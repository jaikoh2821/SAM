Imports System.Windows.Forms
Imports System.IO

Public Class MDIMain
    '  Public mLoading As New frmLoading
    'Private m_ChildFormNumber As Integer = 0
    Public mFrm As New Form
    ' Dim mCloseForLogin As Boolean = False
    ' Dim mLogOff As Boolean = False

#Region "ChkUser"
    'Private mColtMenu As New Collection

    'Private Sub pMenuSet()
    '    '   mColtMenu = sClsCollection.AddMember(tsmnProductData, tsmnMemberData, tsmnMemberMonth, tsmnDraw, tsmnuSummary, tsmnuProductType, tsmnReceive, tsmnReceiveData, tsmnuSales, tsmnuSalesEdit, tsmnuSalesReturn, tsmnuProductGroup, tsmnuProductSection)
    '    'For Each vObj As Object In mColtMenu
    '    '    vObj.Enabled = False
    '    'Next
    '    For Each vTs As Object In ToolStrip.Items
    '        If TypeOf vTs Is ToolStripDropDownButton Then
    '            For Each vItm As Object In CType(vTs, ToolStripDropDownButton).DropDownItems
    '                If TypeOf vItm Is ToolStripMenuItem Then
    '                    vItm.Enabled = False
    '                End If
    '            Next
    '        End If
    '    Next
    'End Sub
    Private Sub pChkMenuAccess()
        'Select Case sUser
        '    Case "user"
        '        ksbControlsVisibleFalse(mnuSysUserAccess)  ', mnuUserSet
        '        mdMenuAccess(MenuStrip)
        '    Case "admin" : mdMenuUnlock(MenuStrip)

        'End Select
        'mdMenuUnlock(MenuStrip)
        If sUser <> "admin" Then pMenuAccess(Me.MenuStrip, "SAM")
    End Sub

    Dim dPsMenu As New DataTable
    Dim lbrDbCore As New KsbLibrary.Database.DatabaseManage()
    Dim sCmd As System.Data.SqlClient.SqlCommand
    Dim sAdt As System.Data.SqlClient.SqlDataAdapter

    'Private Sub pMenuAccess(ByVal aSys As String)
    '    lbrDbCore.Connecting(My.Settings.cnCore, KsbLibrary.Database.DatabaseManage.DbType.SqlServer)
    '    sCmd = New System.Data.SqlClient.SqlCommand("", lbrDbCore.mCnSqlServ)
    '    sAdt = New System.Data.SqlClient.SqlDataAdapter(sCmd)
    '    '  dPsMenu.Clear()
    '    sCmd.CommandText = "SELECT MenuUserSet.MenuCode, MenuUserPs.idPs FROM MenuUserSet INNER JOIN " & _
    '    "MenuUser ON MenuUserSet.idUser = MenuUser.idUser INNER JOIN MenuUserPs ON MenuUser.idUser = MenuUserPs.idUser " & _
    '    "WHERE (MenuUserPs.idPs = " & sPsId & ") AND (MenuUser.MenuSys = '" & aSys & "')"

    '    sAdt.Fill(dPsMenu)
    '    'Me.MenuStrip1.Items("Tsm1").Enabled = False
    '    SetAllMenuItems(Me.MenuStrip, "SAM")
    'End Sub
    Private Sub pMenuAccess(ByRef menuStrip As MenuStrip, ByVal sysWhere As String)
        dPsMenu.Clear()
        mdCore_Connect()
        sCommand.CommandText = "SELECT dbo.MenuUserSet.MenuCode, dbo.MenuUserPs.idPs FROM dbo.MenuUserSet INNER JOIN " & _
        "dbo.MenuUser ON dbo.MenuUserSet.idUser = dbo.MenuUser.idUser INNER JOIN dbo.MenuUserPs ON dbo.MenuUser.idUser = dbo.MenuUserPs.idUser " & _
        "WHERE (dbo.MenuUserPs.idPs = " & sPsId & ") AND (dbo.MenuUser.MenuSys = '" & sysWhere & "')"
        sAdapter.Fill(dPsMenu)
        Dim c As ToolStripItem
        Dim t As ToolStripMenuItem
        For Each c In menuStrip.Items
            c.Enabled = True
            If c.GetType Is GetType(ToolStripMenuItem) Then
                t = c
                SetAllMenuItems(t.DropDownItems)
            End If
        Next
    End Sub


    Dim chead As Boolean = False
    Private Sub SetAllMenuItems(ByRef menus As ToolStripItemCollection)
        Dim c As ToolStripItem
        Dim t As ToolStripMenuItem
        For Each c In menus
            c.Enabled = False
            For i As Integer = 0 To dPsMenu.Rows.Count - 1
                If c.Tag = dPsMenu.Rows(i).Item("MenuCode") Then
                    c.Enabled = True
                    Exit For
                End If
            Next
            If c.GetType Is GetType(ToolStripMenuItem) Then
                t = c
                If t.DropDownItems.Count > 0 Then
                    c.Enabled = True
                End If
                SetAllMenuItems(t.DropDownItems)
            End If
        Next
    End Sub

    'Private Sub pChkUserLevel()
    '    If sUserLevel <> "0" Then
    '        tsmnuSalesEdit.Visible = False
    '        tsmnReceiveData.Visible = False
    '    End If
    'End Sub
#End Region

    Public Sub pFrmShow()
        Dim vFrm As New Form
        If mFrm.Tag <> "System" Then
            For Each vFrm In Me.MdiChildren
                If (vFrm.WindowState = FormWindowState.Maximized And mFrm.WindowState = FormWindowState.Normal) _
                Or (vFrm.WindowState = FormWindowState.Normal And mFrm.WindowState = FormWindowState.Maximized) Then
                    vFrm.WindowState = FormWindowState.Normal
                End If
                If vFrm.Tag = "System" Then vFrm.WindowState = FormWindowState.Normal
                If vFrm Is mFrm = True Then mFrm.Activate() : Exit Sub
            Next
        End If

        mFrm.MdiParent = Me

        '     mFrm.StartPosition = FormStartPosition.CenterScreen

        'mFrm.Text = sMsgTitle
        '     mFrm.MaximizeBox = True
        'mFrm.WindowState = FormWindowState.Maximized
        mFrm.Show()
        ' mFrmDetail.WindowState = FormWindowState.Normal
    End Sub

    Private Sub pFrmClose()
        Try
            For Each vFrm As Form In Me.MdiChildren
                If vFrm.Tag <> "System" Then vFrm.Close()
            Next
        Catch

        End Try      
    End Sub


    Private Sub MDIMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            'Dim vDir As System.IO.Directory
            If Directory.Exists("C:\GrSystemTemp") = True Then Directory.Delete("C:\GrSystemTemp")
        Catch
        End Try
    End Sub

    Private Sub MDIMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'nfiAlertInventory.Visible = False
        'nfiAlertMember.Visible = False
        'nfiAlertInventory.Dispose()
        'nfiAlertMember.Dispose()
        'If mCloseForLogin = False Then
        Application.Exit()
        ' End If
    End Sub

    Public Sub pAuthentication()
        ' mdConnectDb()
        '   pFrmClose()
        '   mFrm = New frmSysCompSelect
        '   pFrmShow()
        MenuStrip.Enabled = True
        'Dim vFrmComp As New frmSysCompSelect
        'If vFrmComp.ShowDialog() <> Windows.Forms.DialogResult.OK Then Application.Exit()
        pChkMenuAccess()
        ' pChkAlert()
        '  mdReportSetPerfomance()
        '   lblVersion.Text = "Update เมื่อวันที่  " & ksbStringToDate(My.Settings.Vers.Substring(0, 8)) & "  " & My.Settings.Vers.Substring(8, 2) & ":" & My.Settings.Vers.Substring(10, 2)
        Try
            With My.Application.Deployment.CurrentVersion
                Me.Tag = .Build.ToString & "/" & .Minor.ToString & "/" & .Major.ToString & "   " & .Revision.ToString.Substring(0, 2) & " : " & .Revision.ToString.Substring(2, 2)
            End With
        Catch
            Me.Tag = Now.ToShortDateString & "   " & Now.ToShortTimeString
        End Try
        lblVersion.Text = "Update เมื่อวันที่ : " & Me.Tag
        lblComp.Text = " เข้าใช้งานข้อมูล " & sCompName
        lblPs.Text = " ผู้เข้าใช้งาน : " & sPsName
        lblDate.Text = " วันที่ปัจจุบัน : " & Now.ToShortDateString

        '---Close 25/6/2019 >> Update Sale table---'
        'mFrm = New frmSaleDateChart
        'pFrmShow()

        'mFrm.WindowState = FormWindowState.Maximized
        'mFrm.Activate()
        'mFrm.MdiParent = Me
        'mFrm.Show()


        mdAlertSaleOrder()
    End Sub
  
    Private Sub pLogin()

        pFrmClose()
        ' MenuStrip.Enabled = False

        sPsName = lbrDb.SQLExecuteReturnValue("Max", "PsName", "vPerson", "idPs=" & sPsId)
        pCompSelect()
        'pMenuAccess(Me.MenuStrip, "SAM")
    End Sub

    Public Sub pCompSelect()
        pFrmClose()
        MenuStrip.Enabled = False
        mFrm = New frmSysCompSelect  'frmSysCompSelect
        pFrmShow()
    End Sub



    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit_.Click
        Application.Exit()
    End Sub

    Private Sub MainMenuDental_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' If mLogOff = False Then
        '  mdPathTmpDelete()
        Application.Exit()
        ' End If
    End Sub

   
    Private Sub MDIMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        For Each vFrm As Form In Me.MdiChildren
            If vFrm.Tag = "System" Then
                vFrm.Opacity = 40
                vFrm.WindowState = FormWindowState.Normal
            End If
        Next
    End Sub

    Private Sub nfiUpdateAlert_BalloonTipClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles nfiUpdate.BalloonTipClosed
        sender.visible = False
        Me.Refresh()
    End Sub

    Private Sub MDIMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'lbrMsg.MsgWarning("ยังไม่สามารถใช้งานได้ อยู่ระหว่างการปรับปรุงระบบ")
        'Application.Exit()
        'Exit Sub

        mdConnectDb()

        Dim vUserPs As New GrTeamSystem.GrsApplication(GrTeamSystem.GrsApplication.eProcess.eUserLogin)
        sUser = vUserPs.GetUser
        sPsId = vUserPs.GetIdPs

        If My.Settings.PortalCheck = True Then
            If vUserPs.PortalCheckLink = False Then Application.Exit() : Exit Sub
        End If

        pLogin()
    End Sub

    Private Sub mnuSl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSlPdPkPrice.Click,
         mnuSlSummary.Click, mnuSlSaleRpt.Click, mnuSaleTsLot.Click, mnuSaleData.Click, mnuSaleCancel.Click, mnuSaleAccept.Click,
         mnuSaleCheck.Click, mnuSaleApprove.Click, mnuOrderSaleLot.Click, mnuCancelApv.Click, ReturnToSaleMenuItem.Click,
            mnuSaleNoteCenter.Click, StockCardMainMenuItem.Click, mnuStockTran.Click, mnuRptInvoice.Click,
            mnuSaleTsSH.Click, mnuSaleDataSH.Click, mnuSaleCancelSH.Click, mnuSaleGroupSH.Click, mnuOrderWaitToSale.Click, mnuSlSaleBack.Click

        ' Dim tempDt As New DataTable
        Select Case sender.name
            'Case mnuOrderSaleTemp.Name : mFrm = New frmSlOrderToSale_temp(frmSlOrderToSale_temp.eProcess.eNew, Nothing, Nothing, Nothing, Nothing)
            'Case mnuSaleTsTemp.Name : mFrm = New frmSlMain_temp

            Case mnuOrderSaleLot.Name : mFrm = New frmSlOrderToSale(frmSlOrderToSale.eProcess.eNew, "", 0, 0, "")
            Case mnuSaleTsLot.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eAddCombine)

            Case ReturnToSaleMenuItem.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eAddXY)
                'Case ReturnToSaleMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eNewSale, Nothing, tempDt)

                'คำอธิบายรายการ
            Case mnuSaleNoteCenter.Name : mFrm = New frmNoteSelect(frmNoteSelect.eProcess.eAdd, sIdComp)

            Case mnuSaleData.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eView)
            Case mnuSaleCancel.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eCancel)
            Case mnuSlSummary.Name : mFrm = New frmSaleSummaryRpt
            Case mnuSlSaleRpt.Name : mFrm = New frmSaleRpt
            Case mnuSlPdPkPrice.Name : mFrm = New frmPdPkPriceRpt

            Case mnuSaleAccept.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eAccept)
            Case mnuSaleCheck.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eCheck)
            Case mnuSaleApprove.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eApprove)
            Case mnuCancelApv.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eCancelApv)
                ' Case mnuSlSaleTsAll.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eAddCombine)

            Case StockCardMainMenuItem.Name : mFrm = New frmStockCardInvLot 'stockcard
            Case mnuStockTran.Name : mFrm = New frmStockCardInventory(frmStockCardInventory.eProcess.eviewData) 'transaction stock

            Case mnuRptInvoice.Name : mFrm = New FrmRptInvoice

            Case mnuSaleTsSH.Name : mFrm = New FrmWaitCrateBillSH(FrmWaitCrateBillSH.eProcess.eWaitXAdd) 'ทำรายการขายสินค้าโสหุ้ย จากรายการเบิกของ SPM
            Case mnuSaleDataSH.Name : mFrm = New FrmSlSaleDataSH(FrmSlSaleDataSH.eProcess.eView) 'ข้อมูลรายการขายสินค้าโสหุ้ย
            Case mnuSaleCancelSH.Name : mFrm = New FrmSlSaleDataSH(FrmSlSaleDataSH.eProcess.eCancel) 'ยกเลิกข้อมูลรายการขายสินค้าโสหุ้ย
            Case mnuSaleGroupSH.Name : mFrm = New FrmSlSaleGroupMt(FrmSlSaleGroupMt.eProcess.eNew) 'รวบรวมใบแจ้งหนี้สินค้าโสหุ้ย
                'Case StockCardPdPkMenuItem.Name : mFrm = New frmPdPkStockCard
                'Case StockCardPdMenuItem.Name : mFrm = New frmPdMixStockCard
                'Case StockCardOtherMenuItem.Name : mFrm = New frmPdoStockCard

            Case mnuOrderWaitToSale.Name : mFrm = New FrmOrderWaitToSale(FrmOrderWaitToSale.eProcess.eBillTs) 'รายการออเดอร์รอเปิดบิลขาย

            Case mnuSlSaleBack.Name : mFrm = New frmSlSaleData(frmSlSaleData.eProcess.eAddBack)
                'New frmSlSaleBack(frmSlSaleBack.eProcess.eAddBack)
        End Select
        pFrmShow()
    End Sub


    'Private Sub mnuMkCusData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCusData.Click,
    '     mnuCusDoc.Click, mnuCusBusinessStSet.Click,
    '    frmCusRpt.Click,
    '  mnuCusCompIn.Click, mnuCusEvent.Click, mnuPsSaleCommSet.Click, mnuPsSaleCommSummary.Click,
    '    mnuPssEvent.Click,
    '     mnuCusCompSet.Click,
    '    PssSaleSummaryMenuItem.Click

    '    mdCnOpen()
    '    Select Case sender.name
    '        Case PssSaleSummaryMenuItem.Name : mFrm = frmPssSaleSummary

    '            'Case mnuCusData.Name : mFrm = frmCustomerData
    '            'Case mnuCusMap.Name : mFrm = New frmSlCusMapAll
    '            'Case mnuCusPic.Name : mFrm = frmMkCusPicSet
    '            'Case mnuCusDoc.Name : mFrm = frmCusCommercePic
    '            'Case mnuCusMapSet.Name : mFrm = frmCusMapSet
    '            'Case mnuCusBusinessStSet.Name : mFrm = frmCusBusinessSt
    '            '    'Case mnuCusAdsSent.Name : mFrm = frmCusAdsSent
    '            '    ' Case mnuMkSaleCusMap.Name : mFrm = New frmSlCusMapAll
    '            'Case mnuCusLevel.Name : mFrm = New frmCusLevelData
    '            'Case mnuCusLevelSet.Name : mFrm = New frmCusLevelSet




    '            'Case mnuPsSaleExpenseSet.Name : mFrm = New frmMkPsSaleExpenseData
    '            'Case mnuPsSaleExpenseTs.Name : mFrm = New frmMkPsSaleExpenseTsData(frmMkPsSaleExpenseTsData.eProcess.eSelectManage)
    '            'Case mnuPsSaleExpenseData.Name : mFrm = New frmMkPsSaleExpenseTsData(frmMkPsSaleExpenseTsData.eProcess.eSelectData)
    '            'Case mnuPsSaleExpenseCancel.Name : mFrm = New frmMkPsSaleExpenseTsData(frmMkPsSaleExpenseTsData.eProcess.eSelectCancle)
    '            ' Case mnuPsSaleTrip.Name : mFrm = New frmPsSaleTrip
    '        Case frmCusRpt.Name : mFrm = New frmCusRpt
    '            'Case mnuCusCompIn.Name : mFrm = New frmCusCompSet

    '            'Case mnuCusRightSet.Name : mFrm = New frmCustomerRight
    '            'Case mnuCusEvent.Name : mFrm = New frmCustomerEvent
    '        Case mnuPsSaleCommSet.Name : mFrm = New frmPsSaleComm
    '        Case mnuPsSaleCommSummary.Name

    '            : mFrm = New frmPsSaleCommSummary

    '            ' Case mnuPsSaleLineSummary.Name : mFrm = New frmPsSaleLineSummary
    '            '  Case mnuCusTfBank.Name : mFrm = New frmCusTfBank
    '        Case mnuPssEvent.Name : mFrm = New frmPssEvent
    '            'Case mnuPssTripPlanTs.Name : mFrm = New frmPssTripPlan(frmPssTripPlan.eProcess.eAdddata)
    '            'Case mnuPssTripPlanData.Name : mFrm = New frmPssTripPlanData(frmPssTripPlanData.eProcess.eShowdata)
    '            'Case mnuPssCusNotMeet.Name : mFrm = New frmPssTripPlanCusNotMeet
    '            '  Case mnuCusTP.Name : mFrm = New frmMkCusPM
    '            'Case mnuCusCompSet.Name : mFrm = New frmCusCompSet
    '    End Select
    '    pFrmShow()
    'End Sub


    'Private Sub mnuPicServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSysPicServ.Click
    '    'lbrMsg.MsgWarning("กำลังทำการปรับปรุงระบบ") : Exit Sub
    '    mFrm = New frmSysPicServ(frmSysPicServ.ePc.eManage)
    '    pFrmShow()
    'End Sub


    Private Sub mnuSysDebtStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSysDebtStart.Click
        Select Case sender.name
            Case mnuSysDebtStart.Name : mFrm = New frmSetDebtCus
        End Select
        pFrmShow()
    End Sub

#Region "mnuMk_Click"
    'Private Sub mnuMk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Select Case sender.name
    '        Case mnuMkSaleYear.Name : mFrm = New frmSlSaleSummary
    '        Case mnuMkGiftCusData.Name : mFrm = New frmMkGiftCauseData
    '        Case mnuMkGiftTs.Name : mFrm = New frmMkGiftCusSelect
    '        Case mnuMkGiftData.Name : mFrm = New frmMkGiftCusData(frmMkGiftCusData.eProcess.eGiftCusData)
    '        Case mnuMkGiftCancel.Name : mFrm = New frmMkGiftCusData(frmMkGiftCusData.eProcess.eGiftCancel)
    '        Case mnuMkGiftRpt.Name : mFrm = New frmMkGiftCusRpt
    '        Case mnuMkCusAddressSentDoc.Name : mFrm = New frmMkCusAddressSendDoc
    '        Case mnuMkSupRecTs.Name : mFrm = New frmMkSupGiftRecTs(frmMkSupGiftRecTs.eProcess.eAddTs)
    '        Case mnuMkSupRecData.Name : mFrm = New frmMkSupGiftRecData
    '        Case mnuMkCusMeet.Name : mFrm = New frmMkMeetCus(frmMkMeetCus.eProcess.eChange)
    '        Case mnuMkCusMeetTs.Name : mFrm = New frmMkMeetCusData(frmMkMeetCusData.eProcess.eAddOrEdit)
    '        Case mnuMkCusMeetData.Name : mFrm = New frmMkMeetCusData(frmMkMeetCusData.eProcess.eShowData)
    '        Case mnuMkCusMeetCancel.Name : mFrm = New frmMkMeetCusData(frmMkMeetCusData.eProcess.eCancle)
    '        Case mnuMkCusMeetRpt.Name : mFrm = New frmMkMeetCusRpt
    '        Case mnuMkTarget.Name : mFrm = New frmMkTargetYear
    '        Case mnuMkSaleYearAmount.Name : mFrm = New frmSlSaleAmountSummary
    '        Case mnuMkSaleYearLine.Name : mFrm = New frmSlSaleSummaryLine
    '        Case mnuMkSaleYearAmountLine.Name : mFrm = New frmSlSaleAmountSummaryLine
    '            'Case mnuMkSaleFinenceReturn.Name : mFrm = frmMkSaleRecReturn
    '        Case mnuMkRegionProvince.Name : mFrm = New frmPsZoneSummary
    '        Case mnuMkSaleStock.Name : mFrm = New frmMkSaleStockSummary
    '        Case frmPssPsRatio.Name : mFrm = New frmPssSaleSummary
    '        Case mnuMkSaleCusPvSerch.Name : mFrm = New frmMkSaleCusSearch
    '        Case mnuPssSaleByCus.Name : mFrm = New frmPsSaleSummaryPerson
    '    End Select
    '    pFrmShow()
    'End Sub
#End Region

   
    Private Sub mnuTspType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTspType.Click, mnuTspData.Click
        Select Case sender.name
            Case mnuTspType.Name : mFrm = New frmTspType
            Case mnuTspData.Name : mFrm = New frmSlTransportData
        End Select
        pFrmShow()
    End Sub

    '--- Finance ---'
    Private Sub mnuFn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFnDebtList.Click,
        mnuFnBillingTs.Click, mnuFnBillingData.Click, mnuFnBillingCancel.Click, mnuDebtADD.Click, mnuDebtBal.Click, mnuDebtBalAllCus.Click
        Select Case sender.name
            'Case mnuFnDebtList.Name : mFrm = New frmCusDebtList(frmCusDebtList.eProcess.eViewBn)
            Case mnuDebtADD.Name : mFrm = New frmDebtorData
            Case mnuFnDebtList.Name : mFrm = New frmSlSaleCusDebt

                'การวางบิล
            Case mnuFnBillingTs.Name : mFrm = New frmSlBnData(frmSlBnData.eProcess.eNew, 0, "", New DataTable)
            Case mnuFnBillingData.Name : mFrm = New frmSlBnData(frmSlBnData.eProcess.eView, 0, "", New DataTable)
            Case mnuFnBillingCancel.Name : mFrm = New frmSlBnData(frmSlBnData.eProcess.eCancel, 0, "", New DataTable)
            Case mnuDebtBal.Name : mFrm = New frmDebtBalData()
            Case mnuDebtBalAllCus.Name : mFrm = New frmDebtBalDataAllCus() 'ข้อมูลยอดรวมลูกหนี้คงเหลือทั้งหมด


        End Select
        pFrmShow()
    End Sub

#Region "mnuMkPromotion_Click"
    'Private Sub mnuMkPromotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Select Case sender.name
    '        Case mnuMkProSet.Name : mFrm = New frmMkPromotionData(frmMkPromotionData.eProcess.eNewAndEdit)
    '        Case mnuMkProData.Name : mFrm = New frmMkPromotionData(frmMkPromotionData.eProcess.eView)
    '        Case mnuMkProApprove.Name : mFrm = New frmMkPromotionGet
    '        Case mnuMkProCancel.Name : mFrm = New frmMkPromotionData(frmMkPromotionData.eProcess.eCancel)
    '        Case mnuMkProSummary.Name : mFrm = New frmMkPromotionUse
    '    End Select
    '    pFrmShow()
    'End Sub
#End Region


    Private Sub mnuTmpAccSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTmpAccSale.Click, mnuTmpAccSaleCompare.Click
        Select Case sender.name
            Case mnuTmpAccSale.Name : mFrm = New frmAccountSaleMY(frmAccountSaleMY.eProcess.eAdd)
            Case mnuTmpAccSaleCompare.Name : mFrm = New frmAccountSaleMY(frmAccountSaleMY.eProcess.eCompare)
        End Select
        pFrmShow()
    End Sub

    '**************************** Order ****************************************'
    Private Sub mnuOrderTs_Click(sender As Object, e As EventArgs) Handles mnuOrderTs.Click, mnuOrderData.Click, mnuOrderCancel.Click, mnuOrderBal.Click, mnuOrderCloseTs.Click

        Select Case sender.name
            Case mnuOrderTs.Name : mFrm = New frmSlOrderData(frmSlOrderData.eProcess.eNew)
            Case mnuOrderData.Name : mFrm = New frmSlOrderData(frmSlOrderData.eProcess.eView)
            Case mnuOrderCancel.Name : mFrm = New frmSlOrderData(frmSlOrderData.eProcess.eCancel)
            Case mnuOrderBal.Name : mFrm = New frmSlOrderBalance(frmSlOrderBalance.eProcess.eOrderBal)
            Case mnuOrderCloseTs.Name : mFrm = New frmSlOrderData(frmSlOrderData.eProcess.eCloseOrder)
                'Case mnuOrderAct.Name : mFrm = New frmSlOrderData(frmSlOrderData.eProcess.eAccept)
                'Case mnuOrderChk.Name : mFrm = New frmSlOrderData(frmSlOrderData.eProcess.eCheck)
                'Case mnuOrderApv.Name : mFrm = New frmSlOrderData(frmSlOrderData.eProcess.eApprove)
                '  Case mnuSlOrderStockCheck.Name : mFrm = New frmSlOrderCheckingStock
        End Select
        pFrmShow()
    End Sub


    '**************************** Return ****************************************'
    Private Sub SlReturnTsMenuItem_Click(sender As Object, e As EventArgs) Handles SlReturn153TsMenuItem.Click, SlReturnDataMenuItem.Click,
        SlReturnCancelMenuItem.Click, SlReturnRptMenuItem.Click, SetRtCodeMenuItem.Click, SetCauseRTMenuItem.Click,
        ActJUMenuItem.Click, ChkJUMenuItem.Click, ApvJUMenuItem.Click, ManageRejectMenuItem.Click, SlReturnJUTsMenuItem.Click, JUNewPdMenuItem.Click,
        SlReturn151TsMenuItem.Click, mnuNewApvReturn.Click, mnuDataReturn.Click, mnuEditBillReturn.Click

        Dim tempDt As New DataTable
        Select Case sender.name
            Case SlReturn153TsMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eNew153, Nothing, tempDt)
            Case SlReturn151TsMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eNew151, Nothing, tempDt)
            Case SlReturnJUTsMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eNewJU, Nothing, tempDt)
            Case JUNewPdMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eSelectNewPd, Nothing, tempDt)

            Case ActJUMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eAccept, Nothing, tempDt)
            Case ChkJUMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eCheck, Nothing, tempDt)
            Case ApvJUMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eApprove, Nothing, tempDt)

            Case ManageRejectMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eManageReject, Nothing, tempDt)

            Case SlReturnDataMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eViewData, Nothing, tempDt)
           ' Case SlReturnCancelMenuItem.Name : mFrm = New frmSlReturnData(frmSlReturnData.eProcess.eCancel, Nothing, tempDt)
            Case SetRtCodeMenuItem.Name : mFrm = New frmSlReturnDocCode
            Case SetCauseRTMenuItem.Name : mFrm = New frmSlReturnCauseSet
            Case SlReturnRptMenuItem.Name : mFrm = New frmSlReturnRpt

            'New Menu Return
            Case mnuNewApvReturn.Name : mFrm = New frmCrateSaleRTData(frmCrateSaleRTData.eProcess.eBillTs)
            Case mnuEditBillReturn.Name : mFrm = New FrmBillSaleReturnData(FrmBillSaleReturnData.eProcess.eEdit)
            Case mnuDataReturn.Name : mFrm = New FrmBillSaleReturnData(FrmBillSaleReturnData.eProcess.eView)

            Case SlReturnCancelMenuItem.Name : mFrm = New FrmBillSaleReturnData(FrmBillSaleReturnData.eProcess.eCancel)

                'New AddxEditReturn
                'Case mnuAddxEditReturn.Name : mFrm = New frmWaitReturnData(frmWaitReturnData.eProcess.eNewxEditReturn)


                'Case ChkJUMenuItem.Name : mFrm = New frmApvSaleReturn(frmApvSaleReturn.eProcess.eRTCheck)
                'Case ApvJUMenuItem.Name : mFrm = New frmApvSaleReturn(frmApvSaleReturn.eProcess.eRTApprove)
        End Select
        pFrmShow()
    End Sub

    '********************** Quotation : เสนอราคา **********************************'
    Private Sub mnuQTMain_Click(sender As Object, e As EventArgs) Handles mnuQTTs.Click, mnuQTData.Click, mnuQTCancel.Click
        Select Case sender.name
            '--- การเสนอราคา ---'
            Case mnuQTTs.Name : mFrm = New frmQtData(frmQtData.eProcess.eNew, 0, "", 0, 0)
            Case mnuQTData.Name : mFrm = New frmQtData(frmQtData.eProcess.eViewData, 0, "", 0, 0)
            Case mnuQTCancel.Name : mFrm = New frmQtData(frmQtData.eProcess.eCancel, 0, "", 0, 0)
        End Select
        pFrmShow()
    End Sub

    '********************** เจ้าหน้าที่ขาย **********************************'
    Private Sub mnuPsSaleMain_Click(sender As Object, e As EventArgs) Handles PssSaleSummaryMenuItem.Click, mnuSlSumMonthPlant.Click
        Select Case sender.name
            Case PssSaleSummaryMenuItem.Name : mFrm = New frmPssSaleSummary 'สรุปสัดส่วนยอดขาย
            Case mnuSlSumMonthPlant.Name : mFrm = New frmSaleSummaryMonth 'ยอดขาย และจำนวนขายสินค้าเมล็ดพันธุ์

        End Select
        pFrmShow()
    End Sub

    '********************** Credit Note **********************************'
    Private Sub mnuCreditDebitNote_Click(sender As Object, e As EventArgs) Handles mnuCreditNoteTs.Click, mnuCreditNoteData.Click,
        mnuCreditNoteCancel.Click, mnuDebitNoteTs.Click, mnuDebitNoteData.Click, mnuDebitNoteCancel.Click
        Select Case sender.name
            'Credit
            Case mnuCreditNoteTs.Name : mFrm = New frmCreditDebitNoteData(frmCreditDebitNoteData.eProcess.eAddxEditCreditNote) 'ทำรายการ/แก้ไข credit
            Case mnuCreditNoteData.Name : mFrm = New frmCreditDebitNoteData(frmCreditDebitNoteData.eProcess.eViewCreditNote) 'view credit
            Case mnuCreditNoteCancel.Name : mFrm = New frmCreditDebitNoteData(frmCreditDebitNoteData.eProcess.eCancelCreditNote) 'cancel credit

                'Debit
            Case mnuDebitNoteTs.Name : mFrm = New frmCreditDebitNoteData(frmCreditDebitNoteData.eProcess.eAddxEditDebitNote) 'ทำรายการ/แก้ไข Debit
            Case mnuDebitNoteData.Name : mFrm = New frmCreditDebitNoteData(frmCreditDebitNoteData.eProcess.eViewDebitNote) 'view Debit
            Case mnuDebitNoteCancel.Name : mFrm = New frmCreditDebitNoteData(frmCreditDebitNoteData.eProcess.eCancelDebitNote) 'cancel Debit

        End Select
        pFrmShow()
    End Sub


    Private Sub GraphDailyMenuItem_Click(sender As Object, e As EventArgs) Handles GraphDailyMenuItem.Click
        mFrm = New frmSaleDateChart
        pFrmShow()
    End Sub

    Private Sub mnuManageDoc_Click(sender As Object, e As EventArgs) Handles mnuManageDoc.Click
        mFrm = New frmMnDocTypeCode
        pFrmShow()
    End Sub

    Private Sub ChangeCompMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeCompMenuItem.Click
        ' --- Select Company ---'
        'frmSaleDateChart.Close()

        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        mFrm = New frmSysCompSelect
        pFrmShow()
    End Sub


End Class

