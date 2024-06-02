Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI

Public Class frm601_04A_SalesOrderStoreAvailability
    Public frm601_04A_SalesOrderStoreAvailabilityIsClosed As Boolean

    Public objForm As Object

    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Public intLogOnInventoryAccessLevel As Integer
    Public intLogOnInventoryMPRAccessLevel As Integer

    Public isExecutedFrom_frm601_03SalesOrderEdit As Boolean = False
    Public isExecutedFrom_frm601_04SalesOrderView As Boolean = False
    '

    Public SalesOrderNo As String = ""

    Private Sub ucCostAnalysis_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Tbl600_01StoreMasterTableAdapter.Fill(Me.Dsfrm601_04A_SalesOrderStoreAvailability1.tbl600_01StoreMaster)


        RetrieveVoucher(SalesOrderNo)
        'Retrieve Panel Layout
        LoadLayoutFromDB_PVG(Me.intLogOnUserID, "frm601_04A_SalesOrderStoreAvailability_Pivot", Me.pvgProfitLoss)
        LoadLayoutFromDB(Me.intLogOnUserID, "frm601_04A_SalesOrderStoreAvailability_Grid", Me.gvStockAvailabilityInStore)

    End Sub

    Public Sub InsertStoreInventoryValueByDate(ByVal StartDate As Date, ByVal EndDate As Date)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp653_01InsertStoreInvTransByDate"
            Dim paramStartDate As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@StartDate", SqlDbType.DateTime)
            Dim paramEndDate As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@EndDate", SqlDbType.DateTime)

            paramStartDate.Value = StartDate
            paramEndDate.Value = EndDate
            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            'MessageBox.Show("Quotation Line Item Delete failed, Please try again", "Data Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public Sub RetrieveVoucher(ByVal SalesOrderNo As String)
        Try
            Me.InsertStoreInventoryValueByDate("2001-01-01", Today.AddHours(23))

            Me.Qry653_20StoreStockAvaliabilityForSalesOrderTableAdapter.FillBySalesOrder(Me.Dsfrm601_04A_SalesOrderStoreAvailability.qry653_20StoreStockAvaliabilityForSalesOrder, SalesOrderNo)

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Stock Availability for the Sales Order.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_04A_SalesOrderStoreAvailabilityIsClosed = True
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
            Dim formID As String = "frm601_04A_SalesOrderStoreAvailability_Pivot"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromPVG(Me.pvgProfitLoss))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromPVG(Me.pvgProfitLoss))
            End If

            Dim formID2 As String = "frm601_04A_SalesOrderStoreAvailability_Grid"
            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID2) = True Then
                UpdateXmlLayout(formID2, Me.intLogOnUserID, GetStringFromView(Me.gvStockAvailabilityInStore))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID2, GetStringFromView(Me.gvStockAvailabilityInStore))
            End If


            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowFields_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowFields.ItemClick

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
            Dim formID As String = "frm601_04A_SalesOrderStoreAvailability_Pivot"
            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)
                'MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.Close()
            End If

            Dim formID2 As String = "frm601_04A_SalesOrderStoreAvailability_Grid"
            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID2) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID2)

            End If

            MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtStoreCode_EditValueChanged(sender As Object, e As EventArgs) Handles txtStoreCode.EditValueChanged

        Try
            'Updates Deliverying Qty
            Me.UpdateDeliveringQtyFromStoreAvailability(SalesOrderNo, Me.txtStoreCode.EditValue)

            Me.Qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter.Fill(Me.Dsfrm601_04A_SalesOrderStoreAvailability2.qry653_20StoreStockAvaliabilityForSalesOrder1, SalesOrderNo, Me.txtStoreCode.EditValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvStockAvailabilityInStore_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvStockAvailabilityInStore.CellValueChanged
        Try
            If e.Column.Name = "colDeliveringQuantity" Then
                If e.Value = 0 Then
                    Exit Sub
                End If

                Dim EnteredQty As Decimal = e.Value
                Dim CurrentQty As Decimal = gvStockAvailabilityInStore.GetRowCellValue(e.RowHandle, gvStockAvailabilityInStore.Columns("CurrentQtyInOrderedUnit"))
                Dim BalanceToOrder As Decimal = gvStockAvailabilityInStore.GetRowCellValue(e.RowHandle, gvStockAvailabilityInStore.Columns("BalanceToDeliver"))

                Dim IsServiceGroup As Boolean = gvStockAvailabilityInStore.GetRowCellValue(e.RowHandle, gvStockAvailabilityInStore.Columns("IsServicesGroup"))

                If e.Value < 0 Then
                    MessageBox.Show("You cannot Issue Quantity in negative.", "Negative Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    gvStockAvailabilityInStore.SetRowCellValue(e.RowHandle, gvStockAvailabilityInStore.Columns("DeliveringQuantity"), 0)
                End If

                If IsServiceGroup = True Then
                    'if the item is service
                    If EnteredQty <= BalanceToOrder Then

                    Else
                        MessageBox.Show("Entered Service Quantity for this Item is more than the Balance in Ordered Qty : " & Format(BalanceToOrder, "###,###,##0.00##") & vbCrLf & "Please check the Quantity Balance in Order.", "Balance in Order is Less", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        gvStockAvailabilityInStore.SetRowCellValue(e.RowHandle, gvStockAvailabilityInStore.Columns("DeliveringQuantity"), BalanceToOrder)

                    End If
                Else
                    'if the item is not services
                    If EnteredQty <= BalanceToOrder Then
                        If EnteredQty > CurrentQty Then
                            MessageBox.Show("Current Quantity for this Item is :" & Format(CurrentQty, "###,###,##0.00##") & vbCrLf & "less than Issuing Quantity," & vbCrLf & "Please check the Quantity avaliable in hand.", "Current Quantity is Less", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            gvStockAvailabilityInStore.SetRowCellValue(e.RowHandle, gvStockAvailabilityInStore.Columns("DeliveringQuantity"), CurrentQty)

                        End If

                    Else
                        MessageBox.Show("Entered Quantity for this Item is more than the Balance in Ordered Qty : " & Format(BalanceToOrder, "###,###,##0.00##") & vbCrLf & "Please check the Quantity Balance in Order.", "Balance in Order is Less", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        gvStockAvailabilityInStore.SetRowCellValue(e.RowHandle, gvStockAvailabilityInStore.Columns("DeliveringQuantity"), BalanceToOrder)

                    End If

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnShowDeliveryNotes_Click(sender As Object, e As EventArgs) Handles btnPrepareDeliveryNote.Click
        'Check if the Items are fully delivered already for this Sales Order

        If frm601_04SalesOrderView.CheckSalesOrderDeliveryStatus(SalesOrderNo) = "Fully Delivered" Then
            MessageBox.Show("Sales Order is fully Delivered, you cannot create Delivery for this Order anymore, Please review again.", "Sales Order status is Fully Delivered.", MessageBoxButtons.OK)
            Exit Sub
        End If

        'If Me.CheckStockAvailabilityStatus(SalesOrderNo, Me.txtStoreCode.EditValue) = True Then
        '    MessageBox.Show("Store doesnt have stock for issuing this Order, you cannot create Delivery for this Order Please review again.", "Stock Not Available", MessageBoxButtons.OK)
        '    Exit Sub
        'End If

        DialogResult = MessageBox.Show("You are about to create new Delivery Note." & vbCrLf & "Are you Sure want to continue creating Delivery Note?", "Confirm creating Delivery Note.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(SalesOrderNo) = False Then

                'Get New Delivery Note Number
                GetCompanyDetails(1)
                Dim NewDeliveryNoteNo As String = frm601_05DeliveryNoteEdit.GetNewDeliveryNoteNo(gDeliveryNoteAbbrv, gInvoiceYearDigits, gNoOfDigitsToDeliveryNote, Date.Now, gIsResetDeliverInYear)

                Me.UpdateDeliveringQty()

                Me.CreatePartialDeliveryFromStoreAvailability(NewDeliveryNoteNo, 1, SalesOrderNo, Me.strLogOnUser, Me.txtStoreCode.EditValue)
                Me.OpenDeliveryNote(NewDeliveryNoteNo)

                'Refresh the datagrid
                ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)
                RefreshMainScreen()

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub RefreshMainScreen()
        If isExecutedFrom_frm601_04SalesOrderView = True Then
            Try
                CType(objForm, frm601_04SalesOrderView).RetrieveVoucher(CType(objForm, frm601_04SalesOrderView).txtStartDate.EditValue, CType(objForm, frm601_04SalesOrderView).txtEndDate.EditValue)
                GoBackToRow(CType(objForm, frm601_04SalesOrderView).gvAdvBandedQuotationView, "SalesOrderNo", Me.SalesOrderNo)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Sales Order Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub OpenDeliveryNote(ByVal DeliveryNoteNo As String)
        If CheckIfNull(DeliveryNoteNo) = False Then
            Dim frm601_05DeliveryNoteEdit As New frm601_05DeliveryNoteEdit
            frm601_05DeliveryNoteEdit.ObjForm = Me
            frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
            frm601_05DeliveryNoteEdit.btnSave.Caption = "Update"

            frm601_05DeliveryNoteEdit.strLogonUser = Me.strLogOnUser
            frm601_05DeliveryNoteEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_05DeliveryNoteEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_05DeliveryNoteEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_05DeliveryNoteEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_05DeliveryNoteEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_05DeliveryNoteEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_05DeliveryNoteEdit.isExecutedFrom_frm601_04A_SalesOrderStoreAvailability = True

            ''Post all the Average Cost Price of the Items in the Delivery Note and Update it
            'UpdateAvgCostPriceInDeliveryNote(Me.SelectedDeliveryNoteNo, Me.SelectedDeliveryNoteDate)


            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = True
            Else
                frm601_05DeliveryNoteEdit.txtSalesPerson.Enabled = False
            End If

            frm601_05DeliveryNoteEdit.Show()
            frm601_05DeliveryNoteEdit.RetrieveDeliveryMaster(DeliveryNoteNo)

            frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
            frm601_05DeliveryNoteEdit.DisableApprovedVoucherEditing(DeliveryNoteNo)
            frm601_05DeliveryNoteEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

            frm601_05DeliveryNoteEdit.txtStoreIssuedFrom.Enabled = False

            'Dim SelectedDeliveryNoteType As Integer = 1

            'If SelectedDeliveryNoteType = 4 Then
            '    GetCompanyDetails02(1)
            '    If gIsStoreWiseDelivery = True Then
            '        Try
            '            Dim EndDate As Date = Me.SelectedDeliveryNoteDate
            '            frm601_05DeliveryNoteEdit.InsertStoreInventoryValueByDate("2001-01-01", EndDate.AddHours(23))
            '            frm601_05DeliveryNoteEdit.Qry653_20StoreStockBalanceWtStoreCodeTableAdapter.FillByStoreCode(frm601_05DeliveryNoteEdit.Dsfrm601_01QuotationEdit1.qry653_20StoreStockBalanceWtStoreCode, frm601_05DeliveryNoteEdit.txtStoreIssuedFrom.EditValue)

            '            frm601_05DeliveryNoteEdit.colDetailedDescription.Visible = False

            '            frm601_05DeliveryNoteEdit.colStockDescriptionWtStores.VisibleIndex = 3
            '            frm601_05DeliveryNoteEdit.colStockDescriptionWtStores.Visible = True

            '            frm601_05DeliveryNoteEdit.txtStoreIssuedFrom.Enabled = False
            '        Catch ex As Exception

            '        End Try
            '    End If
            'End If

        End If
    End Sub

    Private Sub CreatePartialDeliveryFromStoreAvailability(ByVal DeliveryNoteNo As String, ByVal DeliveryType As Integer, ByVal SalesOrderNo As String, ByVal AddedBy As String, ByVal StoreIssuedFrom As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "[sp600_07aInsertPartialDeliveryFromStoreAvailability]"
            Dim paramDeliveryNoteNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryNoteNo", SqlDbType.VarChar)
            Dim paramDeliveryType As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@DeliveryType", SqlDbType.TinyInt)
            Dim paramSalesOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramStoreIssuedFrom As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@StoreIssuedFrom", SqlDbType.VarChar)

            paramDeliveryNoteNo.Value = DeliveryNoteNo
            paramDeliveryType.Value = DeliveryType
            paramSalesOrderNo.Value = SalesOrderNo
            paramAddedBy.Value = AddedBy
            paramStoreIssuedFrom.Value = StoreIssuedFrom

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Delivery Note is created successfully,", "Delivery Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Delivery Note Creation failed, Please try again", "Delivery Note Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public Function CheckStockAvailabilityStatus(ByVal SalesOrderNo As String, ByVal StoreCode As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "SELECT SalesOrderNo FROM qry653_20StoreStockAvaliabilityForSalesOrder WHERE 
                        (SalesOrderNo = '" & SalesOrderNo & "') AND (StoreCode = '" & StoreCode & "') AND (AvailabilityStatus = 'No Stock Available')"

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = strSqlQueryText
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                Return True
            Else
                Return False
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try

    End Function

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()

    End Sub

    Private Sub UpdateDeliveringQty()
        Try
            Me.Qry65320StoreStockAvaliabilityForSalesOrder1BindingSource.EndEdit()
            Me.Qry653_20StoreStockAvaliabilityForSalesOrder1TableAdapter.Update(Me.Dsfrm601_04A_SalesOrderStoreAvailability2.qry653_20StoreStockAvaliabilityForSalesOrder1)


        Catch ex As Exception

        End Try

    End Sub

    Private Sub UpdateDeliveringQtyFromStoreAvailability(ByVal SalesOrderNo As String, ByVal StoreIssuedFrom As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "[sp600_07bUpdateDeliveryQtyFromStoreAvailability]"
            Dim paramSalesOrderNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@SalesOrderNo", SqlDbType.VarChar)
            Dim paramStoreIssuedFrom As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@StoreIssuedFrom", SqlDbType.VarChar)

            paramSalesOrderNo.Value = SalesOrderNo
            paramStoreIssuedFrom.Value = StoreIssuedFrom

            SqlCommand1.ExecuteNonQuery()
            'MessageBox.Show("New Delivery Note is created successfully,", "Delivery Note created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Delivering Quantity Details update failed, Please try again", "Delivering Quantity Update failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

End Class