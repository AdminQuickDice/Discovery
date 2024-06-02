Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_02PurchaseOrderFormat01
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Public boolShowHSCode As Boolean
    Public boolShowItemPartNo As Boolean

    Public boolShowVerifiedBy As Boolean
    Public boolShowApprovedBy As Boolean
    Public boolShowAcceptance As Boolean
    Public boolShowSimpleAcceptance As Boolean

    Public boolShowOnlyPosition As Boolean
    Public boolDontShowContactNo As Boolean
    Public boolDontShowEmailAddress As Boolean

    Public boolShowSignatures As Boolean
    Public boolShowShippingDetails As Boolean

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            GetCompanySealImage()

            'Get Print Margins
            GetReportDetails("IMS-PO-001")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin
            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtSystemTitle.Text = gDocumentNo
            Me.txtCompanySeal.LocationF = New PointF(gSealLocationX, gSealLocationY)
            Me.txtSignatureImage.LocationF = New PointF(gSignLocationX, gSignLocationY)

            If gIsDotMatrix = True Then
                Me.lblPO.ForeColor = Color.Black
                Me.XrLine2.ForeColor = Color.Black

                Me.lblSlNo.BackColor = Color.Transparent
                Me.lblDescription.BackColor = Color.Transparent
                Me.lblUnit.BackColor = Color.Transparent
                Me.lblQty.BackColor = Color.Transparent
                Me.txtUnitPriceText.BackColor = Color.Transparent
                Me.cellDiscountText.BackColor = Color.Transparent
                Me.txtVATText.BackColor = Color.Transparent
                Me.txtAmtBeforeTaxText.BackColor = Color.Transparent
                Me.lblVATAmount.BackColor = Color.Transparent

                Me.lblNetAmountText.BackColor = Color.Transparent
                Me.lblColon.BackColor = Color.Transparent
                Me.txtNetAmountSales.BackColor = Color.Transparent

            End If

            If boolShowHSCode = True Then
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.HSCode", "{0}")
                Me.txtItemCode.DataBindings.Add(BindingReferenceNo)
                Me.lblItemCode.Text = "HS Code"
                '
            ElseIf boolShowItemPartNo = True Then

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.ItemPartNo", "{0}")
                Me.txtItemCode.DataBindings.Add(BindingReferenceNo)
                Me.lblItemCode.Text = "Part No."
            Else
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.GSCode", "{0}")
                Me.txtItemCode.DataBindings.Add(BindingReferenceNo)
                Me.lblItemCode.Text = "Stock No."
            End If

            If boolShowShippingDetails = True Then
                Me.tableTerms.Visible = True
                Me.tableBillToShipTo.Visible = True

                Me.tableBillToShipTo.SizeF = New Size(753.46, 70)
                Me.tableTerms.SizeF = New Size(753.46, 79)

                Me.tableBillToShipTo.LocationF = New Point(13.54, 2)
                Me.tableTerms.LocationF = New Point(13.54, 73)

                Me.GroupFooter3.Visible = True
            Else
                Me.tableTerms.Visible = False
                Me.tableBillToShipTo.Visible = False

                Me.tableTerms.SizeF = New Size(1, 1)
                Me.tableBillToShipTo.SizeF = New Size(1, 1)

                Me.tableTerms.LocationF = New Point(1, 1)
                Me.tableBillToShipTo.LocationF = New Point(1, 1)
                Me.GroupFooter3.Visible = False


            End If

            'gReportSet
            If gReportSet = "102" Then
                '101 - used for Sudhir Gensets
                '102 - Used for Raqwani Piping Division
                'Change Sales Person to Project
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.MPRNo", "{0}")
                Me.txtReferenceNo.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "RC Ref:"

            ElseIf gReportSet = "203" Then 'Used for Tart Medical Est.

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.MPRNo", "{0}")
                Me.txtReferenceNo.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "MPR No:"

                Me.lblItemCode.Text = "Stock No"
                Me.lblDescription.Text = "Catalog No & Stock Description"

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.DescriptionWithItemPartNo", "{0}")
                Me.txtStockDescription.DataBindings.Add(BindingReferenceNo2)

            ElseIf gReportSet = "204" Then 'Used for Alazzaz Trading

                Me.lblItemCode.Text = ""
                Me.txtItemCode.Text = ""

                Me.lblItemCode.WidthF = 0
                Me.txtItemCode.WidthF = 0

                Me.lblDescription.WidthF = 263
                Me.txtStockDescription.WidthF = 263

                Me.XrCrossBandBox6.Visible = False

                Me.txtRecordNo.Summary.Running = SummaryRunning.None
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.LineOrderNo")
                Me.txtRecordNo.DataBindings.Add(BindingReferenceNo)

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.DeliveryPeriod", "{0}")
                Me.txtDiscount.DataBindings.Add(BindingReferenceNo2)
                Me.txtDiscount.TextAlignment = TextAlignment.TopCenter
                Me.cellDiscountText.Text = "Delivery"

                Me.lblSlNo.Text = "Sr No"

            ElseIf gReportSet = "205" Then 'Used for CAD World Trading

                'MRItemNo
                Me.txtRecordNo.Summary.Running = SummaryRunning.None
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.MRItemNo")
                Me.txtRecordNo.DataBindings.Add(BindingReferenceNo)
                Me.lblSlNo.Text = "Sl No."

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.ItemPartNo", "{0}")
                Me.txtItemCode.DataBindings.Add(BindingReferenceNo2)
                Me.txtItemCode.TextAlignment = TextAlignment.TopCenter
                Me.lblItemCode.Text = "Part No"


            ElseIf gReportSet = "208" Then 'Used for Qamat Company

                'MRItemNo
                Me.txtRecordNo.Summary.Running = SummaryRunning.None
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.MRItemNo")
                Me.txtRecordNo.DataBindings.Add(BindingReferenceNo)
                Me.lblSlNo.Text = "Item #"

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.ItemPartNo", "{0}")
                Me.txtItemCode.DataBindings.Add(BindingReferenceNo2)
                Me.txtItemCode.TextAlignment = TextAlignment.TopCenter
                Me.lblItemCode.Text = "Part No"


                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.DeliveryPeriod", "{0}")
                Me.txtDiscount.DataBindings.Add(BindingReferenceNo3)
                Me.txtDiscount.TextAlignment = TextAlignment.TopCenter
                Me.cellDiscountText.Text = "Delivery Period"

                '
            Else
                'Change back Sales Person 
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.Project", "{0}")
                Me.txtReferenceNo.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "Project:"

            End If

            'gReportSet
            If gReportSet = "110" Then
                '110 - Used for SSQ
                'Change VAT Number to Supplier Reference No.
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.SupplierRefNo", "{0}")
                Me.txtVATNo.DataBindings.Add(BindingReferenceNo)
                Me.lblVATNumber.Text = "Ref No.:"

            Else
                'Change back VAT Number 
                GetCompanyDetails(intCompanyID)
                Me.txtVATNo.Text = gCompanyVATNo
                Me.lblVATNumber.Text = "VAT No.:"

            End If


            ShowSignatoryFields()

            If gDefaultCurrencyDecimals = 3 Then
                SetCurrencyThreeDecimals()
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowSignatoryFields()

        If boolShowVerifiedBy = True Then
            Me.panelVerifiedBy.Visible = True
            Me.lblPreparedBy.Text = "Prepared By:"
            Me.lblPreparedBy.Borders = BorderSide.Bottom
            If boolShowSignatures = True Then
                Me.txtVerifiedSignature.Visible = True
            End If
        Else
            Me.panelVerifiedBy.Visible = False
            Me.txtVerifiedSignature.Visible = False
        End If

        If boolShowApprovedBy = True Then
            Me.panelApprovedBy.Visible = True
            Me.lblPreparedBy.Text = "Prepared By:"
            Me.lblPreparedBy.Borders = BorderSide.Bottom
            If boolShowSignatures = True Then
                Me.txtApprovedBySignature.Visible = True
            End If
        Else
            Me.panelApprovedBy.Visible = False
            Me.txtApprovedBySignature.Visible = False
        End If

        If boolShowOnlyPosition = True Then
            Me.lblPreparedBy.Visible = True
            Me.lblVerifiedBy.Visible = True
            Me.lblApprovedBy.Visible = True

            Me.lblPreparedBy.Borders = BorderSide.Bottom
            Me.lblVerifiedBy.Borders = BorderSide.Bottom
            Me.lblApprovedBy.Borders = BorderSide.Bottom

            Me.lblPreparedName.Visible = True
            Me.lblVerifiedName.Visible = True
            Me.lblApprovedName.Visible = True

            Dim BindingReferenceNo1 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.SignatoryPosition", "{0}")
            Me.lblPreparedName.DataBindings.Add(BindingReferenceNo1)

            Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.VerifiedPosition", "{0}")
            Me.lblVerifiedName.DataBindings.Add(BindingReferenceNo2)

            Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.ApprovedPosition", "{0}")
            Me.lblApprovedName.DataBindings.Add(BindingReferenceNo3)

            Me.lblPreparedPosition.Visible = False
            Me.lblVerifiedPosition.Visible = False
            Me.lblApprovedPosition.Visible = False

            Me.lblPreparedContactNo.Visible = False
            Me.lblVerifiedContactNo.Visible = False
            Me.lblApprovedContactNo.Visible = False

            Me.lblPreparedEmail.Visible = False
            Me.lblVerifiedEmail.Visible = False
            Me.lblApprovedEmail.Visible = False

        End If

        If boolShowAcceptance = True Then
            Me.panelAcceptance.Visible = True
            Me.panelAcceptance.LocationF = New PointF(504, 198)
            Me.ReportFooter.HeightF = 320
        Else
            Me.panelAcceptance.Visible = False
            Me.panelAcceptance.LocationF = New PointF(504, 85)
            Me.ReportFooter.HeightF = 208
        End If

        If boolShowVerifiedBy = False Then
            If boolShowApprovedBy = False Then
                If boolShowAcceptance = True Then
                    Me.panelAcceptance.Visible = True
                    Me.panelAcceptance.LocationF = New PointF(504, 85)
                    Me.ReportFooter.HeightF = 208
                End If
            End If
        End If
        'boolShowSimpleAcceptance

        If boolShowSimpleAcceptance = True Then
            Me.panelAcceptance02.Visible = True
            Me.panelAcceptance02.LocationF = New PointF(2, 198)
            Me.ReportFooter.HeightF = 236
        Else
            Me.panelAcceptance02.Visible = False
            Me.panelAcceptance02.LocationF = New PointF(2, 0)
            Me.ReportFooter.HeightF = 208
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
    Private Sub txtAmountInWords_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles txtAmountInWords.BeforePrint
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

        Me.txtDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtLineAmtBeforeTax.TextFormatString = "{0:#,0.000}"
        Me.txtVATAmount.TextFormatString = "{0:#,0.000}"
        Me.txtTotalBeforeDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtDiscountAmount.TextFormatString = "{0:#,0.000}"
        Me.txtTotalAfterDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtTotalVatAmount.TextFormatString = "{0:#,0.000}"
        Me.txtAdditionAmount.TextFormatString = "{0:#,0.000}"
        Me.txtDeductionAmount.TextFormatString = "{0:#,0.000}"
        Me.txtNetAmountSales.TextFormatString = "{0:#,0.000}"
        Me.txtUnitPrice.TextFormatString = "{0:#,0.000#}"

    End Sub
End Class