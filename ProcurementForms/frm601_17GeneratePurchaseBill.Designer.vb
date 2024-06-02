<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm601_17GeneratePurchaseBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm601_17GeneratePurchaseBill))
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnShowDeliveryNotes = New DevExpress.XtraEditors.SimpleButton()
        Me.gcEmpDocuments = New DevExpress.XtraGrid.GridControl()
        Me.Qry60511MaterialReceiptNotesWithDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_17GenerateBillsFromMRN = New ERP.dsfrm601_17GenerateBillsFromMRN()
        Me.gvDeliveryNotes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDeliveryNoteNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientCode2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesOrderNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientAccountLedgerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.repoDocumentType = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.repoDocumentNo = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.txtPurchaseOrders = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierPurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colClientCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSupplierName = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierListToBeBilledBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.Qry605_11MaterialReceiptNotesWithDetailsTableAdapter = New ERP.dsfrm601_17GenerateBillsFromMRNTableAdapters.qry605_11MaterialReceiptNotesWithDetailsTableAdapter()
        Me.SupplierListToBeBilledTableAdapter = New ERP.dsfrm601_17GenerateBillsFromMRNTableAdapters.SupplierListToBeBilledTableAdapter()
        Me.SupplierPurchaseOrderTableAdapter = New ERP.dsfrm601_17GenerateBillsFromMRNTableAdapters.SupplierPurchaseOrderTableAdapter()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcEmpDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60511MaterialReceiptNotesWithDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_17GenerateBillsFromMRN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDeliveryNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDocumentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDocumentNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurchaseOrders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierPurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplierName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierListToBeBilledBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelControl2.Size = New System.Drawing.Size(19, 363)
        Me.PanelControl2.TabIndex = 176
        '
        'btnShowDeliveryNotes
        '
        Me.btnShowDeliveryNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowDeliveryNotes.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowDeliveryNotes.Appearance.Options.UseFont = True
        Me.btnShowDeliveryNotes.ImageOptions.Image = CType(resources.GetObject("btnShowDeliveryNotes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnShowDeliveryNotes.Location = New System.Drawing.Point(651, 11)
        Me.btnShowDeliveryNotes.Name = "btnShowDeliveryNotes"
        Me.btnShowDeliveryNotes.Size = New System.Drawing.Size(210, 38)
        Me.btnShowDeliveryNotes.TabIndex = 189
        Me.btnShowDeliveryNotes.Text = "Show Material Receipt Notes"
        '
        'gcEmpDocuments
        '
        Me.gcEmpDocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcEmpDocuments.DataSource = Me.Qry60511MaterialReceiptNotesWithDetailsBindingSource
        Me.gcEmpDocuments.Location = New System.Drawing.Point(25, 54)
        Me.gcEmpDocuments.MainView = Me.gvDeliveryNotes
        Me.gcEmpDocuments.Name = "gcEmpDocuments"
        Me.gcEmpDocuments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.repoDocumentType, Me.repoDocumentNo})
        Me.gcEmpDocuments.Size = New System.Drawing.Size(836, 304)
        Me.gcEmpDocuments.TabIndex = 188
        Me.gcEmpDocuments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDeliveryNotes})
        '
        'Qry60511MaterialReceiptNotesWithDetailsBindingSource
        '
        Me.Qry60511MaterialReceiptNotesWithDetailsBindingSource.DataMember = "qry605_11MaterialReceiptNotesWithDetails"
        Me.Qry60511MaterialReceiptNotesWithDetailsBindingSource.DataSource = Me.Dsfrm601_17GenerateBillsFromMRN
        '
        'Dsfrm601_17GenerateBillsFromMRN
        '
        Me.Dsfrm601_17GenerateBillsFromMRN.DataSetName = "dsfrm601_17GenerateBillsFromMRN"
        Me.Dsfrm601_17GenerateBillsFromMRN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvDeliveryNotes
        '
        Me.gvDeliveryNotes.ColumnPanelRowHeight = 35
        Me.gvDeliveryNotes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDeliveryNoteNo, Me.colDeliveryDate, Me.colDeliveryType, Me.colClientName2, Me.colClientCode2, Me.colSalesOrderNo1, Me.colInvoiceNo, Me.colClientAccountLedgerNo, Me.colOrderStatus, Me.colInvoiceStatus})
        Me.gvDeliveryNotes.CustomizationFormBounds = New System.Drawing.Rectangle(619, 194, 216, 204)
        Me.gvDeliveryNotes.GridControl = Me.gcEmpDocuments
        Me.gvDeliveryNotes.Name = "gvDeliveryNotes"
        Me.gvDeliveryNotes.OptionsSelection.CheckBoxSelectorColumnWidth = 35
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
        Me.colDeliveryNoteNo.FieldName = "ReceiptNo"
        Me.colDeliveryNoteNo.Name = "colDeliveryNoteNo"
        Me.colDeliveryNoteNo.Visible = True
        Me.colDeliveryNoteNo.VisibleIndex = 1
        Me.colDeliveryNoteNo.Width = 97
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
        Me.colDeliveryDate.FieldName = "ReceiptDate"
        Me.colDeliveryDate.Name = "colDeliveryDate"
        Me.colDeliveryDate.Visible = True
        Me.colDeliveryDate.VisibleIndex = 2
        Me.colDeliveryDate.Width = 84
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
        Me.colDeliveryType.FieldName = "ModeOfReceiptID"
        Me.colDeliveryType.Name = "colDeliveryType"
        Me.colDeliveryType.Width = 71
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
        Me.colClientName2.FieldName = "SupplierName"
        Me.colClientName2.Name = "colClientName2"
        Me.colClientName2.Visible = True
        Me.colClientName2.VisibleIndex = 3
        Me.colClientName2.Width = 171
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
        Me.colClientCode2.FieldName = "SupplierCode"
        Me.colClientCode2.Name = "colClientCode2"
        Me.colClientCode2.Width = 69
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
        Me.colSalesOrderNo1.Caption = "PO No"
        Me.colSalesOrderNo1.FieldName = "OurPurchaseOrderNo"
        Me.colSalesOrderNo1.Name = "colSalesOrderNo1"
        Me.colSalesOrderNo1.Visible = True
        Me.colSalesOrderNo1.VisibleIndex = 4
        Me.colSalesOrderNo1.Width = 114
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
        Me.colInvoiceNo.Caption = "Purchase Voucher No"
        Me.colInvoiceNo.FieldName = "VATPurchaseBillNo"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        Me.colInvoiceNo.Visible = True
        Me.colInvoiceNo.VisibleIndex = 6
        Me.colInvoiceNo.Width = 112
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
        Me.colClientAccountLedgerNo.Caption = "Ledger No"
        Me.colClientAccountLedgerNo.FieldName = "SupplierAccountLedgerNo"
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
        Me.colOrderStatus.VisibleIndex = 5
        Me.colOrderStatus.Width = 92
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
        Me.colInvoiceStatus.FieldName = "BillStatus"
        Me.colInvoiceStatus.Name = "colInvoiceStatus"
        Me.colInvoiceStatus.Visible = True
        Me.colInvoiceStatus.VisibleIndex = 7
        Me.colInvoiceStatus.Width = 122
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
        'txtPurchaseOrders
        '
        Me.txtPurchaseOrders.EnterMoveNextControl = True
        Me.txtPurchaseOrders.Location = New System.Drawing.Point(389, 26)
        Me.txtPurchaseOrders.Name = "txtPurchaseOrders"
        Me.txtPurchaseOrders.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtPurchaseOrders.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPurchaseOrders.Properties.Appearance.Options.UseBackColor = True
        Me.txtPurchaseOrders.Properties.Appearance.Options.UseFont = True
        EditorButtonImageOptions1.Image = Global.ERP.My.Resources.Resources.DailyRpt16x16
        EditorButtonImageOptions2.Image = Global.ERP.My.Resources.Resources.add116
        Me.txtPurchaseOrders.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtPurchaseOrders.Properties.DataSource = Me.SupplierPurchaseOrderBindingSource
        Me.txtPurchaseOrders.Properties.DisplayMember = "OurPurchaseOrderNo"
        Me.txtPurchaseOrders.Properties.NullText = ""
        Me.txtPurchaseOrders.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.txtPurchaseOrders.Properties.PopupView = Me.GridView5
        Me.txtPurchaseOrders.Properties.ValueMember = "OurPurchaseOrderNo"
        Me.txtPurchaseOrders.Size = New System.Drawing.Size(215, 22)
        Me.txtPurchaseOrders.TabIndex = 187
        '
        'SupplierPurchaseOrderBindingSource
        '
        Me.SupplierPurchaseOrderBindingSource.DataMember = "SupplierPurchaseOrder"
        Me.SupplierPurchaseOrderBindingSource.DataSource = Me.Dsfrm601_17GenerateBillsFromMRN
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
        Me.colClientCode1.FieldName = "SupplierCode"
        Me.colClientCode1.Name = "colClientCode1"
        '
        'colClientName1
        '
        Me.colClientName1.FieldName = "SupplierName"
        Me.colClientName1.Name = "colClientName1"
        '
        'colSalesOrderNo
        '
        Me.colSalesOrderNo.Caption = "PO No"
        Me.colSalesOrderNo.FieldName = "OurPurchaseOrderNo"
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
        Me.LabelControl11.Location = New System.Drawing.Point(392, 8)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(100, 14)
        Me.LabelControl11.TabIndex = 186
        Me.LabelControl11.Text = "Purchase Order #:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(29, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 14)
        Me.LabelControl1.TabIndex = 184
        Me.LabelControl1.Text = "Supplier Name:"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.EnterMoveNextControl = True
        Me.txtSupplierName.Location = New System.Drawing.Point(26, 26)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSupplierName.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSupplierName.Properties.Appearance.Options.UseBackColor = True
        Me.txtSupplierName.Properties.Appearance.Options.UseFont = True
        Me.txtSupplierName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSupplierName.Properties.DataSource = Me.SupplierListToBeBilledBindingSource
        Me.txtSupplierName.Properties.DisplayMember = "SupplierName"
        Me.txtSupplierName.Properties.NullText = ""
        Me.txtSupplierName.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.txtSupplierName.Properties.PopupView = Me.GridView7
        Me.txtSupplierName.Properties.ValueMember = "SupplierCode"
        Me.txtSupplierName.Size = New System.Drawing.Size(357, 22)
        Me.txtSupplierName.TabIndex = 185
        '
        'SupplierListToBeBilledBindingSource
        '
        Me.SupplierListToBeBilledBindingSource.DataMember = "SupplierListToBeBilled"
        Me.SupplierListToBeBilledBindingSource.DataSource = Me.Dsfrm601_17GenerateBillsFromMRN
        '
        'GridView7
        '
        Me.GridView7.ColumnPanelRowHeight = 30
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode, Me.colSupplierName})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.RowHeight = 30
        '
        'colSupplierCode
        '
        Me.colSupplierCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSupplierCode.AppearanceHeader.Options.UseFont = True
        Me.colSupplierCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 0
        Me.colSupplierCode.Width = 238
        '
        'colSupplierName
        '
        Me.colSupplierName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSupplierName.AppearanceHeader.Options.UseFont = True
        Me.colSupplierName.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 1
        Me.colSupplierName.Width = 834
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
        Me.btnGenerateInvoice.Caption = "Generate VAT Purchase Bill"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(866, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 363)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(866, 42)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 363)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(866, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 363)
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
        'Qry605_11MaterialReceiptNotesWithDetailsTableAdapter
        '
        Me.Qry605_11MaterialReceiptNotesWithDetailsTableAdapter.ClearBeforeFill = True
        '
        'SupplierListToBeBilledTableAdapter
        '
        Me.SupplierListToBeBilledTableAdapter.ClearBeforeFill = True
        '
        'SupplierPurchaseOrderTableAdapter
        '
        Me.SupplierPurchaseOrderTableAdapter.ClearBeforeFill = True
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
        'frm601_17GeneratePurchaseBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 405)
        Me.Controls.Add(Me.btnShowDeliveryNotes)
        Me.Controls.Add(Me.gcEmpDocuments)
        Me.Controls.Add(Me.txtPurchaseOrders)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frm601_17GeneratePurchaseBill.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm601_17GeneratePurchaseBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Purchase Bills:"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcEmpDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60511MaterialReceiptNotesWithDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_17GenerateBillsFromMRN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDeliveryNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDocumentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDocumentNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurchaseOrders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierPurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplierName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierListToBeBilledBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnShowDeliveryNotes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcEmpDocuments As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDeliveryNotes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDeliveryNoteNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientCode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesOrderNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientAccountLedgerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repoDocumentType As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents repoDocumentNo As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents txtPurchaseOrders As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colClientCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplierName As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents Qry60511MaterialReceiptNotesWithDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dsfrm601_17GenerateBillsFromMRN As ERP.dsfrm601_17GenerateBillsFromMRN
    Friend WithEvents Qry605_11MaterialReceiptNotesWithDetailsTableAdapter As ERP.dsfrm601_17GenerateBillsFromMRNTableAdapters.qry605_11MaterialReceiptNotesWithDetailsTableAdapter
    Friend WithEvents SupplierListToBeBilledBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierListToBeBilledTableAdapter As ERP.dsfrm601_17GenerateBillsFromMRNTableAdapters.SupplierListToBeBilledTableAdapter
    Friend WithEvents SupplierPurchaseOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierPurchaseOrderTableAdapter As ERP.dsfrm601_17GenerateBillsFromMRNTableAdapters.SupplierPurchaseOrderTableAdapter
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
