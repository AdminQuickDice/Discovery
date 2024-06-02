Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_26QuoteCostSummary
    Public frm601_26QuoteCostSummaryIsClosed As Boolean

    Public objForm As Object

    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public isExecutedFrom_frm601_01QuotationEdit As Boolean = False

    Private Sub ucCostAnalysis_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Dsfrm601_26QuoteCostSummary.tbl601_05QuotationCostMaster' table. You can move, or remove it, as needed.
        Me.Tbl601_05QuotationCostMasterTableAdapter.Fill(Me.Dsfrm601_26QuoteCostSummary.tbl601_05QuotationCostMaster)

        'Retrieve Panel Layout
        LoadLayoutFromDB_PVG(Me.intLogOnUserID, "frm601_26QuoteCostSummary", Me.pvgProfitLoss)

        GetCompanyDetails(1)
        If gDefaultCurrencyDecimals = 3 Then


            colCostPrice.DisplayFormat.FormatString = "{0:#,0.000}"

            fieldUnitCostPriceTotal1.CellFormat.FormatString = "{0:#,0.000}"
            fieldUnitCostPriceTotal1.ValueFormat.FormatString = "{0:#,0.000}"
            fieldUnitCostPriceTotal1.TotalCellFormat.FormatString = "{0:#,0.000}"
            fieldUnitCostPriceTotal1.TotalValueFormat.FormatString = "{0:#,0.000}"

            txtCostAmount.Properties.DisplayFormat.FormatString = "{0:#,0.000}"
            txtCostAmount.Properties.EditMask = "###,###,##0.000"

        End If
    End Sub

    Public Sub RetrieveVoucher(ByVal QuotationNo As String)
        Try
            Me.Qry601_20QuotationCostList02TableAdapter.FillByQuoteNo(Me.Dsfrm601_26QuoteCostSummary.qry601_20QuotationCostList02, QuotationNo)

            'fill child details in the datagrid
            Me.Qry601_02QuotationChildTableAdapter.FillByQuoteNo(Me.Dsfrm601_26QuoteCostSummary.qry601_02QuotationChild, QuotationNo)

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Cost Summary Sheet.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_26QuoteCostSummaryIsClosed = True
    End Sub

    Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
        SaveFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            'My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
            Dim fileName As String = Me.SaveFileDialog1.FileName
            Me.pvgProfitLoss.SaveLayoutToXml(fileName)
        End If
    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenLayout.ItemClick
        OpenFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Me.OpenFileDialog1.FileName
            Me.pvgProfitLoss.RestoreLayoutFromXml(fileName)

        End If
    End Sub

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_26QuoteCostSummary"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromPVG(Me.pvgProfitLoss))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromPVG(Me.pvgProfitLoss))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowFields_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroup.ItemClick

        If Me.pvgProfitLoss.OptionsView.ShowDataHeaders = True Then
            Me.pvgProfitLoss.OptionsView.ShowDataHeaders = False
        Else
            Me.pvgProfitLoss.OptionsView.ShowDataHeaders = True
        End If

        If Me.pvgProfitLoss.OptionsView.ShowFilterHeaders = True Then
            Me.pvgProfitLoss.OptionsView.ShowFilterHeaders = False
        Else
            Me.pvgProfitLoss.OptionsView.ShowFilterHeaders = True
        End If
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
        Me.PrintableComponentLink1.PrintingSystem.Document.AutoFitToPagesWidth = 1
    End Sub

    Private Sub btnShowRowTotals_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowRowTotals.ItemClick
        If Me.pvgProfitLoss.OptionsView.ShowRowTotals = True Then
            Me.pvgProfitLoss.OptionsView.ShowRowTotals = False
        Else
            Me.pvgProfitLoss.OptionsView.ShowRowTotals = True
        End If
    End Sub

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_26QuoteCostSummary"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

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
        If isExecutedFrom_frm601_01QuotationEdit = True Then
            Try
                CType(objForm, frm601_01QuotationEdit).RetrieveQuotationMaster(Me.QuotationNo)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Quotation Details" & ex.Message)
            End Try
        End If
    End Sub

#Region "Cost Distribution Codes "

    Public QuotationNo As String = ""

    Private Sub DistributeCost(ByVal DistributionMethod As Integer)
        Try
            'Check if the Cost Group is added already
            Me.DeleteCostItems(QuotationNo)
            Me.DeleteCostDistribution(QuotationNo, Me.txtCostItem.EditValue)

            Dim view As GridView = gvInvoiceChild
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    QuotationNo = view.GetRowCellValue(row, view.Columns("QuoteNo"))
                    Dim QuoteChildID As Integer = view.GetRowCellValue(row, view.Columns("QuoteChildID"))
                    Dim GSCode As String = view.GetRowCellValue(row, view.Columns("GSCode"))
                    Dim QuotedQuantity As Decimal = view.GetRowCellValue(row, view.Columns("QuotedQuantity"))
                    Dim QuotedCostPrice As Decimal = view.GetRowCellValue(row, view.Columns("CostPrice"))
                    Dim TotalCostOfItemInclAll As Decimal = view.GetRowCellValue(row, view.Columns("TotalCostOfItem"))
                    'TotalCostOfItem
                    Me.AddNewItemForCostDistribution(QuotationNo, QuoteChildID, GSCode, QuotedQuantity, QuotedCostPrice, Me.txtCostAmount.EditValue, Me.txtCostPercentage.EditValue, Me.txtCostItem.EditValue, TotalCostOfItemInclAll)
                Next
            End If

            If Me.txtCostItem.EditValue = "PM-001" Then
                If DistributionMethod = 1 Then 'Distribute Equally
                    Me.ProfitMarginByEqual(QuotationNo)
                ElseIf DistributionMethod = 2 Then   'Distribute Proportionately
                    Me.ProfitMarginByProportion(QuotationNo)
                ElseIf DistributionMethod = 3 Then   'Distribute By Percentage
                    Me.ProfitMarginByPercentage(QuotationNo)
                End If

            ElseIf Me.txtCostItem.EditValue = "DIS-001" Then
                If DistributionMethod = 1 Then 'Distribute Equally
                    Me.DiscountByEqual(QuotationNo)
                ElseIf DistributionMethod = 2 Then   'Distribute Proportionately
                    Me.DiscountByProportion(QuotationNo)
                ElseIf DistributionMethod = 3 Then   'Distribute By Percentage
                    Me.DiscountByPercentage(QuotationNo)
                End If

            Else

                If DistributionMethod = 1 Then 'Distribute Equally
                    Me.DistributeEqually(QuotationNo)
                ElseIf DistributionMethod = 2 Then   'Distribute Proportionately
                    Me.DistributeByProportion(QuotationNo)
                ElseIf DistributionMethod = 3 Then   'Distribute By Percentage
                    Me.DistributeByPercentage(QuotationNo)
                End If
            End If
      

            Me.Qry601_02QuotationChildTableAdapter.FillByQuoteNo(Me.Dsfrm601_26QuoteCostSummary.qry601_02QuotationChild, QuotationNo)
            Me.Qry601_20QuotationCostList02TableAdapter.FillByQuoteNo(Me.Dsfrm601_26QuoteCostSummary.qry601_20QuotationCostList02, QuotationNo)

            MessageBox.Show("Cost has been Sucessfully distributed for the selected Items.", "Cost Distributed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateParentEnumerationDetails()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub AddNewItemForCostDistribution(ByVal QuotationNo As String, ByVal QuoteChildID As Integer, ByVal GSCode As String, ByVal QuoteQty As Decimal, ByVal QuoteCostPrice As Decimal, ByVal PostingAmount As Decimal, ByVal PostingPercentage As Decimal, ByVal PostingCostItemCode As String, ByVal TotalCostOfItem As Decimal)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Insert into tbl601_06QuoteCostDistribution (QuotationNo, QuoteChildID, GSCode, QuotedQuantity, QuotedCostPrice, PostingAmount, PostingPercentage, PostingCostItemCode, TotalCostOfItemInclAll) VALUES ('" & QuotationNo & "', '" & QuoteChildID & "', '" & GSCode & "', '" & QuoteQty & "', '" & QuoteCostPrice & "', '" & PostingAmount & "' , '" & PostingPercentage & "' , '" & PostingCostItemCode & "' , '" & TotalCostOfItem & "' )"

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
    Public Function DeleteCostDistribution(ByVal QuotationNo As String, ByVal CostItem As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Delete from tbl601_04QuotationItemCosts where QuoteNo = '" & QuotationNo & "' and CostItemCode = '" & CostItem & "'"

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
            MessageBox.Show("Error Occured on Removing Cost Distribution Details" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Public Function DeleteCostItems(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Delete from tbl601_06QuoteCostDistribution where QuotationNo = '" & QuotationNo & "'"

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
            MessageBox.Show("Error Occured on Removing Cost Distribution Details" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Public Function DistributeEqually(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "INSERT INTO tbl601_04QuotationItemCosts(QuoteChildID, QuoteNo, GSCode, CostItemCode, CostPercentage, CostItemPrice, CostItemQty, AddedBy, AddedOn) SELECT QuoteChildID, QuotationNo, GSCode, PostingCostItemCode, EqualPercentage, EquallyDistributed, 1, '" & Me.strLogOnUser & "', GETDATE() FROM qry601_21QuoteDistributionMaster02 Where QuotationNo = '" & QuotationNo & "'"
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

    Public Function DistributeByProportion(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "INSERT INTO tbl601_04QuotationItemCosts(QuoteChildID, QuoteNo, GSCode, CostItemCode, CostPercentage, CostItemPrice, CostItemQty, AddedBy, AddedOn) SELECT QuoteChildID, QuotationNo, GSCode, PostingCostItemCode, PorpoDistPercentage, PropoDistributed, 1, '" & Me.strLogOnUser & "', GETDATE() FROM qry601_21QuoteDistributionMaster02 Where QuotationNo = '" & QuotationNo & "'"
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

    Public Function DistributeByPercentage(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "INSERT INTO tbl601_04QuotationItemCosts(QuoteChildID, QuoteNo, GSCode, CostItemCode, CostPercentage, CostItemPrice, CostItemQty, AddedBy, AddedOn) SELECT QuoteChildID, QuotationNo, GSCode, PostingCostItemCode, PostingPercentage, DistributedByPercentage, 1, '" & Me.strLogOnUser & "', GETDATE() FROM qry601_21QuoteDistributionMaster02 Where QuotationNo = '" & QuotationNo & "'"
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


    'Add Profit Margin Distributions
    Public Function ProfitMarginByPercentage(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl601_02QuotationChild Set QuotedUnitPrice = ProfitMarginPerItemByPercentage FROM  dbo.tbl601_02QuotationChild INNER JOIN  dbo.qry601_23QuoteDistributionOfProfitMargin ON dbo.tbl601_02QuotationChild.QuoteChildID = dbo.qry601_23QuoteDistributionOfProfitMargin.QuoteChildID WHERE (QuoteNo = '" & QuotationNo & "')"
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

    Public Function ProfitMarginByProportion(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl601_02QuotationChild Set QuotedUnitPrice = ProfitMarginPerItemByProportion FROM  dbo.tbl601_02QuotationChild INNER JOIN  dbo.qry601_23QuoteDistributionOfProfitMargin ON dbo.tbl601_02QuotationChild.QuoteChildID = dbo.qry601_23QuoteDistributionOfProfitMargin.QuoteChildID WHERE (QuoteNo = '" & QuotationNo & "')"
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


    Public Function ProfitMarginByEqual(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl601_02QuotationChild Set QuotedUnitPrice = ProfitMarginPerItemByEqual FROM  dbo.tbl601_02QuotationChild INNER JOIN  dbo.qry601_23QuoteDistributionOfProfitMargin ON dbo.tbl601_02QuotationChild.QuoteChildID = dbo.qry601_23QuoteDistributionOfProfitMargin.QuoteChildID WHERE (QuoteNo = '" & QuotationNo & "')"
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


    'Add Discount Distributions
    Public Function DiscountByEqual(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl601_02QuotationChild Set QuotedDiscount = DiscountByEqual  FROM  dbo.tbl601_02QuotationChild INNER JOIN  dbo.qry601_21QuoteDistributionMaster02 ON dbo.tbl601_02QuotationChild.QuoteChildID = dbo.qry601_21QuoteDistributionMaster02.QuoteChildID WHERE (QuoteNo =  '" & QuotationNo & "')"
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

    Public Function DiscountByProportion(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl601_02QuotationChild Set QuotedDiscount = DiscountByProportion  FROM  dbo.tbl601_02QuotationChild INNER JOIN  dbo.qry601_21QuoteDistributionMaster02 ON dbo.tbl601_02QuotationChild.QuoteChildID = dbo.qry601_21QuoteDistributionMaster02.QuoteChildID WHERE (QuoteNo =  '" & QuotationNo & "')"
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
    Public Function DiscountByPercentage(ByVal QuotationNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Update tbl601_02QuotationChild Set QuotedDiscount = DiscountByPercentage  FROM  dbo.tbl601_02QuotationChild INNER JOIN  dbo.qry601_21QuoteDistributionMaster02 ON dbo.tbl601_02QuotationChild.QuoteChildID = dbo.qry601_21QuoteDistributionMaster02.QuoteChildID WHERE (QuoteNo =  '" & QuotationNo & "')"
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
  
    Private Sub txtCostItem_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCostItem.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm600_10QuotationCostItems As New frm600_10QuotationCostItems
            frm600_10QuotationCostItems.ObjForm = Me
            frm600_10QuotationCostItems.Show()
            frm600_10QuotationCostItems.txtCostItem.Focus()
            frm600_10QuotationCostItems.isExecutedFrom_frm601_26QuoteCostSummary = True
        End If
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub
End Class