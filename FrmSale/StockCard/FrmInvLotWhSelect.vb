
Imports DevExpress.XtraEditors.Repository
Imports System.Net
Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports System.Drawing


Public Class FrmInvLotWhSelect


    Dim idcomp As Integer
    Dim eEvent As eProcess
    Public sDt_LotGet As DataTable
    Public sDt_LotGetWh As DataTable
    Public sdt_idLot As Integer = 0
    Public sdt_InvName As String = ""
    Public sdt_idWh As Integer = 0

    Dim vWhereSelectData = "0"


    ' parameter fiter Gridview
    Dim varType As String = ""
    Dim AmtZero As String = ""
    Dim varPd As String = ""
    Dim varLotNum As String = ""
    Dim varWh As String = ""


    Enum eProcess

        eSelect



    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal GetidComp As Integer, ByRef dt As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eSelect
                Me.Text = "รายการสต็อกวัสดุ และสินค้าจากคลัง"

        End Select
        sDt_LotGet = dt
        If Not sDt_LotGet Is Nothing Then sDt_LotGetWh = sDt_LotGet.Copy
        eEvent = aProcess
        idcomp = GetidComp

    End Sub



    Private Sub FrmInvLotWhSelect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GetDataType()
        setCmbGroupComp()
        BindData()

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
        sCommand.CommandText = "SELECT idInvGroup,InvGroupName  FROM dInvGroup " & vbNewLine &
                            "where stDel  Is Null "
        sAdapter.Fill(sDt2)

        With cmbType
            .DisplayMember = "InvGroupName"
            .ValueMember = "idInvGroup"
            .DataSource = sDt2
        End With
    End Sub

    Private Sub setCmbGroupComp()

        mdCnOpen()
        Dim sDt As New DataTable

        sCommand.CommandText = " SELECT idWh,WareHouseName FROM ssWareHouse WHERE idComp = " & idcomp & "AND stParrent = 1  AND stApprove = 1  and stdel = 0 AND StData=0"
        sAdapter.Fill(sDt)


        With cmbWhName
            .DisplayMember = "WareHouseName"
            .ValueMember = "idWh"
            .DataSource = sDt
        End With

     

        mdLoadCommitt()

    End Sub



    Private Sub BindData()
        mdCnOpen()
        mdLoadShow()


        If Not sDt_LotGetWh Is Nothing Then
            If sDt_LotGetWh.Rows.Count >= 1 Then

                For i As Integer = 0 To sDt_LotGetWh.Rows.Count - 1
                    If Not IsDBNull(sDt_LotGetWh.Rows(i).Item("idRefLot")) Then
                        vWhereSelectData &= "," & sDt_LotGetWh.Rows(i).Item("idRefLot")
                    End If
                Next
            End If
        End If

        Dim vWHERE As String = "AND idRefLot NOT IN (" & vWhereSelectData & ")"



        'sDt.Clear()


        Dim sDt As New DataTable("t1")
        sCommand.CommandText = "SELECT DISTINCT cast(0 as bit) as  CheckPd,lm.idLot as idLotMain,idRefLot,lm.LotNo,itm.idInvGroup,ug.InvGroupName " & vbNewLine & _
                             ",lm.idInvMain,itm.InvName,lf.Amount,0 as AmountOperate,0 as AmountAfter,lf.idUnit,un.UnitName,lf.idwh,wh.WareHouseName " & vbNewLine & _
                             "from  dInvLotRefwh lf " & vbNewLine & _
                             "left join dInvLotMain lm on lf.idLot=lm.idlot " & vbNewLine & _
                             "left join dInventoryMain itm on lm.idInvMain=itm.idInvMain " & vbNewLine & _
                             "left join dInvUnit un on lf.idUnit=un.idUnit " & vbNewLine & _
                             "left join dInvGroup ug on itm.idInvGroup=ug.idInvGroup  " & vbNewLine & _
                             "left join SsWarehouse wh on lf.idWh=wh.idWh  " & vbNewLine & _
                             "WHERE (lm.stDel  = 0 OR lm.stDel IS NULL) AND lm.CompRec = " & idcomp & " " & vWHERE & "  Order by UnitName"
        sAdapter.Fill(sDt)



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
        ActiveFilter()
        mdLoadCommitt()
        Me.ChkPd.Focus()
    End Sub

  

    Private Sub ActiveFilter()
        'GridView1.ExpandGroupLevel(0)
        'GridView1.ActiveFilterString = "1=1" + strPlantType + strPdname + strntxt + strGrade + strGrow + strHumidt + strPure + strLotNotxt + SubNamename   
        GridView1.ActiveFilterString = "1=1" + varType + AmtZero + varPd + varLotNum + varWh

        txtCount.Text = Format(GridView1.DataRowCount, "#,##0")
    End Sub



    Private Sub ChkType_CheckedChanged(sender As Object, e As EventArgs) Handles ChkType.CheckedChanged, ChkPd.CheckedChanged, CHKLotNum.CheckedChanged
        Select Case sender.Name
            Case ChkType.Name
                If ChkType.Checked = True Then
                    cmbType.Enabled = True
                    varType = "AND [idInvGroup] = '" & cmbType.SelectedValue & "'"
                Else
                    cmbType.Enabled = False
                    varType = ""

                End If

            Case ChkPd.Name
                If ChkPd.Checked = True Then
                    txtPdName.Enabled = True
                    txtPdName.Focus()
                    varPd = "AND [InvName] like '%" & txtPdName.Text & "%'"
                Else
                    txtPdName.Enabled = False
                    txtPdName.Text = ""
                    varPd = ""

                End If
            Case CHKLotNum.Name
                If CHKLotNum.Checked = True Then
                    txtLotNum.Enabled = True
                    txtLotNum.Focus()
                    varLotNum = "AND [LotNo] like '%" & txtLotNum.Text & "%'"
                Else
                    txtLotNum.Enabled = False
                    txtLotNum.Text = ""
                    varLotNum = ""

                End If

        End Select
        ActiveFilter()

    End Sub


    Private Sub cmbType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedValueChanged, cmbWhName.SelectedValueChanged
        Select Case sender.Name
            Case cmbType.Name
                If ChkType.Checked = True Then
                    varType = "AND [idInvGroup] = '" & cmbType.SelectedValue & "'"
                End If

            Case cmbWhName.Name
                If cmbWhName.SelectedValue <> 0 Then
                    varWh = "AND [idwh] = '" & cmbWhName.SelectedValue & "'"
                End If

        End Select

        ActiveFilter()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs)
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

    Private Sub ChkAmount_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAmount.CheckedChanged
        If ChkAmount.Checked = True Then
            AmtZero = "AND [Amount] <> 0"

        Else
            AmtZero = ""

        End If
        ActiveFilter()

    End Sub


    Private Sub txtPdName_TextChanged(sender As Object, e As EventArgs) Handles txtPdName.TextChanged, txtLotNum.TextChanged
        Select Case sender.Name
            Case txtPdName.Name
                varPd = "AND [InvName] like '%" & txtPdName.Text & "%'"

            Case txtLotNum.Name
                varLotNum = "AND [LotNo] like '%" & txtLotNum.Text & "%'"

        End Select
        ActiveFilter()
        Expand()
    End Sub

    Private Sub Expand()
        If cbType.Checked = True Then
            Col_InvGroupName.GroupIndex = 0
            If cbPdName.Checked = True Then
                Col_InvName.GroupIndex = 1
                If cpLotNo.Checked = True Then
                    Col_LotNo.GroupIndex = 2

                End If
            End If
            If cpLotNo.Checked = True Then
                Col_LotNo.GroupIndex = 1

            End If
        End If
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

        GridView1.ExpandAllGroups()
    End Sub



    Private Sub btnSchPd_Click(sender As Object, e As EventArgs)
        BindData()
    End Sub

    Private Sub ButtonPd_Click(sender As Object, e As EventArgs) Handles ButtonPd.Click
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

        sdt_idLot = dr.Item("idLotMain")
        sdt_InvName = dr.Item("InvName")
        sdt_idWh = dr.Item("idWh")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

  
End Class