Imports System.Net
Imports System.IO

Public Class frmCusApproveDetail
    Dim eEvent As eProcess

    Enum eProcess
        ePsAcceptCus
        ePsCheckCus
        ePsApproveCus
    End Enum

    Dim vWhere As String = ""
    Dim idCus_ As Integer
    Dim idPs_ As Integer = sPsId
    Dim UpdateDay As String = ksbDateToString(Format(Now, "Short date").ToString())
    Dim idPv_ As Integer
    Dim idAp_ As Integer
    Dim idTb_ As Integer
    Dim idTsp_ As Integer
    Dim idTspType_ As Integer
    Dim ChkFullData_ As String = "" 'เช็คข้อมูลครบ

    Dim n As Integer
    Dim lastPage3 As Integer
    Dim totalRows3 As Integer
    Dim curPage3 As Integer = 1
    Dim nCur3 As Integer = 0
    Dim n3 As Integer
    Dim perPage As Integer = 2
    Dim page3 As Integer
    Dim lastPage As Integer
    Dim ftpFiles1 As New ArrayList()
    Dim ftpFiles2 As New ArrayList()
    Dim ftpFiles3 As New ArrayList()
    Dim ftpFiles4 As New ArrayList()

    Public listname1 As String = "pCusOwner"
    Public listname2 As String = "pCusCard"
    Public listname3 As String = "pCusRegistration"
    Public listname4 As String = "pCusCommercial"

    Public Sub get_idCus(ByVal idCus As Integer, ByVal stFullData As String)
        idCus_ = idCus
        ChkFullData_ = stFullData
        SetData()
        mdLoadShow()
        Get_Image3(listname1)
        Get_ImageCusCard(listname2)
        Get_ImageCusRegistration(listname3)
        Get_ImageCusCommercial(listname4)
        If ChkFullData_ <> "" Then
            stPanal.BackColor = Color.SeaGreen
        Else
            stPanal.BackColor = Color.Salmon
        End If
        mdLoadCommitt()
    End Sub

    Private Sub SetData()
        Dim sDtset As New DataTable

        sCommand.CommandText = "SELECT C.CusCode, C.CusName_ As CusName, C.Address, C.Tel, C.TelOffice, C.TelHome, C.Fax, C.Latitude, C.Longitude, C.stBusinessType, " & _
                                "C.Note, P1.PsName As PsAccept, C.DateAccept,P2.PsName As PsCheck, C.DateCheck, P3.PsName As PsApprove, " & _
                                "C.DateApprive, C.stRight, C.idCus, C.idTsp, C.idPv, C.idAp, C.idTb FROM vCustomer As C LEFT JOIN vPerson As P1 On C.idPsAccept=P1.idPs " & _
                                "LEFT JOIN vPerson As P2 On C.idPsCheck=P2.idPs LEFT JOIN vPerson As P3 On C.idPsApprove=P3.idPs WHERE C.idCus=" & idCus_
        sAdapter.Fill(sDtset)

        If Not IsDBNull(sDtset.Rows(0).Item("CusCode")) Then
            txt_ShotName.Text = sDtset.Rows(0).Item("CusCode")
        End If
        txt_CusName.Text = sDtset.Rows(0).Item("CusName")
        If Not IsDBNull(sDtset.Rows(0).Item("Address")) Then
            txt_Address.Text = sDtset.Rows(0).Item("Address")
        End If
        If Not IsDBNull(sDtset.Rows(0).Item("Tel")) Then
            txt_tel.Text = sDtset.Rows(0).Item("Tel")
        End If
        If Not IsDBNull(sDtset.Rows(0).Item("TelOffice")) Then
            txt_telOffice.Text = sDtset.Rows(0).Item("TelOffice")
        End If
        If Not IsDBNull(sDtset.Rows(0).Item("TelHome")) Then
            txt_TelHome.Text = sDtset.Rows(0).Item("TelHome")
        End If
        If Not IsDBNull(sDtset.Rows(0).Item("Latitude")) Then
            txt_Latitude.Text = sDtset.Rows(0).Item("Latitude")
        End If
        If Not IsDBNull(sDtset.Rows(0).Item("Longitude")) Then
            txt_Longitude.Text = sDtset.Rows(0).Item("Longitude")
        End If

        'สถานะความถูกหลัก
        If IsDBNull(sDtset.Rows(0).Item("stRight")) Then
            Rd_NoSetstRight.Checked = True
        ElseIf sDtset.Rows(0).Item("stRight") = 1 Then
            Rd_right.Checked = True
        ElseIf sDtset.Rows(0).Item("stRight") = 0 Then
            Rd_Noright.Checked = True
        End If

        'สถานะทางการค้า
        If IsDBNull(sDtset.Rows(0).Item("stBusinessType")) Then 'ยังไม่ได้กำหนด
            Rd_NoSetstBusinessT.Checked = True
        ElseIf sDtset.Rows(0).Item("stBusinessType") = 1 Then 'ซื้อ
            Rd_CusBuy.Checked = True
        ElseIf sDtset.Rows(0).Item("stBusinessType") = 2 Then 'ขาย
            Rd_CusSale.Checked = True
        ElseIf sDtset.Rows(0).Item("stBusinessType") = 3 Then 'ซื้อและขาย
            Rd_CusBuySale.Checked = True
        End If

        If Not IsDBNull(sDtset.Rows(0).Item("PsAccept")) Then 'รับทราบ
            txt_Accpet.Text = sDtset.Rows(0).Item("PsAccept")
            txt_DateAccept.Text = ksbStringToDate(sDtset.Rows(0).Item("DateAccept"))
        End If
       
        If Not IsDBNull(sDtset.Rows(0).Item("PsCheck")) Then 'ตรวจสอบ
            txt_Check.Text = sDtset.Rows(0).Item("PsCheck")
            txt_DateCheck.Text = ksbStringToDate(sDtset.Rows(0).Item("DateCheck"))
        End If

        If Not IsDBNull(sDtset.Rows(0).Item("PsApprove")) Then 'อนุมัติ
            txt_Approve.Text = sDtset.Rows(0).Item("PsApprove")
            txt_DateApprove.Text = ksbStringToDate(sDtset.Rows(0).Item("DateApprive"))
        End If

        If Not IsDBNull(sDtset.Rows(0).Item("idPv")) Then
            idPv_ = sDtset.Rows(0).Item("idPv")
        End If
        If Not IsDBNull(sDtset.Rows(0).Item("idAp")) Then
            idAp_ = sDtset.Rows(0).Item("idAp")
        End If
        If Not IsDBNull(sDtset.Rows(0).Item("idTb")) Then
            idTb_ = sDtset.Rows(0).Item("idTb")
        End If
        If Not IsDBNull(sDtset.Rows(0).Item("idTsp")) Then
            idTsp_ = sDtset.Rows(0).Item("idTsp")
        End If





    End Sub

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.ePsAcceptCus 'รับทราบ
                Text = "ทำรายการรับทราบข้อมูลคู่ค้า"
                btn_save.Text = "รับทราบ"
                aProcess = eProcess.ePsAcceptCus
            Case eProcess.ePsCheckCus 'ตรวจสอบ
                Text = "ทำรายการตรวจสอบข้อมูลคู่ค้า"
                btn_save.Text = "ตรวจสอบ"
                btn_save.Size = New Size(95, 38)
                aProcess = eProcess.ePsCheckCus
            Case eProcess.ePsApproveCus 'อนุมัติ
                Text = "ทำรายการอนุมัติข้อมูลคู่ค้า"
                btn_save.Text = "อนุมัติ"
                btn_save.Size = New Size(75, 38)
                aProcess = eProcess.ePsApproveCus
        End Select
        eEvent = aProcess
    End Sub

    Dim sDtPv As New DataTable
    Dim sDtAp As New DataTable
    Dim sDtTb As New DataTable
    Dim sDtTsp As New DataTable
    Dim sDtTspType As New DataTable

    Private Sub frmCusApproveDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
        'จังหวัด
        ShowDataOnCombo(sDtPv, "SELECT PvName, idPv FROM dProvinceFixSale", comboPv, "idPv", "PvName")
        'การขนส่ง
        ShowDataOnCombo(sDtTsp, "SELECT TspName, idTspType  FROM dTsp", ComboTsp, "idTspType", "TspName")
        comboAp.Text = "-"
        comboTb.Text = "-"

        If idCus_ <> 0 Then
            comboPv.SelectedValue = idPv_
            'อำเภอ
            ShowDataOnCombo(sDtAp, "SELECT ApName, idAp FROM dAp WHERE idPv='" & comboPv.SelectedValue & "'", comboAp, "idAp", "ApName")
            comboAp.SelectedValue = idAp_
            'ตำบล
            ShowDataOnCombo(sDtTb, "SELECT TbName, idTb FROM dTb WHERE idAp='" & comboAp.SelectedValue & "'", comboTb, "idTb", "TbName")
            comboTb.SelectedValue = idTb_
            ComboTsp.SelectedValue = idTsp_
            'ประเภทการขนส่ง
            sCommand.CommandText = "SELECT TspTypeName FROM dTspType WHERE idTspType='" & ComboTsp.SelectedValue & "'"
            sAdapter.Fill(sDtTspType)
            If sDtTspType.Rows.Count > 0 Then
                txt_TspType.Text = sDtTspType.Rows(0).Item("TspTypeName")
            Else
                txt_TspType.Text = "---ไม่กำหนด---"
                ComboTsp.Text = "-"
            End If
        End If
    End Sub

#Region "Even ComboBox"
    Private Sub ShowDataOnCombo(ByVal sDtName As DataTable, ByVal SQL As String, ByVal ComboName As ComboBox, ByVal ValueMember As String, ByVal DisplayMember As String)
        sDtName.Clear()
        sCommand.CommandText = SQL
        sAdapter.Fill(sDtName)

        ComboName.DataSource = sDtName
        ComboName.ValueMember = ValueMember          'เก็บค่า ลงฐานข้อมูล
        ComboName.DisplayMember = DisplayMember     'นำข้อมูลในฐานข้อมูลมาแสดง

        'Dim ComboSearch As New AutoCompleteStringCollection
        'Dim ComboAddValue As String

        'For i As Integer = 0 To sDtName.Rows.Count - 1 'นับแถวในฐานข้อมูล
        '    ComboAddValue = sDtName.Rows.Item(i).Item(DisplayMember).ToString()  'ช่วยในการค้นหาจากการพิมพ์ข้อมูลผ่าน Combobox และเลือก Combobox 
        '    ComboSearch.Add(ComboAddValue)
        'Next

        'ComboName.AutoCompleteMode = AutoCompleteMode.Suggest
        'ComboName.AutoCompleteSource = AutoCompleteSource.CustomSource
        'ComboName.AutoCompleteCustomSource = ComboSearch

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        'CusCode, Address, Latitude, Longitude, stRight, C.stBusinessType, C.idTsp, tel , teloff
        Dim result As DialogResult

        If ChkFullData_ = "" Then
            result = MsgBox(" ข้อมูลยังระบุไม่ครบต้องการทำรายการต่อหรือไม่ ?", MsgBoxStyle.YesNo, sSystemName)
            If result = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        If eEvent = eProcess.ePsAcceptCus Then 'รับทราบ
            result = MsgBox("ยืนยันการรับทราบรายการ", MsgBoxStyle.YesNo, sSystemName)
            If result = Windows.Forms.DialogResult.Yes Then
                mdCnOpen()
                sCommand.CommandText = "UPDATE dCustomer SET idPsAccept=" & idPs_ & ", DateAccept='" & UpdateDay & "' WHERE idCus=" & idCus_
                sCommand.ExecuteNonQuery()
                MessageBox.Show("รับทราบรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        ElseIf eEvent = eProcess.ePsCheckCus Then 'ตรวจสอบ
            result = MsgBox("ยืนยันการตรวจสอบรายการ", MsgBoxStyle.YesNo, sSystemName)
            If result = Windows.Forms.DialogResult.Yes Then
                mdCnOpen()
                sCommand.CommandText = "UPDATE dCustomer SET idPsCheck=" & idPs_ & ", DateCheck='" & UpdateDay & "' WHERE idCus=" & idCus_
                sCommand.ExecuteNonQuery()
                MessageBox.Show("ตรวจสอบรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        ElseIf eEvent = eProcess.ePsApproveCus Then 'อนุมัติ
            result = MsgBox("ยืนยันการอนุมัติรายการ", MsgBoxStyle.YesNo, sSystemName)
            If result = Windows.Forms.DialogResult.Yes Then
                mdCnOpen()
                sCommand.CommandText = "UPDATE dCustomer SET idPsApprove=" & idPs_ & ", DateApprive='" & UpdateDay & "' WHERE idCus=" & idCus_
                sCommand.ExecuteNonQuery()
                MessageBox.Show("อนุมัติรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim MyWebClient As New System.Net.WebClient
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(url)
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        Dim pic As System.Drawing.Image = New System.Drawing.Bitmap(ImageStream)
        Return pic
    End Function

    Private Sub Get_Image3(ByVal listname As String)
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/" + listname + "/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))
        Dim i As Integer = 0
        Dim Str() As String
        ftpFiles1 = New ArrayList

        While Not (reader.EndOfStream)
            ftpFiles1.Add(reader.ReadLine())
            Str = ftpFiles1.Item(i).ToString().Split("-")
            If (Str(0) <> idCus_.ToString) Then
                ftpFiles1.RemoveAt(i)
            Else
                i += 1
            End If

        End While
        ftpFiles1.Sort()

        totalRows3 = ftpFiles1.Count

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
            pSetPic3(n3, listname1)

        Else
            'lbCurPage.Text = "หน้าปัจจุบัน : " & page
            Lv1.Clear()
            btnNext3.Enabled = False
            btnLast3.Enabled = False
            btnBack3.Enabled = False
            btnFirst3.Enabled = False
        End If
    End Sub

    Private Sub pSetPic3(ByVal num As Integer, ByVal listname As String)
        Dim strtemp() As String
        Try
            Lv1.Clear()
            Img1.Images.Clear()
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

    Private Sub btnFirst3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst3.Click

        page3 = 1
        curPage3 = page3
        n3 = 0
        nCur3 = n
        pSetPic3(n3, listname1)

    End Sub

    Private Sub btnBack3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack3.Click

        page3 -= 1
        curPage3 = page3
        n3 -= perPage
        nCur3 = n3
        pSetPic3(n3, listname1)

    End Sub

    Private Sub btnNext3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext3.Click

        page3 += 1
        curPage3 = page3
        n3 += perPage
        nCur3 = n3
        pSetPic3(n3, listname1)

    End Sub

    Private Sub btnLast3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast3.Click

        page3 = lastPage3
        curPage3 = page3
        If totalRows3 Mod perPage = 0 Then
            n3 = totalRows3 - perPage
        Else
            n3 = totalRows3 - (totalRows3 Mod perPage)
        End If
        nCur3 = n3
        pSetPic3(n3, listname1)

    End Sub

    Private Sub Get_ImageCusCard(ByVal listname As String)
        Lv2.Clear()
        Img2.Images.Clear()
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/" + listname + "/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))
        Dim i As Integer = 0
        Dim Str() As String
        ftpFiles2 = New ArrayList
        While Not (reader.EndOfStream)
            ftpFiles2.Add(reader.ReadLine())
            Str = ftpFiles2.Item(i).ToString().Split(".jpg")
            If (Str(0) <> idCus_.ToString) Then
                ftpFiles2.RemoveAt(i)
            Else
                Img2.Images.Add(ftpFiles2.Item(i).ToString(), getImg("http://" & sHost & sFtpPathMain & "images/" & listname & "/" & ftpFiles2.Item(i).ToString()))
                Dim listItem As New ListViewItem()
                listItem.ImageKey = ftpFiles2.Item(i).ToString()
                Lv2.Items.Add(listItem)
                i += 1
            End If

        End While
    End Sub

    Private Sub Get_ImageCusRegistration(ByVal listname As String)
        Lv3.Clear()
        Img3.Images.Clear()
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/" + listname + "/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))
        Dim i As Integer = 0
        Dim Str() As String
        ftpFiles3 = New ArrayList
        While Not (reader.EndOfStream)
            ftpFiles3.Add(reader.ReadLine())
            Str = ftpFiles3.Item(i).ToString().Split(".jpg")
            If (Str(0) <> idCus_.ToString) Then
                ftpFiles3.RemoveAt(i)
            Else
                Img3.Images.Add(ftpFiles3.Item(i).ToString(), getImg("http://" & sHost & sFtpPathMain & "images/" & listname & "/" & ftpFiles3.Item(i).ToString()))
                Dim listItem As New ListViewItem()
                listItem.ImageKey = ftpFiles3.Item(i).ToString()
                Lv3.Items.Add(listItem)
                i += 1
            End If

        End While
    End Sub

    Private Sub Get_ImageCusCommercial(ByVal listname As String)
        Lv4.Clear()
        Img4.Images.Clear()
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/" + listname + "/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))
        Dim i As Integer = 0
        Dim Str() As String
        ftpFiles4 = New ArrayList
        While Not (reader.EndOfStream)
            ftpFiles4.Add(reader.ReadLine())
            Str = ftpFiles4.Item(i).ToString().Split(".jpg")
            If (Str(0) <> idCus_.ToString) Then
                ftpFiles4.RemoveAt(i)
            Else
                Img4.Images.Add(ftpFiles4.Item(i).ToString(), getImg("http://" & sHost & sFtpPathMain & "images/" & listname & "/" & ftpFiles4.Item(i).ToString()))
                Dim listItem As New ListViewItem()
                listItem.ImageKey = ftpFiles4.Item(i).ToString()
                Lv4.Items.Add(listItem)
                i += 1
            End If
        End While
    End Sub

    Private Sub Lv1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv1.DoubleClick

        'frm.Get_UrlImg(str, Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        'frm.ShowDialog()
        'System.Diagnostics.Process.Start(str)

        My.Computer.Network.DownloadFile("http://" & sHost & sFtpPathMain & "images/pCusOwner/" & Lv1.Items(Lv1.FocusedItem.Index).ImageKey, Lv1.Items(Lv1.FocusedItem.Index).ImageKey)
        Dim myProcess As Process = System.Diagnostics.Process.Start(Lv1.Items(Lv1.FocusedItem.Index).ImageKey)
        'While Not myProcess.HasExited
        '    myProcess.Refresh()
        'End While
        myProcess.WaitForExit()
        System.IO.File.Delete(Lv1.Items(Lv1.FocusedItem.Index).ImageKey)
        
    End Sub

    Private Sub Lv2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv2.DoubleClick

        'frm.Get_UrlImg(str, Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        'frm.ShowDialog()
        'System.Diagnostics.Process.Start(str)
        My.Computer.Network.DownloadFile("http://" & sHost & sFtpPathMain & "images/pCusCard/" & Lv2.Items(Lv2.FocusedItem.Index).ImageKey, Lv2.Items(Lv2.FocusedItem.Index).ImageKey)

        Dim myProcess As Process = System.Diagnostics.Process.Start(Lv2.Items(Lv2.FocusedItem.Index).ImageKey)
        'While Not myProcess.HasExited
        '    myProcess.Refresh()
        'End While
        myProcess.WaitForExit()
        System.IO.File.Delete(Lv2.Items(Lv2.FocusedItem.Index).ImageKey)
       
    End Sub

    Private Sub Lv3_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv3.DoubleClick
        
        'System.IO.File.Delete(Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        My.Computer.Network.DownloadFile("http://" & sHost & sFtpPathMain & "images/pCusRegistration/" & Lv3.Items(Lv3.FocusedItem.Index).ImageKey, Lv3.Items(Lv3.FocusedItem.Index).ImageKey)

        Dim myProcess As Process = System.Diagnostics.Process.Start(Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        myProcess.WaitForExit()
        System.IO.File.Delete(Lv3.Items(Lv3.FocusedItem.Index).ImageKey)

    End Sub


    Private Sub Lv4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv4.DoubleClick

        'frm.Get_UrlImg(str, Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        'frm.ShowDialog()
        'System.Diagnostics.Process.Start(str)

        My.Computer.Network.DownloadFile("http://" & sHost & sFtpPathMain & "images/pCusCommercial/" & Lv4.Items(Lv4.FocusedItem.Index).ImageKey, Lv4.Items(Lv4.FocusedItem.Index).ImageKey)

        Dim myProcess As Process = System.Diagnostics.Process.Start(Lv4.Items(Lv4.FocusedItem.Index).ImageKey)
        myProcess.WaitForExit()
        'While Not myProcess.HasExited
        '    myProcess.Refresh()
        'End While
        System.IO.File.Delete(Lv4.Items(Lv4.FocusedItem.Index).ImageKey)
        
    End Sub

End Class

