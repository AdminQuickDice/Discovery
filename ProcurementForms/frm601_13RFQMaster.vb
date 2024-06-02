Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Drawing
Imports System.Text
Imports System.Drawing
Imports DevExpress.XtraBars

Public Class frm601_13RFQMaster
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

    Dim SelectedRFQChildSlNo As Integer
    Public CreatedNewRFQNo As String

    Public isExecutedFrom_frm601_14RFQView As Boolean = False
    Public isExecutedFrom_frm601_12PurchaseRequestView As Boolean = False
    'isExecutedFrom_frm601_12PurchaseRequestView


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


                Exit For
            End If
        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                GetReportDetails("IMS-RFQ-01")
                Me.txtSubject.EditValue = gReportSubject
                Me.txtQuoteIntro.Text = gReportIntroduction
                Me.txtQuoteSummary.Text = gReportSummary
                Exit For
            End If

        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageQuoteDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
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

        Next

    End Sub

    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtRFQNo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtRFQNo, "RFQ Number Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtRFQNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtRFQDate.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtRFQDate, "RFQ Date must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtRFQDate, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtSupplierName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtSupplierName, "Supplier must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtSupplierName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

    End Sub

    Public Sub RetrieveRFQMaster(ByVal RFQNo As String)
        Try
            If CheckIfNull(RFQNo) = False Then
                'fill master details
                Me.Tbl607_01RFQMasterTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.tbl607_01RFQMaster, RFQNo)

                'fill child details in the datagrid
                Me.Qry607_02RFQChildTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild, RFQNo)

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Purchase Order Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateRFQMaster(ByVal RFQNo As String, ByVal WithMessage As Boolean)
        If CheckIfNull(RFQNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60701RFQMasterBindingSource.Current, DataRowView)
            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            Me.Tbl60701RFQMasterBindingSource.EndEdit()
            Me.Tbl607_01RFQMasterTableAdapter.Update(Me.Dsfrm601_13RFQEdit.tbl607_01RFQMaster)

            If WithMessage = True Then
                MessageBox.Show("RFQ Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SaveNewRFQMaster(ByVal RFQNo As String)
        If CheckIfNull(RFQNo) = False Then
            If isBeingNew = True Then
                'Select the Invoice Page

                Dim view As DataRowView = DirectCast(Me.Tbl60701RFQMasterBindingSource.Current, DataRowView)
                view.Row("AddedBy") = Me.strLogonUser
                view.Row("AddedOn") = Date.Now
                Me.Validate()

                Me.Tbl60701RFQMasterBindingSource.EndEdit()
                Me.Tbl607_01RFQMasterTableAdapter.Update(Me.Dsfrm601_13RFQEdit.tbl607_01RFQMaster)
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
            UpdateRFQMaster(Me.txtRFQNo.EditValue, WithMessage)
            Me.btnSave.Caption = "Update"

        ElseIf Me.btnSave.Caption = "Save" Then
            If Me.isBeingNew = True Then
                SaveNewRFQMaster(Me.txtRFQNo.EditValue)
                Me.btnSave.Caption = "Update"
            End If
        End If

        Try
            'Update the Data in the Child
            Me.Qry60702RFQChildBindingSource.EndEdit()
            Me.Qry607_02RFQChildTableAdapter.Update(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild)
            Me.Qry607_02RFQChildTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild, Me.txtRFQNo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshRFQMasterDataGrid()
    End Sub


    Private Sub RefreshRFQMasterDataGrid()
        If isExecutedFrom_frm601_14RFQView = True Then
            Try
                CType(ObjForm, frm601_14RFQView).RetrieveVoucher(CType(ObjForm, frm601_14RFQView).txtStartDate.EditValue, CType(ObjForm, frm601_14RFQView).txtEndDate.EditValue)
                CType(ObjForm, frm601_14RFQView).UpdateFrames()
                GoBackToRow(CType(ObjForm, frm601_14RFQView).gvAdvBandedQuotationView, "RFQNo", Me.txtRFQNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the RFQ List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If isExecutedFrom_frm601_12PurchaseRequestView = True Then
            Try
                CType(ObjForm, frm601_12PurchaseRequestView).RetrieveVoucher(CType(ObjForm, frm601_12PurchaseRequestView).txtStartDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).txtEndDate.EditValue, CType(ObjForm, frm601_12PurchaseRequestView).SelectedRequestedType)
                CType(ObjForm, frm601_12PurchaseRequestView).UpdateFrames()
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Material Request Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.ItemClick
        If isControlsModified = True Then
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("RFQ Details have been edited, would you like to save changes?", "Save Changes?", MessageBoxButtons.YesNoCancel)

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

    Public Function GetNewRFQNo(ByVal RFQAbbrv As String, ByVal YearInDigit As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(right(RFQNo,5) as int)) from tbl607_01RFQMaster"
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
            strNewQuotationNo = RFQAbbrv & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
            strNewQuotationNo = RFQAbbrv & strYear & "-" & "00001"
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function


    'Saving and updating codes
    Public Sub NewRFQMaster(ByVal RFQNo As String)
        Try
            If CheckIfNull(RFQNo) = False Then
                Me.Tbl60701RFQMasterBindingSource.AddNew()
                Me.txtRFQNo.EditValue = RFQNo
                isBeingUpdated = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New RFQ", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddNewLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewLineItem.ItemClick
        Try
            If CheckIfNull(Me.txtRFQNo.EditValue) = False Then
                If Me.btnSave.Caption = "Save" Then
                    SaveNewRFQMaster(Me.txtRFQNo.EditValue)
                    Me.btnSave.Caption = "Update"
                End If

                Me.AddNewChild()
                Me.Validate()
                'Me.Qry603_02DeliveryNoteChildTableAdapter1.FillByDeliveryNote(Me.Dsfrm601_05DeliveryNoteEdit.qry603_02DeliveryNoteChild, DeliveryNoteNo)
                Me.Qry60702RFQChildBindingSource.EndEdit()
                Me.Qry607_02RFQChildTableAdapter.Update(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild)
                Me.Qry607_02RFQChildTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild, Me.txtRFQNo.EditValue)

                Me.gvInvoiceChild.MoveLast()
                Me.gvInvoiceChild.FocusedColumn = Me.gvInvoiceChild.Columns("GSCode")
                Me.gvInvoiceChild.ShowEditor()
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New RFQ Line Item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm601_13RFQEdit.Tables("qry607_02RFQChild")
            dr = dt.NewRow()
            dr("RFQChildSlNo") = 1
            dr("RFQNo") = Me.txtRFQNo.EditValue
            dr("GSCode") = ""
            dr("QuotedQuantity") = 1
            dr("LineOrderNo") = GetNewRFQLineItemNo(Me.txtRFQNo.EditValue)
            dt.Rows.Add(dr)
            Me.Qry607_02RFQChildTableAdapter.Update(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Purchase Order Line Item, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewRFQLineItemNo(ByVal strRFQNo As String) As Integer
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Max(LineOrderNo) from tbl607_02RFQChild where RFQNo = '" & strRFQNo & "'"
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


    Private Sub DeleteRFQChild(ByVal RFQChildSlNo As Integer, ByVal WithMessage As Boolean)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp607_01DeleteRFQChild"
            Dim paramPayrollInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@RFQChildSlNo", SqlDbType.Int)

            paramPayrollInvoiceNo.Value = RFQChildSlNo

            SqlCommand1.ExecuteNonQuery()

            If WithMessage = True Then
                MessageBox.Show("RFQ Line Item Deleted Successfully,", "Data Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As System.InvalidCastException
            MessageBox.Show("RFQ Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLineItem.ItemClick

        DialogResult = MessageBox.Show("You are about to delete RFQ Line Item." & vbCrLf & "Are you Sure want to delete this RFQ Details?", "Delete RFQ Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedRFQChildSlNo) = False Then

                Me.DeleteRFQChild(Me.SelectedRFQChildSlNo, True)

                'Refresh the datagrid
                'fill child details in the datagrid
                Me.Qry607_02RFQChildTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild, Me.txtRFQNo.EditValue)

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
                SelectedRFQChildSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("RFQChildSlNo"))
                Me.popInvoiceChild.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAddLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddLineItem.ItemClick
        If CheckIfNull(Me.txtRFQNo.EditValue) = False Then
            Me.AddNewChild()
            Me.Validate()
            Me.Qry60702RFQChildBindingSource.EndEdit()
            Me.Qry607_02RFQChildTableAdapter.Update(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild)

            Me.Qry607_02RFQChildTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild, Me.txtRFQNo.EditValue)
        End If
    End Sub

    Public Sub UpdateInvoiceChild()
        Try

            Me.Validate()
            Me.Qry60702RFQChildBindingSource.EndEdit()
            Me.Qry607_02RFQChildTableAdapter.Update(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild)

            RefreshPOChild()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub RefreshPOChild()
        Me.Qry607_02RFQChildTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild, Me.txtRFQNo.EditValue)

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            'Check if the Voucher is approved already
            If CheckIfRFQIsApproved(Me.txtRFQNo.EditValue) = True Then
                MessageBox.Show("RFQ is already approved, You cannot delete the Approved RFQ", "RFQ Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            If frm601_14RFQView.CheckIfRFQHasPO(Me.txtRFQNo.EditValue) = True Then
                MessageBox.Show("RFQ has related Purchase Order Issued, You cannot delete the RFQ.", "RFQ has Purchase Order Issued", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the RFQ from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtRFQNo.EditValue) = False Then
                    If DeleteRFQ(Me.txtRFQNo.EditValue) = True Then
                        MessageBox.Show("RFQ has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS RFQ", "IMS RFQ Ref No." & Me.txtRFQNo.EditValue & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogonUser & ".", Me.strLogonUser, Me.txtRFQNo.EditValue)


                        'Refresh the datagrid
                        RefreshRFQMasterDataGrid()

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

    Private Function CheckIfRFQIsApproved(ByVal RFQNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select RFQNo from tbl607_01RFQMaster where (RFQNo = '" & RFQNo & "') and (Isnull(IsApproved,0) = 1 )"

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

    Private Function DeleteRFQ(ByVal RFQNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl607_01RFQMaster WHERE RFQNo   = '" & RFQNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl607_02RFQChild WHERE RFQNo   = '" & RFQNo & "'"
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


    Public Sub DisableApprovedVoucherEditing(ByVal RFQNo As String)
        'Disable access if the voucher is already approved.
        'Get the IsVoucherIsApproved
        If CheckIfRFQIsApproved(Me.txtRFQNo.EditValue) = True Then
            Me.btnAddLineItem.Enabled = False
            Me.btnSave.Enabled = False
            Me.btnSaveAndClose.Enabled = False
            Me.btnAddNewLineItem.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnVerify.Enabled = False
            Me.btnApprove.Enabled = False
            Me.gcInvoiceChild.Enabled = False

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
            frm30110SupplierMaster.isExecutedFrom_frm601_13RFQMaster = True

        ElseIf e.Button.Index = 1 Then

            If CheckIfNull(Me.txtSupplierName.EditValue) = True Or Me.txtSupplierName.Text = String.Empty Then
                MessageBox.Show("Please select the Supplier to edit.", "Select Supplier to edit", MessageBoxButtons.OK)
            Else
                Dim frm30110SupplierMaster As New frm30110SupplierMaster
                frm30110SupplierMaster.ObjForm = Me

                frm30110SupplierMaster.isExecutedFrom_frm601_13RFQMaster = True

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

                Me.txtClientRefName.EditValue = Me.Dsfrm601_13RFQEdit1.Tables("tbl30199_SupplierMaster").Rows.Find(Me.txtSupplierName.EditValue).Item("ContactPerson")
                Me.txtClientContactNo.EditValue = Me.Dsfrm601_13RFQEdit1.Tables("tbl30199_SupplierMaster").Rows.Find(Me.txtSupplierName.EditValue).Item("ContactPhone1")
                Me.txtClientEmail.EditValue = Me.Dsfrm601_13RFQEdit1.Tables("tbl30199_SupplierMaster").Rows.Find(Me.txtSupplierName.EditValue).Item("ContactEmail")
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub txtSignatory_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSignatory.ButtonClick
    '    If e.Button.Index = 1 Then
    '        Dim frm40115QuotationSignatories As New frm40115QuotationSignatories
    '        frm40115QuotationSignatories.ObjForm = Me
    '        frm40115QuotationSignatories.Show()
    '        frm40115QuotationSignatories.txtSignatoryName.Focus()
    '        frm40115QuotationSignatories.isExecutedFrom_frm601_05DeliveryNoteEdit = True
    '    End If
    'End Sub

    'Private Sub repoDetailedDescription_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoDetailedDescription.ButtonClick
    '    If e.Button.Index = 1 Then
    '        Try
    '            Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
    '            frm20163VATGoodsAndServicesEdit.ObjForm = Me

    '            frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Save"
    '            frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_01QuotationEdit = True

    '            frm20163VATGoodsAndServicesEdit.Show()
    '            frm20163VATGoodsAndServicesEdit.FillDataSetforNew()
    '            frm20163VATGoodsAndServicesEdit.strLogonUser = Me.strLogonUser
    '            frm20163VATGoodsAndServicesEdit.intLogOnUserID = Me.intLogOnUserID
    '            frm20163VATGoodsAndServicesEdit.intLogOnUserLevel = Me.intLogOnUserLevel
    '            frm20163VATGoodsAndServicesEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
    '            frm20163VATGoodsAndServicesEdit.txtUnitIssue.EditValue = 1
    '            frm20163VATGoodsAndServicesEdit.txtSellingRate.EditValue = 1

    '            frm20163VATGoodsAndServicesEdit.txtGSDescription.Focus()

    '        Catch ex As Exception
    '            MessageBox.Show("Error on Adding Goods & Services Item, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try

    '    ElseIf e.Button.Index = 2 Then
    '        Try
    '            Dim strItemCode As String = Me.gvInvoiceChild.GetRowCellValue(Me.gvInvoiceChild.FocusedRowHandle, "ItemCode")

    '            If CheckIfNull(strItemCode) = False Then

    '                Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
    '                frm20163VATGoodsAndServicesEdit.ObjForm = Me
    '                frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_01QuotationEdit = True

    '                frm20163VATGoodsAndServicesEdit.strLogonUser = Me.strLogonUser
    '                frm20163VATGoodsAndServicesEdit.intLogOnUserID = Me.intLogOnUserID
    '                frm20163VATGoodsAndServicesEdit.intLogOnUserLevel = Me.intLogOnUserLevel
    '                frm20163VATGoodsAndServicesEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
    '                frm20163VATGoodsAndServicesEdit.txtGSCode.EditValue = strItemCode
    '                frm20163VATGoodsAndServicesEdit.Show()
    '                frm20163VATGoodsAndServicesEdit.FillDataSetforEditing(strItemCode)

    '                frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Update"
    '                frm20163VATGoodsAndServicesEdit.txtGSDescription.Focus()

    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    'Private Sub gvInvoiceChild_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvInvoiceChild.CellValueChanged
    '    Try
    '        'Dim DescriptionCaptionWtArabic As String = "Description " & Global.Microsoft.VisualBasic.ChrW(10) & "// وصف السلعة"

    '        If e.Column.Caption = "Description" Then
    '            Dim SelectedValue As String = e.Value
    '            GetGSDetails(SelectedValue)
    '            gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("UnitRateMethod"), gGSStockUnitMethod)
    '            UpdateInvoiceChild()

    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub btnTerms_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTerms.ItemClick
    '    If CheckIfNull(Me.txtQuotationNo.EditValue) = False Then
    '        Dim frm40107QuoteSelected As New frm40107QuoteSelected
    '        frm40107QuoteSelected.Show()
    '        frm40107QuoteSelected.SelectedQuoteNo = Me.txtQuotationNo.EditValue
    '        frm40107QuoteSelected.FilterSelectedQuoteNo(Me.txtQuotationNo.EditValue)
    '        frm40107QuoteSelected.selectedQuoteType = "Sales"

    '    End If
    'End Sub

    Private Sub frm601_13RFQMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm601_13RFQEdit.tbl20101SalesPersonMaster' table. You can move, or remove it, as needed.
        Me.Tbl20101SalesPersonMasterTableAdapter.Fill(Me.Dsfrm601_13RFQEdit.tbl20101SalesPersonMaster)
        'TODO: This line of code loads data into the 'Dsfrm601_13RFQEdit3.qry700_02ProjectsViewMaster' table. You can move, or remove it, as needed.
        Me.Qry700_02ProjectsViewMasterTableAdapter.Fill(Me.Dsfrm601_13RFQEdit3.qry700_02ProjectsViewMaster)

        Me.Tbl600_08InventoryMasterGroupTableAdapter.Fill(Me.Dsfrm601_13RFQEdit2.tbl600_08InventoryMasterGroup)
        Me.Tbl30199_SupplierMasterTableAdapter.Fill(Me.Dsfrm601_13RFQEdit1.tbl30199_SupplierMaster)
        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm601_13RFQEdit.tbl40111PropertyUnitCodes)

        Me.Tbl901CompanyDetailsTableAdapter.Fill(Me.Dsfrm601_13RFQEdit.tbl901CompanyDetails)
        Me.Tbl90104DocumentSignatoriesTableAdapter.Fill(Me.Dsfrm601_13RFQEdit.tbl90104DocumentSignatories)

        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm601_13RFQEdit.tbl20164GoodsAndServicesMaster)
        Else
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.FillByInventoryMasterGroupID(Me.Dsfrm601_13RFQEdit.tbl20164GoodsAndServicesMaster, Me.intLogOnInventoryAccessLevel)
        End If


        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_13RFQMaster", Me.gvInvoiceChild)

        Me.ImplementAccess(Me.intLogOnUserID)

        'Populate Custom Reports Tab
        Me.PopulateCustomReportButtons(Me.CustomReportFormNo)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colLineTotalAfterDisc.DisplayFormat.FormatString = "{0:#,0.000}"

        End If
    End Sub

    Public Sub ImplementAccess(ByVal UserID As Integer)
        If GetUserAccess(UserID, "frm601_13RFQMaster_FullAccess") = True Then

            Me.btnResetLayout.Enabled = True
            Me.btnSetDefaultLayout.Enabled = True
            Me.btnMoveUp.Enabled = True
            Me.btnMoveDown.Enabled = True
            Me.btnSave.Enabled = True
            Me.btnSaveAndClose.Enabled = True
            Me.btnPreviewRFQ.Enabled = True
            Me.btnDelete.Enabled = True
            Me.btnAddNewLineItem.Enabled = True
            Me.btnBack.Enabled = True
            Me.btnSubmit.Enabled = True
            Me.btnVerify.Enabled = True
            Me.btnApprove.Enabled = True
            Me.btnCreatePO.Enabled = True
            Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = True
            Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = True

            Me.txtSignatory.Properties.Buttons.Item(1).Enabled = True

            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(3).Enabled = True

        Else
            Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnResetLayout")
            Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnSetDefaultLayout")
            Me.btnMoveUp.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnMoveUp")
            Me.btnMoveDown.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnMoveDown")
            Me.btnSave.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnSave")
            Me.btnSaveAndClose.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnSaveAndClose")
            Me.btnPreviewRFQ.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnPreviewRFQ")
            Me.btnDelete.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnDelete")
            Me.btnAddNewLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnAddNewLineItem")
            Me.btnBack.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnBack")
            Me.btnSubmit.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnSubmit")
            Me.btnVerify.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnVerify")
            Me.btnApprove.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnApprove")
            Me.btnCreatePO.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_btnCreatePO")
            Me.txtSupplierName.Properties.Buttons.Item(2).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_txtSupplierName.Properties.Buttons.Item(2)")
            Me.txtSupplierName.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_txtSupplierName.Properties.Buttons.Item(1)")
            Me.txtSignatory.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_txtSignatory.Properties.Buttons.Item(1)")
            Me.repoDetailedDescription.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_repoDetailedDescription.Properties.Buttons.Item(1)")
            Me.repoDetailedDescription.Buttons.Item(2).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_repoDetailedDescription.Properties.Buttons.Item(2)")
            Me.repoDetailedDescription.Buttons.Item(3).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_13RFQMaster_repoDetailedDescription.Properties.Buttons.Item(3)")

        End If
    End Sub

    Private Sub btnPreviewRequest_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewRFQ.ItemClick
        Try
            'Save before print
            Me.SaveAll(False)

            Dim rpt1 As New rpt601_05RfqFormat01
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = "IMS-RFQ-01"
            Dim frm1 As New frm999_04ReportPreviewIMS_RFQ

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            rpt1.Qry607_05RFQReportTableAdapter.FillByRFQNo(rpt1.DsRpt601_05RfqFormat011.qry607_05RFQReport, Me.txtRFQNo.EditValue)

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

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "RFQ_No_" & Me.txtRFQNo.EditValue & "_" & Me.txtSupplierName.Text
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

#Region "Create PO"

    Private Sub btnCreatePO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreatePO.ItemClick

        Try
            'Check if the RFQ has PO

            If frm601_14RFQView.CheckIfRFQHasPO(Me.txtRFQNo.EditValue) = True Then
                MessageBox.Show("RFQ has already been converted to PO, Please review the Purchase Order.", "RFQ has converted to PO", MessageBoxButtons.OK)
                Exit Sub

            End If


            DialogResult = MessageBox.Show("You are about to create new Purchase Order." & vbCrLf & "Are you Sure want to continue creating Purchase Order?", "Confirm creating Purchase Order.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtRFQNo.EditValue) = False Then

                    'Get New PO Number
                    GetCompanyDetails(1)
                    GetCompanyDetails02(1)

                    Dim NewPONo As String

                    If Me.intLogOnInventoryAccessLevel = 99 Then
                        NewPONo = frm601_07PurchaseOrderEdit.GetNewPONo(gPurchaseOrderAbbrv, gInvoiceYearDigits, Date.Now, gIsResetPOInYear, gNoOfDigitsToInventoryPO, gIsUseNewSequencePONoForGroup)
                    Else
                        Dim PONumberSeqForGroup As String = GetPONoSequenceForGroup(Me.intLogOnInventoryAccessLevel)
                        NewPONo = frm601_07PurchaseOrderEdit.GetNewPONo(PONumberSeqForGroup, gInvoiceYearDigits, Date.Now, gIsResetPOInYear, gNoOfDigitsToInventoryPO, gIsUseNewSequencePONoForGroup)
                    End If

                    Me.CreatePO(NewPONo, Me.txtRFQNo.EditValue, Me.strLogonUser)
                    'Set the status to Purchase Order Issued
                    frm601_12PurchaseRequestView.UpdateStatusOfMPR(Me.txtMPRNo.EditValue, 6)

                    Me.OpenPO(NewPONo)
                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub CreatePO(ByVal PONo As String, ByVal RFQNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_02InsertToPOfromRFQ"
            Dim paramPONo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@PONo", SqlDbType.VarChar)
            Dim paramRFQNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@RFQNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramPONo.Value = PONo
            paramRFQNo.Value = RFQNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Purchase Order is created successfully,", "PO created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("PO Creation failed, Please try again", "RFQ Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub OpenPO(ByVal PONo As String)
        If CheckIfNull(PONo) = False Then
            Dim frm601_07PurchaseOrderEdit As New frm601_07PurchaseOrderEdit
            frm601_07PurchaseOrderEdit.ObjForm = Me
            frm601_07PurchaseOrderEdit.txtPONo.Enabled = False
            frm601_07PurchaseOrderEdit.btnSave.Caption = "Update"


            frm601_07PurchaseOrderEdit.strLogonUser = Me.strLogonUser
            frm601_07PurchaseOrderEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_07PurchaseOrderEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_07PurchaseOrderEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_07PurchaseOrderEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_07PurchaseOrderEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_07PurchaseOrderEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_07PurchaseOrderEdit.isExecutedFrom_frm601_13RFQMaster = True

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_07PurchaseOrderEdit.txtSalesPerson.Enabled = True
            Else
                frm601_07PurchaseOrderEdit.txtSalesPerson.Enabled = False
            End If

            frm601_07PurchaseOrderEdit.Show()

            frm601_07PurchaseOrderEdit.RetrievePOMaster(PONo)

            If GetPurchaseOrderCurrency(PONo) = 1 Then
                frm601_07PurchaseOrderEdit.IsVisibleOC = False
            Else
                frm601_07PurchaseOrderEdit.IsVisibleOC = True
            End If
            frm601_07PurchaseOrderEdit.SwitchColumns()
            frm601_07PurchaseOrderEdit.txtPONo.Enabled = False
            frm601_07PurchaseOrderEdit.DisableApprovedVoucherEditing(PONo)
            frm601_07PurchaseOrderEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

            frm601_07PurchaseOrderEdit.ImplementAccess(Me.intLogOnUserID)
        End If
    End Sub


#End Region


    Private Sub cmdEditContacts_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles cmdEditContacts.OpenLink
        Try
            Dim strSupplierCode As String = Me.txtSupplierName.EditValue

            If CheckIfNull(strSupplierCode) = False Then

                Dim frm600_04SupplierContactList As New frm600_04SupplierContactList
                frm600_04SupplierContactList.ObjForm = Me
                frm600_04SupplierContactList.isExecutedFrom_frm601_13RFQMaster = True

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

    Private Sub txtSignatory_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSignatory.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40115QuotationSignatories As New frm40115QuotationSignatories
            frm40115QuotationSignatories.ObjForm = Me
            frm40115QuotationSignatories.Show()
            frm40115QuotationSignatories.txtSignatoryName.Focus()
            frm40115QuotationSignatories.isExecutedFrom_frm601_13RFQMaster = True
        End If
    End Sub

    Private Sub repoDetailedDescription_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoDetailedDescription.ButtonClick
        If e.Button.Index = 1 Then
            Try
                Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                frm20163VATGoodsAndServicesEdit.ObjForm = Me

                frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Save"
                frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_13RFQMaster = True

                frm20163VATGoodsAndServicesEdit.Show()
                frm20163VATGoodsAndServicesEdit.FillDataSetforNew()
                frm20163VATGoodsAndServicesEdit.strLogonUser = Me.strLogonUser
                frm20163VATGoodsAndServicesEdit.intLogOnUserID = Me.intLogOnUserID
                frm20163VATGoodsAndServicesEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                frm20163VATGoodsAndServicesEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm20163VATGoodsAndServicesEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel

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
                    frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_13RFQMaster = True

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
                    frm600_01InventoryStockEdit.isExecutedFrom_frm601_13RFQMaster = True

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
                    frm600_01InventoryStockEdit.txtItemName.Focus()


                End If

            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        GetReportDetails("IMS-RFQ-01")
        Me.txtSubject.EditValue = gReportSubject
    End Sub

    Private Sub cmdAddIntro_Click(sender As Object, e As EventArgs) Handles cmdAddIntro.Click
        GetReportDetails("IMS-RFQ-01")
        Me.txtQuoteIntro.Text = gReportIntroduction
    End Sub

    Private Sub txtAddText_Click(sender As Object, e As EventArgs) Handles txtAddText.Click
        GetReportDetails("IMS-RFQ-01")
        Me.txtQuoteSummary.Text = gReportSummary
    End Sub


    Private Sub btnDeleteAllSelectedLineItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteAllSelectedLineItems.ItemClick

        DialogResult = MessageBox.Show("You are about to delete all the Selected RFQ Line Item." & vbCrLf & "Are you Sure want to delete this RFQ Details?", "Delete RFQ Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Dim view As GridView = gvInvoiceChild
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    Dim ChosenRFQSlNo As Integer = view.GetRowCellValue(row, view.Columns("RFQChildSlNo"))
                    Me.DeleteRFQChild(ChosenRFQSlNo, False)

                Next
            End If
            'Refresh the datagrid
            'fill child details in the datagrid
            Me.Qry607_02RFQChildTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild, Me.txtRFQNo.EditValue)

        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub

        End If
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_13RFQMaster"

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
            Dim formID As String = "frm601_13RFQMaster"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvInvoiceChild))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvInvoiceChild))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSetAllAsSelectedForPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetAllAsSelectedForPO.ItemClick
        DialogResult = MessageBox.Show("You are about to set all the Selected Items to Create PO." & vbCrLf & "Are you Sure want to set all this Items for PO?", "Select for PO.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Dim view As GridView = gvInvoiceChild
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    Dim ChosenRFQSlNo As Integer = view.GetRowCellValue(row, view.Columns("RFQChildSlNo"))
                    'Me.DeleteRFQChild(ChosenRFQSlNo, False)
                    view.SetRowCellValue(row, view.Columns("IsWonForPO"), 1)
                    view.SetRowCellValue(row, view.Columns("IsWonUpdatedBy"), Me.strLogonUser)
                    view.SetRowCellValue(row, view.Columns("IsWonUpdatedDate"), Date.Now)
                Next
            End If
            'Refresh the datagrid
            'fill child details in the datagrid
            'Me.Qry607_02RFQChildTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild, Me.txtRFQNo.EditValue)
            Try
                'Update the Data in the Child
                Me.Qry60702RFQChildBindingSource.EndEdit()
                Me.Qry607_02RFQChildTableAdapter.Update(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild)
                Me.Qry607_02RFQChildTableAdapter.FillByRFQNo(Me.Dsfrm601_13RFQEdit.qry607_02RFQChild, Me.txtRFQNo.EditValue)

            Catch ex As Exception

            End Try


        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub

        End If
    End Sub

    Private Sub btnSubmit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSubmit.ItemClick
        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_13RFQMaster_btnSubmit") = False Then
            MessageBox.Show("You have no Access rights to Submit the RFQ. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.SubmitMPR(Me.txtRFQNo.EditValue)

        ''Check whether Alert Activation for Submission to Verification is set then
        ''Make an Alert to the Verifier
        'GetAlertSettings("SYS-20106-001")
        'If gIsAlertActivated = True Then
        '    'Add an alert
        '    Dim AlertMessage2 As String = ""
        '    AlertMessage2 = Me.strLogonUser & " submitted a claim for your verification."
        '    InsertSystemAlert(GetNewAlertCode("SYS"), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New Expenses Claim is ready to verify.")

        'End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshRFQMasterDataGrid()
    End Sub


    Private Sub SubmitMPR(ByVal MPRNo As String)
        If CheckIfNull(MPRNo) = False Then

            Me.Validate()

            Dim view As DataRowView = DirectCast(Me.Tbl60701RFQMasterBindingSource.Current, DataRowView)
            view.Row("IsSubmitted") = True
            view.Row("SubmittedBy") = Me.strLogonUser
            view.Row("SubmittedOn") = Date.Now

            Me.Tbl60701RFQMasterBindingSource.EndEdit()
            Me.Tbl607_01RFQMasterTableAdapter.Update(Me.Dsfrm601_13RFQEdit.tbl607_01RFQMaster)

            MessageBox.Show("RFQ has been submitted for Approval.", "Submit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnVerify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerify.ItemClick
        Me.SaveAll(False)

        ''Check if the request has any entry to submit
        'If GetClaimChildTotal(Me.txtClaimRefNo.EditValue) = 0 Then
        '    MessageBox.Show("Please check your Claim Request, no amount to submit the Claim.", "Claim Amount Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_13RFQMaster_btnVerify") = False Then
            MessageBox.Show("You have no Access rights to Verify the RFQ. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.VerifyMPR(Me.txtRFQNo.EditValue)

        ''Check whether Alert Activation for Submission to Verification is set then
        ''Make an Alert to the Verifier
        'GetAlertSettings("SYS-20106-001")
        'If gIsAlertActivated = True Then
        '    'Add an alert
        '    Dim AlertMessage2 As String = ""
        '    AlertMessage2 = Me.strLogonUser & " submitted a claim for your verification."
        '    InsertSystemAlert(GetNewAlertCode("SYS"), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New Expenses Claim is ready to verify.")

        'End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshRFQMasterDataGrid()
    End Sub

    Private Sub VerifyMPR(ByVal MPRNo As String)
        If CheckIfNull(MPRNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60701RFQMasterBindingSource.Current, DataRowView)
            view.Row("IsVerified") = True
            view.Row("VerifiedBy") = Me.strLogonUser
            view.Row("VerifiedOn") = Date.Now

            Me.Tbl60701RFQMasterBindingSource.EndEdit()
            Me.Tbl607_01RFQMasterTableAdapter.Update(Me.Dsfrm601_13RFQEdit.tbl607_01RFQMaster)

            MessageBox.Show("RFQ has been Verified and processed for Approval.", "Verify Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnApprove.ItemClick
        Me.SaveAll(False)

        ''Check if the request has any entry to submit
        'If GetClaimChildTotal(Me.txtClaimRefNo.EditValue) = 0 Then
        '    MessageBox.Show("Please check your Claim Request, no amount to submit the Claim.", "Claim Amount Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_13RFQMaster_btnApprove") = False Then
            MessageBox.Show("You have no Access rights to Approve the RFQ. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.ApproveMPR(Me.txtRFQNo.EditValue)

        ''Check whether Alert Activation for Submission to Verification is set then
        ''Make an Alert to the Verifier
        'GetAlertSettings("SYS-20106-001")
        'If gIsAlertActivated = True Then
        '    'Add an alert
        '    Dim AlertMessage2 As String = ""
        '    AlertMessage2 = Me.strLogonUser & " submitted a claim for your verification."
        '    InsertSystemAlert(GetNewAlertCode("SYS"), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New Expenses Claim is ready to verify.")

        'End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshRFQMasterDataGrid()
    End Sub

    Private Sub ApproveMPR(ByVal MPRNo As String)
        If CheckIfNull(MPRNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60701RFQMasterBindingSource.Current, DataRowView)
            view.Row("IsApproved") = True
            view.Row("ApprovedBy") = Me.strLogonUser
            view.Row("ApprovedOn") = Date.Now
            'Set the Status to 33 - Enquiry/Request Approved
            view.Row("PurchaseRequestStatusID") = 33

            Me.Tbl60701RFQMasterBindingSource.EndEdit()
            Me.Tbl607_01RFQMasterTableAdapter.Update(Me.Dsfrm601_13RFQEdit.tbl607_01RFQMaster)
            MessageBox.Show("Material Purchase Request has been Approved.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Disable All Controls
    Public Sub DisableAllControls()

        Me.btnMoveUp.Enabled = False
        Me.btnMoveDown.Enabled = False
        Me.btnResetLayout.Enabled = False
        Me.btnSetDefaultLayout.Enabled = False

        Me.btnSave.Enabled = False
        Me.btnSaveAndClose.Enabled = False
        Me.btnPreviewRFQ.Enabled = True
        Me.btnDelete.Enabled = False
        Me.btnAddNewLineItem.Enabled = False
        Me.btnAddLineItem.Enabled = False
        Me.btnBack.Enabled = True

        Me.btnSubmit.Enabled = False
        Me.btnVerify.Enabled = False
        Me.btnApprove.Enabled = False

        Me.btnLineItem.Enabled = False

        Me.gcInvoiceChild.Enabled = False

        Me.txtRFQDate.Enabled = False
        Me.txtSupplierName.Enabled = False
        Me.txtMPRNo.Enabled = False
        Me.txtProject.Enabled = False
        Me.txtClientRefName.Enabled = False
        Me.txtClientContactNo.Enabled = False
        Me.txtSupplierQuoteNo.Enabled = False
        Me.txtSupplierQuoteDate.Enabled = False
        Me.txtClientEmail.Enabled = False
        Me.txtProjectCode.Enabled = False
        Me.txtSubject.Enabled = False
        Me.txtQuoteIntro.Enabled = False
        Me.txtQuoteSummary.Enabled = False
        Me.btnAddSubject.Enabled = False
        Me.cmdAddIntro.Enabled = False
        Me.txtAddText.Enabled = False
        Me.txtSignatory.Enabled = False
        Me.txtCompanyID.Enabled = False
        Me.txtInventoryGroupMaster.Enabled = False

        Me.txtSalesPerson.Enabled = False

    End Sub

    Private Sub btnDefaultSubject_Click(sender As Object, e As EventArgs) Handles btnDefaultSubject.Click
        'UpdateReportDefaults
        Try
            If UpdateReportDefaults(Me.txtSubject.EditValue, "ReportSubject", "IMS-RFQ-%") Then
                MessageBox.Show("Quotation Request Subject has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefaultIntro_Click(sender As Object, e As EventArgs) Handles btnDefaultIntro.Click
        Try
            If UpdateReportDefaults(Me.txtQuoteIntro.EditValue, "ReportIntroduction", "IMS-RFQ-%") Then
                MessageBox.Show("Quotation Request Introduction has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnDefaultSummary_Click(sender As Object, e As EventArgs) Handles btnDefaultSummary.Click
        Try
            If UpdateReportDefaults(Me.txtQuoteSummary.EditValue, "ReportSummary", "IMS-RFQ-%") Then
                MessageBox.Show("Quotation Request Summary has been set as default.", "Set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub




#Region "Populate Custom Report Buttons"
    'Change this code for other forms.. 
    Dim CustomReportFormNo As Integer = 6

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

            Dim rpt1 As New rpt601_05RfqFormat01
            '---------------------------------------
            'NEW REPORT DESIGNED BY CLIENT STARTS HERE
            'This is for Customer Desinged Report
            'Check this is Customer Designed Report then.. run this code
            '----------------------------------------
            Dim ReportCode As String = ReportNo
            Dim frm1 As New frm999_04ReportPreviewIMS_RFQ

            If CheckIfReportIsCustomDesigned(ReportCode) = True Then
                Dim text As String = GetReportXmlLayout(ReportCode)
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                rpt1.LoadLayoutFromXml(stream)

            End If

            '---------------------------------------

            rpt1.Qry607_05RFQReportTableAdapter.FillByRFQNo(rpt1.DsRpt601_05RfqFormat011.qry607_05RFQReport, Me.txtRFQNo.EditValue)

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

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "RFQ_No_" & Me.txtRFQNo.EditValue & "_" & Me.txtSupplierName.Text
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

    Private Sub txtRFQDate_Leave(sender As Object, e As EventArgs) Handles txtRFQDate.Leave
        'DATE BLOCKING
        GetCompanyDetails02(1)
        If gIsDateLockingEnabled = True Then
            If CheckIfNull(Me.txtRFQDate.EditValue) = True Then
                Me.txtRFQDate.EditValue = Date.Today()
            End If

            If CheckIfDateBeenLocked("IMS_RFQ", Me.txtRFQDate.EditValue) = True Then
                MessageBox.Show("This RFQ Entry date has been blocked." & vbCrLf & "Please review your entry date.", "Entry Date is Blocked", MessageBoxButtons.OK)
                Me.txtRFQDate.EditValue = Me.txtRFQDate.OldEditValue
                Me.txtRFQDate.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnUseItemDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60702RFQChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.Text = GetGSCodeDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUseItemDetailedDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDetailedDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60702RFQChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.txtDetailedDescription.Text = GetGSCodeDetailedDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub


#End Region
End Class

