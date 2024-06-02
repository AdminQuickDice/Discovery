Public Class frm600_11InventoryDocuments 
    Public frm600_11InventoryDocumentsIsClosed As Boolean

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public ObjForm As Object

    Public SelectedGSCode As String

    Public isExecutedFrom_frm600_01InventoryStockEdit As Boolean = False

    Private Sub frm600_11InventoryDocuments_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_11InventoryDocumentsIsClosed = True
    End Sub
    Private Sub frm600_11InventoryDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm600_11InventoryStockDocuments1.tbl101DocumentType' table. You can move, or remove it, as needed.
        Me.Tbl101DocumentTypeTableAdapter.Fill(Me.Dsfrm600_11InventoryStockDocuments1.tbl101DocumentType)

    End Sub

    Public Sub FillDataSetforNew()

        Me.Tbl600_07InventoryStockDocumentsTableAdapter.FillByGSCode(Me.Dsfrm600_11InventoryStockDocuments.tbl600_07InventoryStockDocuments, Me.SelectedGSCode)
        Me.Tbl60007InventoryStockDocumentsBindingSource.AddNew()

    End Sub

    Private Sub CheckForErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtDocumentNo.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtDocumentNo, "Document Number Name cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtDocumentNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtDocumentType.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtDocumentType, "Document Type Name cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtDocumentType, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If


        If String.IsNullOrEmpty(ConvertIfNull(Me.txtDocExpiry.EditValue)) = False Then
            If Me.txtDocExpiry.EditValue <= Date.Today() Then
                Me.DxErrorProvider1.SetError(Me.txtDocExpiry, "Expiry date must be future date," & vbCrLf & " please check again.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Else
                Me.DxErrorProvider1.SetError(Me.txtDocExpiry, "")
            End If

            Me.DxErrorProvider1.SetError(Me.txtDocExpiry, "")
        Else
            Me.DxErrorProvider1.SetError(Me.txtDocExpiry, "Expiry date must be entered," & vbCrLf & " please check again.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtDocNotifyDate.EditValue)) = False Then
            Me.DxErrorProvider1.SetError(Me.txtDocNotifyDate, "")
        Else
            Me.DxErrorProvider1.SetError(Me.txtDocNotifyDate, "Notification date must be entered," & vbCrLf & " please check again.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            CheckForErrors()

            If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
                MessageBox.Show("Cannot save while the entry have errors, Please clear the errors to continue.", "Errors in Entry", MessageBoxButtons.OK)
                Exit Sub
            End If

            Me.AddNewChild()

            Me.Validate()
            Me.Tbl60007InventoryStockDocumentsBindingSource.EndEdit()
            Me.Tbl600_07InventoryStockDocumentsTableAdapter.Update(Me.Dsfrm600_11InventoryStockDocuments.tbl600_07InventoryStockDocuments)

            Me.Tbl600_07InventoryStockDocumentsTableAdapter.FillByGSCode(Me.Dsfrm600_11InventoryStockDocuments.tbl600_07InventoryStockDocuments, SelectedGSCode)

            Me.txtDocumentNo.Text = GetNewDocumentNo()
            Me.txtDocumentType.Text = ""
            Me.txtRefNo.Text = ""
            Me.txtRemarks.Text = ""
            Me.txtDocExpiry.EditValue = Date.Today()

            UpdateMaster()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateMaster()

        If isExecutedFrom_frm600_01InventoryStockEdit = True Then
            Try
                '  Me.Tbl600_07InventoryStockDocumentsTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit1.tbl600_07InventoryStockDocuments, StockCode)

                CType(ObjForm, frm600_01InventoryStockEdit).Tbl600_07InventoryStockDocumentsTableAdapter.FillByGSCode(CType(ObjForm, frm600_01InventoryStockEdit).Dsfrm600_01InventoryStockEdit1.tbl600_07InventoryStockDocuments, Me.SelectedGSCode)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Inventory Documents List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm600_11InventoryStockDocuments.Tables("tbl600_07InventoryStockDocuments")
            dr = dt.NewRow()
            dr("DocumentNo") = Me.txtDocumentNo.EditValue
            dr("GSCode") = Me.SelectedGSCode
            dr("DocumentType") = Me.txtDocumentType.EditValue
            dr("DocumentRefNo") = Me.txtRefNo.EditValue
            dr("DocumentRemarks") = Me.txtRemarks.EditValue

            dr("DocumentExpDate") = ConvertIfNullDate(Me.txtDocExpiry.EditValue)
            dr("DocumentExpDateAr") = Me.txtDocExpiryAr.EditValue
            dr("DocumentNotificationDate") = ConvertIfNullDate(Me.txtDocNotifyDate.EditValue)

            dt.Rows.Add(dr)
            Me.Tbl600_07InventoryStockDocumentsTableAdapter.Update(Me.Dsfrm600_11InventoryStockDocuments.tbl600_07InventoryStockDocuments)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Documents, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewDocumentNo() As String
        Dim strNewCandidateID As String
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(DocumentNo as int)) from tbl600_07InventoryStockDocuments"
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewCandidateID = int1

            Return strNewCandidateID

        Catch ex As System.InvalidCastException
            strNewCandidateID = 1
            Return strNewCandidateID

        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            Me.Validate()
            Me.Tbl60007InventoryStockDocumentsBindingSource.EndEdit()
            Me.Tbl600_07InventoryStockDocumentsTableAdapter.Update(Me.Dsfrm600_11InventoryStockDocuments.tbl600_07InventoryStockDocuments)

            MessageBox.Show("Inventory Documents List has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl600_07InventoryStockDocumentsTableAdapter.FillByGSCode(Me.Dsfrm600_11InventoryStockDocuments.tbl600_07InventoryStockDocuments, Me.SelectedGSCode)
            UpdateMaster()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub txtDocExpiry_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocExpiry.Validated
        If CheckIfNull(Me.txtDocExpiry.EditValue) = False Then
            Dates()
            Me.txtDocExpiryAr.EditValue = GregToHijri(Me.txtDocExpiry.Text)
        End If
    End Sub

    Private Sub txtDocExpiryAr_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocExpiryAr.Validated
        If CheckIfNull(Me.txtDocExpiryAr.EditValue) = False Then
            Dates()
            Me.txtDocExpiry.EditValue = HijriToGreg(Me.txtDocExpiryAr.Text)
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim strDocNo As String = Me.txtDocumentNo.EditValue
        strDocNo = Me.SelectedGSCode & "-" & strDocNo

        Dim nullcheck1 As Boolean = IsDBNull(Me.txtDocumentNo.EditValue)
        If nullcheck1 = True Then
            MessageBox.Show("No Records", "No Record", MessageBoxButtons.OK)
        Else
            GetCompanyDetails(1)
            Dim ScannedFileLocation As String = gScannedLocation
            ScannedFileLocation = gScannedLocation & "AssetsScanned\Inventory"
            ScannedFileLocation = ScannedFileLocation & strDocNo & ".pdf"


            If System.IO.File.Exists(ScannedFileLocation) = True Then
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = strDocNo
                frmDocuments.LoadDocument(ScannedFileLocation)
                frmDocuments.sourceFile = ScannedFileLocation
                frmDocuments.IsInventoryDocuments = True
                frmDocuments.Show()
            Else
                Dim frmDocuments As New frmScannedDoc
                frmDocuments.FileNo = strDocNo
                frmDocuments.IsInventoryDocuments = True
                frmDocuments.Show()
                frmDocuments.OpenFileDialogBox()

            End If

        End If
    End Sub

    Private Sub repoViewDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repoViewDocument.Click
        Try
            Dim strDocNo As String = Me.gvDrillsDetails.GetRowCellValue(Me.gvDrillsDetails.FocusedRowHandle, "DocumentNo")
            strDocNo = Me.SelectedGSCode & "-" & strDocNo

            Dim nullcheck1 As Boolean = IsDBNull(strDocNo)
            If nullcheck1 = True Then
                MessageBox.Show("No Records", "No Record", MessageBoxButtons.OK)
            Else
                GetCompanyDetails(1)
                Dim ScannedFileLocation As String = gScannedLocation
                ScannedFileLocation = gScannedLocation & "AssetsScanned\Inventory"
                ScannedFileLocation = ScannedFileLocation & strDocNo & ".pdf"

                If System.IO.File.Exists(ScannedFileLocation) = True Then
                    Dim frmDocuments As New frmScannedDoc
                    frmDocuments.FileNo = strDocNo
                    frmDocuments.LoadDocument(ScannedFileLocation)
                    frmDocuments.sourceFile = ScannedFileLocation
                    frmDocuments.IsInventoryDocuments = True
                    frmDocuments.Show()
                Else
                    'MessageBox.Show("No documents Attached", "No documents", MessageBoxButtons.OK)
                    Dim frmDocuments As New frmScannedDoc
                    frmDocuments.FileNo = strDocNo
                    frmDocuments.IsInventoryDocuments = True
                    frmDocuments.Show()
                    frmDocuments.OpenFileDialogBox()

                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvWorkSheet_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDrillsDetails.CellValueChanged
        If e.Column.Caption = "Expiry Arabic" Then
            Dim SelectedValue As String = e.Value
            Dim GreograinDate As Date
            'Convert Arabic date to english date
            If CheckIfNull(SelectedValue) = False Then
                Dates()
                GreograinDate = HijriToGreg(SelectedValue)
            End If

            gvDrillsDetails.SetRowCellValue(e.RowHandle, gvDrillsDetails.Columns("DocumentExpDate"), GreograinDate)

        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Tbl600_07InventoryStockDocumentsTableAdapter.FillByGSCode(Me.Dsfrm600_11InventoryStockDocuments.tbl600_07InventoryStockDocuments, Me.SelectedGSCode)
    End Sub

    Dim NoOfDaysReminder As Integer = 0
    Private Sub txtDocExpiry_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocExpiry.EditValueChanged
        Try
            'Get number of days for the document type
            If CheckIfNull(Me.txtDocNotifyDate.EditValue) = False Then
                NoOfDaysReminder = GetReminderDays(Me.txtDocumentType.EditValue)
            Else
                NoOfDaysReminder = 0
            End If

            Me.txtDocNotifyDate.EditValue = DateAdd(DateInterval.Day, -NoOfDaysReminder, Me.txtDocExpiry.EditValue)
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetReminderDays(ByVal DocumentTypeID As Integer) As Integer
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "SELECT isnull(ReminderDays,0) as ReminderDays FROM  tbl101DocumentType  WHERE (DocumentTypeID = '" & DocumentTypeID & "')"
            Dim NoOfDays As Integer
            NoOfDays = SqlCommand1.ExecuteScalar()
            Return NoOfDays

        Catch ex As System.InvalidCastException
            Return 0
        Finally
            Sqlconnection1.Close()

        End Try

    End Function

    Private Sub txtDocumentType_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDocumentType.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm101DocumentType As New frm101DocumentType
            frm101DocumentType.ObjForm = Me
            frm101DocumentType.Show()
            frm101DocumentType.txtDocumentType.Focus()
            frm101DocumentType.isExecutedFrom_frm600_11InventoryDocuments = True

        End If
    End Sub
End Class