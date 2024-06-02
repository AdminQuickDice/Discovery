Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI

'Imports System
'Imports System.Diagnostics
'Imports System.IO
'Imports System.Windows.Forms
'Imports DevExpress.XtraPrinting
Public Class frm601_38PODiscountDistribution
    Public frm601_38PODiscountDistributionIsClosed As Boolean

    Public objForm As Object

    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public isExecutedFrom_frm601_07PurchaseOrderEdit As Boolean = False

    Private Sub frm601_38PODiscountDistribution_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Retrieve Panel Layout
        'LoadLayoutFromDB_PVG(Me.intLogOnUserID, "frm601_26QuoteCostSummary", Me.pvgProfitLoss)


    End Sub

    Public Sub RetrieveVoucher(ByVal PONo As String)
        Try
            'fill child details in the datagrid
            Me.Qry604_02PurchaseOrderChildTableAdapter.FillByPONo(Me.Dsfrm601_38PODiscountDistribution.qry604_02PurchaseOrderChild, PONo)


        Catch ex As Exception
            MessageBox.Show("Error on Retrieving PO Discount Distribution.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDistributeEqually_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDistributeEqually.ItemClick
        Dim selectedRowHandles As Int32() = gvInvoiceChild.GetSelectedRows()
        If (selectedRowHandles.Count = 0) Then
            MessageBox.Show("No Items are selected for Posting, Please Check again.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.DistributeCost(1)
    End Sub
    Private Sub btnDistributeByProportionately_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDistributeByProportionately.ItemClick
        Dim selectedRowHandles As Int32() = gvInvoiceChild.GetSelectedRows()
        If (selectedRowHandles.Count = 0) Then
            MessageBox.Show("No Items are selected for Posting, Please Check again.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.DistributeCost(2)
    End Sub

    Private Sub btnDistributeByPercentage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDistributeByPercentage.ItemClick
        Dim selectedRowHandles As Int32() = gvInvoiceChild.GetSelectedRows()
        If (selectedRowHandles.Count = 0) Then
            MessageBox.Show("No Items are selected for Posting, Please Check again.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.DistributeCost(3)
    End Sub

    Public Sub UpdateParentEnumerationDetails()
        If isExecutedFrom_frm601_07PurchaseOrderEdit = True Then
            Try
                CType(objForm, frm601_07PurchaseOrderEdit).RetrievePOMaster(Me.PurchaseOrderNo)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Purchase Order Details" & ex.Message)
            End Try
        End If
    End Sub


#Region "Cost Distribution Codes "

    Public PurchaseOrderNo As String = ""

    Private Sub DistributeCost(ByVal DistributionMethod As Integer)
        Try
            'Check if the Cost Group is added already
            Me.DeleteDiscountItems(PurchaseOrderNo)

            Dim view As GridView = gvInvoiceChild
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    PurchaseOrderNo = view.GetRowCellValue(row, view.Columns("PONo"))
                    Dim POChildNo As Integer = view.GetRowCellValue(row, view.Columns("POChildNo"))
                    Dim GSCode As String = view.GetRowCellValue(row, view.Columns("GSCode"))
                    Dim QuotedQuantity As Decimal = view.GetRowCellValue(row, view.Columns("QuotedQuantity"))
                    Dim POUnitPrice As Decimal = view.GetRowCellValue(row, view.Columns("UnitPrice"))
                    Dim LineTotalBeforeTax As Decimal = view.GetRowCellValue(row, view.Columns("LineTotalBeforeTax"))
                    Dim TotalCostOfItemInclAll As Decimal = view.GetRowCellValue(row, view.Columns("LineTotalBeforeTax"))
                    'TotalCostOfItem
                    Me.AddNewItemForDiscountDistribution(PurchaseOrderNo, POChildNo, GSCode, QuotedQuantity, POUnitPrice, Me.txtCostAmount.EditValue, Me.txtCostPercentage.EditValue, "DIS-001", TotalCostOfItemInclAll)
                Next
            End If


            If DistributionMethod = 1 Then 'Distribute Equally
                Me.DiscountByEqual(PurchaseOrderNo)
            ElseIf DistributionMethod = 2 Then   'Distribute Proportionately
                Me.DiscountByProportion(PurchaseOrderNo)
            ElseIf DistributionMethod = 3 Then   'Distribute By Percentage
                Me.DiscountByPercentage(PurchaseOrderNo)
            End If

            Me.Qry604_02PurchaseOrderChildTableAdapter.FillByPONo(Me.Dsfrm601_38PODiscountDistribution.qry604_02PurchaseOrderChild, PurchaseOrderNo)

            MessageBox.Show("Discount has been Sucessfully distributed for the selected Items.", "Discount Distributed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateParentEnumerationDetails()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub AddNewItemForDiscountDistribution(ByVal PONo As String, ByVal POChildNo As Integer, ByVal GSCode As String, ByVal QuoteQty As Decimal, ByVal QuoteCostPrice As Decimal, ByVal PostingAmount As Decimal, ByVal PostingPercentage As Decimal, ByVal PostingCostItemCode As String, ByVal TotalCostOfItem As Decimal)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Insert into tbl604_03PurchaseOrderCostDistribution ( PONo, POChildNo, GSCode, QuotedQuantity, UnitPrice, PostingAmount, PostingPercentage, PostingCostItemCode, TotalCostOfItemInclAll) VALUES ('" & PONo & "', '" & POChildNo & "', '" & GSCode & "', '" & QuoteQty & "', '" & QuoteCostPrice & "', '" & PostingAmount & "' , '" & PostingPercentage & "' , '" & PostingCostItemCode & "' , '" & TotalCostOfItem & "' )"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            'Return 0
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub
    Public Function DeleteDiscountItems(ByVal PONo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Delete from tbl604_03PurchaseOrderCostDistribution where PONo = '" & PONo & "'"

            Dim int1 As Integer
            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText

            int1 = SqlCommand1.ExecuteNonQuery()

            If int1 > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error Occured on Removing Discount Distribution Details" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try
    End Function


    'Add Discount Distributions
    Public Function DiscountByEqual(ByVal PONo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl604_02PurchaseOrderChild Set ItemDiscount = DiscountByEqual  FROM  dbo.tbl604_02PurchaseOrderChild INNER JOIN  dbo.qry604_12PODiscountDistribution02 ON dbo.tbl604_02PurchaseOrderChild.POChildNo = dbo.qry604_12PODiscountDistribution02.POChildNo WHERE (dbo.tbl604_02PurchaseOrderChild.PONo =  '" & PONo & "')"
            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim int1 As Integer = SqlCommand1.ExecuteNonQuery()
            If int1 = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Public Function DiscountByProportion(ByVal PONo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl604_02PurchaseOrderChild Set ItemDiscount = DiscountByProportion  FROM  dbo.tbl604_02PurchaseOrderChild INNER JOIN  dbo.qry604_12PODiscountDistribution02 ON dbo.tbl604_02PurchaseOrderChild.POChildNo = dbo.qry604_12PODiscountDistribution02.POChildNo WHERE (dbo.tbl604_02PurchaseOrderChild.PONo =  '" & PONo & "')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim int1 As Integer = SqlCommand1.ExecuteNonQuery()
            If int1 = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function
    Public Function DiscountByPercentage(ByVal PONo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl604_02PurchaseOrderChild Set ItemDiscount = DiscountByPercentage, DiscountInOC = DiscountByPercentageInOC  FROM  dbo.tbl604_02PurchaseOrderChild INNER JOIN  dbo.qry604_12PODiscountDistribution02 ON dbo.tbl604_02PurchaseOrderChild.POChildNo = dbo.qry604_12PODiscountDistribution02.POChildNo WHERE (dbo.tbl604_02PurchaseOrderChild.PONo =  '" & PONo & "')"

            'strSqlQueryText = "Update tbl601_02QuotationChild Set QuotedDiscount = DiscountByPercentage  FROM  dbo.tbl601_02QuotationChild INNER JOIN  dbo.qry601_21QuoteDistributionMaster02 ON dbo.tbl601_02QuotationChild.QuoteChildID = dbo.qry601_21QuoteDistributionMaster02.QuoteChildID WHERE (QuoteNo =  '" & QuotationNo & "')"
            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim int1 As Integer = SqlCommand1.ExecuteNonQuery()
            If int1 = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function
#End Region


    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub


    '    Private Sub testing()
    '        report.XmlDataPath = "ZUGFeRD-invoice.xml"

    '        Dim additionalMetadata As String = File.ReadAllText("ZUGFeRD_DocumentInfo.txt") & _
    '            File.ReadAllText("ZUGFeRD_PdfASchema.txt")

    '        Dim options As New PdfExportOptions() With {.PdfACompatibility = PdfACompatibility.PdfA3b, _
    '                                                    .AdditionalMetadata = additionalMetadata}



    '        options.Attachments.Add(New PdfAttachment() With {.FilePath = "ZUGFeRD-invoice.xml", _
    '                                                          .Type = "text/xml", _
    '                                                          .Description = "Rechnungsdaten im ZUGFeRD-XML-Format"})

    '        report.ExportToPdf("result.pdf", options)
    '        Process.Start("result.pdf")
    '    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        GenerateGUID()

    End Sub

    Private Sub GenerateGUID()

        Dim sGUID As String
        sGUID = System.Guid.NewGuid.ToString()
        MessageBox.Show(sGUID)

    End Sub
End Class