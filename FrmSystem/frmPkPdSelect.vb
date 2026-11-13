Public Class frmPkPdSelect
    Public getIdPdPk, getIdUnitW, getIdPkUnit, getIdPdT, getIdPdPkBigPackage, getIdPdPkSmallPackage As Integer
    Public getPdTradeName As String
    Public getPkUnit As String
    Public getWeight, getPriceBill, getPriceWholesale, getPriceRetail As Decimal
    Public getUnitW, getBigPackageName, getSmallPackageName As String

    Private Sub frmPkPdSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Dim sDt As New DataTable
    Private Sub loadData()
        mdLoadShow()

        Dim vWhere As String = ""
        If chkPdName.Checked = True And chkPlantName.Checked = False Then
            vWhere = " WHERE dPP.stDel IS NULL AND vS.PdTradeName Like '%" & txtPdName.Text & "%' "
        ElseIf chkPdName.Checked = False And chkPlantName.Checked = True Then
            vWhere = " WHERE dPP.stDel IS NULL AND vS.PlantTypeName Like '%" & txtPlantName.Text & "%' "
        ElseIf chkPdName.Checked = True And chkPlantName.Checked = True Then
            vWhere = " WHERE dPP.stDel IS NULL AND vS.PdTradeName Like '%" & txtPdName.Text & "%' And vS.PlantTypeName Like '%" & txtPlantName.Text & "%' "
        End If

        mdCnOpen()
        sDt = New DataTable
        sCommand.CommandText = "Select vS.PlantTypeName, vS.PdTradeName, dPD.SizeName, dPP.Weight, dUW.UnitW, dPP.idPdPk, " & _
                               "dPP.PriceBill, dPP.PriceWholesale, dPP.PriceRetail, dPD.idPkUnit, dUW.idUnitW, '' As PkUnitName, dPP.idPdT " & _
                               " From vSlPdTradeNameD vS inner join dPackingPdSet As dPP ON vS.idPdT = dPP.idPdT " & _
                               " inner join dPackingDetail dPD ON dPP.idPkDetail = dPD.idPkDetail " & _
                               " inner join dUnitW dUW ON dPP.idUnitW = dUW.idUnitW " & vWhere & " Order by vS.PdTradeName ASC"
        sAdapter.Fill(sDt)

        For i As Integer = 0 To sDt.Rows.Count - 1
            Select Case sDt.Rows(i).Item("idPkUnit")
                Case 1
                    sDt.Rows(i).Item("PkUnitName") = "กระป๋อง"
                Case 2
                    sDt.Rows(i).Item("PkUnitName") = "ซอง"
                Case Else '4,6
                    sDt.Rows(i).Item("PkUnitName") = "กล่อง"
            End Select
        Next

        dgvPkPdSetList.DataSource = sDt

        mdLoadCommitt()
    End Sub

    Private Sub btnSFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFindAll.Click
        loadData()
        If dgvPkPdSetList.Rows.Count = 0 Then
            lbrMsg.MsgInformation("ไม่พบข้อมูล          ")
        End If
    End Sub

    Private Sub chkPdName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPdName.CheckedChanged
        If chkPdName.Checked = True Then
            txtPdName.Enabled = True
            txtPdName.Focus()
        Else
            txtPdName.Enabled = False
        End If
    End Sub

    Private Sub chkPlantName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlantName.CheckedChanged
        If chkPlantName.Checked = True Then
            txtPlantName.Enabled = True
            txtPlantName.Focus()
        Else
            txtPlantName.Enabled = False
        End If
    End Sub

    Private Sub txtPdName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPdName.KeyPress
        If (e.KeyChar = Chr(Keys.Enter)) Then
            loadData()
        End If
    End Sub

    Private Sub txtPlantName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlantName.KeyPress
        If (e.KeyChar = Chr(Keys.Enter)) Then
            loadData()
        End If
    End Sub

    Private Sub dgvPkPdSetList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPkPdSetList.CellContentClick
        If dgvPkPdSetList.Columns(e.ColumnIndex).Name = colSelect.Name Then

            getIdPdPk = dgvPkPdSetList.Rows(e.RowIndex).Cells(idPdPk.Name).Value
            getPdTradeName = dgvPkPdSetList.Rows(e.RowIndex).Cells(colPdTradeName.Name).Value
            getWeight = dgvPkPdSetList.Rows(e.RowIndex).Cells(colWeight.Name).Value
            getUnitW = dgvPkPdSetList.Rows(e.RowIndex).Cells(colidUnitW.Name).Value
            getPkUnit = dgvPkPdSetList.Rows(e.RowIndex).Cells(colPkUnit.Name).Value
            getPriceRetail = dgvPkPdSetList.Rows(e.RowIndex).Cells(PriceRetail.Name).Value
            getPriceBill = dgvPkPdSetList.Rows(e.RowIndex).Cells(PriceBill.Name).Value
            getPriceWholesale = dgvPkPdSetList.Rows(e.RowIndex).Cells(PriceWholesale.Name).Value
            getIdUnitW = dgvPkPdSetList.Rows(e.RowIndex).Cells(idUnitW.Name).Value
            getIdPkUnit = dgvPkPdSetList.Rows(e.RowIndex).Cells(idPkUnit.Name).Value
            getIdPdT = dgvPkPdSetList.Rows(e.RowIndex).Cells(col_idPdT.Name).Value

            'getIdPdPkBigPackage, getBigPackageName, getIdPdPkSmallPackage, getSmallPackageName
            BigOrSmallPackage()


            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BigOrSmallPackage()
        Dim dvChkMaxPackage = New DataView(sDt)
        Dim dvChkMinPackage = New DataView(sDt)

        dvChkMaxPackage.RowFilter = "idPdT=" & getIdPdT & " And idUnitW=2"

        dvChkMinPackage.RowFilter = "idPdT=" & getIdPdT & " And idUnitW=1"

        Dim Max As Double = 0
        Dim Min As Double = 0
        Dim Min_Old As Double = 0
        Dim PkUnit As String = ""

        If dvChkMaxPackage.Count > 0 Then
            For i As Integer = 0 To dvChkMaxPackage.count - 1
                If Max < dvChkMaxPackage.Item(i).Item("Weight") Then
                    Max = dvChkMaxPackage.Item(i).Item("Weight")
                    getBigPackageName = dvChkMaxPackage.Item(i).Item("PdTradeName") & " (" & dvChkMaxPackage.Item(i).Item("PkUnitName") & Max & " " & dvChkMaxPackage.Item(i).Item("UnitW") & ")"
                    getIdPdPkBigPackage = dvChkMaxPackage.Item(i).Item("idPdPk")
                End If
            Next
            If dvChkMinPackage.Count = 0 Then
                For i As Integer = 0 To dvChkMaxPackage.count - 1
                    Min_Old = dvChkMaxPackage.item(i).Item("Weight")
                    If i = 0 Then Min = dvChkMaxPackage.item(i).Item("Weight")
                    If Min_Old <= Min And dvChkMaxPackage.Count > 0 Then
                        Min = dvChkMaxPackage.item(i).Item("Weight")
                        Min_Old = dvChkMaxPackage.item(i).Item("Weight")
                        getSmallPackageName = dvChkMaxPackage.Item(i).Item("PdTradeName") & " (" & dvChkMaxPackage.Item(i).Item("PkUnitName") & Min & " " & dvChkMaxPackage.Item(i).Item("UnitW") & ")"
                        getIdPdPkSmallPackage = dvChkMaxPackage.Item(i).Item("idPdPk")
                    End If
                Next
            End If
        End If

        If dvChkMinPackage.Count > 0 Then
            For i As Integer = 0 To dvChkMinPackage.count - 1
                Min_Old = dvChkMinPackage.item(i).Item("Weight")
                If i = 0 Then Min = dvChkMinPackage.Item(i).Item("Weight")
                If Min_Old <= Min And dvChkMinPackage.Count > 0 Then
                    Min = dvChkMinPackage.item(i).Item("Weight")
                    Min_Old = dvChkMinPackage.item(i).Item("Weight")
                    getSmallPackageName = dvChkMinPackage.Item(i).Item("PdTradeName") & " (" & dvChkMinPackage.Item(i).Item("PkUnitName") & Min & " " & dvChkMinPackage.Item(i).Item("UnitW") & ")"
                    getIdPdPkSmallPackage = dvChkMinPackage.Item(i).Item("idPdPk")
                End If
            Next
            If dvChkMaxPackage.Count = 0 Then
                Max = 0
                For i As Integer = 0 To dvChkMinPackage.count - 1
                    If Max < dvChkMinPackage.Item(i).Item("Weight") Then
                        Max = dvChkMinPackage.Item(i).Item("Weight")
                        getBigPackageName = dvChkMinPackage.Item(i).Item("PdTradeName") & " (" & dvChkMinPackage.Item(i).Item("PkUnitName") & Max & " " & dvChkMinPackage.Item(i).Item("UnitW") & ")"
                        getIdPdPkBigPackage = dvChkMinPackage.Item(i).Item("idPdPk")
                    End If
                Next
            End If
        End If
    End Sub

End Class