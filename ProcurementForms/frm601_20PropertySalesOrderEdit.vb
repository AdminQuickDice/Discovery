Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraReports.UI

Imports System.Drawing
Imports DevExpress.XtraPrinting.Drawing
Public Class frm601_20PropertySalesOrderEdit
    Public isBeingUpdated As Boolean = False
    Public isBeingNew As Boolean = False
    Public isControlsModified As Boolean

    Public ObjForm As Object
    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnCompanyID As Integer

    Dim SelectedSalesOrderChildSlNo As Integer

    Public isExecutedFrom_frm40119PropertySalesOrderMaster As Boolean = False
    Public isExecutedFrom_frm40104PropertyQuoteView As Boolean = False

    Public CreatedNewSalesOrderNo As String



#Region "Ordering Code"
    Private Const OrderFieldName As String = "LineOrderNo"

    Private downHitInfo As GridHitInfo = Nothing

    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Dim view As GridView = gvSalesOrderChild
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
        Dim view As GridView = gvSalesOrderChild
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
            End If

        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageQuoteDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
            End If
        Next

    End Sub

    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtSalesOrderNo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtSalesOrderNo, "Sales Order Number Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtSalesOrderNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtSalesOrderDate.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtSalesOrderDate, "Sales Order Date must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtSalesOrderDate, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtClientName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtClientName, "Client must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtClientName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

    End Sub
    Private Sub frm601_20PropertySalesOrderEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Tbl90104DocumentSignatoriesTableAdapter.Fill(Me.Dsfrm40120PropertySalesOrderEdit.tbl90104DocumentSignatories)
        Me.Tbl20101SalesPersonMasterTableAdapter.Fill(Me.Dsfrm40120PropertySalesOrderEdit1.tbl20101SalesPersonMaster)
        Me.Tbl901CompanyDetailsTableAdapter.Fill(Me.Dsfrm40120PropertySalesOrderEdit.tbl901CompanyDetails)
        Me.Tbl30101ClientMasterTableAdapter.Fill(Me.Dsfrm40120PropertySalesOrderEdit.tbl30101ClientMaster)
        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm40120PropertySalesOrderEdit.tbl40111PropertyUnitCodes)
        Me.Tbl40110PropertyTypesTableAdapter.Fill(Me.Dsfrm40120PropertySalesOrderEdit.tbl40110PropertyTypes)

        'Implement Access
        Me.ImplementAccessLevel()

        FillCombobox()

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit", Me.gvSalesOrderChild)

    End Sub

    Public Sub ImplementAccessLevel()
        Try
            If GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_FullAccess") = True Then
                Me.btnSave.Enabled = True
                Me.btnSaveAndClose.Enabled = True
                Me.btnDelete.Enabled = True
                Me.btnPrintSalesOrder.Enabled = True
                Me.btnPrintSalesOrderYardCopy.Enabled = True
                Me.btnAddNewLineItem.Enabled = True
                Me.btnBack.Enabled = True
                Me.btnVerify.Enabled = True
                Me.btnApprove.Enabled = True
                Me.btnAttachFile.Enabled = True
                Me.gcSalesOrderChild.Enabled = True
                Me.pageQuoteDetails.Enabled = True
                Me.pageSignatories.Enabled = True
                Me.pageDeliveryDetails.Enabled = True

                'Edit
                Me.txtClientName.Properties.Buttons.Item(1).Enabled = True
                'Add
                Me.txtClientName.Properties.Buttons.Item(2).Enabled = True
                Me.txtSalesPerson.Properties.Buttons.Item(1).Enabled = True

            Else
                Me.btnSave.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnSave")
                Me.btnSaveAndClose.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnSaveAndClose")
                Me.btnDelete.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnDelete")
                Me.btnPrintSalesOrder.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnPrintSalesOrder")
                Me.btnPrintSalesOrderYardCopy.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnPrintSalesOrderYardCopy")
                Me.btnAddNewLineItem.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnAddNewLineItem")
                Me.btnBack.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnBack")
                Me.btnVerify.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnVerify")
                Me.btnApprove.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnApprove")
                Me.btnAttachFile.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_btnAttachFile")
                Me.gcSalesOrderChild.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_gcSalesOrderChild")
                Me.pageQuoteDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_pageQuoteDetails")
                Me.pageSignatories.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_pageSignatories")
                Me.pageDeliveryDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_pageDeliveryDetails")

                'Edit
                Me.txtClientName.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_txtClientNameEdit")
                'Add
                Me.txtClientName.Properties.Buttons.Item(2).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_txtClientNameAdd")
                Me.txtSalesPerson.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_20PropertySalesOrderEdit_txtSalesPerson")

            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub RetrieveSalesOrderMaster(ByVal SalesOrderNo As String)
        Try
            If CheckIfNull(SalesOrderNo) = False Then
                'fill master details
                Me.Tbl40129_PropertySalesOrderMasterTableAdapter.FillBySalesOrderNo(Me.Dsfrm40120PropertySalesOrderEdit.tbl40129_PropertySalesOrderMaster, SalesOrderNo)

                'fill child details in the datagrid
                Me.Qry402_02PropertySalesOrderChildTableAdapter.FillBySalesOrderNo(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild, SalesOrderNo)


            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Sales Order Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateSalesOrderMaster(ByVal SalesOrderNo As String, ByVal WithMessage As Boolean)
        If CheckIfNull(SalesOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl40129PropertySalesOrderMasterBindingSource.Current, DataRowView)
            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            Me.Tbl40129PropertySalesOrderMasterBindingSource.EndEdit()
            Me.Tbl40129_PropertySalesOrderMasterTableAdapter.Update(Me.Dsfrm40120PropertySalesOrderEdit.tbl40129_PropertySalesOrderMaster)

            If WithMessage = True Then
                MessageBox.Show("Sales Order  Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SaveNewSalesOrderMaster(ByVal SalesOrderNo As String)
        If CheckIfNull(SalesOrderNo) = False Then
            If isBeingNew = True Then
                Dim view As DataRowView = DirectCast(Me.Tbl40129PropertySalesOrderMasterBindingSource.Current, DataRowView)
                view.Row("AddedBy") = Me.strLogonUser
                view.Row("AddedOn") = Date.Now
                Me.Validate()

                Me.Tbl40129PropertySalesOrderMasterBindingSource.EndEdit()
                Me.Tbl40129_PropertySalesOrderMasterTableAdapter.Update(Me.Dsfrm40120PropertySalesOrderEdit.tbl40129_PropertySalesOrderMaster)
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
            UpdateSalesOrderMaster(Me.txtSalesOrderNo.EditValue, WithMessage)
            Me.btnSave.Caption = "Update"

        ElseIf Me.btnSave.Caption = "Save" Then
            If Me.isBeingNew = True Then
                SaveNewSalesOrderMaster(Me.txtSalesOrderNo.EditValue)
                Me.btnSave.Caption = "Update"
            End If
        End If

        Try

            'Update the Data in the Child
            Me.Qry40202PropertySalesOrderChildBindingSource.EndEdit()
            Me.Qry402_02PropertySalesOrderChildTableAdapter.Update(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild)
            Me.Qry402_02PropertySalesOrderChildTableAdapter.FillBySalesOrderNo(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild, Me.txtSalesOrderNo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshSalesOrderMasterDataGrid()
    End Sub

    Private Sub RefreshSalesOrderMasterDataGrid()
        If isExecutedFrom_frm40119PropertySalesOrderMaster = True Then
            Try
                CType(ObjForm, frm40119PropertySalesOrderMaster).RetrieveVoucher(CType(ObjForm, frm40119PropertySalesOrderMaster).txtStartDate.EditValue, CType(ObjForm, frm40119PropertySalesOrderMaster).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm40119PropertySalesOrderMaster).gvAdvBandedQuotationView, "SalesOrderNo", Me.txtSalesOrderNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Sales Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        '
        If isExecutedFrom_frm40104PropertyQuoteView = True Then
            Try
                CType(ObjForm, frm40104PropertyQuoteView).RetrieveVoucher(CType(ObjForm, frm40104PropertyQuoteView).txtStartDate.EditValue, CType(ObjForm, frm40104PropertyQuoteView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm40104PropertyQuoteView).AdvBandedGridView1, "QuoteNo", Me.txtQuotationNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Quotation Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.ItemClick
        If isControlsModified = True Then
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("Sales Order Details have been edited, would you like to save changes?", "Save Changes?", MessageBoxButtons.YesNoCancel)

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

    Public Function GetNewSalesOrderNo(ByVal SalesOrderAbbr As String, ByVal YearInDigit As Integer, ByVal SalesOrderDate As Date, ByVal IsResetByYear As Boolean, ByVal NoOfDigits As Integer) As String
        'Public Function GetNewSalesOrderNo(ByVal SalesOrderAbbr As String, ByVal YearInDigit As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            If IsResetByYear = True Then
                SqlCommand1.CommandText = "select max(cast(right(SalesOrderNo, " & NoOfDigits & ") as int)) from tbl40129_PropertySalesOrderMaster where SalesOrderNo like '" & SalesOrderAbbr & "%' AND Year(SalesOrderDate) = '" & Year(SalesOrderDate).ToString & "'"
            Else
                SqlCommand1.CommandText = "select max(cast(right(SalesOrderNo, " & NoOfDigits & ") as int)) from tbl40129_PropertySalesOrderMaster WHERE SalesOrderNo like '" & SalesOrderAbbr & "%'"
            End If

            'SqlCommand1.CommandText = "select max(cast(right(SalesOrderNo,4) as int)) from tbl40129_PropertySalesOrderMaster"

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
            strNewQuotationNo = SalesOrderAbbr & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException

            Dim strYear As String = Year(SalesOrderDate).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = "0000001"
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)

            strNewQuotationNo = SalesOrderAbbr & strYear & "-" & strNewQuotationNo
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    'Saving and updating codes
    Public Sub NewSalesOrderMaster(ByVal SalesOrderNo As String)
        Try
            If CheckIfNull(SalesOrderNo) = False Then
                Me.Tbl40129PropertySalesOrderMasterBindingSource.AddNew()
                Me.txtSalesOrderNo.EditValue = SalesOrderNo
                isBeingUpdated = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Sales Order", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddNewLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewLineItem.ItemClick

        Try
            If CheckIfNull(Me.txtSalesOrderNo.EditValue) = False Then
                If Me.btnSave.Caption = "Save" Then
                    SaveNewSalesOrderMaster(Me.txtSalesOrderNo.EditValue)
                    Me.btnSave.Caption = "Update"
                End If

                Me.AddNewChild()
                Me.Validate()
                Me.Qry40202PropertySalesOrderChildBindingSource.EndEdit()
                Me.Qry402_02PropertySalesOrderChildTableAdapter.Update(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild)

                Me.Qry402_02PropertySalesOrderChildTableAdapter.FillBySalesOrderNo(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild, Me.txtSalesOrderNo.EditValue)

                Me.gvSalesOrderChild.MoveLast()
                Me.gvSalesOrderChild.FocusedColumn = Me.gvSalesOrderChild.Columns("PropertyTypeID")
                Me.gvSalesOrderChild.ShowEditor()

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Sales Order Line Item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm40120PropertySalesOrderEdit.Tables("qry402_02PropertySalesOrderChild")
            dr = dt.NewRow()
            dr("SalesOrderChildID") = 1
            dr("SalesOrderNo") = Me.txtSalesOrderNo.EditValue
            dr("QuotedQuantity") = 1
            dr("LineOrderNo") = GetNewSalesOrderLineItemNo(Me.txtSalesOrderNo.EditValue)
            dt.Rows.Add(dr)
            Me.Qry402_02PropertySalesOrderChildTableAdapter.Update(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Sales Order Line Item, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewSalesOrderLineItemNo(ByVal strSalesOrderNo As String) As Integer
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Max(LineOrderNo) from tbl40130_PropertySalesOrderChild where SalesOrderNo = '" & strSalesOrderNo & "'"
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

    'Private Sub cmdStockItemDesc_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles cmdStockItemDesc.OpenLink
    '    Try
    '        Dim view As DataRowView = DirectCast(Me.Qry40202PropertySalesOrderChildBindingSource.Current, DataRowView)
    '        Dim SelectedPropertyTypeID As Integer = 1
    '        SelectedPropertyTypeID = view.Row("PropertyTypeID")
    '        Me.txtDetailedDescription.EditValue = GetItemDescription(SelectedPropertyNo)

    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub DeleteSalesOrderChild(ByVal SalesOrderChildSlNo As Integer)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp40105DeletePropertySalesOrderChild"
            Dim paramPayrollInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderChildSlNo", SqlDbType.Int)

            paramPayrollInvoiceNo.Value = SalesOrderChildSlNo

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("Sales Order Line Item Deleted Successfully,", "Data Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Sales Order Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLineItem.ItemClick

        DialogResult = MessageBox.Show("You are about to delete Sales Order Line Item." & vbCrLf & "Are you Sure want to delete this Sales Order Details?", "Delete Invoice.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedSalesOrderChildSlNo) = False Then

                Me.DeleteSalesOrderChild(Me.SelectedSalesOrderChildSlNo)

                'Refresh the datagrid
                'fill child details in the datagrid
                Me.Qry402_02PropertySalesOrderChildTableAdapter.FillBySalesOrderNo(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild, Me.txtSalesOrderNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub gvInvoiceChild_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvSalesOrderChild.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedSalesOrderChildSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SalesOrderChildID"))
                Me.popInvoiceChild.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAddLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddLineItem.ItemClick
        If CheckIfNull(Me.txtSalesOrderNo.EditValue) = False Then
            Me.AddNewChild()
            Me.Validate()
            Me.Qry40202PropertySalesOrderChildBindingSource.EndEdit()
            Me.Qry402_02PropertySalesOrderChildTableAdapter.Update(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild)

            Me.Qry402_02PropertySalesOrderChildTableAdapter.FillBySalesOrderNo(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild, Me.txtSalesOrderNo.EditValue)
        End If
    End Sub

    Public Sub UpdateInvoiceChild()
        Try

            Me.Validate()
            Me.Qry40202PropertySalesOrderChildBindingSource.EndEdit()
            Me.Qry402_02PropertySalesOrderChildTableAdapter.Update(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild)

            'RefreshInvoiceChild()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub RefreshInvoiceChild()
        Me.Qry402_02PropertySalesOrderChildTableAdapter.FillBySalesOrderNo(Me.Dsfrm40120PropertySalesOrderEdit.qry402_02PropertySalesOrderChild, Me.txtSalesOrderNo.EditValue)

        'GetWorkHours()

    End Sub

    Private Sub gvWorkSheet_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvSalesOrderChild.RowUpdated
        'UpdateqvoiceChild()

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            'Check if the Voucher is approved already
            If CheckIfSalesOrderIsApproved(Me.txtSalesOrderNo.EditValue) = True Then
                MessageBox.Show("Sales Order is already approved, You cannot delete the Approved Sales Order", "Sales Order Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Sales Order from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtSalesOrderNo.EditValue) = False Then
                    If DeleteSalesOrder(Me.txtSalesOrderNo.EditValue) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.txtSalesOrderNo.EditValue, "VoucherScanned\PropSO")

                        MessageBox.Show("Sales Order has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Refresh the datagrid
                        RefreshSalesOrderMasterDataGrid()

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

    Private Function CheckIfSalesOrderIsApproved(ByVal SalesOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select SalesOrderNo from tbl40129_PropertySalesOrderMaster where (SalesOrderNo = '" & SalesOrderNo & "') and (Isnull(IsApproved,0) = 1 )"

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

    Private Function DeleteSalesOrder(ByVal SalesOrderNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl40129_PropertySalesOrderMaster WHERE SalesOrderNo   = '" & SalesOrderNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl40130_PropertySalesOrderChild WHERE SalesOrderNo   = '" & SalesOrderNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "UPDATE tbl40103PropertyQuoteMaster SET SalesOrderNo = '' WHERE SalesOrderNo = '" & SalesOrderNo & "'"
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


    Public Sub DisableApprovedVoucherEditing(ByVal QuotationNo As String)
        'Disable access if the voucher is already approved.
        'Get the IsVoucherIsApproved
        If CheckIfSalesOrderIsApproved(Me.txtSalesOrderNo.EditValue) = True Then
            Me.btnAddLineItem.Enabled = False
            Me.btnSave.Enabled = False
            Me.btnSaveAndClose.Enabled = False
            Me.btnAddNewLineItem.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnVerify.Enabled = False
            Me.btnApprove.Enabled = False
            Me.gcSalesOrderChild.Enabled = False

            Me.btnPrint.Enabled = True

        End If

        'Me.CheckIfPDFAvailable(voucherNo)
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

            If Me.intLogOnDivision = 99 Then
                frm30106ClientMaster.txtSalesPerson.Enabled = True
            Else
                frm30106ClientMaster.txtSalesPerson.EditValue = GetSalesPersonCode(Me.intLogOnUserID)
                frm30106ClientMaster.txtSalesPerson.Enabled = False
            End If

            frm30106ClientMaster.txtClientName.Focus()
            frm30106ClientMaster.isExecutedFrom_frm601_20PropertySalesOrderEdit = True

        ElseIf e.Button.Index = 1 Then

            If CheckIfNull(Me.txtClientName.EditValue) = True Or Me.txtClientName.Text = String.Empty Then
                MessageBox.Show("Please select the Client to edit.", "Select Client to edit", MessageBoxButtons.OK)
            Else
                Dim frm30106ClientMaster As New frm30106ClientMaster
                frm30106ClientMaster.ObjForm = Me

                frm30106ClientMaster.isExecutedFrom_frm601_20PropertySalesOrderEdit = True

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

                If Me.intLogOnDivision = 99 Then
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

                Me.txtClientRefName.EditValue = Me.Dsfrm40120PropertySalesOrderEdit.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactPerson")
                Me.txtClientContactNo.EditValue = Me.Dsfrm40120PropertySalesOrderEdit.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactPhone1")
                Me.txtClientEmail.EditValue = Me.Dsfrm40120PropertySalesOrderEdit.Tables("tbl30101ClientMaster").Rows.Find(Me.txtClientName.EditValue).Item("ContactEmail")
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
        ScannedFileLocation = gScannedLocation & "VoucherScanned\PropSO"
    End Sub

    Public Sub CheckIfPDFAvailable(ByVal VoucherNo As String)
        GetTheScannedFileLocation()
        ScannedFileLocation = ScannedFileLocation & VoucherNo & ".pdf"
        If System.IO.File.Exists(ScannedFileLocation) = True Then
            Me.btnAttachFile.Glyph = My.Resources.book_blue

        Else
            Me.btnAttachFile.Glyph = My.Resources.book_blue_delete
        End If
        ScannedFileLocation = ""

    End Sub
    Private Sub btnAttachPdf_Click(sender As Object, e As EventArgs) Handles btnAttachFile.ItemClick
        GetTheScannedFileLocation()
        AttachFile(Me.txtSalesOrderNo.EditValue, ScannedFileLocation)
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
                frmDocuments.IsPropSO = True
                frmDocuments.Show()
            Else
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = DocumentNo
                frmDocuments.IsPropSO = True
                frmDocuments.Show()
                frmDocuments.OpenFileDialogBox()
            End If

        End If
    End Sub


#End Region


    Private Sub btnPrintSalesOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintSalesOrder.ItemClick
        Try
            SaveAll(False)

            Dim rpt1 As New rpt40110PropertySalesOrder
            rpt1.Qry402_05PropertySalesOrderReportTableAdapter.FillBySalesOrderNo(rpt1.Dsrpt40110PropertySalesOrder1.qry402_05PropertySalesOrderReport, Me.txtSalesOrderNo.EditValue)

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

            rpt1.ExportOptions.PrintPreview.DefaultFileName = "Eqp_SalesOrder_No_" & Me.txtSalesOrderNo.EditValue & "_" & Me.txtClientName.Text
            rpt1.RequestParameters = False

            rpt1.ShowPreview()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Occured", MessageBoxButtons.OK)
        End Try

    End Sub

    
    Private Sub btnPrintSalesOrderYardCopy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintSalesOrderYardCopy.ItemClick
        Try
            SaveAll(False)

            Dim rpt1 As New rpt40110PropertySalesOrder
            rpt1.Qry402_05PropertySalesOrderReportTableAdapter.FillBySalesOrderNo(rpt1.Dsrpt40110PropertySalesOrder1.qry402_05PropertySalesOrderReport, Me.txtSalesOrderNo.EditValue)

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

            rpt1.lblUnitRate.Visible = False
            rpt1.txtUnitRate.Visible = False

            rpt1.lblMobCharges.Visible = False
            rpt1.txtMobCharges.Visible = False
            rpt1.lblDemobCharges.Visible = False
            rpt1.txtDemobCharges.Visible = False
            rpt1.lblTotalAmount.Visible = False
            rpt1.txtTotalAmount.Visible = False
            rpt1.tableTotal.Visible = False


            rpt1.RequestParameters = False
            rpt1.ShowPreview()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub FillCombobox()
        'Fill Cost Group
        Me.Tbl40129_PropertySalesOrderMaster_RegionTableAdapter.Fill(Me.Dsfrm40120PropertySalesOrderEdit2.tbl40129_PropertySalesOrderMaster_Region)

        For Each row As DataRow In Dsfrm40120PropertySalesOrderEdit2.tbl40129_PropertySalesOrderMaster_Region.Rows
            Me.txtSiteRegion.Properties.Items.Add(row("DeliveryRegion"))
        Next
        Me.txtSiteRegion.Properties.Sorted = True

    End Sub

    Public Sub FillComboboxClientPOs(ByVal SalesOrderNo As String)
        'Fill Sales Order PO Details

        'fill Po details 
        Me.Tbl40145_EqpSalesOrderPODetailsTableAdapter.FillBySalesOrder(Me.Dsfrm40120PropertySalesOrderEdit3.tbl40145_EqpSalesOrderPODetails, SalesOrderNo)

        Me.txtClientPONo.Properties.Items.Clear()
        For Each row As DataRow In Dsfrm40120PropertySalesOrderEdit3.tbl40145_EqpSalesOrderPODetails.Rows
            Me.txtClientPONo.Properties.Items.Add(row("ClientPONo"))
        Next
        Me.txtClientPONo.Properties.Sorted = True
    End Sub

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetAsDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_20PropertySalesOrderEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvSalesOrderChild))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvSalesOrderChild))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_20PropertySalesOrderEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEditContacts_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles cmdEditContacts.OpenLink
        Try
            Dim strClientCode As String = Me.txtClientName.EditValue

            If CheckIfNull(strClientCode) = False Then

                Dim frm600_03ClientContactList As New frm600_03ClientContactList
                frm600_03ClientContactList.ObjForm = Me
                frm600_03ClientContactList.isExecutedFrom_frm601_20PropertySalesOrderEdit = True

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

    Private Sub txtClientPONo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtClientPONo.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40144PropertySalesOrderPODetails As New frm40144PropertySalesOrderPODetails
            frm40144PropertySalesOrderPODetails.ObjForm = Me
            frm40144PropertySalesOrderPODetails.txtSalesOrderNo.EditValue = Me.txtSalesOrderNo.EditValue
            frm40144PropertySalesOrderPODetails.txtClientPONo.EditValue = Me.txtClientPONo.EditValue
            frm40144PropertySalesOrderPODetails.txtClientPODate.EditValue = Date.Today
            frm40144PropertySalesOrderPODetails.txtClientPOEndDate.EditValue = DateAdd(DateInterval.Year, 1, Date.Today)

            frm40144PropertySalesOrderPODetails.txtClientPONo.Focus()
            frm40144PropertySalesOrderPODetails.isExecutedFrom_frm601_20PropertySalesOrderEdit = True

            frm40144PropertySalesOrderPODetails.Show()
        End If
    End Sub
End Class