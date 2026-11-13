Imports DevExpress.XtraSplashScreen

Public Class FrmJobSelect
    Enum eProcess
        eSelectJob
    End Enum

    Dim stload As Integer = 0
    Dim gidSeasonPd As Integer = 0
    Dim gSeasonName As String = ""
    Dim gdiCompb As Integer = 0
    Dim gCompany As String = ""
    Dim gJobNo As String = ""
    Public dtJobReturn As New DataTable


    Sub New(ByVal aProcess As eProcess, ByVal idSeason As Integer, ByVal SeasonName As String, ByVal idCompb As Integer, _
            ByVal CompanyName As String, ByVal txtJobNo As String)
        InitializeComponent()

        gidSeasonPd = idSeason
        gSeasonName = SeasonName
        gdiCompb = idCompb
        gCompany = CompanyName
        gJobNo = txtJobNo
    End Sub


    Private Sub FrmJobSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdCnOpen()

        initDataTable(dtJobReturn)

        'cmbSeasonCode.SelectedValue = gSeasonCode
        Me.Text = "เลือก Job ในฤดูผลิต " & gSeasonName & " ของ " & gCompany


        mdLoadShow()
        BindData()
        mdLoadCommitt()

        stload = 1

        If Trim(gJobNo) <> "" Then
            chkJobNo.Checked = True
            Me.txtJobNo.Text = gJobNo
        End If
    End Sub

    Private Sub initDataTable(sender As Object)
        sender.Columns.Add("idJob", System.Type.GetType("System.Int64"))
        sender.Columns.Add("JobNo", System.Type.GetType("System.String"))
        sender.Columns.Add("StrainCode", System.Type.GetType("System.String"))
        sender.Columns.Add("Area", System.Type.GetType("System.String"))
        sender.Columns.Add("SeedTypeName", System.Type.GetType("System.String"))
        sender.Columns.Add("PartnerName", System.Type.GetType("System.String"))
        sender.Columns.Add("idPartner", System.Type.GetType("System.Int64"))
        sender.Columns.Add("idFM", System.Type.GetType("System.Int64"))
    End Sub

    Private Sub BindData()

        Dim dt As New DataTable
        sCommand.CommandText = "SELECT mt.idCompb, mt.StrainCode, dt.idJob, dt.JobNo, psCancel.PsFullName As PsCancel, dt.idUserCancel, dt.stCancel, dt.CancelNote, dt.NoteCancelProduce," & vbNewLine & _
                                "z.ZoneName, ps.PsFullName As PsMete, t.SeedTypeName, p.idPartner, p.idFM, " & vbNewLine & _
                                "d.SeasonCode, t.SeedTypeName, p.PartnerName, substring(dt.DateMete,7,2)+'/'+substring(dt.DateMete,5,2)+'/'+substring(dt.DateMete,1,4) As DateMete,   " & vbNewLine & _
                                "CONVERT(nvarchar, dt.MeteRai) + ' ไร่  ' + CONVERT(nvarchar, dt.MeteNgan) + ' งาน' As Area, dt.RecSeedsKg, dt.stWeightUpdate" & vbNewLine & _
                                "FROM PdIndexJobDt  dt " & vbNewLine & _
                                "LEFT JOIN dFarmer f ON dt.idFM = f.idFM " & vbNewLine & _
                                "LEFT JOIN dPartner p ON f.idFM = p.idFM " & vbNewLine & _
                                "LEFT JOIN dZone z ON f.idZone = z.idZone " & vbNewLine & _
                                "LEFT JOIN dAumphur a ON z.idAp = a.idAp  " & vbNewLine & _
                                "LEFT JOIN dProvinceFix px ON z.idProvince = px.idProvince " & vbNewLine & _
                                "LEFT JOIN vPersonxSelect ps ON dt.idPs = ps.idPs " & vbNewLine & _
                                "LEFT JOIN PdIndexMt mt ON dt.idIndex = mt.idIndex " & vbNewLine & _
                                "LEFT JOIN dSeedType t ON mt.idSeedType = t.idSeedType" & vbNewLine & _
                                "LEFT JOIN dSeasonOfProduce d ON mt.idSeasonPd = d.idSeasonPd " & vbNewLine & _
                                "LEFT JOIN vPersonxSelect psCancel ON dt.idUserCancel = psCancel.idPs" & vbNewLine & _
                                "Where mt.idSeasonPd = " & gidSeasonPd & vbNewLine & _
                                "AND mt.idCompb = " & gdiCompb & vbNewLine & _
                                "Order by mt.StrainCode ASC"
        sAdapter.Fill(dt)

        If dt.Rows.Count <= 0 Then
            MessageBox.Show("ไม่พบข้อมูลการเปิด Job ในฤดูผลิต " & gSeasonName & vbCrLf & _
                            "ของ " & gCompany, sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

        GCJob.DataSource = dt
        txtCount.Text = Format(GVJob.DataRowCount, "#,##0")

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        mdCnOpen()
        SplashScreenManager.ShowForm(Me, GetType(WaitFrmPg), True, True)
        BindData()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub fnFilterDataOnGrid()
        Dim StrFilter As String = ""

        If chkJobNo.Checked = True Then
            StrFilter &= " AND [JobNo] Like '%" & txtJobNo.Text.Trim & "%'"
        End If

        If ChkStrainCode.Checked = True Then
            StrFilter &= " AND [StrainCode] Like '%" & txtStrainCode.Text.Trim & "%'"
        End If

        If chkSeed.Checked = True Then
            StrFilter &= " AND [SeedTypeName] Like '%" & txtSeed.Text.Trim & "%'"
        End If

        If chkFarmerName.Checked = True Then
            StrFilter &= " AND [PartnerName] Like '%" & txtFarmerName.Text.Trim & "%'"
        End If


        GVJob.ActiveFilterString = " 1=1" + StrFilter
        txtCount.Text = Format(GVJob.DataRowCount, "#,##0")
    End Sub

    Private Sub GVJob_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVJob.RowCellClick
        If Not IsDBNull(GVJob.GetRowCellValue(GVJob.FocusedRowHandle, "stCancel")) Then
            MessageBox.Show("รายการนี้ได้ถูกยกเลิกแล้ว" & vbCrLf & _
                           "สาเหตุการยกเลิก:  " & GVJob.GetRowCellValue(GVJob.FocusedRowHandle, "CancelNote") & vbCrLf & _
                           "ยกเลิกโดย: " & GVJob.GetRowCellValue(GVJob.FocusedRowHandle, "PsCancel"), sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Not IsDBNull(GVJob.GetRowCellValue(GVJob.FocusedRowHandle, "NoteCancelProduce")) Then
            MessageBox.Show("รายการนี้มีการผลิตล้มเหลว" & vbCrLf & _
                          "สาเหตุ:  " & GVJob.GetRowCellValue(GVJob.FocusedRowHandle, "NoteCancelProduce") & vbCrLf & _
                          "ยกเลิกโดย: " & GVJob.GetRowCellValue(GVJob.FocusedRowHandle, "PsCancel"), sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtStrainCode_TextChanged(sender As Object, e As EventArgs) Handles txtStrainCode.TextChanged, txtFarmerName.TextChanged, txtJobNo.TextChanged, txtSeed.TextChanged
        If stload = 1 Then
            fnFilterDataOnGrid()
        End If
    End Sub

    Private Sub ChkStrainCode_CheckedChanged(sender As Object, e As EventArgs) Handles ChkStrainCode.CheckedChanged
        If stload = 1 Then
            If Me.ChkStrainCode.Checked = True Then
                Me.txtStrainCode.Enabled = True
                Me.txtStrainCode.Focus()
            Else
                Me.txtStrainCode.Enabled = False
                Me.txtStrainCode.Text = ""
            End If
        End If
    End Sub

    Private Sub chkFarmerName_CheckedChanged(sender As Object, e As EventArgs) Handles chkFarmerName.CheckedChanged
        If stload = 1 Then
            If Me.chkFarmerName.Checked = True Then
                Me.txtFarmerName.Enabled = True
                Me.txtFarmerName.Focus()
            Else
                Me.txtFarmerName.Enabled = False
                Me.txtFarmerName.Text = ""
            End If
        End If
    End Sub

    Private Sub chkJobNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkJobNo.CheckedChanged
        If stload = 1 Then
            If Me.chkJobNo.Checked = True Then
                Me.txtJobNo.Enabled = True
                Me.txtJobNo.Focus()
            Else
                Me.txtJobNo.Enabled = False
                Me.txtJobNo.Text = ""
            End If
        End If
    End Sub

    Private Sub chkSeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeed.CheckedChanged
        If stload = 1 Then
            If Me.chkSeed.Checked = True Then
                Me.txtSeed.Enabled = True
                Me.txtSeed.Focus()
            Else
                Me.txtSeed.Enabled = False
                Me.txtSeed.Text = ""
            End If
        End If
    End Sub

    Private Sub rptSelect_Click(sender As Object, e As EventArgs) Handles rptSelect.Click
        Dim dr As DataRow = GVJob.GetDataRow(GVJob.FocusedRowHandle)
        Dim dr_ As DataRow = dtJobReturn.NewRow

        dr_("idJob") = dr("idJob")
        dr_("JobNo") = dr("JobNo")
        dr_("StrainCode") = dr("StrainCode")
        dr_("SeedTypeName") = dr("SeedTypeName")
        dr_("Area") = dr("Area")
        dr_("idFM") = dr("idFM")
        dr_("idPartner") = dr("idPartner")
        dr_("PartnerName") = dr("PartnerName")
    
        dtJobReturn.Rows.Add(dr_)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub GVJob_KeyDown(sender As Object, e As KeyEventArgs) Handles GVJob.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As DataRow = GVJob.GetDataRow(GVJob.FocusedRowHandle)
            Dim dr_ As DataRow = dtJobReturn.NewRow

            dr_("idJob") = dr("idJob")
            dr_("JobNo") = dr("JobNo")
            dr_("StrainCode") = dr("StrainCode")
            dr_("SeedTypeName") = dr("SeedTypeName")
            dr_("Area") = dr("Area")
            dr_("idFM") = dr("idFM")
            dr_("idPartner") = dr("idPartner")
            dr_("PartnerName") = dr("PartnerName")


            dtJobReturn.Rows.Add(dr_)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub
End Class