Imports System.Net
Imports System.IO

Public Class frmCusCommercePicDetail
    Dim n As Integer
    Dim nCur As Integer = 0
    Dim page As Integer
    Dim perPage As Integer = 2
    Dim curPage As Integer = 1
    Dim lastPage As Integer
    Dim totalRows As Integer
    Dim n2 As Integer
    Dim nCur2 As Integer = 0
    Dim page2 As Integer
    Dim perPage2 As Integer = 2
    Dim curPage2 As Integer = 1
    Dim lastPage2 As Integer
    Dim totalRows2 As Integer
    Dim ftpFiles As New ArrayList()
    Dim idCus As Integer
    Public checkChange As Integer = 0
    Public checkChange2 As Integer = 0

    Public Sub setValues(ByVal id As Integer, ByVal cusName As String, ByVal address As String, ByVal psName As String)
        idCus = id
        lbCusName.Text &= cusName
        lbAddress.Text &= address
        lbPsName.Text &= psName

        Try
            ptbCusCard.Image = getImg("http://" & sHost & "/spm/images/pCusCard/" & idCus & ".jpg")
            btnCusCardDel.Enabled = True
        Catch ex As Exception

        End Try

        Try
            ptbCusRegistration.Image = getImg("http://" & sHost & "/spm/images/pCusRegistration/" & idCus & ".jpg")
            btnCusRegistrationDel.Enabled = True
        Catch ex As Exception

        End Try

        Try
            ptbCusCommercial.Image = getImg("http://" & sHost & "/spm/images/pCusCommercial/" & idCus & ".jpg")
            btnCusCommercialDel.Enabled = True
        Catch ex As Exception

        End Try

        getCusBusiness()
        getCusBusinessEtc()

    End Sub

    Private Sub pSetPic(ByVal num As Integer)
        Try
            lsv.Clear()
            lbCurPage.Text = "หน้าปัจจุบัน : " & page

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
                        img.Images.Add(ftpFiles.Item(i).ToString(), getImg("http://" & sHost & "/spm/images/pCusBusiness/" & ftpFiles.Item(i).ToString()))
                    Catch ex As Exception

                    End Try

                    Dim listItem As New ListViewItem()
                    listItem.ImageKey = ftpFiles.Item(i).ToString()
                    lsv.Items.Add(listItem)
                    num += 1
                End If
            Next
            lsv.Focus()
        Catch ex As Exception
            MessageBox.Show("ไม่สามารถแสดงรูปภาพจาก Server ได้ " & ex.Message, sSystemName)
        End Try
    End Sub

    Private Sub pSetPic2(ByVal num As Integer)
        Try
            lsvetc.Clear()
            lbCurPage2.Text = "หน้าปัจจุบัน : " & page2

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

            If (page2 = lastPage2) And (totalRows2 Mod perPage2 > 0) Then
                d = (totalRows2 Mod perPage2) - 1
            Else
                d = perPage2 - 1
            End If

            For i As Integer = 0 To num + d
                If i = num Then
                    Try
                        img2.Images.Add(ftpFiles.Item(i).ToString(), getImg("http://" & sHost & "/spm/images/pCusBusinessEtc/" & ftpFiles.Item(i).ToString()))
                    Catch ex As Exception

                    End Try

                    Dim listItem As New ListViewItem()
                    listItem.ImageKey = ftpFiles.Item(i).ToString()
                    lsvetc.Items.Add(listItem)
                    num += 1
                End If
            Next
            lsvetc.Focus()
        Catch ex As Exception
            MessageBox.Show("ไม่สามารถแสดงรูปภาพจาก Server ได้ " & ex.Message, sSystemName)
        End Try
    End Sub
    Private Sub getCusBusiness()
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pCusBusiness/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory

        ftpFiles = New ArrayList()

        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)

        Dim Response As FtpWebResponse = ftp.GetResponse()

        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))


        While Not (reader.EndOfStream)
            Dim str() As String
            Dim str2 As String
            str2 = reader.ReadLine()
            str = str2.Split("-")
            If Str(0) = idCus Then
                ftpFiles.Add(str2)
            End If
        End While

        totalRows = ftpFiles.Count

        Dim lp As Double
        lp = totalRows / perPage

        If lp > CType(lp, Integer) Then
            lastPage = CType(lp, Integer) + 1
        Else
            lastPage = lp
        End If

        lbTotalPic.Text = "มีรูปทั้งหมด : " & totalRows
        lbTotalPages.Text = "หน้าทั้งหมด : " & lastPage
        page = 0

        If curPage > lastPage Then
            curPage = 1
            nCur = 0
        End If

        If totalRows > 0 Then
            page = curPage
            n = nCur
            pSetPic(n)
        Else
            lbCurPage.Text = "หน้าปัจจุบัน : " & page
            lsv.Clear()
            btnNext.Enabled = False
            btnLast.Enabled = False
            btnBack.Enabled = False
            btnFirst.Enabled = False
        End If
    End Sub

    Private Sub getCusBusinessEtc()
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pCusBusinessEtc/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory

        ftpFiles = New ArrayList()

        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)

        Dim Response As FtpWebResponse = ftp.GetResponse()

        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))


        While Not (reader.EndOfStream)
            Dim str() As String
            Dim str2 As String
            str2 = reader.ReadLine()
            str = str2.Split("-")
            If str(0) = idCus Then
                ftpFiles.Add(str2)
            End If
        End While

        totalRows2 = ftpFiles.Count

        Dim lp As Double
        lp = totalRows2 / perPage2

        If lp > CType(lp, Integer) Then
            lastPage2 = CType(lp, Integer) + 1
        Else
            lastPage2 = lp
        End If

        lbTotalPic2.Text = "มีรูปทั้งหมด : " & totalRows2
        lbTotalPages2.Text = "หน้าทั้งหมด : " & lastPage2
        page2 = 0

        If curPage2 > lastPage2 Then
            curPage2 = 1
            nCur2 = 0
        End If

        If totalRows2 > 0 Then
            page2 = curPage2
            n2 = nCur2
            pSetPic2(n2)
        Else
            lbCurPage2.Text = "หน้าปัจจุบัน : " & page2
            lsvetc.Clear()
            btnNext2.Enabled = False
            btnLast2.Enabled = False
            btnBack2.Enabled = False
            btnFirst2.Enabled = False
        End If
    End Sub

    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim MyWebClient As New System.Net.WebClient
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(url)
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        Dim pic As System.Drawing.Image = New System.Drawing.Bitmap(ImageStream)

        Return pic
    End Function

    Private Sub upFile(ByVal filePath As String, ByVal type As String, ByVal fileName As String)
        My.Computer.Network.UploadFile(filePath, "ftp://" & sHost & "/images/" & type & "/" & fileName & ".jpg", sFtpUser, sFtpPass)
    End Sub

    Private Sub delFile(ByVal type As String, ByVal fileName As String)
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://" & sHost & "/images/" & type & "/" & fileName), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(sFtpUser, sFtpPass)
        request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
        request.GetResponse()
    End Sub

    Private Sub showImg(ByVal type As String, ByVal fileName As String)
        My.Computer.Network.DownloadFile("http://" & sHost & "/spm/images/" & type & "/" & fileName, fileName)
        Dim myProcess As Process = System.Diagnostics.Process.Start(fileName)
        myProcess.WaitForExit()
        System.IO.File.Delete(fileName)
    End Sub

    Private Sub btnCusCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusCard.Click
        If ofdUpImg.ShowDialog And ofdUpImg.FileName <> "" Then
            Dim result = MessageBox.Show("ต้องการเพิ่มรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                upFile(ofdUpImg.FileName, "pCusCard", idCus)
                sCommand.CommandText = "UPDATE dCustomer SET  stPicCard = '1' WHERE idCus = " & idCus
                sCommand.ExecuteNonQuery()
                ptbCusCard.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
                btnCusCardDel.Enabled = True
                checkChange = 1
            End If
            ofdUpImg.FileName = ""
        End If
    End Sub

    Private Sub btnCusCardDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusCardDel.Click
        Dim result = MessageBox.Show("ต้องการลบรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            delFile("pCusCard", idCus & ".jpg")
            sCommand.CommandText = "UPDATE dCustomer SET  stPicCard = '0' WHERE idCus = " & idCus
            sCommand.ExecuteNonQuery()
            ptbCusCard.Image = Nothing
            btnCusCardDel.Enabled = False
            checkChange = 1
        End If
    End Sub

    Private Sub btnCusRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusRegistration.Click
        If ofdUpImg.ShowDialog And ofdUpImg.FileName <> "" Then
            Dim result = MessageBox.Show("ต้องการเพิ่มรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                upFile(ofdUpImg.FileName, "pCusRegistration", idCus)
                sCommand.CommandText = "UPDATE dCustomer SET  stPicRegist = '1' WHERE idCus = " & idCus
                sCommand.ExecuteNonQuery()
                ptbCusRegistration.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
                btnCusRegistrationDel.Enabled = True
                checkChange = 1
            End If
            ofdUpImg.FileName = ""
        End If
    End Sub

    Private Sub btnCusRegistrationDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusRegistrationDel.Click
        Dim result = MessageBox.Show("ต้องการลบรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            delFile("pCusRegistration", idCus & ".jpg")
            sCommand.CommandText = "UPDATE dCustomer SET  stPicRegist = '0' WHERE idCus = " & idCus
            sCommand.ExecuteNonQuery()
            ptbCusRegistration.Image = Nothing
            btnCusRegistrationDel.Enabled = False
            checkChange = 1
        End If
    End Sub

    Private Sub btnCusCommercial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusCommercial.Click
        If ofdUpImg.ShowDialog And ofdUpImg.FileName <> "" Then
            Dim result = MessageBox.Show("ต้องการเพิ่มรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                upFile(ofdUpImg.FileName, "pCusCommercial", idCus)
                sCommand.CommandText = "UPDATE dCustomer SET  stCusComm = '1' WHERE idCus = " & idCus
                sCommand.ExecuteNonQuery()
                ptbCusCommercial.Image = New System.Drawing.Bitmap(ofdUpImg.FileName)
                btnCusCommercialDel.Enabled = True
                checkChange = 1
            End If
            ofdUpImg.FileName = ""
        End If
    End Sub

    Private Sub btnCusCommercialDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusCommercialDel.Click
        Dim result = MessageBox.Show("ต้องการลบรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            delFile("pCusCommercial", idCus & ".jpg")
            sCommand.CommandText = "UPDATE dCustomer SET  stCusComm = '0' WHERE idCus = " & idCus
            sCommand.ExecuteNonQuery()
            ptbCusCommercial.Image = Nothing
            btnCusCommercialDel.Enabled = False
            checkChange = 1
        End If
    End Sub

    Private Sub btnCusBusiness_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusBusiness.Click
        If ofdUpImg.ShowDialog And ofdUpImg.FileName <> "" Then
            Dim result = MessageBox.Show("ต้องการเพิ่มรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                upFile(ofdUpImg.FileName, "pCusBusiness", idCus & "-" & Format(DateTime.Now, "yyyyMMdd_HHmmss"))
                getCusBusiness()
                If totalRows > 0 Then
                    sCommand.CommandText = "UPDATE dCustomer SET  stCusBusiness = '1' WHERE idCus = " & idCus
                    sCommand.ExecuteNonQuery()
                    checkChange = 1
                End If
            End If
            ofdUpImg.FileName = ""
        End If
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        page = 1
        curPage = page
        n = 0
        nCur = n
        pSetPic(n)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        page -= 1
        curPage = page
        n -= perPage
        nCur = n
        pSetPic(n)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        page += 1
        curPage = page
        n += perPage
        nCur = n
        pSetPic(n)
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        page = lastPage
        curPage = page
        If totalRows Mod perPage = 0 Then
            n = totalRows - perPage
        Else
            n = totalRows - (totalRows Mod perPage)
        End If
        nCur = n
        pSetPic(n)
    End Sub

    Private Sub btnCusBusinessDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusBusinessDel.Click
        Dim result = MessageBox.Show("ต้องการลบรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            delFile("pCusBusiness", lsv.Items(lsv.FocusedItem.Index).ImageKey)
            getCusBusiness()
            If totalRows = 0 Then
                sCommand.CommandText = "UPDATE dCustomer SET  stCusBusiness = '0' WHERE idCus = " & idCus
                sCommand.ExecuteNonQuery()
                checkChange = 1             
            End If
            btnCusBusinessDel.Enabled = False
        End If
    End Sub

    Private Sub lsv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv.SelectedIndexChanged
        If lsv.SelectedItems.Count > 1 Then
            btnCusBusinessDel.Enabled = False
            lsv.SelectedItems.Clear()
        ElseIf lsv.SelectedItems.Count = 1 Then
            btnCusBusinessDel.Enabled = True
        Else
            btnCusBusinessDel.Enabled = False
        End If
    End Sub

    Private Sub lsv_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv.DoubleClick
        showImg("pCusBusiness", lsv.Items(lsv.FocusedItem.Index).ImageKey)
    End Sub

    Private Sub ptbCusCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbCusCard.Click
        If ptbCusCard.Image IsNot Nothing Then
            showImg("pCusCard", idCus & ".jpg")
        End If
    End Sub

    Private Sub ptbCusRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbCusRegistration.Click
        If ptbCusRegistration.Image IsNot Nothing Then
            showImg("pCusRegistration", idCus & ".jpg")
        End If
    End Sub

    Private Sub ptbCusCommercial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbCusCommercial.Click
        If ptbCusCommercial.Image IsNot Nothing Then
            showImg("pCusCommercial", idCus & ".jpg")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusBusiness2.Click
        If ofdUpImg.ShowDialog And ofdUpImg.FileName <> "" Then
            Dim result = MessageBox.Show("ต้องการเพิ่มรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                upFile(ofdUpImg.FileName, "pCusBusinessEtc", idCus & "-" & Format(DateTime.Now, "yyyyMMdd_HHmmss"))
                getCusBusinessEtc()
                If totalRows2 > 0 Then
                    sCommand.CommandText = "UPDATE dCustomer SET  stCusBusinessEtc = '1' WHERE idCus = " & idCus
                    sCommand.ExecuteNonQuery()
                    checkChange2 = 1
                End If

            End If
            ofdUpImg.FileName = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusBusinessDel2.Click
        Dim result = MessageBox.Show("ต้องการลบรูปภาพนี้ใช่หรือไม่", sSystemName, MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            delFile("pCusBusinessEtc", lsvetc.Items(lsvetc.FocusedItem.Index).ImageKey)
            getCusBusinessEtc()
            If totalRows2 = 0 Then
                sCommand.CommandText = "UPDATE dCustomer SET  stCusBusinessEtc = '0' WHERE idCus = " & idCus
                sCommand.ExecuteNonQuery()
                checkChange2 = 1
            End If
            btnCusBusinessDel2.Enabled = False
        End If
    End Sub

    Private Sub btnFirst2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst2.Click
        page2 = 1
        curPage2 = page2
        n2 = 0
        nCur2 = n
        pSetPic2(n2)
    End Sub

    Private Sub btnBack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack2.Click
        page2 -= 1
        curPage2 = page2
        n2 -= perPage2
        nCur2 = n2
        pSetPic2(n2)
    End Sub

    Private Sub btnNext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext2.Click
        page2 += 1
        curPage2 = page2
        n2 += perPage2
        nCur2 = n2
        pSetPic2(n2)
    End Sub

    Private Sub btnLast2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast2.Click
        page2 = lastPage2
        curPage2 = page2
        If totalRows2 Mod perPage2 = 0 Then
            n2 = totalRows2 - perPage2
        Else
            n2 = totalRows2 - (totalRows2 Mod perPage2)
        End If
        nCur2 = n2
        pSetPic2(n2)
    End Sub

    Private Sub lsvetc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvetc.SelectedIndexChanged
        If lsvetc.SelectedItems.Count > 1 Then
            btnCusBusinessDel2.Enabled = False
            lsvetc.SelectedItems.Clear()
        ElseIf lsvetc.SelectedItems.Count = 1 Then
            btnCusBusinessDel2.Enabled = True
        Else
            btnCusBusinessDel2.Enabled = False
        End If
    End Sub

    Private Sub lsvetc_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvetc.DoubleClick
        showImg("pCusBusiness", lsvetc.Items(lsvetc.FocusedItem.Index).ImageKey)
    End Sub
End Class