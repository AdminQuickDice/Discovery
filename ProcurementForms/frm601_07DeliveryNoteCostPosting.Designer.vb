<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm601_07DeliveryNoteCostPosting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm601_07DeliveryNoteCostPosting))
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
        Me.gcVoucherList = New DevExpress.XtraGrid.GridControl()
        Me.Qry60306DeliveryNoteDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_07DeliveryNoteCostPosting = New ERP.dsfrm601_07DeliveryNoteCostPosting()
        Me.gvDeliveryNote = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDeliveryNoteNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientPONo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuotationNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialRequestNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoreID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsVerified1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPersonTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactMobile1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactMobile2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPhone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPhone2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPersonName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssuedQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssuedUOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitRateMethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddlDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDescrpition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignatoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignatoryPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignatoryContact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignatoryEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesman = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransportedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDriversName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDriversID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVehicleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryNoteRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoreName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoreCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientPODate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMPRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevisionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssuedUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpiryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryIssuedTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAttention = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientContactNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientContactEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssuedFromStoreCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssuedFromStoreName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectMasterCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSGroupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemMake = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockClassification = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHSCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdentification = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Qry60304DeliveryNoteViewMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_06DeliveryNoteView = New ERP.dsfrm601_06DeliveryNoteView()
        Me.Qry603_04DeliveryNoteViewMasterTableAdapter = New ERP.dsfrm601_06DeliveryNoteViewTableAdapters.qry603_04DeliveryNoteViewMasterTableAdapter()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.btnShowAllRecords = New DevExpress.XtraEditors.DropDownButton()
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
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOpenLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnResetLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSetDefaultLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSearch = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGroup = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPostAvgCost = New DevExpress.XtraBars.BarButtonItem()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnAddNewAlert = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditDeliveryNote = New DevExpress.XtraBars.BarButtonItem()
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
        Me.btnDeleteDeliveryNote = New DevExpress.XtraBars.BarButtonItem()
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
        Me.btnAddNewDN = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPreviewQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTaxSummaryReport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnlockDeliveryNote = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTaxReport = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.btnReviseQuotation = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeliveryDetails = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddNewIssueToStore = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCreateInvoiceForOneDN = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddStoreTransfers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddNewIssueToProjects = New DevExpress.XtraBars.BarButtonItem()
        Me.txtEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ERP.WaitForm2), True, True)
        Me.Qry603_06DeliveryNoteDetailsTableAdapter = New ERP.dsfrm601_07DeliveryNoteCostPostingTableAdapters.qry603_06DeliveryNoteDetailsTableAdapter()
        Me.colDeliveryNoteSlNo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcVoucherList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60306DeliveryNoteDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_07DeliveryNoteCostPosting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDeliveryNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoQuoteNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQuotationDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60304DeliveryNoteViewMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_06DeliveryNoteView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(19, 370)
        Me.PanelControl1.TabIndex = 114
        '
        'gcVoucherList
        '
        Me.gcVoucherList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVoucherList.DataSource = Me.Qry60306DeliveryNoteDetailsBindingSource
        Me.gcVoucherList.Location = New System.Drawing.Point(22, 43)
        Me.gcVoucherList.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcVoucherList.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcVoucherList.MainView = Me.gvDeliveryNote
        Me.gcVoucherList.Name = "gcVoucherList"
        Me.gcVoucherList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoQuoteNo, Me.repoClientName})
        Me.gcVoucherList.Size = New System.Drawing.Size(773, 323)
        Me.gcVoucherList.TabIndex = 115
        Me.gcVoucherList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDeliveryNote, Me.gvQuotationDetails, Me.GridView2})
        '
        'Qry60306DeliveryNoteDetailsBindingSource
        '
        Me.Qry60306DeliveryNoteDetailsBindingSource.DataMember = "qry603_06DeliveryNoteDetails"
        Me.Qry60306DeliveryNoteDetailsBindingSource.DataSource = Me.Dsfrm601_07DeliveryNoteCostPosting
        '
        'Dsfrm601_07DeliveryNoteCostPosting
        '
        Me.Dsfrm601_07DeliveryNoteCostPosting.DataSetName = "dsfrm601_07DeliveryNoteCostPosting"
        Me.Dsfrm601_07DeliveryNoteCostPosting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvDeliveryNote
        '
        Me.gvDeliveryNote.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDeliveryNote.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDeliveryNote.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDeliveryNote.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDeliveryNote.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvDeliveryNote.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDeliveryNote.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvDeliveryNote.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDeliveryNote.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDeliveryNote.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvDeliveryNote.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvDeliveryNote.Appearance.Empty.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent
        Me.gvDeliveryNote.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDeliveryNote.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDeliveryNote.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDeliveryNote.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDeliveryNote.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvDeliveryNote.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvDeliveryNote.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvDeliveryNote.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvDeliveryNote.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvDeliveryNote.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDeliveryNote.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDeliveryNote.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDeliveryNote.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDeliveryNote.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvDeliveryNote.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDeliveryNote.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDeliveryNote.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvDeliveryNote.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDeliveryNote.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDeliveryNote.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvDeliveryNote.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDeliveryNote.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDeliveryNote.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDeliveryNote.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDeliveryNote.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvDeliveryNote.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvDeliveryNote.Appearance.GroupRow.Options.UseFont = True
        Me.gvDeliveryNote.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDeliveryNote.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDeliveryNote.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDeliveryNote.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDeliveryNote.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvDeliveryNote.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDeliveryNote.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvDeliveryNote.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvDeliveryNote.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.OddRow.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.OddRow.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDeliveryNote.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDeliveryNote.Appearance.Preview.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.Preview.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvDeliveryNote.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvDeliveryNote.Appearance.Row.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.Row.Options.UseForeColor = True
        Me.gvDeliveryNote.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvDeliveryNote.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvDeliveryNote.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvDeliveryNote.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvDeliveryNote.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvDeliveryNote.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvDeliveryNote.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.gvDeliveryNote.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvDeliveryNote.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvDeliveryNote.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvDeliveryNote.ColumnPanelRowHeight = 40
        Me.gvDeliveryNote.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDeliveryNoteNo, Me.colDeliveryDate, Me.colDeliveryType, Me.colClientPONo, Me.colQuotationNo1, Me.colSalesOrderNo, Me.colMaterialRequestNo, Me.colStoreID, Me.colProjectID, Me.colClientProject, Me.colIsVerified1, Me.colIsApproved1, Me.colClientName1, Me.colClientAddress, Me.colContactPerson, Me.colContactPersonTitle, Me.colContactMobile1, Me.colContactMobile2, Me.colContactPhone1, Me.colContactPhone2, Me.colContactEmail, Me.colSalesPersonName, Me.colEmailAddress, Me.colGSCode, Me.colIssuedQty, Me.colIssuedUOM, Me.colUnitRateMethod, Me.colDeliveryRemarks, Me.colLineOrderNo, Me.colAddlDescription, Me.colGSDescrpition, Me.colUnitType, Me.colUnitDesc, Me.colSignatoryName, Me.colSignatoryPosition, Me.colSignatoryContact, Me.colSignatoryEmail, Me.colSalesman, Me.colTransportedBy, Me.colDriversName, Me.colDriversID, Me.colVehicleNo, Me.colDeliveryNoteRemarks, Me.colVendorNo, Me.colStoreName, Me.colStoreCode, Me.colClientPODate, Me.colMPRNo, Me.colRevisionNo, Me.colInvoiceNo1, Me.colIssuedUnitPrice, Me.colUnitTotalPrice, Me.colAddedOn1, Me.colExpiryDate, Me.colBatchNo, Me.colDeliveryIssuedTo, Me.colAttention, Me.colClientContactNo1, Me.colClientContactEmail, Me.colIssuedFromStoreCode, Me.colIssuedFromStoreName, Me.colDeliveryTypeName, Me.colProjectMasterCode, Me.colGSGroupName, Me.colItemSize, Me.colItemPartNo, Me.colItemBrand, Me.colItemMake, Me.colStockClassification, Me.colHSCode, Me.colActualSize, Me.colIdentification, Me.colDeliveryNoteSlNo})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Name = "formatCompleted"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = True
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.gvDeliveryNote.FormatRules.Add(GridFormatRule1)
        Me.gvDeliveryNote.GridControl = Me.gcVoucherList
        Me.gvDeliveryNote.GroupRowHeight = 30
        Me.gvDeliveryNote.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ClientName", Nothing, "({0})")})
        Me.gvDeliveryNote.Name = "gvDeliveryNote"
        Me.gvDeliveryNote.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvDeliveryNote.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvDeliveryNote.OptionsLayout.Columns.StoreAppearance = True
        Me.gvDeliveryNote.OptionsLayout.StoreAllOptions = True
        Me.gvDeliveryNote.OptionsLayout.StoreAppearance = True
        Me.gvDeliveryNote.OptionsLayout.StoreFormatRules = True
        Me.gvDeliveryNote.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDeliveryNote.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvDeliveryNote.OptionsSelection.MultiSelect = True
        Me.gvDeliveryNote.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvDeliveryNote.OptionsView.ShowFooter = True
        Me.gvDeliveryNote.OptionsView.ShowGroupPanel = False
        Me.gvDeliveryNote.OptionsView.ShowIndicator = False
        Me.gvDeliveryNote.RowHeight = 30
        Me.gvDeliveryNote.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDeliveryDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colDeliveryNoteNo
        '
        Me.colDeliveryNoteNo.AppearanceCell.Options.UseTextOptions = True
        Me.colDeliveryNoteNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryNoteNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveryNoteNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryNoteNo.FieldName = "DeliveryNoteNo"
        Me.colDeliveryNoteNo.Name = "colDeliveryNoteNo"
        Me.colDeliveryNoteNo.Visible = True
        Me.colDeliveryNoteNo.VisibleIndex = 2
        Me.colDeliveryNoteNo.Width = 109
        '
        'colDeliveryDate
        '
        Me.colDeliveryDate.AppearanceCell.Options.UseTextOptions = True
        Me.colDeliveryDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveryDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryDate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colDeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDeliveryDate.FieldName = "DeliveryDate"
        Me.colDeliveryDate.Name = "colDeliveryDate"
        Me.colDeliveryDate.Visible = True
        Me.colDeliveryDate.VisibleIndex = 3
        Me.colDeliveryDate.Width = 91
        '
        'colDeliveryType
        '
        Me.colDeliveryType.FieldName = "DeliveryType"
        Me.colDeliveryType.Name = "colDeliveryType"
        Me.colDeliveryType.Width = 20
        '
        'colClientPONo
        '
        Me.colClientPONo.FieldName = "ClientPONo"
        Me.colClientPONo.Name = "colClientPONo"
        Me.colClientPONo.Width = 20
        '
        'colQuotationNo1
        '
        Me.colQuotationNo1.FieldName = "QuotationNo"
        Me.colQuotationNo1.Name = "colQuotationNo1"
        Me.colQuotationNo1.Width = 20
        '
        'colSalesOrderNo
        '
        Me.colSalesOrderNo.FieldName = "SalesOrderNo"
        Me.colSalesOrderNo.Name = "colSalesOrderNo"
        Me.colSalesOrderNo.Width = 20
        '
        'colMaterialRequestNo
        '
        Me.colMaterialRequestNo.FieldName = "MaterialRequestNo"
        Me.colMaterialRequestNo.Name = "colMaterialRequestNo"
        Me.colMaterialRequestNo.Width = 20
        '
        'colStoreID
        '
        Me.colStoreID.FieldName = "StoreID"
        Me.colStoreID.Name = "colStoreID"
        Me.colStoreID.Width = 20
        '
        'colProjectID
        '
        Me.colProjectID.FieldName = "ProjectID"
        Me.colProjectID.Name = "colProjectID"
        Me.colProjectID.Width = 20
        '
        'colClientProject
        '
        Me.colClientProject.FieldName = "ClientProject"
        Me.colClientProject.Name = "colClientProject"
        Me.colClientProject.Width = 20
        '
        'colIsVerified1
        '
        Me.colIsVerified1.FieldName = "IsVerified"
        Me.colIsVerified1.Name = "colIsVerified1"
        Me.colIsVerified1.Width = 20
        '
        'colIsApproved1
        '
        Me.colIsApproved1.FieldName = "IsApproved"
        Me.colIsApproved1.Name = "colIsApproved1"
        Me.colIsApproved1.Width = 20
        '
        'colClientName1
        '
        Me.colClientName1.FieldName = "ClientName"
        Me.colClientName1.Name = "colClientName1"
        Me.colClientName1.Width = 20
        '
        'colClientAddress
        '
        Me.colClientAddress.FieldName = "ClientAddress"
        Me.colClientAddress.Name = "colClientAddress"
        Me.colClientAddress.Width = 20
        '
        'colContactPerson
        '
        Me.colContactPerson.FieldName = "ContactPerson"
        Me.colContactPerson.Name = "colContactPerson"
        Me.colContactPerson.Width = 20
        '
        'colContactPersonTitle
        '
        Me.colContactPersonTitle.FieldName = "ContactPersonTitle"
        Me.colContactPersonTitle.Name = "colContactPersonTitle"
        Me.colContactPersonTitle.Width = 20
        '
        'colContactMobile1
        '
        Me.colContactMobile1.FieldName = "ContactMobile1"
        Me.colContactMobile1.Name = "colContactMobile1"
        Me.colContactMobile1.Width = 20
        '
        'colContactMobile2
        '
        Me.colContactMobile2.FieldName = "ContactMobile2"
        Me.colContactMobile2.Name = "colContactMobile2"
        Me.colContactMobile2.Width = 20
        '
        'colContactPhone1
        '
        Me.colContactPhone1.FieldName = "ContactPhone1"
        Me.colContactPhone1.Name = "colContactPhone1"
        Me.colContactPhone1.Width = 20
        '
        'colContactPhone2
        '
        Me.colContactPhone2.FieldName = "ContactPhone2"
        Me.colContactPhone2.Name = "colContactPhone2"
        Me.colContactPhone2.Width = 20
        '
        'colContactEmail
        '
        Me.colContactEmail.FieldName = "ContactEmail"
        Me.colContactEmail.Name = "colContactEmail"
        Me.colContactEmail.Width = 20
        '
        'colSalesPersonName
        '
        Me.colSalesPersonName.FieldName = "SalesPersonName"
        Me.colSalesPersonName.Name = "colSalesPersonName"
        Me.colSalesPersonName.Width = 20
        '
        'colEmailAddress
        '
        Me.colEmailAddress.FieldName = "EmailAddress"
        Me.colEmailAddress.Name = "colEmailAddress"
        Me.colEmailAddress.Width = 20
        '
        'colGSCode
        '
        Me.colGSCode.AppearanceCell.Options.UseTextOptions = True
        Me.colGSCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSCode.FieldName = "GSCode"
        Me.colGSCode.Name = "colGSCode"
        Me.colGSCode.Visible = True
        Me.colGSCode.VisibleIndex = 4
        Me.colGSCode.Width = 113
        '
        'colIssuedQty
        '
        Me.colIssuedQty.FieldName = "IssuedQty"
        Me.colIssuedQty.Name = "colIssuedQty"
        Me.colIssuedQty.Width = 20
        '
        'colIssuedUOM
        '
        Me.colIssuedUOM.FieldName = "IssuedUOM"
        Me.colIssuedUOM.Name = "colIssuedUOM"
        Me.colIssuedUOM.Width = 20
        '
        'colUnitRateMethod
        '
        Me.colUnitRateMethod.FieldName = "UnitRateMethod"
        Me.colUnitRateMethod.Name = "colUnitRateMethod"
        Me.colUnitRateMethod.Width = 20
        '
        'colDeliveryRemarks
        '
        Me.colDeliveryRemarks.FieldName = "DeliveryRemarks"
        Me.colDeliveryRemarks.Name = "colDeliveryRemarks"
        Me.colDeliveryRemarks.Width = 20
        '
        'colLineOrderNo
        '
        Me.colLineOrderNo.FieldName = "LineOrderNo"
        Me.colLineOrderNo.Name = "colLineOrderNo"
        Me.colLineOrderNo.Width = 20
        '
        'colAddlDescription
        '
        Me.colAddlDescription.FieldName = "AddlDescription"
        Me.colAddlDescription.Name = "colAddlDescription"
        Me.colAddlDescription.Width = 20
        '
        'colGSDescrpition
        '
        Me.colGSDescrpition.FieldName = "GSDescrpition"
        Me.colGSDescrpition.Name = "colGSDescrpition"
        Me.colGSDescrpition.Visible = True
        Me.colGSDescrpition.VisibleIndex = 5
        Me.colGSDescrpition.Width = 298
        '
        'colUnitType
        '
        Me.colUnitType.FieldName = "UnitType"
        Me.colUnitType.Name = "colUnitType"
        Me.colUnitType.Width = 20
        '
        'colUnitDesc
        '
        Me.colUnitDesc.FieldName = "UnitDesc"
        Me.colUnitDesc.Name = "colUnitDesc"
        Me.colUnitDesc.Width = 270
        '
        'colSignatoryName
        '
        Me.colSignatoryName.FieldName = "SignatoryName"
        Me.colSignatoryName.Name = "colSignatoryName"
        Me.colSignatoryName.Width = 20
        '
        'colSignatoryPosition
        '
        Me.colSignatoryPosition.FieldName = "SignatoryPosition"
        Me.colSignatoryPosition.Name = "colSignatoryPosition"
        Me.colSignatoryPosition.Width = 20
        '
        'colSignatoryContact
        '
        Me.colSignatoryContact.FieldName = "SignatoryContact"
        Me.colSignatoryContact.Name = "colSignatoryContact"
        Me.colSignatoryContact.Width = 20
        '
        'colSignatoryEmail
        '
        Me.colSignatoryEmail.FieldName = "SignatoryEmail"
        Me.colSignatoryEmail.Name = "colSignatoryEmail"
        Me.colSignatoryEmail.Width = 20
        '
        'colSalesman
        '
        Me.colSalesman.FieldName = "Salesman"
        Me.colSalesman.Name = "colSalesman"
        Me.colSalesman.Width = 20
        '
        'colTransportedBy
        '
        Me.colTransportedBy.FieldName = "TransportedBy"
        Me.colTransportedBy.Name = "colTransportedBy"
        Me.colTransportedBy.Width = 20
        '
        'colDriversName
        '
        Me.colDriversName.FieldName = "DriversName"
        Me.colDriversName.Name = "colDriversName"
        Me.colDriversName.Width = 20
        '
        'colDriversID
        '
        Me.colDriversID.FieldName = "DriversID"
        Me.colDriversID.Name = "colDriversID"
        Me.colDriversID.Width = 20
        '
        'colVehicleNo
        '
        Me.colVehicleNo.FieldName = "VehicleNo"
        Me.colVehicleNo.Name = "colVehicleNo"
        Me.colVehicleNo.Width = 20
        '
        'colDeliveryNoteRemarks
        '
        Me.colDeliveryNoteRemarks.FieldName = "DeliveryNoteRemarks"
        Me.colDeliveryNoteRemarks.Name = "colDeliveryNoteRemarks"
        Me.colDeliveryNoteRemarks.Width = 20
        '
        'colVendorNo
        '
        Me.colVendorNo.FieldName = "VendorNo"
        Me.colVendorNo.Name = "colVendorNo"
        Me.colVendorNo.Width = 20
        '
        'colStoreName
        '
        Me.colStoreName.FieldName = "StoreName"
        Me.colStoreName.Name = "colStoreName"
        Me.colStoreName.Width = 20
        '
        'colStoreCode
        '
        Me.colStoreCode.FieldName = "StoreCode"
        Me.colStoreCode.Name = "colStoreCode"
        Me.colStoreCode.Width = 20
        '
        'colClientPODate
        '
        Me.colClientPODate.FieldName = "ClientPODate"
        Me.colClientPODate.Name = "colClientPODate"
        Me.colClientPODate.Width = 20
        '
        'colMPRNo
        '
        Me.colMPRNo.FieldName = "MPRNo"
        Me.colMPRNo.Name = "colMPRNo"
        Me.colMPRNo.Width = 20
        '
        'colRevisionNo
        '
        Me.colRevisionNo.FieldName = "RevisionNo"
        Me.colRevisionNo.Name = "colRevisionNo"
        Me.colRevisionNo.Width = 20
        '
        'colInvoiceNo1
        '
        Me.colInvoiceNo1.FieldName = "InvoiceNo"
        Me.colInvoiceNo1.Name = "colInvoiceNo1"
        Me.colInvoiceNo1.Width = 20
        '
        'colIssuedUnitPrice
        '
        Me.colIssuedUnitPrice.FieldName = "IssuedUnitPrice"
        Me.colIssuedUnitPrice.Name = "colIssuedUnitPrice"
        Me.colIssuedUnitPrice.Width = 20
        '
        'colUnitTotalPrice
        '
        Me.colUnitTotalPrice.FieldName = "UnitTotalPrice"
        Me.colUnitTotalPrice.Name = "colUnitTotalPrice"
        Me.colUnitTotalPrice.Width = 20
        '
        'colAddedOn1
        '
        Me.colAddedOn1.FieldName = "AddedOn"
        Me.colAddedOn1.Name = "colAddedOn1"
        Me.colAddedOn1.Width = 20
        '
        'colExpiryDate
        '
        Me.colExpiryDate.FieldName = "ExpiryDate"
        Me.colExpiryDate.Name = "colExpiryDate"
        Me.colExpiryDate.Width = 20
        '
        'colBatchNo
        '
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.Width = 20
        '
        'colDeliveryIssuedTo
        '
        Me.colDeliveryIssuedTo.FieldName = "DeliveryIssuedTo"
        Me.colDeliveryIssuedTo.Name = "colDeliveryIssuedTo"
        Me.colDeliveryIssuedTo.Width = 20
        '
        'colAttention
        '
        Me.colAttention.FieldName = "Attention"
        Me.colAttention.Name = "colAttention"
        Me.colAttention.Width = 20
        '
        'colClientContactNo1
        '
        Me.colClientContactNo1.FieldName = "ClientContactNo"
        Me.colClientContactNo1.Name = "colClientContactNo1"
        Me.colClientContactNo1.Width = 20
        '
        'colClientContactEmail
        '
        Me.colClientContactEmail.FieldName = "ClientContactEmail"
        Me.colClientContactEmail.Name = "colClientContactEmail"
        Me.colClientContactEmail.Width = 20
        '
        'colIssuedFromStoreCode
        '
        Me.colIssuedFromStoreCode.FieldName = "IssuedFromStoreCode"
        Me.colIssuedFromStoreCode.Name = "colIssuedFromStoreCode"
        Me.colIssuedFromStoreCode.Width = 20
        '
        'colIssuedFromStoreName
        '
        Me.colIssuedFromStoreName.FieldName = "IssuedFromStoreName"
        Me.colIssuedFromStoreName.Name = "colIssuedFromStoreName"
        Me.colIssuedFromStoreName.Width = 20
        '
        'colDeliveryTypeName
        '
        Me.colDeliveryTypeName.FieldName = "DeliveryTypeName"
        Me.colDeliveryTypeName.Name = "colDeliveryTypeName"
        Me.colDeliveryTypeName.Width = 20
        '
        'colProjectMasterCode
        '
        Me.colProjectMasterCode.FieldName = "ProjectMasterCode"
        Me.colProjectMasterCode.Name = "colProjectMasterCode"
        Me.colProjectMasterCode.Width = 20
        '
        'colGSGroupName
        '
        Me.colGSGroupName.FieldName = "GSGroupName"
        Me.colGSGroupName.Name = "colGSGroupName"
        Me.colGSGroupName.Width = 20
        '
        'colItemSize
        '
        Me.colItemSize.FieldName = "ItemSize"
        Me.colItemSize.Name = "colItemSize"
        Me.colItemSize.Width = 20
        '
        'colItemPartNo
        '
        Me.colItemPartNo.FieldName = "ItemPartNo"
        Me.colItemPartNo.Name = "colItemPartNo"
        Me.colItemPartNo.Width = 20
        '
        'colItemBrand
        '
        Me.colItemBrand.FieldName = "ItemBrand"
        Me.colItemBrand.Name = "colItemBrand"
        Me.colItemBrand.Width = 20
        '
        'colItemMake
        '
        Me.colItemMake.FieldName = "ItemMake"
        Me.colItemMake.Name = "colItemMake"
        Me.colItemMake.Width = 20
        '
        'colStockClassification
        '
        Me.colStockClassification.FieldName = "StockClassification"
        Me.colStockClassification.Name = "colStockClassification"
        Me.colStockClassification.Width = 20
        '
        'colHSCode
        '
        Me.colHSCode.FieldName = "HSCode"
        Me.colHSCode.Name = "colHSCode"
        Me.colHSCode.Width = 20
        '
        'colActualSize
        '
        Me.colActualSize.FieldName = "ActualSize"
        Me.colActualSize.Name = "colActualSize"
        Me.colActualSize.Width = 20
        '
        'colIdentification
        '
        Me.colIdentification.FieldName = "Identification"
        Me.colIdentification.Name = "colIdentification"
        Me.colIdentification.Width = 20
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
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcVoucherList
        Me.GridView2.Name = "GridView2"
        '
        'Qry60304DeliveryNoteViewMasterBindingSource
        '
        Me.Qry60304DeliveryNoteViewMasterBindingSource.DataMember = "qry603_04DeliveryNoteViewMaster"
        Me.Qry60304DeliveryNoteViewMasterBindingSource.DataSource = Me.Dsfrm601_06DeliveryNoteView
        '
        'Dsfrm601_06DeliveryNoteView
        '
        Me.Dsfrm601_06DeliveryNoteView.DataSetName = "dsfrm601_06DeliveryNoteView"
        Me.Dsfrm601_06DeliveryNoteView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Qry603_04DeliveryNoteViewMasterTableAdapter
        '
        Me.Qry603_04DeliveryNoteViewMasterTableAdapter.ClearBeforeFill = True
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.txtStartDate)
        Me.PanelControl3.Controls.Add(Me.btnShowAllRecords)
        Me.PanelControl3.Controls.Add(Me.txtEndDate)
        Me.PanelControl3.Location = New System.Drawing.Point(22, 3)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(773, 37)
        Me.PanelControl3.TabIndex = 116
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
        Me.txtStartDate.TabIndex = 89
        '
        'btnShowAllRecords
        '
        Me.btnShowAllRecords.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowAllRecords.Appearance.Options.UseFont = True
        Me.btnShowAllRecords.DropDownControl = Me.PopupMenu2
        Me.btnShowAllRecords.ImageOptions.Image = Global.ERP.My.Resources.Resources.books_blue
        Me.btnShowAllRecords.Location = New System.Drawing.Point(373, 4)
        Me.btnShowAllRecords.LookAndFeel.SkinName = "Blue"
        Me.btnShowAllRecords.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnShowAllRecords.Name = "btnShowAllRecords"
        Me.btnShowAllRecords.Size = New System.Drawing.Size(158, 31)
        Me.btnShowAllRecords.TabIndex = 92
        Me.btnShowAllRecords.Text = "Show Records"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPrint, Me.btnSearch, Me.btnGroup, Me.btnAddNewAlert, Me.btnEditDeliveryNote, Me.btnShowRecords2, Me.btnNewSystemAlert, Me.btnNewAlert, Me.btnNewReminder, Me.btnNewAssignment, Me.btnApprove, Me.btnViewVoucher, Me.btnAddNewPR, Me.btnRptPR, Me.BarButtonItem1, Me.btnViewServiceRequest, Me.btnNewRequest, Me.btnVerify, Me.btnDeleteDeliveryNote, Me.btnShowMyRequests, Me.btnChooseVoucher, Me.btnChooseVouchers, Me.btnPaymentVouchers, Me.btnReceiptVouchers, Me.btnSalesVouchers, Me.btnPurchasesVouchers, Me.btnJournalVouchers, Me.btnAllVoucherTypes, Me.btnToday, Me.btnYesterday, Me.btnThisWeek, Me.BarButtonItem5, Me.btnThisYear, Me.btnThisMonthFull, Me.btnThisYearTillDate, Me.btnThisMonthTillDate, Me.btnLastYear, Me.btnLastMonth, Me.BarSubItem1, Me.BarButtonItem2, Me.btnAddNewDN, Me.btnPreviewQuote, Me.btnTaxSummaryReport, Me.btnUnlockDeliveryNote, Me.btnTaxReport, Me.BarSubItem2, Me.BarSubItem3, Me.btnSaveLayout, Me.btnOpenLayout, Me.btnSetDefaultLayout, Me.BarSubItem4, Me.btnBy1stQuarter, Me.btnBy2ndQuarter, Me.btnBy3rdQuarter, Me.btnBy4thQuarter, Me.btnReviseQuotation, Me.btnDeliveryDetails, Me.btnAddNewIssueToStore, Me.btnCreateInvoiceForOneDN, Me.btnAddStoreTransfers, Me.btnResetLayout, Me.btnAddNewIssueToProjects, Me.btnPostAvgCost})
        Me.BarManager1.MaxItemId = 68
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem3, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPrint, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSearch, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGroup, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPostAvgCost, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        Me.btnResetLayout.Id = 65
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
        'btnPostAvgCost
        '
        Me.btnPostAvgCost.Caption = "Post Average Cost"
        Me.btnPostAvgCost.Id = 67
        Me.btnPostAvgCost.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPostAvgCost.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPostAvgCost.Name = "btnPostAvgCost"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(800, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 370)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(800, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 370)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(800, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 370)
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
        'btnEditDeliveryNote
        '
        Me.btnEditDeliveryNote.Caption = "Edit Delivery Note"
        Me.btnEditDeliveryNote.Id = 4
        Me.btnEditDeliveryNote.ImageOptions.Image = Global.ERP.My.Resources.Resources.edit24
        Me.btnEditDeliveryNote.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditDeliveryNote.ItemAppearance.Normal.Options.UseFont = True
        Me.btnEditDeliveryNote.Name = "btnEditDeliveryNote"
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
        'btnDeleteDeliveryNote
        '
        Me.btnDeleteDeliveryNote.Caption = "Delete Delivery Note"
        Me.btnDeleteDeliveryNote.Id = 19
        Me.btnDeleteDeliveryNote.ImageOptions.Image = CType(resources.GetObject("btnDeleteDeliveryNote.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteDeliveryNote.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteDeliveryNote.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteDeliveryNote.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDeleteDeliveryNote.ItemAppearance.Normal.Options.UseForeColor = True
        Me.btnDeleteDeliveryNote.Name = "btnDeleteDeliveryNote"
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
        'btnAddNewDN
        '
        Me.btnAddNewDN.Caption = "Add New Delivery To Client"
        Me.btnAddNewDN.Id = 42
        Me.btnAddNewDN.ImageOptions.Image = CType(resources.GetObject("btnAddNewDN.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddNewDN.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewDN.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddNewDN.Name = "btnAddNewDN"
        '
        'btnPreviewQuote
        '
        Me.btnPreviewQuote.Caption = "Preview Delivery Note"
        Me.btnPreviewQuote.Id = 43
        Me.btnPreviewQuote.ImageOptions.Image = CType(resources.GetObject("btnPreviewQuote.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPreviewQuote.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPreviewQuote.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPreviewQuote.Name = "btnPreviewQuote"
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
        'btnUnlockDeliveryNote
        '
        Me.btnUnlockDeliveryNote.Caption = "Unlock the Delivery Note"
        Me.btnUnlockDeliveryNote.Id = 45
        Me.btnUnlockDeliveryNote.ImageOptions.Image = CType(resources.GetObject("btnUnlockDeliveryNote.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUnlockDeliveryNote.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnUnlockDeliveryNote.ItemAppearance.Normal.Options.UseFont = True
        Me.btnUnlockDeliveryNote.Name = "btnUnlockDeliveryNote"
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
        'btnReviseQuotation
        '
        Me.btnReviseQuotation.Caption = "Revise Quotation"
        Me.btnReviseQuotation.Id = 57
        Me.btnReviseQuotation.ImageOptions.Image = CType(resources.GetObject("btnReviseQuotation.ImageOptions.Image"), System.Drawing.Image)
        Me.btnReviseQuotation.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnReviseQuotation.ItemAppearance.Normal.Options.UseFont = True
        Me.btnReviseQuotation.Name = "btnReviseQuotation"
        '
        'btnDeliveryDetails
        '
        Me.btnDeliveryDetails.Caption = "Delivery Note Details"
        Me.btnDeliveryDetails.Id = 59
        Me.btnDeliveryDetails.ImageOptions.Image = CType(resources.GetObject("btnDeliveryDetails.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeliveryDetails.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDeliveryDetails.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDeliveryDetails.Name = "btnDeliveryDetails"
        '
        'btnAddNewIssueToStore
        '
        Me.btnAddNewIssueToStore.Caption = "Add Material Issued to Store (Consumption)"
        Me.btnAddNewIssueToStore.Id = 61
        Me.btnAddNewIssueToStore.ImageOptions.Image = CType(resources.GetObject("btnAddNewIssueToStore.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddNewIssueToStore.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewIssueToStore.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddNewIssueToStore.Name = "btnAddNewIssueToStore"
        '
        'btnCreateInvoiceForOneDN
        '
        Me.btnCreateInvoiceForOneDN.Caption = "Create Invoice for this Delivery Note"
        Me.btnCreateInvoiceForOneDN.Id = 63
        Me.btnCreateInvoiceForOneDN.ImageOptions.Image = CType(resources.GetObject("btnCreateInvoiceForOneDN.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCreateInvoiceForOneDN.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCreateInvoiceForOneDN.ItemAppearance.Normal.Options.UseFont = True
        Me.btnCreateInvoiceForOneDN.Name = "btnCreateInvoiceForOneDN"
        '
        'btnAddStoreTransfers
        '
        Me.btnAddStoreTransfers.Caption = "Add Store Transfers"
        Me.btnAddStoreTransfers.Id = 64
        Me.btnAddStoreTransfers.ImageOptions.Image = CType(resources.GetObject("btnAddStoreTransfers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddStoreTransfers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddStoreTransfers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddStoreTransfers.Name = "btnAddStoreTransfers"
        '
        'btnAddNewIssueToProjects
        '
        Me.btnAddNewIssueToProjects.Caption = "Add Materials Issued to Projects (Consumption)"
        Me.btnAddNewIssueToProjects.Id = 66
        Me.btnAddNewIssueToProjects.ImageOptions.Image = CType(resources.GetObject("btnAddNewIssueToProjects.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddNewIssueToProjects.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewIssueToProjects.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddNewIssueToProjects.Name = "btnAddNewIssueToProjects"
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
        Me.txtEndDate.TabIndex = 91
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditDeliveryNote, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDeleteDeliveryNote, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnUnlockDeliveryNote, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCreateInvoiceForOneDN, True)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "Flag-blue16.png")
        Me.ImageCollection1.Images.SetKeyName(1, "Flag-green16.png")
        Me.ImageCollection1.Images.SetKeyName(2, "Flag-red16.png")
        Me.ImageCollection1.Images.SetKeyName(3, "Flag-yellow16.png")
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Csv.Separator = ";"
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gcVoucherList
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'Qry603_06DeliveryNoteDetailsTableAdapter
        '
        Me.Qry603_06DeliveryNoteDetailsTableAdapter.ClearBeforeFill = True
        '
        'colDeliveryNoteSlNo
        '
        Me.colDeliveryNoteSlNo.FieldName = "DeliveryNoteSlNo"
        Me.colDeliveryNoteSlNo.Name = "colDeliveryNoteSlNo"
        Me.colDeliveryNoteSlNo.Visible = True
        Me.colDeliveryNoteSlNo.VisibleIndex = 1
        Me.colDeliveryNoteSlNo.Width = 85
        '
        'frm601_07DeliveryNoteCostPosting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 413)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.gcVoucherList)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm601_07DeliveryNoteCostPosting"
        Me.Text = "Delivery Note : Average Cost Posting"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcVoucherList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60306DeliveryNoteDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_07DeliveryNoteCostPosting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDeliveryNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoQuoteNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQuotationDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60304DeliveryNoteViewMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_06DeliveryNoteView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcVoucherList As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Qry60304DeliveryNoteViewMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dsfrm601_06DeliveryNoteView As ERP.dsfrm601_06DeliveryNoteView
    Friend WithEvents gvDeliveryNote As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Qry603_04DeliveryNoteViewMasterTableAdapter As ERP.dsfrm601_06DeliveryNoteViewTableAdapters.qry603_04DeliveryNoteViewMasterTableAdapter
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Public WithEvents txtStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnShowAllRecords As DevExpress.XtraEditors.DropDownButton
    Public WithEvents txtEndDate As DevExpress.XtraEditors.DateEdit
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
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOpenLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSetDefaultLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSearch As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeliveryDetails As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddNewDN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddNewIssueToStore As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddNewIssueToProjects As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddStoreTransfers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnAddNewAlert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditDeliveryNote As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents btnDeleteDeliveryNote As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents btnPreviewQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTaxSummaryReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnlockDeliveryNote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTaxReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnReviseQuotation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCreateInvoiceForOneDN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnPostAvgCost As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents Qry60306DeliveryNoteDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dsfrm601_07DeliveryNoteCostPosting As ERP.dsfrm601_07DeliveryNoteCostPosting
    Friend WithEvents colDeliveryNoteNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientPONo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuotationNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialRequestNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoreID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsVerified1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsApproved1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPersonTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactMobile1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactMobile2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPhone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPhone2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPersonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssuedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssuedUOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitRateMethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddlDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDescrpition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignatoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignatoryPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignatoryContact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignatoryEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesman As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransportedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDriversName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDriversID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVehicleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryNoteRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoreName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoreCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientPODate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMPRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevisionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssuedUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpiryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryIssuedTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAttention As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientContactNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientContactEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssuedFromStoreCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssuedFromStoreName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectMasterCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSGroupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemPartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemMake As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockClassification As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHSCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdentification As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qry603_06DeliveryNoteDetailsTableAdapter As ERP.dsfrm601_07DeliveryNoteCostPostingTableAdapters.qry603_06DeliveryNoteDetailsTableAdapter
    Friend WithEvents colDeliveryNoteSlNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
