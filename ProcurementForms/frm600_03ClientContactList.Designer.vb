<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm600_03ClientContactList
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
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm600_03ClientContactList))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.gcContactList = New DevExpress.XtraGrid.GridControl()
        Me.Tbl3010102ClientContactListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm600_03ClientContactList = New ERP.dsfrm600_03ClientContactList()
        Me.gvContactList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colClientContactSlNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPersonTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactMobile1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactMobile2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPhone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPhone2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactFaxNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDefault = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoAddClientContact = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colContactLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactDivision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtClientCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientName = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Tbl30101_02ClientContactListTableAdapter = New ERP.dsfrm600_03ClientContactListTableAdapters.tbl30101_02ClientContactListTableAdapter()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcContactList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl3010102ClientContactListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm600_03ClientContactList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvContactList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoAddClientContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.RoyalBlue
        Me.PanelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(21, 344)
        Me.PanelControl2.TabIndex = 76
        '
        'gcContactList
        '
        Me.gcContactList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcContactList.DataSource = Me.Tbl3010102ClientContactListBindingSource
        Me.gcContactList.Location = New System.Drawing.Point(24, 54)
        Me.gcContactList.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcContactList.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcContactList.MainView = Me.gvContactList
        Me.gcContactList.Name = "gcContactList"
        Me.gcContactList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemImageComboBox1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemHyperLinkEdit2, Me.repoAddClientContact})
        Me.gcContactList.Size = New System.Drawing.Size(832, 289)
        Me.gcContactList.TabIndex = 95
        Me.gcContactList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvContactList, Me.GridView10})
        '
        'Tbl3010102ClientContactListBindingSource
        '
        Me.Tbl3010102ClientContactListBindingSource.DataMember = "tbl30101_02ClientContactList"
        Me.Tbl3010102ClientContactListBindingSource.DataSource = Me.Dsfrm600_03ClientContactList
        '
        'Dsfrm600_03ClientContactList
        '
        Me.Dsfrm600_03ClientContactList.DataSetName = "dsfrm600_03ClientContactList"
        Me.Dsfrm600_03ClientContactList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvContactList
        '
        Me.gvContactList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvContactList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvContactList.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvContactList.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvContactList.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvContactList.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvContactList.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvContactList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvContactList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvContactList.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvContactList.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvContactList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvContactList.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvContactList.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvContactList.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvContactList.Appearance.Empty.Options.UseBackColor = True
        Me.gvContactList.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent
        Me.gvContactList.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvContactList.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvContactList.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvContactList.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvContactList.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvContactList.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvContactList.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvContactList.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvContactList.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvContactList.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvContactList.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvContactList.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvContactList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvContactList.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvContactList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvContactList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvContactList.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvContactList.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvContactList.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvContactList.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvContactList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvContactList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvContactList.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvContactList.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvContactList.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvContactList.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvContactList.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvContactList.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvContactList.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvContactList.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvContactList.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvContactList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvContactList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvContactList.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvContactList.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvContactList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvContactList.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvContactList.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvContactList.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvContactList.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvContactList.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvContactList.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvContactList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvContactList.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvContactList.Appearance.GroupRow.Options.UseFont = True
        Me.gvContactList.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvContactList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvContactList.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvContactList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvContactList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvContactList.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvContactList.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvContactList.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvContactList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvContactList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvContactList.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvContactList.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvContactList.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvContactList.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.OddRow.Options.UseBackColor = True
        Me.gvContactList.Appearance.OddRow.Options.UseForeColor = True
        Me.gvContactList.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvContactList.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvContactList.Appearance.Preview.Options.UseBackColor = True
        Me.gvContactList.Appearance.Preview.Options.UseForeColor = True
        Me.gvContactList.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvContactList.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvContactList.Appearance.Row.Options.UseBackColor = True
        Me.gvContactList.Appearance.Row.Options.UseForeColor = True
        Me.gvContactList.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvContactList.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvContactList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvContactList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvContactList.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvContactList.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvContactList.ColumnPanelRowHeight = 40
        Me.gvContactList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClientContactSlNo, Me.colClientCode1, Me.colContactPerson, Me.colContactPersonTitle, Me.colContactMobile1, Me.colContactMobile2, Me.colContactPhone1, Me.colContactPhone2, Me.colContactEmail, Me.colContactFaxNo, Me.colContactRemarks, Me.colIsDefault, Me.GridColumn1, Me.colContactLocation, Me.colContactDivision, Me.colCreatedBy, Me.colCreatedOn, Me.colModifiedBy, Me.colModifiedOn})
        Me.gvContactList.CustomizationFormBounds = New System.Drawing.Rectangle(604, 454, 208, 191)
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Name = "FormatSystemAlerts"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.PeachPuff
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "[AlertType] = 1"
        FormatConditionRuleValue1.Value1 = CType(1, Short)
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Name = "FormatReminders"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.LightCyan
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = CType(2, Short)
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Name = "FormatAssignments"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue3.Value1 = CType(3, Short)
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Name = "formatDone"
        FormatConditionRuleValue4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Strikeout)
        FormatConditionRuleValue4.Appearance.Options.UseFont = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue4.Value1 = True
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.gvContactList.FormatRules.Add(GridFormatRule1)
        Me.gvContactList.FormatRules.Add(GridFormatRule2)
        Me.gvContactList.FormatRules.Add(GridFormatRule3)
        Me.gvContactList.FormatRules.Add(GridFormatRule4)
        Me.gvContactList.GridControl = Me.gcContactList
        Me.gvContactList.GroupRowHeight = 30
        Me.gvContactList.Name = "gvContactList"
        Me.gvContactList.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvContactList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvContactList.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvContactList.OptionsSelection.MultiSelect = True
        Me.gvContactList.OptionsView.ShowGroupPanel = False
        Me.gvContactList.OptionsView.ShowIndicator = False
        Me.gvContactList.RowHeight = 45
        '
        'colClientContactSlNo
        '
        Me.colClientContactSlNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientContactSlNo.AppearanceHeader.Options.UseFont = True
        Me.colClientContactSlNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientContactSlNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientContactSlNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientContactSlNo.FieldName = "ClientContactSlNo"
        Me.colClientContactSlNo.Name = "colClientContactSlNo"
        '
        'colClientCode1
        '
        Me.colClientCode1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientCode1.AppearanceHeader.Options.UseFont = True
        Me.colClientCode1.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientCode1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientCode1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientCode1.FieldName = "ClientCode"
        Me.colClientCode1.Name = "colClientCode1"
        '
        'colContactPerson
        '
        Me.colContactPerson.AppearanceCell.Options.UseTextOptions = True
        Me.colContactPerson.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactPerson.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactPerson.AppearanceHeader.Options.UseFont = True
        Me.colContactPerson.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactPerson.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactPerson.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactPerson.Caption = "Name"
        Me.colContactPerson.FieldName = "ContactPerson"
        Me.colContactPerson.Name = "colContactPerson"
        Me.colContactPerson.Visible = True
        Me.colContactPerson.VisibleIndex = 0
        Me.colContactPerson.Width = 179
        '
        'colContactPersonTitle
        '
        Me.colContactPersonTitle.AppearanceCell.Options.UseTextOptions = True
        Me.colContactPersonTitle.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactPersonTitle.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactPersonTitle.AppearanceHeader.Options.UseFont = True
        Me.colContactPersonTitle.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactPersonTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactPersonTitle.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactPersonTitle.Caption = "Title"
        Me.colContactPersonTitle.FieldName = "ContactPersonTitle"
        Me.colContactPersonTitle.Name = "colContactPersonTitle"
        Me.colContactPersonTitle.Visible = True
        Me.colContactPersonTitle.VisibleIndex = 1
        Me.colContactPersonTitle.Width = 115
        '
        'colContactMobile1
        '
        Me.colContactMobile1.AppearanceCell.Options.UseTextOptions = True
        Me.colContactMobile1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactMobile1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactMobile1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactMobile1.AppearanceHeader.Options.UseFont = True
        Me.colContactMobile1.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactMobile1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactMobile1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactMobile1.Caption = "Mobile"
        Me.colContactMobile1.FieldName = "ContactMobile1"
        Me.colContactMobile1.Name = "colContactMobile1"
        Me.colContactMobile1.Visible = True
        Me.colContactMobile1.VisibleIndex = 3
        Me.colContactMobile1.Width = 83
        '
        'colContactMobile2
        '
        Me.colContactMobile2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactMobile2.AppearanceHeader.Options.UseFont = True
        Me.colContactMobile2.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactMobile2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactMobile2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactMobile2.Caption = "Mobile 2"
        Me.colContactMobile2.FieldName = "ContactMobile2"
        Me.colContactMobile2.Name = "colContactMobile2"
        '
        'colContactPhone1
        '
        Me.colContactPhone1.AppearanceCell.Options.UseTextOptions = True
        Me.colContactPhone1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactPhone1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactPhone1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactPhone1.AppearanceHeader.Options.UseFont = True
        Me.colContactPhone1.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactPhone1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactPhone1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactPhone1.Caption = "Phone"
        Me.colContactPhone1.FieldName = "ContactPhone1"
        Me.colContactPhone1.Name = "colContactPhone1"
        Me.colContactPhone1.Visible = True
        Me.colContactPhone1.VisibleIndex = 4
        Me.colContactPhone1.Width = 86
        '
        'colContactPhone2
        '
        Me.colContactPhone2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactPhone2.AppearanceHeader.Options.UseFont = True
        Me.colContactPhone2.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactPhone2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactPhone2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactPhone2.Caption = "Phone 2"
        Me.colContactPhone2.FieldName = "ContactPhone2"
        Me.colContactPhone2.Name = "colContactPhone2"
        '
        'colContactEmail
        '
        Me.colContactEmail.AppearanceCell.Options.UseTextOptions = True
        Me.colContactEmail.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactEmail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactEmail.AppearanceHeader.Options.UseFont = True
        Me.colContactEmail.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactEmail.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactEmail.Caption = "Email"
        Me.colContactEmail.FieldName = "ContactEmail"
        Me.colContactEmail.Name = "colContactEmail"
        Me.colContactEmail.Visible = True
        Me.colContactEmail.VisibleIndex = 2
        Me.colContactEmail.Width = 120
        '
        'colContactFaxNo
        '
        Me.colContactFaxNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactFaxNo.AppearanceHeader.Options.UseFont = True
        Me.colContactFaxNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactFaxNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactFaxNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactFaxNo.Caption = "Fax No"
        Me.colContactFaxNo.FieldName = "ContactFaxNo"
        Me.colContactFaxNo.Name = "colContactFaxNo"
        Me.colContactFaxNo.Width = 130
        '
        'colContactRemarks
        '
        Me.colContactRemarks.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactRemarks.AppearanceHeader.Options.UseFont = True
        Me.colContactRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactRemarks.Caption = "Remarks"
        Me.colContactRemarks.FieldName = "ContactRemarks"
        Me.colContactRemarks.Name = "colContactRemarks"
        '
        'colIsDefault
        '
        Me.colIsDefault.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIsDefault.AppearanceHeader.Options.UseFont = True
        Me.colIsDefault.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsDefault.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsDefault.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsDefault.FieldName = "IsDefault"
        Me.colIsDefault.Name = "colIsDefault"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Add"
        Me.GridColumn1.ColumnEdit = Me.repoAddClientContact
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 56
        '
        'repoAddClientContact
        '
        Me.repoAddClientContact.AutoHeight = False
        Me.repoAddClientContact.Name = "repoAddClientContact"
        Me.repoAddClientContact.NullText = "Add"
        '
        'colContactLocation
        '
        Me.colContactLocation.AppearanceCell.Options.UseTextOptions = True
        Me.colContactLocation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactLocation.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactLocation.AppearanceHeader.Options.UseFont = True
        Me.colContactLocation.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactLocation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactLocation.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactLocation.Caption = "Location"
        Me.colContactLocation.FieldName = "ContactLocation"
        Me.colContactLocation.Name = "colContactLocation"
        Me.colContactLocation.Visible = True
        Me.colContactLocation.VisibleIndex = 5
        Me.colContactLocation.Width = 80
        '
        'colContactDivision
        '
        Me.colContactDivision.AppearanceCell.Options.UseTextOptions = True
        Me.colContactDivision.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactDivision.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContactDivision.AppearanceHeader.Options.UseFont = True
        Me.colContactDivision.AppearanceHeader.Options.UseTextOptions = True
        Me.colContactDivision.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContactDivision.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colContactDivision.Caption = "Division"
        Me.colContactDivision.FieldName = "ContactDivision"
        Me.colContactDivision.Name = "colContactDivision"
        Me.colContactDivision.Visible = True
        Me.colContactDivision.VisibleIndex = 6
        Me.colContactDivision.Width = 111
        '
        'colCreatedBy
        '
        Me.colCreatedBy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCreatedBy.AppearanceHeader.Options.UseFont = True
        Me.colCreatedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreatedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        '
        'colCreatedOn
        '
        Me.colCreatedOn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCreatedOn.AppearanceHeader.Options.UseFont = True
        Me.colCreatedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreatedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCreatedOn.FieldName = "CreatedOn"
        Me.colCreatedOn.Name = "colCreatedOn"
        '
        'colModifiedBy
        '
        Me.colModifiedBy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModifiedBy.AppearanceHeader.Options.UseFont = True
        Me.colModifiedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        '
        'colModifiedOn
        '
        Me.colModifiedOn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModifiedOn.AppearanceHeader.Options.UseFont = True
        Me.colModifiedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedOn.FieldName = "ModifiedOn"
        Me.colModifiedOn.Name = "colModifiedOn"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "DepartmentName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView8
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "DepartmentCode"
        '
        'GridView8
        '
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Life Saving", CType(1, Byte), 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Urgent", CType(2, Byte), 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("ASAP", CType(3, Byte), 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Routine", CType(4, Byte), 1)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "ModeOfPurchaseDescription"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.PopupView = Me.GridView6
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "ModeOfPurchaseCode"
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "ApprovalStatus"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = ""
        Me.RepositoryItemGridLookUpEdit3.PopupView = Me.GridView9
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "ApprovalStatusId"
        '
        'GridView9
        '
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        '
        'GridView10
        '
        Me.GridView10.GridControl = Me.gcContactList
        Me.GridView10.Name = "GridView10"
        '
        'txtClientCode
        '
        Me.txtClientCode.Enabled = False
        Me.txtClientCode.EnterMoveNextControl = True
        Me.txtClientCode.Location = New System.Drawing.Point(25, 25)
        Me.txtClientCode.Name = "txtClientCode"
        Me.txtClientCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.txtClientCode.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientCode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtClientCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtClientCode.Properties.Appearance.Options.UseFont = True
        Me.txtClientCode.Properties.Appearance.Options.UseForeColor = True
        Me.txtClientCode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtClientCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtClientCode.Size = New System.Drawing.Size(149, 22)
        Me.txtClientCode.TabIndex = 97
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(28, 8)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(65, 14)
        Me.LabelControl8.TabIndex = 96
        Me.LabelControl8.Text = "Client Code:"
        '
        'txtClientName
        '
        Me.txtClientName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClientName.Location = New System.Drawing.Point(182, 24)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtClientName.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!)
        Me.txtClientName.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtClientName.Properties.Appearance.Options.UseBackColor = True
        Me.txtClientName.Properties.Appearance.Options.UseFont = True
        Me.txtClientName.Properties.Appearance.Options.UseForeColor = True
        Me.txtClientName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtClientName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txtClientName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtClientName.Size = New System.Drawing.Size(674, 24)
        Me.txtClientName.TabIndex = 99
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(185, 8)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl4.TabIndex = 98
        Me.LabelControl4.Text = "Client Name:"
        '
        'Tbl30101_02ClientContactListTableAdapter
        '
        Me.Tbl30101_02ClientContactListTableAdapter.ClearBeforeFill = True
        '
        'frm600_03ClientContactList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 344)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtClientCode)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.gcContactList)
        Me.Controls.Add(Me.PanelControl2)
        Me.IconOptions.Icon = CType(resources.GetObject("frm600_03ClientContactList.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm600_03ClientContactList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Contact List"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcContactList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl3010102ClientContactListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm600_03ClientContactList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvContactList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoAddClientContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcContactList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvContactList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colClientContactSlNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPersonTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactMobile1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactMobile2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPhone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPhone2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactFaxNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDefault As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtClientCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClientName As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Tbl3010102ClientContactListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dsfrm600_03ClientContactList As ERP.dsfrm600_03ClientContactList
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoAddClientContact As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents Tbl30101_02ClientContactListTableAdapter As ERP.dsfrm600_03ClientContactListTableAdapters.tbl30101_02ClientContactListTableAdapter
    Friend WithEvents colContactLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactDivision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedOn As DevExpress.XtraGrid.Columns.GridColumn
End Class
