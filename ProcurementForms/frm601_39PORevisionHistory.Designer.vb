<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm601_39PORevisionHistory
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
        Me.gcPORevisionHistory = New DevExpress.XtraGrid.GridControl()
        Me.Qry60404PurchaseOrderViewMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_39PORevisionHistory = New ERP.dsfrm601_39PORevisionHistory()
        Me.gvPORevisionHistory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPONo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPODate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierQuoteNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierQuoteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAttention = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierContactEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubjectTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreparedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreparedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOIntroduction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOSummary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevisionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdditionsText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscountsText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPODueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOSignatory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdditionsAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeductionsAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoOfItems = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalBeforeTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalAfterDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalTaxAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalWithTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrandTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalanceToReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderedQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivedQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalOrdered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalBilled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalanceToBill = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRFQNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTypeOfRequest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMPRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectMasterCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExchangeRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalAmountB4TaxInOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalAmountAfterDiscInOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalTaxAmountInOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalDiscountInOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalWithTaxInOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrandTotalInOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSubmitted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsVerified = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPORevisionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsObseleteVersion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPORevisionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Qry604_04PurchaseOrderViewMasterTableAdapter = New ERP.dsfrm601_39PORevisionHistoryTableAdapters.qry604_04PurchaseOrderViewMasterTableAdapter()
        Me.repoEditPO = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        CType(Me.gcPORevisionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60404PurchaseOrderViewMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_39PORevisionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPORevisionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoEditPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcPORevisionHistory
        '
        Me.gcPORevisionHistory.DataSource = Me.Qry60404PurchaseOrderViewMasterBindingSource
        Me.gcPORevisionHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPORevisionHistory.Location = New System.Drawing.Point(0, 0)
        Me.gcPORevisionHistory.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.gcPORevisionHistory.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcPORevisionHistory.MainView = Me.gvPORevisionHistory
        Me.gcPORevisionHistory.Name = "gcPORevisionHistory"
        Me.gcPORevisionHistory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoEditPO})
        Me.gcPORevisionHistory.Size = New System.Drawing.Size(935, 387)
        Me.gcPORevisionHistory.TabIndex = 73
        Me.gcPORevisionHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPORevisionHistory})
        '
        'Qry60404PurchaseOrderViewMasterBindingSource
        '
        Me.Qry60404PurchaseOrderViewMasterBindingSource.DataMember = "qry604_04PurchaseOrderViewMaster"
        Me.Qry60404PurchaseOrderViewMasterBindingSource.DataSource = Me.Dsfrm601_39PORevisionHistory
        '
        'Dsfrm601_39PORevisionHistory
        '
        Me.Dsfrm601_39PORevisionHistory.DataSetName = "dsfrm601_39PORevisionHistory"
        Me.Dsfrm601_39PORevisionHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvPORevisionHistory
        '
        Me.gvPORevisionHistory.ColumnPanelRowHeight = 40
        Me.gvPORevisionHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPONo, Me.colPODate, Me.colSupplierCode, Me.colSupplierName, Me.colSupplierCategory, Me.colSupplierQuoteNo, Me.colSupplierQuoteDate, Me.colSupplierRefNo, Me.colAttention, Me.colSupplierContactNo, Me.colSupplierContactEmail, Me.colSubjectTitle, Me.colPreparedBy, Me.colPreparedOn, Me.colApprovedBy, Me.colApprovedOn, Me.colAddedBy, Me.colAddedOn, Me.colModifiedBy, Me.colModifiedOn, Me.colIsApproved, Me.colProject, Me.colPOIntroduction, Me.colPOSummary, Me.colRevisionNo, Me.colCompanyBranch, Me.colAdditionsText, Me.colDiscountsText, Me.colPODueDate, Me.colPOSignatory, Me.colAdditionsAmount, Me.colDeductionsAmount, Me.colNoOfItems, Me.colTotalBeforeTax, Me.colTotalDiscount, Me.colTotalAfterDiscount, Me.colTotalTaxAmount, Me.colTotalWithTax, Me.colGrandTotal, Me.colBalanceToReceive, Me.colOrderStatus, Me.colOrderedQty, Me.colReceivedQty, Me.colTotalOrdered, Me.colTotalBilled, Me.colBalanceToBill, Me.colBillStatus, Me.colRFQNo, Me.colTypeOfRequest, Me.colMPRNo, Me.colProjectMasterCode, Me.colProjectDescription, Me.colCurrency, Me.colExchangeRate, Me.colTotalAmountB4TaxInOC, Me.colTotalAmountAfterDiscInOC, Me.colTotalTaxAmountInOC, Me.colTotalDiscountInOC, Me.colTotalWithTaxInOC, Me.colGrandTotalInOC, Me.colIsSubmitted, Me.colIsVerified, Me.colPORevisionID, Me.colIsObseleteVersion, Me.colPORevisionNo})
        Me.gvPORevisionHistory.CustomizationFormBounds = New System.Drawing.Rectangle(619, 193, 216, 204)
        Me.gvPORevisionHistory.GridControl = Me.gcPORevisionHistory
        Me.gvPORevisionHistory.Name = "gvPORevisionHistory"
        Me.gvPORevisionHistory.OptionsSelection.MultiSelect = True
        Me.gvPORevisionHistory.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvPORevisionHistory.OptionsView.ShowFooter = True
        Me.gvPORevisionHistory.OptionsView.ShowGroupPanel = False
        Me.gvPORevisionHistory.RowHeight = 40
        Me.gvPORevisionHistory.RowSeparatorHeight = 1
        '
        'colPONo
        '
        Me.colPONo.AppearanceCell.Options.UseTextOptions = True
        Me.colPONo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPONo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPONo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPONo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPONo.ColumnEdit = Me.repoEditPO
        Me.colPONo.FieldName = "PONo"
        Me.colPONo.Name = "colPONo"
        Me.colPONo.Visible = True
        Me.colPONo.VisibleIndex = 1
        Me.colPONo.Width = 160
        '
        'colPODate
        '
        Me.colPODate.AppearanceHeader.Options.UseTextOptions = True
        Me.colPODate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPODate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPODate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colPODate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPODate.FieldName = "PODate"
        Me.colPODate.Name = "colPODate"
        Me.colPODate.Visible = True
        Me.colPODate.VisibleIndex = 2
        Me.colPODate.Width = 80
        '
        'colSupplierCode
        '
        Me.colSupplierCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 3
        Me.colSupplierCode.Width = 128
        '
        'colSupplierName
        '
        Me.colSupplierName.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 4
        Me.colSupplierName.Width = 226
        '
        'colSupplierCategory
        '
        Me.colSupplierCategory.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierCategory.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierCategory.FieldName = "SupplierCategory"
        Me.colSupplierCategory.Name = "colSupplierCategory"
        '
        'colSupplierQuoteNo
        '
        Me.colSupplierQuoteNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierQuoteNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierQuoteNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierQuoteNo.FieldName = "SupplierQuoteNo"
        Me.colSupplierQuoteNo.Name = "colSupplierQuoteNo"
        '
        'colSupplierQuoteDate
        '
        Me.colSupplierQuoteDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierQuoteDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierQuoteDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierQuoteDate.FieldName = "SupplierQuoteDate"
        Me.colSupplierQuoteDate.Name = "colSupplierQuoteDate"
        '
        'colSupplierRefNo
        '
        Me.colSupplierRefNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierRefNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierRefNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierRefNo.FieldName = "SupplierRefNo"
        Me.colSupplierRefNo.Name = "colSupplierRefNo"
        '
        'colAttention
        '
        Me.colAttention.AppearanceHeader.Options.UseTextOptions = True
        Me.colAttention.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAttention.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAttention.FieldName = "Attention"
        Me.colAttention.Name = "colAttention"
        '
        'colSupplierContactNo
        '
        Me.colSupplierContactNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierContactNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierContactNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierContactNo.FieldName = "SupplierContactNo"
        Me.colSupplierContactNo.Name = "colSupplierContactNo"
        '
        'colSupplierContactEmail
        '
        Me.colSupplierContactEmail.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierContactEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierContactEmail.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierContactEmail.FieldName = "SupplierContactEmail"
        Me.colSupplierContactEmail.Name = "colSupplierContactEmail"
        '
        'colSubjectTitle
        '
        Me.colSubjectTitle.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubjectTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubjectTitle.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubjectTitle.FieldName = "SubjectTitle"
        Me.colSubjectTitle.Name = "colSubjectTitle"
        '
        'colPreparedBy
        '
        Me.colPreparedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreparedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreparedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreparedBy.FieldName = "PreparedBy"
        Me.colPreparedBy.Name = "colPreparedBy"
        '
        'colPreparedOn
        '
        Me.colPreparedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreparedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreparedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreparedOn.FieldName = "PreparedOn"
        Me.colPreparedOn.Name = "colPreparedOn"
        '
        'colApprovedBy
        '
        Me.colApprovedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedBy.FieldName = "ApprovedBy"
        Me.colApprovedBy.Name = "colApprovedBy"
        '
        'colApprovedOn
        '
        Me.colApprovedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedOn.FieldName = "ApprovedOn"
        Me.colApprovedOn.Name = "colApprovedOn"
        '
        'colAddedBy
        '
        Me.colAddedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddedBy.FieldName = "AddedBy"
        Me.colAddedBy.Name = "colAddedBy"
        '
        'colAddedOn
        '
        Me.colAddedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddedOn.FieldName = "AddedOn"
        Me.colAddedOn.Name = "colAddedOn"
        '
        'colModifiedBy
        '
        Me.colModifiedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        '
        'colModifiedOn
        '
        Me.colModifiedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedOn.FieldName = "ModifiedOn"
        Me.colModifiedOn.Name = "colModifiedOn"
        '
        'colIsApproved
        '
        Me.colIsApproved.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsApproved.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsApproved.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsApproved.FieldName = "IsApproved"
        Me.colIsApproved.Name = "colIsApproved"
        '
        'colProject
        '
        Me.colProject.AppearanceHeader.Options.UseTextOptions = True
        Me.colProject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProject.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProject.FieldName = "Project"
        Me.colProject.Name = "colProject"
        '
        'colPOIntroduction
        '
        Me.colPOIntroduction.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOIntroduction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOIntroduction.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOIntroduction.FieldName = "POIntroduction"
        Me.colPOIntroduction.Name = "colPOIntroduction"
        '
        'colPOSummary
        '
        Me.colPOSummary.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOSummary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOSummary.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOSummary.FieldName = "POSummary"
        Me.colPOSummary.Name = "colPOSummary"
        '
        'colRevisionNo
        '
        Me.colRevisionNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colRevisionNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRevisionNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRevisionNo.FieldName = "RevisionNo"
        Me.colRevisionNo.Name = "colRevisionNo"
        '
        'colCompanyBranch
        '
        Me.colCompanyBranch.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompanyBranch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompanyBranch.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompanyBranch.FieldName = "CompanyBranch"
        Me.colCompanyBranch.Name = "colCompanyBranch"
        '
        'colAdditionsText
        '
        Me.colAdditionsText.AppearanceHeader.Options.UseTextOptions = True
        Me.colAdditionsText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAdditionsText.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAdditionsText.FieldName = "AdditionsText"
        Me.colAdditionsText.Name = "colAdditionsText"
        '
        'colDiscountsText
        '
        Me.colDiscountsText.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiscountsText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiscountsText.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiscountsText.FieldName = "DiscountsText"
        Me.colDiscountsText.Name = "colDiscountsText"
        '
        'colPODueDate
        '
        Me.colPODueDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colPODueDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPODueDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPODueDate.FieldName = "PODueDate"
        Me.colPODueDate.Name = "colPODueDate"
        '
        'colPOSignatory
        '
        Me.colPOSignatory.AppearanceHeader.Options.UseTextOptions = True
        Me.colPOSignatory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPOSignatory.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPOSignatory.FieldName = "POSignatory"
        Me.colPOSignatory.Name = "colPOSignatory"
        '
        'colAdditionsAmount
        '
        Me.colAdditionsAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colAdditionsAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAdditionsAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAdditionsAmount.FieldName = "AdditionsAmount"
        Me.colAdditionsAmount.Name = "colAdditionsAmount"
        '
        'colDeductionsAmount
        '
        Me.colDeductionsAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeductionsAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeductionsAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeductionsAmount.FieldName = "DeductionsAmount"
        Me.colDeductionsAmount.Name = "colDeductionsAmount"
        '
        'colNoOfItems
        '
        Me.colNoOfItems.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoOfItems.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoOfItems.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNoOfItems.FieldName = "NoOfItems"
        Me.colNoOfItems.Name = "colNoOfItems"
        '
        'colTotalBeforeTax
        '
        Me.colTotalBeforeTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalBeforeTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalBeforeTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalBeforeTax.FieldName = "TotalBeforeTax"
        Me.colTotalBeforeTax.Name = "colTotalBeforeTax"
        '
        'colTotalDiscount
        '
        Me.colTotalDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalDiscount.FieldName = "TotalDiscount"
        Me.colTotalDiscount.Name = "colTotalDiscount"
        '
        'colTotalAfterDiscount
        '
        Me.colTotalAfterDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalAfterDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalAfterDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalAfterDiscount.FieldName = "TotalAfterDiscount"
        Me.colTotalAfterDiscount.Name = "colTotalAfterDiscount"
        '
        'colTotalTaxAmount
        '
        Me.colTotalTaxAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalTaxAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalTaxAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalTaxAmount.FieldName = "TotalTaxAmount"
        Me.colTotalTaxAmount.Name = "colTotalTaxAmount"
        '
        'colTotalWithTax
        '
        Me.colTotalWithTax.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalWithTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalWithTax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalWithTax.FieldName = "TotalWithTax"
        Me.colTotalWithTax.Name = "colTotalWithTax"
        '
        'colGrandTotal
        '
        Me.colGrandTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrandTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrandTotal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGrandTotal.FieldName = "GrandTotal"
        Me.colGrandTotal.Name = "colGrandTotal"
        '
        'colBalanceToReceive
        '
        Me.colBalanceToReceive.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalanceToReceive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalanceToReceive.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBalanceToReceive.FieldName = "BalanceToReceive"
        Me.colBalanceToReceive.Name = "colBalanceToReceive"
        '
        'colOrderStatus
        '
        Me.colOrderStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderStatus.FieldName = "OrderStatus"
        Me.colOrderStatus.Name = "colOrderStatus"
        '
        'colOrderedQty
        '
        Me.colOrderedQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderedQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderedQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderedQty.FieldName = "OrderedQty"
        Me.colOrderedQty.Name = "colOrderedQty"
        '
        'colReceivedQty
        '
        Me.colReceivedQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceivedQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceivedQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceivedQty.FieldName = "ReceivedQty"
        Me.colReceivedQty.Name = "colReceivedQty"
        '
        'colTotalOrdered
        '
        Me.colTotalOrdered.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalOrdered.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalOrdered.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalOrdered.FieldName = "TotalOrdered"
        Me.colTotalOrdered.Name = "colTotalOrdered"
        '
        'colTotalBilled
        '
        Me.colTotalBilled.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalBilled.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalBilled.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalBilled.FieldName = "TotalBilled"
        Me.colTotalBilled.Name = "colTotalBilled"
        '
        'colBalanceToBill
        '
        Me.colBalanceToBill.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalanceToBill.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalanceToBill.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBalanceToBill.FieldName = "BalanceToBill"
        Me.colBalanceToBill.Name = "colBalanceToBill"
        '
        'colBillStatus
        '
        Me.colBillStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colBillStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBillStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBillStatus.FieldName = "BillStatus"
        Me.colBillStatus.Name = "colBillStatus"
        '
        'colRFQNo
        '
        Me.colRFQNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colRFQNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRFQNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRFQNo.FieldName = "RFQNo"
        Me.colRFQNo.Name = "colRFQNo"
        '
        'colTypeOfRequest
        '
        Me.colTypeOfRequest.AppearanceHeader.Options.UseTextOptions = True
        Me.colTypeOfRequest.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTypeOfRequest.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTypeOfRequest.FieldName = "TypeOfRequest"
        Me.colTypeOfRequest.Name = "colTypeOfRequest"
        '
        'colMPRNo
        '
        Me.colMPRNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colMPRNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMPRNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMPRNo.FieldName = "MPRNo"
        Me.colMPRNo.Name = "colMPRNo"
        '
        'colProjectMasterCode
        '
        Me.colProjectMasterCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colProjectMasterCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProjectMasterCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProjectMasterCode.FieldName = "ProjectMasterCode"
        Me.colProjectMasterCode.Name = "colProjectMasterCode"
        '
        'colProjectDescription
        '
        Me.colProjectDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colProjectDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProjectDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProjectDescription.FieldName = "ProjectDescription"
        Me.colProjectDescription.Name = "colProjectDescription"
        '
        'colCurrency
        '
        Me.colCurrency.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrency.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrency.FieldName = "Currency"
        Me.colCurrency.Name = "colCurrency"
        '
        'colExchangeRate
        '
        Me.colExchangeRate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExchangeRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExchangeRate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExchangeRate.FieldName = "ExchangeRate"
        Me.colExchangeRate.Name = "colExchangeRate"
        '
        'colTotalAmountB4TaxInOC
        '
        Me.colTotalAmountB4TaxInOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalAmountB4TaxInOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalAmountB4TaxInOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalAmountB4TaxInOC.FieldName = "TotalAmountB4TaxInOC"
        Me.colTotalAmountB4TaxInOC.Name = "colTotalAmountB4TaxInOC"
        '
        'colTotalAmountAfterDiscInOC
        '
        Me.colTotalAmountAfterDiscInOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalAmountAfterDiscInOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalAmountAfterDiscInOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalAmountAfterDiscInOC.FieldName = "TotalAmountAfterDiscInOC"
        Me.colTotalAmountAfterDiscInOC.Name = "colTotalAmountAfterDiscInOC"
        '
        'colTotalTaxAmountInOC
        '
        Me.colTotalTaxAmountInOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalTaxAmountInOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalTaxAmountInOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalTaxAmountInOC.FieldName = "TotalTaxAmountInOC"
        Me.colTotalTaxAmountInOC.Name = "colTotalTaxAmountInOC"
        '
        'colTotalDiscountInOC
        '
        Me.colTotalDiscountInOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalDiscountInOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalDiscountInOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalDiscountInOC.FieldName = "TotalDiscountInOC"
        Me.colTotalDiscountInOC.Name = "colTotalDiscountInOC"
        '
        'colTotalWithTaxInOC
        '
        Me.colTotalWithTaxInOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalWithTaxInOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalWithTaxInOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalWithTaxInOC.FieldName = "TotalWithTaxInOC"
        Me.colTotalWithTaxInOC.Name = "colTotalWithTaxInOC"
        '
        'colGrandTotalInOC
        '
        Me.colGrandTotalInOC.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrandTotalInOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrandTotalInOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGrandTotalInOC.FieldName = "GrandTotalInOC"
        Me.colGrandTotalInOC.Name = "colGrandTotalInOC"
        '
        'colIsSubmitted
        '
        Me.colIsSubmitted.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsSubmitted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsSubmitted.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsSubmitted.FieldName = "IsSubmitted"
        Me.colIsSubmitted.Name = "colIsSubmitted"
        '
        'colIsVerified
        '
        Me.colIsVerified.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsVerified.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsVerified.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsVerified.FieldName = "IsVerified"
        Me.colIsVerified.Name = "colIsVerified"
        '
        'colPORevisionID
        '
        Me.colPORevisionID.AppearanceHeader.Options.UseTextOptions = True
        Me.colPORevisionID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPORevisionID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPORevisionID.FieldName = "PORevisionID"
        Me.colPORevisionID.Name = "colPORevisionID"
        Me.colPORevisionID.Width = 173
        '
        'colIsObseleteVersion
        '
        Me.colIsObseleteVersion.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsObseleteVersion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsObseleteVersion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsObseleteVersion.FieldName = "IsObseleteVersion"
        Me.colIsObseleteVersion.Name = "colIsObseleteVersion"
        Me.colIsObseleteVersion.Visible = True
        Me.colIsObseleteVersion.VisibleIndex = 6
        Me.colIsObseleteVersion.Width = 95
        '
        'colPORevisionNo
        '
        Me.colPORevisionNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPORevisionNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPORevisionNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPORevisionNo.FieldName = "PORevisionNo"
        Me.colPORevisionNo.Name = "colPORevisionNo"
        Me.colPORevisionNo.Visible = True
        Me.colPORevisionNo.VisibleIndex = 5
        Me.colPORevisionNo.Width = 146
        '
        'Qry604_04PurchaseOrderViewMasterTableAdapter
        '
        Me.Qry604_04PurchaseOrderViewMasterTableAdapter.ClearBeforeFill = True
        '
        'repoEditPO
        '
        Me.repoEditPO.AutoHeight = False
        Me.repoEditPO.Name = "repoEditPO"
        '
        'frm601_39PORevisionHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 387)
        Me.Controls.Add(Me.gcPORevisionHistory)
        Me.Name = "frm601_39PORevisionHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMS Modules: Purchase Order Revision History"
        CType(Me.gcPORevisionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60404PurchaseOrderViewMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_39PORevisionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPORevisionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoEditPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcPORevisionHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPORevisionHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Qry60404PurchaseOrderViewMasterBindingSource As BindingSource
    Friend WithEvents Dsfrm601_39PORevisionHistory As dsfrm601_39PORevisionHistory
    Friend WithEvents colPONo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPODate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierQuoteNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierQuoteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAttention As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierContactEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubjectTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreparedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreparedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOIntroduction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOSummary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevisionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdditionsText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscountsText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPODueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOSignatory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdditionsAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeductionsAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoOfItems As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalBeforeTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalAfterDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalTaxAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalWithTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrandTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalanceToReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalOrdered As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalBilled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalanceToBill As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRFQNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypeOfRequest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMPRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectMasterCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExchangeRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalAmountB4TaxInOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalAmountAfterDiscInOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalTaxAmountInOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalDiscountInOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalWithTaxInOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrandTotalInOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSubmitted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsVerified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPORevisionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsObseleteVersion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPORevisionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qry604_04PurchaseOrderViewMasterTableAdapter As dsfrm601_39PORevisionHistoryTableAdapters.qry604_04PurchaseOrderViewMasterTableAdapter
    Friend WithEvents repoEditPO As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
End Class
