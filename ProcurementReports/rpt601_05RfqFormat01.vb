Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_05RfqFormat01
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1
    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            GetCompanySealImage()

            'Get Print Margins
            GetReportDetails("IMS-RFQ-01")

            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin
            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtSystemTitle.Text = gDocumentNo

            'gReportSet
            If gReportSet = "105" Then
                '101 - used for Sudhir Gensets
                '102 - Used for Raqwani Piping Division
                '105 - Used for Raqwani Medical Division

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.PlanNo", "{0}")
                Me.txtPlanNo.DataBindings.Add(BindingReferenceNo2)
                Me.lblPlanNo.Text = "Ref. No. / Plan No"

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.ItemMake", "{0}")
                Me.txtManufacturer.DataBindings.Add(BindingReferenceNo)
                Me.lblManufacturer.Text = "Manufacturer"

                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.Expr1", "{0}")
                Me.txtDeliveryPeriod.DataBindings.Add(BindingReferenceNo3)
                Me.lblDeliveryPeriod.Text = "Delivery Period"

            ElseIf gReportSet = "110" Then
                '110 - Exelon Indl.

                'Change back to empty
                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.PlanNo", "{0}")
                Me.txtPlanNo.DataBindings.Add(BindingReferenceNo2)
                Me.lblPlanNo.Text = "Ref. No."

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.ItemMake", "{0}")
                Me.txtManufacturer.DataBindings.Add(BindingReferenceNo)
                Me.lblManufacturer.Text = "Duration"

                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.Expr1", "{0}")
                Me.txtDeliveryPeriod.DataBindings.Add(BindingReferenceNo3)
                Me.lblDeliveryPeriod.Text = "Location"

            ElseIf gReportSet = "206" Then ' 206 - Metro Company


                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.UnitDesc", "{0}")
                Me.txtPlanNo.DataBindings.Add(BindingReferenceNo2)
                Me.lblPlanNo.Text = "UoM"

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.QuotedQuantity", "{0}")
                Me.txtManufacturer.DataBindings.Add(BindingReferenceNo)
                Me.lblManufacturer.Text = "Qty"
                Me.txtManufacturer.TextFormatString = "{0:#,0.####}"

                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.UnitPrice", "{0}")
                Me.txtDeliveryPeriod.DataBindings.Add(BindingReferenceNo3)
                Me.lblDeliveryPeriod.Text = "Unit Price"
                Me.txtDeliveryPeriod.TextFormatString = "{0:#,0.00##}"

                Dim BindingReferenceNo4 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.ItemDiscount", "{0}")
                Me.txtUnit.DataBindings.Add(BindingReferenceNo4)
                Me.lblUnit.Text = "Discount"
                Me.txtUnit.TextFormatString = "{0:#,0.00##}"

                Dim BindingReferenceNo5 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.LineTotalAfterDisc", "{0}")
                Me.txtQty.DataBindings.Add(BindingReferenceNo5)
                Me.lblQty.Text = "Total"

                Me.txtQty.TextFormatString = "{0:#,0.00##}"

                Dim BindingReferenceNo6 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.ProjectMasterCode", "{0}")
                Me.txtRefNo.DataBindings.Add(BindingReferenceNo6)
                Me.lblReferenceNo.Text = "Project Ref.No."

                Dim BindingReferenceNo7 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.ProjectDescription", "{0}")
                Me.txtProject.DataBindings.Add(BindingReferenceNo7)
                Me.lblProject.Text = "Project Name:"


            ElseIf gReportSet = "208" Then  'for Qamat Company

                Dim BindingReferenceNo1 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.ItemPartNo", "{0}")
                Me.txtPlanNo.DataBindings.Add(BindingReferenceNo1)
                Me.lblPlanNo.Text = "Part No."


                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "", "{0}")
                Me.txtRFQNo.DataBindings.Add(BindingReferenceNo2)


                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "", "{0}")
                Me.txtRefNo.DataBindings.Add(BindingReferenceNo3)


            Else

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.PlanNo", "{0}")
                Me.txtPlanNo.DataBindings.Add(BindingReferenceNo2)
                Me.lblPlanNo.Text = "Plan No"

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.ItemMake", "{0}")
                Me.txtManufacturer.DataBindings.Add(BindingReferenceNo)
                Me.lblManufacturer.Text = "Manufacturer"

                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry607_05RFQReport.Expr1", "{0}")
                Me.txtDeliveryPeriod.DataBindings.Add(BindingReferenceNo3)
                Me.lblDeliveryPeriod.Text = "Delivery Period"
             
            End If

            Me.txtCompanySeal.LocationF = New PointF(gSealLocationX, gSealLocationY)
            Me.txtSignatureImage.LocationF = New PointF(gSignLocationX, gSignLocationY)

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetCompanySealImage()
        If GetCompanySeal(intCompanyID) = True Then
            Dim mybytearray1 As Byte() = gCompanySeal
            Dim myimage As Image
            Dim ms1 As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray1)
            myimage = System.Drawing.Image.FromStream(ms1)
            Me.txtCompanySeal.Image = myimage
        End If
    End Sub


End Class