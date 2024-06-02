Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Drawing
Imports System.Text

Imports System.Drawing
Imports DevExpress.XtraBars

Public Class frm601_05DeliveryNoteEdit
    Public isBeingUpdated As Boolean = False
    Public isBeingNew As Boolean = False
    Public isControlsModified As Boolean

    Public ObjForm As Object
    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer


    Dim SelectedDeliveryNoteChildSlNo As Integer
    Public CreatedNewDeliveryNoteNo As String

    Public isExecutedFrom_frm601_06DeliveryNoteView As Boolean = False
    Public isExecutedFrom_frm601_04SalesOrderView As Boolean = False
    Public isExecutedFrom_frm601_28JobOrdersView As Boolean = False
    Public isExecutedFrom_frm700_01ProjectsEdit As Boolean = False
    Public isExecutedFrom_frm601_14DeliveryDetails As Boolean = False
    Public isExecutedFrom_frm601_12PurchaseRequestView As Boolean = False

    Public isExecutedFrom_frm601_04A_SalesOrderStoreAvailability As Boolean = False


    Public isExecutedFrom_frm600_01InventoryStockEdit As Boolean = False

#Region "Ordering Code"

    Private Const OrderFieldName As String = "LineOrderNo"

    Private downHitInfo As GridHitInfo = Nothing

    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Dim view As GridView = gvInvoiceChild
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        If index <= 0 Then
            Return
        End If

        Dim row1 As DataRow = view.GetDataRow(index)
        Dim row2 As DataRow = view.GetDataRow(index - 1)
        Dim val1 As Object = row1(OrderFieldName)
        Dim val2 As Object = row2(OrderFieldName)
        row1(OrderFieldName) = val2
        row2(OrderFieldName) = val1

        view.FocusedRowHandle = index - 1
    End Sub

    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick
        Dim view As GridView = gvInvoiceChild
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        If index >= view.DataRowCount - 1 Then
            Return
        End If

        Dim row1 As DataRow = view.GetDataRow(index)
        Dim row2 As DataRow = view.GetDataRow(index + 1)
        Dim val1 As Object = row1(OrderFieldName)
        Dim val2 As Object = row2(OrderFieldName)
        row1(OrderFieldName) = val2
        row2(OrderFieldName) = val1

        view.FocusedRowHandle = index + 1
    End Sub

#End Region

    Private Sub frm601_01QuotationEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm601_05DeliveryNoteEdit.tbl40101PropertyMaster' table. You can move, or remove it, as needed.
        Me.Tbl40101PropertyMasterTableAdapter.Fill(Me.Dsfrm601_05DeliveryNoteEdit.tbl40101PropertyMaster)

        Me.Tbl101EmployeesTableAdapter.Fill(Me.Dsfrm601_05DeliveryNoteEdit.tbl101Employees)
        Me.Tbl600_08InventoryMasterGroupTableAdapter.Fill(Me.Dsfrm601_05DeliveryNoteEdit.tbl600_08InventoryMasterGroup)

        Me.Tbl603_03DeliveryTypeTableAdapter.Fill(Me.Dsfrm601_05DeliveryNoteEdit1.tbl603_03DeliveryType)
        Me.Tbl600_01StoreMasterTableAdapter.Fill(Me.Dsfrm601_05DeliveryNoteEdit.tbl600_01StoreMaster)
        Me.Tbl40111PropertyUnitCodesTableAdapter1.Fill(Me.Dsfrm20161VATInvoiceEdit.tbl40111PropertyUnitCodes)

        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.tbl40111PropertyUnitCodes)
        Me.Tbl901CompanyDetailsTableAdapter.Fill(Me.Dsfrm20161VATInvoiceEdit.tbl901CompanyDetails)
        Me.Tbl90104DocumentSignatoriesTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl90104DocumentSignatories)
        Me.Tbl20101SalesPersonMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl20101SalesPersonMaster)
        Me.Tbl30101ClientMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl30101ClientMaster)

        Me.Qry700_02ProjectsViewMasterTableAdapter.Fill(Me.Dsfrm601_05DeliveryNoteEdit2.qry700_02ProjectsViewMaster)

        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl20164GoodsAndServicesMasterTableAdapter1.Fill(Me.Dsfrm20161VATInvoiceEdit.tbl20164GoodsAndServicesMaster)
        Else
            Me.Tbl20164GoodsAndServicesMasterTableAdapter1.FillByGroup(Me.Dsfrm20161VATInvoiceEdit.tbl20164GoodsAndServicesMaster, Me.intLogOnInventoryAccessLevel)
        End If



        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit", Me.gvInvoiceChild)

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_GSList", Me.gvGSList)


        GetCompanyDetails02(1)
        If gIsShowFixedCostPrice = True Then
            Me.colIssuedUnitPrice.Visible = False

        End If

        'Populate Custom Reports Tab
        Me.PopulateCustomReportButtons(Me.CustomReportFormNo)

        Me.ImplementAccess(Me.intLogOnUserID)





        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colIssuedUnitPrice.DisplayFormat.FormatString = "{0:###,###,##0.000}"
            colIssuedQuoteUnitPrice.DisplayFormat.FormatString = "{0:###,###,##0.000}"

        End If
    End Sub

    Public Sub ImplementAccess(ByVal UserID As Integer)
        If GetUserAccess(UserID, "frm601_05DeliveryNoteEdit_FullAccess") = True Then

            Me.btnResetLayout.Enabled = True
            Me.btnSetDefaultLayout.Enabled = True
            Me.btnMoveUp.Enabled = True
            Me.btnMoveDown.Enabled = True
            Me.btnSave.Enabled = True
            Me.btnSaveAndClose.Enabled = True
            Me.btnPreviewDeliveryNote.Enabled = True
            Me.btnPreviewDeliveryNoteDotMat.Enabled = True
            Me.btnPreviewMRN.Enabled = True
            Me.barSubItemCustomReportDesigns.Enabled = True

            Me.btnDelete.Enabled = True
            Me.btnAddNewLineItem.Enabled = True
            Me.btnBack.Enabled = True
            Me.btnAttachments.Enabled = True
            Me.btnApprove.Enabled = True
            Me.btnPostToBooks.Enabled = True
            Me.btnReceipts.Enabled = True
            Me.btnVerify.Enabled = True

            Me.btnLineItem.Enabled = True

            Me.txtSalesPerson.Properties.Buttons.Item(1).Enabled = True
            Me.txtStoreIssuedFrom.Properties.Buttons.Item(1).Enabled = True
            Me.txtInventoryStore.Properties.Buttons.Item(1).Enabled = True

            Me.txtIssuedToProject.Properties.Buttons.Item(1).Enabled = True

            Me.txtClientName.Properties.Buttons.Item(2).Enabled = True
            Me.txtClientName.Properties.Buttons.Item(1).Enabled = True

            Me.cmdEditContacts.Enabled = True

            Me.txtSignatory.Properties.Buttons.Item(1).Enabled = True

            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = True

        Else

            Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnResetLayout")
            Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnSetDefaultLayout")
            Me.btnMoveUp.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnMoveUp")
            Me.btnMoveDown.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnMoveDown")
            Me.btnSave.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnSave")
            Me.btnSaveAndClose.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnSaveAndClose")

            Me.btnPreviewDeliveryNote.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnPreviewDeliveryNote")
            Me.btnPreviewDeliveryNoteDotMat.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnPreviewDeliveryNote")
            Me.btnPreviewMRN.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnPreviewDeliveryNote")
            Me.barSubItemCustomReportDesigns.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnPreviewDeliveryNote")

            Me.btnDelete.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnDelete")
            Me.btnAddNewLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnAddNewLineItem")
            Me.btnBack.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnBack")
            Me.btnAttachments.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnAttachments")
            Me.btnApprove.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnApprove")
            Me.btnPostToBooks.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnPostToBooks")
            Me.btnReceipts.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnReceipts")
            Me.btnVerify.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnVerify")
            Me.btnLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_btnLineItem")

            Me.txtSalesPerson.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddSalesPerson")
            Me.txtStoreIssuedFrom.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddStores")
            Me.txtInventoryStore.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddStores")

            Me.txtIssuedToProject.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddProjects")

            Me.txtClientName.Properties.Buttons.Item(2).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddClient")
            Me.txtClientName.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddClient")

            Me.cmdEditContacts.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddClient")

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then

                    Me.txtSignatory.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddSignatory")

                    Exit For
                End If
            Next

            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddStockItem")
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddStockItem")
            Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_AddStockItem")

            Me.colIssuedUnitPrice.Visible = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_CostPrice_Visible")
            Me.colIssuedUnitPrice.OptionsColumn.AllowShowHide = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_CostPrice_Visible")

            Me.colIssuedQuoteUnitPrice.OptionsColumn.AllowEdit = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_EditQuotePrice")
            Me.colIssuedQuoteUnitPrice.OptionsColumn.AllowFocus = GetUserAccess(Me.intLogOnUserID, "frm601_05DeliveryNoteEdit_EditQuotePrice")

        End If
    End Sub

    Public selectedDeliveryType As Integer = 1

    Public Sub UpdateDefaultFields()
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                If Me.intLogOnDivision = 99 Then
                    Me.txtCompanyID.EditValue = 1
                Else
                    Me.txtCompanyID.EditValue = Me.intLogOnDivision
                End If

                Me.txtDeliveryType.EditValue = Me.selectedDeliveryType

                'Enable/Disable CostDetails
                GetCompanyDetails(Me.txtCompanyID.EditValue)
                If gIsExpiryItems = True Then
                    Me.colIssuedUnitPrice.OptionsColumn.AllowEdit = False
                    Me.colIssuedUnitPrice.OptionsColumn.AllowFocus = False
                End If

                If Me.intLogOnInventoryAccessLevel = 99 Then
                    Me.txtInventoryGroupMaster.EditValue = 1
                    Me.txtInventoryGroupMaster.Enabled = True

                Else
                    Me.txtInventoryGroupMaster.EditValue = Me.intLogOnInventoryAccessLevel
                    Me.txtInventoryGroupMaster.Enabled = False
                End If

                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageQuoteDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)

                'Get SalesPerson Code and fill it.
                'If the User Account can create Other SalesPerson Quotes then enable SalesPerson Field.. else disable it.
                Dim SalesPersonCode As String = ""
                SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

                Try
                    If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                        If SalesPersonCode = 0 OrElse SalesPersonCode = "" Then
                            Me.txtSalesPerson.Enabled = True
                        Else
                            Me.txtSalesPerson.EditValue = GetSalesPersonCode(Me.intLogOnUserID)
                            Me.txtSalesPerson.Enabled = True
                        End If
                    Else
                        Me.txtSalesPerson.EditValue = GetSalesPersonCode(Me.intLogOnUserID)
                        Me.txtSalesPerson.Enabled = False
                    End If

                Catch ex As Exception

                End Try

            End If
        Next




    End Sub

    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtDeliveryNoteNo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtDeliveryNoteNo, "Quotation Number Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtDeliveryNoteNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtDeliveryNoteDate.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtDeliveryNoteDate, "Quotation Date must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtDeliveryNoteDate, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)

                If Me.txtDeliveryType.EditValue = 1 Then
                    If String.IsNullOrEmpty(ConvertIfNull(Me.txtClientName.EditValue)) Then
                        Me.DxErrorProvider1.SetError(Me.txtClientName, "Client must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    Else
                        Me.DxErrorProvider1.SetError(Me.txtClientName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    End If

                ElseIf Me.txtDeliveryType.EditValue = 2 Then

                    If String.IsNullOrEmpty(ConvertIfNull(Me.txtInventoryStore.EditValue)) Then
                        Me.DxErrorProvider1.SetError(Me.txtInventoryStore, "Inventory Store must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    Else
                        Me.DxErrorProvider1.SetError(Me.txtInventoryStore, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    End If

                ElseIf Me.txtDeliveryType.EditValue = 3 Then

                    If String.IsNullOrEmpty(ConvertIfNull(Me.txtIssuedToProject.EditValue)) Then
                        Me.DxErrorProvider1.SetError(Me.txtIssuedToProject, "Project Store must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    Else
                        Me.DxErrorProvider1.SetError(Me.txtIssuedToProject, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    End If
                End If

                Exit For
            End If
        Next




    End Sub

    Public Sub RetrieveDeliveryMaster(ByVal DeliveryNoteNo As String)
        Try
            If CheckIfNull(DeliveryNoteNo) = False Then
                'fill master details
                Me.Tbl603_01DeliveryNoteMasterTableAdapter.FillByDeliveryNoteNo(Me.Dsfrm601_01QuotationEdit1.tbl603_01DeliveryNoteMaster, DeliveryNoteNo)

                'fill child details in the datagrid
                Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, DeliveryNoteNo)



            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Delivery Note Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateDeliveryNoteMaster(ByVal QuotationNo As String, ByVal WithMessage As Boolean)
        If CheckIfNull(QuotationNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60301DeliveryNoteMasterBindingSource.Current, DataRowView)
            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            Me.Tbl60301DeliveryNoteMasterBindingSource.EndEdit()
            Me.Tbl603_01DeliveryNoteMasterTableAdapter.Update(Me.Dsfrm601_01QuotationEdit1.tbl603_01DeliveryNoteMaster)

            If WithMessage = True Then
                MessageBox.Show("Delivery Note Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SaveNewDeliveryNoteMaster(ByVal QuotationNo As String)
        If CheckIfNull(QuotationNo) = False Then
            If isBeingNew = True Then
                Dim view As DataRowView = DirectCast(Me.Tbl60301DeliveryNoteMasterBindingSource.Current, DataRowView)
                view.Row("AddedBy") = Me.strLogonUser
                view.Row("AddedOn") = Date.Now
                Me.Validate()

                Me.Tbl60301DeliveryNoteMasterBindingSource.EndEdit()
                Me.Tbl603_01DeliveryNoteMasterTableAdapter.Update(Me.Dsfrm601_01QuotationEdit1.tbl603_01DeliveryNoteMaster)
            End If
        End If
    End Sub

    Private Sub btnSaveAndClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
        cmdSave_Click(sender, e)
        Me.Close()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick
        SaveAll(True)
    End Sub

    Private Sub SaveAll(ByVal WithMessage As Boolean)
        CheckMasterErrors()
        If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
            MessageBox.Show("Cannot continue saving with errors, please clear the errors and continue.", "Clear Errors", MessageBoxButtons.OK)
            Exit Sub

        End If

        If Me.btnSave.Caption = "Update" Then
            UpdateDeliveryNoteMaster(Me.txtDeliveryNoteNo.EditValue, WithMessage)
            Me.btnSave.Caption = "Update"

        ElseIf Me.btnSave.Caption = "Save" Then
            If Me.isBeingNew = True Then
                SaveNewDeliveryNoteMaster(Me.txtDeliveryNoteNo.EditValue)
                Me.btnSave.Caption = "Update"
            End If
        End If

        Try

            'Update the Data in the Child
            Me.Qry60302DeliveryNoteChildBindingSource1.EndEdit()
            Me.Qry603_02DeliveryNoteChildTableAdapter1.Update(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild)
            Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, Me.txtDeliveryNoteNo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshMasterDataGrid()
    End Sub

    Private Sub RefreshMasterDataGrid()
        If isExecutedFrom_frm601_06DeliveryNoteView = True Then
            Try
                CType(ObjForm, frm601_06DeliveryNoteView).RetrieveVoucher(CType(ObjForm, frm601_06DeliveryNoteView).txtStartDate.EditValue, CType(ObjForm, frm601_06DeliveryNoteView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_06DeliveryNoteView).gvAdvBandedQuotationView, "DeliveryNoteNo", Me.txtDeliveryNoteNo.EditValue)
            Catch ex As Exception
                'MessageBox.Show("Error Occured while Refreshing the Delivery Note Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        If isExecutedFrom_frm601_04SalesOrderView = True Then
            Try
                CType(ObjForm, frm601_04SalesOrderView).RetrieveVoucher(CType(ObjForm, frm601_04SalesOrderView).txtStartDate.EditValue, CType(ObjForm, frm601_04SalesOrderView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_04SalesOrderView).gvAdvBandedQuotationView, "SalesOrderNo", Me.txtSalesOrderNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Sales Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        'isExecutedFrom_frm601_28JobOrdersView
        If isExecutedFrom_frm601_28JobOrdersView = True Then
            Try
                CType(ObjForm, frm601_28JobOrdersView).RetrieveVoucher(CType(ObjForm, frm601_28JobOrdersView).txtStartDate.EditValue, CType(ObjForm, frm601_28JobOrdersView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_28JobOrdersView).gvAdvBandedQuotationView, "JobOrderNo", Me.txtSalesOrderNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Job Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If isExecutedFrom_frm700_01ProjectsEdit = True Then
            Try
                CType(ObjForm, frm700_01ProjectsEdit).Qry700_06ProjectMaterialDeliveryTableAdapter.FillByProjectMasterCode(CType(ObjForm, frm700_01ProjectsEdit).Dsfrm700_01ProjectsEdit6.qry700_06ProjectMaterialDelivery, Me.txtIssuedToProject.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Projects Delivery List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        '
        If isExecutedFrom_frm601_14DeliveryDetails = True Then
            Try
                CType(ObjForm, frm601_14DeliveryDetails).Qry603_06DeliveryNoteDetailsTableAdapter.FillByDate(CType(ObjForm, frm601_14DeliveryDetails).Dsfrm601_19DeliveryDetails.qry603_06DeliveryNoteDetails, CType(ObjForm, frm601_14DeliveryDetails).txtStartDate.EditValue, CType(ObjForm, frm601_14DeliveryDetails).txtEndDate.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Delivery Details." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If isExecutedFrom_frm600_01InventoryStockEdit = True Then
            Try
                'Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit4.qry603_06DeliveryNoteDetails, StockCode)

                CType(ObjForm, frm600_01InventoryStockEdit).Qry603_06DeliveryNoteDetailsTableAdapter.FillByGSCode(CType(ObjForm, frm600_01InventoryStockEdit).Dsfrm600_01InventoryStockEdit4.qry603_06DeliveryNoteDetails, CType(ObjForm, frm600_01InventoryStockEdit).txtStockCode.EditValue)

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Delivery Details." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        'isExecutedFrom_frm601_12PurchaseRequestView
        If isExecutedFrom_frm601_12PurchaseRequestView = True Then
            Try

                CType(ObjForm, frm601_12PurchaseRequestView).RetrieveVoucher(CType(ObjForm, frm601_12PurchaseRequestView).txtStartDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).txtEndDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).SelectedRequestedType)

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Delivery Details." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        'isExecutedFrom_frm601_04A_SalesOrderStoreAvailability
        If isExecutedFrom_frm601_04A_SalesOrderStoreAvailability = True Then
            Try

                CType(ObjForm, frm601_04A_SalesOrderStoreAvailability).RetrieveVoucher(CType(ObjForm, frm601_04A_SalesOrderStoreAvailability).SalesOrderNo)
                'Me.Qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter.Fill(Me.Dsfrm601_04A_SalesOrderStoreAvailability2.qry653_20StoreStockAvaliabilityForSalesOrder1, SalesOrderNo, Me.txtStoreCode.EditValue)
                CType(ObjForm, frm601_04A_SalesOrderStoreAvailability).Qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter.Fill(CType(ObjForm, frm601_04A_SalesOrderStoreAvailability).Dsfrm601_04A_SalesOrderStoreAvailability2.qry653_20StoreStockAvaliabilityForSalesOrder1, CType(ObjForm, frm601_04A_SalesOrderStoreAvailability).SalesOrderNo, CType(ObjForm, frm601_04A_SalesOrderStoreAvailability).txtStoreCode.EditValue)


            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Sales Order Details." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.ItemClick
        If isControlsModified = True Then
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("Delivery Note Details have been edited, would you like to save changes?", "Save Changes?", MessageBoxButtons.YesNoCancel)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then

                cmdSave_Click(sender, e)
                Me.Close()

            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Me.Close()
            ElseIf DialogResult = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

        ElseIf isBeingUpdated = False Then
            Me.Close()
        End If
    End Sub

    Public Function GetNewDeliveryNoteNo(ByVal DeliveryNoteAbbr As String, ByVal YearInDigit As Integer, ByVal NoOfDigits As Integer, ByVal DeliveryDate As Date, ByVal IsResetByYear As Boolean) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1

            If IsResetByYear = True Then
                SqlCommand1.CommandText = "select max(cast(right(DeliveryNoteNo, " & NoOfDigits & ") as int)) from tbl603_01DeliveryNoteMaster where DeliveryNoteNo like '" & DeliveryNoteAbbr & "%' AND Year(DeliveryDate) = '" & Year(DeliveryDate).ToString & "'"
            Else
                SqlCommand1.CommandText = "select max(cast(right(DeliveryNoteNo," & NoOfDigits & ") as int)) from tbl603_01DeliveryNoteMaster WHERE DeliveryNoteNo like '" & DeliveryNoteAbbr & "%'"
            End If


            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewQuotationNo = "000000" & CStr(int1)
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)

            If CheckIfNull(YearInDigit) = True Then
                YearInDigit = 0
            End If

            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = strYear & "-" & strNewQuotationNo
            strNewQuotationNo = DeliveryNoteAbbr & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = "000000" & 1
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)
            strNewQuotationNo = DeliveryNoteAbbr & strYear & "-" & strNewQuotationNo
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    'Saving and updating codes
    Public Sub NewDeliveryNoteMaster(ByVal DeliveryNoteNo As String)
        Try
            If CheckIfNull(DeliveryNoteNo) = False Then
                Me.Tbl60301DeliveryNoteMasterBindingSource.AddNew()
                Me.txtDeliveryNoteNo.EditValue = DeliveryNoteNo
                isBeingUpdated = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Delivery Note", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddNewLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewLineItem.ItemClick
        Try
            If selectedDeliveryType = 4 Or selectedDeliveryType = 3 Or selectedDeliveryType = 2 Or selectedDeliveryType = 1 Then
                If CheckIfNull(Me.txtStoreIssuedFrom.EditValue) = True Then
                    MessageBox.Show("Please Choose the Store Issued From before adding Line Items to Delivery Note", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If CheckIfNull(Me.txtDeliveryNoteDate.EditValue) = True Then
                    MessageBox.Show("Please Choose the Delivery Note Date of Issue From before adding Line Items to Delivery Note", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                GetCompanyDetails02(1)
                If gIsStoreWiseDelivery = True Then
                    Try
                        Dim EndDate As Date = Me.txtDeliveryNoteDate.EditValue
                        Me.InsertStoreInventoryValueByDate("2001-01-01", EndDate.AddHours(23))
                        Me.Qry653_20StoreStockBalanceWtStoreCodeTableAdapter.FillByStoreCode(Me.Dsfrm601_01QuotationEdit1.qry653_20StoreStockBalanceWtStoreCode, Me.txtStoreIssuedFrom.EditValue)

                        Me.colDetailedDescription.Visible = False

                        Me.colStockDescriptionWtStores.VisibleIndex = 3
                        Me.colStockDescriptionWtStores.Visible = True

                    Catch ex As Exception

                    End Try
                End If
            End If

            If CheckIfNull(Me.txtDeliveryNoteNo.EditValue) = False Then
                If Me.btnSave.Caption = "Save" Then
                    SaveNewDeliveryNoteMaster(Me.txtDeliveryNoteNo.EditValue)
                    Me.btnSave.Caption = "Update"
                End If

                Me.AddNewChild()
                Me.Validate()
                'Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, DeliveryNoteNo)
                Me.Qry60302DeliveryNoteChildBindingSource1.EndEdit()
                Me.Qry603_02DeliveryNoteChildTableAdapter1.Update(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild)

                Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, Me.txtDeliveryNoteNo.EditValue)

                Me.gvInvoiceChild.MoveLast()
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.Columns("GSCode")
                Me.gvInvoiceChild.ShowEditor()


            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Delivery Note Line Item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm601_05DeliveryNoteEdit.Tables("qry603_02DeliveryNoteChild")
            dr = dt.NewRow()
            dr("DeliveryNoteSlNo") = 1
            dr("DeliveryNoteNo") = Me.txtDeliveryNoteNo.EditValue
            dr("GSCode") = ""
            dr("IssuedQty") = 0
            dr("LineOrderNo") = GetNewDeliveryNoteLineItemNo(Me.txtDeliveryNoteNo.EditValue)
            dt.Rows.Add(dr)
            Me.Qry603_02DeliveryNoteChildTableAdapter1.Update(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Delivery Note Line Item, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewDeliveryNoteLineItemNo(ByVal strDeliveryNoteNo As String) As Integer
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Max(LineOrderNo) from tbl603_02DeliveryNoteChild where DeliveryNoteNo = '" & strDeliveryNoteNo & "'"
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1
            Return int1

        Catch ex As System.InvalidCastException
            Return 1
        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub cmdStockItemDesc_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs)

    End Sub

    Private Sub DeleteDeliveryNoteChild(ByVal DeliveryNoteChildSlNo As Integer, ByVal WithMessage As Boolean)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp603_01DeleteDeliveryNoteChild"
            Dim paramPayrollInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteSlNo", SqlDbType.Int)

            paramPayrollInvoiceNo.Value = DeliveryNoteChildSlNo

            SqlCommand1.ExecuteNonQuery()

            If WithMessage = True Then
                MessageBox.Show("Delivery Note Line Item Deleted Successfully,", "Data Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As System.InvalidCastException
            MessageBox.Show("Delivery Note Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLineItem.ItemClick

        DialogResult = MessageBox.Show("You are about to delete Delivery Note Line Item." & vbCrLf & "Are you Sure want to delete this Delivery Note Details?", "Delete Delivery Note Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedDeliveryNoteChildSlNo) = False Then

                Me.DeleteDeliveryNoteChild(Me.SelectedDeliveryNoteChildSlNo, True)

                'Refresh the datagrid
                'fill child details in the datagrid
                Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, Me.txtDeliveryNoteNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub gvInvoiceChild_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvInvoiceChild.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedDeliveryNoteChildSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryNoteSlNo"))
                Me.popInvoiceChild.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAddLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddLineItem.ItemClick
        If CheckIfNull(Me.txtDeliveryNoteNo.EditValue) = False Then
            Me.AddNewChild()
            Me.Validate()
            Me.Qry60302DeliveryNoteChildBindingSource1.EndEdit()
            Me.Qry603_02DeliveryNoteChildTableAdapter1.Update(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild)

            Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, Me.txtDeliveryNoteNo.EditValue)
        End If
    End Sub

    Public Sub UpdateInvoiceChild()
        Try

            Me.Validate()
            Me.Qry60302DeliveryNoteChildBindingSource1.EndEdit()
            Me.Qry603_02DeliveryNoteChildTableAdapter1.Update(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild)

            RefreshDeliveryNoteChild()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub RefreshDeliveryNoteChild()
        Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, Me.txtDeliveryNoteNo.EditValue)

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            If CheckIfDeliveryAlreadyPosted(Me.txtDeliveryNoteNo.EditValue) = True Then
                MessageBox.Show("This Delivery Note is already posted to your ledgers.", "Delivery Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Check if the Voucher is Posted already
            If CheckIfDeliveryNoteIsApproved(Me.txtDeliveryNoteNo.EditValue) = True Then
                MessageBox.Show("Delivery Note is already approved, You cannot delete the Approved Delivery Note", "Delivery Note Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            'Check if the Delivery Note is Invoiced
            If CheckIfDeliveryNoteIsInvoiced(Me.txtDeliveryNoteNo.EditValue) = True Then
                MessageBox.Show("Delivery Note is Invoiced, You cannot delete the Invoiced Delivery Note", "Delivery Note Invoiced", MessageBoxButtons.OK)
                Exit Sub

            End If


            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Delivery Note from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtDeliveryNoteNo.EditValue) = False Then
                    If DeleteDeliveryNote(Me.txtDeliveryNoteNo.EditValue) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.txtDeliveryNoteNo.EditValue, "VoucherScanned\IMSDelv")

                        MessageBox.Show("Delivery Note has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Delivery Note", "IMS Delivery Note Ref No." & Me.txtDeliveryNoteNo.EditValue & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogonUser & ".", Me.strLogonUser, Me.txtDeliveryNoteNo.EditValue)

                        'Refresh the datagrid
                        RefreshMasterDataGrid()

                        Me.Close()
                    Else
                        MessageBox.Show("Deleting Failed, please try again.", "Delete Failed", MessageBoxButtons.OK)
                    End If
                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Function CheckIfDeliveryNoteIsApproved(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select DeliveryNoteNo from tbl603_01DeliveryNoteMaster where (DeliveryNoteNo = '" & DeliveryNoteNo & "') and (Isnull(IsApproved,0) = 1 )"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Public Function CheckIfDeliveryNoteIsInvoiced(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select InvoiceNo from tbl603_01DeliveryNoteMaster where (DeliveryNoteNo = '" & DeliveryNoteNo & "') and  ((InvoiceNo IS NOT NULL) OR (InvoiceNo <> ''))"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Function DeleteDeliveryNote(ByVal DeliveryNoteNo As String) As Boolean
        Dim myTrans As System.Data.SqlClient.SqlTransaction

        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)

        If Sqlconnection1.State = ConnectionState.Closed Then
            Sqlconnection1.Open()
        End If

        Dim delPRTrans As New SqlClient.SqlCommand
        myTrans = Sqlconnection1.BeginTransaction(IsolationLevel.ReadCommitted, "PRTransaction")
        delPRTrans.Connection = Sqlconnection1
        delPRTrans.Transaction = myTrans
        Try

            delPRTrans.CommandText = "UPDATE dbo.tbl608_01JobOrderMaster SET JobOrderStatus = 2 FROM dbo.tbl603_02DeliveryNoteChild INNER JOIN dbo.tbl608_01JobOrderMaster ON dbo.tbl603_02DeliveryNoteChild.JobOrderNoInDNChild = dbo.tbl608_01JobOrderMaster.JobOrderNo WHERE (dbo.tbl603_02DeliveryNoteChild.DeliveryNoteNo  = '" & DeliveryNoteNo & "')"
            delPRTrans.ExecuteNonQuery()

            delPRTrans.CommandText = "DELETE from tbl603_01DeliveryNoteMaster WHERE DeliveryNoteNo   = '" & DeliveryNoteNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl603_02DeliveryNoteChild WHERE DeliveryNoteNo   = '" & DeliveryNoteNo & "'"
            delPRTrans.ExecuteNonQuery()
            myTrans.Commit()
            Return True

        Catch ex As Exception
            Try
                myTrans.Rollback("PRTransaction")
                Return False
            Catch Sqlex As System.Data.SqlClient.SqlException
                If Not myTrans.Connection Is Nothing Then
                    MessageBox.Show("An exception of type " & Sqlex.GetType().ToString() &
                                      " was encountered while attempting to roll back the transaction.", "Error on Delete", MessageBoxButtons.OK)
                End If
                MessageBox.Show("An exception of type " & ex.GetType().ToString() &
                                      "was encountered while inserting the data.")
                Return False
            End Try
        Finally
            Sqlconnection1.Close()
        End Try
    End Function


    Public Sub DisableApprovedVoucherEditing(ByVal QuotationNo As String)
        'Disable access if the voucher is already approved.
        'Get the IsVoucherIsApproved
        If CheckIfDeliveryNoteIsApproved(Me.txtDeliveryNoteNo.EditValue) = True Then
            Me.btnAddLineItem.Enabled = False
            Me.btnSave.Enabled = False
            Me.btnSaveAndClose.Enabled = False
            Me.btnAddNewLineItem.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnVerify.Enabled = False
            Me.btnApprove.Enabled = False
            Me.gcInvoiceChild.Enabled = False

            'Me.btnPreviewDeliveryNote.Enabled = True
            Me.btnPrint.Enabled = True

            Me.txtSalesPerson.Enabled = False
            Me.txtReferenceNo.Enabled = False
            Me.txtClientPODate.Enabled = False
            Me.txtDeliveryNoteDate.Enabled = False
            Me.txtClientName.Enabled = False
            Me.txtClientRefName.Enabled = False
            Me.txtClientContactNo.Enabled = False
            Me.txtIssuedToProject.Enabled = False
            Me.txtClientEmail.Enabled = False
            Me.txtProject.Enabled = False
            Me.txtStoreIssuedFrom.Enabled = False
            Me.txtInventoryStore.Enabled = False

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Me.txtCompanyID.Enabled = False
                    Me.txtDeliveryType.Enabled = False
                    Exit For
                End If
            Next
        End If

        'Me.CheckIfPDFAvailable(voucherNo)
    End Sub

    Public Sub DisableControlsForInventoryGroupMaster(ByVal InventoryGroupMaster As Integer)
        If InventoryGroupMaster = 99 Then
            Me.txtInventoryGroupMaster.Enabled = True
        Else
            Me.txtInventoryGroupMaster.Enabled = False
        End If


        'If Me.txtDeliveryType.EditValue = 1 Then
        '    Me.lblSalesPerson.Text = "Sales Person:"
        'Else
        '    Me.lblSalesPerson.Text = "Store Incharge:"
        'End If

    End Sub

    Private Sub txtClientName_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtClientName.ButtonClick
        If e.Button.Index = 2 Then

            Dim frm30106ClientMaster As New frm30106ClientMaster
            frm30106ClientMaster.ObjForm = Me

            frm30106ClientMaster.btnSave.Caption = "Save"
            frm30106ClientMaster.strLogonUser = Me.strLogonUser
            frm30106ClientMaster.intLogOnUserID = Me.intLogOnUserID
            frm30106ClientMaster.intLogOnUserLevel = Me.intLogOnUserLevel
            frm30106ClientMaster.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm30106ClientMaster.Show()
            frm30106ClientMaster.FillDataSetforNew()


            Dim NewClientCode As String = frm30106ClientMaster.GetNewClientNo()
            frm30106ClientMaster.txtClientCode.EditValue = NewClientCode

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm30106ClientMaster.txtSalesPerson.Enabled = True
            Else
                frm30106ClientMaster.txtSalesPerson.EditValue = GetSalesPersonCode(Me.intLogOnUserID)
                frm30106ClientMaster.txtSalesPerson.Enabled = False
            End If

            frm30106ClientMaster.txtClientName.Focus()
            frm30106ClientMaster.isExecutedFrom_frm601_05DeliveryNoteEdit = True

        ElseIf e.Button.Index = 1 Then

            If CheckIfNull(Me.txtClientName.EditValue) = True Or Me.txtClientName.Text = String.Empty Then
                MessageBox.Show("Please select the Client to edit.", "Select Client to edit", MessageBoxButtons.OK)
            Else
                Dim frm30106ClientMaster As New frm30106ClientMaster
                frm30106ClientMaster.ObjForm = Me

                frm30106ClientMaster.isExecutedFrom_frm601_05DeliveryNoteEdit = True

                frm30106ClientMaster.strLogonUser = Me.strLogonUser
                frm30106ClientMaster.intLogOnUserID = Me.intLogOnUserID
                frm30106ClientMaster.intLogOnUserLevel = Me.intLogOnUserLevel
                frm30106ClientMaster.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm30106ClientMaster.txtClientCode.EditValue = Me.txtClientName.EditValue
                frm30106ClientMaster.Show()
                frm30106ClientMaster.FillDataSetforEditing(Me.txtClientName.EditValue)

                frm30106ClientMaster.btnSave.Caption = "Update"

                Dim SalesPersonCode As String = ""
                SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    frm30106ClientMaster.txtSalesPerson.Enabled = True
                Else
                    frm30106ClientMaster.txtSalesPerson.Enabled = False
                End If

                frm30106ClientMaster.txtClientName.Focus()

            End If
        End If
    End Sub

    Private Sub txtClientName_EditValueChanged(sender As Object, e As EventArgs) Handles txtClientName.EditValueChanged
        Try
            If CheckIfNull(Me.txtClientName.EditValue) = False Then
                'Me.Tbl30101ClientMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster3.tbl30101ClientMaster)

                Me.txtClientRefName.EditValue = Me.Ds40103PropertyQuoteMaster.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactPerson")
                Me.txtClientContactNo.EditValue = Me.Ds40103PropertyQuoteMaster.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactPhone1")
                Me.txtClientEmail.EditValue = Me.Ds40103PropertyQuoteMaster.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactEmail")



            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSignatory_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSignatory.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40115QuotationSignatories As New frm40115QuotationSignatories
            frm40115QuotationSignatories.ObjForm = Me
            frm40115QuotationSignatories.Show()
            frm40115QuotationSignatories.txtSignatoryName.Focus()
            frm40115QuotationSignatories.isExecutedFrom_frm601_05DeliveryNoteEdit = True
        End If
    End Sub

    Private Sub repoDetailedDescription_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoDetailedDescription.ButtonClick
        If e.Button.Index = 1 Then
            Try
                Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                frm20163VATGoodsAndServicesEdit.ObjForm = Me

                frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Save"
                frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_05DeliveryNoteEdit = True

                frm20163VATGoodsAndServicesEdit.strLogonUser = Me.strLogonUser
                frm20163VATGoodsAndServicesEdit.intLogOnUserID = Me.intLogOnUserID
                frm20163VATGoodsAndServicesEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                frm20163VATGoodsAndServicesEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm20163VATGoodsAndServicesEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel

                frm20163VATGoodsAndServicesEdit.Show()
                frm20163VATGoodsAndServicesEdit.FillDataSetforNew()

                frm20163VATGoodsAndServicesEdit.txtUnitIssue.EditValue = 1
                frm20163VATGoodsAndServicesEdit.txtSellingRate.EditValue = 1

                frm20163VATGoodsAndServicesEdit.txtGSDescription.Focus()

            Catch ex As Exception
                MessageBox.Show("Error on Adding Goods & Services Item, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf e.Button.Index = 2 Then
            Try
                Dim strItemCode As String = Me.gvInvoiceChild.GetRowCellValue(Me.gvInvoiceChild.FocusedRowHandle, "GSCode")

                If CheckIfNull(strItemCode) = False Then

                    Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                    frm20163VATGoodsAndServicesEdit.ObjForm = Me
                    frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_05DeliveryNoteEdit = True

                    frm20163VATGoodsAndServicesEdit.strLogonUser = Me.strLogonUser
                    frm20163VATGoodsAndServicesEdit.intLogOnUserID = Me.intLogOnUserID
                    frm20163VATGoodsAndServicesEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                    frm20163VATGoodsAndServicesEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                    frm20163VATGoodsAndServicesEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                    frm20163VATGoodsAndServicesEdit.txtGSCode.EditValue = strItemCode
                    frm20163VATGoodsAndServicesEdit.Show()
                    frm20163VATGoodsAndServicesEdit.FillDataSetforEditing(strItemCode)

                    frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Update"
                    frm20163VATGoodsAndServicesEdit.txtGSDescription.Focus()

                End If

            Catch ex As Exception

            End Try

        ElseIf e.Button.Index = 3 Then
            Try
                Dim strItemCode As String = Me.gvInvoiceChild.GetRowCellValue(Me.gvInvoiceChild.FocusedRowHandle, "GSCode")

                If CheckIfNull(strItemCode) = False Then

                    Dim frm600_01InventoryStockEdit As New frm600_01InventoryStockEdit
                    frm600_01InventoryStockEdit.objForm = Me
                    frm600_01InventoryStockEdit.isExecutedFrom_frm601_05DeliveryNoteEdit = True

                    frm600_01InventoryStockEdit.strLogOnUser = Me.strLogonUser
                    frm600_01InventoryStockEdit.intLogOnUserID = Me.intLogOnUserID
                    frm600_01InventoryStockEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                    frm600_01InventoryStockEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                    frm600_01InventoryStockEdit.intLogOnDivision = Me.intLogOnDivision
                    frm600_01InventoryStockEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                    frm600_01InventoryStockEdit.txtStockCode.EditValue = strItemCode
                    frm600_01InventoryStockEdit.Show()
                    frm600_01InventoryStockEdit.FillDataSetforEditing(strItemCode)

                    frm600_01InventoryStockEdit.btnSave.Caption = "Update"
                    frm600_01InventoryStockEdit.txtStockCode.Enabled = False
                    frm600_01InventoryStockEdit.txtItemName.Focus()


                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub gvInvoiceChild_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvInvoiceChild.CellValueChanged
        Try
            'Dim DescriptionCaptionWtArabic As String = "Description " & Global.Microsoft.VisualBasic.ChrW(10) & "// وصف السلعة"

            If e.Column.Caption = "Description" Then
                Dim SelectedValue As String = e.Value
                GetGSDetails(SelectedValue)
                gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitRateMethod"), gGSStockUnitMethod)

                GetCompanyDetails02(1)
                If gIsShowFixedCostPrice = True Then
                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedUnitPrice"), gCostPrice)

                Else
                    'Get Stock Issue Cost Price - Average Cost Price
                    PostAvgCostPriceToTable(Me.txtDeliveryNoteDate.EditValue, SelectedValue)

                    Dim StockCostAvgPrice As Decimal = Me.GetStockIssueCost(SelectedValue)

                    If StockCostAvgPrice = 0 Then
                        StockCostAvgPrice = gCostPrice
                    End If

                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedUnitPrice"), StockCostAvgPrice)
                End If

                'Dim StockCostAvgPrice As Decimal = Me.GetStockIssueCost(SelectedValue)
                'gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedUnitPrice"), StockCostAvgPrice)

                Dim intFocusedRow As Integer = Me.gvInvoiceChild.FocusedRowHandle
                UpdateInvoiceChild()
                Me.gvInvoiceChild.FocusedRowHandle = intFocusedRow
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.VisibleColumns(7)
                Me.gvInvoiceChild.ShowEditor()

            End If


            If e.Column.Caption = "Stock Description" Then
                Dim SelectedValue As String = e.Value
                GetGSDetails(SelectedValue)
                gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitRateMethod"), gGSStockUnitMethod)

                GetCompanyDetails02(1)
                If gIsShowFixedCostPrice = True Then
                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedUnitPrice"), gCostPrice)

                Else
                    'Get Stock Issue Cost Price - Average Cost Price
                    PostAvgCostPriceToTable(Me.txtDeliveryNoteDate.EditValue, SelectedValue)

                    Dim StockCostAvgPrice As Decimal = Me.GetStockIssueCost(SelectedValue)

                    If StockCostAvgPrice = 0 Then
                        StockCostAvgPrice = gCostPrice
                    End If

                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedUnitPrice"), StockCostAvgPrice)
                End If

                'Dim StockCostAvgPrice As Decimal = Me.GetStockIssueCost(SelectedValue)
                'gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedUnitPrice"), StockCostAvgPrice)

                Dim intFocusedRow As Integer = Me.gvInvoiceChild.FocusedRowHandle
                UpdateInvoiceChild()
                Me.gvInvoiceChild.FocusedRowHandle = intFocusedRow
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.VisibleColumns(7)
                Me.gvInvoiceChild.ShowEditor()

            End If


            If e.Column.Name = "colQuantityInvoiced" Then
                If e.Value = 0 Then
                    Exit Sub
                End If

                GetCompanyDetails02(1)
                If gIsStrictDeliveryWoCurrentQty = True Then
                    Dim EnteredQty As Decimal = e.Value
                    Dim SelectedGSCode As String = gvInvoiceChild.GetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("GSCode"))
                    If CheckIfGSCodeIsServiceGroup(SelectedGSCode) = True Then
                        Exit Sub
                    End If

                    Dim SelectedItemCurrentQty As Decimal = GetCurrentQtyByDate(SelectedGSCode, Me.txtStoreIssuedFrom.EditValue)
                    Dim SelectedUOM As String = gvInvoiceChild.GetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitRateMethod"))
                    Dim UnitsToConvert As Decimal = GetStockItemBaseUnitsToConvert(SelectedGSCode, SelectedUOM)

                    Dim CurrentQtyForThisUOM As Decimal = 0D

                    If UnitsToConvert <> 0 Then
                        CurrentQtyForThisUOM = SelectedItemCurrentQty / UnitsToConvert
                    Else
                        CurrentQtyForThisUOM = SelectedItemCurrentQty
                    End If

                    If Math.Round(CurrentQtyForThisUOM, 4) >= EnteredQty Then
                        Exit Sub
                    Else
                        MessageBox.Show("Current Quantity for this Item is " & Format(CurrentQtyForThisUOM, "#,0.####") & vbCrLf & "less than Issuing Quantity," & vbCrLf & "Please check the Quantity avaliable in hand.", "Current Quantity is Less", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedQty"), 0)
                        Exit Sub
                    End If

                End If


            End If

            If e.Column.Name = "colUnitRateMethod" Then
                GetCompanyDetails02(1)
                If gIsStrictUnitsForStockItems = True Then
                    Dim EnteredUOM As Decimal = e.Value
                    Dim SelectedGSCode As String = gvInvoiceChild.GetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("GSCode"))
                    If CheckIfGSCodeIsServiceGroup(SelectedGSCode) = True Then
                        Exit Sub
                    End If

                    If CheckStockUOM(SelectedGSCode, EnteredUOM) = True Then

                        'Get the Unit Converted and Get the Cost Price and multiply it by Unit Converted
                        Dim UnitsToConvert As Decimal = GetStockItemBaseUnitsToConvert(SelectedGSCode, EnteredUOM)
                        Dim CostPrice As Decimal = Me.GetStockIssueCost(SelectedGSCode)
                        Dim UnitCostPrice As Decimal = 0D
                        UnitCostPrice = UnitsToConvert * CostPrice
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedUnitPrice"), UnitCostPrice)

                        'Get the Unit Converted and get the Selling Price and Mulitply it by unit converted
                        GetGSDetails(SelectedGSCode)
                        Dim UnitSellingPrice As Decimal = 0D
                        UnitSellingPrice = UnitsToConvert * gGSSellingRate
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedQuoteUnitPrice"), UnitSellingPrice)

                        Exit Sub
                    Else
                        MessageBox.Show("Selected Unit is not in the Base Unit of this Stock Item," & vbCrLf & "Please check the Unit and try again.", "UoM not matching", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitRateMethod"), GetStockItemBaseUnit(SelectedGSCode))
                        Me.gvInvoiceChild.FocusedColumn = gvInvoiceChild.Columns("UnitRateMethod")

                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub btnTerms_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTerms.ItemClick
    '    If CheckIfNull(Me.txtQuotationNo.EditValue) = False Then
    '        Dim frm40107QuoteSelected As New frm40107QuoteSelected
    '        frm40107QuoteSelected.Show()
    '        frm40107QuoteSelected.SelectedQuoteNo = Me.txtQuotationNo.EditValue
    '        frm40107QuoteSelected.FilterSelectedQuoteNo(Me.txtQuotationNo.EditValue)
    '        frm40107QuoteSelected.selectedQuoteType = "Sales"

    '    End If
    'End Sub


    Private Sub btnPreviewDeliveryNote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewDeliveryNote.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)


            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)

                    Exit For
                End If
            Next

            Dim rpt1 As New rpt601_03DeliveryNoteFormat01

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-DN-01"
            Dim frm1 As New frm999_03ReportPreviewIMS_DeliveryNote

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            rpt1.Qry603_05DeliveryNoteReportTableAdapter.FillByDeliveryNoteNo(rpt1.DsRpt601_03DeliveryNoteReport1.qry603_05DeliveryNoteReport, Me.txtDeliveryNoteNo.EditValue)


            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue

            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "DeliveryNoteNo_" & Me.txtDeliveryNoteNo.EditValue & "_" & Me.txtClientName.Text

            If Not CheckIfNull(Me.txtShowLineItemNo.EditValue) Then
                If Me.txtShowLineItemNo.EditValue = True Then
                    rpt1.ShowLineItemNo = True
                Else
                    rpt1.ShowLineItemNo = False
                End If
            End If

            If Not CheckIfNull(Me.txtIsPrintAtBottom.EditValue) Then
                If Me.txtIsPrintAtBottom.EditValue = True Then
                    rpt1.IsPrintFooterAtBottom = True
                Else
                    rpt1.IsPrintFooterAtBottom = False
                End If
            End If

            rpt1.RequestParameters = False
            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEditContacts_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles cmdEditContacts.OpenLink
        Try
            Dim strClientCode As String = Me.txtClientName.EditValue

            If CheckIfNull(strClientCode) = False Then

                Dim frm600_03ClientContactList As New frm600_03ClientContactList
                frm600_03ClientContactList.ObjForm = Me
                frm600_03ClientContactList.isExecutedFrom_frm601_05DeliveryNoteEdit = True

                frm600_03ClientContactList.strLogonUser = Me.strLogonUser
                frm600_03ClientContactList.intLogOnUserID = Me.intLogOnUserID
                frm600_03ClientContactList.intLogOnUserLevel = Me.intLogOnUserLevel
                frm600_03ClientContactList.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm600_03ClientContactList.txtClientCode.EditValue = strClientCode
                frm600_03ClientContactList.txtClientCode.Enabled = False

                frm600_03ClientContactList.txtClientName.EditValue = Me.txtClientName.Text
                frm600_03ClientContactList.txtClientName.Enabled = False
                frm600_03ClientContactList.Show()
                frm600_03ClientContactList.FillDataSetforEditing(strClientCode)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSalesPerson_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSalesPerson.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm20107SalesPersonMaster As New frm20107SalesPersonMaster
            frm20107SalesPersonMaster.ObjForm = Me
            frm20107SalesPersonMaster.Show()
            frm20107SalesPersonMaster.txtSalesPersonName.Focus()
            frm20107SalesPersonMaster.isExecutedFrom_frm601_05DeliveryNoteEdit = True

        End If
    End Sub

    Private Sub btnPreviewMRN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewMRN.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_06MaterialIssues
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-DN-02"
            Dim frm1 As New frm999_03ReportPreviewIMS_DeliveryNote

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            rpt1.Qry603_05DeliveryNoteReportTableAdapter.FillByDeliveryNoteNo(rpt1.DsRpt601_03DeliveryNoteReport1.qry603_05DeliveryNoteReport, Me.txtDeliveryNoteNo.EditValue)

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.ExportOptions.PrintPreview.DefaultFileName = "DeliveryNoteNo_" & Me.txtDeliveryNoteNo.EditValue

            If Me.txtDeliveryType.EditValue = 1 Then
                'Issued to Client
                rpt1.tblClientDetails.Visible = True
                rpt1.tblStoreIssue.Visible = False
                rpt1.tblProjectDetails.Visible = False
                rpt1.tblStoreTransfers.Visible = False

            ElseIf Me.txtDeliveryType.EditValue = 2 Then
                'Issued to Store Consumption
                rpt1.tblClientDetails.Visible = False
                rpt1.tblStoreIssue.Visible = True
                rpt1.tblProjectDetails.Visible = False
                rpt1.tblStoreTransfers.Visible = False

            ElseIf Me.txtDeliveryType.EditValue = 3 Then
                'Issued to Projects
                rpt1.tblClientDetails.Visible = False
                rpt1.tblStoreIssue.Visible = False
                rpt1.tblProjectDetails.Visible = True
                rpt1.tblStoreTransfers.Visible = False

            ElseIf Me.txtDeliveryType.EditValue = 4 Then
                'Store Transfers
                rpt1.tblClientDetails.Visible = False
                rpt1.tblStoreIssue.Visible = False
                rpt1.tblProjectDetails.Visible = False
                rpt1.tblStoreTransfers.Visible = True

            End If

            rpt1.RequestParameters = False

            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtInventoryStore_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtInventoryStore.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm600_01StoreEdit As New frm600_01StoreEdit
            frm600_01StoreEdit.ObjForm = Me
            frm600_01StoreEdit.Show()
            frm600_01StoreEdit.txtStoreName.Focus()
            frm600_01StoreEdit.isExecutedFrom_frm601_05DeliveryNoteEdit = True

        End If
    End Sub

    Private Sub btnPreviewDeliveryNoteDotMat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewDeliveryNoteDotMat.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_03DeliveryNoteFormat02
            rpt1.Qry603_05DeliveryNoteReportTableAdapter.FillByDeliveryNoteNo(rpt1.DsRpt601_03DeliveryNoteReport1.qry603_05DeliveryNoteReport, Me.txtDeliveryNoteNo.EditValue)

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.ExportOptions.PrintPreview.DefaultFileName = "DeliveryNoteNo_" & Me.txtDeliveryNoteNo.EditValue & "_" & Me.txtClientName.Text

            rpt1.RequestParameters = False
            rpt1.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub repoChooseBatchNo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoChooseBatchNo.ButtonClick
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60302DeliveryNoteChildBindingSource1.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.Qry652_09ExpDtStockBalanceWithDescTableAdapter.FillByGSCode(Me.Dsfrm601_05DeliveryNoteEdit.qry652_09ExpDtStockBalanceWithDesc, SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Dim SelectedGSCode As String = ""
    Dim SelectedExpiryDate As Date = Date.Today
    Dim SelectedBatchNo As String = ""
    Dim SelectedQtyBalance As Decimal = 0D

    Private Sub repoGSCode_Click(sender As Object, e As EventArgs) Handles repoGSCode.Click
        Try

            Dim SelectedGSCode As String = Me.gvStockListWtExpDate.GetRowCellValue(Me.gvStockListWtExpDate.FocusedRowHandle, "GSCode")
            Dim SelectedExpiryDate As String = Me.gvStockListWtExpDate.GetRowCellValue(Me.gvStockListWtExpDate.FocusedRowHandle, "ExpiryDate")
            Dim SelectedBatchNo As String = Me.gvStockListWtExpDate.GetRowCellValue(Me.gvStockListWtExpDate.FocusedRowHandle, "BatchNo")
            Dim SelectedQtyBalance As String = Me.gvStockListWtExpDate.GetRowCellValue(Me.gvStockListWtExpDate.FocusedRowHandle, "TotalBalance")

            'MessageBox.Show(SelectedGSCode & "," & SelectedBatchNo & ", " & SelectedExpiryDate)

            Dim view As DataRowView = DirectCast(Me.Qry60302DeliveryNoteChildBindingSource1.Current, DataRowView)
            view.Row("ExpiryDate") = SelectedExpiryDate
            view.Row("BatchNo") = SelectedBatchNo
            view.Row("TotalBalance") = SelectedQtyBalance

            'Dim control As PopupContainerBarControl = TryCast(PopupContainerStockListWtExp.Parent, PopupContainerBarControl)
            'control.ClosePopup()

            Me.PopupContainerStockListWtExp.OwnerEdit.ClosePopup()
            Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.Columns("GSCode")


        Catch ex As Exception

        End Try
    End Sub

    Public Function GetStockIssueCost(ByVal GSCode As String) As Decimal
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            'strSqlQueryText = "SELECT Isnull(AvgCostUnitRate,0) as AvgCostUnitRate FROM qry653_16GetInventoryIssuePriceUsingAvgCost WHERE (GSCode = '" & GSCode & "') "

            strSqlQueryText = "SELECT Isnull(AverageStockPrice,0) as AvgCostUnitRate FROM tbl654_01StockMasterAvgCost WHERE (GSCode = '" & GSCode & "') "


            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    If CheckIfNull(srStockReader.Item("AvgCostUnitRate")) = False Then
                        Return srStockReader.Item("AvgCostUnitRate") & ""
                    Else
                        Return 0
                    End If
                End While
            Else
                Return 0
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return ""
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub CheckPostingErrors()

        'Delivery Type 1 = Issues to Client
        If Me.txtDeliveryType.EditValue = 1 Then
            If String.IsNullOrEmpty(ConvertIfNull(Me.txtStoreIssuedFrom.Text)) Or CheckIfNull(Me.txtStoreIssuedFrom.EditValue) = True Then
                Me.DxErrorProvider2.SetError(Me.txtStoreIssuedFrom, "Stock Issued from Store must be entered before posting.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider2.SetError(Me.txtStoreIssuedFrom, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

            If String.IsNullOrEmpty(ConvertIfNull(Me.txtClientName.Text)) Or CheckIfNull(Me.txtStoreIssuedFrom.EditValue) = True Then
                Me.DxErrorProvider2.SetError(Me.txtClientName, "Client Name Cannot be Empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider2.SetError(Me.txtClientName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

        End If

        'Delivery Type 2 = Store Consumption / Issued to Store 
        If Me.txtDeliveryType.EditValue = 2 Then
            If String.IsNullOrEmpty(ConvertIfNull(Me.txtStoreIssuedFrom.Text)) Or CheckIfNull(Me.txtStoreIssuedFrom.EditValue) = True Then
                Me.DxErrorProvider2.SetError(Me.txtStoreIssuedFrom, "Stock Issued from Store must be entered before posting.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider2.SetError(Me.txtStoreIssuedFrom, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

            If String.IsNullOrEmpty(ConvertIfNull(Me.txtInventoryStore.Text)) Or CheckIfNull(Me.txtInventoryStore.EditValue) = True Then
                Me.DxErrorProvider2.SetError(Me.txtInventoryStore, "Stock Issued to Store must be entered before posting.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider2.SetError(Me.txtInventoryStore, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

        End If

        If Me.txtDeliveryType.EditValue = 3 Then
            If String.IsNullOrEmpty(ConvertIfNull(Me.txtStoreIssuedFrom.Text)) Or CheckIfNull(Me.txtStoreIssuedFrom.EditValue) = True Then
                Me.DxErrorProvider2.SetError(Me.txtStoreIssuedFrom, "Stock Issued from Store must be entered before posting.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider2.SetError(Me.txtStoreIssuedFrom, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

            If String.IsNullOrEmpty(ConvertIfNull(Me.txtIssuedToProject.Text)) Or CheckIfNull(Me.txtIssuedToProject.EditValue) = True Then
                Me.DxErrorProvider2.SetError(Me.txtIssuedToProject, "Stock Issued to Project must be entered before posting.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider2.SetError(Me.txtIssuedToProject, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

        End If


        If Me.txtDeliveryType.EditValue = 4 Then
            If String.IsNullOrEmpty(ConvertIfNull(Me.txtStoreIssuedFrom.Text)) Or CheckIfNull(Me.txtStoreIssuedFrom.EditValue) = True Then
                Me.DxErrorProvider2.SetError(Me.txtStoreIssuedFrom, "Stock Issued from Store must be entered before posting.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider2.SetError(Me.txtStoreIssuedFrom, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

            If String.IsNullOrEmpty(ConvertIfNull(Me.txtInventoryStore.Text)) Or CheckIfNull(Me.txtInventoryStore.EditValue) = True Then
                Me.DxErrorProvider2.SetError(Me.txtInventoryStore, "Stock Issued to Store must be entered before posting.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider2.SetError(Me.txtInventoryStore, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

        End If
    End Sub

#Region "Production Table Entries"
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceipts.ItemClick
        'If the Production Voucher is already added .. then open it.
        'Get the Receipt Voucher No from Delivery Note No...
        If CheckIfDeliveryHasProductionVoucher(Me.txtDeliveryNoteNo.EditValue) = True Then
            Me.OpenReceipt(Me.MaterialReceiptNo)

        Else
            'If not already added, create new Production Voucher and Open it for adding
            'Add new Receipt voucher no and add it.
            'frm601_24ProductionReceipt.GetNewReceiptNo("PRV", 4)

            Me.CreateNewReceipt(Me.txtDeliveryNoteNo.EditValue)

        End If

    End Sub

    Private Sub CreateNewReceipt(ByVal DeliveryNoteNo As String)
        Dim frm601_24ProductionReceipt As New frm601_24ProductionReceipt
        frm601_24ProductionReceipt.ObjForm = Me

        frm601_24ProductionReceipt.btnSave.Caption = "Save"
        frm601_24ProductionReceipt.isBeingNew = True

        frm601_24ProductionReceipt.strLogonUser = Me.strLogonUser
        frm601_24ProductionReceipt.intLogOnUserID = Me.intLogOnUserID
        frm601_24ProductionReceipt.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_24ProductionReceipt.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_24ProductionReceipt.intLogOnDivision = Me.intLogOnDivision

        frm601_24ProductionReceipt.isExecutedFrom_frm601_05DeliveryNoteEdit = True

        frm601_24ProductionReceipt.Show()

        GetCompanyDetails(1)
        Dim NewReceiptNo As String = frm601_24ProductionReceipt.GetNewReceiptNo("PRV-", gInvoiceYearDigits)
        frm601_24ProductionReceipt.CreatedNewReceiptNo = NewReceiptNo
        frm601_24ProductionReceipt.NewReceiptMaster(NewReceiptNo)
        frm601_24ProductionReceipt.txtMaterialReceiptNo.EditValue = NewReceiptNo
        frm601_24ProductionReceipt.txtMaterialReceiptDate.EditValue = Date.Today

        frm601_24ProductionReceipt.txtStoreCode.EditValue = Me.txtInventoryStore.EditValue

        frm601_24ProductionReceipt.txtDN.EditValue = DeliveryNoteNo

        frm601_24ProductionReceipt.txtDeliveryNoteNo.EditValue = DeliveryNoteNo
        frm601_24ProductionReceipt.txtDeliveryNoteDate.EditValue = Me.txtDeliveryNoteDate.EditValue
        frm601_24ProductionReceipt.txtReceivedFrom.EditValue = Me.txtInventoryStore.Text

        If CheckIfDeliveryHasAmount(DeliveryNoteNo) = True Then
            frm601_24ProductionReceipt.txtTotalDeliveryValue.EditValue = Me.TotalValueOfDeliveryNote
        End If


        'frm601_24ProductionReceipt.UpdateDefaultFields()

    End Sub

    Private Sub OpenReceipt(ByVal ReceiptNo As String)
        If CheckIfNull(ReceiptNo) = False Then
            Dim frm601_24ProductionReceipt As New frm601_24ProductionReceipt
            frm601_24ProductionReceipt.ObjForm = Me

            frm601_24ProductionReceipt.btnSave.Caption = "Update"

            frm601_24ProductionReceipt.strLogonUser = Me.strLogonUser
            frm601_24ProductionReceipt.intLogOnUserID = Me.intLogOnUserID
            frm601_24ProductionReceipt.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_24ProductionReceipt.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_24ProductionReceipt.intLogOnDivision = Me.intLogOnDivision
            frm601_24ProductionReceipt.txtStoreCode.EditValue = Me.txtInventoryStore.EditValue

            frm601_24ProductionReceipt.isExecutedFrom_frm601_05DeliveryNoteEdit = True

            frm601_24ProductionReceipt.Show()

            frm601_24ProductionReceipt.RetrieveReceiptMaster(ReceiptNo)

            frm601_24ProductionReceipt.txtDeliveryNoteNo.EditValue = Me.txtDeliveryNoteNo.EditValue
            frm601_24ProductionReceipt.txtDeliveryNoteDate.EditValue = Me.txtDeliveryNoteDate.EditValue
            frm601_24ProductionReceipt.txtReceivedFrom.EditValue = Me.txtInventoryStore.Text

            If CheckIfDeliveryHasAmount(Me.txtDeliveryNoteNo.EditValue) = True Then
                frm601_24ProductionReceipt.txtTotalDeliveryValue.EditValue = Me.TotalValueOfDeliveryNote
            End If

            frm601_24ProductionReceipt.txtMaterialReceiptNo.Enabled = False
            frm601_24ProductionReceipt.txtStoreCode.Enabled = False
            'frm601_24ProductionReceipt.DisableApprovedVoucherEditing(ReceiptNo)

        End If
    End Sub

    Dim MaterialReceiptNo As String = ""
    Public Function CheckIfDeliveryHasProductionVoucher(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReceiptNo, DeliveryNoteNo from tbl605_01MaterialReceiptMaster where (DeliveryNoteNo = '" & DeliveryNoteNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    If CheckIfNull(srStockReader.Item("ReceiptNo")) = False Then
                        MaterialReceiptNo = srStockReader.Item("ReceiptNo") & ""
                    Else
                        MaterialReceiptNo = ""
                    End If
                End While

                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

#End Region

    Private Sub btnDeleteSelectedLineItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteSelectedLineItems.ItemClick
        DialogResult = MessageBox.Show("You are about to delete all the Selected Delivery Note Line Item." & vbCrLf & "Are you Sure want to delete this Delivery Note Details?", "Delete Delivery Note Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Dim view As GridView = gvInvoiceChild
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    Dim ChosenDeliveryNoteSlNo As Integer = view.GetRowCellValue(row, view.Columns("DeliveryNoteSlNo"))
                    Me.DeleteDeliveryNoteChild(ChosenDeliveryNoteSlNo, False)

                Next
            End If
            'Refresh the datagrid
            'fill child details in the datagrid
            Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, Me.txtDeliveryNoteNo.EditValue)

        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub

        End If

    End Sub

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_05DeliveryNoteEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvInvoiceChild))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvInvoiceChild))
            End If

            Dim formID2 As String = "frm601_05DeliveryNoteEdit_GSList"
            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID2) = True Then
                UpdateXmlLayout(formID2, Me.intLogOnUserID, GetStringFromView(Me.gvGSList))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID2, GetStringFromView(Me.gvGSList))
            End If


            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_05DeliveryNoteEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub


#Region "Attach PDF files"

    Dim ScannedFileLocation As String = ""

    Private Sub GetTheScannedFileLocation()
        GetCompanyDetails(1)
        ScannedFileLocation = ""
        ScannedFileLocation = gScannedLocation
        ScannedFileLocation = gScannedLocation & "VoucherScanned\IMSDelv"
    End Sub

    Public Sub CheckIfPDFAvailable(ByVal VoucherNo As String)
        GetTheScannedFileLocation()
        ScannedFileLocation = ScannedFileLocation & VoucherNo & ".pdf"
        If System.IO.File.Exists(ScannedFileLocation) = True Then
            Me.btnAttachments.Glyph = My.Resources.book_blue

        Else
            Me.btnAttachments.Glyph = My.Resources.book_blue_delete
        End If
        ScannedFileLocation = ""

    End Sub
    Private Sub btnAttachments_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAttachments.ItemClick
        GetTheScannedFileLocation()
        AttachFile(Me.txtDeliveryNoteNo.EditValue, ScannedFileLocation)
    End Sub
    Private Sub AttachFile(ByVal DocumentNo As String, ByVal ScannedFileLocation As String)
        Dim nullcheck1 As Boolean = IsDBNull(DocumentNo)
        If nullcheck1 = True Then
            MessageBox.Show("No Records to show.", "No Record", MessageBoxButtons.OK)
        Else
            GetTheScannedFileLocation()
            ScannedFileLocation = ScannedFileLocation & DocumentNo & ".pdf"

            If System.IO.File.Exists(ScannedFileLocation) = True Then
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = DocumentNo
                frmDocuments.LoadDocument(ScannedFileLocation)
                frmDocuments.sourceFile = ScannedFileLocation
                frmDocuments.IsIMSDelv = True
                frmDocuments.Show()
            Else
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = DocumentNo
                frmDocuments.IsIMSDelv = True
                frmDocuments.Show()
                frmDocuments.OpenFileDialogBox()
            End If

        End If
    End Sub


#End Region

    Private Sub PostAvgCostPriceToTable(ByVal DeliveryDate As Date, ByVal GSCode As String)
        Try

            'Run the Average Cost Definition Table as on the DeliveryDate Value
            InsertStockAverageCost(DeliveryDate, GSCode)
        Catch ex As Exception

        End Try


    End Sub


    '#Region "Old Post to Journal Codes"
    '    Private Sub btnPostJournal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPostJournal.ItemClick
    '        'Check if the JV is entered already using VoucherRefNO
    '        If CheckIfDeliveryAlreadyPosted(Me.txtDeliveryNoteNo.EditValue) = True Then
    '            MessageBox.Show("This Delivery Note is already posted to your ledgers.", "Delivery Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        'Check the Selection of Income ledger and Cost Center Ledger


    '        'Select the Details Page
    '        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
    '            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
    '                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
    '                Exit For
    '            End If
    '        Next

    '        CheckPostingErrors()
    '        If DxErrorProvider2.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
    '            MessageBox.Show("Cannot continue Post Journal Entry with errors, please clear the errors and continue.", "Clear Errors", MessageBoxButtons.OK)
    '            Exit Sub
    '        End If

    '        'Check if the Invoice has any entries or not
    '        If CheckIfDeliveryHasNoAmount(Me.txtDeliveryNoteNo.EditValue) = True Then
    '            MessageBox.Show("This Delivery has no amount to be posted, Please review the Delivery Note again.", "No Amount to post", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        Try
    '            If CheckIfNull(Me.txtDeliveryNoteNo.EditValue) = False Then
    '                'Save the Entry
    '                SaveAll(False)

    '                Dim CurrentDate As Date = Me.txtDeliveryNoteDate.EditValue
    '                Dim CurrentYear As String = CurrentDate.Year
    '                Dim CurrentMonth As String = CurrentDate.Month
    '                Dim CurrMonthWithZero As String = "00" & CurrentMonth
    '                Dim VoucherString As String = "JV-" & CurrentYear.Substring(CurrentYear.Length - 2, 2) & "-" & CurrMonthWithZero.Substring(CurrMonthWithZero.Length - 2, 2) & "-"

    '                Dim VoucherNo As String = GetNewVoucherNo("Journal", "JV", VoucherString, CurrentMonth, CurrentYear)

    '                'Check if Delivery Type is Client or to Store
    '                If Me.txtDeliveryType.EditValue = 1 Then
    '                    Me.PostClientDeliveryJournal(Me.txtDeliveryNoteNo.EditValue, VoucherNo)
    '                    UpdatePosted(True, Me.strLogonUser, Me.txtDeliveryNoteNo.EditValue, VoucherNo)
    '                End If

    '                'Check if Delivery Type is Store Consumption
    '                '
    '                If Me.txtDeliveryType.EditValue = 2 Then
    '                    Me.PostStoreConsumptionJournal(Me.txtDeliveryNoteNo.EditValue, VoucherNo)
    '                    UpdatePosted(True, Me.strLogonUser, Me.txtDeliveryNoteNo.EditValue, VoucherNo)
    '                End If

    '                'Check if Delivery Type is Store Transfer
    '                If Me.txtDeliveryType.EditValue = 4 Then
    '                    Me.PostDeliveryJournal(Me.txtDeliveryNoteNo.EditValue, VoucherNo)
    '                    UpdatePosted(True, Me.strLogonUser, Me.txtDeliveryNoteNo.EditValue, VoucherNo)
    '                End If

    '                MessageBox.Show("Delivery Note has been posted to the Accounting Books.", "Delivery Note Posted Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                'Refresh the datagrid
    '                RefreshMasterDataGrid()
    '            Else
    '                'MessageBox.Show("Please select the Journal Posting to proceed.", "Select Posting for.", MessageBoxButtons.OK)
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub


    '    Public Function CheckIfDeliveryAlreadyPosted(ByVal DeliveryNoteNo As String) As Boolean
    '        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
    '        Try
    '            If Sqlconnection1.State = ConnectionState.Closed Then
    '                Sqlconnection1.Open()
    '            End If
    '            Dim strSqlQueryText As String
    '            strSqlQueryText = "Select VoucherNo from tbl201VoucherMaster where (VoucherRefNo = '" & DeliveryNoteNo & "')"

    '            Dim SqlCommand1 As New SqlClient.SqlCommand
    '            SqlCommand1.Connection = Sqlconnection1
    '            SqlCommand1.CommandText = strSqlQueryText
    '            Dim srStockReader As SqlClient.SqlDataReader
    '            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

    '            If srStockReader.HasRows() Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '            srStockReader.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
    '            Return False
    '        Finally
    '            Sqlconnection1.Close()
    '        End Try

    '    End Function


    '    Public Function CheckIfDeliveryHasNoAmount(ByVal DeliveryNoteNo As String) As Boolean
    '        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
    '        Try
    '            If Sqlconnection1.State = ConnectionState.Closed Then
    '                Sqlconnection1.Open()
    '            End If
    '            Dim strSqlQueryText As String
    '            strSqlQueryText = "Select DeliveryNoteNo, Isnull(TotalAfterDiscount,0) as TotalAfterDiscount from qry603_03DeliveryNoteItemsWithTotal where (Isnull(TotalAfterDiscount, 0) <= 0 and DeliveryNoteNo = '" & DeliveryNoteNo & "')"

    '            Dim SqlCommand1 As New SqlClient.SqlCommand
    '            SqlCommand1.Connection = Sqlconnection1
    '            SqlCommand1.CommandText = strSqlQueryText
    '            Dim srStockReader As SqlClient.SqlDataReader
    '            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

    '            If srStockReader.HasRows() Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '            srStockReader.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
    '            Return False
    '        Finally
    '            Sqlconnection1.Close()
    '        End Try

    '    End Function

    '    Public Sub PostClientDeliveryJournal(ByVal DeliveryNoteNo As String, ByVal VoucherNo As String)
    '        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
    '        Try
    '            If Sqlconnection1.State = ConnectionState.Closed Then
    '                Sqlconnection1.Open()
    '            End If

    '            Dim SqlCommand1 As New SqlClient.SqlCommand
    '            SqlCommand1.Connection = Sqlconnection1
    '            SqlCommand1.CommandType = CommandType.StoredProcedure
    '            SqlCommand1.CommandText = "sp600_22InsertCostOfGoodsSoldToVoucher"
    '            SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar).Value = DeliveryNoteNo
    '            SqlCommand1.Parameters.Add("@VoucherNo", SqlDbType.VarChar).Value = VoucherNo
    '            SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar).Value = Me.strLogonUser
    '            SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime).Value = Date.Now

    '            Dim srStockReader As SqlClient.SqlDataReader
    '            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)
    '            srStockReader.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)

    '        Finally
    '            Sqlconnection1.Close()
    '        End Try
    '    End Sub

    '    Public Sub PostStoreConsumptionJournal(ByVal DeliveryNoteNo As String, ByVal VoucherNo As String)
    '        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
    '        Try
    '            If Sqlconnection1.State = ConnectionState.Closed Then
    '                Sqlconnection1.Open()
    '            End If

    '            Dim SqlCommand1 As New SqlClient.SqlCommand
    '            SqlCommand1.Connection = Sqlconnection1
    '            SqlCommand1.CommandType = CommandType.StoredProcedure
    '            SqlCommand1.CommandText = "sp600_22InsertStockConsumptionToVoucher"
    '            SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar).Value = DeliveryNoteNo
    '            SqlCommand1.Parameters.Add("@VoucherNo", SqlDbType.VarChar).Value = VoucherNo
    '            SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar).Value = Me.strLogonUser
    '            SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime).Value = Date.Now

    '            Dim srStockReader As SqlClient.SqlDataReader
    '            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)
    '            srStockReader.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)

    '        Finally
    '            Sqlconnection1.Close()
    '        End Try
    '    End Sub

    '    Public Sub PostDeliveryJournal(ByVal DeliveryNoteNo As String, ByVal VoucherNo As String)
    '        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
    '        Try
    '            If Sqlconnection1.State = ConnectionState.Closed Then
    '                Sqlconnection1.Open()
    '            End If

    '            Dim SqlCommand1 As New SqlClient.SqlCommand
    '            SqlCommand1.Connection = Sqlconnection1
    '            SqlCommand1.CommandType = CommandType.StoredProcedure
    '            SqlCommand1.CommandText = "sp600_22InsertStockTransferToVoucher"
    '            SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar).Value = DeliveryNoteNo
    '            SqlCommand1.Parameters.Add("@VoucherNo", SqlDbType.VarChar).Value = VoucherNo
    '            SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar).Value = Me.strLogonUser
    '            SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime).Value = Date.Now

    '            Dim srStockReader As SqlClient.SqlDataReader
    '            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)
    '            srStockReader.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)

    '        Finally
    '            Sqlconnection1.Close()
    '        End Try
    '    End Sub

    '    Private Function UpdatePosted(ByVal IsPosted As Boolean, ByVal PostedBy As String, ByVal DeliveryNoteNo As String, ByVal VoucherNo As String) As Boolean
    '        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
    '        Try
    '            If Sqlconnection1.State = ConnectionState.Closed Then
    '                Sqlconnection1.Open()
    '            End If

    '            Dim strSqlQueryText As String
    '            strSqlQueryText = "UPDATE tbl603_01DeliveryNoteMaster Set IsPosted = '" & IsPosted & "', PostedBy = '" & PostedBy & "', PostedOn = Getdate(), VoucherNo = '" & VoucherNo & "' where DeliveryNoteNo = '" & DeliveryNoteNo & "'"

    '            Dim SqlCommand1 As New SqlClient.SqlCommand
    '            SqlCommand1.Connection = Sqlconnection1
    '            SqlCommand1.CommandText = strSqlQueryText
    '            Dim int1 As Integer = SqlCommand1.ExecuteNonQuery()
    '            If int1 = 0 Then
    '                Return False
    '            Else
    '                Return True
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
    '            Return False
    '        Finally
    '            Sqlconnection1.Close()
    '        End Try

    '    End Function


    Dim TotalValueOfDeliveryNote As Decimal = 0D
    Public Function CheckIfDeliveryHasAmount(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select DeliveryNoteNo, Isnull(TotalAfterDiscount,0) as TotalAfterDiscount from qry603_03DeliveryNoteItemsWithTotal where (Isnull(TotalAfterDiscount, 0) >= 0 and DeliveryNoteNo = '" & DeliveryNoteNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    If CheckIfNull(srStockReader.Item("TotalAfterDiscount")) = False Then
                        TotalValueOfDeliveryNote = srStockReader.Item("TotalAfterDiscount")
                    Else
                        TotalValueOfDeliveryNote = 0D
                    End If
                End While
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    '    Public Function GetNewVoucherNo(ByVal VoucherType As String, ByVal VoucherPrefix As String, ByVal VoucherString As String, ByVal VoucherMonth As Integer, ByVal VoucherYear As Integer) As String
    '        Dim strNewReceiptNo As String
    '        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
    '        Try
    '            If Sqlconnection1.State = ConnectionState.Closed Then
    '                Sqlconnection1.Open()
    '            End If

    '            Dim SqlCommand1 As New SqlClient.SqlCommand
    '            SqlCommand1.Connection = Sqlconnection1
    '            ' SqlCommand1.CommandText = "select max(cast(RIGHT(VoucherNo, 3) as int)) from tbl201VoucherMaster WHERE VoucherNo like '" & VoucherPrefix & "%' and month(VoucherDate) = '" & VoucherMonth & "' and year(voucherdate) = '" & VoucherYear & "'"
    '            SqlCommand1.CommandText = "select max(cast(RIGHT(VoucherNo, 3) as int)) from tbl201VoucherMaster WHERE VoucherNo like '" & VoucherString & "%'"

    '            Dim int1 As Integer
    '            int1 = SqlCommand1.ExecuteScalar()
    '            int1 = int1 + 1

    '            strNewReceiptNo = "0000" & CStr(int1)
    '            strNewReceiptNo = Microsoft.VisualBasic.Right(strNewReceiptNo, 3)
    '            strNewReceiptNo = VoucherString & strNewReceiptNo

    '            Return strNewReceiptNo

    '        Catch ex As System.InvalidCastException
    '            strNewReceiptNo = VoucherString & "001"
    '            Return strNewReceiptNo
    '        Finally
    '            Sqlconnection1.Close()
    '        End Try
    '    End Function
    '#End Region


#Region "Journal Posting to Inventory Account Books"

    Private Sub btnPostToBooks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPostToBooks.ItemClick
        'Check if the JV is entered already using VoucherRefNO
        If CheckIfDeliveryAlreadyPosted(Me.txtDeliveryNoteNo.EditValue) = True Then
            MessageBox.Show("This Delivery Note is already posted to your ledgers.", "Delivery Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Check the Selection of Income ledger and Cost Center Ledger

        'Select the Details Page
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        CheckPostingErrors()
        If DxErrorProvider2.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
            MessageBox.Show("Cannot continue Post Journal Entry with errors, please clear the errors and continue.", "Clear Errors", MessageBoxButtons.OK)
            Exit Sub
        End If

        'Check if the Delivery Note has Amount to Post
        If CheckIfDeliveryHasNoAmount(Me.txtDeliveryNoteNo.EditValue) = True Then
            MessageBox.Show("This Delivery has no amount to be posted, Please review the Delivery Note again.", "No Amount to post", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If CheckIfNull(Me.txtDeliveryNoteNo.EditValue) = False Then
                'Save the Entry
                SaveAll(False)

                'Check if Delivery Type is Store Consumption
                '
                If Me.txtDeliveryType.EditValue = 2 Then
                    Me.PostStoreConsumptionDeliveryJournal(Me.txtDeliveryNoteNo.EditValue, Me.txtDeliveryNoteDate.EditValue, Me.strLogonUser)
                    UpdatePosted(True, Me.strLogonUser, Me.txtDeliveryNoteNo.EditValue)
                End If

                'Check if Delivery Type is Store Transfer
                'If Me.txtDeliveryType.EditValue = 4 Then
                '    Me.PostDeliveryJournal(Me.txtDeliveryNoteNo.EditValue, VoucherNo)
                '    UpdatePosted(True, Me.strLogonUser, Me.txtDeliveryNoteNo.EditValue, VoucherNo)
                'End If

                'Check if Delivery Type is Issued to Projects
                If Me.txtDeliveryType.EditValue = 3 Then
                    Me.PostProjectDeliveryJournal(Me.txtDeliveryNoteNo.EditValue, Me.txtDeliveryNoteDate.EditValue, Me.strLogonUser)
                    UpdatePosted(True, Me.strLogonUser, Me.txtDeliveryNoteNo.EditValue)
                End If

                'Check if the Voucher is Posted already
                If CheckIfDeliveryNoteIsApproved(Me.txtDeliveryNoteNo.EditValue) = False Then
                    btnApprove_ItemClick(sender, e)
                End If


                MessageBox.Show("Delivery Note has been posted to the Accounting Books.", "Delivery Note Posted Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Refresh the datagrid
                RefreshMasterDataGrid()

                Me.Close()

            Else
                'MessageBox.Show("Please select the Journal Posting to proceed.", "Select Posting for.", MessageBoxButtons.OK)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Function CheckIfDeliveryAlreadyPosted(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select VoucherNo from tbl201VoucherMaster where (DeliveryNoteNo = '" & DeliveryNoteNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function


    Public Function CheckIfDeliveryHasNoAmount(ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            'SELECT DeliveryNoteNo, SUM(ISNULL(CostPriceTotal, 0)) AS CostPriceTotal FROM dbo.qry603_15DeliveryNoteToJournal GROUP BY DeliveryNoteNo HAVING (DeliveryNoteNo = 'HSM-MIP-2021-0002') AND (SUM(ISNULL(CostPriceTotal, 0)) <= 0)
            'strSqlQueryText = "Select DeliveryNoteNo, Isnull(CostPriceTotal,0) as CostPriceTotal from qry603_15DeliveryNoteToJournal where (Isnull(CostPriceTotal, 0) <= 0 and DeliveryNoteNo = '" & DeliveryNoteNo & "')"
            strSqlQueryText = "SELECT DeliveryNoteNo, SUM(ISNULL(CostPriceTotal, 0)) AS CostPriceTotal FROM dbo.qry603_15DeliveryNoteToJournal GROUP BY DeliveryNoteNo HAVING (DeliveryNoteNo = '" & DeliveryNoteNo & "') AND (SUM(ISNULL(CostPriceTotal, 0)) <= 0)"


            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Public Sub PostStoreConsumptionDeliveryJournal(ByVal DeliveryNoteNo As String, ByVal DeliveryNoteDate As Date, ByVal UserLogOn As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_30InsertJVfromDNForStoreConsumption"
            SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar).Value = DeliveryNoteNo
            SqlCommand1.Parameters.Add("@DeliveryNoteDate", SqlDbType.SmallDateTime).Value = DeliveryNoteDate
            SqlCommand1.Parameters.Add("@JustAddedVoucherEntryNoSubLedger", SqlDbType.Int).Value = 0
            SqlCommand1.Parameters.Add("@JustAddedVoucherEntryNoCostAlloc", SqlDbType.Int).Value = 0
            SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar).Value = UserLogOn
            SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime).Value = Date.Now

            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)

        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public Sub PostProjectDeliveryJournal(ByVal DeliveryNoteNo As String, ByVal DeliveryNoteDate As Date, ByVal UserLogOn As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_29InsertJVfromDeliveryNote"
            SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar).Value = DeliveryNoteNo
            SqlCommand1.Parameters.Add("@DeliveryNoteDate", SqlDbType.SmallDateTime).Value = DeliveryNoteDate
            SqlCommand1.Parameters.Add("@JustAddedVoucherEntryNoSubLedger", SqlDbType.Int).Value = 0
            SqlCommand1.Parameters.Add("@JustAddedVoucherEntryNoCostAlloc", SqlDbType.Int).Value = 0
            SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar).Value = UserLogOn
            SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime).Value = Date.Now

            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)

        Finally
            Sqlconnection1.Close()
        End Try
    End Sub


    Public Function UpdatePosted(ByVal IsPosted As Boolean, ByVal PostedBy As String, ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl603_01DeliveryNoteMaster Set IsPosted = '" & IsPosted & "', PostedBy = '" & PostedBy & "', PostedOn = Getdate(), VoucherNo = '" & DeliveryNoteNo & "' where DeliveryNoteNo = '" & DeliveryNoteNo & "'"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim int1 As Integer = SqlCommand1.ExecuteNonQuery()
            If int1 = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function


#End Region


    Private Sub btnApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnApprove.ItemClick

        Try
            If UpdateApproved(True, Me.strLogonUser, Me.txtDeliveryNoteNo.EditValue) = True Then
                MessageBox.Show("Delivery Note / Material Issue Note has been Approved.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Disable all controls
                Me.DisableApprovedVoucherEditing(Me.txtDeliveryNoteNo.EditValue)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function UpdateApproved(ByVal IsApproved As Boolean, ByVal ApprovedBy As String, ByVal DeliveryNoteNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl603_01DeliveryNoteMaster Set IsApproved = '" & IsApproved & "', ApprovedBy = '" & ApprovedBy & "', ApprovedOn = Getdate() where DeliveryNoteNo = '" & DeliveryNoteNo & "'"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim int1 As Integer = SqlCommand1.ExecuteNonQuery()
            If int1 = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Sub txtIssuedToProject_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtIssuedToProject.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm700_07ProjectsSimpleEditForm As New frm700_07ProjectsSimpleEditForm
            frm700_07ProjectsSimpleEditForm.ObjForm = Me
            frm700_07ProjectsSimpleEditForm.Show()
            frm700_07ProjectsSimpleEditForm.txtProjectGroup.Focus()
            frm700_07ProjectsSimpleEditForm.isExecutedFrom_frm601_05DeliveryNoteEdit = True
        End If
    End Sub

    Private Sub txtDeliveryNoteDate_Leave(sender As Object, e As EventArgs) Handles txtDeliveryNoteDate.Leave
        'DATE BLOCKING
        GetCompanyDetails02(1)
        If gIsDateLockingEnabled = True Then
            If CheckIfNull(Me.txtDeliveryNoteDate.EditValue) = True Then
                Me.txtDeliveryNoteDate.EditValue = Date.Today()
            End If

            If CheckIfDateBeenLocked("IMS_DELIVERY", Me.txtDeliveryNoteDate.EditValue) = True Then
                MessageBox.Show("This Delivery Note Entry date has been blocked." & vbCrLf & "Please review your entry date.", "Entry Date is Blocked", MessageBoxButtons.OK)
                Me.txtDeliveryNoteDate.EditValue = Me.txtDeliveryNoteDate.OldEditValue
                Me.txtDeliveryNoteDate.Focus()
                Exit Sub
            End If
        End If
    End Sub


#Region "Populate Custom Report Buttons"
    'Change this code for other forms.. 
    Dim CustomReportFormNo As Integer = 5

    Public Sub PopulateCustomReportButtons(ByVal CustomReportFormNo As Integer)

        GetCustomReportNo(CustomReportFormNo, barSubItemCustomReportDesigns)

    End Sub

    Public Sub RemoveAllButtonsInSubItem()

        barSubItemCustomReportDesigns.ClearLinks()
    End Sub

    Public Function GetCustomReportNo(ByVal CustomReportFormNo As Integer, ByVal subitem As DevExpress.XtraBars.BarSubItem)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReportNo, ReportNo + ' - ' + buttontext as ButtonText from tbl90112ReportAttributes where CustomReportFormNo = '" & CustomReportFormNo & "'"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            Dim intCounter As Integer = 0

            Dim ReportNo As String = ""
            Dim ButtonText As String = ""

            While srStockReader.Read()
                'Run the code for creating button
                ReportNo = srStockReader.Item("ReportNo") & ""
                ButtonText = srStockReader.Item("buttontext") & ""

                Dim btnCustomReport1 As New BarButtonItem
                CreateBarButtonItems(ReportNo, ButtonText, btnCustomReport1, subitem)

            End While
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return 0
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Sub CreateBarButtonItems(ByVal ButtonName As String, ByVal ButtonText As String, ByVal ButtonItem As BarButtonItem, ByVal subitem As DevExpress.XtraBars.BarSubItem)

        ButtonItem.Caption = ButtonText
        ButtonItem.Id = BarManager1.GetNewItemId()
        ButtonItem.Name = ButtonName
        ButtonItem.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        ButtonItem.ItemAppearance.Normal.Options.UseFont = True
        ButtonItem.ImageOptions.Image = My.Resources.DailyRpt32x32

        AddHandler ButtonItem.ItemClick, AddressOf btnCustomReport1_ItemClick
        subitem.AddItem(ButtonItem)

    End Sub

    Private Sub btnCustomReport1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        OpenReport(e.Item.Name, CustomReportFormNo)
    End Sub

    Private Sub OpenReport(ByVal ReportNo As String, ByVal CustomReportFormNo As Integer)
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_03DeliveryNoteFormat01

            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = ReportNo
            Dim frm1 As New frm999_03ReportPreviewIMS_DeliveryNote

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            rpt1.Qry603_05DeliveryNoteReportTableAdapter.FillByDeliveryNoteNo(rpt1.DsRpt601_03DeliveryNoteReport1.qry603_05DeliveryNoteReport, Me.txtDeliveryNoteNo.EditValue)

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)

                    Exit For
                End If
            Next

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue

            rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
            rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "DeliveryNoteNo_" & Me.txtDeliveryNoteNo.EditValue & "_" & Me.txtClientName.Text

            If Not CheckIfNull(Me.txtShowLineItemNo.EditValue) Then
                If Me.txtShowLineItemNo.EditValue = True Then
                    rpt1.ShowLineItemNo = True
                Else
                    rpt1.ShowLineItemNo = False
                End If
            End If

            If Not CheckIfNull(Me.txtIsPrintAtBottom.EditValue) Then
                If Me.txtIsPrintAtBottom.EditValue = True Then
                    rpt1.IsPrintFooterAtBottom = True
                Else
                    rpt1.IsPrintFooterAtBottom = False
                End If
            End If


            rpt1.RequestParameters = False
            '-------------------------------------
            ' New Report Design Code Starts here
            '-------------------------------------
            frm1.ReportCode = ReportCode
            frm1.DocumentViewer1.DocumentSource = rpt1
            rpt1.DisplayName = ReportCode
            frm1.ReportName = rpt1
            frm1.intLogOnUserID = Me.intLogOnUserID
            frm1.strLogonUser = Me.strLogonUser
            frm1.intCustomReportFormNo = CustomReportFormNo
            frm1.objForm = Me
            frm1.Show()
            '-------------------------------------
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtStoreIssuedFrom_Validated(sender As Object, e As EventArgs) Handles txtStoreIssuedFrom.Validated
        If selectedDeliveryType = 4 Or selectedDeliveryType = 3 Or selectedDeliveryType = 2 Then
            GetCompanyDetails02(1)
            If gIsStoreWiseDelivery = True Then
                Try
                    Dim EndDate As Date = Me.txtDeliveryNoteDate.EditValue
                    Me.InsertStoreInventoryValueByDate("2001-01-01", EndDate.AddHours(23))
                    Me.Qry653_20StoreStockBalanceWtStoreCodeTableAdapter.FillByStoreCode(Me.Dsfrm601_01QuotationEdit1.qry653_20StoreStockBalanceWtStoreCode, Me.txtStoreIssuedFrom.EditValue)

                    Me.colDetailedDescription.Visible = False

                    Me.colStockDescriptionWtStores.VisibleIndex = 3
                    Me.colStockDescriptionWtStores.Visible = True

                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Public Sub InsertStoreInventoryValueByDate(ByVal StartDate As Date, ByVal EndDate As Date)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp653_01InsertStoreInvTransByDate"
            Dim paramStartDate As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@StartDate", SqlDbType.DateTime)
            Dim paramEndDate As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@EndDate", SqlDbType.DateTime)

            paramStartDate.Value = StartDate
            paramEndDate.Value = EndDate
            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            'MessageBox.Show("Quotation Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnUseItemDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60302DeliveryNoteChildBindingSource1.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.EditValue = GetGSCodeDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUseItemDetailedDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDetailedDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60302DeliveryNoteChildBindingSource1.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.EditValue = GetGSCodeDetailedDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

#End Region



End Class