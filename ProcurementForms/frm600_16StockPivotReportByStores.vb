Imports DevExpress.XtraPivotGrid

Public Class frm600_16StockPivotReportByStores
    Public ObjForm As Object

    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public frm600_16StockPivotReportByStoresIsClosed As Boolean


    Private Sub frm10105TimesheetLogReporting02_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_16StockPivotReportByStoresIsClosed = True
    End Sub

    Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
        SaveFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            'My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
            Dim fileName As String = Me.SaveFileDialog1.FileName
            Me.pvgProfitLoss.SaveLayoutToXml(fileName)
        End If
    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenLayout.ItemClick
        OpenFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Me.OpenFileDialog1.FileName
            Me.pvgProfitLoss.RestoreLayoutFromXml(fileName)

        End If
    End Sub

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_16StockPivotReportByStores"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromPVG(Me.pvgProfitLoss))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromPVG(Me.pvgProfitLoss))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
        Me.PrintableComponentLink1.PrintingSystem.Document.AutoFitToPagesWidth = 1
    End Sub
    Private Sub frm101_102LeaveList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRecords()


        'TODO: This line of code loads data into the 'Ds101_102LeaveListWtFullDetails.qry101_102LeaveListWtFullDetails' table. You can move, or remove it, as needed.
        LoadLayoutFromDB_PVG(Me.intLogOnUserID, "frm600_16StockPivotReportByStores", Me.pvgProfitLoss)

    End Sub

    Public Sub InsertStoreInventoryValueByDate(ByVal StartDate As Date, ByVal EndDate As Date)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp653_01InsertStoreInvTransByDate"
            Dim paramStartDate As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@StartDate", SqlDbType.DateTime)
            Dim paramEndDate As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@EndDate", SqlDbType.DateTime)

            paramStartDate.Value = StartDate
            paramEndDate.Value = EndDate
            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            'MessageBox.Show("Quotation Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs)
        Me.LoadRecords()

    End Sub

    'Public Sub FillDate()
    '    Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
    '    Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
    'End Sub

    Public Sub LoadRecords()
        Try
            Me.InsertStoreInventoryValueByDate("2001-01-01", Today.AddHours(23))

            Me.Qry653_20StoreStockBalanceWtStoreCodeTableAdapter.Fill(Me.Dsfrm600_16StockPivotReportByStores.qry653_20StoreStockBalanceWtStoreCode)

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Stock Availability for the Sales Order.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        'Check if the user has layout specified... then reset the layout
        Try
            Dim formID As String = "frm600_16StockPivotReportByStores"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowRowTotals_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowRowTotals.ItemClick
        If Me.pvgProfitLoss.OptionsView.ShowRowTotals = True Then
            Me.pvgProfitLoss.OptionsView.ShowRowTotals = False
        Else
            Me.pvgProfitLoss.OptionsView.ShowRowTotals = True
        End If
    End Sub

    Private Sub btnGroup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowFields.ItemClick

        If Me.pvgProfitLoss.OptionsView.ShowDataHeaders = True Then
            Me.pvgProfitLoss.OptionsView.ShowDataHeaders = False
        Else
            Me.pvgProfitLoss.OptionsView.ShowDataHeaders = True
        End If

        If Me.pvgProfitLoss.OptionsView.ShowFilterHeaders = True Then
            Me.pvgProfitLoss.OptionsView.ShowFilterHeaders = False
        Else
            Me.pvgProfitLoss.OptionsView.ShowFilterHeaders = True
        End If
    End Sub


    Private Sub pivotGridControl1_CustomAppearance(ByVal sender As System.Object, ByVal e As PivotCustomAppearanceEventArgs)
        'If e.ColumnField Is fieldTimeSheetDay Then
        '    'If Not e.Value Is Nothing And Convert.ToString(e.Value) = "Fr" Then
        '    If Not e.Value Is Nothing And Convert.ToString(e.Value) = "Fr" Then

        '        e.Appearance.BackColor = Color.Brown
        '        'e.Appearance.FontStyleDelta = FontStyle.Bold
        '    End If
        'End If
    End Sub

    Private Sub PivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As PivotCustomDrawCellEventArgs)
        If e.ColumnValueType = PivotGridValueType.GrandTotal OrElse e.RowValueType = PivotGridValueType.GrandTotal Then
            Dim r As Rectangle
            Dim brushFillTotals As Brush
            brushFillTotals = e.GraphicsCache.GetSolidBrush(ColorTranslator.FromHtml("#0099cc"))
            r = e.Bounds
            e.GraphicsCache.FillRectangle(brushFillTotals, e.Bounds)
            r.Inflate(-4, -4)
            e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font, Brushes.White, r, e.Appearance.GetStringFormat())
            e.Handled = True
        End If


    End Sub

    Private Sub pivotGridControl1_CustomDrawFieldValue(ByVal sender As Object, ByVal e As PivotCustomDrawFieldValueEventArgs)
        'If e.Area = PivotArea.ColumnArea Then
        '    e.Appearance.BackColor = Color.RoyalBlue

        '    'ElseIf e.Area = PivotArea.RowArea Then
        '    '    e.Painter.DrawObject(e.Info)
        '    '    e.Painter.DrawIndicator(e.Info)
        '    '    e.GraphicsCache.FillRectangle(e.GraphicsCache.GetSolidBrush(Color.FromArgb(50, 0, 0, 200)), e.Bounds)
        '    '    e.Handled = True
        'End If
    End Sub
End Class