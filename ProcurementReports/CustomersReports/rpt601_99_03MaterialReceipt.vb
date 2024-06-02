Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_99_03MaterialReceipt
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    'Delivery Note for PRECISION

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            'GetCompanySealImage()
            'Get Print Margins
            GetReportDetails("IMS-MRN-02")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin

            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy

            If gReportSet = "203" Then 'For Tart Medical Est.

                'Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation.ClientRefNo", "{0}")
                'Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                'Me.lblReferenceNo.Text = "Customer RFQ:"

                Me.lblGood.Text = "Lot #"
                Me.lblMissing.Text = "Expiry Dt"
                Me.lblDamaged.Text = "Location"
                Me.lblRemarks.Text = "Remarks"

                Me.txtRequestedBy.Text = ""
                Me.txtReceivedBy.Text = ""
                Me.txtReviewedBy.Text = ""
                Me.txtVerifiedBy.Text = ""

            Else
                'Change back Reference No 
                'Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation.ClientRefNo", "{0}")
                'Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                'Me.lblReferenceNo.Text = "Ref.No:"


                Me.lblGood.Text = "Good"
                Me.lblMissing.Text = "Missing"
                Me.lblDamaged.Text = "Damaged"
                Me.lblRemarks.Text = "Remarks"

                Me.txtRequestedBy.Text = "Purchase Officer/Sales Co-ordinator"
                Me.txtReceivedBy.Text = "Store Keeper"
                Me.txtVerifiedBy.Text = "Production"
                Me.txtReviewedBy.Text = "QC / Manager"

            End If

            If gDefaultCurrencyDecimals = 3 Then
                Me.SetCurrencyThreeDecimals()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtAmountInWords_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles txtAmountInWords.BeforePrint
        GetCompanyDetails(intCompanyID)

        If String.IsNullOrEmpty(ConvertIfNull(gCurrencyAbbr)) Then
            Dim AmountInwords As String = ConvertCurrencyToEnglish(ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
            Me.txtAmountInWords.Text = "Total : " & AmountInwords
        Else
            Dim AmountInwords As String = ConvertCurrencyToEnglish(gCurrencyAbbr, gCurrencyPoints, ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
            Me.txtAmountInWords.Text = "Total : " & AmountInwords
        End If

    End Sub


    Private Sub SetCurrencyThreeDecimals()

        Me.txtUnitPrice.TextFormatString = "{0:#,0.000#}"
        Me.txtDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtVATAmount.TextFormatString = "{0:#,0.000}"
        Me.txtLineTotalAmount.TextFormatString = "{0:#,0.000}"
        Me.txtTotalDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtTotalVATAmount.TextFormatString = "{0:#,0.000}"
        Me.txtNetAmountSales.TextFormatString = "{0:#,0.000}"

    End Sub

End Class