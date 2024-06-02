Public Class frm600_06DocumentConditions 

    Private Sub btnDefaultSalesTerms_Click(sender As Object, e As EventArgs) Handles btnDefaultSalesTerms.Click
        DialogResult = MessageBox.Show("You are about to Insert new Quotation Terms and Conditions." & vbCrLf & "Are you Sure want to continue creating Terms & Conditions?", "Confirm creating Terms & Conditions.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.txtConditionsCode.EditValue) = False Then
                If CheckIfNull(Me.txtDocumentNo.EditValue) = False Then

                    'Get New Quotation Number
                    Me.InsertConditions(Me.txtConditionsCode.EditValue, Me.txtDocumentNo.EditValue)

                    ''Refresh the datagrid
                    ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)
                    Me.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(Me.Dsfrm600_06DocumentConditions.tbl601_03QuotationTerms, Me.txtDocumentNo.EditValue)

                End If
            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub frm600_06DocumentConditions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsfrm600_06DocumentConditions1.tbl600_04TermsConditionsMaster' table. You can move, or remove it, as needed.
        Me.Tbl600_04TermsConditionsMasterTableAdapter.Fill(Me.Dsfrm600_06DocumentConditions1.tbl600_04TermsConditionsMaster)

    End Sub

    Public Sub FillDocumentConditions(ByVal DocumentNo As String)

        Me.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(Me.Dsfrm600_06DocumentConditions.tbl601_03QuotationTerms, DocumentNo)

    End Sub

    Private Sub InsertConditions(ByVal ConditionsCode As String, ByVal QuotationNo As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_19InsertTermsAndCond"
            Dim paramConditionsCode As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ConditionsCode", SqlDbType.VarChar)
            Dim paramQuotationNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@QuotationNo", SqlDbType.VarChar)

            paramConditionsCode.Value = ConditionsCode
            paramQuotationNo.Value = QuotationNo

            SqlCommand1.ExecuteNonQuery()
            'MessageBox.Show("Terms & Conditions is created successfully,", "Terms & Conditions created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
            Me.Tbl60103QuotationTermsBindingSource.EndEdit()
            Me.Tbl601_03QuotationTermsTableAdapter.Update(Me.Dsfrm600_06DocumentConditions.tbl601_03QuotationTerms)

            MessageBox.Show("Terms & Conditions has been Successfully updated.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl601_03QuotationTermsTableAdapter.FillByQuoteNo(Me.Dsfrm600_06DocumentConditions.tbl601_03QuotationTerms, Me.txtDocumentNo.EditValue)

            'UpdateEmployeeCategory()

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
            Dim frm601_18TermsAndCondNew As New frm601_18TermsAndCondNew
            frm601_18TermsAndCondNew.objForm = Me
            frm601_18TermsAndCondNew.Show()
            frm601_18TermsAndCondNew.isExecutedFrom_frm600_06DocumentConditions = True
            frm601_18TermsAndCondNew.txtConditionsCode2.EditValue = Me.txtConditionsCode.EditValue
            frm601_18TermsAndCondNew.FillConditions(Me.txtConditionsCode.EditValue)

        ElseIf e.Button.Index = 2 Then
            Dim frm601_18TermsAndCondNew As New frm601_18TermsAndCondNew
            frm601_18TermsAndCondNew.objForm = Me
            frm601_18TermsAndCondNew.Show()
            frm601_18TermsAndCondNew.isExecutedFrom_frm600_06DocumentConditions = True
            'Get New Code
            frm601_18TermsAndCondNew.NewConditions(GetNewConditionsNo("TERMS"))

        End If
    End Sub

    Public Function GetNewConditionsNo(ByVal QuotationAbbr As String) As String
        Dim strNewConditionsNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(right(ConditionsCode,4) as int)) from tbl600_04TermsConditionsMaster WHERE ConditionsCode like '" & QuotationAbbr & "%'"
            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewConditionsNo = "0000" & CStr(int1)
            strNewConditionsNo = Microsoft.VisualBasic.Right(strNewConditionsNo, 4)

            strNewConditionsNo = QuotationAbbr & "-" & strNewConditionsNo
            Return strNewConditionsNo

        Catch ex As System.InvalidCastException
            strNewConditionsNo = QuotationAbbr & "-" & "0001"
            Return strNewConditionsNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function
End Class