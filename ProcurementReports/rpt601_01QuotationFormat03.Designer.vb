<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt601_01QuotationFormat03
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim ShapeRectangle2 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtRecordNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtItemDescription = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellDiscount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtAmtBeforeTax = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblQuotation = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVendorID = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtClientEmail = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblQuotationNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtReferenceNO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblSubject = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtSubject = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblVendorID = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtQuotationNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lineQuotation = New DevExpress.XtraReports.UI.XRLine()
        Me.lblReferenceNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.shapeClientDetails02 = New DevExpress.XtraReports.UI.XRShape()
        Me.shapeClientDetails = New DevExpress.XtraReports.UI.XRShape()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblSlNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDescription = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblUnit = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtUnitPriceText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellDiscountText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtAmtBeforeTaxText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.DsRpt601_01QuotationReport1 = New ERP.dsRpt601_01QuotationReport()
        Me.Qry601_05QuotationReportTableAdapter = New ERP.dsRpt601_01QuotationReportTableAdapters.qry601_05QuotationReportTableAdapter()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.panelPreparedBy = New DevExpress.XtraReports.UI.XRPanel()
        Me.lblPreparedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPreparedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPreparedContactNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPreparedEmail = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPreparedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.panelVerifiedBy = New DevExpress.XtraReports.UI.XRPanel()
        Me.lblVerifiedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblVerifiedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblVerifiedContactNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblVerifiedEmail = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblVerifiedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.panelApprovedBy = New DevExpress.XtraReports.UI.XRPanel()
        Me.lblApprovedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblApprovedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblApprovedContactNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblApprovedEmail = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblApprovedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtApprovedBySignature = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtVerifiedSignature = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtCompanySeal = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtSignatureImage = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.panelAcceptance = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageBreak2 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtAmountInWords = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtTotalBeforeDiscount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rowDiscounts = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rowDiscountsColon = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtDiscountAmount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNetAmountText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblColon = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtNetAmountSales = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.txtUserPrinting = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPageNumber = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.txtSystemTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.calcPropertyDescription = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox2 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox3 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox4 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.calcPropertyDescWithCode = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calcPropertyDescWithPartNo = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calcPropertyDescWtArabic = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calcEmailWithPhone = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRpt601_01QuotationReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 30.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("LineOrderNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(753.4584!, 30.0!)
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.BorderColor = System.Drawing.Color.Gray
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtRecordNo, Me.txtItemDescription, Me.XrTableCell12, Me.XrTableCell13, Me.txtUnitPrice, Me.cellDiscount, Me.txtAmtBeforeTax})
        Me.XrTableRow2.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.0!)
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.StylePriority.UseBorderColor = False
        Me.XrTableRow2.StylePriority.UseFont = False
        Me.XrTableRow2.Weight = 1.0R
        '
        'txtRecordNo
        '
        Me.txtRecordNo.BackColor = System.Drawing.Color.Transparent
        Me.txtRecordNo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtRecordNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.GSCode")})
        Me.txtRecordNo.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtRecordNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRecordNo.Multiline = True
        Me.txtRecordNo.Name = "txtRecordNo"
        Me.txtRecordNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 3, 0, 100.0!)
        Me.txtRecordNo.StylePriority.UseBackColor = False
        Me.txtRecordNo.StylePriority.UseBorders = False
        Me.txtRecordNo.StylePriority.UseFont = False
        Me.txtRecordNo.StylePriority.UseForeColor = False
        Me.txtRecordNo.StylePriority.UsePadding = False
        Me.txtRecordNo.StylePriority.UseTextAlignment = False
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.txtRecordNo.Summary = XrSummary1
        Me.txtRecordNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtRecordNo.Weight = 0.31292910691305936R
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BackColor = System.Drawing.Color.Transparent
        Me.txtItemDescription.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtItemDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.calcPropertyDescription")})
        Me.txtItemDescription.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtItemDescription.Multiline = True
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 3, 0, 100.0!)
        Me.txtItemDescription.StylePriority.UseBackColor = False
        Me.txtItemDescription.StylePriority.UseBorders = False
        Me.txtItemDescription.StylePriority.UseFont = False
        Me.txtItemDescription.StylePriority.UseForeColor = False
        Me.txtItemDescription.StylePriority.UsePadding = False
        Me.txtItemDescription.StylePriority.UseTextAlignment = False
        Me.txtItemDescription.Text = "Material Description"
        Me.txtItemDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtItemDescription.Weight = 2.2980175063679749R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.UnitDesc")})
        Me.XrTableCell12.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 3, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseBackColor = False
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseForeColor = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "Unit"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell12.Weight = 0.599331348264723R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuotedQuantity", "{0:#,#.####}")})
        Me.XrTableCell13.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.XrTableCell13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 3, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UseBackColor = False
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseForeColor = False
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "Qty"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell13.Weight = 0.40886590681955992R
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtUnitPrice.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuotedUnitPrice")})
        Me.txtUnitPrice.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtUnitPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.txtUnitPrice.StylePriority.UseBackColor = False
        Me.txtUnitPrice.StylePriority.UseBorders = False
        Me.txtUnitPrice.StylePriority.UseFont = False
        Me.txtUnitPrice.StylePriority.UseForeColor = False
        Me.txtUnitPrice.StylePriority.UsePadding = False
        Me.txtUnitPrice.StylePriority.UseTextAlignment = False
        Me.txtUnitPrice.Text = "txtUnitPrice"
        Me.txtUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtUnitPrice.TextFormatString = "{0:########0.00##}"
        Me.txtUnitPrice.Weight = 0.59901036381956185R
        '
        'cellDiscount
        '
        Me.cellDiscount.BackColor = System.Drawing.Color.Transparent
        Me.cellDiscount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.cellDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuotedDiscount", "{0:n2}")})
        Me.cellDiscount.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.cellDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cellDiscount.Name = "cellDiscount"
        Me.cellDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.cellDiscount.StylePriority.UseBackColor = False
        Me.cellDiscount.StylePriority.UseBorders = False
        Me.cellDiscount.StylePriority.UseFont = False
        Me.cellDiscount.StylePriority.UseForeColor = False
        Me.cellDiscount.StylePriority.UsePadding = False
        Me.cellDiscount.StylePriority.UseTextAlignment = False
        Me.cellDiscount.Text = "cellDiscount"
        Me.cellDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.cellDiscount.Weight = 0.67391417236490558R
        '
        'txtAmtBeforeTax
        '
        Me.txtAmtBeforeTax.BackColor = System.Drawing.Color.Transparent
        Me.txtAmtBeforeTax.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtAmtBeforeTax.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.LineTotalAfterDiscount", "{0:n2}")})
        Me.txtAmtBeforeTax.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAmtBeforeTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmtBeforeTax.Name = "txtAmtBeforeTax"
        Me.txtAmtBeforeTax.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.txtAmtBeforeTax.StylePriority.UseBackColor = False
        Me.txtAmtBeforeTax.StylePriority.UseBorders = False
        Me.txtAmtBeforeTax.StylePriority.UseFont = False
        Me.txtAmtBeforeTax.StylePriority.UseForeColor = False
        Me.txtAmtBeforeTax.StylePriority.UsePadding = False
        Me.txtAmtBeforeTax.StylePriority.UseTextAlignment = False
        Me.txtAmtBeforeTax.Text = "txtAmtBeforeTax"
        Me.txtAmtBeforeTax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtAmtBeforeTax.Weight = 0.87153160290939125R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 87.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 39.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblQuotation, Me.XrLabel3, Me.txtVendorID, Me.txtClientEmail, Me.XrLabel23, Me.lblQuotationNo, Me.XrLabel21, Me.txtReferenceNO, Me.XrTable6, Me.lblVendorID, Me.txtQuotationNo, Me.XrLabel17, Me.XrLabel30, Me.lineQuotation, Me.lblReferenceNo, Me.XrLabel31, Me.XrLabel1, Me.shapeClientDetails02, Me.shapeClientDetails})
        Me.ReportHeader.HeightF = 260.6875!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'lblQuotation
        '
        Me.lblQuotation.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuotation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblQuotation.LocationFloat = New DevExpress.Utils.PointFloat(13.15887!, 0!)
        Me.lblQuotation.Name = "lblQuotation"
        Me.lblQuotation.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblQuotation.SizeF = New System.Drawing.SizeF(753.1192!, 33.45833!)
        Me.lblQuotation.StylePriority.UseFont = False
        Me.lblQuotation.StylePriority.UseForeColor = False
        Me.lblQuotation.StylePriority.UseTextAlignment = False
        Me.lblQuotation.Text = "Q U O T A T I O N"
        Me.lblQuotation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(477.2794!, 68.35416!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(113.0001!, 20.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Date:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtVendorID
        '
        Me.txtVendorID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.VendorNo", "{0:dd-MMM-yy}")})
        Me.txtVendorID.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtVendorID.LocationFloat = New DevExpress.Utils.PointFloat(591.4291!, 113.8438!)
        Me.txtVendorID.Name = "txtVendorID"
        Me.txtVendorID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVendorID.SizeF = New System.Drawing.SizeF(167.9174!, 20.00002!)
        Me.txtVendorID.StylePriority.UseFont = False
        Me.txtVendorID.StylePriority.UseTextAlignment = False
        Me.txtVendorID.Text = "XrLabel16"
        Me.txtVendorID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtClientEmail
        '
        Me.txtClientEmail.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ClientContactEmail", "Email:{0}")})
        Me.txtClientEmail.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtClientEmail.LocationFloat = New DevExpress.Utils.PointFloat(49.47237!, 113.3542!)
        Me.txtClientEmail.Name = "txtClientEmail"
        Me.txtClientEmail.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtClientEmail.SizeF = New System.Drawing.SizeF(414.9167!, 21.0!)
        Me.txtClientEmail.StylePriority.UseFont = False
        Me.txtClientEmail.Text = "Tel #: [BillingPhoneNo]  ,   Fax # : [BillingFaxNo]"
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel23.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(19.77785!, 43.35425!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(27.69448!, 25.0!)
        Me.XrLabel23.StylePriority.UseBackColor = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "To:"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblQuotationNo
        '
        Me.lblQuotationNo.BackColor = System.Drawing.Color.Transparent
        Me.lblQuotationNo.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuotationNo.LocationFloat = New DevExpress.Utils.PointFloat(477.2794!, 45.35408!)
        Me.lblQuotationNo.Name = "lblQuotationNo"
        Me.lblQuotationNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblQuotationNo.SizeF = New System.Drawing.SizeF(101.2267!, 20.99999!)
        Me.lblQuotationNo.StylePriority.UseBackColor = False
        Me.lblQuotationNo.StylePriority.UseFont = False
        Me.lblQuotationNo.StylePriority.UseTextAlignment = False
        Me.lblQuotationNo.Text = "Quotation No:"
        Me.lblQuotationNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuoteDate", "{0:dd-MMM-yyyy}")})
        Me.XrLabel21.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(589.3737!, 68.35416!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(169.9728!, 20.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "XrLabel16"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtReferenceNO
        '
        Me.txtReferenceNO.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ClientRefNo", "{0:dd-MMM-yy}")})
        Me.txtReferenceNO.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtReferenceNO.LocationFloat = New DevExpress.Utils.PointFloat(590.4291!, 91.35418!)
        Me.txtReferenceNO.Name = "txtReferenceNO"
        Me.txtReferenceNO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReferenceNO.SizeF = New System.Drawing.SizeF(168.9174!, 20.0!)
        Me.txtReferenceNO.StylePriority.UseFont = False
        Me.txtReferenceNO.StylePriority.UseTextAlignment = False
        Me.txtReferenceNO.Text = "XrLabel16"
        Me.txtReferenceNO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTable6
        '
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 149.3542!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7, Me.XrTableRow8})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(754.7222!, 51.31252!)
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell44})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 0.92204631399461268R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BorderColor = System.Drawing.Color.Gray
        Me.XrTableCell8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell8.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell8.StylePriority.UseBorderColor = False
        Me.XrTableCell8.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UsePadding = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "Attention:"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell8.Weight = 0.50592144820016161R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.BorderColor = System.Drawing.Color.Gray
        Me.XrTableCell44.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell44.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.Attention")})
        Me.XrTableCell44.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell44.StylePriority.UseBorderColor = False
        Me.XrTableCell44.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell44.StylePriority.UseBorders = False
        Me.XrTableCell44.StylePriority.UseFont = False
        Me.XrTableCell44.StylePriority.UsePadding = False
        Me.XrTableCell44.StylePriority.UseTextAlignment = False
        Me.XrTableCell44.Text = "Delivery Note No:"
        Me.XrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell44.Weight = 3.5160280942441831R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblSubject, Me.txtSubject})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0779536860053871R
        '
        'lblSubject
        '
        Me.lblSubject.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubject.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.[Double]
        Me.lblSubject.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblSubject.BorderWidth = 3.0!
        Me.lblSubject.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.lblSubject.StylePriority.UseBorderColor = False
        Me.lblSubject.StylePriority.UseBorderDashStyle = False
        Me.lblSubject.StylePriority.UseBorders = False
        Me.lblSubject.StylePriority.UseBorderWidth = False
        Me.lblSubject.StylePriority.UseFont = False
        Me.lblSubject.StylePriority.UsePadding = False
        Me.lblSubject.StylePriority.UseTextAlignment = False
        Me.lblSubject.Text = "Subject :"
        Me.lblSubject.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblSubject.Weight = 0.50592153193102107R
        '
        'txtSubject
        '
        Me.txtSubject.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSubject.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.[Double]
        Me.txtSubject.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtSubject.BorderWidth = 3.0!
        Me.txtSubject.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.SubjectTitle")})
        Me.txtSubject.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.txtSubject.StylePriority.UseBorderColor = False
        Me.txtSubject.StylePriority.UseBorderDashStyle = False
        Me.txtSubject.StylePriority.UseBorders = False
        Me.txtSubject.StylePriority.UseBorderWidth = False
        Me.txtSubject.StylePriority.UseFont = False
        Me.txtSubject.StylePriority.UsePadding = False
        Me.txtSubject.StylePriority.UseTextAlignment = False
        Me.txtSubject.Text = "txtSubject"
        Me.txtSubject.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtSubject.Weight = 3.5160280105133235R
        '
        'lblVendorID
        '
        Me.lblVendorID.BackColor = System.Drawing.Color.Transparent
        Me.lblVendorID.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblVendorID.LocationFloat = New DevExpress.Utils.PointFloat(477.2794!, 113.8438!)
        Me.lblVendorID.Name = "lblVendorID"
        Me.lblVendorID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblVendorID.SizeF = New System.Drawing.SizeF(113.0!, 20.00002!)
        Me.lblVendorID.StylePriority.UseBackColor = False
        Me.lblVendorID.StylePriority.UseFont = False
        Me.lblVendorID.StylePriority.UseTextAlignment = False
        Me.lblVendorID.Text = "Vendor ID:"
        Me.lblVendorID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtQuotationNo
        '
        Me.txtQuotationNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuoteNo")})
        Me.txtQuotationNo.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtQuotationNo.LocationFloat = New DevExpress.Utils.PointFloat(578.5061!, 45.35408!)
        Me.txtQuotationNo.Name = "txtQuotationNo"
        Me.txtQuotationNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtQuotationNo.SizeF = New System.Drawing.SizeF(180.8404!, 20.99999!)
        Me.txtQuotationNo.StylePriority.UseFont = False
        Me.txtQuotationNo.StylePriority.UseTextAlignment = False
        Me.txtQuotationNo.Text = "XrLabel6"
        Me.txtQuotationNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuoteIntro")})
        Me.XrLabel17.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 236.6875!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(754.778!, 24.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UsePadding = False
        Me.XrLabel17.Text = "With reference to your enquiry, please find our competitive quotation as follows:" &
    ""
        '
        'XrLabel30
        '
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ClientName", "{0:dd-MMMM-yyyy}")})
        Me.XrLabel30.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(49.47237!, 43.35413!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(414.9167!, 24.0!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "XrLabel9"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lineQuotation
        '
        Me.lineQuotation.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.lineQuotation.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lineQuotation.BorderWidth = 5.0!
        Me.lineQuotation.ForeColor = System.Drawing.Color.DarkBlue
        Me.lineQuotation.LineWidth = 2.0!
        Me.lineQuotation.LocationFloat = New DevExpress.Utils.PointFloat(12.8399!, 34.45832!)
        Me.lineQuotation.Name = "lineQuotation"
        Me.lineQuotation.SizeF = New System.Drawing.SizeF(753.3824!, 6.895798!)
        Me.lineQuotation.StylePriority.UseBorderDashStyle = False
        Me.lineQuotation.StylePriority.UseBorders = False
        Me.lineQuotation.StylePriority.UseBorderWidth = False
        Me.lineQuotation.StylePriority.UseForeColor = False
        '
        'lblReferenceNo
        '
        Me.lblReferenceNo.BackColor = System.Drawing.Color.Transparent
        Me.lblReferenceNo.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReferenceNo.LocationFloat = New DevExpress.Utils.PointFloat(477.2794!, 91.35418!)
        Me.lblReferenceNo.Name = "lblReferenceNo"
        Me.lblReferenceNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblReferenceNo.SizeF = New System.Drawing.SizeF(113.0!, 20.00001!)
        Me.lblReferenceNo.StylePriority.UseBackColor = False
        Me.lblReferenceNo.StylePriority.UseFont = False
        Me.lblReferenceNo.StylePriority.UseTextAlignment = False
        Me.lblReferenceNo.Text = "Ref No:"
        Me.lblReferenceNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel31
        '
        Me.XrLabel31.EditOptions.Enabled = True
        Me.XrLabel31.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 211.6875!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(223.549!, 21.00002!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UsePadding = False
        Me.XrLabel31.Text = "Dear Sir,"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ClientAddress")})
        Me.XrLabel1.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(49.47253!, 68.35412!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(414.9167!, 43.00007!)
        Me.XrLabel1.StylePriority.UseFont = False
        '
        'shapeClientDetails02
        '
        Me.shapeClientDetails02.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.shapeClientDetails02.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "qry40104RptQuotation.ClientRefNo")})
        Me.shapeClientDetails02.LocationFloat = New DevExpress.Utils.PointFloat(473.2794!, 41.35411!)
        Me.shapeClientDetails02.Name = "shapeClientDetails02"
        ShapeRectangle1.Fillet = 10
        Me.shapeClientDetails02.Shape = ShapeRectangle1
        Me.shapeClientDetails02.SizeF = New System.Drawing.SizeF(292.9987!, 99.00008!)
        '
        'shapeClientDetails
        '
        Me.shapeClientDetails.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.shapeClientDetails.BorderWidth = 1.0!
        Me.shapeClientDetails.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 41.35413!)
        Me.shapeClientDetails.Name = "shapeClientDetails"
        ShapeRectangle2.Fillet = 10
        Me.shapeClientDetails.Shape = ShapeRectangle2
        Me.shapeClientDetails.SizeF = New System.Drawing.SizeF(456.9306!, 99.00007!)
        Me.shapeClientDetails.StylePriority.UseBorderWidth = False
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.GroupHeader1.HeightF = 32.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.Color.Silver
        Me.XrTable1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(754.5001!, 31.50002!)
        Me.XrTable1.StylePriority.UseBackColor = False
        Me.XrTable1.StylePriority.UseBorderColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.BackColor = System.Drawing.Color.LightGray
        Me.XrTableRow1.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblSlNo, Me.lblDescription, Me.lblUnit, Me.lblQty, Me.txtUnitPriceText, Me.cellDiscountText, Me.txtAmtBeforeTaxText})
        Me.XrTableRow1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow1.ForeColor = System.Drawing.Color.Black
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBackColor = False
        Me.XrTableRow1.StylePriority.UseBorderColor = False
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.StylePriority.UseForeColor = False
        Me.XrTableRow1.Weight = 1.3379500532264397R
        '
        'lblSlNo
        '
        Me.lblSlNo.BackColor = System.Drawing.Color.LightBlue
        Me.lblSlNo.BorderColor = System.Drawing.Color.DimGray
        Me.lblSlNo.ForeColor = System.Drawing.Color.Black
        Me.lblSlNo.Multiline = True
        Me.lblSlNo.Name = "lblSlNo"
        Me.lblSlNo.StylePriority.UseBackColor = False
        Me.lblSlNo.StylePriority.UseBorderColor = False
        Me.lblSlNo.StylePriority.UseForeColor = False
        Me.lblSlNo.Text = "#"
        Me.lblSlNo.Weight = 0.31292914019520857R
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.LightBlue
        Me.lblDescription.BorderColor = System.Drawing.Color.DimGray
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.StylePriority.UseBackColor = False
        Me.lblDescription.StylePriority.UseBorderColor = False
        Me.lblDescription.StylePriority.UseForeColor = False
        Me.lblDescription.Text = "Description & Specifications"
        Me.lblDescription.Weight = 2.3073063734862291R
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.LightBlue
        Me.lblUnit.BorderColor = System.Drawing.Color.DimGray
        Me.lblUnit.ForeColor = System.Drawing.Color.Black
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.StylePriority.UseBackColor = False
        Me.lblUnit.StylePriority.UseBorderColor = False
        Me.lblUnit.StylePriority.UseForeColor = False
        Me.lblUnit.Text = "Unit"
        Me.lblUnit.Weight = 0.60571019371946955R
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.LightBlue
        Me.lblQty.BorderColor = System.Drawing.Color.DimGray
        Me.lblQty.ForeColor = System.Drawing.Color.Black
        Me.lblQty.Name = "lblQty"
        Me.lblQty.StylePriority.UseBackColor = False
        Me.lblQty.StylePriority.UseBorderColor = False
        Me.lblQty.StylePriority.UseForeColor = False
        Me.lblQty.Text = "Qty"
        Me.lblQty.Weight = 0.403721711522441R
        '
        'txtUnitPriceText
        '
        Me.txtUnitPriceText.BackColor = System.Drawing.Color.LightBlue
        Me.txtUnitPriceText.BorderColor = System.Drawing.Color.DimGray
        Me.txtUnitPriceText.ForeColor = System.Drawing.Color.Black
        Me.txtUnitPriceText.Multiline = True
        Me.txtUnitPriceText.Name = "txtUnitPriceText"
        Me.txtUnitPriceText.StylePriority.UseBackColor = False
        Me.txtUnitPriceText.StylePriority.UseBorderColor = False
        Me.txtUnitPriceText.StylePriority.UseForeColor = False
        Me.txtUnitPriceText.Text = "Unit Price"
        Me.txtUnitPriceText.Weight = 0.59904079823097167R
        '
        'cellDiscountText
        '
        Me.cellDiscountText.BackColor = System.Drawing.Color.LightBlue
        Me.cellDiscountText.BorderColor = System.Drawing.Color.DimGray
        Me.cellDiscountText.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cellDiscountText.ForeColor = System.Drawing.Color.Black
        Me.cellDiscountText.Name = "cellDiscountText"
        Me.cellDiscountText.StylePriority.UseBackColor = False
        Me.cellDiscountText.StylePriority.UseBorderColor = False
        Me.cellDiscountText.StylePriority.UseBorders = False
        Me.cellDiscountText.StylePriority.UseForeColor = False
        Me.cellDiscountText.Text = "Discount"
        Me.cellDiscountText.Weight = 0.67265006630964252R
        '
        'txtAmtBeforeTaxText
        '
        Me.txtAmtBeforeTaxText.BackColor = System.Drawing.Color.LightBlue
        Me.txtAmtBeforeTaxText.BorderColor = System.Drawing.Color.DimGray
        Me.txtAmtBeforeTaxText.ForeColor = System.Drawing.Color.Black
        Me.txtAmtBeforeTaxText.Multiline = True
        Me.txtAmtBeforeTaxText.Name = "txtAmtBeforeTaxText"
        Me.txtAmtBeforeTaxText.StylePriority.UseBackColor = False
        Me.txtAmtBeforeTaxText.StylePriority.UseBorderColor = False
        Me.txtAmtBeforeTaxText.StylePriority.UseForeColor = False
        Me.txtAmtBeforeTaxText.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount"
        Me.txtAmtBeforeTaxText.Weight = 0.87153169766456329R
        '
        'DsRpt601_01QuotationReport1
        '
        Me.DsRpt601_01QuotationReport1.DataSetName = "dsRpt601_01QuotationReport"
        Me.DsRpt601_01QuotationReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Qry601_05QuotationReportTableAdapter
        '
        Me.Qry601_05QuotationReportTableAdapter.ClearBeforeFill = True
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel29})
        Me.GroupFooter1.HeightF = 17.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(56.63447!, 0!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(278.7065!, 17.0!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "**** Nothing Follows *****"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panelPreparedBy, Me.panelVerifiedBy, Me.panelApprovedBy, Me.txtApprovedBySignature, Me.txtVerifiedSignature, Me.txtCompanySeal, Me.txtSignatureImage, Me.panelAcceptance, Me.XrLabel2, Me.XrPageBreak2})
        Me.ReportFooter.HeightF = 333.1666!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'panelPreparedBy
        '
        Me.panelPreparedBy.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPreparedName, Me.lblPreparedPosition, Me.lblPreparedContactNo, Me.lblPreparedEmail, Me.lblPreparedBy})
        Me.panelPreparedBy.LocationFloat = New DevExpress.Utils.PointFloat(13.56189!, 83.6667!)
        Me.panelPreparedBy.Name = "panelPreparedBy"
        Me.panelPreparedBy.SizeF = New System.Drawing.SizeF(248.125!, 111.3333!)
        '
        'lblPreparedName
        '
        Me.lblPreparedName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.SignatoryName")})
        Me.lblPreparedName.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPreparedName.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 30.99994!)
        Me.lblPreparedName.Name = "lblPreparedName"
        Me.lblPreparedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPreparedName.SizeF = New System.Drawing.SizeF(229.618!, 21.00006!)
        Me.lblPreparedName.StylePriority.UseFont = False
        Me.lblPreparedName.Text = "M. A. Siddiqui"
        '
        'lblPreparedPosition
        '
        Me.lblPreparedPosition.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.SignatoryPosition")})
        Me.lblPreparedPosition.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblPreparedPosition.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 52.0!)
        Me.lblPreparedPosition.Name = "lblPreparedPosition"
        Me.lblPreparedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPreparedPosition.SizeF = New System.Drawing.SizeF(229.618!, 18.0!)
        Me.lblPreparedPosition.StylePriority.UseFont = False
        Me.lblPreparedPosition.Text = "Sales & Marketing Executive"
        '
        'lblPreparedContactNo
        '
        Me.lblPreparedContactNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.SignatoryContact", "Contact #: {0}")})
        Me.lblPreparedContactNo.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblPreparedContactNo.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 70.99994!)
        Me.lblPreparedContactNo.Name = "lblPreparedContactNo"
        Me.lblPreparedContactNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPreparedContactNo.SizeF = New System.Drawing.SizeF(229.618!, 18.0!)
        Me.lblPreparedContactNo.StylePriority.UseFont = False
        Me.lblPreparedContactNo.Text = "Contact # : "
        '
        'lblPreparedEmail
        '
        Me.lblPreparedEmail.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.SignatoryEmail", "Email: {0}")})
        Me.lblPreparedEmail.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblPreparedEmail.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 90.0!)
        Me.lblPreparedEmail.Name = "lblPreparedEmail"
        Me.lblPreparedEmail.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPreparedEmail.SizeF = New System.Drawing.SizeF(229.618!, 18.0!)
        Me.lblPreparedEmail.StylePriority.UseFont = False
        Me.lblPreparedEmail.Text = "Email: "
        '
        'lblPreparedBy
        '
        Me.lblPreparedBy.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblPreparedBy.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPreparedBy.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 8.999939!)
        Me.lblPreparedBy.Name = "lblPreparedBy"
        Me.lblPreparedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPreparedBy.SizeF = New System.Drawing.SizeF(230.0!, 21.0!)
        Me.lblPreparedBy.StylePriority.UseBorders = False
        Me.lblPreparedBy.StylePriority.UseFont = False
        Me.lblPreparedBy.Text = "Prepared By:"
        '
        'panelVerifiedBy
        '
        Me.panelVerifiedBy.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblVerifiedName, Me.lblVerifiedPosition, Me.lblVerifiedContactNo, Me.lblVerifiedEmail, Me.lblVerifiedBy})
        Me.panelVerifiedBy.LocationFloat = New DevExpress.Utils.PointFloat(261.6869!, 83.6667!)
        Me.panelVerifiedBy.Name = "panelVerifiedBy"
        Me.panelVerifiedBy.SizeF = New System.Drawing.SizeF(249.125!, 110.3333!)
        Me.panelVerifiedBy.Visible = False
        '
        'lblVerifiedName
        '
        Me.lblVerifiedName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.VerifiedBySignatoryName")})
        Me.lblVerifiedName.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblVerifiedName.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 30.99994!)
        Me.lblVerifiedName.Name = "lblVerifiedName"
        Me.lblVerifiedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblVerifiedName.SizeF = New System.Drawing.SizeF(229.618!, 21.00006!)
        Me.lblVerifiedName.StylePriority.UseFont = False
        Me.lblVerifiedName.Text = "M. A. Siddiqui"
        '
        'lblVerifiedPosition
        '
        Me.lblVerifiedPosition.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.VerifiedBySignatoryPosition")})
        Me.lblVerifiedPosition.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblVerifiedPosition.LocationFloat = New DevExpress.Utils.PointFloat(10.382!, 52.0!)
        Me.lblVerifiedPosition.Name = "lblVerifiedPosition"
        Me.lblVerifiedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblVerifiedPosition.SizeF = New System.Drawing.SizeF(229.618!, 18.0!)
        Me.lblVerifiedPosition.StylePriority.UseFont = False
        Me.lblVerifiedPosition.Text = "Sales & Marketing Executive"
        '
        'lblVerifiedContactNo
        '
        Me.lblVerifiedContactNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.VerifiedBySignatoryContact", "Contact #: {0}")})
        Me.lblVerifiedContactNo.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblVerifiedContactNo.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 70.99994!)
        Me.lblVerifiedContactNo.Name = "lblVerifiedContactNo"
        Me.lblVerifiedContactNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblVerifiedContactNo.SizeF = New System.Drawing.SizeF(229.618!, 18.0!)
        Me.lblVerifiedContactNo.StylePriority.UseFont = False
        Me.lblVerifiedContactNo.Text = "Contact # : "
        '
        'lblVerifiedEmail
        '
        Me.lblVerifiedEmail.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.VerifiedBySignatoryEmail", "Email: {0}")})
        Me.lblVerifiedEmail.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblVerifiedEmail.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 90.0!)
        Me.lblVerifiedEmail.Name = "lblVerifiedEmail"
        Me.lblVerifiedEmail.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblVerifiedEmail.SizeF = New System.Drawing.SizeF(229.618!, 18.0!)
        Me.lblVerifiedEmail.StylePriority.UseFont = False
        Me.lblVerifiedEmail.Text = "Email: "
        '
        'lblVerifiedBy
        '
        Me.lblVerifiedBy.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblVerifiedBy.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblVerifiedBy.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 8.0!)
        Me.lblVerifiedBy.Name = "lblVerifiedBy"
        Me.lblVerifiedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblVerifiedBy.SizeF = New System.Drawing.SizeF(230.0!, 21.0!)
        Me.lblVerifiedBy.StylePriority.UseBorders = False
        Me.lblVerifiedBy.StylePriority.UseFont = False
        Me.lblVerifiedBy.Text = "Verified By:"
        '
        'panelApprovedBy
        '
        Me.panelApprovedBy.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblApprovedName, Me.lblApprovedPosition, Me.lblApprovedContactNo, Me.lblApprovedEmail, Me.lblApprovedBy})
        Me.panelApprovedBy.LocationFloat = New DevExpress.Utils.PointFloat(512.8751!, 84.6667!)
        Me.panelApprovedBy.Name = "panelApprovedBy"
        Me.panelApprovedBy.SizeF = New System.Drawing.SizeF(254.125!, 109.3333!)
        Me.panelApprovedBy.Visible = False
        '
        'lblApprovedName
        '
        Me.lblApprovedName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ApprovedBySignatoryName")})
        Me.lblApprovedName.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblApprovedName.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 30.99994!)
        Me.lblApprovedName.Name = "lblApprovedName"
        Me.lblApprovedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblApprovedName.SizeF = New System.Drawing.SizeF(229.618!, 21.00006!)
        Me.lblApprovedName.StylePriority.UseFont = False
        Me.lblApprovedName.Text = "M. A. Siddiqui"
        '
        'lblApprovedPosition
        '
        Me.lblApprovedPosition.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ApprovedBySignatoryPosition")})
        Me.lblApprovedPosition.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblApprovedPosition.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 52.0!)
        Me.lblApprovedPosition.Name = "lblApprovedPosition"
        Me.lblApprovedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblApprovedPosition.SizeF = New System.Drawing.SizeF(229.618!, 18.0!)
        Me.lblApprovedPosition.StylePriority.UseFont = False
        Me.lblApprovedPosition.Text = "Sales & Marketing Executive"
        '
        'lblApprovedContactNo
        '
        Me.lblApprovedContactNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ApprovedBySignatoryContact", "Contact #: {0}")})
        Me.lblApprovedContactNo.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblApprovedContactNo.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 70.99994!)
        Me.lblApprovedContactNo.Name = "lblApprovedContactNo"
        Me.lblApprovedContactNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblApprovedContactNo.SizeF = New System.Drawing.SizeF(229.618!, 18.0!)
        Me.lblApprovedContactNo.StylePriority.UseFont = False
        Me.lblApprovedContactNo.Text = "Contact # : "
        '
        'lblApprovedEmail
        '
        Me.lblApprovedEmail.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ApprovedBySignatoryEmail", "Email: {0}")})
        Me.lblApprovedEmail.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblApprovedEmail.LocationFloat = New DevExpress.Utils.PointFloat(10.38203!, 90.0!)
        Me.lblApprovedEmail.Name = "lblApprovedEmail"
        Me.lblApprovedEmail.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblApprovedEmail.SizeF = New System.Drawing.SizeF(229.618!, 18.0!)
        Me.lblApprovedEmail.StylePriority.UseFont = False
        Me.lblApprovedEmail.Text = "Email: "
        '
        'lblApprovedBy
        '
        Me.lblApprovedBy.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblApprovedBy.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblApprovedBy.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 8.0!)
        Me.lblApprovedBy.Name = "lblApprovedBy"
        Me.lblApprovedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblApprovedBy.SizeF = New System.Drawing.SizeF(230.0!, 21.0!)
        Me.lblApprovedBy.StylePriority.UseBorders = False
        Me.lblApprovedBy.StylePriority.UseFont = False
        Me.lblApprovedBy.Text = "Approved By:"
        '
        'txtApprovedBySignature
        '
        Me.txtApprovedBySignature.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry601_05QuotationReport.ApprovedBySignatoryImage")})
        Me.txtApprovedBySignature.LocationFloat = New DevExpress.Utils.PointFloat(522.8751!, 30.0834!)
        Me.txtApprovedBySignature.Name = "txtApprovedBySignature"
        Me.txtApprovedBySignature.SizeF = New System.Drawing.SizeF(242.4793!, 110.5833!)
        Me.txtApprovedBySignature.Visible = False
        '
        'txtVerifiedSignature
        '
        Me.txtVerifiedSignature.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry601_05QuotationReport.VerifiedBySignatoryImage")})
        Me.txtVerifiedSignature.LocationFloat = New DevExpress.Utils.PointFloat(252.584!, 30.0834!)
        Me.txtVerifiedSignature.Name = "txtVerifiedSignature"
        Me.txtVerifiedSignature.SizeF = New System.Drawing.SizeF(294.8833!, 110.5833!)
        Me.txtVerifiedSignature.Visible = False
        '
        'txtCompanySeal
        '
        Me.txtCompanySeal.LocationFloat = New DevExpress.Utils.PointFloat(231.0987!, 6.999964!)
        Me.txtCompanySeal.Name = "txtCompanySeal"
        Me.txtCompanySeal.SizeF = New System.Drawing.SizeF(302.0834!, 156.0!)
        '
        'txtSignatureImage
        '
        Me.txtSignatureImage.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry601_05QuotationReport.SignatureImage")})
        Me.txtSignatureImage.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 20.0!)
        Me.txtSignatureImage.Name = "txtSignatureImage"
        Me.txtSignatureImage.SizeF = New System.Drawing.SizeF(294.8833!, 110.5833!)
        '
        'panelAcceptance
        '
        Me.panelAcceptance.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel34, Me.XrLabel33, Me.XrLabel25, Me.XrLabel32, Me.XrLabel15, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLabel13, Me.XrLabel18, Me.XrLabel24, Me.XrLabel27})
        Me.panelAcceptance.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 195.0!)
        Me.panelAcceptance.Name = "panelAcceptance"
        Me.panelAcceptance.SizeF = New System.Drawing.SizeF(756.4583!, 138.1666!)
        Me.panelAcceptance.Visible = False
        '
        'XrLabel34
        '
        Me.XrLabel34.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(167.3817!, 117.0002!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(22.36795!, 18.00003!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = ":"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel33
        '
        Me.XrLabel33.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(7.559999!, 117.0002!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(158.8263!, 18.00003!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.Text = "Stamp"
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(7.555381!, 99.00017!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(158.8263!, 18.00003!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.Text = "Signature"
        '
        'XrLabel32
        '
        Me.XrLabel32.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(166.3817!, 99.00017!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(22.36795!, 18.00003!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = ":"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(7.555389!, 81.00014!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(158.8263!, 18.00003!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "Date"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(166.3817!, 81.00014!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(22.36795!, 18.00003!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = ":"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(7.555405!, 63.00011!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(158.8263!, 18.00003!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "Job Title"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(166.3817!, 63.00011!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(22.36795!, 18.00003!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = ":"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(7.555405!, 45.00008!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(158.8263!, 18.00003!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "Authorized Signatory"
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(166.3817!, 45.00008!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(22.36795!, 18.00003!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = ":"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Cambria", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(7.555405!, 6.000007!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(278.1789!, 21.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "Quotation Acceptance by Hirer"
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(7.555407!, 27.00005!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(158.8263!, 18.00003!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "Company Name"
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(166.3817!, 27.00005!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(22.36795!, 18.00003!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = ":"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ClientName")})
        Me.XrLabel27.Font = New System.Drawing.Font("Cambria", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(188.7496!, 27.00005!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(541.8057!, 18.00003!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.Text = "Signature, Seal & Date:"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuoteThanksNote")})
        Me.XrLabel2.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(12.8399!, 3.0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(753.1185!, 52.29166!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.Text = "Furthermore, If you require any more clarification, please do not hesitate to cal" &
    "l the undersigned." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Many Thanks & Regards,"
        '
        'XrPageBreak2
        '
        Me.XrPageBreak2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageBreak2.Name = "XrPageBreak2"
        Me.XrPageBreak2.Visible = False
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak1, Me.XrSubreport1, Me.XrLabel7, Me.XrTable3})
        Me.GroupFooter2.HeightF = 139.5!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 114.5!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.CanShrink = True
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 118.5!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New ERP.rpt40102QuotationTerms()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(755.9584!, 21.00001!)
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuotationSummary")})
        Me.XrLabel7.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(12.49998!, 85.50002!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(753.4584!, 24.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.Text = "With reference to your enquiry, please find our competitive quotation as follows:" &
    ""
        '
        'XrTable3
        '
        Me.XrTable3.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left
        Me.XrTable3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrTable3.KeepTogether = True
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 6.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow5, Me.XrTableRow9})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(754.5001!, 75.5!)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtAmountInWords, Me.XrTableCell20, Me.XrTableCell21, Me.txtTotalBeforeDiscount})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'txtAmountInWords
        '
        Me.txtAmountInWords.BorderColor = System.Drawing.Color.DimGray
        Me.txtAmountInWords.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.txtAmountInWords.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAmountInWords.Multiline = True
        Me.txtAmountInWords.Name = "txtAmountInWords"
        Me.txtAmountInWords.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 10, 100.0!)
        Me.txtAmountInWords.RowSpan = 5
        Me.txtAmountInWords.StylePriority.UseBorderColor = False
        Me.txtAmountInWords.StylePriority.UseBorders = False
        Me.txtAmountInWords.StylePriority.UseFont = False
        Me.txtAmountInWords.StylePriority.UsePadding = False
        Me.txtAmountInWords.StylePriority.UseTextAlignment = False
        Me.txtAmountInWords.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.txtAmountInWords.Weight = 4.0495482064959329R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell20.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell20.EditOptions.Enabled = True
        Me.XrTableCell20.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell20.StylePriority.UseBorderColor = False
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UsePadding = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.Text = "Gross Amount "
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell20.Weight = 1.8804833833560246R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell21.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBorderColor = False
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = ":"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell21.Weight = 0.24098194861063277R
        '
        'txtTotalBeforeDiscount
        '
        Me.txtTotalBeforeDiscount.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalBeforeDiscount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.txtTotalBeforeDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.TotalBeforeDiscount", "{0:n2}")})
        Me.txtTotalBeforeDiscount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalBeforeDiscount.Name = "txtTotalBeforeDiscount"
        Me.txtTotalBeforeDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtTotalBeforeDiscount.StylePriority.UseBorderColor = False
        Me.txtTotalBeforeDiscount.StylePriority.UseBorders = False
        Me.txtTotalBeforeDiscount.StylePriority.UseFont = False
        Me.txtTotalBeforeDiscount.StylePriority.UsePadding = False
        Me.txtTotalBeforeDiscount.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        Me.txtTotalBeforeDiscount.Summary = XrSummary2
        Me.txtTotalBeforeDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtTotalBeforeDiscount.Weight = 1.1094304370869479R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell41, Me.rowDiscounts, Me.rowDiscountsColon, Me.txtDiscountAmount})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell41.StylePriority.UseFont = False
        Me.XrTableCell41.StylePriority.UsePadding = False
        Me.XrTableCell41.StylePriority.UseTextAlignment = False
        Me.XrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell41.Weight = 4.0495482064959329R
        '
        'rowDiscounts
        '
        Me.rowDiscounts.EditOptions.Enabled = True
        Me.rowDiscounts.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.rowDiscounts.Name = "rowDiscounts"
        Me.rowDiscounts.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.rowDiscounts.StylePriority.UseFont = False
        Me.rowDiscounts.StylePriority.UsePadding = False
        Me.rowDiscounts.StylePriority.UseTextAlignment = False
        Me.rowDiscounts.Text = " (- Less ) Total Discount"
        Me.rowDiscounts.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.rowDiscounts.Weight = 1.880483972306275R
        '
        'rowDiscountsColon
        '
        Me.rowDiscountsColon.Name = "rowDiscountsColon"
        Me.rowDiscountsColon.StylePriority.UseTextAlignment = False
        Me.rowDiscountsColon.Text = ":"
        Me.rowDiscountsColon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.rowDiscountsColon.Weight = 0.24098135966038264R
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtDiscountAmount.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.txtDiscountAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.Discount", "{0:n2}")})
        Me.txtDiscountAmount.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtDiscountAmount.StylePriority.UseBorderColor = False
        Me.txtDiscountAmount.StylePriority.UseBorders = False
        Me.txtDiscountAmount.StylePriority.UseFont = False
        Me.txtDiscountAmount.StylePriority.UsePadding = False
        Me.txtDiscountAmount.StylePriority.UseTextAlignment = False
        Me.txtDiscountAmount.Text = "txtDiscountAmount"
        Me.txtDiscountAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtDiscountAmount.Weight = 1.1094304370869479R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblNetAmountText, Me.lblColon, Me.txtNetAmountSales})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'lblNetAmountText
        '
        Me.lblNetAmountText.BackColor = System.Drawing.Color.LightBlue
        Me.lblNetAmountText.BorderColor = System.Drawing.Color.DimGray
        Me.lblNetAmountText.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblNetAmountText.EditOptions.Enabled = True
        Me.lblNetAmountText.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNetAmountText.Name = "lblNetAmountText"
        Me.lblNetAmountText.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.lblNetAmountText.StylePriority.UseBackColor = False
        Me.lblNetAmountText.StylePriority.UseBorderColor = False
        Me.lblNetAmountText.StylePriority.UseBorders = False
        Me.lblNetAmountText.StylePriority.UseFont = False
        Me.lblNetAmountText.StylePriority.UsePadding = False
        Me.lblNetAmountText.StylePriority.UseTextAlignment = False
        Me.lblNetAmountText.Text = "Total Amount "
        Me.lblNetAmountText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblNetAmountText.Weight = 5.9300318843270823R
        '
        'lblColon
        '
        Me.lblColon.BackColor = System.Drawing.Color.LightBlue
        Me.lblColon.BorderColor = System.Drawing.Color.DimGray
        Me.lblColon.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.StylePriority.UseBackColor = False
        Me.lblColon.StylePriority.UseBorderColor = False
        Me.lblColon.StylePriority.UseBorders = False
        Me.lblColon.StylePriority.UseTextAlignment = False
        Me.lblColon.Text = ":"
        Me.lblColon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lblColon.Weight = 0.240982537560883R
        '
        'txtNetAmountSales
        '
        Me.txtNetAmountSales.BackColor = System.Drawing.Color.LightBlue
        Me.txtNetAmountSales.BorderColor = System.Drawing.Color.DimGray
        Me.txtNetAmountSales.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtNetAmountSales.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.TotalAfterDiscount", "{0:n2}")})
        Me.txtNetAmountSales.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNetAmountSales.Name = "txtNetAmountSales"
        Me.txtNetAmountSales.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtNetAmountSales.StylePriority.UseBackColor = False
        Me.txtNetAmountSales.StylePriority.UseBorderColor = False
        Me.txtNetAmountSales.StylePriority.UseBorders = False
        Me.txtNetAmountSales.StylePriority.UseFont = False
        Me.txtNetAmountSales.StylePriority.UsePadding = False
        Me.txtNetAmountSales.StylePriority.UseTextAlignment = False
        Me.txtNetAmountSales.Text = "txtNetAmountSales"
        Me.txtNetAmountSales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtNetAmountSales.Weight = 1.1094295536615726R
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtUserPrinting, Me.txtPageNumber, Me.txtSystemTitle})
        Me.PageFooter.HeightF = 19.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'txtUserPrinting
        '
        Me.txtUserPrinting.BorderColor = System.Drawing.Color.Empty
        Me.txtUserPrinting.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.txtUserPrinting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUserPrinting.LocationFloat = New DevExpress.Utils.PointFloat(468.5267!, 0!)
        Me.txtUserPrinting.Name = "txtUserPrinting"
        Me.txtUserPrinting.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtUserPrinting.SizeF = New System.Drawing.SizeF(301.0982!, 19.0!)
        Me.txtUserPrinting.StylePriority.UseBorderColor = False
        Me.txtUserPrinting.StylePriority.UseFont = False
        Me.txtUserPrinting.StylePriority.UseForeColor = False
        Me.txtUserPrinting.StylePriority.UseTextAlignment = False
        Me.txtUserPrinting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtPageNumber
        '
        Me.txtPageNumber.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.txtPageNumber.ForeColor = System.Drawing.Color.DimGray
        Me.txtPageNumber.LocationFloat = New DevExpress.Utils.PointFloat(320.9849!, 0!)
        Me.txtPageNumber.Name = "txtPageNumber"
        Me.txtPageNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPageNumber.SizeF = New System.Drawing.SizeF(108.0!, 17.0!)
        Me.txtPageNumber.StylePriority.UseFont = False
        Me.txtPageNumber.StylePriority.UseForeColor = False
        Me.txtPageNumber.StylePriority.UseTextAlignment = False
        Me.txtPageNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtPageNumber.TextFormatString = "Page No:{0} of {1}"
        '
        'txtSystemTitle
        '
        Me.txtSystemTitle.BorderColor = System.Drawing.Color.Empty
        Me.txtSystemTitle.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.txtSystemTitle.ForeColor = System.Drawing.Color.DimGray
        Me.txtSystemTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.624889!, 0!)
        Me.txtSystemTitle.Name = "txtSystemTitle"
        Me.txtSystemTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSystemTitle.SizeF = New System.Drawing.SizeF(277.9597!, 18.0!)
        Me.txtSystemTitle.StylePriority.UseBorderColor = False
        Me.txtSystemTitle.StylePriority.UseFont = False
        Me.txtSystemTitle.StylePriority.UseForeColor = False
        Me.txtSystemTitle.StylePriority.UseTextAlignment = False
        Me.txtSystemTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'calcPropertyDescription
        '
        Me.calcPropertyDescription.DataMember = "qry601_05QuotationReport"
        Me.calcPropertyDescription.Expression = "Iif(IsNullOrEmpty([AddlDescription]), [GSDescrpition]  , [AddlDescription] )"
        Me.calcPropertyDescription.Name = "calcPropertyDescription"
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox1.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox1.BorderWidth = 1.0!
        Me.XrCrossBandBox1.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(12.49998!, 2.00003!)
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(12.49998!, 31.0!)
        Me.XrCrossBandBox1.WidthF = 754.5001!
        '
        'XrCrossBandBox2
        '
        Me.XrCrossBandBox2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox2.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox2.BorderWidth = 1.0!
        Me.XrCrossBandBox2.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox2.EndPointFloat = New DevExpress.Utils.PointFloat(52.63446!, 2.00003!)
        Me.XrCrossBandBox2.Name = "XrCrossBandBox2"
        Me.XrCrossBandBox2.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox2.StartPointFloat = New DevExpress.Utils.PointFloat(52.63446!, 31.0!)
        Me.XrCrossBandBox2.WidthF = 599.3913!
        '
        'XrCrossBandBox3
        '
        Me.XrCrossBandBox3.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox3.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox3.BorderWidth = 1.0!
        Me.XrCrossBandBox3.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox3.EndPointFloat = New DevExpress.Utils.PointFloat(354.9572!, 2.000046!)
        Me.XrCrossBandBox3.Name = "XrCrossBandBox3"
        Me.XrCrossBandBox3.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox3.StartPointFloat = New DevExpress.Utils.PointFloat(354.9572!, 31.00001!)
        Me.XrCrossBandBox3.WidthF = 210.2228!
        '
        'XrCrossBandBox4
        '
        Me.XrCrossBandBox4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox4.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox4.BorderWidth = 1.0!
        Me.XrCrossBandBox4.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox4.EndPointFloat = New DevExpress.Utils.PointFloat(433.2118!, 2.00003!)
        Me.XrCrossBandBox4.Name = "XrCrossBandBox4"
        Me.XrCrossBandBox4.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox4.StartPointFloat = New DevExpress.Utils.PointFloat(433.2118!, 31.0!)
        Me.XrCrossBandBox4.WidthF = 53.67535!
        '
        'calcPropertyDescWithCode
        '
        Me.calcPropertyDescWithCode.DataMember = "qry601_05QuotationReport"
        Me.calcPropertyDescWithCode.Expression = "Iif(IsNullOrEmpty([AddlDescription]), Concat([GSCode], ' - ', [GSDescrpition]),  " &
    "Concat([GSCode], ' - ', [AddlDescription]) )"
        Me.calcPropertyDescWithCode.Name = "calcPropertyDescWithCode"
        '
        'calcPropertyDescWithPartNo
        '
        Me.calcPropertyDescWithPartNo.DataMember = "qry601_05QuotationReport"
        Me.calcPropertyDescWithPartNo.Expression = "Iif(IsNullOrEmpty([AddlDescription]), Concat([GSDescrpition], '|| Catalogue # ', " &
    "[ItemPartNo]),  Concat( [AddlDescription], '|| Catalogue # ', [ItemPartNo]) )"
        Me.calcPropertyDescWithPartNo.Name = "calcPropertyDescWithPartNo"
        '
        'calcPropertyDescWtArabic
        '
        Me.calcPropertyDescWtArabic.DataMember = "qry601_05QuotationReport"
        Me.calcPropertyDescWtArabic.Expression = "Iif(IsNullOrEmpty([AddlDescription]), Concat([GSDescriptionAr], ' || ', [GSDescrp" &
    "ition], ' || Cat# ', [ItemPartNo]),  Concat( [GSDescriptionAr], ' || ', [AddlDes" &
    "cription], ' || Cat# ', [ItemPartNo]) )"
        Me.calcPropertyDescWtArabic.Name = "calcPropertyDescWtArabic"
        '
        'calcEmailWithPhone
        '
        Me.calcEmailWithPhone.DataMember = "qry601_05QuotationReport"
        Me.calcEmailWithPhone.Expression = "Concat('Email: ',Iif(IsNullOrEmpty([ClientContactEmail]), '',[ClientContactEmail]" &
    " ), '     Contact #:', Iif(IsNullOrEmpty([ClientContactNo] ), ' ', [ClientContac" &
    "tNo] ))"
        Me.calcEmailWithPhone.Name = "calcEmailWithPhone"
        '
        'rpt601_01QuotationFormat03
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupFooter1, Me.ReportFooter, Me.GroupFooter2, Me.PageFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calcPropertyDescription, Me.calcPropertyDescWithCode, Me.calcPropertyDescWithPartNo, Me.calcPropertyDescWtArabic, Me.calcEmailWithPhone})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBox4, Me.XrCrossBandBox3, Me.XrCrossBandBox2, Me.XrCrossBandBox1})
        Me.DataAdapter = Me.Qry601_05QuotationReportTableAdapter
        Me.DataMember = "qry601_05QuotationReport"
        Me.DataSource = Me.DsRpt601_01QuotationReport1
        Me.Margins = New System.Drawing.Printing.Margins(25, 24, 87, 39)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "21.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRpt601_01QuotationReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents DsRpt601_01QuotationReport1 As ERP.dsRpt601_01QuotationReport
    Friend WithEvents Qry601_05QuotationReportTableAdapter As ERP.dsRpt601_01QuotationReportTableAdapters.qry601_05QuotationReportTableAdapter
    Friend WithEvents shapeClientDetails02 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents shapeClientDetails As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents lblQuotation As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtVendorID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtClientEmail As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblQuotationNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtReferenceNO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblSubject As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtSubject As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblVendorID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtQuotationNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lineQuotation As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblReferenceNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblSlNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblUnit As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtUnitPriceText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellDiscountText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtAmtBeforeTaxText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtRecordNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtItemDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtUnitPrice As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellDiscount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtAmtBeforeTax As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtAmountInWords As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTotalBeforeDiscount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rowDiscounts As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rowDiscountsColon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtDiscountAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNetAmountText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblColon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtNetAmountSales As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageBreak2 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents txtCompanySeal As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtSignatureImage As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents calcPropertyDescription As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox2 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox3 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox4 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents panelAcceptance As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtUserPrinting As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPageNumber As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents txtSystemTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents calcPropertyDescWithCode As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents calcPropertyDescWithPartNo As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents calcPropertyDescWtArabic As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents calcEmailWithPhone As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents panelPreparedBy As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblPreparedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPreparedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPreparedContactNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPreparedEmail As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPreparedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents panelVerifiedBy As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblVerifiedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblVerifiedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblVerifiedContactNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblVerifiedEmail As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblVerifiedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents panelApprovedBy As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblApprovedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblApprovedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblApprovedContactNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblApprovedEmail As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblApprovedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtApprovedBySignature As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtVerifiedSignature As DevExpress.XtraReports.UI.XRPictureBox
End Class
