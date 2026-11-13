Public Class frmCusAdsSentDetail
    Dim Result As DialogResult
    Dim idRef As String
    Dim stPage As Integer = 0
    Dim stAdr As Integer = 0
    'Dim stFrom As String
    Dim NumS As String = ""
    Dim Village As String = ""
    Dim Building As String = ""
    Dim Floor As String = ""
    Dim Room As String = ""
    Dim Soi As String = ""
    Dim Mhoo As String = ""
    Dim Road As String = ""
    Dim AddressADD As String = ""
    Dim Tb As String = ""
    Dim Ap As String = ""
    Dim Pv As String = ""
    'Dim PostCode As String = ""
    Dim idCus As Integer 'Delete

    Dim eEvent As eProcess

    Enum eProcess
        eAddNew
        eEdit
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal idCusRefAddr As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.eAddNew
                stPage = 1
                Me.btnDelete.Visible = False
            Case eProcess.eEdit
                stPage = 2
                Me.btnCustomer.Visible = False
        End Select
        idRef = idCusRefAddr
        eEvent = aProcess
    End Sub


    Private Sub frmCusAdsSentDetail_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim idTbS As String = ""
        Dim idPvS As String = "'"
        Dim idApS As String = "'"

        If stPage = 1 Then 'New
            CmbProvinceS()

        Else 'Edit
            mdCnOpen()

            '----Show from dCustomerAdrSent ---'
            Dim vDt As New DataTable
            vDt.Rows.Clear()
            sCommand.CommandText = "SELECT s.idCus, c.CusName_, s.AddressS, s.AddressSK, s.AdNumS, s.AdVillageS, s.AdBuildingS, s.AdFloorS, s.AdRoomS, " & _
                                   "s.AdSoiS, s.AdMhooS, s.AdRoadS, s.idPvS, s.idApS, s.idTbS, s.stFromS, p.Psname As PsUpdate, " & _
                                   "s.DateUpdate, s.stAddress FROM dCustomerAdrSent s LEFT OUTER JOIN vCustomer c ON s.idCus = c.idCus " & _
                                   "LEFT OUTER JOIN vPerson p ON s.idPsUpdate = p.idPs WHERE s.idCusRefAddr = " & idRef
            sAdapter.Fill(vDt)

            idCus = vDt.Rows(0).Item("idCus")
            '----Show Address from vCustomer ---'
            Dim aDt As New DataTable
            aDt.Rows.Clear()
            sCommand.CommandText = "SELECT Address FROM vCustomer WHERE idCus = " & idCus
            sAdapter.Fill(aDt)
            '****AddrSent same Addr****'
            If IsDBNull(aDt.Rows(0).Item("Address")) Then
                Me.txtAddress.Text = ""
            ElseIf Trim(aDt.Rows(0).Item("Address")) = "" Then
                Me.txtAddress.Text = ""
            Else
                'มีที่อยู่ปัจจุบัน (Address)
                Me.txtAddress.Text = Trim(aDt.Rows(0).Item("Address"))
            End If
            Me.txtCusName.Text = vDt.Rows(0).Item("CusName_")

            If vDt.Rows(0).Item("stFromS") = 1 Then
                Me.ChkSame.Checked = True
                If Trim(vDt.Rows(0).Item("AddressS")) = "" Then
                    If Not IsDBNull(vDt.Rows(0).Item("stAddress")) Then
                        'เป็นที่อยู่ต่างประเทศ
                        Me.rdbExp.Checked = True
                        Me.txtForeign.Text = ""

                        'Me.txtForeign.Enabled = True
                        'Me.txtNumS.Enabled = False
                        'Me.txtVillage.Enabled = False
                        'Me.txtbuilding.Enabled = False
                        'Me.txtFloor.Enabled = False
                        'Me.txtRoad.Enabled = False
                        'Me.txtSoi.Enabled = False
                        'Me.txtMhooS.Enabled = False
                        'Me.txtRoad.Enabled = False
                        'Me.txtRoom.Enabled = False
                        'Me.CmbProvince.Enabled = False
                        'Me.CmbAp.Enabled = False
                        'Me.CmbTb.Enabled = False
                        'Me.txtCode.Enabled = False
                    Else
                        Me.rdbinThai.Checked = True
                        txtAddressAdd.Text = ""
                        CmbProvinceS()
                    End If
                Else
                    'มีข้อมูลที่อยู่จัดส่ง (AddressS)
                    If Not IsDBNull(vDt.Rows(0).Item("stAddress")) Then
                        'เป็นที่อยู่ต่างประเทศ
                        Me.rdbExp.Checked = True
                        Me.txtForeign.Text = Trim(vDt.Rows(0).Item("AddressSK"))
                        Me.txtAddressAdd.Text = Trim(Me.txtForeign.Text)

                        'Me.txtForeign.Enabled = True
                        'Me.txtNumS.Enabled = False
                        'Me.txtVillage.Enabled = False
                        'Me.txtbuilding.Enabled = False
                        'Me.txtFloor.Enabled = False
                        'Me.txtRoad.Enabled = False
                        'Me.txtSoi.Enabled = False
                        'Me.txtMhooS.Enabled = False
                        'Me.txtRoad.Enabled = False
                        'Me.txtRoom.Enabled = False
                        'Me.CmbProvince.Enabled = False
                        'Me.CmbAp.Enabled = False
                        'Me.CmbTb.Enabled = False
                        'Me.txtCode.Enabled = False
                    Else
                        'เป็นที่อยู่ในประเทศ
                        Me.rdbinThai.Checked = True
                        If Not IsDBNull(vDt.Rows(0).Item("AdNumS")) Then
                            If Trim(vDt.Rows(0).Item("AdNumS")) <> "" Then
                                Me.txtNumS.Text = Trim(vDt.Rows(0).Item("AdNumS"))
                                NumS = " " & Trim(vDt.Rows(0).Item("AdNumS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdVillageS")) Then
                            If Trim(vDt.Rows(0).Item("AdVillageS")) <> "" Then
                                Me.txtVillage.Text = Trim(vDt.Rows(0).Item("AdVillageS"))
                                Village = "หมู่บ้าน " & Trim(vDt.Rows(0).Item("AdVillageS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdBuildingS")) Then
                            If Trim(vDt.Rows(0).Item("AdBuildingS")) <> "" Then
                                Me.txtbuilding.Text = Trim(vDt.Rows(0).Item("AdBuildingS"))
                                Building = "อาคาร " & Trim(vDt.Rows(0).Item("AdBuildingS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdFloorS")) Then
                            If Trim(vDt.Rows(0).Item("AdFloorS")) <> "" Then
                                Me.txtFloor.Text = Trim(vDt.Rows(0).Item("AdFloorS"))
                                Floor = " ชั้น " & Trim(vDt.Rows(0).Item("AdFloorS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdRoomS")) Then
                            If Trim(vDt.Rows(0).Item("AdRoomS")) <> "" Then
                                Me.txtRoom.Text = Trim(vDt.Rows(0).Item("AdRoomS"))
                                Room = " ห้อง " & Trim(vDt.Rows(0).Item("AdRoomS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdSoiS")) Then
                            If Trim(vDt.Rows(0).Item("AdSoiS")) <> "" Then
                                Me.txtSoi.Text = Trim(vDt.Rows(0).Item("AdSoiS"))
                                Soi = " ซอย " & Trim(vDt.Rows(0).Item("AdSoiS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdMhooS")) Then
                            If Trim(vDt.Rows(0).Item("AdMhooS")) <> "" Then
                                Me.txtMhooS.Text = Trim(vDt.Rows(0).Item("AdMhooS"))
                                Mhoo = " หมู่ " & Trim(vDt.Rows(0).Item("AdMhooS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdRoadS")) Then
                            If Trim(vDt.Rows(0).Item("AdRoadS")) <> "" Then
                                Me.txtRoad.Text = Trim(vDt.Rows(0).Item("AdRoadS"))
                                Road = " ถนน " & Trim(vDt.Rows(0).Item("AdRoadS"))
                            End If
                        End If

                        CmbProvinceS()
                        If Not IsDBNull(vDt.Rows(0).Item("idPvS")) Then
                            If Trim(vDt.Rows(0).Item("idPvS")) <> "" Then
                                CmbProvince.SelectedValue = Trim(vDt.Rows(0).Item("idPvS"))
                                Pv = " จ." & Me.CmbProvince.Text
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("idApS")) Then
                            If Trim(vDt.Rows(0).Item("idApS")) <> "" Then
                                Me.CmbAp.SelectedValue = Trim(vDt.Rows(0).Item("idApS"))
                                If vDt.Rows(0).Item("idPvS") = 1 Then
                                    Ap = Me.CmbAp.Text
                                Else
                                    Ap = " อ." & Me.CmbAp.Text
                                End If

                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("idTbS")) Then
                            If Trim(vDt.Rows(0).Item("idTbS")) <> "" Then
                                Me.CmbTb.SelectedValue = Trim(vDt.Rows(0).Item("idTbS"))
                                If vDt.Rows(0).Item("idPvS") = 1 Then
                                    Tb = " แขวง " & Me.CmbTb.Text
                                Else
                                    Tb = " ต." & Me.CmbTb.Text
                                End If

                            End If
                        End If


                        If Building <> "" Then
                            AddressADD = AddressADD & Building
                        End If
                        If Floor <> "" Then
                            AddressADD = AddressADD & Floor
                        End If
                        If Room <> "" Then
                            AddressADD = AddressADD & Room
                        End If
                        If Village <> "" Then
                            AddressADD = AddressADD & Village
                        End If
                        If NumS <> "" Then
                            AddressADD = AddressADD & NumS
                        End If
                        If Mhoo <> "" Then
                            AddressADD = AddressADD & Mhoo
                        End If
                        If Soi <> "" Then
                            AddressADD = AddressADD & Soi
                        End If
                        If Road <> "" Then
                            AddressADD = AddressADD & Road
                        End If
                        If Tb <> "" Then
                            AddressADD = AddressADD & Tb
                        End If
                        If Ap <> "" Then
                            AddressADD = AddressADD & Ap
                        End If
                        If Pv <> "" Then
                            AddressADD = AddressADD & Pv
                        End If
                        If Tb <> "" Then
                            AddressADD = AddressADD & Me.txtCode.Text
                        End If
                        Me.txtAddressAdd.Text = AddressADD
                        'txtAddr.Text = vDt.Rows(0).Item("AddressSK")
                    End If
                End If


                If IsDBNull(vDt.Rows(0).Item("PsUpdate")) Then
                    Me.lblPsTs.Text = "-"
                ElseIf Trim((vDt.Rows(0).Item("PsUpdate")) = "") Then
                    Me.lblPsTs.Text = "-"
                Else
                    Me.lblPsTs.Text = vDt.Rows(0).Item("PsUpdate")
                End If

                If IsDBNull(vDt.Rows(0).Item("DateUpdate")) Then
                    Me.lblDate.Text = "-"
                ElseIf Trim((vDt.Rows(0).Item("DateUpdate")) = "") Then
                    Me.lblDate.Text = "-"
                Else
                    Me.lblDate.Text = ksbStringToDate(vDt.Rows(0).Item("DateUpdate"))
                End If
            Else
                '****AddrSent Not Same Addr****'
                'Me.ChkSame.Checked = False
                'If IsDBNull(vDt.Rows(0).Item("Address")) Then
                '    Me.txtAddress.Text = ""
                'ElseIf Trim(vDt.Rows(0).Item("Address")) = "" Then
                '    Me.txtAddress.Text = ""
                'Else
                '    Me.txtAddress.Text = Trim(vDt.Rows(0).Item("Address"))
                'End If
                'Me.txtCusName.Text = vDt.Rows(0).Item("CusName_")

                If Trim(vDt.Rows(0).Item("AddressS")) = "" Then
                    stAdr = 0
                    If Not IsDBNull(vDt.Rows(0).Item("stAddress")) Then
                        'เป็นที่อยู่ต่างประเทศ
                        'Me.txtNumS.Enabled = False
                        'Me.txtVillage.Enabled = False
                        'Me.txtbuilding.Enabled = False
                        'Me.txtFloor.Enabled = False
                        'Me.txtRoad.Enabled = False
                        'Me.txtSoi.Enabled = False
                        'Me.txtMhooS.Enabled = False
                        'Me.txtRoad.Enabled = False
                        'Me.txtRoom.Enabled = False
                        'Me.CmbProvince.Enabled = False
                        'Me.CmbAp.Enabled = False
                        'Me.CmbTb.Enabled = False
                        'Me.txtCode.Enabled = False
                        'Me.txtRoom.Enabled = False
                        'Me.txtForeign.Enabled = True
                        Me.rdbExp.Checked = True
                        Me.txtForeign.Text = ""
                        Me.txtAddressAdd.Text = Trim(Me.txtForeign.Text)
                    Else
                        Me.rdbinThai.Checked = True
                        Me.txtAddressAdd.Text = ""
                        Me.txtNumS.Text = ""
                        Me.txtVillage.Text = ""
                        Me.txtbuilding.Text = ""
                        Me.txtFloor.Text = ""
                        Me.txtRoad.Text = ""
                        Me.txtSoi.Text = ""
                        Me.txtMhooS.Text = ""
                        Me.txtRoad.Text = ""
                        Me.txtRoom.Text = ""
                        CmbProvinceS()
                    End If
                Else
                    stAdr = 1 'มี AddressS
                    If Not IsDBNull(vDt.Rows(0).Item("stAddress")) Then
                        'เป็นที่อยู่ต่างประเทศ
                        Me.rdbExp.Checked = True
                        'Me.txtForeign.Enabled = True
                        Me.txtForeign.Text = Trim(vDt.Rows(0).Item("AddressS"))
                        Me.txtAddressAdd.Text = Trim(Me.txtForeign.Text)
                        'Me.txtNumS.Enabled = False
                        'Me.txtVillage.Enabled = False
                        'Me.txtbuilding.Enabled = False
                        'Me.txtFloor.Enabled = False
                        'Me.txtRoad.Enabled = False
                        'Me.txtSoi.Enabled = False
                        'Me.txtMhooS.Enabled = False
                        'Me.txtRoad.Enabled = False
                        'Me.txtRoom.Enabled = False
                        'Me.CmbProvince.Enabled = False
                        'Me.CmbAp.Enabled = False
                        'Me.CmbTb.Enabled = False
                        'Me.txtCode.Enabled = False
                        'Me.txtRoom.Enabled = False
                    Else
                        'เป็นที่อยู่ในประเทL
                        Me.rdbinThai.Checked = True

                        If Not IsDBNull(vDt.Rows(0).Item("AdNumS")) Then
                            If Trim(vDt.Rows(0).Item("AdNumS")) <> "" Then
                                Me.txtNumS.Text = Trim(vDt.Rows(0).Item("AdNumS"))
                                NumS = " " & Trim(vDt.Rows(0).Item("AdNumS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdVillageS")) Then
                            If Trim(vDt.Rows(0).Item("AdVillageS")) <> "" Then
                                Me.txtVillage.Text = Trim(vDt.Rows(0).Item("AdVillageS"))
                                Village = "หมู่บ้าน " & Trim(vDt.Rows(0).Item("AdVillageS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdBuildingS")) Then
                            If Trim(vDt.Rows(0).Item("AdBuildingS")) <> "" Then
                                Me.txtbuilding.Text = Trim(vDt.Rows(0).Item("AdBuildingS"))
                                Building = "อาคาร " & Trim(vDt.Rows(0).Item("AdBuildingS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdFloorS")) Then
                            If Trim(vDt.Rows(0).Item("AdFloorS")) <> "" Then
                                Me.txtFloor.Text = Trim(vDt.Rows(0).Item("AdFloorS"))
                                Floor = " ชั้น " & Trim(vDt.Rows(0).Item("AdFloorS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdRoomS")) Then
                            If Trim(vDt.Rows(0).Item("AdRoomS")) <> "" Then
                                Me.txtRoom.Text = Trim(vDt.Rows(0).Item("AdRoomS"))
                                Room = " ห้อง " & Trim(vDt.Rows(0).Item("AdRoomS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdSoiS")) Then
                            If Trim(vDt.Rows(0).Item("AdSoiS")) <> "" Then
                                Me.txtSoi.Text = Trim(vDt.Rows(0).Item("AdSoiS"))
                                Soi = " ซอย " & Trim(vDt.Rows(0).Item("AdSoiS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdMhooS")) Then
                            If Trim(vDt.Rows(0).Item("AdMhooS")) <> "" Then
                                Me.txtMhooS.Text = Trim(vDt.Rows(0).Item("AdMhooS"))
                                Mhoo = " หมู่ " & Trim(vDt.Rows(0).Item("AdMhooS"))
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("AdRoadS")) Then
                            If Trim(vDt.Rows(0).Item("AdRoadS")) <> "" Then
                                Me.txtRoad.Text = Trim(vDt.Rows(0).Item("AdRoadS"))
                                Road = " ถนน " & Trim(vDt.Rows(0).Item("AdRoadS"))
                            End If
                        End If

                        CmbProvinceS()
                        If Not IsDBNull(vDt.Rows(0).Item("idPvS")) Then
                            If Trim(vDt.Rows(0).Item("idPvS")) <> "" Then
                                CmbProvince.SelectedValue = Trim(vDt.Rows(0).Item("idPvS"))
                                Pv = " จ." & Me.CmbProvince.Text
                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("idApS")) Then
                            If Trim(vDt.Rows(0).Item("idApS")) <> "" Then
                                Me.CmbAp.SelectedValue = Trim(vDt.Rows(0).Item("idApS"))
                                If vDt.Rows(0).Item("idPvS") = 1 Then
                                    Ap = Me.CmbAp.Text
                                Else
                                    Ap = " อ." & Me.CmbAp.Text
                                End If

                            End If
                        End If
                        If Not IsDBNull(vDt.Rows(0).Item("idTbS")) Then
                            If Trim(vDt.Rows(0).Item("idTbS")) <> "" Then
                                Me.CmbTb.SelectedValue = Trim(vDt.Rows(0).Item("idTbS"))
                                If vDt.Rows(0).Item("idPvS") = 1 Then
                                    Tb = " แขวง " & Me.CmbTb.Text
                                Else
                                    Tb = " ต." & Me.CmbTb.Text
                                End If

                            End If
                        End If

                        If Building <> "" Then
                            AddressADD = AddressADD & Building
                        End If
                        If Floor <> "" Then
                            AddressADD = AddressADD & Floor
                        End If
                        If Room <> "" Then
                            AddressADD = AddressADD & Room
                        End If
                        If Village <> "" Then
                            AddressADD = AddressADD & Village
                        End If
                        If NumS <> "" Then
                            AddressADD = AddressADD & NumS
                        End If
                        If Mhoo <> "" Then
                            AddressADD = AddressADD & Mhoo
                        End If
                        If Soi <> "" Then
                            AddressADD = AddressADD & Soi
                        End If
                        If Road <> "" Then
                            AddressADD = AddressADD & Road
                        End If
                        If Tb <> "" Then
                            AddressADD = AddressADD & Tb
                        End If
                        If Ap <> "" Then
                            AddressADD = AddressADD & Ap
                        End If
                        If Pv <> "" Then
                            AddressADD = AddressADD & Pv
                        End If
                        If Tb <> "" Then
                            AddressADD = AddressADD & Me.txtCode.Text
                        End If
                        Me.txtAddressAdd.Text = AddressADD
                    End If
                End If


                If IsDBNull(vDt.Rows(0).Item("PsUpdate")) Then
                    Me.lblPsTs.Text = "-"
                ElseIf Trim((vDt.Rows(0).Item("PsUpdate")) = "") Then
                    Me.lblPsTs.Text = "-"
                Else
                    Me.lblPsTs.Text = vDt.Rows(0).Item("PsUpdate")
                End If

                If IsDBNull(vDt.Rows(0).Item("DateUpdate")) Then
                    Me.lblDate.Text = "-"
                ElseIf Trim((vDt.Rows(0).Item("DateUpdate")) = "") Then
                    Me.lblDate.Text = "-"
                Else
                    Me.lblDate.Text = ksbStringToDate(vDt.Rows(0).Item("DateUpdate"))
                End If
            End If

        End If

    End Sub

    Private Sub CmbProvinceS()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select PvName, idPv From dProvinceFixSale"
        sAdapter.Fill(sDt)
        With CmbProvince
            .DisplayMember = "PvName"
            .ValueMember = "idPv"
            .DataSource = sDt
        End With
    End Sub

    Private Sub CmbApS()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select ApName, idAp From dAp WHERE idPv = '" & CmbProvince.SelectedValue & "'"
        sAdapter.Fill(sDt)
        With CmbAp
            .DisplayMember = "ApName"
            .ValueMember = "idAp"
            .DataSource = sDt
        End With
    End Sub

    Private Sub CmbTbS()
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select TbName, idTb From dTb WHERE idPv = '" & CmbProvince.SelectedValue & "' AND idAp = '" & CmbAp.SelectedValue & "'"
        sAdapter.Fill(sDt)
        With CmbTb
            .DisplayMember = "TbName"
            .ValueMember = "idTb"
            .DataSource = sDt
        End With
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtCusName.Text = "" Then
            mdLoadCommitt()
            MessageBox.Show("กรุณาเลือกชื่อลูกค้าที่ต้องการกำหนดที่อยู่จัดส่ง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If rdbinThai.Checked = True And CmbProvince.SelectedValue = 0 Then
            mdLoadCommitt()
            MessageBox.Show("กรุณาระบุจังหวัด", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Result = MsgBox("คุณต้องการบันทึกรายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            mdCnOpen()
            If stPage = 1 Then 'Add new
                mdLoadShow()
                InsertCustomerAdrSent()
                mdLoadShow()
            Else 'edit
                mdLoadShow()
                UpdatedCustomerAdrSent()
                mdLoadCommitt()
            End If

            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Sub InsertCustomerAdrSent() 'ADD NEW
        Dim stFrom As Integer = 0
        If Me.ChkSame.Checked = True Then
            stFrom = 1
        Else
            stFrom = 0
        End If

        If Me.rdbExp.Checked = True Then 'ที่อยู่ ตปท
            sCommand.CommandText = "Insert Into dCustomerAdrSent(idCus, AddressS, idPsUpdate, DateUpdate, AddressSK, " & _
                                   "stFromS, stAddress) Values(" & idCus & ", '" & Trim(Me.txtAddressAdd.Text) & "', " & _
                                   "" & sPsId & ", '" & ksbDateToString(Date.Today) & "', " & _
                                   "'" & Trim(Me.txtForeign.Text) & "', " & stFrom & ", 4)"
            sCommand.ExecuteNonQuery()
        Else ' ที่อยู่ ในประเทศ
            sCommand.CommandText = "Insert Into dCustomerAdrSent(idCus, AddressS, idPsUpdate, DateUpdate, idPvS, " & _
                                 "idApS, idTbS, stFromS, AdNumS, AdVillageS, AdBuildingS, AdFloorS, AdRoomS, AdSoiS, AdMhooS, " & _
                                 "AdRoadS) Values(" & idCus & ", '" & Trim(Me.txtAddressAdd.Text) & "', " & _
                                 "" & sPsId & ", '" & ksbDateToString(Date.Today) & "', " & Me.CmbProvince.SelectedValue & ", " & _
                                 "'" & CmbAp.SelectedValue & "', '" & CmbTb.SelectedValue & "', " & stFrom & ", '" & Me.txtNumS.Text & "', " & _
                                 "'" & Me.txtVillage.Text & "', '" & Me.txtbuilding.Text & "', '" & Me.txtFloor.Text & "', " & _
                                 "'" & Me.txtRoom.Text & "', '" & Me.txtSoi.Text & "', '" & Me.txtMhooS.Text & "', '" & Me.txtRoad.Text & "')"
            sCommand.ExecuteNonQuery()
        End If

    End Sub

    Sub UpdatedCustomerAdrSent() 'Edit
        Dim stFrom As Integer = 0
        If Me.ChkSame.Checked = True Then
            stFrom = 1
        Else
            stFrom = 0
        End If

        If Me.rdbExp.Checked = True Then
            Dim strAddr As String = Trim(Me.txtForeign.Text)
            Dim Newstr As String = ""

            For i As Integer = 0 To strAddr.Length - 1
                If strAddr(i) = "'" Then
                    Newstr += "'" + strAddr(i)
                Else
                    Newstr += strAddr(i)
                End If
            Next
            sCommand.CommandText = "Update dCustomerAdrSent SET AddressS = '" & Newstr & "', idPsUpdate ='" & sPsId & "', " & _
                                    "DateUpdate ='" & ksbDateToString(Date.Today) & "', AddressSK ='" & Newstr & "', stFromS = '" & stFrom & "', " & _
                                    "idPvS = NULL, idApS = NULL, idTbS = NULL, AdNumS = NULL, AdVillageS = NULL, AdBuildingS = NULL, " & _
                                    "AdFloorS = NULL, AdRoomS = NULL, AdSoiS = NULL, AdMhooS = NULL, AdRoadS = NULL, " & _
                                    "stAddress = 4 WHERE idCusRefAddr = " & idRef
        Else
            sCommand.CommandText = "Update dCustomerAdrSent SET idPvS = '" & CmbProvince.SelectedValue & "', idApS = '" & CmbAp.SelectedValue & "', " & _
                                   "idTbS = '" & CmbTb.SelectedValue & "', AddressS = '" & txtAddressAdd.Text & "', idPsUpdate ='" & sPsId & "', " & _
                                   "DateUpdate ='" & ksbDateToString(Date.Today) & "', stFromS = '" & stFrom & "', " & _
                                   "AdNumS='" & Me.txtNumS.Text & "', AdVillageS='" & Me.txtVillage.Text & "', AdBuildingS='" & Me.txtbuilding.Text & "', " & _
                                   "AdFloorS='" & Me.txtFloor.Text & "', AdRoomS = '" & Me.txtRoom.Text & "', AdSoiS='" & Me.txtSoi.Text & "', " & _
                                   "AdMhooS = '" & Me.txtMhooS.Text & "', AdRoadS = '" & Me.txtRoad.Text & "', stAddress = NULL, AddressSK = NULL " & _
                                   "WHERE idCusRefAddr = " & idRef
        End If
        sCommand.ExecuteNonQuery()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        mdLoadCommitt()
        Result = MsgBox("คุณต้องการ ลบ รายการนี้ใช่หรือไม่", MsgBoxStyle.YesNo)
        If Result = Windows.Forms.DialogResult.Yes Then
            'sCommand.CommandText = "Delete dCustomerAdrSent Where idCusRefAddr = " & idRef

            sCommand.CommandText = "UPDATE dCustomerAdrSent SET stDel = 1, idPsDel = " & sPsId & ", " & _
                                   "DateDel = '" & ksbDateToString(Date.Today) & "' Where idCusRefAddr = " & idRef
            sCommand.ExecuteNonQuery()

            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub ReAddressADD()
        Dim NumS As String = ""
        Dim Village As String = ""
        Dim Building As String = ""
        Dim Floor As String = ""
        Dim Room As String = ""
        Dim Soi As String = ""
        Dim Mhoo As String = ""
        Dim Road As String = ""
        Dim AddressADD As String = ""
        Dim Tb As String = ""
        Dim Ap As String = ""
        Dim Pv As String = ""
        '  Dim PostCode As String = ""

        If Trim(Me.txtNumS.Text) <> "" Then
            NumS = " " & Trim(Me.txtNumS.Text)
        End If
        If Trim(Me.txtVillage.Text) <> "" Then
            Village = "หมู่บ้าน " & Trim(Me.txtVillage.Text)
        End If
        If Trim(Me.txtbuilding.Text) <> "" Then
            Building = "อาคาร " & Trim(Me.txtbuilding.Text)
        End If
        If Trim(Me.txtFloor.Text) <> "" Then
            Floor = " ชั้น " & Trim(Me.txtFloor.Text)
        End If
        If Trim(Me.txtRoom.Text) <> "" Then
            Room = " ห้อง " & Trim(Me.txtRoom.Text)
        End If
        If Trim(Me.txtSoi.Text) <> "" Then
            Soi = " ซอย " & Trim(Me.txtSoi.Text)
        End If
        If Trim(Me.txtMhooS.Text) <> "" Then
            Mhoo = " หมู่ " & Trim(Me.txtMhooS.Text)
        End If
        If Trim(Me.txtRoad.Text) <> "" Then
            Road = " ถนน " & Trim(Me.txtRoad.Text)
        End If
        If Me.CmbProvince.SelectedValue <> 0 Then
            Pv = " จ." & Me.CmbProvince.Text
        End If
        If Me.CmbAp.SelectedValue <> 0 Then
            If Me.CmbProvince.SelectedValue = 1 Then
                Ap = Me.CmbAp.Text
            Else
                Ap = " อ." & Me.CmbAp.Text
            End If
        End If
        If Me.CmbTb.SelectedValue <> 0 Then
            If Me.CmbProvince.SelectedValue = 1 Then
                Tb = " แขวง " & Me.CmbTb.Text
            Else
                Tb = " ต." & Me.CmbTb.Text
            End If
        End If


        If Building <> "" Then
            AddressADD = AddressADD & Building
        End If
        If Floor <> "" Then
            AddressADD = AddressADD & Floor
        End If
        If Room <> "" Then
            AddressADD = AddressADD & Room
        End If
        If Village <> "" Then
            AddressADD = AddressADD & Village
        End If
        If NumS <> "" Then
            AddressADD = AddressADD & NumS
        End If
        If Mhoo <> "" Then
            AddressADD = AddressADD & Mhoo
        End If
        If Soi <> "" Then
            AddressADD = AddressADD & Soi
        End If
        If Road <> "" Then
            AddressADD = AddressADD & Road
        End If
        If Tb <> "" Then
            AddressADD = AddressADD & Tb
        End If
        If Ap <> "" Then
            AddressADD = AddressADD & Ap
        End If
        If Pv <> "" Then
            AddressADD = AddressADD & Pv
        End If
        If Tb <> "" Then
            AddressADD = AddressADD & Me.txtCode.Text
        End If
        Me.txtAddressAdd.Text = AddressADD
    End Sub

    Private Sub CmbProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProvince.SelectedIndexChanged
        CmbApS()
        If CmbProvince.SelectedValue = 0 Then
            txtAddressAdd.Text = ""
        Else
            ReAddressADD()
        End If
    End Sub

    Private Sub CmbAp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAp.SelectedIndexChanged
        CmbTbS()
        ReAddressADD()
    End Sub

    Private Sub CmbTb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTb.SelectedIndexChanged
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select PostCode From dTb WHERE idTb = '" & CmbTb.SelectedValue & "'"
        sAdapter.Fill(sDt)
        txtCode.Text = sDt.Rows(0).Item("PostCode")

        ReAddressADD()
    End Sub

    Private Sub ChkSameAdr()
        Dim NumS As String = ""
        Dim Village As String = ""
        Dim Building As String = ""
        Dim Floor As String = ""
        Dim Room As String = ""
        Dim Soi As String = ""
        Dim Mhoo As String = ""
        Dim Road As String = ""
        Dim AddressADD As String = ""
        Dim Tb As String = ""
        Dim Ap As String = ""
        Dim Pv As String = ""
        ' Dim PostCode As String = ""
        Dim stAddr As String = ""

        Me.txtForeign.Text = ""
        Me.txtAddressAdd.Text = ""
        Me.txtNumS.Text = ""
        Me.txtVillage.Text = ""
        Me.txtbuilding.Text = ""
        Me.txtFloor.Text = ""
        Me.txtRoad.Text = ""
        Me.txtSoi.Text = ""
        Me.txtMhooS.Text = ""
        Me.txtRoad.Text = ""
        Me.txtRoom.Text = ""

        If Me.ChkSame.Checked = True Then
            'Me.stFrom = 1
            mdCnOpen()
            Dim vDt As New DataTable
            sDs.Tables.Clear()
            sCommand.CommandText = "SELECT Address, AdNum, AdVillage, AdBuilding, AdFloor, AdRoom, AdSoi, AdMhoo, " & _
                                   "AdRoad, idPv, idAp, idTb, stAddress FROM vCustomer WHERE idCus ='" & idCus & "'"
            sAdapter.Fill(vDt)

            If IsDBNull(vDt.Rows(0).Item("Address")) Then
                MessageBox.Show("ไม่พบข้อมูลที่อยู่ปัจจุบัน", sSystemName)
                Me.ChkSame.Checked = False
                Exit Sub
            ElseIf Trim(vDt.Rows(0).Item("Address")) = "" Then
                MessageBox.Show("ไม่พบข้อมูลที่อยู่ปัจจุบัน", sSystemName)
                Me.ChkSame.Checked = False
                Exit Sub
            Else
                If vDt.Rows(0).Item("stAddress") = 4 Then
                    'ที่อยู่ต่างประเทศ
                    Me.rdbExp.Checked = True
                    stAddr = vDt.Rows(0).Item("stAddress")
                    Me.txtForeign.Text = Trim(vDt.Rows(0).Item("Address"))
                    ' Me.txtForeign.Enabled = True
                    ' Me.txtAddressAdd.Text = Trim(vDt.Rows(0).Item("Address"))
                    'Me.txtNumS.Enabled = False
                    'Me.txtVillage.Enabled = False
                    'Me.txtbuilding.Enabled = False
                    'Me.txtFloor.Enabled = False
                    'Me.txtRoad.Enabled = False
                    'Me.txtSoi.Enabled = False
                    'Me.txtMhooS.Enabled = False
                    'Me.txtRoad.Enabled = False
                    'Me.txtRoom.Enabled = False
                    'Me.CmbProvince.Enabled = False
                    'Me.CmbAp.Enabled = False
                    'Me.CmbTb.Enabled = False
                    'Me.txtCode.Enabled = False
                Else
                    'ที่อยู่ในประเทศ
                    Me.rdbinThai.Checked = True
                    If Not IsDBNull(vDt.Rows(0).Item("AdNum")) Then
                        If Trim(vDt.Rows(0).Item("AdNum")) <> "" Then
                            Me.txtNumS.Text = Trim(vDt.Rows(0).Item("AdNum"))
                            NumS = " " & Trim(vDt.Rows(0).Item("AdNum"))
                        End If
                    End If
                    If Not IsDBNull(vDt.Rows(0).Item("AdVillage")) Then
                        If Trim(vDt.Rows(0).Item("AdVillage")) <> "" Then
                            Me.txtVillage.Text = Trim(vDt.Rows(0).Item("AdVillage"))
                            Village = "หมู่บ้าน " & Trim(vDt.Rows(0).Item("AdVillage"))
                        End If
                    End If
                    If Not IsDBNull(vDt.Rows(0).Item("AdBuilding")) Then
                        If Trim(vDt.Rows(0).Item("AdBuilding")) <> "" Then
                            Me.txtbuilding.Text = Trim(vDt.Rows(0).Item("AdBuilding"))
                            Building = "อาคาร " & Trim(vDt.Rows(0).Item("AdBuilding"))
                        End If
                    End If
                    If Not IsDBNull(vDt.Rows(0).Item("AdFloor")) Then
                        If Trim(vDt.Rows(0).Item("AdFloor")) <> "" Then
                            Me.txtFloor.Text = Trim(vDt.Rows(0).Item("AdFloor"))
                            Floor = " ชั้น " & Trim(vDt.Rows(0).Item("AdFloor"))
                        End If
                    End If
                    If Not IsDBNull(vDt.Rows(0).Item("AdRoom")) Then
                        If Trim(vDt.Rows(0).Item("AdRoom")) <> "" Then
                            Me.txtRoom.Text = Trim(vDt.Rows(0).Item("AdRoom"))
                            Room = " ห้อง " & Trim(vDt.Rows(0).Item("AdRoom"))
                        End If
                    End If
                    If Not IsDBNull(vDt.Rows(0).Item("AdSoi")) Then
                        If Trim(vDt.Rows(0).Item("AdSoi")) <> "" Then
                            Me.txtSoi.Text = Trim(vDt.Rows(0).Item("AdSoi"))
                            Soi = " ซอย " & Trim(vDt.Rows(0).Item("AdSoi"))
                        End If
                    End If
                    If Not IsDBNull(vDt.Rows(0).Item("AdMhoo")) Then
                        If Trim(vDt.Rows(0).Item("AdMhoo")) <> "" Then
                            Me.txtMhooS.Text = Trim(vDt.Rows(0).Item("AdMhoo"))
                            Mhoo = " หมู่ " & Trim(vDt.Rows(0).Item("AdMhoo"))
                        End If
                    End If
                    If Not IsDBNull(vDt.Rows(0).Item("AdRoad")) Then
                        If Trim(vDt.Rows(0).Item("AdRoad")) <> "" Then
                            Me.txtRoad.Text = Trim(vDt.Rows(0).Item("AdRoad"))
                            Road = " ถนน " & Trim(vDt.Rows(0).Item("AdRoad"))
                        End If
                    End If

                    CmbProvinceS()
                    If Not IsDBNull(vDt.Rows(0).Item("idPv")) Then
                        If Trim(vDt.Rows(0).Item("idPv")) <> "" Then
                            CmbProvince.SelectedValue = Trim(vDt.Rows(0).Item("idPv"))
                            Pv = " จ." & Me.CmbProvince.Text
                        End If
                    End If
                    If Not IsDBNull(vDt.Rows(0).Item("idAp")) Then
                        If Trim(vDt.Rows(0).Item("idAp")) <> "" Then
                            Me.CmbAp.SelectedValue = Trim(vDt.Rows(0).Item("idAp"))
                            Ap = " อ." & Me.CmbAp.Text
                        End If
                    End If
                    If Not IsDBNull(vDt.Rows(0).Item("idTb")) Then
                        If Trim(vDt.Rows(0).Item("idTb")) <> "" Then
                            Me.CmbTb.SelectedValue = Trim(vDt.Rows(0).Item("idTb"))
                            Tb = " ต." & Me.CmbTb.Text
                        End If
                    End If

                    If Building <> "" Then
                        AddressADD = AddressADD & Building
                    End If
                    If Floor <> "" Then
                        AddressADD = AddressADD & Floor
                    End If
                    If Room <> "" Then
                        AddressADD = AddressADD & Room
                    End If
                    If Village <> "" Then
                        AddressADD = AddressADD & Village
                    End If
                    If NumS <> "" Then
                        AddressADD = AddressADD & NumS
                    End If
                    If Mhoo <> "" Then
                        AddressADD = AddressADD & Mhoo
                    End If
                    If Soi <> "" Then
                        AddressADD = AddressADD & Soi
                    End If
                    If Road <> "" Then
                        AddressADD = AddressADD & Road
                    End If
                    If Tb <> "" Then
                        AddressADD = AddressADD & Tb
                    End If
                    If Ap <> "" Then
                        AddressADD = AddressADD & Ap
                    End If
                    If Pv <> "" Then
                        AddressADD = AddressADD & Pv
                    End If
                    If Tb <> "" Then
                        AddressADD = AddressADD & Me.txtCode.Text
                    End If
                    Me.txtAddressAdd.Text = AddressADD
                End If

                'Me.txtAddr.Text = Trim(vDt.Rows(0).Item("Address"))
            End If ' End ChkAddress
            Me.rdbExp.Enabled = False
            Me.rdbinThai.Enabled = False
        Else ' Not Same
            'Me.stFrom = 0
            Me.rdbExp.Enabled = True
            Me.rdbinThai.Enabled = True
            CmbProvinceS()
            Me.txtAddressAdd.Text = ""
            '    mdCnOpen()
            '    Dim Dt As New DataTable
            '    Dt.Clear()
            '    sCommand.CommandText = "SELECT stAddress FROM vCustomer WHERE idCus ='" & idCus & "'"
            '    sAdapter.Fill(Dt)

            '    If Dt.Rows(0).Item("stAddress") = 4 Then
            '        Me.txtForeign.Enabled = False
            '        Me.txtAddressAdd.Text = Trim(Me.txtForeign.Text)
            '        Me.CmbProvince.Enabled = False
            '        Me.CmbAp.Enabled = False
            '        Me.CmbTb.Enabled = False
            '        Me.txtCode.Enabled = False
            '    Else
            '        Me.txtAddressAdd.Text = ""
            '        Me.txtNumS.Text = ""
            '        Me.txtVillage.Text = ""
            '        Me.txtbuilding.Text = ""
            '        Me.txtFloor.Text = ""
            '        Me.txtRoad.Text = ""
            '        Me.txtSoi.Text = ""
            '        Me.txtMhooS.Text = ""
            '        Me.txtRoad.Text = ""
            '        Me.txtForeign.Text = ""
            '        Me.CmbProvince.Enabled = True
            '        Me.CmbAp.Enabled = True
            '        Me.CmbTb.Enabled = True
            '        Me.txtCode.Enabled = True
            '        CmbProvinceS()
            '    End If
        End If
    End Sub

    Private Sub ChkSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSame.CheckedChanged
        If Me.ChkSame.Checked = True Then
            If txtCusName.Text = "" Then
                mdLoadCommitt()
                MessageBox.Show("กรุณาเลือกชื่อลูกค้าที่ต้องการกำหนดที่อยู่จัดส่ง", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ChkSame.Checked = False
                Exit Sub
            End If
        End If

        ChkSameAdr()
    End Sub

    Private Sub txtbuilding_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuilding.TextChanged
        ReAddressADD()
    End Sub

    Private Sub txtFloor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFloor.TextChanged
        ReAddressADD()
    End Sub

    Private Sub txtRoom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoom.TextChanged
        ReAddressADD()
    End Sub

    Private Sub txtVillage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.TextChanged
        ReAddressADD()
    End Sub

    Private Sub txtNumS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumS.TextChanged
        ReAddressADD()
    End Sub

    Private Sub txtMhooS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMhooS.TextChanged
        ReAddressADD()
    End Sub

    Private Sub txtSoi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoi.TextChanged
        ReAddressADD()
    End Sub

    Private Sub txtRoad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoad.TextChanged
        ReAddressADD()
    End Sub

    Private Sub txtForeign_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtForeign.TextChanged
        Me.txtAddressAdd.Text = Me.txtForeign.Text
    End Sub

    Private Sub rdbExp_CheckedChanged(sender As Object, e As EventArgs) Handles rdbExp.CheckedChanged
        If Me.rdbExp.Checked = True Then
            Me.txtForeign.Enabled = True
        Else
            Me.txtForeign.Enabled = False
            Me.txtForeign.Text = ""
        End If
    End Sub

    Private Sub rdbinThai_CheckedChanged(sender As Object, e As EventArgs) Handles rdbinThai.CheckedChanged
        If Me.rdbinThai.Checked = True Then
            Me.txtNumS.Enabled = True
            Me.txtVillage.Enabled = True
            Me.txtbuilding.Enabled = True
            Me.txtFloor.Enabled = True
            Me.txtRoad.Enabled = True
            Me.txtSoi.Enabled = True
            Me.txtMhooS.Enabled = True
            Me.txtRoad.Enabled = True
            Me.txtRoom.Enabled = True
            Me.CmbProvince.Enabled = True
            Me.CmbAp.Enabled = True
            Me.CmbTb.Enabled = True
            Me.txtCode.Enabled = True
        Else
            Me.txtNumS.Enabled = False
            Me.txtVillage.Enabled = False
            Me.txtbuilding.Enabled = False
            Me.txtFloor.Enabled = False
            Me.txtRoad.Enabled = False
            Me.txtSoi.Enabled = False
            Me.txtMhooS.Enabled = False
            Me.txtRoad.Enabled = False
            Me.txtRoom.Enabled = False
            Me.CmbProvince.Enabled = False
            Me.CmbAp.Enabled = False
            Me.CmbTb.Enabled = False
            Me.txtCode.Enabled = False
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim vFrm As New frmCustomerSelect(frmCustomerSelect.eProcess.eSelect, sIdComp)
        If vFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            idCus = vFrm.idCus
            Me.txtCusName.Tag = vFrm.idCus
            Me.txtCusName.Text = vFrm.CusName

            mdCnOpen()
            Dim sDt As New DataTable
            sCommand.CommandText = "Select Address From vCustomer WHERE idCus = " & vFrm.idCus
            sAdapter.Fill(sDt)

            If Not IsDBNull(sDt.Rows(0).Item("Address")) Then
                Me.txtAddress.Text = sDt.Rows(0).Item("Address")
            End If

        End If
    End Sub
End Class