Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraReports.UI
Public Class frm601_16GenerateInvoiceFromDelivery
    Public ObjForm As Object
    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Public strClientPONo As String = ""
    Public strClientPODate As Date
    Public strQuotationNo As String = ""
    Public strCompanyName As Integer
    Public strSalesPersonCode As String = ""

    Public isExecutedFrom_frm601_06DeliveryNoteView As Boolean = False
    Public isExecutedFrom_frm601_04SalesOrderView As Boolean = False

    Private Sub frm601_16GenerateInvoiceFromDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ClientListToBeInvoicedTableAdapter.FillClientList(Me.Dsfrm601_16GeneralInvoiceFromDN.ClientListToBeInvoiced)

    End Sub


    Private Sub btnShowDeliveryNotes_Click(sender As Object, e As EventArgs) Handles btnShowDeliveryNotes.Click
        ShowRecords()
    End Sub

    Public Sub ShowRecords()
        Try
            If CheckIfNull(Me.txtClientName.EditValue) = False Then
                If CheckIfNull(Me.txtSalesOrders.EditValue) = False Then
                    Me.Qry603_11DeliveryNotesWithDetailsTableAdapter.FillDNByClientAndSO(Me.Dsfrm601_16GeneralInvoiceFromDN.qry603_11DeliveryNotesWithDetails, Me.txtClientName.EditValue, Me.txtSalesOrders.EditValue)

                    RefreshMasterDataGrid()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshMasterDataGrid()

        If isExecutedFrom_frm601_04SalesOrderView = True Then
            Try
                CType(ObjForm, frm601_04SalesOrderView).RetrieveVoucher(CType(ObjForm, frm601_04SalesOrderView).txtStartDate.EditValue, CType(ObjForm, frm601_04SalesOrderView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_04SalesOrderView).gvAdvBandedQuotationView, "SalesOrderNo", Me.txtSalesOrders.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Sales Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
    Private Sub txtClientName_EditValueChanged(sender As Object, e As EventArgs) Handles txtClientName.EditValueChanged
        Try
            If CheckIfNull(Me.txtClientName.EditValue) = False Then
                Me.ClientSalesOrderTableAdapter.FillByClient(Me.Dsfrm601_16GeneralInvoiceFromDN.ClientSalesOrder, Me.txtClientName.EditValue)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGenerateInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenerateInvoice.ItemClick
        Try

            If CheckIfInvoiceAlreadyGenerated() = True Then
                MessageBox.Show("Invoice Generated for the selected Delivery Notes", "Invoice already generated", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub

            End If


            If String.IsNullOrEmpty(ConvertIfNull(GetLedgerNoFromClientCode(Me.txtClientName.EditValue))) Then
                MessageBox.Show("Client Ledger is not Created, Please map the Client Ledger as per Finance Books.", "Client Ledger not Mapped", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            Else
                Dim GeneratedInvoiceNo As String = GenerateInvoice(GetLedgerNoFromClientCode(Me.txtClientName.EditValue), Me.strQuotationNo, Me.txtSalesOrders.EditValue, Me.strClientPONo, Me.strClientPODate, Me.strLogonUser, Me.strCompanyName, Me.strSalesPersonCode)
                'Update the Due Date for the Invoice
                Me.UpdateDueDateOfInvoice(GeneratedInvoiceNo, GetDueDateOfInvoice(GetLedgerNoFromClientCode(Me.txtClientName.EditValue)))

                Me.OpenEInvoice(GeneratedInvoiceNo)
                ShowRecords()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Public Function UpdateDueDateOfInvoice(ByVal InvoiceNo As String, ByVal NoOfDaysCreditPeriod As Decimal) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim NoOfDaysCredit As Decimal = NoOfDaysCreditPeriod
            Dim InvoiceDueDate As Date = DateAdd(DateInterval.Day, NoOfDaysCredit, Date.Today)

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl20161VATInvoiceMaster SET InvoiceDueDate = '" & InvoiceDueDate & "' WHERE (InvoiceNo = '" & InvoiceNo & "') "

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

    Public Sub OpenEInvoice(ByVal InvoiceNo As String)
        If CheckIfNull(InvoiceNo) = False Then
            Dim frm00102eInvSalesInvoiceEdit As New frm00102eInvSalesInvoiceEdit
            frm00102eInvSalesInvoiceEdit.ObjForm = Me
            frm00102eInvSalesInvoiceEdit.btnSave.Caption = "Update"
            frm00102eInvSalesInvoiceEdit.strLogonUser = Me.strLogonUser
            frm00102eInvSalesInvoiceEdit.intLogOnUserID = Me.intLogOnUserID
            frm00102eInvSalesInvoiceEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm00102eInvSalesInvoiceEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm00102eInvSalesInvoiceEdit.intLogOnDivision = Me.intLogOnDivision
            'frm00102eInvSalesInvoiceEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            'frm00102eInvSalesInvoiceEdit.isExecutedFrom_frm601_06DeliveryNoteView = True
            frm00102eInvSalesInvoiceEdit.Show()

            frm00102eInvSalesInvoiceEdit.RetrieveInvoiceMaster(InvoiceNo)
            If GetInvoiceCurrency(InvoiceNo) = 1 Then
                frm00102eInvSalesInvoiceEdit.IsVisibleOC = False
            Else
                frm00102eInvSalesInvoiceEdit.IsVisibleOC = True
            End If
            frm00102eInvSalesInvoiceEdit.SwitchColumns()

            frm00102eInvSalesInvoiceEdit.txtInvoiceNo.Enabled = False
            frm00102eInvSalesInvoiceEdit.DisableApprovedVoucherEditing(InvoiceNo)

            frm00102eInvSalesInvoiceEdit.BackToInvoiceTab()

            frm00102eInvSalesInvoiceEdit.txtInvoiceNo.Enabled = False
            frm00102eInvSalesInvoiceEdit.txtInvoiceDate.Enabled = False
            frm00102eInvSalesInvoiceEdit.txtInvoiceDateWtTime.Enabled = False
            frm00102eInvSalesInvoiceEdit.txtInvoiceUUID.Enabled = False
            frm00102eInvSalesInvoiceEdit.txtInvoiceType.Enabled = False

            'To Fill the details of the company & client address
            frm00102eInvSalesInvoiceEdit.FixCompanyAndClientDetails()

            frm00102eInvSalesInvoiceEdit.ConstructFullAddressText()

        End If
    End Sub

    Private Function GenerateInvoice(ByVal ClientAccountNo As String, ByVal QuotationNo As String, ByVal SalesOrderNo As String, ByVal ClientPONo As String, ByVal ClientPODate As Date, ByVal AddedBy As String, ByVal CompanyBranch As Integer, ByVal SalesPersonCode As String) As String
        Dim myTrans As System.Data.SqlClient.SqlTransaction
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)

        If Sqlconnection1.State = ConnectionState.Closed Then
            Sqlconnection1.Open()
        End If

        GetCompanyDetails(1)
        Dim NewInvoiceNo As String = ""
        If gIsUseEInvoiceAbbrv = True Then
            NewInvoiceNo = frm00102eInvSalesInvoiceEdit.GetNewInvoiceNo(gEInvoiceAbbrv, gInvoiceYearDigits, GetSQLServerDate, gIsResetInvoiceInYear, gNoOfDigitsInEInvoiceNo)
        Else
            NewInvoiceNo = frm00102eInvSalesInvoiceEdit.GetNewInvoiceNo("", gInvoiceYearDigits, GetSQLServerDate, gIsResetInvoiceInYear, gNoOfDigitsInEInvoiceNo)
        End If

        Dim sGUID As String
        sGUID = System.Guid.NewGuid.ToString()

        Dim intInvoiceCounterValue As Integer = 0
        intInvoiceCounterValue = GetNewInvoiceCounterValue()
        If intInvoiceCounterValue = 0 Then
            MessageBox.Show("Error on Creating new e-Invoice, Invoice Counter Value returns Zero (0), please try again or contact I.T. Support for assistance.", "Invoice Counter Value Error", MessageBoxButtons.OK)
            Return ""
            Exit Function

        End If

        Dim InsertInvoiceTrans As New SqlClient.SqlCommand
        myTrans = Sqlconnection1.BeginTransaction(IsolationLevel.ReadCommitted, "InsertInvoiceTransaction")
        InsertInvoiceTrans.Connection = Sqlconnection1
        InsertInvoiceTrans.Transaction = myTrans

        Try
            InsertInvoiceTrans.CommandText = GetStringForQueryingMaster(NewInvoiceNo, ClientAccountNo, QuotationNo, SalesOrderNo, ClientPONo, ClientPODate, AddedBy, CompanyBranch, SalesPersonCode, sGUID, intInvoiceCounterValue)
            InsertInvoiceTrans.ExecuteNonQuery()

            InsertInvoiceTrans.CommandText = GetStringForUpdatingInvoiceChild(NewInvoiceNo)
            InsertInvoiceTrans.ExecuteNonQuery()

            InsertInvoiceTrans.CommandText = GetStringForUpdatingInvoiceNo(NewInvoiceNo)
            InsertInvoiceTrans.ExecuteNonQuery()

            myTrans.Commit()

            MessageBox.Show("New Invoice Created Successfully", "Data addition Successfull", MessageBoxButtons.OK)
            Return NewInvoiceNo

        Catch ex As Exception
            Try
                myTrans.Rollback("InsertInvoiceTransaction")
                Return ""
            Catch Sqlex As System.Data.SqlClient.SqlException
                If Not myTrans.Connection Is Nothing Then
                    MessageBox.Show("An exception of type " & Sqlex.GetType().ToString() &
                                      " was encountered while attempting to roll back the transaction.", "Error on Adding Data", MessageBoxButtons.OK)
                    Return ""
                End If
                MessageBox.Show("An exception of type " & ex.GetType().ToString() &
                                      "was encountered while inserting the data.")
                Return ""
            End Try
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Function GetStringForUpdatingInvoiceNo(ByVal InvoiceNo As String) As String
        Dim int1 As Integer = 0
        Dim str1 As String
        Dim strDeliveryNoteNos As String = ""

        Dim view As GridView = gvDeliveryNotes
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If strDeliveryNoteNos = "" Then
                    strDeliveryNoteNos = "[DeliveryNoteNo]='" & view.GetRowCellValue(row, view.Columns("DeliveryNoteNo")) & "'"
                Else
                    strDeliveryNoteNos = strDeliveryNoteNos & " OR " + "[DeliveryNoteNo]='" & view.GetRowCellValue(row, view.Columns("DeliveryNoteNo")) & "'"
                End If
            Next
        End If

        str1 = "Update tbl603_01DeliveryNoteMaster Set InvoiceNo = '" & InvoiceNo & "' WHERE (" & strDeliveryNoteNos & ")"
        Return str1

    End Function

    Private Function GetStringForUpdatingInvoiceChild(ByVal InvoiceNo As String) As String
        Dim int1 As Integer = 0
        Dim str1 As String
        Dim strDeliveryNoteNos As String = ""

        Dim view As GridView = gvDeliveryNotes
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If strDeliveryNoteNos = "" Then
                    strDeliveryNoteNos = "[DeliveryNoteNo]='" & view.GetRowCellValue(row, view.Columns("DeliveryNoteNo")) & "'"
                Else
                    strDeliveryNoteNos = strDeliveryNoteNos & " OR " + "[DeliveryNoteNo]='" & view.GetRowCellValue(row, view.Columns("DeliveryNoteNo")) & "'"
                End If
            Next
        End If

        str1 = "INSERT INTO tbl20162VATInvoiceChild (InvoiceNo, UoM, QuantityInvoiced, UnitsToBill, UnitRateMethod, UnitRate,  TaxSlabCode, ItemCode, LineOrderNo ) SELECT   '" & InvoiceNo & "', IssuedUOM, SUM(IssuedQty) AS IssuedQty, 1, UnitRateMethod, MAX(QuotedUnitPrice) AS QuotedUnitPrice, QuotedTaxSlab, GSCode, Sum(LineOrderNo) as LineOrderNo FROM dbo.qry651_12DeliveryNoteItemsWithPrice WHERE (" & strDeliveryNoteNos & ") GROUP BY SalesOrderNo, GSCode, IssuedUOM, UnitRateMethod, QuotedTaxSlab"
        Return str1

    End Function

    Private Function GetStringForQueryingMaster(ByVal InvoiceNo As String, ByVal ClientAccountNo As String, ByVal QuotationNo As String, ByVal SalesOrderNo As String, ByVal ClientPONo As String, ByVal ClientPODate As Date, ByVal AddedBy As String, ByVal CompanyBranch As Integer, ByVal SalesPersonCode As String, ByVal InvoiceUUID As String, ByVal InvoiceCounterValue As Integer) As String
        Dim int1 As Integer = 0
        Dim str1 As String
        Dim strDeliveryNoteNos As String = ""

        Dim view As GridView = gvDeliveryNotes
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If strDeliveryNoteNos = "" Then
                    strDeliveryNoteNos = view.GetRowCellValue(row, view.Columns("DeliveryNoteNo"))
                Else
                    strDeliveryNoteNos = strDeliveryNoteNos & ", " & view.GetRowCellValue(row, view.Columns("DeliveryNoteNo"))
                End If
            Next
        End If

        str1 = "INSERT INTO tbl20161VATInvoiceMaster (InvoiceNo, InvoiceDate, InvoiceEffectiveDate, InvoiceDeliveryDate, ClientCode, QuotationNo, DeliveryNoteNos, ReferenceNo, SOSReferenceNo, PONo, PODate, AddedBy, AddedOn, TaxCategoryID, AdvanceAmount, RetentionAmount, AdvanceText, RetentionText, AdvanceTextAr, RetentionTextAr, InvoiceDueDate, CompanyID, InvoiceSalesPerson, SalesOrderNo, InvoiceUUID, InvoiceCounterValue, InvoiceTypeCode, InvoiceTransactionCode, InvoiceTypeCodeSubType, IsThirdParty, IsNominal, IsExport, IsSummary, IsSelfBilled, InvoiceDateWtTime, InvoiceCurrencyCode, TaxCurrencyCode, PaymentMeansTypeCode, Currency, ExchangeRate) VALUES ('" & InvoiceNo & "', DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0), DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0), DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0), '" & ClientAccountNo & "', '" & QuotationNo & "', '" & strDeliveryNoteNos & "', '" & SalesOrderNo & "', '" & SalesOrderNo & "', '" & ClientPONo & "', '" & ClientPODate & "', '" & AddedBy & "', GETDATE(), 1, 0, 0, 'Less: Advance', 'Less: Retention', N'أقل: المبلغ المستلم مقدما (ريال سعودى)ـ' , N'أقل: مبلغ الاحتفاظ (ريال سعودى)ـ', GETDATE(), '" & CompanyBranch & "', '" & SalesPersonCode & "', '" & SalesOrderNo & "',  '" & InvoiceUUID & "',  '" & InvoiceCounterValue & "', '388', '0100000', '01', 0, 0, 0, 0, 0, GETDATE(), 1, 1, 42, 1, 1)"
        Return str1

    End Function


    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.close()

    End Sub

    Private Function CheckIfInvoiceAlreadyGenerated() As Boolean

        Dim view As GridView = gvDeliveryNotes
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()

                If Not String.IsNullOrEmpty(ConvertIfNull(view.GetRowCellValue(row, view.Columns("InvoiceNo")))) Then
                        'IF the Invoice Number is not empty then return True
                        Return True
                    Else
                        Return False
                End If
            Next
        Else
            Return True
        End If

    End Function
End Class