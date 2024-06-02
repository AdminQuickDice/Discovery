<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm601_34PurchaseOrderItemDetails
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm601_34PurchaseOrderItemDetails))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.repoQuoteNo = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.repoClientName = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colClientCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvQuotationDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceEffectiveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceDateAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceDeliveryDateAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountHead = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuotationNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryNoteNos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferenceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOSReferenceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPONo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPODate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPODateAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientReferenceName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarksInEn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarksInAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSubmitted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmittedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmittedByAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmittedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsVerified = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVerifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVerifiedByAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVerifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedByAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddedByAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedByAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaxCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalcLineAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalcTaxAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomesticStandartRatedRevenue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomesticZeroRatedRevenue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomesticExemptedRevenue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGCCStandardRatedRevenue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGCCZeroRatedRevenue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGCCExpemptedRevenue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExportsRevenue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomesticStandartRatedTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomesticZeroRatedTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomesticExemptedTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGCCStandardRatedTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGCCZeroRatedTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGCCExpemptedTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExportsTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcVoucherList = New DevExpress.XtraGrid.GridControl()
        Me.Qry60410PurchaseItemDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_34PurchaseOrderItemDetails = New ERP.dsfrm601_34PurchaseOrderItemDetails()
        Me.gvAdvBandedQuotationView = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.InvoiceDetails = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPONo1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRevisionNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPODate1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSupplierQuoteNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSupplierQuoteDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSupplierRefNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAttention = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSupplierContactNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSupplierContactEmail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubjectTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPreparedBy = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPreparedOn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colApprovedBy1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colApprovedOn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAddedBy1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAddedOn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colModifiedBy1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colModifiedOn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsApproved1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPOIntroduction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPOSummary = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCompanyBranch = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAdditionsText = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDiscountsText = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPODueDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPOSignatory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAdditionsAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDeductionsAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalBeforeTax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalDiscount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalAfterDiscount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalTaxAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalWithTax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGrandTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSDescrpition = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSDescriptionAr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAddlDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQuotedQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colUnitType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colUnitRateMethod = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colItemDiscount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLineTotalAfterDisc = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLineTotalBeforeTax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLineTaxAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colUnitDesc = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPOTaxSlab = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPOItemRemarks = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLineOrderNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPurchaseTaxSlab = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPurchaseTaxRate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLineTotalWithTax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colOrderedQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colReceivedQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBalanceToReceive = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSupplierNameAr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSupplierAddress = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMPRNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPOThanksNote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colHSCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colVerifiedName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colVerifiedPosition = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colVerifiedContactNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colVerifiedEmail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colApprovedName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colApprovedPosition = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colApprovedContact = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colApprovedEmail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandClientDetails = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandStoreDetails = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandProjectDetails = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colInventoryMasterGroup = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colInventoryMasterGroupID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSalesPersonCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSalesPersonName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSalesPersonUserID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink3 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.txtStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewReminder = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewAssignment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnApprove = New DevExpress.XtraBars.BarButtonItem()
        Me.btnViewVoucher = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddNewPR = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptPR = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnViewServiceRequest = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewRequest = New DevExpress.XtraBars.BarButtonItem()
        Me.btnVerify = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.btnShowMyRequests = New DevExpress.XtraBars.BarButtonItem()
        Me.btnChooseVoucher = New DevExpress.XtraBars.BarListItem()
        Me.btnChooseVouchers = New DevExpress.XtraBars.BarSubItem()
        Me.btnAllVoucherTypes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPaymentVouchers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReceiptVouchers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalesVouchers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPurchasesVouchers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnJournalVouchers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnToday = New DevExpress.XtraBars.BarButtonItem()
        Me.btnYesterday = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisWeek = New DevExpress.XtraBars.BarButtonItem()
        Me.btnShowRecords2 = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.btnEditQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnShowAllRecords = New DevExpress.XtraEditors.DropDownButton()
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.btnBy1stQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy2ndQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy3rdQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy4thQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisMonthFull = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisMonthTillDate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisYear = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisYearTillDate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLastYear = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLastMonth = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOpenLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnResetLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSetDefaultLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSearch = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGroup = New DevExpress.XtraBars.BarButtonItem()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnAddNewAlert = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewSystemAlert = New DevExpress.XtraBars.BarSubItem()
        Me.btnNewAlert = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddNewInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPreviewInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTaxSummaryReport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnlockInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTaxReport = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.btnDuplicateInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Qry604_10PurchaseItemDetailsTableAdapter = New ERP.dsfrm601_34PurchaseOrderItemDetailsTableAdapters.qry604_10PurchaseItemDetailsTableAdapter()
        Me.colProjectMasterCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProjectDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProjectLocation = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoQuoteNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQuotationDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcVoucherList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60410PurchaseItemDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_34PurchaseOrderItemDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAdvBandedQuotationView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.PanelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(19, 371)
        Me.PanelControl1.TabIndex = 111
        '
        'repoQuoteNo
        '
        Me.repoQuoteNo.AutoHeight = False
        Me.repoQuoteNo.Name = "repoQuoteNo"
        '
        'repoClientName
        '
        Me.repoClientName.AutoHeight = False
        Me.repoClientName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoClientName.DisplayMember = "ClientName"
        Me.repoClientName.Name = "repoClientName"
        Me.repoClientName.NullText = ""
        Me.repoClientName.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.repoClientName.ValueMember = "ClientCode"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.ColumnPanelRowHeight = 35
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClientCode1, Me.colClientName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.RepositoryItemGridLookUpEdit1View.RowHeight = 35
        '
        'colClientCode1
        '
        Me.colClientCode1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientCode1.AppearanceCell.Options.UseFont = True
        Me.colClientCode1.AppearanceCell.Options.UseTextOptions = True
        Me.colClientCode1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientCode1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientCode1.AppearanceHeader.Options.UseFont = True
        Me.colClientCode1.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientCode1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientCode1.FieldName = "ClientCode"
        Me.colClientCode1.Name = "colClientCode1"
        Me.colClientCode1.Visible = True
        Me.colClientCode1.VisibleIndex = 0
        Me.colClientCode1.Width = 169
        '
        'colClientName
        '
        Me.colClientName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientName.AppearanceCell.Options.UseFont = True
        Me.colClientName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientName.AppearanceHeader.Options.UseFont = True
        Me.colClientName.FieldName = "ClientName"
        Me.colClientName.Name = "colClientName"
        Me.colClientName.Visible = True
        Me.colClientName.VisibleIndex = 1
        Me.colClientName.Width = 909
        '
        'gvQuotationDetails
        '
        Me.gvQuotationDetails.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvQuotationDetails.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvQuotationDetails.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvQuotationDetails.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvQuotationDetails.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvQuotationDetails.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvQuotationDetails.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvQuotationDetails.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvQuotationDetails.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvQuotationDetails.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvQuotationDetails.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvQuotationDetails.Appearance.Empty.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent
        Me.gvQuotationDetails.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvQuotationDetails.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvQuotationDetails.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvQuotationDetails.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvQuotationDetails.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvQuotationDetails.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvQuotationDetails.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvQuotationDetails.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvQuotationDetails.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvQuotationDetails.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvQuotationDetails.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvQuotationDetails.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvQuotationDetails.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvQuotationDetails.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvQuotationDetails.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvQuotationDetails.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvQuotationDetails.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvQuotationDetails.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvQuotationDetails.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvQuotationDetails.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvQuotationDetails.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvQuotationDetails.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvQuotationDetails.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvQuotationDetails.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvQuotationDetails.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvQuotationDetails.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvQuotationDetails.Appearance.GroupRow.Options.UseFont = True
        Me.gvQuotationDetails.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvQuotationDetails.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvQuotationDetails.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvQuotationDetails.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvQuotationDetails.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvQuotationDetails.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvQuotationDetails.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvQuotationDetails.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvQuotationDetails.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.OddRow.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.OddRow.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvQuotationDetails.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvQuotationDetails.Appearance.Preview.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.Preview.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvQuotationDetails.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvQuotationDetails.Appearance.Row.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.Row.Options.UseForeColor = True
        Me.gvQuotationDetails.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvQuotationDetails.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvQuotationDetails.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvQuotationDetails.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvQuotationDetails.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvQuotationDetails.ColumnPanelRowHeight = 40
        Me.gvQuotationDetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoiceNo, Me.colInvoiceDate, Me.colInvoiceEffectiveDate, Me.colInvoiceDateAr, Me.colInvoiceDeliveryDate, Me.colInvoiceDeliveryDateAr, Me.colAccountHead, Me.colQuotationNo, Me.colDeliveryNoteNos, Me.colReferenceNo, Me.colSOSReferenceNo, Me.colPONo, Me.colPODate, Me.colPODateAr, Me.colSalesPerson, Me.colClientReferenceName, Me.colClientContactNo, Me.colClientEmail, Me.colRemarksInEn, Me.colDiscount, Me.colRemarksInAr, Me.colIsSubmitted, Me.colSubmittedBy, Me.colSubmittedByAr, Me.colSubmittedOn, Me.colIsVerified, Me.colVerifiedBy, Me.colVerifiedByAr, Me.colVerifiedOn, Me.colIsApproved, Me.colApprovedBy, Me.colApprovedByAr, Me.colApprovedOn, Me.colAddedBy, Me.colAddedByAr, Me.colAddedOn, Me.colModifiedBy, Me.colModifiedByAr, Me.colModifiedOn, Me.colTaxCategoryID, Me.colcalcLineAmount, Me.colcalcTaxAmount, Me.colDomesticStandartRatedRevenue, Me.colDomesticZeroRatedRevenue, Me.colDomesticExemptedRevenue, Me.colGCCStandardRatedRevenue, Me.colGCCZeroRatedRevenue, Me.colGCCExpemptedRevenue, Me.colExportsRevenue, Me.colDomesticStandartRatedTax, Me.colDomesticZeroRatedTax, Me.colDomesticExemptedTax, Me.colGCCStandardRatedTax, Me.colGCCZeroRatedTax, Me.colGCCExpemptedTax, Me.colExportsTax})
        Me.gvQuotationDetails.CustomizationFormBounds = New System.Drawing.Rectangle(604, 454, 208, 191)
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Name = "formatCompleted"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = True
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.gvQuotationDetails.FormatRules.Add(GridFormatRule1)
        Me.gvQuotationDetails.GridControl = Me.gcVoucherList
        Me.gvQuotationDetails.GroupRowHeight = 30
        Me.gvQuotationDetails.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "PropertyNo", Nothing, "({0})")})
        Me.gvQuotationDetails.Name = "gvQuotationDetails"
        Me.gvQuotationDetails.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvQuotationDetails.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvQuotationDetails.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvQuotationDetails.OptionsSelection.MultiSelect = True
        Me.gvQuotationDetails.OptionsView.ShowFooter = True
        Me.gvQuotationDetails.OptionsView.ShowGroupPanel = False
        Me.gvQuotationDetails.OptionsView.ShowIndicator = False
        Me.gvQuotationDetails.RowHeight = 45
        '
        'colInvoiceNo
        '
        Me.colInvoiceNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceNo.AppearanceCell.Options.UseFont = True
        Me.colInvoiceNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceNo.AppearanceHeader.Options.UseFont = True
        Me.colInvoiceNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvoiceNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceNo.FieldName = "InvoiceNo"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        '
        'colInvoiceDate
        '
        Me.colInvoiceDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceDate.AppearanceCell.Options.UseFont = True
        Me.colInvoiceDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceDate.AppearanceHeader.Options.UseFont = True
        Me.colInvoiceDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvoiceDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceDate.FieldName = "InvoiceDate"
        Me.colInvoiceDate.Name = "colInvoiceDate"
        '
        'colInvoiceEffectiveDate
        '
        Me.colInvoiceEffectiveDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceEffectiveDate.AppearanceCell.Options.UseFont = True
        Me.colInvoiceEffectiveDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceEffectiveDate.AppearanceHeader.Options.UseFont = True
        Me.colInvoiceEffectiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvoiceEffectiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceEffectiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceEffectiveDate.FieldName = "InvoiceEffectiveDate"
        Me.colInvoiceEffectiveDate.Name = "colInvoiceEffectiveDate"
        '
        'colInvoiceDateAr
        '
        Me.colInvoiceDateAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceDateAr.AppearanceCell.Options.UseFont = True
        Me.colInvoiceDateAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceDateAr.AppearanceHeader.Options.UseFont = True
        Me.colInvoiceDateAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvoiceDateAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceDateAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceDateAr.FieldName = "InvoiceDateAr"
        Me.colInvoiceDateAr.Name = "colInvoiceDateAr"
        '
        'colInvoiceDeliveryDate
        '
        Me.colInvoiceDeliveryDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceDeliveryDate.AppearanceCell.Options.UseFont = True
        Me.colInvoiceDeliveryDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceDeliveryDate.AppearanceHeader.Options.UseFont = True
        Me.colInvoiceDeliveryDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvoiceDeliveryDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceDeliveryDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceDeliveryDate.FieldName = "InvoiceDeliveryDate"
        Me.colInvoiceDeliveryDate.Name = "colInvoiceDeliveryDate"
        '
        'colInvoiceDeliveryDateAr
        '
        Me.colInvoiceDeliveryDateAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceDeliveryDateAr.AppearanceCell.Options.UseFont = True
        Me.colInvoiceDeliveryDateAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceDeliveryDateAr.AppearanceHeader.Options.UseFont = True
        Me.colInvoiceDeliveryDateAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvoiceDeliveryDateAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceDeliveryDateAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceDeliveryDateAr.FieldName = "InvoiceDeliveryDateAr"
        Me.colInvoiceDeliveryDateAr.Name = "colInvoiceDeliveryDateAr"
        '
        'colAccountHead
        '
        Me.colAccountHead.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAccountHead.AppearanceCell.Options.UseFont = True
        Me.colAccountHead.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAccountHead.AppearanceHeader.Options.UseFont = True
        Me.colAccountHead.AppearanceHeader.Options.UseTextOptions = True
        Me.colAccountHead.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAccountHead.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAccountHead.FieldName = "AccountHead"
        Me.colAccountHead.Name = "colAccountHead"
        '
        'colQuotationNo
        '
        Me.colQuotationNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQuotationNo.AppearanceCell.Options.UseFont = True
        Me.colQuotationNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQuotationNo.AppearanceHeader.Options.UseFont = True
        Me.colQuotationNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuotationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuotationNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuotationNo.FieldName = "QuotationNo"
        Me.colQuotationNo.Name = "colQuotationNo"
        '
        'colDeliveryNoteNos
        '
        Me.colDeliveryNoteNos.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDeliveryNoteNos.AppearanceCell.Options.UseFont = True
        Me.colDeliveryNoteNos.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDeliveryNoteNos.AppearanceHeader.Options.UseFont = True
        Me.colDeliveryNoteNos.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveryNoteNos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryNoteNos.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveryNoteNos.FieldName = "DeliveryNoteNos"
        Me.colDeliveryNoteNos.Name = "colDeliveryNoteNos"
        '
        'colReferenceNo
        '
        Me.colReferenceNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colReferenceNo.AppearanceCell.Options.UseFont = True
        Me.colReferenceNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colReferenceNo.AppearanceHeader.Options.UseFont = True
        Me.colReferenceNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colReferenceNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReferenceNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReferenceNo.FieldName = "ReferenceNo"
        Me.colReferenceNo.Name = "colReferenceNo"
        '
        'colSOSReferenceNo
        '
        Me.colSOSReferenceNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSOSReferenceNo.AppearanceCell.Options.UseFont = True
        Me.colSOSReferenceNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSOSReferenceNo.AppearanceHeader.Options.UseFont = True
        Me.colSOSReferenceNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSOSReferenceNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSOSReferenceNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSOSReferenceNo.FieldName = "SOSReferenceNo"
        Me.colSOSReferenceNo.Name = "colSOSReferenceNo"
        '
        'colPONo
        '
        Me.colPONo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPONo.AppearanceCell.Options.UseFont = True
        Me.colPONo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPONo.AppearanceHeader.Options.UseFont = True
        Me.colPONo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPONo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPONo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPONo.FieldName = "PONo"
        Me.colPONo.Name = "colPONo"
        '
        'colPODate
        '
        Me.colPODate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPODate.AppearanceCell.Options.UseFont = True
        Me.colPODate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPODate.AppearanceHeader.Options.UseFont = True
        Me.colPODate.AppearanceHeader.Options.UseTextOptions = True
        Me.colPODate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPODate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPODate.FieldName = "PODate"
        Me.colPODate.Name = "colPODate"
        '
        'colPODateAr
        '
        Me.colPODateAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPODateAr.AppearanceCell.Options.UseFont = True
        Me.colPODateAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPODateAr.AppearanceHeader.Options.UseFont = True
        Me.colPODateAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colPODateAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPODateAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPODateAr.FieldName = "PODateAr"
        Me.colPODateAr.Name = "colPODateAr"
        '
        'colSalesPerson
        '
        Me.colSalesPerson.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSalesPerson.AppearanceCell.Options.UseFont = True
        Me.colSalesPerson.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSalesPerson.AppearanceHeader.Options.UseFont = True
        Me.colSalesPerson.AppearanceHeader.Options.UseTextOptions = True
        Me.colSalesPerson.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSalesPerson.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSalesPerson.FieldName = "SalesPerson"
        Me.colSalesPerson.Name = "colSalesPerson"
        '
        'colClientReferenceName
        '
        Me.colClientReferenceName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientReferenceName.AppearanceCell.Options.UseFont = True
        Me.colClientReferenceName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientReferenceName.AppearanceHeader.Options.UseFont = True
        Me.colClientReferenceName.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientReferenceName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientReferenceName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientReferenceName.FieldName = "ClientReferenceName"
        Me.colClientReferenceName.Name = "colClientReferenceName"
        '
        'colClientContactNo
        '
        Me.colClientContactNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientContactNo.AppearanceCell.Options.UseFont = True
        Me.colClientContactNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientContactNo.AppearanceHeader.Options.UseFont = True
        Me.colClientContactNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientContactNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientContactNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientContactNo.FieldName = "ClientContactNo"
        Me.colClientContactNo.Name = "colClientContactNo"
        '
        'colClientEmail
        '
        Me.colClientEmail.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientEmail.AppearanceCell.Options.UseFont = True
        Me.colClientEmail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientEmail.AppearanceHeader.Options.UseFont = True
        Me.colClientEmail.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientEmail.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientEmail.FieldName = "ClientEmail"
        Me.colClientEmail.Name = "colClientEmail"
        '
        'colRemarksInEn
        '
        Me.colRemarksInEn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRemarksInEn.AppearanceCell.Options.UseFont = True
        Me.colRemarksInEn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRemarksInEn.AppearanceHeader.Options.UseFont = True
        Me.colRemarksInEn.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarksInEn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarksInEn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarksInEn.FieldName = "RemarksInEn"
        Me.colRemarksInEn.Name = "colRemarksInEn"
        '
        'colDiscount
        '
        Me.colDiscount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiscount.AppearanceCell.Options.UseFont = True
        Me.colDiscount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiscount.AppearanceHeader.Options.UseFont = True
        Me.colDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiscount.FieldName = "Discount"
        Me.colDiscount.Name = "colDiscount"
        '
        'colRemarksInAr
        '
        Me.colRemarksInAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRemarksInAr.AppearanceCell.Options.UseFont = True
        Me.colRemarksInAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRemarksInAr.AppearanceHeader.Options.UseFont = True
        Me.colRemarksInAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarksInAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarksInAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarksInAr.FieldName = "RemarksInAr"
        Me.colRemarksInAr.Name = "colRemarksInAr"
        '
        'colIsSubmitted
        '
        Me.colIsSubmitted.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsSubmitted.AppearanceCell.Options.UseFont = True
        Me.colIsSubmitted.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsSubmitted.AppearanceHeader.Options.UseFont = True
        Me.colIsSubmitted.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsSubmitted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsSubmitted.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsSubmitted.FieldName = "IsSubmitted"
        Me.colIsSubmitted.Name = "colIsSubmitted"
        '
        'colSubmittedBy
        '
        Me.colSubmittedBy.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubmittedBy.AppearanceCell.Options.UseFont = True
        Me.colSubmittedBy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubmittedBy.AppearanceHeader.Options.UseFont = True
        Me.colSubmittedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubmittedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubmittedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubmittedBy.FieldName = "SubmittedBy"
        Me.colSubmittedBy.Name = "colSubmittedBy"
        '
        'colSubmittedByAr
        '
        Me.colSubmittedByAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubmittedByAr.AppearanceCell.Options.UseFont = True
        Me.colSubmittedByAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubmittedByAr.AppearanceHeader.Options.UseFont = True
        Me.colSubmittedByAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubmittedByAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubmittedByAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubmittedByAr.FieldName = "SubmittedByAr"
        Me.colSubmittedByAr.Name = "colSubmittedByAr"
        '
        'colSubmittedOn
        '
        Me.colSubmittedOn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubmittedOn.AppearanceCell.Options.UseFont = True
        Me.colSubmittedOn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubmittedOn.AppearanceHeader.Options.UseFont = True
        Me.colSubmittedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubmittedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubmittedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubmittedOn.FieldName = "SubmittedOn"
        Me.colSubmittedOn.Name = "colSubmittedOn"
        '
        'colIsVerified
        '
        Me.colIsVerified.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsVerified.AppearanceCell.Options.UseFont = True
        Me.colIsVerified.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsVerified.AppearanceHeader.Options.UseFont = True
        Me.colIsVerified.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsVerified.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsVerified.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsVerified.FieldName = "IsVerified"
        Me.colIsVerified.Name = "colIsVerified"
        '
        'colVerifiedBy
        '
        Me.colVerifiedBy.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedBy.AppearanceCell.Options.UseFont = True
        Me.colVerifiedBy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedBy.AppearanceHeader.Options.UseFont = True
        Me.colVerifiedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colVerifiedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVerifiedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVerifiedBy.FieldName = "VerifiedBy"
        Me.colVerifiedBy.Name = "colVerifiedBy"
        '
        'colVerifiedByAr
        '
        Me.colVerifiedByAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedByAr.AppearanceCell.Options.UseFont = True
        Me.colVerifiedByAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedByAr.AppearanceHeader.Options.UseFont = True
        Me.colVerifiedByAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colVerifiedByAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVerifiedByAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVerifiedByAr.FieldName = "VerifiedByAr"
        Me.colVerifiedByAr.Name = "colVerifiedByAr"
        '
        'colVerifiedOn
        '
        Me.colVerifiedOn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedOn.AppearanceCell.Options.UseFont = True
        Me.colVerifiedOn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedOn.AppearanceHeader.Options.UseFont = True
        Me.colVerifiedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colVerifiedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVerifiedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVerifiedOn.FieldName = "VerifiedOn"
        Me.colVerifiedOn.Name = "colVerifiedOn"
        '
        'colIsApproved
        '
        Me.colIsApproved.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsApproved.AppearanceCell.Options.UseFont = True
        Me.colIsApproved.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsApproved.AppearanceHeader.Options.UseFont = True
        Me.colIsApproved.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsApproved.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsApproved.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsApproved.FieldName = "IsApproved"
        Me.colIsApproved.Name = "colIsApproved"
        '
        'colApprovedBy
        '
        Me.colApprovedBy.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colApprovedBy.AppearanceCell.Options.UseFont = True
        Me.colApprovedBy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colApprovedBy.AppearanceHeader.Options.UseFont = True
        Me.colApprovedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedBy.FieldName = "ApprovedBy"
        Me.colApprovedBy.Name = "colApprovedBy"
        '
        'colApprovedByAr
        '
        Me.colApprovedByAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colApprovedByAr.AppearanceCell.Options.UseFont = True
        Me.colApprovedByAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colApprovedByAr.AppearanceHeader.Options.UseFont = True
        Me.colApprovedByAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedByAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedByAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedByAr.FieldName = "ApprovedByAr"
        Me.colApprovedByAr.Name = "colApprovedByAr"
        '
        'colApprovedOn
        '
        Me.colApprovedOn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colApprovedOn.AppearanceCell.Options.UseFont = True
        Me.colApprovedOn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colApprovedOn.AppearanceHeader.Options.UseFont = True
        Me.colApprovedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedOn.FieldName = "ApprovedOn"
        Me.colApprovedOn.Name = "colApprovedOn"
        '
        'colAddedBy
        '
        Me.colAddedBy.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAddedBy.AppearanceCell.Options.UseFont = True
        Me.colAddedBy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAddedBy.AppearanceHeader.Options.UseFont = True
        Me.colAddedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddedBy.FieldName = "AddedBy"
        Me.colAddedBy.Name = "colAddedBy"
        '
        'colAddedByAr
        '
        Me.colAddedByAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAddedByAr.AppearanceCell.Options.UseFont = True
        Me.colAddedByAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAddedByAr.AppearanceHeader.Options.UseFont = True
        Me.colAddedByAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddedByAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddedByAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddedByAr.FieldName = "AddedByAr"
        Me.colAddedByAr.Name = "colAddedByAr"
        '
        'colAddedOn
        '
        Me.colAddedOn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAddedOn.AppearanceCell.Options.UseFont = True
        Me.colAddedOn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAddedOn.AppearanceHeader.Options.UseFont = True
        Me.colAddedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddedOn.FieldName = "AddedOn"
        Me.colAddedOn.Name = "colAddedOn"
        '
        'colModifiedBy
        '
        Me.colModifiedBy.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModifiedBy.AppearanceCell.Options.UseFont = True
        Me.colModifiedBy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModifiedBy.AppearanceHeader.Options.UseFont = True
        Me.colModifiedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        '
        'colModifiedByAr
        '
        Me.colModifiedByAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModifiedByAr.AppearanceCell.Options.UseFont = True
        Me.colModifiedByAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModifiedByAr.AppearanceHeader.Options.UseFont = True
        Me.colModifiedByAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedByAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedByAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedByAr.FieldName = "ModifiedByAr"
        Me.colModifiedByAr.Name = "colModifiedByAr"
        '
        'colModifiedOn
        '
        Me.colModifiedOn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModifiedOn.AppearanceCell.Options.UseFont = True
        Me.colModifiedOn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModifiedOn.AppearanceHeader.Options.UseFont = True
        Me.colModifiedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedOn.FieldName = "ModifiedOn"
        Me.colModifiedOn.Name = "colModifiedOn"
        '
        'colTaxCategoryID
        '
        Me.colTaxCategoryID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTaxCategoryID.AppearanceCell.Options.UseFont = True
        Me.colTaxCategoryID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTaxCategoryID.AppearanceHeader.Options.UseFont = True
        Me.colTaxCategoryID.AppearanceHeader.Options.UseTextOptions = True
        Me.colTaxCategoryID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTaxCategoryID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTaxCategoryID.FieldName = "TaxCategoryID"
        Me.colTaxCategoryID.Name = "colTaxCategoryID"
        '
        'colcalcLineAmount
        '
        Me.colcalcLineAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colcalcLineAmount.AppearanceCell.Options.UseFont = True
        Me.colcalcLineAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colcalcLineAmount.AppearanceHeader.Options.UseFont = True
        Me.colcalcLineAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colcalcLineAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcalcLineAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colcalcLineAmount.FieldName = "calcLineAmount"
        Me.colcalcLineAmount.Name = "colcalcLineAmount"
        Me.colcalcLineAmount.Visible = True
        Me.colcalcLineAmount.VisibleIndex = 0
        '
        'colcalcTaxAmount
        '
        Me.colcalcTaxAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colcalcTaxAmount.AppearanceCell.Options.UseFont = True
        Me.colcalcTaxAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colcalcTaxAmount.AppearanceHeader.Options.UseFont = True
        Me.colcalcTaxAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colcalcTaxAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcalcTaxAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colcalcTaxAmount.FieldName = "calcTaxAmount"
        Me.colcalcTaxAmount.Name = "colcalcTaxAmount"
        Me.colcalcTaxAmount.Visible = True
        Me.colcalcTaxAmount.VisibleIndex = 1
        '
        'colDomesticStandartRatedRevenue
        '
        Me.colDomesticStandartRatedRevenue.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticStandartRatedRevenue.AppearanceCell.Options.UseFont = True
        Me.colDomesticStandartRatedRevenue.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticStandartRatedRevenue.AppearanceHeader.Options.UseFont = True
        Me.colDomesticStandartRatedRevenue.AppearanceHeader.Options.UseTextOptions = True
        Me.colDomesticStandartRatedRevenue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDomesticStandartRatedRevenue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDomesticStandartRatedRevenue.FieldName = "DomesticStandartRatedRevenue"
        Me.colDomesticStandartRatedRevenue.Name = "colDomesticStandartRatedRevenue"
        Me.colDomesticStandartRatedRevenue.Visible = True
        Me.colDomesticStandartRatedRevenue.VisibleIndex = 2
        '
        'colDomesticZeroRatedRevenue
        '
        Me.colDomesticZeroRatedRevenue.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticZeroRatedRevenue.AppearanceCell.Options.UseFont = True
        Me.colDomesticZeroRatedRevenue.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticZeroRatedRevenue.AppearanceHeader.Options.UseFont = True
        Me.colDomesticZeroRatedRevenue.AppearanceHeader.Options.UseTextOptions = True
        Me.colDomesticZeroRatedRevenue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDomesticZeroRatedRevenue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDomesticZeroRatedRevenue.FieldName = "DomesticZeroRatedRevenue"
        Me.colDomesticZeroRatedRevenue.Name = "colDomesticZeroRatedRevenue"
        Me.colDomesticZeroRatedRevenue.Visible = True
        Me.colDomesticZeroRatedRevenue.VisibleIndex = 3
        '
        'colDomesticExemptedRevenue
        '
        Me.colDomesticExemptedRevenue.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticExemptedRevenue.AppearanceCell.Options.UseFont = True
        Me.colDomesticExemptedRevenue.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticExemptedRevenue.AppearanceHeader.Options.UseFont = True
        Me.colDomesticExemptedRevenue.AppearanceHeader.Options.UseTextOptions = True
        Me.colDomesticExemptedRevenue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDomesticExemptedRevenue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDomesticExemptedRevenue.FieldName = "DomesticExemptedRevenue"
        Me.colDomesticExemptedRevenue.Name = "colDomesticExemptedRevenue"
        Me.colDomesticExemptedRevenue.Visible = True
        Me.colDomesticExemptedRevenue.VisibleIndex = 4
        '
        'colGCCStandardRatedRevenue
        '
        Me.colGCCStandardRatedRevenue.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCStandardRatedRevenue.AppearanceCell.Options.UseFont = True
        Me.colGCCStandardRatedRevenue.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCStandardRatedRevenue.AppearanceHeader.Options.UseFont = True
        Me.colGCCStandardRatedRevenue.AppearanceHeader.Options.UseTextOptions = True
        Me.colGCCStandardRatedRevenue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGCCStandardRatedRevenue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGCCStandardRatedRevenue.FieldName = "GCCStandardRatedRevenue"
        Me.colGCCStandardRatedRevenue.Name = "colGCCStandardRatedRevenue"
        Me.colGCCStandardRatedRevenue.Visible = True
        Me.colGCCStandardRatedRevenue.VisibleIndex = 5
        '
        'colGCCZeroRatedRevenue
        '
        Me.colGCCZeroRatedRevenue.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCZeroRatedRevenue.AppearanceCell.Options.UseFont = True
        Me.colGCCZeroRatedRevenue.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCZeroRatedRevenue.AppearanceHeader.Options.UseFont = True
        Me.colGCCZeroRatedRevenue.AppearanceHeader.Options.UseTextOptions = True
        Me.colGCCZeroRatedRevenue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGCCZeroRatedRevenue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGCCZeroRatedRevenue.FieldName = "GCCZeroRatedRevenue"
        Me.colGCCZeroRatedRevenue.Name = "colGCCZeroRatedRevenue"
        Me.colGCCZeroRatedRevenue.Visible = True
        Me.colGCCZeroRatedRevenue.VisibleIndex = 6
        '
        'colGCCExpemptedRevenue
        '
        Me.colGCCExpemptedRevenue.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCExpemptedRevenue.AppearanceCell.Options.UseFont = True
        Me.colGCCExpemptedRevenue.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCExpemptedRevenue.AppearanceHeader.Options.UseFont = True
        Me.colGCCExpemptedRevenue.AppearanceHeader.Options.UseTextOptions = True
        Me.colGCCExpemptedRevenue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGCCExpemptedRevenue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGCCExpemptedRevenue.FieldName = "GCCExpemptedRevenue"
        Me.colGCCExpemptedRevenue.Name = "colGCCExpemptedRevenue"
        Me.colGCCExpemptedRevenue.Visible = True
        Me.colGCCExpemptedRevenue.VisibleIndex = 7
        '
        'colExportsRevenue
        '
        Me.colExportsRevenue.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExportsRevenue.AppearanceCell.Options.UseFont = True
        Me.colExportsRevenue.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExportsRevenue.AppearanceHeader.Options.UseFont = True
        Me.colExportsRevenue.AppearanceHeader.Options.UseTextOptions = True
        Me.colExportsRevenue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExportsRevenue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExportsRevenue.FieldName = "ExportsRevenue"
        Me.colExportsRevenue.Name = "colExportsRevenue"
        Me.colExportsRevenue.Visible = True
        Me.colExportsRevenue.VisibleIndex = 8
        '
        'colDomesticStandartRatedTax
        '
        Me.colDomesticStandartRatedTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticStandartRatedTax.AppearanceCell.Options.UseFont = True
        Me.colDomesticStandartRatedTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticStandartRatedTax.AppearanceHeader.Options.UseFont = True
        Me.colDomesticStandartRatedTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colDomesticStandartRatedTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDomesticStandartRatedTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDomesticStandartRatedTax.FieldName = "DomesticStandartRatedTax"
        Me.colDomesticStandartRatedTax.Name = "colDomesticStandartRatedTax"
        Me.colDomesticStandartRatedTax.Visible = True
        Me.colDomesticStandartRatedTax.VisibleIndex = 9
        '
        'colDomesticZeroRatedTax
        '
        Me.colDomesticZeroRatedTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticZeroRatedTax.AppearanceCell.Options.UseFont = True
        Me.colDomesticZeroRatedTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticZeroRatedTax.AppearanceHeader.Options.UseFont = True
        Me.colDomesticZeroRatedTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colDomesticZeroRatedTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDomesticZeroRatedTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDomesticZeroRatedTax.FieldName = "DomesticZeroRatedTax"
        Me.colDomesticZeroRatedTax.Name = "colDomesticZeroRatedTax"
        Me.colDomesticZeroRatedTax.Visible = True
        Me.colDomesticZeroRatedTax.VisibleIndex = 10
        '
        'colDomesticExemptedTax
        '
        Me.colDomesticExemptedTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticExemptedTax.AppearanceCell.Options.UseFont = True
        Me.colDomesticExemptedTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDomesticExemptedTax.AppearanceHeader.Options.UseFont = True
        Me.colDomesticExemptedTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colDomesticExemptedTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDomesticExemptedTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDomesticExemptedTax.FieldName = "DomesticExemptedTax"
        Me.colDomesticExemptedTax.Name = "colDomesticExemptedTax"
        Me.colDomesticExemptedTax.Visible = True
        Me.colDomesticExemptedTax.VisibleIndex = 11
        '
        'colGCCStandardRatedTax
        '
        Me.colGCCStandardRatedTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCStandardRatedTax.AppearanceCell.Options.UseFont = True
        Me.colGCCStandardRatedTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCStandardRatedTax.AppearanceHeader.Options.UseFont = True
        Me.colGCCStandardRatedTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colGCCStandardRatedTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGCCStandardRatedTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGCCStandardRatedTax.FieldName = "GCCStandardRatedTax"
        Me.colGCCStandardRatedTax.Name = "colGCCStandardRatedTax"
        Me.colGCCStandardRatedTax.Visible = True
        Me.colGCCStandardRatedTax.VisibleIndex = 12
        '
        'colGCCZeroRatedTax
        '
        Me.colGCCZeroRatedTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCZeroRatedTax.AppearanceCell.Options.UseFont = True
        Me.colGCCZeroRatedTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCZeroRatedTax.AppearanceHeader.Options.UseFont = True
        Me.colGCCZeroRatedTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colGCCZeroRatedTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGCCZeroRatedTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGCCZeroRatedTax.FieldName = "GCCZeroRatedTax"
        Me.colGCCZeroRatedTax.Name = "colGCCZeroRatedTax"
        Me.colGCCZeroRatedTax.Visible = True
        Me.colGCCZeroRatedTax.VisibleIndex = 13
        '
        'colGCCExpemptedTax
        '
        Me.colGCCExpemptedTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCExpemptedTax.AppearanceCell.Options.UseFont = True
        Me.colGCCExpemptedTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGCCExpemptedTax.AppearanceHeader.Options.UseFont = True
        Me.colGCCExpemptedTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colGCCExpemptedTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGCCExpemptedTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGCCExpemptedTax.FieldName = "GCCExpemptedTax"
        Me.colGCCExpemptedTax.Name = "colGCCExpemptedTax"
        Me.colGCCExpemptedTax.Visible = True
        Me.colGCCExpemptedTax.VisibleIndex = 14
        '
        'colExportsTax
        '
        Me.colExportsTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExportsTax.AppearanceCell.Options.UseFont = True
        Me.colExportsTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExportsTax.AppearanceHeader.Options.UseFont = True
        Me.colExportsTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colExportsTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExportsTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExportsTax.FieldName = "ExportsTax"
        Me.colExportsTax.Name = "colExportsTax"
        Me.colExportsTax.Visible = True
        Me.colExportsTax.VisibleIndex = 15
        '
        'gcVoucherList
        '
        Me.gcVoucherList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVoucherList.DataSource = Me.Qry60410PurchaseItemDetailsBindingSource
        Me.gcVoucherList.Location = New System.Drawing.Point(22, 43)
        Me.gcVoucherList.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcVoucherList.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcVoucherList.MainView = Me.gvAdvBandedQuotationView
        Me.gcVoucherList.Name = "gcVoucherList"
        Me.gcVoucherList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoQuoteNo, Me.repoClientName})
        Me.gcVoucherList.Size = New System.Drawing.Size(994, 326)
        Me.gcVoucherList.TabIndex = 124
        Me.gcVoucherList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAdvBandedQuotationView, Me.GridView2, Me.gvQuotationDetails})
        '
        'Qry60410PurchaseItemDetailsBindingSource
        '
        Me.Qry60410PurchaseItemDetailsBindingSource.DataMember = "qry604_10PurchaseItemDetails"
        Me.Qry60410PurchaseItemDetailsBindingSource.DataSource = Me.Dsfrm601_34PurchaseOrderItemDetails
        '
        'Dsfrm601_34PurchaseOrderItemDetails
        '
        Me.Dsfrm601_34PurchaseOrderItemDetails.DataSetName = "dsfrm601_34PurchaseOrderItemDetails"
        Me.Dsfrm601_34PurchaseOrderItemDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvAdvBandedQuotationView
        '
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvAdvBandedQuotationView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedQuotationView.Appearance.Empty.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent
        Me.gvAdvBandedQuotationView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedQuotationView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvAdvBandedQuotationView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvAdvBandedQuotationView.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedQuotationView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvAdvBandedQuotationView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedQuotationView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvAdvBandedQuotationView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvAdvBandedQuotationView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvAdvBandedQuotationView.Appearance.GroupRow.Options.UseFont = True
        Me.gvAdvBandedQuotationView.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedQuotationView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvAdvBandedQuotationView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedQuotationView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.OddRow.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.OddRow.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.Preview.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.Preview.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedQuotationView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedQuotationView.Appearance.Row.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.Row.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedQuotationView.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvAdvBandedQuotationView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvAdvBandedQuotationView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvAdvBandedQuotationView.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvAdvBandedQuotationView.AppearancePrint.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvAdvBandedQuotationView.AppearancePrint.BandPanel.Options.UseFont = True
        Me.gvAdvBandedQuotationView.AppearancePrint.BandPanel.Options.UseTextOptions = True
        Me.gvAdvBandedQuotationView.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvAdvBandedQuotationView.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvAdvBandedQuotationView.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvAdvBandedQuotationView.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.gvAdvBandedQuotationView.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvAdvBandedQuotationView.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvAdvBandedQuotationView.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvAdvBandedQuotationView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.InvoiceDetails, Me.GridBand1, Me.gridBand7, Me.BandClientDetails, Me.BandStoreDetails, Me.BandProjectDetails})
        Me.gvAdvBandedQuotationView.ColumnPanelRowHeight = 40
        Me.gvAdvBandedQuotationView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colPONo1, Me.colPODate1, Me.colSupplierCode, Me.colSupplierQuoteNo, Me.colSupplierQuoteDate, Me.colSupplierRefNo, Me.colAttention, Me.colSupplierContactNo, Me.colSupplierContactEmail, Me.colSubjectTitle, Me.colPreparedBy, Me.colPreparedOn, Me.colApprovedBy1, Me.colApprovedOn1, Me.colAddedBy1, Me.colAddedOn1, Me.colModifiedBy1, Me.colModifiedOn1, Me.colIsApproved1, Me.colPOIntroduction, Me.colPOSummary, Me.colRevisionNo, Me.colCompanyBranch, Me.colAdditionsText, Me.colDiscountsText, Me.colPODueDate, Me.colPOSignatory, Me.colAdditionsAmount, Me.colDeductionsAmount, Me.colTotalBeforeTax, Me.colTotalDiscount, Me.colTotalAfterDiscount, Me.colTotalTaxAmount, Me.colTotalWithTax, Me.colGrandTotal, Me.colCompanyName, Me.colGSCode, Me.colGSDescrpition, Me.colGSDescriptionAr, Me.colAddlDescription, Me.colQuotedQuantity, Me.colUnitRateMethod, Me.colUnitType, Me.colUnitDesc, Me.colUnitPrice, Me.colItemDiscount, Me.colPOTaxSlab, Me.colPOItemRemarks, Me.colLineOrderNo, Me.colPurchaseTaxSlab, Me.colPurchaseTaxRate, Me.colLineTotalBeforeTax, Me.colLineTotalAfterDisc, Me.colLineTaxAmount, Me.colLineTotalWithTax, Me.colSupplierName, Me.colSupplierNameAr, Me.colSupplierAddress, Me.colMPRNo, Me.colPOThanksNote, Me.colHSCode, Me.colVerifiedName, Me.colVerifiedPosition, Me.colVerifiedContactNo, Me.colVerifiedEmail, Me.colApprovedName, Me.colApprovedPosition, Me.colApprovedContact, Me.colApprovedEmail, Me.colOrderedQty, Me.colReceivedQty, Me.colBalanceToReceive, Me.colInventoryMasterGroup, Me.colInventoryMasterGroupID, Me.colSalesPersonCode, Me.colSalesPersonName, Me.colSalesPersonUserID, Me.colProjectMasterCode, Me.colProjectDescription, Me.colProjectLocation})
        Me.gvAdvBandedQuotationView.CustomizationFormBounds = New System.Drawing.Rectangle(850, 372, 222, 356)
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Name = "formatCompleted"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Appearance.Options.UseFont = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = True
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.gvAdvBandedQuotationView.FormatRules.Add(GridFormatRule2)
        Me.gvAdvBandedQuotationView.GridControl = Me.gcVoucherList
        Me.gvAdvBandedQuotationView.GroupCount = 1
        Me.gvAdvBandedQuotationView.GroupRowHeight = 30
        Me.gvAdvBandedQuotationView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalAfterDisc", Me.colTotalAfterDiscount, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTaxAmount", Me.colLineTaxAmount, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalWithTax", Me.colLineTotalWithTax, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "GSCode", Me.colGSDescrpition, "No of Items: {0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ItemDiscount", Me.colItemDiscount, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalBeforeTax", Me.colLineTotalBeforeTax, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalAfterDisc", Me.colLineTotalAfterDisc, "{0:n2}")})
        Me.gvAdvBandedQuotationView.Name = "gvAdvBandedQuotationView"
        Me.gvAdvBandedQuotationView.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvAdvBandedQuotationView.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvAdvBandedQuotationView.OptionsLayout.Columns.StoreAppearance = True
        Me.gvAdvBandedQuotationView.OptionsLayout.StoreAllOptions = True
        Me.gvAdvBandedQuotationView.OptionsLayout.StoreAppearance = True
        Me.gvAdvBandedQuotationView.OptionsLayout.StoreFormatRules = True
        Me.gvAdvBandedQuotationView.OptionsMenu.ShowConditionalFormattingItem = True
        Me.gvAdvBandedQuotationView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvAdvBandedQuotationView.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvAdvBandedQuotationView.OptionsSelection.MultiSelect = True
        Me.gvAdvBandedQuotationView.OptionsView.ShowFooter = True
        Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = False
        Me.gvAdvBandedQuotationView.OptionsView.ShowIndicator = False
        Me.gvAdvBandedQuotationView.RowHeight = 40
        Me.gvAdvBandedQuotationView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPONo1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'InvoiceDetails
        '
        Me.InvoiceDetails.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.InvoiceDetails.AppearanceHeader.Options.UseFont = True
        Me.InvoiceDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.InvoiceDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.InvoiceDetails.Caption = "Purchase Order Item Details"
        Me.InvoiceDetails.Columns.Add(Me.colPONo1)
        Me.InvoiceDetails.Columns.Add(Me.colRevisionNo)
        Me.InvoiceDetails.Columns.Add(Me.colPODate1)
        Me.InvoiceDetails.Columns.Add(Me.colSupplierName)
        Me.InvoiceDetails.Columns.Add(Me.colSupplierCode)
        Me.InvoiceDetails.Columns.Add(Me.colSupplierQuoteNo)
        Me.InvoiceDetails.Columns.Add(Me.colSupplierQuoteDate)
        Me.InvoiceDetails.Columns.Add(Me.colSupplierRefNo)
        Me.InvoiceDetails.Columns.Add(Me.colAttention)
        Me.InvoiceDetails.Columns.Add(Me.colSupplierContactNo)
        Me.InvoiceDetails.Columns.Add(Me.colSupplierContactEmail)
        Me.InvoiceDetails.Columns.Add(Me.colSubjectTitle)
        Me.InvoiceDetails.Columns.Add(Me.colPreparedBy)
        Me.InvoiceDetails.Columns.Add(Me.colPreparedOn)
        Me.InvoiceDetails.Columns.Add(Me.colApprovedBy1)
        Me.InvoiceDetails.Columns.Add(Me.colApprovedOn1)
        Me.InvoiceDetails.Columns.Add(Me.colAddedBy1)
        Me.InvoiceDetails.Columns.Add(Me.colAddedOn1)
        Me.InvoiceDetails.Columns.Add(Me.colModifiedBy1)
        Me.InvoiceDetails.Columns.Add(Me.colModifiedOn1)
        Me.InvoiceDetails.Columns.Add(Me.colIsApproved1)
        Me.InvoiceDetails.Columns.Add(Me.colPOIntroduction)
        Me.InvoiceDetails.Columns.Add(Me.colPOSummary)
        Me.InvoiceDetails.Columns.Add(Me.colCompanyBranch)
        Me.InvoiceDetails.Columns.Add(Me.colAdditionsText)
        Me.InvoiceDetails.Columns.Add(Me.colDiscountsText)
        Me.InvoiceDetails.Columns.Add(Me.colPODueDate)
        Me.InvoiceDetails.Columns.Add(Me.colPOSignatory)
        Me.InvoiceDetails.Columns.Add(Me.colAdditionsAmount)
        Me.InvoiceDetails.Columns.Add(Me.colDeductionsAmount)
        Me.InvoiceDetails.Columns.Add(Me.colTotalBeforeTax)
        Me.InvoiceDetails.Columns.Add(Me.colTotalDiscount)
        Me.InvoiceDetails.Columns.Add(Me.colTotalAfterDiscount)
        Me.InvoiceDetails.Columns.Add(Me.colTotalTaxAmount)
        Me.InvoiceDetails.Columns.Add(Me.colTotalWithTax)
        Me.InvoiceDetails.Columns.Add(Me.colGrandTotal)
        Me.InvoiceDetails.Columns.Add(Me.colCompanyName)
        Me.InvoiceDetails.Columns.Add(Me.colGSCode)
        Me.InvoiceDetails.Columns.Add(Me.colGSDescrpition)
        Me.InvoiceDetails.Columns.Add(Me.colGSDescriptionAr)
        Me.InvoiceDetails.Columns.Add(Me.colAddlDescription)
        Me.InvoiceDetails.Columns.Add(Me.colQuotedQuantity)
        Me.InvoiceDetails.Columns.Add(Me.colUnitPrice)
        Me.InvoiceDetails.Columns.Add(Me.colUnitType)
        Me.InvoiceDetails.Columns.Add(Me.colUnitRateMethod)
        Me.InvoiceDetails.Columns.Add(Me.colItemDiscount)
        Me.InvoiceDetails.Columns.Add(Me.colLineTotalAfterDisc)
        Me.InvoiceDetails.Columns.Add(Me.colLineTotalBeforeTax)
        Me.InvoiceDetails.Columns.Add(Me.colLineTaxAmount)
        Me.InvoiceDetails.Columns.Add(Me.colUnitDesc)
        Me.InvoiceDetails.Columns.Add(Me.colPOTaxSlab)
        Me.InvoiceDetails.Columns.Add(Me.colPOItemRemarks)
        Me.InvoiceDetails.Columns.Add(Me.colLineOrderNo)
        Me.InvoiceDetails.Columns.Add(Me.colPurchaseTaxSlab)
        Me.InvoiceDetails.Columns.Add(Me.colPurchaseTaxRate)
        Me.InvoiceDetails.Columns.Add(Me.colLineTotalWithTax)
        Me.InvoiceDetails.Columns.Add(Me.colOrderedQty)
        Me.InvoiceDetails.Columns.Add(Me.colReceivedQty)
        Me.InvoiceDetails.Columns.Add(Me.colBalanceToReceive)
        Me.InvoiceDetails.Columns.Add(Me.colSupplierNameAr)
        Me.InvoiceDetails.Columns.Add(Me.colSupplierAddress)
        Me.InvoiceDetails.Columns.Add(Me.colMPRNo)
        Me.InvoiceDetails.Columns.Add(Me.colPOThanksNote)
        Me.InvoiceDetails.Columns.Add(Me.colHSCode)
        Me.InvoiceDetails.Columns.Add(Me.colVerifiedName)
        Me.InvoiceDetails.Columns.Add(Me.colVerifiedPosition)
        Me.InvoiceDetails.Columns.Add(Me.colVerifiedContactNo)
        Me.InvoiceDetails.Columns.Add(Me.colVerifiedEmail)
        Me.InvoiceDetails.Columns.Add(Me.colApprovedName)
        Me.InvoiceDetails.Columns.Add(Me.colApprovedPosition)
        Me.InvoiceDetails.Columns.Add(Me.colApprovedContact)
        Me.InvoiceDetails.Columns.Add(Me.colApprovedEmail)
        Me.InvoiceDetails.Name = "InvoiceDetails"
        Me.InvoiceDetails.VisibleIndex = 0
        Me.InvoiceDetails.Width = 2162
        '
        'colPONo1
        '
        Me.colPONo1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPONo1.AppearanceCell.Options.UseFont = True
        Me.colPONo1.AppearanceCell.Options.UseTextOptions = True
        Me.colPONo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPONo1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPONo1.AppearanceHeader.Options.UseFont = True
        Me.colPONo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPONo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPONo1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPONo1.FieldName = "PONo"
        Me.colPONo1.Name = "colPONo1"
        Me.colPONo1.Visible = True
        Me.colPONo1.Width = 122
        '
        'colRevisionNo
        '
        Me.colRevisionNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colRevisionNo.AppearanceCell.Options.UseFont = True
        Me.colRevisionNo.AppearanceCell.Options.UseTextOptions = True
        Me.colRevisionNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRevisionNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colRevisionNo.AppearanceHeader.Options.UseFont = True
        Me.colRevisionNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colRevisionNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRevisionNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRevisionNo.FieldName = "RevisionNo"
        Me.colRevisionNo.Name = "colRevisionNo"
        Me.colRevisionNo.Visible = True
        Me.colRevisionNo.Width = 57
        '
        'colPODate1
        '
        Me.colPODate1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPODate1.AppearanceCell.Options.UseFont = True
        Me.colPODate1.AppearanceCell.Options.UseTextOptions = True
        Me.colPODate1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPODate1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPODate1.AppearanceHeader.Options.UseFont = True
        Me.colPODate1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPODate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPODate1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPODate1.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colPODate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPODate1.FieldName = "PODate"
        Me.colPODate1.Name = "colPODate1"
        Me.colPODate1.Visible = True
        '
        'colSupplierName
        '
        Me.colSupplierName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSupplierName.AppearanceCell.Options.UseFont = True
        Me.colSupplierName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSupplierName.AppearanceHeader.Options.UseFont = True
        Me.colSupplierName.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.Width = 215
        '
        'colSupplierCode
        '
        Me.colSupplierCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSupplierCode.AppearanceCell.Options.UseFont = True
        Me.colSupplierCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSupplierCode.AppearanceHeader.Options.UseFont = True
        Me.colSupplierCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        '
        'colSupplierQuoteNo
        '
        Me.colSupplierQuoteNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSupplierQuoteNo.AppearanceCell.Options.UseFont = True
        Me.colSupplierQuoteNo.AppearanceCell.Options.UseTextOptions = True
        Me.colSupplierQuoteNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierQuoteNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSupplierQuoteNo.AppearanceHeader.Options.UseFont = True
        Me.colSupplierQuoteNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierQuoteNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierQuoteNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierQuoteNo.FieldName = "SupplierQuoteNo"
        Me.colSupplierQuoteNo.Name = "colSupplierQuoteNo"
        Me.colSupplierQuoteNo.Visible = True
        Me.colSupplierQuoteNo.Width = 120
        '
        'colSupplierQuoteDate
        '
        Me.colSupplierQuoteDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSupplierQuoteDate.AppearanceCell.Options.UseFont = True
        Me.colSupplierQuoteDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSupplierQuoteDate.AppearanceHeader.Options.UseFont = True
        Me.colSupplierQuoteDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierQuoteDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierQuoteDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierQuoteDate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colSupplierQuoteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSupplierQuoteDate.FieldName = "SupplierQuoteDate"
        Me.colSupplierQuoteDate.Name = "colSupplierQuoteDate"
        '
        'colSupplierRefNo
        '
        Me.colSupplierRefNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSupplierRefNo.AppearanceCell.Options.UseFont = True
        Me.colSupplierRefNo.AppearanceCell.Options.UseTextOptions = True
        Me.colSupplierRefNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierRefNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSupplierRefNo.AppearanceHeader.Options.UseFont = True
        Me.colSupplierRefNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierRefNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierRefNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierRefNo.FieldName = "SupplierRefNo"
        Me.colSupplierRefNo.Name = "colSupplierRefNo"
        Me.colSupplierRefNo.Visible = True
        Me.colSupplierRefNo.Width = 112
        '
        'colAttention
        '
        Me.colAttention.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colAttention.AppearanceCell.Options.UseFont = True
        Me.colAttention.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colAttention.AppearanceHeader.Options.UseFont = True
        Me.colAttention.AppearanceHeader.Options.UseTextOptions = True
        Me.colAttention.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAttention.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAttention.FieldName = "Attention"
        Me.colAttention.Name = "colAttention"
        '
        'colSupplierContactNo
        '
        Me.colSupplierContactNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSupplierContactNo.AppearanceCell.Options.UseFont = True
        Me.colSupplierContactNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSupplierContactNo.AppearanceHeader.Options.UseFont = True
        Me.colSupplierContactNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierContactNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierContactNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierContactNo.FieldName = "SupplierContactNo"
        Me.colSupplierContactNo.Name = "colSupplierContactNo"
        '
        'colSupplierContactEmail
        '
        Me.colSupplierContactEmail.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSupplierContactEmail.AppearanceCell.Options.UseFont = True
        Me.colSupplierContactEmail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSupplierContactEmail.AppearanceHeader.Options.UseFont = True
        Me.colSupplierContactEmail.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierContactEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierContactEmail.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierContactEmail.FieldName = "SupplierContactEmail"
        Me.colSupplierContactEmail.Name = "colSupplierContactEmail"
        '
        'colSubjectTitle
        '
        Me.colSubjectTitle.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSubjectTitle.AppearanceCell.Options.UseFont = True
        Me.colSubjectTitle.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSubjectTitle.AppearanceHeader.Options.UseFont = True
        Me.colSubjectTitle.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubjectTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubjectTitle.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubjectTitle.FieldName = "SubjectTitle"
        Me.colSubjectTitle.Name = "colSubjectTitle"
        '
        'colPreparedBy
        '
        Me.colPreparedBy.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPreparedBy.AppearanceCell.Options.UseFont = True
        Me.colPreparedBy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPreparedBy.AppearanceHeader.Options.UseFont = True
        Me.colPreparedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreparedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreparedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreparedBy.FieldName = "PreparedBy"
        Me.colPreparedBy.Name = "colPreparedBy"
        '
        'colPreparedOn
        '
        Me.colPreparedOn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPreparedOn.AppearanceCell.Options.UseFont = True
        Me.colPreparedOn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPreparedOn.AppearanceHeader.Options.UseFont = True
        Me.colPreparedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreparedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreparedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreparedOn.FieldName = "PreparedOn"
        Me.colPreparedOn.Name = "colPreparedOn"
        '
        'colApprovedBy1
        '
        Me.colApprovedBy1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colApprovedBy1.AppearanceCell.Options.UseFont = True
        Me.colApprovedBy1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colApprovedBy1.AppearanceHeader.Options.UseFont = True
        Me.colApprovedBy1.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedBy1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedBy1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedBy1.FieldName = "ApprovedBy"
        Me.colApprovedBy1.Name = "colApprovedBy1"
        '
        'colApprovedOn1
        '
        Me.colApprovedOn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colApprovedOn1.AppearanceCell.Options.UseFont = True
        Me.colApprovedOn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colApprovedOn1.AppearanceHeader.Options.UseFont = True
        Me.colApprovedOn1.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedOn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedOn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedOn1.FieldName = "ApprovedOn"
        Me.colApprovedOn1.Name = "colApprovedOn1"
        '
        'colAddedBy1
        '
        Me.colAddedBy1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colAddedBy1.AppearanceCell.Options.UseFont = True
        Me.colAddedBy1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colAddedBy1.AppearanceHeader.Options.UseFont = True
        Me.colAddedBy1.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddedBy1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddedBy1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddedBy1.FieldName = "AddedBy"
        Me.colAddedBy1.Name = "colAddedBy1"
        '
        'colAddedOn1
        '
        Me.colAddedOn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colAddedOn1.AppearanceCell.Options.UseFont = True
        Me.colAddedOn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colAddedOn1.AppearanceHeader.Options.UseFont = True
        Me.colAddedOn1.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddedOn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddedOn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddedOn1.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colAddedOn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAddedOn1.FieldName = "AddedOn"
        Me.colAddedOn1.Name = "colAddedOn1"
        '
        'colModifiedBy1
        '
        Me.colModifiedBy1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colModifiedBy1.AppearanceCell.Options.UseFont = True
        Me.colModifiedBy1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colModifiedBy1.AppearanceHeader.Options.UseFont = True
        Me.colModifiedBy1.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedBy1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedBy1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedBy1.FieldName = "ModifiedBy"
        Me.colModifiedBy1.Name = "colModifiedBy1"
        '
        'colModifiedOn1
        '
        Me.colModifiedOn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colModifiedOn1.AppearanceCell.Options.UseFont = True
        Me.colModifiedOn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colModifiedOn1.AppearanceHeader.Options.UseFont = True
        Me.colModifiedOn1.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedOn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedOn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedOn1.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colModifiedOn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colModifiedOn1.FieldName = "ModifiedOn"
        Me.colModifiedOn1.Name = "colModifiedOn1"
        '
        'colIsApproved1
        '
        Me.colIsApproved1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colIsApproved1.AppearanceCell.Options.UseFont = True
        Me.colIsApproved1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colIsApproved1.AppearanceHeader.Options.UseFont = True
        Me.colIsApproved1.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsApproved1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsApproved1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsApproved1.FieldName = "IsApproved"
        Me.colIsApproved1.Name = "colIsApproved1"
        '
        'colPOIntroduction
        '
        Me.colPOIntroduction.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPOIntroduction.AppearanceCell.Options.UseFont = True
        Me.colPOIntroduction.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPOIntroduction.AppearanceHeader.Options.UseFont = True
        Me.colPOIntroduction.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOIntroduction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOIntroduction.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOIntroduction.FieldName = "POIntroduction"
        Me.colPOIntroduction.Name = "colPOIntroduction"
        '
        'colPOSummary
        '
        Me.colPOSummary.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPOSummary.AppearanceCell.Options.UseFont = True
        Me.colPOSummary.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPOSummary.AppearanceHeader.Options.UseFont = True
        Me.colPOSummary.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOSummary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOSummary.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOSummary.FieldName = "POSummary"
        Me.colPOSummary.Name = "colPOSummary"
        '
        'colCompanyBranch
        '
        Me.colCompanyBranch.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colCompanyBranch.AppearanceCell.Options.UseFont = True
        Me.colCompanyBranch.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colCompanyBranch.AppearanceHeader.Options.UseFont = True
        Me.colCompanyBranch.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompanyBranch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompanyBranch.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompanyBranch.FieldName = "CompanyBranch"
        Me.colCompanyBranch.Name = "colCompanyBranch"
        '
        'colAdditionsText
        '
        Me.colAdditionsText.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colAdditionsText.AppearanceCell.Options.UseFont = True
        Me.colAdditionsText.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colAdditionsText.AppearanceHeader.Options.UseFont = True
        Me.colAdditionsText.AppearanceHeader.Options.UseTextOptions = True
        Me.colAdditionsText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAdditionsText.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAdditionsText.FieldName = "AdditionsText"
        Me.colAdditionsText.Name = "colAdditionsText"
        '
        'colDiscountsText
        '
        Me.colDiscountsText.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colDiscountsText.AppearanceCell.Options.UseFont = True
        Me.colDiscountsText.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colDiscountsText.AppearanceHeader.Options.UseFont = True
        Me.colDiscountsText.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiscountsText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiscountsText.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiscountsText.FieldName = "DiscountsText"
        Me.colDiscountsText.Name = "colDiscountsText"
        '
        'colPODueDate
        '
        Me.colPODueDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPODueDate.AppearanceCell.Options.UseFont = True
        Me.colPODueDate.AppearanceCell.Options.UseTextOptions = True
        Me.colPODueDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPODueDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPODueDate.AppearanceHeader.Options.UseFont = True
        Me.colPODueDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colPODueDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPODueDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPODueDate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colPODueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPODueDate.FieldName = "PODueDate"
        Me.colPODueDate.Name = "colPODueDate"
        Me.colPODueDate.Visible = True
        Me.colPODueDate.Width = 90
        '
        'colPOSignatory
        '
        Me.colPOSignatory.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPOSignatory.AppearanceCell.Options.UseFont = True
        Me.colPOSignatory.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPOSignatory.AppearanceHeader.Options.UseFont = True
        Me.colPOSignatory.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOSignatory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOSignatory.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOSignatory.FieldName = "POSignatory"
        Me.colPOSignatory.Name = "colPOSignatory"
        '
        'colAdditionsAmount
        '
        Me.colAdditionsAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colAdditionsAmount.AppearanceCell.Options.UseFont = True
        Me.colAdditionsAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colAdditionsAmount.AppearanceHeader.Options.UseFont = True
        Me.colAdditionsAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colAdditionsAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAdditionsAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAdditionsAmount.DisplayFormat.FormatString = "n2"
        Me.colAdditionsAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAdditionsAmount.FieldName = "AdditionsAmount"
        Me.colAdditionsAmount.Name = "colAdditionsAmount"
        '
        'colDeductionsAmount
        '
        Me.colDeductionsAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colDeductionsAmount.AppearanceCell.Options.UseFont = True
        Me.colDeductionsAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colDeductionsAmount.AppearanceHeader.Options.UseFont = True
        Me.colDeductionsAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeductionsAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeductionsAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeductionsAmount.DisplayFormat.FormatString = "n2"
        Me.colDeductionsAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDeductionsAmount.FieldName = "DeductionsAmount"
        Me.colDeductionsAmount.Name = "colDeductionsAmount"
        '
        'colTotalBeforeTax
        '
        Me.colTotalBeforeTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colTotalBeforeTax.AppearanceCell.Options.UseFont = True
        Me.colTotalBeforeTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colTotalBeforeTax.AppearanceHeader.Options.UseFont = True
        Me.colTotalBeforeTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalBeforeTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalBeforeTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalBeforeTax.DisplayFormat.FormatString = "n2"
        Me.colTotalBeforeTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalBeforeTax.FieldName = "TotalBeforeTax"
        Me.colTotalBeforeTax.Name = "colTotalBeforeTax"
        '
        'colTotalDiscount
        '
        Me.colTotalDiscount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colTotalDiscount.AppearanceCell.Options.UseFont = True
        Me.colTotalDiscount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colTotalDiscount.AppearanceHeader.Options.UseFont = True
        Me.colTotalDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalDiscount.DisplayFormat.FormatString = "n2"
        Me.colTotalDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalDiscount.FieldName = "TotalDiscount"
        Me.colTotalDiscount.Name = "colTotalDiscount"
        '
        'colTotalAfterDiscount
        '
        Me.colTotalAfterDiscount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colTotalAfterDiscount.AppearanceCell.Options.UseFont = True
        Me.colTotalAfterDiscount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colTotalAfterDiscount.AppearanceHeader.Options.UseFont = True
        Me.colTotalAfterDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalAfterDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalAfterDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalAfterDiscount.DisplayFormat.FormatString = "n2"
        Me.colTotalAfterDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalAfterDiscount.FieldName = "TotalAfterDiscount"
        Me.colTotalAfterDiscount.Name = "colTotalAfterDiscount"
        '
        'colTotalTaxAmount
        '
        Me.colTotalTaxAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colTotalTaxAmount.AppearanceCell.Options.UseFont = True
        Me.colTotalTaxAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colTotalTaxAmount.AppearanceHeader.Options.UseFont = True
        Me.colTotalTaxAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalTaxAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalTaxAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalTaxAmount.DisplayFormat.FormatString = "n2"
        Me.colTotalTaxAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalTaxAmount.FieldName = "TotalTaxAmount"
        Me.colTotalTaxAmount.Name = "colTotalTaxAmount"
        '
        'colTotalWithTax
        '
        Me.colTotalWithTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colTotalWithTax.AppearanceCell.Options.UseFont = True
        Me.colTotalWithTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colTotalWithTax.AppearanceHeader.Options.UseFont = True
        Me.colTotalWithTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalWithTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalWithTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalWithTax.DisplayFormat.FormatString = "n2"
        Me.colTotalWithTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalWithTax.FieldName = "TotalWithTax"
        Me.colTotalWithTax.Name = "colTotalWithTax"
        '
        'colGrandTotal
        '
        Me.colGrandTotal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colGrandTotal.AppearanceCell.Options.UseFont = True
        Me.colGrandTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colGrandTotal.AppearanceHeader.Options.UseFont = True
        Me.colGrandTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrandTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrandTotal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGrandTotal.DisplayFormat.FormatString = "n2"
        Me.colGrandTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrandTotal.FieldName = "GrandTotal"
        Me.colGrandTotal.Name = "colGrandTotal"
        '
        'colCompanyName
        '
        Me.colCompanyName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colCompanyName.AppearanceCell.Options.UseFont = True
        Me.colCompanyName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colCompanyName.AppearanceHeader.Options.UseFont = True
        Me.colCompanyName.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompanyName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompanyName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        '
        'colGSCode
        '
        Me.colGSCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colGSCode.AppearanceCell.Options.UseFont = True
        Me.colGSCode.AppearanceCell.Options.UseTextOptions = True
        Me.colGSCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colGSCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colGSCode.AppearanceHeader.Options.UseFont = True
        Me.colGSCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSCode.FieldName = "GSCode"
        Me.colGSCode.Name = "colGSCode"
        Me.colGSCode.Visible = True
        Me.colGSCode.Width = 103
        '
        'colGSDescrpition
        '
        Me.colGSDescrpition.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colGSDescrpition.AppearanceCell.Options.UseFont = True
        Me.colGSDescrpition.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colGSDescrpition.AppearanceHeader.Options.UseFont = True
        Me.colGSDescrpition.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDescrpition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDescrpition.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDescrpition.FieldName = "GSDescrpition"
        Me.colGSDescrpition.Name = "colGSDescrpition"
        Me.colGSDescrpition.Visible = True
        Me.colGSDescrpition.Width = 191
        '
        'colGSDescriptionAr
        '
        Me.colGSDescriptionAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colGSDescriptionAr.AppearanceCell.Options.UseFont = True
        Me.colGSDescriptionAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colGSDescriptionAr.AppearanceHeader.Options.UseFont = True
        Me.colGSDescriptionAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDescriptionAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDescriptionAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDescriptionAr.FieldName = "GSDescriptionAr"
        Me.colGSDescriptionAr.Name = "colGSDescriptionAr"
        '
        'colAddlDescription
        '
        Me.colAddlDescription.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colAddlDescription.AppearanceCell.Options.UseFont = True
        Me.colAddlDescription.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colAddlDescription.AppearanceHeader.Options.UseFont = True
        Me.colAddlDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddlDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddlDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddlDescription.FieldName = "AddlDescription"
        Me.colAddlDescription.Name = "colAddlDescription"
        '
        'colQuotedQuantity
        '
        Me.colQuotedQuantity.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colQuotedQuantity.AppearanceCell.Options.UseFont = True
        Me.colQuotedQuantity.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colQuotedQuantity.AppearanceHeader.Options.UseFont = True
        Me.colQuotedQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuotedQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuotedQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuotedQuantity.FieldName = "QuotedQuantity"
        Me.colQuotedQuantity.Name = "colQuotedQuantity"
        Me.colQuotedQuantity.Visible = True
        Me.colQuotedQuantity.Width = 113
        '
        'colUnitPrice
        '
        Me.colUnitPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colUnitPrice.AppearanceCell.Options.UseFont = True
        Me.colUnitPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colUnitPrice.AppearanceHeader.Options.UseFont = True
        Me.colUnitPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        '
        'colUnitType
        '
        Me.colUnitType.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colUnitType.AppearanceCell.Options.UseFont = True
        Me.colUnitType.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colUnitType.AppearanceHeader.Options.UseFont = True
        Me.colUnitType.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitType.FieldName = "UnitType"
        Me.colUnitType.Name = "colUnitType"
        Me.colUnitType.Visible = True
        '
        'colUnitRateMethod
        '
        Me.colUnitRateMethod.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colUnitRateMethod.AppearanceCell.Options.UseFont = True
        Me.colUnitRateMethod.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colUnitRateMethod.AppearanceHeader.Options.UseFont = True
        Me.colUnitRateMethod.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitRateMethod.FieldName = "UnitRateMethod"
        Me.colUnitRateMethod.Name = "colUnitRateMethod"
        Me.colUnitRateMethod.Width = 119
        '
        'colItemDiscount
        '
        Me.colItemDiscount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colItemDiscount.AppearanceCell.Options.UseFont = True
        Me.colItemDiscount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colItemDiscount.AppearanceHeader.Options.UseFont = True
        Me.colItemDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemDiscount.DisplayFormat.FormatString = "n2"
        Me.colItemDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colItemDiscount.FieldName = "ItemDiscount"
        Me.colItemDiscount.Name = "colItemDiscount"
        Me.colItemDiscount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ItemDiscount", "{0:n2}")})
        Me.colItemDiscount.Visible = True
        Me.colItemDiscount.Width = 100
        '
        'colLineTotalAfterDisc
        '
        Me.colLineTotalAfterDisc.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colLineTotalAfterDisc.AppearanceCell.Options.UseFont = True
        Me.colLineTotalAfterDisc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colLineTotalAfterDisc.AppearanceHeader.Options.UseFont = True
        Me.colLineTotalAfterDisc.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalAfterDisc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalAfterDisc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalAfterDisc.DisplayFormat.FormatString = "n2"
        Me.colLineTotalAfterDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLineTotalAfterDisc.FieldName = "LineTotalAfterDisc"
        Me.colLineTotalAfterDisc.Name = "colLineTotalAfterDisc"
        Me.colLineTotalAfterDisc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalAfterDisc", "{0:n2}")})
        Me.colLineTotalAfterDisc.Width = 113
        '
        'colLineTotalBeforeTax
        '
        Me.colLineTotalBeforeTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colLineTotalBeforeTax.AppearanceCell.Options.UseFont = True
        Me.colLineTotalBeforeTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colLineTotalBeforeTax.AppearanceHeader.Options.UseFont = True
        Me.colLineTotalBeforeTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalBeforeTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalBeforeTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalBeforeTax.DisplayFormat.FormatString = "n2"
        Me.colLineTotalBeforeTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLineTotalBeforeTax.FieldName = "LineTotalBeforeTax"
        Me.colLineTotalBeforeTax.Name = "colLineTotalBeforeTax"
        Me.colLineTotalBeforeTax.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalBeforeTax", "{0:n2}")})
        Me.colLineTotalBeforeTax.Visible = True
        Me.colLineTotalBeforeTax.Width = 116
        '
        'colLineTaxAmount
        '
        Me.colLineTaxAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colLineTaxAmount.AppearanceCell.Options.UseFont = True
        Me.colLineTaxAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colLineTaxAmount.AppearanceHeader.Options.UseFont = True
        Me.colLineTaxAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTaxAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTaxAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTaxAmount.DisplayFormat.FormatString = "n2"
        Me.colLineTaxAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLineTaxAmount.FieldName = "LineTaxAmount"
        Me.colLineTaxAmount.Name = "colLineTaxAmount"
        Me.colLineTaxAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTaxAmount", "{0:n2}")})
        Me.colLineTaxAmount.Visible = True
        Me.colLineTaxAmount.Width = 115
        '
        'colUnitDesc
        '
        Me.colUnitDesc.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colUnitDesc.AppearanceCell.Options.UseFont = True
        Me.colUnitDesc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colUnitDesc.AppearanceHeader.Options.UseFont = True
        Me.colUnitDesc.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitDesc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitDesc.FieldName = "UnitDesc"
        Me.colUnitDesc.Name = "colUnitDesc"
        '
        'colPOTaxSlab
        '
        Me.colPOTaxSlab.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPOTaxSlab.AppearanceCell.Options.UseFont = True
        Me.colPOTaxSlab.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPOTaxSlab.AppearanceHeader.Options.UseFont = True
        Me.colPOTaxSlab.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOTaxSlab.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOTaxSlab.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOTaxSlab.FieldName = "POTaxSlab"
        Me.colPOTaxSlab.Name = "colPOTaxSlab"
        '
        'colPOItemRemarks
        '
        Me.colPOItemRemarks.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPOItemRemarks.AppearanceCell.Options.UseFont = True
        Me.colPOItemRemarks.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPOItemRemarks.AppearanceHeader.Options.UseFont = True
        Me.colPOItemRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOItemRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOItemRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOItemRemarks.FieldName = "POItemRemarks"
        Me.colPOItemRemarks.Name = "colPOItemRemarks"
        '
        'colLineOrderNo
        '
        Me.colLineOrderNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colLineOrderNo.AppearanceCell.Options.UseFont = True
        Me.colLineOrderNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colLineOrderNo.AppearanceHeader.Options.UseFont = True
        Me.colLineOrderNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineOrderNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineOrderNo.FieldName = "LineOrderNo"
        Me.colLineOrderNo.Name = "colLineOrderNo"
        '
        'colPurchaseTaxSlab
        '
        Me.colPurchaseTaxSlab.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPurchaseTaxSlab.AppearanceCell.Options.UseFont = True
        Me.colPurchaseTaxSlab.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPurchaseTaxSlab.AppearanceHeader.Options.UseFont = True
        Me.colPurchaseTaxSlab.AppearanceHeader.Options.UseTextOptions = True
        Me.colPurchaseTaxSlab.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPurchaseTaxSlab.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPurchaseTaxSlab.FieldName = "PurchaseTaxSlab"
        Me.colPurchaseTaxSlab.Name = "colPurchaseTaxSlab"
        '
        'colPurchaseTaxRate
        '
        Me.colPurchaseTaxRate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPurchaseTaxRate.AppearanceCell.Options.UseFont = True
        Me.colPurchaseTaxRate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPurchaseTaxRate.AppearanceHeader.Options.UseFont = True
        Me.colPurchaseTaxRate.AppearanceHeader.Options.UseTextOptions = True
        Me.colPurchaseTaxRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPurchaseTaxRate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPurchaseTaxRate.FieldName = "PurchaseTaxRate"
        Me.colPurchaseTaxRate.Name = "colPurchaseTaxRate"
        '
        'colLineTotalWithTax
        '
        Me.colLineTotalWithTax.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colLineTotalWithTax.AppearanceCell.Options.UseFont = True
        Me.colLineTotalWithTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colLineTotalWithTax.AppearanceHeader.Options.UseFont = True
        Me.colLineTotalWithTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalWithTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalWithTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalWithTax.DisplayFormat.FormatString = "n2"
        Me.colLineTotalWithTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLineTotalWithTax.FieldName = "LineTotalWithTax"
        Me.colLineTotalWithTax.Name = "colLineTotalWithTax"
        Me.colLineTotalWithTax.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalWithTax", "{0:n2}")})
        Me.colLineTotalWithTax.Visible = True
        Me.colLineTotalWithTax.Width = 96
        '
        'colOrderedQty
        '
        Me.colOrderedQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colOrderedQty.AppearanceCell.Options.UseBackColor = True
        Me.colOrderedQty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colOrderedQty.AppearanceHeader.Options.UseFont = True
        Me.colOrderedQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderedQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderedQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderedQty.DisplayFormat.FormatString = "n2"
        Me.colOrderedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOrderedQty.FieldName = "OrderedQty"
        Me.colOrderedQty.Name = "colOrderedQty"
        Me.colOrderedQty.Visible = True
        '
        'colReceivedQty
        '
        Me.colReceivedQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colReceivedQty.AppearanceCell.Options.UseBackColor = True
        Me.colReceivedQty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colReceivedQty.AppearanceHeader.Options.UseFont = True
        Me.colReceivedQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceivedQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceivedQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceivedQty.DisplayFormat.FormatString = "n2"
        Me.colReceivedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colReceivedQty.FieldName = "ReceivedQty"
        Me.colReceivedQty.Name = "colReceivedQty"
        Me.colReceivedQty.Visible = True
        '
        'colBalanceToReceive
        '
        Me.colBalanceToReceive.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colBalanceToReceive.AppearanceCell.Options.UseBackColor = True
        Me.colBalanceToReceive.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colBalanceToReceive.AppearanceHeader.Options.UseFont = True
        Me.colBalanceToReceive.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalanceToReceive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalanceToReceive.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBalanceToReceive.DisplayFormat.FormatString = "n2"
        Me.colBalanceToReceive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalanceToReceive.FieldName = "BalanceToReceive"
        Me.colBalanceToReceive.Name = "colBalanceToReceive"
        Me.colBalanceToReceive.Visible = True
        '
        'colSupplierNameAr
        '
        Me.colSupplierNameAr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSupplierNameAr.AppearanceCell.Options.UseFont = True
        Me.colSupplierNameAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSupplierNameAr.AppearanceHeader.Options.UseFont = True
        Me.colSupplierNameAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierNameAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierNameAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierNameAr.FieldName = "SupplierNameAr"
        Me.colSupplierNameAr.Name = "colSupplierNameAr"
        '
        'colSupplierAddress
        '
        Me.colSupplierAddress.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colSupplierAddress.AppearanceCell.Options.UseFont = True
        Me.colSupplierAddress.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSupplierAddress.AppearanceHeader.Options.UseFont = True
        Me.colSupplierAddress.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierAddress.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierAddress.FieldName = "SupplierAddress"
        Me.colSupplierAddress.Name = "colSupplierAddress"
        '
        'colMPRNo
        '
        Me.colMPRNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colMPRNo.AppearanceCell.Options.UseFont = True
        Me.colMPRNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colMPRNo.AppearanceHeader.Options.UseFont = True
        Me.colMPRNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colMPRNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMPRNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMPRNo.FieldName = "MPRNo"
        Me.colMPRNo.Name = "colMPRNo"
        Me.colMPRNo.Visible = True
        Me.colMPRNo.Width = 162
        '
        'colPOThanksNote
        '
        Me.colPOThanksNote.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colPOThanksNote.AppearanceCell.Options.UseFont = True
        Me.colPOThanksNote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colPOThanksNote.AppearanceHeader.Options.UseFont = True
        Me.colPOThanksNote.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOThanksNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOThanksNote.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOThanksNote.FieldName = "POThanksNote"
        Me.colPOThanksNote.Name = "colPOThanksNote"
        '
        'colHSCode
        '
        Me.colHSCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colHSCode.AppearanceCell.Options.UseFont = True
        Me.colHSCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colHSCode.AppearanceHeader.Options.UseFont = True
        Me.colHSCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colHSCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHSCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHSCode.FieldName = "HSCode"
        Me.colHSCode.Name = "colHSCode"
        '
        'colVerifiedName
        '
        Me.colVerifiedName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colVerifiedName.AppearanceCell.Options.UseFont = True
        Me.colVerifiedName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedName.AppearanceHeader.Options.UseFont = True
        Me.colVerifiedName.AppearanceHeader.Options.UseTextOptions = True
        Me.colVerifiedName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVerifiedName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVerifiedName.FieldName = "VerifiedName"
        Me.colVerifiedName.Name = "colVerifiedName"
        '
        'colVerifiedPosition
        '
        Me.colVerifiedPosition.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colVerifiedPosition.AppearanceCell.Options.UseFont = True
        Me.colVerifiedPosition.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedPosition.AppearanceHeader.Options.UseFont = True
        Me.colVerifiedPosition.AppearanceHeader.Options.UseTextOptions = True
        Me.colVerifiedPosition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVerifiedPosition.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVerifiedPosition.FieldName = "VerifiedPosition"
        Me.colVerifiedPosition.Name = "colVerifiedPosition"
        '
        'colVerifiedContactNo
        '
        Me.colVerifiedContactNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colVerifiedContactNo.AppearanceCell.Options.UseFont = True
        Me.colVerifiedContactNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedContactNo.AppearanceHeader.Options.UseFont = True
        Me.colVerifiedContactNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colVerifiedContactNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVerifiedContactNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVerifiedContactNo.FieldName = "VerifiedContactNo"
        Me.colVerifiedContactNo.Name = "colVerifiedContactNo"
        '
        'colVerifiedEmail
        '
        Me.colVerifiedEmail.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colVerifiedEmail.AppearanceCell.Options.UseFont = True
        Me.colVerifiedEmail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colVerifiedEmail.AppearanceHeader.Options.UseFont = True
        Me.colVerifiedEmail.AppearanceHeader.Options.UseTextOptions = True
        Me.colVerifiedEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVerifiedEmail.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVerifiedEmail.FieldName = "VerifiedEmail"
        Me.colVerifiedEmail.Name = "colVerifiedEmail"
        '
        'colApprovedName
        '
        Me.colApprovedName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colApprovedName.AppearanceCell.Options.UseFont = True
        Me.colApprovedName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colApprovedName.AppearanceHeader.Options.UseFont = True
        Me.colApprovedName.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedName.FieldName = "ApprovedName"
        Me.colApprovedName.Name = "colApprovedName"
        '
        'colApprovedPosition
        '
        Me.colApprovedPosition.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colApprovedPosition.AppearanceCell.Options.UseFont = True
        Me.colApprovedPosition.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colApprovedPosition.AppearanceHeader.Options.UseFont = True
        Me.colApprovedPosition.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedPosition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedPosition.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedPosition.FieldName = "ApprovedPosition"
        Me.colApprovedPosition.Name = "colApprovedPosition"
        '
        'colApprovedContact
        '
        Me.colApprovedContact.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colApprovedContact.AppearanceCell.Options.UseFont = True
        Me.colApprovedContact.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colApprovedContact.AppearanceHeader.Options.UseFont = True
        Me.colApprovedContact.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedContact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedContact.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedContact.FieldName = "ApprovedContact"
        Me.colApprovedContact.Name = "colApprovedContact"
        '
        'colApprovedEmail
        '
        Me.colApprovedEmail.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colApprovedEmail.AppearanceCell.Options.UseFont = True
        Me.colApprovedEmail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colApprovedEmail.AppearanceHeader.Options.UseFont = True
        Me.colApprovedEmail.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedEmail.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedEmail.FieldName = "ApprovedEmail"
        Me.colApprovedEmail.Name = "colApprovedEmail"
        Me.colApprovedEmail.Width = 108
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridBand1.AppearanceHeader.Options.UseFont = True
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridBand1.Caption = "No of Items"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Visible = False
        Me.GridBand1.VisibleIndex = -1
        Me.GridBand1.Width = 75
        '
        'gridBand7
        '
        Me.gridBand7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gridBand7.AppearanceHeader.Options.UseFont = True
        Me.gridBand7.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand7.Caption = "Sales Order Amount"
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.Visible = False
        Me.gridBand7.VisibleIndex = -1
        Me.gridBand7.Width = 75
        '
        'BandClientDetails
        '
        Me.BandClientDetails.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandClientDetails.AppearanceHeader.Options.UseFont = True
        Me.BandClientDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.BandClientDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandClientDetails.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandClientDetails.Caption = "Delivery to Client"
        Me.BandClientDetails.Name = "BandClientDetails"
        Me.BandClientDetails.Visible = False
        Me.BandClientDetails.VisibleIndex = -1
        Me.BandClientDetails.Width = 693
        '
        'BandStoreDetails
        '
        Me.BandStoreDetails.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandStoreDetails.AppearanceHeader.Options.UseFont = True
        Me.BandStoreDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.BandStoreDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandStoreDetails.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandStoreDetails.Caption = "Delivery To Store"
        Me.BandStoreDetails.Name = "BandStoreDetails"
        Me.BandStoreDetails.Visible = False
        Me.BandStoreDetails.VisibleIndex = -1
        Me.BandStoreDetails.Width = 238
        '
        'BandProjectDetails
        '
        Me.BandProjectDetails.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandProjectDetails.AppearanceHeader.Options.UseFont = True
        Me.BandProjectDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.BandProjectDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandProjectDetails.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandProjectDetails.Caption = "Delivery to Our Project"
        Me.BandProjectDetails.Name = "BandProjectDetails"
        Me.BandProjectDetails.Visible = False
        Me.BandProjectDetails.VisibleIndex = -1
        '
        'colInventoryMasterGroup
        '
        Me.colInventoryMasterGroup.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colInventoryMasterGroup.AppearanceHeader.Options.UseFont = True
        Me.colInventoryMasterGroup.AppearanceHeader.Options.UseTextOptions = True
        Me.colInventoryMasterGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInventoryMasterGroup.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInventoryMasterGroup.FieldName = "InventoryMasterGroup"
        Me.colInventoryMasterGroup.Name = "colInventoryMasterGroup"
        Me.colInventoryMasterGroup.Visible = True
        '
        'colInventoryMasterGroupID
        '
        Me.colInventoryMasterGroupID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colInventoryMasterGroupID.AppearanceHeader.Options.UseFont = True
        Me.colInventoryMasterGroupID.AppearanceHeader.Options.UseTextOptions = True
        Me.colInventoryMasterGroupID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInventoryMasterGroupID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInventoryMasterGroupID.FieldName = "InventoryMasterGroupID"
        Me.colInventoryMasterGroupID.Name = "colInventoryMasterGroupID"
        Me.colInventoryMasterGroupID.Visible = True
        '
        'colSalesPersonCode
        '
        Me.colSalesPersonCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSalesPersonCode.AppearanceHeader.Options.UseFont = True
        Me.colSalesPersonCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colSalesPersonCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSalesPersonCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSalesPersonCode.FieldName = "SalesPersonCode"
        Me.colSalesPersonCode.Name = "colSalesPersonCode"
        Me.colSalesPersonCode.Visible = True
        '
        'colSalesPersonName
        '
        Me.colSalesPersonName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSalesPersonName.AppearanceHeader.Options.UseFont = True
        Me.colSalesPersonName.AppearanceHeader.Options.UseTextOptions = True
        Me.colSalesPersonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSalesPersonName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSalesPersonName.FieldName = "SalesPersonName"
        Me.colSalesPersonName.Name = "colSalesPersonName"
        Me.colSalesPersonName.Visible = True
        '
        'colSalesPersonUserID
        '
        Me.colSalesPersonUserID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colSalesPersonUserID.AppearanceHeader.Options.UseFont = True
        Me.colSalesPersonUserID.AppearanceHeader.Options.UseTextOptions = True
        Me.colSalesPersonUserID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSalesPersonUserID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSalesPersonUserID.FieldName = "SalesPersonUserID"
        Me.colSalesPersonUserID.Name = "colSalesPersonUserID"
        Me.colSalesPersonUserID.Visible = True
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcVoucherList
        Me.GridView2.Name = "GridView2"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Csv.Separator = ";"
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink3})
        '
        'PrintableComponentLink3
        '
        Me.PrintableComponentLink3.Component = Me.gcVoucherList
        Me.PrintableComponentLink3.Landscape = True
        Me.PrintableComponentLink3.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PrintableComponentLink3.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink3.PaperName = "Delivery Note Details"
        Me.PrintableComponentLink3.PrintingSystemBase = Me.PrintingSystem1
        '
        'txtStartDate
        '
        Me.txtStartDate.EditValue = Nothing
        Me.txtStartDate.EnterMoveNextControl = True
        Me.txtStartDate.Location = New System.Drawing.Point(3, 8)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStartDate.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txtStartDate.Properties.Appearance.Options.UseBackColor = True
        Me.txtStartDate.Properties.Appearance.Options.UseFont = True
        Me.txtStartDate.Properties.Appearance.Options.UseForeColor = True
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtStartDate.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.txtStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtStartDate.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.txtStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtStartDate.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.txtStartDate.Properties.NullText = "Start Date"
        Me.txtStartDate.Size = New System.Drawing.Size(175, 22)
        Me.txtStartDate.TabIndex = 0
        '
        'txtEndDate
        '
        Me.txtEndDate.EditValue = Nothing
        Me.txtEndDate.EnterMoveNextControl = True
        Me.txtEndDate.Location = New System.Drawing.Point(184, 8)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEndDate.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txtEndDate.Properties.Appearance.Options.UseBackColor = True
        Me.txtEndDate.Properties.Appearance.Options.UseFont = True
        Me.txtEndDate.Properties.Appearance.Options.UseForeColor = True
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.txtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtEndDate.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.txtEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtEndDate.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.txtEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtEndDate.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.txtEndDate.Properties.NullText = "End Date"
        Me.txtEndDate.Size = New System.Drawing.Size(175, 22)
        Me.txtEndDate.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Last Week"
        Me.BarButtonItem5.Id = 32
        Me.BarButtonItem5.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'btnNewReminder
        '
        Me.btnNewReminder.Caption = "New Reminder"
        Me.btnNewReminder.Id = 8
        Me.btnNewReminder.ImageOptions.Image = CType(resources.GetObject("btnNewReminder.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNewReminder.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewReminder.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewReminder.Name = "btnNewReminder"
        '
        'btnNewAssignment
        '
        Me.btnNewAssignment.Caption = "New Assignment"
        Me.btnNewAssignment.Id = 9
        Me.btnNewAssignment.ImageOptions.Image = CType(resources.GetObject("btnNewAssignment.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNewAssignment.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewAssignment.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewAssignment.Name = "btnNewAssignment"
        '
        'btnApprove
        '
        Me.btnApprove.Caption = "Approve Purchase Request"
        Me.btnApprove.Id = 11
        Me.btnApprove.ImageOptions.Image = Global.ERP.My.Resources.Resources.AdminAccept24x24
        Me.btnApprove.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnApprove.ItemAppearance.Normal.Options.UseFont = True
        Me.btnApprove.Name = "btnApprove"
        '
        'btnViewVoucher
        '
        Me.btnViewVoucher.Caption = "View Voucher"
        Me.btnViewVoucher.Id = 12
        Me.btnViewVoucher.ImageOptions.Image = CType(resources.GetObject("btnViewVoucher.ImageOptions.Image"), System.Drawing.Image)
        Me.btnViewVoucher.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnViewVoucher.ItemAppearance.Normal.Options.UseFont = True
        Me.btnViewVoucher.Name = "btnViewVoucher"
        '
        'btnAddNewPR
        '
        Me.btnAddNewPR.Caption = "Add New PR"
        Me.btnAddNewPR.Id = 13
        Me.btnAddNewPR.ImageOptions.Image = Global.ERP.My.Resources.Resources.add
        Me.btnAddNewPR.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewPR.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddNewPR.Name = "btnAddNewPR"
        '
        'btnRptPR
        '
        Me.btnRptPR.Caption = "Preview P.R. Form"
        Me.btnRptPR.Id = 14
        Me.btnRptPR.ImageOptions.Image = CType(resources.GetObject("btnRptPR.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRptPR.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRptPR.ItemAppearance.Normal.Options.UseFont = True
        Me.btnRptPR.Name = "btnRptPR"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 15
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnViewServiceRequest
        '
        Me.btnViewServiceRequest.Caption = "View Service Request"
        Me.btnViewServiceRequest.Id = 16
        Me.btnViewServiceRequest.ImageOptions.Image = CType(resources.GetObject("btnViewServiceRequest.ImageOptions.Image"), System.Drawing.Image)
        Me.btnViewServiceRequest.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnViewServiceRequest.ItemAppearance.Normal.Options.UseFont = True
        Me.btnViewServiceRequest.Name = "btnViewServiceRequest"
        Me.btnViewServiceRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnNewRequest
        '
        Me.btnNewRequest.Caption = "New Request"
        Me.btnNewRequest.Id = 17
        Me.btnNewRequest.ImageOptions.Image = Global.ERP.My.Resources.Resources.add
        Me.btnNewRequest.ImageOptions.LargeImage = Global.ERP.My.Resources.Resources.add
        Me.btnNewRequest.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewRequest.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewRequest.Name = "btnNewRequest"
        '
        'btnVerify
        '
        Me.btnVerify.Caption = "Verify Voucher"
        Me.btnVerify.Id = 18
        Me.btnVerify.ImageOptions.Image = CType(resources.GetObject("btnVerify.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVerify.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnVerify.ItemAppearance.Normal.Options.UseFont = True
        Me.btnVerify.Name = "btnVerify"
        '
        'btnDeleteQuote
        '
        Me.btnDeleteQuote.Caption = "Delete Invoice"
        Me.btnDeleteQuote.Id = 19
        Me.btnDeleteQuote.ImageOptions.Image = CType(resources.GetObject("btnDeleteQuote.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteQuote.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteQuote.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteQuote.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDeleteQuote.ItemAppearance.Normal.Options.UseForeColor = True
        Me.btnDeleteQuote.Name = "btnDeleteQuote"
        '
        'btnShowMyRequests
        '
        Me.btnShowMyRequests.Caption = "Show Requests From Me"
        Me.btnShowMyRequests.Id = 20
        Me.btnShowMyRequests.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowMyRequests.ItemAppearance.Normal.Options.UseFont = True
        Me.btnShowMyRequests.Name = "btnShowMyRequests"
        '
        'btnChooseVoucher
        '
        Me.btnChooseVoucher.Caption = "Choose Voucher"
        Me.btnChooseVoucher.Id = 21
        Me.btnChooseVoucher.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnChooseVoucher.ItemAppearance.Normal.Options.UseFont = True
        Me.btnChooseVoucher.Name = "btnChooseVoucher"
        '
        'btnChooseVouchers
        '
        Me.btnChooseVouchers.Caption = "Choose Voucher"
        Me.btnChooseVouchers.Id = 22
        Me.btnChooseVouchers.ImageOptions.Image = CType(resources.GetObject("btnChooseVouchers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnChooseVouchers.ImageOptions.LargeImage = CType(resources.GetObject("btnChooseVouchers.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnChooseVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnChooseVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnChooseVouchers.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAllVoucherTypes), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPaymentVouchers, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnReceiptVouchers), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSalesVouchers, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPurchasesVouchers), New DevExpress.XtraBars.LinkPersistInfo(Me.btnJournalVouchers, True)})
        Me.btnChooseVouchers.Name = "btnChooseVouchers"
        '
        'btnAllVoucherTypes
        '
        Me.btnAllVoucherTypes.Caption = "All Vouchers"
        Me.btnAllVoucherTypes.Id = 28
        Me.btnAllVoucherTypes.ImageOptions.Image = CType(resources.GetObject("btnAllVoucherTypes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAllVoucherTypes.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAllVoucherTypes.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAllVoucherTypes.Name = "btnAllVoucherTypes"
        '
        'btnPaymentVouchers
        '
        Me.btnPaymentVouchers.Caption = "Payments"
        Me.btnPaymentVouchers.Id = 23
        Me.btnPaymentVouchers.ImageOptions.Image = CType(resources.GetObject("btnPaymentVouchers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPaymentVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPaymentVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPaymentVouchers.Name = "btnPaymentVouchers"
        '
        'btnReceiptVouchers
        '
        Me.btnReceiptVouchers.Caption = "Receipts"
        Me.btnReceiptVouchers.Id = 24
        Me.btnReceiptVouchers.ImageOptions.Image = Global.ERP.My.Resources.Resources.hand_money
        Me.btnReceiptVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnReceiptVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnReceiptVouchers.Name = "btnReceiptVouchers"
        '
        'btnSalesVouchers
        '
        Me.btnSalesVouchers.Caption = "Client Receivables (Invoices)"
        Me.btnSalesVouchers.Id = 25
        Me.btnSalesVouchers.ImageOptions.Image = CType(resources.GetObject("btnSalesVouchers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalesVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalesVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSalesVouchers.Name = "btnSalesVouchers"
        '
        'btnPurchasesVouchers
        '
        Me.btnPurchasesVouchers.Caption = "Supplier Payables"
        Me.btnPurchasesVouchers.Id = 26
        Me.btnPurchasesVouchers.ImageOptions.Image = CType(resources.GetObject("btnPurchasesVouchers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPurchasesVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPurchasesVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPurchasesVouchers.Name = "btnPurchasesVouchers"
        '
        'btnJournalVouchers
        '
        Me.btnJournalVouchers.Caption = "Other Vouchers"
        Me.btnJournalVouchers.Id = 27
        Me.btnJournalVouchers.ImageOptions.Image = CType(resources.GetObject("btnJournalVouchers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnJournalVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnJournalVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnJournalVouchers.Name = "btnJournalVouchers"
        '
        'btnToday
        '
        Me.btnToday.Caption = "Today"
        Me.btnToday.Id = 29
        Me.btnToday.ImageOptions.Image = CType(resources.GetObject("btnToday.ImageOptions.Image"), System.Drawing.Image)
        Me.btnToday.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnToday.ItemAppearance.Normal.Options.UseFont = True
        Me.btnToday.Name = "btnToday"
        '
        'btnYesterday
        '
        Me.btnYesterday.Caption = "Yesterday"
        Me.btnYesterday.Id = 30
        Me.btnYesterday.ImageOptions.Image = CType(resources.GetObject("btnYesterday.ImageOptions.Image"), System.Drawing.Image)
        Me.btnYesterday.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnYesterday.ItemAppearance.Normal.Options.UseFont = True
        Me.btnYesterday.Name = "btnYesterday"
        '
        'btnThisWeek
        '
        Me.btnThisWeek.Caption = "This Week"
        Me.btnThisWeek.Id = 31
        Me.btnThisWeek.ImageOptions.Image = CType(resources.GetObject("btnThisWeek.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThisWeek.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisWeek.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisWeek.Name = "btnThisWeek"
        '
        'btnShowRecords2
        '
        Me.btnShowRecords2.Caption = "Show Records"
        Me.btnShowRecords2.Id = 5
        Me.btnShowRecords2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnShowRecords2.ItemAppearance.Normal.Options.UseFont = True
        Me.btnShowRecords2.Name = "btnShowRecords2"
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PrintableComponentLink1.PaperName = "Invoice Details"
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'btnEditQuote
        '
        Me.btnEditQuote.Caption = "Edit Invoice"
        Me.btnEditQuote.Id = 4
        Me.btnEditQuote.ImageOptions.Image = Global.ERP.My.Resources.Resources.edit24
        Me.btnEditQuote.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditQuote.ItemAppearance.Normal.Options.UseFont = True
        Me.btnEditQuote.Name = "btnEditQuote"
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.btnShowAllRecords)
        Me.PanelControl3.Controls.Add(Me.txtStartDate)
        Me.PanelControl3.Controls.Add(Me.txtEndDate)
        Me.PanelControl3.Location = New System.Drawing.Point(23, 3)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(992, 37)
        Me.PanelControl3.TabIndex = 123
        '
        'btnShowAllRecords
        '
        Me.btnShowAllRecords.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowAllRecords.Appearance.Options.UseFont = True
        Me.btnShowAllRecords.DropDownControl = Me.PopupMenu2
        Me.btnShowAllRecords.ImageOptions.Image = Global.ERP.My.Resources.Resources.books_blue
        Me.btnShowAllRecords.Location = New System.Drawing.Point(374, 3)
        Me.btnShowAllRecords.LookAndFeel.SkinName = "Blue"
        Me.btnShowAllRecords.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnShowAllRecords.Name = "btnShowAllRecords"
        Me.BarManager1.SetPopupContextMenu(Me.btnShowAllRecords, Me.PopupMenu2)
        Me.btnShowAllRecords.Size = New System.Drawing.Size(158, 31)
        Me.btnShowAllRecords.TabIndex = 2
        Me.btnShowAllRecords.Text = "Show Records"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnToday), New DevExpress.XtraBars.LinkPersistInfo(Me.btnYesterday), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisWeek, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisMonthFull, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisMonthTillDate), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisYear, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisYearTillDate), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLastYear, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLastMonth)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "By Quarter"
        Me.BarSubItem4.Id = 52
        Me.BarSubItem4.ImageOptions.Image = CType(resources.GetObject("BarSubItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarSubItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarSubItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnBy1stQuarter), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBy2ndQuarter, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBy3rdQuarter, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBy4thQuarter, True)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'btnBy1stQuarter
        '
        Me.btnBy1stQuarter.Caption = "1st Quarter ( Jan - Mar )"
        Me.btnBy1stQuarter.Id = 53
        Me.btnBy1stQuarter.ImageOptions.Image = CType(resources.GetObject("btnBy1stQuarter.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBy1stQuarter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBy1stQuarter.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBy1stQuarter.Name = "btnBy1stQuarter"
        '
        'btnBy2ndQuarter
        '
        Me.btnBy2ndQuarter.Caption = "2nd Quarter ( Apr - Jun )"
        Me.btnBy2ndQuarter.Id = 54
        Me.btnBy2ndQuarter.ImageOptions.Image = CType(resources.GetObject("btnBy2ndQuarter.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBy2ndQuarter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBy2ndQuarter.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBy2ndQuarter.Name = "btnBy2ndQuarter"
        '
        'btnBy3rdQuarter
        '
        Me.btnBy3rdQuarter.Caption = "3rd Quarter ( Jul - Sep )"
        Me.btnBy3rdQuarter.Id = 55
        Me.btnBy3rdQuarter.ImageOptions.Image = CType(resources.GetObject("btnBy3rdQuarter.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBy3rdQuarter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBy3rdQuarter.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBy3rdQuarter.Name = "btnBy3rdQuarter"
        '
        'btnBy4thQuarter
        '
        Me.btnBy4thQuarter.Caption = "4th Quarter ( Oct - Dec )"
        Me.btnBy4thQuarter.Id = 56
        Me.btnBy4thQuarter.ImageOptions.Image = CType(resources.GetObject("btnBy4thQuarter.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBy4thQuarter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBy4thQuarter.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBy4thQuarter.Name = "btnBy4thQuarter"
        '
        'btnThisMonthFull
        '
        Me.btnThisMonthFull.Caption = "This Month "
        Me.btnThisMonthFull.Id = 34
        Me.btnThisMonthFull.ImageOptions.Image = CType(resources.GetObject("btnThisMonthFull.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThisMonthFull.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisMonthFull.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisMonthFull.Name = "btnThisMonthFull"
        '
        'btnThisMonthTillDate
        '
        Me.btnThisMonthTillDate.Caption = "This Month (till date)"
        Me.btnThisMonthTillDate.Id = 36
        Me.btnThisMonthTillDate.ImageOptions.Image = CType(resources.GetObject("btnThisMonthTillDate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThisMonthTillDate.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisMonthTillDate.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisMonthTillDate.Name = "btnThisMonthTillDate"
        '
        'btnThisYear
        '
        Me.btnThisYear.Caption = "This year"
        Me.btnThisYear.Id = 33
        Me.btnThisYear.ImageOptions.Image = CType(resources.GetObject("btnThisYear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThisYear.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisYear.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisYear.Name = "btnThisYear"
        '
        'btnThisYearTillDate
        '
        Me.btnThisYearTillDate.Caption = "This year (till date)"
        Me.btnThisYearTillDate.Id = 35
        Me.btnThisYearTillDate.ImageOptions.Image = CType(resources.GetObject("btnThisYearTillDate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThisYearTillDate.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisYearTillDate.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisYearTillDate.Name = "btnThisYearTillDate"
        '
        'btnLastYear
        '
        Me.btnLastYear.Caption = "Last Year"
        Me.btnLastYear.Id = 37
        Me.btnLastYear.ImageOptions.Image = CType(resources.GetObject("btnLastYear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLastYear.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnLastYear.ItemAppearance.Normal.Options.UseFont = True
        Me.btnLastYear.Name = "btnLastYear"
        '
        'btnLastMonth
        '
        Me.btnLastMonth.Caption = "Last Month"
        Me.btnLastMonth.Id = 38
        Me.btnLastMonth.ImageOptions.Image = CType(resources.GetObject("btnLastMonth.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLastMonth.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnLastMonth.ItemAppearance.Normal.Options.UseFont = True
        Me.btnLastMonth.Name = "btnLastMonth"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.Controller = Me.BarAndDockingController1
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPrint, Me.btnSearch, Me.btnGroup, Me.btnAddNewAlert, Me.btnEditQuote, Me.btnShowRecords2, Me.btnNewSystemAlert, Me.btnNewAlert, Me.btnNewReminder, Me.btnNewAssignment, Me.btnApprove, Me.btnViewVoucher, Me.btnAddNewPR, Me.btnRptPR, Me.BarButtonItem1, Me.btnViewServiceRequest, Me.btnNewRequest, Me.btnVerify, Me.btnDeleteQuote, Me.btnShowMyRequests, Me.btnChooseVoucher, Me.btnChooseVouchers, Me.btnPaymentVouchers, Me.btnReceiptVouchers, Me.btnSalesVouchers, Me.btnPurchasesVouchers, Me.btnJournalVouchers, Me.btnAllVoucherTypes, Me.btnToday, Me.btnYesterday, Me.btnThisWeek, Me.BarButtonItem5, Me.btnThisYear, Me.btnThisMonthFull, Me.btnThisYearTillDate, Me.btnThisMonthTillDate, Me.btnLastYear, Me.btnLastMonth, Me.BarSubItem1, Me.BarButtonItem2, Me.btnAddNewInvoice, Me.btnPreviewInvoice, Me.btnTaxSummaryReport, Me.btnUnlockInvoice, Me.btnTaxReport, Me.BarSubItem2, Me.BarSubItem3, Me.btnSaveLayout, Me.btnOpenLayout, Me.btnSetDefaultLayout, Me.BarSubItem4, Me.btnBy1stQuarter, Me.btnBy2ndQuarter, Me.btnBy3rdQuarter, Me.btnBy4thQuarter, Me.btnDuplicateInvoice, Me.btnResetLayout})
        Me.BarManager1.MaxItemId = 59
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem3, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPrint, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSearch, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGroup, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Layout Setting"
        Me.BarSubItem3.Id = 48
        Me.BarSubItem3.ImageOptions.Image = CType(resources.GetObject("BarSubItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarSubItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarSubItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.btnOpenLayout, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnResetLayout, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSetDefaultLayout, True)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'btnSaveLayout
        '
        Me.btnSaveLayout.Caption = "Save Layout"
        Me.btnSaveLayout.Id = 49
        Me.btnSaveLayout.ImageOptions.Image = CType(resources.GetObject("btnSaveLayout.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaveLayout.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSaveLayout.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSaveLayout.Name = "btnSaveLayout"
        '
        'btnOpenLayout
        '
        Me.btnOpenLayout.Caption = "Open Layout"
        Me.btnOpenLayout.Id = 50
        Me.btnOpenLayout.ImageOptions.Image = CType(resources.GetObject("btnOpenLayout.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOpenLayout.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOpenLayout.ItemAppearance.Normal.Options.UseFont = True
        Me.btnOpenLayout.Name = "btnOpenLayout"
        '
        'btnResetLayout
        '
        Me.btnResetLayout.Caption = "Reset Layout"
        Me.btnResetLayout.Id = 58
        Me.btnResetLayout.ImageOptions.Image = CType(resources.GetObject("btnResetLayout.ImageOptions.Image"), System.Drawing.Image)
        Me.btnResetLayout.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnResetLayout.ItemAppearance.Normal.Options.UseFont = True
        Me.btnResetLayout.Name = "btnResetLayout"
        '
        'btnSetDefaultLayout
        '
        Me.btnSetDefaultLayout.Caption = "Set as Default Layout"
        Me.btnSetDefaultLayout.Id = 51
        Me.btnSetDefaultLayout.ImageOptions.Image = CType(resources.GetObject("btnSetDefaultLayout.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSetDefaultLayout.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSetDefaultLayout.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSetDefaultLayout.Name = "btnSetDefaultLayout"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Id = 0
        Me.btnPrint.ImageOptions.Image = Global.ERP.My.Resources.Resources.Print
        Me.btnPrint.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPrint.Name = "btnPrint"
        '
        'btnSearch
        '
        Me.btnSearch.Caption = "Search"
        Me.btnSearch.Id = 1
        Me.btnSearch.ImageOptions.Image = Global.ERP.My.Resources.Resources.SearchGrid
        Me.btnSearch.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSearch.Name = "btnSearch"
        '
        'btnGroup
        '
        Me.btnGroup.Caption = "Group"
        Me.btnGroup.Id = 2
        Me.btnGroup.ImageOptions.Image = Global.ERP.My.Resources.Resources.GroupGrid
        Me.btnGroup.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGroup.ItemAppearance.Normal.Options.UseFont = True
        Me.btnGroup.Name = "btnGroup"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.BarAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1017, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 371)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1017, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 371)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1017, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 371)
        '
        'btnAddNewAlert
        '
        Me.btnAddNewAlert.Caption = "Add New Alert"
        Me.btnAddNewAlert.Id = 3
        Me.btnAddNewAlert.ImageOptions.Image = Global.ERP.My.Resources.Resources.add
        Me.btnAddNewAlert.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewAlert.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddNewAlert.Name = "btnAddNewAlert"
        '
        'btnNewSystemAlert
        '
        Me.btnNewSystemAlert.Caption = "New"
        Me.btnNewSystemAlert.Id = 6
        Me.btnNewSystemAlert.ImageOptions.Image = Global.ERP.My.Resources.Resources.add
        Me.btnNewSystemAlert.ImageOptions.LargeImage = Global.ERP.My.Resources.Resources.add
        Me.btnNewSystemAlert.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewSystemAlert.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewSystemAlert.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnNewAlert)})
        Me.btnNewSystemAlert.Name = "btnNewSystemAlert"
        '
        'btnNewAlert
        '
        Me.btnNewAlert.Caption = "New System Alerts"
        Me.btnNewAlert.Id = 7
        Me.btnNewAlert.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewAlert.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewAlert.Name = "btnNewAlert"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Show Records"
        Me.BarSubItem1.Id = 39
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 41
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'btnAddNewInvoice
        '
        Me.btnAddNewInvoice.Caption = "Add New VAT Invoice"
        Me.btnAddNewInvoice.Id = 42
        Me.btnAddNewInvoice.ImageOptions.Image = CType(resources.GetObject("btnAddNewInvoice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddNewInvoice.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewInvoice.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddNewInvoice.Name = "btnAddNewInvoice"
        '
        'btnPreviewInvoice
        '
        Me.btnPreviewInvoice.Caption = "Preview Invoice"
        Me.btnPreviewInvoice.Id = 43
        Me.btnPreviewInvoice.ImageOptions.Image = CType(resources.GetObject("btnPreviewInvoice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPreviewInvoice.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPreviewInvoice.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPreviewInvoice.Name = "btnPreviewInvoice"
        '
        'btnTaxSummaryReport
        '
        Me.btnTaxSummaryReport.Caption = "Tax Summary Report"
        Me.btnTaxSummaryReport.Id = 44
        Me.btnTaxSummaryReport.ImageOptions.Image = CType(resources.GetObject("btnTaxSummaryReport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTaxSummaryReport.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnTaxSummaryReport.ItemAppearance.Normal.Options.UseFont = True
        Me.btnTaxSummaryReport.Name = "btnTaxSummaryReport"
        '
        'btnUnlockInvoice
        '
        Me.btnUnlockInvoice.Caption = "Unlock the Invoice"
        Me.btnUnlockInvoice.Id = 45
        Me.btnUnlockInvoice.ImageOptions.Image = CType(resources.GetObject("btnUnlockInvoice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUnlockInvoice.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnUnlockInvoice.ItemAppearance.Normal.Options.UseFont = True
        Me.btnUnlockInvoice.Name = "btnUnlockInvoice"
        '
        'btnTaxReport
        '
        Me.btnTaxReport.Caption = "Tax Report (Revenue Classified)"
        Me.btnTaxReport.Id = 46
        Me.btnTaxReport.ImageOptions.Image = CType(resources.GetObject("btnTaxReport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTaxReport.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnTaxReport.ItemAppearance.Normal.Options.UseFont = True
        Me.btnTaxReport.Name = "btnTaxReport"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Reports"
        Me.BarSubItem2.Id = 47
        Me.BarSubItem2.ImageOptions.Image = CType(resources.GetObject("BarSubItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarSubItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarSubItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTaxSummaryReport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTaxReport, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'btnDuplicateInvoice
        '
        Me.btnDuplicateInvoice.Caption = "Duplicate Invoice"
        Me.btnDuplicateInvoice.Id = 57
        Me.btnDuplicateInvoice.ImageOptions.Image = CType(resources.GetObject("btnDuplicateInvoice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDuplicateInvoice.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDuplicateInvoice.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDuplicateInvoice.Name = "btnDuplicateInvoice"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'Qry604_10PurchaseItemDetailsTableAdapter
        '
        Me.Qry604_10PurchaseItemDetailsTableAdapter.ClearBeforeFill = True
        '
        'colProjectMasterCode
        '
        Me.colProjectMasterCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colProjectMasterCode.AppearanceHeader.Options.UseFont = True
        Me.colProjectMasterCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colProjectMasterCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProjectMasterCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProjectMasterCode.FieldName = "ProjectMasterCode"
        Me.colProjectMasterCode.Name = "colProjectMasterCode"
        Me.colProjectMasterCode.Visible = True
        '
        'colProjectDescription
        '
        Me.colProjectDescription.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colProjectDescription.AppearanceHeader.Options.UseFont = True
        Me.colProjectDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colProjectDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProjectDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProjectDescription.FieldName = "ProjectDescription"
        Me.colProjectDescription.Name = "colProjectDescription"
        Me.colProjectDescription.Visible = True
        '
        'colProjectLocation
        '
        Me.colProjectLocation.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colProjectLocation.AppearanceHeader.Options.UseFont = True
        Me.colProjectLocation.AppearanceHeader.Options.UseTextOptions = True
        Me.colProjectLocation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProjectLocation.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProjectLocation.FieldName = "ProjectLocation"
        Me.colProjectLocation.Name = "colProjectLocation"
        Me.colProjectLocation.Visible = True
        '
        'frm601_34PurchaseOrderItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 414)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.gcVoucherList)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frm601_34PurchaseOrderItemDetails.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm601_34PurchaseOrderItemDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order with Item Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoQuoteNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQuotationDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcVoucherList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60410PurchaseItemDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_34PurchaseOrderItemDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAdvBandedQuotationView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents repoQuoteNo As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents repoClientName As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colClientCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvQuotationDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceEffectiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceDateAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceDeliveryDateAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountHead As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuotationNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryNoteNos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferenceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOSReferenceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPONo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPODate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPODateAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientReferenceName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarksInEn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarksInAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSubmitted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmittedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmittedByAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmittedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsVerified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVerifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVerifiedByAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVerifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedByAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddedByAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedByAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaxCategoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalcLineAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalcTaxAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomesticStandartRatedRevenue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomesticZeroRatedRevenue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomesticExemptedRevenue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGCCStandardRatedRevenue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGCCZeroRatedRevenue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGCCExpemptedRevenue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExportsRevenue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomesticStandartRatedTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomesticZeroRatedTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomesticExemptedTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGCCStandardRatedTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGCCZeroRatedTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGCCExpemptedTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExportsTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcVoucherList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAdvBandedQuotationView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink3 As DevExpress.XtraPrinting.PrintableComponentLink
    Public WithEvents txtStartDate As DevExpress.XtraEditors.DateEdit
    Public WithEvents txtEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewReminder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewAssignment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnApprove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnViewVoucher As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddNewPR As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptPR As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnViewServiceRequest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewRequest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerify As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnShowMyRequests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnChooseVoucher As DevExpress.XtraBars.BarListItem
    Friend WithEvents btnChooseVouchers As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnAllVoucherTypes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPaymentVouchers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReceiptVouchers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalesVouchers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPurchasesVouchers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnJournalVouchers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnToday As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnYesterday As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisWeek As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnShowRecords2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnEditQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnShowAllRecords As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnBy1stQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy2ndQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy3rdQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy4thQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisMonthFull As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisMonthTillDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisYear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisYearTillDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLastYear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLastMonth As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOpenLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSetDefaultLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSearch As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnAddNewAlert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewSystemAlert As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnNewAlert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddNewInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPreviewInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTaxSummaryReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnlockInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTaxReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnDuplicateInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Qry60410PurchaseItemDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dsfrm601_34PurchaseOrderItemDetails As ERP.dsfrm601_34PurchaseOrderItemDetails
    Friend WithEvents colPONo1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRevisionNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPODate1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierQuoteNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierQuoteDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierRefNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAttention As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierContactNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierContactEmail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSubjectTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPreparedBy As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPreparedOn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colApprovedBy1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colApprovedOn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAddedBy1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAddedOn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colModifiedBy1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colModifiedOn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsApproved1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPOIntroduction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPOSummary As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompanyBranch As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAdditionsText As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiscountsText As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPODueDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPOSignatory As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAdditionsAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDeductionsAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalBeforeTax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalDiscount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalAfterDiscount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalTaxAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalWithTax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGrandTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSDescrpition As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSDescriptionAr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAddlDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuotedQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnitRateMethod As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colItemDiscount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLineTotalAfterDisc As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLineTaxAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLineTotalBeforeTax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnitType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnitDesc As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPOTaxSlab As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPOItemRemarks As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLineOrderNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPurchaseTaxSlab As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPurchaseTaxRate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLineTotalWithTax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierNameAr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierAddress As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMPRNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPOThanksNote As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colHSCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colVerifiedName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colVerifiedPosition As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colVerifiedContactNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colVerifiedEmail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colApprovedName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colApprovedPosition As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colApprovedContact As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colApprovedEmail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Qry604_10PurchaseItemDetailsTableAdapter As ERP.dsfrm601_34PurchaseOrderItemDetailsTableAdapters.qry604_10PurchaseItemDetailsTableAdapter
    Friend WithEvents InvoiceDetails As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandClientDetails As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandStoreDetails As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandProjectDetails As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colOrderedQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colReceivedQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBalanceToReceive As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInventoryMasterGroup As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInventoryMasterGroupID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSalesPersonCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSalesPersonName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSalesPersonUserID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProjectMasterCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProjectDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProjectLocation As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
