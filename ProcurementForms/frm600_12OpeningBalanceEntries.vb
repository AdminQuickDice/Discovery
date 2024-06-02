Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Public Class frm600_12OpeningBalanceEntries
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public objForm As Object
    Public IsOpenedFrom_frm600_01InventoryStockEdit As Boolean = False

    Public VoucherEntryNo As Integer

    Public Sub OpenItemOpeningBalEntry(ByVal StockCode As String)
        Me.Tbl605_02MaterialReceiptChildTableAdapter.FillByGSCode(Me.Dsfrm600_12OpeningBalanceEntries.tbl605_02MaterialReceiptChild, StockCode)

    End Sub
    Private Sub frm600_12OpeningBalanceEntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm600_12OpeningBalanceEntries.tbl40111PropertyUnitCodes' table. You can move, or remove it, as needed.
        Me.Tbl40111PropertyUnitCodesTableAdapter.Fill(Me.Dsfrm600_12OpeningBalanceEntries.tbl40111PropertyUnitCodes)

    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            Me.Validate()
            Me.Tbl60502MaterialReceiptChildBindingSource.EndEdit()
            Me.Tbl605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm600_12OpeningBalanceEntries.tbl605_02MaterialReceiptChild)
            MessageBox.Show("Stock Item Opening Balance Entries updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Stock Item Opening Balance Entries, Please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub gvCostAllocation_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvCostAllocation.CellValueChanged
        Try
            If e.Column.Caption = "Quantity" Then

                Me.Validate()
                Me.Tbl60502MaterialReceiptChildBindingSource.EndEdit()
                Me.Tbl605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm600_12OpeningBalanceEntries.tbl605_02MaterialReceiptChild)

                Dim SelectedOpBalEntryID As Integer = gvCostAllocation.GetRowCellValue(gvCostAllocation.FocusedRowHandle, "ReceiptChildSlNo")
                'Dim SelectedVoucherEntryID As Integer = gvCostAllocation.GetRowCellValue(gvCostAllocation.FocusedRowHandle, "VoucherEntryID")
                'Dim SelectedVoucherEntryDate As Date = gvCostAllocation.GetRowCellValue(gvCostAllocation.FocusedRowHandle, "EffectiveDate")

                Dim EnteredAmount As Decimal = e.Value
                Dim VoucherAmount As Decimal = Me.txtOpeningBalance.EditValue

                Dim TotalAmount As Decimal = GetOpeningBalanceTotal(Me.txtStockCode.EditValue) 'gvCostAllocation.Columns("AmountAllocated").SummaryItem.SummaryValue
                Dim NewEntryAmount As Decimal = VoucherAmount - TotalAmount

                If TotalAmount < VoucherAmount Then
                    'Create new row and add default values
                    AddNewOpBalEntry(NewEntryAmount)

                ElseIf TotalAmount > VoucherAmount Then

                    Dim balanceAmount As Decimal = TotalAmount - VoucherAmount
                    Dim AmountToPost As Decimal = EnteredAmount - balanceAmount
                    Me.UpdateEntryQty(SelectedOpBalEntryID, AmountToPost)
                    Me.Tbl605_02MaterialReceiptChildTableAdapter.FillByGSCode(Me.Dsfrm600_12OpeningBalanceEntries.tbl605_02MaterialReceiptChild, Me.txtStockCode.EditValue)
                End If


            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function GetOpeningBalanceTotal(ByVal StockCode As String) As Decimal
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            'SELECT    SUM(QtyReceived) as TotalReceived from tbl605_02MaterialReceiptChild WHERE (ReceiptNo = 'OPENING-BAL') AND (GSCode = 'CONS-00016')
            'SqlCommand1.CommandText = "select TotalAllocatedAmount from qry20139SearchPropertyAllocatedAmount where VoucherEntryID = '" & VoucherEntryID & "'"

            SqlCommand1.CommandText = "SELECT SUM(QtyReceived) as TotalReceived from tbl605_02MaterialReceiptChild WHERE (ReceiptNo = 'OPENING-BAL') AND (GSCode = '" & StockCode & "')"

            Dim TotalOpeningBalance As Decimal
            TotalOpeningBalance = SqlCommand1.ExecuteScalar()

            Return TotalOpeningBalance

        Catch ex As System.InvalidCastException

            Return 0

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub AddNewOpBalEntry(ByVal QtyReceived As Decimal)
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm600_12OpeningBalanceEntries.Tables("tbl605_02MaterialReceiptChild")
            dr = dt.NewRow()
            dr("ReceiptNo") = "OPENING-BAL"
            dr("GSCode") = Me.txtStockCode.EditValue
            dr("QtyReceived") = QtyReceived
            dr("UnitRateMethod") = Me.txtUnitOfMeasure.EditValue
            dr("UnitPrice") = Me.txtUnitPrice.EditValue

            'dr("EnteredBy") = Me.strLogOnUser
            'dr("EnteredOn") = Date.Now

            dt.Rows.Add(dr)

            Me.Tbl605_02MaterialReceiptChildTableAdapter.Update(Me.Dsfrm600_12OpeningBalanceEntries.tbl605_02MaterialReceiptChild)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Opening Balance Entry, Please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Function UpdateEntryQty(ByVal ReceiptChildSlNo As Integer, ByVal QtyAllocated As Decimal) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "update tbl605_02MaterialReceiptChild Set QtyReceived = " & QtyAllocated & " where ReceiptChildSlNo = '" & ReceiptChildSlNo & "'"

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

    Private Function DeleteOpeningBalance(ByVal StockCode As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "DELETE from tbl605_02MaterialReceiptChild where (ReceiptNo = 'OPENING-BAL') AND (GSCode = '" & StockCode & "')"

            Dim int1 As Integer
            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText

            int1 = SqlCommand1.ExecuteNonQuery()

            If int1 > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error Occured on Deleting Stock Item Opening Balance Details" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Public Function InsertOpeningBalance(ByVal StockCode As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Insert into tbl605_02MaterialReceiptChild (ReceiptNo, GSCode, QtyReceived, UnitRateMethod, UnitPrice) Values ('OPENING-BAL', '" & StockCode & "', '" & Me.txtOpeningBalance.EditValue & "', '" & Me.txtUnitOfMeasure.EditValue & "', '" & Me.txtUnitPrice.EditValue & "')"

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

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.ItemClick
        'Delete All Employee Allocation Entries
        Dim DialogResult As DialogResult
        DialogResult = MessageBox.Show("You are about to reset Opening Balance details for this Stock Item." & vbCrLf & "Are you Sure want to reset the Opening Balance Entries?", "Reset Item Opening Balance.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.txtStockCode.EditValue) = False Then
                Me.DeleteOpeningBalance(Me.txtStockCode.EditValue)

                If InsertOpeningBalance(Me.txtStockCode.EditValue) = True Then
                    'Refresh the Master datagrid
                    Me.Tbl605_02MaterialReceiptChildTableAdapter.FillByGSCode(Me.Dsfrm600_12OpeningBalanceEntries.tbl605_02MaterialReceiptChild, Me.txtStockCode.EditValue)

                End If
            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub btnBack_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub

End Class