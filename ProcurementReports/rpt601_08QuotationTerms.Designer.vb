<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt601_08QuotationTerms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt601_08QuotationTerms))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Dsrpt601_08QuotationTerms1 = New ERP.dsrpt601_08QuotationTerms()
        Me.Tbl601_03QuotationTermsTableAdapter = New ERP.dsrpt601_08QuotationTermsTableAdapters.tbl601_03QuotationTermsTableAdapter()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsrpt601_08QuotationTerms1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1})
        Me.Detail.HeightF = 25.08334!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText1
        '
        Me.XrRichText1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "tbl601_03QuotationTerms.ConditionsText")})
        Me.XrRichText1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 0.0!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(733.9999!, 25.08334!)
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Dsrpt601_08QuotationTerms1
        '
        Me.Dsrpt601_08QuotationTerms1.DataSetName = "dsrpt601_08QuotationTerms"
        Me.Dsrpt601_08QuotationTerms1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl601_03QuotationTermsTableAdapter
        '
        Me.Tbl601_03QuotationTermsTableAdapter.ClearBeforeFill = True
        '
        'rpt601_08QuotationTerms
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataAdapter = Me.Tbl601_03QuotationTermsTableAdapter
        Me.DataMember = "tbl601_03QuotationTerms"
        Me.DataSource = Me.Dsrpt601_08QuotationTerms1
        Me.Margins = New System.Drawing.Printing.Margins(20, 20, 0, 0)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.1"
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsrpt601_08QuotationTerms1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents Dsrpt601_08QuotationTerms1 As ERP.dsrpt601_08QuotationTerms
    Friend WithEvents Tbl601_03QuotationTermsTableAdapter As ERP.dsrpt601_08QuotationTermsTableAdapters.tbl601_03QuotationTermsTableAdapter
End Class
