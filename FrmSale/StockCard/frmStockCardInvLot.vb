Imports DevExpress.XtraSplashScreen

Public Class frmStockCardInvLot
    Dim stload As Integer = 0
    Private Sub frmStockCardInvLot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setCmbGroupComp(Me.cmbGroupComp)
        stload = 1
    End Sub

    Private Sub LoadDataWareHouse()
        mdCnOpen()
        Dim sDt As New DataTable

        sCommand.CommandText = "SELECT wh.idWh, s.WareHouseName" & vbNewLine &
                                "FROM dInvLotRefWh wh" & vbNewLine &
                                "LEFT JOIN sSWareHouse s ON wh.idWh = s.idWh" & vbNewLine &
                                "WHERE wh.idLot = " & lblLotNo.Tag
        sAdapter.Fill(sDt)
        cmbWareHouse.DataSource = sDt
        cmbWareHouse.DisplayMember = "WareHouseName"
        cmbWareHouse.ValueMember = "idWh"

    End Sub

    Private Sub BindData()
        If lblLotNo.Tag <> 0 Then
            mdCnOpen()
            Dim sDt As New DataTable
            sCommand.CommandText = "exec devsk.sp_StockCardInv " & lblLotNo.Tag
            sAdapter.Fill(sDt)

            If cbWh.Checked = True Then
                Dim dv As New DataView(sDt)
                dv.RowFilter = "idWh = " & cmbWareHouse.SelectedValue
                Dim Balance As Double = 0.0

                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i).Item("typ") = 1 Then '--Statement รับ 

                        If IsDBNull(dv.Item(i).Item("QtyIN")) Then
                            dv.Item(i).Item("QtyIN") = 0
                        End If

                        Balance = dv.Item(i).Item("QtyIN") + Balance

                    ElseIf dv.Item(i).Item("typ") = 2 Then '--Statement เบิก
                        'Balance = Math.Abs(Balance) - Math.Abs(returnCusHistory.Rows(i).Item("Credit"))

                        If IsDBNull(dv.Item(i).Item("QtyOUT")) Then
                            dv.Item(i).Item("QtyOUT") = 0
                        End If

                        Balance = Balance - dv.Item(i).Item("QtyOUT")

                    ElseIf dv.Item(i).Item("typ") = 3 Then '--Statement = ของตรวจนับ

                        If IsDBNull(dv.Item(i).Item("QtyIN")) Then
                            dv.Item(i).Item("QtyIN") = 0
                        End If


                        Balance = dv.Item(i).Item("QtyIN")


                    End If

                    dv.Item(i).Item("Bal") = Balance
                Next

                GCStockCard.DataSource = dv
            Else
                Dim Balance As Double = 0.0

                For i As Integer = 0 To sDt.Rows.Count - 1
                    If sDt.Rows(i).Item("typ") = 1 Then '--Statement รับ 

                        If IsDBNull(sDt.Rows(i).Item("QtyIN")) Then
                            sDt.Rows(i).Item("QtyIN") = 0
                        End If

                        Balance = Math.Abs(sDt.Rows(i).Item("QtyIN")) + Balance

                    ElseIf sDt.Rows(i).Item("typ") = 2 Then '--Statement เบิก
                        If IsDBNull(sDt.Rows(i).Item("QtyOUT")) Then
                            sDt.Rows(i).Item("QtyOUT") = 0
                        End If

                        Balance = Balance - Math.Abs(sDt.Rows(i).Item("QtyOUT"))

                    ElseIf sDt.Rows(i).Item("typ") = 3 Then '--Statement = ของตรวจนับ
                        If IsDBNull(sDt.Rows(i).Item("QtyIN")) Then
                            sDt.Rows(i).Item("QtyIN") = 0
                        End If

                        Balance = Math.Abs(sDt.Rows(i).Item("QtyIN"))
                    End If

                    sDt.Rows(i).Item("Bal") = Balance
                Next

                GCStockCard.DataSource = sDt
            End If
        End If
    End Sub

    Private Sub btnLotNo_Click(sender As Object, e As EventArgs) Handles btnLotNo.Click
        Dim dt As New DataTable
        Dim vFrm As New FrmInvLotSelectAll(FrmInvLotSelectAll.eProcess.eSelectOne, cmbGroupComp.SelectedValue, dt, cmbGroupComp.Text)

        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblLotNo.Tag = vFrm.sdt_idLot
            lblLotNo.Text = vFrm.sdt_LotNo

            lblLot.Text = "Lot No.: " & vFrm.sdt_LotNo
            lblInvName.Text = "รายการสต็อกการ์ด : " & vFrm.sdt_InvName

            cbWh.Enabled = True
            LoadDataWareHouse()

            mdLoadShow()
            BindData()
            mdLoadCommitt()

        End If
    End Sub

    Private Sub BandedGridView1_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles BandedGridView1.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub cbComp_CheckedChanged(sender As Object, e As EventArgs) Handles cbWh.CheckedChanged
        If Me.cbWh.Checked = True Then
            Me.cmbWareHouse.Enabled = True
        Else
            Me.cmbWareHouse.Enabled = False
        End If

        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub cmbWareHouse_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbWareHouse.SelectedValueChanged
        mdLoadShow()
        BindData()
        mdLoadCommitt()
    End Sub

    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        If stload = 1 Then
            lblLotNo.Tag = 0
            lblLotNo.Text = ""
            lblInvName.Text = "รายการสต็อกการ์ด : -"
            lblLot.Text = "Lot No.: -"
            cbWh.Checked = False
            cbWh.Enabled = False
            Dim tempDt As New DataTable

            GCStockCard.DataSource = tempDt
        End If
    End Sub

End Class