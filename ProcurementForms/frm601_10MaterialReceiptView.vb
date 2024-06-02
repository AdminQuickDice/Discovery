Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_10MaterialReceiptView
    Public frm601_10MaterialReceiptViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Public intLogOnHRLevelCode As Integer

    Private SelectedReceiptNo As String = ""
    Private SelectedReceiptDate As Date = Date.Today()

    Private SelectedSupplierCode As String = ""

    Public SelectedIsSubmitted As Boolean
    Public SelectedIsVerified As Boolean
    Public SelectedIsApproved As Boolean

#Region "Calendar Controls Code"
    Public Sub RetrieveVoucher(ByVal StartDate As Date, ByVal EndDate As Date)
        Try
            If intLogOnInventoryAccessLevel = 99 Then
                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry605_04MaterialReceiptViewMasterTableAdapter.FillByReceiptDate(Me.Dsfrm601_10MaterialReceiptView.qry605_04MaterialReceiptViewMaster, StartDate, EndDate)
                Else
                    Me.Qry605_04MaterialReceiptViewMasterTableAdapter.FillByReceiptDateBySalesPersonUserID(Me.Dsfrm601_10MaterialReceiptView.qry605_04MaterialReceiptViewMaster, StartDate, EndDate, Me.intLogOnUserID)
                End If


            Else
                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    Me.Qry605_04MaterialReceiptViewMasterTableAdapter.FillByReceiptDateByGroup(Me.Dsfrm601_10MaterialReceiptView.qry605_04MaterialReceiptViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel)
                Else
                    Me.Qry605_04MaterialReceiptViewMasterTableAdapter.FillByReceiptDateByGroupBySalesPersonUserID(Me.Dsfrm601_10MaterialReceiptView.qry605_04MaterialReceiptViewMaster, StartDate, EndDate, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
                End If


            End If

            'Update Tiles
            Me.UpdateFrames()

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Material Receipts Database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ShowRecords()
        'Check the Dates are correct
        'Retrieve records
        RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        ''Update Tiles
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
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry605_04MaterialReceiptViewMasterTableAdapter.GetNoOfReceipts(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue))
        Else
            nwTile3.Elements(0).Text = ConvertIfNull(Me.Qry605_04MaterialReceiptViewMasterTableAdapter.GetNoOfReceiptsByGroup(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue, Me.intLogOnInventoryAccessLevel))
        End If

    End Sub

    Private Sub btnShowAllRecords_Click(sender As Object, e As EventArgs) Handles btnShowAllRecords.Click
        ShowRecords()
    End Sub

#End Region

    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_10MaterialReceiptViewIsClosed = True
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
                SelectedReceiptNo = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ReceiptNo"))
                SelectedReceiptDate = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ReceiptDate"))

                If CheckIfNull(view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SupplierCode"))) = False Then
                    SelectedSupplierCode = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("SupplierCode"))
                Else
                    SelectedSupplierCode = ""
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
            frm601_09MaterialReceiptEdit.isExecutedFrom_frm601_10MaterialReceiptView = True

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


            If frm601_09MaterialReceiptEdit.CheckIfMaterialReceiptIsSubmitted(ReceiptNo) = True Then

                frm601_09MaterialReceiptEdit.DisableAllControls()
                frm601_09MaterialReceiptEdit.btnSubmit.Enabled = False

                If Me.SelectedIsVerified = False And Me.SelectedIsApproved = False Then
                    'Check if the User is allowed to verify the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnVerify") = True Then
                        frm601_09MaterialReceiptEdit.EnableAllControls()
                        frm601_09MaterialReceiptEdit.btnSubmit.Enabled = False
                        frm601_09MaterialReceiptEdit.btnVerify.Enabled = True
                        frm601_09MaterialReceiptEdit.btnApprove.Enabled = False
                    End If
                End If

            End If

            If frm601_09MaterialReceiptEdit.CheckIfMaterialReceiptIsVerified(ReceiptNo) = True Then
                frm601_09MaterialReceiptEdit.DisableAllControls()
                frm601_09MaterialReceiptEdit.btnSubmit.Enabled = False
                frm601_09MaterialReceiptEdit.btnVerify.Enabled = False

                If Me.SelectedIsApproved = False Then
                    'Check if the User is allowed to Approve the PO
                    If CheckIfItemIsEnabled(Me.intLogOnUserID, "frm601_09MaterialReceiptEdit_btnApprove") = True Then
                        frm601_09MaterialReceiptEdit.EnableAllControls()
                        frm601_09MaterialReceiptEdit.btnSubmit.Enabled = False
                        frm601_09MaterialReceiptEdit.btnVerify.Enabled = False
                        frm601_09MaterialReceiptEdit.btnApprove.Enabled = True
                    End If
                End If
            End If

            If frm601_09MaterialReceiptEdit.CheckIfMaterialReceiptIsApproved(ReceiptNo) = True Then
                frm601_09MaterialReceiptEdit.DisableAllControls()

            End If

            GetCompanyDetails02(1)
            If gIsAmendMaterialReceiptAfterPurchaseEntry = False Then
                'Check if the VAT Purchase Bills is created already
                If CheckIfPurchaseBillAvailableForMR(ReceiptNo) = True Then
                    frm601_09MaterialReceiptEdit.DisableAllControls()
                End If

            End If


        End If
    End Sub
    Private Sub btnPopupEditQuotation_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditMaterialReceipt.ItemClick
        Me.OpenReceipt(Me.SelectedReceiptNo)
    End Sub

    Private Sub repoQuoteNo_Click(sender As Object, e As EventArgs) Handles repoQuoteNo.Click
        Dim strReceiptNo As String = Me.gvAdvBandedQuotationView.GetRowCellValue(Me.gvAdvBandedQuotationView.FocusedRowHandle, "ReceiptNo")
        If CheckIfNull(strReceiptNo) = True Then
            MessageBox.Show("Please select the Material Receipt No. to edit.", "Select Material Receipt No. to edit", MessageBoxButtons.OK)
        Else
            Me.OpenReceipt(strReceiptNo)
        End If
    End Sub

    Private Sub btnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteMaterialReceipt.ItemClick
        Try
            'Check if the JV is entered already using VoucherRefNO
            If CheckIfReceiptEntryAlreadyPosted(Me.SelectedReceiptNo) = True Then
                MessageBox.Show("This Receipt Entry is already posted to your ledgers.", "Receipt Posted Already.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Check if the Voucher is approved already
            If CheckIfReceiptIsApproved(Me.SelectedReceiptNo) = True Then
                MessageBox.Show("Material Receipt is already approved, You cannot delete the Approved Material Receipt.", "Material Receipt is Approved", MessageBoxButtons.OK)
                Exit Sub

            End If

            'Check if the VAT Purchase Bills is created already
            If CheckIfPurchaseBillAvailableForMR(Me.SelectedReceiptNo) = True Then
                MessageBox.Show("Purchase Bill has already been created for this Material Receipt Entry, You cannot delete this Material Receipt.", "Purchase Bill Already Available.", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Material Receipt from the Register," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.SelectedReceiptNo) = False Then
                    If DeleteReceipt(Me.SelectedReceiptNo) = True Then
                        'Delete the Files
                        DeleteDocumentPDF(Me.SelectedReceiptNo, "VoucherScanned\IMSReceipt")

                        MessageBox.Show("Material Receipt has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("IMS Material Receipt", "IMS Material Receipt Ref No." & Me.SelectedReceiptNo & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedReceiptNo)

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

    Public Function CheckIfReceiptEntryAlreadyPosted(ByVal ReceiptNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReceiptNo from tbl605_01MaterialReceiptMaster where (IsPosted = 1) and (ReceiptNo = '" & ReceiptNo & "')"

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

    Private Function CheckIfReceiptIsApproved(ByVal ReceiptNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReceiptNo from tbl605_01MaterialReceiptMaster where (ReceiptNo = '" & ReceiptNo & "') and (Isnull(IsApproved,0) = 1 )"

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
    Private Function DeleteReceipt(ByVal ReceiptNo As String) As Boolean
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

            delPRTrans.CommandText = "DELETE from tbl605_01MaterialReceiptMaster WHERE ReceiptNo   = '" & ReceiptNo & "'"
            delPRTrans.ExecuteNonQuery()
            delPRTrans.CommandText = "DELETE from tbl605_02MaterialReceiptChild WHERE ReceiptNo   = '" & ReceiptNo & "'"
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

    Private Sub btnAddNewInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewMRFromSupplier.ItemClick
        Dim frm601_09MaterialReceiptEdit As New frm601_09MaterialReceiptEdit
        frm601_09MaterialReceiptEdit.ObjForm = Me

        frm601_09MaterialReceiptEdit.btnSave.Caption = "Save"
        frm601_09MaterialReceiptEdit.isBeingNew = True


        frm601_09MaterialReceiptEdit.strLogonUser = Me.strLogOnUser
        frm601_09MaterialReceiptEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_09MaterialReceiptEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_09MaterialReceiptEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_09MaterialReceiptEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_09MaterialReceiptEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
        frm601_09MaterialReceiptEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

        frm601_09MaterialReceiptEdit.isExecutedFrom_frm601_10MaterialReceiptView = True

        frm601_09MaterialReceiptEdit.Show()

        GetCompanyDetails(1)
        Dim NewReceiptNo As String = frm601_09MaterialReceiptEdit.GetNewReceiptNo(gMaterialReceiptAbbrv, gInvoiceYearDigits, Date.Now, gIsResetDeliverInYear)
        frm601_09MaterialReceiptEdit.CreatedNewReceiptNo = NewReceiptNo
        frm601_09MaterialReceiptEdit.NewReceiptMaster(NewReceiptNo)
        frm601_09MaterialReceiptEdit.txtReceiptNo.EditValue = NewReceiptNo
        frm601_09MaterialReceiptEdit.txtReceiptDate.EditValue = Date.Today
        frm601_09MaterialReceiptEdit.selectedMaterialReceiptType = 1
        frm601_09MaterialReceiptEdit.UpdateDefaultFields()

        frm601_09MaterialReceiptEdit.txtMaterialReceiptType.Enabled = False
        frm601_09MaterialReceiptEdit.txtClientName.Enabled = False

    End Sub

    Private Sub btnUnlockInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnlockMaterialReceipt.ItemClick
        If Me.intLogOnUserLevel = 99 Then
            Me.UnlockTheReceipt(Me.SelectedReceiptNo)
            MessageBox.Show("Material Receipt has been unlocked successfully.", "Material Receipt Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Update the Delete Log File
            InsertUserEntryLogSheet("IMS Material Receipt", "IMS Material Receipt Ref No." & Me.SelectedReceiptNo & " has been Unlocked by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.SelectedReceiptNo)

            'Refresh the screen
            Me.RetrieveVoucher(Me.txtStartDate.EditValue, Me.txtEndDate.EditValue)
        Else
            MessageBox.Show("Your user access level cannot unlock the Material Receipt, Please review again.", "Access Permission Denied.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If

    End Sub

    Private Function UnlockTheReceipt(ByVal ReceiptNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            'strSqlQueryText = "UPDATE tbl605_01MaterialReceiptMaster Set IsApproved = 0, ApprovedBy = ''  where ReceiptNo = '" & ReceiptNo & "'"

            strSqlQueryText = "UPDATE tbl605_01MaterialReceiptMaster Set 
                                IsSubmitted = 0, SubmittedBy = '', SubmittedOn = NULL, 
                                IsVerified = 0, VerifiedBy = '', VerifiedOn = NULL, 
                                IsApproved = 0, ApprovedBy = '', ApprovedOn = NULL 
                                where ReceiptNo = '" & ReceiptNo & "'"

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
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_10MaterialReceiptView", Me.gvAdvBandedQuotationView)

        ImplementAccess()

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then
            colTotalBeforeTax.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalDiscount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalAfterDiscount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalTaxAmount.DisplayFormat.FormatString = "{0:#,0.000}"
            colTotalWithTax.DisplayFormat.FormatString = "{0:#,0.000}"
        End If
    End Sub

    Private Sub ImplementAccess()
        Try
            If GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_FullAccess") = True Then
                Me.btnShowAllRecords.Enabled = True
                Me.btnSaveLayout.Enabled = True
                Me.btnOpenLayout.Enabled = True
                Me.btnResetLayout.Enabled = True
                Me.btnSetDefaultLayout.Enabled = True
                Me.btnPrint.Enabled = True
                Me.btnSearch.Enabled = True
                Me.btnGroup.Enabled = True
                Me.btnReceiptDetails.Enabled = True
                Me.btnAddNewMRFromSupplier.Enabled = True
                Me.btnAddNewMRFromProjects.Enabled = True

                Me.btnEditMaterialReceipt.Enabled = True
                Me.btnDeleteMaterialReceipt.Enabled = True
                Me.btnUnlockMaterialReceipt.Enabled = True
                Me.btnCreateVATPurchaseBill.Enabled = True
            Else
                Me.btnShowAllRecords.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnShowAllRecords")
                Me.btnSaveLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnSaveLayout")
                Me.btnOpenLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnOpenLayout")
                Me.btnResetLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnResetLayout")
                Me.btnSetDefaultLayout.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnSetDefaultLayout")
                Me.btnPrint.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnPrint")
                Me.btnSearch.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnSearch")
                Me.btnGroup.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnGroup")
                Me.btnReceiptDetails.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnReceiptDetails")
                Me.btnAddNewMRFromSupplier.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnAddNewMRFromSupplier")
                Me.btnAddNewMRFromProjects.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnAddNewMRFromProjects")


                Me.btnEditMaterialReceipt.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnEditMaterialReceipt")
                Me.btnDeleteMaterialReceipt.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnDeleteMaterialReceipt")
                Me.btnUnlockMaterialReceipt.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnUnlockMaterialReceipt")
                Me.btnCreateVATPurchaseBill.Enabled = GetUserAccess(Me.intLogOnUserID, "frm601_10MaterialReceiptView_btnCreateVATPurchaseBill")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_10MaterialReceiptView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvAdvBandedQuotationView))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvAdvBandedQuotationView))
            End If
            MessageBox.Show("Your current data layout has been Set As Default layout.", "Layout Set As Default", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnCreateVATPurchaseBill_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateVATPurchaseBill.ItemClick
        'Check if the Purchase Voucher Invoice is generate for the Delivery Note

        If CheckIfPurchaseBillAvailableForMR(Me.SelectedReceiptNo) = True Then
            MessageBox.Show("Purchase Bill has already been created For this Material Receipt Entry, Please review again.", "Purchase Bill Already Available.", MessageBoxButtons.OK)
            Exit Sub

        End If

        If GetLedgerNoFromSupplierCode(SelectedSupplierCode) = "" Then
            MessageBox.Show("This Supplier details are Not mapped To Accounting Ledger, " & vbCrLf & "Please link this Supplier Details With Accounts Ledgers To create a VAT Purchase Bill.", "Supplier Ledger Account Is Not Linked.", MessageBoxButtons.OK)
            Exit Sub
        End If

        DialogResult = MessageBox.Show("You are about To create New VAT Purchase Bill." & vbCrLf & "Are you Sure want To Continue creating Purchase Bill?", "Confirm creating Purchase Bill.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.SelectedReceiptNo) = False Then

                'Get New VAT Purchase voucher Number
                GetCompanyDetails(1)
                Dim NewPurchaseVoucherNo As String = GetNewPurchaseVoucherNo("", gInvoiceYearDigits, Date.Now, gIsResetInvoiceInYear)


                GetCompanyDetails02(1)
                Dim NoOfDaysDue As Decimal = GetDueDateOfInvoice(GetLedgerNoFromSupplierCode(SelectedSupplierCode))

                If gIsDefaultInventoryLedgerInPurchase = True Then
                    Me.CreateInvoiceFromDeliveryNote(NewPurchaseVoucherNo, GetLedgerNoFromSupplierCode(SelectedSupplierCode),
                                                Me.SelectedReceiptNo, Me.strLogOnUser, gDefaultInventoryLedgerNo, Date.Today.AddDays(NoOfDaysDue))
                Else
                    Me.CreateInvoiceFromDeliveryNote(NewPurchaseVoucherNo, GetLedgerNoFromSupplierCode(SelectedSupplierCode),
                                                 Me.SelectedReceiptNo, Me.strLogOnUser, "", Date.Today.AddDays(NoOfDaysDue))
                End If


                Me.OpenPurchaseVoucher(NewPurchaseVoucherNo)

                ''Refresh the datagrid
                ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Function CheckIfPurchaseBillAvailableForMR(ByVal ReceiptNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ReceiptNo, VATPurchaseBillNo from tbl605_01MaterialReceiptMaster where (ReceiptNo = '" & ReceiptNo & "') and (VATPurchaseBillNo  IS NOT NULL)"

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

    Private Sub OpenPurchaseVoucher(ByVal PurchaseVoucherNo As String)
        If CheckIfNull(PurchaseVoucherNo) = False Then
            Dim frm20164VATPurchaseEdit As New frm20164VATPurchaseEdit
            frm20164VATPurchaseEdit.ObjForm = Me
            frm20164VATPurchaseEdit.txtInvoiceNo.Enabled = False
            frm20164VATPurchaseEdit.btnSave.Caption = "Update"


            frm20164VATPurchaseEdit.strLogonUser = Me.strLogOnUser
            frm20164VATPurchaseEdit.intLogOnUserID = Me.intLogOnUserID
            frm20164VATPurchaseEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm20164VATPurchaseEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel

            frm20164VATPurchaseEdit.isExecutedFrom_frm601_10MaterialReceiptView = True

            frm20164VATPurchaseEdit.Show()

            frm20164VATPurchaseEdit.txtMaterialReceiptNo.Enabled = True

            frm20164VATPurchaseEdit.RetrievePurchaseMaster(PurchaseVoucherNo)
            frm20164VATPurchaseEdit.DisableApprovedVoucherEditing(PurchaseVoucherNo)

            frm20164VATPurchaseEdit.txtSupplierName.Focus()
            frm20164VATPurchaseEdit.txtSupplierBillNo.Focus()



        End If
    End Sub

    Private Sub CreateInvoiceFromDeliveryNote(ByVal PurchaseVoucherNo As String, ByVal SupplierAccountNo As String, ByVal ReceiptNoteNo As String, ByVal AddedBy As String,
                                              ByVal DefaultPurchaseLedgerNo As String, ByVal BillDueDate As Date)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_16InsertToBillFromReceiptNote"
            Dim paramPurchaseVoucherNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@PurchaseVoucherNo", SqlDbType.VarChar)
            Dim paramSupplierAccountNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SupplierAccountNo", SqlDbType.VarChar)
            Dim paramReceiptNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ReceiptNoteNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramDefaultPurchaseLedgerNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DefaultPurchaseLedgerNo", SqlDbType.VarChar)
            Dim paramBillDueDate As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@BillDueDate", SqlDbType.Date)

            paramPurchaseVoucherNo.Value = PurchaseVoucherNo
            paramSupplierAccountNo.Value = SupplierAccountNo
            paramReceiptNoteNo.Value = ReceiptNoteNo
            paramAddedBy.Value = AddedBy
            paramDefaultPurchaseLedgerNo.Value = DefaultPurchaseLedgerNo
            paramBillDueDate.Value = BillDueDate

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New VAT Purchase Bill is created successfully,", "VAT Purchase Bill created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("VAT Purchase Bill Creation failed, Please try again", "VAT Purchase Bill Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnInvoiceDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceiptDetails.ItemClick
        Try
            Dim frm601_23MaterialReceiptsDetails As New frm601_23MaterialReceiptsDetails
            frm601_23MaterialReceiptsDetails.ObjForm = Me

            frm601_23MaterialReceiptsDetails.strLogOnUser = Me.strLogOnUser
            frm601_23MaterialReceiptsDetails.intLogOnUserID = Me.intLogOnUserID
            frm601_23MaterialReceiptsDetails.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_23MaterialReceiptsDetails.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_23MaterialReceiptsDetails.intLogOnDivision = Me.intLogOnDivision
            frm601_23MaterialReceiptsDetails.intLogOnHRLevelCode = Me.intLogOnHRLevelCode
            frm601_23MaterialReceiptsDetails.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_23MaterialReceiptsDetails.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_23MaterialReceiptsDetails.txtStartDate.EditValue = Me.txtStartDate.EditValue
            frm601_23MaterialReceiptsDetails.txtEndDate.EditValue = Me.txtEndDate.EditValue

            frm601_23MaterialReceiptsDetails.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_10MaterialReceiptView"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddNewMRFromProjects_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewMRFromProjects.ItemClick
        Dim frm601_09MaterialReceiptEdit As New frm601_09MaterialReceiptEdit
        frm601_09MaterialReceiptEdit.ObjForm = Me

        frm601_09MaterialReceiptEdit.btnSave.Caption = "Save"
        frm601_09MaterialReceiptEdit.isBeingNew = True

        frm601_09MaterialReceiptEdit.strLogonUser = Me.strLogOnUser
        frm601_09MaterialReceiptEdit.intLogOnUserID = Me.intLogOnUserID
        frm601_09MaterialReceiptEdit.intLogOnUserLevel = Me.intLogOnUserLevel
        frm601_09MaterialReceiptEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
        frm601_09MaterialReceiptEdit.intLogOnDivision = Me.intLogOnDivision
        frm601_09MaterialReceiptEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel

        frm601_09MaterialReceiptEdit.isExecutedFrom_frm601_10MaterialReceiptView = True

        frm601_09MaterialReceiptEdit.Show()

        GetCompanyDetails(1)
        Dim NewReceiptNo As String = frm601_09MaterialReceiptEdit.GetNewReceiptNo(gMaterialReceiptAbbrv, gInvoiceYearDigits, Date.Now, gIsResetDeliverInYear)
        frm601_09MaterialReceiptEdit.CreatedNewReceiptNo = NewReceiptNo
        frm601_09MaterialReceiptEdit.NewReceiptMaster(NewReceiptNo)
        frm601_09MaterialReceiptEdit.txtReceiptNo.EditValue = NewReceiptNo
        frm601_09MaterialReceiptEdit.txtReceiptDate.EditValue = Date.Today
        frm601_09MaterialReceiptEdit.selectedMaterialReceiptType = 3
        frm601_09MaterialReceiptEdit.UpdateDefaultFields()

        frm601_09MaterialReceiptEdit.txtMaterialReceiptType.Enabled = False

        frm601_09MaterialReceiptEdit.txtClientName.Enabled = False
        frm601_09MaterialReceiptEdit.txtSupplierName.Enabled = False


    End Sub
End Class