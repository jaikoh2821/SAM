Public Class frmSlOrderToSaleSelect
    Dim stpage As Integer = 0
    Dim eEvent As eProcess
    Public idCus As String
    Public CusName As String
    Public stAddress As Integer
    Public idComp As Integer
    Public idSaleOrder As Integer = 0
    Dim NumOfNoPass As Integer = 0

    Enum eProcess
        eDateTs
        eDateReq
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eDateTs
                stPage = 1
            Case eProcess.eDateReq
                stPage = 2
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmSlOrderToSaleSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        If stpage = 1 Then 'DateTs
            Me.Text = "เลือกรายการสั่งซื้อจากลำดับทำรายการสั่งซื้อ"
            'dgvOrder.Columns(ColDateReq.Name).Visible = False
            dgvOrder.Columns(ColDay.Name).HeaderText = "จำนวนวันที่สั่งซื้อ"
        ElseIf stpage = 2 Then
            Me.Text = "เลือกรายการสั่งซื้อจากวันที่ต้องการสินค้า"
            'dgvOrder.Columns(ColDateReq.Name).Visible = True
            'dgvOrder.Columns(ColDateTs.Name).Visible = False
            'dgvOrder.Columns(ColTime.Name).Visible = False
            dgvOrder.Columns(ColDay.Name).HeaderText = "จำนวนวันที่ต้องการ"
        End If

        BindData()
        mdLoadCommitt()
    End Sub


    Private Sub frmSlOrderToSaleSelect_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtCusName.Focus()
    End Sub

    Sub BindData()
        mdCnOpen()
        Dim sDt As New DataTable
        sDt.Clear()
        Dim OrderBy As String = ""
        If stpage = 1 Then 'DateTs
            OrderBy = " DateTs, mt.TimeTs"
        ElseIf stpage = 2 Then
            OrderBy = " DateRequire"
        End If


        'sCommand.CommandText = "SELECT distinct mt.idSaleOrder, mt.DocCode, v.CusName_, mt.idCus, " & _
        '                       "DATEADD(Year, - 543, CONVERT(DateTime, mt.DateTs, 103)) As DateTs, " & _
        '                       "mt.TimeTs, DATEADD(Year, - 543, CONVERT(DateTime, mt.DateRequire, 103)) " & _
        '                       "As DateRequire, 0 As CountDay, p1.PsName As PsSale, P2.PsName As PsOrder, " & _
        '                       "mt.stSysOrder, mt.Note, v.stAddress, v.idComp, mt.idPsAccept, " & _
        '                       "mt.idPsCheck, mt.idPsApp, mt.stApp " & _
        '                       "FROM SmSaleOrderMt mt INNER JOIN vCustomer AS v ON mt.idCus = v.idCus " & _
        '                        "LEFT OUTER JOIN SmSaleOrderDt dt ON mt.idSaleOrder = dt.idSaleOrder " & _
        '                        "LEFT OUTER JOIN vPerson p1 ON mt.idPsSale = p1.idPs " & _
        '                        "LEFT OUTER JOIN vPerson p2 ON mt.idPsOrder = p2.idPs " & _
        '                       "WHERE mt.idPsCancel IS NULL AND mt.idComp = '" & sIdComp & "' " & _
        '                        "AND dt.stAllSale IS NULL AND mt.DateOrder > '25570701' " & _
        '                        "AND CusName_ Like '%" & txtCusName.Text & "%' ORDER BY " & OrderBy

        sCommand.CommandText = "SELECT distinct mt.idSaleOrder, mt.DocCode, v.CusName_, mt.idCus, " & _
                               "DateTs, mt.TimeTs, DateRequire, 0 As CountDay, p1.PsName As PsSale, P2.PsName As PsOrder, " & _
                               "mt.stSysOrder, mt.Note, v.stAddress, v.idComp, mt.idPsAccept, " & _
                               "mt.idPsCheck, mt.idPsApp, mt.stApp " & _
                               "FROM SmSaleOrderMt mt INNER JOIN vCustomer AS v ON mt.idCus = v.idCus " & _
                                "LEFT OUTER JOIN SmSaleOrderDt dt ON mt.idSaleOrder = dt.idSaleOrder " & _
                                "LEFT OUTER JOIN vPerson p1 ON mt.idPsSale = p1.idPs " & _
                                "LEFT OUTER JOIN vPerson p2 ON mt.idPsOrder = p2.idPs " & _
                               "WHERE mt.idPsCancel IS NULL AND mt.idComp = '" & sIdComp & "' " & _
                                "AND dt.stAllSale IS NULL AND mt.DateOrder > '25570701' " & _
                                "AND CusName_ Like '%" & txtCusName.Text & "%' ORDER BY " & OrderBy

        sAdapter.Fill(sDt)


        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            NumOfNoPass = 0
            MessageBox.Show("ไม่พบข้อมูลรายการสั่งซื้อ", sSystemName)
            dgvOrder.DataSource = sDt
            SumTotal()
            Exit Sub
        Else
            For i As Integer = 0 To sDt.Rows.Count - 1
                sDt.Rows(i).Item("DateTs") = ksbStringToDate(sDt.Rows(i).Item("DateTs"))
                sDt.Rows(i).Item("DateRequire") = ksbStringToDate(sDt.Rows(i).Item("DateRequire"))
                'If stpage = 1 Then 'DateTs
                '    sDt.Rows(i).Item("CountDay") = DateDiff(DateInterval.Day, sDt.Rows(i).Item("DateTs"), Date.Today)
                'ElseIf stpage = 2 Then
                '    sDt.Rows(i).Item("CountDay") = DateDiff(DateInterval.Day, sDt.Rows(i).Item("DateRequire"), Date.Today)
                'End If


                If IsDBNull(sDt.Rows(i).Item("stSysOrder")) Then
                    sDt.Rows(i).Item("stSysOrder") = "PC"
                ElseIf sDt.Rows(i).Item("stSysOrder") = 1 Then
                    sDt.Rows(i).Item("stSysOrder") = "Mobile"
                ElseIf sDt.Rows(i).Item("stSysOrder") = 2 Then
                    sDt.Rows(i).Item("stSysOrder") = "Web Browser"
                End If
            Next
            dgvOrder.DataSource = sDt

            NumOfNoPass = 0
            For i As Integer = 0 To dgvOrder.Rows.Count - 1
                If IsDBNull(dgvOrder.Rows(i).Cells("ColidPsAccept").Value) Or _
                IsDBNull(dgvOrder.Rows(i).Cells("ColidPsCheck").Value) Or _
                IsDBNull(dgvOrder.Rows(i).Cells("ColidPsApp").Value) Or _
                IsDBNull(dgvOrder.Rows(i).Cells("ColstApp").Value) Then
                    '---ยังผ่านกระบวนการไม่ครบ----'
                    dgvOrder.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
                    dgvOrder.Rows(i).Cells("colSelect").Style.BackColor = Color.White
                    dgvOrder.Rows(i).Cells("colSelect").ReadOnly = True
                    NumOfNoPass = NumOfNoPass + 1
                Else
                    '----ผ่านกระบวนการครบ แต่สถานะไม่อนุมัติ----'
                    If dgvOrder.Rows(i).Cells("ColstApp").Value = 0 Then
                        dgvOrder.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
                        dgvOrder.Rows(i).Cells("colSelect").Style.BackColor = Color.White
                        dgvOrder.Rows(i).Cells("colSelect").ReadOnly = True
                        NumOfNoPass = NumOfNoPass + 1
                    End If
                End If
            Next
            SumTotal()
        End If

    End Sub

    Private Sub txtCusName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusName.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If
    End Sub


    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Sub SumTotal()
        Me.txtCount.Text = Format(dgvOrder.Rows.Count, "#,##0")
        Me.txtNoPass.Text = Format(NumOfNoPass, "#,##0")
        Me.txtPass.Text = Format(CInt(Me.txtCount.Text) - NumOfNoPass, "#,##0")

    End Sub

    Private Sub dgvOrder_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrder.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        'If dgvOrder.Columns(e.ColumnIndex).Name = colSelect.Name Then
        '    If IsDBNull(dgvOrder.CurrentRow.Cells("ColidPsAccept").Value) Or _
        '    IsDBNull(dgvOrder.CurrentRow.Cells("ColidPsCheck").Value) Or _
        '    IsDBNull(dgvOrder.CurrentRow.Cells("ColidPsApp").Value) Or _
        '    IsDBNull(dgvOrder.CurrentRow.Cells("ColstApp").Value) Then
        '        MessageBox.Show("รายการสั่งซื้อนี้ยังไม่ผ่านกระบวนการรับทราบ ตรวจสอบ และอนุมัติ " & vbCrLf & "จึงไม่สามารถเลือกไปเปิดบิลขายสินค้าได้", sSystemName)
        '    Else
        '        '----ผ่านกระบวนการครบ แต่สถานะไม่อนุมัติ----'
        '        If dgvOrder.CurrentRow.Cells("ColstApp").Value = 0 Then
        '            MessageBox.Show("รายการสั่งซื้อนี้ยังไม่ผ่านกระบวนการรับทราบ ตรวจสอบ และอนุมัติ " & vbCrLf & "จึงไม่สามารถเลือกไปเปิดบิลขายสินค้าได้", sSystemName)
        '        End If
        '    End If
        'End If

    End Sub

    Private Sub dgvOrder_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrder.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvOrder.Columns(e.ColumnIndex).Name = colSelect.Name Then
            'If Not IsDBNull(dgvOrder.Rows(e.RowIndex).Cells("ColidPsAccept").Value) And _
            'Not IsDBNull(dgvOrder.Rows(e.RowIndex).Cells("ColidPsCheck").Value) And _
            'Not IsDBNull(dgvOrder.Rows(e.RowIndex).Cells("ColidPsApp").Value) And _
            'Not IsDBNull(dgvOrder.Rows(e.RowIndex).Cells("ColstApp").Value) Then
            '    If dgvOrder.Rows(e.RowIndex).Cells("ColstApp").Value = 1 Then
            idCus = CInt(dgvOrder.Rows(e.RowIndex).Cells(ColidCus.Name).Value)
            CusName = CStr(dgvOrder.Rows(e.RowIndex).Cells(colCusName.Name).Value)

            If IsDBNull(dgvOrder.Rows(e.RowIndex).Cells(ColidComp.Name).Value) Then
                idComp = 0
            Else
                idComp = CInt(dgvOrder.Rows(e.RowIndex).Cells(ColidComp.Name).Value)
            End If

            If IsDBNull(dgvOrder.Rows(e.RowIndex).Cells(ColstAddress.Name).Value) Then
                stAddress = 0
            Else
                stAddress = CInt(dgvOrder.Rows(e.RowIndex).Cells(ColstAddress.Name).Value)
            End If

            idSaleOrder = CInt(dgvOrder.Rows(e.RowIndex).Cells(ColidSaleOrder.Name).Value)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            'End If
            '    End If

        End If

        If dgvOrder.Columns(e.ColumnIndex).Name = ColDetail.Name Then
            Dim vFrm As New frmSlOrderTs(frmSlOrderTs.eProcess.eShow, dgvOrder.Rows(e.RowIndex).Cells("colidSaleOrder").Value)
            vFrm.ShowDialog()

        End If
    End Sub
End Class