Imports System.Net
Imports System.IO

Public Class frmSlSalePic
    Dim pidEx As String
    Dim tarray As New ArrayList
    Dim urlfile As String
    Dim stPage As Integer = 0
    Dim idSaleS As Integer = 0
    Dim Result As DialogResult
    Public sDt_flagpic As New DataTable
    Dim sDtPicBack As New DataTable
    Dim ftpFiles3 As ArrayList
    Dim eEvent As eProcess


    Enum eProcess
        eAddNew
        eEdit
        eView
        eAddNewPlus
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idSale As String, ByVal sDtTemp As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eAddNew  ' เพิ่มรายการใหม่
                stPage = 1
            Case eProcess.eEdit  ' แก้ไขรายการเดิม
                stPage = 2
                idSaleS = idSale
            Case eProcess.eView  ' ดูข้อมูล
                stPage = 3
                idSaleS = idSale
            Case eProcess.eAddNewPlus  ' เพิ่มรายการใหม่ อีกครั้ง
                stPage = 4
                ' idSaleS = idSale
                sDtPicBack = sDtTemp
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmSlSalePic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sDt_flagpic.Columns.Add("picurl", System.Type.GetType("System.String"))
        sDt_flagpic.Columns.Add("delflag", System.Type.GetType("System.String"))
        sDt_flagpic.Columns.Add("addflag", System.Type.GetType("System.String"))
        sDt_flagpic.Columns.Add("filename", System.Type.GetType("System.String"))

        If stPage = 2 Or stPage = 3 Then
            mdLoadShow()
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
                If (Str(0) <> idSaleS.ToString) Then
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

            If stPage = 3 Then
                Me.btnSelectImgPd.Enabled = False
                Me.btnDelImgPd.Enabled = False
                Me.btn_OK.Enabled = False
            End If
            mdLoadCommitt()
        ElseIf stPage = 4 Then
            For j As Integer = 0 To sDtPicBack.Rows.Count - 1
                If sDtPicBack.Rows(j).Item("Delflag") <> 1 Then ' No Pic Del
                    Dim listItem As New ListViewItem()

                    listItem.ImageKey = sDtPicBack.Rows(j).Item("picurl")
                    Img1.Images.Add(sDtPicBack.Rows(j).Item("picurl"), My.Resources.ResourceManager.GetObject("JPG_icon"))
                    listItem.Text = sDtPicBack.Rows(j).Item("filename")
                    Lv.Items.Add(listItem)
                    sDt_flagpic.Rows.Add(sDtPicBack.Rows(j).Item("picurl"), "0", "1", sDtPicBack.Rows(j).Item("filename"))
                End If
            Next
        End If


    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        If stPage = 1 And Me.Lv.Items.Count = 0 Then
            MessageBox.Show("กรุณาเลือกไฟล์รูปภาพอย่างน้อย 1 ไฟล์ ก่อนกดปุ่มบันทึก", sSystemName)
            Exit Sub
        Else
            If stPage = 1 Or stPage = 4 Then  ' new
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                mdLoadShow()
                '---Delete image---'
                For j As Integer = 0 To sDt_flagpic.Rows.Count - 1
                    If sDt_flagpic.Rows(j).Item(1) = "1" Then
                        Try
                            delFile(sDt_flagpic.Rows(j).Item(0), idSaleS)
                        Catch ex As Exception
                            'Nothing
                        End Try
                    End If
                Next

                '--- up new pic ---'
                For j As Integer = 0 To sDt_flagpic.Rows.Count - 1
                    If sDt_flagpic.Rows(j).Item(2) = "1" Then
                        upFile(sDt_flagpic.Rows(j).Item(3), sDt_flagpic.Rows(j).Item(0), idSaleS)
                    End If
                Next

                mdLoadCommitt()
                MessageBox.Show("บันทึกรูปภาพที่แก้ไขเรียบร้อยแล้ว", sSystemName)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub upFile(ByVal namefile As String, ByVal locationname As String, ByVal idSale As String)
        My.Computer.Network.UploadFile(locationname, "ftp://" & sHost & "/SAM/SaleTs/" + idSale + "_" + namefile + ".jpg", sFtpUser, sFtpPass)
    End Sub

    Private Sub delFile(ByVal locationname As String, ByVal idSaleEdit As String)
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://" & sHost & "/SAM/SaleTs/" + idSaleEdit + "_" + locationname + ".jpg"), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(sFtpUser, sFtpPass)
        request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
        request.GetResponse()
    End Sub

    Private Sub btnSelectImgPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectImgPd.Click
        If ofdUpImg.ShowDialog And ofdUpImg.FileName <> "" Then
            Dim filename As String
            'ptbPd.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
            'filename = NumOfPic + 1
            urlfile = ofdUpImg.FileName

            'Dim frm As New frmSlSalePic
            'Dim filename As String
            'Dim urlfile As String
            Dim array_temp As New ArrayList
            Dim lastItem As Integer = Me.Lv.Items.Count
            If Me.Lv.Items.Count = 0 Then
                filename = "1"
            Else
                'CountPic = Me.Lv.Items(Me.Lv.Items.Count - 1).Text
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
            'frm.Get_data(idSaleS, array_temp, CountPic)
            'frm.ShowDialog()

            'If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            '    filename = frm.Send_filename
            '    urlfile = frm.Send_url
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
        ' End If
    End Sub

    Private Sub Lv_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv.DoubleClick
        Try
            My.Computer.Network.DownloadFile("http://" & sHost & sFtpPathMain & "SAM/SaleTs/" & idSaleS & "_" & Lv.Items(Lv.FocusedItem.Index).Text & ".jpg", Lv.Items(Lv.FocusedItem.Index).ImageKey)
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