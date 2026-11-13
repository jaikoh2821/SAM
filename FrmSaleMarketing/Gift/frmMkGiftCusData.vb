Public Class frmMkGiftCusData
    ' Public dGiftCusMany_ As New DataTable
    Public idPs_get As Integer = sPsId
    Dim eEvent As eProcess

    Enum eProcess
        eGiftCusData
        eGiftCancel
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eGiftCusData
                Me.DGV.Columns(Me.col_cancle.Name).Visible = False
        End Select

        eEvent = aProcess

    End Sub

    Private Sub chk_gift_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_gift.CheckedChanged
        If Me.chk_gift.Checked Then
            Me.combo_gift.Enabled = True
        Else
            Me.combo_gift.Enabled = False
        End If
    End Sub

    Dim idPscancel As Integer

    Sub ShowDGV()
        Dim f As Font = Me.DGV.DefaultCellStyle.Font
        Dim gDt As New DataTable
        mdCnOpen()
        'mdCnOpen2()
        mdLoadShow()
        gDt.Clear()
        Dim str_where As String = ""
        Dim str_ As String = ""
        str_ = "Select mt.idGift ,mt.idCus,cus.CusName_, mt.idSup, sup.SupName, Pv.PvName, Reg.RegionName, cus.Address, sup.SupAddress, " & _
                "dt.idInv,dt.Amount,dt.idStore,mt.DateGift,cd.idGC,cd.Cause,mt.idPsCommand,v1.PsName As PsCommand" & _
                ",mt.idPsGift,v.PsName As PsGift,mt.idPsCancel,mt.CancelNote, sl.idPs From GR_Group.dbo.MkGiftCusMt mt " & _
                "INNER JOIN GR_Group.dbo.MkGiftCusDt dt ON dt.idGift=mt.idGift " & _
                "INNER JOIN GR_Group.dbo.MkGiftCauseD cd ON cd.idGC=mt.idGC " & _
                "INNER JOIN GR_Group.dbo.vPerson v ON mt.idPsGift=v.idPs " & _
                "INNER JOIN GR_Group.dbo.vPerson v1 ON mt.idPsCommand=v1.idPs " & _
                "LEFT OUTER JOIN GR_Group.dbo.vCustomer cus ON mt.idCus=cus.idCus " & _
                "LEFT OUTER JOIN GR_Group.dbo.SmMkCusPs sl ON mt.idCus=sl.idCus " & _
                "LEFT OUTER JOIN GR_Group.dbo.dProvinceFixSale Pv ON cus.idPv = Pv.idPv " & _
                "LEFT OUTER JOIN GR_Group.dbo.dRegion Reg ON Pv.idRegion = Reg.idRegion " & _
                "LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sup ON mt.idSup=sup.idSup " & _
                "Where mt.DateGift BETWEEN '" & ksbDateToString(Me.date_s.Value.ToShortDateString) & "' AND '" & ksbDateToString(Me.date_f.Value.ToShortDateString) & "'"


        '-----ประเภทผู้รับของ---'
        If Me.rdbCus.Checked = True Then
            str_where = str_where + " AND mt.idSup is Null "
            DGV.Columns("ColSupp").Visible = False
            DGV.Columns("ColPv").Visible = True
            DGV.Columns("ColReg").Visible = True
        ElseIf Me.rdbSupplier.Checked = True Then
            str_where = str_where + " AND mt.idCus is Null "
            DGV.Columns("col_name").Visible = False
            DGV.Columns("ColPv").Visible = False
            DGV.Columns("ColReg").Visible = False
        End If

        '-----สถานะรายการ---'
        If Me.rdbCancel.Checked = True Then
            str_where = str_where + " AND mt.idPsCancel is Not NULL "
        ElseIf Me.rdbUnCan.Checked = True Then
            str_where = str_where + " AND mt.idPsCancel is NULL "
        End If

        '-----ประเภทข้อมูล---'
        If Me.rdbReg.Checked = True Then
            str_where = str_where + " AND Reg.idRegion = " & Me.cmbReg.SelectedValue & " "
        ElseIf Me.rdbPv.Checked = True Then
            str_where = str_where + " AND Pv.idPv = " & Me.cmbPv.SelectedValue & " "
        End If

        '--- by Name---'
        If Me.chk_cus.Checked = True Then
            If Me.rdbAll.Checked = True Then
                str_where = " AND (cus.CusName_ Like '%" & Me.txt_cus.Text & "%' OR sup.SupName Like '%" & Me.txt_cus.Text & "%') "
            ElseIf Me.rdbCus.Checked = True Then
                str_where = " AND cus.CusName_ Like '%" & Me.txt_cus.Text & "%' "
            ElseIf Me.rdbSupplier.Checked = True Then
                str_where = " AND sup.SupName Like '%" & Me.txt_cus.Text & "%' "
            End If
        End If

        '--- by gift ---'
        If Me.chk_gift.Checked Then
            str_where = str_where + " AND dt.idInv = " & Me.combo_gift.SelectedValue & " "
        End If

        '---- by causeGift ---'
        If Me.ChkCause.Checked = True Then
            str_where = str_where + " AND cd.idGC = " & Me.cmbCause.SelectedValue & " "
        End If

        '--- by PsGift ---'
        If Me.ChkPsGift.Checked = True Then
            str_where = str_where + " AND mt.idPsGift = " & Me.cmbPsGift.SelectedValue & " "
        End If

        '--- by PsSale ---'
        If Me.ChkPsSale.Checked = True Then
            str_where = str_where + " AND sl.idPs = " & Me.cmbPsSale.SelectedValue & " "
        End If

        sCommand.CommandText = str_ + str_where + " order by mt.DateGift ASC "
        sAdapter.Fill(gDt)

        gDt.Columns.Add("Num", System.Type.GetType("System.String"))
        gDt.Columns.Add("InvName_", System.Type.GetType("System.String"))
        gDt.Columns.Add("UnitName", System.Type.GetType("System.String"))
        gDt.Columns.Add("StoreName", System.Type.GetType("System.String"))

        Dim dtTemp As New DataTable
        dtTemp.Clear()
        sCommand.CommandText = "SELECT d.idGift,I.InvName_, I.UnitName ,s.StoreName FROM  GR_Group.dbo.MkGiftCusDt AS d " & _
                                "INNER JOIN PchInvAndProject.dbo.vInventory AS I ON d.idInv = I.idInv " & _
                                "INNER JOIN PchInvAndProject.dbo.dInvStore AS s ON d.idStore = s.idStore "
        sAdapter.Fill(dtTemp)

        For i As Integer = 0 To gDt.Rows.Count - 1
            For j As Integer = 0 To dtTemp.Rows.Count - 1
                If gDt.Rows(i).Item("idGift") = dtTemp.Rows(j).Item("idGift") Then
                    gDt.Rows(i).Item("InvName_") = dtTemp.Rows(j).Item("InvName_")
                    gDt.Rows(i).Item("UnitName") = dtTemp.Rows(j).Item("UnitName")
                    gDt.Rows(i).Item("StoreName") = dtTemp.Rows(j).Item("StoreName")
                End If
            Next

            gDt.Rows(i).Item("Num") = i + 1
            gDt.Rows(i).Item("DateGift") = ksbStringToDate(gDt.Rows(i).Item("DateGift"))
            If IsDBNull(gDt.Rows(i).Item("idCus")) = True Then
                gDt.Rows(i).Item("Address") = gDt.Rows(i).Item("SupAddress")
            ElseIf IsDBNull(gDt.Rows(i).Item("idSup")) = True Then
                gDt.Rows(i).Item("Address") = gDt.Rows(i).Item("Address")
            End If
        Next
        gDt.Columns.Remove("SupAddress")
        Me.DGV.DataSource = gDt

        If Me.rdbCus.Checked = True Then
            DGV.Columns("ColSupp").Visible = False
            DGV.Columns("col_name").Visible = True
        ElseIf Me.rdbSupplier.Checked = True Then
            DGV.Columns("ColSupp").Visible = True
            DGV.Columns("col_name").Visible = False
        ElseIf Me.rdbAll.Checked = True Then
            DGV.Columns("ColSupp").Visible = True
            DGV.Columns("col_name").Visible = True
        End If

        If gDt.Rows.Count = 0 Then
            If Me.rdbAll.Checked = False Then
                MessageBox.Show("ไม่พบข้อมูล", sSystemName)
                Exit Sub
            End If        
        End If

        SumTotal()

        For i As Integer = 0 To Me.DGV.Rows.Count - 1
            Try
                idPscancel = Me.DGV.Rows(i).Cells(Me.col_idcancel.Name).Value
            Catch ex As Exception
                idPscancel = 0
            End Try
            If idPscancel <> 0 Then
                Me.DGV.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                Me.DGV.Rows(i).DefaultCellStyle.Font = New Font(f, FontStyle.Strikeout)
                Me.DGV.Rows(i).Cells(ColChk.Name).ReadOnly = True
            End If
        Next
    End Sub

    Sub SumTotal()
        Dim Total As Double = 0.0
        For i As Integer = 0 To DGV.Rows.Count - 1
            If IsDBNull(DGV.Rows(i).Cells("col_idcancel").Value) = True Then
                Total += DGV.Rows(i).Cells("col_Amount").Value
            End If
        Next
        txtTotal.Text = Format(Total, "#,##0.00")
        Me.txtCount.Text = Me.DGV.Rows.Count
    End Sub

    Dim id_set As Integer
    Dim Name_ As String
    Dim nDt As New DataTable

    Sub showName(ByVal id As Integer)
        id_set = id
        nDt.Clear()
        sCommand.CommandText = "Select PsName FROM vPerson WHERE idPs = " & id_set & " "
        sAdapter.Fill(nDt)
        Name_ = nDt.Rows.Item(0).Item("PsName").ToString()
    End Sub

    Dim InvDT_ As New DataTable
    Dim StoreDT_ As New DataTable
    Dim InvName_ As String
    Dim UnitName As String
    Dim StoreName As String
    Sub showInv_(ByVal id As Integer)
        id_set = id
        InvDT_.Clear()
        sCommand.CommandText = "Select InvName_,UnitName FROM vInventory WHERE idInv = " & id_set & ""
        sAdapter.Fill(InvDT_)
        InvName_ = InvDT_.Rows.Item(0).Item("InvName_").ToString()
        UnitName = InvDT_.Rows.Item(0).Item("UnitName").ToString()
    End Sub

    Sub showStore_(ByVal id As Integer)
        id_set = id
        StoreDT_.Clear()
        sCommand.CommandText = "Select StoreName FROM dInvStore  WHERE idStore = " & id_set & ""
        sAdapter.Fill(StoreDT_)
        StoreName = StoreDT_.Rows.Item(0).Item("StoreName").ToString()
    End Sub

    Private Sub chk_cus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cus.CheckedChanged
        If Me.chk_cus.Checked Then
            Me.txt_cus.Enabled = True
        Else
            Me.txt_cus.Enabled = False
        End If
    End Sub


    Private Sub frmMkGiftCusData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowDataInv()
        CauseGift()
        ShowReg()
        ShowPv()
        ShowPsGift()
        ShowPsSale()
        Me.rdbAll.Checked = True
        Me.rdbAllC.Checked = True
        Me.rdbAllAddr.Checked = True
    End Sub

    Private Sub ShowDataInv()
        Dim sDt As New DataTable
        sDt.Clear()
        mdCnOpen()
        mdCnOpen2()
        sCommand.CommandText = "Select DISTINCT dt.idInv,v.InvName_ From GR_Group.dbo.MkGiftCusDt dt, PchInvAndProject.dbo.vInventory v WHERE dt.idInv=v.idInv"

        sAdapter.Fill(sDt)
        Me.combo_gift.DataSource = sDt
        Me.combo_gift.ValueMember = "idInv"
        Me.combo_gift.DisplayMember = "InvName_"
    End Sub

    Dim idGift_ As Integer

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If Me.DGV.Columns(e.ColumnIndex).Name = Me.col_cancle.Name Then
            mdLoadShow()
            mdCnOpen()
            idGift_ = Me.DGV.Rows(e.RowIndex).Cells(Me.col_idGift.Name).Value
            If IsDBNull(Me.DGV.Rows(e.RowIndex).Cells(Me.col_idcancel.Name).Value) Then
                Dim CancelNote As String = InputBox("ระบุสาเหตุการยกเลิก", sSystemName)
                If CancelNote.Length <> 0 Then
                    sCommand.CommandText = "UPDATE MkGiftCusMt SET idPsCancel  =" & idPs_get & ",CancelNote ='" & CancelNote & "'" & _
                                           " Where  idGift =" & idGift_ & ""
                    sCommand.ExecuteNonQuery()
                    MessageBox.Show("ยกเลิกเรียบร้อยแล้ว", sSystemName)
                    ShowDGV()
                End If
            End If
            mdLoadCommitt()
        End If
    End Sub

    Private Sub DGV_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            idPscancel = Me.DGV.Rows(e.RowIndex).Cells(Me.col_idcancel.Name).Value
        Catch ex As Exception
            idPscancel = 0
        End Try

        If idPscancel <> 0 Then
            showName(Me.DGV.Rows(e.RowIndex).Cells("col_idCancel").Value)
            Dim name_cancel As String = Name_
            Dim note_cancel As String = Me.DGV.Rows(e.RowIndex).Cells("col_CancelNote").Value
            MessageBox.Show("ผู้ยกเลิก : " & name_cancel & vbNewLine & "ยกเลิกสาเหตุ : " & note_cancel, sSystemName)
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        mdLoadShow()
        ShowDGV()
        mdLoadCommitt()
    End Sub

    Private Sub ShowPsGift()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select DISTINCT mt.idPsGift, v.PsName From MkGiftCusMt mt INNER JOIN vPerson v ON mt.idPsGift=v.idPs"
        sAdapter.Fill(sDt)
        With cmbPsGift
            .DisplayMember = "PsName"
            .ValueMember = "idPsGift"
            .DataSource = sDt
        End With
    End Sub

    Private Sub ShowPsSale()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPs,PsName From vPerson Where stSale = '1' Order By PsName"
        sAdapter.Fill(sDt)
        With cmbPsSale
            .DisplayMember = "PsName"
            .ValueMember = "idPs"
            .DataSource = sDt
        End With
    End Sub

    Private Sub CauseGift()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idGC, Cause From MkGiftCauseD"
        sAdapter.Fill(sDt)
        With cmbCause
            .DisplayMember = "Cause"
            .ValueMember = "idGC"
            .DataSource = sDt
        End With
    End Sub

    Private Sub ShowReg()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idRegion, RegionName From dRegion"
        sAdapter.Fill(sDt)
        With cmbReg
            .DisplayMember = "RegionName"
            .ValueMember = "idRegion"
            .DataSource = sDt
        End With
    End Sub

    Private Sub ShowPv()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPv, PvName From dProvinceFixSale"
        sAdapter.Fill(sDt)
        With cmbPv
            .DisplayMember = "PvName"
            .ValueMember = "idPv"
            .DataSource = sDt
        End With
    End Sub

    Private Sub ChkCause_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCause.CheckedChanged
        If Me.ChkCause.Checked = True Then
            Me.cmbCause.Enabled = True
        Else
            Me.cmbCause.Enabled = False
        End If
    End Sub

    Private Sub chkAddr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddr.CheckedChanged
        If Me.chkAddr.Checked = True Then
            Me.btnShowDoc.Visible = True
            Me.DGV.Columns(Me.ColChk.Name).Visible = True
            Me.btnChkAll.Visible = True
            Me.btnUnChk.Visible = True
        Else
            Me.btnShowDoc.Visible = False
            Me.DGV.Columns(Me.ColChk.Name).Visible = False
            Me.btnChkAll.Visible = False
            Me.btnUnChk.Visible = False
        End If
    End Sub

    Private Sub btnShowDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDoc.Click
        If Me.rdbAll.Checked = True Then
            MessageBox.Show("ไม่สามารถแสดงเอกสารได้ ต้องเลือกลูกค้าหรือ supplier อย่างใดอย่างหนึ่งเท่านั้น", sSystemName)
            Exit Sub
        End If

        Dim dGiftCusMany_ As New DataTable
        dGiftCusMany_.Clear()
        mdCnOpen()
        'sCommand.CommandText = "SELECT '' AS PsRec, '' AS CompRec, '' AS AddressRec, '' AS TelRec FROM MkGiftCusMt"
        'sAdapter.Fill(dGiftCusMany)
        dGiftCusMany_.Columns.Add("idCus", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("PsRec", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("CompRec", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("TelRec", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("PsGift", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec1", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec2", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec3", System.Type.GetType("System.String"))
        dGiftCusMany_.Columns.Add("AddressRec4", System.Type.GetType("System.String"))


        Dim j As Integer = 0

        '---check select row
        For i As Integer = 0 To DGV.Rows.Count - 1
            If Me.DGV.Rows(i).Cells(ColChk.Name).Value = True Then
                dGiftCusMany_.Rows.Add()
                '---------------------------------------------------
                If IsDBNull(Me.DGV.Rows(i).Cells(col_idCus.Name).Value) Then
                    '--- Supplier ---'
                    dGiftCusMany_.Rows(j).Item("idCus") = Me.DGV.Rows(i).Cells(ColidSup.Name).Value
                ElseIf IsDBNull(Me.DGV.Rows(i).Cells(ColidSup.Name).Value) Then
                    '--- customer ---'
                    dGiftCusMany_.Rows(j).Item("idCus") = Me.DGV.Rows(i).Cells(col_idCus.Name).Value
                End If

                'dGiftCusMany_.Rows(j).Item("idCus") = Me.DGV.Rows(i).Cells(col_idCus.Name).Value
                '----------------------------------------------------
                dGiftCusMany_.Rows(j).Item("PsGift") = Me.DGV.Rows(i).Cells(col_PsGift.Name).Value
                ' MessageBox.Show("Sent " & dGiftCusMany_.Rows(j).Item("idCus"))
                j = j + 1
            End If
        Next

        If Me.rdbCus.Checked = True Then
            Dim vFrm As New frmMkGiftDocSelect(frmMkGiftDocSelect.eProcess.eDataSet2, dGiftCusMany_)
            vFrm.Show()
        ElseIf Me.rdbSupplier.Checked = True Then
            Dim vFrm As New frmMkGiftDocSelect(frmMkGiftDocSelect.eProcess.eDataSet4, dGiftCusMany_)
            vFrm.Show()
        End If

       

        'If dGiftCusMany.Rows.Count = 0 Then
        '    MessageBox.Show("ไม่มีข้อมูลสำหรับแสดงเอกสาร", sSystemName)
        '    Exit Sub
        'End If

        'For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
        '    Dim dt As New DataTable
        '    dt.Clear()
        '    sCommand.CommandText = "Select CusNameCon_, CusName_, AddressS, Address, Tel FROM vCustomer WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
        '    sAdapter.Fill(dt)
        '    dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("CusNameCon_")
        '    dGiftCusMany.Rows(i).Item("CompRec") = dt.Rows(0).Item("CusName_")
        '    If Trim(dt.Rows(0).Item("AddressS")) = "" Then
        '        dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
        '    ElseIf IsDBNull(dt.Rows(0).Item("AddressS")) Then
        '        dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
        '    Else
        '        dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("AddressS")
        '    End If
        '    dGiftCusMany.Rows(i).Item("TelRec") = dt.Rows(0).Item("Tel")
        'Next


        'Dim vFrm As New frmReportView
        'Dim vRpt As New crpStickerSaleSeedsPsRecSend
        'Dim sDt_Temp As New DataTable

        'mdCnOpen2()
        'sCommand.CommandText = "SELECT CompName ,Address,Tel  FROM dCompany WHERE idComp = " + sCompbUse.ToString
        'sAdapter.Fill(sDt_Temp)

        'Dim CompName As String = sDt_Temp.Rows(0).Item("CompName")
        'Dim CompAddress As String = sDt_Temp.Rows(0).Item("Address")
        'Dim pTel As String = sDt_Temp.Rows(0).Item("Tel")
        'vRpt.SetDataSource(dGiftCusMany)
        'vRpt.SetParameterValue(vRpt.Parameter_ptPsSend.ParameterFieldName, "")
        'vRpt.SetParameterValue(vRpt.Parameter_ptSendCompb.ParameterFieldName, CompName)
        'vRpt.SetParameterValue(vRpt.Parameter_ptSendAddress.ParameterFieldName, CompAddress)
        'vRpt.SetParameterValue(vRpt.Parameter_ptSendTel.ParameterFieldName, pTel)
        'vFrm.CrystalReportViewer1.ReportSource = vRpt
        'vFrm.Show()
    End Sub

    Private Sub btnChkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkAll.Click
        For i As Integer = 0 To DGV.Rows.Count - 1
            Me.DGV.Rows(i).Cells(ColChk.Name).Value = True
        Next
    End Sub

    Private Sub btnUnChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnChk.Click
        For i As Integer = 0 To DGV.Rows.Count - 1
            Me.DGV.Rows(i).Cells(ColChk.Name).Value = False
        Next
    End Sub


    Private Sub rdbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAll.CheckedChanged
        If Me.rdbAll.Checked = True Then
           Me.GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub rdbCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCus.CheckedChanged
        If Me.rdbCus.Checked = True Then
            Me.GroupBox4.Enabled = True
            'Me.rdbPv.Enabled = True
            'Me.rdbReg.Enabled = True
            'Me.rdbPsGift.Enabled = True
        End If
    End Sub

    Private Sub rdbSupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSupplier.CheckedChanged
        If Me.rdbSupplier.Checked = True Then
            Me.GroupBox4.Enabled = False
            Me.rdbAllAddr.Checked = True
            Me.rdbPv.Checked = False
            Me.rdbReg.Checked = False
            'Me.rdbPsGift.Checked = False
            'Me.rdbPv.Enabled = False
            'Me.rdbReg.Enabled = False
            'Me.rdbPsGift.Enabled = True

        End If
    End Sub

    Private Sub rdbReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbReg.CheckedChanged
        If Me.rdbReg.Checked = True Then
            Me.cmbReg.Enabled = True
            Me.cmbPv.Enabled = False
            Me.cmbPsGift.Enabled = False
        Else
            Me.cmbReg.Enabled = False
        End If
    End Sub

    Private Sub rdbPv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPv.CheckedChanged
        If Me.rdbPv.Checked = True Then
            Me.cmbReg.Enabled = False
            Me.cmbPv.Enabled = True
            Me.cmbPsGift.Enabled = False
        Else
            Me.cmbPv.Enabled = False
        End If
    End Sub

    Private Sub ChkPsGift_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPsGift.CheckedChanged
        If Me.ChkPsGift.Checked = True Then
            Me.cmbPsGift.Enabled = True
        Else
            Me.cmbPsGift.Enabled = False
        End If
    End Sub

    Private Sub ChkPsSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPsSale.CheckedChanged
        If Me.ChkPsSale.Checked = True Then
            Me.cmbPsSale.Enabled = True
        Else
            Me.cmbPsSale.Enabled = False
        End If
    End Sub
End Class