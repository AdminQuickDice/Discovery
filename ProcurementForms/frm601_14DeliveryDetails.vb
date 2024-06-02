Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI

Public Class frm601_14DeliveryDetails

    Public frm601_14DeliveryDetailsIsClosed As Boolean
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

    Private SelectedDeliveryNoteNo As String = ""
    Private SelectedDeliveryNoteDate As Date = Date.Today()
    Private SelectedDeliveryNoteSlNo As Integer = 0D
    Private SelectedUnitRateMethod As Integer = 0

    Private SelectedStockCode As String = ""

#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If Me.intLogOnHRLevelCode = 99 Then
                If intLogOnInventoryAccessLevel = 99 Then
                    If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDate(Me.Dsfrm601_19DeliveryDetails.qry603_06DeliveryNoteDetails, StartDate, EndDate)
                    Else
                        Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDateBySalesPersonUserID(Me.Dsfrm601_19DeliveryDetails.qry603_06DeliveryNoteDetails, StartDate, EndDate, Me.intLogOnUserID)
                    End If

                Else
                    If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDateByGroup(Me.Dsfrm601_19DeliveryDetails.qry603_06DeliveryNoteDetails, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                    Else
                        Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDateByGroupBySalesPersonUserID(Me.Dsfrm601_19DeliveryDetails.qry603_06DeliveryNoteDetails, StartDate, EndDate, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                    End If


                End If
            Else
                If intLogOnInventoryAccessLevel = 99 Then
                    If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDeliveryType(Me.Dsfrm601_19DeliveryDetails.qry603_06DeliveryNoteDetails, StartDate, EndDate, Me.intLogOnHRLevelCode)
                    Else
                        Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDateByDeliveryTypeBySalesPerson(Me.Dsfrm601_19DeliveryDetails.qry603_06DeliveryNoteDetails, StartDate, EndDate, Me.intLogOnHRLevelCode, Me.intLogOnUserID)
                    End If

                Else
                    If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDeliveryTypeByGroup(Me.Dsfrm601_19DeliveryDetails.qry603_06DeliveryNoteDetails, StartDate, EndDate, Me.intLogOnHRLevelCode, Me.intLogOnInventoryAccessLevel)
                    Else
                        Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByDateByDeliveryTypeByGroupBySalesPersonUserID(Me.Dsfrm601_19DeliveryDetails.qry603_06DeliveryNoteDetails, StartDate, EndDate, Me.intLogOnHRLevelCode, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Delivery Note Register.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Me.frm601_14DeliveryDetailsIsClosed = True
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
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_14DeliveryDetails", Me.gvAdvBandedQuotationView)

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
            Dim formID As String = "frm601_14DeliveryDetails"

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
            Dim formID As String = "frm601_14DeliveryDetails"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEditDeliveryNote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditDeliveryNote.ItemClick
        Me.OpenDeliveryNote(Me.SelectedDeliveryNoteNo)
    End Sub

    Private Sub OpenDeliveryNote(ByVal DeliveryNoteNo As String)
        If CheckIfNull(DeliveryNoteNo) = False Then
            Dim frm601_05DeliveryNoteEdit As New frm601_05DeliveryNoteEdit
            frm601_05DeliveryNoteEdit.ObjForm = Me
            frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
            frm601_05DeliveryNoteEdit.btnSave.Caption = "Update"

            frm601_05DeliveryNoteEdit.strLogonUser = Me.strLogOnUser
            frm601_05DeliveryNoteEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_05DeliveryNoteEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_05DeliveryNoteEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_05DeliveryNoteEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_05DeliveryNoteEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_14DeliveryDetails = True

            ''Post all the Average Cost Price of the Items in the Delivery Note and Update it
            'UpdateAvgCostPriceInDeliveryNote(Me.SelectedDeliveryNoteNo, Me.SelectedDeliveryNoteDate)

            frm601_05DeliveryNoteEdit.Show()
            frm601_05DeliveryNoteEdit.RetrieveDeliveryMaster(DeliveryNoteNo)

            frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
            frm601_05DeliveryNoteEdit.DisableApprovedVoucherEditing(DeliveryNoteNo)
            frm601_05DeliveryNoteEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

        End If
    End Sub

    Private Sub gvAdvBandedQuotationView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvAdvBandedQuotationView.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedDeliveryNoteNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryNoteNo"))

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryDate"))) = False Then
                    SelectedDeliveryNoteDate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryDate"))
                Else
                    SelectedDeliveryNoteDate = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryNoteSlNo"))) = False Then
                    SelectedDeliveryNoteSlNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("DeliveryNoteSlNo"))
                Else
                    SelectedDeliveryNoteSlNo = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("GSCode"))) = False Then
                    SelectedStockCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("GSCode"))
                Else
                    SelectedStockCode = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("UnitRateMethod"))) = False Then
                    SelectedUnitRateMethod = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("UnitRateMethod"))
                Else
                    SelectedUnitRateMethod = 0
                End If

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

    Private Sub btnUpdateUnitCostPrice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUpdateUnitCostPrice.ItemClick
        Try
            'Get Stock Issue Cost Price - Average Cost Price
            PostAvgCostPriceToTable(SelectedDeliveryNoteDate, SelectedStockCode)

            Dim StockCostAvgPrice As Decimal = frm601_05DeliveryNoteEdit.GetStockIssueCost(SelectedStockCode)

            'Update IssuedUnitPrice for the GSCode of Delivery Note No
            'gvInvoiceChild.SetRowCellValue(e.RowHandle, gvInvoiceChild.Columns("IssuedUnitPrice"), StockCostAvgPrice)



            'Get the Unit Converted and Get the Cost Price and multiply it by Unit Converted
            Dim UnitsToConvert As Decimal = GetStockItemBaseUnitsToConvert(SelectedStockCode, SelectedUnitRateMethod)
            Dim CostPrice As Decimal = StockCostAvgPrice
            Dim UnitCostPrice As Decimal = 0D
            UnitCostPrice = UnitsToConvert * CostPrice

            Me.UpdateIssuedUnitCostPrice(SelectedDeliveryNoteSlNo, UnitCostPrice)

            Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)

        Catch ex As Exception

        End Try

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

    Private Sub btnEditStockItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditStockItem.ItemClick
        Try
            If CheckIfNull(Me.SelectedStockCode) = False Then

                Dim frm600_01InventoryStockEdit As New frm600_01InventoryStockEdit
                frm600_01InventoryStockEdit.objForm = Me
                frm600_01InventoryStockEdit.isExecutedFrom_frm600_02InventoryStockView = False

                frm600_01InventoryStockEdit.strLogOnUser = Me.strLogOnUser
                frm600_01InventoryStockEdit.intLogOnUserID = Me.intLogOnUserID
                frm600_01InventoryStockEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                frm600_01InventoryStockEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm600_01InventoryStockEdit.intLogOnDivision = Me.intLogOnDivision
                frm600_01InventoryStockEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                frm600_01InventoryStockEdit.btnSave.Caption = "Update"

                frm600_01InventoryStockEdit.txtStockCode.EditValue = Me.SelectedStockCode
                frm600_01InventoryStockEdit.Show()
                frm600_01InventoryStockEdit.FillDataSetforEditing(Me.SelectedStockCode)
                frm600_01InventoryStockEdit.txtItemName.Focus()

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class