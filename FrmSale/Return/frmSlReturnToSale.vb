Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient

Public Class frmSlReturnToSale
    Dim Result As DialogResult
    Dim CopyReturnMt As New DataTable
    Dim CopyReturnDt As New DataTable
    'Dim PdMainDt As New DataTable

    Dim stRight As Integer = 0
    Dim CopyNewSaleMt As New DataTable
    Dim CopyNewSaleDt As New DataTable
    Dim idReturn As Integer = 0
    Dim idSale As Integer = 0
    'Dim stPage As String = 0
    Dim eEvent As eProcess
    Dim gidComp As Integer = 0
    Dim idFM As Integer = 0
    Dim idCus As Integer = 0
    Dim idPartner As Integer = 0
    Dim dtDel As New DataTable

    Enum eProcess
        eNew
        eView
        eAccept
        eCheck
        eApprove
        eEdit
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idSaleReturn As Integer, ByVal vidSale As Integer, ByVal idComp As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eNew
                'stPage = 1
                idReturn = idSaleReturn
            Case eProcess.eView
                'stPage = 2
                idSale = vidSale
                Me.Text = "ข้อมูลรายการขายสินค้า จากรายการคืน (JU>>>XY)"
            Case eProcess.eAccept
                'stPage = 3
                idSale = vidSale
                Me.Text = "รับทราบ รายการขายสินค้า จากรายการคืน (JU>>>XY)"
            Case eProcess.eCheck
                'stPage = 4
                idSale = vidSale
                Me.Text = "ตรวจสอบ รายการขายสินค้า จากรายการคืน (JU>>>XY)"
            Case eProcess.eApprove
                'stPage = 5
                idSale = vidSale
                Me.Text = "อนุมัติ รายการขายสินค้า จากรายการคืน (JU>>>XY)"
            Case eProcess.eEdit
                'stPage = 6
                idSale = vidSale
                Me.Text = "แก้ไข รายการขายสินค้า จากรายการคืน (JU>>>XY)"
                btnPdInc.Visible = False
        End Select
        eEvent = aProcess

        gidComp = idComp
    End Sub

    Private Sub frmSlReturnToSale_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dtDel.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
        dtDel.Columns.Add("idLot", System.Type.GetType("System.Int32"))
        dtDel.Columns.Add("idWh", System.Type.GetType("System.Int32"))
        dtDel.Columns.Add("idSaleDt", System.Type.GetType("System.Int32"))
        dtDel.Columns.Add("AmtSale", System.Type.GetType("System.Double"))
        dtDel.Columns.Add("LotNo", System.Type.GetType("System.String"))





        setCmbGroupComp(Me.cmbGroupComp)

        cmbGroupComp.SelectedValue = gidComp

        If eEvent = eProcess.eNew Then 'New        
            lblDateTs.Text = Date.Today
            lblPsTs.Text = sPsName
            lblPsTs.Tag = sPsId
            lblTimeText.Visible = False
            lbltime.Visible = False
            cmbTransport()
            cmbDRefCode()
            cmbPayTps()

            '--- Show Detail Of Return-JU ---'
            mdCnOpen()
            Dim sDt As New DataTable
            sDt.Clear()

            sCommand.CommandText = "SELECT  mt.idPartner, p.PartnerName, mt.idPsSale, vp.PsName As PsSale, c.idRefAdrS, ad.AddressS, ad.idTsp AS idTspS ," & vbNewLine & _
                                    "ad.idPayTsp AS idPayTspS, ad.PsRecName, ad.idSupTsp AS idSupTspS, s.SupName AS SupNameS, ISNULL(p.idFM,0) As idFM,ISNULL(p.idCus,0) As idCus" & vbNewLine & _
                                    "FROM SmSaleReturnMt mt " & vbNewLine & _
                                    "LEFT JOIN dPartner p ON  mt.idPartner =  p.idPartner" & vbNewLine & _
                                    "LEFT JOIN vCustomer c ON mt.idCus = c.idCus" & vbNewLine & _
                                    "LEFT JOIN vPersonxSelect vp ON mt.idPsSale = vp.idPs " & vbNewLine & _
                                    "LEFT JOIN dCustomerAdrSent ad ON c.idRefAdrS = ad.idCusRefAddr" & vbNewLine & _
                                    "LEFT JOIN PchInvAndProject.dbo.dSupplier AS s ON ad.idSupTsp = s.idSup" & vbNewLine & _
                                    "WHERE mt.idSaleReturn = " & idReturn

            sAdapter.Fill(sDt)

            idPartner = sDt.Rows(0).Item("idPartner")
            idCus = sDt.Rows(0).Item("idCus")
            idFM = sDt.Rows(0).Item("idFM")

            Me.lblPsCus.Text = sDt.Rows(0).Item("PartnerName")
            Me.lblAddr.Tag = sDt.Rows(0).Item("idRefAdrS")
            Me.lblAddr.Text = sDt.Rows(0).Item("AddressS")

            Me.btnAddressS.Enabled = True
            Me.lblPsSale.Tag = sDt.Rows(0).Item("idPsSale")
            Me.lblPsSale.Text = sDt.Rows(0).Item("PsSale")
            Me.CmbTs.SelectedValue = sDt.Rows(0).Item("idTspS")
            If Not IsDBNull(sDt.Rows(0).Item("idPayTspS")) Then
                cmbTypePayTrp.SelectedValue = sDt.Rows(0).Item("idPayTspS")
            End If
            If Not IsDBNull(sDt.Rows(0).Item("idSupTspS")) Then
                If sDt.Rows(0).Item("idSupTspS") <> 0 Then
                    Me.lblTspComp.Tag = sDt.Rows(0).Item("idSupTspS")
                    Me.lblTspComp.Text = sDt.Rows(0).Item("SupNameS")
                End If
            End If
            Me.lblCusRec.Text = sDt.Rows(0).Item("PsRecName")

            '--- Show Return-Dt ---'
            Dim ds0 As New DataSet
            Dim ReturnMt As New DataTable 'Mt
            Dim ReturnDt As New DataTable 'Dt

            ReturnMt.Columns.Add("DocRefCode", System.Type.GetType("System.String"))
            ReturnMt.Columns.Add("idSaleReturn", System.Type.GetType("System.Int32"))

            Dim tempMtDt As New DataTable
            tempMtDt.Clear()
            sCommand.CommandText = "SELECT  DocRefCode, idSaleReturn FROM vSmSaleReturnMt mt WHERE idSaleReturn = " & idReturn
            sAdapter.Fill(tempMtDt)
            ReturnMt.Rows.Add(tempMtDt.Rows(0).Item("DocRefCode"), tempMtDt.Rows(0).Item("idSaleReturn"))

            ReturnDt.Columns.Add("idSaleReturn", System.Type.GetType("System.Int32"))
            ReturnDt.Columns.Add("InvName", System.Type.GetType("System.String"))
            ReturnDt.Columns.Add("AmountReturn", System.Type.GetType("System.Double"))
            ReturnDt.Columns.Add("UnitName", System.Type.GetType("System.String"))
            ReturnDt.Columns.Add("DtType", System.Type.GetType("System.Int32"))

            Dim listRTDt As New DataTable
            listRTDt.Clear()
            'sCommand.CommandText = "SELECT idSaleReturn, PdPkName, AmountReturn, PkUnitName FROM vSmSaleReturnDt WHERE idSaleReturn = " & idReturn
            sCommand.CommandText = "SELECT dt.idSaleReturn, inv.InvName, dt.AmountReturn, unit.UnitName, g.DtType" & vbNewLine & _
                                   "FROM SmSaleReturnDt dt" & vbNewLine & _
                                   "LEFT JOIN dInventoryMain inv ON dt.idInvMain = inv.idInvMain" & vbNewLine & _
                                   "LEFT JOIN dInvUnit unit On dt.idUnit = unit.idUnit" & vbNewLine & _
                                   "LEFT JOIN dInvGroup g ON inv.idInvGroup = g.idInvGroup" & vbNewLine & _
                                   "WHERE idSaleReturn = " & idReturn


            sAdapter.Fill(listRTDt)
            For i As Integer = 0 To listRTDt.Rows.Count - 1
                ReturnDt.Rows.Add(listRTDt.Rows(i).Item("idSaleReturn"), listRTDt.Rows(i).Item("InvName"), listRTDt.Rows(i).Item("AmountReturn"), _
                                  listRTDt.Rows(i).Item("UnitName"), listRTDt.Rows(i).Item("DtType"))
            Next

            CopyReturnMt = ReturnMt
            CopyReturnDt = ReturnDt

            ds0.Tables.Clear()
            ds0.Tables.Add(ReturnMt)
            ds0.Tables.Add(ReturnDt)

            Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idSaleReturn")
            Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idSaleReturn")

            ds0.Relations.Add("รายการคืน", keyColumn, foreignColumn)

            If ds0.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("ไม่พบข้อมูลรายการคืนสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            GridControl1.DataSource = ds0.Tables(0)
            GridControl1.ForceInitialize()

            GridControl1.LevelTree.Nodes.Add("รายการคืน", GVReturnDt)

            '---- Show New-Pd----'
            Dim ds1 As New DataSet
            Dim NewSaleMt As New DataTable 'Mt
            Dim NewSaleDt As New DataTable 'Dt

            NewSaleMt.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
            NewSaleMt.Columns.Add("InvCode", System.Type.GetType("System.String"))
            NewSaleMt.Columns.Add("InvName", System.Type.GetType("System.String"))
            NewSaleMt.Columns.Add("Amount", System.Type.GetType("System.Double"))
            NewSaleMt.Columns.Add("AmtReal", System.Type.GetType("System.Double"))
            NewSaleMt.Columns.Add("UnitName", System.Type.GetType("System.String"))
            NewSaleMt.Columns.Add("SumExp", System.Type.GetType("System.Double"))
            NewSaleMt.Columns.Add("DtType", System.Type.GetType("System.Int32"))
            NewSaleMt.Columns.Add("idSaleRT", System.Type.GetType("System.Int32"))
            NewSaleMt.Columns.Add("idJUDt", System.Type.GetType("System.Int32"))

            Dim NewtempDt As New DataTable
            NewtempDt.Clear()

            sCommand.CommandText = "SELECT ju.idInvMain, inv.InvCode, inv.InvName, unit.UnitName, (ju.Amount - ISNULL(ju.AmountCut, 0.0)) As Amount," & vbNewLine & _
                                    "ju.idUnit, ju.idSaleReturn, ju.idJUDt, g.DtType" & vbNewLine & _
                                    "FROM SmSaleReturnJUDt ju" & vbNewLine & _
                                    "LEFT JOIN dInventoryMain inv ON ju.idInvMain = inv.idInvMain" & vbNewLine & _
                                    "LEFT JOIN dInvUnit unit ON ju.idUnit = unit.idUnit" & vbNewLine & _
                                    "LEFT JOIN dInvGroup g ON inv.idInvGroup = g.idInvGroup" & vbNewLine & _
                                    "WHERE ju.Amount <> ISNULL(ju.AmountCut,0)" & vbNewLine & _
                                    "And ju.idSaleReturn = " & idReturn

            sAdapter.Fill(NewtempDt)

            For i As Integer = 0 To NewtempDt.Rows.Count - 1
                NewSaleMt.Rows.Add(NewtempDt.Rows(i).Item("idInvMain"), NewtempDt.Rows(i).Item("InvCode"), NewtempDt.Rows(i).Item("InvName"), _
                                   NewtempDt.Rows(i).Item("Amount"), 0.0, NewtempDt.Rows(i).Item("UnitName"), 0.0, NewtempDt.Rows(i).Item("DtType"), _
                                   NewtempDt.Rows(i).Item("idSaleReturn"), NewtempDt.Rows(i).Item("idJUDt"))
            Next

            NewSaleDt.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
            NewSaleDt.Columns.Add("idLot", System.Type.GetType("System.Int32"))
            NewSaleDt.Columns.Add("LotNo", System.Type.GetType("System.String"))
            NewSaleDt.Columns.Add("AmtStock", System.Type.GetType("System.Double")) 'จำนวน Lot คงเหลือ
            NewSaleDt.Columns.Add("AmtSale", System.Type.GetType("System.Double")) 'จำนวนขายสินค้า XY ที่เอามาแทน
            NewSaleDt.Columns.Add("UnitName", System.Type.GetType("System.String"))
            NewSaleDt.Columns.Add("Price", System.Type.GetType("System.Double"))
            NewSaleDt.Columns.Add("Exp", System.Type.GetType("System.Double"))
            NewSaleDt.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
            NewSaleDt.Columns.Add("AmtHide", System.Type.GetType("System.Double"))
            NewSaleDt.Columns.Add("idSaleDt", System.Type.GetType("System.Int32"))
            NewSaleDt.Columns.Add("OldStock", System.Type.GetType("System.Double"))
            NewSaleDt.Columns.Add("OldAmt", System.Type.GetType("System.Double"))
            NewSaleDt.Columns.Add("DtType", System.Type.GetType("System.Int32"))
            NewSaleDt.Columns.Add("idWh", System.Type.GetType("System.Int32"))
            NewSaleDt.Columns.Add("idInvGroup", System.Type.GetType("System.Int32"))
            ' GCProduct.DataSource = PdMainDt
            CopyNewSaleMt = NewSaleMt
            CopyNewSaleDt = NewSaleDt

            ds1.Tables.Clear()
            ds1.Tables.Add(NewSaleMt)
            ds1.Tables.Add(NewSaleDt)

            Dim keyColumn2 As DataColumn = ds1.Tables(0).Columns("idInvMain")
            Dim foreignColumn2 As DataColumn = ds1.Tables(1).Columns("idInvMain")

            ds1.Relations.Add("ล็อตสินค้า", keyColumn2, foreignColumn2)

            GCProduct.DataSource = ds1.Tables(0)
            GCProduct.ForceInitialize()

            GCProduct.LevelTree.Nodes.Add("ล็อตสินค้า", GvLot)

            'PdMainDt.DefaultView.Sort = "dtType, idProduct"

        Else 'Edit / view

            '--- Show SmSaleMt ---'
            BindData()
        End If
    End Sub
    Private Sub BindData()
        mdCnOpen()
        Dim vDt As New DataTable
        vDt.Clear()

        sCommand.CommandText = "SELECT mt.DocCode, mt.DocRefAcc, mt.idSaleCode, mt.DocRef, mt.DateSaleD, mt.DateTsD, mt.TimeTs, pt.PsName As PsTs, mt.idPsTs," & vbNewLine & _
                                "p.PartnerName, mt.idPartner, ISNULL(p.idCus,0) As idCus, ISNULL(p.idFM,0) As idFM, ad.AddressS As AddressSent, ad.idCusRefAddr," & vbNewLine & _
                                "ps.PsName As PsSale, mt.idTs, mt.idPsSale, mt.idSupTsp, sup.SupName, ad.idPayTsp, mt.Note,mt.stRight, ad.PsRecName, sup.SupName" & vbNewLine & _
                                "FROM SmSaleMt mt" & vbNewLine & _
                                "LEFT JOIN dPartner p ON mt.idPartner = p.idPartner" & vbNewLine & _
                                "LEFT JOIN vCustomer c ON mt.idCus = c.idCus" & vbNewLine & _
                                "LEFT JOIN vPersonxSelect pt ON mt.idPsTs = pt.idPs" & vbNewLine & _
                                "LEFT JOIN vPersonxSelect ps ON mt.idPsTs = ps.idPs" & vbNewLine & _
                                "LEFT JOIN dCustomerAdrSent ad ON c.idRefAdrS = ad.idCusRefAddr" & vbNewLine & _
                                "LEFT JOIN PchInvAndProject.dbo.dSupplier sup ON mt.idSupTsp = sup.idSup" & vbNewLine & _
                                "WHERE mt.idSale= " & idSale
        sAdapter.Fill(vDt)

        Me.lblPsCus.Text = vDt.Rows(0).Item("PartnerName")

        idPartner = vDt.Rows(0).Item("idPartner")
        idCus = vDt.Rows(0).Item("idCus")
        idFM = vDt.Rows(0).Item("idFM")

        Me.lblDocCode.Text = vDt.Rows(0).Item("DocCode")
        If IsDBNull(vDt.Rows(0).Item("DocRefAcc")) = True Then
            Me.lblRefAcc.Text = ""
        Else
            Me.lblRefAcc.Text = vDt.Rows(0).Item("DocRefAcc")
        End If

        cmbDRefCode()
        cmbDRCode.SelectedValue = vDt.Rows(0).Item("idSaleCode")
        Dim DocRef() As String = vDt.Rows(0).Item("DocRef").ToString.Split(" ")
        If DocRef.Length > 1 Then
            'cmbDRCode.Text = DocRef(0)
            txtDocRef.Text = DocRef(1)
        End If

        Me.dtpSale.Value = vDt.Rows(0).Item("DateSaleD")
        Me.lblDateTs.Text = vDt.Rows(0).Item("DateTsD")
        If Not IsDBNull(vDt.Rows(0).Item("TimeTs")) Then
            Me.lbltime.Text = vDt.Rows(0).Item("TimeTs")
            Me.lbltime.Visible = True
            Me.lblTimeText.Visible = True
        End If
        Me.lblPsTs.Text = vDt.Rows(0).Item("PsTs")
        Me.lblPsTs.Tag = vDt.Rows(0).Item("idPsTs")


        Me.btnAddressS.Enabled = True
        If Not IsDBNull(vDt.Rows(0).Item("AddressSent")) Then
            Me.lblAddr.Text = vDt.Rows(0).Item("AddressSent")
            Me.lblAddr.Tag = vDt.Rows(0).Item("idCusRefAddr")
        Else ' Old case : No set idCusRefAddr on SmSaleMt
            Me.lblAddr.Text = vDt.Rows(0).Item("AddressS")
            Me.lblAddr.Tag = 0
        End If
        Me.lblCusRec.Text = vDt.Rows(0).Item("PsRecName")
        Me.lblPsSale.Text = vDt.Rows(0).Item("PsSale")
        Me.lblPsSale.Tag = vDt.Rows(0).Item("idPsSale")

        If Not IsDBNull(vDt.Rows(0).Item("stRight")) Then
            stRight = vDt.Rows(0).Item("stRight")
            'If vDt.Rows(0).Item("stRight") = 1 Then
            '    Me.rdbRight.Checked = True
            'ElseIf vDt.Rows(0).Item("stRight") = 0 Then
            '    Me.rdbNoRight.Checked = True
            'End If
        End If


        cmbTransport()
        If Not IsDBNull(vDt.Rows(0).Item("idTs")) Then
            CmbTs.SelectedValue = vDt.Rows(0).Item("idTs")
        End If
        cmbPayTps()
        If Not IsDBNull(vDt.Rows(0).Item("idPayTsp")) Then
            cmbTypePayTrp.SelectedValue = vDt.Rows(0).Item("idPayTsp")
        End If
        If Not IsDBNull(vDt.Rows(0).Item("idSupTsp")) Then
            Me.lblTspComp.Tag = vDt.Rows(0).Item("idSupTsp")
            Me.lblTspComp.Text = vDt.Rows(0).Item("SupName")
        End If
        Me.txtNote.Text = vDt.Rows(0).Item("note")



        '--- Show Return-Dt ---'
        Dim ds0 As New DataSet
        Dim ReturnMt As New DataTable 'Mt
        Dim ReturnDt As New DataTable 'Dt

        ReturnMt.Columns.Add("DocRefCode", System.Type.GetType("System.String"))
        ReturnMt.Columns.Add("idSaleReturn", System.Type.GetType("System.Int32"))

        ReturnDt.Columns.Add("idSaleReturn", System.Type.GetType("System.Int32"))
        ReturnDt.Columns.Add("InvName", System.Type.GetType("System.String"))
        ReturnDt.Columns.Add("AmountReturn", System.Type.GetType("System.Double"))
        ReturnDt.Columns.Add("UnitName", System.Type.GetType("System.String"))

        Dim tempMtDt As New DataTable
        tempMtDt.Clear()
        'sCommand.CommandText = "SELECT distinct rt.DocRefCode, rt.idSaleReturn FROM vSmSaleDetail s LEFT OUTER JOIN " & _
        '                       "vSmSaleReturnMt rt ON s.idsaleReturn = rt.idsaleReturn WHERE s.idSale = " & idSale
        sCommand.CommandText = "SELECT distinct c.ReturnCode + ' ' + rmt.DocRef AS DocRefCode, rmt.idSaleReturn" & vbNewLine & _
                                "FROM SmSaleDtAll s " & vbNewLine & _
                                "LEFT JOIN SmSaleReturnMt rmt ON s.idsaleReturn = rmt.idsaleReturn" & vbNewLine & _
                                "LEFT JOIN SmSaleReturnCode c ON rmt.idRTDocCode = c.idRTDocCode" & vbNewLine & _
                                "WHERE s.idSale = " & idSale
        sAdapter.Fill(tempMtDt)

        For k As Integer = 0 To tempMtDt.Rows.Count - 1
            If Not IsDBNull(tempMtDt.Rows(k).Item("idSaleReturn")) Then
                ReturnMt.Rows.Add(tempMtDt.Rows(k).Item("DocRefCode"), tempMtDt.Rows(k).Item("idSaleReturn"))

                Dim listRTDt As New DataTable
                listRTDt.Clear()

                sCommand.CommandText = "SELECT idSaleReturn, inv.InvName, AmountReturn, unit.UnitName  " & vbNewLine & _
                                        "FROM SmSaleReturnDt dt" & vbNewLine & _
                                        "LEFT JOIN dInventoryMain inv ON inv.idInvMain = dt.idInvMain" & vbNewLine & _
                                        "LEFT JOIN dInvUnit unit ON inv.idUnit = unit.idUnit " & vbNewLine & _
                                        "WHERE idSaleReturn = " & tempMtDt.Rows(k).Item("idSaleReturn")


                sAdapter.Fill(listRTDt)
                For i As Integer = 0 To listRTDt.Rows.Count - 1
                    ReturnDt.Rows.Add(listRTDt.Rows(i).Item("idSaleReturn"), listRTDt.Rows(i).Item("InvName"), listRTDt.Rows(i).Item("AmountReturn"), _
                                      listRTDt.Rows(i).Item("UnitName"))
                Next
            End If
        Next

        CopyReturnMt = ReturnMt
        CopyReturnDt = ReturnDt

        ds0.Tables.Clear()
        ds0.Tables.Add(ReturnMt)
        ds0.Tables.Add(ReturnDt)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idSaleReturn")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idSaleReturn")

        ds0.Relations.Add("รายการคืน", keyColumn, foreignColumn)

        If ds0.Tables(0).Rows.Count <= 0 And eEvent = eProcess.eNew Then 'Only new-enum
            MessageBox.Show("ไม่พบข้อมูลรายการคืนสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        GridControl1.DataSource = ds0.Tables(0)
        GridControl1.ForceInitialize()

        GridControl1.LevelTree.Nodes.Add("รายการคืน", GVReturnDt)

        '---- Show Sale Detail----'
        Dim ds1 As New DataSet
        Dim NewSaleMt As New DataTable 'Mt
        Dim NewSaleDt As New DataTable 'Dt

        NewSaleMt.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
        NewSaleMt.Columns.Add("InvCode", System.Type.GetType("System.String"))
        NewSaleMt.Columns.Add("InvName", System.Type.GetType("System.String"))
        NewSaleMt.Columns.Add("Amount", System.Type.GetType("System.Double")) 'จำนวนเบิกได้
        NewSaleMt.Columns.Add("AmtReal", System.Type.GetType("System.Double")) 'จำนวนเบิกเจริง
        NewSaleMt.Columns.Add("UnitName", System.Type.GetType("System.String"))
        NewSaleMt.Columns.Add("SumExp", System.Type.GetType("System.Double"))
        NewSaleMt.Columns.Add("dtType", System.Type.GetType("System.Int32"))
        NewSaleMt.Columns.Add("idSaleRT", System.Type.GetType("System.Int32"))
        NewSaleMt.Columns.Add("idJUDt", System.Type.GetType("System.Int32"))

        Dim NewtempDt As New DataTable
        NewtempDt.Clear()

        sCommand.CommandText = "SELECT distinct dt.idProduct, inv.InvCode, ProductName, unit.UnitName, dt.dtType, dt.idSaleReturn," & vbNewLine & _
                                "(ju.Amount - ISNULL(ju.AmountCut, 0.0)) As Amount " & vbNewLine & _
                                "FROM SmSaleDtAll dt" & vbNewLine & _
                                "LEFT JOIN SmSaleReturnJUDt ju ON dt.idSaleReturn = ju.idSaleReturn" & vbNewLine & _
                                "LEFT JOIN dInventoryMain inv ON dt.idProduct = inv.idInvmain" & vbNewLine & _
                                "LEFT JOIN dInvUnit unit ON dt.idUnit = unit.idUnit" & vbNewLine & _
                                "WHERE idSale = " & idSale & ""
        sAdapter.Fill(NewtempDt)

        For i As Integer = 0 To NewtempDt.Rows.Count - 1
            NewSaleMt.Rows.Add(NewtempDt.Rows(i).Item("idProduct"), NewtempDt.Rows(i).Item("InvCode"), NewtempDt.Rows(i).Item("ProductName"), _
                               NewtempDt.Rows(i).Item("Amount"), 0.0, NewtempDt.Rows(i).Item("UnitName"), 0.0, NewtempDt.Rows(i).Item("dtType"), _
                               NewtempDt.Rows(i).Item("idSaleReturn"), 0)
        Next

        NewSaleDt.Columns.Add("idInvMain", System.Type.GetType("System.Int32"))
        NewSaleDt.Columns.Add("idLot", System.Type.GetType("System.Int32"))
        NewSaleDt.Columns.Add("LotNo", System.Type.GetType("System.String"))
        NewSaleDt.Columns.Add("AmtStock", System.Type.GetType("System.Double"))
        NewSaleDt.Columns.Add("AmtSale", System.Type.GetType("System.Double"))
        NewSaleDt.Columns.Add("UnitName", System.Type.GetType("System.String"))
        NewSaleDt.Columns.Add("Price", System.Type.GetType("System.Double"))
        NewSaleDt.Columns.Add("Exp", System.Type.GetType("System.Double"))
        NewSaleDt.Columns.Add("idUnit", System.Type.GetType("System.Int32"))
        NewSaleDt.Columns.Add("AmtHide", System.Type.GetType("System.Double"))
        NewSaleDt.Columns.Add("idSaleDt", System.Type.GetType("System.Int32"))
        NewSaleDt.Columns.Add("OldStock", System.Type.GetType("System.Double"))
        NewSaleDt.Columns.Add("OldAmt", System.Type.GetType("System.Double"))
        NewSaleDt.Columns.Add("DtType", System.Type.GetType("System.Int32"))
        NewSaleDt.Columns.Add("idWh", System.Type.GetType("System.Int32"))

        Dim NewtempDt2 As New DataTable
        NewtempDt2.Clear()

        sCommand.CommandText = "SELECT dt.idProduct, dt.idLot, dt.LotNo, dt.Amount As AmtSale, dt.idWh, " & vbNewLine & _
                                "(select Sum(Amount) From dInvLotRefWh WHERE dt.idLot = dInvLotRefWh.idLot AND dt.idWh = dInvLotRefWh.idWh ) As AmtStock," & vbNewLine & _
                                "unit.UnitName, dt.Price, dt.idUnit, dt.idSaleDt, dt.DtType" & vbNewLine & _
                                "FROM SmSaleDtAll dt" & vbNewLine & _
                                "LEFT JOIN dInvUnit unit ON dt.idUnit = unit.idUnit" & vbNewLine & _
                                "WHERE idSale = " & idSale
        sAdapter.Fill(NewtempDt2)

        For i As Integer = 0 To NewtempDt2.Rows.Count - 1
            NewSaleDt.Rows.Add(NewtempDt2.Rows(i).Item("idProduct"), NewtempDt2.Rows(i).Item("idLot"), NewtempDt2.Rows(i).Item("LotNo"), _
                               NewtempDt2.Rows(i).Item("AmtStock"), NewtempDt2.Rows(i).Item("AmtSale"), NewtempDt2.Rows(i).Item("UnitName"), _
                               NewtempDt2.Rows(i).Item("Price"), _
                               NewtempDt2.Rows(i).Item("AmtSale") * NewtempDt2.Rows(i).Item("Price"), NewtempDt2.Rows(i).Item("idUnit"), _
                               NewtempDt2.Rows(i).Item("AmtSale"), NewtempDt2.Rows(i).Item("idSaleDt"), NewtempDt2.Rows(i).Item("AmtStock"), NewtempDt2.Rows(i).Item("AmtSale"), _
                               NewtempDt2.Rows(i).Item("DtType"), NewtempDt2.Rows(i).Item("idWh"))
        Next

        CopyNewSaleMt = NewSaleMt
        CopyNewSaleDt = NewSaleDt

        ds1.Tables.Clear()
        ds1.Tables.Add(NewSaleMt)
        ds1.Tables.Add(NewSaleDt)

        Dim keyColumn2 As DataColumn = ds1.Tables(0).Columns("idInvMain")
        Dim foreignColumn2 As DataColumn = ds1.Tables(1).Columns("idInvMain")

        ds1.Relations.Add("ล็อตสินค้า", keyColumn2, foreignColumn2)

        GCProduct.DataSource = ds1.Tables(0)
        GCProduct.ForceInitialize()

        GCProduct.LevelTree.Nodes.Add("ล็อตสินค้า", GvLot)
        SumTotal()

        If eEvent <> eProcess.eEdit Then 'Edit
            Me.txtDocRef.Enabled = False
            Me.cmbDRCode.Enabled = False
            Me.dtpSale.Enabled = False
            Me.btnAddressS.Visible = False
            Me.CmbTs.Enabled = False
            Me.btnTspComp.Visible = False
            Me.txtNote.Enabled = False

            Me.btnSave.Visible = False
            Me.btnPdInc.Visible = False
            ColSelect.Visible = False
            ColAmount.Visible = False
            ColDelLot.Visible = False
            ColStock.Visible = False
            ColPrice_.OptionsColumn.AllowEdit = False
            ColPrice_.OptionsColumn.ReadOnly = False
            ColAmtSale.OptionsColumn.AllowEdit = False
            ColAmtSale.OptionsColumn.ReadOnly = False
            ColCancel.Visible = False
        End If


        If eEvent = eProcess.eAccept Then 'Accept
            Me.btnActAndChk.Visible = True
            Me.btnActAndChk.Text = "    รับทราบ"
            ' Me.btnActAndChk.Image = My.Resources.ResourceManager.GetObject("check_icon555")
        ElseIf eEvent = eProcess.eCheck Then ' Check
            Me.btnActAndChk.Visible = True
            Me.btnActAndChk.Text = "     ตรวจสอบ"
        ElseIf eEvent = eProcess.eApprove Then ' Approve
            Me.btnActAndChk.Visible = True
            Me.btnActAndChk.Text = "       บันทึกอนุมัติ"
            Me.rdbAppOK.Visible = True
            Me.rdbAppNo.Visible = True
        End If
    End Sub
    Private Sub cmbDRefCode()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idSaleCode, SaleCode From SmSaleDocCode WHERE SaleCode  = 'XY' "
        'sCommand.CommandText = "Select * From SmSaleDocCode WHERE SaleCode IN (SELECT SaleCode From SmSaleCodeComp WHERE idComp = " & sIdComp & ")"
        sAdapter.Fill(sDt)
        With cmbDRCode
            .DisplayMember = "SaleCode"
            .ValueMember = "idSaleCode"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbPayTps()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select * From dPayTspType"
        sAdapter.Fill(sDt)
        With cmbTypePayTrp
            .DisplayMember = "PayTspName"
            .ValueMember = "idPayTsp"
            .DataSource = sDt
        End With
    End Sub

    Private Sub cmbTransport()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idTspType, TspTypeName From dTspType"
        sAdapter.Fill(sDt)
        With CmbTs
            .DisplayMember = "TspTypeName"
            .ValueMember = "idTspType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub CmbTs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTs.SelectedIndexChanged
        If Me.CmbTs.SelectedValue = 21 Then ' บริษัทขนส่ง
            Me.btnTspComp.Enabled = True
            Me.cmbTypePayTrp.Enabled = True
        Else
            Me.btnTspComp.Enabled = False
            Me.cmbTypePayTrp.Enabled = False
            Me.lblTspComp.Tag = Nothing
            Me.lblTspComp.Text = ""
            Me.cmbTypePayTrp.SelectedValue = 1
        End If
    End Sub

    Private Sub cmbDRCode_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDRCode.SelectedValueChanged
        '--- Check ถูกหลัก/ไม่ถูกหลัก ---'
        If Me.cmbDRCode.Text <> "" Then
            Dim tempDt As New DataTable
            mdCnOpen()
            sCommand.CommandText = "Select stRight From SmSaleCodeComp Where idComp = " & cmbGroupComp.SelectedValue & " AND SaleCode = '" & Me.cmbDRCode.Text & "'"
            sAdapter.Fill(tempDt)

            If tempDt.Rows.Count <> 0 Then
                stRight = tempDt.Rows(0).Item("stRight")
            End If


            'If tempDt.Rows(0).Item("stRight") = 1 Then
            '    Me.rdbRight.Checked = True
            'Else
            '    Me.rdbNoRight.Checked = True
            'End If
        End If
    End Sub

    Private Sub btnAddressS_Click(sender As Object, e As EventArgs) Handles btnAddressS.Click
        Dim vFrm As New frmCusAdsSent(frmCusAdsSent.eProcess.eSelect, Me.lblPsCus.Tag)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblAddr.Tag = vFrm.idCusRefAddr 'idRef update to dCustomer

            mdCnOpen()
            Dim sDt As New DataTable
            sDt.Rows.Clear()
            sCommand.CommandText = "Select s.AddressS, s.stFromS, s.PsRecName, s.idTsp, s.idPayTsp, s.idSupTsp, sp.SupName " & _
                                   "From dCustomerAdrSent s LEFT OUTER JOIN PchInvAndProject.dbo.vSupplier sp ON s.idSupTsp = sp.idSup " & _
                                   "Where s.idCusRefAddr = " & vFrm.idCusRefAddr
            sAdapter.Fill(sDt)

            Me.lblAddr.Text = sDt.Rows(0).Item("AddressS")
            Me.lblCusRec.Text = sDt.Rows(0).Item("PsRecName")
            Me.CmbTs.SelectedValue = sDt.Rows(0).Item("idTsp")
            Me.cmbTypePayTrp.SelectedValue = sDt.Rows(0).Item("idPayTsp")
            If Not IsDBNull(sDt.Rows(0).Item("idSupTsp")) Then
                If sDt.Rows(0).Item("idSupTsp") <> 0 Then
                    Me.lblTspComp.Text = sDt.Rows(0).Item("SupName")
                    Me.lblTspComp.Tag = sDt.Rows(0).Item("idSupTsp")
                End If
            End If

        End If
    End Sub

    Private Sub btnTspComp_Click(sender As Object, e As EventArgs) Handles btnTspComp.Click
        Dim vFrm As New frmTspCompSelect(frmTspCompSelect.eProcess.eAll)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblTspComp.Tag = vFrm.idSup
            Me.lblTspComp.Text = vFrm.SupName
        End If
    End Sub

    '----- Add JU ----'
    Private Sub btnPdInc_Click(sender As Object, e As EventArgs) Handles btnPdInc.Click
        Dim idBackDt As New DataTable
        idBackDt.Columns.Add("idSaleReturn", System.Type.GetType("System.Int32"))
        For i As Integer = 0 To CopyReturnMt.Rows.Count - 1
            idBackDt.Rows.Add(CopyReturnMt.Rows(i).Item("idSaleReturn"))
        Next

        Dim vFrm As New frmSlReturnData(frmSlReturnData.eProcess.eNewSale, Me.lblPsCus.Tag, idBackDt)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            mdCnOpen()
            '---- Mt -----'
            Dim tempMtDt As New DataTable
            tempMtDt.Clear()
            sCommand.CommandText = "SELECT  DocRefCode, idSaleReturn FROM vSmSaleReturnMt mt WHERE idSaleReturn = " & vFrm.idRTSelect
            sAdapter.Fill(tempMtDt)
            CopyReturnMt.Rows.Add(tempMtDt.Rows(0).Item("DocRefCode"), tempMtDt.Rows(0).Item("idSaleReturn"))

            '--- Dt -----'
            Dim listRTDt As New DataTable
            listRTDt.Clear()
            sCommand.CommandText = "SELECT idSaleReturn, PdPkName, AmountReturn, PkUnitName FROM vSmSaleReturnDt WHERE idSaleReturn = " & vFrm.idRTSelect
            sAdapter.Fill(listRTDt)
            For i As Integer = 0 To listRTDt.Rows.Count - 1
                CopyReturnDt.Rows.Add(listRTDt.Rows(i).Item("idSaleReturn"), listRTDt.Rows(i).Item("PdPkName"), listRTDt.Rows(i).Item("AmountReturn"), _
                                  listRTDt.Rows(i).Item("PkUnitName"))
            Next

            '---- Show New-Pd----'
            Dim NewtempDt As New DataTable
            NewtempDt.Clear()
            sCommand.CommandText = " Select ju.idProduct, p.PdCode, p.PdPkname, p.PkUnitName, (ju.Amount - ISNULL(ju.AmountCut, 0.0)) As Amount, " & _
                                   "ju.idUnit, ju.dtType, ju.idsalereturn, ju.idJUDt FROM SmSaleReturnJUDt ju LEFT OUTER JOIN vPackingPdSet p " & _
                                   "ON ju.idProduct = p.idPdPk WHERE ju.dtType = 1 AND ju.Amount <> ISNULL(ju.AmountCut,0) " & _
                                   "And ju.idSaleReturn = " & vFrm.idRTSelect & " UNION ALL " &
                                   "SELECT ju.idProduct, '' As PdCode, p.Title As PdPkName, p.UnitName As PkUnitName, " & _
                                   "(ju.Amount - ISNULL(ju.AmountCut, 0.0)) As Amount, ju.idUnit, " & _
                                   "ju.dtType, ju.idsalereturn, ju.idJUDt FROM SmSaleReturnJUDt ju LEFT OUTER JOIN vSmPdOtherD p " & _
                                   "ON ju.idProduct = p.idPdO WHERE ju.dtType = 2 AND ju.Amount <> ISNULL(ju.AmountCut,0) AND ju.idSaleReturn = " & vFrm.idRTSelect & " UNION ALL " & _
                                   "SELECT ju.idProduct, '' As PdCode, p.PdName As PdPkName, u.UnitW As PkUnitName, " & _
                                   "(ju.Amount - ISNULL(ju.AmountCut, 0.0)) As Amount, " & _
                                   "ju.idUnit, ju.dtType, ju.idsalereturn, ju.idJUDt FROM SmSaleReturnJUDt ju LEFT OUTER JOIN vSeedProduct p " & _
                                   "ON ju.idProduct = p.idPd LEFT OUTER JOIN dUnitW u ON  ju.idUnit = u.idUnitW WHERE " & _
                                   "ju.dtType = 3 AND ju.Amount <> ISNULL(ju.AmountCut,0) AND ju.idSaleReturn = " & vFrm.idRTSelect & ""
            sAdapter.Fill(NewtempDt)

            For i As Integer = 0 To NewtempDt.Rows.Count - 1
                CopyNewSaleMt.Rows.Add(NewtempDt.Rows(i).Item("idProduct"), NewtempDt.Rows(i).Item("PdCode"), NewtempDt.Rows(i).Item("PdPkname"), _
                                   NewtempDt.Rows(i).Item("Amount"), 0.0, NewtempDt.Rows(i).Item("PkUnitName"), 0.0, NewtempDt.Rows(i).Item("dtType"), _
                                   NewtempDt.Rows(i).Item("idsalereturn"), NewtempDt.Rows(i).Item("idJUDt"))
            Next
        End If
    End Sub

    '--- Del JU ----'
    Private Sub RepositoryItemButtonEdit2_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit2.ButtonClick
        Result = MsgBox("คุณต้องการลบรายการนี้ใช่หรือไม่", vbYesNo + vbQuestion, sSystemName)
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim idDel As Integer = GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColidSaleReturn)

            GVReturn.DeleteRow(GVReturn.FocusedRowHandle)
            GridControl1.RefreshDataSource()

            'Dim idPdPkCUt As New DataTable
            'idPdPkCUt.Columns.Add("idProduct", System.Type.GetType("System.Int32"))
            'idPdPkCUt.Columns.Add("dtType", System.Type.GetType("System.Int32"))

            '--Del New-Pd--'
            For i As Integer = CopyNewSaleMt.Rows.Count - 1 To 0 Step -1
                If CopyNewSaleMt.Rows(i).Item("idSaleRT") = idDel Then
                    'idPdPkCUt.Rows.Add(CopyNewSaleMt.Rows(i).Item("idProduct"), CopyNewSaleMt.Rows(i).Item("dtType"))
                    For j As Integer = CopyNewSaleDt.Rows.Count - 1 To 0 Step -1
                        If CopyNewSaleMt.Rows(i).Item("idProduct") = CopyNewSaleDt.Rows(j).Item("idProduct") Then
                            CopyNewSaleDt.Rows.Remove(CopyNewSaleDt.Rows(j))
                        End If
                    Next
                    CopyNewSaleDt.AcceptChanges()
                    CopyNewSaleMt.Rows.Remove(CopyNewSaleMt.Rows(i))
                End If
            Next
            CopyNewSaleMt.AcceptChanges()

            Dim TotalNet As Double = 0.0
            For i As Integer = 0 To CopyNewSaleMt.Rows.Count - 1
                TotalNet += CopyNewSaleMt.Rows(i).Item("SumExp")
            Next
            txtTotalNet.Text = Format(TotalNet, "#,##0.00##")
            ' PdMainDt.DefaultView.Sort = "dtType, idProduct"
        End If
    End Sub

    '--Select Lot of NewPd ---'
    Private Sub rptSelLot_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptSelLot.ButtonClick
        Dim tempCutDt As New DataTable
        tempCutDt.Columns.Add("idLot", System.Type.GetType("System.Int32"))
        tempCutDt.Columns.Add("idWh", System.Type.GetType("System.Int32"))
        For i As Integer = 0 To CopyNewSaleDt.Rows.Count - 1
            If GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, ColidInvMain) = CopyNewSaleDt.Rows(i).Item("idInvMain") Then
                tempCutDt.Rows.Add(CopyNewSaleDt.Rows(i).Item("idLot"), CopyNewSaleDt.Rows(i).Item("idWh"))
            End If
        Next
        'Dim idDel As Integer = GVReturn.GetRowCellValue(GVReturn.FocusedRowHandle, ColidSaleReturn)


        Dim vFrm As New frmSlJuPdSelect(frmSlJuPdSelect.eProcess.eSelectPdAll, GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, ColidInvMain), _
                                        GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, ColInvName), tempCutDt)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            mdCnOpen()
            For i As Integer = 0 To vFrm.getLotDt.Rows.Count - 1

                Dim Price As Double = 0.0
                If GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, ColdtType) = 1 Then 'สินค้าทั่วไป
                    Price = vFrm.getLotDt.Rows(i).Item("Price_fg")
                ElseIf GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, ColdtType) = 2 Then 'สินค้าอื่นๆ
                    Price = vFrm.getLotDt.Rows(i).Item("Price_Pdo")
                End If

                CopyNewSaleDt.Rows.Add(GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, ColidInvMain), vFrm.getLotDt.Rows(i).Item("idLot"), _
                                       vFrm.getLotDt.Rows(i).Item("LotNo"), vFrm.getLotDt.Rows(i).Item("Amount"), _
                                       0.0, vFrm.getLotDt.Rows(i).Item("UnitName"), Price, 0.0, vFrm.getLotDt.Rows(i).Item("idUnit"), _
                                       0.0, 0, vFrm.getLotDt.Rows(i).Item("Amount"), 0.0, GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, ColdtType), _
                                         vFrm.getLotDt.Rows(i).Item("idWh"))
            Next
        End If

        GVNewPd.CollapseAllDetails()
        RecursExpand(GVNewPd, GVNewPd.FocusedRowHandle)

        GCProduct.Refresh()
    End Sub

    '---------------------- expand All child All -----------------------------'
    Public Sub RecursExpand(ByVal masterView As GridView, ByVal masterRowHandle As Integer)
        ' Prevent excessive visual updates. 
        masterView.BeginUpdate()
        Try
            ' Get the number of master-detail relationships. 
            Dim relationCount As Integer = masterView.GetRelationCount(masterRowHandle)
            ' Iterate through relationships. 
            Dim index As Integer
            For index = relationCount - 1 To 0 Step -1
                ' Open the detail View for the current relationship. 
                masterView.ExpandMasterRow(masterRowHandle, index)
                ' Get the detail View. 
                Dim childView As ColumnView = masterView.GetDetailView(masterRowHandle, index)
                If TypeOf childView Is GridView Then
                    ' Get the number of rows in the detail View. 
                    Dim childRowCount As Integer = CType(childView, GridView).DataRowCount
                    ' Expand child rows recursively. 
                    Dim handle As Integer
                    For handle = 0 To childRowCount - 1
                        RecursExpand(childView, handle)
                    Next
                End If
            Next
        Finally
            ' Enable visual updates. 
            masterView.EndUpdate()
        End Try
    End Sub
    'expand All child All


    'Del Lot
    Private Sub rptDel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rptDel.ButtonClick
        Result = MsgBox("คุณต้องการลบรายการนี้ใช่หรือไม่", vbYesNo + vbQuestion, sSystemName)
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim idInvMain As Integer = GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, ColidInvMain)

            Dim detailView As ColumnView = GCProduct.FocusedView
            Dim idLot As Integer = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColidLot)
            Dim idWh As Integer = detailView.GetRowCellValue(detailView.FocusedRowHandle, colidWh)

            Dim idSaleDt As Integer = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColidSaleDt)
            Dim AmtSale As Double = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColAmtSale)
            Dim LotNo As String = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColLotNo)
            '--Del New-Pd--'
            For i As Integer = CopyNewSaleDt.Rows.Count - 1 To 0 Step -1
                If CopyNewSaleDt.Rows(i).Item("idLot") = idLot And CopyNewSaleDt.Rows(i).Item("idWh") = idWh Then
                    CopyNewSaleDt.Rows.Remove(CopyNewSaleDt.Rows(i))
                End If
            Next

            '----เก็บใส่ dtDel เพื่อลบรายการถ้ามีการลบใน GVLot
            Dim dr As DataRow = GVNewPd.GetDataRow(GVNewPd.FocusedRowHandle)
            Dim drtemp As DataRow = dtDel.NewRow()
            drtemp("idInvMain") = dr("idInvMain")
            drtemp("idLot") = idLot
            drtemp("idWh") = idWh
            drtemp("idSaleDt") = idSaleDt
            drtemp("AmtSale") = AmtSale
            drtemp("LotNo") = LotNo
            dtDel.Rows.Add(drtemp)

            dtDel.AcceptChanges()

            CopyNewSaleDt.AcceptChanges()
            SumTotal()
        End If
    End Sub

    Private Sub GvLot_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GvLot.CellValueChanged
        Dim detailView As ColumnView = GCProduct.FocusedView
        'Dim RowMain As Integer = GVNewPd.FocusedRowHandle
        'Dim Rowi As Integer = detailView.FocusedRowHandle
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColAmtSale" Then
            'Check Stock
            If detailView.GetRowCellValue(detailView.FocusedRowHandle, ColAmtSale) > detailView.GetRowCellValue(detailView.FocusedRowHandle, ColStock) Then
                mdLoadCommitt()
                MessageBox.Show("จำนวนคงเหลือใน Stock ไม่เพียงพอต่อความต้องการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                detailView.SetRowCellValue(detailView.FocusedRowHandle, ColAmtSale, detailView.GetRowCellValue(detailView.FocusedRowHandle, ColStock))

                Dim SumPrice2 As Double = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColAmtSale) * detailView.GetRowCellValue(detailView.FocusedRowHandle, ColPrice_)
                detailView.SetRowCellValue(detailView.FocusedRowHandle, ColExp, SumPrice2)
                SumTotal()
                Exit Sub
            End If


            Dim SumAmtUse As Double = 0.0
            For i As Integer = 0 To CopyNewSaleDt.Rows.Count - 1
                If detailView.GetRowCellValue(detailView.FocusedRowHandle, ColidInvMainDt) = CopyNewSaleDt.Rows(i).Item("idInvMain") Then
                    SumAmtUse = SumAmtUse + CopyNewSaleDt.Rows(i).Item("AmtSale")
                End If
            Next

            If SumAmtUse > GVNewPd.GetRowCellValue(GVNewPd.FocusedRowHandle, ColAmount) Then 'รวมตัด Lot มากกว่า จำนวนที่อนุมัติขาย
                mdLoadCommitt()
                MessageBox.Show("จำนวนที่เบิกครั้งนี้ มากกว่าจำนวนที่เบิกได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                detailView.SetRowCellValue(detailView.FocusedRowHandle, ColAmtSale, 0.0)

                Dim SumPrice2 As Double = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColAmtSale) * detailView.GetRowCellValue(detailView.FocusedRowHandle, ColPrice_)
                detailView.SetRowCellValue(detailView.FocusedRowHandle, ColExp, SumPrice2)
                SumTotal()
                Exit Sub
            End If

            Dim SumPrice As Double = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColAmtSale) * detailView.GetRowCellValue(detailView.FocusedRowHandle, ColPrice_)
            detailView.SetRowCellValue(detailView.FocusedRowHandle, ColExp, SumPrice)
            SumTotal()

        End If

        If Col.Name = "ColPrice_" Then
            Dim SumPrice As Double = detailView.GetRowCellValue(detailView.FocusedRowHandle, ColAmtSale) * detailView.GetRowCellValue(detailView.FocusedRowHandle, ColPrice_)
            detailView.SetRowCellValue(detailView.FocusedRowHandle, ColExp, SumPrice)
            SumTotal()
        End If

    End Sub

    Sub SumTotal()
        'Dim SumPrice As Double = vdetailView.GetRowCellValue(vdetailView.FocusedRowHandle, ColAmtUse) * vdetailView.GetRowCellValue(vdetailView.FocusedRowHandle, ColPrice_)
        'vdetailView.SetRowCellValue(vdetailView.FocusedRowHandle, ColExp, SumPrice)

        For i As Integer = 0 To CopyNewSaleMt.Rows.Count - 1
            Dim sum1 As Object = CopyNewSaleDt.Compute("SUM(Exp)", "idInvMain = " & CopyNewSaleMt.Rows(i).Item("idInvMain"))
            CopyNewSaleMt.Rows(i).Item("SumExp") = sum1
            If IsDBNull(CopyNewSaleMt.Rows(i).Item("SumExp")) Then
                CopyNewSaleMt.Rows(i).Item("SumExp") = 0.0
            End If

            Dim sumAmt As Object = CopyNewSaleDt.Compute("SUM(AmtSale)", "idInvMain = '" & CopyNewSaleMt.Rows(i).Item("idInvMain") & "'")
            CopyNewSaleMt.Rows(i).Item("AmtReal") = sumAmt
            If IsDBNull(CopyNewSaleMt.Rows(i).Item("AmtReal")) Then
                CopyNewSaleMt.Rows(i).Item("AmtReal") = 0.0
            End If
        Next

        'Dim SumExp As Double = 0.0
        'For i As Integer = 0 To CopyNewSaleDt.Rows.Count - 1


        '    'If vdetailView.GetRowCellValue(vRow, ColidProduct) = CopyNewSaleDt.Rows(i).Item("idProduct") Then
        '    '    SumExp = SumExp + CopyNewSaleDt.Rows(i).Item("Exp")
        '    'End If
        'Next
        'GVNewPd.SetRowCellValue(vRowMain, ColTotal, SumExp)

        Dim TotalNet As Double = 0.0
        For i As Integer = 0 To CopyNewSaleMt.Rows.Count - 1
            TotalNet += CopyNewSaleMt.Rows(i).Item("SumExp")
        Next
        txtTotalNet.Text = Format(TotalNet, "#,##0.00##")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        mdLoadCommitt()
        Result = MsgBox("คุณต้องการบันทึกรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            If lblPsCus.Text = "" Then
                mdLoadCommitt()
                MessageBox.Show("กรุณาเลือกชื่อลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf lblPsSale.Text = "" Then
                mdLoadCommitt()
                MessageBox.Show("กรุณาเลือกเจ้าหน้าที่ขาย", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf txtDocRef.Text = "" Then
                mdLoadCommitt()
                MessageBox.Show("กรุณากรอกเลขที่อ้างอิง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txtDocRef.Focus()
                Exit Sub
                'ElseIf Me.rdbRight.Checked = False And Me.rdbNoRight.Checked = False Then
                '    mdLoadCommitt()
                '    MessageBox.Show("กรุณาเลือกประเภทบิลถูกหลัก/ไม่ถูกหลักก่อนกดบันทึก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    Exit Sub
            ElseIf GVReturn.RowCount = 0 Then
                mdLoadCommitt()
                MessageBox.Show("กรุณาเลือกรายการคืนสินค้า JU อย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf CopyNewSaleDt.Rows.Count = 0 Then ' Check No Lot
                mdLoadCommitt()
                MessageBox.Show("กรุณาระบุ Lot ของสินค้าอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Check ทุกสินค้า ให้ระบุ Lot
            'For i As Integer = 0 To CopyNewSaleMt.Rows.Count - 1
            '    Dim CountLot As Object = CopyNewSaleDt.Compute("Count(idLot)", "idProduct = '" & CopyNewSaleMt.Rows(i).Item("idProduct") & "'")
            '    If CountLot = 0 Then
            '        mdLoadCommitt()
            '        MessageBox.Show("มีสินค้าบางรายการไม่ได้ระบุ Lot สินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '        Exit Sub
            '    End If
            'Next

            'Check Lot Not Use
            For i As Integer = 0 To CopyNewSaleDt.Rows.Count - 1
                If CopyNewSaleDt.Rows(i).Item("AmtSale") = 0.0 Then
                    mdLoadCommitt()
                    MessageBox.Show("มีบางล็อตสินค้าระบุจำนวนขายเท่ากับ 0 " & vbCrLf & "กรุณาตรวจสอบความถูกต้อง ก่อนกดบันทึกอีกครั้ง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next

            'Check stock Before Cut
            For i As Integer = 0 To CopyNewSaleDt.Rows.Count - 1

                Dim sDt As New DataTable
                sDt.Clear()
                sCommand.CommandText = "Select inv.InvName, wh.Amount, unit.UnitName " & vbNewLine & _
                                        "From dInvLotRefWh wh " & vbNewLine & _
                                        "LEFT JOIN dInvLotMain lm ON wh.idLot = lm.idLot" & vbNewLine & _
                                        "LEFT JOIN dInventoryMain inv ON lm.idInvMain = inv.idInvMain" & vbNewLine & _
                                        "LEFT JOIN dInvUnit unit ON wh.idUnit = unit.idUnit" & vbNewLine & _
                                       "WHERE lm.idLot = " & CopyNewSaleDt.Rows(i).Item("idLot")
                sAdapter.Fill(sDt)

                Dim AllStock As Double = sDt.Rows(0).Item("Amount") + CopyNewSaleDt.Rows(i).Item("OldAmt")
                If AllStock < CopyNewSaleDt.Rows(i).Item("AmtSale") Then  ' Stock < AllSaleAmount
                    mdLoadCommitt()
                    MessageBox.Show("จำนวน " & sDt.Rows(0).Item("InvName") & " คงเหลือใน Stock ไม่เพียงพอ ระบบจึงไม่สามารถทำรายการขายได้" & vbCrLf & _
                           "(จำนวนขาย : " & Format(CopyNewSaleDt.Rows(i).Item("AmtSale"), "#,##0.00##") & " " & sDt.Rows(0).Item("UnitName") & _
                           " แต่จำนวน Stock คงเหลือ : " & Format(AllStock, "#,##0.00##") & " " & _
                           sDt.Rows(0).Item("UnitName") & ")", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next

            If eEvent = eProcess.eNew Then 'AddData
                Dim idSaleTemp As Integer
                '----insert----'
                idSaleTemp = AddSmSaleMt()

                If idSaleTemp = 0 Then
                    Exit Sub
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            ElseIf eEvent = eProcess.eEdit Then

                'UpdateSmSaleMt()
            End If  'End if Check New or Edit

        End If 'End Dialogbox
    End Sub

    Function AddSmSaleMt() As String
        '---insert SmSaleMt Table---'
        Dim DocCode As String = ""
        Dim getDate As String = CType(Date.Today, String)
        Dim Prefixcode As String = ""

        Dim DocRef As String = ""
        Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
        Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)

        Dim DocRefAcc As String = ""
        Dim idSale_last As Integer = 0
        '--- insert stBillType = '9' : บิลขายสินค้า XY

        Dim vidSupTsp As String
        If Me.lblTspComp.Tag = Nothing Then
            vidSupTsp = " NULL"
        Else
            vidSupTsp = Me.lblTspComp.Tag
        End If

        Dim vidCusRefAddr As String
        If Me.lblAddr.Tag = 0 Then
            vidCusRefAddr = " NULL"
        Else
            vidCusRefAddr = Me.lblAddr.Tag
        End If

        'If Me.rdbRight.Checked = True Then
        '    stRight = 1
        'ElseIf Me.rdbNoRight.Checked = True Then
        '    stRight = 0
        'End If

        Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))

        DocCode = getDocCode(Prefixcode)
        DocRefAcc = getDocRefAcc(YAndM_Cut)
        DocRef = Me.cmbDRCode.Text & " " & Trim(Me.txtDocRef.Text)

        '  --- temp DateSale ใช้ชั่วคราวช่วงคีย์ย้อนหลัง ---'
        tempDateSale = ksbDateToString(dtpSale.Value.ToShortDateString)
        '  ---------------------------------------'

        'mdCnOpenTest()
        Using myconnection As New SqlConnection(conStr)
            myconnection.Open()
            Dim mycommand As New SqlCommand()
            Dim mytransaction As SqlTransaction

            ' Start a local transaction
            mytransaction = myconnection.BeginTransaction()

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            mycommand.Connection = myconnection
            mycommand.Transaction = mytransaction

            Dim stridCus As String = ""
            Dim qidCus As String = ""

            If idFM = 0 And idCus <> 0 Then
                'Case เป็น Customer อย่างเดียว
                stridCus = "idCus"
                qidCus = idCus
            ElseIf idCus = 0 And idFM <> 0 Then
                'Case เป็น Farmer อย่างเดียว
                stridCus = "idFm"
                qidCus = idFM

            ElseIf idCus <> 0 And idFM <> 0 Then
                'Case เป็นทั้ง Customer และ Farmer 
                stridCus = "idCus, idFm"
                qidCus = idCus & "," & idFM
            End If

            Try
                Dim query As String = "Insert Into SmSaleMt(DateSale, DatePay, DateTs, TimeTs, DocCode, DocRefAcc, idSaleCode, DocRef, Note, " & _
                                      "Total, DiscountAmout, DiscountPerc, TotalNet, idPartner, " & stridCus & ", idPsTs, idPsSale, " & _
                                      "stPay, idPM, idTS, stPrice, LevelDiscount, stRight, idComp, idPayTsp, idSupTsp, " & _
                                      "idCusRefAddr, stBillType, stLot) " & _
                                      "Values('" & ksbDateToString(dtpSale.Value.ToShortDateString) & "', " & _
                                      "'" & ksbDateToString(dtpSale.Value.ToShortDateString) & "', " & _
                                      "'" & ksbDateToString(lblDateTs.Text) & "', CONVERT(VARCHAR(5),GETDATE(),108), " & _
                                      "'" & DocCode & "', '" & DocRefAcc & "', '" & Me.cmbDRCode.SelectedValue & "', " & _
                                      "'" & DocRef & "', '" & txtNote.Text & "', " & CDbl(txtTotalNet.Text) & ", " & _
                                      "0.00, 0, " & CDbl(txtTotalNet.Text) & ", " & idPartner & "," & qidCus & ", " & lblPsTs.Tag & ", " & _
                                      "" & lblPsSale.Tag & ", '', 75, '" & CmbTs.SelectedValue & "'," & _
                                      "'1', 0.0, '" & stRight & "', " & cmbGroupComp.SelectedValue & ", " & cmbTypePayTrp.SelectedValue & ", " & _
                                      "" & vidSupTsp & ", " & vidCusRefAddr & ", '9', 1)"
                mycommand.CommandText = query

                Dim query2 As String = "Select @@Identity"
                mycommand.ExecuteNonQuery()
                mycommand.CommandText = query2
                idSale_last = mycommand.ExecuteScalar()


                ' --- Insert SmSaleDt/DtPd/DtOther----
                For i As Integer = 0 To GVNewPd.DataRowCount - 1
                    Dim dr As DataRow = GVNewPd.GetDataRow(i)
                    AddSmSaleDtAll(idSale_last, dr, mycommand)
                Next '


                ''up image
                'For j As Integer = 0 To sDt_flagpic_Rec.Rows.Count - 1
                '    If sDt_flagpic_Rec.Rows(j).Item(2) = "1" Then
                '        upFile(j + 1, sDt_flagpic_Rec.Rows(j).Item(0), idSale_last)
                '    End If
                'Next

                ' Attempt to commit the transaction.
                mytransaction.Commit()
                mdLoadCommitt()
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return idSale_last
            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try
                    mytransaction.Rollback()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                            sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    idSale_last = 0
                    Return idSale_last
                Catch e2x As Exception
                    idSale_last = 0
                    'MessageBox.Show(ex.Message, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                            sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Return idSale_last
                End Try
                'Finally
                '    myconnection.Close()
            End Try
        End Using
        '  Return idSale_last
    End Function

    Private Sub UpdateSmSaleMt() 'Edit
        Dim DocCode As String = ""
        Dim getDate As String = CType(Date.Today, String)
        Dim Prefixcode As String = ""

        Dim DocRef As String = ""
        Dim YAndM As String = Microsoft.VisualBasic.Left(ksbDateToString(Date.Today), 6)
        Dim YAndM_Cut As String = Microsoft.VisualBasic.Right(YAndM, 4)

        Dim DocRefAcc As String = ""

        '--- insert stBillType = '9' : บิลขายสินค้า XY

        Dim vidSupTsp As String
        If Me.lblTspComp.Tag = Nothing Then
            vidSupTsp = " NULL"
        Else
            vidSupTsp = Me.lblTspComp.Tag
        End If

        Dim vidCusRefAddr As String
        If Me.lblAddr.Tag = 0 Then
            vidCusRefAddr = " NULL"
        Else
            vidCusRefAddr = Me.lblAddr.Tag
        End If

        Prefixcode = (Microsoft.VisualBasic.Right(getDate, 2))

        DocCode = getDocCode(Prefixcode)
        DocRefAcc = getDocRefAcc(YAndM_Cut)
        DocRef = Me.cmbDRCode.Text & " " & Trim(Me.txtDocRef.Text)

        Using myconnection As New SqlConnection(conStr)
            myconnection.Open()
            Dim mycommand As SqlCommand = myconnection.CreateCommand()
            Dim mytransaction As SqlTransaction
            mytransaction = myconnection.BeginTransaction()
            mycommand.Connection = myconnection
            mycommand.Transaction = mytransaction
            mdLoadShow()
            Try
                mycommand.CommandText = "Update SmSaleMt Set DateSale='" & ksbDateToString(dtpSale.Value.ToShortDateString) & "', " & _
                                        "DatePay='" & ksbDateToString(dtpSale.Value.ToShortDateString) & "', " & _
                                        "DateTs='" & ksbDateToString(Date.Today) & "', TimeTs = CONVERT(VARCHAR(5),GETDATE(),108), " & _
                                        "DocCode='" & lblDocCode.Text & "', idSaleCode = '" & Me.cmbDRCode.SelectedValue & "', DocRef='" & DocRef & "', " & _
                                        "Note='" & txtNote.Text & "', Total='" & CDbl(txtTotalNet.Text) & "', " & _
                                        "DiscountAmout = 0.00, DiscountPerc = 0, TotalNet='" & CDbl(txtTotalNet.Text) & "', " & _
                                        "idCus='" & lblPsCus.Tag & "', idPsTs='" & sPsId & "', idPsSale='" & lblPsSale.Tag & "', " & _
                                        "stPay='', idTS ='" & CmbTs.SelectedValue & "', " & _
                                        "stPrice= '1', LevelDiscount = 0.00, idPayTsp = " & cmbTypePayTrp.SelectedValue & ", " & _
                                        "idSupTsp = " & vidSupTsp & ", idCusRefAddr = " & vidCusRefAddr & ", " & _
                                        "stRight = '" & stRight & "' Where idSale = " & idSale
                mycommand.ExecuteNonQuery()

                UpdateSmSaleDt(mycommand)

                ' Attempt to commit the transaction.
                mytransaction.Commit()

                mdLoadCommitt()
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                ' Attempt to roll back the transaction.
                Try
                    mytransaction.Rollback()
                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                             sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                Catch e2x As Exception
                    mdLoadCommitt()
                    MessageBox.Show("Commit Exception Type: " & ex.Message & vbCrLf & "ระบบเกิดข้อผิดพลาด จึงไม่สามารถบันทึกรายการได้", _
                                            sSystemName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    Exit Sub
                End Try
            End Try
        End Using
    End Sub

    Private Sub UpdateSmSaleDt(ByVal vCommand As SqlCommand)
        For i As Integer = 0 To GVNewPd.DataRowCount - 1
            Dim dr_NewPd As DataRow = GVNewPd.GetDataRow(i)

            'Delete Lot
            If dtDel.Rows.Count <> 0 Then
                For j As Integer = 0 To dtDel.Rows.Count - 1
                    Dim drDel As DataRow = dtDel.Rows(j)
                    '--- UPDATE ---'
                    InvLotMainUpdate(1, drDel.Item("idLot"), drDel.Item("idLot"), _
                                     CDbl(drDel.Item("AmtSale")), "เมนู" & Me.Text, idSale, "SAM", _
                                     "SmSaleMt", Trim(drDel.Item("LotNo")), drDel.Item("idWh"), vCommand)

                    vCommand.CommandText = "DELETE FROM SmSaleDtAll WHERE idSaleDt = " & drDel.Item("idSaleDt")
                    vCommand.ExecuteNonQuery()

                    drDel.Delete()
                    dtDel.AcceptChanges()
                Next
            End If


            For j As Integer = 0 To CopyNewSaleDt.Rows.Count - 1

                Dim detailView As ColumnView = GCProduct.FocusedView
                Dim idLot As Integer = detailView.GetRowCellValue(j, ColidLot)
                Dim idWh As Integer = detailView.GetRowCellValue(j, colidWh)

                Dim idSaleDt As Integer = detailView.GetRowCellValue(j, ColidSaleDt)
                Dim AmtSale As Double = detailView.GetRowCellValue(j, ColAmtSale)
                Dim LotNo As String = detailView.GetRowCellValue(j, ColLotNo)
                Dim idJUDt As Integer = detailView.GetRowCellValue(j, colidJUDt)

                Dim dr_Lot As DataRow = CopyNewSaleDt.Rows(j)
                'Case 1: insert New Lot
                If idSaleDt = 0 Then
                    If dr_Lot.Item("idSaleDt") = 0 Then
                        AddSmSaleDtAll(idSale, dr_Lot, vCommand)
                    End If
                End If

                'Edit In Old Lot
                If idSaleDt <> 0 Then
                    If AmtSale <> dr_Lot.item("AmtSale") Then 'จำนวนขายเก่า ไม่เท่ากับ จำนวนขายใหม่
                        ' คืนสต๊อก จำนวนขาย เก่า (Lot เดิม)
                        InvLotMainUpdate(1, dr_NewPd.Item("idInvMain"), dr_Lot.Item("idLot"), CDbl(AmtSale), _
                                     "เมนู" & Me.Text, idSale, "SAM", "SmSaleMt", dr_Lot.Item("LotNo"), idWh, vCommand)

                        ' ตัดสต๊อก จำนวนขาย ใหม่ (Lot เดิม)
                        InvLotMainUpdate(2, dr_Lot.Item("idInvMain"), dr_Lot.Item("idLot"), CDbl(dr_Lot.Item("AmtSale")), _
                                    "เมนู" & Me.Text, idSale, "SAM", "SmSaleMt", dr_Lot.Item("LotNo"), dr_Lot.Item("idWh"), vCommand)

                        vCommand.CommandText = "UPDATE SmSaleReturnJUDt SET AmountCut = ( AmountCut +" & CDbl(AmtSale) & ") - " & dr_Lot.Item("AmtSale") & vbNewLine & _
                                                "WHERE idJUDt = " & idJUDt
                        vCommand.ExecuteNonQuery()
                    End If
                End If



            Next
        Next
    End Sub

    Sub AddSmSaleDtAll(ByVal idSale As Integer, ByVal dr_NewPd As DataRow, ByVal vCommand As SqlCommand)
        Dim vAdapter = New SqlDataAdapter(vCommand)
        Dim SumSvFree As Double = 0.0 'รวมยอดค่าบริการ (ขนส่ง)

        For j As Integer = 0 To CopyNewSaleDt.Rows.Count - 1

            Dim dr_Lot As DataRow = CopyNewSaleDt.Rows(j)

            If dr_Lot.Item("idSaleDt") = 0 Then

            End If
            If dr_NewPd.Item("idInvMain") = dr_Lot.Item("idInvMain") Then
                Dim LotNo As String = ""

                If IsDBNull(dr_Lot.Item("LotNo")) Then
                    LotNo = ""
                Else
                    LotNo = Trim(dr_Lot.Item("LotNo"))
                End If

                Dim ProductName As String = Trim(dr_NewPd.Item("InvName"))
                ProductName = Replace(ProductName, "'", "''")

                vCommand.CommandText = "INSERT INTO SmSaleDtAll(idSale,  idProduct, ProductName, idLot, LotNo, Amount, idUnit," & vbNewLine & _
                                         " Price, PriceBfDis, DiscountPerc, DiscountBath, stCutStock, No, DtType, idWh, idSaleReturn, idJUDt) Values(" & vbNewLine & _
                                         idSale & "," & vbNewLine & _
                                          dr_NewPd.Item("idInvMain") & "," & vbNewLine & _
                                         "'" & Trim(ProductName) & "', " & vbNewLine & _
                                         "" & dr_Lot.Item("idLot") & "," & vbNewLine & _
                                         "'" & LotNo & "', " & vbNewLine & _
                                         "" & CDbl(dr_Lot.Item("AmtSale")) & "," & vbNewLine & _
                                         dr_Lot.Item("idUnit") & "," & vbNewLine & _
                                         "" & CDbl(dr_Lot.Item("Price")) & "," & vbNewLine & _
                                         "" & CDbl(dr_Lot.Item("Price")) & ", " & vbNewLine & _
                                         " 0 , " & vbNewLine & _
                                         " 0 , " & vbNewLine & _
                                         " 1 , " & vbNewLine & _
                                         j + 1 & "," & vbNewLine & _
                                         dr_NewPd.Item("DtType") & "," & vbNewLine & _
                                         dr_Lot.Item("idWh") & "," & vbNewLine & _
                                         idReturn & "," & vbNewLine & _
                                         dr_NewPd.Item("idJUDt") & vbNewLine & _
                                         ")"

                vCommand.ExecuteNonQuery()

                'Lot in New Sysytem
                If Not IsDBNull(CopyNewSaleDt.Rows(j).Item("idLot")) Then

                    '--- UPDATE InvLot : New System ---'
                    InvLotMainUpdate(2, dr_Lot.Item("idLot"), dr_Lot.Item("idLot"), _
                                     CDbl(dr_Lot.Item("AmtSale")), "เมนู" & Me.Text, idSale, "SAM", _
                                     "SmSaleMt", Trim(LotNo), dr_Lot.Item("idWh"), vCommand)
                End If

                'If dr_Lot.Item("idInvGroup") = 30 Then
                '    SumSvFree = SumSvFree + CDbl(CopyNewSaleDt.Rows(j).Item("Exp"))
                'End If

            End If

        Next 'Next Lot

        'UPDATE Amount Cut
        vCommand.CommandText = "UPDATE SmSaleReturnJUDt SET AmountCut = (Select ISNULL(AmountCut, 0.0)  As AmountCut FROM SmSaleReturnJUDt " & _
                               "WHERE idJUDt = " & dr_NewPd.Item("idJUDt") & ") + " & CDbl(dr_NewPd.Item("AmtReal")) & " " & _
                               "WHERE idJUDt = " & dr_NewPd.Item("idJUDt") & ""
        vCommand.ExecuteNonQuery()

        '---- Update SumService in SmSaleMt ----'
        vCommand.CommandText = "Update SmSaleMt Set SumService = " & SumSvFree & " WHERE idSale = " & idSale
        vCommand.ExecuteNonQuery()

        'check stCutAll
        For k As Integer = 0 To GVNewPd.DataRowCount - 1 'JU

            Dim dr As DataRow = GVNewPd.GetDataRow(k)

            Dim CheckDt As New DataTable
            CheckDt.Clear()
            vCommand.CommandText = "SELECT COUNT(idJUDT) As CntNot " & vbNewLine & _
                                    "FROM SmSaleReturnJUDt  " & vbNewLine & _
                                    "WHERE idSaleReturn = " & idReturn & vbNewLine & _
                                    "AND Amount <> ISNULL(AmountCut,0)"
            vAdapter.Fill(CheckDt)

            If CheckDt.Rows(k).Item("CntNot") = 0 Then ' All Product Cut
                vCommand.CommandText = "Update SmSaleReturnMt Set stAllCut = 1 WHERE idSaleReturn = " & idReturn
                vCommand.ExecuteNonQuery()
            End If

        Next

    End Sub


    Function getDocCode(ByVal Prefixcode As String) As String
        Dim DocCode As String = ""
        Dim nextOrder As String = ""
        'Dim CodeYear As String = ""

        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        sCommand.CommandText = "SELECT MAX(DocCode) as max_DocCode FROM SmSaleMt"
        sAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocCode")) = True Then
            DocCode = Prefixcode & "/" & "000001"
        Else
            ' Dim max_DocCode As String = sDt.Rows(0).Item("max_DocCode")
            Dim yearDoc As String = Microsoft.VisualBasic.Left(sDt.Rows(0).Item("max_DocCode"), 2)
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocCode"), 6)

            If Prefixcode <> yearDoc Then
                DocCode = Prefixcode & "/" & "000001"
            Else
                Dim temp As Integer
                temp = CInt(RunningCode) + 1
                If temp < 10 Then
                    nextOrder = "00000" & CStr(temp)
                ElseIf temp < 100 Then
                    nextOrder = "0000" & CStr(temp)
                ElseIf temp < 1000 Then
                    nextOrder = "000" & CStr(temp)
                ElseIf temp < 10000 Then
                    nextOrder = "00" & CStr(temp)
                ElseIf temp < 100000 Then
                    nextOrder = "0" & CStr(temp)
                Else
                    nextOrder = CStr(temp)
                End If
                DocCode = Prefixcode & "/" & nextOrder
            End If
        End If
        Return DocCode
    End Function

    Function getDocRefAcc(ByVal YearAndMonth As String) As String
        Dim PrefixCode As String = "XY"
        Dim DocRefAcc As String = ""
        Dim nextOrder As String = ""
        Dim CodeYear As String = ""

        DocRefAcc = PrefixCode & " " & YearAndMonth
        mdCnOpen()
        Dim sDt As New DataTable
        sDs.Tables.Clear()
        sCommand.CommandText = "SELECT MAX(DocRefAcc) as max_DocRefAcc " & vbNewLine & _
                                "FROM SmSaleMt " & vbNewLine & _
                                "WHERE SUBSTRING(DocRefAcc,1,7) = '" & DocRefAcc & "'" & vbNewLine & _
                                "AND idComp = " & cmbGroupComp.SelectedValue
        sAdapter.Fill(sDt)

        If IsDBNull(sDt.Rows(0).Item("max_DocRefAcc")) = True Then
            DocRefAcc = PrefixCode & " " & YearAndMonth & "0001"
        Else
            Dim RunningCode As String = Microsoft.VisualBasic.Right(sDt.Rows(0).Item("max_DocRefAcc"), 4)
            Dim temp As Integer
            temp = CInt(RunningCode) + 1
            If temp < 10 Then
                nextOrder = "000" & CStr(temp)
            ElseIf temp < 100 Then
                nextOrder = "00" & CStr(temp)
            ElseIf temp < 1000 Then
                nextOrder = "0" & CStr(temp)
            Else
                nextOrder = CStr(temp)
            End If
            DocRefAcc = PrefixCode & " " & YearAndMonth & nextOrder

        End If
        Return DocRefAcc
    End Function

    'Accept/Check/Approve
    Private Sub btnActAndChk_Click(sender As Object, e As EventArgs) Handles btnActAndChk.Click
        Select Case eEvent
            Case eProcess.eAccept  'Accept
                Result = MsgBox("คุณต้องการ รับทราบ รายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
                If Result = Windows.Forms.DialogResult.Yes Then
                    mdCnOpen()
                    '---Update SmSaleMt Table---'
                    sCommand.CommandText = "Update SmSaleMt Set idPsAccept='" & sPsId & "', DateAccept='" & ksbDateToString(Date.Today) & "' " & _
                                           "Where idSale = " & idSale
                    sCommand.ExecuteNonQuery()

                    Dim sDt As New DataTable
                    sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleMt Where idSale = " & idSale
                    sAdapter.Fill(sDt)
                    If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
                        '----Update stApp----'
                        sCommand.CommandText = "Update SmSaleMt Set stApp='1' Where idSale = " & idSale
                        sCommand.ExecuteNonQuery()
                        MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3 " & vbCrLf & _
                                        "โดยหลังจากขั้นตอนนี้สามารถออกเอกสารได้ และรายการจะถูกส่งไปยังขั้นตอนจัดส่งสินค้าต่อไป", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'vFrmACAp.Close()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("รับทราบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'vFrmACAp.Close()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            Case eProcess.eCheck 'Check
                Result = MsgBox("คุณต้องการ ตรวจสอบ รายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
                If Result = Windows.Forms.DialogResult.Yes Then
                    mdCnOpen()
                    '---Update SmSaleMt Table---'
                    sCommand.CommandText = "UPDATE SmSaleMt SET idPsCheck = '" & sPsId & "', DateChcek = '" & ksbDateToString(Date.Today) & "' " & _
                                           "WHERE idSale= " & idSale
                    sCommand.ExecuteNonQuery()

                    Dim sDt As New DataTable
                    sCommand.CommandText = "SELECT idPsAccept, idPsCheck, idPsApp FROM SmSaleMt WHERE idSale='" & idSale & "'"
                    sAdapter.Fill(sDt)
                    If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
                        '----Update stApp----'
                        sCommand.CommandText = "UPDATE SmSaleMt Set stApp='1' Where idSale='" & idSale & "'"
                        sCommand.ExecuteNonQuery()
                        MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3 " & vbCrLf & _
                                        " โดยหลังจากขั้นตอนนี้สามารถออกเอกสารได้ และรายการจะถูกส่งไปยังขั้นตอนจัดส่งสินค้าต่อไป", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'vFrmACAp.Close()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("ตรวจสอบเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' vFrmACAp.Close()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            Case eProcess.eApprove 'Approve
                Result = MsgBox("คุณต้องการอนุมัติ หรือไม่อนุมัติรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
                If Result = Windows.Forms.DialogResult.Yes Then
                    If Me.rdbAppOK.Checked = True Then  ' อนุมัติ
                        mdCnOpen()
                        '---Update SmSaleMt Table---'
                        sCommand.CommandText = "UPDATE SmSaleMt SET idPsApp = '" & sPsId & "', DateApp = '" & ksbDateToString(Date.Today) & "' " & _
                                               "WHERE idSale='" & idSale & "'"
                        sCommand.ExecuteNonQuery()

                    ElseIf Me.rdbAppNo.Checked = True Then  ' ไม่อนุมัติ
                        mdCnOpen()
                        '---Update SmSaleMt Table---'
                        sCommand.CommandText = "UPDATE SmSaleMt SET idPsApp = '" & sPsId & "', DateApp = '" & ksbDateToString(Date.Today) & "', " & _
                                               "stApp = '0' WHERE idSale='" & idSale & "'"
                        sCommand.ExecuteNonQuery()

                        For j As Integer = 0 To CopyNewSaleDt.Rows.Count - 1 'Detail  

                            Dim dr_Lot As DataRow = CopyNewSaleDt.Rows(j)

                            InvLotMainUpdate(1, dr_Lot.Item("idLot"), dr_Lot.Item("idLot"), _
                                       CDbl(dr_Lot.Item("AmtSale")), "SAM: ไม่อนุมัติรายการขายสินค้า", idSale, "SAM-4", _
                                       "SmSaleMt", Trim(dr_Lot.Item("LotNo")), dr_Lot.Item("idWh"), sCommand)

                        Next

                        MessageBox.Show("ระบบยืนยันการไม่อนุมัติรายการเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' vFrmACAp.Close()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Exit Sub
                    Else
                        MessageBox.Show("กรุณาเลือกอนุมัติ หรือไม่อนุมัติก่อนทำการบันทึก", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Dim sDt As New DataTable
                    sCommand.CommandText = "Select idPsAccept, idPsCheck, idPsApp From SmSaleMt Where idSale='" & idSale & "'"
                    sAdapter.Fill(sDt)
                    If Not IsDBNull(sDt.Rows(0).Item("idPsAccept")) And Not IsDBNull(sDt.Rows(0).Item("idPsCheck")) And Not IsDBNull(sDt.Rows(0).Item("idPsApp")) Then
                        '----Update stApp----'
                        sCommand.CommandText = "Update SmSaleMt Set stApp='1' Where idSale='" & idSale & "'"
                        sCommand.ExecuteNonQuery()
                        MessageBox.Show("กระบวนการนี้เป็นการยืนยันขั้นตอนลำดับสุดท้าย ลำดับที่ 3 " & vbCrLf & _
                                        "โดยหลังจากขั้นตอนนี้สามารถออกเอกสารได้ และรายการจะถูกส่งไปยังขั้นตอนจัดส่งสินค้าต่อไป", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("อนุมัติเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'vFrmACAp.Close()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If

                End If
        End Select
    End Sub

    Private Sub GVNewPd_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVNewPd.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "ColNum_" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

End Class