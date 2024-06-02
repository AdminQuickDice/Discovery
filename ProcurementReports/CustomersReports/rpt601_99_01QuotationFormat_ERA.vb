Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_99_01QuotationFormat_ERA
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            'GetCompanySealImage()
            'Get Print Margins
            GetReportDetails("IMS-QTN-01")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin

            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            'Me.txtPageNumber.Visible = gReportIsShowPageNo
            'Me.txtUserPrinting.Visible = gReportIsShowPrintedBy

            'If gIsDotMatrix = True Then
            '    Me.lblQuotation.ForeColor = Color.Black
            '    Me.lineQuotation.ForeColor = Color.Black

            '    Me.lblSlNo.BackColor = Color.Transparent
            '    Me.lblDescription.BackColor = Color.Transparent
            '    Me.lblUnit.BackColor = Color.Transparent
            '    Me.lblQty.BackColor = Color.Transparent
            '    Me.txtUnitPriceText.BackColor = Color.Transparent
            '    Me.cellDiscountText.BackColor = Color.Transparent
            '    Me.txtVATText.BackColor = Color.Transparent
            '    Me.txtAmtBeforeTaxText.BackColor = Color.Transparent
            '    Me.lblVATAmount.BackColor = Color.Transparent

            '    Me.lblNetAmountText.BackColor = Color.Transparent
            '    Me.lblColon.BackColor = Color.Transparent
            '    Me.txtNetAmountSales.BackColor = Color.Transparent

            'End If


            'If gReportIsSingleSignatory = True Then
            '    Me.panelSingleSigantory.Visible = True
            '    Me.panelMultiSigantory.Visible = False

            'Else
            '    Me.panelSingleSigantory.Visible = False
            '    Me.panelMultiSigantory.Visible = True

            '    Me.txtSignatureImage.Visible = False
            '    Me.txtCompanySeal.Visible = False
            'End If

            'Me.txtCompanySeal.LocationF = New PointF(gSealLocationX, gSealLocationY)
            'Me.txtSignatureImage.LocationF = New PointF(gSignLocationX, gSignLocationY)

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtAmountInWords_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles txtAmountInWords.BeforePrint
        GetCompanyDetails(intCompanyID)

        If String.IsNullOrEmpty(ConvertIfNull(gCurrencyAbbr)) Then
            Dim AmountInwords As String = ConvertCurrencyToEnglish(ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
            Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
        Else
            Dim AmountInwords As String = ConvertCurrencyToEnglish(gCurrencyAbbr, gCurrencyPoints, ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
            Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
        End If

    End Sub
End Class