Public Class Form2
    'Private cn As New DB.Connection
    'Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim rp As New CrystalReport9x11
    '    Dim ds As New DataSet

    '    Dim sqlMt As String
    '    sqlMt = "Select m.idSale, m.DateTsD, m.DateSaleD, devsk.fncStrDateToDateTime(m.DatePay) As DatePay, '' As RegionName, " & _
    '                           " m.DocCode, m.DocRef, m.Total, m.TotalNet, m.PartnerNameBill, m.PsSale , m.PaymentTerms, m.Transport, m.note," & _
    '                           " c.address, m.AddressS, (CASE c.TelOffice WHEN '' THEN c.Mobile1 ELSE c.TelOffice END) As Tel, " & _
    '                           " c.Fax, c.TaxCode, m.idPsSale, m.idPsSet, m.idPsSend, ISNULL(m.idCus,0) As idCus, m.PsRecName, m.TelOfAddrSent, ISNULL(m.stFromS, 1) As stFromS " & _
    '                           " FROM vSmSaleMt m" & _
    '                           " LEFT JOIN dPartner pn ON m.idPartner = pn.idPartner" & _
    '                           " LEFT JOIN dCustomer c ON m.idCus = c.idCus " & _
    '                           " WHERE m.idSale IN(215662,215661,215660,215658,215657)"

    '    Dim dtSmSaleMt As DataTable = cn.GetDataTable(sqlMt, "dtSmSaleMt")
    '    Dim sqlDt As String
    '    sqlDt = "SELECT d.idSale,d.idProduct, d.ProductName, d.Price, SUM(d.Amount) AS AmountAllSale," & _
    '                " ISNULL(unit.UnitShort, unit.UnitName) As UnitName," & _
    '                " STRING_AGG( d.LotNo + ' (' + FORMAT(d.Amount, 'N2') + ')', ', ') WITHIN GROUP (ORDER BY d.LotNo) AS [LotDetailUsed] ," & _
    '                " ISNULL(pk.PdPkName3, d.ProductName) As ProductNoWeight" & _
    '                " FROM SmSaleDtAll d " & _
    '                " LEFT JOIN dInvUnit unit ON d.idUnit = unit.idUnit " & _
    '                " LEFT JOIN dInventoryMain inv ON inv.idInvMain = d.idProduct AND inv.idInvGroup = 2" & _
    '                " LEFT JOIN vPackingPdSet pk ON inv.idSubType = pk.idPdPk" & _
    '                " WHERE d.idSale IN(215662,215661,215660,215658,215657) " & _
    '                " GROUP BY d.idSale,d.idProduct, d.ProductName, d.Price, unit.UnitShort, unit.UnitName ,d.No, pk.PdPkName3" & _
    '                " Order By d.No ASC, d.Price DESC"
    '    Dim dtSmSaleDtAll As DataTable = cn.GetDataTable(sqlDt, "dtSmSaleDtAll")
    '    ds.Tables.Add(dtSmSaleMt)
    '    ds.Tables.Add(dtSmSaleDtAll)
    '    ds.Relations.Add(ds.Tables("dtSmSaleMt").Columns("idSale"), ds.Tables("dtSmSaleDtAll").Columns("idSale"))

    '    rp.SetDataSource(ds)
    '    CrystalReportViewer1.ReportSource = rp
    '    CrystalReportViewer1.Refresh()
    'End Sub
End Class