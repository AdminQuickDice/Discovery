Public Class frm600_03ClientContactList 
    Public ObjForm As Object

    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public isExecutedFrom_frm601_01QuotationEdit As Boolean = False
    Public isExecutedFrom_frm40103PropertyQuote As Boolean = False
    Public isExecutedFrom_frm601_11PurchaseRequestEdit As Boolean = False
    Public isExecutedFrom_frm601_05DeliveryNoteEdit As Boolean = False
    Public isExecutedFrom_frm601_03SalesOrderEdit As Boolean = False
    Public isExecutedFrom_frm40109PropIssueMaster As Boolean = False
    Public isExecutedFrom_frm601_20PropertySalesOrderEdit As Boolean = False
    '

    Public Sub FillDataSetforEditing(ByVal ClientCode As String)
        Me.Tbl30101_02ClientContactListTableAdapter.FillByClientCode(Me.Dsfrm600_03ClientContactList.tbl30101_02ClientContactList, ClientCode)
    End Sub


    Dim ClientContactSlNo As Integer
    Dim ClientCode As String = ""
    Dim ClientContactPerson As String = ""
    Dim ClientContactPhone1 As String = ""
    Dim ClientContactEmail As String = ""
    Dim ContactPersonTitle As String = ""

    Private Sub repoAddClientContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repoAddClientContact.Click
        Try

            ClientContactSlNo = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "ClientContactSlNo")
            ClientCode = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "ClientCode")
            ClientContactPerson = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "ContactPerson")
            ClientContactPhone1 = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "ContactPhone1")
            ClientContactEmail = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "ContactEmail")

            ContactPersonTitle = Me.gvContactList.GetRowCellValue(Me.gvContactList.FocusedRowHandle, "ContactPersonTitle")

            Me.InsertSelectedContactDetails(ClientContactSlNo)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
        End Try
    End Sub


    Private Sub InsertSelectedContactDetails(ByVal ClientContactSlNo As String)

        If Me.isExecutedFrom_frm601_01QuotationEdit = True Then
            Try
                CType(ObjForm, frm601_01QuotationEdit).txtClientRefName.EditValue = Me.ClientContactPerson & ", " & Me.ContactPersonTitle
                CType(ObjForm, frm601_01QuotationEdit).txtClientContactNo.EditValue = Me.ClientContactPhone1
                CType(ObjForm, frm601_01QuotationEdit).txtClientEmail.EditValue = Me.ClientContactEmail

                CType(ObjForm, frm601_01QuotationEdit).txtClientRefName.Focus()

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Client Contact." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If Me.isExecutedFrom_frm40103PropertyQuote = True Then
            Try
                CType(ObjForm, frm40103PropertyQuote).txtClientRefName.EditValue = Me.ClientContactPerson & ", " & Me.ContactPersonTitle
                CType(ObjForm, frm40103PropertyQuote).txtClientContactNo.EditValue = Me.ClientContactPhone1
                CType(ObjForm, frm40103PropertyQuote).txtClientEmail.EditValue = Me.ClientContactEmail

                CType(ObjForm, frm40103PropertyQuote).txtClientRefName.Focus()
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Client Contact." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If Me.isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
            Try
                CType(ObjForm, frm601_11PurchaseRequestEdit).txtClientRefName.EditValue = Me.ClientContactPerson & ", " & Me.ContactPersonTitle
                CType(ObjForm, frm601_11PurchaseRequestEdit).txtClientContactNo.EditValue = Me.ClientContactPhone1
                CType(ObjForm, frm601_11PurchaseRequestEdit).txtClientEmail.EditValue = Me.ClientContactEmail

                CType(ObjForm, frm601_11PurchaseRequestEdit).txtClientRefName.Focus()


            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Client Contact." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If Me.isExecutedFrom_frm601_05DeliveryNoteEdit = True Then
            Try
                CType(ObjForm, frm601_05DeliveryNoteEdit).txtClientRefName.EditValue = Me.ClientContactPerson & ", " & Me.ContactPersonTitle
                CType(ObjForm, frm601_05DeliveryNoteEdit).txtClientContactNo.EditValue = Me.ClientContactPhone1
                CType(ObjForm, frm601_05DeliveryNoteEdit).txtClientEmail.EditValue = Me.ClientContactEmail

                CType(ObjForm, frm601_05DeliveryNoteEdit).txtClientRefName.Focus()
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Client Contact." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        '
        If Me.isExecutedFrom_frm601_03SalesOrderEdit = True Then
            Try
                CType(ObjForm, frm601_03SalesOrderEdit).txtClientRefName.EditValue = Me.ClientContactPerson & ", " & Me.ContactPersonTitle
                CType(ObjForm, frm601_03SalesOrderEdit).txtClientContactNo.EditValue = Me.ClientContactPhone1
                CType(ObjForm, frm601_03SalesOrderEdit).txtClientEmail.EditValue = Me.ClientContactEmail

                CType(ObjForm, frm601_03SalesOrderEdit).txtClientRefName.Focus()

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Client Contact." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        '
        If Me.isExecutedFrom_frm40109PropIssueMaster = True Then
            Try
                CType(ObjForm, frm40109PropIssueMaster).txtClientRefName.EditValue = Me.ClientContactPerson & ", " & Me.ContactPersonTitle
                CType(ObjForm, frm40109PropIssueMaster).txtClientContactNo.EditValue = Me.ClientContactPhone1
                CType(ObjForm, frm40109PropIssueMaster).txtClientEmail.EditValue = Me.ClientContactEmail

                CType(ObjForm, frm40109PropIssueMaster).txtClientRefName.Focus()

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Client Contact." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        '
        If Me.isExecutedFrom_frm601_20PropertySalesOrderEdit = True Then
            Try
                CType(ObjForm, frm601_20PropertySalesOrderEdit).txtClientRefName.EditValue = Me.ClientContactPerson & ", " & Me.ContactPersonTitle
                CType(ObjForm, frm601_20PropertySalesOrderEdit).txtClientContactNo.EditValue = Me.ClientContactPhone1
                CType(ObjForm, frm601_20PropertySalesOrderEdit).txtClientEmail.EditValue = Me.ClientContactEmail

                CType(ObjForm, frm601_20PropertySalesOrderEdit).txtClientRefName.Focus()

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Client Contact." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
End Class