<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt601_01CustomQuotationFormat1
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
        Me.txtColumn1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtColumn2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtColumn3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtVAT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtAmtBeforeTax = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblSlNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblColumn1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblColumn2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblColumn3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblUnit = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtUnitPriceText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtVATText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblVATAmount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.DsRpt601_01QuotationReport1 = New ERP.dsRpt601_01QuotationReport()
        Me.Qry601_05QuotationReportTableAdapter = New ERP.dsRpt601_01QuotationReportTableAdapters.qry601_05QuotationReportTableAdapter()
        Me.calcPropertyDescription = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblQuotation = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVendorID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.shapeClientDetails = New DevExpress.XtraReports.UI.XRShape()
        Me.shapeClientDetails02 = New DevExpress.XtraReports.UI.XRShape()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtAmountInWords = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtTotalBeforeDiscount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtVatAmount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rowAdditions = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtAdditionAmount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rowDeductions = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtDeductionAmount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rowDiscounts = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rowDiscountsColon = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtDiscountAmount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNetAmountText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblColon = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtNetAmountSales = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.txtVerifiedSignature = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtApprovedBySignature = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageBreak2 = New DevExpress.XtraReports.UI.XRPageBreak()
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
        Me.txtSignatureImage = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtCompanySeal = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.LineColumns2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.LineColumns1b = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.LineColumns1a = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.txtUserPrinting = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPageNumber = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.txtSystemTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.calcPropertyDescWithCode = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calcPropertyDescWithPartNo = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRpt601_01QuotationReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(800.0!, 30.0!)
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.BorderColor = System.Drawing.Color.Gray
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtRecordNo, Me.txtItemDescription, Me.txtColumn1, Me.txtColumn2, Me.txtColumn3, Me.XrTableCell12, Me.XrTableCell13, Me.txtUnitPrice, Me.txtVAT, Me.txtAmtBeforeTax})
        Me.XrTableRow2.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.0!)
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.StylePriority.UseBorderColor = False
        Me.XrTableRow2.StylePriority.UseFont = False
        Me.XrTableRow2.Weight = 1.0R
        '
        'txtRecordNo
        '
        Me.txtRecordNo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtRecordNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.GSCode")})
        Me.txtRecordNo.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.txtRecordNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRecordNo.Multiline = True
        Me.txtRecordNo.Name = "txtRecordNo"
        Me.txtRecordNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 3, 0, 100.0!)
        Me.txtRecordNo.StylePriority.UseBorders = False
        Me.txtRecordNo.StylePriority.UseFont = False
        Me.txtRecordNo.StylePriority.UseForeColor = False
        Me.txtRecordNo.StylePriority.UsePadding = False
        Me.txtRecordNo.StylePriority.UseTextAlignment = False
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.txtRecordNo.Summary = XrSummary1
        Me.txtRecordNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtRecordNo.Weight = 0.19060227778497435R
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtItemDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.calcPropertyDescription")})
        Me.txtItemDescription.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.txtItemDescription.Multiline = True
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 3, 0, 100.0!)
        Me.txtItemDescription.StylePriority.UseBorders = False
        Me.txtItemDescription.StylePriority.UseFont = False
        Me.txtItemDescription.StylePriority.UsePadding = False
        Me.txtItemDescription.StylePriority.UseTextAlignment = False
        Me.txtItemDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtItemDescription.Weight = 1.5934422287561563R
        '
        'txtColumn1
        '
        Me.txtColumn1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtColumn1.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.txtColumn1.Name = "txtColumn1"
        Me.txtColumn1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 3, 0, 100.0!)
        Me.txtColumn1.StylePriority.UseBorders = False
        Me.txtColumn1.StylePriority.UseFont = False
        Me.txtColumn1.StylePriority.UsePadding = False
        Me.txtColumn1.StylePriority.UseTextAlignment = False
        Me.txtColumn1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtColumn1.Weight = 1.6350102612439725R
        '
        'txtColumn2
        '
        Me.txtColumn2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtColumn2.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.txtColumn2.Name = "txtColumn2"
        Me.txtColumn2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 3, 0, 100.0!)
        Me.txtColumn2.StylePriority.UseBorders = False
        Me.txtColumn2.StylePriority.UseFont = False
        Me.txtColumn2.StylePriority.UsePadding = False
        Me.txtColumn2.StylePriority.UseTextAlignment = False
        Me.txtColumn2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtColumn2.Weight = 0.012701421185446371R
        '
        'txtColumn3
        '
        Me.txtColumn3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtColumn3.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.txtColumn3.Multiline = True
        Me.txtColumn3.Name = "txtColumn3"
        Me.txtColumn3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 3, 0, 100.0!)
        Me.txtColumn3.StylePriority.UseBorders = False
        Me.txtColumn3.StylePriority.UseFont = False
        Me.txtColumn3.StylePriority.UseForeColor = False
        Me.txtColumn3.StylePriority.UsePadding = False
        Me.txtColumn3.StylePriority.UseTextAlignment = False
        Me.txtColumn3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtColumn3.Weight = 0.015010405301405516R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.UnitDesc")})
        Me.XrTableCell12.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrTableCell12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 3, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseForeColor = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "Unit"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell12.Weight = 0.32661991395068346R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BackColor = System.Drawing.Color.White
        Me.XrTableCell13.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
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
        Me.XrTableCell13.Weight = 0.41747179386439282R
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.Color.Empty
        Me.txtUnitPrice.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
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
        Me.txtUnitPrice.Weight = 0.47601947142989209R
        '
        'txtVAT
        '
        Me.txtVAT.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtVAT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.TaxRate", "{0:0%}")})
        Me.txtVAT.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtVAT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.txtVAT.StylePriority.UseBorders = False
        Me.txtVAT.StylePriority.UseFont = False
        Me.txtVAT.StylePriority.UseForeColor = False
        Me.txtVAT.StylePriority.UsePadding = False
        Me.txtVAT.StylePriority.UseTextAlignment = False
        Me.txtVAT.Text = "txtVAT"
        Me.txtVAT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtVAT.Weight = 0.21639542441386869R
        '
        'txtAmtBeforeTax
        '
        Me.txtAmtBeforeTax.BackColor = System.Drawing.Color.Empty
        Me.txtAmtBeforeTax.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtAmtBeforeTax.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.LineTotalBeforeDiscount", "{0:n2}")})
        Me.txtAmtBeforeTax.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAmtBeforeTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmtBeforeTax.Multiline = True
        Me.txtAmtBeforeTax.Name = "txtAmtBeforeTax"
        Me.txtAmtBeforeTax.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.txtAmtBeforeTax.StylePriority.UseBackColor = False
        Me.txtAmtBeforeTax.StylePriority.UseBorders = False
        Me.txtAmtBeforeTax.StylePriority.UseFont = False
        Me.txtAmtBeforeTax.StylePriority.UseForeColor = False
        Me.txtAmtBeforeTax.StylePriority.UsePadding = False
        Me.txtAmtBeforeTax.StylePriority.UseTextAlignment = False
        Me.txtAmtBeforeTax.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Month"
        Me.txtAmtBeforeTax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtAmtBeforeTax.Weight = 0.65913438465363738R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 62.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 22.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.GroupHeader1.HeightF = 32.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.Color.Silver
        Me.XrTable1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(800.0!, 31.50002!)
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
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblSlNo, Me.XrTableCell2, Me.lblColumn1, Me.lblColumn2, Me.lblColumn3, Me.lblUnit, Me.lblQty, Me.txtUnitPriceText, Me.txtVATText, Me.lblVATAmount})
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
        Me.lblSlNo.Weight = 0.19064542829668674R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.LightBlue
        Me.XrTableCell2.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell2.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.StylePriority.UseBorderColor = False
        Me.XrTableCell2.StylePriority.UseForeColor = False
        Me.XrTableCell2.Text = "Description"
        Me.XrTableCell2.Weight = 1.5938028381251665R
        '
        'lblColumn1
        '
        Me.lblColumn1.BackColor = System.Drawing.Color.LightBlue
        Me.lblColumn1.BorderColor = System.Drawing.Color.DimGray
        Me.lblColumn1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblColumn1.ForeColor = System.Drawing.Color.Black
        Me.lblColumn1.Multiline = True
        Me.lblColumn1.Name = "lblColumn1"
        Me.lblColumn1.StylePriority.UseBackColor = False
        Me.lblColumn1.StylePriority.UseBorderColor = False
        Me.lblColumn1.StylePriority.UseBorders = False
        Me.lblColumn1.StylePriority.UseForeColor = False
        Me.lblColumn1.Weight = 1.6348030402196654R
        '
        'lblColumn2
        '
        Me.lblColumn2.BackColor = System.Drawing.Color.LightBlue
        Me.lblColumn2.BorderColor = System.Drawing.Color.DimGray
        Me.lblColumn2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblColumn2.ForeColor = System.Drawing.Color.Black
        Me.lblColumn2.Name = "lblColumn2"
        Me.lblColumn2.StylePriority.UseBackColor = False
        Me.lblColumn2.StylePriority.UseBorderColor = False
        Me.lblColumn2.StylePriority.UseBorders = False
        Me.lblColumn2.StylePriority.UseForeColor = False
        Me.lblColumn2.Weight = 0.013859155545944883R
        '
        'lblColumn3
        '
        Me.lblColumn3.BackColor = System.Drawing.Color.LightBlue
        Me.lblColumn3.BorderColor = System.Drawing.Color.DimGray
        Me.lblColumn3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblColumn3.ForeColor = System.Drawing.Color.Black
        Me.lblColumn3.Multiline = True
        Me.lblColumn3.Name = "lblColumn3"
        Me.lblColumn3.StylePriority.UseBackColor = False
        Me.lblColumn3.StylePriority.UseBorderColor = False
        Me.lblColumn3.StylePriority.UseBorders = False
        Me.lblColumn3.StylePriority.UseForeColor = False
        Me.lblColumn3.Weight = 0.014436479377738494R
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
        Me.lblUnit.Weight = 0.32669342032135085R
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
        Me.lblQty.Weight = 0.41756582444228063R
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
        Me.txtUnitPriceText.Weight = 0.47612723708219523R
        '
        'txtVATText
        '
        Me.txtVATText.BackColor = System.Drawing.Color.LightBlue
        Me.txtVATText.BorderColor = System.Drawing.Color.DimGray
        Me.txtVATText.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtVATText.ForeColor = System.Drawing.Color.Black
        Me.txtVATText.Multiline = True
        Me.txtVATText.Name = "txtVATText"
        Me.txtVATText.StylePriority.UseBackColor = False
        Me.txtVATText.StylePriority.UseBorderColor = False
        Me.txtVATText.StylePriority.UseBorders = False
        Me.txtVATText.StylePriority.UseForeColor = False
        Me.txtVATText.Text = "VAT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%"
        Me.txtVATText.Weight = 0.21659413642132763R
        '
        'lblVATAmount
        '
        Me.lblVATAmount.BackColor = System.Drawing.Color.LightBlue
        Me.lblVATAmount.BorderColor = System.Drawing.Color.DimGray
        Me.lblVATAmount.ForeColor = System.Drawing.Color.Black
        Me.lblVATAmount.Multiline = True
        Me.lblVATAmount.Name = "lblVATAmount"
        Me.lblVATAmount.StylePriority.UseBackColor = False
        Me.lblVATAmount.StylePriority.UseBorderColor = False
        Me.lblVATAmount.StylePriority.UseForeColor = False
        Me.lblVATAmount.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount"
        Me.lblVATAmount.Weight = 0.6591346585455975R
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0!
        Me.PageHeader.Name = "PageHeader"
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
        'calcPropertyDescription
        '
        Me.calcPropertyDescription.DataMember = "qry601_05QuotationReport"
        Me.calcPropertyDescription.Expression = "Iif(IsNullOrEmpty([AddlDescription]), [GSDescrpition]  , [AddlDescription] )"
        Me.calcPropertyDescription.Name = "calcPropertyDescription"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblQuotation, Me.XrLabel3, Me.txtVendorID, Me.XrLabel22, Me.XrLabel23, Me.lblQuotationNo, Me.XrLabel21, Me.txtReferenceNO, Me.XrTable6, Me.lblVendorID, Me.txtQuotationNo, Me.XrLabel17, Me.XrLabel30, Me.lineQuotation, Me.lblReferenceNo, Me.XrLabel31, Me.XrLabel1, Me.shapeClientDetails, Me.shapeClientDetails02})
        Me.ReportHeader.HeightF = 265.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'lblQuotation
        '
        Me.lblQuotation.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuotation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblQuotation.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 3.619798!)
        Me.lblQuotation.Name = "lblQuotation"
        Me.lblQuotation.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblQuotation.SizeF = New System.Drawing.SizeF(778.5002!, 33.45833!)
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
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(494.0687!, 71.97396!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(95.73615!, 20.0!)
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
        Me.txtVendorID.LocationFloat = New DevExpress.Utils.PointFloat(606.9291!, 117.4636!)
        Me.txtVendorID.Name = "txtVendorID"
        Me.txtVendorID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVendorID.SizeF = New System.Drawing.SizeF(178.0709!, 20.00002!)
        Me.txtVendorID.StylePriority.UseFont = False
        Me.txtVendorID.StylePriority.UseTextAlignment = False
        Me.txtVendorID.Text = "XrLabel16"
        Me.txtVendorID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ClientContactEmail", "Email:{0}")})
        Me.XrLabel22.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(45.41661!, 118.974!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(432.0119!, 21.0!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.Text = "Tel #: [BillingPhoneNo]  ,   Fax # : [BillingFaxNo]"
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel23.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(17.72213!, 46.97404!)
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
        Me.lblQuotationNo.LocationFloat = New DevExpress.Utils.PointFloat(494.0687!, 48.97391!)
        Me.lblQuotationNo.Name = "lblQuotationNo"
        Me.lblQuotationNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblQuotationNo.SizeF = New System.Drawing.SizeF(95.73615!, 21.0!)
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
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(590.8737!, 71.97396!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(194.1263!, 20.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "XrLabel16"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtReferenceNO
        '
        Me.txtReferenceNO.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ClientRefNo", "{0:dd-MMM-yy}")})
        Me.txtReferenceNO.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtReferenceNO.LocationFloat = New DevExpress.Utils.PointFloat(606.929!, 94.97398!)
        Me.txtReferenceNO.Name = "txtReferenceNO"
        Me.txtReferenceNO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReferenceNO.SizeF = New System.Drawing.SizeF(178.071!, 20.0!)
        Me.txtReferenceNO.StylePriority.UseFont = False
        Me.txtReferenceNO.StylePriority.UseTextAlignment = False
        Me.txtReferenceNO.Text = "XrLabel16"
        Me.txtReferenceNO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTable6
        '
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 151.974!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7, Me.XrTableRow8})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(777.5001!, 51.31252!)
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
        Me.lblVendorID.LocationFloat = New DevExpress.Utils.PointFloat(494.0686!, 117.4636!)
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
        Me.txtQuotationNo.LocationFloat = New DevExpress.Utils.PointFloat(591.8048!, 48.97391!)
        Me.txtQuotationNo.Name = "txtQuotationNo"
        Me.txtQuotationNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtQuotationNo.SizeF = New System.Drawing.SizeF(193.1952!, 21.0!)
        Me.txtQuotationNo.StylePriority.UseFont = False
        Me.txtQuotationNo.StylePriority.UseTextAlignment = False
        Me.txtQuotationNo.Text = "XrLabel6"
        Me.txtQuotationNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuoteIntro")})
        Me.XrLabel17.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 240.3073!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(777.5557!, 24.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UsePadding = False
        Me.XrLabel17.Text = "With reference to your enquiry, please find our competitive quotation as follows:" &
    ""
        '
        'XrLabel30
        '
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ClientName", "{0:dd-MMMM-yyyy}")})
        Me.XrLabel30.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(45.41661!, 46.97393!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(432.0119!, 25.0!)
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
        Me.lineQuotation.LocationFloat = New DevExpress.Utils.PointFloat(12.55573!, 38.07811!)
        Me.lineQuotation.Name = "lineQuotation"
        Me.lineQuotation.SizeF = New System.Drawing.SizeF(777.5!, 6.895798!)
        Me.lineQuotation.StylePriority.UseBorderDashStyle = False
        Me.lineQuotation.StylePriority.UseBorders = False
        Me.lineQuotation.StylePriority.UseBorderWidth = False
        Me.lineQuotation.StylePriority.UseForeColor = False
        '
        'lblReferenceNo
        '
        Me.lblReferenceNo.BackColor = System.Drawing.Color.Transparent
        Me.lblReferenceNo.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReferenceNo.LocationFloat = New DevExpress.Utils.PointFloat(494.0686!, 94.97401!)
        Me.lblReferenceNo.Name = "lblReferenceNo"
        Me.lblReferenceNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblReferenceNo.SizeF = New System.Drawing.SizeF(113.0!, 20.00001!)
        Me.lblReferenceNo.StylePriority.UseBackColor = False
        Me.lblReferenceNo.StylePriority.UseFont = False
        Me.lblReferenceNo.StylePriority.UseTextAlignment = False
        Me.lblReferenceNo.Text = "Reference No:"
        Me.lblReferenceNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel31
        '
        Me.XrLabel31.EditOptions.Enabled = True
        Me.XrLabel31.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 218.3073!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(188.7496!, 20.99998!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UsePadding = False
        Me.XrLabel31.Text = "Dear Sir,"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.ClientAddress")})
        Me.XrLabel1.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(45.41661!, 72.97394!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(432.0119!, 44.00007!)
        Me.XrLabel1.StylePriority.UseFont = False
        '
        'shapeClientDetails
        '
        Me.shapeClientDetails.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.shapeClientDetails.BorderWidth = 1.0!
        Me.shapeClientDetails.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 44.97393!)
        Me.shapeClientDetails.Name = "shapeClientDetails"
        ShapeRectangle1.Fillet = 10
        Me.shapeClientDetails.Shape = ShapeRectangle1
        Me.shapeClientDetails.SizeF = New System.Drawing.SizeF(472.4306!, 98.0!)
        Me.shapeClientDetails.StylePriority.UseBorderWidth = False
        '
        'shapeClientDetails02
        '
        Me.shapeClientDetails02.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.shapeClientDetails02.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "qry40104RptQuotation.ClientRefNo")})
        Me.shapeClientDetails02.LocationFloat = New DevExpress.Utils.PointFloat(490.4285!, 44.97395!)
        Me.shapeClientDetails02.Name = "shapeClientDetails02"
        ShapeRectangle2.Fillet = 10
        Me.shapeClientDetails02.Shape = ShapeRectangle2
        Me.shapeClientDetails02.SizeF = New System.Drawing.SizeF(299.6272!, 98.00001!)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak1, Me.XrSubreport1, Me.XrLabel7, Me.XrTable3})
        Me.GroupFooter1.HeightF = 178.9167!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 153.9167!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.CanShrink = True
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 157.9167!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New ERP.rpt40102QuotationTerms()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(778.5002!, 21.0!)
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuotationSummary")})
        Me.XrLabel7.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 124.9167!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(778.5002!, 24.0!)
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
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4, Me.rowAdditions, Me.rowDeductions, Me.XrTableRow5, Me.XrTableRow9})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(800.0!, 119.0!)
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
        Me.txtAmountInWords.Weight = 4.8022796318849785R
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
        Me.XrTableCell20.Text = "Total Amount "
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell20.Weight = 1.6977678915452195R
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
        Me.XrTableCell21.Weight = 0.156656069576307R
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
        Me.txtTotalBeforeDiscount.Weight = 1.0627854199831737R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell38, Me.XrTableCell1, Me.XrTableCell24, Me.txtVatAmount})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell38.StylePriority.UseFont = False
        Me.XrTableCell38.StylePriority.UsePadding = False
        Me.XrTableCell38.StylePriority.UseTextAlignment = False
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell38.Weight = 4.8022796318849768R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.EditOptions.Enabled = True
        Me.XrTableCell1.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "(+ Add) VAT Amount"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell1.Weight = 1.6977669794682819R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        Me.XrTableCell24.Text = ":"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell24.Weight = 0.15665727612838121R
        '
        'txtVatAmount
        '
        Me.txtVatAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtVatAmount.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.txtVatAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.TotalTaxAmount", "{0:n2}")})
        Me.txtVatAmount.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtVatAmount.Name = "txtVatAmount"
        Me.txtVatAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtVatAmount.StylePriority.UseBorderColor = False
        Me.txtVatAmount.StylePriority.UseBorders = False
        Me.txtVatAmount.StylePriority.UseFont = False
        Me.txtVatAmount.StylePriority.UsePadding = False
        Me.txtVatAmount.StylePriority.UseTextAlignment = False
        Me.txtVatAmount.Text = "XrTableCell20"
        Me.txtVatAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtVatAmount.Weight = 1.0627851255080374R
        '
        'rowAdditions
        '
        Me.rowAdditions.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell39, Me.XrTableCell26, Me.XrTableCell27, Me.txtAdditionAmount})
        Me.rowAdditions.Name = "rowAdditions"
        Me.rowAdditions.Weight = 1.0R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell39.StylePriority.UseFont = False
        Me.XrTableCell39.StylePriority.UsePadding = False
        Me.XrTableCell39.StylePriority.UseTextAlignment = False
        Me.XrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell39.Weight = 4.8022796318849785R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.AdditionsText")})
        Me.XrTableCell26.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UsePadding = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.Text = "XrTableCell21"
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell26.Weight = 1.6977678915452195R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.Text = ":"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell27.Weight = 0.156656069576307R
        '
        'txtAdditionAmount
        '
        Me.txtAdditionAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtAdditionAmount.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.txtAdditionAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuoteTransport", "{0:n2}")})
        Me.txtAdditionAmount.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtAdditionAmount.Name = "txtAdditionAmount"
        Me.txtAdditionAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtAdditionAmount.StylePriority.UseBorderColor = False
        Me.txtAdditionAmount.StylePriority.UseBorders = False
        Me.txtAdditionAmount.StylePriority.UseFont = False
        Me.txtAdditionAmount.StylePriority.UsePadding = False
        Me.txtAdditionAmount.StylePriority.UseTextAlignment = False
        Me.txtAdditionAmount.Text = "XrTableCell23"
        Me.txtAdditionAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtAdditionAmount.Weight = 1.0627854199831737R
        '
        'rowDeductions
        '
        Me.rowDeductions.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell40, Me.XrTableCell29, Me.XrTableCell30, Me.txtDeductionAmount})
        Me.rowDeductions.Name = "rowDeductions"
        Me.rowDeductions.Weight = 1.0R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell40.StylePriority.UseFont = False
        Me.XrTableCell40.StylePriority.UsePadding = False
        Me.XrTableCell40.StylePriority.UseTextAlignment = False
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell40.Weight = 4.8022796318849785R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.DiscountsText")})
        Me.XrTableCell29.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UsePadding = False
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        Me.XrTableCell29.Text = "XrTableCell24"
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell29.Weight = 1.6977678915452195R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.Text = ":"
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell30.Weight = 0.156656069576307R
        '
        'txtDeductionAmount
        '
        Me.txtDeductionAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtDeductionAmount.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.txtDeductionAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuoteDiscount", "{0:n2}")})
        Me.txtDeductionAmount.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtDeductionAmount.Name = "txtDeductionAmount"
        Me.txtDeductionAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtDeductionAmount.StylePriority.UseBorderColor = False
        Me.txtDeductionAmount.StylePriority.UseBorders = False
        Me.txtDeductionAmount.StylePriority.UseFont = False
        Me.txtDeductionAmount.StylePriority.UsePadding = False
        Me.txtDeductionAmount.StylePriority.UseTextAlignment = False
        Me.txtDeductionAmount.Text = "XrTableCell26"
        Me.txtDeductionAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtDeductionAmount.Weight = 1.0627854199831737R
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
        Me.XrTableCell41.Weight = 4.8022796318849785R
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
        Me.rowDiscounts.Weight = 1.6977678915452195R
        '
        'rowDiscountsColon
        '
        Me.rowDiscountsColon.Name = "rowDiscountsColon"
        Me.rowDiscountsColon.StylePriority.UseTextAlignment = False
        Me.rowDiscountsColon.Text = ":"
        Me.rowDiscountsColon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.rowDiscountsColon.Weight = 0.156656069576307R
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
        Me.txtDiscountAmount.Weight = 1.0627854199831737R
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
        Me.lblNetAmountText.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
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
        Me.lblNetAmountText.Text = "Net Amount"
        Me.lblNetAmountText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblNetAmountText.Weight = 6.5000476706677652R
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
        Me.lblColon.Weight = 0.15686338007226136R
        '
        'txtNetAmountSales
        '
        Me.txtNetAmountSales.BackColor = System.Drawing.Color.LightBlue
        Me.txtNetAmountSales.BorderColor = System.Drawing.Color.DimGray
        Me.txtNetAmountSales.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtNetAmountSales.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.FinalTotal", "{0:n2}")})
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
        Me.txtNetAmountSales.Weight = 1.0625779622496514R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panelPreparedBy, Me.panelVerifiedBy, Me.panelApprovedBy, Me.txtVerifiedSignature, Me.txtApprovedBySignature, Me.XrLabel2, Me.XrPageBreak2, Me.panelAcceptance, Me.txtSignatureImage, Me.txtCompanySeal})
        Me.ReportFooter.HeightF = 313.0832!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'panelPreparedBy
        '
        Me.panelPreparedBy.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPreparedName, Me.lblPreparedPosition, Me.lblPreparedContactNo, Me.lblPreparedEmail, Me.lblPreparedBy})
        Me.panelPreparedBy.LocationFloat = New DevExpress.Utils.PointFloat(13.56189!, 63.5833!)
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
        Me.panelVerifiedBy.LocationFloat = New DevExpress.Utils.PointFloat(261.6869!, 63.5833!)
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
        Me.panelApprovedBy.LocationFloat = New DevExpress.Utils.PointFloat(512.8751!, 64.5833!)
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
        'txtVerifiedSignature
        '
        Me.txtVerifiedSignature.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry601_05QuotationReport.VerifiedBySignatoryImage")})
        Me.txtVerifiedSignature.LocationFloat = New DevExpress.Utils.PointFloat(252.584!, 10.0!)
        Me.txtVerifiedSignature.Name = "txtVerifiedSignature"
        Me.txtVerifiedSignature.SizeF = New System.Drawing.SizeF(294.8833!, 110.5833!)
        Me.txtVerifiedSignature.Visible = False
        '
        'txtApprovedBySignature
        '
        Me.txtApprovedBySignature.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry601_05QuotationReport.ApprovedBySignatoryImage")})
        Me.txtApprovedBySignature.LocationFloat = New DevExpress.Utils.PointFloat(522.8751!, 10.0!)
        Me.txtApprovedBySignature.Name = "txtApprovedBySignature"
        Me.txtApprovedBySignature.SizeF = New System.Drawing.SizeF(242.4793!, 110.5833!)
        Me.txtApprovedBySignature.Visible = False
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry601_05QuotationReport.QuoteThanksNote")})
        Me.XrLabel2.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(13.71509!, 5.0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(776.3406!, 41.29166!)
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
        'panelAcceptance
        '
        Me.panelAcceptance.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel34, Me.XrLabel33, Me.XrLabel25, Me.XrLabel32, Me.XrLabel15, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLabel13, Me.XrLabel18, Me.XrLabel24, Me.XrLabel27})
        Me.panelAcceptance.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 174.9166!)
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
        Me.XrLabel13.Text = "Quotation Acceptance by Client:"
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
        'txtSignatureImage
        '
        Me.txtSignatureImage.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry601_05QuotationReport.SignatureImage")})
        Me.txtSignatureImage.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 10.0!)
        Me.txtSignatureImage.Name = "txtSignatureImage"
        Me.txtSignatureImage.SizeF = New System.Drawing.SizeF(294.8833!, 110.5833!)
        '
        'txtCompanySeal
        '
        Me.txtCompanySeal.LocationFloat = New DevExpress.Utils.PointFloat(231.0987!, 0!)
        Me.txtCompanySeal.Name = "txtCompanySeal"
        Me.txtCompanySeal.SizeF = New System.Drawing.SizeF(302.0834!, 156.0!)
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox1.BorderWidth = 1.0!
        Me.XrCrossBandBox1.EndBand = Me.GroupFooter1
        Me.XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 2.0!)
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandBox1.WidthF = 800.0001!
        '
        'XrCrossBandLine1
        '
        Me.XrCrossBandLine1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine1.EndBand = Nothing
        Me.XrCrossBandLine1.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandLine1.Name = "XrCrossBandLine1"
        Me.XrCrossBandLine1.StartBand = Nothing
        Me.XrCrossBandLine1.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandLine1.WidthF = 1.041667!
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine2.EndBand = Nothing
        Me.XrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Nothing
        Me.XrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandLine2.WidthF = 9.375!
        '
        'LineColumns2
        '
        Me.LineColumns2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.LineColumns2.EndBand = Me.GroupFooter1
        Me.LineColumns2.EndPointFloat = New DevExpress.Utils.PointFloat(376.0417!, 2.0!)
        Me.LineColumns2.ForeColor = System.Drawing.Color.DimGray
        Me.LineColumns2.Name = "LineColumns2"
        Me.LineColumns2.StartBand = Me.GroupHeader1
        Me.LineColumns2.StartPointFloat = New DevExpress.Utils.PointFloat(376.0417!, 0!)
        Me.LineColumns2.WidthF = 1.0!
        '
        'LineColumns1b
        '
        Me.LineColumns1b.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.LineColumns1b.EndBand = Me.GroupFooter1
        Me.LineColumns1b.EndPointFloat = New DevExpress.Utils.PointFloat(417.5!, 2.0!)
        Me.LineColumns1b.ForeColor = System.Drawing.Color.DimGray
        Me.LineColumns1b.Name = "LineColumns1b"
        Me.LineColumns1b.StartBand = Me.GroupHeader1
        Me.LineColumns1b.StartPointFloat = New DevExpress.Utils.PointFloat(417.5!, 0!)
        Me.LineColumns1b.WidthF = 1.041656!
        '
        'LineColumns1a
        '
        Me.LineColumns1a.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.LineColumns1a.EndBand = Me.GroupFooter1
        Me.LineColumns1a.EndPointFloat = New DevExpress.Utils.PointFloat(337.375!, 2.0!)
        Me.LineColumns1a.ForeColor = System.Drawing.Color.DimGray
        Me.LineColumns1a.Name = "LineColumns1a"
        Me.LineColumns1a.StartBand = Me.GroupHeader1
        Me.LineColumns1a.StartPointFloat = New DevExpress.Utils.PointFloat(337.375!, 1.041667!)
        Me.LineColumns1a.WidthF = 1.041656!
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
        Me.txtUserPrinting.LocationFloat = New DevExpress.Utils.PointFloat(498.0686!, 0!)
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
        Me.txtPageNumber.LocationFloat = New DevExpress.Utils.PointFloat(337.375!, 0!)
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
        Me.txtSystemTitle.LocationFloat = New DevExpress.Utils.PointFloat(11.9028!, 0!)
        Me.txtSystemTitle.Name = "txtSystemTitle"
        Me.txtSystemTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSystemTitle.SizeF = New System.Drawing.SizeF(277.9597!, 18.0!)
        Me.txtSystemTitle.StylePriority.UseBorderColor = False
        Me.txtSystemTitle.StylePriority.UseFont = False
        Me.txtSystemTitle.StylePriority.UseForeColor = False
        Me.txtSystemTitle.StylePriority.UseTextAlignment = False
        Me.txtSystemTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.calcPropertyDescWithPartNo.Expression = "Iif(IsNullOrEmpty([AddlDescription]), Concat([ItemPartNo], ' - ', [GSDescrpition]" &
    "),  Concat([ItemPartNo], ' - ', [AddlDescription]) )"
        Me.calcPropertyDescWithPartNo.Name = "calcPropertyDescWithPartNo"
        '
        'rpt601_01CustomQuotationFormat1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.PageHeader, Me.ReportHeader, Me.GroupFooter1, Me.ReportFooter, Me.PageFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calcPropertyDescription, Me.calcPropertyDescWithCode, Me.calcPropertyDescWithPartNo})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.LineColumns1a, Me.LineColumns1b, Me.LineColumns2, Me.XrCrossBandLine2, Me.XrCrossBandLine1, Me.XrCrossBandBox1})
        Me.DataAdapter = Me.Qry601_05QuotationReportTableAdapter
        Me.DataMember = "qry601_05QuotationReport"
        Me.DataSource = Me.DsRpt601_01QuotationReport1
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 62, 22)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "21.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRpt601_01QuotationReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents DsRpt601_01QuotationReport1 As ERP.dsRpt601_01QuotationReport
    Friend WithEvents Qry601_05QuotationReportTableAdapter As ERP.dsRpt601_01QuotationReportTableAdapters.qry601_05QuotationReportTableAdapter
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblSlNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblColumn3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblUnit As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtUnitPriceText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtVATText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblVATAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtRecordNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtColumn3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtUnitPrice As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtVAT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtAmtBeforeTax As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtItemDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtColumn1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtColumn2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblColumn1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblColumn2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents calcPropertyDescription As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents shapeClientDetails02 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents shapeClientDetails As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents lblQuotation As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtVendorID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtAmountInWords As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTotalBeforeDiscount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtVatAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rowAdditions As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtAdditionAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rowDeductions As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtDeductionAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rowDiscounts As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rowDiscountsColon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtDiscountAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNetAmountText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblColon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtNetAmountSales As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageBreak2 As DevExpress.XtraReports.UI.XRPageBreak
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
    Friend WithEvents txtSignatureImage As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtCompanySeal As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents LineColumns2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents LineColumns1b As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents LineColumns1a As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents txtUserPrinting As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPageNumber As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents txtSystemTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents calcPropertyDescWithCode As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents calcPropertyDescWithPartNo As DevExpress.XtraReports.UI.CalculatedField
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
    Friend WithEvents txtVerifiedSignature As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtApprovedBySignature As DevExpress.XtraReports.UI.XRPictureBox
End Class
