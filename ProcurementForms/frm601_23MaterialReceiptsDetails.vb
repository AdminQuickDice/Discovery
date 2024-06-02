Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI

Public Class frm601_23MaterialReceiptsDetails
    Public frm601_23MaterialReceiptsDetailsIsClosed As Boolean
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

    Private SelectedReceiptNo As String = ""
    Private SelectedReceiptDate As Date = Date.Today()


#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If intLogOnInventoryAccessLevel = 99 Then
                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry605_06MaterailReceiptDetailsTableAdapter.FillByReceiptDate(Me.Dsfrm601_23MaterialReceiptDetails.qry605_06MaterailReceiptDetails, StartDate, EndDate)
                Else
                    Me.Qry605_06MaterailReceiptDetailsTableAdapter.FillByReceiptDateBySalesPersonUserID(Me.Dsfrm601_23MaterialReceiptDetails.qry605_06MaterailReceiptDetails, StartDate, EndDate, Me.intLogOnUserID)
                End If

            Else
                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry605_06MaterailReceiptDetailsTableAdapter.FillByDateByGroup(Me.Dsfrm601_23MaterialReceiptDetails.qry605_06MaterailReceiptDetails, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                Else
                    Me.Qry605_06MaterailReceiptDetailsTableAdapter.FillByReceiptDateByGroupBySalesPersonUserID(Me.Dsfrm601_23MaterialReceiptDetails.qry605_06MaterailReceiptDetails, StartDate, EndDate, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Material Receipt Register.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Me.frm601_23MaterialReceiptsDetailsIsClosed = True
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
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails", Me.gvAdvBandedQuotationView)

        ImplementAccess(Me.intLogOnUserID)

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
            Dim formID As String = "frm601_23MaterialReceiptsDetails"

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
            Dim formID As String = "frm601_23MaterialReceiptsDetails"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvAccountDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvAdvBandedQuotationView.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedReceiptNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ReceiptNo"))

                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEditMaterialReceipt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditMaterialReceipt.ItemClick
        Me.OpenReceipt(Me.SelectedReceiptNo)
    End Sub

    Public Sub OpenReceipt(ByVal ReceiptNo As String)
        If CheckIfNull(ReceiptNo) = False Then
            Dim frm601_09MaterialReceiptEdit As New frm601_09MaterialReceiptEdit
            frm601_09MaterialReceiptEdit.ObjForm = Me
            frm601_09MaterialReceiptEdit.txtReceiptNo.Enabled = False
            frm601_09MaterialReceiptEdit.btnSave.Caption = "Update"


            frm601_09MaterialReceiptEdit.strLogonUser = Me.strLogOnUser
            frm601_09MaterialReceiptEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_09MaterialReceiptEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_09MaterialReceiptEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_09MaterialReceiptEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_09MaterialReceiptEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_09MaterialReceiptEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_09MaterialReceiptEdit.isExecutedFrom_frm601_23MaterialReceiptsDetails = True

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_09MaterialReceiptEdit.txtSalesPerson.Enabled = True
            Else
                frm601_09MaterialReceiptEdit.txtSalesPerson.Enabled = False
            End If

            frm601_09MaterialReceiptEdit.Show()

            frm601_09MaterialReceiptEdit.RetrieveReceiptMaster(ReceiptNo)

            frm601_09MaterialReceiptEdit.txtReceiptNo.Enabled = False
            frm601_09MaterialReceiptEdit.DisableApprovedVoucherEditing(ReceiptNo)
            frm601_09MaterialReceiptEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

        End If
    End Sub

    Public Sub ImplementAccess(ByVal UserID As Integer)
        Try
            If GetUserAccess(UserID, "frm601_23MaterialReceiptsDetails_FullAccess") = True Then
                Me.btnShowAllRecords.Enabled = True
                Me.btnSaveLayout.Enabled = True
                Me.btnOpenLayout.Enabled = True
                Me.btnResetLayout.Enabled = True
                Me.btnSetDefaultLayout.Enabled = True
                Me.btnPrint.Enabled = True
                Me.btnSearch.Enabled = True
                Me.btnGroup.Enabled = True

            Else
                Me.btnShowAllRecords.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails_btnShowAllRecords")
                Me.btnSaveLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails_btnSaveLayout")
                Me.btnOpenLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails_btnOpenLayout")
                Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails_btnResetLayout")
                Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails_btnSetDefaultLayout")
                Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails_btnPrint")
                Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails_btnSearch")
                Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails_btnGroup")

                Dim DisablePriceDetails As Boolean = GetUserAccess(Me.intLogOnUserID, "frm601_23MaterialReceiptsDetails_DisablePriceDetails")
                Me.colUnitPrice.Visible = DisablePriceDetails
                Me.colUnitPrice.OptionsColumn.AllowShowHide = DisablePriceDetails
                Me.colLineTotalBeforeTax.Visible = DisablePriceDetails
                Me.colLineTotalBeforeTax.OptionsColumn.AllowShowHide = DisablePriceDetails
                Me.colLineTotalAfterDisc.Visible = DisablePriceDetails
                Me.colLineTotalAfterDisc.OptionsColumn.AllowShowHide = DisablePriceDetails
                Me.colLineTaxAmount.Visible = DisablePriceDetails
                Me.colLineTaxAmount.OptionsColumn.AllowShowHide = DisablePriceDetails
                Me.colLineTotalWithTax.Visible = DisablePriceDetails
                Me.colLineTotalWithTax.OptionsColumn.AllowShowHide = DisablePriceDetails
                Me.colTotalBeforeTax.Visible = DisablePriceDetails
                Me.colTotalBeforeTax.OptionsColumn.AllowShowHide = DisablePriceDetails
                Me.colTotalDiscount.Visible = DisablePriceDetails
                Me.colTotalDiscount.OptionsColumn.AllowShowHide = DisablePriceDetails
                Me.colTotalAfterDiscount.Visible = DisablePriceDetails
                Me.colTotalAfterDiscount.OptionsColumn.AllowShowHide = DisablePriceDetails
                Me.colTotalTaxAmount.Visible = DisablePriceDetails
                Me.colTotalTaxAmount.OptionsColumn.AllowShowHide = DisablePriceDetails
                Me.colTotalWithTax.Visible = DisablePriceDetails
                Me.colTotalWithTax.OptionsColumn.AllowShowHide = DisablePriceDetails

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class