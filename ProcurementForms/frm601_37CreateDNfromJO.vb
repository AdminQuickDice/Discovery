Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraReports.UI
Public Class frm601_37CreateDNfromJO
    Public ObjForm As Object
    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Public isExecutedFrom_frm601_28JobOrdersView As Boolean = False
    Private Sub frm601_37CreateDNfromJO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Qry608_01JobOrdersView1TableAdapter.FillAllClients(Me.Dsfrm601_37CreateDNfromJO.qry608_01JobOrdersView1)
        Me.Qry608_01JobOrdersViewTableAdapter.FillByJONotDelivered(Me.Dsfrm601_37CreateDNfromJO.qry608_01JobOrdersView, Me.txtClientName.EditValue)

    End Sub

    Private Sub RefreshMasterDataGrid()

        If isExecutedFrom_frm601_28JobOrdersView = True Then
            Try
                CType(ObjForm, frm601_28JobOrdersView).RetrieveVoucher(CType(ObjForm, frm601_28JobOrdersView).txtStartDate.EditValue, CType(ObjForm, frm601_28JobOrdersView).txtEndDate.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Job Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.close()

    End Sub

    Public SelectedClientPONo As String
    Public SelectedQuotationNo As String
    Public SelectedSalesOrderNo As String
    Public SelectedClientProject As String
    Public SelectedCompanyBranch As Integer
    Public SelectedClientPODate As Date

    Private Sub btnGenerateInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenerateInvoice.ItemClick
        Try
            'GenerateInvoice(GetLedgerNoFromClientCode(Me.txtClientName.EditValue), Me.strQuotationNo, Me.txtSalesOrders.EditValue, Me.strClientPONo, Me.strClientPODate, Me.strLogonUser, Me.strCompanyName, Me.strSalesPersonCode)
            Me.GenerateDeliveryNote(Me.txtClientName.EditValue, Me.SelectedClientPONo, Me.SelectedQuotationNo, Me.SelectedSalesOrderNo, Me.SelectedClientProject, Me.strLogonUser, Me.SelectedCompanyBranch)

            Me.Qry608_01JobOrdersViewTableAdapter.FillByJONotDelivered(Me.Dsfrm601_37CreateDNfromJO.qry608_01JobOrdersView, Me.txtClientName.EditValue)
            RefreshMasterDataGrid()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GenerateDeliveryNote(ByVal ClientCode As String, ByVal ClientPONo As String, ByVal QuotationNo As String, ByVal SalesOrderNo As String, ByVal ClientProject As String, ByVal AddedBy As String, ByVal CompanyBranch As Integer)

        Dim myTrans As System.Data.SqlClient.SqlTransaction
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)

        If Sqlconnection1.State = ConnectionState.Closed Then
            Sqlconnection1.Open()
        End If

        GetCompanyDetails(1)
        Dim NewDeliveryNoteNo As String = Me.GetNewDeliveryNoteNo(gDeliveryNoteAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote)

        Dim InsertInvoiceTrans As New SqlClient.SqlCommand
        myTrans = Sqlconnection1.BeginTransaction(IsolationLevel.ReadCommitted, "InsertInvoiceTransaction")
        InsertInvoiceTrans.Connection = Sqlconnection1
        InsertInvoiceTrans.Transaction = myTrans

        Try
            InsertInvoiceTrans.CommandText = GetStringForQueryingMaster(NewDeliveryNoteNo, ClientCode, ClientPONo, QuotationNo, SalesOrderNo, ClientProject, AddedBy, CompanyBranch)
            InsertInvoiceTrans.ExecuteNonQuery()

            'InsertInvoiceTrans.CommandText = GetStringForUpdatingInvoiceChild(NewInvoiceNo)
            'InsertInvoiceTrans.ExecuteNonQuery()

            'InsertInvoiceTrans.CommandText = GetStringForUpdatingInvoiceNo(NewInvoiceNo)
            'InsertInvoiceTrans.ExecuteNonQuery()

            myTrans.Commit()

            Me.InsertDeliveryNoteChildData(NewDeliveryNoteNo)

            MessageBox.Show("New Delivery Note Created Successfully", "Delivery Note Created Successfull", MessageBoxButtons.OK)
        Catch ex As Exception
            Try
                myTrans.Rollback("InsertInvoiceTransaction")
            Catch Sqlex As System.Data.SqlClient.SqlException
                If Not myTrans.Connection Is Nothing Then
                    MessageBox.Show("An exception of type " & Sqlex.GetType().ToString() & _
                                      " was encountered while attempting to roll back the transaction.", "Error on Adding Data", MessageBoxButtons.OK)
                End If
                MessageBox.Show("An exception of type " & ex.GetType().ToString() & _
                                      "was encountered while inserting the data.")
            End Try
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub
    Private Function GetStringForQueryingMaster(ByVal DeliveryNoteNo As String, ByVal ClientCode As String, ByVal ClientPONo As String, ByVal QuotationNo As String, ByVal SalesOrderNo As String, ByVal ClientProject As String, ByVal AddedBy As String, ByVal CompanyBranch As Integer) As String
        Dim int1 As Integer = 0
        Dim str1 As String
        Dim strJobOrderNos As String = ""
        'Dim strClientPONos As String = ""

        Dim view As GridView = gvJobOrders
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If strJobOrderNos = "" Then
                    strJobOrderNos = view.GetRowCellValue(row, view.Columns("JobOrderNo"))
                Else
                    strJobOrderNos = strJobOrderNos & ", " & view.GetRowCellValue(row, view.Columns("JobOrderNo"))
                End If

                'If strClientPONos = "" Then
                '    strClientPONos = view.GetRowCellValue(row, view.Columns("ClientPONo"))
                'Else
                '    strClientPONos = strClientPONos & ", " & view.GetRowCellValue(row, view.Columns("ClientPONo"))
                'End If
            Next
        End If

        str1 = "INSERT INTO tbl603_01DeliveryNoteMaster (DeliveryNoteNo, DeliveryDate, DeliveryType, ClientCode, ClientPONo, QuotationNo, SalesOrderNo,  ClientProject, AddedBy, AddedOn,  CompanyBranch, JobOrderNo) VALUES ('" & DeliveryNoteNo & "', GETDATE(), 1, '" & ClientCode & "', '" & ClientPONo & "', '" & QuotationNo & "', '" & SalesOrderNo & "', '" & ClientProject & "', '" & AddedBy & "', GETDATE(), '" & CompanyBranch & "', '" & strJobOrderNos & "')"
        Return str1

    End Function

    Public Function GetNewDeliveryNoteNo(ByVal DeliveryNoteAbbr As String, ByVal YearInDigit As Integer, ByVal NoOfDigits As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(right(DeliveryNoteNo," & NoOfDigits & ") as int)) from tbl603_01DeliveryNoteMaster"
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

    Private Function InsertDeliveryNoteChildData(ByVal DeliveryNoteNo As String) As String
        Dim int1 As Integer = 0
        Dim str1 As String
        Dim strJobOrderNos As String = ""

        Dim view As GridView = gvJobOrders
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()

                If view.IsGroupRow(row) Then
                Else
                    'MessageBox.Show(DeliveryNoteNo, view.GetRowCellValue(row, view.Columns("JobOrderNo")))
                    'Insert a line item in Delivery Note Record
                    Me.InsertToDeliveryNoteChild(DeliveryNoteNo, view.GetRowCellValue(row, view.Columns("JobOrderNo")))
                End If
            Next
        End If

        str1 = ""
        Return str1

    End Function

    Private Sub InsertToDeliveryNoteChild(ByVal DeliveryNoteNo As String, ByVal JobOrderNo As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp608_03InsertToDNChildfromJO"
            Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
            Dim paramJobOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@JobOrderNo", SqlDbType.VarChar)

            paramDeliveryNoteNo.Value = DeliveryNoteNo
            paramJobOrderNo.Value = JobOrderNo

            SqlCommand1.ExecuteNonQuery()
            'MessageBox.Show("New Delivery Note is created successfully,", "Delivery Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Delivery Note Creation failed, Please try again", "Delivery Note Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

   
    Private Sub btnShowDeliveryNotes_Click(sender As Object, e As EventArgs) Handles btnShowDeliveryNotes.Click
        Me.Qry608_01JobOrdersViewTableAdapter.FillByJONotDelivered(Me.Dsfrm601_37CreateDNfromJO.qry608_01JobOrdersView, Me.txtClientName.EditValue)
    End Sub
End Class