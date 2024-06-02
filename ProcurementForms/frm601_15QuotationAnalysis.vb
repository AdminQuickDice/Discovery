Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraReports.UI
Public Class frm601_15QuotationAnalysis

    Public frm601_15QuotationAnalysisIsClosed As Boolean
    'User Access Controls
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer
    Public intLogOnInventoryAccessLevel As Integer

    Public intLogOnInventoryMPRAccessLevel As Integer

#Region "Test Codes"

    'Private Sub PivotGrid_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PivotGridControl1.MouseDown
    '    If e.Button <> System.Windows.Forms.MouseButtons.Right Then
    '        Return
    '    End If

    '    Dim hitInfo = Me.PivotGridControl1.CalcHitInfo(e.Location)

    '    If hitInfo.HitTest = PivotGridHitTest.Cell Then
    '        If Me.PivotGridControl1.Cells.MultiSelection.SelectedCells.Count <= 1 Then
    '            Me.PivotGridControl1.Cells.Selection = New Rectangle(hitInfo.CellInfo.ColumnIndex, hitInfo.CellInfo.RowIndex, 1, 1)

    '            Me.PopupMenu1.ShowPopup(MousePosition)

    '            'Dim strVoucherNoAndType As String = e.GetFieldValue(fieldVoucherTypeAndNo)
    '            'Dim IndexOfVoucher As Integer = strVoucherNoAndType.IndexOf("::")

    '            'Dim strlength As Integer = strVoucherNoAndType.Length
    '            'Dim IndexOfVoucherEnd As Integer = IndexOfVoucher + 2
    '            'Dim strToVoucherNo As Integer = strlength - IndexOfVoucherEnd

    '            'Dim strVoucherNo As String = strVoucherNoAndType.Substring(strlength - strToVoucherNo)
    '            'Dim strVoucherType As String = strVoucherNoAndType.Substring(0, IndexOfVoucher)

    '        End If
    '    End If
    'End Sub

    'Private Sub pivotGridControl1_CustomAppearance(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles PivotGridControl1.CustomAppearance
    '    If e.DataField IsNot Nothing AndAlso e.RowValueType = DevExpress.XtraPivotGrid.PivotGridValueType.Value Then
    '        If e.Value IsNot Nothing AndAlso Convert.ToBoolean(e.Value) Then
    '            e.Appearance.BackColor = Color.Yellow
    '        Else
    '            e.Appearance.BackColor = Color.Orange
    '        End If
    '    End If
    'End Sub

    'Private Sub pivotGridControl1_CustomAppearance(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles pvgQuotationAnalysis.CustomAppearance
    'Dim selected_row As Integer
    'Dim selected_column As Integer
    'selected_column = pivotGridControl1.Cells.FocusedCell.X
    'selected_row = pivotGridControl1.Cells.FocusedCell.Y

    'If e.RowIndex = selected_row Then
    '    e.Appearance.BackColor = Color.Gold
    '    e.Appearance.BackColor2 = Color.Gold
    '    e.Appearance.ForeColor = Color.Black
    '    e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
    'End If

    'If e.ColumnIndex = selected_column Then
    '    e.Appearance.BackColor = Color.Gold
    '    e.Appearance.BackColor2 = Color.Gold
    '    e.Appearance.ForeColor = Color.Black
    '    e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
    'End If

    'If e.DataField = "fieldRFQChildSlNo" IsNot Nothing AndAlso e.RowValueType = DevExpress.XtraPivotGrid.PivotGridValueType.Value Then
    '    If e.Value IsNot Nothing AndAlso Convert.ToBoolean(e.Value) Then
    '        e.Appearance.BackColor = Color.Yellow
    '    Else
    '        e.Appearance.BackColor = Color.Orange
    '    End If
    'End If
    'End Sub


    'Private Sub pivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles pvgQuotationAnalysis.CustomCellDisplayText
    '    'If e.DataField <> Me.pvgQuotationAnalysis.Fields.GetFieldByName("fieldRFQChildSlNo") Then
    '    '    Return
    '    'End If
    '    'If e.RowValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal Then
    '    '    e.DisplayText = e.CreateDrillDownDataSource().RowCount
    '    'End If

    'End Sub
#End Region

#Region "Layout Settings"
    Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
        SaveFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            'My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
            Dim fileName As String = Me.SaveFileDialog1.FileName
            Me.pvgQuotationAnalysis.SaveLayoutToXml(fileName)
        End If
    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenLayout.ItemClick
        OpenFileDialog1.Filter = "XML Files (*.xml*)|*.xml"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Me.OpenFileDialog1.FileName
            Me.pvgQuotationAnalysis.RestoreLayoutFromXml(fileName)

        End If
    End Sub

    Private Sub btnSetDefaultLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetDefaultLayout.ItemClick
        'Check if the user has layout specified... then replace the layout, else insert new layout data
        Try
            Dim formID As String = "frm601_15QuotationAnalysis"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                UpdateXmlLayout(formID, Me.intLogOnUserID, GetStringFromPVG(Me.pvgQuotationAnalysis))
            Else
                InsertXmlLayout(Me.intLogOnUserID, formID, GetStringFromPVG(Me.pvgQuotationAnalysis))
            End If
            MessageBox.Show("Your current data layout has been set as default layout.", "Layout set as default", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

#End Region

    Private Sub frm20162VATInvoiceMasterView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.frm601_15QuotationAnalysisIsClosed = True
    End Sub

    Private Sub frm601_15QuotationAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If intLogOnInventoryAccessLevel = 99 Then
            If intLogOnInventoryMPRAccessLevel = 99 Then
                Me.Qry607_07RFQIssuedByMPRNoTableAdapter.Fill(Me.Dsfrm601_15QuotationAnalysis1.qry607_07RFQIssuedByMPRNo)
            Else
                Me.Qry607_07RFQIssuedByMPRNoTableAdapter.FillBySalesPersonUSERID(Me.Dsfrm601_15QuotationAnalysis1.qry607_07RFQIssuedByMPRNo, Me.intLogOnUserID)
            End If

        Else
            If intLogOnInventoryMPRAccessLevel = 99 Then
                Me.Qry607_07RFQIssuedByMPRNoTableAdapter.FillByInventoryMasterGroupID(Me.Dsfrm601_15QuotationAnalysis1.qry607_07RFQIssuedByMPRNo, Me.intLogOnInventoryAccessLevel)
            Else
                Me.Qry607_07RFQIssuedByMPRNoTableAdapter.FillByGroupBySalesPersonUserID(Me.Dsfrm601_15QuotationAnalysis1.qry607_07RFQIssuedByMPRNo, Me.intLogOnInventoryAccessLevel, Me.intLogOnUserID)
            End If


        End If
    End Sub

    Private Sub btnGroup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroup.ItemClick

        If Me.pvgQuotationAnalysis.OptionsView.ShowDataHeaders = True Then
            Me.pvgQuotationAnalysis.OptionsView.ShowDataHeaders = False
        Else
            Me.pvgQuotationAnalysis.OptionsView.ShowDataHeaders = True
        End If

        If Me.pvgQuotationAnalysis.OptionsView.ShowFilterHeaders = True Then
            Me.pvgQuotationAnalysis.OptionsView.ShowFilterHeaders = False
        Else
            Me.pvgQuotationAnalysis.OptionsView.ShowFilterHeaders = True
        End If

    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
        Me.PrintableComponentLink1.PrintingSystem.Document.AutoFitToPagesWidth = 1
    End Sub

    Private Sub btnViewAnalysis_Click(sender As Object, e As EventArgs) Handles btnViewAnalysis.Click
        Me.Qry607_08QuotationAnalysisPVGTableAdapter.FillByMPRNo(Me.Dsfrm601_15QuotationAnalysis.qry607_08QuotationAnalysisPVG, Me.txtMPRNo.EditValue)

        'Retrieve Panel Layout
        LoadLayoutFromDB_PVG(Me.intLogOnUserID, "frm601_15QuotationAnalysis", Me.pvgQuotationAnalysis)
    End Sub


    Dim SelectedRFQChildSlNo As Integer

    Private Sub PivotGridControl1_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles pvgQuotationAnalysis.CellDoubleClick
        SelectedRFQChildSlNo = e.GetFieldValue(fieldRFQChildSlNo)
        If CheckIfNull(SelectedRFQChildSlNo) = False Then
            GetMPRDetailsFromRFQChildNo(SelectedRFQChildSlNo)
            Me.PopupContainerControl1.Show()
        End If

    End Sub

    Private Sub btnBulkUpdate_Click(sender As Object, e As EventArgs) Handles btnBulkUpdate.Click
        If CheckIfNull(Me.strMPRNoFromRFQChild) = False Then
            If CheckIfNull(Me.strGSCodeFromRFQChild) = False Then
                Me.UpdateRFQChild_SetZeroToWon(strMPRNoFromRFQChild, strGSCodeFromRFQChild)

                If CheckIfNull(Me.strGSCodeFromRFQChild) = False Then
                    Me.UpdateRFQChildIsWon(SelectedRFQChildSlNo, Me.strLogOnUser, Me.txtReasonForSelection02.EditValue)
                Else
                    Me.UpdateRFQChildIsWon(SelectedRFQChildSlNo, Me.strLogOnUser, "")
                End If
                'Refresh Records
                Me.Qry607_08QuotationAnalysisPVGTableAdapter.FillByMPRNo(Me.Dsfrm601_15QuotationAnalysis.qry607_08QuotationAnalysisPVG, Me.txtMPRNo.EditValue)
                Me.txtReasonForSelection02.EditValue = ""


            End If
        End If

        Me.PopupContainerControl1.Hide()
    End Sub

    Private Sub UpdateRFQChildIsWon(ByVal RFQChildSlNo As Integer, ByVal UpdatedBy As String, ByVal ReasonForSelection As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp607_02UpdateRFQChild_IsWon"
            Dim paramRFQChildSlNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@RFQChildSlNo", SqlDbType.Int)
            Dim paramUpdatedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@UpdatedBy", SqlDbType.VarChar)
            Dim paramReasonForSelection As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@ReasonForSelection", SqlDbType.VarChar)

            paramRFQChildSlNo.Value = RFQChildSlNo
            paramUpdatedBy.Value = UpdatedBy
            paramReasonForSelection.Value = ReasonForSelection

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("Line Item has been set as Won for Ordering Process Successfully,", "Bid Won Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Line Item has been set as Won for Ordering Process failed", "Data update failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Private Sub UpdateRFQChild_SetZeroToWon(ByVal MPRNo As String, ByVal GSCode As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp607_03UpdateRFQChild_SetZeroToWon"
            Dim paramMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRNo", SqlDbType.VarChar)
            Dim paramGSCode As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@GSCode", SqlDbType.VarChar)

            paramMPRNo.Value = MPRNo
            paramGSCode.Value = GSCode

            SqlCommand1.ExecuteNonQuery()

        Catch ex As System.InvalidCastException
            MessageBox.Show("Line Item has been set as Won for Ordering Process failed", "Data update failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub

    Public strMPRNoFromRFQChild As String = ""
    Public strGSCodeFromRFQChild As String = ""

    Public Sub GetMPRDetailsFromRFQChildNo(ByVal RFQChildSlNo As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.ERPConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandText = "select  MPRNo, GSCode, RFQChildSlNo from qry607_06RFQDetails where RFQChildSlNo = '" & RFQChildSlNo & "'"
            Dim srStockReader As SqlClient.SqlDataReader
            srStockReader = SqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

            If srStockReader.HasRows() Then
                While srStockReader.Read()
                    strMPRNoFromRFQChild = srStockReader.Item("MPRNo")
                    strGSCodeFromRFQChild = srStockReader.Item("GSCode")

                End While
            End If
            srStockReader.Close()

        Catch ex As System.InvalidCastException
            MessageBox.Show(ex.Message)

        Finally
            Sqlconnection1.Close()

        End Try
    End Sub



#Region "Create Quotation"

    Private Sub btnCreateQuotation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateQuotation.ItemClick
        DialogResult = MessageBox.Show("You are about to create new Quotation." & vbCrLf & "Are you Sure want to continue creating Quotation?", "Confirm creating Quotation.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If DialogResult = System.Windows.Forms.DialogResult.Yes Then
            If CheckIfNull(Me.txtMPRNo.EditValue) = False Then

                'Get New Quotation Number
                GetCompanyDetails(1)
                GetCompanyDetails02(1)
                Dim NewQuotationNo As String = GetNewQuotationNo(gQuotationAbbrv, gInvoiceYearDigits, Date.Now, gIsResetQuoteInYear, gNoOfDigitsToInventoryQuotation)
                Me.CreateQuotationFromPR(NewQuotationNo, Me.txtMPRNo.EditValue, Me.strLogOnUser)
                Me.OpenQuotation(NewQuotationNo)

                ''Refresh the datagrid
                ''Me.Qry606_02PurchaseRequestChildTableAdapter.FillByMPRNo(Me.Dsfrm601_11PurchaseRequestEdit.qry606_02PurchaseRequestChild, Me.txtRequestNo.EditValue)

            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub OpenQuotation(ByVal QuotationNo As String)
        If CheckIfNull(QuotationNo) = False Then
            Dim frm601_01QuotationEdit As New frm601_01QuotationEdit
            frm601_01QuotationEdit.ObjForm = Me
            frm601_01QuotationEdit.txtQuotationNo.Enabled = False
            frm601_01QuotationEdit.btnSave.Caption = "Update"
            frm601_01QuotationEdit.strLogonUser = Me.strLogOnUser
            frm601_01QuotationEdit.intLogOnUserID = Me.intLogOnUserID
            frm601_01QuotationEdit.intLogOnUserLevel = Me.intLogOnUserLevel
            frm601_01QuotationEdit.intLogOnAccessLevel = Me.intLogOnAccessLevel
            frm601_01QuotationEdit.intLogOnDivision = Me.intLogOnDivision
            frm601_01QuotationEdit.intLogOnInventoryAccessLevel = Me.intLogOnInventoryAccessLevel
            frm601_01QuotationEdit.intLogOnInventoryMPRAccessLevel = Me.intLogOnInventoryMPRAccessLevel

            frm601_01QuotationEdit.isExecutedFrom_frm601_15QuotationAnalysis = True

            Dim SalesPersonCode As String = ""
            SalesPersonCode = GetSalesPersonCode(Me.intLogOnUserID)

            If Me.intLogOnInventoryMPRAccessLevel = 99 Then
                frm601_01QuotationEdit.txtSalesPerson.Enabled = True
            Else
                frm601_01QuotationEdit.txtSalesPerson.Enabled = False
            End If

            frm601_01QuotationEdit.Show()
            frm601_01QuotationEdit.RetrieveQuotationMaster(QuotationNo)
            frm601_01QuotationEdit.DisableApprovedVoucherEditing(QuotationNo)
            frm601_01QuotationEdit.DisableControlsForInventoryGroupMaster(Me.intLogOnInventoryAccessLevel)

            frm601_01QuotationEdit.txtQuotationNo.Enabled = False

        End If
    End Sub


    Private Sub CreateQuotationFromPR(ByVal QuotationNo As String, ByVal MPRNo As String, ByVal AddedBy As String)
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1
            SqlCommand1.CommandType = CommandType.StoredProcedure
            SqlCommand1.CommandText = "sp600_03InsertToQuotationFromEnquiry"
            Dim paramQuotationNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@QuotationNo", SqlDbType.VarChar)
            Dim paramMPRNo As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@MPRNo", SqlDbType.VarChar)
            Dim paramAddedBy As SqlClient.SqlParameter = SqlCommand1.Parameters.Add("@AddedBy", SqlDbType.VarChar)

            paramQuotationNo.Value = QuotationNo
            paramMPRNo.Value = MPRNo
            paramAddedBy.Value = AddedBy

            SqlCommand1.ExecuteNonQuery()
            MessageBox.Show("New Quotation is created successfully,", "Quotation created Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Quotation Creation failed, Please try again", "Quotation Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Sqlconnection1.Close()
        End Try
    End Sub


    Public Function GetNewQuotationNo(ByVal QuotationAbbr As String, ByVal YearInDigit As Integer, ByVal QuoteDate As Date, ByVal IsResetByYear As Boolean, ByVal NoOfDigits As Integer) As String
        Dim strNewQuotationNo As String = ""
        Dim Sqlconnection1 As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.IMSdbConnectionString)
        Try
            If Sqlconnection1.State = ConnectionState.Closed Then
                Sqlconnection1.Open()
            End If

            Dim SqlCommand1 As New SqlClient.SqlCommand
            SqlCommand1.Connection = Sqlconnection1

            If IsResetByYear = True Then
                SqlCommand1.CommandText = "select max(cast(right(QuoteNo, " & NoOfDigits & ") as int)) from tbl601_01QuotationMaster where QuoteNo like '" & QuotationAbbr & "%' AND Isnull(RevisionNo,0) = 0 and Year(QuoteDate) = '" & Year(QuoteDate).ToString & "'"
            Else
                SqlCommand1.CommandText = "select max(cast(right(QuoteNo, " & NoOfDigits & ") as int)) from tbl601_01QuotationMaster WHERE QuoteNo like '" & QuotationAbbr & "%' AND Isnull(RevisionNo,0) = 0"
            End If

            Dim int1 As Integer
            int1 = SqlCommand1.ExecuteScalar()
            int1 = int1 + 1

            strNewQuotationNo = "0000" & CStr(int1)
            strNewQuotationNo = Microsoft.VisualBasic.Right(strNewQuotationNo, NoOfDigits)

            If CheckIfNull(YearInDigit) = True Then
                YearInDigit = 0
            End If

            Dim strYear As String = Year(Now).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)

            strNewQuotationNo = strYear & "-" & strNewQuotationNo
            strNewQuotationNo = QuotationAbbr & strNewQuotationNo
            Return strNewQuotationNo

        Catch ex As System.InvalidCastException
            Dim strYear As String = Year(QuoteDate).ToString
            strYear = strYear.Substring(strYear.Length - YearInDigit, YearInDigit)
            strNewQuotationNo = QuotationAbbr & strYear & "-" & "0001"
            Return strNewQuotationNo

        Finally
            Sqlconnection1.Close()

        End Try
    End Function
#End Region

    Private Sub btnResetLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetLayout.ItemClick
        Try
            Dim formID As String = "frm601_15QuotationAnalysis"

            If CheckIfUserHasLayoutSaved(Me.intLogOnUserID, formID) = True Then
                DeleteXmlLayout(Me.intLogOnUserID, formID)

                MessageBox.Show("Your current data layout has been reset.", "Layout Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCloseMultiUpdates_Click(sender As Object, e As EventArgs) Handles btnCloseMultiUpdates.Click
        Me.PopupContainerControl1.Hide()
    End Sub
End Class