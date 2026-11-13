Imports System.Net
Imports System.IO

Public Class frmMkGiftDocSelect
    Dim Process As eProcess
    Public dGiftCusMany As New DataTable
    Public CompName As String
    Public CompAddress As String
    Public pTel As String
    Public PsGifttxt As String

    Enum eProcess
        eDataSet1
        eDataSet2
        eDataSet3
        eDataSet4
    End Enum

    Sub New(ByVal aProcess As eProcess, ByVal dtCusGift As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Select Case aProcess
            Case eProcess.eDataSet1
                Process = eProcess.eDataSet1
            Case eProcess.eDataSet2
                Process = eProcess.eDataSet2
                dGiftCusMany = dtCusGift
            Case eProcess.eDataSet3
                Process = eProcess.eDataSet3
            Case eProcess.eDataSet4
                Process = eProcess.eDataSet4
                dGiftCusMany = dtCusGift
        End Select
    End Sub

    Function CHKAddress(ByVal sDt_Temp As DataTable, ByVal sDt_Temp2 As DataTable, ByVal NameTanle As String) As String
        Dim ans As String = ""
        Dim NameTanleS As String = NameTanle + "S"

        If sDt_Temp.Rows(0).Item(NameTanleS) Is DBNull.Value Then
            If sDt_Temp2.Rows(0).Item(NameTanle) Is DBNull.Value Then
                ans = "-"
            Else
                If sDt_Temp2.Rows(0).Item(NameTanle).ToString.Trim = "" Then
                    ans = "-"
                Else
                    ans = sDt_Temp2.Rows(0).Item(NameTanle)
                End If
            End If
        Else
            If sDt_Temp.Rows(0).Item(NameTanleS).ToString.Trim = "" Then
                ans = "-"
            Else
                ans = sDt_Temp.Rows(0).Item(NameTanleS)
            End If
        End If
        Return ans
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case Process
            Case eProcess.eDataSet1
                mdLoadShow()
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCard
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1

                    If RBAdress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString + " และครอบครัว"
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If
                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If
                    If RBAllAddress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString + " และครอบครัว"
                        End If
                    End If

                    Dim sDt_Temp As New DataTable
                    Dim sDt_Temp2 As New DataTable
                    mdCnOpen()
                    sCommand.CommandText = "Select C.AdNumS, C.AdVillageS, C.AdBuildingS, C.AdFloorS, C.AdRoomS, C.AdSoiS, C.AdMhooS, C.AdRoadS, P.PvName AS PvNameS , A.ApName AS ApNameS , T.TbName AS TbNameS, T.PostCode AS PostCodeS FROM dbo.dCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS P ON C.idPvS = P.idPv LEFT OUTER JOIN dbo.dAp AS A ON C.idApS = A.idAp LEFT OUTER JOIN dbo.dTb AS T ON C.idTbS = T.idTb WHERE C.idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(sDt_Temp)
                    sCommand.CommandText = "Select C.AdNum, C.AdVillage, C.AdBuilding, C.AdFloor, C.AdRoom, C.AdSoi, C.AdMhoo, C.AdRoad, P.PvName, A.ApName, T.TbName, T.PostCode FROM dbo.dCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS P ON C.idPv = P.idPv LEFT OUTER JOIN dbo.dAp AS A ON C.idAp = A.idAp LEFT OUTER JOIN dbo.dTb AS T ON C.idTb = T.idTb WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(sDt_Temp2)
                    Dim AdNum As String
                    Dim AdVillage As String
                    Dim AdBuilding As String
                    Dim AdFloor As String
                    Dim AdRoom As String
                    Dim AdSoi As String
                    Dim AdMhoo As String
                    Dim AdRoad As String
                    Dim PvName As String
                    Dim ApName As String
                    Dim TbName As String
                    Dim PostCode As String

                    AdNum = CHKAddress(sDt_Temp, sDt_Temp2, "AdNum")
                    AdVillage = CHKAddress(sDt_Temp, sDt_Temp2, "AdVillage")
                    AdBuilding = CHKAddress(sDt_Temp, sDt_Temp2, "AdBuilding")
                    AdFloor = CHKAddress(sDt_Temp, sDt_Temp2, "AdFloor")
                    AdRoom = CHKAddress(sDt_Temp, sDt_Temp2, "AdRoom")
                    AdSoi = CHKAddress(sDt_Temp, sDt_Temp2, "AdSoi")
                    AdMhoo = CHKAddress(sDt_Temp, sDt_Temp2, "AdMhoo")
                    AdRoad = CHKAddress(sDt_Temp, sDt_Temp2, "AdRoad")
                    PvName = CHKAddress(sDt_Temp, sDt_Temp2, "PvName")
                    ApName = CHKAddress(sDt_Temp, sDt_Temp2, "ApName")
                    TbName = CHKAddress(sDt_Temp, sDt_Temp2, "TbName")
                    PostCode = CHKAddress(sDt_Temp, sDt_Temp2, "PostCode")
                    Dim array_temp As New ArrayList
                    Dim AddressRec1 As String = ""
                    Dim AddressRec2 As String = ""
                    Dim AddressRec3 As String = ""
                    Dim AddressRec4 As String = ""

                    If AdNum <> "-" Then
                        array_temp.Add("เลขที่ " + AdNum.Trim)
                        AddressRec1 += "เลขที่ " + AdNum.Trim + " "
                    End If
                    'If AdBuilding <> "-" Then
                    '    array_temp.Add("อาคาร " + AdBuilding.Trim)
                    'End If
                    'If AdFloor <> "-" Then
                    '    array_temp.Add("ชั้น " + AdFloor.Trim)
                    'End If
                    'If AdRoom <> "-" Then
                    '    array_temp.Add("ห้อง " + AdRoom.Trim)
                    'End If
                    'If AdVillage <> "-" Then
                    '    array_temp.Add("หมู่บ้าน " + AdVillage.Trim)
                    'End If
                    If AdMhoo <> "-" Then
                        array_temp.Add("หมู่ " + AdMhoo.Trim)
                        AddressRec1 += "หมู่ " + AdMhoo.Trim + " "
                    End If
                    If AdSoi <> "-" Then
                        array_temp.Add("ซอย " + AdSoi.Trim)
                        AddressRec1 += "ซอย " + AdSoi.Trim + " "
                    End If
                    If AdRoad <> "-" Then
                        array_temp.Add("ถนน " + AdRoad.Trim)
                        AddressRec1 += "ถนน " + AdRoad.Trim + " "
                    End If
                    If TbName <> "-" Then
                        If PvName.Trim = "กรุงเทพมหานคร" Then
                            array_temp.Add("แขวง " + TbName.Trim)
                            AddressRec2 += "แขวง " + TbName.Trim + " "
                        Else
                            array_temp.Add("ตำบล " + TbName.Trim)
                            AddressRec2 += "ตำบล " + TbName.Trim + " "
                        End If
                    End If
                    If ApName <> "-" Then
                        If PvName.Trim = "กรุงเทพมหานคร" Then
                            array_temp.Add(ApName.Trim)
                            AddressRec2 += ApName.Trim + " "
                        Else
                            array_temp.Add("อำเภอ " + ApName.Trim)
                            AddressRec2 += "อำเภอ " + ApName.Trim + " "
                        End If

                    End If
                    If PvName <> "-" Then
                        If PvName.Trim = "กรุงเทพมหานคร" Then
                            array_temp.Add(PvName.Trim)
                            AddressRec3 += PvName.Trim + " "
                        Else
                            array_temp.Add("จังหวัด " + PvName.Trim)
                            AddressRec3 += "จังหวัด " + PvName.Trim + " "
                        End If

                    End If
                    If PostCode <> "-" Then
                        array_temp.Add(PostCode.Trim)
                        AddressRec3 += PostCode.Trim + " "
                    End If

                    Dim lentAddress1 As Integer = 30
                    Dim lentAddress2 As Integer = 30
                    Dim lentAddress3 As Integer = 30
                    Dim lentAddress4 As Integer = 30

                    'For j As Integer = 0 To array_temp.Count - 1
                    '    Dim strlent As Integer = array_temp(j).ToString.Length
                    '    If lentAddress1 > 0 And strlent < lentAddress1 Then
                    '        AddressRec1 += array_temp(j) + " "
                    '        lentAddress1 = lentAddress1 - strlent
                    '    Else
                    '        lentAddress1 = 0
                    '        If lentAddress2 > 0 And strlent < lentAddress2 Then
                    '            AddressRec2 += array_temp(j) + " "
                    '            lentAddress2 = lentAddress2 - strlent
                    '        Else
                    '            lentAddress2 = 0
                    '            If lentAddress3 > 0 And strlent < lentAddress3 Then
                    '                AddressRec3 += array_temp(j) + " "
                    '                lentAddress3 = lentAddress3 - strlent
                    '            Else
                    '                lentAddress3 = 0
                    '                If lentAddress4 > 0 And strlent < lentAddress4 Then
                    '                    AddressRec4 += array_temp(j) + " "
                    '                    lentAddress4 = lentAddress4 - strlent
                    '                End If
                    '            End If
                    '        End If
                    '    End If
                    'Next
                    'Dim AddressRec1 As String = "เลขที่ " + AdNum + " อาคาร  " + AdBuilding + " ชั้น " + AdFloor + " ห้อง " + AdRoom + " "
                    'Dim AddressRec2 As String = "หมู่บ้าน " + AdVillage + " หมู่ " + AdMhoo + " ซ. " + AdSoi + " ถ. " + AdRoad
                    'Dim AddressRec3 As String
                    'Dim AddressRec4 As String

                    'If PvName.Trim = "กรุงเทพมหานคร" Then
                    '    AddressRec3 = "แขวง " + TbName + " " + ApName
                    '    AddressRec4 = PvName + " " + PostCode
                    'Else
                    '    AddressRec3 = "ต. " + TbName + "อ. " + ApName
                    '    AddressRec4 = "จ. " + PvName + " " + PostCode
                    'End If

                    dGiftCusMany.Rows(i).Item("AddressRec1") = AddressRec1
                    dGiftCusMany.Rows(i).Item("AddressRec2") = AddressRec2
                    dGiftCusMany.Rows(i).Item("AddressRec3") = AddressRec3
                    dGiftCusMany.Rows(i).Item("AddressRec4") = AddressRec4
                Next
                mdLoadCommitt()
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                vRpt.SetDataSource(dGiftCusMany)
                vFrm.crView.ReportSource = vRpt
                vRpt.SetParameterValue(vRpt.Parameter_head.ParameterFieldName, head)
                vRpt.SetParameterValue(vRpt.Parameter_head2.ParameterFieldName, head2)
                Me.Close()
                vFrm.Show()
            Case eProcess.eDataSet2
                mdLoadShow()
                If dGiftCusMany.Rows.Count = 0 Then
                    MessageBox.Show("ไม่มีข้อมูลสำหรับแสดงเอกสาร", sSystemName)
                    Exit Sub
                End If

                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    mdCnOpen()
                    Dim dt As New DataTable
                    Dim dt2 As New DataTable
                    Dim dt3 As New DataTable
                    dt.Clear()
                    dt2.Clear()
                    dt3.Clear()
                    sCommand.CommandText = "Select CusNameCon_, CusName_, Tel FROM vCustomer WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt3)
                    sCommand.CommandText = "Select C.AdNumS, C.AdVillageS, C.AdBuildingS, C.AdFloorS, C.AdRoomS, " & _
                                            "C.AdSoiS, C.AdMhooS, C.AdRoadS, P.PvName AS PvNameS , A.ApName AS ApNameS, " & _
                                            "T.TbName AS TbNameS, T.PostCode AS PostCodeS FROM dbo.dCustomer AS C " & _
                                            "LEFT OUTER JOIN dbo.dProvinceFixSale AS P ON C.idPvS = P.idPv " & _
                                            "LEFT OUTER JOIN dbo.dAp AS A ON C.idApS = A.idAp LEFT OUTER JOIN " & _
                                            "dbo.dTb AS T ON C.idTbS = T.idTb WHERE C.idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt)
                    sCommand.CommandText = "Select C.AdNum, C.AdVillage, C.AdBuilding, C.AdFloor, C.AdRoom, " & _
                                            "C.AdSoi, C.AdMhoo, C.AdRoad, P.PvName, A.ApName, T.TbName, T.PostCode " & _
                                            "FROM dbo.dCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS P " & _
                                            "ON C.idPv = P.idPv LEFT OUTER JOIN dbo.dAp AS A ON C.idAp = A.idAp " & _
                                            "LEFT OUTER JOIN dbo.dTb AS T ON C.idTb = T.idTb " & _
                                            "WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt2)

                    '----Check CusName or CompName----'
                    If Me.RBAdress.Checked = True Then
                        If dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "" Or dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusNameCon_") + " และครอบครัว"
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If
                    If Me.RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusName_")
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If
                    If Me.RBAllAddress.Checked = True Then
                        If dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "" Or dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusName_")
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusNameCon_") + " และครอบครัว"
                            dGiftCusMany.Rows(i).Item("CompRec") = dt3.Rows(0).Item("CusName_")
                        End If
                    End If

                    '----Check Address-------'
                    'If Trim(dt.Rows(0).Item("AddressS")) = "" Then
                    '    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
                    'ElseIf IsDBNull(dt.Rows(0).Item("AddressS")) Then
                    '    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
                    'Else
                    '    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("AddressS")
                    'End If
                    Dim AdNum As String
                    Dim AdVillage As String
                    Dim AdBuilding As String
                    Dim AdFloor As String
                    Dim AdRoom As String
                    Dim AdSoi As String
                    Dim AdMhoo As String
                    Dim AdRoad As String
                    Dim PvName As String
                    Dim ApName As String
                    Dim TbName As String
                    Dim PostCode As String

                    AdNum = CHKAddress(dt, dt2, "AdNum")
                    AdVillage = CHKAddress(dt, dt2, "AdVillage")
                    AdBuilding = CHKAddress(dt, dt2, "AdBuilding")
                    AdFloor = CHKAddress(dt, dt2, "AdFloor")
                    AdRoom = CHKAddress(dt, dt2, "AdRoom")
                    AdSoi = CHKAddress(dt, dt2, "AdSoi")
                    AdMhoo = CHKAddress(dt, dt2, "AdMhoo")
                    AdRoad = CHKAddress(dt, dt2, "AdRoad")
                    PvName = CHKAddress(dt, dt2, "PvName")
                    ApName = CHKAddress(dt, dt2, "ApName")
                    TbName = CHKAddress(dt, dt2, "TbName")
                    PostCode = CHKAddress(dt, dt2, "PostCode")

                    Dim array_temp As New ArrayList
                    Dim AddressRec1 As String = ""
                    Dim AddressRec2 As String = ""
                    Dim AddressRec3 As String = ""
                    Dim AddressRec4 As String = ""

                    If AdNum <> "-" Then
                        array_temp.Add("เลขที่ " + AdNum.Trim)
                        AddressRec1 += "เลขที่ " + AdNum.Trim + " "
                    End If
                    'If AdBuilding <> "-" Then
                    '    array_temp.Add("อาคาร " + AdBuilding.Trim)
                    'End If
                    'If AdFloor <> "-" Then
                    '    array_temp.Add("ชั้น " + AdFloor.Trim)
                    'End If
                    'If AdRoom <> "-" Then
                    '    array_temp.Add("ห้อง " + AdRoom.Trim)
                    'End If
                    'If AdVillage <> "-" Then
                    '    array_temp.Add("หมู่บ้าน " + AdVillage.Trim)
                    'End If
                    If AdMhoo <> "-" Then
                        array_temp.Add("หมู่ " + AdMhoo.Trim)
                        AddressRec1 += "หมู่ " + AdMhoo.Trim + " "
                    End If
                    If AdSoi <> "-" Then
                        array_temp.Add("ซอย " + AdSoi.Trim)
                        AddressRec1 += "ซอย " + AdSoi.Trim + " "
                    End If
                    If AdRoad <> "-" Then
                        array_temp.Add("ถนน " + AdRoad.Trim)
                        AddressRec1 += "ถนน " + AdRoad.Trim + " "
                    End If
                    If TbName <> "-" Then
                        If PvName.Trim = "กรุงเทพมหานคร" Then
                            array_temp.Add("แขวง " + TbName.Trim)
                            AddressRec2 += "แขวง " + TbName.Trim + " "
                        Else
                            array_temp.Add("ตำบล " + TbName.Trim)
                            AddressRec2 += "ตำบล " + TbName.Trim + " "
                        End If
                    End If
                    If ApName <> "-" Then
                        If PvName.Trim = "กรุงเทพมหานคร" Then
                            array_temp.Add(ApName.Trim)
                            AddressRec2 += ApName.Trim + " "
                        Else
                            array_temp.Add("อำเภอ " + ApName.Trim)
                            AddressRec2 += "อำเภอ " + ApName.Trim + " "
                        End If

                    End If
                    If PvName <> "-" Then
                        If PvName.Trim = "กรุงเทพมหานคร" Then
                            array_temp.Add(PvName.Trim)
                            AddressRec3 += PvName.Trim + " "
                        Else
                            array_temp.Add("จังหวัด " + PvName.Trim)
                            AddressRec3 += "จังหวัด " + PvName.Trim + " "
                        End If

                    End If
                    If PostCode <> "-" Then
                        array_temp.Add(PostCode.Trim)
                        AddressRec3 += PostCode.Trim + " "
                    End If

                    Dim lentAddress1 As Integer = 30
                    Dim lentAddress2 As Integer = 30
                    Dim lentAddress3 As Integer = 30
                    Dim lentAddress4 As Integer = 30

                    'For j As Integer = 0 To array_temp.Count - 1
                    '    Dim strlent As Integer = array_temp(j).ToString.Length
                    '    If lentAddress1 > 0 And strlent < lentAddress1 Then
                    '        AddressRec1 += array_temp(j) + " "
                    '        lentAddress1 = lentAddress1 - strlent
                    '    Else
                    '        lentAddress1 = 0
                    '        If lentAddress2 > 0 And strlent < lentAddress2 Then
                    '            AddressRec2 += array_temp(j) + " "
                    '            lentAddress2 = lentAddress2 - strlent
                    '        Else
                    '            lentAddress2 = 0
                    '            If lentAddress3 > 0 And strlent < lentAddress3 Then
                    '                AddressRec3 += array_temp(j) + " "
                    '                lentAddress3 = lentAddress3 - strlent
                    '            Else
                    '                lentAddress3 = 0
                    '                If lentAddress4 > 0 And strlent < lentAddress4 Then
                    '                    AddressRec4 += array_temp(j) + " "
                    '                    lentAddress4 = lentAddress4 - strlent
                    '                End If
                    '            End If
                    '        End If
                    '    End If
                    'Next
                    'Dim AddressRec1 As String = "เลขที่ " + AdNum + " อาคาร  " + AdBuilding + " ชั้น " + AdFloor + " ห้อง " + AdRoom + " "
                    'Dim AddressRec2 As String = "หมู่บ้าน " + AdVillage + " หมู่ " + AdMhoo + " ซ. " + AdSoi + " ถ. " + AdRoad
                    'Dim AddressRec3 As String
                    'Dim AddressRec4 As String

                    'If PvName.Trim = "กรุงเทพมหานคร" Then
                    '    AddressRec3 = "แขวง " + TbName + " " + ApName
                    '    AddressRec4 = PvName + " " + PostCode
                    'Else
                    '    AddressRec3 = "ต. " + TbName + "อ. " + ApName
                    '    AddressRec4 = "จ. " + PvName + " " + PostCode
                    'End If

                    dGiftCusMany.Rows(i).Item("AddressRec1") = AddressRec1
                    dGiftCusMany.Rows(i).Item("AddressRec2") = AddressRec2
                    dGiftCusMany.Rows(i).Item("AddressRec3") = AddressRec3
                    dGiftCusMany.Rows(i).Item("AddressRec4") = AddressRec4
                    '---Tel----'
                    dGiftCusMany.Rows(i).Item("TelRec") = dt3.Rows(0).Item("Tel")
                Next

                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCard
                Dim sDt_Temp As New DataTable

                mdCnOpen2()
                sCommand.CommandText = "SELECT CompName ,Address,Tel  FROM dCompany WHERE idComp = " + sIdComp.ToString
                sAdapter.Fill(sDt_Temp)

                Dim CompName As String = sDt_Temp.Rows(0).Item("CompName")
                Dim CompAddress As String = sDt_Temp.Rows(0).Item("Address")
                Dim pTel As String = sDt_Temp.Rows(0).Item("Tel")
                mdLoadCommitt()
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next

                vRpt.SetDataSource(dGiftCusMany)
                vFrm.crView.ReportSource = vRpt
                vRpt.SetParameterValue(vRpt.Parameter_head.ParameterFieldName, head)
                vRpt.SetParameterValue(vRpt.Parameter_head2.ParameterFieldName, head2)
                vFrm.Show()
            Case eProcess.eDataSet3
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCard
                Dim sDt_Temp As New DataTable

                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    If RBAdress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If
                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If

                    If RBAllAddress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString
                        End If
                    End If
                    dGiftCusMany.Rows(i).Item("AddressRec1") = dGiftCusMany.Rows(i).Item("AddressRec")

                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_head.ParameterFieldName, head)
                vRpt.SetParameterValue(vRpt.Parameter_head2.ParameterFieldName, head2)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            Case eProcess.eDataSet4
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCard
                Dim sDt_Temp As New DataTable

                mdCnOpen2()

                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim dt As New DataTable
                    dt.Clear()
                    sCommand.CommandText = "Select SupName, SupAddress, SupContact, SupContactTel FROM vSupplier WHERE idSup = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt)

                    If RBAdress.Checked = True Then
                        If dt.Rows(0).Item("SupContact").ToString.Trim = "" Or dt.Rows(0).Item("SupContact").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupContact").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If

                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupName").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If

                    If RBAllAddress.Checked = True Then
                        If dt.Rows(0).Item("SupContact").ToString.Trim = "" Or dt.Rows(0).Item("SupContact").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupName").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupContact").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = dt.Rows(0).Item("SupName").ToString
                        End If
                    End If
                    dGiftCusMany.Rows(i).Item("AddressRec1") = dt.Rows(0).Item("SupAddress").ToString
                    dGiftCusMany.Rows(i).Item("TelRec") = dt.Rows(0).Item("SupContactTel").ToString

                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_head.ParameterFieldName, head)
                vRpt.SetParameterValue(vRpt.Parameter_head2.ParameterFieldName, head2)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
        End Select
    End Sub

    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        Select Case Process
            Case eProcess.eDataSet1
                mdLoadShow()
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpStickerSaleSeedsPsRecSend
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    If RBAdress.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If
                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If
                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsSend.ParameterFieldName, PsGifttxt)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendCompb.ParameterFieldName, CompName)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendAddress.ParameterFieldName, CompAddress)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendTel.ParameterFieldName, pTel)
                vFrm.crView.ReportSource = vRpt
                'vFrm.ppDisplayGroupTree = True
                vFrm.Show()
            Case eProcess.eDataSet2
                mdLoadShow()

                If dGiftCusMany.Rows.Count = 0 Then
                    MessageBox.Show("ไม่มีข้อมูลสำหรับแสดงเอกสาร", sSystemName)
                    Exit Sub
                End If

                mdCnOpen()
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim dt As New DataTable
                    dt.Clear()
                    sCommand.CommandText = "Select CusNameCon_, CusName_, AddressS, Address, Tel FROM vCustomer WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt)
                    If Me.RBAdress.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("CusNameCon_")
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    ElseIf Me.RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("CusName_")
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    ElseIf Me.RBAllAddress.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("CusNameCon_")
                        dGiftCusMany.Rows(i).Item("CompRec") = dt.Rows(0).Item("CusName_")
                    End If
                    If Trim(dt.Rows(0).Item("AddressS")) = "" Then
                        dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
                    ElseIf IsDBNull(dt.Rows(0).Item("AddressS")) Then
                        dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
                    Else
                        dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("AddressS")
                    End If
                    dGiftCusMany.Rows(i).Item("TelRec") = dt.Rows(0).Item("Tel")
                Next


                Dim vFrm As New FrmReportView
                Dim vRpt As New crpStickerSaleSeedsPsRecSend
                Dim sDt_Temp As New DataTable

                mdCnOpen2()
                sCommand.CommandText = "SELECT CompName ,Address,Tel  FROM dCompany WHERE idComp = " + sIdComp.ToString
                sAdapter.Fill(sDt_Temp)

                Dim CompName As String = sDt_Temp.Rows(0).Item("CompName")
                Dim CompAddress As String = sDt_Temp.Rows(0).Item("Address")
                Dim pTel As String = sDt_Temp.Rows(0).Item("Tel")
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()
                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsSend.ParameterFieldName, "")
                vRpt.SetParameterValue(vRpt.Parameter_ptSendCompb.ParameterFieldName, CompName)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendAddress.ParameterFieldName, CompAddress)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendTel.ParameterFieldName, pTel)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            Case eProcess.eDataSet3
                mdLoadShow()
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpStickerSaleSeedsPsRecSend
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    If RBAdress.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If
                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If
                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsSend.ParameterFieldName, PsGifttxt)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendCompb.ParameterFieldName, CompName)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendAddress.ParameterFieldName, CompAddress)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendTel.ParameterFieldName, pTel)
                vFrm.crView.ReportSource = vRpt
                'vFrm.ppDisplayGroupTree = True
                vFrm.Show()
            Case eProcess.eDataSet4
                mdLoadShow()
                'Dim head As String = "แด่"
                'Dim head2 As String = "ส.ค.ส."
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpStickerSaleSeedsPsRecSend
                Dim sDt_Temp As New DataTable

                If dGiftCusMany.Rows.Count = 0 Then
                    MessageBox.Show("ไม่มีข้อมูลสำหรับแสดงเอกสาร", sSystemName)
                    Exit Sub
                End If

                mdCnOpen2()
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    'MessageBox.Show("Rec " & dGiftCusMany.Rows(i).Item("idCus"))
                    Dim dt As New DataTable
                    dt.Clear()
                    sCommand.CommandText = "Select SupName, SupAddress, SupContact, SupContactTel FROM vSupplier WHERE idSup = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt)

                    If RBAdress.Checked = True Then
                        If dt.Rows(0).Item("SupContact").ToString.Trim = "" Or dt.Rows(0).Item("SupContact").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupContact").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If

                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupName").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If

                    If RBAllAddress.Checked = True Then
                        If dt.Rows(0).Item("SupContact").ToString.Trim = "" Or dt.Rows(0).Item("SupContact").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupName").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupContact").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = dt.Rows(0).Item("SupName").ToString
                        End If
                    End If
                    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("SupAddress").ToString
                    dGiftCusMany.Rows(i).Item("TelRec") = dt.Rows(0).Item("SupContactTel").ToString

                Next

                mdCnOpen2()
                sCommand.CommandText = "SELECT CompName ,Address,Tel  FROM dCompany WHERE idComp = " + sIdComp.ToString
                sAdapter.Fill(sDt_Temp)

                Dim CompName As String = sDt_Temp.Rows(0).Item("CompName")
                Dim CompAddress As String = sDt_Temp.Rows(0).Item("Address")
                Dim pTel As String = sDt_Temp.Rows(0).Item("Tel")
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_ptPsSend.ParameterFieldName, "")
                vRpt.SetParameterValue(vRpt.Parameter_ptSendCompb.ParameterFieldName, CompName)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendAddress.ParameterFieldName, CompAddress)
                vRpt.SetParameterValue(vRpt.Parameter_ptSendTel.ParameterFieldName, pTel)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case Process
            Case eProcess.eDataSet1
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                mdLoadShow()
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCardA4
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1

                    If RBAdress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString + " และครอบครัว"
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If
                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If

                    If RBAllAddress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString + " และครอบครัว"
                        End If
                    End If

                    Dim sDt_Temp As New DataTable
                    Dim sDt_Temp2 As New DataTable
                    mdCnOpen()
                    sCommand.CommandText = "Select C.AddressS,C.Address,C.AdNumS, C.AdVillageS, C.AdBuildingS, C.AdFloorS, C.AdRoomS, C.AdSoiS, C.AdMhooS, C.AdRoadS, P.PvName AS PvNameS , A.ApName AS ApNameS , T.TbName AS TbNameS, T.PostCode AS PostCodeS,C.stAddress FROM dbo.dCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS P ON C.idPvS = P.idPv LEFT OUTER JOIN dbo.dAp AS A ON C.idApS = A.idAp LEFT OUTER JOIN dbo.dTb AS T ON C.idTbS = T.idTb WHERE C.idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(sDt_Temp)
                    sCommand.CommandText = "Select C.AdNum, C.AdVillage, C.AdBuilding, C.AdFloor, C.AdRoom, C.AdSoi, C.AdMhoo, C.AdRoad, P.PvName, A.ApName, T.TbName, T.PostCode FROM dbo.dCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS P ON C.idPv = P.idPv LEFT OUTER JOIN dbo.dAp AS A ON C.idAp = A.idAp LEFT OUTER JOIN dbo.dTb AS T ON C.idTb = T.idTb WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(sDt_Temp2)
                    Dim AdNum As String
                    Dim AdVillage As String
                    Dim AdBuilding As String
                    Dim AdFloor As String
                    Dim AdRoom As String
                    Dim AdSoi As String
                    Dim AdMhoo As String
                    Dim AdRoad As String
                    Dim PvName As String
                    Dim ApName As String
                    Dim TbName As String
                    Dim PostCode As String
                    'Dim AddressRecEng As String

                    If sDt_Temp.Rows(i).Item("stAddress") <> "4" Then
                        AdNum = CHKAddress(sDt_Temp, sDt_Temp2, "AdNum")
                        AdVillage = CHKAddress(sDt_Temp, sDt_Temp2, "AdVillage")
                        AdBuilding = CHKAddress(sDt_Temp, sDt_Temp2, "AdBuilding")
                        AdFloor = CHKAddress(sDt_Temp, sDt_Temp2, "AdFloor")
                        AdRoom = CHKAddress(sDt_Temp, sDt_Temp2, "AdRoom")
                        AdSoi = CHKAddress(sDt_Temp, sDt_Temp2, "AdSoi")
                        AdMhoo = CHKAddress(sDt_Temp, sDt_Temp2, "AdMhoo")
                        AdRoad = CHKAddress(sDt_Temp, sDt_Temp2, "AdRoad")
                        PvName = CHKAddress(sDt_Temp, sDt_Temp2, "PvName")
                        ApName = CHKAddress(sDt_Temp, sDt_Temp2, "ApName")
                        TbName = CHKAddress(sDt_Temp, sDt_Temp2, "TbName")
                        PostCode = CHKAddress(sDt_Temp, sDt_Temp2, "PostCode")
                        Dim array_temp As New ArrayList
                        Dim AddressRec1 As String = ""
                        Dim AddressRec2 As String = ""
                        Dim AddressRec3 As String = ""
                        Dim AddressRec4 As String = ""

                        If AdNum <> "-" Then
                            array_temp.Add("เลขที่ " + AdNum.Trim)
                            AddressRec1 += "เลขที่ " + AdNum.Trim + " "
                        End If
                        'If AdBuilding <> "-" Then
                        '    array_temp.Add("อาคาร " + AdBuilding.Trim)
                        'End If
                        'If AdFloor <> "-" Then
                        '    array_temp.Add("ชั้น " + AdFloor.Trim)
                        'End If
                        'If AdRoom <> "-" Then
                        '    array_temp.Add("ห้อง " + AdRoom.Trim)
                        'End If
                        'If AdVillage <> "-" Then
                        '    array_temp.Add("หมู่บ้าน " + AdVillage.Trim)
                        'End If
                        If AdMhoo <> "-" Then
                            array_temp.Add("หมู่ " + AdMhoo.Trim)
                            AddressRec1 += "หมู่ " + AdMhoo.Trim + " "
                        End If
                        If AdSoi <> "-" Then
                            array_temp.Add("ซอย " + AdSoi.Trim)
                            AddressRec1 += "ซอย " + AdSoi.Trim + " "
                        End If
                        If AdRoad <> "-" Then
                            array_temp.Add("ถนน " + AdRoad.Trim)
                            AddressRec1 += "ถนน " + AdRoad.Trim + " "
                        End If
                        If TbName <> "-" Then
                            If PvName.Trim = "กรุงเทพมหานคร" Then
                                array_temp.Add("แขวง " + TbName.Trim)
                                AddressRec2 += "แขวง " + TbName.Trim + " "
                            Else
                                array_temp.Add("ตำบล " + TbName.Trim)
                                AddressRec2 += "ตำบล " + TbName.Trim + " "
                            End If
                        End If
                        If ApName <> "-" Then
                            If PvName.Trim = "กรุงเทพมหานคร" Then
                                array_temp.Add(ApName.Trim)
                                AddressRec2 += ApName.Trim + " "
                            Else
                                array_temp.Add("อำเภอ " + ApName.Trim)
                                AddressRec2 += "อำเภอ " + ApName.Trim + " "
                            End If

                        End If
                        If PvName <> "-" Then
                            If PvName.Trim = "กรุงเทพมหานคร" Then
                                array_temp.Add(PvName.Trim)
                                AddressRec3 += PvName.Trim + " "
                            Else
                                array_temp.Add("จังหวัด " + PvName.Trim)
                                AddressRec3 += "จังหวัด " + PvName.Trim + " "
                            End If

                        End If
                        If PostCode <> "-" Then
                            array_temp.Add(PostCode.Trim)
                            AddressRec3 += PostCode.Trim + " "
                        End If

                        Dim lentAddress1 As Integer = 30
                        Dim lentAddress2 As Integer = 30
                        Dim lentAddress3 As Integer = 30
                        Dim lentAddress4 As Integer = 30

                        'For j As Integer = 0 To array_temp.Count - 1
                        '    Dim strlent As Integer = array_temp(j).ToString.Length
                        '    If lentAddress1 > 0 And strlent < lentAddress1 Then
                        '        AddressRec1 += array_temp(j) + " "
                        '        lentAddress1 = lentAddress1 - strlent
                        '    Else
                        '        lentAddress1 = 0
                        '        If lentAddress2 > 0 And strlent < lentAddress2 Then
                        '            AddressRec2 += array_temp(j) + " "
                        '            lentAddress2 = lentAddress2 - strlent
                        '        Else
                        '            lentAddress2 = 0
                        '            If lentAddress3 > 0 And strlent < lentAddress3 Then
                        '                AddressRec3 += array_temp(j) + " "
                        '                lentAddress3 = lentAddress3 - strlent
                        '            Else
                        '                lentAddress3 = 0
                        '                If lentAddress4 > 0 And strlent < lentAddress4 Then
                        '                    AddressRec4 += array_temp(j) + " "
                        '                    lentAddress4 = lentAddress4 - strlent
                        '                End If
                        '            End If
                        '        End If
                        '    End If
                        'Next
                        'Dim AddressRec1 As String = "เลขที่ " + AdNum + " อาคาร  " + AdBuilding + " ชั้น " + AdFloor + " ห้อง " + AdRoom + " "
                        'Dim AddressRec2 As String = "หมู่บ้าน " + AdVillage + " หมู่ " + AdMhoo + " ซ. " + AdSoi + " ถ. " + AdRoad
                        'Dim AddressRec3 As String
                        'Dim AddressRec4 As String

                        'If PvName.Trim = "กรุงเทพมหานคร" Then
                        '    AddressRec3 = "แขวง " + TbName + " " + ApName
                        '    AddressRec4 = PvName + " " + PostCode
                        'Else
                        '    AddressRec3 = "ต. " + TbName + "อ. " + ApName
                        '    AddressRec4 = "จ. " + PvName + " " + PostCode
                        'End If

                        dGiftCusMany.Rows(i).Item("AddressRec1") = AddressRec1
                        dGiftCusMany.Rows(i).Item("AddressRec2") = AddressRec2
                        dGiftCusMany.Rows(i).Item("AddressRec3") = AddressRec3
                        dGiftCusMany.Rows(i).Item("AddressRec4") = AddressRec4
                    Else

                        '    If sDt_Temp.Rows(i).Item("AddressS") Is DBNull.Value Or sDt_Temp.Rows(i).Item("AddressS") = "" Then
                        '        AddressRecEng = sDt_Temp.Rows(i).Item("AddressS")
                        '    Else
                        '        AddressRecEng = sDt_Temp.Rows(i).Item("Address")
                        '    End If
                        '    Dim AddressRec1 As String = AddressRecEng
                        '    Dim AddressRec2 As String = ""
                        '    Dim AddressRec3 As String = ""
                        '    Dim AddressRec4 As String = ""

                        '    dGiftCusMany.Rows(i).Item("AddressRec1") = AddressRec1
                        '    dGiftCusMany.Rows(i).Item("AddressRec2") = AddressRec2
                        '    dGiftCusMany.Rows(i).Item("AddressRec3") = AddressRec3
                        '    dGiftCusMany.Rows(i).Item("AddressRec4") = AddressRec4
                        '    head2 = ""
                        '    head = "To"
                    End If
                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()


                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_head.ParameterFieldName, head)
                vRpt.SetParameterValue(vRpt.Parameter_head2.ParameterFieldName, head2)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            Case eProcess.eDataSet2
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                mdLoadShow()
                If dGiftCusMany.Rows.Count = 0 Then
                    MessageBox.Show("ไม่มีข้อมูลสำหรับแสดงเอกสาร", sSystemName)
                    Exit Sub
                End If

                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    mdCnOpen()
                    Dim dt As New DataTable
                    Dim dt2 As New DataTable
                    Dim dt3 As New DataTable
                    dt.Clear()
                    dt2.Clear()
                    dt3.Clear()
                    sCommand.CommandText = "Select CusNameCon_, CusName_, Tel FROM vCustomer WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt3)
                    sCommand.CommandText = "Select C.AdNumS, C.AdVillageS, C.AdBuildingS, C.AdFloorS, C.AdRoomS, " & _
                                            "C.AdSoiS, C.AdMhooS, C.AdRoadS, P.PvName AS PvNameS , A.ApName AS ApNameS, " & _
                                            "T.TbName AS TbNameS, T.PostCode AS PostCodeS FROM dbo.dCustomer AS C " & _
                                            "LEFT OUTER JOIN dbo.dProvinceFixSale AS P ON C.idPvS = P.idPv " & _
                                            "LEFT OUTER JOIN dbo.dAp AS A ON C.idApS = A.idAp LEFT OUTER JOIN " & _
                                            "dbo.dTb AS T ON C.idTbS = T.idTb WHERE C.idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt)
                    sCommand.CommandText = "Select C.stAddress,C.AddressS,C.Address,C.AdNum, C.AdVillage, C.AdBuilding, C.AdFloor, C.AdRoom, " & _
                                            "C.AdSoi, C.AdMhoo, C.AdRoad, P.PvName, A.ApName, T.TbName, T.PostCode " & _
                                            "FROM dbo.dCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS P " & _
                                            "ON C.idPv = P.idPv LEFT OUTER JOIN dbo.dAp AS A ON C.idAp = A.idAp " & _
                                            "LEFT OUTER JOIN dbo.dTb AS T ON C.idTb = T.idTb " & _
                                            "WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt2)

                    '----Check CusName or CompName----'
                    If Me.RBAdress.Checked = True Then
                        If dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "" Or dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusNameCon_") + " และครอบครัว"
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If
                    If Me.RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusName_")
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If
                    If Me.RBAllAddress.Checked = True Then
                        If dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "" Or dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusName_")
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusNameCon_") + " และครอบครัว"
                            dGiftCusMany.Rows(i).Item("CompRec") = dt3.Rows(0).Item("CusName_")
                        End If
                    End If

                    '----Check Address-------'
                    'If Trim(dt.Rows(0).Item("AddressS")) = "" Then
                    '    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
                    'ElseIf IsDBNull(dt.Rows(0).Item("AddressS")) Then
                    '    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
                    'Else
                    '    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("AddressS")
                    'End If
                    Dim AdNum As String
                    Dim AdVillage As String
                    Dim AdBuilding As String
                    Dim AdFloor As String
                    Dim AdRoom As String
                    Dim AdSoi As String
                    Dim AdMhoo As String
                    Dim AdRoad As String
                    Dim PvName As String
                    Dim ApName As String
                    Dim TbName As String
                    Dim PostCode As String

                    'Dim AddressRecEng As String

                    If dt2.Rows(0).Item("stAddress") <> "4" Then
                        AdNum = CHKAddress(dt, dt2, "AdNum")
                        AdVillage = CHKAddress(dt, dt2, "AdVillage")
                        AdBuilding = CHKAddress(dt, dt2, "AdBuilding")
                        AdFloor = CHKAddress(dt, dt2, "AdFloor")
                        AdRoom = CHKAddress(dt, dt2, "AdRoom")
                        AdSoi = CHKAddress(dt, dt2, "AdSoi")
                        AdMhoo = CHKAddress(dt, dt2, "AdMhoo")
                        AdRoad = CHKAddress(dt, dt2, "AdRoad")
                        PvName = CHKAddress(dt, dt2, "PvName")
                        ApName = CHKAddress(dt, dt2, "ApName")
                        TbName = CHKAddress(dt, dt2, "TbName")
                        PostCode = CHKAddress(dt, dt2, "PostCode")
                        Dim array_temp As New ArrayList
                        Dim AddressRec1 As String = ""
                        Dim AddressRec2 As String = ""
                        Dim AddressRec3 As String = ""
                        Dim AddressRec4 As String = ""

                        If AdNum <> "-" Then
                            array_temp.Add("เลขที่ " + AdNum.Trim)
                            AddressRec1 += "เลขที่ " + AdNum.Trim + " "
                        End If
                        'If AdBuilding <> "-" Then
                        '    array_temp.Add("อาคาร " + AdBuilding.Trim)
                        'End If
                        'If AdFloor <> "-" Then
                        '    array_temp.Add("ชั้น " + AdFloor.Trim)
                        'End If
                        'If AdRoom <> "-" Then
                        '    array_temp.Add("ห้อง " + AdRoom.Trim)
                        'End If
                        'If AdVillage <> "-" Then
                        '    array_temp.Add("หมู่บ้าน " + AdVillage.Trim)
                        'End If
                        If AdMhoo <> "-" Then
                            array_temp.Add("หมู่ " + AdMhoo.Trim)
                            AddressRec1 += "หมู่ " + AdMhoo.Trim + " "
                        End If
                        If AdSoi <> "-" Then
                            array_temp.Add("ซอย " + AdSoi.Trim)
                            AddressRec1 += "ซอย " + AdSoi.Trim + " "
                        End If
                        If AdRoad <> "-" Then
                            array_temp.Add("ถนน " + AdRoad.Trim)
                            AddressRec1 += "ถนน " + AdRoad.Trim + " "
                        End If
                        If TbName <> "-" Then
                            If PvName.Trim = "กรุงเทพมหานคร" Then
                                array_temp.Add("แขวง " + TbName.Trim)
                                AddressRec2 += "แขวง " + TbName.Trim + " "
                            Else
                                array_temp.Add("ตำบล " + TbName.Trim)
                                AddressRec2 += "ตำบล " + TbName.Trim + " "
                            End If
                        End If
                        If ApName <> "-" Then
                            If PvName.Trim = "กรุงเทพมหานคร" Then
                                array_temp.Add(ApName.Trim)
                                AddressRec2 += ApName.Trim + " "
                            Else
                                array_temp.Add("อำเภอ " + ApName.Trim)
                                AddressRec2 += "อำเภอ " + ApName.Trim + " "
                            End If

                        End If
                        If PvName <> "-" Then
                            If PvName.Trim = "กรุงเทพมหานคร" Then
                                array_temp.Add(PvName.Trim)
                                AddressRec3 += PvName.Trim + " "
                            Else
                                array_temp.Add("จังหวัด " + PvName.Trim)
                                AddressRec3 += "จังหวัด " + PvName.Trim + " "
                            End If

                        End If
                        If PostCode <> "-" Then
                            array_temp.Add(PostCode.Trim)
                            AddressRec3 += PostCode.Trim + " "
                        End If

                        Dim lentAddress1 As Integer = 30
                        Dim lentAddress2 As Integer = 30
                        Dim lentAddress3 As Integer = 30
                        Dim lentAddress4 As Integer = 30

                        'For j As Integer = 0 To array_temp.Count - 1
                        '    Dim strlent As Integer = array_temp(j).ToString.Length
                        '    If lentAddress1 > 0 And strlent < lentAddress1 Then
                        '        AddressRec1 += array_temp(j) + " "
                        '        lentAddress1 = lentAddress1 - strlent
                        '    Else
                        '        lentAddress1 = 0
                        '        If lentAddress2 > 0 And strlent < lentAddress2 Then
                        '            AddressRec2 += array_temp(j) + " "
                        '            lentAddress2 = lentAddress2 - strlent
                        '        Else
                        '            lentAddress2 = 0
                        '            If lentAddress3 > 0 And strlent < lentAddress3 Then
                        '                AddressRec3 += array_temp(j) + " "
                        '                lentAddress3 = lentAddress3 - strlent
                        '            Else
                        '                lentAddress3 = 0
                        '                If lentAddress4 > 0 And strlent < lentAddress4 Then
                        '                    AddressRec4 += array_temp(j) + " "
                        '                    lentAddress4 = lentAddress4 - strlent
                        '                End If
                        '            End If
                        '        End If
                        '    End If
                        'Next
                        'Dim AddressRec1 As String = "เลขที่ " + AdNum + " อาคาร  " + AdBuilding + " ชั้น " + AdFloor + " ห้อง " + AdRoom + " "
                        'Dim AddressRec2 As String = "หมู่บ้าน " + AdVillage + " หมู่ " + AdMhoo + " ซ. " + AdSoi + " ถ. " + AdRoad
                        'Dim AddressRec3 As String
                        'Dim AddressRec4 As String

                        'If PvName.Trim = "กรุงเทพมหานคร" Then
                        '    AddressRec3 = "แขวง " + TbName + " " + ApName
                        '    AddressRec4 = PvName + " " + PostCode
                        'Else
                        '    AddressRec3 = "ต. " + TbName + "อ. " + ApName
                        '    AddressRec4 = "จ. " + PvName + " " + PostCode
                        'End If

                        dGiftCusMany.Rows(i).Item("AddressRec1") = AddressRec1
                        dGiftCusMany.Rows(i).Item("AddressRec2") = AddressRec2
                        dGiftCusMany.Rows(i).Item("AddressRec3") = AddressRec3
                        dGiftCusMany.Rows(i).Item("AddressRec4") = AddressRec4
                    Else

                        'If dt2.Rows(0).Item("AddressS") Is DBNull.Value Or dt2.Rows(0).Item("AddressS").ToString.Trim = "" Then
                        '    AddressRecEng = dt2.Rows(0).Item("Address")
                        'Else
                        '    AddressRecEng = dt2.Rows(0).Item("AddressS")
                        'End If
                        'Dim AddressRec1 As String = AddressRecEng
                        'Dim AddressRec2 As String = ""
                        'Dim AddressRec3 As String = ""
                        'Dim AddressRec4 As String = ""

                        'dGiftCusMany.Rows(i).Item("AddressRec1") = AddressRec1
                        'dGiftCusMany.Rows(i).Item("AddressRec2") = AddressRec2
                        'dGiftCusMany.Rows(i).Item("AddressRec3") = AddressRec3
                        'dGiftCusMany.Rows(i).Item("AddressRec4") = AddressRec4
                        'head2 = ""
                        'head = "To"
                    End If
                    '---Tel----'
                    dGiftCusMany.Rows(i).Item("TelRec") = dt3.Rows(0).Item("Tel")
                Next

                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCardA4
                Dim sDt_Temp As New DataTable

                mdCnOpen2()
                sCommand.CommandText = "SELECT CompName ,Address,Tel  FROM dCompany WHERE idComp = " + sIdComp.ToString
                sAdapter.Fill(sDt_Temp)

                Dim CompName As String = sDt_Temp.Rows(0).Item("CompName")
                Dim CompAddress As String = sDt_Temp.Rows(0).Item("Address")
                Dim pTel As String = sDt_Temp.Rows(0).Item("Tel")
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_head.ParameterFieldName, head)
                vRpt.SetParameterValue(vRpt.Parameter_head2.ParameterFieldName, head2)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            Case eProcess.eDataSet3
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCardA4
                Dim sDt_Temp As New DataTable
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    If RBAdress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If
                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If

                    If RBAllAddress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString
                        End If
                    End If
                    dGiftCusMany.Rows(i).Item("AddressRec1") = dGiftCusMany.Rows(i).Item("AddressRec")
                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_head.ParameterFieldName, head)
                vRpt.SetParameterValue(vRpt.Parameter_head2.ParameterFieldName, head2)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            Case eProcess.eDataSet4
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCardA4
                Dim sDt_Temp As New DataTable


                If dGiftCusMany.Rows.Count = 0 Then
                    MessageBox.Show("ไม่มีข้อมูลสำหรับแสดงเอกสาร", sSystemName)
                    Exit Sub
                End If

                mdCnOpen2()
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim dt As New DataTable
                    dt.Clear()
                    sCommand.CommandText = "Select SupName, SupAddress, SupContact, SupContactTel FROM vSupplier WHERE idSup = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt)

                    If RBAdress.Checked = True Then
                        If dt.Rows(0).Item("SupContact").ToString.Trim = "" Or dt.Rows(0).Item("SupContact").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupContact").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If

                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupName").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If

                    If RBAllAddress.Checked = True Then
                        If dt.Rows(0).Item("SupContact").ToString.Trim = "" Or dt.Rows(0).Item("SupContact").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupName").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupContact").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = dt.Rows(0).Item("SupName").ToString
                        End If
                    End If
                    dGiftCusMany.Rows(i).Item("AddressRec1") = dt.Rows(0).Item("SupAddress").ToString
                    dGiftCusMany.Rows(i).Item("TelRec") = dt.Rows(0).Item("SupContactTel").ToString

                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_head.ParameterFieldName, head)
                vRpt.SetParameterValue(vRpt.Parameter_head2.ParameterFieldName, head2)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Select Case Process
            Case eProcess.eDataSet1
                mdLoadShow()
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCardA4Eng
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1

                    If RBAdress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString + " และครอบครัว"
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If
                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If

                    If RBAllAddress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString + " และครอบครัว"
                        End If
                    End If

                    Dim sDt_Temp As New DataTable
                    Dim sDt_Temp2 As New DataTable
                    mdCnOpen()
                    sCommand.CommandText = "Select C.AddressS,C.Address,C.AdNumS, C.AdVillageS, C.AdBuildingS, C.AdFloorS, C.AdRoomS, C.AdSoiS, C.AdMhooS, C.AdRoadS, P.PvName AS PvNameS , A.ApName AS ApNameS , T.TbName AS TbNameS, T.PostCode AS PostCodeS,C.stAddress FROM dbo.dCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS P ON C.idPvS = P.idPv LEFT OUTER JOIN dbo.dAp AS A ON C.idApS = A.idAp LEFT OUTER JOIN dbo.dTb AS T ON C.idTbS = T.idTb WHERE C.idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(sDt_Temp)
                    sCommand.CommandText = "Select C.AdNum, C.AdVillage, C.AdBuilding, C.AdFloor, C.AdRoom, C.AdSoi, C.AdMhoo, C.AdRoad, P.PvName, A.ApName, T.TbName, T.PostCode FROM dbo.dCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS P ON C.idPv = P.idPv LEFT OUTER JOIN dbo.dAp AS A ON C.idAp = A.idAp LEFT OUTER JOIN dbo.dTb AS T ON C.idTb = T.idTb WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(sDt_Temp2)
                    Dim AddressRecEng As String



                    If sDt_Temp.Rows(i).Item("AddressS") Is DBNull.Value Or sDt_Temp.Rows(i).Item("AddressS") = "" Then
                        AddressRecEng = sDt_Temp.Rows(i).Item("AddressS")
                    Else
                        AddressRecEng = sDt_Temp.Rows(i).Item("Address")
                    End If
                    Dim AddressRec1 As String = AddressRecEng
                    Dim AddressRec2 As String = ""
                    Dim AddressRec3 As String = ""
                    Dim AddressRec4 As String = ""

                    dGiftCusMany.Rows(i).Item("AddressRec1") = AddressRec1
                    dGiftCusMany.Rows(i).Item("AddressRec2") = AddressRec2
                    dGiftCusMany.Rows(i).Item("AddressRec3") = AddressRec3
                    dGiftCusMany.Rows(i).Item("AddressRec4") = AddressRec4

                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()


                vRpt.SetDataSource(dGiftCusMany)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            Case eProcess.eDataSet2
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                mdLoadShow()
                If dGiftCusMany.Rows.Count = 0 Then
                    MessageBox.Show("ไม่มีข้อมูลสำหรับแสดงเอกสาร", sSystemName)
                    Exit Sub
                End If

                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    mdCnOpen()
                    Dim dt As New DataTable
                    Dim dt2 As New DataTable
                    Dim dt3 As New DataTable
                    dt.Clear()
                    dt2.Clear()
                    dt3.Clear()
                    sCommand.CommandText = "Select CusNameCon_, CusName_, Tel FROM vCustomer WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt3)
                    sCommand.CommandText = "Select C.AdNumS, C.AdVillageS, C.AdBuildingS, C.AdFloorS, C.AdRoomS, " & _
                                            "C.AdSoiS, C.AdMhooS, C.AdRoadS, P.PvName AS PvNameS , A.ApName AS ApNameS, " & _
                                            "T.TbName AS TbNameS, T.PostCode AS PostCodeS FROM dbo.dCustomer AS C " & _
                                            "LEFT OUTER JOIN dbo.dProvinceFixSale AS P ON C.idPvS = P.idPv " & _
                                            "LEFT OUTER JOIN dbo.dAp AS A ON C.idApS = A.idAp LEFT OUTER JOIN " & _
                                            "dbo.dTb AS T ON C.idTbS = T.idTb WHERE C.idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt)
                    sCommand.CommandText = "Select C.stAddress,C.AddressS,C.Address,C.AdNum, C.AdVillage, C.AdBuilding, C.AdFloor, C.AdRoom, " & _
                                            "C.AdSoi, C.AdMhoo, C.AdRoad, P.PvName, A.ApName, T.TbName, T.PostCode " & _
                                            "FROM dbo.dCustomer AS C LEFT OUTER JOIN dbo.dProvinceFixSale AS P " & _
                                            "ON C.idPv = P.idPv LEFT OUTER JOIN dbo.dAp AS A ON C.idAp = A.idAp " & _
                                            "LEFT OUTER JOIN dbo.dTb AS T ON C.idTb = T.idTb " & _
                                            "WHERE idCus = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt2)

                    '----Check CusName or CompName----'
                    If Me.RBAdress.Checked = True Then
                        If dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "" Or dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusNameCon_") + " และครอบครัว"
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If
                    If Me.RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusName_")
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If
                    If Me.RBAllAddress.Checked = True Then
                        If dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "" Or dt3.Rows(0).Item("CusNameCon_").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusName_")
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt3.Rows(0).Item("CusNameCon_") + " และครอบครัว"
                            dGiftCusMany.Rows(i).Item("CompRec") = dt3.Rows(0).Item("CusName_")
                        End If
                    End If

                    '----Check Address-------'
                    'If Trim(dt.Rows(0).Item("AddressS")) = "" Then
                    '    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
                    'ElseIf IsDBNull(dt.Rows(0).Item("AddressS")) Then
                    '    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("Address")
                    'Else
                    '    dGiftCusMany.Rows(i).Item("AddressRec") = dt.Rows(0).Item("AddressS")
                    'End If
                    Dim AddressRecEng As String



                    If dt2.Rows(0).Item("AddressS") Is DBNull.Value Or dt2.Rows(0).Item("AddressS").ToString.Trim = "" Then
                        AddressRecEng = dt2.Rows(0).Item("Address")
                    Else
                        AddressRecEng = dt2.Rows(0).Item("AddressS")
                    End If
                    Dim AddressRec1 As String = AddressRecEng
                    Dim AddressRec2 As String = ""
                    Dim AddressRec3 As String = ""
                    Dim AddressRec4 As String = ""

                    dGiftCusMany.Rows(i).Item("AddressRec1") = AddressRec1
                    dGiftCusMany.Rows(i).Item("AddressRec2") = AddressRec2
                    dGiftCusMany.Rows(i).Item("AddressRec3") = AddressRec3
                    dGiftCusMany.Rows(i).Item("AddressRec4") = AddressRec4
                    '---Tel----'
                    dGiftCusMany.Rows(i).Item("TelRec") = dt3.Rows(0).Item("Tel")
                Next

                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCardA4Eng
                Dim sDt_Temp As New DataTable

                mdCnOpen2()
                sCommand.CommandText = "SELECT CompName ,Address,Tel  FROM dCompany WHERE idComp = " + sIdComp.ToString
                sAdapter.Fill(sDt_Temp)

                Dim CompName As String = sDt_Temp.Rows(0).Item("CompName")
                Dim CompAddress As String = sDt_Temp.Rows(0).Item("Address")
                Dim pTel As String = sDt_Temp.Rows(0).Item("Tel")
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            Case eProcess.eDataSet3
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCardA4Eng
                Dim sDt_Temp As New DataTable
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    If RBAdress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If
                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If

                    If RBAllAddress.Checked = True Then
                        If dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "" Or dGiftCusMany.Rows(i).Item("PsRec").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("CompRec").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString
                        End If
                    End If
                    dGiftCusMany.Rows(i).Item("AddressRec1") = dGiftCusMany.Rows(i).Item("AddressRec")
                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next
                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
            Case eProcess.eDataSet4
                Dim head As String = "แด่"
                Dim head2 As String = "ส.ค.ส."
                Dim vFrm As New FrmReportView
                Dim vRpt As New crpMkGiftGreetingCardA4Eng
                Dim sDt_Temp As New DataTable

                If dGiftCusMany.Rows.Count = 0 Then
                    MessageBox.Show("ไม่มีข้อมูลสำหรับแสดงเอกสาร", sSystemName)
                    Exit Sub
                End If

                mdCnOpen2()

                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim dt As New DataTable
                    dt.Clear()

                    sCommand.CommandText = "Select SupName, SupAddress, SupContact, SupContactTel FROM vSupplier WHERE idSup = '" & dGiftCusMany.Rows(i).Item("idCus") & "'"
                    sAdapter.Fill(dt)

                    If RBAdress.Checked = True Then
                        If dt.Rows(0).Item("SupContact").ToString.Trim = "" Or dt.Rows(0).Item("SupContact").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupContact").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        End If
                    End If

                    If RBAdress2.Checked = True Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupName").ToString
                        dGiftCusMany.Rows(i).Item("CompRec") = ""
                    End If

                    If RBAllAddress.Checked = True Then
                        If dt.Rows(0).Item("SupContact").ToString.Trim = "" Or dt.Rows(0).Item("SupContact").ToString.Trim = "-" Then
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupName").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = ""
                        Else
                            dGiftCusMany.Rows(i).Item("PsRec") = dt.Rows(0).Item("SupContact").ToString
                            dGiftCusMany.Rows(i).Item("CompRec") = dt.Rows(0).Item("SupName").ToString
                        End If
                    End If
                    dGiftCusMany.Rows(i).Item("AddressRec1") = dt.Rows(0).Item("SupAddress").ToString
                    dGiftCusMany.Rows(i).Item("TelRec") = dt.Rows(0).Item("SupContactTel").ToString

                Next
                For i As Integer = 0 To dGiftCusMany.Rows.Count - 1
                    Dim strchk As String = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(0, 1)
                    If strchk = "-" Then
                        dGiftCusMany.Rows(i).Item("PsRec") = dGiftCusMany.Rows(i).Item("PsRec").ToString.Substring(2)
                    End If
                Next

                mdLoadCommitt()

                vRpt.SetDataSource(dGiftCusMany)
                vRpt.SetParameterValue(vRpt.Parameter_head.ParameterFieldName, head)
                vRpt.SetParameterValue(vRpt.Parameter_head2.ParameterFieldName, head2)
                vFrm.crView.ReportSource = vRpt
                vFrm.Show()
        End Select
    End Sub

    Private Sub frmMkGiftDocSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Process
            Case eProcess.eDataSet1
                dGiftCusMany.Columns.Add("AddressRec1", System.Type.GetType("System.String"))
                dGiftCusMany.Columns.Add("AddressRec2", System.Type.GetType("System.String"))
                dGiftCusMany.Columns.Add("AddressRec3", System.Type.GetType("System.String"))
                dGiftCusMany.Columns.Add("AddressRec4", System.Type.GetType("System.String"))
            Case eProcess.eDataSet3
                dGiftCusMany.Columns.Add("AddressRec1", System.Type.GetType("System.String"))
                dGiftCusMany.Columns.Add("AddressRec2", System.Type.GetType("System.String"))
                dGiftCusMany.Columns.Add("AddressRec3", System.Type.GetType("System.String"))
                dGiftCusMany.Columns.Add("AddressRec4", System.Type.GetType("System.String"))
        End Select

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Dim str As String = sHost & sFtpPathMain & "Font/SarunManorah.ttf"
        'mdLoadShow()
        ''frm.Get_UrlImg(str, Lv3.Items(Lv3.FocusedItem.Index).ImageKey)
        ''frm.ShowDialog()
        ''System.Diagnostics.Process.Start(str)
        'My.Computer.Network.DownloadFile(str, "SarunManorah.ttf")
        'Dim myProcess As Process = System.Diagnostics.Process.Start("SarunManorah.ttf")
        'While Not myProcess.HasExited
        '    myProcess.Refresh()
        'End While
        'System.IO.File.Delete("SarunManorah.ttf")
        'mdLoadCommitt()
        'Dim myProcess As Process = System.Diagnostics.Process.Start("SarunManorah.ttf")
        'While Not myProcess.HasExited
        '    myProcess.Refresh()
        'End While
        Dim webAddress As String = "www." & sHost & sFtpPathMain & "Font/SarunManorah.ttf"
        System.Diagnostics.Process.Start(webAddress)

    End Sub

End Class