Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm600_02InventoryStockView

    Public frm600_02InventoryStockViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer

    Public intLogOnInventoryMPRAccessLevel As Integer

    Private SelectedStockNo As String = ""
    'Private SelectedSalesOrderDate As Date = Date.Today()

#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher()
        Try
            Try
                'Run the Stored Procedure to Get the Current Value
                InsertCurrentInventoryValue()
            Catch ex As Exception

            End Try


            Try
                'Run the Average Cost Definition Table as on the DeliveryDate Value
                InsertStockAverageCostAllItems(Date.Today)

            Catch ex As Exception

            End Try

            If Me.intLogOnInventoryAccessLevel = 99 Then
                Me.Qry600_02InventoryStockViewMasterTableAdapter.FillByAllInUseItems(Me.Dsfrm600_02InventoryStockView.qry600_02InventoryStockViewMaster)
            Else
                Me.Qry600_02InventoryStockViewMasterTableAdapter.FillByGroupInUseItems(Me.Dsfrm600_02InventoryStockView.qry600_02InventoryStockViewMaster, intLogOnInventoryAccessLevel)
            End If

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Inventory Stock Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function InsertStockAverageCostAllItems(ByVal ClosingDate As Date) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "[sp600_26InsertStockAvgCostPriceAllItems]"
            SqlCommand1.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = ClosingDate

            Return SqlCommand1.ExecuteNonQuery()

        Catch ex As Exception
            'MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return 0
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub InsertCurrentInventoryValue()
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp651_01InsertInventoryTransactions"
            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            'MessageBox.Show("Quotation Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public Sub ShowRecords()
        'Check the Dates are correct
        'Retrieve records
        RetrieveVoucher()
        'Update Tiles
        Me.UpdateFrames()

    End Sub


    Private Sub UpdateFrames()
        Dim nwTile As TileItem = Me.tilePendingTasks
        'Deliveries Today
        nwTile.Frames(0).Elements(1).Text = "You have"
        nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(GetNoOfDeliveriesToday())
        nwTile.Frames(0).Elements(3).Text = "Deliveries"
        nwTile.Frames(0).Elements(4).Text = "Today"

        'No of Quotations waiting for Approval
        nwTile.Frames(1).Elements(1).Text = "You have"
        nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(GetNoOfQuotationNotApproved())
        nwTile.Frames(1).Elements(3).Text = "Quotation Waiting"
        nwTile.Frames(1).Elements(4).Text = "Approval"

        'No of Stock Items added today
        'No of Quotations waiting for Approval
        nwTile.Frames(2).Elements(1).Text = "You have"
        If Me.intLogOnInventoryAccessLevel = 99 Then
            nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry600_02InventoryStockViewMasterTableAdapter.GetNoOfItemsToday())
        Else
            nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry600_02InventoryStockViewMasterTableAdapter.GetNoOfItemsTodayInGroup(Me.intLogOnInventoryAccessLevel))
        End If

        nwTile.Frames(2).Elements(3).Text = "Items Added"
        nwTile.Frames(2).Elements(4).Text = "Today"

        Dim nwTile2 As TileItem = Me.tileAllItems
        If Me.intLogOnInventoryAccessLevel = 99 Then
            nwTile2.Elements(0).Text = ConvertIfNullInt(Me.Qry600_02InventoryStockViewMasterTableAdapter.GetNoOfItems())
        Else
            nwTile2.Elements(0).Text = ConvertIfNullInt(Me.Qry600_02InventoryStockViewMasterTableAdapter.GetNoOfItemsInGroup(Me.intLogOnInventoryAccessLevel))
        End If

        nwTile2.Elements(1).Text = "No of Items"

    End Sub


#End Region

    Public Sub ImplementAccess(ByVal UserID As Integer)
        If GetUserAccess(UserID, "frm600_02InventoryStockView_FullAccess") = True Then
            Me.btnRefresh.Enabled = True
            Me.btnSaveLayout.Enabled = True
            Me.btnOpenLayout.Enabled = True
            Me.btnSetDefaultLayout.Enabled = True
            Me.btnPrint.Enabled = True
            Me.btnSearch.Enabled = True
            Me.btnGroup.Enabled = True
            Me.btnRptWithExpiryDate.Enabled = True
            Me.btnInventoryByDate.Enabled = True
            Me.btnInventoryByStore.Enabled = True
            Me.btnInventoryByStoreByDate.Enabled = True
            Me.btnAddNewStock.Enabled = True
            Me.btnEditStock.Enabled = True
            Me.btnDeleteStock.Enabled = True
            Me.btnViewStockDetails.Enabled = True

        Else
            Me.btnRefresh.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnRefresh")
            Me.btnSaveLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnSaveLayout")
            Me.btnOpenLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnOpenLayout")
            Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnResetLayout")
            Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnSetDefaultLayout")
            Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnPrint")
            Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnSearch")
            Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnGroup")
            Me.btnRptWithExpiryDate.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnRptWithExpiryDate")
            Me.btnInventoryByDate.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnInventoryByDate")
            Me.btnInventoryByStore.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnInventoryByStore")
            Me.btnInventoryByStoreByDate.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnInventoryByStoreByDate")
            Me.btnAddNewStock.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnAddNewStock")
            Me.btnEditStock.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnEditStock")
            Me.btnDeleteStock.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_btnDeleteStock")


            Me.colCostPrice.Visible = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_CostPrice_Visible")
            Me.colCostPrice.OptionsColumn.AllowShowHide = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_CostPrice_Visible")
            Me.colAverageCostUnitPrice.OptionsColumn.AllowShowHide = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_CostPrice_Visible")

            Me.btnViewStockDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_02InventoryStockView_ViewStockItemDetails")

        End If
    End Sub
    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_02InventoryStockViewIsClosed = True
    End Sub

    Private Sub btnSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        If Me.gvAdvBandedInvoiceView.OptionsView.ShowAutoFilterRow = True Then
            Me.gvAdvBandedInvoiceView.OptionsView.ShowAutoFilterRow = False
        Else
            Me.gvAdvBandedInvoiceView.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub

    Private Sub btnPrintDatabase_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick

        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem.Document.AutoFitToPagesWidth = 1
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnAllowGrouping_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroup.ItemClick
        If Me.gvAdvBandedInvoiceView.OptionsView.ShowGroupPanel = True Then
            Me.gvAdvBandedInvoiceView.OptionsView.ShowGroupPanel = False
        Else
            Me.gvAdvBandedInvoiceView.OptionsView.ShowGroupPanel = True
        End If
    End Sub

    Private Sub gvAccountDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvAdvBandedInvoiceView.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedStockNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("GSCode"))
                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenStockItem(ByVal StockNo As String)
        Try
            If CheckIfNull(StockNo) = False Then

                Dim frm600_01InventoryStockEdit As New frm600_01InventoryStockEdit
                frm600_01InventoryStockEdit.objForm = Me
                frm600_01InventoryStockEdit.isExecutedFrom_frm600_02InventoryStockView = True

                frm600_01InventoryStockEdit.strLogOnUser = Me.strLogOnUser
                frm600_01InventoryStockEdit.intLogOnUserID = Me.intLogOnUserID
                frm600_01InventoryStockEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                frm600_01InventoryStockEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm600_01InventoryStockEdit.intLogOnDivision = Me.intLogOnDivision
                frm600_01InventoryStockEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                frm600_01InventoryStockEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

                frm600_01InventoryStockEdit.txtStockCode.EditValue = StockNo
                frm600_01InventoryStockEdit.Show()

                frm600_01InventoryStockEdit.FillDataSetforEditing(StockNo)
                frm600_01InventoryStockEdit.btnSave.Caption = "Update"
                frm600_01InventoryStockEdit.txtStockCode.Enabled = False

                frm600_01InventoryStockEdit.txtItemName.Focus()

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnEditStock_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditStock.ItemClick
        Me.OpenStockItem(Me.SelectedStockNo)
    End Sub

    Private Sub frm601_04SalesOrderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ShowRecords()

        Me.ImplementAccess(Me.intLogOnUserID)

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm600_02InventoryStockView", Me.gvAdvBandedInvoiceView)
    End Sub


    Private Sub repoQuoteNo_Click(sender As Object, e As EventArgs) Handles repoQuoteNo.Click
        Dim strStockNo As String = Me.gvAdvBandedInvoiceView.GetRowCellValue(Me.gvAdvBandedInvoiceView.FocusedRowHandle, "GSCode")
        If CheckIfNull(strStockNo) = True Then
            MessageBox.Show("Please select the Stock Code to edit.", "Select Stock Code to edit", MessageBoxButtons.OK)
        Else
            Me.OpenStockItem(strStockNo)
        End If
    End Sub

    Private Sub btnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteStock.ItemClick
        Try

            'Check before deleting... if the Item has records in VAT Invoice / other Registers
            'Important XXXXXXXXXXXXXX
            If CheckIfItemHasInvoice(Me.SelectedStockNo) = True Then
                MessageBox.Show("This Item has been generated in Invoice.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsQuoted
            If CheckIfItemIsQuoted(Me.SelectedStockNo) = True Then
                MessageBox.Show("This Item has been Quoted in Quotation Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInSalesOrder
            If CheckIfItemIsInSalesOrder(Me.SelectedStockNo) = True Then
                MessageBox.Show("This Item has been added in Sales Order Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInDeliveryNote
            If CheckIfItemIsInDeliveryNote(Me.SelectedStockNo) = True Then
                MessageBox.Show("This Item has been Delivered in Delivery Note Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInRFQ
            If CheckIfItemIsInRFQ(Me.SelectedStockNo) = True Then
                MessageBox.Show("This Item has been added in RFQ Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInMaterialRequest
            If CheckIfItemIsInMaterialRequest(Me.SelectedStockNo) = True Then
                MessageBox.Show("This Item has been added in Material Request / Enquiry Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInPurchaseOrder
            If CheckIfItemIsInPurchaseOrder(Me.SelectedStockNo) = True Then
                MessageBox.Show("This Item has been added in Purchase Order.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInMaterialReceipt
            If CheckIfItemIsInMaterialReceipt(Me.SelectedStockNo) = True Then
                MessageBox.Show("This Item has been added in Material Receipt Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Inventory Stock Item from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedStockNo) = False Then
                    If DeleteStockItem(Me.SelectedStockNo) = True Then
                        MessageBox.Show("Inventory Stock Item has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("Inventory Item", "Inventory Master Item Code." & Me.SelectedStockNo & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedStockNo)

                        'Refresh the datagrid
                        Me.RetrieveVoucher()
                    Else
                        MessageBox.Show("Deleting Failed, please try again.", "Delete Failed", MessageBoxButtons.OK)
                    End If
                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function CheckIfItemHasInvoice(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ItemCode from tbl20162VATInvoiceChild where (ItemCode = '" & StockNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Function CheckIfItemIsQuoted(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl601_02QuotationChild where (GSCode = '" & StockNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Function CheckIfItemIsInSalesOrder(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl602_02SalesOrderChild where (GSCode = '" & StockNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Function CheckIfItemIsInDeliveryNote(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl603_02DeliveryNoteChild where (GSCode = '" & StockNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Function CheckIfItemIsInMaterialRequest(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl606_02PurchaseRequestChild where (GSCode = '" & StockNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function
    Private Function CheckIfItemIsInRFQ(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl607_02RFQChild where (GSCode = '" & StockNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Function CheckIfItemIsInPurchaseOrder(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl604_02PurchaseOrderChild where (GSCode = '" & StockNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Function CheckIfItemIsInMaterialReceipt(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl605_02MaterialReceiptChild where (GSCode = '" & StockNo & "') AND (ReceiptNo <> 'OPENING-BAL')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function
    Private Function DeleteStockItem(ByVal StockNo As String) As Boolean
        Dim myTrans As System.Data.SqlClient.SqlTransaction

        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)

        If Sqlconnection1.State = ConnectionState.Closed Then
            Sqlconnection1.Open()
        End If

        Dim delPRTrans As New SqlClient.SqlCommand
        myTrans = Sqlconnection1.BeginTransaction(IsolationLevel.ReadCommitted, "PRTransaction")
        delPRTrans.Connection = Sqlconnection1
        delPRTrans.Transaction = myTrans
        Try

            delPRTrans.CommandText = "DELETE from tbl20164GoodsAndServicesMaster WHERE GSCode   = '" & StockNo & "'"
            delPRTrans.ExecuteNonQuery()

            delPRTrans.CommandText = "DELETE from tbl605_02MaterialReceiptChild WHERE GSCode   = '" & StockNo & "' and ReceiptNo = 'OPENING-BAL'"
            delPRTrans.ExecuteNonQuery()
         
            myTrans.Commit()
            Return True

        Catch ex As Exception
            Try
                myTrans.Rollback("PRTransaction")
                Return False
            Catch Sqlex As System.Data.SqlClient.SqlException
                If Not myTrans.Connection Is Nothing Then
                    MessageBox.Show("An exception of type " & Sqlex.GetType().ToString() & _
                                      " was encountered while attempting to roll back the transaction.", "Error on Delete", MessageBoxButtons.OK)
                End If
                MessageBox.Show("An exception of type " & ex.GetType().ToString() & _
                                      "was encountered while inserting the data.")
                Return False
            End Try
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub btnAddNewInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewStock.ItemClick

        Try
            Dim frm600_01InventoryStockEdit As New frm600_01InventoryStockEdit
            frm600_01InventoryStockEdit.objForm = Me
            frm600_01InventoryStockEdit.strLogOnUser = Me.strLogOnUser
            frm600_01InventoryStockEdit.intLogOnUserID = Me.intLogOnUserID
            frm600_01InventoryStockEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm600_01InventoryStockEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm600_01InventoryStockEdit.intLogOnDivision = Me.intLogOnDivision
            frm600_01InventoryStockEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel

            frm600_01InventoryStockEdit.btnSave.Caption = "Save"
            frm600_01InventoryStockEdit.isExecutedFrom_frm600_02InventoryStockView = True

            frm600_01InventoryStockEdit.Show()
            frm600_01InventoryStockEdit.FillDataSetforNew()

            frm600_01InventoryStockEdit.txtUnitIssue.EditValue = 1
            frm600_01InventoryStockEdit.txtCostPrice.EditValue = 0
            frm600_01InventoryStockEdit.txtOpeningBalance.EditValue = 0
            frm600_01InventoryStockEdit.txtGSUoM.EditValue = 1

            frm600_01InventoryStockEdit.txtItemName.Focus()
            frm600_01InventoryStockEdit.txtStockCode.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error on Adding Goods & Services Item, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
        SaveFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            'My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
            Dim fileName As String = Me.SaveFileDialog1.FileName
            Me.gvAdvBandedInvoiceView.SaveLayoutToXml(fileName)
        End If
    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenLayout.ItemClick
        OpenFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Me.OpenFileDialog1.FileName
            Me.gvAdvBandedInvoiceView.RestoreLayoutFromXml(fileName)

        End If
    End Sub

    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_02InventoryStockView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvAdvBandedInvoiceView))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvAdvBandedInvoiceView))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnRptWithExpiryDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptWithExpiryDate.ItemClick
        Try
            Dim rpt1 As New rpt602_InventoryWithExpDate
            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogOnUser

            rpt1.Qry652_09ExpDtStockBalanceWithDescTableAdapter.Fill(rpt1.DsRpt602_InventoryWithExpDate1.qry652_09ExpDtStockBalanceWithDesc)
            rpt1.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        ShowRecords()
    End Sub
     
    Private Sub btnInventoryByDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInventoryByDate.ItemClick
        Try
            Dim frm601_22InventoryByDate As New frm601_22InventoryByDate
            frm601_22InventoryByDate.ObjForm = Me

            frm601_22InventoryByDate.strLogOnUser = Me.strLogOnUser
            frm601_22InventoryByDate.intLogOnUserID = Me.intLogOnUserID
            frm601_22InventoryByDate.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_22InventoryByDate.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_22InventoryByDate.intLogOnDivision = Me.intLogOnDivision
            'frm601_22InventoryByDate.intLogOnHRLevelCode = Me.intLogOnHRLevelCode

            'frm601_22InventoryByDate.txtStartDate.EditValue = Me.txtStartDate.EditValue
            'frm601_22InventoryByDate.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm601_22InventoryByDate.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnSaveLayoutToDB_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayoutToDB.ItemClick
        'If e.Button.Index = 1 Then
        '    Dim frm600_05GoodsAndServicesGroups As New frm600_05GoodsAndServicesGroups
        '    frm600_05GoodsAndServicesGroups.ObjForm = Me
        '    frm600_05GoodsAndServicesGroups.Show()
        '    frm600_05GoodsAndServicesGroups.txtGroupName.Focus()
        '    frm600_05GoodsAndServicesGroups.isExecutedFrom_frm600_01InventoryStockEdit = True

        'End If

        'MessageBox.Show("Clicked the button")
    End Sub

    Private Sub repoSaveLayoutToDB_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles repoSaveLayoutToDB.ButtonClick
        Me.btnSaveLayoutToDB.Refresh()
        If e.Button.Index = 0 Then
            'Dim frm600_05GoodsAndServicesGroups As New frm600_05GoodsAndServicesGroups
            'frm600_05GoodsAndServicesGroups.ObjForm = Me
            'frm600_05GoodsAndServicesGroups.Show()
            'frm600_05GoodsAndServicesGroups.txtGroupName.Focus()
            'frm600_05GoodsAndServicesGroups.isExecutedFrom_frm600_01InventoryStockEdit = True
            MessageBox.Show("You added " & Me.btnSaveLayoutToDB.EditValue)
        End If
    End Sub

    Private Sub btnInventoryByStore_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInventoryByStore.ItemClick
        Try
            Dim frm600_07InventoryStockWtStores As New frm600_07InventoryStockWtStores
            frm600_07InventoryStockWtStores.ObjForm = Me

            frm600_07InventoryStockWtStores.strLogOnUser = Me.strLogOnUser
            frm600_07InventoryStockWtStores.intLogOnUserID = Me.intLogOnUserID
            frm600_07InventoryStockWtStores.intLogOnUserLevel = Me.intLogOnUserLevel
            frm600_07InventoryStockWtStores.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm600_07InventoryStockWtStores.intLogOnDivision = Me.intLogOnDivision
            'frm601_22InventoryByDate.intLogOnHRLevelCode = Me.intLogOnHRLevelCode

            'frm601_22InventoryByDate.txtStartDate.EditValue = Me.txtStartDate.EditValue
            'frm601_22InventoryByDate.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm600_07InventoryStockWtStores.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnInventoryByStoreByDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInventoryByStoreByDate.ItemClick
        Try
            Dim frm600_08InventoryStockStoresByDate As New frm600_08InventoryStockStoresByDate
            frm600_08InventoryStockStoresByDate.ObjForm = Me

            frm600_08InventoryStockStoresByDate.strLogOnUser = Me.strLogOnUser
            frm600_08InventoryStockStoresByDate.intLogOnUserID = Me.intLogOnUserID
            frm600_08InventoryStockStoresByDate.intLogOnUserLevel = Me.intLogOnUserLevel
            frm600_08InventoryStockStoresByDate.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm600_08InventoryStockStoresByDate.intLogOnDivision = Me.intLogOnDivision
            'frm601_22InventoryByDate.intLogOnHRLevelCode = Me.intLogOnHRLevelCode

            'frm601_22InventoryByDate.txtStartDate.EditValue = Me.txtStartDate.EditValue
            'frm601_22InventoryByDate.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm600_08InventoryStockStoresByDate.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        'Check if the user has layout specified... then reset the layout
        Try
            Dim formID As String = "frm600_02InventoryStockView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowItemsDiscontinued_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowItemsDiscontinued.ItemClick
        Try
            If Me.intLogOnInventoryAccessLevel = 99 Then
                Me.Qry600_02InventoryStockViewMasterTableAdapter.FillByAllDiscontinuedItems(Me.Dsfrm600_02InventoryStockView.qry600_02InventoryStockViewMaster)
            Else
                Me.Qry600_02InventoryStockViewMasterTableAdapter.FillByGroupDiscontinuedItems(Me.Dsfrm600_02InventoryStockView.qry600_02InventoryStockViewMaster, intLogOnInventoryAccessLevel)
            End If

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Inventory Stock Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowAllItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowAllItems.ItemClick
        Try
            If Me.intLogOnInventoryAccessLevel = 99 Then
                Me.Qry600_02InventoryStockViewMasterTableAdapter.FillAllInventoryItems(Me.Dsfrm600_02InventoryStockView.qry600_02InventoryStockViewMaster)
            Else
                Me.Qry600_02InventoryStockViewMasterTableAdapter.FillByGroupInventoryItemsFull(Me.Dsfrm600_02InventoryStockView.qry600_02InventoryStockViewMaster, intLogOnInventoryAccessLevel)
            End If

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Inventory Stock Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowItemsInUse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowItemsInUse.ItemClick
        RetrieveVoucher()
    End Sub

    Private Sub btnViewStockDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnViewStockDetails.ItemClick
        ViewStockItem(Me.SelectedStockNo)
    End Sub

    Private Sub ViewStockItem(ByVal StockNo As String)
        Try
            If CheckIfNull(StockNo) = False Then

                Dim frm600_01InventoryStockEdit As New frm600_01InventoryStockEdit
                frm600_01InventoryStockEdit.objForm = Me
                frm600_01InventoryStockEdit.isExecutedFrom_frm600_02InventoryStockView = True

                frm600_01InventoryStockEdit.strLogOnUser = Me.strLogOnUser
                frm600_01InventoryStockEdit.intLogOnUserID = Me.intLogOnUserID
                frm600_01InventoryStockEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                frm600_01InventoryStockEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm600_01InventoryStockEdit.intLogOnDivision = Me.intLogOnDivision
                frm600_01InventoryStockEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                frm600_01InventoryStockEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

                frm600_01InventoryStockEdit.txtStockCode.EditValue = StockNo
                frm600_01InventoryStockEdit.Show()

                frm600_01InventoryStockEdit.FillDataSetforEditing(StockNo)
                frm600_01InventoryStockEdit.btnSave.Caption = "Update"
                frm600_01InventoryStockEdit.txtStockCode.Enabled = False

                frm600_01InventoryStockEdit.DisableAllControls()


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnInventoryByStorePivot_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInventoryByStorePivot.ItemClick
        Try
            Dim frm600_16StockPivotReportByStores As New frm600_16StockPivotReportByStores
            frm600_16StockPivotReportByStores.ObjForm = Me

            frm600_16StockPivotReportByStores.strLogonUser = Me.strLogOnUser
            frm600_16StockPivotReportByStores.intLogOnUserID = Me.intLogOnUserID
            frm600_16StockPivotReportByStores.intLogOnUserLevel = Me.intLogOnUserLevel
            frm600_16StockPivotReportByStores.intLogOnAccessLevel = Me.intLogOnAccessLevel
            'frm600_07InventoryStockWtStores.intLogOnDivision = Me.intLogOnDivision
            'frm601_22InventoryByDate.intLogOnHRLevelCode = Me.intLogOnHRLevelCode

            'frm601_22InventoryByDate.txtStartDate.EditValue = Me.txtStartDate.EditValue
            'frm601_22InventoryByDate.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm600_16StockPivotReportByStores.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnStockMovementReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStockMovementReport.ItemClick
        Try
            Dim frm600_17StockMovementReport As New frm600_17StockMovementReport
            frm600_17StockMovementReport.ObjForm = Me

            frm600_17StockMovementReport.strLogOnUser = Me.strLogOnUser
            frm600_17StockMovementReport.intLogOnUserID = Me.intLogOnUserID
            frm600_17StockMovementReport.intLogOnUserLevel = Me.intLogOnUserLevel
            frm600_17StockMovementReport.intLogOnAccessLevel = Me.intLogOnAccessLevel
            'frm600_07InventoryStockWtStores.intLogOnDivision = Me.intLogOnDivision
            'frm601_22InventoryByDate.intLogOnHRLevelCode = Me.intLogOnHRLevelCode

            'frm601_22InventoryByDate.txtStartDate.EditValue = Me.txtStartDate.EditValue
            'frm600_17StockMovementReport.txtEndDate.EditValue = Me.txtEndDate.EditValue
            frm600_17StockMovementReport.IsOnlyOneStockItem = False
            frm600_17StockMovementReport.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub
End Class