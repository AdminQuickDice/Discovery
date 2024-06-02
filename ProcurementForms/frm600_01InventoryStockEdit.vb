Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu

Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.Data.SqlTypes
Imports System.IO

Imports System.Globalization
Imports System.Threading
Imports System.Xml

Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraReports.UI

Imports System.Security
Imports DevExpress.Pdf

Public Class frm600_01InventoryStockEdit
    Public objForm As Object

    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer

    Public intLogOnInventoryMPRAccessLevel As Integer

    Private NewStockNo As String = ""

    Public isExecutedFrom_frm600_02InventoryStockView As Boolean = False

    Public isExecutedFrom_frm601_11PurchaseRequestEdit As Boolean = False
    Public isExecutedFrom_frm601_01QuotationEdit As Boolean = False
    Public isExecutedFrom_frm601_03SalesOrderEdit As Boolean = False
    Public isExecutedFrom_frm601_05DeliveryNoteEdit As Boolean = False

    Public isExecutedFrom_frm601_13RFQMaster As Boolean = False
    Public isExecutedFrom_frm601_07PurchaseOrderEdit As Boolean = False
    Public isExecutedFrom_frm601_09MaterialReceiptEdit As Boolean = False
    '
    Public isExecutedFrom_frm00106InvoiceCostPosting As Boolean = False
    Public isExecutedFrom_frm20172VATInvoiceWithDetails As Boolean = False

    Public isExecutedFrom_frm00102eInvSalesInvoiceEdit As Boolean = False

    Public Function GetNewGSCode(ByVal GSGroupCode As String) As String
        Dim strNewReceiptNo As String
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
            int1 = int1 + 1

            strNewReceiptNo = "0000" & CStr(int1)
            strNewReceiptNo = Microsoft.VisualBasic.Right(strNewReceiptNo, 5)
            strNewReceiptNo = GSGroupCode & "-" & strNewReceiptNo

            Return strNewReceiptNo

        Catch ex As System.InvalidCastException
            strNewReceiptNo = GSGroupCode & "-" & "00001"
            Return strNewReceiptNo
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub txtGSGroup_EditValueChanged(sender As Object, e As EventArgs) Handles txtGSGroup.EditValueChanged
        If Me.btnSave.Caption = "Save" Then
            If CheckIfNull(Me.txtGSGroup.EditValue) = False Then
                Dim SelectedGSGroupCode As String = ""

                SelectedGSGroupCode = Me.Dsfrm600_01InventoryStockEdit.Tables("tbl20165GoodsAndServicesGroup").Rows.Find(Me.txtGSGroup.EditValue).Item("GSGroupCode")
                Me.txtStockCode.EditValue = GetNewGSCode(SelectedGSGroupCode)

            End If
        End If
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        SaveStockItem()

    End Sub

    Private Sub CheckForErrors()
        If String.IsNullOrEmpty(ConvertIfNull(Me.txtStockCode.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtStockCode, "Services / Stock Code cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtStockCode, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If String.IsNullOrEmpty(ConvertIfNull(Me.txtItemName.EditValue)) Then
            Me.DxErrorProvider1.SetError(Me.txtItemName, "Description  cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Me.DxErrorProvider1.SetError(Me.txtItemName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        'check if the Iqama Number is strictly entered
        If Me.btnSave.Caption = "Save" Then
            'Get the Stock Group is Services then exit this
            If CheckIfItemGroupIsServices(Me.txtGSGroup.EditValue) = False Then
                GetCompanyDetails02(1)
                If gIsStrictPartNoEntry = True Then
                    If String.IsNullOrEmpty(ConvertIfNull(Me.txtPartNo.EditValue)) Then
                        Me.DxErrorProvider1.SetError(Me.txtPartNo, "Item Part Number must be entered, it cannot be empty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    Else
                        Me.DxErrorProvider1.SetError(Me.txtPartNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    End If

                    If String.IsNullOrEmpty(ConvertIfNull(Me.txtPartNo.EditValue)) = False Then
                        If CheckIfPartNoAlreadyExists(Me.txtPartNo.EditValue) = True Then
                            If Not Me.GSCodeFromPartNo = Me.txtStockCode.EditValue Then
                                Me.DxErrorProvider1.SetError(Me.txtPartNo, "Item Part Number has been already added to the database with the same Part No." & vbCrLf & "Stock No: " & Me.GSCodeFromPartNo & vbCrLf & "Stock Description :" & Me.GSNameFromPartNo, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)

                            Else
                                Me.DxErrorProvider1.SetError(Me.txtPartNo, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                            End If
                        End If
                    End If


                    If gIsAllowDuplicateItemDescription = True Then

                    Else
                        'Check if the record already in the system
                        If CheckIfDescriptionAlreadyExists(Me.txtItemName.EditValue) = True Then
                            If Not Me.GSCodeFromDescription = Me.txtStockCode.EditValue Then
                                Me.DxErrorProvider1.SetError(Me.txtItemName, "This Stock/Services Description is already in the Database, Please Check again.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                            Else
                                Me.DxErrorProvider1.SetError(Me.txtItemName, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                            End If
                        End If
                    End If
                End If
            End If
        End If


       

    End Sub

    Dim GSCodeFromDescription As String = String.Empty
    Public Function CheckIfDescriptionAlreadyExists(ByVal GSDescription As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "SELECT  GSCode  FROM  tbl20164GoodsAndServicesMaster WHERE (GSDescrpition = '" & GSDescription & "')"
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    GSCodeFromDescription = srStockReader.Item("GSCode")

                End While
                Return True
            Else
                GSCodeFromDescription = String.Empty
                Return False
            End If

            srStockReader.Close()
        Catch ex As System.InvalidCastException
            MessageBox.Show(ex.Message)
        Finally
            Sqlconnection1.Close()

        End Try
    End Function
    Private Function CheckIfStockDescriptionEnteredAlready(ByVal StockDescription As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "SELECT GSDescrpition FROM tbl20164GoodsAndServicesMaster WHERE (GSDescrpition = '" & StockDescription & "')"

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

    Private Function CheckIfItemGroupIsServices(ByVal GSGroupID As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSGroupID   from tbl20165GoodsAndServicesGroup  where (GSGroupID  = '" & GSGroupID & "') AND (ISNULL(IsServicesGroup, 0) = 1)"

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

    Dim GSCodeFromPartNo As String = String.Empty
    Dim GSNameFromPartNo As String = String.Empty
    Public Function CheckIfPartNoAlreadyExists(ByVal ItemPartNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "SELECT  GSCode, GSDescrpition, ItemPartNo FROM  tbl20164GoodsAndServicesMaster WHERE (ItemPartNo = '" & ItemPartNo & "')"
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    GSCodeFromPartNo = srStockReader.Item("GSCode")
                    GSNameFromPartNo = srStockReader.Item("GSDescrpition")
                End While
                Return True
            Else
                GSCodeFromPartNo = String.Empty
                GSNameFromPartNo = String.Empty
                Return False
            End If

            srStockReader.Close()
        Catch ex As System.InvalidCastException
            MessageBox.Show(ex.Message)
        Finally
            Sqlconnection1.Close()

        End Try
    End Function

    Private Sub SaveStockItem()
        Try
            CheckForErrors()

            If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) = True Then
                MessageBox.Show("Cannot save while the entry have errors, Please clear the errors to continue.", "Errors in Entry", MessageBoxButtons.OK)
                Exit Sub
            End If

            Try
                Dim currentImage As Bitmap = TryCast(Me.txtStockImage.EditValue, Bitmap)
                Dim resizedImage As New Bitmap(currentImage, Me.txtStockImage.ClientSize.Width, Me.txtStockImage.ClientSize.Height)
                Me.txtStockImage.Image = resizedImage

            Catch ex As Exception

            End Try

            If Me.btnSave.Caption = "Update" Then
                Try
                    Me.Validate()
                    Dim view As DataRowView = DirectCast(Me.Tbl20164GoodsAndServicesMasterBindingSource.Current, DataRowView)
                    view.Row("ModifiedBy") = Me.strLogonUser
                    view.Row("ModifiedOn") = Date.Now

                    Me.Tbl20164GoodsAndServicesMasterBindingSource.EndEdit()
                    Me.Tbl20164GoodsAndServicesMasterTableAdapter.Update(Me.Dsfrm600_01InventoryStockEdit.tbl20164GoodsAndServicesMaster)

                    UpdateUnitConversion(Me.txtStockCode.EditValue)


                    MessageBox.Show("Stock Inventory Master Information Updated Successfully.", "Save Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateParentEnumerationDetails()

                Catch ex As Exception
                    MessageBox.Show("Error on Updating record, please try again.", "Error On Updating", MessageBoxButtons.OK)
                End Try

            ElseIf Me.btnSave.Caption = "Save" Then

                SaveNewStockItem()

                InsertOpeningBalance(Me.txtStockCode.EditValue, Me.txtOpeningBalance.EditValue, Me.txtCostPrice.EditValue, Me.txtGSUoM.EditValue)
               
                UpdateParentEnumerationDetails()
                Me.btnSave.Caption = "Update"

            End If
        Catch ex As Exception
            MessageBox.Show("Error Occured while saving details to the Stock Master Database." & vbCrLf & "Please Try again." & vbCrLf & ex.Message, "Error on Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function InsertOpeningBalance(ByVal StockNo As String, ByVal QtyReceived As Decimal, UnitPrice As Decimal, UnitRateMethod As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_18InsertStockOpeningBalance"
            SqlCommand1.Parameters.Add("@StockNo", SqlDbType.VarChar).Value = StockNo
            SqlCommand1.Parameters.Add("@QtyReceived", SqlDbType.Decimal).Value = QtyReceived
            SqlCommand1.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = UnitPrice
            SqlCommand1.Parameters.Add("@UnitRateMethod", SqlDbType.TinyInt).Value = UnitRateMethod

            Return SqlCommand1.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return 0
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Public Function UpdateOpeningBalance(ByVal StockNo As String, ByVal QtyReceived As Decimal, ByVal UnitPrice As Decimal) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_17UpdateStockOpeningBalance"
            SqlCommand1.Parameters.Add("@StockNo", SqlDbType.VarChar).Value = StockNo
            SqlCommand1.Parameters.Add("@QtyReceived", SqlDbType.Decimal).Value = QtyReceived
            SqlCommand1.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = UnitPrice

            Return SqlCommand1.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error Occured" & vbCrLf & ex.ToString)
            Return 0
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Public Sub UpdateParentEnumerationDetails()
        If isExecutedFrom_frm600_02InventoryStockView = True Then
            Try
                CType(objForm, frm600_02InventoryStockView).ShowRecords()
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Goods and Services List Details." & ex.Message)
            End Try

        End If

        If isExecutedFrom_frm601_11PurchaseRequestEdit = True Then
            Try
                CType(objForm, frm601_11PurchaseRequestEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(objForm, frm601_11PurchaseRequestEdit).Dsfrm601_11PurchaseRequestEdit3.tbl40111PropertyUnitCodes)
            Catch ex As Exception

            End Try

            Try
                CType(objForm, frm601_11PurchaseRequestEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(objForm, frm601_11PurchaseRequestEdit).Dsfrm601_11PurchaseRequestEdit2.tbl20164GoodsAndServicesMaster)

                With CType(objForm, frm601_11PurchaseRequestEdit).gvInvoiceChild
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, Me.txtStockCode.EditValue)
                    .FocusedRowHandle = .FocusedRowHandle
                    .FocusedColumn = .Columns("GSCode")
                    .FocusedColumn = .Columns("QtyRequested")
                    .ShowEditor()
                End With

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Goods and Services List Details." & ex.Message)
            End Try

        End If

        'isExecutedFrom_frm601_01QuotationEdit
        If isExecutedFrom_frm601_01QuotationEdit = True Then
            Try
                CType(objForm, frm601_01QuotationEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(objForm, frm601_01QuotationEdit).Dsfrm601_01QuotationEdit.tbl40111PropertyUnitCodes)
            Catch ex As Exception

            End Try

            Try
                CType(objForm, frm601_01QuotationEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(objForm, frm601_01QuotationEdit).Dsfrm601_01QuotationEdit.tbl20164GoodsAndServicesMaster)

                With CType(objForm, frm601_01QuotationEdit).gvInvoiceChild
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, Me.txtStockCode.EditValue)
                    .FocusedRowHandle = .FocusedRowHandle
                    .FocusedColumn = .Columns("GSCode")
                    .FocusedColumn = .Columns("QuotedQuantity")
                    .ShowEditor()
                End With

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Goods and Services List Details." & ex.Message)
            End Try
        End If

        'isExecutedFrom_frm601_03SalesOrderEdit
        If isExecutedFrom_frm601_03SalesOrderEdit = True Then
            Try
                CType(objForm, frm601_03SalesOrderEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(objForm, frm601_03SalesOrderEdit).Dsfrm601_01QuotationEdit.tbl40111PropertyUnitCodes)
            Catch ex As Exception

            End Try

            Try
                CType(objForm, frm601_03SalesOrderEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(objForm, frm601_03SalesOrderEdit).Dsfrm601_01QuotationEdit.tbl20164GoodsAndServicesMaster)

                With CType(objForm, frm601_03SalesOrderEdit).gvInvoiceChild
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, Me.txtStockCode.EditValue)
                    .FocusedRowHandle = .FocusedRowHandle
                    .FocusedColumn = .Columns("GSCode")
                    .FocusedColumn = .Columns("QuotedQuantity")
                    .ShowEditor()
                End With

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Goods and Services List Details." & ex.Message)
            End Try
        End If

        'isExecutedFrom_frm601_05DeliveryNoteEdit
        If isExecutedFrom_frm601_05DeliveryNoteEdit = True Then
            Try
                CType(objForm, frm601_05DeliveryNoteEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(objForm, frm601_05DeliveryNoteEdit).Dsfrm601_01QuotationEdit.tbl40111PropertyUnitCodes)
            Catch ex As Exception

            End Try

            Try
                CType(objForm, frm601_05DeliveryNoteEdit).Tbl20164GoodsAndServicesMasterTableAdapter1.Fill(CType(objForm, frm601_05DeliveryNoteEdit).Dsfrm20161VATInvoiceEdit.tbl20164GoodsAndServicesMaster)

                With CType(objForm, frm601_05DeliveryNoteEdit).gvInvoiceChild
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, Me.txtStockCode.EditValue)
                    .FocusedRowHandle = .FocusedRowHandle
                    .FocusedColumn = .Columns("GSCode")
                    .FocusedColumn = .Columns("IssuedQty")
                    .ShowEditor()
                End With
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Goods and Services List Details." & ex.Message)
            End Try
        End If

        If isExecutedFrom_frm601_07PurchaseOrderEdit = True Then
            Try
                CType(objForm, frm601_07PurchaseOrderEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(objForm, frm601_07PurchaseOrderEdit).Dsfrm601_07PurchaseOrderEdit1.tbl40111PropertyUnitCodes)
            Catch ex As Exception

            End Try

            Try
                CType(objForm, frm601_07PurchaseOrderEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(objForm, frm601_07PurchaseOrderEdit).Dsfrm601_07PurchaseOrderEdit1.tbl20164GoodsAndServicesMaster)

                With CType(objForm, frm601_07PurchaseOrderEdit).gvInvoiceChild
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, Me.txtStockCode.EditValue)
                    .FocusedRowHandle = .FocusedRowHandle
                    .FocusedColumn = .Columns("GSCode")
                    .FocusedColumn = .Columns("QuotedQuantity")
                    .ShowEditor()
                End With
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Goods and Services List Details." & ex.Message)
            End Try

        End If
        '
        If isExecutedFrom_frm601_13RFQMaster = True Then
            Try
                CType(objForm, frm601_13RFQMaster).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(objForm, frm601_13RFQMaster).Dsfrm601_13RFQEdit.tbl40111PropertyUnitCodes)
            Catch ex As Exception

            End Try

            Try
                CType(objForm, frm601_13RFQMaster).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(objForm, frm601_13RFQMaster).Dsfrm601_13RFQEdit.tbl20164GoodsAndServicesMaster)

                With CType(objForm, frm601_13RFQMaster).gvInvoiceChild
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, Me.txtStockCode.EditValue)
                    .FocusedRowHandle = .FocusedRowHandle
                    .FocusedColumn = .Columns("GSCode")
                    .FocusedColumn = .Columns("QuotedQuantity")
                    .ShowEditor()
                End With

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Goods and Services List Details." & ex.Message)
            End Try
        End If

        If isExecutedFrom_frm601_09MaterialReceiptEdit = True Then
            Try
                CType(objForm, frm601_09MaterialReceiptEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(objForm, frm601_09MaterialReceiptEdit).Dsfrm601_09MaterialReceiptEdit.tbl40111PropertyUnitCodes)
            Catch ex As Exception

            End Try

            Try
                CType(objForm, frm601_09MaterialReceiptEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(objForm, frm601_09MaterialReceiptEdit).Dsfrm601_09MaterialReceiptEdit.tbl20164GoodsAndServicesMaster)

                With CType(objForm, frm601_09MaterialReceiptEdit).gvInvoiceChild
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, Me.txtStockCode.EditValue)
                    .FocusedRowHandle = .FocusedRowHandle
                    .FocusedColumn = .Columns("GSCode")
                    .FocusedColumn = .Columns("QtyReceived")
                    .ShowEditor()
                End With
            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Goods and Services List Details." & ex.Message)
            End Try
        End If

        If isExecutedFrom_frm00106InvoiceCostPosting = True Then
            Try
                CType(objForm, frm00106InvoiceCostPosting).ShowRecords()
            Catch ex As Exception

            End Try
        End If
        '
        If isExecutedFrom_frm20172VATInvoiceWithDetails = True Then
            Try
                CType(objForm, frm20172VATInvoiceWithDetails).ShowRecords()
            Catch ex As Exception

            End Try
        End If

        '
        If isExecutedFrom_frm00102eInvSalesInvoiceEdit = True Then
            Try
                CType(objForm, frm00102eInvSalesInvoiceEdit).Tbl40111PropertyUnitCodesTableAdapter.Fill(CType(objForm, frm00102eInvSalesInvoiceEdit).Dsfrm00102eInvSalesInvoiceEdit.tbl40111PropertyUnitCodes)
            Catch ex As Exception

            End Try

            Try
                'Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm20161VATInvoiceEdit1.tbl20164GoodsAndServicesMaster)
                CType(objForm, frm00102eInvSalesInvoiceEdit).Tbl20164GoodsAndServicesMasterTableAdapter.Fill(CType(objForm, frm00102eInvSalesInvoiceEdit).Dsfrm00102eInvSalesInvoiceEdit.tbl20164GoodsAndServicesMaster)

                With CType(objForm, frm00102eInvSalesInvoiceEdit).gvInvoiceChild
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, Me.txtStockCode.EditValue)
                    .FocusedRowHandle = .FocusedRowHandle
                    .FocusedColumn = .Columns("ItemCode")
                    .FocusedColumn = .Columns("QuantityInvoiced")
                    .ShowEditor()
                End With

            Catch ex As Exception
                MessageBox.Show("Error Occured while Refreshing the Goods and Services List Details." & ex.Message)
            End Try
        End If

    End Sub
    Public Sub FillDataSetforNew()

        Me.Tbl20164GoodsAndServicesMasterTableAdapter.Fill(Me.Dsfrm600_01InventoryStockEdit.tbl20164GoodsAndServicesMaster)
        Me.Tbl20164GoodsAndServicesMasterBindingSource.AddNew()

    End Sub

    Public Sub FillDataSetforEditing(ByVal StockCode As String)
        Me.Tbl20164GoodsAndServicesMasterTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit.tbl20164GoodsAndServicesMaster, StockCode)

        'Invoice Details
        Me.Qry600_03Stock_InvoiceDetailsTableAdapter.FillByItemCode(Me.Dsfrm600_01InventoryStockEdit1.qry600_03Stock_InvoiceDetails, StockCode)
        'Quotation Details
        Me.Qry601_06QuotationDetailsTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit2.qry601_06QuotationDetails, StockCode)
        'Purchase Order Details
        Me.Qry604_06PurchaseOrderDetailsTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit3.qry604_06PurchaseOrderDetails, StockCode)
        'Deliveries
        Me.Qry603_06DeliveryNoteDetailsTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit4.qry603_06DeliveryNoteDetails, StockCode)
        'Receipts
        Me.Qry605_06MaterailReceiptDetailsTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit5.qry605_06MaterailReceiptDetails, StockCode)
        'Unit Conversion
        Me.Tbl600_03UnitConversionMasterTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit7.tbl600_03UnitConversionMaster, StockCode)
        'Stock Card
        Me.Qry651_11StockCardForStockMasterEditTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit8.qry651_11StockCardForStockMasterEdit, StockCode)
        'Stock Documents
        Me.Tbl600_07InventoryStockDocumentsTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit1.tbl600_07InventoryStockDocuments, StockCode)
        'Stock Purchases
        Me.Qry600_08InventoryPurchaseDetailsTableAdapter.FillByStockCode(Me.Dsfrm600_01InventoryStockEdit.qry600_08InventoryPurchaseDetails, StockCode)

    End Sub

    Private Sub SaveNewStockItem()
        'Save new record
        Dim view As DataRowView = DirectCast(Me.Tbl20164GoodsAndServicesMasterBindingSource.Current, DataRowView)
        view.Row("CreatedBy") = Me.strLogonUser
        view.Row("CreatedOn") = Date.Now

        Me.Tbl20164GoodsAndServicesMasterBindingSource.EndEdit()
        Me.Tbl20164GoodsAndServicesMasterTableAdapter.Update(Me.Dsfrm600_01InventoryStockEdit.tbl20164GoodsAndServicesMaster)
        MessageBox.Show("Goods and Services Master Information Saved Successfully.", "Save Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnSaveClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
        SaveStockItem()

        If DxErrorProvider1.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical) = True Then
            MessageBox.Show("Cannot save while the entry have errors, Please clear the errors to continue.", "Errors in Entry", MessageBoxButtons.OK)
            Exit Sub
        End If

        Me.Close()

    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.Close()

    End Sub

    Private Sub btnTranslateDetailedDesc_Click(sender As Object, e As EventArgs) Handles btnTranslateDetailedDesc.Click
        Me.txtDetailedDescAr.EditValue = TranslateToArabic(Me.txtDetailedDescription.EditValue)
        Me.txtDetailedDescAr.Focus()

    End Sub

    Private Sub txtGSUoM_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtGSUoM.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm40114QuoteMethods As New frm40114QuoteMethods
            frm40114QuoteMethods.ObjForm = Me
            frm40114QuoteMethods.Show()
            frm40114QuoteMethods.txtQuoteMethod.Focus()
            frm40114QuoteMethods.isExecutedFrom_frm600_01InventoryStockEdit = True
        End If
    End Sub

    Private Sub frm600_01InventoryStockEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tbl101DocumentTypeTableAdapter.Fill(Me.Dsfrm600_01InventoryStockEdit9.tbl101DocumentType)
        Me.Tbl600_01StoreMasterTableAdapter.Fill(Me.Dsfrm600_01InventoryStockEdit6.tbl600_01StoreMaster)
        Me.Tbl30111StockClassificationMasterTableAdapter.Fill(Me.Dsfrm600_01InventoryStockEdit.tbl30111StockClassificationMaster)
        Me.Tbl40111PropertyUnitCodesTableAdapter1.Fill(Me.Dsfrm600_01InventoryStockEdit.tbl40111PropertyUnitCodes)

        'intLogOnInventoryAccessLevel
        If Me.intLogOnInventoryAccessLevel = 99 Then
            Me.Tbl20165GoodsAndServicesGroupTableAdapter.Fill(Me.Dsfrm600_01InventoryStockEdit.tbl20165GoodsAndServicesGroup)
        Else
            Me.Tbl20165GoodsAndServicesGroupTableAdapter.FillByInventoryMasterGroupID(Me.Dsfrm600_01InventoryStockEdit.tbl20165GoodsAndServicesGroup, Me.intLogOnInventoryAccessLevel)
        End If

        Me.ImplementAccessLevel()

        Try
            LoadLayoutFromDB(Me.intLogOnUserID, "frm600_01InventoryStockEdit_gvStockCard", Me.gvStockCard)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm600_01InventoryStockEdit_gvPayroll", Me.gvPayroll)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm600_01InventoryStockEdit_gvQuotations", Me.gvQuotations)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm600_01InventoryStockEdit_gvPurchaseOrders", Me.gvPurchaseOrders)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm600_01InventoryStockEdit_gvDeliveryNotes", Me.gvDeliveryNotes)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm600_01InventoryStockEdit_gvReceipts", Me.gvReceipts)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm600_01InventoryStockEdit_gvEmpDocuments", Me.gvEmpDocuments)
            LoadLayoutFromDB(Me.intLogOnUserID, "frm600_01InventoryStockEdit_gvPurchases", Me.gvPurchases)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImplementAccessLevel()
        Try
            If GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_FullAccess") = True Then
                Me.btnSave.Enabled = True
                Me.btnSaveAndClose.Enabled = True
                Me.btnDelete.Enabled = True
                Me.btnBack.Enabled = True

                Me.txtGSGroup.Properties.Buttons.Item(1).Enabled = True
                Me.txtStore.Properties.Buttons.Item(1).Enabled = True
                Me.txtItemClassification.Properties.Buttons.Item(1).Enabled = True
                Me.txtItemName.Enabled = True
                Me.txtItemNameAr.Enabled = True

                Me.pageAttributes.PageEnabled = True
                Me.txtGSUoM.Properties.Buttons.Item(1).Enabled = True

                Me.txtCostPrice.Enabled = True
                Me.txtSellingPrice.Enabled = True
                Me.txtOpeningBalance.Enabled = True

                Me.lblExFactoryPrice.Visible = True
                Me.txtExFactoryPrice.Visible = True

                Me.pageStockControl.PageEnabled = True
                Me.pageStockImage.PageEnabled = True
                Me.pageInvoices.PageEnabled = True
                Me.pageQuotations.PageEnabled = True
                Me.pagePurchaseOrders.PageEnabled = True
                Me.pageDeliveryNotes.PageEnabled = True
                Me.pageItemsReceived.PageEnabled = True

                'pageUnitConversion
                Me.pageUnitConversion.PageEnabled = True

                For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
                    If tabItemDetails.TabPages(i).Name = "pageUnitConversion" Then
                        tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)

                        Me.btnAddNewUnitConversion.Enabled = True
                        Me.gcUnitConvertion.Enabled = True
                        Exit For
                    End If
                Next

                'pageDocuments
                Me.pageDocuments.PageEnabled = True

                For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
                    If tabItemDetails.TabPages(i).Name = "pageDocuments" Then
                        tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)

                        Me.btnAddDocuments.Enabled = True
                        Me.btnMergeSelectedFiles.Enabled = True
                        Me.btnSaveSeperateFiles.Enabled = True
                        Exit For
                    End If
                Next

                'Focus to pageAttributes
                For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
                    If tabItemDetails.TabPages(i).Name = "pageAttributes" Then
                        tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)
                        Exit For
                    End If
                Next
            Else
                Me.btnSave.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_btnSave")
                Me.btnSaveAndClose.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_btnSaveAndClose")
                Me.btnDelete.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_btnDelete")
                Me.btnBack.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_btnBack")

                Me.txtGSGroup.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtGSGroup_Add")
                Me.txtStore.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtStore_Add")
                Me.txtItemClassification.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtItemClassification_Add")
                Me.txtItemName.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtItemName_Edit")
                Me.txtItemNameAr.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtItemNameAr_Edit")

                Me.txtCostPrice.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtCostPrice_Edit")
                Me.txtSellingPrice.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtSellingPrice_Edit")
                Me.txtOpeningBalance.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtOpeningBalance_Edit")

                Me.lblExFactoryPrice.Visible = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtExFactoryPrice_Visible")
                Me.txtExFactoryPrice.Visible = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtExFactoryPrice_Visible")

                Me.lblCostPrice.Visible = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtCostPrice_Visible")
                Me.txtCostPrice.Visible = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtCostPrice_Visible")

                Me.pageAttributes.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pageAttributes")
                Me.txtGSUoM.Properties.Buttons.Item(1).Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_txtGSUoM_Add")

                Me.pageStockControl.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pageStockControl")
                Me.pageStockImage.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pageStockImage")
                Me.pageInvoices.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pageInvoices")
                Me.pageQuotations.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pageQuotations")
                Me.pagePurchaseOrders.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pagePurchaseOrders")
                Me.pageDeliveryNotes.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pageDeliveryNotes")
                Me.pageItemsReceived.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pageItemsReceived")

                'pageUnitConversion
                Me.pageUnitConversion.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pageUnitConversion")

                For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
                    If tabItemDetails.TabPages(i).Name = "pageUnitConversion" Then
                        tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)

                        Me.btnAddNewUnitConversion.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_btnAddNewUnitConversion")
                        Me.gcUnitConvertion.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_gcUnitConvertion_Edit")
                        Exit For
                    End If
                Next

                'pageDocuments
                Me.pageDocuments.PageEnabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_pageDocuments")

                For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
                    If tabItemDetails.TabPages(i).Name = "pageDocuments" Then
                        tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)

                        Me.btnAddDocuments.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_btnAddDocuments")
                        Me.btnMergeSelectedFiles.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_btnMergeSelectedFiles")
                        Me.btnSaveSeperateFiles.Enabled = GetUserAccess(Me.intLogOnUserID, "frm600_01InventoryStockEdit_btnSaveSeperateFiles")
                        Exit For
                    End If
                Next

                'Focus to pageAttributes
                For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
                    If tabItemDetails.TabPages(i).Name = "pageAttributes" Then
                        tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtItemNameAr_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtItemNameAr.ButtonClick
        If e.Button.Index = 0 Then
            Me.txtItemNameAr.EditValue = TranslateToArabic(Me.txtItemName.EditValue)
        End If
    End Sub

    Private Sub ChangeToArabicKeyboardOn_Enter(sender As Object, e As EventArgs) Handles txtItemNameAr.Enter
        ArabicKeyboard()
    End Sub

    Private Sub ChangeToEnglishKeyboardOn_Leave(sender As Object, e As EventArgs) Handles txtItemNameAr.Leave
        EnglishKeyboard()
    End Sub
   
    Private Sub btnAddNewUnitConversion_Click(sender As Object, e As EventArgs) Handles btnAddNewUnitConversion.Click
        'Insert new item and set for editing
        Me.InsertUnitConvertionEntry(Me.txtStockCode.EditValue)

        Me.Tbl20164GoodsAndServicesMasterBindingSource.EndEdit()
        Me.Tbl20164GoodsAndServicesMasterTableAdapter.Update(Me.Dsfrm600_01InventoryStockEdit.tbl20164GoodsAndServicesMaster)

        UpdateUnitConversion(Me.txtStockCode.EditValue)
    
    End Sub

    Public Sub UpdateUnitConversion(ByVal StockCode As String)
        Me.Tbl60003UnitConversionMasterBindingSource.EndEdit()
        Me.Tbl600_03UnitConversionMasterTableAdapter.Update(Me.Dsfrm600_01InventoryStockEdit7.tbl600_03UnitConversionMaster)

        Me.Tbl600_03UnitConversionMasterTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit7.tbl600_03UnitConversionMaster, Me.txtStockCode.EditValue)
    End Sub


    Public Function InsertUnitConvertionEntry(ByVal GSCode As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "insert into tbl600_03UnitConversionMaster (GSCode, UnitConverted) Values ('" & GSCode & "',   1)"

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

    Dim selectedUnitConversionID As Integer

    Private Sub gvUnitConvertion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvUnitConvertion.MouseDown
        Try
            Dim view As GridView = CType(sender, GridView)
            If view Is Nothing Then Return

            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ((e.Button = System.Windows.Forms.MouseButtons.Right) <> 0) And (hitInfo.InRow) And (Not view.IsGroupRow(hitInfo.RowHandle)) Then
                view.FocusedRowHandle = hitInfo.RowHandle

                Me.selectedUnitConversionID = view.GetRowCellValue(hitInfo.RowHandle, view.Columns("UnitConversionID"))
                Me.popupUnitConversion.ShowPopup(MousePosition)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeleteConversion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteConversion.ItemClick
        Try
            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Unit Conversion from the database." & vbCrLf & "You cannot revert the changes." & vbCrLf & "Are you Sure want to Delete?", "Delete Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(selectedUnitConversionID) = False Then
                    'Check the Record has any Sub Entered
                    If DeleteUnitConversion(selectedUnitConversionID) = True Then
                        MessageBox.Show("Master Records has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Refresh the datagrid
                        'Fill Unit Conversion
                        Me.Tbl600_03UnitConversionMasterTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit7.tbl600_03UnitConversionMaster, Me.txtStockCode.EditValue)

                    Else
                        MessageBox.Show("Deleting Failed, please try again.", "Delete Failed", MessageBoxButtons.OK)
                    End If

                End If

            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then

                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function DeleteUnitConversion(ByVal UnitConversionID As Integer) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim strSqlQueryText As String
            strSqlQueryText = "Delete from dbo.tbl600_03UnitConversionMaster where UnitConversionID = '" & UnitConversionID & "'"

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
            MessageBox.Show("Error Occured on Removing Master records" & vbCrLf & ex.ToString)
            Return False
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub gvStockCard_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gvStockCard.CustomUnboundColumnData
        Try

            Dim view As GridView = TryCast(sender, GridView)

            If e.Column.FieldName = "colBalance" Then
                If e.IsGetData Then
                    Dim total As Decimal = 0
                    Dim rHandle As Integer = view.GetRowHandle(e.ListSourceRowIndex)

                    For i As Integer = -1 To (rHandle - 1)
                        total += Convert.ToDecimal(view.GetRowCellValue(i + 1, "StockReceivedQty"))
                    Next

                    e.Value = total
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtStore_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtStore.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm600_01StoreEdit As New frm600_01StoreEdit
            frm600_01StoreEdit.ObjForm = Me
            frm600_01StoreEdit.Show()
            frm600_01StoreEdit.txtStoreName.Focus()
            frm600_01StoreEdit.isExecutedFrom_frm600_01InventoryStockEdit = True

        End If
    End Sub

    Private Sub txtGSGroup_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtGSGroup.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm600_05GoodsAndServicesGroups As New frm600_05GoodsAndServicesGroups
            frm600_05GoodsAndServicesGroups.ObjForm = Me
            frm600_05GoodsAndServicesGroups.intLogOnUserID = Me.intLogOnUserID
            frm600_05GoodsAndServicesGroups.intLogOnUserLevel = Me.intLogOnUserLevel
            frm600_05GoodsAndServicesGroups.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm600_05GoodsAndServicesGroups.intLogOnDivision = Me.intLogOnDivision
            frm600_05GoodsAndServicesGroups.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel

            frm600_05GoodsAndServicesGroups.Show()
            frm600_05GoodsAndServicesGroups.txtGroupName.Focus()
            frm600_05GoodsAndServicesGroups.isExecutedFrom_frm600_01InventoryStockEdit = True


        End If
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try

            'Check before deleting... if the Item has records in VAT Invoice / other Registers
            'Important XXXXXXXXXXXXXX
            If CheckIfItemHasInvoice(Me.txtStockCode.EditValue) = True Then
                MessageBox.Show("This Item has been generated in Invoice.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsQuoted
            If CheckIfItemIsQuoted(Me.txtStockCode.EditValue) = True Then
                MessageBox.Show("This Item has been Quoted in Quotation Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInSalesOrder
            If CheckIfItemIsInSalesOrder(Me.txtStockCode.EditValue) = True Then
                MessageBox.Show("This Item has been added in Sales Order Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInDeliveryNote
            If CheckIfItemIsInDeliveryNote(Me.txtStockCode.EditValue) = True Then
                MessageBox.Show("This Item has been Delivered in Delivery Note Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInRFQ
            If CheckIfItemIsInRFQ(Me.txtStockCode.EditValue) = True Then
                MessageBox.Show("This Item has been added in RFQ Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInMaterialRequest
            If CheckIfItemIsInMaterialRequest(Me.txtStockCode.EditValue) = True Then
                MessageBox.Show("This Item has been added in Material Request / Enquiry Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInPurchaseOrder
            If CheckIfItemIsInPurchaseOrder(Me.txtStockCode.EditValue) = True Then
                MessageBox.Show("This Item has been added in Purchase Order.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            'CheckIfItemIsInMaterialReceipt
            If CheckIfItemIsInMaterialReceipt(Me.txtStockCode.EditValue) = True Then
                MessageBox.Show("This Item has been added in Material Receipt Database.", "Cannot Delete.", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim DialogResult As DialogResult
            DialogResult = MessageBox.Show("You are about to delete the Inventory Stock Item from the Database," & vbCrLf & "Click yes if you would like to continue.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

            If DialogResult = System.Windows.Forms.DialogResult.Yes Then
                If CheckIfNull(Me.txtStockCode.EditValue) = False Then
                    If DeleteStockItem(Me.txtStockCode.EditValue) = True Then
                        MessageBox.Show("Inventory Stock Item has been successfully removed from the database.", "Data Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Update the Delete Log File
                        InsertUserEntryLogSheet("Inventory Item", "Inventory Master Item Code." & Me.txtStockCode.EditValue & " has been Deleted by User ID:" & Me.intLogOnUserID & " User Name: " & Me.strLogOnUser & ".", Me.strLogOnUser, Me.txtStockCode.EditValue)

                        'Refresh the datagrid
                        UpdateParentEnumerationDetails()
                        Me.Close()

                    Else
                        MessageBox.Show("Deleting Failed, please try again.", "Delete Failed", MessageBoxButtons.OK)
                    End If
                End If
            ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function CheckIfItemHasInvoice(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select ItemCode from tbl20162VATInvoiceChild where (ItemCode = '" & StockNo & "')"

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

    Private Function CheckIfItemIsQuoted(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl601_02QuotationChild where (GSCode = '" & StockNo & "')"

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

    Private Function CheckIfItemIsInSalesOrder(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl602_02SalesOrderChild where (GSCode = '" & StockNo & "')"

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

    Private Function CheckIfItemIsInDeliveryNote(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl603_02DeliveryNoteChild where (GSCode = '" & StockNo & "')"

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

    Private Function CheckIfItemIsInMaterialRequest(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl606_02PurchaseRequestChild where (GSCode = '" & StockNo & "')"

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
    Private Function CheckIfItemIsInRFQ(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl607_02RFQChild where (GSCode = '" & StockNo & "')"

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

    Private Function CheckIfItemIsInPurchaseOrder(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl604_02PurchaseOrderChild where (GSCode = '" & StockNo & "')"

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

    Private Function CheckIfItemIsInMaterialReceipt(ByVal StockNo As String) As Boolean
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If
            Dim strSqlQueryText As String
            strSqlQueryText = "Select GSCode from tbl605_02MaterialReceiptChild where (GSCode = '" & StockNo & "') AND (ReceiptNo <> 'OPENING-BAL')"

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
    Private Function DeleteStockItem(ByVal StockNo As String) As Boolean
        Dim myTrans As System.Data.SqlClient.SqlTransaction

        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)

        If Sqlconnection1.State = ConnectionState.Closed Then
            Sqlconnection1.Open()
        End If

        Dim delPRTrans As New SqlClient.SqlCommand
        myTrans = Sqlconnection1.BeginTransaction(IsolationLevel.ReadCommitted, "PRTransaction")
        delPRTrans.Connection = Sqlconnection1
        delPRTrans.Transaction = myTrans
        Try

            delPRTrans.CommandText = "DELETE from tbl20164GoodsAndServicesMaster WHERE GSCode   = '" & StockNo & "'"
            delPRTrans.ExecuteNonQuery()

            delPRTrans.CommandText = "DELETE from tbl605_02MaterialReceiptChild WHERE GSCode   = '" & StockNo & "' and ReceiptNo = 'OPENING-BAL'"
            delPRTrans.ExecuteNonQuery()

            myTrans.Commit()
            Return True

        Catch ex As Exception
            Try
                myTrans.Rollback("PRTransaction")
                Return False
            Catch Sqlex As System.Data.SqlClient.SqlException
                If Not myTrans.Connection Is Nothing Then
                    MessageBox.Show("An exception of type " & Sqlex.GetType().ToString() & _
                                      " was encountered while attempting to roll back the transaction.", "Error on Delete", MessageBoxButtons.OK)
                End If
                MessageBox.Show("An exception of type " & ex.GetType().ToString() & _
                                      "was encountered while inserting the data.")
                Return False
            End Try
        Finally
            Sqlconnection1.Close()
        End Try
    End Function

    Private Sub txtItemClassification_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtItemClassification.ButtonClick
        If e.Button.Index = 1 Then
            Dim frm600_09StockClassification As New frm600_09StockClassification
            frm600_09StockClassification.ObjForm = Me
            frm600_09StockClassification.Show()
            frm600_09StockClassification.txtPropertyCategory.Focus()
            frm600_09StockClassification.isExecutedFrom_frm600_01InventoryStockEdit = True

        End If
    End Sub

    Private Sub btnPrintTransactions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintTransactions.ItemClick
        Me.printComponentStockTransactions.CreateDocument()
        Me.printComponentStockTransactions.ShowPreview()
    End Sub

    Private Sub printComponentLoans_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles printComponentStockTransactions.CreateReportHeaderArea
        Dim brick As DevExpress.XtraPrinting.TextBrick
        brick = e.Graph.DrawString("Stock Description: " & Me.txtItemName.EditValue, Color.Navy, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
        brick.Font = New Font("Arial", 12)
        brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)

    End Sub

    Private Sub btnPrintInvoices_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintInvoices.ItemClick
        Me.printComponentInvoices.CreateDocument()
        Me.printComponentInvoices.ShowPreview()
    End Sub

    Private Sub printComponentInvoices_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles printComponentInvoices.CreateReportHeaderArea
        Dim brick As DevExpress.XtraPrinting.TextBrick
        brick = e.Graph.DrawString("Stock Description: " & Me.txtItemName.EditValue, Color.Navy, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
        brick.Font = New Font("Arial", 12)
        brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)

    End Sub

    Private Sub btnPrintQuotations_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintQuotations.ItemClick
        Me.printComponentQuotations.CreateDocument()
        Me.printComponentQuotations.ShowPreview()
    End Sub

    Private Sub printComponentQuotations_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles printComponentQuotations.CreateReportHeaderArea
        Dim brick As DevExpress.XtraPrinting.TextBrick
        brick = e.Graph.DrawString("Stock Description: " & Me.txtItemName.EditValue, Color.Navy, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
        brick.Font = New Font("Arial", 12)
        brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)

    End Sub

    Private Sub btnPrintPOs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPOs.ItemClick
        Me.printComponentPurchaseOrders.CreateDocument()
        Me.printComponentPurchaseOrders.ShowPreview()
    End Sub

    Private Sub printComponentPurchaseOrders_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles printComponentPurchaseOrders.CreateReportHeaderArea
        Dim brick As DevExpress.XtraPrinting.TextBrick
        brick = e.Graph.DrawString("Stock Description: " & Me.txtItemName.EditValue, Color.Navy, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
        brick.Font = New Font("Arial", 12)
        brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)

    End Sub

    Private Sub btnPrintDeliveries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintDeliveries.ItemClick
        Me.printComponentStockDeliveries.CreateDocument()
        Me.printComponentStockDeliveries.ShowPreview()
    End Sub

    Private Sub printComponentStockDeliveries_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles printComponentStockDeliveries.CreateReportHeaderArea
        Dim brick As DevExpress.XtraPrinting.TextBrick
        brick = e.Graph.DrawString("Stock Description: " & Me.txtItemName.EditValue, Color.Navy, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
        brick.Font = New Font("Arial", 12)
        brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)

    End Sub

    Private Sub btnPrintStockReceipts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintStockReceipts.ItemClick
        Me.printComponentStockReceipts.CreateDocument()
        Me.printComponentStockReceipts.ShowPreview()
    End Sub

    Private Sub printComponentStockReceipts_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles printComponentStockReceipts.CreateReportHeaderArea
        Dim brick As DevExpress.XtraPrinting.TextBrick
        brick = e.Graph.DrawString("Stock Description: " & Me.txtItemName.EditValue, Color.Navy, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
        brick.Font = New Font("Arial", 12)
        brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)

    End Sub

#Region "Document Attachments"
    Private Sub btnAddDocuments_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddDocuments.ItemClick
        Try
            If CheckIfNull(Me.txtStockCode.EditValue) = False Then
                Dim frm600_11InventoryDocuments As New frm600_11InventoryDocuments
                frm600_11InventoryDocuments.ObjForm = Me
                frm600_11InventoryDocuments.isExecutedFrom_frm600_01InventoryStockEdit = True

                frm600_11InventoryDocuments.strLogOnUser = Me.strLogOnUser
                frm600_11InventoryDocuments.intLogOnUserID = Me.intLogOnUserID
                frm600_11InventoryDocuments.intLogOnUserLevel = Me.intLogOnUserLevel
                frm600_11InventoryDocuments.intLogOnAccessLevel = Me.intLogOnAccessLevel

                frm600_11InventoryDocuments.Show()

                frm600_11InventoryDocuments.SelectedGSCode = Me.txtStockCode.EditValue
                frm600_11InventoryDocuments.txtDocumentNo.EditValue = frm600_11InventoryDocuments.GetNewDocumentNo()
                frm600_11InventoryDocuments.txtDocumentType.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show("Error on adding new document for this Project, please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim pdfDocProcessor As New PdfDocumentProcessor()
    Dim DestinationFolder As String = ""
    Private Sub SaveEmployeeDocument(ByVal DocumentNo As String)
        Try
            Dim strDocNo As String = DocumentNo
            strDocNo = Me.txtStockCode.EditValue & "-" & strDocNo

            Dim nullcheck1 As Boolean = IsDBNull(strDocNo)
            If nullcheck1 = True Then
                MessageBox.Show("No Records", "No Record", MessageBoxButtons.OK)
            Else

                GetCompanyDetails(1)
                Dim ScannedFileLocation As String = gScannedLocation
                ScannedFileLocation = gScannedLocation & "AssetsScanned\Inventory"
                ScannedFileLocation = ScannedFileLocation & strDocNo & ".pdf"

                'Copy the File from the destination and Save it to C:\
                Dim DestinationFile As String = DestinationFolder
                DestinationFile = DestinationFile & "\Inventory-" & strDocNo & ".pdf"

                If System.IO.File.Exists(ScannedFileLocation) = True Then
                    'If file exists then copy the file to new location
                    'System.IO.File.Copy(ScannedFileLocation, DestinationFile)
                    Me.PdfViewer1.LoadDocument(ScannedFileLocation)
                    Me.PdfViewer1.SaveDocument(DestinationFile)
                    Me.PdfViewer1.CloseDocument()
                    Me.PdfViewer1.Hide()

                End If

            End If
        Catch ex As Exception

            MessageBox.Show("Error Occured on copying Document " & vbCrLf & ex.ToString)
        End Try

    End Sub

    Private Sub PdfViewer1_PasswordRequested(sender As Object, e As PdfPasswordRequestedEventArgs) Handles PdfViewer1.PasswordRequested
        'e.Password = New System.Security.SecureString()
        'For Each symbol As Char In "erp40"
        '    e.Password.AppendChar(symbol)
        'Next symbol

        e.PasswordString = "erp40"
    End Sub

    Private Sub MergeEmployeeDocument(ByVal DocumentNo As String)
        Try
            Dim strDocNo As String = DocumentNo
            strDocNo = Me.txtStockCode.EditValue & "-" & strDocNo

            Dim nullcheck1 As Boolean = IsDBNull(strDocNo)
            If nullcheck1 = True Then
                MessageBox.Show("No Records", "No Record", MessageBoxButtons.OK)
            Else
                GetCompanyDetails(1)
                Dim ScannedFileLocation As String = gScannedLocation
                ScannedFileLocation = gScannedLocation & "AssetsScanned\Inventory"
                ScannedFileLocation = ScannedFileLocation & strDocNo & ".pdf"


                'Copy the File from the destination and Save it to C:\
                Dim DestinationFile As String = DestinationFolder
                DestinationFile = DestinationFile & "\Inventory-" & strDocNo & ".pdf"

                If System.IO.File.Exists(ScannedFileLocation) = True Then
                    'If file exists then copy the file to new location
                    'System.IO.File.Copy(ScannedFileLocation, DestinationFile)
                    Me.PdfViewer1.LoadDocument(ScannedFileLocation)
                    Me.PdfViewer1.SaveDocument(DestinationFile)
                    pdfDocProcessor.AppendDocument(DestinationFile)
                    Me.PdfViewer1.CloseDocument()
                    Me.PdfViewer1.Hide()
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error Occured on copying Document " & vbCrLf & ex.ToString)
        End Try

    End Sub
    Private Sub btnMergeSelectedFiles_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMergeSelectedFiles.ItemClick
        Try

            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                Me.DestinationFolder = FolderBrowserDialog1.SelectedPath
            End If

            Dim view As GridView = gvEmpDocuments
            pdfDocProcessor.CreateEmptyDocument()
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    Dim ChosenDocumentNo As String = view.GetRowCellValue(row, view.Columns("DocumentNo"))
                    Me.MergeEmployeeDocument(ChosenDocumentNo)
                Next
            End If
            pdfDocProcessor.SaveDocument(DestinationFolder & "\Inventory-" & Me.txtStockCode.EditValue & "-MergedDocuments.pdf")

        Catch ex As Exception
            MessageBox.Show("Error Occured on copying Document " & vbCrLf & ex.ToString)
        End Try
    End Sub

    Private Sub btnSaveSeperateFiles_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveSeperateFiles.ItemClick
        Try
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                Me.DestinationFolder = FolderBrowserDialog1.SelectedPath
            End If

            Dim view As GridView = gvEmpDocuments
            If view.SelectedRowsCount > 0 Then
                For Each row As Integer In view.GetSelectedRows()
                    Dim ChosenDocumentNo As String = view.GetRowCellValue(row, view.Columns("DocumentNo"))
                    Me.SaveEmployeeDocument(ChosenDocumentNo)
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("Error Occured on copying Document " & vbCrLf & ex.ToString)
        End Try
    End Sub

    Private Sub repoDocumentNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repoDocumentNo.Click
        Try
            Dim strDocNo As String = Me.gvEmpDocuments.GetRowCellValue(Me.gvEmpDocuments.FocusedRowHandle, "DocumentNo")
            strDocNo = Me.txtStockCode.EditValue & "-" & strDocNo

            Dim nullcheck1 As Boolean = IsDBNull(strDocNo)
            If nullcheck1 = True Then
                MessageBox.Show("No Records", "No Record", MessageBoxButtons.OK)
            Else
                GetCompanyDetails(1)
                Dim ScannedFileLocation As String = gScannedLocation
                ScannedFileLocation = gScannedLocation & "AssetsScanned\Inventory"
                ScannedFileLocation = ScannedFileLocation & strDocNo & ".pdf"


                If System.IO.File.Exists(ScannedFileLocation) = True Then
                    Dim frmDocuments As New frmScannedDoc
                    frmDocuments.FileNo = strDocNo
                    frmDocuments.LoadDocument(ScannedFileLocation)
                    frmDocuments.sourceFile = ScannedFileLocation
                    frmDocuments.IsInventoryDocuments = True
                    frmDocuments.Show()
                Else
                    'MessageBox.Show("No documents Attached", "No documents", MessageBoxButtons.OK)
                    Dim frmDocuments As New frmScannedDoc
                    frmDocuments.FileNo = strDocNo
                    frmDocuments.IsInventoryDocuments = True
                    frmDocuments.Show()
                    frmDocuments.OpenFileDialogBox()

                End If


            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub txtPartNo_Validated(sender As Object, e As EventArgs) Handles txtPartNo.Validated
        'Check if the Part No exists .. if exists notify message
        'If the StockNo is same as the current editing StockNo then skip
        Try
            If CheckIfItemGroupIsServices(Me.txtGSGroup.EditValue) = False Then
                If String.IsNullOrEmpty(ConvertIfNull(Me.txtPartNo.EditValue)) = False Then
                    If CheckIfPartNoAlreadyExists(Me.txtPartNo.EditValue) = True Then
                        If Not Me.GSCodeFromPartNo = Me.txtStockCode.EditValue Then
                            MessageBox.Show("Stock Item with this Part Number has been already added to the database." & vbCrLf & "Stock No: " & Me.GSCodeFromPartNo & vbCrLf & "Stock Description :" & Me.GSNameFromPartNo, "Item Part Number already present in the database", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            GetCompanyDetails02(1)
                            If gIsStrictPartNoEntry = True Then
                                Me.txtPartNo.Focus()
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtItemName_Validated(sender As Object, e As EventArgs) Handles txtItemName.Validated
        If gIsAllowDuplicateItemDescription = True Then
            Exit Sub
        End If
        'Check if the Item Description exists .. if exists notify message
        Try
            If String.IsNullOrEmpty(ConvertIfNull(Me.txtItemName.EditValue)) = False Then
                If CheckIfDescriptionAlreadyExists(Me.txtItemName.EditValue) = True Then
                    If Not Me.GSCodeFromDescription = Me.txtStockCode.EditValue Then
                        MessageBox.Show("Stock Item with this Stock Description has been already added to the database." & vbCrLf & "Stock No: " & Me.GSCodeFromDescription, "Stock Description already present in the database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtItemName.Focus()

                        'GetCompanyDetails02(1)
                        'If gIsStrictPartNoEntry = True Then

                        'End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddOpeningBal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddOpeningBal.ItemClick
        Try
            InsertOpeningBalance(Me.txtStockCode.EditValue, 0, Me.txtCostPrice.EditValue, Me.txtGSUoM.EditValue)
            Me.Qry605_06MaterailReceiptDetailsTableAdapter.FillByGSCode(Me.Dsfrm600_01InventoryStockEdit5.qry605_06MaterailReceiptDetails, Me.txtStockCode.EditValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtOpeningBalance_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtOpeningBalance.ButtonClick
        If e.Button.Index = 1 Then
            Me.OpenOpeningBalanceEntryForm(Me.txtStockCode.EditValue)
        End If
    End Sub

    Private Sub OpenOpeningBalanceEntryForm(ByVal StockNo As String)
        Try
            Dim frm600_12OpeningBalanceEntries As New frm600_12OpeningBalanceEntries
            frm600_12OpeningBalanceEntries.objForm = Me
            frm600_12OpeningBalanceEntries.IsOpenedFrom_frm600_01InventoryStockEdit = True

            frm600_12OpeningBalanceEntries.strLogOnUser = Me.strLogOnUser
            frm600_12OpeningBalanceEntries.intLogOnUserID = Me.intLogOnUserID
            frm600_12OpeningBalanceEntries.intLogOnUserLevel = Me.intLogOnUserLevel
            frm600_12OpeningBalanceEntries.intLogOnAccessLevel = Me.intLogOnAccessLevel

            frm600_12OpeningBalanceEntries.Show()

            frm600_12OpeningBalanceEntries.OpenItemOpeningBalEntry(StockNo)
            frm600_12OpeningBalanceEntries.txtStockDesc.Text = Me.txtItemName.EditValue
            frm600_12OpeningBalanceEntries.txtStockCode.Text = StockNo
            frm600_12OpeningBalanceEntries.txtOpeningBalance.EditValue = Me.txtOpeningBalance.EditValue
            frm600_12OpeningBalanceEntries.txtUnitOfMeasure.EditValue = Me.txtGSUoM.EditValue
            frm600_12OpeningBalanceEntries.txtUnitPrice.EditValue = Me.txtCostPrice.EditValue

            frm600_12OpeningBalanceEntries.txtStockDesc.Enabled = False
            frm600_12OpeningBalanceEntries.txtStockCode.Enabled = False
            frm600_12OpeningBalanceEntries.txtOpeningBalance.Enabled = False
            frm600_12OpeningBalanceEntries.txtUnitOfMeasure.Enabled = False
            frm600_12OpeningBalanceEntries.txtUnitPrice.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error occured while Open Item Opening Balance entry form, Please try again." & vbCrLf & ex.Message, "Error Occured", MessageBoxButtons.OK)
        End Try
    End Sub
 

    Private Sub txtOpeningBalance_EditValueChanged(sender As Object, e As EventArgs) Handles txtOpeningBalance.EditValueChanged
        If Me.btnSave.Caption = "Update" Then
            If Not String.IsNullOrEmpty(ConvertIfNull(Me.txtOpeningBalance.EditValue)) Then
                If Me.txtOpeningBalance.EditValue <> Me.txtOpeningBalance.OldEditValue Then
                    InsertOpeningBalance(Me.txtStockCode.EditValue, Me.txtOpeningBalance.EditValue, Me.txtCostPrice.EditValue, Me.txtGSUoM.EditValue)
                End If
            End If
        End If
    End Sub

    Private Sub repoEditDeliveryNoteNo_Click(sender As Object, e As EventArgs) Handles repoEditDeliveryNoteNo.Click
        Try
            Dim strDeliveryNoteNo As String = Me.gvDeliveryNotes.GetRowCellValue(Me.gvDeliveryNotes.FocusedRowHandle, "DeliveryNoteNo")
            If CheckIfNull(strDeliveryNoteNo) = False Then

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
                frm601_05DeliveryNoteEdit.isExecutedFrom_frm600_01InventoryStockEdit = True

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
                frm601_05DeliveryNoteEdit.RetrieveDeliveryMaster(strDeliveryNoteNo)

                frm601_05DeliveryNoteEdit.txtDeliveryNoteNo.Enabled = False
                frm601_05DeliveryNoteEdit.DisableApprovedVoucherEditing(strDeliveryNoteNo)
                frm601_05DeliveryNoteEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub repoEditReceiptNo_Click(sender As Object, e As EventArgs) Handles repoEditReceiptNo.Click
        Try
            Dim strReceiptNo As String = Me.gvReceipts.GetRowCellValue(Me.gvReceipts.FocusedRowHandle, "ReceiptNo")
            If CheckIfNull(strReceiptNo) = False Then

                Dim frm601_09MaterialReceiptEdit As New frm601_09MaterialReceiptEdit
                frm601_09MaterialReceiptEdit.ObjForm = Me
                frm601_09MaterialReceiptEdit.txtReceiptNo.Enabled = False
                frm601_09MaterialReceiptEdit.btnSave.Caption = "Update"

                frm601_09MaterialReceiptEdit.strLogonUser = Me.strLogOnUser
                frm601_09MaterialReceiptEdit.intLogOnUserID = Me.intLogOnUserID
                frm601_09MaterialReceiptEdit.intLogOnUserLevel = Me.intLogOnUserLevel
                frm601_09MaterialReceiptEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
                frm601_09MaterialReceiptEdit.intLogOnDivision = Me.intLogOnDivision
                frm601_09MaterialReceiptEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
                frm601_09MaterialReceiptEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel
                frm601_09MaterialReceiptEdit.isExecutedFrom_frm600_01InventoryStockEdit = True

                Dim SalesPersonCode As String = ""
                SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

                If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                    frm601_09MaterialReceiptEdit.txtSalesPerson.Enabled = True
                Else
                    frm601_09MaterialReceiptEdit.txtSalesPerson.Enabled = False
                End If

                frm601_09MaterialReceiptEdit.Show()

                frm601_09MaterialReceiptEdit.RetrieveReceiptMaster(strReceiptNo)

                frm601_09MaterialReceiptEdit.txtReceiptNo.Enabled = False
                frm601_09MaterialReceiptEdit.DisableApprovedVoucherEditing(strReceiptNo)
                frm601_09MaterialReceiptEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub printComponentPurchaseDetails_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles printComponentPurchaseDetails.CreateReportHeaderArea
        Dim brick As DevExpress.XtraPrinting.TextBrick
        brick = e.Graph.DrawString("Stock Description: " & Me.txtItemName.EditValue, Color.Navy, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
        brick.Font = New Font("Arial", 12)
        brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)

    End Sub

    Private Sub btnPrintPurchaseDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPurchaseDetails.ItemClick
        Me.printComponentPurchaseDetails.CreateDocument()
        Me.printComponentPurchaseDetails.ShowPreview()
    End Sub

    Private Sub btnSetAsDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetAsDefaultLayout.ItemClick
        Me.SetDefaultLayout_gvStockCard()
        Me.SetDefaultLayout_gvPayroll()
        Me.SetDefaultLayout_gvQuotations()
        Me.SetDefaultLayout_gvPurchaseOrders()
        Me.SetDefaultLayout_gvDeliveryNotes()
        Me.SetDefaultLayout_gvReceipts()
        Me.SetDefaultLayout_gvEmpDocuments()
        Me.SetDefaultLayout_gvPurchases()
        '
        MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#Region "Set Default Layout"
    Private Sub SetDefaultLayout_gvStockCard()
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvStockCard"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvStockCard))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvStockCard))
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetDefaultLayout_gvPayroll()
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvPayroll"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvPayroll))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvPayroll))
            End If

        Catch ex As Exception

        End Try
    End Sub
    '
    Private Sub SetDefaultLayout_gvQuotations()
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvQuotations"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvQuotations))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvQuotations))
            End If

        Catch ex As Exception

        End Try
    End Sub
    '
    Private Sub SetDefaultLayout_gvPurchaseOrders()
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvPurchaseOrders"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvPurchaseOrders))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvPurchaseOrders))
            End If

        Catch ex As Exception

        End Try
    End Sub
    '
    Private Sub SetDefaultLayout_gvDeliveryNotes()
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvDeliveryNotes"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvDeliveryNotes))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvDeliveryNotes))
            End If

        Catch ex As Exception

        End Try
    End Sub
    '
    Private Sub SetDefaultLayout_gvReceipts()
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvReceipts"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvReceipts))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvReceipts))
            End If

        Catch ex As Exception

        End Try
    End Sub
    '
    Private Sub SetDefaultLayout_gvPurchases()
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvPurchases"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvPurchases))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvPurchases))
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub SetDefaultLayout_gvEmpDocuments()
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvEmpDocuments"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromView(Me.gvEmpDocuments))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromView(Me.gvEmpDocuments))
            End If

        Catch ex As Exception

        End Try
    End Sub


#End Region

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Me.ResetLayout_gvStockCard()
        Me.ResetLayout_gvPayroll()
        Me.ResetLayout_gvQuotations()
        Me.ResetLayout_gvPurchaseOrders()
        Me.ResetLayout_gvDeliveryNotes()
        Me.ResetLayout_gvReceipts()
        Me.ResetLayout_gvEmpDocuments()
        Me.ResetLayout_gvPurchases()

        MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

#Region "Reset Layout "
    Private Sub ResetLayout_gvStockCard()
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvStockCard"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetLayout_gvPayroll()
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvPayroll"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetLayout_gvQuotations()
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvQuotations"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

            End If
        Catch ex As Exception

        End Try
    End Sub
    '
    Private Sub ResetLayout_gvPurchaseOrders()
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvPurchaseOrders"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

            End If
        Catch ex As Exception

        End Try
    End Sub
    '
    Private Sub ResetLayout_gvDeliveryNotes()
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvDeliveryNotes"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

            End If
        Catch ex As Exception

        End Try
    End Sub
    '
    Private Sub ResetLayout_gvReceipts()
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvReceipts"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetLayout_gvEmpDocuments()
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvEmpDocuments"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

            End If
        Catch ex As Exception

        End Try
    End Sub

    '
    Private Sub ResetLayout_gvPurchases()
        Try
            Dim formID As String = "frm600_01InventoryStockEdit_gvPurchases"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DisableAllControls()
        DisableAllControlInTabPage(Me.tabStockDetails)
        DisableAllControlInTabPage(Me.tabItemDetails)

        Me.btnSave.Enabled = False
        Me.btnSaveAndClose.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnBack.Enabled = True


        For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
            If tabItemDetails.TabPages(i).Name = "pageUnitConversion" Then
                tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)

                Me.btnAddNewUnitConversion.Enabled = False
                Me.gcUnitConvertion.Enabled = False
                Exit For
            End If
        Next

        For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
            If tabItemDetails.TabPages(i).Name = "pageDocuments" Then
                tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)

                Me.btnAddDocuments.Enabled = False
                Me.btnMergeSelectedFiles.Enabled = False
                Me.btnSaveSeperateFiles.Enabled = False
                Exit For
            End If
        Next

        For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
            If tabItemDetails.TabPages(i).Name = "pageDeliveryNotes" Then
                tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)
                colDeliveryNoteNo.OptionsColumn.AllowEdit = False
                colDeliveryNoteNo.OptionsColumn.AllowFocus = False


                Exit For
            End If
        Next

        For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
            If tabItemDetails.TabPages(i).Name = "pageItemsReceived" Then
                tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)
                colReceiptNo.OptionsColumn.AllowEdit = False
                colReceiptNo.OptionsColumn.AllowFocus = False

                Exit For
            End If
        Next

        'Focus to pageAttributes
        For i As Integer = 0 To tabItemDetails.TabPages.Count - 1
            If tabItemDetails.TabPages(i).Name = "pageAttributes" Then
                tabItemDetails.SelectedTabPage = tabItemDetails.TabPages(i)
                Exit For
            End If
        Next


    End Sub

    Private Sub btnViewStockMovementReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnViewStockMovementReport.ItemClick
        Try
            Dim frm600_17StockMovementReport As New frm600_17StockMovementReport
            frm600_17StockMovementReport.ObjForm = Me

            frm600_17StockMovementReport.strLogOnUser = Me.strLogOnUser
            frm600_17StockMovementReport.intLogOnUserID = Me.intLogOnUserID
            frm600_17StockMovementReport.intLogOnUserLevel = Me.intLogOnUserLevel
            frm600_17StockMovementReport.intLogOnAccessLevel = Me.intLogOnAccessLevel
            'frm600_07InventoryStockWtStores.intLogOnDivision = Me.intLogOnDivision
            'frm601_22InventoryByDate.intLogOnHRLevelCode = Me.intLogOnHRLevelCode

            'frm601_22InventoryByDate.txtStartDate.EditValue = Me.txtStartDate.EditValue
            'frm600_17StockMovementReport.txtEndDate.EditValue = Me.txtEndDate.EditValue
            frm600_17StockMovementReport.IsOnlyOneStockItem = True
            frm600_17StockMovementReport.strStockCode = Me.txtStockCode.EditValue

            frm600_17StockMovementReport.Show()

        Catch ex As Exception
            'MessageBox.Show("Error on Loading Invoice with Details.", "Invoice with Details form failed to load.", MessageBoxButtons.OK)
        End Try
    End Sub

#End Region


End Class