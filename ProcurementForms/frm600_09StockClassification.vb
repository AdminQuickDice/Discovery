Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu

Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.Data.SqlTypes
Imports System.IO
Public Class frm600_09StockClassification
    Public frm600_09StockClassificationIsClosed As Boolean

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public ObjForm As Object

    Public isExecutedFrom_frm600_01InventoryStockEdit As Boolean = False

    Private Sub frm101Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_09StockClassificationIsClosed = True
    End Sub

    Private Sub CheckForErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtPropertyCategory.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtPropertyCategory, "Stock Classification Name By cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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

            'Check if the record already in the system
            If CheckIfSubRecordEnteredAlready(Me.txtPropertyCategory.EditValue) = True Then
                MessageBox.Show("This Stock Classification is already in the Database, Please Check again.", "Duplicate Entry", MessageBoxButtons.OK)
                Exit Sub
            End If

            Me.AddNewChild()

            Me.Validate()
            Me.Tbl30111StockClassificationMasterBindingSource.EndEdit()
            Me.Tbl30111StockClassificationMasterTableAdapter.Update(Me.Ds401SubForms1.tbl30111StockClassificationMaster)
            Me.Tbl30111StockClassificationMasterTableAdapter.Fill(Me.Ds401SubForms1.tbl30111StockClassificationMaster)
            Me.txtPropertyCategory.Text = ""
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

            strSqlQueryText = "SELECT StockClassification FROM tbl30111StockClassificationMaster WHERE (StockClassification = '" & EntryName & "')"

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
        If Me.isExecutedFrom_frm600_01InventoryStockEdit = True Then
            Try
                'Me.Tbl30111StockClassificationMasterTableAdapter.Fill(Me.Dsfrm600_01InventoryStockEdit.tbl30111StockClassificationMaster)
                CType(ObjForm, frm600_01InventoryStockEdit).Tbl30111StockClassificationMasterTableAdapter.Fill(CType(ObjForm, frm600_01InventoryStockEdit).Dsfrm600_01InventoryStockEdit.tbl30111StockClassificationMaster)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Stock Classification Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Ds401SubForms1.Tables("tbl30111StockClassificationMaster")
            dr = dt.NewRow()
            dr("StockClassID") = GetNewCategoryID()
            dr("StockClassification") = Me.txtPropertyCategory.EditValue

            dt.Rows.Add(dr)
            Me.Tbl30111StockClassificationMasterTableAdapter.Update(Me.Ds401SubForms1.tbl30111StockClassificationMaster)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Stock Classification, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
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
            SqlCommand1.CommandText = "select max(cast(StockClassID as int)) from tbl30111StockClassificationMaster"
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
            Me.Tbl30111StockClassificationMasterBindingSource.EndEdit()
            Me.Tbl30111StockClassificationMasterTableAdapter.Update(Me.Ds401SubForms1.tbl30111StockClassificationMaster)

            MessageBox.Show("Stock Classification By List has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl30111StockClassificationMasterTableAdapter.Fill(Me.Ds401SubForms1.tbl30111StockClassificationMaster)

            UpdateEmployeeCategory()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frm600_09StockClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds401SubForms1.tbl30111StockClassificationMaster' table. You can move, or remove it, as needed.
        Me.Tbl30111StockClassificationMasterTableAdapter.Fill(Me.Ds401SubForms1.tbl30111StockClassificationMaster)

    End Sub

    Dim selectedSubID As Integer

    Private Sub gvEmpDocuments_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvDrillsDetails.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle

                Me.selectedSubID = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("StockClassID"))
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
                            Me.Tbl30111StockClassificationMasterTableAdapter.Fill(Me.Ds401SubForms1.tbl30111StockClassificationMaster)
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

    Private Function CheckIfSubRecordHasRows(ByVal ItemClassificationId As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            'SELECT    EmployeeID, AgencyHired FROM  tbl101Employees WHERE (AgencyHired = 2)
            strSqlQueryText = "SELECT GSCode, ItemClassificationId FROM  tbl20164GoodsAndServicesMaster WHERE (ItemClassificationId =  '" & ItemClassificationId & "')"

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
            strSqlQueryText = "Delete from dbo.tbl30111StockClassificationMaster where StockClassID = '" & SubFormID & "'"


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