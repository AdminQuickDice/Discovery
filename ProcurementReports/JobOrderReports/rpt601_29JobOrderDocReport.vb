Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_29JobOrderDocReport
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Public JobOrderNo As String = ""
    Public JobOrderType As String = ""

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            'Get Print Margins
            GetReportDetails("IMS-JO-01")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin
            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin
            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy


            'gReportSet
            If JobOrderType = "RCR" Then

                Me.lblReportTitle.Text = "RECEIVED CONDTION REPORT"
                Me.lblReportTile2.Text = "RECEIVED CONDTION REPORT"

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InitialObsrvPreparedBy", "{0}")
                Me.lblPreparedName.DataBindings.Add(BindingReferenceNo)

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InitialObsrvApprovedBy", "{0}")
                Me.lblApprovedByName.DataBindings.Add(BindingReferenceNo2)

                Me.rowScope.Visible = False
                Me.ReportHeader.HeightF = 205

            ElseIf JobOrderType = "VIR" Then
                Me.lblReportTitle.Text = "VISUAL INSPECTION REPORT"
                Me.lblReportTile2.Text = "VISUAL INSPECTION REPORT"

                Me.lblReportHeading.Text = "OBSERVATION AFTER DISMANTLING"

                Me.lblNotes.Text = "Pre-Tested:"
                Dim BindingReferenceNo5 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionPreTested", "{0}")
                Me.txtReportNotes.DataBindings.Add(BindingReferenceNo5)

                Me.lblScope.Text = "Scope:"
                Dim BindingReferenceNo6 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionScope", "{0}")
                Me.txtScope.DataBindings.Add(BindingReferenceNo6)

                Me.rowScope.Visible = True
                Me.ReportHeader.HeightF = 225

                'Prepared By
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionPreparedBy", "{0}")
                Me.lblPreparedName.DataBindings.Add(BindingReferenceNo)

                'Prepared On
                Dim BindingReferenceNo4 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionPreparedOn", "{0}")
                Me.lblPreparedOn.DataBindings.Add(BindingReferenceNo4)

                'Approved By
                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionApprovedBy", "{0}")
                Me.lblApprovedByName.DataBindings.Add(BindingReferenceNo2)

                'Witnessed On
                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionApprovedOn", "{0}")
                Me.lblApprovedOn.DataBindings.Add(BindingReferenceNo3)

            ElseIf JobOrderType = "VRR" Then
                Me.lblReportTitle.Text = "VALVE REPAIR REPORT"
                Me.lblReportTile2.Text = "VALVE REPAIR REPORT"

                Me.lblReportHeading.Text = "REPAIR NOTES"

                Me.lblNotes.Text = "Pre-Tested:"
                Dim BindingReferenceNo5 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionPreTested", "{0}")
                Me.txtReportNotes.DataBindings.Add(BindingReferenceNo5)

                Me.lblScope.Text = "Scope:"
                Dim BindingReferenceNo6 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionScope", "{0}")
                Me.txtScope.DataBindings.Add(BindingReferenceNo6)

                Me.rowScope.Visible = True
                Me.ReportHeader.HeightF = 225

                'Prepared By
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.RepairPreparedBy", "{0}")
                Me.lblPreparedName.DataBindings.Add(BindingReferenceNo)

                'Prepared On
                Dim BindingReferenceNo4 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.RepairPreparedOn", "{0}")
                Me.lblPreparedOn.DataBindings.Add(BindingReferenceNo4)

                'Witnessed By
                Me.lblApprovedBy.Text = "Witnessed By:"
                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.RepairWitnessedBy", "{0}")
                Me.lblApprovedByName.DataBindings.Add(BindingReferenceNo2)

                'Witnessed On
                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.RepairWitnessedOn", "{0}")
                Me.lblApprovedOn.DataBindings.Add(BindingReferenceNo3)

            ElseIf JobOrderType = "DR" Then
                Me.lblReportTitle.Text = "DISPATCH REPORT"
                Me.lblReportTile2.Text = "DISPATCH REPORT"

                Me.lblReportHeading.Text = "DISPATCH NOTES"

                Me.lblNotes.Text = "Pre-Tested:"
                Dim BindingReferenceNo5 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionPreTested", "{0}")
                Me.txtReportNotes.DataBindings.Add(BindingReferenceNo5)

                Me.lblScope.Text = "Scope:"
                Dim BindingReferenceNo6 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.InspectionScope", "{0}")
                Me.txtScope.DataBindings.Add(BindingReferenceNo6)

                Me.rowScope.Visible = True
                Me.ReportHeader.HeightF = 225

                'Prepared By
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.DispatchPreparedBy", "{0}")
                Me.lblPreparedName.DataBindings.Add(BindingReferenceNo)

                'Prepared On
                Dim BindingReferenceNo4 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.DispatchPreparedOn", "{0}")
                Me.lblPreparedOn.DataBindings.Add(BindingReferenceNo4)

                'Witnessed By
                Me.lblApprovedBy.Text = "Witnessed By:"
                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.DispatchApprovedBy", "{0}")
                Me.lblApprovedByName.DataBindings.Add(BindingReferenceNo2)

                'Witnessed On
                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry608_02JobOrderReport.DispatchApprovedOn", "{0}")
                Me.lblApprovedOn.DataBindings.Add(BindingReferenceNo3)

            End If

            'GetCompanyDetails(intCompanyID)

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class