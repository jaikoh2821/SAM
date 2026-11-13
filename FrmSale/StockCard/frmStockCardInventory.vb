Public Class frmStockCardInventory
    Dim Data_tabel As New DataTable("t1")
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim InvName As String = ""
    Dim strInvName As String = ""
    Dim idInvMainxLot As Integer = 0

#Region "eProcess"
    Dim eEvent As eProcess
    Dim DataT As New DataTable
    Dim idWh As Integer = 0

    Enum eProcess
        eviewData

    End Enum
#End Region


    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess

            Case eProcess.eviewData
        End Select
        eEvent = aProcess

    End Sub

    Private Sub frmCardInventory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        setCmbGroupComp(Me.cmbGroupComp)
        'GetDataWh()
        Col_DateTs.Width = 130
        col_LotNo.Width = 100
        col_WhNamw.Width = 100
        col_QtyIn.Width = 100
        col_QtyOut.Width = 100
        col_QtyBalance.Width = 100
        col_UnitName.Width = 60
    End Sub

    Private Sub Rdb_inv_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_inv.CheckedChanged, Rdb_lotmain.CheckedChanged
        If Rdb_inv.Checked = True Then
            lblInvname.Text = " "
            lblInvname.Tag = 0
            lbllotmain.Text = " "
            lbllotmain.Tag = 0
            btnLotmain.Enabled = False
            btnInv.Enabled = True
            TextName.Text = "รายการความเคลื่อนไหว :"
            CheckWh.Checked = False
            cmbWh.Enabled = False
            GBlength.Enabled = True
            Panel5.Height = 31
            LabelLot.Text = ""
            col_LotNo.Visible = True

        End If

        If Rdb_lotmain.Checked = True Then
            lblInvname.Text = " "
            lblInvname.Tag = 0
            lbllotmain.Text = " "
            lbllotmain.Tag = 0
            CheckWh.Enabled = True
            btnInv.Enabled = False
            btnLotmain.Enabled = True
            TextName.Text = "รายการความเคลื่อนไหว :"
            GBlength.Enabled = False

            Panel5.Height = 55
            LabelLot.Text = "LotNo : "
            col_LotNo.Visible = False

        Else
            CheckWh.Enabled = False
            CheckWh.Checked = False

        End If

        Data_tabel.Clear()
        GridMain.DataSource = Data_tabel

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        If Rdb_inv.Checked = True Then
            BindData(lblInvname.Tag, 0)
        Else
            BindData(lbllotmain.Tag, 0)

        End If
    End Sub


    Private Sub cmbGroupComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupComp.SelectedValueChanged
        lblInvname.Text = " "
        lblInvname.Tag = 0
        lbllotmain.Text = " "
        lbllotmain.Tag = 0
        Me.Text = "รายการความเคลื่อนไหวสต็อกวัสดุ/สินค้า " & cmbGroupComp.Text
        TextName.Text = "รายการความเคลื่อนไหว : "
        LabelLot.Text = "LotNo : "
        Data_tabel.Clear()

    End Sub

    Sub BindData(ByVal idwhere As Integer, ByVal idwhere2 As Integer)
        Dim vWhere As String = ""
        Dim vWhereX As String = ""
        mdCnOpen()
        mdLoadShow()
        Data_tabel.Clear()
        GridMain.DataSource = Data_tabel

        'If Rdb_inv.Checked = True And lblInvname.Tag <> 0 Then
        '    vWhere &= " mt.idInvMain = " & idwhere
        'ElseIf Rdb_lotmain.Checked = True And lbllotmain.Tag <> 0 Then
        '    vWhere &= " mt.idLot = " & idwhere
        'Else
        '    vWhere &= " mt.idLot = " & idwhere
        'End If

        If cmbGroupComp.SelectedValue = 10 Or cmbGroupComp.SelectedValue = 4 Then 'ST/AV
            vWhere = vWhere & " AND (dm.CompRec = 4 OR dm.CompRec = " & cmbGroupComp.SelectedValue & ") "
            vWhereX = vWhereX & " AND (l.CompRec = 4 OR l.CompRec = " & cmbGroupComp.SelectedValue & ") "
        Else
            vWhere = vWhere & " AND dm.CompRec = " & cmbGroupComp.SelectedValue & " "
            vWhereX = vWhereX & " AND l.CompRec = " & cmbGroupComp.SelectedValue & " "
        End If

        If Rdb_inv.Checked = True Then
            Dim DateNow As System.DateTime = Convert.ToDateTime(Date.Now, _cultureEnInfo)
            Dim DateRB As System.DateTime

            If rb3m.Checked = True Then
                DateRB = DateNow.AddMonths(-3)
            ElseIf rb6m.Checked = True Then
                DateRB = DateNow.AddMonths(-6)
            ElseIf rb1y.Checked = True Then
                DateRB = DateNow.AddYears(-1)
            Else
                DateRB = DateNow.AddYears(-2)
            End If

            'vWhere &= " AND mt.DateTs  BETWEEN '" & DateRB.ToString("yyyy-MM-dd", _cultureEnInfo) &
            '    "' AND '" & DateNow.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "' "

            sCommand.CommandText = "with StockCard as ( " & vbNewLine &
                                  "      SELECT 0 as idTs, NULL as DateTs,'' as InvName, 'ยอดยกมา' as SumText, 0 As idLot, '' As LotNo, " & vbNewLine &
                                  "             (SELECT TOP 1 ISNULL(c.QtyBalInv, 0.00) " & vbNewLine &
                                  "              FROm dInvLotStockCard c" & vbNewLine &
                                  "              LEFT JOIN dInvlotMain l On c.idLot = l.idLot " & vbNewLine &
                                  "              WHERE l.stDel IS NULL AND c.idInvMain = " & idwhere & vWhereX & vbNewLine &
                                  "              AND c.DateTs < '" & DateRB.ToString("yyyy-MM-dd", _cultureEnInfo) & "' Order by c.DateTs DESC) As QtyIn, NULL As QtyOut, " & vbNewLine &
                                  "             (SELECT TOP 1 ISNULL(c.QtyBalInv, 0.00) " & vbNewLine &
                                  "              FROm dInvLotStockCard c" & vbNewLine &
                                  "              LEFT JOIN dInvlotMain l On c.idLot = l.idLot " & vbNewLine &
                                  "              WHERE l.stDel IS NULL AND c.idInvMain = " & idwhere & vWhereX & vbNewLine &
                                  "              And c.DateTs < '" & DateRB.ToString("yyyy-MM-dd", _cultureEnInfo) & "' Order by c.DateTs DESC) As QtyBalance, " & vbNewLine &
                                  "              '' As WareHouseName, '' As RefTable , " & vbNewLine &
                                  "             (SELECT u.UnitName FROM dInventoryMain i " & vbNewLine &
                                  "              LEFT JOIN dInvUnit u On i.idUnit = u.idUnit WHERE i.idInvMain =  " & idwhere & ") As UnitName, '' As PsName" & vbNewLine &
                                  "      UNION " & vbNewLine &
                                  "      SELECT mt.idTs, mt.DateTs, ilm.InvName, devsk.fnDetailsStock(mt.idTs) as SumText, " & vbNewLine &
                                  "             mt.idLot, mt.LotNo, mt.QtyIn, mt.QtyOut, mt.QtyBalInv As QtyBalance, ss.WareHouseName, mt.RefTable, d.UnitName, ps.PsName" & vbNewLine &
                                  "      FROM dInvLotStockCard mt" & vbNewLine &
                                  "      LEFT JOIN dInvlotMain dm on mt.idLot = dm.idLot" & vbNewLine &
                                  "      LEFT JOIN dInVentorymain ilm ON  mt.idInvMain = ilm.idInvMain " & vbNewLine &
                                  "      LEFT JOIN ssWareHouse ss ON mt.idWh = ss.idWh " & vbNewLine &
                                  "      LEFT JOIN dInvUnit d ON d.idUnit = ilm.idUnit " & vbNewLine &
                                  "      LEFT JOIN vPersonxSelect ps ON mt.idPsts = ps.idPs  " & vbNewLine &
                                  "      WHERE mt.idInvMain =  " & idwhere & vWhere & vbNewLine &
                                  "             AND mt.DateTs  BETWEEN '" & DateRB.ToString("yyyy-MM-dd", _cultureEnInfo) & "'" & vbNewLine &
                                  "             AND '" & DateNow.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo) & "'" & vbNewLine &
                                  ")SELECT * FROM StockCard ORDER BY DateTs ASC "

        ElseIf Rdb_lotmain.Checked = True Then
            If CheckWh.Checked = True Then
                vWhere &= " AND mt.idWh = " & idwhere2
            End If

            sCommand.CommandText = "SELECT dm.CompRec,mt.DateTs  " &
                   ",ilm.InvName ,devsk.fnDetailsStock(mt.idTs) as SumText " &
                   " ,mt.idLot,mt.LotNo,mt.QtyIn,mt.QtyOut,mt.QtyBalance,ss.WareHouseName,d.UnitName,mt.RefTable,pTs.PsName " &
                   " From dInvLotStockCard mt  " &
                   " left join dInvlotMain dm on mt.idLot=dm.idLot     " & vbNewLine &
                   " LEFT JOIN dInVentorymain ilm ON  mt.idInvMain = ilm.idInvMain     " & vbNewLine &
                   " LEFT JOIN ssWareHouse ss ON mt.idWh = ss.idWh " & vbNewLine &
                   " LEFT JOIN dInvUnit d ON d.idUnit = ilm.idUnit " & vbNewLine &
                   " LEFT JOIN vPersonxSelect As pTs ON mt.idPsTs=pTs.idPs" & vbNewLine &
                   " Where mt.idLot = " & idwhere & vWhere & "order by  mt.datets ASC "

            ' " AND mt.LotNo = '" & lbllotmain.Text.Trim & "' AND mt.idInvMain = " & idInvMainxLot & vWhere & "order by  mt.datets ASC "


        End If


        sAdapter.Fill(Data_tabel)


        If Data_tabel.Rows.Count > 0 Then
            If Rdb_inv.Checked = True Or CheckWh.Checked = True Then
                InvName = lblInvname.Text

                If CheckWh.Checked = True Then
                    InvName = Data_tabel.Rows(0).Item("InvName")
                End If

                'Dim QtyBalance As Double
                'QtyBalance = Data_tabel.Rows(0).Item("QtyBalance")

                'For i As Integer = 0 To Data_tabel.Rows.Count - 1
                '    Dim dr As DataRow = Data_tabel.Rows(i)
                '    If Not IsDBNull(dr.Item("QtyIn")) Then '--กรณีเพิ่ม
                '        QtyBalance = dr.Item("QtyIn") + QtyBalance
                '        If i = 0 Then QtyBalance = QtyBalance - dr.Item("QtyIn")

                '    End If

                '    If Not IsDBNull(dr.Item("QtyOut")) Then '--กรณีเพิ่มลด 
                '        'QtyBalance = Math.Abs(QtyBalance) - Math.Abs(dr.Item("QtyOut"))
                '        QtyBalance = QtyBalance - dr.Item("QtyOut")
                '        If i = 0 Then QtyBalance = QtyBalance + dr.Item("QtyOut")

                '    End If

                '    dr.Item("QtyBalance") = QtyBalance
                'Next
            Else
                InvName = Data_tabel.Rows(0).Item("InvName")
            End If
        End If




        If CheckWh.Checked = True Then
            InvName &= " / " + cmbWh.Text
        End If


        GridMain.DataSource = Data_tabel

        GridMain.ForceInitialize()
        Data_mt.SelectRows(0, 1)
        Me.Text = "รายการความเคลื่อนไหวสต็อกวัสดุ/สินค้า " & cmbGroupComp.Text

        mdLoadCommitt()
    End Sub

#Region "Run Number Row"

    Private Sub PkPoRecMt_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles Data_mt.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

#End Region


    Private Sub btnInv_Click(sender As Object, e As EventArgs) Handles btnInv.Click
        Dim frm As New frmAllInvSelect(frmAllInvSelect.eProcess.eAll, cmbGroupComp.SelectedValue)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow = frm.sdt1.Rows(0)
            lblInvname.Text = dr.Item("pkDetailName")
            lblInvname.Tag = dr.Item("idInvMain")
            rb3m.Checked = True
            TextName.Text = "รายการความเคลื่อนไหว : " + dr.Item("pkDetailName")
            'GetDataWh()


            BindData(lblInvname.Tag, 0)
            If Data_mt.RowCount = 0 Then lbrMsg.MsgInformation("ไม่มีรายการ")

        End If


    End Sub


    Private Sub btnLotmain_Click(sender As Object, e As EventArgs) Handles btnLotmain.Click
        Dim frm As New FrmInvLotSelectAll(FrmInvLotSelectAll.eProcess.eSelectOne, cmbGroupComp.SelectedValue, DataT, cmbGroupComp.Text)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lbllotmain.Text = frm.sdt_LotNo
            lbllotmain.Tag = frm.sdt_idLot
            idInvMainxLot = frm.sdt_idInvMain
            strInvName = frm.sdt_InvName
            CheckWh.Checked = False
            rb3m.Checked = True

            TextName.Text = "รายการความเคลื่อนไหว : " + strInvName
            LabelLot.Text = "Lot No : " + frm.sdt_LotNo

            BindData(lbllotmain.Tag, 0)
            GetDataRefWH()

            If Data_mt.RowCount = 0 Then lbrMsg.MsgInformation("ไม่มีรายการ")

        End If
    End Sub

    'Private Sub GetDataWh()
    '    mdCnOpen()

    '    Dim sDt2 As New DataTable

    '    sCommand.CommandText = "SELECT idWh,WareHouseName FROM ssWareHouse WHERE idComp = " & cmbGroupComp.SelectedValue & vbNewLine &
    '                        "AND  stApprove = 1  and stdel = 0 AND StData=0 "
    '    sAdapter.Fill(sDt2)

    '    With cmbWh
    '        .DisplayMember = "WareHouseName"
    '        .ValueMember = "idWh"
    '        .DataSource = sDt2
    '    End With

    'End Sub

    Private Sub GetDataRefWH()
        mdCnOpen()
        Dim sDt2 As New DataTable
        sCommand.CommandText = "SELECT distinct wh.idWh,wh.WareHouseName FROM ssWareHouse wh " &
                              " Left join  dInvLotRefWh rw on wh.idWh =rw.idWh" &
                              " WHERE rw.idLot = " & lbllotmain.Tag & "" &
                              " AND  stApprove = 1  and stdel = 0 AND StData=0 "
        sAdapter.Fill(sDt2)

        With cmbWh
            .DisplayMember = "WareHouseName"
            .ValueMember = "idWh"
            .DataSource = sDt2
        End With

    End Sub


    Private Sub CheckWh_CheckedChanged(sender As Object, e As EventArgs) Handles CheckWh.CheckedChanged

        If CheckWh.Checked = True Then
            If lbllotmain.Tag = 0 Then
                lbrMsg.MsgInformation("กรูณาเลือกข้อมูลที่จะค้นหาก่อน ")
                CheckWh.Checked = False
                Exit Sub
            End If
            cmbWh.Enabled = True
            BindData(lbllotmain.Tag, cmbWh.SelectedValue)
            TextName.Text = "รายการสต๊อกการ์ด : " + strInvName
            LabelLot.Text = "LotNo : " + lbllotmain.Text + " " + cmbWh.Text

        Else
            If lbllotmain.Tag <> 0 Then
                'GetDataWh()
                cmbWh.Enabled = False
                BindData(lbllotmain.Tag, 0)
                TextName.Text = "รายการสต๊อกการ์ด : " + strInvName + lbllotmain.Text
                LabelLot.Text = "LotNo : " + lbllotmain.Text

                If Data_mt.RowCount = 0 Then lbrMsg.MsgInformation("ไม่มีรายการ")

            End If

        End If
    End Sub


    Private Sub cmbWh_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbWh.SelectedValueChanged
        If CheckWh.Checked = True Then
            BindData(lbllotmain.Tag, cmbWh.SelectedValue)
        End If
    End Sub



    Private Sub RepositoryItemHyperLinkEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemHyperLinkEdit1.Click
        'Dim dr As DataRow = Data_mt.GetDataRow(Data_mt.FocusedRowHandle)
        ''If   RefTable='PkPORecMt' idRecType =1รัทำรายการรับวัสดุ นอกเครือ 2นอกเครือ 3 ในเครือ    

        'Select Case dr.Item("Id")
        '    Case 3  ' dInvLotCountMt
        '    Case 8  'PkPdPkUpdateMt
        '    Case 9  'SmPdOtherUpdateMt
        '    Case 12 'PkPdLotStock
        '    Case 15 'PkPdMixPacking
        '    Case 16 'PkPdPkUpdateRec
        '    Case 18 'PkPORecMt
        '        mdLoadShow()
        '        Dim dr_Reder As SqlClient.SqlDataReader
        '        sCommand.CommandText = "SELECT vRmt.idRecType " & vbNewLine & _
        '                        " From PkPORecMt vRmt " & vbNewLine & _
        '                        " where vRmt.idPkPoRec = " & dr.Item("idRef")
        '        dr_Reder = sCommand.ExecuteReader

        '        While dr_Reder.Read
        '            idRecType = dr_Reder.Item("idRecType")

        '        End While
        '        dr_Reder.Close()




        '        If idRecType = 1 Then
        '            lbrMsg.MsgInformation("idRecType1")

        '        ElseIf idRecType = 2 Then
        '            Dim frm = New frmRecASGTs(frmRecASGTs.eProcess.eviewData)
        '            frm.idPkPORec = dr("idRef")
        '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

        '            End If

        '        Else
        '            Dim frm = New frmRecASGTs(frmRecASGTs.eProcess.eviewData)
        '            frm.idPkPORec = dr("idRef")
        '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

        '            End If
        '        End If

        '    Case 19 'SmPdoStockUpdateMt
        '    Case 20 'SmSaleMt
        '    Case 21 'SmSaleReturnMt
        '    Case 22 'SsWarehouseMoveProductMt
        '    Case 23 'vSsLotMt


        'End Select



    End Sub


    Private Sub rb3m_CheckedChanged(sender As Object, e As EventArgs) Handles rb3m.CheckedChanged
        If lblInvname.Tag = 0 And lbllotmain.Tag = 0 Then
            Exit Sub
        End If
        If rb3m.Checked = True Then
            If Rdb_inv.Checked = True Then
                BindData(lblInvname.Tag, 0)
            Else
                BindData(lbllotmain.Tag, 0)
            End If
            If Data_mt.RowCount = 0 Then lbrMsg.MsgInformation("ไม่มีรายการ")

        End If

    End Sub

    Private Sub rb6m_CheckedChanged(sender As Object, e As EventArgs) Handles rb6m.CheckedChanged
        If lblInvname.Tag = 0 And lbllotmain.Tag = 0 Then
            Exit Sub
        End If
        If rb6m.Checked = True Then
            If Rdb_inv.Checked = True Then
                BindData(lblInvname.Tag, 0)
            Else
                BindData(lbllotmain.Tag, 0)
            End If
            If Data_mt.RowCount = 0 Then lbrMsg.MsgInformation("ไม่มีรายการ")

        End If

    End Sub

    Private Sub rb1y_CheckedChanged(sender As Object, e As EventArgs) Handles rb1y.CheckedChanged
        If lblInvname.Tag = 0 And lbllotmain.Tag = 0 Then
            Exit Sub
        End If


        If rb1y.Checked = True Then
            If Rdb_inv.Checked = True Then
                BindData(lblInvname.Tag, 0)
            Else
                BindData(lbllotmain.Tag, 0)
            End If
            If Data_mt.RowCount = 0 Then lbrMsg.MsgInformation("ไม่มีรายการ")

        End If

    End Sub
End Class