Public Class frmPdMixStockCard
    Dim idPdLot_ As Integer = 0
    Dim stLot As Integer = 0
    Private samNoteMapText As New Dictionary(Of String, String)
    Private wimNoteMapText As New Dictionary(Of String, String)

    Private Sub frmPdMixStockCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'BindPlant()
        samNoteMapText.Add("SAM-1", "ขายสินค้า")
        samNoteMapText.Add("SAM-2", "ยกเลิกรายการ")
        samNoteMapText.Add("SAM-3", "แก้ไขรายการขายสินค้า")
        samNoteMapText.Add("SAM-4", "ไม่อนุมัติขายสินค้า")
        samNoteMapText.Add("SAM-5", "คืนสินค้า")
        samNoteMapText.Add("SAM-6", "แก้ไขคืนสินค้า")
        samNoteMapText.Add("SAM-7", "ยกเลิกการคืนสินค้า")
        samNoteMapText.Add("SAM-8", "ไม่อนุมัติการคืนสินค้า")
        samNoteMapText.Add("SAM-9", "Reject รายการคืนสินค้า")
        samNoteMapText.Add("SAM-10", "ยกเลิกสถานะ รับทราบ/ตรวจสอบ/อนุมัติ รายการขายสินค้า")
        samNoteMapText.Add("SAM-11", "โอนย้ายสินค้าระหว่างบริษัท")
        wimNoteMapText.Add("WIM-1", "ย้ายคลังสินค้า")
        wimNoteMapText.Add("WIM-2", "เพิ่มสินค้าเข้าคลัง")
        wimNoteMapText.Add("WIM-3", "ปรับปรุงสต๊อกสินค้าวัตถุดิบ")
        wimNoteMapText.Add("WIM-4", "รายการเบิกวัตถุดิบ")
        wimNoteMapText.Add("WIM-5", "แก้ไขรายการสินค้าวัตถุดิบ")
        wimNoteMapText.Add("WIM-6", "ยกเลิกรายการเบิกวัตกุดิบ")
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        BindData()
    End Sub

    Sub BindData()
        mdCnOpen()
        mdLoadShow()
        Dim vWhere As String = ""
        Dim ds As New DataSet

        If Me.ChkDateStock.Checked = True Then
            vWhere = vWhere & " AND sc.DateTs Between '" & ksbDateToString(dtpStockS.Value.ToShortDateString) & "' " & _
                              "And '" & ksbDateToString(dtpStockE.Value.ToShortDateString) & "' "
        End If


        Dim sDt As New DataTable
        sCommand.CommandText = "Select sc.idTs, sc.idLot, l.LotNum, sc.DateTs, p.pdName, p.SeedTypeName, sc.AmountAdd, " & _
                               "sc.AmountCut, sc.Balance, sc.Note, Ps.PsName As PsTs, sc.idRef From PdMixStockCard sc " & _
                               "LEFT OUTER JOIN PkPdLotStock l ON sc.idLot = l.idPdLot " & _
                               "LEFT OUTER JOIN vSeedProduct p ON l.idPd = p.idPd " & _
                               "LEFT OUTER JOIN vPerson Ps ON sc.idPsTs = Ps.idPs " & _
                               "Where idLot = '" & idPdLot_ & "' " & vWhere & " Order by sc.DateTs"
        sAdapter.Fill(sDt)
        sDt.Columns.Add("ColNum", System.Type.GetType("System.String"))
        sDt.Columns.Add("NoteText", System.Type.GetType("System.String"))

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสต็อกการ์ด สินค้าวัตถุดิบ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            GridControl2.DataSource = sDt
            SumTotal(sDt.Rows.Count)
            Exit Sub
        Else
            Dim j As Integer = 1
            For i As Integer = 0 To sDt.Rows.Count - 1
                sDt.Rows(i).Item("DateTs") = ksbStringToDate(sDt.Rows(i).Item("DateTs"))

                Dim sdt2 As New DataTable
                Dim dr As DataRow = sDt.Rows(i)
                sDt.Rows(i).Item("NoteText") = sDt.Rows(i).Item("Note")
                Dim tempNode As String = sDt.Rows(i).Item("Note")
                Dim idTs As String = sDt.Rows(i).Item("idRef")

                If samNoteMapText.ContainsKey(tempNode) Then
                    If tempNode = "SAM-1" Or tempNode = "SAM-2" Or tempNode = "SAM-3" Or tempNode = "SAM-4" Or tempNode = "SAM-10" Then
                        sCommand.CommandText = "Select DocRef,CusName FROM vSmSaleMt Where idSale = " & idTs
                        sAdapter.Fill(sdt2)
                    ElseIf tempNode = "SAM-5" Or tempNode = "SAM-6" Or tempNode = "SAM-7" Or tempNode = "SAM-8" Or tempNode = "SAM-9" Then
                        sCommand.CommandText = "Select DocRefCode AS DocRef,CusName FROM vSmSaleReturnMt Where idSaleReturn = " & idTs
                        sAdapter.Fill(sdt2)
                    End If

                    If sdt2.Rows.Count > 0 Then
                        dr.Item("Note") = "SAM: " & samNoteMapText.Item(tempNode) & " : " & sdt2.Rows(0).Item("DocRef") & " : " & sdt2.Rows(0).Item("CusName")
                    Else
                        dr.Delete()
                        Continue For
                    End If
                End If
                If wimNoteMapText.ContainsKey(tempNode) Then
                    If tempNode = "WIM-4" Then
                        sCommand.CommandText = "Select Note FROM PkPdMixPacking Where idPacking = " & idTs
                        sAdapter.Fill(sdt2)
                        sDt.Rows(i).Item("Note") = "WIM: " & wimNoteMapText.Item(tempNode) & " : หมายเหตุ : " & sdt2.Rows(0).Item("Note")
                    Else
                        sDt.Rows(i).Item("Note") = "WIM: " & wimNoteMapText.Item(tempNode)
                    End If
                End If

                sDt.Rows(i).Item("ColNum") = j
                'dr.Item("DateTs") = ksbStringToDate(dr.Item("DateTs"))
                j += 1
                sDt.AcceptChanges()
            Next

        End If


        GridControl2.DataSource = sDt
        SumTotal(sDt.Rows.Count)
        mdLoadCommitt()
    End Sub

    Sub SumTotal(ByVal RowNum As Integer)
        Me.txtCount.Text = Format(RowNum, "#,##0")
    End Sub

    'Private Sub BindPlant()
    '    mdCnOpen()
    '    Dim sDt As New DataTable
    '    sCommand.CommandText = "Select Distinct idSeedType, SeedTypeName From vSeedProduct Where idSeedType <> '0' " & _
    '                           "AND SeedTypeName <> '' Order By SeedTypeName Asc"
    '    sAdapter.Fill(sDt)

    '    With cmbPlant
    '        .DisplayMember = "SeedTypeName"
    '        .ValueMember = "idSeedType"
    '        .DataSource = sDt
    '    End With
    'End Sub

    'Private Sub BindPd()
    '    mdCnOpen()
    '    Dim sDt As New DataTable
    '    sCommand.CommandText = "Select Distinct idPd, PdName From vSeedProduct Where idSeedType = '" & Me.cmbPlant.SelectedValue & "' Order By PdName Asc"
    '    sAdapter.Fill(sDt)

    '    With cmbPdName
    '        .DisplayMember = "PdName"
    '        .ValueMember = "idPd"
    '        .DataSource = sDt
    '    End With
    'End Sub

    'Private Sub cmbPlant_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    BindPd()
    'End Sub

    'Private Sub ChkPlantType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.ChkPlantType.Checked = True Then
    '        Me.cmbPlant.Enabled = True
    '        Me.ChkPdname.Enabled = True
    '    Else
    '        Me.cmbPlant.Enabled = False
    '        Me.ChkPdname.Enabled = False
    '        Me.ChkPdname.Checked = False
    '        Me.cmbPdName.Enabled = False
    '    End If
    'End Sub

    'Private Sub ChkPdname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.ChkPdname.Checked = True Then

    '        Me.cmbPdName.Enabled = True
    '    Else
    '        Me.cmbPdName.Enabled = False
    '    End If
    'End Sub

    'Private Sub ChkSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.ChkLotNum.Checked = True Then
    '        Me.txtLotNum.Enabled = True
    '    Else
    '        Me.txtLotNum.Enabled = False
    '    End If
    'End Sub

    Private Sub ChkDateStock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDateStock.CheckedChanged
        If Me.ChkDateStock.Checked = True Then
            Me.dtpStockS.Enabled = True
            Me.dtpStockE.Enabled = True
        Else
            Me.dtpStockS.Enabled = False
            Me.dtpStockE.Enabled = False
        End If
    End Sub


    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        go_to_page(dr)
    End Sub

    Private Sub go_to_page(ByRef dr As DataRow)
        Dim pidTs As String = dr.Item("idRef")
        Dim tempNode As String = dr.Item("NoteText")

        If samNoteMapText.ContainsKey(tempNode) Then

            If tempNode = "SAM-1" Or tempNode = "SAM-2" Or tempNode = "SAM-3" Or tempNode = "SAM-4" Or tempNode = "SAM-10" Then
                Dim frm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, pidTs, 0)
                frm.ShowDialog()
            End If

            If tempNode = "SAM-5" Or tempNode = "SAM-6" Or tempNode = "SAM-7" Or tempNode = "SAM-8" Or tempNode = "SAM-9" Then

                Dim sDt As New DataTable
                sCommand.CommandText = "SELECT idRTDocCode FROM vSmSaleReturnMt WHERE idSaleReturn = " & pidTs
                sAdapter.Fill(sDt)
                If sDt.Rows.Count > 0 Then
                    If sDt.Rows(0).Item("idRTDocCode") = 1 Then
                        Dim frm As New frmSlReturnTs(frmSlReturnTs.eProcess.eviewData, pidTs)
                        frm.ShowDialog()
                    Else
                        'Dim frm As New frmSlReturnTsJUPd(frmSlReturnTsJUPd.eProcess.eViewData, pidTs)
                        'frm.ShowDialog()
                    End If
                End If

            End If
            Exit Sub

        End If

        If tempNode = "WIM-2" Or tempNode = "WIM-5" Then
            Dim vFrm As New frmPdStockDetail(frmPdStockDetail.eProcess.eShow, idPdLot_)
            vFrm.ShowDialog()
        ElseIf tempNode = "WIM-4" Or tempNode = "WIM-6" Then
            Dim vFrm As New frmPdStockMixUpdateTs(frmPdStockMixUpdateTs.eProcess.eShowDataCard, pidTs)
            vFrm.ShowDialog()
        Else
            MessageBox.Show("ไม่พบหน้าทำรายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPdPk_Click(sender As Object, e As EventArgs) Handles btnPdPk.Click
        Dim vFrm As New frmPdStock(frmPdStock.eProcess.eSelectSale, "")
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.idPdLot_ = vFrm.idPdLot

            mdCnOpen()
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "Select s.LotNum, s.LotCodeRef, s.idPd, p.PdName, p.SeedTypeName From PkPdLotStock s " & _
                                   "LEFT OUTER JOIN vSeedProduct p " & _
                                   "ON s.idPd = p.idPd Where idPdLot = '" & idPdLot_ & "'"
            sAdapter.Fill(sDt)

            If IsDBNull(sDt.Rows(0).Item("LotNum")) Then
                Me.lblLotNum.Text = sDt.Rows(0).Item("LotCodeRef")
                Me.Label1.Text = "Group/Serial"
                stLot = 1 'LotCodeRef
            ElseIf sDt.Rows(0).Item("LotNum") = "" Then
                Me.lblLotNum.Text = sDt.Rows(0).Item("LotNum")
                Me.Label1.Text = "Lot no."
                stLot = 2 ' LotNum
            Else
                Me.lblLotNum.Text = sDt.Rows(0).Item("LotNum")
                Me.Label1.Text = "Lot no."
                stLot = 2 ' LotNum
            End If
            Me.lblPdName.Text = sDt.Rows(0).Item("PdName")
            Me.lblPdName.Tag = sDt.Rows(0).Item("idPd")
            Me.lblPlantName.Text = sDt.Rows(0).Item("SeedTypeName")
            BindData()

            Me.btnShow.Visible = True
        End If
    End Sub

End Class