Public Class frmSlPdPkApproveDetail
    Dim idPdt As Integer
    Dim ppName As String
    Dim pidPk As String
    Dim PriceRetail As String
    Dim PriceBill As String
    Dim PriceWholeSale As String
    Dim PerBox As String
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

    Public Sub Get_value(ByVal id As Integer, ByVal idpPk As String, ByVal pName As String, ByVal PriceRetail As String, ByVal PriceBill As String, ByVal PriceWholeSale As String, ByVal PerBox As String, ByVal pPsApp As String, ByVal pPsCheck As String, ByVal pDateCheck As String, ByVal pDateApp As String, ByVal pidPsApp As Integer, ByVal pidPsCheck As Integer, ByVal wType As Integer)
        idPdt = id
        pidPk = idpPk
        ppName = pName
        PriceRetail = PriceRetail
        PriceBill = PriceBill
        PriceWholeSale = PriceWholeSale
        PerBox = PerBox
        PsApp = pPsApp
        PsCheck = pPsCheck
        DateCheck = pDateCheck
        DateApp = pDateApp
        idPsApp = pidPsApp
        idPsCheck = pidPsCheck


        txtName.Text = ppName
        txtPriceRetail.Text = PriceRetail
        txtPriceBill.Text = PriceBill
        txtPriceWholeSale.Text = PriceWholeSale
        txtPerBox.Text = PerBox
        txtApp.Text = PsApp
        txtCheck.Text = PsCheck
        txtDateCheck.Text = ksbStringToDate(DateCheck)
        txtDateApp.Text = ksbStringToDate(DateApp)

        ' TextBox1.Text = sPsId.ToString & " --- " & idPdt & "---" & wType
        ' TextBox2.Text = sPsName
        If wType = 1 Then
            Me.Text = "การตรวจสอบราคาสินค้าบรรจุขาย"
        Else
            Me.Text = "การอนุมัติราคาสินค้าบรรจุขาย"
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
            labelcheck.Text = "ไม่สามารถอนุมัติราคาสินค้าขายได้เนื่องจากยังไม่ผ่านการตรวจสอบข้อมูล"
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
            sCommand.CommandText = "UPDATE dPackingPdSet SET idPsChk  = " & sPsId.ToString & ",DateChk = " & ksbDateToString(dtm) & " WHERE idPdPk  = " & pidPk
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
            sCommand.CommandText = "UPDATE dPackingPdSet SET idPsApp = " & sPsId.ToString & ",DateApp = " & ksbDateToString(dtm) & " WHERE idPdPk  = " & pidPk
            sCommand.ExecuteNonQuery()
            MessageBox.Show("บันทึกข้อมูลการการอนุมัติ")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        mdLoadCommitt()
    End Sub
End Class