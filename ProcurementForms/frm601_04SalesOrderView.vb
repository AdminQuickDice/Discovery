Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_04SalesOrderView

    Public frm601_04SalesOrderViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Public intLogOnHRLevelCode As Integer

    Private SelectedSalesOrderNo As String = ""
    Private SelectedSalesOrderDate As Date = Date.Today()
    Private SelectedClientCode As String = ""

    Private SelectedClientPONo As String = ""
    Private SelectedClientPODate As Date = Date.Today()
    Private SelectedQuotationNo As String = ""
    Private SelectedCompany As Integer = 1
    Private SelectedSalesPerson As String = ""

    Public SelectedIsSubmitted As Boolean
    Public SelectedIsVerified As Boolean
    Public SelectedIsApproved As Boolean

#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If intLogOnInventoryAccessLevel = 99 Then
                If intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry602_04SalesOrderViewMasterTableAdapter.FillByDate(Me.Dsfrm601_04SalesOrderView.qry602_04SalesOrderViewMaster, StartDate, EndDate)
                Else
                    Me.Qry602_04SalesOrderViewMasterTableAdapter.FillByDateBySalesPersonUserID(Me.Dsfrm601_04SalesOrderView.qry602_04SalesOrderViewMaster, StartDate, EndDate, Me.intLogOnUserID)
                End If


            Else
                If intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry602_04SalesOrderViewMasterTableAdapter.FillByDateByGroup(Me.Dsfrm601_04SalesOrderView.qry602_04SalesOrderViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                Else
                    Me.Qry602_04SalesOrderViewMasterTableAdapter.FillByDateByGroupBySalesPersonUserID(Me.Dsfrm601_04SalesOrderView.qry602_04SalesOrderViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                End If


            End If

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Sales Order Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry602_04SalesOrderViewMasterTableAdapter.NoOfSalesOrdersAddedToday())
        Else
            nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry602_04SalesOrderViewMasterTableAdapter.NoOfSalesOrdersAddedTodayByGroup(Me.intLogOnInventoryAccessLevel))
        End If
        nwTile.Frames(0).Elements(3).Text = "New Sales Order's"
        nwTile.Frames(0).Elements(4).Text = "Today"

        'No of Sales Order's waiting for Approval
        nwTile.Frames(1).Elements(1).Text = "You have"
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry602_04SalesOrderViewMasterTableAdapter.NoOrSalesOrdersPendingApproval())
        Else
            nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry602_04SalesOrderViewMasterTableAdapter.NoOrSalesOrdersPendingApprovalByGroup(Me.intLogOnInventoryAccessLevel))
        End If

        nwTile.Frames(1).Elements(3).Text = "Pending for Approval"
        nwTile.Frames(1).Elements(4).Text = "Approval"

        'Deliveries Today
        nwTile.Frames(2).Elements(1).Text = "You have"
        nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(GetNoOfDeliveriesToday())
        nwTile.Frames(2).Elements(3).Text = "Deliveries"
        nwTile.Frames(2).Elements(4).Text = "Today"

        Dim nwTile3 As TileItem = Me.tileAllAssets
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry602_04SalesOrderViewMasterTableAdapter.NoOfSalesOrders(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue))
        Else
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry602_04SalesOrderViewMasterTableAdapter.NoOfSalesOrdersByGroup(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, Me.intLogOnInventoryAccessLevel))
        End If
    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub

#End Region
    Public Sub ImplementAccess(ByVal UserID As Integer)
        Try
            If GetUserAccess(UserID, "frm601_04SalesOrderView_FullAccess") = True Then

                Me.btnShowAllRecords.Enabled = True
                Me.btnSaveLayout.Enabled = True
                Me.btnOpenLayout.Enabled = True
                Me.btnResetLayout.Enabled = True
                Me.btnSetDefaultLayout.Enabled = True
                Me.btnPrint.Enabled = True
                Me.btnSearch.Enabled = True
                Me.btnGroup.Enabled = True
                Me.btnSalesOrderDetails.Enabled = True
                Me.btnAddNewSalesOrder.Enabled = True
                Me.btnEditSalesOrder.Enabled = True
                Me.btnUnlockSalesOrder.Enabled = True
                Me.btnDeleteSalesOrder.Enabled = True
                Me.btnCreatePartialDelivery.Enabled = True
                Me.btnCreateFullDelivery.Enabled = True
                Me.btnCreateInvoice.Enabled = True

            Else
                Me.btnShowAllRecords.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnShowAllRecords")
                Me.btnSaveLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnSaveLayout")
                Me.btnOpenLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnOpenLayout")
                Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnResetLayout")
                Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnSetDefaultLayout")
                Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnPrint")
                Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnSearch")
                Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnGroup")
                Me.btnSalesOrderDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnSalesOrderDetails")
                Me.btnAddNewSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnAddNewSalesOrder")
                Me.btnEditSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnEditSalesOrder")
                Me.btnUnlockSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnUnlockSalesOrder")
                Me.btnDeleteSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnDeleteSalesOrder")
                Me.btnCreatePartialDelivery.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnCreatePartialDelivery")
                Me.btnCreateFullDelivery.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnCreateFullDelivery")
                Me.btnCreateInvoice.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_04SalesOrderView_btnCreateInvoice")

            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_04SalesOrderViewIsClosed = True
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
                SelectedSalesOrderNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SalesOrderNo"))
                SelectedSalesOrderDate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SalesOrderDate"))

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))) = False Then
                    SelectedClientCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))
                Else
                    SelectedClientCode = ""
                End If


                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientPONo"))) = False Then
                    SelectedClientPONo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientPONo"))
                Else
                    SelectedClientPONo = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientPODate"))) = False Then
                    SelectedClientPODate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientPODate"))
                Else
                    SelectedClientPODate = Date.Today()
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("QuoteNo"))) = False Then
                    SelectedQuotationNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("QuoteNo"))
                Else
                    SelectedQuotationNo = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SalesPersonCode"))) = False Then
                    SelectedSalesPerson = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SalesPersonCode"))
                Else
                    SelectedSalesPerson = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("CompanyBranch"))) = False Then
                    SelectedCompany = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("CompanyBranch"))
                Else
                    SelectedCompany = 1
                End If

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
            frm601_03SalesOrderEdit.isExecutedFrom_frm601_04SalesOrderView = True

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

            If frm601_03SalesOrderEdit.CheckIfSalesOrderIsSubmitted(SalesOrderNo) = True Then

                frm601_03SalesOrderEdit.DisableAllControls()
                frm601_03SalesOrderEdit.btnSubmit.Enabled = False

                If Me.SelectedIsVerified = False And Me.SelectedIsApproved = False Then
                    'Check if the User is allowed to verify the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_03SalesOrderEdit_btnVerify") = True Then
                        frm601_03SalesOrderEdit.EnableAllControls()
                        frm601_03SalesOrderEdit.btnSubmit.Enabled = False
                        frm601_03SalesOrderEdit.btnVerify.Enabled = True
                        frm601_03SalesOrderEdit.btnApprove.Enabled = False
                    End If
                End If

            End If

            If frm601_03SalesOrderEdit.CheckIfSalesOrderIsVerified(SalesOrderNo) = True Then
                frm601_03SalesOrderEdit.DisableAllControls()
                frm601_03SalesOrderEdit.btnSubmit.Enabled = False
                frm601_03SalesOrderEdit.btnVerify.Enabled = False

                If Me.SelectedIsApproved = False Then
                    'Check if the User is allowed to Approve the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_03SalesOrderEdit_btnApprove") = True Then
                        frm601_03SalesOrderEdit.EnableAllControls()
                        frm601_03SalesOrderEdit.btnSubmit.Enabled = False
                        frm601_03SalesOrderEdit.btnVerify.Enabled = False
                        frm601_03SalesOrderEdit.btnApprove.Enabled = True
                    End If
                End If
            End If

            If frm601_03SalesOrderEdit.CheckIfSalesOrderIsApproved(SalesOrderNo) = True Then
                frm601_03SalesOrderEdit.DisableAllControls()

            End If

            GetCompanyDetails02(1)
            If gIsAmendSalesOrderAfterDN = False Then
                If CheckSalesOrderDeliveryStatus(SalesOrderNo) = "Fully Delivered" Or CheckSalesOrderDeliveryStatus(SalesOrderNo) = "Partially Delivered" Then
                    frm601_03SalesOrderEdit.DisableAllControls()
                End If
            End If

        End If
    End Sub
    Private Sub btnPopupEditQuotation_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditSalesOrder.ItemClick
        Me.OpenSalesOrder(Me.SelectedSalesOrderNo)
    End Sub

    Private Sub frm601_04SalesOrderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()

        Me.ImplementAccess(Me.intLogOnUserID)

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_04SalesOrderView", Me.gvAdvBandedQuotationView)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colTotalAfterDiscount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalBeforeDiscount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalTaxAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalWithTax.DisplayFormat.FormatString = "{0:#,0.000}"
            colDiscount1.DisplayFormat.FormatString = "{0:#,0.000}"

        End If

    End Sub


    Private Sub repoQuoteNo_Click(sender As Object, e As EventArgs) Handles repoQuoteNo.Click
        Dim strSalesOrderNo As String = Me.gvAdvBandedQuotationView.GetRowCellValue(Me.gvAdvBandedQuotationView.FocusedRowHandle, "SalesOrderNo")
        If CheckIfNull(strSalesOrderNo) = True Then
            MessageBox.Show("Please select the Sales Order No. to edit.", "Select Sales Order No. to edit", MessageBoxButtons.OK)
        Else
            Me.OpenSalesOrder(strSalesOrderNo)
        End If
    End Sub

    Private Sub btnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteSalesOrder.ItemClick
        Try
            If CheckSalesOrderDeliveryStatus(Me.SelectedSalesOrderNo) = "Fully Delivered" Or CheckSalesOrderDeliveryStatus(Me.SelectedSalesOrderNo) = "Partially Delivered" Then
                MessageBox.Show("You cannot delete this Sales Order, Sales Order has related Delivery Notes, Please Remove the Delivery Notes to Unlock this Sales Order and try again.", "Delivery Notes Generated.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If

            'Check if the Voucher is approved already
            If CheckIfSalesOrderIsApproved(Me.SelectedSalesOrderNo) = True Then
                MessageBox.Show("Sales Order is already approved, You cannot delete the Approved Sales Order", "Sales Order Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            'Check if the Sales Order has Cost Center already
            GetCompanyDetails02(1)
            If gIsCreateCostCenterFromSalesOrder = True Then
                If CheckIfSalesOrderHasCostCenter(Me.SelectedSalesOrderNo) = True Then
                    MessageBox.Show("Sales Order has Cost Center Created in Finance Modules, You cannot delete the Sales Order." & vbCrLf & "Please delete the Cost Center Details from CHART OF COST CENTERS  from Finance Modules to Proceed.", "Sales Order has related Cost Center", MessageBoxButtons.OK)
                    Exit Sub
                End If

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Sales Order from the Register," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedSalesOrderNo) = False Then
                    If DeleteSalesOrder(Me.SelectedSalesOrderNo) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.SelectedSalesOrderNo, "VoucherScanned\IMSSO")

                        MessageBox.Show("Sales Order has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Sales Order", "IMS Sales Order Ref No." & Me.SelectedSalesOrderNo & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedSalesOrderNo)

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


    Private Function CheckIfSalesOrderIsApproved(ByVal SalesOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select SalesOrderNo from tbl602_01SalesOrderMaster where (SalesOrderNo = '" & SalesOrderNo & "') and (Isnull(IsApproved,0) = 1 )"

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

    Public Function CheckIfSalesOrderHasCostCenter(ByVal SalesOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "SELECT  CostAllocationUnitID FROM tbl201CostAllocationUnits WHERE (CostAllocationUnitID = '" & SalesOrderNo & "')"

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

    Private Function DeleteSalesOrder(ByVal SalesOrderNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl602_01SalesOrderMaster WHERE SalesOrderNo   = '" & SalesOrderNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl602_02SalesOrderChild WHERE SalesOrderNo   = '" & SalesOrderNo & "'"
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

    Private Sub btnAddNewSalesOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewSalesOrder.ItemClick
        Dim frm601_03SalesOrderEdit As New frm601_03SalesOrderEdit
        frm601_03SalesOrderEdit.ObjForm = Me

        frm601_03SalesOrderEdit.btnSave.Caption = "Save"
        frm601_03SalesOrderEdit.isBeingNew = True
        frm601_03SalesOrderEdit.strLogonUser = Me.strLogOnUser
        frm601_03SalesOrderEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_03SalesOrderEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_03SalesOrderEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_03SalesOrderEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_03SalesOrderEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
        frm601_03SalesOrderEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
        frm601_03SalesOrderEdit.isExecutedFrom_frm601_04SalesOrderView = True
        frm601_03SalesOrderEdit.Show()

        GetCompanyDetails(1)
        Dim NewSalesOrderNo As String = frm601_03SalesOrderEdit.GetNewSalesOrderNo(gSalesOrderAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote)
        frm601_03SalesOrderEdit.CreatedNewSalesOrderNo = NewSalesOrderNo
        frm601_03SalesOrderEdit.NewSalesOrderMaster(NewSalesOrderNo)
        frm601_03SalesOrderEdit.txtSalesOrderNo.EditValue = NewSalesOrderNo
        frm601_03SalesOrderEdit.txtSalesOrderDate.EditValue = Date.Today
        frm601_03SalesOrderEdit.UpdateDefaultFields()

    End Sub

    Private Sub btnUnlockInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnlockSalesOrder.ItemClick
        If CheckSalesOrderDeliveryStatus(Me.SelectedSalesOrderNo) = "Fully Delivered" Or CheckSalesOrderDeliveryStatus(Me.SelectedSalesOrderNo) = "Partially Delivered" Then
            MessageBox.Show("You cannot unlock this Sales Order, Sales Order has related Delivery Notes, Please Remove the Delivery Notes to Unlock this Sales Order and try again.", "Delivery Notes Generated.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If


        If Me.intLogOnUserLevel = 99 Then
            Me.UnlockTheSalesOrder(Me.SelectedSalesOrderNo)
            MessageBox.Show("Sales Order has been unlocked successfully.", "Sales Order Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Update the Delete Log File
            InsertUserEntryLogSheet("IMS Sales Order", "IMS Sales Order Ref No." & Me.SelectedSalesOrderNo & " has been Unlock by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedSalesOrderNo)

            'Refresh the screen
            Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        Else
            MessageBox.Show("Your user access level cannot unlock the Sales Order, Please review again.", "Access Permission Denied.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If

    End Sub

    Private Function UnlockTheSalesOrder(ByVal SalesOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            'strSqlQueryText = "UPDATE tbl602_01SalesOrderMaster Set IsApproved = 0, ApprovedBy = ''  where SalesOrderNo = '" & SalesOrderNo & "'"

            strSqlQueryText = "UPDATE tbl602_01SalesOrderMaster Set 
                                IsSubmitted = 0, SubmittedBy = '', SubmittedOn = NULL, 
                                IsVerified = 0, VerifiedBy = '', VerifiedOn = NULL, 
                                IsApproved = 0, ApprovedBy = '', ApprovedOn = NULL 
                                where SalesOrderNo = '" & SalesOrderNo & "'"

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
            Dim formID As String = "frm601_04SalesOrderView"

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


    Private Sub btnCreateFullDelivery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateFullDelivery.ItemClick
        
        'Check if the Items are partially delivered or fully delivered already for this Sales Order

        If CheckSalesOrderDeliveryStatus(Me.SelectedSalesOrderNo) = "Fully Delivered" Then
            MessageBox.Show("Sales Order is fully Delivered, you cannot create Delivery for this Order anymore, Please review again.", "Sales Order status is Fully Delivered.", MessageBoxButtons.OK)
            Exit Sub

        End If

        If CheckSalesOrderDeliveryStatus(Me.SelectedSalesOrderNo) = "Partially Delivered" Then
            MessageBox.Show("Sales Order is partially Delivered, you cannot create Full Delivery for this Order anymore, Please review again.", "Sales Order status is Partially Delivered.", MessageBoxButtons.OK)
            Exit Sub

        End If

        GetCompanyDetails02(1)
        If gIsUseStoreAvailabilityInDeliveryNote = True Then
            Try
                If CheckIfNull(Me.SelectedSalesOrderNo) = True Or Me.SelectedSalesOrderNo = String.Empty Then
                    MessageBox.Show("Sales Order No is Empty to review.", "No Sales Order", MessageBoxButtons.OK)
                Else

                    Dim frm601_04A_SalesOrderStoreAvailability As New frm601_04A_SalesOrderStoreAvailability
                    frm601_04A_SalesOrderStoreAvailability.objForm = Me
                    frm601_04A_SalesOrderStoreAvailability.isExecutedFrom_frm601_04SalesOrderView = True

                    frm601_04A_SalesOrderStoreAvailability.strLogOnUser = Me.strLogOnUser
                    frm601_04A_SalesOrderStoreAvailability.intLogOnUserID = Me.intLogOnUserID
                    frm601_04A_SalesOrderStoreAvailability.intLogOnUserLevel = Me.intLogOnUserLevel
                    frm601_04A_SalesOrderStoreAvailability.intLogOnAccessLevel = Me.intLogOnAccessLevel
                    frm601_04A_SalesOrderStoreAvailability.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                    frm601_04A_SalesOrderStoreAvailability.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

                    frm601_04A_SalesOrderStoreAvailability.SalesOrderNo = Me.SelectedSalesOrderNo

                    frm601_04A_SalesOrderStoreAvailability.Show()


                End If
            Catch ex As Exception

            End Try

        Else

            DialogResult = MessageBox.Show("You are about to create new Delivery Note." & vbCrLf & "Are you Sure want to continue creating Delivery Note?", "Confirm creating Delivery Note.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedSalesOrderNo) = False Then

                    'Get New Delivery Note Number
                    GetCompanyDetails(1)
                    Dim NewDeliveryNoteNo As String = frm601_05DeliveryNoteEdit.GetNewDeliveryNoteNo(gDeliveryNoteAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote, Date.Now, gIsResetDeliverInYear)

                    Me.CreateFullDeliveryFromSalesOrder(NewDeliveryNoteNo, 1, Me.SelectedSalesOrderNo, Me.strLogOnUser)
                    Me.OpenDeliveryNote(NewDeliveryNoteNo)

                    ''Refresh the datagrid
                    ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

        End If


    End Sub


    Public Sub OpenDeliveryNote(ByVal DeliveryNoteNo As String)
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

            frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_04SalesOrderView = True

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

        End If
    End Sub
    Private Sub CreateFullDeliveryFromSalesOrder(ByVal DeliveryNoteNo As String, ByVal DeliveryType As Integer, ByVal SalesOrderNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_05InsertToDeliveryNoteFromSalesOrder"
            Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
            Dim paramDeliveryType As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryType", SqlDbType.TinyInt)
            Dim paramSalesOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramDeliveryNoteNo.Value = DeliveryNoteNo
            paramDeliveryType.Value = DeliveryType
            paramSalesOrderNo.Value = SalesOrderNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Delivery Note is created successfully,", "Delivery Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Delivery Note Creation failed, Please try again", "Delivery Note Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub
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

    Private Sub btnCreatePartialDelivery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreatePartialDelivery.ItemClick
        'Check if the Items are fully delivered already for this Sales Order
        If CheckSalesOrderDeliveryStatus(Me.SelectedSalesOrderNo) = "Fully Delivered" Then
            MessageBox.Show("Sales Order is fully Delivered, you cannot create Delivery for this Order anymore, Please review again.", "Sales Order status is Fully Delivered.", MessageBoxButtons.OK)
            Exit Sub
        End If

        GetCompanyDetails02(1)
        If gIsUseStoreAvailabilityInDeliveryNote = True Then
            Try
                If CheckIfNull(Me.SelectedSalesOrderNo) = True Or Me.SelectedSalesOrderNo = String.Empty Then
                    MessageBox.Show("Sales Order No is Empty to review.", "No Sales Order", MessageBoxButtons.OK)
                Else

                    Dim frm601_04A_SalesOrderStoreAvailability As New frm601_04A_SalesOrderStoreAvailability
                    frm601_04A_SalesOrderStoreAvailability.objForm = Me
                    frm601_04A_SalesOrderStoreAvailability.isExecutedFrom_frm601_04SalesOrderView = True

                    frm601_04A_SalesOrderStoreAvailability.strLogOnUser = Me.strLogOnUser
                    frm601_04A_SalesOrderStoreAvailability.intLogOnUserID = Me.intLogOnUserID
                    frm601_04A_SalesOrderStoreAvailability.intLogOnUserLevel = Me.intLogOnUserLevel
                    frm601_04A_SalesOrderStoreAvailability.intLogOnAccessLevel = Me.intLogOnAccessLevel
                    frm601_04A_SalesOrderStoreAvailability.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                    frm601_04A_SalesOrderStoreAvailability.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

                    frm601_04A_SalesOrderStoreAvailability.SalesOrderNo = Me.SelectedSalesOrderNo

                    frm601_04A_SalesOrderStoreAvailability.Show()


                End If

            Catch ex As Exception

            End Try

        Else

            DialogResult = MessageBox.Show("You are about to create new Delivery Note." & vbCrLf & "Are you Sure want to continue creating Delivery Note?", "Confirm creating Delivery Note.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedSalesOrderNo) = False Then

                    'Get New Delivery Note Number
                    GetCompanyDetails(1)
                    Dim NewDeliveryNoteNo As String = frm601_05DeliveryNoteEdit.GetNewDeliveryNoteNo(gDeliveryNoteAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote, Date.Now, gIsResetDeliverInYear)

                    Me.CreatePartialDeliveryFromSalesOrder(NewDeliveryNoteNo, 1, Me.SelectedSalesOrderNo, Me.strLogOnUser)
                    Me.OpenDeliveryNote(NewDeliveryNoteNo)

                    ''Refresh the datagrid
                    ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

        End If

    End Sub

    Public Function CheckSalesOrderDeliveryStatus(ByVal SalesOrderNo As String) As String
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select OrderStatus, SalesOrderNo from qry602_04SalesOrderViewMaster where (SalesOrderNo = '" & SalesOrderNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    If CheckIfNull(srStockReader.Item("OrderStatus")) = False Then
                        Return srStockReader.Item("OrderStatus") & ""
                    Else
                        Return ""
                    End If
                End While
            Else
                Return ""
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return ""
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Sub CreatePartialDeliveryFromSalesOrder(ByVal DeliveryNoteNo As String, ByVal DeliveryType As Integer, ByVal SalesOrderNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_07InsertPartialDeliveryFromSalesOrder"
            Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
            Dim paramDeliveryType As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryType", SqlDbType.TinyInt)
            Dim paramSalesOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramDeliveryNoteNo.Value = DeliveryNoteNo
            paramDeliveryType.Value = DeliveryType
            paramSalesOrderNo.Value = SalesOrderNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Delivery Note is created successfully,", "Delivery Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Delivery Note Creation failed, Please try again", "Delivery Note Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnCreateInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateInvoice.ItemClick
        Try
            Dim frm601_16GenerateInvoiceFromDelivery As New frm601_16GenerateInvoiceFromDelivery
            frm601_16GenerateInvoiceFromDelivery.ObjForm = Me
            frm601_16GenerateInvoiceFromDelivery.strLogonUser = Me.strLogOnUser
            frm601_16GenerateInvoiceFromDelivery.intLogOnUserID = Me.intLogOnUserID
            frm601_16GenerateInvoiceFromDelivery.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_16GenerateInvoiceFromDelivery.intLogOnAccessLevel = Me.intLogOnAccessLevel

            frm601_16GenerateInvoiceFromDelivery.isExecutedFrom_frm601_04SalesOrderView = True
            frm601_16GenerateInvoiceFromDelivery.txtClientName.EditValue = Me.SelectedClientCode
            frm601_16GenerateInvoiceFromDelivery.txtSalesOrders.EditValue = Me.SelectedSalesOrderNo

            frm601_16GenerateInvoiceFromDelivery.strQuotationNo = Me.SelectedQuotationNo
            frm601_16GenerateInvoiceFromDelivery.strClientPONo = Me.SelectedClientPONo
            frm601_16GenerateInvoiceFromDelivery.strClientPODate = Me.SelectedClientPODate
            frm601_16GenerateInvoiceFromDelivery.strCompanyName = Me.SelectedCompany
            frm601_16GenerateInvoiceFromDelivery.strSalesPersonCode = Me.SelectedSalesPerson

            frm601_16GenerateInvoiceFromDelivery.ShowRecords()
            frm601_16GenerateInvoiceFromDelivery.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_04SalesOrderView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub btnSalesOrderDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalesOrderDetails.ItemClick
        Try
            Dim frm601_36SalesOrderItemDetails As New frm601_36SalesOrderItemDetails
            frm601_36SalesOrderItemDetails.ObjForm = Me

            frm601_36SalesOrderItemDetails.strLogOnUser = Me.strLogOnUser
            frm601_36SalesOrderItemDetails.intLogOnUserID = Me.intLogOnUserID
            frm601_36SalesOrderItemDetails.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_36SalesOrderItemDetails.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_36SalesOrderItemDetails.intLogOnDivision = Me.intLogOnDivision
            frm601_36SalesOrderItemDetails.intLogOnHRLevelCode = Me.intLogOnHRLevelCode
            frm601_36SalesOrderItemDetails.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_36SalesOrderItemDetails.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
            '
            frm601_36SalesOrderItemDetails.txtStartDate.EditValue = Me.txtStartDate.EditValue
            frm601_36SalesOrderItemDetails.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm601_36SalesOrderItemDetails.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnCreateProformaInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateProformaInvoice.ItemClick



        DialogResult = MessageBox.Show("You are about to create new Proforma Invoice." & vbCrLf & "Are you Sure want to continue creating Proforma Invoice?", "Confirm creating Proforma Invoice.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedSalesOrderNo) = False Then

                If String.IsNullOrEmpty(ConvertIfNull(GetLedgerNoFromClientCode(Me.SelectedClientCode))) Then
                    MessageBox.Show("Client Ledger is not Created, Please map the Client Ledger as per Finance Books.", "Client Ledger not Mapped", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub
                Else
                    'Get New Proforma Invoice
                    GetCompanyDetails(1)
                    Dim NewInvoiceNo As String = frm20181ProformaInvoiceEdit.GetNewProformaInvoiceNo("", gInvoiceYearDigits, Date.Now, gIsResetInvoiceInYear)

                    Dim NoOfDaysDue As Decimal = GetDueDateOfInvoice(GetLedgerNoFromClientCode(Me.SelectedClientCode))
                    Me.CreateProformaFromSalesOrder(NewInvoiceNo, Me.SelectedSalesOrderNo, GetLedgerNoFromClientCode(Me.SelectedClientCode),
                                                    Date.Today.AddDays(NoOfDaysDue), Me.strLogOnUser)
                    Me.OpenProformaInvoice(NewInvoiceNo)
                End If

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub CreateProformaFromSalesOrder(ByVal ProformaInvoiceNo As String, ByVal SalesOrderNo As String, ByVal ClientLedgerNo As String,
                                             ByVal DueDate As Date, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_05InsertToProformaFromSalesOrder"
            Dim paramProformaInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ProformaInvoiceNo", SqlDbType.VarChar)
            Dim paramSalesOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderNo", SqlDbType.VarChar)
            Dim paramClientLedgerNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ClientLedgerNo ", SqlDbType.VarChar)
            Dim paramDueDate As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DueDate ", SqlDbType.Date)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramProformaInvoiceNo.Value = ProformaInvoiceNo
            paramSalesOrderNo.Value = SalesOrderNo
            paramClientLedgerNo.Value = ClientLedgerNo
            paramDueDate.Value = DueDate
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Proforma Invoice is created successfully,", "Proforma Invoice created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Proforma Invoice Creation failed, Please try again", "Proforma Invoice Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public Sub OpenProformaInvoice(ByVal InvoiceNo As String)
        If CheckIfNull(InvoiceNo) = False Then
            Dim frm20181ProformaInvoiceEdit As New frm20181ProformaInvoiceEdit
            frm20181ProformaInvoiceEdit.ObjForm = Me
            'frm20161VATInvoiceEdit.txtQuotationNo.Enabled = True
            frm20181ProformaInvoiceEdit.btnSave.Caption = "Update"
            frm20181ProformaInvoiceEdit.Show()

            frm20181ProformaInvoiceEdit.strLogonUser = Me.strLogOnUser
            frm20181ProformaInvoiceEdit.intLogOnUserID = Me.intLogOnUserID
            frm20181ProformaInvoiceEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm20181ProformaInvoiceEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm20181ProformaInvoiceEdit.intLogOnDivision = Me.intLogOnDivision
            frm20181ProformaInvoiceEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel

            frm20181ProformaInvoiceEdit.isExecutedFrom_frm601_04SalesOrderView = True

            frm20181ProformaInvoiceEdit.RetrieveInvoiceMaster(InvoiceNo)

            frm20181ProformaInvoiceEdit.txtInvoiceNo.Enabled = False
            frm20181ProformaInvoiceEdit.DisableApprovedVoucherEditing(InvoiceNo)
            If GetProformaInvoiceCurrency(InvoiceNo) = 1 Then
                frm20181ProformaInvoiceEdit.IsVisibleOC = False
            Else
                frm20181ProformaInvoiceEdit.IsVisibleOC = True
            End If
            frm20181ProformaInvoiceEdit.SwitchColumns()

        End If
    End Sub

End Class