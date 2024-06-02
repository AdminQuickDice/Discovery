Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI

Public Class rpt601_99_06QuotationFormatBgate
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1
    Public IsPrintItemCodeWithDescription As Boolean = False
    Public IsPrintItemPartNoWithDescription As Boolean = False
    Public IsPrintItemPartNoWithArabicDesc As Boolean = False


    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            GetCompanySealImage()
            'Get Print Margins
            GetReportDetails("IMS-QTN-21")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin

            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtSystemTitle.Text = gDocumentNo

            'Me.txtCompanySeal.LocationF = New PointF(gSealLocationX, gSealLocationY)
            Me.txtSignatureImage.LocationF = New PointF(gSignLocationX, gSignLocationY)
            Me.txtApprovedBySignature.LocationF = New PointF(gThirdSignLocationX, gThirdSignLocationY)

            GetCompanyDetails(intCompanyID)

            If gReportSet = "231" Then ' BGATE Design with Bank Details
                Me.tableBankDetails.Visible = True
            Else
                Me.tableBankDetails.Visible = False

            End If

            ''If the option to Print Item Code along with Description
            'If Me.IsPrintItemCodeWithDescription = True Then
            '    Me.txtItemDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWithCode")
            'End If

            'If Me.IsPrintItemPartNoWithDescription = True Then
            '    Me.txtItemDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWithPartNo")
            'End If

            'If Me.IsPrintItemPartNoWithArabicDesc = True Then
            '    Me.txtItemDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWtArabic")
            'End If

            If gDefaultCurrencyDecimals = 3 Then
                SetCurrencyThreeDecimals()
            End If


        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetCompanySealImage()
        'If GetCompanySeal(intCompanyID) = True Then
        '    Dim mybytearray1 As Byte() = gCompanySeal
        '    Dim myimage As Image
        '    Dim ms1 As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray1)
        '    myimage = System.Drawing.Image.FromStream(ms1)
        '    Me.txtCompanySeal.Image = myimage
        'End If
    End Sub

    Private Sub txtAmountInWords_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles txtAmountInWords.BeforePrint
        'Dim AmountInwords As String = ConvertCurrencyToEnglish(ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
        'Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords

        GetCompanyDetails(intCompanyID)

        If String.IsNullOrEmpty(ConvertIfNull(gCurrencyAbbr)) Then
            Dim AmountInwords As String = ConvertCurrencyToEnglish(ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
            Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
        Else
            Dim AmountInwords As String = ConvertCurrencyToEnglish(gCurrencyAbbr, gCurrencyPoints, ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
            Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
        End If

        If gCurrencyType = "BHD" Then
            Dim AmountInwords As String = ConvertBharainiDinarToEnglish(ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
            Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
        End If

    End Sub

    Private Sub SetCurrencyThreeDecimals()

        Me.txtAmtBeforeTax.TextFormatString = "{0:#,0.000}"
        Me.txtSubTotalBeforeTax.TextFormatString = "{0:#,0.000}"
        Me.txtTotalBeforeDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtDiscountAmount.TextFormatString = "{0:#,0.000}"
        Me.txtTotalAfterDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtVatAmount.TextFormatString = "{0:#,0.000}"
        Me.txtNetAmountSales.TextFormatString = "{0:#,0.000}"
        Me.txtUnitPrice.TextFormatString = "{0:#,0.000#}"

    End Sub

End Class