<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm600_03RequestedBy
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
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPropertyCategory = New DevExpress.XtraEditors.TextEdit()
        Me.gcDrillDetails = New DevExpress.XtraGrid.GridControl()
        Me.Tbl60002RequestedByBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds401SubForms = New ERP.ds401SubForms()
        Me.gvDrillsDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Tbl600_02RequestedByTableAdapter = New ERP.ds401SubFormsTableAdapters.tbl600_02RequestedByTableAdapter()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtPropertyCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDrillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl60002RequestedByBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds401SubForms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDrillsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.cmdAdd)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.txtPropertyCategory)
        Me.PanelControl2.Location = New System.Drawing.Point(5, 4)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(626, 85)
        Me.PanelControl2.TabIndex = 67
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAdd.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Appearance.Options.UseForeColor = True
        Me.cmdAdd.Image = Global.ERP.My.Resources.Resources.add
        Me.cmdAdd.Location = New System.Drawing.Point(506, 32)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(111, 39)
        Me.cmdAdd.TabIndex = 35
        Me.cmdAdd.Text = "Add"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl4.Location = New System.Drawing.Point(9, 18)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(277, 15)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Type new Requested By && Add to the Existing List:"
        '
        'txtPropertyCategory
        '
        Me.txtPropertyCategory.EnterMoveNextControl = True
        Me.txtPropertyCategory.Location = New System.Drawing.Point(9, 44)
        Me.txtPropertyCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPropertyCategory.Name = "txtPropertyCategory"
        Me.txtPropertyCategory.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPropertyCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyCategory.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtPropertyCategory.Properties.Appearance.Options.UseBackColor = True
        Me.txtPropertyCategory.Properties.Appearance.Options.UseFont = True
        Me.txtPropertyCategory.Properties.Appearance.Options.UseForeColor = True
        Me.txtPropertyCategory.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPropertyCategory.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtPropertyCategory.Size = New System.Drawing.Size(471, 26)
        Me.txtPropertyCategory.TabIndex = 47
        '
        'gcDrillDetails
        '
        Me.gcDrillDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDrillDetails.DataSource = Me.Tbl60002RequestedByBindingSource
        Me.gcDrillDetails.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcDrillDetails.Location = New System.Drawing.Point(5, 96)
        Me.gcDrillDetails.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcDrillDetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcDrillDetails.MainView = Me.gvDrillsDetails
        Me.gcDrillDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcDrillDetails.Name = "gcDrillDetails"
        Me.gcDrillDetails.Size = New System.Drawing.Size(626, 494)
        Me.gcDrillDetails.TabIndex = 68
        Me.gcDrillDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDrillsDetails, Me.GridView5})
        '
        'Tbl60002RequestedByBindingSource
        '
        Me.Tbl60002RequestedByBindingSource.DataMember = "tbl600_02RequestedBy"
        Me.Tbl60002RequestedByBindingSource.DataSource = Me.Ds401SubForms
        '
        'Ds401SubForms
        '
        Me.Ds401SubForms.DataSetName = "ds401SubForms"
        Me.Ds401SubForms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvDrillsDetails
        '
        Me.gvDrillsDetails.ColumnPanelRowHeight = 35
        Me.gvDrillsDetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryID, Me.colCategoryTitle})
        Me.gvDrillsDetails.CustomizationFormBounds = New System.Drawing.Rectangle(604, 454, 208, 191)
        Me.gvDrillsDetails.GridControl = Me.gcDrillDetails
        Me.gvDrillsDetails.Name = "gvDrillsDetails"
        Me.gvDrillsDetails.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDrillsDetails.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvDrillsDetails.OptionsSelection.MultiSelect = True
        Me.gvDrillsDetails.OptionsView.ShowGroupPanel = False
        Me.gvDrillsDetails.RowHeight = 35
        Me.gvDrillsDetails.RowSeparatorHeight = 1
        '
        'colCategoryID
        '
        Me.colCategoryID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCategoryID.AppearanceCell.Options.UseFont = True
        Me.colCategoryID.AppearanceCell.Options.UseTextOptions = True
        Me.colCategoryID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCategoryID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCategoryID.AppearanceHeader.Options.UseFont = True
        Me.colCategoryID.AppearanceHeader.Options.UseTextOptions = True
        Me.colCategoryID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCategoryID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCategoryID.Caption = "Code"
        Me.colCategoryID.FieldName = "RequestedByCode"
        Me.colCategoryID.Name = "colCategoryID"
        Me.colCategoryID.OptionsColumn.AllowEdit = False
        Me.colCategoryID.Visible = True
        Me.colCategoryID.VisibleIndex = 0
        Me.colCategoryID.Width = 81
        '
        'colCategoryTitle
        '
        Me.colCategoryTitle.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCategoryTitle.AppearanceCell.Options.UseFont = True
        Me.colCategoryTitle.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCategoryTitle.AppearanceHeader.Options.UseFont = True
        Me.colCategoryTitle.AppearanceHeader.Options.UseTextOptions = True
        Me.colCategoryTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCategoryTitle.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCategoryTitle.Caption = "Material Requested By"
        Me.colCategoryTitle.FieldName = "RequestedBy"
        Me.colCategoryTitle.Name = "colCategoryTitle"
        Me.colCategoryTitle.Visible = True
        Me.colCategoryTitle.VisibleIndex = 1
        Me.colCategoryTitle.Width = 438
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.gcDrillDetails
        Me.GridView5.Name = "GridView5"
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.cmdClose)
        Me.PanelControl3.Controls.Add(Me.cmdUpdate)
        Me.PanelControl3.Location = New System.Drawing.Point(5, 594)
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(626, 53)
        Me.PanelControl3.TabIndex = 69
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.Image = Global.ERP.My.Resources.Resources.GoBackBlue24x24
        Me.cmdClose.Location = New System.Drawing.Point(506, 6)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(111, 39)
        Me.cmdClose.TabIndex = 33
        Me.cmdClose.Text = "Back"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Image = Global.ERP.My.Resources.Resources.Save24x24
        Me.cmdUpdate.Location = New System.Drawing.Point(6, 6)
        Me.cmdUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(112, 41)
        Me.cmdUpdate.TabIndex = 34
        Me.cmdUpdate.Text = "Update"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'Tbl600_02RequestedByTableAdapter
        '
        Me.Tbl600_02RequestedByTableAdapter.ClearBeforeFill = True
        '
        'frm600_03RequestedBy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 650)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.gcDrillDetails)
        Me.Controls.Add(Me.PanelControl2)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm600_03RequestedBy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Requested By:"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtPropertyCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDrillDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl60002RequestedByBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds401SubForms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDrillsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPropertyCategory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcDrillDetails As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDrillsDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents Ds401SubForms As ERP.ds401SubForms
    Friend WithEvents Tbl60002RequestedByBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl600_02RequestedByTableAdapter As ERP.ds401SubFormsTableAdapters.tbl600_02RequestedByTableAdapter
End Class
