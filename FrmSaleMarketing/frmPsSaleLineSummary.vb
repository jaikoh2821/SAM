Public Class frmPsSaleLineSummary
    Dim dPsSale, dPsSaleMt, dPsSaleMt_copy As New DataTable
    Dim dPsLineOld, dPsTAll As New DataTable
    Dim dRSale As New DataTable
    Dim dPsLine As New DataTable
    Dim SumAllTotalNet As Double = 0
    Dim ImagePsSale As New ImageList()

    Private Sub frmPsSaleLineSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdLoadShow()
        mdCnOpen()
        'Dim dnow As Date = Date.Now
        'dtpMonth.Value.AddDays(-(dnow.Day - 1))
        'Load_PsSale()
        Load_PsLine(0)
        BindDataShow()
        mdLoadCommitt()
    End Sub

    Private Function getImg(ByVal url As String) As System.Drawing.Image
        Dim objImage As IO.MemoryStream
        Dim objwebClient As System.Net.WebClient
        Dim vImg As Image

        Try
            objwebClient = New System.Net.WebClient()
            objImage = New IO.MemoryStream(objwebClient.DownloadData(url))
            vImg = Image.FromStream(objImage)

            objwebClient.Dispose()
            Return vImg
        Catch ex As Exception
            vImg = Nothing
            Return vImg
        End Try
    End Function

    Private Sub Load_PsSale()
        mdCnOpen()
        dPsSale.Clear()
        mdLoadShow()
        'Dim subStrDate As Integer
        'Dim strDate As String
        Dim ptDate As String

        Dim strStart As Integer
        Dim strEnd As Integer
        If rbMonth.Checked = True Then
            'Dim month As String
            'If dtpMonth.Value.Month < 10 Then
            '    month = "0" & dtpMonth.Value.Month
            'Else
            '    month = dtpMonth.Value.Month
            'End If

            'strDate = (dtpMonth.Value.Year + 543) & month
            'subStrDate = 6
            ptDate = "เดือน : " & dtpMonth.Text

            strStart = ksbDateToString(dtpMonth.Value.ToShortDateString)
            strStart = (strStart \ 100) * 100 + 1
            strEnd = strStart + 30
        Else
            'strDate = (dtpYear.Value.Year + 543)
            'subStrDate = 4
            ptDate = "ปี : " & dtpYear.Text

            strStart = ksbDateToString(dtpYear.Value.ToShortDateString)
            strStart = (strStart \ 10000) * 10000 + 100

            strEnd = strStart + 1131
        End If

        ' Dim vWhereType As String = ""
        dPsSaleMt.Clear()
        'sCommand.CommandText = "Select idPsSale,PsSale ,SUM(TotalSale) AS TotalNet From vSmSaleMt WHERE " & _
        '                       "substring(DateSale,1," & subStrDate & ") = '" & strDate & "'" & vWhereType & " GROUP BY " & _
        '                       "idPsSale,PsSale Order by TotalNet DESC"

        sCommand.CommandText = "SELECT mt.idPsSale, mt.PsSale, SUM(dt.Amount*dt.Price) AS TotalNet " & _
                               "FROM vSmSaleDetail dt LEFT OUTER JOIN vSmSaleMt mt ON dt.idSale = mt.idSale WHERE dt.Price > 0.0 " & _
                               "AND mt.idPsCancel IS NULL AND mt.idComp = " & sIdComp & " AND dt.dtType <> 4 " & _
                               "AND cast(mt.DateSale as integer) between " & strStart & " and " & strEnd & " GROUP BY mt.idPsSale, " & _
                               "mt.PsSale Order by TotalNet DESC"
        sAdapter.Fill(dPsSaleMt)
        dPsSaleMt_copy = dPsSaleMt.Copy()
        dPsTAll.Clear()

        sCommand.CommandText = "SELECT l.idPs, l.PsName, l.Parent, SUM(dt.Amount*dt.Price) AS TotalNet " & _
                               "FROM SmPsSaleLine l LEFT JOIN vSmSaleMt mt ON l.idPs = mt.idPsSale " & _
                               "LEFT OUTER JOIN vSmSaleDetail dt ON mt.idSale = dt.idSale WHERE l.idComp =  " & sIdComp & " AND " & _
                               "dt.Price > 0.0 AND mt.idPsCancel IS NULL AND mt.idComp = " & sIdComp & " AND dt.dtType <> 4 " & _
                               "AND cast(mt.DateSale as integer) between " & strStart & " and " & strEnd & " Group by " & _
                                "l.idPs, l.PsName, l.Parent order by TotalNet DESC"
        sAdapter.Fill(dPsTAll)
        SumAllTotalNet = 0
        For i As Integer = 0 To dPsTAll.Rows.Count - 1
            SumAllTotalNet += dPsTAll.Rows(i).Item("TotalNet")
        Next
        lblAllTotal.Text = "รวมยอดขายทั้งหมด " & FormatNumber(SumAllTotalNet, 2).ToString & " บาท"
        mdLoadCommitt()
    End Sub

    Private Sub Load_PsLine(ByVal status As Integer)
        dRSale.Clear()
        'sCommand.CommandText = "SELECT RS.idPsSale, RD.RegionName FROM SmRegionSaleSet AS RS INNER JOIN SmRegionD AS RD " & _
        '                        "ON RS.idRegion = RD.idRegion"
        sCommand.CommandText = "SELECT RS.idPsSale, RD.RegionName FROM SmRegionSaleSet AS RS LEFT OUTER JOIN " & _
                               "SmRegionD AS RD ON RS.idRegion = RD.idRegion LEFT OUTER JOIN dPsSaleCompSet c " & _
                               "ON RS.idPsSale = c.idPsSale WHERE c.idComp = " & sIdComp
        sAdapter.Fill(dRSale)

        dPsLineOld.Clear()
        'sCommand.CommandText = "SELECT idPs,PsName,Parent FROM SmPsSaleLine "
        sCommand.CommandText = "SELECT idPs, PsName, Parent, LevelNode FROM SmPsSaleLine WHERE idComp = " & sIdComp
        sAdapter.Fill(dPsLineOld)

        dPsLine.Clear()
        ' sCommand.CommandText = "SELECT idPs,PsName,Parent FROM SmPsSaleLine Where Parent IS NULL"
        sCommand.CommandText = "SELECT idPs,PsName,Parent, LevelNode FROM SmPsSaleLine Where Parent IS NULL AND idComp = " & sIdComp
        sAdapter.Fill(dPsLine)
        If status = 0 Then
            dPsLine.Columns.Add("RegionName")
            dPsLineOld.Columns.Add("RegionName")
        End If
        For i As Integer = 0 To dPsLine.Rows.Count - 1
            Dim strRegion As String = ""
            For j As Integer = 0 To dRSale.Rows.Count - 1
                If dPsLine.Rows(i).Item("idPs") = dRSale.Rows(j).Item("idPsSale") Then
                    strRegion += dRSale.Rows(j).Item("RegionName") + ","
                End If
            Next
            If strRegion <> "" Then
                strRegion = (Microsoft.VisualBasic.Left(strRegion, strRegion.Length - 1))
            End If
            dPsLine.Rows(i).Item("RegionName") = strRegion
        Next
        For i As Integer = 0 To dPsLineOld.Rows.Count - 1
            Dim strRegion As String = ""
            For j As Integer = 0 To dRSale.Rows.Count - 1
                If dPsLineOld.Rows(i).Item("idPs") = dRSale.Rows(j).Item("idPsSale") Then
                    strRegion += dRSale.Rows(j).Item("RegionName") + ","
                End If
            Next
            If strRegion <> "" Then
                strRegion = (Microsoft.VisualBasic.Left(strRegion, strRegion.Length - 1))
            End If
            dPsLineOld.Rows(i).Item("RegionName") = strRegion
        Next
        ImagePsSale.ImageSize = New Size(48, 60)

        For i As Integer = 0 To dPsLineOld.Rows.Count - 1
            Dim url As String = "http://" & sHost & "/spm/images/pPs/" & dPsLineOld.Rows(i).Item("idPs") & ".jpg"
            Dim psimg As Image = getImg(url)
            If psimg Is Nothing = False Then
                ImagePsSale.Images.Add(dPsLineOld.Rows(i).Item("idPs").ToString, psimg)
            Else
                ImagePsSale.Images.Add(dPsLineOld.Rows(i).Item("idPs").ToString, My.Resources.ResourceManager.GetObject("personal_loan_256"))
            End If

        Next
        TreeView1.ImageList = ImagePsSale
    End Sub

    Private Sub FillTree(ByVal Key As Integer, ByVal txt As String, ByVal N As TreeNode)
        'Dim searchedValue As Integer
        '  Dim j As Integer = 0
        ' Dim checkans As Integer = 0
        mdLoadShow()
        Dim NN As TreeNode
        If N Is Nothing Then
            NN = TreeView1.Nodes.Add(Key.ToString, txt, Key.ToString, Key.ToString)
        Else
            NN = N.Nodes.Add(Key.ToString, txt, Key.ToString, Key.ToString)
        End If
        Dim dr As New DataTable
        ' sCommand.CommandText = "SELECT idPs,PsName FROM SmPsSaleLine Where Parent = " & Key
        'sCommand.CommandText = "SELECT idPs, PsName, Parent FROM SmPsSaleLine WHERE idComp = " & sIdComp & " AND Parent = " & Key
        sCommand.CommandText = "SELECT idPs, PsName, Parent FROM SmPsSaleLine WHERE idComp = " & sIdComp & " " & _
                              "AND Parent = " & Key & " AND LevelNode = " & NN.Level + 1
        sAdapter.Fill(dr)
        If dr.Rows.Count > 0 Then
            dr.Columns.Add("RegionName")
            dr.Columns.Add("TotalNet", GetType(Double))
            For i As Integer = 0 To dr.Rows.Count - 1
                Dim strRegion As String = ""
                For k As Integer = 0 To dRSale.Rows.Count - 1
                    If dr.Rows(i).Item("idPs") = dRSale.Rows(k).Item("idPsSale") Then
                        strRegion += dRSale.Rows(k).Item("RegionName") + ","
                    End If
                Next
                If strRegion <> "" Then
                    strRegion = (Microsoft.VisualBasic.Left(strRegion, strRegion.Length - 1))
                End If
                dr.Rows(i).Item("RegionName") = strRegion
            Next
            Dim checkT As Boolean = False
            For i As Integer = 0 To dr.Rows.Count - 1
                Dim totalnet As Double = 0
                'Dim strnumCus As String = ""
                'Dim strratio As String = ""
                checkT = False
                For k As Integer = 0 To dPsSaleMt_copy.Rows.Count - 1
                    If dr.Rows(i).Item("idPs") = dPsSaleMt_copy.Rows(k).Item("idPsSale") Then
                        dr.Rows(i).Item("TotalNet") = dPsSaleMt_copy.Rows(k).Item("TotalNet")
                        totalnet = dPsSaleMt_copy.Rows(k).Item("TotalNet")
                        checkT = True
                        Exit For
                    End If
                Next
                If checkT = False Then
                    dr.Rows(i).Item("TotalNet") = 0
                End If
                'If totalnet > 0 Then
                '    strnumCus = " | ยอดขาย " & FormatNumber(totalnet, 2).ToString
                'End If
                'Dim RegionName As String = ""
                'If dr.Rows(i).Item("RegionName") <> "" Then
                '    RegionName = " | " & dr.Rows(i).Item("RegionName")
                'End If
                'Dim ratio As Double = FormatNumber((totalnet * 100) / SumAllTotalNet, 2)
                'If ratio <> 0 Then
                '    strratio = " | " & ratio.ToString & " % "
                'End If
                'FillTree(dr.Rows(i).Item("idPs"), dr.Rows(i).Item("PsName") & RegionName & strnumCus & strratio, NN)
            Next
            Dim swaps As Boolean = True
            While swaps = True
                swaps = False
                For i As Integer = 0 To dr.Rows.Count - 2
                    If dr.Rows(i).Item("TotalNet") < dr.Rows(i + 1).Item("TotalNet") Then
                        Dim tempidPs As Integer = dr.Rows(i + 1).Item("idPs") 'ListofNumber(i + 1)
                        Dim tempPsName As String = dr.Rows(i + 1).Item("PsName")
                        Dim tempReg As String = dr.Rows(i + 1).Item("RegionName")
                        Dim tempTotalNet As Double = dr.Rows(i + 1).Item("TotalNet")
                        'ListofNumber(i + 1) = ListofNumber(i)
                        dr.Rows(i + 1).Item("idPs") = dr.Rows(i).Item("idPs")
                        dr.Rows(i + 1).Item("PsName") = dr.Rows(i).Item("PsName")
                        dr.Rows(i + 1).Item("RegionName") = dr.Rows(i).Item("RegionName")
                        dr.Rows(i + 1).Item("TotalNet") = dr.Rows(i).Item("TotalNet")
                        'ListofNumber(i) = temp
                        dr.Rows(i).Item("idPs") = tempidPs
                        dr.Rows(i).Item("PsName") = tempPsName
                        dr.Rows(i).Item("RegionName") = tempReg
                        dr.Rows(i).Item("TotalNet") = tempTotalNet
                        swaps = True
                    End If
                Next
            End While
            Dim strnumCus As String = ""
            Dim strratio As String = ""
            For i As Integer = 0 To dr.Rows.Count - 1
                If dr.Rows(i).Item("TotalNet") > 0 Then
                    strnumCus = " | ยอดขาย " & FormatNumber(dr.Rows(i).Item("TotalNet"), 2).ToString
                End If
                Dim RegionName As String = ""
                If dr.Rows(i).Item("RegionName") <> "" Then
                    RegionName = " | " & dr.Rows(i).Item("RegionName")
                End If
                Dim ratio As Double = FormatNumber((dr.Rows(i).Item("TotalNet") * 100) / SumAllTotalNet, 2)
                If ratio <> 0 Then
                    strratio = " | " & ratio.ToString & " % "
                End If
                FillTree(dr.Rows(i).Item("idPs"), dr.Rows(i).Item("PsName") & RegionName & strnumCus & strratio, NN)
            Next
        End If
        mdLoadCommitt()
    End Sub

    Private Sub AllCus(ByVal tnc As TreeNodeCollection)
        Dim AllnumCus As Double = 0
        Dim numCus As Double = 0
        Dim PsName As String = ""
        Dim RegionName As String = ""
        Dim strnumCus As String = ""
        For i As Integer = 0 To tnc.Count - 1
            AllnumCus = 0
            ''For j As Integer = 0 To dPsSaleMt_copy.Rows.Count - 1
            ''    If tnc(i).Name = dPsSaleMt_copy.Rows(j).Item("idPsSale").ToString Then
            ''        'PsName = dPsSale_copy.Rows(j).Item("PsName")
            ''        numCus = dPsSaleMt_copy.Rows(j).Item("Totalnet")
            ''        'RegionName = dPsSale_copy.Rows(j).Item("RegionName")
            ''        Exit For
            ''    End If
            ''Next
            'For j As Integer = 0 To dPsLineOld.Rows.Count - 1
            '    Dim a As String = tnc(i).Name
            '    Dim b As String = dPsLineOld.Rows(j).Item("idPs").ToString
            '    If tnc(i).Name = dPsLineOld.Rows(j).Item("idPs").ToString Then
            '        PsName = dPsLineOld.Rows(j).Item("PsName")
            '        'numCus = dPsLine.Rows(j).Item("Totalnet")
            '        RegionName = dPsLineOld.Rows(j).Item("RegionName")
            '        Exit For
            '    End If
            'Next
            If tnc(i).Nodes.Count > 0 Then
                For j As Integer = 0 To dPsSaleMt_copy.Rows.Count - 1
                    If tnc(i).Name = dPsSaleMt_copy.Rows(j).Item("idPsSale").ToString Then
                        'PsName = dPsSale_copy.Rows(j).Item("PsName")
                        numCus = dPsSaleMt_copy.Rows(j).Item("Totalnet")
                        'RegionName = dPsSale_copy.Rows(j).Item("RegionName")
                        Exit For
                    End If
                Next
                If numCus > 0 Then
                    strnumCus = " | ยอดขาย " & FormatNumber(numCus, 2).ToString
                End If
                For j As Integer = 0 To dPsLineOld.Rows.Count - 1
                    Dim a As String = tnc(i).Name
                    Dim b As String = dPsLineOld.Rows(j).Item("idPs").ToString
                    If tnc(i).Name = dPsLineOld.Rows(j).Item("idPs").ToString Then
                        PsName = dPsLineOld.Rows(j).Item("PsName")
                        'numCus = dPsLine.Rows(j).Item("Totalnet")
                        RegionName = dPsLineOld.Rows(j).Item("RegionName")
                        Exit For
                    End If
                Next
                If RegionName <> "" Then
                    RegionName = " | " & RegionName
                End If
                AllnumCus = numCus + CountAllCus(tnc(i).Nodes)
                Dim strratio As String = ""
                Dim ratio As Double = FormatNumber((numCus * 100) / SumAllTotalNet, 2)
                If ratio <> 0 Then
                    strratio = " | " & ratio.ToString & " % "
                End If
                tnc(i).Text = PsName & RegionName & strnumCus & strratio & " | รวมยอดขาย " & FormatNumber(AllnumCus, 2).ToString
                AllCus(tnc(i).Nodes)
            End If
        Next
    End Sub

    Private Function CountAllCus(ByVal tnc As TreeNodeCollection) As Double
        Dim AllnumCus As Double = 0
        Dim numCus As Double = 0
        For i As Integer = 0 To tnc.Count - 1
            numCus = 0
            For j As Integer = 0 To dPsSaleMt_copy.Rows.Count - 1
                If tnc(i).Name = dPsSaleMt_copy.Rows(j).Item("idPsSale").ToString Then
                    numCus = dPsSaleMt_copy.Rows(j).Item("TotalNet")
                    Exit For
                End If
            Next
            AllnumCus += numCus
            'TreeView1.TopNode.Name
            If tnc(i).Nodes.Count > 0 Then
                AllnumCus += CountAllCus(tnc(i).Nodes)
                'If AllnumCus > 0 Then
                '    tnc(i).Text += " | รวมลูกค้า " & AllnumCus.ToString
                '    'AllnumCus = 0
                'End If
            End If
        Next
        Return AllnumCus
    End Function

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        'MessageBox.Show(TreeView1.SelectedNode.Text)
        If TreeView1.SelectedNode.Nodes.Count >= 0 Then
            mdLoadShow()
            Dim dPsSaleT As New DataTable
            Dim strStart As Integer
            Dim strEnd As Integer
            'Dim subStrDate As Integer
            'Dim strDate As String
            If rbMonth.Checked = True Then
                'Dim month As String
                'If dtpMonth.Value.Month < 10 Then
                '    month = "0" & dtpMonth.Value.Month
                'Else
                '    month = dtpMonth.Value.Month
                'End If

                'strDate = (dtpMonth.Value.Year + 543) & month
                'subStrDate = 6

                strStart = ksbDateToString(dtpMonth.Value.ToShortDateString)
                strStart = (strStart \ 100) * 100 + 1
                strEnd = strStart + 30
            Else
                strStart = ksbDateToString(dtpYear.Value.ToShortDateString)
                strStart = (strStart \ 10000) * 10000 + 100

                strEnd = strStart + 1131
                'strDate = (dtpYear.Value.Year + 543)
                'subStrDate = 4
            End If

            Dim vWhere As String = TreeView1.SelectedNode.Name & ","
            vWhere += find_sale(TreeView1.SelectedNode.Nodes)
            vWhere = (Microsoft.VisualBasic.Left(vWhere, vWhere.Length - 1))
            dPsSaleT.Clear()
            'sCommand.CommandText = "SELECT vSmSaleMt.idPsSale, vPerson.PsName, SUM(vSmSaleMt.TotalSale) AS TotalNet " & _
            '                       "FROM vSmSaleMt LEFT OUTER JOIN vPerson ON vSmSaleMt.idPsSale = vPerson.idPs WHERE " & _
            '                       "substring(DateSale,1," & subStrDate & ") = '" & strDate & "' AND " & _
            '                       "vSmSaleMt.idPsSale IN (" & vWhere & ") GROUP BY vSmSaleMt.idPsSale, vPerson.PsName " & _
            '                       "Order by TotalNet DESC"

            sCommand.CommandText = "SELECT mt.idPsSale, mt.PsSale, SUM(dt.Amount*dt.Price) AS TotalNet " & _
                                   "FROM vSmSaleDetail dt LEFT OUTER JOIN vSmSaleMt mt ON dt.idSale = mt.idSale WHERE dt.Price > 0.0 " & _
                                   "AND mt.idPsCancel IS NULL AND mt.idComp = " & sIdComp & " AND dt.dtType <> 4 " & _
                                   "AND cast(mt.DateSale as integer) between " & strStart & " and " & strEnd & " AND mt.idPsSale " & _
                                   "IN (" & vWhere & ") GROUP BY mt.idPsSale, mt.PsSale Order by TotalNet DESC"

            sAdapter.Fill(dPsSaleT)
            dPsSaleT.Columns.Add("ratio", GetType(Double))
            Dim AllTotalnet As Double = 0
            For i As Integer = 0 To dPsSaleT.Rows.Count - 1
                'dPsSaleT.Rows(i).Item("ratio") = 0
                AllTotalnet += dPsSaleT.Rows(i).Item("TotalNet")
            Next
            For i As Integer = 0 To dPsSaleT.Rows.Count - 1
                dPsSaleT.Rows(i).Item("ratio") = FormatNumber((dPsSaleT.Rows(i).Item("TotalNet") * 100) / AllTotalnet, 2)
            Next
            dgv_SaleSum.DataSource = dPsSaleT
            mdLoadCommitt()
        End If
    End Sub

    Private Sub dgv_SaleSum_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgv_SaleSum.RowPostPaint
        Me.dgv_SaleSum("colautonum", e.RowIndex).Value = e.RowIndex + 1
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        BindDataShow()
    End Sub

    Sub BindDataShow()
        TreeView1.Nodes.Clear()
        Load_PsSale()
        For i As Integer = 0 To dPsLine.Rows.Count - 1
            Dim totalnet As Double = 0
            Dim strnumCus As String = ""
            For k As Integer = 0 To dPsSaleMt_copy.Rows.Count - 1
                If dPsLine.Rows(i).Item("idPs") = dPsSaleMt_copy.Rows(k).Item("idPsSale") Then
                    totalnet = dPsSaleMt_copy.Rows(k).Item("TotalNet")
                    Exit For
                End If
            Next
            If totalnet > 0 Then
                strnumCus = " | ยอดขาย " & FormatNumber(totalnet, 2).ToString
            End If
            Dim RegionName As String = ""
            If dPsLine.Rows(i).Item("RegionName") <> "" Then
                RegionName = " | " & dPsLine.Rows(i).Item("RegionName")
            End If
            Dim strratio As String = ""
            Dim ratio As Double = FormatNumber((totalnet * 100) / SumAllTotalNet, 2)
            If ratio <> 0 Then
                strratio = " | " & ratio.ToString & " % "
            End If
            FillTree(dPsLine.Rows(i).Item("idPs"), dPsLine.Rows(i).Item("PsName") & RegionName & strnumCus & strratio, Nothing)
        Next
        AllCus(TreeView1.Nodes)
    End Sub

    Private Function find_sale(ByVal tnc As TreeNodeCollection) As String
        Dim stridPsSale As String = ""
        For i As Integer = 0 To tnc.Count - 1
            stridPsSale += tnc(i).Name & ","
            If tnc(i).Nodes.Count > 0 Then
                stridPsSale += find_sale(tnc(i).Nodes)
            End If
        Next
        Return stridPsSale
    End Function

    Private Function BubbleSortNumber(ByVal ListofNumber As List(Of Integer)) As List(Of Integer)
        Dim swaps As Boolean = True
        While swaps = True
            swaps = False
            For i As Integer = 0 To ListofNumber.Count - 2
                If ListofNumber(i) > ListofNumber(i + 1) Then
                    Dim temp As Integer = ListofNumber(i + 1)
                    ListofNumber(i + 1) = ListofNumber(i)
                    ListofNumber(i) = temp
                    swaps = True
                End If
            Next
        End While
        Return ListofNumber
    End Function

    Private Sub dtpYear_ValueChanged(sender As Object, e As EventArgs) Handles dtpYear.ValueChanged, dtpMonth.ValueChanged
        ClearDataGrid()
    End Sub

    Private Sub rbMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rbMonth.CheckedChanged
        If Me.rbMonth.Checked = True Then
            ClearDataGrid()
            TreeView1.Nodes.Clear()
            lblAllTotal.Text = "รวมยอดขายทั้งหมด 0.00 บาท"

            dtpMonth.Enabled = True
            dtpYear.Enabled = False
        End If
    End Sub

    Private Sub rbYear_CheckedChanged(sender As Object, e As EventArgs) Handles rbYear.CheckedChanged
        If Me.rbYear.Checked = True Then
            ClearDataGrid()
            TreeView1.Nodes.Clear()
            lblAllTotal.Text = "รวมยอดขายทั้งหมด 0.00 บาท"
            dtpMonth.Enabled = False
            dtpYear.Enabled = True
        End If
    End Sub

    Sub ClearDataGrid()
        Dim dPsSaleT As New DataTable
        dPsSaleT.Columns.Add("idPsSale", GetType(Int32))
        dPsSaleT.Columns.Add("PsSale", GetType(String))
        dPsSaleT.Columns.Add("TotalNet", GetType(Double))
        dPsSaleT.Columns.Add("ratio", GetType(Double))
        dgv_SaleSum.DataSource = dPsSaleT
    End Sub

End Class