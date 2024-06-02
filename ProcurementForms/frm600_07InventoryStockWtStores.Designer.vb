<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm600_07InventoryStockWtStores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm600_07InventoryStockWtStores))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.colReferenceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoQuoteNo = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.repoClientName = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colClientCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcStockList = New DevExpress.XtraGrid.GridControl()
        Me.Qry65315StoreStockBalanceMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm600_07InventoryStoreSummary = New ERP.dsfrm600_07InventoryStoreSummary()
        Me.gvAdvBandedInvoiceView = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.Receipts = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colStoreName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSDescrpition = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStoreCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSDescriptionAr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSGroupName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSGroupNameAr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSDetailedDesc = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSDetailedDescAr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSGroupID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSUoM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGSPackingUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colItemSize = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colItemColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colItemDimension = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colItemPartNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colItemThickness = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colItemBrand = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colItemMake = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStockClassification = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand12 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colTotalOpeningBal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand11 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colTotalReceivedFromSuppliers = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalReceivedFromStores = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalReceipts = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colTotalIssuedToClient = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalConsumed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalStoreTransfered = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalIssues = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colBalanceInStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colAmountOpeningBal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colAmountReceived = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAmountReceivedFromStore = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAmountTotalReceipts = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colAmountIssuedToClient = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAmountConsumed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAmountIssuedToStore = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAmountTotalIssues = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand10 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colTransactionTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsDiscontinued = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIdentification = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colHSCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colExpiryDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBatchNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.repoGSDescription = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
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
        Me.btnYesterday = New DevExpress.XtraBars.BarButtonItem()
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
        Me.btnNewAssignment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisWeek = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewReminder = New DevExpress.XtraBars.BarButtonItem()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
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
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnAddNewAlert = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.btnShowRecords2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewSystemAlert = New DevExpress.XtraBars.BarSubItem()
        Me.btnNewAlert = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisYear = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisMonthFull = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisYearTillDate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisMonthTillDate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLastYear = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLastMonth = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddNewInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPreviewInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTaxSummaryReport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnlockInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTaxReport = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.btnBy1stQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy2ndQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy3rdQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy4thQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDuplicateInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink3 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Qry653_15StoreStockBalanceMasterTableAdapter = New ERP.dsfrm600_07InventoryStoreSummaryTableAdapters.qry653_15StoreStockBalanceMasterTableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoQuoteNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcStockList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry65315StoreStockBalanceMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm600_07InventoryStoreSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAdvBandedInvoiceView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoGSDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQuotationDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.TabIndex = 110
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
        Me.repoClientName.ValueMember = "ClientCode"
        Me.repoClientName.View = Me.RepositoryItemGridLookUpEdit1View
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
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcStockList
        Me.GridView2.Name = "GridView2"
        '
        'gcStockList
        '
        Me.gcStockList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcStockList.DataSource = Me.Qry65315StoreStockBalanceMasterBindingSource
        Me.gcStockList.Location = New System.Drawing.Point(20, 2)
        Me.gcStockList.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcStockList.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcStockList.MainView = Me.gvAdvBandedInvoiceView
        Me.gcStockList.Name = "gcStockList"
        Me.gcStockList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoQuoteNo, Me.repoClientName, Me.repoGSDescription})
        Me.gcStockList.Size = New System.Drawing.Size(992, 367)
        Me.gcStockList.TabIndex = 126
        Me.gcStockList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAdvBandedInvoiceView, Me.gvQuotationDetails, Me.GridView2})
        '
        'Qry65315StoreStockBalanceMasterBindingSource
        '
        Me.Qry65315StoreStockBalanceMasterBindingSource.DataMember = "qry653_15StoreStockBalanceMaster"
        Me.Qry65315StoreStockBalanceMasterBindingSource.DataSource = Me.Dsfrm600_07InventoryStoreSummary
        '
        'Dsfrm600_07InventoryStoreSummary
        '
        Me.Dsfrm600_07InventoryStoreSummary.DataSetName = "dsfrm600_07InventoryStoreSummary"
        Me.Dsfrm600_07InventoryStoreSummary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvAdvBandedInvoiceView
        '
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvAdvBandedInvoiceView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedInvoiceView.Appearance.Empty.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent
        Me.gvAdvBandedInvoiceView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedInvoiceView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvAdvBandedInvoiceView.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedInvoiceView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvAdvBandedInvoiceView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedInvoiceView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvAdvBandedInvoiceView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvAdvBandedInvoiceView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupRow.Options.UseFont = True
        Me.gvAdvBandedInvoiceView.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvAdvBandedInvoiceView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvAdvBandedInvoiceView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedInvoiceView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.OddRow.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.OddRow.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.Preview.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.Preview.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedInvoiceView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvAdvBandedInvoiceView.Appearance.Row.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.Row.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvAdvBandedInvoiceView.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvAdvBandedInvoiceView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvAdvBandedInvoiceView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvAdvBandedInvoiceView.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvAdvBandedInvoiceView.AppearancePrint.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvAdvBandedInvoiceView.AppearancePrint.BandPanel.Options.UseFont = True
        Me.gvAdvBandedInvoiceView.AppearancePrint.BandPanel.Options.UseTextOptions = True
        Me.gvAdvBandedInvoiceView.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvAdvBandedInvoiceView.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvAdvBandedInvoiceView.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvAdvBandedInvoiceView.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.gvAdvBandedInvoiceView.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvAdvBandedInvoiceView.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvAdvBandedInvoiceView.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvAdvBandedInvoiceView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Receipts, Me.gridBand4, Me.gridBand12, Me.gridBand2})
        Me.gvAdvBandedInvoiceView.ColumnPanelRowHeight = 40
        Me.gvAdvBandedInvoiceView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colGSCode, Me.colStoreCode, Me.colStoreName, Me.colGSDescrpition, Me.colTotalOpeningBal, Me.colTotalReceivedFromSuppliers, Me.colTotalReceivedFromStores, Me.colTotalReceipts, Me.colTotalIssuedToClient, Me.colTotalConsumed, Me.colTotalStoreTransfered, Me.colTotalIssues, Me.colBalanceInStock, Me.colGSDescriptionAr, Me.colGSGroupName, Me.colGSGroupNameAr, Me.colGSDetailedDesc, Me.colGSDetailedDescAr, Me.colGSGroupID, Me.colGSUoM, Me.colGSPackingUnit, Me.colItemSize, Me.colItemColor, Me.colItemDimension, Me.colItemPartNo, Me.colItemThickness, Me.colItemBrand, Me.colItemMake, Me.colStockClassification, Me.colTransactionTotal, Me.colAmountOpeningBal, Me.colAmountReceived, Me.colAmountReceivedFromStore, Me.colAmountIssuedToClient, Me.colAmountConsumed, Me.colAmountIssuedToStore, Me.colAmountTotalIssues, Me.colAmountTotalReceipts, Me.colIsDiscontinued, Me.colIdentification, Me.colHSCode, Me.colExpiryDate, Me.colBatchNo})
        Me.gvAdvBandedInvoiceView.CustomizationFormBounds = New System.Drawing.Rectangle(850, 372, 222, 356)
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Name = "formatCompleted"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = True
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.gvAdvBandedInvoiceView.FormatRules.Add(GridFormatRule1)
        Me.gvAdvBandedInvoiceView.GridControl = Me.gcStockList
        Me.gvAdvBandedInvoiceView.GroupCount = 1
        Me.gvAdvBandedInvoiceView.GroupRowHeight = 30
        Me.gvAdvBandedInvoiceView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "GSCode", Nothing, "(#: {0})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalOpeningBal", Me.colTotalOpeningBal, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalReceivedFromSuppliers", Me.colTotalReceivedFromSuppliers, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalReceivedFromStores", Me.colTotalReceivedFromStores, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalReceipts", Me.colTotalReceipts, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalIssuedToClient", Me.colTotalIssuedToClient, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalConsumed", Me.colTotalConsumed, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalStoreTransfered", Me.colTotalStoreTransfered, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalIssues", Me.colTotalIssues, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BalanceInStock", Me.colBalanceInStock, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransactionTotal", Me.colTransactionTotal, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountOpeningBal", Me.colAmountOpeningBal, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountReceived", Me.colAmountReceived, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountReceivedFromStore", Me.colAmountReceivedFromStore, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountTotalReceipts", Me.colAmountTotalReceipts, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountIssuedToClient", Me.colAmountIssuedToClient, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountConsumed", Me.colAmountConsumed, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountIssuedToStore", Me.colAmountIssuedToStore, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountTotalIssues", Me.colAmountTotalIssues, "{0:#,0.##}")})
        Me.gvAdvBandedInvoiceView.Name = "gvAdvBandedInvoiceView"
        Me.gvAdvBandedInvoiceView.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvAdvBandedInvoiceView.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvAdvBandedInvoiceView.OptionsLayout.Columns.StoreAppearance = True
        Me.gvAdvBandedInvoiceView.OptionsLayout.StoreAllOptions = True
        Me.gvAdvBandedInvoiceView.OptionsLayout.StoreAppearance = True
        Me.gvAdvBandedInvoiceView.OptionsLayout.StoreFormatRules = True
        Me.gvAdvBandedInvoiceView.OptionsMenu.ShowConditionalFormattingItem = True
        Me.gvAdvBandedInvoiceView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvAdvBandedInvoiceView.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvAdvBandedInvoiceView.OptionsSelection.MultiSelect = True
        Me.gvAdvBandedInvoiceView.OptionsView.ShowFooter = True
        Me.gvAdvBandedInvoiceView.OptionsView.ShowGroupPanel = False
        Me.gvAdvBandedInvoiceView.OptionsView.ShowIndicator = False
        Me.gvAdvBandedInvoiceView.RowHeight = 45
        Me.gvAdvBandedInvoiceView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGSCode, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'Receipts
        '
        Me.Receipts.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Receipts.AppearanceHeader.Options.UseFont = True
        Me.Receipts.AppearanceHeader.Options.UseTextOptions = True
        Me.Receipts.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Receipts.Caption = "Stock Details"
        Me.Receipts.Columns.Add(Me.colStoreName)
        Me.Receipts.Columns.Add(Me.colGSCode)
        Me.Receipts.Columns.Add(Me.colGSDescrpition)
        Me.Receipts.Columns.Add(Me.colStoreCode)
        Me.Receipts.Columns.Add(Me.colGSDescriptionAr)
        Me.Receipts.Columns.Add(Me.colGSGroupName)
        Me.Receipts.Columns.Add(Me.colGSGroupNameAr)
        Me.Receipts.Columns.Add(Me.colGSDetailedDesc)
        Me.Receipts.Columns.Add(Me.colGSDetailedDescAr)
        Me.Receipts.Columns.Add(Me.colGSGroupID)
        Me.Receipts.Columns.Add(Me.colGSUoM)
        Me.Receipts.Columns.Add(Me.colGSPackingUnit)
        Me.Receipts.Columns.Add(Me.colItemSize)
        Me.Receipts.Columns.Add(Me.colItemColor)
        Me.Receipts.Columns.Add(Me.colItemDimension)
        Me.Receipts.Columns.Add(Me.colItemPartNo)
        Me.Receipts.Columns.Add(Me.colItemThickness)
        Me.Receipts.Columns.Add(Me.colItemBrand)
        Me.Receipts.Columns.Add(Me.colItemMake)
        Me.Receipts.Columns.Add(Me.colStockClassification)
        Me.Receipts.Name = "Receipts"
        Me.Receipts.VisibleIndex = 0
        Me.Receipts.Width = 503
        '
        'colStoreName
        '
        Me.colStoreName.AppearanceCell.Options.UseFont = True
        Me.colStoreName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colStoreName.AppearanceHeader.Options.UseFont = True
        Me.colStoreName.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoreName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoreName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStoreName.FieldName = "StoreName"
        Me.colStoreName.Name = "colStoreName"
        Me.colStoreName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colStoreName.Visible = True
        Me.colStoreName.Width = 169
        '
        'colGSCode
        '
        Me.colGSCode.AppearanceCell.Options.UseFont = True
        Me.colGSCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colGSCode.AppearanceHeader.Options.UseFont = True
        Me.colGSCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSCode.Caption = "Stock Code"
        Me.colGSCode.FieldName = "GSCode"
        Me.colGSCode.Name = "colGSCode"
        Me.colGSCode.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colGSCode.Visible = True
        Me.colGSCode.Width = 106
        '
        'colGSDescrpition
        '
        Me.colGSDescrpition.AppearanceCell.Options.UseFont = True
        Me.colGSDescrpition.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colGSDescrpition.AppearanceHeader.Options.UseFont = True
        Me.colGSDescrpition.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDescrpition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDescrpition.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDescrpition.Caption = "Stock Description"
        Me.colGSDescrpition.FieldName = "GSDescrpition"
        Me.colGSDescrpition.Name = "colGSDescrpition"
        Me.colGSDescrpition.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colGSDescrpition.Visible = True
        Me.colGSDescrpition.Width = 228
        '
        'colStoreCode
        '
        Me.colStoreCode.AppearanceCell.Options.UseFont = True
        Me.colStoreCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoreCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoreCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStoreCode.FieldName = "StoreCode"
        Me.colStoreCode.Name = "colStoreCode"
        Me.colStoreCode.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colStoreCode.Width = 88
        '
        'colGSDescriptionAr
        '
        Me.colGSDescriptionAr.AppearanceCell.Options.UseFont = True
        Me.colGSDescriptionAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDescriptionAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDescriptionAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDescriptionAr.FieldName = "GSDescriptionAr"
        Me.colGSDescriptionAr.Name = "colGSDescriptionAr"
        '
        'colGSGroupName
        '
        Me.colGSGroupName.AppearanceCell.Options.UseFont = True
        Me.colGSGroupName.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSGroupName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSGroupName.FieldName = "GSGroupName"
        Me.colGSGroupName.Name = "colGSGroupName"
        Me.colGSGroupName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colGSGroupName.Width = 154
        '
        'colGSGroupNameAr
        '
        Me.colGSGroupNameAr.AppearanceCell.Options.UseFont = True
        Me.colGSGroupNameAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSGroupNameAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSGroupNameAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSGroupNameAr.FieldName = "GSGroupNameAr"
        Me.colGSGroupNameAr.Name = "colGSGroupNameAr"
        '
        'colGSDetailedDesc
        '
        Me.colGSDetailedDesc.AppearanceCell.Options.UseFont = True
        Me.colGSDetailedDesc.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDetailedDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDetailedDesc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDetailedDesc.FieldName = "GSDetailedDesc"
        Me.colGSDetailedDesc.Name = "colGSDetailedDesc"
        '
        'colGSDetailedDescAr
        '
        Me.colGSDetailedDescAr.AppearanceCell.Options.UseFont = True
        Me.colGSDetailedDescAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDetailedDescAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDetailedDescAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDetailedDescAr.FieldName = "GSDetailedDescAr"
        Me.colGSDetailedDescAr.Name = "colGSDetailedDescAr"
        '
        'colGSGroupID
        '
        Me.colGSGroupID.AppearanceCell.Options.UseFont = True
        Me.colGSGroupID.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSGroupID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSGroupID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSGroupID.FieldName = "GSGroupID"
        Me.colGSGroupID.Name = "colGSGroupID"
        Me.colGSGroupID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colGSUoM
        '
        Me.colGSUoM.AppearanceCell.Options.UseFont = True
        Me.colGSUoM.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSUoM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSUoM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSUoM.FieldName = "GSUoM"
        Me.colGSUoM.Name = "colGSUoM"
        '
        'colGSPackingUnit
        '
        Me.colGSPackingUnit.AppearanceCell.Options.UseFont = True
        Me.colGSPackingUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSPackingUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSPackingUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSPackingUnit.FieldName = "GSPackingUnit"
        Me.colGSPackingUnit.Name = "colGSPackingUnit"
        '
        'colItemSize
        '
        Me.colItemSize.AppearanceCell.Options.UseFont = True
        Me.colItemSize.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemSize.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemSize.FieldName = "ItemSize"
        Me.colItemSize.Name = "colItemSize"
        Me.colItemSize.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colItemColor
        '
        Me.colItemColor.AppearanceCell.Options.UseFont = True
        Me.colItemColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemColor.FieldName = "ItemColor"
        Me.colItemColor.Name = "colItemColor"
        Me.colItemColor.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colItemDimension
        '
        Me.colItemDimension.AppearanceCell.Options.UseFont = True
        Me.colItemDimension.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemDimension.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemDimension.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemDimension.FieldName = "ItemDimension"
        Me.colItemDimension.Name = "colItemDimension"
        Me.colItemDimension.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colItemPartNo
        '
        Me.colItemPartNo.AppearanceCell.Options.UseFont = True
        Me.colItemPartNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemPartNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemPartNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemPartNo.FieldName = "ItemPartNo"
        Me.colItemPartNo.Name = "colItemPartNo"
        Me.colItemPartNo.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colItemThickness
        '
        Me.colItemThickness.AppearanceCell.Options.UseFont = True
        Me.colItemThickness.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemThickness.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemThickness.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemThickness.FieldName = "ItemThickness"
        Me.colItemThickness.Name = "colItemThickness"
        Me.colItemThickness.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colItemBrand
        '
        Me.colItemBrand.AppearanceCell.Options.UseFont = True
        Me.colItemBrand.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemBrand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemBrand.FieldName = "ItemBrand"
        Me.colItemBrand.Name = "colItemBrand"
        Me.colItemBrand.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colItemMake
        '
        Me.colItemMake.AppearanceCell.Options.UseFont = True
        Me.colItemMake.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemMake.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemMake.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemMake.FieldName = "ItemMake"
        Me.colItemMake.Name = "colItemMake"
        Me.colItemMake.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colStockClassification
        '
        Me.colStockClassification.AppearanceCell.Options.UseFont = True
        Me.colStockClassification.AppearanceHeader.Options.UseTextOptions = True
        Me.colStockClassification.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStockClassification.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStockClassification.FieldName = "StockClassification"
        Me.colStockClassification.Name = "colStockClassification"
        Me.colStockClassification.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gridBand4.AppearanceHeader.Options.UseFont = True
        Me.gridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand4.Caption = "Revenue & Tax"
        Me.gridBand4.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand6})
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.Visible = False
        Me.gridBand4.VisibleIndex = -1
        Me.gridBand4.Width = 108
        '
        'gridBand6
        '
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.Visible = False
        Me.gridBand6.VisibleIndex = -1
        Me.gridBand6.Width = 108
        '
        'gridBand12
        '
        Me.gridBand12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gridBand12.AppearanceHeader.Options.UseFont = True
        Me.gridBand12.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand12.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gridBand12.Caption = "Inventory Stock Qty"
        Me.gridBand12.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand11, Me.gridBand3, Me.gridBand5})
        Me.gridBand12.Name = "gridBand12"
        Me.gridBand12.VisibleIndex = 1
        Me.gridBand12.Width = 803
        '
        'gridBand1
        '
        Me.gridBand1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gridBand1.AppearanceHeader.Options.UseFont = True
        Me.gridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand1.Caption = "Opening Balance"
        Me.gridBand1.Columns.Add(Me.colTotalOpeningBal)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.VisibleIndex = 0
        Me.gridBand1.Width = 110
        '
        'colTotalOpeningBal
        '
        Me.colTotalOpeningBal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalOpeningBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalOpeningBal.AppearanceCell.Options.UseBackColor = True
        Me.colTotalOpeningBal.AppearanceCell.Options.UseFont = True
        Me.colTotalOpeningBal.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalOpeningBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalOpeningBal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalOpeningBal.Caption = "Opening Bal. (Qty)"
        Me.colTotalOpeningBal.DisplayFormat.FormatString = "{0:#,0.####}"
        Me.colTotalOpeningBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalOpeningBal.FieldName = "TotalOpeningBal"
        Me.colTotalOpeningBal.Name = "colTotalOpeningBal"
        Me.colTotalOpeningBal.Visible = True
        Me.colTotalOpeningBal.Width = 110
        '
        'gridBand11
        '
        Me.gridBand11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gridBand11.AppearanceHeader.Options.UseFont = True
        Me.gridBand11.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gridBand11.Caption = "Stock Receipts (Qty)"
        Me.gridBand11.Columns.Add(Me.colTotalReceivedFromSuppliers)
        Me.gridBand11.Columns.Add(Me.colTotalReceivedFromStores)
        Me.gridBand11.Columns.Add(Me.colTotalReceipts)
        Me.gridBand11.Name = "gridBand11"
        Me.gridBand11.VisibleIndex = 1
        Me.gridBand11.Width = 280
        '
        'colTotalReceivedFromSuppliers
        '
        Me.colTotalReceivedFromSuppliers.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalReceivedFromSuppliers.AppearanceCell.Options.UseBackColor = True
        Me.colTotalReceivedFromSuppliers.AppearanceCell.Options.UseFont = True
        Me.colTotalReceivedFromSuppliers.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalReceivedFromSuppliers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalReceivedFromSuppliers.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalReceivedFromSuppliers.Caption = "From Suppliers (Qty)"
        Me.colTotalReceivedFromSuppliers.DisplayFormat.FormatString = "{0:#,0.####}"
        Me.colTotalReceivedFromSuppliers.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalReceivedFromSuppliers.FieldName = "TotalReceivedFromSuppliers"
        Me.colTotalReceivedFromSuppliers.Name = "colTotalReceivedFromSuppliers"
        Me.colTotalReceivedFromSuppliers.Visible = True
        Me.colTotalReceivedFromSuppliers.Width = 103
        '
        'colTotalReceivedFromStores
        '
        Me.colTotalReceivedFromStores.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalReceivedFromStores.AppearanceCell.Options.UseBackColor = True
        Me.colTotalReceivedFromStores.AppearanceCell.Options.UseFont = True
        Me.colTotalReceivedFromStores.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalReceivedFromStores.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalReceivedFromStores.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalReceivedFromStores.Caption = "From Store (Qty)"
        Me.colTotalReceivedFromStores.DisplayFormat.FormatString = "{0:#,0.####}"
        Me.colTotalReceivedFromStores.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalReceivedFromStores.FieldName = "TotalReceivedFromStores"
        Me.colTotalReceivedFromStores.Name = "colTotalReceivedFromStores"
        Me.colTotalReceivedFromStores.Visible = True
        Me.colTotalReceivedFromStores.Width = 84
        '
        'colTotalReceipts
        '
        Me.colTotalReceipts.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalReceipts.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalReceipts.AppearanceCell.Options.UseBackColor = True
        Me.colTotalReceipts.AppearanceCell.Options.UseFont = True
        Me.colTotalReceipts.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalReceipts.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalReceipts.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalReceipts.Caption = "Total Receipts (Qty)"
        Me.colTotalReceipts.DisplayFormat.FormatString = "{0:#,0.####}"
        Me.colTotalReceipts.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalReceipts.FieldName = "TotalReceipts"
        Me.colTotalReceipts.Name = "colTotalReceipts"
        Me.colTotalReceipts.Visible = True
        Me.colTotalReceipts.Width = 93
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gridBand3.AppearanceHeader.Options.UseFont = True
        Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand3.Caption = "Stock Issues"
        Me.gridBand3.Columns.Add(Me.colTotalIssuedToClient)
        Me.gridBand3.Columns.Add(Me.colTotalConsumed)
        Me.gridBand3.Columns.Add(Me.colTotalStoreTransfered)
        Me.gridBand3.Columns.Add(Me.colTotalIssues)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 2
        Me.gridBand3.Width = 325
        '
        'colTotalIssuedToClient
        '
        Me.colTotalIssuedToClient.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalIssuedToClient.AppearanceCell.Options.UseBackColor = True
        Me.colTotalIssuedToClient.AppearanceCell.Options.UseFont = True
        Me.colTotalIssuedToClient.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalIssuedToClient.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalIssuedToClient.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalIssuedToClient.Caption = "To Client (Qty)"
        Me.colTotalIssuedToClient.DisplayFormat.FormatString = "{0:#,0.####}"
        Me.colTotalIssuedToClient.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalIssuedToClient.FieldName = "TotalIssuedToClient"
        Me.colTotalIssuedToClient.Name = "colTotalIssuedToClient"
        Me.colTotalIssuedToClient.Visible = True
        Me.colTotalIssuedToClient.Width = 70
        '
        'colTotalConsumed
        '
        Me.colTotalConsumed.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalConsumed.AppearanceCell.Options.UseBackColor = True
        Me.colTotalConsumed.AppearanceCell.Options.UseFont = True
        Me.colTotalConsumed.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalConsumed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalConsumed.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalConsumed.Caption = "Consumed (Qty)"
        Me.colTotalConsumed.DisplayFormat.FormatString = "{0:#,0.####}"
        Me.colTotalConsumed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalConsumed.FieldName = "TotalConsumed"
        Me.colTotalConsumed.Name = "colTotalConsumed"
        Me.colTotalConsumed.Visible = True
        Me.colTotalConsumed.Width = 81
        '
        'colTotalStoreTransfered
        '
        Me.colTotalStoreTransfered.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalStoreTransfered.AppearanceCell.Options.UseBackColor = True
        Me.colTotalStoreTransfered.AppearanceCell.Options.UseFont = True
        Me.colTotalStoreTransfered.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalStoreTransfered.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalStoreTransfered.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalStoreTransfered.Caption = "Transfered (Qty)"
        Me.colTotalStoreTransfered.DisplayFormat.FormatString = "{0:#,0.####}"
        Me.colTotalStoreTransfered.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalStoreTransfered.FieldName = "TotalStoreTransfered"
        Me.colTotalStoreTransfered.Name = "colTotalStoreTransfered"
        Me.colTotalStoreTransfered.Visible = True
        Me.colTotalStoreTransfered.Width = 89
        '
        'colTotalIssues
        '
        Me.colTotalIssues.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalIssues.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalIssues.AppearanceCell.Options.UseBackColor = True
        Me.colTotalIssues.AppearanceCell.Options.UseFont = True
        Me.colTotalIssues.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalIssues.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalIssues.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalIssues.Caption = "Total Issues (Qty)"
        Me.colTotalIssues.DisplayFormat.FormatString = "{0:#,0.####}"
        Me.colTotalIssues.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalIssues.FieldName = "TotalIssues"
        Me.colTotalIssues.Name = "colTotalIssues"
        Me.colTotalIssues.Visible = True
        Me.colTotalIssues.Width = 85
        '
        'gridBand5
        '
        Me.gridBand5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gridBand5.AppearanceHeader.Options.UseFont = True
        Me.gridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand5.Caption = "Closing Balance"
        Me.gridBand5.Columns.Add(Me.colBalanceInStock)
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 3
        Me.gridBand5.Width = 88
        '
        'colBalanceInStock
        '
        Me.colBalanceInStock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colBalanceInStock.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBalanceInStock.AppearanceCell.Options.UseBackColor = True
        Me.colBalanceInStock.AppearanceCell.Options.UseFont = True
        Me.colBalanceInStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalanceInStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalanceInStock.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBalanceInStock.Caption = "Closing Balance (Qty)"
        Me.colBalanceInStock.DisplayFormat.FormatString = "{0:#,0.####}"
        Me.colBalanceInStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalanceInStock.FieldName = "BalanceInStock"
        Me.colBalanceInStock.Name = "colBalanceInStock"
        Me.colBalanceInStock.Visible = True
        Me.colBalanceInStock.Width = 88
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gridBand2.AppearanceHeader.Options.UseFont = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Inventory Stock Values (Amount)"
        Me.gridBand2.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand9, Me.gridBand8, Me.gridBand7, Me.gridBand10})
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 2
        Me.gridBand2.Width = 781
        '
        'gridBand9
        '
        Me.gridBand9.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gridBand9.AppearanceHeader.Options.UseFont = True
        Me.gridBand9.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand9.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand9.Caption = "Opening Bal.(Amt)"
        Me.gridBand9.Columns.Add(Me.colAmountOpeningBal)
        Me.gridBand9.Name = "gridBand9"
        Me.gridBand9.VisibleIndex = 0
        Me.gridBand9.Width = 104
        '
        'colAmountOpeningBal
        '
        Me.colAmountOpeningBal.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colAmountOpeningBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAmountOpeningBal.AppearanceCell.Options.UseBackColor = True
        Me.colAmountOpeningBal.AppearanceCell.Options.UseFont = True
        Me.colAmountOpeningBal.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmountOpeningBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmountOpeningBal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmountOpeningBal.Caption = "Opening Bal. (Amount)"
        Me.colAmountOpeningBal.DisplayFormat.FormatString = "{0:#,0.##}"
        Me.colAmountOpeningBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmountOpeningBal.FieldName = "AmountOpeningBal"
        Me.colAmountOpeningBal.Name = "colAmountOpeningBal"
        Me.colAmountOpeningBal.Visible = True
        Me.colAmountOpeningBal.Width = 104
        '
        'gridBand8
        '
        Me.gridBand8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gridBand8.AppearanceHeader.Options.UseFont = True
        Me.gridBand8.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand8.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand8.Caption = "Stock Receipts (Amount)"
        Me.gridBand8.Columns.Add(Me.colAmountReceived)
        Me.gridBand8.Columns.Add(Me.colAmountReceivedFromStore)
        Me.gridBand8.Columns.Add(Me.colAmountTotalReceipts)
        Me.gridBand8.Name = "gridBand8"
        Me.gridBand8.VisibleIndex = 1
        Me.gridBand8.Width = 277
        '
        'colAmountReceived
        '
        Me.colAmountReceived.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colAmountReceived.AppearanceCell.Options.UseBackColor = True
        Me.colAmountReceived.AppearanceCell.Options.UseFont = True
        Me.colAmountReceived.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmountReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmountReceived.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmountReceived.Caption = "From Suppliers (Amount)"
        Me.colAmountReceived.DisplayFormat.FormatString = "{0:#,0.##}"
        Me.colAmountReceived.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmountReceived.FieldName = "AmountReceived"
        Me.colAmountReceived.Name = "colAmountReceived"
        Me.colAmountReceived.Visible = True
        Me.colAmountReceived.Width = 101
        '
        'colAmountReceivedFromStore
        '
        Me.colAmountReceivedFromStore.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colAmountReceivedFromStore.AppearanceCell.Options.UseBackColor = True
        Me.colAmountReceivedFromStore.AppearanceCell.Options.UseFont = True
        Me.colAmountReceivedFromStore.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmountReceivedFromStore.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmountReceivedFromStore.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmountReceivedFromStore.Caption = "From Store (Amount)"
        Me.colAmountReceivedFromStore.DisplayFormat.FormatString = "{0:#,0.##}"
        Me.colAmountReceivedFromStore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmountReceivedFromStore.FieldName = "AmountReceivedFromStore"
        Me.colAmountReceivedFromStore.Name = "colAmountReceivedFromStore"
        Me.colAmountReceivedFromStore.Visible = True
        Me.colAmountReceivedFromStore.Width = 101
        '
        'colAmountTotalReceipts
        '
        Me.colAmountTotalReceipts.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colAmountTotalReceipts.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAmountTotalReceipts.AppearanceCell.Options.UseBackColor = True
        Me.colAmountTotalReceipts.AppearanceCell.Options.UseFont = True
        Me.colAmountTotalReceipts.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmountTotalReceipts.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmountTotalReceipts.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmountTotalReceipts.Caption = "Total Receipts (Amount)"
        Me.colAmountTotalReceipts.DisplayFormat.FormatString = "{0:#,0.##}"
        Me.colAmountTotalReceipts.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmountTotalReceipts.FieldName = "AmountTotalReceipts"
        Me.colAmountTotalReceipts.Name = "colAmountTotalReceipts"
        Me.colAmountTotalReceipts.Visible = True
        '
        'gridBand7
        '
        Me.gridBand7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gridBand7.AppearanceHeader.Options.UseFont = True
        Me.gridBand7.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand7.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand7.Caption = "Stock Issues (Amount)"
        Me.gridBand7.Columns.Add(Me.colAmountIssuedToClient)
        Me.gridBand7.Columns.Add(Me.colAmountConsumed)
        Me.gridBand7.Columns.Add(Me.colAmountIssuedToStore)
        Me.gridBand7.Columns.Add(Me.colAmountTotalIssues)
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.VisibleIndex = 2
        Me.gridBand7.Width = 318
        '
        'colAmountIssuedToClient
        '
        Me.colAmountIssuedToClient.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colAmountIssuedToClient.AppearanceCell.Options.UseBackColor = True
        Me.colAmountIssuedToClient.AppearanceCell.Options.UseFont = True
        Me.colAmountIssuedToClient.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmountIssuedToClient.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmountIssuedToClient.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmountIssuedToClient.Caption = "To Client (Amount)"
        Me.colAmountIssuedToClient.DisplayFormat.FormatString = "{0:#,0.##}"
        Me.colAmountIssuedToClient.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmountIssuedToClient.FieldName = "AmountIssuedToClient"
        Me.colAmountIssuedToClient.Name = "colAmountIssuedToClient"
        Me.colAmountIssuedToClient.Visible = True
        Me.colAmountIssuedToClient.Width = 81
        '
        'colAmountConsumed
        '
        Me.colAmountConsumed.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colAmountConsumed.AppearanceCell.Options.UseBackColor = True
        Me.colAmountConsumed.AppearanceCell.Options.UseFont = True
        Me.colAmountConsumed.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmountConsumed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmountConsumed.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmountConsumed.Caption = "Consumed (Amount)"
        Me.colAmountConsumed.DisplayFormat.FormatString = "{0:#,0.##}"
        Me.colAmountConsumed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmountConsumed.FieldName = "AmountConsumed"
        Me.colAmountConsumed.Name = "colAmountConsumed"
        Me.colAmountConsumed.Visible = True
        Me.colAmountConsumed.Width = 81
        '
        'colAmountIssuedToStore
        '
        Me.colAmountIssuedToStore.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colAmountIssuedToStore.AppearanceCell.Options.UseBackColor = True
        Me.colAmountIssuedToStore.AppearanceCell.Options.UseFont = True
        Me.colAmountIssuedToStore.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmountIssuedToStore.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmountIssuedToStore.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmountIssuedToStore.Caption = "Transfered (Amount)"
        Me.colAmountIssuedToStore.DisplayFormat.FormatString = "{0:#,0.##}"
        Me.colAmountIssuedToStore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmountIssuedToStore.FieldName = "AmountIssuedToStore"
        Me.colAmountIssuedToStore.Name = "colAmountIssuedToStore"
        Me.colAmountIssuedToStore.Visible = True
        Me.colAmountIssuedToStore.Width = 81
        '
        'colAmountTotalIssues
        '
        Me.colAmountTotalIssues.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colAmountTotalIssues.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAmountTotalIssues.AppearanceCell.Options.UseBackColor = True
        Me.colAmountTotalIssues.AppearanceCell.Options.UseFont = True
        Me.colAmountTotalIssues.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmountTotalIssues.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmountTotalIssues.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmountTotalIssues.Caption = "Total Issues (Amount)"
        Me.colAmountTotalIssues.DisplayFormat.FormatString = "{0:#,0.##}"
        Me.colAmountTotalIssues.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmountTotalIssues.FieldName = "AmountTotalIssues"
        Me.colAmountTotalIssues.Name = "colAmountTotalIssues"
        Me.colAmountTotalIssues.Visible = True
        '
        'gridBand10
        '
        Me.gridBand10.Caption = "Closing Bal.(Amt)"
        Me.gridBand10.Columns.Add(Me.colTransactionTotal)
        Me.gridBand10.Name = "gridBand10"
        Me.gridBand10.VisibleIndex = 3
        Me.gridBand10.Width = 82
        '
        'colTransactionTotal
        '
        Me.colTransactionTotal.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colTransactionTotal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTransactionTotal.AppearanceCell.Options.UseBackColor = True
        Me.colTransactionTotal.AppearanceCell.Options.UseFont = True
        Me.colTransactionTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colTransactionTotal.AppearanceHeader.Options.UseFont = True
        Me.colTransactionTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colTransactionTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTransactionTotal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTransactionTotal.Caption = "Inventory Value (Amount)"
        Me.colTransactionTotal.DisplayFormat.FormatString = "{0:#,0.##}"
        Me.colTransactionTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTransactionTotal.FieldName = "TransactionTotal"
        Me.colTransactionTotal.Name = "colTransactionTotal"
        Me.colTransactionTotal.Visible = True
        Me.colTransactionTotal.Width = 82
        '
        'colIsDiscontinued
        '
        Me.colIsDiscontinued.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsDiscontinued.AppearanceHeader.Options.UseFont = True
        Me.colIsDiscontinued.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsDiscontinued.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsDiscontinued.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsDiscontinued.FieldName = "IsDiscontinued"
        Me.colIsDiscontinued.Name = "colIsDiscontinued"
        Me.colIsDiscontinued.Visible = True
        '
        'colIdentification
        '
        Me.colIdentification.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIdentification.AppearanceHeader.Options.UseFont = True
        Me.colIdentification.AppearanceHeader.Options.UseTextOptions = True
        Me.colIdentification.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIdentification.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIdentification.FieldName = "Identification"
        Me.colIdentification.Name = "colIdentification"
        Me.colIdentification.Visible = True
        '
        'colHSCode
        '
        Me.colHSCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colHSCode.AppearanceHeader.Options.UseFont = True
        Me.colHSCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colHSCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHSCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHSCode.FieldName = "HSCode"
        Me.colHSCode.Name = "colHSCode"
        Me.colHSCode.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colHSCode.Visible = True
        '
        'colExpiryDate
        '
        Me.colExpiryDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExpiryDate.AppearanceHeader.Options.UseFont = True
        Me.colExpiryDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExpiryDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExpiryDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExpiryDate.FieldName = "ExpiryDate"
        Me.colExpiryDate.Name = "colExpiryDate"
        Me.colExpiryDate.Visible = True
        '
        'colBatchNo
        '
        Me.colBatchNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBatchNo.AppearanceHeader.Options.UseFont = True
        Me.colBatchNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colBatchNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBatchNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colBatchNo.Visible = True
        '
        'repoGSDescription
        '
        Me.repoGSDescription.Appearance.Options.UseTextOptions = True
        Me.repoGSDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.repoGSDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.repoGSDescription.LinesCount = 2
        Me.repoGSDescription.Name = "repoGSDescription"
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
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Name = "formatCompleted"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Appearance.Options.UseFont = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = True
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.gvQuotationDetails.FormatRules.Add(GridFormatRule2)
        Me.gvQuotationDetails.GridControl = Me.gcStockList
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
        'btnYesterday
        '
        Me.btnYesterday.Caption = "Yesterday"
        Me.btnYesterday.Glyph = CType(resources.GetObject("btnYesterday.Glyph"), System.Drawing.Image)
        Me.btnYesterday.Id = 30
        Me.btnYesterday.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnYesterday.ItemAppearance.Normal.Options.UseFont = True
        Me.btnYesterday.Name = "btnYesterday"
        '
        'btnApprove
        '
        Me.btnApprove.Caption = "Approve Purchase Request"
        Me.btnApprove.Glyph = Global.ERP.My.Resources.Resources.AdminAccept24x24
        Me.btnApprove.Id = 11
        Me.btnApprove.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnApprove.ItemAppearance.Normal.Options.UseFont = True
        Me.btnApprove.Name = "btnApprove"
        '
        'btnViewVoucher
        '
        Me.btnViewVoucher.Caption = "View Voucher"
        Me.btnViewVoucher.Glyph = CType(resources.GetObject("btnViewVoucher.Glyph"), System.Drawing.Image)
        Me.btnViewVoucher.Id = 12
        Me.btnViewVoucher.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnViewVoucher.ItemAppearance.Normal.Options.UseFont = True
        Me.btnViewVoucher.Name = "btnViewVoucher"
        '
        'btnAddNewPR
        '
        Me.btnAddNewPR.Caption = "Add New PR"
        Me.btnAddNewPR.Glyph = Global.ERP.My.Resources.Resources.add
        Me.btnAddNewPR.Id = 13
        Me.btnAddNewPR.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewPR.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddNewPR.Name = "btnAddNewPR"
        '
        'btnRptPR
        '
        Me.btnRptPR.Caption = "Preview P.R. Form"
        Me.btnRptPR.Glyph = CType(resources.GetObject("btnRptPR.Glyph"), System.Drawing.Image)
        Me.btnRptPR.Id = 14
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
        Me.btnViewServiceRequest.Glyph = CType(resources.GetObject("btnViewServiceRequest.Glyph"), System.Drawing.Image)
        Me.btnViewServiceRequest.Id = 16
        Me.btnViewServiceRequest.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnViewServiceRequest.ItemAppearance.Normal.Options.UseFont = True
        Me.btnViewServiceRequest.Name = "btnViewServiceRequest"
        Me.btnViewServiceRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnNewRequest
        '
        Me.btnNewRequest.Caption = "New Request"
        Me.btnNewRequest.Glyph = Global.ERP.My.Resources.Resources.add
        Me.btnNewRequest.Id = 17
        Me.btnNewRequest.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewRequest.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewRequest.LargeGlyph = Global.ERP.My.Resources.Resources.add
        Me.btnNewRequest.Name = "btnNewRequest"
        '
        'btnVerify
        '
        Me.btnVerify.Caption = "Verify Voucher"
        Me.btnVerify.Glyph = CType(resources.GetObject("btnVerify.Glyph"), System.Drawing.Image)
        Me.btnVerify.Id = 18
        Me.btnVerify.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnVerify.ItemAppearance.Normal.Options.UseFont = True
        Me.btnVerify.Name = "btnVerify"
        '
        'btnDeleteQuote
        '
        Me.btnDeleteQuote.Caption = "Delete Invoice"
        Me.btnDeleteQuote.Glyph = CType(resources.GetObject("btnDeleteQuote.Glyph"), System.Drawing.Image)
        Me.btnDeleteQuote.Id = 19
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
        Me.btnChooseVouchers.Glyph = CType(resources.GetObject("btnChooseVouchers.Glyph"), System.Drawing.Image)
        Me.btnChooseVouchers.Id = 22
        Me.btnChooseVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnChooseVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnChooseVouchers.LargeGlyph = CType(resources.GetObject("btnChooseVouchers.LargeGlyph"), System.Drawing.Image)
        Me.btnChooseVouchers.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAllVoucherTypes), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPaymentVouchers, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnReceiptVouchers), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSalesVouchers, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPurchasesVouchers), New DevExpress.XtraBars.LinkPersistInfo(Me.btnJournalVouchers, True)})
        Me.btnChooseVouchers.Name = "btnChooseVouchers"
        '
        'btnAllVoucherTypes
        '
        Me.btnAllVoucherTypes.Caption = "All Vouchers"
        Me.btnAllVoucherTypes.Glyph = CType(resources.GetObject("btnAllVoucherTypes.Glyph"), System.Drawing.Image)
        Me.btnAllVoucherTypes.Id = 28
        Me.btnAllVoucherTypes.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAllVoucherTypes.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAllVoucherTypes.Name = "btnAllVoucherTypes"
        '
        'btnPaymentVouchers
        '
        Me.btnPaymentVouchers.Caption = "Payments"
        Me.btnPaymentVouchers.Glyph = CType(resources.GetObject("btnPaymentVouchers.Glyph"), System.Drawing.Image)
        Me.btnPaymentVouchers.Id = 23
        Me.btnPaymentVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPaymentVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPaymentVouchers.Name = "btnPaymentVouchers"
        '
        'btnReceiptVouchers
        '
        Me.btnReceiptVouchers.Caption = "Receipts"
        Me.btnReceiptVouchers.Glyph = Global.ERP.My.Resources.Resources.hand_money
        Me.btnReceiptVouchers.Id = 24
        Me.btnReceiptVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnReceiptVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnReceiptVouchers.Name = "btnReceiptVouchers"
        '
        'btnSalesVouchers
        '
        Me.btnSalesVouchers.Caption = "Client Receivables (Invoices)"
        Me.btnSalesVouchers.Glyph = CType(resources.GetObject("btnSalesVouchers.Glyph"), System.Drawing.Image)
        Me.btnSalesVouchers.Id = 25
        Me.btnSalesVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalesVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSalesVouchers.Name = "btnSalesVouchers"
        '
        'btnPurchasesVouchers
        '
        Me.btnPurchasesVouchers.Caption = "Supplier Payables"
        Me.btnPurchasesVouchers.Glyph = CType(resources.GetObject("btnPurchasesVouchers.Glyph"), System.Drawing.Image)
        Me.btnPurchasesVouchers.Id = 26
        Me.btnPurchasesVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPurchasesVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPurchasesVouchers.Name = "btnPurchasesVouchers"
        '
        'btnJournalVouchers
        '
        Me.btnJournalVouchers.Caption = "Other Vouchers"
        Me.btnJournalVouchers.Glyph = CType(resources.GetObject("btnJournalVouchers.Glyph"), System.Drawing.Image)
        Me.btnJournalVouchers.Id = 27
        Me.btnJournalVouchers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnJournalVouchers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnJournalVouchers.Name = "btnJournalVouchers"
        '
        'btnToday
        '
        Me.btnToday.Caption = "Today"
        Me.btnToday.Glyph = CType(resources.GetObject("btnToday.Glyph"), System.Drawing.Image)
        Me.btnToday.Id = 29
        Me.btnToday.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnToday.ItemAppearance.Normal.Options.UseFont = True
        Me.btnToday.Name = "btnToday"
        '
        'btnNewAssignment
        '
        Me.btnNewAssignment.Caption = "New Assignment"
        Me.btnNewAssignment.Glyph = CType(resources.GetObject("btnNewAssignment.Glyph"), System.Drawing.Image)
        Me.btnNewAssignment.Id = 9
        Me.btnNewAssignment.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewAssignment.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewAssignment.Name = "btnNewAssignment"
        '
        'btnThisWeek
        '
        Me.btnThisWeek.Caption = "This Week"
        Me.btnThisWeek.Glyph = CType(resources.GetObject("btnThisWeek.Glyph"), System.Drawing.Image)
        Me.btnThisWeek.Id = 31
        Me.btnThisWeek.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisWeek.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisWeek.Name = "btnThisWeek"
        '
        'btnNewReminder
        '
        Me.btnNewReminder.Caption = "New Reminder"
        Me.btnNewReminder.Glyph = CType(resources.GetObject("btnNewReminder.Glyph"), System.Drawing.Image)
        Me.btnNewReminder.Id = 8
        Me.btnNewReminder.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewReminder.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewReminder.Name = "btnNewReminder"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.BarAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
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
        Me.BarSubItem3.Glyph = CType(resources.GetObject("BarSubItem3.Glyph"), System.Drawing.Image)
        Me.BarSubItem3.Id = 48
        Me.BarSubItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarSubItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.btnOpenLayout, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnResetLayout, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSetDefaultLayout, True)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'btnSaveLayout
        '
        Me.btnSaveLayout.Caption = "Save Layout"
        Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
        Me.btnSaveLayout.Id = 49
        Me.btnSaveLayout.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSaveLayout.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSaveLayout.Name = "btnSaveLayout"
        '
        'btnOpenLayout
        '
        Me.btnOpenLayout.Caption = "Open Layout"
        Me.btnOpenLayout.Glyph = CType(resources.GetObject("btnOpenLayout.Glyph"), System.Drawing.Image)
        Me.btnOpenLayout.Id = 50
        Me.btnOpenLayout.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOpenLayout.ItemAppearance.Normal.Options.UseFont = True
        Me.btnOpenLayout.Name = "btnOpenLayout"
        '
        'btnResetLayout
        '
        Me.btnResetLayout.Caption = "Reset Layout"
        Me.btnResetLayout.Glyph = CType(resources.GetObject("btnResetLayout.Glyph"), System.Drawing.Image)
        Me.btnResetLayout.Id = 58
        Me.btnResetLayout.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnResetLayout.ItemAppearance.Normal.Options.UseFont = True
        Me.btnResetLayout.Name = "btnResetLayout"
        '
        'btnSetDefaultLayout
        '
        Me.btnSetDefaultLayout.Caption = "Set as Default Layout"
        Me.btnSetDefaultLayout.Glyph = CType(resources.GetObject("btnSetDefaultLayout.Glyph"), System.Drawing.Image)
        Me.btnSetDefaultLayout.Id = 51
        Me.btnSetDefaultLayout.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSetDefaultLayout.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSetDefaultLayout.Name = "btnSetDefaultLayout"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Glyph = Global.ERP.My.Resources.Resources.Print
        Me.btnPrint.Id = 0
        Me.btnPrint.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPrint.Name = "btnPrint"
        '
        'btnSearch
        '
        Me.btnSearch.Caption = "Search"
        Me.btnSearch.Glyph = Global.ERP.My.Resources.Resources.SearchGrid
        Me.btnSearch.Id = 1
        Me.btnSearch.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSearch.Name = "btnSearch"
        '
        'btnGroup
        '
        Me.btnGroup.Caption = "Group"
        Me.btnGroup.Glyph = Global.ERP.My.Resources.Resources.GroupGrid
        Me.btnGroup.Id = 2
        Me.btnGroup.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGroup.ItemAppearance.Normal.Options.UseFont = True
        Me.btnGroup.Name = "btnGroup"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1017, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 371)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1017, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 371)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1017, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 371)
        '
        'btnAddNewAlert
        '
        Me.btnAddNewAlert.Caption = "Add New Alert"
        Me.btnAddNewAlert.Glyph = Global.ERP.My.Resources.Resources.add
        Me.btnAddNewAlert.Id = 3
        Me.btnAddNewAlert.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewAlert.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddNewAlert.Name = "btnAddNewAlert"
        '
        'btnEditQuote
        '
        Me.btnEditQuote.Caption = "Edit Invoice"
        Me.btnEditQuote.Glyph = Global.ERP.My.Resources.Resources.edit24
        Me.btnEditQuote.Id = 4
        Me.btnEditQuote.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditQuote.ItemAppearance.Normal.Options.UseFont = True
        Me.btnEditQuote.Name = "btnEditQuote"
        '
        'btnShowRecords2
        '
        Me.btnShowRecords2.Caption = "Show Records"
        Me.btnShowRecords2.Id = 5
        Me.btnShowRecords2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnShowRecords2.ItemAppearance.Normal.Options.UseFont = True
        Me.btnShowRecords2.Name = "btnShowRecords2"
        '
        'btnNewSystemAlert
        '
        Me.btnNewSystemAlert.Caption = "New"
        Me.btnNewSystemAlert.Glyph = Global.ERP.My.Resources.Resources.add
        Me.btnNewSystemAlert.Id = 6
        Me.btnNewSystemAlert.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewSystemAlert.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewSystemAlert.LargeGlyph = Global.ERP.My.Resources.Resources.add
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
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Last Week"
        Me.BarButtonItem5.Glyph = CType(resources.GetObject("BarButtonItem5.Glyph"), System.Drawing.Image)
        Me.BarButtonItem5.Id = 32
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'btnThisYear
        '
        Me.btnThisYear.Caption = "This year"
        Me.btnThisYear.Glyph = CType(resources.GetObject("btnThisYear.Glyph"), System.Drawing.Image)
        Me.btnThisYear.Id = 33
        Me.btnThisYear.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisYear.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisYear.Name = "btnThisYear"
        '
        'btnThisMonthFull
        '
        Me.btnThisMonthFull.Caption = "This Month "
        Me.btnThisMonthFull.Glyph = CType(resources.GetObject("btnThisMonthFull.Glyph"), System.Drawing.Image)
        Me.btnThisMonthFull.Id = 34
        Me.btnThisMonthFull.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisMonthFull.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisMonthFull.Name = "btnThisMonthFull"
        '
        'btnThisYearTillDate
        '
        Me.btnThisYearTillDate.Caption = "This year (till date)"
        Me.btnThisYearTillDate.Glyph = CType(resources.GetObject("btnThisYearTillDate.Glyph"), System.Drawing.Image)
        Me.btnThisYearTillDate.Id = 35
        Me.btnThisYearTillDate.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisYearTillDate.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisYearTillDate.Name = "btnThisYearTillDate"
        '
        'btnThisMonthTillDate
        '
        Me.btnThisMonthTillDate.Caption = "This Month (till date)"
        Me.btnThisMonthTillDate.Glyph = CType(resources.GetObject("btnThisMonthTillDate.Glyph"), System.Drawing.Image)
        Me.btnThisMonthTillDate.Id = 36
        Me.btnThisMonthTillDate.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisMonthTillDate.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisMonthTillDate.Name = "btnThisMonthTillDate"
        '
        'btnLastYear
        '
        Me.btnLastYear.Caption = "Last Year"
        Me.btnLastYear.Glyph = CType(resources.GetObject("btnLastYear.Glyph"), System.Drawing.Image)
        Me.btnLastYear.Id = 37
        Me.btnLastYear.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnLastYear.ItemAppearance.Normal.Options.UseFont = True
        Me.btnLastYear.Name = "btnLastYear"
        '
        'btnLastMonth
        '
        Me.btnLastMonth.Caption = "Last Month"
        Me.btnLastMonth.Glyph = CType(resources.GetObject("btnLastMonth.Glyph"), System.Drawing.Image)
        Me.btnLastMonth.Id = 38
        Me.btnLastMonth.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnLastMonth.ItemAppearance.Normal.Options.UseFont = True
        Me.btnLastMonth.Name = "btnLastMonth"
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
        Me.btnAddNewInvoice.Glyph = CType(resources.GetObject("btnAddNewInvoice.Glyph"), System.Drawing.Image)
        Me.btnAddNewInvoice.Id = 42
        Me.btnAddNewInvoice.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewInvoice.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddNewInvoice.Name = "btnAddNewInvoice"
        '
        'btnPreviewInvoice
        '
        Me.btnPreviewInvoice.Caption = "Preview Invoice"
        Me.btnPreviewInvoice.Glyph = CType(resources.GetObject("btnPreviewInvoice.Glyph"), System.Drawing.Image)
        Me.btnPreviewInvoice.Id = 43
        Me.btnPreviewInvoice.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPreviewInvoice.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPreviewInvoice.Name = "btnPreviewInvoice"
        '
        'btnTaxSummaryReport
        '
        Me.btnTaxSummaryReport.Caption = "Tax Summary Report"
        Me.btnTaxSummaryReport.Glyph = CType(resources.GetObject("btnTaxSummaryReport.Glyph"), System.Drawing.Image)
        Me.btnTaxSummaryReport.Id = 44
        Me.btnTaxSummaryReport.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnTaxSummaryReport.ItemAppearance.Normal.Options.UseFont = True
        Me.btnTaxSummaryReport.Name = "btnTaxSummaryReport"
        '
        'btnUnlockInvoice
        '
        Me.btnUnlockInvoice.Caption = "Unlock the Invoice"
        Me.btnUnlockInvoice.Glyph = CType(resources.GetObject("btnUnlockInvoice.Glyph"), System.Drawing.Image)
        Me.btnUnlockInvoice.Id = 45
        Me.btnUnlockInvoice.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnUnlockInvoice.ItemAppearance.Normal.Options.UseFont = True
        Me.btnUnlockInvoice.Name = "btnUnlockInvoice"
        '
        'btnTaxReport
        '
        Me.btnTaxReport.Caption = "Tax Report (Revenue Classified)"
        Me.btnTaxReport.Glyph = CType(resources.GetObject("btnTaxReport.Glyph"), System.Drawing.Image)
        Me.btnTaxReport.Id = 46
        Me.btnTaxReport.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnTaxReport.ItemAppearance.Normal.Options.UseFont = True
        Me.btnTaxReport.Name = "btnTaxReport"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Reports"
        Me.BarSubItem2.Glyph = CType(resources.GetObject("BarSubItem2.Glyph"), System.Drawing.Image)
        Me.BarSubItem2.Id = 47
        Me.BarSubItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarSubItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTaxSummaryReport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTaxReport, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "By Quarter"
        Me.BarSubItem4.Glyph = CType(resources.GetObject("BarSubItem4.Glyph"), System.Drawing.Image)
        Me.BarSubItem4.Id = 52
        Me.BarSubItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarSubItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnBy1stQuarter), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBy2ndQuarter, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBy3rdQuarter, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBy4thQuarter, True)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'btnBy1stQuarter
        '
        Me.btnBy1stQuarter.Caption = "1st Quarter ( Jan - Mar )"
        Me.btnBy1stQuarter.Glyph = CType(resources.GetObject("btnBy1stQuarter.Glyph"), System.Drawing.Image)
        Me.btnBy1stQuarter.Id = 53
        Me.btnBy1stQuarter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBy1stQuarter.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBy1stQuarter.Name = "btnBy1stQuarter"
        '
        'btnBy2ndQuarter
        '
        Me.btnBy2ndQuarter.Caption = "2nd Quarter ( Apr - Jun )"
        Me.btnBy2ndQuarter.Glyph = CType(resources.GetObject("btnBy2ndQuarter.Glyph"), System.Drawing.Image)
        Me.btnBy2ndQuarter.Id = 54
        Me.btnBy2ndQuarter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBy2ndQuarter.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBy2ndQuarter.Name = "btnBy2ndQuarter"
        '
        'btnBy3rdQuarter
        '
        Me.btnBy3rdQuarter.Caption = "3rd Quarter ( Jul - Sep )"
        Me.btnBy3rdQuarter.Glyph = CType(resources.GetObject("btnBy3rdQuarter.Glyph"), System.Drawing.Image)
        Me.btnBy3rdQuarter.Id = 55
        Me.btnBy3rdQuarter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBy3rdQuarter.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBy3rdQuarter.Name = "btnBy3rdQuarter"
        '
        'btnBy4thQuarter
        '
        Me.btnBy4thQuarter.Caption = "4th Quarter ( Oct - Dec )"
        Me.btnBy4thQuarter.Glyph = CType(resources.GetObject("btnBy4thQuarter.Glyph"), System.Drawing.Image)
        Me.btnBy4thQuarter.Id = 56
        Me.btnBy4thQuarter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBy4thQuarter.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBy4thQuarter.Name = "btnBy4thQuarter"
        '
        'btnDuplicateInvoice
        '
        Me.btnDuplicateInvoice.Caption = "Duplicate Invoice"
        Me.btnDuplicateInvoice.Glyph = CType(resources.GetObject("btnDuplicateInvoice.Glyph"), System.Drawing.Image)
        Me.btnDuplicateInvoice.Id = 57
        Me.btnDuplicateInvoice.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDuplicateInvoice.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDuplicateInvoice.Name = "btnDuplicateInvoice"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnToday), New DevExpress.XtraBars.LinkPersistInfo(Me.btnYesterday), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisWeek, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisMonthFull, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisMonthTillDate), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisYear, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisYearTillDate), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLastYear, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLastMonth)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PrintableComponentLink1.PaperName = "Invoice Details"
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Csv.Separator = ";"
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink3})
        '
        'PrintableComponentLink3
        '
        Me.PrintableComponentLink3.Component = Me.gcStockList
        Me.PrintableComponentLink3.Landscape = True
        Me.PrintableComponentLink3.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PrintableComponentLink3.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink3.PaperName = "Delivery Note Details"
        Me.PrintableComponentLink3.PrintingSystemBase = Me.PrintingSystem1
        '
        'Qry653_15StoreStockBalanceMasterTableAdapter
        '
        Me.Qry653_15StoreStockBalanceMasterTableAdapter.ClearBeforeFill = True
        '
        'frm600_07InventoryStockWtStores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 414)
        Me.Controls.Add(Me.gcStockList)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm600_07InventoryStockWtStores"
        Me.Text = "Store Inventory Summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoQuoteNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcStockList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry65315StoreStockBalanceMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm600_07InventoryStoreSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAdvBandedInvoiceView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoGSDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQuotationDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colReferenceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoQuoteNo As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents repoClientName As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colClientCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcStockList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAdvBandedInvoiceView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents repoGSDescription As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
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
    Friend WithEvents btnYesterday As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents btnNewAssignment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisWeek As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewReminder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOpenLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSetDefaultLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSearch As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnAddNewAlert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnShowRecords2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewSystemAlert As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnNewAlert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisYear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisMonthFull As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisYearTillDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisMonthTillDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLastYear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLastMonth As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddNewInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPreviewInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTaxSummaryReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnlockInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTaxReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnBy1stQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy2ndQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy3rdQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy4thQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDuplicateInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink3 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Dsfrm600_07InventoryStoreSummary As ERP.dsfrm600_07InventoryStoreSummary
    Friend WithEvents Qry65315StoreStockBalanceMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry653_15StoreStockBalanceMasterTableAdapter As ERP.dsfrm600_07InventoryStoreSummaryTableAdapters.qry653_15StoreStockBalanceMasterTableAdapter
    Friend WithEvents colGSCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSDescrpition As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStoreCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStoreName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSDescriptionAr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSGroupName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSGroupNameAr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSDetailedDesc As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSDetailedDescAr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSGroupID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSUoM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSPackingUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colItemSize As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colItemColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colItemDimension As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colItemPartNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colItemThickness As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colItemBrand As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colItemMake As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStockClassification As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalOpeningBal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalReceivedFromSuppliers As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalReceivedFromStores As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalReceipts As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalIssuedToClient As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalConsumed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalStoreTransfered As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalIssues As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBalanceInStock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTransactionTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAmountOpeningBal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAmountReceived As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAmountReceivedFromStore As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAmountIssuedToClient As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAmountConsumed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAmountIssuedToStore As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Receipts As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand12 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand11 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colAmountTotalReceipts As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colAmountTotalIssues As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand10 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents btnResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colIsDiscontinued As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIdentification As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colHSCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExpiryDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
