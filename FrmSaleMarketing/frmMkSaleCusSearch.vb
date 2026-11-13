Public Class frmMkSaleCusSearch

    Private Sub frmMkSaleCusSerch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbProvinceS()
    End Sub

    Private Sub btnFing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim vFrm As New frmPdTSerach(frmPdTSerach.eProcess.eAll)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblPdPkName.Tag = vFrm.idPdT
            Me.lblPdPkName.Text = vFrm.PdTName
        End If
    End Sub

    Private Sub CmbProvinceS()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select PvName, idPv From dProvinceFixSale Order By PvName ASC"
        sAdapter.Fill(sDt)
        With CmbPv
            .DisplayMember = "PvName"
            .ValueMember = "idPv"
            .DataSource = sDt
        End With
    End Sub

    Private Sub CmbApS()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select ApName, idAp From dAp WHERE idPv = '" & CmbPv.SelectedValue & "' " & _
                               "Order By ApName ASC"
        sAdapter.Fill(sDt)
        With CmbAp
            .DisplayMember = "ApName"
            .ValueMember = "idAp"
            .DataSource = sDt
        End With
    End Sub

    Private Sub ChkAp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAp.CheckedChanged
        If Me.ChkAp.Checked = True Then
            Me.cmbAp.Enabled = True
        Else
            Me.cmbAp.Enabled = False
        End If
    End Sub

    Private Sub CmbPv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPv.SelectedIndexChanged
        CmbApS()
    End Sub

    Private Sub btnSchPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchPd.Click
        mdLoadShow()
        BindData()
        'SumTotal()
        mdLoadCommitt()
    End Sub

    Sub BindData()
        Dim vWhere As String = ""

        If Me.rdbPvOnly.Checked = True Then
            vWhere = vWhere & " AND c.idPv = " & Me.CmbPv.SelectedValue & ""

        End If

        If Me.ChkAp.Checked = True Then
            vWhere = vWhere & " AND c.idAp = " & Me.cmbAp.SelectedValue & ""
        End If


        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT idCus, CusName, MAX(DateSale) AS LastDateSale, ApName, " & _
                               "ProvinceName, Tel FROM  (Select TOP 100 PERCENT mt.idCus, mt.CusName, " & _
                               "mt.DateSale, c.ApName, c.ProvinceName, c.Tel From SmSaleDt dt LEFT OUTER JOIN " & _
                               "vSmSalemt mt ON dt.idSale = mt.idSale LEFT OUTER JOIN vCustomer c " & _
                               "ON mt.idCus = c.idCus LEFT OUTER JOIN vPackingPdSet p ON dt.idPdPk = p.idPdPk " & _
                               "WHERE mt.idPsCancel Is NULL AND mt.idCus IS NOT NULL AND mt.idComp = " & sIdComp & " " & _
                               "AND p.idPdT = " & Me.lblPdPkName.Tag & vWhere & " Order By mt.DateSale DESC) " & _
                               "AS derivedtbl_1 GROUP BY idCus , CusName, ApName, " & _
                               "ProvinceName, Tel  ORDER BY LastDateSale DESC"  
        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบร้านค้าที่จำหน่าย " & Me.lblPdPkName.Text, sSystemName)
            dgvCus.DataSource = sDt
            Exit Sub
        Else
            dgvCus.DataSource = sDt
            ksbCountRowDgv(dgvCus, ColNum.Name)
            mdConvertDateInGrid(dgvCus, ColDateSale)
        End If

    End Sub

    Private Sub dgvCus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCus.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvCus.Columns(e.ColumnIndex).Name = ColBill.Name Then
            Dim vFrm As New frmMkSaleCusSearchBill(frmMkSaleCusSearchBill.eProcess.eView, Me.lblPdPkName.Tag, _
            Me.lblPdPkName.Text, dgvCus.Rows(e.RowIndex).Cells("ColidCus").Value, _
            dgvCus.Rows(e.RowIndex).Cells("ColCusName").Value)
            vFrm.ShowDialog()
        End If

    End Sub


    Private Sub rdbPvOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPvOnly.CheckedChanged
        If Me.rdbPvOnly.Checked = True Then
            Me.CmbPv.Enabled = True
            Me.ChkAp.Enabled = True
        Else
            Me.CmbPv.Enabled = False
            Me.ChkAp.Checked = False
            Me.ChkAp.Enabled = False
        End If
    End Sub
End Class