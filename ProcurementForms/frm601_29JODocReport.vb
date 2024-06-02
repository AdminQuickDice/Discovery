Public Class frm601_29JODocReport 

    Private Sub frm601_29JODocReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm601_29JODocReport1.tbl608_02JobOrderDocReportMaster' table. You can move, or remove it, as needed.
        Me.Tbl608_02JobOrderDocReportMasterTableAdapter.Fill(Me.Dsfrm601_29JODocReport1.tbl608_02JobOrderDocReportMaster)

    End Sub

    Public Sub FillDocumentConditions(ByVal JobOrderNo As String, ByVal ReportType As String)

        Me.Tbl608_03JobOrderReportsTableAdapter.FillByJONoAndType(Me.Dsfrm601_29JODocReport.tbl608_03JobOrderReports, JobOrderNo, ReportType)

    End Sub

    Private Sub btnDefaultSalesTerms_Click(sender As Object, e As EventArgs) Handles btnDefaultSalesTerms.Click
        DialogResult = MessageBox.Show("You are about to Insert new Report Template." & vbCrLf & "Are you Sure want to continue creating report?", "Confirm creating report template.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.txtConditionsCode.EditValue) = False Then
                If CheckIfNull(Me.txtJobOrderNo.EditValue) = False Then
                    If CheckIfNull(Me.txtJobOrderType.EditValue) = False Then

                        Me.InsertConditions(Me.txtConditionsCode.EditValue, Me.txtJobOrderNo.EditValue, Me.txtJobOrderType.EditValue)

                        ''Refresh the datagrid
                        ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)
                        Me.Tbl608_03JobOrderReportsTableAdapter.FillByJONoAndType(Me.Dsfrm601_29JODocReport.tbl608_03JobOrderReports, Me.txtJobOrderNo.EditValue, Me.txtJobOrderType.EditValue)

                    End If

                End If
            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub InsertConditions(ByVal ReportDocCode As String, ByVal JobOrderNo As String, ByVal ReportType As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_25InsertReportTemplate"
            Dim paramReportDocCode As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ReportDocCode", SqlDbType.VarChar)
            Dim paramJobOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@JobOrderNo", SqlDbType.VarChar)
            Dim paramReportType As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ReportType", SqlDbType.VarChar)

            paramReportDocCode.Value = ReportDocCode
            paramJobOrderNo.Value = JobOrderNo
            paramReportType.Value = ReportType

            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            MessageBox.Show("Terms & Conditions Creation failed, Please try again", "Terms & Conditions Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        SaveConditions()
    End Sub

    Public Sub SaveConditions()
        Try
            Me.Validate()
            Me.Tbl60803JobOrderReportsBindingSource.EndEdit()
            Me.Tbl608_03JobOrderReportsTableAdapter.Update(Me.Dsfrm601_29JODocReport.tbl608_03JobOrderReports)

            MessageBox.Show("Report Template has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl608_03JobOrderReportsTableAdapter.FillByJONoAndType(Me.Dsfrm601_29JODocReport.tbl608_03JobOrderReports, Me.txtJobOrderNo.EditValue, Me.txtJobOrderType.EditValue)

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

    Private Sub txtConditionsCode_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtConditionsCode.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm601_30JODocReportMaster As New frm601_30JODocReportMaster
            frm601_30JODocReportMaster.objForm = Me
            frm601_30JODocReportMaster.Show()
            frm601_30JODocReportMaster.isExecutedFrom_frm601_29JODocReport = True
            frm601_30JODocReportMaster.txtReportDocCode.EditValue = Me.txtConditionsCode.EditValue
            frm601_30JODocReportMaster.txtReportTemplateGroup.EditValue = Me.txtJobOrderType.EditValue
            frm601_30JODocReportMaster.FillConditions(Me.txtConditionsCode.EditValue)

        ElseIf e.Button.Index = 2 Then
            Dim frm601_30JODocReportMaster As New frm601_30JODocReportMaster
            frm601_30JODocReportMaster.objForm = Me
            frm601_30JODocReportMaster.Show()
            frm601_30JODocReportMaster.isExecutedFrom_frm601_29JODocReport = True
            'Get New Code
            frm601_30JODocReportMaster.txtReportTemplateGroup.EditValue = Me.txtJobOrderType.EditValue
            frm601_30JODocReportMaster.NewConditions(GetNewReportCodeNo(Me.txtJobOrderType.EditValue))

        End If
    End Sub

    Public Function GetNewReportCodeNo(ByVal ReportType As String) As String
        Dim strNewConditionsNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(right(ReportDocCode,4) as int)) from tbl608_02JobOrderDocReportMaster WHERE ReportDocCode like '" & ReportType & "%'"
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewConditionsNo = "0000" & CStr(int1)
            strNewConditionsNo = Microsoft.VisualBasic.Right(strNewConditionsNo, 4)

            strNewConditionsNo = ReportType & "-" & strNewConditionsNo
            Return strNewConditionsNo

        Catch ex As System.InvalidCastException
            strNewConditionsNo = ReportType & "-" & "0001"
            Return strNewConditionsNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function
End Class