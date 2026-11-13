Public Class frmMkPromotionGet
    Dim ProShow As New DataTable
    Public ProInsert As New DataTable

    Public Sub ShowText(ByVal getProDt As DataTable)
        ProShow = getProDt
    End Sub

    Private Sub frmSlSalePromotionShow_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ProInsert.Columns.Add("idPromotion", System.Type.GetType("System.Int32"))
        ProInsert.Columns.Add("CdtPrice", System.Type.GetType("System.Double"))
        ProInsert.Columns.Add("CdtAmount", System.Type.GetType("System.Int32"))
        ProInsert.Columns.Add("CdtMin", System.Type.GetType("System.Int32"))
        ProInsert.Columns.Add("CdtMax", System.Type.GetType("System.Int32"))
        ProInsert.Columns.Add("CdtUnit", System.Type.GetType("System.String"))
        ProInsert.Columns.Add("idInv", System.Type.GetType("System.Int32"))
        ProInsert.Columns.Add("idProType", System.Type.GetType("System.Int32"))
        ProInsert.Columns.Add("AmountFree", System.Type.GetType("System.Int32"))
        ProInsert.Columns.Add("FreeUnit", System.Type.GetType("System.String"))

        Dim vFrm As New frmMkPromotionCustomerSelect
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsCus.Tag = vFrm.idCus
            Me.lblPsCus.Text = vFrm.CusName
            'BindGetPro()
            mdLoadShow()
            BindData()
            mdLoadCommitt()
        End If

    End Sub

    Sub BindData()

        mdCnOpen()
        Dim sDt As New DataTable
        'sCommand.CommandText = "SELECT u.idProUse, u.idPromotion, u.DateUse, p.ProName, t.ProTypeName, p.idProType, " & _
        '                       "ps.PsName As PsSale FROM [GR_Group].[dbo].[SmPromotionUseMt] u " & _
        '                       "LEFT OUTER JOIN [GR_Group].[dbo].[SmPromotionMt] p ON u.idPromotion = p.idPromotion " & _
        '                       "LEFT OUTER JOIN [GR_Group].[dbo].[SmPromotionType] t ON p.idProType = t.idProType " & _
        '                       "LEFT OUTER JOIN [GR_Group].[dbo].[vPerson]  ps ON u.idPsSale = ps.idPs " & _
        '                       "WHERE u.stConfirm IS NULL AND p.idProType <> 1 AND p.idProType <> 6 AND idCus = " & Me.lblPsCus.Tag & ""

        sCommand.CommandText = "SELECT Distinct u.idSale, s.DocCode, s.DateSale, p.PsName As PsSale, 0 As NumPro " & _
                               "FROM SmPromotionUseMt u LEFT OUTER JOIN vSmSaleMt s ON u.idSale = s.idSale " & _
                               "LEFT OUTER JOIN SmPromotionMt pro ON u.idPromotion = pro.idPromotion " & _
                               "LEFT OUTER JOIN vPerson p ON u.idPsSale = p.idPs " & _
                               "WHERE u.idSale IS NOT NULL AND pro.idProType <> 1 AND pro.idProType <> 6 " & _
                               "AND u.idCus = " & Me.lblPsCus.Tag & " AND (s.stPromotion = 1 AND s.idPsAppPromotion IS NULL)"
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลรายการที่ได้รับโปรโมชั่น", sSystemName)
            dgvBF.DataSource = sDt
            Exit Sub
        Else
            '---Count Promotion----'
            For i As Integer = 0 To sDt.Rows.Count - 1
                Dim tempDt As New DataTable

                sCommand.CommandText = "SELECT COUNT(mt.idProUse) As NumPro FROM SmPromotionUseMt mt " & _
                                       "LEFT OUTER JOIN SmPromotionMt pro ON mt.idPromotion = pro.idPromotion " & _
                                       "WHERE pro.idProType <> 1 AND pro.idProType <> 6 " & _
                                       "AND mt.idSale = " & sDt.Rows(i).Item("idSale") & ""
                sAdapter.Fill(tempDt)

                sDt.Rows(i).Item("NumPro") = tempDt.Rows(0).Item("NumPro")
            Next

            dgvBF.DataSource = sDt
            ksbCountRowDgv(dgvBF, ColNum.Name)
            mdConvertDateInGrid(dgvBF, ColDateSale)
        End If
    End Sub

    'Sub BindGetPro()
    '    For Each drRow As DataRow In ProShow.Rows
    '        With dgvBF
    '            Dim rc As Integer = dgvBF.RowCount
    '            Dim CntStr As String = ""

    '            If Not IsDBNull(ProShow.Rows(rc)("CdtAmount")) Then
    '                CntStr = CntStr & " ซื้อสินค้าจำนวนขั้นต่ำ " & ProShow.Rows(rc)("CdtAmount") & " " & ProShow.Rows(rc)("CdtUnit")
    '            Else
    '                CntStr = CntStr & " ซื้อสินค้าจำนวน " & ProShow.Rows(rc)("CdtMin") & " - " & ProShow.Rows(rc)("CdtMax") _
    '                        & " " & ProShow.Rows(rc)("CdtUnit")
    '            End If

    '            If Not IsDBNull(ProShow.Rows(rc)("CdtPrice")) Then
    '                CntStr = CntStr & " ราคาตั้งแต่ " & ProShow.Rows(rc)("CdtPrice") & " บาทขึ้นไป "
    '            End If

    '            CntStr = CntStr & " แถม " & ProShow.Rows(rc)("InvName_") & " " & ProShow.Rows(rc)("InvAmt") _
    '                            & " " & ProShow.Rows(rc)("InvUnit")

    '            .Rows.Add()
    '            .Rows(rc).Cells("ColNum_Up").Value = rc + 1
    '            .Rows(rc).Cells("ColidPromotion").Value = ProShow.Rows(rc)("idPromotion")
    '            ' .Rows(rc).Cells("ColidSale").Value = ProShow.Rows(rc)("idSale")
    '            '  .Rows(rc).Cells("ColidCus").Value = ProShow.Rows(rc)("idCus")
    '            .Rows(rc).Cells("ColProName").Value = ProShow.Rows(rc)("ProName")
    '            .Rows(rc).Cells("ColProType").Value = ProShow.Rows(rc)("ProTypeName")
    '            .Rows(rc).Cells("ColidProType").Value = ProShow.Rows(rc)("idProType")
    '            '  .Rows(rc).Cells("ColidPsSale").Value = ProShow.Rows(rc)("idPsSale")
    '            .Rows(rc).Cells("ColCondition").Value = CntStr
    '            .Rows(rc).Cells("ColInvname").Value = ProShow.Rows(rc)("InvName_")
    '            .Rows(rc).Cells("ColidInv").Value = ProShow.Rows(rc)("idInv")
    '            .Rows(rc).Cells("ColCntAmt").Value = ProShow.Rows(rc)("CntAmt")
    '            .Rows(rc).Cells("ColInvUnit").Value = ProShow.Rows(rc)("InvUnit")
    '            .Rows(rc).Cells("ColCdtPrice").Value = ProShow.Rows(rc)("CdtPrice")
    '            .Rows(rc).Cells("ColCdtAmount").Value = ProShow.Rows(rc)("CdtAmount")
    '            .Rows(rc).Cells("ColCdtMin").Value = ProShow.Rows(rc)("CdtMin")
    '            .Rows(rc).Cells("ColCdtMax").Value = ProShow.Rows(rc)("CdtMax")
    '            .Rows(rc).Cells("ColCdtUnit").Value = ProShow.Rows(rc)("CdtUnit")
    '        End With
    '    Next
    'End Sub

    Private Sub dgvBF_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBF.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If


        If dgvBF.Columns(e.ColumnIndex).Name = ColSelect.Name Then
            'idSaleOrderShow = dgvShowOrder.CurrentRow.Cells("ColidProUse").Value
            Dim vFrm As New frmMkPromotionGetConfirm(frmMkPromotionGetConfirm.eProcess.eComfirm, dgvBF.CurrentRow.Cells("ColidSale").Value)
            If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                mdLoadShow()
                BindData()
                mdLoadCommitt()
            End If

        End If

        ''----Select Promotion------'
        'If dgvBF.Columns(e.ColumnIndex).Name = ColSelect.Name Then

        '    'ADD TO dgvAF
        '    With dgvAF
        '        Dim rc As Integer = dgvAF.RowCount
        '        .Rows.Add()
        '        .Rows(rc).Cells("ColNumR").Value = rc + 1
        '        .Rows(rc).Cells("ColidPromotionR").Value = dgvBF.Rows(e.RowIndex).Cells("ColidPromotion").Value
        '        ' .Rows(rc).Cells("ColidSaleR").Value = dgvBF.Rows(e.RowIndex).Cells("ColidSale").Value
        '        '  .Rows(rc).Cells("ColidCusR").Value = dgvBF.Rows(e.RowIndex).Cells("ColidCus").Value
        '        '   .Rows(rc).Cells("ColidPsSaleR").Value = dgvBF.Rows(e.RowIndex).Cells("ColidPsSale").Value
        '        .Rows(rc).Cells("ColProNameR").Value = dgvBF.Rows(e.RowIndex).Cells("ColProName").Value
        '        .Rows(rc).Cells("ColProTypeR").Value = dgvBF.Rows(e.RowIndex).Cells("ColProType").Value
        '        .Rows(rc).Cells("ColidProTypeR").Value = dgvBF.Rows(e.RowIndex).Cells("ColidProType").Value
        '        .Rows(rc).Cells("ColConditionR").Value = dgvBF.Rows(e.RowIndex).Cells("ColCondition").Value
        '        If dgvBF.Rows(e.RowIndex).Cells("ColidProType").Value <> 3 Then 'ไม่ใช่สินค้าบริษัท
        '            .Rows(rc).Cells("ColInvnameR").Value = dgvBF.Rows(e.RowIndex).Cells("ColInvname").Value
        '            .Rows(rc).Cells("ColidInvR").Value = dgvBF.Rows(e.RowIndex).Cells("ColidInv").Value
        '        End If

        '        .Rows(rc).Cells("ColCntAmtR").Value = dgvBF.Rows(e.RowIndex).Cells("ColCntAmt").Value
        '        .Rows(rc).Cells("ColInvUnitR").Value = dgvBF.Rows(e.RowIndex).Cells("ColInvUnit").Value
        '        .Rows(rc).Cells("ColCdtPriceR").Value = dgvBF.Rows(e.RowIndex).Cells("ColCdtPrice").Value
        '        .Rows(rc).Cells("ColCdtAmountR").Value = dgvBF.Rows(e.RowIndex).Cells("ColCdtAmount").Value
        '        .Rows(rc).Cells("ColCdtMinR").Value = dgvBF.Rows(e.RowIndex).Cells("ColCdtMin").Value
        '        .Rows(rc).Cells("ColCdtMaxR").Value = dgvBF.Rows(e.RowIndex).Cells("ColCdtMax").Value
        '        .Rows(rc).Cells("ColCdtUnitR").Value = dgvBF.Rows(e.RowIndex).Cells("ColCdtUnit").Value
        '    End With

        '    'DELETE FROM dgvBF
        '    dgvBF.Rows.Remove(dgvBF.CurrentRow)
        '    ksbCountRowDgv(dgvBF, ColNum_Up.Name)

        'End If

    End Sub

    Private Sub dgvAF_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        ''----Select PdPk ----'
        'If dgvAF.Columns(e.ColumnIndex).Name = ColPkSelect.Name Then
        '    If dgvAF.CurrentRow.Cells("ColidProTypeR").Value = 3 Then 'แถมสินค้าบริษัท
        '        'idPdPk in Promotion
        '        Dim sDt As New DataTable
        '        sCommand.CommandText = "Select idPdPk From SmPromotionDtPd WHERE idPromotion = " & dgvAF.CurrentRow.Cells("ColidPromotionR").Value & ""
        '        sAdapter.Fill(sDt)

        '        Dim idPdPklist As String = ""

        '        idPdPklist = idPdPklist & sDt.Rows(0).Item("idPdPk")
        '        For i As Integer = 1 To sDt.Rows.Count - 1
        '            idPdPklist = idPdPklist & "|" & sDt.Rows(i).Item("idPdPk")
        '        Next

        '        Dim vFrm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePromotion)
        '        vFrm.ShowText(idPdPklist)
        '        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
        '            dgvAF.Rows(e.RowIndex).Cells("ColidInvR").Value = vFrm.idPdPk
        '            dgvAF.Rows(e.RowIndex).Cells("ColInvnameR").Value = vFrm.PdPkName
        '        End If
        '    End If
        'End If

        ''--- Delete-----'
        'If dgvAF.Columns(e.ColumnIndex).Name = ColDel.Name Then

        '    'ADD TO dgvBF
        '    With dgvBF
        '        Dim rc As Integer = dgvBF.RowCount
        '        .Rows.Add()
        '        .Rows(rc).Cells("ColNum_Up").Value = rc + 1
        '        .Rows(rc).Cells("ColidPromotion").Value = dgvAF.Rows(e.RowIndex).Cells("ColidPromotionR").Value
        '        ' .Rows(rc).Cells("ColidSale").Value = dgvAF.Rows(e.RowIndex).Cells("ColidSaleR").Value
        '        '  .Rows(rc).Cells("ColidCus").Value = dgvAF.Rows(e.RowIndex).Cells("ColidCusR").Value
        '        '   .Rows(rc).Cells("ColidPsSale").Value = dgvAF.Rows(e.RowIndex).Cells("ColidPsSaleR").Value
        '        .Rows(rc).Cells("ColProName").Value = dgvAF.Rows(e.RowIndex).Cells("ColProNameR").Value
        '        .Rows(rc).Cells("ColProType").Value = dgvAF.Rows(e.RowIndex).Cells("ColProTypeR").Value
        '        .Rows(rc).Cells("ColidProType").Value = dgvAF.Rows(e.RowIndex).Cells("ColidProTypeR").Value
        '        .Rows(rc).Cells("ColCondition").Value = dgvAF.Rows(e.RowIndex).Cells("ColConditionR").Value

        '        'Dim test As Integer = dgvBF.Rows(e.RowIndex).Cells("ColidProType").Value
        '        If .Rows(rc).Cells("ColidProType").Value <> 3 Then 'ไม่ใช่สินค้าบริษัท
        '            .Rows(rc).Cells("ColInvname").Value = dgvAF.Rows(e.RowIndex).Cells("ColInvnameR").Value
        '            .Rows(rc).Cells("ColidInv").Value = dgvAF.Rows(e.RowIndex).Cells("ColidInvR").Value
        '        Else 'สินค้าบริษัท
        '            .Rows(rc).Cells("ColInvname").Value = "สินค้าที่ผูกกับโปรโมชั่น"
        '        End If

        '        .Rows(rc).Cells("ColCntAmt").Value = dgvAF.Rows(e.RowIndex).Cells("ColCntAmtR").Value
        '        .Rows(rc).Cells("ColInvUnit").Value = dgvAF.Rows(e.RowIndex).Cells("ColInvUnitR").Value

        '        .Rows(rc).Cells("ColCdtPrice").Value = dgvAF.Rows(e.RowIndex).Cells("ColCdtPriceR").Value
        '        .Rows(rc).Cells("ColCdtAmount").Value = dgvAF.Rows(e.RowIndex).Cells("ColCdtAmountR").Value
        '        .Rows(rc).Cells("ColCdtMin").Value = dgvAF.Rows(e.RowIndex).Cells("ColCdtMinR").Value
        '        .Rows(rc).Cells("ColCdtMax").Value = dgvAF.Rows(e.RowIndex).Cells("ColCdtMaxR").Value
        '        .Rows(rc).Cells("ColCdtUnit").Value = dgvAF.Rows(e.RowIndex).Cells("ColCdtUnitR").Value
        '    End With

        '    'DELETE FROM dgvBF
        '    dgvAF.Rows.Remove(dgvAF.CurrentRow)
        '    ksbCountRowDgv(dgvAF, ColNumR.Name)

        'End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'For i As Integer = 0 To dgvAF.Rows.Count - 1
        '    'Sent Value Back For Insert
        '    Dim rc As Integer = ProInsert.Rows.Count
        '    ProInsert.Rows.Add()
        '    ProInsert.Rows(rc)("idPromotion") = dgvAF.Rows(i).Cells("ColidPromotionR").Value
        '    ProInsert.Rows(rc)("CdtPrice") = dgvAF.Rows(i).Cells("ColCdtPriceR").Value
        '    ProInsert.Rows(rc)("CdtAmount") = dgvAF.Rows(i).Cells("ColCdtAmountR").Value
        '    ProInsert.Rows(rc)("CdtMin") = dgvAF.Rows(i).Cells("ColCdtMinR").Value
        '    ProInsert.Rows(rc)("CdtMax") = dgvAF.Rows(i).Cells("ColCdtMaxR").Value
        '    ProInsert.Rows(rc)("CdtUnit") = dgvAF.Rows(i).Cells("ColCdtUnitR").Value
        '    ProInsert.Rows(rc)("idInv") = dgvAF.Rows(i).Cells("ColidInvR").Value
        '    ProInsert.Rows(rc)("idProType") = dgvAF.Rows(i).Cells("ColidProTypeR").Value
        '    ProInsert.Rows(rc)("AmountFree") = dgvAF.Rows(i).Cells("ColCntAmtR").Value
        '    ProInsert.Rows(rc)("FreeUnit") = dgvAF.Rows(i).Cells("ColInvUnitR").Value
        'Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Dim vFrm As New frmMkPromotionCustomerSelect
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPsCus.Tag = vFrm.idCus
            Me.lblPsCus.Text = vFrm.CusName
            BindData()
            'BindGetPro()
        End If

    End Sub

    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        'BindGetPro()
        BindData()
    End Sub

End Class