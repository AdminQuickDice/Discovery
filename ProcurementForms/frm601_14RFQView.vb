Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI


Public Class frm601_14RFQView

    Public frm601_14RFQViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer

    Public intLogOnInventoryMPRAccessLevel As Integer


    Private SelectedRFQNo As String = ""
    Private SelectedRFQDate As Date = Date.Today()
    Private SelectedMPRNo As String = ""


#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If intLogOnInventoryAccessLevel = 99 Then
                If intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry607_04RFQViewMasterTableAdapter.FillByRFQDate(Me.Dsfrm601_14RFQView.qry607_04RFQViewMaster, StartDate, EndDate)
                Else
                    Me.Qry607_04RFQViewMasterTableAdapter.FillByRFQDateAndSalesPersonCode(Me.Dsfrm601_14RFQView.qry607_04RFQViewMaster, StartDate, EndDate, Me.intLogOnUserID)
                End If

            Else

                If intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry607_04RFQViewMasterTableAdapter.FillByRFQDateByGroup(Me.Dsfrm601_14RFQView.qry607_04RFQViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                Else
                    Me.Qry607_04RFQViewMasterTableAdapter.FillByRFQDateByGroupBySalesPerson(Me.Dsfrm601_14RFQView.qry607_04RFQViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                End If


            End If

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving RFQ List.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Public Sub UpdateFrames()
        'Dim nwTile As TileItem = Me.tilePendingTasks
        ''VAT Invoices Today
        'nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry201_607VATInvoiceRegisterMainViewTableAdapter.GetNoOfVATInvoicesToday())
        ''VAT Invoices Not Verified
        'nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry201_607VATInvoiceRegisterMainViewTableAdapter.GetNoOfInvoiceTodayNotVerified())
        ''VAT Invoices Verified
        'nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry201_607VATInvoiceRegisterMainViewTableAdapter.GetNoOfInvoiceTodayVerified())


        Dim nwTile3 As TileItem = Me.tileAllAssets
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry607_04RFQViewMasterTableAdapter.GetNoOfRFQs(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue))
        Else
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry607_04RFQViewMasterTableAdapter.GetNoOfRFQsByGroup(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, Me.intLogOnInventoryAccessLevel))
        End If



    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub

#End Region

    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_14RFQViewIsClosed = True
    End Sub

    Private Sub btnSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        If Me.gvAdvBandedQuotationView.OptionsView.ShowAutoFilterRow = True Then
            Me.gvAdvBandedQuotationView.OptionsView.ShowAutoFilterRow = False
        Else
            Me.gvAdvBandedQuotationView.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub

    Private Sub btnPrintDatabase_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnAllowGrouping_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroup.ItemClick
        If Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = True Then
            Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = False
        Else
            Me.gvAdvBandedQuotationView.OptionsView.ShowGroupPanel = True
        End If
    End Sub

    Private Sub gvAccountDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvAdvBandedQuotationView.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedRFQNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("RFQNo"))

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("RFQDate"))) = False Then
                    SelectedRFQDate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("RFQDate"))
                Else
                    SelectedRFQDate = ""
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("MPRNo"))) = False Then
                    SelectedMPRNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("MPRNo"))
                Else
                    SelectedMPRNo = ""
                End If


                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenRFQ(ByVal RFQNo As String)
        If CheckIfNull(RFQNo) = False Then
            Dim frm601_13RFQMaster As New frm601_13RFQMaster
            frm601_13RFQMaster.ObjForm = Me
            frm601_13RFQMaster.txtRFQNo.Enabled = False
            frm601_13RFQMaster.btnSave.Caption = "Update"


            frm601_13RFQMaster.strLogonUser = Me.strLogOnUser
            frm601_13RFQMaster.intLogOnUserID = Me.intLogOnUserID
            frm601_13RFQMaster.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_13RFQMaster.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_13RFQMaster.intLogOnDivision = Me.intLogOnDivision
            frm601_13RFQMaster.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_13RFQMaster.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
            frm601_13RFQMaster.isExecutedFrom_frm601_14RFQView = True

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_13RFQMaster.txtSalesPerson.Enabled = True
            Else
                frm601_13RFQMaster.txtSalesPerson.Enabled = False
            End If

            frm601_13RFQMaster.Show()
            frm601_13RFQMaster.RetrieveRFQMaster(RFQNo)

            frm601_13RFQMaster.txtRFQNo.Enabled = False
            frm601_13RFQMaster.DisableApprovedVoucherEditing(RFQNo)
            frm601_13RFQMaster.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

            If CheckIfRFQIsSubmitted(Me.SelectedRFQNo) = True Then
                'frm601_11PurchaseRequestEdit.DisableAllControls()
                'frm601_11PurchaseRequestEdit.ImplementAccessLevel()
                frm601_13RFQMaster.btnSubmit.Enabled = False
            End If

            If CheckIfRFQIsVerified(Me.SelectedRFQNo) = True Then
                'frm601_11PurchaseRequestEdit.DisableAllControls()
                'frm601_11PurchaseRequestEdit.ImplementAccessLevel()
                frm601_13RFQMaster.btnSubmit.Enabled = False
                frm601_13RFQMaster.btnVerify.Enabled = False
            End If

            If CheckIfRFQIsApproved(Me.SelectedRFQNo) = True Then
                frm601_13RFQMaster.DisableAllControls()
                frm601_13RFQMaster.btnSubmit.Enabled = False
                frm601_13RFQMaster.btnVerify.Enabled = False
                frm601_13RFQMaster.btnApprove.Enabled = False
            End If

            If CheckIfRFQHasPO(Me.SelectedRFQNo) = True Then
                frm601_13RFQMaster.DisableAllControls()
            End If

        End If
    End Sub

    Private Function CheckIfRFQIsSubmitted(ByVal RFQNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select RFQNo from tbl607_01RFQMaster where (RFQNo = '" & RFQNo & "') and (Isnull(IsSubmitted,0) = 1 )"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Function CheckIfRFQIsVerified(ByVal RFQNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select RFQNo from tbl607_01RFQMaster where (RFQNo = '" & RFQNo & "') and (Isnull(IsVerified,0) = 1 )"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    'Private Function CheckIfRFQIsApproved(ByVal RFQNo As String) As Boolean
    '    Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
    '    Try
    '        If Sqlconnection1.State = ConnectionState.Closed Then
    '            Sqlconnection1.Open()
    '        End If
    '        Dim strSqlQueryText As String
    '        strSqlQueryText = "Select RFQNo from tbl607_01RFQMaster where (RFQNo = '" & RFQNo & "') and (Isnull(IsApproved,0) = 1 )"

    '        Dim SqlCommand1 As New SqlClient.SqlCommand
    '        SqlCommand1.Connection = Sqlconnection1
    '        SqlCommand1.CommandText = strSqlQueryText
    '        Dim srStockReader As SqlClient.SqlDataReader
    '        srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

    '        If srStockReader.HasRows() Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '        srStockReader.Close()
    '    Catch ex As Exception
    '        MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
    '        Return False
    '    Finally
    '        Sqlconnection1.Close()
    '    End Try

    'End Function

    Private Sub btnPopupEditQuotation_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditRFQ.ItemClick
        Me.OpenRFQ(Me.SelectedRFQNo)
    End Sub

    Private Sub repoQuoteNo_Click(sender As Object, e As EventArgs) Handles repoQuoteNo.Click
        Dim strReceiptNo As String = Me.gvAdvBandedQuotationView.GetRowCellValue(Me.gvAdvBandedQuotationView.FocusedRowHandle, "RFQNo")
        If CheckIfNull(strReceiptNo) = True Then
            MessageBox.Show("Please select the RFQ No. to edit.", "Select RFQ No. to edit", MessageBoxButtons.OK)
        Else
            Me.OpenRFQ(strReceiptNo)
        End If
    End Sub

    Private Sub btnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteRFQ.ItemClick
        Try
            'Check if the Voucher is approved already
            If CheckIfRFQIsApproved(Me.SelectedRFQNo) = True Then
                MessageBox.Show("RFQ is already approved, You cannot delete the Approved Request/Enquiry.", "RFQ is Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            If CheckIfRFQHasPO(Me.SelectedRFQNo) = True Then
                MessageBox.Show("RFQ has related Purchase Order Issued, You cannot delete the RFQ.", "RFQ has Purchase Order Issued", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the RFQ from the Register," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedRFQNo) = False Then
                    If DeleteRFQ(Me.SelectedRFQNo) = True Then
                        MessageBox.Show("RFQ has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS RFQ", "IMS RFQ Ref No." & Me.SelectedRFQNo & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedRFQNo)

                        'Refresh the datagrid
                        Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
                    Else
                        MessageBox.Show("Deleting Failed, please try again.", "Delete Failed", MessageBoxButtons.OK)
                    End If
                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function CheckIfRFQIsApproved(ByVal RFQNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select RFQNo from tbl607_01RFQMaster where (RFQNo = '" & RFQNo & "') and (Isnull(IsApproved,0) = 1 )"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function
    Private Function DeleteRFQ(ByVal RFQNo As String) As Boolean
        Dim myTrans As System.Data.SqlClient.SqlTransaction

        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)

        If Sqlconnection1.State = ConnectionState.Closed Then
            Sqlconnection1.Open()
        End If

        Dim delPRTrans As New SqlClient.SqlCommand
        myTrans = Sqlconnection1.BeginTransaction(IsolationLevel.ReadCommitted, "PRTransaction")
        delPRTrans.Connection = Sqlconnection1
        delPRTrans.Transaction = myTrans
        Try

            delPRTrans.CommandText = "DELETE from tbl607_01RFQMaster WHERE RFQNo   = '" & RFQNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl607_02RFQChild WHERE RFQNo   = '" & RFQNo & "'"
            delPRTrans.ExecuteNonQuery()
            myTrans.Commit()
            Return True

        Catch ex As Exception
            Try
                myTrans.Rollback("PRTransaction")
                Return False
            Catch Sqlex As System.Data.SqlClient.SqlException
                If Not myTrans.Connection Is Nothing Then
                    MessageBox.Show("An exception of type " & Sqlex.GetType().ToString() & _
                                      " was encountered while attempting to roll back the transaction.", "Error on Delete", MessageBoxButtons.OK)
                End If
                MessageBox.Show("An exception of type " & ex.GetType().ToString() & _
                                      "was encountered while inserting the data.")
                Return False
            End Try
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub btnAddNewRFQ_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewRFQ.ItemClick
        Dim frm601_13RFQMaster As New frm601_13RFQMaster
        frm601_13RFQMaster.ObjForm = Me

        frm601_13RFQMaster.btnSave.Caption = "Save"
        frm601_13RFQMaster.isBeingNew = True


        frm601_13RFQMaster.strLogonUser = Me.strLogOnUser
        frm601_13RFQMaster.intLogOnUserID = Me.intLogOnUserID
        frm601_13RFQMaster.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_13RFQMaster.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_13RFQMaster.intLogOnDivision = Me.intLogOnDivision
        frm601_13RFQMaster.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel

        frm601_13RFQMaster.isExecutedFrom_frm601_14RFQView = True

        Dim SalesPersonCode As String = ""
        SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

        If Me.intLogOnInventoryMPRAccessLevel = 99 Then
            frm601_13RFQMaster.txtSalesPerson.Enabled = True
        Else
            frm601_13RFQMaster.txtSalesPerson.Enabled = False
        End If

        frm601_13RFQMaster.Show()

        GetCompanyDetails(1)
        Dim NewRFQNo As String = frm601_13RFQMaster.GetNewRFQNo(gRFQAbbrv, gInvoiceYearDigits)

        frm601_13RFQMaster.CreatedNewRFQNo = NewRFQNo
        frm601_13RFQMaster.NewRFQMaster(NewRFQNo)
        frm601_13RFQMaster.txtRFQNo.EditValue = NewRFQNo
        frm601_13RFQMaster.txtRFQDate.EditValue = Date.Today
        frm601_13RFQMaster.UpdateDefaultFields()

    End Sub

    Private Sub btnUnlockInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnlockRFQ.ItemClick
        If Me.intLogOnUserLevel = 99 Then
            Me.UnlockTheRFQ(Me.SelectedRFQNo)
            MessageBox.Show("RFQ has been unlocked successfully.", "RFQ Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Refresh the screen
            Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        Else
            MessageBox.Show("Your user access level cannot unlock the RFQ, Please review again.", "Access Permission Denied.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If

    End Sub

    Private Function UnlockTheRFQ(ByVal RFQNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl607_01RFQMaster Set IsApproved = 0, ApprovedBy = ''  where RFQNo = '" & RFQNo & "'"

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

    Private Sub frm601_04SalesOrderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords()

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_14RFQView", Me.gvAdvBandedQuotationView)


        ImplementAccess()
    End Sub

    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_14RFQView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvAdvBandedQuotationView))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvAdvBandedQuotationView))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
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

    


#Region "Create PO"

    Private Sub btnCreatePO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreatePO.ItemClick

        'Check if the PO is already Created...
        'CheckIfRFQHasPO
        If CheckIfRFQHasPO(Me.SelectedRFQNo) = True Then
            MessageBox.Show("RFQ has already been converted to PO, Please review the Purchase Order.", "RFQ has converted to PO", MessageBoxButtons.OK)
            Exit Sub

        End If


        DialogResult = MessageBox.Show("You are about to create new Purchase Order." & vbCrLf & "Are you Sure want to continue creating Purchase Order?", "Confirm creating Purchase Order.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedRFQNo) = False Then

                'Get New PO Number
                GetCompanyDetails(1)
                GetCompanyDetails02(1)

                Dim NewPONo As String

                If Me.intLogOnInventoryAccessLevel = 99 Then
                    NewPONo = frm601_07PurchaseOrderEdit.GetNewPONo(gPurchaseOrderAbbrv, gInvoiceYearDigits, Date.Now, gIsResetPOInYear, gNoOfDigitsToInventoryPO, gIsUseNewSequencePONoForGroup)
                Else
                    Dim PONumberSeqForGroup As String = GetPONoSequenceForGroup(Me.intLogOnInventoryAccessLevel)
                    NewPONo = frm601_07PurchaseOrderEdit.GetNewPONo(PONumberSeqForGroup, gInvoiceYearDigits, Date.Now, gIsResetPOInYear, gNoOfDigitsToInventoryPO, gIsUseNewSequencePONoForGroup)
                End If

                Me.CreatePO(NewPONo, Me.SelectedRFQNo, Me.strLogOnUser)

                If CheckIfNull(Me.SelectedMPRNo) = False Then
                    'Set the status to Purchase Order Issued
                    frm601_12PurchaseRequestView.UpdateStatusOfMPR(Me.SelectedMPRNo, 6)
                End If
                Me.OpenPO(NewPONo)
            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub


    Private Sub CreatePO(ByVal PONo As String, ByVal RFQNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_02InsertToPOfromRFQ"
            Dim paramPONo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@PONo", SqlDbType.VarChar)
            Dim paramRFQNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@RFQNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramPONo.Value = PONo
            paramRFQNo.Value = RFQNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Purchase Order is created successfully,", "PO created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("PO Creation failed, Please try again", "RFQ Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub OpenPO(ByVal PONo As String)
        If CheckIfNull(PONo) = False Then
            Dim frm601_07PurchaseOrderEdit As New frm601_07PurchaseOrderEdit
            frm601_07PurchaseOrderEdit.ObjForm = Me
            frm601_07PurchaseOrderEdit.txtPONo.Enabled = False
            frm601_07PurchaseOrderEdit.btnSave.Caption = "Update"


            frm601_07PurchaseOrderEdit.strLogonUser = Me.strLogOnUser
            frm601_07PurchaseOrderEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_07PurchaseOrderEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_07PurchaseOrderEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_07PurchaseOrderEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_07PurchaseOrderEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_07PurchaseOrderEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
            frm601_07PurchaseOrderEdit.isExecutedFrom_frm601_14RFQView = True

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_07PurchaseOrderEdit.txtSalesPerson.Enabled = True
            Else
                frm601_07PurchaseOrderEdit.txtSalesPerson.Enabled = False
            End If

            frm601_07PurchaseOrderEdit.Show()

            frm601_07PurchaseOrderEdit.RetrievePOMaster(PONo)

            frm601_07PurchaseOrderEdit.txtPONo.Enabled = False
            frm601_07PurchaseOrderEdit.DisableApprovedVoucherEditing(PONo)
            frm601_07PurchaseOrderEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

            If GetPurchaseOrderCurrency(PONo) = 1 Then
                frm601_07PurchaseOrderEdit.IsVisibleOC = False
            Else
                frm601_07PurchaseOrderEdit.IsVisibleOC = True
            End If
            frm601_07PurchaseOrderEdit.SwitchColumns()

            frm601_07PurchaseOrderEdit.ImplementAccess(Me.intLogOnUserID)

            'If Me.SelectedIsSubmitted = True Then
            '    frm601_07PurchaseOrderEdit.DisableAllControls()
            '    frm601_07PurchaseOrderEdit.btnSubmit.Enabled = False

            '    If Me.SelectedIsVerified = False And Me.SelectedIsApproved = False Then
            '        'Check if the User is allowed to verify the PO
            '        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_btnVerify") = True Then
            '            frm601_07PurchaseOrderEdit.EnableAllControls()
            '            frm601_07PurchaseOrderEdit.btnSubmit.Enabled = False
            '            frm601_07PurchaseOrderEdit.btnVerify.Enabled = True
            '            frm601_07PurchaseOrderEdit.btnApprove.Enabled = False
            '        End If
            '    End If
            'End If

            'If Me.SelectedIsVerified = True Then
            '    frm601_07PurchaseOrderEdit.DisableAllControls()
            '    frm601_07PurchaseOrderEdit.btnSubmit.Enabled = False
            '    frm601_07PurchaseOrderEdit.btnVerify.Enabled = False

            '    If Me.SelectedIsApproved = False Then
            '        'Check if the User is allowed to Approve the PO
            '        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_btnApprove") = True Then
            '            frm601_07PurchaseOrderEdit.EnableAllControls()
            '            frm601_07PurchaseOrderEdit.btnSubmit.Enabled = False
            '            frm601_07PurchaseOrderEdit.btnVerify.Enabled = False
            '            frm601_07PurchaseOrderEdit.btnApprove.Enabled = True
            '        End If
            '    End If
            'End If

            'If Me.SelectedIsApproved = True Then
            '    frm601_07PurchaseOrderEdit.DisableAllControls()
            'End If
        End If
    End Sub


#End Region

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_14RFQView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Public Function CheckIfRFQHasPO(ByVal RFQNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select RFQNo from qry607_04RFQViewMaster where (RFQNo = '" & RFQNo & "') and (Isnull(PONo,'') <> '' )"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub btnRFQDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRFQDetails.ItemClick
        Try
            Dim frm601_40RFQItemDetails As New frm601_40RFQItemDetails
            frm601_40RFQItemDetails.ObjForm = Me

            frm601_40RFQItemDetails.strLogOnUser = Me.strLogOnUser
            frm601_40RFQItemDetails.intLogOnUserID = Me.intLogOnUserID
            frm601_40RFQItemDetails.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_40RFQItemDetails.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_40RFQItemDetails.intLogOnDivision = Me.intLogOnDivision
            'frm601_40RFQItemDetails.intLogOnHRLevelCode = Me.intLogOnHRLevelCode
            frm601_40RFQItemDetails.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel

            frm601_40RFQItemDetails.txtStartDate.EditValue = Me.txtStartDate.EditValue
            frm601_40RFQItemDetails.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm601_40RFQItemDetails.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ImplementAccess()
        Try
            If GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_FullAccess") = True Then

                Me.btnEditRFQ.Enabled = True
                Me.btnDeleteRFQ.Enabled = True
                Me.btnUnlockRFQ.Enabled = True
                Me.btnCreatePO.Enabled = True
                Me.btnSaveLayout.Enabled = True
                Me.btnOpenLayout.Enabled = True
                Me.btnResetLayout.Enabled = True
                Me.btnSetDefaultLayout.Enabled = True
                Me.btnPrint.Enabled = True
                Me.btnSearch.Enabled = True
                Me.btnGroup.Enabled = True
                Me.btnRFQDetails.Enabled = True
                Me.btnAddNewRFQ.Enabled = True
                Me.btnShowAllRecords.Enabled = True


            Else
                Me.btnEditRFQ.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnEditRFQ")
                Me.btnDeleteRFQ.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnDeleteRFQ")
                Me.btnUnlockRFQ.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnUnlockRFQ")
                Me.btnCreatePO.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnCreatePO")
                Me.btnSaveLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnSaveLayout")
                Me.btnOpenLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnOpenLayout")
                Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnResetLayout")
                Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnSetDefaultLayout")
                Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnPrint")
                Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnSearch")
                Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnGroup")
                Me.btnRFQDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnRFQDetails")
                Me.btnAddNewRFQ.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnAddNewRFQ")
                Me.btnShowAllRecords.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_14RFQView_btnShowAllRecords")

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class