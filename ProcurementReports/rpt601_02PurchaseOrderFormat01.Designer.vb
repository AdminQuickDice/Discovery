<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt601_02PurchaseOrderFormat01
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
        Me.txtItemCode = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtStockDescription = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtDiscount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtLineAmtBeforeTax = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtVATAmount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblPO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtReferenceNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVATNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblReferenceNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.lblVATNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape2 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblSlNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblItemCode = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDescription = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblUnit = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtUnitPriceText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellDiscountText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtVATText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtAmtBeforeTaxText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblVATAmount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.DsRpt601_02PurchaseOrderReport1 = New ERP.dsRpt601_02PurchaseOrderReport()
        Me.Qry604_05PurchaseOrderReportTableAdapter = New ERP.dsRpt601_02PurchaseOrderReportTableAdapters.qry604_05PurchaseOrderReportTableAdapter()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.panelAcceptance02 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtApprovedBySignature = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtSignatureImage = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtVerifiedSignature = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtCompanySeal = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.panelAcceptance = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtThanks = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageBreak2 = New DevExpress.XtraReports.UI.XRPageBreak()
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
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.txtSystemTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPageNumber = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.txtUserPrinting = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtAmountInWords = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtTotalBeforeDiscount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtDiscountAmount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtTotalAfterDiscount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtTotalVatAmount = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNetAmountText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblColon = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtNetAmountSales = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrCrossBandBox4 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox2 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox3 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox5 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.calcGSDescription = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandBox6 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.calcPONo = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Qry601_05QuotationReportTableAdapter = New ERP.dsRpt601_01QuotationReportTableAdapters.qry601_05QuotationReportTableAdapter()
        Me.GroupFooter3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.tableBillToShipTo = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableTerms = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtTotalTaxAmount = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRpt601_02PurchaseOrderReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tableBillToShipTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tableTerms, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XrTable2.SizeF = New System.Drawing.SizeF(754.5001!, 30.0!)
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.BorderColor = System.Drawing.Color.Gray
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtRecordNo, Me.txtItemCode, Me.txtStockDescription, Me.XrTableCell12, Me.XrTableCell13, Me.txtUnitPrice, Me.txtDiscount, Me.XrTableCell16, Me.txtLineAmtBeforeTax, Me.txtVATAmount})
        Me.XrTableRow2.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.0!)
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.StylePriority.UseBorderColor = False
        Me.XrTableRow2.StylePriority.UseFont = False
        Me.XrTableRow2.Weight = 1.0R
        '
        'txtRecordNo
        '
        Me.txtRecordNo.BackColor = System.Drawing.Color.Transparent
        Me.txtRecordNo.BorderColor = System.Drawing.Color.DimGray
        Me.txtRecordNo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtRecordNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.GSCode")})
        Me.txtRecordNo.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtRecordNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRecordNo.Multiline = True
        Me.txtRecordNo.Name = "txtRecordNo"
        Me.txtRecordNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 3, 0, 100.0!)
        Me.txtRecordNo.StylePriority.UseBackColor = False
        Me.txtRecordNo.StylePriority.UseBorderColor = False
        Me.txtRecordNo.StylePriority.UseBorders = False
        Me.txtRecordNo.StylePriority.UseFont = False
        Me.txtRecordNo.StylePriority.UseForeColor = False
        Me.txtRecordNo.StylePriority.UsePadding = False
        Me.txtRecordNo.StylePriority.UseTextAlignment = False
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.txtRecordNo.Summary = XrSummary1
        Me.txtRecordNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtRecordNo.Weight = 0.25050878864166232R
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.Transparent
        Me.txtItemCode.BorderColor = System.Drawing.Color.DimGray
        Me.txtItemCode.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtItemCode.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.GSCode")})
        Me.txtItemCode.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 3, 0, 100.0!)
        Me.txtItemCode.StylePriority.UseBackColor = False
        Me.txtItemCode.StylePriority.UseBorderColor = False
        Me.txtItemCode.StylePriority.UseBorders = False
        Me.txtItemCode.StylePriority.UseFont = False
        Me.txtItemCode.StylePriority.UsePadding = False
        Me.txtItemCode.StylePriority.UseTextAlignment = False
        Me.txtItemCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtItemCode.Weight = 0.66460970375218487R
        '
        'txtStockDescription
        '
        Me.txtStockDescription.BackColor = System.Drawing.Color.Transparent
        Me.txtStockDescription.BorderColor = System.Drawing.Color.DimGray
        Me.txtStockDescription.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtStockDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.calcGSDescription")})
        Me.txtStockDescription.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtStockDescription.Multiline = True
        Me.txtStockDescription.Name = "txtStockDescription"
        Me.txtStockDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 3, 0, 100.0!)
        Me.txtStockDescription.StylePriority.UseBackColor = False
        Me.txtStockDescription.StylePriority.UseBorderColor = False
        Me.txtStockDescription.StylePriority.UseBorders = False
        Me.txtStockDescription.StylePriority.UseFont = False
        Me.txtStockDescription.StylePriority.UseForeColor = False
        Me.txtStockDescription.StylePriority.UsePadding = False
        Me.txtStockDescription.StylePriority.UseTextAlignment = False
        Me.txtStockDescription.Text = "Material Description"
        Me.txtStockDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtStockDescription.Weight = 1.6958281208871866R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell12.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.UnitDesc")})
        Me.XrTableCell12.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 3, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseBackColor = False
        Me.XrTableCell12.StylePriority.UseBorderColor = False
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseForeColor = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "Unit"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell12.Weight = 0.50371232191328152R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell13.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell13.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.QuotedQuantity", "{0:#,#.####}")})
        Me.XrTableCell13.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.XrTableCell13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 3, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UseBackColor = False
        Me.XrTableCell13.StylePriority.UseBorderColor = False
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseForeColor = False
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "Qty"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell13.Weight = 0.5044849331710014R
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtUnitPrice.BorderColor = System.Drawing.Color.DimGray
        Me.txtUnitPrice.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.UnitPrice")})
        Me.txtUnitPrice.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtUnitPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.txtUnitPrice.StylePriority.UseBackColor = False
        Me.txtUnitPrice.StylePriority.UseBorderColor = False
        Me.txtUnitPrice.StylePriority.UseBorders = False
        Me.txtUnitPrice.StylePriority.UseFont = False
        Me.txtUnitPrice.StylePriority.UseForeColor = False
        Me.txtUnitPrice.StylePriority.UsePadding = False
        Me.txtUnitPrice.StylePriority.UseTextAlignment = False
        Me.txtUnitPrice.Text = "UnitPrice"
        Me.txtUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtUnitPrice.TextFormatString = "{0:########0.00##}"
        Me.txtUnitPrice.Weight = 0.55311302807369311R
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.Transparent
        Me.txtDiscount.BorderColor = System.Drawing.Color.DimGray
        Me.txtDiscount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.ItemDiscount", "{0:n2}")})
        Me.txtDiscount.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.txtDiscount.StylePriority.UseBackColor = False
        Me.txtDiscount.StylePriority.UseBorderColor = False
        Me.txtDiscount.StylePriority.UseBorders = False
        Me.txtDiscount.StylePriority.UseFont = False
        Me.txtDiscount.StylePriority.UseForeColor = False
        Me.txtDiscount.StylePriority.UsePadding = False
        Me.txtDiscount.StylePriority.UseTextAlignment = False
        Me.txtDiscount.Text = "txtDiscount"
        Me.txtDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtDiscount.Weight = 0.71981150811077432R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell16.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell16.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.PurchaseTaxRate", "{0:0%}")})
        Me.XrTableCell16.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.XrTableCell16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.XrTableCell16.StylePriority.UseBackColor = False
        Me.XrTableCell16.StylePriority.UseBorderColor = False
        Me.XrTableCell16.StylePriority.UseBorders = False
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UseForeColor = False
        Me.XrTableCell16.StylePriority.UsePadding = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.Text = "XrTableCell16"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell16.Weight = 0.305285287235294R
        '
        'txtLineAmtBeforeTax
        '
        Me.txtLineAmtBeforeTax.BackColor = System.Drawing.Color.Transparent
        Me.txtLineAmtBeforeTax.BorderColor = System.Drawing.Color.DimGray
        Me.txtLineAmtBeforeTax.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtLineAmtBeforeTax.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.LineTotalAfterDisc", "{0:n2}")})
        Me.txtLineAmtBeforeTax.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtLineAmtBeforeTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLineAmtBeforeTax.Name = "txtLineAmtBeforeTax"
        Me.txtLineAmtBeforeTax.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.txtLineAmtBeforeTax.StylePriority.UseBackColor = False
        Me.txtLineAmtBeforeTax.StylePriority.UseBorderColor = False
        Me.txtLineAmtBeforeTax.StylePriority.UseBorders = False
        Me.txtLineAmtBeforeTax.StylePriority.UseFont = False
        Me.txtLineAmtBeforeTax.StylePriority.UseForeColor = False
        Me.txtLineAmtBeforeTax.StylePriority.UsePadding = False
        Me.txtLineAmtBeforeTax.StylePriority.UseTextAlignment = False
        Me.txtLineAmtBeforeTax.Text = "txtLineAmtBeforeTax"
        Me.txtLineAmtBeforeTax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtLineAmtBeforeTax.Weight = 0.87153160290939125R
        '
        'txtVATAmount
        '
        Me.txtVATAmount.BackColor = System.Drawing.Color.Transparent
        Me.txtVATAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtVATAmount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtVATAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.LineTaxAmount", "{0:n2}")})
        Me.txtVATAmount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtVATAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVATAmount.Multiline = True
        Me.txtVATAmount.Name = "txtVATAmount"
        Me.txtVATAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.txtVATAmount.StylePriority.UseBackColor = False
        Me.txtVATAmount.StylePriority.UseBorderColor = False
        Me.txtVATAmount.StylePriority.UseBorders = False
        Me.txtVATAmount.StylePriority.UseFont = False
        Me.txtVATAmount.StylePriority.UseForeColor = False
        Me.txtVATAmount.StylePriority.UsePadding = False
        Me.txtVATAmount.StylePriority.UseTextAlignment = False
        Me.txtVATAmount.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Month"
        Me.txtVATAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtVATAmount.Weight = 0.65913438465363738R
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
        Me.BottomMargin.HeightF = 38.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPO, Me.XrLabel3, Me.txtReferenceNo, Me.XrLabel22, Me.XrLabel23, Me.XrLabel20, Me.XrLabel21, Me.txtVATNo, Me.XrLabel24, Me.XrTable6, Me.lblReferenceNo, Me.XrLabel19, Me.XrLabel17, Me.XrLabel30, Me.XrLine2, Me.lblVATNumber, Me.XrLabel31, Me.XrShape2, Me.XrShape1})
        Me.ReportHeader.HeightF = 277.6875!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'lblPO
        '
        Me.lblPO.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblPO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPO.LocationFloat = New DevExpress.Utils.PointFloat(18.77748!, 0!)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPO.SizeF = New System.Drawing.SizeF(748.2228!, 29.45833!)
        Me.lblPO.StylePriority.UseFont = False
        Me.lblPO.StylePriority.UseForeColor = False
        Me.lblPO.StylePriority.UseTextAlignment = False
        Me.lblPO.Text = "P U R C H A S E    O R D E R"
        Me.lblPO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.EditOptions.Enabled = True
        Me.XrLabel3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(495.9828!, 64.35416!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(67.48944!, 20.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "P.O. Date:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.Project", "{0:dd-MMM-yy}")})
        Me.txtReferenceNo.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtReferenceNo.LocationFloat = New DevExpress.Utils.PointFloat(566.4724!, 109.8438!)
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReferenceNo.SizeF = New System.Drawing.SizeF(192.8743!, 20.00002!)
        Me.txtReferenceNo.StylePriority.UseFont = False
        Me.txtReferenceNo.StylePriority.UseTextAlignment = False
        Me.txtReferenceNo.Text = "XrLabel16"
        Me.txtReferenceNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SupplierContactEmail", "Email:{0}")})
        Me.XrLabel22.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(49.47237!, 108.3542!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(430.9167!, 21.0!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.Text = "Tel #: [BillingPhoneNo]  ,   Fax # : [BillingFaxNo]"
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel23.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(19.77785!, 39.35425!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(27.69448!, 25.0!)
        Me.XrLabel23.StylePriority.UseBackColor = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "To:"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel20.EditOptions.Enabled = True
        Me.XrLabel20.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(495.9828!, 41.35411!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(67.48944!, 21.0!)
        Me.XrLabel20.StylePriority.UseBackColor = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "P.O. No:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.PODate", "{0:dd-MMM-yyyy}")})
        Me.XrLabel21.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(566.4724!, 64.35416!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(192.8743!, 20.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "XrLabel16"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtVATNo
        '
        Me.txtVATNo.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtVATNo.LocationFloat = New DevExpress.Utils.PointFloat(566.4724!, 87.35419!)
        Me.txtVATNo.Name = "txtVATNo"
        Me.txtVATNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVATNo.SizeF = New System.Drawing.SizeF(192.8743!, 20.0!)
        Me.txtVATNo.StylePriority.UseFont = False
        Me.txtVATNo.StylePriority.UseTextAlignment = False
        Me.txtVATNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel24
        '
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SupplierAddress")})
        Me.XrLabel24.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(49.47237!, 66.3541!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(430.9167!, 40.0!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "XrLabel10"
        '
        'XrTable6
        '
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(16.77753!, 139.6979!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7, Me.XrTableRow6, Me.XrTableRow8})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(750.1669!, 78.96878!)
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
        Me.XrTableCell8.EditOptions.Enabled = True
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
        Me.XrTableCell8.Weight = 0.41563528688504736R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.BorderColor = System.Drawing.Color.Gray
        Me.XrTableCell44.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell44.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.Attention")})
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
        Me.XrTableCell44.Weight = 3.6063142555592975R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell34, Me.XrTableCell45})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0779536860053871R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell34.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.[Double]
        Me.XrTableCell34.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell34.BorderWidth = 3.0!
        Me.XrTableCell34.EditOptions.Enabled = True
        Me.XrTableCell34.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell34.StylePriority.UseBorderColor = False
        Me.XrTableCell34.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell34.StylePriority.UseBorders = False
        Me.XrTableCell34.StylePriority.UseBorderWidth = False
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.StylePriority.UsePadding = False
        Me.XrTableCell34.StylePriority.UseTextAlignment = False
        Me.XrTableCell34.Text = "Reference:"
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell34.Weight = 0.41563524662671369R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell45.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell45.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell45.BorderWidth = 3.0!
        Me.XrTableCell45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SupplierQuoteNo")})
        Me.XrTableCell45.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell45.StylePriority.UseBorderColor = False
        Me.XrTableCell45.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell45.StylePriority.UseBorders = False
        Me.XrTableCell45.StylePriority.UseBorderWidth = False
        Me.XrTableCell45.StylePriority.UseFont = False
        Me.XrTableCell45.StylePriority.UsePadding = False
        Me.XrTableCell45.StylePriority.UseTextAlignment = False
        Me.XrTableCell45.Text = "XrTableCell45"
        Me.XrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell45.Weight = 3.6063142958176306R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell35, Me.XrTableCell43})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0779536860053871R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell35.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.[Double]
        Me.XrTableCell35.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell35.BorderWidth = 3.0!
        Me.XrTableCell35.EditOptions.Enabled = True
        Me.XrTableCell35.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell35.StylePriority.UseBorderColor = False
        Me.XrTableCell35.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell35.StylePriority.UseBorders = False
        Me.XrTableCell35.StylePriority.UseBorderWidth = False
        Me.XrTableCell35.StylePriority.UseFont = False
        Me.XrTableCell35.StylePriority.UsePadding = False
        Me.XrTableCell35.StylePriority.UseTextAlignment = False
        Me.XrTableCell35.Text = "Subject :"
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell35.Weight = 0.41563524662671369R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell43.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.[Double]
        Me.XrTableCell43.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell43.BorderWidth = 3.0!
        Me.XrTableCell43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SubjectTitle")})
        Me.XrTableCell43.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell43.StylePriority.UseBorderColor = False
        Me.XrTableCell43.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell43.StylePriority.UseBorders = False
        Me.XrTableCell43.StylePriority.UseBorderWidth = False
        Me.XrTableCell43.StylePriority.UseFont = False
        Me.XrTableCell43.StylePriority.UsePadding = False
        Me.XrTableCell43.StylePriority.UseTextAlignment = False
        Me.XrTableCell43.Text = "XrTableCell43"
        Me.XrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell43.Weight = 3.6063142958176306R
        '
        'lblReferenceNo
        '
        Me.lblReferenceNo.BackColor = System.Drawing.Color.Transparent
        Me.lblReferenceNo.EditOptions.Enabled = True
        Me.lblReferenceNo.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReferenceNo.LocationFloat = New DevExpress.Utils.PointFloat(495.9828!, 109.8438!)
        Me.lblReferenceNo.Name = "lblReferenceNo"
        Me.lblReferenceNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblReferenceNo.SizeF = New System.Drawing.SizeF(67.48944!, 20.0!)
        Me.lblReferenceNo.StylePriority.UseBackColor = False
        Me.lblReferenceNo.StylePriority.UseFont = False
        Me.lblReferenceNo.StylePriority.UseTextAlignment = False
        Me.lblReferenceNo.Text = "Project:"
        Me.lblReferenceNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.calcPONo")})
        Me.XrLabel19.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(566.4724!, 41.35411!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(192.8743!, 21.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "XrLabel6"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POIntroduction")})
        Me.XrLabel17.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(16.77754!, 253.6875!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(750.2227!, 24.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UsePadding = False
        Me.XrLabel17.Text = "With reference to your enquiry, please find our competitive quotation as follows:" &
    ""
        '
        'XrLabel30
        '
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SupplierName", "{0:dd-MMMM-yyyy}")})
        Me.XrLabel30.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(49.47237!, 39.35413!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(430.9167!, 26.0!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "XrLabel9"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine2.BorderWidth = 5.0!
        Me.XrLine2.ForeColor = System.Drawing.Color.DarkBlue
        Me.XrLine2.LineWidth = 2.0!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(16.77754!, 30.45832!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(750.2227!, 6.895796!)
        Me.XrLine2.StylePriority.UseBorderDashStyle = False
        Me.XrLine2.StylePriority.UseBorders = False
        Me.XrLine2.StylePriority.UseBorderWidth = False
        Me.XrLine2.StylePriority.UseForeColor = False
        '
        'lblVATNumber
        '
        Me.lblVATNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblVATNumber.EditOptions.Enabled = True
        Me.lblVATNumber.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblVATNumber.LocationFloat = New DevExpress.Utils.PointFloat(495.9828!, 87.35419!)
        Me.lblVATNumber.Name = "lblVATNumber"
        Me.lblVATNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblVATNumber.SizeF = New System.Drawing.SizeF(67.48944!, 20.00001!)
        Me.lblVATNumber.StylePriority.UseBackColor = False
        Me.lblVATNumber.StylePriority.UseFont = False
        Me.lblVATNumber.StylePriority.UseTextAlignment = False
        Me.lblVATNumber.Text = "VAT No:"
        Me.lblVATNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(16.77754!, 227.6875!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(118.2298!, 21.00002!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UsePadding = False
        Me.XrLabel31.Text = "Dear Sir,"
        '
        'XrShape2
        '
        Me.XrShape2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrShape2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "qry40104RptQuotation.ClientRefNo")})
        Me.XrShape2.LocationFloat = New DevExpress.Utils.PointFloat(492.6465!, 37.35413!)
        Me.XrShape2.Name = "XrShape2"
        ShapeRectangle1.Fillet = 5
        Me.XrShape2.Shape = ShapeRectangle1
        Me.XrShape2.SizeF = New System.Drawing.SizeF(273.312!, 97.99999!)
        '
        'XrShape1
        '
        Me.XrShape1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrShape1.BorderWidth = 1.0!
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(16.77754!, 37.35413!)
        Me.XrShape1.Name = "XrShape1"
        ShapeRectangle2.Fillet = 5
        Me.XrShape1.Shape = ShapeRectangle2
        Me.XrShape1.SizeF = New System.Drawing.SizeF(471.6531!, 99.0!)
        Me.XrShape1.StylePriority.UseBorderWidth = False
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
        Me.XrTableRow1.BorderColor = System.Drawing.Color.Gray
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblSlNo, Me.lblItemCode, Me.lblDescription, Me.lblUnit, Me.lblQty, Me.txtUnitPriceText, Me.cellDiscountText, Me.txtVATText, Me.txtAmtBeforeTaxText, Me.lblVATAmount})
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
        Me.lblSlNo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblSlNo.EditOptions.Enabled = True
        Me.lblSlNo.ForeColor = System.Drawing.Color.Black
        Me.lblSlNo.Multiline = True
        Me.lblSlNo.Name = "lblSlNo"
        Me.lblSlNo.StylePriority.UseBackColor = False
        Me.lblSlNo.StylePriority.UseBorderColor = False
        Me.lblSlNo.StylePriority.UseBorders = False
        Me.lblSlNo.StylePriority.UseForeColor = False
        Me.lblSlNo.Text = "#"
        Me.lblSlNo.Weight = 0.25942600396046855R
        '
        'lblItemCode
        '
        Me.lblItemCode.BackColor = System.Drawing.Color.LightBlue
        Me.lblItemCode.BorderColor = System.Drawing.Color.DimGray
        Me.lblItemCode.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblItemCode.EditOptions.Enabled = True
        Me.lblItemCode.ForeColor = System.Drawing.Color.Black
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.StylePriority.UseBackColor = False
        Me.lblItemCode.StylePriority.UseBorderColor = False
        Me.lblItemCode.StylePriority.UseBorders = False
        Me.lblItemCode.StylePriority.UseForeColor = False
        Me.lblItemCode.Text = "Item Code"
        Me.lblItemCode.Weight = 0.63785822217281951R
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.LightBlue
        Me.lblDescription.BorderColor = System.Drawing.Color.DimGray
        Me.lblDescription.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDescription.EditOptions.Enabled = True
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.StylePriority.UseBackColor = False
        Me.lblDescription.StylePriority.UseBorderColor = False
        Me.lblDescription.StylePriority.UseBorders = False
        Me.lblDescription.StylePriority.UseForeColor = False
        Me.lblDescription.Text = "Description & Specifications"
        Me.lblDescription.Weight = 1.7229512875481499R
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.LightBlue
        Me.lblUnit.BorderColor = System.Drawing.Color.DimGray
        Me.lblUnit.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblUnit.EditOptions.Enabled = True
        Me.lblUnit.ForeColor = System.Drawing.Color.Black
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.StylePriority.UseBackColor = False
        Me.lblUnit.StylePriority.UseBorderColor = False
        Me.lblUnit.StylePriority.UseBorders = False
        Me.lblUnit.StylePriority.UseForeColor = False
        Me.lblUnit.Text = "Unit"
        Me.lblUnit.Weight = 0.50115214947373643R
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.LightBlue
        Me.lblQty.BorderColor = System.Drawing.Color.DimGray
        Me.lblQty.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblQty.EditOptions.Enabled = True
        Me.lblQty.ForeColor = System.Drawing.Color.Black
        Me.lblQty.Name = "lblQty"
        Me.lblQty.StylePriority.UseBackColor = False
        Me.lblQty.StylePriority.UseBorderColor = False
        Me.lblQty.StylePriority.UseBorders = False
        Me.lblQty.StylePriority.UseForeColor = False
        Me.lblQty.Text = "Qty"
        Me.lblQty.Weight = 0.508279789784552R
        '
        'txtUnitPriceText
        '
        Me.txtUnitPriceText.BackColor = System.Drawing.Color.LightBlue
        Me.txtUnitPriceText.BorderColor = System.Drawing.Color.DimGray
        Me.txtUnitPriceText.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtUnitPriceText.EditOptions.Enabled = True
        Me.txtUnitPriceText.ForeColor = System.Drawing.Color.Black
        Me.txtUnitPriceText.Multiline = True
        Me.txtUnitPriceText.Name = "txtUnitPriceText"
        Me.txtUnitPriceText.StylePriority.UseBackColor = False
        Me.txtUnitPriceText.StylePriority.UseBorderColor = False
        Me.txtUnitPriceText.StylePriority.UseBorders = False
        Me.txtUnitPriceText.StylePriority.UseForeColor = False
        Me.txtUnitPriceText.Text = "Unit Price"
        Me.txtUnitPriceText.Weight = 0.54258847759478812R
        '
        'cellDiscountText
        '
        Me.cellDiscountText.BackColor = System.Drawing.Color.LightBlue
        Me.cellDiscountText.BorderColor = System.Drawing.Color.DimGray
        Me.cellDiscountText.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cellDiscountText.EditOptions.Enabled = True
        Me.cellDiscountText.ForeColor = System.Drawing.Color.Black
        Me.cellDiscountText.Name = "cellDiscountText"
        Me.cellDiscountText.StylePriority.UseBackColor = False
        Me.cellDiscountText.StylePriority.UseBorderColor = False
        Me.cellDiscountText.StylePriority.UseBorders = False
        Me.cellDiscountText.StylePriority.UseForeColor = False
        Me.cellDiscountText.Text = "Discount"
        Me.cellDiscountText.Weight = 0.71981166372747185R
        '
        'txtVATText
        '
        Me.txtVATText.BackColor = System.Drawing.Color.LightBlue
        Me.txtVATText.BorderColor = System.Drawing.Color.DimGray
        Me.txtVATText.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtVATText.EditOptions.Enabled = True
        Me.txtVATText.ForeColor = System.Drawing.Color.Black
        Me.txtVATText.Multiline = True
        Me.txtVATText.Name = "txtVATText"
        Me.txtVATText.StylePriority.UseBackColor = False
        Me.txtVATText.StylePriority.UseBorderColor = False
        Me.txtVATText.StylePriority.UseBorders = False
        Me.txtVATText.StylePriority.UseForeColor = False
        Me.txtVATText.Text = "VAT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%"
        Me.txtVATText.Weight = 0.30528583924296282R
        '
        'txtAmtBeforeTaxText
        '
        Me.txtAmtBeforeTaxText.BackColor = System.Drawing.Color.LightBlue
        Me.txtAmtBeforeTaxText.BorderColor = System.Drawing.Color.DimGray
        Me.txtAmtBeforeTaxText.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtAmtBeforeTaxText.EditOptions.Enabled = True
        Me.txtAmtBeforeTaxText.ForeColor = System.Drawing.Color.Black
        Me.txtAmtBeforeTaxText.Multiline = True
        Me.txtAmtBeforeTaxText.Name = "txtAmtBeforeTaxText"
        Me.txtAmtBeforeTaxText.StylePriority.UseBackColor = False
        Me.txtAmtBeforeTaxText.StylePriority.UseBorderColor = False
        Me.txtAmtBeforeTaxText.StylePriority.UseBorders = False
        Me.txtAmtBeforeTaxText.StylePriority.UseForeColor = False
        Me.txtAmtBeforeTaxText.Text = "Amount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Before Tax"
        Me.txtAmtBeforeTaxText.Weight = 0.87153169766456351R
        '
        'lblVATAmount
        '
        Me.lblVATAmount.BackColor = System.Drawing.Color.LightBlue
        Me.lblVATAmount.BorderColor = System.Drawing.Color.DimGray
        Me.lblVATAmount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblVATAmount.EditOptions.Enabled = True
        Me.lblVATAmount.ForeColor = System.Drawing.Color.Black
        Me.lblVATAmount.Multiline = True
        Me.lblVATAmount.Name = "lblVATAmount"
        Me.lblVATAmount.StylePriority.UseBackColor = False
        Me.lblVATAmount.StylePriority.UseBorderColor = False
        Me.lblVATAmount.StylePriority.UseBorders = False
        Me.lblVATAmount.StylePriority.UseForeColor = False
        Me.lblVATAmount.Text = "VAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount"
        Me.lblVATAmount.Weight = 0.65913533887315578R
        '
        'DsRpt601_02PurchaseOrderReport1
        '
        Me.DsRpt601_02PurchaseOrderReport1.DataSetName = "dsRpt601_02PurchaseOrderReport"
        Me.DsRpt601_02PurchaseOrderReport1.EnforceConstraints = False
        Me.DsRpt601_02PurchaseOrderReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Qry604_05PurchaseOrderReportTableAdapter
        '
        Me.Qry604_05PurchaseOrderReportTableAdapter.ClearBeforeFill = True
        '
        'GroupHeader2
        '
        Me.GroupHeader2.HeightF = 0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panelAcceptance02, Me.txtApprovedBySignature, Me.txtSignatureImage, Me.txtVerifiedSignature, Me.txtCompanySeal, Me.panelAcceptance, Me.txtThanks, Me.XrPageBreak2, Me.panelPreparedBy, Me.panelVerifiedBy, Me.panelApprovedBy})
        Me.ReportFooter.HeightF = 320.0832!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'panelAcceptance02
        '
        Me.panelAcceptance02.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.panelAcceptance02.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6})
        Me.panelAcceptance02.LocationFloat = New DevExpress.Utils.PointFloat(0.00001502037!, 196.3333!)
        Me.panelAcceptance02.Name = "panelAcceptance02"
        Me.panelAcceptance02.SizeF = New System.Drawing.SizeF(774.0001!, 39.62485!)
        Me.panelAcceptance02.StylePriority.UseBorders = False
        Me.panelAcceptance02.Visible = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SupplierName")})
        Me.XrLabel1.Font = New System.Drawing.Font("Cambria", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(148.124!, 2.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(344.3066!, 21.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Agreed & Accepted by:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(515.382!, 20.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(210.9096!, 18.00006!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Date & Stamp:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(514.382!, 2.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(210.9096!, 18.00003!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Signature:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.Font = New System.Drawing.Font("Cambria", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(9.02844!, 2.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(137.0956!, 21.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Agreed & Accepted by:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtApprovedBySignature
        '
        Me.txtApprovedBySignature.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry604_05PurchaseOrderReport.ApprovedImage")})
        Me.txtApprovedBySignature.LocationFloat = New DevExpress.Utils.PointFloat(510.9367!, 19.41667!)
        Me.txtApprovedBySignature.Name = "txtApprovedBySignature"
        Me.txtApprovedBySignature.SizeF = New System.Drawing.SizeF(262.8538!, 110.5833!)
        Me.txtApprovedBySignature.Visible = False
        '
        'txtSignatureImage
        '
        Me.txtSignatureImage.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry604_05PurchaseOrderReport.SignatureImage")})
        Me.txtSignatureImage.LocationFloat = New DevExpress.Utils.PointFloat(10.41602!, 19.41668!)
        Me.txtSignatureImage.Name = "txtSignatureImage"
        Me.txtSignatureImage.SizeF = New System.Drawing.SizeF(294.8833!, 110.5833!)
        '
        'txtVerifiedSignature
        '
        Me.txtVerifiedSignature.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry604_05PurchaseOrderReport.VerifiedImage")})
        Me.txtVerifiedSignature.LocationFloat = New DevExpress.Utils.PointFloat(253.0!, 19.41668!)
        Me.txtVerifiedSignature.Name = "txtVerifiedSignature"
        Me.txtVerifiedSignature.SizeF = New System.Drawing.SizeF(294.8833!, 110.5833!)
        Me.txtVerifiedSignature.Visible = False
        '
        'txtCompanySeal
        '
        Me.txtCompanySeal.LocationFloat = New DevExpress.Utils.PointFloat(173.3059!, 6.999964!)
        Me.txtCompanySeal.Name = "txtCompanySeal"
        Me.txtCompanySeal.SizeF = New System.Drawing.SizeF(302.0834!, 156.0!)
        '
        'panelAcceptance
        '
        Me.panelAcceptance.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrLabel25, Me.XrLabel32, Me.XrLabel33, Me.XrLabel16})
        Me.panelAcceptance.LocationFloat = New DevExpress.Utils.PointFloat(505.9828!, 197.3333!)
        Me.panelAcceptance.Name = "panelAcceptance"
        Me.panelAcceptance.SizeF = New System.Drawing.SizeF(269.1668!, 122.7499!)
        Me.panelAcceptance.Visible = False
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SupplierName")})
        Me.XrLabel27.Font = New System.Drawing.Font("Cambria", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(4.028442!, 30.29144!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(264.9289!, 21.0!)
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "Agreed & Accepted by:"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(4.028442!, 95.54175!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(210.9096!, 18.0!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Stamp:"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel32
        '
        Me.XrLabel32.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(4.028442!, 74.54169!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(210.9096!, 18.00006!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Date:"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel33
        '
        Me.XrLabel33.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(4.028442!, 52.91656!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(210.9096!, 18.00003!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Signature:"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Cambria", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(4.028442!, 7.291443!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(264.9289!, 21.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Agreed & Accepted by:"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtThanks
        '
        Me.txtThanks.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POThanksNote")})
        Me.txtThanks.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtThanks.LocationFloat = New DevExpress.Utils.PointFloat(12.50002!, 3.000005!)
        Me.txtThanks.Multiline = True
        Me.txtThanks.Name = "txtThanks"
        Me.txtThanks.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtThanks.SizeF = New System.Drawing.SizeF(753.4586!, 52.29166!)
        Me.txtThanks.StylePriority.UseFont = False
        Me.txtThanks.StylePriority.UsePadding = False
        '
        'XrPageBreak2
        '
        Me.XrPageBreak2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageBreak2.Name = "XrPageBreak2"
        Me.XrPageBreak2.Visible = False
        '
        'panelPreparedBy
        '
        Me.panelPreparedBy.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPreparedName, Me.lblPreparedPosition, Me.lblPreparedContactNo, Me.lblPreparedEmail, Me.lblPreparedBy})
        Me.panelPreparedBy.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 84.0!)
        Me.panelPreparedBy.Name = "panelPreparedBy"
        Me.panelPreparedBy.SizeF = New System.Drawing.SizeF(248.125!, 111.3333!)
        '
        'lblPreparedName
        '
        Me.lblPreparedName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SignatoryName")})
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
        Me.lblPreparedPosition.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SignatoryPosition")})
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
        Me.lblPreparedContactNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SignatoryContact", "Contact #: {0}")})
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
        Me.lblPreparedEmail.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SignatoryEmail", "Email: {0}")})
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
        '
        'panelVerifiedBy
        '
        Me.panelVerifiedBy.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblVerifiedName, Me.lblVerifiedPosition, Me.lblVerifiedContactNo, Me.lblVerifiedEmail, Me.lblVerifiedBy})
        Me.panelVerifiedBy.LocationFloat = New DevExpress.Utils.PointFloat(253.0!, 85.0!)
        Me.panelVerifiedBy.Name = "panelVerifiedBy"
        Me.panelVerifiedBy.SizeF = New System.Drawing.SizeF(249.125!, 110.3333!)
        Me.panelVerifiedBy.Visible = False
        '
        'lblVerifiedName
        '
        Me.lblVerifiedName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.VerifiedName")})
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
        Me.lblVerifiedPosition.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.VerifiedPosition")})
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
        Me.lblVerifiedContactNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.VerifiedContactNo", "Contact #: {0}")})
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
        Me.lblVerifiedEmail.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.VerifiedEmail", "Email: {0}")})
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
        Me.panelApprovedBy.LocationFloat = New DevExpress.Utils.PointFloat(504.0!, 85.0!)
        Me.panelApprovedBy.Name = "panelApprovedBy"
        Me.panelApprovedBy.SizeF = New System.Drawing.SizeF(254.125!, 109.3333!)
        Me.panelApprovedBy.Visible = False
        '
        'lblApprovedName
        '
        Me.lblApprovedName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.ApprovedName")})
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
        Me.lblApprovedPosition.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.ApprovedPosition")})
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
        Me.lblApprovedContactNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.ApprovedContact", "Contact #: {0}")})
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
        Me.lblApprovedEmail.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.ApprovedEmail", "Email: {0}")})
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
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtSystemTitle, Me.txtPageNumber, Me.txtUserPrinting})
        Me.PageFooter.HeightF = 19.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'txtSystemTitle
        '
        Me.txtSystemTitle.BorderColor = System.Drawing.Color.Empty
        Me.txtSystemTitle.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.txtSystemTitle.ForeColor = System.Drawing.Color.DimGray
        Me.txtSystemTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 0!)
        Me.txtSystemTitle.Name = "txtSystemTitle"
        Me.txtSystemTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSystemTitle.SizeF = New System.Drawing.SizeF(277.9597!, 18.0!)
        Me.txtSystemTitle.StylePriority.UseBorderColor = False
        Me.txtSystemTitle.StylePriority.UseFont = False
        Me.txtSystemTitle.StylePriority.UseForeColor = False
        Me.txtSystemTitle.StylePriority.UseTextAlignment = False
        Me.txtSystemTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtPageNumber
        '
        Me.txtPageNumber.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.txtPageNumber.ForeColor = System.Drawing.Color.DimGray
        Me.txtPageNumber.LocationFloat = New DevExpress.Utils.PointFloat(321.36!, 0!)
        Me.txtPageNumber.Name = "txtPageNumber"
        Me.txtPageNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPageNumber.SizeF = New System.Drawing.SizeF(108.0!, 17.0!)
        Me.txtPageNumber.StylePriority.UseFont = False
        Me.txtPageNumber.StylePriority.UseForeColor = False
        Me.txtPageNumber.StylePriority.UseTextAlignment = False
        Me.txtPageNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtPageNumber.TextFormatString = "Page No:{0} of {1}"
        '
        'txtUserPrinting
        '
        Me.txtUserPrinting.BorderColor = System.Drawing.Color.Empty
        Me.txtUserPrinting.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.txtUserPrinting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUserPrinting.LocationFloat = New DevExpress.Utils.PointFloat(468.9018!, 0!)
        Me.txtUserPrinting.Name = "txtUserPrinting"
        Me.txtUserPrinting.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtUserPrinting.SizeF = New System.Drawing.SizeF(301.0982!, 19.0!)
        Me.txtUserPrinting.StylePriority.UseBorderColor = False
        Me.txtUserPrinting.StylePriority.UseFont = False
        Me.txtUserPrinting.StylePriority.UseForeColor = False
        Me.txtUserPrinting.StylePriority.UseTextAlignment = False
        Me.txtUserPrinting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(116.2169!, 0!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(186.962!, 17.0!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "**** Nothing Follows *****"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1, Me.XrPageBreak1, Me.XrLabel7, Me.XrTable3})
        Me.GroupFooter2.HeightF = 225.7292!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.CanShrink = True
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(12.0!, 201.5417!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New ERP.rpt40102QuotationTerms()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(753.9586!, 20.99998!)
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 195.5417!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POSummary")})
        Me.XrLabel7.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(12.0!, 160.25!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(753.4098!, 32.29164!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.Text = "With reference to your enquiry, please find our competitive quotation as follows:" &
    ""
        '
        'XrTable3
        '
        Me.XrTable3.KeepTogether = True
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(12.50002!, 4.000012!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4, Me.XrTableRow5, Me.XrTableRow10, Me.rowAdditions, Me.rowDeductions, Me.XrTableRow9})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(755.0001!, 148.2268!)
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
        Me.txtAmountInWords.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAmountInWords.Multiline = True
        Me.txtAmountInWords.Name = "txtAmountInWords"
        Me.txtAmountInWords.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 10, 100.0!)
        Me.txtAmountInWords.RowSpan = 6
        Me.txtAmountInWords.StylePriority.UseBorderColor = False
        Me.txtAmountInWords.StylePriority.UseBorders = False
        Me.txtAmountInWords.StylePriority.UseFont = False
        Me.txtAmountInWords.StylePriority.UseForeColor = False
        Me.txtAmountInWords.StylePriority.UsePadding = False
        Me.txtAmountInWords.StylePriority.UseTextAlignment = False
        Me.txtAmountInWords.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.txtAmountInWords.Weight = 4.41317522198544R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell20.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell20.CanGrow = False
        Me.XrTableCell20.EditOptions.Enabled = True
        Me.XrTableCell20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell20.StylePriority.UseBorderColor = False
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UseForeColor = False
        Me.XrTableCell20.StylePriority.UsePadding = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.Text = "Total Amount "
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell20.Weight = 1.6191131495206048R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell21.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBorderColor = False
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UseForeColor = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = ":"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell21.Weight = 0.14500481218917508R
        '
        'txtTotalBeforeDiscount
        '
        Me.txtTotalBeforeDiscount.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalBeforeDiscount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.txtTotalBeforeDiscount.CanGrow = False
        Me.txtTotalBeforeDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.TotalBeforeTax", "{0:n2}")})
        Me.txtTotalBeforeDiscount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalBeforeDiscount.Name = "txtTotalBeforeDiscount"
        Me.txtTotalBeforeDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtTotalBeforeDiscount.StylePriority.UseBorderColor = False
        Me.txtTotalBeforeDiscount.StylePriority.UseBorders = False
        Me.txtTotalBeforeDiscount.StylePriority.UseFont = False
        Me.txtTotalBeforeDiscount.StylePriority.UseForeColor = False
        Me.txtTotalBeforeDiscount.StylePriority.UsePadding = False
        Me.txtTotalBeforeDiscount.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        Me.txtTotalBeforeDiscount.Summary = XrSummary2
        Me.txtTotalBeforeDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtTotalBeforeDiscount.Weight = 1.1031507918543186R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell38, Me.XrTableCell23, Me.XrTableCell24, Me.txtDiscountAmount})
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
        Me.XrTableCell38.Weight = 4.41317522198544R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell23.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell23.CanGrow = False
        Me.XrTableCell23.EditOptions.Enabled = True
        Me.XrTableCell23.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell23.StylePriority.UseBorderColor = False
        Me.XrTableCell23.StylePriority.UseBorders = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UsePadding = False
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        Me.XrTableCell23.Text = " Less:  Discount"
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell23.Weight = 1.6191131495206048R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseBorderColor = False
        Me.XrTableCell24.StylePriority.UseBorders = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        Me.XrTableCell24.Text = ":"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell24.Weight = 0.14500481218917508R
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDiscountAmount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtDiscountAmount.CanGrow = False
        Me.txtDiscountAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.TotalDiscount", "{0:n2}")})
        Me.txtDiscountAmount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtDiscountAmount.StylePriority.UseBorderColor = False
        Me.txtDiscountAmount.StylePriority.UseBorders = False
        Me.txtDiscountAmount.StylePriority.UseFont = False
        Me.txtDiscountAmount.StylePriority.UseForeColor = False
        Me.txtDiscountAmount.StylePriority.UsePadding = False
        Me.txtDiscountAmount.StylePriority.UseTextAlignment = False
        Me.txtDiscountAmount.Text = "XrTableCell20"
        Me.txtDiscountAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtDiscountAmount.Weight = 1.1031507918543186R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell10, Me.txtTotalAfterDiscount})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell6.Weight = 4.41317522198544R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.EditOptions.Enabled = True
        Me.XrTableCell7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "Gross Total "
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell7.Weight = 1.6191131495206048R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = ":"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell10.Weight = 0.14500481218917508R
        '
        'txtTotalAfterDiscount
        '
        Me.txtTotalAfterDiscount.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalAfterDiscount.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.txtTotalAfterDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.TotalAfterDiscount", "{0:n2}")})
        Me.txtTotalAfterDiscount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAfterDiscount.Name = "txtTotalAfterDiscount"
        Me.txtTotalAfterDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtTotalAfterDiscount.StylePriority.UseBorderColor = False
        Me.txtTotalAfterDiscount.StylePriority.UseBorders = False
        Me.txtTotalAfterDiscount.StylePriority.UseFont = False
        Me.txtTotalAfterDiscount.StylePriority.UsePadding = False
        Me.txtTotalAfterDiscount.StylePriority.UseTextAlignment = False
        Me.txtTotalAfterDiscount.Text = "txtTotalAfterDiscount"
        Me.txtTotalAfterDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtTotalAfterDiscount.Weight = 1.1031507918543186R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell3, Me.XrTableCell4, Me.txtTotalVatAmount})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell1.Weight = 4.41317522198544R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.EditOptions.Enabled = True
        Me.XrTableCell3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "(+) VAT Amount"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell3.Weight = 1.6191131495206048R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = ":"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 0.14500481218917508R
        '
        'txtTotalVatAmount
        '
        Me.txtTotalVatAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalVatAmount.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.txtTotalVatAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.TotalTaxAmount", "{0:n2}")})
        Me.txtTotalVatAmount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtTotalVatAmount.Name = "txtTotalVatAmount"
        Me.txtTotalVatAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtTotalVatAmount.StylePriority.UseBorderColor = False
        Me.txtTotalVatAmount.StylePriority.UseBorders = False
        Me.txtTotalVatAmount.StylePriority.UseFont = False
        Me.txtTotalVatAmount.StylePriority.UsePadding = False
        Me.txtTotalVatAmount.StylePriority.UseTextAlignment = False
        Me.txtTotalVatAmount.Text = "txtTotalVatAmount"
        Me.txtTotalVatAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtTotalVatAmount.Weight = 1.1031507918543186R
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
        Me.XrTableCell39.Weight = 4.41317522198544R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.CanGrow = False
        Me.XrTableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.AdditionsText")})
        Me.XrTableCell26.EditOptions.Enabled = True
        Me.XrTableCell26.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UsePadding = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.Text = "XrTableCell21"
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell26.Weight = 1.6191131495206048R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.Text = ":"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell27.Weight = 0.14500481218917508R
        '
        'txtAdditionAmount
        '
        Me.txtAdditionAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtAdditionAmount.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.txtAdditionAmount.CanGrow = False
        Me.txtAdditionAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.AdditionsAmount", "{0:n2}")})
        Me.txtAdditionAmount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtAdditionAmount.Name = "txtAdditionAmount"
        Me.txtAdditionAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtAdditionAmount.StylePriority.UseBorderColor = False
        Me.txtAdditionAmount.StylePriority.UseBorders = False
        Me.txtAdditionAmount.StylePriority.UseFont = False
        Me.txtAdditionAmount.StylePriority.UseForeColor = False
        Me.txtAdditionAmount.StylePriority.UsePadding = False
        Me.txtAdditionAmount.StylePriority.UseTextAlignment = False
        Me.txtAdditionAmount.Text = "XrTableCell23"
        Me.txtAdditionAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtAdditionAmount.Weight = 1.1031507918543186R
        '
        'rowDeductions
        '
        Me.rowDeductions.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell40, Me.XrTableCell29, Me.XrTableCell30, Me.txtDeductionAmount})
        Me.rowDeductions.Name = "rowDeductions"
        Me.rowDeductions.Weight = 1.0R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell40.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell40.StylePriority.UseBorders = False
        Me.XrTableCell40.StylePriority.UseFont = False
        Me.XrTableCell40.StylePriority.UsePadding = False
        Me.XrTableCell40.StylePriority.UseTextAlignment = False
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell40.Weight = 4.41317522198544R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.CanGrow = False
        Me.XrTableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.DiscountsText")})
        Me.XrTableCell29.EditOptions.Enabled = True
        Me.XrTableCell29.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UsePadding = False
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        Me.XrTableCell29.Text = "XrTableCell24"
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell29.Weight = 1.6191131495206048R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.Text = ":"
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell30.Weight = 0.14500481218917508R
        '
        'txtDeductionAmount
        '
        Me.txtDeductionAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtDeductionAmount.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.txtDeductionAmount.CanGrow = False
        Me.txtDeductionAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.DeductionsAmount", "{0:n2}")})
        Me.txtDeductionAmount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtDeductionAmount.Name = "txtDeductionAmount"
        Me.txtDeductionAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.txtDeductionAmount.StylePriority.UseBorderColor = False
        Me.txtDeductionAmount.StylePriority.UseBorders = False
        Me.txtDeductionAmount.StylePriority.UseFont = False
        Me.txtDeductionAmount.StylePriority.UseForeColor = False
        Me.txtDeductionAmount.StylePriority.UsePadding = False
        Me.txtDeductionAmount.StylePriority.UseTextAlignment = False
        Me.txtDeductionAmount.Text = "XrTableCell26"
        Me.txtDeductionAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtDeductionAmount.Weight = 1.1031507918543186R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblNetAmountText, Me.lblColon, Me.txtNetAmountSales})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.2605044581309084R
        '
        'lblNetAmountText
        '
        Me.lblNetAmountText.BackColor = System.Drawing.Color.LightBlue
        Me.lblNetAmountText.BorderColor = System.Drawing.Color.DimGray
        Me.lblNetAmountText.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblNetAmountText.EditOptions.Enabled = True
        Me.lblNetAmountText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNetAmountText.Name = "lblNetAmountText"
        Me.lblNetAmountText.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.lblNetAmountText.StylePriority.UseBackColor = False
        Me.lblNetAmountText.StylePriority.UseBorderColor = False
        Me.lblNetAmountText.StylePriority.UseBorders = False
        Me.lblNetAmountText.StylePriority.UseFont = False
        Me.lblNetAmountText.StylePriority.UsePadding = False
        Me.lblNetAmountText.StylePriority.UseTextAlignment = False
        Me.lblNetAmountText.Text = "Net Amount "
        Me.lblNetAmountText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblNetAmountText.Weight = 6.032288371506044R
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
        Me.lblColon.Weight = 0.14500481218917508R
        '
        'txtNetAmountSales
        '
        Me.txtNetAmountSales.BackColor = System.Drawing.Color.LightBlue
        Me.txtNetAmountSales.BorderColor = System.Drawing.Color.DimGray
        Me.txtNetAmountSales.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtNetAmountSales.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.GrandTotal", "{0:n2}")})
        Me.txtNetAmountSales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
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
        Me.txtNetAmountSales.Weight = 1.1031507918543186R
        '
        'XrCrossBandBox4
        '
        Me.XrCrossBandBox4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox4.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox4.BorderWidth = 1.0!
        Me.XrCrossBandBox4.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox4.EndPointFloat = New DevExpress.Utils.PointFloat(12.5!, 5.1875!)
        Me.XrCrossBandBox4.Name = "XrCrossBandBox4"
        Me.XrCrossBandBox4.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox4.StartPointFloat = New DevExpress.Utils.PointFloat(12.5!, 0!)
        Me.XrCrossBandBox4.WidthF = 754.5001!
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox1.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox1.BorderWidth = 1.0!
        Me.XrCrossBandBox1.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(40.5!, 5.1875!)
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(40.5!, 0!)
        Me.XrCrossBandBox1.WidthF = 652.4901!
        '
        'XrCrossBandBox2
        '
        Me.XrCrossBandBox2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox2.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox2.BorderWidth = 1.0!
        Me.XrCrossBandBox2.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox2.EndPointFloat = New DevExpress.Utils.PointFloat(305.2993!, 5.1875!)
        Me.XrCrossBandBox2.Name = "XrCrossBandBox2"
        Me.XrCrossBandBox2.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox2.StartPointFloat = New DevExpress.Utils.PointFloat(305.2993!, 0!)
        Me.XrCrossBandBox2.WidthF = 290.0474!
        '
        'XrCrossBandBox3
        '
        Me.XrCrossBandBox3.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox3.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox3.BorderWidth = 1.0!
        Me.XrCrossBandBox3.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox3.EndPointFloat = New DevExpress.Utils.PointFloat(361.7871!, 5.1875!)
        Me.XrCrossBandBox3.Name = "XrCrossBandBox3"
        Me.XrCrossBandBox3.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox3.StartPointFloat = New DevExpress.Utils.PointFloat(361.7871!, 0!)
        Me.XrCrossBandBox3.WidthF = 199.3239!
        '
        'XrCrossBandBox5
        '
        Me.XrCrossBandBox5.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox5.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox5.BorderWidth = 1.0!
        Me.XrCrossBandBox5.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox5.EndPointFloat = New DevExpress.Utils.PointFloat(418.3615!, 5.1875!)
        Me.XrCrossBandBox5.Name = "XrCrossBandBox5"
        Me.XrCrossBandBox5.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox5.StartPointFloat = New DevExpress.Utils.PointFloat(418.3615!, 0!)
        Me.XrCrossBandBox5.WidthF = 62.02777!
        '
        'calcGSDescription
        '
        Me.calcGSDescription.DataMember = "qry604_05PurchaseOrderReport"
        Me.calcGSDescription.Expression = "Iif(IsNullOrEmpty([AddlDescription]), [GSDescrpition], [AddlDescription])"
        Me.calcGSDescription.Name = "calcGSDescription"
        '
        'XrCrossBandBox6
        '
        Me.XrCrossBandBox6.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox6.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox6.BorderWidth = 1.0!
        Me.XrCrossBandBox6.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox6.EndPointFloat = New DevExpress.Utils.PointFloat(40.5!, 5.1875!)
        Me.XrCrossBandBox6.Name = "XrCrossBandBox6"
        Me.XrCrossBandBox6.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox6.StartPointFloat = New DevExpress.Utils.PointFloat(40.5!, 0!)
        Me.XrCrossBandBox6.WidthF = 73.62411!
        '
        'calcPONo
        '
        Me.calcPONo.DataMember = "qry604_05PurchaseOrderReport"
        Me.calcPONo.Expression = "Concat([PONo], Iif(IsNullOrEmpty([PORevisionNo]), '', [PORevisionNo]) )"
        Me.calcPONo.Name = "calcPONo"
        '
        'Qry601_05QuotationReportTableAdapter
        '
        Me.Qry601_05QuotationReportTableAdapter.ClearBeforeFill = True
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tableBillToShipTo, Me.tableTerms})
        Me.GroupFooter3.HeightF = 152.0001!
        Me.GroupFooter3.Level = 2
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'tableBillToShipTo
        '
        Me.tableBillToShipTo.BackColor = System.Drawing.Color.Silver
        Me.tableBillToShipTo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tableBillToShipTo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.tableBillToShipTo.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tableBillToShipTo.LocationFloat = New DevExpress.Utils.PointFloat(13.54167!, 2.0!)
        Me.tableBillToShipTo.Name = "tableBillToShipTo"
        Me.tableBillToShipTo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow14, Me.XrTableRow15})
        Me.tableBillToShipTo.SizeF = New System.Drawing.SizeF(753.4586!, 70.00006!)
        Me.tableBillToShipTo.StylePriority.UseBackColor = False
        Me.tableBillToShipTo.StylePriority.UseBorderColor = False
        Me.tableBillToShipTo.StylePriority.UseBorders = False
        Me.tableBillToShipTo.StylePriority.UseFont = False
        Me.tableBillToShipTo.StylePriority.UseTextAlignment = False
        Me.tableBillToShipTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow14
        '
        Me.XrTableRow14.BackColor = System.Drawing.Color.LightGray
        Me.XrTableRow14.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableRow14.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell47, Me.XrTableCell54})
        Me.XrTableRow14.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow14.ForeColor = System.Drawing.Color.Black
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.StylePriority.UseBackColor = False
        Me.XrTableRow14.StylePriority.UseBorderColor = False
        Me.XrTableRow14.StylePriority.UseBorders = False
        Me.XrTableRow14.StylePriority.UseFont = False
        Me.XrTableRow14.StylePriority.UseForeColor = False
        Me.XrTableRow14.Weight = 1.1255771574981641R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.BackColor = System.Drawing.Color.LightBlue
        Me.XrTableCell47.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell47.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell47.EditOptions.Enabled = True
        Me.XrTableCell47.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell47.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell47.Multiline = True
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell47.StylePriority.UseBackColor = False
        Me.XrTableCell47.StylePriority.UseBorderColor = False
        Me.XrTableCell47.StylePriority.UseBorders = False
        Me.XrTableCell47.StylePriority.UseFont = False
        Me.XrTableCell47.StylePriority.UseForeColor = False
        Me.XrTableCell47.StylePriority.UsePadding = False
        Me.XrTableCell47.StylePriority.UseTextAlignment = False
        Me.XrTableCell47.Text = "Ship To:"
        Me.XrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell47.Weight = 2.8391385761351726R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.BackColor = System.Drawing.Color.LightBlue
        Me.XrTableCell54.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell54.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell54.EditOptions.Enabled = True
        Me.XrTableCell54.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell54.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell54.Multiline = True
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell54.StylePriority.UseBackColor = False
        Me.XrTableCell54.StylePriority.UseBorderColor = False
        Me.XrTableCell54.StylePriority.UseBorders = False
        Me.XrTableCell54.StylePriority.UseFont = False
        Me.XrTableCell54.StylePriority.UseForeColor = False
        Me.XrTableCell54.StylePriority.UsePadding = False
        Me.XrTableCell54.StylePriority.UseTextAlignment = False
        Me.XrTableCell54.Text = "Bill To"
        Me.XrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell54.Weight = 2.689338179325083R
        '
        'XrTableRow15
        '
        Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell58, Me.XrTableCell61})
        Me.XrTableRow15.Name = "XrTableRow15"
        Me.XrTableRow15.Weight = 2.926498166839782R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell58.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell58.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell58.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POShipTo")})
        Me.XrTableCell58.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell58.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell58.Multiline = True
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 0, 5, 0, 100.0!)
        Me.XrTableCell58.StylePriority.UseBackColor = False
        Me.XrTableCell58.StylePriority.UseBorderColor = False
        Me.XrTableCell58.StylePriority.UseBorders = False
        Me.XrTableCell58.StylePriority.UseFont = False
        Me.XrTableCell58.StylePriority.UseForeColor = False
        Me.XrTableCell58.StylePriority.UsePadding = False
        Me.XrTableCell58.StylePriority.UseTextAlignment = False
        Me.XrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell58.Weight = 2.8391385761351726R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell61.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell61.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell61.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POBillTo")})
        Me.XrTableCell61.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell61.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell61.Multiline = True
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 0, 5, 0, 100.0!)
        Me.XrTableCell61.StylePriority.UseBackColor = False
        Me.XrTableCell61.StylePriority.UseBorderColor = False
        Me.XrTableCell61.StylePriority.UseBorders = False
        Me.XrTableCell61.StylePriority.UseFont = False
        Me.XrTableCell61.StylePriority.UseForeColor = False
        Me.XrTableCell61.StylePriority.UsePadding = False
        Me.XrTableCell61.StylePriority.UseTextAlignment = False
        Me.XrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell61.Weight = 2.689338179325083R
        '
        'tableTerms
        '
        Me.tableTerms.BackColor = System.Drawing.Color.Silver
        Me.tableTerms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tableTerms.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.tableTerms.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tableTerms.LocationFloat = New DevExpress.Utils.PointFloat(13.54167!, 73.00006!)
        Me.tableTerms.Name = "tableTerms"
        Me.tableTerms.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11, Me.XrTableRow12, Me.XrTableRow13})
        Me.tableTerms.SizeF = New System.Drawing.SizeF(753.4586!, 79.0!)
        Me.tableTerms.StylePriority.UseBackColor = False
        Me.tableTerms.StylePriority.UseBorderColor = False
        Me.tableTerms.StylePriority.UseBorders = False
        Me.tableTerms.StylePriority.UseFont = False
        Me.tableTerms.StylePriority.UseTextAlignment = False
        Me.tableTerms.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow11
        '
        Me.XrTableRow11.BackColor = System.Drawing.Color.LightGray
        Me.XrTableRow11.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableRow11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell11, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell32, Me.XrTableCell33})
        Me.XrTableRow11.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow11.ForeColor = System.Drawing.Color.Black
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.StylePriority.UseBackColor = False
        Me.XrTableRow11.StylePriority.UseBorderColor = False
        Me.XrTableRow11.StylePriority.UseBorders = False
        Me.XrTableRow11.StylePriority.UseFont = False
        Me.XrTableRow11.StylePriority.UseForeColor = False
        Me.XrTableRow11.Weight = 1.1255771574981641R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.White
        Me.XrTableCell9.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.EditOptions.Enabled = True
        Me.XrTableCell9.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell9.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell9.Multiline = True
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseBackColor = False
        Me.XrTableCell9.StylePriority.UseBorderColor = False
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseForeColor = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Payment Terms"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.70841341765554144R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell11.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell11.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell11.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell11.StylePriority.UseBackColor = False
        Me.XrTableCell11.StylePriority.UseBorderColor = False
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseForeColor = False
        Me.XrTableCell11.StylePriority.UsePadding = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = ":"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell11.Weight = 0.099611975017581733R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell17.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell17.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POPaymentTerm")})
        Me.XrTableCell17.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrTableCell17.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell17.StylePriority.UseBackColor = False
        Me.XrTableCell17.StylePriority.UseBorderColor = False
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseForeColor = False
        Me.XrTableCell17.StylePriority.UsePadding = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell17.Weight = 2.031113237746387R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.BackColor = System.Drawing.Color.White
        Me.XrTableCell18.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell18.EditOptions.Enabled = True
        Me.XrTableCell18.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell18.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell18.Multiline = True
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell18.StylePriority.UseBackColor = False
        Me.XrTableCell18.StylePriority.UseBorderColor = False
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UseForeColor = False
        Me.XrTableCell18.StylePriority.UsePadding = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.Text = "Documents Req'd"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell18.Weight = 0.71441011569379187R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell32.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell32.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell32.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell32.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StylePriority.UseBackColor = False
        Me.XrTableCell32.StylePriority.UseBorderColor = False
        Me.XrTableCell32.StylePriority.UseBorders = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UseForeColor = False
        Me.XrTableCell32.StylePriority.UseTextAlignment = False
        Me.XrTableCell32.Text = ":"
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell32.Weight = 0.054191405404771853R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell33.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.PODocRequired")})
        Me.XrTableCell33.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell33.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell33.Multiline = True
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseBackColor = False
        Me.XrTableCell33.StylePriority.UseBorderColor = False
        Me.XrTableCell33.StylePriority.UseBorders = False
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UseForeColor = False
        Me.XrTableCell33.StylePriority.UseTextAlignment = False
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell33.Weight = 1.9207366039421816R
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell36, Me.XrTableCell37, Me.XrTableCell41, Me.XrTableCell42, Me.XrTableCell46, Me.XrTableCell101})
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.Weight = 1.1255771574981641R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.BackColor = System.Drawing.Color.White
        Me.XrTableCell36.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell36.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell36.EditOptions.Enabled = True
        Me.XrTableCell36.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell36.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell36.StylePriority.UseBackColor = False
        Me.XrTableCell36.StylePriority.UseBorderColor = False
        Me.XrTableCell36.StylePriority.UseBorders = False
        Me.XrTableCell36.StylePriority.UseFont = False
        Me.XrTableCell36.StylePriority.UseForeColor = False
        Me.XrTableCell36.StylePriority.UsePadding = False
        Me.XrTableCell36.StylePriority.UseTextAlignment = False
        Me.XrTableCell36.Text = "Delivery Terms"
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell36.Weight = 0.70841341765554133R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell37.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell37.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell37.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell37.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell37.StylePriority.UseBackColor = False
        Me.XrTableCell37.StylePriority.UseBorderColor = False
        Me.XrTableCell37.StylePriority.UseBorders = False
        Me.XrTableCell37.StylePriority.UseFont = False
        Me.XrTableCell37.StylePriority.UseForeColor = False
        Me.XrTableCell37.StylePriority.UsePadding = False
        Me.XrTableCell37.StylePriority.UseTextAlignment = False
        Me.XrTableCell37.Text = ":"
        Me.XrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell37.Weight = 0.0996119750175818R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell41.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell41.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.PODeliveryTerm")})
        Me.XrTableCell41.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrTableCell41.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell41.StylePriority.UseBackColor = False
        Me.XrTableCell41.StylePriority.UseBorderColor = False
        Me.XrTableCell41.StylePriority.UseBorders = False
        Me.XrTableCell41.StylePriority.UseFont = False
        Me.XrTableCell41.StylePriority.UseForeColor = False
        Me.XrTableCell41.StylePriority.UsePadding = False
        Me.XrTableCell41.StylePriority.UseTextAlignment = False
        Me.XrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell41.Weight = 2.031113237746387R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.BackColor = System.Drawing.Color.White
        Me.XrTableCell42.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell42.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell42.EditOptions.Enabled = True
        Me.XrTableCell42.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell42.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell42.StylePriority.UseBackColor = False
        Me.XrTableCell42.StylePriority.UseBorderColor = False
        Me.XrTableCell42.StylePriority.UseBorders = False
        Me.XrTableCell42.StylePriority.UseFont = False
        Me.XrTableCell42.StylePriority.UseForeColor = False
        Me.XrTableCell42.StylePriority.UsePadding = False
        Me.XrTableCell42.StylePriority.UseTextAlignment = False
        Me.XrTableCell42.Text = "Warranty Period"
        Me.XrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell42.Weight = 0.71441033283114264R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell46.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell46.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell46.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.StylePriority.UseBackColor = False
        Me.XrTableCell46.StylePriority.UseBorderColor = False
        Me.XrTableCell46.StylePriority.UseBorders = False
        Me.XrTableCell46.StylePriority.UseFont = False
        Me.XrTableCell46.StylePriority.UseForeColor = False
        Me.XrTableCell46.StylePriority.UseTextAlignment = False
        Me.XrTableCell46.Text = ":"
        Me.XrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell46.Weight = 0.054190535567178295R
        '
        'XrTableCell101
        '
        Me.XrTableCell101.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell101.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell101.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell101.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POWarrantyPeriod", "{0:n2}")})
        Me.XrTableCell101.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell101.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell101.Name = "XrTableCell101"
        Me.XrTableCell101.StylePriority.UseBackColor = False
        Me.XrTableCell101.StylePriority.UseBorderColor = False
        Me.XrTableCell101.StylePriority.UseBorders = False
        Me.XrTableCell101.StylePriority.UseFont = False
        Me.XrTableCell101.StylePriority.UseForeColor = False
        Me.XrTableCell101.StylePriority.UseTextAlignment = False
        Me.XrTableCell101.Text = "XrTableCell101"
        Me.XrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell101.Weight = 1.920737256642425R
        '
        'XrTableRow13
        '
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell48, Me.XrTableCell49, Me.XrTableCell50, Me.XrTableCell51, Me.XrTableCell52, Me.txtTotalTaxAmount})
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.Weight = 1.1255771574981641R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.BackColor = System.Drawing.Color.White
        Me.XrTableCell48.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell48.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell48.EditOptions.Enabled = True
        Me.XrTableCell48.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell48.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell48.StylePriority.UseBackColor = False
        Me.XrTableCell48.StylePriority.UseBorderColor = False
        Me.XrTableCell48.StylePriority.UseBorders = False
        Me.XrTableCell48.StylePriority.UseFont = False
        Me.XrTableCell48.StylePriority.UseForeColor = False
        Me.XrTableCell48.StylePriority.UsePadding = False
        Me.XrTableCell48.StylePriority.UseTextAlignment = False
        Me.XrTableCell48.Text = "Delivery Period"
        Me.XrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell48.Weight = 0.70841341765554133R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell49.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell49.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell49.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell49.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell49.StylePriority.UseBackColor = False
        Me.XrTableCell49.StylePriority.UseBorderColor = False
        Me.XrTableCell49.StylePriority.UseBorders = False
        Me.XrTableCell49.StylePriority.UseFont = False
        Me.XrTableCell49.StylePriority.UseForeColor = False
        Me.XrTableCell49.StylePriority.UsePadding = False
        Me.XrTableCell49.StylePriority.UseTextAlignment = False
        Me.XrTableCell49.Text = ":"
        Me.XrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell49.Weight = 0.099611975017581733R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell50.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell50.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.PODeliveryPeriod")})
        Me.XrTableCell50.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrTableCell50.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell50.StylePriority.UseBackColor = False
        Me.XrTableCell50.StylePriority.UseBorderColor = False
        Me.XrTableCell50.StylePriority.UseBorders = False
        Me.XrTableCell50.StylePriority.UseFont = False
        Me.XrTableCell50.StylePriority.UseForeColor = False
        Me.XrTableCell50.StylePriority.UsePadding = False
        Me.XrTableCell50.StylePriority.UseTextAlignment = False
        Me.XrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell50.Weight = 2.0311132377463865R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.BackColor = System.Drawing.Color.White
        Me.XrTableCell51.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell51.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell51.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell51.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell51.StylePriority.UseBackColor = False
        Me.XrTableCell51.StylePriority.UseBorderColor = False
        Me.XrTableCell51.StylePriority.UseBorders = False
        Me.XrTableCell51.StylePriority.UseFont = False
        Me.XrTableCell51.StylePriority.UseForeColor = False
        Me.XrTableCell51.StylePriority.UsePadding = False
        Me.XrTableCell51.StylePriority.UseTextAlignment = False
        Me.XrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell51.Weight = 0.71441011569379209R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.BackColor = System.Drawing.Color.Empty
        Me.XrTableCell52.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell52.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell52.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell52.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.StylePriority.UseBackColor = False
        Me.XrTableCell52.StylePriority.UseBorderColor = False
        Me.XrTableCell52.StylePriority.UseBorders = False
        Me.XrTableCell52.StylePriority.UseFont = False
        Me.XrTableCell52.StylePriority.UseForeColor = False
        Me.XrTableCell52.StylePriority.UseTextAlignment = False
        Me.XrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell52.Weight = 0.054191404116580168R
        '
        'txtTotalTaxAmount
        '
        Me.txtTotalTaxAmount.BackColor = System.Drawing.Color.Empty
        Me.txtTotalTaxAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalTaxAmount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtTotalTaxAmount.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalTaxAmount.ForeColor = System.Drawing.Color.Black
        Me.txtTotalTaxAmount.Name = "txtTotalTaxAmount"
        Me.txtTotalTaxAmount.StylePriority.UseBackColor = False
        Me.txtTotalTaxAmount.StylePriority.UseBorderColor = False
        Me.txtTotalTaxAmount.StylePriority.UseBorders = False
        Me.txtTotalTaxAmount.StylePriority.UseFont = False
        Me.txtTotalTaxAmount.StylePriority.UseForeColor = False
        Me.txtTotalTaxAmount.StylePriority.UseTextAlignment = False
        Me.txtTotalTaxAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtTotalTaxAmount.Weight = 1.9207366052303736R
        '
        'rpt601_02PurchaseOrderFormat01
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.ReportFooter, Me.PageFooter, Me.GroupFooter1, Me.GroupFooter2, Me.GroupFooter3})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calcGSDescription, Me.calcPONo})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBox6, Me.XrCrossBandBox5, Me.XrCrossBandBox3, Me.XrCrossBandBox2, Me.XrCrossBandBox1, Me.XrCrossBandBox4})
        Me.DataAdapter = Me.Qry604_05PurchaseOrderReportTableAdapter
        Me.DataMember = "qry604_05PurchaseOrderReport"
        Me.DataSource = Me.DsRpt601_02PurchaseOrderReport1
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 87, 38)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "21.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRpt601_02PurchaseOrderReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tableBillToShipTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tableTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents DsRpt601_02PurchaseOrderReport1 As ERP.dsRpt601_02PurchaseOrderReport
    Friend WithEvents Qry604_05PurchaseOrderReportTableAdapter As ERP.dsRpt601_02PurchaseOrderReportTableAdapters.qry604_05PurchaseOrderReportTableAdapter
    Friend WithEvents lblPO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtReferenceNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtVATNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblReferenceNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblVATNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape2 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblSlNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblUnit As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtUnitPriceText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellDiscountText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtVATText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtAmtBeforeTaxText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblVATAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtRecordNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtStockDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtUnitPrice As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtDiscount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtLineAmtBeforeTax As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtVATAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtAmountInWords As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTotalBeforeDiscount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtDiscountAmount As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNetAmountText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblColon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtNetAmountSales As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrCrossBandBox4 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox2 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox3 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox5 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatureImage As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtCompanySeal As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtThanks As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageBreak2 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents calcGSDescription As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTotalVatAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTotalAfterDiscount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents panelAcceptance As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPageNumber As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents txtUserPrinting As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSystemTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtItemCode As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblItemCode As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrCrossBandBox6 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents panelApprovedBy As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblApprovedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblApprovedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblApprovedContactNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblApprovedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents panelVerifiedBy As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblVerifiedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblVerifiedEmail As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblVerifiedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents panelPreparedBy As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblPreparedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPreparedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPreparedContactNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPreparedEmail As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPreparedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblVerifiedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblVerifiedContactNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblApprovedEmail As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtVerifiedSignature As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtApprovedBySignature As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents panelAcceptance02 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents calcPONo As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Qry601_05QuotationReportTableAdapter As dsRpt601_01QuotationReportTableAdapters.qry601_05QuotationReportTableAdapter
    Friend WithEvents GroupFooter3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableTerms As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell101 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTotalTaxAmount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableBillToShipTo As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell61 As DevExpress.XtraReports.UI.XRTableCell
End Class
