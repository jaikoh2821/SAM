Public Class frmPdPkPriceSaleAll
    Dim idPdPk, stPrice As Integer
    Dim PdPkName As String
    Dim Price As Double
    Sub get_value(ByVal id As Integer, ByVal name As String)
        idPdPk = id
        PdPkName = name
        lb_PdPkName.Text = name
    End Sub
   
    Private Sub frmPdPkPriceSaleAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Pro()
        Load_Data()
    End Sub
    Dim dPro As DataTable
    Private Sub Load_Pro()
        mdLoadShow()
        mdCnOpen()
        dPro = New DataTable
        sCommand.CommandText = "SELECT PUM.idSale, PM.ProName, PUM.CdtPrice, PUM.CdtAmount, PUM.CdtMin, PUM.CdtMax, PUM.CdtUnit, PUM.idInv,vInv.InvName, PUM.idPdPk ,vPPS.PdPkName,PUM.AmountFree,PUM.FreeUnit " & _
        "FROM SmPromotionUseMt AS PUM INNER JOIN SmPromotionMt AS PM ON PUM.idPromotion = PM.idPromotion LEFT JOIN vPackingPdSet As vPPS ON PUM.idPdPk = vPPS.idPdPk LEFT JOIN PchInvAndProject.dbo.vInventory As vInv ON PUM.idInv = vInv.idInv " & _
        "Where PUM.idSale Is Not NULL"
        sAdapter.Fill(dPro)
        Dim dStPrice As New DataTable
        sCommand.CommandText = "Select PriceBill,PriceWholesale,PriceRetail FROM vPackingPdSet Where idPdPk = " & idPdPk
        sAdapter.Fill(dStPrice)
        txtstPrice1.Text = FormatNumber(dStPrice.Rows(0).Item("PriceBill"), 2)
        txtstPrice2.Text = FormatNumber(dStPrice.Rows(0).Item("PriceWholesale"), 2)
        txtstPrice3.Text = FormatNumber(dStPrice.Rows(0).Item("PriceRetail"), 2)
        mdLoadCommitt()
    End Sub
    Private Sub Load_Data()
        mdLoadShow()
        mdCnOpen()
        Dim datenow As Date = Date.Now
        Dim datefind As Date
        Dim strDate As String = ""
        'Dim vWhere As String = ""
        If rb_day.Checked Then
            strDate = " AND vSSM.DateSale between '" & ksbDateToString(Format(dtpS.Value, "Short date")) & "' AND '" & ksbDateToString(Format(dtpE.Value, "Short date")) & "'"
        ElseIf rb_3m.Checked Then
            datefind = datenow.AddMonths(-3)
            strDate = " AND vSSM.DateSale between '" & ksbDateToString(Format(datefind, "Short date")) & "' AND '" & ksbDateToString(Format(Now, "Short date")) & "'"
            'Label3.Text = "รายละเอียดราคาขาย 6 เดือนก่อนหน้า"
        ElseIf rb_6m.Checked Then
            datefind = datenow.AddMonths(-6)
            strDate = " AND vSSM.DateSale between '" & ksbDateToString(Format(datefind, "Short date")) & "' AND '" & ksbDateToString(Format(Now, "Short date")) & "'"
            'Label3.Text = "รายละเอียดราคาขาย 6 เดือนก่อนหน้า"
        End If
        'Tab1
        Dim SSD As New DataTable
        sCommand.CommandText = "SELECT SSD.Price, SSD.idPdPk, vSSM.DateSale, vSSM.DocCode, vSSM.CusName, vSSM.PsSale, vSSM.PsTs, vSSM.Note, C.CompName,SSD.idSale, 0 As stSale, " & _
        "Case vSSM.stPrice When 1 then 'ราคาหน้าบิล' When 2 then 'ราคาปลีก' When 3 then 'ราคาส่ง' End As stPrice FROM SmSaleDt AS SSD " & _
        "INNER JOIN vSmSaleMt AS vSSM ON SSD.idSale = vSSM.idSale INNER JOIN vPackingPdSet AS vPPS ON SSD.idPdPk = vPPS.idPdPk INNER JOIN PchInvAndProject.dbo.dCompany As C ON vSSM.idComp = C.idComp " & _
        "Where SSD.idPdPk = " & idPdPk & strDate & " Order By DateSale DESC"
        sAdapter.Fill(SSD)
        For i As Integer = 0 To SSD.Rows.Count - 1
            SSD.Rows(i).Item("DateSale") = ksbStringToDate(SSD.Rows(i).Item("DateSale"))
        Next
        DGV.DataSource = SSD
        Label3.Text = "รายการราคาขายสินค้าทั้งหมด " & SSD.Rows.Count & " รายการ"
        ksbCountRowDgv(DGV, colautonum.Name)
        For i As Integer = 0 To DGV.Rows.Count - 1
            For j As Integer = 0 To dPro.Rows.Count - 1
                If DGV.Rows(i).Cells(colidSale.Name).Value = dPro.Rows(j).Item("idSale") Then
                    DGV.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128)
                    DGV.Rows(i).Cells(colstSale.Name).Value = 1
                    Exit For
                End If
            Next
        Next
        Dim c As Integer = 0
        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(colstSale.Name).Value = 1 Then
                c += 1
            End If
        Next
        Label5.Text = "รายการสินค้าที่ได้โปรโมชั่นทั้งหมด " & c & " รายการ"
        'Tab2
        Dim SSD2 As New DataTable
        SSD2.Clear()
        sCommand.CommandText = "SELECT SSD.Price, SUM(SSD.Amount) AS Amount, Case vSSM.stPrice When 1 then 'ราคาหน้าบิล' When 2 then 'ราคาปลีก' When 3 then 'ราคาส่ง' End As stPrice,Count(SSD.Price) As CPrice " & _
        "FROM SmSaleDt AS SSD INNER JOIN vSmSaleMt AS vSSM ON SSD.idSale = vSSM.idSale Where SSD.idPdPk = " & idPdPk & strDate & " GROUP BY vSSM.stPrice,SSD.Price Order By SSD.Price DESC ,Amount DESC"
        sAdapter.Fill(SSD2)
        SSD2.Columns.Add("ratio", GetType(Double))
        Dim SumAmountAll As Double = 0
        For i As Integer = 0 To SSD2.Rows.Count - 1
            SumAmountAll += SSD2.Rows(i).Item("Amount")
            SSD2.Rows(i).Item("ratio") = 0
        Next
        For i As Integer = 0 To SSD2.Rows.Count - 1
            SSD2.Rows(i).Item("ratio") = (SSD2.Rows(i).Item("Amount") * 100) / SumAmountAll
        Next
        DGVAllPrice.DataSource = SSD2
        mdLoadCommitt()
    End Sub

    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        Load_Data()
    End Sub

    Private Sub DGV_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        mdLoadShow()
        If DGV.Rows(e.RowIndex).Cells(colstSale.Name).Value = 1 Then
            ContextMenuStrip1 = New ContextMenuStrip
            Dim vPro As New DataView(dPro)
            vPro.RowFilter = "idSale = " & DGV.Rows(e.RowIndex).Cells(colidSale.Name).Value
            Dim strPro As String = ""
            For i As Integer = 0 To vPro.Count - 1
                'ชื่อโปรโมชั่น
                strPro = ""
                If vPro.Count > 1 Then
                    strPro &= (i + 1).ToString & "." & vPro(i).Item("ProName") & " "
                Else
                    strPro &= vPro(i).Item("ProName") & " "
                End If
                'เงื่อนไข
                If vPro(i).Item("CdtAmount") Is DBNull.Value Then
                    strPro &= "ซื้อสินค้า " & vPro(i).Item("CdtMin") & " - " & vPro(i).Item("CdtMax") & " " & vPro(i).Item("CdtUnit") & " "
                Else
                    strPro &= "ซื้อสินค้าตั้งแต่ " & vPro(i).Item("CdtAmount") & " " & vPro(i).Item("CdtUnit") & " "
                End If
                'เงื่อนไขราคา
                If Not vPro(i).Item("CdtPrice") Is DBNull.Value Then
                    strPro &= "ราคาตั้งแต่ " & vPro(i).Item("CdtPrice") & " บาท "
                End If
                'ของแถม
                If vPro(i).Item("idInv") Is DBNull.Value Then
                    strPro &= "แถม " & vPro(i).Item("PdPkName") & " " & vPro(i).Item("AmountFree") & " " & vPro(i).Item("FreeUnit")
                Else
                    'If vPro(i).Item("FreeUnit") = "-" Then
                    '    strPro &= "แถม " & vPro(i).Item("InvName") & " " & vPro(i).Item("AmountFree") & " บาท" '& vPro(i).Item("FreeUnit")
                    'End If
                    strPro &= "แถม " & vPro(i).Item("InvName") & " " & vPro(i).Item("AmountFree") & " " & vPro(i).Item("FreeUnit")
                End If
                ContextMenuStrip1.Items.Add(strPro)
                ContextMenuStrip1.Show(New Point(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y))
            Next
        End If
        mdLoadCommitt()
    End Sub

    Private Sub DGVAllPrice_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DGVAllPrice.RowPostPaint
        Me.DGVAllPrice("colautonum2", e.RowIndex).Value = e.RowIndex + 1
    End Sub
End Class