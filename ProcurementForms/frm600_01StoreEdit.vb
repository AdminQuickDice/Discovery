Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu

Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.Data.SqlTypes
Imports System.IO
Public Class frm600_01StoreEdit
    Public frm600_01StoreEditIsClosed As Boolean

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public ObjForm As Object

    Public isExecutedFrom_frm601_05DeliveryNoteEdit As Boolean = False
    Public isExecutedFrom_frm600_01InventoryStockEdit As Boolean = False
    Public isExecutedFrom_frm601_11PurchaseRequestEdit As Boolean = False


    Private Sub frm600_01StoreEdit_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_01StoreEditIsClosed = True
    End Sub

    Private Sub CheckForErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtStoreName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtStoreName, "Store Name cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtStoreName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtStoreCode.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtStoreCode, "Store Code cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtStoreCode, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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
            If CheckIfSubRecordEnteredAlready(Me.txtStoreName.EditValue) = True Then
                MessageBox.Show("This Store Name is already in the Database, Please Check again.", "Duplicate Entry", MessageBoxButtons.OK)
                Exit Sub
            End If

            Me.AddNewChild()

            Me.Validate()
            Me.Tbl60001StoreMasterBindingSource.EndEdit()
            Me.Tbl600_01StoreMasterTableAdapter.Update(Me.Dsfrm600_01StoreEdit.tbl600_01StoreMaster)

            Me.Tbl600_01StoreMasterTableAdapter.Fill(Me.Dsfrm600_01StoreEdit.tbl600_01StoreMaster)

            Me.txtStoreName.Text = ""
            Me.txtStoreCode.Text = ""

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
            strSqlQueryText = "SELECT StoreName FROM tbl600_01StoreMaster WHERE (StoreName = '" & EntryName & "')"

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

        If isExecutedFrom_frm601_05DeliveryNoteEdit = True Then
            Try
                CType(ObjForm, frm601_05DeliveryNoteEdit).Tbl600_01StoreMasterTableAdapter.Fill(CType(ObjForm, frm601_05DeliveryNoteEdit).Dsfrm601_05DeliveryNoteEdit.tbl600_01StoreMaster)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Store Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If isExecutedFrom_frm600_01InventoryStockEdit = True Then
            Try
                CType(ObjForm, frm600_01InventoryStockEdit).Tbl600_01StoreMasterTableAdapter.Fill(CType(ObjForm, frm600_01InventoryStockEdit).Dsfrm600_01InventoryStockEdit6.tbl600_01StoreMaster)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Store Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


        If isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
            Try

                CType(ObjForm, frm601_11PurchaseRequestEdit).Tbl600_01StoreMasterTableAdapter.Fill(CType(ObjForm, frm601_11PurchaseRequestEdit).Dsfrm601_11PurchaseRequestEdit4.tbl600_01StoreMaster)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Store Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm600_01StoreEdit.Tables("tbl600_01StoreMaster")
            dr = dt.NewRow()
            dr("StoreID") = Me.txtStoreCode.EditValue
            dr("StoreName") = Me.txtStoreName.EditValue
            
            dt.Rows.Add(dr)
            Me.Tbl600_01StoreMasterTableAdapter.Update(Me.Dsfrm600_01StoreEdit.tbl600_01StoreMaster)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Store, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            Me.Validate()
            Me.Tbl60001StoreMasterBindingSource.EndEdit()
            Me.Tbl600_01StoreMasterTableAdapter.Update(Me.Dsfrm600_01StoreEdit.tbl600_01StoreMaster)

            MessageBox.Show("Store List has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl600_01StoreMasterTableAdapter.Fill(Me.Dsfrm600_01StoreEdit.tbl600_01StoreMaster)


            UpdateEmployeeCategory()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Dim selectedSubID As Integer

    Private Sub gvEmpDocuments_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvSubDetails.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle

                Me.selectedSubID = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("StoreID"))
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
                            Me.Tbl600_01StoreMasterTableAdapter.Fill(Me.Dsfrm600_01StoreEdit.tbl600_01StoreMaster)
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

    Private Function CheckIfSubRecordHasRows(ByVal StoreCode As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            'SELECT    EmployeeID, AgencyHired FROM  tbl101Employees WHERE (AgencyHired = 2)
            strSqlQueryText = "SELECT StoreCode  FROM  tbl603_01DeliveryNoteMaster WHERE (StoreCode =  '" & StoreCode & "')"

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
            strSqlQueryText = "Delete from dbo.tbl600_01StoreMaster where StoreID = '" & SubFormID & "'"

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
    Private Sub frm600_01StoreEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl201CostAllocationUnitsTableAdapter.Fill(Me.Dsfrm600_01StoreEdit1.tbl201CostAllocationUnits)
        Me.Tbl600_01StoreMasterTableAdapter.Fill(Me.Dsfrm600_01StoreEdit.tbl600_01StoreMaster)

    End Sub
End Class