Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_28JobOrdersView
    Public frm601_28JobOrdersViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Private SelectedJobOrderNo As String = ""
    Private SelectedJobOrderDate As Date = Date.Today()
    Private SelectedClientCode As String = ""
    Private SelectedJOStatus As Integer = 1

    Private SelectedClientPONo As String = ""
    Private SelectedClientPODate As Date = Date.Today()
    Private SelectedQuotationNo As String = ""
    Private SelectedCompany As Integer = 1
    Private SelectedSalesPerson As String = ""


#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            Me.Qry608_01JobOrdersViewTableAdapter.FillByJobOrderDate(Me.Dsfrm601_28JobOrdersView.qry608_01JobOrdersView, StartDate, EndDate)

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Job Order Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ShowRecords()
        'Check the Dates are correct
        'Retrieve records
        RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        'Update Tiles
        Me.UpdateFrames()

    End Sub

    Private Sub btnToday_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnToday.ItemClick
        Me.txtStartDate.EditValue = Date.Today
        Me.txtEndDate.EditValue = Date.Today
        ShowRecords()
    End Sub

    Private Sub btnYesterday_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnYesterday.ItemClick
        Me.txtStartDate.EditValue = DateAdd(DateInterval.Day, -1, Date.Today)
        Me.txtEndDate.EditValue = DateAdd(DateInterval.Day, -1, Date.Today)
        ShowRecords()
    End Sub


    'this week
    Private Sub btnThisWeek_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisWeek.ItemClick
        Dim today As Date = Date.Today
        Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Saturday
        Dim SaturDay As Date = today.AddDays(-dayDiff)

        Me.txtStartDate.EditValue = DateAdd(DateInterval.Day, -7, SaturDay)
        Me.txtEndDate.EditValue = DateAdd(DateInterval.Day, -1, SaturDay)

        ShowRecords()
    End Sub

    Private Sub btnThisYearTillDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisYearTillDate.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 1, 1)
        Me.txtEndDate.EditValue = Date.Today
        ShowRecords()
    End Sub

    'this year full
    Private Sub btnThisYearfull_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisYear.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 1, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()

    End Sub

    Private Sub btnThisMonthTillDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisMonthTillDate.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = Date.Today
        ShowRecords()
    End Sub

    'this month
    Private Sub btnFillThisMonth_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisMonthFull.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()
    End Sub

    'Last Year
    Private Sub btnLastYear_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLastYear.ItemClick
        Dim LastYearDate As Date = DateAdd(DateInterval.Year, -1, Date.Today)
        Me.txtStartDate.EditValue = DateSerial(LastYearDate.Year, 1, 1)
        Me.txtEndDate.EditValue = DateSerial(LastYearDate.Year, 12, 31)
        ShowRecords()

    End Sub


    Private Sub btnLastMonth_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLastMonth.ItemClick
        Dim LastMonthThisDate As Date = DateAdd(DateInterval.Month, -1, Date.Today)

        Me.txtStartDate.EditValue = DateSerial(LastMonthThisDate.Year, LastMonthThisDate.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(LastMonthThisDate.Year, LastMonthThisDate.Month, Date.DaysInMonth(LastMonthThisDate.Year, LastMonthThisDate.Month))

        ShowRecords()
    End Sub

    Private Sub UpdateFrames()
        Dim nwTile As TileItem = Me.tilePendingTasks
        'No of Sales Order Generated Today
        nwTile.Frames(0).Elements(1).Text = "You have"
        nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry608_01JobOrdersViewTableAdapter.GetNoOfJobOrdersAddedToday())
        nwTile.Frames(0).Elements(3).Text = "New Job Order's"
        nwTile.Frames(0).Elements(4).Text = "Today"

        'No of Sales Order's waiting for Approval
        nwTile.Frames(1).Elements(1).Text = "You have"
        nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry608_01JobOrdersViewTableAdapter.GetNoOfJobOrderToDispatch())
        nwTile.Frames(1).Elements(3).Text = "Waiting for Dispatch"
        'nwTile.Frames(1).Elements(4).Text = "To Dispatch"

        'Deliveries Today
        nwTile.Frames(2).Elements(1).Text = "You have"
        nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry608_01JobOrdersViewTableAdapter.GetNoOfJobOrderOnProcess())
        nwTile.Frames(2).Elements(3).Text = "Job Order's On Process"
        nwTile.Frames(2).Elements(4).Text = "Today"

        Dim nwTile3 As TileItem = Me.tileAllAssets
        nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry608_01JobOrdersViewTableAdapter.GetNoOfJobOrders(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue))

    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub

#End Region
    Public Sub ImplementAccess(ByVal UserID As Integer)
        Try
            'If GetUserAccess(UserID, "frm601_04SalesOrderView_FullAccess") = True Then

            '    Me.btnShowAllRecords.Enabled = True
            '    Me.btnSaveLayout.Enabled = True
            '    Me.btnOpenLayout.Enabled = True
            '    Me.btnResetLayout.Enabled = True
            '    Me.btnSetDefaultLayout.Enabled = True
            '    Me.btnPrint.Enabled = True
            '    Me.btnSearch.Enabled = True
            '    Me.btnGroup.Enabled = True
            '    Me.btnSalesOrderDetails.Enabled = True
            '    Me.btnAddNewSalesOrder.Enabled = True
            '    Me.btnEditSalesOrder.Enabled = True
            '    Me.btnUnlockSalesOrder.Enabled = True
            '    Me.btnDeleteSalesOrder.Enabled = True
            '    Me.btnCreatePartialDelivery.Enabled = True
            '    Me.btnCreateFullDelivery.Enabled = True
            '    Me.btnCreateInvoice.Enabled = True

            'Else
            '    Me.btnShowAllRecords.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnShowAllRecords")
            '    Me.btnSaveLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnSaveLayout")
            '    Me.btnOpenLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnOpenLayout")
            '    Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnResetLayout")
            '    Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnSetDefaultLayout")
            '    Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnPrint")
            '    Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnSearch")
            '    Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnGroup")
            '    Me.btnSalesOrderDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnSalesOrderDetails")
            '    Me.btnAddNewSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnAddNewSalesOrder")
            '    Me.btnEditSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnEditSalesOrder")
            '    Me.btnUnlockSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnUnlockSalesOrder")
            '    Me.btnDeleteSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnDeleteSalesOrder")
            '    Me.btnCreatePartialDelivery.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnCreatePartialDelivery")
            '    Me.btnCreateFullDelivery.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnCreateFullDelivery")
            '    Me.btnCreateInvoice.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnCreateInvoice")

            'End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub frm601_28JobOrdersView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_28JobOrdersViewIsClosed = True
    End Sub

    Private Sub btnSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        If Me.gvAdvBandedQuotationView.OptionsView.ShowAutoFilterRow = True Then
            Me.gvAdvBandedQuotationView.OptionsView.ShowAutoFilterRow = False
        Else
            Me.gvAdvBandedQuotationView.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub

    Private Sub btnPrintDatabase_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnAllowGrouping_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroup.ItemClick
        If Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = True Then
            Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = False
        Else
            Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = True
        End If
    End Sub

    Private Sub gvAccountDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvAdvBandedQuotationView.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedJobOrderNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("JobOrderNo"))
                SelectedJobOrderDate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("JobOrderDate"))

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))) = False Then
                    SelectedClientCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))
                Else
                    SelectedClientCode = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("JobOrderStatus"))) = False Then
                    SelectedJOStatus = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("JobOrderStatus"))
                Else
                    SelectedJOStatus = 0
                End If

                'If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientPONo"))) = False Then
                '    SelectedClientPONo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientPONo"))
                'Else
                '    SelectedClientPONo = ""
                'End If

                'If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientPODate"))) = False Then
                '    SelectedClientPODate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientPODate"))
                'Else
                '    SelectedClientPODate = Date.Today()
                'End If

                'If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("QuoteNo"))) = False Then
                '    SelectedQuotationNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("QuoteNo"))
                'Else
                '    SelectedQuotationNo = ""
                'End If

                'If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SalesPersonCode"))) = False Then
                '    SelectedSalesPerson = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SalesPersonCode"))
                'Else
                '    SelectedSalesPerson = ""
                'End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("CompanyBranch"))) = False Then
                    SelectedCompany = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("CompanyBranch"))
                Else
                    SelectedCompany = 1
                End If

                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenJobOrder(ByVal JobOrderNo As String)
        If CheckIfNull(JobOrderNo) = False Then
            Dim frm601_27JobOrderEdit02 As New frm601_27JobOrderEdit02
            frm601_27JobOrderEdit02.ObjForm = Me
            frm601_27JobOrderEdit02.txtJobOrderNo.Enabled = False
            frm601_27JobOrderEdit02.btnSave.Caption = "Update"
            frm601_27JobOrderEdit02.strLogonUser = Me.strLogOnUser
            frm601_27JobOrderEdit02.intLogOnUserID = Me.intLogOnUserID
            frm601_27JobOrderEdit02.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_27JobOrderEdit02.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_27JobOrderEdit02.intLogOnDivision = Me.intLogOnDivision
            frm601_27JobOrderEdit02.isExecutedFrom_frm601_28JobOrdersView = True
            frm601_27JobOrderEdit02.Show()

            frm601_27JobOrderEdit02.RetrieveJobOrderMaster(JobOrderNo)

            frm601_27JobOrderEdit02.txtJobOrderNo.Enabled = False
            frm601_27JobOrderEdit02.txtWorkOrderNo.Enabled = False
            frm601_27JobOrderEdit02.txtClientName.Enabled = False

            frm601_27JobOrderEdit02.DisableApprovedVoucherEditing(JobOrderNo)
            frm601_27JobOrderEdit02.DisableControlsByStatus(Me.SelectedJOStatus)

        End If
    End Sub
    Private Sub btnPopupEditQuotation_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditJobOrder.ItemClick
        Me.OpenJobOrder(Me.SelectedJobOrderNo)
    End Sub

    Private Sub frm601_04SalesOrderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()

        Me.ImplementAccess(Me.intLogOnUserID)

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_28JobOrdersView", Me.gvAdvBandedQuotationView)
    End Sub


    Private Sub repoQuoteNo_Click(sender As Object, e As EventArgs) Handles repoQuoteNo.Click
        Dim strJobOrderNo As String = Me.gvAdvBandedQuotationView.GetRowCellValue(Me.gvAdvBandedQuotationView.FocusedRowHandle, "JobOrderNo")
        If CheckIfNull(strJobOrderNo) = True Then
            MessageBox.Show("Please select the Job Order No. to edit.", "Select Job Order No. to edit", MessageBoxButtons.OK)
        Else
            Me.OpenJobOrder(strJobOrderNo)
        End If
    End Sub

    Private Sub btnDeleteJobOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteJobOrder.ItemClick
        Try
            'Check if the Voucher is approved already
            If CheckIfJobOrderIsApproved(Me.SelectedJobOrderNo) = True Then
                MessageBox.Show("Job Order is already delivered, You cannot delete the delivered Job Order", "Job Order delivered", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Job Order from the Register," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedJobOrderNo) = False Then
                    If DeleteJobOrder(Me.SelectedJobOrderNo) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.SelectedJobOrderNo, "VoucherScanned\IMSJO")

                        MessageBox.Show("Job Order has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Refresh the datagrid
                        Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
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


    Private Function CheckIfJobOrderIsApproved(ByVal JobOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select JobOrderNo from tbl608_01JobOrderMaster where (JobOrderNo = '" & JobOrderNo & "') and (Isnull(JobOrderStatus,0) = 1 )"

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
    Private Function DeleteJobOrder(ByVal JobOrderNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl608_01JobOrderMaster WHERE JobOrderNo   = '" & JobOrderNo & "'"
            delPRTrans.ExecuteNonQuery()

            delPRTrans.CommandText = "DELETE from tbl608_05JobOrderTests WHERE JobOrderNo   = '" & JobOrderNo & "'"
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

    Private Sub btnAddNewInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewSalesOrder.ItemClick
        'Dim frm601_03SalesOrderEdit As New frm601_03SalesOrderEdit
        'frm601_03SalesOrderEdit.ObjForm = Me

        'frm601_03SalesOrderEdit.btnSave.Caption = "Save"
        'frm601_03SalesOrderEdit.isBeingNew = True
        'frm601_03SalesOrderEdit.strLogonUser = Me.strLogOnUser
        'frm601_03SalesOrderEdit.intLogOnUserID = Me.intLogOnUserID
        'frm601_03SalesOrderEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        'frm601_03SalesOrderEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        'frm601_03SalesOrderEdit.intLogOnDivision = Me.intLogOnDivision
        'frm601_03SalesOrderEdit.isExecutedFrom_frm601_04SalesOrderView = True
        'frm601_03SalesOrderEdit.Show()



        'GetCompanyDetails(1)
        'Dim NewSalesOrderNo As String = frm601_03SalesOrderEdit.GetNewSalesOrderNo(gSalesOrderAbbrv, gInvoiceYearDigits)
        'frm601_03SalesOrderEdit.CreatedNewSalesOrderNo = NewSalesOrderNo
        'frm601_03SalesOrderEdit.NewSalesOrderMaster(NewSalesOrderNo)
        'frm601_03SalesOrderEdit.txtSalesOrderNo.EditValue = NewSalesOrderNo
        'frm601_03SalesOrderEdit.txtSalesOrderDate.EditValue = Date.Today
        'frm601_03SalesOrderEdit.UpdateDefaultFields()

    End Sub

    Private Sub btnUnlockInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnlockSalesOrder.ItemClick
        If Me.intLogOnUserLevel = 99 Then
            Me.UnlockTheJobOrder(Me.SelectedJobOrderNo)
            MessageBox.Show("Job Order has been unlocked successfully.", "Job Order Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Refresh the screen
            Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        Else
            MessageBox.Show("Your user access level cannot unlock the Job Order, Please review again.", "Access Permission Denied.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If

    End Sub

    Private Function UnlockTheJobOrder(ByVal JobOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl608_01JobOrderMaster Set IsApproved = 0, ApprovedBy = ''  where JobOrderNo = '" & JobOrderNo & "'"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim int1 As Integer = SqlCommand1.ExecuteNonQuery()
            If int1 = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function


    Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
        SaveFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            'My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
            Dim fileName As String = Me.SaveFileDialog1.FileName
            Me.gvAdvBandedQuotationView.SaveLayoutToXml(fileName)
        End If
    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenLayout.ItemClick
        OpenFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Me.OpenFileDialog1.FileName
            Me.gvAdvBandedQuotationView.RestoreLayoutFromXml(fileName)

        End If
    End Sub

    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_28JobOrdersView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvAdvBandedQuotationView))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvAdvBandedQuotationView))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBy1stQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy1stQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 1, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 3, 31)

        ShowRecords()
    End Sub

    Private Sub btnBy2ndQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy2ndQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 4, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 6, 30)

        ShowRecords()
    End Sub

    Private Sub btnBy3rdQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy3rdQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 7, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 9, 30)

        ShowRecords()
    End Sub

    Private Sub btnBy4thQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy4thQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 10, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 12, 31)

        ShowRecords()
    End Sub

    'Private Sub btnDuplicateInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDuplicateInvoice.ItemClick
    '    'Duplicate the Invoice
    '    Try
    '        Dim DialogResult As DialogResult
    '        DialogResult = MessageBox.Show("You are about to Duplicate this Invoice." & vbCrLf & "Are you Sure want to Continue?", "Confirm Duplication.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

    '        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
    '            If CheckIfNull(Me.SelectedInvoiceNo) = False Then
    '                If CheckIfNull(Me.SelectedInvoiceDate) = False Then
    '                    'Get a new Invoice No
    '                    GetCompanyDetails()
    '                    Dim NewInvoiceNo As String = frm20161VATInvoiceEdit.GetNewInvoiceNo("", gInvoiceYearDigits)

    '                    If DuplicateVATInvoice(Me.SelectedInvoiceNo, NewInvoiceNo, Me.SelectedInvoiceDate, Me.strLogOnUser, Date.Now) = True Then
    '                        MessageBox.Show("Invoice has been successfully added to the database.", "Data insertion Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        'Refresh datagrid
    '                        Me.ShowRecords()
    '                    Else
    '                        MessageBox.Show("Invoice duplication Failed, please try again.", "Insertion Failed", MessageBoxButtons.OK)
    '                    End If
    '                End If
    '            End If

    '        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
    '            Exit Sub
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub btnInvoiceDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvoiceDetails.ItemClick
    '    Try
    '        Dim frm20172VATInvoiceWithDetails As New frm20172VATInvoiceWithDetails
    '        frm20172VATInvoiceWithDetails.ObjForm = Me

    '        frm20172VATInvoiceWithDetails.Show()

    '        frm20172VATInvoiceWithDetails.strLogOnUser = Me.strLogOnUser
    '        frm20172VATInvoiceWithDetails.intLogOnUserID = Me.intLogOnUserID
    '        frm20172VATInvoiceWithDetails.intLogOnUserLevel = Me.intLogOnUserLevel
    '        frm20172VATInvoiceWithDetails.intLogOnAccessLevel = Me.intLogOnAccessLevel
    '        frm20172VATInvoiceWithDetails.intLogOnDivision = Me.intLogOnDivision

    '        frm20172VATInvoiceWithDetails.txtStartDate.EditValue = Me.txtStartDate.EditValue
    '        frm20172VATInvoiceWithDetails.txtEndDate.EditValue = Me.txtEndDate.EditValue
    '        frm20172VATInvoiceWithDetails.txtUseEffectiveDate.EditValue = Me.txtUseEffectiveDate.EditValue


    '    Catch ex As Exception
    '        'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
    '    End Try
    'End Sub


    'Private Sub btnCreateFullDelivery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateFullDelivery.ItemClick

    '    'Check if the Items are partially delivered or fully delivered already for this Sales Order

    '    'If CheckSalesOrderDeliveryStatus(Me.SelectedJobOrderNo) = "Fully Delivered" Then
    '    '    MessageBox.Show("Sales Order is fully Delivered, you cannot create Delivery for this Order anymore, Please review again.", "Sales Order status is Fully Delivered.", MessageBoxButtons.OK)
    '    '    Exit Sub

    '    'End If

    '    'If CheckSalesOrderDeliveryStatus(Me.SelectedJobOrderNo) = "Partially Delivered" Then
    '    '    MessageBox.Show("Sales Order is partially Delivered, you cannot create Full Delivery for this Order anymore, Please review again.", "Sales Order status is Partially Delivered.", MessageBoxButtons.OK)
    '    '    Exit Sub

    '    'End If

    '    DialogResult = MessageBox.Show("You are about to create new Delivery Note." & vbCrLf & "Are you Sure want to continue creating Delivery Note?", "Confirm creating Delivery Note.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

    '    If DialogResult = System.Windows.Forms.DialogResult.Yes Then
    '        If CheckIfNull(Me.SelectedSalesOrderNo) = False Then

    '            'Get New Delivery Note Number
    '            GetCompanyDetails(1)
    '            Dim NewDeliveryNoteNo As String = Me.GetNewDeliveryNoteNo(gDeliveryNoteAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote)

    '            Me.CreateFullDeliveryFromSalesOrder(NewDeliveryNoteNo, 1, Me.SelectedSalesOrderNo, Me.strLogOnUser)
    '            Me.OpenDeliveryNote(NewDeliveryNoteNo)

    '            ''Refresh the datagrid
    '            ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

    '        End If
    '    ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
    '        Exit Sub
    '    End If
    'End Sub


    'Private Sub OpenDeliveryNote(ByVal DeliveryNoteNo As String)
    '    If CheckIfNull(DeliveryNoteNo) = False Then
    '        Dim frm601_05DeliveryNoteEdit As New frm601_05DeliveryNoteEdit
    '        frm601_05DeliveryNoteEdit.ObjForm = Me
    '        frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
    '        frm601_05DeliveryNoteEdit.btnSave.Caption = "Update"
    '        frm601_05DeliveryNoteEdit.strLogonUser = Me.strLogOnUser
    '        frm601_05DeliveryNoteEdit.intLogOnUserID = Me.intLogOnUserID
    '        frm601_05DeliveryNoteEdit.intLogOnUserLevel = Me.intLogOnUserLevel
    '        frm601_05DeliveryNoteEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
    '        frm601_05DeliveryNoteEdit.intLogOnDivision = Me.intLogOnDivision
    '        frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_04SalesOrderView = True
    '        frm601_05DeliveryNoteEdit.Show()



    '        frm601_05DeliveryNoteEdit.RetrieveDeliveryMaster(DeliveryNoteNo)

    '        frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
    '        frm601_05DeliveryNoteEdit.DisableApprovedVoucherEditing(DeliveryNoteNo)

    '    End If
    'End Sub
    'Private Sub CreateFullDeliveryFromSalesOrder(ByVal DeliveryNoteNo As String, ByVal DeliveryType As Integer, ByVal SalesOrderNo As String, ByVal AddedBy As String)
    '    Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
    '    Try
    '        If Sqlconnection1.State = ConnectionState.Closed Then
    '            Sqlconnection1.Open()
    '        End If

    '        Dim SqlCommand1 As New SqlClient.SqlCommand
    '        SqlCommand1.Connection = Sqlconnection1
    '        SqlCommand1.CommandType = CommandType.StoredProcedure
    '        SqlCommand1.CommandText = "sp600_05InsertToDeliveryNoteFromSalesOrder"
    '        Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
    '        Dim paramDeliveryType As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryType", SqlDbType.TinyInt)
    '        Dim paramSalesOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderNo", SqlDbType.VarChar)
    '        Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

    '        paramDeliveryNoteNo.Value = DeliveryNoteNo
    '        paramDeliveryType.Value = DeliveryType
    '        paramSalesOrderNo.Value = SalesOrderNo
    '        paramAddedBy.Value = AddedBy

    '        SqlCommand1.ExecuteNonQuery()
    '        MessageBox.Show("New Delivery Note is created successfully,", "Delivery Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    Catch ex As System.InvalidCastException
    '        MessageBox.Show("Delivery Note Creation failed, Please try again", "Delivery Note Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Finally
    '        Sqlconnection1.Close()
    '    End Try
    'End Sub
    'Public Function GetNewDeliveryNoteNo(ByVal DeliveryNoteAbbr As String, ByVal YearInDigit As Integer, ByVal NoOfDigits As Integer) As String
    '    Dim strNewQuotationNo As String = ""
    '    Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
    '    Try
    '        If Sqlconnection1.State = ConnectionState.Closed Then
    '            Sqlconnection1.Open()
    '        End If

    '        Dim SqlCommand1 As New SqlClient.SqlCommand
    '        SqlCommand1.Connection = Sqlconnection1
    '        SqlCommand1.CommandText = "select max(cast(right(DeliveryNoteNo," & NoOfDigits & ") as int)) from tbl603_01DeliveryNoteMaster"
    '        Dim int1 As Integer
    '        int1 = SqlCommand1.ExecuteScalar()
    '        int1 = int1 + 1

    '        strNewQuotationNo = "000000" & CStr(int1)
    '        strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)

    '        If CheckIfNull(YearInDigit) = True Then
    '            YearInDigit = 0
    '        End If

    '        Dim strYear As String = Year(Now).ToString
    '        strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

    '        strNewQuotationNo = strYear & "-" & strNewQuotationNo
    '        strNewQuotationNo = DeliveryNoteAbbr & strNewQuotationNo
    '        Return strNewQuotationNo

    '    Catch ex As System.InvalidCastException
    '        Dim strYear As String = Year(Now).ToString
    '        strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

    '        strNewQuotationNo = "000000" & 1
    '        strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)
    '        strNewQuotationNo = DeliveryNoteAbbr & strYear & "-" & strNewQuotationNo
    '        Return strNewQuotationNo

    '    Finally
    '        Sqlconnection1.Close()

    '    End Try
    'End Function

    'Private Sub btnCreatePartialDelivery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreatePartialDelivery.ItemClick
    '    'Check if the Items are fully delivered already for this Sales Order

    '    If CheckSalesOrderDeliveryStatus(Me.SelectedSalesOrderNo) = "Fully Delivered" Then
    '        MessageBox.Show("Sales Order is fully Delivered, you cannot create Delivery for this Order anymore, Please review again.", "Sales Order status is Fully Delivered.", MessageBoxButtons.OK)
    '        Exit Sub
    '    End If

    '    DialogResult = MessageBox.Show("You are about to create new Delivery Note." & vbCrLf & "Are you Sure want to continue creating Delivery Note?", "Confirm creating Delivery Note.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

    '    If DialogResult = System.Windows.Forms.DialogResult.Yes Then
    '        If CheckIfNull(Me.SelectedSalesOrderNo) = False Then

    '            'Get New Delivery Note Number
    '            GetCompanyDetails(1)
    '            Dim NewDeliveryNoteNo As String = Me.GetNewDeliveryNoteNo(gDeliveryNoteAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote)

    '            Me.CreatePartialDeliveryFromSalesOrder(NewDeliveryNoteNo, 1, Me.SelectedSalesOrderNo, Me.strLogOnUser)
    '            Me.OpenDeliveryNote(NewDeliveryNoteNo)

    '            ''Refresh the datagrid
    '            ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

    '        End If
    '    ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
    '        Exit Sub
    '    End If
    'End Sub

    'Private Function CheckSalesOrderDeliveryStatus(ByVal SalesOrderNo As String) As String
    '    Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
    '    Try
    '        If Sqlconnection1.State = ConnectionState.Closed Then
    '            Sqlconnection1.Open()
    '        End If
    '        Dim strSqlQueryText As String
    '        strSqlQueryText = "Select OrderStatus, SalesOrderNo from qry602_04SalesOrderViewMaster where (SalesOrderNo = '" & SalesOrderNo & "')"

    '        Dim SqlCommand1 As New SqlClient.SqlCommand
    '        SqlCommand1.Connection = Sqlconnection1
    '        SqlCommand1.CommandText = strSqlQueryText
    '        Dim srStockReader As SqlClient.SqlDataReader
    '        srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

    '        If srStockReader.HasRows() Then
    '            While srStockReader.Read()
    '                If CheckIfNull(srStockReader.Item("OrderStatus")) = False Then
    '                    Return srStockReader.Item("OrderStatus") & ""
    '                Else
    '                    Return ""
    '                End If
    '            End While
    '        Else
    '            Return ""
    '        End If
    '        srStockReader.Close()
    '    Catch ex As Exception
    '        MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
    '        Return False
    '    Finally
    '        Sqlconnection1.Close()
    '    End Try

    'End Function
    'Private Sub CreatePartialDeliveryFromSalesOrder(ByVal DeliveryNoteNo As String, ByVal DeliveryType As Integer, ByVal SalesOrderNo As String, ByVal AddedBy As String)
    '    Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
    '    Try
    '        If Sqlconnection1.State = ConnectionState.Closed Then
    '            Sqlconnection1.Open()
    '        End If

    '        Dim SqlCommand1 As New SqlClient.SqlCommand
    '        SqlCommand1.Connection = Sqlconnection1
    '        SqlCommand1.CommandType = CommandType.StoredProcedure
    '        SqlCommand1.CommandText = "sp600_07InsertPartialDeliveryFromSalesOrder"
    '        Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
    '        Dim paramDeliveryType As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryType", SqlDbType.TinyInt)
    '        Dim paramSalesOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderNo", SqlDbType.VarChar)
    '        Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

    '        paramDeliveryNoteNo.Value = DeliveryNoteNo
    '        paramDeliveryType.Value = DeliveryType
    '        paramSalesOrderNo.Value = SalesOrderNo
    '        paramAddedBy.Value = AddedBy

    '        SqlCommand1.ExecuteNonQuery()
    '        MessageBox.Show("New Delivery Note is created successfully,", "Delivery Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    Catch ex As System.InvalidCastException
    '        MessageBox.Show("Delivery Note Creation failed, Please try again", "Delivery Note Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Finally
    '        Sqlconnection1.Close()
    '    End Try
    'End Sub

    'Private Sub btnCreateInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateInvoice.ItemClick
    '    Try
    '        Dim frm601_16GenerateInvoiceFromDelivery As New frm601_16GenerateInvoiceFromDelivery
    '        frm601_16GenerateInvoiceFromDelivery.ObjForm = Me
    '        frm601_16GenerateInvoiceFromDelivery.strLogonUser = Me.strLogOnUser
    '        frm601_16GenerateInvoiceFromDelivery.intLogOnUserID = Me.intLogOnUserID
    '        frm601_16GenerateInvoiceFromDelivery.intLogOnUserLevel = Me.intLogOnUserLevel
    '        frm601_16GenerateInvoiceFromDelivery.intLogOnAccessLevel = Me.intLogOnAccessLevel

    '        frm601_16GenerateInvoiceFromDelivery.isExecutedFrom_frm601_04SalesOrderView = True
    '        frm601_16GenerateInvoiceFromDelivery.txtClientName.EditValue = Me.SelectedClientCode
    '        frm601_16GenerateInvoiceFromDelivery.txtSalesOrders.EditValue = Me.SelectedSalesOrderNo

    '        frm601_16GenerateInvoiceFromDelivery.strQuotationNo = Me.SelectedQuotationNo
    '        frm601_16GenerateInvoiceFromDelivery.strClientPONo = Me.SelectedClientPONo
    '        frm601_16GenerateInvoiceFromDelivery.strClientPODate = Me.SelectedClientPODate
    '        frm601_16GenerateInvoiceFromDelivery.strCompanyName = Me.SelectedCompany
    '        frm601_16GenerateInvoiceFromDelivery.strSalesPersonCode = Me.SelectedSalesPerson

    '        frm601_16GenerateInvoiceFromDelivery.ShowRecords()
    '        frm601_16GenerateInvoiceFromDelivery.Show()

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_28JobOrdersView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCreateFullDelivery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateFullDelivery.ItemClick
        ''Check if the Items are partially delivered or fully delivered already for this Sales Order
        If CheckIfDeliveryNoteGenerated(Me.SelectedJobOrderNo) = True Then
            MessageBox.Show("This Job Order has been Delivered, you cannot create Delivery for this Job Order anymore, Please review again.", "Job Order status is Delivered.", MessageBoxButtons.OK)
            Exit Sub

        End If


        'If CheckSalesOrderDeliveryStatus(Me.SelectedSalesOrderNo) = "Partially Delivered" Then
        '    MessageBox.Show("Sales Order is partially Delivered, you cannot create Full Delivery for this Order anymore, Please review again.", "Sales Order status is Partially Delivered.", MessageBoxButtons.OK)
        '    Exit Sub

        'End If

        DialogResult = MessageBox.Show("You are about to create new Delivery Note." & vbCrLf & "Are you Sure want to continue creating Delivery Note?", "Confirm creating Delivery Note.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedJobOrderNo) = False Then

                'Get New Delivery Note Number
                GetCompanyDetails(1)
                Dim NewDeliveryNoteNo As String = Me.GetNewDeliveryNoteNo(gDeliveryNoteAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote)

                Me.CreateFullDeliveryFromJobOrder(NewDeliveryNoteNo, 1, Me.SelectedJobOrderNo, Me.strLogOnUser)
                Me.OpenDeliveryNote(NewDeliveryNoteNo)

                ''Refresh the datagrid
                ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub
    Private Function CheckIfDeliveryNoteGenerated(ByVal JobOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select JobOrderNo from tbl603_01DeliveryNoteMaster where (JobOrderNo  = '" & JobOrderNo & "')"

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
    Private Sub OpenDeliveryNote(ByVal DeliveryNoteNo As String)
        If CheckIfNull(DeliveryNoteNo) = False Then
            Dim frm601_05DeliveryNoteEdit As New frm601_05DeliveryNoteEdit
            frm601_05DeliveryNoteEdit.ObjForm = Me
            frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
            frm601_05DeliveryNoteEdit.btnSave.Caption = "Update"
            frm601_05DeliveryNoteEdit.strLogonUser = Me.strLogOnUser
            frm601_05DeliveryNoteEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_05DeliveryNoteEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_05DeliveryNoteEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_05DeliveryNoteEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_28JobOrdersView = True
            frm601_05DeliveryNoteEdit.Show()

            frm601_05DeliveryNoteEdit.RetrieveDeliveryMaster(DeliveryNoteNo)

            frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
            frm601_05DeliveryNoteEdit.DisableApprovedVoucherEditing(DeliveryNoteNo)

        End If
    End Sub
    Private Sub CreateFullDeliveryFromJobOrder(ByVal DeliveryNoteNo As String, ByVal DeliveryType As Integer, ByVal JobOrderNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp608_02InsertToDeliveryNoteFromJobOrder"
            Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
            Dim paramDeliveryType As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryType", SqlDbType.TinyInt)
            Dim paramJobOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@JobOrderNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramDeliveryNoteNo.Value = DeliveryNoteNo
            paramDeliveryType.Value = DeliveryType
            paramJobOrderNo.Value = JobOrderNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Delivery Note is created successfully,", "Delivery Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Delivery Note Creation failed, Please try again", "Delivery Note Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public Function GetNewDeliveryNoteNo(ByVal DeliveryNoteAbbr As String, ByVal YearInDigit As Integer, ByVal NoOfDigits As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(right(DeliveryNoteNo," & NoOfDigits & ") as int)) from tbl603_01DeliveryNoteMaster"
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewQuotationNo = "000000" & CStr(int1)
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)

            If CheckIfNull(YearInDigit) = True Then
                YearInDigit = 0
            End If

            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = strYear & "-" & strNewQuotationNo
            strNewQuotationNo = DeliveryNoteAbbr & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = "000000" & 1
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)
            strNewQuotationNo = DeliveryNoteAbbr & strYear & "-" & strNewQuotationNo
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub btnCreateMultipleDN2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateMultipleDN2.ItemClick
        Try
            If CheckIfDeliveryNoteGenerated(Me.SelectedJobOrderNo) = True Then
                MessageBox.Show("This Job Order has been Delivered, you cannot create Delivery for this Job Order anymore, Please review again.", "Job Order status is Delivered.", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim frm601_37CreateDNfromJO As New frm601_37CreateDNfromJO
            frm601_37CreateDNfromJO.ObjForm = Me
            frm601_37CreateDNfromJO.strLogonUser = Me.strLogOnUser
            frm601_37CreateDNfromJO.intLogOnUserID = Me.intLogOnUserID
            frm601_37CreateDNfromJO.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_37CreateDNfromJO.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_37CreateDNfromJO.SelectedCompanyBranch = Me.SelectedCompany

            frm601_37CreateDNfromJO.isExecutedFrom_frm601_28JobOrdersView = True
            frm601_37CreateDNfromJO.txtClientName.EditValue = Me.SelectedClientCode
            frm601_37CreateDNfromJO.Show()

        Catch ex As Exception

        End Try
    End Sub
End Class