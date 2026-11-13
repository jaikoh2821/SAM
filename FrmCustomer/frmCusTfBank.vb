Public Class frmCusTfBank
    Dim dtBank1 As New DataTable
    Dim dtBank2 As New DataTable
    Dim dtCus As New DataTable
    Dim CheckIdCB As String = ""
    Dim bm As Bitmap
    Dim dtCheckBkOrCus As New DataTable

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is tabCus Then
            mdLoadShow()
            SetGridStart()
            cntCusNone()
            mdLoadCommitt()
        ElseIf TabControl1.SelectedTab Is tabBank Then
            mdLoadShow()
            ShowBank2()
            mdLoadCommitt()
        End If
    End Sub

#Region "TabControl 1"
    Private Sub SetGridStart()
        txtCus1.Text = ""
        txtCus1.Tag = ""
        dgvbank.Enabled = False
        txtSearch1.Enabled = False
        dgvInsert1.Enabled = False
        For i As Integer = dgvInsert1.Rows.Count - 1 To 0 Step -1
            dgvInsert1.Rows.RemoveAt(i)
        Next
        lbBank1.Text = cntRowsGrid(dgvbank)
        lbBankIdentity.Text = cntRowsGrid(dgvInsert1)

        dtBank1.Clear()
        dgvbank.DataSource = dtBank1
        lbBank1.Text = cntRowsGrid(dgvbank)
        Button1.Focus()
    End Sub

    Private Sub frmCusTfBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetGridStart()
        cntCusNone()
    End Sub

    Private Sub dgvbank_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvbank.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgvbank.RowHeadersWidth < CInt((size.Width + 20)) Then
            dgvbank.RowHeadersWidth = CInt((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub dgvInsert1_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvInsert1.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgvInsert1.RowHeadersWidth < CInt((size.Width + 20)) Then
            dgvInsert1.RowHeadersWidth = CInt((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, sIdComp)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtCus1.Text = frm.CusName
            txtCus1.Tag = frm.idCus
            seTDataCusCB()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLbCus.LinkClicked
        Dim cusNon As New frmCusTfBankNone
        If cusNon.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtCus1.Text = cusNon.CusNames
            txtCus1.Tag = cusNon.idCus
            seTDataCusCB()
        End If
    End Sub

    Private Sub seTDataCusCB()
        
        dtBank1.Clear()
        
        dgvbank.Enabled = True
        txtSearch1.Enabled = True
        dgvInsert1.Enabled = True
        txtSearch1.Focus()
        txtSearch1.SelectAll()
        For i As Integer = dgvInsert1.Rows.Count - 1 To 0 Step -1
            dgvInsert1.Rows.RemoveAt(i)
        Next
        sCommand.CommandText = "SELECT ShortName, BankName, AccountNum, NameShort, AccountName, CompName, idCB, '' As idCus, 0 As cnt FROM vCompbBank WHERE stDel is null And idComp=" & sIdComp & " Order by ShortName"
        sAdapter.Fill(dtBank1)

        Dim dtcnt As New DataTable
        sCommand.CommandText = "SELECT count(CusBk.idCB) As cnt, CusBk.idCB FROM dCusTfBank As CusBk WHERE idCB=(SELECT CompBk.idCB FROM vCompbBank As CompBk WHERE CompBk.idCB=CusBk.idCB And CompBk.idComp=" & sIdComp & ") Group by CusBk.idCB"
        sAdapter.Fill(dtcnt)

        For i As Integer = 0 To dtcnt.Rows.Count - 1
            For Each dr As DataRow In dtBank1.Select("idCB='" & dtcnt.Rows(i).Item("idCB") & "'")
                dr.Item("cnt") = dtcnt.Rows(i).Item("cnt")
            Next
        Next

        dtCheckBkOrCus.Clear()
        sCommand.CommandText = "SELECT idCB FROM dCusTfBank  WHERE idCus =" & txtCus1.Tag
        sAdapter.Fill(dtCheckBkOrCus)

        For i As Integer = 0 To dtCheckBkOrCus.Rows.Count - 1
            For Each dr As DataRow In dtBank1.Select("idCB=" & dtCheckBkOrCus.Rows(i).Item("idCB"))
                dgvInsert1.Rows.Add(bm, dr.Item("ShortName").ToString(), dr.Item("BankName").ToString(), dr.Item("AccountNum").ToString(), dr.Item("NameShort").ToString(), dr.Item("AccountName").ToString(), dr.Item("CompName").ToString(), dr.Item("idCB").ToString(), txtCus1.Tag, dr.Item("cnt").ToString())
                dr.Delete()
            Next
        Next

        dgvbank.DataSource = dtBank1
        lbBank1.Text = cntRowsGrid(dgvbank)
        lbBankIdentity.Text = cntRowsGrid(dgvInsert1)

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbank.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvbank.Columns(e.ColumnIndex).Name = change.Name Then
            dgvInsert1.Rows.Add(bm, dgvbank.Rows(e.RowIndex).Cells("ShortName").Value, dgvbank.Rows(e.RowIndex).Cells("BankName").Value, dgvbank.Rows(e.RowIndex).Cells("AccountNum").Value, dgvbank.Rows(e.RowIndex).Cells("NameShort").Value, dgvbank.Rows(e.RowIndex).Cells("AccountName").Value, dgvbank.Rows(e.RowIndex).Cells("CompName").Value, dgvbank.Rows(e.RowIndex).Cells("idCBT1G1").Value, dgvbank.Rows(e.RowIndex).Cells("idCusT1G1").Value, dgvbank.Rows(e.RowIndex).Cells("cnt").Value)
            dgvbank.Rows.RemoveAt(e.RowIndex)
            lbBank1.Text = cntRowsGrid(dgvbank)
            lbBankIdentity.Text = cntRowsGrid(dgvInsert1)
        End If
    End Sub

    Private Sub dgvInsert1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInsert1.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvInsert1.Columns(e.ColumnIndex).Name = cancle.Name Then
            dtBank1.Rows.Add(dgvInsert1.Rows(e.RowIndex).Cells("ShortName2").Value, dgvInsert1.Rows(e.RowIndex).Cells("BankName2").Value, dgvInsert1.Rows(e.RowIndex).Cells("AccountNum2").Value, dgvInsert1.Rows(e.RowIndex).Cells("NameShort2").Value, dgvInsert1.Rows(e.RowIndex).Cells("AccountName2").Value, dgvInsert1.Rows(e.RowIndex).Cells("CompName2").Value, dgvInsert1.Rows(e.RowIndex).Cells("idCBT1G2").Value, dgvInsert1.Rows(e.RowIndex).Cells("idCusT1G2").Value, dgvInsert1.Rows(e.RowIndex).Cells("cnt2").Value)
            Dim dv As New DataView(dtBank1)
            dv.RowFilter = "AccountName LIKE  '%" & txtSearch1.Text.Trim() & "%'"
            dv.Sort = "ShortName"
            dgvbank.DataSource = dv
            dgvInsert1.Rows.RemoveAt(e.RowIndex)
            lbBank1.Text = cntRowsGrid(dgvbank)
            lbBankIdentity.Text = cntRowsGrid(dgvInsert1)
        End If
    End Sub

    Private Sub txtSearch1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(dtBank1)
            dv.RowFilter = "AccountName LIKE  '%" & txtSearch1.Text.Trim() & "%'"
            dv.Sort = "ShortName"
            dgvbank.DataSource = dv
            If dgvbank.Rows.Count < 1 Then
                MessageBox.Show("ไม่พบที่ค้นหา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            lbBank1.Text = cntRowsGrid(dgvbank)
        End If
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If String.IsNullOrEmpty(txtCus1.Text.Trim()) Then
            MessageBox.Show("กรุณาเลือกลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Button1.Focus()
            Exit Sub
        ElseIf dgvInsert1.Rows.Count = 0 And dtCheckBkOrCus.Rows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกบัญชีธนาคาร", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As New DialogResult()
        result = MessageBox.Show("ต้องการบันทึกข้อมูล ใช่หรือไม่ ?", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = Windows.Forms.DialogResult.Yes Then
            mdCnOpen()
            Dim sqlDel As String = ""
            For j As Integer = 0 To dgvbank.Rows.Count - 1
                If dgvbank.Rows(j).Cells("idCusT1G1").Value.ToString() <> "" Then
                    sqlDel += "DELETE FROM dCusTfBank WHERE idCB='" & dgvbank.Rows(j).Cells("idCBT1G1").Value & "' And idCus='" & dgvbank.Rows(j).Cells("idCusT1G1").Value.ToString() & "'" & Environment.NewLine
                End If
            Next
            If sqlDel <> "" Then
                sCommand.CommandText = sqlDel
                sCommand.ExecuteNonQuery()
            End If

            Dim sqlInsert As String = ""
            For i As Integer = 0 To dgvInsert1.Rows.Count - 1
                If dgvInsert1.Rows(i).Cells("idCusT1G2").Value.ToString() = "" Then
                    sqlInsert += "insert into dCusTfBank (idCus, idCB) values (" & txtCus1.Tag & ", " & dgvInsert1.Rows(i).Cells("idCBT1G2").Value & ")" & Environment.NewLine
                End If
            Next

            If sqlInsert <> "" Then
                sCommand.CommandText = sqlInsert
                sCommand.ExecuteNonQuery()
            End If

            SetGridStart()
            cntCusNone()
            dtBank1.Clear()
            dgvbank.DataSource = dtBank1
            lbBank1.Text = cntRowsGrid(dgvbank)
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

#End Region
#Region "TabControl 2"
    Private Sub dgvbank2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbank2.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvbank2.Columns(e.ColumnIndex).Name = changeBank.Name Then
            mdLoadShow()
            For index As Integer = 0 To dgvbank2.Rows.Count - 1
                dgvbank2.Rows(index).DefaultCellStyle.BackColor = Color.Gainsboro
            Next
            txtShowBk.Text = ""
            txtShowBk.Tag = ""
            txtShowBk.Text = dgvbank2.Rows(e.RowIndex).Cells("AccountNameT2").Value
            txtShowBk.Tag = dgvbank2.Rows(e.RowIndex).Cells("idCBT2").Value
            ShowCus()
            txtSearchCus.Enabled = True
            dgvCus2.Enabled = True
            dgvCusChange.Enabled = True
            txtSearchCus.Focus()

            dgvbank2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.GreenYellow
            
            txtSearchCus.SelectAll()
            mdLoadCommitt()
        End If

    End Sub

    Private Sub dgvCus2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCus2.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvCus2.Columns(e.ColumnIndex).Name = change2.Name Then
            dgvCusChange.Rows.Add(bm, dgvCus2.Rows(e.RowIndex).Cells("CusNameC").Value, dgvCus2.Rows(e.RowIndex).Cells("AddressC").Value, dgvCus2.Rows(e.RowIndex).Cells("idCusC").Value, dgvCus2.Rows(e.RowIndex).Cells("idCBc1").Value)
            dgvCus2.Rows.RemoveAt(e.RowIndex)
            lbCus.Text = cntRowsGrid(dgvCus2)
            lbCusIdentity.Text = cntRowsGrid(dgvCusChange)
        End If
    End Sub

    Private Sub dgvCusChange_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCusChange.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvCusChange.Columns(e.ColumnIndex).Name = cancle2.Name Then
            dtCus.Rows.Add(dgvCusChange.Rows(e.RowIndex).Cells("CusName2").Value, dgvCusChange.Rows(e.RowIndex).Cells("Address2").Value, dgvCusChange.Rows(e.RowIndex).Cells("idCus2").Value, dgvCusChange.Rows(e.RowIndex).Cells("idCBc2").Value)
            Dim dv As New DataView(dtCus)
            dv.RowFilter = "CusName LIKE  '%" & txtSearchCus.Text.Trim() & "%'"
            dv.Sort = "CusName"
            dgvCus2.DataSource = dv
            dgvCusChange.Rows.RemoveAt(e.RowIndex)
            lbCus.Text = cntRowsGrid(dgvCus2)
            lbCusIdentity.Text = cntRowsGrid(dgvCusChange)
        End If
    End Sub

    Private Sub ShowBank2()
        mdCnOpen()
        dtBank2.Clear()
        sCommand.CommandText = "SELECT ShortName, BankName, AccountNum, NameShort, AccountName, CompName, idCB, 0 As cnt FROM vCompbBank WHERE stDel is null And idComp=" & sIdComp & " Order by ShortName"
        sAdapter.Fill(dtBank2)

        Dim dtcnt As New DataTable
        sCommand.CommandText = "SELECT count(CusBk.idCB) As cnt, CusBk.idCB FROM dCusTfBank As CusBk WHERE idCB=(SELECT CompBk.idCB FROM vCompbBank As CompBk WHERE CompBk.idCB=CusBk.idCB And CompBk.idComp=" & sIdComp & ") Group by CusBk.idCB"
        sAdapter.Fill(dtcnt)

        For i As Integer = 0 To dtcnt.Rows.Count - 1
            For Each dr As DataRow In dtBank2.Select("idCB='" & dtcnt.Rows(i).Item("idCB") & "'")
                dr.Item("cnt") = dtcnt.Rows(i).Item("cnt")
            Next
        Next

        dgvbank2.DataSource = dtBank2
        txtShowBk.Text = ""
        txtShowBk.Tag = ""

        txtSearchBank.Focus()
        txtSearchBank.SelectAll()
        txtSearchCus.Enabled = False
        dgvCus2.Enabled = False
        dgvCusChange.Enabled = False
        dtCus.Clear()
        dgvCus2.DataSource = dtCus
        For i As Integer = dgvCusChange.Rows.Count - 1 To 0 Step -1
            dgvCusChange.Rows.RemoveAt(i)
        Next
        lbBank2.Text = cntRowsGrid(dgvbank2)
        lbCus.Text = cntRowsGrid(dgvCus2)
        lbCusIdentity.Text = cntRowsGrid(dgvCusChange)
    End Sub

    Private Sub ShowCus()
        mdCnOpen()
        dtCus.Clear()
        sCommand.CommandText = "SELECT LTRIM(CusName) As CusName, Address, idCus, '' As idCB FROM vCustomer  Order by CusName"
        sAdapter.Fill(dtCus)

        For i As Integer = dgvCusChange.Rows.Count - 1 To 0 Step -1
            dgvCusChange.Rows.RemoveAt(i)
        Next

        txtSearchCus.Enabled = False
        dgvCus2.Enabled = False
        dgvCusChange.Enabled = False
        For i As Integer = dgvCusChange.Rows.Count - 1 To 0 Step -1
            dgvCusChange.Rows.RemoveAt(i)
        Next
        'เช็คที่ถูกเลือกแล้ว

        dtCheckBkOrCus.Clear()
        sCommand.CommandText = "SELECT idCus FROM dCusTfBank  WHERE idCB ='" & txtShowBk.Tag & "' group by idCus"
        sAdapter.Fill(dtCheckBkOrCus)


        For i As Integer = 0 To dtCheckBkOrCus.Rows.Count - 1
            For Each dr As DataRow In dtCus.Select("idCus=" & dtCheckBkOrCus.Rows(i).Item("idCus"))
                dgvCusChange.Rows.Add(bm, dr.Item("CusName").ToString(), dr.Item("Address").ToString(), dr.Item("idCus").ToString(), txtShowBk.Tag)
                dr.Delete()
            Next
        Next

        dgvCus2.DataSource = dtCus
        lbCus.Text = cntRowsGrid(dgvCus2)
        lbCusIdentity.Text = cntRowsGrid(dgvCusChange)
    End Sub

    Private Sub txtSearchBank_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchBank.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(dtBank2)
            dv.RowFilter = "AccountName LIKE  '%" & txtSearchBank.Text.Trim() & "%'"
            dv.Sort = "ShortName"
            dgvbank2.DataSource = dv
            If dgvbank2.Rows.Count < 1 Then
                MessageBox.Show("ไม่พบที่ค้นหา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            lbBank2.Text = cntRowsGrid(dgvbank2)
        End If
    End Sub

    Private Sub txtSearchCus_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchCus.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(dtCus)
            dv.RowFilter = "CusName LIKE  '%" & txtSearchCus.Text.Trim() & "%'"
            dv.Sort = "CusName"
            dgvCus2.DataSource = dv
            If dgvCus2.Rows.Count < 1 Then
                MessageBox.Show("ไม่พบที่ค้นหา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            lbCus.Text = cntRowsGrid(dgvCus2)
        End If
    End Sub

    Private Sub btnSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave2.Click

        If String.IsNullOrEmpty(txtShowBk.Text.Trim()) Then
            MessageBox.Show("กรุณาเลือกบัญชีธนาคาร", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf dgvCusChange.Rows.Count = 0 And dtCheckBkOrCus.Rows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim result As New DialogResult()
        result = MessageBox.Show("ต้องการบันทึกข้อมูล ใช่หรือไม่ ?", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = Windows.Forms.DialogResult.Yes Then
            mdCnOpen()
            Dim sqlDel As String = ""
            For j As Integer = 0 To dgvCus2.Rows.Count - 1
                If dgvCus2.Rows(j).Cells("idCBc1").Value.ToString() <> "" Then
                    sqlDel += "DELETE FROM dCusTfBank WHERE idCus='" & dgvCus2.Rows(j).Cells("idCusC").Value & "' And idCB='" & txtShowBk.Tag & "'" & Environment.NewLine
                End If
            Next
            If sqlDel <> "" Then
                sCommand.CommandText = sqlDel
                sCommand.ExecuteNonQuery()
            End If

            Dim sqlInsert As String = ""
            For i As Integer = 0 To dgvCusChange.Rows.Count - 1
                If dgvCusChange.Rows(i).Cells("idCBc2").Value.ToString() = "" Then
                    sqlInsert += "insert into dCusTfBank (idCus, idCB) values ('" & dgvCusChange.Rows(i).Cells("idCus2").Value & "', '" & txtShowBk.Tag & "')" & Environment.NewLine
                End If
            Next

            If sqlInsert <> "" Then
                sCommand.CommandText = sqlInsert
                sCommand.ExecuteNonQuery()
            End If
            ShowBank2()
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub dgvbank2_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvbank2.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgvbank2.RowHeadersWidth < CInt((size.Width + 20)) Then
            dgvbank2.RowHeadersWidth = CInt((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub dgvCus2_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvCus2.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgvCus2.RowHeadersWidth < CInt((size.Width + 20)) Then
            dgvCus2.RowHeadersWidth = CInt((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub dgvCusChange_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvCusChange.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgvCusChange.RowHeadersWidth < CInt((size.Width + 20)) Then
            dgvCusChange.RowHeadersWidth = CInt((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

#End Region

    Private Function cntRowsGrid(ByVal dgvName As DataGridView) As String
        Dim cnt = "ทั้งหมด " & Format(dgvName.Rows.Count, "#,##0") & " รายการ"
        Return cnt
    End Function

    Private Sub cntCusNone()
        mdCnOpen()
        Dim dtcntvCus As New DataTable
        dtcntvCus.Clear()
        sCommand.CommandText = "SELECT idCus FROM vCustomer"
        sAdapter.Fill(dtcntvCus)

        Dim dtcntidCusBank As New DataTable
        dtcntidCusBank.Clear()
        sCommand.CommandText = "SELECT idCus FROM dCusTfBank GROUP BY idCus"
        sAdapter.Fill(dtcntidCusBank)
        linkLbCus.Text = "*ลูกค้าที่ยังไม่กำหนด    " & Format(dtcntvCus.Rows.Count - dtcntidCusBank.Rows.Count, "#,###")
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim vFrm As New frmReportView
        Dim vRpt As New crpCusTfBank
        mdCnOpen()
        Dim ChkGroup As String = ""
        Dim formatRpt As String = ""
        If rdGrBank.Checked Then
            formatRpt = "จัดกลุ่มตามธนาคาร"
            ChkGroup = "b.BankName"
        Else
            formatRpt = "จัดกลุ่มตามบัญชีธนาคาร"
            ChkGroup = "''"
        End If

        Dim dtCusTfBank As New DataTable
        dtCusTfBank.Clear()
        sCommand.CommandText = "SELECT LTRIM(c.CusName) As CusName, CASE WHEN LTRIM(c.Address) IS NULL OR LTRIM(c.Address) = '' THEN '-' ELSE c.Address END AS Address," & _
            " b.ShortName, " + ChkGroup + " As BankName, b.AccountNum, b.AccountName, b.CompName, b.BankName As BankName2 FROM dCusTfBank As cBk LEFT JOIN vCustomer As c ON cBk.idCus=c.idCus " & _
            " LEFT JOIN  vCompbBank As b ON b.idCB=cBk.idCB ORDER BY b.AccountName"
        sAdapter.Fill(dtCusTfBank)
        If dtCusTfBank.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลการกำหนดธนาคารโอนเงินของลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        vRpt.SetDataSource(dtCusTfBank)

        vRpt.SetParameterValue(vRpt.Parameter_rptFormat.ParameterFieldName, "รูปแบบรายงาน  : " & formatRpt)
        vRpt.SetParameterValue(vRpt.Parameter_title.ParameterFieldName, "รายงานการกำหนดธนาคารโอนเงินของลูกค้า")
        vRpt.SetParameterValue(vRpt.Parameter_cntRow.ParameterFieldName, "รายการทั้งหมด   " & Format(dtCusTfBank.Rows.Count, "#,##0") & "  รายการ")
        vRpt.SetParameterValue(vRpt.Parameter_compname.ParameterFieldName, sCompName)
        vRpt.SetParameterValue(vRpt.Parameter_printname.ParameterFieldName, mdPsPrint())

        vFrm.crView.ReportSource = vRpt

        vFrm.Show()
    End Sub
End Class