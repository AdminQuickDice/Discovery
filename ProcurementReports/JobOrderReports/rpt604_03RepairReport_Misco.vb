Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt604_03RepairReport_Misco
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1
    Private Sub rpt602_02InspectionReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            'Get Print Margins
            GetReportDetails("IMS-JO-03")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin
            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin
            Me.txtPageNumber.Visible = gReportIsShowPageNo

            Dim LogoSizeHeight As Decimal = gLogoSizeHeight
            Dim LogoSizeWidth As Decimal = gLogoSizeWidth

            Try
                GetCompanyDetails(1)
                Dim mybytearray As Byte() = gCompanyLogo
                Dim myimage As Image
                Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray)
                myimage = System.Drawing.Image.FromStream(ms)
                Me.XrPictureBox1.Image = myimage
                Me.XrPictureBox2.Image = myimage

                Me.XrPictureBox1.SizeF = New SizeF(LogoSizeWidth, LogoSizeHeight)
                Me.XrPictureBox2.SizeF = New SizeF(LogoSizeWidth, LogoSizeHeight)

            Catch ex As Exception

            End Try

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class