Public Class frmPdAllSelect
    Public idPdPk As String
    Public PdCodeS As String
    Public PdPkName As String
    Public Unit As String
    Public idPkUnit As String
    Public PerBox As Integer
    Public PriceBill As Double
    Public PriveWh As Double
    Public PriceRetail As Double
    Public idPdS As Integer
    Public pidPdPkLot As Integer
    Public PdPkLotNo As String
    Public ShortName As String
    Public Barcode As String
    Public PkUnitName As String

    Public idPdLot As Integer
    Public idPdO As Integer

    Public DtType As Integer  ' ประเภทสินค้า 1:ทั่วไป 2:สินค้าอื่นๆ 3:เมล็ด
    Dim sqlLot As Integer = 0
    Dim stPdGen As Integer = 0
    Dim stPack As Integer = 0
    Dim stFolwer As Integer = 0
    Dim eEvent As eProcess

    Enum eProcess
        eSale
        eQt
        eSaleLot
        eHormone
        ePlastic
        eSalePdGen
        eSalePack 'ผักซอง
        eSaleFolwer ' ดอกไม้
        eSalePdMat 'สินค้าวัตถุดิบ
        eSaleOther 'สินค้าอื่นๆ
        eReturn 'คืนสินค้า
    End Enum

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eSale
                sqlLot = 0
                stPdGen = 0
                stPack = 0
                stFolwer = 0
            Case eProcess.eQt
                ' stPage = 2
                sqlLot = 0
                stPdGen = 0
                stPack = 0
                stFolwer = 0
            Case eProcess.eSaleLot
                '   stPage = 3
                sqlLot = 1
                stPdGen = 0
                stPack = 0
                stFolwer = 0
            Case eProcess.eHormone
                ' stPage = 4
                sqlLot = 0
                stPdGen = 0
                stPack = 0
                stFolwer = 0
            Case eProcess.ePlastic
                '   stPage = 5
                sqlLot = 0
                stPdGen = 0
                stPack = 0
                stFolwer = 0
            Case eProcess.eSalePdGen
                '  stPage = 6
                sqlLot = 0
                stPdGen = 1
                stPack = 0
                stFolwer = 0
            Case eProcess.eSalePack 'ผักซอง
                '  stPage = 7
                stPdGen = 0
                sqlLot = 0
                stPack = 1
                stFolwer = 0
            Case eProcess.eSaleFolwer 'ดอกไม้
                '  stPage = 8
                sqlLot = 0
                stPdGen = 1
                stPack = 0
                stFolwer = 1
            Case eProcess.eSalePdMat 'วัคถุดิบ
                '   stPage = 9
                sqlLot = 0
                stPdGen = 0
                stPack = 0
                stFolwer = 0
            Case eProcess.eSaleOther 'สินค้าอื่นๆ
                '  stPage = 10
                sqlLot = 0
                stPdGen = 0
                stPack = 0
                stFolwer = 0
            Case eProcess.eReturn 'คืนสินค้า
                '  stPage = 11
                sqlLot = 0
                stPdGen = 0
                stPack = 0
                stFolwer = 0
        End Select
        eEvent = aProcess
    End Sub

    Private Sub frmPdAllSelect_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Select Case eEvent
            Case 1  ' Sale
                TabControl1.TabPages.Remove(TabQt)
                Me.TabControl1.SelectedIndex = 0
                Me.TabControl1.SelectedIndex = 1
                Me.TabControl1.SelectedIndex = 2
                Me.TabControl1.SelectedIndex = 3
                Me.TabControl1.SelectedIndex = 5
                Me.TabControl1.SelectedIndex = 6
                cmbPdoType()
                BindPlant()
                Me.TabControl1.SelectedIndex = 0
                Me.txtPdName.Focus()
                '  BindPd()
            Case 2  ' qt
                BindPlantn()
                'BindPdn()
                TabControl1.TabPages.Remove(TabMaterial)
                Me.TabControl1.SelectedIndex = 0
                Me.TabControl1.SelectedIndex = 1
                Me.TabControl1.SelectedIndex = 2
                Me.TabControl1.SelectedIndex = 4
                Me.TabControl1.SelectedIndex = 5
                Me.TabControl1.SelectedIndex = 6
                cmbPdoType()
                Me.TabControl1.SelectedIndex = 0
                Me.txtPdName.Focus()
            Case 3  ' Sale LOt
                Me.TabControl1.SelectedIndex = 0
                Me.TabControl1.SelectedIndex = 1
                Me.TabControl1.SelectedIndex = 2
                Me.TabControl1.SelectedIndex = 3
                Me.TabControl1.SelectedIndex = 5
                Me.TabControl1.SelectedIndex = 6
                cmbPdoType()

                BindPlant()
                TabControl1.TabPages.Remove(TabQt)
                dgvPd.Columns(ColAmountP.Name).Visible = True
                dgvPd.Columns(ColLotNo.Name).Visible = True
                dgvPd.Columns(ColPkUnitName.Name).Visible = True
                Me.ChkNoStock.Visible = True
                Me.ChkLot.Visible = True
                Me.txtLot.Visible = True
                Me.ChkNolot_Otc.Visible = True
                Me.chkLotno_otc.Visible = True
                Me.txtLotNo_otc.Visible = True
                Me.TabControl1.SelectedIndex = 0
                Me.txtPdName.Focus()
            Case 4 ' sale Hormone
                TabControl1.TabPages.Remove(TabGen)
                ' TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabQt)
                TabControl1.TabPages.Remove(TabMaterial)
                TabControl1.TabPages.Remove(TabPlastic)
                TabControl1.TabPages.Remove(TabPdOtherComp)

                Me.TabControl1.SelectedIndex = 1
                Me.txtHormone.Focus()
            Case 5 ' sale Plastic
                TabControl1.TabPages.Remove(TabGen)
                'TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabMaterial)
                TabControl1.TabPages.Remove(TabQt)
                TabControl1.TabPages.Remove(TabHormone)
                TabControl1.TabPages.Remove(TabPdOtherComp)

                Me.TabControl1.SelectedIndex = 1
                Me.txtPlastic.Focus()
            Case 6 ' eSalePack
                'TabControl1.TabPages.Remove(TabGen)
                'TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabMaterial)
                TabControl1.TabPages.Remove(TabQt)
                TabControl1.TabPages.Remove(TabPlastic)
                TabControl1.TabPages.Remove(TabHormone)
                ' TabControl1.TabPages.Remove(TabPdOtherComp)

                Me.TabControl1.SelectedIndex = 0
                Me.txtPdName.Focus()
            Case 7 ' eSalePdGen
                TabControl1.TabPages.Remove(TabMaterial)
                TabControl1.TabPages.Remove(TabQt)
                TabControl1.TabPages.Remove(TabPlastic)
                TabControl1.TabPages.Remove(TabHormone)

                Me.TabControl1.SelectedIndex = 0
                Me.txtPdName.Focus()
            Case 8 ' eSalePdGen
                TabControl1.TabPages.Remove(TabMaterial)
                TabControl1.TabPages.Remove(TabQt)
                TabControl1.TabPages.Remove(TabPlastic)
                TabControl1.TabPages.Remove(TabHormone)

                Me.TabControl1.SelectedIndex = 0
                Me.txtPdName.Focus()
            Case 9 'วัคถุดิบ
                TabControl1.TabPages.Remove(TabGen)
                ' TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabQt)
                ' TabControl1.TabPages.Remove(TabMaterial)
                TabControl1.TabPages.Remove(TabPlastic)
                TabControl1.TabPages.Remove(TabHormone)
                TabControl1.TabPages.Remove(TabPdOtherComp)

                cmbPdoType()
                Me.TabControl1.SelectedIndex = 1
                Me.txtPdName.Focus()
            Case 10 'สินค้าอื่นๆ
                TabControl1.TabPages.Remove(TabGen)
                ' TabControl1.TabPages.Remove(TabOther)
                TabControl1.TabPages.Remove(TabQt)
                TabControl1.TabPages.Remove(TabMaterial)
                ' TabControl1.TabPages.Remove(TabPlastic)
                ' TabControl1.TabPages.Remove(TabHormone)
                TabControl1.TabPages.Remove(TabPdOtherComp)
                Me.TabControl1.SelectedIndex = 0
                Me.txtPdNameLot.Focus()
            Case 11 'คืนสินค้า
                BindPlantn()
                'TabControl1.TabPages.Remove(TabGen)
                TabControl1.TabPages.Remove(TabOther)
                'TabControl1.TabPages.Remove(TabQt)
                TabControl1.TabPages.Remove(TabMaterial)
                ' TabControl1.TabPages.Remove(TabPlastic)
                ' TabControl1.TabPages.Remove(TabHormone)
                TabControl1.TabPages.Remove(TabPdOtherComp)
                Me.TabControl1.SelectedIndex = 0
                Me.txtPdName.Focus()
        End Select
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Me.txtPdName.Focus()
            Case 1
                If eEvent = eProcess.eReturn Then
                    Me.txtHormone.Focus()
                Else
                    Me.txtPdNameLot.Focus()
                End If
            Case 2
                Me.txtPd_Otc.Focus()
                Me.txtHormone.Focus()
            Case 3
                Me.txtPlastic.Focus()
            Case 4
                Me.txtPdNameL.Focus()
            Case 5
                Me.txtPd_Otc.Focus()
            Case 6
                Me.cmbPlantType.Focus()
        End Select

    End Sub

    Private Sub cmbPdoType()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "SELECT distinct idPdoType, PdoTypeName From SmPdOtherTypeD WHERE idPdoType <> 2 AND idPdoType <> 3 "
        sAdapter.Fill(sDt)

        With Me.cmbType
            .DisplayMember = "PdoTypeName"
            .ValueMember = "idPdoType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindPd()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idPd, PdName From vSeedProduct Where stDel IS NULL AND " & _
                               "idSeedType = '" & Me.cmbPlant.SelectedValue & "' Order By PdName Asc"
        sAdapter.Fill(sDt)

        With cmbPdName
            .DisplayMember = "PdName"
            .ValueMember = "idPd"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindPdn()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idPd, PdName From vSeedProduct Where stDel IS NULL AND " & _
                               "idSeedType = '" & Me.cmbPlantType.SelectedValue & "' Order By PdName Asc"
        sAdapter.Fill(sDt)

        With cmbPdNamen
            .DisplayMember = "PdName"
            .ValueMember = "idPd"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindPlant()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idSeedType, SeedTypeName From vSeedProduct WHERE stDel IS NULL Order By SeedTypeName Asc"
        sAdapter.Fill(sDt)

        With cmbPlant
            .DisplayMember = "SeedTypeName"
            .ValueMember = "idSeedType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub BindPlantn()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select Distinct idSeedType, SeedTypeName From vSeedProduct WHERE stDel IS NULL Order By SeedTypeName Asc"
        sAdapter.Fill(sDt)

        With cmbPlantType
            .DisplayMember = "SeedTypeName"
            .ValueMember = "idSeedType"
            .DataSource = sDt
        End With
    End Sub

    Private Sub btnSchPd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchPd.Click
        BindDataGeneral()
    End Sub

    Private Sub txtPdName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPdName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataGeneral()
        End If
    End Sub

    Private Sub txtLot_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindDataGeneral()
        End If
    End Sub

    Private Sub BindDataGeneral()
        Dim vWHERE As String = ""
        Dim sDt As New DataTable

        If stPdGen = 1 Then 'เฉพาะสินค้าทั่วไป
            vWHERE = vWHERE & " AND p.idType = 0 "
        End If

        If stPack = 1 Then ' เฉพาะผักซอง
            vWHERE = vWHERE & " AND p.idType = 1 "
        End If

        If stFolwer = 1 Then 'เฉพาะดอกไม้ และ ต้องไม่ใช่สินค้าผักซอง
            vWHERE = vWHERE & " AND p.idSeedKind = 2 "
        End If

        If ChkPd.Checked = True Then
            Dim tx As String = txtPdName.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" PdPkName Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then
                ' vWHERE = vWHERE & "Where " & strPdPk
                vWHERE = vWHERE & " AND " & strPdPk
            End If
        End If

        If ChkLot.Checked = True Then
            'If vWHERE = "" Then
            '    vWHERE = vWHERE & "WHERE lot.LotNum = '" & txtLot.Text & "' "
            'Else
            vWHERE = vWHERE & " AND  lot.LotNum = '" & txtLot.Text & "' "
            'End If
        End If



        'vWHERE = " Where (p.PdPkName Like '%" & txtPdName.Text & "%' OR p.ShortName Like '%" & txtPdName.Text & "%') "

        mdCnOpen()
        sDt.Clear()
        If sqlLot = 0 Then
            sCommand.CommandText = "Select p.idPdPk, p.PdCode, p.Barcode, p.PdPkName, p.ShortName, p.Weight, p.UnitW, " & _
                                   "p.idUnitW, p.idPkUnit, p.PkUnitName, p.PriceBill, p.PriceWholesale, " & _
                                   "p.PriceRetail, p.PerBox, t.idSeedKind From vPackingPdSet p " & _
                                   "LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT WHERE p.stDel IS NULL AND p.idComp = " & sIdComp & " " & _
                                   "" & vWHERE & " Order by p.PdPkName"
        Else
            If Me.ChkNoStock.Checked = True Then
                'If vWHERE = " " Then
                '    vWHERE = "Where lot.Amount > '0' "
                'Else
                vWHERE = vWHERE & "AND lot.Amount > '0' "
                '  End If

            End If

            sCommand.CommandText = "Select lot.idPdPkLot , lot.LotNum , p.idPdPk, p.PdCode, p.Barcode, p.PdPkName, p.ShortName," & _
                                   "p.Weight, p.UnitW, p.idUnitW, p.idPkUnit, p.PkUnitName, p.PriceBill, p.PriceWholesale, " & _
                                   "p.PriceRetail, p.PerBox, t.idSeedKind, lot.Amount From dPackingPdSetLot lot " & _
                                   "LEFT JOIN vPackingPdSet p ON p.idPdPk = lot.idPdPk " & _
                                    "LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT WHERE p.stDel IS NULL AND p.idComp = " & sIdComp & " " & _
                                    "" & vWHERE & " Order by p.PdPkName"

        End If

        sAdapter.Fill(sDt)
        dgvPd.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
            Exit Sub
        End If

    End Sub

    Private Sub btnSchOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchOther.Click
        mdLoadShow()
        BindDataPd()
        mdLoadCommitt()
    End Sub

    Private Sub txtPdNameLot_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPdNameLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindDataPd()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub BindDataPd() ' สินค้าอื่นๆ
        Dim sDt As New DataTable
        Dim vWHERE As String = ""

        If Me.ChkPdLot.Checked = True Then
            Dim tx As String = txtPdNameLot.Text
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
            ' vWHERE = vWHERE & " AND p.PdoName Like '%" & txtPdNameLot.Text & "%' "
        End If

        If Me.ChkType.Checked = True Then
            vWHERE = vWHERE & " AND p.idPdoType = '" & cmbType.SelectedValue & "' "
        End If

        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdO, p.Title, t.PdoTypeName, p.Perbox FROM SmPdOtherD p " & _
                               "LEFT OUTER JOIN SmPdOtherTypeD t ON p.idPdoType = t.idPdoType " & _
                               "WHERE p.stDel IS NULL " & vWHERE & " AND p.idPdoType <> 2 AND p.idPdoType <> 3 Order by p.Title"
        sAdapter.Fill(sDt)
        DGVPdLot.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
            Exit Sub
        End If

    End Sub

    Sub BindDataMat()
        Dim vWhere As String = " "

        If Me.ChkPdNameL.Checked = True Then
            Dim tx As String = txtPdNameL.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" PdName Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then
                vWhere = vWhere & " WHERE " & strPdPk
            End If
        End If


        If Me.ChkLotLefCode.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where s.LotCodeRef= '" & Me.txtLotSerial.Text & "' "
            Else
                vWhere = vWhere & "AND s.LotCodeRef= '" & Me.txtLotSerial.Text & "' "
            End If
        End If

        If Me.ChkLotNum.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where s.LotNum = '" & Me.txtLotNum.Text & "' "
            Else
                vWhere = vWhere & "AND s.LotNum = '" & Me.txtLotNum.Text & "'"
            End If

        End If

        If Me.ChkPlantType.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where p.idSeedType= '" & Me.cmbPlant.SelectedValue & "' "
            Else
                vWhere = vWhere & "AND p.idSeedType= '" & Me.cmbPlant.SelectedValue & "'"
            End If

        End If

        If Me.ChkPdname.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where s.idPd= '" & Me.cmbPdName.SelectedValue & "' "
            Else
                vWhere = vWhere & "AND s.idPd= '" & Me.cmbPdName.SelectedValue & "' "
            End If
        End If


        If Me.ChkNoPd.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where s.Amount > '0' "
            Else
                vWhere = vWhere & "AND s.Amount > '0' "
            End If

        End If

        mdCnOpen()
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "Select s.idPdLot, s.LotNum, s.LotCodeRef, s.idPd, p.PdName, p.SeedTypeName, " & _
                               "s.Amount, s.Grad, s.Grow, s.Humid, s.Pure, s.DocPackCode, " & _
                               "s.Note From PkPdLotStock s LEFT OUTER JOIN vSeedProduct p " & _
                               "ON s.idPd = p.idPd " & vWhere

        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสต๊อกสินค้าวัตถุดิบ", sSystemName)
            dgvShowData.DataSource = sDt
            Exit Sub
        Else

            dgvShowData.DataSource = sDt
            ksbCountRowDgv(dgvShowData, ColNum.Name)
        End If
    End Sub

    Private Sub btnSchMat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchMat.Click
        mdLoadShow()
        BindDataMat()
        mdLoadCommitt()
    End Sub

    Private Sub txtPdNameL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPdNameL.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindDataMat()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub txtLotSerial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLotSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindDataMat()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub ChkPdNameL_KeyDown(sender As Object, e As KeyEventArgs) Handles ChkPdNameL.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindDataMat()
            mdLoadCommitt()
        End If
    End Sub


    Sub BindDataMat_n()
        Dim vWhere As String = " "

        If Me.ChkPlantTypen.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where stDel IS NULL AND idSeedType = '" & Me.cmbPlantType.SelectedValue & "' "
            Else
                vWhere = vWhere & "AND idSeedType = '" & Me.cmbPlantType.SelectedValue & "'"
            End If
        End If

        If Me.chkPdn.Checked = True Then
            If vWhere = " " Then
                vWhere = "Where stDel IS NULL idPd = '" & Me.cmbPdNamen.SelectedValue & "' "
            Else
                vWhere = vWhere & "AND idPd = '" & Me.cmbPdNamen.SelectedValue & "' "
            End If
        End If

        mdCnOpen()
        Dim sDt As New DataTable
        sDt.Clear()
        sCommand.CommandText = "Select distinct idPd, PdName, SeedTypeName From vSeedProduct " & vWhere

        sAdapter.Fill(sDt)

        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้าวัตถุดิบ", sSystemName)
            DGVPdn.DataSource = sDt
            Exit Sub
        Else

            DGVPdn.DataSource = sDt
            ksbCountRowDgv(DGVPdn, ColNumN.Name)
        End If
    End Sub

    Private Sub ChkPdLot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPdLot.CheckedChanged
        If Me.ChkPdLot.Checked = True Then
            Me.txtPdNameLot.Enabled = True
            Me.txtPdNameLot.Focus()
        Else
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

    Private Sub dgvPd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPd.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvPd.Columns(e.ColumnIndex).Name = colSelect.Name Then
            idPdPk = CStr(dgvPd.Rows(e.RowIndex).Cells(idPd.Name).Value)

            If IsDBNull(dgvPd.Rows(e.RowIndex).Cells(colPdName.Name).Value) Then
                '--Nothing--'
            Else
                Me.PdPkName = CStr(dgvPd.Rows(e.RowIndex).Cells(colPdName.Name).Value)
            End If

            If IsDBNull(dgvPd.Rows(e.RowIndex).Cells(PdCode.Name).Value) Then
                '--Nothing--'
            Else
                Me.PdCodeS = CStr(dgvPd.Rows(e.RowIndex).Cells(PdCode.Name).Value)
            End If

            If IsDBNull(dgvPd.Rows(e.RowIndex).Cells(ColPerBox.Name).Value) Then
                '---nothing---'
            Else
                Me.PerBox = CInt(dgvPd.Rows(e.RowIndex).Cells(ColPerBox.Name).Value)
            End If

            If Not IsDBNull(dgvPd.Rows(e.RowIndex).Cells(ColShortName.Name).Value) Then
                ShortName = dgvPd.Rows(e.RowIndex).Cells(ColShortName.Name).Value
            End If
            If Not IsDBNull(dgvPd.Rows(e.RowIndex).Cells(ColBarcode.Name).Value) Then
                Barcode = dgvPd.Rows(e.RowIndex).Cells(ColBarcode.Name).Value
            End If
            If Not IsDBNull(dgvPd.Rows(e.RowIndex).Cells(ColPkUnitName.Name).Value) Then
                PkUnitName = dgvPd.Rows(e.RowIndex).Cells(ColPkUnitName.Name).Value
            End If

            Me.pidPdPkLot = dgvPd.Rows(e.RowIndex).Cells(idPdPkLot.Name).Value
            Me.PdPkLotNo = dgvPd.Rows(e.RowIndex).Cells(ColLotNo.Name).Value
            Me.Unit = CStr(dgvPd.Rows(e.RowIndex).Cells(ColPkUnitName.Name).Value)
            Me.PriceBill = CDbl(dgvPd.Rows(e.RowIndex).Cells(ColPriceBill.Name).Value)
            Me.PriveWh = CDbl(dgvPd.Rows(e.RowIndex).Cells(ColPriceWholesale.Name).Value)
            Me.PriceRetail = CDbl(dgvPd.Rows(e.RowIndex).Cells(ColPriceRetail.Name).Value)
            Me.idPkUnit = CStr(dgvPd.Rows(e.RowIndex).Cells(colidPkUnit.Name).Value)
            Me.DtType = 1 'สินค้าทั่วไป

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub dgvPd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvPd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If dgvPd.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If dgvPd.Columns(dgvPd.CurrentCell.ColumnIndex).Name = colSelect.Name Then
                idPdPk = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(idPd.Name).Value)

                If IsDBNull(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(colPdName.Name).Value) Then
                    '--Nothing--'
                Else
                    Me.PdPkName = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(colPdName.Name).Value)
                End If

                If IsDBNull(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(PdCode.Name).Value) Then
                    '--Nothing--'
                Else
                    Me.PdCodeS = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(PdCode.Name).Value)
                End If

                If IsDBNull(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPerBox.Name).Value) Then
                    '---nothing---'
                Else
                    Me.PerBox = CInt(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPerBox.Name).Value)
                End If

                Me.Unit = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPkUnitName.Name).Value)
                Me.PriceBill = CDbl(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPriceBill.Name).Value)
                Me.PriveWh = CDbl(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPriceWholesale.Name).Value)
                Me.PriceRetail = CDbl(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(ColPriceRetail.Name).Value)
                Me.idPkUnit = CStr(dgvPd.Rows(dgvPd.CurrentCell.RowIndex).Cells(colidPkUnit.Name).Value)
                Me.DtType = 1 'สินค้าทั่วไป

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End If
    End Sub


    Private Sub DGVPdLot_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPdLot.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGVPdLot.Columns(e.ColumnIndex).Name = ColSelectO.Name Then
            idPdO = CInt(DGVPdLot.Rows(e.RowIndex).Cells(ColidPdO.Name).Value)
            ' Me.PdPkName = CStr(DGVPdLot.Rows(e.RowIndex).Cells(ColTitle.Name).Value)

            Me.DtType = 2 'สินค้าอื่นๆ

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub DGVPdLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVPdLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If DGVPdLot.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If DGVPdLot.Columns(DGVPdLot.CurrentCell.ColumnIndex).Name = ColSelectO.Name Then
                idPdO = CInt(DGVPdLot.Rows(DGVPdLot.CurrentCell.RowIndex).Cells(ColidPdO.Name).Value)
                Me.DtType = 2   ' สินค้าอื่นๆ

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()

            End If
        End If

    End Sub

    Private Sub dgvShowData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvShowData.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvShowData.Columns(e.ColumnIndex).Name = Me.ColSelectM.Name Then
            'If dgvShowData.CurrentRow.Cells("ColAmount").Value = 0 Then
            '    MessageBox.Show("ไม่สามารถเลือกรายการที่มีน้ำหนักคงเหลือเท่ากับ 0 ได้", sSystemName)
            'Else
            idPdLot = dgvShowData.Rows(e.RowIndex).Cells(ColidPdLot.Name).Value
            'Me.PdPkName = CStr(dgvShowData.Rows(e.RowIndex).Cells(ColPdNameM.Name).Value)

            Me.DtType = 3  ' เมล็ดวัตถุดิบ

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            ' End If

        End If

    End Sub

    Private Sub dgvShowData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvShowData.KeyDown
        If e.KeyCode = Keys.Enter Then

            If dgvShowData.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If dgvShowData.Columns(dgvShowData.CurrentCell.ColumnIndex).Name = ColSelectM.Name Then
                If dgvShowData.CurrentRow.Cells("ColAmount").Value = 0 Then
                    MessageBox.Show("ไม่สามารถเลือกรายการที่มีน้ำหนักคงเหลือเท่ากับ 0 ได้", sSystemName)
                Else
                    idPdLot = dgvShowData.Rows(dgvShowData.CurrentCell.RowIndex).Cells(ColidPdLot.Name).Value
                    Me.DtType = 3  ' เมล็ดวัตถุดิบ

                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If

        End If
    End Sub

    Private Sub ChkPlantTypen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPlantTypen.CheckedChanged
        If Me.ChkPlantTypen.Checked = True Then
            Me.cmbPlantType.Enabled = True
            Me.cmbPlantType.Focus()
            Me.chkPdn.Enabled = True
        Else
            Me.cmbPlantType.Enabled = False
            Me.chkPdn.Checked = False
        End If
    End Sub

    Private Sub chkPdn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPdn.CheckedChanged
        If Me.chkPdn.Checked = True Then
            Me.cmbPdNamen.Enabled = True
            Me.cmbPdNamen.Focus()
        Else
            Me.cmbPdNamen.Enabled = False
        End If
    End Sub

    Private Sub cmbPlantType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlantType.SelectedIndexChanged
        BindPdn()
    End Sub

    Private Sub btnShown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShown.Click
        mdLoadShow()
        BindDataMat_n()
        mdLoadCommitt()
    End Sub

    Private Sub DGVPdn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPdn.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGVPdn.Columns(e.ColumnIndex).Name = Me.ColSelectPd.Name Then
            idPdS = DGVPdn.Rows(e.RowIndex).Cells(ColidPdn.Name).Value

            'idPdLot = DGVPdn.Rows(e.RowIndex).Cells(ColidPdn.Name).Value
            'Me.PdPkName = CStr(DGVPdn.Rows(e.RowIndex).Cells(ColPdNamen.Name).Value)

            Me.DtType = 3 'เมล็ดวัตถุดิบ
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub


    Private Sub DGVPdn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVPdn.KeyDown
        If e.KeyCode = Keys.Enter Then

            If DGVPdn.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If DGVPdn.Columns(DGVPdn.CurrentCell.ColumnIndex).Name = ColSelectPd.Name Then
                idPdS = DGVPdn.Rows(DGVPdn.CurrentCell.RowIndex).Cells(ColidPdn.Name).Value
                Me.DtType = 3  ' เมล็ดวัตถุดิบ
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
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

    Private Sub ChkPd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPd.CheckedChanged
        If Me.ChkPd.Checked = True Then
            Me.txtPdName.Enabled = True
            Me.txtPdName.Focus()
        Else
            Me.txtPdName.Enabled = False
        End If
    End Sub

  
    Private Sub ChkPdNameL_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPdNameL.CheckedChanged
        If Me.ChkPdNameL.Checked = True Then
            Me.txtPdNameL.Enabled = True
            Me.txtPdNameL.Focus()
        Else
            Me.txtPdNameL.Enabled = False
        End If
    End Sub


#Region "Pd-OtherComp"
    Private Sub BindPdOtherComp()
        Dim vWHERE As String = ""
        Dim sDt As New DataTable


        If stPdGen = 1 Then 'เฉพาะสินค้าทั่วไป
            vWHERE = vWHERE & " AND p.idType = 0 "
        End If

        If stPack = 1 Then ' เฉพาะผักซอง
            vWHERE = vWHERE & " AND p.idType = 1 "
        End If

        If stFolwer = 1 Then 'เฉพาะดอกไม้ และ ต้องไม่ใช่สินค้าผักซอง
            vWHERE = vWHERE & " AND p.idSeedKind = 2 "
        End If

        If chkPdName_otc.Checked = True Then
            Dim tx As String = txtPd_Otc.Text
            Dim tx_a As String() = tx.Split(" ")
            Dim a_and As String = ""
            Dim strPdPk As String = ""
            If tx_a.Length > 0 Then
                For Each txt As String In tx_a
                    If Not txt.Equals("") Then
                        strPdPk += a_and & "" & String.Format(" PdPkName Like '%{0}%' ", txt)
                    End If
                    a_and = " and "
                Next
            End If

            If strPdPk <> "" Then
                vWHERE = vWHERE & " AND " & strPdPk
            End If
        End If

        If chkLotno_otc.Checked = True Then
            vWHERE = vWHERE & " AND  lot.LotNum = '" & txtLot.Text & "' "
        End If

        mdCnOpen()
        sDt.Clear()
        If sqlLot = 0 Then
            sCommand.CommandText = "Select p.idPdPk, p.PdCode, p.Barcode, p.PdPkName, p.ShortName, p.Weight, p.UnitW, " & _
                                   "p.idUnitW, p.idPkUnit, p.PkUnitName, p.PriceBill, p.PriceWholesale, " & _
                                   "p.PriceRetail, p.PerBox, t.idSeedKind From vPackingPdSet p " & _
                                   "LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT WHERE p.stDel IS NULL AND p.idComp <> " & sIdComp & " " & _
                                   "" & vWHERE & " Order by p.PdPkName"
        Else
            If Me.ChkNolot_Otc.Checked = True Then
                vWHERE = vWHERE & "AND lot.Amount > '0' "
            End If

            sCommand.CommandText = "Select lot.idPdPkLot , lot.LotNum , p.idPdPk, p.PdCode, p.Barcode, p.PdPkName, p.ShortName," & _
                                   "p.Weight, p.UnitW, p.idUnitW, p.idPkUnit, p.PkUnitName, p.PriceBill, p.PriceWholesale, " & _
                                   "p.PriceRetail, p.PerBox, t.idSeedKind, lot.Amount From dPackingPdSetLot lot " & _
                                   "LEFT JOIN vPackingPdSet p ON p.idPdPk = lot.idPdPk " & _
                                    "LEFT OUTER JOIN vSlPdTradeNameD t ON p.idPdT = t.idPdT WHERE p.stDel IS NULL AND p.idComp <> " & sIdComp & " " & _
                                    "" & vWHERE & " Order by p.PdPkName"

        End If

        sAdapter.Fill(sDt)
        DGVOtComp.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
            Exit Sub
        End If

    End Sub

    Private Sub txtPd_Otc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPd_Otc.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindPdOtherComp()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub btnOtc_Click(sender As Object, e As EventArgs) Handles btnOtc.Click
        mdLoadShow()
        BindPdOtherComp()
        mdLoadCommitt()
    End Sub

    Private Sub chkPdName_otc_CheckedChanged(sender As Object, e As EventArgs) Handles chkPdName_otc.CheckedChanged
        If chkPdName_otc.Checked = True Then
            Me.txtPd_Otc.Enabled = True
            Me.txtPd_Otc.Focus()
        Else
            Me.txtPd_Otc.Text = ""
            Me.txtPd_Otc.Enabled = False
        End If
    End Sub

    Private Sub chkLotno_otc_CheckedChanged(sender As Object, e As EventArgs) Handles chkLotno_otc.CheckedChanged
        If Me.chkLotno_otc.Checked = True Then
            Me.txtLotNo_otc.Enabled = True
            Me.txtLotNo_otc.Focus()
        Else
            Me.txtLotNo_otc.Text = ""
            Me.txtLotNo_otc.Enabled = False
        End If
    End Sub

    Private Sub DGVOtComp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOtComp.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGVOtComp.Columns(e.ColumnIndex).Name = ColSelect_otc.Name Then

            idPdPk = CStr(DGVOtComp.Rows(e.RowIndex).Cells(ColidPdPk_otc.Name).Value)

            If Not IsDBNull(DGVOtComp.Rows(e.RowIndex).Cells(ColPdPkName_otc.Name).Value) Then
                Me.PdPkName = CStr(DGVOtComp.Rows(e.RowIndex).Cells(ColPdPkName_otc.Name).Value)
            End If
            If Not IsDBNull(DGVOtComp.Rows(e.RowIndex).Cells(ColPdCode_otc.Name).Value) Then
                Me.PdCodeS = CStr(DGVOtComp.Rows(e.RowIndex).Cells(ColPdCode_otc.Name).Value)
            End If
            If Not IsDBNull(DGVOtComp.Rows(e.RowIndex).Cells(ColPerBox_otc.Name).Value) Then
                Me.PerBox = CInt(DGVOtComp.Rows(e.RowIndex).Cells(ColPerBox_otc.Name).Value)
            End If
            If Not IsDBNull(DGVOtComp.Rows(e.RowIndex).Cells(ColShortName_otc.Name).Value) Then
                ShortName = DGVOtComp.Rows(e.RowIndex).Cells(ColShortName_otc.Name).Value
            End If
            If Not IsDBNull(DGVOtComp.Rows(e.RowIndex).Cells(ColBarCode_otc.Name).Value) Then
                Barcode = DGVOtComp.Rows(e.RowIndex).Cells(ColBarCode_otc.Name).Value
            End If
            If Not IsDBNull(DGVOtComp.Rows(e.RowIndex).Cells(ColPkUnitName_otc.Name).Value) Then
                PkUnitName = DGVOtComp.Rows(e.RowIndex).Cells(ColPkUnitName_otc.Name).Value
            End If

            Me.pidPdPkLot = DGVOtComp.Rows(e.RowIndex).Cells(COlidPdPkLot_otc.Name).Value
            Me.PdPkLotNo = DGVOtComp.Rows(e.RowIndex).Cells(ColLOtNo_otc.Name).Value
            Me.Unit = CStr(DGVOtComp.Rows(e.RowIndex).Cells(ColPkUnitName_otc.Name).Value)
            Me.PriceBill = CDbl(DGVOtComp.Rows(e.RowIndex).Cells(ColPriceBill_otc.Name).Value)
            Me.PriveWh = CDbl(DGVOtComp.Rows(e.RowIndex).Cells(ColPriceWholesale_otc.Name).Value)
            Me.PriceRetail = CDbl(DGVOtComp.Rows(e.RowIndex).Cells(ColPriceRetail_otc.Name).Value)
            Me.idPkUnit = CStr(DGVOtComp.Rows(e.RowIndex).Cells(ColidPkUnit_otc.Name).Value)
            Me.DtType = 1 'สินค้าทั่วไป

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub DGVOtComp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVOtComp.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If DGVOtComp.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If DGVOtComp.Columns(DGVOtComp.CurrentCell.ColumnIndex).Name = ColSelect_otc.Name Then

                idPdPk = CStr(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColidPdPk_otc.Name).Value)

                If Not IsDBNull(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPdPkName_otc.Name).Value) Then
                    Me.PdPkName = CStr(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPdPkName_otc.Name).Value)
                End If
                If Not IsDBNull(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPdCode_otc.Name).Value) Then
                    Me.PdCodeS = CStr(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPdCode_otc.Name).Value)
                End If
                If Not IsDBNull(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPerBox_otc.Name).Value) Then
                    Me.PerBox = CInt(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPerBox_otc.Name).Value)
                End If
                If Not IsDBNull(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColShortName_otc.Name).Value) Then
                    ShortName = DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColShortName_otc.Name).Value
                End If
                If Not IsDBNull(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColBarCode_otc.Name).Value) Then
                    Barcode = DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColBarCode_otc.Name).Value
                End If
                If Not IsDBNull(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPkUnitName_otc.Name).Value) Then
                    PkUnitName = DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPkUnitName_otc.Name).Value
                End If

                Me.pidPdPkLot = DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(COlidPdPkLot_otc.Name).Value
                Me.PdPkLotNo = DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColLOtNo_otc.Name).Value
                Me.Unit = CStr(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPkUnitName_otc.Name).Value)
                Me.PriceBill = CDbl(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPriceBill_otc.Name).Value)
                Me.PriveWh = CDbl(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPriceWholesale_otc.Name).Value)
                Me.PriceRetail = CDbl(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColPriceRetail_otc.Name).Value)
                Me.idPkUnit = CStr(DGVOtComp.Rows(DGVOtComp.CurrentCell.RowIndex).Cells(ColidPkUnit_otc.Name).Value)
                Me.DtType = 1 'สินค้าทั่วไป

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End If
    End Sub
#End Region

#Region "Pd-Hormone"
    Private Sub BindDataHormone()
        Dim sDt As New DataTable
        Dim vWHERE As String = ""

        Dim tx As String = txtHormone.Text
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


        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdO, p.Title, p.Perbox FROM SmPdOtherD p " & _
                                   "LEFT OUTER JOIN SmPdOtherTypeD t ON p.idPdoType = t.idPdoType " & _
                                   "WHERE p.stDel IS NULL AND p.stDel IS NULL " & vWHERE & " AND p.idPdoType = 2 Order by p.Title"
        sAdapter.Fill(sDt)
        DGVHormone.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
            Exit Sub
        End If
    End Sub

    Private Sub btnHormone_Click(sender As Object, e As EventArgs) Handles btnHormone.Click
        mdLoadShow()
        BindDataHormone()
        mdLoadCommitt()
    End Sub

    Private Sub txtHormone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHormone.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindDataHormone()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub DGVHormone_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHormone.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGVHormone.Columns(e.ColumnIndex).Name = ColSelectH.Name Then
            idPdO = CInt(DGVHormone.Rows(e.RowIndex).Cells(ColidPdoH.Name).Value)
            'Me.PdPkName = CStr(DGVHormone.Rows(e.RowIndex).Cells(ColHormoneName.Name).Value)
            Me.DtType = 2  ' สินค้าอื่นๆ

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub DGVHormone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVHormone.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If DGVHormone.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If DGVHormone.Columns(DGVHormone.CurrentCell.ColumnIndex).Name = ColSelectH.Name Then
                idPdO = CInt(DGVHormone.Rows(DGVHormone.CurrentCell.RowIndex).Cells(ColidPdoH.Name).Value)
                Me.DtType = 2  ' สินค้าอื่นๆ

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

#End Region

#Region "Pd-Plastic"

    Private Sub BindDataPlastic()
        Dim sDt As New DataTable
        Dim vWHERE As String = ""

        Dim tx As String = txtPlastic.Text
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

        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "SELECT p.idPdO, p.Title FROM SmPdOtherD p " & _
                                   "LEFT OUTER JOIN SmPdOtherTypeD t ON p.idPdoType = t.idPdoType " & _
                                   "WHERE p.stDel IS NULL AND p.stDel IS NULL " & vWHERE & " AND p.idPdoType = 3 Order by p.Title"
        sAdapter.Fill(sDt)
        DGV_Plastic.DataSource = sDt
        If sDt.Rows.Count = 0 Then
            mdLoadCommitt()
            MessageBox.Show("ไม่พบข้อมูลสินค้า", sSystemName)
            Exit Sub
        End If
    End Sub

    Private Sub btnPlastic_Click(sender As Object, e As EventArgs) Handles btnPlastic.Click
        mdLoadShow()
        BindDataPlastic()
        mdLoadCommitt()
    End Sub

    Private Sub txtPlastic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlastic.KeyDown
        If e.KeyCode = Keys.Enter Then
            mdLoadShow()
            BindDataPlastic()
            mdLoadCommitt()
        End If
    End Sub

    Private Sub DGV_Plastic_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Plastic.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGV_Plastic.Columns(e.ColumnIndex).Name = ColSelect_P.Name Then
            idPdO = CInt(DGV_Plastic.Rows(e.RowIndex).Cells(ColidPdO_P.Name).Value)
            'Me.PdPkName = CStr(DGV_Plastic.Rows(e.RowIndex).Cells(ColPlasticName.Name).Value)

            Me.DtType = 2  ' สินค้าอื่นๆ

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub DGV_Plastic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Plastic.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If DGV_Plastic.CurrentCell.RowIndex < 0 Then
                Exit Sub
            End If

            If DGV_Plastic.Columns(DGV_Plastic.CurrentCell.ColumnIndex).Name = ColSelect_P.Name Then
                idPdO = CInt(DGV_Plastic.Rows(DGV_Plastic.CurrentCell.RowIndex).Cells(ColidPdO_P.Name).Value)
                Me.DtType = 2  ' สินค้าอื่นๆ

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

#End Region





End Class