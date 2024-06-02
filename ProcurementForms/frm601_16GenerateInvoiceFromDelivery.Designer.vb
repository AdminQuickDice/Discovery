<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm601_16GenerateInvoiceFromDelivery
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm601_16GenerateInvoiceFromDelivery))
        Me.txtClientName = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ClientListToBeInvoicedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_16GeneralInvoiceFromDN = New ERP.dsfrm601_16GeneralInvoiceFromDN()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colClientCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPersonTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSalesOrders = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ClientSalesOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colClientCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.gcEmpDocuments = New DevExpress.XtraGrid.GridControl()
        Me.Qry60311DeliveryNotesWithDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvDeliveryNotes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDeliveryNoteNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveredTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientCode2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientPONo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesOrderNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientAccountLedgerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.repoDocumentType = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.repoDocumentNo = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGenerateInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBack = New DevExpress.XtraBars.BarButtonItem()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnDeleteConversion = New DevExpress.XtraBars.BarButtonItem()
        Me.btnShowDeliveryNotes = New DevExpress.XtraEditors.SimpleButton()
        Me.ClientListToBeInvoicedTableAdapter = New ERP.dsfrm601_16GeneralInvoiceFromDNTableAdapters.ClientListToBeInvoicedTableAdapter()
        Me.ClientSalesOrderTableAdapter = New ERP.dsfrm601_16GeneralInvoiceFromDNTableAdapters.ClientSalesOrderTableAdapter()
        Me.Qry603_11DeliveryNotesWithDetailsTableAdapter = New ERP.dsfrm601_16GeneralInvoiceFromDNTableAdapters.qry603_11DeliveryNotesWithDetailsTableAdapter()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.txtClientName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientListToBeInvoicedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_16GeneralInvoiceFromDN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalesOrders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientSalesOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcEmpDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60311DeliveryNotesWithDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDeliveryNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDocumentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDocumentNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtClientName
        '
        Me.txtClientName.EnterMoveNextControl = True
        Me.txtClientName.Location = New System.Drawing.Point(26, 29)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtClientName.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtClientName.Properties.Appearance.Options.UseBackColor = True
        Me.txtClientName.Properties.Appearance.Options.UseFont = True
        Me.txtClientName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClientName.Properties.DataSource = Me.ClientListToBeInvoicedBindingSource
        Me.txtClientName.Properties.DisplayMember = "ClientName"
        Me.txtClientName.Properties.NullText = ""
        Me.txtClientName.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.txtClientName.Properties.PopupView = Me.GridView7
        Me.txtClientName.Properties.ValueMember = "ClientCode"
        Me.txtClientName.Size = New System.Drawing.Size(357, 22)
        Me.txtClientName.TabIndex = 5
        '
        'ClientListToBeInvoicedBindingSource
        '
        Me.ClientListToBeInvoicedBindingSource.DataMember = "ClientListToBeInvoiced"
        Me.ClientListToBeInvoicedBindingSource.DataSource = Me.Dsfrm601_16GeneralInvoiceFromDN
        '
        'Dsfrm601_16GeneralInvoiceFromDN
        '
        Me.Dsfrm601_16GeneralInvoiceFromDN.DataSetName = "dsfrm601_16GeneralInvoiceFromDN"
        Me.Dsfrm601_16GeneralInvoiceFromDN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView7
        '
        Me.GridView7.ColumnPanelRowHeight = 30
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClientCode, Me.colClientCategory, Me.colClientName, Me.colClientAddress, Me.colContactPerson, Me.colContactPersonTitle, Me.colContactEmail, Me.colIsDiscontinued})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.RowHeight = 30
        '
        'colClientCode
        '
        Me.colClientCode.FieldName = "ClientCode"
        Me.colClientCode.Name = "colClientCode"
        '
        'colClientCategory
        '
        Me.colClientCategory.FieldName = "ClientCategory"
        Me.colClientCategory.Name = "colClientCategory"
        '
        'colClientName
        '
        Me.colClientName.FieldName = "ClientName"
        Me.colClientName.Name = "colClientName"
        Me.colClientName.Visible = True
        Me.colClientName.VisibleIndex = 0
        '
        'colClientAddress
        '
        Me.colClientAddress.FieldName = "ClientAddress"
        Me.colClientAddress.Name = "colClientAddress"
        '
        'colContactPerson
        '
        Me.colContactPerson.FieldName = "ContactPerson"
        Me.colContactPerson.Name = "colContactPerson"
        '
        'colContactPersonTitle
        '
        Me.colContactPersonTitle.FieldName = "ContactPersonTitle"
        Me.colContactPersonTitle.Name = "colContactPersonTitle"
        '
        'colContactEmail
        '
        Me.colContactEmail.FieldName = "ContactEmail"
        Me.colContactEmail.Name = "colContactEmail"
        '
        'colIsDiscontinued
        '
        Me.colIsDiscontinued.FieldName = "IsDiscontinued"
        Me.colIsDiscontinued.Name = "colIsDiscontinued"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(29, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Client Name:"
        '
        'txtSalesOrders
        '
        Me.txtSalesOrders.EnterMoveNextControl = True
        Me.txtSalesOrders.Location = New System.Drawing.Point(389, 29)
        Me.txtSalesOrders.Name = "txtSalesOrders"
        Me.txtSalesOrders.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSalesOrders.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSalesOrders.Properties.Appearance.Options.UseBackColor = True
        Me.txtSalesOrders.Properties.Appearance.Options.UseFont = True
        EditorButtonImageOptions1.Image = Global.ERP.My.Resources.Resources.DailyRpt16x16
        EditorButtonImageOptions2.Image = Global.ERP.My.Resources.Resources.add116
        Me.txtSalesOrders.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtSalesOrders.Properties.DataSource = Me.ClientSalesOrderBindingSource
        Me.txtSalesOrders.Properties.DisplayMember = "SalesOrderNo"
        Me.txtSalesOrders.Properties.NullText = ""
        Me.txtSalesOrders.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.txtSalesOrders.Properties.PopupView = Me.GridView5
        Me.txtSalesOrders.Properties.ValueMember = "SalesOrderNo"
        Me.txtSalesOrders.Size = New System.Drawing.Size(215, 22)
        Me.txtSalesOrders.TabIndex = 150
        '
        'ClientSalesOrderBindingSource
        '
        Me.ClientSalesOrderBindingSource.DataMember = "ClientSalesOrder"
        Me.ClientSalesOrderBindingSource.DataSource = Me.Dsfrm601_16GeneralInvoiceFromDN
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClientCode1, Me.colClientName1, Me.colSalesOrderNo})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.RowHeight = 30
        Me.GridView5.RowSeparatorHeight = 1
        '
        'colClientCode1
        '
        Me.colClientCode1.FieldName = "ClientCode"
        Me.colClientCode1.Name = "colClientCode1"
        '
        'colClientName1
        '
        Me.colClientName1.FieldName = "ClientName"
        Me.colClientName1.Name = "colClientName1"
        '
        'colSalesOrderNo
        '
        Me.colSalesOrderNo.FieldName = "SalesOrderNo"
        Me.colSalesOrderNo.Name = "colSalesOrderNo"
        Me.colSalesOrderNo.Visible = True
        Me.colSalesOrderNo.VisibleIndex = 0
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(392, 11)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(77, 14)
        Me.LabelControl11.TabIndex = 149
        Me.LabelControl11.Text = "Sales Order #:"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.RoyalBlue
        Me.PanelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(19, 369)
        Me.PanelControl2.TabIndex = 175
        '
        'gcEmpDocuments
        '
        Me.gcEmpDocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcEmpDocuments.DataSource = Me.Qry60311DeliveryNotesWithDetailsBindingSource
        Me.gcEmpDocuments.Location = New System.Drawing.Point(25, 61)
        Me.gcEmpDocuments.MainView = Me.gvDeliveryNotes
        Me.gcEmpDocuments.Name = "gcEmpDocuments"
        Me.gcEmpDocuments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.repoDocumentType, Me.repoDocumentNo})
        Me.gcEmpDocuments.Size = New System.Drawing.Size(850, 305)
        Me.gcEmpDocuments.TabIndex = 178
        Me.gcEmpDocuments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDeliveryNotes})
        '
        'Qry60311DeliveryNotesWithDetailsBindingSource
        '
        Me.Qry60311DeliveryNotesWithDetailsBindingSource.DataMember = "qry603_11DeliveryNotesWithDetails"
        Me.Qry60311DeliveryNotesWithDetailsBindingSource.DataSource = Me.Dsfrm601_16GeneralInvoiceFromDN
        '
        'gvDeliveryNotes
        '
        Me.gvDeliveryNotes.ColumnPanelRowHeight = 35
        Me.gvDeliveryNotes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDeliveryNoteNo, Me.colDeliveryDate, Me.colDeliveryType, Me.colDeliveredTo, Me.colClientName2, Me.colClientCode2, Me.colClientPONo, Me.colSalesOrderNo1, Me.colInvoiceNo, Me.colClientAccountLedgerNo, Me.colOrderStatus, Me.colInvoiceStatus})
        Me.gvDeliveryNotes.CustomizationFormBounds = New System.Drawing.Rectangle(619, 194, 216, 204)
        Me.gvDeliveryNotes.GridControl = Me.gcEmpDocuments
        Me.gvDeliveryNotes.Name = "gvDeliveryNotes"
        Me.gvDeliveryNotes.OptionsSelection.MultiSelect = True
        Me.gvDeliveryNotes.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvDeliveryNotes.OptionsView.ShowGroupPanel = False
        Me.gvDeliveryNotes.RowHeight = 30
        Me.gvDeliveryNotes.RowSeparatorHeight = 1
        '
        'colDeliveryNoteNo
        '
        Me.colDeliveryNoteNo.AppearanceCell.Options.UseTextOptions = True
        Me.colDeliveryNoteNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryNoteNo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveryNoteNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDeliveryNoteNo.AppearanceHeader.Options.UseFont = True
        Me.colDeliveryNoteNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveryNoteNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryNoteNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveryNoteNo.FieldName = "DeliveryNoteNo"
        Me.colDeliveryNoteNo.Name = "colDeliveryNoteNo"
        Me.colDeliveryNoteNo.Visible = True
        Me.colDeliveryNoteNo.VisibleIndex = 1
        Me.colDeliveryNoteNo.Width = 101
        '
        'colDeliveryDate
        '
        Me.colDeliveryDate.AppearanceCell.Options.UseTextOptions = True
        Me.colDeliveryDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveryDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDeliveryDate.AppearanceHeader.Options.UseFont = True
        Me.colDeliveryDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveryDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveryDate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colDeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDeliveryDate.FieldName = "DeliveryDate"
        Me.colDeliveryDate.Name = "colDeliveryDate"
        Me.colDeliveryDate.Visible = True
        Me.colDeliveryDate.VisibleIndex = 2
        Me.colDeliveryDate.Width = 88
        '
        'colDeliveryType
        '
        Me.colDeliveryType.AppearanceCell.Options.UseTextOptions = True
        Me.colDeliveryType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryType.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveryType.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDeliveryType.AppearanceHeader.Options.UseFont = True
        Me.colDeliveryType.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveryType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveryType.FieldName = "DeliveryType"
        Me.colDeliveryType.Name = "colDeliveryType"
        Me.colDeliveryType.Width = 71
        '
        'colDeliveredTo
        '
        Me.colDeliveredTo.AppearanceCell.Options.UseTextOptions = True
        Me.colDeliveredTo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveredTo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveredTo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDeliveredTo.AppearanceHeader.Options.UseFont = True
        Me.colDeliveredTo.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveredTo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveredTo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeliveredTo.FieldName = "DeliveredTo"
        Me.colDeliveredTo.Name = "colDeliveredTo"
        Me.colDeliveredTo.Width = 128
        '
        'colClientName2
        '
        Me.colClientName2.AppearanceCell.Options.UseTextOptions = True
        Me.colClientName2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientName2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientName2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientName2.AppearanceHeader.Options.UseFont = True
        Me.colClientName2.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientName2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientName2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientName2.FieldName = "ClientName"
        Me.colClientName2.Name = "colClientName2"
        Me.colClientName2.Visible = True
        Me.colClientName2.VisibleIndex = 3
        Me.colClientName2.Width = 178
        '
        'colClientCode2
        '
        Me.colClientCode2.AppearanceCell.Options.UseTextOptions = True
        Me.colClientCode2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientCode2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientCode2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientCode2.AppearanceHeader.Options.UseFont = True
        Me.colClientCode2.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientCode2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientCode2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientCode2.FieldName = "ClientCode"
        Me.colClientCode2.Name = "colClientCode2"
        Me.colClientCode2.Width = 69
        '
        'colClientPONo
        '
        Me.colClientPONo.AppearanceCell.Options.UseTextOptions = True
        Me.colClientPONo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientPONo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientPONo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientPONo.AppearanceHeader.Options.UseFont = True
        Me.colClientPONo.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientPONo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientPONo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientPONo.FieldName = "ClientPONo"
        Me.colClientPONo.Name = "colClientPONo"
        Me.colClientPONo.Visible = True
        Me.colClientPONo.VisibleIndex = 4
        Me.colClientPONo.Width = 87
        '
        'colSalesOrderNo1
        '
        Me.colSalesOrderNo1.AppearanceCell.Options.UseTextOptions = True
        Me.colSalesOrderNo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSalesOrderNo1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSalesOrderNo1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSalesOrderNo1.AppearanceHeader.Options.UseFont = True
        Me.colSalesOrderNo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colSalesOrderNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSalesOrderNo1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSalesOrderNo1.FieldName = "SalesOrderNo"
        Me.colSalesOrderNo1.Name = "colSalesOrderNo1"
        Me.colSalesOrderNo1.Visible = True
        Me.colSalesOrderNo1.VisibleIndex = 5
        Me.colSalesOrderNo1.Width = 87
        '
        'colInvoiceNo
        '
        Me.colInvoiceNo.AppearanceCell.Options.UseTextOptions = True
        Me.colInvoiceNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceNo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceNo.AppearanceHeader.Options.UseFont = True
        Me.colInvoiceNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvoiceNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceNo.FieldName = "InvoiceNo"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        Me.colInvoiceNo.OptionsColumn.AllowEdit = False
        Me.colInvoiceNo.Visible = True
        Me.colInvoiceNo.VisibleIndex = 7
        Me.colInvoiceNo.Width = 98
        '
        'colClientAccountLedgerNo
        '
        Me.colClientAccountLedgerNo.AppearanceCell.Options.UseTextOptions = True
        Me.colClientAccountLedgerNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientAccountLedgerNo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientAccountLedgerNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colClientAccountLedgerNo.AppearanceHeader.Options.UseFont = True
        Me.colClientAccountLedgerNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientAccountLedgerNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientAccountLedgerNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClientAccountLedgerNo.FieldName = "ClientAccountLedgerNo"
        Me.colClientAccountLedgerNo.Name = "colClientAccountLedgerNo"
        Me.colClientAccountLedgerNo.Width = 69
        '
        'colOrderStatus
        '
        Me.colOrderStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colOrderStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderStatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderStatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOrderStatus.AppearanceHeader.Options.UseFont = True
        Me.colOrderStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderStatus.FieldName = "OrderStatus"
        Me.colOrderStatus.Name = "colOrderStatus"
        Me.colOrderStatus.Visible = True
        Me.colOrderStatus.VisibleIndex = 6
        Me.colOrderStatus.Width = 113
        '
        'colInvoiceStatus
        '
        Me.colInvoiceStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colInvoiceStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceStatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceStatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvoiceStatus.AppearanceHeader.Options.UseFont = True
        Me.colInvoiceStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvoiceStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInvoiceStatus.FieldName = "InvoiceStatus"
        Me.colInvoiceStatus.Name = "colInvoiceStatus"
        Me.colInvoiceStatus.Visible = True
        Me.colInvoiceStatus.VisibleIndex = 8
        Me.colInvoiceStatus.Width = 148
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'repoDocumentType
        '
        Me.repoDocumentType.AutoHeight = False
        Me.repoDocumentType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoDocumentType.DisplayMember = "DocumentType"
        Me.repoDocumentType.Name = "repoDocumentType"
        Me.repoDocumentType.NullText = ""
        Me.repoDocumentType.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.repoDocumentType.ValueMember = "DocumentTypeID"
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'repoDocumentNo
        '
        Me.repoDocumentNo.AutoHeight = False
        Me.repoDocumentNo.Name = "repoDocumentNo"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGenerateInvoice, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPrint, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnBack, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "   "
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnGenerateInvoice
        '
        Me.btnGenerateInvoice.Caption = "Generate VAT Invoice"
        Me.btnGenerateInvoice.Id = 6
        Me.btnGenerateInvoice.ImageOptions.Image = CType(resources.GetObject("btnGenerateInvoice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGenerateInvoice.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateInvoice.ItemAppearance.Normal.Options.UseFont = True
        Me.btnGenerateInvoice.Name = "btnGenerateInvoice"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Id = 1
        Me.btnPrint.ImageOptions.Image = Global.ERP.My.Resources.Resources.Print
        Me.btnPrint.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPrint.Name = "btnPrint"
        '
        'btnBack
        '
        Me.btnBack.Caption = "Back"
        Me.btnBack.Id = 2
        Me.btnBack.ImageOptions.Image = Global.ERP.My.Resources.Resources.GoBackBlue24x24
        Me.btnBack.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBack.Name = "btnBack"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Blue"
        Me.BarAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPrint, Me.btnBack, Me.btnDeleteConversion, Me.btnGenerateInvoice, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(880, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 369)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(880, 42)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 369)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(880, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 369)
        '
        'btnDeleteConversion
        '
        Me.btnDeleteConversion.Caption = "Delete Conversion "
        Me.btnDeleteConversion.Id = 5
        Me.btnDeleteConversion.ImageOptions.Image = Global.ERP.My.Resources.Resources.DeleteRed
        Me.btnDeleteConversion.ImageOptions.LargeImage = CType(resources.GetObject("btnDeleteConversion.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDeleteConversion.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteConversion.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDeleteConversion.Name = "btnDeleteConversion"
        '
        'btnShowDeliveryNotes
        '
        Me.btnShowDeliveryNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowDeliveryNotes.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowDeliveryNotes.Appearance.Options.UseFont = True
        Me.btnShowDeliveryNotes.ImageOptions.Image = CType(resources.GetObject("btnShowDeliveryNotes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnShowDeliveryNotes.Location = New System.Drawing.Point(665, 15)
        Me.btnShowDeliveryNotes.Name = "btnShowDeliveryNotes"
        Me.btnShowDeliveryNotes.Size = New System.Drawing.Size(210, 38)
        Me.btnShowDeliveryNotes.TabIndex = 183
        Me.btnShowDeliveryNotes.Text = "Show Delivery Notes"
        '
        'ClientListToBeInvoicedTableAdapter
        '
        Me.ClientListToBeInvoicedTableAdapter.ClearBeforeFill = True
        '
        'ClientSalesOrderTableAdapter
        '
        Me.ClientSalesOrderTableAdapter.ClearBeforeFill = True
        '
        'Qry603_11DeliveryNotesWithDetailsTableAdapter
        '
        Me.Qry603_11DeliveryNotesWithDetailsTableAdapter.ClearBeforeFill = True
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Csv.Separator = ";"
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gcEmpDocuments
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frm601_16GenerateInvoiceFromDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 411)
        Me.Controls.Add(Me.btnShowDeliveryNotes)
        Me.Controls.Add(Me.gcEmpDocuments)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.txtSalesOrders)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frm601_16GenerateInvoiceFromDelivery.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm601_16GenerateInvoiceFromDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Invoice : "
        CType(Me.txtClientName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientListToBeInvoicedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_16GeneralInvoiceFromDN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalesOrders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientSalesOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcEmpDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60311DeliveryNotesWithDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDeliveryNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDocumentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDocumentNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtClientName As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colClientCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPersonTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSalesOrders As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcEmpDocuments As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDeliveryNotes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents repoDocumentNo As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents repoDocumentType As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGenerateInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBack As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnDeleteConversion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnShowDeliveryNotes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Dsfrm601_16GeneralInvoiceFromDN As ERP.dsfrm601_16GeneralInvoiceFromDN
    Friend WithEvents ClientListToBeInvoicedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientListToBeInvoicedTableAdapter As ERP.dsfrm601_16GeneralInvoiceFromDNTableAdapters.ClientListToBeInvoicedTableAdapter
    Friend WithEvents ClientSalesOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientSalesOrderTableAdapter As ERP.dsfrm601_16GeneralInvoiceFromDNTableAdapters.ClientSalesOrderTableAdapter
    Friend WithEvents colClientCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qry60311DeliveryNotesWithDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDeliveryNoteNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveredTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientCode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientPONo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesOrderNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientAccountLedgerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qry603_11DeliveryNotesWithDetailsTableAdapter As ERP.dsfrm601_16GeneralInvoiceFromDNTableAdapters.qry603_11DeliveryNotesWithDetailsTableAdapter
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
