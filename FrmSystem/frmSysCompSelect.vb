Imports DevExpress.XtraTreeList.Nodes

Public Class frmSysCompSelect
    Dim mExit As Boolean = True

    Private Sub frmSysCompSelect_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mExit = True Then Application.Exit()
    End Sub

    Private Sub frmSysCompSelect_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        mdCnOpen2()
        TreeList1.BeginUnboundLoad()
        FillTree(0, "Seeds Group", Nothing)
        TreeList1.EndUnboundLoad()
        TreeList1.ExpandAll()

    End Sub

    Private Sub FillTree(ByVal Key As Integer, ByVal txt As String, ByVal N As TreeListNode)
        Dim NN As TreeListNode
        If N Is Nothing Then
            NN = TreeList1.Nodes.Add(New Object() {txt})
        Else
            NN = N.Nodes.Add(New Object() {txt})
        End If
        NN.StateImageIndex = 0
        NN.Tag = Key

        Dim dr As New DataTable
        sCommand.CommandText = "SELECT m.id AS idGroup, c.idComp, case m.parentid when 0 then m.groupName else c.CompName end as CompName, " &
                               "parentid from dGroupCompMap m left join dCompany c On c.idComp = m.idcomp " &
                               "WHERE c.stDel Is NULL AND m.stActive = 1 AND parentid = " & Key
        sAdapter.Fill(dr)
        If dr.Rows.Count > 0 Then
            For i As Integer = 0 To dr.Rows.Count - 1
                FillTree(dr.Rows(i).Item("idGroup"), dr.Rows(i).Item("CompName"), NN)
            Next

        End If

    End Sub


    Private Sub TreeList1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TreeList1.MouseDoubleClick
        Dim Hinfo As DevExpress.XtraTreeList.TreeListHitInfo = TreeList1.CalcHitInfo(New Point(e.X, e.Y))
        If Hinfo.Column Is Nothing Then Exit Sub

        sCompName = Hinfo.Node.GetDisplayText(Hinfo.Column.AbsoluteIndex)
        sIdGroupComp = Hinfo.Node.Tag

        mdCnOpen2()
        Dim vDt As New DataTable
        sCommand.CommandText = "SELECT ISNULL(m.idComp, 0) As idComp, ISNULL(c.CompCode, '') As CompCode " &
                               "From dGroupCompMap m LEFT JOIN dCompany c On c.idComp = m.idcomp WHERE id = " & sIdGroupComp
        sAdapter.Fill(vDt)

        If vDt.Rows.Count = 0 Then ' Seeds Group
            sCompCode = ""
            sIdComp = 0

            Dim strDt As New DataTable
            sCommand.CommandText = "SELECT idComp From dGroupCompMap WHERE parentid <> 0"
            sAdapter.Fill(strDt)

            SIdCompStr = strDt.Rows(0).Item("idComp")
            For i As Integer = 1 To strDt.Rows.Count - 1
                SIdCompStr = SIdCompStr & ", " & strDt.Rows(i).Item("idComp")
            Next
        Else
            sCompCode = vDt.Rows(0).Item("CompCode").ToString
            sIdComp = vDt.Rows(0).Item("idComp")

            Dim strDt As New DataTable
            sCommand.CommandText = "SELECT idComp From dGroupCompMap WHERE parentid = " & sIdGroupComp
            sAdapter.Fill(strDt)
            If strDt.Rows.Count = 0 Then 'No Child = Comp
                SIdCompStr = sIdComp
            Else 'Parent = Group
                SIdCompStr = strDt.Rows(0).Item("idComp")
                For i As Integer = 1 To strDt.Rows.Count - 1
                    SIdCompStr = SIdCompStr & ", " & strDt.Rows(i).Item("idComp")
                Next
            End If
        End If


        MDIMain.pAuthentication()

        mExit = False
        Me.Close()
    End Sub

End Class