Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu

Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.Data.SqlTypes
Imports System.IO

Public Class frm600_14ProjectSubUnits

    Public frm600_14ProjectSubUnitsIsClosed As Boolean

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public ObjForm As Object

    Public isExecutedFrom_frm601_11PurchaseRequestEdit As Boolean = False

    Private Sub frm600_14ProjectSubUnits_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_14ProjectSubUnitsIsClosed = True
    End Sub

    Private Sub CheckForErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtProjectSubUnitName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtProjectSubUnitName, "Project Unit Name By cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtProjectSubUnitName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            CheckForErrors()

            If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
                MessageBox.Show("Cannot save while the entry have errors, Please clear the errors to continue.", "Errors in Entry", MessageBoxButtons.OK)
                Exit Sub
            End If

            'Check if the record already in the system
            If CheckIfSubRecordEnteredAlready(Me.txtProjectSubUnitName.EditValue) = True Then
                MessageBox.Show("This Stock Classification is already in the Database, Please Check again.", "Duplicate Entry", MessageBoxButtons.OK)
                Exit Sub
            End If

            Me.AddNewChild()

            Me.Validate()
            Me.Tbl60604PurchaseRequestProjectSubUnitsBindingSource.EndEdit()
            Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Update(Me.Dsfrm600_14ProjectSubUnits.tbl606_04PurchaseRequestProjectSubUnits)
            Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Fill(Me.Dsfrm600_14ProjectSubUnits.tbl606_04PurchaseRequestProjectSubUnits)
            Me.txtProjectSubUnitName.Text = ""
            UpdateEmployeeCategory()

        Catch ex As Exception

        End Try

    End Sub


    Private Function CheckIfSubRecordEnteredAlready(ByVal EntryName As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String

            strSqlQueryText = "SELECT ProjectSubUnitName FROM tbl606_04PurchaseRequestProjectSubUnits WHERE (ProjectSubUnitName = '" & EntryName & "')"

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

    Public Sub UpdateEmployeeCategory()
        If Me.isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
            Try
                'Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Fill(Me.Dsfrm601_11PurchaseRequestEdit.tbl606_04PurchaseRequestProjectSubUnits)
                CType(ObjForm, frm601_11PurchaseRequestEdit).Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Fill(CType(ObjForm, frm601_11PurchaseRequestEdit).Dsfrm601_11PurchaseRequestEdit.tbl606_04PurchaseRequestProjectSubUnits)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Project Sub Units Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm600_14ProjectSubUnits.Tables("tbl606_04PurchaseRequestProjectSubUnits")
            dr = dt.NewRow()
            dr("ProjectSubUnitCode") = GetNewProjectSubUnitCode()
            dr("ProjectSubUnitName") = Me.txtProjectSubUnitName.EditValue

            dt.Rows.Add(dr)
            Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Update(Me.Dsfrm600_14ProjectSubUnits.tbl606_04PurchaseRequestProjectSubUnits)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Purchase Order Category, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewProjectSubUnitCode() As String
        Dim strNewCandidateID As String
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(ProjectSubUnitCode as int)) from tbl606_04PurchaseRequestProjectSubUnits"
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
            Me.Tbl60604PurchaseRequestProjectSubUnitsBindingSource.EndEdit()
            Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Update(Me.Dsfrm600_14ProjectSubUnits.tbl606_04PurchaseRequestProjectSubUnits)

            MessageBox.Show("Projet Sub Unit List has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Fill(Me.Dsfrm600_14ProjectSubUnits.tbl606_04PurchaseRequestProjectSubUnits)

            UpdateEmployeeCategory()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frm600_14ProjectSubUnits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm600_14ProjectSubUnits.tbl606_04PurchaseRequestProjectSubUnits' table. You can move, or remove it, as needed.
        Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Fill(Me.Dsfrm600_14ProjectSubUnits.tbl606_04PurchaseRequestProjectSubUnits)

    End Sub


    Dim selectedSubID As Integer

    Private Sub gvEmpDocuments_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvDrillsDetails.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle

                Me.selectedSubID = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("ProjectSubUnitCode"))
                Me.popupSubForm.ShowPopup(MousePosition)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeleteEntry_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteEntry.ItemClick
        Try
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Master Record from the database." & vbCrLf & "You cannot revert the changes." & vbCrLf & "Are you Sure want to Delete?", "Delete Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(selectedSubID) = False Then
                    'Check the Record has any Sub Entered
                    If CheckIfSubRecordHasRows(selectedSubID) = False Then
                        If DeleteSubRecord(selectedSubID) = True Then
                            MessageBox.Show("Master Records has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Refresh the datagrid
                            Me.Tbl606_04PurchaseRequestProjectSubUnitsTableAdapter.Fill(Me.Dsfrm600_14ProjectSubUnits.tbl606_04PurchaseRequestProjectSubUnits)
                        Else
                            MessageBox.Show("Deleting Failed, please try again.", "Delete Failed", MessageBoxButtons.OK)
                        End If
                    Else
                        MessageBox.Show("The master list you are trying to delete, has some entries posted." & vbCrLf & "Please try to change the entries first and try deleting.", "Delete Failed", MessageBoxButtons.OK)
                    End If

                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Function CheckIfSubRecordHasRows(ByVal ProjectSubUnitCode As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            'SELECT    EmployeeID, AgencyHired FROM  tbl101Employees WHERE (AgencyHired = 2)
            strSqlQueryText = "SELECT MPRNo, ProjectSubUnitCode FROM  tbl606_01PurchaseRequestMaster WHERE (ProjectSubUnitCode =  '" & ProjectSubUnitCode & "')"

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
    Private Function DeleteSubRecord(ByVal SubFormID As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Delete from dbo.tbl606_04PurchaseRequestProjectSubUnits where ProjectSubUnitCode = '" & SubFormID & "'"


            Dim int1 As Integer
            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText

            int1 = SqlCommand1.ExecuteNonQuery()

            If int1 > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error Occured on Removing Master records" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try
    End Function


End Class