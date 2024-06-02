<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm600_12OpeningBalanceEntries
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm600_12OpeningBalanceEntries))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.txtUnitPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtUnitOfMeasure = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockDesc = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStockCode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtOpeningBalance = New DevExpress.XtraEditors.SpinEdit()
        Me.lblRateOrPrice = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.gcCostAllocation = New DevExpress.XtraGrid.GridControl()
        Me.Tbl60502MaterialReceiptChildBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm600_12OpeningBalanceEntries = New ERP.dsfrm600_12OpeningBalanceEntries()
        Me.gvCostAllocation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReceiptChildSlNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiptNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyReceived = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colUnitRateMethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOTaxSlab = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOItemRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddlDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpiryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoEmpAllocationUnit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gvCostAllocationUnitEdit = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPropertyType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNationalID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeReferenceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlateNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlternatorNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientSite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrentStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsBreakDown = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKVAorKW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMobilizedTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperatorContactMobile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPropertyCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPropertyGroupCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientRatePerHour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoEffectiveDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.repoAmountEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.repoRemarksEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.repoAddLoanSchedule = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnDeleteLineItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBack = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnApproveCostAllocation = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddCostCenter = New DevExpress.XtraBars.BarButtonItem()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.Tbl605_02MaterialReceiptChildTableAdapter = New ERP.dsfrm600_12OpeningBalanceEntriesTableAdapters.tbl605_02MaterialReceiptChildTableAdapter()
        Me.Tbl40111PropertyUnitCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl40111PropertyUnitCodesTableAdapter = New ERP.dsfrm600_12OpeningBalanceEntriesTableAdapters.tbl40111PropertyUnitCodesTableAdapter()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txtUnitPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitOfMeasure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOpeningBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCostAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl60502MaterialReceiptChildBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm600_12OpeningBalanceEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCostAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoEmpAllocationUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCostAllocationUnitEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoEffectiveDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoEffectiveDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoAmountEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoRemarksEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoAddLoanSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl40111PropertyUnitCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.RoyalBlue
        Me.PanelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(19, 360)
        Me.PanelControl2.TabIndex = 5
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.RoyalBlue
        Me.PanelControl3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.PictureEdit1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(19, 0)
        Me.PanelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(854, 53)
        Me.PanelControl3.TabIndex = 14
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelControl6.Location = New System.Drawing.Point(70, 21)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(465, 25)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Inventory Stock Items: Opening Balance Entries"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.ERP.My.Resources.Resources.DailyRpt32x32
        Me.PictureEdit1.Location = New System.Drawing.Point(15, 6)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.PictureEdit1.Properties.ReadOnly = True
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(42, 42)
        Me.PictureEdit1.TabIndex = 13
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.txtUnitPrice)
        Me.PanelControl4.Controls.Add(Me.txtUnitOfMeasure)
        Me.PanelControl4.Controls.Add(Me.txtStockDesc)
        Me.PanelControl4.Controls.Add(Me.LabelControl4)
        Me.PanelControl4.Controls.Add(Me.txtStockCode)
        Me.PanelControl4.Controls.Add(Me.txtOpeningBalance)
        Me.PanelControl4.Controls.Add(Me.lblRateOrPrice)
        Me.PanelControl4.Controls.Add(Me.LabelControl22)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(19, 53)
        Me.PanelControl4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(854, 70)
        Me.PanelControl4.TabIndex = 15
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Enabled = False
        Me.txtUnitPrice.Location = New System.Drawing.Point(729, 39)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(120, 20)
        Me.txtUnitPrice.TabIndex = 55
        '
        'txtUnitOfMeasure
        '
        Me.txtUnitOfMeasure.Enabled = False
        Me.txtUnitOfMeasure.Location = New System.Drawing.Point(729, 16)
        Me.txtUnitOfMeasure.Name = "txtUnitOfMeasure"
        Me.txtUnitOfMeasure.Size = New System.Drawing.Size(120, 20)
        Me.txtUnitOfMeasure.TabIndex = 54
        '
        'txtStockDesc
        '
        Me.txtStockDesc.Enabled = False
        Me.txtStockDesc.EnterMoveNextControl = True
        Me.txtStockDesc.Location = New System.Drawing.Point(187, 35)
        Me.txtStockDesc.Name = "txtStockDesc"
        Me.txtStockDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtStockDesc.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtStockDesc.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtStockDesc.Properties.Appearance.Options.UseBackColor = True
        Me.txtStockDesc.Properties.Appearance.Options.UseFont = True
        Me.txtStockDesc.Properties.Appearance.Options.UseForeColor = True
        Me.txtStockDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtStockDesc.Size = New System.Drawing.Size(367, 24)
        Me.txtStockDesc.TabIndex = 49
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl4.Location = New System.Drawing.Point(13, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(59, 14)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Stock Code:"
        '
        'txtStockCode
        '
        Me.txtStockCode.Enabled = False
        Me.txtStockCode.EnterMoveNextControl = True
        Me.txtStockCode.Location = New System.Drawing.Point(11, 35)
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtStockCode.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtStockCode.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtStockCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtStockCode.Properties.Appearance.Options.UseFont = True
        Me.txtStockCode.Properties.Appearance.Options.UseForeColor = True
        Me.txtStockCode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStockCode.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockCode.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtStockCode.Properties.AppearanceDropDown.Options.UseTextOptions = True
        Me.txtStockCode.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStockCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStockCode.Properties.DropDownRows = 2
        Me.txtStockCode.Properties.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.txtStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtStockCode.Size = New System.Drawing.Size(170, 24)
        Me.txtStockCode.TabIndex = 47
        '
        'txtOpeningBalance
        '
        Me.txtOpeningBalance.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOpeningBalance.Enabled = False
        Me.txtOpeningBalance.EnterMoveNextControl = True
        Me.txtOpeningBalance.Location = New System.Drawing.Point(560, 35)
        Me.txtOpeningBalance.Name = "txtOpeningBalance"
        Me.txtOpeningBalance.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtOpeningBalance.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtOpeningBalance.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtOpeningBalance.Properties.Appearance.Options.UseBackColor = True
        Me.txtOpeningBalance.Properties.Appearance.Options.UseFont = True
        Me.txtOpeningBalance.Properties.Appearance.Options.UseForeColor = True
        Me.txtOpeningBalance.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOpeningBalance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOpeningBalance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtOpeningBalance.Properties.DisplayFormat.FormatString = "n2"
        Me.txtOpeningBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOpeningBalance.Properties.EditFormat.FormatString = "n2"
        Me.txtOpeningBalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOpeningBalance.Properties.Mask.EditMask = "n2"
        Me.txtOpeningBalance.Size = New System.Drawing.Size(107, 24)
        Me.txtOpeningBalance.TabIndex = 35
        '
        'lblRateOrPrice
        '
        Me.lblRateOrPrice.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRateOrPrice.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblRateOrPrice.Location = New System.Drawing.Point(563, 18)
        Me.lblRateOrPrice.Name = "lblRateOrPrice"
        Me.lblRateOrPrice.Size = New System.Drawing.Size(87, 14)
        Me.lblRateOrPrice.TabIndex = 36
        Me.lblRateOrPrice.Text = "Opening Balance"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl22.Location = New System.Drawing.Point(187, 17)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(119, 14)
        Me.LabelControl22.TabIndex = 34
        Me.LabelControl22.Text = "Stock Item Description:"
        '
        'gcCostAllocation
        '
        Me.gcCostAllocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCostAllocation.DataSource = Me.Tbl60502MaterialReceiptChildBindingSource
        Me.gcCostAllocation.Location = New System.Drawing.Point(19, 125)
        Me.gcCostAllocation.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcCostAllocation.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcCostAllocation.MainView = Me.gvCostAllocation
        Me.gcCostAllocation.Name = "gcCostAllocation"
        Me.gcCostAllocation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoEmpAllocationUnit, Me.repoEffectiveDate, Me.repoAmountEdit, Me.repoRemarksEdit, Me.repoAddLoanSchedule, Me.RepositoryItemButtonEdit1, Me.RepositoryItemGridLookUpEdit1})
        Me.gcCostAllocation.Size = New System.Drawing.Size(854, 233)
        Me.gcCostAllocation.TabIndex = 16
        Me.gcCostAllocation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCostAllocation, Me.GridView5})
        '
        'Tbl60502MaterialReceiptChildBindingSource
        '
        Me.Tbl60502MaterialReceiptChildBindingSource.DataMember = "tbl605_02MaterialReceiptChild"
        Me.Tbl60502MaterialReceiptChildBindingSource.DataSource = Me.Dsfrm600_12OpeningBalanceEntries
        '
        'Dsfrm600_12OpeningBalanceEntries
        '
        Me.Dsfrm600_12OpeningBalanceEntries.DataSetName = "dsfrm600_12OpeningBalanceEntries"
        Me.Dsfrm600_12OpeningBalanceEntries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvCostAllocation
        '
        Me.gvCostAllocation.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvCostAllocation.Appearance.TopNewRow.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvCostAllocation.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvCostAllocation.Appearance.TopNewRow.Options.UseFont = True
        Me.gvCostAllocation.ColumnPanelRowHeight = 40
        Me.gvCostAllocation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReceiptChildSlNo, Me.colReceiptNo, Me.colGSCode, Me.colQtyReceived, Me.colUnitRateMethod, Me.colUnitPrice, Me.colItemDiscount, Me.colPOTaxSlab, Me.colPOItemRemarks, Me.colLineOrderNo, Me.colAddlDescription, Me.colExpiryDate, Me.colBatchNo})
        Me.gvCostAllocation.CustomizationFormBounds = New System.Drawing.Rectangle(604, 455, 208, 191)
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Moccasin
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "Dr"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "Cr"
        Me.gvCostAllocation.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.gvCostAllocation.GridControl = Me.gcCostAllocation
        Me.gvCostAllocation.Name = "gvCostAllocation"
        Me.gvCostAllocation.OptionsNavigation.AutoFocusNewRow = True
        Me.gvCostAllocation.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvCostAllocation.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvCostAllocation.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvCostAllocation.OptionsSelection.MultiSelect = True
        Me.gvCostAllocation.OptionsView.ShowFooter = True
        Me.gvCostAllocation.OptionsView.ShowGroupPanel = False
        Me.gvCostAllocation.RowHeight = 35
        Me.gvCostAllocation.RowSeparatorHeight = 1
        '
        'colReceiptChildSlNo
        '
        Me.colReceiptChildSlNo.FieldName = "ReceiptChildSlNo"
        Me.colReceiptChildSlNo.Name = "colReceiptChildSlNo"
        '
        'colReceiptNo
        '
        Me.colReceiptNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colReceiptNo.AppearanceHeader.Options.UseFont = True
        Me.colReceiptNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceiptNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceiptNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceiptNo.FieldName = "ReceiptNo"
        Me.colReceiptNo.Name = "colReceiptNo"
        Me.colReceiptNo.Width = 108
        '
        'colGSCode
        '
        Me.colGSCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSCode.AppearanceCell.Options.UseFont = True
        Me.colGSCode.AppearanceCell.Options.UseTextOptions = True
        Me.colGSCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSCode.AppearanceHeader.Options.UseFont = True
        Me.colGSCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSCode.Caption = "Stock Code"
        Me.colGSCode.FieldName = "GSCode"
        Me.colGSCode.Name = "colGSCode"
        Me.colGSCode.Visible = True
        Me.colGSCode.VisibleIndex = 0
        Me.colGSCode.Width = 132
        '
        'colQtyReceived
        '
        Me.colQtyReceived.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQtyReceived.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtyReceived.AppearanceCell.Options.UseBackColor = True
        Me.colQtyReceived.AppearanceCell.Options.UseFont = True
        Me.colQtyReceived.AppearanceCell.Options.UseTextOptions = True
        Me.colQtyReceived.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyReceived.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtyReceived.AppearanceHeader.Options.UseFont = True
        Me.colQtyReceived.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyReceived.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQtyReceived.Caption = "Quantity"
        Me.colQtyReceived.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.colQtyReceived.FieldName = "QtyReceived"
        Me.colQtyReceived.Name = "colQtyReceived"
        Me.colQtyReceived.Visible = True
        Me.colQtyReceived.VisibleIndex = 3
        Me.colQtyReceived.Width = 132
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'colUnitRateMethod
        '
        Me.colUnitRateMethod.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitRateMethod.AppearanceCell.Options.UseFont = True
        Me.colUnitRateMethod.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitRateMethod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitRateMethod.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitRateMethod.AppearanceHeader.Options.UseFont = True
        Me.colUnitRateMethod.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitRateMethod.Caption = "Unit"
        Me.colUnitRateMethod.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colUnitRateMethod.FieldName = "UnitRateMethod"
        Me.colUnitRateMethod.Name = "colUnitRateMethod"
        Me.colUnitRateMethod.OptionsColumn.AllowEdit = False
        Me.colUnitRateMethod.Visible = True
        Me.colUnitRateMethod.VisibleIndex = 1
        Me.colUnitRateMethod.Width = 132
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.Tbl40111PropertyUnitCodesBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "UnitDesc"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "UnitCode"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colUnitPrice
        '
        Me.colUnitPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitPrice.AppearanceCell.Options.UseFont = True
        Me.colUnitPrice.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitPrice.AppearanceHeader.Options.UseFont = True
        Me.colUnitPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.OptionsColumn.AllowEdit = False
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 2
        Me.colUnitPrice.Width = 121
        '
        'colItemDiscount
        '
        Me.colItemDiscount.FieldName = "ItemDiscount"
        Me.colItemDiscount.Name = "colItemDiscount"
        '
        'colPOTaxSlab
        '
        Me.colPOTaxSlab.FieldName = "POTaxSlab"
        Me.colPOTaxSlab.Name = "colPOTaxSlab"
        '
        'colPOItemRemarks
        '
        Me.colPOItemRemarks.FieldName = "POItemRemarks"
        Me.colPOItemRemarks.Name = "colPOItemRemarks"
        Me.colPOItemRemarks.Width = 116
        '
        'colLineOrderNo
        '
        Me.colLineOrderNo.FieldName = "LineOrderNo"
        Me.colLineOrderNo.Name = "colLineOrderNo"
        '
        'colAddlDescription
        '
        Me.colAddlDescription.FieldName = "AddlDescription"
        Me.colAddlDescription.Name = "colAddlDescription"
        '
        'colExpiryDate
        '
        Me.colExpiryDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExpiryDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExpiryDate.AppearanceCell.Options.UseBackColor = True
        Me.colExpiryDate.AppearanceCell.Options.UseFont = True
        Me.colExpiryDate.AppearanceCell.Options.UseTextOptions = True
        Me.colExpiryDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExpiryDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExpiryDate.AppearanceHeader.Options.UseFont = True
        Me.colExpiryDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExpiryDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExpiryDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExpiryDate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colExpiryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colExpiryDate.FieldName = "ExpiryDate"
        Me.colExpiryDate.Name = "colExpiryDate"
        Me.colExpiryDate.Visible = True
        Me.colExpiryDate.VisibleIndex = 4
        Me.colExpiryDate.Width = 119
        '
        'colBatchNo
        '
        Me.colBatchNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBatchNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBatchNo.AppearanceCell.Options.UseBackColor = True
        Me.colBatchNo.AppearanceCell.Options.UseFont = True
        Me.colBatchNo.AppearanceCell.Options.UseTextOptions = True
        Me.colBatchNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBatchNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBatchNo.AppearanceHeader.Options.UseFont = True
        Me.colBatchNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colBatchNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBatchNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.Visible = True
        Me.colBatchNo.VisibleIndex = 5
        Me.colBatchNo.Width = 173
        '
        'repoEmpAllocationUnit
        '
        Me.repoEmpAllocationUnit.AutoHeight = False
        Me.repoEmpAllocationUnit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.ERP.My.Resources.Resources.add116, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.ERP.My.Resources.Resources.DailyRpt16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.repoEmpAllocationUnit.DisplayMember = "PropertyDescription"
        Me.repoEmpAllocationUnit.ImmediatePopup = True
        Me.repoEmpAllocationUnit.LookAndFeel.SkinName = "Money Twins"
        Me.repoEmpAllocationUnit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.repoEmpAllocationUnit.Name = "repoEmpAllocationUnit"
        Me.repoEmpAllocationUnit.NullText = ""
        Me.repoEmpAllocationUnit.PopupFormSize = New System.Drawing.Size(750, 0)
        Me.repoEmpAllocationUnit.ValueMember = "PropertyNo"
        Me.repoEmpAllocationUnit.View = Me.gvCostAllocationUnitEdit
        '
        'gvCostAllocationUnitEdit
        '
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.Empty.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.OddRow.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvCostAllocationUnitEdit.Appearance.OddRow.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvCostAllocationUnitEdit.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.Preview.Options.UseFont = True
        Me.gvCostAllocationUnitEdit.Appearance.Preview.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvCostAllocationUnitEdit.Appearance.Row.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.Row.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvCostAllocationUnitEdit.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvCostAllocationUnitEdit.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvCostAllocationUnitEdit.Appearance.VertLine.Options.UseBackColor = True
        Me.gvCostAllocationUnitEdit.ColumnPanelRowHeight = 30
        Me.gvCostAllocationUnitEdit.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmployeeID, Me.colEmployeeName, Me.colPropertyType, Me.colNationalID, Me.gcEdit, Me.colEmployeeReferenceID, Me.colPlateNo, Me.colAlternatorNo, Me.colClientSite, Me.colCurrentStatus, Me.colEngineNo, Me.colIsBreakDown, Me.colKVAorKW, Me.colLocation, Me.colMobilizedTo, Me.colOperator, Me.colOperatorContactMobile, Me.colPropertyCategoryName, Me.colPropertyGroupCode, Me.colSupplierName, Me.colClientRatePerHour})
        Me.gvCostAllocationUnitEdit.DetailHeight = 400
        Me.gvCostAllocationUnitEdit.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvCostAllocationUnitEdit.GroupRowHeight = 20
        Me.gvCostAllocationUnitEdit.Name = "gvCostAllocationUnitEdit"
        Me.gvCostAllocationUnitEdit.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvCostAllocationUnitEdit.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvCostAllocationUnitEdit.OptionsView.EnableAppearanceEvenRow = True
        Me.gvCostAllocationUnitEdit.OptionsView.EnableAppearanceOddRow = True
        Me.gvCostAllocationUnitEdit.OptionsView.ShowAutoFilterRow = True
        Me.gvCostAllocationUnitEdit.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.gvCostAllocationUnitEdit.OptionsView.ShowGroupPanel = False
        Me.gvCostAllocationUnitEdit.RowHeight = 25
        Me.gvCostAllocationUnitEdit.RowSeparatorHeight = 3
        '
        'colEmployeeID
        '
        Me.colEmployeeID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colEmployeeID.AppearanceCell.Options.UseFont = True
        Me.colEmployeeID.AppearanceCell.Options.UseTextOptions = True
        Me.colEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmployeeID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colEmployeeID.AppearanceHeader.Options.UseFont = True
        Me.colEmployeeID.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmployeeID.FieldName = "PropertyNo"
        Me.colEmployeeID.Name = "colEmployeeID"
        Me.colEmployeeID.Visible = True
        Me.colEmployeeID.VisibleIndex = 0
        Me.colEmployeeID.Width = 277
        '
        'colEmployeeName
        '
        Me.colEmployeeName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colEmployeeName.AppearanceCell.Options.UseFont = True
        Me.colEmployeeName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colEmployeeName.AppearanceHeader.Options.UseFont = True
        Me.colEmployeeName.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmployeeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmployeeName.FieldName = "PropertyDescription"
        Me.colEmployeeName.Name = "colEmployeeName"
        Me.colEmployeeName.Visible = True
        Me.colEmployeeName.VisibleIndex = 1
        Me.colEmployeeName.Width = 670
        '
        'colPropertyType
        '
        Me.colPropertyType.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPropertyType.AppearanceHeader.Options.UseFont = True
        Me.colPropertyType.AppearanceHeader.Options.UseTextOptions = True
        Me.colPropertyType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPropertyType.FieldName = "PropertyType"
        Me.colPropertyType.Name = "colPropertyType"
        Me.colPropertyType.Visible = True
        Me.colPropertyType.VisibleIndex = 2
        Me.colPropertyType.Width = 417
        '
        'colNationalID
        '
        Me.colNationalID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.colNationalID.AppearanceCell.Options.UseFont = True
        Me.colNationalID.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNationalID.AppearanceHeader.Options.UseFont = True
        Me.colNationalID.AppearanceHeader.Options.UseTextOptions = True
        Me.colNationalID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNationalID.FieldName = "PropertyGroup"
        Me.colNationalID.Name = "colNationalID"
        Me.colNationalID.Width = 269
        '
        'gcEdit
        '
        Me.gcEdit.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gcEdit.AppearanceHeader.Options.UseFont = True
        Me.gcEdit.AppearanceHeader.Options.UseTextOptions = True
        Me.gcEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcEdit.Caption = "Edit"
        Me.gcEdit.Name = "gcEdit"
        Me.gcEdit.Width = 98
        '
        'colEmployeeReferenceID
        '
        Me.colEmployeeReferenceID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colEmployeeReferenceID.AppearanceCell.Options.UseFont = True
        Me.colEmployeeReferenceID.AppearanceCell.Options.UseTextOptions = True
        Me.colEmployeeReferenceID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmployeeReferenceID.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEmployeeReferenceID.AppearanceHeader.Options.UseFont = True
        Me.colEmployeeReferenceID.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmployeeReferenceID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmployeeReferenceID.FieldName = "EmployeeReferenceID"
        Me.colEmployeeReferenceID.Name = "colEmployeeReferenceID"
        '
        'colPlateNo
        '
        Me.colPlateNo.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlateNo.AppearanceHeader.Options.UseFont = True
        Me.colPlateNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlateNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlateNo.FieldName = "PlateNo"
        Me.colPlateNo.Name = "colPlateNo"
        Me.colPlateNo.Visible = True
        Me.colPlateNo.VisibleIndex = 3
        Me.colPlateNo.Width = 266
        '
        'colAlternatorNo
        '
        Me.colAlternatorNo.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAlternatorNo.AppearanceHeader.Options.UseFont = True
        Me.colAlternatorNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlternatorNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlternatorNo.FieldName = "AlternatorNo"
        Me.colAlternatorNo.Name = "colAlternatorNo"
        '
        'colClientSite
        '
        Me.colClientSite.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientSite.AppearanceHeader.Options.UseFont = True
        Me.colClientSite.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientSite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientSite.FieldName = "ClientSite"
        Me.colClientSite.Name = "colClientSite"
        '
        'colCurrentStatus
        '
        Me.colCurrentStatus.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCurrentStatus.AppearanceHeader.Options.UseFont = True
        Me.colCurrentStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrentStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrentStatus.FieldName = "CurrentStatus"
        Me.colCurrentStatus.Name = "colCurrentStatus"
        '
        'colEngineNo
        '
        Me.colEngineNo.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEngineNo.AppearanceHeader.Options.UseFont = True
        Me.colEngineNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colEngineNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEngineNo.FieldName = "EngineNo"
        Me.colEngineNo.Name = "colEngineNo"
        '
        'colIsBreakDown
        '
        Me.colIsBreakDown.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsBreakDown.AppearanceHeader.Options.UseFont = True
        Me.colIsBreakDown.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsBreakDown.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsBreakDown.FieldName = "IsBreakDown"
        Me.colIsBreakDown.Name = "colIsBreakDown"
        '
        'colKVAorKW
        '
        Me.colKVAorKW.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colKVAorKW.AppearanceHeader.Options.UseFont = True
        Me.colKVAorKW.AppearanceHeader.Options.UseTextOptions = True
        Me.colKVAorKW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKVAorKW.FieldName = "KVAorKW"
        Me.colKVAorKW.Name = "colKVAorKW"
        '
        'colLocation
        '
        Me.colLocation.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLocation.AppearanceHeader.Options.UseFont = True
        Me.colLocation.AppearanceHeader.Options.UseTextOptions = True
        Me.colLocation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        '
        'colMobilizedTo
        '
        Me.colMobilizedTo.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMobilizedTo.AppearanceHeader.Options.UseFont = True
        Me.colMobilizedTo.AppearanceHeader.Options.UseTextOptions = True
        Me.colMobilizedTo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMobilizedTo.FieldName = "MobilizedTo"
        Me.colMobilizedTo.Name = "colMobilizedTo"
        '
        'colOperator
        '
        Me.colOperator.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOperator.AppearanceHeader.Options.UseFont = True
        Me.colOperator.AppearanceHeader.Options.UseTextOptions = True
        Me.colOperator.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOperator.FieldName = "Operator"
        Me.colOperator.Name = "colOperator"
        '
        'colOperatorContactMobile
        '
        Me.colOperatorContactMobile.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOperatorContactMobile.AppearanceHeader.Options.UseFont = True
        Me.colOperatorContactMobile.AppearanceHeader.Options.UseTextOptions = True
        Me.colOperatorContactMobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOperatorContactMobile.FieldName = "OperatorContactMobile"
        Me.colOperatorContactMobile.Name = "colOperatorContactMobile"
        '
        'colPropertyCategoryName
        '
        Me.colPropertyCategoryName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPropertyCategoryName.AppearanceHeader.Options.UseFont = True
        Me.colPropertyCategoryName.AppearanceHeader.Options.UseTextOptions = True
        Me.colPropertyCategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPropertyCategoryName.FieldName = "PropertyCategoryName"
        Me.colPropertyCategoryName.Name = "colPropertyCategoryName"
        '
        'colPropertyGroupCode
        '
        Me.colPropertyGroupCode.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPropertyGroupCode.AppearanceHeader.Options.UseFont = True
        Me.colPropertyGroupCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colPropertyGroupCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPropertyGroupCode.FieldName = "PropertyGroupCode"
        Me.colPropertyGroupCode.Name = "colPropertyGroupCode"
        '
        'colSupplierName
        '
        Me.colSupplierName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSupplierName.AppearanceHeader.Options.UseFont = True
        Me.colSupplierName.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        '
        'colClientRatePerHour
        '
        Me.colClientRatePerHour.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientRatePerHour.AppearanceHeader.Options.UseFont = True
        Me.colClientRatePerHour.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientRatePerHour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientRatePerHour.FieldName = "ClientRatePerHour"
        Me.colClientRatePerHour.Name = "colClientRatePerHour"
        '
        'repoEffectiveDate
        '
        Me.repoEffectiveDate.AutoHeight = False
        Me.repoEffectiveDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoEffectiveDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.repoEffectiveDate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.repoEffectiveDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repoEffectiveDate.EditFormat.FormatString = "dd-MMM-yyyy"
        Me.repoEffectiveDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repoEffectiveDate.Mask.EditMask = "dd-MMM-yyyy"
        Me.repoEffectiveDate.Name = "repoEffectiveDate"
        '
        'repoAmountEdit
        '
        Me.repoAmountEdit.AutoHeight = False
        Me.repoAmountEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.repoAmountEdit.DisplayFormat.FormatString = "###,###,###,##0.00;"
        Me.repoAmountEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoAmountEdit.EditFormat.FormatString = "###,###,###,##0.00;"
        Me.repoAmountEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoAmountEdit.Mask.EditMask = "###,###,###,##0.00;"
        Me.repoAmountEdit.Name = "repoAmountEdit"
        '
        'repoRemarksEdit
        '
        Me.repoRemarksEdit.Appearance.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!)
        Me.repoRemarksEdit.Appearance.Options.UseFont = True
        Me.repoRemarksEdit.AppearanceDropDown.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repoRemarksEdit.AppearanceDropDown.Options.UseFont = True
        Me.repoRemarksEdit.AutoHeight = False
        Me.repoRemarksEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoRemarksEdit.Name = "repoRemarksEdit"
        Me.repoRemarksEdit.ShowIcon = False
        '
        'repoAddLoanSchedule
        '
        Me.repoAddLoanSchedule.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.repoAddLoanSchedule.Appearance.Options.UseFont = True
        Me.repoAddLoanSchedule.AppearanceDisabled.BackColor = System.Drawing.Color.Silver
        Me.repoAddLoanSchedule.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.repoAddLoanSchedule.AppearanceDisabled.Options.UseBackColor = True
        Me.repoAddLoanSchedule.AppearanceDisabled.Options.UseForeColor = True
        Me.repoAddLoanSchedule.AutoHeight = False
        Me.repoAddLoanSchedule.Name = "repoAddLoanSchedule"
        Me.repoAddLoanSchedule.NullText = "Add"
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.gcCostAllocation
        Me.GridView5.Name = "GridView5"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDeleteLineItem, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'btnDeleteLineItem
        '
        Me.btnDeleteLineItem.Caption = "Delete Line Item"
        Me.btnDeleteLineItem.Glyph = Global.ERP.My.Resources.Resources.DeleteRed
        Me.btnDeleteLineItem.Id = 6
        Me.btnDeleteLineItem.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteLineItem.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDeleteLineItem.Name = "btnDeleteLineItem"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnDelete, Me.btnBack, Me.btnApproveCostAllocation, Me.btnAddCostCenter, Me.btnDeleteLineItem, Me.btnPrint})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSave, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPrint, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDelete, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnBack, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save && Close"
        Me.btnSave.Glyph = Global.ERP.My.Resources.Resources.Save24x24
        Me.btnSave.Id = 0
        Me.btnSave.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSave.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShortcutKeyDisplayString = "Press Ctrl+S to Save"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Glyph = Global.ERP.My.Resources.Resources.Print
        Me.btnPrint.Id = 7
        Me.btnPrint.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPrint.Name = "btnPrint"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Glyph = Global.ERP.My.Resources.Resources.DeleteRed
        Me.btnDelete.Id = 1
        Me.btnDelete.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShortcutKeyDisplayString = "Press Ctrl+X to Delete"
        '
        'btnBack
        '
        Me.btnBack.Caption = "Back"
        Me.btnBack.Glyph = Global.ERP.My.Resources.Resources.GoBackBlue24x24
        Me.btnBack.Id = 2
        Me.btnBack.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBack.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Home)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShortcutKeyDisplayString = "Press F5 to close"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(873, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 360)
        Me.barDockControlBottom.Size = New System.Drawing.Size(873, 35)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 360)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(873, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 360)
        '
        'btnApproveCostAllocation
        '
        Me.btnApproveCostAllocation.Caption = "Approve"
        Me.btnApproveCostAllocation.Glyph = Global.ERP.My.Resources.Resources.AdminAccept24x24
        Me.btnApproveCostAllocation.Id = 3
        Me.btnApproveCostAllocation.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnApproveCostAllocation.ItemAppearance.Normal.Options.UseFont = True
        Me.btnApproveCostAllocation.Name = "btnApproveCostAllocation"
        '
        'btnAddCostCenter
        '
        Me.btnAddCostCenter.Caption = "Add New Cost Centre"
        Me.btnAddCostCenter.Glyph = Global.ERP.My.Resources.Resources.add
        Me.btnAddCostCenter.Id = 5
        Me.btnAddCostCenter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCostCenter.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAddCostCenter.Name = "btnAddCostCenter"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Blue"
        Me.BarAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'Tbl605_02MaterialReceiptChildTableAdapter
        '
        Me.Tbl605_02MaterialReceiptChildTableAdapter.ClearBeforeFill = True
        '
        'Tbl40111PropertyUnitCodesBindingSource
        '
        Me.Tbl40111PropertyUnitCodesBindingSource.DataMember = "tbl40111PropertyUnitCodes"
        Me.Tbl40111PropertyUnitCodesBindingSource.DataSource = Me.Dsfrm600_12OpeningBalanceEntries
        '
        'Tbl40111PropertyUnitCodesTableAdapter
        '
        Me.Tbl40111PropertyUnitCodesTableAdapter.ClearBeforeFill = True
        '
        'frm600_12OpeningBalanceEntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 395)
        Me.Controls.Add(Me.gcCostAllocation)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm600_12OpeningBalanceEntries"
        Me.Text = "Opening Balance Entries"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.txtUnitPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitOfMeasure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOpeningBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCostAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl60502MaterialReceiptChildBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm600_12OpeningBalanceEntries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCostAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoEmpAllocationUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCostAllocationUnitEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoEffectiveDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoEffectiveDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoAmountEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoRemarksEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoAddLoanSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl40111PropertyUnitCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtUnitPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUnitOfMeasure As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStockCode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtOpeningBalance As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblRateOrPrice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcCostAllocation As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCostAllocation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents repoEmpAllocationUnit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gvCostAllocationUnitEdit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropertyType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNationalID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeReferenceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlateNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlternatorNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientSite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsBreakDown As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKVAorKW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMobilizedTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperatorContactMobile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropertyCategoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropertyGroupCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientRatePerHour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoAmountEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents repoEffectiveDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repoRemarksEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents repoAddLoanSchedule As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnDeleteLineItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBack As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnApproveCostAllocation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddCostCenter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents Dsfrm600_12OpeningBalanceEntries As ERP.dsfrm600_12OpeningBalanceEntries
    Friend WithEvents Tbl60502MaterialReceiptChildBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl605_02MaterialReceiptChildTableAdapter As ERP.dsfrm600_12OpeningBalanceEntriesTableAdapters.tbl605_02MaterialReceiptChildTableAdapter
    Friend WithEvents colReceiptChildSlNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiptNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyReceived As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitRateMethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOTaxSlab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOItemRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddlDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpiryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Tbl40111PropertyUnitCodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl40111PropertyUnitCodesTableAdapter As ERP.dsfrm600_12OpeningBalanceEntriesTableAdapters.tbl40111PropertyUnitCodesTableAdapter
End Class
