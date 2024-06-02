Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI

Public Class frm601_39PORevisionHistory
    Public frm601_08PurchaseOrderViewIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Public intLogOnHRLevelCode As Integer

    Private SelectedPONo As String = ""
    Private SelectedPODate As Date = Date.Today()
    Private SelectedSupplierCode As String = ""
    Private SelectedCompany As Integer = 1


    Public Sub RetrieveVoucher(ByVal PONo As String)
        Try
            Me.Qry604_04PurchaseOrderViewMasterTableAdapter.FillByPONo(Me.Dsfrm601_39PORevisionHistory.qry604_04PurchaseOrderViewMaster, PONo)

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Purchase Order Revision History.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub repoEditPO_Click(sender As Object, e As EventArgs) Handles repoEditPO.Click
        Try
            Dim strPONo As String = Me.gvPORevisionHistory.GetRowCellValue(Me.gvPORevisionHistory.FocusedRowHandle, "PONo")
            'frm601_08PurchaseOrderView.(strEmployeeID)

            If CheckIfNull(strPONo) = False Then
                Dim frm601_07PurchaseOrderEdit As New frm601_07PurchaseOrderEdit
                frm601_07PurchaseOrderEdit.ObjForm = Me
                frm601_07PurchaseOrderEdit.btnSave.Caption = "Update"

                frm601_07PurchaseOrderEdit.strLogonUser = Me.strLogOnUser
                frm601_07PurchaseOrderEdit.intLogOnUserID = Me.intLogOnUserID
                frm601_07PurchaseOrderEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                frm601_07PurchaseOrderEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm601_07PurchaseOrderEdit.intLogOnDivision = Me.intLogOnDivision

                frm601_07PurchaseOrderEdit.Show()
                frm601_07PurchaseOrderEdit.isExecutedFrom_frm601_39PORevisionHistory = True
                frm601_07PurchaseOrderEdit.RetrievePOMaster(strPONo)
                frm601_07PurchaseOrderEdit.txtPONo.Enabled = False
                frm601_07PurchaseOrderEdit.DisableAllControls()
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class