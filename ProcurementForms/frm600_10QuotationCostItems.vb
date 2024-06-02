Public Class frm600_10QuotationCostItems 
    Public frm600_10QuotationCostItemsIsClosed As Boolean

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public ObjForm As Object

    Public isExecutedFrom_frm601_26QuoteCostSummary As Boolean = False

    Private Sub frm600_10QuotationCostItems_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_10QuotationCostItemsIsClosed = True
    End Sub

    Private Sub CheckForErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtCostItem.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtCostItem, "Cost Item By cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtCostItem, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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
            Me.Tbl60105QuotationCostMasterBindingSource.EndEdit()
            Me.Tbl601_05QuotationCostMasterTableAdapter.Update(Me.Dsfrm600_10QuotationCostItems.tbl601_05QuotationCostMaster)
            Me.Tbl601_05QuotationCostMasterTableAdapter.Fill(Me.Dsfrm600_10QuotationCostItems.tbl601_05QuotationCostMaster)
            Me.txtCostItem.Text = ""
            UpdateEmployeeCategory()

        Catch ex As Exception

        End Try

    End Sub


    Public Sub UpdateEmployeeCategory()
        If Me.isExecutedFrom_frm601_26QuoteCostSummary = True Then
            Try
                CType(ObjForm, frm601_26QuoteCostSummary).Tbl601_05QuotationCostMasterTableAdapter.Fill(CType(ObjForm, frm601_26QuoteCostSummary).Dsfrm601_26QuoteCostSummary.tbl601_05QuotationCostMaster)

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Quotation Mode of Request Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm600_10QuotationCostItems.Tables("tbl601_05QuotationCostMaster")
            dr = dt.NewRow()
            dr("CostItemCode") = GetNewCategoryID()
            dr("CostItem") = Me.txtCostItem.EditValue

            dt.Rows.Add(dr)
            Me.Tbl601_05QuotationCostMasterTableAdapter.Update(Me.Dsfrm600_10QuotationCostItems.tbl601_05QuotationCostMaster)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Cost Items, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewCategoryID() As String

        Dim strNewCostItemCode As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(right(CostItemCode,3) as int)) from tbl601_05QuotationCostMaster where CostItemCode like 'A-%'"
            
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1


            strNewCostItemCode = "0000" & CStr(int1)
            strNewCostItemCode = Microsoft.VisualBasic.Right(strNewCostItemCode, 3)

            strNewCostItemCode = "A-" & strNewCostItemCode
            Return strNewCostItemCode

        Catch ex As System.InvalidCastException
            strNewCostItemCode = "A-" & "001"
            Return strNewCostItemCode

        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            Me.Validate()
            Me.Tbl60105QuotationCostMasterBindingSource.EndEdit()
            Me.Tbl601_05QuotationCostMasterTableAdapter.Update(Me.Dsfrm600_10QuotationCostItems.tbl601_05QuotationCostMaster)

            MessageBox.Show("Quotation Cost Items has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl601_05QuotationCostMasterTableAdapter.Fill(Me.Dsfrm600_10QuotationCostItems.tbl601_05QuotationCostMaster)

            UpdateEmployeeCategory()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub frm600_10QuotationCostItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm600_10QuotationCostItems.tbl601_05QuotationCostMaster' table. You can move, or remove it, as needed.
        Me.Tbl601_05QuotationCostMasterTableAdapter.Fill(Me.Dsfrm600_10QuotationCostItems.tbl601_05QuotationCostMaster)

    End Sub
End Class