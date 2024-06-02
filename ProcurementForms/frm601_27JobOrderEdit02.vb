Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraReports.UI

Imports System.Drawing
Imports DevExpress.XtraPrinting.Drawing

Public Class frm601_27JobOrderEdit02
    Public isBeingUpdated As Boolean = False
    Public isBeingNew As Boolean = False
    Public isControlsModified As Boolean

    Public ObjForm As Object
    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Public isExecutedFrom_frm601_28JobOrdersView As Boolean = False
    
    Private Sub frm601_27JobOrderEdit02_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Tbl608_06JobOrderStatusMasterTableAdapter.Fill(Me.Dsfrm601_27JobOrderEdit.tbl608_06JobOrderStatusMaster)

        Me.Tbl901CompanyDetailsTableAdapter.Fill(Me.Dsfrm601_27JobOrderEdit.tbl901CompanyDetails)

        Me.Tbl30101ClientMasterTableAdapter.Fill(Me.Dsfrm601_27JobOrderEdit2.tbl30101ClientMaster)
        
        'Retrieve Panel Layout
        'LoadLayoutFromDB(Me.intLogOnUserID, "frm601_03SalesOrderEdit", Me.gvInvoiceChild)

    End Sub

    Public Sub DisableControlsByStatus(ByVal StatusID As Integer)

        If StatusID = 1 Then
            Me.txtJobOrderDate.Enabled = False
            Me.txtClientName.Enabled = False
            Me.txtWorkOrderNo.Enabled = False
            Me.txtJobOrderStatus.Enabled = False
            'JO Attributes
            Me.txtType.Enabled = False
            Me.txtOperator.Enabled = False
            Me.txtModelNo.Enabled = False
            Me.txtClientWorkOrderNo.Enabled = False
            Me.txtSize.Enabled = False
            Me.txtMaterial.Enabled = False
            Me.txtTagNo.Enabled = False
            Me.txtClientProject.Enabled = False
            Me.txtClass.Enabled = False
            Me.txtMake.Enabled = False
            Me.txtSerialNo.Enabled = False
            Me.txtValveType.Enabled = False
            Me.txtDetailedDescription.Enabled = False

            ' JO Observation Report
            Me.txtObservationDate.Enabled = False
            Me.txtInitialObsrvRemarks.Enabled = False
            Me.txtObsrvPreparedBy.Enabled = False
            Me.txtObsrvPreparedOn.Enabled = False
            Me.txtObsrvApprovedBy.Enabled = False
            Me.txtObsrvApprovedOn.Enabled = False
            Me.btnApproveInitialObservation.Enabled = False

            ' JO Inspection Report
            Me.txtInspectionDate.Enabled = False
            Me.txtPreTested.Enabled = False
            Me.txtScope.Enabled = False
            Me.txtInspectionRemarks.Enabled = False
            Me.txtInspectionPreparedBy.Enabled = False
            Me.txtInspectionPreparedOn.Enabled = False
            Me.txtInspectionApprovedBy.Enabled = False
            Me.txtInspectionApprovedOn.Enabled = False
            Me.btnApproveVisualInspection.Enabled = False

            'Jo Repair Report
            Me.grpFinalTestResult.Enabled = False
            Me.grpFinalTestSignatory.Enabled = False
            Me.btnApproveRepairReport.Enabled = False


            'Jo Dispatch Report
            Me.grpDispatchReport.Enabled = False
            Me.btnApproveDispatchReport.Enabled = False

        End If

        If StatusID = 2 Then
            Me.txtJobOrderDate.Enabled = False
            Me.txtClientName.Enabled = False
            Me.txtWorkOrderNo.Enabled = False
            Me.txtJobOrderStatus.Enabled = False
            'JO Attributes
            Me.txtType.Enabled = False
            Me.txtOperator.Enabled = False
            Me.txtModelNo.Enabled = False
            Me.txtClientWorkOrderNo.Enabled = False
            Me.txtSize.Enabled = False
            Me.txtMaterial.Enabled = False
            Me.txtTagNo.Enabled = False
            Me.txtClientProject.Enabled = False
            Me.txtClass.Enabled = False
            Me.txtMake.Enabled = False
            Me.txtSerialNo.Enabled = False
            Me.txtValveType.Enabled = False
            Me.txtDetailedDescription.Enabled = False

            ' JO Observation Report
            Me.txtObservationDate.Enabled = False
            Me.txtInitialObsrvRemarks.Enabled = False
            Me.txtObsrvPreparedBy.Enabled = False
            Me.txtObsrvPreparedOn.Enabled = False
            Me.txtObsrvApprovedBy.Enabled = False
            Me.txtObsrvApprovedOn.Enabled = False
            Me.btnApproveInitialObservation.Enabled = False

            ' JO Inspection Report
            Me.txtInspectionDate.Enabled = False
            Me.txtPreTested.Enabled = False
            Me.txtScope.Enabled = False
            Me.txtInspectionRemarks.Enabled = False
            Me.txtInspectionPreparedBy.Enabled = False
            Me.txtInspectionPreparedOn.Enabled = False
            Me.txtInspectionApprovedBy.Enabled = False
            Me.txtInspectionApprovedOn.Enabled = False
            Me.btnApproveVisualInspection.Enabled = False

            'Jo Repair Report
            Me.grpFinalTestResult.Enabled = False
            Me.grpFinalTestSignatory.Enabled = False
            Me.btnApproveRepairReport.Enabled = False

            'Jo Dispatch Report
            Me.grpDispatchReport.Enabled = False
            Me.btnApproveDispatchReport.Enabled = False

        End If


        If StatusID = 3 Then
            Me.txtJobOrderDate.Enabled = False
            Me.txtClientName.Enabled = False
            Me.txtWorkOrderNo.Enabled = False
            Me.txtJobOrderStatus.Enabled = False
            'JO Attributes
            Me.txtType.Enabled = False
            Me.txtOperator.Enabled = False
            Me.txtModelNo.Enabled = False
            Me.txtClientWorkOrderNo.Enabled = False
            Me.txtSize.Enabled = False
            Me.txtMaterial.Enabled = False
            Me.txtTagNo.Enabled = False
            Me.txtClientProject.Enabled = False
            Me.txtClass.Enabled = False
            Me.txtMake.Enabled = False
            Me.txtSerialNo.Enabled = False
            Me.txtValveType.Enabled = False
            Me.txtDetailedDescription.Enabled = False

            ' JO Observation Report
            Me.txtObservationDate.Enabled = False
            Me.txtInitialObsrvRemarks.Enabled = False
            Me.txtObsrvPreparedBy.Enabled = False
            Me.txtObsrvPreparedOn.Enabled = False
            Me.txtObsrvApprovedBy.Enabled = False
            Me.txtObsrvApprovedOn.Enabled = False
            Me.btnApproveInitialObservation.Enabled = False

            ' JO Inspection Report
            Me.txtInspectionDate.Enabled = True
            Me.txtPreTested.Enabled = True
            Me.txtScope.Enabled = True
            Me.txtInspectionRemarks.Enabled = True
            Me.txtInspectionPreparedBy.Enabled = True
            Me.txtInspectionPreparedOn.Enabled = True
            Me.txtInspectionApprovedBy.Enabled = True
            Me.txtInspectionApprovedOn.Enabled = True
            Me.btnApproveVisualInspection.Enabled = True

            'Jo Repair Report
            Me.grpFinalTestResult.Enabled = False
            Me.grpFinalTestSignatory.Enabled = False
            Me.btnApproveRepairReport.Enabled = False

            'Jo Dispatch Report
            Me.grpDispatchReport.Enabled = False
            Me.btnApproveDispatchReport.Enabled = False

        End If

        If StatusID = 4 Then
            Me.txtJobOrderDate.Enabled = False
            Me.txtClientName.Enabled = False
            Me.txtWorkOrderNo.Enabled = False
            Me.txtJobOrderStatus.Enabled = False
            'JO Attributes
            Me.txtType.Enabled = False
            Me.txtOperator.Enabled = False
            Me.txtModelNo.Enabled = False
            Me.txtClientWorkOrderNo.Enabled = False
            Me.txtSize.Enabled = False
            Me.txtMaterial.Enabled = False
            Me.txtTagNo.Enabled = False
            Me.txtClientProject.Enabled = False
            Me.txtClass.Enabled = False
            Me.txtMake.Enabled = False
            Me.txtSerialNo.Enabled = False
            Me.txtValveType.Enabled = False
            Me.txtDetailedDescription.Enabled = False

            ' JO Observation Report
            Me.txtObservationDate.Enabled = False
            Me.txtInitialObsrvRemarks.Enabled = False
            Me.txtObsrvPreparedBy.Enabled = False
            Me.txtObsrvPreparedOn.Enabled = False
            Me.txtObsrvApprovedBy.Enabled = False
            Me.txtObsrvApprovedOn.Enabled = False
            Me.btnApproveInitialObservation.Enabled = False

            ' JO Inspection Report
            Me.txtInspectionDate.Enabled = False
            Me.txtPreTested.Enabled = False
            Me.txtScope.Enabled = False
            Me.txtInspectionRemarks.Enabled = False
            Me.txtInspectionPreparedBy.Enabled = False
            Me.txtInspectionPreparedOn.Enabled = False
            Me.txtInspectionApprovedBy.Enabled = False
            Me.txtInspectionApprovedOn.Enabled = False
            Me.btnApproveVisualInspection.Enabled = False

            'Jo Repair Report
            Me.grpFinalTestResult.Enabled = True
            Me.grpFinalTestSignatory.Enabled = True
            Me.btnApproveRepairReport.Enabled = True

            'Jo Dispatch Report
            Me.grpDispatchReport.Enabled = False
            Me.btnApproveDispatchReport.Enabled = False

        End If

        If StatusID = 5 Then
            Me.txtJobOrderDate.Enabled = False
            Me.txtClientName.Enabled = False
            Me.txtWorkOrderNo.Enabled = False
            Me.txtJobOrderStatus.Enabled = False
            'JO Attributes
            Me.txtType.Enabled = False
            Me.txtOperator.Enabled = False
            Me.txtModelNo.Enabled = False
            Me.txtClientWorkOrderNo.Enabled = False
            Me.txtSize.Enabled = False
            Me.txtMaterial.Enabled = False
            Me.txtTagNo.Enabled = False
            Me.txtClientProject.Enabled = False
            Me.txtClass.Enabled = False
            Me.txtMake.Enabled = False
            Me.txtSerialNo.Enabled = False
            Me.txtValveType.Enabled = False
            Me.txtDetailedDescription.Enabled = False

            ' JO Observation Report
            Me.txtObservationDate.Enabled = False
            Me.txtInitialObsrvRemarks.Enabled = False
            Me.txtObsrvPreparedBy.Enabled = False
            Me.txtObsrvPreparedOn.Enabled = False
            Me.txtObsrvApprovedBy.Enabled = False
            Me.txtObsrvApprovedOn.Enabled = False
            Me.btnApproveInitialObservation.Enabled = False

            ' JO Inspection Report
            Me.txtInspectionDate.Enabled = False
            Me.txtPreTested.Enabled = False
            Me.txtScope.Enabled = False
            Me.txtInspectionRemarks.Enabled = False
            Me.txtInspectionPreparedBy.Enabled = False
            Me.txtInspectionPreparedOn.Enabled = False
            Me.txtInspectionApprovedBy.Enabled = False
            Me.txtInspectionApprovedOn.Enabled = False
            Me.btnApproveVisualInspection.Enabled = False

            'Jo Repair Report
            Me.grpFinalTestResult.Enabled = False
            Me.grpFinalTestSignatory.Enabled = False
            Me.btnApproveRepairReport.Enabled = False

            'Jo Dispatch Report
            Me.grpDispatchReport.Enabled = True
            Me.btnApproveDispatchReport.Enabled = True

        End If

        If StatusID = 6 Then
            Me.txtJobOrderDate.Enabled = True
            Me.txtClientName.Enabled = True
            Me.txtWorkOrderNo.Enabled = True
            Me.txtJobOrderStatus.Enabled = False
            'JO Attributes
            Me.txtType.Enabled = True
            Me.txtOperator.Enabled = True
            Me.txtModelNo.Enabled = True
            Me.txtClientWorkOrderNo.Enabled = True
            Me.txtSize.Enabled = True
            Me.txtMaterial.Enabled = True
            Me.txtTagNo.Enabled = True
            Me.txtClientProject.Enabled = True
            Me.txtClass.Enabled = True
            Me.txtMake.Enabled = True
            Me.txtSerialNo.Enabled = True
            Me.txtValveType.Enabled = True
            Me.txtDetailedDescription.Enabled = True

            ' JO Observation Report
            Me.txtObservationDate.Enabled = True
            Me.txtInitialObsrvRemarks.Enabled = True
            Me.txtObsrvPreparedBy.Enabled = True
            Me.txtObsrvPreparedOn.Enabled = True
            Me.txtObsrvApprovedBy.Enabled = True
            Me.txtObsrvApprovedOn.Enabled = True
            Me.btnApproveInitialObservation.Enabled = True

            ' JO Inspection Report
            Me.txtInspectionDate.Enabled = False
            Me.txtPreTested.Enabled = False
            Me.txtScope.Enabled = False
            Me.txtInspectionRemarks.Enabled = False
            Me.txtInspectionPreparedBy.Enabled = False
            Me.txtInspectionPreparedOn.Enabled = False
            Me.txtInspectionApprovedBy.Enabled = False
            Me.txtInspectionApprovedOn.Enabled = False
            Me.btnApproveVisualInspection.Enabled = False

            'Jo Repair Report
            Me.grpFinalTestResult.Enabled = False
            Me.grpFinalTestSignatory.Enabled = False
            Me.btnApproveRepairReport.Enabled = False

            'Jo Dispatch Report
            Me.grpDispatchReport.Enabled = False
            Me.btnApproveDispatchReport.Enabled = False

        End If

    End Sub




    Public Sub UpdateDefaultFields()
        'Select the Details Page
        For i As Integer = 0 To tabControlObservation.TabPages.Count - 1
            If tabControlObservation.TabPages(i).Name = "pageCompanyDetails" Then
                tabControlObservation.SelectedTabPage = tabControlObservation.TabPages(i)
                If Me.intLogOnDivision = 99 Then
                    Me.txtCompanyID.EditValue = 1
                Else
                    Me.txtCompanyID.EditValue = Me.intLogOnDivision
                End If


                Exit For
            End If

        Next

        For i As Integer = 0 To tabControlObservation.TabPages.Count - 1
            If tabControlObservation.TabPages(i).Name = "pageJobOrderDetails" Then
                tabControlObservation.SelectedTabPage = tabControlObservation.TabPages(i)
            End If
        Next

    End Sub

    Public Sub DisableAllControls()

        'Me.btnResetLayout.Enabled = False
        'Me.btnSetDefaultLayout.Enabled = False
        'Me.btnMoveUp.Enabled = False
        'Me.btnMoveDown.Enabled = False
        'Me.btnSave.Enabled = False
        'Me.btnSaveAndClose.Enabled = False
        'Me.btnPreviewPO.Enabled = True
        'Me.btnPreviewPOwoVAT2.Enabled = True
        'Me.btnPreviewPOWoVAT.Enabled = True
        'Me.btnPreviewPOinFC.Enabled = True
        'Me.btnDelete.Enabled = False
        'Me.btnAddNewLineItem.Enabled = False
        'Me.btnAddLineItem.Enabled = False
        'Me.btnTerms.Enabled = False
        'Me.btnAttachments.Enabled = True
        'Me.btnSubmit.Enabled = False
        'Me.btnVerify.Enabled = False
        'Me.btnApprove.Enabled = False
        'Me.btnBack.Enabled = True
        'Me.btnDeleteLineItem.Enabled = False
        'Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = False
        'Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = False

        'Me.cmdEditContacts.Enabled = False
        'Me.btnDefaultSubject.Enabled = False
        'Me.btnDefaultIntro.Enabled = False
        'Me.btnDefaultSummary.Enabled = False
        'Me.btnDefaultThanks.Enabled = False
        'Me.btnFillSubject.Enabled = False
        'Me.btnFillPOIntroduction.Enabled = False
        'Me.btnFillPOSummary.Enabled = False
        'Me.btnFillThanksNote.Enabled = False
        'Me.txtSignatory.Properties.Buttons.Item(1).Enabled = False

        'Me.txtCurrency.Properties.Buttons.Item(1).Enabled = False
        'Me.btnDefaultShipTo.Enabled = False
        'Me.btnDefaultBillTo.Enabled = False
        'Me.btnFillShipTo.Enabled = False
        'Me.btnFillBillTo.Enabled = False


        'Me.groupCompanyBranch.Enabled = False
        'Me.groupCurrency.Enabled = False
        'Me.groupShipments.Enabled = False
        'Me.groupShipping.Enabled = False
        'Me.groupTerms.Enabled = False
        'Me.panelPODetails.Enabled = False

        'Me.txtSignatory.Enabled = False
        'Me.txtVerifiedSign.Enabled = False
        'Me.txtApprovedSign.Enabled = False

        'Me.gcInvoiceChild.Enabled = False
        'Me.txtSubject.Enabled = False
        'Me.txtQuoteIntro.Enabled = False
        'Me.txtQuoteSummary.Enabled = False
        'Me.txtQuoteThanksNote.Enabled = False

    End Sub

    Public Sub EnableAllControls()

        'Me.btnResetLayout.Enabled = True
        'Me.btnSetDefaultLayout.Enabled = True
        'Me.btnMoveUp.Enabled = True
        'Me.btnMoveDown.Enabled = True
        'Me.btnSave.Enabled = True
        'Me.btnSaveAndClose.Enabled = True
        'Me.btnPreviewPO.Enabled = True
        'Me.btnPreviewPOwoVAT2.Enabled = True
        'Me.btnPreviewPOWoVAT.Enabled = True
        'Me.btnPreviewPOinFC.Enabled = True
        'Me.btnDelete.Enabled = True
        'Me.btnAddNewLineItem.Enabled = True
        'Me.btnAddLineItem.Enabled = True
        'Me.btnTerms.Enabled = True
        'Me.btnAttachments.Enabled = True
        'Me.btnSubmit.Enabled = True
        'Me.btnVerify.Enabled = True
        'Me.btnApprove.Enabled = True
        'Me.btnBack.Enabled = True
        'Me.btnDeleteLineItem.Enabled = True
        'Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = True
        'Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = True

        'Me.cmdEditContacts.Enabled = True
        'Me.btnDefaultSubject.Enabled = True
        'Me.btnDefaultIntro.Enabled = True
        'Me.btnDefaultSummary.Enabled = True
        'Me.btnDefaultThanks.Enabled = True
        'Me.btnFillSubject.Enabled = True
        'Me.btnFillPOIntroduction.Enabled = True
        'Me.btnFillPOSummary.Enabled = True
        'Me.btnFillThanksNote.Enabled = True
        'Me.txtSignatory.Properties.Buttons.Item(1).Enabled = True

        'Me.txtCurrency.Properties.Buttons.Item(1).Enabled = True
        'Me.btnDefaultShipTo.Enabled = True
        'Me.btnDefaultBillTo.Enabled = True
        'Me.btnFillShipTo.Enabled = True
        'Me.btnFillBillTo.Enabled = True


        'Me.groupCompanyBranch.Enabled = True
        'Me.groupCurrency.Enabled = True
        'Me.groupShipments.Enabled = True
        'Me.groupShipping.Enabled = True
        'Me.groupTerms.Enabled = True
        'Me.panelPODetails.Enabled = True

        'Me.txtSignatory.Enabled = True
        'Me.txtVerifiedSign.Enabled = True
        'Me.txtApprovedSign.Enabled = True

        'Me.gcInvoiceChild.Enabled = True
        'Me.txtSubject.Enabled = True
        'Me.txtQuoteIntro.Enabled = True
        'Me.txtQuoteSummary.Enabled = True
        'Me.txtQuoteThanksNote.Enabled = True

    End Sub

    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtJobOrderNo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtJobOrderNo, "Job Order Number Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtJobOrderNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtJobOrderDate.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtJobOrderDate, "Job Order Date must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtJobOrderDate, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtClientName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtClientName, "Client must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtClientName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

    End Sub

    Public Sub RetrieveJobOrderMaster(ByVal JobOrderNo As String)
        Try
            If CheckIfNull(JobOrderNo) = False Then
                'fill master details
                Me.Tbl608_01JobOrderMasterTableAdapter.FillByJobOrderNo(Me.Dsfrm601_27JobOrderEdit.tbl608_01JobOrderMaster, JobOrderNo)

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Job Order Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateJobOrderMaster(ByVal JobOrderNo As String, ByVal WithMessage As Boolean)
        If CheckIfNull(JobOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60801JobOrderMasterBindingSource.Current, DataRowView)
            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            Me.Tbl60801JobOrderMasterBindingSource.EndEdit()
            Me.Tbl608_01JobOrderMasterTableAdapter.Update(Me.Dsfrm601_27JobOrderEdit.tbl608_01JobOrderMaster)

            If WithMessage = True Then
                MessageBox.Show("Job Order Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSaveAndClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
        cmdSave_Click(sender, e)
        Me.close()

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
            UpdateJobOrderMaster(Me.txtJobOrderNo.EditValue, WithMessage)
            Me.btnSave.Caption = "Update"

            'ElseIf Me.btnSave.Caption = "Save" Then
            '    If Me.isBeingNew = True Then
            '        SaveNewSalesOrderMaster(Me.txtJobOrderNo.EditValue)
            '        Me.btnSave.Caption = "Update"
            '    End If
        End If

        Try

            ''Update the Data in the Child
            'Me.Qry60202SalesOrderChildBindingSource.EndEdit()
            'Me.Qry602_02SalesOrderChildTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild)
            'Me.Qry602_02SalesOrderChildTableAdapter.FillByOrder(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild, Me.txtSalesOrderNo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshMasterDataGrid()
    End Sub

    Private Sub RefreshMasterDataGrid()
        'isExecutedFrom_frm601_28JobOrdersView

        If isExecutedFrom_frm601_28JobOrdersView = True Then
            Try
                CType(ObjForm, frm601_28JobOrdersView).RetrieveVoucher(CType(ObjForm, frm601_28JobOrdersView).txtStartDate.EditValue, CType(ObjForm, frm601_28JobOrdersView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_28JobOrdersView).gvAdvBandedQuotationView, "JobOrderNo", Me.txtJobOrderNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Job Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.ItemClick
        If isControlsModified = True Then
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("Job Order Details have been edited, would you like to save changes?", "Save Changes?", MessageBoxButtons.YesNoCancel)

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

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            'Check if the Voucher is approved already
            If CheckIfJobOrderIsApproved(Me.txtJobOrderNo.EditValue) = True Then
                MessageBox.Show("Job Order is already approved, You cannot delete the Approved Job Order", "Job Order Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Job Order from the Register," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
                    If DeleteJobOrder(Me.txtJobOrderNo.EditValue) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.txtJobOrderNo.EditValue, "VoucherScanned\IMSJO")

                        MessageBox.Show("Job Order has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Refresh the datagrid
                        Me.RefreshMasterDataGrid()
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

    Private Function CheckIfJobOrderIsApproved(ByVal JobOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select JobOrderNo from tbl608_01JobOrderMaster where (JobOrderNo = '" & JobOrderNo & "') and (Isnull(IsApproved,0) = 1 )"

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
    Private Function DeleteJobOrder(ByVal JobOrderNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl608_01JobOrderMaster WHERE JobOrderNo   = '" & JobOrderNo & "'"
            delPRTrans.ExecuteNonQuery()
            myTrans.Commit()
            Return True

        Catch ex As Exception
            Try
                myTrans.Rollback("PRTransaction")
                Return False
            Catch Sqlex As System.Data.SqlClient.SqlException
                If Not myTrans.Connection Is Nothing Then
                    MessageBox.Show("An exception of type " & Sqlex.GetType().ToString() & _
                                      " was encountered while attempting to roll back the transaction.", "Error on Delete", MessageBoxButtons.OK)
                End If
                MessageBox.Show("An exception of type " & ex.GetType().ToString() & _
                                      "was encountered while inserting the data.")
                Return False
            End Try
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Public Sub DisableApprovedVoucherEditing(ByVal JobOrderNo As String)
        'Disable access if the voucher is already approved.
        'Get the IsVoucherIsApproved
        If CheckIfJobOrderIsApproved(JobOrderNo) = True Then
            Me.btnSave.Enabled = False
            Me.btnSaveAndClose.Enabled = False
            Me.btnDelete.Enabled = False
            'Me.btnVerify.Enabled = False
            'Me.btnApprove.Enabled = False

            Me.btnPrint.Enabled = True

        End If

        'Me.CheckIfPDFAvailable(voucherNo)
    End Sub

    Private Sub btnObservationReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
            Dim frm601_29JODocReport As New frm601_29JODocReport
            frm601_29JODocReport.txtConditionsCode.EditValue = "RCR-0001"
            frm601_29JODocReport.txtJobOrderNo.EditValue = Me.txtJobOrderNo.EditValue
            frm601_29JODocReport.txtJobOrderType.EditValue = "RCR"
            frm601_29JODocReport.FillDocumentConditions(Me.txtJobOrderNo.EditValue, "RCR")
            frm601_29JODocReport.Show()


        End If
    End Sub

    Private Sub btnInspectionReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInspectionReport.ItemClick
        If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
            Dim frm601_31JobOrderTests As New frm601_31JobOrderTests
            frm601_31JobOrderTests.txtJobOrderNo.EditValue = Me.txtJobOrderNo.EditValue
            frm601_31JobOrderTests.txtJobOrderType.EditValue = "VIR"
            frm601_31JobOrderTests.txtValveType.EditValue = Me.txtValveType.EditValue

            frm601_31JobOrderTests.FillDocumentConditions(Me.txtJobOrderNo.EditValue)
            frm601_31JobOrderTests.Show()
            frm601_31JobOrderTests.colRequirements.Visible = True
            frm601_31JobOrderTests.colActionTaken.Visible = False

        End If
    End Sub

    Private Sub btnRepairReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepairReport.ItemClick
        If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
            Dim frm601_31JobOrderTests As New frm601_31JobOrderTests
            frm601_31JobOrderTests.txtJobOrderNo.EditValue = Me.txtJobOrderNo.EditValue
            frm601_31JobOrderTests.txtJobOrderType.EditValue = "VRR"
            frm601_31JobOrderTests.FillDocumentConditions(Me.txtJobOrderNo.EditValue)
            frm601_31JobOrderTests.Show()
            frm601_31JobOrderTests.colRequirements.Visible = False
            frm601_31JobOrderTests.colActionTaken.Visible = True

        End If
    End Sub

    Private Sub btnDispatchReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDispatchReport.ItemClick
        If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
            Dim frm601_29JODocReport As New frm601_29JODocReport
            frm601_29JODocReport.txtConditionsCode.EditValue = "DR-0001"
            frm601_29JODocReport.txtJobOrderNo.EditValue = Me.txtJobOrderNo.EditValue
            frm601_29JODocReport.txtJobOrderType.EditValue = "DR"
            frm601_29JODocReport.FillDocumentConditions(Me.txtJobOrderNo.EditValue, "DR")
            frm601_29JODocReport.Show()


        End If
    End Sub

    Private Sub btnObservationImages_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnObservationImages.ItemClick
        If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
            Dim frm601_31JOImages As New frm601_31JOImages
            frm601_31JOImages.txtJobOrderNo.EditValue = Me.txtJobOrderNo.EditValue
            frm601_31JOImages.txtJobOrderType.EditValue = "RCR"
            frm601_31JOImages.Show()
            frm601_31JOImages.LoadAllImages()
        End If
    End Sub

    Private Sub btnInspectionImages_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInspectionImages.ItemClick
        If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
            Dim frm601_31JOImages As New frm601_31JOImages
            frm601_31JOImages.txtJobOrderNo.EditValue = Me.txtJobOrderNo.EditValue
            frm601_31JOImages.txtJobOrderType.EditValue = "VIR"
            frm601_31JOImages.Show()
            frm601_31JOImages.LoadAllImages()
        End If
    End Sub

    Private Sub btnRepairImages_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepairImages.ItemClick
        If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
            Dim frm601_31JOImages As New frm601_31JOImages
            frm601_31JOImages.txtJobOrderNo.EditValue = Me.txtJobOrderNo.EditValue
            frm601_31JOImages.txtJobOrderType.EditValue = "VRR"
            frm601_31JOImages.Show()
            frm601_31JOImages.LoadAllImages()
        End If
    End Sub

    Private Sub btnDispatchImages_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDispatchImages.ItemClick
        If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
            Dim frm601_31JOImages As New frm601_31JOImages
            frm601_31JOImages.txtJobOrderNo.EditValue = Me.txtJobOrderNo.EditValue
            frm601_31JOImages.txtJobOrderType.EditValue = "DR"
            frm601_31JOImages.Show()
            frm601_31JOImages.LoadAllImages()
        End If
    End Sub

    Private Sub btnPrintObservationReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintObservationReport.ItemClick

        'Save before print
        Me.SaveAll(False)

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
                Exit For
            End If

        Next

        GetCompanyDetails02(Me.txtCompanyID.EditValue)

        If CheckIfNull(gJobOrderProcessingCode) = False Then
            If gJobOrderProcessingCode = "0" Then  'Print Precision Valve Report
                PrintObservationReport_PrecisionValves()
            Else
                PrintIncomingInspectionReport_Misco()
            End If
        End If

    End Sub

    Private Sub PrintObservationReport_PrecisionValves()
        Dim rpt1 As New rpt602_01ReceivedCondition
        rpt1.Qry608_02JobOrderReportTableAdapter.FillByJobOrderNo(rpt1.DsRpt601_29JobOrderDocReport1.qry608_02JobOrderReport, Me.txtJobOrderNo.EditValue)

        Dim rpt3 As New rpt601_31JOImages
        rpt3.JobOrderNo = Me.txtJobOrderNo.EditValue
        rpt3.JobOrderType = "RCR"

        rpt1.XrSubreport1.ReportSource = rpt3

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
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

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Received_Condition_Report_" & Me.txtJobOrderNo.EditValue
        rpt1.ShowPreview()
    End Sub

    Private Sub PrintIncomingInspectionReport_Misco()
        Dim rpt1 As New rpt604_01IncomingInspectionReport
        rpt1.Qry608_02JobOrderReportTableAdapter.FillByJobOrderNo(rpt1.DsRpt601_29JobOrderDocReport1.qry608_02JobOrderReport, Me.txtJobOrderNo.EditValue)

        Dim rpt3 As New rpt601_31JOImages
        rpt3.JobOrderNo = Me.txtJobOrderNo.EditValue
        rpt3.JobOrderType = "RCR"

        rpt1.XrSubreport1.ReportSource = rpt3

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
                Exit For
            End If
        Next

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Incoming_Inspection_Report_" & Me.txtJobOrderNo.EditValue
        rpt1.ShowPreview()
    End Sub

    Private Sub btnPrintInpsectionReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintInpsectionReport.ItemClick

        'Save before print
        Me.SaveAll(False)

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
                Exit For
            End If

        Next

        GetCompanyDetails02(Me.txtCompanyID.EditValue)

        If CheckIfNull(gJobOrderProcessingCode) = False Then
            If gJobOrderProcessingCode = "0" Then  'Print Precision Valve Report
                PrintVisualInspectionReport_Precision()
            Else
                If Me.txtValveType.EditValue = "Manual Valves" Then
                    PrintVisualInspectionReportManual_Misco()
                ElseIf Me.txtValveType.EditValue = "Control Valves" Then
                    PrintVisualInspectionReportManual_Misco()
                ElseIf Me.txtValveType.EditValue = "Safety Valves" Then
                    PrintVisualInspectionReportSafetyValves_Misco()
                End If

            End If

        End If

    End Sub

    Private Sub PrintVisualInspectionReport_Precision()
        Dim rpt1 As New rpt602_02InspectionReport
        rpt1.Qry608_02JobOrderReportTableAdapter.FillByJobOrderNo(rpt1.DsRpt601_29JobOrderDocReport1.qry608_02JobOrderReport, Me.txtJobOrderNo.EditValue)

        Dim rpt2 As New rpt603_01InspectionSubReport
        rpt2.Qry608_03JobOrderTestsTableAdapter.FillByJobOrderNo(rpt2.DsRpt603_01InspectionSubReport1.qry608_03JobOrderTests, Me.txtJobOrderNo.EditValue)

        Dim rpt3 As New rpt601_31JOImages
        rpt3.JobOrderNo = Me.txtJobOrderNo.EditValue
        rpt3.JobOrderType = "VIR"

        rpt1.XrSubreport1.ReportSource = rpt2
        rpt1.XrSubreport2.ReportSource = rpt3

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
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

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Visual_Inspection_Report_" & Me.txtJobOrderNo.EditValue
        rpt1.ShowPreview()
    End Sub

    Private Sub PrintVisualInspectionReportManual_Misco()
        Dim rpt1 As New rpt604_02InspectionReport_Misco
        rpt1.Qry608_02JobOrderReportTableAdapter.FillByJobOrderNo(rpt1.DsRpt601_29JobOrderDocReport1.qry608_02JobOrderReport, Me.txtJobOrderNo.EditValue)

        Dim rpt2 As New rpt603_01InspectionSubReport
        rpt2.Qry608_03JobOrderTestsTableAdapter.FillByJobOrderNo(rpt2.DsRpt603_01InspectionSubReport1.qry608_03JobOrderTests, Me.txtJobOrderNo.EditValue)

        Dim rpt3 As New rpt601_31JOImages
        rpt3.JobOrderNo = Me.txtJobOrderNo.EditValue
        rpt3.JobOrderType = "VIR"

        rpt1.XrSubreport1.ReportSource = rpt2
        rpt1.XrSubreport2.ReportSource = rpt3

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
                Exit For
            End If
        Next
        rpt1.txtValveTypeText01.Text = "(MANUAL & CONTROL VALVES)"
        rpt1.txtValveTypeText02.Text = "(MANUAL & CONTROL VALVES)"

        rpt1.txtDocumentNo01.Text = "MOSANED-FRM-509"
        rpt1.txtDocumentNo02.Text = "MOSANED-FRM-509"

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Visual_Inspection_Report_" & Me.txtJobOrderNo.EditValue
        rpt1.ShowPreview()
    End Sub

    Private Sub PrintVisualInspectionReportSafetyValves_Misco()
        Dim rpt1 As New rpt604_02InspectionReport_Misco
        rpt1.Qry608_02JobOrderReportTableAdapter.FillByJobOrderNo(rpt1.DsRpt601_29JobOrderDocReport1.qry608_02JobOrderReport, Me.txtJobOrderNo.EditValue)

        Dim rpt2 As New rpt603_01InspectionSubReport
        rpt2.Qry608_03JobOrderTestsTableAdapter.FillByJobOrderNo(rpt2.DsRpt603_01InspectionSubReport1.qry608_03JobOrderTests, Me.txtJobOrderNo.EditValue)

        Dim rpt3 As New rpt601_31JOImages
        rpt3.JobOrderNo = Me.txtJobOrderNo.EditValue
        rpt3.JobOrderType = "VIR"

        rpt1.XrSubreport1.ReportSource = rpt2
        rpt1.XrSubreport2.ReportSource = rpt3

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
                Exit For
            End If
        Next
        rpt1.txtValveTypeText01.Text = "(PSV'S)"
        rpt1.txtValveTypeText02.Text = "(PSV'S)"

        rpt1.txtDocumentNo01.Text = "MOSANED-FRM-510"
        rpt1.txtDocumentNo02.Text = "MOSANED-FRM-510"

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Visual_Inspection_Report_" & Me.txtJobOrderNo.EditValue
        rpt1.ShowPreview()
    End Sub

    Private Sub btnPrintRepairReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintRepairReport.ItemClick

        'Save before print
        Me.SaveAll(False)

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
                Exit For
            End If

        Next

        GetCompanyDetails02(Me.txtCompanyID.EditValue)

        If CheckIfNull(gJobOrderProcessingCode) = False Then
            If gJobOrderProcessingCode = "0" Then  'Print Precision Valve Report
                PrintRepairReport_Precision()
            Else
                If Me.txtValveType.EditValue = "Manual Valves" Then
                    PrintRepairReport_ManualValves_Misco()
                ElseIf Me.txtValveType.EditValue = "Control Valves" Then
                    PrintRepairReport_ManualValves_Misco()
                ElseIf Me.txtValveType.EditValue = "Safety Valves" Then
                    PrintRepairReport_ManualValves_Misco()
                End If

            End If

        End If

    End Sub

    Private Sub PrintRepairReport_Precision()
        Dim rpt1 As New rpt602_03RepairReport
        rpt1.Qry608_02JobOrderReportTableAdapter.FillByJobOrderNo(rpt1.DsRpt601_29JobOrderDocReport1.qry608_02JobOrderReport, Me.txtJobOrderNo.EditValue)

        Dim rpt2 As New rpt603_02RepairSubReport
        rpt2.Qry608_03JobOrderTestsTableAdapter.FillByJobOrderNo(rpt2.DsRpt603_01InspectionSubReport1.qry608_03JobOrderTests, Me.txtJobOrderNo.EditValue)

        rpt1.XrSubreport1.ReportSource = rpt2

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
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

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Valve_Repair_Report_" & Me.txtJobOrderNo.EditValue
        rpt1.ShowPreview()
    End Sub

    Private Sub PrintRepairReport_ManualValves_Misco()
        Dim rpt1 As New rpt604_03RepairReport_Misco
        rpt1.Qry608_02JobOrderReportTableAdapter.FillByJobOrderNo(rpt1.DsRpt601_29JobOrderDocReport1.qry608_02JobOrderReport, Me.txtJobOrderNo.EditValue)

        Dim rpt2 As New rpt604_03RepairSubReport_Misco
        rpt2.Qry608_03JobOrderTestsTableAdapter.Fill(rpt2.DsRpt603_02RepairSubReport1.qry608_03JobOrderTests, Me.txtJobOrderNo.EditValue)

        rpt1.XrSubreport1.ReportSource = rpt2

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
                Exit For
            End If
        Next

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Valve_Repair_Report_" & Me.txtJobOrderNo.EditValue
        rpt1.ShowPreview()
    End Sub

    Private Sub btnPrintDispatchReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintDispatchReport.ItemClick

        'Save before print
        Me.SaveAll(False)

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
                Exit For
            End If

        Next

        GetCompanyDetails02(Me.txtCompanyID.EditValue)

        If CheckIfNull(gJobOrderProcessingCode) = False Then
            If gJobOrderProcessingCode = "0" Then  'Print Precision Valve Report
                PrintDispatchReport_Precision()
            Else
                PrintDispatchReport_Misco()
            End If

        End If
    End Sub

    Private Sub PrintDispatchReport_Precision()
        Dim rpt1 As New rpt602_04DispatchReport
        rpt1.Qry608_02JobOrderReportTableAdapter.FillByJobOrderNo(rpt1.DsRpt601_29JobOrderDocReport1.qry608_02JobOrderReport, Me.txtJobOrderNo.EditValue)

        Dim rpt3 As New rpt601_31JOImages
        rpt3.JobOrderNo = Me.txtJobOrderNo.EditValue
        rpt3.JobOrderType = "DR"

        rpt1.XrSubreport1.ReportSource = rpt3

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
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
        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Dispatch_Condition_Report_" & Me.txtJobOrderNo.EditValue
        rpt1.ShowPreview()
    End Sub

    Private Sub PrintDispatchReport_Misco()
        Dim rpt1 As New rpt604_04DispatchReport_Misco
        rpt1.Qry608_02JobOrderReportTableAdapter.FillByJobOrderNo(rpt1.DsRpt601_29JobOrderDocReport1.qry608_02JobOrderReport, Me.txtJobOrderNo.EditValue)

        Dim rpt3 As New rpt601_31JOImages
        rpt3.JobOrderNo = Me.txtJobOrderNo.EditValue
        rpt3.JobOrderType = "DR"

        rpt1.XrSubreport1.ReportSource = rpt3

        For i As Integer = 0 To XtraTabControl2.TabPages.Count - 1
            If XtraTabControl2.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl2.SelectedTabPage = XtraTabControl2.TabPages(i)
                Exit For
            End If
        Next

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Dispatch_Condition_Report_" & Me.txtJobOrderNo.EditValue
        rpt1.ShowPreview()
    End Sub

    Private Sub txtJobOrderStatus_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtJobOrderStatus.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm601_32JobOrderStatus As New frm601_32JobOrderStatus
            frm601_32JobOrderStatus.ObjForm = Me
            frm601_32JobOrderStatus.Show()
            frm601_32JobOrderStatus.txtPropertyCategory.Focus()
            frm601_32JobOrderStatus.isExecutedFrom_frm601_27JobOrderEdit02 = True

        End If
    End Sub

    Private Sub btnApproveInitialObservation_Click(sender As Object, e As EventArgs) Handles btnApproveInitialObservation.Click
        Try
            SaveAll(False)
            Me.ApproveInitialObservation(Me.txtJobOrderNo.EditValue)

            ''Check whether Alert Activation for Submission to Verification is set then
            ''Make an Alert to the Verifier
            'GetAlertSettings("SYS-60107-003")
            'If gIsAlertActivated = True Then
            '    'Add an alert
            '    Dim AlertMessage2 As String = ""
            '    AlertMessage2 = Me.strLogonUser & " has approved PO_NO: " & Me.txtPONo.EditValue & " for Proceeding."
            '    InsertSystemAlert(GetNewAlertCode("SYS"), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify Purchase Order is ready to proceed.")

            'End If

            'Disable editing of controls
            DisableAllControls()
            'Check if the login user is an Finance Admin and enable btnPayClaim
            'If is updated from Master Datagrid refresh it
            RefreshMasterDataGrid()

            Me.Close()
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub ApproveInitialObservation(ByVal JobOrderNo As String)
        If CheckIfNull(JobOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60801JobOrderMasterBindingSource.Current, DataRowView)
            view.Row("IsInitialObservationApproved") = True
            view.Row("InitialObsrvApprovedBy") = Me.strLogonUser
            view.Row("InitialObsrvApprovedOn") = Date.Now
            view.Row("JobOrderStatus") = 3

            Me.Tbl60801JobOrderMasterBindingSource.EndEdit()
            Me.Tbl608_01JobOrderMasterTableAdapter.Update(Me.Dsfrm601_27JobOrderEdit.tbl608_01JobOrderMaster)

            MessageBox.Show("Job Order has been approved for Initial Observation.", "Initial Observation Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

   
    Private Sub btnApproveVisualInspection_Click(sender As Object, e As EventArgs) Handles btnApproveVisualInspection.Click
        Try
            SaveAll(False)
            Me.ApproveVisualInspection(Me.txtJobOrderNo.EditValue)

            ''Check whether Alert Activation for Submission to Verification is set then
            ''Make an Alert to the Verifier
            'GetAlertSettings("SYS-60107-003")
            'If gIsAlertActivated = True Then
            '    'Add an alert
            '    Dim AlertMessage2 As String = ""
            '    AlertMessage2 = Me.strLogonUser & " has approved PO_NO: " & Me.txtPONo.EditValue & " for Proceeding."
            '    InsertSystemAlert(GetNewAlertCode("SYS"), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify Purchase Order is ready to proceed.")

            'End If

            'Disable editing of controls
            DisableAllControls()
            'Check if the login user is an Finance Admin and enable btnPayClaim
            'If is updated from Master Datagrid refresh it
            RefreshMasterDataGrid()

            Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ApproveVisualInspection(ByVal JobOrderNo As String)
        If CheckIfNull(JobOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60801JobOrderMasterBindingSource.Current, DataRowView)
            view.Row("IsVisualInspectionApproved") = True
            view.Row("InspectionApprovedBy") = Me.strLogonUser
            view.Row("InspectionApprovedOn") = Date.Now
            view.Row("JobOrderStatus") = 4

            Me.Tbl60801JobOrderMasterBindingSource.EndEdit()
            Me.Tbl608_01JobOrderMasterTableAdapter.Update(Me.Dsfrm601_27JobOrderEdit.tbl608_01JobOrderMaster)

            MessageBox.Show("Job Order has been approved for Visual Inspection.", "Visual Inspection Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnApproveRepairReport_Click(sender As Object, e As EventArgs) Handles btnApproveRepairReport.Click
        Try
            SaveAll(False)
            Me.ApproveRepairReport(Me.txtJobOrderNo.EditValue)

            ''Check whether Alert Activation for Submission to Verification is set then
            ''Make an Alert to the Verifier
            'GetAlertSettings("SYS-60107-003")
            'If gIsAlertActivated = True Then
            '    'Add an alert
            '    Dim AlertMessage2 As String = ""
            '    AlertMessage2 = Me.strLogonUser & " has approved PO_NO: " & Me.txtPONo.EditValue & " for Proceeding."
            '    InsertSystemAlert(GetNewAlertCode("SYS"), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify Purchase Order is ready to proceed.")

            'End If

            'Disable editing of controls
            DisableAllControls()
            'Check if the login user is an Finance Admin and enable btnPayClaim
            'If is updated from Master Datagrid refresh it
            RefreshMasterDataGrid()

            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ApproveRepairReport(ByVal JobOrderNo As String)
        If CheckIfNull(JobOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60801JobOrderMasterBindingSource.Current, DataRowView)
            view.Row("IsRepairReportApproved") = True
            'view.Row("InspectionApprovedBy") = Me.strLogonUser
            'view.Row("InspectionApprovedOn") = Date.Now
            view.Row("JobOrderStatus") = 5

            Me.Tbl60801JobOrderMasterBindingSource.EndEdit()
            Me.Tbl608_01JobOrderMasterTableAdapter.Update(Me.Dsfrm601_27JobOrderEdit.tbl608_01JobOrderMaster)

            MessageBox.Show("Job Order has been approved for Repair Report.", "Repair Report Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnApproveDispatchReport_Click(sender As Object, e As EventArgs) Handles btnApproveDispatchReport.Click
        Try
            SaveAll(False)
            Me.ApproveDispatchReport(Me.txtJobOrderNo.EditValue)

            ''Check whether Alert Activation for Submission to Verification is set then
            ''Make an Alert to the Verifier
            'GetAlertSettings("SYS-60107-003")
            'If gIsAlertActivated = True Then
            '    'Add an alert
            '    Dim AlertMessage2 As String = ""
            '    AlertMessage2 = Me.strLogonUser & " has approved PO_NO: " & Me.txtPONo.EditValue & " for Proceeding."
            '    InsertSystemAlert(GetNewAlertCode("SYS"), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify Purchase Order is ready to proceed.")

            'End If

            'Disable editing of controls
            DisableAllControls()
            'Check if the login user is an Finance Admin and enable btnPayClaim
            'If is updated from Master Datagrid refresh it
            RefreshMasterDataGrid()

            Me.Close()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ApproveDispatchReport(ByVal JobOrderNo As String)
        If CheckIfNull(JobOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60801JobOrderMasterBindingSource.Current, DataRowView)
            view.Row("IsDispatchReportApproved") = True
            view.Row("DispatchApprovedBy") = Me.strLogonUser
            view.Row("DispatchApprovedOn") = Date.Now
            view.Row("JobOrderStatus") = 2

            Me.Tbl60801JobOrderMasterBindingSource.EndEdit()
            Me.Tbl608_01JobOrderMasterTableAdapter.Update(Me.Dsfrm601_27JobOrderEdit.tbl608_01JobOrderMaster)

            MessageBox.Show("Job Order has been approved for Dispatch.", "Dispatch Report Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class