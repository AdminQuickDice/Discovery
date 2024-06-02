Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_08PurchaseOrderView
    Public frm601_08PurchaseOrderViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Public intLogOnHRLevelCode As Integer

    Private SelectedPONo As String = ""
    Private SelectedPODate As Date = Date.Today()
    Private SelectedSupplierCode As String = ""
    Private SelectedCompany As Integer = 1

#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If intLogOnInventoryAccessLevel = 99 Then
                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry604_04PurchaseOrderViewMasterTableAdapter.FillByPODate(Me.Dsfrm601_08PurchaseOrderView.qry604_04PurchaseOrderViewMaster, StartDate, EndDate)
                Else
                    Me.Qry604_04PurchaseOrderViewMasterTableAdapter.FillByPODateBySalesPersonUserID(Me.Dsfrm601_08PurchaseOrderView.qry604_04PurchaseOrderViewMaster, StartDate, EndDate, Me.intLogOnUserID)
                End If

            Else
                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry604_04PurchaseOrderViewMasterTableAdapter.FillByPODateByGroup(Me.Dsfrm601_08PurchaseOrderView.qry604_04PurchaseOrderViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                Else
                    Me.Qry604_04PurchaseOrderViewMasterTableAdapter.FillByPODateByGroupBySalesPersonUserID(Me.Dsfrm601_08PurchaseOrderView.qry604_04PurchaseOrderViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Purchase Order Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub UpdateFrames()
        'Dim nwTile As TileItem = Me.tilePendingTasks
        ''VAT Invoices Today
        'nwTile.Frames(0).Elements(2).Text = ConvertIfNullInt(Me.Qry201_607VATInvoiceRegisterMainViewTableAdapter.GetNoOfVATInvoicesToday())
        ''VAT Invoices Not Verified
        'nwTile.Frames(1).Elements(2).Text = ConvertIfNullInt(Me.Qry201_607VATInvoiceRegisterMainViewTableAdapter.GetNoOfInvoiceTodayNotVerified())
        ''VAT Invoices Verified
        'nwTile.Frames(2).Elements(2).Text = ConvertIfNullInt(Me.Qry201_607VATInvoiceRegisterMainViewTableAdapter.GetNoOfInvoiceTodayVerified())


        Dim nwTile3 As TileItem = Me.tileAllAssets
        If intLogOnInventoryAccessLevel = 99 Then
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry604_04PurchaseOrderViewMasterTableAdapter.GetNoOfPOs(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue))
        Else
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry604_04PurchaseOrderViewMasterTableAdapter.GetNoOfPOsByGroup(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, Me.intLogOnInventoryAccessLevel))
        End If


    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub

#End Region

    Public Sub ImplementAccess(ByVal UserID As Integer)
        Try
            If GetUserAccess(UserID, "frm601_08PurchaseOrderView_FullAccess") = True Then

                Me.btnShowAllRecords.Enabled = True
                Me.btnSaveLayout.Enabled = True
                Me.btnOpenLayout.Enabled = True
                Me.btnResetLayout.Enabled = True
                Me.btnSetDefaultLayout.Enabled = True
                Me.btnPrint.Enabled = True
                Me.btnSearch.Enabled = True
                Me.btnGroup.Enabled = True
                Me.btnPODetails.Enabled = True
                Me.btnAddNewPO.Enabled = True
                Me.btnEditPO.Enabled = True
                Me.btnDeletePO.Enabled = True
                Me.btnUnlockPO.Enabled = True
                Me.btnCreatePartialReceipt.Enabled = True
                Me.btnCreateFullDelivery.Enabled = True
                Me.btnCreateVATPurBills.Enabled = True

            Else
                Me.btnShowAllRecords.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnShowAllRecords")
                Me.btnSaveLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnSaveLayout")
                Me.btnOpenLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnOpenLayout")
                Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnResetLayout")
                Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnSetDefaultLayout")
                Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnPrint")
                Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnSearch")
                Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnGroup")
                Me.btnPODetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnPODetails")
                Me.btnAddNewPO.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnAddNewPO")
                Me.btnEditPO.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnEditPO")
                Me.btnDeletePO.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnDeletePO")
                Me.btnUnlockPO.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnUnlockPO")
                Me.btnCreatePartialReceipt.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnCreatePartialReceipt")
                Me.btnCreateFullDelivery.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnCreateFullDelivery")
                Me.btnCreateVATPurBills.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnCreateVATPurBills")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_08PurchaseOrderViewIsClosed = True
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

    Private SelectedIsSubmitted As Boolean = False
    Private SelectedIsVerified As Boolean = False
    Private SelectedIsApproved As Boolean = False
    Private Sub gvAccountDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvAdvBandedQuotationView.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle
                SelectedPONo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("PONo"))
                SelectedPODate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("PODate"))


                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SupplierCode"))) = False Then
                    SelectedSupplierCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SupplierCode"))
                Else
                    SelectedSupplierCode = ""
                End If


                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("CompanyBranch"))) = False Then
                    SelectedCompany = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("CompanyBranch"))
                Else
                    SelectedCompany = 1
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

                Me.PopupMenu1.ShowPopup(MousePosition)
            End If
        Catch ex As Exception

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
            frm601_07PurchaseOrderEdit.isExecutedFrom_frm601_08PurchaseOrderView = True

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

            If frm601_07PurchaseOrderEdit.CheckIfPOIsSubmitted(PONo) = True Then
                frm601_07PurchaseOrderEdit.DisableAllControls()
                frm601_07PurchaseOrderEdit.btnSubmit.Enabled = False

                If frm601_07PurchaseOrderEdit.CheckIfPOIsVerified(PONo) = False And frm601_07PurchaseOrderEdit.CheckIfPOIsApproved(PONo) = False Then
                    'Check if the User is allowed to verify the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_btnVerify") = True Then
                        frm601_07PurchaseOrderEdit.EnableAllControls()
                        frm601_07PurchaseOrderEdit.btnSubmit.Enabled = False
                        frm601_07PurchaseOrderEdit.btnVerify.Enabled = True
                        frm601_07PurchaseOrderEdit.btnApprove.Enabled = False
                    End If
                End If
            End If

            If frm601_07PurchaseOrderEdit.CheckIfPOIsVerified(PONo) = True Then
                frm601_07PurchaseOrderEdit.DisableAllControls()
                frm601_07PurchaseOrderEdit.btnSubmit.Enabled = False
                frm601_07PurchaseOrderEdit.btnVerify.Enabled = False

                If frm601_07PurchaseOrderEdit.CheckIfPOIsApproved(PONo) = False Then
                    'Check if the User is allowed to Approve the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_07PurchaseOrderEdit_btnApprove") = True Then
                        frm601_07PurchaseOrderEdit.EnableAllControls()
                        frm601_07PurchaseOrderEdit.btnSubmit.Enabled = False
                        frm601_07PurchaseOrderEdit.btnVerify.Enabled = False
                        frm601_07PurchaseOrderEdit.btnApprove.Enabled = True
                    End If
                End If
            End If

            GetCompanyDetails02(1)
            If gIsAmendPOAfterReceipt = False Then
                If frm601_07PurchaseOrderEdit.CheckIfPOIsApproved(PONo) = True Then
                    frm601_07PurchaseOrderEdit.DisableAllControls()
                End If
            End If

            'Check if the PO has line items.. If available disable currency choosing, else enable currency.
            If frm601_07PurchaseOrderEdit.Dsfrm601_07PurchaseOrderEdit.qry604_02PurchaseOrderChild.Rows.Count = 0 Then
                frm601_07PurchaseOrderEdit.txtCurrency.Enabled = True
                frm601_07PurchaseOrderEdit.txtCurrencyExchangeRate.Enabled = True
            Else
                frm601_07PurchaseOrderEdit.txtCurrency.Enabled = False
                frm601_07PurchaseOrderEdit.txtCurrencyExchangeRate.Enabled = False

            End If
        End If
    End Sub

    Private Sub btnPopupEditQuotation_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPO.ItemClick
        Me.OpenPO(Me.SelectedPONo)
    End Sub

    Private Sub repoQuoteNo_Click(sender As Object, e As EventArgs) Handles repoQuoteNo.Click
        Dim strDeliveryNoteNo As String = Me.gvAdvBandedQuotationView.GetRowCellValue(Me.gvAdvBandedQuotationView.FocusedRowHandle, "PONo")
        If CheckIfNull(strDeliveryNoteNo) = True Then
            MessageBox.Show("Please select the Purchase Order No. to edit.", "Select Purchase Order No. to edit", MessageBoxButtons.OK)
        Else
            Me.OpenPO(strDeliveryNoteNo)
        End If
    End Sub

    Private Sub btnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeletePO.ItemClick
        Try
            'Check if the Voucher is approved already
            If CheckIfPOIsApproved(Me.SelectedPONo) = True Then
                MessageBox.Show("Purchase Order is already approved, You cannot delete the Approved Purchase Order.", "Purchase Order is Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Purchase Order from the Register," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedPONo) = False Then
                    If DeletePO(Me.SelectedPONo) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.SelectedPONo, "VoucherScanned\IMSPO")

                        MessageBox.Show("Purchase Order has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Purchase Order", "IMS Purchase Order Ref No." & Me.SelectedPONo & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedPONo)

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

    Private Function CheckIfPOIsApproved(ByVal PONo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select PONo from tbl604_01PurchaseOrderMaster where (PONo = '" & PONo & "') and (Isnull(IsApproved,0) = 1 )"

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
    Private Function DeletePO(ByVal PONo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl604_01PurchaseOrderMaster WHERE PONo   = '" & PONo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl604_02PurchaseOrderChild WHERE PONo   = '" & PONo & "'"
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

    Private Sub btnAddNewPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewPO.ItemClick
        Dim frm601_07PurchaseOrderEdit As New frm601_07PurchaseOrderEdit
        frm601_07PurchaseOrderEdit.ObjForm = Me

        frm601_07PurchaseOrderEdit.btnSave.Caption = "Save"
        frm601_07PurchaseOrderEdit.isBeingNew = True
        frm601_07PurchaseOrderEdit.strLogonUser = Me.strLogOnUser
        frm601_07PurchaseOrderEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_07PurchaseOrderEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_07PurchaseOrderEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_07PurchaseOrderEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_07PurchaseOrderEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
        frm601_07PurchaseOrderEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

        frm601_07PurchaseOrderEdit.isExecutedFrom_frm601_08PurchaseOrderView = True

        frm601_07PurchaseOrderEdit.Show()

        GetCompanyDetails(1)
        GetCompanyDetails02(1)

        Dim NewPONo As String

        If Me.intLogOnInventoryAccessLevel = 99 Then
            NewPONo = frm601_07PurchaseOrderEdit.GetNewPONo(gPurchaseOrderAbbrv, gInvoiceYearDigits, Date.Now, gIsResetPOInYear, gNoOfDigitsToInventoryPO, gIsUseNewSequencePONoForGroup)
        Else
            Dim PONumberSeqForGroup As String = GetPONoSequenceForGroup(Me.intLogOnInventoryAccessLevel)
            NewPONo = frm601_07PurchaseOrderEdit.GetNewPONo(PONumberSeqForGroup, gInvoiceYearDigits, Date.Now, gIsResetPOInYear, gNoOfDigitsToInventoryPO, gIsUseNewSequencePONoForGroup)
        End If

        frm601_07PurchaseOrderEdit.CreatedNewPONo = NewPONo
        frm601_07PurchaseOrderEdit.NewPOMaster(NewPONo)
        frm601_07PurchaseOrderEdit.txtPONo.EditValue = NewPONo
        frm601_07PurchaseOrderEdit.txtPODate.EditValue = Date.Today
        frm601_07PurchaseOrderEdit.UpdateDefaultFields()

    End Sub

    Private Sub btnUnlockInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnlockPO.ItemClick

        GetCompanyDetails02(1)
        If gIsAllowUnlockPO = False Then
            'Unlocking option is been disabled... you cannot unlock this purchase order
            MessageBox.Show("PO Unlock Workflow is disabled, you cannot Unlock the Purchase Order.", "Cannot Unlock PO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Check if the User is allowed to Approve the PO
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnUnlockPO") = False Then
            MessageBox.Show("You have no Access rights to Unlock the Purchase Order. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        Else
            Me.UnlockThePO(Me.SelectedPONo)
            InsertUserEntryLogSheet("Inventory Purchase Order", "Purchase Order No." & Me.SelectedPONo & " has been unlocked by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedPONo)
            MessageBox.Show("Purchase Order has been unlocked successfully.", "Purchase Order Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Refresh the screen
            Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        End If
    End Sub

    Private Function UnlockThePO(ByVal PONo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "UPDATE tbl604_01PurchaseOrderMaster Set IsSubmitted = 0, SubmittedBy = NULL, SubmittedOn = NULL, IsVerified = 0, VerifiedBy = NULL, VerifiedOn = NULL, IsApproved = 0, ApprovedBy = NULL, ApprovedOn = NULL  where PONo = '" & PONo & "'"

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
    ' Insert Unlock History log


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

        Me.ImplementAccess(Me.intLogOnUserID)

        'Retrieve Panel Layout
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_08PurchaseOrderView", Me.gvAdvBandedQuotationView)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colAdditionsAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colDeductionsAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalBeforeTax.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalDiscount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalAfterDiscount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalTaxAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalWithTax.DisplayFormat.FormatString = "{0:#,0.000}"
            colGrandTotal.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalBilled.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalAmountB4TaxInOC.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalAmountAfterDiscInOC.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalDiscountInOC.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalTaxAmountInOC.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalWithTaxInOC.DisplayFormat.FormatString = "{0:#,0.000}"
            colGrandTotalInOC.DisplayFormat.FormatString = "{0:#,0.000}"

        End If

    End Sub

    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_08PurchaseOrderView"

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

    Private Sub btnCreateFullDelivery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateFullDelivery.ItemClick

        'Check if the PO Workflow Implemented then 
        'Check if the Purchase Order is Approved or not
        GetCompanyDetails02(1)
        If gIsImplementPOWorkflow = True Then
            If CheckIfPOIsApproved(Me.SelectedPONo) = False Then
                MessageBox.Show("Purchase Order is still under Approval, you cannot Receive Items for this Order, Please approve the Purchase Order and Proceed.", "Purchase Order status is Not Approved.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        'Check if the Items are fully delivered already for this Purchase Order

        If CheckPurchaseOrderDeliveryStatus(Me.SelectedPONo) = "Fully Received" Then
            MessageBox.Show("Purchase Order is fully Delivered, you cannot Receive Items for this Order anymore, Please review again.", "Purchase Order status is Fully Received.", MessageBoxButtons.OK)
            Exit Sub
        End If

        If CheckPurchaseOrderDeliveryStatus(Me.SelectedPONo) = "Partially Received" Then
            MessageBox.Show("Purchase Order is partially Delivered, you cannot make full Receipt for this Order, Please review again.", "Purchase Order status is Partially Received.", MessageBoxButtons.OK)
            Exit Sub

        End If

        DialogResult = MessageBox.Show("You are about to create new Material Receipt Note." & vbCrLf & "Are you Sure want to continue creating Material Receipt Note?", "Confirm creating Material Receipt Note.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedPONo) = False Then

                'Get New Receipt Note Number
                GetCompanyDetails(1)
                Dim NewReceiptNo As String = frm601_09MaterialReceiptEdit.GetNewReceiptNo(gMaterialReceiptAbbrv, gInvoiceYearDigits, Date.Now, gIsResetDeliverInYear)

                Me.CreateFullDeliveryFromPurchaseOrder(NewReceiptNo, 1, Me.SelectedPONo, Me.strLogOnUser)
                Me.OpenReceipt(NewReceiptNo)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub OpenReceipt(ByVal ReceiptNo As String)
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

            frm601_09MaterialReceiptEdit.isExecutedFrom_frm601_08PurchaseOrderView = True

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

    Private Sub CreateFullDeliveryFromPurchaseOrder(ByVal ReceiptNoteNo As String, ByVal ModeOfReceiptID As Integer, ByVal PONo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_15InsertToReceiptNoteFromPurchaseOrder"
            Dim paramReceiptNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ReceiptNoteNo", SqlDbType.VarChar)
            Dim paramModeOfReceiptID As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ModeOfReceiptID", SqlDbType.TinyInt)
            Dim paramPONo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@PONo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramReceiptNoteNo.Value = ReceiptNoteNo
            paramModeOfReceiptID.Value = ModeOfReceiptID
            paramPONo.Value = PONo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Material Receipt Note is created successfully,", "Receipt Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Material Receipt Note Creation failed, Please try again", "Material Receipt Note Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub
    'Public Function GetNewReceiptNo(ByVal MaterialReceiptAbbrv As String, ByVal YearInDigit As Integer) As String
    '    Dim strNewQuotationNo As String = ""
    '    Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
    '    Try
    '        If Sqlconnection1.State = ConnectionState.Closed Then
    '            Sqlconnection1.Open()
    '        End If

    '        Dim SqlCommand1 As New SqlClient.SqlCommand
    '        SqlCommand1.Connection = Sqlconnection1
    '        SqlCommand1.CommandText = "select max(cast(right(ReceiptNo,5) as int)) from tbl605_01MaterialReceiptMaster where ReceiptNo <> 'OPENING-BAL'"
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
    '        strNewQuotationNo = MaterialReceiptAbbrv & strNewQuotationNo
    '        Return strNewQuotationNo

    '    Catch ex As System.InvalidCastException
    '        Dim strYear As String = Year(Now).ToString
    '        strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
    '        strNewQuotationNo = MaterialReceiptAbbrv & strYear & "-" & "00001"
    '        Return strNewQuotationNo

    '    Finally
    '        Sqlconnection1.Close()

    '    End Try
    'End Function

    Private Sub btnCreatePartialReceipt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreatePartialReceipt.ItemClick

        'Check if the PO Workflow Implemented then 
        'Check if the Purchase Order is Approved or not
        GetCompanyDetails02(1)
        If gIsImplementPOWorkflow = True Then
            If CheckIfPOIsApproved(Me.SelectedPONo) = False Then
                MessageBox.Show("Purchase Order is still under Approval, you cannot Receive Items for this Order, Please approve the Purchase Order and Proceed.", "Purchase Order status is Not Approved.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        'Check if the Items are fully delivered already for this Purchase Order
        If CheckPurchaseOrderDeliveryStatus(Me.SelectedPONo) = "Fully Received" Then
            MessageBox.Show("Purchase Order is fully Delivered, you cannot Receive Items for this Order anymore, Please review again.", "Purchase Order status is Fully Received.", MessageBoxButtons.OK)
            Exit Sub
        End If

        DialogResult = MessageBox.Show("You are about to create new Material Receipt Note." & vbCrLf & "Are you Sure want to continue creating Material Receipt Note?", "Confirm creating Material Receipt Note.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedPONo) = False Then

                'Get New Delivery Note Number
                GetCompanyDetails(1)
                Dim NewReceiptNo As String = frm601_09MaterialReceiptEdit.GetNewReceiptNo(gMaterialReceiptAbbrv, gInvoiceYearDigits, Date.Now, gIsResetDeliverInYear)

                'Me.CreatePartialDeliveryFromSalesOrder(NewDeliveryNoteNo, 1, Me.SelectedSalesOrderNo, Me.strLogOnUser)
                'Me.OpenDeliveryNote(NewDeliveryNoteNo)

                Me.CreatePartialDeliveryFromPurchaseOrder(NewReceiptNo, 1, Me.SelectedPONo, Me.strLogOnUser)
                Me.OpenReceipt(NewReceiptNo)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Function CheckPurchaseOrderDeliveryStatus(ByVal PONo As String) As String
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select OrderStatus, PONo from qry604_04PurchaseOrderViewMaster where (PONo = '" & PONo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    If CheckIfNull(srStockReader.Item("OrderStatus")) = False Then
                        Return srStockReader.Item("OrderStatus") & ""
                    Else
                        Return ""
                    End If
                End While
            Else
                Return ""
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return ""
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Sub CreatePartialDeliveryFromPurchaseOrder(ByVal MaterialReceiptNo As String, ByVal ModeOfReceipt As Integer, ByVal PONo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_16InsertToPartialReceiptFromPurchaseOrder"
            Dim paramReceiptNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ReceiptNoteNo", SqlDbType.VarChar)
            Dim paramModeOfReceipt As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ModeOfReceiptID", SqlDbType.TinyInt)
            Dim paramPONo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@PONo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramReceiptNoteNo.Value = MaterialReceiptNo
            paramModeOfReceipt.Value = ModeOfReceipt
            paramPONo.Value = PONo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Material Receipt Note is created successfully,", "Material Receipt Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Material Receipt Note Creation failed, Please try again", "Material Receipt Note Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnCreateVATPurBills_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateVATPurBills.ItemClick
        'Check if the PO Workflow Implemented then 
        'Check if the Purchase Order is Approved or not
        GetCompanyDetails02(1)
        If gIsImplementPOWorkflow = True Then
            If CheckIfPOIsApproved(Me.SelectedPONo) = False Then
                MessageBox.Show("Purchase Order is still under Approval, you cannot Receive Items for this Order, Please approve the Purchase Order and Proceed.", "Purchase Order status is Not Approved.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Try
            Dim frm601_17GeneratePurchaseBill As New frm601_17GeneratePurchaseBill
            frm601_17GeneratePurchaseBill.ObjForm = Me
            frm601_17GeneratePurchaseBill.strLogonUser = Me.strLogOnUser
            frm601_17GeneratePurchaseBill.intLogOnUserID = Me.intLogOnUserID
            frm601_17GeneratePurchaseBill.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_17GeneratePurchaseBill.intLogOnAccessLevel = Me.intLogOnAccessLevel

            frm601_17GeneratePurchaseBill.isExecutedFrom_frm601_08PurchaseOrderView = True
            frm601_17GeneratePurchaseBill.txtSupplierName.EditValue = Me.SelectedSupplierCode
            frm601_17GeneratePurchaseBill.txtPurchaseOrders.EditValue = Me.SelectedPONo
            frm601_17GeneratePurchaseBill.strClientPONo = Me.SelectedPONo
            frm601_17GeneratePurchaseBill.strCompanyName = Me.SelectedCompany

            frm601_17GeneratePurchaseBill.ShowRecords()
            frm601_17GeneratePurchaseBill.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_08PurchaseOrderView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPODetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPODetails.ItemClick
        Try
            Dim frm601_34PurchaseOrderItemDetails As New frm601_34PurchaseOrderItemDetails
            frm601_34PurchaseOrderItemDetails.ObjForm = Me

            frm601_34PurchaseOrderItemDetails.strLogOnUser = Me.strLogOnUser
            frm601_34PurchaseOrderItemDetails.intLogOnUserID = Me.intLogOnUserID
            frm601_34PurchaseOrderItemDetails.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_34PurchaseOrderItemDetails.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_34PurchaseOrderItemDetails.intLogOnDivision = Me.intLogOnDivision
            frm601_34PurchaseOrderItemDetails.intLogOnHRLevelCode = Me.intLogOnHRLevelCode
            frm601_34PurchaseOrderItemDetails.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_34PurchaseOrderItemDetails.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_34PurchaseOrderItemDetails.txtStartDate.EditValue = Me.txtStartDate.EditValue
            frm601_34PurchaseOrderItemDetails.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm601_34PurchaseOrderItemDetails.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnRevisePO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRevisePO.ItemClick
        'IsAllowPORevision
        GetCompanyDetails02(1)
        If gIsAllowRevisePO = False Then
            'Revision option is been disabled... you cannot unlock this purchase order
            MessageBox.Show("PO Revision Workflow is Disabled, you cannot Revise the Purchase Order.", "Cannot Revise PO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Check if the User is allowed to Approve the PO
        If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_08PurchaseOrderView_btnRevisePO") = False Then
            MessageBox.Show("You have no Access rights to Revise the Purchase Order. Please review your access rights.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        Else
            'Check if the PO items been received... then exit the revision option

            'Else Revise the PO
            'Get the PO No to be revised... add the Revision No as the new ended... 
            DialogResult = MessageBox.Show("You are about to revise this Purchase Order." & vbCrLf & "Are you Sure want to continue adding new revised Purchase Order?", "Confirm creating revised Purchase Order.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedPONo) = False Then

                    Dim CurrentRevisionNo As Integer = GetCurrentPOVersionNo(Me.SelectedPONo)
                    Dim NextRevisionNo As Integer = GetNextPOVersionNo(Me.SelectedPONo)

                    Dim OldPONo As String = Me.SelectedPONo
                    Dim NewPONo As String = OldPONo & "-(R" & CurrentRevisionNo & ")"

                    Me.CreateNewRevisedPO(Me.SelectedPONo, NewPONo, NextRevisionNo, Me.strLogOnUser)

                    Me.UnlockThePO(Me.SelectedPONo)
                    InsertUserEntryLogSheet("Inventory Purchase Order", "Purchase Order No." & Me.SelectedPONo & " has been revised by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedPONo)
                    MessageBox.Show("Purchase Order has been revised successfully.", "Purchase Order Revised", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.OpenPO(OldPONo)
                    'Refresh the datagrid
                    Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)

                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

    End Sub

    Dim CurrentPOVersionNo As Integer = 0
    Dim NextPOVersionNo As Integer = 0

    Public Function GetCurrentPOVersionNo(ByVal PurchaseOrderNo As String) As Integer

        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select Isnull(PORevisionID, 0) from tbl604_01PurchaseOrderMaster WHERE PONo like '" & PurchaseOrderNo & "%' "
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            Return int1

        Catch ex As System.InvalidCastException
            Return 1
        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Public Function GetNextPOVersionNo(ByVal PurchaseOrderNo As String) As Integer

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
            SqlCommand1.CommandText = "select Isnull(PORevisionID, 0) from tbl604_01PurchaseOrderMaster WHERE PONo like '" & PurchaseOrderNo & "%' "
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

    Private Sub CreateNewRevisedPO(ByVal PONo As String, ByVal NewPONo As String, ByVal NewRevisionID As Integer, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_28CreateNewRevisedPO"
            Dim paramPONo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@PONo", SqlDbType.VarChar)
            Dim paramNewPONo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@NewPONo", SqlDbType.VarChar)
            Dim paramRevisionNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@NewRevisionID", SqlDbType.TinyInt)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramPONo.Value = PONo
            paramNewPONo.Value = NewPONo
            paramRevisionNo.Value = NewRevisionID
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Revised Purchase Order is created successfully,", "Revised PO created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Revised Purchase Order Creation failed, Please try again", "Revised PO Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnShowVersionHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowVersionHistory.ItemClick
        Try
            Dim frm601_39PORevisionHistory As New frm601_39PORevisionHistory
            'frm601_39PORevisionHistory.ObjForm = Me

            frm601_39PORevisionHistory.strLogOnUser = Me.strLogOnUser
            frm601_39PORevisionHistory.intLogOnUserID = Me.intLogOnUserID
            frm601_39PORevisionHistory.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_39PORevisionHistory.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_39PORevisionHistory.intLogOnDivision = Me.intLogOnDivision
            frm601_39PORevisionHistory.intLogOnHRLevelCode = Me.intLogOnHRLevelCode

            frm601_39PORevisionHistory.Show()

            frm601_39PORevisionHistory.RetrieveVoucher(Me.SelectedPONo)

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub
End Class