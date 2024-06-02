Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_12PurchaseRequestView
    Public frm601_12PurchaseRequestViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Public intLogOnHRLevelCode As Integer

    Private SelectedPurchaseRequestNo As String = ""
    Private SelectedPurchaseRequestDate As Date = Date.Today()

    Private SelectedRequestedBy As Integer = 1

    Public SelectedRequestedType As Integer = 99
    Public SelectedIsSubmitted As Boolean
    Public SelectedIsVerified As Boolean
    Public SelectedIsApproved As Boolean
    Public SelectedIsCancelled As Boolean

    Public SelectedRequestedVATSlabCode As Integer = 8

#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date, ByVal RequestedType As Integer)
        Try
            If RequestedType = 99 Then
                If intLogOnInventoryAccessLevel = 99 Then
                    If intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry606_04PurchaseRequestViewMasterTableAdapter.FillByMPRDate(Me.Dsfrm601_12PurchaseRequestView.qry606_04PurchaseRequestViewMaster, StartDate, EndDate)
                    Else
                        Me.Qry606_04PurchaseRequestViewMasterTableAdapter.FillByMPRDateAndSalesPerson(Me.Dsfrm601_12PurchaseRequestView.qry606_04PurchaseRequestViewMaster, StartDate, EndDate, Me.intLogOnUserID)
                    End If
                Else
                    If intLogOnInventoryMPRAccessLevel = 99 Then
                        Me.Qry606_04PurchaseRequestViewMasterTableAdapter.FillByMPRDateByGroup(Me.Dsfrm601_12PurchaseRequestView.qry606_04PurchaseRequestViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                    Else
                        'ByMPRDateByGroupAndSalesPerson
                        Me.Qry606_04PurchaseRequestViewMasterTableAdapter.FillByMPRDateByGroupAndSalesPerson(Me.Dsfrm601_12PurchaseRequestView.qry606_04PurchaseRequestViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                    End If

                End If

            Else
                If intLogOnInventoryAccessLevel = 99 Then
                    Me.Qry606_04PurchaseRequestViewMasterTableAdapter.FillByRequestType(Me.Dsfrm601_12PurchaseRequestView.qry606_04PurchaseRequestViewMaster, StartDate, EndDate, RequestedType)
                Else
                    Me.Qry606_04PurchaseRequestViewMasterTableAdapter.FillByRequestTypeByGroup(Me.Dsfrm601_12PurchaseRequestView.qry606_04PurchaseRequestViewMaster, StartDate, EndDate, RequestedType, Me.intLogOnInventoryAccessLevel)
                End If


            End If


        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Request's / Enquiries Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ShowRecords(ByVal RequestedType As Integer)
        'Check the Dates are correct
        'Retrieve records
        RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, RequestedType)
        'Update Tiles
        Me.UpdateFrames()

    End Sub

    Private Sub btnToday_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnToday.ItemClick
        Me.txtStartDate.EditValue = Date.Today
        Me.txtEndDate.EditValue = Date.Today
        ShowRecords(SelectedRequestedType)
    End Sub

    Private Sub btnYesterday_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnYesterday.ItemClick
        Me.txtStartDate.EditValue = DateAdd(DateInterval.Day, -1, Date.Today)
        Me.txtEndDate.EditValue = DateAdd(DateInterval.Day, -1, Date.Today)
        ShowRecords(SelectedRequestedType)
    End Sub


    'this week
    Private Sub btnThisWeek_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisWeek.ItemClick
        Dim today As Date = Date.Today
        Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Saturday
        Dim SaturDay As Date = today.AddDays(-dayDiff)

        Me.txtStartDate.EditValue = DateAdd(DateInterval.Day, -7, SaturDay)
        Me.txtEndDate.EditValue = DateAdd(DateInterval.Day, -1, SaturDay)

        ShowRecords(SelectedRequestedType)
    End Sub

    Private Sub btnThisYearTillDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisYearTillDate.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 1, 1)
        Me.txtEndDate.EditValue = Date.Today
        ShowRecords(SelectedRequestedType)
    End Sub

    'this year full
    Private Sub btnThisYearfull_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisYear.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 1, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords(SelectedRequestedType)

    End Sub

    Private Sub btnThisMonthTillDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisMonthTillDate.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = Date.Today
        ShowRecords(SelectedRequestedType)
    End Sub

    'this month
    Private Sub btnFillThisMonth_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThisMonthFull.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords(SelectedRequestedType)
    End Sub

    'Last Year
    Private Sub btnLastYear_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLastYear.ItemClick
        Dim LastYearDate As Date = DateAdd(DateInterval.Year, -1, Date.Today)
        Me.txtStartDate.EditValue = DateSerial(LastYearDate.Year, 1, 1)
        Me.txtEndDate.EditValue = DateSerial(LastYearDate.Year, 12, 31)
        ShowRecords(SelectedRequestedType)

    End Sub


    Private Sub btnLastMonth_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLastMonth.ItemClick
        Dim LastMonthThisDate As Date = DateAdd(DateInterval.Month, -1, Date.Today)

        Me.txtStartDate.EditValue = DateSerial(LastMonthThisDate.Year, LastMonthThisDate.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(LastMonthThisDate.Year, LastMonthThisDate.Month, Date.DaysInMonth(LastMonthThisDate.Year, LastMonthThisDate.Month))

        ShowRecords(SelectedRequestedType)
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
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry606_04PurchaseRequestViewMasterTableAdapter.GetNoOfRequests(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue))
        Else
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry606_04PurchaseRequestViewMasterTableAdapter.GetNoOfRequestsByGroup(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, Me.intLogOnInventoryAccessLevel))
        End If

    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords(SelectedRequestedType)
    End Sub

#End Region

    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_12PurchaseRequestViewIsClosed = True
    End Sub

    Private Sub btnSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        If Me.gvAdvBandedQuotationView2.OptionsView.ShowAutoFilterRow = True Then
            Me.gvAdvBandedQuotationView2.OptionsView.ShowAutoFilterRow = False
        Else
            Me.gvAdvBandedQuotationView2.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub

    Private Sub btnPrintDatabase_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnAllowGrouping_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroup.ItemClick
        If Me.gvAdvBandedQuotationView2.OptionsView.ShowGroupPanel = True Then
            Me.gvAdvBandedQuotationView2.OptionsView.ShowGroupPanel = False
        Else
            Me.gvAdvBandedQuotationView2.OptionsView.ShowGroupPanel = True
        End If
    End Sub

    Private Sub gvAccountDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvAdvBandedQuotationView2.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedPurchaseRequestNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("MPRNo"))
                SelectedPurchaseRequestDate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("MPRDate"))

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("TypeOfMPR"))) = False Then
                    SelectedRequestedBy = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("TypeOfMPR"))
                Else
                    SelectedRequestedBy = 0
                End If

                If SelectedRequestedBy = 4 Then
                    Me.btnCreateMaterialIssueNote.Enabled = True
                Else
                    Me.btnCreateMaterialIssueNote.Enabled = False
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsSubmitted"))) = False Then
                    SelectedIsSubmitted = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsSubmitted"))
                Else
                    SelectedIsSubmitted = False
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsVerified"))) = False Then
                    SelectedIsVerified = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsVerified"))
                Else
                    SelectedIsVerified = False
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsApproved"))) = False Then
                    SelectedIsApproved = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsApproved"))
                Else
                    SelectedIsApproved = False
                End If

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsCancelled"))) = False Then
                    SelectedIsCancelled = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("IsCancelled"))
                Else
                    SelectedIsCancelled = False
                End If

                If SelectedIsCancelled = True Then
                    LockButtonsForCancelled(True)
                Else
                    LockButtonsForCancelled(False)
                End If

                '
                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ExpectedVATRate"))) = False Then
                    SelectedRequestedVATSlabCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ExpectedVATRate"))
                Else
                    GetCompanyDetails(1)
                    If gCurrencyType = "BHD" Then
                        SelectedRequestedVATSlabCode = 10
                    ElseIf gCurrencyType = "AED" Then
                        SelectedRequestedVATSlabCode = 1
                    Else
                        SelectedRequestedVATSlabCode = 8
                    End If

                End If

                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub OpenPR(ByVal MPRNo As String)
        If CheckIfNull(MPRNo) = False Then
            Dim frm601_11PurchaseRequestEdit As New frm601_11PurchaseRequestEdit
            frm601_11PurchaseRequestEdit.ObjForm = Me
            frm601_11PurchaseRequestEdit.txtRequestNo.Enabled = False
            frm601_11PurchaseRequestEdit.btnSave.Caption = "Update"

            frm601_11PurchaseRequestEdit.strLogonUser = Me.strLogOnUser
            frm601_11PurchaseRequestEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_11PurchaseRequestEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_11PurchaseRequestEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_11PurchaseRequestEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_11PurchaseRequestEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_11PurchaseRequestEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
            frm601_11PurchaseRequestEdit.isExecutedFrom_frm601_12PurchaseRequestView = True

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_11PurchaseRequestEdit.txtSalesPerson.Enabled = True
            Else
                frm601_11PurchaseRequestEdit.txtSalesPerson.Enabled = False
            End If

            frm601_11PurchaseRequestEdit.Show()

            frm601_11PurchaseRequestEdit.RetrieveRequestMaster(MPRNo)

            frm601_11PurchaseRequestEdit.txtRequestNo.Enabled = False

            frm601_11PurchaseRequestEdit.DisableControlsForRequestType(Me.SelectedRequestedBy)
            frm601_11PurchaseRequestEdit.DisableApprovedVoucherEditing(MPRNo)
            frm601_11PurchaseRequestEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)


            If CheckIfPRIsSubmitted(Me.SelectedPurchaseRequestNo) = True Then

                frm601_11PurchaseRequestEdit.DisableAllControls()
                frm601_11PurchaseRequestEdit.btnSubmit.Enabled = False

                If Me.SelectedIsVerified = False And Me.SelectedIsApproved = False Then
                    'Check if the User is allowed to verify the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnVerify") = True Then
                        frm601_11PurchaseRequestEdit.EnableAllControls()
                        frm601_11PurchaseRequestEdit.btnSubmit.Enabled = False
                        frm601_11PurchaseRequestEdit.btnVerify.Enabled = True

                        frm601_11PurchaseRequestEdit.btnVerifyTheRequest.Enabled = True
                        frm601_11PurchaseRequestEdit.btnCancelRequestByVerifier.Enabled = True
                        frm601_11PurchaseRequestEdit.txtRemarksByVerifier.Enabled = True

                        frm601_11PurchaseRequestEdit.btnApprove.Enabled = False
                    End If
                End If

            End If

            If CheckIfPRIsVerified(Me.SelectedPurchaseRequestNo) = True Then
                frm601_11PurchaseRequestEdit.DisableAllControls()
                frm601_11PurchaseRequestEdit.btnSubmit.Enabled = False
                frm601_11PurchaseRequestEdit.btnVerify.Enabled = False

                If Me.SelectedIsApproved = False Then
                    'Check if the User is allowed to Approve the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_11PurchaseRequestEdit_btnApprove") = True Then
                        frm601_11PurchaseRequestEdit.EnableAllControls()
                        frm601_11PurchaseRequestEdit.btnSubmit.Enabled = False
                        frm601_11PurchaseRequestEdit.btnVerify.Enabled = False
                        frm601_11PurchaseRequestEdit.btnApprove.Enabled = True

                        frm601_11PurchaseRequestEdit.btnApproveRequest.Enabled = True
                        frm601_11PurchaseRequestEdit.btnCancelRequest.Enabled = True
                        frm601_11PurchaseRequestEdit.txtRemarksByApprover.Enabled = True

                    End If
                End If
            End If

            If CheckIfPRIsApproved(Me.SelectedPurchaseRequestNo) = True Then
                frm601_11PurchaseRequestEdit.DisableAllControls()

            End If

        End If
    End Sub
    Private Sub btnPopupEditQuotation_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditRequest.ItemClick
        Me.OpenPR(Me.SelectedPurchaseRequestNo)
    End Sub

    Private Sub repoQuoteNo_Click(sender As Object, e As EventArgs) Handles repoQuoteNo.Click
        Dim strReceiptNo As String = Me.gvAdvBandedQuotationView2.GetRowCellValue(Me.gvAdvBandedQuotationView2.FocusedRowHandle, "MPRNo")
        If CheckIfNull(strReceiptNo) = True Then
            MessageBox.Show("Please select the Request/Enquiry No. to edit.", "Select Request/Enquiry No. to edit", MessageBoxButtons.OK)
        Else
            Me.OpenPR(strReceiptNo)
        End If
    End Sub

    Private Sub btnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteRequest.ItemClick
        Try
            'Check if the Voucher is Submitted already
            If CheckIfPRIsSubmitted(Me.SelectedPurchaseRequestNo) = True Then
                MessageBox.Show("Request/Enquiry is already Submitted, You cannot delete the Submitted Request/Enquiry.", "Request/Enquiry is Submitted", MessageBoxButtons.OK)
                Exit Sub

            End If

            'Check if the Voucher is approved already
            If CheckIfPRIsApproved(Me.SelectedPurchaseRequestNo) = True Then
                MessageBox.Show("Request/Enquiry is already approved, You cannot delete the Approved Request/Enquiry.", "Request/Enquiry is Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Request/Enquiry from the Register," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedPurchaseRequestNo) = False Then
                    If DeletePR(Me.SelectedPurchaseRequestNo) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.SelectedPurchaseRequestNo, "VoucherScanned\IMSEnquiry")

                        MessageBox.Show("Request/Enquiry has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Purchase Request", "IMS Purchase Request Ref No." & Me.SelectedPurchaseRequestNo & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedPurchaseRequestNo)

                        'Refresh the datagrid
                        Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, SelectedRequestedType)
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


    Private Function CheckIfPRIsSubmitted(ByVal MPRNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select MPRNo from tbl606_01PurchaseRequestMaster where (MPRNo = '" & MPRNo & "') and (Isnull(IsSubmitted,0) = 1 )"

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


    Private Function CheckIfPRIsVerified(ByVal MPRNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select MPRNo from tbl606_01PurchaseRequestMaster where (MPRNo = '" & MPRNo & "') and (Isnull(IsVerified,0) = 1 )"

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

    Public Function CheckIfPRIsApproved(ByVal MPRNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select MPRNo from tbl606_01PurchaseRequestMaster where (MPRNo = '" & MPRNo & "') and (Isnull(IsApproved,0) = 1 )"

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
    Private Function DeletePR(ByVal MPRNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl606_01PurchaseRequestMaster WHERE MPRNo   = '" & MPRNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl606_02PurchaseRequestChild WHERE MPRNo   = '" & MPRNo & "'"
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

    Private Sub btnUnlockInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnlockRequest.ItemClick
        If Me.intLogOnUserLevel = 99 Then
            Me.UnlockThePR(Me.SelectedPurchaseRequestNo)
            'Set the status to Re-Initiated
            Me.UpdateStatusOfMPR(Me.SelectedPurchaseRequestNo, 34)
            MessageBox.Show("Request/Enquiry has been unlocked successfully.", "Request/Enquiry Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Update the Delete Log File
            InsertUserEntryLogSheet("IMS Purchase Request", "IMS Purchase Request Ref No." & Me.SelectedPurchaseRequestNo & " has been Unlocked by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedPurchaseRequestNo)

            'Refresh the screen
            Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, SelectedRequestedType)
        Else
            MessageBox.Show("Your user access level cannot unlock the Request/Enquiry, Please review again.", "Access Permission Denied.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If

    End Sub

    Private Function UnlockThePR(ByVal MPRNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl606_01PurchaseRequestMaster Set 
                                IsSubmitted = 0, SubmittedBy = '', SubmittedOn = NULL, 
                                IsVerified = 0, VerifiedBy = '', VerifiedOn = NULL, 
                                IsApproved = 0, ApprovedBy = '', ApprovedOn = NULL,
                                RequestSignatory = NULL, MPRVerifiedSign = NULL, MPRApprovedSign = NULL,
                                PurchaseRequestStatusID = Null  where MPRNo = '" & MPRNo & "'"

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

    Public Function UpdateStatusOfMPR(ByVal MPRNo As String, ByVal StatusId As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl606_01PurchaseRequestMaster Set PurchaseRequestStatusID = '" & StatusId & "'  where MPRNo = '" & MPRNo & "'"

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

    Public Function UpdateQuotationVATPercentage(ByVal QuotationNo As String, ByVal VatTaxSlab As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl601_02QuotationChild Set QuotedTaxSlab = '" & VatTaxSlab & "'  where QuoteNo = '" & QuotationNo & "'"

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
            Me.gvAdvBandedQuotationView2.SaveLayoutToXml(fileName)
        End If
    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenLayout.ItemClick
        OpenFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Me.OpenFileDialog1.FileName
            Me.gvAdvBandedQuotationView2.RestoreLayoutFromXml(fileName)

        End If
    End Sub

    Private Sub frm601_04SalesOrderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
        ShowRecords(SelectedRequestedType)

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_12PurchaseRequestView", Me.gvAdvBandedQuotationView2)

        ImplementAccess()


        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colNetQuotedAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colNetQuotedWithTax.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalRequestCost.DisplayFormat.FormatString = "{0:#,0.000}"

        End If
    End Sub

    Private Sub ImplementAccess()
        Try
            If GetUserAccess(Me.intLogOnUserID, "PurchaseRequestFullAccess") = True Then

                Me.btnEditRequest.Enabled = True
                Me.btnPreviewRequest.Enabled = True
                Me.btnDeleteRequest.Enabled = True
                Me.btnUnlockRequest.Enabled = True
                Me.btnCreateRFQ.Enabled = True

                Me.btnCreateQuotation.Enabled = True
                Me.btnCreatePurchaseOrder.Enabled = True
                Me.btnCreateMaterialIssueNote.Enabled = True
                Me.btnCreateReceipt.Enabled = True
                Me.btnCloneRequest.Enabled = True
                Me.btnReviseMPR.Enabled = True
                Me.btnShowVersionHistory.Enabled = True

                Me.btnLayoutMenu.Enabled = True
                Me.btnPrint.Enabled = True
                Me.btnSearch.Enabled = True
                Me.btnGroup.Enabled = True
                Me.btnRequestDetails.Enabled = True
                Me.btnAddNewRequest.Enabled = True

                Me.btnAddNewStoreRequest.Enabled = True
                Me.btnAddNewDeptRequest.Enabled = True

                'Me.colClientCode.Visible = True
                'Me.colClientName1.Visible = True

            Else
                Me.btnEditRequest.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnEditRequest")
                Me.btnPreviewRequest.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnPreviewRequest")
                Me.btnDeleteRequest.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnDeleteRequest")
                Me.btnUnlockRequest.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnUnlockRequest")
                Me.btnCreateRFQ.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnCreateRFQ")

                Me.btnLayoutMenu.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnLayoutMenu")
                Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnPrint")
                Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnSearch")
                Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnGroup")
                Me.btnRequestDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnRequestDetails")
                Me.btnAddNewRequest.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnAddNewRequest")

                Me.btnAddNewStoreRequest.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnAddNewStoreRequest")
                Me.btnAddNewDeptRequest.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnAddNewDeptRequest")

                'Me.colClientCode.Visible = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_colClientCode")
                'Me.colClientName1.Visible = GetUserAccess(Me.intLogOnUserID, "frm601_12PurchaseRequestView_colClientName1")

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_12PurchaseRequestView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvAdvBandedQuotationView2))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvAdvBandedQuotationView2))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBy1stQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy1stQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 1, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 3, 31)

        ShowRecords(SelectedRequestedType)
    End Sub

    Private Sub btnBy2ndQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy2ndQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 4, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 6, 30)

        ShowRecords(SelectedRequestedType)
    End Sub

    Private Sub btnBy3rdQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy3rdQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 7, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 9, 30)

        ShowRecords(SelectedRequestedType)
    End Sub

    Private Sub btnBy4thQuarter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBy4thQuarter.ItemClick
        Me.txtStartDate.EditValue = DateSerial(Date.Today.Year, 10, 1)
        Me.txtEndDate.EditValue = DateSerial(Date.Today.Year, 12, 31)

        ShowRecords(SelectedRequestedType)
    End Sub


#Region "Create RFQ"

    Private Sub btnCreateRFQ_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateRFQ.ItemClick

        GetCompanyDetails02(1)
        If gIsEnableMPRWorkflow = True Then
            'Check if the PR is Approved or not
            If CheckIfPRIsApproved(Me.SelectedPurchaseRequestNo) = False Then
                MessageBox.Show("Request/Enquiry is not approved, You cannot process this Request without approval", "Request/Enquiry is not Approved", MessageBoxButtons.OK)
                Exit Sub
            End If
        End If


        DialogResult = MessageBox.Show("You are about to create new RFQ." & vbCrLf & "Are you Sure want to continue creating RFQ?", "Confirm creating RFQ.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedPurchaseRequestNo) = False Then

                'Get New RFQ Number
                GetCompanyDetails(1)
                Dim NewRFQNo As String = frm601_13RFQMaster.GetNewRFQNo(gRFQAbbrv, gInvoiceYearDigits)
                Me.CreateRFQ(NewRFQNo, Me.SelectedPurchaseRequestNo, Me.strLogOnUser)
                Me.UpdateStatusOfMPR(Me.SelectedPurchaseRequestNo, 2)
                Me.OpenRFQ(NewRFQNo)

                'Refresh the datagrid
                'Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub CreateRFQ(ByVal RFQNo As String, ByVal MPRNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_01InsertToRfqFromEnquiry"
            Dim paramRFQNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@RFQNo", SqlDbType.VarChar)
            Dim paramMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramRFQNo.Value = RFQNo
            paramMPRNo.Value = MPRNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New RFQ is created successfully,", "RFQ created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("RFQ Creation failed, Please try again", "RFQ Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    'Public Function GetNewRFQNo(ByVal RFQAbbrv As String, ByVal YearInDigit As Integer) As String
    '    Dim strNewQuotationNo As String = ""
    '    Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
    '    Try
    '        If Sqlconnection1.State = ConnectionState.Closed Then
    '            Sqlconnection1.Open()
    '        End If

    '        Dim SqlCommand1 As New SqlClient.SqlCommand
    '        SqlCommand1.Connection = Sqlconnection1
    '        SqlCommand1.CommandText = "select max(cast(right(RFQNo,5) as int)) from tbl607_01RFQMaster"
    '        Dim int1 As Integer
    '        int1 = SqlCommand1.ExecuteScalar()
    '        int1 = int1 + 1

    '        strNewQuotationNo = "00000" & CStr(int1)
    '        strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, 5)

    '        If CheckIfNull(YearInDigit) = True Then
    '            YearInDigit = 0
    '        End If

    '        Dim strYear As String = Year(Now).ToString
    '        strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

    '        strNewQuotationNo = strYear & "-" & strNewQuotationNo
    '        strNewQuotationNo = RFQAbbrv & strNewQuotationNo
    '        Return strNewQuotationNo

    '    Catch ex As System.InvalidCastException
    '        Dim strYear As String = Year(Now).ToString
    '        strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
    '        strNewQuotationNo = RFQAbbrv & strYear & "-" & "00001"
    '        Return strNewQuotationNo

    '    Finally
    '        Sqlconnection1.Close()

    '    End Try
    'End Function

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

            frm601_13RFQMaster.isExecutedFrom_frm601_12PurchaseRequestView = True

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

        End If
    End Sub


#End Region

#Region "Create Quotation"

    Private Sub btnCreateQuotation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateQuotation.ItemClick
        GetCompanyDetails02(1)
        If gIsEnableMPRWorkflow = True Then
            'Check if the PR is Approved or not
            If CheckIfPRIsApproved(Me.SelectedPurchaseRequestNo) = False Then
                MessageBox.Show("Request/Enquiry is not approved, You cannot process this Request without approval", "Request/Enquiry is not Approved", MessageBoxButtons.OK)
                Exit Sub
            End If
        End If

        DialogResult = MessageBox.Show("You are about to create new Quotation." & vbCrLf & "Are you Sure want to continue creating Quotation?", "Confirm creating Quotation.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedPurchaseRequestNo) = False Then

                'Get New Quotation Number
                GetCompanyDetails(1)
                GetCompanyDetails02(1)
                Dim NewQuotationNo As String = GetNewQuotationNo(gQuotationAbbrv, gInvoiceYearDigits, Date.Now, gIsResetQuoteInYear, gNoOfDigitsToInventoryQuotation)
                Me.CreateQuotationFromPR(NewQuotationNo, Me.SelectedPurchaseRequestNo, Me.strLogOnUser)
                Me.UpdateStatusOfMPR(Me.SelectedPurchaseRequestNo, 4)

                Me.UpdateQuotationVATPercentage(NewQuotationNo, SelectedRequestedVATSlabCode)

                Me.OpenQuotation(NewQuotationNo)

                ''Refresh the datagrid
                ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub OpenQuotation(ByVal QuotationNo As String)
        If CheckIfNull(QuotationNo) = False Then
            Dim frm601_01QuotationEdit As New frm601_01QuotationEdit
            frm601_01QuotationEdit.ObjForm = Me
            frm601_01QuotationEdit.txtQuotationNo.Enabled = False
            frm601_01QuotationEdit.btnSave.Caption = "Update"
            frm601_01QuotationEdit.strLogonUser = Me.strLogOnUser
            frm601_01QuotationEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_01QuotationEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_01QuotationEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_01QuotationEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_01QuotationEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_01QuotationEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_01QuotationEdit.isExecutedFrom_frm601_12PurchaseRequestView = True

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_01QuotationEdit.txtSalesPerson.Enabled = True
            Else
                frm601_01QuotationEdit.txtSalesPerson.Enabled = False
            End If

            frm601_01QuotationEdit.Show()

            frm601_01QuotationEdit.RetrieveQuotationMaster(QuotationNo)

            frm601_01QuotationEdit.txtQuotationNo.Enabled = False
            frm601_01QuotationEdit.DisableApprovedVoucherEditing(QuotationNo)
            frm601_01QuotationEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

        End If
    End Sub


    Private Sub CreateQuotationFromPR(ByVal QuotationNo As String, ByVal MPRNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_03InsertToQuotationFromEnquiry"
            Dim paramQuotationNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@QuotationNo", SqlDbType.VarChar)
            Dim paramMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramQuotationNo.Value = QuotationNo
            paramMPRNo.Value = MPRNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Quotation is created successfully,", "Quotation created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Quotation Creation failed, Please try again", "Quotation Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public Function GetNewQuotationNo(ByVal QuotationAbbr As String, ByVal YearInDigit As Integer, ByVal QuoteDate As Date, ByVal IsResetByYear As Boolean, ByVal NoOfDigits As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1


            If IsResetByYear = True Then
                SqlCommand1.CommandText = "select max(cast(right(QuoteNo, " & NoOfDigits & ") as int)) from tbl601_01QuotationMaster where QuoteNo like '" & QuotationAbbr & "%' AND Isnull(RevisionNo,0) = 0 and Year(QuoteDate) = '" & Year(QuoteDate).ToString & "'"
            Else
                SqlCommand1.CommandText = "select max(cast(right(QuoteNo, " & NoOfDigits & ") as int)) from tbl601_01QuotationMaster WHERE QuoteNo like '" & QuotationAbbr & "%' AND Isnull(RevisionNo,0) = 0"
            End If

            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewQuotationNo = "000000" & CStr(int1)
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)

            If CheckIfNull(YearInDigit) = True Then
                YearInDigit = 0
            End If

            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = strYear & "-" & strNewQuotationNo
            strNewQuotationNo = QuotationAbbr & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(QuoteDate).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = "0000001"
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)

            strNewQuotationNo = QuotationAbbr & strYear & "-" & strNewQuotationNo
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    'Public Function GetNewQuotationNo(ByVal QuotationAbbr As String, ByVal YearInDigit As Integer, ByVal QuoteDate As Date, ByVal IsResetByYear As Boolean, ByVal NoOfDigits As Integer) As String
    '    Dim strNewQuotationNo As String = ""
    '    Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
    '    Try
    '        If Sqlconnection1.State = ConnectionState.Closed Then
    '            Sqlconnection1.Open()
    '        End If

    '        Dim SqlCommand1 As New SqlClient.SqlCommand
    '        SqlCommand1.Connection = Sqlconnection1

    '        If IsResetByYear = True Then
    '            SqlCommand1.CommandText = "select max(cast(right(QuoteNo, " & NoOfDigits & ") as int)) from tbl601_01QuotationMaster where QuoteNo like '" & QuotationAbbr & "%' AND Isnull(RevisionNo,0) = 0 and Year(QuoteDate) = '" & Year(QuoteDate).ToString & "'"
    '        Else
    '            SqlCommand1.CommandText = "select max(cast(right(QuoteNo, " & NoOfDigits & ") as int)) from tbl601_01QuotationMaster WHERE QuoteNo like '" & QuotationAbbr & "%' AND Isnull(RevisionNo,0) = 0"
    '        End If

    '        Dim int1 As Integer
    '        int1 = SqlCommand1.ExecuteScalar()
    '        int1 = int1 + 1

    '        strNewQuotationNo = "0000" & CStr(int1)
    '        strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, 4)

    '        If CheckIfNull(YearInDigit) = True Then
    '            YearInDigit = 0
    '        End If

    '        Dim strYear As String = Year(Now).ToString
    '        strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

    '        strNewQuotationNo = strYear & "-" & strNewQuotationNo
    '        strNewQuotationNo = QuotationAbbr & strNewQuotationNo
    '        Return strNewQuotationNo

    '    Catch ex As System.InvalidCastException
    '        Dim strYear As String = Year(QuoteDate).ToString
    '        strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
    '        strNewQuotationNo = QuotationAbbr & strYear & "-" & "0001"
    '        Return strNewQuotationNo

    '    Finally
    '        Sqlconnection1.Close()

    '    End Try
    'End Function
#End Region

    Private Sub CreateNewRequest(ByVal RequestedBy As Integer)
        Dim frm601_11PurchaseRequestEdit As New frm601_11PurchaseRequestEdit
        frm601_11PurchaseRequestEdit.ObjForm = Me

        frm601_11PurchaseRequestEdit.btnSave.Caption = "Save"
        frm601_11PurchaseRequestEdit.isBeingNew = True
        frm601_11PurchaseRequestEdit.strLogonUser = Me.strLogOnUser
        frm601_11PurchaseRequestEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_11PurchaseRequestEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_11PurchaseRequestEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_11PurchaseRequestEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
        frm601_11PurchaseRequestEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
        frm601_11PurchaseRequestEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_11PurchaseRequestEdit.Show()

        GetCompanyDetails(1)
        'Dim NewRFQNo As String = frm601_11PurchaseRequestEdit.GetNewRequestNo(gRFQAbbrv, gInvoiceYearDigits, Date.Now, False, 5)

        Dim NewRequestNo As String = frm601_11PurchaseRequestEdit.GetNewRequestNo(gRequestAbbrv, gInvoiceYearDigits, Date.Now, False, 5)
        frm601_11PurchaseRequestEdit.CreatedNewPurchaseRequestNo = NewRequestNo
        frm601_11PurchaseRequestEdit.NewRequestMaster(NewRequestNo)
        frm601_11PurchaseRequestEdit.txtRequestNo.EditValue = NewRequestNo
        frm601_11PurchaseRequestEdit.txtRequestDate.EditValue = Date.Today
        frm601_11PurchaseRequestEdit.UpdateDefaultFields(RequestedBy)
        frm601_11PurchaseRequestEdit.isExecutedFrom_frm601_12PurchaseRequestView = True
        frm601_11PurchaseRequestEdit.txtRequestStatus.EditValue = 1

        For i As Integer = 0 To frm601_11PurchaseRequestEdit.XtraTabControl1.TabPages.Count - 1
            If frm601_11PurchaseRequestEdit.XtraTabControl1.TabPages(i).Name = "pageRequestDetails" Then
                frm601_11PurchaseRequestEdit.XtraTabControl1.SelectedTabPage = frm601_11PurchaseRequestEdit.XtraTabControl1.TabPages(i)

                If gCurrencyType = "BHD" Then
                    frm601_11PurchaseRequestEdit.txtVATPercentage.EditValue = 10
                ElseIf gCurrencyType = "AED" Then
                    frm601_11PurchaseRequestEdit.txtVATPercentage.EditValue = 1
                Else
                    frm601_11PurchaseRequestEdit.txtVATPercentage.EditValue = 8
                End If

            End If
        Next

        For i As Integer = 0 To frm601_11PurchaseRequestEdit.XtraTabControl1.TabPages.Count - 1
            If frm601_11PurchaseRequestEdit.XtraTabControl1.TabPages(i).Name = "pageQuoteDetails" Then
                frm601_11PurchaseRequestEdit.XtraTabControl1.SelectedTabPage = frm601_11PurchaseRequestEdit.XtraTabControl1.TabPages(i)

            End If
        Next


    End Sub

    Private Sub btnAddNewInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewRequest.ItemClick
        Me.CreateNewRequest(1)
    End Sub
    Private Sub btnAddNewStoreRequest_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewStoreRequest.ItemClick
        Me.CreateNewRequest(2)
    End Sub

    Private Sub btnAddNewDeptRequest_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewDeptRequest.ItemClick
        Me.CreateNewRequest(3)
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_12PurchaseRequestView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddNewProjectRequest_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewProjectRequest.ItemClick
        Me.CreateNewRequest(4)
    End Sub

    Private Sub btnRequestDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRequestDetails.ItemClick
        Try
            Dim frm601_35PurchaseRequestItemDetails As New frm601_35PurchaseRequestItemDetails
            frm601_35PurchaseRequestItemDetails.ObjForm = Me

            frm601_35PurchaseRequestItemDetails.strLogOnUser = Me.strLogOnUser
            frm601_35PurchaseRequestItemDetails.intLogOnUserID = Me.intLogOnUserID
            frm601_35PurchaseRequestItemDetails.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_35PurchaseRequestItemDetails.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_35PurchaseRequestItemDetails.intLogOnDivision = Me.intLogOnDivision
            frm601_35PurchaseRequestItemDetails.intLogOnHRLevelCode = Me.intLogOnHRLevelCode
            frm601_35PurchaseRequestItemDetails.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_35PurchaseRequestItemDetails.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_35PurchaseRequestItemDetails.txtStartDate.EditValue = Me.txtStartDate.EditValue
            frm601_35PurchaseRequestItemDetails.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm601_35PurchaseRequestItemDetails.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnCreatePurchaseOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreatePurchaseOrder.ItemClick
        GetCompanyDetails02(1)
        If gIsEnableMPRWorkflow = True Then
            'Check if the PR is Approved or not
            If CheckIfPRIsApproved(Me.SelectedPurchaseRequestNo) = False Then
                MessageBox.Show("Request/Enquiry is not approved, You cannot process this Request without approval", "Request/Enquiry is not Approved", MessageBoxButtons.OK)
                Exit Sub
            End If
        End If

        DialogResult = MessageBox.Show("You are about to create new Purchase Order." & vbCrLf & "Are you Sure want to continue creating Purchase Order?", "Confirm creating Purchase Order.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedPurchaseRequestNo) = False Then

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

                Me.CreatePO(NewPONo, Me.SelectedPurchaseRequestNo, Me.strLogOnUser)
                Me.OpenPO(NewPONo)

                Me.UpdateStatusOfMPR(Me.SelectedPurchaseRequestNo, 6)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Public Function GetNewPONo(ByVal PurchaseOrderAbbrv As String, ByVal YearInDigit As Integer, ByVal PODate As Date, ByVal IsResetByYear As Boolean) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1

            If IsResetByYear = True Then
                SqlCommand1.CommandText = "select max(cast(right(PONo,4) as int)) from tbl604_01PurchaseOrderMaster where PONo like '" & PurchaseOrderAbbrv & "%' AND Year(PODate) = '" & Year(PODate).ToString & "' AND ISNULL(IsObseleteVersion, 0) = 0"
            Else
                SqlCommand1.CommandText = "select max(cast(right(PONo,4) as int)) from tbl604_01PurchaseOrderMaster WHERE PONo like '" & PurchaseOrderAbbrv & "%' AND ISNULL(IsObseleteVersion, 0) = 0"
            End If

            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewQuotationNo = "0000" & CStr(int1)
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, 4)

            If CheckIfNull(YearInDigit) = True Then
                YearInDigit = 0
            End If

            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = strYear & "-" & strNewQuotationNo
            strNewQuotationNo = PurchaseOrderAbbrv & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(PODate).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
            strNewQuotationNo = PurchaseOrderAbbrv & strYear & "-" & "0001"
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub CreatePO(ByVal PONo As String, ByVal MPRNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_01InsertToPOfromEnquiry"
            Dim paramPONo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@PONo", SqlDbType.VarChar)
            Dim paramMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramPONo.Value = PONo
            paramMPRNo.Value = MPRNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Purchase Order is created successfully,", "PO created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("PO Creation failed, Please try again", "PO Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            frm601_07PurchaseOrderEdit.isExecutedFrom_frm601_12PurchaseRequestView = True

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
        End If
    End Sub

    Private Sub btnCreateReceipt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateReceipt.ItemClick
        GetCompanyDetails02(1)
        If gIsEnableMPRWorkflow = True Then
            'Check if the PR is Approved or not
            If CheckIfPRIsApproved(Me.SelectedPurchaseRequestNo) = False Then
                MessageBox.Show("Request/Enquiry is not approved, You cannot process this Request without approval", "Request/Enquiry is not Approved", MessageBoxButtons.OK)
                Exit Sub
            End If
        End If

        DialogResult = MessageBox.Show("You are about to create new Material Receipt for this Request." & vbCrLf & "Are you Sure want to continue creating Material Receipt Voucher?", "Confirm creating Material Receipt.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedPurchaseRequestNo) = False Then

                'Get New Receipt Number
                GetCompanyDetails(1)
                'Dim NewReceiptNo As String = frm601_09MaterialReceiptEdit.GetNewReceiptNo(gPurchaseOrderAbbrv, gInvoiceYearDigits, Date.Now, gIsResetPOInYear, gNoOfDigitsToInventoryPO)
                Dim NewReceiptNo As String = frm601_09MaterialReceiptEdit.GetNewReceiptNo(gMaterialReceiptAbbrv, gInvoiceYearDigits, Date.Now, gIsResetDeliverInYear)

                'frm601_07PurchaseOrderEdit.CreatedNewPONo = NewPONo
                Me.CreateMaterialReceipt(NewReceiptNo, 1, Me.SelectedPurchaseRequestNo, Me.strLogOnUser)
                Me.OpenReceipt(NewReceiptNo)

                Me.UpdateStatusOfMPR(Me.SelectedPurchaseRequestNo, 8)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
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

            'frm601_09MaterialReceiptEdit.isExecutedFrom_frm601_10MaterialReceiptView = False
            frm601_09MaterialReceiptEdit.Show()
            frm601_09MaterialReceiptEdit.RetrieveReceiptMaster(ReceiptNo)
            frm601_09MaterialReceiptEdit.txtReceiptNo.Enabled = False
            frm601_09MaterialReceiptEdit.DisableApprovedVoucherEditing(ReceiptNo)
            frm601_09MaterialReceiptEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

        End If
    End Sub

    Private Sub CreateMaterialReceipt(ByVal ReceiptNo As String, ByVal ModeOfReceipt As Integer, ByVal MPRNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_31InsertToMaterialReceiptfromEnquiry"
            Dim paramReceiptNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ReceiptNoteNo", SqlDbType.VarChar)
            Dim paramModeOfReceipt As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ModeOfReceiptID", SqlDbType.TinyInt)
            Dim paramMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramReceiptNo.Value = ReceiptNo
            paramModeOfReceipt.Value = ModeOfReceipt
            paramMPRNo.Value = MPRNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Material Receipt Voucher is created successfully,", "Material Receipt Voucher  created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Material Receipt Voucher Creation failed, Please try again", "Material Receipt Voucher  Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnCreateMaterialIssueNote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateMaterialIssueNote.ItemClick
        GetCompanyDetails02(1)
        If gIsEnableMPRWorkflow = True Then
            'Check if the PR is Approved or not
            If CheckIfPRIsApproved(Me.SelectedPurchaseRequestNo) = False Then
                MessageBox.Show("Request/Enquiry is not approved, You cannot process this Request without approval", "Request/Enquiry is not Approved", MessageBoxButtons.OK)
                Exit Sub
            End If
        End If

        DialogResult = MessageBox.Show("You are about to create new Material Issue Note for this Request." & vbCrLf & "Are you Sure want to continue creating Material Issue Voucher?", "Confirm creating Material Issue.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedPurchaseRequestNo) = False Then

                'Get New Delivery Note Number
                GetCompanyDetails(1)
                Dim NewDeliveryNoteNo As String = frm601_05DeliveryNoteEdit.GetNewDeliveryNoteNo(gMaterialIssueProjectAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote, Date.Now, gIsResetDeliverInYear)

                Me.CreateMaterialIssueNote(NewDeliveryNoteNo, 3, Me.SelectedPurchaseRequestNo, Me.strLogOnUser)
                Me.OpenDeliveryNote(NewDeliveryNoteNo)

                'update the Delivery Status in the MPR
                Me.UpdateStatusOfMPR(Me.SelectedPurchaseRequestNo, 10)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub CreateMaterialIssueNote(ByVal DeliveryNoteNo As String, ByVal DeliveryType As Integer, ByVal MPRNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_08InsertToDeliveryNoteFromMaterialRequest"
            Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
            Dim paramDeliveryType As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryType", SqlDbType.TinyInt)
            Dim paramMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramDeliveryNoteNo.Value = DeliveryNoteNo
            paramDeliveryType.Value = DeliveryType
            paramMPRNo.Value = MPRNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Material Issue Note is created successfully,", "Material Issue Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Material Issue Note Creation failed, Please try again", "Material Issue Note  Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
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
            frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_12PurchaseRequestView = True

            ''Post all the Average Cost Price of the Items in the Delivery Note and Update it
            'UpdateAvgCostPriceInDeliveryNote(Me.SelectedDeliveryNoteNo, Me.SelectedDeliveryNoteDate)

            frm601_05DeliveryNoteEdit.Show()
            frm601_05DeliveryNoteEdit.RetrieveDeliveryMaster(DeliveryNoteNo)

            frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
            frm601_05DeliveryNoteEdit.DisableApprovedVoucherEditing(DeliveryNoteNo)
            frm601_05DeliveryNoteEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

        End If
    End Sub

    Private Sub btnCloneRequest_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCloneRequest.ItemClick
        'Duplicate the Quotation
        Try
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to Clone this Request/Enquiry." & vbCrLf & "Are you Sure want to Continue?", "Confirm Cloning.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedPurchaseRequestNo) = False Then
                    If CheckIfNull(Me.SelectedPurchaseRequestDate) = False Then
                        GetCompanyDetails(1)
                        ''Dim NewRFQNo As String = frm601_11PurchaseRequestEdit.GetNewRequestNo(gRFQAbbrv, gInvoiceYearDigits, Date.Now, False, 5)
                        Dim NewRequestNo As String = frm601_11PurchaseRequestEdit.GetNewRequestNo(gRequestAbbrv, gInvoiceYearDigits, Date.Now, False, 5)

                        If DuplicateIMSPurchaseRequest(Me.SelectedPurchaseRequestNo, NewRequestNo, Me.SelectedPurchaseRequestDate, Me.strLogOnUser, Date.Now) = True Then
                            MessageBox.Show("Purchase Request/Enquiry has been successfully added to the database.", "Data insertion Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Refresh datagrid
                            ShowRecords(SelectedRequestedType)
                        Else
                            MessageBox.Show("Purchase Request/Enquiry cloning Failed, please try again.", "Insertion Failed", MessageBoxButtons.OK)
                        End If
                    End If
                End If

            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowVersionHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowVersionHistory.ItemClick
        Try
            Dim frm601_41MPRRevisionHistory As New frm601_41MPRRevisionHistory
            'frm601_39PORevisionHistory.ObjForm = Me

            frm601_41MPRRevisionHistory.strLogOnUser = Me.strLogOnUser
            frm601_41MPRRevisionHistory.intLogOnUserID = Me.intLogOnUserID
            frm601_41MPRRevisionHistory.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_41MPRRevisionHistory.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_41MPRRevisionHistory.intLogOnDivision = Me.intLogOnDivision
            frm601_41MPRRevisionHistory.intLogOnHRLevelCode = Me.intLogOnHRLevelCode
            frm601_41MPRRevisionHistory.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_41MPRRevisionHistory.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_41MPRRevisionHistory.Show()

            frm601_41MPRRevisionHistory.RetrieveVoucher(Me.SelectedPurchaseRequestNo)

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnReviseMPR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReviseMPR.ItemClick
        'IsAllowPORevision
        GetCompanyDetails02(1)
        If gIsAllowMPRRevision = False Then
            'Revision option is been disabled... you cannot unlock this purchase order
            MessageBox.Show("MPR Revision Workflow is Disabled, you cannot Revise the Purchase Request.", "Cannot Revise MPR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Check if the User is allowed to Approve the PO
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_12PurchaseRequestView_btnReviseMPR") = False Then
            MessageBox.Show("You have no Access rights to Revise the Purchase Request. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        Else
            'Check if the PO items been received... then exit the revision option

            'Else Revise the PO
            'Get the PO No to be revised... add the Revision No as the new ended... 
            DialogResult = MessageBox.Show("You are about to revise this Purchase Request." & vbCrLf & "Are you Sure want to continue adding new revised Purchase Request?", "Confirm creating revised Purchase Request.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedPurchaseRequestNo) = False Then

                    Dim CurrentRevisionNo As Integer = GetCurrentMPRVersionNo(Me.SelectedPurchaseRequestNo)
                    Dim NextRevisionNo As Integer = GetNextMPRVersionNo(Me.SelectedPurchaseRequestNo)

                    Dim OldMPRNo As String = Me.SelectedPurchaseRequestNo
                    Dim NewMPRNo As String = OldMPRNo & "-(R" & CurrentRevisionNo & ")"

                    Me.CreateNewRevisedMPR(Me.SelectedPurchaseRequestNo, NewMPRNo, NextRevisionNo, Me.strLogOnUser)

                    Me.UnlockThePR(Me.SelectedPurchaseRequestNo)
                    InsertUserEntryLogSheet("Inventory Purchase Request", "Purchase Request No." & Me.SelectedPurchaseRequestNo & " has been revised by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedPurchaseRequestNo)
                    MessageBox.Show("Purchase Request has been revised successfully.", "Purchase Request Revised", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.OpenPR(OldMPRNo)
                    'Refresh the datagrid
                    Me.ShowRecords(SelectedRequestedType)

                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
    End Sub

    Dim CurrentMPRVersionNo As Integer = 0
    Dim NextMPRVersionNo As Integer = 0

    Public Function GetCurrentMPRVersionNo(ByVal PurchaseRequestNo As String) As Integer

        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Isnull(MPRRevisionID, 0) from tbl606_01PurchaseRequestMaster WHERE MPRNo like '" & PurchaseRequestNo & "%' "
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            Return int1

        Catch ex As System.InvalidCastException
            Return 1
        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Public Function GetNextMPRVersionNo(ByVal PurchaseRequestNo As String) As Integer

        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            'Dim PurchaseOrderNoTrimmed As String = PurchaseOrderNo
            'Dim PurchaseOrderNoIndex As Integer = PurchaseOrderNoTrimmed.IndexOf("(")

            'If PurchaseOrderNoIndex > -1 Then
            '    PurchaseOrderNoTrimmed = PurchaseOrderNo.Substring(0, PurchaseOrderNoIndex - 1)
            'Else
            '    PurchaseOrderNoTrimmed = PurchaseOrderNo
            'End If


            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Isnull(MPRRevisionID, 0) from tbl606_01PurchaseRequestMaster WHERE MPRNo like '" & PurchaseRequestNo & "%' "
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1
            Return int1

        Catch ex As System.InvalidCastException
            Return 1
        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub CreateNewRevisedMPR(ByVal MPRNo As String, ByVal NewMPRNo As String, ByVal NewRevisionID As Integer, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_32CreateNewRevisedMPR"
            Dim paramMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRNo", SqlDbType.VarChar)
            Dim paramNewMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@NewMPRNo", SqlDbType.VarChar)
            Dim paramRevisionNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@NewRevisionID", SqlDbType.TinyInt)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramMPRNo.Value = MPRNo
            paramNewMPRNo.Value = NewMPRNo
            paramRevisionNo.Value = NewRevisionID
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Revised Purchase Request is created successfully,", "Revised MPR created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Revised Purchase Request Creation failed, Please try again", "Revised MPR Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub LockButtonsForCancelled(ByVal IsLock As Boolean)
        If IsLock = True Then
            Me.btnEditRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnPreviewRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnDeleteRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnUnlockRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnCreateRFQ.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Me.btnCreateQuotation.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnCreatePurchaseOrder.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnCreateMaterialIssueNote.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnCreateReceipt.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnReviseMPR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.btnEditRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnPreviewRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnDeleteRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnUnlockRequest.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnCreateRFQ.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            Me.btnCreateQuotation.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnCreatePurchaseOrder.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnCreateMaterialIssueNote.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnCreateReceipt.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnReviseMPR.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

    End Sub
End Class