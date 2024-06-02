Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_04MaterialReceiptFormat01
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            GetCompanySealImage()


            'Get Print Margins
            GetReportDetails("IMS-MRN-01")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin
            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtSystemTitle.Text = gDocumentNo

            If gIsDotMatrix = True Then
                Me.lblMRN.ForeColor = Color.Black
                Me.XrLine2.ForeColor = Color.Black

                Me.lblSlNo.BackColor = Color.Transparent
                Me.lblItemcode.BackColor = Color.Transparent
                Me.lblExpiryDate.BackColor = Color.Transparent
                Me.lblUoM.BackColor = Color.Transparent
                Me.lblQty.BackColor = Color.Transparent

            End If

            'gReportSet
            If gReportSet = "105" Then
                '101 - used for Sudhir Gensets
                '102 - Used for Raqwani Piping Division
                '105 - Used for Raqwani Medical Division
                Me.txtGSDescription.WidthF = 254.22

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry605_05MaterialReceiptReport.BatchNo", "{0}")
                Me.txtBatchNo.DataBindings.Add(BindingReferenceNo2)
                Me.lblBatchNo.Text = "Batch No"

                Me.txtBatchNo.WidthF = 120
                Me.lblBatchNo.WidthF = 120

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry605_05MaterialReceiptReport.ExpiryDate", "{0:dd-MMM-yyyy}")
                Me.txtExpiryDate.DataBindings.Add(BindingReferenceNo)

                Me.lblExpiryDate.Text = "Expiry Date"

                Me.txtExpiryDate.WidthF = 86.34
                Me.lblExpiryDate.WidthF = 86.34

                Me.BandBatchAndExpDate.Visible = True

            ElseIf gReportSet = "106" Then
                '101 - used for Sudhir Gensets
                '102 - Used for Raqwani Piping Division
                '105 - Used for Raqwani Medical Division
                Me.txtGSDescription.WidthF = 254.22

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry605_05MaterialReceiptReport.BatchNo", "{0}")
                Me.txtBatchNo.DataBindings.Add(BindingReferenceNo2)
                Me.lblBatchNo.Text = "Batch No"

                Me.txtBatchNo.WidthF = 120
                Me.lblBatchNo.WidthF = 120

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry605_05MaterialReceiptReport.ExpiryDate", "{0:dd-MMM-yyyy}")
                Me.txtExpiryDate.DataBindings.Add(BindingReferenceNo)

                Me.lblExpiryDate.Text = "Expiry Date"

                Me.txtExpiryDate.WidthF = 86.34
                Me.lblExpiryDate.WidthF = 86.34

                Me.BandBatchAndExpDate.Visible = True

                Me.lblItemcode.Text = "Item Part No"
                Me.txtGScode.DataBindings.Add("Text", Nothing, "ItemPartNo")

            Else
                'Change back to empty

                Me.txtExpiryDate.Text = ""
                Me.lblExpiryDate.Text = ""

                Me.txtBatchNo.Text = ""
                Me.lblBatchNo.Text = ""

                'Me.txtRecordNo.WidthF = 40
                'Me.txtGScode.WidthF = 82.71
                'Me.txtGSDescription.WidthF = 650
                'Me.txtBatchNo.WidthF = 2
                'Me.txtExpiryDate.WidthF = 2
                'Me.txtUnitDesc.WidthF = 86.34
                'Me.txtQty.WidthF = 86.34

                Me.BandBatchAndExpDate.Visible = False

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