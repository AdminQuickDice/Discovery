<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm600_15QuotationSubGroups
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtIsHidePrice = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.txtQuotationNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubGroupCode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtSubGroupName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.gcDrillDetails = New DevExpress.XtraGrid.GridControl()
        Me.Tbl60107QuotationChildItemGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm600_15QuotationSubGroups = New ERP.dsfrm600_15QuotationSubGroups()
        Me.gvDrillsDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colQuoteGroupItemSlNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuotationNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGroupCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGroupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGroupRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsShowLineItemsTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repoRemarks = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Tbl601_07QuotationChildItemGroupTableAdapter = New ERP.dsfrm600_15QuotationSubGroupsTableAdapters.tbl601_07QuotationChildItemGroupTableAdapter()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMPRNo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtIsHidePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuotationNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubGroupCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubGroupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDrillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl60107QuotationChildItemGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm600_15QuotationSubGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDrillsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMPRNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txtMPRNo)
        Me.PanelControl2.Controls.Add(Me.txtIsHidePrice)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.txtRemarks)
        Me.PanelControl2.Controls.Add(Me.txtQuotationNo)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.cmdAdd)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.txtSubGroupCode)
        Me.PanelControl2.Controls.Add(Me.txtSubGroupName)
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(749, 173)
        Me.PanelControl2.TabIndex = 1
        '
        'txtIsHidePrice
        '
        Me.txtIsHidePrice.Location = New System.Drawing.Point(506, 90)
        Me.txtIsHidePrice.Name = "txtIsHidePrice"
        Me.txtIsHidePrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtIsHidePrice.Properties.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtIsHidePrice.Properties.Appearance.Options.UseFont = True
        Me.txtIsHidePrice.Properties.Appearance.Options.UseForeColor = True
        Me.txtIsHidePrice.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIsHidePrice.Properties.OffText = "Show Price Details"
        Me.txtIsHidePrice.Properties.OnText = "Hide Price Details"
        Me.txtIsHidePrice.Size = New System.Drawing.Size(175, 24)
        Me.txtIsHidePrice.TabIndex = 88
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(24, 31)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(87, 14)
        Me.LabelControl7.TabIndex = 87
        Me.LabelControl7.Text = "Sub Group Code:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(246, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(71, 14)
        Me.LabelControl3.TabIndex = 85
        Me.LabelControl3.Text = "Quotation No:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(24, 120)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(147, 14)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Sub Group Remarks / Notes:"
        '
        'txtRemarks
        '
        Me.txtRemarks.EnterMoveNextControl = True
        Me.txtRemarks.Location = New System.Drawing.Point(21, 137)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Properties.Appearance.Options.UseForeColor = True
        Me.txtRemarks.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRemarks.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtRemarks.Size = New System.Drawing.Size(438, 22)
        Me.txtRemarks.TabIndex = 10
        '
        'txtQuotationNo
        '
        Me.txtQuotationNo.Enabled = False
        Me.txtQuotationNo.EnterMoveNextControl = True
        Me.txtQuotationNo.Location = New System.Drawing.Point(243, 48)
        Me.txtQuotationNo.Name = "txtQuotationNo"
        Me.txtQuotationNo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtQuotationNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuotationNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtQuotationNo.Properties.Appearance.Options.UseBackColor = True
        Me.txtQuotationNo.Properties.Appearance.Options.UseFont = True
        Me.txtQuotationNo.Properties.Appearance.Options.UseForeColor = True
        Me.txtQuotationNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuotationNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtQuotationNo.Size = New System.Drawing.Size(216, 22)
        Me.txtQuotationNo.TabIndex = 84
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(24, 75)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(91, 14)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Sub Group Name:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAdd.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Appearance.Options.UseForeColor = True
        Me.cmdAdd.ImageOptions.Image = Global.ERP.My.Resources.Resources.add
        Me.cmdAdd.Location = New System.Drawing.Point(567, 127)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(114, 32)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "Add"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(21, 7)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(322, 12)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Type a New Quotation Item Sub Group && Add to the Existing List:"
        '
        'txtSubGroupCode
        '
        Me.txtSubGroupCode.Location = New System.Drawing.Point(21, 48)
        Me.txtSubGroupCode.Name = "txtSubGroupCode"
        Me.txtSubGroupCode.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSubGroupCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubGroupCode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtSubGroupCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubGroupCode.Properties.Appearance.Options.UseFont = True
        Me.txtSubGroupCode.Properties.Appearance.Options.UseForeColor = True
        Me.txtSubGroupCode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSubGroupCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtSubGroupCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSubGroupCode.Properties.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.txtSubGroupCode.Size = New System.Drawing.Size(216, 22)
        Me.txtSubGroupCode.TabIndex = 86
        '
        'txtSubGroupName
        '
        Me.txtSubGroupName.Location = New System.Drawing.Point(21, 92)
        Me.txtSubGroupName.Name = "txtSubGroupName"
        Me.txtSubGroupName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSubGroupName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubGroupName.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtSubGroupName.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubGroupName.Properties.Appearance.Options.UseFont = True
        Me.txtSubGroupName.Properties.Appearance.Options.UseForeColor = True
        Me.txtSubGroupName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSubGroupName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtSubGroupName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSubGroupName.Size = New System.Drawing.Size(438, 22)
        Me.txtSubGroupName.TabIndex = 2
        '
        'gcDrillDetails
        '
        Me.gcDrillDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDrillDetails.DataSource = Me.Tbl60107QuotationChildItemGroupBindingSource
        Me.gcDrillDetails.Location = New System.Drawing.Point(2, 179)
        Me.gcDrillDetails.LookAndFeel.SkinName = "Blue"
        Me.gcDrillDetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcDrillDetails.MainView = Me.gvDrillsDetails
        Me.gcDrillDetails.Name = "gcDrillDetails"
        Me.gcDrillDetails.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemCheckEdit1, Me.repoRemarks, Me.RepositoryItemCheckEdit2})
        Me.gcDrillDetails.Size = New System.Drawing.Size(750, 289)
        Me.gcDrillDetails.TabIndex = 2
        Me.gcDrillDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDrillsDetails, Me.GridView5})
        '
        'Tbl60107QuotationChildItemGroupBindingSource
        '
        Me.Tbl60107QuotationChildItemGroupBindingSource.DataMember = "tbl601_07QuotationChildItemGroup"
        Me.Tbl60107QuotationChildItemGroupBindingSource.DataSource = Me.Dsfrm600_15QuotationSubGroups
        '
        'Dsfrm600_15QuotationSubGroups
        '
        Me.Dsfrm600_15QuotationSubGroups.DataSetName = "dsfrm600_15QuotationSubGroups"
        Me.Dsfrm600_15QuotationSubGroups.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvDrillsDetails
        '
        Me.gvDrillsDetails.ColumnPanelRowHeight = 28
        Me.gvDrillsDetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQuoteGroupItemSlNo, Me.colQuotationNo, Me.colGroupCode, Me.colGroupName, Me.colGroupRemarks, Me.colIsShowLineItemsTotal})
        Me.gvDrillsDetails.CustomizationFormBounds = New System.Drawing.Rectangle(604, 454, 0, 155)
        Me.gvDrillsDetails.DetailHeight = 284
        Me.gvDrillsDetails.GridControl = Me.gcDrillDetails
        Me.gvDrillsDetails.Name = "gvDrillsDetails"
        Me.gvDrillsDetails.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDrillsDetails.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvDrillsDetails.OptionsSelection.MultiSelect = True
        Me.gvDrillsDetails.OptionsView.ShowGroupPanel = False
        Me.gvDrillsDetails.RowHeight = 35
        Me.gvDrillsDetails.RowSeparatorHeight = 1
        '
        'colQuoteGroupItemSlNo
        '
        Me.colQuoteGroupItemSlNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQuoteGroupItemSlNo.AppearanceHeader.Options.UseFont = True
        Me.colQuoteGroupItemSlNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuoteGroupItemSlNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuoteGroupItemSlNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuoteGroupItemSlNo.FieldName = "QuoteGroupItemSlNo"
        Me.colQuoteGroupItemSlNo.Name = "colQuoteGroupItemSlNo"
        '
        'colQuotationNo
        '
        Me.colQuotationNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQuotationNo.AppearanceHeader.Options.UseFont = True
        Me.colQuotationNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuotationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuotationNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuotationNo.FieldName = "QuotationNo"
        Me.colQuotationNo.Name = "colQuotationNo"
        '
        'colGroupCode
        '
        Me.colGroupCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGroupCode.AppearanceHeader.Options.UseFont = True
        Me.colGroupCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colGroupCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGroupCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGroupCode.Caption = "Code"
        Me.colGroupCode.FieldName = "GroupCode"
        Me.colGroupCode.Name = "colGroupCode"
        Me.colGroupCode.Visible = True
        Me.colGroupCode.VisibleIndex = 0
        Me.colGroupCode.Width = 104
        '
        'colGroupName
        '
        Me.colGroupName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGroupName.AppearanceHeader.Options.UseFont = True
        Me.colGroupName.AppearanceHeader.Options.UseTextOptions = True
        Me.colGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGroupName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGroupName.Caption = "Sub Group Name"
        Me.colGroupName.FieldName = "GroupName"
        Me.colGroupName.Name = "colGroupName"
        Me.colGroupName.Visible = True
        Me.colGroupName.VisibleIndex = 1
        Me.colGroupName.Width = 398
        '
        'colGroupRemarks
        '
        Me.colGroupRemarks.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGroupRemarks.AppearanceHeader.Options.UseFont = True
        Me.colGroupRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colGroupRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGroupRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGroupRemarks.Caption = "Notes"
        Me.colGroupRemarks.FieldName = "GroupRemarks"
        Me.colGroupRemarks.Name = "colGroupRemarks"
        Me.colGroupRemarks.Visible = True
        Me.colGroupRemarks.VisibleIndex = 2
        Me.colGroupRemarks.Width = 456
        '
        'colIsShowLineItemsTotal
        '
        Me.colIsShowLineItemsTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsShowLineItemsTotal.AppearanceHeader.Options.UseFont = True
        Me.colIsShowLineItemsTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsShowLineItemsTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsShowLineItemsTotal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsShowLineItemsTotal.Caption = "Hide Price"
        Me.colIsShowLineItemsTotal.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colIsShowLineItemsTotal.FieldName = "IsShowLineItemsTotal"
        Me.colIsShowLineItemsTotal.Name = "colIsShowLineItemsTotal"
        Me.colIsShowLineItemsTotal.Visible = True
        Me.colIsShowLineItemsTotal.VisibleIndex = 3
        Me.colIsShowLineItemsTotal.Width = 109
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1
        Me.RepositoryItemCheckEdit2.CheckBoxOptions.SvgColorChecked = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RepositoryItemCheckEdit2.CheckBoxOptions.SvgColorGrayed = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RepositoryItemCheckEdit2.CheckBoxOptions.SvgColorUnchecked = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'repoRemarks
        '
        Me.repoRemarks.Name = "repoRemarks"
        '
        'GridView5
        '
        Me.GridView5.DetailHeight = 284
        Me.GridView5.GridControl = Me.gcDrillDetails
        Me.GridView5.Name = "GridView5"
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.cmdClose)
        Me.PanelControl3.Controls.Add(Me.cmdUpdate)
        Me.PanelControl3.Location = New System.Drawing.Point(2, 472)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(750, 43)
        Me.PanelControl3.TabIndex = 73
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageOptions.Image = Global.ERP.My.Resources.Resources.GoBackBlue24x24
        Me.cmdClose.Location = New System.Drawing.Point(651, 6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(95, 32)
        Me.cmdClose.TabIndex = 33
        Me.cmdClose.Text = "Back"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ImageOptions.Image = Global.ERP.My.Resources.Resources.Save24x24
        Me.cmdUpdate.Location = New System.Drawing.Point(5, 4)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(96, 33)
        Me.cmdUpdate.TabIndex = 34
        Me.cmdUpdate.Text = "Update"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'Tbl601_07QuotationChildItemGroupTableAdapter
        '
        Me.Tbl601_07QuotationChildItemGroupTableAdapter.ClearBeforeFill = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(468, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl2.TabIndex = 90
        Me.LabelControl2.Text = "MPR No:"
        '
        'txtMPRNo
        '
        Me.txtMPRNo.Enabled = False
        Me.txtMPRNo.EnterMoveNextControl = True
        Me.txtMPRNo.Location = New System.Drawing.Point(465, 48)
        Me.txtMPRNo.Name = "txtMPRNo"
        Me.txtMPRNo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMPRNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMPRNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtMPRNo.Properties.Appearance.Options.UseBackColor = True
        Me.txtMPRNo.Properties.Appearance.Options.UseFont = True
        Me.txtMPRNo.Properties.Appearance.Options.UseForeColor = True
        Me.txtMPRNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMPRNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtMPRNo.Size = New System.Drawing.Size(216, 22)
        Me.txtMPRNo.TabIndex = 89
        '
        'frm600_15QuotationSubGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 518)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.gcDrillDetails)
        Me.Controls.Add(Me.PanelControl2)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm600_15QuotationSubGroups"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quotation Line Items - Sub Grouping"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtIsHidePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuotationNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubGroupCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubGroupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDrillDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl60107QuotationChildItemGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm600_15QuotationSubGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDrillsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMPRNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQuotationNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubGroupCode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtIsHidePrice As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents gcDrillDetails As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDrillsDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repoRemarks As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSubGroupName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents Tbl60107QuotationChildItemGroupBindingSource As BindingSource
    Friend WithEvents Dsfrm600_15QuotationSubGroups As dsfrm600_15QuotationSubGroups
    Friend WithEvents colQuoteGroupItemSlNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuotationNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGroupCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGroupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGroupRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsShowLineItemsTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Tbl601_07QuotationChildItemGroupTableAdapter As dsfrm600_15QuotationSubGroupsTableAdapters.tbl601_07QuotationChildItemGroupTableAdapter
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMPRNo As DevExpress.XtraEditors.TextEdit
End Class
