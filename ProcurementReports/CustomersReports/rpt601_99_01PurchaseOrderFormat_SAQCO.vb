Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_99_01PurchaseOrderFormat_SAQCO
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Public boolShowHSCode As Boolean

    Public boolShowVerifiedBy As Boolean
    Public boolShowApprovedBy As Boolean
    Public boolShowAcceptance As Boolean

    Public boolShowOnlyPosition As Boolean
    Public boolDontShowContactNo As Boolean
    Public boolDontShowEmailAddress As Boolean

    Public boolShowSignatures As Boolean

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            'GetCompanySealImage()

            'Get Print Margins
            GetReportDetails("IMS-PO-001")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin
            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtReportDocumentNo.Text = gDocumentNo

            GetCompanyDetails(intCompanyID)

            Me.lblUnitPrice02.Text = "Unit Price" & vbCrLf & "(" & gCurrencyType & ")"
            Me.lblTotalAmount02.Text = "Total Amount" & vbCrLf & "(" & gCurrencyType & ")"

            'Me.txtCompanySeal.LocationF = New PointF(gSealLocationX, gSealLocationY)
            'Me.txtSignatureImage.LocationF = New PointF(gSignLocationX, gSignLocationY)

            'If gIsDotMatrix = True Then
            '    Me.lblPO.ForeColor = Color.Black
            '    Me.XrLine2.ForeColor = Color.Black

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


            'gReportSet
            'If gReportSet = "102" Then
            '    '101 - used for Sudhir Gensets
            '    '102 - Used for Raqwani Piping Division
            '    'Change Sales Person to Project
            '    Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.MPRNo", "{0}")
            '    Me.txtReferenceNo.DataBindings.Add(BindingReferenceNo)
            '    Me.lblReferenceNo.Text = "RC Ref:"

            'Else
            '    'Change back Sales Person 
            '    Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.Project", "{0}")
            '    Me.txtReferenceNo.DataBindings.Add(BindingReferenceNo)
            '    Me.lblReferenceNo.Text = "Project:"

            'End If

            'If boolShowHSCode = True Then
            '    Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.HSCode", "{0}")
            '    Me.txtItemCode.DataBindings.Add(BindingReferenceNo)
            '    Me.lblItemCode.Text = "HS Code"
            'Else
            '    Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.GSCode", "{0}")
            '    Me.txtItemCode.DataBindings.Add(BindingReferenceNo)
            '    Me.lblItemCode.Text = "Item Code"
            'End If

            'ShowSignatoryFields()

            'GetCompanyDetails(intCompanyID)
            'Me.txtVATNo.Text = gCompanyVATNo

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub ShowSignatoryFields()

    '    If boolShowVerifiedBy = True Then
    '        Me.panelVerifiedBy.Visible = True
    '        Me.lblPreparedBy.Text = "Prepared By:"
    '        Me.lblPreparedBy.Borders = BorderSide.Bottom
    '        If boolShowSignatures = True Then
    '            Me.txtVerifiedSignature.Visible = True
    '        End If
    '    Else
    '        Me.panelVerifiedBy.Visible = False
    '        Me.txtVerifiedSignature.Visible = False
    '    End If

    '    If boolShowApprovedBy = True Then
    '        Me.panelApprovedBy.Visible = True
    '        Me.lblPreparedBy.Text = "Prepared By:"
    '        Me.lblPreparedBy.Borders = BorderSide.Bottom
    '        If boolShowSignatures = True Then
    '            Me.txtApprovedBySignature.Visible = True
    '        End If
    '    Else
    '        Me.panelApprovedBy.Visible = False
    '        Me.txtApprovedBySignature.Visible = False
    '    End If

    '    If boolShowOnlyPosition = True Then
    '        Me.lblPreparedBy.Visible = True
    '        Me.lblVerifiedBy.Visible = True
    '        Me.lblApprovedBy.Visible = True

    '        Me.lblPreparedBy.Borders = BorderSide.Bottom
    '        Me.lblVerifiedBy.Borders = BorderSide.Bottom
    '        Me.lblApprovedBy.Borders = BorderSide.Bottom

    '        Me.lblPreparedName.Visible = True
    '        Me.lblVerifiedName.Visible = True
    '        Me.lblApprovedName.Visible = True

    '        Dim BindingReferenceNo1 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.SignatoryPosition", "{0}")
    '        Me.lblPreparedName.DataBindings.Add(BindingReferenceNo1)

    '        Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.VerifiedPosition", "{0}")
    '        Me.lblVerifiedName.DataBindings.Add(BindingReferenceNo2)

    '        Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry604_05PurchaseOrderReport.ApprovedPosition", "{0}")
    '        Me.lblApprovedName.DataBindings.Add(BindingReferenceNo3)

    '        Me.lblPreparedPosition.Visible = False
    '        Me.lblVerifiedPosition.Visible = False
    '        Me.lblApprovedPosition.Visible = False

    '        Me.lblPreparedContactNo.Visible = False
    '        Me.lblVerifiedContactNo.Visible = False
    '        Me.lblApprovedContactNo.Visible = False

    '        Me.lblPreparedEmail.Visible = False
    '        Me.lblVerifiedEmail.Visible = False
    '        Me.lblApprovedEmail.Visible = False

    '    End If

    '    If boolShowAcceptance = True Then
    '        Me.panelAcceptance.Visible = True
    '        Me.panelAcceptance.LocationF = New PointF(504, 198)
    '        Me.ReportFooter.HeightF = 320
    '    Else
    '        Me.panelAcceptance.Visible = False
    '        Me.panelAcceptance.LocationF = New PointF(504, 85)
    '        Me.ReportFooter.HeightF = 208
    '    End If

    '    If boolShowVerifiedBy = False Then
    '        If boolShowApprovedBy = False Then
    '            If boolShowAcceptance = True Then
    '                Me.panelAcceptance.Visible = True
    '                Me.panelAcceptance.LocationF = New PointF(504, 85)
    '                Me.ReportFooter.HeightF = 208
    '            End If
    '        End If
    '    End If

    'End Sub

    'Private Sub GetCompanySealImage()
    '    If GetCompanySeal(intCompanyID) = True Then
    '        Dim mybytearray1 As Byte() = gCompanySeal
    '        Dim myimage As Image
    '        Dim ms1 As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray1)
    '        myimage = System.Drawing.Image.FromStream(ms1)
    '        Me.txtCompanySeal.Image = myimage
    '    End If
    'End Sub
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

    Private Sub txtAmountInWords2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtAmountInWords2.BeforePrint
        GetCompanyDetails(intCompanyID)

        If String.IsNullOrEmpty(ConvertIfNull(gCurrencyAbbr)) Then
            Dim AmountInwords As String = ConvertCurrencyToEnglish(ConvertIfNullDecimal(Me.txtTotalAmountWithTax.Text))
            Me.txtAmountInWords2.Text = "" & AmountInwords
        Else
            Dim AmountInwords As String = ConvertCurrencyToEnglish(gCurrencyAbbr, gCurrencyPoints, ConvertIfNullDecimal(Me.txtTotalAmountWithTax.Text))
            Me.txtAmountInWords2.Text = "" & AmountInwords
        End If
    End Sub
End Class