Public Class frm600_03RequestedBy 
    Public frm600_03RequestedByIsClosed As Boolean

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public ObjForm As Object

    'Public isExecutedFrom_frm601_11PurchaseRequestEdit As Boolean = False
    Private Sub frm101Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_03RequestedByIsClosed = True
    End Sub

    Private Sub CheckForErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtPropertyCategory.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtPropertyCategory, "Material Requested By cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtPropertyCategory, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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
            Me.Tbl60002RequestedByBindingSource.EndEdit()
            Me.Tbl600_02RequestedByTableAdapter.Update(Me.Ds401SubForms.tbl600_02RequestedBy)
            Me.Tbl600_02RequestedByTableAdapter.Fill(Me.Ds401SubForms.tbl600_02RequestedBy)
            Me.txtPropertyCategory.Text = ""
            UpdateEmployeeCategory()

        Catch ex As Exception

        End Try

    End Sub


    Public Sub UpdateEmployeeCategory()
        'If Me.isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
        '    Try
        '        CType(ObjForm, frm601_11PurchaseRequestEdit).Tbl30103ModeOfRequestMasterTableAdapter.Fill(CType(ObjForm, frm601_11PurchaseRequestEdit).Dsfrm601_11PurchaseRequestEdit4.tbl30103ModeOfRequestMaster)
        '    Catch ex As Exception
        '        MessageBox.Show("Error Occured while Refreshing the Quotation Mode of Request Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End If
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Ds401SubForms.Tables("tbl600_02RequestedBy")
            dr = dt.NewRow()
            dr("RequestedByCode") = GetNewCategoryID()
            dr("RequestedBy") = Me.txtPropertyCategory.EditValue

            dt.Rows.Add(dr)
            Me.Tbl600_02RequestedByTableAdapter.Update(Me.Ds401SubForms.tbl600_02RequestedBy)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Material Requested By, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewCategoryID() As String
        Dim strNewCandidateID As String
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(RequestedByCode as int)) from tbl600_02RequestedBy"
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
            Me.Tbl60002RequestedByBindingSource.EndEdit()
            Me.Tbl600_02RequestedByTableAdapter.Update(Me.Ds401SubForms.tbl600_02RequestedBy)

            MessageBox.Show("Material Requested By List has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl600_02RequestedByTableAdapter.Fill(Me.Ds401SubForms.tbl600_02RequestedBy)

            UpdateEmployeeCategory()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub frm600_03RequestedBy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds401SubForms.tbl600_02RequestedBy' table. You can move, or remove it, as needed.
        Me.Tbl600_02RequestedByTableAdapter.Fill(Me.Ds401SubForms.tbl600_02RequestedBy)

    End Sub
     
End Class