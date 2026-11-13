Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraGrid.Views.Base

Public Class frmPdPkAllLotSelect
    Public DtType As Integer  ' ประเภทสินค้า 1:ทั่วไป 2:สินค้าอื่นๆ 3:เมล็ด
    'Dim Result As DialogResult
    Dim stPdGen As Integer = 0
    Dim stPack As Integer = 0
    Dim stFolwer As Integer = 0
    Dim stPage As String = 0
    Dim eEvent As eProcess

    Dim lotDtCut As New DataTable
    Public getLotDt As New DataTable
    Dim sDt3 As New DataTable
    Dim sDt3OC As New DataTable

    Public idPdOService As Integer

    Dim lotDtCutM As New DataTable
    Public getLotDtM As New DataTable
    Dim sDt3M As New DataTable

    Dim lotDtCutO As New DataTable
    Public getLotDtO As New DataTable
    Dim sDt3O As New DataTable
    Public MainReturn As New DataTable
    'Dim OnlyidPdPk As Integer

    Enum eProcess
        eSaleLot
        eHormone
        ePlastic
        eSalePdGen
        eSalePack 'ผักซอง
        eSaleFolwer ' ดอกไม้
        eSalePdMat 'สินค้าวัตถุดิบ
        eSaleOther 'สินค้าอื่นๆ
        'eSaleJu ' เลือก lot บิล JU
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idPdPkLotdt As DataTable, ByVal idPdPkLotdtM As DataTable, ByVal idPdPkLotdtO As DataTable)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eSaleLot
                stPage = 1
                stPdGen = 0
                stPack = 0
                stFolwer = 0
                'lotDtCut = idPdPkLotdt
                'lotDtCutM = idPdPkLotdtM
                'lotDtCutO = idPdPkLotdtO
            Case eProcess.eHormone
                stPage = 2
                stPdGen = 0
                stPack = 0
                stFolwer = 0
                ' lotDtCutO = idPdPkLotdtO
            Case eProcess.ePlastic
                stPage = 3
                stPdGen = 0
                stPack = 0
                stFolwer = 0
                ' lotDtCutO = idPdPkLotdtO
            Case eProcess.eSalePdGen 'สินค้าทั่วไป
                stPage = 4
                stPdGen = 1
                stPack = 0
                stFolwer = 0
                ' lotDtCut = idPdPkLotdt
            Case eProcess.eSalePack 'ผักซอง
                stPage = 5
                stPdGen = 0
                stPack = 1
                stFolwer = 0
                '  lotDtCut = idPdPkLotdt
            Case eProcess.eSaleFolwer ' ดอกไม้
                stPage = 6
                stPdGen = 1
                stPack = 0
                stFolwer = 1
                '   lotDtCut = idPdPkLotdt
            Case eProcess.eSalePdMat 'สินค้าวัตถุดิบ
                stPage = 7
                stPdGen = 0
                stPack = 0
                stFolwer = 0
                '  lotDtCutM = idPdPkLotdtM
            Case eProcess.eSaleOther 'สินค้าอื่นๆ
                stPage = 8
                stPdGen = 0
                stPack = 0
                stFolwer = 0
                '  lotDtCutO = idPdPkLotdtO
                'Case eProcess.eSaleJu 'เลือก lot บิล JU
                '    stPage = 8
                '    stPdGen = 0
                '    stPack = 0
                '    stFolwer = 0
                '    OnlyidPdPk = vidPdPk
        End Select
        lotDtCut = idPdPkLotdt
        lotDtCutM = idPdPkLotdtM
        lotDtCutO = idPdPkLotdtO
        eEvent = aProcess
    End Sub

    Private Sub frmPdPkAllLotSelect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Select Case stPage
            Case 1  ' SaleLot       
                cmbPdoType()
                BindPlant()
                getLotDt.Columns.Add("idPdPkLot", System.Type.GetType("System.Int64"))
                'getLotDt.Columns.Add("PdPkName", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("Lotno", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("CompName", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("idComp", System.Type.GetType("System.Int32"))

                getLotDtM.Columns.Add("idPdLot", System.Type.GetType("System.Int64"))
                getLotDtO.Columns.Add("idPdOLot", System.Type.GetType("System.Int32"))
                getLotDtO.Columns.Add("idPdO", System.Type.GetType("System.Int32"))

                Me.TabControl1.SelectedIndex = 0
                BindDataPdPk()
                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView1OC.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GVPdoMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GVHormoneMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GVPlasticMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                Me.txtPdName.Focus()
            Case 2 ' Hormone
                TabControl1.TabPages.Remove(TabGen)
                ' TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabMat)
                TabControl1.TabPages.Remove(TabPlastic)
                TabControl1.TabPages.Remove(TabPdOtherComp)
                getLotDt.Columns.Add("idPdPkLot", System.Type.GetType("System.Int64"))
                getLotDt.Columns.Add("Lotno", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("CompName", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("idComp", System.Type.GetType("System.Int32"))

                getLotDtM.Columns.Add("idPdLot", System.Type.GetType("System.Int64"))
                getLotDtO.Columns.Add("idPdOLot", System.Type.GetType("System.Int32"))
                getLotDtO.Columns.Add("idPdO", System.Type.GetType("System.Int32"))

                Me.TabControl1.SelectedIndex = 1
                GVPdoMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                Me.txtHormone.Focus()
            Case 3 ' Plastic
                TabControl1.TabPages.Remove(TabGen)
                ' TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabMat)
                TabControl1.TabPages.Remove(TabHormone)
                TabControl1.TabPages.Remove(TabPdOtherComp)
                getLotDt.Columns.Add("idPdPkLot", System.Type.GetType("System.Int64"))
                getLotDt.Columns.Add("Lotno", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("CompName", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("idComp", System.Type.GetType("System.Int32"))


                getLotDtM.Columns.Add("idPdLot", System.Type.GetType("System.Int64"))
                getLotDtO.Columns.Add("idPdOLot", System.Type.GetType("System.Int32"))
                getLotDtO.Columns.Add("idPdO", System.Type.GetType("System.Int32"))

                Me.TabControl1.SelectedIndex = 1
                GVPlasticMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                Me.txtPlastic.Focus()
            Case 4, 5, 6 'Pd-Gen/ผักซอง/ดอกไม้
                'TabControl1.TabPages.Remove(TabGen)
                'TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabMat)
                TabControl1.TabPages.Remove(TabPlastic)
                TabControl1.TabPages.Remove(TabHormone)
                ' TabControl1.TabPages.Remove(TabPdOtherComp)
                getLotDt.Columns.Add("idPdPkLot", System.Type.GetType("System.Int64"))
                getLotDt.Columns.Add("Lotno", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("CompName", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("idComp", System.Type.GetType("System.Int32"))


                getLotDtM.Columns.Add("idPdLot", System.Type.GetType("System.Int64"))
                getLotDtO.Columns.Add("idPdOLot", System.Type.GetType("System.Int32"))
                getLotDtO.Columns.Add("idPdO", System.Type.GetType("System.Int32"))
                '  getLotDt.Columns.Add("SumAmt", System.Type.GetType("System.Int64"))
                ' getLotDt.Rows.Clear()

                Me.TabControl1.SelectedIndex = 0
                BindDataPdPk()

                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView1OC.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GVPdoMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                Me.txtPdName.Focus()
            Case 7 'สินค้าวัตถุดิบ
                TabControl1.TabPages.Remove(TabGen)
                'TabControl1.TabPages.Remove(TabOther)
                'TabControl1.TabPages.Remove(TabMat)
                TabControl1.TabPages.Remove(TabPlastic)
                TabControl1.TabPages.Remove(TabHormone)
                TabControl1.TabPages.Remove(TabPdOtherComp)
                getLotDt.Columns.Add("idPdPkLot", System.Type.GetType("System.Int64"))
                getLotDt.Columns.Add("Lotno", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("CompName", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("idComp", System.Type.GetType("System.Int32"))


                getLotDtM.Columns.Add("idPdLot", System.Type.GetType("System.Int64"))
                getLotDtO.Columns.Add("idPdOLot", System.Type.GetType("System.Int32"))
                getLotDtO.Columns.Add("idPdO", System.Type.GetType("System.Int32"))
                ' getLotDtM.Columns.Add("idPdAmt", System.Type.GetType("System.Double"))
                ' getLotDtM.Rows.Clear()

                Me.TabControl1.SelectedIndex = 1
                cmbPdoType()
                BindPlant()

                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView1OC.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GVHormoneMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GVPlasticMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                Me.txtPdNameL.Focus()
            Case 8 'สินค้าอื่นๆ
                cmbPdoType()
                TabControl1.TabPages.Remove(TabGen)
                'TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabMat)
                'TabControl1.TabPages.Remove(TabPlastic)
                ' TabControl1.TabPages.Remove(TabHormone)
                TabControl1.TabPages.Remove(TabPdOtherComp)
                getLotDt.Columns.Add("idPdPkLot", System.Type.GetType("System.Int64"))
                getLotDt.Columns.Add("Lotno", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("CompName", System.Type.GetType("System.String"))
                getLotDt.Columns.Add("idComp", System.Type.GetType("System.Int32"))


                getLotDtM.Columns.Add("idPdLot", System.Type.GetType("System.Int64"))
                getLotDtO.Columns.Add("idPdOLot", System.Type.GetType("System.Int32"))
                getLotDtO.Columns.Add("idPdO", System.Type.GetType("System.Int32"))

                Me.TabControl1.SelectedIndex = 0
                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GVPdoMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                Me.txtPdNameLot.Focus()
        End Select

        fnAddDataTable()
    End Sub

#Region "fnAddDataTable"
    Private Sub fnAddDataTable()
        MainReturn.Columns.Add("PdPkName", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("LotNum", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("idPdPkLot", System.Type.GetType("System.String"))
        MainReturn.Columns.Add("DtType", System.Type.GetType("System.Int64"))
    End Sub
#End Region
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If stPage = 1 Then 'eSaleLot
            Select Case Me.TabControl1.SelectedIndex
                Case 0
                    Me.txtPdName.Focus()
                    'Me.txtPdNameLot.Focus()
                Case 1
                    BindDataPd()
                    Me.txtPdNameLot.Focus()
                    ' Me.txtHormone.Focus()
                    ' Me.txtPlastic.Focus()
                Case 2
                    BindDataHormone()
                    Me.txtHormone.Focus()
                    ' Me.txtPdNameOC.Focus()
                    ' Me.txtService.Focus()
                Case 3
                    BindDataPlastic()
                    Me.txtPlastic.Focus()
                Case 4
                    BindDataMat()
                    Me.txtPdNameL.Focus()
                Case 5
                    BindDataPdPkOC()
                    Me.txtPdNameOC.Focus()

                Case 6
                    BindDataService()
                    Me.txtService.Focus()
            End Select
        ElseIf stPage = 2 Then 'Hormone
            Select Case Me.TabControl1.SelectedIndex
                Case 0
                    Me.txtPdNameLot.Focus()
                Case 1
                    BindDataHormone()
                    Me.txtHormone.Focus()
                Case 2
                    BindDataService()
                    Me.txtService.Focus()
            End Select
        ElseIf stPage = 3 Then 'plastic
            Select Case Me.TabControl1.SelectedIndex
                Case 0
                    Me.txtPdNameLot.Focus()
                Case 1
                    BindDataPlastic()
                    Me.txtHormone.Focus()
                Case 2
                    BindDataService()
                    Me.txtService.Focus()
            End Select
        ElseIf stPage = 7 Then 'สินค้าวัตถุดิบ
            Select Case Me.TabControl1.SelectedIndex
                Case 0
                    BindDataPd()
                    Me.txtPdName.Focus()
                Case 1
                    BindDataMat()
                    Me.txtPdNameL.Focus()
                Case 2
                    BindDataService()
                    Me.txtService.Focus()
            End Select
        ElseIf stPage = 8 Then ''สินค้าอื่นๆ
            Select Case Me.TabControl1.SelectedIndex
                Case 0
                    BindDataPd()
                    Me.txtPdNameLot.Focus()
                Case 1
                    BindDataHormone()
                    Me.txtHormone.Focus()
                Case 2
                    BindDataPlastic()
                    Me.txtPlastic.Focus()
                Case 3
                    BindDataService()
                    Me.txtService.Focus()
            End Select
        Else 'Pd-Gen/ผักซอง/ดอกไม้
            Select Case Me.TabControl1.SelectedIndex
                Case 0
                    Me.txtPdName.Focus()
                Case 1
                    BindDataPd()
                    Me.txtPdNameLot.Focus()
                Case 2
                    BindDataPdPkOC()
                    Me.txtPdNameOC.Focus()
                Case 3
                    BindDataService()
                    Me.txtService.Focus()
            End Select
        End If
    End Sub

#Region "PdPk-Lot"
    Private Sub BindDataPdPk()
        mdCnOpen()
        mdLoadShow()
        For i As Integer = 0 To sDt3.Rows.Count - 1
            If sDt3.Rows(i).Item("ChkKey") = True Then
                Dim stAddlot As Integer = 0
                For j As Integer = 0 To getLotDt.Rows.Count - 1
                    If sDt3.Rows(i).Item("idPdPkLot") = getLotDt.Rows(j).Item("idPdPkLot") Then
                        stAddlot = 1
                        Exit For
                    End If
                Next

                If stAddlot = 0 Then
                    'getLotDt.Rows.Add(sDt3.Rows(i).Item("idPdPkLot"))
                    getLotDt.Rows.Add(sDt3.Rows(i).Item("idPdPkLot"), sDt3.Rows(i).Item("LotNum"), sDt3.Rows(i).Item("CompName"), _
                                     sDt3.Rows(i).Item("CompRec"))
                End If
            End If
        Next

        Dim vWhere As String = ""

        If stPdGen = 1 Then 'เฉพาะสินค้าทั่วไป
            vWhere = vWhere & " AND l.idType = 0 "
        End If

        If stPack = 1 Then ' เฉพาะผักซอง
            vWhere = vWhere & " AND l.idType = 1 "
        End If

        If stFolwer = 1 Then 'เฉพาะดอกไม้ และ ต้องไม่ใช่สินค้าผักซอง
            vWhere = vWhere & " AND l.idSeedKind = 2 "
        End If

        If sIdComp = 10 Then 'สตาร์อะกรีเทค
            vWhere = vWhere & " AND (l.CompRec = 4 OR l.CompRec = " & sIdComp & ") "
        Else
            vWhere = vWhere & " AND l.CompRec = " & sIdComp & " "
        End If

        If ChkPd.Checked = True Then
            Dim tx As String = txtPdName.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" ConCat(l.PdPkName, ' ',l.ShortName) Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then
                vWhere = vWhere & " AND " & strPdPk
            End If
        End If

        If ChkLot.Checked = True Then
            vWhere = vWhere & " AND  l.LotNum = '" & txtLot.Text & "' "
        End If

        If Me.ChkNoStock.Checked = True Then
            vWhere = vWhere & " AND l.Amount > '0' "
        End If

        'If OnlyidPdPk <> 0 Then 'Show only lot Of idPdPk
        '    vWhere = vWhere & " AND p.idPdPk = " & OnlyidPdPk & ""
        'End If

        If lotDtCut.Rows.Count > 0 Then
            Dim stridCut As String = ""
            'MessageBox.Show(lotDtCut.Rows.Count & "/" & lotDtCutM.Rows.Count)
            For i As Integer = 1 To lotDtCut.Rows.Count - 1
                stridCut = stridCut & " AND l.idPdPkLot <> " & lotDtCut.Rows(i).Item("idPdPkLot") & " "
            Next

            vWhere = vWhere & " AND (l.idPdPkLot <> " & lotDtCut.Rows(0).Item("idPdPkLot") & stridCut & ") "
        End If


        Dim ds0 As New DataSet
        Dim sDt As New DataTable
        Dim sDt2 As New DataTable


        sDt.Clear()
        'sCommand.CommandText = "SELECT idPdPk,  PdPkName, ShortName, Amount, PkUnitName, (Weight*Amount/1000) As WightOfKg " & _
        '                       "FROM  (Select p.idPdPk, p.PdPkName, p.ShortName, SUM(l.Amount) As Amount, p.PkUnitName, p.Weight " & _
        '                       "From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT " & _
        '                       "LEFT OUTER JOIN vPackingPdSetLot l ON p.idPdPk = l.idPdPk WHERE p.stDel IS NULL AND l.stDel = 0 " & _
        '                       "AND l.stType <> 1 " & vWhere & vUnit1 & " Group By p.idPdPk, p.PdPkName, p.ShortName, " & _
        '                       "p.PkUnitName,p.Weight) as db1 UNION SELECT idPdPk,  PdPkName, ShortName, Amount, PkUnitName, " & _
        '                       "(Weight*Amount) As WightOfKg FROM  (Select p.idPdPk, p.PdPkName, p.ShortName, SUM(l.Amount) As Amount, " & _
        '                       "p.PkUnitName, p.Weight From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON " & _
        '                       "p.idPdT = t.idPdT LEFT OUTER JOIN vPackingPdSetLot l ON p.idPdPk = l.idPdPk " & _
        '                       "WHERE p.stDel IS NULL AND l.stDel = 0 AND l.stType <> 1 " & vWhere & vUnit2 & " Group By p.idPdPk, p.PdPkName, " & _
        '                       "p.ShortName, p.PkUnitName,p.Weight) as db2 Order by PdPkName"

        'sCommand.CommandText = "Select p.idPdPk, p.PdPkName, p.ShortName, SUM(l.Amount) As Amount, p.PkUnitName, p.Weight " & _
        '                     "From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT " & _
        '                     "LEFT OUTER JOIN vPackingPdSetLot l ON p.idPdPk = l.idPdPk WHERE p.stDel IS NULL AND l.stDel = 0 " & _
        '                     "AND l.stType <> 1 " & vWhere & " Group By p.idPdPk, p.PdPkName, p.ShortName, " & _
        '                     "p.PkUnitName,p.Weight Order by PdPkName"

        'sCommand.CommandText = "Select l.idPdPk, l.PdPkName, l.ShortName, SUM(l.Amount) As Amount, l.PkUnitName, l.Weight " & _
        '                       "From vPackingPdSetLot l WHERE ISNULL(l.stDel,0) = 0 AND l.stType <> 1  " & vWhere & " Group By " & _
        '                       "l.idPdPk, l.PdPkName, l.ShortName, l.PkUnitName,l.Weight Order by PdPkName"
        'sAdapter.Fill(sDt)

        sCommand.CommandText = "Select l.idPdPk, l.PdPkName, l.ShortName, SUM(l.Amount) As Amount, l.PkUnitName " & _
                               "From vPackingPdSetLotxSelect l WHERE ISNULL(l.stDel,0) = 0 AND l.stType <> 1  " & vWhere & " Group By " & _
                               "l.idPdPk, l.PdPkName, l.ShortName, l.PkUnitName Order by l.PdPkName"
        sAdapter.Fill(sDt)

        sDt2.Clear()
        'sCommand.CommandText = "Select l.idPdPk, l.idPdPkLot, l.LotNum, l.Amount, l.DateGen, l.WareHouseName, l.CompNameRec As CompName, l.CompRec " & _
        '                       "From vPackingPdSetLot l LEFT OUTER JOIN vPackingPdSet p On l.idPdPk = p.idPdPk LEFT OUTER JOIN vSlPdTradeNameD t " & _
        '                       "ON p.idPdT = t.idPdT WHERE l.stDel = 0 AND l.stType <> 1 " & vWhere & " Order by l.idPdPkLot"
        sCommand.CommandText = "Select l.idPdPk, l.idPdPkLot, l.LotNum, l.Amount, devsk.fncStrDateToDateTime(DateGen) As DateGen, " & _
                               "l.WareHouseName, l.CompNameRec As CompName, " & _
                                "l.CompRec From vPackingPdSetLotxSelect l WHERE l.stDel = 0 And l.stType <> 1 " & vWhere & " Order by l.idPdPkLot"
        sAdapter.Fill(sDt2)
        sDt2.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To sDt2.Rows.Count - 1
            'If sDt2.Rows(i).Item("DateGen") <> "" Then
            '    sDt2.Rows(i).Item("DateGen") = ksbStringToDate(sDt2.Rows(i).Item("DateGen"))
            'End If
            sDt2.Rows(i).Item("ChkKey") = False
            For j As Integer = 0 To getLotDt.Rows.Count - 1
                If sDt2.Rows(i).Item("idPdPkLot") = getLotDt.Rows(j).Item("idPdPkLot") Then
                    sDt2.Rows(i).Item("ChkKey") = True
                End If
            Next
        Next
        sDt3 = sDt2

        ds0.Tables.Clear()
        ds0.Tables.Add(sDt)
        ds0.Tables.Add(sDt2)

        Dim keyColumn As DataColumn = ds0.Tables(0).Columns("idPdPk")
        Dim foreignColumn As DataColumn = ds0.Tables(1).Columns("idPdPk")

        ds0.Relations.Add("ล็อตสินค้า", keyColumn, foreignColumn)

        GridControl1.DataSource = ds0.Tables(0)
        GridControl1.ForceInitialize()

        GridControl1.LevelTree.Nodes.Add("ล็อตสินค้า", DGVGeneral)
        mdLoadCommitt()
    End Sub

    Private Sub ChkPd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPd.CheckedChanged
        If Me.ChkPd.Checked = True Then
            Me.txtPdName.Enabled = True
            Me.txtPdName.Focus()
        Else
            Me.txtPdName.Enabled = False
        End If
    End Sub

    Private Sub ChkLot_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLot.CheckedChanged
        If Me.ChkLot.Checked = True Then
            Me.txtLot.Enabled = True
            Me.txtLot.Focus()
        Else
            Me.txtLot.Enabled = False
        End If
    End Sub

    Private Sub btnSchPd_Click(sender As Object, e As EventArgs) Handles btnSchPd.Click
        BindDataPdPk()
    End Sub

    Private Sub txtPdName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPdName.KeyUp
        'GridView1.Columns("PdPkName").FilterInfo = New ColumnFilterInfo(schGrid(txtPdName.Text))
        GridView1.ActiveFilterString = schGrid(txtPdName.Text, {"PdPkName", "Shortname"})
        'If e.KeyCode = Keys.Enter Then
        '    BindDataPdPk()
        'End If
    End Sub

    Private Sub txtLot_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataPdPk()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        getLotDt = MainReturn
        'For i As Integer = 0 To sDt3.Rows.Count - 1
        '    If sDt3.Rows(i).Item("ChkKey") = True Then
        '        Dim stAddlot2 As Integer = 0
        '        For j As Integer = 0 To getLotDt.Rows.Count - 1
        '            If sDt3.Rows(i).Item("idPdPkLot") = getLotDt.Rows(j).Item("idPdPkLot") Then
        '                stAddlot2 = 1
        '                Exit For
        '            End If
        '        Next

        '        If stAddlot2 = 0 Then
        '            ' getLotDt.Rows.Add(sDt3.Rows(i).Item("idPdPkLot"))
        '            getLotDt.Rows.Add(sDt3.Rows(i).Item("idPdPkLot"), sDt3.Rows(i).Item("LotNum"), sDt3.Rows(i).Item("CompName"), _
        '                              sDt3.Rows(i).Item("CompRec"))
        '        End If
        '    End If
        'Next

        'If getLotDt.Rows.Count = 0 Then
        '    mdLoadCommitt()
        '    MessageBox.Show("กรุณาเลือกล็อตสินค้าอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'Else

        'Me.DtType = 1 'สินค้าทั่วไป
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'End If
    End Sub
#End Region

#Region "PdPkOtherComp-Lot"
    Private Sub BindDataPdPkOC()
        mdCnOpen()
        mdLoadShow()
        For i As Integer = 0 To sDt3OC.Rows.Count - 1
            If sDt3OC.Rows(i).Item("ChkKey") = True Then
                Dim stAddlot As Integer = 0
                For j As Integer = 0 To getLotDt.Rows.Count - 1
                    If sDt3OC.Rows(i).Item("idPdPkLot") = getLotDt.Rows(j).Item("idPdPkLot") Then
                        stAddlot = 1
                        Exit For
                    End If
                Next

                If stAddlot = 0 Then
                    ' getLotDt.Rows.Add(sDt3OC.Rows(i).Item("idPdPkLot"))
                    getLotDt.Rows.Add(sDt3OC.Rows(i).Item("idPdPkLot"), sDt3OC.Rows(i).Item("LotNum"), sDt3OC.Rows(i).Item("CompName"), _
                                     sDt3OC.Rows(i).Item("CompRec"))
                End If
            End If
        Next

        Dim vWhere As String = ""

        If stPdGen = 1 Then 'เฉพาะสินค้าทั่วไป
            vWhere = vWhere & " AND l.idType = 0 "
        End If

        If stPack = 1 Then ' เฉพาะผักซอง
            vWhere = vWhere & " AND l.idType = 1 "
        End If

        If stFolwer = 1 Then 'เฉพาะดอกไม้ และ ต้องไม่ใช่สินค้าผักซอง
            vWhere = vWhere & " AND l.idSeedKind = 2 "
        End If

        If sIdComp = 10 Then 'สตาร์อะกรีเทค
            vWhere = vWhere & " AND (l.CompRec <> 4 AND l.CompRec <> " & sIdComp & ") "
        Else
            vWhere = vWhere & " AND l.CompRec <> " & sIdComp & " "
        End If

        If ChkPdOC.Checked = True Then
            Dim tx As String = txtPdNameOC.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" l.PdPkName Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then
                vWhere = vWhere & " AND " & strPdPk
            End If
        End If

        If ChkLotOC.Checked = True Then
            vWhere = vWhere & " AND  l.LotNum = '" & txtLotOC.Text & "' "
        End If

        If Me.ChkNoStockOC.Checked = True Then
            vWhere = vWhere & " AND l.Amount > '0' "
        End If

        If lotDtCut.Rows.Count > 0 Then
            ''check stock : หัก stock ของรายการขายที่มีแล้ว
            'Dim SumStock As Integer = 0
            'For n As Integer = 0 To DGVCombine.Rows.Count - 1
            '    If DGVCombine.Rows(n).Cells("ColidPdLotC").Value = sDt.Rows(0).Item("idPdPkLot") Then 'idPdPkLot ที่เลือกมา มีในรายการแล้ว
            '        SumStock = SumStock + DGVCombine.Rows(n).Cells("ColAmountC").Value
            '    End If
            'Next
            'sDt.Rows(0).Item("AmtStock") = sDt.Rows(0).Item("AmtStock") - SumStock

            Dim stridCut As String = ""
            'MessageBox.Show(lotDtCut.Rows.Count & "/" & lotDtCutM.Rows.Count)
            For i As Integer = 1 To lotDtCut.Rows.Count - 1
                stridCut = stridCut & " AND l.idPdPkLot <> " & lotDtCut.Rows(i).Item("idPdPkLot") & " "
            Next

            vWhere = vWhere & " AND (l.idPdPkLot <> " & lotDtCut.Rows(0).Item("idPdPkLot") & stridCut & ") "
        End If


        'Dim vUnit1 As String = ""
        'vUnit1 = " AND p.idUnitW = 1 "

        'Dim vUnit2 As String = ""
        'vUnit2 = " AND p.idUnitW = 2 "

        Dim ds0OC As New DataSet
        Dim sDtOC As New DataTable
        Dim sDt2OC As New DataTable


        sDtOC.Clear()
        'sCommand.CommandText = "Select p.idPdPk, p.PdPkName, p.ShortName, p.Amount, p.PkUnitName, " & _
        '                       "(p.Weight * p.Amount) As WightOfKg From vPackingPdSet p LEFT OUTER JOIN " & _
        '                       "vSlPdTradeNameD t ON p.idPdT = t.idPdT LEFT OUTER JOIN vPackingPdSetLot l " & _
        '                       "ON p.idPdPk = l.idPdPk WHERE l.stDel = 0 AND p.idComp <> " & sIdComp & vWhere & vUnit2 & " UNION Select p.idPdPk, p.PdPkName, " & _
        '                        "p.ShortName, p.Amount, p.PkUnitName, (p.Weight*p.Amount/1000) As WightOfKg " & _
        '                       "From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT " & _
        '                       "LEFT OUTER JOIN vPackingPdSetLot l ON p.idPdPk = l.idPdPk WHERE l.stDel = 0 AND " & _
        '                       "p.idComp <> " & sIdComp & vWhere & vUnit1 & " Order by p.PdPkName"
        'sCommand.CommandText = "SELECT idPdPk,  PdPkName, ShortName, Amount, PkUnitName, (Weight*Amount/1000) As WightOfKg " & _
        '                      "FROM  (Select p.idPdPk, p.PdPkName, p.ShortName, SUM(l.Amount) As Amount, p.PkUnitName, p.Weight " & _
        '                      "From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT " & _
        '                      "LEFT OUTER JOIN vPackingPdSetLot l ON p.idPdPk = l.idPdPk WHERE p.stDel IS NULL AND l.stDel = 0 " & _
        '                      "AND l.stType <> 1  " & vWhere & vUnit1 & " Group By p.idPdPk, p.PdPkName, p.ShortName, " & _
        '                      "p.PkUnitName,p.Weight) as db1 UNION SELECT idPdPk,  PdPkName, ShortName, Amount, PkUnitName, " & _
        '                      "(Weight*Amount) As WightOfKg FROM  (Select p.idPdPk, p.PdPkName, p.ShortName, SUM(l.Amount) As Amount, " & _
        '                      "p.PkUnitName, p.Weight From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON " & _
        '                      "p.idPdT = t.idPdT LEFT OUTER JOIN vPackingPdSetLot l ON p.idPdPk = l.idPdPk " & _
        '                      "WHERE p.stDel IS NULL AND l.stDel = 0 AND l.stType <> 1  " & vWhere & vUnit2 & " Group By p.idPdPk, p.PdPkName, " & _
        '                      "p.ShortName, p.PkUnitName,p.Weight) as db2 Order by PdPkName"

        'sCommand.CommandText = "Select p.idPdPk, p.PdPkName, p.ShortName, SUM(l.Amount) As Amount, p.PkUnitName, p.Weight " & _
        '                    "From vPackingPdSet p LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT " & _
        '                    "LEFT OUTER JOIN vPackingPdSetLot l ON p.idPdPk = l.idPdPk WHERE p.stDel IS NULL AND l.stDel = 0 " & _
        '                    "AND l.stType <> 1 " & vWhere & " Group By p.idPdPk, p.PdPkName, p.ShortName, " & _
        '                    "p.PkUnitName,p.Weight Order by PdPkName"

        sCommand.CommandText = "Select l.idPdPk, l.PdPkName, l.ShortName, SUM(l.Amount) As Amount, l.PkUnitName " & _
                             "From vPackingPdSetLotxSelect l WHERE ISNULL(l.stDel,0) = 0 AND l.stType <> 1  " & vWhere & " Group By " & _
                             "l.idPdPk, l.PdPkName, l.ShortName, l.PkUnitName Order by l.PdPkName"
        sAdapter.Fill(sDtOC)

        sDt2OC.Clear()
        'sCommand.CommandText = "Select l.idPdPk, l.idPdPkLot, l.LotNum, l.Amount, l.DateGen, l.WareHouseName, l.CompNameRec As CompName, l.CompRec " & _
        '                       "From vPackingPdSetLot l LEFT OUTER JOIN vPackingPdSet p On l.idPdPk = p.idPdPk LEFT OUTER JOIN vSlPdTradeNameD t " & _
        '                       "ON p.idPdT = t.idPdT WHERE l.stDel = 0 AND l.stType <> 1 " & vWhere & " Order by l.idPdPkLot"

        sCommand.CommandText = "Select l.idPdPk, l.idPdPkLot, l.LotNum, l.Amount, devsk.fncStrDateToDateTime(DateGen) As DateGen, " & _
                              "l.WareHouseName, l.CompNameRec As CompName, " & _
                               "l.CompRec From vPackingPdSetLotxSelect l WHERE l.stDel = 0 And l.stType <> 1 " & vWhere & " Order by l.idPdPkLot"
        sAdapter.Fill(sDt2OC)
        sDt2OC.Columns.Add("ChkKey", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To sDt2OC.Rows.Count - 1
            'If sDt2OC.Rows(i).Item("DateGen") <> "" Then
            '    sDt2OC.Rows(i).Item("DateGen") = ksbStringToDate(sDt2OC.Rows(i).Item("DateGen"))
            'End If
            sDt2OC.Rows(i).Item("ChkKey") = False
            For j As Integer = 0 To getLotDt.Rows.Count - 1
                If sDt2OC.Rows(i).Item("idPdPkLot") = getLotDt.Rows(j).Item("idPdPkLot") Then
                    sDt2OC.Rows(i).Item("ChkKey") = True
                End If
            Next
        Next
        sDt3OC = sDt2OC

        ds0OC.Tables.Clear()
        ds0OC.Tables.Add(sDtOC)
        ds0OC.Tables.Add(sDt2OC)

        Dim keyColumn As DataColumn = ds0OC.Tables(0).Columns("idPdPk")
        Dim foreignColumn As DataColumn = ds0OC.Tables(1).Columns("idPdPk")

        ds0OC.Relations.Add("ล็อตสินค้า", keyColumn, foreignColumn)

        GridControl1OC.DataSource = ds0OC.Tables(0)
        GridControl1OC.ForceInitialize()

        GridControl1OC.LevelTree.Nodes.Add("ล็อตสินค้า", GridView2OC)
        mdLoadCommitt()
    End Sub

    Private Sub ChkPdOC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPdOC.CheckedChanged
        If Me.ChkPdOC.Checked = True Then
            Me.txtPdNameOC.Enabled = True
            Me.txtPdNameOC.Focus()
        Else
            Me.txtPdNameOC.Enabled = False
        End If
    End Sub

    Private Sub ChkLotOC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLotOC.CheckedChanged
        If Me.ChkLotOC.Checked = True Then
            Me.txtLotOC.Enabled = True
            Me.txtLotOC.Focus()
        Else
            Me.txtLotOC.Enabled = False
        End If
    End Sub

    Private Sub btnSchPdOC_Click(sender As Object, e As EventArgs) Handles btnSchPdOC.Click
        BindDataPdPkOC()
    End Sub

    Private Sub txtPdNameOC_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPdNameOC.KeyUp
        ' GridView1OC.Columns("PdPkName").FilterInfo = New ColumnFilterInfo(schGrid(txtPdNameOC.Text))
        GridView1OC.ActiveFilterString = schGrid(txtPdNameOC.Text, {"PdPkName", "Shortname"})
        'If e.KeyCode = Keys.Enter Then
        '    BindDataPdPkOC()
        'End If
    End Sub

    Private Sub txtLotOC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLotOC.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataPdPkOC()
        End If
    End Sub

    Private Sub btn_addOC_Click(sender As Object, e As EventArgs) Handles btn_addOC.Click
        'For i As Integer = 0 To sDt3OC.Rows.Count - 1
        '    If sDt3OC.Rows(i).Item("ChkKey") = True Then
        '        Dim stAddlot2OC As Integer = 0
        '        For j As Integer = 0 To getLotDt.Rows.Count - 1
        '            If sDt3OC.Rows(i).Item("idPdPkLot") = getLotDt.Rows(j).Item("idPdPkLot") Then
        '                stAddlot2OC = 1
        '                Exit For
        '            End If
        '        Next

        '        If stAddlot2OC = 0 Then
        '            getLotDt.Rows.Add(sDt3OC.Rows(i).Item("idPdPkLot"), sDt3OC.Rows(i).Item("LotNum"), sDt3OC.Rows(i).Item("CompName"), _
        '                              sDt3OC.Rows(i).Item("CompRec"))
        '        End If
        '    End If
        'Next

        'If getLotDt.Rows.Count = 0 Then
        '    mdLoadCommitt()
        '    MessageBox.Show("กรุณาเลือกล็อตสินค้าอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'Else
        '    'Dim PdMoveList As String = ""
        '    'For i As Integer = 0 To getLotDt.Rows.Count - 1
        '    '    If sIdComp <> getLotDt.Rows(i).Item("idComp") Then 'บริษัทที่รับสินค้า ไม่ตรงกับบริษัทที่ Log in
        '    '        PdMoveList = PdMoveList & vbCrLf & "- Lot No. " & getLotDt.Rows(i).Item("Lotno") & " เป็นสินค้าบริษัท " & getLotDt.Rows(i).Item("CompName")
        '    '    End If
        '    'Next

        '    'mdLoadCommitt()
        '    'Result = MessageBox.Show(PdMoveList & vbCrLf & vbCrLf & "ระบบจะทำการโยกย้ายสินค้าทั้งหมดมายังคลังบริษัท '" & sCompName & "' ก่อนทำรายการขายสินค้า " & _
        '    '               "คุณยืนยันที่จะทำรายการขาย และให้ระบบโยกย้ายคลังใช่หรือไม่?", sSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        '    'If Result = Windows.Forms.DialogResult.Yes Then
        '    '    Me.DtType = 1 'สินค้าทั่วไป
        '    '    Me.DialogResult = Windows.Forms.DialogResult.OK
        '    '    Me.Close()
        '    'End If

        '    Me.DtType = 1 'สินค้าทั่วไป
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'End If
    End Sub
#End Region

#Region "PdOther"
    Private Sub cmbPdoType()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT distinct idPdoType, PdoTypeName From SmPdOtherTypeD WHERE idPdoType <> 2 " & _
                               "AND idPdoType <> 3 AND idPdoType <> 6 "  ' Not Hormone
        sAdapter.Fill(sDt)

        With Me.cmbType
            .DisplayMember = "PdoTypeName"
            .ValueMember = "idPdoType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub btnSchOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchOther.Click
        BindDataPd()
    End Sub

    Private Sub BindDataPd()
        mdCnOpen()
        mdLoadShow()

        For i As Integer = 0 To sDt3O.Rows.Count - 1
            If sDt3O.Rows(i).Item("ChkKeyO") = True Then
                Dim stAddlot2O As Integer = 0
                For j As Integer = 0 To getLotDtO.Rows.Count - 1
                    If sDt3O.Rows(i).Item("idPdOLot") = getLotDtO.Rows(j).Item("idPdOLot") Then
                        stAddlot2O = 1
                        Exit For
                    End If
                Next

                If stAddlot2O = 0 Then
                    getLotDtO.Rows.Add(sDt3O.Rows(i).Item("idPdOLot"), sDt3O.Rows(i).Item("idPdO"))
                End If
            End If
        Next

        Dim vWHERE As String = ""
        ' Dim vWHERE2 As String = ""

        If Me.ChkPdLot.Checked = True Then
            Dim tx As String = txtPdNameLot.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" d.Title Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then

                vWHERE = vWHERE & " AND " & strPdPk
            End If
        End If

        If Me.ChkType.Checked = True Then
            vWHERE = vWHERE & " AND d.idPdoType = '" & cmbType.SelectedValue & "' "
        End If

        If Me.ChkLotNoPdo.Checked = True Then
            vWHERE = vWHERE & " AND l.LotNum = '" & Trim(txtPdoLotNo.Text) & "' "
        End If

        If Me.ChkNoStockPdo.Checked = True Then
            vWHERE = vWHERE & " AND l.Amount > 0 "
        End If


        If lotDtCutO.Rows.Count > 0 Then
            Dim stridCut As String = ""
            For i As Integer = 1 To lotDtCutO.Rows.Count - 1
                stridCut = stridCut & " AND l.idPdOLot <> " & lotDtCutO.Rows(i).Item("idPdOLot") & " "
            Next

            vWHERE = vWHERE & " AND (l.idPdOLot <> " & lotDtCutO.Rows(0).Item("idPdOLot") & stridCut & ") "
        End If

        ' mdCnOpen()
        'sDt.Clear()
        'sCommand.CommandText = "SELECT p.idPdO, p.Title, t.PdoTypeName, p.Perbox FROM SmPdOtherD p " & _
        '                       "LEFT OUTER JOIN SmPdOtherTypeD t ON p.idPdoType = t.idPdoType " & _
        '                       "WHERE p.stDel IS NULL " & vWHERE & " AND p.idPdoType <> 2 AND p.idPdoType <> 3 Order by p.Title"
        'sAdapter.Fill(sDt)
        'DGVPdLot.DataSource = sDt
        'If sDt.Rows.Count = 0 Then
        '    mdLoadCommitt()
        '    MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
        '    Exit Sub
        'End If

        Dim ds0O As New DataSet
        Dim sDtO As New DataTable
        Dim sDt2O As New DataTable


        sDtO.Clear()
        sCommand.CommandText = "SELECT distinct d.idPdO, d.Title, d.PdoTypeName, SUM(l.Amount) As Amount, d.UnitName FROM " & _
                               "vSmPdOtherD d LEFT OUTER JOIN vSmPdOtherDLot l ON d.idPdO = l.idPdO WHERE d.stDel IS NULL AND l.stDel = 0 AND " & _
                               "l.CompRec = " & sIdComp & " AND d.idPdoType <> 2 AND d.idPdoType <> 3 AND d.idPdoType <> 6 " & _
                               "AND l.stType <> 1 " & vWHERE & " GROUP BY d.idPdO, d.Title, d.PdoTypeName, d.UnitName Order by d.Title"
        sAdapter.Fill(sDtO)

        sDt2O.Clear() 'vSmPdOtherDLo
        sCommand.CommandText = "SELECT l.idPdO, l.idPdOLot, l.LotNum, l.Amount, l.MFGDate, l.WareHouseName FROM vSmPdOtherDLot l " & _
                               "LEFT OUTER JOIN vSmPdOtherD d ON l.idPdO = d.idPdO WHERE d.stDel IS NULL AND l.CompRec = " & sIdComp & " AND " & _
                               "l.stDel = 0 AND d.idPdoType <> 2 AND d.idPdoType <> 3 AND d.idPdoType <> 6 " & _
                               "AND l.stType <> 1" & vWHERE & " Order by l.idPdOLot"
        sAdapter.Fill(sDt2O)
        sDt2O.Columns.Add("ChkKeyO", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To sDt2O.Rows.Count - 1
            If Not IsDBNull(sDt2O.Rows(i).Item("MFGDate")) Then
                sDt2O.Rows(i).Item("MFGDate") = ksbStringToDate(sDt2O.Rows(i).Item("MFGDate"))
            End If
            sDt2O.Rows(i).Item("ChkKeyO") = False
            For j As Integer = 0 To getLotDtO.Rows.Count - 1
                If sDt2O.Rows(i).Item("idPdOLot") = getLotDtO.Rows(j).Item("idPdOLot") Then
                    sDt2O.Rows(i).Item("ChkKeyO") = True
                End If
            Next
        Next
        sDt3O = sDt2O

        ds0O.Tables.Clear()
        ds0O.Tables.Add(sDtO)
        ds0O.Tables.Add(sDt2O)

        Dim keyColumn As DataColumn = ds0O.Tables(0).Columns("idPdO")
        Dim foreignColumn As DataColumn = ds0O.Tables(1).Columns("idPdO")

        ds0O.Relations.Add("ล็อตสินค้า", keyColumn, foreignColumn)

        GCPdo.DataSource = ds0O.Tables(0)
        GCPdo.ForceInitialize()

        GCPdo.LevelTree.Nodes.Add("ล็อตสินค้า", GVPdODt)
        mdLoadCommitt()
    End Sub

    Private Sub btnSelectPdo_Click(sender As Object, e As EventArgs) Handles btnSelectPdo.Click
        'For i As Integer = 0 To sDt3O.Rows.Count - 1
        '    If sDt3O.Rows(i).Item("ChkKeyO") = True Then
        '        Dim stAddlot2O As Integer = 0
        '        For j As Integer = 0 To getLotDtO.Rows.Count - 1
        '            If sDt3O.Rows(i).Item("idPdOLot") = getLotDtO.Rows(j).Item("idPdOLot") Then
        '                stAddlot2O = 1
        '                Exit For
        '            End If
        '        Next

        '        If stAddlot2O = 0 Then
        '            getLotDtO.Rows.Add(sDt3O.Rows(i).Item("idPdOLot"), sDt3O.Rows(i).Item("idPdO"))
        '        End If
        '    End If
        'Next

        'If getLotDtO.Rows.Count = 0 Then
        '    mdLoadCommitt()
        '    MessageBox.Show("กรุณาเลือกล็อตสินค้าอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'Else
        '    Me.DtType = 2  'สินค้าอื่นๆ
        'getLotDtO = MainReturn
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'End If
    End Sub

    'Private Sub DGVPdLot_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If e.RowIndex < 0 Then
    '        Exit Sub
    '    End If

    '    If DGVPdLot.Columns(e.ColumnIndex).Name = ColSelectO.Name Then
    '        idPdO = CInt(DGVPdLot.Rows(e.RowIndex).Cells(ColidPdO.Name).Value)
    '        Me.DtType = 2  ' สินค้าอื่นๆ

    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub DGVPdLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        e.SuppressKeyPress = True

    '        If DGVPdLot.CurrentCell.RowIndex < 0 Then
    '            Exit Sub
    '        End If

    '        If DGVPdLot.Columns(DGVPdLot.CurrentCell.ColumnIndex).Name = ColSelectO.Name Then
    '            idPdO = CInt(DGVPdLot.Rows(DGVPdLot.CurrentCell.RowIndex).Cells(ColidPdO.Name).Value)
    '            Me.DtType = 2   ' สินค้าอื่นๆ

    '            Me.DialogResult = Windows.Forms.DialogResult.OK
    '            Me.Close()

    '        End If
    '    End If
    'End Sub

    Private Sub ChkPdLot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPdLot.CheckedChanged
        If Me.ChkPdLot.Checked = True Then
            Me.txtPdNameLot.Enabled = True
            Me.txtPdNameLot.Focus()
        Else
            Me.txtPdNameLot.Text = ""
            Me.txtPdNameLot.Enabled = False
        End If
    End Sub

    Private Sub ChkType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkType.CheckedChanged
        If Me.ChkType.Checked = True Then
            Me.cmbType.Enabled = True
            Me.cmbType.Focus()
        Else
            Me.cmbType.Enabled = False
        End If
    End Sub

    Private Sub ChkLotNoPdo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLotNoPdo.CheckedChanged
        If Me.ChkLotNoPdo.Checked = True Then
            Me.txtPdoLotNo.Enabled = True
            Me.txtPdoLotNo.Focus()
        Else
            Me.txtPdoLotNo.Text = ""
            Me.txtPdoLotNo.Enabled = False
        End If
    End Sub

    Private Sub txtPdNameLot_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPdNameLot.KeyUp
        GVPdoMt.Columns("Title").FilterInfo = New ColumnFilterInfo(schGridOther(txtPdNameLot.Text))
        'If e.KeyCode = Keys.Enter Then
        '    BindDataPd()
        'End If
    End Sub

    Private Function schGridOther(ByVal txt As String) As String
        Dim ar() As String = txt.Trim().Split(" ")
        Dim msg As String = ""
        Dim a As String = ""
        For Each tx As String In ar
            msg &= a & "[Title] LIKE '%" & tx & "%'"
            a = " And "
        Next
        Return msg
    End Function

    Private Sub txtPdoLotNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPdoLotNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataPd()
        End If
    End Sub

#End Region

#Region "Pd-Matrial"
    Sub BindDataMat()
        mdCnOpen()
        mdLoadShow()

        For i As Integer = 0 To sDt3M.Rows.Count - 1
            If sDt3M.Rows(i).Item("ChkKeyM") = True Then
                Dim stAddlot2M As Integer = 0
                For j As Integer = 0 To getLotDtM.Rows.Count - 1
                    If sDt3M.Rows(i).Item("idPdLot") = getLotDtM.Rows(j).Item("idPdLot") Then
                        stAddlot2M = 1
                        Exit For
                    End If
                Next

                If stAddlot2M = 0 Then
                    getLotDtM.Rows.Add(sDt3M.Rows(i).Item("idPdLot"))
                End If
            End If
        Next

        Dim vWhere As String = ""
        If Me.ChkPdNameL.Checked = True Then
            Dim tx As String = txtPdNameL.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" p.PdName Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then
                vWhere = vWhere & " AND " & strPdPk
            End If
        End If

        If Me.ChkLotLefCode.Checked = True Then
            vWhere = vWhere & " AND s.LotCodeRef= '" & Me.txtLotSerial.Text & "' "
        End If

        If Me.ChkLotNum.Checked = True Then
            vWhere = vWhere & "AND s.LotNum = '" & Me.txtLotNum.Text & "'"
        End If

        If Me.ChkPlantType.Checked = True Then
            vWhere = vWhere & "AND p.idSeedType= '" & Me.cmbPlant.SelectedValue & "'"
        End If

        If Me.ChkPdname.Checked = True Then
            vWhere = vWhere & "AND s.idPd= '" & Me.cmbPdName.SelectedValue & "' "
        End If

        If Me.ChkNoPd.Checked = True Then
            vWhere = vWhere & "AND s.Amount > '0' "
        End If

        If lotDtCutM.Rows.Count > 0 Then
            Dim stridCutM As String = ""
            For i As Integer = 1 To lotDtCutM.Rows.Count - 1
                stridCutM = stridCutM & " AND s.idPdLot <> " & lotDtCutM.Rows(i).Item("idPdLot") & " "
            Next

            vWhere = vWhere & " AND (s.idPdLot <> " & lotDtCutM.Rows(0).Item("idPdLot") & stridCutM & ") "
        End If


        Dim ds0M As New DataSet
        Dim sDtM As New DataTable
        Dim sDt2M As New DataTable

        sDtM.Clear()
        sCommand.CommandText = "Select p.idPd, p.PdName, p.SeedTypeName, SUM(s.Amount) As sumAmount From PkPdLotStock s " & _
                               "LEFT OUTER JOIN vSeedProduct p ON s.idPd = p.idPd WHERE p.idPd <> 0 " & vWhere & " Group by " & _
                               "p.idPd, p.PdName, p.SeedTypeName Order by p.PdName"
        sAdapter.Fill(sDtM)

        sDt2M.Clear()
        sCommand.CommandText = "Select p.idPd, s.idPdLot, s.LotNum, s.LotCodeRef, s.Grad, s.Amount, s.Grow, s.Humid, s.Pure, s.DocPackCode, " & _
                               "s.Note, s.WareHouseName From vPkPdLotStock s LEFT OUTER JOIN vSeedProduct p ON s.idPd = p.idPd " & _
                               "WHERE p.idPd <> 0 " & vWhere & " Order by s.idPdLot "
        sAdapter.Fill(sDt2M)
        sDt2M.Columns.Add("ChkKeyM", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To sDt2M.Rows.Count - 1
            sDt2M.Rows(i).Item("ChkKeyM") = False
            For j As Integer = 0 To getLotDtM.Rows.Count - 1
                If sDt2M.Rows(i).Item("idPdLot") = getLotDtM.Rows(j).Item("idPdLot") Then
                    sDt2M.Rows(i).Item("ChkKeyM") = True
                End If
            Next
        Next
        sDt3M = sDt2M

        ds0M.Tables.Clear()
        ds0M.Tables.Add(sDtM)
        ds0M.Tables.Add(sDt2M)

        Dim keyColumn As DataColumn = ds0M.Tables(0).Columns("idPd")
        Dim foreignColumn As DataColumn = ds0M.Tables(1).Columns("idPd")

        ds0M.Relations.Add("ล็อตสินค้า", keyColumn, foreignColumn)

        GridControl2.DataSource = ds0M.Tables(0)
        GridControl2.ForceInitialize()

        GridControl2.LevelTree.Nodes.Add("ล็อตสินค้า", GridView3)
        mdLoadCommitt()
    End Sub

    Private Sub btnSchMat_Click(sender As Object, e As EventArgs) Handles btnSchMat.Click
        BindDataMat()
    End Sub

    Private Sub btnSelectMat_Click(sender As Object, e As EventArgs) Handles btnSelectMat.Click
        'For i As Integer = 0 To sDt3M.Rows.Count - 1
        '    If sDt3M.Rows(i).Item("ChkKeyM") = True Then
        '        Dim stAddlot2M As Integer = 0
        '        For j As Integer = 0 To getLotDtM.Rows.Count - 1
        '            If sDt3M.Rows(i).Item("idPdLot") = getLotDtM.Rows(j).Item("idPdLot") Then
        '                stAddlot2M = 1
        '                Exit For
        '            End If
        '        Next

        '        If stAddlot2M = 0 Then
        '            getLotDtM.Rows.Add(sDt3M.Rows(i).Item("idPdLot"))
        '        End If
        '    End If
        'Next

        'If getLotDtM.Rows.Count = 0 Then
        '    mdLoadCommitt()
        '    MessageBox.Show("กรุณาเลือกล็อตสินค้าอย่างน้อย 1 รายการ", sSystemName)
        '    Exit Sub
        'Else
        '    Me.DtType = 3  'สินค้าวัตถุดิบ
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'End If
    End Sub

    Private Sub ChkPdNameL_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPdNameL.CheckedChanged
        If Me.ChkPdNameL.Checked = True Then
            Me.txtPdNameL.Enabled = True
            Me.txtPdNameL.Focus()
        Else
            Me.txtPdNameL.Enabled = False
        End If
    End Sub

    Private Sub ChkLotLefCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLotLefCode.CheckedChanged
        If Me.ChkLotLefCode.Checked = True Then
            Me.txtLotSerial.Enabled = True
            Me.txtLotSerial.Focus()
        Else
            Me.txtLotSerial.Enabled = False
        End If
    End Sub

    Private Sub ChkLotNum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLotNum.CheckedChanged
        If Me.ChkLotNum.Checked = True Then
            Me.txtLotNum.Enabled = True
            Me.txtLotNum.Focus()
        Else
            Me.txtLotNum.Enabled = False
        End If
    End Sub

    Private Sub ChkPlantType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPlantType.CheckedChanged
        If Me.ChkPlantType.Checked = True Then
            Me.cmbPlant.Enabled = True
            Me.cmbPlant.Focus()
            Me.ChkPdname.Enabled = True
        Else
            Me.cmbPlant.Enabled = False
            Me.ChkPdname.Checked = False
        End If
    End Sub

    Private Sub ChkPdname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPdname.CheckedChanged
        If Me.ChkPdname.Checked = True Then
            Me.cmbPdName.Enabled = True
            Me.cmbPdName.Focus()
        Else
            Me.cmbPdName.Enabled = False
        End If
    End Sub

    Private Sub cmbPlant_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlant.SelectedIndexChanged
        BindPd()
    End Sub

    Private Sub txtLotSerial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLotSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataMat()
        End If
    End Sub

    Private Sub ChkPdNameL_KeyDown(sender As Object, e As KeyEventArgs) Handles ChkPdNameL.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataMat()
        End If
    End Sub

    Private Sub txtPdNameL_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPdNameL.KeyUp
        GridView4.Columns("PdName").FilterInfo = New ColumnFilterInfo(schGridPd(txtPdNameL.Text))
        'If e.KeyCode = Keys.Enter Then
        '    BindDataMat()
        'End If
    End Sub

    Private Function schGridPd(ByVal txt As String) As String
        Dim ar() As String = txt.Trim().Split(" ")
        Dim msg As String = ""
        Dim a As String = ""
        For Each tx As String In ar
            msg &= a & "[PdName] LIKE '%" & tx & "%'"
            a = " And "
        Next
        Return msg
    End Function

    Private Sub BindPlant()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idSeedType, SeedTypeName From vSeedProduct Order By SeedTypeName Asc"
        sAdapter.Fill(sDt)

        With cmbPlant
            .DisplayMember = "SeedTypeName"
            .ValueMember = "idSeedType"
            .DataSource = sDt
        End With

    End Sub

    Private Sub BindPd()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idPd, PdName From vSeedProduct Where idSeedType = '" & Me.cmbPlant.SelectedValue & "' Order By PdName Asc"
        sAdapter.Fill(sDt)

        With cmbPdName
            .DisplayMember = "PdName"
            .ValueMember = "idPd"
            .DataSource = sDt
        End With
    End Sub

#End Region

#Region "Pd-Hormone"
    Private Sub BindDataHormone()
        mdCnOpen()
        mdLoadShow()

        For i As Integer = 0 To sDt3O.Rows.Count - 1
            If sDt3O.Rows(i).Item("ChkKeyO") = True Then
                Dim stAddlot2O As Integer = 0
                For j As Integer = 0 To getLotDtO.Rows.Count - 1
                    If sDt3O.Rows(i).Item("idPdOLot") = getLotDtO.Rows(j).Item("idPdOLot") Then
                        stAddlot2O = 1
                        Exit For
                    End If
                Next

                If stAddlot2O = 0 Then
                    getLotDtO.Rows.Add(sDt3O.Rows(i).Item("idPdOLot"), sDt3O.Rows(i).Item("idPdO"))
                End If
            End If
        Next

        Dim vWHERE As String = ""

        Dim tx As String = txtHormone.Text
        Dim tx_a As String() = tx.Split(" ")
        Dim a_and As String = ""
        Dim strPdPk As String = ""
        If tx_a.Length > 0 Then
            For Each txt As String In tx_a
                If Not txt.Equals("") Then
                    strPdPk += a_and & "" & String.Format(" d.Title Like '%{0}%' ", txt)
                End If
                a_and = " and "
            Next
        End If

        If strPdPk <> "" Then
            vWHERE = vWHERE & " AND " & strPdPk
        End If

        If Me.ChkLotNoH.Checked = True Then
            vWHERE = vWHERE & " AND l.LotNum = '" & Trim(txtLotNoH.Text) & "' "
        End If

        If Me.ChkNoStockH.Checked = True Then
            vWHERE = vWHERE & " AND l.Amount > 0 "
        End If


        If lotDtCutO.Rows.Count > 0 Then
            Dim stridCut As String = ""
            For i As Integer = 1 To lotDtCutO.Rows.Count - 1
                stridCut = stridCut & " AND l.idPdOLot <> " & lotDtCutO.Rows(i).Item("idPdOLot") & " "
            Next

            vWHERE = vWHERE & " AND (l.idPdOLot <> " & lotDtCutO.Rows(0).Item("idPdOLot") & stridCut & ") "
        End If
        Dim ds0O As New DataSet
        Dim sDtO As New DataTable
        Dim sDt2O As New DataTable


        sDtO.Clear()
        sCommand.CommandText = "SELECT distinct d.idPdO, d.Title, d.PdoTypeName, SUM(l.Amount) As Amount, d.UnitName FROM " & _
                               "vSmPdOtherD d LEFT OUTER JOIN vSmPdOtherDLot l ON d.idPdO = l.idPdO WHERE d.stDel IS NULL " & _
                               "AND l.CompRec = " & sIdComp & " AND l.stDel = 0 AND l.stType <> 1 AND " & _
                               "d.idPdoType = 2  " & vWHERE & " GROUP BY d.idPdO, d.Title, d.PdoTypeName, d.UnitName  Order by d.Title"
        sAdapter.Fill(sDtO)

        sDt2O.Clear() 'vSmPdOtherDLo
        sCommand.CommandText = "SELECT l.idPdO, l.idPdOLot, l.LotNum, l.Amount, l.MFGDate, l.WareHouseName FROM vSmPdOtherDLot l " & _
                               "LEFT OUTER JOIN vSmPdOtherD d ON l.idPdO = d.idPdO WHERE d.stDel IS NULL AND l.CompRec = " & sIdComp & " AND " & _
                               "l.stDel = 0 AND l.stType <> 1 AND d.idPdoType = 2 " & vWHERE & " Order by l.idPdOLot"
        sAdapter.Fill(sDt2O)
        sDt2O.Columns.Add("ChkKeyO", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To sDt2O.Rows.Count - 1
            If Not IsDBNull(sDt2O.Rows(i).Item("MFGDate")) Then
                sDt2O.Rows(i).Item("MFGDate") = ksbStringToDate(sDt2O.Rows(i).Item("MFGDate"))
            End If
            sDt2O.Rows(i).Item("ChkKeyO") = False
            For j As Integer = 0 To getLotDtO.Rows.Count - 1
                If sDt2O.Rows(i).Item("idPdOLot") = getLotDtO.Rows(j).Item("idPdOLot") Then
                    sDt2O.Rows(i).Item("ChkKeyO") = True
                End If
            Next
        Next
        sDt3O = sDt2O

        ds0O.Tables.Clear()
        ds0O.Tables.Add(sDtO)
        ds0O.Tables.Add(sDt2O)

        Dim keyColumn As DataColumn = ds0O.Tables(0).Columns("idPdO")
        Dim foreignColumn As DataColumn = ds0O.Tables(1).Columns("idPdO")

        ds0O.Relations.Add("ล็อตสินค้า", keyColumn, foreignColumn)

        GCHormone.DataSource = ds0O.Tables(0)
        GCHormone.ForceInitialize()

        GCHormone.LevelTree.Nodes.Add("ล็อตสินค้า", GVHormoneDt)

        'mdCnOpen()
        'sDt.Clear()
        'sCommand.CommandText = "SELECT p.idPdO, p.Title, p.Perbox FROM SmPdOtherD p " & _
        '                           "LEFT OUTER JOIN SmPdOtherTypeD t ON p.idPdoType = t.idPdoType " & _
        '                           "WHERE p.stDel IS NULL " & vWHERE & " AND p.idPdoType = 2 Order by p.Title"
        'sAdapter.Fill(sDt)
        '' DGVHormone.DataSource = sDt
        '    If sDt.Rows.Count = 0 Then
        '        mdLoadCommitt()
        '        MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
        '        Exit Sub
        '    End If
        mdLoadCommitt()
    End Sub

    Private Sub btnHormone_Click(sender As Object, e As EventArgs) Handles btnHormone.Click
        BindDataHormone()
    End Sub

    Private Sub txtLotNoH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLotNoH.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataHormone()
        End If
    End Sub

    Private Sub txtHormone_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHormone.KeyUp
        'If e.KeyCode = Keys.Enter Then
        '    BindDataHormone()
        'End If
        GVHormoneMt.Columns("Title").FilterInfo = New ColumnFilterInfo(schGridOther(txtHormone.Text))
    End Sub

    Private Sub ChkLotNoH_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLotNoH.CheckedChanged
        If Me.ChkLotNoH.Checked = True Then
            Me.txtLotNoH.Enabled = True
            Me.txtLotNoH.Focus()
        Else
            Me.txtLotNoH.Enabled = Text = ""
            Me.txtLotNoH.Enabled = False
        End If

    End Sub

    Private Sub btnSelectH_Click(sender As Object, e As EventArgs) Handles btnSelectH.Click
        'For i As Integer = 0 To sDt3O.Rows.Count - 1
        '    If sDt3O.Rows(i).Item("ChkKeyO") = True Then
        '        Dim stAddlot2O As Integer = 0
        '        For j As Integer = 0 To getLotDtO.Rows.Count - 1
        '            If sDt3O.Rows(i).Item("idPdOLot") = getLotDtO.Rows(j).Item("idPdOLot") Then
        '                stAddlot2O = 1
        '                Exit For
        '            End If
        '        Next

        '        If stAddlot2O = 0 Then
        '            getLotDtO.Rows.Add(sDt3O.Rows(i).Item("idPdOLot"), sDt3O.Rows(i).Item("idPdO"))
        '        End If
        '    End If
        'Next

        'If getLotDtO.Rows.Count = 0 Then
        '    mdLoadCommitt()
        '    MessageBox.Show("กรุณาเลือกล็อตสินค้าอย่างน้อย 1 รายการ", sSystemName)
        '    Exit Sub
        'Else
        '    Me.DtType = 2  'สินค้าอื่นๆ
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'End If
    End Sub

    'Private Sub DGVHormone_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    '    If e.RowIndex < 0 Then
    '        Exit Sub
    '    End If

    '    If DGVHormone.Columns(e.ColumnIndex).Name = ColSelectH.Name Then
    '        idPdO = CInt(DGVHormone.Rows(e.RowIndex).Cells(ColidPdoH.Name).Value)
    '        Me.DtType = 2  ' สินค้าอื่นๆ

    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub DGVHormone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        e.SuppressKeyPress = True

    '        If DGVHormone.CurrentCell.RowIndex < 0 Then
    '            Exit Sub
    '        End If

    '        If DGVHormone.Columns(DGVHormone.CurrentCell.ColumnIndex).Name = ColSelectH.Name Then
    '            idPdO = CInt(DGVHormone.Rows(DGVHormone.CurrentCell.RowIndex).Cells(ColidPdoH.Name).Value)
    '            Me.DtType = 2  ' สินค้าอื่นๆ

    '            Me.DialogResult = Windows.Forms.DialogResult.OK
    '            Me.Close()
    '        End If
    '    End If
    'End Sub

#End Region

#Region "Pd-Plastic"

    Private Sub BindDataPlastic()
        mdCnOpen()
        mdLoadShow()

        For i As Integer = 0 To sDt3O.Rows.Count - 1
            If sDt3O.Rows(i).Item("ChkKeyO") = True Then
                Dim stAddlot2O As Integer = 0
                For j As Integer = 0 To getLotDtO.Rows.Count - 1
                    If sDt3O.Rows(i).Item("idPdOLot") = getLotDtO.Rows(j).Item("idPdOLot") Then
                        stAddlot2O = 1
                        Exit For
                    End If
                Next

                If stAddlot2O = 0 Then
                    getLotDtO.Rows.Add(sDt3O.Rows(i).Item("idPdOLot"), sDt3O.Rows(i).Item("idPdO"))
                End If
            End If
        Next

        Dim vWHERE As String = ""

        Dim tx As String = txtPlastic.Text
        Dim tx_a As String() = tx.Split(" ")
        Dim a_and As String = ""
        Dim strPdPk As String = ""
        If tx_a.Length > 0 Then
            For Each txt As String In tx_a
                If Not txt.Equals("") Then
                    strPdPk += a_and & "" & String.Format(" d.Title Like '%{0}%' ", txt)
                End If
                a_and = " and "
            Next
        End If

        If strPdPk <> "" Then
            vWHERE = vWHERE & " AND " & strPdPk
        End If

        If Me.ChkLotNoP.Checked = True Then
            vWHERE = vWHERE & " AND l.LotNum = '" & Trim(txtLotNoP.Text) & "' "
        End If

        If Me.ChkNoStockP.Checked = True Then
            vWHERE = vWHERE & " AND l.Amount > 0 "
        End If


        If lotDtCutO.Rows.Count > 0 Then
            Dim stridCut As String = ""
            For i As Integer = 1 To lotDtCutO.Rows.Count - 1
                stridCut = stridCut & " AND l.idPdOLot <> " & lotDtCutO.Rows(i).Item("idPdOLot") & " "
            Next

            vWHERE = vWHERE & " AND (l.idPdOLot <> " & lotDtCutO.Rows(0).Item("idPdOLot") & stridCut & ") "
        End If

        Dim ds0O As New DataSet
        Dim sDtO As New DataTable
        Dim sDt2O As New DataTable


        sDtO.Clear()
        sCommand.CommandText = "SELECT distinct d.idPdO, d.Title, d.PdoTypeName, SUM(l.Amount) As Amount, d.UnitName FROM " & _
                               "vSmPdOtherD d LEFT OUTER JOIN vSmPdOtherDLot l ON d.idPdO = l.idPdO WHERE d.stDel IS NULL " & _
                               "AND l.CompRec = " & sIdComp & " AND l.stDel = 0 AND l.stType <> 1 AND " & _
                               "d.idPdoType = 3  " & vWHERE & " GROUP BY d.idPdO, d.Title, d.PdoTypeName, d.UnitName Order by d.Title"
        sAdapter.Fill(sDtO)

        sDt2O.Clear() 'vSmPdOtherDLo
        sCommand.CommandText = "SELECT l.idPdO, l.idPdOLot, l.LotNum, l.Amount, l.MFGDate, l.WareHouseName FROM vSmPdOtherDLot l " & _
                               "LEFT OUTER JOIN vSmPdOtherD d ON l.idPdO = d.idPdO WHERE d.stDel IS NULL AND l.CompRec = " & sIdComp & " AND " & _
                               "l.stDel = 0 AND l.stType <> 1 AND d.idPdoType = 3 " & vWHERE & " Order by l.idPdOLot"
        sAdapter.Fill(sDt2O)
        sDt2O.Columns.Add("ChkKeyO", System.Type.GetType("System.Boolean"))

        For i As Integer = 0 To sDt2O.Rows.Count - 1
            If Not IsDBNull(sDt2O.Rows(i).Item("MFGDate")) Then
                sDt2O.Rows(i).Item("MFGDate") = ksbStringToDate(sDt2O.Rows(i).Item("MFGDate"))
            End If
            sDt2O.Rows(i).Item("ChkKeyO") = False
            For j As Integer = 0 To getLotDtO.Rows.Count - 1
                If sDt2O.Rows(i).Item("idPdOLot") = getLotDtO.Rows(j).Item("idPdOLot") Then
                    sDt2O.Rows(i).Item("ChkKeyO") = True
                End If
            Next
        Next
        sDt3O = sDt2O

        ds0O.Tables.Clear()
        ds0O.Tables.Add(sDtO)
        ds0O.Tables.Add(sDt2O)

        Dim keyColumn As DataColumn = ds0O.Tables(0).Columns("idPdO")
        Dim foreignColumn As DataColumn = ds0O.Tables(1).Columns("idPdO")

        ds0O.Relations.Add("ล็อตสินค้า", keyColumn, foreignColumn)

        GCPlastic.DataSource = ds0O.Tables(0)
        GCPlastic.ForceInitialize()

        GCPlastic.LevelTree.Nodes.Add("ล็อตสินค้า", GVPlasticDt)

        'mdCnOpen()
        'sDt.Clear()
        'sCommand.CommandText = "SELECT p.idPdO, p.Title FROM SmPdOtherD p " & _
        '                           "LEFT OUTER JOIN SmPdOtherTypeD t ON p.idPdoType = t.idPdoType " & _
        '                           "WHERE p.stDel IS NULL " & vWHERE & " AND p.idPdoType = 3 Order by p.Title"
        'sAdapter.Fill(sDt)
        '' DGV_Plastic.DataSource = sDt
        'If sDt.Rows.Count = 0 Then
        '    mdLoadCommitt()
        '    MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
        '    Exit Sub
        'End If
        mdLoadCommitt()
    End Sub

    Private Sub btnPlastic_Click(sender As Object, e As EventArgs) Handles btnPlastic.Click
        BindDataPlastic()
    End Sub

    Private Sub txtLotNoP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLotNoP.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataPlastic()
        End If
    End Sub

    Private Sub txtPlastic_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlastic.KeyUp
        GVPlasticMt.Columns("Title").FilterInfo = New ColumnFilterInfo(schGridOther(txtPlastic.Text))
        'If e.KeyCode = Keys.Enter Then
        '    BindDataPlastic()
        'End If
    End Sub

    Private Sub ChkLotNoP_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLotNoP.CheckedChanged
        If Me.ChkLotNoP.Checked = True Then
            Me.txtLotNoP.Enabled = True
            Me.txtLotNoP.Focus()
        Else
            Me.txtLotNoP.Enabled = False
            Me.txtLotNoP.Text = ""
        End If
    End Sub

    Private Sub btnSelectP_Click(sender As Object, e As EventArgs) Handles btnSelectP.Click
        'For i As Integer = 0 To sDt3O.Rows.Count - 1
        '    If sDt3O.Rows(i).Item("ChkKeyO") = True Then
        '        Dim stAddlot2O As Integer = 0
        '        For j As Integer = 0 To getLotDtO.Rows.Count - 1
        '            If sDt3O.Rows(i).Item("idPdOLot") = getLotDtO.Rows(j).Item("idPdOLot") Then
        '                stAddlot2O = 1
        '                Exit For
        '            End If
        '        Next

        '        If stAddlot2O = 0 Then
        '            getLotDtO.Rows.Add(sDt3O.Rows(i).Item("idPdOLot"), sDt3O.Rows(i).Item("idPdO"))
        '        End If
        '    End If
        'Next

        'If getLotDtO.Rows.Count = 0 Then
        '    mdLoadCommitt()
        '    MessageBox.Show("กรุณาเลือกล็อตสินค้าอย่างน้อย 1 รายการ", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'Else
        '    Me.DtType = 2  'สินค้าอื่นๆ
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'End If
    End Sub

    'Private Sub DGV_Plastic_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    '    If e.RowIndex < 0 Then
    '        Exit Sub
    '    End If

    '    If DGV_Plastic.Columns(e.ColumnIndex).Name = ColSelect_P.Name Then
    '        idPdO = CInt(DGV_Plastic.Rows(e.RowIndex).Cells(ColidPdO_P.Name).Value)
    '        Me.DtType = 2  ' สินค้าอื่นๆ

    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub DGV_Plastic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        e.SuppressKeyPress = True

    '        If DGV_Plastic.CurrentCell.RowIndex < 0 Then
    '            Exit Sub
    '        End If

    '        If DGV_Plastic.Columns(DGV_Plastic.CurrentCell.ColumnIndex).Name = ColSelect_P.Name Then
    '            idPdO = CInt(DGV_Plastic.Rows(DGV_Plastic.CurrentCell.RowIndex).Cells(ColidPdO_P.Name).Value)
    '            Me.DtType = 2  ' สินค้าอื่นๆ

    '            Me.DialogResult = Windows.Forms.DialogResult.OK
    '            Me.Close()
    '        End If
    '    End If
    'End Sub

#End Region

#Region "Service"

    Private Sub BindDataService()
        mdCnOpen()
        mdLoadShow()
        Dim vWHERE As String = ""

        Dim tx As String = txtService.Text
        Dim tx_a As String() = tx.Split(" ")
        Dim a_and As String = ""
        Dim strPdPk As String = ""
        If tx_a.Length > 0 Then
            For Each txt As String In tx_a
                If Not txt.Equals("") Then
                    strPdPk += a_and & "" & String.Format(" Title Like '%{0}%' ", txt)
                End If
                a_and = " and "
            Next
        End If

        If strPdPk <> "" Then
            vWHERE = vWHERE & " AND " & strPdPk
        End If


        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "SELECT idPdO, Title, PdoTypeName, UnitName, Price FROM vSmPdOtherD " & _
                               "WHERE stDel IS NULL " & vWHERE & " AND idPdoType = 6 Order by Title"
        sDt.Columns.Add("ChkKeyS", System.Type.GetType("System.Boolean"))
        sAdapter.Fill(sDt)
        GCService.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mdLoadCommitt()
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        BindDataService()
    End Sub

    Private Sub txtService_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtService.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataService()
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit8_Click(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit8.Click
        Me.idPdOService = GVService.GetRowCellValue(GVService.FocusedRowHandle, ColidPdoS)
        ' idPdOService = GVService.GetRowCellValue(, ColidPdoS)
        Me.DtType = 4  'Service
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

#End Region

    Private Sub fnAddDatatoDGVSelected(ByVal PdPkName As String, ByVal LotNum As String, ByVal idPdPkLot As Integer, ByVal DtType As Integer)

        Dim drNew As DataRow = MainReturn.NewRow()
        drNew("PdPkName") = PdPkName
        drNew("LotNum") = LotNum
        drNew("idPdPkLot") = idPdPkLot
        drNew("DtType") = DtType
        MainReturn.Rows.Add(drNew)
        GCSelected.DataSource = MainReturn

    End Sub

    Private Sub rptBtnSelect_Click(sender As Object, e As EventArgs) Handles rptBtnSelect.Click
        Dim dr As DataRow
        
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GridControl1.FocusedView
        Dim dr_1 As DataRow = detailView.GetDataRow(detailView.FocusedRowHandle)
        Dim PdPkName As String = dr.Item("PdPkName")
        Dim idPdPkLot As Integer = dr_1.Item("idPdPkLot")
        Dim LotNum As String = dr_1.Item("LotNum")
        Dim DtType As Integer = 1 'สินค้าทั่วไป
        fnAddDatatoDGVSelected(PdPkName, LotNum, idPdPkLot, DtType)
        'GCSelected.DataSource = getLotDt

    End Sub

   
    Private Sub rptbtnSelected_Click(sender As Object, e As EventArgs) Handles rptbtnSelected.Click
        Dim dr As DataRow

        dr = GVPdoMt.GetDataRow(GVPdoMt.FocusedRowHandle)
        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCPdo.FocusedView
        Dim dr_1 As DataRow = detailView.GetDataRow(detailView.FocusedRowHandle)

        Dim PdPkName As String = dr.Item("Title")
        Dim idPdPkLot As Integer = dr_1.Item("idPdOLot")
        Dim LotNum As String = dr_1.Item("LotNum")
        Dim DtType As Integer = 2 'สินค้าอื่นๆ (ไม่ใช่เมล็ด)
        fnAddDatatoDGVSelected(PdPkName, LotNum, idPdPkLot, DtType)
    End Sub

    Private Sub rptbtnSel_Click(sender As Object, e As EventArgs) Handles rptbtnSel.Click
        Dim dr As DataRow

        dr = GVHormoneMt.GetDataRow(GVHormoneMt.FocusedRowHandle)
        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCHormone.FocusedView
        Dim dr_1 As DataRow = detailView.GetDataRow(detailView.FocusedRowHandle)

        Dim PdPkName As String = dr.Item("Title")
        Dim idPdPkLot As Integer = dr_1.Item("idPdOLot")
        Dim LotNum As String = dr_1.Item("LotNum")
        Dim DtType As Integer = 2  'สินค้าอื่นๆ (ฮอร์โมน)
        fnAddDatatoDGVSelected(PdPkName, LotNum, idPdPkLot, DtType)
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click
        Dim dr As DataRow

        dr = GVPlasticMt.GetDataRow(GVPlasticMt.FocusedRowHandle)
        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GCPlastic.FocusedView
        Dim dr_1 As DataRow = detailView.GetDataRow(detailView.FocusedRowHandle)
        Dim PdPkName As String = dr.Item("Title")
        Dim idPdPkLot As Integer = dr_1.Item("idPdOLot")
        Dim LotNum As String = dr_1.Item("LotNum")
        Dim DtType As Integer = 2 'สินค้าอื่นๆ (พลาสติก)
        fnAddDatatoDGVSelected(PdPkName, LotNum, idPdPkLot, DtType)
    End Sub

    Private Sub rptbtnSelected2_Click(sender As Object, e As EventArgs) Handles rptbtnSelected2.Click
        Dim dr As DataRow

        dr = GridView1OC.GetDataRow(GridView1OC.FocusedRowHandle)
        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GridControl1OC.FocusedView
        Dim dr_1 As DataRow = detailView.GetDataRow(detailView.FocusedRowHandle)
        Dim PdPkName As String = dr.Item("PdPkName")
        Dim idPdPkLot As Integer = dr_1.Item("idPdPkLot")
        Dim LotNum As String = dr_1.Item("LotNum")
        Dim DtType As Integer = 1 'สินค้าทั่วไป
        fnAddDatatoDGVSelected(PdPkName, LotNum, idPdPkLot, DtType)
    End Sub

    Private Sub rptbtnsel1_Click(sender As Object, e As EventArgs) Handles rptbtnsel1.Click
        Dim dr As DataRow

        dr = GridView4.GetDataRow(GridView4.FocusedRowHandle)
        Dim detailView As DevExpress.XtraGrid.Views.Base.ColumnView = GridControl2.FocusedView
        Dim dr_1 As DataRow = detailView.GetDataRow(detailView.FocusedRowHandle)

        Dim PdPkName As String = dr.Item("PdName")
        Dim idPdPkLot As Integer = dr_1.Item("idPdLot")
        Dim LotNum As String = dr_1.Item("LotNum")
        Dim DtType As Integer = 3 'สินค้าวัตถุดิบ
        fnAddDatatoDGVSelected(PdPkName, LotNum, idPdPkLot, DtType)
    End Sub

    Private Sub rptbtnSelected3_Click(sender As Object, e As EventArgs) Handles rptbtnSelected3.Click
        Dim dr As DataRow

        dr = GVService.GetDataRow(GVService.FocusedRowHandle)

        Dim PdPkName As String = dr.Item("Title")
        Dim idPdPkLot As Integer = dr.Item("idPdO")
        Dim LotNum As String = ""
        Dim DtType As Integer = 4 'ค่าบริการ
        fnAddDatatoDGVSelected(PdPkName, LotNum, idPdPkLot, DtType)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub rptDel_Click(sender As Object, e As EventArgs) Handles rptDel.Click
        If lbrMsg.MsgQuestion("คุณต้องการลบรายการใช่หรือไม่?") = True Then
            Dim dr As DataRow = GVSelected.GetDataRow(GVSelected.FocusedRowHandle)
            dr.Delete()
            MainReturn.AcceptChanges()
        End If
    End Sub

    Private Sub ButtonUp_Click(sender As Object, e As EventArgs) Handles ButtonUp.Click
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GVSelected
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        If index <= 0 Then Exit Sub

        Dim row1 As DataRow = view.GetDataRow(index)
        Dim row2 As DataRow = view.GetDataRow((index - 1))
        Dim val1 As Object = row1("LotNum")
        Dim val2 As Object = row2("LotNum")
        row1("LotNum") = val2
        row2("LotNum") = val1
        Dim PdPkName1 As Object = row1("PdPkName")
        Dim PdPkName2 As Object = row2("PdPkName")
        row1("PdPkName") = PdPkName2
        row2("PdPkName") = PdPkName1
        Dim idPdPkLot1 As Object = row1("idPdPkLot")
        Dim idPdPkLot2 As Object = row2("idPdPkLot")
        row1("idPdPkLot") = idPdPkLot2
        row2("idPdPkLot") = idPdPkLot1
        Dim DtType1 As Object = row1("DtType")
        Dim DtType2 As Object = row2("DtType")
        row1("DtType") = DtType2
        row2("DtType") = DtType1
        view.FocusedRowHandle = index - 1

    End Sub

    Private Sub ButtonDown_Click(sender As Object, e As EventArgs) Handles ButtonDown.Click
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GVSelected
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        If index >= view.DataRowCount - 1 Then Exit Sub

        Dim row1 As DataRow = view.GetDataRow(index)
        Dim row2 As DataRow = view.GetDataRow((index + 1))
        Dim val1 As Object = row1("LotNum")
        Dim val2 As Object = row2("LotNum")
        row1("LotNum") = val2
        row2("LotNum") = val1
        Dim PdPkName1 As Object = row1("PdPkName")
        Dim PdPkName2 As Object = row2("PdPkName")
        row1("PdPkName") = PdPkName2
        row2("PdPkName") = PdPkName1
        Dim idPdPkLot1 As Object = row1("idPdPkLot")
        Dim idPdPkLot2 As Object = row2("idPdPkLot")
        row1("idPdPkLot") = idPdPkLot2
        row2("idPdPkLot") = idPdPkLot1
        Dim DtType1 As Object = row1("DtType")
        Dim DtType2 As Object = row2("DtType")
        row1("DtType") = DtType2
        row2("DtType") = DtType1
        view.FocusedRowHandle = index + 1
    End Sub


    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'GridView1.ExpandGroupRow(GridView1.FocusedRowHandle)
            GridView1.ExpandGroupLevel(0)
        End If
    End Sub

    Private Sub GVSelected_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVSelected.CustomDrawCell
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "colNum" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub
End Class