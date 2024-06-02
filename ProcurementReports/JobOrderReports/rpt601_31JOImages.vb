Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_31JOImages
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Public JobOrderNo As String = ""
    Public JobOrderType As String = ""

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            ''Get Print Margins
            'GetReportDetails("IMS-PO-001")
            'Me.TopMargin.HeightF = gReportTopMargin
            'Me.BottomMargin.HeightF = gReportBottomMargin
            'Me.Margins.Left = gReportLeftMargin
            'Me.Margins.Right = gReportRightMargin

            'ShowSignatoryFields()

            'GetCompanyDetails(intCompanyID)
            'Me.txtVATNo.Text = gCompanyVATNo
            'Get the Image Folder Location and Keep it in ScannedFolderLocation variable
            GetTheImageFolderLocation(JobOrderNo, JobOrderType)
            LoadAllImages()
            Me.Detail.HeightF = 200

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim ScannedFolderLocation As String = ""
    Private Sub GetTheImageFolderLocation(ByVal JobOrderNo As String, ByVal ReportType As String)
        GetCompanyDetails(1)
        ScannedFolderLocation = ""
        ScannedFolderLocation = gScannedLocation
        ScannedFolderLocation = gScannedLocation & "JobOrderImages\" & JobOrderNo & "-" & ReportType & "-"
    End Sub

    Public Sub LoadImages(ByVal ImageControl As DevExpress.XtraReports.UI.XRPictureBox, ByVal ImageNo As String)
        Dim ImageFileName As String = ""
        ImageFileName = ScannedFolderLocation & ImageNo & ".jpg"
        Try
            If System.IO.File.Exists(ImageFileName) = True Then
                Dim img1 As Image = Image.FromFile(ImageFileName)
                ImageControl.Image = img1
            Else
                ImageControl.Visible = False
                ImageControl.LocationF = New PointF(0, 0)
                ImageControl.WidthF = 1
                ImageControl.HeightF = 1
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Please try again or contact IT Department.", "Error on Reading", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub LoadAllImages()
        Me.LoadImages(Me.XrPictureBox1, "01")
        Me.LoadImages(Me.XrPictureBox2, "02")
        Me.LoadImages(Me.XrPictureBox3, "03")
        Me.LoadImages(Me.XrPictureBox4, "04")
        Me.LoadImages(Me.XrPictureBox5, "05")
        Me.LoadImages(Me.XrPictureBox6, "06")
        Me.LoadImages(Me.XrPictureBox7, "07")
        Me.LoadImages(Me.XrPictureBox8, "08")
        Me.LoadImages(Me.XrPictureBox9, "09")
        Me.LoadImages(Me.XrPictureBox10, "10")
        Me.LoadImages(Me.XrPictureBox11, "11")
        Me.LoadImages(Me.XrPictureBox12, "12")
        Me.LoadImages(Me.XrPictureBox13, "13")
        Me.LoadImages(Me.XrPictureBox14, "14")
        Me.LoadImages(Me.XrPictureBox15, "15")

        Me.LoadImages(Me.XrPictureBox16, "16")
        Me.LoadImages(Me.XrPictureBox17, "17")
        Me.LoadImages(Me.XrPictureBox18, "18")
        Me.LoadImages(Me.XrPictureBox19, "19")
        Me.LoadImages(Me.XrPictureBox20, "20")
        Me.LoadImages(Me.XrPictureBox21, "21")
        Me.LoadImages(Me.XrPictureBox22, "22")
        Me.LoadImages(Me.XrPictureBox23, "23")
        Me.LoadImages(Me.XrPictureBox24, "24")
        Me.LoadImages(Me.XrPictureBox25, "25")
        Me.LoadImages(Me.XrPictureBox26, "26")
        Me.LoadImages(Me.XrPictureBox27, "27")
        Me.LoadImages(Me.XrPictureBox28, "28")
        Me.LoadImages(Me.XrPictureBox29, "29")
        Me.LoadImages(Me.XrPictureBox30, "30")

        Me.LoadImages(Me.XrPictureBox31, "31")
        Me.LoadImages(Me.XrPictureBox32, "32")
        Me.LoadImages(Me.XrPictureBox33, "33")
        Me.LoadImages(Me.XrPictureBox34, "34")
        Me.LoadImages(Me.XrPictureBox35, "35")
        Me.LoadImages(Me.XrPictureBox36, "36")
        Me.LoadImages(Me.XrPictureBox37, "37")
        Me.LoadImages(Me.XrPictureBox38, "38")
        Me.LoadImages(Me.XrPictureBox39, "39")
        Me.LoadImages(Me.XrPictureBox40, "40")
        Me.LoadImages(Me.XrPictureBox41, "41")
        Me.LoadImages(Me.XrPictureBox42, "42")
        Me.LoadImages(Me.XrPictureBox43, "43")
        Me.LoadImages(Me.XrPictureBox44, "44")
        Me.LoadImages(Me.XrPictureBox45, "45")

    End Sub

  
End Class