Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Globalization
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class rpt601_01CustomQuotationFormat1

#Region "Old Code"
    'Public Sub New()
    '    InitializeComponent()
    'End Sub
    'Public Sub New(ByVal gridData As DataSet, ByVal gv As GridView)
    '    InitializeComponent()
    '    Dim columnAL As New ArrayList()
    '    Me.DataSource = gridData
    '    Me.DataMember = gridData.Tables(0).TableName
    '    For i As Integer = gv.GroupCount - 1 To 0 Step -1
    '        InsertGroupBand(gv.GroupedColumns(i), i)
    '    Next i
    '    For i As Integer = 0 To gv.Columns.Count - 1
    '        If gv.Columns(i).Visible AndAlso gv.Columns(i).GroupIndex < 0 Then
    '            columnAL.Add(gv.Columns(i).Caption)
    '        End If
    '    Next i
    '    InitTables(columnAL)
    'End Sub

    'Private Sub InsertGroupBand(ByVal gridColumn As DevExpress.XtraGrid.Columns.GridColumn, ByVal i As Integer)
    '    Dim gb As New GroupHeaderBand()
    '    gb.Height = 25
    '    gb.RepeatEveryPage = True
    '    Dim l As New XRLabel()
    '    l.DataBindings.Add("Text", Me.DataSource, gridColumn.Caption)
    '    l.Size = New Size(300, 25)
    '    l.Location = New Point(0 + i * 20, 0)
    '    l.BackColor = Color.Beige
    '    gb.Controls.Add(l)
    '    Dim gf As GroupField
    '    If gridColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending Then
    '        gf = New GroupField(gridColumn.FieldName, XRColumnSortOrder.Ascending)
    '    Else
    '        gf = New GroupField(gridColumn.FieldName, XRColumnSortOrder.Descending)
    '    End If
    '    gb.GroupFields.Add(gf)
    '    Me.Bands.Add(gb)
    'End Sub
    'Public Sub InitTables(ByVal columns As ArrayList)

    '    Dim colCount As Integer = columns.Count
    '    Dim pagewidth As Integer = (Me.PageWidth - (Margins.Left + Margins.Right))
    '    Dim colWidth As Integer = pagewidth \ colCount

    '    Dim table As New XRTable()
    '    Dim row As New XRTableRow()
    '    Dim table2 As New XRTable()
    '    Dim row2 As New XRTableRow()

    '    For i As Integer = 0 To colCount - 1
    '        Dim cell As New XRTableCell()
    '        cell.Width = CInt(Fix(colWidth))
    '        cell.Text = columns(i).ToString()
    '        row.Cells.Add(cell)

    '        Dim cell2 As New XRTableCell()
    '        cell2.Width = CInt(Fix(colWidth))
    '        cell2.DataBindings.Add("Text", Nothing, columns(i).ToString())
    '        row2.Cells.Add(cell2)
    '    Next i
    '    table.Rows.Add(row)
    '    table.Width = pagewidth
    '    table.Borders = DevExpress.XtraPrinting.BorderSide.Bottom

    '    table2.Rows.Add(row2)
    '    table2.Width = pagewidth

    '    Bands(BandKind.PageHeader).Controls.Add(table)
    '    Bands(BandKind.Detail).Controls.Add(table2)
    'End Sub

    'Private Sub rpt601_01CustomQuotationFormat1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint

    '    'If Convert.ToBoolean(showDiscount.Value) Then
    '    '    Me.lblDiscount.Visible = True
    '    '    Me.txtDiscount.Visible = True

    '    'Else
    '    '    Me.lblDiscount.Visible = False
    '    '    Me.txtDiscount.Visible = False

    '    'End If

    '    'Me.Detail.Controls.Add(CreateXRTable())

    'End Sub

    ''Public Function CreateXRTable() As XRTable
    ''    Dim cellsInRow As Integer = 3
    ''    Dim rowsCount As Integer = 3
    ''    Dim rowHeight As Single = 25.0F

    ''    Dim table As New XRTable()
    ''    table.Borders = DevExpress.XtraPrinting.BorderSide.All
    ''    table.BeginInit()

    ''    For i As Integer = 0 To rowsCount - 1
    ''        Dim row As New XRTableRow()
    ''        row.HeightF = rowHeight
    ''        For j As Integer = 0 To cellsInRow - 1
    ''            Dim cell As New XRTableCell()
    ''            row.Cells.Add(cell)
    ''        Next j
    ''        table.Rows.Add(row)
    ''    Next i

    ''    AddHandler table.BeforePrint, AddressOf table_BeforePrint
    ''    table.AdjustSize()
    ''    table.EndInit()
    ''    Return table
    ''End Function

    ''Private Sub table_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
    ''    Dim table As XRTable = (CType(sender, XRTable))
    ''    table.LocationF = New DevExpress.Utils.PointFloat(0.0F, 0.0F)
    ''    table.WidthF = Me.PageWidth - Me.Margins.Left - Me.Margins.Right
    ''End Sub

#End Region

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intCompanyID As Integer = 1
    Public IsPrintItemCodeWithDescription As Boolean = False
    Public IsPrintItemPartNoWithDescription As Boolean = False

    Public boolShowVerifiedBy As Boolean
    Public boolShowApprovedBy As Boolean
    Public boolShowSignatures As Boolean

    Private Sub rpt601_01QuotationFormat01_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            GetCompanySealImage()
            'Get Print Margins
            GetReportDetails("IMS-QTN-05")
            Me.TopMargin.HeightF = gReportTopMargin
            Me.BottomMargin.HeightF = gReportBottomMargin

            Me.Margins.Left = gReportLeftMargin
            Me.Margins.Right = gReportRightMargin

            Me.txtPageNumber.Visible = gReportIsShowPageNo
            Me.txtUserPrinting.Visible = gReportIsShowPrintedBy
            Me.txtSystemTitle.Text = gDocumentNo
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

            ElseIf gReportSet = "203" Then 'For Tart Medical Est.
                Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry601_05QuotationReport.ClientRefNo", "{0}")
                Me.txtReferenceNO.DataBindings.Add(BindingReferenceNo)
                Me.lblReferenceNo.Text = "Customer RFQ:"

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
                Me.XrTableCell2.BackColor = Color.LightGray
                Me.lblColumn1.BackColor = Color.LightGray
                Me.lblColumn2.BackColor = Color.LightGray
                Me.lblColumn3.BackColor = Color.LightGray
                Me.lblUnit.BackColor = Color.LightGray
                Me.lblQty.BackColor = Color.LightGray
                Me.txtUnitPriceText.BackColor = Color.LightGray
                Me.txtVATText.BackColor = Color.LightGray
                Me.lblVATAmount.BackColor = Color.LightGray

                Me.lblNetAmountText.BackColor = Color.LightGray
                Me.lblColon.BackColor = Color.LightGray
                Me.txtNetAmountSales.BackColor = Color.LightGray

                Me.lblSubject.Borders = BorderSide.None
                Me.txtSubject.Borders = BorderSide.None

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

            Me.txtUnitPriceText.Text = "Unit Price" & vbCrLf & "(" & gCurrencyType & ")"
            Me.lblVATAmount.Text = "Total" & vbCrLf & "Amount (" & gCurrencyType & ")"
            Me.lblNetAmountText.Text = "Net Amount (" & gCurrencyType & "):"

            'If the option to Print Item Code along with Description
            If Me.IsPrintItemCodeWithDescription = True Then
                Me.txtItemDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWithCode")
            End If

            If Me.IsPrintItemPartNoWithDescription = True Then
                Me.txtItemDescription.DataBindings.Add("Text", Nothing, "calcPropertyDescWithPartNo")
            End If
            ShowSignatoryFields()

            If gDefaultCurrencyDecimals = 3 Then
                Me.SetCurrencyThreeDecimals()
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load Images for document, Please try again.", "Loading Images Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowSignatoryFields()

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

    Public Sub SetColumns(ByVal NoOfColumns As Integer)
        If NoOfColumns = 3 Then

            Me.lblColumn1.WidthF = 80
            Me.txtColumn1.WidthF = 80

            Me.lblColumn2.WidthF = 80
            Me.txtColumn2.WidthF = 80

            Me.lblColumn3.WidthF = 80
            Me.txtColumn3.WidthF = 80

            Me.LineColumns1a.Visible = True
            Me.LineColumns1b.Visible = True
            Me.LineColumns2.Visible = False


        ElseIf NoOfColumns = 2 Then
            Me.lblColumn3.WidthF = 1
            Me.txtColumn3.WidthF = 1

            Me.lblColumn2.WidthF = 118
            Me.txtColumn2.WidthF = 118

            Me.lblColumn1.WidthF = 118
            Me.txtColumn1.WidthF = 118

            Me.LineColumns1a.Visible = False
            Me.LineColumns1b.Visible = False
            Me.LineColumns2.Visible = True

            Me.lblColumn3.Text = ""

        ElseIf NoOfColumns = 1 Then

            Me.lblColumn3.WidthF = 1
            Me.txtColumn3.WidthF = 1

            Me.lblColumn2.WidthF = 1
            Me.txtColumn2.WidthF = 1

            Me.lblColumn1.WidthF = 236
            Me.txtColumn1.WidthF = 236

            Me.LineColumns1a.Visible = False
            Me.LineColumns1b.Visible = False
            Me.LineColumns2.Visible = False

            Me.lblColumn3.Text = ""
            Me.lblColumn2.Text = ""

        End If
    End Sub

    Public Sub GetColumnOne(ByVal ColumnLabel As String, ByVal ColumnData As String)
        Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation." & ColumnData, "{0}")
        Me.txtColumn1.DataBindings.Add(BindingReferenceNo)
        Me.lblColumn1.Text = ColumnLabel
    End Sub

    Public Sub GetColumnTwo(ByVal ColumnLabel As String, ByVal ColumnData As String)
        Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation." & ColumnData, "{0}")
        Me.txtColumn2.DataBindings.Add(BindingReferenceNo)
        Me.lblColumn2.Text = ColumnLabel
    End Sub

    Public Sub GetColumnThree(ByVal ColumnLabel As String, ByVal ColumnData As String)
        Dim BindingReferenceNo As New XRBinding("Text", Me.DataSource, "qry40104RptQuotation." & ColumnData, "{0}")
        Me.txtColumn3.DataBindings.Add(BindingReferenceNo)
        Me.lblColumn3.Text = ColumnLabel
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
        Me.txtTotalBeforeDiscount.TextFormatString = "{0:#,0.000}"
        Me.txtDiscountAmount.TextFormatString = "{0:#,0.000}"
        Me.txtVatAmount.TextFormatString = "{0:#,0.000}"
        Me.txtAdditionAmount.TextFormatString = "{0:#,0.000}"
        Me.txtDeductionAmount.TextFormatString = "{0:#,0.000}"
        Me.txtNetAmountSales.TextFormatString = "{0:#,0.000}"
        Me.txtUnitPrice.TextFormatString = "{0:#,0.000#}"

    End Sub
End Class