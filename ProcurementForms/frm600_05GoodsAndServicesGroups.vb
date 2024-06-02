Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu

Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.Data.SqlTypes
Imports System.IO
Public Class frm600_05GoodsAndServicesGroups
    Public frm600_05GoodsAndServicesGroupsIsClosed As Boolean

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer

    Public ObjForm As Object

    Public isExecutedFrom_frm20163VATGoodsAndServicesEdit As Boolean = False
    Public isExecutedFrom_frm600_01InventoryStockEdit As Boolean = False

    Private Sub frm101EmployeeGroup_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_05GoodsAndServicesGroupsIsClosed = True
    End Sub

    Private Sub CheckForErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtGroupName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtGroupName, "Stock/Services Group cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtGroupName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtGroupCode.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtGroupCode, "Stock/Services Group Code cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtGroupCode, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtInventoryMasterGroup.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtInventoryMasterGroup, "Inventory Master Group Code cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtInventoryMasterGroup, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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
            If CheckIfSubRecordEnteredAlready(Me.txtGroupName.EditValue) = True Then
                MessageBox.Show("This Stock/Services Group is already in the Database, Please Check again.", "Duplicate Entry", MessageBoxButtons.OK)
                Exit Sub
            End If

            Me.AddNewChild()

            Me.Validate()
            Me.Tbl20165GoodsAndServicesGroupBindingSource.EndEdit()
            Me.Tbl20165GoodsAndServicesGroupTableAdapter.Update(Me.Dsfrm600_05GoodsAndServicesGroups.tbl20165GoodsAndServicesGroup)

            Me.Tbl20165GoodsAndServicesGroupTableAdapter.Fill(Me.Dsfrm600_05GoodsAndServicesGroups.tbl20165GoodsAndServicesGroup)
            Me.txtGroupName.Text = ""
            Me.txtGroupNameAr.Text = ""
            Me.txtGroupCode.Text = ""
            Me.txtGroupCategory.Text = ""
            Me.txtCostLedger.Text = ""
            Me.txtInventoryLedger.Text = ""
            Me.txtInventoryMasterGroup.Text = ""

            UpdateRenumeration()

            Me.txtGroupName.Focus()

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
            strSqlQueryText = "SELECT GSGroupName FROM tbl20165GoodsAndServicesGroup WHERE (GSGroupName = '" & EntryName & "')"

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

    Public Sub UpdateRenumeration()

        'If isExecutedFrom_frm20163VATGoodsAndServicesEdit = True Then
        '    Try
        '        CType(ObjForm, frm20163VATGoodsAndServicesEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(ObjForm, frm20163VATGoodsAndServicesEdit).Dsfrm20163VATGoodsAndServices1.tbl40111PropertyUnitCodes)
        '    Catch ex As Exception
        '        MessageBox.Show("Error Occured while Refreshing the UoM Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End If

        If isExecutedFrom_frm600_01InventoryStockEdit = True Then
            Try
                'Me.Tbl20165GoodsAndServicesGroupTableAdapter.Fill(Me.Dsfrm600_01InventoryStockEdit.tbl20165GoodsAndServicesGroup)
                CType(ObjForm, frm600_01InventoryStockEdit).Tbl20165GoodsAndServicesGroupTableAdapter.Fill(CType(ObjForm, frm600_01InventoryStockEdit).Dsfrm600_01InventoryStockEdit.tbl20165GoodsAndServicesGroup)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Stock/Services Group Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm600_05GoodsAndServicesGroups.Tables("tbl20165GoodsAndServicesGroup")
            dr = dt.NewRow()
            dr("GSGroupID") = GetNewStockGroupID()
            dr("GSGroupName") = Me.txtGroupName.EditValue
            dr("GSGroupNameAr") = Me.txtGroupNameAr.EditValue
            dr("GSGroupCode") = Me.txtGroupCode.EditValue
            dr("GSCategory") = Me.txtGroupCategory.EditValue
            dr("IsServicesGroup") = Me.txtIsServiceGroup.EditValue
            dr("GSGroupInventoryLedger") = Me.txtInventoryLedger.EditValue
            dr("GSGroupExpenseLedger") = Me.txtCostLedger.EditValue
            dr("InventoryMasterGroupID") = Me.txtInventoryMasterGroup.EditValue

            dt.Rows.Add(dr)
            Me.Tbl20165GoodsAndServicesGroupTableAdapter.Update(Me.Dsfrm600_05GoodsAndServicesGroups.tbl20165GoodsAndServicesGroup)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Stock/Services Group, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function GetNewStockGroupID() As String
        Dim strNewCandidateID As String
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(GSGroupID as int)) from tbl20165GoodsAndServicesGroup"
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
            Me.Tbl20165GoodsAndServicesGroupBindingSource.EndEdit()
            Me.Tbl20165GoodsAndServicesGroupTableAdapter.Update(Me.Dsfrm600_05GoodsAndServicesGroups.tbl20165GoodsAndServicesGroup)

            MessageBox.Show("Stock/Services Group has been Successfully updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl20165GoodsAndServicesGroupTableAdapter.Fill(Me.Dsfrm600_05GoodsAndServicesGroups.tbl20165GoodsAndServicesGroup)

            UpdateRenumeration()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub frm600_05GoodsAndServicesGroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tbl201ChartOfAccounts_InvntryLedgersTableAdapter.FillInventoryLedgers(Me.Dsfrm600_05GoodsAndServicesGroups2.tbl201ChartOfAccounts_InvntryLedgers)
        Me.Tbl201ChartOfAccountsTableAdapter.FillExpenseLedgers(Me.Dsfrm600_05GoodsAndServicesGroups2.tbl201ChartOfAccounts)


        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl600_08InventoryMasterGroupTableAdapter.Fill(Me.Dsfrm600_05GoodsAndServicesGroups3.tbl600_08InventoryMasterGroup)
        Else
            Me.Tbl600_08InventoryMasterGroupTableAdapter.FillByInventoryMasterGroupID(Me.Dsfrm600_05GoodsAndServicesGroups3.tbl600_08InventoryMasterGroup, Me.intLogOnInventoryAccessLevel)
        End If

        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl20165GoodsAndServicesGroupTableAdapter.Fill(Me.Dsfrm600_05GoodsAndServicesGroups.tbl20165GoodsAndServicesGroup)
        Else
            Me.Tbl20165GoodsAndServicesGroupTableAdapter.FillByInventoryMasterGroupID(Me.Dsfrm600_05GoodsAndServicesGroups.tbl20165GoodsAndServicesGroup, Me.intLogOnInventoryAccessLevel)
        End If

    End Sub

    Dim selectedSubID As Integer
    Private Sub gvSubRecord_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvSubRecord.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle

                Me.selectedSubID = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("GSGroupID"))
                Me.popupSubForm.ShowPopup(MousePosition)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeleteEntry_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteEntry.ItemClick
        Try

            If CheckIfSubRecordIsUndeleteable(selectedSubID) = True Then
                MessageBox.Show("You cannot delete this Item. This is default System Entry, cannot be deleted.", "System Entry: Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Master Record from the database." & vbCrLf & "You cannot revert the changes." & vbCrLf & "Are you Sure want to Delete?", "Delete Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(selectedSubID) = False Then
                    'Check the Record has any Sub Entered
                    If CheckIfSubRecordHasRows(selectedSubID) = False Then
                        If DeleteSubRecord(selectedSubID) = True Then
                            MessageBox.Show("Master Records has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Refresh the datagrid
                            Me.Tbl20165GoodsAndServicesGroupTableAdapter.Fill(Me.Dsfrm600_05GoodsAndServicesGroups.tbl20165GoodsAndServicesGroup)
                            UpdateRenumeration()
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

    Private Function CheckIfSubRecordIsUndeleteable(ByVal GSGroupID As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String

            strSqlQueryText = "SELECT GSGroupID  FROM  tbl20165GoodsAndServicesGroup WHERE (GSGroupID =  '" & GSGroupID & "') and Isnull(IsUnDeletable, 0) = 1"

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

    Private Function CheckIfSubRecordHasRows(ByVal GSGroupID As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String

            strSqlQueryText = "SELECT GSGroupID FROM  tbl20164GoodsAndServicesMaster WHERE (GSGroupID =  '" & GSGroupID & "')"

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
            strSqlQueryText = "Delete from dbo.tbl20165GoodsAndServicesGroup where GSGroupID = '" & SubFormID & "'"


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

    Private Sub txtAccountHeadArabic_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtGroupNameAr.ButtonClick
        If e.Button.Index = 0 Then
            Me.txtGroupNameAr.EditValue = TranslateToArabic(Me.txtGroupName.EditValue)
        End If
    End Sub
End Class