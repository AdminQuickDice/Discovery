Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Configuration

Public Class rpt601_09SalesOrder
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
            GetReportDetails("IMS-SO-01")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin

            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtSystemTitle.Text = gDocumentNo

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

            If gReportSet = "208" Then 'Used for Qamat Company

                'Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry602_13SalesOrderReport.ItemPartNo", "{0}")

                Me.txtVATAmount.ExpressionBindings.Add(New ExpressionBinding("Text", "calcItemPartNo")) '.Add("Text", Nothing, "calcItemPartNo")
                Me.txtVATAmount.TextAlignment = TextAlignment.TopCenter
                Me.lblVATAmount.Text = "Part No"

                Me.cellDiscount.ExpressionBindings.Add(New ExpressionBinding("Text", "calcDeliveryPeriod")) '.Add("Text", Nothing, "calcItemPartNo")
                Me.cellDiscount.TextAlignment = TextAlignment.TopCenter
                Me.cellDiscountText.Text = "Delivery Period"


                Me.txtAmtBeforeTaxText.Text = "Total Price"
            End If

            If gDefaultCurrencyDecimals = 3 Then
                SetCurrencyThreeDecimals()
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

    'Private Sub txtAmountInWords_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles txtAmountInWords.BeforePrint
    '    'Dim AmountInwords As String = ConvertCurrencyToEnglish(ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
    '    'Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
    '    GetCompanyDetails(intCompanyID)

    '    If String.IsNullOrEmpty(ConvertIfNull(gCurrencyAbbr)) Then
    '        Dim AmountInwords As String = ConvertCurrencyToEnglish(ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
    '        Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
    '    Else
    '        Dim AmountInwords As String = ConvertCurrencyToEnglish(gCurrencyAbbr, gCurrencyPoints, ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
    '        Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
    '    End If
    'End Sub


    Private Sub SetCurrencyThreeDecimals()

        Me.txtAmtBeforeTax.TextFormatString = "{0:#,0.000}"
        Me.cellDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtVATAmount.TextFormatString = "{0:#,0.000}"
        Me.txtTotalBeforeDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtDiscountAmount.TextFormatString = "{0:#,0.000}"
        Me.txtTotalVatAmount.TextFormatString = "{0:#,0.000}"
        Me.txtAdditionAmount.TextFormatString = "{0:#,0.000}"
        Me.txtDeductionAmount.TextFormatString = "{0:#,0.000}"
        Me.txtNetAmountSales.TextFormatString = "{0:#,0.000}"

        Me.txtUnitPrice.TextFormatString = "{0:#,0.000#}"

    End Sub

End Class