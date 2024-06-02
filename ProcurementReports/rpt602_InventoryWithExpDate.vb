Imports DevExpress.XtraReports.UI
Public Class rpt602_InventoryWithExpDate
    Public strLogOnUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer

    Private Sub rpt602_InventoryWithExpDate_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            GetCompanyDetails(1)
            Me.txtCompanyName.Text = gCompanyName
            Me.txtCompanyFullAddress.Text = gCompanyFullAddress
            Me.txtUserPrinting.Text = "Reported By: " & Me.strLogOnUser & " on " & Format(Date.Now, "dd-MMM-yyyy hh:mm tt")
            Me.txtSystemTitle.Text = gProductName

            Dim mybytearray As Byte() = gCompanyLogo
            Dim myimage As Image
            Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray)
            myimage = System.Drawing.Image.FromStream(ms)
            Me.txtCompanyLogo.Image = myimage

        Catch ex As Exception

        End Try
    End Sub
End Class