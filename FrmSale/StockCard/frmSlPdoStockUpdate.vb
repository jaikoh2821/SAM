Public Class frmSlPdoStockUpdate
    Dim namePs As String
    Dim idps As String = ""
    Dim idpswork As String = ""

    Dim pidUpdate As String

    Private sdt As New DataTable

    Private process As eProcess

    Enum eProcess
        eSelect
        eShow
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Select Case aProcess
            Case eProcess.eSelect
                process = eProcess.eSelect
            Case eProcess.eShow
                process = eProcess.eShow

                btn_PsAction.Enabled = False
                btn_Pscommand.Enabled = False

                btn_operetor.Enabled = False
                btn_note.Enabled = False

                btn_save.Enabled = False
                btn_addPdo.Enabled = False

                _operator.OptionsColumn.AllowEdit = False
                change.OptionsColumn.AllowEdit = False
                note.OptionsColumn.AllowEdit = False
                gvdel.Visible = False

                _operator.AppearanceCell.BackColor = Color.FromArgb(192, 192, 255)
                change.AppearanceCell.BackColor = Color.FromArgb(255, 255, 192)
                note.AppearanceCell.BackColor = Color.FromArgb(192, 255, 255)

                txtnote.Enabled = False
        End Select

        sdt.Columns.Add("idPdOLot", System.Type.GetType("System.Int32"))
        sdt.Columns.Add("lotName", System.Type.GetType("System.String"))
        sdt.Columns.Add("name", System.Type.GetType("System.String"))
        sdt.Columns.Add("amount", System.Type.GetType("System.Double"))
        sdt.Columns.Add("operator", System.Type.GetType("System.String"))
        sdt.Columns.Add("change", System.Type.GetType("System.Double"))
        sdt.Columns.Add("amountN", System.Type.GetType("System.Double"))
        sdt.Columns.Add("unit", System.Type.GetType("System.String"))
        sdt.Columns.Add("note", System.Type.GetType("System.String"))

        Dim primaryKey(1) As DataColumn
        primaryKey(0) = sdt.Columns("idPdOLot")
        sdt.PrimaryKey = primaryKey

        gc.DataSource = sdt
    End Sub


    Private Sub btn_Pscommand_Click(sender As Object, e As EventArgs) Handles btn_Pscommand.Click
        Dim frm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            namePs = frm.mName
            idps = frm.mId
            txtPsCommand.Text = namePs
        End If
    End Sub

    Private Sub btn_PsAction_Click(sender As Object, e As EventArgs) Handles btn_PsAction.Click
        Dim frm As New frmPersonSelect(frmPersonSelect.eProcess.eSelect)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            namePs = frm.mName
            idpswork = frm.mId
            txtPsAction.Text = namePs
        End If
    End Sub

    Private Sub frmSlPdoStockUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If process = eProcess.eShow Then
            If gv.RowCount = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", sSystemName)
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_operetor.Click
        Dim f2 As New Form
        Dim ComboBox1 As New ComboBox
        Dim LabelUserName As New Label
        Dim ButtonOK As New Button
        Dim ButtonCancel As New Button

        With f2
            .MinimizeBox = False
            .MaximizeBox = False
            .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            .AutoSize = True
        End With
        With LabelUserName
            .Parent = f2
            .Left = 5
            .Top = 5
            .Width = 200
            .Height = 13
            .Text = "*เลือกตัวดำเนินการ:"
        End With
        With ComboBox1
            .Parent = f2
            .Items.Add("+")
            .Items.Add("-")
            .Items.Add("=")
            .Left = 5
            .Top = 18
            .Width = 156
            .Height = 20
        End With
        With ButtonOK
            .Parent = f2
            .Left = 14
            .Top = 68
            .Width = 75
            .Height = 23
            .Text = "OK"
            .DialogResult = DialogResult.OK
        End With
        With ButtonCancel
            .Parent = f2
            .Left = 95
            .Top = 68
            .Width = 75
            .Height = 23
            .Text = "Cancel"
            .DialogResult = DialogResult.Cancel
        End With

        Dim rowCount As Integer = gv.RowCount

        If rowCount > 0 Then
            f2.StartPosition = FormStartPosition.CenterScreen
            f2.ShowDialog()
            If f2.DialogResult = Windows.Forms.DialogResult.OK Then
                Dim op_str As String = ComboBox1.SelectedItem

                Select Case op_str
                    Case "+"
                        For i As Integer = 0 To rowCount - 1
                            Dim dr As DataRow = gv.GetDataRow(gv.GetRowHandle(i))
                            dr.Item("operator") = op_str
                            dr.Item("amountN") = dr.Item("amount") + dr.Item("change")
                        Next
                    Case "-"
                        For i As Integer = 0 To rowCount - 1
                            Dim dr As DataRow = gv.GetDataRow(gv.GetRowHandle(i))
                            If dr.Item("change") <= dr.Item("amount") Then
                                dr.Item("operator") = op_str
                                dr.Item("amountN") = dr.Item("amount") - dr.Item("change")
                            End If
                        Next
                    Case "="
                        For i As Integer = 0 To gv.RowCount - 1
                            Dim dr As DataRow = gv.GetDataRow(gv.GetRowHandle(i))
                            dr.Item("operator") = op_str
                            dr.Item("amountN") = dr.Item("change")
                        Next
                End Select
            End If
        Else
            MessageBox.Show("กรุณาเลือกสินค้าก่อนทำการแก้ไขตัวดำเนินการ", sSystemName)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_note.Click
        Dim str As String
        If gv.RowCount > 1 Then
            str = InputBox("กรอกหมายเหตุ", sSystemName)
            If str <> "" Then
                For i As Integer = 0 To gv.RowCount - 1
                    gv.GetDataRow(gv.GetRowHandle(i)).Item("note") = str
                Next
            End If
        Else
            MessageBox.Show("กรุณาเลือกสินค้าก่อนใส่เหตุผล", sSystemName)
        End If
    End Sub

    'Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
    '    Dim flag As Integer = 0

    '    If idps = "" Then
    '        MessageBox.Show("กรุณาเลือกพนักงานผู้ออกคำสั่ง", sSystemName)
    '    Else
    '        If idpswork = "" Then
    '            MessageBox.Show("กรุณาเลือกพนักงานผู้ปฏิบัติงาน", sSystemName)
    '        Else
    '            If txtnote.Text = "" Then
    '                MessageBox.Show("กรุณากรอกหมายเหตุการปฏิบัติงาน", sSystemName)
    '            Else
    '                Dim error_str As String = "ไม่สามารถบันทึกได้"

    '                setFormatCondition()

    '                If gv.RowCount = 0 Then
    '                    error_str = "ไม่สามารถบันทึกได้ ไม่มีรายการปรับปรุง"
    '                    flag = 1
    '                Else
    '                    For i As Integer = 0 To gv.RowCount - 1
    '                        Dim dr As DataRow = gv.GetDataRow(gv.GetRowHandle(i))

    '                        If dr.Item("operator") = "" Then
    '                            flag = 1
    '                            error_str = "ไม่สามารถบันทึกได้ กรอกข้อมูลไม่สมบูรณ์"
    '                        ElseIf dr.Item("note") = "" Then
    '                            flag = 1
    '                            error_str = "ไม่สามารถบันทึกได้ กรอกข้อมูลไม่สมบูรณ์"
    '                        ElseIf dr.Item("amountN") < 0 Then
    '                            flag = 1
    '                            error_str = "ไม่สามารถบันทึกได้ ตัวเลขยอดคงเหลือติดลบ"
    '                        End If
    '                    Next
    '                End If

    '                If flag = 1 Then
    '                    MessageBox.Show(error_str, sSystemName)
    '                Else
    '                    mdCnOpen()
    '                    mdLoadShow()

    '                    sCommand.CommandText = "INSERT INTO SmPdOtherUpdateMt (DateTs, idPsTs, idPsCommand,idPsAction,Note) " & _
    '                                            "VALUES ('" & ksbDateToString(Date.Now.Date) & "'," & _
    '                                            sPsId & " ," & _
    '                                            idps & " ," & _
    '                                            idpswork & ",'" & _
    '                                            txtnote.Text & "')"
    '                    Dim idUpdate As Integer = mdCnOpenQueryIdentity(sCommand.CommandText)
    '                    'selectmax
    '                    For i As Integer = 0 To gv.RowCount - 1
    '                        Dim dr As DataRow = gv.GetDataRow(gv.GetRowHandle(i))

    '                        sCommand.CommandText = "INSERT INTO SmPdOtherUpdateDt (idUpdate, idPdo, AmountBefore, Operate, AmountOperate, AmountAfter, Note) " & _
    '                                                "VALUES ('" & idUpdate & "'," & _
    '                                                dr.Item("idPdOLot") & "," & _
    '                                                dr.Item("amount") & " , '" & _
    '                                                dr.Item("operator") & "'," & _
    '                                                dr.Item("change") & "," & _
    '                                                dr.Item("amountN") & ", '" & _
    '                                                dr.Item("note") & "')"
    '                        Dim ID As Integer = mdCnOpenQueryIdentity(sCommand.CommandText)

    '                        Dim pidPdo As Integer = CType(dr.Item("idPdOLot"), Integer)
    '                        Dim temp2 As Integer = CType(dr.Item("change"), Integer)

    '                        Select Case dr.Item("operator")
    '                            Case "+"
    '                                mdPdoLotStockUpdate(1, pidPdo, temp2, "WIM-3", ID)
    '                            Case "-"
    '                                mdPdoLotStockUpdate(2, pidPdo, temp2, "WIM-3", ID)
    '                            Case "="
    '                                mdPdoLotStockUpdate(3, pidPdo, temp2, "WIM-3", ID)
    '                        End Select
    '                    Next
    '                    mdLoadCommitt()
    '                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", sSystemName)
    '                    Me.Close()
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub addPdo_Click(sender As Object, e As EventArgs) Handles btn_addPdo.Click
    '    Dim vFrm As New frmPdOtherSelect(frmPdOtherSelect.eProcess.eSelectLot)

    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Dim idPdLot As Integer = vFrm.idPdO
    '        Dim pdoName As String = vFrm.PdoName
    '        Dim amount As Double = vFrm.pAmount
    '        Dim lotNum As String = vFrm.pdoLotName
    '        Dim unit As String = vFrm.pdoUnitName

    '        If IsNothing(sdt.Rows.Find(idPdLot)) Then
    '            sdt.Rows.Add(idPdLot,
    '                         lotNum,
    '                         pdoName,
    '                         amount,
    '                         "",
    '                         0,
    '                         amount,
    '                         unit,
    '                         "")

    '            gc.DataSource = sdt
    '        Else
    '            MessageBox.Show("สินค้าซ้ำกรุณาเลือกสินค้าชนิดอื่น", sSystemName)
    '        End If
    '    End If
    'End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If MessageBox.Show("ยืนยันการลบ", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dr As DataRow = gv.GetDataRow(gv.FocusedRowHandle)
            dr.Delete()
            sdt.AcceptChanges()
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged
        If e.Column.Name <> _operator.Name And e.Column.Name <> change.Name Then
            Exit Sub
        End If

        Dim dr As DataRow = gv.GetDataRow(gv.FocusedRowHandle)

        If dr.Item("operator") = "" Or Not IsNumeric(dr.Item("change")) Then
            Exit Sub
        End If

        Select Case dr.Item("operator")
            Case "+"
                dr.Item("amountN") = dr.Item("amount") + dr.Item("change")
            Case "-"
                If dr.Item("change") > dr.Item("amount") Then
                    dr.Item("change") = 0
                    dr.Item("amountN") = dr.Item("amount")
                    MessageBox.Show("ข้อมูลผิดพลาดจำนวนสินค้าไม่สามารถมีน้อยกว่า 0 ชิ้นได้", sSystemName)
                Else
                    dr.Item("amountN") = dr.Item("amount") - dr.Item("change")
                End If
            Case "="
                dr.Item("amountN") = dr.Item("change")
        End Select
    End Sub

    Public Sub getShowData(ByVal idUpdate As String)
        If idUpdate <> "" Then
            Dim sdata, sdata2 As New DataTable
            sCommand.CommandText = "select ps1.PsName AS psCmd, ps2.PsName AS psAct , mt.Note " & _
                                    "from SmPdOtherUpdateMt As mt " & _
                                    "LEFT JOIN vPerson AS ps1 ON mt.idPsCommand = ps1.idPs " & _
                                    "LEFT JOIN vPerson AS ps2 ON mt.idPsAction = ps2.idPs " & _
                                    "WHERE idUpdate = " & idUpdate
            sAdapter.Fill(sdata)

            If sdata.Rows.Count > 0 Then
                txtPsCommand.Text = sdata.Rows(0).Item("psCmd")
                txtPsAction.Text = sdata.Rows(0).Item("psAct")
                txtnote.Text = sdata.Rows(0).Item("Note")

                sCommand.CommandText = "SELECT lot.idPdOLot, lot.LotNum, lot.Title, lot.UnitName, " & _
                                        "dt.AmountBefore, dt.Operate, dt.AmountOperate, dt.AmountAfter, dt.Note " & _
                                        "FROM SmPdOtherUpdateDt AS dt " & _
                                        "LEFT JOIN vSmPdOtherDLot AS lot ON lot.idPdOLot = dt.idPdo " & _
                                        "WHERE (lot.stDel  = 0 OR lot.stDel IS NULL) AND lot.CompRec = " & sIdComp & " " & _
                                        "AND dt.idUpdate = " & idUpdate & " " & _
                                        "Order by lot.Title"

                sAdapter.Fill(sdata2)

                For i As Integer = 0 To sdata2.Rows.Count - 1
                    Dim dr As DataRow = sdata2.Rows(i)

                    sdt.Rows.Add(dr.Item("idPdOLot"),
                                 dr.Item("LotNum"),
                                 dr.Item("Title"),
                                 dr.Item("AmountBefore"),
                                 dr.Item("Operate"),
                                 dr.Item("AmountOperate"),
                                 dr.Item("AmountAfter"),
                                 dr.Item("UnitName"),
                                 dr.Item("Note"))
                Next

                gc.DataSource = sdt
            End If
        End If
    End Sub

    Private Sub setFormatCondition()
        gv.FormatConditions.Item(0).Appearance.BackColor = Color.FromArgb(192, 255, 192)
        gv.FormatConditions.Item(1).Appearance.Options.UseBackColor = True
    End Sub

    Private Sub resetFormatCondition()
        gv.FormatConditions.Item(0).Appearance.BackColor = Color.FromArgb(192, 255, 255)
        gv.FormatConditions.Item(1).Appearance.Options.UseBackColor = False
    End Sub
End Class