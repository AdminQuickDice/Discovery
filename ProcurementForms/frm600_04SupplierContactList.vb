Public Class frm600_04SupplierContactList 
    Public ObjForm As Object

    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public isExecutedFrom_frm601_07PurchaseOrderEdit As Boolean = False
    Public isExecutedFrom_frm601_13RFQMaster As Boolean = False

    Public Sub FillDataSetforEditing(ByVal SupplierCode As String)
        Me.Tbl3019902_SupplierContactListTableAdapter.FillBySupplierCode(Me.Dsfrm600_04SupplierContactList.tbl3019902_SupplierContactList, SupplierCode)
    End Sub


    Dim SupplierContactSlNo As Integer
    Dim SupplierCode As String = ""
    Dim SupplierContactPerson As String = ""
    Dim SupplierContactPhone1 As String = ""
    Dim SupplierContactEmail As String = ""

    Private Sub repoAddClientContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repoAddClientContact.Click
        Try

            SupplierContactSlNo = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "SupplierContactSlNo")
            SupplierCode = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "SupplierCode")
            SupplierContactPerson = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "ContactPerson")
            SupplierContactPhone1 = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "ContactPhone1")
            SupplierContactEmail = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "ContactEmail")

            Me.InsertSelectedContactDetails(SupplierContactSlNo)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
        End Try
    End Sub


    Private Sub InsertSelectedContactDetails(ByVal ClientContactSlNo As String)

        If Me.isExecutedFrom_frm601_07PurchaseOrderEdit = True Then
            Try
                CType(ObjForm, frm601_07PurchaseOrderEdit).txtClientRefName.EditValue = Me.SupplierContactPerson
                CType(ObjForm, frm601_07PurchaseOrderEdit).txtClientContactNo.EditValue = Me.SupplierContactPhone1
                CType(ObjForm, frm601_07PurchaseOrderEdit).txtClientEmail.EditValue = Me.SupplierContactEmail

                CType(ObjForm, frm601_07PurchaseOrderEdit).txtClientRefName.Focus()

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Supplier Contact." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If Me.isExecutedFrom_frm601_13RFQMaster = True Then
            Try
                CType(ObjForm, frm601_13RFQMaster).txtClientRefName.EditValue = Me.SupplierContactPerson
                CType(ObjForm, frm601_13RFQMaster).txtClientContactNo.EditValue = Me.SupplierContactPhone1
                CType(ObjForm, frm601_13RFQMaster).txtClientEmail.EditValue = Me.SupplierContactEmail

                CType(ObjForm, frm601_13RFQMaster).txtClientRefName.Focus()

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Supplier Contact." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
       
    End Sub
End Class