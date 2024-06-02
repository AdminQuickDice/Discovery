<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm600_14ProjectSubUnits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm600_14ProjectSubUnits))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProjectSubUnitName = New DevExpress.XtraEditors.TextEdit()
        Me.gcDrillDetails = New DevExpress.XtraGrid.GridControl()
        Me.Tbl60604PurchaseRequestProjectSubUnitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm600_14ProjectSubUnits = New ERP.dsfrm600_14ProjectSubUnits()
        Me.gvDrillsDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.popupSubForm = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnDeleteEntry = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter = New ERP.dsfrm600_14ProjectSubUnitsTableAdapters.tbl606_04PurchaseRequestProjectSubUnitsTableAdapter()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtProjectSubUnitName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDrillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl60604PurchaseRequestProjectSubUnitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm600_14ProjectSubUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDrillsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.popupSubForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.cmdAdd)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.txtProjectSubUnitName)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 6)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(523, 69)
        Me.PanelControl2.TabIndex = 76
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAdd.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Appearance.Options.UseForeColor = True
        Me.cmdAdd.ImageOptions.Image = Global.ERP.My.Resources.Resources.add
        Me.cmdAdd.Location = New System.Drawing.Point(421, 26)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(95, 32)
        Me.cmdAdd.TabIndex = 35
        Me.cmdAdd.Text = "Add"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(245, 12)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Type new Project Sub Unit && Add to the Existing List:"
        '
        'txtProjectSubUnitName
        '
        Me.txtProjectSubUnitName.EnterMoveNextControl = True
        Me.txtProjectSubUnitName.Location = New System.Drawing.Point(8, 36)
        Me.txtProjectSubUnitName.Name = "txtProjectSubUnitName"
        Me.txtProjectSubUnitName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProjectSubUnitName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectSubUnitName.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtProjectSubUnitName.Properties.Appearance.Options.UseBackColor = True
        Me.txtProjectSubUnitName.Properties.Appearance.Options.UseFont = True
        Me.txtProjectSubUnitName.Properties.Appearance.Options.UseForeColor = True
        Me.txtProjectSubUnitName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtProjectSubUnitName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtProjectSubUnitName.Size = New System.Drawing.Size(404, 22)
        Me.txtProjectSubUnitName.TabIndex = 47
        '
        'gcDrillDetails
        '
        Me.gcDrillDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDrillDetails.DataSource = Me.Tbl60604PurchaseRequestProjectSubUnitsBindingSource
        Me.gcDrillDetails.Location = New System.Drawing.Point(11, 81)
        Me.gcDrillDetails.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcDrillDetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcDrillDetails.MainView = Me.gvDrillsDetails
        Me.gcDrillDetails.Name = "gcDrillDetails"
        Me.gcDrillDetails.Size = New System.Drawing.Size(523, 395)
        Me.gcDrillDetails.TabIndex = 77
        Me.gcDrillDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDrillsDetails, Me.GridView5})
        '
        'Tbl60604PurchaseRequestProjectSubUnitsBindingSource
        '
        Me.Tbl60604PurchaseRequestProjectSubUnitsBindingSource.DataMember = "tbl606_04PurchaseRequestProjectSubUnits"
        Me.Tbl60604PurchaseRequestProjectSubUnitsBindingSource.DataSource = Me.Dsfrm600_14ProjectSubUnits
        '
        'Dsfrm600_14ProjectSubUnits
        '
        Me.Dsfrm600_14ProjectSubUnits.DataSetName = "dsfrm600_14ProjectSubUnits"
        Me.Dsfrm600_14ProjectSubUnits.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.colCategoryID.FieldName = "ProjectSubUnitCode"
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
        Me.colCategoryTitle.Caption = "Project Unit Name"
        Me.colCategoryTitle.FieldName = "ProjectSubUnitName"
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
        Me.PanelControl3.Location = New System.Drawing.Point(11, 480)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(523, 43)
        Me.PanelControl3.TabIndex = 78
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageOptions.Image = Global.ERP.My.Resources.Resources.GoBackBlue24x24
        Me.cmdClose.Location = New System.Drawing.Point(419, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(95, 32)
        Me.cmdClose.TabIndex = 33
        Me.cmdClose.Text = "Back"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ImageOptions.Image = Global.ERP.My.Resources.Resources.Save24x24
        Me.cmdUpdate.Location = New System.Drawing.Point(5, 5)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(96, 33)
        Me.cmdUpdate.TabIndex = 34
        Me.cmdUpdate.Text = "Update"
        '
        'popupSubForm
        '
        Me.popupSubForm.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDeleteEntry, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.popupSubForm.Manager = Me.BarManager1
        Me.popupSubForm.Name = "popupSubForm"
        '
        'btnDeleteEntry
        '
        Me.btnDeleteEntry.Caption = "Delete Entry"
        Me.btnDeleteEntry.Id = 0
        Me.btnDeleteEntry.ImageOptions.Image = CType(resources.GetObject("btnDeleteEntry.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteEntry.ImageOptions.LargeImage = CType(resources.GetObject("btnDeleteEntry.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDeleteEntry.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteEntry.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDeleteEntry.Name = "btnDeleteEntry"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnDeleteEntry})
        Me.BarManager1.MaxItemId = 1
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(545, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 528)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(545, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 528)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(545, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 528)
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter
        '
        Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.ClearBeforeFill = True
        '
        'frm600_14ProjectSubUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 528)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.gcDrillDetails)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm600_14ProjectSubUnits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Sub Units"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtProjectSubUnitName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDrillDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl60604PurchaseRequestProjectSubUnitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm600_14ProjectSubUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDrillsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.popupSubForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProjectSubUnitName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcDrillDetails As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDrillsDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents popupSubForm As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnDeleteEntry As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents Dsfrm600_14ProjectSubUnits As dsfrm600_14ProjectSubUnits
    Friend WithEvents Tbl60604PurchaseRequestProjectSubUnitsBindingSource As BindingSource
    Friend WithEvents Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter As dsfrm600_14ProjectSubUnitsTableAdapters.tbl606_04PurchaseRequestProjectSubUnitsTableAdapter
End Class
