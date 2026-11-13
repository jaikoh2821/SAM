Imports System.Net
Imports System.IO

Public Class frmSlOrderPic
    Dim pidEx As String
    Dim tarray As New ArrayList
    Dim urlfile As String
    Dim stPage As Integer = 0
    Dim idOrderS As Integer = 0
    Dim idOrderDt_Rec As New DataTable
    Dim Result As DialogResult
    Public sDt_flagpic As New DataTable
    Dim ftpFiles3 As ArrayList
    Dim ftpFilesShow As ArrayList
    Dim eEvent As eProcess

    Enum eProcess
        eAddNew
        eEdit
        eView
        eViewFromSale
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idOrder As String, ByVal idOrderDt As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eAddNew 'เพิ่มรายการใหม่
                stPage = 1
            Case eProcess.eEdit 'แก้ไขรายการเดิม
                stPage = 2
                idOrderS = idOrder
            Case eProcess.eView 'ดูข้อมูล
                stPage = 3
                idOrderS = idOrder
            Case eProcess.eViewFromSale 'ดูข้อมูลจากหน้าขาย
                stPage = 4
                idOrderDt_Rec = idOrderDt

        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmSlOrderPic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sDt_flagpic.Columns.Add("picurl", System.Type.GetType("System.String"))
        sDt_flagpic.Columns.Add("delflag", System.Type.GetType("System.String"))
        sDt_flagpic.Columns.Add("addflag", System.Type.GetType("System.String"))
        sDt_flagpic.Columns.Add("filename", System.Type.GetType("System.String"))


        If stPage = 2 Or stPage = 3 Then 'Edit/View
            mdLoadShow()
            Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pSaleOrder/"), FtpWebRequest)
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
                If (Str(0) <> idOrderS.ToString) Then
                    ftpFiles3.RemoveAt(y)
                Else
                    y += 1
                End If
            End While

            For j As Integer = 0 To ftpFiles3.Count - 1
                Dim strtemp() As String
                Dim listItem As New ListViewItem()

                listItem.ImageKey = ftpFiles3.Item(j).ToString()
                Img1.Images.Add(ftpFiles3.Item(j).ToString(), My.Resources.ResourceManager.GetObject("JPG_icon"))
                strtemp = (ftpFiles3.Item(j).ToString()).Split("_")
                listItem.Text = strtemp(1)
                listItem.Text = Microsoft.VisualBasic.Left(listItem.Text, listItem.Text.ToString.Length - 4)
                Lv.Items.Add(listItem)
            Next

            If stPage = 3 Then 'View
                Me.btnSelectImgPd.Enabled = False
                Me.btnDelImgPd.Enabled = False
                Me.btn_OK.Enabled = False
            End If
            mdLoadCommitt()
        ElseIf stPage = 4 Then 'ดูข้อมูลจากหน้าขาย
            mdLoadShow()
            Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pSaleOrder/"), FtpWebRequest)
            ftp.Method = WebRequestMethods.Ftp.ListDirectory
            ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
            Dim Response As FtpWebResponse = ftp.GetResponse()
            Dim responseStream As Stream = Response.GetResponseStream()
            Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))
            Dim y As Integer = 0
            ' Dim x As Integer = 0
            Dim Str() As String
            ftpFiles3 = New ArrayList
            ftpFilesShow = New ArrayList

            While Not (reader.EndOfStream)
                ftpFiles3.Add(reader.ReadLine())
            End While

            For i As Integer = 0 To idOrderDt_Rec.Rows.Count - 1
                For y = 0 To ftpFiles3.Count - 1
                    Str = ftpFiles3.Item(y).ToString().Split("_")
                    If (Str(0) = idOrderDt_Rec.Rows(i).Item("idSaleOrder").ToString) Then
                        ftpFilesShow.Add(ftpFiles3.Item(y))
                    End If

                Next
            Next


            For j As Integer = 0 To ftpFilesShow.Count - 1
                'Dim strtemp() As String
                Dim listItem As New ListViewItem()

                listItem.ImageKey = ftpFilesShow.Item(j).ToString()
                Img1.Images.Add(ftpFilesShow.Item(j).ToString(), My.Resources.ResourceManager.GetObject("JPG_icon"))
                'strtemp = (ftpFilesShow.Item(j).ToString()).Split("_")
                listItem.Text = ftpFilesShow.Item(j).ToString()
                listItem.Text = Microsoft.VisualBasic.Left(listItem.Text, listItem.Text.ToString.Length - 4)
                Lv.Items.Add(listItem)
            Next

            Me.btnSelectImgPd.Enabled = False
            Me.btnDelImgPd.Enabled = False
            Me.btn_OK.Enabled = False
            mdLoadCommitt()
        End If
    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        If stPage = 1 And Me.Lv.Items.Count = 0 Then 'New
            MessageBox.Show("กรุณาเลือกไฟล์รูปภาพอย่างน้อย 1 ไฟล์ ก่อนกดปุ่มบันทึก", sSystemName)
            Exit Sub
        Else
            If stPage = 1 Then 'new
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                mdLoadShow()
                '---Delete image---'
                For j As Integer = 0 To sDt_flagpic.Rows.Count - 1
                    If sDt_flagpic.Rows(j).Item(1) = "1" Then
                        Try
                            delFile(sDt_flagpic.Rows(j).Item(0), idOrderS)
                        Catch ex As Exception
                            'Nothing
                        End Try
                    End If
                Next

                '--- up new pic ---'
                For j As Integer = 0 To sDt_flagpic.Rows.Count - 1
                    If sDt_flagpic.Rows(j).Item(2) = "1" Then
                        upFile(sDt_flagpic.Rows(j).Item(3), sDt_flagpic.Rows(j).Item(0), idOrderS)
                    End If
                Next

                mdLoadCommitt()
                MessageBox.Show("บันทึกรูปภาพที่แก้ไขเรียบร้อยแล้ว", sSystemName)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub upFile(ByVal namefile As String, ByVal locationname As String, ByVal idOrder As String)
        My.Computer.Network.UploadFile(locationname, "ftp://" & sHost & "/images/pSaleOrder/" + idOrder + "_" + namefile + ".jpg", sFtpUser, sFtpPass)
    End Sub

    Private Sub delFile(ByVal locationname As String, ByVal idOrderEdit As String)
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://" & sHost & "/images/pSaleOrder/" + idOrderEdit + "_" + locationname + ".jpg"), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(sFtpUser, sFtpPass)
        request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
        request.GetResponse()
    End Sub


    Private Sub btnSelectImgPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectImgPd.Click
        If ofdUpImg.ShowDialog And ofdUpImg.FileName <> "" Then
            Dim filename As String
            urlfile = ofdUpImg.FileName

            Dim array_temp As New ArrayList
            Dim lastItem As Integer = Me.Lv.Items.Count
            If Me.Lv.Items.Count = 0 Then
                filename = "1"
            Else
                Dim MaxItem As Integer = CInt(Me.Lv.Items(0).Text)
                For i As Integer = 0 To Me.Lv.Items.Count - 1
                    If CInt(Me.Lv.Items(i).Text) > MaxItem Then
                        MaxItem = CInt(Me.Lv.Items(i).Text)
                    End If
                Next
                filename = MaxItem + 1
            End If
            ' MessageBox.Show(CountPic)


            For i As Integer = 0 To Lv.Items.Count - 1
                array_temp.Add(Lv.Items(i).Text)
            Next

            Img1.Images.Add(urlfile, My.Resources.ResourceManager.GetObject("JPG_icon"))
            Dim listItem As New ListViewItem()
            listItem.ImageKey = urlfile
            listItem.Text = filename
            Lv.Items.Add(listItem)
            btnDelImgPd.Enabled = True
            sDt_flagpic.Rows.Add(urlfile, "0", "1", filename)
        End If
        ' End If
    End Sub

    Private Sub btnDelImgPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelImgPd.Click
        If Me.Lv.SelectedItems.Count = 0 Then
            MessageBox.Show("กรุณาเลือกไฟล์รูปภาพที่ต้องการลบ", sSystemName)
        Else
            Result = MsgBox("คุณต้องการลบรูปนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                Dim stAdd As Integer = 0
                For i As Integer = 0 To sDt_flagpic.Rows.Count - 1
                    If sDt_flagpic.Rows(i).Item("filename") = Lv.FocusedItem.Text Then
                        sDt_flagpic.Rows(i).Item("Delflag") = 1
                        sDt_flagpic.Rows(i).Item("addflag") = 0
                        stAdd = 1 'ไม่ Add
                    End If
                Next

                If stAdd <> 1 Then 'Add ใหม่
                    sDt_flagpic.Rows.Add(Lv.FocusedItem.Text, "1", "0", Lv.FocusedItem.Text)
                End If
                Lv.FocusedItem.Remove()
            End If
        End If
    End Sub

    Private Sub Lv_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv.DoubleClick
        Try
            My.Computer.Network.DownloadFile("http://" & sHost & sFtpPathMain & "images/pSaleOrder/" & idOrderS & "_" & Lv.Items(Lv.FocusedItem.Index).Text & ".jpg", Lv.Items(Lv.FocusedItem.Index).ImageKey)
            Dim myProcess As Process = System.Diagnostics.Process.Start(Lv.Items(Lv.FocusedItem.Index).ImageKey)
            While Not myProcess.HasExited
                myProcess.Refresh()
            End While
            System.IO.File.Delete(Lv.Items(Lv.FocusedItem.Index).ImageKey)
        Catch ex As Exception
            Try
                Dim myProcess As Process = System.Diagnostics.Process.Start(Lv.Items(Lv.FocusedItem.Index).ImageKey)
                While Not myProcess.HasExited
                    myProcess.Refresh()
                End While
                System.IO.File.Delete(Lv.Items(Lv.FocusedItem.Index).ImageKey)
            Catch ex2 As Exception
                '---Nothing----'
            End Try
        End Try
    End Sub
End Class