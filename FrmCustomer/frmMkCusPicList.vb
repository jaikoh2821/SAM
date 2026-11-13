Imports System.Net
Imports System.IO

Public Class frmMkCusPicList

    Dim pCusName As String
    Dim pidCus As Integer
    Dim pCusAdd As String
    Dim mPc As ePc
    Dim n As Integer
    Dim page As Integer
    Dim lastPage As Integer
    Dim totalRows As Integer
    Dim n2 As Integer
    Dim n3 As Integer
    Dim page2 As Integer
    Dim lastPage2 As Integer
    Dim totalRows2 As Integer
    Dim page3 As Integer
    Dim lastPage3 As Integer
    Dim totalRows3 As Integer
    Public mFtpPath As String
    Public mIdPicTmp As Integer
    Public listname1 As String = "pCusLocation"
    Public listname2 As String = "pCusEvent"
    Public listname3 As String = "pCusOwner"
    Public lp1 As Double = 0
    Public lp2 As Double = 0
    Public lp3 As Double = 0
    Dim perPage As Integer = 6
    Dim nCur As Integer = 0
    Dim curPage As Integer = 1
    Dim nCur1 As Integer = 0
    Dim curPage1 As Integer = 1
    Dim nCur2 As Integer = 0
    Dim curPage2 As Integer = 1
    Dim nCur3 As Integer = 0
    Dim curPage3 As Integer = 1
    Dim ftpFiles1 As New ArrayList()
    Dim ftpFiles2 As New ArrayList()
    Dim ftpFiles3 As New ArrayList()
    Dim pPsnum As String

    Enum ePc
        eManage
        eSelectArtwork
    End Enum

    Dim mDir As String = ""
    Dim mEnum As Byte
    Sub mdLoadShow()

    End Sub
    Sub mdLoadCommitt()

    End Sub
    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim MyWebClient As New System.Net.WebClient
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(url)
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        Dim pic As System.Drawing.Image = New System.Drawing.Bitmap(ImageStream)

        Return pic
    End Function

    Public Sub Get_value(ByVal idCus As Integer, ByVal cusName As String, ByVal cusAdd As String, ByVal ps As String)
        pidCus = idCus
        pCusName = cusName
        pCusAdd = cusAdd
        txtname.Text = pCusName
        txtadd.Text = pCusAdd
        pPsnum = ps
        txtnumPs.Text += " " + pPsnum

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim frm As New frmCusPicAdd
        mdLoadShow()
        frm.Get_idCus(pidCus)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            Get_Image1(listname1)
            Get_Image2(listname2)
            Get_Image3(listname3)
        End If
        mdLoadCommitt()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frm As New frmCusPicAdd
        Dim selectLvValue As String = ""
        mdLoadShow()
        If Lv1.SelectedItems.Count > 0 Then
            selectLvValue = sHost & sFtpPathMain & "images/pCusLocation/" + Lv1.Items(Lv1.FocusedItem.Index).ImageKey
            Lv1.SelectedItems.Clear()
        ElseIf Lv2.SelectedItems.Count > 0 Then
            selectLvValue = sHost & sFtpPathMain & "images/pCusEvent/" + Lv2.Items(Lv2.FocusedItem.Index).ImageKey
            Lv2.SelectedItems.Clear()
        ElseIf Lv3.SelectedItems.Count > 0 Then
            selectLvValue = sHost & sFtpPathMain & "images/pCusOwner/" + Lv3.Items(Lv3.FocusedItem.Index).ImageKey
            Lv3.SelectedItems.Clear()

        End If

        If selectLvValue <> "" Then
            frm.Get_Type("1", selectLvValue, pidCus)
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Get_Image1(listname1)
                Get_Image2(listname2)
                Get_Image3(listname3)
            End If
        Else
            MessageBox.Show("กรุณาคลิกเลือกรูปภาพก่อนจะทำการแก้ไข")
        End If
        mdLoadCommitt()

    End Sub

    Private Sub frmMkCusPicList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        Get_Image1(listname1)
        Get_Image2(listname2)
        Get_Image3(listname3)
        mdLoadCommitt()
    End Sub

    Private Sub Lv1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv1.DoubleClick

        Dim str As String = sHost & sFtpPathMain & "images/pCusLocation/" + Lv1.Items(Lv1.FocusedItem.Index).ImageKey
        mdLoadShow()
        'frm.Get_UrlImg(str, Lv1.Items(Lv1.FocusedItem.Index).ImageKey)
        'frm.ShowDialog()
        'System.Diagnostics.Process.Start(str)
        My.Computer.Network.DownloadFile(sHost & sFtpPathMain & "images/pCusLocation/" & Lv1.Items(Lv1.FocusedItem.Index).ImageKey, Lv1.Items(Lv1.FocusedItem.Index).ImageKey)
        Dim myProcess As Process = System.Diagnostics.Process.Start(Lv1.Items(Lv1.FocusedItem.Index).ImageKey)
        While Not myProcess.HasExited
            myProcess.Refresh()
        End While
        System.IO.File.Delete(Lv1.Items(Lv1.FocusedItem.Index).ImageKey)
        mdLoadCommitt()

       


    End Sub

    Private Sub Lv2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv2.DoubleClick

        Dim str As String = sHost & sFtpPathMain & "images/pCusEvent/" + Lv2.Items(Lv2.FocusedItem.Index).ImageKey
        mdLoadShow()
        'frm.Get_UrlImg(str, Lv2.Items(Lv2.FocusedItem.Index).ImageKey)
        'frm.ShowDialog()
        'System.Diagnostics.Process.Start(str)
        My.Computer.Network.DownloadFile(sHost & sFtpPathMain & "images/pCusEvent/" & Lv2.Items(Lv2.FocusedItem.Index).ImageKey, Lv2.Items(Lv2.FocusedItem.Index).ImageKey)
        Dim myProcess As Process = System.Diagnostics.Process.Start(Lv2.Items(Lv2.FocusedItem.Index).ImageKey)
        While Not myProcess.HasExited
            myProcess.Refresh()
        End While
        System.IO.File.Delete(Lv2.Items(Lv2.FocusedItem.Index).ImageKey)
        mdLoadCommitt()
    End Sub

    Private Sub Lv3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv3.DoubleClick

        Dim str As String = sHost & sFtpPathMain & "images/pCusOwner/" + Lv3.Items(Lv3.FocusedItem.Index).ImageKey
        mdLoadShow()
        'frm.Get_UrlImg(str, Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        'frm.ShowDialog()
        'System.Diagnostics.Process.Start(str)
        My.Computer.Network.DownloadFile(sHost & sFtpPathMain & "images/pCusOwner/" & Lv3.Items(Lv3.FocusedItem.Index).ImageKey, Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        Dim myProcess As Process = System.Diagnostics.Process.Start(Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        While Not myProcess.HasExited
            myProcess.Refresh()
        End While
        System.IO.File.Delete(Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        mdLoadCommitt()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim selectLvValue As String = ""
        Dim answer As DialogResult
        Dim message As String = ""
        mdLoadShow()
        If Lv1.SelectedItems.Count > 0 Then
            message = Lv1.Items(Lv1.FocusedItem.Index).ImageKey
        End If
        If Lv2.SelectedItems.Count > 0 Then
            message = Lv2.Items(Lv2.FocusedItem.Index).ImageKey
        End If
        If Lv3.SelectedItems.Count > 0 Then
            message = Lv3.Items(Lv3.FocusedItem.Index).ImageKey
        End If

        'MessageBox.Show(selectLvValue)
        If Lv1.SelectedItems.Count > 0 Or Lv2.SelectedItems.Count > 0 Or Lv3.SelectedItems.Count > 0 Then
            answer = MessageBox.Show("ยืนยันการลบภาพ " + message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                If Lv1.SelectedItems.Count > 0 Then
                    selectLvValue = sHost & "/images/pCusLocation/" + Lv1.Items(Lv1.FocusedItem.Index).ImageKey
                    Lv1.SelectedItems.Clear()
                ElseIf Lv2.SelectedItems.Count > 0 Then
                    selectLvValue = sHost & "/images/pCusEvent/" + Lv2.Items(Lv2.FocusedItem.Index).ImageKey
                    Lv2.SelectedItems.Clear()
                ElseIf Lv3.SelectedItems.Count > 0 Then
                    selectLvValue = sHost & "/images/pCusOwner/" + Lv3.Items(Lv3.FocusedItem.Index).ImageKey
                    Lv3.SelectedItems.Clear()
                End If
                delfile(selectLvValue)
            End If
        Else
            MessageBox.Show("กรุณาคลิกเลือกรูปภาพก่อนจะทำการลบรูป")
        End If

        mdLoadCommitt()
    End Sub
    Private Sub delfile(ByVal purl As String)
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://" + purl), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(sFtpUser, sFtpPass)
        request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
        request.GetResponse()
        Get_Image1(listname1)
        Get_Image2(listname2)
        Get_Image3(listname3)
    End Sub

    Private Sub pSetPic(ByVal num As Integer, ByVal listname As String)
        Dim strtemp() As String
        Try
            Lv1.Clear()
            Img1.Images.Clear()
            'lbCurPage.Text = "หน้าปัจจุบัน : " & page

            If lastPage > 1 Then
                If page = 1 Then
                    btnBack.Enabled = False
                    btnFirst.Enabled = False
                    btnNext.Enabled = True
                    btnLast.Enabled = True
                ElseIf page = lastPage Then
                    btnBack.Enabled = True
                    btnFirst.Enabled = True
                    btnNext.Enabled = False
                    btnLast.Enabled = False
                Else
                    btnBack.Enabled = True
                    btnFirst.Enabled = True
                    btnNext.Enabled = True
                    btnLast.Enabled = True
                End If
            Else
                btnBack.Enabled = False
                btnFirst.Enabled = False
                btnNext.Enabled = False
                btnLast.Enabled = False
            End If

            Dim d As Integer

            If (page = lastPage) And (totalRows Mod perPage > 0) Then
                d = (totalRows Mod perPage) - 1
            Else
                d = perPage - 1
            End If

            For i As Integer = 0 To num + d
                If i = num Then
                    Try
                        Img1.Images.Add(ftpFiles1.Item(i).ToString(), getImg("http://" & sHost & sFtpPathMain & "images/" + listname + "/" & ftpFiles1.Item(i).ToString()))
                    Catch ex As Exception

                    End Try

                    Dim listItem As New ListViewItem()
                    listItem.ImageKey = ftpFiles1.Item(i).ToString()
                    strtemp = (ftpFiles1.Item(i).ToString()).Split(".jpg")
                    strtemp = strtemp(0).Split("-")
                    listItem.Text = strtemp(1)
                    Lv1.Items.Add(listItem)
                    num += 1
                End If
            Next
            Lv1.Focus()
        Catch ex As Exception
            MessageBox.Show("ไม่สามารถแสดงรูปภาพจาก Server ได้ " & ex.Message, sSystemName)
        End Try
    End Sub
    Private Sub pSetPic2(ByVal num As Integer, ByVal listname As String)
        Dim strtemp() As String
        Try
            Lv2.Clear()
            Img2.Images.Clear()
            'lbCurPage.Text = "หน้าปัจจุบัน : " & page

            If lastPage2 > 1 Then
                If page2 = 1 Then
                    btnBack2.Enabled = False
                    btnFirst2.Enabled = False
                    btnNext2.Enabled = True
                    btnLast2.Enabled = True
                ElseIf page2 = lastPage2 Then
                    btnBack2.Enabled = True
                    btnFirst2.Enabled = True
                    btnNext2.Enabled = False
                    btnLast2.Enabled = False
                Else
                    btnBack2.Enabled = True
                    btnFirst2.Enabled = True
                    btnNext2.Enabled = True
                    btnLast2.Enabled = True
                End If
            Else
                btnBack2.Enabled = False
                btnFirst2.Enabled = False
                btnNext2.Enabled = False
                btnLast2.Enabled = False
            End If

            Dim d As Integer

            If (page2 = lastPage2) And (totalRows2 Mod perPage > 0) Then
                d = (totalRows2 Mod perPage) - 1
            Else
                d = perPage - 1
            End If

            For i As Integer = 0 To num + d
                If i = num Then
                    Try
                        Img2.Images.Add(ftpFiles2.Item(i).ToString(), getImg("http://" & sHost & sFtpPathMain & "images/" + listname + "/" & ftpFiles2.Item(i).ToString()))
                    Catch ex As Exception

                    End Try

                    Dim listItem As New ListViewItem()
                    listItem.ImageKey = ftpFiles2.Item(i).ToString()
                    strtemp = (ftpFiles2.Item(i).ToString()).Split(".jpg")
                    strtemp = strtemp(0).Split("-")
                    listItem.Text = strtemp(1)
                    Lv2.Items.Add(listItem)
                    num += 1
                End If
            Next
            Lv2.Focus()
        Catch ex As Exception
            MessageBox.Show("ไม่สามารถแสดงรูปภาพจาก Server ได้ " & ex.Message, sSystemName)
        End Try
    End Sub
    Private Sub pSetPic3(ByVal num As Integer, ByVal listname As String)
        Dim strtemp() As String
        Try
            Lv3.Clear()
            Img3.Images.Clear()
            'lbCurPage.Text = "หน้าปัจจุบัน : " & page

            If lastPage3 > 1 Then
                If page3 = 1 Then
                    btnBack3.Enabled = False
                    btnFirst3.Enabled = False
                    btnNext3.Enabled = True
                    btnLast3.Enabled = True
                ElseIf page3 = lastPage Then
                    btnBack3.Enabled = True
                    btnFirst3.Enabled = True
                    btnNext3.Enabled = False
                    btnLast3.Enabled = False
                Else
                    btnBack3.Enabled = True
                    btnFirst3.Enabled = True
                    btnNext3.Enabled = True
                    btnLast3.Enabled = True
                End If
            Else
                btnBack3.Enabled = False
                btnFirst3.Enabled = False
                btnNext3.Enabled = False
                btnLast3.Enabled = False
            End If

            Dim d As Integer

            If (page3 = lastPage3) And (totalRows3 Mod perPage > 0) Then
                d = (totalRows3 Mod perPage) - 1
            Else
                d = perPage - 1
            End If

            For i As Integer = 0 To num + d
                If i = num Then
                    Try
                        Img3.Images.Add(ftpFiles3.Item(i).ToString(), getImg("http://" & sHost & sFtpPathMain & "images/" + listname + "/" & ftpFiles3.Item(i).ToString()))
                    Catch ex As Exception

                    End Try

                    Dim listItem As New ListViewItem()
                    listItem.ImageKey = ftpFiles3.Item(i).ToString()
                    strtemp = (ftpFiles3.Item(i).ToString()).Split(".jpg")
                    strtemp = strtemp(0).Split("-")
                    listItem.Text = strtemp(1)
                    Lv3.Items.Add(listItem)
                    num += 1
                End If
            Next
            Lv3.Focus()
        Catch ex As Exception
            MessageBox.Show("ไม่สามารถแสดงรูปภาพจาก Server ได้ " & ex.Message, sSystemName)
        End Try
    End Sub

    Private Sub Get_Image1(ByVal listname As String)
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/" + listname + "/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"))
        Dim i As Integer = 0
        Dim Str() As String
        ftpFiles1 = New ArrayList()

        While Not (reader.EndOfStream)
            ftpFiles1.Add(reader.ReadLine())
            Str = ftpFiles1.Item(i).ToString().Split("-")
            If (Str(0) <> pidCus.ToString) Then
                ftpFiles1.RemoveAt(i)
            Else
                i += 1
            End If
        End While

        ftpFiles1.Sort()

        totalRows = ftpFiles1.Count

        Dim lp As Double
        lp = totalRows / perPage

        If lp > CType(lp, Integer) Then
            lastPage = CType(lp, Integer) + 1
        Else
            lastPage = lp
        End If

        lbTotalPic1.Text = "มีรูปทั้งหมด : " & totalRows & " รูป"
        'lbTotalPages.Text = "หน้าทั้งหมด : " & lastPage
        page = 0

        If curPage > lastPage Then
            curPage = 1
            nCur = 0
        End If

        If totalRows > 0 Then
            page = curPage
            n = nCur
            pSetPic(n, listname1)
        Else
            'lbCurPage.Text = "หน้าปัจจุบัน : " & page
            Lv1.Clear()
            btnNext.Enabled = False
            btnLast.Enabled = False
            btnBack.Enabled = False
            btnFirst.Enabled = False
        End If
    End Sub
    Private Sub Get_Image2(ByVal listname As String)
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/" + listname + "/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"))
        Dim i As Integer = 0
        Dim Str() As String
        ftpFiles2 = New ArrayList

        While Not (reader.EndOfStream)
            ftpFiles2.Add(reader.ReadLine())
            Str = ftpFiles2.Item(i).ToString().Split("-")
            If (Str(0) <> pidCus.ToString) Then
                ftpFiles2.RemoveAt(i)
            Else
                i += 1
            End If

        End While
        ftpFiles2.Sort()

        totalRows2 = ftpFiles2.Count

        Dim lp As Double
        lp = totalRows2 / perPage

        If lp > CType(lp, Integer) Then
            lastPage2 = CType(lp, Integer) + 1
        Else
            lastPage2 = lp
        End If

        lbTotalPic2.Text = "มีรูปทั้งหมด : " & totalRows2 & " รูป"
        'lbTotalPages.Text = "หน้าทั้งหมด : " & lastPage
        page2 = 0

        If curPage2 > lastPage2 Then
            curPage2 = 1
            nCur2 = 0
        End If

        If totalRows2 > 0 Then
            page2 = curPage2
            n2 = nCur2
            pSetPic2(n2, listname2)
        Else
            'lbCurPage.Text = "หน้าปัจจุบัน : " & page
            Lv2.Clear()
            btnNext2.Enabled = False
            btnLast2.Enabled = False
            btnBack2.Enabled = False
            btnFirst2.Enabled = False
        End If
    End Sub
    Private Sub Get_Image3(ByVal listname As String)
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/" + listname + "/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"))
        Dim i As Integer = 0
        Dim Str() As String
        ftpFiles3 = New ArrayList

        While Not (reader.EndOfStream)
            ftpFiles3.Add(reader.ReadLine())
            Str = ftpFiles3.Item(i).ToString().Split("-")
            If (Str(0) <> pidCus.ToString) Then
                ftpFiles3.RemoveAt(i)
            Else
                i += 1
            End If

        End While
        ftpFiles3.Sort()

        totalRows3 = ftpFiles3.Count

        Dim lp As Double
        lp = totalRows3 / perPage

        If lp > CType(lp, Integer) Then
            lastPage3 = CType(lp, Integer) + 1
        Else
            lastPage3 = lp
        End If

        lbTotalPic3.Text = "มีรูปทั้งหมด : " & totalRows3 & " รูป"
        'lbTotalPages.Text = "หน้าทั้งหมด : " & lastPage
        page3 = 0

        If curPage3 > lastPage3 Then
            curPage3 = 1
            nCur3 = 0
        End If

        If totalRows3 > 0 Then
            page3 = curPage3
            n3 = nCur3
            pSetPic3(n3, listname3)

        Else
            'lbCurPage.Text = "หน้าปัจจุบัน : " & page
            Lv3.Clear()
            btnNext3.Enabled = False
            btnLast3.Enabled = False
            btnBack3.Enabled = False
            btnFirst3.Enabled = False
        End If
    End Sub


    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        mdLoadShow()
        page = 1
        curPage = page
        n = 0
        nCur = n
        pSetPic(n, listname1)
        mdLoadCommitt()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        mdLoadShow()
        page -= 1
        curPage = page
        n -= perPage
        nCur = n
        pSetPic(n, listname1)
        mdLoadCommitt()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        mdLoadShow()
        page += 1
        curPage = page
        n += perPage
        nCur = n
        pSetPic(n, listname1)
        mdLoadCommitt()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        mdLoadShow()
        page = lastPage
        curPage = page
        If totalRows Mod perPage = 0 Then
            n = totalRows - perPage
        Else
            n = totalRows - (totalRows Mod perPage)
        End If
        nCur = n
        pSetPic(n, listname1)
        mdLoadCommitt()
    End Sub

    Private Sub btnFirst2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst2.Click
        mdLoadShow()
        page2 = 1
        curPage2 = page2
        n2 = 0
        nCur2 = n2
        pSetPic2(n2, listname2)
        mdLoadCommitt()
    End Sub

    Private Sub btnBack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack2.Click
        mdLoadShow()
        page2 -= 1
        curPage2 = page2
        n2 -= perPage
        nCur2 = n2
        pSetPic2(n2, listname2)
        mdLoadCommitt()
    End Sub

    Private Sub btnNext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext2.Click
        mdLoadShow()
        page2 += 1
        curPage2 = page2
        n2 += perPage
        nCur2 = n2
        pSetPic2(n2, listname2)
        mdLoadCommitt()
    End Sub

    Private Sub btnLast2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast2.Click
        mdLoadShow()
        page2 = lastPage2
        curPage2 = page2
        If totalRows2 Mod perPage = 0 Then
            n2 = totalRows2 - perPage
        Else
            n2 = totalRows2 - (totalRows2 Mod perPage)
        End If
        nCur2 = n2
        pSetPic2(n2, listname2)
        mdLoadCommitt()
    End Sub

    Private Sub btnFirst3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst3.Click
        mdLoadShow()
        page3 = 1
        curPage3 = page3
        n3 = 0
        nCur3 = n
        pSetPic3(n3, listname3)
        mdLoadCommitt()
    End Sub

    Private Sub btnBack3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack3.Click
        mdLoadShow()
        page3 -= 1
        curPage3 = page3
        n3 -= perPage
        nCur3 = n3
        pSetPic3(n3, listname3)
        mdLoadCommitt()
    End Sub

    Private Sub btnNext3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext3.Click
        mdLoadShow()
        page3 += 1
        curPage3 = page3
        n3 += perPage
        nCur3 = n3
        pSetPic3(n3, listname3)
        mdLoadCommitt()
    End Sub

    Private Sub btnLast3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast3.Click
        mdLoadShow()
        page3 = lastPage3
        curPage3 = page3
        If totalRows3 Mod perPage = 0 Then
            n3 = totalRows3 - perPage
        Else
            n3 = totalRows3 - (totalRows3 Mod perPage)
        End If
        nCur3 = n3
        pSetPic3(n3, listname3)
        mdLoadCommitt()
    End Sub

    Private Sub frmMkCusPicList_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Lv2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv2.Click
        Lv1.SelectedItems.Clear()
        Lv3.SelectedItems.Clear()
    End Sub

    Private Sub Lv3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv3.Click
        Lv1.SelectedItems.Clear()
        Lv2.SelectedItems.Clear()
    End Sub

    Private Sub Lv1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv1.Click
        Lv2.SelectedItems.Clear()
        Lv3.SelectedItems.Clear()
    End Sub
End Class