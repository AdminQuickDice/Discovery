Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraReports.UI


Imports System.Drawing
Imports DevExpress.XtraPrinting.Drawing
Imports System.Text
Imports DevExpress.XtraBars

Public Class frm601_11PurchaseRequestEdit

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

    Dim SelectedPurchaseRequestChildSlNo As Integer

    Public CreatedNewPurchaseRequestNo As String

    Public isExecutedFrom_frm700_01ProjectsEdit As Boolean = False
    Public isExecutedFrom_frm601_12PurchaseRequestView As Boolean = False

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

    Public Sub UpdateDefaultFields(ByVal RequestedBy As Integer)
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                If Me.intLogOnDivision = 99 Then
                    Me.txtCompanyID.EditValue = 1
                Else
                    Me.txtCompanyID.EditValue = Me.intLogOnDivision
                End If

                If Me.intLogOnInventoryAccessLevel = 99 Then
                    Me.txtInventoryGroupMaster.EditValue = 1
                    Me.txtInventoryGroupMaster.Enabled = True

                Else
                    Me.txtInventoryGroupMaster.EditValue = Me.intLogOnInventoryAccessLevel
                    Me.txtInventoryGroupMaster.Enabled = False
                End If

                Me.txtRequestedBy.EditValue = RequestedBy
                Me.txtRequestedBy.Enabled = False
                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageQuoteDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)

                DisableControlsForRequestType(RequestedBy)

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


            End If
        Next



    End Sub

    Public Sub DisableControlsForRequestType(ByVal RequestedBy As Integer)
        If RequestedBy = 1 Then
            Me.txtStoreCode.Enabled = False
            Me.txtDepartmentRequeste.Enabled = False
            Me.txtProjectCode.Enabled = False

        ElseIf RequestedBy = 2 Then
            Me.txtClientName.Enabled = False
            'Change label to Requested By:
            Me.lblClientRefName.Text = "Name of the Store Incharge:"
            Me.txtClientRefName.Enabled = True

            Me.txtReferenceNo.Enabled = True
            Me.txtClientContactNo.Enabled = True
            Me.txtClientEmail.Enabled = True

            Me.txtDepartmentRequeste.Enabled = False
            Me.txtProjectCode.Enabled = False

        ElseIf RequestedBy = 3 Then
            Me.txtClientName.Enabled = False
            'Change label to Requested By:
            Me.lblClientRefName.Text = "Name of the Department Incharge:"
            Me.txtClientRefName.Enabled = True

            Me.txtReferenceNo.Enabled = True
            Me.txtClientContactNo.Enabled = True
            Me.txtClientEmail.Enabled = True

            Me.txtProjectCode.Enabled = False

        ElseIf RequestedBy = 4 Then
            Me.txtClientName.Enabled = False

            'Change label to Requested By:
            Me.lblClientRefName.Text = "Name of the Requester:"
            Me.txtClientRefName.Enabled = True

            Me.txtReferenceNo.Enabled = True
            Me.txtClientContactNo.Enabled = True
            Me.txtClientEmail.Enabled = True

            Me.txtDepartmentRequeste.Enabled = False
            Me.txtStoreCode.Enabled = True
            Me.txtProjectCode.Enabled = True
        End If
    End Sub

    Public Sub DisableControlsForInventoryGroupMaster(ByVal InventoryGroupMaster As Integer)
        If InventoryGroupMaster = 99 Then
            Me.txtInventoryGroupMaster.Enabled = True
        Else
            Me.txtInventoryGroupMaster.Enabled = False
        End If

    End Sub

    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtRequestNo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtRequestNo, "Request Number Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtRequestNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtRequestDate.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtRequestDate, "Requested Date must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtRequestDate, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        'If String.IsNullOrEmpty(ConvertIfNull(Me.txtClientName.EditValue)) Then
        '    Me.DxErrorProvider1.SetError(Me.txtClientName, "Client must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'Else
        '    Me.DxErrorProvider1.SetError(Me.txtClientName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'End If

    End Sub

    Public Sub RetrieveRequestMaster(ByVal RequestNo As String)
        Try
            If CheckIfNull(RequestNo) = False Then
                'fill master details
                Me.Tbl606_01PurchaseRequestMasterTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_01PurchaseRequestMaster, RequestNo)

                'fill child details in the datagrid
                Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, RequestNo)

                Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit10.tbl601_07QuotationChildItemGroup, RequestNo)
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Request Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateRequestMaster(ByVal RequestNo As String, ByVal WithMessage As Boolean)
        If CheckIfNull(RequestNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60601PurchaseRequestMasterBindingSource.Current, DataRowView)
            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            Me.Tbl60601PurchaseRequestMasterBindingSource.EndEdit()
            Me.Tbl606_01PurchaseRequestMasterTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_01PurchaseRequestMaster)

            If WithMessage = True Then
                MessageBox.Show("Request Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SaveNewRequestMaster(ByVal RequestNo As String)
        If CheckIfNull(RequestNo) = False Then
            If isBeingNew = True Then
                Dim view As DataRowView = DirectCast(Me.Tbl60601PurchaseRequestMasterBindingSource.Current, DataRowView)
                view.Row("AddedBy") = Me.strLogonUser
                view.Row("AddedOn") = Date.Now
                Me.Validate()

                Me.Tbl60601PurchaseRequestMasterBindingSource.EndEdit()
                Me.Tbl606_01PurchaseRequestMasterTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_01PurchaseRequestMaster)
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

    Public Sub SaveAll(ByVal WithMessage As Boolean)
        CheckMasterErrors()
        If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
            MessageBox.Show("Cannot continue saving with errors, please clear the errors and continue.", "Clear Errors", MessageBoxButtons.OK)
            Exit Sub

        End If

        If Me.btnSave.Caption = "Update" Then
            UpdateRequestMaster(Me.txtRequestNo.EditValue, WithMessage)
            Me.btnSave.Caption = "Update"

        ElseIf Me.btnSave.Caption = "Save" Then
            If Me.isBeingNew = True Then
                SaveNewRequestMaster(Me.txtRequestNo.EditValue)
                Me.btnSave.Caption = "Update"
            End If
        End If

        Try

            'Update the Data in the Child
            Me.Qry60602PurchaseRequestChildBindingSource.EndEdit()
            Me.Qry606_02PurchaseRequestChildTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild)
            Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshRequestMasterDataGrid()
    End Sub

    Private Sub RefreshRequestMasterDataGrid()
        If isExecutedFrom_frm700_01ProjectsEdit = True Then
            Try
                CType(ObjForm, frm700_01ProjectsEdit).Qry700_07ProjectRequestsTableAdapter.FillByProjectMasterCode(CType(ObjForm, frm700_01ProjectsEdit).Dsfrm700_01ProjectsEdit.qry700_07ProjectRequests, Me.txtProjectCode.EditValue)

            Catch ex As Exception

            End Try
        End If

        If isExecutedFrom_frm601_12PurchaseRequestView = True Then
            Try
                CType(ObjForm, frm601_12PurchaseRequestView).RetrieveVoucher(CType(ObjForm, frm601_12PurchaseRequestView).txtStartDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).txtEndDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).SelectedRequestedType)
                CType(ObjForm, frm601_12PurchaseRequestView).UpdateFrames()
                GoBackToRow(CType(ObjForm, frm601_12PurchaseRequestView).gvAdvBandedQuotationView2, "MPRNo", Me.txtRequestNo.EditValue)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.ItemClick
        If isControlsModified = True Then
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("Material Request Details have been edited, would you like to save changes?", "Save Changes?", MessageBoxButtons.YesNoCancel)

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

    'Public Function GetNewQuotationNo(ByVal QuotationAbbr As String, ByVal YearInDigit As Integer, ByVal QuoteDate As Date, ByVal IsResetByYear As Boolean, ByVal NoOfDigits As Integer) As String

    Public Function GetNewRequestNo(ByVal RequestAbbr As String, ByVal YearInDigit As Integer, ByVal MPRDate As Date, ByVal IsResetByYear As Boolean, ByVal NoOfDigits As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1

            If IsResetByYear = True Then
                SqlCommand1.CommandText = "select max(cast(right(MPRNo, " & NoOfDigits & ") as int)) from tbl606_01PurchaseRequestMaster where MPRNo like '" & RequestAbbr & "%' AND Year(MPRDate) = '" & Year(MPRDate).ToString & "' AND ISNULL(IsObseleteVersion, 0) = 0"

            Else
                SqlCommand1.CommandText = "select max(cast(right(MPRNo, " & NoOfDigits & ") as int)) from tbl606_01PurchaseRequestMaster where MPRNo like '" & RequestAbbr & "%' AND ISNULL(IsObseleteVersion, 0) = 0"

            End If

            'SqlCommand1.CommandText = "select max(cast(right(MPRNo,5) as int)) from tbl606_01PurchaseRequestMaster where ISNULL(IsObseleteVersion, 0) = 0"
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewQuotationNo = "00000" & CStr(int1)
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, 5)

            If CheckIfNull(YearInDigit) = True Then
                YearInDigit = 0
            End If

            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = strYear & "-" & strNewQuotationNo
            strNewQuotationNo = RequestAbbr & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
            strNewQuotationNo = RequestAbbr & strYear & "-" & "00001"
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    'Saving and updating codes
    Public Sub NewRequestMaster(ByVal RequestNo As String)
        Try
            If CheckIfNull(RequestNo) = False Then
                Me.Tbl60601PurchaseRequestMasterBindingSource.AddNew()
                Me.txtRequestNo.EditValue = RequestNo
                isBeingUpdated = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Request", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddNewLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewLineItem.ItemClick
        Try
            If CheckIfNull(Me.txtRequestNo.EditValue) = False Then
                If Me.btnSave.Caption = "Save" Then
                    SaveNewRequestMaster(Me.txtRequestNo.EditValue)
                    Me.btnSave.Caption = "Update"
                End If

                Me.AddNewChild()
                Me.Validate()
                'Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, DeliveryNoteNo)
                Me.Qry60602PurchaseRequestChildBindingSource.EndEdit()
                Me.Qry606_02PurchaseRequestChildTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild)

                Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

                Me.gvInvoiceChild.MoveLast()
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.Columns("GSCode")
                Me.gvInvoiceChild.ShowEditor()
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Request Line Item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm601_11PurchaseRequestEdit.Tables("qry606_02PurchaseRequestChild")
            dr = dt.NewRow()
            dr("MPRChildSlNo") = 1
            dr("MPRNo") = Me.txtRequestNo.EditValue
            dr("GSCode") = ""
            dr("QtyRequested") = 1
            dr("LineOrderNo") = GetNewRequestLineItemNo(Me.txtRequestNo.EditValue)
            dt.Rows.Add(dr)
            Me.Qry606_02PurchaseRequestChildTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Request Line Item, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewRequestLineItemNo(ByVal strRequestNo As String) As Integer
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Max(LineOrderNo) from tbl606_02PurchaseRequestChild where MPRNo = '" & strRequestNo & "'"
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

    Private Sub DeleteRequestChild(ByVal MPRChildSlNo As Integer, ByVal WithMessage As Boolean)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp606_01DeletePurchaseRequestChild"
            Dim paramPayrollInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRChildSlNo", SqlDbType.Int)

            paramPayrollInvoiceNo.Value = MPRChildSlNo

            SqlCommand1.ExecuteNonQuery()

            If WithMessage = True Then
                MessageBox.Show("Request Line Item Deleted Successfully,", "Data Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As System.InvalidCastException
            MessageBox.Show("Request Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLineItem.ItemClick

        DialogResult = MessageBox.Show("You are about to delete Request Line Item." & vbCrLf & "Are you Sure want to delete this Request Details?", "Delete Request Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedPurchaseRequestChildSlNo) = False Then

                Me.DeleteRequestChild(Me.SelectedPurchaseRequestChildSlNo, True)

                'Refresh the datagrid
                'fill child details in the datagrid
                Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

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
                SelectedPurchaseRequestChildSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("MPRChildSlNo"))
                Me.popInvoiceChild.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAddLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddLineItem.ItemClick
        If CheckIfNull(Me.txtRequestNo.EditValue) = False Then
            Me.AddNewChild()
            Me.Validate()
            Me.Qry60602PurchaseRequestChildBindingSource.EndEdit()
            Me.Qry606_02PurchaseRequestChildTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild)

            Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)
        End If
    End Sub

    Public Sub UpdateInvoiceChild()
        Try

            Me.Validate()
            Me.Qry60602PurchaseRequestChildBindingSource.EndEdit()
            Me.Qry606_02PurchaseRequestChildTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild)

            RefreshRequestChild()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub RefreshRequestChild()
        Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            'Check if the Voucher is approved already
            If CheckIfPRIsSubmitted(Me.txtRequestNo.EditValue) = True Then
                MessageBox.Show("Request/Enquiry is already Submitted, You cannot delete the Submitted Request/Enquiry.", "Request/Enquiry is Submitted", MessageBoxButtons.OK)
                Exit Sub

            End If

            'Check if the Voucher is approved already
            If CheckIfRequestIsApproved(Me.txtRequestNo.EditValue) = True Then
                MessageBox.Show("Request is already approved, You cannot delete the Approved Request", "Request Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Request from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtRequestNo.EditValue) = False Then
                    If DeleteRequest(Me.txtRequestNo.EditValue) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.txtRequestNo.EditValue, "VoucherScanned\IMSEnquiry")

                        MessageBox.Show("Request has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Purchase Request", "IMS Purchase Request Ref No." & Me.txtRequestNo.EditValue & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogonUser & ".", Me.strLogonUser, Me.txtRequestNo.EditValue)

                        'Refresh the datagrid
                        RefreshRequestMasterDataGrid()

                        Me.Close()
                    Else
                        MessageBox.Show("Deleting Failed, please try again.", "Delete Failed", MessageBoxButtons.OK)
                    End If
                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Function CheckIfPRIsSubmitted(ByVal MPRNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select MPRNo from tbl606_01PurchaseRequestMaster where (MPRNo = '" & MPRNo & "') and (Isnull(IsSubmitted,0) = 1 )"

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

    Private Function CheckIfPRIsVerified(ByVal MPRNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select MPRNo from tbl606_01PurchaseRequestMaster where (MPRNo = '" & MPRNo & "') and (Isnull(IsVerified,0) = 1 )"

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

    Private Function CheckIfRequestIsApproved(ByVal RequestNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select MPRNo from tbl606_01PurchaseRequestMaster where (MPRNo = '" & RequestNo & "') and (Isnull(IsApproved,0) = 1 )"

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

    Private Function DeleteRequest(ByVal RequestNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl606_01PurchaseRequestMaster WHERE MPRNo   = '" & RequestNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl606_02PurchaseRequestChild WHERE MPRNo   = '" & RequestNo & "'"
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


    Public Sub DisableApprovedVoucherEditing(ByVal RequestNo As String)
        'Disable access if the voucher is already approved.
        'Get the IsVoucherIsApproved
        If CheckIfRequestIsApproved(RequestNo) = True Then
            DisableAllControls()
        End If

        'Me.CheckIfPDFAvailable(voucherNo)
    End Sub

    'Disable All Controls
    Public Sub DisableAllControls()

        Me.btnMoveUp.Enabled = False
        Me.btnMoveDown.Enabled = False
        Me.btnResetLayout.Enabled = False
        Me.btnSetAsDefaultLayout.Enabled = False

        Me.btnSave.Enabled = False
        Me.btnSaveAndClose.Enabled = False
        Me.btnPreviewRequest.Enabled = True
        Me.btnDelete.Enabled = False
        Me.btnAddNewLineItem.Enabled = False
        Me.btnAddLineItem.Enabled = False
        Me.btnBack.Enabled = True
        Me.btnAttachments.Enabled = True
        Me.btnUploadData.Enabled = False
        Me.btnSubmit.Enabled = False
        Me.btnVerify.Enabled = False
        Me.btnApprove.Enabled = False

        Me.btnLineItem.Enabled = False

        Me.txtSignatory.Enabled = False

        Me.txtClientName.Enabled = False

        Me.gcInvoiceChild.Enabled = False


        Me.txtRequestDate.Enabled = False
        Me.txtClientName.Enabled = False
        Me.txtStoreCode.Enabled = False
        Me.txtDepartmentRequeste.Enabled = False
        Me.txtClientRefName.Enabled = False
        Me.txtClientContactNo.Enabled = False
        Me.txtModeOfRequest.Enabled = False
        Me.txtTypeOfRequest.Enabled = False
        Me.txtReferenceNo.Enabled = False
        Me.txtClientEmail.Enabled = False
        Me.txtProjectCode.Enabled = False

        Me.txtPurpose.Enabled = False
        Me.txtPriority.Enabled = False
        Me.txtCostCenter.Enabled = False
        Me.txtVATPercentage.Enabled = False
        Me.txtExpectedDate.Enabled = False
        Me.MemoEdit1.Enabled = False
        Me.txtSignatory.Enabled = False

        Me.txtCompanyID.Enabled = False
        Me.txtRequestedBy.Enabled = False
        Me.txtRequestStatus.Enabled = False
        Me.txtInventoryGroupMaster.Enabled = False
        Me.txtBidClosingDate.Enabled = False
        Me.txtBidReminderDate.Enabled = False

        Me.txtSalesPerson.Enabled = False

        Me.txtVerifiedSign.Enabled = False
        Me.txtApprovedSign.Enabled = False

        Me.txtRemarksByApprover.Enabled = False
        Me.btnApproveRequest.Enabled = False
        Me.btnCancelRequest.Enabled = False

        Me.txtRemarksByVerifier.Enabled = False
        Me.btnVerifyTheRequest.Enabled = False
        Me.btnCancelRequestByVerifier.Enabled = False

    End Sub

    'Enable All Controls
    Public Sub EnableAllControls()

        Me.btnMoveUp.Enabled = True
        Me.btnMoveDown.Enabled = True
        Me.btnResetLayout.Enabled = True
        Me.btnSetAsDefaultLayout.Enabled = True

        Me.btnSave.Enabled = True
        Me.btnSaveAndClose.Enabled = True
        Me.btnPreviewRequest.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnAddNewLineItem.Enabled = True
        Me.btnAddLineItem.Enabled = True
        Me.btnBack.Enabled = True
        Me.btnAttachments.Enabled = True
        Me.btnUploadData.Enabled = True
        Me.btnSubmit.Enabled = True
        Me.btnVerify.Enabled = True
        Me.btnApprove.Enabled = True

        Me.btnLineItem.Enabled = True

        Me.txtSignatory.Enabled = True

        Me.txtClientName.Enabled = True

        Me.gcInvoiceChild.Enabled = True


        Me.txtRequestDate.Enabled = True
        Me.txtClientName.Enabled = True
        Me.txtStoreCode.Enabled = True
        Me.txtDepartmentRequeste.Enabled = True
        Me.txtClientRefName.Enabled = True
        Me.txtClientContactNo.Enabled = True
        Me.txtModeOfRequest.Enabled = True
        Me.txtTypeOfRequest.Enabled = True
        Me.txtReferenceNo.Enabled = True
        Me.txtClientEmail.Enabled = True
        Me.txtProjectCode.Enabled = True

        Me.txtPurpose.Enabled = True
        Me.txtPriority.Enabled = True
        Me.txtCostCenter.Enabled = True
        Me.txtVATPercentage.Enabled = True
        Me.txtExpectedDate.Enabled = True
        Me.MemoEdit1.Enabled = True
        Me.txtSignatory.Enabled = True

        Me.txtCompanyID.Enabled = True
        Me.txtRequestedBy.Enabled = True
        Me.txtRequestStatus.Enabled = True
        Me.txtInventoryGroupMaster.Enabled = True
        Me.txtBidClosingDate.Enabled = True
        Me.txtBidReminderDate.Enabled = True

        Me.txtSalesPerson.Enabled = True

        Me.txtVerifiedSign.Enabled = True
        Me.txtApprovedSign.Enabled = True

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
            frm30106ClientMaster.isExecutedFrom_frm601_11PurchaseRequestEdit = True

        ElseIf e.Button.Index = 1 Then

            If CheckIfNull(Me.txtClientName.EditValue) = True Or Me.txtClientName.Text = String.Empty Then
                MessageBox.Show("Please select the Client to edit.", "Select Client to edit", MessageBoxButtons.OK)
            Else
                Dim frm30106ClientMaster As New frm30106ClientMaster
                frm30106ClientMaster.ObjForm = Me

                frm30106ClientMaster.isExecutedFrom_frm601_11PurchaseRequestEdit = True

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
                Me.txtClientRefName.EditValue = Me.Dsfrm601_11PurchaseRequestEdit1.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactPerson")
                Me.txtClientContactNo.EditValue = Me.Dsfrm601_11PurchaseRequestEdit1.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactPhone1")
                Me.txtClientEmail.EditValue = Me.Dsfrm601_11PurchaseRequestEdit1.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactEmail")
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
            frm40115QuotationSignatories.isExecutedFrom_frm601_11PurchaseRequestEdit = True
        End If
    End Sub

    Private Sub repoDetailedDescription_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoDetailedDescription.ButtonClick
        If e.Button.Index = 1 Then
            Try
                Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                frm20163VATGoodsAndServicesEdit.ObjForm = Me

                frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Save"
                frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_11PurchaseRequestEdit = True
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
                    frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_11PurchaseRequestEdit = True

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
                    frm600_01InventoryStockEdit.isExecutedFrom_frm601_11PurchaseRequestEdit = True

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
                UpdateInvoiceChild()

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

    Public Sub ImplementAccessLevel()
        Try
            If GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_FullAccess") = True Then
                Me.btnMoveUp.Enabled = True
                Me.btnMoveDown.Enabled = True
                Me.btnResetLayout.Enabled = True
                Me.btnSetAsDefaultLayout.Enabled = True

                Me.btnSave.Enabled = True
                Me.btnSaveAndClose.Enabled = True
                Me.btnPreviewRequest.Enabled = True
                Me.btnDelete.Enabled = True
                Me.btnAddNewLineItem.Enabled = True
                Me.btnAddLineItem.Enabled = True
                Me.btnBack.Enabled = True
                Me.btnAttachments.Enabled = True
                Me.btnUploadData.Enabled = True
                Me.btnSubmit.Enabled = True
                Me.btnVerify.Enabled = True
                Me.btnApprove.Enabled = True

                Me.btnLineItem.Enabled = True
                'edit
                Me.txtClientName.Properties.Buttons.Item(1).Enabled = True
                'add
                Me.txtClientName.Properties.Buttons.Item(2).Enabled = True


                Me.txtSignatory.Enabled = True
                Me.txtSignatory.Properties.Buttons.Item(1).Enabled = True

                Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = True
                Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = True
                Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = True

            Else
                Me.btnMoveUp.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnMoveUp")
                Me.btnMoveDown.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnMoveDown")
                Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnResetLayout")
                Me.btnSetAsDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnSetDefaultLayout")

                Me.btnSave.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnSave")
                Me.btnSaveAndClose.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnSaveAndClose")
                Me.btnPreviewRequest.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnPreviewRequest")
                Me.btnDelete.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnDelete")
                Me.btnAddNewLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnAddNewLineItem")
                Me.btnAddLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnAddNewLineItem")

                Me.btnBack.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnBack")
                Me.btnAttachments.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnAttachments")
                Me.btnUploadData.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnUploadData")
                Me.btnSubmit.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnSubmit")
                Me.btnVerify.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnVerify")
                Me.btnApprove.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnApprove")

                Me.btnLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnDeleteLineItem")

                'edit
                Me.txtClientName.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_EditClientDetails")
                'add
                Me.txtClientName.Properties.Buttons.Item(2).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_AddNewClient")

                Me.txtSignatory.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_txtSignatory")
                Me.txtSignatory.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_txtSignatory_Add")

                Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_AddStockItem")
                Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_EditStockItem")
                Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_EditStockItem")
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub frm601_11PurchaseRequestEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_04PurchaseRequestProjectSubUnits)
        Me.Tbl20101SalesPersonMasterTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit9.tbl20101SalesPersonMaster)

        Me.Tbl600_08InventoryMasterGroupTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit8.tbl600_08InventoryMasterGroup)
        Me.Tbl606_03PurchaseRequestStatusMasterTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_03PurchaseRequestStatusMaster)
        Me.Tbl20168VATPurchaseTaxSlabsTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit.tbl20168VATPurchaseTaxSlabs)
        Me.Qry700_02ProjectsViewMasterTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit.qry700_02ProjectsViewMaster)
        Me.Tbl101DepartmentsTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit7.tbl101Departments)
        Me.Tbl901CompanyDetailsTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl901CompanyDetails)
        Me.Tbl600_02RequestedByTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit6.tbl600_02RequestedBy)
        Me.Tbl90104DocumentSignatoriesTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit5.tbl90104DocumentSignatories)
        Me.Tbl30103ModeOfRequestMasterTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit4.tbl30103ModeOfRequestMaster)
        Me.Tbl30104TypeOfRequestMasterTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit3.tbl30104TypeOfRequestMaster)

        Me.Tbl600_01StoreMasterTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit4.tbl600_01StoreMaster)
        Me.Tbl30101ClientMasterTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit1.tbl30101ClientMaster)

        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit3.tbl40111PropertyUnitCodes)

        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit2.tbl20164GoodsAndServicesMaster)
        Else
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.FillByInventoryGroupID(Me.Dsfrm601_11PurchaseRequestEdit2.tbl20164GoodsAndServicesMaster, Me.intLogOnInventoryAccessLevel)
        End If

        If Me.intLogOnInventoryMPRAccessLevel = 99 Then
            Me.Tbl30101ClientMasterTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit1.tbl30101ClientMaster)
        Else
            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)
            Me.Tbl30101ClientMasterTableAdapter.FillBySalesPersonCode(Me.Dsfrm601_11PurchaseRequestEdit1.tbl30101ClientMaster, SalesPersonCode)
        End If

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit", Me.gvInvoiceChild)

        ImplementAccessLevel()

        'Populate Custom Reports Tab
        Me.PopulateCustomReportButtons(Me.CustomReportFormNo)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colLineTotal.DisplayFormat.FormatString = "{0:#,0.000}"
        End If

    End Sub

    Private Sub txtModeOfRequest_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtModeOfRequest.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40112QuoteModeOfRequest As New frm40112QuoteModeOfRequest
            frm40112QuoteModeOfRequest.ObjForm = Me
            frm40112QuoteModeOfRequest.Show()
            frm40112QuoteModeOfRequest.txtPropertyCategory.Focus()
            frm40112QuoteModeOfRequest.isExecutedFrom_frm601_11PurchaseRequestEdit = True
        End If
    End Sub

    Private Sub txtTypeOfRequest_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtTypeOfRequest.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40113QuoteTypeOfRequest As New frm40113QuoteTypeOfRequest
            frm40113QuoteTypeOfRequest.ObjForm = Me
            frm40113QuoteTypeOfRequest.Show()
            frm40113QuoteTypeOfRequest.txtPropertyCategory.Focus()
            frm40113QuoteTypeOfRequest.isExecutedFrom_frm601_11PurchaseRequestEdit = True
        End If
    End Sub

    Private Sub cmdEditContacts_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles cmdEditContacts.OpenLink
        Try
            Dim strClientCode As String = Me.txtClientName.EditValue

            If CheckIfNull(strClientCode) = False Then

                Dim frm600_03ClientContactList As New frm600_03ClientContactList
                frm600_03ClientContactList.ObjForm = Me
                frm600_03ClientContactList.isExecutedFrom_frm601_11PurchaseRequestEdit = True

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


    Private Sub txtStoreCode_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtStoreCode.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm600_01StoreEdit As New frm600_01StoreEdit
            frm600_01StoreEdit.ObjForm = Me
            frm600_01StoreEdit.Show()
            frm600_01StoreEdit.txtStoreName.Focus()
            frm600_01StoreEdit.isExecutedFrom_frm601_11PurchaseRequestEdit = True

        End If
    End Sub

    Private Sub btnPreviewRequest_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewRequest.ItemClick
        Try

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
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

            GetCompanyDetails(1)

            If CheckIfNull(gCompanyERPCode) = False Then
                If gInvoiceFormatNo = "INV-014" Then   'Technical Cleaning Company ERP Code
                    PrintMPR_TCC(Me.chkShowVAT.EditValue)
                Else
                    PrintRequest()

                End If
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub PrintRequest()
        Me.SaveAll(False)

        Dim rpt1 As New rpt601_07MaterialRequests

        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = "IMS-MPR-01"
        Dim frm1 As New frm999_01ReportPreviewMPR

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------


        rpt1.Qry606_05PurchaseRequestReportTableAdapter.FillByMPRNo(rpt1.DsRpt601_07MaterialRequests1.qry606_05PurchaseRequestReport, Me.txtRequestNo.EditValue)

        If Me.txtPrintInLetterHead.EditValue = True Then
            rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
            rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
            rpt1.Watermark.ImageTiling = False
            rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
            rpt1.Watermark.ImageTransparency = 0
            rpt1.Watermark.ShowBehind = True
        End If

        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser

        If Me.txtRequestedBy.EditValue = 1 Then
            rpt1.tblClientDetails.Visible = True
            rpt1.tblProjectDetails.Visible = False

        ElseIf Me.txtRequestedBy.EditValue = 2 Then
            rpt1.tblClientDetails.Visible = False
            rpt1.tblProjectDetails.Visible = True
            rpt1.lblFrom.Text = "Store:"

        ElseIf Me.txtRequestedBy.EditValue = 3 Then
            rpt1.tblClientDetails.Visible = False
            rpt1.tblProjectDetails.Visible = True
            rpt1.lblFrom.Text = "Department:"

        ElseIf Me.txtRequestedBy.EditValue = 4 Then
            rpt1.tblClientDetails.Visible = False
            rpt1.tblProjectDetails.Visible = True

        End If

        If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
            rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

            If Me.txtShowSignature.EditValue = True Then
                rpt1.txtSignatureImage.Visible = True
            Else
                rpt1.txtSignatureImage.Visible = False
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

        GetCompanyDetails02(1)
        If gIsEnableMPRWorkflow = True Then
            'Check if the PR is Approved or not
            If frm601_12PurchaseRequestView.CheckIfPRIsApproved(Me.txtRequestNo.EditValue) = False Then
                rpt1.Watermark.Text = "D R A F T   C O P Y"
                rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                rpt1.Watermark.TextDirection = DirectionMode.Horizontal
            End If
        End If

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "MPR_No_" & Me.txtRequestNo.EditValue

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
    End Sub


    Private Sub PrintMPR_TCC(ByVal ShowVAT As Boolean)

        Dim rpt1 As New rpt601_99_02MPR_Tcc
        rpt1.Qry606_05PurchaseRequestReportTableAdapter.FillByMPRNo(rpt1.DsRpt601_07MaterialRequests1.qry606_05PurchaseRequestReport, Me.txtRequestNo.EditValue)

        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser
        rpt1.ShowVATFields(ShowVAT)
        rpt1.ExportOptions.PrintPreview.DefaultFileName = "MPR_No_" & Me.txtRequestNo.EditValue
        rpt1.RequestParameters = False
        rpt1.ShowPreview()
    End Sub

    Private Sub btnUploadData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUploadData.ItemClick
        Try
            'Dim strClientCode As String = Me.txtClientName.EditValue

            If CheckIfNull(Me.txtRequestNo.EditValue) = False Then

                Dim frm601_21InventoryUploading As New frm601_21InventoryUploading
                frm601_21InventoryUploading.ObjForm = Me
                frm601_21InventoryUploading.isExecutedFrom_frm601_11PurchaseRequestEdit = True

                frm601_21InventoryUploading.strLogOnUser = Me.strLogonUser
                frm601_21InventoryUploading.intLogOnUserID = Me.intLogOnUserID
                frm601_21InventoryUploading.intLogOnUserLevel = Me.intLogOnUserLevel
                frm601_21InventoryUploading.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm601_21InventoryUploading.txtRequestNo.EditValue = Me.txtRequestNo.EditValue
                frm601_21InventoryUploading.txtRequestNo.Enabled = False

                frm601_21InventoryUploading.btnUploadStocks.Enabled = True

                frm601_21InventoryUploading.Show()
                'frm601_21InventoryUploading.FillDataSetforEditing(strClientCode)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetAsDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_11PurchaseRequestEdit"

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
            Dim formID As String = "frm601_11PurchaseRequestEdit"

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
        ScannedFileLocation = gScannedLocation & "VoucherScanned\IMSEnquiry"
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
        AttachFile(Me.txtRequestNo.EditValue, ScannedFileLocation)
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
                frmDocuments.IsIMSEnquiry = True
                frmDocuments.Show()
            Else
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = DocumentNo
                frmDocuments.IsIMSEnquiry = True
                frmDocuments.Show()
                frmDocuments.OpenFileDialogBox()
            End If

        End If
    End Sub


#End Region

    Private Sub txtBidClosingDate_Validated(sender As Object, e As EventArgs) Handles txtBidClosingDate.Validated
        UpdateReminderDate()
    End Sub

    Private Sub UpdateReminderDate()
        Try
            If CheckIfNull(Me.txtBidClosingDate.EditValue) = False Then
                Dim BidClosingDate As Date = Me.txtBidClosingDate.EditValue
                GetCompanyDetails02(1)
                Dim DateToAdd As Double = -gNoOfDaysBidReminder

                Me.txtBidReminderDate.EditValue = DateAdd(DateInterval.Day, DateToAdd, Me.txtBidClosingDate.EditValue)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBidReminderDate_Leave(sender As Object, e As EventArgs) Handles txtBidReminderDate.Leave
        Try
            If String.IsNullOrEmpty(ConvertIfNull(Me.txtBidReminderDate.EditValue)) = False Then
                If String.IsNullOrEmpty(ConvertIfNull(Me.txtBidReminderDate.EditValue)) = False Then
                    If Me.txtBidReminderDate.EditValue > Me.txtBidClosingDate.EditValue Then
                        MessageBox.Show("Bid Reminder Date cannot be more than the Bid Closing Date, Please review it again.", "Bid Reminder Date must be less than Bid Closing Date.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.txtBidReminderDate.Focus()
                    End If

                    If Me.txtBidReminderDate.EditValue <= Date.Today Then
                        MessageBox.Show("Bid Reminder Date cannot be prior to today, Please review it again.", "Bid Reminder Date must be greater than Today.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.txtBidReminderDate.Focus()
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSubmit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSubmit.ItemClick
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
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

        Me.SaveAll(False)


        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnSubmit") = False Then
            MessageBox.Show("You have no Access rights to Submit the Material Request / Enquriy. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this PO Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Submitting User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.SubmitMPR(Me.txtRequestNo.EditValue)

        Dim RequestNo As String = Me.txtRequestNo.EditValue
        Dim RevisionNo As String = Me.txtRevisionNo.EditValue

        If CheckIfNull(Me.txtRevisionNo.EditValue) = False Then
            RequestNo = RequestNo & " (" & RevisionNo & ")"
        End If

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60111-001")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " submitted a PR/Enquiry for your verification."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New PR/Enquiry is ready to verify.")

        End If

        If gIsEmailToProjectSubUnits = True Then
            'get the details of the Requesting Unit.. use the emails for that unit assigned Alert Settings
            Dim AlertCode As String = GetProjectSubUnitsAlertCode(Me.txtRequestingUnit.EditValue, "AlertCode_MPR_Submit")

            If CheckIfNull(AlertCode) = True Or AlertCode = "" Then
                MessageBox.Show("No Alert code is set to forward emails for this Project Sub Unit.", "No Code to Retreive")
            Else
                GetAlertSettings(AlertCode)
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has submitted MPR No. <font color=blue><b>" & RequestNo & "</b></font> for your verification."

                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPR_" & RequestNo & "_Submission.pdf"
                ExportRequestToPDF(DestinationFile)

                If gIsEmailToRequester = True Then

                    If GetSignatoryEmailfromUserID(Me.intLogOnUserID) <> "" Then
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue & ", " & GetSignatoryEmailfromUserID(intLogOnUserID)
                    Else
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue
                    End If

                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Submitted for Verification (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Else
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Submitted for Verification (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                End If

                Me.SplashScreenManager1.CloseWaitForm()
            End If

        Else

            If gIsEmailAlertActivated = True Then
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has submitted MPR No. <font color=blue><b>" & RequestNo & "</b></font> for your verification."

                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPR_" & RequestNo & "_Submission.pdf"
                ExportRequestToPDF(DestinationFile)
                SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Submitted for Verification (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Me.SplashScreenManager1.CloseWaitForm()

            End If

        End If



        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshRequestMasterDataGrid()
    End Sub


    Private Sub SubmitMPR(ByVal MPRNo As String)
        If CheckIfNull(MPRNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60601PurchaseRequestMasterBindingSource.Current, DataRowView)
            view.Row("IsSubmitted") = True
            view.Row("SubmittedBy") = Me.strLogonUser
            view.Row("SubmittedOn") = Date.Now

            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            view.Row("RequestSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            'Set the Status to 31 - Enquiry/Request Submitted
            view.Row("PurchaseRequestStatusID") = 31

            Me.Tbl60601PurchaseRequestMasterBindingSource.EndEdit()
            Me.Tbl606_01PurchaseRequestMasterTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_01PurchaseRequestMaster)

            MessageBox.Show("Material Purchase Request has been submitted for Approval.", "Submit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnVerify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerify.ItemClick
        Me.PopupContainerControl2.Show()

        'Select the Invoice Page
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageVerifyCancellation" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        Me.pageApproveCancellation.PageVisible = False

    End Sub

    Private Sub VerifyMPR(ByVal MPRNo As String)
        If CheckIfNull(MPRNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60601PurchaseRequestMasterBindingSource.Current, DataRowView)
            view.Row("IsVerified") = True
            view.Row("VerifiedBy") = Me.strLogonUser
            view.Row("VerifiedOn") = Date.Now
            'Set the Status to 32 - Enquiry/Request Verified
            view.Row("PurchaseRequestStatusID") = 32

            view.Row("MPRVerifiedSign") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            Me.Tbl60601PurchaseRequestMasterBindingSource.EndEdit()
            Me.Tbl606_01PurchaseRequestMasterTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_01PurchaseRequestMaster)

            MessageBox.Show("Material Purchase Request has been Verified and processed for Approval.", "Verify Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnApprove.ItemClick
        Me.PopupContainerControl2.Show()

        'Select the Invoice Page
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageApproveCancellation" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        Me.pageVerifyCancellation.PageVisible = False

    End Sub

    Private Sub ApproveMPR(ByVal MPRNo As String)
        If CheckIfNull(MPRNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60601PurchaseRequestMasterBindingSource.Current, DataRowView)
            view.Row("IsApproved") = True
            view.Row("ApprovedBy") = Me.strLogonUser
            view.Row("ApprovedOn") = Date.Now
            'Set the Status to 33 - Enquiry/Request Approved
            view.Row("PurchaseRequestStatusID") = 33

            view.Row("MPRApprovedSign") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            Me.Tbl60601PurchaseRequestMasterBindingSource.EndEdit()
            Me.Tbl606_01PurchaseRequestMasterTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_01PurchaseRequestMaster)

            MessageBox.Show("Material Purchase Request has been Approved.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CancelMPR(ByVal MPRNo As String)
        If CheckIfNull(MPRNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60601PurchaseRequestMasterBindingSource.Current, DataRowView)
            view.Row("IsCancelled") = True
            view.Row("CancelledBy") = Me.strLogonUser
            view.Row("CancelledOn") = Date.Now
            'Set the Status to 33 - Enquiry/Request Approved
            view.Row("PurchaseRequestStatusID") = 35

            Me.Tbl60601PurchaseRequestMasterBindingSource.EndEdit()
            Me.Tbl606_01PurchaseRequestMasterTableAdapter.Update(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_01PurchaseRequestMaster)

            MessageBox.Show("Material Purchase Request has been Cancelled.", "MPR Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPreviewRequestWtPrice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewRequestWtPrice.ItemClick
        Dim rpt1 As New rpt601_99_02MPR_Tcc

        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = "IMS-MPR-02"
        Dim frm1 As New frm999_01ReportPreviewMPR

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------

        rpt1.Qry606_05PurchaseRequestReportTableAdapter.FillByMPRNo(rpt1.DsRpt601_07MaterialRequests1.qry606_05PurchaseRequestReport, Me.txtRequestNo.EditValue)

        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser
        rpt1.ShowVATFields(Me.chkShowVAT.EditValue)
        rpt1.isDefaultDesign = True
        rpt1.RequestParameters = False

        GetCompanyDetails02(1)
        If gIsEnableMPRWorkflow = True Then
            'Check if the PR is Approved or not
            If frm601_12PurchaseRequestView.CheckIfPRIsApproved(Me.txtRequestNo.EditValue) = False Then
                rpt1.Watermark.Text = "D R A F T   C O P Y"
                rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                rpt1.Watermark.TextDirection = DirectionMode.Horizontal
            End If
        End If

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "MPR_No_" & Me.txtRequestNo.EditValue
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

    End Sub

    Private Sub txtProjectCode_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtProjectCode.Properties.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm700_07ProjectsSimpleEditForm As New frm700_07ProjectsSimpleEditForm
            frm700_07ProjectsSimpleEditForm.ObjForm = Me
            frm700_07ProjectsSimpleEditForm.Show()
            frm700_07ProjectsSimpleEditForm.txtProjectGroup.Focus()
            frm700_07ProjectsSimpleEditForm.isExecutedFrom_frm601_11PurchaseRequestEdit = True
        End If
    End Sub

    Private Sub txtRequestDate_Leave(sender As Object, e As EventArgs) Handles txtRequestDate.Leave
        'DATE BLOCKING
        GetCompanyDetails02(1)
        If gIsDateLockingEnabled = True Then
            If CheckIfNull(Me.txtRequestDate.EditValue) = True Then
                Me.txtRequestDate.EditValue = Date.Today()
            End If

            If CheckIfDateBeenLocked("IMS_PR", Me.txtRequestDate.EditValue) = True Then
                MessageBox.Show("This Material Request / Purchase Request Entry date has been blocked." & vbCrLf & "Please review your entry date.", "Entry Date is Blocked", MessageBoxButtons.OK)
                Me.txtRequestDate.EditValue = Me.txtRequestDate.OldEditValue
                Me.txtRequestDate.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnDeleteSelectedItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteSelectedItems.ItemClick
        DialogResult = MessageBox.Show("You are about to delete all the Selected Material Request Line Items." & vbCrLf & "Are you Sure want to delete this Material Request Note Details?", "Delete Material Request Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Dim view As GridView = gvInvoiceChild
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    Dim ChosenMPRChildSlNo As Integer = view.GetRowCellValue(row, view.Columns("MPRChildSlNo"))
                    Me.DeleteRequestChild(ChosenMPRChildSlNo, False)
                Next
            End If
            'Refresh the datagrid
            'fill child details in the datagrid
            Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub

        End If
    End Sub


#Region "Populate Custom Report Buttons"
    'Change this code for other forms.. 
    Dim CustomReportFormNo As Integer = 2

    Public Sub PopulateCustomReportButtons(ByVal CustomReportFormNo As Integer)

        'Dim subitemCustomReports As New BarSubItem
        'subitemCustomReports.Caption = "Custom Reports"
        'subitemCustomReports.Id = BarManager1.GetNewItemId()
        'BarSubItemCustomReportLinkID = BarSubItemCustomReportLinkID
        'subitemCustomReports.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        'subitemCustomReports.ItemAppearance.Normal.Options.UseFont = True
        'subitemCustomReports.ImageOptions.Image = My.Resources.DailyRpt32x32
        'subItemReports.AddItem(subitemCustomReports)

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
        'Check if the report format is IMS-MPR-01 THEN LOAD FIRST REPORT
        'Get CustomReportCode (Desinged from this Custom Report)
        GetNewBaseReportNo(e.Item.Name)

        If grBaseReportNo = "IMS-MPR-01" Then
            Me.OpenReportDesignOne(e.Item.Name, CustomReportFormNo)
        ElseIf grBaseReportNo = "IMS-MPR-02" Then
            Me.OpenReportDesignTwo(e.Item.Name, CustomReportFormNo)
        End If

    End Sub

    Private Sub OpenReportDesignTwo(ByVal ReportNo As String, ByVal CustomReportFormNo As Integer)
        Dim rpt1 As New rpt601_99_02MPR_Tcc

        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = ReportNo
        Dim frm1 As New frm999_01ReportPreviewMPR

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------

        rpt1.Qry606_05PurchaseRequestReportTableAdapter.FillByMPRNo(rpt1.DsRpt601_07MaterialRequests1.qry606_05PurchaseRequestReport, Me.txtRequestNo.EditValue)

        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser
        rpt1.ShowVATFields(Me.chkShowVAT.EditValue)
        rpt1.isDefaultDesign = True
        rpt1.RequestParameters = False

        GetCompanyDetails02(1)
        If gIsEnableMPRWorkflow = True Then
            'Check if the PR is Approved or not
            If frm601_12PurchaseRequestView.CheckIfPRIsApproved(Me.txtRequestNo.EditValue) = False Then
                rpt1.Watermark.Text = "D R A F T   C O P Y"
                rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                rpt1.Watermark.TextDirection = DirectionMode.Horizontal
            End If
        End If

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "MPR_No_" & Me.txtRequestNo.EditValue
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
    End Sub

    Private Sub OpenReportDesignOne(ByVal ReportNo As String, ByVal CustomReportFormNo As Integer)
        Me.SaveAll(False)

        Dim rpt1 As New rpt601_07MaterialRequests

        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = ReportNo
        Dim frm1 As New frm999_01ReportPreviewMPR

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------


        rpt1.Qry606_05PurchaseRequestReportTableAdapter.FillByMPRNo(rpt1.DsRpt601_07MaterialRequests1.qry606_05PurchaseRequestReport, Me.txtRequestNo.EditValue)

        If Me.txtPrintInLetterHead.EditValue = True Then
            rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
            rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
            rpt1.Watermark.ImageTiling = False
            rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
            rpt1.Watermark.ImageTransparency = 0
            rpt1.Watermark.ShowBehind = True
        End If

        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser

        If Me.txtRequestedBy.EditValue = 1 Then
            rpt1.tblClientDetails.Visible = True
            rpt1.tblProjectDetails.Visible = False

        ElseIf Me.txtRequestedBy.EditValue = 2 Then
            rpt1.tblClientDetails.Visible = False
            rpt1.tblProjectDetails.Visible = True
            rpt1.lblFrom.Text = "Store:"

        ElseIf Me.txtRequestedBy.EditValue = 3 Then
            rpt1.tblClientDetails.Visible = False
            rpt1.tblProjectDetails.Visible = True
            rpt1.lblFrom.Text = "Department:"

        ElseIf Me.txtRequestedBy.EditValue = 4 Then
            rpt1.tblClientDetails.Visible = False
            rpt1.tblProjectDetails.Visible = True

        End If


        GetCompanyDetails02(1)
        If gIsEnableMPRWorkflow = True Then
            'Check if the PR is Approved or not
            If frm601_12PurchaseRequestView.CheckIfPRIsApproved(Me.txtRequestNo.EditValue) = False Then
                rpt1.Watermark.Text = "D R A F T   C O P Y"
                rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                rpt1.Watermark.TextDirection = DirectionMode.Horizontal
            End If
        End If

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "MPR_No_" & Me.txtRequestNo.EditValue

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
    End Sub

    Private Sub txtRequestingUnit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtRequestingUnit.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm600_14ProjectSubUnits As New frm600_14ProjectSubUnits
            frm600_14ProjectSubUnits.ObjForm = Me
            frm600_14ProjectSubUnits.Show()
            frm600_14ProjectSubUnits.txtProjectSubUnitName.Focus()
            frm600_14ProjectSubUnits.isExecutedFrom_frm601_11PurchaseRequestEdit = True
        End If
    End Sub

    Private Sub RepositoryItemGridLookUpEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemGridLookUpEdit1.ButtonClick
        If e.Button.Index = 1 Then
            Try
                If CheckIfNull(Me.txtRequestNo.EditValue) = False Then
                    Dim frm600_15QuotationSubGroups As New frm600_15QuotationSubGroups
                    frm600_15QuotationSubGroups.ObjForm = Me
                    frm600_15QuotationSubGroups.isExecutedFrom_frm601_11PurchaseRequestEdit = True

                    frm600_15QuotationSubGroups.strLogOnUser = Me.strLogonUser
                    frm600_15QuotationSubGroups.intLogOnUserID = Me.intLogOnUserID
                    frm600_15QuotationSubGroups.intLogOnUserLevel = Me.intLogOnUserLevel
                    frm600_15QuotationSubGroups.intLogOnAccessLevel = Me.intLogOnAccessLevel
                    frm600_15QuotationSubGroups.MPRNo = Me.txtRequestNo.EditValue
                    frm600_15QuotationSubGroups.txtMPRNo.EditValue = Me.txtRequestNo.EditValue

                    frm600_15QuotationSubGroups.Show()
                    frm600_15QuotationSubGroups.txtSubGroupCode.Focus()

                End If
            Catch ex As Exception
                MessageBox.Show("Error on creating new Quotation Item Sub Group, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

#End Region

    Private Sub ExportRequestToPDF(ByVal SaveInPath As String)
        Try

            Me.SaveAll(False)

            Dim rpt1 As New rpt601_07MaterialRequests
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-MPR-01"
            Dim frm1 As New frm999_01ReportPreviewMPR

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            rpt1.Qry606_05PurchaseRequestReportTableAdapter.FillByMPRNo(rpt1.DsRpt601_07MaterialRequests1.qry606_05PurchaseRequestReport, Me.txtRequestNo.EditValue)

            If Me.txtPrintInLetterHead.EditValue = True Then
                rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
                rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
                rpt1.Watermark.ImageTiling = False
                rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
                rpt1.Watermark.ImageTransparency = 0
                rpt1.Watermark.ShowBehind = True
            End If

            rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
            rpt1.intLogOnUserID = Me.intLogOnUserID
            rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
            rpt1.strLogOnUser = Me.strLogonUser

            If Me.txtRequestedBy.EditValue = 1 Then
                rpt1.tblClientDetails.Visible = True
                rpt1.tblProjectDetails.Visible = False

            ElseIf Me.txtRequestedBy.EditValue = 2 Then
                rpt1.tblClientDetails.Visible = False
                rpt1.tblProjectDetails.Visible = True
                rpt1.lblFrom.Text = "Store:"

            ElseIf Me.txtRequestedBy.EditValue = 3 Then
                rpt1.tblClientDetails.Visible = False
                rpt1.tblProjectDetails.Visible = True
                rpt1.lblFrom.Text = "Department:"

            ElseIf Me.txtRequestedBy.EditValue = 4 Then
                rpt1.tblClientDetails.Visible = False
                rpt1.tblProjectDetails.Visible = True

            End If

            If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
                rpt1.boolShowSignatures = Me.txtShowSignature.EditValue

                If Me.txtShowSignature.EditValue = True Then
                    rpt1.txtSignatureImage.Visible = True
                Else
                    rpt1.txtSignatureImage.Visible = False
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

            GetCompanyDetails02(1)
            If gIsEnableMPRWorkflow = True Then
                'Check if the PR is Approved or not
                If frm601_12PurchaseRequestView.CheckIfPRIsApproved(Me.txtRequestNo.EditValue) = False Then
                    rpt1.Watermark.Text = "D R A F T   C O P Y"
                    rpt1.Watermark.ForeColor = Color.FromArgb(0, 128, 255)
                    rpt1.Watermark.TextDirection = DirectionMode.Horizontal
                End If
            End If

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "MPR_No_" & Me.txtRequestNo.EditValue

            rpt1.RequestParameters = False
            rpt1.ExportToPdf(SaveInPath)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnApproveMPR_Click(sender As Object, e As EventArgs) Handles btnApproveRequest.Click
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
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

        Me.SaveAll(False)

        ''Check if the request has any entry to submit
        'If GetClaimChildTotal(Me.txtClaimRefNo.EditValue) = 0 Then
        '    MessageBox.Show("Please check your Claim Request, no amount to submit the Claim.", "Claim Amount Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnApprove") = False Then
            MessageBox.Show("You have no Access rights to Approve the Material Request / Enquiry. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this MPR is Verified
        If CheckIfPRIsVerified(Me.txtRequestNo.EditValue) = False Then
            MessageBox.Show("Purchase Request is not yet Verified, please verify the MPR for Approval process.", "MPR Not verified for Approval", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this MPR Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Approving User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SaveAll(False)
        Me.ApproveMPR(Me.txtRequestNo.EditValue)

        Dim RequestNo As String = Me.txtRequestNo.EditValue
        Dim RevisionNo As String = Me.txtRevisionNo.EditValue

        If CheckIfNull(Me.txtRevisionNo.EditValue) = False Then
            RequestNo = RequestNo & " (" & RevisionNo & ")"
        End If

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60111-003")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " approved " & "MPR No:" & RequestNo & ". for Processing."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify PR/Enquiry is ready to process.")

        End If

        If gIsEmailToProjectSubUnits = True Then
            'get the details of the Requesting Unit.. use the emails for that unit assigned Alert Settings
            Dim AlertCode As String = GetProjectSubUnitsAlertCode(Me.txtRequestingUnit.EditValue, "AlertCode_MPR_Approve")

            If CheckIfNull(AlertCode) = True Or AlertCode = "" Then
                MessageBox.Show("No Alert code is set to forward emails for this Project Sub Unit.", "No Code to Retreive")
            Else
                GetAlertSettings(AlertCode)
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has Approved MPR No.<font color=blue><b>" & RequestNo & "</b></font> for Procurement Processing."

                If Me.txtRemarksByApprover.Text = "" Then

                Else
                    AlertMessage2 = AlertMessage2 & "<p><b>Note from Approver:</b><br>" & Me.txtRemarksByApprover.Text & "<br></p>"
                End If


                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPR_" & RequestNo & "_Approved.pdf"
                ExportRequestToPDF(DestinationFile)
                If gIsEmailToRequester = True Then
                    If GetSignatoryEmailfromUserID(Me.intLogOnUserID) <> "" Then
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue & ", " & GetSignatoryEmailfromUserID(intLogOnUserID)
                    Else
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue
                    End If
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Approved for Procurement Processing (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Else
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Approved for Procurement Processing (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                End If
                Me.SplashScreenManager1.CloseWaitForm()

            End If

        Else

            If gIsEmailAlertActivated = True Then
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has Approved MPR No.<font color=blue><b>" & RequestNo & "</b></font> for Procurement Processing."
                If Me.txtRemarksByApprover.Text = "" Then

                Else
                    AlertMessage2 = AlertMessage2 & "<p><b>Note from Approver:</b><br>" & Me.txtRemarksByApprover.Text & "<br></p>"
                End If

                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPR_" & RequestNo & "_Approved.pdf"
                ExportRequestToPDF(DestinationFile)
                SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Approved for Procurement Processing (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Me.SplashScreenManager1.CloseWaitForm()
            End If
        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshRequestMasterDataGrid()
    End Sub

    Private Sub btnCloseApproveWindow_Click(sender As Object, e As EventArgs) Handles btnCloseApproveWindow.Click, btnCloseVerifyWindow.Click
        Me.PopupContainerControl2.Hide()
    End Sub

    Private Sub btnCancelRequest_Click(sender As Object, e As EventArgs) Handles btnCancelRequest.Click
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
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

        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnApprove") = False Then
            MessageBox.Show("You have no Access rights to Cancel the Material Request / Enquiry. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this MPR is Verified
        If CheckIfPRIsVerified(Me.txtRequestNo.EditValue) = False Then
            MessageBox.Show("Purchase Request is not yet Verified, please verify the MPR for Approval process.", "MPR Not verified for Approval", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this MPR Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Approving User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SaveAll(False)
        Me.CancelMPR(Me.txtRequestNo.EditValue)

        Dim RequestNo As String = Me.txtRequestNo.EditValue
        Dim RevisionNo As String = Me.txtRevisionNo.EditValue

        If CheckIfNull(Me.txtRevisionNo.EditValue) = False Then
            RequestNo = RequestNo & " (" & RevisionNo & ")"
        End If

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60111-003")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " has cancelled " & "MPR No:" & RequestNo & "."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify PR/Enquiry is ready to process.")

        End If

        If gIsEmailToProjectSubUnits = True Then
            'get the details of the Requesting Unit.. use the emails for that unit assigned Alert Settings
            Dim AlertCode As String = GetProjectSubUnitsAlertCode(Me.txtRequestingUnit.EditValue, "AlertCode_MPR_Approve")

            If CheckIfNull(AlertCode) = True Or AlertCode = "" Then
                MessageBox.Show("No Alert code is set to forward emails for this Project Sub Unit.", "No Code to Retreive")
            Else
                GetAlertSettings(AlertCode)
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has cancelled MPR No.<font color=blue><b>" & RequestNo & "</b></font>."

                If Me.txtRemarksByApprover.Text = "" Then

                Else
                    AlertMessage2 = AlertMessage2 & "<p><b>Note from Approver:</b><br>" & Me.txtRemarksByApprover.Text & "<br></p>"
                End If


                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPR_" & RequestNo & "_Cancelled.pdf"
                ExportRequestToPDF(DestinationFile)
                If gIsEmailToRequester = True Then
                    If GetSignatoryEmailfromUserID(Me.intLogOnUserID) <> "" Then
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue & ", " & GetSignatoryEmailfromUserID(intLogOnUserID)
                    Else
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue
                    End If
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Cancelled the MPR No. (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Else
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Cancelled the MPR No. (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                End If
                Me.SplashScreenManager1.CloseWaitForm()

            End If

        Else

            If gIsEmailAlertActivated = True Then
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has Cancelled MPR No.<font color=blue><b>" & RequestNo & "</b></font>."
                If Me.txtRemarksByApprover.Text = "" Then

                Else
                    AlertMessage2 = AlertMessage2 & "<p><b>Note from Approver:</b><br>" & Me.txtRemarksByApprover.Text & "<br></p>"
                End If

                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPR_" & RequestNo & "_Cancelled.pdf"
                ExportRequestToPDF(DestinationFile)
                SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Cancelled the MPR No. (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Me.SplashScreenManager1.CloseWaitForm()
            End If
        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshRequestMasterDataGrid()
    End Sub

    Private Sub btnUseItemDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60602PurchaseRequestChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.EditValue = GetGSCodeDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUseItemDetailedDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDetailedDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60602PurchaseRequestChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.EditValue = GetGSCodeDetailedDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnVerifyTheRequest_Click(sender As Object, e As EventArgs) Handles btnVerifyTheRequest.Click
        Try


            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
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

            'Check if the User is allowed to Submit the Form
            If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnVerify") = False Then
                MessageBox.Show("You have no Access rights to Verify the Material Request / Enquiry. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Check if this Pr Signatory have Verification Signature
            If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
                MessageBox.Show("Verifying User have not assigned to Signatory in the System.", "Verify Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Check if this PR is submitted
            If CheckIfPRIsSubmitted(Me.txtRequestNo.EditValue) = False Then
                MessageBox.Show("Purchase Request is not yet Submitted, please submit the MPR for verfication process.", "MPR Not Submitted for verification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Me.SaveAll(False)
            Me.VerifyMPR(Me.txtRequestNo.EditValue)

            Dim RequestNo As String = Me.txtRequestNo.EditValue
            Dim RevisionNo As String = Me.txtRevisionNo.EditValue

            If CheckIfNull(Me.txtRevisionNo.EditValue) = False Then
                RequestNo = RequestNo & " (" & RevisionNo & ")"
            End If

            'Check whether Alert Activation for Submission to Verification is set then
            'Make an Alert to the Verifier
            GetAlertSettings("SYS-60111-002")
            If gIsAlertActivated = True Then
                'Add an alert
                GetCompanyDetails02(1)
                Dim AlertMessage2 As String = ""
                AlertMessage2 = Me.strLogonUser & " verified & Send the PR/Enquiry for your Approval."
                InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New PR/Enquiry is ready to Approve.")

            End If

            If gIsEmailToProjectSubUnits = True Then
                'get the details of the Requesting Unit.. use the emails for that unit assigned Alert Settings
                Dim AlertCode As String = GetProjectSubUnitsAlertCode(Me.txtRequestingUnit.EditValue, "AlertCode_MPR_Verify")

                If CheckIfNull(AlertCode) = True Or AlertCode = "" Then
                    MessageBox.Show("No Alert code is set to forward emails for this Project Sub Unit.", "No Code to Retreive")
                Else
                    GetAlertSettings(AlertCode)
                    Me.SplashScreenManager1.ShowWaitForm()
                    Dim AlertMessage2 As String = ""
                    AlertMessage2 = "Mr. " & Me.strLogonUser & " has verified MPR No.<font color=blue><b>" & RequestNo & "</b></font> for your Approval."

                    If Me.txtRemarksByVerifier.Text = "" Then

                    Else
                        AlertMessage2 = AlertMessage2 & "<p><b>Note from Verifier:</b><br>" & Me.txtRemarksByVerifier.Text & "<br></p>"
                    End If

                    If Not Directory.Exists("C:\ReportsToEmail") Then
                        Directory.CreateDirectory("C:\ReportsToEmail")
                    End If

                    Dim DestinationFile As String = "C:\ReportsToEmail"
                    DestinationFile = DestinationFile & "\MPR_" & RequestNo & "_Verified.pdf"
                    ExportRequestToPDF(DestinationFile)

                    If gIsEmailToRequester = True Then
                        If GetSignatoryEmailfromUserID(Me.intLogOnUserID) <> "" Then
                            gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue & ", " & GetSignatoryEmailfromUserID(intLogOnUserID)
                        Else
                            gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue
                        End If
                        SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Verified for your Approval (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                    Else
                        SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Verified for your Approval (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                    End If
                    Me.SplashScreenManager1.CloseWaitForm()

                End If

            Else

                If gIsEmailAlertActivated = True Then
                    Me.SplashScreenManager1.ShowWaitForm()
                    Dim AlertMessage2 As String = ""
                    AlertMessage2 = "Mr. " & Me.strLogonUser & " has verified MPR No.<font color=blue><b>" & Me.txtRequestNo.EditValue & "</b></font> for your Approval."

                    If Me.txtRemarksByVerifier.Text = "" Then

                    Else
                        AlertMessage2 = AlertMessage2 & "<p><b>Note from Verifier:</b><br>" & Me.txtRemarksByVerifier.Text & "<br></p>"
                    End If

                    If Not Directory.Exists("C:\ReportsToEmail") Then
                        Directory.CreateDirectory("C:\ReportsToEmail")
                    End If

                    Dim DestinationFile As String = "C:\ReportsToEmail"
                    DestinationFile = DestinationFile & "\MPR_" & Me.txtRequestNo.EditValue & "_Verified.pdf"
                    ExportRequestToPDF(DestinationFile)
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Verified for your Approval (" & Me.txtRequestNo.EditValue & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                    Me.SplashScreenManager1.CloseWaitForm()
                End If
            End If

            'Disable editing of controls
            DisableAllControls()
            'If is updated from Master Datagrid refresh it
            RefreshRequestMasterDataGrid()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelRequestByVerifier_Click(sender As Object, e As EventArgs) Handles btnCancelRequestByVerifier.Click
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageCompanyDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
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

        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnVerify") = False Then
            MessageBox.Show("You have no Access rights to Cancel the Material Request / Enquiry. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this MPR is Verified
        If CheckIfPRIsSubmitted(Me.txtRequestNo.EditValue) = False Then
            MessageBox.Show("Purchase Request is not yet Submitted, please Submit the MPR for Approval process.", "MPR Not Submitted for Verification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this MPR Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Approving User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SaveAll(False)
        Me.CancelMPR(Me.txtRequestNo.EditValue)

        Dim RequestNo As String = Me.txtRequestNo.EditValue
        Dim RevisionNo As String = Me.txtRevisionNo.EditValue

        If CheckIfNull(Me.txtRevisionNo.EditValue) = False Then
            RequestNo = RequestNo & " (" & RevisionNo & ")"
        End If

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60111-002")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " has cancelled " & "MPR No:" & RequestNo & "."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify PR/Enquiry is ready to process.")

        End If

        If gIsEmailToProjectSubUnits = True Then
            'get the details of the Requesting Unit.. use the emails for that unit assigned Alert Settings
            Dim AlertCode As String = GetProjectSubUnitsAlertCode(Me.txtRequestingUnit.EditValue, "AlertCode_MPR_Verify")

            If CheckIfNull(AlertCode) = True Or AlertCode = "" Then
                MessageBox.Show("No Alert code is set to forward emails for this Project Sub Unit.", "No Code to Retreive")
            Else
                GetAlertSettings(AlertCode)
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has cancelled MPR No.<font color=blue><b>" & RequestNo & "</b></font>."

                If Me.txtRemarksByVerifier.Text = "" Then

                Else
                    AlertMessage2 = AlertMessage2 & "<p><b>Note from Verifier:</b><br>" & Me.txtRemarksByVerifier.Text & "<br></p>"
                End If


                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPR_" & RequestNo & "_Cancelled.pdf"
                ExportRequestToPDF(DestinationFile)
                If gIsEmailToRequester = True Then
                    If GetSignatoryEmailfromUserID(Me.intLogOnUserID) <> "" Then
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue & ", " & GetSignatoryEmailfromUserID(intLogOnUserID)
                    Else
                        gEmailAlertSetForEmails = gEmailAlertSetForEmails & ", " & Me.txtClientEmail.EditValue
                    End If
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Cancelled the MPR No. (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Else
                    SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Cancelled the MPR No. (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                End If
                Me.SplashScreenManager1.CloseWaitForm()

            End If

        Else

            If gIsEmailAlertActivated = True Then
                Me.SplashScreenManager1.ShowWaitForm()
                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Mr. " & Me.strLogonUser & " has Cancelled MPR No.<font color=blue><b>" & RequestNo & "</b></font>."
                If Me.txtRemarksByVerifier.Text = "" Then

                Else
                    AlertMessage2 = AlertMessage2 & "<p><b>Note from Verifier:</b><br>" & Me.txtRemarksByVerifier.Text & "<br></p>"
                End If

                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\MPR_" & RequestNo & "_Cancelled.pdf"
                ExportRequestToPDF(DestinationFile)
                SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Request Cancelled the MPR No. (" & RequestNo & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
                Me.SplashScreenManager1.CloseWaitForm()
            End If
        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshRequestMasterDataGrid()
    End Sub
End Class