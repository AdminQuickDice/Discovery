Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_07DeliveryNoteCostPosting


    Public frfrm601_07DeliveryNoteCostPostingIsClosed As Boolean
    'User Access Controls
    Public ObjForm As Object

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Public intLogOnHRLevelCode As Integer

    Private SelectedDeliveryNoteNo As String = ""
    Private SelectedDeliveryNoteDate As Date = Date.Today()
    '
    Private SelectedGSCode As String = ""
    Private SelectedClientCode As String = ""

    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If Me.intLogOnHRLevelCode = 99 Then
                Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDate(Me.Dsfrm601_07DeliveryNoteCostPosting.qry603_06DeliveryNoteDetails, StartDate, EndDate)

            Else
                Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDeliveryType(Me.Dsfrm601_07DeliveryNoteCostPosting.qry603_06DeliveryNoteDetails, StartDate, EndDate, intLogOnHRLevelCode)

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Delivery Note Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ShowRecords()
        'Check the Dates are correct
        'Retrieve records
        RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        'Update Tiles
        'Me.UpdateFrames()

    End Sub

    Private Sub btnToday_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnToday.ItemClick
        Me.txtStartDate.EditValue = Date.Today
        Me.txtEndDate.EditValue = Date.Today
        ShowRecords()
    End Sub

    Private Sub btnYesterday_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnYesterday.ItemClick
        Me.txtStartDate.EditValue = DateAdd(DateInterval.Day, -1, Date.Today)
        Me.txtEndDate.EditValue = DateAdd(DateInterval.Day, -1, Date.Today)
        ShowRecords()
    End Sub


    'this week
    Private Sub btnThisWeek_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisWeek.ItemClick
        Dim today As Date = Date.Today
        Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Saturday
        Dim SaturDay As Date = today.AddDays(-dayDiff)

        Me.txtStartDate.EditValue = DateAdd(DateInterval.Day, -7, SaturDay)
        Me.txtEndDate.EditValue = DateAdd(DateInterval.Day, -1, SaturDay)

        ShowRecords()
    End Sub

    Private Sub btnThisYearTillDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisYearTillDate.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 1, 1)
        Me.txtEndDate.EditValue = Date.Today
        ShowRecords()
    End Sub

    'this year full
    Private Sub btnThisYearfull_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisYear.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 1, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()

    End Sub

    Private Sub btnThisMonthTillDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisMonthTillDate.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = Date.Today
        ShowRecords()
    End Sub

    'this month
    Private Sub btnFillThisMonth_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisMonthFull.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()
    End Sub

    'Last Year
    Private Sub btnLastYear_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLastYear.ItemClick
        Dim LastYearDate As Date = DateAdd(DateInterval.Year, -1, Date.Today)
        Me.txtStartDate.EditValue = DateSerial(LastYearDate.Year, 1, 1)
        Me.txtEndDate.EditValue = DateSerial(LastYearDate.Year, 12, 31)
        ShowRecords()

    End Sub


    Private Sub btnLastMonth_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLastMonth.ItemClick
        Dim LastMonthThisDate As Date = DateAdd(DateInterval.Month, -1, Date.Today)

        Me.txtStartDate.EditValue = DateSerial(LastMonthThisDate.Year, LastMonthThisDate.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(LastMonthThisDate.Year, LastMonthThisDate.Month, Date.DaysInMonth(LastMonthThisDate.Year, LastMonthThisDate.Month))

        ShowRecords()
    End Sub

    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frfrm601_07DeliveryNoteCostPostingIsClosed = True
    End Sub

    Private Sub btnSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        If Me.gvDeliveryNote.OptionsView.ShowAutoFilterRow = True Then
            Me.gvDeliveryNote.OptionsView.ShowAutoFilterRow = False
        Else
            Me.gvDeliveryNote.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub

    Private Sub btnPrintDatabase_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnAllowGrouping_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroup.ItemClick
        If Me.gvDeliveryNote.OptionsView.ShowGroupPanel = True Then
            Me.gvDeliveryNote.OptionsView.ShowGroupPanel = False
        Else
            Me.gvDeliveryNote.OptionsView.ShowGroupPanel = True
        End If
    End Sub

    Private Sub gvAccountDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvDeliveryNote.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedDeliveryNoteNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryNoteNo"))
                SelectedDeliveryNoteDate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryDate"))
                SelectedGSCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("GSCode"))

                'If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))) = False Then
                '    SelectedClientCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ClientCode"))
                'Else
                '    SelectedClientCode = ""
                'End If

                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnPostAvgCost_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPostAvgCost.ItemClick
        Me.SplashScreenManager1.ShowWaitForm()

        Dim view As GridView = gvDeliveryNote
        'If barEditItem1.EditValue IsNot Nothing AndAlso view.SelectedRowsCount > 0 Then
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If view.IsGroupRow(row) Then
                Else

                    'Post all the Average Cost Price of the Items in the Delivery Note and Update it
                    'Dim TickSelectedDeliveryNoteNo As String = view.GetRowCellValue(row, view.Columns("DeliveryNoteNo"))
                    Dim TickSelectedDeliveryNoteSlNo As Integer = view.GetRowCellValue(row, view.Columns("DeliveryNoteSlNo"))
                    Dim TickSelectedDeliveryNoteDate As Date = view.GetRowCellValue(row, view.Columns("DeliveryDate"))
                    Dim TickSelectedGSCode As String = view.GetRowCellValue(row, view.Columns("GSCode"))

                    'UpdateAvgCostPriceInDeliveryNote(TickSelectedDeliveryNoteNo, TickSelectedDeliveryNoteDate, TickSelectedGSCode)
                    'UpdateAvgCostPriceInDeliveryNoteChild(TickSelectedDeliveryNoteSlNo, TickSelectedDeliveryNoteDate, TickSelectedGSCode)
                    'Get Stock Issue Cost Price - Average Cost Price
                    PostAvgCostPriceToTable(TickSelectedDeliveryNoteDate, TickSelectedGSCode)

                    Dim StockCostAvgPrice As Decimal = frm601_05DeliveryNoteEdit.GetStockIssueCost(TickSelectedGSCode)

                    'Update IssuedUnitPrice for the GSCode of Delivery Note No
                    Me.UpdateIssuedUnitCostPrice(TickSelectedDeliveryNoteSlNo, StockCostAvgPrice)


                End If
            Next

            MessageBox.Show("All Delivery Notes are updated with Cost Price.", "Update Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.SplashScreenManager1.CloseWaitForm()
    End Sub

    Private Function UpdateIssuedUnitCostPrice(ByVal DeliveryNoteSlNo As Integer, ByVal IssuedUnitPrice As Decimal) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl603_02DeliveryNoteChild Set IssuedUnitPrice = '" & IssuedUnitPrice & "' WHERE DeliveryNoteSlNo = '" & DeliveryNoteSlNo & "'"

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

    Private Sub PostAvgCostPriceToTable(ByVal DeliveryDate As Date, ByVal GSCode As String)
        Try

            'Run the Average Cost Definition Table as on the DeliveryDate Value
            InsertStockAverageCost(DeliveryDate, GSCode)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub
End Class