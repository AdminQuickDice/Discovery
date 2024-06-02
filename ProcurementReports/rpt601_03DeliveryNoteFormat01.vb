Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_03DeliveryNoteFormat01
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Public IsPrintItemCodeWithDescription As Boolean = False
    Public IsPrintItemPartNoWithDescription As Boolean = False
    Public IsPrintItemPartNoWithArabicDesc As Boolean = False

    Public IsPrintFooterAtBottom As Boolean = False

    Public ShowLineItemNo As Boolean
    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            GetCompanySealImage()

            'Get Print Margins
            GetReportDetails("IMS-DN-01")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin
            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtReportRemarks.Text = gReportRemarks
            Me.txtSystemTitle.Text = gDocumentNo

            If gIsDotMatrix = True Then
                Me.lblDeliveryNote.ForeColor = Color.Black
                Me.XrLine2.ForeColor = Color.Black

                Me.lblSlNo.BackColor = Color.Transparent
                Me.lblItemCode.BackColor = Color.Transparent
                Me.lblItemDescription.BackColor = Color.Transparent
                Me.lblUoM.BackColor = Color.Transparent
                Me.lblQty.BackColor = Color.Transparent

            End If

            If IsPrintFooterAtBottom = True Then
                Me.GroupFooter1.PrintAtBottom = False
                Me.ReportFooter.PrintAtBottom = False

                Me.XrCrossBandBox1.EndPointF = New Point(11.54, 2)
            Else
                Me.GroupFooter1.PrintAtBottom = True
                Me.ReportFooter.PrintAtBottom = True
                Me.XrCrossBandBox1.EndPointF = New Point(11.54, 2)

            End If

            'gReportSet
            If gReportSet = "102" Then
                '101 - used for Sudhir Gensets
                '102 - Used for Raqwani Piping Division
                'Change Sales Person to Project
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.MPRNo", "{0}")
                Me.txtReferenceNo.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "RC Ref:"

                Me.txtExpiryDate.Text = ""
                Me.lblExpiryDate.Text = ""

                Me.txtBatchNo.Text = ""
                Me.lblBatchNo.Text = ""

                Me.BandBatchAndExpDate.Visible = False

            ElseIf gReportSet = "204" Then 'Used for Alazzaz Trading

                Me.lblItemCode.Text = ""
                Me.txtItemCode.Text = ""

                Me.lblItemCode.WidthF = 0
                Me.txtItemCode.WidthF = 0

                Me.lblItemDescription.WidthF = 545.87
                Me.txtGSDescription.WidthF = 545.87

                Me.XrCrossBandBox5.Visible = False

                Me.txtRecordNo.Summary.Running = SummaryRunning.None
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.LineOrderNo")
                Me.txtRecordNo.DataBindings.Add(BindingReferenceNo)

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.SalesOrderNo", "{0}")
                Me.txtReferenceNo.DataBindings.Add(BindingReferenceNo2)
                Me.lblReferenceNo.Text = "GO No.:"

                Me.BandBatchAndExpDate.Visible = False


            ElseIf gReportSet = "208" Then 'Used for Qamat Trading

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.ItemPartNo", "{0}")
                Me.txtItemCode.DataBindings.Add(BindingReferenceNo)
                Me.lblItemCode.Text = "Part Number"

                Me.BandBatchAndExpDate.Visible = False


            ElseIf gReportSet = "105" Then
                '101 - used for Sudhir Gensets
                '102 - Used for Raqwani Piping Division
                '105 - Used for Raqwani Medical Division
                Me.txtGSDescription.WidthF = 303.26
                Me.lblItemDescription.WidthF = 303.26

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.BatchNo", "{0}")
                Me.txtBatchNo.DataBindings.Add(BindingReferenceNo2)
                Me.lblBatchNo.Text = "Batch No"

                Me.txtBatchNo.WidthF = 84.88
                Me.lblBatchNo.WidthF = 84.88

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.ExpiryDate", "{0:dd-MMM-yyyy}")
                Me.txtExpiryDate.DataBindings.Add(BindingReferenceNo)

                Me.lblExpiryDate.Text = "Expiry Date"

                Me.txtExpiryDate.WidthF = 83.84
                Me.lblExpiryDate.WidthF = 83.84

                Me.BandBatchAndExpDate.Visible = True

            ElseIf gReportSet = "209" Then 'Khalifa Saad

                Me.txtGSDescription.Font = New Font(Me.txtGSDescription.Font.FontFamily, Me.txtGSDescription.Font.Size, FontStyle.Bold)


                'Change back to empty

                Me.txtExpiryDate.Text = ""
                Me.lblExpiryDate.Text = ""

                Me.txtBatchNo.Text = ""
                Me.lblBatchNo.Text = ""

                Me.BandBatchAndExpDate.Visible = False

            ElseIf gReportSet = "210" Then
                '101 - used for Sudhir Gensets
                '102 - Used for Raqwani Piping Division
                '105 - Used for Raqwani Medical Division
                Me.txtGSDescription.WidthF = 303.26
                Me.lblItemDescription.WidthF = 303.26

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.EmployeeNo", "{0}")
                Me.txtBatchNo.DataBindings.Add(BindingReferenceNo2)
                Me.lblBatchNo.Text = "Employee No"

                Me.txtBatchNo.WidthF = 84.88
                Me.lblBatchNo.WidthF = 84.88

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.PropertyNo", "{0}")
                Me.txtExpiryDate.DataBindings.Add(BindingReferenceNo)

                Me.lblExpiryDate.Text = "Equipment No"

                Me.txtExpiryDate.WidthF = 83.84
                Me.lblExpiryDate.WidthF = 83.84

                Me.BandBatchAndExpDate.Visible = True

            Else
                'Change back to empty

                Me.txtExpiryDate.Text = ""
                Me.lblExpiryDate.Text = ""

                Me.txtBatchNo.Text = ""
                Me.lblBatchNo.Text = ""

                Me.BandBatchAndExpDate.Visible = False

                'End If

                'Else
                ''Change back Sales Person 
                'Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.VendorNo", "{0}")
                'Me.txtReferenceNo.DataBindings.Add(BindingReferenceNo)
                'Me.lblReferenceNo.Text = "Vendor ID:"

            End If

            Me.txtCompanySeal.LocationF = New PointF(gSealLocationX, gSealLocationY)
            Me.txtSignatureImage.LocationF = New PointF(gSignLocationX, gSignLocationY)

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        If ShowLineItemNo = True Then
            Me.txtRecordNo.Summary.Running = SummaryRunning.None
            Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.LineOrderNo")
            Me.txtRecordNo.DataBindings.Add(BindingReferenceNo)

        End If

        'If the option to Print Item Code along with Description
        If Me.IsPrintItemCodeWithDescription = True Then
            Me.txtGSDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWithCode")
        End If

        If Me.IsPrintItemPartNoWithDescription = True Then
            Me.txtGSDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWithPartNo")
        End If

        If Me.IsPrintItemPartNoWithArabicDesc = True Then
            Me.txtGSDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWtArabic")
        End If
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