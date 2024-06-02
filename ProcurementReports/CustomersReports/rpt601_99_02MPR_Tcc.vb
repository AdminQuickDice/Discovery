Imports DevExpress.XtraReports.UI

Public Class rpt601_99_02MPR_Tcc
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1

    Public isDefaultDesign As Boolean = False


    Private Sub rpt601_99_02MPR_Tcc_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        Try

            GetCompanyDetails(1)

            Dim mybytearray As Byte() = gCompanyLogo

            Dim myimage As Image
            Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray)
            myimage = System.Drawing.Image.FromStream(ms)

            Me.txtCompanyLogo.Image = myimage

            If Me.isDefaultDesign = True Then
                Me.lblProject.Text = "Project / Cost Center "
                Me.txtApprovedByMD.Text = ""
                Me.txtReviewedBy.Text = ""
            End If


            'Get Print Margins
            GetReportDetails("IMS-MPR-02")

            If gReportSet = "206" Then ' 206 - Metro Company
                Me.panelAllSignatory.Visible = True
                Me.tblSignatories.Visible = False

                Me.lblRequestedBy.Text = "Requester Name:"
                Me.txtRequestedBy.Text = "Project:"

                Me.lblApprovedByHead.Text = "Verified By QS:"
                Me.txtApprovedByHead.Text = ""

                Me.lblReviewedBy.Text = "Reviewed By PCM:"
                Me.txtReviewedBy.Text = ""

                Me.lblApprovedByMD.Text = "Approved By GM:"
                Me.txtApprovedByMD.Text = ""

            ElseIf gReportSet = "210" Then ' Power Tech Inds.
                Me.txtMPRHeading.Text = "PURCHASE REQUISITION"


                Dim BindingRemarks As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.ItemRemarks", "{0}")
                Me.txtUnitPrice.DataBindings.Add(BindingRemarks)
                Me.lblUnitPrice.Text = "Remarks"

                Dim BindingTotalPrice As New XRBinding("Text", Me.DataSource, "qry606_05PurchaseRequestReport.MPRRemark", "{0}")
                Me.txtTotalPrice.DataBindings.Add(BindingTotalPrice)
                Me.lblTotalPrice.Text = ""

                Me.txtTotalPrice.Visible = False
                Me.lblTotalPrice.Visible = False

                Me.lblUnitPrice.WidthF = 201
                Me.txtUnitPrice.WidthF = 201

                Me.TableTotals.Visible = False
                Me.GroupFooter1.HeightF = 2.0F

                Me.panelAllSignatory.Visible = False
                Me.panelAllSignatory.SizeF = New Size(774.08, 50)
                Me.tblSignatories.Visible = True
                Me.ReportFooter.HeightF = 100.0F

            Else

                Me.panelAllSignatory.Visible = True
                Me.tblSignatories.Visible = False

            End If


            Dim LogoSizeHeight As Decimal = gLogoSizeHeight
            Dim LogoSizeWidth As Decimal = gLogoSizeWidth

            Me.txtCompanyLogo.SizeF = New SizeF(LogoSizeWidth, LogoSizeHeight)


            If gDefaultCurrencyDecimals = 3 Then
                SetCurrencyDecimals()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub ShowVATFields(ByVal ShowVAT As Boolean)

        If ShowVAT = True Then
            Me.rowVAT.Visible = True
            Me.rowGrandTotal.Visible = True
            Me.lblSubTotal.Text = "SUB-TOTAL"
        Else
            Me.rowVAT.Visible = False
            Me.rowGrandTotal.Visible = False
            Me.lblSubTotal.Text = "GRAND TOTAL"
        End If

    End Sub

    Private Sub SetCurrencyDecimals()

        Me.txtUnitPrice.TextFormatString = "{0:#,0.000#}"
        Me.txtTotalPrice.TextFormatString = "{0:#,0.000}"
        Me.txtSubTotal.TextFormatString = "{0:#,0.000}"
        Me.txtVATAmount.TextFormatString = "{0:#,0.000}"
        Me.txtGrandTotal.TextFormatString = "{0:#,0.000}"

        Me.lblSubTotalCurrency.Text = gCurrencyType
        Me.lblVATTotalCurrency.Text = gCurrencyType
        Me.lblGrandTotalCurrency.Text = gCurrencyType

        Me.lblTotalPrice.Text = "TOTAL AMOUNT (" & gCurrencyType & ")"
        Me.lblUnitPrice.Text = "UNIT PRICE (" & gCurrencyType & ")"


    End Sub
End Class

