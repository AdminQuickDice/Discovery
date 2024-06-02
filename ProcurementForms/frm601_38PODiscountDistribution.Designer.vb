<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm601_38PODiscountDistribution
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm601_38PODiscountDistribution))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtCostAmount = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCostPercentage = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.gcInvoiceChild = New DevExpress.XtraGrid.GridControl()
        Me.Qry60402PurchaseOrderChildBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_38PODiscountDistribution = New ERP.dsfrm601_38PODiscountDistribution()
        Me.gvInvoiceChild = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPOChildNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPONo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSCode2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDescrpition2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDescriptionAr1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddlDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuotedQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitRateMethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitDesc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOTaxSlab = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOItemRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseTaxSlab = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseTaxRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineTotalBeforeTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineTotalAfterDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineTaxAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineTotalWithTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderedQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivedQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalanceToReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryPeriod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemMake = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHSCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRItemNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExchangeRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitRateInOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscountInOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrencyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrencyNameAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrencyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrencyCodeAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineTotalB4TaxOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineTotalAfterDiscOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineTaxAmountOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineTotalWithTaxOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoDetailedDescription = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gvGSList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGSCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDescrpition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDescriptionAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDetailedDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDetailedDescAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSGroupID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHSCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoQtyInvoiced = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.repoUnitRateMethod = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoEditUnitRate = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.repoPopupAdditionalColumns = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.repoEditTaxSlab = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTaxSlabCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaxSlab = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaxSlabAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaxRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaxCategoryID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaxCategory2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaxCategoryAr2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoPopupCalculateDiscount = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.repoUnitPriceOC = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.repoDiscountOC = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.repoCostDetails = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOpenLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnResetLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSetDefaultLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.btnDistributeEqually = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDistributeByProportionately = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDistributeByPercentage = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
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
        Me.btnToday = New DevExpress.XtraBars.BarButtonItem()
        Me.btnYesterday = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThisWeek = New DevExpress.XtraBars.BarButtonItem()
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
        Me.btnDistributeByEqually = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDistributeByProportion = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnProfitByPercentage = New DevExpress.XtraBars.BarButtonItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Qry604_02PurchaseOrderChildTableAdapter = New ERP.dsfrm601_38PODiscountDistributionTableAdapters.qry604_02PurchaseOrderChildTableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtCostAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostPercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcInvoiceChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60402PurchaseOrderChildBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_38PODiscountDistribution, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInvoiceChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDetailedDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvGSList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoQtyInvoiced, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoUnitRateMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoEditUnitRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopupAdditionalColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoEditTaxSlab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopupCalculateDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoUnitPriceOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDiscountOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoCostDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(14, 370)
        Me.PanelControl1.TabIndex = 114
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.RoyalBlue
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Controls.Add(Me.txtCostAmount)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.txtCostPercentage)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.PictureEdit1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(14, 0)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(884, 65)
        Me.PanelControl2.TabIndex = 188
        '
        'txtCostAmount
        '
        Me.txtCostAmount.AllowDrop = True
        Me.txtCostAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostAmount.EnterMoveNextControl = True
        Me.txtCostAmount.Location = New System.Drawing.Point(761, 38)
        Me.txtCostAmount.Name = "txtCostAmount"
        Me.txtCostAmount.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCostAmount.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtCostAmount.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txtCostAmount.Properties.Appearance.Options.UseBackColor = True
        Me.txtCostAmount.Properties.Appearance.Options.UseFont = True
        Me.txtCostAmount.Properties.Appearance.Options.UseForeColor = True
        Me.txtCostAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCostAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCostAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCostAmount.Properties.DisplayFormat.FormatString = "n2"
        Me.txtCostAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCostAmount.Properties.EditFormat.FormatString = "n2"
        Me.txtCostAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCostAmount.Properties.Mask.EditMask = "n2"
        Me.txtCostAmount.Size = New System.Drawing.Size(111, 22)
        Me.txtCostAmount.TabIndex = 101
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Location = New System.Drawing.Point(761, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 14)
        Me.LabelControl3.TabIndex = 100
        Me.LabelControl3.Text = "Discount Amount"
        '
        'txtCostPercentage
        '
        Me.txtCostPercentage.AllowDrop = True
        Me.txtCostPercentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostPercentage.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostPercentage.EnterMoveNextControl = True
        Me.txtCostPercentage.Location = New System.Drawing.Point(616, 38)
        Me.txtCostPercentage.Name = "txtCostPercentage"
        Me.txtCostPercentage.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCostPercentage.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtCostPercentage.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txtCostPercentage.Properties.Appearance.Options.UseBackColor = True
        Me.txtCostPercentage.Properties.Appearance.Options.UseFont = True
        Me.txtCostPercentage.Properties.Appearance.Options.UseForeColor = True
        Me.txtCostPercentage.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCostPercentage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCostPercentage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCostPercentage.Properties.DisplayFormat.FormatString = "n2"
        Me.txtCostPercentage.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCostPercentage.Properties.EditFormat.FormatString = "n2"
        Me.txtCostPercentage.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCostPercentage.Properties.Mask.EditMask = "n2"
        Me.txtCostPercentage.Size = New System.Drawing.Size(113, 22)
        Me.txtCostPercentage.TabIndex = 97
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Location = New System.Drawing.Point(616, 20)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl10.TabIndex = 96
        Me.LabelControl10.Text = "Percentage (%):"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Location = New System.Drawing.Point(59, 28)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(160, 19)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Discount Distribution"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(4, 9)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.PictureEdit1.Properties.ReadOnly = True
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(40, 38)
        Me.PictureEdit1.TabIndex = 13
        '
        'gcInvoiceChild
        '
        Me.gcInvoiceChild.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcInvoiceChild.DataSource = Me.Qry60402PurchaseOrderChildBindingSource
        Me.gcInvoiceChild.Location = New System.Drawing.Point(15, 66)
        Me.gcInvoiceChild.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcInvoiceChild.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcInvoiceChild.MainView = Me.gvInvoiceChild
        Me.gcInvoiceChild.Name = "gcInvoiceChild"
        Me.gcInvoiceChild.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoDetailedDescription, Me.repoQtyInvoiced, Me.repoUnitRateMethod, Me.repoEditUnitRate, Me.repoPopupAdditionalColumns, Me.repoEditTaxSlab, Me.repoPopupCalculateDiscount, Me.repoUnitPriceOC, Me.repoDiscountOC, Me.repoCostDetails})
        Me.gcInvoiceChild.Size = New System.Drawing.Size(883, 303)
        Me.gcInvoiceChild.TabIndex = 189
        Me.gcInvoiceChild.UseDisabledStatePainter = False
        Me.gcInvoiceChild.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInvoiceChild})
        '
        'Qry60402PurchaseOrderChildBindingSource
        '
        Me.Qry60402PurchaseOrderChildBindingSource.DataMember = "qry604_02PurchaseOrderChild"
        Me.Qry60402PurchaseOrderChildBindingSource.DataSource = Me.Dsfrm601_38PODiscountDistribution
        '
        'Dsfrm601_38PODiscountDistribution
        '
        Me.Dsfrm601_38PODiscountDistribution.DataSetName = "dsfrm601_38PODiscountDistribution"
        Me.Dsfrm601_38PODiscountDistribution.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvInvoiceChild
        '
        Me.gvInvoiceChild.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvInvoiceChild.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvInvoiceChild.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvInvoiceChild.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvInvoiceChild.ColumnPanelRowHeight = 40
        Me.gvInvoiceChild.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPOChildNo, Me.colPONo, Me.colGSCode2, Me.colGSDescrpition2, Me.colGSDescriptionAr1, Me.colAddlDescription, Me.colQuotedQuantity, Me.colUnitRateMethod, Me.colUnitType1, Me.colUnitDesc1, Me.colUnitPrice, Me.colItemDiscount, Me.colPOTaxSlab, Me.colPOItemRemarks, Me.colLineOrderNo, Me.colPurchaseTaxSlab, Me.colPurchaseTaxRate, Me.colLineTotalBeforeTax, Me.colLineTotalAfterDisc, Me.colLineTaxAmount, Me.colLineTotalWithTax, Me.colOrderedQty, Me.colReceivedQty, Me.colBalanceToReceive, Me.colPlanNo, Me.colDeliveryPeriod, Me.colItemSize, Me.colItemPartNo, Me.colItemBrand, Me.colItemMake, Me.colHSCode1, Me.colMRItemNo, Me.colCurrency, Me.colExchangeRate, Me.colUnitRateInOC, Me.colDiscountInOC, Me.colCurrencyName, Me.colCurrencyNameAr, Me.colCurrencyCode, Me.colCurrencyCodeAr, Me.colLineTotalB4TaxOC, Me.colLineTotalAfterDiscOC, Me.colLineTaxAmountOC, Me.colLineTotalWithTaxOC})
        Me.gvInvoiceChild.CustomizationFormBounds = New System.Drawing.Rectangle(307, 336, 210, 312)
        Me.gvInvoiceChild.GridControl = Me.gcInvoiceChild
        Me.gvInvoiceChild.Name = "gvInvoiceChild"
        Me.gvInvoiceChild.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvInvoiceChild.OptionsLayout.Columns.StoreAppearance = True
        Me.gvInvoiceChild.OptionsLayout.StoreAllOptions = True
        Me.gvInvoiceChild.OptionsLayout.StoreAppearance = True
        Me.gvInvoiceChild.OptionsLayout.StoreFormatRules = True
        Me.gvInvoiceChild.OptionsSelection.CheckBoxSelectorColumnWidth = 40
        Me.gvInvoiceChild.OptionsSelection.InvertSelection = True
        Me.gvInvoiceChild.OptionsSelection.MultiSelect = True
        Me.gvInvoiceChild.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvInvoiceChild.OptionsView.EnableAppearanceEvenRow = True
        Me.gvInvoiceChild.OptionsView.ShowFooter = True
        Me.gvInvoiceChild.OptionsView.ShowGroupPanel = False
        Me.gvInvoiceChild.RowHeight = 30
        Me.gvInvoiceChild.RowSeparatorHeight = 2
        '
        'colPOChildNo
        '
        Me.colPOChildNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOChildNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOChildNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOChildNo.FieldName = "POChildNo"
        Me.colPOChildNo.Name = "colPOChildNo"
        Me.colPOChildNo.Width = 24
        '
        'colPONo
        '
        Me.colPONo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPONo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPONo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPONo.FieldName = "PONo"
        Me.colPONo.Name = "colPONo"
        Me.colPONo.Width = 24
        '
        'colGSCode2
        '
        Me.colGSCode2.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSCode2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSCode2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSCode2.FieldName = "GSCode"
        Me.colGSCode2.Name = "colGSCode2"
        Me.colGSCode2.OptionsColumn.AllowEdit = False
        Me.colGSCode2.OptionsColumn.AllowFocus = False
        Me.colGSCode2.Visible = True
        Me.colGSCode2.VisibleIndex = 1
        Me.colGSCode2.Width = 69
        '
        'colGSDescrpition2
        '
        Me.colGSDescrpition2.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDescrpition2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDescrpition2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDescrpition2.FieldName = "GSDescrpition"
        Me.colGSDescrpition2.Name = "colGSDescrpition2"
        Me.colGSDescrpition2.OptionsColumn.AllowEdit = False
        Me.colGSDescrpition2.OptionsColumn.AllowFocus = False
        Me.colGSDescrpition2.Visible = True
        Me.colGSDescrpition2.VisibleIndex = 2
        Me.colGSDescrpition2.Width = 173
        '
        'colGSDescriptionAr1
        '
        Me.colGSDescriptionAr1.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDescriptionAr1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDescriptionAr1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDescriptionAr1.FieldName = "GSDescriptionAr"
        Me.colGSDescriptionAr1.Name = "colGSDescriptionAr1"
        Me.colGSDescriptionAr1.Width = 24
        '
        'colAddlDescription
        '
        Me.colAddlDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddlDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddlDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddlDescription.FieldName = "AddlDescription"
        Me.colAddlDescription.Name = "colAddlDescription"
        Me.colAddlDescription.Width = 24
        '
        'colQuotedQuantity
        '
        Me.colQuotedQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuotedQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuotedQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuotedQuantity.Caption = "Quantity"
        Me.colQuotedQuantity.FieldName = "QuotedQuantity"
        Me.colQuotedQuantity.Name = "colQuotedQuantity"
        Me.colQuotedQuantity.OptionsColumn.AllowEdit = False
        Me.colQuotedQuantity.OptionsColumn.AllowFocus = False
        Me.colQuotedQuantity.Visible = True
        Me.colQuotedQuantity.VisibleIndex = 3
        '
        'colUnitRateMethod
        '
        Me.colUnitRateMethod.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitRateMethod.FieldName = "UnitRateMethod"
        Me.colUnitRateMethod.Name = "colUnitRateMethod"
        Me.colUnitRateMethod.Width = 24
        '
        'colUnitType1
        '
        Me.colUnitType1.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitType1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitType1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitType1.FieldName = "UnitType"
        Me.colUnitType1.Name = "colUnitType1"
        Me.colUnitType1.Width = 24
        '
        'colUnitDesc1
        '
        Me.colUnitDesc1.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitDesc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitDesc1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitDesc1.FieldName = "UnitDesc"
        Me.colUnitDesc1.Name = "colUnitDesc1"
        Me.colUnitDesc1.Width = 24
        '
        'colUnitPrice
        '
        Me.colUnitPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.OptionsColumn.AllowEdit = False
        Me.colUnitPrice.OptionsColumn.AllowFocus = False
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 4
        Me.colUnitPrice.Width = 60
        '
        'colItemDiscount
        '
        Me.colItemDiscount.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colItemDiscount.AppearanceCell.Options.UseBackColor = True
        Me.colItemDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemDiscount.DisplayFormat.FormatString = "n2"
        Me.colItemDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colItemDiscount.FieldName = "ItemDiscount"
        Me.colItemDiscount.Name = "colItemDiscount"
        Me.colItemDiscount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ItemDiscount", "{0:n2}")})
        Me.colItemDiscount.Visible = True
        Me.colItemDiscount.VisibleIndex = 6
        Me.colItemDiscount.Width = 86
        '
        'colPOTaxSlab
        '
        Me.colPOTaxSlab.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOTaxSlab.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOTaxSlab.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOTaxSlab.FieldName = "POTaxSlab"
        Me.colPOTaxSlab.Name = "colPOTaxSlab"
        Me.colPOTaxSlab.Width = 24
        '
        'colPOItemRemarks
        '
        Me.colPOItemRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOItemRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOItemRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOItemRemarks.FieldName = "POItemRemarks"
        Me.colPOItemRemarks.Name = "colPOItemRemarks"
        Me.colPOItemRemarks.Width = 24
        '
        'colLineOrderNo
        '
        Me.colLineOrderNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineOrderNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineOrderNo.FieldName = "LineOrderNo"
        Me.colLineOrderNo.Name = "colLineOrderNo"
        Me.colLineOrderNo.Width = 24
        '
        'colPurchaseTaxSlab
        '
        Me.colPurchaseTaxSlab.AppearanceHeader.Options.UseTextOptions = True
        Me.colPurchaseTaxSlab.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPurchaseTaxSlab.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPurchaseTaxSlab.FieldName = "PurchaseTaxSlab"
        Me.colPurchaseTaxSlab.Name = "colPurchaseTaxSlab"
        Me.colPurchaseTaxSlab.Width = 24
        '
        'colPurchaseTaxRate
        '
        Me.colPurchaseTaxRate.AppearanceHeader.Options.UseTextOptions = True
        Me.colPurchaseTaxRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPurchaseTaxRate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPurchaseTaxRate.FieldName = "PurchaseTaxRate"
        Me.colPurchaseTaxRate.Name = "colPurchaseTaxRate"
        Me.colPurchaseTaxRate.Width = 24
        '
        'colLineTotalBeforeTax
        '
        Me.colLineTotalBeforeTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalBeforeTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalBeforeTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalBeforeTax.Caption = "Total Before Discount"
        Me.colLineTotalBeforeTax.DisplayFormat.FormatString = "n2"
        Me.colLineTotalBeforeTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLineTotalBeforeTax.FieldName = "LineTotalBeforeTax"
        Me.colLineTotalBeforeTax.Name = "colLineTotalBeforeTax"
        Me.colLineTotalBeforeTax.OptionsColumn.AllowEdit = False
        Me.colLineTotalBeforeTax.OptionsColumn.AllowFocus = False
        Me.colLineTotalBeforeTax.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalBeforeTax", "{0:n2}")})
        Me.colLineTotalBeforeTax.Visible = True
        Me.colLineTotalBeforeTax.VisibleIndex = 5
        Me.colLineTotalBeforeTax.Width = 83
        '
        'colLineTotalAfterDisc
        '
        Me.colLineTotalAfterDisc.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalAfterDisc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalAfterDisc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalAfterDisc.Caption = "Total After Discount"
        Me.colLineTotalAfterDisc.DisplayFormat.FormatString = "n2"
        Me.colLineTotalAfterDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLineTotalAfterDisc.FieldName = "LineTotalAfterDisc"
        Me.colLineTotalAfterDisc.Name = "colLineTotalAfterDisc"
        Me.colLineTotalAfterDisc.OptionsColumn.AllowEdit = False
        Me.colLineTotalAfterDisc.OptionsColumn.AllowFocus = False
        Me.colLineTotalAfterDisc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalAfterDisc", "{0:n2}")})
        Me.colLineTotalAfterDisc.Visible = True
        Me.colLineTotalAfterDisc.VisibleIndex = 7
        Me.colLineTotalAfterDisc.Width = 83
        '
        'colLineTaxAmount
        '
        Me.colLineTaxAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTaxAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTaxAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTaxAmount.FieldName = "LineTaxAmount"
        Me.colLineTaxAmount.Name = "colLineTaxAmount"
        Me.colLineTaxAmount.Width = 24
        '
        'colLineTotalWithTax
        '
        Me.colLineTotalWithTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalWithTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalWithTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalWithTax.FieldName = "LineTotalWithTax"
        Me.colLineTotalWithTax.Name = "colLineTotalWithTax"
        Me.colLineTotalWithTax.Width = 24
        '
        'colOrderedQty
        '
        Me.colOrderedQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderedQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderedQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderedQty.FieldName = "OrderedQty"
        Me.colOrderedQty.Name = "colOrderedQty"
        Me.colOrderedQty.Width = 24
        '
        'colReceivedQty
        '
        Me.colReceivedQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceivedQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceivedQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceivedQty.FieldName = "ReceivedQty"
        Me.colReceivedQty.Name = "colReceivedQty"
        Me.colReceivedQty.Width = 24
        '
        'colBalanceToReceive
        '
        Me.colBalanceToReceive.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalanceToReceive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalanceToReceive.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBalanceToReceive.FieldName = "BalanceToReceive"
        Me.colBalanceToReceive.Name = "colBalanceToReceive"
        Me.colBalanceToReceive.Width = 24
        '
        'colPlanNo
        '
        Me.colPlanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlanNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPlanNo.FieldName = "PlanNo"
        Me.colPlanNo.Name = "colPlanNo"
        Me.colPlanNo.Width = 24
        '
        'colDeliveryPeriod
        '
        Me.colDeliveryPeriod.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveryPeriod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryPeriod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveryPeriod.FieldName = "DeliveryPeriod"
        Me.colDeliveryPeriod.Name = "colDeliveryPeriod"
        Me.colDeliveryPeriod.Width = 24
        '
        'colItemSize
        '
        Me.colItemSize.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemSize.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemSize.FieldName = "ItemSize"
        Me.colItemSize.Name = "colItemSize"
        Me.colItemSize.Width = 24
        '
        'colItemPartNo
        '
        Me.colItemPartNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemPartNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemPartNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemPartNo.FieldName = "ItemPartNo"
        Me.colItemPartNo.Name = "colItemPartNo"
        Me.colItemPartNo.Width = 24
        '
        'colItemBrand
        '
        Me.colItemBrand.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemBrand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemBrand.FieldName = "ItemBrand"
        Me.colItemBrand.Name = "colItemBrand"
        Me.colItemBrand.Width = 24
        '
        'colItemMake
        '
        Me.colItemMake.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemMake.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemMake.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemMake.FieldName = "ItemMake"
        Me.colItemMake.Name = "colItemMake"
        Me.colItemMake.Width = 24
        '
        'colHSCode1
        '
        Me.colHSCode1.AppearanceHeader.Options.UseTextOptions = True
        Me.colHSCode1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHSCode1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHSCode1.FieldName = "HSCode"
        Me.colHSCode1.Name = "colHSCode1"
        Me.colHSCode1.Width = 24
        '
        'colMRItemNo
        '
        Me.colMRItemNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colMRItemNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMRItemNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMRItemNo.FieldName = "MRItemNo"
        Me.colMRItemNo.Name = "colMRItemNo"
        Me.colMRItemNo.Width = 24
        '
        'colCurrency
        '
        Me.colCurrency.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrency.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrency.FieldName = "Currency"
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.Width = 24
        '
        'colExchangeRate
        '
        Me.colExchangeRate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExchangeRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExchangeRate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExchangeRate.FieldName = "ExchangeRate"
        Me.colExchangeRate.Name = "colExchangeRate"
        Me.colExchangeRate.Width = 24
        '
        'colUnitRateInOC
        '
        Me.colUnitRateInOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitRateInOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitRateInOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitRateInOC.FieldName = "UnitRateInOC"
        Me.colUnitRateInOC.Name = "colUnitRateInOC"
        Me.colUnitRateInOC.Width = 24
        '
        'colDiscountInOC
        '
        Me.colDiscountInOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiscountInOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiscountInOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiscountInOC.FieldName = "DiscountInOC"
        Me.colDiscountInOC.Name = "colDiscountInOC"
        Me.colDiscountInOC.Width = 24
        '
        'colCurrencyName
        '
        Me.colCurrencyName.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrencyName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrencyName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrencyName.FieldName = "CurrencyName"
        Me.colCurrencyName.Name = "colCurrencyName"
        Me.colCurrencyName.Width = 24
        '
        'colCurrencyNameAr
        '
        Me.colCurrencyNameAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrencyNameAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrencyNameAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrencyNameAr.FieldName = "CurrencyNameAr"
        Me.colCurrencyNameAr.Name = "colCurrencyNameAr"
        Me.colCurrencyNameAr.Width = 24
        '
        'colCurrencyCode
        '
        Me.colCurrencyCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrencyCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrencyCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrencyCode.FieldName = "CurrencyCode"
        Me.colCurrencyCode.Name = "colCurrencyCode"
        Me.colCurrencyCode.Width = 24
        '
        'colCurrencyCodeAr
        '
        Me.colCurrencyCodeAr.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrencyCodeAr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrencyCodeAr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrencyCodeAr.FieldName = "CurrencyCodeAr"
        Me.colCurrencyCodeAr.Name = "colCurrencyCodeAr"
        Me.colCurrencyCodeAr.Width = 24
        '
        'colLineTotalB4TaxOC
        '
        Me.colLineTotalB4TaxOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalB4TaxOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalB4TaxOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalB4TaxOC.FieldName = "LineTotalB4TaxOC"
        Me.colLineTotalB4TaxOC.Name = "colLineTotalB4TaxOC"
        Me.colLineTotalB4TaxOC.Width = 24
        '
        'colLineTotalAfterDiscOC
        '
        Me.colLineTotalAfterDiscOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalAfterDiscOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalAfterDiscOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalAfterDiscOC.FieldName = "LineTotalAfterDiscOC"
        Me.colLineTotalAfterDiscOC.Name = "colLineTotalAfterDiscOC"
        Me.colLineTotalAfterDiscOC.Width = 20
        '
        'colLineTaxAmountOC
        '
        Me.colLineTaxAmountOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTaxAmountOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTaxAmountOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTaxAmountOC.FieldName = "LineTaxAmountOC"
        Me.colLineTaxAmountOC.Name = "colLineTaxAmountOC"
        Me.colLineTaxAmountOC.Width = 34
        '
        'colLineTotalWithTaxOC
        '
        Me.colLineTotalWithTaxOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalWithTaxOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalWithTaxOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalWithTaxOC.FieldName = "LineTotalWithTaxOC"
        Me.colLineTotalWithTaxOC.Name = "colLineTotalWithTaxOC"
        '
        'repoDetailedDescription
        '
        Me.repoDetailedDescription.AutoHeight = False
        ToolTipTitleItem1.Text = "Edit Stock Details (Simple)"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Click here to edit the Stock Item Details"
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "QuickDice ERP Solutions"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        ToolTipTitleItem3.Text = "Edit Stock Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Click here to edit the Stock Item Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem4.LeftIndent = 6
        ToolTipTitleItem4.Text = "QuickDice ERP Solutions"
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        SuperToolTip2.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip2.Items.Add(ToolTipTitleItem4)
        Me.repoDetailedDescription.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("repoDetailedDescription.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.ERP.My.Resources.Resources.DailyRpt16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, SuperToolTip1, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("repoDetailedDescription.Buttons1"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, SuperToolTip2, True)})
        Me.repoDetailedDescription.DisplayMember = "GSDescrpition"
        Me.repoDetailedDescription.Name = "repoDetailedDescription"
        Me.repoDetailedDescription.NullText = "<Select an Item / Service >"
        Me.repoDetailedDescription.PopupFormSize = New System.Drawing.Size(1000, 0)
        Me.repoDetailedDescription.ValueMember = "GSCode"
        Me.repoDetailedDescription.View = Me.gvGSList
        '
        'gvGSList
        '
        Me.gvGSList.ColumnPanelRowHeight = 30
        Me.gvGSList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGSCode, Me.colGSDescrpition, Me.colGSDescriptionAr, Me.colGSDetailedDesc, Me.colGSDetailedDescAr, Me.colGSGroupID, Me.colHSCode})
        Me.gvGSList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvGSList.Name = "gvGSList"
        Me.gvGSList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvGSList.OptionsView.ShowAutoFilterRow = True
        Me.gvGSList.OptionsView.ShowGroupPanel = False
        Me.gvGSList.RowHeight = 30
        '
        'colGSCode
        '
        Me.colGSCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSCode.AppearanceHeader.Options.UseFont = True
        Me.colGSCode.Caption = "Code"
        Me.colGSCode.FieldName = "GSCode"
        Me.colGSCode.Name = "colGSCode"
        Me.colGSCode.Visible = True
        Me.colGSCode.VisibleIndex = 0
        Me.colGSCode.Width = 184
        '
        'colGSDescrpition
        '
        Me.colGSDescrpition.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSDescrpition.AppearanceHeader.Options.UseFont = True
        Me.colGSDescrpition.Caption = "Description"
        Me.colGSDescrpition.FieldName = "GSDescrpition"
        Me.colGSDescrpition.Name = "colGSDescrpition"
        Me.colGSDescrpition.Visible = True
        Me.colGSDescrpition.VisibleIndex = 1
        Me.colGSDescrpition.Width = 638
        '
        'colGSDescriptionAr
        '
        Me.colGSDescriptionAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSDescriptionAr.AppearanceHeader.Options.UseFont = True
        Me.colGSDescriptionAr.Caption = "Description In Arabic"
        Me.colGSDescriptionAr.FieldName = "GSDescriptionAr"
        Me.colGSDescriptionAr.Name = "colGSDescriptionAr"
        Me.colGSDescriptionAr.Width = 463
        '
        'colGSDetailedDesc
        '
        Me.colGSDetailedDesc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSDetailedDesc.AppearanceHeader.Options.UseFont = True
        Me.colGSDetailedDesc.FieldName = "GSDetailedDesc"
        Me.colGSDetailedDesc.Name = "colGSDetailedDesc"
        '
        'colGSDetailedDescAr
        '
        Me.colGSDetailedDescAr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSDetailedDescAr.AppearanceHeader.Options.UseFont = True
        Me.colGSDetailedDescAr.FieldName = "GSDetailedDescAr"
        Me.colGSDetailedDescAr.Name = "colGSDetailedDescAr"
        '
        'colGSGroupID
        '
        Me.colGSGroupID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSGroupID.AppearanceHeader.Options.UseFont = True
        Me.colGSGroupID.FieldName = "GSGroupID"
        Me.colGSGroupID.Name = "colGSGroupID"
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
        Me.colHSCode.Visible = True
        Me.colHSCode.VisibleIndex = 2
        Me.colHSCode.Width = 250
        '
        'repoQtyInvoiced
        '
        Me.repoQtyInvoiced.AutoHeight = False
        Me.repoQtyInvoiced.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoQtyInvoiced.DisplayFormat.FormatString = "######0.####"
        Me.repoQtyInvoiced.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoQtyInvoiced.EditFormat.FormatString = "######0.####"
        Me.repoQtyInvoiced.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoQtyInvoiced.Mask.EditMask = "######0.####"
        Me.repoQtyInvoiced.Name = "repoQtyInvoiced"
        '
        'repoUnitRateMethod
        '
        Me.repoUnitRateMethod.AutoHeight = False
        Me.repoUnitRateMethod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("repoUnitRateMethod.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.repoUnitRateMethod.DisplayMember = "UnitType"
        Me.repoUnitRateMethod.Name = "repoUnitRateMethod"
        Me.repoUnitRateMethod.NullText = ""
        Me.repoUnitRateMethod.ValueMember = "UnitCode"
        Me.repoUnitRateMethod.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 35
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode, Me.colUnitType, Me.colUnitDesc})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 35
        '
        'colUnitCode
        '
        Me.colUnitCode.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitCode.AppearanceHeader.Options.UseFont = True
        Me.colUnitCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitCode.Caption = "Code"
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 0
        Me.colUnitCode.Width = 172
        '
        'colUnitType
        '
        Me.colUnitType.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitType.AppearanceHeader.Options.UseFont = True
        Me.colUnitType.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitType.Caption = "Unit Method"
        Me.colUnitType.FieldName = "UnitType"
        Me.colUnitType.Name = "colUnitType"
        Me.colUnitType.Visible = True
        Me.colUnitType.VisibleIndex = 1
        Me.colUnitType.Width = 906
        '
        'colUnitDesc
        '
        Me.colUnitDesc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitDesc.AppearanceHeader.Options.UseFont = True
        Me.colUnitDesc.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitDesc.FieldName = "UnitDesc"
        Me.colUnitDesc.Name = "colUnitDesc"
        '
        'repoEditUnitRate
        '
        Me.repoEditUnitRate.AutoHeight = False
        Me.repoEditUnitRate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoEditUnitRate.DisplayFormat.FormatString = "#######0.####"
        Me.repoEditUnitRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoEditUnitRate.EditFormat.FormatString = "#######0.####"
        Me.repoEditUnitRate.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoEditUnitRate.Mask.EditMask = "#######0.####"
        Me.repoEditUnitRate.Name = "repoEditUnitRate"
        '
        'repoPopupAdditionalColumns
        '
        Me.repoPopupAdditionalColumns.AutoHeight = False
        Me.repoPopupAdditionalColumns.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("repoPopupAdditionalColumns.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.repoPopupAdditionalColumns.Name = "repoPopupAdditionalColumns"
        Me.repoPopupAdditionalColumns.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'repoEditTaxSlab
        '
        Me.repoEditTaxSlab.AutoHeight = False
        Me.repoEditTaxSlab.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoEditTaxSlab.DisplayMember = "TaxSlab"
        Me.repoEditTaxSlab.Name = "repoEditTaxSlab"
        Me.repoEditTaxSlab.NullText = "<Select VAT Category>"
        Me.repoEditTaxSlab.ValueMember = "TaxSlabCode"
        Me.repoEditTaxSlab.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTaxSlabCode1, Me.colTaxSlab, Me.colTaxSlabAr, Me.colTaxRate, Me.colTaxCategoryID2, Me.colTaxCategory2, Me.colTaxCategoryAr2})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colTaxSlabCode1
        '
        Me.colTaxSlabCode1.FieldName = "TaxSlabCode"
        Me.colTaxSlabCode1.Name = "colTaxSlabCode1"
        Me.colTaxSlabCode1.Width = 81
        '
        'colTaxSlab
        '
        Me.colTaxSlab.FieldName = "TaxSlab"
        Me.colTaxSlab.Name = "colTaxSlab"
        Me.colTaxSlab.Visible = True
        Me.colTaxSlab.VisibleIndex = 0
        Me.colTaxSlab.Width = 912
        '
        'colTaxSlabAr
        '
        Me.colTaxSlabAr.FieldName = "TaxSlabAr"
        Me.colTaxSlabAr.Name = "colTaxSlabAr"
        Me.colTaxSlabAr.Width = 191
        '
        'colTaxRate
        '
        Me.colTaxRate.FieldName = "TaxRate"
        Me.colTaxRate.Name = "colTaxRate"
        Me.colTaxRate.Visible = True
        Me.colTaxRate.VisibleIndex = 1
        Me.colTaxRate.Width = 166
        '
        'colTaxCategoryID2
        '
        Me.colTaxCategoryID2.FieldName = "TaxCategoryID"
        Me.colTaxCategoryID2.Name = "colTaxCategoryID2"
        Me.colTaxCategoryID2.Width = 191
        '
        'colTaxCategory2
        '
        Me.colTaxCategory2.FieldName = "TaxCategory"
        Me.colTaxCategory2.Name = "colTaxCategory2"
        Me.colTaxCategory2.Width = 191
        '
        'colTaxCategoryAr2
        '
        Me.colTaxCategoryAr2.FieldName = "TaxCategoryAr"
        Me.colTaxCategoryAr2.Name = "colTaxCategoryAr2"
        Me.colTaxCategoryAr2.Width = 201
        '
        'repoPopupCalculateDiscount
        '
        Me.repoPopupCalculateDiscount.AutoHeight = False
        Me.repoPopupCalculateDiscount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("repoPopupCalculateDiscount.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.repoPopupCalculateDiscount.Name = "repoPopupCalculateDiscount"
        Me.repoPopupCalculateDiscount.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'repoUnitPriceOC
        '
        Me.repoUnitPriceOC.AutoHeight = False
        Me.repoUnitPriceOC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoUnitPriceOC.Name = "repoUnitPriceOC"
        '
        'repoDiscountOC
        '
        Me.repoDiscountOC.AutoHeight = False
        Me.repoDiscountOC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoDiscountOC.Name = "repoDiscountOC"
        '
        'repoCostDetails
        '
        Me.repoCostDetails.AutoHeight = False
        Me.repoCostDetails.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("repoCostDetails.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject7, "", Nothing, Nothing, True)})
        Me.repoCostDetails.Name = "repoCostDetails"
        Me.repoCostDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem3, "", True, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPrint, "", True, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem5, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Back"
        Me.btnClose.Glyph = Global.ERP.My.Resources.Resources.GoBackBlue24x24
        Me.btnClose.Id = 70
        Me.btnClose.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ItemAppearance.Normal.Options.UseFont = True
        Me.btnClose.Name = "btnClose"
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
        Me.btnResetLayout.Id = 59
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
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Distribute Cost"
        Me.BarSubItem5.Glyph = CType(resources.GetObject("BarSubItem5.Glyph"), System.Drawing.Image)
        Me.BarSubItem5.Id = 65
        Me.BarSubItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.BarSubItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDistributeEqually), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDistributeByProportionately, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDistributeByPercentage, True)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'btnDistributeEqually
        '
        Me.btnDistributeEqually.Caption = "Distribute Cost Equally"
        Me.btnDistributeEqually.Glyph = CType(resources.GetObject("btnDistributeEqually.Glyph"), System.Drawing.Image)
        Me.btnDistributeEqually.Id = 66
        Me.btnDistributeEqually.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnDistributeEqually.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDistributeEqually.Name = "btnDistributeEqually"
        '
        'btnDistributeByProportionately
        '
        Me.btnDistributeByProportionately.Caption = "Distribute Cost Proportionately"
        Me.btnDistributeByProportionately.Glyph = CType(resources.GetObject("btnDistributeByProportionately.Glyph"), System.Drawing.Image)
        Me.btnDistributeByProportionately.Id = 67
        Me.btnDistributeByProportionately.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnDistributeByProportionately.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDistributeByProportionately.Name = "btnDistributeByProportionately"
        '
        'btnDistributeByPercentage
        '
        Me.btnDistributeByPercentage.Caption = "Distribute Cost By Percentage"
        Me.btnDistributeByPercentage.Glyph = CType(resources.GetObject("btnDistributeByPercentage.Glyph"), System.Drawing.Image)
        Me.btnDistributeByPercentage.Id = 68
        Me.btnDistributeByPercentage.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnDistributeByPercentage.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDistributeByPercentage.Name = "btnDistributeByPercentage"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "GUid"
        Me.BarButtonItem6.Id = 71
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPrint, Me.btnAddNewAlert, Me.btnEditQuote, Me.btnShowRecords2, Me.btnNewSystemAlert, Me.btnNewAlert, Me.btnNewReminder, Me.btnNewAssignment, Me.btnApprove, Me.btnViewVoucher, Me.btnAddNewPR, Me.btnRptPR, Me.BarButtonItem1, Me.btnViewServiceRequest, Me.btnNewRequest, Me.btnVerify, Me.btnDeleteQuote, Me.btnShowMyRequests, Me.btnChooseVoucher, Me.btnChooseVouchers, Me.btnPaymentVouchers, Me.btnReceiptVouchers, Me.btnSalesVouchers, Me.btnPurchasesVouchers, Me.btnJournalVouchers, Me.btnAllVoucherTypes, Me.btnToday, Me.btnYesterday, Me.btnThisWeek, Me.BarButtonItem5, Me.btnThisYear, Me.btnThisMonthFull, Me.btnThisYearTillDate, Me.btnThisMonthTillDate, Me.btnLastYear, Me.btnLastMonth, Me.BarSubItem1, Me.BarButtonItem2, Me.btnAddNewInvoice, Me.btnPreviewInvoice, Me.btnTaxSummaryReport, Me.btnUnlockInvoice, Me.btnTaxReport, Me.BarSubItem2, Me.BarSubItem3, Me.btnSaveLayout, Me.btnOpenLayout, Me.btnSetDefaultLayout, Me.BarSubItem4, Me.btnBy1stQuarter, Me.btnBy2ndQuarter, Me.btnBy3rdQuarter, Me.btnBy4thQuarter, Me.btnDuplicateInvoice, Me.btnResetLayout, Me.btnDistributeByEqually, Me.btnDistributeByProportion, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarEditItem1, Me.BarSubItem5, Me.btnDistributeEqually, Me.btnDistributeByProportionately, Me.btnDistributeByPercentage, Me.btnProfitByPercentage, Me.btnClose, Me.BarButtonItem6})
        Me.BarManager1.MaxItemId = 72
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(898, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 370)
        Me.barDockControlBottom.Size = New System.Drawing.Size(898, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 370)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(898, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 370)
        '
        'DockManager1
        '
        Me.DockManager1.Controller = Me.BarAndDockingController1
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.BarAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
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
        'btnNewReminder
        '
        Me.btnNewReminder.Caption = "New Reminder"
        Me.btnNewReminder.Glyph = CType(resources.GetObject("btnNewReminder.Glyph"), System.Drawing.Image)
        Me.btnNewReminder.Id = 8
        Me.btnNewReminder.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewReminder.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNewReminder.Name = "btnNewReminder"
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
        'btnYesterday
        '
        Me.btnYesterday.Caption = "Yesterday"
        Me.btnYesterday.Glyph = CType(resources.GetObject("btnYesterday.Glyph"), System.Drawing.Image)
        Me.btnYesterday.Id = 30
        Me.btnYesterday.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnYesterday.ItemAppearance.Normal.Options.UseFont = True
        Me.btnYesterday.Name = "btnYesterday"
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
        'btnDistributeByEqually
        '
        Me.btnDistributeByEqually.Caption = "Distribute Cost Equally"
        Me.btnDistributeByEqually.Glyph = CType(resources.GetObject("btnDistributeByEqually.Glyph"), System.Drawing.Image)
        Me.btnDistributeByEqually.Id = 60
        Me.btnDistributeByEqually.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnDistributeByEqually.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDistributeByEqually.Name = "btnDistributeByEqually"
        '
        'btnDistributeByProportion
        '
        Me.btnDistributeByProportion.Caption = "Distribute Cost Proportionately"
        Me.btnDistributeByProportion.Glyph = CType(resources.GetObject("btnDistributeByProportion.Glyph"), System.Drawing.Image)
        Me.btnDistributeByProportion.Id = 61
        Me.btnDistributeByProportion.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnDistributeByProportion.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDistributeByProportion.Name = "btnDistributeByProportion"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Distribute Cost Equally"
        Me.BarButtonItem3.Id = 62
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Distribute Cost Proportionately"
        Me.BarButtonItem4.Id = 63
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.Id = 64
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'btnProfitByPercentage
        '
        Me.btnProfitByPercentage.Caption = "Add Profit Margin By Percentage"
        Me.btnProfitByPercentage.Id = 69
        Me.btnProfitByPercentage.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnProfitByPercentage.ItemAppearance.Normal.Options.UseFont = True
        Me.btnProfitByPercentage.Name = "btnProfitByPercentage"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDistributeByEqually), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDistributeByProportion, True)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Csv.Separator = ";"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'Qry604_02PurchaseOrderChildTableAdapter
        '
        Me.Qry604_02PurchaseOrderChildTableAdapter.ClearBeforeFill = True
        '
        'frm601_38PODiscountDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 413)
        Me.Controls.Add(Me.gcInvoiceChild)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm601_38PODiscountDistribution"
        Me.Text = "Purchase Order : Discount Distribution to Items"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtCostAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostPercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcInvoiceChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60402PurchaseOrderChildBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_38PODiscountDistribution, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInvoiceChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDetailedDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvGSList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoQtyInvoiced, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoUnitRateMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoEditUnitRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopupAdditionalColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoEditTaxSlab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopupCalculateDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoUnitPriceOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDiscountOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoCostDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCostAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCostPercentage As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents gcInvoiceChild As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvInvoiceChild As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents repoDetailedDescription As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gvGSList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGSCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDescrpition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDescriptionAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDetailedDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDetailedDescAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSGroupID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHSCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoQtyInvoiced As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents repoUnitRateMethod As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoEditUnitRate As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents repoPopupAdditionalColumns As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents repoEditTaxSlab As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTaxSlabCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaxSlab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaxSlabAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaxRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaxCategoryID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaxCategory2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaxCategoryAr2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoPopupCalculateDiscount As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents repoUnitPriceOC As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents repoDiscountOC As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents repoCostDetails As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOpenLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSetDefaultLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnDistributeEqually As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDistributeByProportionately As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDistributeByPercentage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
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
    Friend WithEvents btnToday As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnYesterday As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThisWeek As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents btnDistributeByEqually As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDistributeByProportion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnProfitByPercentage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Qry60402PurchaseOrderChildBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dsfrm601_38PODiscountDistribution As ERP.dsfrm601_38PODiscountDistribution
    Friend WithEvents colPOChildNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPONo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSCode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDescrpition2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDescriptionAr1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddlDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuotedQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitRateMethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitDesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOTaxSlab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOItemRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseTaxSlab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseTaxRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineTotalBeforeTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineTotalAfterDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineTaxAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineTotalWithTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalanceToReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryPeriod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemPartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemMake As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHSCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRItemNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExchangeRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitRateInOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscountInOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrencyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrencyNameAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrencyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrencyCodeAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineTotalB4TaxOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineTotalAfterDiscOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineTaxAmountOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineTotalWithTaxOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qry604_02PurchaseOrderChildTableAdapter As ERP.dsfrm601_38PODiscountDistributionTableAdapters.qry604_02PurchaseOrderChildTableAdapter
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
End Class
