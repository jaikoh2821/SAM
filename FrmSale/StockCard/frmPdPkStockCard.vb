Imports System.Windows.Forms
Imports System.Drawing
Public Class frmPdPkStockCard
    'Private _propertyName As Rectangle
    Dim idPdPk_ As Integer = 0
    'Dim idPdT As String = ""
    Dim flag As String = 0
    Dim PdTName As String = ""
    Dim idPdPkLot_ As Integer = 0
    'Dim LotNum As String = ""

    Private samNoteMapText As New Dictionary(Of String, String)
    Private wimNoteMapText As New Dictionary(Of String, String)

    Private Sub frmPdPkStockCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'BindPlant()
        'BindData1()

        samNoteMapText.Add("SAM-1", "การขายสินค้า")
        samNoteMapText.Add("SAM-2", "ยกเลิกรายการขายสินค้า")
        samNoteMapText.Add("SAM-3", "แก้ไขรายการขายสินค้า")
        samNoteMapText.Add("SAM-4", "ไม่อนุมัติรายการขายสินค้า")
        samNoteMapText.Add("SAM-5", "การคืนสินค้า")
        samNoteMapText.Add("SAM-6", "แก้ไขรายการคืนสินค้า")
        samNoteMapText.Add("SAM-7", "ยกเลิกรายการคืนสินค้า")
        samNoteMapText.Add("SAM-8", "ไม่อนุมัติรายการคืนสินค้า")
        samNoteMapText.Add("SAM-9", "Reject รายการคืนสินค้า")
        samNoteMapText.Add("SAM-10", "ยกเลิกสถานะ รับทราบ/ตรวจสอบ/อนุมัติ รายการขายสินค้า")
        samNoteMapText.Add("SAM-11", "โอนย้ายสินค้าระหว่างบริษัท")
        wimNoteMapText.Add("WIM-1", "ย้ายคลังสินค้า")
        flag = 1

    End Sub

    Sub BindData()
        Dim vWhere As String = "AND sc.idPdPkLot = " & idPdPkLot_ & " "

        If Me.ChkDateStock.Checked = True Then  
            vWhere &= "AND convert(int,sc.DateTs) Between " & ksbDateToString(dtpStockS.Value.ToShortDateString) & " " & _
                     "AND " & ksbDateToString(dtpStockE.Value.ToShortDateString) & " "
        End If

        getData(vWhere, GridControl2, txtCount)
    End Sub

    Private Sub btnShow_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        BindData()
    End Sub


    'Private Sub btnNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
    '    Dim vFrm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePdLotSelect)
    '    If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Me.idPdPkLot_ = vFrm.pidPdPkLot
    '        Me.LotNum = vFrm.PdPkLotNo
    '        txtLotNum.Text = LotNum
    '        mdCnOpen()
    '        Dim sDt As New DataTable
    '        sDt.Clear()
    '        sCommand.CommandText = "SELECT PdPkName, PlantName FROM  vPackingPdSetLot Where idPdPkLot = '" & idPdPkLot_ & "'"
    '        sAdapter.Fill(sDt)

    '        Me.lblPdPkName.Text = sDt.Rows(0).Item("PdPkName")
    '        Me.lblPlantName.Text = sDt.Rows(0).Item("PlantName")

    '        BindData()
    '    End If
    'End Sub

    Private Sub ChkDateStock_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDateStock.CheckedChanged
        If Me.ChkDateStock.Checked = True Then
            Me.dtpStockS.Enabled = True
            Me.dtpStockE.Enabled = True
        Else
            Me.dtpStockS.Enabled = False
            Me.dtpStockE.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDateStock2.CheckedChanged
        If Me.ChkDateStock2.Checked = True Then
            Me.dtpStockS2.Enabled = True
            Me.dtpStockE2.Enabled = True
        Else
            Me.dtpStockS2.Enabled = False
            Me.dtpStockE2.Enabled = False
        End If
    End Sub

    Private Sub getData(ByVal vwhere As String, ByRef gv As System.Object, ByRef sumtext As System.Object)
        mdCnOpen()
        mdLoadShow()

        Dim sDt As New DataTable

        sCommand.CommandText = "Select sc.idTs, pk.idPdPk, convert(date,convert(char, sc.DateTs-5430000)) as DateTs, " & _
                                "pk.PdPkName, d.idPkUnit, pk.PkUnitName, sc.AmountAdd, sc.AmountCut, sc.Balance, " & _
                                "ps.PsName as PsTs, sc.idRef, pk.LotNum, sc.Note,sc.Note AS idNote, pk.idPdPkLot " & _
                                "From PdPkStockCard sc " & _
                                "LEFT JOIN vPackingPdSetLotxSelect pk ON sc.idPdPkLot = pk.idPdPkLot " & _
                                "LEFT JOIN dPackingPdSet d ON pk.idPdPk = d.idPdPk " & _
                                "LEFT OUTER JOIN vPerson ps ON sc.idPsTs = ps.idPs " & _
                                "Where pk.stDel='0' " & vwhere & _
                                "Order by sc.idPdPkLot,sc.DateTs"
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูลสต็อกการ์ด สินค้าสำเร็จรูป", sSystemName)
        Else
            sDt.Columns.Add("index", System.Type.GetType("System.String"))
            Dim j As Integer = 1
            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim sdt2 As New DataTable
                Dim dr As DataRow = sDt.Rows(i)
                Dim tempNode As String = dr.Item("Note")
                Dim idTs As String = dr.Item("idRef")
                Dim pidPdPkLot As String = dr.Item("idPdPkLot")

                If samNoteMapText.ContainsKey(tempNode) Then
                    If tempNode = "SAM-1" Or tempNode = "SAM-2" Or tempNode = "SAM-3" Or tempNode = "SAM-4" Or tempNode = "SAM-10" Then
                        sCommand.CommandText = "Select DocRef,CusName FROM vSmSaleMt Where idSale = " & idTs
                        sAdapter.Fill(sdt2)
                    ElseIf tempNode = "SAM-5" Or tempNode = "SAM-6" Or tempNode = "SAM-7" Or tempNode = "SAM-8" Or tempNode = "SAM-9" Then
                        sCommand.CommandText = "Select DocRefCode As DocRef, CusName FROM vSmSaleReturnMt Where idSaleReturn = " & idTs
                        sAdapter.Fill(sdt2)
                    End If

                    If sdt2.Rows.Count > 0 Then
                        dr.Item("Note") = "SAM: " & samNoteMapText.Item(tempNode) & " : " & sdt2.Rows(0).Item("DocRef") & " : " & sdt2.Rows(0).Item("CusName")
                    Else
                        dr.Delete()
                        Continue For
                    End If
                ElseIf wimNoteMapText.ContainsKey(tempNode) Then

                    dr.Item("Note") = "WIM: " & wimNoteMapText.Item(tempNode)
                Else
                    If dr.Item("Note") <> "WIM: เพิ่มสินค้าเข้าสต็อก" Then
                        sCommand.CommandText = "Select Note FROM PkPdPkUpdateDt Where idUpdate = " & idTs & " AND idpdpklot = " & pidPdPkLot
                        sAdapter.Fill(sdt2)
                        If sdt2.Rows.Count > 0 Then
                            dr.Item("Note") &= " : " & sdt2.Rows(0).Item("Note")
                        End If
                    End If
                End If

                dr.Item("index") = j
                'dr.Item("DateTs") = ksbStringToDate(dr.Item("DateTs"))
                j += 1
            Next
        End If
        mdLoadCommitt()

        sDt.AcceptChanges()
        gv.DataSource = sDt
        txtCount.Text = Format(sDt.Rows.Count, "#,##0")

    End Sub

    Private Sub BindData_2()
        Dim vWhere As String = "AND pk.idPdPk ='" & idPdPk_ & "' "

        If Me.ChkDateStock2.Checked = True Then
            vWhere &= "AND convert(int,sc.DateTs) Between " & ksbDateToString(dtpStockS2.Value.ToShortDateString) & " " & _
                    "And " & ksbDateToString(dtpStockE2.Value.ToShortDateString) & " "
        End If

        getData(vWhere, GridControl1, txtCount2)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BindData_2()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePdAll)
        frm.ShowDialog()
        If (frm.DialogResult = Windows.Forms.DialogResult.OK) Then
            idPdPk_ = frm.idPdPk
            PdTName = frm.PdPkName
            txtPdTName.Text = PdTName
            BindData_2()
        End If
    End Sub

    Private Sub go_to_page(ByRef dr As DataRow)
        Dim pidTs As String = dr.Item("idRef")
        Dim note As String = dr.Item("Note")
        Dim idNote As String = dr.Item("idNote")

        If samNoteMapText.ContainsKey(idNote) Then

            If idNote = "SAM-1" Or idNote = "SAM-2" Or idNote = "SAM-3" Or idNote = "SAM-4" Or idNote = "SAM-10" Then
                Dim frm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, pidTs, 0)
                frm.ShowDialog()
            End If

            If idNote = "SAM-5" Or idNote = "SAM-6" Or idNote = "SAM-7" Or idNote = "SAM-8" Or idNote = "SAM-9" Then

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

        'If note.StartsWith("SAM: ") Then
        '    Dim frm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, pidTs, Nothing, Nothing, Nothing, Nothing, Nothing)
        '    frm.ShowDialog()
        'Else
        If note.StartsWith("WIM: ปรับปรุงสต็อก") Then
            Try
                Dim frm As New frmPdPkStockUpdate
                frm.Get_type("1", pidTs)
                frm.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("ไม่พบหน้าทำรายการ")
            End Try
        ElseIf note.StartsWith("WIM: " & wimNoteMapText("WIM-1")) Then
            Dim frm As New frmInvMovePdPkShowData
            frm.viewUpdate(pidTs)
            frm.ShowDialog()
        ElseIf note = "WIM: เพิ่มสินค้าเข้าสต็อก" Then
            Dim frm As New frmPdPkPackingStockTemp(frmPdPkPackingStockTemp.eProcess.eShow)
            frm.idPdPkLotShow = dr.Item("idPdPKLot")
            frm.ShowDialog()
        ElseIf note = "Packing: Packing สินค้าสำเร็จรูป" Then
            Dim frm As New frmPkPackingTs(frmPkPackingTs.eProcess.eviewData, pidTs)
            frm.ShowDialog()
        Else
            MessageBox.Show("ไม่พบหน้าทำรายการ")
        End If
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

        go_to_page(dr)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)

        go_to_page(dr)
    End Sub

    Private Sub btnPdPk_Click(sender As Object, e As EventArgs) Handles btnPdPk.Click
        'Dim vFrm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePdLotSelect)
        Dim tempDt As New DataTable
        Dim vFrm As New frmPdPkLotSelect(frmPdPkLotSelect.eProcess.ePdAllLot, tempDt)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.idPdPkLot_ = vFrm.pidPdPkLot

            mdCnOpen()
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "SELECT l.PdPkName, t.SeedTypeName As PlantName, l.LotNum FROM  vPackingPdSetLotxSelect l " & _
                                   "LEFT JOIN slPdTradeNameD s ON l.idPdT = s.idPdT " & _
                                   "LEFT JOIN dSeedType t ON s.idSeedType = t.idSeedType Where idPdPkLot = '" & idPdPkLot_ & "'"
            sAdapter.Fill(sDt)

            Me.lblPdPkName.Text = sDt.Rows(0).Item("PdPkName")
            Me.lblPlantName.Text = sDt.Rows(0).Item("PlantName")
            Me.txtLotNum.Text = sDt.Rows(0).Item("LotNum")

            BindData()
            Me.btnShow.Visible = True
        End If
    End Sub

    Private Sub btnPdT_Click(sender As Object, e As EventArgs) Handles btnPdT.Click
        Dim frm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePdAll)
        frm.ShowDialog()
        If (frm.DialogResult = Windows.Forms.DialogResult.OK) Then
            idPdPk_ = frm.idPdPk
            PdTName = frm.PdPkName
            txtPdTName.Text = PdTName
            BindData_2()
            Button2.Visible = True
        End If
    End Sub
End Class