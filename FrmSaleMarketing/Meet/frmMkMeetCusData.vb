Public Class frmMkMeetCusData
    Dim eEvent As eProcess
    Dim sDt As New DataTable

    Enum eProcess
        eAddOrEdit
        eShowData
        eCancle
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eAddOrEdit
                Me.dgvData1.Columns(Me.cancle.Name).Visible = False
                Text = "ทำรายการบันทึกการเข้าพบคู่ค้า"
            Case eProcess.eShowData
                Me.dgvData1.Columns(Me.edit.Name).Visible = False
                Me.dgvData1.Columns(Me.cancle.Name).Visible = False
                btn_add.Visible = False
                Text = "ข้อมูลการเข้าพบคู่ค้า"
            Case eProcess.eCancle
                Me.btn_add.Visible = False
                Me.dgvData1.Columns(Me.edit.Name).Visible = False
                Text = "ยกเลิกรายการเข้าพบคู่ค้า"
        End Select
        eEvent = aProcess
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showDataOnGrid()
    End Sub

    Private Sub dgvExpense_RowPostPaint1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData1.RowPostPaint
        Me.dgvData1("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vFrm As New frmMkMeetCusTs()
        vFrm.ShowDialog()
        If vFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            showDataOnGrid()
        End If
    End Sub

    Private Sub dgvData1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData1.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Dim vFrm As New frmMkMeetCusTs()
        If dgvData1.Columns(e.ColumnIndex).Name = edit.Name Then
            'MessageBox.Show(dgvData1.Rows(e.RowIndex).Cells(idTs.Name).Value)
            vFrm.getIdMeet(dgvData1.Rows(e.RowIndex).Cells(idTs.Name).Value)
            vFrm.ShowDialog()
        End If
        If vFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            showDataOnGrid()
        End If
        If dgvData1.Columns(e.ColumnIndex).Name = cancle.Name Then
            Dim CurRow As Integer
            CurRow = Me.dgvData1.CurrentRow.Index
            Dim Result As MsgBoxResult
            Result = MessageBox.Show("คุณต้องการยกเลิกใช่หรือไม่ ? ", "ยืนยัน", MessageBoxButtons.YesNo, _
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If Result = MsgBoxResult.Yes Then
                sCommand.CommandText = "DELETE FROM SmMkMeet WHERE (idTs = '" & dgvData1.Rows(e.RowIndex).Cells(idTs.Name).Value & "')"
                sCommand.ExecuteNonQuery()
                Me.dgvData1.Rows.RemoveAt(CurRow)
            End If
        End If
    End Sub

    Sub SumTotal()
        Me.Label3.Text = "รายการทั้งหมด  " & Format(dgvData1.Rows.Count, "#,##0") & "  รายการ"
    End Sub
   
    Private Sub showDataOnGrid(Optional ByVal UseInButtonShow As Boolean = False)
        mdCnOpen()
        sDt.Clear()
        Dim sWhere As String = ""
        If Rd_InThai.Checked = True Then 'คนในประเทศ
            sWhere = " And sM.stAddress = '1'"
        ElseIf Rd_Abroad.Checked = True Then
            sWhere = " And sM.stAddress = '0'" 'คนต่างประเทศ
        Else 'ทั้งหมด
            sWhere = ""
        End If
        If CbSTitle.Checked Then 'ค้นหาหัวข้อการเข้าพบคู่ค้า
            sWhere &= " AND sM.idMeet ='" & txtTitleCus.Tag & "'"
        End If
        If CbSEmp.Checked Then 'ค้นหาพนักงาน
            sWhere &= " AND sM.idPs ='" & txtEmp.Tag & "'"
        End If
        If CbSCus.Checked Then 'ค้นหาลูกค้า
            sWhere &= " AND sM.idCus ='" & txtCus.Tag & "'"
        End If

        Dim SQL As String = ""
        SQL = "SELECT sM.MeetDetail, sM.DateMeet, sMD.MeetName, C.CusName_, P.PsName, sM.idTs, "
        SQL &= " CASE WHEN sM.stAddress = 1 THEN 'คู่ค้าในประเทศ' ELSE 'คู่ค้าต่างประเทศ' END AS Country FROM dbo.SmMkMeet AS sM INNER JOIN dbo.SmMkMeetData AS sMD "
        SQL &= " ON sM.idMeet = sMD.idMeet INNER JOIN dbo.vCustomer AS C ON sM.idCus = C.idCus INNER JOIN dbo.vPerson AS P ON sM.idPs = P.idPs  "
        
        If RdSMonth.Checked = True Then 'ค้นหา ประจำเดือน               
            SQL &= " WHERE sM.DateMeet LIKE '%" & Microsoft.VisualBasic.Left(ksbDateToString(DayOfMonth.Value.ToShortDateString), 6) & "%' " & sWhere & " ORDER BY sM.DateMeet DESC"
        Else 'ค้นหา ระหว่างวันที่
            SQL &= " WHERE sM.DateMeet BETWEEN '" & ksbDateToString(DateTime_Ts1.Value.ToShortDateString) & "' AND '" & ksbDateToString(DateTime_Ts2.Value.ToShortDateString) & "' " & sWhere & " ORDER BY sM.DateMeet DESC"
        End If

        sCommand.CommandText = SQL
        sAdapter.Fill(sDt)

        For i As Integer = 0 To Me.dgvData1.Rows.Count - 1
            Me.dgvData1.Rows(i).Cells("DateMeet").Value = ksbStringToDate(Me.dgvData1.Rows(i).Cells("DateMeet").Value)
        Next
       
        If UseInButtonShow = True And sDt.Rows.Count = 0 Then
            MsgBox("ไม่พบที่ค้นหา", MsgBoxStyle.Information, "SAM")
            Exit Sub
        End If
        dgvData1.DataSource = sDt
        SumTotal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTitle.Click
        Dim vFrm As New frmMkMeetCus(frmMkMeetCus.eProcess.eChange)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtTitleCus.Tag = vFrm.sIdMeet
            txtTitleCus.Text = vFrm.sMeetName
        End If
    End Sub

    Private Sub BtCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCus.Click
        If Rd_InThai.Checked = True Then
            Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eInThaiAndSale, sIdComp)
            vFrm.idPs = txtEmp.Tag
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCus.Tag = vFrm.idCus
                txtCus.Text = vFrm.CusName
            End If
        ElseIf Rd_Abroad.Checked = True Then
            Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eFrgAndSale, sIdComp)
            vFrm.idPs = txtEmp.Tag

            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCus.Tag = vFrm.idCus
                txtCus.Text = vFrm.CusName
            End If
        Else
            Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSaleAll, sIdComp)
            vFrm.idPs = txtEmp.Tag
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCus.Tag = vFrm.idCus
                txtCus.Text = vFrm.CusName
            End If
        End If
    End Sub

    Private Sub BtEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEmp.Click
        Dim vFrm As New frmSsQcPersonSelect(frmSsQcPersonSelect.eProcess.eRdSale)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtEmp.Tag = vFrm.id
            txtEmp.Text = vFrm.PsName
            'MessageBox.Show(txtEmp.Tag)
        End If
    End Sub

    Private Sub CbSTitle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSTitle.CheckedChanged
        If CbSTitle.Checked = True Then
            BtTitle.Enabled = True
        Else
            BtTitle.Enabled = False
        End If
    End Sub

    Private Sub CbSEmp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSEmp.CheckedChanged
        If CbSEmp.Checked = True Then
            BtEmp.Enabled = True
        Else
            BtEmp.Enabled = False
        End If
    End Sub

    Private Sub CbSCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSCus.CheckedChanged
        If CbSCus.Checked = True Then
            BtCus.Enabled = True
        Else
            BtCus.Enabled = False
        End If
    End Sub

    Private Sub RdSMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdSMonth.CheckedChanged
        If RdSMonth.Checked = True Then
            DayOfMonth.Enabled = True
        Else
            DayOfMonth.Enabled = False
        End If
    End Sub

    Private Sub RdSDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdSDay.CheckedChanged
        If RdSDay.Checked = True Then
            DateTime_Ts1.Enabled = True
            DateTime_Ts2.Enabled = True
        Else
            DateTime_Ts1.Enabled = False
            DateTime_Ts2.Enabled = False
        End If
    End Sub

    Private Sub btn_add_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim vFrm As New frmMkMeetCusTs()
        vFrm.ShowDialog()
        If vFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            showDataOnGrid()
        End If
    End Sub

    Private Sub btn_show_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        showDataOnGrid(True)
    End Sub
End Class