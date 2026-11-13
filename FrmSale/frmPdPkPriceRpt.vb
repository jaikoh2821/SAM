Public Class frmPdPkPriceRpt

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        mdLoadShow()
        Dim list_idSeed As New List(Of Integer)
        Dim list_SeedName As New List(Of String)

        For i As Integer = 0 To DGV.Rows.Count - 1
            With DGV.Rows(i)
                If .Cells(col_chk.Name).Value = True Then
                    list_idSeed.Add(.Cells(colidseed.Name).Value)
                    list_SeedName.Add(.Cells(colSeedName.Name).Value)
                End If
            End With
        Next

        Dim seed As String = ""
        Dim MyTable As New DataTable
        MyTable.Clear()

        Dim MyTable2 As New DataTable
        MyTable2.Clear()

        mdCnOpen()
        If Me.rad_seed.Checked Then

            If list_idSeed.Count = 0 Then
                MessageBox.Show("กรุณาเลือกประเภทพืชที่ต้องการ", sSystemName)
                Exit Sub
            End If

            If Me.rad_type1.Checked = True Then
                Dim str As String, Where_id As String
                str = "Select PdTradeName,PlantTypeName,PlantName,Trademark,PkUnitName,Weight,UnitW,PriceRetail,PriceBill,PriceWholesale From vPackingPdset "
                Where_id = " Where "
                Dim vWhere As String = ""

                For i As Integer = 0 To list_idSeed.Count - 1
                    vWhere = vWhere + "idPlant=" & Convert.ToString(list_idSeed.Item(i))
                    If i = list_idSeed.Count - 1 Then
                        '
                    Else
                        vWhere = vWhere + " Or "
                    End If
                Next
                sCommand.CommandText = str + Where_id + vWhere + " Order By Weight"
                sAdapter.Fill(MyTable)
                MyTable.Columns.Add("TradeNamemark", GetType(String))
                For Each vDr As DataRow In MyTable.Rows
                    vDr("TradeNamemark") = vDr("PdTradeName").ToString + " " + vDr("Trademark").ToString
                Next


                For i As Integer = 0 To list_idSeed.Count - 1
                    seed = seed + list_SeedName.Item(i)
                    If i = list_idSeed.Count - 1 Then
                        '
                    Else
                        seed = seed + " , "
                    End If
                Next
            End If

            If Me.rad_type2.Checked = True Then
                Dim str As String, Where_id As String
                str = "Select PdTradeName,PlantTypeName,PlantName,PkUnitName,Weight,UnitW,PriceRetail,PriceBill,PriceWholesale,PdPkName From vPackingPdset "
                Where_id = " Where "
                Dim vWhere As String = ""

                For i As Integer = 0 To list_idSeed.Count - 1
                    vWhere = vWhere + "idPlant=" & Convert.ToString(list_idSeed.Item(i))
                    If i = list_idSeed.Count - 1 Then
                        '
                    Else
                        vWhere = vWhere + " Or "
                    End If
                Next
                sCommand.CommandText = str + Where_id + vWhere + " Order By Weight"
                sAdapter.Fill(MyTable2)

                For i As Integer = 0 To list_idSeed.Count - 1
                    seed = seed + list_SeedName.Item(i)
                    If i = list_idSeed.Count - 1 Then
                        '
                    Else
                        seed = seed + " , "
                    End If
                Next
            End If
        End If


        If Me.rad_all.Checked Then
            If Me.rad_type1.Checked = True Then
                sCommand.CommandText = "Select PdTradeName,PlantTypeName,PlantName,Trademark,PkUnitName,Weight,UnitW,PriceRetail,PriceBill,PriceWholesale From vPackingPdset Order By Weight"
                sAdapter.Fill(MyTable)
                MyTable.Columns.Add("TradeNamemark", GetType(String))

                For Each vDr As DataRow In MyTable.Rows
                    vDr("TradeNamemark") = vDr("PdTradeName").ToString + " " + vDr("Trademark").ToString
                Next

                seed = "ทุกชนิด"
            End If
            If Me.rad_type2.Checked = True Then
                sCommand.CommandText = "Select PdTradeName,PlantTypeName,PlantName,PkUnitName,Weight,UnitW,PriceRetail,PriceBill,PriceWholesale,PdPkName From vPackingPdset Order By Weight"
                sAdapter.Fill(MyTable2)
                seed = "ทุกชนิด"
            End If
        End If



        If Me.rad_type1.Checked = True Then
            Dim vFrm As New frmReportView
            Dim vRpt As New crpPdPkPrice
            vRpt.SetDataSource(MyTable)

            vRpt.SetParameterValue(vRpt.Parameter_ptSeedName.ParameterFieldName, seed)
            vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานข้อมูลราคาสินค้า")
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint)
            vFrm.crView.ReportSource = vRpt
            'vFrm.ppDisplayGroupTree = True
            vFrm.Show()

        Else
            Dim vFrm As New frmReportView
            Dim vRpt As New crpPdPkName
            vRpt.SetDataSource(MyTable2)

            vRpt.SetParameterValue(vRpt.Parameter_ptSeedName.ParameterFieldName, seed)
            vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานข้อมูลราคาสินค้า")
            vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
            vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint)
            vFrm.crView.ReportSource = vRpt
            'vFrm.ppDisplayGroupTree = True
            vFrm.Show()
        End If

        mdLoadCommitt()
    End Sub

    Private Sub frmPdPkPriceRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    Private Sub ShowData()
        Dim sDt As New DataTable
        sDt.Clear()
        mdCnOpen()
        sCommand.CommandText = "Select idSeed,SeedName From dSeed Order By SeedName"
        sAdapter.Fill(sDt)
        Me.DGV.DataSource = sDt

    End Sub

    Private Sub rad_seed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_seed.CheckedChanged
        If Me.rad_seed.Checked Then
            Me.DGV.Enabled = True
        Else
            Me.DGV.Enabled = False
        End If
    End Sub

    Private Sub combo_seed_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) < 161 Or Asc(e.KeyChar) > 240) And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub rad_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_all.CheckedChanged
        For i As Integer = 0 To DGV.Rows.Count - 1
            DGV.Rows(i).Cells(col_chk.Name).Value = False
        Next
    End Sub
End Class