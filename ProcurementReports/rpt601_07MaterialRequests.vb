Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI

Public Class rpt601_07MaterialRequests
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Public boolShowVerifiedBy As Boolean
    Public boolShowApprovedBy As Boolean
    Public boolShowSignatures As Boolean

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            'GetCompanySealImage()

            'Get Print Margins
            GetReportDetails("IMS-MPR-01")

            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin
            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy

            Me.txtSystemTitle.Text = gDocumentNo

            'If gReportIsSingleSignatory = True Then
            '    Me.tblSignatures.Visible = True
            '    Me.panelMultiSigantory.Visible = False

            'Else
            '    Me.tblSignatures.Visible = False
            '    Me.panelMultiSigantory.Visible = True
            'End If


            'gReportSet
            If gReportSet = "204" Then 'Used for Alazzaz Trading

                'dsRpt601_07MaterialRequests - qry606_05PurchaseRequestReport.QtyRequested

                Me.txtRecordNo.Summary.Running = SummaryRunning.None
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.LineOrderNo")
                Me.txtRecordNo.DataBindings.Add(BindingReferenceNo)

            ElseIf gReportSet = "206" Then 'Used for Metro Company

                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.ExpectedDate", "{0}")
                Me.txtModeOfRequest.DataBindings.Add(BindingReferenceNo)
                Me.lblModeOfRequest.Text = "Required Date:"

                Me.lblRequestType.Text = "Material Type:"

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.ProjectMasterCode", "{0}")
                Me.txtRequestedBy.DataBindings.Add(BindingReferenceNo2)
                Me.lblRequstedBy.Text = "Cost Center:"

                Me.XrTableCell13.Text = "Requistioner:"


                Me.lblPurpose.Text = "Specification"
                Me.lblPriority.Text = ""
                Me.lblExpectedDate.Text = "UoM"
                Me.lblUoM.Text = "Requested Qty"
                Me.lblQty.Text = "Unit Price"

                Me.XrCrossBandLinePurpose.Visible = False

                Me.lblPurpose.WidthF = 191.44
                Me.txtPurpose.WidthF = 191.44

                Me.lblPriority.WidthF = 0
                Me.txtPriority.WidthF = 0

                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.AddlDescription", "{0}")
                Me.txtPurpose.DataBindings.Add(BindingReferenceNo3)

                Dim BindingReferenceNo4 As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.UnitDesc", "{0}")
                Me.txtExpectedDate.DataBindings.Add(BindingReferenceNo4)

                Dim BindingReferenceNo5 As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.QtyRequested", "{0}")
                Me.txtUoM.DataBindings.Add(BindingReferenceNo5)
                Me.txtUoM.TextFormatString = "{0:#,0.####}"

                Dim BindingReferenceNo6 As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.ExpectedUnitRate", "{0}")
                Me.txtQty.DataBindings.Add(BindingReferenceNo6)
                Me.txtQty.TextFormatString = "{0:#,0.00##}"

                Dim BindingReferenceNo7 As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.GSDescrpition", "{0}")
                Me.txtItemDescription.DataBindings.Add(BindingReferenceNo7)

                Me.txtMPRNo.TextFormatString = "Request No : {0}"


            ElseIf gReportSet = "207" Then 'Used for Gulf Road Construction

                Me.lblPurpose.Text = ""
                Me.lblPriority.Text = ""
                Me.lblExpectedDate.Text = ""

                Me.lblQty.WidthF = 64.24
                Me.txtQty.WidthF = 64.24

                Me.lblUoM.WidthF = 64.24
                Me.txtUoM.WidthF = 64.24

                Me.lblItemDescription.WidthF = 480
                Me.txtItemDescription.WidthF = 480

                Me.lblItemCode.WidthF = 81.57
                Me.XrTableCell9.WidthF = 81.57

                Me.lblSlNo.WidthF = 41.14
                Me.txtRecordNo.WidthF = 41.14

                Me.XrCrossBandLinePurpose.Visible = False
                Me.XrCrossBandLinePriority.Visible = False
                Me.XrCrossBandLineExpectedDate.Visible = False

            ElseIf gReportSet = "214" Then ' Used for PPCO

                Me.lblSalesPerson.Visible = False
                Me.txtSalesPerson.Visible = False

                Me.lblPurpose.Text = ""
                Me.lblPriority.Text = "Remarks"
                Me.lblExpectedDate.Text = ""

                Me.lblPriority.WidthF = 151.33
                Me.txtPriority.WidthF = 151.33
                Me.txtPriority.TextAlignment = TextAlignment.TopLeft

                Dim BindingReferenceNo3 As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.ItemRemarks", "{0}")
                Me.txtPriority.DataBindings.Add(BindingReferenceNo3)

                Me.lblQty.WidthF = 64.24
                Me.txtQty.WidthF = 64.24

                Me.lblUoM.WidthF = 64.24
                Me.txtUoM.WidthF = 64.24

                Me.lblItemDescription.WidthF = 480
                Me.txtItemDescription.WidthF = 480

                Me.lblItemCode.WidthF = 81.57
                Me.XrTableCell9.WidthF = 81.57

                Me.lblSlNo.WidthF = 41.14
                Me.txtRecordNo.WidthF = 41.14

                Me.XrCrossBandLinePurpose.Visible = False
                Me.XrCrossBandLinePriority.Visible = True
                Me.XrCrossBandLineExpectedDate.Visible = False

                Me.lblPreparedBy.Text = "Submitted By"
                Me.lblPreparedEmail.Visible = False
                Me.lblPreparedContactNo.Visible = False

                Me.lblVerifiedEmail.Visible = False
                Me.lblVerifiedContactNo.Visible = False

                Me.lblApprovedEmail.Visible = False
                Me.lblApprovedContactNo.Visible = False

                Me.panelPreparedBy.HeightF = 70
                Me.panelVerifiedBy.HeightF = 70
                Me.panelApprovedBy.HeightF = 70

                Me.txtVerifiedSignature.Visible = False
                Me.txtApprovedBySignature.Visible = False

                'Me.lblVerifiedBy.Text = "Verified By"
                'Me.lblVerifiedName.Text = ""
                'Me.lblVerifiedPosition.Visible = False

                'Me.lblApprovedBy.Text = "Approved By"
                'Me.lblApprovedName.Text = ""
                'Me.lblApprovedPosition.Visible = False

                Me.panelMultiSigantory.Visible = True
                Me.panelMultiSigantory.HeightF = 158.12

                Me.ReportFooter.HeightF = 100

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
        GetReportDetails("IMS-MPR-01")


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
    End Sub

    Private Sub SetCurrencyThreeDecimals()

        'Me.txtAmtBeforeTax.TextFormatString = "{0:#,0.000}"
        'Me.cellVATAmount.TextFormatString = "{0:#,0.000}"
        'Me.txtTotalBeforeDiscount.TextFormatString = "{0:#,0.000}"
        'Me.txtDiscountAmount.TextFormatString = "{0:#,0.000}"
        'Me.txtTotalAfterDiscount.TextFormatString = "{0:#,0.000}"
        'Me.txtVatAmount.TextFormatString = "{0:#,0.000}"
        'Me.txtAdditionAmount.TextFormatString = "{0:#,0.000}"
        'Me.txtDeductionAmount.TextFormatString = "{0:#,0.000}"
        'Me.txtNetAmountSales.TextFormatString = "{0:#,0.000}"

    End Sub
End Class