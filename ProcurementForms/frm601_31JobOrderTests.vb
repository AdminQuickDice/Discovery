Public Class frm601_31JobOrderTests


    Public Sub FillDocumentConditions(ByVal JobOrderNo As String)

        Me.Qry608_03JobOrderTestsTableAdapter.FillByJobOrderNo(Me.Dsfrm601_31JobOrderTests.qry608_03JobOrderTests, JobOrderNo)

    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        SaveConditions()
    End Sub

    Public Sub SaveConditions()
        Try
            Me.Validate()
            Me.Qry60803JobOrderTestsBindingSource.EndEdit()
            Me.Qry608_03JobOrderTestsTableAdapter.Update(Me.Dsfrm601_31JobOrderTests.qry608_03JobOrderTests)

            MessageBox.Show("Job Order Report has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Qry608_03JobOrderTestsTableAdapter.FillByJobOrderNo(Me.Dsfrm601_31JobOrderTests.qry608_03JobOrderTests, Me.txtJobOrderNo.EditValue)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSaveAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
        SaveConditions()
        Me.close()
    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.close()
    End Sub
End Class