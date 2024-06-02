Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_06MaterialIssues
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1
    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            GetCompanySealImage()

            'Get Print Margins
            GetReportDetails("IMS-ISU-01")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin
            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtSystemTitle.Text = gDocumentNo

            Me.txtCompanySeal.LocationF = New PointF(gSealLocationX, gSealLocationY)
            Me.txtSignatureImage.LocationF = New PointF(gSignLocationX, gSignLocationY)

            ' ''gReportSet
            ''If gReportSet = "201" Then
            ''    '201 - used for Raqwani Medical Division
            ''    'Change Sales Person to Project
            ''    Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.MPRNo", "{0}")
            ''    Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
            ''    Me.lblReferenceNo.Text = "RC Ref:"

            ''Else
            ''    'Change back Sales Person 
            ''    Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry603_05DeliveryNoteReport.ClientRefNo", "{0}")
            ''    Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
            ''    Me.lblReferenceNo.Text = "Ref.No:"

            ''End If


            If gReportSet = "105" Then
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

            Else
                'Change back to empty

                Me.txtExpiryDate.Text = ""
                Me.lblExpiryDate.Text = ""

                Me.txtBatchNo.Text = ""
                Me.lblBatchNo.Text = ""

                Me.BandBatchAndExpDate.Visible = False

            End If

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