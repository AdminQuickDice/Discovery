Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control
Imports System.Drawing
Imports DevExpress.XtraPrinting.Drawing
Imports System.Text
Imports DevExpress.XtraBars

Public Class frm601_07PurchaseOrderEdit
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

    Dim SelectedPOChildSlNo As Integer
    Public CreatedNewPONo As String

    Public isExecutedFrom_frm601_08PurchaseOrderView As Boolean = False

    Public isExecutedFrom_frm601_13RFQMaster As Boolean = False
    Public isExecutedFrom_frm601_14RFQView As Boolean = False
    Public isExecutedFrom_frm601_12PurchaseRequestView As Boolean = False
    Public isExecutedFrom_frm601_39PORevisionHistory As Boolean = False


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

    Public Sub ImplementAccess(ByVal UserID As Integer)
        If GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_FullAccess") = True Then
            Me.btnResetLayout.Enabled = True
            Me.btnSetDefaultLayout.Enabled = True
            Me.btnMoveUp.Enabled = True
            Me.btnMoveDown.Enabled = True
            Me.btnSave.Enabled = True
            Me.btnSaveAndClose.Enabled = True
            Me.btnPreviewPO.Enabled = True
            Me.btnPreviewPOwoVAT2.Enabled = True
            Me.btnPreviewPOWoVAT.Enabled = True
            Me.btnPreviewPOinFC.Enabled = True
            Me.btnDelete.Enabled = True
            Me.btnDeleteSelectedLineItems.Enabled = True
            Me.btnAddNewLineItem.Enabled = True
            Me.btnAddLineItem.Enabled = True
            Me.btnTerms.Enabled = True
            Me.btnAttachments.Enabled = True
            Me.btnSubmit.Enabled = True
            Me.btnVerify.Enabled = True
            Me.btnApprove.Enabled = True
            Me.btnBack.Enabled = True
            Me.btnDeleteLineItem.Enabled = True
            Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = True
            Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = True

            Me.cmdEditContacts.Enabled = True
            Me.btnDefaultSubject.Enabled = True
            Me.btnDefaultIntro.Enabled = True
            Me.btnDefaultSummary.Enabled = True
            Me.btnDefaultThanks.Enabled = True
            Me.btnFillSubject.Enabled = True
            Me.btnFillPOIntroduction.Enabled = True
            Me.btnFillPOSummary.Enabled = True
            Me.btnFillThanksNote.Enabled = True
            Me.txtSignatory.Properties.Buttons.Item(1).Enabled = True

            Me.txtCurrency.Properties.Buttons.Item(1).Enabled = True
            Me.btnDefaultShipTo.Enabled = True
            Me.btnDefaultBillTo.Enabled = True
            Me.btnFillShipTo.Enabled = True
            Me.btnFillBillTo.Enabled = True

            Me.txtSignatory.Enabled = True
            Me.txtVerifiedSign.Enabled = True
            Me.txtApprovedSign.Enabled = True

            Me.btnDistributeDiscount.Enabled = True


            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = True
        Else
            Me.btnResetLayout.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnResetLayout")
            Me.btnSetDefaultLayout.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnSetDefaultLayout")
            Me.btnMoveUp.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnMoveUp")
            Me.btnMoveDown.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnMoveDown")
            Me.btnSave.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnSave")
            Me.btnSaveAndClose.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnSaveAndClose")
            Me.btnPreviewPO.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnPreviewPO")
            Me.btnPreviewPOwoVAT2.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnPreviewPOwoVAT2")
            Me.btnPreviewPOWoVAT.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnPreviewPOWoVAT")
            Me.btnPreviewPOinFC.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnPreviewPOinFC")
            Me.btnDelete.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnDelete")
            Me.btnDeleteSelectedLineItems.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnDelete")
            Me.btnAddNewLineItem.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnAddNewLineItem")
            Me.btnAddLineItem.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnAddNewLineItem")
            Me.btnTerms.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnTerms")
            Me.btnAttachments.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnAttachments")
            Me.btnSubmit.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnSubmit")
            Me.btnVerify.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnVerify")
            Me.btnApprove.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnApprove")
            Me.btnBack.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnBack")
            Me.btnDeleteLineItem.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnDeleteLineItem")

            Me.btnDistributeDiscount.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnDistributeDiscount")

            Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnAddLineItem")
            Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_AddSupplier")
            Me.cmdEditContacts.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_ChangeContactInfo")

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
                    Me.btnDefaultSubject.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_SetDefaultSubject")
                    Me.btnDefaultIntro.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_SetDefaultIntro")
                    Me.btnDefaultSummary.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_SetDefaultSummary")
                    Me.btnDefaultThanks.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_SetDefaultThanks")
                    Me.btnFillSubject.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnFillSubject")
                    Me.btnFillPOIntroduction.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnFillSubject")
                    Me.btnFillPOSummary.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnFillPOSummary")
                    Me.btnFillThanksNote.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnFillThanksNote")
                End If
            Next

            Me.txtCurrency.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_EditCurrency")
            Me.btnDefaultShipTo.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_SetDefaultShipTo")
            Me.btnDefaultBillTo.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_SetDefaultBillTo")
            Me.btnFillShipTo.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnFillShipTo")
            Me.btnFillBillTo.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnFillBillTo")

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                    Me.txtSignatory.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_EditSignatory")
                    Me.txtSignatory.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnSubmit")
                    Me.txtVerifiedSign.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnVerify")
                    Me.txtApprovedSign.Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_btnApprove")
                    Exit For
                End If
            Next
        End If

        Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_AddStockItem")
        Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_EditStockItem")
        Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = GetUserAccess(UserID, "frm601_07PurchaseOrderEdit_EditStockItem")
    End Sub

    'Public Sub ImplementApprovalAccess()
    '    Try
    '        'EnableAllControls

    '        If GetUserAccess(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_btnVerify") = True Then
    '            Me.btnVerify.Enabled = True
    '        End If

    '        If GetUserAccess(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_btnApprove") = True Then
    '            Me.btnApprove.Enabled = True
    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub

    Public Sub UpdateDefaultFields()
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                If Me.intLogOnDivision = 99 Then
                    Me.txtCompanyID.EditValue = 1
                Else
                    Me.txtCompanyID.EditValue = Me.intLogOnDivision
                End If

                Me.txtCurrency.EditValue = 1
                Me.txtCurrencyExchangeRate.EditValue = 1

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
            If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                GetReportDetails("IMS-PO-001")
                Me.txtSubject.EditValue = gReportSubject
                Me.txtQuoteIntro.Text = gReportIntroduction
                Me.txtQuoteSummary.Text = gReportSummary
                Me.txtQuoteThanksNote.Text = gReportThanksNote
                Exit For
            End If

        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Me.txtAdditions.EditValue = "(+) Shipments & Handling:"
                Me.txtDeductions.EditValue = "(-) Discount:"
                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageShippingDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Me.txtShipTo.Text = gReportShipTo
                Me.txtBillTo.Text = gReportBillTo
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

                Exit For
            End If
        Next

    End Sub

    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtPONo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtPONo, "Purchase Order Number Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtPONo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtPODate.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtPODate, "Purchase Order Date must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtPODate, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtSupplierName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtSupplierName, "Supplier must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtSupplierName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

    End Sub

    Public Sub RetrievePOMaster(ByVal PONo As String)
        Try
            If CheckIfNull(PONo) = False Then
                'fill master details
                Me.Tbl604_01PurchaseOrderMasterTableAdapter.FillByPONo(Me.Dsfrm601_07PurchaseOrderEdit.tbl604_01PurchaseOrderMaster, PONo)

                'fill child details in the datagrid
                Me.Qry604_02PurchaseOrderChildTableAdapter.FillByPONo(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild, PONo)

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Purchase Order Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdatePOMaster(ByVal PONo As String, ByVal WithMessage As Boolean)
        If CheckIfNull(PONo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60401PurchaseOrderMasterBindingSource.Current, DataRowView)
            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            Me.Tbl60401PurchaseOrderMasterBindingSource.EndEdit()
            Me.Tbl604_01PurchaseOrderMasterTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.tbl604_01PurchaseOrderMaster)

            If WithMessage = True Then
                MessageBox.Show("Purchase Order Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SaveNewPOMaster(ByVal PONo As String)
        If CheckIfNull(PONo) = False Then
            If isBeingNew = True Then
                'Select the Invoice Page


                Dim view As DataRowView = DirectCast(Me.Tbl60401PurchaseOrderMasterBindingSource.Current, DataRowView)
                view.Row("AddedBy") = Me.strLogonUser
                view.Row("AddedOn") = Date.Now
                Me.Validate()

                Me.Tbl60401PurchaseOrderMasterBindingSource.EndEdit()
                Me.Tbl604_01PurchaseOrderMasterTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.tbl604_01PurchaseOrderMaster)
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
            UpdatePOMaster(Me.txtPONo.EditValue, WithMessage)
            Me.btnSave.Caption = "Update"

        ElseIf Me.btnSave.Caption = "Save" Then
            If Me.isBeingNew = True Then
                SaveNewPOMaster(Me.txtPONo.EditValue)
                Me.btnSave.Caption = "Update"
            End If
        End If

        Try
            'Update the Data in the Child
            Me.Qry60402PurchaseOrderChildBindingSource.EndEdit()
            Me.Qry604_02PurchaseOrderChildTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild)
            Me.Qry604_02PurchaseOrderChildTableAdapter.FillByPONo(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild, Me.txtPONo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshPOMasterDataGrid()
    End Sub


    Private Sub RefreshPOMasterDataGrid()


        'If isExecutedFrom_frm601_14RFQView = True Then
        '    Try
        '        CType(ObjForm, frm601_14RFQView).RetrieveVoucher(CType(ObjForm, frm601_14RFQView).txtStartDate.EditValue, CType(ObjForm, frm601_14RFQView).txtEndDate.EditValue)
        '        CType(ObjForm, frm601_14RFQView).UpdateFrames()
        '        GoBackToRow(CType(ObjForm, frm601_14RFQView).gvAdvBandedQuotationView, "RFQNo", Me.txtRFQNo.EditValue)
        '    Catch ex As Exception
        '        MessageBox.Show("Error Occured while Refreshing the RFQ List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End If

        If isExecutedFrom_frm601_08PurchaseOrderView = True Then
            Try
                CType(ObjForm, frm601_08PurchaseOrderView).RetrieveVoucher(CType(ObjForm, frm601_08PurchaseOrderView).txtStartDate.EditValue, CType(ObjForm, frm601_08PurchaseOrderView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_08PurchaseOrderView).gvAdvBandedQuotationView, "PONo", Me.txtPONo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Purchase Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If


        If isExecutedFrom_frm601_14RFQView = True Then
            Try
                CType(ObjForm, frm601_14RFQView).RetrieveVoucher(CType(ObjForm, frm601_14RFQView).txtStartDate.EditValue, CType(ObjForm, frm601_14RFQView).txtEndDate.EditValue)
                CType(ObjForm, frm601_14RFQView).UpdateFrames()
                GoBackToRow(CType(ObjForm, frm601_14RFQView).gvAdvBandedQuotationView, "RFQNo", Me.txtRFQNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the RFQ List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
        '

        If isExecutedFrom_frm601_12PurchaseRequestView = True Then
            'Try
            '    CType(ObjForm, frm601_12PurchaseRequestView).RetrieveVoucher(CType(ObjForm, frm601_12PurchaseRequestView).txtStartDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).txtEndDate.EditValue, Me.intLogOnUserLevel)
            '    CType(ObjForm, frm601_12PurchaseRequestView).UpdateFrames()
            '    GoBackToRow(CType(ObjForm, frm601_12PurchaseRequestView).gvAdvBandedQuotationView2, "MPRNo", Me.txtRFQNo.EditValue)
            'Catch ex As Exception
            '    MessageBox.Show("Error Occured while Refreshing the RFQ List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try

        End If

    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.ItemClick
        If isControlsModified = True Then
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("Purchase Order Details have been edited, would you like to save changes?", "Save Changes?", MessageBoxButtons.YesNoCancel)

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

    Public Function GetNewPONo(ByVal PurchaseOrderAbbrv As String, ByVal YearInDigit As Integer, ByVal PODate As Date, ByVal IsResetByYear As Boolean, ByVal NoOfDigits As Integer, ByVal IsUseNewSequencePONoForGroup As Boolean) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1

            If IsUseNewSequencePONoForGroup = True Then
                If IsResetByYear = True Then
                    SqlCommand1.CommandText = "select max(cast(right(PONo, " & NoOfDigits & ") as int)) from tbl604_01PurchaseOrderMaster WHERE PONo like '" & PurchaseOrderAbbrv & "%' AND Year(PODate) = '" & Year(PODate).ToString & "' AND ISNULL(IsObseleteVersion, 0) = 0 AND Right(Convert(varchar(4), Year(PODate)), " & YearInDigit & ")  = SUBSTRING(PONO, LEN('" & PurchaseOrderAbbrv & "') + 1, " & YearInDigit & ")"

                Else
                    SqlCommand1.CommandText = "select max(cast(right(PONo, " & NoOfDigits & ") as int)) from tbl604_01PurchaseOrderMaster WHERE PONo like '" & PurchaseOrderAbbrv & "%' AND ISNULL(IsObseleteVersion, 0) = 0"
                End If

            Else
                If IsResetByYear = True Then
                    SqlCommand1.CommandText = "select max(cast(right(PONo, " & NoOfDigits & ") as int)) from tbl604_01PurchaseOrderMaster WHERE PONo like '" & PurchaseOrderAbbrv & "%' AND Year(PODate) = '" & Year(PODate).ToString & "' AND ISNULL(IsObseleteVersion, 0) = 0 AND Right(Convert(varchar(4), Year(PODate)), " & YearInDigit & ")  = SUBSTRING(PONO, LEN('" & PurchaseOrderAbbrv & "') + 1, " & YearInDigit & ")"

                Else
                    SqlCommand1.CommandText = "select max(cast(right(PONo, " & NoOfDigits & ") as int)) from tbl604_01PurchaseOrderMaster WHERE PONo like '" & PurchaseOrderAbbrv & "%' AND ISNULL(IsObseleteVersion, 0) = 0"
                End If
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
            strNewQuotationNo = PurchaseOrderAbbrv & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(PODate).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = "0000001"
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)

            strNewQuotationNo = PurchaseOrderAbbrv & strYear & "-" & strNewQuotationNo
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function


    'Saving and updating codes
    Public Sub NewPOMaster(ByVal PONo As String)
        Try
            If CheckIfNull(PONo) = False Then
                Me.Tbl60401PurchaseOrderMasterBindingSource.AddNew()
                Me.txtPONo.EditValue = PONo
                isBeingUpdated = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Purchase Order", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddNewLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewLineItem.ItemClick
        Try
            If CheckIfNull(Me.txtPONo.EditValue) = False Then
                If Me.btnSave.Caption = "Save" Then
                    SaveNewPOMaster(Me.txtPONo.EditValue)
                    Me.btnSave.Caption = "Update"
                End If

                Me.AddNewChild()
                Me.Validate()
                'Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, DeliveryNoteNo)
                Me.Qry60402PurchaseOrderChildBindingSource.EndEdit()
                Me.Qry604_02PurchaseOrderChildTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild)
                Me.Qry604_02PurchaseOrderChildTableAdapter.FillByPONo(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild, Me.txtPONo.EditValue)

                Me.gvInvoiceChild.MoveLast()
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.Columns("GSCode")
                Me.gvInvoiceChild.ShowEditor()

                Me.txtCurrency.Enabled = False
                Me.txtCurrencyExchangeRate.Enabled = False

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Purchase Order Line Item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm601_07PurchaseOrderEdit.Tables("qry604_02PurchaseOrderChild")
            dr = dt.NewRow()
            dr("POChildNo") = 1
            dr("PONo") = Me.txtPONo.EditValue
            dr("GSCode") = ""
            dr("QuotedQuantity") = 1
            dr("LineOrderNo") = GetNewPOLineItemNo(Me.txtPONo.EditValue)

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)

                    dr("Currency") = Me.txtCurrency.EditValue
                    dr("ExchangeRate") = Me.txtCurrencyExchangeRate.EditValue
                    Exit For
                End If
            Next

            dt.Rows.Add(dr)
            Me.Qry604_02PurchaseOrderChildTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Purchase Order Line Item, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewPOLineItemNo(ByVal strPONo As String) As Integer
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Max(LineOrderNo) from tbl604_02PurchaseOrderChild where PONo = '" & strPONo & "'"
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

    Private Sub DeletePOChild(ByVal POChildSlNo As Integer, ByVal WithMessage As Boolean)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp604_01DeletePurchaseOrderChild"
            Dim paramPayrollInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@POChildNo", SqlDbType.Int)

            paramPayrollInvoiceNo.Value = POChildSlNo

            SqlCommand1.ExecuteNonQuery()
            If WithMessage = True Then
                MessageBox.Show("Purchase Order Line Item Deleted Successfully,", "Data Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As System.InvalidCastException
            MessageBox.Show("Purchase Order Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteLineItem.ItemClick

        DialogResult = MessageBox.Show("You are about to delete Purchase Order Line Item." & vbCrLf & "Are you Sure want to delete this Purchase Order Details?", "Delete Purchase Order Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedPOChildSlNo) = False Then

                Me.DeletePOChild(Me.SelectedPOChildSlNo, True)

                'Refresh the datagrid
                'fill child details in the datagrid
                Me.Qry604_02PurchaseOrderChildTableAdapter.FillByPONo(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild, Me.txtPONo.EditValue)

                'Check if the PO has line items.. If available disable currency choosing, else enable currency.
                If Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild.Rows.Count = 0 Then
                    Me.txtCurrency.Enabled = True
                    Me.txtCurrencyExchangeRate.Enabled = True

                End If

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
                SelectedPOChildSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("POChildNo"))
                Me.popInvoiceChild.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAddLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddLineItem.ItemClick
        If CheckIfNull(Me.txtPONo.EditValue) = False Then
            Me.AddNewChild()
            Me.Validate()
            Me.Qry60402PurchaseOrderChildBindingSource.EndEdit()
            Me.Qry604_02PurchaseOrderChildTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild)

            Me.Qry604_02PurchaseOrderChildTableAdapter.FillByPONo(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild, Me.txtPONo.EditValue)
        End If
    End Sub

    Public Sub UpdateInvoiceChild()
        Try

            Me.Validate()
            Me.Qry60402PurchaseOrderChildBindingSource.EndEdit()
            Me.Qry604_02PurchaseOrderChildTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild)

            RefreshPOChild()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub RefreshPOChild()
        Me.Qry604_02PurchaseOrderChildTableAdapter.FillByPONo(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild, Me.txtPONo.EditValue)

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            'Check if the Voucher is approved already
            If CheckIfPOIsApproved(Me.txtPONo.EditValue) = True Then
                MessageBox.Show("Purchase Order is already approved, You cannot delete the Approved Purchase Order", "Purchase Order Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Purchase Order from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtPONo.EditValue) = False Then
                    If DeletePO(Me.txtPONo.EditValue) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.txtPONo.EditValue, "VoucherScanned\IMSPO")

                        MessageBox.Show("Purchase Order has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Purchase Order", "IMS Purchase Order Ref No." & Me.txtPONo.EditValue & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogonUser & ".", Me.strLogonUser, Me.txtPONo.EditValue)

                        'Refresh the datagrid
                        RefreshPOMasterDataGrid()

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

    Public Function CheckIfPOIsApproved(ByVal PONo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select PONo from tbl604_01PurchaseOrderMaster where (PONo = '" & PONo & "') and (Isnull(IsApproved,0) = 1 )"

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

    Public Function CheckIfPOIsSubmitted(ByVal PONo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select PONo from tbl604_01PurchaseOrderMaster where (PONo = '" & PONo & "') and (Isnull(IsSubmitted,0) = 1 )"

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

    Public Function CheckIfPOIsVerified(ByVal PONo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select PONo from tbl604_01PurchaseOrderMaster where (PONo = '" & PONo & "') and (Isnull(IsVerified,0) = 1 )"

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
    Private Function DeletePO(ByVal PONo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl604_01PurchaseOrderMaster WHERE PONo   = '" & PONo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl604_02PurchaseOrderChild WHERE PONo   = '" & PONo & "'"
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


    Public Sub DisableApprovedVoucherEditing(ByVal PONo As String)
        'Disable access if the voucher is already approved.
        'Get the IsVoucherIsApproved
        If CheckIfPOIsApproved(Me.txtPONo.EditValue) = True Then
            Me.DisableAllControls()
        End If

        'Me.CheckIfPDFAvailable(voucherNo)
    End Sub

    Public Sub DisableAllControls()

        Me.btnResetLayout.Enabled = False
        Me.btnSetDefaultLayout.Enabled = False
        Me.btnMoveUp.Enabled = False
        Me.btnMoveDown.Enabled = False
        Me.btnSave.Enabled = False
        Me.btnSaveAndClose.Enabled = False
        Me.btnPreviewPO.Enabled = True
        Me.btnPreviewPOwoVAT2.Enabled = True
        Me.btnPreviewPOWoVAT.Enabled = True
        Me.btnPreviewPOinFC.Enabled = True
        Me.btnDelete.Enabled = False
        Me.btnAddNewLineItem.Enabled = False
        Me.btnAddLineItem.Enabled = False
        Me.btnTerms.Enabled = False
        Me.btnAttachments.Enabled = True
        Me.btnSubmit.Enabled = False
        Me.btnVerify.Enabled = False
        Me.btnApprove.Enabled = False
        Me.btnBack.Enabled = True

        Me.btnDistributeDiscount.Enabled = False

        Me.btnDeleteLineItem.Enabled = False
        Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = False
        Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = False

        Me.cmdEditContacts.Enabled = False
        Me.btnDefaultSubject.Enabled = False
        Me.btnDefaultIntro.Enabled = False
        Me.btnDefaultSummary.Enabled = False
        Me.btnDefaultThanks.Enabled = False
        Me.btnFillSubject.Enabled = False
        Me.btnFillPOIntroduction.Enabled = False
        Me.btnFillPOSummary.Enabled = False
        Me.btnFillThanksNote.Enabled = False
        Me.txtSignatory.Properties.Buttons.Item(1).Enabled = False

        Me.txtCurrency.Properties.Buttons.Item(1).Enabled = False
        Me.btnDefaultShipTo.Enabled = False
        Me.btnDefaultBillTo.Enabled = False
        Me.btnFillShipTo.Enabled = False
        Me.btnFillBillTo.Enabled = False


        Me.groupCompanyBranch.Enabled = False
        Me.groupCurrency.Enabled = False
        Me.groupShipments.Enabled = False
        Me.groupShipping.Enabled = False
        Me.groupTerms.Enabled = False
        Me.panelPODetails.Enabled = False

        Me.txtSignatory.Enabled = False
        Me.txtVerifiedSign.Enabled = False
        Me.txtApprovedSign.Enabled = False

        Me.gcInvoiceChild.Enabled = False
        Me.txtSubject.Enabled = False
        Me.txtQuoteIntro.Enabled = False
        Me.txtQuoteSummary.Enabled = False
        Me.txtQuoteThanksNote.Enabled = False

    End Sub

    Public Sub DisableControlsForInventoryGroupMaster(ByVal InventoryGroupMaster As Integer)
        If InventoryGroupMaster = 99 Then
            Me.txtInventoryGroupMaster.Enabled = True
        Else
            Me.txtInventoryGroupMaster.Enabled = False
        End If

    End Sub

    Public Sub EnableAllControls()

        Me.btnResetLayout.Enabled = True
        Me.btnSetDefaultLayout.Enabled = True
        Me.btnMoveUp.Enabled = True
        Me.btnMoveDown.Enabled = True
        Me.btnSave.Enabled = True
        Me.btnSaveAndClose.Enabled = True
        Me.btnPreviewPO.Enabled = True
        Me.btnPreviewPOwoVAT2.Enabled = True
        Me.btnPreviewPOWoVAT.Enabled = True
        Me.btnPreviewPOinFC.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnAddNewLineItem.Enabled = True
        Me.btnAddLineItem.Enabled = True
        Me.btnTerms.Enabled = True
        Me.btnAttachments.Enabled = True
        Me.btnSubmit.Enabled = True
        Me.btnVerify.Enabled = True
        Me.btnApprove.Enabled = True
        Me.btnBack.Enabled = True
        Me.btnDistributeDiscount.Enabled = True

        Me.btnDeleteLineItem.Enabled = True
        Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = True
        Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = True

        Me.cmdEditContacts.Enabled = True
        Me.btnDefaultSubject.Enabled = True
        Me.btnDefaultIntro.Enabled = True
        Me.btnDefaultSummary.Enabled = True
        Me.btnDefaultThanks.Enabled = True
        Me.btnFillSubject.Enabled = True
        Me.btnFillPOIntroduction.Enabled = True
        Me.btnFillPOSummary.Enabled = True
        Me.btnFillThanksNote.Enabled = True
        Me.txtSignatory.Properties.Buttons.Item(1).Enabled = True

        Me.txtCurrency.Properties.Buttons.Item(1).Enabled = True
        Me.btnDefaultShipTo.Enabled = True
        Me.btnDefaultBillTo.Enabled = True
        Me.btnFillShipTo.Enabled = True
        Me.btnFillBillTo.Enabled = True


        Me.groupCompanyBranch.Enabled = True
        Me.groupCurrency.Enabled = True
        Me.groupShipments.Enabled = True
        Me.groupShipping.Enabled = True
        Me.groupTerms.Enabled = True
        Me.panelPODetails.Enabled = True

        Me.txtSignatory.Enabled = True
        Me.txtVerifiedSign.Enabled = True
        Me.txtApprovedSign.Enabled = True

        Me.gcInvoiceChild.Enabled = True
        Me.txtSubject.Enabled = True
        Me.txtQuoteIntro.Enabled = True
        Me.txtQuoteSummary.Enabled = True
        Me.txtQuoteThanksNote.Enabled = True

    End Sub
    Private Sub txtClientName_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSupplierName.ButtonClick
        If e.Button.Index = 2 Then

            Dim frm30110SupplierMaster As New frm30110SupplierMaster
            frm30110SupplierMaster.ObjForm = Me

            frm30110SupplierMaster.btnSave.Caption = "Save"
            frm30110SupplierMaster.strLogonUser = Me.strLogonUser
            frm30110SupplierMaster.intLogOnUserID = Me.intLogOnUserID
            frm30110SupplierMaster.intLogOnUserLevel = Me.intLogOnUserLevel
            frm30110SupplierMaster.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm30110SupplierMaster.Show()
            frm30110SupplierMaster.FillDataSetforNew()


            Dim NewSupplierCode As String = frm30110SupplierMaster.GetNewSupplierNo()
            frm30110SupplierMaster.txtSupplierCode.EditValue = NewSupplierCode
            frm30110SupplierMaster.txtSupplierName.Focus()
            frm30110SupplierMaster.isExecutedFrom_frm601_07PurchaseOrderEdit = True

        ElseIf e.Button.Index = 1 Then

            If CheckIfNull(Me.txtSupplierName.EditValue) = True Or Me.txtSupplierName.Text = String.Empty Then
                MessageBox.Show("Please select the Supplier to edit.", "Select Supplier to edit", MessageBoxButtons.OK)
            Else
                Dim frm30110SupplierMaster As New frm30110SupplierMaster
                frm30110SupplierMaster.ObjForm = Me

                frm30110SupplierMaster.isExecutedFrom_frm601_07PurchaseOrderEdit = True

                frm30110SupplierMaster.strLogonUser = Me.strLogonUser
                frm30110SupplierMaster.intLogOnUserID = Me.intLogOnUserID
                frm30110SupplierMaster.intLogOnUserLevel = Me.intLogOnUserLevel
                frm30110SupplierMaster.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm30110SupplierMaster.txtSupplierCode.EditValue = Me.txtSupplierName.EditValue
                frm30110SupplierMaster.Show()
                frm30110SupplierMaster.FillDataSetforEditing(Me.txtSupplierName.EditValue)

                frm30110SupplierMaster.btnSave.Caption = "Update"
                frm30110SupplierMaster.txtSupplierName.Focus()

            End If
        End If
    End Sub

    Private Sub txtClientName_EditValueChanged(sender As Object, e As EventArgs) Handles txtSupplierName.EditValueChanged
        Try
            If CheckIfNull(Me.txtSupplierName.EditValue) = False Then
                ' Me.Tbl30199_SupplierMasterTableAdapter.Fill(Me.Ds40117PropertyPOEdit1.tbl30199_SupplierMaster)

                Me.txtClientRefName.EditValue = Me.Dsfrm601_07PurchaseOrderEdit.Tables("tbl30199_SupplierMaster").Rows.Find(Me.txtSupplierName.EditValue).Item("ContactPerson")
                Me.txtClientContactNo.EditValue = Me.Dsfrm601_07PurchaseOrderEdit.Tables("tbl30199_SupplierMaster").Rows.Find(Me.txtSupplierName.EditValue).Item("ContactPhone1")
                Me.txtClientEmail.EditValue = Me.Dsfrm601_07PurchaseOrderEdit.Tables("tbl30199_SupplierMaster").Rows.Find(Me.txtSupplierName.EditValue).Item("ContactEmail")
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
            frm40115QuotationSignatories.isExecutedFrom_frm601_07PurchaseOrderEdit = True
        End If
    End Sub

    Private Sub repoDetailedDescription_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoDetailedDescription.ButtonClick
        If e.Button.Index = 1 Then
            Try
                Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                frm20163VATGoodsAndServicesEdit.ObjForm = Me

                frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Save"
                frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_07PurchaseOrderEdit = True


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
                    frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_07PurchaseOrderEdit = True

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
                MessageBox.Show(ex.Message.ToString)
            End Try

        ElseIf e.Button.Index = 3 Then
            Try
                Dim strItemCode As String = Me.gvInvoiceChild.GetRowCellValue(Me.gvInvoiceChild.FocusedRowHandle, "GSCode")

                If CheckIfNull(strItemCode) = False Then

                    Dim frm600_01InventoryStockEdit As New frm600_01InventoryStockEdit
                    frm600_01InventoryStockEdit.objForm = Me
                    frm600_01InventoryStockEdit.isExecutedFrom_frm601_07PurchaseOrderEdit = True

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

                GetCompanyDetails(1)
                If gCurrencyType = "BHD" Then
                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("POTaxSlab"), 11)
                ElseIf gCurrencyType = "AED" Then

                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("POTaxSlab"), 1)

                Else
                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("POTaxSlab"), 8)
                End If


                GetCompanyDetails02(1)
                If gIsShowLastUnitPriceInPOForItem = True Then
                    GetLastUnitPriceFromPO(SelectedValue)
                    'Get the Last Unit Price for the PO
                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitPrice"), gLastUnitPriceFromPO)
                End If


                Dim intFocusedRow As Integer = Me.gvInvoiceChild.FocusedRowHandle
                UpdateInvoiceChild()
                Me.gvInvoiceChild.FocusedRowHandle = intFocusedRow
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.VisibleColumns(6)
                Me.gvInvoiceChild.ShowEditor()

            End If

            If e.Column.Name = "colUnitRateInOC" Then
                Dim SelectedValue As Decimal = e.Value
                Dim SelectedExchangeRate As Decimal = Me.txtCurrencyExchangeRate.EditValue
                Dim ValueInRiyals As Decimal = SelectedValue * SelectedExchangeRate

                Select Case SelectedValue
                    Case 0
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitPrice"), 0)
                    Case Else
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitPrice"), ValueInRiyals)
                End Select
            End If

            'Discount in OC - Change the Discount of Riyals
            If e.Column.Name = "colDiscountInOC" Then
                Dim SelectedValue As Decimal = e.Value
                Dim SelectedExchangeRate As Decimal = Me.txtCurrencyExchangeRate.EditValue
                Dim ValueInRiyals As Decimal = SelectedValue * SelectedExchangeRate

                Select Case SelectedValue
                    Case 0
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("ItemDiscount"), 0)
                    Case Else
                        gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("ItemDiscount"), ValueInRiyals)
                End Select
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




    Private Sub frm40117PropertyPOEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm601_07PurchaseOrderEdit7.tbl606_04PurchaseRequestProjectSubUnits' table. You can move, or remove it, as needed.
        Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit7.tbl606_04PurchaseRequestProjectSubUnits)
        'TODO: This line of code loads data into the 'Dsfrm601_07PurchaseOrderEdit.tbl20101SalesPersonMaster' table. You can move, or remove it, as needed.
        Me.Tbl20101SalesPersonMasterTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit.tbl20101SalesPersonMaster)
        'TODO: This line of code loads data into the 'Dsfrm601_07PurchaseOrderEdit6.tbl600_08InventoryMasterGroup' table. You can move, or remove it, as needed.
        Me.Tbl600_08InventoryMasterGroupTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit6.tbl600_08InventoryMasterGroup)
        'TODO: This line of code loads data into the 'Dsfrm600_13POCategories.tbl604_04POCategory' table. You can move, or remove it, as needed.
        Me.Tbl604_04POCategoryTableAdapter.Fill(Me.Dsfrm600_13POCategories.tbl604_04POCategory)

        Me.Tbl20169CurrencyExchangeTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit.tbl20169CurrencyExchange)
        Me.Qry700_02ProjectsViewMasterTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit5.qry700_02ProjectsViewMaster)
        Me.Tbl30104TypeOfRequestMasterTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit4.tbl30104TypeOfRequestMaster)
        Me.Tbl20168VATPurchaseTaxSlabsTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit2.tbl20168VATPurchaseTaxSlabs)
        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit1.tbl40111PropertyUnitCodes)

        Me.Tbl901CompanyDetailsTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit.tbl901CompanyDetails)
        Me.Tbl90104DocumentSignatoriesTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit.tbl90104DocumentSignatories)
        Me.Tbl30199_SupplierMasterTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit.tbl30199_SupplierMaster)

        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm601_07PurchaseOrderEdit1.tbl20164GoodsAndServicesMaster)
        Else
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.FillByInventoryMasterGroupID(Me.Dsfrm601_07PurchaseOrderEdit1.tbl20164GoodsAndServicesMaster, Me.intLogOnInventoryAccessLevel)
        End If

        'Retrieve Panel Layout
        Try
            LoadLayoutFromDB(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit", Me.gvInvoiceChild)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_gvProjectList", Me.gvProjectList)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_gvGSList", Me.gvGSList)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_gvSupplierList", Me.gvSupplierList)

        Catch ex As Exception

        End Try


        Me.ImplementAccess(Me.intLogOnUserID)


        'Populate Custom Reports Tab
        Me.PopulateCustomReportButtons(Me.CustomReportFormNo)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colcalcTaxAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colLineAmount.DisplayFormat.FormatString = "{0:#,0.000}"

            txtAdditionsAmount.Properties.DisplayFormat.FormatString = "{0:#,0.000}"
            txtDeductionsAmount.Properties.DisplayFormat.FormatString = "{0:#,0.000}"
            txtCreditLimit.Properties.DisplayFormat.FormatString = "{0:#,0.000}"

            txtAdditionsAmount.Properties.EditFormat.FormatString = "{0:###,###,##0.000}"
            txtDeductionsAmount.Properties.EditFormat.FormatString = "{0:###,###,##0.000}"
            txtCreditLimit.Properties.EditFormat.FormatString = "{0:###,###,##0.000}"

            txtAdditionsAmount.Properties.EditMask = "###,###,##0.000"
            txtDeductionsAmount.Properties.EditMask = "###,###,##0.000"
            txtCreditLimit.Properties.EditMask = "###,###,##0.000"

        End If
    End Sub

    Private Sub btnPreviewPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewPO.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If

            Next

            GetCompanyDetails(Me.txtCompanyID.EditValue)

            If CheckIfNull(gCompanyERPCode) = False Then
                If gCompanyERPCode = "ERP-801" Then  'ERA International ERP Code
                    PrintQuotationFormat_SAQCO()
                Else
                    PrintPurchaseOrderFormat01()

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintQuotationFormat_SAQCO()
        Try

            Dim rpt1 As New rpt601_99_01PurchaseOrderFormat_SAQCO
            rpt1.Qry604_05PurchaseOrderReportTableAdapter.FillByPONo(rpt1.DsRpt601_02PurchaseOrderReport1.qry604_05PurchaseOrderReport, Me.txtPONo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtPONo.EditValue)

            rpt1.XrSubreport1.ReportSource = rpt2

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

            'rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            'rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            'If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
            '    If Me.txtShowCompanySeal.EditValue = True Then
            '        rpt1.txtCompanySeal.Visible = True
            '    Else
            '        rpt1.txtCompanySeal.Visible = False
            '    End If
            'End If

            'If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
            '    rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

            '    If Me.txtShowSignature.EditValue = True Then
            '        rpt1.txtSignatureImage.Visible = True
            '    Else
            '        rpt1.txtSignatureImage.Visible = False
            '    End If
            'End If

            'If Me.txtAdditionsAmount.EditValue = 0 Then
            '    rpt1.rowAdditions.Visible = False
            'End If

            'If Me.txtDeductionsAmount.EditValue = 0 Then
            '    rpt1.rowDeductions.Visible = False
            'End If

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.ShowHSCode.EditValue) Then
                If Me.ShowHSCode.EditValue = True Then
                    rpt1.boolShowHSCode = True
                Else
                    rpt1.boolShowHSCode = False
                End If
            End If

            'If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
            '    If Me.txtVerifiedSign.EditValue = 99 Then
            '        rpt1.boolShowVerifiedBy = False
            '    Else
            '        rpt1.boolShowVerifiedBy = True
            '    End If
            'End If

            'If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
            '    If Me.txtApprovedSign.EditValue = 99 Then
            '        rpt1.boolShowApprovedBy = False
            '    Else
            '        rpt1.boolShowApprovedBy = True
            '    End If
            'End If

            'If Me.txtPrintSupplierAcceptance.EditValue = True Then
            '    rpt1.boolShowAcceptance = True
            'Else
            '    rpt1.boolShowAcceptance = False
            'End If

            'If Me.txtShowSignPositionOnly.EditValue = True Then
            '    rpt1.boolShowOnlyPosition = True
            'Else
            '    rpt1.boolShowOnlyPosition = False
            'End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser

            'Checkif the Purchase Order is Not Approved then show Watermark
            GetCompanyDetails02(1)
            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    rpt1.Watermark.Text = "D R A F T   C O P Y"
                    rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                    rpt1.Watermark.TextDirection = DirectionMode.Horizontal
                    'rpt1.Watermark.ShowBehind = False

                End If
            End If

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Purchase_Order_No_" & Me.txtPONo.EditValue & "_" & Me.txtSupplierName.Text
            rpt1.RequestParameters = False
            rpt1.ShowPreview()

            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    If rpt1.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) <> CommandVisibility.None Then
                        rpt1.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None)
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub PrintPurchaseOrderFormat01()
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_02PurchaseOrderFormat01
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-PO-001"
            Dim frm1 As New frm999_05ReportPreviewIMS_PO

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------
            rpt1.Qry604_05PurchaseOrderReportTableAdapter.FillByPONo(rpt1.DsRpt601_02PurchaseOrderReport1.qry604_05PurchaseOrderReport, Me.txtPONo.EditValue)

            'Dim rpt2 As New rpt40102QuotationTerms
            'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtPONo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtPONo.EditValue)

            rpt1.XrSubreport1.ReportSource = rpt2

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

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Me.txtAdditionsAmount.EditValue = 0 Then
                rpt1.rowAdditions.Visible = False
            End If

            If Me.txtDeductionsAmount.EditValue = 0 Then
                rpt1.rowDeductions.Visible = False
            End If

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.ShowHSCode.EditValue) Then
                If Me.ShowHSCode.EditValue = True Then
                    rpt1.boolShowHSCode = True
                Else
                    rpt1.boolShowHSCode = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowItemPartNumber.EditValue) Then
                If Me.txtShowItemPartNumber.EditValue = True Then
                    rpt1.boolShowItemPartNo = True
                Else
                    rpt1.boolShowItemPartNo = False
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If

            If Me.txtPrintSupplierAcceptance.EditValue = True Then
                rpt1.boolShowAcceptance = True
            Else
                rpt1.boolShowAcceptance = False
            End If

            If Me.txtPrintSupplierAcceptance02.EditValue = True Then
                rpt1.boolShowSimpleAcceptance = True
            Else
                rpt1.boolShowSimpleAcceptance = False
            End If

            If Me.txtShowSignPositionOnly.EditValue = True Then
                rpt1.boolShowOnlyPosition = True
            Else
                rpt1.boolShowOnlyPosition = False
            End If

            If Not CheckIfNull(Me.txtShowShippingDetails.EditValue) Then
                If Me.txtShowShippingDetails.EditValue = True Then
                    rpt1.boolShowShippingDetails = True
                Else
                    rpt1.boolShowShippingDetails = False
                End If
            End If

            'Checkif the Purchase Order is Not Approved then show Watermark
            GetCompanyDetails02(1)
            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    rpt1.Watermark.Text = "D R A F T   C O P Y"
                    rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                    rpt1.Watermark.TextDirection = DirectionMode.Horizontal
                End If
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Purchase_Order_No_" & Me.txtPONo.EditValue & "_" & Me.txtSupplierName.Text
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

            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    If rpt1.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) <> CommandVisibility.None Then
                        rpt1.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None)
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnTerms_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTerms.ItemClick
        'If CheckIfNull(Me.txtPONo.EditValue) = False Then
        '    Dim frm40107QuoteSelected As New frm40107QuoteSelected
        '    frm40107QuoteSelected.selectedTermsFor = "Purchase Order"
        '    frm40107QuoteSelected.Show()
        '    frm40107QuoteSelected.SelectedQuoteNo = Me.txtPONo.EditValue
        '    frm40107QuoteSelected.selectedQuoteType = Me.txtTypeOfRequest.Text
        '    frm40107QuoteSelected.txtTermsCategory.Text = Me.txtTypeOfRequest.Text
        '    frm40107QuoteSelected.FilterSelectedQuoteNo(Me.txtPONo.EditValue)
        'End If

        If CheckIfNull(Me.txtPONo.EditValue) = False Then
            Dim frm600_06DocumentConditions As New frm600_06DocumentConditions
            frm600_06DocumentConditions.txtConditionsCode.EditValue = "TERMS-0001"
            frm600_06DocumentConditions.txtDocumentNo.EditValue = Me.txtPONo.EditValue
            frm600_06DocumentConditions.FillDocumentConditions(Me.txtPONo.EditValue)
            frm600_06DocumentConditions.Show()


        End If
    End Sub

    Private Sub cmdEditContacts_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles cmdEditContacts.OpenLink
        Try
            Dim strSupplierCode As String = Me.txtSupplierName.EditValue

            If CheckIfNull(strSupplierCode) = False Then

                Dim frm600_04SupplierContactList As New frm600_04SupplierContactList
                frm600_04SupplierContactList.ObjForm = Me
                frm600_04SupplierContactList.isExecutedFrom_frm601_07PurchaseOrderEdit = True

                frm600_04SupplierContactList.strLogonUser = Me.strLogonUser
                frm600_04SupplierContactList.intLogOnUserID = Me.intLogOnUserID
                frm600_04SupplierContactList.intLogOnUserLevel = Me.intLogOnUserLevel
                frm600_04SupplierContactList.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm600_04SupplierContactList.txtClientCode.EditValue = strSupplierCode
                frm600_04SupplierContactList.txtClientCode.Enabled = False

                frm600_04SupplierContactList.txtClientName.EditValue = Me.txtSupplierName.Text
                frm600_04SupplierContactList.txtClientName.Enabled = False
                frm600_04SupplierContactList.Show()
                frm600_04SupplierContactList.FillDataSetforEditing(strSupplierCode)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnFillSubject.Click
        GetReportDetails("IMS-PO-001")
        Me.txtSubject.EditValue = gReportSubject
        Me.txtSubject.Focus()

    End Sub

    Private Sub cmdAddIntro_Click(sender As Object, e As EventArgs) Handles btnFillPOIntroduction.Click
        GetReportDetails("IMS-PO-001")
        Me.txtQuoteIntro.Text = gReportIntroduction
        Me.txtQuoteIntro.Focus()

    End Sub

    Private Sub txtAddText_Click(sender As Object, e As EventArgs) Handles btnFillPOSummary.Click
        GetReportDetails("IMS-PO-001")
        Me.txtQuoteSummary.Text = gReportSummary
        Me.txtQuoteSummary.Focus()

    End Sub

    Private Sub cmdAddThanksNotes_Click(sender As Object, e As EventArgs) Handles btnFillThanksNote.Click
        GetReportDetails("IMS-PO-001")
        Me.txtQuoteThanksNote.Text = gReportThanksNote
        Me.txtQuoteThanksNote.Focus()
    End Sub
    Private Sub btnPreviewPOWoVAT_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewPOWoVAT.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_PurchaseOrderFormat02
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-PO-002"
            Dim frm1 As New frm999_05ReportPreviewIMS_PO

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------
            rpt1.Qry604_05PurchaseOrderReportTableAdapter.FillByPONo(rpt1.DsRpt601_02PurchaseOrderReport1.qry604_05PurchaseOrderReport, Me.txtPONo.EditValue)

            'Dim rpt2 As New rpt40102QuotationTerms
            'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtPONo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtPONo.EditValue)

            rpt1.XrSubreport1.ReportSource = rpt2

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

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue
                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            'If Me.txtAdditionsAmount.EditValue = 0 Then
            '    rpt1.rowAdditions.Visible = False
            'End If

            'If Me.txtDeductionsAmount.EditValue = 0 Then
            '    rpt1.rowDeductions.Visible = False
            'End If

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.ShowHSCode.EditValue) Then
                If Me.ShowHSCode.EditValue = True Then
                    rpt1.boolShowHSCode = True
                Else
                    rpt1.boolShowHSCode = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowItemPartNumber.EditValue) Then
                If Me.txtShowItemPartNumber.EditValue = True Then
                    rpt1.boolShowItemPartNo = True
                Else
                    rpt1.boolShowItemPartNo = False
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If

            If Me.txtPrintSupplierAcceptance.EditValue = True Then
                rpt1.boolShowAcceptance = True
            Else
                rpt1.boolShowAcceptance = False
            End If

            If Me.txtPrintSupplierAcceptance02.EditValue = True Then
                rpt1.boolShowSimpleAcceptance = True
            Else
                rpt1.boolShowSimpleAcceptance = False
            End If

            If Me.txtShowSignPositionOnly.EditValue = True Then
                rpt1.boolShowOnlyPosition = True
            Else
                rpt1.boolShowOnlyPosition = False
            End If

            If Not CheckIfNull(Me.txtShowShippingDetails.EditValue) Then
                If Me.txtShowShippingDetails.EditValue = True Then
                    rpt1.boolShowShippingDetails = True
                Else
                    rpt1.boolShowShippingDetails = False
                End If
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Purchase_Order_No_" & Me.txtPONo.EditValue & "_" & Me.txtSupplierName.Text
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
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnPreviewPOwoVAT2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewPOwoVAT2.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt60102_PurchaseOrderFormat03
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-PO-003"
            Dim frm1 As New frm999_05ReportPreviewIMS_PO

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------
            rpt1.Qry604_05PurchaseOrderReportTableAdapter.FillByPONo(rpt1.DsRpt601_02PurchaseOrderReport1.qry604_05PurchaseOrderReport, Me.txtPONo.EditValue)

            'Dim rpt2 As New rpt40102QuotationTerms
            'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtPONo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtPONo.EditValue)


            rpt1.XrSubreport1.ReportSource = rpt2

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

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Me.txtAdditionsAmount.EditValue = 0 Then
                rpt1.rowAdditions.Visible = False
            End If

            If Me.txtDeductionsAmount.EditValue = 0 Then
                rpt1.rowDeductions.Visible = False
            End If

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.ShowHSCode.EditValue) Then
                If Me.ShowHSCode.EditValue = True Then
                    rpt1.boolShowHSCode = True
                Else
                    rpt1.boolShowHSCode = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowItemPartNumber.EditValue) Then
                If Me.txtShowItemPartNumber.EditValue = True Then
                    rpt1.boolShowItemPartNo = True
                Else
                    rpt1.boolShowItemPartNo = False
                End If
            End If


            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If

            If Me.txtPrintSupplierAcceptance.EditValue = True Then
                rpt1.boolShowAcceptance = True
            Else
                rpt1.boolShowAcceptance = False
            End If

            If Me.txtPrintSupplierAcceptance02.EditValue = True Then
                rpt1.boolShowSimpleAcceptance = True
            Else
                rpt1.boolShowSimpleAcceptance = False
            End If

            If Me.txtShowSignPositionOnly.EditValue = True Then
                rpt1.boolShowOnlyPosition = True
            Else
                rpt1.boolShowOnlyPosition = False
            End If

            If Not CheckIfNull(Me.txtShowShippingDetails.EditValue) Then
                If Me.txtShowShippingDetails.EditValue = True Then
                    rpt1.boolShowShippingDetails = True
                Else
                    rpt1.boolShowShippingDetails = False
                End If
            End If

            'Checkif the Purchase Order is Not Approved then show Watermark
            GetCompanyDetails02(1)
            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    rpt1.Watermark.Text = "D R A F T   C O P Y"
                    rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                    rpt1.Watermark.TextDirection = DirectionMode.Horizontal
                End If
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser

            rpt1.intCompanyID = Me.txtCompanyID.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Purchase_Order_No_" & Me.txtPONo.EditValue & "_" & Me.txtSupplierName.Text

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

            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    If rpt1.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) <> CommandVisibility.None Then
                        rpt1.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None)
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnDefaultSubject_Click(sender As Object, e As EventArgs) Handles btnDefaultSubject.Click
        'UpdateReportDefaults
        Try
            If UpdateReportDefaults(Me.txtSubject.EditValue, "ReportSubject", "IMS-PO-%") Then
                MessageBox.Show("Purchase Order Subject has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefaultIntro_Click(sender As Object, e As EventArgs) Handles btnDefaultIntro.Click
        Try
            If UpdateReportDefaults(Me.txtQuoteIntro.EditValue, "ReportIntroduction", "IMS-PO-%") Then
                MessageBox.Show("Purchase Order Introduction has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefaultSummary_Click(sender As Object, e As EventArgs) Handles btnDefaultSummary.Click
        '
        Try
            If UpdateReportDefaults(Me.txtQuoteSummary.EditValue, "ReportSummary", "IMS-PO-%") Then
                MessageBox.Show("Purchase Order Summary has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefaultThanks_Click(sender As Object, e As EventArgs) Handles btnDefaultThanks.Click
        '
        Try
            If UpdateReportDefaults(Me.txtQuoteThanksNote.EditValue, "ReportThanksNote", "IMS-PO-%") Then
                MessageBox.Show("Purchase Order Thanks Note has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data

        Try
            Dim formID As String = "frm601_07PurchaseOrderEdit_gvProjectList"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvProjectList))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvProjectList))
            End If

        Catch ex As Exception

        End Try

        Try
            Dim formID As String = "frm601_07PurchaseOrderEdit_gvGSList"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvGSList))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvGSList))
            End If

        Catch ex As Exception

        End Try

        Try
            Dim formID As String = "frm601_07PurchaseOrderEdit_gvSupplierList"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvSupplierList))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvSupplierList))
            End If

        Catch ex As Exception

        End Try

        Try
            Dim formID As String = "frm601_07PurchaseOrderEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvInvoiceChild))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvInvoiceChild))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_07PurchaseOrderEdit_gvProjectList"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)


            End If
        Catch ex As Exception

        End Try

        Try
            Dim formID As String = "frm601_07PurchaseOrderEdit_gvGSList"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)


            End If
        Catch ex As Exception

        End Try

        Try
            Dim formID As String = "frm601_07PurchaseOrderEdit_gvSupplierList"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

            End If
        Catch ex As Exception

        End Try

        Try
            Dim formID As String = "frm601_07PurchaseOrderEdit"

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
        ScannedFileLocation = gScannedLocation & "VoucherScanned\IMSPO"
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

        Try
            If CheckIfNull(Me.txtPONo.EditValue) = False Then
                Dim frm20113LedgerDocuments As New frm20113LedgerDocuments
                frm20113LedgerDocuments.ObjForm = Me
                frm20113LedgerDocuments.isExecutedFrom_frm601_07PurchaseOrderEdit = True

                frm20113LedgerDocuments.strLogOnUser = Me.strLogonUser
                frm20113LedgerDocuments.intLogOnUserID = Me.intLogOnUserID
                frm20113LedgerDocuments.intLogOnUserLevel = Me.intLogOnUserLevel
                frm20113LedgerDocuments.intLogOnAccessLevel = Me.intLogOnAccessLevel

                frm20113LedgerDocuments.Show()

                frm20113LedgerDocuments.SelectedLedgerNo = Me.txtPONo.EditValue
                frm20113LedgerDocuments.txtRefNo.EditValue = Me.txtPONo.EditValue
                frm20113LedgerDocuments.txtDocumentNo.EditValue = frm20113LedgerDocuments.GetNewDocumentNo()
                frm20113LedgerDocuments.txtDocumentType.Focus()

                frm20113LedgerDocuments.Tbl20116LedgerDocumentsTableAdapter.FillByLedgerNo(frm20113LedgerDocuments.Dsfrm20113LedgerDocuments.tbl20116LedgerDocuments, frm20113LedgerDocuments.SelectedLedgerNo)

            End If
        Catch ex As Exception
            MessageBox.Show("Error on adding new document for this Account Ledger Book, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
                frmDocuments.IsIMSPO = True
                frmDocuments.Show()
            Else
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = DocumentNo
                frmDocuments.IsIMSPO = True
                frmDocuments.Show()
                frmDocuments.OpenFileDialogBox()
            End If

        End If
    End Sub


#End Region

    Private Sub btnDefaultShipTo_Click(sender As Object, e As EventArgs) Handles btnDefaultShipTo.Click
        Try
            If UpdateReportDefaults(Me.txtShipTo.EditValue, "ReportShipTo", "IMS-PO-%") Then
                MessageBox.Show("Purchase Order Shipping Address has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefaultBillTo_Click(sender As Object, e As EventArgs) Handles btnDefaultBillTo.Click
        Try
            If UpdateReportDefaults(Me.txtBillTo.EditValue, "ReportBillTo", "IMS-PO-%") Then
                MessageBox.Show("Purchase Order Billing Address has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles btnFillShipTo.Click
        GetReportDetails("IMS-PO-001")
        Me.txtShipTo.Text = gReportShipTo
        Me.txtShipTo.Focus()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles btnFillBillTo.Click
        GetReportDetails("IMS-PO-001")
        Me.txtBillTo.Text = gReportBillTo
        Me.txtBillTo.Focus()
    End Sub

    Private Sub txtPrintSupplierAcceptance02_CheckedChanged(sender As Object, e As EventArgs) Handles txtPrintSupplierAcceptance02.CheckedChanged
        If Me.txtPrintSupplierAcceptance02.CheckState = CheckState.Checked Then
            Me.txtPrintSupplierAcceptance.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub txtPrintSupplierAcceptance_CheckedChanged(sender As Object, e As EventArgs) Handles txtPrintSupplierAcceptance.CheckedChanged
        If Me.txtPrintSupplierAcceptance.CheckState = CheckState.Checked Then
            Me.txtPrintSupplierAcceptance02.CheckState = CheckState.Unchecked
        End If
    End Sub


#Region "Currency Codes"
    Public IsVisibleOC As Boolean = False

    Public Sub SwitchColumns()
        If IsVisibleOC = True Then

            Me.colLineOrderNo.VisibleIndex = 1
            Me.colPropertyNo.VisibleIndex = 2
            Me.colDetailedDescription.VisibleIndex = 3
            Me.gcAdditionalColumns.VisibleIndex = 4
            Me.colUnitRateMethod.VisibleIndex = 5
            Me.colQuantityInvoiced.VisibleIndex = 6
            Me.colUnitRateInOC.VisibleIndex = 7
            Me.colDiscountInOC.VisibleIndex = 8
            'Me.gcCalculateDiscount.VisibleIndex = 9
            Me.colTaxSlabCode.VisibleIndex = 9
            Me.colLineTaxAmountOC.VisibleIndex = 10
            Me.colLineTotalWithTaxOC.VisibleIndex = 11

            Me.colUnitRate.Visible = False
            Me.colDiscount.Visible = False
            Me.colcalcTaxAmount.Visible = False
            Me.colLineAmount.Visible = False

            Me.colUnitRateInOC.Visible = True
            Me.colDiscountInOC.Visible = True
            Me.colLineTaxAmountOC.Visible = True
            Me.colLineTotalWithTaxOC.Visible = True

            'Me.colLineOrderNo.VisibleIndex = 0
            'Me.colPropertyNo.VisibleIndex = 1
            'Me.colDetailedDescription.VisibleIndex = 2
            'Me.gcAdditionalColumns.VisibleIndex = 3
            'Me.colUnitRateMethod.VisibleIndex = 4
            'Me.colQuantityInvoiced.VisibleIndex = 5
            'Me.colUnitRateInOC.VisibleIndex = 6
            'Me.colDiscountInOC.VisibleIndex = 7
            ''Me.gcCalculateDiscount.VisibleIndex = 9
            'Me.colTaxSlabCode.VisibleIndex = 8
            'Me.colLineTaxAmountOC.VisibleIndex = 9
            'Me.colLineTotalWithTaxOC.VisibleIndex = 10


        ElseIf IsVisibleOC = False Then
            Me.colLineOrderNo.VisibleIndex = 1
            Me.colPropertyNo.VisibleIndex = 2
            Me.colDetailedDescription.VisibleIndex = 3
            Me.gcAdditionalColumns.VisibleIndex = 4
            Me.colUnitRateMethod.VisibleIndex = 5
            Me.colQuantityInvoiced.VisibleIndex = 6
            Me.colUnitRate.VisibleIndex = 7
            Me.colDiscount.VisibleIndex = 8
            'Me.gcCalculateDiscount.VisibleIndex = 10
            Me.colTaxSlabCode.VisibleIndex = 9
            Me.colcalcTaxAmount.VisibleIndex = 10
            Me.colLineAmount.VisibleIndex = 11

            Me.colUnitRate.Visible = True
            Me.colDiscount.Visible = True
            Me.colcalcTaxAmount.Visible = True
            Me.colLineAmount.Visible = True

            Me.colUnitRateInOC.Visible = False
            Me.colDiscountInOC.Visible = False
            Me.colLineTaxAmountOC.Visible = False
            Me.colLineTotalWithTaxOC.Visible = False
        End If

    End Sub

    Private Sub txtCurrency_Validated(sender As Object, e As EventArgs) Handles txtCurrency.Validated
        If Me.txtCurrency.EditValue = 1 Then
            Me.IsVisibleOC = False
            SwitchColumns()
        Else
            Me.IsVisibleOC = True
            SwitchColumns()
        End If
    End Sub


    Private Sub txtCurrency_EditValueChanged(sender As Object, e As EventArgs) Handles txtCurrency.EditValueChanged
        Try
            If CheckIfNull(Me.txtCurrency.EditValue) = False Then
                Me.txtCurrencyExchangeRate.EditValue = Me.Dsfrm601_07PurchaseOrderEdit.Tables("tbl20169CurrencyExchange").Rows.Find(Me.txtCurrency.EditValue).Item("ExchangeRate")
                Me.txtCurrencyExchangeRate.Focus()
            End If

            'Take the Value and Multiply it with all the Items amount

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCurrency_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCurrency.ButtonClick
        If e.Button.Index = 1 Then

            Dim frm20167CurrencyEdit As New frm20167CurrencyEdit
            frm20167CurrencyEdit.ObjForm = Me
            frm20167CurrencyEdit.Show()
            frm20167CurrencyEdit.txtCurrencyName.Focus()
            frm20167CurrencyEdit.isExecutedFrom_frm20161VATInvoiceEdit = True

        End If

    End Sub

#End Region

    Private Sub btnPreviewPOinFC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewPOinFC.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_02PurchaseOrderFormatFC
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-PO-004"
            Dim frm1 As New frm999_05ReportPreviewIMS_PO

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------
            rpt1.Qry604_05PurchaseOrderReportTableAdapter.FillByPONo(rpt1.DsRpt601_02PurchaseOrderReport1.qry604_05PurchaseOrderReport, Me.txtPONo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtPONo.EditValue)

            rpt1.XrSubreport1.ReportSource = rpt2

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

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Me.txtAdditionsAmount.EditValue = 0 Then
                rpt1.rowAdditions.Visible = False
            End If

            If Me.txtDeductionsAmount.EditValue = 0 Then
                rpt1.rowDeductions.Visible = False
            End If

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.ShowHSCode.EditValue) Then
                If Me.ShowHSCode.EditValue = True Then
                    rpt1.boolShowHSCode = True
                Else
                    rpt1.boolShowHSCode = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowItemPartNumber.EditValue) Then
                If Me.txtShowItemPartNumber.EditValue = True Then
                    rpt1.boolShowItemPartNo = True
                Else
                    rpt1.boolShowItemPartNo = False
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If

            If Me.txtPrintSupplierAcceptance.EditValue = True Then
                rpt1.boolShowAcceptance = True
            Else
                rpt1.boolShowAcceptance = False
            End If

            If Me.txtPrintSupplierAcceptance02.EditValue = True Then
                rpt1.boolShowSimpleAcceptance = True
            Else
                rpt1.boolShowSimpleAcceptance = False
            End If

            If Me.txtShowSignPositionOnly.EditValue = True Then
                rpt1.boolShowOnlyPosition = True
            Else
                rpt1.boolShowOnlyPosition = False
            End If

            If Not CheckIfNull(Me.txtShowShippingDetails.EditValue) Then
                If Me.txtShowShippingDetails.EditValue = True Then
                    rpt1.boolShowShippingDetails = True
                Else
                    rpt1.boolShowShippingDetails = False
                End If
            End If

            'Checkif the Purchase Order is Not Approved then show Watermark
            GetCompanyDetails02(1)
            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    rpt1.Watermark.Text = "D R A F T   C O P Y"
                    rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                    rpt1.Watermark.TextDirection = DirectionMode.Horizontal
                End If
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue
            rpt1.ImsPONo = Me.txtPONo.EditValue
            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Purchase_Order_No_" & Me.txtPONo.EditValue & "_" & Me.txtSupplierName.Text
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

            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    If rpt1.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) <> CommandVisibility.None Then
                        rpt1.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None)
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSubmit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSubmit.ItemClick
        Me.SaveAll(False)

        If Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild.Rows.Count = 0 Then
            MessageBox.Show("Please check the Purchase Order, no Line Item to submit the PO.", "PO has no Line Items", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if the Purchase Order has any amount to submit
        If GetPOChildTotal(Me.txtPONo.EditValue) = 0 Then
            MessageBox.Show("Please check the Purchase Order, no amount to submit the PO.", "PO Amount Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_btnSubmit") = False Then
            MessageBox.Show("You have no Access rights to Submit the Purchase Order. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this PO Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Submitting User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.SubmitPurchaseOrder(Me.txtPONo.EditValue)

        Dim PONumber As String = Me.txtPONo.EditValue
        Dim RevisionNo As String = Me.txtRevisionNo.EditValue

        If CheckIfNull(Me.txtRevisionNo.EditValue) = False Then
            PONumber = PONumber & " (" & RevisionNo & ")"
        End If

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60107-001")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " submitted PO_No: " & PONumber & " for your verification."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New Purchase Order is ready to verify.")

        End If

        If gIsEmailToProjectSubUnits = True Then
            'get the details of the Requesting Unit.. use the emails for that unit assigned Alert Settings
            Dim AlertCode As String = GetProjectSubUnitsAlertCode(Me.txtRequestingUnit.EditValue, "AlertCode_MPO_Submit")

            If CheckIfNull(AlertCode) = True Or AlertCode = "" Then
                MessageBox.Show("No Alert code is set to forward emails for this Project Sub Unit.", "No Code to Retreive")
            Else
                GetAlertSettings(AlertCode)
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has submitted Purchase Order No. <font color=blue><b>" & PONumber & "</b></font> for your verification."

                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPO_" & PONumber & "_Submission.pdf"
                ExportPurchaseOrderToPDF(DestinationFile)

                If gIsEmailToRequester = True Then
                    gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Purchase Order Submitted for Verification (" & PONumber & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Else
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Purchase Order Submitted for Verification (" & PONumber & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                End If

                Me.SplashScreenManager1.CloseWaitForm()
            End If

        Else

            If gIsEmailAlertActivated = True Then
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has submitted Purchase Order No. <font color=blue><b>" & PONumber & "</b></font> for your verification."

                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPO_" & PONumber & "_Submission.pdf"
                ExportPurchaseOrderToPDF(DestinationFile)
                SendEmailsWtAttachment(gEmailAlertSetForEmails, "Purchase Order Submitted for Verification (" & PONumber & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Me.SplashScreenManager1.CloseWaitForm()

            End If

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshPOMasterDataGrid()
    End Sub

    Private Function GetPOChildTotal(ByVal PONo As String) As Decimal
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "[sp604_01GetPurchaseOrderChildTotal]"
            SqlCommand1.Parameters.Add("@PONo", SqlDbType.VarChar).Value = PONo
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            Dim TotalAmount1 As Decimal = 0D

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    If CheckIfNull(srStockReader.Item("TotalWithTax")) = False Then
                        TotalAmount1 = srStockReader.Item("TotalWithTax")
                        Return TotalAmount1
                    Else
                        Return 0D
                    End If

                End While
            Else
                Return 0D
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return 0D
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Public Function CheckIfItemIsEnabled(ByVal UserID As String, ByVal ItemName As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select UserID, ItemName, ItemVisible from tblUserAccess where (UserID = '" & UserID & "') AND (ItemName = '" & ItemName & "') AND (ItemVisible = 1)"

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

    Private Sub SubmitPurchaseOrder(ByVal PONo As String)
        Try
            If CheckIfNull(PONo) = False Then

                Me.Validate()
                Dim view As DataRowView = DirectCast(Me.Tbl60401PurchaseOrderMasterBindingSource.Current, DataRowView)
                view.Row("IsSubmitted") = True
                view.Row("SubmittedBy") = Me.strLogonUser
                view.Row("SubmittedOn") = Date.Now

                view.Row("ModifiedBy") = Me.strLogonUser
                view.Row("ModifiedOn") = Date.Now

                view.Row("POSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

                Me.Tbl60401PurchaseOrderMasterBindingSource.EndEdit()
                Me.Tbl604_01PurchaseOrderMasterTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.tbl604_01PurchaseOrderMaster)
                MessageBox.Show("Purchase Order has been submitted for Approval.", "Submit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnVerify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerify.ItemClick
        Try
            If Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild.Rows.Count = 0 Then
                MessageBox.Show("Please check the Purchase Order, no Line Item to verify the PO.", "PO has no Line Items", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Check if the User is allowed to verify the PO
            If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_btnVerify") = False Then
                MessageBox.Show("You have no Access rights to Verify the Purchase Order. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Check if this PO Signatory have Verification Signature
            If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
                MessageBox.Show("Verifying User have not assigned to Signatory in the System.", "Verify Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Check if this PO is submitted
            If CheckIfPOIsSubmitted(Me.txtPONo.EditValue) = False Then
                MessageBox.Show("Purchase Order is not yet Submitted, please submit the PO for verfication process.", "PO Not Submitted for verification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            SaveAll(False)
            Me.VerifyPO(Me.txtPONo.EditValue)

            Dim PONumber As String = Me.txtPONo.EditValue
            Dim RevisionNo As String = Me.txtRevisionNo.EditValue

            If CheckIfNull(Me.txtRevisionNo.EditValue) = False Then
                PONumber = PONumber & " (" & RevisionNo & ")"
            End If

            'Check whether Alert Activation for Verification to Approval is set then
            'Make an Alert to the Verifier
            GetAlertSettings("SYS-60107-002")
            If gIsAlertActivated = True Then
                'Add an alert
                GetCompanyDetails02(1)
                Dim AlertMessage2 As String = ""
                AlertMessage2 = Me.strLogonUser & " has sent PO_No: " & PONumber & " for your approval."
                InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New Purchase Order is ready to approve.")

            End If

            If gIsEmailToProjectSubUnits = True Then
                'get the details of the Requesting Unit.. use the emails for that unit assigned Alert Settings
                Dim AlertCode As String = GetProjectSubUnitsAlertCode(Me.txtRequestingUnit.EditValue, "AlertCode_MPO_Verify")

                If CheckIfNull(AlertCode) = True Or AlertCode = "" Then
                    MessageBox.Show("No Alert code is set to forward emails for this Project Sub Unit.", "No Code to Retreive")
                Else
                    GetAlertSettings(AlertCode)
                    Me.SplashScreenManager1.ShowWaitForm()
                    Dim AlertMessage2 As String = ""
                    AlertMessage2 = "Mr. " & Me.strLogonUser & " has Verified Purchase Order No. <font color=blue><b>" & PONumber & "</b></font> for your approval."

                    If Not Directory.Exists("C:\ReportsToEmail") Then
                        Directory.CreateDirectory("C:\ReportsToEmail")
                    End If

                    Dim DestinationFile As String = "C:\ReportsToEmail"
                    DestinationFile = DestinationFile & "\MPO_" & PONumber & "_Verification.pdf"
                    ExportPurchaseOrderToPDF(DestinationFile)

                    If gIsEmailToRequester = True Then
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue
                        SendEmailsWtAttachment(gEmailAlertSetForEmails, "Purchase Order Verified for Approval (" & PONumber & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                    Else
                        SendEmailsWtAttachment(gEmailAlertSetForEmails, "Purchase Order Verified for Approval (" & PONumber & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                    End If

                    Me.SplashScreenManager1.CloseWaitForm()
                End If

            Else

                If gIsEmailAlertActivated = True Then
                    Me.SplashScreenManager1.ShowWaitForm()
                    Dim AlertMessage2 As String = ""
                    AlertMessage2 = "Mr. " & Me.strLogonUser & " has Verified Purchase Order No. <font color=blue><b>" & PONumber & "</b></font> for your approval."

                    If Not Directory.Exists("C:\ReportsToEmail") Then
                        Directory.CreateDirectory("C:\ReportsToEmail")
                    End If

                    Dim DestinationFile As String = "C:\ReportsToEmail"
                    DestinationFile = DestinationFile & "\MPO_" & PONumber & "_Verification.pdf"
                    ExportPurchaseOrderToPDF(DestinationFile)
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Purchase Order Verified for Approval (" & PONumber & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                    Me.SplashScreenManager1.CloseWaitForm()

                End If

            End If

            'Disable editing of controls
            DisableAllControls()
            'Check if the login user is an Finance Admin and enable btnPayClaim
            'If is updated from Master Datagrid refresh it
            RefreshPOMasterDataGrid()

        Catch ex As Exception
            MessageBox.Show("Error Occured while Verifying the Purchase Order." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Verifying", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub VerifyPO(ByVal PONo As String)
        Try
            If CheckIfNull(PONo) = False Then

                Me.Validate()
                Dim view As DataRowView = DirectCast(Me.Tbl60401PurchaseOrderMasterBindingSource.Current, DataRowView)

                view.Row("IsVerified") = True
                view.Row("VerifiedBy") = Me.strLogonUser
                view.Row("VerifiedOn") = Date.Now

                view.Row("POVerifiedSign") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

                Me.Tbl60401PurchaseOrderMasterBindingSource.EndEdit()
                Me.Tbl604_01PurchaseOrderMasterTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.tbl604_01PurchaseOrderMaster)
                MessageBox.Show("Purchase Order has been verified for Approval.", "Verification Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnApprove.ItemClick
        Try
            If Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild.Rows.Count = 0 Then
                MessageBox.Show("Please check the Purchase Order, no Line Item to Approve the PO.", "PO has no Line Items", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Check if the Purchase Order has any amount to submit
            If GetPOChildTotal(Me.txtPONo.EditValue) = 0 Then
                MessageBox.Show("Please check the Purchase Order, no amount to submit the PO.", "PO Amount Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Check if the User is allowed to Submit the Form
            If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_btnApprove") = False Then
                MessageBox.Show("You have no Access rights to Approve the Purchase Order. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Check if this PO is Verified
            If CheckIfPOIsVerified(Me.txtPONo.EditValue) = False Then
                MessageBox.Show("Purchase Order is not yet Verified, please verify the PO for Approval process.", "PO Not Submitted for Approval", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Check if this PO Signatory have Verification Signature
            If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
                MessageBox.Show("Approving User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            SaveAll(False)
            Me.ApprovePO(Me.txtPONo.EditValue)

            Dim PONumber As String = Me.txtPONo.EditValue
            Dim RevisionNo As String = Me.txtRevisionNo.EditValue

            If CheckIfNull(Me.txtRevisionNo.EditValue) = False Then
                PONumber = PONumber & " (" & RevisionNo & ")"
            End If

            'Check whether Alert Activation for Submission to Verification is set then
            'Make an Alert to the Verifier
            GetAlertSettings("SYS-60107-003")
            If gIsAlertActivated = True Then
                'Add an alert
                GetCompanyDetails02(1)
                Dim AlertMessage2 As String = ""
                AlertMessage2 = Me.strLogonUser & " has approved PO_NO: " & PONumber & " for Proceeding."
                InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify Purchase Order is ready to proceed.")

            End If

            If gIsEmailToProjectSubUnits = True Then
                'get the details of the Requesting Unit.. use the emails for that unit assigned Alert Settings
                Dim AlertCode As String = GetProjectSubUnitsAlertCode(Me.txtRequestingUnit.EditValue, "AlertCode_MPO_Approve")

                If CheckIfNull(AlertCode) = True Or AlertCode = "" Then
                    MessageBox.Show("No Alert code is set to forward emails for this Project Sub Unit.", "No Code to Retreive")
                Else
                    GetAlertSettings(AlertCode)
                    Me.SplashScreenManager1.ShowWaitForm()
                    Dim AlertMessage2 As String = ""
                    AlertMessage2 = "Mr. " & Me.strLogonUser & " has Approved Purchase Order No. <font color=blue><b>" & PONumber & "</b></font> for further Processing."

                    If Not Directory.Exists("C:\ReportsToEmail") Then
                        Directory.CreateDirectory("C:\ReportsToEmail")
                    End If

                    Dim DestinationFile As String = "C:\ReportsToEmail"
                    DestinationFile = DestinationFile & "\MPO_" & PONumber & "_Approved.pdf"
                    ExportPurchaseOrderToPDF(DestinationFile)

                    If gIsEmailToRequester = True Then
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue
                        SendEmailsWtAttachment(gEmailAlertSetForEmails, "Purchase Order Approved for Processing (" & PONumber & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                    Else
                        SendEmailsWtAttachment(gEmailAlertSetForEmails, "Purchase Order Approved for Processing (" & PONumber & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                    End If

                    Me.SplashScreenManager1.CloseWaitForm()
                End If

            Else

                If gIsEmailAlertActivated = True Then
                    Me.SplashScreenManager1.ShowWaitForm()
                    Dim AlertMessage2 As String = ""
                    AlertMessage2 = "Mr. " & Me.strLogonUser & " has Approved Purchase Order No. <font color=blue><b>" & PONumber & "</b></font> for further Processing."

                    If Not Directory.Exists("C:\ReportsToEmail") Then
                        Directory.CreateDirectory("C:\ReportsToEmail")
                    End If

                    Dim DestinationFile As String = "C:\ReportsToEmail"
                    DestinationFile = DestinationFile & "\MPO_" & PONumber & "_Approved.pdf"
                    ExportPurchaseOrderToPDF(DestinationFile)
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Purchase Order Approved for Processing (" & PONumber & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                    Me.SplashScreenManager1.CloseWaitForm()

                End If

            End If
            'Disable editing of controls
            DisableAllControls()
            'Check if the login user is an Finance Admin and enable btnPayClaim
            'If is updated from Master Datagrid refresh it
            RefreshPOMasterDataGrid()

        Catch ex As Exception
            MessageBox.Show("Error Occured while Approving the Claim." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Approving", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApprovePO(ByVal PONo As String)
        If CheckIfNull(PONo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60401PurchaseOrderMasterBindingSource.Current, DataRowView)

            view.Row("IsApproved") = True
            view.Row("ApprovedBy") = Me.strLogonUser
            view.Row("ApprovedOn") = Date.Now
            view.Row("POApprovedSign") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            Me.Tbl60401PurchaseOrderMasterBindingSource.EndEdit()
            Me.Tbl604_01PurchaseOrderMasterTableAdapter.Update(Me.Dsfrm601_07PurchaseOrderEdit.tbl604_01PurchaseOrderMaster)
            MessageBox.Show("Purchase Order has been approved for proceeding.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDistributeDiscount_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDistributeDiscount.ItemClick
        Try

            Dim frm601_38PODiscountDistribution As New frm601_38PODiscountDistribution
            frm601_38PODiscountDistribution.objForm = Me
            frm601_38PODiscountDistribution.isExecutedFrom_frm601_07PurchaseOrderEdit = True

            frm601_38PODiscountDistribution.strLogOnUser = Me.strLogonUser
            frm601_38PODiscountDistribution.intLogOnUserID = Me.intLogOnUserID
            frm601_38PODiscountDistribution.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_38PODiscountDistribution.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_38PODiscountDistribution.PurchaseOrderNo = Me.txtPONo.EditValue

            frm601_38PODiscountDistribution.Show()
            frm601_38PODiscountDistribution.RetrieveVoucher(Me.txtPONo.EditValue)



        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPOCategory_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtPOCategory.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm600_13POCategories As New frm600_13POCategories
            frm600_13POCategories.ObjForm = Me
            frm600_13POCategories.Show()
            frm600_13POCategories.txtPropertyCategory.Focus()
            frm600_13POCategories.isExecutedFrom_frm601_07PurchaseOrderEdit = True
        End If
    End Sub

    Private Sub btnAddDocuments_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddDocuments.ItemClick
        Try
            If CheckIfNull(Me.txtPONo.EditValue) = False Then
                Dim frm20113LedgerDocuments As New frm20113LedgerDocuments
                frm20113LedgerDocuments.ObjForm = Me
                frm20113LedgerDocuments.isExecutedFrom_frm601_07PurchaseOrderEdit = True

                frm20113LedgerDocuments.strLogOnUser = Me.strLogonUser
                frm20113LedgerDocuments.intLogOnUserID = Me.intLogOnUserID
                frm20113LedgerDocuments.intLogOnUserLevel = Me.intLogOnUserLevel
                frm20113LedgerDocuments.intLogOnAccessLevel = Me.intLogOnAccessLevel

                frm20113LedgerDocuments.Show()

                frm20113LedgerDocuments.SelectedLedgerNo = Me.txtPONo.EditValue
                frm20113LedgerDocuments.txtRefNo.EditValue = Me.txtPONo.EditValue
                frm20113LedgerDocuments.txtDocumentNo.EditValue = frm20113LedgerDocuments.GetNewDocumentNo()
                frm20113LedgerDocuments.txtDocumentType.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show("Error on adding new document for this Account Ledger Book, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        GetTheScannedFileLocation()
        AttachFile(Me.txtPONo.EditValue, ScannedFileLocation)
    End Sub

    Private Sub btnDeleteSelectedLineItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteSelectedLineItems.ItemClick
        DialogResult = MessageBox.Show("You are about to delete all the Selected Purchase Order Line Items." & vbCrLf & "Are you Sure want to delete this Purchase Order Details?", "Delete Purchase Order Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Dim view As GridView = gvInvoiceChild
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    Dim ChosenDeliveryNoteSlNo As Integer = view.GetRowCellValue(row, view.Columns("POChildNo"))
                    Me.DeletePOChild(ChosenDeliveryNoteSlNo, False)

                Next
            End If
            'Refresh the datagrid
            'fill child details in the datagrid
            Me.Qry604_02PurchaseOrderChildTableAdapter.FillByPONo(Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild, Me.txtPONo.EditValue)

            'Check if the PO has line items.. If available disable currency choosing, else enable currency.
            If Me.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild.Rows.Count = 0 Then
                Me.txtCurrency.Enabled = True
                Me.txtCurrencyExchangeRate.Enabled = True

            End If

        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub

        End If
    End Sub

    Private Sub txtProjectCode_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtProjectCode.Properties.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm700_07ProjectsSimpleEditForm As New frm700_07ProjectsSimpleEditForm
            frm700_07ProjectsSimpleEditForm.ObjForm = Me
            frm700_07ProjectsSimpleEditForm.Show()
            frm700_07ProjectsSimpleEditForm.txtProjectGroup.Focus()
            frm700_07ProjectsSimpleEditForm.isExecutedFrom_frm601_07PurchaseOrderEdit = True
        End If
    End Sub

    Private Sub txtPODate_Leave(sender As Object, e As EventArgs) Handles txtPODate.Leave
        'DATE BLOCKING
        GetCompanyDetails02(1)
        If gIsDateLockingEnabled = True Then
            If CheckIfNull(Me.txtPODate.EditValue) = True Then
                Me.txtPODate.EditValue = Date.Today()
            End If
            If CheckIfDateBeenLocked("IMS_PO", Me.txtPODate.EditValue) = True Then
                MessageBox.Show("This Purchase Order Entry date has been blocked." & vbCrLf & "Please review your entry date.", "Entry Date is Blocked", MessageBoxButtons.OK)
                Me.txtPODate.EditValue = Me.txtPODate.OldEditValue
                Me.txtPODate.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ExportPurchaseOrderToPDF(ByVal SaveInPath As String)
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_02PurchaseOrderFormat01
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-PO-001"
            Dim frm1 As New frm999_05ReportPreviewIMS_PO

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------
            rpt1.Qry604_05PurchaseOrderReportTableAdapter.FillByPONo(rpt1.DsRpt601_02PurchaseOrderReport1.qry604_05PurchaseOrderReport, Me.txtPONo.EditValue)

            'Dim rpt2 As New rpt40102QuotationTerms
            'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtPONo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtPONo.EditValue)

            rpt1.XrSubreport1.ReportSource = rpt2

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

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Me.txtAdditionsAmount.EditValue = 0 Then
                rpt1.rowAdditions.Visible = False
            End If

            If Me.txtDeductionsAmount.EditValue = 0 Then
                rpt1.rowDeductions.Visible = False
            End If

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.ShowHSCode.EditValue) Then
                If Me.ShowHSCode.EditValue = True Then
                    rpt1.boolShowHSCode = True
                Else
                    rpt1.boolShowHSCode = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowItemPartNumber.EditValue) Then
                If Me.txtShowItemPartNumber.EditValue = True Then
                    rpt1.boolShowItemPartNo = True
                Else
                    rpt1.boolShowItemPartNo = False
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If

            If Me.txtPrintSupplierAcceptance.EditValue = True Then
                rpt1.boolShowAcceptance = True
            Else
                rpt1.boolShowAcceptance = False
            End If

            If Me.txtPrintSupplierAcceptance02.EditValue = True Then
                rpt1.boolShowSimpleAcceptance = True
            Else
                rpt1.boolShowSimpleAcceptance = False
            End If

            If Me.txtShowSignPositionOnly.EditValue = True Then
                rpt1.boolShowOnlyPosition = True
            Else
                rpt1.boolShowOnlyPosition = False
            End If

            If Not CheckIfNull(Me.txtShowShippingDetails.EditValue) Then
                If Me.txtShowShippingDetails.EditValue = True Then
                    rpt1.boolShowShippingDetails = True
                Else
                    rpt1.boolShowShippingDetails = False
                End If
            End If

            'Checkif the Purchase Order is Not Approved then show Watermark
            GetCompanyDetails02(1)
            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    rpt1.Watermark.Text = "D R A F T   C O P Y"
                    rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                    rpt1.Watermark.TextDirection = DirectionMode.Horizontal
                End If
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Purchase_Order_No_" & Me.txtPONo.EditValue & "_" & Me.txtSupplierName.Text
            rpt1.RequestParameters = False

            rpt1.ExportToPdf(SaveInPath)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

#Region "Populate Custom Report Buttons"
    'Change this code for other forms.. 
    Dim CustomReportFormNo As Integer = 7

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

            Dim rpt1 As New rpt601_02PurchaseOrderFormat01
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = ReportNo
            Dim frm1 As New frm999_05ReportPreviewIMS_PO

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------
            rpt1.Qry604_05PurchaseOrderReportTableAdapter.FillByPONo(rpt1.DsRpt601_02PurchaseOrderReport1.qry604_05PurchaseOrderReport, Me.txtPONo.EditValue)

            'Dim rpt2 As New rpt40102QuotationTerms
            'rpt2.Qry40107RptQuoteTermsTableAdapter.Fill(rpt2.DsRpt40102QuotationTerms1.qry40107RptQuoteTerms, Me.txtPONo.EditValue)

            Dim rpt2 As New rpt601_08QuotationTerms
            rpt2.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(rpt2.Dsrpt601_08QuotationTerms1.tbl601_03QuotationTerms, Me.txtPONo.EditValue)

            rpt1.XrSubreport1.ReportSource = rpt2

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

            rpt1.XrPageBreak1.Visible = Me.ShowPageBreak1.EditValue
            rpt1.XrPageBreak2.Visible = Me.ShowPageBreak2.EditValue

            If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
                If Me.txtShowCompanySeal.EditValue = True Then
                    rpt1.txtCompanySeal.Visible = True
                Else
                    rpt1.txtCompanySeal.Visible = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
                End If
            End If

            If Me.txtAdditionsAmount.EditValue = 0 Then
                rpt1.rowAdditions.Visible = False
            End If

            If Me.txtDeductionsAmount.EditValue = 0 Then
                rpt1.rowDeductions.Visible = False
            End If

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            If Not CheckIfNull(Me.ShowHSCode.EditValue) Then
                If Me.ShowHSCode.EditValue = True Then
                    rpt1.boolShowHSCode = True
                Else
                    rpt1.boolShowHSCode = False
                End If
            End If

            If Not CheckIfNull(Me.txtShowItemPartNumber.EditValue) Then
                If Me.txtShowItemPartNumber.EditValue = True Then
                    rpt1.boolShowItemPartNo = True
                Else
                    rpt1.boolShowItemPartNo = False
                End If
            End If

            If Not CheckIfNull(Me.txtVerifiedSign.EditValue) Then
                If Me.txtVerifiedSign.EditValue = 99 Then
                    rpt1.boolShowVerifiedBy = False
                Else
                    rpt1.boolShowVerifiedBy = True
                End If
            End If

            If Not CheckIfNull(Me.txtApprovedSign.EditValue) Then
                If Me.txtApprovedSign.EditValue = 99 Then
                    rpt1.boolShowApprovedBy = False
                Else
                    rpt1.boolShowApprovedBy = True
                End If
            End If

            If Me.txtPrintSupplierAcceptance.EditValue = True Then
                rpt1.boolShowAcceptance = True
            Else
                rpt1.boolShowAcceptance = False
            End If

            If Me.txtPrintSupplierAcceptance02.EditValue = True Then
                rpt1.boolShowSimpleAcceptance = True
            Else
                rpt1.boolShowSimpleAcceptance = False
            End If

            If Me.txtShowSignPositionOnly.EditValue = True Then
                rpt1.boolShowOnlyPosition = True
            Else
                rpt1.boolShowOnlyPosition = False
            End If

            If Not CheckIfNull(Me.txtShowShippingDetails.EditValue) Then
                If Me.txtShowShippingDetails.EditValue = True Then
                    rpt1.boolShowShippingDetails = True
                Else
                    rpt1.boolShowShippingDetails = False
                End If
            End If

            'Checkif the Purchase Order is Not Approved then show Watermark
            GetCompanyDetails02(1)
            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    rpt1.Watermark.Text = "D R A F T   C O P Y"
                    rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                    rpt1.Watermark.TextDirection = DirectionMode.Horizontal
                End If
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser
            rpt1.intCompanyID = Me.txtCompanyID.EditValue

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Purchase_Order_No_" & Me.txtPONo.EditValue & "_" & Me.txtSupplierName.Text
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

            If gIsImplementPOWorkflow = True Then
                If CheckIfPOIsApproved(Me.txtPONo.EditValue) = False Then
                    If rpt1.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) <> CommandVisibility.None Then
                        rpt1.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None)
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnUseItemDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60402PurchaseOrderChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.Text = GetGSCodeDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUseItemDetailedDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDetailedDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60402PurchaseOrderChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.Text = GetGSCodeDetailedDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub




#End Region
End Class