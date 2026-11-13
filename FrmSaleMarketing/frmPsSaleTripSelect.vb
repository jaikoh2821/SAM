Public Class frmPsSaleTripSelect
    Public idPsSale As String = ""
    Public PsName As String
    Dim checkIdPsSale As Integer = 0
    Public pidTr As String = ""
    Dim sDt3 As New DataTable
    Dim Process As eProcess
    Dim screendata As String = 0
    Enum eProcess
        eSelectRoom
        eSelectReception
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Select Case aProcess
            Case eProcess.eSelectRoom
                screendata = 1
                Process = eProcess.eSelectRoom

            Case eProcess.eSelectReception
                screendata = 2
                Process = eProcess.eSelectReception
        End Select
    End Sub


    Private Sub loadData()
        Dim month As String
        If dtpPsSaleTrip.Value.Month < 10 Then
            month = "0" & dtpPsSaleTrip.Value.Month
        Else
            month = dtpPsSaleTrip.Value.Month
        End If
        Dim strDate As String
        strDate = (dtpPsSaleTrip.Value.Year + 543) & month
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select s.DateTripS,s.DateTripE,p.PvName,a.ApName,s.Note,s.idTrip,s.idProvince,s.idAp,s.idSup,s.stTrip From SmPsTripMt s,dProvinceFixSale p,dAp a WHERE s.idProvince = p.idPv AND s.idAp = a.idAp AND idPsSale = " & idPsSale & " AND substring(s.DateTripS,1,6) = '" & strDate & "' AND s.stTrip = " + screendata + " ORDER BY s.DateTripS,s.DateTripE"
        sAdapter.Fill(sDt)

        sDt.Columns.Add("colStTrip")
        sDt.Columns.Add("colSup")

        If sDt.Rows.Count = 0 Then
            dgvPsSaleTrip.DataSource = sDt
            MessageBox.Show("ไม่มีข้อมูล", sSystemName)

        Else

            mdCnOpen2()
            Dim sDt2 As New DataTable
            sCommand.CommandText = "SELECT idSup,SupName FROM vSupplier"
            sAdapter.Fill(sDt2)

            For i As Integer = 0 To sDt.Rows.Count - 1
                If sDt.Rows(i).Item("stTrip") = "1" Then
                    sDt.Rows(i).Item("colStTrip") = "ที่พัก"
                Else
                    sDt.Rows(i).Item("colStTrip") = "จัดเลี้ยง"
                End If

                For j As Integer = 0 To sDt2.Rows.Count - 1
                    If sDt.Rows(i).Item("idSup") = sDt2.Rows(j).Item("idSup") Then
                        sDt.Rows(i).Item("colSup") = sDt2.Rows(j).Item("SupName")
                    End If
                Next
            Next

            dgvPsSaleTrip.DataSource = sDt
            mdDgvConvertNumberFormat(dgvPsSaleTrip, DateTripS)
            mdDgvConvertNumberFormat(dgvPsSaleTrip, DateTripE)
            dgvPsSaleTrip.ClearSelection()

            mdCnOpen()
            sDt3.Clear()
            sCommand.CommandText = "Select idTrip From SmPsSaleExpenseTs WHERE idPsSale = " & idPsSale
            sAdapter.Fill(sDt3)
            For i As Integer = 0 To dgvPsSaleTrip.Rows.Count - 1
                For j As Integer = 0 To sDt3.Rows.Count - 1
                    If dgvPsSaleTrip.Rows(i).Cells(idTrip.Name).Value.ToString = sDt3.Rows(j).Item("idTrip").ToString Then
                        dgvPsSaleTrip.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                        Dim f As Font = dgvPsSaleTrip.DefaultCellStyle.Font
                        dgvPsSaleTrip.Rows(i).DefaultCellStyle.Font = New Font(f, FontStyle.Strikeout)
                    End If
                Next
            Next
            
        End If
    End Sub

    Private Sub btShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btShow.Click
        loadData()
    End Sub

    Private Sub dgvPsSaleTrip_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPsSaleTrip.CellContentClick
        Dim ans As Integer = 0
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvPsSaleTrip.Columns(e.ColumnIndex).Name = colEdit.Name Then

            For j As Integer = 0 To sDt3.Rows.Count - 1
                If dgvPsSaleTrip.Rows(e.RowIndex).Cells(idTrip.Name).Value.ToString = sDt3.Rows(j).Item("idTrip").ToString Then
                    ans = 1
                End If
            Next
            If ans = 0 Then
                Dim idTr As Integer = dgvPsSaleTrip.Rows(e.RowIndex).Cells(idTrip.Name).Value
                Dim strDateTripS As String = dgvPsSaleTrip.Rows(e.RowIndex).Cells(DateTripS.Name).Value
                Dim strDateTripE As String = dgvPsSaleTrip.Rows(e.RowIndex).Cells(DateTripE.Name).Value
                Dim stTr As String = dgvPsSaleTrip.Rows(e.RowIndex).Cells(stTrip.Name).Value
                Dim supName As String = dgvPsSaleTrip.Rows(e.RowIndex).Cells(colSup.Name).Value
                Dim idP As Integer = dgvPsSaleTrip.Rows(e.RowIndex).Cells(idProvince.Name).Value
                Dim idA As Integer = dgvPsSaleTrip.Rows(e.RowIndex).Cells(idAp.Name).Value
                Dim note As String = dgvPsSaleTrip.Rows(e.RowIndex).Cells(colNote.Name).Value
                Dim idS As Integer = dgvPsSaleTrip.Rows(e.RowIndex).Cells(idSup.Name).Value
                pidTr = idTr
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub dgvPsSaleTrip_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPsSaleTrip.Sorted
        dgvPsSaleTrip.ClearSelection()
    End Sub

    Private Sub frmPsSaleTrip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpPsSaleTrip.Value = Today
        dtpPsSaleTrip.Value = New DateTime(dtpPsSaleTrip.Value.Year, dtpPsSaleTrip.Value.Month, 1)
        loadData()
    End Sub
End Class