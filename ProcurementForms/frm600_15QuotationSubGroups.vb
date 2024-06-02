Public Class frm600_15QuotationSubGroups
    Public frm600_15QuotationSubGroupsIsClosed As Boolean

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Public ObjForm As Object

    Public QuotationNo As String
    Public MPRNo As String

    Public isExecutedFromQuotation As Boolean = False
    Public isExecutedFrom_frm601_11PurchaseRequestEdit As Boolean = False


    Private Sub frm600_15QuotationSubGroupsIsClosed_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm600_15QuotationSubGroupsIsClosed = True
    End Sub

    Private Sub CheckForErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtSubGroupName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtSubGroupName, "Sub Group Name cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtSubGroupName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtSubGroupCode.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtSubGroupCode, "Sub Group Code cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtSubGroupCode, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            CheckForErrors()

            If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
                MessageBox.Show("Cannot save while the entry have errors, Please clear the errors to continue.", "Errors in Entry", MessageBoxButtons.OK)
                Exit Sub
            End If

            Me.AddNewChild()

            Me.Validate()
            Me.Tbl60107QuotationChildItemGroupBindingSource.EndEdit()
            Me.Tbl601_07QuotationChildItemGroupTableAdapter.Update(Me.Dsfrm600_15QuotationSubGroups.tbl601_07QuotationChildItemGroup)

            If isExecutedFromQuotation = True Then
                Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByQuotationNo(Me.Dsfrm600_15QuotationSubGroups.tbl601_07QuotationChildItemGroup, QuotationNo)
            End If

            If isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
                Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByMPRNo(Me.Dsfrm600_15QuotationSubGroups.tbl601_07QuotationChildItemGroup, MPRNo)
            End If

            Me.txtSubGroupName.Text = ""
            Me.txtSubGroupCode.Text = ""
            Me.txtRemarks.Text = ""

            UpdateMasters()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateMasters()

        If isExecutedFromQuotation = True Then
            Try
                'Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByQuotationNo(Me.Dsfrm601_01QuotationEdit.tbl601_07QuotationChildItemGroup, QuotationNo)
                CType(ObjForm, frm601_01QuotationEdit).Tbl601_07QuotationChildItemGroupTableAdapter.FillByQuotationNo(CType(ObjForm, frm601_01QuotationEdit).Dsfrm601_01QuotationEdit.tbl601_07QuotationChildItemGroup, QuotationNo)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Emploee Assets Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
            Try
                'Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit10.tbl601_07QuotationChildItemGroup, RequestNo)
                CType(ObjForm, frm601_11PurchaseRequestEdit).Tbl601_07QuotationChildItemGroupTableAdapter.FillByMPRNo(CType(ObjForm, frm601_11PurchaseRequestEdit).Dsfrm601_11PurchaseRequestEdit10.tbl601_07QuotationChildItemGroup, MPRNo)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Emploee Assets Dropdown List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub AddNewChild()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm600_15QuotationSubGroups.Tables("tbl601_07QuotationChildItemGroup")
            dr = dt.NewRow()
            dr("QuotationNo") = Me.QuotationNo
            dr("GroupCode") = Me.txtSubGroupCode.EditValue
            dr("GroupName") = Me.txtSubGroupName.EditValue
            dr("GroupRemarks") = Me.txtRemarks.EditValue
            dr("IsShowLineItemsTotal") = Me.txtIsHidePrice.EditValue
            dr("MPRNo") = Me.txtMPRNo.EditValue

            dt.Rows.Add(dr)
            Me.Tbl601_07QuotationChildItemGroupTableAdapter.Update(Me.Dsfrm600_15QuotationSubGroups.tbl601_07QuotationChildItemGroup)

        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Quotation Item Sub Group, Please try again" & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            Me.Validate()
            Me.Tbl60107QuotationChildItemGroupBindingSource.EndEdit()
            Me.Tbl601_07QuotationChildItemGroupTableAdapter.Update(Me.Dsfrm600_15QuotationSubGroups.tbl601_07QuotationChildItemGroup)

            MessageBox.Show("Quotation Item Sub Group has been Successfully updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If isExecutedFromQuotation = True Then
                Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByQuotationNo(Me.Dsfrm600_15QuotationSubGroups.tbl601_07QuotationChildItemGroup, QuotationNo)
            End If

            If isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
                Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByMPRNo(Me.Dsfrm600_15QuotationSubGroups.tbl601_07QuotationChildItemGroup, MPRNo)
            End If

            If isExecutedFromQuotation = True Then
                UpdateMasters()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub frm101EmployeeAssets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If isExecutedFromQuotation = True Then
            Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByQuotationNo(Me.Dsfrm600_15QuotationSubGroups.tbl601_07QuotationChildItemGroup, QuotationNo)
        End If

        If isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
            Me.Tbl601_07QuotationChildItemGroupTableAdapter.FillByMPRNo(Me.Dsfrm600_15QuotationSubGroups.tbl601_07QuotationChildItemGroup, MPRNo)
        End If
        FillCombobox()

    End Sub

    Public Sub FillCombobox()
        ''Fill Cost Group
        'For Each row As DataRow In Ds101SupportDatasets1.qry20149AssetsRegisterView.Rows
        '    Me.txtAssetNo.Properties.Items.Add(row("AccountID"))
        'Next
        'Me.txtAssetNo.Properties.Sorted = True

    End Sub

End Class