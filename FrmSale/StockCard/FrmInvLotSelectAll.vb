Imports DevExpress.XtraEditors.Repository
Imports System.Net
Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports System.Drawing


Public Class FrmInvLotSelectAll

    Dim idcomp As Integer
    Dim eEvent As eProcess
    Public sDt_LotGet As DataTable
    Public sDt_LotGetWh As DataTable
    Public sdt_idLot As Integer = 0
    Public sdt_LotNo As String = ""
    Public sdt_idInvMain As Integer = 0

    Public sdt_InvName As String = ""


    Enum eProcess
        eSelect
        eSelectOne
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal GetidComp As Integer, ByRef dt As DataTable, ByVal GetCompName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eSelect
                Me.Text = "รายการสต็อกวัสดุ/สินค้า ของ" & GetCompName
            Case eProcess.eSelectOne
                Me.Text = "รายการสต็อกวัสดุ และสินค้า" & GetCompName
                Select_Button.Visible = True
                Select_check.Visible = False
                btn_save.Visible = False
                Col_WareHouseName.Visible = False
                CHKWh.Visible = False
                cmbWhFrom.Visible = False
                'Col_Amount.Visible = False
        End Select

        sDt_LotGet = dt
        If Not sDt_LotGet Is Nothing Then sDt_LotGetWh = sDt_LotGet.Copy
        eEvent = aProcess
        idcomp = GetidComp

    End Sub



    Private Sub FrmInvLotSelect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GetDataType()
        'If eEvent = eProcess.eSelect Then
        '    BindData()
        '    Col_InvGroupName.GroupIndex = 0
        '    Col_InvName.GroupIndex = 1
        '    GridView1.ExpandGroupLevel(0)

        'Else
        '    BindDataOne()
        'End If
        SetWhFrom(Me.cmbWhFrom)
        BindData()
        Col_InvName.GroupIndex = 1
        txtLotNum.Focus()
    End Sub

    Private Sub initDataTabla(sender As Object)
        sender.Columns.Add("idPkDetail", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idInv", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idlot", System.Type.GetType("System.Int32"))
        sender.Columns.Add("pkDetailName", System.Type.GetType("System.String"))
        sender.Columns.Add("UnitName", System.Type.GetType("System.String"))
        sender.Columns.Add("PricePerUnit", System.Type.GetType("System.Double"))
        sender.Columns.Add("amount", System.Type.GetType("System.Double"))
        sender.Columns.Add("price", System.Type.GetType("System.Double"))
        sender.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
        sender.Columns.Add("idSubType", System.Type.GetType("System.Int32"))
    End Sub

    Private Sub GetDataType()

        mdCnOpen()

        Dim sDt2 As New DataTable

        sCommand.CommandText = "SELECT distinct mn.idInvGroup, grp.InvGroupName  " &
        " FROM dInvLotRefWh lotrf " &
        " LEFT  JOIN dInvLotMain lotmn ON lotrf.idLot = lotmn.idLot " &
        " LEFT JOIN dInventoryMain mn on lotmn.idInvMain = mn.idInvMain" &
        " LEFT JOIN dInvGroup grp ON mn.idInvGroup = grp.idInvGroup" &
        " WHERE mn.stActive Is nuLL And lotrf.Amount > 0 And lotmn.stDel Is NULL And lotmn.CompRec = " & idcomp &
        " Order by grp.InvGroupName"


        sAdapter.Fill(sDt2)
        With cmbType
            .DisplayMember = "InvGroupName"
            .ValueMember = "idInvGroup"
            .DataSource = sDt2
        End With



    End Sub

    Private Sub BindData()
        mdCnOpen()
        mdLoadShow()

        Dim vWhere As String = ""
        Dim vWhere2 As String = ""
        Dim vWhere3 As String = ""

        If Not sDt_LotGetWh Is Nothing Then
            If sDt_LotGetWh.Rows.Count >= 1 Then
                Dim sumsql0 As String = ""
                For i As Integer = 0 To sDt_LotGetWh.Rows.Count - 1
                    sumsql0 &= sDt_LotGetWh.Rows(i).Item("idRefLot") & ","
                Next
                vWhere &= "AND  idRefLot NOT IN (" & sumsql0.Substring(0, sumsql0.Length - 1) & ") "
            End If


        End If

        Dim sDt As New DataTable("t1")

        If idcomp = 10 Or idcomp = 4 Then 'ST/AV
            vWhere = vWhere & " AND (lm.CompRec = 4 OR lm.CompRec = " & idcomp & ") "
        Else
            vWhere = vWhere & " AND lm.CompRec = " & idcomp & " "
        End If

        If eEvent = eProcess.eSelect Then

            If CBLot.Checked = True Then
                vWhere2 &= "AND lf.Amount = 0"
            Else
                vWhere2 &= "AND lf.Amount > 0"

            End If

            sCommand.CommandText = "SELECT DISTINCT cast(0 as bit) as  CheckPd,lm.idLot as idLotMain,idRefLot,lm.LotNo,itm.idInvGroup,ug.InvGroupName " & vbNewLine &
                                 ",lm.idInvMain,itm.InvName,lf.Amount,0 as AmountOperate,0 as AmountAfter,lf.idUnit,un.UnitName,lf.idwh,wh.WareHouseName " & vbNewLine &
                                 "from  dInvLotRefwh lf " & vbNewLine &
                                 "left join dInvLotMain lm on lf.idLot=lm.idlot " & vbNewLine &
                                 "left join dInventoryMain itm on lm.idInvMain=itm.idInvMain " & vbNewLine &
                                 "left join dInvUnit un on lf.idUnit=un.idUnit " & vbNewLine &
                                 "left join dInvGroup ug on itm.idInvGroup=ug.idInvGroup  " & vbNewLine &
                                 "left join SsWarehouse wh on lf.idWh=wh.idWh  " & vbNewLine &
                                 "WHERE (lm.stDel  = 0 OR lm.stDel IS NULL) " & vWhere + vWhere2 & " Order by UnitName"
            sAdapter.Fill(sDt)

        Else
            If CBLot.Checked = True Then
                vWhere2 &= "AND lf.Amount = 0"
                vWhere3 &= "AND tb.Amount = 0"
            Else
                vWhere2 &= "AND lf.Amount > 0"
                vWhere3 &= "AND tb.Amount > 0"

            End If

            sCommand.CommandText = "SELECT cast(0 as bit) as  CheckPd, tb.idLotMain, tb.LotNo, tb.idInvGroup, tb.InvGroupName," & vbNewLine &
                             "   tb.idInvMain, tb.InvName, tb.Amount, tb.idUnit, tb.UnitName FROM(" & vbNewLine &
                             " SELECT lm.idLot as idLotMain, lm.LotNo,itm.idInvGroup,ug.InvGroupName, " & vbNewLine &
                             " lm.idInvMain, itm.InvName, ISNULL(SUM(lf.Amount), 0.00) As Amount, lf.idUnit,un.UnitName " & vbNewLine &
                             " from  dInvLotRefwh lf " & vbNewLine &
                             " left join dInvLotMain lm on lf.idLot=lm.idlot" & vbNewLine &
                             " left join dInventoryMain itm on lm.idInvMain=itm.idInvMain  " & vbNewLine &
                             " left join dInvUnit un on lf.idUnit=un.idUnit  " & vbNewLine &
                             " left join dInvGroup ug on itm.idInvGroup=ug.idInvGroup " & vbNewLine &
                             " WHERE (ISNULL(lm.stDel, 0) = 0) " & vWhere + vWhere2 & "" & vbNewLine &
                             "  Group BY  lm.idLot, lm.LotNo,itm.idInvGroup,ug.InvGroupName, " & vbNewLine &
                             "   lm.idInvMain, itm.InvName, lf.idUnit,un.UnitName) As tb WHERE 1=1" + vWhere3 & vbNewLine &
                             " Order by tb.InvName"
            sAdapter.Fill(sDt)

        End If




        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCount.Text = ("0")
            Exit Sub
        Else
            txtCount.Text = Format(sDt.Rows.Count, "#,##0")
        End If
        sDt_LotGet = sDt.Copy
        'sDt_LotGet.Clear()

        GridControl1.DataSource = sDt

        FilterGridview()

        mdLoadCommitt()
        Me.ChkPd.Focus()

    End Sub


    'Private Sub BindDataOne()
    '    mdCnOpen()
    '    mdLoadShow()




    '    'sDt.Clear()


    '    Dim sDt As New DataTable("t1")
    '    sCommand.CommandText = "SELECT DISTINCT cast(0 as bit) as  CheckPd,lm.idLot as idLotMain,lm.LotNo,itm.idInvGroup,ug.InvGroupName " & vbNewLine & _
    '                         ",lm.idInvMain,itm.InvName,itm.idUnit,un.UnitName " & vbNewLine & _
    '                         "from  dInvLotMain  lm " & vbNewLine & _
    '                         "left join dInventoryMain itm on lm.idInvMain=itm.idInvMain " & vbNewLine & _
    '                         "left join dInvUnit un on itm.idUnit=un.idUnit " & vbNewLine & _
    '                         "left join dInvGroup ug on itm.idInvGroup=ug.idInvGroup  " & vbNewLine & _
    '                         "WHERE (lm.stDel  = 0 OR lm.stDel IS NULL) AND lm.CompRec = " & idcomp & " Order by InvName"
    '    sAdapter.Fill(sDt)



    '    If sDt.Rows.Count = 0 Then
    '        mdLoadCommitt()
    '        MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        txtCount.Text = ("0")
    '        Exit Sub
    '    Else
    '        txtCount.Text = Format(sDt.Rows.Count, "#,##0")
    '    End If
    '    sDt_LotGet = sDt.Copy


    '    GridControl1.DataSource = sDt
    '    FilterGridview()
    '    mdLoadCommitt()
    '    Me.ChkPd.Focus()
    'End Sub


    Private Sub FilterGridview()
        Dim StrFilter As String = "1=1"
        If ChkType.Checked = True Then
            cmbType.Enabled = True
            StrFilter &= " AND [idInvGroup] = '" & cmbType.SelectedValue & "'"
        End If



        Dim tx As String = txtPdName.Text
        Dim tx_a As String() = tx.Split(" ")
        Dim a_and As String = ""
        Dim strPdPk As String = ""
        If tx_a.Length > 0 Then
            For Each txt As String In tx_a
                If Not txt.Equals("") Then
                    strPdPk += a_and & "" & String.Format(" [InvName] Like '%{0}%' ", txt)
                End If
                a_and = " and "
            Next
        End If

        If ChkPd.Checked = True And strPdPk <> "" Then
            StrFilter &= " AND " & strPdPk
        End If


        Dim tx2 As String = txtLotNum.Text
        Dim tx_b As String() = tx2.Split(" ")
        Dim b_and As String = ""
        Dim strLotNum As String = ""
        If tx_b.Length > 0 Then
            For Each txt2 As String In tx_b
                If Not txt2.Equals("") Then
                    strLotNum += b_and & "" & String.Format(" [LotNo] Like '%{0}%' ", txt2)
                End If
                b_and = " and "
            Next
        End If




        If CHKLotNum.Checked = True And strLotNum <> "" Then
            StrFilter &= " AND " & strLotNum
        End If




        If CHKWh.Checked = True Then
            StrFilter &= " AND " & String.Format(" [idwh] = {0} ", cmbWhFrom.SelectedValue)
            'StrFilter &= " AND [WareHouseName] = " & cmbWhFrom.Text
        End If







        'If ChkPd.Checked = True Then
        '    StrFilter &= "AND [InvName] like '%" & txtPdName.Text & "%'"

        'End If

        'If CHKLotNum.Checked = True Then
        '    StrFilter &= "AND [LotNo] like '%" & txtLotNum.Text & "%'"

        'End If


        GridView1.ActiveFilterString = StrFilter



        If cbType.Checked = True Then
            Col_InvGroupName.GroupIndex = 0
            If cbPdName.Checked = True Then
                Col_InvName.GroupIndex = 1
                If cpLotNo.Checked = True Then
                    Col_LotNo.GroupIndex = 2
                    GridView1.ExpandAllGroups()
                    Exit Sub
                End If

                GridView1.ExpandGroupLevel(0)
            End If
            If cpLotNo.Checked = True Then
                Col_LotNo.GroupIndex = 1

            End If

            If CHKLotNum.Checked = True Then
                Col_InvGroupName.GroupIndex = 0
                Col_InvName.GroupIndex = 1
                GridView1.ExpandAllGroups()

            End If
        End If

        If CHKLotNum.Checked = True Then
            GridView1.ExpandAllGroups()

        End If



        txtCount.Text = Format(GridView1.DataRowCount, "#,##0")



    End Sub


    Private Sub ChkType_CheckedChanged(sender As Object, e As EventArgs) Handles ChkType.CheckedChanged
        If ChkType.Checked = True Then
            cmbType.Enabled = True

        Else
            cmbType.Enabled = False
        End If
        FilterGridview()
    End Sub

    Private Sub ChkPd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPd.CheckedChanged, CHKLotNum.CheckedChanged, CHKWh.CheckedChanged
        Select Case sender.Name

            Case ChkPd.Name
                If ChkPd.Checked = True Then
                    txtPdName.Enabled = True
                    txtPdName.Focus()
                Else
                    txtPdName.Enabled = False
                    txtPdName.Text = ""
                    GridView1.CollapseAllGroups()


                End If
            Case CHKLotNum.Name
                If CHKLotNum.Checked = True Then
                    txtLotNum.Enabled = True
                    txtLotNum.Focus()
                    'GridView1.ExpandAllGroups()

                Else
                    txtLotNum.Enabled = False
                    txtLotNum.Text = ""
                    Col_InvName.GroupIndex = 0
                    GridView1.CollapseAllGroups()
                End If

            Case CHKWh.Name
                If CHKWh.Checked = True Then
                    cmbWhFrom.Enabled = True

                Else
                    cmbWhFrom.Enabled = False
                End If
                FilterGridview()

        End Select

    End Sub


    Private Sub cmbType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedValueChanged


        FilterGridview()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        sDt_LotGet.Clear()
        If GridView1.RowCount = 0 Then
            Exit Sub
        Else
            Dim count As Integer = 0
            For Each dr As DataRow In CType(GridControl1.DataSource, DataTable).Select("CheckPd=True")

                'sCommand.CommandText = "SELECT DISTINCT cast(0 as bit) as  CheckPd,lm.idLot,idRefLot,lm.LotNo,itm.idInvGroup,ug.InvGroupName " & vbNewLine & _
                '           ",lm.idInvMain,itm.InvName,lf.Amount,lf.idUnit,un.UnitName,lf.idwh,wh.WareHouseName " & vbNewLine & _
                '           "from  dInvLotRefwh lf " & vbNewLine & _
                '           "left join dInvLotMain lm on lf.idLot=lm.idlot " & vbNewLine & _
                '           "left join dInventoryMain itm on lm.idInvMain=itm.idInvMain " & vbNewLine & _
                '           "left join dInvUnit un on lf.idUnit=un.idUnit " & vbNewLine & _
                '           "left join dInvGroup ug on itm.idInvGroup=ug.idInvGroup  " & vbNewLine & _
                '           "left join SsWarehouse wh on lf.idWh=wh.idWh  " & vbNewLine & _
                '           "WHERE (lm.stDel  = 0 OR lm.stDel IS NULL) AND lm.CompRec = " & idcomp & " " & vWHERE & " Order by UnitName"
                'sAdapter.Fill(sDt)


                Dim R As DataRow = sDt_LotGet.NewRow
                R("idLotMain") = dr.Item("idLotMain")
                R("idRefLot") = dr.Item("idRefLot")
                R("LotNo") = dr.Item("LotNo")
                R("idInvGroup") = dr.Item("idInvGroup")
                R("InvGroupName") = dr.Item("InvGroupName")
                R("idInvMain") = dr.Item("idInvMain")
                R("InvName") = dr.Item("InvName")
                R("Amount") = dr.Item("Amount")
                R("AmountOperate") = dr.Item("AmountOperate")
                R("AmountAfter") = dr.Item("AmountAfter")
                R("idUnit") = dr.Item("idUnit")
                R("UnitName") = dr.Item("UnitName")
                R("idwh") = dr.Item("idwh")
                R("WareHouseName") = dr.Item("WareHouseName")

                sDt_LotGet.Rows.Add(R)



                count = count + 1
            Next

            If count < 1 Then
                MessageBox.Show("กรุณาเลือกรายการ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            Else

                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub


    Private Sub txtPdName_TextChanged(sender As Object, e As EventArgs) Handles txtPdName.TextChanged
        FilterGridview()
    End Sub

    Private Sub txtLotNum_TextChanged(sender As Object, e As EventArgs) Handles txtLotNum.TextChanged
        FilterGridview()
        GridView1.ExpandAllGroups()

    End Sub


    Private Sub cbType_CheckedChanged(sender As Object, e As EventArgs) Handles cbType.CheckedChanged, cbPdName.CheckedChanged, cpLotNo.CheckedChanged
        Select Case sender.name
            Case cbType.Name
                If cbType.Checked = True Then
                    Col_InvGroupName.GroupIndex = 0
                    If cbPdName.Checked = True Then
                        Col_InvName.GroupIndex = 1
                        If cpLotNo.Checked = True Then
                            Col_LotNo.GroupIndex = 2
                            Exit Select

                        End If
                    End If
                    If cpLotNo.Checked = True Then
                        Col_LotNo.GroupIndex = 1

                        Exit Select

                    End If
                End If
            Case cbPdName.Name
                If cbPdName.Checked = True Then
                    If cbType.Checked = True Then
                        Col_InvGroupName.GroupIndex = 0
                    End If
                    If cbPdName.Checked = True Then
                        Col_InvName.GroupIndex = 1
                        If cpLotNo.Checked = True Then
                            Col_LotNo.GroupIndex = 2
                            Exit Select
                        End If
                    End If
                    If cpLotNo.Checked = True Then
                        Col_LotNo.GroupIndex = 1
                        Exit Select
                    End If
                End If
            Case cpLotNo.Name
                If cpLotNo.Checked = True Then
                    If cbType.Checked = True Then
                        Col_InvGroupName.GroupIndex = 0
                        GridView1.ExpandAllGroups()

                    End If
                    If cbPdName.Checked = True Then
                        Col_InvName.GroupIndex = 1
                        If cpLotNo.Checked = True Then
                            Col_LotNo.GroupIndex = 2
                            Exit Select
                        End If
                    End If
                    If cpLotNo.Checked = True Then
                        Col_LotNo.GroupIndex = 1
                        Exit Select
                    End If
                End If

        End Select





        If cbType.Checked = False Then
            Col_InvGroupName.GroupIndex = -1
        End If
        If cbPdName.Checked = False Then
            Col_InvName.GroupIndex = -1
        End If
        If cpLotNo.Checked = False Then
            Col_LotNo.GroupIndex = -1
        End If

    End Sub


    Private Sub btnSchPd_Click(sender As Object, e As EventArgs) Handles btnSchPd.Click
        BindData()
    End Sub

    Private Sub ButtonPd_Click(sender As Object, e As EventArgs) Handles ButtonPd.Click
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

        sdt_idLot = dr.Item("idLotMain")
        sdt_LotNo = dr.Item("LotNo")
        sdt_InvName = dr.Item("InvName")
        sdt_idInvMain = dr.Item("idInvMain")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub CBLot_CheckedChanged(sender As Object, e As EventArgs) Handles CBLot.CheckedChanged
        BindData()
        If CHKLotNum.Checked = True Then
            GridView1.ExpandAllGroups()
        Else
            GridView1.CollapseAllGroups()

        End If
    End Sub

    Private Sub SetWhFrom(ByVal cCombobox As Object)

        mdCnOpen()
        mdLoadShow()

        Dim WhFromDt As New DataTable

        sCommand.CommandText = "SELECT idWh,WareHouseName FROM ssWareHouse WHERE idComp = " & idcomp & " AND stParrent = 1  AND stApprove = 1  and stdel = 0 AND StData=0 "
        sAdapter.Fill(WhFromDt)

        cCombobox.DataSource = WhFromDt
        cCombobox.DisplayMember = "WareHouseName"
        cCombobox.ValueMember = "idWh"

        cCombobox.SelectedItem = 1

        mdLoadCommitt()


    End Sub



    Private Sub cmbWhFrom_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbWhFrom.SelectedValueChanged
        FilterGridview()
    End Sub

End Class