Public Class frmPsSaleCommDetail
    Dim idPdT_ As Integer = 0
    Dim idComm_ As Integer
    Dim Status As Integer
    Dim Mode_ As Integer
    Dim DateComm As String

    Enum eProcess
        eUDATE
        eADD
    End Enum
    Sub New(ByVal aProcess As eProcess, ByVal mode As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Mode_ = mode
        If Mode_ = 1 Then
            txt_PdtName.Visible = True
            btn_seed.Visible = True
            Label2.Visible = True
        End If
        Select Case aProcess
            Case eProcess.eUDATE
                Status = 0
                btn_del.Visible = True
            Case eProcess.eADD
                Status = 1
        End Select
    End Sub
    Sub get_value(ByVal idComm As Integer)
        idComm_ = idComm
    End Sub
    Sub get_valueDate(ByVal strDate As String)
        DateComm = strDate
    End Sub
    Private Sub frmPsSaleCommDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdCnOpen()
        If Status = 0 Then
            Load_Data()
        End If

    End Sub
    Dim d_Comm As New DataTable
    Dim d_CommP As New DataTable
    Private Sub Load_Comm(ByVal vWhere As String)
        d_Comm.Clear()
        d_CommP.Clear()
        If Mode_ = 0 Then
            If Status = 0 Then
                sCommand.CommandText = "SELECT DateComm, PayComm, Comm FROM SmPsSaleComm Where DateComm = '" & vWhere & "' AND idComm <> " & idComm_ & " AND idComp = " & sIdComp & " Order by PayComm DESC"
            Else
                sCommand.CommandText = "SELECT DateComm, PayComm, Comm FROM SmPsSaleComm Where DateComm = '" & vWhere & "' AND idComp = " & sIdComp & " Order by PayComm DESC"
            End If
            sAdapter.Fill(d_Comm)
        ElseIf Mode_ = 1 Then
            If Status = 0 Then
                sCommand.CommandText = "SELECT DateCommP, PayCommP, CommP, idPdT FROM SmPsSaleCommProduct Where DateCommP = " & vWhere & " AND idCommP <> " & idComm_ & " AND idComp = " & sIdComp & " Order by PayCommP DESC"
            Else
                sCommand.CommandText = "SELECT DateCommP, PayCommP, CommP, idPdT FROM SmPsSaleCommProduct Where DateCommP = " & vWhere & " AND idComp = " & sIdComp & " Order by PayCommP DESC"
            End If
            sAdapter.Fill(d_CommP)
        End If
    End Sub
    Private Sub Load_Data()
        Dim Psc As New DataTable
        Psc.Clear()
        If Mode_ = 0 Then
            sCommand.CommandText = "SELECT DateComm, PayComm, Comm FROM SmPsSaleComm Where idComm = " & idComm_
        Else
            sCommand.CommandText = "SELECT s.DateCommP, s.PayCommP, s.CommP, s.idPdT ,v.PdTradeName FROM SmPsSaleCommProduct as s " & _
            "INNER JOIN vSlPdTradeNameD as v ON s.idPdT = v.idPdT Where idCommP = " & idComm_
        End If
        sAdapter.Fill(Psc)
        If Mode_ = 0 Then
            DateComm = Psc.Rows(0).Item("DateComm")
            DateComm = DateComm.Substring(0, 6)
            'dtp_dateComm.Value = ksbStringToDate(DateComm)
            txt_Pay.Text = Psc.Rows(0).Item("PayComm")
            txt_Comm.Text = Psc.Rows(0).Item("Comm")
        Else
            DateComm = Psc.Rows(0).Item("DateCommP")
            DateComm = DateComm.Substring(0, 6)
            'dtp_dateComm.Value = ksbStringToDate(DateComm)
            txt_Pay.Text = Psc.Rows(0).Item("PayCommP")
            txt_Comm.Text = Psc.Rows(0).Item("CommP")
            txt_PdtName.Text = Psc.Rows(0).Item("PdTradeName")
            idPdT_ = Psc.Rows(0).Item("idPdT")
        End If
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        mdLoadShow()
        mdCnOpen()
        If Mode_ = 1 And (Me.txt_PdtName.Text = "" Or Me.txt_Pay.Text = "" Or Me.txt_Comm.Text = "") Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        ElseIf Mode_ = 0 And (Me.txt_Pay.Text = "" Or Me.txt_Comm.Text = "") Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If
        'DateComm = ksbDateToString(Format(dtp_dateComm.Value, "Short date").ToString())
        'DateComm = DateComm.Substring(0, 6)
        'DateComm = (Microsoft.VisualBasic.Left(DateComm, DateComm.Length - 2))
        If Mode_ = 0 Then
            chkDateComm()
            chkComm()
            If chkDate = False Then
                MessageBox.Show("ยอดขายซ้ำซ้อน")
                Exit Sub
            ElseIf chk_Comm = False Then
                MessageBox.Show("ค่าคอมมิสชั่นไม่ถูกต้องตามหลักการ")
                Exit Sub
            Else
                If MessageBox.Show("ต้องการบันทึกข้อมูลหรือไม่", "บันทึกข้อมูล", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    If Status = 0 Then
                        sCommand.CommandText = "UPDATE SmPsSaleComm SET PayComm = " & txt_Pay.Text & ",Comm = " & txt_Comm.Text & " Where idComm = " & idComm_
                    Else
                        sCommand.CommandText = "INSERT INTO SmPsSaleComm (DateComm, PayComm, Comm,idComp) VALUES ('" & DateComm & "'," & txt_Pay.Text & "," & txt_Comm.Text & "," & sIdComp & ")"
                    End If
                    sCommand.ExecuteNonQuery()
                    MessageBox.Show("บันทึกเรียบร้อยแล้ว")
                Else
                    Exit Sub
                End If
            End If
        Else
            chkDateComm()
            chkComm()
            If chkDate = False Then
                MessageBox.Show("ยอดขายซ้ำซ้อน")
                Exit Sub
            ElseIf chk_Comm = False Then
                MessageBox.Show("ค่าคอมมิสชั่นไม่ถูกต้องตามหลักการ")
                Exit Sub
            Else
                If MessageBox.Show("ต้องการบันทึกข้อมูลหรือไม่", "บันทึกข้อมูล", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    If Status = 0 Then
                        sCommand.CommandText = "UPDATE SmPsSaleCommProduct SET PayCommP = " & txt_Pay.Text & ",CommP = " & txt_Comm.Text & ",idPdT = " & idPdT_ & " Where idCommP = " & idComm_
                    Else
                        sCommand.CommandText = "INSERT INTO SmPsSaleCommProduct (DateCommP, PayCommP, CommP, idPdT,idComp) VALUES ('" & DateComm & "'," & txt_Pay.Text & "," & txt_Comm.Text & "," & idPdT_ & "," & sIdComp & ")"
                    End If
                    sCommand.ExecuteNonQuery()
                    MessageBox.Show("บันทึกเรียบร้อยแล้ว")
                Else
                    Exit Sub
                End If
            End If
        End If

        DialogResult = Windows.Forms.DialogResult.OK
        mdLoadCommitt()
    End Sub
    Private Sub btn_seed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_seed.Click
        Dim frm_s As New frmPdTSerach(frmPdTSerach.eProcess.eAll)
        frm_s.ShowDialog()
        If frm_s.idPdT > 0 Then
            idPdT_ = frm_s.idPdT
            txt_PdtName.Text = frm_s.PdTName
        End If
    End Sub

    Dim chkDate As Boolean = True
    Private Sub chkDateComm()
        chkDate = True
        Dim chk_D As New DataTable
        chk_D.Clear()
        If Mode_ = 0 Then
            If Status = 0 Then
                sCommand.CommandText = "SELECT idComm, DateComm, PayComm, Comm FROM SmPsSaleComm Where DateComm = '" & DateComm & "' AND PayComm = " & txt_Pay.Text & " AND idComm <> " & idComm_ & " AND idComp = " & sIdComp
            Else
                sCommand.CommandText = "SELECT idComm, DateComm, PayComm, Comm FROM SmPsSaleComm Where DateComm = '" & DateComm & "' AND PayComm = " & txt_Pay.Text & " AND idComp = " & sIdComp
            End If
        Else
            If Status = 0 Then
                sCommand.CommandText = "SELECT idCommP, DateCommP, PayCommP, CommP, idPdT FROM SmPsSaleCommProduct " & _
                            "Where DateCommP = '" & DateComm & "' AND PayCommP = " & txt_Pay.Text & " AND idPdT = " & idPdT_ & " AND idCommP <> " & idComm_ & " AND idComp = " & sIdComp
            Else
                sCommand.CommandText = "SELECT idCommP, DateCommP, PayCommP, CommP, idPdT FROM SmPsSaleCommProduct " & _
                            "Where DateCommP = '" & DateComm & "' AND PayCommP = " & txt_Pay.Text & " AND idPdT = " & idPdT_ & " AND idComp = " & sIdComp
            End If

        End If
        sAdapter.Fill(chk_D)
        If chk_D.Rows.Count > 0 Then
            chkDate = False
        End If
    End Sub
    Dim chk_Comm As Boolean
    Private Sub chkComm()
        Dim sWhere As String
        If Mode_ = 0 Then
            sWhere = DateComm
            Load_Comm(sWhere)
            chk_Comm = True
            For i As Integer = 0 To d_Comm.Rows.Count - 1
                Dim test As String = d_Comm.Rows(i).Item("PayComm").ToString
                If d_Comm.Rows(i).Item("PayComm") > txt_Pay.Text Then
                    If d_Comm.Rows(i).Item("Comm") <= txt_Comm.Text Then
                        chk_Comm = False
                        Exit For
                    End If
                ElseIf d_Comm.Rows(i).Item("PayComm") < txt_Pay.Text Then
                    If d_Comm.Rows(i).Item("Comm") >= txt_Comm.Text Then
                        chk_Comm = False
                        Exit For
                    End If
                End If
            Next
        Else
            sWhere = "'" & DateComm & "' AND idPdT = " & idPdT_
            Load_Comm(sWhere)
            chk_Comm = True
            For i As Integer = 0 To d_CommP.Rows.Count - 1
                Dim test As String = d_CommP.Rows(i).Item("PayCommP").ToString
                Dim test1 As String = d_CommP.Rows(i).Item("CommP").ToString
                If d_CommP.Rows(i).Item("PayCommP") > txt_Pay.Text Then
                    If d_CommP.Rows(i).Item("CommP") <= txt_Comm.Text Then
                        chk_Comm = False
                        Exit For
                    End If
                ElseIf d_CommP.Rows(i).Item("PayCommP") < txt_Pay.Text Then
                    If d_CommP.Rows(i).Item("CommP") >= txt_Comm.Text Then
                        chk_Comm = False
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        mdLoadShow()
        mdCnOpen()
        If MessageBox.Show("ต้องการลบข้อมูลหรือไม่", "ลบข้อมูล", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If Mode_ = 0 Then
                sCommand.CommandText = "DELETE FROM SmPsSaleComm Where idComm = " & idComm_
                sCommand.ExecuteNonQuery()
            Else
                sCommand.CommandText = "DELETE FROM SmPsSaleCommProduct Where idCommP = " & idComm_
                sCommand.ExecuteNonQuery()
            End If
        End If
        DialogResult = Windows.Forms.DialogResult.OK
        mdLoadCommitt()
    End Sub
End Class