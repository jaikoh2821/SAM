Public Class frmPsZoneDetail
    Public idRg As String = 1
    Public DateS As String = 0
    Public YearS As String = 0
    Public DateStart As String = 0
    Public DateEnd As String = 0
    Public Year As String = ""
    Public RgName As String = ""
    Public LengDay As String = ""
    Public Datetext As String = ""


   

    Private Sub frmPsZoneDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBName.Text &= ": " & RgName
        LBTap2_1.Text &= ": " & RgName

        If DateS = 0 Then
            LBTime.Text = "ประจำปี " & Year
            LBTap2_2.Text = "ประจำปี " & Year
        Else
            LBTime.Text = Datetext
            LBTap2_2.Text = Datetext
        End If
        mdLoadShow()
        fillAllData()
        mdLoadCommitt()
    End Sub
    

    Private Sub fillAllData()
        Dim vWhere As String = ""
        Dim vWhere2 As String = ""
        Dim sDt As New DataTable
        Dim sDt2 As New DataTable
        Dim sDt3 As New DataTable
        Dim sDt4 As New DataTable
        Dim sDt5 As New DataTable
        If DateS = 1 Then
            vWhere &= " AND (sm.DateSale BETWEEN  '" & DateStart & "' AND '" & DateEnd & "' ) "
            vWhere2 &= " AND (t1.DateSale BETWEEN  '" & DateStart & "' AND '" & DateEnd & "' ) "
        Else
            vWhere &= " AND (SUBSTRING (sm.DateSale,0,5) = " & Year & " ) "
            vWhere2 &= " AND (SUBSTRING (t1.DateSale,0,5) = " & Year & " ) "
        End If
        If idRg = "11" Then
            idRg = " IS NULL "
            TabControl1.TabPages.Remove(TabPage2)
        Else
            idRg = " = " & idRg
        End If
        mdCnOpen()
        sCommand.CommandText = " Select Ps.PsName , " & _
               " SUM(t1.Totalnet) AS Totalnet , convert(VARCHAR,CONVERT(DECIMAL(10,2),(SUM(t1.Totalnet) / ((SELECT SUM(sm.Totalnet)from VSmSaleMt as sm LEFT JOIN vCustomer as C ON sm.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv " & _
               " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale WHERE sm.idPsCancel IS NULL AND P.idRegionSale " & idRg & " " & vWhere & " ))*100)),120) + ' %' AS percent2  " & _
               " FROM  VSmSaleMt as t1 LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv   " & _
                " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
                " WHERE t1.idPsCancel IS NULL AND P.idRegionSale " & idRg & " " & vWhere2 & " " & _
                " group by t1.idPsSale,Ps.PsName Order By Totalnet DESC "
        sAdapter.Fill(sDt)
        dgvData1.DataSource = sDt
        mdCnOpen()
        sCommand.CommandText = " Select C.CusName , " & _
               " SUM(t1.Totalnet) AS Totalnet , convert(VARCHAR,CONVERT(DECIMAL(10,2),(SUM(t1.Totalnet) / ((SELECT SUM(sm.Totalnet)from VSmSaleMt as sm LEFT JOIN vCustomer as C ON sm.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv " & _
               " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale WHERE sm.idPsCancel IS NULL AND P.idRegionSale " & idRg & " " & vWhere & " ))*100)),120) + ' %' AS percent2  " & _
               " FROM  VSmSaleMt as t1 LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv   " & _
                " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
                " WHERE t1.idPsCancel IS NULL AND P.idRegionSale " & idRg & " " & vWhere2 & " " & _
                " group by C.CusName Order By Totalnet DESC "
        sAdapter.Fill(sDt2)
        dgvData2.DataSource = sDt2

        Dim allTotal As Double = 0
        sCommand.CommandText = "SELECT PlantName ,SUM(Totalnet) AS totalnet,' ' AS percent2 " & _
       " FROM (Select Pack.PlantName ,SUM(SmD.Price * SmD.Amount) AS Totalnet " & _
       " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
       " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
       " WHERE(t1.idPsCancel Is NULL And P.idRegionSale " & idRg & " " & vWhere2 & "   And SmD.idPkUnit <> 3) " & _
       " group by Pack.PlantName " & _
       " UNION " & _
       " Select Pack.PlantName ,SUM((SmD.Price * SmD.PerBox) * SmD.Amount) AS Totalnet    " & _
       " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
       " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
       " WHERE(t1.idPsCancel Is NULL And P.idRegionSale " & idRg & " " & vWhere2 & "  And SmD.idPkUnit = 3) " & _
       " group by Pack.PlantName) as DB1 GROUP BY PlantName ORDER BY totalnet DESC "
        sAdapter.Fill(sDt3)
        allTotal = 0
        For i As Integer = 0 To sDt3.Rows.Count - 1
            allTotal = allTotal + sDt3.Rows(i).Item("totalnet")
        Next
        For i As Integer = 0 To sDt3.Rows.Count - 1
            sDt3.Rows(i).Item("percent2") = Format(((sDt3.Rows(i).Item("totalnet") / allTotal) * 100), "0.00").ToString() & " %"
        Next
        dgvData3.DataSource = sDt3

        sCommand.CommandText = "SELECT PdTradeName ,SUM(Totalnet) AS totalnet,' ' AS percent2 " & _
       " FROM (Select Pack.PdTradeName ,SUM(SmD.Price * SmD.Amount) AS Totalnet " & _
       " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
       " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
       " WHERE(t1.idPsCancel Is NULL And P.idRegionSale " & idRg & " " & vWhere2 & "  And SmD.idPkUnit <> 3) " & _
       " group by Pack.PdTradeName " & _
       " UNION " & _
       " Select Pack.PdTradeName ,SUM((SmD.Price * SmD.PerBox) * SmD.Amount) AS Totalnet    " & _
       " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
       " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
       " WHERE(t1.idPsCancel Is NULL And P.idRegionSale " & idRg & " " & vWhere2 & " And SmD.idPkUnit = 3) " & _
       " group by Pack.PdTradeName) as DB1 GROUP BY PdTradeName ORDER BY totalnet DESC "
        sAdapter.Fill(sDt4)
        allTotal = 0
        For i As Integer = 0 To sDt4.Rows.Count - 1
            allTotal = allTotal + sDt4.Rows(i).Item("totalnet")
        Next
        For i As Integer = 0 To sDt4.Rows.Count - 1
            sDt4.Rows(i).Item("percent2") = Format(((sDt4.Rows(i).Item("totalnet") / allTotal) * 100), "0.00").ToString() & " %"
        Next
        dgvData4.DataSource = sDt4

        sCommand.CommandText = "SELECT PdPkName ,SUM(Totalnet) AS totalnet,' ' AS percent2 " & _
        " FROM (Select Pack.PdPkName ,SUM(SmD.Price * SmD.Amount) AS Totalnet " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
        " WHERE(t1.idPsCancel Is NULL And P.idRegionSale " & idRg & " " & vWhere2 & "  And SmD.idPkUnit <> 3) " & _
        " group by Pack.PdPkName " & _
        " UNION " & _
        " Select Pack.PdPkName ,SUM((SmD.Price * SmD.PerBox) * SmD.Amount) AS Totalnet    " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
        " WHERE(t1.idPsCancel Is NULL And P.idRegionSale " & idRg & " " & vWhere2 & "  And SmD.idPkUnit = 3) " & _
        " group by Pack.PdPkName) as DB1 GROUP BY PdPkName ORDER BY totalnet DESC "
        sAdapter.Fill(sDt5)
        allTotal = 0
        For i As Integer = 0 To sDt5.Rows.Count - 1
            allTotal = allTotal + sDt5.Rows(i).Item("totalnet")
        Next
        For i As Integer = 0 To sDt5.Rows.Count - 1
            sDt5.Rows(i).Item("percent2") = Format(((sDt5.Rows(i).Item("totalnet") / allTotal) * 100), "0.00").ToString() & " %"
        Next
        dgvData5.DataSource = sDt5

        Dim sDt_Tab2_1 As New DataTable
        sCommand.CommandText = " SELECT P.idPv,P.PvName,Sum(total) AS Total,' ' AS percent2,0 as Flag FROM  " & _
       " (select sum(totalnet) AS total,vc.cusname,vc.idcus,vc.idpv  " & _
       " FROM vSmSaleMt Sm LEFT JOIN vcustomer vc On vc.idcus = sm.idcus WHERE sm.idPsCancel IS NULL AND (SUBSTRING (sm.DateSale,0,5) =  " & Year & " ) Group by vc.cusname,vc.idcus,vc.idpv) as DB1 Left JOIn dProvinceFixSale P ON P.idPv = DB1.idPv    " & _
       " WHERE P.idRegionSale " & idRg & " Group by P.PvName,P.idPv ORDER BY Total DESC"
        sAdapter.Fill(sDt_Tab2_1)
        allTotal = 0
        For i As Integer = 0 To sDt_Tab2_1.Rows.Count - 1
            allTotal = allTotal + sDt_Tab2_1.Rows(i).Item("Total")
        Next
        For i As Integer = 0 To sDt_Tab2_1.Rows.Count - 1
            sDt_Tab2_1.Rows(i).Item("percent2") = Format(((sDt_Tab2_1.Rows(i).Item("Total") / allTotal) * 100), "0.00").ToString() & " %"
        Next
        dgvDataP.DataSource = sDt_Tab2_1

    End Sub

    Private Sub fillAllData2(ByVal idPv As String)
        Dim vWhere As String = ""
        Dim vWhere2 As String = ""
        Dim sDt As New DataTable
        Dim sDt2 As New DataTable
        Dim sDt3 As New DataTable
        Dim sDt4 As New DataTable
        Dim sDt5 As New DataTable
        If DateS = 1 Then
            vWhere &= " AND (sm.DateSale BETWEEN  '" & DateStart & "' AND '" & DateEnd & "' ) "
            vWhere2 &= " AND (t1.DateSale BETWEEN  '" & DateStart & "' AND '" & DateEnd & "' ) "
        Else
            vWhere &= " AND (SUBSTRING (sm.DateSale,0,5)  = " & Year & " ) "
            vWhere2 &= " AND (SUBSTRING (t1.DateSale,0,5)  = " & Year & " ) "
        End If
        If idRg = "11" Then
            idRg = " IS NULL "
            TabControl1.TabPages.Remove(TabPage2)
        Else
            idRg = " = " & idRg
        End If
        mdCnOpen()
        sCommand.CommandText = " Select Ps.PsName , " & _
               " SUM(t1.Totalnet) AS Totalnet , convert(VARCHAR,CONVERT(DECIMAL(10,2),(SUM(t1.Totalnet) / ((SELECT SUM(sm.Totalnet)from VSmSaleMt as sm LEFT JOIN vCustomer as C ON sm.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv " & _
               " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale WHERE sm.idPsCancel IS NULL AND P.idPv = " & idPv & " " & vWhere & " ))*100)),120) + ' %' AS percent2  " & _
               " FROM  VSmSaleMt as t1 LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv   " & _
                " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
                " WHERE t1.idPsCancel IS NULL AND P.idPv = " & idPv & " " & vWhere2 & " " & _
                " group by t1.idPsSale,Ps.PsName Order By Totalnet DESC "
        sAdapter.Fill(sDt)
        dgvDataP1.DataSource = sDt
        mdCnOpen()
        sCommand.CommandText = " Select C.CusName , " & _
               " SUM(t1.Totalnet) AS Totalnet , convert(VARCHAR,CONVERT(DECIMAL(10,2),(SUM(t1.Totalnet) / ((SELECT SUM(sm.Totalnet)from VSmSaleMt as sm LEFT JOIN vCustomer as C ON sm.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv " & _
               " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale WHERE sm.idPsCancel IS NULL AND P.idPv = " & idPv & " " & vWhere & " ))*100)),120) + ' %' AS percent2  " & _
               " FROM  VSmSaleMt as t1 LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv   " & _
                " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale " & _
                " WHERE t1.idPsCancel IS NULL AND P.idPv = " & idPv & " " & vWhere2 & " " & _
                " group by C.CusName Order By Totalnet DESC "
        sAdapter.Fill(sDt2)
        dgvDataP2.DataSource = sDt2

        Dim allTotal As Double = 0
        sCommand.CommandText = "SELECT PlantName ,SUM(Totalnet) AS totalnet,' ' AS percent2 " & _
       " FROM (Select Pack.PlantName ,SUM(SmD.Price * SmD.Amount) AS Totalnet " & _
       " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
       " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
       " WHERE(t1.idPsCancel Is NULL And P.idPv = " & idPv & " " & vWhere2 & "   And SmD.idPkUnit <> 3) " & _
       " group by Pack.PlantName " & _
       " UNION " & _
       " Select Pack.PlantName ,SUM((SmD.Price * SmD.PerBox) * SmD.Amount) AS Totalnet    " & _
       " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
       " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
       " WHERE(t1.idPsCancel Is NULL And P.idPv = " & idPv & " " & vWhere2 & "  And SmD.idPkUnit = 3) " & _
       " group by Pack.PlantName) as DB1 GROUP BY PlantName ORDER BY totalnet DESC "
        sAdapter.Fill(sDt3)
        allTotal = 0
        For i As Integer = 0 To sDt3.Rows.Count - 1
            allTotal = allTotal + sDt3.Rows(i).Item("totalnet")
        Next
        For i As Integer = 0 To sDt3.Rows.Count - 1
            sDt3.Rows(i).Item("percent2") = Format(((sDt3.Rows(i).Item("totalnet") / allTotal) * 100), "0.00").ToString() & " %"
        Next
        dgvDataP3.DataSource = sDt3

        sCommand.CommandText = "SELECT PdTradeName ,SUM(Totalnet) AS totalnet,' ' AS percent2 " & _
       " FROM (Select Pack.PdTradeName ,SUM(SmD.Price * SmD.Amount) AS Totalnet " & _
       " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
       " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
       " WHERE(t1.idPsCancel Is NULL And P.idPv = " & idPv & " " & vWhere2 & "  And SmD.idPkUnit <> 3) " & _
       " group by Pack.PdTradeName " & _
       " UNION " & _
       " Select Pack.PdTradeName ,SUM((SmD.Price * SmD.PerBox) * SmD.Amount) AS Totalnet    " & _
       " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
       " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
       " WHERE(t1.idPsCancel Is NULL And P.idPv = " & idPv & " " & vWhere2 & " And SmD.idPkUnit = 3) " & _
       " group by Pack.PdTradeName) as DB1 GROUP BY PdTradeName ORDER BY totalnet DESC "
        sAdapter.Fill(sDt4)
        allTotal = 0
        For i As Integer = 0 To sDt4.Rows.Count - 1
            allTotal = allTotal + sDt4.Rows(i).Item("totalnet")
        Next
        For i As Integer = 0 To sDt4.Rows.Count - 1
            sDt4.Rows(i).Item("percent2") = Format(((sDt4.Rows(i).Item("totalnet") / allTotal) * 100), "0.00").ToString() & " %"
        Next
        dgvDataP4.DataSource = sDt4

        sCommand.CommandText = "SELECT PdPkName ,SUM(Totalnet) AS totalnet,' ' AS percent2 " & _
        " FROM (Select Pack.PdPkName ,SUM(SmD.Price * SmD.Amount) AS Totalnet " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
        " WHERE(t1.idPsCancel Is NULL And P.idPv = " & idPv & " " & vWhere2 & "  And SmD.idPkUnit <> 3) " & _
        " group by Pack.PdPkName " & _
        " UNION " & _
        " Select Pack.PdPkName ,SUM((SmD.Price * SmD.PerBox) * SmD.Amount) AS Totalnet    " & _
        " FROM SmSaleDt SmD LEFT JOIN vPackingPdSet Pack ON Pack.idPdPk = SmD.idPdPk Left JOIN VSmSaleMt as t1 ON t1.idSale = SmD.idSale LEFT JOIN vCustomer as C ON t1.idCus = C.idCus Left JOIn dProvinceFixSale P ON P.idPv = c.idPv    " & _
        " Left JOIN SmRegionD SmR ON SmR.idRegion = P.idRegionSale LEFT JOIN vPerson Ps ON Ps.idPs = t1.idPsSale  " & _
        " WHERE(t1.idPsCancel Is NULL And P.idPv = " & idPv & " " & vWhere2 & "  And SmD.idPkUnit = 3) " & _
        " group by Pack.PdPkName) as DB1 GROUP BY PdPkName ORDER BY totalnet DESC "
        sAdapter.Fill(sDt5)
        allTotal = 0
        For i As Integer = 0 To sDt5.Rows.Count - 1
            allTotal = allTotal + sDt5.Rows(i).Item("totalnet")
        Next
        For i As Integer = 0 To sDt5.Rows.Count - 1
            sDt5.Rows(i).Item("percent2") = Format(((sDt5.Rows(i).Item("totalnet") / allTotal) * 100), "0.00").ToString() & " %"
        Next
        dgvDataP5.DataSource = sDt5

    End Sub

    Public Sub AutoNumberRowsForGridView(ByVal dataGridView As DataGridView)

        If DataGridView IsNot Nothing Then

            Dim count As Integer = 0

            While (count <= (DataGridView.Rows.Count - 2))

                DataGridView.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")

                count += 1

            End While

        End If

    End Sub
    Private Sub dgvExpense_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData1.RowPostPaint
        dgvData1("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData2.RowPostPaint
        dgvData2("autonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint3(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData3.RowPostPaint
        dgvData3("colautonum3", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint4(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData4.RowPostPaint
        dgvData4("colautonum4", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint5(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvData5.RowPostPaint
        dgvData5("calautonum5", e.RowIndex).Value = e.RowIndex + 1
    End Sub


    Private Sub dgvExpense_RowPostPaint1_1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataP1.RowPostPaint
        dgvDataP1("colautonum_1", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint1_2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataP2.RowPostPaint
        dgvDataP2("colautonum_2", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint1_3(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataP3.RowPostPaint
        dgvDataP3("colautonum_3", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint1_4(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataP4.RowPostPaint
        dgvDataP4("colautonum_4", e.RowIndex).Value = e.RowIndex + 1
    End Sub
    Private Sub dgvExpense_RowPostPaint1_5(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvDataP5.RowPostPaint
        dgvDataP5("colautonum_5", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataP2.CellContentClick

    End Sub

    Private Sub DataGridView5_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataP1.CellContentClick

    End Sub

    Private Sub dgvData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataP.CellContentClick
        For i As Integer = 0 To dgvDataP.Rows.Count - 1
            dgvDataP.Rows(i).Cells(Flag1.Name).Value = 0
        Next
        If dgvDataP.Columns(e.ColumnIndex).Name = CHK1.Name Then
            If dgvDataP.Rows(e.RowIndex).Cells(Flag1.Name).Value = 0 Then
                dgvDataP.Rows(e.RowIndex).Cells(Flag1.Name).Value = 1
            End If
        End If

        For i As Integer = 0 To dgvDataP.Rows.Count - 1
            dgvDataP.Rows(i).Cells(CHK1.Name).Value = False
            If dgvDataP.Rows(i).Cells(Flag1.Name).Value = 1 Then
                dgvDataP.Rows(i).Cells(CHK1.Name).Value = True
            End If
        Next
        For i As Integer = 0 To dgvDataP.Rows.Count - 1
            dgvDataP.Rows(i).DefaultCellStyle.BackColor = Color.Gainsboro
            dgvDataP.Rows(i).Cells(CHK1.Name).Style.BackColor = Color.White
        Next

        If dgvDataP.Columns(e.ColumnIndex).Name = CHK1.Name Then
            Dim pidPv As String = dgvDataP.Rows(e.RowIndex).Cells(idPv.Name).Value
            fillAllData2(pidPv)
            dgvDataP.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.PaleGreen
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class