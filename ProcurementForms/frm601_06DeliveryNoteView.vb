Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI

Public Class frm601_06DeliveryNoteView

    Public frm601_06DeliveryNoteViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Public intLogOnHRLevelCode As Integer

    Private SelectedDeliveryNoteNo As String = ""
    Private SelectedDeliveryNoteDate As Date = Date.Today()

    Private SelectedClientCode As String = ""

#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If Me.intLogOnDivision = 99 Then
                If intLogOnInventoryAccessLevel = 99 Then
                    If intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDate(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate)
                    Else
                        Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDateBySalesPersonUserID(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate, Me.intLogOnUserID)
                    End If

                Else
                    If intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDateByGroup(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                    Else
                        Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDateByGroupBySalesPersonUserID(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                    End If
                End If

            Else
                If intLogOnInventoryAccessLevel = 99 Then
                    If intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDateByType(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate, intLogOnDivision)
                    Else
                        Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDateByTypeBySalesPersonUserID(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate, intLogOnDivision, Me.intLogOnUserID)
                    End If

                Else
                    If intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDateByTypeByGroup(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate, intLogOnDivision, Me.intLogOnInventoryAccessLevel)
                    Else
                        Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDateByTypeByGroupBySalesPersonUserID(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate, intLogOnDivision, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                    End If


                End If


            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Delivery Note Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry603_04DeliveryNoteViewMasterTableAdapter.NoOfDeliveryNotesToday())
        Else
            nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry603_04DeliveryNoteViewMasterTableAdapter.NoOfDeliveryNotesTodayByGroup(Me.intLogOnInventoryAccessLevel))
        End If
        nwTile.Frames(0).Elements(3).Text = "New Deliveries"
        nwTile.Frames(0).Elements(4).Text = "Today"

        'No of Sales Order's waiting for Approval
        nwTile.Frames(1).Elements(1).Text = "You have"
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry603_04DeliveryNoteViewMasterTableAdapter.NoOfDeliveryNotesWaitingApproval())
        Else
            nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry603_04DeliveryNoteViewMasterTableAdapter.NoOfDeliveryNotesWaitingApprovalByGroup(Me.intLogOnInventoryAccessLevel))
        End If
        nwTile.Frames(1).Elements(3).Text = "Delivery Note's for Approval"
        nwTile.Frames(1).Elements(4).Text = "Pending"

        'Deliveries Today
        nwTile.Frames(2).Elements(1).Text = "You have"
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry603_04DeliveryNoteViewMasterTableAdapter.NoOfDeliveryNotePendingToInvoice())
        Else
            nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry603_04DeliveryNoteViewMasterTableAdapter.NoOfDeliveryNotePendingToInvoiceByGroup(Me.intLogOnInventoryAccessLevel))
        End If

        nwTile.Frames(2).Elements(3).Text = "Delivery Note's for Invoicing"
        nwTile.Frames(2).Elements(4).Text = "Waiting"


        Dim nwTile3 As TileItem = Me.tileAllAssets
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry603_04DeliveryNoteViewMasterTableAdapter.GetNoOfDeliveryNotes(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue))
        Else
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry603_04DeliveryNoteViewMasterTableAdapter.GetNoOfDeliveryNotesByGroup(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, Me.intLogOnInventoryAccessLevel))
        End If
    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub

#End Region

    Public Sub ImplementAccess(ByVal UserID As Integer)
        Try
            If GetUserAccess(UserID, "frm601_06DeliveryNoteView_FullAccess") = True Then

                Me.btnShowAllRecords.Enabled = True
                Me.btnSaveLayout.Enabled = True
                Me.btnOpenLayout.Enabled = True
                Me.btnResetLayout.Enabled = True
                Me.btnSetDefaultLayout.Enabled = True
                Me.btnPrint.Enabled = True
                Me.btnSearch.Enabled = True
                Me.btnGroup.Enabled = True
                Me.btnDeliveryDetails.Enabled = True
                Me.btnAddNewDN.Enabled = True
                Me.btnAddNewIssueToStore.Enabled = True
                Me.btnAddStoreTransfers.Enabled = True
                Me.btnEditDeliveryNote.Enabled = True
                Me.btnDeleteDeliveryNote.Enabled = True
                Me.btnUnlockDeliveryNote.Enabled = True
                Me.btnCreateInvoiceForOneDN.Enabled = True

            Else
                Me.btnShowAllRecords.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnShowAllRecords")
                Me.btnSaveLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnSaveLayout")
                Me.btnOpenLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnOpenLayout")
                Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnResetLayout")
                Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnSetDefaultLayout")
                Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnPrint")
                Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnSearch")
                Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnGroup")
                Me.btnDeliveryDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnDeliveryDetails")
                Me.btnAddNewDN.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnAddNewDN")
                Me.btnAddNewIssueToStore.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnAddNewIssueToStore")
                Me.btnAddStoreTransfers.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnAddStoreTransfers")
                Me.btnEditDeliveryNote.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnEditDeliveryNote")
                Me.btnDeleteDeliveryNote.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnDeleteDeliveryNote")
                Me.btnUnlockDeliveryNote.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnUnlockDeliveryNote")
                Me.btnCreateInvoiceForOneDN.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_06DeliveryNoteView_btnCreateInvoiceForOneDN")

            End If
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_06DeliveryNoteViewIsClosed = True
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

    Private SelectedDeliveryNoteType As Integer = 0

    Private Sub gvAccountDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvAdvBandedQuotationView.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedDeliveryNoteNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryNoteNo"))
                SelectedDeliveryNoteDate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryDate"))

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))) = False Then
                    SelectedClientCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))
                Else
                    SelectedClientCode = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))) = False Then
                    SelectedClientCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))
                Else
                    SelectedClientCode = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryType"))) = False Then
                    SelectedDeliveryNoteType = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryType"))
                Else
                    SelectedDeliveryNoteType = ""
                End If

                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception

        End Try
    End Sub

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
            frm601_05DeliveryNoteEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_05DeliveryNoteEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_06DeliveryNoteView = True

            ''Post all the Average Cost Price of the Items in the Delivery Note and Update it
            'UpdateAvgCostPriceInDeliveryNote(Me.SelectedDeliveryNoteNo, Me.SelectedDeliveryNoteDate)


            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = True
            Else
                frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = False
            End If

            frm601_05DeliveryNoteEdit.Show()
            frm601_05DeliveryNoteEdit.RetrieveDeliveryMaster(DeliveryNoteNo)

            frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
            frm601_05DeliveryNoteEdit.DisableApprovedVoucherEditing(DeliveryNoteNo)
            frm601_05DeliveryNoteEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)


            If SelectedDeliveryNoteType = 4 Then
                GetCompanyDetails02(1)
                If gIsStoreWiseDelivery = True Then
                    Try
                        Dim EndDate As Date = Me.SelectedDeliveryNoteDate
                        frm601_05DeliveryNoteEdit.InsertStoreInventoryValueByDate("2001-01-01", EndDate.AddHours(23))
                        frm601_05DeliveryNoteEdit.Qry653_20StoreStockBalanceWtStoreCodeTableAdapter.FillByStoreCode(frm601_05DeliveryNoteEdit.Dsfrm601_01QuotationEdit1.qry653_20StoreStockBalanceWtStoreCode, frm601_05DeliveryNoteEdit.txtStoreIssuedFrom.EditValue)

                        frm601_05DeliveryNoteEdit.colDetailedDescription.Visible = False

                        frm601_05DeliveryNoteEdit.colStockDescriptionWtStores.VisibleIndex = 3
                        frm601_05DeliveryNoteEdit.colStockDescriptionWtStores.Visible = True

                        frm601_05DeliveryNoteEdit.txtStoreIssuedFrom.Enabled = False
                    Catch ex As Exception

                    End Try
                End If
            End If

        End If
    End Sub


    Private Sub btnPopupEditQuotation_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditDeliveryNote.ItemClick
        Me.OpenDeliveryNote(Me.SelectedDeliveryNoteNo)
    End Sub

  


    Private Sub repoQuoteNo_Click(sender As Object, e As EventArgs) Handles repoQuoteNo.Click
        Dim strDeliveryNoteNo As String = Me.gvAdvBandedQuotationView.GetRowCellValue(Me.gvAdvBandedQuotationView.FocusedRowHandle, "SalesOrderNo")
        If CheckIfNull(strDeliveryNoteNo) = True Then
            MessageBox.Show("Please select the Delivery Note No. to edit.", "Select Delivery Note No. to edit", MessageBoxButtons.OK)
        Else
            Me.OpenDeliveryNote(strDeliveryNoteNo)
        End If
    End Sub

    Private Sub btnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteDeliveryNote.ItemClick
        Try
            If CheckIfDeliveryAlreadyPosted(Me.SelectedDeliveryNoteNo) = True Then
                MessageBox.Show("This Delivery Note is already posted to your ledgers.", "Delivery Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Check if the Voucher is approved already
            If CheckIfDeliveryNoteIsApproved(Me.SelectedDeliveryNoteNo) = True Then
                MessageBox.Show("Delivery Note is already approved, You cannot delete the Approved Delivery Note.", "Delivery Note is Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            'Check if the Delivery Note is Invoiced
            If CheckIfDeliveryNoteIsInvoiced(Me.SelectedDeliveryNoteNo) = True Then
                MessageBox.Show("Delivery Note is Invoiced, You cannot delete the Invoiced Delivery Note", "Delivery Note Invoiced", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Delivery Note from the Register," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedDeliveryNoteNo) = False Then
                    If DeleteDeliveryNote(Me.SelectedDeliveryNoteNo) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.SelectedDeliveryNoteNo, "VoucherScanned\IMSDelv")

                        MessageBox.Show("Delivery Note has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Delivery Note", "IMS Delivery Note Ref No." & Me.SelectedDeliveryNoteNo & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedDeliveryNoteNo)

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

    Public Function CheckIfDeliveryNoteIsInvoiced(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select InvoiceNo from tbl603_01DeliveryNoteMaster where (DeliveryNoteNo = '" & DeliveryNoteNo & "') and  ((InvoiceNo IS NOT NULL) OR (InvoiceNo <> ''))"

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

    Public Function CheckIfDeliveryAlreadyPosted(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select VoucherNo from tbl201VoucherMaster where (VoucherRefNo = '" & DeliveryNoteNo & "')"

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
    Private Function CheckIfDeliveryNoteIsApproved(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select DeliveryNoteNo from tbl603_01DeliveryNoteMaster where (DeliveryNoteNo = '" & DeliveryNoteNo & "') and (Isnull(IsApproved,0) = 1 )"

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
    Private Function DeleteDeliveryNote(ByVal DeliveryNoteNo As String) As Boolean
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
            delPRTrans.CommandText = "UPDATE dbo.tbl608_01JobOrderMaster SET JobOrderStatus = 2 FROM dbo.tbl603_02DeliveryNoteChild INNER JOIN dbo.tbl608_01JobOrderMaster ON dbo.tbl603_02DeliveryNoteChild.JobOrderNoInDNChild = dbo.tbl608_01JobOrderMaster.JobOrderNo WHERE (dbo.tbl603_02DeliveryNoteChild.DeliveryNoteNo  = '" & DeliveryNoteNo & "')"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl603_01DeliveryNoteMaster WHERE DeliveryNoteNo   = '" & DeliveryNoteNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl603_02DeliveryNoteChild WHERE DeliveryNoteNo   = '" & DeliveryNoteNo & "'"
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


    Public Function GetJobOrderNo(DeliveryNoteNo) As String
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString1)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select  JobOrderNo from tbl603_01DeliveryNoteMaster where DeliveryNoteNo = '" & DeliveryNoteNo & "'"
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            Dim rSignatoryName As String = ""

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    rSignatoryName = srStockReader.Item("JobOrderNo")
                End While
            End If

            Return rSignatoryName
            srStockReader.Close()

        Catch ex As System.InvalidCastException

            Return ""
            MessageBox.Show(ex.Message)

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub btnUnlockInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnlockDeliveryNote.ItemClick
        If Me.intLogOnUserLevel = 99 Then
            'Check if the Delivery Note is posted
            If Me.CheckIfDeliveryAlreadyPosted(Me.SelectedDeliveryNoteNo) = True Then
                MessageBox.Show("This Delivery Note is already posted to your ledgers.", "Delivery Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.UnlockTheDeliveryNote(Me.SelectedDeliveryNoteNo)
            MessageBox.Show("Delivery Note has been unlocked successfully.", "Delivery Note Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Update the Delete Log File
            InsertUserEntryLogSheet("IMS Delivery Note", "IMS Delivery Note Ref No." & Me.SelectedDeliveryNoteNo & " has been Unlocked by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedDeliveryNoteNo)


            'Refresh the screen
            Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        Else
            MessageBox.Show("Your user access level cannot unlock the Delivery Note, Please review again.", "Access Permission Denied.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If

    End Sub


    Private Function UnlockTheDeliveryNote(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl603_01DeliveryNoteMaster Set IsApproved = 0, ApprovedBy = '', ApprovedOn = NULL where DeliveryNoteNo = '" & DeliveryNoteNo & "'"

            'strSqlQueryText = "UPDATE tbl603_01DeliveryNoteMaster Set 
            '                    IsSubmitted = 0, SubmittedBy = '', SubmittedOn = NULL, 
            '                    IsVerified = 0, VerifiedBy = '', VerifiedOn = NULL, 
            '                    IsApproved = 0, ApprovedBy = '', ApprovedOn = NULL 
            '                    where DeliveryNoteNo = '" & DeliveryNoteNo & "'"

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

    Private Sub frm601_04SalesOrderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()

        Me.ImplementAccess(Me.intLogOnUserID)

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_06DeliveryNoteView", Me.gvAdvBandedQuotationView)

        'If Me.intLogOnHRLevelCode = 99 Then
        '    Me.btnAddNewDN.Enabled = True
        '    Me.btnAddNewIssueToStore.Enabled = True
        'ElseIf Me.intLogOnHRLevelCode = 1 Then
        '    Me.btnAddNewDN.Enabled = True
        '    Me.btnAddNewIssueToStore.Enabled = False
        'ElseIf Me.intLogOnHRLevelCode = 2 Then
        '    Me.btnAddNewDN.Enabled = False
        '    Me.btnAddNewIssueToStore.Enabled = True
        'End If
    End Sub

    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_06DeliveryNoteView"

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



    Private Sub btnCreateInvoiceForOneDN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateInvoiceForOneDN.ItemClick
        'Check if the Invoice is generate for the Delivery Note

        If CheckIfInvoiceAvailableForSalesOrder(Me.SelectedDeliveryNoteNo) = True Then
            MessageBox.Show("Invoice is already created for this Delivery Note, Please review again.", "Invoice Available.", MessageBoxButtons.OK)
            Exit Sub

        End If

        If GetLedgerNoFromClientCode(SelectedClientCode) = "" Then
            MessageBox.Show("This Client details are not added to Accounting Ledger," & vbCrLf & "Please link this Client Details with Accounts Ledgers to create a VAT Invoice.", "Client Ledger Account is not Linked.", MessageBoxButtons.OK)
            Exit Sub
        End If

        DialogResult = MessageBox.Show("You are about to create new VAT Invoice." & vbCrLf & "Are you Sure want to continue creating Invoice?", "Confirm creating Invoice.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedDeliveryNoteNo) = False Then

                'Get New VAT Invoice Number
                GetCompanyDetails(1)
                Dim NewInvoiceNo As String = ""
                If gIsUseEInvoiceAbbrv = True Then
                    NewInvoiceNo = frm00102eInvSalesInvoiceEdit.GetNewInvoiceNo(gEInvoiceAbbrv, gInvoiceYearDigits, GetSQLServerDate, gIsResetInvoiceInYear, gNoOfDigitsInEInvoiceNo)
                Else
                    NewInvoiceNo = frm00102eInvSalesInvoiceEdit.GetNewInvoiceNo("", gInvoiceYearDigits, GetSQLServerDate, gIsResetInvoiceInYear, gNoOfDigitsInEInvoiceNo)
                End If

                If CheckIfSalesOrderAvailableForDN(Me.SelectedDeliveryNoteNo) = True Then
                    'Check if Sales Order is already available... then generate DN with Sales Order

                    Dim sGUID As String
                    sGUID = System.Guid.NewGuid.ToString()

                    Dim intInvoiceCounterValue As Integer = 0
                    intInvoiceCounterValue = GetNewInvoiceCounterValue()
                    If intInvoiceCounterValue = 0 Then
                        MessageBox.Show("Error on Creating new e-Invoice, Invoice Counter Value returns Zero (0), please try again or contact I.T. Support for assistance.", "Invoice Counter Value Error", MessageBoxButtons.OK)
                        Exit Sub
                    End If

                    Me.CreateInvoiceFromDeliveryNote(NewInvoiceNo, GetLedgerNoFromClientCode(SelectedClientCode), Me.SelectedDeliveryNoteNo, Me.strLogOnUser, sGUID, intInvoiceCounterValue)

                    frm601_05DeliveryNoteEdit.UpdateApproved(True, Me.strLogOnUser, SelectedDeliveryNoteNo)

                Else
                    'Else Create Invoice Without Sales Order Details
                    Dim sGUID As String
                    sGUID = System.Guid.NewGuid.ToString()

                    Dim intInvoiceCounterValue As Integer = 0
                    intInvoiceCounterValue = GetNewInvoiceCounterValue()
                    If intInvoiceCounterValue = 0 Then
                        MessageBox.Show("Error on Creating new e-Invoice, Invoice Counter Value returns Zero (0), please try again or contact I.T. Support for assistance.", "Invoice Counter Value Error", MessageBoxButtons.OK)
                        Exit Sub
                    End If

                    Me.CreateInvoiceFromDeliveryNoteWOSalesOrder(NewInvoiceNo, GetLedgerNoFromClientCode(SelectedClientCode), Me.SelectedDeliveryNoteNo, Me.strLogOnUser, sGUID, intInvoiceCounterValue)
                    frm601_05DeliveryNoteEdit.UpdateApproved(True, Me.strLogOnUser, SelectedDeliveryNoteNo)
                End If
                'Me.OpenPropertyInvoice(NewInvoiceNo)

                'Update the Due Date for the Invoice
                Me.UpdateDueDateOfInvoice(NewInvoiceNo, GetDueDateOfInvoice(GetLedgerNoFromClientCode(SelectedClientCode)))

                Me.OpenEInvoice(NewInvoiceNo)

                ''Refresh the datagrid
                ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Public Function GetDueDateOfInvoice(ByVal AccountID As String) As Decimal
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "SELECT     AccountID, AccountHead, ISNULL(NoOfDaysCreditPeriod, 0) AS NoOfDaysCreditPeriod FROM qry20107ChartOfAccounts WHERE (AccountID = '" & AccountID & "')"
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    If CheckIfNull(srStockReader.Item("NoOfDaysCreditPeriod")) = False Then
                        Return srStockReader.Item("NoOfDaysCreditPeriod")
                    Else
                        Return 0
                    End If
                End While
            Else
                Return 0
            End If
            srStockReader.Close()


        Catch ex As System.InvalidCastException

            Return 0

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Public Function UpdateDueDateOfInvoice(ByVal InvoiceNo As String, ByVal NoOfDaysCreditPeriod As Decimal) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim NoOfDaysCredit As Decimal = NoOfDaysCreditPeriod
            Dim InvoiceDueDate As Date = DateAdd(DateInterval.Day, NoOfDaysCredit, Date.Today)

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl20161VATInvoiceMaster SET InvoiceDueDate = '" & InvoiceDueDate & "' WHERE (InvoiceNo = '" & InvoiceNo & "') "

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

    Private Function CheckIfSalesOrderAvailableForDN(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select DeliveryNoteNo, SalesOrderNo from qry603_04DeliveryNoteViewMaster where (DeliveryNoteNo = '" & DeliveryNoteNo & "') and (SalesOrderNo IS NOT NULL)"

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

    Private Function CheckIfInvoiceAvailableForSalesOrder(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select DeliveryNoteNo, InvoiceNo from qry603_04DeliveryNoteViewMaster where (DeliveryNoteNo = '" & DeliveryNoteNo & "') and (InvoiceNo IS NOT NULL)"

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


    'Private Sub OpenPropertyInvoice(ByVal InvoiceNo As String)
    '    If CheckIfNull(InvoiceNo) = False Then
    '        Dim frm20161VATInvoiceEdit As New frm20161VATInvoiceEdit
    '        frm20161VATInvoiceEdit.ObjForm = Me
    '        frm20161VATInvoiceEdit.txtQuotationNo.Enabled = False
    '        frm20161VATInvoiceEdit.btnSave.Caption = "Update"

    '        frm20161VATInvoiceEdit.strLogonUser = Me.strLogOnUser
    '        frm20161VATInvoiceEdit.intLogOnUserID = Me.intLogOnUserID
    '        frm20161VATInvoiceEdit.intLogOnUserLevel = Me.intLogOnUserLevel
    '        frm20161VATInvoiceEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
    '        frm20161VATInvoiceEdit.intLogOnDivision = Me.intLogOnDivision
    '        frm20161VATInvoiceEdit.isExecutedFrom_frm601_06DeliveryNoteView = True

    '        frm20161VATInvoiceEdit.Show()
    '        frm20161VATInvoiceEdit.RetrieveInvoiceMaster(InvoiceNo)

    '        frm20161VATInvoiceEdit.txtInvoiceNo.Enabled = False
    '        frm20161VATInvoiceEdit.DisableApprovedVoucherEditing(InvoiceNo)
    '        If GetInvoiceCurrency(InvoiceNo) = 1 Then
    '            frm20161VATInvoiceEdit.IsVisibleOC = False
    '        Else
    '            frm20161VATInvoiceEdit.IsVisibleOC = True
    '        End If
    '        frm20161VATInvoiceEdit.SwitchColumns()
    '        frm20161VATInvoiceEdit.txtDeliveryNoteNo.Enabled = False


    '    End If
    'End Sub

    Public Sub OpenEInvoice(ByVal InvoiceNo As String)
        If CheckIfNull(InvoiceNo) = False Then
            Dim frm00102eInvSalesInvoiceEdit As New frm00102eInvSalesInvoiceEdit
            frm00102eInvSalesInvoiceEdit.ObjForm = Me
            frm00102eInvSalesInvoiceEdit.btnSave.Caption = "Update"
            frm00102eInvSalesInvoiceEdit.strLogonUser = Me.strLogOnUser
            frm00102eInvSalesInvoiceEdit.intLogOnUserID = Me.intLogOnUserID
            frm00102eInvSalesInvoiceEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm00102eInvSalesInvoiceEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm00102eInvSalesInvoiceEdit.intLogOnDivision = Me.intLogOnDivision
            frm00102eInvSalesInvoiceEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm00102eInvSalesInvoiceEdit.isExecutedFrom_frm601_06DeliveryNoteView = True
            frm00102eInvSalesInvoiceEdit.Show()

            frm00102eInvSalesInvoiceEdit.RetrieveInvoiceMaster(InvoiceNo)
            If GetInvoiceCurrency(InvoiceNo) = 1 Then
                frm00102eInvSalesInvoiceEdit.IsVisibleOC = False
            Else
                frm00102eInvSalesInvoiceEdit.IsVisibleOC = True
            End If
            frm00102eInvSalesInvoiceEdit.SwitchColumns()

            frm00102eInvSalesInvoiceEdit.txtInvoiceNo.Enabled = False
            frm00102eInvSalesInvoiceEdit.DisableApprovedVoucherEditing(InvoiceNo)

            frm00102eInvSalesInvoiceEdit.BackToInvoiceTab()

            frm00102eInvSalesInvoiceEdit.txtInvoiceNo.Enabled = False
            frm00102eInvSalesInvoiceEdit.txtInvoiceDate.Enabled = False
            frm00102eInvSalesInvoiceEdit.txtInvoiceDateWtTime.Enabled = False
            frm00102eInvSalesInvoiceEdit.txtInvoiceUUID.Enabled = False
            frm00102eInvSalesInvoiceEdit.txtInvoiceType.Enabled = False

            'To Fill the details of the company & client address
            frm00102eInvSalesInvoiceEdit.FixCompanyAndClientDetails()

            frm00102eInvSalesInvoiceEdit.ConstructFullAddressText()

        End If
    End Sub

    Private Sub CreateInvoiceFromDeliveryNote(ByVal InvoiceNo As String, ByVal ClientAccountNo As String, ByVal DeliveryNoteNo As String, ByVal AddedBy As String, ByVal InvoiceUUID As String, ByVal InvoiceCounterValue As Integer)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_06InsertToInvoiceFromDeliveryNote"
            Dim paramInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@InvoiceNo", SqlDbType.VarChar)
            Dim paramClientAccountNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ClientAccountNo", SqlDbType.VarChar)
            Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramInvoiceUUID As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@InvoiceUUID", SqlDbType.VarChar)
            Dim paramInvoiceCounterValue As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@InvoiceCounterValue", SqlDbType.BigInt)

            paramInvoiceNo.Value = InvoiceNo
            paramClientAccountNo.Value = ClientAccountNo
            paramDeliveryNoteNo.Value = DeliveryNoteNo
            paramAddedBy.Value = AddedBy
            paramInvoiceUUID.Value = InvoiceUUID
            paramInvoiceCounterValue.Value = InvoiceCounterValue

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New VAT Invoice is created successfully,", "VAT Invoice created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("VAT Invoice Creation failed, Please try again", "VAT Invoice Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub CreateInvoiceFromDeliveryNoteWOSalesOrder(ByVal InvoiceNo As String, ByVal ClientAccountNo As String, ByVal DeliveryNoteNo As String, ByVal AddedBy As String, ByVal InvoiceUUID As String, ByVal InvoiceCounterValue As Integer)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_06InsertToInvoiceFromDeliveryNote2"
            Dim paramInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@InvoiceNo", SqlDbType.VarChar)
            Dim paramClientAccountNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ClientAccountNo", SqlDbType.VarChar)
            Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramInvoiceUUID As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@InvoiceUUID", SqlDbType.VarChar)
            Dim paramInvoiceCounterValue As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@InvoiceCounterValue", SqlDbType.BigInt)

            paramInvoiceNo.Value = InvoiceNo
            paramClientAccountNo.Value = ClientAccountNo
            paramDeliveryNoteNo.Value = DeliveryNoteNo
            paramAddedBy.Value = AddedBy
            paramInvoiceUUID.Value = InvoiceUUID
            paramInvoiceCounterValue.Value = InvoiceCounterValue

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New VAT Invoice is created successfully,", "VAT Invoice created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("VAT Invoice Creation failed, Please try again", "VAT Invoice Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub
    Private Sub btnInvoiceDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeliveryDetails.ItemClick
        Try
            Dim frm601_14DeliveryDetails As New frm601_14DeliveryDetails
            frm601_14DeliveryDetails.ObjForm = Me

            frm601_14DeliveryDetails.strLogOnUser = Me.strLogOnUser
            frm601_14DeliveryDetails.intLogOnUserID = Me.intLogOnUserID
            frm601_14DeliveryDetails.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_14DeliveryDetails.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_14DeliveryDetails.intLogOnDivision = Me.intLogOnDivision
            frm601_14DeliveryDetails.intLogOnHRLevelCode = Me.intLogOnHRLevelCode
            frm601_14DeliveryDetails.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_14DeliveryDetails.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
            frm601_14DeliveryDetails.txtStartDate.EditValue = Me.txtStartDate.EditValue
            frm601_14DeliveryDetails.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm601_14DeliveryDetails.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnAddNewDN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewDN.ItemClick
        Dim frm601_05DeliveryNoteEdit As New frm601_05DeliveryNoteEdit
        frm601_05DeliveryNoteEdit.ObjForm = Me

        frm601_05DeliveryNoteEdit.btnSave.Caption = "Save"
        frm601_05DeliveryNoteEdit.isBeingNew = True
        frm601_05DeliveryNoteEdit.strLogonUser = Me.strLogOnUser
        frm601_05DeliveryNoteEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_05DeliveryNoteEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_05DeliveryNoteEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_05DeliveryNoteEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_05DeliveryNoteEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
        frm601_05DeliveryNoteEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
        frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_06DeliveryNoteView = True

        Dim SalesPersonCode As String = ""
        SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

        If Me.intLogOnInventoryMPRAccessLevel = 99 Then
            frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = True
        Else
            frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = False
        End If

        frm601_05DeliveryNoteEdit.Show()

        GetCompanyDetails(1)
        Dim NewDeliveryNoteNo As String = frm601_05DeliveryNoteEdit.GetNewDeliveryNoteNo(gDeliveryNoteAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote, Date.Now, gIsResetDeliverInYear)
        frm601_05DeliveryNoteEdit.CreatedNewDeliveryNoteNo = NewDeliveryNoteNo
        frm601_05DeliveryNoteEdit.NewDeliveryNoteMaster(NewDeliveryNoteNo)
        frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.EditValue = NewDeliveryNoteNo
        frm601_05DeliveryNoteEdit.txtDeliveryNoteDate.EditValue = Date.Today
        frm601_05DeliveryNoteEdit.selectedDeliveryType = 1
        frm601_05DeliveryNoteEdit.UpdateDefaultFields()

        frm601_05DeliveryNoteEdit.txtDeliveryType.Enabled = False

        frm601_05DeliveryNoteEdit.txtStoreIssuedFrom.Enabled = True
        frm601_05DeliveryNoteEdit.lblStoreIssuedFrom.Text = "Stock Delivered from Store:"

        frm601_05DeliveryNoteEdit.txtInventoryStore.Enabled = False
        frm601_05DeliveryNoteEdit.txtInventoryStore.Visible = False
        frm601_05DeliveryNoteEdit.lblStoreIssuedTo.Visible = False

        frm601_05DeliveryNoteEdit.txtIssuedToProject.Enabled = False

    End Sub

    Private Sub btnAddNewIssueToStore_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewIssueToStore.ItemClick
        Dim frm601_05DeliveryNoteEdit As New frm601_05DeliveryNoteEdit
        frm601_05DeliveryNoteEdit.ObjForm = Me

        frm601_05DeliveryNoteEdit.btnSave.Caption = "Save"
        frm601_05DeliveryNoteEdit.isBeingNew = True
        frm601_05DeliveryNoteEdit.strLogonUser = Me.strLogOnUser
        frm601_05DeliveryNoteEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_05DeliveryNoteEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_05DeliveryNoteEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_05DeliveryNoteEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_05DeliveryNoteEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
        frm601_05DeliveryNoteEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
        frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_06DeliveryNoteView = True

        Dim SalesPersonCode As String = ""
        SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

        If Me.intLogOnInventoryMPRAccessLevel = 99 Then
            frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = True
        Else
            frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = False
        End If

        frm601_05DeliveryNoteEdit.Show()

        GetCompanyDetails(1)
        Dim NewDeliveryNoteNo As String = frm601_05DeliveryNoteEdit.GetNewDeliveryNoteNo(gMaterialIssueNoteAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote, Date.Now, gIsResetDeliverInYear)
        frm601_05DeliveryNoteEdit.CreatedNewDeliveryNoteNo = NewDeliveryNoteNo
        frm601_05DeliveryNoteEdit.NewDeliveryNoteMaster(NewDeliveryNoteNo)
        frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.EditValue = NewDeliveryNoteNo
        frm601_05DeliveryNoteEdit.txtDeliveryNoteDate.EditValue = Date.Today
        frm601_05DeliveryNoteEdit.selectedDeliveryType = 2
        frm601_05DeliveryNoteEdit.UpdateDefaultFields()

        frm601_05DeliveryNoteEdit.txtDeliveryType.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientName.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientRefName.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientContactNo.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientEmail.Enabled = False
        frm601_05DeliveryNoteEdit.txtProject.Enabled = False

        frm601_05DeliveryNoteEdit.cmdEditContacts.Enabled = False

        frm601_05DeliveryNoteEdit.lblStoreIssuedFrom.Text = "Stock Issued from Store:"
        frm601_05DeliveryNoteEdit.txtStoreIssuedFrom.Enabled = True

        frm601_05DeliveryNoteEdit.lblStoreIssuedTo.Text = "Stock Consumed by Store:"
        frm601_05DeliveryNoteEdit.txtInventoryStore.Enabled = True

        frm601_05DeliveryNoteEdit.txtIssuedToProject.Enabled = False

        frm601_05DeliveryNoteEdit.lblSalesPerson.Text = "Store Incharge:"


    End Sub
    Private Sub btnAddStoreTransfers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddStoreTransfers.ItemClick
        Dim frm601_05DeliveryNoteEdit As New frm601_05DeliveryNoteEdit
        frm601_05DeliveryNoteEdit.ObjForm = Me

        frm601_05DeliveryNoteEdit.btnSave.Caption = "Save"
        frm601_05DeliveryNoteEdit.isBeingNew = True
        frm601_05DeliveryNoteEdit.strLogonUser = Me.strLogOnUser
        frm601_05DeliveryNoteEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_05DeliveryNoteEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_05DeliveryNoteEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_05DeliveryNoteEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_05DeliveryNoteEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
        frm601_05DeliveryNoteEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
        frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_06DeliveryNoteView = True

        Dim SalesPersonCode As String = ""
        SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

        If Me.intLogOnInventoryMPRAccessLevel = 99 Then
            frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = True
        Else
            frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = False
        End If

        frm601_05DeliveryNoteEdit.Show()

        GetCompanyDetails(1)
        Dim NewDeliveryNoteNo As String = frm601_05DeliveryNoteEdit.GetNewDeliveryNoteNo(gStoreTransferAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote, Date.Now, gIsResetDeliverInYear)
        frm601_05DeliveryNoteEdit.CreatedNewDeliveryNoteNo = NewDeliveryNoteNo
        frm601_05DeliveryNoteEdit.NewDeliveryNoteMaster(NewDeliveryNoteNo)
        frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.EditValue = NewDeliveryNoteNo
        frm601_05DeliveryNoteEdit.txtDeliveryNoteDate.EditValue = Date.Today
        frm601_05DeliveryNoteEdit.selectedDeliveryType = 4
        frm601_05DeliveryNoteEdit.UpdateDefaultFields()

        frm601_05DeliveryNoteEdit.txtDeliveryType.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientName.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientRefName.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientContactNo.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientEmail.Enabled = False
        frm601_05DeliveryNoteEdit.txtProject.Enabled = False
        frm601_05DeliveryNoteEdit.cmdEditContacts.Enabled = False

        frm601_05DeliveryNoteEdit.lblStoreIssuedFrom.Text = "Stock Transfered from Store:"
        frm601_05DeliveryNoteEdit.txtStoreIssuedFrom.Enabled = True

        frm601_05DeliveryNoteEdit.lblStoreIssuedTo.Text = "Stock Received by Store:"
        frm601_05DeliveryNoteEdit.txtInventoryStore.Enabled = True

        frm601_05DeliveryNoteEdit.txtIssuedToProject.Enabled = False

        frm601_05DeliveryNoteEdit.lblSalesPerson.Text = "Store Incharge:"

    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_06DeliveryNoteView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddNewIssueToProjects_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewIssueToProjects.ItemClick
        Dim frm601_05DeliveryNoteEdit As New frm601_05DeliveryNoteEdit
        frm601_05DeliveryNoteEdit.ObjForm = Me

        frm601_05DeliveryNoteEdit.btnSave.Caption = "Save"
        frm601_05DeliveryNoteEdit.isBeingNew = True
        frm601_05DeliveryNoteEdit.strLogonUser = Me.strLogOnUser
        frm601_05DeliveryNoteEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_05DeliveryNoteEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_05DeliveryNoteEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_05DeliveryNoteEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_05DeliveryNoteEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
        frm601_05DeliveryNoteEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
        frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_06DeliveryNoteView = True

        Dim SalesPersonCode As String = ""
        SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

        If Me.intLogOnInventoryMPRAccessLevel = 99 Then
            frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = True
        Else
            frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = False
        End If
        frm601_05DeliveryNoteEdit.Show()

        GetCompanyDetails(1)
        Dim NewDeliveryNoteNo As String = frm601_05DeliveryNoteEdit.GetNewDeliveryNoteNo(gMaterialIssueProjectAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote, Date.Now, gIsResetDeliverInYear)
        frm601_05DeliveryNoteEdit.CreatedNewDeliveryNoteNo = NewDeliveryNoteNo
        frm601_05DeliveryNoteEdit.NewDeliveryNoteMaster(NewDeliveryNoteNo)
        frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.EditValue = NewDeliveryNoteNo
        frm601_05DeliveryNoteEdit.txtDeliveryNoteDate.EditValue = Date.Today
        frm601_05DeliveryNoteEdit.selectedDeliveryType = 3
        frm601_05DeliveryNoteEdit.UpdateDefaultFields()

        frm601_05DeliveryNoteEdit.txtDeliveryType.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientName.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientRefName.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientContactNo.Enabled = False
        frm601_05DeliveryNoteEdit.txtClientEmail.Enabled = False
        frm601_05DeliveryNoteEdit.txtProject.Enabled = False

        frm601_05DeliveryNoteEdit.cmdEditContacts.Enabled = False

        frm601_05DeliveryNoteEdit.lblStoreIssuedFrom.Text = "Stock Issued from Store:"
        frm601_05DeliveryNoteEdit.txtStoreIssuedFrom.Enabled = True

        frm601_05DeliveryNoteEdit.lblStoreIssuedTo.Text = "Stock Consumed by Store:"
        frm601_05DeliveryNoteEdit.txtInventoryStore.Enabled = True

        frm601_05DeliveryNoteEdit.txtIssuedToProject.Enabled = True

        frm601_05DeliveryNoteEdit.lblSalesPerson.Text = "Store Incharge:"

    End Sub

    Private Sub btnPosting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPosting.ItemClick
        Try
            Dim frm601_07DeliveryNoteCostPosting As New frm601_07DeliveryNoteCostPosting
            frm601_07DeliveryNoteCostPosting.ObjForm = Me

            frm601_07DeliveryNoteCostPosting.strLogOnUser = Me.strLogOnUser
            frm601_07DeliveryNoteCostPosting.intLogOnUserID = Me.intLogOnUserID
            frm601_07DeliveryNoteCostPosting.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_07DeliveryNoteCostPosting.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_07DeliveryNoteCostPosting.intLogOnDivision = Me.intLogOnDivision
            frm601_07DeliveryNoteCostPosting.intLogOnHRLevelCode = Me.intLogOnHRLevelCode

            frm601_07DeliveryNoteCostPosting.txtStartDate.EditValue = Me.txtStartDate.EditValue
            frm601_07DeliveryNoteCostPosting.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm601_07DeliveryNoteCostPosting.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnPostToJournal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPostToJournal.ItemClick
        Try
            Dim frm601_07DeliveryNoteJournalPosting As New frm601_07DeliveryNoteJournalPosting
            frm601_07DeliveryNoteJournalPosting.ObjForm = Me

            frm601_07DeliveryNoteJournalPosting.strLogOnUser = Me.strLogOnUser
            frm601_07DeliveryNoteJournalPosting.intLogOnUserID = Me.intLogOnUserID
            frm601_07DeliveryNoteJournalPosting.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_07DeliveryNoteJournalPosting.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_07DeliveryNoteJournalPosting.intLogOnDivision = Me.intLogOnDivision
            frm601_07DeliveryNoteJournalPosting.intLogOnHRLevelCode = Me.intLogOnHRLevelCode

            frm601_07DeliveryNoteJournalPosting.Show()

            frm601_07DeliveryNoteJournalPosting.txtStartDate.EditValue = Me.txtStartDate.EditValue
            frm601_07DeliveryNoteJournalPosting.txtEndDate.EditValue = Me.txtEndDate.EditValue

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub
End Class