<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm601_15QuotationAnalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm601_15QuotationAnalysis))
        Dim PivotGridFormatRule1 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim FormatRuleTotalTypeSettings1 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Me.fieldIsWonForPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.repoIsWon = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnViewAnalysis = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMPRNo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Qry60707RFQIssuedByMPRNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_15QuotationAnalysis1 = New ERP.dsfrm601_15QuotationAnalysis()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCostAllocationUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostAllocationGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMPRDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientNameOrStoreName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.pvgQuotationAnalysis = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.Qry60708QuotationAnalysisPVGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_15QuotationAnalysis = New ERP.dsfrm601_15QuotationAnalysis()
        Me.fieldRFQNo1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRFQDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMPRNo1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSupplierCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSupplierName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGSCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGSDescrpition1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnitDesc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQuotedQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnitPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLineTotalBeforeTax1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldItemDiscount1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLineTotalAfterDisc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRFQChildSlNo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldReasonForSelection = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.Qry607_08QuotationAnalysisPVGTableAdapter = New ERP.dsfrm601_15QuotationAnalysisTableAdapters.qry607_08QuotationAnalysisPVGTableAdapter()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOpenLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnResetLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSetDefaultLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGroup = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCreateQuotation = New DevExpress.XtraBars.BarButtonItem()
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
        Me.btnPreviewQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTaxSummaryReport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnlockInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTaxReport = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.btnBy1stQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy2ndQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy3rdQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBy4thQuarter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReviseQuotation = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditRFQ = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditRFQ2 = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Qry607_07RFQIssuedByMPRNoTableAdapter = New ERP.dsfrm601_15QuotationAnalysisTableAdapters.qry607_07RFQIssuedByMPRNoTableAdapter()
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.pageUpdateStatus = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtReasonForSelection02 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnBulkUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCloseMultiUpdates = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.repoIsWon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtMPRNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60707RFQIssuedByMPRNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_15QuotationAnalysis1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pvgQuotationAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60708QuotationAnalysisPVGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_15QuotationAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.pageUpdateStatus.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtReasonForSelection02.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldIsWonForPO
        '
        Me.fieldIsWonForPO.Appearance.Cell.Options.UseTextOptions = True
        Me.fieldIsWonForPO.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldIsWonForPO.Appearance.CellTotal.Options.UseTextOptions = True
        Me.fieldIsWonForPO.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldIsWonForPO.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldIsWonForPO.Appearance.Header.Options.UseFont = True
        Me.fieldIsWonForPO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldIsWonForPO.AreaIndex = 4
        Me.fieldIsWonForPO.Caption = "Won"
        Me.fieldIsWonForPO.FieldEdit = Me.repoIsWon
        Me.fieldIsWonForPO.FieldName = "IsWonForPO"
        Me.fieldIsWonForPO.MinWidth = 17
        Me.fieldIsWonForPO.Name = "fieldIsWonForPO"
        Me.fieldIsWonForPO.Options.AllowEdit = False
        Me.fieldIsWonForPO.Options.ShowGrandTotal = False
        Me.fieldIsWonForPO.Options.ShowTotals = False
        Me.fieldIsWonForPO.RowValueLineCount = 2
        Me.fieldIsWonForPO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldIsWonForPO.Width = 31
        '
        'repoIsWon
        '
        Me.repoIsWon.AutoHeight = False
        Me.repoIsWon.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repoIsWon.Name = "repoIsWon"
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
        Me.PanelControl1.Size = New System.Drawing.Size(19, 405)
        Me.PanelControl1.TabIndex = 119
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label5.Location = New System.Drawing.Point(19, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(921, 25)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Business Intelligence Reporting : Quotation Analysis"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Appearance.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Controls.Add(Me.btnViewAnalysis)
        Me.PanelControl2.Controls.Add(Me.txtMPRNo)
        Me.PanelControl2.Controls.Add(Me.LabelControl22)
        Me.PanelControl2.Location = New System.Drawing.Point(20, 28)
        Me.PanelControl2.LookAndFeel.SkinName = "VS2010"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(919, 68)
        Me.PanelControl2.TabIndex = 121
        '
        'btnViewAnalysis
        '
        Me.btnViewAnalysis.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnViewAnalysis.Appearance.Options.UseFont = True
        Me.btnViewAnalysis.ImageOptions.SvgImage = CType(resources.GetObject("btnViewAnalysis.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnViewAnalysis.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
        Me.btnViewAnalysis.Location = New System.Drawing.Point(470, 16)
        Me.btnViewAnalysis.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btnViewAnalysis.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnViewAnalysis.Name = "btnViewAnalysis"
        Me.btnViewAnalysis.Size = New System.Drawing.Size(149, 40)
        Me.btnViewAnalysis.TabIndex = 79
        Me.btnViewAnalysis.Text = "View Analysis"
        '
        'txtMPRNo
        '
        Me.txtMPRNo.EnterMoveNextControl = True
        Me.txtMPRNo.Location = New System.Drawing.Point(8, 31)
        Me.txtMPRNo.Name = "txtMPRNo"
        Me.txtMPRNo.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue
        Me.txtMPRNo.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtMPRNo.Properties.Appearance.Options.UseBackColor = True
        Me.txtMPRNo.Properties.Appearance.Options.UseFont = True
        Me.txtMPRNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMPRNo.Properties.DataSource = Me.Qry60707RFQIssuedByMPRNoBindingSource
        Me.txtMPRNo.Properties.DisplayMember = "MPRNo"
        Me.txtMPRNo.Properties.ImmediatePopup = True
        Me.txtMPRNo.Properties.NullText = ""
        Me.txtMPRNo.Properties.PopupFormSize = New System.Drawing.Size(1029, 0)
        Me.txtMPRNo.Properties.PopupView = Me.GridView2
        Me.txtMPRNo.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSuggest
        Me.txtMPRNo.Properties.ValueMember = "MPRNo"
        Me.txtMPRNo.Size = New System.Drawing.Size(456, 24)
        Me.txtMPRNo.TabIndex = 78
        '
        'Qry60707RFQIssuedByMPRNoBindingSource
        '
        Me.Qry60707RFQIssuedByMPRNoBindingSource.DataMember = "qry607_07RFQIssuedByMPRNo"
        Me.Qry60707RFQIssuedByMPRNoBindingSource.DataSource = Me.Dsfrm601_15QuotationAnalysis1
        '
        'Dsfrm601_15QuotationAnalysis1
        '
        Me.Dsfrm601_15QuotationAnalysis1.DataSetName = "dsfrm601_15QuotationAnalysis"
        Me.Dsfrm601_15QuotationAnalysis1.EnforceConstraints = False
        Me.Dsfrm601_15QuotationAnalysis1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.GridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GridView2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple
        Me.GridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray
        Me.GridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridView2.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.Preview.ForeColor = System.Drawing.Color.Purple
        Me.GridView2.Appearance.Preview.Options.UseBackColor = True
        Me.GridView2.Appearance.Preview.Options.UseForeColor = True
        Me.GridView2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.Row.Options.UseBackColor = True
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.VertLine.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView2.ColumnPanelRowHeight = 45
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCostAllocationUnit, Me.colCostAllocationGroup, Me.colClientName, Me.colClientRefNo, Me.colMPRDate, Me.colRequestedBy, Me.colClientNameOrStoreName})
        Me.GridView2.DetailHeight = 284
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GroupRowHeight = 28
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.RowHeight = 28
        Me.GridView2.RowSeparatorHeight = 1
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCostAllocationGroup, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCostAllocationUnit
        '
        Me.colCostAllocationUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostAllocationUnit.AppearanceHeader.Options.UseFont = True
        Me.colCostAllocationUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostAllocationUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostAllocationUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCostAllocationUnit.Caption = "Request / Enquiry No:"
        Me.colCostAllocationUnit.FieldName = "MPRNo"
        Me.colCostAllocationUnit.MinWidth = 17
        Me.colCostAllocationUnit.Name = "colCostAllocationUnit"
        Me.colCostAllocationUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCostAllocationUnit.Visible = True
        Me.colCostAllocationUnit.VisibleIndex = 0
        Me.colCostAllocationUnit.Width = 196
        '
        'colCostAllocationGroup
        '
        Me.colCostAllocationGroup.AppearanceCell.Options.UseTextOptions = True
        Me.colCostAllocationGroup.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostAllocationGroup.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostAllocationGroup.AppearanceHeader.Options.UseFont = True
        Me.colCostAllocationGroup.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostAllocationGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostAllocationGroup.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCostAllocationGroup.Caption = "No of RFQ Issued"
        Me.colCostAllocationGroup.FieldName = "NoOfRFQIssued"
        Me.colCostAllocationGroup.MinWidth = 17
        Me.colCostAllocationGroup.Name = "colCostAllocationGroup"
        Me.colCostAllocationGroup.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCostAllocationGroup.Visible = True
        Me.colCostAllocationGroup.VisibleIndex = 1
        Me.colCostAllocationGroup.Width = 74
        '
        'colClientName
        '
        Me.colClientName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientName.AppearanceHeader.Options.UseFont = True
        Me.colClientName.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientName.FieldName = "ClientName"
        Me.colClientName.MinWidth = 17
        Me.colClientName.Name = "colClientName"
        Me.colClientName.Width = 252
        '
        'colClientRefNo
        '
        Me.colClientRefNo.AppearanceCell.Options.UseTextOptions = True
        Me.colClientRefNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientRefNo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientRefNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientRefNo.AppearanceHeader.Options.UseFont = True
        Me.colClientRefNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientRefNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientRefNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientRefNo.FieldName = "ClientRefNo"
        Me.colClientRefNo.MinWidth = 17
        Me.colClientRefNo.Name = "colClientRefNo"
        Me.colClientRefNo.Visible = True
        Me.colClientRefNo.VisibleIndex = 3
        Me.colClientRefNo.Width = 267
        '
        'colMPRDate
        '
        Me.colMPRDate.AppearanceCell.Options.UseTextOptions = True
        Me.colMPRDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMPRDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMPRDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMPRDate.AppearanceHeader.Options.UseFont = True
        Me.colMPRDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colMPRDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMPRDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMPRDate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colMPRDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colMPRDate.FieldName = "MPRDate"
        Me.colMPRDate.MinWidth = 17
        Me.colMPRDate.Name = "colMPRDate"
        Me.colMPRDate.Visible = True
        Me.colMPRDate.VisibleIndex = 4
        Me.colMPRDate.Width = 163
        '
        'colRequestedBy
        '
        Me.colRequestedBy.AppearanceCell.Options.UseTextOptions = True
        Me.colRequestedBy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRequestedBy.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRequestedBy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRequestedBy.AppearanceHeader.Options.UseFont = True
        Me.colRequestedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colRequestedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRequestedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRequestedBy.FieldName = "RequestedBy"
        Me.colRequestedBy.MinWidth = 17
        Me.colRequestedBy.Name = "colRequestedBy"
        Me.colRequestedBy.Visible = True
        Me.colRequestedBy.VisibleIndex = 5
        Me.colRequestedBy.Width = 227
        '
        'colClientNameOrStoreName
        '
        Me.colClientNameOrStoreName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientNameOrStoreName.AppearanceHeader.Options.UseFont = True
        Me.colClientNameOrStoreName.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientNameOrStoreName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientNameOrStoreName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientNameOrStoreName.FieldName = "ClientNameOrStoreName"
        Me.colClientNameOrStoreName.MinWidth = 17
        Me.colClientNameOrStoreName.Name = "colClientNameOrStoreName"
        Me.colClientNameOrStoreName.Visible = True
        Me.colClientNameOrStoreName.VisibleIndex = 2
        Me.colClientNameOrStoreName.Width = 435
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseForeColor = True
        Me.LabelControl22.Location = New System.Drawing.Point(11, 13)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(147, 14)
        Me.LabelControl22.TabIndex = 77
        Me.LabelControl22.Text = "Select a Request / Enquiry:"
        '
        'pvgQuotationAnalysis
        '
        Me.pvgQuotationAnalysis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pvgQuotationAnalysis.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.pvgQuotationAnalysis.Appearance.FieldValueGrandTotal.Options.UseFont = True
        Me.pvgQuotationAnalysis.Appearance.FieldValueGrandTotal.Options.UseTextOptions = True
        Me.pvgQuotationAnalysis.Appearance.FieldValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pvgQuotationAnalysis.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.pvgQuotationAnalysis.DataSource = Me.Qry60708QuotationAnalysisPVGBindingSource
        Me.pvgQuotationAnalysis.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldRFQNo1, Me.fieldRFQDate1, Me.fieldMPRNo1, Me.fieldSupplierCode1, Me.fieldSupplierName1, Me.fieldGSCode1, Me.fieldGSDescrpition1, Me.fieldUnitDesc1, Me.fieldQuotedQuantity1, Me.fieldUnitPrice1, Me.fieldLineTotalBeforeTax1, Me.fieldItemDiscount1, Me.fieldLineTotalAfterDisc1, Me.fieldRFQChildSlNo, Me.fieldIsWonForPO, Me.fieldReasonForSelection})
        PivotGridFormatRule1.Measure = Me.fieldIsWonForPO
        PivotGridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = True
        PivotGridFormatRule1.Rule = FormatConditionRuleValue1
        PivotGridFormatRule1.Settings = FormatRuleTotalTypeSettings1
        Me.pvgQuotationAnalysis.FormatRules.Add(PivotGridFormatRule1)
        Me.pvgQuotationAnalysis.Location = New System.Drawing.Point(21, 100)
        Me.pvgQuotationAnalysis.LookAndFeel.SkinName = "VS2010"
        Me.pvgQuotationAnalysis.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pvgQuotationAnalysis.Name = "pvgQuotationAnalysis"
        Me.pvgQuotationAnalysis.OptionsDataField.RowHeaderWidth = 86
        Me.pvgQuotationAnalysis.OptionsDataField.RowValueLineCount = 2
        Me.pvgQuotationAnalysis.OptionsLayout.Columns.StoreAllOptions = True
        Me.pvgQuotationAnalysis.OptionsLayout.Columns.StoreAppearance = True
        Me.pvgQuotationAnalysis.OptionsLayout.StoreAllOptions = True
        Me.pvgQuotationAnalysis.OptionsLayout.StoreAppearance = True
        Me.pvgQuotationAnalysis.OptionsLayout.StoreFormatRules = True
        Me.pvgQuotationAnalysis.OptionsLayout.StoreLayoutOptions = True
        Me.pvgQuotationAnalysis.OptionsMenu.EnableFormatRulesMenu = True
        Me.pvgQuotationAnalysis.OptionsPrint.PageSettings.Landscape = True
        Me.pvgQuotationAnalysis.OptionsPrint.PageSettings.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.pvgQuotationAnalysis.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.pvgQuotationAnalysis.OptionsPrint.UsePrintAppearance = True
        Me.pvgQuotationAnalysis.OptionsView.RowTreeOffset = 18
        Me.pvgQuotationAnalysis.OptionsView.RowTreeWidth = 86
        Me.pvgQuotationAnalysis.OptionsView.ShowColumnGrandTotalHeader = False
        Me.pvgQuotationAnalysis.OptionsView.ShowColumnGrandTotals = False
        Me.pvgQuotationAnalysis.OptionsView.ShowColumnTotals = False
        Me.pvgQuotationAnalysis.OptionsView.ShowDataHeaders = False
        Me.pvgQuotationAnalysis.OptionsView.ShowFilterHeaders = False
        Me.pvgQuotationAnalysis.OptionsView.ShowRowGrandTotals = False
        Me.pvgQuotationAnalysis.OptionsView.ShowRowTotals = False
        Me.pvgQuotationAnalysis.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoIsWon})
        Me.pvgQuotationAnalysis.Size = New System.Drawing.Size(918, 302)
        Me.pvgQuotationAnalysis.TabIndex = 122
        '
        'Qry60708QuotationAnalysisPVGBindingSource
        '
        Me.Qry60708QuotationAnalysisPVGBindingSource.DataMember = "qry607_08QuotationAnalysisPVG"
        Me.Qry60708QuotationAnalysisPVGBindingSource.DataSource = Me.Dsfrm601_15QuotationAnalysis
        '
        'Dsfrm601_15QuotationAnalysis
        '
        Me.Dsfrm601_15QuotationAnalysis.DataSetName = "dsfrm601_15QuotationAnalysis"
        Me.Dsfrm601_15QuotationAnalysis.EnforceConstraints = False
        Me.Dsfrm601_15QuotationAnalysis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldRFQNo1
        '
        Me.fieldRFQNo1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldRFQNo1.Appearance.Header.Options.UseFont = True
        Me.fieldRFQNo1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldRFQNo1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldRFQNo1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldRFQNo1.AreaIndex = 0
        Me.fieldRFQNo1.Caption = "RFQ No"
        Me.fieldRFQNo1.FieldName = "RFQNo"
        Me.fieldRFQNo1.MinWidth = 17
        Me.fieldRFQNo1.Name = "fieldRFQNo1"
        Me.fieldRFQNo1.Width = 86
        '
        'fieldRFQDate1
        '
        Me.fieldRFQDate1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldRFQDate1.Appearance.Header.Options.UseFont = True
        Me.fieldRFQDate1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldRFQDate1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldRFQDate1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldRFQDate1.AreaIndex = 1
        Me.fieldRFQDate1.Caption = "RFQ Date"
        Me.fieldRFQDate1.CellFormat.FormatString = "dd-MMM-yyyy"
        Me.fieldRFQDate1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldRFQDate1.FieldName = "RFQDate"
        Me.fieldRFQDate1.MinWidth = 17
        Me.fieldRFQDate1.Name = "fieldRFQDate1"
        Me.fieldRFQDate1.Width = 86
        '
        'fieldMPRNo1
        '
        Me.fieldMPRNo1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldMPRNo1.Appearance.Header.Options.UseFont = True
        Me.fieldMPRNo1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldMPRNo1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldMPRNo1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldMPRNo1.AreaIndex = 3
        Me.fieldMPRNo1.Caption = "MPR No"
        Me.fieldMPRNo1.FieldName = "MPRNo"
        Me.fieldMPRNo1.MinWidth = 17
        Me.fieldMPRNo1.Name = "fieldMPRNo1"
        Me.fieldMPRNo1.Width = 86
        '
        'fieldSupplierCode1
        '
        Me.fieldSupplierCode1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldSupplierCode1.Appearance.Header.Options.UseFont = True
        Me.fieldSupplierCode1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldSupplierCode1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldSupplierCode1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldSupplierCode1.AreaIndex = 6
        Me.fieldSupplierCode1.Caption = "Supplier Code"
        Me.fieldSupplierCode1.FieldName = "SupplierCode"
        Me.fieldSupplierCode1.MinWidth = 17
        Me.fieldSupplierCode1.Name = "fieldSupplierCode1"
        Me.fieldSupplierCode1.Width = 86
        '
        'fieldSupplierName1
        '
        Me.fieldSupplierName1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldSupplierName1.Appearance.Cell.Options.UseFont = True
        Me.fieldSupplierName1.Appearance.CellGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldSupplierName1.Appearance.CellGrandTotal.Options.UseFont = True
        Me.fieldSupplierName1.Appearance.CellTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldSupplierName1.Appearance.CellTotal.Options.UseFont = True
        Me.fieldSupplierName1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldSupplierName1.Appearance.Header.Options.UseFont = True
        Me.fieldSupplierName1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldSupplierName1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldSupplierName1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldSupplierName1.Appearance.ValueTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldSupplierName1.Appearance.ValueTotal.Options.UseFont = True
        Me.fieldSupplierName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSupplierName1.AreaIndex = 0
        Me.fieldSupplierName1.Caption = "Supplier Name"
        Me.fieldSupplierName1.FieldName = "SupplierName"
        Me.fieldSupplierName1.MinWidth = 17
        Me.fieldSupplierName1.Name = "fieldSupplierName1"
        Me.fieldSupplierName1.Width = 193
        '
        'fieldGSCode1
        '
        Me.fieldGSCode1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldGSCode1.Appearance.Header.Options.UseFont = True
        Me.fieldGSCode1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldGSCode1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldGSCode1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldGSCode1.AreaIndex = 4
        Me.fieldGSCode1.Caption = "GS Code"
        Me.fieldGSCode1.FieldName = "GSCode"
        Me.fieldGSCode1.MinWidth = 17
        Me.fieldGSCode1.Name = "fieldGSCode1"
        Me.fieldGSCode1.Width = 89
        '
        'fieldGSDescrpition1
        '
        Me.fieldGSDescrpition1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldGSDescrpition1.Appearance.Header.Options.UseFont = True
        Me.fieldGSDescrpition1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldGSDescrpition1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldGSDescrpition1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldGSDescrpition1.AreaIndex = 0
        Me.fieldGSDescrpition1.Caption = "Item Description"
        Me.fieldGSDescrpition1.FieldName = "GSDescrpition"
        Me.fieldGSDescrpition1.MinWidth = 17
        Me.fieldGSDescrpition1.Name = "fieldGSDescrpition1"
        Me.fieldGSDescrpition1.RowValueLineCount = 2
        Me.fieldGSDescrpition1.Width = 261
        '
        'fieldUnitDesc1
        '
        Me.fieldUnitDesc1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldUnitDesc1.Appearance.Header.Options.UseFont = True
        Me.fieldUnitDesc1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldUnitDesc1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldUnitDesc1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldUnitDesc1.AreaIndex = 2
        Me.fieldUnitDesc1.Caption = "UOM"
        Me.fieldUnitDesc1.FieldName = "UnitDesc"
        Me.fieldUnitDesc1.MinWidth = 17
        Me.fieldUnitDesc1.Name = "fieldUnitDesc1"
        Me.fieldUnitDesc1.Width = 86
        '
        'fieldQuotedQuantity1
        '
        Me.fieldQuotedQuantity1.Appearance.Cell.Options.UseTextOptions = True
        Me.fieldQuotedQuantity1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldQuotedQuantity1.Appearance.CellTotal.Options.UseTextOptions = True
        Me.fieldQuotedQuantity1.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldQuotedQuantity1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldQuotedQuantity1.Appearance.Header.Options.UseFont = True
        Me.fieldQuotedQuantity1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldQuotedQuantity1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldQuotedQuantity1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldQuotedQuantity1.Appearance.Value.Options.UseTextOptions = True
        Me.fieldQuotedQuantity1.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldQuotedQuantity1.Appearance.ValueGrandTotal.Options.UseTextOptions = True
        Me.fieldQuotedQuantity1.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldQuotedQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldQuotedQuantity1.AreaIndex = 1
        Me.fieldQuotedQuantity1.Caption = "Quantity"
        Me.fieldQuotedQuantity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldQuotedQuantity1.FieldName = "QuotedQuantity"
        Me.fieldQuotedQuantity1.MinWidth = 17
        Me.fieldQuotedQuantity1.Name = "fieldQuotedQuantity1"
        Me.fieldQuotedQuantity1.RowValueLineCount = 2
        Me.fieldQuotedQuantity1.Width = 77
        '
        'fieldUnitPrice1
        '
        Me.fieldUnitPrice1.Appearance.Cell.Options.UseTextOptions = True
        Me.fieldUnitPrice1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldUnitPrice1.Appearance.CellTotal.Options.UseTextOptions = True
        Me.fieldUnitPrice1.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldUnitPrice1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldUnitPrice1.Appearance.Header.Options.UseFont = True
        Me.fieldUnitPrice1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldUnitPrice1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldUnitPrice1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldUnitPrice1.Appearance.ValueGrandTotal.Options.UseTextOptions = True
        Me.fieldUnitPrice1.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldUnitPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldUnitPrice1.AreaIndex = 1
        Me.fieldUnitPrice1.Caption = "Unit Price"
        Me.fieldUnitPrice1.CellFormat.FormatString = "n2"
        Me.fieldUnitPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldUnitPrice1.FieldName = "UnitPrice"
        Me.fieldUnitPrice1.MinWidth = 17
        Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
        Me.fieldUnitPrice1.Options.ShowTotals = False
        Me.fieldUnitPrice1.RowValueLineCount = 2
        Me.fieldUnitPrice1.Width = 71
        '
        'fieldLineTotalBeforeTax1
        '
        Me.fieldLineTotalBeforeTax1.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.fieldLineTotalBeforeTax1.Appearance.CellGrandTotal.Options.UseBackColor = True
        Me.fieldLineTotalBeforeTax1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldLineTotalBeforeTax1.Appearance.Header.Options.UseFont = True
        Me.fieldLineTotalBeforeTax1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldLineTotalBeforeTax1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldLineTotalBeforeTax1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldLineTotalBeforeTax1.Appearance.ValueGrandTotal.Options.UseTextOptions = True
        Me.fieldLineTotalBeforeTax1.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldLineTotalBeforeTax1.AreaIndex = 5
        Me.fieldLineTotalBeforeTax1.Caption = "Total"
        Me.fieldLineTotalBeforeTax1.CellFormat.FormatString = "n2"
        Me.fieldLineTotalBeforeTax1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldLineTotalBeforeTax1.FieldName = "LineTotalBeforeTax"
        Me.fieldLineTotalBeforeTax1.MinWidth = 17
        Me.fieldLineTotalBeforeTax1.Name = "fieldLineTotalBeforeTax1"
        Me.fieldLineTotalBeforeTax1.Width = 56
        '
        'fieldItemDiscount1
        '
        Me.fieldItemDiscount1.Appearance.Cell.Options.UseTextOptions = True
        Me.fieldItemDiscount1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldItemDiscount1.Appearance.CellTotal.Options.UseTextOptions = True
        Me.fieldItemDiscount1.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldItemDiscount1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldItemDiscount1.Appearance.Header.Options.UseFont = True
        Me.fieldItemDiscount1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldItemDiscount1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldItemDiscount1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldItemDiscount1.Appearance.ValueGrandTotal.Options.UseTextOptions = True
        Me.fieldItemDiscount1.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldItemDiscount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldItemDiscount1.AreaIndex = 2
        Me.fieldItemDiscount1.Caption = "Discount"
        Me.fieldItemDiscount1.CellFormat.FormatString = "n2"
        Me.fieldItemDiscount1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldItemDiscount1.FieldName = "ItemDiscount"
        Me.fieldItemDiscount1.MinWidth = 17
        Me.fieldItemDiscount1.Name = "fieldItemDiscount1"
        Me.fieldItemDiscount1.RowValueLineCount = 2
        Me.fieldItemDiscount1.Width = 79
        '
        'fieldLineTotalAfterDisc1
        '
        Me.fieldLineTotalAfterDisc1.Appearance.Cell.BackColor = System.Drawing.Color.Silver
        Me.fieldLineTotalAfterDisc1.Appearance.Cell.Options.UseBackColor = True
        Me.fieldLineTotalAfterDisc1.Appearance.Cell.Options.UseTextOptions = True
        Me.fieldLineTotalAfterDisc1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldLineTotalAfterDisc1.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.Silver
        Me.fieldLineTotalAfterDisc1.Appearance.CellGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldLineTotalAfterDisc1.Appearance.CellGrandTotal.Options.UseBackColor = True
        Me.fieldLineTotalAfterDisc1.Appearance.CellGrandTotal.Options.UseFont = True
        Me.fieldLineTotalAfterDisc1.Appearance.CellTotal.BackColor = System.Drawing.Color.Silver
        Me.fieldLineTotalAfterDisc1.Appearance.CellTotal.Options.UseBackColor = True
        Me.fieldLineTotalAfterDisc1.Appearance.CellTotal.Options.UseTextOptions = True
        Me.fieldLineTotalAfterDisc1.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldLineTotalAfterDisc1.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.fieldLineTotalAfterDisc1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldLineTotalAfterDisc1.Appearance.Header.Options.UseBackColor = True
        Me.fieldLineTotalAfterDisc1.Appearance.Header.Options.UseFont = True
        Me.fieldLineTotalAfterDisc1.Appearance.Header.Options.UseTextOptions = True
        Me.fieldLineTotalAfterDisc1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldLineTotalAfterDisc1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.fieldLineTotalAfterDisc1.Appearance.Value.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.fieldLineTotalAfterDisc1.Appearance.Value.Options.UseBackColor = True
        Me.fieldLineTotalAfterDisc1.Appearance.ValueGrandTotal.BackColor = System.Drawing.Color.Silver
        Me.fieldLineTotalAfterDisc1.Appearance.ValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldLineTotalAfterDisc1.Appearance.ValueGrandTotal.Options.UseBackColor = True
        Me.fieldLineTotalAfterDisc1.Appearance.ValueGrandTotal.Options.UseFont = True
        Me.fieldLineTotalAfterDisc1.Appearance.ValueGrandTotal.Options.UseTextOptions = True
        Me.fieldLineTotalAfterDisc1.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldLineTotalAfterDisc1.Appearance.ValueTotal.BackColor = System.Drawing.Color.Silver
        Me.fieldLineTotalAfterDisc1.Appearance.ValueTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldLineTotalAfterDisc1.Appearance.ValueTotal.Options.UseBackColor = True
        Me.fieldLineTotalAfterDisc1.Appearance.ValueTotal.Options.UseFont = True
        Me.fieldLineTotalAfterDisc1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldLineTotalAfterDisc1.AreaIndex = 3
        Me.fieldLineTotalAfterDisc1.Caption = "Net Total"
        Me.fieldLineTotalAfterDisc1.CellFormat.FormatString = "n2"
        Me.fieldLineTotalAfterDisc1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldLineTotalAfterDisc1.FieldName = "LineTotalAfterDisc"
        Me.fieldLineTotalAfterDisc1.GrandTotalCellFormat.FormatString = "n2"
        Me.fieldLineTotalAfterDisc1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldLineTotalAfterDisc1.MinWidth = 17
        Me.fieldLineTotalAfterDisc1.Name = "fieldLineTotalAfterDisc1"
        Me.fieldLineTotalAfterDisc1.RowValueLineCount = 2
        Me.fieldLineTotalAfterDisc1.Width = 78
        '
        'fieldRFQChildSlNo
        '
        Me.fieldRFQChildSlNo.Appearance.CellTotal.Options.UseTextOptions = True
        Me.fieldRFQChildSlNo.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldRFQChildSlNo.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldRFQChildSlNo.AreaIndex = 0
        Me.fieldRFQChildSlNo.Caption = "#"
        Me.fieldRFQChildSlNo.FieldName = "RFQChildSlNo"
        Me.fieldRFQChildSlNo.MinWidth = 17
        Me.fieldRFQChildSlNo.Name = "fieldRFQChildSlNo"
        Me.fieldRFQChildSlNo.Options.ShowGrandTotal = False
        Me.fieldRFQChildSlNo.Options.ShowTotals = False
        Me.fieldRFQChildSlNo.RowValueLineCount = 2
        Me.fieldRFQChildSlNo.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldRFQChildSlNo.Width = 27
        '
        'fieldReasonForSelection
        '
        Me.fieldReasonForSelection.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldReasonForSelection.AreaIndex = 2
        Me.fieldReasonForSelection.FieldName = "ReasonForSelection"
        Me.fieldReasonForSelection.Name = "fieldReasonForSelection"
        Me.fieldReasonForSelection.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldReasonForSelection.Visible = False
        '
        'Qry607_08QuotationAnalysisPVGTableAdapter
        '
        Me.Qry607_08QuotationAnalysisPVGTableAdapter.ClearBeforeFill = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPrint, Me.btnGroup, Me.btnAddNewAlert, Me.btnEditQuote, Me.btnShowRecords2, Me.btnNewSystemAlert, Me.btnNewAlert, Me.btnNewReminder, Me.btnNewAssignment, Me.btnApprove, Me.btnViewVoucher, Me.btnAddNewPR, Me.btnRptPR, Me.BarButtonItem1, Me.btnViewServiceRequest, Me.btnNewRequest, Me.btnVerify, Me.btnDeleteQuote, Me.btnShowMyRequests, Me.btnChooseVoucher, Me.btnChooseVouchers, Me.btnPaymentVouchers, Me.btnReceiptVouchers, Me.btnSalesVouchers, Me.btnPurchasesVouchers, Me.btnJournalVouchers, Me.btnAllVoucherTypes, Me.btnToday, Me.btnYesterday, Me.btnThisWeek, Me.BarButtonItem5, Me.btnThisYear, Me.btnThisMonthFull, Me.btnThisYearTillDate, Me.btnThisMonthTillDate, Me.btnLastYear, Me.btnLastMonth, Me.BarSubItem1, Me.BarButtonItem2, Me.btnPreviewQuote, Me.btnTaxSummaryReport, Me.btnUnlockInvoice, Me.btnTaxReport, Me.BarSubItem2, Me.BarSubItem3, Me.btnSaveLayout, Me.btnOpenLayout, Me.btnSetDefaultLayout, Me.BarSubItem4, Me.btnBy1stQuarter, Me.btnBy2ndQuarter, Me.btnBy3rdQuarter, Me.btnBy4thQuarter, Me.btnReviseQuotation, Me.btnEditRFQ, Me.btnEditRFQ2, Me.btnCreateQuotation, Me.btnResetLayout})
        Me.BarManager1.MaxItemId = 64
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem3, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPrint, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGroup, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCreateQuotation, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        Me.btnResetLayout.Id = 63
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
        'btnGroup
        '
        Me.btnGroup.Caption = "Show Filters"
        Me.btnGroup.Id = 2
        Me.btnGroup.ImageOptions.Image = Global.ERP.My.Resources.Resources.GroupGrid
        Me.btnGroup.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGroup.ItemAppearance.Normal.Options.UseFont = True
        Me.btnGroup.Name = "btnGroup"
        '
        'btnCreateQuotation
        '
        Me.btnCreateQuotation.Caption = "Create Quotation"
        Me.btnCreateQuotation.Id = 62
        Me.btnCreateQuotation.ImageOptions.Image = CType(resources.GetObject("btnCreateQuotation.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCreateQuotation.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCreateQuotation.ItemAppearance.Normal.Options.UseFont = True
        Me.btnCreateQuotation.Name = "btnCreateQuotation"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(940, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 405)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(940, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 405)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(940, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 405)
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
        Me.btnEditQuote.Caption = "Edit RFQ"
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
        Me.btnDeleteQuote.Caption = "Delete RFQ"
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
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Last Week"
        Me.BarButtonItem5.Id = 32
        Me.BarButtonItem5.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
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
        'btnThisMonthFull
        '
        Me.btnThisMonthFull.Caption = "This Month "
        Me.btnThisMonthFull.Id = 34
        Me.btnThisMonthFull.ImageOptions.Image = CType(resources.GetObject("btnThisMonthFull.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThisMonthFull.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisMonthFull.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisMonthFull.Name = "btnThisMonthFull"
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
        'btnThisMonthTillDate
        '
        Me.btnThisMonthTillDate.Caption = "This Month (till date)"
        Me.btnThisMonthTillDate.Id = 36
        Me.btnThisMonthTillDate.ImageOptions.Image = CType(resources.GetObject("btnThisMonthTillDate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThisMonthTillDate.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnThisMonthTillDate.ItemAppearance.Normal.Options.UseFont = True
        Me.btnThisMonthTillDate.Name = "btnThisMonthTillDate"
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
        'btnPreviewQuote
        '
        Me.btnPreviewQuote.Caption = "Preview RFQ"
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
        'btnUnlockInvoice
        '
        Me.btnUnlockInvoice.Caption = "Unlock the RFQ"
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
        'btnReviseQuotation
        '
        Me.btnReviseQuotation.Caption = "Revise Quotation"
        Me.btnReviseQuotation.Id = 57
        Me.btnReviseQuotation.ImageOptions.Image = CType(resources.GetObject("btnReviseQuotation.ImageOptions.Image"), System.Drawing.Image)
        Me.btnReviseQuotation.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnReviseQuotation.ItemAppearance.Normal.Options.UseFont = True
        Me.btnReviseQuotation.Name = "btnReviseQuotation"
        '
        'btnEditRFQ
        '
        Me.btnEditRFQ.Caption = "Edit RFQ"
        Me.btnEditRFQ.Id = 60
        Me.btnEditRFQ.Name = "btnEditRFQ"
        '
        'btnEditRFQ2
        '
        Me.btnEditRFQ2.Caption = "Edit RFQ"
        Me.btnEditRFQ2.Id = 61
        Me.btnEditRFQ2.Name = "btnEditRFQ2"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditRFQ2), New DevExpress.XtraBars.LinkPersistInfo(Me.btnToday), New DevExpress.XtraBars.LinkPersistInfo(Me.btnYesterday), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisWeek, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisMonthFull, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisMonthTillDate), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisYear, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnThisYearTillDate), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLastYear, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLastMonth)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Blue"
        Me.BarAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Csv.Separator = ";"
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.pvgQuotationAnalysis
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditQuote, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPreviewQuote, "", True, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 0)
        Me.ImageCollection1.Images.SetKeyName(0, "apply_16x16.png")
        Me.ImageCollection1.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 1)
        Me.ImageCollection1.Images.SetKeyName(1, "cancel_16x16.png")
        '
        'Qry607_07RFQIssuedByMPRNoTableAdapter
        '
        Me.Qry607_07RFQIssuedByMPRNoTableAdapter.ClearBeforeFill = True
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.XtraTabControl1)
        Me.PopupContainerControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PopupContainerControl1.Location = New System.Drawing.Point(336, 141)
        Me.PopupContainerControl1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.PopupContainerControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(450, 279)
        Me.PopupContainerControl1.TabIndex = 127
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 5)
        Me.XtraTabControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.pageUpdateStatus
        Me.XtraTabControl1.Size = New System.Drawing.Size(444, 271)
        Me.XtraTabControl1.TabIndex = 97
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pageUpdateStatus})
        '
        'pageUpdateStatus
        '
        Me.pageUpdateStatus.Controls.Add(Me.PanelControl3)
        Me.pageUpdateStatus.Controls.Add(Me.btnBulkUpdate)
        Me.pageUpdateStatus.Controls.Add(Me.btnCloseMultiUpdates)
        Me.pageUpdateStatus.Name = "pageUpdateStatus"
        Me.pageUpdateStatus.Size = New System.Drawing.Size(438, 243)
        Me.pageUpdateStatus.Text = "Selection Details"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtReasonForSelection02)
        Me.PanelControl3.Controls.Add(Me.LabelControl10)
        Me.PanelControl3.Controls.Add(Me.LabelControl5)
        Me.PanelControl3.Location = New System.Drawing.Point(3, 7)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(432, 161)
        Me.PanelControl3.TabIndex = 95
        '
        'txtReasonForSelection02
        '
        Me.txtReasonForSelection02.EditValue = ""
        Me.txtReasonForSelection02.Location = New System.Drawing.Point(19, 27)
        Me.txtReasonForSelection02.MenuManager = Me.BarManager1
        Me.txtReasonForSelection02.Name = "txtReasonForSelection02"
        Me.txtReasonForSelection02.Properties.AllowMultiSelect = True
        Me.txtReasonForSelection02.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReasonForSelection02.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Lowest Price"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Delivery Terms"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Sole Dealer"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Best Payment Terms"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Item Availability")})
        Me.txtReasonForSelection02.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txtReasonForSelection02.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtReasonForSelection02.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtReasonForSelection02.Size = New System.Drawing.Size(401, 20)
        Me.txtReasonForSelection02.TabIndex = 93
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(19, 7)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(110, 14)
        Me.LabelControl10.TabIndex = 86
        Me.LabelControl10.Text = "Reason of Selection:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(16, 155)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(6, 14)
        Me.LabelControl5.TabIndex = 91
        Me.LabelControl5.Text = "  "
        '
        'btnBulkUpdate
        '
        Me.btnBulkUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBulkUpdate.Appearance.Options.UseFont = True
        Me.btnBulkUpdate.ImageOptions.Image = CType(resources.GetObject("btnBulkUpdate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBulkUpdate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnBulkUpdate.Location = New System.Drawing.Point(5, 192)
        Me.btnBulkUpdate.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnBulkUpdate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBulkUpdate.Name = "btnBulkUpdate"
        Me.btnBulkUpdate.Size = New System.Drawing.Size(221, 38)
        Me.btnBulkUpdate.TabIndex = 93
        Me.btnBulkUpdate.Text = "Update"
        '
        'btnCloseMultiUpdates
        '
        Me.btnCloseMultiUpdates.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseMultiUpdates.Appearance.Options.UseFont = True
        Me.btnCloseMultiUpdates.ImageOptions.Image = CType(resources.GetObject("btnCloseMultiUpdates.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCloseMultiUpdates.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnCloseMultiUpdates.Location = New System.Drawing.Point(242, 192)
        Me.btnCloseMultiUpdates.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnCloseMultiUpdates.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCloseMultiUpdates.Name = "btnCloseMultiUpdates"
        Me.btnCloseMultiUpdates.Size = New System.Drawing.Size(191, 38)
        Me.btnCloseMultiUpdates.TabIndex = 94
        Me.btnCloseMultiUpdates.Text = "Close"
        '
        'frm601_15QuotationAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 448)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.pvgQuotationAnalysis)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frm601_15QuotationAnalysis.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm601_15QuotationAnalysis"
        Me.Text = "Supplier Quotation Analysis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.repoIsWon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtMPRNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60707RFQIssuedByMPRNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_15QuotationAnalysis1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pvgQuotationAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60708QuotationAnalysisPVGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_15QuotationAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.pageUpdateStatus.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtReasonForSelection02.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Public WithEvents txtMPRNo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCostAllocationUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostAllocationGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pvgQuotationAnalysis As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents Dsfrm601_15QuotationAnalysis As ERP.dsfrm601_15QuotationAnalysis
    Friend WithEvents Qry60708QuotationAnalysisPVGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry607_08QuotationAnalysisPVGTableAdapter As ERP.dsfrm601_15QuotationAnalysisTableAdapters.qry607_08QuotationAnalysisPVGTableAdapter
    Friend WithEvents fieldRFQNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRFQDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMPRNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSupplierCode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSupplierName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGSCode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGSDescrpition1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnitDesc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQuotedQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnitPrice1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLineTotalBeforeTax1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldItemDiscount1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLineTotalAfterDisc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOpenLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSetDefaultLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents btnPreviewQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTaxSummaryReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnlockInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTaxReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnBy1stQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy2ndQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy3rdQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBy4thQuarter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReviseQuotation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditRFQ As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents btnEditRFQ2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents fieldRFQChildSlNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIsWonForPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnViewAnalysis As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Dsfrm601_15QuotationAnalysis1 As ERP.dsfrm601_15QuotationAnalysis
    Friend WithEvents Qry60707RFQIssuedByMPRNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry607_07RFQIssuedByMPRNoTableAdapter As ERP.dsfrm601_15QuotationAnalysisTableAdapters.qry607_07RFQIssuedByMPRNoTableAdapter
    Friend WithEvents repoIsWon As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnCreateQuotation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colClientName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMPRDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colClientNameOrStoreName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents pageUpdateStatus As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBulkUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCloseMultiUpdates As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldReasonForSelection As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents txtReasonForSelection02 As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
