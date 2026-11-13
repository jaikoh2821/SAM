Imports System.Net

Public Class frmMkCusPicSet
    Dim wType As New Integer
    Dim chkevent As New Integer
    Dim dtb1 As New DataTable

    Sub mdLoadShow()

    End Sub
    Sub mdLoadCommitt()

    End Sub
    Private Sub dgvExpense_RowPostPaint2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataCus.RowPostPaint
        Me.dgvDataCus("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub dgvData_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataCus.CellClick
        Dim frm As New frmMkCusPicList
        Dim pIdT As New Integer
        Dim pName As String
        Dim pAdd As String
        Dim frmShowPs As New frmMkCusPsList
        Dim pPsnum As String


        If e.RowIndex < 0 Then
            Exit Sub
        End If


        If dgvDataCus.Columns(e.ColumnIndex).Name = colselect.Name Then
            pIdT = dgvDataCus.Rows(e.RowIndex).Cells(idCus.Name).Value
            pName = dgvDataCus.Rows(e.RowIndex).Cells(colCusName.Name).Value
            pPsnum = dgvDataCus.Rows(e.RowIndex).Cells(numPs.Name).Value
            If dgvDataCus.Rows(e.RowIndex).Cells(colAddCus.Name).Value Is DBNull.Value Then
                pAdd = ""
            Else
                pAdd = dgvDataCus.Rows(e.RowIndex).Cells(colAddCus.Name).Value
            End If
            frm.Get_value(pIdT, pName, pAdd, pPsnum)
            frm.ShowDialog()
        End If
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            pSetdata()
        End If

    End Sub

    Private Sub frmMkCusPsSet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        pSetdata()
        mdLoadCommitt()
    End Sub

    Private Sub pSetdata()
        Dim vWhere As String = ""
        Dim ptxtsname As String = txtsname.Text
        Dim padd As String = txtadd.Text
        If CHKname.Checked = False And AddcusCheck.Checked = False Then
            vWhere = " WHERE dCustomer.stDel= '0' "
        ElseIf CHKname.Checked = True And AddcusCheck.Checked = False Then
            vWhere = " WHERE dCustomer.CusName LIKE '%" & ptxtsname & "%' AND dCustomer.stDel= '0'"
        ElseIf CHKname.Checked = False And AddcusCheck.Checked = True Then
            vWhere = " WHERE dCustomer.Address LIKE '%" & padd & "%' AND dCustomer.stDel= '0'"
        ElseIf CHKname.Checked = True And AddcusCheck.Checked = True Then
            vWhere = " WHERE dCustomer.Address LIKE '%" & padd & "%' AND dCustomer.CusName LIKE '%" & ptxtsname & "%' AND dCustomer.stDel= '0'"
        End If
        mdLoadShow()
        ShowDataOnGrid(vWhere)
        mdLoadCommitt()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mdLoadShow()
        pSetdata()
        mdLoadCommitt()
    End Sub
    Public Sub ShowDataOnGrid(ByVal sWhere As String)
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select vPerson.PsName,SmMkCusPs.idCus From vPerson,SmMkCusPs WHERE vPerson.idPs = SmMkCusPs.idPs Order by vPerson.PsName ASC"
        sAdapter.Fill(sDt)

        dtb1.Clear()
        Dim vWhere As String = sWhere
        sCommand.CommandText = "SELECT '0' AS colPicOwner,'0' AS colPicLocation ,'0' AS colPicEvent,dCustomer.CusName, dCustomer.Address, dCustomer.idCus,'' AS CusPsName FROM dCustomer " & vWhere & " ORDER BY dCustomer.CusName"
        sAdapter.Fill(dtb1)
        Me.dgvDataCus.DataSource = dtb1
        countpicrow()
        selectCusPs(sDt)
        Me.dgvDataCus.DataSource = dtb1
        caltotalPic()
    End Sub
    Private Sub selectCusPs(ByVal sDt As DataTable)
        mdCnOpen()
        For i As Integer = 0 To dtb1.Rows.Count - 1
            dtb1.Rows(i).Item("CusPsName") = ""
            Dim first As Integer = 1
            For j As Integer = 0 To Sdt.Rows.Count - 1
                If dtb1.Rows(i).Item("idCus") = Sdt.Rows(j).Item("idCus") Then
                    If first = 1 Then
                        dtb1.Rows(i).Item("CusPsName") &= Sdt.Rows(j).Item("PsName")
                        first = 0
                    Else
                        dtb1.Rows(i).Item("CusPsName") &= " , " & Sdt.Rows(j).Item("PsName")
                    End If
                End If
            Next
            If dtb1.Rows(i).Item("CusPsName") = "" Then
                dtb1.Rows(i).Item("CusPsName") = "   -"
            End If
        Next

    End Sub
    Private Sub CHKname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKname.CheckedChanged
        If CHKname.Checked = True Then
            txtsname.Enabled = True
        End If
        If CHKname.Checked = False Then
            txtsname.Enabled = False
            txtsname.Text = ""
        End If
    End Sub

    Private Sub AddcusCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddcusCheck.CheckedChanged
        If AddcusCheck.Checked = True Then
            txtadd.Enabled = True
        End If
        If AddcusCheck.Checked = False Then
            txtadd.Enabled = False
            txtadd.Text = ""
        End If
    End Sub

    Private Sub countpicrow()

        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pCusLocation/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        Dim ftpFiles As New ArrayList()
        Dim i As Integer = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As IO.Stream = Response.GetResponseStream()
        Dim str() As String
        Dim str2() As String
        Dim str3() As String
        Dim strname As String = ""
        Dim reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"))
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

        For i = 0 To dgvDataCus.Rows.Count - 1
            pidcus = dgvDataCus.Rows(i).Cells(idCus.Name).Value
            For j = 0 To ftpFiles.Count - 1
                str = ftpFiles.Item(j).ToString().Split("-")
                If (str(0) = pidcus) Then
                    k += 1
                End If
            Next
            dtb1.Rows(i).Item(1) = k.ToString
            'dgvDataCus.Rows(i).Cells(colPicLocation.Name).Value = k.ToString
            k = 0
        Next

        ftp = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pCusEvent/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftpFiles.Clear()
        i = 0
        k = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Response = ftp.GetResponse()
        responseStream = Response.GetResponseStream()
        reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"))

        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For i = 0 To dgvDataCus.Rows.Count - 1
            pidcus = dgvDataCus.Rows(i).Cells(idCus.Name).Value
            For j = 0 To ftpFiles.Count - 1
                str2 = ftpFiles.Item(j).ToString().Split("-")
                If (str2(0) = pidcus) Then
                    k += 1
                End If
            Next
            dtb1.Rows(i).Item(2) = k.ToString
            'dgvDataCus.Rows(i).Cells(colPicEvent.Name).Value = k.ToString
            k = 0
        Next


        ftp = DirectCast(WebRequest.Create("ftp://" & sHost & "/images/pCusOwner/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        ftpFiles.Clear()
        i = 0
        k = 0
        ftp.Credentials = New NetworkCredential(sFtpUser, sFtpPass)
        Response = ftp.GetResponse()
        responseStream = Response.GetResponseStream()
        reader = New IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"))

        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For i = 0 To dgvDataCus.Rows.Count - 1
            pidcus = dgvDataCus.Rows(i).Cells(idCus.Name).Value
            For j = 0 To ftpFiles.Count - 1
                str3 = ftpFiles.Item(j).ToString().Split("-")
                If (str3(0) = pidcus) Then
                    k += 1
                End If
            Next
            dtb1.Rows(i).Item(0) = k.ToString
            'dgvDataCus.Rows(i).Cells(colPicOwner.Name).Value = k.ToString
            k = 0
        Next
        
        reader.Close()
        responseStream.Close()
        Response.Close()

    End Sub

    Private Sub caltotalPic()
        Dim i As Integer = 0
        Dim m As Integer = 0
        Dim totalrow As Integer = 0
        Dim noPicOwn As Integer = 0
        Dim noPicLocation As Integer = 0
        Dim noPicEvent As Integer = 0

        For i = 0 To dgvDataCus.Rows.Count - 1
            If dgvDataCus.Rows(i).Cells(colPicOwner.Name).Value = 0 Then
                noPicOwn += 1
            End If
            If dgvDataCus.Rows(i).Cells(colPicLocation.Name).Value = 0 Then
                noPicLocation += 1
            End If
            If dgvDataCus.Rows(i).Cells(colPicEvent.Name).Value = 0 Then
                noPicEvent += 1
            End If
            totalrow += 1
        Next

        lbOwn.Text = noPicOwn.ToString + " รายการ"
        lbLocation.Text = noPicLocation.ToString + " รายการ"
        lbEvent.Text = noPicEvent.ToString + " รายการ"
        lbtotal.Text = "รายการทั้งหมด" + totalrow.ToString + " รายการ"

        m = dtb1.Rows.Count
        i = 0
        If CHKOwnPic.Checked = True Then
            Do While i <= dtb1.Rows.Count - 1
                If dtb1.Rows(i).Item(0) <> "0" Then
                    dtb1.Rows(i).Delete()
                    dtb1.AcceptChanges()
                    i = 0
                    Continue Do
                End If
                i += 1
            Loop

        End If

        If CHKLocation.Checked = True Then
            Do While i <= dtb1.Rows.Count - 1
                If dtb1.Rows(i).Item(1) <> "0" Then
                    dtb1.Rows(i).Delete()
                    dtb1.AcceptChanges()
                    i = 0
                    Continue Do
                End If
                i += 1
            Loop
        End If

        i = 0
        If CHKEventPic.Checked = True Then
            Do While i <= dtb1.Rows.Count - 1
                If dtb1.Rows(i).Item(2) <> "0" Then
                    dtb1.Rows(i).Delete()
                    dtb1.AcceptChanges()
                    i = 0
                    Continue Do
                End If
                i += 1
            Loop
        End If

    End Sub
End Class