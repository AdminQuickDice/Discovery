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

Public Class frm601_03SalesOrderEdit
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

    Dim SelectedSalesOrderChildSlNo As Integer
    Dim SelectedSalesOrderChildQty As Decimal = 0D


    Public isExecutedFrom_frm601_04SalesOrderView As Boolean = False
    Public isExecutedFrom_frm601_02_QuotationView As Boolean = False

    Public CreatedNewSalesOrderNo As String


#Region "Ordering Code"
    Private Const OrderFieldName As String = "LineOrderNo"

    Private downHitInfo As GridHitInfo = Nothing

    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Dim view As GridView = GridView1
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
        Dim view As GridView = GridView1
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

    Private Sub frm601_03SalesOrderEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm601_03SalesOrderEdit.tbl201CostAllocationUnits' table. You can move, or remove it, as needed.
        Me.Tbl201CostAllocationUnitsTableAdapter.Fill(Me.Dsfrm601_03SalesOrderEdit.tbl201CostAllocationUnits)
        Me.Tbl600_08InventoryMasterGroupTableAdapter.Fill(Me.Dsfrm601_03SalesOrderEdit1.tbl600_08InventoryMasterGroup)
        Me.Qry700_02ProjectsViewMasterTableAdapter.Fill(Me.Dsfrm601_03SalesOrderEdit.qry700_02ProjectsViewMaster)
        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.tbl40111PropertyUnitCodes)
        Me.Tbl20163VatTaxSlabsTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.tbl20163VatTaxSlabs)
        Me.Tbl901CompanyDetailsTableAdapter.Fill(Me.Dsfrm20161VATInvoiceEdit.tbl901CompanyDetails)
        Me.Tbl90104DocumentSignatoriesTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl90104DocumentSignatories)
        Me.Tbl20101SalesPersonMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl20101SalesPersonMaster)
        Me.Tbl30101ClientMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl30101ClientMaster)
        Me.Tbl30104TypeOfRequestMasterTableAdapter.Fill(Me.Ds40103PropertyQuoteMaster.tbl30104TypeOfRequestMaster)

        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm601_01QuotationEdit.tbl20164GoodsAndServicesMaster)
        Else
            Me.Tbl20164GoodsAndServicesMasterTableAdapter.FillByInventoryMasterGroupID(Me.Dsfrm601_01QuotationEdit.tbl20164GoodsAndServicesMaster, Me.intLogOnInventoryAccessLevel)
        End If
        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_03SalesOrderEdit", Me.GridView1)

        Me.ImplementAccess(Me.intLogOnUserID)

        GetCompanyDetails02(1)
        If gIsShowFixedCostPrice = True Then
            Me.colCostPrice.Visible = False

        End If

        'Populate Custom Reports Tab
        Me.PopulateCustomReportButtons(Me.CustomReportFormNo)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colLineTaxAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colLineTotalWithTax02.DisplayFormat.FormatString = "{0:#,0.000}"

            txtAdditionsAmount.Properties.DisplayFormat.FormatString = "{0:#,0.000}"
            txtDeductionsAmount.Properties.DisplayFormat.FormatString = "{0:#,0.000}"

            txtAdditionsAmount.Properties.EditFormat.FormatString = "{0:#,0.000}"
            txtDeductionsAmount.Properties.EditFormat.FormatString = "{0:#,0.000}"

            txtAdditionsAmount.Properties.EditMask = "###,###,##0.000"
            txtDeductionsAmount.Properties.EditMask = "###,###,##0.000"

        End If
    End Sub

    Public Sub ImplementAccess(ByVal UserID As Integer)
        If GetUserAccess(UserID, "frm601_03SalesOrderEdit_FullAccess") = True Then

            Me.btnMoveUp.Enabled = True
            Me.btnMoveDown.Enabled = True
            Me.btnResetLayout.Enabled = True
            Me.btnSetAsDefaultLayout.Enabled = True
            Me.btnSave.Enabled = True
            Me.btnSaveAndClose.Enabled = True
            Me.btnReportGroup.Enabled = True
            Me.btnDelete.Enabled = True
            Me.btnAddNewLineItem.Enabled = True
            Me.btnDeleteLineItem.Enabled = True
            Me.btnDeleteSelectedItems.Enabled = True
            Me.btnAddLineItem.Enabled = True
            Me.btnGenerateJobOrders.Enabled = True
            Me.btnBack.Enabled = True
            Me.btnAttachments.Enabled = True
            Me.btnSubmit.Enabled = True
            Me.btnVerify.Enabled = True
            Me.btnApprove.Enabled = True

            Me.txtClientName.Properties.Buttons.Item(2).Enabled = True
            Me.txtClientName.Properties.Buttons.Item(1).Enabled = True

            Me.cmdEditContacts.Enabled = True

            Me.txtSalesPerson.Properties.Buttons.Item(1).Enabled = True
            Me.txtTypeOfSalesOrder.Properties.Buttons.Item(1).Enabled = True

            Me.txtSignatory.Properties.Buttons.Item(1).Enabled = True

            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = True
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = True

        Else

            Me.btnMoveUp.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnMoveUp")
            Me.btnMoveDown.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnMoveDown")
            Me.btnResetLayout.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnResetLayout")
            Me.btnSetAsDefaultLayout.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnSetAsDefaultLayout")
            Me.btnSave.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnSave")
            Me.btnSaveAndClose.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnSaveAndClose")
            Me.btnReportGroup.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnPrintSalesOrder")
            Me.btnDelete.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnDelete")
            Me.btnAddNewLineItem.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnAddNewLineItem")
            Me.btnDeleteLineItem.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnDeleteLineItem")
            Me.btnDeleteSelectedItems.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnDeleteLineItem")
            Me.btnAddLineItem.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnAddNewLineItem")
            Me.btnGenerateJobOrders.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnGenerateJobOrders")
            Me.btnBack.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnBack")
            Me.btnAttachments.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnAttachments")
            Me.btnSubmit.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnSubmit")
            Me.btnVerify.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnVerify")
            Me.btnApprove.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_btnApprove")

            Me.txtClientName.Properties.Buttons.Item(2).Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_txtClientName")
            Me.txtClientName.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_txtClientName")

            Me.cmdEditContacts.Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_cmdEditContacts")

            Me.txtSalesPerson.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_txtSalesPerson")
            Me.txtTypeOfSalesOrder.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_txtTypeOfSalesOrder")

            Me.repoDetailedDescription.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_AddStockItem")
            Me.repoDetailedDescription.Properties.Buttons.Item(2).Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_EditStockItem")


            For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then

                    Me.txtSignatory.Properties.Buttons.Item(1).Enabled = GetUserAccess(UserID, "frm601_03SalesOrderEdit_txtSignatory")
                    Exit For
                End If
            Next

        End If
    End Sub

    'Disable All Controls
    Public Sub DisableAllControls()

        Me.btnMoveUp.Enabled = False
        Me.btnMoveDown.Enabled = False
        Me.btnResetLayout.Enabled = False
        Me.btnSetAsDefaultLayout.Enabled = False

        Me.btnSave.Enabled = False
        Me.btnSaveAndClose.Enabled = False
        Me.btnReportGroup.Enabled = True
        Me.btnDelete.Enabled = False
        Me.btnAddNewLineItem.Enabled = False
        Me.btnBack.Enabled = True
        Me.btnAttachments.Enabled = True
        Me.btnSubmit.Enabled = False
        Me.btnVerify.Enabled = False
        Me.btnApprove.Enabled = False

        Me.btnDeleteLineItem.Enabled = False
        Me.btnDeleteSelectedItems.Enabled = False
        Me.btnAddLineItem.Enabled = False
        Me.btnGenerateJobOrder.Enabled = False

        Me.txtSignatory.Enabled = False

        Me.txtClientName.Enabled = False

        Me.GridControl1.Enabled = False

        Me.txtSalesOrderDate.Enabled = False
        Me.txtQuotationNo.Enabled = False
        Me.txtQuoteDate.Enabled = False
        Me.txtClientPONo.Enabled = False
        Me.txtClientPODate.Enabled = False
        Me.txtIssuedToProject.Enabled = False
        Me.txtTypeOfSalesOrder.Enabled = False
        Me.txtProject.Enabled = False
        Me.txtClientName.Enabled = False
        Me.txtClientRefName.Enabled = False
        Me.txtClientContactNo.Enabled = False
        Me.txtClientEmail.Enabled = False

        Me.PanelControl1.Enabled = False

    End Sub

    Public Sub EnableAllControls()

        Me.btnMoveUp.Enabled = True
        Me.btnMoveDown.Enabled = True
        Me.btnResetLayout.Enabled = True
        Me.btnSetAsDefaultLayout.Enabled = True

        Me.btnSave.Enabled = True
        Me.btnSaveAndClose.Enabled = True
        Me.btnReportGroup.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnAddNewLineItem.Enabled = True
        Me.btnBack.Enabled = True
        Me.btnAttachments.Enabled = True
        Me.btnSubmit.Enabled = True
        Me.btnVerify.Enabled = True
        Me.btnApprove.Enabled = True

        Me.btnDeleteLineItem.Enabled = True
        Me.btnDeleteSelectedItems.Enabled = True
        Me.btnAddLineItem.Enabled = True
        Me.btnGenerateJobOrder.Enabled = True

        Me.txtSignatory.Enabled = True

        Me.GridControl1.Enabled = True

        Me.txtSalesOrderDate.Enabled = True
        Me.txtQuotationNo.Enabled = True
        Me.txtQuoteDate.Enabled = True
        Me.txtClientPONo.Enabled = True
        Me.txtClientPODate.Enabled = True
        Me.txtIssuedToProject.Enabled = True
        Me.txtTypeOfSalesOrder.Enabled = True
        Me.txtProject.Enabled = True
        Me.txtClientName.Enabled = True
        Me.txtClientRefName.Enabled = True
        Me.txtClientContactNo.Enabled = True
        Me.txtClientEmail.Enabled = True

        Me.PanelControl1.Enabled = False

    End Sub

    Public Sub UpdateDefaultFields()
        'Select the Details Page
        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageSignatories" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)

                Me.txtAdditionsAmount.EditValue = 0
                Me.txtDeductionsAmount.EditValue = 0
                Me.txtAdditions.EditValue = "Add: Additions (SAR)"
                Me.txtDeductions.EditValue = "Less: Deductions (SAR)"

                Exit For
            End If
        Next

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

                'Get SalesPerson Code and fill it.
                'If the User Account can create Other SalesPerson Quotes then enable SalesPerson Field.. else disable it.
                Dim SalesPersonCode As String = ""
                SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    If SalesPersonCode = "0" OrElse SalesPersonCode = "" Then
                        Me.txtSalesPerson.Enabled = True
                    Else
                        Me.txtSalesPerson.EditValue = GetSalesPersonCode(Me.intLogOnUserID)
                        Me.txtSalesPerson.Enabled = True
                    End If
                Else
                    Me.txtSalesPerson.EditValue = GetSalesPersonCode(Me.intLogOnUserID)
                    Me.txtSalesPerson.Enabled = False
                End If

                GetCompanyDetails02(1)
                Me.txtCostCenterMaster.EditValue = gDefaultCostCenterMasterFromSalesOrder

                Exit For
            End If

        Next

        For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
            If XtraTabControl1.TabPages(i).Name = "pageQuoteDetails" Then
                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(i)
                Exit For
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

    Public Sub RetrieveSalesOrderMaster(ByVal SalesOrderNo As String)
        Try
            If CheckIfNull(SalesOrderNo) = False Then
                'fill master details
                Me.Tbl602_01SalesOrderMasterTableAdapter.FillByOrder(Me.Dsfrm601_03SalesOrderEdit.tbl602_01SalesOrderMaster, SalesOrderNo)

                'fill child details in the datagrid
                Me.Qry602_02SalesOrderChildTableAdapter.FillByOrder(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild, SalesOrderNo)

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Sales Order Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateSalesOrderMaster(ByVal SalesOrderNo As String, ByVal WithMessage As Boolean)
        If CheckIfNull(SalesOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60201SalesOrderMasterBindingSource.Current, DataRowView)
            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            Me.Tbl60201SalesOrderMasterBindingSource.EndEdit()
            Me.Tbl602_01SalesOrderMasterTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.tbl602_01SalesOrderMaster)

            If WithMessage = True Then
                MessageBox.Show("Sales Order  Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SaveNewSalesOrderMaster(ByVal SalesOrderNo As String)
        If CheckIfNull(SalesOrderNo) = False Then
            If isBeingNew = True Then
                Dim view As DataRowView = DirectCast(Me.Tbl60201SalesOrderMasterBindingSource.Current, DataRowView)
                view.Row("AddedBy") = Me.strLogonUser
                view.Row("AddedOn") = Date.Now
                Me.Validate()

                Me.Tbl60201SalesOrderMasterBindingSource.EndEdit()
                Me.Tbl602_01SalesOrderMasterTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.tbl602_01SalesOrderMaster)

                'Create a Cost Center in Finance Modules - Chart of Cost Centers

                GetCompanyDetails02(1)
                'gDefaultCostCenterMasterFromSalesOrder
                Me.CreateCostCenterFromSalesOrder(Me.txtSalesOrderNo.EditValue, Me.txtClientName.Text, Me.strLogonUser, gIsCreateCostCenterFromSalesOrder, Me.txtCostCenterMaster.EditValue, Me.txtSalesPerson.Text)

            End If
        End If
    End Sub

    Private Sub CreateCostCenterFromSalesOrder(ByVal SalesOrderNo As String, ByVal ClientName As String, ByVal AddedBy As String, ByVal IsCreateCostCenterFromSalesOrder As Boolean, ByVal DefaultCostCenterMasterFromSalesOrder As String, ByVal SalesPersonName As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_04InsertToCostCenterFromSalesOrder"
            Dim paramSalesOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderNo", SqlDbType.VarChar)
            Dim paramClientName As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ClientName", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramIsCreateCostCenterFromSalesOrder As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@IsCreateCostCenterFromSalesOrder", SqlDbType.Bit)
            Dim paramDefaultCostCenterMasterFromSalesOrder As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DefaultCostCenterMasterFromSalesOrder", SqlDbType.VarChar)
            Dim paramSalesPersonName As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesPersonName", SqlDbType.VarChar)

            paramSalesOrderNo.Value = SalesOrderNo
            paramClientName.Value = ClientName
            paramAddedBy.Value = AddedBy
            paramIsCreateCostCenterFromSalesOrder.Value = IsCreateCostCenterFromSalesOrder
            paramDefaultCostCenterMasterFromSalesOrder.Value = DefaultCostCenterMasterFromSalesOrder
            paramSalesPersonName.Value = SalesPersonName

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Cost Center created successfully,", "Cost Center Created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Sales Order Creation failed, Please try again", "Sales Order  Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
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
            Me.Qry60202SalesOrderChildBindingSource.EndEdit()
            Me.Qry602_02SalesOrderChildTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild)
            Me.Qry602_02SalesOrderChildTableAdapter.FillByOrder(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild, Me.txtSalesOrderNo.EditValue)

        Catch ex As Exception

        End Try

        'If is updated from Master Datagrid refresh it
        RefreshSalesOrderMasterDataGrid()
    End Sub

    Private Sub RefreshSalesOrderMasterDataGrid()
        If isExecutedFrom_frm601_04SalesOrderView = True Then
            Try
                CType(ObjForm, frm601_04SalesOrderView).RetrieveVoucher(CType(ObjForm, frm601_04SalesOrderView).txtStartDate.EditValue, CType(ObjForm, frm601_04SalesOrderView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_04SalesOrderView).gvAdvBandedQuotationView, "SalesOrderNo", Me.txtSalesOrderNo.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Sales Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If isExecutedFrom_frm601_02_QuotationView = True Then
            Try
                CType(ObjForm, frm601_02_QuotationView).RetrieveVoucher(CType(ObjForm, frm601_02_QuotationView).txtStartDate.EditValue, CType(ObjForm, frm601_02_QuotationView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_02_QuotationView).gvAdvBandedQuotationView, "QuoteNo", Me.txtQuotationNo.EditValue)
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

    Public Function GetNewSalesOrderNo(ByVal SalesOrderAbbr As String, ByVal YearInDigit As Integer, ByVal NoOfDigits As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1

            SqlCommand1.CommandText = "select max(cast(right(SalesOrderNo," & NoOfDigits & ") as int)) from tbl602_01SalesOrderMaster WHERE SalesOrderNo like '" & SalesOrderAbbr & "%'"
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
            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
            strNewQuotationNo = "000000" & 1
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
                Me.Tbl60201SalesOrderMasterBindingSource.AddNew()
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
                Me.Qry60202SalesOrderChildBindingSource.EndEdit()
                Me.Qry602_02SalesOrderChildTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild)

                Me.Qry602_02SalesOrderChildTableAdapter.FillByOrder(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild, Me.txtSalesOrderNo.EditValue)

                Me.GridView1.MoveLast()
                Me.GridView1.FocusedColumn = Me.GridView1.Columns("GSCode")
                Me.GridView1.ShowEditor()

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Sales Order Line Item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm601_03SalesOrderEdit.Tables("qry602_02SalesOrderChild")
            dr = dt.NewRow()
            dr("SalesOrderChildID") = 1
            dr("SalesOrderNo") = Me.txtSalesOrderNo.EditValue
            dr("QuotedQuantity") = 1
            dr("LineOrderNo") = GetNewSalesOrderLineItemNo(Me.txtSalesOrderNo.EditValue)
            dt.Rows.Add(dr)
            Me.Qry602_02SalesOrderChildTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild)

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
            SqlCommand1.CommandText = "select Max(LineOrderNo) from tbl602_02SalesOrderChild where SalesOrderNo = '" & strSalesOrderNo & "'"
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

    Private Sub cmdStockItemDesc_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles cmdStockItemDesc.OpenLink
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60202SalesOrderChildBindingSource.Current, DataRowView)
            Dim SelectedPropertyNo As String = ""
            SelectedPropertyNo = view.Row("GSCode")
            Me.txtDetailedDescription.EditValue = GetItemDescription(SelectedPropertyNo)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteSalesOrderChild(ByVal SalesOrderChildSlNo As Integer, ByVal WithMessage As Boolean)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp602_01DeleteSalesOrderChild"
            Dim paramPayrollInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderChildSlNo", SqlDbType.Int)

            paramPayrollInvoiceNo.Value = SalesOrderChildSlNo

            SqlCommand1.ExecuteNonQuery()

            If WithMessage = True Then
                MessageBox.Show("Sales Order Line Item Deleted Successfully,", "Data Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As System.InvalidCastException
            MessageBox.Show("Sales Order Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnLineItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteLineItem.ItemClick

        DialogResult = MessageBox.Show("You are about to delete Sales Order Line Item." & vbCrLf & "Are you Sure want to delete this Sales Order Details?", "Delete Invoice.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedSalesOrderChildSlNo) = False Then

                Me.DeleteSalesOrderChild(Me.SelectedSalesOrderChildSlNo, True)

                'Refresh the datagrid
                'fill child details in the datagrid
                Me.Qry602_02SalesOrderChildTableAdapter.FillByOrder(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild, Me.txtSalesOrderNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub GridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView1.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedSalesOrderChildSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SalesOrderChildID"))
                SelectedSalesOrderChildQty = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("QuotedQuantity"))
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
            Me.Qry60202SalesOrderChildBindingSource.EndEdit()
            Me.Qry602_02SalesOrderChildTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild)

            Me.Qry602_02SalesOrderChildTableAdapter.FillByOrder(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild, Me.txtSalesOrderNo.EditValue)
        End If
    End Sub

    Public Sub UpdateInvoiceChild()
        Try

            Me.Validate()
            Me.Qry60202SalesOrderChildBindingSource.EndEdit()
            Me.Qry602_02SalesOrderChildTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild)

            'RefreshInvoiceChild()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub RefreshInvoiceChild()
        Me.Qry602_02SalesOrderChildTableAdapter.FillByOrder(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild, Me.txtSalesOrderNo.EditValue)

        'GetWorkHours()

    End Sub

    Private Sub gvWorkSheet_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        'UpdateqvoiceChild()

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            If frm601_04SalesOrderView.CheckSalesOrderDeliveryStatus(Me.txtSalesOrderNo.EditValue) = "Fully Delivered" Or frm601_04SalesOrderView.CheckSalesOrderDeliveryStatus(Me.txtSalesOrderNo.EditValue) = "Partially Delivered" Then
                MessageBox.Show("You cannot delete this Sales Order, Sales Order has related Delivery Notes, Please Remove the Delivery Notes to Unlock this Sales Order and try again.", "Delivery Notes Generated.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If

            'Check if the Voucher is approved already
            If CheckIfSalesOrderIsApproved(Me.txtSalesOrderNo.EditValue) = True Then
                MessageBox.Show("Sales Order is already approved, You cannot delete the Approved Sales Order", "Sales Order Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            'Check if the Sales Order has Cost Center already
            GetCompanyDetails02(1)
            If gIsCreateCostCenterFromSalesOrder = True Then
                If frm601_04SalesOrderView.CheckIfSalesOrderHasCostCenter(Me.txtSalesOrderNo.EditValue) = True Then
                    MessageBox.Show("Sales Order has Cost Center Created in Finance Modules, You cannot delete the Sales Order." & vbCrLf & "Please delete the Cost Center Details from CHART OF COST CENTERS  from Finance Modules to Proceed.", "Sales Order has related Cost Center", MessageBoxButtons.OK)
                    Exit Sub
                End If

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Sales Order from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtSalesOrderNo.EditValue) = False Then
                    If DeleteSalesOrder(Me.txtSalesOrderNo.EditValue) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.txtSalesOrderNo.EditValue, "VoucherScanned\IMSSO")

                        MessageBox.Show("Sales Order has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Sales Order", "IMS Sales Order Ref No." & Me.txtSalesOrderNo.EditValue & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogonUser & ".", Me.strLogonUser, Me.txtSalesOrderNo.EditValue)

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

    Public Function CheckIfSalesOrderIsApproved(ByVal SalesOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select SalesOrderNo from tbl602_01SalesOrderMaster where (SalesOrderNo = '" & SalesOrderNo & "') and (Isnull(IsApproved,0) = 1 )"

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

            delPRTrans.CommandText = "DELETE from tbl602_01SalesOrderMaster WHERE SalesOrderNo   = '" & SalesOrderNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl602_02SalesOrderChild WHERE SalesOrderNo   = '" & SalesOrderNo & "'"
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
        If CheckIfSalesOrderIsApproved(Me.txtSalesOrderNo.EditValue) = True Then
            Me.btnAddLineItem.Enabled = False
            Me.btnSave.Enabled = False
            Me.btnSaveAndClose.Enabled = False
            Me.btnAddNewLineItem.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnVerify.Enabled = False
            Me.btnApprove.Enabled = False
            Me.gcInvoiceChild.Enabled = False

            Me.btnPreviewQuotation.Enabled = True
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
            frm30106ClientMaster.isExecutedFrom_frm601_03SalesOrderEdit = True

        ElseIf e.Button.Index = 1 Then

            If CheckIfNull(Me.txtClientName.EditValue) = True Or Me.txtClientName.Text = String.Empty Then
                MessageBox.Show("Please select the Client to edit.", "Select Client to edit", MessageBoxButtons.OK)
            Else
                Dim frm30106ClientMaster As New frm30106ClientMaster
                frm30106ClientMaster.ObjForm = Me

                frm30106ClientMaster.isExecutedFrom_frm601_03SalesOrderEdit = True

                frm30106ClientMaster.strLogonUser = Me.strLogonUser
                frm30106ClientMaster.intLogOnUserID = Me.intLogOnUserID
                frm30106ClientMaster.intLogOnUserLevel = Me.intLogOnUserLevel
                frm30106ClientMaster.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm30106ClientMaster.txtClientCode.EditValue = Me.txtClientName.EditValue
                frm30106ClientMaster.Show()
                frm30106ClientMaster.FillDataSetforEditing(Me.txtClientName.EditValue)

                frm30106ClientMaster.btnSave.Caption = "Update"

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
            frm40115QuotationSignatories.isExecutedFrom_frm601_03SalesOrderEdit = True
        End If
    End Sub



    Private Sub repoUnitRateMethod_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemGridLookUpEdit4.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40114QuoteMethods As New frm40114QuoteMethods
            frm40114QuoteMethods.ObjForm = Me
            frm40114QuoteMethods.Show()
            frm40114QuoteMethods.txtQuoteMethod.Focus()
            frm40114QuoteMethods.isExecutedFrom_frm601_01QuotationEdit = True
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            'Dim DescriptionCaptionWtArabic As String = "Description " & Global.Microsoft.VisualBasic.ChrW(10) & "// وصف السلعة"

            If e.Column.Caption = "Description" Then
                Dim SelectedValue As String = e.Value
                GetGSDetails(SelectedValue)
                GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("UnitRateMethod"), gGSStockUnitMethod)
                GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("QuotedUnitPrice"), gGSSellingRate)

                GetCompanyDetails(1)
                If gCurrencyType = "BHD" Then
                    GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("QuotedTaxSlab"), 10)
                ElseIf gCurrencyType = "AED" Then
                    gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("QuotedTaxSlab"), 1)
                Else
                    GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("QuotedTaxSlab"), 8)
                End If



                Dim StockCostAvgPrice As Decimal = Me.GetStockIssueCost(SelectedValue)
                GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("CostPrice"), StockCostAvgPrice)

                UpdateInvoiceChild()

            End If

            If e.Column.Name = "colUnitRateMethod02" Then
                GetCompanyDetails02(1)
                If gIsStrictUnitsForStockItems = True Then
                    Dim EnteredUOM As Decimal = e.Value
                    Dim SelectedGSCode As String = GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns("GSCode"))
                    If CheckIfGSCodeIsServiceGroup(SelectedGSCode) = True Then
                        Exit Sub
                    End If

                    If CheckStockUOM(SelectedGSCode, EnteredUOM) = True Then
                        'Get the Unit Converted and Get the Cost Price and multiply it by Unit Converted
                        Dim UnitsToConvert As Decimal = GetStockItemBaseUnitsToConvert(SelectedGSCode, EnteredUOM)
                        Dim CostPrice As Decimal = Me.GetStockIssueCost(SelectedGSCode)
                        Dim UnitCostPrice As Decimal = 0D
                        UnitCostPrice = UnitsToConvert * CostPrice
                        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("CostPrice"), UnitCostPrice)

                        'Get the Unit Converted and get the Selling Price and Mulitply it by unit converted
                        GetGSDetails(SelectedGSCode)
                        Dim UnitSellingPrice As Decimal = 0D
                        UnitSellingPrice = UnitsToConvert * gGSSellingRate
                        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("QuotedUnitPrice"), UnitSellingPrice)

                    Else
                        MessageBox.Show("Selected Unit is not in the Base Unit of this Stock Item," & vbCrLf & "Please check the Unit and try again.", "UoM not matching", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("UnitRateMethod"), GetStockItemBaseUnit(SelectedGSCode))
                        Me.GridView1.FocusedColumn = GridView1.Columns("UnitRateMethod")

                    End If

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub


    'Edit Stock / Description
    Private Sub RepositoryItemGridLookUpEdit5_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemGridLookUpEdit5.ButtonClick
        If e.Button.Index = 1 Then
            Try
                Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                frm20163VATGoodsAndServicesEdit.ObjForm = Me

                frm20163VATGoodsAndServicesEdit.btnSave.Caption = "Save"

                frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_03SalesOrderEdit = True
                'isExecutedFrom_frm601_03SalesOrderEdit


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
                Dim strItemCode As String = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "GSCode")

                If CheckIfNull(strItemCode) = False Then

                    Dim frm20163VATGoodsAndServicesEdit As New frm20163VATGoodsAndServicesEdit
                    frm20163VATGoodsAndServicesEdit.ObjForm = Me
                    frm20163VATGoodsAndServicesEdit.isExecutedFrom_frm601_03SalesOrderEdit = True

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
                Dim strItemCode As String = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "GSCode")

                If CheckIfNull(strItemCode) = False Then

                    Dim frm600_01InventoryStockEdit As New frm600_01InventoryStockEdit
                    frm600_01InventoryStockEdit.objForm = Me
                    frm600_01InventoryStockEdit.isExecutedFrom_frm601_03SalesOrderEdit = True

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

    Public Function GetStockIssueCost(ByVal GSCode As String) As Decimal
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "SELECT Isnull(AvgCostUnitRate,0) as AvgCostUnitRate FROM qry653_16GetInventoryIssuePriceUsingAvgCost WHERE (GSCode = '" & GSCode & "') "

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

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetAsDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_03SalesOrderEdit"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.GridView1))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.GridView1))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_03SalesOrderEdit"

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
        ScannedFileLocation = gScannedLocation & "VoucherScanned\IMSSO"
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
                frmDocuments.IsIMSSO = True
                frmDocuments.Show()
            Else
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = DocumentNo
                frmDocuments.IsIMSSO = True
                frmDocuments.Show()
                frmDocuments.OpenFileDialogBox()
            End If

        End If
    End Sub


#End Region

    Private Sub btnGenerateJobOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenerateJobOrders.ItemClick
        Me.popupCreateJobOrders.Show()

    End Sub

    Public Function GetNewJobOrderNo(ByVal JobOrderAbbr As String, ByVal YearInDigit As Integer, ByVal NoOfDigits As Integer, ByVal JobOrderDate As Date, ByVal IsResetByYear As Boolean) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1

            If IsResetByYear = True Then
                'SqlCommand1.CommandText = "select max(cast(right(PONo, " & NoOfDigits & ") as int)) from tbl604_01PurchaseOrderMaster where PONo like '" & PurchaseOrderAbbrv & "%' AND Year(PODate) = '" & Year(PODate).ToString & "'"
                SqlCommand1.CommandText = "select max(cast(right(JobOrderNo," & NoOfDigits & ") as int)) from tbl608_01JobOrderMaster where JobOrderNo Like '" & JobOrderAbbr & "%' AND Year(JobOrderDate) = '" & Year(JobOrderDate).ToString & "'"
            Else
                SqlCommand1.CommandText = "select max(cast(right(JobOrderNo," & NoOfDigits & ") as int)) from tbl608_01JobOrderMaster where JobOrderNo Like '" & JobOrderAbbr & "%'"
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
            strNewQuotationNo = JobOrderAbbr & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = "000000" & 1
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)
            strNewQuotationNo = JobOrderAbbr & strYear & "-" & strNewQuotationNo
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function
    Private Sub InsertJobOrderFromSalesOrder(ByVal JobOrderNo As String, ByVal AddedBy As String, ByVal SalesOrderChildID As Integer, ByVal ValveType As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp608_01InsertToJobOrderFromSalesOrderChild"
            Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@JobOrderNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramSalesOrderChildID As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderChildID", SqlDbType.BigInt)
            Dim paramValveType As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ValveType", SqlDbType.VarChar)

            paramDeliveryNoteNo.Value = JobOrderNo
            paramAddedBy.Value = AddedBy
            paramSalesOrderChildID.Value = SalesOrderChildID
            paramValveType.Value = ValveType

            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            MessageBox.Show("Job Orders Creation failed, Please try again", "Job Orders Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Function CheckIfJobOrdersGenerated(ByVal SalesOrderChildID As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select SalesOrderChildID from tbl608_01JobOrderMaster where (SalesOrderChildID = '" & SalesOrderChildID & "')"

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

    Private Sub btnGenerateJobOrder_Click(sender As Object, e As EventArgs) Handles btnGenerateJobOrder.Click

        Try
            If CheckIfJobOrdersGenerated(Me.SelectedSalesOrderChildSlNo) = True Then
                MessageBox.Show("Job Orders are generated already, please check Job Order Database.", "Job Orders Generated already.", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim var As Integer
            Dim startVal As Integer
            Dim endVal As Integer
            startVal = 1
            endVal = Me.SelectedSalesOrderChildQty
            GetCompanyDetails(1)

            For var = startVal To endVal
                'Insert Job Orders
                Dim NewJobOrderNo As String = Me.GetNewJobOrderNo(Me.txtValveList.EditValue & "-", gInvoiceYearDigits, 5, Date.Now, gIsResetJobOrdersInYear)

                Me.InsertJobOrderFromSalesOrder(NewJobOrderNo, Me.strLogonUser, Me.SelectedSalesOrderChildSlNo, Me.txtValveList.Properties.Items(Me.txtValveList.SelectedIndex).Description)

            Next var

            MessageBox.Show("New Job Orders created successfully,", "Job Orders created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.popupCreateJobOrders.Hide()
    End Sub

    Private Sub cmdEditContacts_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles cmdEditContacts.OpenLink
        Try
            Dim strClientCode As String = Me.txtClientName.EditValue

            If CheckIfNull(strClientCode) = False Then

                Dim frm600_03ClientContactList As New frm600_03ClientContactList
                frm600_03ClientContactList.ObjForm = Me
                frm600_03ClientContactList.isExecutedFrom_frm601_03SalesOrderEdit = True

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

    Private Sub btnPrintSalesOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintSalesOrder.ItemClick
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

                PrintSalesOrderFormat01()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintSalesOrderFormat01()

        Dim rpt1 As New rpt601_09SalesOrder

        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = "IMS-SO-01"
        Dim frm1 As New frm999_02ReportPreviewIMS_SalesOrdervb

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------

        rpt1.Qry602_13SalesOrderReportTableAdapter.FillBySalesOrderNo(rpt1.DsRpt601_09SalesOrder1.qry602_13SalesOrderReport, Me.txtSalesOrderNo.EditValue)

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

        If Me.txtAdditionsAmount.EditValue = 0 Then
            rpt1.rowAdditions02.Visible = False
        End If

        If Me.txtDeductionsAmount.EditValue = 0 Then
            rpt1.rowDeductions02.Visible = False
        End If

        If Me.txtPrintInLetterHead.EditValue = True Then

            rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
            rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
            rpt1.Watermark.ImageTiling = False
            rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
            rpt1.Watermark.ImageTransparency = 0
            rpt1.Watermark.ShowBehind = True
            'rpt1.Watermark.PageRange = "2,4"

        End If


        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser
        'rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
        'rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
        'rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

        rpt1.intCompanyID = Me.txtCompanyID.EditValue

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "SalesOrder_No_" & Me.txtSalesOrderNo.EditValue & "_" & Me.txtClientName.Text
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

    Private Sub txtIssuedToProject_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtIssuedToProject.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm700_07ProjectsSimpleEditForm As New frm700_07ProjectsSimpleEditForm
            frm700_07ProjectsSimpleEditForm.ObjForm = Me
            frm700_07ProjectsSimpleEditForm.Show()
            frm700_07ProjectsSimpleEditForm.txtProjectGroup.Focus()
            frm700_07ProjectsSimpleEditForm.isExecutedFrom_frm601_03SalesOrderEdit = True
        End If
    End Sub

    Private Sub btnDeleteSelectedItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteSelectedItems.ItemClick
        DialogResult = MessageBox.Show("You are about to delete all the Selected Sales Order Line Items." & vbCrLf & "Are you Sure want to delete this Sales Order Details?", "Delete Sales Order Line Item.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Dim view As GridView = GridView1
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    Dim ChosenSalesOrderChildID As Integer = view.GetRowCellValue(row, view.Columns("SalesOrderChildID"))
                    Me.DeleteSalesOrderChild(ChosenSalesOrderChildID, False)
                Next
            End If
            'Refresh the datagrid
            'fill child details in the datagrid
            Me.Qry602_02SalesOrderChildTableAdapter.FillByOrder(Me.Dsfrm601_03SalesOrderEdit.qry602_02SalesOrderChild, Me.txtSalesOrderNo.EditValue)


        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub

        End If
    End Sub


#Region "Populate Custom Report Buttons"
    'Change this code for other forms.. 
    Dim CustomReportFormNo As Integer = 4

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
        Dim rpt1 As New rpt601_09SalesOrder

        '---------------------------------------
        'NEW REPORT DESIGNED BY CLIENT STARTS HERE
        'This is for Customer Desinged Report
        'Check this is Customer Designed Report then.. run this code
        '----------------------------------------
        Dim ReportCode As String = ReportNo
        Dim frm1 As New frm999_02ReportPreviewIMS_SalesOrdervb

        If CheckIfReportIsCustomDesigned(ReportCode) = True Then
            Dim text As String = GetReportXmlLayout(ReportCode)
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
            Dim stream As New MemoryStream(byteArray)
            rpt1.LoadLayoutFromXml(stream)

        End If

        '---------------------------------------
        rpt1.Qry602_13SalesOrderReportTableAdapter.FillBySalesOrderNo(rpt1.DsRpt601_09SalesOrder1.qry602_13SalesOrderReport, Me.txtSalesOrderNo.EditValue)

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

        If Me.txtAdditionsAmount.EditValue = 0 Then
            rpt1.rowAdditions02.Visible = False
        End If

        If Me.txtDeductionsAmount.EditValue = 0 Then
            rpt1.rowDeductions02.Visible = False
        End If

        If Me.txtPrintInLetterHead.EditValue = True Then

            rpt1.Watermark.Image = GetLetterHeadFull(Me.txtCompanyID.EditValue)
            rpt1.Watermark.ImageAlign = ContentAlignment.TopLeft
            rpt1.Watermark.ImageTiling = False
            rpt1.Watermark.ImageViewMode = ImageViewMode.Stretch
            rpt1.Watermark.ImageTransparency = 0
            rpt1.Watermark.ShowBehind = True
            'rpt1.Watermark.PageRange = "2,4"

        End If


        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser
        'rpt1.IsPrintItemCodeWithDescription = Me.txtIsPrintItemCodeWtDesc.EditValue
        'rpt1.IsPrintItemPartNoWithDescription = Me.txtIsPrintItemPartNoWtDesc.EditValue
        'rpt1.IsPrintItemPartNoWithArabicDesc = Me.txtIsPrintItemPartNoWtArabicDesc.EditValue

        rpt1.intCompanyID = Me.txtCompanyID.EditValue

        rpt1.ExportOptions.PrintPreview.DefaultFileName = "SalesOrder_No_" & Me.txtSalesOrderNo.EditValue & "_" & Me.txtClientName.Text
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

    Private Sub btnSubmit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSubmit.ItemClick
        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_03SalesOrderEdit_btnSubmit") = False Then
            MessageBox.Show("You have no Access rights to Submit the Sales Order. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Submitting User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.SubmitSalesOrder(Me.txtSalesOrderNo.EditValue)

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60103-001")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " submitted a Sales Order for your verification."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New PR/Enquiry is ready to verify.")

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshSalesOrderMasterDataGrid()
    End Sub


    Private Sub SubmitSalesOrder(ByVal SalesOrderNo As String)
        If CheckIfNull(SalesOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60201SalesOrderMasterBindingSource.Current, DataRowView)
            view.Row("IsSubmitted") = True
            view.Row("SubmittedBy") = Me.strLogonUser
            view.Row("SubmittedOn") = Date.Now

            view.Row("ModifiedBy") = Me.strLogonUser
            view.Row("ModifiedOn") = Date.Now

            'view.Row("QuoteSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            ''Set the Status to 31 - Enquiry/Request Submitted
            'view.Row("PurchaseRequestStatusID") = 31

            Me.Tbl60201SalesOrderMasterBindingSource.EndEdit()
            Me.Tbl602_01SalesOrderMasterTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.tbl602_01SalesOrderMaster)

            MessageBox.Show("Sales Order has been submitted for Approval.", "Submit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnVerify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnVerify.ItemClick
        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_03SalesOrderEdit_btnVerify") = False Then
            MessageBox.Show("You have no Access rights to Verify the Sales Order. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this Pr Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Verifying User have not assigned to Signatory in the System.", "Verify Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check if this PR is submitted
        If CheckIfSalesOrderIsSubmitted(Me.txtSalesOrderNo.EditValue) = False Then
            MessageBox.Show("Sales Order is not yet Submitted, please submit the Sales Order for verfication process.", "Sales Order Not Submitted for verification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Me.VerifySalesOrder(Me.txtSalesOrderNo.EditValue)

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60103-002")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " verified & Sent the Sales Order for your Approval."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify New PR/Enquiry is ready to Approve.")

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshSalesOrderMasterDataGrid()
    End Sub

    Public Function CheckIfSalesOrderIsSubmitted(ByVal SalesOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select SalesOrderNo from tbl602_01SalesOrderMaster where (SalesOrderNo = '" & SalesOrderNo & "') and (Isnull(IsSubmitted,0) = 1 )"

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

    Private Sub VerifySalesOrder(ByVal SalesOrderNo As String)
        If CheckIfNull(SalesOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60201SalesOrderMasterBindingSource.Current, DataRowView)
            view.Row("IsVerified") = True
            view.Row("VerifiedBy") = Me.strLogonUser
            view.Row("VerifiedOn") = Date.Now
            ''Set the Status to 32 - Enquiry/Request Verified
            'view.Row("PurchaseRequestStatusID") = 32

            'view.Row("VerifiedSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            Me.Tbl60201SalesOrderMasterBindingSource.EndEdit()
            Me.Tbl602_01SalesOrderMasterTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.tbl602_01SalesOrderMaster)

            MessageBox.Show("Sales ORder has been Verified and processed for Approval.", "Verify Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnApprove_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnApprove.ItemClick
        Me.SaveAll(False)

        'Check if the User is allowed to Submit the Form
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_03SalesOrderEdit_btnApprove") = False Then
            MessageBox.Show("You have no Access rights to Approve the Sales Order. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        'Check if this MPR Signatory have Verification Signature
        If GetSignatoryIDfromUserID(Me.intLogOnUserID) = 0 Then
            MessageBox.Show("Approving User have not assigned to Signatory in the System.", "Signature not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        'Check if this MPR is Verified
        If CheckIfSalesOrderIsVerified(Me.txtSalesOrderNo.EditValue) = False Then
            If MessageBox.Show("Sales Order is not yet Verified, Click Yes If you want to verify and Approve this Sales Order.", "Sales Order is not Verified.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                Me.VerifySalesOrder(Me.txtSalesOrderNo.EditValue)
            Else
                Exit Sub
            End If
        End If

        Me.ApproveSalesOrder(Me.txtSalesOrderNo.EditValue)

        'Check whether Alert Activation for Submission to Verification is set then
        'Make an Alert to the Verifier
        GetAlertSettings("SYS-60101-003")
        If gIsAlertActivated = True Then
            'Add an alert
            GetCompanyDetails02(1)
            Dim AlertMessage2 As String = ""
            AlertMessage2 = Me.strLogonUser & " approved " & "Sales Order No:" & Me.txtSalesOrderNo.EditValue & ". for Processing."
            InsertSystemAlert(GetNewAlertCode("SYS", gNoOfDigitsToAlertNotification), gAlertIsSetForUserID, AlertMessage2, Me.intLogOnUserID, Date.Now, "Auto Alert set to notify PR/Enquiry is ready to process.")

        End If

        'Disable editing of controls
        DisableAllControls()
        'If is updated from Master Datagrid refresh it
        RefreshSalesOrderMasterDataGrid()
    End Sub

    Public Function CheckIfSalesOrderIsVerified(ByVal SalesOrderNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select SalesOrderNo from tbl602_01SalesOrderMaster where (SalesOrderNo = '" & SalesOrderNo & "') and (Isnull(IsVerified,0) = 1 )"

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

    Private Sub ApproveSalesOrder(ByVal SalesOrderNo As String)
        If CheckIfNull(SalesOrderNo) = False Then

            Me.Validate()
            Dim view As DataRowView = DirectCast(Me.Tbl60201SalesOrderMasterBindingSource.Current, DataRowView)
            view.Row("IsApproved") = True
            view.Row("ApprovedBy") = Me.strLogonUser
            view.Row("ApprovedOn") = Date.Now
            ''Set the Status to 33 - Enquiry/Request Approved
            'view.Row("PurchaseRequestStatusID") = 33

            'view.Row("ApprovedSignatory") = GetSignatoryIDfromUserID(Me.intLogOnUserID)

            Me.Tbl60201SalesOrderMasterBindingSource.EndEdit()
            Me.Tbl602_01SalesOrderMasterTableAdapter.Update(Me.Dsfrm601_03SalesOrderEdit.tbl602_01SalesOrderMaster)

            MessageBox.Show("Sales Order has been Approved.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCheckStockAvailability_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCheckStockAvailability.ItemClick
        Try
            If CheckIfNull(Me.txtSalesOrderNo.EditValue) = True Or Me.txtSalesOrderNo.Text = String.Empty Then
                MessageBox.Show("Sales Order No is Empty to review.", "No Sales Order", MessageBoxButtons.OK)
            Else

                Dim frm601_04A_SalesOrderStoreAvailability As New frm601_04A_SalesOrderStoreAvailability
                frm601_04A_SalesOrderStoreAvailability.objForm = Me
                frm601_04A_SalesOrderStoreAvailability.isExecutedFrom_frm601_03SalesOrderEdit = True

                frm601_04A_SalesOrderStoreAvailability.strLogOnUser = Me.strLogonUser
                frm601_04A_SalesOrderStoreAvailability.intLogOnUserID = Me.intLogOnUserID
                frm601_04A_SalesOrderStoreAvailability.intLogOnUserLevel = Me.intLogOnUserLevel
                frm601_04A_SalesOrderStoreAvailability.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm601_04A_SalesOrderStoreAvailability.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                frm601_04A_SalesOrderStoreAvailability.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

                frm601_04A_SalesOrderStoreAvailability.SalesOrderNo = Me.txtSalesOrderNo.EditValue

                frm601_04A_SalesOrderStoreAvailability.Show()


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSalesOrderDate_Leave(sender As Object, e As EventArgs) Handles txtSalesOrderDate.Leave
        'DATE BLOCKING
        GetCompanyDetails02(1)
        If gIsDateLockingEnabled = True Then
            If CheckIfNull(Me.txtSalesOrderDate.EditValue) = True Then
                Me.txtSalesOrderDate.EditValue = Date.Today()
            End If
            If CheckIfDateBeenLocked("IMS_SALESORDERS", Me.txtSalesOrderDate.EditValue) = True Then
                MessageBox.Show("This Sales Order Entry date has been blocked." & vbCrLf & "Please review your entry date.", "Entry Date is Blocked", MessageBoxButtons.OK)
                Me.txtSalesOrderDate.EditValue = Me.txtSalesOrderDate.OldEditValue
                Me.txtSalesOrderDate.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnUseItemDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60202SalesOrderChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.MemoEdit1.Text = GetGSCodeDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUseItemDetailedDesc_Click(sender As Object, e As EventArgs) Handles btnUseItemDetailedDesc.Click
        Try
            Dim view As DataRowView = DirectCast(Me.Qry60202SalesOrderChildBindingSource.Current, DataRowView)
            Dim SelectedGSCode As String = ""
            SelectedGSCode = view.Row("GSCode")
            Me.MemoEdit1.Text = GetGSCodeDetailedDescription(SelectedGSCode)

        Catch ex As Exception

        End Try
    End Sub


#End Region
End Class