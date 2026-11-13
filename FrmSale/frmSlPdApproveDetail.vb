Public Class frmSlPdApproveDetail
    Dim idPdt As Integer
    Dim ppName As String
    Dim PlantType As String
    Dim Trademark As String
    Dim PP As String
    Dim PsAdd As String
    Dim PsApp As String
    Dim PsCheck As String
    Dim DateCheck As String
    Dim DateApp As String
    Dim idPsApp As Integer
    Dim idPsCheck As Integer
    Sub mdLoadShow()

    End Sub
    Sub mdLoadCommitt()

    End Sub

    Public Sub Get_value(ByVal id As Integer, ByVal pName As String, ByVal pPlantType As String, ByVal pTrademark As String, ByVal pPP As String, ByVal pPsAdd As String, ByVal pPsApp As String, ByVal pPsCheck As String, ByVal pDateCheck As String, ByVal pDateApp As String, ByVal pidPsApp As Integer, ByVal pidPsCheck As Integer, ByVal wType As Integer)
        idPdt = id
        ppName = pName
        PlantType = pPlantType
        Trademark = pTrademark
        PP = pPP
        PsAdd = pPsAdd
        PsApp = pPsApp
        PsCheck = pPsCheck
        DateCheck = pDateCheck
        DateApp = pDateApp
        idPsApp = pidPsApp
        idPsCheck = pidPsCheck


        txtName.Text = ppName
        txtTypeName.Text = PlantType
        txtTrademark.Text = Trademark
        txtPP.Text = PP
        txtAdd.Text = PsAdd
        txtApp.Text = PsApp
        txtCheck.Text = PsCheck
        txtDateCheck.Text = ksbStringToDate(DateCheck)
        txtDateApp.Text = ksbStringToDate(DateApp)

        ' TextBox1.Text = sPsId.ToString & " --- " & idPdt & "---" & wType
        ' TextBox2.Text = sPsName
        If wType = 1 Then
            Me.Text = "การตรวจสอบสินค้า"
        Else
            Me.Text = "การอนุมัติสินค้า"
        End If

        If idPsCheck = -1 And idPsApp = -1 And wType = 1 Then
            btn_Check.Enabled = True
            btn_app.Enabled = False
        ElseIf idPsCheck <> -1 And idPsApp = -1 And wType = 1 Then
            btn_Check.Enabled = False
            btn_app.Enabled = False
        ElseIf idPsCheck <> -1 And idPsApp <> -1 And wType = 2 Then
            btn_Check.Enabled = False
            btn_app.Enabled = False
        ElseIf idPsCheck <> -1 And idPsApp = -1 And wType = 2 Then
            btn_Check.Enabled = False
            btn_app.Enabled = True
        ElseIf idPsCheck = -1 And idPsApp = -1 And wType = 2 Then
            btn_Check.Enabled = False
            btn_app.Enabled = False
            labelcheck.Text = "*ไม่สามารถอนุมัติสินค้าได้เนื่องจากยังไม่ผ่านการตรวจสอบข้อมูล"
        End If


        Try
            Img1.Image = getImg("http://" & sHost & "/SPM/images/pPdArtWork/" & idPdt & ".jpg")
        Catch ex As Exception
            Img1.Image = My.Resources.ResourceManager.GetObject("ImgNotprocess")
            Img1.SizeMode = PictureBoxSizeMode.CenterImage
        End Try

    End Sub
    Private Sub btn_Check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Check.Click
        Dim answer As DialogResult
        Dim dtm As String = DateValue(Now)
        mdLoadShow()
        mdCnOpen()
        answer = MessageBox.Show("ยืนยันการตรวจสอบ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            mdCnOpen()
            sCommand.CommandText = "UPDATE SlPdTradeNameD SET idPsCheck = " & sPsId.ToString & ",DateCheck = " & ksbDateToString(dtm) & " WHERE idPdT = " & idPdt
            sCommand.ExecuteNonQuery()
            MessageBox.Show("บันทึกข้อมูลการตรวจสอบ")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        mdLoadCommitt()
    End Sub

    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim MyWebClient As New System.Net.WebClient
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(url)
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        Dim pic As System.Drawing.Image = New System.Drawing.Bitmap(ImageStream)

        Return pic
    End Function

    Private Sub btn_app_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_app.Click
        Dim answer As DialogResult
        Dim dtm As String = DateValue(Now)
        mdLoadShow()
        mdCnOpen()
        answer = MessageBox.Show("ยืนยันการอนุมัติ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            mdCnOpen()
            sCommand.CommandText = "UPDATE SlPdTradeNameD SET idPsApp = " & sPsId.ToString & ",DateApp = " & ksbDateToString(dtm) & " WHERE idPdT = " & idPdt
            sCommand.ExecuteNonQuery()
            MessageBox.Show("บันทึกข้อมูลการการอนุมัติ")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        mdLoadCommitt()
    End Sub
End Class