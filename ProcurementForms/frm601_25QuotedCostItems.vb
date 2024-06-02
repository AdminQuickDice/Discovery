Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls

Public Class frm601_25QuotedCostItems
    Public isBeingUpdated As Boolean = False
    Public isBeingNew As Boolean = False
    Public isControlsModified As Boolean

    Public ObjForm As Object
    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Public SelectedQuotationChildSlNo As Integer
    Public SelectedQuotationNo As String

    Public isExecutedFrom_frm601_01QuotationEdit As Boolean = False

    Private Sub CheckMasterErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtCostItem.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtCostItem, "Cost Item Should be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtCostItem, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtCostQuantity.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtCostQuantity, "Cost Quantity must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtCostQuantity, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtCostAmount.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtCostAmount, "Cost Amount must be entered.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtCostAmount, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

    End Sub

    Public Sub LoadData(ByVal QuoteChildID As Integer)
        Try
            If CheckIfNull(QuoteChildID) = False Then
                ''fill master details
                Me.Qry601_14QuotationItemCostEditViewTableAdapter.FillByQuoteChildID(Me.Dsfrm601_25QuotedCostItems.qry601_14QuotationItemCostEditView, QuoteChildID)

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Quoted Items Cost Record.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub AddNewItemCostEntry()
        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = Me.Dsfrm601_25QuotedCostItems1.Tables("tbl601_04QuotationItemCosts")
            dr = dt.NewRow()
            'dr("QuoteCostSlNo") = 0
            dr("QuoteChildID") = Me.txtQuoteChildID.EditValue
            dr("QuoteNo") = Me.txtQuotationNo.EditValue
            dr("GSCode") = Me.txtGSCode.EditValue
            dr("CostItemCode") = Me.txtCostItem.EditValue
            dr("CostPercentage") = Me.txtCostPercentage.EditValue
            dr("CostItemPrice") = Me.txtCostAmount.EditValue
            dr("CostItemQty") = Me.txtCostQuantity.EditValue
            dr("AddedBy") = Me.strLogonUser
            dr("Addedon") = Date.Now

            dt.Rows.Add(dr)
            Me.Tbl601_04QuotationItemCostsTableAdapter.Update(Me.Dsfrm601_25QuotedCostItems1.tbl601_04QuotationItemCosts)


        Catch ex As Exception
            MessageBox.Show("Error occured while Adding Item Cost Entry, Please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ClearEntryFields()
        Try
            Me.txtCostItem.Text = ""
            Me.txtCostPercentage.Text = ""
            Me.txtCostAmount.EditValue = 0
            Me.txtCostQuantity.EditValue = 1

        Catch ex As NullReferenceException
            Me.txtCostItem.Focus()
        End Try
    End Sub

    Private Sub frm601_25QuotedCostItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tbl601_05QuotationCostMasterTableAdapter.Fill(Me.Dsfrm601_25QuotedCostItems2.tbl601_05QuotationCostMaster)
        Me.Tbl601_04QuotationItemCostsTableAdapter.Fill(Me.Dsfrm601_25QuotedCostItems1.tbl601_04QuotationItemCosts)

    End Sub

    Private Sub btnBack_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            'If Updating child details
            If Me.btnAdd.Text = "ADD" Then
                CheckMasterErrors()

                If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) Then
                    MessageBox.Show("Cannot continue saving with errors, please clear the errors and continue.", "Clear Errors", MessageBoxButtons.OK)
                    Exit Sub
                End If

                AddNewItemCostEntry()

                LoadData(Me.SelectedQuotationChildSlNo)

                ClearEntryFields()
                Me.txtCostItem.Focus()

            End If

        Catch ex As Exception
            MessageBox.Show("Error on Adding details.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            Me.Validate()
            Me.Qry60114QuotationItemCostEditViewBindingSource.EndEdit()
            Me.Qry601_14QuotationItemCostEditViewTableAdapter.Update(Me.Dsfrm601_25QuotedCostItems.qry601_14QuotationItemCostEditView)

            MessageBox.Show("Cost Details updated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
       
    End Sub
End Class