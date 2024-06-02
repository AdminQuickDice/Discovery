Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_02_QuotationView
    Public frm601_02_QuotationViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Public intLogOnHRLevelCode As Integer

    Private SelectedQuotationNo As String = ""
    Private SelectedQuotationDate As Date = Date.Today()

    Public SelectedIsSubmitted As Boolean
    Public SelectedIsVerified As Boolean
    Public SelectedIsApproved As Boolean

#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then

                If intLogOnInventoryAccessLevel = 99 Then
                    Me.Qry601_04QuotationViewMasterTableAdapter.FillByDate(Me.Dsfrm601_02QuotationView.qry601_04QuotationViewMaster, StartDate, EndDate)
                Else
                    Me.Qry601_04QuotationViewMasterTableAdapter.FillByDateByGroup(Me.Dsfrm601_02QuotationView.qry601_04QuotationViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                End If

            Else
                If intLogOnInventoryAccessLevel = 99 Then
                    Me.Qry601_04QuotationViewMasterTableAdapter.FillBySalesPersonCode(Me.Dsfrm601_02QuotationView.qry601_04QuotationViewMaster, StartDate, EndDate, SalesPersonCode)
                Else
                    Me.Qry601_04QuotationViewMasterTableAdapter.FillBySalesPersonByGroup(Me.Dsfrm601_02QuotationView.qry601_04QuotationViewMaster, StartDate, EndDate, SalesPersonCode, Me.intLogOnInventoryAccessLevel)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Quotation Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub UpdateFrames()

        Dim nwTile As TileItem = Me.tilePendingTasks
        'No of Quotations Today
        nwTile.Frames(0).Elements(1).Text = "You have"
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry601_04QuotationViewMasterTableAdapter.NoOfQuotationsAddedToday())
        Else
            nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry601_04QuotationViewMasterTableAdapter.NoOfQuotationsAddedTodayByGroup(Me.intLogOnInventoryAccessLevel))
        End If
        nwTile.Frames(0).Elements(3).Text = "New Quotation's"
        nwTile.Frames(0).Elements(4).Text = "Today"

        'No of Quotations waiting for Approval
        nwTile.Frames(1).Elements(1).Text = "You have"
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry601_04QuotationViewMasterTableAdapter.NoOfQuotationsPendingApproval())
        Else
            nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry601_04QuotationViewMasterTableAdapter.NoOfQuotationsPendingApprovalByGroup(Me.intLogOnInventoryAccessLevel))
        End If

        nwTile.Frames(1).Elements(3).Text = "Pending for Approval"
        nwTile.Frames(1).Elements(4).Text = "Approval"

        'No of Quotations waiting for Sales Order
        nwTile.Frames(2).Elements(1).Text = "You have"
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry601_04QuotationViewMasterTableAdapter.NoOfQuotationWaitingSalesOrder())
        Else
            nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry601_04QuotationViewMasterTableAdapter.NoOfQuotationWaitingSalesOrderByGroup(Me.intLogOnInventoryAccessLevel))
        End If
        nwTile.Frames(2).Elements(3).Text = "waiting for Sales Order"
        nwTile.Frames(2).Elements(4).Text = "Waiting"

        Dim nwTile3 As TileItem = Me.tileAllAssets
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry601_04QuotationViewMasterTableAdapter.GetNoOfQuotations(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue))
        Else
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry601_04QuotationViewMasterTableAdapter.GetNoOfQuotationsByGroup(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, Me.intLogOnInventoryAccessLevel))
        End If

    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub

#End Region

    Public Sub ImplementAccess(ByVal UserID As Integer)
        Try
            If GetUserAccess(UserID, "frm601_02_QuotationView_FullAccess") = True Then

                Me.btnShowAllRecords.Enabled = True
                Me.btnSaveLayout.Enabled = True
                Me.btnOpenLayout.Enabled = True
                Me.btnResetLayout.Enabled = True
                Me.btnSetDefaultLayout.Enabled = True
                Me.btnPrint.Enabled = True
                Me.btnSearch.Enabled = True
                Me.btnGroup.Enabled = True
                Me.btnQuotationDetails.Enabled = True
                Me.btnAddNewQuotation.Enabled = True
                Me.btnEditQuote.Enabled = True
                Me.btnDuplicateQuotation.Enabled = True
                Me.btnDeleteQuote.Enabled = True
                Me.btnUnlockQuotation.Enabled = True
                Me.btnReviseQuotation.Enabled = True
                Me.btnCreateSalesOrder.Enabled = True

            Else
                Me.btnShowAllRecords.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnShowAllRecords")
                Me.btnSaveLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnSaveLayout")
                Me.btnOpenLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnOpenLayout")
                Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnResetLayout")
                Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnSetDefaultLayout")
                Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnPrint")
                Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnSearch")
                Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnGroup")
                Me.btnQuotationDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnQuotationDetails")
                Me.btnAddNewQuotation.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnAddNewQuotation")
                Me.btnEditQuote.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnEditQuote")
                Me.btnDuplicateQuotation.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnDuplicateQuotation")
                Me.btnDeleteQuote.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnDeleteQuote")
                Me.btnUnlockQuotation.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnUnlockQuotation")
                Me.btnReviseQuotation.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnReviseQuotation")
                Me.btnCreateSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_02_QuotationView_btnCreateSalesOrder")

            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_02_QuotationViewIsClosed = True
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
                SelectedQuotationNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("QuoteNo"))
                SelectedQuotationDate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("QuoteDate"))

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsSubmitted"))) = False Then
                    SelectedIsSubmitted = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsSubmitted"))
                Else
                    SelectedIsSubmitted = False
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsVerified"))) = False Then
                    SelectedIsVerified = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsVerified"))
                Else
                    SelectedIsVerified = False
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsApproved"))) = False Then
                    SelectedIsApproved = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsApproved"))
                Else
                    SelectedIsApproved = False
                End If

                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub OpenQuotation(ByVal QuotationNo As String)
        If CheckIfNull(QuotationNo) = False Then
            Dim frm601_01QuotationEdit As New frm601_01QuotationEdit
            frm601_01QuotationEdit.ObjForm = Me
            frm601_01QuotationEdit.txtQuotationNo.Enabled = False
            frm601_01QuotationEdit.btnSave.Caption = "Update"

            frm601_01QuotationEdit.strLogonUser = Me.strLogOnUser
            frm601_01QuotationEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_01QuotationEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_01QuotationEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_01QuotationEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_01QuotationEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_01QuotationEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
            frm601_01QuotationEdit.isExecutedFrom_frm601_02_QuotationView = True

            frm601_01QuotationEdit.Show()
            frm601_01QuotationEdit.RetrieveQuotationMaster(QuotationNo)

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_01QuotationEdit.txtSalesPerson.Enabled = True
            Else
                frm601_01QuotationEdit.txtSalesPerson.Enabled = False
            End If

            frm601_01QuotationEdit.txtQuotationNo.Enabled = False
            frm601_01QuotationEdit.DisableApprovedVoucherEditing(QuotationNo)
            frm601_01QuotationEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

            If frm601_01QuotationEdit.CheckIfQuotationIsSubmitted(QuotationNo) = True Then

                frm601_01QuotationEdit.DisableAllControls()
                frm601_01QuotationEdit.btnSubmit.Enabled = False

                If Me.SelectedIsVerified = False And Me.SelectedIsApproved = False Then
                    'Check if the User is allowed to verify the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_01QuotationEdit_btnVerify") = True Then
                        frm601_01QuotationEdit.EnableAllControls()
                        frm601_01QuotationEdit.btnSubmit.Enabled = False
                        frm601_01QuotationEdit.btnVerify.Enabled = True
                        frm601_01QuotationEdit.btnApprove.Enabled = False
                    End If
                End If

            End If

            If frm601_01QuotationEdit.CheckIfQuotationIsVerified(QuotationNo) = True Then
                frm601_01QuotationEdit.DisableAllControls()
                frm601_01QuotationEdit.btnSubmit.Enabled = False
                frm601_01QuotationEdit.btnVerify.Enabled = False

                If Me.SelectedIsApproved = False Then
                    'Check if the User is allowed to Approve the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_01QuotationEdit_btnApprove") = True Then
                        frm601_01QuotationEdit.EnableAllControls()
                        frm601_01QuotationEdit.btnSubmit.Enabled = False
                        frm601_01QuotationEdit.btnVerify.Enabled = False
                        frm601_01QuotationEdit.btnApprove.Enabled = True
                    End If
                End If
            End If

            If frm601_01QuotationEdit.CheckIfQuotationIsApproved(QuotationNo) = True Then
                frm601_01QuotationEdit.DisableAllControls()

            End If

            GetCompanyDetails02(1)
            If gIsAmendSalesOrderAfterDN = False Then
                If CheckIfSalesOrderIsAvailableForQuotation(QuotationNo) = True Then
                    frm601_01QuotationEdit.DisableAllControls()
                End If
            End If
        End If

    End Sub
    Private Sub btnPopupEditQuotation_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditQuote.ItemClick
        Me.OpenQuotation(Me.SelectedQuotationNo)
    End Sub

    Private Sub frm40104PropertyQuoteView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tbl20101SalesPersonMasterTableAdapter.Fill(Me.Dsfrm601_02QuotationView1.tbl20101SalesPersonMaster)

        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()

        Me.ImplementAccess(Me.intLogOnUserID)

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_02_QuotationView", Me.gvAdvBandedQuotationView)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colTotalBeforeDiscount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalAfterDiscount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalTaxAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalWithTax.DisplayFormat.FormatString = "{0:#,0.000}"
            colDiscount1.DisplayFormat.FormatString = "{0:#,0.000}"
            colAdditions.DisplayFormat.FormatString = "{0:#,0.000}"
            colDeductions.DisplayFormat.FormatString = "{0:#,0.000}"
            colNetTotal.DisplayFormat.FormatString = "{0:#,0.000}"
        End If
    End Sub


    Private Sub repoQuoteNo_Click(sender As Object, e As EventArgs) Handles repoQuoteNo.Click
        Dim strQuoteNo As String = Me.gvAdvBandedQuotationView.GetRowCellValue(Me.gvAdvBandedQuotationView.FocusedRowHandle, "QuoteNo")
        If CheckIfNull(strQuoteNo) = True Then
            MessageBox.Show("Please select the Quotation No. to edit.", "Select Quotation No. to edit", MessageBoxButtons.OK)
        Else
            Me.OpenQuotation(strQuoteNo)
        End If
    End Sub

    Private Sub btnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteQuote.ItemClick
        Try
            If CheckIfSalesOrderIsAvailableForQuotation(Me.SelectedQuotationNo) = True Then
                MessageBox.Show("You cannot Delete this Quotation, Sales Order has been Generated for this Quotation, Please Remove the Sales Order to Unlock this Quotation and try again.", "Sales Order Generated.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If

            'Check if the Voucher is approved already
            If CheckIfQuotationIsApproved(Me.SelectedQuotationNo) = True Then
                MessageBox.Show("Quotation is already approved, You cannot delete the Approved Quotation", "Quotation Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Quotation from the Register," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedQuotationNo) = False Then
                    If DeleteQuotation(Me.SelectedQuotationNo) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.SelectedQuotationNo, "VoucherScanned\IMSQuote")

                        MessageBox.Show("Quotation has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Quotation", "IMS Quotation No." & Me.SelectedQuotationNo & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedQuotationNo)

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


    Private Function CheckIfQuotationIsApproved(ByVal QuoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select QuoteNo from tbl601_01QuotationMaster where (QuoteNo = '" & QuoteNo & "') and (Isnull(IsApproved,0) = 1 )"

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
    Private Function DeleteQuotation(ByVal QuoteNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl601_01QuotationMaster WHERE QuoteNo   = '" & QuoteNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl601_02QuotationChild WHERE QuoteNo   = '" & QuoteNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl601_04QuotationItemCosts WHERE QuoteNo   = '" & QuoteNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl601_03QuotationTerms WHERE QuoteNo   = '" & QuoteNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "UPDATE tbl606_01PurchaseRequestMaster SET MaterialQuoteNo = NULL WHERE MaterialQuoteNo   = '" & QuoteNo & "'"
            delPRTrans.ExecuteNonQuery()
            myTrans.Commit()
            Return True

        Catch ex As Exception
            Try
                myTrans.Rollback("PRTransaction")
                Return False
            Catch Sqlex As System.Data.SqlClient.SqlException
                If Not myTrans.Connection Is Nothing Then
                    MessageBox.Show("An exception of type " & Sqlex.GetType().ToString() &
                                      " was encountered while attempting to roll back the transaction.", "Error on Delete", MessageBoxButtons.OK)
                End If
                MessageBox.Show("An exception of type " & ex.GetType().ToString() &
                                      "was encountered while inserting the data.")
                Return False
            End Try
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub btnAddNewQuotation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewQuotation.ItemClick
        Dim frm601_01QuotationEdit As New frm601_01QuotationEdit
        frm601_01QuotationEdit.ObjForm = Me

        frm601_01QuotationEdit.btnSave.Caption = "Save"
        frm601_01QuotationEdit.isBeingNew = True
        frm601_01QuotationEdit.strLogonUser = Me.strLogOnUser
        frm601_01QuotationEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_01QuotationEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_01QuotationEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_01QuotationEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_01QuotationEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
        frm601_01QuotationEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
        frm601_01QuotationEdit.isExecutedFrom_frm601_02_QuotationView = True

        frm601_01QuotationEdit.Show()

        GetCompanyDetails(1)
        GetCompanyDetails02(1)
        Dim NewQuotationNo As String = frm601_01QuotationEdit.GetNewQuotationNo(gQuotationAbbrv, gInvoiceYearDigits, Date.Now, gIsResetQuoteInYear, gNoOfDigitsToInventoryQuotation)
        frm601_01QuotationEdit.CreatedNewQuotationNo = NewQuotationNo
        frm601_01QuotationEdit.NewInvoiceMaster(NewQuotationNo)
        frm601_01QuotationEdit.txtQuotationNo.EditValue = NewQuotationNo
        frm601_01QuotationEdit.txtQuoteDate.EditValue = Date.Today
        frm601_01QuotationEdit.UpdateDefaultFields()

    End Sub

    Private Sub btnUnlockInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnlockQuotation.ItemClick

        If CheckIfSalesOrderIsAvailableForQuotation(Me.SelectedQuotationNo) = True Then
            MessageBox.Show("You cannot unlock this Quotation, Sales Order has been Generated for this Quotation, Please Remove the Sales Order to Unlock this Quotation and try again.", "Sales Order Generated.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If

        If Me.intLogOnUserLevel = 99 Then
            Me.UnlockTheQuotation(Me.SelectedQuotationNo)
            MessageBox.Show("Quotation has been unlocked successfully.", "Quotation Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Update the Delete Log File
            InsertUserEntryLogSheet("IMS Quotation", "IMS Quotation No." & Me.SelectedQuotationNo & " has been Unlocked by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedQuotationNo)

            'Refresh the screen
            Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        Else
            MessageBox.Show("Your user access level cannot unlock the Quotation, Please review again.", "Access Permission Denied.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If

    End Sub

    Private Function UnlockTheQuotation(ByVal QuoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            'strSqlQueryText = "UPDATE tbl601_01QuotationMaster Set IsApproved = 0, ApprovedBy = ''  where QuoteNo = '" & QuoteNo & "'"

            strSqlQueryText = "UPDATE tbl601_01QuotationMaster Set 
                                IsSubmitted = 0, SubmittedBy = '', SubmittedOn = NULL, 
                                IsVerified = 0, VerifiedBy = '', VerifiedOn = NULL, 
                                IsApproved = 0, ApprovedBy = '', ApprovedOn = NULL 
                                where QuoteNo = '" & QuoteNo & "'"

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
            Dim formID As String = "frm601_02_QuotationView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvAdvBandedQuotationView))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvAdvBandedQuotationView))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
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

    Private Sub btnReviseQuotation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReviseQuotation.ItemClick
        'Get the Quotation No to be revised... add the Revision No as the new ended... 
        DialogResult = MessageBox.Show("You are about to revise this Quotation." & vbCrLf & "Are you Sure want to continue adding new revised Quotation?", "Confirm creating revised Quotation.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedQuotationNo) = False Then

                Dim NewRevisionNo As Integer = GetNewQuotationRevisionNo(Me.SelectedQuotationNo)

                Dim QuotationNoTrimmed As String = Me.SelectedQuotationNo
                Dim QuotationIndex As Integer = QuotationNoTrimmed.IndexOf("(")

                If QuotationIndex > -1 Then
                    QuotationNoTrimmed = QuotationNoTrimmed.Substring(0, QuotationIndex - 1)
                Else
                    QuotationNoTrimmed = QuotationNoTrimmed
                End If
                Dim NewQuotatioNo As String = QuotationNoTrimmed & "-(R" & NewRevisionNo & ")"

                Me.CreateNewRevisedQuotation(Me.SelectedQuotationNo, NewQuotatioNo, NewRevisionNo, Me.strLogOnUser)

                'Update Old Quotation status to "Revised"
                Me.UpdateQuoteStatus(Me.SelectedQuotationNo, 5)

                Me.OpenQuotation(NewQuotatioNo)
                'Refresh the datagrid
                Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If


    End Sub

    Public Function UpdateQuoteStatus(ByVal QuotationNo As String, ByVal QuoteStatus As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl601_01QuotationMaster SET QuoteStatus = '" & QuoteStatus & "' WHERE (QuoteNo = '" & QuotationNo & "') "

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

    Public Function GetNewQuotationRevisionNo(ByVal QuotationNo As String) As Integer
        'Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim QuotationNoTrimmed As String = QuotationNo
            Dim QuotationIndex As Integer = QuotationNoTrimmed.IndexOf("(")

            If QuotationIndex > -1 Then
                QuotationNoTrimmed = QuotationNo.Substring(0, QuotationIndex - 1)
            Else
                QuotationNoTrimmed = QuotationNo
            End If


            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(RevisionNo) from tbl601_01QuotationMaster WHERE QuoteNo like '" & QuotationNoTrimmed & "%' "
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1
            Return int1

        Catch ex As System.InvalidCastException
            Return 1

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub CreateNewRevisedQuotation(ByVal QuotationNo As String, ByVal NewQuotationNo As String, ByVal RevisionNo As Integer, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_05CreateNewRevisedQuotation"
            Dim paramQuotationNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@QuotationNo", SqlDbType.VarChar)
            Dim paramNewQuotationNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@NewQuotationNo", SqlDbType.VarChar)
            Dim paramRevisionNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@RevisionNo", SqlDbType.TinyInt)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramQuotationNo.Value = QuotationNo
            paramNewQuotationNo.Value = NewQuotationNo
            paramRevisionNo.Value = RevisionNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Revised Quotation is created successfully,", "Revised Quotation created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Revised Quotation Creation failed, Please try again", "Revised Quotation Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub
#Region "Create Sales Order"

    Private Sub btnCreateSalesOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateSalesOrder.ItemClick
        'Check if the Sales Order already created for this Quotation
        If CheckIfSalesOrderIsAvailableForQuotation(Me.SelectedQuotationNo) = True Then
            MessageBox.Show("Sales Order is already created for this Quotation, Please review again.", "Sales Order Available.", MessageBoxButtons.OK)
            Exit Sub

        End If


        DialogResult = MessageBox.Show("You are about to create new Sales Order." & vbCrLf & "Are you Sure want to continue creating Sales Order?", "Confirm creating Sales Order.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedQuotationNo) = False Then

                'Get New Sales Order Number
                GetCompanyDetails(1)
                GetCompanyDetails02(1)
                Dim NewSalesOrderNo As String = frm601_03SalesOrderEdit.GetNewSalesOrderNo(gSalesOrderAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote)
                Me.CreateSalesOrderFromQuotation(NewSalesOrderNo, Me.SelectedQuotationNo, Me.strLogOnUser, gIsCreateCostCenterFromSalesOrder, gDefaultCostCenterMasterFromSalesOrder)
                Me.OpenSalesOrder(NewSalesOrderNo)

                'Update Old Quotation status to "Revised"
                Me.UpdateQuoteStatus(Me.SelectedQuotationNo, 8)

                ''Refresh the datagrid
                ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub


    Private Sub OpenSalesOrder(ByVal SalesOrderNo As String)
        If CheckIfNull(SalesOrderNo) = False Then
            Dim frm601_03SalesOrderEdit As New frm601_03SalesOrderEdit
            frm601_03SalesOrderEdit.ObjForm = Me
            frm601_03SalesOrderEdit.txtSalesOrderNo.Enabled = False
            frm601_03SalesOrderEdit.btnSave.Caption = "Update"
            frm601_03SalesOrderEdit.strLogonUser = Me.strLogOnUser
            frm601_03SalesOrderEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_03SalesOrderEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_03SalesOrderEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_03SalesOrderEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_03SalesOrderEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_03SalesOrderEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
            frm601_03SalesOrderEdit.isExecutedFrom_frm601_02_QuotationView = True

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_03SalesOrderEdit.txtSalesPerson.Enabled = True
            Else
                frm601_03SalesOrderEdit.txtSalesPerson.Enabled = False
            End If

            frm601_03SalesOrderEdit.Show()


            frm601_03SalesOrderEdit.RetrieveSalesOrderMaster(SalesOrderNo)

            frm601_03SalesOrderEdit.txtSalesOrderNo.Enabled = False
            frm601_03SalesOrderEdit.DisableApprovedVoucherEditing(SalesOrderNo)
            frm601_03SalesOrderEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

        End If
    End Sub

    Private Sub CreateSalesOrderFromQuotation(ByVal SalesOrderNo As String, ByVal QuotationNo As String, ByVal AddedBy As String, ByVal IsCreateCostCenterFromSalesOrder As Boolean, ByVal DefaultCostCenterMasterFromSalesOrder As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_04InsertToSalesOrderFromQuotation"
            Dim paramSalesOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderNo", SqlDbType.VarChar)
            Dim paramQuotationNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@QuotationNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramIsCreateCostCenterFromSalesOrder As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@IsCreateCostCenterFromSalesOrder", SqlDbType.Bit)
            Dim paramDefaultCostCenterMasterFromSalesOrder As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DefaultCostCenterMasterFromSalesOrder", SqlDbType.VarChar)

            paramSalesOrderNo.Value = SalesOrderNo
            paramQuotationNo.Value = QuotationNo
            paramAddedBy.Value = AddedBy
            paramIsCreateCostCenterFromSalesOrder.Value = IsCreateCostCenterFromSalesOrder
            paramDefaultCostCenterMasterFromSalesOrder.Value = DefaultCostCenterMasterFromSalesOrder

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Sales Order is created successfully,", "Sales Order created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Sales Order Creation failed, Please try again", "Sales Order  Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    'Public Function GetNewSalesOrderNo(ByVal SalesOrderAbbr As String, ByVal YearInDigit As Integer) As String
    '    Dim strNewQuotationNo As String = ""
    '    Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
    '    Try
    '        If Sqlconnection1.State = ConnectionState.Closed Then
    '            Sqlconnection1.Open()
    '        End If

    '        Dim SqlCommand1 As New SqlClient.SqlCommand
    '        SqlCommand1.Connection = Sqlconnection1
    '        SqlCommand1.CommandText = "select max(cast(right(SalesOrderNo,4) as int)) from tbl602_01SalesOrderMaster"
    '        Dim int1 As Integer
    '        int1 = SqlCommand1.ExecuteScalar()
    '        int1 = int1 + 1

    '        strNewQuotationNo = "0000" & CStr(int1)
    '        strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, 4)

    '        If CheckIfNull(YearInDigit) = True Then
    '            YearInDigit = 0
    '        End If

    '        Dim strYear As String = Year(Now).ToString
    '        strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

    '        strNewQuotationNo = strYear & "-" & strNewQuotationNo
    '        strNewQuotationNo = SalesOrderAbbr & strNewQuotationNo
    '        Return strNewQuotationNo

    '    Catch ex As System.InvalidCastException
    '        Dim strYear As String = Year(Now).ToString
    '        strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
    '        strNewQuotationNo = SalesOrderAbbr & strYear & "-" & "0001"
    '        Return strNewQuotationNo

    '    Finally
    '        Sqlconnection1.Close()

    '    End Try
    'End Function
#End Region

    Public Function CheckIfSalesOrderIsAvailableForQuotation(ByVal QuoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select QuoteNo, SalesOrderNo from qry601_04QuotationViewMaster where (QuoteNo = '" & QuoteNo & "') and (SalesOrderNo IS NOT NULL)"

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


    Private Sub btnDuplicateQuotation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDuplicateQuotation.ItemClick
        'Duplicate the Quotation
        Try
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to Duplicate this Quotation." & vbCrLf & "Are you Sure want to Continue?", "Confirm Duplication.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedQuotationNo) = False Then
                    If CheckIfNull(Me.SelectedQuotationDate) = False Then
                        'Get a new Quotation No
                        GetCompanyDetails(1)
                        GetCompanyDetails02(1)
                        Dim NewQuotationNo As String = frm601_01QuotationEdit.GetNewQuotationNo(gQuotationAbbrv, gInvoiceYearDigits, Date.Now, gIsResetQuoteInYear, gNoOfDigitsToInventoryQuotation)

                        If DuplicateIMSQuotation(Me.SelectedQuotationNo, NewQuotationNo, Me.SelectedQuotationDate, Me.strLogOnUser, Date.Now) = True Then
                            MessageBox.Show("Quotation has been successfully added to the database.", "Data insertion Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Refresh datagrid
                            Me.ShowRecords()
                        Else
                            MessageBox.Show("Quotation duplication Failed, please try again.", "Insertion Failed", MessageBoxButtons.OK)
                        End If
                    End If
                End If

            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_02_QuotationView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnQuotationDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuotationDetails.ItemClick
        Try
            Dim frm601_33QuotationDetails As New frm601_33QuotationDetails
            frm601_33QuotationDetails.ObjForm = Me

            frm601_33QuotationDetails.strLogOnUser = Me.strLogOnUser
            frm601_33QuotationDetails.intLogOnUserID = Me.intLogOnUserID
            frm601_33QuotationDetails.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_33QuotationDetails.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_33QuotationDetails.intLogOnDivision = Me.intLogOnDivision
            frm601_33QuotationDetails.intLogOnHRLevelCode = Me.intLogOnHRLevelCode
            frm601_33QuotationDetails.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_33QuotationDetails.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_33QuotationDetails.txtStartDate.EditValue = Me.txtStartDate.EditValue
            frm601_33QuotationDetails.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm601_33QuotationDetails.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub
End Class