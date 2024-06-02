
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_21InventoryUploading
    Public frm601_21InventoryUploadingIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String = ""
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Public ObjForm As Object
    Public isExecutedFrom_frm601_11PurchaseRequestEdit As Boolean = False
    Public isExecutedFrom_frm00102eInvSalesInvoiceEdit As Boolean = False
    Public isExecutedFrom_frm20181ProformaInvoiceEdit As Boolean = False
    Public isExecutedFrom_frm20164VATPurchaseEdit As Boolean = False
    '


    Private Sub frm601_21InventoryUploading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl20165GoodsAndServicesGroupTableAdapter.Fill(Me.Dsfrm600_01InventoryStockEdit.tbl20165GoodsAndServicesGroup)
        Me.Tbl600_05InventoryUploadTableAdapter.Fill(Me.Dsfrm601_21InventoryLoading.tbl600_05InventoryUpload)

    End Sub

    Private Sub SaveData()
        Me.Validate()
        Me.Tbl60005InventoryUploadBindingSource.EndEdit()
        Me.Tbl600_05InventoryUploadTableAdapter.Update(Me.Dsfrm601_21InventoryLoading.tbl600_05InventoryUpload)
    End Sub

    Private Sub RefreshData()
        Me.Tbl600_05InventoryUploadTableAdapter.Fill(Me.Dsfrm601_21InventoryLoading.tbl600_05InventoryUpload)
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick

        SaveData()
        RefreshData()

    End Sub

    Private tblInventoryUpload As DataTable

    Private Sub btnPasteFromExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPasteFromExcel.ItemClick
        Try
            tblInventoryUpload = New DataTable

            'Dim dt As DataTable
            tblInventoryUpload = Me.Dsfrm601_21InventoryLoading.Tables("tbl600_05InventoryUpload")

            Dim data() As String = ClipboardData.Split(ControlChars.Lf)
            If data.Length < 1 Then
                Return
            End If
            For Each row As String In data
                AddRow(row)
            Next row
        Catch ex As Exception
            MessageBox.Show("Error on Copying Excel Data...Please try again.", "Error on Uploading Data from Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Private Property ClipboardData() As String
        Get
            Dim iData As IDataObject = Clipboard.GetDataObject()
            If iData Is Nothing Then
                Return ""
            End If

            'If iData.GetDataPresent(DataFormats.Text) Then
            '    Return CStr(iData.GetData(DataFormats.Text))
            'End If
            'Return ""

            If iData.GetDataPresent(DataFormats.UnicodeText) Then
                Return DirectCast(iData.GetData(DataFormats.UnicodeText), String)
            End If
            Return ""

        End Get
        Set(ByVal value As String)
            Clipboard.SetDataObject(value)
        End Set
    End Property

    Private Sub AddRow(ByVal data As String)
        Try
            If data = String.Empty Then
                Return
            End If
            Dim rowData() As String = data.Split(New Char() {ControlChars.Cr, ChrW(&H9)})
            Dim newRow As DataRow = tblInventoryUpload.NewRow()
            For i As Integer = 0 To rowData.Length - 1
                If i >= tblInventoryUpload.Columns.Count Then
                    Exit For
                End If
                newRow(i) = rowData(i)
            Next i
            tblInventoryUpload.Rows.Add(newRow)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUploadStocks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUploadStocks.ItemClick
        'Get Last Group Code
        'Get Last Unit Code
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtGSGroup.EditValue)) Then
            MessageBox.Show("Please Select Stock Group before Uploading...", "Select Stock Group", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            SaveData()
            Dim GSGroupCode As String = Me.GetUnitCode(Me.txtGSGroup.EditValue)

            Try
                Me.UploadStock(GSGroupCode, Me.GetLastGSCode(GSGroupCode), Me.GetLastUnitCode(), strLogOnUser, Date.Now, Me.txtRequestNo.EditValue, Me.txtGSGroup.EditValue)
                MessageBox.Show("Stock List has been Updated Successfully.", "Data Upload Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
                RefreshRequestChildDataGrid()
                Me.Close()

            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try
     

    End Sub

    Private Sub RefreshRequestChildDataGrid()
        If isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
            Try
                CType(ObjForm, frm601_11PurchaseRequestEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(ObjForm, frm601_11PurchaseRequestEdit).Dsfrm601_11PurchaseRequestEdit3.tbl40111PropertyUnitCodes)
                CType(ObjForm, frm601_11PurchaseRequestEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(ObjForm, frm601_11PurchaseRequestEdit).Dsfrm601_11PurchaseRequestEdit2.tbl20164GoodsAndServicesMaster)
                CType(ObjForm, frm601_11PurchaseRequestEdit).SaveAll(False)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Material Request List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If isExecutedFrom_frm00102eInvSalesInvoiceEdit = True Then
            Try

                'Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm00102eInvSalesInvoiceEdit.tbl20164GoodsAndServicesMaster)

                CType(ObjForm, frm00102eInvSalesInvoiceEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(ObjForm, frm00102eInvSalesInvoiceEdit).Dsfrm00102eInvSalesInvoiceEdit.tbl40111PropertyUnitCodes)
                CType(ObjForm, frm00102eInvSalesInvoiceEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(ObjForm, frm00102eInvSalesInvoiceEdit).Dsfrm00102eInvSalesInvoiceEdit.tbl20164GoodsAndServicesMaster)
                CType(ObjForm, frm00102eInvSalesInvoiceEdit).SaveAll(False)
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Invoice Items List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        '
        If isExecutedFrom_frm20181ProformaInvoiceEdit = True Then
            Try
                CType(ObjForm, frm20181ProformaInvoiceEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(ObjForm, frm20181ProformaInvoiceEdit).Dsfrm20183ProInvoiceEdit.tbl40111PropertyUnitCodes)
                CType(ObjForm, frm20181ProformaInvoiceEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(ObjForm, frm20181ProformaInvoiceEdit).Dsfrm20183ProInvoiceEdit.tbl20164GoodsAndServicesMaster)
                CType(ObjForm, frm20181ProformaInvoiceEdit).SaveAll(False)

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Proforma Items List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        '
        If isExecutedFrom_frm20164VATPurchaseEdit = True Then
            Try

                CType(ObjForm, frm20164VATPurchaseEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(ObjForm, frm20164VATPurchaseEdit).Dsfrm20164VATPurchaseEdit.tbl40111PropertyUnitCodes)
                CType(ObjForm, frm20164VATPurchaseEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(ObjForm, frm20164VATPurchaseEdit).Dsfrm20164VATPurchaseEdit.tbl20164GoodsAndServicesMaster)
                CType(ObjForm, frm20164VATPurchaseEdit).SaveAll(False)

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the VAT Purchase Items List." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub UploadStock(ByVal StockGroupCode As String, ByVal LastNoInStockGroup As Integer, ByVal LastNoInUnit As Integer, ByVal AddedBy As String, ByVal AddedOn As Date, ByVal MPRNo As String, ByVal GSGroupID As Integer)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_21InventoryUploading"
            Dim paramStockGroupCode As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@StockGroupCode", SqlDbType.VarChar)
            Dim paramLastNoInStockGroup As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@LastNoInStockGroup", SqlDbType.Int)
            Dim paramLastNoInUnit As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@LastNoInUnit", SqlDbType.TinyInt)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramAddedOn As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime)
            Dim paramMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRNo", SqlDbType.VarChar)
            Dim paramGSGroupID As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@GSGroupID", SqlDbType.TinyInt)

            paramStockGroupCode.Value = StockGroupCode
            paramLastNoInStockGroup.Value = LastNoInStockGroup
            paramLastNoInUnit.Value = LastNoInUnit
            paramAddedBy.Value = AddedBy
            paramAddedOn.Value = AddedOn
            paramMPRNo.Value = MPRNo
            paramGSGroupID.Value = GSGroupID

            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            MessageBox.Show("Stock List has been Updated Failed.", "Data Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub UploadStockToInvoice(ByVal StockGroupCode As String, ByVal LastNoInStockGroup As Integer, ByVal LastNoInUnit As Integer, ByVal AddedBy As String, ByVal AddedOn As Date, ByVal InvoiceNo As String, ByVal GSGroupID As Integer)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_21InventoryUploadingToInvoice"
            Dim paramStockGroupCode As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@StockGroupCode", SqlDbType.VarChar)
            Dim paramLastNoInStockGroup As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@LastNoInStockGroup", SqlDbType.Int)
            Dim paramLastNoInUnit As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@LastNoInUnit", SqlDbType.TinyInt)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramAddedOn As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime)
            Dim paramInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@InvoiceNo", SqlDbType.VarChar)
            Dim paramGSGroupID As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@GSGroupID", SqlDbType.TinyInt)

            paramStockGroupCode.Value = StockGroupCode
            paramLastNoInStockGroup.Value = LastNoInStockGroup
            paramLastNoInUnit.Value = LastNoInUnit
            paramAddedBy.Value = AddedBy
            paramAddedOn.Value = AddedOn
            paramInvoiceNo.Value = InvoiceNo
            paramGSGroupID.Value = GSGroupID

            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            MessageBox.Show("Stock List has been Updated Failed.", "Data Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public Function GetUnitCode(ByVal UnitID As Integer) As String
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select GSGroupCode from tbl20165GoodsAndServicesGroup Where GSGroupID = " & UnitID & ""

            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    If CheckIfNull(srStockReader.Item("GSGroupCode")) = False Then
                        Return srStockReader.Item("GSGroupCode") & ""
                    Else
                        Return ""
                    End If
                End While
            Else
                Return ""
            End If
            srStockReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return ""
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Public Function GetLastGSCode(ByVal GSGroupCode As String) As Integer
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(cast(Right(GSCode,5) as int)) from tbl20164GoodsAndServicesMaster Where (GSCode LIKE '" & GSGroupCode & "-%')"

            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()

            Return int1

        Catch ex As System.InvalidCastException
            Return 0
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Public Function GetLastUnitCode() As Integer
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select max(UnitCode) from tbl40111PropertyUnitCodes"

            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()

            Return int1

        Catch ex As System.InvalidCastException
            Return 0
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub btnUploadStocksToInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUploadStocksToInvoice.ItemClick
        'Get Last Group Code
        'Get Last Unit Code
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtGSGroup.EditValue)) Then
            MessageBox.Show("Please Select Stock Group before Uploading...", "Select Stock Group", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            SaveData()
            Dim GSGroupCode As String = Me.GetUnitCode(Me.txtGSGroup.EditValue)

            Try
                Me.UploadStockToInvoice(GSGroupCode, Me.GetLastGSCode(GSGroupCode), Me.GetLastUnitCode(), strLogOnUser, Date.Now, Me.txtInvoiceNo.EditValue, Me.txtGSGroup.EditValue)
                MessageBox.Show("Stock List has been Updated to Invoice Successfully.", "Data Upload Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
                RefreshRequestChildDataGrid()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error on Uploading Stock Items to Invoice" & vbCrLf & ex.Message, "Error on Uploading Stock Items", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Catch ex As Exception
            MessageBox.Show("Error on Uploading Stock Items to Invoice (Geting Unit Codes)" & vbCrLf & ex.Message, "Error on Uploading Stock Items", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnUploadStocksToProformaInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUploadStocksToProformaInvoice.ItemClick
        'Get Last Group Code
        'Get Last Unit Code
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtGSGroup.EditValue)) Then
            MessageBox.Show("Please Select Stock Group before Uploading...", "Select Stock Group", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            SaveData()
            Dim GSGroupCode As String = Me.GetUnitCode(Me.txtGSGroup.EditValue)

            Try
                Me.UploadStockToProformaInvoice(GSGroupCode, Me.GetLastGSCode(GSGroupCode), Me.GetLastUnitCode(), strLogOnUser, Date.Now, Me.txtProformaInvoiceNo.EditValue, Me.txtGSGroup.EditValue)
                MessageBox.Show("Stock List has been Updated to Invoice Successfully.", "Data Upload Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
                RefreshRequestChildDataGrid()
                Me.Close()

            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub UploadStockToProformaInvoice(ByVal StockGroupCode As String, ByVal LastNoInStockGroup As Integer, ByVal LastNoInUnit As Integer, ByVal AddedBy As String, ByVal AddedOn As Date, ByVal ProformaInvoiceNo As String, ByVal GSGroupID As Integer)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_21InventoryUploadingToProformaInvoice"
            Dim paramStockGroupCode As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@StockGroupCode", SqlDbType.VarChar)
            Dim paramLastNoInStockGroup As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@LastNoInStockGroup", SqlDbType.Int)
            Dim paramLastNoInUnit As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@LastNoInUnit", SqlDbType.TinyInt)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramAddedOn As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime)
            Dim paramProformaInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ProformaInvoiceNo", SqlDbType.VarChar)
            Dim paramGSGroupID As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@GSGroupID", SqlDbType.TinyInt)

            paramStockGroupCode.Value = StockGroupCode
            paramLastNoInStockGroup.Value = LastNoInStockGroup
            paramLastNoInUnit.Value = LastNoInUnit
            paramAddedBy.Value = AddedBy
            paramAddedOn.Value = AddedOn
            paramProformaInvoiceNo.Value = ProformaInvoiceNo
            paramGSGroupID.Value = GSGroupID

            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            MessageBox.Show("Stock List has been Updated Failed.", "Data Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnUploadStocksToVATPurchaseVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUploadStocksToVATPurchaseVoucher.ItemClick
        'Get Last Group Code
        'Get Last Unit Code
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtGSGroup.EditValue)) Then
            MessageBox.Show("Please Select Stock Group before Uploading...", "Select Stock Group", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            SaveData()
            Dim GSGroupCode As String = Me.GetUnitCode(Me.txtGSGroup.EditValue)

            Try
                Me.UploadStockToVATPurchaseVoucher(GSGroupCode, Me.GetLastGSCode(GSGroupCode), Me.GetLastUnitCode(), strLogOnUser, Date.Now, Me.txtVATPurchaseVoucherNo.EditValue, Me.txtGSGroup.EditValue)
                MessageBox.Show("Stock List has been Updated to VAT Purchase Voucher Successfully.", "Data Upload Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
                RefreshRequestChildDataGrid()
                Me.Close()

            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub UploadStockToVATPurchaseVoucher(ByVal StockGroupCode As String, ByVal LastNoInStockGroup As Integer, ByVal LastNoInUnit As Integer, ByVal AddedBy As String, ByVal AddedOn As Date, ByVal VATPurchaseVoucherNo As String, ByVal GSGroupID As Integer)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_21InventoryUploadingToVATPurchaseVoucherNo"
            Dim paramStockGroupCode As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@StockGroupCode", SqlDbType.VarChar)
            Dim paramLastNoInStockGroup As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@LastNoInStockGroup", SqlDbType.Int)
            Dim paramLastNoInUnit As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@LastNoInUnit", SqlDbType.TinyInt)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)
            Dim paramAddedOn As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedOn", SqlDbType.DateTime)
            Dim paramProformaInvoiceNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@VATPurchaseVoucherNo", SqlDbType.VarChar)
            Dim paramGSGroupID As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@GSGroupID", SqlDbType.TinyInt)

            paramStockGroupCode.Value = StockGroupCode
            paramLastNoInStockGroup.Value = LastNoInStockGroup
            paramLastNoInUnit.Value = LastNoInUnit
            paramAddedBy.Value = AddedBy
            paramAddedOn.Value = AddedOn
            paramProformaInvoiceNo.Value = VATPurchaseVoucherNo
            paramGSGroupID.Value = GSGroupID

            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            MessageBox.Show("Stock List has been Updated Failed.", "Data Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()
    End Sub
End Class