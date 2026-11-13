Public Class frmMkCusPsList
    Dim idCusPs As String
    Sub mdLoadShow()

    End Sub
    Sub mdLoadCommitt()

    End Sub
    Public Sub Get_idCus(ByVal idCus As String, ByVal pCusname As String, ByVal pAdd As String)
        idCusPs = idCus
        txtnamecus.Text = "ชื่อลูกค้า : " + pCusname
        txtaddcus.Text = pAdd
    End Sub
    Private Sub pSetData()
        Dim vWhere As String = " WHERE dbo.SmMkCusPs.idCus = " & idCusPs
        Dim SelectTM As String = " "
        mdLoadShow()
        ShowDataOnGrid(vWhere)
        mdLoadCommitt()
    End Sub

    Private Sub dgvExpense_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData.RowPostPaint
        Me.dgvData("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Public Sub ShowDataOnGrid(ByVal sWhere As String)
        mdCnOpen()
        Dim sDt As New DataTable
        Dim vWhere As String = sWhere
        sCommand.CommandText = "SELECT dbo.vPerson.PsName FROM dbo.SmMkCusPs LEFT OUTER JOIN dbo.vPerson ON dbo.SmMkCusPs.idPs = dbo.vPerson.idPs " & vWhere
        sAdapter.Fill(sDt)
        dgvData.DataSource = sDt
    End Sub
    Private Sub frmMkCusPsSet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pSetData()
    End Sub
End Class