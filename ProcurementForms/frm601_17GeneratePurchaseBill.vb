Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Xml
Imports DevExpress.XtraReports.UI
Public Class frm601_17GeneratePurchaseBill
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

    'Public isExecutedFrom_frm601_06DeliveryNoteView As Boolean = False
    Public isExecutedFrom_frm601_08PurchaseOrderView As Boolean = False
    Private Sub frm601_17GeneratePurchaseBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SupplierListToBeBilledTableAdapter.Fill(Me.Dsfrm601_17GenerateBillsFromMRN.SupplierListToBeBilled)

    End Sub

    Private Sub btnShowDeliveryNotes_Click(sender As Object, e As EventArgs) Handles btnShowDeliveryNotes.Click
        ShowRecords()
    End Sub

    Public Sub ShowRecords()
        Try
            If CheckIfNull(Me.txtSupplierName.EditValue) = False Then
                If CheckIfNull(Me.txtPurchaseOrders.EditValue) = False Then
                    Me.Qry605_11MaterialReceiptNotesWithDetailsTableAdapter.FillByMRNandSuppID(Me.Dsfrm601_17GenerateBillsFromMRN.qry605_11MaterialReceiptNotesWithDetails, Me.txtSupplierName.EditValue, Me.txtPurchaseOrders.EditValue)

                    RefreshMasterDataGrid()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshMasterDataGrid()
        If isExecutedFrom_frm601_08PurchaseOrderView = True Then
            Try
                CType(ObjForm, frm601_08PurchaseOrderView).RetrieveVoucher(CType(ObjForm, frm601_08PurchaseOrderView).txtStartDate.EditValue, CType(ObjForm, frm601_08PurchaseOrderView).txtEndDate.EditValue)
                GoBackToRow(CType(ObjForm, frm601_08PurchaseOrderView).gvAdvBandedQuotationView, "PONo", Me.txtPurchaseOrders.EditValue)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Purchase Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub txtClientName_EditValueChanged(sender As Object, e As EventArgs) Handles txtSupplierName.EditValueChanged
        Try
            If CheckIfNull(Me.txtSupplierName.EditValue) = False Then
                Me.SupplierPurchaseOrderTableAdapter.Fill(Me.Dsfrm601_17GenerateBillsFromMRN.SupplierPurchaseOrder, Me.txtSupplierName.EditValue)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGenerateInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenerateInvoice.ItemClick
        Try
            If CheckIfPurchaseBillsAlreadyGenerated() = True Then
                MessageBox.Show("VAT Purchase Voucher Generated for the selected Material Receipts", "VAT Purchase Voucher already generated", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If

            If String.IsNullOrEmpty(ConvertIfNull(GetLedgerNoFromSupplierCode(Me.txtSupplierName.EditValue))) Then
                MessageBox.Show("Supplier Ledger is not Created, Please map the Supplier Ledger as per Finance Books.", "Supplier Ledger not Mapped", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            Else
                GeneratePurchaseBill(GetLedgerNoFromSupplierCode(Me.txtSupplierName.EditValue), Me.txtPurchaseOrders.EditValue, Me.strLogonUser, Me.strCompanyName)
                ShowRecords()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function CheckIfPurchaseBillsAlreadyGenerated() As Boolean

        Dim view As GridView = gvDeliveryNotes
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()

                If Not String.IsNullOrEmpty(ConvertIfNull(view.GetRowCellValue(row, view.Columns("VATPurchaseBillNo")))) Then
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

    Private Sub GeneratePurchaseBill(ByVal SupplierAccountNo As String, ByVal PurchaseOrderNo As String, ByVal AddedBy As String, ByVal CompanyBranch As Integer)

        Dim myTrans As System.Data.SqlClient.SqlTransaction
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)

        If Sqlconnection1.State = ConnectionState.Closed Then
            Sqlconnection1.Open()
        End If

        GetCompanyDetails(1)
        Dim NewPurchaseVoucherNo As String = GetNewPurchaseVoucherNo("", gInvoiceYearDigits, Date.Now, gIsResetInvoiceInYear)

        Dim InsertInvoiceTrans As New SqlClient.SqlCommand
        myTrans = Sqlconnection1.BeginTransaction(IsolationLevel.ReadCommitted, "InsertInvoiceTransaction")
        InsertInvoiceTrans.Connection = Sqlconnection1
        InsertInvoiceTrans.Transaction = myTrans

        Try
            InsertInvoiceTrans.CommandText = GetStringForQueryingMaster(NewPurchaseVoucherNo, SupplierAccountNo, PurchaseOrderNo, AddedBy, CompanyBranch)
            InsertInvoiceTrans.ExecuteNonQuery()

            InsertInvoiceTrans.CommandText = GetStringForUpdatingPurchaseVoucherChild(NewPurchaseVoucherNo)
            InsertInvoiceTrans.ExecuteNonQuery()

            InsertInvoiceTrans.CommandText = GetStringForUpdatingPurchaseVoucherNo(NewPurchaseVoucherNo)
            InsertInvoiceTrans.ExecuteNonQuery()

            myTrans.Commit()

            MessageBox.Show("New Purchase Bill Created Successfully", "Data addition Successfull", MessageBoxButtons.OK)
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

    Private Function GetStringForUpdatingPurchaseVoucherNo(ByVal PurchaseVoucherNo As String) As String
        Dim int1 As Integer = 0
        Dim str1 As String
        Dim strDeliveryNoteNos As String = ""

        Dim view As GridView = gvDeliveryNotes
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If view.GetRowCellValue(row, view.Columns("VATPurchaseBillNo")) = "" Then
                    If strDeliveryNoteNos = "" Then
                        strDeliveryNoteNos = "[ReceiptNo]='" & view.GetRowCellValue(row, view.Columns("ReceiptNo")) & "'"
                    Else
                        strDeliveryNoteNos = strDeliveryNoteNos & " OR " + "[ReceiptNo]='" & view.GetRowCellValue(row, view.Columns("ReceiptNo")) & "'"
                    End If
                End If
            Next
        End If

        str1 = "Update tbl605_01MaterialReceiptMaster Set VATPurchaseBillNo = '" & PurchaseVoucherNo & "' WHERE (" & strDeliveryNoteNos & ")"
        Return str1

    End Function

    Private Function GetStringForUpdatingPurchaseVoucherChild(ByVal PurchaseVoucherNo As String) As String
        Dim int1 As Integer = 0
        Dim str1 As String
        Dim strDeliveryNoteNos As String = ""

        Dim view As GridView = gvDeliveryNotes
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If view.GetRowCellValue(row, view.Columns("VATPurchaseBillNo")) = "" Then
                    If strDeliveryNoteNos = "" Then
                        strDeliveryNoteNos = "[ReceiptNo]='" & view.GetRowCellValue(row, view.Columns("ReceiptNo")) & "'"
                    Else
                        strDeliveryNoteNos = strDeliveryNoteNos & " OR " + "[ReceiptNo]='" & view.GetRowCellValue(row, view.Columns("ReceiptNo")) & "'"
                    End If
                End If
            Next
        End If

        str1 = "INSERT INTO tbl20167VATPurchaseChild (PurchaseVoucherNo, QuantityInvoiced, UnitsToBill, UnitRateMethod, UnitRate,  TaxSlabCode, ItemCode, Discount ) SELECT   '" & PurchaseVoucherNo & "',  SUM(QtyReceived) AS QtyReceived, 1, UnitRateMethod, MAX(UnitPrice) AS UnitPrice, POTaxSlab, GSCode, Sum(ItemDiscount) As ItemDiscount FROM dbo.tbl605_02MaterialReceiptChild WHERE (" & strDeliveryNoteNos & ") GROUP BY GSCode, UnitRateMethod, POTaxSlab"
        Return str1

    End Function

    Private Function GetStringForQueryingMaster(ByVal PurchaseVoucherNo As String, ByVal SupplierAccountNo As String, ByVal PurchaseOrderNo As String, ByVal AddedBy As String, ByVal CompanyBranch As Integer) As String
        Dim int1 As Integer = 0
        Dim str1 As String
        Dim strDeliveryNoteNos As String = ""

        Dim view As GridView = gvDeliveryNotes
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If view.GetRowCellValue(row, view.Columns("VATPurchaseBillNo")) = "" Then
                    If strDeliveryNoteNos = "" Then
                        strDeliveryNoteNos = view.GetRowCellValue(row, view.Columns("ReceiptNo"))
                    Else
                        strDeliveryNoteNos = strDeliveryNoteNos & ", " & view.GetRowCellValue(row, view.Columns("ReceiptNo"))
                    End If
                End If
            Next
        End If

        GetCompanyDetails02(1)
        If gIsDefaultInventoryLedgerInPurchase = True Then
            str1 = "INSERT INTO tbl20166VATPurchaseMaster (PurchaseVoucherNo, PurchaseVoucherDate, PurchaseEffectiveDate, PurchaseDeliveryDate, SupplierCode, MaterialReceiptNo, ReferenceNo, PurchaseOrderNo, AddedBy, AddedOn, PurchaseDueDate, CompanyID, PurchaseLedgerAccountNo, CostCenterCode) VALUES ('" & PurchaseVoucherNo & "', DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0), DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0), DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0), '" & SupplierAccountNo & "',  '" & strDeliveryNoteNos & "', '" & PurchaseOrderNo & "', '" & PurchaseOrderNo & "',  '" & AddedBy & "', GETDATE(),  GETDATE(), '" & CompanyBranch & "', '" & gDefaultInventoryLedgerNo & "' , 'ADMIN-0001')"
        Else
            str1 = "INSERT INTO tbl20166VATPurchaseMaster (PurchaseVoucherNo, PurchaseVoucherDate, PurchaseEffectiveDate, PurchaseDeliveryDate, SupplierCode, MaterialReceiptNo, ReferenceNo, PurchaseOrderNo, AddedBy, AddedOn, PurchaseDueDate, CompanyID, CostCenterCode) VALUES ('" & PurchaseVoucherNo & "', DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0), DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0), DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0), '" & SupplierAccountNo & "',  '" & strDeliveryNoteNos & "', '" & PurchaseOrderNo & "', '" & PurchaseOrderNo & "',  '" & AddedBy & "', GETDATE(),  GETDATE(), '" & CompanyBranch & "', 'ADMIN-0001')"
        End If

        Return str1

    End Function

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.close()

    End Sub


    Private Sub gvDeliveryNotes_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gvDeliveryNotes.ShowingEditor

        'if the Purchase Voucher No is available ... disable selection

        'Dim string1 As String = gvDeliveryNotes.GetRowCellDisplayText(gvDeliveryNotes.FocusedRowHandle, "BillStatus")

        'If (string1 = "Not Billed") Then
        '    gvDeliveryNotes.
        '    'row.DataGridView.Enabled = false;

        '    e.Cancel = False
        'Else
        '    e.Cancel = True
        '    'Select Case gvDeliveryNotes.FocusedColumn.FieldName
        '    '    Case "WorkStatus"
        '    '        e.Cancel = False
        '    '    Case "StartTimeShift1"
        '    '        e.Cancel = False
        '    '    Case "EndTimeShift1"
        '    '        e.Cancel = False
        '    '    Case "StartTimeShift2"
        '    '        e.Cancel = False
        '    '    Case "EndTimeShift2"
        '    '        e.Cancel = False
        '    '    Case "BonusMinutes"
        '    '        e.Cancel = False
        '    '    Case "ProjectID"
        '    '        e.Cancel = False
        '    '    Case "TotalHoursM"
        '    '        e.Cancel = False
        '    'End Select
        'End If

    End Sub

    Private Sub gvDeliveryNotes_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvDeliveryNotes.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim BillStatus As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("BillStatus"))
            If BillStatus <> "Not Billed" Then
                e.Appearance.BackColor = Color.PaleGreen
                'e.Appearance.BackColor2 = Color.SeaShell
                'e.HighPriority = True
            End If
        End If
    End Sub
End Class