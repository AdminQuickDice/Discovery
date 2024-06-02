Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_07DeliveryNoteJournalPosting

    Public frm601_07DeliveryNoteJournalPostingIsClosed As Boolean
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
    

    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If Me.intLogOnHRLevelCode = 99 Then
                Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDate(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate)

            Else
                Me.Qry603_04DeliveryNoteViewMasterTableAdapter.FillByDateByType(Me.Dsfrm601_06DeliveryNoteView.qry603_04DeliveryNoteViewMaster, StartDate, EndDate, intLogOnHRLevelCode)

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
        Me.frm601_07DeliveryNoteJournalPostingIsClosed = True
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



    Private Sub btnPostJournal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPostJournal.ItemClick
        Me.SplashScreenManager1.ShowWaitForm()

        Dim view As GridView = gvDeliveryNote
        'If barEditItem1.EditValue IsNot Nothing AndAlso view.SelectedRowsCount > 0 Then
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If view.IsGroupRow(row) Then
                Else

                    'Post all the Selected Delivery Notes to Accounting Books
                    Dim TickSelectedDeliveryNoteNo As String = view.GetRowCellValue(row, view.Columns("DeliveryNoteNo"))
                    Dim TickSelectedDeliveryNoteDate As Date = view.GetRowCellValue(row, view.Columns("DeliveryDate"))
                    Dim TickSelectedDeliveryNoteType As Integer = view.GetRowCellValue(row, view.Columns("DeliveryType"))

                    PostDNToJournal(TickSelectedDeliveryNoteNo, TickSelectedDeliveryNoteDate, TickSelectedDeliveryNoteType)


                End If
            Next

            MessageBox.Show("All Delivery Notes are posted to Journal Books.", "Update Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.SplashScreenManager1.CloseWaitForm()
    End Sub

    Private Sub PostDNToJournal(ByVal DeliveryNoteNo As String, ByVal DeliveryNoteDate As Date, ByVal DeliveryType As Integer)
        'Check if the JV is entered already using VoucherRefNO
        If frm601_05DeliveryNoteEdit.CheckIfDeliveryAlreadyPosted(DeliveryNoteNo) = True Then
            'MessageBox.Show("This Delivery Note is already posted to your ledgers.", "Delivery Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Check if the Delivery Note has Amount to Post
        If frm601_05DeliveryNoteEdit.CheckIfDeliveryHasNoAmount(DeliveryNoteNo) = True Then
            'MessageBox.Show("This Delivery has no amount to be posted, Please review the Delivery Note again.", "No Amount to post", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If CheckIfNull(DeliveryNoteNo) = False Then

                If CheckIfNull(DeliveryType) = False Then

                    'Check if Delivery Type is Store Consumption
                    '
                    If DeliveryType = 2 Then
                        frm601_05DeliveryNoteEdit.PostStoreConsumptionDeliveryJournal(DeliveryNoteNo, DeliveryNoteDate, Me.strLogOnUser)
                        frm601_05DeliveryNoteEdit.UpdatePosted(True, Me.strLogOnUser, DeliveryNoteNo)
                    End If

                    'Check if Delivery Type is Issued to Projects
                    If DeliveryType = 3 Then
                        frm601_05DeliveryNoteEdit.PostProjectDeliveryJournal(DeliveryNoteNo, DeliveryNoteDate, Me.strLogOnUser)
                        frm601_05DeliveryNoteEdit.UpdatePosted(True, Me.strLogOnUser, DeliveryNoteNo)
                    End If

                    'Check if the Voucher is Approved already
                    If frm601_05DeliveryNoteEdit.CheckIfDeliveryNoteIsApproved(DeliveryNoteNo) = False Then
                        frm601_05DeliveryNoteEdit.UpdateApproved(True, Me.strLogOnUser, DeliveryNoteNo)
                    End If

                End If
            Else
                'MessageBox.Show("Please select the Journal Posting to proceed.", "Select Posting for.", MessageBoxButtons.OK)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub

    Private Sub btnApproveAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnApproveAll.ItemClick
        Dim view As GridView = gvDeliveryNote
        'If barEditItem1.EditValue IsNot Nothing AndAlso view.SelectedRowsCount > 0 Then
        If view.SelectedRowsCount > 0 Then
            For Each row As Integer In view.GetSelectedRows()
                If view.IsGroupRow(row) Then
                Else

                    'Approve all the Selected Delivery Notes
                    Dim TickSelectedDeliveryNoteNo As String = view.GetRowCellValue(row, view.Columns("DeliveryNoteNo"))
                    frm601_05DeliveryNoteEdit.UpdateApproved(True, Me.strLogOnUser, TickSelectedDeliveryNoteNo)


                End If
            Next

            MessageBox.Show("All Delivery Notes are Approved", "Approve Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class