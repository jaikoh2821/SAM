Public Class frmPdoStockCard
    Dim idPdoLot_ As Integer = 0
    Private samNoteMapText As New Dictionary(Of String, String)
    Private wimNoteMapText As New Dictionary(Of String, String)


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        BindData()
    End Sub

    Sub BindData()
        Dim vWhere As String = "AND sc.idLot = " & idPdoLot_ & " "

        If Me.ChkDateStock.Checked = True Then
            vWhere &= "AND convert(int,sc.DateTs) Between " & ksbDateToString(dtpStockS.Value.ToShortDateString) & " " & _
                     "AND " & ksbDateToString(dtpStockE.Value.ToShortDateString) & " "
        End If

        getData(vWhere, GridControl2, txtCount)
    End Sub

    Private Sub frmPdoStockCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        wimNoteMapText.Add("WIM-2", "เพิ่มสินค้าเข้าสต๊อก")
        wimNoteMapText.Add("WIM-3", "ปรับปรุงจำนวนสินค้าในสต๊อก")

        dtpStockS.Value = Date.Today
        dtpStockE.Value = Date.Today
    End Sub

    Private Sub getData(ByVal vwhere As String, ByRef gv As System.Object, ByRef sumtext As System.Object)
        mdCnOpen()
        mdLoadShow()

        Dim sDt As New DataTable

        sCommand.CommandText = "Select sc.idTs, convert(date,convert(char, sc.DateTs-5430000)) as DateTs, " & _
                                "pk.PdoName, sc.AmountAdd, sc.AmountCut, sc.Balance, " & _
                                "ps.PsName as PsTs, sc.idRef, pk.LotNum, sc.Note,sc.Note AS idNote, pk.idPdOLot " & _
                                "From SmPdOStockCrad sc " & _
                                "LEFT OUTER JOIN vSmPdOtherDLot pk ON sc.idLot = pk.idPdOLot " & _
                                "LEFT OUTER JOIN vPerson ps ON sc.idPsTs = ps.idPs " & _
                                "Where pk.stDel='0' AND pk.CompRec = '" & sIdComp & "' " & vwhere & _
                                "Order by sc.idLot,sc.DateTs"
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสต็อกการ์ด สินค้าอื่น ๆ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sDt.Columns.Add("index", System.Type.GetType("System.String"))
            Dim j As Integer = 1
            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim sdt2 As New DataTable
                Dim dr As DataRow = sDt.Rows(i)
                Dim tempNode As String = dr.Item("Note")
                Dim idTs As String = dr.Item("idRef")
                Dim pidPdoLot As String = dr.Item("idPdOLot")

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
                ElseIf wimNoteMapText.ContainsKey(tempNode) Then
                    dr.Item("Note") = "WIM: " & wimNoteMapText.Item(tempNode)
                    If tempNode = "WIM-2" Then
                        sCommand.CommandText = "Select Note,DocNum FROM SmPdoStockUpdateMt Where idUpdate = " & idTs & ""
                        sAdapter.Fill(sdt2)
                        If sdt2.Rows.Count > 0 Then
                            dr.Item("Note") &= " : เลขที่เอกสาร : " & sdt2.Rows(0).Item("DocNum") & " : หมายเหตุ : " & sdt2.Rows(0).Item("Note")
                        End If
                    End If
                    If tempNode = "WIM-3" Then
                        sCommand.CommandText = "Select Note FROM SmPdOtherUpdateMt Where idUpdate = " & idTs & ""
                        sAdapter.Fill(sdt2)
                        If sdt2.Rows.Count > 0 Then
                            dr.Item("Note") &= " : หมายเหตุ : " & sdt2.Rows(0).Item("Note")
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
        sumtext.text = Format(sDt.Rows.Count, "#,##0")
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        go_to_page(dr)
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
        If wimNoteMapText.ContainsKey(idNote) Then
            If idNote = "WIM-2" Then
                Dim sDtTemp As New DataTable
                sCommand.CommandText = "SELECT *  FROM vSmPdOtherDLot WHERE idPdOLot = " & idPdoLot_
                sAdapter.Fill(sDtTemp)
                Dim frm As New frmSlPdoAddStockTempAddData(frmSlPdoAddStockTempAddData.eProcess.eShow)

                If sDtTemp.Rows(0).Item("AmountRec") Is DBNull.Value Then
                    sDtTemp.Rows(0).Item("AmountRec") = 0
                End If
                If sDtTemp.Rows(0).Item("DateDoc") Is DBNull.Value Then
                    sDtTemp.Rows(0).Item("DateDoc") = ""
                End If
                If sDtTemp.Rows(0).Item("DocNum") Is DBNull.Value Then
                    sDtTemp.Rows(0).Item("DocNum") = ""
                End If
                If sDtTemp.Rows(0).Item("LotNum") Is DBNull.Value Then
                    sDtTemp.Rows(0).Item("LotNum") = ""
                End If
                If sDtTemp.Rows(0).Item("Note") Is DBNull.Value Then
                    sDtTemp.Rows(0).Item("Note") = ""
                End If
                If sDtTemp.Rows(0).Item("EXPDate") Is DBNull.Value Then
                    sDtTemp.Rows(0).Item("EXPDate") = sDtTemp.Rows(0).Item("DateTs")
                End If

                Dim pAmount As String = sDtTemp.Rows(0).Item("AmountRec")
                Dim pDocDate As String = ksbStringToDate(sDtTemp.Rows(0).Item("DateDoc"))
                Dim pDocNum As String = sDtTemp.Rows(0).Item("DocNum")
                Dim pLotNum As String = sDtTemp.Rows(0).Item("LotNum")
                Dim pNote As String = sDtTemp.Rows(0).Item("Note")
                Dim pidWh As String = sDtTemp.Rows(0).Item("idWh")
                Dim pWareHouseName As String = sDtTemp.Rows(0).Item("WareHouseName")
                Dim pEXPDate As String = sDtTemp.Rows(0).Item("EXPDate")
                Dim pidPdo As String = sDtTemp.Rows(0).Item("idPdo")
                frm.Get_Data(pidPdo, pDocDate, pLotNum, pAmount, pNote, pDocNum, pidWh, pWareHouseName, pEXPDate)
                frm.ShowDialog()
            End If
            If idNote = "WIM-3" Then
                Dim frm As New frmSlPdoStockUpdate(frmSlPdoStockUpdate.eProcess.eShow)
                Dim sDtTemp As New DataTable
                sCommand.CommandText = "SELECT idUpdate FROM SmPdOtherUpdateDt WHERE idUpdateDt = " & pidTs
                sAdapter.Fill(sDtTemp)
                Dim idUpdate As String = sDtTemp.Rows(0).Item("idUpdate")
                frm.getShowData(idUpdate)
                frm.ShowDialog()
            End If
        Else
            MessageBox.Show("ไม่พบหน้าทำรายการ")
        End If
        'If note.StartsWith("SAM: ") Then
        '    Dim frm As New frmSlSaleTs(frmSlSaleTs.eProcess.eView, pidTs, Nothing, Nothing, Nothing, Nothing, Nothing)
        '    frm.ShowDialog()
        'Else
        'If note.StartsWith("WIM: " & wimNoteMapText("WIM-1")) Then
        '    Dim frm As New frmInvMovePdPkShowData
        '    frm.viewUpdate(pidTs)
        '    frm.ShowDialog()
        'ElseIf note = "WIM: เพิ่มสินค้าเข้าสต็อก" Then
        '    Dim frm As New frmPdPkPackingStockTemp(frmPdPkPackingStockTemp.eProcess.eShow)
        '    frm.idPdPkLotShow = dr.Item("idPdPKLot")
        '    frm.ShowDialog()
        'ElseIf note = "Packing: Packing สินค้าสำเร็จรูป" Then
        '    Dim frm As New frmPkPackingTs(frmPkPackingTs.eProcess.eviewData, pidTs)
        '    frm.ShowDialog()

    End Sub

    Private Sub ChkDateStock_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDateStock.CheckedChanged
        If Me.ChkDateStock.Checked = True Then
            Me.dtpStockS.Enabled = True
            Me.dtpStockE.Enabled = True
        Else
            Me.dtpStockS.Enabled = False
            Me.dtpStockE.Enabled = False
        End If
    End Sub

    Private Sub btnPdPk_Click(sender As Object, e As EventArgs) Handles btnPdPk.Click
        Dim vfrm As New frmPdOtherSelectCard(frmPdOtherSelectCard.eProcess.eSelectLot)
        vfrm.ShowDialog()
        If vfrm.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.idPdoLot_ = vfrm.idPdO
            mdCnOpen()
            Dim sDt As New DataTable
            sDt.Clear()
            sCommand.CommandText = "SELECT Title, PdoTypeName ,LotNum FROM  vSmPdOtherDLot Where idPdOLot = '" & idPdoLot_ & "'"
            sAdapter.Fill(sDt)

            Me.lblPdoName.Text = sDt.Rows(0).Item("Title")
            Me.lblTypeName.Text = sDt.Rows(0).Item("PdoTypeName")
            Me.lblLotNum.Text = sDt.Rows(0).Item("LotNum")
            BindData()
            Me.btnShow.Visible = True
        End If
    End Sub

End Class