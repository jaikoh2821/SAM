Imports System.Security.Permissions

Public Class frmSlCusMapAll
    Dim arrCus As New myArr
    Dim listCheck As New List(Of Integer)

    Private Sub setData(ByVal sWhere As String)
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = sWhere
        sAdapter.Fill(sDt)

        Dim listDup As New List(Of Integer)
        Dim checkDup As Integer
        For i As Integer = 0 To sDt.Rows.Count - 1
            checkDup = 0
            If listDup.Count > 0 Then
                For k As Integer = 0 To listDup.Count - 1
                    If i = listDup.Item(k) Then
                        checkDup = 1
                    End If
                Next
            End If

            If checkDup = 0 Then
                arrCus.lat.Add(sDt.Rows(i).Item("Latitude"))
                arrCus.lng.Add(sDt.Rows(i).Item("Longitude"))
                arrCus.cusName.Add(sDt.Rows(i).Item("CusName"))
                For j As Integer = i + 1 To sDt.Rows.Count - 1
                    If sDt.Rows(i).Item("Latitude") = sDt.Rows(j).Item("Latitude") And sDt.Rows(i).Item("Longitude") = sDt.Rows(j).Item("Longitude") Then
                        arrCus.cusName.Item(i) &= " , " & sDt.Rows(j).Item("CusName")
                        listDup.Add(j)
                    End If
                Next
            End If

        Next

    End Sub

    Private Sub frmSlCusMapAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vWhere As String = "Select Latitude,Longitude,CusName From dCustomer WHERE Latitude IS NOT NULL AND " & _
                                "Longitude IS NOT NULL AND Latitude <> '' AND Longitude <> ''"
        setData(vWhere)
        arrCus.n = arrCus.lat.Count
        WebBrowser1.DocumentText = My.Resources.ResourceManager.GetObject("cusMap")

        Dim sDt As New DataTable
        'Dim vWhere2 As String = " WHERE vPerson.idPosition = 2 AND (idStWork = 1 OR idStWork = 2) "
        Dim vWhere2 As String = " WHERE vPerson.stSale = 1 "
        sCommand.CommandText = "SELECT vPerson.PsName, COUNT(SmMkCusPs.idPs) AS numCus ,vPerson.idPs FROM vPerson " & _
                               "LEFT OUTER JOIN SmMkCusPs ON vPerson.idPs = SmMkCusPs.idPs " & vWhere2 & " GROUP BY vPerson.PsName, " & _
                               "vPerson.idPs ORDER BY vPerson.PsName"
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
        dgvData.Sort(dgvData.Columns(colNumCus.Name), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.Document.InvokeScript("setLatLng", New Object() {arrCus})
    End Sub

    Private Sub cbCusName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCusName.CheckedChanged
        If cbCusName.Checked = True Then
            WebBrowser1.Document.InvokeScript("showInfoBox")
        Else
            WebBrowser1.Document.InvokeScript("hideInfoBox")
        End If
    End Sub

    Private Sub dgvData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If dgvData.Columns(e.ColumnIndex).Name = colselect.Name Then
            dgvData.EndEdit()
            Dim vWhere As String
            arrCus = New myArr
            listCheck.Clear()
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If dgvData.Rows(i).Cells(colselect.Name).Value = True Then
                    vWhere = "Select dCustomer.Latitude,dCustomer.Longitude,dCustomer.CusName From dCustomer, SmMkCusPs " & _
                              "WHERE dCustomer.idCus = SmMkCusPs.idCus AND SmMkCusPs.idPs = " & dgvData.Rows(i).Cells(colidPer.Name).Value & " " & _
                              "AND dCustomer.Latitude IS NOT NULL AND dCustomer.Longitude IS NOT NULL AND dCustomer.Latitude <> '' AND " & _
                              "dCustomer.Longitude <> ''"
                    setData(vWhere)
                    listCheck.Add(dgvData.Rows(i).Cells(colidPer.Name).Value)
                End If
            Next

            If cbCusName2.Checked = True Then
                arrCus.checkShowBox = 1
            End If
            arrCus.n = arrCus.lat.Count
            WebBrowser2.DocumentText = My.Resources.ResourceManager.GetObject("cusMap")

            cbCusName2.Enabled = True

        End If
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        WebBrowser2.Document.InvokeScript("setLatLng", New Object() {arrCus})
    End Sub

    Private Sub cbCusName2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCusName2.CheckedChanged
        If cbCusName2.Checked = True Then
            WebBrowser2.Document.InvokeScript("showInfoBox")
        Else
            WebBrowser2.Document.InvokeScript("hideInfoBox")
        End If
    End Sub

    Private Sub dgvData_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvData.Sorted
        For i As Integer = 0 To dgvData.Rows.Count - 1
            For j As Integer = 0 To listCheck.Count - 1
                If dgvData.Rows(i).Cells(colidPer.Name).Value = listCheck.Item(j) Then
                    dgvData.Rows(i).Cells(colselect.Name).Value = True
                End If
            Next
        Next
        dgvData.RefreshEdit()
    End Sub

    Private Sub dgvData_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvData.SelectionChanged
        dgvData.ClearSelection()
    End Sub

End Class

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")> _
<System.Runtime.InteropServices.ComVisibleAttribute(True)> _
Public Class myArr
    Public checkShowBox As Integer = 0
    Public n As Integer
    Public lat As New List(Of Double)
    Public lng As New List(Of Double)
    Public cusName As New List(Of String)

    Public Function getLat(ByVal i As Integer) As Double
        Return lat.Item(i)
    End Function

    Public Function getLng(ByVal i As Integer) As Double
        Return lng.Item(i)
    End Function

    Public Function getCusName(ByVal i As Integer) As String
        Return cusName.Item(i)
    End Function

End Class

