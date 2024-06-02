<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm600_01StoreEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm600_01StoreEdit))
        Me.popupSubForm = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnDeleteEntry = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStoreCode = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStoreName = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtCostCenterCode = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Tbl201CostAllocationUnitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm600_01StoreEdit1 = New ERP.dsfrm600_01StoreEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostAllocationGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostAllocationMasterGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.Dsfrm600_01StoreEdit = New ERP.dsfrm600_01StoreEdit()
        Me.Tbl60001StoreMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl600_01StoreMasterTableAdapter = New ERP.dsfrm600_01StoreEditTableAdapters.tbl600_01StoreMasterTableAdapter()
        Me.gcDrillDetails = New DevExpress.XtraGrid.GridControl()
        Me.gvSubDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStoreID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoreName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostAllocationUnitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoCostCenter = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Tbl201CostAllocationUnitsTableAdapter = New ERP.dsfrm600_01StoreEditTableAdapters.tbl201CostAllocationUnitsTableAdapter()
        CType(Me.popupSubForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtStoreCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStoreName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtCostCenterCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl201CostAllocationUnitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm600_01StoreEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm600_01StoreEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl60001StoreMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDrillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSubDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoCostCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(531, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 522)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(531, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 522)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(531, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 522)
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageOptions.Image = Global.ERP.My.Resources.Resources.GoBackBlue24x24
        Me.cmdClose.Location = New System.Drawing.Point(434, 5)
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
        Me.cmdUpdate.Location = New System.Drawing.Point(5, 4)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(96, 33)
        Me.cmdUpdate.TabIndex = 34
        Me.cmdUpdate.Text = "Update"
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.cmdClose)
        Me.PanelControl3.Controls.Add(Me.cmdUpdate)
        Me.PanelControl3.Location = New System.Drawing.Point(4, 477)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(523, 43)
        Me.PanelControl3.TabIndex = 74
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 57)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 12)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Store Code:"
        '
        'txtStoreCode
        '
        Me.txtStoreCode.EnterMoveNextControl = True
        Me.txtStoreCode.Location = New System.Drawing.Point(13, 71)
        Me.txtStoreCode.Name = "txtStoreCode"
        Me.txtStoreCode.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtStoreCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtStoreCode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtStoreCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtStoreCode.Properties.Appearance.Options.UseFont = True
        Me.txtStoreCode.Properties.Appearance.Options.UseForeColor = True
        Me.txtStoreCode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStoreCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtStoreCode.Properties.MaxLength = 30
        Me.txtStoreCode.Size = New System.Drawing.Size(284, 22)
        Me.txtStoreCode.TabIndex = 5
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAdd.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Appearance.Options.UseForeColor = True
        Me.cmdAdd.ImageOptions.Image = Global.ERP.My.Resources.Resources.add
        Me.cmdAdd.Location = New System.Drawing.Point(420, 106)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(95, 36)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Text = "Add"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(15, 10)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(203, 12)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Type a New Store && Add to the Existing List:"
        '
        'txtStoreName
        '
        Me.txtStoreName.EnterMoveNextControl = True
        Me.txtStoreName.Location = New System.Drawing.Point(13, 27)
        Me.txtStoreName.Name = "txtStoreName"
        Me.txtStoreName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtStoreName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoreName.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtStoreName.Properties.Appearance.Options.UseBackColor = True
        Me.txtStoreName.Properties.Appearance.Options.UseFont = True
        Me.txtStoreName.Properties.Appearance.Options.UseForeColor = True
        Me.txtStoreName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStoreName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtStoreName.Size = New System.Drawing.Size(404, 22)
        Me.txtStoreName.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.txtCostCenterCode)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txtStoreCode)
        Me.PanelControl2.Controls.Add(Me.cmdAdd)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.txtStoreName)
        Me.PanelControl2.Location = New System.Drawing.Point(4, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(523, 150)
        Me.PanelControl2.TabIndex = 72
        '
        'txtCostCenterCode
        '
        Me.txtCostCenterCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostCenterCode.EnterMoveNextControl = True
        Me.txtCostCenterCode.Location = New System.Drawing.Point(15, 123)
        Me.txtCostCenterCode.Name = "txtCostCenterCode"
        Me.txtCostCenterCode.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCostCenterCode.Properties.Appearance.Options.UseFont = True
        Me.txtCostCenterCode.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCostCenterCode.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCostCenterCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCostCenterCode.Properties.DataSource = Me.Tbl201CostAllocationUnitsBindingSource
        Me.txtCostCenterCode.Properties.DisplayMember = "CostAllocationUnit"
        Me.txtCostCenterCode.Properties.ImmediatePopup = True
        Me.txtCostCenterCode.Properties.NullText = ""
        Me.txtCostCenterCode.Properties.PopupFormSize = New System.Drawing.Size(800, 0)
        Me.txtCostCenterCode.Properties.PopupView = Me.GridView14
        Me.txtCostCenterCode.Properties.ValueMember = "CostAllocationUnitID"
        Me.txtCostCenterCode.Size = New System.Drawing.Size(268, 22)
        Me.txtCostCenterCode.TabIndex = 133
        '
        'Tbl201CostAllocationUnitsBindingSource
        '
        Me.Tbl201CostAllocationUnitsBindingSource.DataMember = "tbl201CostAllocationUnits"
        Me.Tbl201CostAllocationUnitsBindingSource.DataSource = Me.Dsfrm600_01StoreEdit1
        '
        'Dsfrm600_01StoreEdit1
        '
        Me.Dsfrm600_01StoreEdit1.DataSetName = "dsfrm600_01StoreEdit"
        Me.Dsfrm600_01StoreEdit1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView14
        '
        Me.GridView14.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView14.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.GridView14.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView14.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView14.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView14.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView14.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.GridView14.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView14.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.GridView14.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView14.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView14.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView14.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView14.Appearance.Empty.Options.UseBackColor = True
        Me.GridView14.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.GridView14.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView14.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView14.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView14.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView14.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GridView14.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView14.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView14.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView14.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView14.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView14.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView14.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView14.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView14.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView14.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView14.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GridView14.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView14.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView14.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple
        Me.GridView14.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView14.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView14.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple
        Me.GridView14.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GridView14.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView14.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView14.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView14.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView14.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView14.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView14.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView14.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView14.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView14.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView14.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView14.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView14.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView14.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView14.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView14.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView14.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GridView14.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView14.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView14.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView14.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray
        Me.GridView14.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView14.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView14.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView14.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView14.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView14.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView14.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView14.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.GridView14.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView14.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView14.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView14.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView14.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView14.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.GridView14.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GridView14.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView14.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView14.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridView14.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.GridView14.Appearance.Preview.ForeColor = System.Drawing.Color.Purple
        Me.GridView14.Appearance.Preview.Options.UseBackColor = True
        Me.GridView14.Appearance.Preview.Options.UseForeColor = True
        Me.GridView14.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView14.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView14.Appearance.Row.Options.UseBackColor = True
        Me.GridView14.Appearance.Row.Options.UseForeColor = True
        Me.GridView14.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView14.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView14.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView14.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView14.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView14.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView14.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView14.Appearance.VertLine.BackColor = System.Drawing.Color.Silver
        Me.GridView14.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn13, Me.colCostAllocationGroup, Me.colCostAllocationMasterGroup})
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView14.OptionsView.EnableAppearanceOddRow = True
        Me.GridView14.OptionsView.ShowAutoFilterRow = True
        Me.GridView14.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView14.OptionsView.ShowGroupPanel = False
        Me.GridView14.RowHeight = 26
        Me.GridView14.RowSeparatorHeight = 2
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.Caption = "ID"
        Me.GridColumn12.FieldName = "CostAllocationUnitID"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        Me.GridColumn12.Width = 158
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.Caption = "Cost Unit"
        Me.GridColumn13.FieldName = "CostAllocationUnit"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        Me.GridColumn13.Width = 506
        '
        'colCostAllocationGroup
        '
        Me.colCostAllocationGroup.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.colCostAllocationGroup.AppearanceHeader.Options.UseFont = True
        Me.colCostAllocationGroup.FieldName = "CostAllocationGroup"
        Me.colCostAllocationGroup.Name = "colCostAllocationGroup"
        Me.colCostAllocationGroup.Visible = True
        Me.colCostAllocationGroup.VisibleIndex = 2
        Me.colCostAllocationGroup.Width = 206
        '
        'colCostAllocationMasterGroup
        '
        Me.colCostAllocationMasterGroup.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.colCostAllocationMasterGroup.AppearanceHeader.Options.UseFont = True
        Me.colCostAllocationMasterGroup.FieldName = "CostAllocationMasterGroup"
        Me.colCostAllocationMasterGroup.Name = "colCostAllocationMasterGroup"
        Me.colCostAllocationMasterGroup.Visible = True
        Me.colCostAllocationMasterGroup.VisibleIndex = 3
        Me.colCostAllocationMasterGroup.Width = 169
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(18, 106)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(170, 12)
        Me.LabelControl7.TabIndex = 132
        Me.LabelControl7.Text = "Cost Center Code: (Finance Modules)"
        '
        'Dsfrm600_01StoreEdit
        '
        Me.Dsfrm600_01StoreEdit.DataSetName = "dsfrm600_01StoreEdit"
        Me.Dsfrm600_01StoreEdit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl60001StoreMasterBindingSource
        '
        Me.Tbl60001StoreMasterBindingSource.DataMember = "tbl600_01StoreMaster"
        Me.Tbl60001StoreMasterBindingSource.DataSource = Me.Dsfrm600_01StoreEdit
        '
        'Tbl600_01StoreMasterTableAdapter
        '
        Me.Tbl600_01StoreMasterTableAdapter.ClearBeforeFill = True
        '
        'gcDrillDetails
        '
        Me.gcDrillDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDrillDetails.DataSource = Me.Tbl60001StoreMasterBindingSource
        Me.gcDrillDetails.Location = New System.Drawing.Point(4, 158)
        Me.gcDrillDetails.LookAndFeel.SkinName = "Blue"
        Me.gcDrillDetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcDrillDetails.MainView = Me.gvSubDetails
        Me.gcDrillDetails.Name = "gcDrillDetails"
        Me.gcDrillDetails.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoCostCenter})
        Me.gcDrillDetails.Size = New System.Drawing.Size(523, 318)
        Me.gcDrillDetails.TabIndex = 79
        Me.gcDrillDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSubDetails, Me.GridView5})
        '
        'gvSubDetails
        '
        Me.gvSubDetails.ColumnPanelRowHeight = 35
        Me.gvSubDetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStoreID, Me.colStoreName, Me.colCostAllocationUnitID})
        Me.gvSubDetails.CustomizationFormBounds = New System.Drawing.Rectangle(604, 454, 208, 191)
        Me.gvSubDetails.GridControl = Me.gcDrillDetails
        Me.gvSubDetails.Name = "gvSubDetails"
        Me.gvSubDetails.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSubDetails.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvSubDetails.OptionsSelection.MultiSelect = True
        Me.gvSubDetails.OptionsView.ShowGroupPanel = False
        Me.gvSubDetails.RowHeight = 35
        Me.gvSubDetails.RowSeparatorHeight = 1
        '
        'colStoreID
        '
        Me.colStoreID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStoreID.AppearanceCell.Options.UseFont = True
        Me.colStoreID.AppearanceCell.Options.UseTextOptions = True
        Me.colStoreID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoreID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStoreID.AppearanceHeader.Options.UseFont = True
        Me.colStoreID.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoreID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoreID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStoreID.FieldName = "StoreID"
        Me.colStoreID.Name = "colStoreID"
        Me.colStoreID.Visible = True
        Me.colStoreID.VisibleIndex = 0
        Me.colStoreID.Width = 93
        '
        'colStoreName
        '
        Me.colStoreName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStoreName.AppearanceHeader.Options.UseFont = True
        Me.colStoreName.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoreName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoreName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStoreName.FieldName = "StoreName"
        Me.colStoreName.Name = "colStoreName"
        Me.colStoreName.Visible = True
        Me.colStoreName.VisibleIndex = 1
        Me.colStoreName.Width = 242
        '
        'colCostAllocationUnitID
        '
        Me.colCostAllocationUnitID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCostAllocationUnitID.AppearanceHeader.Options.UseFont = True
        Me.colCostAllocationUnitID.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostAllocationUnitID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostAllocationUnitID.Caption = "Cost Center for Consumption"
        Me.colCostAllocationUnitID.ColumnEdit = Me.repoCostCenter
        Me.colCostAllocationUnitID.FieldName = "CostAllocationUnitID"
        Me.colCostAllocationUnitID.Name = "colCostAllocationUnitID"
        Me.colCostAllocationUnitID.Visible = True
        Me.colCostAllocationUnitID.VisibleIndex = 2
        Me.colCostAllocationUnitID.Width = 184
        '
        'repoCostCenter
        '
        Me.repoCostCenter.AutoHeight = False
        Me.repoCostCenter.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoCostCenter.DataSource = Me.Tbl201CostAllocationUnitsBindingSource
        Me.repoCostCenter.DisplayMember = "CostAllocationUnit"
        Me.repoCostCenter.Name = "repoCostCenter"
        Me.repoCostCenter.NullText = "<Select a Costcenter>"
        Me.repoCostCenter.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.repoCostCenter.ValueMember = "CostAllocationUnitID"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.gcDrillDetails
        Me.GridView5.Name = "GridView5"
        '
        'Tbl201CostAllocationUnitsTableAdapter
        '
        Me.Tbl201CostAllocationUnitsTableAdapter.ClearBeforeFill = True
        '
        'frm600_01StoreEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 522)
        Me.Controls.Add(Me.gcDrillDetails)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm600_01StoreEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Masters: Stores"
        CType(Me.popupSubForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtStoreCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStoreName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtCostCenterCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl201CostAllocationUnitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm600_01StoreEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm600_01StoreEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl60001StoreMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDrillDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSubDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoCostCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents popupSubForm As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnDeleteEntry As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStoreCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStoreName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents Dsfrm600_01StoreEdit As ERP.dsfrm600_01StoreEdit
    Friend WithEvents Tbl60001StoreMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl600_01StoreMasterTableAdapter As ERP.dsfrm600_01StoreEditTableAdapters.tbl600_01StoreMasterTableAdapter
    Friend WithEvents gcDrillDetails As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSubDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStoreID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoreName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCostAllocationUnitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoCostCenter As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Dsfrm600_01StoreEdit1 As ERP.dsfrm600_01StoreEdit
    Friend WithEvents Tbl201CostAllocationUnitsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl201CostAllocationUnitsTableAdapter As ERP.dsfrm600_01StoreEditTableAdapters.tbl201CostAllocationUnitsTableAdapter
    Friend WithEvents txtCostCenterCode As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostAllocationGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostAllocationMasterGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
