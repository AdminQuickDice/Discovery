Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_01QuotationFormat05
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1
    Public IsPrintItemCodeWithDescription As Boolean = False
    Public IsPrintItemPartNoWithDescription As Boolean = False
    Public IsPrintItemPartNoWithArabicDesc As Boolean = False

    Public boolShowPreparedBy As Boolean
    Public boolShowVerifiedBy As Boolean
    Public boolShowApprovedBy As Boolean
    Public boolShowSignatures As Boolean


    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            GetCompanySealImage()
            'Get Print Margins
            GetReportDetails("IMS-QTN-06")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin

            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtSystemTitle.Text = gDocumentNo

            If gIsDotMatrix = True Then
                Me.lblQuotation.ForeColor = Color.Black
                Me.lineQuotation.ForeColor = Color.Black

                Me.lblSlNo.BackColor = Color.Transparent
                Me.lblDescription.BackColor = Color.Transparent
                Me.lblUnit.BackColor = Color.Transparent
                Me.lblQty.BackColor = Color.Transparent

            End If

            'gReportSet
            If gReportSet = "102" Then
                '101 - used for Sudhir Gensets
                '102 - Used for Raqwani Piping Division
                'Change Sales Person to Project
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "RC Ref:"

                Dim BindingQuotationNo As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.MPRNo", "{0}")
                Me.txtQuotationNo.DataBindings.Add(BindingQuotationNo)
                Me.lblQuotationNo.Text = "Reference No:"

                Me.lblQuotationNo.Visible = False
                Me.txtQuotationNo.Visible = False

            ElseIf gReportSet = "103" Then 'For Precision Valves
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "RFQ No:"

            ElseIf gReportSet = "202" Then '202 for Spar Arabia
                'Change back Sales Person 
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.ClientRefNo", "{0}")
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

                Me.lblSubject.Borders = BorderSide.None
                Me.txtSubject.Borders = BorderSide.None

            ElseIf gReportSet = "203" Then 'For Tart Medical Est.
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "Customer RFQ:"

            ElseIf gReportSet = "204" Then 'Used for Alazzaz Trading

                Me.txtRecordNo.Summary.Running = SummaryRunning.None
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.LineOrderNo")
                Me.txtRecordNo.DataBindings.Add(BindingReferenceNo)

            ElseIf gReportSet = "210" Then 'For Makhavi
                'Change back Sales Person 
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.SalesPersonName", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "SalesPerson:"

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.Project", "{0}")
                Me.txtVendorID.DataBindings.Add(BindingReferenceNo2)
                Me.lblVendorID.Text = "Project :"


            ElseIf gReportSet = "211" Then 'For Rentz

                Dim BindingReferenceNo2 As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.Project", "{0}")
                Me.txtVendorID.DataBindings.Add(BindingReferenceNo2)
                Me.lblVendorID.Text = "Project :"


                Me.txtClientEmail.DataBindings.Add("Text", Nothing, "calcEmailWithPhone")

            Else
                'Change back Sales Person 
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "Ref.No:"

            End If

            'If gReportIsSingleSignatory = True Then
            '    Me.panelSingleSigantory.Visible = True
            '    Me.panelMultiSigantory.Visible = False

            'Else
            '    Me.panelSingleSigantory.Visible = False
            '    Me.panelMultiSigantory.Visible = True

            '    Me.txtSignatureImage.Visible = False
            '    Me.txtCompanySeal.Visible = False
            'End If

            Me.txtCompanySeal.LocationF = New PointF(gSealLocationX, gSealLocationY)
            Me.txtSignatureImage.LocationF = New PointF(gSignLocationX, gSignLocationY)
            Me.txtVerifiedSignature.LocationF = New PointF(gSecondSignLocationX, gSecondSignLocationY)
            Me.txtApprovedBySignature.LocationF = New PointF(gThirdSignLocationX, gThirdSignLocationY)
            GetCompanyDetails(intCompanyID)

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

            ShowSignatoryFields()

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowSignatoryFields()


        If boolShowPreparedBy = True Then
            Me.panelPreparedBy.Visible = True
            Me.lblPreparedBy.Text = gPreparedByText
            Me.lblPreparedBy.Borders = BorderSide.Bottom
            If boolShowSignatures = True Then
                Me.txtSignatureImage.Visible = True
            End If
        Else
            Me.panelPreparedBy.Visible = False
            Me.txtSignatureImage.Visible = False

        End If

        If boolShowVerifiedBy = True Then
            Me.panelVerifiedBy.Visible = True
            Me.lblPreparedBy.Text = gPreparedByText
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
            Me.lblPreparedBy.Text = gPreparedByText
            Me.lblPreparedBy.Borders = BorderSide.Bottom
            If boolShowSignatures = True Then
                Me.txtApprovedBySignature.Visible = True
            End If
        Else
            Me.panelApprovedBy.Visible = False
            Me.txtApprovedBySignature.Visible = False
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

    'Private Sub txtAmountInWords_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles txtAmountInWords.BeforePrint
    '    Dim AmountInwords As String = ConvertCurrencyToEnglish(ConvertIfNullDecimal(Me.txtNetAmountSales.Text))
    '    Me.txtAmountInWords.Text = "Amount in words : " & AmountInwords
    'End Sub
End Class