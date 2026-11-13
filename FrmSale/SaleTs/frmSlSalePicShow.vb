Imports System.Net
Imports System.IO

Public Class frmSlSalePicShow
    Dim ftpFiles3 As ArrayList
    Dim picIndex As Integer = 0
    Dim idSale_R As Integer = 0
    Dim stpage As Integer = 0
    Dim eEvent As eProcess
    Dim vlocation As Point

    Enum eProcess
        eShowBillSale
        eView
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idSale As String, ByVal vPoint As Point)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eShowBillSale 'รับทราบ/ตรวจสอบ/อนุมัติ
                stpage = 1
            Case eProcess.eView 'ดูข้อมูล
                stpage = 2
        End Select
        eEvent = aProcess
        idSale_R = idSale
        vlocation = vPoint
    End Sub

    Private Sub frmSlSalePicShow_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        mdLoadShow()
        If stpage = 1 Then
            Me.Location = New Point(vlocation.X + 1190, vlocation.Y) 'รับทราบ/ตรวจสอบ/อนุมัติ
        End If

        '-------Get Pic -------------'
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/SAM/SaleTs/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))
        Dim y As Integer = 0
        Dim Str() As String
        ftpFiles3 = New ArrayList

        While Not (reader.EndOfStream)
            ftpFiles3.Add(reader.ReadLine())
            Str = ftpFiles3.Item(y).ToString().Split("_")
            If (Str(0) <> idSale_R.ToString) Then
                ftpFiles3.RemoveAt(y)
            Else
                y += 1
            End If
        End While

        If ftpFiles3.Count > 0 Then 'มีรูป
            Dim strUrl As String = "http://" & sHost & sFtpPathMain & "/SAM/SaleTs/" & ftpFiles3.Item(0).ToString()
            PictureBox1.Image = getImg(strUrl)
            picIndex = 0

            'check next pic
            If ftpFiles3.Count - 1 > picIndex Then 'มีรูปถัดไป
                Me.btnNext.Enabled = True
            End If
            Me.lblNumOfPic.Text = (picIndex + 1) & " Of " & ftpFiles3.Count
        Else
            Dim strUrl As String = ""
            PictureBox1.Image = getImg(strUrl)
            picIndex = 0

            'check next pic
            If ftpFiles3.Count - 1 > picIndex Then 'มีรูปถัดไป
                Me.btnNext.Enabled = True
            End If
            Me.lblNumOfPic.Text = "0 Of 0"
            Me.btnPreview.Enabled = False
        End If


        mdLoadCommitt()
    End Sub

    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim MyWebClient As New System.Net.WebClient
        Try
            Dim ImageInBytes() As Byte = MyWebClient.DownloadData(url)
            Dim ImageStream As New IO.MemoryStream(ImageInBytes)
            Dim pic As System.Drawing.Image = New System.Drawing.Bitmap(ImageStream)
            Return pic
        Catch ex As Exception
            Dim pic As System.Drawing.Image = SAM.My.Resources.Resources.noimage
            Return pic
        End Try
    End Function

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        mdLoadShow()
        Dim strUrl As String = "http://" & sHost & sFtpPathMain & "/SAM/SaleTs/" & ftpFiles3.Item(picIndex + 1).ToString()
        PictureBox1.Image = getImg(strUrl)
        picIndex = picIndex + 1

        'check next pic
        If ftpFiles3.Count - 1 > picIndex Then 'มีรูปถัดไป
            Me.btnNext.Enabled = True
        Else
            Me.btnNext.Enabled = False
        End If

        'Check pre pic
        If picIndex <> 0 Then
            Me.btnPrv.Enabled = True
        Else
            Me.btnPrv.Enabled = False
        End If
        Me.lblNumOfPic.Text = (picIndex + 1) & " Of " & ftpFiles3.Count

        mdLoadCommitt()
    End Sub

    Private Sub btnPrv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrv.Click
        mdLoadShow()
        Dim strUrl As String = "http://" & sHost & sFtpPathMain & "/SAM/SaleTs/" & ftpFiles3.Item(picIndex - 1).ToString()
        PictureBox1.Image = getImg(strUrl)
        picIndex = picIndex - 1

        'check next pic
        If ftpFiles3.Count - 1 > picIndex Then 'มีรูปถัดไป
            Me.btnNext.Enabled = True
        Else
            Me.btnNext.Enabled = False
        End If

        'Check pre pic
        If picIndex <> 0 Then
            Me.btnPrv.Enabled = True
        Else
            Me.btnPrv.Enabled = False
        End If
        Me.lblNumOfPic.Text = (picIndex + 1) & " Of " & ftpFiles3.Count

        mdLoadCommitt()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        '*************** CODE No Show Duplicate ****************'
        Try
            My.Computer.Network.DownloadFile("http://" & sHost & sFtpPathMain & "SAM/SaleTs/" & ftpFiles3.Item(picIndex).ToString, ftpFiles3.Item(picIndex))
            Dim myProcess As Process = System.Diagnostics.Process.Start(ftpFiles3.Item(picIndex))
        Catch ex As Exception
            System.IO.File.Delete(ftpFiles3.Item(picIndex))
            My.Computer.Network.DownloadFile("http://" & sHost & sFtpPathMain & "SAM/SaleTs/" & ftpFiles3.Item(picIndex).ToString, ftpFiles3.Item(picIndex))
            Dim myProcess As Process = System.Diagnostics.Process.Start(ftpFiles3.Item(picIndex))
        End Try

    End Sub

 
End Class