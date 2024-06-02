<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm601_41MPRRevisionHistory
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
        Me.Qry60604PurchaseRequestViewMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsfrm601_41MPRRevisionHistory = New ERP.dsfrm601_41MPRRevisionHistory()
        Me.gvPORevisionHistory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMPRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoEditPO = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colMPRDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTypeOfMPR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoreCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModeOfRequestID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTypeOfRequestID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMPRRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModeOfRequest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTypeOfRequest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoreName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoOfItems = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestEnquiry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequesterContact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequesterContactEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoOfRFQIssued = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoOfQuotations = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetQuotedAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetQuotedWithTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestedNameRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurposeOfRequest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpectedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectMasterCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalRequestCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseRequestStatusID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseRequestStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBidClosingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBidReminderOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteSubmittedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoOfDaysToGo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryMasterGroupID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryMasterGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPersonCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPersonName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPersonUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreparedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreparedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSubmitted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmittedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmittedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsVerified = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVerifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVerifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequesterName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectSubUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialQuoteNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMPRRevisedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMPRRevisedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMPRRevisionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Qry606_04PurchaseRequestViewMasterTableAdapter = New ERP.dsfrm601_41MPRRevisionHistoryTableAdapters.qry606_04PurchaseRequestViewMasterTableAdapter()
        CType(Me.gcPORevisionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qry60604PurchaseRequestViewMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrm601_41MPRRevisionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPORevisionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoEditPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcPORevisionHistory
        '
        Me.gcPORevisionHistory.DataSource = Me.Qry60604PurchaseRequestViewMasterBindingSource
        Me.gcPORevisionHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPORevisionHistory.Location = New System.Drawing.Point(0, 0)
        Me.gcPORevisionHistory.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.gcPORevisionHistory.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcPORevisionHistory.MainView = Me.gvPORevisionHistory
        Me.gcPORevisionHistory.Name = "gcPORevisionHistory"
        Me.gcPORevisionHistory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoEditPO})
        Me.gcPORevisionHistory.Size = New System.Drawing.Size(935, 387)
        Me.gcPORevisionHistory.TabIndex = 74
        Me.gcPORevisionHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPORevisionHistory})
        '
        'Qry60604PurchaseRequestViewMasterBindingSource
        '
        Me.Qry60604PurchaseRequestViewMasterBindingSource.DataMember = "qry606_04PurchaseRequestViewMaster"
        Me.Qry60604PurchaseRequestViewMasterBindingSource.DataSource = Me.Dsfrm601_41MPRRevisionHistory
        '
        'Dsfrm601_41MPRRevisionHistory
        '
        Me.Dsfrm601_41MPRRevisionHistory.DataSetName = "dsfrm601_41MPRRevisionHistory"
        Me.Dsfrm601_41MPRRevisionHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvPORevisionHistory
        '
        Me.gvPORevisionHistory.ColumnPanelRowHeight = 40
        Me.gvPORevisionHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMPRNo, Me.colMPRDate, Me.colTypeOfMPR, Me.colClientCode, Me.colStoreCode, Me.colModeOfRequestID, Me.colTypeOfRequestID, Me.colMPRRemarks, Me.colModeOfRequest, Me.colTypeOfRequest, Me.colClientName, Me.colClientCategory, Me.colStoreName, Me.colNoOfItems, Me.colRequestEnquiry, Me.colCompanyName, Me.colRequestedBy, Me.colRequesterContact, Me.colRequesterContactEmail, Me.colProject, Me.colNoOfRFQIssued, Me.colNoOfQuotations, Me.colNetQuotedAmount, Me.colNetQuotedWithTax, Me.colDepartmentCode, Me.colDepartment, Me.colClientRefNo, Me.colRequestedNameRef, Me.colPurposeOfRequest, Me.colPriority, Me.colExpectedDate, Me.colRemarks, Me.colProjectMasterCode, Me.colProjectDescription, Me.colTotalRequestCost, Me.colSalesOrderNo, Me.colOrderStatus, Me.colInvoiceStatus, Me.colPurchaseRequestStatusID, Me.colPurchaseRequestStatus, Me.colBidClosingDate, Me.colBidReminderOn, Me.colQuoteSubmittedOn, Me.colComments, Me.colNoOfDaysToGo, Me.colInventoryMasterGroupID, Me.colInventoryMasterGroup, Me.colSalesPersonCode, Me.colSalesPersonName, Me.colSalesPersonUserID, Me.colPreparedBy, Me.colPreparedOn, Me.colIsApproved, Me.colApprovedBy, Me.colApprovedOn, Me.colAddedBy, Me.colAddedOn, Me.colModifiedBy, Me.colModifiedOn, Me.colIsSubmitted, Me.colSubmittedBy, Me.colSubmittedOn, Me.colIsVerified, Me.colVerifiedBy, Me.colVerifiedOn, Me.colRequesterName, Me.colProjectSubUnitName, Me.colMaterialQuoteNo, Me.colMPRRevisedBy, Me.colMPRRevisedOn, Me.colMPRRevisionNo})
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
        'colMPRNo
        '
        Me.colMPRNo.ColumnEdit = Me.repoEditPO
        Me.colMPRNo.FieldName = "MPRNo"
        Me.colMPRNo.Name = "colMPRNo"
        Me.colMPRNo.Visible = True
        Me.colMPRNo.VisibleIndex = 1
        Me.colMPRNo.Width = 173
        '
        'repoEditPO
        '
        Me.repoEditPO.AutoHeight = False
        Me.repoEditPO.Name = "repoEditPO"
        '
        'colMPRDate
        '
        Me.colMPRDate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colMPRDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colMPRDate.FieldName = "MPRDate"
        Me.colMPRDate.Name = "colMPRDate"
        Me.colMPRDate.Visible = True
        Me.colMPRDate.VisibleIndex = 2
        Me.colMPRDate.Width = 77
        '
        'colTypeOfMPR
        '
        Me.colTypeOfMPR.FieldName = "TypeOfMPR"
        Me.colTypeOfMPR.Name = "colTypeOfMPR"
        '
        'colClientCode
        '
        Me.colClientCode.FieldName = "ClientCode"
        Me.colClientCode.Name = "colClientCode"
        '
        'colStoreCode
        '
        Me.colStoreCode.FieldName = "StoreCode"
        Me.colStoreCode.Name = "colStoreCode"
        '
        'colModeOfRequestID
        '
        Me.colModeOfRequestID.FieldName = "ModeOfRequestID"
        Me.colModeOfRequestID.Name = "colModeOfRequestID"
        '
        'colTypeOfRequestID
        '
        Me.colTypeOfRequestID.FieldName = "TypeOfRequestID"
        Me.colTypeOfRequestID.Name = "colTypeOfRequestID"
        '
        'colMPRRemarks
        '
        Me.colMPRRemarks.FieldName = "MPRRemarks"
        Me.colMPRRemarks.Name = "colMPRRemarks"
        '
        'colModeOfRequest
        '
        Me.colModeOfRequest.FieldName = "ModeOfRequest"
        Me.colModeOfRequest.Name = "colModeOfRequest"
        '
        'colTypeOfRequest
        '
        Me.colTypeOfRequest.FieldName = "TypeOfRequest"
        Me.colTypeOfRequest.Name = "colTypeOfRequest"
        Me.colTypeOfRequest.Visible = True
        Me.colTypeOfRequest.VisibleIndex = 7
        Me.colTypeOfRequest.Width = 135
        '
        'colClientName
        '
        Me.colClientName.FieldName = "ClientName"
        Me.colClientName.Name = "colClientName"
        '
        'colClientCategory
        '
        Me.colClientCategory.FieldName = "ClientCategory"
        Me.colClientCategory.Name = "colClientCategory"
        '
        'colStoreName
        '
        Me.colStoreName.FieldName = "StoreName"
        Me.colStoreName.Name = "colStoreName"
        '
        'colNoOfItems
        '
        Me.colNoOfItems.FieldName = "NoOfItems"
        Me.colNoOfItems.Name = "colNoOfItems"
        '
        'colRequestEnquiry
        '
        Me.colRequestEnquiry.FieldName = "RequestEnquiry"
        Me.colRequestEnquiry.Name = "colRequestEnquiry"
        Me.colRequestEnquiry.Visible = True
        Me.colRequestEnquiry.VisibleIndex = 6
        Me.colRequestEnquiry.Width = 98
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        '
        'colRequestedBy
        '
        Me.colRequestedBy.FieldName = "RequestedBy"
        Me.colRequestedBy.Name = "colRequestedBy"
        '
        'colRequesterContact
        '
        Me.colRequesterContact.FieldName = "RequesterContact"
        Me.colRequesterContact.Name = "colRequesterContact"
        '
        'colRequesterContactEmail
        '
        Me.colRequesterContactEmail.FieldName = "RequesterContactEmail"
        Me.colRequesterContactEmail.Name = "colRequesterContactEmail"
        '
        'colProject
        '
        Me.colProject.FieldName = "Project"
        Me.colProject.Name = "colProject"
        '
        'colNoOfRFQIssued
        '
        Me.colNoOfRFQIssued.FieldName = "NoOfRFQIssued"
        Me.colNoOfRFQIssued.Name = "colNoOfRFQIssued"
        '
        'colNoOfQuotations
        '
        Me.colNoOfQuotations.FieldName = "NoOfQuotations"
        Me.colNoOfQuotations.Name = "colNoOfQuotations"
        '
        'colNetQuotedAmount
        '
        Me.colNetQuotedAmount.FieldName = "NetQuotedAmount"
        Me.colNetQuotedAmount.Name = "colNetQuotedAmount"
        '
        'colNetQuotedWithTax
        '
        Me.colNetQuotedWithTax.FieldName = "NetQuotedWithTax"
        Me.colNetQuotedWithTax.Name = "colNetQuotedWithTax"
        '
        'colDepartmentCode
        '
        Me.colDepartmentCode.FieldName = "DepartmentCode"
        Me.colDepartmentCode.Name = "colDepartmentCode"
        '
        'colDepartment
        '
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        '
        'colClientRefNo
        '
        Me.colClientRefNo.FieldName = "ClientRefNo"
        Me.colClientRefNo.Name = "colClientRefNo"
        '
        'colRequestedNameRef
        '
        Me.colRequestedNameRef.FieldName = "RequestedNameRef"
        Me.colRequestedNameRef.Name = "colRequestedNameRef"
        Me.colRequestedNameRef.Visible = True
        Me.colRequestedNameRef.VisibleIndex = 5
        Me.colRequestedNameRef.Width = 154
        '
        'colPurposeOfRequest
        '
        Me.colPurposeOfRequest.FieldName = "PurposeOfRequest"
        Me.colPurposeOfRequest.Name = "colPurposeOfRequest"
        '
        'colPriority
        '
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.Name = "colPriority"
        '
        'colExpectedDate
        '
        Me.colExpectedDate.FieldName = "ExpectedDate"
        Me.colExpectedDate.Name = "colExpectedDate"
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Width = 97
        '
        'colProjectMasterCode
        '
        Me.colProjectMasterCode.FieldName = "ProjectMasterCode"
        Me.colProjectMasterCode.Name = "colProjectMasterCode"
        '
        'colProjectDescription
        '
        Me.colProjectDescription.FieldName = "ProjectDescription"
        Me.colProjectDescription.Name = "colProjectDescription"
        '
        'colTotalRequestCost
        '
        Me.colTotalRequestCost.FieldName = "TotalRequestCost"
        Me.colTotalRequestCost.Name = "colTotalRequestCost"
        '
        'colSalesOrderNo
        '
        Me.colSalesOrderNo.FieldName = "SalesOrderNo"
        Me.colSalesOrderNo.Name = "colSalesOrderNo"
        '
        'colOrderStatus
        '
        Me.colOrderStatus.FieldName = "OrderStatus"
        Me.colOrderStatus.Name = "colOrderStatus"
        '
        'colInvoiceStatus
        '
        Me.colInvoiceStatus.FieldName = "InvoiceStatus"
        Me.colInvoiceStatus.Name = "colInvoiceStatus"
        '
        'colPurchaseRequestStatusID
        '
        Me.colPurchaseRequestStatusID.FieldName = "PurchaseRequestStatusID"
        Me.colPurchaseRequestStatusID.Name = "colPurchaseRequestStatusID"
        '
        'colPurchaseRequestStatus
        '
        Me.colPurchaseRequestStatus.FieldName = "PurchaseRequestStatus"
        Me.colPurchaseRequestStatus.Name = "colPurchaseRequestStatus"
        '
        'colBidClosingDate
        '
        Me.colBidClosingDate.FieldName = "BidClosingDate"
        Me.colBidClosingDate.Name = "colBidClosingDate"
        '
        'colBidReminderOn
        '
        Me.colBidReminderOn.FieldName = "BidReminderOn"
        Me.colBidReminderOn.Name = "colBidReminderOn"
        '
        'colQuoteSubmittedOn
        '
        Me.colQuoteSubmittedOn.FieldName = "QuoteSubmittedOn"
        Me.colQuoteSubmittedOn.Name = "colQuoteSubmittedOn"
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        '
        'colNoOfDaysToGo
        '
        Me.colNoOfDaysToGo.FieldName = "NoOfDaysToGo"
        Me.colNoOfDaysToGo.Name = "colNoOfDaysToGo"
        '
        'colInventoryMasterGroupID
        '
        Me.colInventoryMasterGroupID.FieldName = "InventoryMasterGroupID"
        Me.colInventoryMasterGroupID.Name = "colInventoryMasterGroupID"
        '
        'colInventoryMasterGroup
        '
        Me.colInventoryMasterGroup.FieldName = "InventoryMasterGroup"
        Me.colInventoryMasterGroup.Name = "colInventoryMasterGroup"
        '
        'colSalesPersonCode
        '
        Me.colSalesPersonCode.FieldName = "SalesPersonCode"
        Me.colSalesPersonCode.Name = "colSalesPersonCode"
        '
        'colSalesPersonName
        '
        Me.colSalesPersonName.FieldName = "SalesPersonName"
        Me.colSalesPersonName.Name = "colSalesPersonName"
        '
        'colSalesPersonUserID
        '
        Me.colSalesPersonUserID.FieldName = "SalesPersonUserID"
        Me.colSalesPersonUserID.Name = "colSalesPersonUserID"
        '
        'colPreparedBy
        '
        Me.colPreparedBy.FieldName = "PreparedBy"
        Me.colPreparedBy.Name = "colPreparedBy"
        '
        'colPreparedOn
        '
        Me.colPreparedOn.FieldName = "PreparedOn"
        Me.colPreparedOn.Name = "colPreparedOn"
        '
        'colIsApproved
        '
        Me.colIsApproved.FieldName = "IsApproved"
        Me.colIsApproved.Name = "colIsApproved"
        '
        'colApprovedBy
        '
        Me.colApprovedBy.FieldName = "ApprovedBy"
        Me.colApprovedBy.Name = "colApprovedBy"
        '
        'colApprovedOn
        '
        Me.colApprovedOn.FieldName = "ApprovedOn"
        Me.colApprovedOn.Name = "colApprovedOn"
        '
        'colAddedBy
        '
        Me.colAddedBy.FieldName = "AddedBy"
        Me.colAddedBy.Name = "colAddedBy"
        '
        'colAddedOn
        '
        Me.colAddedOn.FieldName = "AddedOn"
        Me.colAddedOn.Name = "colAddedOn"
        '
        'colModifiedBy
        '
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        '
        'colModifiedOn
        '
        Me.colModifiedOn.FieldName = "ModifiedOn"
        Me.colModifiedOn.Name = "colModifiedOn"
        '
        'colIsSubmitted
        '
        Me.colIsSubmitted.FieldName = "IsSubmitted"
        Me.colIsSubmitted.Name = "colIsSubmitted"
        '
        'colSubmittedBy
        '
        Me.colSubmittedBy.FieldName = "SubmittedBy"
        Me.colSubmittedBy.Name = "colSubmittedBy"
        '
        'colSubmittedOn
        '
        Me.colSubmittedOn.FieldName = "SubmittedOn"
        Me.colSubmittedOn.Name = "colSubmittedOn"
        '
        'colIsVerified
        '
        Me.colIsVerified.FieldName = "IsVerified"
        Me.colIsVerified.Name = "colIsVerified"
        '
        'colVerifiedBy
        '
        Me.colVerifiedBy.FieldName = "VerifiedBy"
        Me.colVerifiedBy.Name = "colVerifiedBy"
        '
        'colVerifiedOn
        '
        Me.colVerifiedOn.FieldName = "VerifiedOn"
        Me.colVerifiedOn.Name = "colVerifiedOn"
        '
        'colRequesterName
        '
        Me.colRequesterName.FieldName = "RequesterName"
        Me.colRequesterName.Name = "colRequesterName"
        Me.colRequesterName.Width = 98
        '
        'colProjectSubUnitName
        '
        Me.colProjectSubUnitName.FieldName = "ProjectSubUnitName"
        Me.colProjectSubUnitName.Name = "colProjectSubUnitName"
        '
        'colMaterialQuoteNo
        '
        Me.colMaterialQuoteNo.FieldName = "MaterialQuoteNo"
        Me.colMaterialQuoteNo.Name = "colMaterialQuoteNo"
        '
        'colMPRRevisedBy
        '
        Me.colMPRRevisedBy.FieldName = "MPRRevisedBy"
        Me.colMPRRevisedBy.Name = "colMPRRevisedBy"
        Me.colMPRRevisedBy.Visible = True
        Me.colMPRRevisedBy.VisibleIndex = 3
        Me.colMPRRevisedBy.Width = 116
        '
        'colMPRRevisedOn
        '
        Me.colMPRRevisedOn.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colMPRRevisedOn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMPRRevisedOn.FieldName = "MPRRevisedOn"
        Me.colMPRRevisedOn.Name = "colMPRRevisedOn"
        Me.colMPRRevisedOn.Visible = True
        Me.colMPRRevisedOn.VisibleIndex = 4
        Me.colMPRRevisedOn.Width = 82
        '
        'colMPRRevisionNo
        '
        Me.colMPRRevisionNo.Caption = "Rev.No"
        Me.colMPRRevisionNo.FieldName = "MPRRevisionNo"
        Me.colMPRRevisionNo.Name = "colMPRRevisionNo"
        Me.colMPRRevisionNo.Width = 67
        '
        'Qry606_04PurchaseRequestViewMasterTableAdapter
        '
        Me.Qry606_04PurchaseRequestViewMasterTableAdapter.ClearBeforeFill = True
        '
        'frm601_41MPRRevisionHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 387)
        Me.Controls.Add(Me.gcPORevisionHistory)
        Me.Name = "frm601_41MPRRevisionHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMS Modules: Material Request Revision History"
        CType(Me.gcPORevisionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qry60604PurchaseRequestViewMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrm601_41MPRRevisionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPORevisionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoEditPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcPORevisionHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPORevisionHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents repoEditPO As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents Qry60604PurchaseRequestViewMasterBindingSource As BindingSource
    Friend WithEvents Dsfrm601_41MPRRevisionHistory As dsfrm601_41MPRRevisionHistory
    Friend WithEvents colMPRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMPRDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypeOfMPR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoreCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModeOfRequestID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypeOfRequestID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMPRRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModeOfRequest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypeOfRequest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoreName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoOfItems As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestEnquiry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequesterContact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequesterContactEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoOfRFQIssued As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoOfQuotations As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetQuotedAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetQuotedWithTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestedNameRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurposeOfRequest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpectedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectMasterCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalRequestCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseRequestStatusID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseRequestStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBidClosingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBidReminderOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteSubmittedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoOfDaysToGo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryMasterGroupID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryMasterGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPersonCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPersonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPersonUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreparedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreparedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSubmitted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmittedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmittedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsVerified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVerifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVerifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequesterName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectSubUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialQuoteNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qry606_04PurchaseRequestViewMasterTableAdapter As dsfrm601_41MPRRevisionHistoryTableAdapters.qry606_04PurchaseRequestViewMasterTableAdapter
    Friend WithEvents colMPRRevisedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMPRRevisedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMPRRevisionNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
