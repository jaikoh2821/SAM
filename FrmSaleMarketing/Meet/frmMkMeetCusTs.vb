Public Class frmMkMeetCusTs
    Public idTs As String
    Public sAddress As String
    Public Sub getIdMeet(ByVal id As Integer)
        idTs = id
    End Sub
    Private Sub setTextUpdate()

        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT sM.MeetDetail, sM.DateMeet, sMD.MeetName, C.CusName_, P.PsName, sMD.idMeet, sM.idCus, P.idPs, sM.stAddress " & _
                                " FROM dbo.SmMkMeet AS sM INNER JOIN dbo.SmMkMeetData AS sMD " & _
                                " ON sM.idMeet = sMD.idMeet INNER JOIN dbo.vCustomer AS C " & _
                                " ON sM.idCus = C.idCus INNER JOIN dbo.vPerson AS P ON sM.idPs = P.idPs WHERE idTs='" & idTs & "' ORDER BY sM.DateMeet DESC"
        sAdapter.Fill(sDt)
        txtDetailMeet.Text = sDt.Rows(0).ItemArray(0).ToString
        DateTime_Ts1.Value = ksbStringToDate(sDt.Rows(0).ItemArray(1).ToString)
        ' Set หัวข้อ MeetName And idMeet
        txtTitleCus.Text = sDt.Rows(0).ItemArray(2).ToString
        txtTitleCus.Tag = sDt.Rows(0).ItemArray(5).ToString
        ' Set พนักงาน PsName And idPs
        txtEmp.Text = sDt.Rows(0).ItemArray(4).ToString
        txtEmp.Tag = sDt.Rows(0).ItemArray(7).ToString
        ' Set คู่ค้า CusName_ And idCus
        txtCus.Text = sDt.Rows(0).ItemArray(3).ToString
        txtCus.Tag = sDt.Rows(0).ItemArray(6).ToString
        sAddress = sDt.Rows(0).ItemArray(8).ToString
        If sAddress.Equals("0") Then
            Rd_Abroad.Checked = True
        Else
            Rd_InThai.Checked = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vFrm As New frmMkMeetCus(frmMkMeetCus.eProcess.eChange)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtTitleCus.Tag = vFrm.sIdMeet
            txtTitleCus.Text = vFrm.sMeetName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Rd_InThai.Checked = True Then
            Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eInThaiAndSale, sIdComp)
            vFrm.idPs = txtEmp.Tag
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCus.Tag = vFrm.idCus
                txtCus.Text = vFrm.CusName
            End If
        Else
            Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eFrgAndSale, sIdComp)
            vFrm.idPs = txtEmp.Tag
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCus.Tag = vFrm.idCus
                txtCus.Text = vFrm.CusName
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim vFrm As New frmSsQcPersonSelect(frmSsQcPersonSelect.eProcess.eRdSale)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtEmp.Tag = vFrm.id
            txtEmp.Text = vFrm.PsName
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txtCus.Text = "" Or txtEmp.Text = "" Or txtDetailMeet.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบก่อนกด 'บันทึก' ", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Rd_InThai.Checked = True Then
                sAddress = "1"
            Else
                sAddress = "0"
            End If
            mdCnOpen()
            If idTs <> "" Then
                sCommand.CommandText = "UPDATE  SmMkMeet SET idMeet='" & txtTitleCus.Tag & "', idCus='" & txtCus.Tag & "', idPs='" & txtEmp.Tag & "', MeetDetail='" & txtDetailMeet.Text & "', DateMeet='" & ksbDateToString(DateTime_Ts1.Value.ToShortDateString) & "', stAddress='" & sAddress & "'  WHERE idTs ='" & idTs & "'"
                sCommand.ExecuteNonQuery()
                MessageBox.Show("ระบบได้ทำการบันทึกข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else

                sCommand.CommandText = "INSERT INTO SmMkMeet (idMeet, idCus, idPs, MeetDetail, DateMeet, stAddress) VALUES ('" & txtTitleCus.Tag & "', '" & txtCus.Tag & "', '" & txtEmp.Tag & "', '" & txtDetailMeet.Text & "', '" & ksbDateToString(DateTime_Ts1.Value.ToShortDateString) & "','" & sAddress & "')"
                Dim Result As DialogResult
                Result = MsgBox("คุณต้องการบันทึกข้อมูล ? ", MsgBoxStyle.YesNo)
                If Result = Windows.Forms.DialogResult.Yes Then
                    sCommand.ExecuteNonQuery()
                    MessageBox.Show("ระบบได้ทำการเพิ่มข้อมูลเรียบร้อยแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub frmMkMeetCusTs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If idTs <> "" Then
            setTextUpdate()
        End If
    End Sub
End Class