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

Public Class frm601_09MaterialReceiptEdit
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

    Dim SelectedReceiptChildSlNo As Integer
    Public CreatedNewReceiptNo As String

    Public isExecutedFrom_frm601_10MaterialReceiptView As Boolean = False
    Public isExecutedFrom_frm601_08PurchaseOrderView As Boolean = False
    Public isExecutedFrom_frm601_23MaterialReceiptsDetails As Boolean = False
    Public isExecutedFrom_frm600_01InventoryStockEdit As Boolean = False

    Public selectedMaterialReceiptType As Integer = 1

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

    Public Sub UpdateDefaultFields()
        For i As Integer = 0 To tabMaterialReceipt.TabPages.Count - 1
            If tabMaterialReceipt.TabPages(i).Name = "pageCompanyDetails" Then
                tabMaterialReceipt.SelectedTabPage = tabMaterialReceipt.TabPages(i)
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

                Me.txtMaterialReceiptType.EditValue = Me.selectedMaterialReceiptType

                Exit For
            End If
        Next

        For i As Integer = 0 To tabMaterialReceipt.TabPages.Count - 1
            If tabMaterialReceipt.TabPages(i).Name = "pageQuoteDetails" Then
                tabMaterialReceipt.SelectedTabPage = tabMaterialReceipt.TabPages(i)
            End If

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
        Next

    End Sub


    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtReceiptNo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtReceiptNo, "Material Receipt Number Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtReceiptNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtReceiptDate.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtReceiptDate, "Receipt Date must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtReceiptDate, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If Me.selectedMaterialReceiptType = 1 Then
            If String.IsNullOrEmpty(ConvertIfNull(Me.txtSupplierName.EditValue)) Then
                Me.DxErrorProvider1.SetError(Me.txtSupplierName, "Supplier must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider1.SetError(Me.txtSupplierName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If

        If Me.selectedMaterialReceiptType = 3 Then
            If String.IsNullOrEmpty(ConvertIfNull(Me.txtProjectCode.EditValue)) Then
                Me.DxErrorProvider1.SetError(Me.txtProjectCode, "Project must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider1.SetError(Me.txtProjectCode, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If


    End Sub

    Public Sub RetrieveReceiptMaster(ByVal ReceiptNo As String)
        Try
            If CheckIfNull(ReceiptNo) = False Then
                'fill master details
                Me.Tbl605_01MaterialReceiptMasterTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.tbl605_01MaterialReceiptMaster, ReceiptNo)

                'fill child details in the datagrid
                Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, ReceiptNo)

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Material Receipt Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateReceiptMaster(ByVal ReceiptNo As String, ByVal WithMessage As Boolean)
        If CheckIfNull(ReceiptNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60501MaterialReceiptMasterBindingSource.Current, DataRowView)
            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            Me.Tbl60501MaterialReceiptMasterBindingSource.EndEdit()
            Me.Tbl605_01MaterialReceiptMasterTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.tbl605_01MaterialReceiptMaster)

            If WithMessage = True Then
                MessageBox.Show("Material Receipt Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SaveNewReceiptMaster(ByVal ReceiptNo As String)
        If CheckIfNull(ReceiptNo) = False Then
            If isBeingNew = True Then

                Dim view As DataRowView = DirectCast(Me.Tbl60501MaterialReceiptMasterBindingSource.Current, DataRowView)
                view.Row("AddedBy") = Me.strLogonUser
                view.Row("AddedOn") = Date.Now
                Me.Validate()

                Me.Tbl60501MaterialReceiptMasterBindingSource.EndEdit()
                Me.Tbl605_01MaterialReceiptMasterTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.tbl605_01MaterialReceiptMaster)
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
            UpdateReceiptMaster(Me.txtReceiptNo.EditValue, WithMessage)
            Me.btnSave.Caption = "Update"

        ElseIf Me.btnSave.Caption = "Save" Then
            If Me.isBeingNew = True Then
                SaveNewReceiptMaster(Me.txtReceiptNo.EditValue)
                Me.btnSave.Caption = "Update"
            End If
        End If

        Try
            'Update the Data in the Child
            Me.Qry60502MaterialReceiptChildBindingSource.EndEdit()
            Me.Qry605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild)
            Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtReceiptNo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshReceiptMasterDataGrid()
    End Sub


    Private Sub RefreshReceiptMasterDataGrid()
        If isExecutedFrom_frm601_10MaterialReceiptView = True Then
            Try
                CType(ObjForm, frm601_10MaterialReceiptView).RetrieveVoucher(CType(ObjForm, frm601_10MaterialReceiptView).txtStartDate.EditValue, CType(ObjForm, frm601_10MaterialReceiptView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_10MaterialReceiptView).gvAdvBandedQuotationView, "ReceiptNo", Me.txtReceiptNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Material Receipt's Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        If isExecutedFrom_frm601_08PurchaseOrderView = True Then
            Try
                CType(ObjForm, frm601_08PurchaseOrderView).RetrieveVoucher(CType(ObjForm, frm601_08PurchaseOrderView).txtStartDate.EditValue, CType(ObjForm, frm601_08PurchaseOrderView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_08PurchaseOrderView).gvAdvBandedQuotationView, "PONo", Me.txtPONo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Purchase Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        If isExecutedFrom_frm601_23MaterialReceiptsDetails = True Then
            Try
                CType(ObjForm, frm601_23MaterialReceiptsDetails).RetrieveVoucher(CType(ObjForm, frm601_23MaterialReceiptsDetails).txtStartDate.EditValue, CType(ObjForm, frm601_23MaterialReceiptsDetails).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_23MaterialReceiptsDetails).gvAdvBandedQuotationView, "ReceiptNo", Me.txtReceiptNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Material Receipt's Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        '
        If isExecutedFrom_frm600_01InventoryStockEdit = True Then
            Try
                'Me.Qry605_06MaterailReceiptDetailsTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit5.qry605_06MaterailReceiptDetails, StockCode)
                CType(ObjForm, frm600_01InventoryStockEdit).Qry605_06MaterailReceiptDetailsTableAdapter.FillByGSCode(CType(ObjForm, frm600_01InventoryStockEdit).Dsfrm600_01InventoryStockEdit5.qry605_06MaterailReceiptDetails, CType(ObjForm, frm600_01InventoryStockEdit).txtStockCode.EditValue)

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Material Receipt's Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.ItemClick
        If isControlsModified = True Then
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("Material Receipt Details have been edited, would you like to save changes?", "Save Changes?", MessageBoxButtons.YesNoCancel)

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

    Public Function GetNewReceiptNo(ByVal MaterialReceiptAbbrv As String, ByVal YearInDigit As Integer, ByVal ReceiptDate As Date, ByVal IsResetByYear As Boolean) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1

            If IsResetByYear = True Then
                SqlCommand1.CommandText = "select max(cast(right(ReceiptNo,5) as int)) from tbl605_01MaterialReceiptMaster where ReceiptNo <> 'OPENING-BAL' and Year(ReceiptDate) = '" & Year(ReceiptDate).ToString & "'"
            Else
                SqlCommand1.CommandText = "select max(cast(right(ReceiptNo,5) as int)) from tbl605_01MaterialReceiptMaster where ReceiptNo <> 'OPENING-BAL'"
            End If

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
            strNewQuotationNo = MaterialReceiptAbbrv & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
            strNewQuotationNo = MaterialReceiptAbbrv & strYear & "-" & "00001"
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function


    'Saving and updating codes
    Public Sub NewReceiptMaster(ByVal ReceiptNo As String)
        Try
            If CheckIfNull(ReceiptNo) = False Then
                Me.Tbl60501MaterialReceiptMasterBindingSource.AddNew()
                Me.txtReceiptNo.EditValue = ReceiptNo
                isBeingUpdated = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Material Receipt", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddNewLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewLineItem.ItemClick
        Try
            If CheckIfNull(Me.txtReceiptNo.EditValue) = False Then
                If Me.btnSave.Caption = "Save" Then
                    SaveNewReceiptMaster(Me.txtReceiptNo.EditValue)
                    Me.btnSave.Caption = "Update"
                End If

                Me.AddNewChild()
                Me.Validate()
                'Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, DeliveryNoteNo)
                Me.Qry60502MaterialReceiptChildBindingSource.EndEdit()
                Me.Qry605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild)
                Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtReceiptNo.EditValue)

                Me.gvInvoiceChild.MoveLast()
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.Columns("GSCode")
                Me.gvInvoiceChild.ShowEditor()
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Material Receipt Note Line Item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm601_09MaterialReceiptEdit.Tables("qry605_02MaterialReceiptChild")
            dr = dt.NewRow()
            dr("ReceiptChildSlNo") = 1
            dr("ReceiptNo") = Me.txtReceiptNo.EditValue
            dr("GSCode") = ""
            dr("QtyReceived") = 1
            dr("LineOrderNo") = GetNewReceiptLineItemNo(Me.txtReceiptNo.EditValue)
            dt.Rows.Add(dr)
            Me.Qry605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Material Receipt Line Item, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewReceiptLineItemNo(ByVal strReceiptNo As String) As Integer
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Max(LineOrderNo) from tbl605_02MaterialReceiptChild where ReceiptNo = '" & strReceiptNo & "'"
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

    Private Sub DeleteReceiptChild(ByVal ReceiptChildSlNo As Integer, ByVal WithMessage As Boolean)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp605_01DeleteMaterialReceiptChild"
            Dim paramPayrollInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ReceiptChildNo", SqlDbType.Int)

            paramPayrollInvoiceNo.Value = ReceiptChildSlNo

            SqlCommand1.ExecuteNonQuery()

            If WithMessage = True Then
                MessageBox.Show("Material Receipt Line Item Deleted Successfully,", "Data Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As System.InvalidCastException
            MessageBox.Show("Material Receipt Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteLineItem.ItemClick

        DialogResult = MessageBox.Show("You are about to delete Material Receipt Line Item." & vbCrLf & "Are you Sure want to delete this Material Receipt Details?", "Delete Material Receipt Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedReceiptChildSlNo) = False Then

                Me.DeleteReceiptChild(Me.SelectedReceiptChildSlNo, True)

                'Refresh the datagrid
                'fill child details in the datagrid
                Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtReceiptNo.EditValue)

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
                SelectedReceiptChildSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ReceiptChildSlNo"))
                Me.popInvoiceChild.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAddLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddLineItem.ItemClick
        If CheckIfNull(Me.txtReceiptNo.EditValue) = False Then
            Me.AddNewChild()
            Me.Validate()
            Me.Qry60502MaterialReceiptChildBindingSource.EndEdit()
            Me.Qry605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild)

            Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtReceiptNo.EditValue)
        End If
    End Sub

    Public Sub UpdateInvoiceChild()
        Try

            Me.Validate()
            Me.Qry60502MaterialReceiptChildBindingSource.EndEdit()
            Me.Qry605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild)

            RefreshPOChild()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub RefreshPOChild()
        Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtReceiptNo.EditValue)

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick

        Try
            'Check if the JV is entered already using VoucherRefNO
            If CheckIfReceiptEntryAlreadyPosted(Me.txtReceiptNo.EditValue) = True Then
                MessageBox.Show("Material Receipt Entry is already posted to your ledgers.", "Receipt Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Check if the Voucher is approved already
            If CheckIfReceiptIsApproved(Me.txtReceiptNo.EditValue) = True Then
                MessageBox.Show("Material Receipt is already approved, You cannot delete the Approved Material Receipt", "Material Receipt Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Material Receipt from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtReceiptNo.EditValue) = False Then
                    If DeleteReceipt(Me.txtReceiptNo.EditValue) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.txtReceiptNo.EditValue, "VoucherScanned\IMSReceipt")

                        MessageBox.Show("Material Receipt has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Material Receipt", "IMS Material Receipt Ref No." & Me.txtReceiptNo.EditValue & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogonUser & ".", Me.strLogonUser, Me.txtReceiptNo.EditValue)

                        'Refresh the datagrid
                        RefreshReceiptMasterDataGrid()

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

    Public Function CheckIfReceiptEntryAlreadyPosted(ByVal ReceiptNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReceiptNo from tbl605_01MaterialReceiptMaster where (IsPosted = 1) and (ReceiptNo = '" & ReceiptNo & "')"

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

    Private Function CheckIfReceiptIsApproved(ByVal ReceiptNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReceiptNo from tbl605_01MaterialReceiptMaster where (ReceiptNo = '" & ReceiptNo & "') and (Isnull(IsApproved,0) = 1 )"

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

    Private Function DeleteReceipt(ByVal ReceiptNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl605_01MaterialReceiptMaster WHERE ReceiptNo   = '" & ReceiptNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl605_02MaterialReceiptChild WHERE ReceiptNo   = '" & ReceiptNo & "'"
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


    Public Sub DisableApprovedVoucherEditing(ByVal ReceiptNo As String)
        'Disable access if the voucher is already approved.
        'Get the IsVoucherIsApproved
        If CheckIfReceiptIsApproved(ReceiptNo) = True Then
            Me.btnAddLineItem.Enabled = False
            Me.btnSave.Enabled = False
            Me.btnSaveAndClose.Enabled = False
            Me.btnAddNewLineItem.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnVerify.Enabled = False
            Me.btnApprove.Enabled = False
            Me.gcInvoiceChild.Enabled = False

            Me.btnPreviewMRNFormat1.Enabled = True
            Me.btnPrint.Enabled = True

        End If

        'Me.CheckIfPDFAvailable(voucherNo)
    End Sub

    Public Sub DisableControlsForInventoryGroupMaster(ByVal InventoryGroupMaster As Integer)
        If InventoryGroupMaster = 99 Then
            Me.txtInventoryGroupMaster.Enabled = True
        Else
            Me.txtInventoryGroupMaster.Enabled = False
        End If

    End Sub

    Private Sub txtSupplierName_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSupplierName.ButtonClick
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
            frm30110SupplierMaster.isExecutedFrom_frm601_09MaterialReceiptEdit = True

        ElseIf e.Button.Index = 1 Then

            If CheckIfNull(Me.txtSupplierName.EditValue) = True Or Me.txtSupplierName.Text = String.Empty Then
                MessageBox.Show("Please select the Supplier to edit.", "Select Supplier to edit", MessageBoxButtons.OK)
            Else
                Dim frm30110SupplierMaster As New frm30110SupplierMaster
                frm30110SupplierMaster.ObjForm = Me

                frm30110SupplierMaster.isExecutedFrom_frm601_09MaterialReceiptEdit = True

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

    Private Sub txtSupplierName_EditValueChanged(sender As Object, e As EventArgs) Handles txtSupplierName.EditValueChanged
        'Try
        '    If CheckIfNull(Me.txtSupplierName.EditValue) = False Then
        '        ' Me.Tbl30199_SupplierMasterTableAdapter.Fill(Me.Ds40117PropertyPOEdit1.tbl30199_SupplierMaster)

        '        Me.txtClientRefName.EditValue = Me.Dsfrm601_07PurchaseOrderEdit.Tables("tbl30199_SupplierMaster").Rows.Find(Me.txtSupplierName.EditValue).Item("ContactPerson")
        '        Me.txtClientContactNo.EditValue = Me.Dsfrm601_07PurchaseOrderEdit.Tables("tbl30199_SupplierMaster").Rows.Find(Me.txtSupplierName.EditValue).Item("ContactPhone1")
        '        Me.txtClientEmail.EditValue = Me.Dsfrm601_07PurchaseOrderEdit.Tables("tbl30199_SupplierMaster").Rows.Find(Me.txtSupplierName.EditValue).Item("ContactEmail")
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtSignatory_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSignatory.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40115QuotationSignatories As New frm40115QuotationSignatories
            frm40115QuotationSignatories.ObjForm = Me
            frm40115QuotationSignatories.Show()
            frm40115QuotationSignatories.txtSignatoryName.Focus()
            frm40115QuotationSignatories.isExecutedFrom_frm601_09MaterialReceiptEdit = True
        End If
    End Sub

    Private Sub repoDetailedDescription_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoDetailedDescription.ButtonClick
        If e.Button.Index = 1 Then
            Try
                Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                frm20163VATGoodsAndServicesEdit.ObjForm = Me

                frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Save"
                frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_09MaterialReceiptEdit = True


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
                    frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_09MaterialReceiptEdit = True

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
                    frm600_01InventoryStockEdit.isExecutedFrom_frm601_09MaterialReceiptEdit = True

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


                Dim intFocusedRow As Integer = Me.gvInvoiceChild.FocusedRowHandle
                UpdateInvoiceChild()
                Me.gvInvoiceChild.FocusedRowHandle = intFocusedRow
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.VisibleColumns(6)
                Me.gvInvoiceChild.ShowEditor()

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




    Private Sub frm40117PropertyPOEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm601_09MaterialReceiptEdit.tbl600_01StoreMaster' table. You can move, or remove it, as needed.
        Me.Tbl600_01StoreMasterTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl600_01StoreMaster)
        'TODO: This line of code loads data into the 'Dsfrm601_09MaterialReceiptEdit.tbl20101SalesPersonMaster' table. You can move, or remove it, as needed.
        Me.Tbl20101SalesPersonMasterTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl20101SalesPersonMaster)
        'TODO: This line of code loads data into the 'Dsfrm601_09MaterialReceiptEdit.tbl605_03ReceiptType' table. You can move, or remove it, as needed.
        Me.Tbl605_03ReceiptTypeTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl605_03ReceiptType)
        'TODO: This line of code loads data into the 'Dsfrm601_09MaterialReceiptEdit.tbl600_08InventoryMasterGroup' table. You can move, or remove it, as needed.
        Me.Tbl600_08InventoryMasterGroupTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl600_08InventoryMasterGroup)
        'TODO: This line of code loads data into the 'Dsfrm601_09MaterialReceiptEdit1.qry700_02ProjectsViewMaster' table. You can move, or remove it, as needed.
        Me.Qry700_02ProjectsViewMasterTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit1.qry700_02ProjectsViewMaster)

        Me.Tbl901CompanyDetailsTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl901CompanyDetails)
        Me.Tbl90104DocumentSignatoriesTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl90104DocumentSignatories)
        Me.Tbl20168VATPurchaseTaxSlabsTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl20168VATPurchaseTaxSlabs)
        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl40111PropertyUnitCodes)

        Me.Tbl30199_SupplierMasterTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl30199_SupplierMaster)

        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit.tbl20164GoodsAndServicesMaster)
        Else
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.FillByInventoryMasterGroupID(Me.Dsfrm601_09MaterialReceiptEdit.tbl20164GoodsAndServicesMaster, Me.intLogOnInventoryAccessLevel)
        End If

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit", Me.gvInvoiceChild)

        Me.ImplementAccess(Me.intLogOnUserID)

        'Populate Custom Reports Tab
        Me.PopulateCustomReportButtons(Me.CustomReportFormNo)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colcalcTaxAmount.DisplayFormat.FormatString = "{0:###,###,##0.000}"
            colLineAmount.DisplayFormat.FormatString = "{0:###,###,##0.000}"

        End If
    End Sub


    Public Sub ImplementAccess(ByVal UserID As Integer)
        If GetUserAccess(UserID, "frm601_09MaterialReceiptEdit_FullAccess") = True Then

            Me.btnResetLayout.Enabled = True
            Me.btnSetDefaultLayout.Enabled = True
            Me.btnMoveUp.Enabled = True
            Me.btnMoveDown.Enabled = True
            Me.btnSave.Enabled = True
            Me.btnSaveAndClose.Enabled = True
            Me.btnPreviewMRNFormat1.Enabled = True
            Me.btnPreviewMRNFormat2.Enabled = True
            Me.btnDelete.Enabled = True
            Me.btnAddNewLineItem.Enabled = True
            Me.btnBack.Enabled = True
            Me.btnAttachments.Enabled = True
            Me.btnSubmit.Enabled = True
            Me.btnVerify.Enabled = True
            Me.btnApprove.Enabled = True
            Me.btnDeleteLineItem.Enabled = True
            Me.btnDeleteSelected.Enabled = True
            Me.btnAddLineItem.Enabled = True
            Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = True
            Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = True

            For i As Integer = 0 To tabMaterialReceipt.TabPages.Count - 1
                If tabMaterialReceipt.TabPages(i).Name = "pageSignatories" Then

                    Me.txtSignatory.Properties.Buttons.Item(1).Enabled = True

                    Exit For
                End If
            Next

            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = True


        Else

            Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnResetLayout")
            Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnSetDefaultLayout")
            Me.btnMoveUp.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnMoveUp")
            Me.btnMoveDown.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnMoveDown")
            Me.btnSave.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnSave")
            Me.btnSaveAndClose.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnSaveAndClose")
            Me.btnPreviewMRNFormat1.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnPreviewMRNFormat1")
            Me.btnPreviewMRNFormat2.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnPreviewMRNFormat2")
            Me.btnDelete.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnDelete")
            Me.btnAddNewLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnAddNewLineItem")
            Me.btnBack.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnBack")
            Me.btnAttachments.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnAttachments")
            Me.btnVerify.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnVerify")
            Me.btnApprove.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnApprove")
            Me.btnDeleteLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnDeleteLineItem")
            Me.btnDeleteSelected.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnDeleteSelected")
            Me.btnAddLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnAddLineItem")

            Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_txtSupplierName")
            Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_txtSupplierName")

            Me.btnSubmit.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnSubmit")

            For i As Integer = 0 To tabMaterialReceipt.TabPages.Count - 1
                If tabMaterialReceipt.TabPages(i).Name = "pageSignatories" Then

                    Me.txtSignatory.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_txtSignatory")

                    Exit For
                End If
            Next

            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_AddItemMaster")
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_EditItemMaster")
            Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_EditItemMaster")


            Dim DisablePriceDetails As Boolean = GetUserAccess(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_DisablePriceDetails")

            Me.colUnitRate.Visible = DisablePriceDetails
            Me.colUnitRate.OptionsColumn.AllowShowHide = DisablePriceDetails

            Me.colDiscount.Visible = DisablePriceDetails
            Me.colDiscount.OptionsColumn.AllowShowHide = DisablePriceDetails

            Me.colcalcTaxAmount.Visible = DisablePriceDetails
            Me.colcalcTaxAmount.OptionsColumn.AllowShowHide = DisablePriceDetails

            Me.colLineAmount.Visible = DisablePriceDetails
            Me.colLineAmount.OptionsColumn.AllowShowHide = DisablePriceDetails

            Me.colcalcLineAmountBeforeDiscount.Visible = DisablePriceDetails
            Me.colcalcLineAmountBeforeDiscount.OptionsColumn.AllowShowHide = DisablePriceDetails

            Me.colLineTotalWithTax.Visible = DisablePriceDetails
            Me.colLineTotalWithTax.OptionsColumn.AllowShowHide = DisablePriceDetails


        End If
    End Sub

    Private Sub btnPreviewPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewMRNFormat1.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            For i As Integer = 0 To tabMaterialReceipt.TabPages.Count - 1
                If tabMaterialReceipt.TabPages(i).Name = "pageCompanyDetails" Then
                    tabMaterialReceipt.SelectedTabPage = tabMaterialReceipt.TabPages(i)
                    Exit For
                End If
            Next

            For i As Integer = 0 To tabMaterialReceipt.TabPages.Count - 1
                If tabMaterialReceipt.TabPages(i).Name = "pageSignatories" Then
                    tabMaterialReceipt.SelectedTabPage = tabMaterialReceipt.TabPages(i)
                    Exit For
                End If
            Next

            GetReportDetails("IMS-MRN-01")

            If CheckIfNull(gReportSet) = False Then
                If gReportSet = "110" Then  '110 for precision - 
                    PrintMR_Precision()
                Else
                    PrintRequest()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub PrintRequest()

        Dim rpt1 As New rpt601_04MaterialReceiptFormat01
        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = "IMS-MRN-01"
        Dim frm1 As New frm999_06ReportPreviewIMS_Receipts

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------
        rpt1.Qry605_05MaterialReceiptReportTableAdapter.FillByReceiptNo(rpt1.DsRpt601_04MaterialReceipt1.qry605_05MaterialReceiptReport, Me.txtReceiptNo.EditValue)

        If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
            If Me.txtShowCompanySeal.EditValue = True Then
                rpt1.txtCompanySeal.Visible = True
            Else
                rpt1.txtCompanySeal.Visible = False
            End If
        End If

        If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
            If Me.txtShowSignature.EditValue = True Then
                rpt1.txtSignatureImage.Visible = True
            Else
                rpt1.txtSignatureImage.Visible = False
            End If
        End If

        If Not CheckIfNull(Me.txtIsServiceEntrySheet.EditValue) Then
            If Me.txtIsServiceEntrySheet.EditValue = True Then
                rpt1.lblMRN.Text = "S E R V I C E  E N T R Y   N O T E"
                rpt1.lblMRNumber.TextFormatString = "Service Entry Note No : {0}"
            End If
        End If

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
        rpt1.intCompanyID = Me.txtCompanyID.EditValue
        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Material_Receipt_No_" & Me.txtReceiptNo.EditValue & "_" & Me.txtSupplierName.Text
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

    Private Sub PrintMR_Precision()

        Dim rpt1 As New rpt601_99_03MaterialReceipt
        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = "IMS-MRN-02"
        Dim frm1 As New frm999_06ReportPreviewIMS_Receipts

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------
        rpt1.Qry605_05MaterialReceiptReportTableAdapter.FillByReceiptNo(rpt1.DsRpt601_04MaterialReceipt1.qry605_05MaterialReceiptReport, Me.txtReceiptNo.EditValue)

        rpt1.RequestParameters = False
        '-------------------------------------
        ' New Report Design Code Starts here
        '-------------------------------------
        frm1.ReportCode = ReportCode
        frm1.DocumentViewer1.DocumentSource = rpt1
        rpt1.DisplayName = ReportCode
        frm1.intLogOnUserID = Me.intLogOnUserID
        frm1.strLogonUser = Me.strLogonUser
        frm1.intCustomReportFormNo = CustomReportFormNo
        frm1.objForm = Me
        frm1.ReportName = rpt1
        frm1.Show()
        '-------------------------------------
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_09MaterialReceiptEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_09MaterialReceiptEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvInvoiceChild))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvInvoiceChild))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeleteSelected_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteSelected.ItemClick
        DialogResult = MessageBox.Show("You are about to delete all the Selected Material Receipt Note Line Item." & vbCrLf & "Are you Sure want to delete this Material Receipt Note Details?", "Delete Material Receipt Note Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Dim view As GridView = gvInvoiceChild
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    Dim ChosenReceiptNoteSlNo As Integer = view.GetRowCellValue(row, view.Columns("ReceiptChildSlNo"))
                    Me.DeleteReceiptChild(ChosenReceiptNoteSlNo, False)
                Next
            End If
            'Refresh the datagrid
            'fill child details in the datagrid
            Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtReceiptNo.EditValue)

        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub

        End If
    End Sub


#Region "Attach PDF files"

    Dim ScannedFileLocation As String = ""
    Private Sub GetTheScannedFileLocation()
        GetCompanyDetails(1)
        ScannedFileLocation = ""
        ScannedFileLocation = gScannedLocation
        ScannedFileLocation = gScannedLocation & "VoucherScanned\IMSReceipt"
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
        AttachFile(Me.txtReceiptNo.EditValue, ScannedFileLocation)
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
                frmDocuments.IsIMSReceipt = True
                frmDocuments.Show()
            Else
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = DocumentNo
                frmDocuments.IsIMSReceipt = True
                frmDocuments.Show()
                frmDocuments.OpenFileDialogBox()
            End If

        End If
    End Sub


#End Region


    Private Sub btnPreviewReceiptFormat2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewMRNFormat2.ItemClick
        Me.PrintMR_Precision()

    End Sub

    Private Sub txtReceiptDate_Leave(sender As Object, e As EventArgs) Handles txtReceiptDate.Leave
        'DATE BLOCKING
        GetCompanyDetails02(1)
        If gIsDateLockingEnabled = True Then
            If CheckIfNull(Me.txtReceiptDate.EditValue) = True Then
                Me.txtReceiptDate.EditValue = Date.Today()
            End If
            If CheckIfDateBeenLocked("IMS_RECEIPTS", Me.txtReceiptDate.EditValue) = True Then
                MessageBox.Show("This Material Receipt Note Entry date has been blocked." & vbCrLf & "Please review your entry date.", "Entry Date is Blocked", MessageBoxButtons.OK)
                Me.txtReceiptDate.EditValue = Me.txtReceiptDate.OldEditValue
                Me.txtReceiptDate.Focus()
                Exit Sub
            End If
        End If
    End Sub


#Region "Populate Custom Report Buttons"
    'Change this code for other forms.. 
    Dim CustomReportFormNo As Integer = 3


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
        'Check if the report format is IMS-MPR-01 THEN LOAD FIRST REPORT
        'Get CustomReportCode (Desinged from this Custom Report)
        GetNewBaseReportNo(e.Item.Name)

        If grBaseReportNo = "IMS-MRN-01" Then
            Me.OpenReportDesignOne(e.Item.Name, CustomReportFormNo)
        ElseIf grBaseReportNo = "IMS-MRN-02" Then
            Me.OpenReportDesignTwo(e.Item.Name, CustomReportFormNo)
        End If
    End Sub

    Private Sub OpenReportDesignOne(ByVal ReportNo As String, ByVal CustomReportFormNo As Integer)
        Dim rpt1 As New rpt601_04MaterialReceiptFormat01
        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = ReportNo
        Dim frm1 As New frm999_06ReportPreviewIMS_Receipts

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------
        rpt1.Qry605_05MaterialReceiptReportTableAdapter.FillByReceiptNo(rpt1.DsRpt601_04MaterialReceipt1.qry605_05MaterialReceiptReport, Me.txtReceiptNo.EditValue)

        If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
            If Me.txtShowCompanySeal.EditValue = True Then
                rpt1.txtCompanySeal.Visible = True
            Else
                rpt1.txtCompanySeal.Visible = False
            End If
        End If

        If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
            If Me.txtShowSignature.EditValue = True Then
                rpt1.txtSignatureImage.Visible = True
            Else
                rpt1.txtSignatureImage.Visible = False
            End If
        End If

        If Not CheckIfNull(Me.txtIsServiceEntrySheet.EditValue) Then
            If Me.txtIsServiceEntrySheet.EditValue = True Then
                rpt1.lblMRN.Text = "S E R V I C E  E N T R Y   N O T E"
                rpt1.lblMRNumber.TextFormatString = "Service Entry Note No : {0}"
            End If
        End If

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
        rpt1.intCompanyID = Me.txtCompanyID.EditValue
        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Material_Receipt_No_" & Me.txtReceiptNo.EditValue & "_" & Me.txtSupplierName.Text
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

    Private Sub OpenReportDesignTwo(ByVal ReportNo As String, ByVal CustomReportFormNo As Integer)

        Dim rpt1 As New rpt601_99_03MaterialReceipt
        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = ReportNo
        Dim frm1 As New frm999_06ReportPreviewIMS_Receipts

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------
        rpt1.Qry605_05MaterialReceiptReportTableAdapter.FillByReceiptNo(rpt1.DsRpt601_04MaterialReceipt1.qry605_05MaterialReceiptReport, Me.txtReceiptNo.EditValue)

        rpt1.RequestParameters = False
        '-------------------------------------
        ' New Report Design Code Starts here
        '-------------------------------------
        frm1.ReportCode = ReportCode
        frm1.DocumentViewer1.DocumentSource = rpt1
        rpt1.DisplayName = ReportCode
        frm1.intLogOnUserID = Me.intLogOnUserID
        frm1.strLogonUser = Me.strLogonUser
        frm1.intCustomReportFormNo = CustomReportFormNo
        frm1.objForm = Me
        frm1.ReportName = rpt1
        frm1.Show()
        '-------------------------------------
    End Sub

    Private Sub btnSubmit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSubmit.ItemClick
        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnSubmit") = False Then
            MessageBox.Show("You have no Access rights to Submit the Material Receipt. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Me.SubmitMaterialReceipt(Me.txtReceiptNo.EditValue)

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60109-001")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " submitted a Material Receipt for your verification."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New PR/Enquiry is ready to verify.")

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshReceiptMasterDataGrid()
    End Sub

    Private Sub SubmitMaterialReceipt(ByVal ReceiptNo As String)
        If CheckIfNull(ReceiptNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60501MaterialReceiptMasterBindingSource.Current, DataRowView)
            view.Row("IsSubmitted") = True
            view.Row("SubmittedBy") = Me.strLogonUser
            view.Row("SubmittedOn") = Date.Now

            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            'view.Row("QuoteSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            ''Set the Status to 31 - Enquiry/Request Submitted
            'view.Row("PurchaseRequestStatusID") = 31

            Me.Tbl60501MaterialReceiptMasterBindingSource.EndEdit()
            Me.Tbl605_01MaterialReceiptMasterTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.tbl605_01MaterialReceiptMaster)

            MessageBox.Show("Material Receipt has been submitted for Approval.", "Submit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Public Sub DisableAllControls()

        Me.btnMoveUp.Enabled = False
        Me.btnMoveDown.Enabled = False
        Me.btnResetLayout.Enabled = False
        Me.btnSetDefaultLayout.Enabled = False

        Me.btnSave.Enabled = False
        Me.btnSaveAndClose.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnAddNewLineItem.Enabled = False
        Me.btnBack.Enabled = True
        Me.btnAttachments.Enabled = True
        Me.btnSubmit.Enabled = False
        Me.btnVerify.Enabled = False
        Me.btnApprove.Enabled = False

        Me.btnDeleteLineItem.Enabled = False
        Me.btnDeleteSelected.Enabled = False
        Me.btnAddLineItem.Enabled = False

        Me.gcInvoiceChild.Enabled = False

        DisableAllControlInTabPage(Me.tabMaterialReceipt)


    End Sub

    Public Sub EnableAllControls()

        Me.btnMoveUp.Enabled = True
        Me.btnMoveDown.Enabled = True
        Me.btnResetLayout.Enabled = True
        Me.btnSetDefaultLayout.Enabled = True

        Me.btnSave.Enabled = True
        Me.btnSaveAndClose.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnAddNewLineItem.Enabled = True
        Me.btnBack.Enabled = True
        Me.btnAttachments.Enabled = True
        Me.btnSubmit.Enabled = True
        Me.btnVerify.Enabled = True
        Me.btnApprove.Enabled = True

        Me.btnDeleteLineItem.Enabled = True
        Me.btnDeleteSelected.Enabled = True
        Me.btnAddLineItem.Enabled = True

        Me.gcInvoiceChild.Enabled = True



    End Sub

    Private Sub btnVerify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnVerify.ItemClick
        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnVerify") = False Then
            MessageBox.Show("You have no Access rights to Verify the Material Receipt. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ''Check if this Pr Signatory have Verification Signature
        'If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
        '    MessageBox.Show("Verifying User have not assigned to Signatory in the System.", "Verify Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'Check if this PR is submitted
        If CheckIfMaterialReceiptIsSubmitted(Me.txtReceiptNo.EditValue) = False Then
            MessageBox.Show("Material Receipt is not yet Submitted, please submit the Material Receipt for verfication process.", "Sales Order Not Submitted for verification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Me.VerifyMaterialReceipt(Me.txtReceiptNo.EditValue)

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60109-002")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " verified & Sent the Material Receipt for your Approval."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New PR/Enquiry is ready to Approve.")

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshReceiptMasterDataGrid()
    End Sub

    Public Function CheckIfMaterialReceiptIsSubmitted(ByVal ReceiptNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReceiptNo from tbl605_01MaterialReceiptMaster where (ReceiptNo = '" & ReceiptNo & "') and (Isnull(IsSubmitted,0) = 1 )"

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

    Private Sub VerifyMaterialReceipt(ByVal ReceiptNo As String)
        If CheckIfNull(ReceiptNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60501MaterialReceiptMasterBindingSource.Current, DataRowView)
            view.Row("IsVerified") = True
            view.Row("VerifiedBy") = Me.strLogonUser
            view.Row("VerifiedOn") = Date.Now
            ''Set the Status to 32 - Enquiry/Request Verified
            'view.Row("PurchaseRequestStatusID") = 32

            'view.Row("VerifiedSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            Me.Tbl60501MaterialReceiptMasterBindingSource.EndEdit()
            Me.Tbl605_01MaterialReceiptMasterTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.tbl605_01MaterialReceiptMaster)

            MessageBox.Show("Material Receipt has been Verified and processed for Approval.", "Verify Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnApprove_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnApprove.ItemClick
        For i As Integer = 0 To tabMaterialReceipt.TabPages.Count - 1
            If tabMaterialReceipt.TabPages(i).Name = "pageCompanyDetails" Then
                tabMaterialReceipt.SelectedTabPage = tabMaterialReceipt.TabPages(i)
                Exit For
            End If
        Next

        For i As Integer = 0 To tabMaterialReceipt.TabPages.Count - 1
            If tabMaterialReceipt.TabPages(i).Name = "pageSignatories" Then
                tabMaterialReceipt.SelectedTabPage = tabMaterialReceipt.TabPages(i)
                Exit For
            End If
        Next

        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnApprove") = False Then
            MessageBox.Show("You have no Access rights to Approve the Material Receipt. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        ''Check if this MPR Signatory have Verification Signature
        'If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
        '    MessageBox.Show("Approving User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If


        'Check if this MPR is Verified
        If CheckIfMaterialReceiptIsVerified(Me.txtReceiptNo.EditValue) = False Then
            If MessageBox.Show("Material Receipt is not yet Verified, Click Yes If you want to verify and Approve this Material Receipt.", "Material Receipt is not Verified.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                Me.VerifyMaterialReceipt(Me.txtReceiptNo.EditValue)
            Else
                Exit Sub
            End If
        End If

        Me.ApproveMaterialReceipt(Me.txtReceiptNo.EditValue)

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60109-003")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " approved " & "Material Receipt No: " & Me.txtReceiptNo.EditValue & " for Processing."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify PR/Enquiry is ready to process.")

        End If

        If gIsEmailAlertActivated = True Then
            Me.SplashScreenManager1.ShowWaitForm()
            Dim AlertMessage2 As String = ""
            AlertMessage2 = "Mr." & Me.strLogonUser & " has Approved Material Receipt No. <font color=blue><b>" & Me.txtReceiptNo.EditValue & "</b></font> for Delivery."

            If Not Directory.Exists("C:\ReportsToEmail") Then
                Directory.CreateDirectory("C:\ReportsToEmail")
            End If

            Dim DestinationFile As String = "C:\ReportsToEmail"
            DestinationFile = DestinationFile & "\Receipt_" & Me.txtReceiptNo.EditValue & "_Approved.pdf"
            ExportReceiptToPDF(DestinationFile)
            SendEmailsWtAttachment(gEmailAlertSetForEmails, "Material Received approved for Delivery (" & Me.txtReceiptNo.EditValue & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)
            Me.SplashScreenManager1.CloseWaitForm()
        End If

        If gIsEmailToProjectIncharge = True Then

            Me.SplashScreenManager1.ShowWaitForm()
            SplashScreenManager1.SetWaitFormCaption("Please wait")
            SplashScreenManager1.SetWaitFormDescription("emailing to Project Incharge...")

            If CheckIfNull(Me.txtProjectCode.EditValue) = False Then

                GetProjectManagerDetails(Me.txtProjectCode.EditValue)

                Dim AlertMessage2 As String = ""
                AlertMessage2 = "Dear Mr." & gProjectManager & ", <p></p> </p></p> Mr." & Me.strLogonUser & " Approved Material Receipt No. <font color=blue><b>" & Me.txtReceiptNo.EditValue & "</b></font> for Delivery."

                If Not Directory.Exists("C:\ReportsToEmail") Then
                    Directory.CreateDirectory("C:\ReportsToEmail")
                End If

                Dim DestinationFile As String = "C:\ReportsToEmail"
                DestinationFile = DestinationFile & "\Receipt_" & Me.txtReceiptNo.EditValue & "_Approved02.pdf"
                ExportReceiptToPDF(DestinationFile)

                'Get Project Manager Email address
                SendEmailsWtAttachment(gProjectInchargeEmail, "Material Received approved for Delivery (" & Me.txtReceiptNo.EditValue & ")", DestinationFile, AlertMessage2, gEmailAlertSetForEmails_CC)

                Me.SplashScreenManager1.CloseWaitForm()
            End If

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshReceiptMasterDataGrid()
    End Sub

    Public Function CheckIfMaterialReceiptIsVerified(ByVal ReceiptNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReceiptNo from tbl605_01MaterialReceiptMaster where (ReceiptNo = '" & ReceiptNo & "') and (Isnull(IsVerified,0) = 1 )"

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

    Private Sub ApproveMaterialReceipt(ByVal SalesOrderNo As String)
        If CheckIfNull(SalesOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60501MaterialReceiptMasterBindingSource.Current, DataRowView)
            view.Row("IsApproved") = True
            view.Row("ApprovedBy") = Me.strLogonUser
            view.Row("ApprovedOn") = Date.Now
            ''Set the Status to 33 - Enquiry/Request Approved
            'view.Row("PurchaseRequestStatusID") = 33

            'view.Row("ApprovedSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            Me.Tbl60501MaterialReceiptMasterBindingSource.EndEdit()
            Me.Tbl605_01MaterialReceiptMasterTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.tbl605_01MaterialReceiptMaster)

            MessageBox.Show("Material Receipt has been Approved.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Function CheckIfMaterialReceiptIsApproved(ByVal ReceiptNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReceiptNo from tbl605_01MaterialReceiptMaster where (ReceiptNo = '" & ReceiptNo & "') and (Isnull(IsApproved,0) = 1 )"

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

#End Region

    Private Sub ExportReceiptToPDF(ByVal SaveInPath As String)

        Dim rpt1 As New rpt601_04MaterialReceiptFormat01
        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = "IMS-MRN-01"
        Dim frm1 As New frm999_06ReportPreviewIMS_Receipts

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------
        rpt1.Qry605_05MaterialReceiptReportTableAdapter.FillByReceiptNo(rpt1.DsRpt601_04MaterialReceipt1.qry605_05MaterialReceiptReport, Me.txtReceiptNo.EditValue)

        If Not CheckIfNull(Me.txtShowCompanySeal.EditValue) Then
            If Me.txtShowCompanySeal.EditValue = True Then
                rpt1.txtCompanySeal.Visible = True
            Else
                rpt1.txtCompanySeal.Visible = False
            End If
        End If

        If Not CheckIfNull(Me.txtShowSignature.EditValue) Then
            If Me.txtShowSignature.EditValue = True Then
                rpt1.txtSignatureImage.Visible = True
            Else
                rpt1.txtSignatureImage.Visible = False
            End If
        End If

        If Not CheckIfNull(Me.txtIsServiceEntrySheet.EditValue) Then
            If Me.txtIsServiceEntrySheet.EditValue = True Then
                rpt1.lblMRN.Text = "S E R V I C E  E N T R Y   N O T E"
                rpt1.lblMRNumber.TextFormatString = "Service Entry Note No : {0}"
            End If
        End If

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
        rpt1.intCompanyID = Me.txtCompanyID.EditValue
        rpt1.ExportOptions.PrintPreview.DefaultFileName = "Material_Receipt_No_" & Me.txtReceiptNo.EditValue & "_" & Me.txtSupplierName.Text
        rpt1.RequestParameters = False


        rpt1.ExportToPdf(SaveInPath)

    End Sub

    Private Sub btnUseItemDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60502MaterialReceiptChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.EditValue = GetGSCodeDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUseItemDetailedDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDetailedDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60502MaterialReceiptChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.EditValue = GetGSCodeDetailedDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub
End Class