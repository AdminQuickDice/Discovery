Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Public Class frm601_24ProductionReceipt
    Public isBeingUpdated As Boolean = False
    Public isBeingNew As Boolean = False
    Public isControlsModified As Boolean

    Public ObjForm As Object
    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Dim SelectedReceiptChildSlNo As Integer
    Public CreatedNewReceiptNo As String

    Public isExecutedFrom_frm601_05DeliveryNoteEdit As Boolean = False

    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtMaterialReceiptNo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtMaterialReceiptNo, "Material Receipt Number Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtMaterialReceiptNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtMaterialReceiptDate.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtMaterialReceiptDate, "Receipt Date must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtMaterialReceiptDate, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtStoreCode.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtStoreCode, "Store Code must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtStoreCode, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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
        Try
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

        Catch ex As Exception

        End Try
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
        Me.close()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick
        SaveAll(True)
    End Sub

    Private Sub SaveAll(ByVal WithMessage As Boolean)
        'Dim TotalAllocAmount As Decimal = GetTotalAmountAllocated(Me.txtMaterialReceiptNo.EditValue)
        'If Me.txtTotalDeliveryValue.EditValue <> TotalAllocAmount Then
        '    MessageBox.Show("Cannot save the Receipts, total does not match with the Allocated amount", "Errors in Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.btnBack.Enabled = False
        '    Exit Sub
        'End If

        CheckMasterErrors()
        If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
            MessageBox.Show("Cannot continue saving with errors, please clear the errors and continue.", "Clear Errors", MessageBoxButtons.OK)
            Exit Sub

        End If

        If Me.btnSave.Caption = "Update" Then
            UpdateReceiptMaster(Me.txtMaterialReceiptNo.EditValue, WithMessage)
            Me.btnSave.Caption = "Update"

        ElseIf Me.btnSave.Caption = "Save" Then
            If Me.isBeingNew = True Then
                SaveNewReceiptMaster(Me.txtMaterialReceiptNo.EditValue)
                Me.btnSave.Caption = "Update"
            End If
        End If

        Try
            'Update the Data in the Child
            Me.Qry60502MaterialReceiptChildBindingSource.EndEdit()
            Me.Qry605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild)
            Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtMaterialReceiptNo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshReceiptMasterDataGrid()
    End Sub


    Private Sub RefreshReceiptMasterDataGrid()
        'If isExecutedFrom_frm601_10MaterialReceiptView = True Then
        '    Try
        '        CType(ObjForm, frm601_10MaterialReceiptView).RetrieveVoucher(CType(ObjForm, frm601_10MaterialReceiptView).txtStartDate.EditValue, CType(ObjForm, frm601_10MaterialReceiptView).txtEndDate.EditValue)
        '        GoBackToRow(CType(ObjForm, frm601_10MaterialReceiptView).gvAdvBandedQuotationView, "ReceiptNo", Me.txtMaterialReceiptNo.EditValue)
        '    Catch ex As Exception
        '        MessageBox.Show("Error Occured while Refreshing the Material Receipt's Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try

        'End If

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

    Public Function GetNewReceiptNo(ByVal MaterialReceiptAbbrv As String, ByVal YearInDigit As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(right(ReceiptNo,5) as int)) from tbl605_01MaterialReceiptMaster where ReceiptNo <> 'OPENING-BAL'"
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
                Me.txtMaterialReceiptNo.EditValue = ReceiptNo
                isBeingUpdated = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Material Receipt", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm601_09MaterialReceiptEdit.Tables("qry605_02MaterialReceiptChild")
            dr = dt.NewRow()
            dr("ReceiptChildSlNo") = 1
            dr("ReceiptNo") = Me.txtMaterialReceiptNo.EditValue
            dr("GSCode") = Me.txtItemRequested.EditValue
            dr("UnitRateMethod") = Me.txtUnitMethod1.EditValue
            dr("QtyReceived") = Me.txtQty.EditValue
            dr("UnitPrice") = Me.txtUnitRate1.EditValue
            dr("LineOrderNo") = GetNewReceiptLineItemNo(Me.txtMaterialReceiptNo.EditValue)
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

    Private Sub DeleteReceiptChild(ByVal ReceiptChildSlNo As Integer)
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
            MessageBox.Show("Material Receipt Line Item Deleted Successfully,", "Data Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Material Receipt Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteLineEntry.ItemClick

        DialogResult = MessageBox.Show("You are about to delete Material Receipt Line Item." & vbCrLf & "Are you Sure want to delete this Material Receipt Details?", "Delete Material Receipt Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedReceiptChildSlNo) = False Then

                Me.DeleteReceiptChild(Me.SelectedReceiptChildSlNo)

                'Refresh the datagrid
                'fill child details in the datagrid
                Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtMaterialReceiptNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub gvInvoiceChild_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvSubLedger.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedReceiptChildSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ReceiptChildSlNo"))
                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'The Line Total should not be more than the Delivery Total
        'If Me.txtLineTotal.EditValue > Me.txtTotalDeliveryValue.EditValue Then
        '    MessageBox.Show("Received Items Value is greater than the Delivered Total Value", "Value is greater", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        ''Check if the Total Delivery - Total Receipt
        'Dim EnteredAmount As Decimal = Me.txtLineTotal.EditValue
        'Dim VoucherAmount As Decimal = Me.txtTotalDeliveryValue.EditValue

        'Dim TotalAmount As Decimal = GetVoucherTotal(Me.txtMaterialReceiptNo.EditValue) 'gvCostAllocation.Columns("AmountAllocated").SummaryItem.SummaryValue
        'Dim EnteringAmount As Decimal = TotalAmount + EnteredAmount

        'If EnteringAmount > VoucherAmount Then
        '    MessageBox.Show("Received Items Value is greater than the Delivered Total Value", "Value is greater", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub

        'End If


        Try
            If CheckIfNull(Me.txtMaterialReceiptNo.EditValue) = False Then
                If Me.btnSave.Caption = "Save" Then
                    SaveNewReceiptMaster(Me.txtMaterialReceiptNo.EditValue)
                    Me.btnSave.Caption = "Update"
                End If

                Me.AddNewChild()
                Me.Validate()
                Me.Qry60502MaterialReceiptChildBindingSource.EndEdit()
                Me.Qry605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild)
                Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtMaterialReceiptNo.EditValue)

                Me.txtQty.EditValue = 1
                Me.txtUnitRate1.EditValue = 0
                Me.txtUnitMethod1.EditValue = ""
                Me.txtItemRequested.EditValue = ""
                Me.txtItemRequested.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Material Receipt Note Line Item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetVoucherTotal(ByVal ReceiptNo As String) As Decimal
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select TotalWithTax from qry605_03MaterialReceiptWithTotal where ReceiptNo = '" & ReceiptNo & "'"
            Dim VoucherTotalAmount As Decimal
            VoucherTotalAmount = SqlCommand1.ExecuteScalar()

            Return VoucherTotalAmount

        Catch ex As System.InvalidCastException

            Return 0

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Public Function GetTotalAmountAllocated(ByVal ReceiptNo As String) As Decimal
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "SELECT SUM(LineTotalWithTax) AS TotalAmountScheduled FROM qry605_02MaterialReceiptChild WHERE (ReceiptNo = '" & ReceiptNo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            Dim LoanAmount As Decimal = 0D
            While srStockReader.Read()
                LoanAmount = srStockReader.Item("TotalAmountScheduled")
            End While

            Return LoanAmount
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return 0D

        Finally
            Sqlconnection1.Close()
        End Try

    End Function

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
        Me.Qry605_02MaterialReceiptChildTableAdapter.FillByReceiptNo(Me.Dsfrm601_09MaterialReceiptEdit.qry605_02MaterialReceiptChild, Me.txtMaterialReceiptNo.EditValue)

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            'Check if the JV is entered already using VoucherRefNO
            If CheckIfReceiptEntryAlreadyPosted(Me.txtMaterialReceiptNo.EditValue) = True Then
                MessageBox.Show("This Receipt Entry is already posted to your ledgers.", "Receipt Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ''Check if the Voucher is approved already
            'If CheckIfReceiptIsApproved(Me.txtReceiptNo.EditValue) = True Then
            '    MessageBox.Show("Material Receipt is already approved, You cannot delete the Approved Material Receipt", "Material Receipt Approved", MessageBoxButtons.OK)
            '    Exit Sub

            'End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Material Receipt from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtMaterialReceiptNo.EditValue) = False Then
                    If DeleteReceipt(Me.txtMaterialReceiptNo.EditValue) = True Then
                        MessageBox.Show("Material Receipt has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
 

   
    Private Sub frm601_24ProductionReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit1.tbl40111PropertyUnitCodes)
        Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm601_09MaterialReceiptEdit1.tbl20164GoodsAndServicesMaster)

    End Sub

    'Private Sub txtQuotedQty_EditValueChanged(sender As Object, e As EventArgs) Handles txtQty.EditValueChanged
    '    Try
    '        If CheckIfNull(Me.txtTotalDeliveryValue.EditValue) = False Then

    '            Dim TotalAmount As Decimal = Me.txtTotalDeliveryValue.EditValue
    '            Dim ReceivedTotal As Decimal = Me.GetReceivedTotal(Me.txtMaterialReceiptNo.EditValue)




    '            'Dim VoucherEntryTotalAmount As Decimal = GetVoucherTotal(Me.SelectedVoucherID)
    '            'VoucherEntryTotalAmount = VoucherEntryTotalAmount + BalanceAmount

    '            'If VoucherEntryTotalAmount > Me.txtVoucherAmount.EditValue Then
    '            '    'MessageBox.Show("Payment voucher amount is more than the balance to paid.")
    '            '    Me.txtEntryAmount.EditValue = Me.txtVoucherAmount.EditValue - GetVoucherTotal(Me.SelectedVoucherID)

    '            'ElseIf VoucherEntryTotalAmount <= Me.txtVoucherAmount.EditValue Then
    '            '    Me.txtEntryAmount.EditValue = BalanceAmount

    '            'End If

    '            'Me.cmdAdd.Focus()
    '        End If
    '    Catch NullEx As NullReferenceException

    '    Catch ex As Exception
    '        'MessageBox.Show("Error on Retrieving values, Please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Public Function GetReceivedTotal(ByVal ReceiptNo As String) As Decimal
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select TotalWithTax as TotalVoucherAmount from qry605_03MaterialReceiptWithTotal where ReceiptNo = '" & ReceiptNo & "'"
            Dim VoucherTotalAmount As Decimal
            VoucherTotalAmount = SqlCommand1.ExecuteScalar()

            Return VoucherTotalAmount

        Catch ex As System.InvalidCastException

            Return 0

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub txtUnitRate1_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnitRate1.EditValueChanged
        Me.GetLineTotal()

    End Sub
    Private Sub txtQty_EditValueChanged(sender As Object, e As EventArgs) Handles txtQty.EditValueChanged
        Me.GetLineTotal()
    End Sub

    Private Sub GetLineTotal()
        Try
            Dim TotalAmount As Decimal = 0D
            TotalAmount = Me.txtQty.EditValue * txtUnitRate1.EditValue
            Me.txtLineTotal.EditValue = TotalAmount

        Catch ex As Exception

        End Try
    End Sub

 
    Private Sub btnPostJournal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPostJournal.ItemClick
        'Check if the JV is entered already using VoucherRefNO
        If CheckIfReceiptEntryAlreadyPosted(Me.txtMaterialReceiptNo.EditValue) = True Then
            MessageBox.Show("This Receipt Entry is already posted to your ledgers.", "Receipt Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Check if the Invoice has any entries or not
        'If CheckIfDeliveryHasNoAmount(Me.txtDeliveryNoteNo.EditValue) = True Then
        '    MessageBox.Show("This Delivery has no amount to be posted, Please review the Delivery Note again.", "No Amount to post", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        Try
            If CheckIfNull(Me.txtDeliveryNoteNo.EditValue) = False Then
                'Save the Entry
                SaveAll(False)

                Dim CurrentDate As Date = Me.txtDeliveryNoteDate.EditValue
                Dim CurrentYear As String = CurrentDate.Year
                Dim CurrentMonth As String = CurrentDate.Month
                Dim CurrMonthWithZero As String = "00" & CurrentMonth
                Dim VoucherString As String = "JV-" & CurrentYear.Substring(CurrentYear.Length - 2, 2) & "-" & CurrMonthWithZero.Substring(CurrMonthWithZero.Length - 2, 2) & "-"

                Dim VoucherNo As String = GetNewVoucherNo("Journal", "JV", VoucherString, CurrentMonth, CurrentYear)


                Me.PostProductionReceiptJournal(Me.txtDeliveryNoteNo.EditValue, VoucherNo, Me.txtMaterialReceiptNo.EditValue)
                UpdatePosted(True, Me.strLogonUser, Me.txtMaterialReceiptNo.EditValue, VoucherNo)

                MessageBox.Show("Production Receipt has been posted to the Accounting Books.", "Delivery Note Posted Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Refresh the datagrid
                'RefreshMasterDataGrid()
            Else
                'MessageBox.Show("Please select the Journal Posting to proceed.", "Select Posting for.", MessageBoxButtons.OK)
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

    Private Function UpdatePosted(ByVal IsPosted As Boolean, ByVal PostedBy As String, ByVal ReceiptNo As String, ByVal VoucherNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl605_01MaterialReceiptMaster Set IsPosted = '" & IsPosted & "', PostedBy = '" & PostedBy & "', PostedOn = Getdate(), VoucherNo = '" & VoucherNo & "' where ReceiptNo = '" & ReceiptNo & "'"

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
    Public Sub PostProductionReceiptJournal(ByVal DeliveryNoteNo As String, ByVal VoucherNo As String, ByVal ReceiptNo As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_23InsertProductionReceiptToVoucher"
            SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar).Value = DeliveryNoteNo
            SqlCommand1.Parameters.Add("@VoucherNo", SqlDbType.VarChar).Value = VoucherNo
            SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar).Value = Me.strLogonUser
            SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime).Value = Date.Now
            SqlCommand1.Parameters.Add("@ReceiptVoucherNo", SqlDbType.VarChar).Value = ReceiptNo

            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)

        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public Function GetNewVoucherNo(ByVal VoucherType As String, ByVal VoucherPrefix As String, ByVal VoucherString As String, ByVal VoucherMonth As Integer, ByVal VoucherYear As Integer) As String
        Dim strNewReceiptNo As String
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            ' SqlCommand1.CommandText = "select max(cast(RIGHT(VoucherNo, 3) as int)) from tbl201VoucherMaster WHERE VoucherNo like '" & VoucherPrefix & "%' and month(VoucherDate) = '" & VoucherMonth & "' and year(voucherdate) = '" & VoucherYear & "'"
            SqlCommand1.CommandText = "select max(cast(RIGHT(VoucherNo, 3) as int)) from tbl201VoucherMaster WHERE VoucherNo like '" & VoucherString & "%'"

            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewReceiptNo = "0000" & CStr(int1)
            strNewReceiptNo = Microsoft.VisualBasic.Right(strNewReceiptNo, 3)
            strNewReceiptNo = VoucherString & strNewReceiptNo

            Return strNewReceiptNo

        Catch ex As System.InvalidCastException
            strNewReceiptNo = VoucherString & "001"
            Return strNewReceiptNo
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub txtItemRequested_Validated(sender As Object, e As EventArgs) Handles txtItemRequested.Validated
        Try
            If CheckIfNull(Me.txtItemRequested.EditValue) = False Then
                Me.txtUnitMethod1.EditValue = Me.Dsfrm601_09MaterialReceiptEdit1.Tables("tbl20164GoodsAndServicesMaster").Rows.Find(Me.txtItemRequested.EditValue).Item("GSUoM")
                Me.txtUnitRate1.EditValue = Me.Dsfrm601_09MaterialReceiptEdit1.Tables("tbl20164GoodsAndServicesMaster").Rows.Find(Me.txtItemRequested.EditValue).Item("CostPrice")
                Me.txtQty.EditValue = 1
                Me.txtQty.Focus()

            End If
        Catch ex As Exception

        End Try
    End Sub

    
End Class