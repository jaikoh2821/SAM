Imports System.Net
Public Class frmCusPicAdd
    Dim delImg As Integer = 0
    Dim upImg As Integer = 0
    Dim chkImg As Integer = 1
    Dim idPdPk As Integer
    Dim txtpic As String
    Dim pLocation As String = ""
    Dim pidCus As Integer
    Dim ptype As String = "0"
    Dim purl As String = ""
    Dim pictype As String = ""
    Dim txtold As String = ""
    Dim pLocationold As String = ""
    Dim answer As DialogResult

    Public Function CheckIfFtpFileExists(ByVal fileUri As String) As Boolean
        Dim request As FtpWebRequest = WebRequest.Create(fileUri)
        request.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        request.Method = WebRequestMethods.Ftp.GetFileSize
        Try
            Dim response As FtpWebResponse = request.GetResponse()
            ' THE FILE EXISTS
        Catch ex As WebException
            Dim response As FtpWebResponse = ex.Response
            If FtpStatusCode.ActionNotTakenFileUnavailable = response.StatusCode Then
                ' THE FILE DOES NOT EXIST
                Return False
            End If
        End Try
        Return True
    End Function

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        txtpic = txtpicname.Text
        If rb1.Checked = True Then
            pLocation = "pCusLocation"
        ElseIf rb2.Checked = True Then
            pLocation = "pCusEvent"
        ElseIf rb3.Checked = True Then
            pLocation = "pCusOwner"
        End If
        If txtpicname.Text = "" Then
            MessageBox.Show("กรุณาใส่ชื่อรูป")
            Exit Sub
        End If
        If ofdUpImg.FileName = "" And ptype = "0" Then
            MessageBox.Show("กรุณาเลือกรูปภาพก่อนทำการบันทึก")
            Exit Sub
        End If

        If ptype = "0" Then
            If Not (CheckIfFtpFileExists("ftp://" & sHost & "/images/" & pLocation & "/" & pidCus & "-" & txtpic & ".jpg")) Then
                answer = MessageBox.Show("ยืนยันการบันทึก", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = vbYes Then
                    If ptype = "0" Then
                        upFile()
                    ElseIf ptype = "1" Then
                        If ofdUpImg.FileName <> "" Then
                            ptbPd.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
                            btnDelImgPd.Enabled = True
                            delFile()
                            upFile()
                        Else
                            If purl <> sHost & sFtpPathMain & "images/" & pLocation & "/" & pidCus & "-" & txtpic & ".jpg" Then
                                If ofdUpImg.FileName <> "" Then
                                    ptbPd.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
                                    btnDelImgPd.Enabled = True
                                    delFile()
                                    upFile()
                                Else
                                    moveFile()
                                End If

                            End If
                        End If
                    End If
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                MessageBox.Show("ชื่อไฟล์ซ้ำ")
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            If pLocation = pLocationold Then
                answer = MessageBox.Show("ยืนยันการบันทึก", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = vbYes Then
                    If ptype = "0" Then
                        upFile()
                    ElseIf ptype = "1" Then
                        If ofdUpImg.FileName <> "" Then
                            ptbPd.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
                            btnDelImgPd.Enabled = True
                            delFile()
                            upFile()
                        Else
                            If purl <> sHost & sFtpPathMain & "images/" & pLocation & "/" & pidCus & "-" & txtpic & ".jpg" Then
                                If ofdUpImg.FileName <> "" Then
                                    ptbPd.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
                                    btnDelImgPd.Enabled = True
                                    delFile()
                                    upFile()
                                Else
                                    moveFile()
                                End If

                            End If
                        End If
                    End If
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If Not (CheckIfFtpFileExists("ftp://" & sHost & "/images/" & pLocation & "/" & pidCus & "-" & txtpic & ".jpg")) Then
                    answer = MessageBox.Show("ยืนยันการบันทึก", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If answer = vbYes Then
                        If ptype = "0" Then
                            upFile()
                        ElseIf ptype = "1" Then
                            If ofdUpImg.FileName <> "" Then
                                ptbPd.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
                                btnDelImgPd.Enabled = True
                                delFile()
                                upFile()
                            Else
                                If purl <> sHost & sFtpPathMain & "images/" & pLocation & "/" & pidCus & "-" & txtpic & ".jpg" Then
                                    If ofdUpImg.FileName <> "" Then
                                        ptbPd.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
                                        btnDelImgPd.Enabled = True
                                        delFile()
                                        upFile()
                                    Else
                                        moveFile()
                                    End If

                                End If
                            End If
                        End If
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                Else
                    MessageBox.Show("ชื่อไฟล์ซ้ำ")
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Public Sub Get_idCus(ByVal idCus As Integer)
        pidCus = idCus
    End Sub

    Private Sub upFile()
        My.Computer.Network.UploadFile(ofdUpImg.FileName, "ftp://" & sHost & "/images/" & pLocation & "/" & pidCus & "-" & txtpic & ".jpg", sFtpUser, sFtpPass)
    End Sub

    Private Sub moveFile()
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://" & sHost & "/images/" & pLocationold & "/" & pidCus & "-" & txtold & ".jpg"), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(sFtpUser, sFtpPass)
        request.Method = System.Net.WebRequestMethods.Ftp.Rename
        request.RenameTo = "../" & pLocation & "/" & pidCus & "-" & txtpic & ".jpg"
        request.GetResponse()
    End Sub
    Private Sub delFile()
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://" & sHost & "/images/" & pLocationold & "/" & pidCus & "-" & txtold & ".jpg"), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(sFtpUser, sFtpPass)
        request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
        request.GetResponse()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnSelectImgPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectImgPd.Click
        If ofdUpImg.ShowDialog And ofdUpImg.FileName <> "" Then
            ptbPd.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
            btnDelImgPd.Enabled = True
            delImg = 0
            upImg = 1
            txtpic = txtpicname.Text
        End If

    End Sub

    Private Sub btnDelImgPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelImgPd.Click
        ptbPd.Image = Nothing
        upImg = 0
        If chkImg = 1 Then
            delImg = 1
        End If
        btnDelImgPd.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delFile()
    End Sub
    Public Sub Get_Type(ByVal type As String, ByVal url As String, ByVal idCus As Integer)
        ptype = type
        purl = url

        Dim str() As String = purl.Split("/")
        pictype = str(3)
        If pictype = "pCusLocation" Then
            pictype = "1"
        End If
        If pictype = "pCusEvent" Then
            pictype = "2"
        End If
        If pictype = "pCusOwner" Then
            pictype = "3"
        End If
        pidCus = idCus
    End Sub

    Private Sub frmCusPicAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ptype = "1" Then
            Dim str As String = "http://" + purl
            Dim str1() As String = str.Split("/")
            Dim str2() As String
            Dim str3() As String
            Dim strname As String = ""
            str2 = str1(str1.Length - 1).Split(".")
            str3 = str2(0).Split("-")
            For k As Integer = 1 To str3.Length - 1
                strname += str3(k)
            Next

            txtpicname.Text = strname
            ptbPd.Image = getImg(str)
            If pictype = "1" Then
                rb1.Checked = True
            End If
            If pictype = "2" Then
                rb2.Checked = True
            End If
            If pictype = "3" Then
                rb3.Checked = True
            End If
            If rb1.Checked = True Then
                pLocationold = "pCusLocation"
            ElseIf rb2.Checked = True Then
                pLocationold = "pCusEvent"
            ElseIf rb3.Checked = True Then
                pLocationold = "pCusOwner"
            End If
            txtold = txtpicname.Text
        End If
    End Sub
    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim MyWebClient As New System.Net.WebClient
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(url)
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        Dim pic As System.Drawing.Image = New System.Drawing.Bitmap(ImageStream)
        Return pic
    End Function
End Class