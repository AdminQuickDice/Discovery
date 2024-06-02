Public Class frm601_18TermsAndCondNew
    Public objForm As Object

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    '
    Public isExecutedFrom_frm600_06DocumentConditions As Boolean

    Private Sub frm601_18TermsAndCondNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl6001_04ConditionsGroupTableAdapter.Fill(Me.Dsfrm601_18TermsAndCondNew1.tbl6001_04ConditionsGroup)
        Me.Tbl600_04TermsConditionsMasterTableAdapter.Fill(Me.Dsfrm601_18TermsAndCondNew.tbl600_04TermsConditionsMaster)

        FillCombobox()

    End Sub

    Public Sub NewConditions(ByVal ConditionCode As String)
        Try
            If CheckIfNull(ConditionCode) = False Then
                Me.Tbl60004TermsConditionsMasterBindingSource.AddNew()
                Me.txtConditionsCode2.EditValue = ConditionCode
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Terms & Condition Document", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub FillConditions(ByVal ConditionsCode As String)
        Me.Tbl600_04TermsConditionsMasterTableAdapter.FillByConditionsCode(Me.Dsfrm601_18TermsAndCondNew.tbl600_04TermsConditionsMaster, ConditionsCode)

    End Sub

    Public Sub SaveConditions()
        Try
            Me.Validate()
            Me.Tbl60004TermsConditionsMasterBindingSource.EndEdit()
            Me.Tbl600_04TermsConditionsMasterTableAdapter.Update(Me.Dsfrm601_18TermsAndCondNew.tbl600_04TermsConditionsMaster)

            MessageBox.Show("Terms & Conditions has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl600_04TermsConditionsMasterTableAdapter.Fill(Me.Dsfrm601_18TermsAndCondNew.tbl600_04TermsConditionsMaster)

            RefreshDocumentMasterDataGrid()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshDocumentMasterDataGrid()
        If isExecutedFrom_frm600_06DocumentConditions = True Then
            Try
                CType(objForm, frm600_06DocumentConditions).Tbl600_04TermsConditionsMasterTableAdapter.Fill(CType(objForm, frm600_06DocumentConditions).Dsfrm600_06DocumentConditions1.tbl600_04TermsConditionsMaster)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Terms and Conditions List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        '
    End Sub

    Private Sub btnSaveAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
        SaveConditions()
        Me.Close()

    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        SaveConditions()
    End Sub


    Public Sub FillCombobox()

        'Fill Terms Category
        Me.txtConditionsType.Properties.Items.Clear()

        For Each row As DataRow In Dsfrm601_18TermsAndCondNew1.tbl6001_04ConditionsGroup.Rows
            Me.txtConditionsType.Properties.Items.Add(row("ConditionsType"))
        Next
        Me.txtConditionsType.Properties.Sorted = True

    End Sub
End Class