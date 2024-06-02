Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_36SalesOrderItemDetails
    Public frm601_36SalesOrderItemDetailsIsClosed As Boolean
    Public ObjForm As Object

    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnHRLevelCode As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Private SelectedPONo As String = ""
    Private SelectedPODate As Date = Date.Today()


#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If intLogOnInventoryAccessLevel = 99 Then
                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry602_12SalesOrderItemsWithDetailsTableAdapter.FillByDate(Me.Dsfrm601_36SalesOrderItemDetails.qry602_12SalesOrderItemsWithDetails, StartDate, EndDate)
                Else
                    Me.Qry602_12SalesOrderItemsWithDetailsTableAdapter.FillByDateBySalesPersonUserID(Me.Dsfrm601_36SalesOrderItemDetails.qry602_12SalesOrderItemsWithDetails, StartDate, EndDate, Me.intLogOnUserID)
                End If

            Else
                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry602_12SalesOrderItemsWithDetailsTableAdapter.FillByDateByGroup(Me.Dsfrm601_36SalesOrderItemDetails.qry602_12SalesOrderItemsWithDetails, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                Else
                    Me.Qry602_12SalesOrderItemsWithDetailsTableAdapter.FillByDateByGroupBySalesPersonUserID(Me.Dsfrm601_36SalesOrderItemDetails.qry602_12SalesOrderItemsWithDetails, StartDate, EndDate, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Sales Order Items Details.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ShowRecords()
        'Check the Dates are correct
        'Retrieve records
        RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        'Update Tiles
        Me.UpdateFrames()

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

    Private Sub btnBy1stQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy1stQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 1, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 3, 31)

        ShowRecords()
    End Sub

    Private Sub btnBy2ndQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy2ndQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 4, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 6, 30)

        ShowRecords()
    End Sub

    Private Sub btnBy3rdQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy3rdQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 7, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 9, 30)

        ShowRecords()
    End Sub

    Private Sub btnBy4thQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy4thQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 10, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 12, 31)

        ShowRecords()
    End Sub

    Private Sub UpdateFrames()
        'Dim nwTile As TileItem = Me.tilePendingTasks
        ''VAT Invoices Today
        'nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry201_607VATInvoiceRegisterMainViewTableAdapter.GetNoOfVATInvoicesToday())
        ''VAT Invoices Not Verified
        'nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry201_607VATInvoiceRegisterMainViewTableAdapter.GetNoOfInvoiceTodayNotVerified())
        ''VAT Invoices Verified
        'nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry201_607VATInvoiceRegisterMainViewTableAdapter.GetNoOfInvoiceTodayVerified())
    End Sub


    Private Sub btnShowAllRecords_Click_1(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub
#End Region

    Private Sub frm601_14DeliveryDetails_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_36SalesOrderItemDetailsIsClosed = True
    End Sub

    Private Sub btnSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        If Me.gvAdvBandedQuotationView.OptionsView.ShowAutoFilterRow = True Then
            Me.gvAdvBandedQuotationView.OptionsView.ShowAutoFilterRow = False
        Else
            Me.gvAdvBandedQuotationView.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub

    Private Sub btnPrintDatabase_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink3.CreateDocument()
        Me.PrintableComponentLink3.ShowPreview()
    End Sub

    Private Sub btnAllowGrouping_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroup.ItemClick
        If Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = True Then
            Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = False
        Else
            Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = True
        End If
    End Sub


    Private Sub frm20172VATInvoiceWithDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_36SalesOrderItemDetails", Me.gvAdvBandedQuotationView)

    End Sub

    Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
        SaveFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            'My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
            Dim fileName As String = Me.SaveFileDialog1.FileName
            Me.gvAdvBandedQuotationView.SaveLayoutToXml(fileName)
        End If
    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenLayout.ItemClick
        OpenFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Me.OpenFileDialog1.FileName
            Me.gvAdvBandedQuotationView.RestoreLayoutFromXml(fileName)

        End If
    End Sub

    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_36SalesOrderItemDetails"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvAdvBandedQuotationView))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvAdvBandedQuotationView))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_36SalesOrderItemDetails"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class