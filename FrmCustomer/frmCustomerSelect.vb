Public Class frmCustomerSelect
    Public idCus As Integer
    Public CusName As String
    Public idPartner As Integer
    Public idFm As Integer
    Public Address As String

    Public CusNameCon As String
    Public MobileCon As String
    Public CusLevel As String
    Public PriceRet As String
    Public PriceBill As String
    Public PriceWh As String
    Public CusLevelNote As String
    Public idCusType As Integer
    Public pTel As String
    Public idPs As String
    Public AddressS As String
    Public idTsp As Integer
    Public idPayTsp As Integer
    Public idSupTsp As Integer
    Public idRefAdrS As Integer
    Public vPsRecName As String
    Public SupName As String
    Public Note As String
    Public sstASG As Integer
    'Public idPM As Integer
    Public stRight As Integer
    Public stAddress As Integer
    Public idComp As Integer
    Dim Process As eProcess
    'Dim sDtCus2 As New DataTable
    Public sDtCus As New DataTable
    Dim arraylist As New ArrayList
    'Dim vWhere As String = ""
    Dim stPage As String = 0 'สถานะลูกค้าผูกกับ sale
    Dim stLoad As Integer = 0 'สถานะเริ่ม Load Page
    Dim stForeign As Integer = 0 'สถานะลูกค้าต่างประเทศ
    Dim stInASG As Integer = 0 'สถานะลูกค้าที่เป็นบริษัทในเครือ
    Dim stAll As Integer = 0 'สถานะเลือกข้อมูลทั้งหมด
    Public pbPartnerName As String = ""

    Enum eProcess
        eSelect
        eCheckbox
        ePsSale
        eAddressSent
        eForeign
        ePsSaleFrg
        eNotForeign
        ePsSaleNotFrg
        'add new
        eInThaiAndSale
        eFrgAndSale
        eSaleAll
        eCusInASG 'ลูกค้าที่เป็นบริษัทในเครือ
        eCusInASGAndSale 'ลูกค้าที่เป็นบริษัทในเครือผูกติดกับเซลล์
        eSelectAllChkSt 'เลือกลูกค้าทั้งหมด + เช็คสถานะของลูกค้า (Sale & Order)
        eChkSetComp
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal gidComp As Integer, Optional ByVal aOption As Boolean = True)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Select Case aProcess
            Case eProcess.eSelect 'เลือกลูกค้าทั้งหมด
                'dgvCustomer.Columns(colChk.Name).Visible = False
                'dgvCustomer.Columns(colSelect.Name).Visible = True

                ColSelectChk.Visible = False
                colSelect.Visible = True
                stAll = 1
                'Process = eProcess.eSelect
            Case eProcess.eCheckbox
                'dgvCustomer.Columns(colChk.Name).Visible = True
                'dgvCustomer.Columns(colSelect.Name).Visible = False
                ColSelectChk.Visible = True
                colSelect.Visible = False
                RbCusPs.Visible = True
                Rball.Visible = True
                RbCusPs.Checked = True
                'Process = eProcess.eCheckbox
                btn_save.Visible = True
                Panel2.Size = New Size(225, 43)
                Me.Text = "เลือกลูกค้า"
            Case eProcess.ePsSale
                Me.Text = "เลือกลูกค้า"
                Me.Rball.Text = "เลือกลูกค้าทั้งหมด"
                RbCusPs.Visible = True
                Rball.Visible = True
                RbCusPs.Checked = True
                stPage = 1
                'Process = eProcess.ePsSale
            Case eProcess.eAddressSent
                'dgvCustomer.Columns(colChk.Name).Visible = True
                'dgvCustomer.Columns(colCusCon.Name).Visible = True
                'dgvCustomer.Columns(colSelect.Name).Visible = False
                ColSelectChk.Visible = True
                colSelect.Visible = False

                ' Process = eProcess.eAddressSent
                btn_save.Visible = True
                Panel2.Size = New Size(225, 43)
                Me.Text = "เลือกลูกค้า"
            Case eProcess.eForeign 'เลือกลูกค้าต่างประเทศ
                'dgvCustomer.Columns(colChk.Name).Visible = False
                'dgvCustomer.Columns(colSelect.Name).Visible = True
                'dgvCustomer.Columns(ColAp.Name).Visible = False
                'dgvCustomer.Columns(ColPv.Name).Visible = False
                ColSelectChk.Visible = False
                colSelect.Visible = True
                ColAmpher.Visible = False
                ColProvince.Visible = False

                rdbFrgOnly.Visible = True
                rdbFrgOnly.Checked = True
                Rball.Visible = True
                'Process = eProcess.eForeign
                stForeign = 1
                Me.ChkPv.Visible = False
                Me.CmbPv.Visible = False
                'stPage = 2
            Case eProcess.ePsSaleFrg 'เลือกลูกค้าต่างประเทศผูกติด sale
                Me.Text = "เลือกลูกค้า"
                rdbFrgOnly.Text = "เลือกลูกค้าต่างประเทศทั้งหมด"

                ColAmpher.Visible = False
                ColProvince.Visible = False
                rdbFrgSale.Visible = True
                rdbFrgSale.Checked = True
                Rball.Visible = True
                rdbFrgOnly.Visible = True
                stPage = 1
                'Process = eProcess.ePsSaleFrg
                stForeign = 1
                Me.ChkPv.Visible = False
                Me.CmbPv.Visible = False
            Case eProcess.eNotForeign 'เลือกลูกค้าที่ไม่ใช่ลูกค้าต่างประเทศ (ในประเทศทั้งหมด)
                'dgvCustomer.Columns(colChk.Name).Visible = False
                'dgvCustomer.Columns(colSelect.Name).Visible = True
                ColSelectChk.Visible = False
                colSelect.Visible = True

                Rball.Visible = True
                rdbInOnly.Visible = True
                rdbInOnly.Checked = True
                'Process = eProcess.eNotForeign
                stForeign = 2 'ไม่เอาต่างประเทศ
            Case eProcess.ePsSaleNotFrg 'เลือกลูกค้าในประเทศ + ผูกติด sale
                Me.Text = "เลือกลูกค้า"
                Me.Rball.Text = "เลือกลูกค้าทั้งหมด"
                rdbInSale.Visible = True
                rdbInSale.Checked = True
                Rball.Visible = True
                rdbInOnly.Visible = True
                stPage = 1
                'Process = eProcess.ePsSaleNotFrg
                stForeign = 2 'ไม่เอาต่างประเทศ
            Case eProcess.eInThaiAndSale
                'New add
                'dgvCustomer.Columns(Me.ColAp.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                'dgvCustomer.Columns(Me.ColAp.Name).ReadOnly = True
                'dgvCustomer.Columns(Me.ColPv.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                'dgvCustomer.Columns(Me.ColPv.Name).ReadOnly = True
                'dgvCustomer.Columns(Me.Address.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                'dgvCustomer.Columns(Me.Address.Name).ReadOnly = True
                'dgvCustomer.Columns(colChk.Name).Visible = False
                'dgvCustomer.Columns(colSelect.Name).Visible = True

                ColSelectChk.Visible = False
                colSelect.Visible = True


                MaximizeBox = False
                MinimizeBox = True
                btn_save.Visible = False

                'end add
                Me.Text = "เลือกลูกค้า"
                Me.Rball.Text = "เลือกลูกค้าทั้งหมด"
                RbCusPs.Visible = True
                Rball.Visible = True
                RbCusPs.Checked = True
                stPage = 1

                stForeign = 2 'ไม่เอาต่างประเทศ
            Case eProcess.eFrgAndSale
                'New add
                'dgvCustomer.Columns(Me.ColAp.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                'dgvCustomer.Columns(Me.ColAp.Name).ReadOnly = True
                'dgvCustomer.Columns(Me.ColPv.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                'dgvCustomer.Columns(Me.ColPv.Name).ReadOnly = True
                'dgvCustomer.Columns(Me.Address.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                'dgvCustomer.Columns(Me.Address.Name).ReadOnly = True
                'dgvCustomer.Columns(colChk.Name).Visible = False
                'dgvCustomer.Columns(colSelect.Name).Visible = True
                MinimizeBox = True
                MaximizeBox = False
                btn_save.Visible = False
                'end add
                Me.Text = "เลือกลูกค้า"
                Me.Rball.Text = "เลือกลูกค้าต่างประเทศทั้งหมด"
                'dgvCustomer.Columns(ColAp.Name).Visible = False
                'dgvCustomer.Columns(ColPv.Name).Visible = False
                RbCusPs.Visible = True
                Rball.Visible = True
                RbCusPs.Checked = True
                stPage = 1
                ' Process = eProcess.eFrgAndSale
                stForeign = 1
                Me.ChkPv.Visible = False
                Me.CmbPv.Visible = False
            Case eProcess.eSaleAll
                Me.Text = "เลือกลูกค้า"
                Me.Rball.Text = "เลือกลูกค้าทั้งหมด"
                RbCusPs.Visible = True
                Rball.Visible = True
                RbCusPs.Checked = True
                stPage = 1
                ' Process = eProcess.eSaleAll
                'add new
                'dgvCustomer.Columns(Me.ColAp.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                'dgvCustomer.Columns(Me.ColAp.Name).ReadOnly = True
                'dgvCustomer.Columns(Me.ColPv.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                'dgvCustomer.Columns(Me.ColPv.Name).ReadOnly = True
                'dgvCustomer.Columns(Me.Address.Name).DefaultCellStyle.BackColor = Color.Gainsboro
                'dgvCustomer.Columns(Me.Address.Name).ReadOnly = True
                'dgvCustomer.Columns(colChk.Name).Visible = False
                'dgvCustomer.Columns(colSelect.Name).Visible = True
                MaximizeBox = False
                MinimizeBox = True
                btn_save.Visible = False

            Case eProcess.eCusInASG
                Me.Text = "เลือกลูกค้าที่เป็นบริษัทในเครือ"
                'dgvCustomer.Columns(colChk.Name).Visible = False
                'dgvCustomer.Columns(colSelect.Name).Visible = True
                'Process = eProcess.eCusInASG
                stInASG = 1
                Me.ChkPv.Visible = False
                Me.CmbPv.Visible = False
            Case eProcess.eCusInASGAndSale
                Me.Text = "เลือกลูกค้าที่เป็นบริษัทในเครือ"
                RbCusPs.Visible = True
                RbCusPs.Checked = True
                Rball.Visible = True
                Me.Rball.Text = "เลือกลูกค้าที่เป็นบริษัทในเครือทั้งหมด"
                stInASG = 1
                stPage = 1
                Me.ChkPv.Visible = False
                Me.CmbPv.Visible = False
            Case eProcess.eSelectAllChkSt
                'dgvCustomer.Columns(colChk.Name).Visible = False
                'dgvCustomer.Columns(colSelect.Name).Visible = True
                stAll = 1
                'Process = eProcess.eSelectAllChkSt
            Case eProcess.eChkSetComp
                Me.Text = "เลือกลูกค้าที่ผูกกับบริษัท"
                'dgvCustomer.Columns(colChk.Name).Visible = True
        End Select

        Process = aProcess
        idComp = gidComp
        If aOption = False Then
            Rball.Checked = True
            RbCusPs.Visible = False : Rball.Visible = False
        End If
    End Sub

    Private Sub frmCustomerSelect_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        CmbProvinceS()
        If stPage = 1 Then
            'Me.lblPsSale.Text = PsSaleName_
            'Me.lblPsSale.Tag = idPsSale_
            Me.lblPsSale.Visible = True
            Me.lblSale.Visible = True

            mdCnOpen()
            Dim Dt As New DataTable
            Dt.Clear()
            sCommand.CommandText = "Select PsName From vPersonxSelect Where idPs = " & idPs
            sAdapter.Fill(Dt)

            Me.lblPsSale.Text = Dt.Rows(0).Item("PsName")
            BindData()
        Else

            BindData()
        End If

        'If stPage = 1 Then
        '    mdLoadShow()
        '    BindData()
        '    mdLoadCommitt()
        'End If


        Me.CenterToScreen()
        Me.txtCusName.Focus()
        txtCusName.Text = pbPartnerName
    End Sub

    Private Sub CmbProvinceS()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select PvName, idPv From dProvinceFixSale Order By PvName ASC"
        sAdapter.Fill(sDt)
        With CmbPv
            .DisplayMember = "PvName"
            .ValueMember = "idPv"
            .DataSource = sDt
        End With
    End Sub

    Sub BindData()

        mdCnOpen()
        mdLoadShow()

        Dim sDt As New DataTable
        sDt.Clear()
        Dim vWhere As String = ""

        If stForeign = 1 And (Me.rdbFrgOnly.Checked = True Or Me.rdbFrgSale.Checked = True) Then
            vWhere = vWhere & " AND d.stAddress = 4 "
        ElseIf stForeign = 2 And (Me.rdbInOnly.Checked = True Or Me.rdbInSale.Checked = True) Then 'Other
            vWhere = vWhere & " AND (d.stAddress <> 4 OR d.stAddress Is Null) "
        End If

        Dim chkComp As New DataTable
        sCommand.CommandText = "SELECT parentid FROM PchInvAndProject.devsk.dGroupCompMap WHERE idComp = " & idComp & " AND stActive = 1"
        sAdapter.Fill(chkComp)

      

        If RbCusPs.Checked = True Or Me.rdbFrgSale.Checked = True Or Me.rdbInSale.Checked = True Then
            If chkComp.Rows(0).Item("parentid") = 1 Then ' AV GROUP
                vWhere = vWhere & " AND p.idCus Is Not NULL AND ds.idComp = " & idComp
            Else
                vWhere = vWhere & " AND (p.idCus Is Not NULL AND ds.idComp = " & idComp & " Or p.idFm Is Not NULL)"
            End If

            sCommand.CommandText = "SELECT p.idPartner,IsNULL(p.idFm,0) As idFm, IsNull(p.idCus,0) As idCus, p.PartnerName As CusName_, ISNULL(p.pNote,'') As Note,   " & vbNewLine &
                                   "ISNULL(ap.ApName, '-') As ApName ,ISNULL(pv.PvName, '-') As PvName, IsNULL(p.pAddress,'') As Address, d.CusNameCon As CusNameCon_, t.idCusType, t.CusType, t.PriceRetail, d.stRight, " & vbNewLine &
                                   "t.PriceBill, t.PriceWholeSale,  ISNULL(se.AddressS, p.pAddress ) As AddressS, d.Tel, se.idTsp AS idTspS, d.stRight, d.stAddress,  " & vbNewLine &
                                   "d.idPsAccept, d.idPsCheck, d.idPsApprove, se.idSupTsp AS idSupTspS , se.idPayTsp AS idPayTspS, " & vbNewLine &
                                   "sup.SupName AS SupNameS, d.idRefAdrS, IsNULL(d.stActive,0) As stActive, se.PsRecName, t.Note As NoteCus,IsNULL(d.idComp, 0) As stASG" & vbNewLine &
                                   "FROM dPartner As p " & vbNewLine &
                                   "LEFT JOIN SmMkCusPs AS ps ON p.idCus = ps.idCus AND ps.idComp = " & idComp & vbNewLine &
                                   "LEFT JOIN SmRegionPsSaleSet s ON ps.idRegionC = s.idRegion" & vbNewLine &
                                   "LEFT JOIN dPsSalecompSet ds  ON s.idPsComSet = ds.idPsComSet" & vbNewLine &
                                   "LEFT JOIN dCustomer AS d ON ps.idCus = d.idCus AND ps.idComp = " & idComp & vbNewLine &
                                   "LEFT JOIN dCusType AS t ON d.idCusType = t.idCusType" & vbNewLine &
                                   "LEFT JOIN dProvinceFixSale As Pv ON d.idPv = Pv.idPv  " & vbNewLine &
                                   "LEFT JOIN dAp As Ap ON d.idAp = Ap.idAp " & vbNewLine &
                                   "LEFT JOIN dCustomerAdrSent As se ON d.idRefAdrS = se.idCusRefAddr" & vbNewLine &
                                   "LEFT JOIN PchInvAndProject.dbo.dSupplier As sup ON se.idSupTsp = sup.idSup" & vbNewLine &
                                   "WHERE p.stDel Is NULL" & vbNewLine &
                                   vWhere & vbNewLine &
                                   "AND (ds.idPsSale = " & idPs & ")" & vbNewLine &
                                   "ORDER BY p.PartnerName"


        ElseIf Rball.Checked = True Then

            If chkComp.Rows(0).Item("parentid") = 1 Then ' AV GROUP
                vWhere = vWhere & " AND p.idCus Is Not NULL AND ps.idComp = " & idComp
            Else
                vWhere = vWhere & " AND (p.idCus Is Not NULL AND ps.idComp = " & idComp & " Or p.idFm Is Not NULL)"
            End If

            sCommand.CommandText = "SELECT p.idPartner, IsNULL(p.idFm,0) As idFm, IsNull(p.idCus,0) As idCus, p.PartnerName As CusName_, ISNULL(p.pNote,'') As Note,   " & vbNewLine & _
                                   "ISNULL(ap.ApName, '-') As ApName ,ISNULL(pv.PvName, '-') As PvName, IsNULL(p.pAddress,'') As Address, d.CusNameCon, p.pTel, t.idCusType, t.CusType, t.PriceRetail, d.stRight, " & vbNewLine & _
                                   "t.PriceBill, t.PriceWholeSale, ISNULL(se.AddressS, p.pAddress ) As AddressS, d.Tel, se.idTsp AS idTspS, d.stRight,  " & vbNewLine & _
                                   "d.stAddress, d.idComp, d.idPsAccept, d.idPsCheck, d.idPsApprove, se.idSupTsp AS idSupTspS, IsNULL(d.idComp, 0) As stASG,  " & vbNewLine & _
                                   "se.idPayTsp AS idPayTspS,  sup.SupName AS SupNameS, d.idRefAdrS, IsNULL(d.stActive,0) As stActive, se.PsRecName, t.Note As NoteCus, " & vbNewLine & _
                                   "IsNULL(d.idComp, 0) As stASG  " & vbNewLine & _
                                   "From dPartner As p " & vbNewLine & _
                                   "LEFT JOIN dCustomer As d ON p.idCus = d.idCus" & vbNewLine & _
                                   "LEFT JOIN dCusType As t ON d.idCusType = t.idCusType " & vbNewLine & _
                                   "LEFT JOIN dProvinceFixSale As Pv ON d.idPv = Pv.idPv  " & vbNewLine & _
                                   "LEFT JOIN dAp As Ap ON d.idAp = Ap.idAp " & vbNewLine & _
                                   "LEFT JOIN dCustomerAdrSent As se ON d.idRefAdrS = se.idCusRefAddr" & vbNewLine & _
                                   "LEFT JOIN PchInvAndProject.dbo.dSupplier As sup ON se.idSupTsp = sup.idSup" & vbNewLine & _
                                   "LEFT JOIN SmMkCusPs As ps ON d.idCus = ps.idCus AND ps.idComp = " & idComp & vbNewLine & _
                                   "WHERE p.stDel Is NULL" & vbNewLine & _
                                   vWhere & vbNewLine & _
                                   "ORDER BY p.PartnerName"
        Else

            If chkComp.Rows(0).Item("parentid") = 1 Then ' AV GROUP
                vWhere = vWhere & " AND p.idCus Is Not NULL AND ps.idComp = " & idComp
            Else
                vWhere = vWhere & " AND (p.idCus Is Not NULL AND ps.idComp = " & idComp & " Or p.idFm Is Not NULL)"
            End If

            sCommand.CommandText = " Select p.idPartner, IsNull(p.idCus,0) As idCus, IsNULL(p.idFm,0) As idFm, p.PartnerName As CusName_, ISNULL(p.pNote,'') As Note," & vbNewLine & _
                                    "ISNULL(ap.ApName, '-') As ApName, ISNULL(pv.PvName, '-') As PvName, IsNULL(p.pAddress, '') As Address , d.stRight," & vbNewLine & _
                                    "ISNULL(se.AddressS, p.pAddress ) As AddressS, se.PsRecName, p.pTel,d.Tel, t.idCusType, t.CusType, t.PriceRetail, t.PriceBill, t.PriceWholeSale, " & vbNewLine & _
                                    "d.stRight, d.stAddress, d.idComp, d.idPsAccept, d.idPsCheck, IsNULL(d.stActive,0) As stActive,d.idRefAdrS, " & vbNewLine & _
                                    "d.idPsApprove,  t.Note As NoteCus, IsNULL(d.stActive,0) As stActive, se.idTsp AS idTspS, se.idPayTsp AS idPayTspS, IsNULL(d.idComp, 0) As stASG, " & vbNewLine & _
                                    "se.idSupTsp AS idSupTspS, sup.SupName AS SupNameS" & vbNewLine & _
                                    "From dPartner As p" & vbNewLine & _
                                    "LEFT JOIN dCustomer As d ON p.idCus = d.idCus" & vbNewLine & _
                                    "LEFT JOIN dAp As ap ON p.pidAp = ap.idAp  " & vbNewLine & _
                                    "LEFT JOIN dCusType As t ON d.idCusType = t.idCusType " & vbNewLine & _
                                    "LEFT JOIN dProvinceFixSale As pv ON d.idPv = pv.idPv " & vbNewLine & _
                                    "LEFT JOIN dCustomerAdrSent As se ON d.idRefAdrS = se.idCusRefAddr " & vbNewLine & _
                                    "LEFT JOIN PchInvAndProject.dbo.dSupplier As sup ON se.idSupTsp = sup.idSup" & vbNewLine & _
                                    "LEFT JOIN SmMkCusPs As ps ON d.idCus = ps.idCus AND ps.idComp = " & idComp & vbNewLine & _
                                    "Where p.stDel Is NULL" & vbNewLine & _
                                    vWhere & vbNewLine & _
                                    "ORDER BY p.PartnerName" & vbNewLine
            '                       "LEFT JOIN dFarmer As fm ON p.idFm = fm.idFm " & vbNewLine & _
        End If

        sAdapter.Fill(sDt)

        GC_Customer.DataSource = sDt
        stLoad = 1
        If sDt.Rows.Count = 0 Then
            If stLoad = 1 Then
                mdLoadCommitt()
                MessageBox.Show("ไม่พบข้อมูลลูกค้า", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        'Select Case Process
        '    Case eProcess.eSelect
        '        'none
        '    Case eProcess.eCheckbox
        '        Dim searchedValue As String
        '        Dim searchedValue2 As String

        '        mdCnOpen()
        '        For i As Integer = 0 To dgvCustomer.Rows.Count - 1
        '            searchedValue = dgvCustomer.Rows(i).Cells(Cusid.Name).Value
        '            For j As Integer = 0 To arraylist.Count - 1
        '                searchedValue2 = arraylist(j)
        '                If searchedValue2 = searchedValue Then
        '                    dgvCustomer.Rows(i).Cells(colChk.Name).Value = True
        '                End If
        '            Next
        '        Next

        '        For i As Integer = 0 To dgvCustomer.Rows.Count - 1
        '            searchedValue = dgvCustomer.Rows(i).Cells(Cusid.Name).Value
        '            For j As Integer = 0 To sDtCus.Rows.Count - 1
        '                searchedValue2 = sDtCus.Rows(j).Item("idCus")
        '                If searchedValue2 = searchedValue Then
        '                    dgvCustomer.Rows(i).Cells(colChk.Name).Value = True
        '                    dgvCustomer.Rows(i).Cells(flag.Name).Value = 1
        '                End If
        '            Next
        '        Next

        '    Case eProcess.eAddressSent
        '        Dim searchedValue As String
        '        Dim searchedValue2 As String
        '        mdCnOpen()
        '        For i As Integer = 0 To dgvCustomer.Rows.Count - 1
        '            searchedValue = dgvCustomer.Rows(i).Cells(Cusid.Name).Value
        '            For j As Integer = 0 To arraylist.Count - 1
        '                searchedValue2 = arraylist(j)
        '                If searchedValue2 = searchedValue Then
        '                    dgvCustomer.Rows(i).Cells(colChk.Name).Value = True
        '                End If
        '            Next
        '        Next

        '        For i As Integer = 0 To dgvCustomer.Rows.Count - 1
        '            searchedValue = dgvCustomer.Rows(i).Cells(Cusid.Name).Value
        '            For j As Integer = 0 To sDtCus.Rows.Count - 1
        '                searchedValue2 = sDtCus.Rows(j).Item("idCus")
        '                If searchedValue2 = searchedValue Then
        '                    dgvCustomer.Rows(i).Cells(colChk.Name).Value = True
        '                    dgvCustomer.Rows(i).Cells(flag.Name).Value = 1
        '                End If
        '            Next
        '        Next
        'End Select
        SumTotal()
        mdLoadCommitt()
    End Sub

    Private Sub txtCusName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub

    Private Sub txtTel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTel.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindData()
        End If
    End Sub


    Public Sub Get_DataChkBox(ByVal sDt As DataTable)
        sDtCus = sDt
        For i As Integer = 0 To sDtCus.Rows.Count - 1
            arraylist.Add(sDtCus.Rows(i).Item("idCus"))
        Next
    End Sub

    Private Sub btnShowdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowdata.Click

        BindData()
    End Sub

    Private Sub Rball_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rball.CheckedChanged
        If Me.Rball.Checked = True Then
            Me.lblPsSale.Visible = False
            Me.lblSale.Visible = False
        Else
            Me.lblPsSale.Visible = True
            Me.lblSale.Visible = True
        End If

        If stLoad = 1 Then
            fnSearchONGrid()
        End If
    End Sub

    Private Sub rdbInOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbInOnly.CheckedChanged
        If Me.rdbInOnly.Checked = True Then
            Me.lblPsSale.Visible = False
            Me.lblSale.Visible = False
        Else
            Me.lblPsSale.Visible = True
            Me.lblSale.Visible = True
        End If

        If stLoad = 1 Then
            fnSearchONGrid()
        End If
    End Sub

    Private Sub rdbFrgOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbFrgOnly.CheckedChanged
        If Me.rdbFrgOnly.Checked = True Then
            Me.lblPsSale.Visible = False
            Me.lblSale.Visible = False
        Else
            Me.lblPsSale.Visible = True
            Me.lblSale.Visible = True
        End If

        If stLoad = 1 Then
            fnSearchONGrid()
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Select Case Process
            Case eProcess.eSelect
                'none
            Case eProcess.eCheckbox
                Dim sDt_temp As New DataTable
                Dim ans As Integer = 0
                Dim noDups As New ArrayList()
                Dim searchedValue As String
                Dim searchedValue2 As String
                sDtCus.Clear()
                mdCnOpen()
                sCommand.CommandText = "SELECT idCus, CusName_, Address FROM vCustomer"
                sAdapter.Fill(sDt_temp)
                'For i As Integer = 0 To noDups.Count - 1
                '    MessageBox.Show(noDups(i))
                'Next
                For i As Integer = 0 To arraylist.Count - 1
                    searchedValue = arraylist(i).ToString
                    For j As Integer = 0 To sDt_temp.Rows.Count - 1
                        searchedValue2 = sDt_temp.Rows(j).Item("idCus")
                        If searchedValue = searchedValue2 Then
                            sDtCus.Rows.Add(sDt_temp.Rows(j).Item("CusName_"), sDt_temp.Rows(j).Item("Address"), sDt_temp.Rows(j).Item("idCus"))
                        End If
                    Next
                Next
            Case eProcess.ePsSale
                'none
            Case eProcess.eAddressSent
                Dim sDt_temp As New DataTable
                Dim ans As Integer = 0
                Dim noDups As New ArrayList()
                Dim searchedValue As String
                Dim searchedValue2 As String
                sDtCus.Clear()
                mdCnOpen()
                sCommand.CommandText = "SELECT v.idCus, v.CusName_, Ap.ApName, Pv.PvName, v.CusNameCon_, v.Address " & _
                                       "FROM vCustomer v INNER JOIN dProvinceFixSale Pv ON v.idPv = Pv.idPv " & _
                                       "INNER JOIN dAp Ap ON v.idAp=Ap.idAp"
                sAdapter.Fill(sDt_temp)

                For i As Integer = 0 To arraylist.Count - 1
                    searchedValue = arraylist(i).ToString
                    For j As Integer = 0 To sDt_temp.Rows.Count - 1
                        searchedValue2 = sDt_temp.Rows(j).Item("idCus")
                        If searchedValue = searchedValue2 Then
                            sDtCus.Rows.Add(sDt_temp.Rows(j).Item("CusName_"), sDt_temp.Rows(j).Item("ApName"), sDt_temp.Rows(j).Item("PvName"), sDt_temp.Rows(j).Item("CusNameCon_"), sDt_temp.Rows(j).Item("Address"), sDt_temp.Rows(j).Item("idCus"))
                        End If
                    Next
                Next
        End Select

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Sub SumTotal()
        Me.txtCount.Text = Format(GV_Customer.RowCount, "#,##0")
    End Sub

    Private Sub ChkCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCus.CheckedChanged
        If Me.ChkCus.Checked = True Then
            Me.txtCusName.Enabled = True
            Me.txtCusName.Focus()
        Else
            Me.txtCusName.Enabled = False
            txtCusName.Text = ""
        End If
    End Sub

    Private Sub ChkTel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTel.CheckedChanged
        If Me.ChkTel.Checked = True Then
            Me.txtTel.Enabled = True
            Me.txtTel.Focus()
        Else
            Me.txtTel.Enabled = False
        End If
    End Sub

    Private Sub ChkPv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPv.CheckedChanged
        If Me.ChkPv.Checked = True Then
            Me.CmbPv.Enabled = True
            Me.CmbPv.Focus()
        Else
            Me.CmbPv.Enabled = False
        End If
    End Sub


    Private Sub rpsSelect_Click(sender As Object, e As EventArgs) Handles rpsSelect.Click

        fnSetData()
    End Sub


    Sub fnSetData()
        idFm = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idFm")
        idCus = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idCus")
        idPartner = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idPartner")
        CusName = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("CusName_")
        Address = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("Address")

        If GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("stActive") = 1 Then ' Not Active
            MessageBox.Show("ลูกค้ารายนี้ อยู่ในสถานะไม่ Active " & vbCrLf & "จึงไม่สามารถเลือกมาทำรายการได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If idCus <> 0 Then
            If IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idPsAccept")) Or _
               IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idPsCheck")) Or _
               IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idPsApprove")) Then
                MessageBox.Show("ข้อมูลลูกค้า ยังไม่ผ่านการกระบวนการรับทราบ ตรวจสอบ อนุมัติ " & vbCrLf & "จึงไม่สามารถเลือกมาทำรายการได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        '    CusNameCon = CStr(dgvCustomer.Rows(e.RowIndex).Cells(colCusCon.Name).Value)
        '    MobileCon = CStr(dgvCustomer.Rows(e.RowIndex).Cells(colTelCon.Name).Value)
        '    idCusType = CInt(dgvCustomer.Rows(e.RowIndex).Cells(ColidCusType.Name).Value)
        '    CusLevel = CStr(dgvCustomer.Rows(e.RowIndex).Cells(ColCuslevel.Name).Value)

        If Not IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idTspS")) Then
            idTsp = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idTspS")
        End If


        If Not IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idPayTspS")) Then
            idPayTsp = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idPayTspS")
        Else
            idPayTsp = 1
        End If

        If Not IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idSupTspS")) Then
            If GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idSupTspS") <> 0 Then
                idSupTsp = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idSupTspS")
                SupName = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("SupNameS")
            End If
        End If

        Note = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("Note")

        sstASG = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("stASG")

        '    If IsDBNull(dgvCustomer.Rows(e.RowIndex).Cells(ColidComp.Name).Value) Then
        '        idComp = 0
        '    Else
        '        idComp = CInt(dgvCustomer.Rows(e.RowIndex).Cells(ColidComp.Name).Value)
        '    End If

        If IsDBNull((GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("stAddress"))) Then
            stAddress = 0
        Else
            stAddress = CInt((GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("stAddress")))
        End If


        If IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("stRight")) Then
            stRight = 2
        Else
            stRight = CInt(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("stRight"))
        End If


        '    If IsDBNull(dgvCustomer.Rows(e.RowIndex).Cells(Tel.Name).Value) Then
        '        pTel = ""
        '    Else
        '        pTel = dgvCustomer.Rows(e.RowIndex).Cells(Tel.Name).Value
        '    End If
        '    If IsDBNull(dgvCustomer.Rows(e.RowIndex).Cells(ColNoteCus.Name).Value) Then
        '        CusLevelNote = "-"
        '    Else
        '        CusLevelNote = CStr(dgvCustomer.Rows(e.RowIndex).Cells(ColNoteCus.Name).Value)
        '    End If

        '    If IsDBNull(dgvCustomer.Rows(e.RowIndex).Cells(ColRetail.Name).Value) Then
        '        PriceRet = "0.00"
        '    Else
        '        PriceRet = CStr(dgvCustomer.Rows(e.RowIndex).Cells(ColRetail.Name).Value)
        '    End If

        '    If IsDBNull(dgvCustomer.Rows(e.RowIndex).Cells(ColBill.Name).Value) Then
        '        PriceBill = "0.00"
        '    Else
        '        PriceBill = CStr(dgvCustomer.Rows(e.RowIndex).Cells(ColBill.Name).Value)
        '    End If

        '    If IsDBNull(dgvCustomer.Rows(e.RowIndex).Cells(ColWhole.Name).Value) Then
        '        PriceWh = "0.00"
        '    Else
        '        PriceWh = CStr(dgvCustomer.Rows(e.RowIndex).Cells(ColWhole.Name).Value)
        '    End If


        If IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idRefAdrS")) Then
            idRefAdrS = 0
            AddressS = ""
        Else
            idRefAdrS = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idRefAdrS")
            AddressS = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("AddressS")
        End If

        If Not IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("PsRecName")) Then
            vPsRecName = GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("PsRecName")
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'End If
    End Sub
    Private Sub txtCusName_TextChanged(sender As Object, e As EventArgs) Handles txtCusName.TextChanged, txtTel.TextChanged, CmbPv.TextChanged
        If stLoad = 1 Then
            fnSearchONGrid()
        End If
    End Sub

    Private Sub rdbInSale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbInSale.CheckedChanged
        If stLoad = 1 Then
            BindData()
        End If
    End Sub

    Private Sub fnSearchONGrid()
        Dim StrFilter As String = ""

        If Me.ChkCus.Checked = True Then
            StrFilter &= " AND [CusName_] like '%" & Trim(txtCusName.Text) & "%'"
        End If

        If Me.ChkTel.Checked = True Then
            StrFilter &= " AND [Tel] like '%" & Trim(txtTel.Text) & "%'"
        End If

        If ChkPv.Checked = True Then
            StrFilter &= " AND [PvName] like '%" & Trim(CmbPv.Text) & "%'"
        End If

        If (Me.rdbInOnly.Checked = True Or Me.rdbInSale.Checked = True) Then
            StrFilter &= " AND (stAddress <> 4 OR stAddress Is Null)"
        End If

        If (Me.rdbFrgOnly.Checked = True Or Me.rdbFrgSale.Checked = True) Then
            StrFilter &= " AND (stAddress = 4) "
        End If

        'If stForeign = 1 And (Me.rdbFrgOnly.Checked = True Or Me.rdbFrgSale.Checked = True) Then
        '    vWhere = vWhere & " AND d.stAddress = 4 "
        'ElseIf stForeign = 2 And (Me.rdbInOnly.Checked = True Or Me.rdbInSale.Checked = True) Then 'Other
        '    vWhere = vWhere & " AND (d.stAddress <> 4 OR d.stAddress Is Null) "
        'End If

        GV_Customer.ActiveFilterString = " 1=1" + StrFilter
        Me.txtCount.Text = Format(GV_Customer.DataRowCount, "#,##0")
        GV_Customer.ExpandAllGroups()

    End Sub

    Private Sub GV_Customer_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV_Customer.RowCellStyle
        Dim stActive As String = GV_Customer.GetRowCellValue(e.RowHandle, "stActive")

        If stActive = 1 Then
            e.Appearance.BackColor = Color.LightPink
        End If
    End Sub

    
    Private Sub rptChkEdit_Click(sender As Object, e As EventArgs) Handles rptChkEdit.Click

            If IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idPsAccept")) Or _
             IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idPsCheck")) Or _
             IsDBNull(GV_Customer.GetDataRow(GV_Customer.FocusedRowHandle).Item("idPsApprove")) Then
                MessageBox.Show("ข้อมูลลูกค้า ยังไม่ผ่านการกระบวนการรับทราบ ตรวจสอบ อนุมัติ " & vbCrLf & "จึงไม่สามารถเลือกมาทำรายการได้", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
    End Sub

    Private Sub GV_Customer_KeyDown(sender As Object, e As KeyEventArgs) Handles GV_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            fnSetData()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCustomerSelect_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtCusName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCusName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 91 ' [
                e.Handled = True
            Case 93 ' ]
                e.Handled = True
            Case Else
                e.Handled = False
                Exit Select
        End Select
    End Sub
End Class