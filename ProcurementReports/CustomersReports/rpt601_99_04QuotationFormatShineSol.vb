Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Configuration

Public Class rpt601_99_04QuotationFormatShineSol

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Public IsPrintItemCodeWithDescription As Boolean = False
    Public IsPrintItemPartNoWithDescription As Boolean = False
    Public IsPrintItemPartNoWithArabicDesc As Boolean = False

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            GetCompanySealImage()
            'Get Print Margins
            GetReportDetails("IMS-QTN-01")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin

            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy

            If gIsDotMatrix = True Then
                Me.lblQuotation.ForeColor = Color.Black
                Me.lineQuotation.ForeColor = Color.Black

                Me.lblSlNo.BackColor = Color.Transparent
                Me.lblDescription.BackColor = Color.Transparent
                Me.lblUnit.BackColor = Color.Transparent
                Me.lblQty.BackColor = Color.Transparent
                Me.txtUnitPriceText.BackColor = Color.Transparent
                Me.txtAmtBeforeTaxText.BackColor = Color.Transparent
                Me.lblVATAmount.BackColor = Color.Transparent

                Me.lblNetAmountText.BackColor = Color.Transparent
                Me.lblColon.BackColor = Color.Transparent
                Me.txtNetAmountSales.BackColor = Color.Transparent

            End If

            'gReportSet
            If gReportSet = "102" Then
                '101 - used for Sudhir Gensets
                '102 - Used for Raqwani Piping Division
                'Change Sales Person to Project
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "RC Ref:"

                Dim BindingQuotationNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation.MPRNo", "{0}")
                Me.txtQuotationNo.DataBindings.Add(BindingQuotationNo)
                Me.lblQuotationNo.Text = "Reference No:"

            ElseIf gReportSet = "103" Then 'For Precision Valves
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "RFQ No:"

            ElseIf gReportSet = "202" Then '202 for Spar Arabia

                'Change back Sales Person 
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "Ref.No:"

                Me.lblQuotation.Visible = False
                Me.lineQuotation.Visible = False
                Me.shapeClientDetails.Visible = False
                Me.shapeClientDetails02.Visible = False

                Me.lblSlNo.BackColor = Color.LightGray
                Me.lblDescription.BackColor = Color.LightGray
                Me.lblUnit.BackColor = Color.LightGray
                Me.lblQty.BackColor = Color.LightGray
                Me.txtUnitPriceText.BackColor = Color.LightGray

                Me.txtAmtBeforeTaxText.BackColor = Color.LightGray
                Me.lblVATAmount.BackColor = Color.LightGray

                Me.lblNetAmountText.BackColor = Color.LightGray
                Me.lblColon.BackColor = Color.LightGray
                Me.txtNetAmountSales.BackColor = Color.LightGray

                Me.lblSubject.Borders = BorderSide.None
                Me.txtSubject.Borders = BorderSide.None

            ElseIf gReportSet = "203" Then 'For Tart Medical Est.
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "Customer RFQ:"

            Else
                'Change back Reference No 
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "Ref.No:"

            End If


            If gReportIsSingleSignatory = True Then
                Me.panelSingleSigantory.Visible = True
                Me.panelMultiSigantory.Visible = False

            Else
                Me.panelSingleSigantory.Visible = False
                Me.panelMultiSigantory.Visible = True

                Me.txtSignatureImage.Visible = False
                Me.txtCompanySeal.Visible = False
            End If

            Me.txtCompanySeal.LocationF = New PointF(gSealLocationX, gSealLocationY)
            Me.txtSignatureImage.LocationF = New PointF(gSignLocationX, gSignLocationY)

            GetCompanyDetails(intCompanyID)

            Me.txtUnitPriceText.Text = "Unit Price" & vbCrLf & "(" & gCurrencyType & ")"
            'Me.txtAmtBeforeTaxText.Text = "Total" & vbCrLf & "Amount (" & gCurrencyType & ")"
            Me.lblNetAmountText.Text = "Net Amount (" & gCurrencyType & "):"

            'If the option to Print Item Code along with Description
            If Me.IsPrintItemCodeWithDescription = True Then
                Me.txtItemDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWithCode")
            End If

            If Me.IsPrintItemPartNoWithDescription = True Then
                Me.txtItemDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWithPartNo")
            End If

            If Me.IsPrintItemPartNoWithArabicDesc = True Then
                Me.txtItemDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWtArabic")
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

    Private Sub txtAmountInWords_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles txtAmountInWords.BeforePrint
        'GetCompanyDetails(intCompanyID)

        'If String.IsNullOrEmpty(ConvertIfNull(gCurrencyAbbr)) Then
        '    Dim AmountInwords As String = ConvertCurrencyToEnglish(ConvertIfNullDecimal(Me.txtNetAmountSales.Text)
        '  Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
        'Else
        '    Dim AmountInwords As String = ConvertCurrencyToEnglish(gCurrencyAbbr, gCurrencyPoints, ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
        '    Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
        'End If

    End Sub

    Private Sub txtNetAmountSales_AfterPrint(sender As Object, e As EventArgs)

    End Sub


    'Private Sub GetLetterHeaderImage()
    '    If GetCompanyLetterHeader(1) = True Then
    '        Dim mybytearray2 As Byte() = gCompanyLetterHeader
    '        Dim myimage As Image
    '        Dim ms2 As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray2)
    '        myimage = System.Drawing.Image.FromStream(ms2)
    '        Me.txtLetterHeader.Image = myimage


    '        'Me.Watermark.Image = myimage
    '    End If
    'End Sub

    'Private Sub GetLetterFooterImage()
    '    If GetCompanyLetterFooter(1) = True Then
    '        Dim mybytearray3 As Byte() = gCompanyLetterFooter
    '        Dim myimage As Image
    '        Dim ms3 As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray3)
    '        myimage = System.Drawing.Image.FromStream(ms3)
    '        Me.txtLetterFooter.Image = myimage
    '    End If
    'End Sub

End Class
