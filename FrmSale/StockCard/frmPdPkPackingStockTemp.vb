Imports System.IO
Imports System.Net
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPdPkPackingStockTemp
    Public idPdPk As String
    Public PdCodeS As String
    Public PdPkName As String
    Public Weight As Double
    Public Unit As String
    Public idUnit As String
    Public idPkUnit As String
    Public PerBox As Integer
    Public PriceBill As Double
    Public PriveWh As Double
    Public PriceRetail As Double
    Public Barcode As String
    Dim pidPd As String
    Dim namePs As String
    Dim idps As String = ""
    Dim sDt_dataTemp As New DataTable
    Dim current_row As Integer = 0
    Dim current_column As Integer = 0
    Dim flag2 As String
    Dim pidPdPk As String
    Dim idpswork As String = ""
    Dim lastrow As Integer
    Dim newrow As Integer = 0
    Dim pidUpdate As String
    Dim ptype As String = "0"
    Dim pPsNamecomm As String
    Dim pPsAction As String
    Dim pNote As String
    Dim DataPdOrder As New DataTable
    Dim DataDel As New DataTable
    Dim lastIndexColCell As Integer = 0
    Dim eProcress As New Process
    Dim stpage As Integer = 1
    Public idPdPkLotShow As Integer = 0
    Enum eProcess
        eAdd 'เพิ่มรายการ
        eEdit 'แก้ไขรายการ
        eShow    
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If aProcess = eProcess.eAdd Then
            stPage = 1
        End If
        If aProcess = eProcess.eEdit Then
            stpage = 2
            GBDate.Visible = True
            btnaddPd.Visible = False
            btnaddPd.Enabled = False
            coldelete.Visible = False
        End If
        If aProcess = eProcess.eShow Then
            stpage = 3
            GBDate.Visible = False
            'btnaddPd.Visible = False
            coldelete.Visible = False
            Panel3.Visible = False
            Panel1.Visible = False
        End If
    End Sub


    'Private Sub dgvPd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellContentClick
    '    'Dim frm As New frmPdPkStockUpdateHistory
    '    Dim frm2 As New frmPdPkPerBoxCal
    '    Dim pBarcode As String = ""
    '    Dim pCode As String = ""
    '    Dim punit As String = ""
    '    Dim ans As DialogResult
    '    If e.RowIndex < 0 Then
    '        Exit Sub
    '    End If

    '    If dgvPd.Columns(e.ColumnIndex).Name = colEdit.Name Then
    '        Dim gidpdpk As Integer = CType(dgvPd.Rows(e.RowIndex).Cells(idPd.Name).Value.ToString, Integer)
    '        Dim gidUpdate As Integer = CType(dgvPd.Rows(e.RowIndex).Cells(idUpdate.Name).Value.ToString, Integer)
    '        Dim gAmount As Integer = CType(dgvPd.Rows(e.RowIndex).Cells(ChangeAmount.Name).Value.ToString, Integer)
    '        Dim gLotNum As String = dgvPd.Rows(e.RowIndex).Cells(LotNum.Name).Value
    '        Dim gnote As String = dgvPd.Rows(e.RowIndex).Cells(colnote.Name).Value
    '        'Dim gidUpdate As String = dgvPd.Rows(e.RowIndex).Cells(idUpdate.Name).Value.ToString
    '        Dim gMec As String = dgvPd.Rows(e.RowIndex).Cells(chkMec.Name).Value
    '        Dim gHum As String = dgvPd.Rows(e.RowIndex).Cells(chkHum.Name).Value
    '        Dim gDocDate As String = dgvPd.Rows(e.RowIndex).Cells(colDocDate.Name).Value
    '        Dim gDocGen As String = dgvPd.Rows(e.RowIndex).Cells(colDateGen.Name).Value
    '        Dim gDocNum As String = dgvPd.Rows(e.RowIndex).Cells(colDocNum.Name).Value
    '        Dim gidPdPkLot As String = dgvPd.Rows(e.RowIndex).Cells(colidPdPkLot.Name).Value
    '        Dim gidWh As String = dgvPd.Rows(e.RowIndex).Cells(idWh.Name).Value
    '        Dim gidInvName As String = dgvPd.Rows(e.RowIndex).Cells(colInv.Name).Value
    '        Dim gAmountB As Integer = CType(dgvPd.Rows(e.RowIndex).Cells(Amount.Name).Value.ToString, Integer)
    '        Dim vFrm As New frmPdPkPackingStockTempAddData(frmPdPkPackingStockTempAddData.eProcess.eEdit)
    '        Dim sDt_pddata As New DataTable
    '        Dim flag As Integer = 0
    '        ''MessageBox.Show(ksbDateToString(gDocDate))
    '        Dim pAmount As Integer = 0
    '        Dim pLotNum As String = ""
    '        Dim DateDoc As String = ""
    '        Dim pDateGen As String = ""
    '        Dim note As String = ""
    '        Dim hum As Integer = 0
    '        Dim mec As Integer = 0
    '        Dim pDocNum As String = ""
    '        Dim pgidWh As String = ""
    '        Dim pgInvName As String = ""

    '        vFrm.Get_Data(gidpdpk, gDocDate, gLotNum, gAmount, gHum, gMec, gnote, gDocNum, gidWh, gidInvName, gDocGen)
    '        vFrm.ShowDialog()



    '        If vFrm.DialogResult = Windows.Forms.DialogResult.OK Then
    '            idPdPk = vFrm.idPdPk
    '            pCode = vFrm.pCode
    '            pBarcode = vFrm.pBarcode
    '            pAmount = vFrm.pAmount
    '            pLotNum = vFrm.pLotNum
    '            DateDoc = vFrm.DocDate
    '            note = vFrm.Note
    '            hum = vFrm.hum
    '            mec = vFrm.mec
    '            pDocNum = vFrm.DocNum
    '            pgInvName = vFrm.pInvNameSent
    '            pgidWh = vFrm.pidWhSent
    '            pDateGen = vFrm.DateGen
    '        Else
    '            flag = 1
    '        End If
    '        'For i As Integer = 0 To dgvPd.Rows.Count - 2
    '        '    If dgvPd.Rows(i).Cells("idPd").Value = idPdPk Then
    '        '        flag = 1
    '        '        Exit For
    '        '    End If
    '        'Next
    '        If flag = 0 Then
    '            Try
    '                mdCnOpen()
    '                Dim sDt As New DataTable
    '                sCommand.CommandText = "Select idPdPk,PdPkName,Amount,PkUnitName From vPackingPdSet WHERE idPdPk = " & idpdpk
    '                sAdapter.Fill(sDt_pddata)
    '                punit = sDt_pddata.Rows(0).Item("PkUnitName")
    '                dgvPd.Rows.RemoveAt(e.RowIndex)
    '                dgvPd.Rows.Add(Nothing, Nothing, gidUpdate, idPdPk, DateDoc, pDocNum, pLotNum, pDateGen, pBarcode, pCode, sDt_pddata.Rows(0).Item(1).ToString, punit, gAmountB, pAmount, (gAmountB + pAmount).ToString, "-", 0, 0, 0, pgInvName, note, mec, hum, Nothing, gidPdPkLot, pgidWh)
    '                'DataPdOrder.Rows.Add(Nothing, Nothing, idPdPk, DateDoc, pLotNum, pBarcode, pCode, Nothing, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, pAmount, sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)
    '                'For i As Integer = 0 To dgvPd.Rows.Count - 2
    '                '    dgvPd.Rows(i).Cells("Operetor").Value = "+"
    '                'Next
    '            Catch ex As Exception
    '                Exit Sub
    '            End Try
    '        End If


    '    End If

    '    If dgvPd.Columns(e.ColumnIndex).Name = chkMec.Name Then
    '        dgvPd.Rows(e.RowIndex).Cells(chkHum.Name).Value = 0
    '    End If
    '    If dgvPd.Columns(e.ColumnIndex).Name = chkHum.Name Then
    '        dgvPd.Rows(e.RowIndex).Cells(chkMec.Name).Value = 0
    '    End If

    '    If dgvPd.Columns(e.ColumnIndex).Name = coldelete.Name Then
    '        ans = MessageBox.Show("ยืนยันการลบ", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '        If ans = vbYes Then
    '            If dgvPd.Rows(e.RowIndex).Cells(idUpdate.Name).Value.ToString <> "0" Then
    '                DataDel.Rows.Add(dgvPd.Rows(e.RowIndex).Cells(idUpdate.Name).Value.ToString)
    '                dgvPd.Rows.RemoveAt(e.RowIndex)
    '            Else
    '                dgvPd.Rows.RemoveAt(e.RowIndex)
    '            End If
    '        End If
    '    End If

    '    If dgvPd.Columns(e.ColumnIndex).Name = btn_add.Name Then
    '        Dim sDt_pddata As New DataTable
    '        Dim flag As Integer = 0
    '        Dim vFrm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePdAmount)
    '        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            idPdPk = vFrm.idPdPk
    '            pCode = vFrm.PdCodeS
    '            pBarcode = vFrm.Barcode
    '        Else
    '            flag = 1
    '        End If
    '        'For i As Integer = 0 To dgvPd.Rows.Count - 2
    '        '    If dgvPd.Rows(i).Cells("idPd").Value = idPdPk Then
    '        '        flag = 1
    '        '        Exit For
    '        '    End If
    '        'Next
    '        If flag = 0 Then
    '            Try
    '                mdCnOpen()
    '                Dim sDt As New DataTable
    '                sCommand.CommandText = "Select idPdPk,PdPkName,Amount,PkUnitName From vPackingPdSet WHERE idPdPk = " & idPdPk
    '                sAdapter.Fill(sDt_pddata)
    '                punit = sDt_pddata.Rows(0).Item("PkUnitName")
    '                dgvPd.Rows.Add(Nothing, 0, idPdPk, "", pBarcode, pCode, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, "0", sDt_pddata.Rows(0).Item(2).ToString, Nothing)
    '                DataPdOrder.Rows.Add(Nothing, idPdPk, "", pBarcode, pCode, Nothing, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, "0", sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)
    '                'For i As Integer = 0 To dgvPd.Rows.Count - 2
    '                '    dgvPd.Rows(i).Cells("Operetor").Value = "+"
    '                'Next
    '            Catch ex As Exception
    '                Exit Sub
    '            End Try
    '        Else
    '            'MessageBox.Show("สินค้าซ้ำกรุณาเลือกสินค้าชนิดอื่น", sSystemName)
    '        End If
    '    End If


    'End Sub

    Private Sub changimg()
        For i As Integer = 0 To dgvPd.Rows.Count - 1
            dgvPd.Rows(i).Cells(coldelete.Name).Value = My.Resources.ResourceManager.GetObject("cross_circle_frame")
        Next
    End Sub

    Private Sub frmPdPkPackingStockTemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Create_TableTamp()
        DateTs.Value = Date.Today
        DateTimePicker2.Value = Date.Today
        txtPsName.Text = sPsName
    End Sub

    Public Sub Create_TableTamp()
        sDt_dataTemp = New DataTable
        sDt_dataTemp.Columns.Add("idPd", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("PdName", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("Before", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("OP", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("Change", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("After", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("note", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("InvName", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("idWh", System.Type.GetType("System.String"))
        sDt_dataTemp.Columns.Add("DateGen", System.Type.GetType("System.String"))
        mdCnOpen()
        sCommand.CommandText = "Select Pr.idUpdate,Ps.idPdPk, Ps.PdCode, Ps.Barcode, Ps.PdPkName,Ps.PkUnitName,Pr.AmountBefore " & _
                               ",Pr.AmountOperate ,Pr.AmountAfter,Pr.LotNum,Pr.Grade,Pr.Grow,Pr.Humid,Pr.Pure,Pr.note,idWh" & _
                               " From PkPdPkUpdateRec Pr LEFT JOIN vPackingPdSet Ps ON Pr.idPdPk = Ps.idPdPk WHERE Pr.idUpdate = 0"

        sAdapter.Fill(DataPdOrder)

        DataDel.Columns.Add("idUpdate", System.Type.GetType("System.String"))
    End Sub

    Private Sub dgvPd_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellEndEdit
        dgvPd.Rows(e.RowIndex).Cells("AfterAmount").Value = (CType(dgvPd.Rows(e.RowIndex).Cells("ChangeAmount").Value, Double) + CType(dgvPd.Rows(e.RowIndex).Cells("Amount").Value, Double)).ToString
        If dgvPd.Columns(e.ColumnIndex).Name = barcode_pd.Name Then
            mdCnOpen()
            Dim sDt As New DataTable
            sCommand.CommandText = "Select idPdPk, PdCode, Barcode, Amount, PdPkName,PkUnitName From vPackingPdSet WHERE Barcode = '" + dgvPd.Rows(e.RowIndex).Cells("barcode_pd").Value + "'"
            sAdapter.Fill(sDt)
            If sDt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", sSystemName)
                dgvPd.CurrentRow.Cells("idPd").Value = Nothing
                dgvPd.CurrentRow.Cells("Pd_Code").Value = Nothing
                dgvPd.CurrentRow.Cells("barcode_pd").Value = Nothing
                dgvPd.CurrentRow.Cells("AfterAmount").Value = Nothing
                dgvPd.CurrentRow.Cells("colPdName").Value = Nothing
                dgvPd.CurrentRow.Cells("Amount").Value = Nothing
                dgvPd.CurrentRow.Cells("ChangeAmount").Value = Nothing
                Try
                    dgvPd.Rows.RemoveAt(lastrow)
                Catch ex As Exception
                End Try
            Else
                Dim flag2 As Integer = 0
                For i As Integer = 0 To dgvPd.Rows.Count - 2
                    If dgvPd.Rows(i).Cells("idPd").Value = sDt.Rows(0).Item("idPdPk") Then
                        flag2 = 1
                        Exit For
                    End If
                Next
                If flag2 = 0 Then
                    dgvPd.CurrentRow.Cells("idPd").Value = sDt.Rows(0).Item("idPdPk")
                    dgvPd.CurrentRow.Cells("Pd_Code").Value = sDt.Rows(0).Item("PdCode")
                    dgvPd.CurrentRow.Cells("barcode_pd").Value = sDt.Rows(0).Item("Barcode")
                    dgvPd.CurrentRow.Cells("AfterAmount").Value = sDt.Rows(0).Item("Amount")
                    dgvPd.CurrentRow.Cells("colPdName").Value = sDt.Rows(0).Item("PdPkName")
                    dgvPd.CurrentRow.Cells("Amount").Value = sDt.Rows(0).Item("Amount")
                    dgvPd.CurrentRow.Cells("UnitPd").Value = sDt.Rows(0).Item("PkUnitName")
                    dgvPd.CurrentRow.Cells("ChangeAmount").Value = "0"
                Else
                    MessageBox.Show("ข้อมูลซ้ำกรุณาเลือกข้อมูลใหม่", sSystemName)
                End If
            End If
        End If

        If dgvPd.Columns(e.ColumnIndex).Name = Pd_Code.Name Then
            mdCnOpen()
            Dim sDt As New DataTable
            sCommand.CommandText = "Select idPdPk, PdCode, Barcode, Amount, PdPkName,PkUnitName From vPackingPdSet WHERE PdCode = '" + dgvPd.Rows(e.RowIndex).Cells("Pd_Code").Value + "'"
            sAdapter.Fill(sDt)
            If sDt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", sSystemName)
                dgvPd.CurrentRow.Cells("idPd").Value = Nothing
                dgvPd.CurrentRow.Cells("Pd_Code").Value = Nothing
                dgvPd.CurrentRow.Cells("barcode_pd").Value = Nothing
                dgvPd.CurrentRow.Cells("AfterAmount").Value = Nothing
                dgvPd.CurrentRow.Cells("colPdName").Value = DBNull.Value
                dgvPd.CurrentRow.Cells("Amount").Value = Nothing
                dgvPd.CurrentRow.Cells("ChangeAmount").Value = Nothing
                Try
                    dgvPd.Rows.RemoveAt(lastrow)
                Catch ex As Exception
                End Try
            Else
                Dim flag2 As Integer = 0
                For i As Integer = 0 To dgvPd.Rows.Count - 2
                    If dgvPd.Rows(i).Cells("idPd").Value = sDt.Rows(0).Item("idPdPk") Then
                        flag2 = 1
                        Exit For
                    End If
                Next
                If flag2 = 0 Then
                    dgvPd.CurrentRow.Cells("idPd").Value = sDt.Rows(0).Item("idPdPk")
                    dgvPd.CurrentRow.Cells("Pd_Code").Value = sDt.Rows(0).Item("PdCode")
                    dgvPd.CurrentRow.Cells("barcode_pd").Value = sDt.Rows(0).Item("Barcode")
                    dgvPd.CurrentRow.Cells("AfterAmount").Value = sDt.Rows(0).Item("Amount")
                    dgvPd.CurrentRow.Cells("colPdName").Value = sDt.Rows(0).Item("PdPkName")
                    dgvPd.CurrentRow.Cells("Amount").Value = sDt.Rows(0).Item("Amount")
                    dgvPd.CurrentRow.Cells("UnitPd").Value = sDt.Rows(0).Item("PkUnitName")
                    dgvPd.CurrentRow.Cells("ChangeAmount").Value = "0"
                Else
                    MessageBox.Show("ข้อมูลซ้ำกรุณาเลือกข้อมูลใหม่", sSystemName)
                End If
            End If
        End If
        changimg()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        mdLoadShow()
        mdCnOpen()
        'selectmax
        Dim ans As DialogResult
        ans = MessageBox.Show("ยืนยันการบันทึก", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbNo Then
            Exit Sub
        End If

        If chksave() Then
            Exit Sub
        End If

        Try
            For i As Integer = 0 To dgvPd.Rows.Count - 1

                Dim idpdpk As Integer = CType(dgvPd.Rows(i).Cells(idPd.Name).Value.ToString, Integer)
                Dim pidpdpkLot As Integer = CType(dgvPd.Rows(i).Cells(colidPdPkLot.Name).Value.ToString, Integer)
                Dim AmountChange As Integer = CType(dgvPd.Rows(i).Cells(ChangeAmount.Name).Value.ToString, Integer)
                Dim AmountBefore As Integer = CType(dgvPd.Rows(i).Cells(Amount.Name).Value.ToString, Integer)
                Dim AmountAfter As Integer = CType(dgvPd.Rows(i).Cells(AfterAmount.Name).Value.ToString, Integer)
                Dim pLotNum As String = dgvPd.Rows(i).Cells(LotNum.Name).Value
                Dim pGrow As String
                Dim pHumid As String
                Dim pPure As String
                If dgvPd.Rows(i).Cells(Grow.Name).Value = Nothing Then
                    pGrow = 0
                Else
                    pGrow = dgvPd.Rows(i).Cells(Grow.Name).Value.ToString
                End If
                If dgvPd.Rows(i).Cells(Humid.Name).Value = Nothing Then
                    pHumid = 0
                Else
                    pHumid = dgvPd.Rows(i).Cells(Humid.Name).Value.ToString
                End If
                If dgvPd.Rows(i).Cells(Pure.Name).Value = Nothing Then
                    pPure = 0
                Else
                    pPure = dgvPd.Rows(i).Cells(Pure.Name).Value.ToString
                End If
                Dim pGrade As String = dgvPd.Rows(i).Cells(Grade.Name).Value
                Dim pnote As String = dgvPd.Rows(i).Cells(colnote.Name).Value
                Dim pidUpdate As String = dgvPd.Rows(i).Cells(idUpdate.Name).Value.ToString
                Dim DateDoc As String = dgvPd.Rows(i).Cells(colDocDate.Name).Value.ToString
                Dim DateGen As String = dgvPd.Rows(i).Cells(colDateGen.Name).Value.ToString
                Dim DocNum As String = dgvPd.Rows(i).Cells(colDocNum.Name).Value.ToString
                Dim Mec As String = dgvPd.Rows(i).Cells(chkMec.Name).Value.ToString
                Dim pidWh As String = dgvPd.Rows(i).Cells(idWh.Name).Value.ToString
                Dim Hum As String = dgvPd.Rows(i).Cells(chkHum.Name).Value.ToString

                'MessageBox.Show(pidUpdate)
                'Exit Sub
                If pidUpdate = "0" Then
                    sCommand.CommandText = "INSERT INTO PkPdPkUpdateRec (idPdPk,AmountBefore,AmountOperate,AmountAfter,Note,LotNum,DateTs,Grade,Grow,Pure,Humid,idPs,stMecMade,stHumMade,DateDoc,DocNum,idWh,CompRec) " & _
                        "VALUES (" & idpdpk & "," & AmountBefore & "," & AmountChange & "," & AmountAfter & ",'" & pnote & "','" & pLotNum & "','" & ksbDateToString(Date.Now.Date) & "','" & pGrade & "','" & pGrow & "','" & pPure & "','" & pHumid & "'," & sPsId & "," & Mec & " , " & Hum & ",'" & ksbDateToString(DateDoc) & "','" & DocNum & "'," & pidWh & "," & sIdComp & ")"
                    'MessageBox.Show(sCommand.CommandText, sSystemName)
                    Dim ID As Integer = mdCnOpenQueryIdentity(sCommand.CommandText)
                    'MessageBox.Show(ID, sSystemName)

                    'sCommand.CommandText = "UPDATE dPackingPdSet SET Amount = " + dgvPd.Rows(i).Cells(AfterAmount.Name).Value.ToString + " WHERE idPdPk = " + dgvPd.Rows(i).Cells(idPd.Name).Value.ToString
                    'sCommand.ExecuteNonQuery()
                    sCommand.CommandText = "INSERT INTO dPackingPdSetLot (idUpdate,idPdPk,LotNum,Amount,AmountRec,idWh,DateGen,CompRec)" & _
                    "VALUES (" & ID & "," & idpdpk & ",'" & pLotNum & "',0," & AmountChange & "," & pidWh & ",'" & ksbDateToString(DateGen) & "'," & sIdComp & ")"
                    Dim idPkLot As Integer = mdCnOpenQueryIdentity(sCommand.CommandText)
                    ' mdPdPkLotStockUpdate(1, idPkLot, AmountChange, "WIM: เพิ่มสินค้าเข้าสต็อก", ID)
                Else
                    'mdPdPkStockUpdate(3, idpdpk, AmountBefore, "WIM: ปรับปรุงสต๊อก(ปรับยอด)", pidUpdate, pLotNum)
                    Dim sDt2 As New DataTable
                    sCommand.CommandText = "Select AmountOperate FROM PkPdPkUpdateRec WHERE idUpdate = " & pidUpdate
                    sAdapter.Fill(sDt2)
                    Dim AmountUpdate As Integer = CType(sDt2.Rows(0).Item("AmountOperate"), Integer)

                    Dim sDt_Temp_CHK As New DataTable
                    sCommand.CommandText = "Select Amount,AmountRec FROM dPackingPdSetLot WHERE idUpdate = " & pidUpdate & " And idpdpk = " & dgvPd.Rows(i).Cells(idPd.Name).Value.ToString
                    sAdapter.Fill(sDt_Temp_CHK)
                    For j As Integer = 0 To sDt_Temp_CHK.Rows.Count - 1
                        If sDt_Temp_CHK.Rows(j).Item("Amount") <> sDt_Temp_CHK.Rows(j).Item("AmountRec") Then

                        Else
                            If AmountUpdate < AmountChange Then
                                Dim AmountCal As Integer = AmountChange - AmountUpdate
                                'mdPdPkLotStockUpdate(2, pidpdpkLot, AmountCal, "WIM: ปรับปรุงสต๊อก(ลด)", pidUpdate)
                                sCommand.CommandText = "UPDATE PkPdPkUpdateRec SET AmountOperate = " & AmountChange.ToString & " ,AmountAfter = " & AmountAfter & ",Note = '" & pnote & "' ,LotNum = '" & pLotNum & "', " & _
                                "Grow = '" & pGrow & "',Humid = '" & pHumid & "',Pure = '" & pPure & "',Grade = '" & pGrade & "',DateUpdate = '" & ksbDateToString(Date.Now.Date) & "',stMecMade = " & Mec & " ,stHumMade = " & Hum & " , DateDoc = '" & ksbDateToString(DateDoc) & "' , DocNum = '" & DocNum & "' , idWh = " & pidWh & "  WHERE idUpdate = " & pidUpdate
                                sCommand.ExecuteNonQuery()
                            Else
                                If AmountUpdate = AmountChange Then
                                    Dim AmountCal As Integer = AmountUpdate
                                    '   mdPdPkLotStockUpdate(3, pidpdpkLot, AmountCal, "WIM: ปรับปรุงสต๊อก(ปรับปรุง)", pidUpdate)
                                    sCommand.CommandText = "UPDATE PkPdPkUpdateRec SET AmountOperate = " & AmountChange.ToString & " ,AmountAfter = " & AmountAfter & ",Note = '" & pnote & "' ,LotNum = '" & pLotNum & "', " & _
                                    "Grow = '" & pGrow & "',Humid = '" & pHumid & "',Pure = '" & pPure & "',Grade = '" & pGrade & "',DateUpdate = '" & ksbDateToString(Date.Now.Date) & "',stMecMade = " & Mec & " ,stHumMade = " & Hum & " , DateDoc = '" & ksbDateToString(DateDoc) & "' , DocNum = '" & DocNum & "' , idWh = " & pidWh & "  WHERE idUpdate = " & pidUpdate
                                    sCommand.ExecuteNonQuery()
                                Else
                                    Dim AmountCal As Integer = AmountUpdate - AmountChange
                                    ' mdPdPkLotStockUpdate(1, pidpdpkLot, AmountCal, "WIM: ปรับปรุงสต๊อก(เพิ่ม)", pidUpdate)
                                    sCommand.CommandText = "UPDATE PkPdPkUpdateRec SET AmountOperate = " & AmountChange.ToString & " ,AmountAfter = " & AmountAfter & ",Note = '" & pnote & "' ,LotNum = '" & pLotNum & "', " & _
                                    "Grow = '" & pGrow & "',Humid = '" & pHumid & "',Pure = '" & pPure & "',Grade = '" & pGrade & "',DateUpdate = '" & ksbDateToString(Date.Now.Date) & "',stMecMade = " & Mec & " ,stHumMade = " & Hum & " , DateDoc = '" & ksbDateToString(DateDoc) & "' , DocNum = '" & DocNum & "' , idWh = " & pidWh & "  WHERE idUpdate = " & pidUpdate
                                    sCommand.ExecuteNonQuery()
                                End If
                            End If
                            sCommand.CommandText = "UPDATE dPackingPdSetLot SET LotNum = '" & pLotNum & "',AmountRec = " & AmountChange & " , idWh = " & pidWh & " ,DateGen = '" & ksbDateToString(DateGen) & "' WHERE idUpdate = " & pidUpdate & " And idpdpk = " & dgvPd.Rows(i).Cells(idPd.Name).Value.ToString
                            sCommand.ExecuteNonQuery()
                        End If
                    Next
                End If
            Next

            For i As Integer = 0 To DataDel.Rows.Count - 1
                Dim sDt2 As New DataTable
                Dim pidpdpkLot As Integer = CType(dgvPd.Rows(i).Cells(colidPdPkLot.Name).Value.ToString, Integer)

                sCommand.CommandText = "Select Amount,AmountRec,LotNum FROM dPackingPdSetLot WHERE idUpdate = " & DataDel.Rows(i).Item("idUpdate")
                sAdapter.Fill(sDt2)
                For j As Integer = 0 To sDt2.Rows.Count - 1
                    If sDt2.Rows(j).Item("Amount") <> sDt2.Rows(j).Item("AmountRec") Then
                        MessageBox.Show("ข้อมูล LOT : " & sDt2.Rows(j).Item("LotNum") & " ถูกนำไปใช้แล้วไม่สามารถทำรายการได้", sSystemName)
                    Else
                        sCommand.CommandText = "UPDATE PkPdPkUpdateRec SET stDel = 1 ,DateUpdate = '" & ksbDateToString(Date.Now.Date) & "' WHERE  idUpdate = " & DataDel.Rows(i).Item("idUpdate")
                        sCommand.ExecuteNonQuery()
                        sCommand.CommandText = "UPDATE dPackingPdSetLot SET stDel = 1 ,DateUpdate = '" & ksbDateToString(Date.Now.Date) & "',idPsUpdate = " & sPsId & " WHERE  idUpdate = " & DataDel.Rows(i).Item("idUpdate")
                        sCommand.ExecuteNonQuery()

                        Dim sDt_Temp2 As New DataTable
                        sCommand.CommandText = "Select AmountOperate,LotNum FROM PkPdPkUpdateRec WHERE idUpdate = " & DataDel.Rows(i).Item("idUpdate")
                        sAdapter.Fill(sDt_Temp2)
                        Dim AmountUpdate As String = sDt_Temp2.Rows(0).Item("AmountOperate")
                        Dim pLotNum As String = sDt_Temp2.Rows(0).Item("LotNum")
                        'mdPdPkLotStockUpdate(2, pidpdpkLot, AmountUpdate, "WIM: ปรับปรุงสต๊อก(ลด)", pidUpdate)
                    End If
                Next
            Next
            mdLoadCommitt()
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", sSystemName)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("ไม่สามารถบันทึกได้ เกิดข้อผิดพลาดในการบันทึก", sSystemName)
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub dgvPd_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvPd.EditingControlShowing
        With Me.dgvPd
            If .CurrentCell.OwningColumn.Name = ChangeAmount.Name Then
                Dim tb As TextBox = CType(e.Control, TextBox)
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If
        End With
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Me.dgvPd.CurrentCell.OwningColumn.Name = ChangeAmount.Name Then
            If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> Chr(Keys.Back)) And (e.KeyChar <> Chr(Keys.Delete)) Or Asc(e.KeyChar) = 46 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim vFrm As New FrmReportView
    '    Dim vRpt As New crpStockPkLotCountDoc
    '    Dim sDt2 As New DataTable
    '    Dim dateTscon As String = ksbDateToString(DateTs.Value)

    '    sCommand.CommandText = "Select LotNum,PdPkName,AmountOperate AS Amount,PkUnitName AS UnitName,Pr.note,stMecMade,stHumMade,P.PsName,Pr.AmountAfter,Pr.DateDoc,Pr.DocNum FROM PkPdPkUpdateRec Pr LEFT JOIN vPackingPdSet Pk ON Pk.idPdPk = Pr.idPdPk LEFT JOIN vPerson AS P ON P.idPs = Pr.idPs WHERE Pr.DateTs ='" & dateTscon & "'"
    '    sAdapter.Fill(sDt2)
    '    For i As Integer = 0 To sDt2.Rows.Count - 1
    '        sDt2.Rows(i).Item("DateDoc") = ksbStringToDate(sDt2.Rows(i).Item("DateDoc"))
    '    Next
    '    vRpt.SetDataSource(sDt2)

    '    vRpt.SetParameterValue(vRpt.Parameter_DateTs.ParameterFieldName, datetxt)
    '    vRpt.SetParameterValue(vRpt.Parameter_ptCompb.ParameterFieldName, sCompName)
    '    vRpt.SetParameterValue(vRpt.Parameter_DateTs.ParameterFieldName, DateTs.Value)
    '    vRpt.SetParameterValue(vRpt.Parameter_ptPsPrint.ParameterFieldName, mdPsPrint())
    '    vFrm.ppDisplayGroupTree = True
    '    vFrm.crView.ReportSource = vRpt
    '    vRpt.SetParameterValue(vRpt.Parameter_ptTitle.ParameterFieldName, "รายงานการปรับสต๊อก")

    '    If sDt2.Rows.Count = 0 Then
    '        MessageBox.Show("ไม่พบรายการ", sSystemName)
    '    Else
    '        vFrm.Show()
    '    End If
    'End Sub

    Private Sub BinddataShow()

        mdCnOpen()
        Dim pBarcode As String = ""
        Dim pCode As String = ""
        Dim punit As String = ""
        Dim pAmountBefore As String = ""
        Dim pAmountOperate As String = ""
        Dim pAmountAfter As String = ""
        Dim pGrade As String = ""
        Dim pGrow As String = ""
        Dim pHumid As String = ""
        Dim pPure As String = ""
        Dim pLotNum As String = ""
        Dim pPkName As String = ""
        Dim pnote As String = ""
        Dim DateDoc As String = ""
        Dim pDocNum As String = ""
        Dim phum As Integer = 0
        Dim pmec As Integer = 0
        Dim sDt As New DataTable
        Dim pidPdPkLot As String = ""
        Dim pidWhRec As String = ""
        Dim pInvNameRec As String = ""
        Dim DateGen As String = ""

        'For i As Integer = 1 To dgvPd.Rows.Count - 1
        'dgvPd.Rows.RemoveAt(i)
        'Next
        'DataPdOrder.Clear()
        'dgvPd.DataSource = DataPdOrder
        dgvPd.Rows.Clear()

        sCommand.CommandText = "Select Pr.idUpdate,Pl.idPdPkLot,Pl.idPdPk, Ps.PdCode, Ps.Barcode, Ps.PdPkName,Ps.PkUnitName,Pr.AmountBefore " & _
                                ",Pr.AmountOperate ,Pr.AmountAfter,Pr.LotNum,Pr.Grade,Pr.Grow,Pr.Humid,Pr.Pure,Pr.note,Pr.DateDoc,Pr.DocNum,Pr.stMecMade,Pr.stHumMade" & _
                                ",Pr.idWh, Wh.WareHouseName, Pl.DateGen" & _
                                " From PkPdPkUpdateRec Pr LEFT JOIN dPackingPdSetLot Pl ON Pr.idUpdate = Pl.idUpdate LEFT JOIN vPackingPdSet Ps ON Ps.idPdPk = Pl.idPdPk  " & _
                                " LEFT JOIN SsWarehouse Wh ON Wh.idWh = Pr.idWh WHERE Pr.stDel = 0 And Pl.idPdPkLot = " & idPdPkLotShow
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", sSystemName)
        Else
            btn_save.Enabled = True
            For i As Integer = 0 To sDt.Rows.Count - 1
                pidUpdate = sDt.Rows(i).Item("idUpdate")
                idPdPk = sDt.Rows(i).Item("idPdPk")
                pCode = sDt.Rows(i).Item("PdCode")
                pBarcode = sDt.Rows(i).Item("Barcode")
                pAmountBefore = sDt.Rows(i).Item("AmountBefore")
                pAmountOperate = sDt.Rows(i).Item("AmountOperate")
                pAmountAfter = sDt.Rows(i).Item("AmountAfter")
                punit = sDt.Rows(i).Item("PkUnitName")
                pLotNum = sDt.Rows(i).Item("LotNum")
                pGrade = sDt.Rows(i).Item("Grade")
                pGrow = sDt.Rows(i).Item("Grow")
                pHumid = sDt.Rows(i).Item("Humid")
                pPure = sDt.Rows(i).Item("Pure")
                pnote = sDt.Rows(i).Item("note")
                pPkName = sDt.Rows(i).Item("PdPkName")
                pidPdPkLot = sDt.Rows(i).Item("idPdPkLot")
                pidWhRec = sDt.Rows(i).Item("idWh")
                pInvNameRec = sDt.Rows(i).Item("WareHouseName")
                If sDt.Rows(i).Item("DateDoc") Is DBNull.Value Then
                    DateDoc = ""
                Else
                    DateDoc = sDt.Rows(i).Item("DateDoc")
                End If

                If sDt.Rows(i).Item("DocNum") Is DBNull.Value Then
                    pDocNum = ""
                Else
                    pDocNum = sDt.Rows(i).Item("DocNum")
                End If

                phum = sDt.Rows(i).Item("stMecMade")
                pmec = sDt.Rows(i).Item("stHumMade")
                If sDt.Rows(i).Item("DateGen") Is DBNull.Value Then
                    DateGen = ""
                Else
                    DateGen = sDt.Rows(i).Item("DateGen")
                End If

                dgvPd.Rows.Add(Nothing, Nothing, pidUpdate, idPdPk, ksbStringToDate(DateDoc), pDocNum, pLotNum, ksbStringToDate(DateGen), pBarcode, pCode, pPkName, punit, pAmountBefore, pAmountOperate, pAmountAfter, pGrade, pGrow, pHumid, pPure, pInvNameRec, pnote, pmec, phum, Nothing, pidPdPkLot, pidWhRec)
                ''DataPdOrder.Rows.Add(Nothing, idPdPk, pBarcode, pCode, Nothing, pPkName, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, "0", sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)
            Next


        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_s.Click
        mdCnOpen()
        Dim pBarcode As String = ""
        Dim pCode As String = ""
        Dim punit As String = ""
        Dim pAmountBefore As String = ""
        Dim pAmountOperate As String = ""
        Dim pAmountAfter As String = ""
        Dim pGrade As String = ""
        Dim pGrow As String = ""
        Dim pHumid As String = ""
        Dim pPure As String = ""
        Dim pLotNum As String = ""
        Dim pPkName As String = ""
        Dim pnote As String = ""
        Dim DateDoc As String = ""
        Dim DateGen As String = ""
        Dim pDocNum As String = ""
        Dim phum As Integer = 0
        Dim pmec As Integer = 0
        Dim sDt As New DataTable
        Dim pidPdPkLot As String = ""
        Dim pidWhRec As String = ""
        Dim pInvNameRec As String = ""
        DataDel.Clear()
        'For i As Integer = 1 To dgvPd.Rows.Count - 1
        'dgvPd.Rows.RemoveAt(i)
        'Next
        'DataPdOrder.Clear()
        'dgvPd.DataSource = DataPdOrder
        dgvPd.Rows.Clear()

        sCommand.CommandText = "Select Pr.idUpdate,Pl.idPdPkLot,Pl.idPdPk, Ps.PdCode, Ps.Barcode, Ps.PdPkName,Ps.PkUnitName,Pr.AmountBefore " & _
                                ",Pr.AmountOperate ,Pr.AmountAfter,Pr.LotNum,Pr.Grade,Pr.Grow,Pr.Humid,Pr.Pure,Pr.note,Pr.DateDoc,Pr.DocNum,Pr.stMecMade,Pr.stHumMade" & _
                                ",Pr.idWh, Wh.WareHouseName, Pl.DateGen" & _
                                " From PkPdPkUpdateRec Pr LEFT JOIN dPackingPdSetLot Pl ON Pr.idUpdate = Pl.idUpdate LEFT JOIN vPackingPdSet Ps ON Ps.idPdPk = Pl.idPdPk  " & _
                                " LEFT JOIN SsWarehouse Wh ON Wh.idWh = Pr.idWh WHERE Pr.stDel = 0 And Pr.DateTs = " & ksbDateToString(DateTimePicker2.Value)
        sAdapter.Fill(sDt)
        If sDt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", sSystemName)
        Else
            btn_save.Enabled = True
            For i As Integer = 0 To sDt.Rows.Count - 1
                pidUpdate = sDt.Rows(i).Item("idUpdate")
                idPdPk = sDt.Rows(i).Item("idPdPk")
                pCode = ""
                pBarcode = ""
                pAmountBefore = sDt.Rows(i).Item("AmountBefore")
                pAmountOperate = sDt.Rows(i).Item("AmountOperate")
                pAmountAfter = sDt.Rows(i).Item("AmountAfter")
                punit = sDt.Rows(i).Item("PkUnitName")
                pLotNum = sDt.Rows(i).Item("LotNum")
                pGrade = sDt.Rows(i).Item("Grade")
                pGrow = sDt.Rows(i).Item("Grow")
                pHumid = sDt.Rows(i).Item("Humid")
                pPure = sDt.Rows(i).Item("Pure")
                pnote = sDt.Rows(i).Item("note")
                pPkName = sDt.Rows(i).Item("PdPkName")
                pidPdPkLot = sDt.Rows(i).Item("idPdPkLot")
                pidWhRec = sDt.Rows(i).Item("idWh")
                pInvNameRec = sDt.Rows(i).Item("WareHouseName")
                If sDt.Rows(i).Item("DateGen") Is DBNull.Value Then
                    DateGen = ""
                Else
                    DateGen = sDt.Rows(i).Item("DateGen")
                End If
                If sDt.Rows(i).Item("DateDoc") Is DBNull.Value Then
                    DateDoc = ""
                Else
                    DateDoc = sDt.Rows(i).Item("DateDoc")
                End If

                If sDt.Rows(i).Item("DocNum") Is DBNull.Value Then
                    pDocNum = ""
                Else
                    pDocNum = sDt.Rows(i).Item("DocNum")
                End If

                phum = sDt.Rows(i).Item("stMecMade")
                pmec = sDt.Rows(i).Item("stHumMade")

                dgvPd.Rows.Add(Nothing, Nothing, pidUpdate, idPdPk, ksbStringToDate(DateDoc), pDocNum, pLotNum, ksbStringToDate(DateGen), pBarcode, pCode, pPkName, punit, pAmountBefore, pAmountOperate, pAmountAfter, pGrade, pGrow, pHumid, pPure, pInvNameRec, pnote, pmec, phum, Nothing, pidPdPkLot, pidWhRec)
                ''DataPdOrder.Rows.Add(Nothing, idPdPk, pBarcode, pCode, Nothing, pPkName, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, "0", sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)
            Next


        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            btn_s.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            btn_s.Enabled = False
            DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show(calDate(Date.Now))
    End Sub

    Private Function calDate(ByVal Dateval As Date) As String
        Dim DateCal As String = Dateval.Year
        Dim DateFullCal As String = ""
        If CType(DateCal, Integer) < 2500 Then
            DateFullCal = Dateval.Year + 543
        Else
            DateFullCal = Dateval.Year - 543
        End If
        Return Dateval.Day & "/" & Format(Dateval.Month, "00") & "/" & DateFullCal

    End Function

    Private Sub dgvPd_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPd.CellEnter
        If sender.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly Then
            If lastIndexColCell > e.ColumnIndex Then
                SendKeys.Send("+{TAB}")
            Else
                SendKeys.Send("{TAB}")
            End If
        End If
        lastIndexColCell = e.ColumnIndex
    End Sub

    Private Sub dgvPd_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPd.KeyDown
        Dim pBarcode As String = ""
        Dim pCode As String = ""
        Dim punit As String = ""
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If dgvPd.Columns(dgvPd.CurrentCell.ColumnIndex).Name = btn_add.Name Then
                Dim sDt_pddata As New DataTable
                Dim flag As Integer = 0
                Dim vFrm As New frmPdPkSelect(frmPdPkSelect.eProcess.ePdAmount)
                If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    idPdPk = vFrm.idPdPk
                    pCode = vFrm.PdCodeS
                    pBarcode = vFrm.Barcode
                End If
                'For i As Integer = 0 To dgvPd.Rows.Count - 2
                '    If dgvPd.Rows(i).Cells("idPd").Value = idPdPk Then
                '        flag = 1
                '        Exit For
                '    End If
                'Next
                If flag = 0 Then
                    Try
                        mdCnOpen()
                        Dim sDt As New DataTable
                        sCommand.CommandText = "Select idPdPk,PdPkName,Amount,PkUnitName From vPackingPdSet WHERE idPdPk = " & idPdPk
                        sAdapter.Fill(sDt_pddata)
                        punit = sDt_pddata.Rows(0).Item("PkUnitName")
                        dgvPd.Rows.Add(Nothing, 0, idPdPk, "", pBarcode, pCode, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, "0", sDt_pddata.Rows(0).Item(2).ToString, Nothing)
                        'DataPdOrder.Rows.Add(Nothing, idPdPk, "", pBarcode, pCode, Nothing, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, "0", sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)
                        'For i As Integer = 0 To dgvPd.Rows.Count - 2
                        '    dgvPd.Rows(i).Cells("Operetor").Value = "+"
                        'Next
                    Catch ex As Exception
                        Exit Sub
                    End Try

                Else
                    MessageBox.Show("สินค้าซ้ำกรุณาเลือกสินค้าชนิดอื่น", sSystemName)
                End If
            End If
            dgvPd.CurrentCell = dgvPd(dgvPd.Columns.Item(LotNum.Name).Index, dgvPd.CurrentCell.RowIndex - 1)
        End If

    End Sub
    Private Function chksave() As Boolean
        Dim str As String = ""
        Dim flag2 As Boolean

        For i As Integer = 0 To dgvPd.Rows.Count - 1
            If dgvPd.Rows(i).Cells("LotNum").Value = "" Then
                dgvPd.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                str = "ไม่สามารถบันทึกได้ ไม่มีข้อมูลเลขที่ Lot "
                flag2 = True
                Exit For
            End If
            If CType(dgvPd.Rows(i).Cells("ChangeAmount").Value, Integer) < 0 Then
                dgvPd.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                flag2 = True
                str = "ไม่สามารถบันทึกได้ ตัวเลขยอดคงเหลือติดลบ"
                Exit For
            End If
        Next
        If flag2 Then
            MessageBox.Show(str, sSystemName)
        End If
        Return flag2
    End Function

    'Private Sub dgvPd_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPd.CellValueChanged
    '    'If dgvPd.Columns(e.ColumnIndex).Name = chkMec.Name Then
    '    '    Dim value As Integer = dgvPd.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    '    '    MessageBox.Show(value.ToString)
    '    'End If

    'End Sub

    'Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles btnaddPd.Click
    '    Dim vFrm As New frmPdPkPackingStockTempAddData(frmPdPkPackingStockTempAddData.eProcess.eSelect)
    '    Dim pBarcode As String = ""
    '    Dim pCode As String = ""
    '    Dim punit As String = ""
    '    Dim pAmount As Integer = 0
    '    Dim pLotNum As String = ""
    '    Dim pDocNum As String = ""
    '    Dim DateDoc As String = ""
    '    Dim DateGen As String = ""
    '    Dim pCost As String = ""
    '    Dim pCostPerPiece As String = ""
    '    Dim note As String = ""
    '    Dim hum As Integer = 0
    '    Dim mec As Integer = 0
    '    Dim idWh As String = ""
    '    Dim InvName As String = ""
    '    Dim sDt_pddata As New DataTable
    '    Dim flag As Integer = 0
    '    vFrm.ShowDialog()

    '    If vFrm.DialogResult = Windows.Forms.DialogResult.OK Then
    '        idPdPk = vFrm.idPdPk
    '        pCode = vFrm.pCode
    '        pBarcode = vFrm.pBarcode
    '        pAmount = vFrm.pAmount
    '        pLotNum = vFrm.pLotNum
    '        DateDoc = vFrm.DocDate
    '        pDocNum = vFrm.DocNum
    '        note = vFrm.Note
    '        hum = vFrm.hum
    '        mec = vFrm.mec
    '        InvName = vFrm.pInvNameSent
    '        idWh = vFrm.pidWhSent
    '        btn_save.Enabled = True
    '        DateGen = vFrm.DateGen
    '        pCost = vFrm.Cost
    '        pCostPerPiece = vFrm.CostPerPiece
    '    Else
    '        flag = 1
    '    End If
    '    'For i As Integer = 0 To dgvPd.Rows.Count - 2
    '    '    If dgvPd.Rows(i).Cells("idPd").Value = idPdPk Then
    '    '        flag = 1
    '    '        Exit For
    '    '    End If
    '    'Next
    '    If flag = 0 Then
    '        Try
    '            mdCnOpen()
    '            Dim sDt As New DataTable
    '            sCommand.CommandText = "Select idPdPk,PdPkName,Amount,PkUnitName From vPackingPdSet WHERE idPdPk = " & idPdPk
    '            sAdapter.Fill(sDt_pddata)
    '            punit = sDt_pddata.Rows(0).Item("PkUnitName")
    '            dgvPd.Rows.Add(Nothing, Nothing, 0, idPdPk, DateDoc, pDocNum, pLotNum, DateGen, pBarcode, pCode, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, pAmount, (sDt_pddata.Rows(0).Item(2) + pAmount).ToString, "-", 0, 0, 0, InvName, note, mec, hum, Nothing, 0, idWh)
    '            'DataPdOrder.Rows.Add(Nothing, Nothing, idPdPk, DateDoc, pLotNum, pBarcode, pCode, Nothing, sDt_pddata.Rows(0).Item(1).ToString, punit, sDt_pddata.Rows(0).Item(2).ToString, Nothing, pAmount, sDt_pddata.Rows(0).Item(2).ToString, "", "", Nothing)
    '            'For i As Integer = 0 To dgvPd.Rows.Count - 2
    '            '    dgvPd.Rows(i).Cells("Operetor").Value = "+"
    '            'Next
    '        Catch ex As Exception
    '            Exit Sub
    '        End Try
    '    End If

    'End Sub

    Private Sub frmPdPkPackingStockTemp_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        btnaddPd.Focus()
        If stpage = 3 Then
            BinddataShow()
            colEdit.Visible = False
            btn_save.Enabled = False
            dgvPd.Enabled = False
        End If
    End Sub


End Class