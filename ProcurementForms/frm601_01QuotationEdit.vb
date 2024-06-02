Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraReports.UI

Imports System.Drawing
Imports DevExpress.XtraPrinting.Drawing
Imports System.Text
Imports DevExpress.XtraBars

Public Class frm601_01QuotationEdit

    Public isBeingUpdated As Boolean = False
    Public isBeingNew As Boolean = False
    Public isControlsModified As Boolean

    Public ObjForm As Object
    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Dim SelectedQuotationChildSlNo As Integer

    Public isExecutedFrom_frm601_02_QuotationView As Boolean = False
    Public isExecutedFrom_frm601_12PurchaseRequestView As Boolean = False
    Public isExecutedFrom_frm601_15QuotationAnalysis As Boolean = False

    Public CreatedNewQuotationNo As String


#Region "Ordering Code"
    Private Const OrderFieldName As String = "LineOrderNo"

    Private downHitInfo As GridHitInfo = Nothing

    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Dim view As GridView = gvInvoiceChild
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        If index <= 0 Then
            Return
        End If

        Dim row1 As DataRow = view.GetDataRow(index)
        Dim row2 As DataRow = view.GetDataRow(index - 1)
        Dim val1 As Object = row1(OrderFieldName)
        Dim val2 As Object = row2(OrderFieldName)
        row1(OrderFieldName) = val2
        row2(OrderFieldName) = val1

        view.FocusedRowHandle = index - 1
    End Sub

    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick
        Dim view As GridView = gvInvoiceChild
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        If index >= view.DataRowCount - 1 Then
            Return
        End If

        Dim row1 As DataRow = view.GetDataRow(index)
        Dim row2 As DataRow = view.GetDataRow(index + 1)
        Dim val1 As Object = row1(OrderFieldName)
        Dim val2 As Object = row2(OrderFieldName)
        row1(OrderFieldName) = val2
        row2(OrderFieldName) = val1

        view.FocusedRowHandle = index + 1
    End Sub

#End Region


#Region "Popup for Calculating Discount"

    Private Sub CalculateDiscount(ByVal Percent As Decimal)
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60102QuotationChildBindingSource.Current, DataRowView)
            Dim SelectedItemQty As Decimal = 0D
            Dim SelectedItemUnitPrice As Decimal = 0D

            SelectedItemQty = view.Row("QuotedQuantity")
            SelectedItemUnitPrice = view.Row("QuotedUnitPrice")

            Dim TotalBeforeDiscount As Decimal = 0D

            TotalBeforeDiscount = SelectedItemQty * SelectedItemUnitPrice

            Me.txtTotalBeforeDiscount.EditValue = TotalBeforeDiscount
            Me.txtDiscount.EditValue = TotalBeforeDiscount * Percent

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtDiscountPercentage_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDiscountPercentage.ButtonClick
        Try
            Dim DiscountPercentage As Decimal = 0D
            DiscountPercentage = Me.txtDiscountPercentage.EditValue / 100
            CalculateDiscount(DiscountPercentage)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles txtCalcDisc.Click
        CalculateDiscount(0.05)
    End Sub
    Private Sub txtCalcDisc10_Click(sender As Object, e As EventArgs) Handles txtCalcDisc10.Click
        CalculateDiscount(0.1)
    End Sub
    Private Sub txtCalcDisc15_Click(sender As Object, e As EventArgs) Handles txtCalcDisc15.Click
        CalculateDiscount(0.15)
    End Sub
    Private Sub txtCalcDisc20_Click(sender As Object, e As EventArgs) Handles txtCalcDisc20.Click
        CalculateDiscount(0.2)
    End Sub
    Private Sub txtCalcDisc25_Click(sender As Object, e As EventArgs) Handles txtCalcDisc25.Click
        CalculateDiscount(0.25)
    End Sub
    Private Sub txtCalcDisc30_Click(sender As Object, e As EventArgs) Handles txtCalcDisc30.Click
        CalculateDiscount(0.3)
    End Sub
    Private Sub txtCalcDisc35_Click(sender As Object, e As EventArgs) Handles txtCalcDisc35.Click
        CalculateDiscount(0.35)
    End Sub
    Private Sub txtCalcDisc40_Click(sender As Object, e As EventArgs) Handles txtCalcDisc40.Click
        CalculateDiscount(0.4)
    End Sub
    Private Sub txtCalcDisc45_Click(sender As Object, e As EventArgs) Handles txtCalcDisc45.Click
        CalculateDiscount(0.45)
    End Sub
    Private Sub txtCalcDisc50_Click(sender As Object, e As EventArgs) Handles txtCalcDisc50.Click
        CalculateDiscount(0.5)
    End Sub
    Private Sub txtCalcDisc55_Click(sender As Object, e As EventArgs) Handles txtCalcDisc55.Click
        CalculateDiscount(0.55)
    End Sub
    Private Sub txtCalcDisc60_Click(sender As Object, e As EventArgs) Handles txtCalcDisc60.Click
        CalculateDiscount(0.6)
    End Sub
    Private Sub txtCalcDisc65_Click(sender As Object, e As EventArgs) Handles txtCalcDisc65.Click
        CalculateDiscount(0.65)
    End Sub
    Private Sub txtCalcDisc70_Click(sender As Object, e As EventArgs) Handles txtCalcDisc70.Click
        CalculateDiscount(0.7)
    End Sub
    Private Sub txtCalcDisc75_Click(sender As Object, e As EventArgs) Handles txtCalcDisc75.Click
        CalculateDiscount(0.75)
    End Sub
    Private Sub txtCalcDisc80_Click(sender As Object, e As EventArgs) Handles txtCalcDisc80.Click
        CalculateDiscount(0.8)
    End Sub
    Private Sub txtCalcDisc85_Click(sender As Object, e As EventArgs) Handles txtCalcDisc85.Click
        CalculateDiscount(0.85)
    End Sub
    Private Sub txtCalcDisc90_Click(sender As Object, e As EventArgs) Handles txtCalcDisc90.Click
        CalculateDiscount(0.9)
    End Sub
    Private Sub txtCalcDisc95_Click(sender As Object, e As EventArgs) Handles txtCalcDisc95.Click
        CalculateDiscount(0.95)
    End Sub
    Private Sub txtCalcDisc100_Click(sender As Object, e As EventArgs) Handles txtCalcDisc100.Click
        CalculateDiscount(1)
    End Sub


    Private Sub repoPopupCalculateDiscount_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoPopupCalculateDiscount.ButtonClick
        Me.txtDiscount.EditValue = 0
        Me.txtTotalBeforeDiscount.EditValue = 0
    End Sub

    Private Sub cmdUseCalculatedDiscount_Click(sender As Object, e As EventArgs) Handles cmdUseCalculatedDiscount.Click
        Try
            Dim intFocusedRow As Integer = Me.gvInvoiceChild.FocusedRowHandle

            Dim view As DataRowView = DirectCast(Me.Qry60102QuotationChildBindingSource.Current, DataRowView)
            view.Row("QuotedDiscount") = Math.Round(Me.txtDiscount.EditValue, 2)

            Me.Qry60102QuotationChildBindingSource.EndEdit()
            Me.Qry601_02QuotationChildTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild)
            Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, Me.txtQuotationNo.EditValue)

            Me.gvInvoiceChild.FocusedRowHandle = intFocusedRow
            Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.VisibleColumns(9)
            Me.gvInvoiceChild.ShowEditor()


        Catch ex As Exception

        End Try

    End Sub


#End Region


    Private Sub frm601_01QuotationEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm601_01QuotationEdit.qry700_02ProjectsViewMaster' table. You can move, or remove it, as needed.
        Me.Qry700_02ProjectsViewMasterTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry700_02ProjectsViewMaster)

        Me.Tbl600_08InventoryMasterGroupTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.tbl600_08InventoryMasterGroup)
        Me.Tbl601_07QuotationStatusTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit2.tbl601_07QuotationStatus)
        Me.Tbl600_06QuotationCustomColumnsTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit1.tbl600_06QuotationCustomColumns)
        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.tbl40111PropertyUnitCodes)
        Me.Tbl20163VatTaxSlabsTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.tbl20163VatTaxSlabs)

        Me.Tbl901CompanyDetailsTableAdapter.Fill(Me.Dsfrm20161VATInvoiceEdit.tbl901CompanyDetails)
        Me.Tbl90104DocumentSignatoriesTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl90104DocumentSignatories)
        Me.Tbl30104TypeOfRequestMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl30104TypeOfRequestMaster)
        Me.Tbl30103ModeOfRequestMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl30103ModeOfRequestMaster)
        Me.Tbl20101SalesPersonMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl20101SalesPersonMaster)

        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.tbl20164GoodsAndServicesMaster)
        Else
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.FillByInventoryMasterGroupID(Me.Dsfrm601_01QuotationEdit.tbl20164GoodsAndServicesMaster, Me.intLogOnInventoryAccessLevel)
        End If

        If Me.intLogOnInventoryMPRAccessLevel = 99 Then
            Me.Tbl30101ClientMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl30101ClientMaster)
        Else
            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)
            Me.Tbl30101ClientMasterTableAdapter.FillBySalesPersonCode(Me.Ds40103PropertyQuoteMaster.tbl30101ClientMaster, SalesPersonCode)
        End If

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_01QuotationEdit", Me.gvInvoiceChild)

        Me.ImplementAccess(Me.intLogOnUserID)

        'Populate Custom Reports Tab
        Me.PopulateCustomReportButtons(Me.CustomReportFormNo)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colcalcTaxAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colLineTotalWithTax.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalCostOfItem.DisplayFormat.FormatString = "{0:#,0.000}"

            txtAdditionsAmount.Properties.DisplayFormat.FormatString = "{0:#,0.000}"
            txtDeductionsAmount.Properties.DisplayFormat.FormatString = "{0:#,0.000}"

            txtAdditionsAmount.Properties.EditFormat.FormatString = "{0:#,0.000}"
            txtDeductionsAmount.Properties.EditFormat.FormatString = "{0:#,0.000}"

            txtAdditionsAmount.Properties.EditMask = "###,###,##0.000"
            txtDeductionsAmount.Properties.EditMask = "###,###,##0.000"

        End If
    End Sub

    Public Sub ImplementAccess(ByVal UserID As Integer)
        If GetUserAccess(UserID, "frm601_01QuotationEdit_FullAccess") = True Then

            Me.btnMoveUp.Enabled = True
            Me.btnMoveDown.Enabled = True
            Me.btnResetLayout.Enabled = True
            Me.btnSetDefaultLayout.Enabled = True
            Me.btnSave.Enabled = True
            Me.btnSaveAndClose.Enabled = True
            Me.btnPreviewQuotation.Enabled = True
            Me.btnPreviewQuotationWoVAT.Enabled = True
            Me.btnPreviewQuotationWtTotPrice.Enabled = True
            Me.btnPreviewQuoteFormat4.Enabled = True
            Me.btnPreviewQuotationWtDetails.Enabled = True
            Me.btnPreviewTechnicalQuote.Enabled = True
            Me.btnPrintCostSheet.Enabled = True
            Me.btnDelete.Enabled = True
            Me.btnAddNewLineItem.Enabled = True
            Me.btnLineItem.Enabled = True
            Me.btnTerms.Enabled = True
            Me.btnBack.Enabled = True
            Me.btnAttachments.Enabled = True
            Me.btnSubmit.Enabled = True
            Me.btnVerify.Enabled = True
            Me.btnApprove.Enabled = True

            Me.txtClientName.Properties.Buttons.Item(2).Enabled = True
            Me.txtClientName.Properties.Buttons.Item(1).Enabled = True

            Me.cmdEditContacts.Enabled = True

            Me.txtSalesPerson.Properties.Buttons.Item(1).Enabled = True
            Me.txtModeOfRequest.Properties.Buttons.Item(1).Enabled = True
            Me.txtTypeOfRequest.Properties.Buttons.Item(1).Enabled = True

            Me.btnDefaultSubject.Enabled = True
            Me.btnDefaultIntro.Enabled = True
            Me.btnDefaultSummary.Enabled = True
            Me.btnDefaultThanks.Enabled = True

            Me.txtSignatory.Properties.Buttons.Item(1).Enabled = True
            Me.txtRequestStatus.Properties.Buttons.Item(1).Enabled = True

            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = True

            Me.gcCostDetails.OptionsColumn.AllowEdit = True

        Else
            Me.btnMoveUp.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnMoveUp")
            Me.btnMoveDown.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnMoveDown")
            Me.btnResetLayout.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnResetLayout")
            Me.btnSetDefaultLayout.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnSetDefaultLayout")
            Me.btnSave.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnSave")
            Me.btnSaveAndClose.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnSaveAndClose")
            Me.btnPreviewQuotation.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnPreviewQuotation")
            Me.btnPreviewQuotationWoVAT.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnPreviewQuotationWoVAT")
            Me.btnPreviewQuotationWtTotPrice.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnPreviewQuotationWtTotPrice")
            Me.btnPreviewQuoteFormat4.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnPreviewQuoteFormat4")
            Me.btnPreviewQuotationWtDetails.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnPreviewQuotationWtDetails")
            Me.btnPreviewTechnicalQuote.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnPreviewTechnicalQuote")
            Me.btnPrintCostSheet.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnPrintCostSheet")
            Me.btnDelete.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnDelete")
            Me.btnAddNewLineItem.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnAddNewLineItem")
            Me.btnLineItem.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnLineItem")
            Me.btnTerms.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnTerms")
            Me.btnBack.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnBack")
            Me.btnAttachments.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnAttachments")
            Me.btnSubmit.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnSubmit")
            Me.btnVerify.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnVerify")
            Me.btnApprove.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnApprove")

            Me.txtClientName.Properties.Buttons.Item(2).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_txtClientName")
            Me.txtClientName.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_txtClientName")

            Me.cmdEditContacts.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_cmdEditContacts")

            Me.txtSalesPerson.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_txtSalesPerson")
            Me.txtModeOfRequest.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_txtModeOfRequest")
            Me.txtTypeOfRequest.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_txtTypeOfRequest")

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
                    Me.btnDefaultSubject.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnDefaultSubject")
                    Me.btnDefaultIntro.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnDefaultIntro")
                    Me.btnDefaultSummary.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnDefaultSummary")
                    Me.btnDefaultThanks.Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_btnDefaultThanks")
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then

                    Me.txtSignatory.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_txtSignatory")
                    Me.txtRequestStatus.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_txtRequestStatus")
                    Exit For
                End If
            Next

            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_AddStockItem")
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_EditStockItem")
            Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = GetUserAccess(UserID, "frm601_01QuotationEdit_EditStockItem")

            Me.gcCostDetails.OptionsColumn.AllowEdit = GetUserAccess(UserID, "frm601_01QuotationEdit_CalculateCost")

            Me.colCostPrice.Visible = GetUserAccess(Me.intLogOnUserID, "frm601_01QuotationEdit_CostPrice_Visible")
            Me.colCostPrice.OptionsColumn.AllowShowHide = GetUserAccess(Me.intLogOnUserID, "frm601_01QuotationEdit_CostPrice_Visible")

            Me.colCostPrice1.Visible = GetUserAccess(Me.intLogOnUserID, "frm601_01QuotationEdit_CostPrice_Visible")
            Me.colCostPrice1.OptionsColumn.AllowShowHide = GetUserAccess(Me.intLogOnUserID, "frm601_01QuotationEdit_CostPrice_Visible")

            Me.colTotalCostOfItem.Visible = GetUserAccess(Me.intLogOnUserID, "frm601_01QuotationEdit_CostPrice_Visible")
            Me.colTotalCostOfItem.OptionsColumn.AllowShowHide = GetUserAccess(Me.intLogOnUserID, "frm601_01QuotationEdit_CostPrice_Visible")

            Me.colItemProfitOrLoss.Visible = GetUserAccess(Me.intLogOnUserID, "frm601_01QuotationEdit_CostPrice_Visible")
            Me.colItemProfitOrLoss.OptionsColumn.AllowShowHide = GetUserAccess(Me.intLogOnUserID, "frm601_01QuotationEdit_CostPrice_Visible")


        End If
    End Sub

    Public Sub UpdateDefaultFields()
        Try
            'Select the Details Page
            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)

                    Me.txtAdditionsAmount.EditValue = 0
                    Me.txtDeductionsAmount.EditValue = 0
                    Me.txtAdditions.EditValue = "Add: Additions (SAR)"
                    Me.txtDeductions.EditValue = "Less: Deductions (SAR)"

                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    If Me.intLogOnDivision = 99 Then
                        Me.txtCompanyID.EditValue = 1
                    Else
                        Me.txtCompanyID.EditValue = Me.intLogOnDivision
                    End If

                    If Me.intLogOnInventoryAccessLevel = 99 Then
                        Me.txtInventoryGroupMaster.EditValue = 1
                        Me.txtInventoryGroupMaster.Enabled = True

                    Else
                        Me.txtInventoryGroupMaster.EditValue = Me.intLogOnInventoryAccessLevel
                        Me.txtInventoryGroupMaster.Enabled = False
                    End If

                    Me.txtQuoteSubmittedOn.EditValue = Date.Today()
                    Me.txtQuoteSubmittedBy.EditValue = Me.strLogonUser

                    Exit For
                End If

            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    GetReportDetails("IMS-QTN-01")
                    Me.txtSubject.EditValue = gReportSubject
                    Me.txtQuoteIntro.Text = gReportIntroduction
                    Me.txtQuoteSummary.Text = gReportSummary
                    Me.txtQuoteThanksNote.Text = gReportThanksNote
                    Exit For
                End If

            Next


            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageQuoteDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)

                    'Get SalesPerson Code and fill it.
                    'If the User Account can create Other SalesPerson Quotes then enable SalesPerson Field.. else disable it.
                    Dim SalesPersonCode As String = ""
                    SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

                    If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                        If SalesPersonCode = 0 OrElse SalesPersonCode = "" Then
                            Me.txtSalesPerson.Enabled = True
                        Else
                            Me.txtSalesPerson.EditValue = GetSalesPersonCode(Me.intLogOnUserID)
                            Me.txtSalesPerson.Enabled = True
                        End If
                    Else
                        Me.txtSalesPerson.EditValue = GetSalesPersonCode(Me.intLogOnUserID)
                        Me.txtSalesPerson.Enabled = False
                    End If

                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtQuotationNo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtQuotationNo, "Quotation Number Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtQuotationNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtQuoteDate.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtQuoteDate, "Quotation Date must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtQuoteDate, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtClientName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtClientName, "Client must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtClientName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtQuoteSubmittedOn.EditValue)) = False Then
            Dim QuoteDate As Date = Me.txtQuoteDate.EditValue
            If QuoteDate.Date > Me.txtQuoteSubmittedOn.EditValue Then
                Me.DxErrorProvider1.SetError(Me.txtQuoteSubmittedOn, "Quote Submitted Date cannot be less than the Quotation Date.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        Else
            Me.DxErrorProvider1.SetError(Me.txtQuoteSubmittedOn, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

    End Sub
    Public Sub RetrieveQuotationMaster(ByVal QuotationNo As String)
        Try
            If CheckIfNull(QuotationNo) = False Then
                'fill master details
                Me.Tbl601_01QuotationMasterTableAdapter.FillByQuoteNo(Me.Dsfrm601_01QuotationEdit.tbl601_01QuotationMaster, QuotationNo)

                'fill child details in the datagrid
                Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, QuotationNo)

                'fill Quotation Child - Sub Group Items
                Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByQuotationNo(Me.Dsfrm601_01QuotationEdit.tbl601_07QuotationChildItemGroup, QuotationNo)
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Quotation Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateQuotationMaster(ByVal QuotationNo As String, ByVal WithMessage As Boolean)
        If CheckIfNull(QuotationNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60101QuotationMasterBindingSource.Current, DataRowView)
            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            Me.Tbl60101QuotationMasterBindingSource.EndEdit()
            Me.Tbl601_01QuotationMasterTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.tbl601_01QuotationMaster)

            If WithMessage = True Then
                MessageBox.Show("Quotation Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SaveNewQuotationMaster(ByVal QuotationNo As String)
        If CheckIfNull(QuotationNo) = False Then
            If isBeingNew = True Then
                Dim view As DataRowView = DirectCast(Me.Tbl60101QuotationMasterBindingSource.Current, DataRowView)
                view.Row("AddedBy") = Me.strLogonUser
                view.Row("AddedOn") = Date.Now
                Me.Validate()

                Me.Tbl60101QuotationMasterBindingSource.EndEdit()
                Me.Tbl601_01QuotationMasterTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.tbl601_01QuotationMaster)
            End If
        End If
    End Sub

    Private Sub btnSaveAndClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
        cmdSave_Click(sender, e)
        Me.Close()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick
        SaveAll(True)
    End Sub

    Private Sub SaveAll(ByVal WithMessage As Boolean)
        CheckMasterErrors()
        If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
            MessageBox.Show("Cannot continue saving with errors, please clear the errors and continue.", "Clear Errors", MessageBoxButtons.OK)
            Exit Sub

        End If

        If Me.btnSave.Caption = "Update" Then
            UpdateQuotationMaster(Me.txtQuotationNo.EditValue, WithMessage)
            Me.btnSave.Caption = "Update"

        ElseIf Me.btnSave.Caption = "Save" Then
            If Me.isBeingNew = True Then
                SaveNewQuotationMaster(Me.txtQuotationNo.EditValue)
                Me.btnSave.Caption = "Update"
            End If
        End If

        Try
            'Update the Data in the Child
            Me.Qry60102QuotationChildBindingSource.EndEdit()
            Me.Qry601_02QuotationChildTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild)
            Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, Me.txtQuotationNo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshQuotationMasterDataGrid()
    End Sub

    Private Sub RefreshQuotationMasterDataGrid()
        If isExecutedFrom_frm601_02_QuotationView = True Then
            Try
                CType(ObjForm, frm601_02_QuotationView).RetrieveVoucher(CType(ObjForm, frm601_02_QuotationView).txtStartDate.EditValue, CType(ObjForm, frm601_02_QuotationView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_02_QuotationView).gvAdvBandedQuotationView, "QuoteNo", Me.txtQuotationNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Quotation Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        '
        If isExecutedFrom_frm601_12PurchaseRequestView = True Then
            Try
                CType(ObjForm, frm601_12PurchaseRequestView).RetrieveVoucher(CType(ObjForm, frm601_12PurchaseRequestView).txtStartDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).txtEndDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).SelectedRequestedType)
                CType(ObjForm, frm601_12PurchaseRequestView).UpdateFrames()
                GoBackToRow(CType(ObjForm, frm601_12PurchaseRequestView).gvAdvBandedQuotationView2, "MPRNo", Me.txtMPRNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Material Request Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        '
        If isExecutedFrom_frm601_15QuotationAnalysis = True Then
            'Try
            '    CType(ObjForm, frm601_12PurchaseRequestView).RetrieveVoucher(CType(ObjForm, frm601_12PurchaseRequestView).txtStartDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).txtEndDate.EditValue)
            '    CType(ObjForm, frm601_12PurchaseRequestView).UpdateFrames()
            '    GoBackToRow(CType(ObjForm, frm601_12PurchaseRequestView).gvAdvBandedQuotationView, "MPRNo", Me.txtMPRNo.EditValue)
            'Catch ex As Exception
            '    MessageBox.Show("Error Occured while Refreshing the Material Request Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
        End If
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.ItemClick
        If isControlsModified = True Then
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("Quotation Details have been edited, would you like to save changes?", "Save Changes?", MessageBoxButtons.YesNoCancel)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then

                cmdSave_Click(sender, e)
                Me.Close()

            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Me.Close()
            ElseIf DialogResult = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

        ElseIf isBeingUpdated = False Then
            Me.Close()
        End If
    End Sub

    Public Function GetNewQuotationNo(ByVal QuotationAbbr As String, ByVal YearInDigit As Integer, ByVal QuoteDate As Date, ByVal IsResetByYear As Boolean, ByVal NoOfDigits As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1

            If IsResetByYear = True Then
                SqlCommand1.CommandText = "select max(cast(right(QuoteNo, " & NoOfDigits & ") as int)) from tbl601_01QuotationMaster where QuoteNo like '" & QuotationAbbr & "%' AND Isnull(RevisionNo,0) = 0 and Year(QuoteDate) = '" & Year(QuoteDate).ToString & "'"
            Else
                SqlCommand1.CommandText = "select max(cast(right(QuoteNo, " & NoOfDigits & ") as int)) from tbl601_01QuotationMaster WHERE QuoteNo like '" & QuotationAbbr & "%' AND Isnull(RevisionNo,0) = 0"
            End If

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
            strNewQuotationNo = QuotationAbbr & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(QuoteDate).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = "0000001"
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)

            strNewQuotationNo = QuotationAbbr & strYear & "-" & strNewQuotationNo
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    'Saving and updating codes
    Public Sub NewInvoiceMaster(ByVal QuotationNo As String)
        Try
            If CheckIfNull(QuotationNo) = False Then
                Me.Tbl60101QuotationMasterBindingSource.AddNew()
                Me.txtQuotationNo.EditValue = QuotationNo
                isBeingUpdated = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Quotation", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddNewLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewLineItem.ItemClick

        Try
            If CheckIfNull(Me.txtQuotationNo.EditValue) = False Then
                If Me.btnSave.Caption = "Save" Then
                    SaveNewQuotationMaster(Me.txtQuotationNo.EditValue)
                    Me.btnSave.Caption = "Update"
                End If

                Me.AddNewChild()
                Me.Validate()
                Me.Qry60102QuotationChildBindingSource.EndEdit()
                Me.Qry601_02QuotationChildTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild)

                Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, Me.txtQuotationNo.EditValue)

                Me.gvInvoiceChild.MoveLast()
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.Columns("GSCode")
                Me.gvInvoiceChild.ShowEditor()

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Quotation Line Item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm601_01QuotationEdit.Tables("qry601_02QuotationChild")
            dr = dt.NewRow()
            dr("QuoteChildID") = 1
            dr("QuoteNo") = Me.txtQuotationNo.EditValue
            dr("QuotedQuantity") = 1
            dr("LineOrderNo") = GetNewQuotationLineItemNo(Me.txtQuotationNo.EditValue)

            dt.Rows.Add(dr)
            Me.Qry601_02QuotationChildTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Quotation Line Item, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewQuotationLineItemNo(ByVal strQuotationNo As String) As Integer
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Max(LineOrderNo) from tbl601_02QuotationChild where QuoteNo = '" & strQuotationNo & "'"
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

    Private Sub cmdStockItemDesc_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs)

    End Sub

    Private Sub DeleteQuotationChild(ByVal QuotationChildSlNo As Integer)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp601_01DeleteQuotationChild"
            Dim paramPayrollInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@QuotationChildSlNo", SqlDbType.Int)

            paramPayrollInvoiceNo.Value = QuotationChildSlNo

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("Quotation Line Item Deleted Successfully,", "Data Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Quotation Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLineItem.ItemClick

        DialogResult = MessageBox.Show("You are about to delete Quotation Line Item." & vbCrLf & "Are you Sure want to delete this Quotation Details?", "Delete Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedQuotationChildSlNo) = False Then

                Me.DeleteQuotationChild(Me.SelectedQuotationChildSlNo)

                'Refresh the datagrid
                'fill child details in the datagrid
                Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, Me.txtQuotationNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub gvInvoiceChild_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvInvoiceChild.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedQuotationChildSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("QuoteChildID"))
                Me.popInvoiceChild.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAddLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddLineItem.ItemClick
        If CheckIfNull(Me.txtQuotationNo.EditValue) = False Then
            Me.AddNewChild()
            Me.Validate()
            Me.Qry60102QuotationChildBindingSource.EndEdit()
            Me.Qry601_02QuotationChildTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild)

            Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, Me.txtQuotationNo.EditValue)
        End If
    End Sub

    Public Sub UpdateInvoiceChild()
        Try

            Me.Validate()
            Me.Qry60102QuotationChildBindingSource.EndEdit()
            Me.Qry601_02QuotationChildTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild)

            'RefreshInvoiceChild()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub RefreshInvoiceChild()
        Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, Me.txtQuotationNo.EditValue)

        'GetWorkHours()

    End Sub

    Private Sub gvWorkSheet_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvInvoiceChild.RowUpdated
        'UpdateqvoiceChild()

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            If frm601_02_QuotationView.CheckIfSalesOrderIsAvailableForQuotation(Me.txtQuotationNo.EditValue) = True Then
                MessageBox.Show("You cannot Delete this Quotation, Sales Order has been Generated for this Quotation, Please Remove the Sales Order to Unlock this Quotation and try again.", "Sales Order Generated.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If

            'Check if the Voucher is approved already
            If CheckIfQuotationIsApproved(Me.txtQuotationNo.EditValue) = True Then
                MessageBox.Show("Quotation is already approved, You cannot delete the Approved Quotation", "Quotation Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Quotation from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtQuotationNo.EditValue) = False Then
                    If DeleteQuotation(Me.txtQuotationNo.EditValue) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.txtQuotationNo.EditValue, "VoucherScanned\IMSQuote")

                        MessageBox.Show("Quotation has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Quotation", "IMS Quotation No." & Me.txtQuotationNo.EditValue & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogonUser & ".", Me.strLogonUser, Me.txtQuotationNo.EditValue)

                        'Refresh the datagrid
                        RefreshQuotationMasterDataGrid()

                        Me.Close()
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

    Public Function CheckIfQuotationIsApproved(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select QuoteNo from tbl601_01QuotationMaster where (QuoteNo = '" & QuotationNo & "') and (Isnull(IsApproved,0) = 1 )"

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
            'tbl601_03QuotationTerms

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


    Public Sub DisableApprovedVoucherEditing(ByVal QuotationNo As String)
        'Disable access if the voucher is already approved.
        'Get the IsVoucherIsApproved

        If CheckIfQuotationIsApproved(QuotationNo) = True Then
            DisableAllControls()
        End If

    End Sub

    Public Sub DisableControlsForInventoryGroupMaster(ByVal InventoryGroupMaster As Integer)
        If InventoryGroupMaster = 99 Then
            Me.txtInventoryGroupMaster.Enabled = True
        Else
            Me.txtInventoryGroupMaster.Enabled = False
        End If

    End Sub

    Private Sub txtClientName_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtClientName.ButtonClick
        If e.Button.Index = 2 Then

            Dim frm30106ClientMaster As New frm30106ClientMaster
            frm30106ClientMaster.ObjForm = Me

            frm30106ClientMaster.btnSave.Caption = "Save"
            frm30106ClientMaster.strLogonUser = Me.strLogonUser
            frm30106ClientMaster.intLogOnUserID = Me.intLogOnUserID
            frm30106ClientMaster.intLogOnUserLevel = Me.intLogOnUserLevel
            frm30106ClientMaster.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm30106ClientMaster.Show()
            frm30106ClientMaster.FillDataSetforNew()

            Dim NewClientCode As String = frm30106ClientMaster.GetNewClientNo()
            frm30106ClientMaster.txtClientCode.EditValue = NewClientCode
            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm30106ClientMaster.txtSalesPerson.Enabled = True
            Else
                frm30106ClientMaster.txtSalesPerson.EditValue = GetSalesPersonCode(Me.intLogOnUserID)
                frm30106ClientMaster.txtSalesPerson.Enabled = False
            End If

            frm30106ClientMaster.txtClientName.Focus()
            frm30106ClientMaster.isExecutedFrom_frm601_01QuotationEdit = True

        ElseIf e.Button.Index = 1 Then

            If CheckIfNull(Me.txtClientName.EditValue) = True Or Me.txtClientName.Text = String.Empty Then
                MessageBox.Show("Please select the Client to edit.", "Select Client to edit", MessageBoxButtons.OK)
            Else
                Dim frm30106ClientMaster As New frm30106ClientMaster
                frm30106ClientMaster.ObjForm = Me

                frm30106ClientMaster.isExecutedFrom_frm601_01QuotationEdit = True

                frm30106ClientMaster.strLogonUser = Me.strLogonUser
                frm30106ClientMaster.intLogOnUserID = Me.intLogOnUserID
                frm30106ClientMaster.intLogOnUserLevel = Me.intLogOnUserLevel
                frm30106ClientMaster.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm30106ClientMaster.txtClientCode.EditValue = Me.txtClientName.EditValue

                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    frm30106ClientMaster.txtSalesPerson.Enabled = True
                Else
                    frm30106ClientMaster.txtSalesPerson.Enabled = False
                End If

                frm30106ClientMaster.Show()
                frm30106ClientMaster.FillDataSetforEditing(Me.txtClientName.EditValue)

                frm30106ClientMaster.btnSave.Caption = "Update"
                frm30106ClientMaster.txtClientName.Focus()

            End If
        End If
    End Sub

    Private Sub txtClientName_EditValueChanged(sender As Object, e As EventArgs) Handles txtClientName.EditValueChanged
        Try
            If CheckIfNull(Me.txtClientName.EditValue) = False Then
                'Me.Tbl30101ClientMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster3.tbl30101ClientMaster)

                Me.txtClientRefName.EditValue = Me.Ds40103PropertyQuoteMaster.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactPerson")
                Me.txtClientContactNo.EditValue = Me.Ds40103PropertyQuoteMaster.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactPhone1")
                Me.txtClientEmail.EditValue = Me.Ds40103PropertyQuoteMaster.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactEmail")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSignatory_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSignatory.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40115QuotationSignatories As New frm40115QuotationSignatories
            frm40115QuotationSignatories.ObjForm = Me
            frm40115QuotationSignatories.Show()
            frm40115QuotationSignatories.txtSignatoryName.Focus()
            frm40115QuotationSignatories.isExecutedFrom_frm601_01QuotationEdit = True
        End If
    End Sub

    Private Sub txtModeOfRequest_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtModeOfRequest.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40112QuoteModeOfRequest As New frm40112QuoteModeOfRequest
            frm40112QuoteModeOfRequest.ObjForm = Me
            frm40112QuoteModeOfRequest.Show()
            frm40112QuoteModeOfRequest.txtPropertyCategory.Focus()
            frm40112QuoteModeOfRequest.isExecutedFrom_frm601_01QuotationEdit = True
        End If
    End Sub

    Private Sub txtTypeOfRequest_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtTypeOfRequest.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40113QuoteTypeOfRequest As New frm40113QuoteTypeOfRequest
            frm40113QuoteTypeOfRequest.ObjForm = Me
            frm40113QuoteTypeOfRequest.Show()
            frm40113QuoteTypeOfRequest.txtPropertyCategory.Focus()
            frm40113QuoteTypeOfRequest.isExecutedFrom_frm601_01QuotationEdit = True
        End If
    End Sub

    Private Sub repoDetailedDescription_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoDetailedDescription.ButtonClick
        If e.Button.Index = 1 Then
            Try
                Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                frm20163VATGoodsAndServicesEdit.ObjForm = Me

                frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Save"
                frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_01QuotationEdit = True

                'Dim row As System.Data.DataRow = gvInvoiceChild.GetDataRow(gvInvoiceChild.FocusedRowHandle)
                'Dim QuotationChildSlNo As Integer = row("QuoteChildID")
                'frm20163VATGoodsAndServicesEdit.frm601_01QuotationEdit_QuoteChildID = QuotationChildSlNo
                frm20163VATGoodsAndServicesEdit.strLogonUser = Me.strLogonUser
                frm20163VATGoodsAndServicesEdit.intLogOnUserID = Me.intLogOnUserID
                frm20163VATGoodsAndServicesEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                frm20163VATGoodsAndServicesEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm20163VATGoodsAndServicesEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel

                frm20163VATGoodsAndServicesEdit.Show()
                frm20163VATGoodsAndServicesEdit.FillDataSetforNew()

                frm20163VATGoodsAndServicesEdit.txtUnitIssue.EditValue = 1
                frm20163VATGoodsAndServicesEdit.txtSellingRate.EditValue = 1

                frm20163VATGoodsAndServicesEdit.txtGSDescription.Focus()

            Catch ex As Exception
                MessageBox.Show("Error on Adding Goods & Services Item, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf e.Button.Index = 2 Then
            Try
                Dim strItemCode As String = Me.gvInvoiceChild.GetRowCellValue(Me.gvInvoiceChild.FocusedRowHandle, "GSCode")

                If CheckIfNull(strItemCode) = False Then

                    Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                    frm20163VATGoodsAndServicesEdit.ObjForm = Me
                    frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_01QuotationEdit = True

                    frm20163VATGoodsAndServicesEdit.strLogonUser = Me.strLogonUser
                    frm20163VATGoodsAndServicesEdit.intLogOnUserID = Me.intLogOnUserID
                    frm20163VATGoodsAndServicesEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                    frm20163VATGoodsAndServicesEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                    frm20163VATGoodsAndServicesEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                    frm20163VATGoodsAndServicesEdit.txtGSCode.EditValue = strItemCode
                    frm20163VATGoodsAndServicesEdit.Show()
                    frm20163VATGoodsAndServicesEdit.FillDataSetforEditing(strItemCode)

                    frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Update"
                    frm20163VATGoodsAndServicesEdit.txtGSDescription.Focus()

                End If

            Catch ex As Exception

            End Try

        ElseIf e.Button.Index = 3 Then
            Try
                Dim strItemCode As String = Me.gvInvoiceChild.GetRowCellValue(Me.gvInvoiceChild.FocusedRowHandle, "GSCode")

                If CheckIfNull(strItemCode) = False Then

                    Dim frm600_01InventoryStockEdit As New frm600_01InventoryStockEdit
                    frm600_01InventoryStockEdit.objForm = Me
                    frm600_01InventoryStockEdit.isExecutedFrom_frm601_01QuotationEdit = True

                    frm600_01InventoryStockEdit.strLogOnUser = Me.strLogonUser
                    frm600_01InventoryStockEdit.intLogOnUserID = Me.intLogOnUserID
                    frm600_01InventoryStockEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                    frm600_01InventoryStockEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                    frm600_01InventoryStockEdit.intLogOnDivision = Me.intLogOnDivision
                    frm600_01InventoryStockEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                    frm600_01InventoryStockEdit.txtStockCode.EditValue = strItemCode
                    frm600_01InventoryStockEdit.Show()
                    frm600_01InventoryStockEdit.FillDataSetforEditing(strItemCode)

                    frm600_01InventoryStockEdit.btnSave.Caption = "Update"
                    frm600_01InventoryStockEdit.txtStockCode.Enabled = False
                    frm600_01InventoryStockEdit.txtItemName.Focus()


                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub repoUnitRateMethod_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoUnitRateMethod.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40114QuoteMethods As New frm40114QuoteMethods
            frm40114QuoteMethods.ObjForm = Me
            frm40114QuoteMethods.Show()
            frm40114QuoteMethods.txtQuoteMethod.Focus()
            frm40114QuoteMethods.isExecutedFrom_frm601_01QuotationEdit = True
        End If
    End Sub

    Private Sub gvInvoiceChild_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvInvoiceChild.CellValueChanged
        Try
            'Dim DescriptionCaptionWtArabic As String = "Description " & Global.Microsoft.VisualBasic.ChrW(10) & "// وصف السلعة"

            If e.Column.Caption = "Description" Then
                Dim SelectedValue As String = e.Value
                GetGSDetails(SelectedValue)
                gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitRateMethod"), gGSStockUnitMethod)
                gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("QuotedUnitPrice"), gGSSellingRate)

                GetCompanyDetails(1)
                If gCurrencyType = "BHD" Then

                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("QuotedTaxSlab"), 10)

                ElseIf gCurrencyType = "AED" Then

                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("QuotedTaxSlab"), 1)

                Else

                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("QuotedTaxSlab"), 8)
                End If


                GetCompanyDetails02(1)
                If gIsShowFixedCostPrice = True Then

                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("CostPrice"), gCostPrice)

                Else
                    Dim StockCostAvgPrice As Decimal = Me.GetStockIssueCost(SelectedValue)

                    If StockCostAvgPrice = 0 Then
                        StockCostAvgPrice = gCostPrice
                    End If

                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("CostPrice"), StockCostAvgPrice)
                End If

                Dim intFocusedRow As Integer = Me.gvInvoiceChild.FocusedRowHandle
                'Update the Data in the Child
                Me.Qry60102QuotationChildBindingSource.EndEdit()
                Me.Qry601_02QuotationChildTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild)
                Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, Me.txtQuotationNo.EditValue)

                Me.gvInvoiceChild.FocusedRowHandle = intFocusedRow
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.VisibleColumns(9)
                Me.gvInvoiceChild.ShowEditor()

            End If


            If e.Column.Caption = "Unit Price" Then
                GetCompanyDetails02(1)
                If gIsShowFixedCostPrice = True Then

                    Dim SelectedStockCode As String = gvInvoiceChild.GetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("GSCode"))
                    GetGSDetails(SelectedStockCode)
                    Dim SelectedValue As Decimal = e.Value
                    Dim GetCostPrice As Decimal = gCostPrice

                    If SelectedValue = 0 Then

                    ElseIf SelectedValue < GetCostPrice Then
                        MessageBox.Show("Quote Price is lower than the Cost Price", "Quote Price is Less", MessageBoxButtons.OK)
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("QuotedUnitPrice"), 0)
                    End If

                End If

                If gIsStrictSellingPriceRange = True Then

                    Dim SelectedStockCode As String = gvInvoiceChild.GetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("GSCode"))
                    GetGSDetails(SelectedStockCode)
                    Dim SelectedValue As Decimal = e.Value
                    Dim GetMinSellingPrice As Decimal = gMinSellingPrice
                    Dim GetMaxSellingPrice As Decimal = gMaxSellingPrice

                    If SelectedValue = 0 Then

                    ElseIf SelectedValue < GetMinSellingPrice Then
                        MessageBox.Show("Quote Price is lower than the Minimum Selling Price", "Quote Price is Less", MessageBoxButtons.OK)
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("QuotedUnitPrice"), 0)

                    ElseIf SelectedValue > GetMaxSellingPrice Then
                        MessageBox.Show("Quote Price is higher than the Maximum Selling Price", "Quote Price is High", MessageBoxButtons.OK)
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("QuotedUnitPrice"), 0)

                    End If

                End If

            End If


            If e.Column.Name = "colUnitRateMethod" Then
                GetCompanyDetails02(1)
                If gIsStrictUnitsForStockItems = True Then
                    Dim EnteredUOM As Decimal = e.Value
                    Dim SelectedGSCode As String = gvInvoiceChild.GetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("GSCode"))
                    If CheckIfGSCodeIsServiceGroup(SelectedGSCode) = True Then
                        Exit Sub
                    End If

                    If CheckStockUOM(SelectedGSCode, EnteredUOM) = True Then
                        'Get the Unit Converted and Get the Cost Price and multiply it by Unit Converted
                        Dim UnitsToConvert As Decimal = GetStockItemBaseUnitsToConvert(SelectedGSCode, EnteredUOM)
                        Dim CostPrice As Decimal = Me.GetStockIssueCost(SelectedGSCode)
                        Dim UnitCostPrice As Decimal = 0D
                        UnitCostPrice = UnitsToConvert * CostPrice
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("CostPrice"), UnitCostPrice)

                        'Get the Unit Converted and get the Selling Price and Mulitply it by unit converted
                        GetGSDetails(SelectedGSCode)
                        Dim UnitSellingPrice As Decimal = 0D
                        UnitSellingPrice = UnitsToConvert * gGSSellingRate
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("QuotedUnitPrice"), UnitSellingPrice)

                    Else
                        MessageBox.Show("Selected Unit is not in the Base Unit of this Stock Item," & vbCrLf & "Please check the Unit and try again.", "UoM not matching", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitRateMethod"), GetStockItemBaseUnit(SelectedGSCode))
                        Me.gvInvoiceChild.FocusedColumn = gvInvoiceChild.Columns("UnitRateMethod")

                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTerms_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTerms.ItemClick
        'If CheckIfNull(Me.txtQuotationNo.EditValue) = False Then
        '    Dim frm40107QuoteSelected As New frm40107QuoteSelected
        '    frm40107QuoteSelected.selectedTermsFor = "Quotation"
        '    frm40107QuoteSelected.Show()
        '    frm40107QuoteSelected.SelectedQuoteNo = Me.txtQuotationNo.EditValue
        '    frm40107QuoteSelected.FilterSelectedQuoteNo(Me.txtQuotationNo.EditValue)
        '    frm40107QuoteSelected.selectedQuoteType = Me.txtTypeOfRequest.Text
        '    frm40107QuoteSelected.txtTermsCategory.Text = Me.txtTypeOfRequest.Text

        'End If

        If CheckIfNull(Me.txtQuotationNo.EditValue) = False Then
            Dim frm600_06DocumentConditions As New frm600_06DocumentConditions
            frm600_06DocumentConditions.txtConditionsCode.EditValue = "TERMS-0001"
            frm600_06DocumentConditions.txtDocumentNo.EditValue = Me.txtQuotationNo.EditValue
            frm600_06DocumentConditions.FillDocumentConditions(Me.txtQuotationNo.EditValue)
            frm600_06DocumentConditions.Show()


        End If

    End Sub


    Private Sub btnPreviewQuotation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewQuotation.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If

            Next

            GetCompanyDetails(Me.txtCompanyID.EditValue)

            If CheckIfNull(gCompanyERPCode) = False Then
                If gCompanyERPCode = "ERP-901" Then  'ERA International ERP Code
                    PrintQuotationFormat_ERAInternational()

                ElseIf gCompanyERPCode = "ERP-902" Then  'Shine Solution ERP Code

                    PrintQuotationFormat_ShineSolution()

                Else
                    PrintQuotationFormat01()

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintQuotationFormat_ShineSolution()
        Dim rpt1 As New rpt601_99_04aQuotationFormatShineSol
        rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

        'Dim rpt2 As New rpt40102QuotationTerms
        'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtQuotationNo.EditValue)

        Dim rpt2 As New rpt601_08QuotationTerms
        rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)

        rpt1.XrSubreport1.ReportSource = rpt2

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
        rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

        If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
            If Me.txtShowCompanySeal.EditValue = True Then
                rpt1.txtCompanySeal.Visible = True
            Else
                rpt1.txtCompanySeal.Visible = False
            End If
        End If

        If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
            If Me.txtShowSignature.EditValue = True Then
                rpt1.txtSignatureImage.Visible = True
            Else
                rpt1.txtSignatureImage.Visible = False
            End If
        End If

        If Me.txtPrintInLetterHead.EditValue = True Then

            rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
            rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
            rpt1.Watermark.ImageTiling = False
            rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
            rpt1.Watermark.ImageTransparency = 0
            rpt1.Watermark.ShowBehind = True
            'rpt1.Watermark.PageRange = "2,4"

        End If

        If Me.txtPrintAcknowledgement.EditValue = True Then
            rpt1.panelAcceptance.Visible = True
            rpt1.panelAcceptance.LocationF = New Point(10, 177)
            rpt1.ReportFooter.HeightF = 316

        Else
            rpt1.panelAcceptance.Visible = False
            rpt1.panelAcceptance.LocationF = New Point(10, 0)
            rpt1.ReportFooter.HeightF = 166
        End If

        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser
        rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
        rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
        rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

        rpt1.intCompanyID = Me.txtCompanyID.EditValue

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text
        rpt1.RequestParameters = False
        rpt1.ShowPreview()
    End Sub

    Private Sub PrintQuotationFormat_ERAInternational()
        Dim rpt1 As New rpt601_99_01QuotationFormat_ERA
        rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

        Dim rpt2 As New rpt601_08QuotationTerms
        rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)

        rpt1.XrSubreport1.ReportSource = rpt2

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
        'rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

        'If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
        '    If Me.txtShowCompanySeal.EditValue = True Then
        '        rpt1.txtCompanySeal.Visible = True
        '    Else
        '        rpt1.txtCompanySeal.Visible = False
        '    End If
        'End If

        'If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
        '    If Me.txtShowSignature.EditValue = True Then
        '        rpt1.txtSignatureImage.Visible = True
        '    Else
        '        rpt1.txtSignatureImage.Visible = False
        '    End If
        'End If

        'If Me.txtAdditionsAmount.EditValue = 0 Then
        '    rpt1.rowAdditions.Visible = False
        'End If

        'If Me.txtDeductionsAmount.EditValue = 0 Then
        '    rpt1.rowDeductions.Visible = False
        'End If

        If Me.txtPrintInLetterHead.EditValue = True Then

            rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
            rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
            rpt1.Watermark.ImageTiling = False
            rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
            rpt1.Watermark.ImageTransparency = 0
            rpt1.Watermark.ShowBehind = True
            'rpt1.Watermark.PageRange = "2,4"

        End If

        'If Me.txtPrintAcknowledgement.EditValue = True Then
        '    rpt1.panelAcceptance.Visible = True
        '    rpt1.panelAcceptance.LocationF = New Point(10, 177)
        '    rpt1.ReportFooter.HeightF = 316

        'Else
        '    rpt1.panelAcceptance.Visible = False
        '    rpt1.panelAcceptance.LocationF = New Point(10, 0)
        '    rpt1.ReportFooter.HeightF = 166
        'End If


        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser
        rpt1.intCompanyID = Me.txtCompanyID.EditValue

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text
        rpt1.RequestParameters = False
        rpt1.ShowPreview()


    End Sub





    Public Function CheckIfQuotationHasDiscount(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select QuoteNo, Isnull(Discount,0) as Discount from qry601_03QuotationItemsWithTotal where (Isnull(Discount, 0) > 0) and (QuoteNo = '" & QuotationNo & "')"

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



    Private Sub cmdEditContacts_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles cmdEditContacts.OpenLink
        Try
            Dim strClientCode As String = Me.txtClientName.EditValue

            If CheckIfNull(strClientCode) = False Then

                Dim frm600_03ClientContactList As New frm600_03ClientContactList
                frm600_03ClientContactList.ObjForm = Me
                frm600_03ClientContactList.isExecutedFrom_frm601_01QuotationEdit = True

                frm600_03ClientContactList.strLogonUser = Me.strLogonUser
                frm600_03ClientContactList.intLogOnUserID = Me.intLogOnUserID
                frm600_03ClientContactList.intLogOnUserLevel = Me.intLogOnUserLevel
                frm600_03ClientContactList.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm600_03ClientContactList.txtClientCode.EditValue = strClientCode
                frm600_03ClientContactList.txtClientCode.Enabled = False

                frm600_03ClientContactList.txtClientName.EditValue = Me.txtClientName.Text
                frm600_03ClientContactList.txtClientName.Enabled = False
                frm600_03ClientContactList.Show()
                frm600_03ClientContactList.FillDataSetforEditing(strClientCode)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSalesPerson_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSalesPerson.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm20107SalesPersonMaster As New frm20107SalesPersonMaster
            frm20107SalesPersonMaster.ObjForm = Me
            frm20107SalesPersonMaster.Show()
            frm20107SalesPersonMaster.txtSalesPersonName.Focus()
            frm20107SalesPersonMaster.isExecutedFrom_frm601_01QuotationEdit = True

        End If
    End Sub

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        GetReportDetails("IMS-QTN-01")
        Me.txtSubject.EditValue = gReportSubject
        Me.txtSubject.Focus()

    End Sub

    Private Sub cmdAddIntro_Click(sender As Object, e As EventArgs) Handles cmdAddIntro.Click
        GetReportDetails("IMS-QTN-01")
        Me.txtQuoteIntro.Text = gReportIntroduction
        Me.txtQuoteIntro.Focus()
    End Sub

    Private Sub txtAddText_Click(sender As Object, e As EventArgs) Handles txtAddText.Click
        GetReportDetails("IMS-QTN-01")
        Me.txtQuoteSummary.Text = gReportSummary
        Me.txtQuoteSummary.Focus()
    End Sub

    Private Sub cmdAddThanksNotes_Click(sender As Object, e As EventArgs) Handles cmdAddThanksNotes.Click
        GetReportDetails("IMS-QTN-01")
        Me.txtQuoteThanksNote.Text = gReportThanksNote
        Me.txtQuoteThanksNote.Focus()
    End Sub




    Private Sub btnDefaultSubject_Click(sender As Object, e As EventArgs) Handles btnDefaultSubject.Click
        'UpdateReportDefaults
        Try
            If UpdateReportDefaults(Me.txtSubject.EditValue, "ReportSubject", "IMS-QTN-%") Then
                MessageBox.Show("Quotation Subject has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefaultIntro_Click(sender As Object, e As EventArgs) Handles btnDefaultIntro.Click
        Try
            If UpdateReportDefaults(Me.txtQuoteIntro.EditValue, "ReportIntroduction", "IMS-QTN-%") Then
                MessageBox.Show("Quotation Introduction has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefaultSummary_Click(sender As Object, e As EventArgs) Handles btnDefaultSummary.Click
        '
        Try
            If UpdateReportDefaults(Me.txtQuoteSummary.EditValue, "ReportSummary", "IMS-QTN-%") Then
                MessageBox.Show("Quotation Summary has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefaultThanks_Click(sender As Object, e As EventArgs) Handles btnDefaultThanks.Click
        '
        Try
            If UpdateReportDefaults(Me.txtQuoteThanksNote.EditValue, "ReportThanksNote", "IMS-QTN-%") Then
                MessageBox.Show("Quotation Thanks Note has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
    '    'Dim rpt1 As New rpt601_01CustomQuotationFormat1

    '    'rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

    '    ''Dim rpt2 As New rpt601_08QuotationTerms
    '    ''rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)

    '    ''rpt1.XrSubreport1.ReportSource = rpt2


    '    'rpt1.showDiscount.Value = Me.txtShowCompanySeal.EditValue

    '    'rpt1.RequestParameters = False
    '    'rpt1.ShowPreview()

    '    'Dim report As New rpt601_01CustomQuotationFormat1(If(Me.txtShowCompanySeal.EditValue, FillDatasetFromGrid(), Dsfrm601_01QuotationEdit), Me.gvInvoiceChild)
    '    Dim report As New rpt601_01CustomQuotationFormat1(FillDatasetFromGrid(), Me.gvInvoiceChild)
    '    Dim printTool As New ReportPrintTool(report)
    '    printTool.ShowPreviewDialog()

    'End Sub

    'Private Function FillDatasetFromGrid() As DataSet

    '    'Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, QuotationNo)

    '    Dim ds As New dsfrm601_01QuotationEdit()
    '    Dim rowHandle As Integer
    '    Dim gridRow As DataRow
    '    For i As Integer = 0 To gvInvoiceChild.RowCount - 1
    '        rowHandle = gvInvoiceChild.GetVisibleRowHandle(i)
    '        If (Not gvInvoiceChild.IsGroupRow(rowHandle)) Then
    '            gridRow = gvInvoiceChild.GetDataRow(rowHandle)
    '            ds.Tables(0).Rows.Add(gridRow.ItemArray)
    '        End If
    '    Next i
    '    Return ds
    'End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewQuotationWtDetails.ItemClick

        Me.PopupContainerControl3.Show()

    End Sub

    Private Sub txtColumn1_EditValueChanged(sender As Object, e As EventArgs) Handles txtColumn1.EditValueChanged
        Try
            If CheckIfNull(Me.txtColumn1.EditValue) = False Then
                Me.lblColumn1.EditValue = Me.Dsfrm601_01QuotationEdit1.Tables("tbl600_06QuotationCustomColumns").Rows.Find(Me.txtColumn1.EditValue).Item("ColumnLabel")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtColumn2_EditValueChanged(sender As Object, e As EventArgs) Handles txtColumn2.EditValueChanged
        Try
            If CheckIfNull(Me.txtColumn2.EditValue) = False Then
                Me.lblColumn2.EditValue = Me.Dsfrm601_01QuotationEdit1.Tables("tbl600_06QuotationCustomColumns").Rows.Find(Me.txtColumn2.EditValue).Item("ColumnLabel")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtColumn3_EditValueChanged(sender As Object, e As EventArgs) Handles txtColumn3.EditValueChanged
        Try
            If CheckIfNull(Me.txtColumn3.EditValue) = False Then
                Me.lblColumn3.EditValue = Me.Dsfrm601_01QuotationEdit1.Tables("tbl600_06QuotationCustomColumns").Rows.Find(Me.txtColumn3.EditValue).Item("ColumnLabel")
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnClosePopupContainer3_Click(sender As Object, e As EventArgs) Handles btnClosePopupContainer3.Click
        Me.PopupContainerControl3.Hide()

    End Sub

    Private Sub txtColumnsToShow_EditValueChanged(sender As Object, e As EventArgs) Handles txtColumnsToShow.EditValueChanged
        If Me.txtColumnsToShow.EditValue = 1 Then
            Me.txtColumn2.EditValue = ""
            Me.txtColumn3.EditValue = ""

            Me.lblColumn2.EditValue = ""
            Me.lblColumn3.EditValue = ""

            Me.txtColumn1.Enabled = True
            Me.txtColumn2.Enabled = False
            Me.txtColumn3.Enabled = False

            Me.lblColumn1.Enabled = True
            Me.lblColumn2.Enabled = False
            Me.lblColumn3.Enabled = False

            Me.txtColumn1.Focus()

        ElseIf Me.txtColumnsToShow.EditValue = 2 Then

            Me.txtColumn3.EditValue = ""

            Me.lblColumn3.EditValue = ""

            Me.txtColumn1.Enabled = True
            Me.txtColumn2.Enabled = True
            Me.txtColumn3.Enabled = False

            Me.lblColumn1.Enabled = True
            Me.lblColumn2.Enabled = True
            Me.lblColumn3.Enabled = False

            Me.txtColumn2.Focus()


        ElseIf Me.txtColumnsToShow.EditValue = 3 Then

            Me.txtColumn1.Enabled = True
            Me.txtColumn2.Enabled = True
            Me.txtColumn3.Enabled = True

            Me.lblColumn1.Enabled = True
            Me.lblColumn2.Enabled = True
            Me.lblColumn3.Enabled = True

            Me.txtColumn3.Focus()

        End If

    End Sub



#Region "For Cost Calculation"

    'Private Sub gvInvoiceChild_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvInvoiceChild.CellValueChanged
    '    Try
    '        If e.Column.Caption = "Description" Then
    '            Dim SelectedValue As String = e.Value
    '            GetGSDetails(SelectedValue)
    '            gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitRateMethod"), gGSStockUnitMethod)

    '            Dim StockCostAvgPrice As Decimal = Me.GetStockIssueCost(SelectedValue)
    '            gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("CostPrice"), StockCostAvgPrice)

    '            UpdateInvoiceChild()

    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Public Function GetStockIssueCost(ByVal GSCode As String) As Decimal
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "SELECT Isnull(AvgCostUnitRate,0) as AvgCostUnitRate FROM qry653_16GetInventoryIssuePriceUsingAvgCost WHERE (GSCode = '" & GSCode & "') "

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    If CheckIfNull(srStockReader.Item("AvgCostUnitRate")) = False Then
                        Return srStockReader.Item("AvgCostUnitRate") & ""
                    Else
                        Return 0
                    End If
                End While
            Else
                Return 0
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return ""
        Finally
            Sqlconnection1.Close()
        End Try
    End Function


#End Region

    Private Sub btnAddOtherCharges_Click(sender As Object, e As EventArgs) Handles btnAddOtherCharges.Click
        Try

            AddCostCharges()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddCostCharges()
        Dim frm601_25QuotedCostItems As New frm601_25QuotedCostItems
        frm601_25QuotedCostItems.ObjForm = Me
        frm601_25QuotedCostItems.isExecutedFrom_frm601_01QuotationEdit = True

        frm601_25QuotedCostItems.strLogonUser = Me.strLogonUser
        frm601_25QuotedCostItems.intLogOnUserID = Me.intLogOnUserID
        frm601_25QuotedCostItems.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_25QuotedCostItems.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_25QuotedCostItems.isBeingNew = False

        frm601_25QuotedCostItems.Show()
        frm601_25QuotedCostItems.btnSave.Caption = "Update"


        Try
            Dim view As DataRowView = DirectCast(Me.Qry60102QuotationChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            frm601_25QuotedCostItems.txtStockDesc.EditValue = GetGSCodeDescription(SelectedGSCode)

            Dim SelectedQuotationChildSlNo As Integer = 0
            SelectedQuotationChildSlNo = view.Row("QuoteChildID")

            frm601_25QuotedCostItems.SelectedQuotationChildSlNo = SelectedQuotationChildSlNo
            frm601_25QuotedCostItems.txtQuoteChildID.EditValue = SelectedQuotationChildSlNo

            frm601_25QuotedCostItems.SelectedQuotationNo = Me.txtQuotationNo.EditValue
            frm601_25QuotedCostItems.txtQuotationNo.EditValue = Me.txtQuotationNo.EditValue
            frm601_25QuotedCostItems.txtGSCode.EditValue = SelectedGSCode
            frm601_25QuotedCostItems.txtItemQty.EditValue = view.Row("QuotedQuantity")
            frm601_25QuotedCostItems.txtCostPrice.EditValue = view.Row("CostPrice")

            frm601_25QuotedCostItems.LoadData(SelectedQuotationChildSlNo)

        Catch ex As Exception

        End Try


        frm601_25QuotedCostItems.txtCostItem.Focus()

    End Sub


    Private Sub btnPrintCostSheet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintCostSheet.ItemClick
        Try

            Dim frm601_26QuoteCostSummary As New frm601_26QuoteCostSummary
            frm601_26QuoteCostSummary.objForm = Me
            frm601_26QuoteCostSummary.isExecutedFrom_frm601_01QuotationEdit = True

            frm601_26QuoteCostSummary.strLogOnUser = Me.strLogonUser
            frm601_26QuoteCostSummary.intLogOnUserID = Me.intLogOnUserID
            frm601_26QuoteCostSummary.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_26QuoteCostSummary.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_26QuoteCostSummary.QuotationNo = Me.txtQuotationNo.EditValue

            frm601_26QuoteCostSummary.Show()
            frm601_26QuoteCostSummary.RetrieveVoucher(Me.txtQuotationNo.EditValue)



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_01QuotationEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_01QuotationEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvInvoiceChild))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvInvoiceChild))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAddProfit_Click(sender As Object, e As EventArgs) Handles cmdAddProfit.Click
        Try
            Dim TotalCost As Decimal = 0D
            Dim ProfitPercentage As Decimal = 0D
            Dim UnitPriceWtProfit As Decimal = 0D

            TotalCost = Me.txtTotalCost.EditValue
            ProfitPercentage = Me.txtProfitPercentage.EditValue
            UnitPriceWtProfit = (TotalCost / Me.txtQty.EditValue) * (1 + ProfitPercentage)

            Me.txtUnitPriceWtProfit.EditValue = Math.Round(UnitPriceWtProfit, 2)

            'Me.gvInvoiceChild.RefreshRow(Me.gvInvoiceChild.FocusedRowHandle)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmdUpdateRows_Click(sender As Object, e As EventArgs) Handles cmdUpdateRows.Click
        Try
            Dim intFocusedRow As Integer = Me.gvInvoiceChild.FocusedRowHandle
            'Update the Data in the Child
            Me.Qry60102QuotationChildBindingSource.EndEdit()
            Me.Qry601_02QuotationChildTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild)
            Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, Me.txtQuotationNo.EditValue)

            Me.gvInvoiceChild.FocusedRowHandle = intFocusedRow
            Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.VisibleColumns(9)
            Me.gvInvoiceChild.ShowEditor()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub gcWorkSheet_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles gcInvoiceChild.ProcessGridKey
        If e.KeyCode = Keys.Enter Then
            TryCast(gcInvoiceChild.FocusedView, ColumnView).FocusedRowHandle += 1
            e.Handled = True
        End If
    End Sub

    'Private Sub gvInvoiceChild_ShownEditor(sender As Object, e As EventArgs) Handles gvInvoiceChild.ShownEditor
    '    Dim view As GridView = CType(sender, GridView)
    '    If view.FocusedColumn.Name = "gcCostDetails" Then
    '        Try
    '            Dim intFocusedRow As Integer = Me.gvInvoiceChild.FocusedRowHandle
    '            'Update the Data in the Child
    '            Me.Qry60102QuotationChildBindingSource.EndEdit()
    '            Me.Qry601_02QuotationChildTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild)
    '            Me.Qry601_02QuotationChildTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.qry601_02QuotationChild, Me.txtQuotationNo.EditValue)

    '            Me.gvInvoiceChild.FocusedRowHandle = intFocusedRow
    '            Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.VisibleColumns(7)
    '            Me.gvInvoiceChild.ShowEditor()

    '        Catch ex As Exception

    '        End Try
    '    End If

    'End Sub


#Region "Attach PDF files"

    Dim ScannedFileLocation As String = ""

    Private Sub GetTheScannedFileLocation()
        GetCompanyDetails(1)
        ScannedFileLocation = ""
        ScannedFileLocation = gScannedLocation
        ScannedFileLocation = gScannedLocation & "VoucherScanned\IMSQuote"
    End Sub

    Public Sub CheckIfPDFAvailable(ByVal VoucherNo As String)
        GetTheScannedFileLocation()
        ScannedFileLocation = ScannedFileLocation & VoucherNo & ".pdf"
        If System.IO.File.Exists(ScannedFileLocation) = True Then
            Me.btnAttachments.Glyph = My.Resources.book_blue

        Else
            Me.btnAttachments.Glyph = My.Resources.book_blue_delete
        End If
        ScannedFileLocation = ""

    End Sub
    Private Sub btnAttachments_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAttachments.ItemClick
        GetTheScannedFileLocation()
        AttachFile(Me.txtQuotationNo.EditValue, ScannedFileLocation)
    End Sub
    Private Sub AttachFile(ByVal DocumentNo As String, ByVal ScannedFileLocation As String)
        Dim nullcheck1 As Boolean = IsDBNull(DocumentNo)
        If nullcheck1 = True Then
            MessageBox.Show("No Records to show.", "No Record", MessageBoxButtons.OK)
        Else
            GetTheScannedFileLocation()
            ScannedFileLocation = ScannedFileLocation & DocumentNo & ".pdf"

            If System.IO.File.Exists(ScannedFileLocation) = True Then
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = DocumentNo
                frmDocuments.LoadDocument(ScannedFileLocation)
                frmDocuments.sourceFile = ScannedFileLocation
                frmDocuments.IsIMSQuote = True
                frmDocuments.Show()
            Else
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = DocumentNo
                frmDocuments.IsIMSQuote = True
                frmDocuments.Show()
                frmDocuments.OpenFileDialogBox()
            End If

        End If
    End Sub


#End Region


    Private Sub txtQuoteSubmittedOn_Leave(sender As Object, e As EventArgs) Handles txtQuoteSubmittedOn.Leave
        Try
            If String.IsNullOrEmpty(ConvertIfNull(Me.txtQuoteSubmittedOn.EditValue)) = False Then
                If String.IsNullOrEmpty(ConvertIfNull(Me.txtQuoteDate.EditValue)) = False Then

                    Dim QuoteDate As Date = Me.txtQuoteDate.EditValue

                    If QuoteDate.Date > Me.txtQuoteSubmittedOn.EditValue Then
                        MessageBox.Show("Quote Submitted Date cannot be less than the Quotation Date, Please review it again.", "Quote Submitted date must be less than Quotation Date.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.txtQuoteSubmittedOn.Focus()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtQuoteDate_Leave(sender As Object, e As EventArgs) Handles txtQuoteDate.Leave
        'DATE BLOCKING
        GetCompanyDetails02(1)
        If gIsDateLockingEnabled = True Then
            If CheckIfNull(Me.txtQuoteDate.EditValue) = True Then
                Me.txtQuoteDate.EditValue = Date.Today()
            End If

            If CheckIfDateBeenLocked("IMS_QUOTATION", Me.txtQuoteDate.EditValue) = True Then
                MessageBox.Show("This Quotation Entry date has been blocked." & vbCrLf & "Please review your entry date.", "Entry Date is Blocked", MessageBoxButtons.OK)
                Me.txtQuoteDate.EditValue = Me.txtQuoteDate.OldEditValue
                Me.txtQuoteDate.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PrintQuotationFormat01()
        Me.SaveAll(False)

        Dim rpt1 As New rpt601_01QuotationFormat001

        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = "IMS-QTN-01"
        Dim frm1 As New frm999_ReportPreviewMaster

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------

        rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

        Dim rpt2 As New rpt601_08QuotationTerms
        rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)

        rpt1.XrSubreport1.ReportSource = rpt2

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
        rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

        If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
            If Me.txtShowCompanySeal.EditValue = True Then
                rpt1.txtCompanySeal.Visible = True
            Else
                rpt1.txtCompanySeal.Visible = False
            End If
        End If

        If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
            rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

            If Me.txtShowSignature.EditValue = True Then
                rpt1.txtSignatureImage.Visible = True
            Else
                rpt1.txtSignatureImage.Visible = False
            End If

            If CheckIfNull(Me.txtSignatory.EditValue) = True Then
                rpt1.boolShowPreparedBy = False
            Else
                If Me.txtSignatory.EditValue = 99 Then
                    rpt1.boolShowPreparedBy = False
                Else
                    rpt1.boolShowPreparedBy = True
                End If
            End If


        End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
            If Me.txtVerifiedSign.EditValue = 99 Then
                rpt1.boolShowVerifiedBy = False
            Else
                rpt1.boolShowVerifiedBy = True
            End If
        End If

        If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
            If Me.txtApprovedSign.EditValue = 99 Then
                rpt1.boolShowApprovedBy = False
            Else
                rpt1.boolShowApprovedBy = True
            End If
        End If

        If Me.txtAdditionsAmount.EditValue = 0 Then
            rpt1.rowAdditions02.Visible = False
        End If

        If Me.txtDeductionsAmount.EditValue = 0 Then
            rpt1.rowDeductions02.Visible = False
        End If

        If Me.txtPrintInLetterHead.EditValue = True Then

            rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
            rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
            rpt1.Watermark.ImageTiling = False
            rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
            rpt1.Watermark.ImageTransparency = 0
            rpt1.Watermark.ShowBehind = True
            'rpt1.Watermark.PageRange = "2,4"

        End If

        If Me.txtPrintAcknowledgement.EditValue = True Then
            rpt1.panelAcceptance.Visible = True
            '16.71, 196
            rpt1.panelAcceptance.LocationF = New Point(17, 196)
            rpt1.ReportFooter.HeightF = 316

        Else
            rpt1.panelAcceptance.Visible = False
            rpt1.panelAcceptance.LocationF = New Point(10, 0)
            rpt1.ReportFooter.HeightF = 166
        End If

        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser
        rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
        rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
        rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

        rpt1.intCompanyID = Me.txtCompanyID.EditValue

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text
        rpt1.RequestParameters = False

        '-------------------------------------
        ' New Report Design Code Starts here
        '-------------------------------------
        frm1.ReportCode = ReportCode
        frm1.DocumentViewer1.DocumentSource = rpt1
        rpt1.DisplayName = ReportCode
        frm1.ReportName = rpt1
        frm1.intLogOnUserID = Me.intLogOnUserID
        frm1.strLogonUser = Me.strLogonUser
        frm1.intCustomReportFormNo = CustomReportFormNo
        frm1.objForm = Me
        frm1.Show()
        '-------------------------------------

    End Sub

    Private Sub btnPreviewQuotationWoVAT_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewQuotationWoVAT.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_01QuotationFormat02

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-QTN-02"
            Dim frm1 As New frm999_ReportPreviewMaster

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            '-------------------------------------------
            'OLD CODES GOES HERE
            '-------------------------------------------

            rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)

            rpt1.XrSubreport1.ReportSource = rpt2

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If

                If CheckIfNull(Me.txtSignatory.EditValue) = True Then
                    rpt1.boolShowPreparedBy = False
                Else
                    If Me.txtSignatory.EditValue = 99 Then
                        rpt1.boolShowPreparedBy = False
                    Else
                        rpt1.boolShowPreparedBy = True
                    End If
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If


            If Me.txtPrintInLetterHead.EditValue = True Then

                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
                'rpt1.Watermark.PageRange = "2,4"

            End If

            If Me.txtPrintAcknowledgement.EditValue = True Then
                rpt1.panelAcceptance.Visible = True
                rpt1.panelAcceptance.LocationF = New Point(17, 196)
                rpt1.ReportFooter.HeightF = 316

            Else
                rpt1.panelAcceptance.Visible = False
                rpt1.panelAcceptance.LocationF = New Point(10, 0)
                rpt1.ReportFooter.HeightF = 166
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser

            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPreviewQuotationWtTotPrice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewQuotationWtTotPrice.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_01QuotationFormat03

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-QTN-03"
            Dim frm1 As New frm999_ReportPreviewMaster

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            '-------------------------------------------
            'OLD CODES GOES HERE
            '-------------------------------------------

            rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

            'Dim rpt2 As New rpt40102QuotationTerms
            'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtQuotationNo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)


            rpt1.XrSubreport1.ReportSource = rpt2

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If

                If CheckIfNull(Me.txtSignatory.EditValue) = True Then
                    rpt1.boolShowPreparedBy = False
                Else
                    If Me.txtSignatory.EditValue = 99 Then
                        rpt1.boolShowPreparedBy = False
                    Else
                        rpt1.boolShowPreparedBy = True
                    End If
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If


            If Me.txtPrintInLetterHead.EditValue = True Then

                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
                'rpt1.Watermark.PageRange = "2,4"

            End If

            If Me.txtPrintAcknowledgement.EditValue = True Then
                rpt1.panelAcceptance.Visible = True
                rpt1.panelAcceptance.LocationF = New Point(17, 196)
                rpt1.ReportFooter.HeightF = 316

            Else
                rpt1.panelAcceptance.Visible = False
                rpt1.panelAcceptance.LocationF = New Point(10, 0)
                rpt1.ReportFooter.HeightF = 166
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPreviewCustomReport_Click(sender As Object, e As EventArgs) Handles btnPreviewCustomReport.Click
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_01CustomQuotationFormat1

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-QTN-05"
            Dim frm1 As New frm999_ReportPreviewMaster

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            '-------------------------------------------
            'OLD CODES GOES HERE
            '-------------------------------------------

            rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)

            rpt1.XrSubreport1.ReportSource = rpt2

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If

            If Me.txtAdditionsAmount.EditValue = 0 Then
                rpt1.rowAdditions.Visible = False
            End If

            If Me.txtDeductionsAmount.EditValue = 0 Then
                rpt1.rowDeductions.Visible = False
            End If

            If Me.txtPrintInLetterHead.EditValue = True Then

                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
                'rpt1.Watermark.PageRange = "2,4"

            End If

            If Me.txtPrintAcknowledgement.EditValue = True Then
                rpt1.panelAcceptance.Visible = True
                rpt1.panelAcceptance.LocationF = New Point(10, 177)
                rpt1.ReportFooter.HeightF = 316

            Else
                rpt1.panelAcceptance.Visible = False
                rpt1.panelAcceptance.LocationF = New Point(10, 0)
                rpt1.ReportFooter.HeightF = 166
            End If


            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue

            rpt1.GetColumnOne(Me.lblColumn1.Text, Me.txtColumn1.EditValue)
            rpt1.GetColumnTwo(Me.lblColumn2.Text, Me.txtColumn2.EditValue)
            rpt1.GetColumnThree(Me.lblColumn3.Text, Me.txtColumn3.EditValue)

            rpt1.SetColumns(Me.txtColumnsToShow.EditValue)

            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            'rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPreviewQuoteFormat4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewQuoteFormat4.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_01QuotationFormat04

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-QTN-04"
            Dim frm1 As New frm999_ReportPreviewMaster

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            '-------------------------------------------
            'OLD CODES GOES HERE
            '-------------------------------------------
            rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)


            rpt1.XrSubreport1.ReportSource = rpt2

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If

                If CheckIfNull(Me.txtSignatory.EditValue) = True Then
                    rpt1.boolShowPreparedBy = False
                Else
                    If Me.txtSignatory.EditValue = 99 Then
                        rpt1.boolShowPreparedBy = False
                    Else
                        rpt1.boolShowPreparedBy = True
                    End If
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If


            If Me.txtPrintInLetterHead.EditValue = True Then

                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
                'rpt1.Watermark.PageRange = "2,4"

            End If

            If Me.txtPrintAcknowledgement.EditValue = True Then
                rpt1.panelAcceptance.Visible = True
                rpt1.panelAcceptance.LocationF = New Point(17, 196)
                rpt1.ReportFooter.HeightF = 316

            Else
                rpt1.panelAcceptance.Visible = False
                rpt1.panelAcceptance.LocationF = New Point(10, 0)
                rpt1.ReportFooter.HeightF = 166
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPreviewTechnicalQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewTechnicalQuote.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_01QuotationFormat05

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-QTN-06"
            Dim frm1 As New frm999_ReportPreviewMaster

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            '-------------------------------------------
            'OLD CODES GOES HERE
            '-------------------------------------------

            rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

            'Dim rpt2 As New rpt40102QuotationTerms
            'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtQuotationNo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)


            rpt1.XrSubreport1.ReportSource = rpt2

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If

                If CheckIfNull(Me.txtSignatory.EditValue) = True Then
                    rpt1.boolShowPreparedBy = False
                Else
                    If Me.txtSignatory.EditValue = 99 Then
                        rpt1.boolShowPreparedBy = False
                    Else
                        rpt1.boolShowPreparedBy = True
                    End If
                End If

            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If


            If Me.txtPrintInLetterHead.EditValue = True Then

                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
                'rpt1.Watermark.PageRange = "2,4"

            End If

            If Me.txtPrintAcknowledgement.EditValue = True Then
                rpt1.panelAcceptance.Visible = True
                rpt1.panelAcceptance.LocationF = New Point(17, 196)
                rpt1.ReportFooter.HeightF = 316

            Else
                rpt1.panelAcceptance.Visible = False
                rpt1.panelAcceptance.LocationF = New Point(10, 0)
                rpt1.ReportFooter.HeightF = 166
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------

        Catch ex As Exception

        End Try
    End Sub


    'Private Sub AddMenu(ByVal menuName As String, ByVal id As Integer, ByVal parentId As Integer, ByVal fileName As String)
    '    Dim subitem As BarSubItem = CreateSubItem(menuName, id, fileName)

    '    If parentId <> 0 Then
    '        Dim parentItem As BarSubItem = TryCast(Ribbon.Items.FindById(parentId), BarSubItem)
    '        parentItem.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(subitem))
    '    Else
    '        menuBarSubItem.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(subitem))
    '    End If
    'End Sub

    'Private Function CreateSubItem(ByVal menuName As String, ByVal id As Integer, ByVal fileName As String) As BarSubItem
    '    Dim subitem As BarSubItem = New BarSubItem(Ribbon.Manager, menuName)
    '    subitem.Id = id
    '    If Not String.IsNullOrEmpty(fileName) Then subitem.Glyph = System.Drawing.Image.FromFile("file.png")
    '    Return subitem
    'End Function

    'Private Sub AddMenuItem(ByVal menuName As String, ByVal id As Integer, ByVal parentId As Integer, ByVal fileName As String)
    '    Dim buttonItem As BarButtonItem = New BarButtonItem(Ribbon.Manager, menuName)
    '    buttonItem.Id = id
    '    buttonItem.Tag = fileName
    '    buttonItem.ItemClick += buttonItem_ItemClick
    '    If Not String.IsNullOrEmpty(fileName) Then buttonItem.Glyph = System.Drawing.Image.FromFile("file.png")

    '    If parentId <> 0 Then
    '        Dim parentItem As BarSubItem = TryCast(Ribbon.Items.FindById(parentId), BarSubItem)
    '        parentItem.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(buttonItem))
    '    Else
    '        menuBarSubItem.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(buttonItem))
    '    End If
    'End Sub

    'Private Sub CreateContainerLink()

    'End Sub

#Region "Populate Custom Report Buttons"
    'Change this code for other forms.. 
    Dim CustomReportFormNo As Integer = 1


    Public Sub PopulateCustomReportButtons(ByVal CustomReportFormNo As Integer)

        GetCustomReportNo(CustomReportFormNo, barSubItemCustomReportDesigns)

    End Sub

    Public Sub RemoveAllButtonsInSubItem()

        barSubItemCustomReportDesigns.ClearLinks()
    End Sub

    Public Function GetCustomReportNo(ByVal CustomReportFormNo As Integer, ByVal subitem As DevExpress.XtraBars.BarSubItem)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReportNo, ReportNo + ' - ' + buttontext as ButtonText from tbl90112ReportAttributes where CustomReportFormNo = '" & CustomReportFormNo & "'"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            Dim intCounter As Integer = 0

            Dim ReportNo As String = ""
            Dim ButtonText As String = ""

            While srStockReader.Read()
                'Run the code for creating button
                ReportNo = srStockReader.Item("ReportNo") & ""
                ButtonText = srStockReader.Item("buttontext") & ""

                Dim btnCustomReport1 As New BarButtonItem
                CreateBarButtonItems(ReportNo, ButtonText, btnCustomReport1, subitem)

            End While
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return 0
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Sub CreateBarButtonItems(ByVal ButtonName As String, ByVal ButtonText As String, ByVal ButtonItem As BarButtonItem, ByVal subitem As DevExpress.XtraBars.BarSubItem)

        ButtonItem.Caption = ButtonText
        ButtonItem.Id = BarManager1.GetNewItemId()
        ButtonItem.Name = ButtonName
        ButtonItem.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        ButtonItem.ItemAppearance.Normal.Options.UseFont = True
        ButtonItem.ImageOptions.Image = My.Resources.DailyRpt32x32

        AddHandler ButtonItem.ItemClick, AddressOf btnCustomReport1_ItemClick
        subitem.AddItem(ButtonItem)

    End Sub

    Private Sub btnCustomReport1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        OpenReport(e.Item.Name, CustomReportFormNo)
    End Sub

    Private Sub OpenReport(ByVal ReportNo As String, ByVal CustomReportFormNo As Integer)
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_01QuotationFormat05
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = ReportNo
            Dim frm1 As New frm999_ReportPreviewMaster

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If
            '---------------------------------------

            '-------------------------------------------
            'OLD CODES GOES HERE
            '-------------------------------------------

            rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

            'Dim rpt2 As New rpt40102QuotationTerms
            'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtQuotationNo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)


            rpt1.XrSubreport1.ReportSource = rpt2

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next


            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If


            If Me.txtPrintInLetterHead.EditValue = True Then

                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
                'rpt1.Watermark.PageRange = "2,4"

            End If

            If Me.txtPrintAcknowledgement.EditValue = True Then
                rpt1.panelAcceptance.Visible = True
                rpt1.panelAcceptance.LocationF = New Point(10, 177)
                rpt1.ReportFooter.HeightF = 316

            Else
                rpt1.panelAcceptance.Visible = False
                rpt1.panelAcceptance.LocationF = New Point(10, 0)
                rpt1.ReportFooter.HeightF = 166
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportNo
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportNo
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPreviewQuoteWithGroupCode_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPreviewQuoteWithGroupCode.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_99_05QuotationFormatAttaMusq

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-QTN-07"
            Dim frm1 As New frm999_ReportPreviewMaster

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            '-------------------------------------------
            'OLD CODES GOES HERE
            '-------------------------------------------
            rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)


            rpt1.XrSubreport1.ReportSource = rpt2

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If


            If Me.txtPrintInLetterHead.EditValue = True Then

                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
                'rpt1.Watermark.PageRange = "2,4"

            End If

            If Me.txtPrintAcknowledgement.EditValue = True Then
                rpt1.panelAcceptance.Visible = True
                rpt1.panelAcceptance.LocationF = New Point(17, 196)
                rpt1.ReportFooter.HeightF = 316

            Else
                rpt1.panelAcceptance.Visible = False
                rpt1.panelAcceptance.LocationF = New Point(10, 0)
                rpt1.ReportFooter.HeightF = 166
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCustomFormatBgate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCustomFormatBgate.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_99_06QuotationFormatBgate

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-QTN-21"
            Dim frm1 As New frm999_ReportPreviewMaster

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            '-------------------------------------------
            'OLD CODES GOES HERE
            '-------------------------------------------

            rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

            'Dim rpt2 As New rpt40102QuotationTerms
            'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtQuotationNo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)


            rpt1.XrSubreport1.ReportSource = rpt2

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue


            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                    rpt1.txtApprovedBySignature.Visible = True

                Else
                    rpt1.txtSignatureImage.Visible = False
                    rpt1.txtApprovedBySignature.Visible = False
                End If
            End If


            If Me.txtPrintInLetterHead.EditValue = True Then

                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
                'rpt1.Watermark.PageRange = "2,4"

            End If


            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSubGroupCode_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSubGroupCode.ButtonClick
        If e.Button.Index = 1 Then
            Try
                If CheckIfNull(Me.txtQuotationNo.EditValue) = False Then
                    Dim frm600_15QuotationSubGroups As New frm600_15QuotationSubGroups
                    frm600_15QuotationSubGroups.ObjForm = Me
                    frm600_15QuotationSubGroups.isExecutedFromQuotation = True

                    frm600_15QuotationSubGroups.strLogOnUser = Me.strLogonUser
                    frm600_15QuotationSubGroups.intLogOnUserID = Me.intLogOnUserID
                    frm600_15QuotationSubGroups.intLogOnUserLevel = Me.intLogOnUserLevel
                    frm600_15QuotationSubGroups.intLogOnAccessLevel = Me.intLogOnAccessLevel
                    frm600_15QuotationSubGroups.QuotationNo = Me.txtQuotationNo.EditValue
                    frm600_15QuotationSubGroups.txtQuotationNo.EditValue = Me.txtQuotationNo.EditValue

                    frm600_15QuotationSubGroups.Show()
                    frm600_15QuotationSubGroups.txtSubGroupCode.Focus()

                End If
            Catch ex As Exception
                MessageBox.Show("Error on creating new Quotation Item Sub Group, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub RepositoryItemGridLookUpEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemGridLookUpEdit1.ButtonClick
        If e.Button.Index = 1 Then
            Try
                If CheckIfNull(Me.txtQuotationNo.EditValue) = False Then
                    Dim frm600_15QuotationSubGroups As New frm600_15QuotationSubGroups
                    frm600_15QuotationSubGroups.ObjForm = Me
                    frm600_15QuotationSubGroups.isExecutedFromQuotation = True

                    frm600_15QuotationSubGroups.strLogOnUser = Me.strLogonUser
                    frm600_15QuotationSubGroups.intLogOnUserID = Me.intLogOnUserID
                    frm600_15QuotationSubGroups.intLogOnUserLevel = Me.intLogOnUserLevel
                    frm600_15QuotationSubGroups.intLogOnAccessLevel = Me.intLogOnAccessLevel
                    frm600_15QuotationSubGroups.QuotationNo = Me.txtQuotationNo.EditValue
                    frm600_15QuotationSubGroups.txtQuotationNo.EditValue = Me.txtQuotationNo.EditValue

                    frm600_15QuotationSubGroups.Show()
                    frm600_15QuotationSubGroups.txtSubGroupCode.Focus()

                End If
            Catch ex As Exception
                MessageBox.Show("Error on creating new Quotation Item Sub Group, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub btnVerify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnVerify.ItemClick
        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_01QuotationEdit_btnVerify") = False Then
            MessageBox.Show("You have no Access rights to Verify the Quotation. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this Pr Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Verifying User have not assigned to Signatory in the System.", "Verify Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this PR is submitted
        If CheckIfQuotationIsSubmitted(Me.txtQuotationNo.EditValue) = False Then
            MessageBox.Show("Quotation is not yet Submitted, please submit the Quotation for verfication process.", "Quotation Not Submitted for verification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        SaveAll(False)
        Me.VerifyQuotation(Me.txtQuotationNo.EditValue)

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60101-002")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " verified & Sent the Quotation for your Approval."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New PR/Enquiry is ready to Approve.")

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshQuotationMasterDataGrid()
    End Sub


    Private Sub VerifyQuotation(ByVal QuotationNo As String)
        If CheckIfNull(QuotationNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60101QuotationMasterBindingSource.Current, DataRowView)
            view.Row("IsVerified") = True
            view.Row("VerifiedBy") = Me.strLogonUser
            view.Row("VerifiedOn") = Date.Now
            ''Set the Status to 32 - Enquiry/Request Verified
            'view.Row("PurchaseRequestStatusID") = 32

            view.Row("VerifiedSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            Me.Tbl60101QuotationMasterBindingSource.EndEdit()
            Me.Tbl601_01QuotationMasterTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.tbl601_01QuotationMaster)

            MessageBox.Show("Quotation has been Verified and processed for Approval.", "Verify Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Function CheckIfQuotationIsSubmitted(ByVal QuoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select QuoteNo from tbl601_01QuotationMaster where (QuoteNo = '" & QuoteNo & "') and (Isnull(IsSubmitted,0) = 1 )"

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

    Public Function CheckIfQuotationIsVerified(ByVal QuoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select QuoteNo from tbl601_01QuotationMaster where (QuoteNo = '" & QuoteNo & "') and (Isnull(IsVerified,0) = 1 )"

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


    'Disable All Controls
    Public Sub DisableAllControls()

        Me.btnMoveUp.Enabled = False
        Me.btnMoveDown.Enabled = False
        Me.btnResetLayout.Enabled = False
        Me.btnSetDefaultLayout.Enabled = False

        Me.btnSave.Enabled = False
        Me.btnSaveAndClose.Enabled = False
        Me.subItemReports.Enabled = True
        Me.btnDelete.Enabled = False
        Me.btnAddNewLineItem.Enabled = False
        Me.btnTerms.Enabled = False
        Me.btnBack.Enabled = True
        Me.btnAttachments.Enabled = True
        Me.btnSubmit.Enabled = False
        Me.btnVerify.Enabled = False
        Me.btnApprove.Enabled = False

        Me.btnLineItem.Enabled = False
        Me.btnAddLineItem.Enabled = False

        Me.txtSignatory.Enabled = False
        Me.txtVerifiedSign.Enabled = False
        Me.txtApprovedSign.Enabled = False

        Me.txtClientName.Enabled = False

        Me.gcInvoiceChild.Enabled = False

        Me.txtQuoteDate.Enabled = False
        Me.txtClientName.Enabled = False
        Me.txtSalesPerson.Enabled = False
        Me.txtMPRNo.Enabled = False
        Me.txtClientRefName.Enabled = False
        Me.txtClientContactNo.Enabled = False
        Me.txtModeOfRequest.Enabled = False
        Me.txtTypeOfRequest.Enabled = False
        Me.txtClientEmail.Enabled = False
        Me.txtProject.Enabled = False

        Me.txtSubject.Enabled = False
        Me.btnDefaultSubject.Enabled = False
        Me.btnAddSubject.Enabled = False
        Me.txtQuoteIntro.Enabled = False
        Me.btnDefaultIntro.Enabled = False
        Me.cmdAddIntro.Enabled = False
        Me.txtQuoteSummary.Enabled = False
        Me.btnDefaultSummary.Enabled = False
        Me.txtAddText.Enabled = False
        Me.txtQuoteThanksNote.Enabled = False
        Me.btnDefaultThanks.Enabled = False
        Me.cmdAddThanksNotes.Enabled = False

        Me.txtCompanyID.Enabled = False
        Me.txtInventoryGroupMaster.Enabled = False
        Me.txtReferenceNo.Enabled = False
        Me.txtQuoteSubmittedBy.Enabled = False
        Me.txtQuoteSubmittedOn.Enabled = False
        Me.txtRequestStatus.Enabled = False

        Me.groupShipment.Enabled = False

        Me.txtSignatory.Enabled = False
        Me.txtVerifiedSign.Enabled = False
        Me.txtApprovedSign.Enabled = False

    End Sub

    'Disable All Controls
    Public Sub EnableAllControls()

        Me.btnMoveUp.Enabled = True
        Me.btnMoveDown.Enabled = True
        Me.btnResetLayout.Enabled = True
        Me.btnSetDefaultLayout.Enabled = True

        Me.btnSave.Enabled = True
        Me.btnSaveAndClose.Enabled = True
        Me.subItemReports.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnAddNewLineItem.Enabled = True
        Me.btnTerms.Enabled = True
        Me.btnBack.Enabled = True
        Me.btnAttachments.Enabled = True
        Me.btnSubmit.Enabled = True
        Me.btnVerify.Enabled = True
        Me.btnApprove.Enabled = True

        Me.btnLineItem.Enabled = True
        Me.btnAddLineItem.Enabled = True

        Me.txtSignatory.Enabled = True
        Me.txtVerifiedSign.Enabled = True
        Me.txtApprovedSign.Enabled = True

        Me.txtClientName.Enabled = True

        Me.gcInvoiceChild.Enabled = True

        Me.txtQuoteDate.Enabled = True
        Me.txtClientName.Enabled = True
        Me.txtSalesPerson.Enabled = True
        Me.txtMPRNo.Enabled = True
        Me.txtClientRefName.Enabled = True
        Me.txtClientContactNo.Enabled = True
        Me.txtModeOfRequest.Enabled = True
        Me.txtTypeOfRequest.Enabled = True
        Me.txtClientEmail.Enabled = True
        Me.txtProject.Enabled = True

        Me.txtSubject.Enabled = True
        Me.btnDefaultSubject.Enabled = True
        Me.btnAddSubject.Enabled = True
        Me.txtQuoteIntro.Enabled = True
        Me.btnDefaultIntro.Enabled = True
        Me.cmdAddIntro.Enabled = True
        Me.txtQuoteSummary.Enabled = True
        Me.btnDefaultSummary.Enabled = True
        Me.txtAddText.Enabled = True
        Me.txtQuoteThanksNote.Enabled = True
        Me.btnDefaultThanks.Enabled = True
        Me.cmdAddThanksNotes.Enabled = True

        Me.txtCompanyID.Enabled = True
        Me.txtInventoryGroupMaster.Enabled = True
        Me.txtReferenceNo.Enabled = True
        Me.txtQuoteSubmittedBy.Enabled = True
        Me.txtQuoteSubmittedOn.Enabled = True
        Me.txtRequestStatus.Enabled = True

        Me.groupShipment.Enabled = True

        Me.txtSignatory.Enabled = True
        Me.txtVerifiedSign.Enabled = True
        Me.txtApprovedSign.Enabled = True

    End Sub

    Private Sub btnSubmit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSubmit.ItemClick
        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_01QuotationEdit_btnSubmit") = False Then
            MessageBox.Show("You have no Access rights to Submit the Quotation. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Submitting User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.SubmitQuotation(Me.txtQuotationNo.EditValue)

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60101-001")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " submitted a Quotation for your verification."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New PR/Enquiry is ready to verify.")

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshQuotationMasterDataGrid()
    End Sub

    Private Sub SubmitQuotation(ByVal QuotationNo As String)
        If CheckIfNull(QuotationNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60101QuotationMasterBindingSource.Current, DataRowView)
            view.Row("IsSubmitted") = True
            view.Row("SubmittedBy") = Me.strLogonUser
            view.Row("SubmittedOn") = Date.Now

            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            view.Row("QuoteSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            ''Set the Status to 31 - Enquiry/Request Submitted
            'view.Row("PurchaseRequestStatusID") = 31

            Me.Tbl60101QuotationMasterBindingSource.EndEdit()
            Me.Tbl601_01QuotationMasterTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.tbl601_01QuotationMaster)

            MessageBox.Show("Quotation has been submitted for Approval.", "Submit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub


    Private Sub btnApprove_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnApprove.ItemClick
        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_01QuotationEdit_btnApprove") = False Then
            MessageBox.Show("You have no Access rights to Approve the Quotation. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this MPR Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Approving User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this MPR is Verified
        'Check if the Voucher is not Verified, then verify it and Approve it
        If CheckIfQuotationIsVerified(Me.txtQuotationNo.EditValue) = False Then
            If MessageBox.Show("Quotation has not been Verified, Click Yes If you want to verify and Approve this Quotation.", "Quotation is not Verified.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                Me.VerifyQuotation(Me.txtQuotationNo.EditValue)
            Else
                Exit Sub
            End If
        End If


        Me.ApproveQuotation(Me.txtQuotationNo.EditValue)

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60101-003")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " approved " & "Quotation No:" & Me.txtQuotationNo.EditValue & ". for Processing."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify PR/Enquiry is ready to process.")

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshQuotationMasterDataGrid()
    End Sub

    Private Sub ApproveQuotation(ByVal QuotationNo As String)
        If CheckIfNull(QuotationNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60101QuotationMasterBindingSource.Current, DataRowView)
            view.Row("IsApproved") = True
            view.Row("ApprovedBy") = Me.strLogonUser
            view.Row("ApprovedOn") = Date.Now
            ''Set the Status to 33 - Enquiry/Request Approved
            'view.Row("PurchaseRequestStatusID") = 33

            view.Row("ApprovedSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            Me.Tbl60101QuotationMasterBindingSource.EndEdit()
            Me.Tbl601_01QuotationMasterTableAdapter.Update(Me.Dsfrm601_01QuotationEdit.tbl601_01QuotationMaster)

            MessageBox.Show("Quotation has been Approved.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUseItemDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60102QuotationChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.Text = GetGSCodeDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUseItemDetailedDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDetailedDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60102QuotationChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.Text = GetGSCodeDetailedDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPreviewQuotationWImage_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPreviewQuotationWImage.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_01QuotationFormat06

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-QTN-08"
            Dim frm1 As New frm999_ReportPreviewMaster

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            '-------------------------------------------
            'OLD CODES GOES HERE
            '-------------------------------------------

            rpt1.Qry601_05QuotationReportTableAdapter.FillByQuote(rpt1.DsRpt601_01QuotationReport1.qry601_05QuotationReport, Me.txtQuotationNo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtQuotationNo.EditValue)

            rpt1.XrSubreport1.ReportSource = rpt2

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If

                If CheckIfNull(Me.txtSignatory.EditValue) = True Then
                    rpt1.boolShowPreparedBy = False
                Else
                    If Me.txtSignatory.EditValue = 99 Then
                        rpt1.boolShowPreparedBy = False
                    Else
                        rpt1.boolShowPreparedBy = True
                    End If
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If


            If Me.txtPrintInLetterHead.EditValue = True Then

                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
                'rpt1.Watermark.PageRange = "2,4"

            End If

            If Me.txtPrintAcknowledgement.EditValue = True Then
                rpt1.panelAcceptance.Visible = True
                rpt1.panelAcceptance.LocationF = New Point(17, 196)
                rpt1.ReportFooter.HeightF = 316

            Else
                rpt1.panelAcceptance.Visible = False
                rpt1.panelAcceptance.LocationF = New Point(10, 0)
                rpt1.ReportFooter.HeightF = 166
            End If

            Dim ReportTotalHeight As Decimal = rpt1.tblReportTotals.HeightF
            If Me.txtAdditionsAmount.EditValue = 0 Then
                rpt1.rowAdditions.Visible = False
                ReportTotalHeight = ReportTotalHeight - 20
                rpt1.tblReportTotals.HeightF = ReportTotalHeight
            Else
                rpt1.rowAdditions.Visible = True
            End If

            If Me.txtDeductionsAmount.EditValue = 0 Then
                rpt1.rowDeductions.Visible = False
                ReportTotalHeight = ReportTotalHeight - 20
                rpt1.tblReportTotals.HeightF = ReportTotalHeight
            Else
                rpt1.rowDeductions.Visible = True
            End If

            If CheckIfQuotationHasDiscount(Me.txtQuotationNo.EditValue) = False Then
                rpt1.rowDiscount.Visible = False
                ReportTotalHeight = ReportTotalHeight - 20
                rpt1.tblReportTotals.HeightF = ReportTotalHeight
            Else
                rpt1.rowDiscount.Visible = True
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Quote_No_" & Me.txtQuotationNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------

        Catch ex As Exception

        End Try
    End Sub


#End Region


End Class