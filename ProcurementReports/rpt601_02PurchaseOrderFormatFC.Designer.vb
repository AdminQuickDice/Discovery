<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rpt601_02PurchaseOrderFormatFC
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtDiscount = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.DsRpt601_02PurchaseOrderReport1 = New ERP.dsRpt601_02PurchaseOrderReport()
        Me.Qry604_05PurchaseOrderReportTableAdapter = New ERP.dsRpt601_02PurchaseOrderReportTableAdapters.qry604_05PurchaseOrderReportTableAdapter()
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
        Me.txtAmtBeforeTaxText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
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
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rowAdditions = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rowDeductions = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNetAmountText = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblColon = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtNetAmountSales = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.txtThanks = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageBreak2 = New DevExpress.XtraReports.UI.XRPageBreak()
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
        Me.panelAcceptance02 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.txtSystemTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtUserPrinting = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPageNumber = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.calLableTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calcLblNetTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox2 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox3 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox4 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandBox5 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.calcGSDescription = New DevExpress.XtraReports.UI.CalculatedField()
        Me.calcPONo = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupFooter3 = New DevExpress.XtraReports.UI.GroupFooterBand()
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
        Me.tableBillToShipTo = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRpt601_02PurchaseOrderReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tableTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tableBillToShipTo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XrTable2.SizeF = New System.Drawing.SizeF(755.9587!, 30.0!)
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.BorderColor = System.Drawing.Color.Gray
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtRecordNo, Me.txtItemCode, Me.txtStockDescription, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell2, Me.txtDiscount, Me.XrTableCell19})
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
        Me.txtRecordNo.Weight = 0.25682585432739224R
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
        Me.txtItemCode.Weight = 0.61995039264868324R
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
        Me.txtStockDescription.Weight = 1.7549342282892066R
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
        Me.XrTableCell12.Weight = 0.49442273085678R
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
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell2.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.UnitRateInOC")})
        Me.XrTableCell2.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.XrTableCell2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.StylePriority.UseBorderColor = False
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseForeColor = False
        Me.XrTableCell2.StylePriority.UsePadding = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell2.TextFormatString = "{0:########0.00##}"
        Me.XrTableCell2.Weight = 0.55311302807369311R
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.Transparent
        Me.txtDiscount.BorderColor = System.Drawing.Color.DimGray
        Me.txtDiscount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.DiscountInOC", "{0:n2}")})
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
        'XrTableCell19
        '
        Me.XrTableCell19.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell19.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell19.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.LineTotalAfterDiscOC", "{0:n2}")})
        Me.XrTableCell19.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 3, 0, 100.0!)
        Me.XrTableCell19.StylePriority.UseBackColor = False
        Me.XrTableCell19.StylePriority.UseBorderColor = False
        Me.XrTableCell19.StylePriority.UseBorders = False
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.StylePriority.UseForeColor = False
        Me.XrTableCell19.StylePriority.UsePadding = False
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.Text = "XrTableCell19"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell19.Weight = 0.8791811265687689R
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
        Me.lblPO.LocationFloat = New DevExpress.Utils.PointFloat(15.38856!, 0!)
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
        Me.XrLabel3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(488.9376!, 64.35416!)
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
        Me.txtReferenceNo.LocationFloat = New DevExpress.Utils.PointFloat(559.427!, 109.8438!)
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReferenceNo.SizeF = New System.Drawing.SizeF(197.4618!, 20.00002!)
        Me.txtReferenceNo.StylePriority.UseFont = False
        Me.txtReferenceNo.StylePriority.UseTextAlignment = False
        Me.txtReferenceNo.Text = "XrLabel16"
        Me.txtReferenceNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SupplierContactEmail", "Email:{0}")})
        Me.XrLabel22.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(46.08345!, 112.3542!)
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
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(16.38893!, 39.35425!)
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
        Me.XrLabel20.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(488.9376!, 41.35411!)
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
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(559.427!, 64.35416!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(197.4618!, 20.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "XrLabel16"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtVATNo
        '
        Me.txtVATNo.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtVATNo.LocationFloat = New DevExpress.Utils.PointFloat(559.427!, 87.35419!)
        Me.txtVATNo.Name = "txtVATNo"
        Me.txtVATNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVATNo.SizeF = New System.Drawing.SizeF(197.4618!, 20.0!)
        Me.txtVATNo.StylePriority.UseFont = False
        Me.txtVATNo.StylePriority.UseTextAlignment = False
        Me.txtVATNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel24
        '
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.SupplierAddress")})
        Me.XrLabel24.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(46.08345!, 71.3541!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(430.9167!, 41.0!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "XrLabel10"
        '
        'XrTable6
        '
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(13.38861!, 139.6979!)
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
        Me.lblReferenceNo.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReferenceNo.LocationFloat = New DevExpress.Utils.PointFloat(488.9376!, 109.8438!)
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
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(559.427!, 41.35411!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(197.4618!, 21.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "XrLabel6"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POIntroduction")})
        Me.XrLabel17.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(13.38862!, 253.6875!)
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
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(46.08345!, 37.35413!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(430.9167!, 33.0!)
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
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(13.38862!, 30.45832!)
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
        Me.lblVATNumber.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblVATNumber.LocationFloat = New DevExpress.Utils.PointFloat(488.9376!, 87.35419!)
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
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(13.38862!, 227.6875!)
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
        Me.XrShape2.LocationFloat = New DevExpress.Utils.PointFloat(485.4958!, 37.35413!)
        Me.XrShape2.Name = "XrShape2"
        ShapeRectangle1.Fillet = 5
        Me.XrShape2.Shape = ShapeRectangle1
        Me.XrShape2.SizeF = New System.Drawing.SizeF(278.1155!, 97.99999!)
        '
        'XrShape1
        '
        Me.XrShape1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrShape1.BorderWidth = 1.0!
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(13.38862!, 37.35413!)
        Me.XrShape1.Name = "XrShape1"
        ShapeRectangle2.Fillet = 5
        Me.XrShape1.Shape = ShapeRectangle2
        Me.XrShape1.SizeF = New System.Drawing.SizeF(468.6531!, 99.0!)
        Me.XrShape1.StylePriority.UseBorderWidth = False
        '
        'DsRpt601_02PurchaseOrderReport1
        '
        Me.DsRpt601_02PurchaseOrderReport1.DataSetName = "dsRpt601_02PurchaseOrderReport"
        Me.DsRpt601_02PurchaseOrderReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Qry604_05PurchaseOrderReportTableAdapter
        '
        Me.Qry604_05PurchaseOrderReportTableAdapter.ClearBeforeFill = True
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.GroupHeader1.HeightF = 31.50002!
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
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(11.4999!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(755.9586!, 31.50002!)
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
        Me.XrTableRow1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblSlNo, Me.lblItemCode, Me.lblDescription, Me.lblUnit, Me.lblQty, Me.txtUnitPriceText, Me.cellDiscountText, Me.txtAmtBeforeTaxText})
        Me.XrTableRow1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow1.ForeColor = System.Drawing.Color.Black
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBackColor = False
        Me.XrTableRow1.StylePriority.UseBorderColor = False
        Me.XrTableRow1.StylePriority.UseBorders = False
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.StylePriority.UseForeColor = False
        Me.XrTableRow1.Weight = 1.3379500532264397R
        '
        'lblSlNo
        '
        Me.lblSlNo.BackColor = System.Drawing.Color.LightBlue
        Me.lblSlNo.BorderColor = System.Drawing.Color.DimGray
        Me.lblSlNo.EditOptions.Enabled = True
        Me.lblSlNo.ForeColor = System.Drawing.Color.Black
        Me.lblSlNo.Multiline = True
        Me.lblSlNo.Name = "lblSlNo"
        Me.lblSlNo.StylePriority.UseBackColor = False
        Me.lblSlNo.StylePriority.UseBorderColor = False
        Me.lblSlNo.StylePriority.UseForeColor = False
        Me.lblSlNo.Text = "#"
        Me.lblSlNo.Weight = 0.25682538110370057R
        '
        'lblItemCode
        '
        Me.lblItemCode.BackColor = System.Drawing.Color.LightBlue
        Me.lblItemCode.BorderColor = System.Drawing.Color.DimGray
        Me.lblItemCode.EditOptions.Enabled = True
        Me.lblItemCode.ForeColor = System.Drawing.Color.Black
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.StylePriority.UseBackColor = False
        Me.lblItemCode.StylePriority.UseBorderColor = False
        Me.lblItemCode.StylePriority.UseForeColor = False
        Me.lblItemCode.Text = "Item Code"
        Me.lblItemCode.Weight = 0.619951132496082R
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.LightBlue
        Me.lblDescription.BorderColor = System.Drawing.Color.DimGray
        Me.lblDescription.EditOptions.Enabled = True
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.StylePriority.UseBackColor = False
        Me.lblDescription.StylePriority.UseBorderColor = False
        Me.lblDescription.StylePriority.UseForeColor = False
        Me.lblDescription.Text = "Description & Specifications"
        Me.lblDescription.Weight = 1.754933401827171R
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.LightBlue
        Me.lblUnit.BorderColor = System.Drawing.Color.DimGray
        Me.lblUnit.EditOptions.Enabled = True
        Me.lblUnit.ForeColor = System.Drawing.Color.Black
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.StylePriority.UseBackColor = False
        Me.lblUnit.StylePriority.UseBorderColor = False
        Me.lblUnit.StylePriority.UseForeColor = False
        Me.lblUnit.Text = "Unit"
        Me.lblUnit.Weight = 0.50115203275127329R
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.LightBlue
        Me.lblQty.BorderColor = System.Drawing.Color.DimGray
        Me.lblQty.EditOptions.Enabled = True
        Me.lblQty.ForeColor = System.Drawing.Color.Black
        Me.lblQty.Name = "lblQty"
        Me.lblQty.StylePriority.UseBackColor = False
        Me.lblQty.StylePriority.UseBorderColor = False
        Me.lblQty.StylePriority.UseForeColor = False
        Me.lblQty.Text = "Qty"
        Me.lblQty.Weight = 0.508279789784552R
        '
        'txtUnitPriceText
        '
        Me.txtUnitPriceText.BackColor = System.Drawing.Color.LightBlue
        Me.txtUnitPriceText.BorderColor = System.Drawing.Color.DimGray
        Me.txtUnitPriceText.EditOptions.Enabled = True
        Me.txtUnitPriceText.ForeColor = System.Drawing.Color.Black
        Me.txtUnitPriceText.Multiline = True
        Me.txtUnitPriceText.Name = "txtUnitPriceText"
        Me.txtUnitPriceText.StylePriority.UseBackColor = False
        Me.txtUnitPriceText.StylePriority.UseBorderColor = False
        Me.txtUnitPriceText.StylePriority.UseForeColor = False
        Me.txtUnitPriceText.Text = "Unit Price"
        Me.txtUnitPriceText.Weight = 0.54258847759478812R
        '
        'cellDiscountText
        '
        Me.cellDiscountText.BackColor = System.Drawing.Color.LightBlue
        Me.cellDiscountText.BorderColor = System.Drawing.Color.DimGray
        Me.cellDiscountText.EditOptions.Enabled = True
        Me.cellDiscountText.ForeColor = System.Drawing.Color.Black
        Me.cellDiscountText.Name = "cellDiscountText"
        Me.cellDiscountText.StylePriority.UseBackColor = False
        Me.cellDiscountText.StylePriority.UseBorderColor = False
        Me.cellDiscountText.StylePriority.UseForeColor = False
        Me.cellDiscountText.Text = "Discount"
        Me.cellDiscountText.Weight = 0.71981166372747185R
        '
        'txtAmtBeforeTaxText
        '
        Me.txtAmtBeforeTaxText.BackColor = System.Drawing.Color.LightBlue
        Me.txtAmtBeforeTaxText.BorderColor = System.Drawing.Color.DimGray
        Me.txtAmtBeforeTaxText.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.calLableTotal")})
        Me.txtAmtBeforeTaxText.EditOptions.Enabled = True
        Me.txtAmtBeforeTaxText.ForeColor = System.Drawing.Color.Black
        Me.txtAmtBeforeTaxText.Multiline = True
        Me.txtAmtBeforeTaxText.Name = "txtAmtBeforeTaxText"
        Me.txtAmtBeforeTaxText.StylePriority.UseBackColor = False
        Me.txtAmtBeforeTaxText.StylePriority.UseBorderColor = False
        Me.txtAmtBeforeTaxText.StylePriority.UseForeColor = False
        Me.txtAmtBeforeTaxText.Text = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount"
        Me.txtAmtBeforeTaxText.Weight = 0.87918122101326524R
        '
        'GroupHeader2
        '
        Me.GroupHeader2.HeightF = 0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel29})
        Me.GroupFooter1.HeightF = 18.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(131.1601!, 1.0!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(217.2031!, 17.0!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "**** Nothing Follows *****"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1, Me.XrPageBreak1, Me.XrLabel7, Me.XrTable3})
        Me.GroupFooter2.HeightF = 213.2267!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.CanShrink = True
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(13.59021!, 192.2267!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New ERP.rpt40102QuotationTerms()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(753.9586!, 20.99998!)
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 189.2267!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POSummary")})
        Me.XrLabel7.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(13.59021!, 160.2268!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(753.4098!, 24.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.Text = "With reference to your enquiry, please find our competitive quotation as follows:" &
    ""
        '
        'XrTable3
        '
        Me.XrTable3.KeepTogether = True
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 5.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4, Me.XrTableRow5, Me.XrTableRow10, Me.rowAdditions, Me.rowDeductions, Me.XrTableRow9})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(756.0001!, 148.2268!)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtAmountInWords, Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22})
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
        Me.txtAmountInWords.Weight = 4.3167455160459811R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell20.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell20.CanGrow = False
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.calLableTotal")})
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
        'XrTableCell22
        '
        Me.XrTableCell22.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell22.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell22.CanGrow = False
        Me.XrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.TotalAmountB4TaxInOC", "{0:n2}")})
        Me.XrTableCell22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell22.StylePriority.UseBorderColor = False
        Me.XrTableCell22.StylePriority.UseBorders = False
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.StylePriority.UseForeColor = False
        Me.XrTableCell22.StylePriority.UsePadding = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        Me.XrTableCell22.Summary = XrSummary2
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell22.Weight = 1.1031507918543186R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell38, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25})
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
        Me.XrTableCell38.Weight = 4.3167455160459811R
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
        'XrTableCell25
        '
        Me.XrTableCell25.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrTableCell25.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell25.CanGrow = False
        Me.XrTableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.TotalDiscountInOC", "{0:n2}")})
        Me.XrTableCell25.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell25.StylePriority.UseBorderColor = False
        Me.XrTableCell25.StylePriority.UseBorders = False
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseForeColor = False
        Me.XrTableCell25.StylePriority.UsePadding = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.Text = "XrTableCell20"
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell25.Weight = 1.1031507918543186R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell10, Me.XrTableCell14})
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
        Me.XrTableCell6.Weight = 4.3167455160459811R
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
        'XrTableCell14
        '
        Me.XrTableCell14.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell14.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.TotalAmountAfterDiscInOC", "{0:n2}")})
        Me.XrTableCell14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell14.StylePriority.UseBorderColor = False
        Me.XrTableCell14.StylePriority.UseBorders = False
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UsePadding = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell14.Weight = 1.1031507918543186R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5})
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
        Me.XrTableCell1.Weight = 4.3167455160459811R
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
        Me.XrTableCell3.Text = "(+) TAX Amount"
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
        'XrTableCell5
        '
        Me.XrTableCell5.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.TotalTaxAmountInOC", "{0:n2}")})
        Me.XrTableCell5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell5.StylePriority.UseBorderColor = False
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell5.Weight = 1.1031507918543186R
        '
        'rowAdditions
        '
        Me.rowAdditions.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell39, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28})
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
        Me.XrTableCell39.Weight = 4.3167455160459811R
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
        'XrTableCell28
        '
        Me.XrTableCell28.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell28.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell28.CanGrow = False
        Me.XrTableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.AdditionsAmount", "{0:n2}")})
        Me.XrTableCell28.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell28.StylePriority.UseBorderColor = False
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UseForeColor = False
        Me.XrTableCell28.StylePriority.UsePadding = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.Text = "XrTableCell23"
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell28.Weight = 1.1031507918543186R
        '
        'rowDeductions
        '
        Me.rowDeductions.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell40, Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell31})
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
        Me.XrTableCell40.Weight = 4.3167455160459811R
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
        'XrTableCell31
        '
        Me.XrTableCell31.BorderColor = System.Drawing.Color.DimGray
        Me.XrTableCell31.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell31.CanGrow = False
        Me.XrTableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.DeductionsAmount", "{0:n2}")})
        Me.XrTableCell31.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell31.StylePriority.UseBorderColor = False
        Me.XrTableCell31.StylePriority.UseBorders = False
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UseForeColor = False
        Me.XrTableCell31.StylePriority.UsePadding = False
        Me.XrTableCell31.StylePriority.UseTextAlignment = False
        Me.XrTableCell31.Text = "XrTableCell26"
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell31.Weight = 1.1031507918543186R
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
        Me.lblNetAmountText.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.calcLblNetTotal")})
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
        Me.lblNetAmountText.Weight = 5.9358586655665855R
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
        Me.txtNetAmountSales.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.GrandTotalInOC", "{0:n2}")})
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
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtThanks, Me.XrPageBreak2, Me.txtApprovedBySignature, Me.txtSignatureImage, Me.txtVerifiedSignature, Me.txtCompanySeal, Me.panelAcceptance, Me.panelPreparedBy, Me.panelVerifiedBy, Me.panelApprovedBy, Me.panelAcceptance02})
        Me.ReportFooter.HeightF = 314.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'txtThanks
        '
        Me.txtThanks.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qry604_05PurchaseOrderReport.POThanksNote")})
        Me.txtThanks.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.txtThanks.LocationFloat = New DevExpress.Utils.PointFloat(13.38865!, 3.45841!)
        Me.txtThanks.Multiline = True
        Me.txtThanks.Name = "txtThanks"
        Me.txtThanks.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtThanks.SizeF = New System.Drawing.SizeF(750.2227!, 52.29166!)
        Me.txtThanks.StylePriority.UseFont = False
        Me.txtThanks.StylePriority.UsePadding = False
        '
        'XrPageBreak2
        '
        Me.XrPageBreak2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0.4584045!)
        Me.XrPageBreak2.Name = "XrPageBreak2"
        Me.XrPageBreak2.Visible = False
        '
        'txtApprovedBySignature
        '
        Me.txtApprovedBySignature.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry604_05PurchaseOrderReport.ApprovedImage")})
        Me.txtApprovedBySignature.LocationFloat = New DevExpress.Utils.PointFloat(511.3533!, 19.87514!)
        Me.txtApprovedBySignature.Name = "txtApprovedBySignature"
        Me.txtApprovedBySignature.SizeF = New System.Drawing.SizeF(262.8538!, 110.5833!)
        Me.txtApprovedBySignature.Visible = False
        '
        'txtSignatureImage
        '
        Me.txtSignatureImage.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry604_05PurchaseOrderReport.SignatureImage")})
        Me.txtSignatureImage.LocationFloat = New DevExpress.Utils.PointFloat(10.83262!, 12.87512!)
        Me.txtSignatureImage.Name = "txtSignatureImage"
        Me.txtSignatureImage.SizeF = New System.Drawing.SizeF(294.8833!, 110.5833!)
        '
        'txtVerifiedSignature
        '
        Me.txtVerifiedSignature.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Nothing, "qry604_05PurchaseOrderReport.VerifiedImage")})
        Me.txtVerifiedSignature.LocationFloat = New DevExpress.Utils.PointFloat(253.4166!, 12.87512!)
        Me.txtVerifiedSignature.Name = "txtVerifiedSignature"
        Me.txtVerifiedSignature.SizeF = New System.Drawing.SizeF(294.8833!, 110.5833!)
        Me.txtVerifiedSignature.Visible = False
        '
        'txtCompanySeal
        '
        Me.txtCompanySeal.LocationFloat = New DevExpress.Utils.PointFloat(173.7225!, 0.4584045!)
        Me.txtCompanySeal.Name = "txtCompanySeal"
        Me.txtCompanySeal.SizeF = New System.Drawing.SizeF(302.0834!, 156.0!)
        '
        'panelAcceptance
        '
        Me.panelAcceptance.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrLabel25, Me.XrLabel32, Me.XrLabel33, Me.XrLabel16})
        Me.panelAcceptance.LocationFloat = New DevExpress.Utils.PointFloat(504.4166!, 190.7917!)
        Me.panelAcceptance.Name = "panelAcceptance"
        Me.panelAcceptance.SizeF = New System.Drawing.SizeF(271.1668!, 122.7499!)
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
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(4.028442!, 5.291443!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(264.9289!, 21.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Agreed & Accepted by:"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'panelPreparedBy
        '
        Me.panelPreparedBy.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPreparedName, Me.lblPreparedPosition, Me.lblPreparedContactNo, Me.lblPreparedEmail, Me.lblPreparedBy})
        Me.panelPreparedBy.LocationFloat = New DevExpress.Utils.PointFloat(2.416595!, 77.45844!)
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
        Me.panelVerifiedBy.LocationFloat = New DevExpress.Utils.PointFloat(253.4166!, 78.45844!)
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
        Me.panelApprovedBy.LocationFloat = New DevExpress.Utils.PointFloat(504.4166!, 78.45844!)
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
        'panelAcceptance02
        '
        Me.panelAcceptance02.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.panelAcceptance02.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6})
        Me.panelAcceptance02.LocationFloat = New DevExpress.Utils.PointFloat(0!, 189.7917!)
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
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(148.124!, 1.999985!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(345.2926!, 21.0!)
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
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtSystemTitle, Me.txtUserPrinting, Me.txtPageNumber})
        Me.PageFooter.HeightF = 19.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'txtSystemTitle
        '
        Me.txtSystemTitle.BorderColor = System.Drawing.Color.Empty
        Me.txtSystemTitle.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.txtSystemTitle.ForeColor = System.Drawing.Color.DimGray
        Me.txtSystemTitle.LocationFloat = New DevExpress.Utils.PointFloat(2.416595!, 0!)
        Me.txtSystemTitle.Name = "txtSystemTitle"
        Me.txtSystemTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSystemTitle.SizeF = New System.Drawing.SizeF(277.9597!, 18.0!)
        Me.txtSystemTitle.StylePriority.UseBorderColor = False
        Me.txtSystemTitle.StylePriority.UseFont = False
        Me.txtSystemTitle.StylePriority.UseForeColor = False
        Me.txtSystemTitle.StylePriority.UseTextAlignment = False
        Me.txtSystemTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtUserPrinting
        '
        Me.txtUserPrinting.BorderColor = System.Drawing.Color.Empty
        Me.txtUserPrinting.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.txtUserPrinting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUserPrinting.LocationFloat = New DevExpress.Utils.PointFloat(475.9018!, 0!)
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
        Me.txtPageNumber.LocationFloat = New DevExpress.Utils.PointFloat(313.7766!, 0!)
        Me.txtPageNumber.Name = "txtPageNumber"
        Me.txtPageNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPageNumber.SizeF = New System.Drawing.SizeF(108.0!, 17.0!)
        Me.txtPageNumber.StylePriority.UseFont = False
        Me.txtPageNumber.StylePriority.UseForeColor = False
        Me.txtPageNumber.StylePriority.UseTextAlignment = False
        Me.txtPageNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtPageNumber.TextFormatString = "Page No:{0} of {1}"
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'calLableTotal
        '
        Me.calLableTotal.DataMember = "qry604_05PurchaseOrderReport"
        Me.calLableTotal.Expression = "Concat('Total Amount ' ,[CurrencyCodeFromPOMaster] )"
        Me.calLableTotal.Name = "calLableTotal"
        '
        'calcLblNetTotal
        '
        Me.calcLblNetTotal.DataMember = "qry604_05PurchaseOrderReport"
        Me.calcLblNetTotal.Expression = "Concat('Net Amount ' , [CurrencyCodeFromPOMaster])"
        Me.calcLblNetTotal.Name = "calcLblNetTotal"
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox1.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox1.BorderWidth = 1.0!
        Me.XrCrossBandBox1.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(12.37957!, 3.000005!)
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(12.37957!, 1.041667!)
        Me.XrCrossBandBox1.WidthF = 756.1205!
        '
        'XrCrossBandBox2
        '
        Me.XrCrossBandBox2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox2.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox2.BorderWidth = 1.0!
        Me.XrCrossBandBox2.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox2.EndPointFloat = New DevExpress.Utils.PointFloat(45.96303!, 3.0!)
        Me.XrCrossBandBox2.Name = "XrCrossBandBox2"
        Me.XrCrossBandBox2.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox2.StartPointFloat = New DevExpress.Utils.PointFloat(45.96303!, 1.041667!)
        Me.XrCrossBandBox2.WidthF = 81.15536!
        '
        'XrCrossBandBox3
        '
        Me.XrCrossBandBox3.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox3.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox3.BorderWidth = 1.0!
        Me.XrCrossBandBox3.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox3.EndPointFloat = New DevExpress.Utils.PointFloat(356.4155!, 2.500031!)
        Me.XrCrossBandBox3.Name = "XrCrossBandBox3"
        Me.XrCrossBandBox3.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox3.StartPointFloat = New DevExpress.Utils.PointFloat(356.4155!, 1.041667!)
        Me.XrCrossBandBox3.WidthF = 297.1104!
        '
        'XrCrossBandBox4
        '
        Me.XrCrossBandBox4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox4.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox4.BorderWidth = 1.0!
        Me.XrCrossBandBox4.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox4.EndPointFloat = New DevExpress.Utils.PointFloat(45.07396!, 2.208328!)
        Me.XrCrossBandBox4.Name = "XrCrossBandBox4"
        Me.XrCrossBandBox4.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox4.StartPointFloat = New DevExpress.Utils.PointFloat(45.07396!, 1.041667!)
        Me.XrCrossBandBox4.WidthF = 443.9678!
        '
        'XrCrossBandBox5
        '
        Me.XrCrossBandBox5.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox5.BorderColor = System.Drawing.Color.Gray
        Me.XrCrossBandBox5.BorderWidth = 1.0!
        Me.XrCrossBandBox5.EndBand = Me.GroupFooter2
        Me.XrCrossBandBox5.EndPointFloat = New DevExpress.Utils.PointFloat(421.0499!, 3.0!)
        Me.XrCrossBandBox5.Name = "XrCrossBandBox5"
        Me.XrCrossBandBox5.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox5.StartPointFloat = New DevExpress.Utils.PointFloat(421.0499!, 1.041667!)
        Me.XrCrossBandBox5.WidthF = 138.3771!
        '
        'calcGSDescription
        '
        Me.calcGSDescription.DataMember = "qry604_05PurchaseOrderReport"
        Me.calcGSDescription.Expression = "Iif(IsNullOrEmpty([AddlDescription]), [GSDescrpition], [AddlDescription])"
        Me.calcGSDescription.Name = "calcGSDescription"
        '
        'calcPONo
        '
        Me.calcPONo.DataMember = "qry604_05PurchaseOrderReport"
        Me.calcPONo.Expression = "Concat([PONo], Iif(IsNullOrEmpty([PORevisionNo]), '', [PORevisionNo]) )"
        Me.calcPONo.Name = "calcPONo"
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tableTerms, Me.tableBillToShipTo})
        Me.GroupFooter3.HeightF = 150.0001!
        Me.GroupFooter3.Level = 2
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'tableTerms
        '
        Me.tableTerms.BackColor = System.Drawing.Color.Silver
        Me.tableTerms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tableTerms.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.tableTerms.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tableTerms.LocationFloat = New DevExpress.Utils.PointFloat(13.54167!, 71.00006!)
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
        'tableBillToShipTo
        '
        Me.tableBillToShipTo.BackColor = System.Drawing.Color.Silver
        Me.tableBillToShipTo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tableBillToShipTo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.tableBillToShipTo.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tableBillToShipTo.LocationFloat = New DevExpress.Utils.PointFloat(13.54167!, 0!)
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
        'rpt601_02PurchaseOrderFormatFC
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.GroupFooter1, Me.GroupFooter2, Me.ReportFooter, Me.PageFooter, Me.PageHeader, Me.GroupFooter3})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calLableTotal, Me.calcLblNetTotal, Me.calcGSDescription, Me.calcPONo})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBox5, Me.XrCrossBandBox4, Me.XrCrossBandBox3, Me.XrCrossBandBox2, Me.XrCrossBandBox1})
        Me.DataAdapter = Me.Qry604_05PurchaseOrderReportTableAdapter
        Me.DataMember = "qry604_05PurchaseOrderReport"
        Me.DataSource = Me.DsRpt601_02PurchaseOrderReport1
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 87, 38)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "21.1"
        Me.Watermark.ShowBehind = False
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRpt601_02PurchaseOrderReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tableTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tableBillToShipTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
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
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblSlNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblItemCode As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblUnit As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtUnitPriceText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellDiscountText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtAmtBeforeTaxText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtRecordNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtItemCode As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtStockDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtDiscount As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtAmountInWords As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rowAdditions As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rowDeductions As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNetAmountText As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblColon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtNetAmountSales As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents txtThanks As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageBreak2 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents txtApprovedBySignature As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtSignatureImage As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtVerifiedSignature As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtCompanySeal As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents panelAcceptance As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents panelAcceptance02 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents txtSystemTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtUserPrinting As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPageNumber As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents calLableTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents calcLblNetTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox2 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox3 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox4 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox5 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents calcGSDescription As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents calcPONo As DevExpress.XtraReports.UI.CalculatedField
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
