<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm601_04A_SalesOrderStoreAvailability
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm601_04A_SalesOrderStoreAvailability))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colAvailabilityStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsServicesGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnPrepareDeliveryNote = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStoreCode = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Tbl60001StoreMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_04A_SalesOrderStoreAvailability1 = New ERP.dsfrm601_04A_SalesOrderStoreAvailability()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStoreID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoreName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pvgProfitLoss = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.Qry65320StoreStockAvaliabilityForSalesOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_04A_SalesOrderStoreAvailability = New ERP.dsfrm601_04A_SalesOrderStoreAvailability()
        Me.fieldSalesOrderNo1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderedQty1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGSCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStoreCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnitRateMethod1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCurrentyQty1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGSDescrpition1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGSGroupName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldItemPartNo1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStockClassification1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnitDesc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTotalOrderedQty = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTotalIssdQty = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBalanceToDeliver = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderUnitOfMeasure = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderedQtyInBaseUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnitConverted = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTotalOrderedQtyInBaseUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTotalIssuedInBaseUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBalanceToDeliverInBaseUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCurrentQtyInOrderedUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOpenLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnResetLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSetDefaultLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnShowFields = New DevExpress.XtraBars.BarButtonItem()
        Me.btnShowRowTotals = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBack = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnToday = New DevExpress.XtraBars.BarButtonItem()
        Me.btnYesterday = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.btnBy1stQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy2ndQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy3rdQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy4thQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisWeek = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisMonthFull = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisMonthTillDate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisYear = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisYearTillDate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLastYear = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLastMonth = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnAddNewAlert = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.btnShowRecords2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewSystemAlert = New DevExpress.XtraBars.BarSubItem()
        Me.btnNewAlert = New DevExpress.XtraBars.BarButtonItem()
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Qry653_20StoreStockAvaliabilityForSalesOrderTableAdapter = New ERP.dsfrm601_04A_SalesOrderStoreAvailabilityTableAdapters.qry653_20StoreStockAvaliabilityForSalesOrderTableAdapter()
        Me.Tbl600_01StoreMasterTableAdapter = New ERP.dsfrm601_04A_SalesOrderStoreAvailabilityTableAdapters.tbl600_01StoreMasterTableAdapter()
        Me.gcStockAvailabilityInStore = New DevExpress.XtraGrid.GridControl()
        Me.Qry65320StoreStockAvaliabilityForSalesOrder1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_04A_SalesOrderStoreAvailability2 = New ERP.dsfrm601_04A_SalesOrderStoreAvailability()
        Me.gvStockAvailabilityInStore = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSalesOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderedQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoreCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitRateMethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrentyQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDescrpition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSGroupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockClassification = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalOrderedQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalIssdQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalanceToDeliver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesOrderChildID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveringQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCurrentQtyInOrderedUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderUnitOfMeasure = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderedQtyInBaseUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalIssuedInBaseUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalOrderedQtyInBaseUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitConverted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalanceToDeliverInBaseUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoVoucherNoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.Qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter = New ERP.dsfrm601_04A_SalesOrderStoreAvailabilityTableAdapters.qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStoreCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl60001StoreMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_04A_SalesOrderStoreAvailability1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pvgProfitLoss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry65320StoreStockAvaliabilityForSalesOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_04A_SalesOrderStoreAvailability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gcStockAvailabilityInStore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry65320StoreStockAvaliabilityForSalesOrder1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_04A_SalesOrderStoreAvailability2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStockAvailabilityInStore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoVoucherNoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQuotationDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.Panel1.SuspendLayout()
        CType(Me.SplitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.Panel2.SuspendLayout()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'colAvailabilityStatus
        '
        Me.colAvailabilityStatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAvailabilityStatus.AppearanceHeader.Options.UseFont = True
        Me.colAvailabilityStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colAvailabilityStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAvailabilityStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAvailabilityStatus.FieldName = "AvailabilityStatus"
        Me.colAvailabilityStatus.Name = "colAvailabilityStatus"
        Me.colAvailabilityStatus.OptionsColumn.AllowEdit = False
        Me.colAvailabilityStatus.Visible = True
        Me.colAvailabilityStatus.VisibleIndex = 10
        Me.colAvailabilityStatus.Width = 134
        '
        'colIsServicesGroup
        '
        Me.colIsServicesGroup.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsServicesGroup.AppearanceHeader.Options.UseFont = True
        Me.colIsServicesGroup.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsServicesGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsServicesGroup.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsServicesGroup.Caption = "Service"
        Me.colIsServicesGroup.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colIsServicesGroup.FieldName = "IsServicesGroup"
        Me.colIsServicesGroup.Name = "colIsServicesGroup"
        Me.colIsServicesGroup.Visible = True
        Me.colIsServicesGroup.VisibleIndex = 1
        Me.colIsServicesGroup.Width = 68
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.PanelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(19, 376)
        Me.PanelControl2.TabIndex = 177
        '
        'btnPrepareDeliveryNote
        '
        Me.btnPrepareDeliveryNote.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrepareDeliveryNote.Appearance.Options.UseFont = True
        Me.btnPrepareDeliveryNote.ImageOptions.Image = CType(resources.GetObject("btnPrepareDeliveryNote.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrepareDeliveryNote.Location = New System.Drawing.Point(415, 9)
        Me.btnPrepareDeliveryNote.Name = "btnPrepareDeliveryNote"
        Me.btnPrepareDeliveryNote.Size = New System.Drawing.Size(210, 38)
        Me.btnPrepareDeliveryNote.TabIndex = 203
        Me.btnPrepareDeliveryNote.Text = "Prepare Delivery Note"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(10, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(158, 14)
        Me.LabelControl1.TabIndex = 201
        Me.LabelControl1.Text = "Select the Store to Issue Items:"
        '
        'txtStoreCode
        '
        Me.txtStoreCode.EnterMoveNextControl = True
        Me.txtStoreCode.Location = New System.Drawing.Point(7, 25)
        Me.txtStoreCode.Name = "txtStoreCode"
        Me.txtStoreCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtStoreCode.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtStoreCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtStoreCode.Properties.Appearance.Options.UseFont = True
        Me.txtStoreCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStoreCode.Properties.DataSource = Me.Tbl60001StoreMasterBindingSource
        Me.txtStoreCode.Properties.DisplayMember = "StoreName"
        Me.txtStoreCode.Properties.NullText = ""
        Me.txtStoreCode.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.txtStoreCode.Properties.PopupView = Me.GridView7
        Me.txtStoreCode.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSuggest
        Me.txtStoreCode.Properties.ValueMember = "StoreID"
        Me.txtStoreCode.Size = New System.Drawing.Size(384, 22)
        Me.txtStoreCode.TabIndex = 202
        '
        'Tbl60001StoreMasterBindingSource
        '
        Me.Tbl60001StoreMasterBindingSource.DataMember = "tbl600_01StoreMaster"
        Me.Tbl60001StoreMasterBindingSource.DataSource = Me.Dsfrm601_04A_SalesOrderStoreAvailability1
        '
        'Dsfrm601_04A_SalesOrderStoreAvailability1
        '
        Me.Dsfrm601_04A_SalesOrderStoreAvailability1.DataSetName = "dsfrm601_04A_SalesOrderStoreAvailability"
        Me.Dsfrm601_04A_SalesOrderStoreAvailability1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView7
        '
        Me.GridView7.ColumnPanelRowHeight = 30
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStoreID, Me.colStoreName})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.RowHeight = 30
        '
        'colStoreID
        '
        Me.colStoreID.FieldName = "StoreID"
        Me.colStoreID.Name = "colStoreID"
        Me.colStoreID.Visible = True
        Me.colStoreID.VisibleIndex = 0
        Me.colStoreID.Width = 329
        '
        'colStoreName
        '
        Me.colStoreName.FieldName = "StoreName"
        Me.colStoreName.Name = "colStoreName"
        Me.colStoreName.Visible = True
        Me.colStoreName.VisibleIndex = 1
        Me.colStoreName.Width = 717
        '
        'pvgProfitLoss
        '
        Me.pvgProfitLoss.Appearance.Cell.BackColor = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.Cell.BackColor2 = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.Cell.BorderColor = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.Cell.Options.UseBackColor = True
        Me.pvgProfitLoss.Appearance.Cell.Options.UseBorderColor = True
        Me.pvgProfitLoss.Appearance.ColumnHeaderArea.BackColor = System.Drawing.Color.Transparent
        Me.pvgProfitLoss.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.pvgProfitLoss.Appearance.ColumnHeaderArea.Options.UseBackColor = True
        Me.pvgProfitLoss.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.pvgProfitLoss.Appearance.FieldHeader.BackColor = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.FieldHeader.BorderColor = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.FieldHeader.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.pvgProfitLoss.Appearance.FieldHeader.Options.UseBackColor = True
        Me.pvgProfitLoss.Appearance.FieldHeader.Options.UseBorderColor = True
        Me.pvgProfitLoss.Appearance.FieldHeader.Options.UseFont = True
        Me.pvgProfitLoss.Appearance.FieldValue.BackColor = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.FieldValue.BackColor2 = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.FieldValue.BorderColor = System.Drawing.Color.Transparent
        Me.pvgProfitLoss.Appearance.FieldValue.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.pvgProfitLoss.Appearance.FieldValue.ForeColor = System.Drawing.Color.DimGray
        Me.pvgProfitLoss.Appearance.FieldValue.Options.UseBackColor = True
        Me.pvgProfitLoss.Appearance.FieldValue.Options.UseBorderColor = True
        Me.pvgProfitLoss.Appearance.FieldValue.Options.UseFont = True
        Me.pvgProfitLoss.Appearance.FieldValue.Options.UseForeColor = True
        Me.pvgProfitLoss.Appearance.FieldValueTotal.BackColor = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.FieldValueTotal.BackColor2 = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.FieldValueTotal.ForeColor = System.Drawing.Color.Gray
        Me.pvgProfitLoss.Appearance.FieldValueTotal.Options.UseBackColor = True
        Me.pvgProfitLoss.Appearance.FieldValueTotal.Options.UseForeColor = True
        Me.pvgProfitLoss.Appearance.HeaderArea.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pvgProfitLoss.Appearance.HeaderArea.Options.UseBackColor = True
        Me.pvgProfitLoss.Appearance.HeaderGroupLine.ForeColor = System.Drawing.Color.DarkGray
        Me.pvgProfitLoss.Appearance.HeaderGroupLine.Options.UseForeColor = True
        Me.pvgProfitLoss.Appearance.Lines.BackColor = System.Drawing.Color.Gray
        Me.pvgProfitLoss.Appearance.Lines.Options.UseBackColor = True
        Me.pvgProfitLoss.Appearance.RowHeaderArea.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.pvgProfitLoss.Appearance.RowHeaderArea.Options.UseFont = True
        Me.pvgProfitLoss.Appearance.TotalCell.BackColor = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.TotalCell.BackColor2 = System.Drawing.Color.White
        Me.pvgProfitLoss.Appearance.TotalCell.BorderColor = System.Drawing.Color.Silver
        Me.pvgProfitLoss.Appearance.TotalCell.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold)
        Me.pvgProfitLoss.Appearance.TotalCell.Options.UseBackColor = True
        Me.pvgProfitLoss.Appearance.TotalCell.Options.UseBorderColor = True
        Me.pvgProfitLoss.Appearance.TotalCell.Options.UseFont = True
        Me.pvgProfitLoss.Cursor = System.Windows.Forms.Cursors.Default
        Me.pvgProfitLoss.DataSource = Me.Qry65320StoreStockAvaliabilityForSalesOrderBindingSource
        Me.pvgProfitLoss.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pvgProfitLoss.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldSalesOrderNo1, Me.fieldOrderedQty1, Me.fieldGSCode1, Me.fieldStoreCode1, Me.fieldUnitRateMethod1, Me.fieldCurrentyQty1, Me.fieldGSDescrpition1, Me.fieldGSGroupName1, Me.fieldItemPartNo1, Me.fieldStockClassification1, Me.fieldUnitDesc1, Me.fieldTotalOrderedQty, Me.fieldTotalIssdQty, Me.fieldBalanceToDeliver, Me.fieldOrderUnitOfMeasure, Me.fieldOrderedQtyInBaseUnit, Me.fieldUnitConverted, Me.fieldTotalOrderedQtyInBaseUnit, Me.fieldTotalIssuedInBaseUnit, Me.fieldBalanceToDeliverInBaseUnit, Me.fieldCurrentQtyInOrderedUnit})
        Me.pvgProfitLoss.Location = New System.Drawing.Point(0, 0)
        Me.pvgProfitLoss.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.pvgProfitLoss.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pvgProfitLoss.Name = "pvgProfitLoss"
        Me.pvgProfitLoss.OptionsChartDataSource.SelectionOnly = False
        Me.pvgProfitLoss.OptionsDataField.ColumnValueLineCount = 2
        Me.pvgProfitLoss.OptionsDataField.RowHeaderWidth = 86
        Me.pvgProfitLoss.OptionsDataField.RowValueLineCount = 2
        Me.pvgProfitLoss.OptionsLayout.Columns.StoreAllOptions = True
        Me.pvgProfitLoss.OptionsLayout.Columns.StoreAppearance = True
        Me.pvgProfitLoss.OptionsLayout.StoreAllOptions = True
        Me.pvgProfitLoss.OptionsLayout.StoreAppearance = True
        Me.pvgProfitLoss.OptionsLayout.StoreFormatRules = True
        Me.pvgProfitLoss.OptionsLayout.StoreLayoutOptions = True
        Me.pvgProfitLoss.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.pvgProfitLoss.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.pvgProfitLoss.OptionsView.RowTreeOffset = 18
        Me.pvgProfitLoss.OptionsView.RowTreeWidth = 86
        Me.pvgProfitLoss.OptionsView.ShowDataHeaders = False
        Me.pvgProfitLoss.OptionsView.ShowFilterHeaders = False
        Me.pvgProfitLoss.Size = New System.Drawing.Size(952, 129)
        Me.pvgProfitLoss.TabIndex = 204
        '
        'Qry65320StoreStockAvaliabilityForSalesOrderBindingSource
        '
        Me.Qry65320StoreStockAvaliabilityForSalesOrderBindingSource.DataMember = "qry653_20StoreStockAvaliabilityForSalesOrder"
        Me.Qry65320StoreStockAvaliabilityForSalesOrderBindingSource.DataSource = Me.Dsfrm601_04A_SalesOrderStoreAvailability
        '
        'Dsfrm601_04A_SalesOrderStoreAvailability
        '
        Me.Dsfrm601_04A_SalesOrderStoreAvailability.DataSetName = "dsfrm601_04A_SalesOrderStoreAvailability"
        Me.Dsfrm601_04A_SalesOrderStoreAvailability.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldSalesOrderNo1
        '
        Me.fieldSalesOrderNo1.AreaIndex = 0
        Me.fieldSalesOrderNo1.Caption = "Sales Order No"
        Me.fieldSalesOrderNo1.FieldName = "SalesOrderNo"
        Me.fieldSalesOrderNo1.Name = "fieldSalesOrderNo1"
        Me.fieldSalesOrderNo1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldSalesOrderNo1.Width = 125
        '
        'fieldOrderedQty1
        '
        Me.fieldOrderedQty1.AreaIndex = 6
        Me.fieldOrderedQty1.Caption = "Ordered Qty"
        Me.fieldOrderedQty1.CellFormat.FormatString = "###,###,##0.00##"
        Me.fieldOrderedQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldOrderedQty1.FieldName = "OrderedQty"
        Me.fieldOrderedQty1.GrandTotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldOrderedQty1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldOrderedQty1.Name = "fieldOrderedQty1"
        Me.fieldOrderedQty1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldOrderedQty1.TotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldOrderedQty1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldOrderedQty1.TotalValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldOrderedQty1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldOrderedQty1.ValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldOrderedQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldGSCode1
        '
        Me.fieldGSCode1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldGSCode1.AreaIndex = 0
        Me.fieldGSCode1.Caption = "GS Code"
        Me.fieldGSCode1.FieldName = "GSCode"
        Me.fieldGSCode1.Name = "fieldGSCode1"
        Me.fieldGSCode1.Width = 125
        '
        'fieldStoreCode1
        '
        Me.fieldStoreCode1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldStoreCode1.AreaIndex = 0
        Me.fieldStoreCode1.Caption = "Store Code"
        Me.fieldStoreCode1.FieldName = "StoreCode"
        Me.fieldStoreCode1.Name = "fieldStoreCode1"
        Me.fieldStoreCode1.Width = 85
        '
        'fieldUnitRateMethod1
        '
        Me.fieldUnitRateMethod1.AreaIndex = 1
        Me.fieldUnitRateMethod1.Caption = "Unit Rate Method"
        Me.fieldUnitRateMethod1.FieldName = "UnitRateMethod"
        Me.fieldUnitRateMethod1.Name = "fieldUnitRateMethod1"
        '
        'fieldCurrentyQty1
        '
        Me.fieldCurrentyQty1.AreaIndex = 12
        Me.fieldCurrentyQty1.Caption = "Current Qty"
        Me.fieldCurrentyQty1.CellFormat.FormatString = "###,###,##0.00##"
        Me.fieldCurrentyQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCurrentyQty1.ColumnValueLineCount = 2
        Me.fieldCurrentyQty1.FieldName = "CurrentyQty"
        Me.fieldCurrentyQty1.GrandTotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldCurrentyQty1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCurrentyQty1.Name = "fieldCurrentyQty1"
        Me.fieldCurrentyQty1.RowValueLineCount = 2
        Me.fieldCurrentyQty1.TotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldCurrentyQty1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCurrentyQty1.TotalValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldCurrentyQty1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldGSDescrpition1
        '
        Me.fieldGSDescrpition1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldGSDescrpition1.AreaIndex = 1
        Me.fieldGSDescrpition1.Caption = "GS Descrpition"
        Me.fieldGSDescrpition1.FieldName = "GSDescrpition"
        Me.fieldGSDescrpition1.Name = "fieldGSDescrpition1"
        Me.fieldGSDescrpition1.Width = 200
        '
        'fieldGSGroupName1
        '
        Me.fieldGSGroupName1.AreaIndex = 2
        Me.fieldGSGroupName1.Caption = "GS Group Name"
        Me.fieldGSGroupName1.FieldName = "GSGroupName"
        Me.fieldGSGroupName1.Name = "fieldGSGroupName1"
        '
        'fieldItemPartNo1
        '
        Me.fieldItemPartNo1.AreaIndex = 3
        Me.fieldItemPartNo1.Caption = "Item Part No"
        Me.fieldItemPartNo1.FieldName = "ItemPartNo"
        Me.fieldItemPartNo1.Name = "fieldItemPartNo1"
        '
        'fieldStockClassification1
        '
        Me.fieldStockClassification1.AreaIndex = 4
        Me.fieldStockClassification1.Caption = "Stock Classification"
        Me.fieldStockClassification1.FieldName = "StockClassification"
        Me.fieldStockClassification1.Name = "fieldStockClassification1"
        '
        'fieldUnitDesc1
        '
        Me.fieldUnitDesc1.AreaIndex = 5
        Me.fieldUnitDesc1.Caption = "Unit Desc"
        Me.fieldUnitDesc1.FieldName = "UnitDesc"
        Me.fieldUnitDesc1.Name = "fieldUnitDesc1"
        '
        'fieldTotalOrderedQty
        '
        Me.fieldTotalOrderedQty.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTotalOrderedQty.AreaIndex = 3
        Me.fieldTotalOrderedQty.Caption = "Ordered Qty"
        Me.fieldTotalOrderedQty.CellFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalOrderedQty.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalOrderedQty.FieldName = "TotalOrderedQty"
        Me.fieldTotalOrderedQty.GrandTotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalOrderedQty.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalOrderedQty.Name = "fieldTotalOrderedQty"
        Me.fieldTotalOrderedQty.TotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalOrderedQty.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalOrderedQty.TotalValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalOrderedQty.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalOrderedQty.ValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalOrderedQty.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldTotalIssdQty
        '
        Me.fieldTotalIssdQty.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTotalIssdQty.AreaIndex = 4
        Me.fieldTotalIssdQty.Caption = "Issd Qty"
        Me.fieldTotalIssdQty.CellFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalIssdQty.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalIssdQty.FieldName = "TotalIssdQty"
        Me.fieldTotalIssdQty.GrandTotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalIssdQty.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalIssdQty.Name = "fieldTotalIssdQty"
        Me.fieldTotalIssdQty.TotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalIssdQty.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalIssdQty.TotalValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalIssdQty.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalIssdQty.ValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldTotalIssdQty.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldBalanceToDeliver
        '
        Me.fieldBalanceToDeliver.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBalanceToDeliver.AreaIndex = 5
        Me.fieldBalanceToDeliver.Caption = "Balance"
        Me.fieldBalanceToDeliver.CellFormat.FormatString = "###,###,##0.00##"
        Me.fieldBalanceToDeliver.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBalanceToDeliver.FieldName = "BalanceToDeliver"
        Me.fieldBalanceToDeliver.GrandTotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldBalanceToDeliver.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBalanceToDeliver.Name = "fieldBalanceToDeliver"
        Me.fieldBalanceToDeliver.TotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldBalanceToDeliver.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBalanceToDeliver.TotalValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldBalanceToDeliver.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBalanceToDeliver.ValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldBalanceToDeliver.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldOrderUnitOfMeasure
        '
        Me.fieldOrderUnitOfMeasure.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldOrderUnitOfMeasure.AreaIndex = 2
        Me.fieldOrderUnitOfMeasure.Caption = "Ordered UOM"
        Me.fieldOrderUnitOfMeasure.FieldName = "OrderUnitOfMeasure"
        Me.fieldOrderUnitOfMeasure.Name = "fieldOrderUnitOfMeasure"
        Me.fieldOrderUnitOfMeasure.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldOrderUnitOfMeasure.Width = 110
        '
        'fieldOrderedQtyInBaseUnit
        '
        Me.fieldOrderedQtyInBaseUnit.AreaIndex = 7
        Me.fieldOrderedQtyInBaseUnit.FieldName = "OrderedQtyInBaseUnit"
        Me.fieldOrderedQtyInBaseUnit.Name = "fieldOrderedQtyInBaseUnit"
        '
        'fieldUnitConverted
        '
        Me.fieldUnitConverted.AreaIndex = 8
        Me.fieldUnitConverted.FieldName = "UnitConverted"
        Me.fieldUnitConverted.Name = "fieldUnitConverted"
        Me.fieldUnitConverted.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldTotalOrderedQtyInBaseUnit
        '
        Me.fieldTotalOrderedQtyInBaseUnit.AreaIndex = 9
        Me.fieldTotalOrderedQtyInBaseUnit.FieldName = "TotalOrderedQtyInBaseUnit"
        Me.fieldTotalOrderedQtyInBaseUnit.Name = "fieldTotalOrderedQtyInBaseUnit"
        Me.fieldTotalOrderedQtyInBaseUnit.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldTotalIssuedInBaseUnit
        '
        Me.fieldTotalIssuedInBaseUnit.AreaIndex = 10
        Me.fieldTotalIssuedInBaseUnit.FieldName = "TotalIssuedInBaseUnit"
        Me.fieldTotalIssuedInBaseUnit.Name = "fieldTotalIssuedInBaseUnit"
        Me.fieldTotalIssuedInBaseUnit.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldBalanceToDeliverInBaseUnit
        '
        Me.fieldBalanceToDeliverInBaseUnit.AreaIndex = 11
        Me.fieldBalanceToDeliverInBaseUnit.FieldName = "BalanceToDeliverInBaseUnit"
        Me.fieldBalanceToDeliverInBaseUnit.Name = "fieldBalanceToDeliverInBaseUnit"
        Me.fieldBalanceToDeliverInBaseUnit.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldCurrentQtyInOrderedUnit
        '
        Me.fieldCurrentQtyInOrderedUnit.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCurrentQtyInOrderedUnit.AreaIndex = 0
        Me.fieldCurrentQtyInOrderedUnit.CellFormat.FormatString = "###,###,##0.00##"
        Me.fieldCurrentQtyInOrderedUnit.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCurrentQtyInOrderedUnit.ColumnValueLineCount = 2
        Me.fieldCurrentQtyInOrderedUnit.FieldName = "CurrentQtyInOrderedUnit"
        Me.fieldCurrentQtyInOrderedUnit.GrandTotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldCurrentQtyInOrderedUnit.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCurrentQtyInOrderedUnit.Name = "fieldCurrentQtyInOrderedUnit"
        Me.fieldCurrentQtyInOrderedUnit.RowValueLineCount = 2
        Me.fieldCurrentQtyInOrderedUnit.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldCurrentQtyInOrderedUnit.TotalCellFormat.FormatString = "###,###,##0.00##"
        Me.fieldCurrentQtyInOrderedUnit.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCurrentQtyInOrderedUnit.TotalValueFormat.FormatString = "###,###,##0.00##"
        Me.fieldCurrentQtyInOrderedUnit.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem3, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPrint, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnShowFields, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnShowRowTotals, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnBack, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        Me.btnResetLayout.Id = 59
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
        Me.btnPrint.ImageOptions.SvgImage = CType(resources.GetObject("btnPrint.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnPrint.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
        Me.btnPrint.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPrint.Name = "btnPrint"
        '
        'btnShowFields
        '
        Me.btnShowFields.Caption = "Show Fields"
        Me.btnShowFields.Id = 2
        Me.btnShowFields.ImageOptions.SvgImage = CType(resources.GetObject("btnShowFields.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnShowFields.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
        Me.btnShowFields.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnShowFields.ItemAppearance.Normal.Options.UseFont = True
        Me.btnShowFields.Name = "btnShowFields"
        '
        'btnShowRowTotals
        '
        Me.btnShowRowTotals.Caption = "Show Row Totals"
        Me.btnShowRowTotals.Id = 58
        Me.btnShowRowTotals.ImageOptions.Image = CType(resources.GetObject("btnShowRowTotals.ImageOptions.Image"), System.Drawing.Image)
        Me.btnShowRowTotals.ImageOptions.SvgImage = CType(resources.GetObject("btnShowRowTotals.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnShowRowTotals.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
        Me.btnShowRowTotals.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowRowTotals.ItemAppearance.Normal.Options.UseFont = True
        Me.btnShowRowTotals.Name = "btnShowRowTotals"
        '
        'btnBack
        '
        Me.btnBack.Caption = "Back"
        Me.btnBack.Id = 60
        Me.btnBack.ImageOptions.SvgImage = CType(resources.GetObject("btnBack.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnBack.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
        Me.btnBack.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBack.Name = "btnBack"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Csv.Separator = ";"
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.pvgProfitLoss
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnToday), New DevExpress.XtraBars.LinkPersistInfo(Me.btnYesterday), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisWeek, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisMonthFull, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisMonthTillDate), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisYear, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisYearTillDate), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLastYear, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLastMonth)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
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
        'btnThisWeek
        '
        Me.btnThisWeek.Caption = "This Week"
        Me.btnThisWeek.Id = 31
        Me.btnThisWeek.ImageOptions.Image = CType(resources.GetObject("btnThisWeek.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThisWeek.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisWeek.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisWeek.Name = "btnThisWeek"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPrint, Me.btnShowFields, Me.btnAddNewAlert, Me.btnEditQuote, Me.btnShowRecords2, Me.btnNewSystemAlert, Me.btnNewAlert, Me.btnNewReminder, Me.btnNewAssignment, Me.btnApprove, Me.btnViewVoucher, Me.btnAddNewPR, Me.btnRptPR, Me.BarButtonItem1, Me.btnViewServiceRequest, Me.btnNewRequest, Me.btnVerify, Me.btnDeleteQuote, Me.btnShowMyRequests, Me.btnChooseVoucher, Me.btnChooseVouchers, Me.btnPaymentVouchers, Me.btnReceiptVouchers, Me.btnSalesVouchers, Me.btnPurchasesVouchers, Me.btnJournalVouchers, Me.btnAllVoucherTypes, Me.btnToday, Me.btnYesterday, Me.btnThisWeek, Me.BarButtonItem5, Me.btnThisYear, Me.btnThisMonthFull, Me.btnThisYearTillDate, Me.btnThisMonthTillDate, Me.btnLastYear, Me.btnLastMonth, Me.BarSubItem1, Me.BarButtonItem2, Me.btnAddNewInvoice, Me.btnPreviewInvoice, Me.btnTaxSummaryReport, Me.btnUnlockInvoice, Me.btnTaxReport, Me.BarSubItem2, Me.BarSubItem3, Me.btnSaveLayout, Me.btnOpenLayout, Me.btnSetDefaultLayout, Me.BarSubItem4, Me.btnBy1stQuarter, Me.btnBy2ndQuarter, Me.btnBy3rdQuarter, Me.btnBy4thQuarter, Me.btnDuplicateInvoice, Me.btnShowRowTotals, Me.btnResetLayout, Me.btnBack})
        Me.BarManager1.MaxItemId = 61
        Me.BarManager1.StatusBar = Me.Bar3
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
        Me.barDockControlTop.Size = New System.Drawing.Size(974, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 376)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(974, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 376)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(974, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 376)
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
        'btnEditQuote
        '
        Me.btnEditQuote.Caption = "Edit Invoice"
        Me.btnEditQuote.Id = 4
        Me.btnEditQuote.ImageOptions.Image = Global.ERP.My.Resources.Resources.edit24
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
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.txtStoreCode)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.btnPrepareDeliveryNote)
        Me.PanelControl3.Location = New System.Drawing.Point(19, 0)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(953, 57)
        Me.PanelControl3.TabIndex = 209
        '
        'Qry653_20StoreStockAvaliabilityForSalesOrderTableAdapter
        '
        Me.Qry653_20StoreStockAvaliabilityForSalesOrderTableAdapter.ClearBeforeFill = True
        '
        'Tbl600_01StoreMasterTableAdapter
        '
        Me.Tbl600_01StoreMasterTableAdapter.ClearBeforeFill = True
        '
        'gcStockAvailabilityInStore
        '
        Me.gcStockAvailabilityInStore.DataSource = Me.Qry65320StoreStockAvaliabilityForSalesOrder1BindingSource
        Me.gcStockAvailabilityInStore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcStockAvailabilityInStore.Location = New System.Drawing.Point(0, 0)
        Me.gcStockAvailabilityInStore.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcStockAvailabilityInStore.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcStockAvailabilityInStore.MainView = Me.gvStockAvailabilityInStore
        Me.gcStockAvailabilityInStore.Name = "gcStockAvailabilityInStore"
        Me.gcStockAvailabilityInStore.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoVoucherNoEdit, Me.RepositoryItemSpinEdit1, Me.RepositoryItemSpinEdit2, Me.RepositoryItemCheckEdit1})
        Me.gcStockAvailabilityInStore.Size = New System.Drawing.Size(952, 184)
        Me.gcStockAvailabilityInStore.TabIndex = 214
        Me.gcStockAvailabilityInStore.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockAvailabilityInStore, Me.gvQuotationDetails, Me.GridView2})
        '
        'Qry65320StoreStockAvaliabilityForSalesOrder1BindingSource
        '
        Me.Qry65320StoreStockAvaliabilityForSalesOrder1BindingSource.DataMember = "qry653_20StoreStockAvaliabilityForSalesOrder1"
        Me.Qry65320StoreStockAvaliabilityForSalesOrder1BindingSource.DataSource = Me.Dsfrm601_04A_SalesOrderStoreAvailability2
        '
        'Dsfrm601_04A_SalesOrderStoreAvailability2
        '
        Me.Dsfrm601_04A_SalesOrderStoreAvailability2.DataSetName = "dsfrm601_04A_SalesOrderStoreAvailability"
        Me.Dsfrm601_04A_SalesOrderStoreAvailability2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvStockAvailabilityInStore
        '
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvStockAvailabilityInStore.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvStockAvailabilityInStore.Appearance.Empty.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent
        Me.gvStockAvailabilityInStore.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvStockAvailabilityInStore.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvStockAvailabilityInStore.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvStockAvailabilityInStore.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvStockAvailabilityInStore.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvStockAvailabilityInStore.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvStockAvailabilityInStore.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvStockAvailabilityInStore.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvStockAvailabilityInStore.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvStockAvailabilityInStore.Appearance.GroupRow.Options.UseFont = True
        Me.gvStockAvailabilityInStore.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvStockAvailabilityInStore.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvStockAvailabilityInStore.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvStockAvailabilityInStore.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.OddRow.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.OddRow.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.Preview.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.Preview.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvStockAvailabilityInStore.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvStockAvailabilityInStore.Appearance.Row.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.Row.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvStockAvailabilityInStore.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvStockAvailabilityInStore.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvStockAvailabilityInStore.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvStockAvailabilityInStore.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvStockAvailabilityInStore.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvStockAvailabilityInStore.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.gvStockAvailabilityInStore.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvStockAvailabilityInStore.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvStockAvailabilityInStore.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvStockAvailabilityInStore.ColumnPanelRowHeight = 40
        Me.gvStockAvailabilityInStore.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSalesOrderNo, Me.colOrderedQty, Me.colGSCode, Me.colStoreCode, Me.colUnitRateMethod, Me.colCurrentyQty, Me.colGSDescrpition, Me.colGSGroupName, Me.colItemPartNo, Me.colStockClassification, Me.colUnitDesc, Me.colTotalOrderedQty, Me.colTotalIssdQty, Me.colBalanceToDeliver, Me.colAvailabilityStatus, Me.colSalesOrderChildID, Me.colDeliveringQuantity, Me.colIsServicesGroup, Me.colCurrentQtyInOrderedUnit, Me.colOrderUnitOfMeasure, Me.colOrderedQtyInBaseUnit, Me.colTotalIssuedInBaseUnit, Me.colTotalOrderedQtyInBaseUnit, Me.colUnitConverted, Me.colBalanceToDeliverInBaseUnit})
        GridFormatRule1.Column = Me.colAvailabilityStatus
        GridFormatRule1.ColumnApplyTo = Me.colAvailabilityStatus
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "[AvailabilityStatus] = 'No Stock Available'"
        FormatConditionRuleValue1.Value1 = "No Stock Available"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colIsServicesGroup
        GridFormatRule2.ColumnApplyTo = Me.colIsServicesGroup
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = True
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.gvStockAvailabilityInStore.FormatRules.Add(GridFormatRule1)
        Me.gvStockAvailabilityInStore.FormatRules.Add(GridFormatRule2)
        Me.gvStockAvailabilityInStore.GridControl = Me.gcStockAvailabilityInStore
        Me.gvStockAvailabilityInStore.GroupRowHeight = 30
        Me.gvStockAvailabilityInStore.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CostAllocationUnit", Nothing, "{0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountAllocated", Nothing, "{0:n2}")})
        Me.gvStockAvailabilityInStore.Name = "gvStockAvailabilityInStore"
        Me.gvStockAvailabilityInStore.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvStockAvailabilityInStore.OptionsMenu.ShowConditionalFormattingItem = True
        Me.gvStockAvailabilityInStore.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvStockAvailabilityInStore.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvStockAvailabilityInStore.OptionsSelection.MultiSelect = True
        Me.gvStockAvailabilityInStore.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvStockAvailabilityInStore.OptionsView.ShowFooter = True
        Me.gvStockAvailabilityInStore.OptionsView.ShowGroupPanel = False
        Me.gvStockAvailabilityInStore.OptionsView.ShowIndicator = False
        Me.gvStockAvailabilityInStore.RowHeight = 30
        '
        'colSalesOrderNo
        '
        Me.colSalesOrderNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSalesOrderNo.AppearanceHeader.Options.UseFont = True
        Me.colSalesOrderNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSalesOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSalesOrderNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSalesOrderNo.FieldName = "SalesOrderNo"
        Me.colSalesOrderNo.Name = "colSalesOrderNo"
        '
        'colOrderedQty
        '
        Me.colOrderedQty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrderedQty.AppearanceHeader.Options.UseFont = True
        Me.colOrderedQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderedQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderedQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderedQty.FieldName = "OrderedQty"
        Me.colOrderedQty.Name = "colOrderedQty"
        '
        'colGSCode
        '
        Me.colGSCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSCode.AppearanceHeader.Options.UseFont = True
        Me.colGSCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSCode.FieldName = "GSCode"
        Me.colGSCode.Name = "colGSCode"
        Me.colGSCode.OptionsColumn.AllowEdit = False
        Me.colGSCode.Visible = True
        Me.colGSCode.VisibleIndex = 3
        Me.colGSCode.Width = 68
        '
        'colStoreCode
        '
        Me.colStoreCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStoreCode.AppearanceHeader.Options.UseFont = True
        Me.colStoreCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoreCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoreCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStoreCode.FieldName = "StoreCode"
        Me.colStoreCode.Name = "colStoreCode"
        '
        'colUnitRateMethod
        '
        Me.colUnitRateMethod.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitRateMethod.AppearanceHeader.Options.UseFont = True
        Me.colUnitRateMethod.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitRateMethod.FieldName = "UnitRateMethod"
        Me.colUnitRateMethod.Name = "colUnitRateMethod"
        '
        'colCurrentyQty
        '
        Me.colCurrentyQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCurrentyQty.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCurrentyQty.AppearanceCell.Options.UseBackColor = True
        Me.colCurrentyQty.AppearanceCell.Options.UseFont = True
        Me.colCurrentyQty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCurrentyQty.AppearanceHeader.Options.UseFont = True
        Me.colCurrentyQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrentyQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrentyQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrentyQty.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colCurrentyQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCurrentyQty.FieldName = "CurrentyQty"
        Me.colCurrentyQty.Name = "colCurrentyQty"
        Me.colCurrentyQty.OptionsColumn.AllowEdit = False
        Me.colCurrentyQty.Width = 57
        '
        'colGSDescrpition
        '
        Me.colGSDescrpition.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSDescrpition.AppearanceHeader.Options.UseFont = True
        Me.colGSDescrpition.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDescrpition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDescrpition.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDescrpition.Caption = "Stock Description"
        Me.colGSDescrpition.FieldName = "GSDescrpition"
        Me.colGSDescrpition.Name = "colGSDescrpition"
        Me.colGSDescrpition.OptionsColumn.AllowEdit = False
        Me.colGSDescrpition.Visible = True
        Me.colGSDescrpition.VisibleIndex = 4
        Me.colGSDescrpition.Width = 127
        '
        'colGSGroupName
        '
        Me.colGSGroupName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSGroupName.AppearanceHeader.Options.UseFont = True
        Me.colGSGroupName.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSGroupName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSGroupName.FieldName = "GSGroupName"
        Me.colGSGroupName.Name = "colGSGroupName"
        '
        'colItemPartNo
        '
        Me.colItemPartNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colItemPartNo.AppearanceHeader.Options.UseFont = True
        Me.colItemPartNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemPartNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemPartNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemPartNo.FieldName = "ItemPartNo"
        Me.colItemPartNo.Name = "colItemPartNo"
        '
        'colStockClassification
        '
        Me.colStockClassification.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStockClassification.AppearanceHeader.Options.UseFont = True
        Me.colStockClassification.AppearanceHeader.Options.UseTextOptions = True
        Me.colStockClassification.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStockClassification.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStockClassification.FieldName = "StockClassification"
        Me.colStockClassification.Name = "colStockClassification"
        '
        'colUnitDesc
        '
        Me.colUnitDesc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitDesc.AppearanceHeader.Options.UseFont = True
        Me.colUnitDesc.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitDesc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitDesc.Caption = "Unit"
        Me.colUnitDesc.FieldName = "UnitDesc"
        Me.colUnitDesc.Name = "colUnitDesc"
        Me.colUnitDesc.OptionsColumn.AllowEdit = False
        Me.colUnitDesc.Visible = True
        Me.colUnitDesc.VisibleIndex = 5
        Me.colUnitDesc.Width = 55
        '
        'colTotalOrderedQty
        '
        Me.colTotalOrderedQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalOrderedQty.AppearanceCell.Options.UseBackColor = True
        Me.colTotalOrderedQty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalOrderedQty.AppearanceHeader.Options.UseFont = True
        Me.colTotalOrderedQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalOrderedQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalOrderedQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalOrderedQty.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colTotalOrderedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalOrderedQty.FieldName = "TotalOrderedQty"
        Me.colTotalOrderedQty.Name = "colTotalOrderedQty"
        Me.colTotalOrderedQty.OptionsColumn.AllowEdit = False
        Me.colTotalOrderedQty.Visible = True
        Me.colTotalOrderedQty.VisibleIndex = 6
        Me.colTotalOrderedQty.Width = 78
        '
        'colTotalIssdQty
        '
        Me.colTotalIssdQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTotalIssdQty.AppearanceCell.Options.UseBackColor = True
        Me.colTotalIssdQty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalIssdQty.AppearanceHeader.Options.UseFont = True
        Me.colTotalIssdQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalIssdQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalIssdQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalIssdQty.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colTotalIssdQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalIssdQty.FieldName = "TotalIssdQty"
        Me.colTotalIssdQty.Name = "colTotalIssdQty"
        Me.colTotalIssdQty.OptionsColumn.AllowEdit = False
        Me.colTotalIssdQty.Visible = True
        Me.colTotalIssdQty.VisibleIndex = 7
        Me.colTotalIssdQty.Width = 60
        '
        'colBalanceToDeliver
        '
        Me.colBalanceToDeliver.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colBalanceToDeliver.AppearanceCell.Options.UseBackColor = True
        Me.colBalanceToDeliver.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBalanceToDeliver.AppearanceHeader.Options.UseFont = True
        Me.colBalanceToDeliver.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalanceToDeliver.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalanceToDeliver.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBalanceToDeliver.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colBalanceToDeliver.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalanceToDeliver.FieldName = "BalanceToDeliver"
        Me.colBalanceToDeliver.Name = "colBalanceToDeliver"
        Me.colBalanceToDeliver.OptionsColumn.AllowEdit = False
        Me.colBalanceToDeliver.Visible = True
        Me.colBalanceToDeliver.VisibleIndex = 8
        Me.colBalanceToDeliver.Width = 62
        '
        'colSalesOrderChildID
        '
        Me.colSalesOrderChildID.AppearanceCell.Options.UseTextOptions = True
        Me.colSalesOrderChildID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSalesOrderChildID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSalesOrderChildID.AppearanceHeader.Options.UseFont = True
        Me.colSalesOrderChildID.AppearanceHeader.Options.UseTextOptions = True
        Me.colSalesOrderChildID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSalesOrderChildID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSalesOrderChildID.Caption = "Order ID"
        Me.colSalesOrderChildID.FieldName = "SalesOrderChildID"
        Me.colSalesOrderChildID.Name = "colSalesOrderChildID"
        Me.colSalesOrderChildID.OptionsColumn.AllowEdit = False
        Me.colSalesOrderChildID.OptionsColumn.AllowFocus = False
        Me.colSalesOrderChildID.Visible = True
        Me.colSalesOrderChildID.VisibleIndex = 2
        Me.colSalesOrderChildID.Width = 47
        '
        'colDeliveringQuantity
        '
        Me.colDeliveringQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDeliveringQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colDeliveringQuantity.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDeliveringQuantity.AppearanceHeader.Options.UseFont = True
        Me.colDeliveringQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveringQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveringQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveringQuantity.ColumnEdit = Me.RepositoryItemSpinEdit2
        Me.colDeliveringQuantity.FieldName = "DeliveringQuantity"
        Me.colDeliveringQuantity.MinWidth = 75
        Me.colDeliveringQuantity.Name = "colDeliveringQuantity"
        Me.colDeliveringQuantity.Visible = True
        Me.colDeliveringQuantity.VisibleIndex = 11
        Me.colDeliveringQuantity.Width = 88
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.RepositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit2.EditFormat.FormatString = "###,###,##0.00##"
        Me.RepositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'colCurrentQtyInOrderedUnit
        '
        Me.colCurrentQtyInOrderedUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCurrentQtyInOrderedUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCurrentQtyInOrderedUnit.AppearanceCell.Options.UseBackColor = True
        Me.colCurrentQtyInOrderedUnit.AppearanceCell.Options.UseFont = True
        Me.colCurrentQtyInOrderedUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCurrentQtyInOrderedUnit.AppearanceHeader.Options.UseFont = True
        Me.colCurrentQtyInOrderedUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrentQtyInOrderedUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrentQtyInOrderedUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrentQtyInOrderedUnit.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colCurrentQtyInOrderedUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCurrentQtyInOrderedUnit.FieldName = "CurrentQtyInOrderedUnit"
        Me.colCurrentQtyInOrderedUnit.Name = "colCurrentQtyInOrderedUnit"
        Me.colCurrentQtyInOrderedUnit.Visible = True
        Me.colCurrentQtyInOrderedUnit.VisibleIndex = 9
        Me.colCurrentQtyInOrderedUnit.Width = 88
        '
        'colOrderUnitOfMeasure
        '
        Me.colOrderUnitOfMeasure.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrderUnitOfMeasure.AppearanceHeader.Options.UseFont = True
        Me.colOrderUnitOfMeasure.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderUnitOfMeasure.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderUnitOfMeasure.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderUnitOfMeasure.FieldName = "OrderUnitOfMeasure"
        Me.colOrderUnitOfMeasure.Name = "colOrderUnitOfMeasure"
        '
        'colOrderedQtyInBaseUnit
        '
        Me.colOrderedQtyInBaseUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrderedQtyInBaseUnit.AppearanceHeader.Options.UseFont = True
        Me.colOrderedQtyInBaseUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderedQtyInBaseUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderedQtyInBaseUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderedQtyInBaseUnit.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colOrderedQtyInBaseUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOrderedQtyInBaseUnit.FieldName = "OrderedQtyInBaseUnit"
        Me.colOrderedQtyInBaseUnit.Name = "colOrderedQtyInBaseUnit"
        '
        'colTotalIssuedInBaseUnit
        '
        Me.colTotalIssuedInBaseUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalIssuedInBaseUnit.AppearanceHeader.Options.UseFont = True
        Me.colTotalIssuedInBaseUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalIssuedInBaseUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalIssuedInBaseUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalIssuedInBaseUnit.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colTotalIssuedInBaseUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalIssuedInBaseUnit.FieldName = "TotalIssuedInBaseUnit"
        Me.colTotalIssuedInBaseUnit.Name = "colTotalIssuedInBaseUnit"
        '
        'colTotalOrderedQtyInBaseUnit
        '
        Me.colTotalOrderedQtyInBaseUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalOrderedQtyInBaseUnit.AppearanceHeader.Options.UseFont = True
        Me.colTotalOrderedQtyInBaseUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalOrderedQtyInBaseUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalOrderedQtyInBaseUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalOrderedQtyInBaseUnit.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colTotalOrderedQtyInBaseUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalOrderedQtyInBaseUnit.FieldName = "TotalOrderedQtyInBaseUnit"
        Me.colTotalOrderedQtyInBaseUnit.Name = "colTotalOrderedQtyInBaseUnit"
        '
        'colUnitConverted
        '
        Me.colUnitConverted.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitConverted.AppearanceHeader.Options.UseFont = True
        Me.colUnitConverted.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitConverted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitConverted.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitConverted.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colUnitConverted.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitConverted.FieldName = "UnitConverted"
        Me.colUnitConverted.Name = "colUnitConverted"
        '
        'colBalanceToDeliverInBaseUnit
        '
        Me.colBalanceToDeliverInBaseUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBalanceToDeliverInBaseUnit.AppearanceHeader.Options.UseFont = True
        Me.colBalanceToDeliverInBaseUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalanceToDeliverInBaseUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalanceToDeliverInBaseUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBalanceToDeliverInBaseUnit.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.colBalanceToDeliverInBaseUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalanceToDeliverInBaseUnit.FieldName = "BalanceToDeliverInBaseUnit"
        Me.colBalanceToDeliverInBaseUnit.Name = "colBalanceToDeliverInBaseUnit"
        '
        'repoVoucherNoEdit
        '
        Me.repoVoucherNoEdit.AutoHeight = False
        Me.repoVoucherNoEdit.Name = "repoVoucherNoEdit"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "###,###,##0.00##"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "###,###,##0.00##"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.MaskSettings.Set("mask", "")
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
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
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Name = "formatCompleted"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Appearance.Options.UseFont = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue3.Value1 = True
        GridFormatRule3.Rule = FormatConditionRuleValue3
        Me.gvQuotationDetails.FormatRules.Add(GridFormatRule3)
        Me.gvQuotationDetails.GridControl = Me.gcStockAvailabilityInStore
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
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcStockAvailabilityInStore
        Me.GridView2.Name = "GridView2"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(20, 58)
        Me.SplitContainerControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SplitContainerControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        '
        'SplitContainerControl1.Panel1
        '
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcStockAvailabilityInStore)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        '
        'SplitContainerControl1.Panel2
        '
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pvgProfitLoss)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(952, 319)
        Me.SplitContainerControl1.SplitterPosition = 184
        Me.SplitContainerControl1.TabIndex = 215
        '
        'Qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter
        '
        Me.Qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter.ClearBeforeFill = True
        '
        'frm601_04A_SalesOrderStoreAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 419)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.SvgImage = CType(resources.GetObject("frm601_04A_SalesOrderStoreAvailability.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.LookAndFeel.SkinName = "The Bezier"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm601_04A_SalesOrderStoreAvailability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Store Stock Availability in Stores:"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStoreCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl60001StoreMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_04A_SalesOrderStoreAvailability1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pvgProfitLoss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry65320StoreStockAvaliabilityForSalesOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_04A_SalesOrderStoreAvailability, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.gcStockAvailabilityInStore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry65320StoreStockAvaliabilityForSalesOrder1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_04A_SalesOrderStoreAvailability2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStockAvailabilityInStore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoVoucherNoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQuotationDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnPrepareDeliveryNote As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStoreCode As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pvgProfitLoss As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOpenLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSetDefaultLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnShowFields As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnShowRowTotals As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnToday As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnYesterday As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnBy1stQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy2ndQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy3rdQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy4thQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisWeek As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisMonthFull As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisMonthTillDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisYear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisYearTillDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLastYear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLastMonth As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnAddNewAlert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnShowRecords2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewSystemAlert As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnNewAlert As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Qry65320StoreStockAvaliabilityForSalesOrderBindingSource As BindingSource
    Friend WithEvents Dsfrm601_04A_SalesOrderStoreAvailability As dsfrm601_04A_SalesOrderStoreAvailability
    Friend WithEvents fieldSalesOrderNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderedQty1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGSCode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStoreCode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnitRateMethod1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCurrentyQty1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGSDescrpition1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGSGroupName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldItemPartNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStockClassification1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnitDesc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Qry653_20StoreStockAvaliabilityForSalesOrderTableAdapter As dsfrm601_04A_SalesOrderStoreAvailabilityTableAdapters.qry653_20StoreStockAvaliabilityForSalesOrderTableAdapter
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents fieldTotalOrderedQty As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTotalIssdQty As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBalanceToDeliver As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Dsfrm601_04A_SalesOrderStoreAvailability1 As dsfrm601_04A_SalesOrderStoreAvailability
    Friend WithEvents Tbl60001StoreMasterBindingSource As BindingSource
    Friend WithEvents Tbl600_01StoreMasterTableAdapter As dsfrm601_04A_SalesOrderStoreAvailabilityTableAdapters.tbl600_01StoreMasterTableAdapter
    Friend WithEvents colStoreID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoreName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcStockAvailabilityInStore As DevExpress.XtraGrid.GridControl
    Friend WithEvents repoVoucherNoEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
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
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Qry65320StoreStockAvaliabilityForSalesOrder1BindingSource As BindingSource
    Friend WithEvents Dsfrm601_04A_SalesOrderStoreAvailability2 As dsfrm601_04A_SalesOrderStoreAvailability
    Friend WithEvents gvStockAvailabilityInStore As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSalesOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoreCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitRateMethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentyQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDescrpition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSGroupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemPartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockClassification As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalOrderedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalIssdQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalanceToDeliver As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvailabilityStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter As dsfrm601_04A_SalesOrderStoreAvailabilityTableAdapters.qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter
    Friend WithEvents btnBack As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colSalesOrderChildID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveringQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colIsServicesGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents fieldOrderUnitOfMeasure As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderedQtyInBaseUnit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnitConverted As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTotalOrderedQtyInBaseUnit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTotalIssuedInBaseUnit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBalanceToDeliverInBaseUnit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCurrentQtyInOrderedUnit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCurrentQtyInOrderedUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderUnitOfMeasure As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderedQtyInBaseUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalIssuedInBaseUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalOrderedQtyInBaseUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitConverted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalanceToDeliverInBaseUnit As DevExpress.XtraGrid.Columns.GridColumn
End Class
