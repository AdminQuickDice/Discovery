Public Class frm601_30JODocReportMaster 
    Public objForm As Object

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    '
    Public isExecutedFrom_frm601_29JODocReport As Boolean

    Private Sub frm601_18TermsAndCondNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm601_30JODocReportMaster.tbl608_02JobOrderDocReportMaster' table. You can move, or remove it, as needed.
        Me.Tbl608_02JobOrderDocReportMasterTableAdapter.Fill(Me.Dsfrm601_30JODocReportMaster.tbl608_02JobOrderDocReportMaster)
        FillCombobox()

    End Sub

    Public Sub NewConditions(ByVal ConditionCode As String)
        Try
            If CheckIfNull(ConditionCode) = False Then
                Me.Tbl60802JobOrderDocReportMasterBindingSource.AddNew()
                Me.txtReportDocCode.EditValue = ConditionCode
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Creating New Report Template Document", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub FillConditions(ByVal ConditionsCode As String)
        Me.Tbl608_02JobOrderDocReportMasterTableAdapter.FillByReportDocCode(Me.Dsfrm601_30JODocReportMaster.tbl608_02JobOrderDocReportMaster, ConditionsCode)

    End Sub

    Public Sub SaveConditions()
        Try
            Me.Validate()
            Me.Tbl60802JobOrderDocReportMasterBindingSource.EndEdit()
            Me.Tbl608_02JobOrderDocReportMasterTableAdapter.Update(Me.Dsfrm601_30JODocReportMaster.tbl608_02JobOrderDocReportMaster)

            MessageBox.Show("Report Document Template has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl608_02JobOrderDocReportMasterTableAdapter.FillByReportDocCode(Me.Dsfrm601_30JODocReportMaster.tbl608_02JobOrderDocReportMaster, Me.txtReportDocCode.EditValue)

            RefreshDocumentMasterDataGrid()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshDocumentMasterDataGrid()
        If isExecutedFrom_frm601_29JODocReport = True Then
            Try

                CType(objForm, frm601_29JODocReport).Tbl608_02JobOrderDocReportMasterTableAdapter.Fill(CType(objForm, frm601_29JODocReport).Dsfrm601_29JODocReport1.tbl608_02JobOrderDocReportMaster)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Report Document List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
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

        ''Fill Terms Category
        'Me.txtConditionsType.Properties.Items.Clear()

        'For Each row As DataRow In Dsfrm601_18TermsAndCondNew1.tbl6001_04ConditionsGroup.Rows
        '    Me.txtConditionsType.Properties.Items.Add(row("ConditionsType"))
        'Next
        'Me.txtConditionsType.Properties.Sorted = True

    End Sub
End Class