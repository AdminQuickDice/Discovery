Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI

Public Class frm600_17StockMovementReport
    Public frm600_17StockMovementReportIsClosed As Boolean
    Public ObjForm As Object

    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnHRLevelCode As Integer

    Private SelectedDeliveryNoteNo As String = ""
    Private SelectedDeliveryNoteDate As Date = Date.Today()

    Public IsOnlyOneStockItem As Boolean = False
    Public strStockCode As String = ""

#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal EndDate As Date)
        Try
            If IsOnlyOneStockItem = True Then
                Me.Qry665_MTL_StockMaster_AvgCost03_WtDetail002TableAdapter.FillByCodeByDate(Me.Dsfrm600_17StockMovementReport.qry665_MTL_StockMaster_AvgCost03_WtDetail002, EndDate, strStockCode)
            Else
                Me.Qry665_MTL_StockMaster_AvgCost03_WtDetail002TableAdapter.Fill(Me.Dsfrm600_17StockMovementReport.qry665_MTL_StockMaster_AvgCost03_WtDetail002, EndDate)
            End If

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Inventory By Date.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub ShowRecords()
        'Check the Dates are correct
        'Retrieve records
        RetrieveVoucher(Me.txtEndDate.EditValue)

    End Sub


    Private Sub btnShowAllRecords_Click_1(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub
#End Region

    Private Sub frm601_22InventoryByDate_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_17StockMovementReportIsClosed = True
    End Sub

    Private Sub btnSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        If Me.gvAdvBandedInvoiceView.OptionsView.ShowAutoFilterRow = True Then
            Me.gvAdvBandedInvoiceView.OptionsView.ShowAutoFilterRow = False
        Else
            Me.gvAdvBandedInvoiceView.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub

    Private Sub btnPrintDatabase_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnAllowGrouping_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroup.ItemClick
        If Me.gvAdvBandedInvoiceView.OptionsView.ShowGroupPanel = True Then
            Me.gvAdvBandedInvoiceView.OptionsView.ShowGroupPanel = False
        Else
            Me.gvAdvBandedInvoiceView.OptionsView.ShowGroupPanel = True
        End If
    End Sub


    Private Sub frm20172VATInvoiceWithDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm600_17StockMovementReport", Me.gvAdvBandedInvoiceView)

    End Sub

    Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
        SaveFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            'My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
            Dim fileName As String = Me.SaveFileDialog1.FileName
            Me.gvAdvBandedInvoiceView.SaveLayoutToXml(fileName)
        End If
    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenLayout.ItemClick
        OpenFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Me.OpenFileDialog1.FileName
            Me.gvAdvBandedInvoiceView.RestoreLayoutFromXml(fileName)

        End If
    End Sub

    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_17StockMovementReport"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvAdvBandedInvoiceView))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvAdvBandedInvoiceView))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm600_17StockMovementReport"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class