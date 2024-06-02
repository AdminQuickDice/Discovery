<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm601_24ProductionReceipt
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtReceivedFrom = New DevExpress.XtraEditors.TextEdit()
        Me.lblStoreIssuedTo = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDeliveryNoteDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalDeliveryValue = New DevExpress.XtraEditors.SpinEdit()
        Me.lblRateOrPrice = New DevExpress.XtraEditors.LabelControl()
        Me.txtDeliveryNoteNo = New DevExpress.XtraEditors.TextEdit()
        Me.groupVoucherEntry = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLineTotal = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnitMethod1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Tbl40111PropertyUnitCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_09MaterialReceiptEdit1 = New ERP.dsfrm601_09MaterialReceiptEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtUnitRate1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.txtItemRequested = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Tbl20164GoodsAndServicesMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGSCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDescrpition1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtQty = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.gcSubLedger = New DevExpress.XtraGrid.GridControl()
        Me.Qry60502MaterialReceiptChildBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_09MaterialReceiptEdit = New ERP.dsfrm601_09MaterialReceiptEdit()
        Me.gvSubLedger = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReceiptChildSlNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiptNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSDescrpition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyReceived = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitRateMethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineTotalWithTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBack = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPostJournal = New DevExpress.XtraBars.BarButtonItem()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnDeleteLineEntry = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.txtMaterialReceiptNo = New DevExpress.XtraEditors.TextEdit()
        Me.Tbl60501MaterialReceiptMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Qry605_02MaterialReceiptChildTableAdapter = New ERP.dsfrm601_09MaterialReceiptEditTableAdapters.qry605_02MaterialReceiptChildTableAdapter()
        Me.Tbl605_01MaterialReceiptMasterTableAdapter = New ERP.dsfrm601_09MaterialReceiptEditTableAdapters.tbl605_01MaterialReceiptMasterTableAdapter()
        Me.txtMaterialReceiptDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtStoreCode = New DevExpress.XtraEditors.TextEdit()
        Me.Tbl20164GoodsAndServicesMasterTableAdapter = New ERP.dsfrm601_09MaterialReceiptEditTableAdapters.tbl20164GoodsAndServicesMasterTableAdapter()
        Me.Tbl40111PropertyUnitCodesTableAdapter = New ERP.dsfrm601_09MaterialReceiptEditTableAdapters.tbl40111PropertyUnitCodesTableAdapter()
        Me.txtDN = New DevExpress.XtraEditors.TextEdit()
        Me.txtPostedOn = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.lblPostedBy = New DevExpress.XtraEditors.LabelControl()
        Me.txtIsPosted = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPostedJVNo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtReceivedFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryNoteDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryNoteDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDeliveryValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryNoteNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupVoucherEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupVoucherEntry.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txtLineTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitMethod1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl40111PropertyUnitCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_09MaterialReceiptEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitRate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemRequested.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl20164GoodsAndServicesMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcSubLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60502MaterialReceiptChildBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_09MaterialReceiptEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSubLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialReceiptNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl60501MaterialReceiptMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialReceiptDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialReceiptDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStoreCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostedOn.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostedOn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIsPosted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostedJVNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.PanelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(19, 457)
        Me.PanelControl2.TabIndex = 110
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue
        Me.PanelControl3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(19, 0)
        Me.PanelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(981, 62)
        Me.PanelControl3.TabIndex = 111
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Cambria", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Location = New System.Drawing.Point(20, 22)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(436, 27)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Materials Received from Production Unit:"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.txtReceivedFrom)
        Me.PanelControl1.Controls.Add(Me.lblStoreIssuedTo)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.txtDeliveryNoteDate)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txtTotalDeliveryValue)
        Me.PanelControl1.Controls.Add(Me.lblRateOrPrice)
        Me.PanelControl1.Controls.Add(Me.txtDeliveryNoteNo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(19, 62)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(981, 52)
        Me.PanelControl1.TabIndex = 112
        '
        'txtReceivedFrom
        '
        Me.txtReceivedFrom.Enabled = False
        Me.txtReceivedFrom.EnterMoveNextControl = True
        Me.txtReceivedFrom.Location = New System.Drawing.Point(365, 23)
        Me.txtReceivedFrom.Name = "txtReceivedFrom"
        Me.txtReceivedFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReceivedFrom.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtReceivedFrom.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtReceivedFrom.Properties.Appearance.Options.UseBackColor = True
        Me.txtReceivedFrom.Properties.Appearance.Options.UseFont = True
        Me.txtReceivedFrom.Properties.Appearance.Options.UseForeColor = True
        Me.txtReceivedFrom.Properties.Appearance.Options.UseTextOptions = True
        Me.txtReceivedFrom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtReceivedFrom.Size = New System.Drawing.Size(360, 24)
        Me.txtReceivedFrom.TabIndex = 97
        '
        'lblStoreIssuedTo
        '
        Me.lblStoreIssuedTo.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoreIssuedTo.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblStoreIssuedTo.Location = New System.Drawing.Point(367, 7)
        Me.lblStoreIssuedTo.Name = "lblStoreIssuedTo"
        Me.lblStoreIssuedTo.Size = New System.Drawing.Size(83, 14)
        Me.lblStoreIssuedTo.TabIndex = 96
        Me.lblStoreIssuedTo.Text = "Received from:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl12.Location = New System.Drawing.Point(203, 6)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(27, 14)
        Me.LabelControl12.TabIndex = 94
        Me.LabelControl12.Text = "Date:"
        '
        'txtDeliveryNoteDate
        '
        Me.txtDeliveryNoteDate.EditValue = Nothing
        Me.txtDeliveryNoteDate.Enabled = False
        Me.txtDeliveryNoteDate.EnterMoveNextControl = True
        Me.txtDeliveryNoteDate.Location = New System.Drawing.Point(201, 23)
        Me.txtDeliveryNoteDate.Name = "txtDeliveryNoteDate"
        Me.txtDeliveryNoteDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDeliveryNoteDate.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtDeliveryNoteDate.Properties.Appearance.Options.UseBackColor = True
        Me.txtDeliveryNoteDate.Properties.Appearance.Options.UseFont = True
        Me.txtDeliveryNoteDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDeliveryNoteDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDeliveryNoteDate.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.txtDeliveryNoteDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDeliveryNoteDate.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.txtDeliveryNoteDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDeliveryNoteDate.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.txtDeliveryNoteDate.Size = New System.Drawing.Size(162, 24)
        Me.txtDeliveryNoteDate.TabIndex = 95
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl8.Location = New System.Drawing.Point(12, 6)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(95, 14)
        Me.LabelControl8.TabIndex = 91
        Me.LabelControl8.Text = "Delivery Note No:"
        '
        'txtTotalDeliveryValue
        '
        Me.txtTotalDeliveryValue.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalDeliveryValue.Enabled = False
        Me.txtTotalDeliveryValue.EnterMoveNextControl = True
        Me.txtTotalDeliveryValue.Location = New System.Drawing.Point(728, 23)
        Me.txtTotalDeliveryValue.Name = "txtTotalDeliveryValue"
        Me.txtTotalDeliveryValue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalDeliveryValue.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalDeliveryValue.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTotalDeliveryValue.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalDeliveryValue.Properties.Appearance.Options.UseFont = True
        Me.txtTotalDeliveryValue.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalDeliveryValue.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalDeliveryValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalDeliveryValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtTotalDeliveryValue.Properties.DisplayFormat.FormatString = "n4"
        Me.txtTotalDeliveryValue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDeliveryValue.Properties.EditFormat.FormatString = "n4"
        Me.txtTotalDeliveryValue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDeliveryValue.Properties.Mask.EditMask = "n4"
        Me.txtTotalDeliveryValue.Size = New System.Drawing.Size(167, 24)
        Me.txtTotalDeliveryValue.TabIndex = 3
        '
        'lblRateOrPrice
        '
        Me.lblRateOrPrice.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRateOrPrice.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblRateOrPrice.Location = New System.Drawing.Point(729, 8)
        Me.lblRateOrPrice.Name = "lblRateOrPrice"
        Me.lblRateOrPrice.Size = New System.Drawing.Size(45, 14)
        Me.lblRateOrPrice.TabIndex = 93
        Me.lblRateOrPrice.Text = "Amount"
        '
        'txtDeliveryNoteNo
        '
        Me.txtDeliveryNoteNo.Enabled = False
        Me.txtDeliveryNoteNo.EnterMoveNextControl = True
        Me.txtDeliveryNoteNo.Location = New System.Drawing.Point(9, 23)
        Me.txtDeliveryNoteNo.Name = "txtDeliveryNoteNo"
        Me.txtDeliveryNoteNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDeliveryNoteNo.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtDeliveryNoteNo.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDeliveryNoteNo.Properties.Appearance.Options.UseBackColor = True
        Me.txtDeliveryNoteNo.Properties.Appearance.Options.UseFont = True
        Me.txtDeliveryNoteNo.Properties.Appearance.Options.UseForeColor = True
        Me.txtDeliveryNoteNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeliveryNoteNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtDeliveryNoteNo.Size = New System.Drawing.Size(186, 24)
        Me.txtDeliveryNoteNo.TabIndex = 0
        '
        'groupVoucherEntry
        '
        Me.groupVoucherEntry.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.groupVoucherEntry.Appearance.Options.UseBackColor = True
        Me.groupVoucherEntry.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.groupVoucherEntry.Controls.Add(Me.PanelControl4)
        Me.groupVoucherEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupVoucherEntry.Location = New System.Drawing.Point(19, 114)
        Me.groupVoucherEntry.LookAndFeel.SkinName = "Seven Classic"
        Me.groupVoucherEntry.LookAndFeel.UseDefaultLookAndFeel = False
        Me.groupVoucherEntry.Name = "groupVoucherEntry"
        Me.groupVoucherEntry.Size = New System.Drawing.Size(981, 58)
        Me.groupVoucherEntry.TabIndex = 113
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.txtLineTotal)
        Me.PanelControl4.Controls.Add(Me.LabelControl10)
        Me.PanelControl4.Controls.Add(Me.txtUnitMethod1)
        Me.PanelControl4.Controls.Add(Me.txtUnitRate1)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.btnAdd)
        Me.PanelControl4.Controls.Add(Me.txtItemRequested)
        Me.PanelControl4.Controls.Add(Me.txtQty)
        Me.PanelControl4.Controls.Add(Me.LabelControl3)
        Me.PanelControl4.Controls.Add(Me.LabelControl4)
        Me.PanelControl4.Location = New System.Drawing.Point(1, 1)
        Me.PanelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(978, 55)
        Me.PanelControl4.TabIndex = 34
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Location = New System.Drawing.Point(789, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 14)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Amount"
        '
        'txtLineTotal
        '
        Me.txtLineTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLineTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLineTotal.Enabled = False
        Me.txtLineTotal.EnterMoveNextControl = True
        Me.txtLineTotal.Location = New System.Drawing.Point(786, 23)
        Me.txtLineTotal.Name = "txtLineTotal"
        Me.txtLineTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLineTotal.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtLineTotal.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLineTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtLineTotal.Properties.Appearance.Options.UseFont = True
        Me.txtLineTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtLineTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLineTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLineTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtLineTotal.Properties.DisplayFormat.FormatString = "n4"
        Me.txtLineTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLineTotal.Properties.EditFormat.FormatString = "n4"
        Me.txtLineTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLineTotal.Properties.Mask.EditMask = "n2"
        Me.txtLineTotal.Size = New System.Drawing.Size(108, 22)
        Me.txtLineTotal.TabIndex = 12
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Location = New System.Drawing.Point(427, 6)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl10.TabIndex = 2
        Me.LabelControl10.Text = "UoM:"
        '
        'txtUnitMethod1
        '
        Me.txtUnitMethod1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnitMethod1.EnterMoveNextControl = True
        Me.txtUnitMethod1.Location = New System.Drawing.Point(422, 23)
        Me.txtUnitMethod1.Name = "txtUnitMethod1"
        Me.txtUnitMethod1.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtUnitMethod1.Properties.Appearance.Options.UseFont = True
        Me.txtUnitMethod1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnitMethod1.Properties.DataSource = Me.Tbl40111PropertyUnitCodesBindingSource
        Me.txtUnitMethod1.Properties.DisplayMember = "UnitType"
        Me.txtUnitMethod1.Properties.ImmediatePopup = True
        Me.txtUnitMethod1.Properties.NullText = ""
        Me.txtUnitMethod1.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.txtUnitMethod1.Properties.ValueMember = "UnitCode"
        Me.txtUnitMethod1.Properties.View = Me.GridView4
        Me.txtUnitMethod1.Size = New System.Drawing.Size(134, 22)
        Me.txtUnitMethod1.TabIndex = 3
        '
        'Tbl40111PropertyUnitCodesBindingSource
        '
        Me.Tbl40111PropertyUnitCodesBindingSource.DataMember = "tbl40111PropertyUnitCodes"
        Me.Tbl40111PropertyUnitCodesBindingSource.DataSource = Me.Dsfrm601_09MaterialReceiptEdit1
        '
        'Dsfrm601_09MaterialReceiptEdit1
        '
        Me.Dsfrm601_09MaterialReceiptEdit1.DataSetName = "dsfrm601_09MaterialReceiptEdit"
        Me.Dsfrm601_09MaterialReceiptEdit1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView4.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView4.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView4.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.GridView4.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView4.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView4.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView4.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView4.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.GridView4.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView4.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.GridView4.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView4.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView4.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView4.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GridView4.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView4.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GridView4.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView4.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView4.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView4.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView4.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView4.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView4.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView4.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView4.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView4.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView4.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GridView4.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView4.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView4.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView4.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView4.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView4.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView4.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView4.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.GridView4.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView4.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView4.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView4.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView4.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView4.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView4.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView4.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView4.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView4.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView4.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView4.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GridView4.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView4.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView4.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView4.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray
        Me.GridView4.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.GridView4.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView4.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView4.Appearance.HeaderPanel.BackColor = System.Drawing.Color.SkyBlue
        Me.GridView4.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView4.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView4.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView4.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView4.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView4.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.GridView4.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView4.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView4.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView4.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
        Me.GridView4.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView4.Appearance.OddRow.BackColor = System.Drawing.SystemColors.Window
        Me.GridView4.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.GridView4.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GridView4.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView4.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView4.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridView4.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.GridView4.Appearance.Preview.ForeColor = System.Drawing.Color.Purple
        Me.GridView4.Appearance.Preview.Options.UseBackColor = True
        Me.GridView4.Appearance.Preview.Options.UseForeColor = True
        Me.GridView4.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView4.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.Row.Options.UseBackColor = True
        Me.GridView4.Appearance.Row.Options.UseForeColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode, Me.colUnitType, Me.colUnitDesc})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView4.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView4.OptionsView.EnableAppearanceOddRow = True
        Me.GridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.PaintStyleName = "Skin"
        Me.GridView4.RowHeight = 26
        Me.GridView4.RowSeparatorHeight = 2
        '
        'colUnitCode
        '
        Me.colUnitCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitCode.AppearanceCell.Options.UseFont = True
        Me.colUnitCode.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitCode.AppearanceHeader.Options.UseFont = True
        Me.colUnitCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Width = 125
        '
        'colUnitType
        '
        Me.colUnitType.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitType.AppearanceCell.Options.UseFont = True
        Me.colUnitType.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitType.AppearanceHeader.Options.UseFont = True
        Me.colUnitType.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitType.FieldName = "UnitType"
        Me.colUnitType.Name = "colUnitType"
        Me.colUnitType.Visible = True
        Me.colUnitType.VisibleIndex = 0
        Me.colUnitType.Width = 475
        '
        'colUnitDesc
        '
        Me.colUnitDesc.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitDesc.AppearanceCell.Options.UseFont = True
        Me.colUnitDesc.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitDesc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitDesc.AppearanceHeader.Options.UseFont = True
        Me.colUnitDesc.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitDesc.FieldName = "UnitDesc"
        Me.colUnitDesc.Name = "colUnitDesc"
        Me.colUnitDesc.Width = 478
        '
        'txtUnitRate1
        '
        Me.txtUnitRate1.AllowDrop = True
        Me.txtUnitRate1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnitRate1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnitRate1.EnterMoveNextControl = True
        Me.txtUnitRate1.Location = New System.Drawing.Point(671, 23)
        Me.txtUnitRate1.Name = "txtUnitRate1"
        Me.txtUnitRate1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUnitRate1.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtUnitRate1.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtUnitRate1.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnitRate1.Properties.Appearance.Options.UseFont = True
        Me.txtUnitRate1.Properties.Appearance.Options.UseForeColor = True
        Me.txtUnitRate1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnitRate1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnitRate1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtUnitRate1.Properties.DisplayFormat.FormatString = "n4"
        Me.txtUnitRate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtUnitRate1.Properties.EditFormat.FormatString = "n4"
        Me.txtUnitRate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtUnitRate1.Properties.Mask.EditMask = "n2"
        Me.txtUnitRate1.Size = New System.Drawing.Size(111, 22)
        Me.txtUnitRate1.TabIndex = 9
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Location = New System.Drawing.Point(673, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Unit Price"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.Appearance.Options.UseForeColor = True
        Me.btnAdd.Image = Global.ERP.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(896, 6)
        Me.btnAdd.LookAndFeel.SkinName = "iMaginary"
        Me.btnAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 40)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "ADD"
        '
        'txtItemRequested
        '
        Me.txtItemRequested.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemRequested.EnterMoveNextControl = True
        Me.txtItemRequested.Location = New System.Drawing.Point(9, 23)
        Me.txtItemRequested.Name = "txtItemRequested"
        Me.txtItemRequested.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtItemRequested.Properties.Appearance.Options.UseFont = True
        Me.txtItemRequested.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItemRequested.Properties.DataSource = Me.Tbl20164GoodsAndServicesMasterBindingSource
        Me.txtItemRequested.Properties.DisplayMember = "GSDescrpition"
        Me.txtItemRequested.Properties.ImmediatePopup = True
        Me.txtItemRequested.Properties.NullText = ""
        Me.txtItemRequested.Properties.PopupFormSize = New System.Drawing.Size(1000, 0)
        Me.txtItemRequested.Properties.ValueMember = "GSCode"
        Me.txtItemRequested.Properties.View = Me.GridView3
        Me.txtItemRequested.Size = New System.Drawing.Size(411, 22)
        Me.txtItemRequested.TabIndex = 1
        '
        'Tbl20164GoodsAndServicesMasterBindingSource
        '
        Me.Tbl20164GoodsAndServicesMasterBindingSource.DataMember = "tbl20164GoodsAndServicesMaster"
        Me.Tbl20164GoodsAndServicesMasterBindingSource.DataSource = Me.Dsfrm601_09MaterialReceiptEdit1
        '
        'GridView3
        '
        Me.GridView3.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView3.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.GridView3.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView3.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView3.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView3.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView3.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.GridView3.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView3.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.GridView3.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView3.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView3.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.GridView3.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView3.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView3.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView3.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView3.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GridView3.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView3.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView3.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView3.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView3.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView3.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView3.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView3.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView3.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView3.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView3.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GridView3.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView3.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView3.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView3.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView3.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView3.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView3.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView3.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView3.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView3.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView3.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView3.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView3.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView3.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GridView3.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView3.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView3.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView3.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray
        Me.GridView3.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView3.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView3.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView3.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView3.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView3.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.GridView3.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GridView3.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView3.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView3.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridView3.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.GridView3.Appearance.Preview.ForeColor = System.Drawing.Color.Purple
        Me.GridView3.Appearance.Preview.Options.UseBackColor = True
        Me.GridView3.Appearance.Preview.Options.UseForeColor = True
        Me.GridView3.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView3.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.Row.Options.UseBackColor = True
        Me.GridView3.Appearance.Row.Options.UseForeColor = True
        Me.GridView3.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView3.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView3.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.VertLine.BackColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGSCode1, Me.colGSDescrpition1})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView3.OptionsView.EnableAppearanceOddRow = True
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.RowHeight = 30
        Me.GridView3.RowSeparatorHeight = 2
        '
        'colGSCode1
        '
        Me.colGSCode1.Caption = "Item Code"
        Me.colGSCode1.FieldName = "GSCode"
        Me.colGSCode1.Name = "colGSCode1"
        Me.colGSCode1.Visible = True
        Me.colGSCode1.VisibleIndex = 0
        Me.colGSCode1.Width = 201
        '
        'colGSDescrpition1
        '
        Me.colGSDescrpition1.Caption = "Description"
        Me.colGSDescrpition1.FieldName = "GSDescrpition"
        Me.colGSDescrpition1.Name = "colGSDescrpition1"
        Me.colGSDescrpition1.Visible = True
        Me.colGSDescrpition1.VisibleIndex = 1
        Me.colGSDescrpition1.Width = 1388
        '
        'txtQty
        '
        Me.txtQty.AllowDrop = True
        Me.txtQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtQty.EnterMoveNextControl = True
        Me.txtQty.Location = New System.Drawing.Point(559, 23)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtQty.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtQty.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtQty.Properties.Appearance.Options.UseBackColor = True
        Me.txtQty.Properties.Appearance.Options.UseFont = True
        Me.txtQty.Properties.Appearance.Options.UseForeColor = True
        Me.txtQty.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtQty.Properties.DisplayFormat.FormatString = "n0"
        Me.txtQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQty.Properties.EditFormat.FormatString = "n0"
        Me.txtQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQty.Properties.Mask.EditMask = "n0"
        Me.txtQty.Size = New System.Drawing.Size(108, 22)
        Me.txtQty.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Location = New System.Drawing.Point(562, 6)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 14)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Quantity"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Location = New System.Drawing.Point(13, 6)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(96, 14)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Item Description:"
        '
        'gcSubLedger
        '
        Me.gcSubLedger.DataSource = Me.Qry60502MaterialReceiptChildBindingSource
        Me.gcSubLedger.Location = New System.Drawing.Point(19, 176)
        Me.gcSubLedger.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcSubLedger.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcSubLedger.MainView = Me.gvSubLedger
        Me.gcSubLedger.Name = "gcSubLedger"
        Me.gcSubLedger.Size = New System.Drawing.Size(977, 250)
        Me.gcSubLedger.TabIndex = 114
        Me.gcSubLedger.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSubLedger, Me.GridView5})
        '
        'Qry60502MaterialReceiptChildBindingSource
        '
        Me.Qry60502MaterialReceiptChildBindingSource.DataMember = "qry605_02MaterialReceiptChild"
        Me.Qry60502MaterialReceiptChildBindingSource.DataSource = Me.Dsfrm601_09MaterialReceiptEdit
        '
        'Dsfrm601_09MaterialReceiptEdit
        '
        Me.Dsfrm601_09MaterialReceiptEdit.DataSetName = "dsfrm601_09MaterialReceiptEdit"
        Me.Dsfrm601_09MaterialReceiptEdit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvSubLedger
        '
        Me.gvSubLedger.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvSubLedger.Appearance.TopNewRow.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvSubLedger.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvSubLedger.Appearance.TopNewRow.Options.UseFont = True
        Me.gvSubLedger.ColumnPanelRowHeight = 40
        Me.gvSubLedger.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReceiptChildSlNo, Me.colReceiptNo, Me.colGSCode, Me.colGSDescrpition, Me.colQtyReceived, Me.colUnitRateMethod, Me.colUnitPrice, Me.colLineOrderNo, Me.colLineTotalWithTax})
        Me.gvSubLedger.CustomizationFormBounds = New System.Drawing.Rectangle(702, 474, 208, 191)
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
        Me.gvSubLedger.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.gvSubLedger.GridControl = Me.gcSubLedger
        Me.gvSubLedger.Name = "gvSubLedger"
        Me.gvSubLedger.OptionsNavigation.AutoFocusNewRow = True
        Me.gvSubLedger.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvSubLedger.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSubLedger.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvSubLedger.OptionsSelection.MultiSelect = True
        Me.gvSubLedger.OptionsView.ShowFooter = True
        Me.gvSubLedger.OptionsView.ShowGroupPanel = False
        Me.gvSubLedger.RowHeight = 35
        Me.gvSubLedger.RowSeparatorHeight = 1
        '
        'colReceiptChildSlNo
        '
        Me.colReceiptChildSlNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colReceiptChildSlNo.AppearanceHeader.Options.UseFont = True
        Me.colReceiptChildSlNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceiptChildSlNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceiptChildSlNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceiptChildSlNo.FieldName = "ReceiptChildSlNo"
        Me.colReceiptChildSlNo.Name = "colReceiptChildSlNo"
        Me.colReceiptChildSlNo.Width = 125
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
        Me.colReceiptNo.Visible = True
        Me.colReceiptNo.VisibleIndex = 0
        Me.colReceiptNo.Width = 108
        '
        'colGSCode
        '
        Me.colGSCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSCode.AppearanceHeader.Options.UseFont = True
        Me.colGSCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSCode.FieldName = "GSCode"
        Me.colGSCode.Name = "colGSCode"
        Me.colGSCode.Width = 151
        '
        'colGSDescrpition
        '
        Me.colGSDescrpition.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGSDescrpition.AppearanceHeader.Options.UseFont = True
        Me.colGSDescrpition.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSDescrpition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSDescrpition.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSDescrpition.Caption = "Description"
        Me.colGSDescrpition.FieldName = "GSDescrpition"
        Me.colGSDescrpition.Name = "colGSDescrpition"
        Me.colGSDescrpition.Visible = True
        Me.colGSDescrpition.VisibleIndex = 1
        Me.colGSDescrpition.Width = 344
        '
        'colQtyReceived
        '
        Me.colQtyReceived.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtyReceived.AppearanceHeader.Options.UseFont = True
        Me.colQtyReceived.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyReceived.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQtyReceived.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyReceived.FieldName = "QtyReceived"
        Me.colQtyReceived.Name = "colQtyReceived"
        Me.colQtyReceived.Visible = True
        Me.colQtyReceived.VisibleIndex = 2
        Me.colQtyReceived.Width = 105
        '
        'colUnitRateMethod
        '
        Me.colUnitRateMethod.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitRateMethod.AppearanceHeader.Options.UseFont = True
        Me.colUnitRateMethod.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitRateMethod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitRateMethod.Caption = "UoM"
        Me.colUnitRateMethod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitRateMethod.FieldName = "UnitRateMethod"
        Me.colUnitRateMethod.Name = "colUnitRateMethod"
        Me.colUnitRateMethod.Visible = True
        Me.colUnitRateMethod.VisibleIndex = 3
        Me.colUnitRateMethod.Width = 105
        '
        'colUnitPrice
        '
        Me.colUnitPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitPrice.AppearanceHeader.Options.UseFont = True
        Me.colUnitPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 4
        Me.colUnitPrice.Width = 110
        '
        'colLineOrderNo
        '
        Me.colLineOrderNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLineOrderNo.AppearanceHeader.Options.UseFont = True
        Me.colLineOrderNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineOrderNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineOrderNo.FieldName = "LineOrderNo"
        Me.colLineOrderNo.Name = "colLineOrderNo"
        Me.colLineOrderNo.Width = 175
        '
        'colLineTotalWithTax
        '
        Me.colLineTotalWithTax.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLineTotalWithTax.AppearanceHeader.Options.UseFont = True
        Me.colLineTotalWithTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineTotalWithTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineTotalWithTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineTotalWithTax.Caption = "Total Amount"
        Me.colLineTotalWithTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLineTotalWithTax.FieldName = "LineTotalWithTax"
        Me.colLineTotalWithTax.Name = "colLineTotalWithTax"
        Me.colLineTotalWithTax.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotalWithTax", "{0:0.##}")})
        Me.colLineTotalWithTax.Visible = True
        Me.colLineTotalWithTax.VisibleIndex = 5
        Me.colLineTotalWithTax.Width = 131
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.gcSubLedger
        Me.GridView5.Name = "GridView5"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnDelete, Me.btnPreview, Me.btnBack, Me.btnDeleteLineEntry, Me.btnSaveAndClose, Me.btnPostJournal})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSave, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDelete, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPreview, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnBack, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPostJournal, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Glyph = Global.ERP.My.Resources.Resources.Save24x24
        Me.btnSave.Id = 0
        Me.btnSave.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSave.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S))
        Me.btnSave.Name = "btnSave"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Glyph = Global.ERP.My.Resources.Resources.DeleteRed
        Me.btnDelete.Id = 1
        Me.btnDelete.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDelete.Name = "btnDelete"
        '
        'btnPreview
        '
        Me.btnPreview.Caption = "Preview"
        Me.btnPreview.Glyph = Global.ERP.My.Resources.Resources.preview_256
        Me.btnPreview.Id = 2
        Me.btnPreview.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPreview.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnBack
        '
        Me.btnBack.Caption = "Back"
        Me.btnBack.Glyph = Global.ERP.My.Resources.Resources.GoBackBlue24x24
        Me.btnBack.Id = 4
        Me.btnBack.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBack.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Home)
        Me.btnBack.Name = "btnBack"
        '
        'btnPostJournal
        '
        Me.btnPostJournal.Caption = "Post Journal"
        Me.btnPostJournal.Glyph = Global.ERP.My.Resources.Resources.EditGen24x24
        Me.btnPostJournal.Id = 7
        Me.btnPostJournal.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnPostJournal.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPostJournal.Name = "btnPostJournal"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Black"
        Me.BarAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1000, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 457)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1000, 35)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 457)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1000, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 457)
        '
        'btnDeleteLineEntry
        '
        Me.btnDeleteLineEntry.Caption = "Delete Line Entry"
        Me.btnDeleteLineEntry.Glyph = Global.ERP.My.Resources.Resources.DeleteRed
        Me.btnDeleteLineEntry.Id = 5
        Me.btnDeleteLineEntry.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteLineEntry.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red
        Me.btnDeleteLineEntry.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDeleteLineEntry.ItemAppearance.Normal.Options.UseForeColor = True
        Me.btnDeleteLineEntry.Name = "btnDeleteLineEntry"
        '
        'btnSaveAndClose
        '
        Me.btnSaveAndClose.Caption = "Save && Close"
        Me.btnSaveAndClose.Id = 6
        Me.btnSaveAndClose.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnSaveAndClose.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDeleteLineEntry)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'txtMaterialReceiptNo
        '
        Me.txtMaterialReceiptNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Tbl60501MaterialReceiptMasterBindingSource, "ReceiptNo", True))
        Me.txtMaterialReceiptNo.Enabled = False
        Me.txtMaterialReceiptNo.EnterMoveNextControl = True
        Me.txtMaterialReceiptNo.Location = New System.Drawing.Point(29, 190)
        Me.txtMaterialReceiptNo.Name = "txtMaterialReceiptNo"
        Me.txtMaterialReceiptNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMaterialReceiptNo.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtMaterialReceiptNo.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMaterialReceiptNo.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaterialReceiptNo.Properties.Appearance.Options.UseFont = True
        Me.txtMaterialReceiptNo.Properties.Appearance.Options.UseForeColor = True
        Me.txtMaterialReceiptNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaterialReceiptNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtMaterialReceiptNo.Size = New System.Drawing.Size(186, 24)
        Me.txtMaterialReceiptNo.TabIndex = 119
        '
        'Tbl60501MaterialReceiptMasterBindingSource
        '
        Me.Tbl60501MaterialReceiptMasterBindingSource.DataMember = "tbl605_01MaterialReceiptMaster"
        Me.Tbl60501MaterialReceiptMasterBindingSource.DataSource = Me.Dsfrm601_09MaterialReceiptEdit
        '
        'Qry605_02MaterialReceiptChildTableAdapter
        '
        Me.Qry605_02MaterialReceiptChildTableAdapter.ClearBeforeFill = True
        '
        'Tbl605_01MaterialReceiptMasterTableAdapter
        '
        Me.Tbl605_01MaterialReceiptMasterTableAdapter.ClearBeforeFill = True
        '
        'txtMaterialReceiptDate
        '
        Me.txtMaterialReceiptDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Tbl60501MaterialReceiptMasterBindingSource, "ReceiptDate", True))
        Me.txtMaterialReceiptDate.EditValue = Nothing
        Me.txtMaterialReceiptDate.Enabled = False
        Me.txtMaterialReceiptDate.EnterMoveNextControl = True
        Me.txtMaterialReceiptDate.Location = New System.Drawing.Point(223, 190)
        Me.txtMaterialReceiptDate.Name = "txtMaterialReceiptDate"
        Me.txtMaterialReceiptDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMaterialReceiptDate.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtMaterialReceiptDate.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaterialReceiptDate.Properties.Appearance.Options.UseFont = True
        Me.txtMaterialReceiptDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMaterialReceiptDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtMaterialReceiptDate.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.txtMaterialReceiptDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtMaterialReceiptDate.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.txtMaterialReceiptDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtMaterialReceiptDate.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.txtMaterialReceiptDate.Size = New System.Drawing.Size(159, 24)
        Me.txtMaterialReceiptDate.TabIndex = 120
        '
        'txtStoreCode
        '
        Me.txtStoreCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Tbl60501MaterialReceiptMasterBindingSource, "StoreCode", True))
        Me.txtStoreCode.Enabled = False
        Me.txtStoreCode.EnterMoveNextControl = True
        Me.txtStoreCode.Location = New System.Drawing.Point(385, 190)
        Me.txtStoreCode.Name = "txtStoreCode"
        Me.txtStoreCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtStoreCode.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtStoreCode.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtStoreCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtStoreCode.Properties.Appearance.Options.UseFont = True
        Me.txtStoreCode.Properties.Appearance.Options.UseForeColor = True
        Me.txtStoreCode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStoreCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtStoreCode.Size = New System.Drawing.Size(134, 24)
        Me.txtStoreCode.TabIndex = 121
        '
        'Tbl20164GoodsAndServicesMasterTableAdapter
        '
        Me.Tbl20164GoodsAndServicesMasterTableAdapter.ClearBeforeFill = True
        '
        'Tbl40111PropertyUnitCodesTableAdapter
        '
        Me.Tbl40111PropertyUnitCodesTableAdapter.ClearBeforeFill = True
        '
        'txtDN
        '
        Me.txtDN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Tbl60501MaterialReceiptMasterBindingSource, "DeliveryNoteNo", True))
        Me.txtDN.Enabled = False
        Me.txtDN.EnterMoveNextControl = True
        Me.txtDN.Location = New System.Drawing.Point(524, 190)
        Me.txtDN.Name = "txtDN"
        Me.txtDN.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDN.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtDN.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDN.Properties.Appearance.Options.UseBackColor = True
        Me.txtDN.Properties.Appearance.Options.UseFont = True
        Me.txtDN.Properties.Appearance.Options.UseForeColor = True
        Me.txtDN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtDN.Size = New System.Drawing.Size(134, 24)
        Me.txtDN.TabIndex = 126
        '
        'txtPostedOn
        '
        Me.txtPostedOn.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Tbl60501MaterialReceiptMasterBindingSource, "PostedOn", True))
        Me.txtPostedOn.EditValue = Nothing
        Me.txtPostedOn.Enabled = False
        Me.txtPostedOn.EnterMoveNextControl = True
        Me.txtPostedOn.Location = New System.Drawing.Point(855, 431)
        Me.txtPostedOn.Name = "txtPostedOn"
        Me.txtPostedOn.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtPostedOn.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtPostedOn.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtPostedOn.Properties.Appearance.Options.UseBackColor = True
        Me.txtPostedOn.Properties.Appearance.Options.UseFont = True
        Me.txtPostedOn.Properties.Appearance.Options.UseForeColor = True
        Me.txtPostedOn.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtPostedOn.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPostedOn.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtPostedOn.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPostedOn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPostedOn.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPostedOn.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.txtPostedOn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPostedOn.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.txtPostedOn.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPostedOn.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.txtPostedOn.Size = New System.Drawing.Size(142, 16)
        Me.txtPostedOn.TabIndex = 151
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl43.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl43.Location = New System.Drawing.Point(798, 433)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(51, 12)
        Me.LabelControl43.TabIndex = 149
        Me.LabelControl43.Text = "Posted On:"
        '
        'lblPostedBy
        '
        Me.lblPostedBy.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblPostedBy.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblPostedBy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl60501MaterialReceiptMasterBindingSource, "PostedBy", True))
        Me.lblPostedBy.Location = New System.Drawing.Point(109, 437)
        Me.lblPostedBy.Name = "lblPostedBy"
        Me.lblPostedBy.Size = New System.Drawing.Size(6, 12)
        Me.lblPostedBy.TabIndex = 150
        Me.lblPostedBy.Text = "..."
        '
        'txtIsPosted
        '
        Me.txtIsPosted.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Tbl60501MaterialReceiptMasterBindingSource, "IsPosted", True))
        Me.txtIsPosted.Enabled = False
        Me.txtIsPosted.Location = New System.Drawing.Point(25, 432)
        Me.txtIsPosted.Name = "txtIsPosted"
        Me.txtIsPosted.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtIsPosted.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtIsPosted.Properties.Appearance.Options.UseFont = True
        Me.txtIsPosted.Properties.Appearance.Options.UseForeColor = True
        Me.txtIsPosted.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtIsPosted.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtIsPosted.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtIsPosted.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtIsPosted.Properties.Caption = "Posted By:"
        Me.txtIsPosted.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.txtIsPosted.Size = New System.Drawing.Size(78, 22)
        Me.txtIsPosted.TabIndex = 148
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Location = New System.Drawing.Point(555, 432)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(89, 12)
        Me.LabelControl5.TabIndex = 156
        Me.LabelControl5.Text = "Posted Journal No:"
        '
        'txtPostedJVNo
        '
        Me.txtPostedJVNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Tbl60501MaterialReceiptMasterBindingSource, "VoucherNo", True))
        Me.txtPostedJVNo.Enabled = False
        Me.txtPostedJVNo.Location = New System.Drawing.Point(650, 431)
        Me.txtPostedJVNo.Name = "txtPostedJVNo"
        Me.txtPostedJVNo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtPostedJVNo.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtPostedJVNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtPostedJVNo.Properties.Appearance.Options.UseBackColor = True
        Me.txtPostedJVNo.Properties.Appearance.Options.UseFont = True
        Me.txtPostedJVNo.Properties.Appearance.Options.UseForeColor = True
        Me.txtPostedJVNo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtPostedJVNo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPostedJVNo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtPostedJVNo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPostedJVNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPostedJVNo.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.txtPostedJVNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtPostedJVNo.Size = New System.Drawing.Size(142, 16)
        Me.txtPostedJVNo.TabIndex = 157
        '
        'frm601_24ProductionReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 492)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtPostedOn)
        Me.Controls.Add(Me.LabelControl43)
        Me.Controls.Add(Me.lblPostedBy)
        Me.Controls.Add(Me.txtIsPosted)
        Me.Controls.Add(Me.gcSubLedger)
        Me.Controls.Add(Me.txtDN)
        Me.Controls.Add(Me.txtStoreCode)
        Me.Controls.Add(Me.txtMaterialReceiptDate)
        Me.Controls.Add(Me.txtMaterialReceiptNo)
        Me.Controls.Add(Me.groupVoucherEntry)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.txtPostedJVNo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm601_24ProductionReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Receipt from Production Unit"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtReceivedFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryNoteDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryNoteDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDeliveryValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryNoteNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupVoucherEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupVoucherEntry.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.txtLineTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitMethod1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl40111PropertyUnitCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_09MaterialReceiptEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitRate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemRequested.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl20164GoodsAndServicesMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcSubLedger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60502MaterialReceiptChildBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_09MaterialReceiptEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSubLedger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialReceiptNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl60501MaterialReceiptMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialReceiptDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialReceiptDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStoreCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostedOn.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostedOn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIsPosted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostedJVNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalDeliveryValue As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblRateOrPrice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDeliveryNoteNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents groupVoucherEntry As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcSubLedger As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSubLedger As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBack As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnDeleteLineEntry As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDeliveryNoteDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblStoreIssuedTo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLineTotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnitMethod1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtUnitRate1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtItemRequested As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtQty As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaterialReceiptNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Qry60502MaterialReceiptChildBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dsfrm601_09MaterialReceiptEdit As ERP.dsfrm601_09MaterialReceiptEdit
    Friend WithEvents colReceiptChildSlNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiptNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDescrpition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyReceived As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitRateMethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineTotalWithTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qry605_02MaterialReceiptChildTableAdapter As ERP.dsfrm601_09MaterialReceiptEditTableAdapters.qry605_02MaterialReceiptChildTableAdapter
    Friend WithEvents Tbl60501MaterialReceiptMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl605_01MaterialReceiptMasterTableAdapter As ERP.dsfrm601_09MaterialReceiptEditTableAdapters.tbl605_01MaterialReceiptMasterTableAdapter
    Friend WithEvents txtStoreCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaterialReceiptDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Dsfrm601_09MaterialReceiptEdit1 As ERP.dsfrm601_09MaterialReceiptEdit
    Friend WithEvents Tbl20164GoodsAndServicesMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl20164GoodsAndServicesMasterTableAdapter As ERP.dsfrm601_09MaterialReceiptEditTableAdapters.tbl20164GoodsAndServicesMasterTableAdapter
    Friend WithEvents Tbl40111PropertyUnitCodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl40111PropertyUnitCodesTableAdapter As ERP.dsfrm601_09MaterialReceiptEditTableAdapters.tbl40111PropertyUnitCodesTableAdapter
    Friend WithEvents btnSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReceivedFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colGSCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSDescrpition1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPostJournal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtPostedOn As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPostedBy As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIsPosted As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPostedJVNo As DevExpress.XtraEditors.TextEdit
End Class
