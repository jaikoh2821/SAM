Public Class frmTspDetail
    Public idTsp As String
    Dim Transport As New DataTable
    Dim dtPv As New DataTable
    Dim dtAp As New DataTable
    Dim dtTb As New DataTable
    Dim dtTspType As New DataTable

    Public Sub GetidTsp(ByVal id As String)
        idTsp = id
    End Sub

    Public Sub setText()
        mdCnOpen()
        sCommand.CommandText = "SELECT TspName, TspShort, Tsptel, TspAddress, idPv, idAp, idTb, TspArea, TspNote, importance, idTspType FROM dTsp WHERE idTsp = '" & idTsp & "'"
        sAdapter.Fill(Transport)
        ShowComboBoxPv()
        ShowComboBoxAp()
        ShowComboBoxTb()
        txtTspName.Text = Transport.Rows(0).ItemArray(0).ToString()
        txtTspShort.Text = Transport.Rows(0).ItemArray(1).ToString()
        txtTsptel.Text = Transport.Rows(0).ItemArray(2).ToString()
        txtTspAddress.Text = Transport.Rows(0).ItemArray(3).ToString()
        txtTspArea.Text = Transport.Rows(0).ItemArray(7).ToString()
        txtTspNote.Text = Transport.Rows(0).ItemArray(8).ToString()
        txtImportance.Text = Transport.Rows(0).ItemArray(9).ToString()

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)
        e.Handled = CheckDigitOnly(KeyAscii)
    End Sub

    Private Sub frmTspDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If idTsp <> "" Then
            setText()
            btn_Delete.Visible = True
        Else
            btn_Delete.Visible = False
        End If
        ShowComboBoxPv()
        ShowComboBoxAp()
        ShowComboBoxTb()
        ShowComboBoxTsb()
    End Sub
#Region "SAVE_DATA"
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txtTspName.Text = "" Then 'Or txtTspArea.Text = "" Or txtTspAddress.Text = "" Or txtTspShort.Text = "" Then
            MessageBox.Show("กรุณากรอกชื่อการขนส่งก่อนกด 'บันทึก'", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'เช็คชื่อจากการกรอกคอมโบจังหวัด
            Dim dvPv As New DataView(dtPv)
            dvPv.RowFilter = "PvName =  '" & comboPv.Text & "'"
            If dvPv.Count = 0 Then
                MessageBox.Show("ไม่สามารถบันทึกได้เนื่องจาก" & Environment.NewLine & "  - ใส่ข้อมูลจังหวัดผิดรูปแบบที่กำหนดให้", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'เช็คชื่อจากการกรอกคอมโบอำเภอ
            Dim dvAp As New DataView(dtAp)
            dvAp.RowFilter = "ApName =  '" & comboAp.Text & "'"
            If dvAp.Count = 0 Then
                MessageBox.Show("ไม่สามารถบันทึกได้เนื่องจาก" & Environment.NewLine & "  - ใส่ข้อมูลอำเภอผิดรูปแบบที่กำหนดให้", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'เช็คชื่อจากการกรอกคอมโบตำบล
            Dim dvTb As New DataView(dtTb)
            dvTb.RowFilter = "TbName =  '" & comboTb.Text & "'"
            If dvTb.Count = 0 Then
                MessageBox.Show("ไม่สามารถบันทึกได้เนื่องจาก" & Environment.NewLine & "  - ใส่ข้อมูลตำบลผิดรูปแบบที่กำหนดให้", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'เช็คชื่อจากการกรอกคอมโบรูปแบบการขนส่ง
            Dim dvTspType As New DataView(dtTspType)
            dvTspType.RowFilter = "TspTypeName =  '" & ComboTsp.Text & "'"
            If dvTspType.Count = 0 Then
                MessageBox.Show("ไม่สามารถบันทึกได้เนื่องจาก" & Environment.NewLine & "  - ใส่ข้อมูลรูปแบบการขนส่งผิดรูปแบบที่กำหนดให้", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'เช็คชื่อการขนส่งซ้ำ
            Dim DtCheckTspName As New DataTable
            'เช็คชื่อย่อการขนส่งซ้ำ
            Dim DtCheckTspShort As New DataTable
            'เรียง Importance น้อยไปหามาก
            Dim DtSortImportance As New DataTable

            'เช็คความสำคัญลำดับการจัดส่ง
            If idTsp <> "" Then
                sCommand.CommandText = "SELECT idTsp, importance FROM dTsp WHERE  importance IS NOT NULL And idTsp <> " & idTsp & "  ORDER BY importance ASC"
            Else
                sCommand.CommandText = "SELECT idTsp, importance FROM dTsp WHERE  importance IS NOT NULL  ORDER BY importance ASC"

            End If
            sAdapter.Fill(DtSortImportance)

            Dim ChkImportance As String = ""
            Dim updateImportance As String = "UPDATE dTsp SET importance='"
            Dim SQL As String = ""
            'Check importance
            If txtImportance.Text <> "" Then
                ChkImportance = "'" & txtImportance.Text & "'"
                For i As Integer = 0 To DtSortImportance.Rows.Count - 1
                    DtSortImportance.Rows(i).Item(1) = i + 1

                    If DtSortImportance.Rows(i).Item(1) = txtImportance.Text Or DtSortImportance.Rows(i).Item(1) > txtImportance.Text Then
                        DtSortImportance.Rows(i).Item(1) = i + 2
                        SQL &= updateImportance & DtSortImportance.Rows(i).Item(1) & "' WHERE idTsp='" & DtSortImportance.Rows(i).Item(0) & "'" & Environment.NewLine

                    Else
                        SQL &= updateImportance & DtSortImportance.Rows(i).Item(1) & "' WHERE idTsp='" & DtSortImportance.Rows(i).Item(0) & "'" & Environment.NewLine

                    End If
                Next
            Else
                ChkImportance = " NULL "
            End If

            Dim ChkTspShort As String = ""
            'Check TspShort
            If txtTspShort.Text = "" Then
                ChkTspShort = " NULL "
            Else
                ChkTspShort = "'" & txtTspShort.Text & "'"
            End If
            If txtImportance.Text = "0" Then
                dtAp.Clear()
                dtTb.Clear()
                MessageBox.Show("ไม่สามารถใส่ลำดับการขนส่งนี้ได้เนื่องจาก" & Environment.NewLine & "  - มีค่าน้อยกว่า 1", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If idTsp = "" Then 'insert

                sCommand.CommandText = "SELECT COUNT(TspName) As cntTspName FROM dTsp WHERE TspName='" & txtTspName.Text.Trim & "'"
                sAdapter.Fill(DtCheckTspName)
                If DtCheckTspName.Rows(0).Item(0) = 1 Then
                    MessageBox.Show("ไม่สามารถเพิ่มชื่อนี้ได้เนื่องจาก" & Environment.NewLine & "  - ชื่อนี้มีอยู่ในระบบแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                sCommand.CommandText = "SELECT COUNT(TspShort) As cntTspShort FROM dTsp WHERE TspShort='" & txtTspShort.Text & "'"
                sAdapter.Fill(DtCheckTspShort)
                If DtCheckTspShort.Rows(0).Item(0) = 1 Then
                    MessageBox.Show("ไม่สามารถเพิ่มรหัสย่อนี้ได้เนื่องจาก" & Environment.NewLine & "  - รหัสนี้มีอยู่ในระบบแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                sCommand.CommandText = "INSERT INTO dTsp (TspName, TspShort, Tsptel, TspAddress, idPv, idAp, idTb, TspNote, TspArea, importance, idTspType) VALUES " & _
                "('" & txtTspName.Text & "'," & ChkTspShort & ", '" & txtTsptel.Text & "', '" & txtTspAddress.Text & "', '" & comboPv.SelectedValue & "', " & _
                "'" & comboAp.SelectedValue & "', '" & comboTb.SelectedValue & "', '" & txtTspNote.Text & "', '" & txtTspArea.Text & "', " & ChkImportance & ", '" & ComboTsp.SelectedValue & "')"

            Else 'update
                sCommand.CommandText = "SELECT COUNT(TspName) As cntTspName FROM dTsp WHERE TspName='" & txtTspName.Text & "' And idTsp <> '" & idTsp & "'"
                sAdapter.Fill(DtCheckTspName)
                If DtCheckTspName.Rows(0).Item(0) = 1 Then
                    MessageBox.Show("ไม่สามารถใช้ชื่อนี้ได้เนื่องจาก" & Environment.NewLine & "  - ชื่อนี้มีอยู่ในระบบแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                sCommand.CommandText = "SELECT COUNT(TspShort) As cntTspShort FROM dTsp WHERE TspShort='" & txtTspShort.Text & "' And idTsp <> '" & idTsp & "'"
                sAdapter.Fill(DtCheckTspShort)
                If DtCheckTspShort.Rows(0).Item(0) = 1 Then
                    MessageBox.Show("ไม่สามารถเพิ่มรหัสย่อนี้ได้เนื่องจาก" & Environment.NewLine & "  - รหัสนี้มีอยู่ในระบบแล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                sCommand.CommandText = "UPDATE dTsp SET TspName='" & txtTspName.Text & "', TspShort=" & ChkTspShort & ", " & _
                "Tsptel='" & txtTsptel.Text & "', TspAddress='" & txtTspAddress.Text & "', idPv='" & comboPv.SelectedValue & "', " & _
                "idAp='" & comboAp.SelectedValue & "', idTb='" & comboTb.SelectedValue & "', TspNote='" & txtTspNote.Text & "', " & _
                "TspArea='" & txtTspArea.Text & "', importance=" & ChkImportance & ", idTspType='" & ComboTsp.SelectedValue & "' WHERE idTsp='" & idTsp & "'"

            End If

            Try 'Query
                Dim Result As DialogResult
                Result = MsgBox("คุณต้องการบันทึกข้อมูลนี้ ใช่หรือไม่ ?", MsgBoxStyle.YesNo)
                If Result = Windows.Forms.DialogResult.Yes Then
                    sCommand.ExecuteNonQuery()
                    sCommand.CommandText = SQL
                    sCommand.ExecuteNonQuery()

                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            Catch ex As Exception
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End Try
        End If
    End Sub
#End Region
#Region "ShowAllCombo"
    Private Sub ShowComboBoxTsb()
        mdCnOpen()
        sCommand.CommandText = "SELECT case when idTspType = 1 then 0 else 1 end as sort, idTspType, TspTypeName FROM dTspType ORDER BY sort,TspTypeName"
        sAdapter.Fill(dtTspType)

        Me.ComboTsp.DataSource = dtTspType
        Me.ComboTsp.ValueMember = "idTspType"          'เก็บค่า ลงฐานข้อมูล
        Me.ComboTsp.DisplayMember = "TspTypeName"     'นำข้อมูลในฐานข้อมูลมาแสดง

        Dim TbName As New AutoCompleteStringCollection
        Dim sTbName As String

        For i As Integer = 0 To dtTspType.Rows.Count - 1 'นับแถวในฐานข้อมูล
            sTbName = dtTspType.Rows.Item(i).Item("TspTypeName").ToString()  'ช่วยในการค้นหาจากการพิมพ์ข้อมูลผ่าน Combobox และเลือก Combobox 
            TbName.Add(sTbName)

        Next
        Me.ComboTsp.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.ComboTsp.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.ComboTsp.AutoCompleteCustomSource = TbName
        If idTsp <> "" Then
            If Not Transport.Rows(0).Item(10) Is DBNull.Value Then
                ComboTsp.SelectedValue = Transport.Rows(0).Item(10)
            End If
        End If
    End Sub

    Private Sub ShowComboBoxPv()
        mdCnOpen()
        dtPv.Clear()
        sCommand.CommandText = " SELECT PvName, idPv FROM dProvinceFixSale"
        sAdapter.Fill(dtPv)

        Me.comboPv.DataSource = dtPv
        Me.comboPv.ValueMember = "idPv"          'เก็บค่า ลงฐานข้อมูล
        Me.comboPv.DisplayMember = "PvName"     'นำข้อมูลในฐานข้อมูลมาแสดง

        Dim TspN As New AutoCompleteStringCollection
        Dim sTspN As String

        For i As Integer = 0 To dtPv.Rows.Count - 1 'นับแถวในฐานข้อมูล
            sTspN = dtPv.Rows.Item(i).Item("PvName").ToString()  'ช่วยในการค้นหาจากการพิมพ์ข้อมูลผ่าน Combobox และเลือก Combobox 
            TspN.Add(sTspN)

        Next
        Me.comboPv.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.comboPv.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.comboPv.AutoCompleteCustomSource = TspN

        If idTsp <> "" Then
            If Not Transport.Rows(0).Item(4) Is DBNull.Value Then
                comboPv.SelectedValue = Transport.Rows(0).Item(4)
            End If
        End If
    End Sub

    Private Sub ShowComboBoxAp()
        mdCnOpen()
        dtAp.Clear()
        sCommand.CommandText = " SELECT ApName, idAp FROM dAp WHERE idPv='" & comboPv.SelectedValue & "'" ' And idAp <> 0"
        sAdapter.Fill(dtAp)

        Me.comboAp.DataSource = dtAp
        Me.comboAp.ValueMember = "idAp"          'เก็บค่า ลงฐานข้อมูล
        Me.comboAp.DisplayMember = "ApName"     'นำข้อมูลในฐานข้อมูลมาแสดง

        Dim ApName As New AutoCompleteStringCollection
        Dim sApName As String

        For i As Integer = 0 To dtAp.Rows.Count - 1 'นับแถวในฐานข้อมูล
            sApName = dtAp.Rows.Item(i).Item("ApName").ToString()  'ช่วยในการค้นหาจากการพิมพ์ข้อมูลผ่าน Combobox และเลือก Combobox 
            ApName.Add(sApName)

        Next
        Me.comboAp.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.comboAp.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.comboAp.AutoCompleteCustomSource = ApName
        If idTsp <> "" Then
            If Not Transport.Rows(0).Item(5) Is DBNull.Value Then
                comboAp.SelectedValue = Transport.Rows(0).Item(5)
            End If
        End If
    End Sub

    Private Sub ShowComboBoxTb()
        mdCnOpen()
        dtTb.Clear()
        sCommand.CommandText = " SELECT TbName, idTb FROM dTb WHERE idAp='" & comboAp.SelectedValue & "'" ' And idTb <> 0"
        sAdapter.Fill(dtTb)

        Me.comboTb.DataSource = dtTb
        Me.comboTb.ValueMember = "idTb"          'เก็บค่า ลงฐานข้อมูล
        Me.comboTb.DisplayMember = "TbName"     'นำข้อมูลในฐานข้อมูลมาแสดง

        Dim TbName As New AutoCompleteStringCollection
        Dim sTbName As String

        For i As Integer = 0 To dtTb.Rows.Count - 1 'นับแถวในฐานข้อมูล
            sTbName = dtTb.Rows.Item(i).Item("TbName").ToString()  'ช่วยในการค้นหาจากการพิมพ์ข้อมูลผ่าน Combobox และเลือก Combobox 
            TbName.Add(sTbName)

        Next
        Me.comboTb.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.comboTb.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.comboTb.AutoCompleteCustomSource = TbName
        If idTsp <> "" Then
            If Not Transport.Rows(0).Item(6) Is DBNull.Value Then
                comboTb.SelectedValue = Transport.Rows(0).Item(6)
            End If
        End If
    End Sub
#End Region
    Private Sub BtOutList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Dim chkSaleList As New DataTable
        sCommand.CommandText = "SELECT COUNT(idTS) FROM SmSaleMt WHERE idTS='" & idTsp & "'"
        sAdapter.Fill(chkSaleList)
        Dim chkTpsdCus As New DataTable
        sCommand.CommandText = "SELECT COUNT(idTsp) FROM dCustomer WHERE idTsp='" & idTsp & "'"
        sAdapter.Fill(chkTpsdCus)
        Dim chkSend As New DataTable
        sCommand.CommandText = "SELECT COUNT(idTS) FROM SmSendTs WHERE idTS='" & idTsp & "'"
        sAdapter.Fill(chkSend)
        If chkSaleList.Rows(0).Item(0) > 0 Or chkTpsdCus.Rows(0).Item(0) > 0 Or chkSend.Rows(0).Item(0) > 0 Then
            MessageBox.Show("ไม่สามารถลบข้อมูลนี้ได้เนื่องจาก" & Environment.NewLine & "  -  ข้อมูลถูกนำไปใช้แล้ว", "SAM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim Result As DialogResult
        Result = MsgBox("คุณต้องการลบข้อมูลนี้ ใช่หรือไม่ ?", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            sCommand.CommandText = "DELETE FROM dTsp WHERE idTsp='" & idTsp & "'"
            sCommand.ExecuteNonQuery()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub comboPv_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboPv.SelectionChangeCommitted
        ShowComboBoxAp()
        ShowComboBoxTb()
    End Sub

    Private Sub comboPv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles comboPv.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowComboBoxAp()
            ShowComboBoxTb()
        End If
    End Sub

    Private Sub comboAp_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboAp.SelectionChangeCommitted
        ShowComboBoxTb()
    End Sub

    Private Sub comboAp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles comboAp.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowComboBoxTb()
        End If
    End Sub

    Private Sub txtTsptel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTsptel.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case 47 To 58 ' เลข 0 - 9
                KeyAscii = False
        End Select
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImportance.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        e.Handled = CheckDigitOnly(KeyAscii)
    End Sub
End Class