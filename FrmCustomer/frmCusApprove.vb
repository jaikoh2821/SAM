Imports System.Net
Imports System.IO

Public Class frmCusApprove
   
    Dim eEvent As eProcess
    Enum eProcess
        ePsAcceptCus
        ePsCheckCus
        ePsApproveCus
    End Enum

    Dim vWhere As String = ""

    Sub New(ByVal aProcess As eProcess)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Select Case aProcess
            Case eProcess.ePsAcceptCus 'รับทราบ
                Text = "รับทราบรายการข้อมูลคู่ค้า"
                vWhere = " WHERE C.idPsAccept IS NULL "
                DgvCusApprove.Columns("col_select").HeaderText = "รับทราบ"
                aProcess = eProcess.ePsAcceptCus
            Case eProcess.ePsCheckCus 'ตรวจสอบ
                Text = "ตรวจสอบรายการข้อมูลคู่ค้า"
                vWhere = " WHERE C.idPsCheck IS NULL "
                DgvCusApprove.Columns("col_select").HeaderText = "ตรวจสอบ"
                aProcess = eProcess.ePsCheckCus
            Case eProcess.ePsApproveCus 'อนุมัติ
                Text = "อนุมัติรายการข้อมูลคู่ค้า"
                vWhere = " WHERE C.idPsApprove IS NULL "
                DgvCusApprove.Columns("col_select").HeaderText = "อนุมัติ"
                aProcess = eProcess.ePsApproveCus
        End Select
        eEvent = aProcess
    End Sub

    Dim sDt As New DataTable

    Private Sub ShowDataOnGrid()
        mdCnOpen()
        sDt.Clear()
        sCommand.CommandText = "SELECT C.CusCode, C.CusName_ As CusName, C.Address, C.Tel, C.TelOffice, C.TelHome, C.Fax, C.Latitude, C.Longitude, C.stBusinessType, " & _
                                "CASE WHEN C.stRight = 0 THEN 'ไม่ถูกหลัก' WHEN C.stRight = 1 THEN 'ถูกหลัก' ELSE 'ยังไม่ได้กำหนด' END As stRightShow, 0 As PicOwner, 0 As PicCard, 0 As PicRegistration, 0 As PicCommercial, C.Note, P1.PsName As PsAccept, C.DateAccept," & _
                                "P2.PsName As PsCheck, C.DateCheck, P3.PsName As PsApprove, C.DateApprive, C.stRight, C.idCus, C.idTsp, C.idPv, C.idAp, C.idTb, '' As chkfullData FROM vCustomer As C LEFT JOIN vPerson As P1 On C.idPsAccept=P1.idPs " & _
                                "LEFT JOIN vPerson As P2 On C.idPsCheck=P2.idPs LEFT JOIN vPerson As P3 On C.idPsApprove=P3.idPs " & vWhere & "  Order By C.CusName"
        sAdapter.Fill(sDt)
        For j As Integer = 0 To sDt.Rows.Count - 1
            If Not IsDBNull(sDt.Rows(j).Item("DateAccept")) Then
                sDt.Rows(j).Item("DateAccept") = ksbStringToDate(sDt.Rows(j).Item("DateAccept"))
            End If
            If Not IsDBNull(sDt.Rows(j).Item("DateCheck")) Then
                sDt.Rows(j).Item("DateCheck") = ksbStringToDate(sDt.Rows(j).Item("DateCheck"))
            End If
            If Not IsDBNull(sDt.Rows(j).Item("DateApprive")) Then
                sDt.Rows(j).Item("DateApprive") = ksbStringToDate(sDt.Rows(j).Item("DateApprive"))
            End If
        Next

        Dim dtChkData As New DataTable
        dtChkData.Clear()
        Dim where As String = ""
        where = "WHERE C.CusCode <> '' AND C.Address <> '' AND C.Tel <> '' AND C.TelOffice <> '' " & _
                "AND C.stBusinessType IS NOT NULL AND C.stRight IS NOT NULL AND " & _
                "C.idTsp IS NOT NULL And C.idTsp <> 1 AND C.Latitude <> '' AND C.Longitude <> '' "

        sCommand.CommandText = "SELECT C.CusCode, C.CusName_ As CusName, C.Address, C.Tel, C.TelOffice, C.TelHome, C.Fax, C.Latitude, C.Longitude, C.stBusinessType, " & _
                               "CASE WHEN C.stRight = 0 THEN 'ไม่ถูกหลัก' WHEN C.stRight = 1 THEN 'ถูกหลัก' ELSE 'ยังไม่ได้กำหนด' END As stRightShow, C.Note, P1.PsName As PsAccept, C.DateAccept," & _
                               "P2.PsName As PsCheck, C.DateCheck, P3.PsName As PsApprove, C.DateApprive, C.stRight, C.idCus, C.idTsp, C.idPv, C.idAp, C.idTb, '' As chkfullData FROM vCustomer As C LEFT JOIN vPerson As P1 On C.idPsAccept=P1.idPs " & _
                               "LEFT JOIN vPerson As P2 On C.idPsCheck=P2.idPs LEFT JOIN vPerson As P3 On C.idPsApprove=P3.idPs " & where & "  Order By C.CusName"
        sAdapter.Fill(dtChkData)

        mdLoadShow()
        countpicrow() 'เช็คจำนวนรูป

        Dim cntFullData As Integer = 0 'นับจำนวนข้อมูลที่ครบ
        For i As Integer = 0 To dtChkData.Rows.Count - 1
            For Each dr As DataRow In sDt.Select("idCus =" & dtChkData.Rows(i).Item("idCus"))
                If dr.Item("PicOwer") <> 0 And dr.Item("PicCard") <> 0 And dr.Item("PicRegistration") <> 0 And dr.Item("PicCommercial") <> 0 Then
                    dr.Item("chkfullData") = "ข้อมูลครบ"
                    cntFullData += 1
                End If
            Next
        Next
        
        mdLoadCommitt()

        Rd_fullData.Text = "ข้อมูลครบ   " & Format(cntFullData, "#,##0")
        Rd_NormalData.Text = "ข้อมูลไม่ครบ   " & Format(sDt.Rows.Count - cntFullData, "#,##0")
        Rd_AllData.Text = "ทั้งหมด   " & Format(sDt.Rows.Count, "#,##0")

        DgvCusApprove.DataSource = sDt
        RowCount()

    End Sub

    Private Sub frmCusApprove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowDataOnGrid()
    End Sub

    Private Sub DataGridView1_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DgvCusApprove.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DgvCusApprove.RowHeadersWidth < CInt((size.Width + 20)) Then
            DgvCusApprove.RowHeadersWidth = CInt((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, _
                              e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) _
                                                       / 2))
    End Sub

    Private Sub DgvCusApprove_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCusApprove.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If DgvCusApprove.Columns(e.ColumnIndex).Name = col_select.Name Then
            If eEvent = eProcess.ePsAcceptCus Then
                Dim vFrm_Data As New frmCusApproveDetail(frmCusApproveDetail.eProcess.ePsAcceptCus)
                vFrm_Data.get_idCus(Me.DgvCusApprove.Rows(e.RowIndex).Cells(col_idCus.Name).Value, Me.DgvCusApprove.Rows(e.RowIndex).Cells(chkfullData.Name).Value)

                If vFrm_Data.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ShowDataOnGrid()
                End If
            ElseIf eEvent = eProcess.ePsCheckCus Then
                Dim vFrm_Data As New frmCusApproveDetail(frmCusApproveDetail.eProcess.ePsCheckCus)
                vFrm_Data.get_idCus(Me.DgvCusApprove.Rows(e.RowIndex).Cells(col_idCus.Name).Value, Me.DgvCusApprove.Rows(e.RowIndex).Cells(chkfullData.Name).Value)

                If vFrm_Data.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ShowDataOnGrid()
                End If
            ElseIf eEvent = eProcess.ePsApproveCus Then
                Dim vFrm_Data As New frmCusApproveDetail(frmCusApproveDetail.eProcess.ePsApproveCus)
                vFrm_Data.get_idCus(Me.DgvCusApprove.Rows(e.RowIndex).Cells(col_idCus.Name).Value, Me.DgvCusApprove.Rows(e.RowIndex).Cells(chkfullData.Name).Value)

                If vFrm_Data.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ShowDataOnGrid()
                End If
            End If
        End If
    End Sub

    Private Sub RowCount()
        Me.Label2.Text = "รายการที่แสดงทั้งหมด  " & Format(DgvCusApprove.Rows.Count, "#,##0") & "  รายการ"
    End Sub

    Private Sub fn_txtSearch()
        Try
            Dim dv As New DataView(sDt)
            If Rd_fullData.Checked Then
                '"CusCode <> '' And Address <> '' And Tel <> '' And TelOffice <> '' And Latitude <> '' And Longitude <> '' And stBusinessType IS NOT NULL And stRight IS NOT NULL And idTsp IS NOT NULL
                dv.RowFilter = "chkfullData <> '' And CusName LIKE  '%" & txt_search.Text.Trim & "%'"
            ElseIf Rd_NormalData.Checked Then
                dv.RowFilter = "chkfullData = '' And CusName LIKE  '%" & txt_search.Text.Trim & "%'"
            ElseIf Rd_AllData.Checked Then
                dv.RowFilter = "CusName LIKE  '%" & txt_search.Text.Trim & "%'"
            End If

            dv.Sort = "CusName"
            DgvCusApprove.DataSource = dv
            If dv.Count = 0 Then
                MessageBox.Show("ไม่พบที่ค้นหา", sSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            RowCount()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Enter Then
            fn_txtSearch()
        End If
    End Sub

    Private Sub Rd_fullData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rd_fullData.CheckedChanged
        If Rd_fullData.Checked Then
            fn_txtSearch()
        End If
    End Sub

    Private Sub Rd_AllData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rd_AllData.CheckedChanged
        If Rd_AllData.Checked Then
            fn_txtSearch()
        End If
    End Sub

    Private Sub Rd_NormalData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rd_NormalData.CheckedChanged
        If Rd_NormalData.Checked Then
            fn_txtSearch()
        End If
    End Sub

    Private Sub countpicrow()

        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pCusOwner/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        Dim ftpFiles As New ArrayList()
        Dim i As Integer = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As IO.Stream = Response.GetResponseStream()
        Dim str() As String
        Dim strname As String = ""
        Dim reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))
        Dim pidcus As String
        Dim k As Integer = 0
        Dim j As Integer = 0
        Dim noPicOwn As Integer = 0
        Dim noPicLocation As Integer = 0
        Dim noPicEvent As Integer = 0
        ftpFiles.Clear()
        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For i = 0 To sDt.Rows.Count - 1
            pidcus = sDt.Rows(i).Item("idCus")
            For j = 0 To ftpFiles.Count - 1
                str = ftpFiles.Item(j).ToString().Split("-")
                If (str(0) = pidcus) Then
                    k += 1
                End If
            Next
            sDt.Rows(i).Item("PicOwner") = k
            'dgvDataCus.Rows(i).Cells(colPicLocation.Name).Value = k.ToString
            k = 0
        Next
        str = New String() {}
        ftp = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pCusCard/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftpFiles.Clear()
        i = 0
        k = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Response = ftp.GetResponse()
        responseStream = Response.GetResponseStream()
        reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))

        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For i = 0 To sDt.Rows.Count - 1
            pidcus = sDt.Rows(i).Item("idCus")
            For j = 0 To ftpFiles.Count - 1
                str = ftpFiles.Item(j).ToString().Split(".jpg")
                If (str(0) = pidcus) Then
                    k += 1
                End If
            Next
            sDt.Rows(i).Item("PicCard") = k
            k = 0
        Next

        str = New String() {}
        ftp = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pCusRegistration/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftpFiles.Clear()
        i = 0
        k = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Response = ftp.GetResponse()
        responseStream = Response.GetResponseStream()
        reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))

        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For i = 0 To sDt.Rows.Count - 1
            pidcus = sDt.Rows(i).Item("idCus")
            For j = 0 To ftpFiles.Count - 1
                str = ftpFiles.Item(j).ToString().Split(".jpg")
                If (str(0) = pidcus) Then
                    k += 1
                End If
            Next
            sDt.Rows(i).Item("PicRegistration") = k
            k = 0
        Next

        str = New String() {}
        ftp = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pCusCommercial/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftpFiles.Clear()
        i = 0
        k = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Response = ftp.GetResponse()
        responseStream = Response.GetResponseStream()
        reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("windows-874"))

        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For i = 0 To sDt.Rows.Count - 1
            pidcus = sDt.Rows(i).Item("idCus")
            For j = 0 To ftpFiles.Count - 1
                str = ftpFiles.Item(j).ToString().Split(".jpg")
                If (str(0) = pidcus) Then
                    k += 1
                End If
            Next
            sDt.Rows(i).Item("PicCommercial") = k
            k = 0
        Next

        reader.Close()
        responseStream.Close()
        Response.Close()

    End Sub
End Class