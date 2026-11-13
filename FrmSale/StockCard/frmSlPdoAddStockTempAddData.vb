Public Class frmSlPdoAddStockTempAddData
    Public pidPdo As String = ""
    Public pPdoName As String = ""
    Public pidWhSent As String = ""
    Public pInvNameSent As String = ""

    Public pnamePd As String
    Public BeforeAmount As String
    Public pBarcode As String = ""
    Public pCode As String = ""
    Public punit As String = ""
    Public pAmount As Integer = 0
    Public pLotNum As String = ""
    Public DocDate As String = ""
    Public Note As String = ""
    Public hum As Integer = 0
    Public mec As Integer = 0
    Public DocNum As String = ""
    Public DateGen As String = ""
    Dim gphum As Integer = 0
    Dim sDt_pddata As New DataTable
    Dim flag As Integer = 0
    Dim Process As eProcess
    Dim ds As New DataSet



    Enum eProcess
        eSelect
        eEdit
        eShow
    End Enum

    Sub New(ByVal aProcess As eProcess)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Select Case aProcess
            Case eProcess.eSelect
                Process = eProcess.eSelect
            Case eProcess.eEdit
                Process = eProcess.eEdit
            Case eProcess.eShow
                Process = eProcess.eShow
                btn_Pscommand.Enabled = False
                txtPdName.Enabled = False
                DateDoc1.Enabled = False
                txtDocNum.Enabled = False
                txtLotNum.Enabled = False
                DTP1.Enabled = False
                txtAmount.Enabled = False
                txtNote.Enabled = False
                txtInvName.Enabled = False
                Button1.Enabled = False
                btn_save.Visible = False
        End Select
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        pAmount = CType(txtAmount.Text, Integer)
        pLotNum = txtLotNum.Text
        DocDate = DateDoc1.Value
        DocNum = txtDocNum.Text
        Note = txtNote.Text
        DateGen = DTP1.Value
        If pidWhSent = "" Then
            MessageBox.Show("กรุณาเลือกคลัง", sSystemName)
            Exit Sub
        End If
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    'Private Sub btn_Pscommand_Click(sender As Object, e As EventArgs) Handles btn_Pscommand.Click
    '    Dim frm As New frmPdOtherSelect(frmPdOtherSelect.eProcess.eSelect)
    '    frm.ShowDialog()
    '    If frm.DialogResult = Windows.Forms.DialogResult.OK Then
    '        pidPdo = frm.idPdO
    '        pPdoName = frm.PdoName
    '        txtPdName.Text = pPdoName
    '        txtAmount.Enabled = True
    '        txtLotNum.Enabled = True
    '        txtDocNum.Enabled = True
    '        DateDoc1.Focus()
    '    Else
    '        flag = 1
    '    End If
    '    If flag = 0 Then
    '        mdCnOpen()
    '        Dim sDt As New DataTable
    '        sCommand.CommandText = "Select idPdO,PdoName,PUnit.UnitName From SmPdOtherD LEFT JOIN PchInvAndProject.dbo.dInvUnit AS PUnit ON PUnit.idUnit = SmPdOtherD.idUnit_Pch WHERE idPdO = " & pidPdo
    '        sAdapter.Fill(sDt)
    '        pPdoName = sDt.Rows(0).Item("PdoName")
    '        pidPdo = sDt.Rows(0).Item("idPdO")
    '        punit = sDt.Rows(0).Item("UnitName")
    '        UnitPkLabel.Text = punit
    '        txtPdName.Text = pPdoName
    '    End If

    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim vFrm As New frmInvManageAll(frmInvManageAll.eProcess.eSelect)
    '    vFrm.ShowDialog()
    '    If vFrm.DialogResult = Windows.Forms.DialogResult.OK Then
    '        pidWhSent = vFrm.pidWhSent
    '        pInvNameSent = vFrm.pInvNameSent
    '        txtInvName.Text = pInvNameSent
    '    End If
    'End Sub

    Private Sub frmSlPdoAddStockTempAddData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Process = eProcess.eSelect Then
        '    Dim frm As New frmPdOtherSelect(frmPdOtherSelect.eProcess.eSelect)

        '    frm.ShowDialog()
        '    If frm.DialogResult = Windows.Forms.DialogResult.OK Then
        '        pidPdo = frm.idPdO
        '        pPdoName = frm.PdoName
        '        txtPdName.Text = pPdoName
        '        txtAmount.Enabled = True
        '        txtLotNum.Enabled = True
        '        txtDocNum.Enabled = True
        '        DateDoc1.Focus()
        '        DateDoc1.Value = Date.Today
        '        DTP1.Value = Date.Today
        '    Else
        '        flag = 1
        '    End If




        '    If flag = 0 Then
        '        mdCnOpen()
        '        Dim sDt As New DataTable
        '        sCommand.CommandText = "Select idPdO,Title,PUnit.UnitName From SmPdOtherD LEFT JOIN PchInvAndProject.dbo.dInvUnit AS PUnit ON PUnit.idUnit = SmPdOtherD.idUnit_Pch WHERE idPdO = " & pidPdo
        '        sAdapter.Fill(sDt)
        '        pPdoName = sDt.Rows(0).Item("Title")
        '        pidPdo = sDt.Rows(0).Item("idPdO")
        '        punit = sDt.Rows(0).Item("UnitName")
        '        UnitPkLabel.Text = punit
        '        txtPdName.Text = pPdoName
        '    End If
        'End If
        If Process = eProcess.eShow Then
            btn_Pscommand.Enabled = False
            txtPdName.Enabled = False
            DateDoc1.Enabled = False
            txtDocNum.Enabled = False
            txtLotNum.Enabled = False
            DTP1.Enabled = False
            txtAmount.Enabled = False
            txtNote.Enabled = False
            txtInvName.Enabled = False
            Button1.Enabled = False
            btn_save.Visible = False
        End If
       

    End Sub

    Public Sub Get_Data(ByVal gidpdo As String, ByVal gDateDoc As String, ByVal gLotNum As String, ByVal gAmount As Integer, ByVal gnote As String, ByVal gDocNum As String, ByVal gidWh As String, ByVal gInvName As String, ByVal gDateGen As String)
        mdCnOpen()
        Dim sDt As New DataTable
        sCommand.CommandText = "Select idPdO,Title From SmPdOtherD WHERE idPdO = " & gidpdo
        sAdapter.Fill(sDt)
        pnamePd = sDt.Rows(0).Item("Title")
        pidPdo = sDt.Rows(0).Item("idPdO")
        UnitPkLabel.Text = punit
        txtPdName.Text = pnamePd
        DateDoc1.Value = gDateDoc
        txtLotNum.Text = gLotNum
        txtAmount.Text = gAmount
        txtDocNum.Text = gDocNum
        DTP1.Value = ksbStringToDate(gDateGen)
        txtNote.Text = gnote
        txtInvName.Text = gInvName
        pidWhSent = gidWh
    End Sub


End Class