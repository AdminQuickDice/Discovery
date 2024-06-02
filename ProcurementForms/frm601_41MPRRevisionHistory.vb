Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI

Public Class frm601_41MPRRevisionHistory
    Public frm601_08PurchaseOrderViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Public intLogOnHRLevelCode As Integer
    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Private SelectedPONo As String = ""
    Private SelectedPODate As Date = Date.Today()
    Private SelectedSupplierCode As String = ""
    Private SelectedCompany As Integer = 1


    Public Sub RetrieveVoucher(ByVal MPRNo As String)
        Try
            Me.Qry606_04PurchaseRequestViewMasterTableAdapter.Fill(Me.Dsfrm601_41MPRRevisionHistory.qry606_04PurchaseRequestViewMaster, MPRNo)

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Material Purchase Request Revision History.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub repoEditPO_Click(sender As Object, e As EventArgs) Handles repoEditPO.Click
        Try
            Dim strMPRNo As String = Me.gvPORevisionHistory.GetRowCellValue(Me.gvPORevisionHistory.FocusedRowHandle, "MPRNo")
            'frm601_08PurchaseOrderView.(strEmployeeID)

            'If CheckIfNull(strPONo) = False Then
            '    Dim frm601_07PurchaseOrderEdit As New frm601_07PurchaseOrderEdit
            '    frm601_07PurchaseOrderEdit.ObjForm = Me
            '    frm601_07PurchaseOrderEdit.btnSave.Caption = "Update"

            '    frm601_07PurchaseOrderEdit.strLogonUser = Me.strLogOnUser
            '    frm601_07PurchaseOrderEdit.intLogOnUserID = Me.intLogOnUserID
            '    frm601_07PurchaseOrderEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            '    frm601_07PurchaseOrderEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            '    frm601_07PurchaseOrderEdit.intLogOnDivision = Me.intLogOnDivision

            '    frm601_07PurchaseOrderEdit.Show()
            '    frm601_07PurchaseOrderEdit.isExecutedFrom_frm601_39PORevisionHistory = True
            '    frm601_07PurchaseOrderEdit.RetrievePOMaster(strPONo)
            '    frm601_07PurchaseOrderEdit.txtPONo.Enabled = False
            '    frm601_07PurchaseOrderEdit.DisableAllControls()
            'End If

            If CheckIfNull(strMPRNo) = False Then
                Dim frm601_11PurchaseRequestEdit As New frm601_11PurchaseRequestEdit
                frm601_11PurchaseRequestEdit.ObjForm = Me
                frm601_11PurchaseRequestEdit.txtRequestNo.Enabled = False
                frm601_11PurchaseRequestEdit.btnSave.Caption = "Update"

                frm601_11PurchaseRequestEdit.strLogonUser = Me.strLogOnUser
                frm601_11PurchaseRequestEdit.intLogOnUserID = Me.intLogOnUserID
                frm601_11PurchaseRequestEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                frm601_11PurchaseRequestEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm601_11PurchaseRequestEdit.intLogOnDivision = Me.intLogOnDivision
                frm601_11PurchaseRequestEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                frm601_11PurchaseRequestEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
                frm601_11PurchaseRequestEdit.isExecutedFrom_frm601_12PurchaseRequestView = True

                Dim SalesPersonCode As String = ""
                SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

                If Me.intLogOnAccessLevel = 99 Then
                    frm601_11PurchaseRequestEdit.txtSalesPerson.Enabled = True
                Else
                    frm601_11PurchaseRequestEdit.txtSalesPerson.Enabled = False
                End If

                frm601_11PurchaseRequestEdit.Show()

                frm601_11PurchaseRequestEdit.RetrieveRequestMaster(strMPRNo)

                frm601_11PurchaseRequestEdit.txtRequestNo.Enabled = False
                frm601_11PurchaseRequestEdit.DisableAllControls()


            End If

        Catch ex As Exception

        End Try
    End Sub
End Class