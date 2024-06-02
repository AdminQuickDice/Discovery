Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.Images
Imports System.Drawing
Imports System.Windows.Media.Imaging
Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class frm601_31JOImages

    Public strLogonUser As String
    Public intLogOnUserID As Integer
    Public intLogOnUserLevel As Integer
    Public intLogOnAccessLevel As Integer
    Public intLogOnDivision As Integer

    Dim ScannedFolderLocation As String = ""
    Private Sub GetTheImageFolderLocation(ByVal JobOrderNo As String, ByVal ReportType As String)
        GetCompanyDetails(1)
        ScannedFolderLocation = ""
        ScannedFolderLocation = gScannedLocation
        ScannedFolderLocation = gScannedLocation & "JobOrderImages\" & JobOrderNo & "-" & ReportType & "-"
    End Sub
    Private Sub frm601_31JOImages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get the Image Folder Location and Keep it in ScannedFolderLocation variable
        Me.GetTheImageFolderLocation(Me.txtJobOrderNo.EditValue, Me.txtJobOrderType.EditValue)
    End Sub

    Public Sub LoadImages(ByVal ImageControl As DevExpress.XtraEditors.PictureEdit, ByVal ImageNo As String)
        Dim ImageFileName As String = ""
        ImageFileName = ScannedFolderLocation & ImageNo & ".jpg"
        Try
            If System.IO.File.Exists(ImageFileName) = True Then
                Dim img1 As Image = Image.FromFile(ImageFileName)
                ImageControl.EditValue = img1
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Please try again or contact IT Department.", "Error on Reading", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub LoadAllImages()
        Me.LoadImages(Me.PictureEdit1, "01")
        Me.LoadImages(Me.PictureEdit2, "02")
        Me.LoadImages(Me.PictureEdit3, "03")
        Me.LoadImages(Me.PictureEdit4, "04")
        Me.LoadImages(Me.PictureEdit5, "05")
        Me.LoadImages(Me.PictureEdit6, "06")
        Me.LoadImages(Me.PictureEdit7, "07")
        Me.LoadImages(Me.PictureEdit8, "08")
        Me.LoadImages(Me.PictureEdit9, "09")
        Me.LoadImages(Me.PictureEdit10, "10")
        Me.LoadImages(Me.PictureEdit11, "11")
        Me.LoadImages(Me.PictureEdit12, "12")
        Me.LoadImages(Me.PictureEdit13, "13")
        Me.LoadImages(Me.PictureEdit14, "14")
        Me.LoadImages(Me.PictureEdit15, "15")

        Me.LoadImages(Me.PictureEdit16, "16")
        Me.LoadImages(Me.PictureEdit17, "17")
        Me.LoadImages(Me.PictureEdit18, "18")
        Me.LoadImages(Me.PictureEdit19, "19")
        Me.LoadImages(Me.PictureEdit20, "20")
        Me.LoadImages(Me.PictureEdit21, "21")
        Me.LoadImages(Me.PictureEdit22, "22")
        Me.LoadImages(Me.PictureEdit23, "23")
        Me.LoadImages(Me.PictureEdit24, "24")
        Me.LoadImages(Me.PictureEdit25, "25")
        Me.LoadImages(Me.PictureEdit26, "26")
        Me.LoadImages(Me.PictureEdit27, "27")
        Me.LoadImages(Me.PictureEdit28, "28")
        Me.LoadImages(Me.PictureEdit29, "29")
        Me.LoadImages(Me.PictureEdit30, "30")

        Me.LoadImages(Me.PictureEdit31, "31")
        Me.LoadImages(Me.PictureEdit32, "32")
        Me.LoadImages(Me.PictureEdit33, "33")
        Me.LoadImages(Me.PictureEdit34, "34")
        Me.LoadImages(Me.PictureEdit35, "35")
        Me.LoadImages(Me.PictureEdit36, "36")
        Me.LoadImages(Me.PictureEdit37, "37")
        Me.LoadImages(Me.PictureEdit38, "38")
        Me.LoadImages(Me.PictureEdit39, "39")
        Me.LoadImages(Me.PictureEdit40, "40")
        Me.LoadImages(Me.PictureEdit41, "41")
        Me.LoadImages(Me.PictureEdit42, "42")
        Me.LoadImages(Me.PictureEdit43, "43")
        Me.LoadImages(Me.PictureEdit44, "44")
        Me.LoadImages(Me.PictureEdit45, "45")

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadAllImages()
    End Sub

    Public Sub SaveImages(ByVal ImageControl As DevExpress.XtraEditors.PictureEdit, ByVal ImageNo As String)
        Try
            Dim ImageFileName As String = ""
            ImageFileName = ScannedFolderLocation & ImageNo & ".jpg"

            If ImageControl.EditValue Is Nothing Then
                If System.IO.File.Exists(ImageFileName) = True Then
                    System.IO.File.Delete(ImageFileName)
                End If
            Else
                Dim currentImage As Bitmap = TryCast(ImageControl.EditValue, Bitmap)
                Dim savedImage As New Bitmap(currentImage, ImageControl.ClientSize.Width, ImageControl.ClientSize.Height)

                If System.IO.File.Exists(ImageFileName) = True Then
                    ImageControl.Image.Dispose()
                    'ImageControl.Image = Nothing
                    System.IO.File.Delete(ImageFileName)

                    savedImage.Save(ImageFileName)
                Else
                    savedImage.Save(ImageFileName)
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message & vbCrLf & "Cannot save file to disk. Please try again or contact IT Department.", "Error on Reading", MessageBoxButtons.OK)

        End Try

    End Sub

    Public Sub SaveAllImages()
        Me.SaveImages(Me.PictureEdit1, "01")
        Me.SaveImages(Me.PictureEdit2, "02")
        Me.SaveImages(Me.PictureEdit3, "03")
        Me.SaveImages(Me.PictureEdit4, "04")
        Me.SaveImages(Me.PictureEdit5, "05")
        Me.SaveImages(Me.PictureEdit6, "06")
        Me.SaveImages(Me.PictureEdit7, "07")
        Me.SaveImages(Me.PictureEdit8, "08")
        Me.SaveImages(Me.PictureEdit9, "09")
        Me.SaveImages(Me.PictureEdit10, "10")
        Me.SaveImages(Me.PictureEdit11, "11")
        Me.SaveImages(Me.PictureEdit12, "12")
        Me.SaveImages(Me.PictureEdit13, "13")
        Me.SaveImages(Me.PictureEdit14, "14")
        Me.SaveImages(Me.PictureEdit15, "15")

        Me.SaveImages(Me.PictureEdit16, "16")
        Me.SaveImages(Me.PictureEdit17, "17")
        Me.SaveImages(Me.PictureEdit18, "18")
        Me.SaveImages(Me.PictureEdit19, "19")
        Me.SaveImages(Me.PictureEdit20, "20")
        Me.SaveImages(Me.PictureEdit21, "21")
        Me.SaveImages(Me.PictureEdit22, "22")
        Me.SaveImages(Me.PictureEdit23, "23")
        Me.SaveImages(Me.PictureEdit24, "24")
        Me.SaveImages(Me.PictureEdit25, "25")
        Me.SaveImages(Me.PictureEdit26, "26")
        Me.SaveImages(Me.PictureEdit27, "27")
        Me.SaveImages(Me.PictureEdit28, "28")
        Me.SaveImages(Me.PictureEdit29, "29")
        Me.SaveImages(Me.PictureEdit30, "30")

        Me.SaveImages(Me.PictureEdit31, "31")
        Me.SaveImages(Me.PictureEdit32, "32")
        Me.SaveImages(Me.PictureEdit33, "33")
        Me.SaveImages(Me.PictureEdit34, "34")
        Me.SaveImages(Me.PictureEdit35, "35")
        Me.SaveImages(Me.PictureEdit36, "36")
        Me.SaveImages(Me.PictureEdit37, "37")
        Me.SaveImages(Me.PictureEdit38, "38")
        Me.SaveImages(Me.PictureEdit39, "39")
        Me.SaveImages(Me.PictureEdit40, "40")
        Me.SaveImages(Me.PictureEdit41, "41")
        Me.SaveImages(Me.PictureEdit42, "42")
        Me.SaveImages(Me.PictureEdit43, "43")
        Me.SaveImages(Me.PictureEdit44, "44")
        Me.SaveImages(Me.PictureEdit45, "45")

    End Sub
    Private Sub btnSaveImages_Click(sender As Object, e As EventArgs) Handles btnSaveImages.Click

        SaveAllImages()
        MessageBox.Show("All Images are stored to the Server.", "Saved Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rpt1 As New rpt601_31JOImages

        rpt1.intLogOnAccessLevel = Me.intLogOnAccessLevel
        rpt1.intLogOnUserID = Me.intLogOnUserID
        rpt1.intLogOnUserLevel = Me.intLogOnUserLevel
        rpt1.strLogOnUser = Me.strLogonUser

        rpt1.JobOrderNo = Me.txtJobOrderNo.EditValue
        rpt1.JobOrderType = Me.txtJobOrderType.EditValue
        rpt1.ShowPreview()

    End Sub

    Dim LastDir As String = ""
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Dim fbd As New OpenFileDialog
            If LastDir = "" Then Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            With fbd
                .Title = "Select multiple files" ' Title of your dialog box
                .InitialDirectory = LastDir ' Directory appear when you open your dialog.
                .Multiselect = True 'allow user to select multiple items (files)
                .Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            End With

            If fbd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then ' check user click ok or cancel
                LastDir = Path.GetDirectoryName(fbd.FileName) 'Update your last Directory.

                ' do your stuf here i.e add selected files to listbox etc.
                For Each mFile As String In fbd.FileNames
                    'CheckedListBox1.Items.Add(mFile, True)
                    Dim img1 As Image = Image.FromFile(mFile)
                    Me.ImageCollection1.AddImage(img1)
                Next

                AssignImages()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AssignImages()
        Try
            Me.PictureEdit1.Image = Me.ImageCollection1.Images(0)
            Me.PictureEdit2.Image = Me.ImageCollection1.Images(1)
            Me.PictureEdit3.Image = Me.ImageCollection1.Images(2)
            Me.PictureEdit4.Image = Me.ImageCollection1.Images(3)
            Me.PictureEdit5.Image = Me.ImageCollection1.Images(4)
            Me.PictureEdit6.Image = Me.ImageCollection1.Images(5)
            Me.PictureEdit7.Image = Me.ImageCollection1.Images(6)
            Me.PictureEdit8.Image = Me.ImageCollection1.Images(7)
            Me.PictureEdit9.Image = Me.ImageCollection1.Images(8)
            Me.PictureEdit10.Image = Me.ImageCollection1.Images(9)
            Me.PictureEdit11.Image = Me.ImageCollection1.Images(10)
            Me.PictureEdit12.Image = Me.ImageCollection1.Images(11)
            Me.PictureEdit13.Image = Me.ImageCollection1.Images(12)
            Me.PictureEdit14.Image = Me.ImageCollection1.Images(13)
            Me.PictureEdit15.Image = Me.ImageCollection1.Images(14)

            Me.PictureEdit16.Image = Me.ImageCollection1.Images(15)
            Me.PictureEdit17.Image = Me.ImageCollection1.Images(16)
            Me.PictureEdit18.Image = Me.ImageCollection1.Images(17)
            Me.PictureEdit19.Image = Me.ImageCollection1.Images(18)
            Me.PictureEdit20.Image = Me.ImageCollection1.Images(19)
            Me.PictureEdit21.Image = Me.ImageCollection1.Images(20)
            Me.PictureEdit22.Image = Me.ImageCollection1.Images(21)
            Me.PictureEdit23.Image = Me.ImageCollection1.Images(22)
            Me.PictureEdit24.Image = Me.ImageCollection1.Images(23)
            Me.PictureEdit25.Image = Me.ImageCollection1.Images(24)
            Me.PictureEdit26.Image = Me.ImageCollection1.Images(25)
            Me.PictureEdit27.Image = Me.ImageCollection1.Images(26)
            Me.PictureEdit28.Image = Me.ImageCollection1.Images(27)
            Me.PictureEdit29.Image = Me.ImageCollection1.Images(28)
            Me.PictureEdit30.Image = Me.ImageCollection1.Images(29)

            Me.PictureEdit31.Image = Me.ImageCollection1.Images(30)
            Me.PictureEdit32.Image = Me.ImageCollection1.Images(31)
            Me.PictureEdit33.Image = Me.ImageCollection1.Images(32)
            Me.PictureEdit34.Image = Me.ImageCollection1.Images(33)
            Me.PictureEdit35.Image = Me.ImageCollection1.Images(34)
            Me.PictureEdit36.Image = Me.ImageCollection1.Images(35)
            Me.PictureEdit37.Image = Me.ImageCollection1.Images(36)
            Me.PictureEdit38.Image = Me.ImageCollection1.Images(37)
            Me.PictureEdit39.Image = Me.ImageCollection1.Images(38)
            Me.PictureEdit40.Image = Me.ImageCollection1.Images(39)
            Me.PictureEdit41.Image = Me.ImageCollection1.Images(40)
            Me.PictureEdit42.Image = Me.ImageCollection1.Images(41)
            Me.PictureEdit43.Image = Me.ImageCollection1.Images(42)
            Me.PictureEdit44.Image = Me.ImageCollection1.Images(43)
            Me.PictureEdit45.Image = Me.ImageCollection1.Images(44)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub DeleteImages(ByVal ImageControl As DevExpress.XtraEditors.PictureEdit, ByVal ImageNo As String)
        Dim ImageFileName As String = ""
        ImageFileName = ScannedFolderLocation & ImageNo & ".jpg"
        Try
            If System.IO.File.Exists(ImageFileName) = True Then

                'Dim tempImage As Image = Image.FromFile("Z:\JobOrderImages\BlankImage.jpg")
                'Dim tempBitmap As Bitmap = New Bitmap(tempImage)
                'ImageControl.Image = tempBitmap

                ImageControl.Image.Dispose()
                ImageControl.Image = Nothing
                System.IO.File.Delete(ImageFileName)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Please try again or contact IT Department.", "Error on Reading", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub DeleteAllImages()
        Try
            Me.DeleteImages(Me.PictureEdit1, "01")
            Me.DeleteImages(Me.PictureEdit2, "02")
            Me.DeleteImages(Me.PictureEdit3, "03")
            Me.DeleteImages(Me.PictureEdit4, "04")
            Me.DeleteImages(Me.PictureEdit5, "05")
            Me.DeleteImages(Me.PictureEdit6, "06")
            Me.DeleteImages(Me.PictureEdit7, "07")
            Me.DeleteImages(Me.PictureEdit8, "08")
            Me.DeleteImages(Me.PictureEdit9, "09")
            Me.DeleteImages(Me.PictureEdit10, "10")
            Me.DeleteImages(Me.PictureEdit11, "11")
            Me.DeleteImages(Me.PictureEdit12, "12")
            Me.DeleteImages(Me.PictureEdit13, "13")
            Me.DeleteImages(Me.PictureEdit14, "14")
            Me.DeleteImages(Me.PictureEdit15, "15")

            Me.DeleteImages(Me.PictureEdit16, "16")
            Me.DeleteImages(Me.PictureEdit17, "17")
            Me.DeleteImages(Me.PictureEdit18, "18")
            Me.DeleteImages(Me.PictureEdit19, "19")
            Me.DeleteImages(Me.PictureEdit20, "20")
            Me.DeleteImages(Me.PictureEdit21, "21")
            Me.DeleteImages(Me.PictureEdit22, "22")
            Me.DeleteImages(Me.PictureEdit23, "23")
            Me.DeleteImages(Me.PictureEdit24, "24")
            Me.DeleteImages(Me.PictureEdit25, "25")
            Me.DeleteImages(Me.PictureEdit26, "26")
            Me.DeleteImages(Me.PictureEdit27, "27")
            Me.DeleteImages(Me.PictureEdit28, "28")
            Me.DeleteImages(Me.PictureEdit29, "29")
            Me.DeleteImages(Me.PictureEdit30, "30")

            Me.DeleteImages(Me.PictureEdit31, "31")
            Me.DeleteImages(Me.PictureEdit32, "32")
            Me.DeleteImages(Me.PictureEdit33, "33")
            Me.DeleteImages(Me.PictureEdit34, "34")
            Me.DeleteImages(Me.PictureEdit35, "35")
            Me.DeleteImages(Me.PictureEdit36, "36")
            Me.DeleteImages(Me.PictureEdit37, "37")
            Me.DeleteImages(Me.PictureEdit38, "38")
            Me.DeleteImages(Me.PictureEdit39, "39")
            Me.DeleteImages(Me.PictureEdit40, "40")
            Me.DeleteImages(Me.PictureEdit41, "41")
            Me.DeleteImages(Me.PictureEdit42, "42")
            Me.DeleteImages(Me.PictureEdit43, "43")
            Me.DeleteImages(Me.PictureEdit44, "44")
            Me.DeleteImages(Me.PictureEdit45, "45")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        DeleteAllImages()
        SaveAllImages()

    End Sub
End Class