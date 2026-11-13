<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSlSaleData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlSaleData))
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GVSaleDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidWh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPONo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPdCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptInvName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWareHouseName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptWH = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDiscountBath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColExp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocCode_PO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GVSaleMt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColStatusDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintMul = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptChkPrint = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColEdit1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colAddTransport = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptAddTransport = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColSendLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptLineNoti = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColAddPic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptAddPic = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDoc = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColPsCancel1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCancelNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSale1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColChk1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColAct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColCheck1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColApprove1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColCancelApv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCancel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colCompCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDatePay1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCusName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColAp1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPv1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidCancel1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDisCntAmt1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDisPer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalNet1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRefAcc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsTs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateTs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTimeTs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsAccept1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateAccept1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsCheck1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateCheck1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsApp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateApp1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsApp2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateApp2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColstBillOrder1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColstBillType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidCus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidPsSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSend = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCompName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSlAVxST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaleCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidPartner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbSlAVxST = New System.Windows.Forms.CheckBox()
        Me.ChkCancel = New System.Windows.Forms.CheckBox()
        Me.txtPsSale = New System.Windows.Forms.TextBox()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.chkComp = New System.Windows.Forms.CheckBox()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.ChkCus = New System.Windows.Forms.CheckBox()
        Me.ChkPsSale = New System.Windows.Forms.CheckBox()
        Me.ChkDoc = New System.Windows.Forms.CheckBox()
        Me.CCbEditDoc = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbDraft = New System.Windows.Forms.CheckBox()
        Me.cmbTsp = New System.Windows.Forms.ComboBox()
        Me.ChkDocCode = New System.Windows.Forms.CheckBox()
        Me.ChkTsp = New System.Windows.Forms.CheckBox()
        Me.ChkStOrd = New System.Windows.Forms.CheckBox()
        Me.txtDocRef = New System.Windows.Forms.TextBox()
        Me.ChkDocRef = New System.Windows.Forms.CheckBox()
        Me.txtDocCode = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpMonthNow = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthE = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthS = New System.Windows.Forms.DateTimePicker()
        Me.rdbBack7 = New System.Windows.Forms.RadioButton()
        Me.rdbMonthNow = New System.Windows.Forms.RadioButton()
        Me.dtpSaleE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpSaleS = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDateTs = New System.Windows.Forms.RadioButton()
        Me.rdbDateSale = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCountDt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.RepositoryItemButtonEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnPrint = New System.Windows.Forms.Panel()
        Me.btnPrintMulti = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSFindAll = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GVSaleDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptInvName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptWH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptChkPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptAddTransport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptLineNoti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptAddPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCusName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.CCbEditDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.RepositoryItemButtonEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnPrint.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVSaleDt
        '
        Me.GVSaleDt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.Empty.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSaleDt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleDt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSaleDt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSaleDt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleDt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleDt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleDt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSaleDt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleDt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleDt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSaleDt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSaleDt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSaleDt.Appearance.Preview.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.Preview.Options.UseFont = True
        Me.GVSaleDt.Appearance.Preview.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.Row.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.Row.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleDt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSaleDt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleDt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleDt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSaleDt.ColumnPanelRowHeight = 35
        Me.GVSaleDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidSaleDt, Me.colidProduct, Me.colidLot, Me.colidWh, Me.ColNo, Me.ColOrderNo, Me.ColPONo, Me.ColPdCode, Me.ColLotNo, Me.ColProductName, Me.ColAmount, Me.ColUnit, Me.ColWareHouseName, Me.ColDiscount, Me.ColDiscountBath, Me.ColPrice, Me.ColExp, Me.colDocCode_PO})
        Me.GVSaleDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GVSaleDt.GridControl = Me.GridControl1
        Me.GVSaleDt.Name = "GVSaleDt"
        Me.GVSaleDt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleDt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleDt.OptionsView.RowAutoHeight = True
        Me.GVSaleDt.OptionsView.ShowGroupPanel = False
        Me.GVSaleDt.OptionsView.ShowIndicator = False
        Me.GVSaleDt.PaintStyleName = "Flat"
        Me.GVSaleDt.RowHeight = 25
        '
        'colidSaleDt
        '
        Me.colidSaleDt.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colidSaleDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidSaleDt.AppearanceCell.Options.UseBackColor = True
        Me.colidSaleDt.AppearanceCell.Options.UseFont = True
        Me.colidSaleDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidSaleDt.AppearanceHeader.Options.UseFont = True
        Me.colidSaleDt.Caption = "idSaleDt"
        Me.colidSaleDt.FieldName = "idSaleDt"
        Me.colidSaleDt.Name = "colidSaleDt"
        '
        'colidProduct
        '
        Me.colidProduct.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colidProduct.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidProduct.AppearanceCell.Options.UseBackColor = True
        Me.colidProduct.AppearanceCell.Options.UseFont = True
        Me.colidProduct.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidProduct.AppearanceHeader.Options.UseFont = True
        Me.colidProduct.Caption = "idProduct"
        Me.colidProduct.FieldName = "idProduct"
        Me.colidProduct.Name = "colidProduct"
        '
        'colidLot
        '
        Me.colidLot.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colidLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidLot.AppearanceCell.Options.UseBackColor = True
        Me.colidLot.AppearanceCell.Options.UseFont = True
        Me.colidLot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidLot.AppearanceHeader.Options.UseFont = True
        Me.colidLot.Caption = "idLot"
        Me.colidLot.FieldName = "idLot"
        Me.colidLot.Name = "colidLot"
        '
        'colidWh
        '
        Me.colidWh.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colidWh.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidWh.AppearanceCell.Options.UseBackColor = True
        Me.colidWh.AppearanceCell.Options.UseFont = True
        Me.colidWh.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidWh.AppearanceHeader.Options.UseFont = True
        Me.colidWh.Caption = "idWh"
        Me.colidWh.FieldName = "idWh"
        Me.colidWh.Name = "colidWh"
        '
        'ColNo
        '
        Me.ColNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNo.AppearanceCell.Options.UseFont = True
        Me.ColNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNo.AppearanceHeader.Options.UseFont = True
        Me.ColNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNo.Caption = "#"
        Me.ColNo.FieldName = "No"
        Me.ColNo.MaxWidth = 45
        Me.ColNo.MinWidth = 45
        Me.ColNo.Name = "ColNo"
        Me.ColNo.Visible = True
        Me.ColNo.VisibleIndex = 0
        Me.ColNo.Width = 45
        '
        'ColOrderNo
        '
        Me.ColOrderNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColOrderNo.AppearanceCell.Options.UseFont = True
        Me.ColOrderNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColOrderNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColOrderNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColOrderNo.AppearanceHeader.Options.UseFont = True
        Me.ColOrderNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColOrderNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColOrderNo.Caption = "เลขที่ออเดอร์ (Order No.)"
        Me.ColOrderNo.FieldName = "OrderNo"
        Me.ColOrderNo.Name = "ColOrderNo"
        Me.ColOrderNo.OptionsColumn.AllowEdit = False
        Me.ColOrderNo.OptionsColumn.ReadOnly = True
        Me.ColOrderNo.Visible = True
        Me.ColOrderNo.VisibleIndex = 11
        Me.ColOrderNo.Width = 134
        '
        'ColPONo
        '
        Me.ColPONo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPONo.AppearanceCell.Options.UseFont = True
        Me.ColPONo.AppearanceCell.Options.UseTextOptions = True
        Me.ColPONo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPONo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPONo.AppearanceHeader.Options.UseFont = True
        Me.ColPONo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPONo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPONo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPONo.Caption = "เลขที่คำสั่งซื้อ (PO No.)"
        Me.ColPONo.FieldName = "PONo"
        Me.ColPONo.Name = "ColPONo"
        Me.ColPONo.OptionsColumn.AllowEdit = False
        Me.ColPONo.OptionsColumn.ReadOnly = True
        Me.ColPONo.Visible = True
        Me.ColPONo.VisibleIndex = 12
        Me.ColPONo.Width = 131
        '
        'ColPdCode
        '
        Me.ColPdCode.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPdCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPdCode.AppearanceCell.Options.UseBackColor = True
        Me.ColPdCode.AppearanceCell.Options.UseFont = True
        Me.ColPdCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPdCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPdCode.AppearanceHeader.Options.UseFont = True
        Me.ColPdCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdCode.Caption = "รหัสสินค้า"
        Me.ColPdCode.FieldName = "InvCode"
        Me.ColPdCode.Name = "ColPdCode"
        Me.ColPdCode.OptionsColumn.AllowEdit = False
        Me.ColPdCode.OptionsColumn.ReadOnly = True
        Me.ColPdCode.Visible = True
        Me.ColPdCode.VisibleIndex = 1
        Me.ColPdCode.Width = 135
        '
        'ColLotNo
        '
        Me.ColLotNo.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColLotNo.AppearanceCell.Options.UseBackColor = True
        Me.ColLotNo.AppearanceCell.Options.UseFont = True
        Me.ColLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColLotNo.AppearanceHeader.Options.UseFont = True
        Me.ColLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.Caption = "Lot No."
        Me.ColLotNo.FieldName = "LotNo"
        Me.ColLotNo.Name = "ColLotNo"
        Me.ColLotNo.OptionsColumn.AllowEdit = False
        Me.ColLotNo.OptionsColumn.ReadOnly = True
        Me.ColLotNo.Visible = True
        Me.ColLotNo.VisibleIndex = 2
        Me.ColLotNo.Width = 182
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColProductName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColProductName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการสินค้า"
        Me.ColProductName.ColumnEdit = Me.rptInvName
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 3
        Me.ColProductName.Width = 361
        '
        'rptInvName
        '
        Me.rptInvName.Name = "rptInvName"
        '
        'ColAmount
        '
        Me.ColAmount.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmount.AppearanceCell.Options.UseBackColor = True
        Me.ColAmount.AppearanceCell.Options.UseFont = True
        Me.ColAmount.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmount.AppearanceHeader.Options.UseFont = True
        Me.ColAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmount.Caption = "จำนวนขาย"
        Me.ColAmount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.OptionsColumn.AllowFocus = False
        Me.ColAmount.OptionsColumn.ReadOnly = True
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 4
        Me.ColAmount.Width = 109
        '
        'ColUnit
        '
        Me.ColUnit.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColUnit.AppearanceCell.Options.UseBackColor = True
        Me.ColUnit.AppearanceCell.Options.UseFont = True
        Me.ColUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnit.AppearanceHeader.Options.UseFont = True
        Me.ColUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.Caption = "หน่วย"
        Me.ColUnit.FieldName = "UnitName"
        Me.ColUnit.Name = "ColUnit"
        Me.ColUnit.OptionsColumn.AllowEdit = False
        Me.ColUnit.OptionsColumn.ReadOnly = True
        Me.ColUnit.Visible = True
        Me.ColUnit.VisibleIndex = 5
        Me.ColUnit.Width = 79
        '
        'ColWareHouseName
        '
        Me.ColWareHouseName.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColWareHouseName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColWareHouseName.AppearanceCell.Options.UseBackColor = True
        Me.ColWareHouseName.AppearanceCell.Options.UseFont = True
        Me.ColWareHouseName.AppearanceCell.Options.UseTextOptions = True
        Me.ColWareHouseName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColWareHouseName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColWareHouseName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColWareHouseName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColWareHouseName.AppearanceHeader.Options.UseFont = True
        Me.ColWareHouseName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColWareHouseName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWareHouseName.Caption = "คลังสินค้า"
        Me.ColWareHouseName.ColumnEdit = Me.rptWH
        Me.ColWareHouseName.FieldName = "full_lock"
        Me.ColWareHouseName.Name = "ColWareHouseName"
        Me.ColWareHouseName.OptionsColumn.AllowEdit = False
        Me.ColWareHouseName.OptionsColumn.ReadOnly = True
        Me.ColWareHouseName.Visible = True
        Me.ColWareHouseName.VisibleIndex = 10
        Me.ColWareHouseName.Width = 140
        '
        'rptWH
        '
        Me.rptWH.Name = "rptWH"
        '
        'ColDiscount
        '
        Me.ColDiscount.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDiscount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDiscount.AppearanceCell.Options.UseBackColor = True
        Me.ColDiscount.AppearanceCell.Options.UseFont = True
        Me.ColDiscount.AppearanceCell.Options.UseTextOptions = True
        Me.ColDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDiscount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDiscount.AppearanceHeader.Options.UseFont = True
        Me.ColDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDiscount.Caption = "ส่วนลด (%)"
        Me.ColDiscount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDiscount.FieldName = "Discount"
        Me.ColDiscount.Name = "ColDiscount"
        Me.ColDiscount.OptionsColumn.AllowEdit = False
        Me.ColDiscount.OptionsColumn.ReadOnly = True
        Me.ColDiscount.Visible = True
        Me.ColDiscount.VisibleIndex = 6
        Me.ColDiscount.Width = 87
        '
        'ColDiscountBath
        '
        Me.ColDiscountBath.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDiscountBath.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDiscountBath.AppearanceCell.Options.UseBackColor = True
        Me.ColDiscountBath.AppearanceCell.Options.UseFont = True
        Me.ColDiscountBath.AppearanceCell.Options.UseTextOptions = True
        Me.ColDiscountBath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDiscountBath.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDiscountBath.AppearanceHeader.Options.UseFont = True
        Me.ColDiscountBath.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDiscountBath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDiscountBath.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDiscountBath.Caption = "ส่วนลด (บาท)"
        Me.ColDiscountBath.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColDiscountBath.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDiscountBath.FieldName = "DiscountBath"
        Me.ColDiscountBath.Name = "ColDiscountBath"
        Me.ColDiscountBath.OptionsColumn.AllowEdit = False
        Me.ColDiscountBath.OptionsColumn.ReadOnly = True
        Me.ColDiscountBath.Visible = True
        Me.ColDiscountBath.VisibleIndex = 7
        Me.ColDiscountBath.Width = 86
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPrice.AppearanceCell.Options.UseBackColor = True
        Me.ColPrice.AppearanceCell.Options.UseFont = True
        Me.ColPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPrice.AppearanceHeader.Options.UseFont = True
        Me.ColPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.Caption = "ราคา"
        Me.ColPrice.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrice.FieldName = "Price"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.OptionsColumn.AllowEdit = False
        Me.ColPrice.OptionsColumn.ReadOnly = True
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 8
        Me.ColPrice.Width = 92
        '
        'ColExp
        '
        Me.ColExp.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColExp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColExp.AppearanceCell.Options.UseBackColor = True
        Me.ColExp.AppearanceCell.Options.UseFont = True
        Me.ColExp.AppearanceCell.Options.UseTextOptions = True
        Me.ColExp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColExp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColExp.AppearanceHeader.Options.UseFont = True
        Me.ColExp.AppearanceHeader.Options.UseTextOptions = True
        Me.ColExp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColExp.Caption = "รวมเป็นเงิน"
        Me.ColExp.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColExp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColExp.FieldName = "ExSump"
        Me.ColExp.Name = "ColExp"
        Me.ColExp.OptionsColumn.AllowEdit = False
        Me.ColExp.OptionsColumn.ReadOnly = True
        Me.ColExp.Visible = True
        Me.ColExp.VisibleIndex = 9
        Me.ColExp.Width = 110
        '
        'colDocCode_PO
        '
        Me.colDocCode_PO.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colDocCode_PO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDocCode_PO.AppearanceCell.Options.UseBackColor = True
        Me.colDocCode_PO.AppearanceCell.Options.UseFont = True
        Me.colDocCode_PO.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colDocCode_PO.AppearanceHeader.Options.UseFont = True
        Me.colDocCode_PO.Caption = "DocCode_PO"
        Me.colDocCode_PO.FieldName = "DocCode_PO"
        Me.colDocCode_PO.Name = "colDocCode_PO"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVSaleDt
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 236)
        Me.GridControl1.MainView = Me.GVSaleMt
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptLineNoti, Me.rptAddTransport, Me.rptChkPrint, Me.rptAddPic, Me.rptInvName, Me.rptWH, Me.rptCusName})
        Me.GridControl1.Size = New System.Drawing.Size(1184, 351)
        Me.GridControl1.TabIndex = 600
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSaleMt, Me.GVSaleDt})
        '
        'GVSaleMt
        '
        Me.GVSaleMt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.Empty.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleMt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleMt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleMt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSaleMt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSaleMt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleMt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleMt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleMt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleMt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSaleMt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleMt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleMt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSaleMt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSaleMt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSaleMt.Appearance.Preview.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.Preview.Options.UseFont = True
        Me.GVSaleMt.Appearance.Preview.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.Row.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.Row.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.Row.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleMt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSaleMt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleMt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleMt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSaleMt.ColumnPanelRowHeight = 35
        Me.GVSaleMt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColStatusDt, Me.ColNum, Me.colPrintMul, Me.ColEdit1, Me.colAddTransport, Me.ColSendLine, Me.ColAddPic, Me.ColDoc, Me.ColPsCancel1, Me.ColCancelNote, Me.ColidSale1, Me.ColChk1, Me.ColAct, Me.ColCheck1, Me.ColApprove1, Me.ColCancelApv, Me.ColCancel, Me.colCompCode, Me.ColDocRef1, Me.ColDateSale1, Me.ColDatePay1, Me.ColCusName1, Me.ColAp1, Me.ColPv1, Me.ColidCancel1, Me.ColTotal, Me.ColDisCntAmt1, Me.ColDisPer1, Me.ColTotalNet1, Me.ColPsSale, Me.ColDocCode, Me.ColDocRefAcc1, Me.ColPsTs1, Me.ColDateTs1, Me.ColTimeTs1, Me.ColPsAccept1, Me.ColDateAccept1, Me.ColPsCheck1, Me.ColDateCheck1, Me.ColPsApp, Me.ColDateApp1, Me.ColPsApp2, Me.colDateApp2, Me.ColNote1, Me.ColstBillOrder1, Me.ColstBillType1, Me.ColidCus, Me.colidComp, Me.colidTs, Me.colidPsSale, Me.colidSend, Me.ColCompName, Me.colidSlAVxST, Me.colSaleCode, Me.ColidPartner})
        Me.GVSaleMt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        GridFormatRule1.Column = Me.ColStatusDt
        GridFormatRule1.ColumnApplyTo = Me.ColStatusDt
        GridFormatRule1.Name = "stWaitCut"
        FormatConditionRuleExpression1.Expression = "[stWaitCut] = 'Draft'"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GVSaleMt.FormatRules.Add(GridFormatRule1)
        Me.GVSaleMt.GridControl = Me.GridControl1
        Me.GVSaleMt.Name = "GVSaleMt"
        Me.GVSaleMt.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVSaleMt.OptionsView.ColumnAutoWidth = False
        Me.GVSaleMt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleMt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleMt.OptionsView.RowAutoHeight = True
        Me.GVSaleMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSaleMt.OptionsView.ShowGroupPanel = False
        Me.GVSaleMt.OptionsView.ShowIndicator = False
        Me.GVSaleMt.PaintStyleName = "MixedXP"
        Me.GVSaleMt.RowHeight = 25
        '
        'ColStatusDt
        '
        Me.ColStatusDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColStatusDt.AppearanceCell.Options.UseFont = True
        Me.ColStatusDt.AppearanceCell.Options.UseTextOptions = True
        Me.ColStatusDt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColStatusDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColStatusDt.AppearanceHeader.Options.UseFont = True
        Me.ColStatusDt.AppearanceHeader.Options.UseTextOptions = True
        Me.ColStatusDt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColStatusDt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColStatusDt.Caption = "สถานะรายการ"
        Me.ColStatusDt.FieldName = "stWaitCut"
        Me.ColStatusDt.MaxWidth = 55
        Me.ColStatusDt.MinWidth = 55
        Me.ColStatusDt.Name = "ColStatusDt"
        Me.ColStatusDt.OptionsColumn.AllowEdit = False
        Me.ColStatusDt.OptionsColumn.ReadOnly = True
        Me.ColStatusDt.Visible = True
        Me.ColStatusDt.VisibleIndex = 23
        Me.ColStatusDt.Width = 55
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 61
        '
        'colPrintMul
        '
        Me.colPrintMul.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPrintMul.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colPrintMul.AppearanceCell.Options.UseBackColor = True
        Me.colPrintMul.AppearanceCell.Options.UseFont = True
        Me.colPrintMul.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colPrintMul.AppearanceHeader.Options.UseFont = True
        Me.colPrintMul.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrintMul.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrintMul.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrintMul.Caption = "Print"
        Me.colPrintMul.ColumnEdit = Me.rptChkPrint
        Me.colPrintMul.FieldName = "chk"
        Me.colPrintMul.MaxWidth = 55
        Me.colPrintMul.MinWidth = 55
        Me.colPrintMul.Name = "colPrintMul"
        Me.colPrintMul.Width = 55
        '
        'rptChkPrint
        '
        Me.rptChkPrint.AutoHeight = False
        Me.rptChkPrint.Name = "rptChkPrint"
        '
        'ColEdit1
        '
        Me.ColEdit1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColEdit1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColEdit1.AppearanceCell.Options.UseBackColor = True
        Me.ColEdit1.AppearanceCell.Options.UseFont = True
        Me.ColEdit1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColEdit1.AppearanceHeader.Options.UseFont = True
        Me.ColEdit1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEdit1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEdit1.Caption = "แก้ไข"
        Me.ColEdit1.ColumnEdit = Me.rptEdit
        Me.ColEdit1.MaxWidth = 45
        Me.ColEdit1.MinWidth = 45
        Me.ColEdit1.Name = "ColEdit1"
        Me.ColEdit1.Visible = True
        Me.ColEdit1.VisibleIndex = 1
        Me.ColEdit1.Width = 45
        '
        'rptEdit
        '
        Me.rptEdit.AutoHeight = False
        Me.rptEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.Computer_Edit, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptEdit.Name = "rptEdit"
        Me.rptEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colAddTransport
        '
        Me.colAddTransport.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colAddTransport.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colAddTransport.AppearanceCell.Options.UseBackColor = True
        Me.colAddTransport.AppearanceCell.Options.UseFont = True
        Me.colAddTransport.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colAddTransport.AppearanceHeader.Options.UseFont = True
        Me.colAddTransport.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddTransport.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddTransport.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAddTransport.Caption = "เพิ่มค่าขนส่ง"
        Me.colAddTransport.ColumnEdit = Me.rptAddTransport
        Me.colAddTransport.MaxWidth = 50
        Me.colAddTransport.MinWidth = 50
        Me.colAddTransport.Name = "colAddTransport"
        Me.colAddTransport.Width = 50
        '
        'rptAddTransport
        '
        Me.rptAddTransport.AutoHeight = False
        Me.rptAddTransport.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptAddTransport.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptAddTransport.Name = "rptAddTransport"
        Me.rptAddTransport.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColSendLine
        '
        Me.ColSendLine.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColSendLine.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColSendLine.AppearanceCell.Options.UseBackColor = True
        Me.ColSendLine.AppearanceCell.Options.UseFont = True
        Me.ColSendLine.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColSendLine.AppearanceHeader.Options.UseFont = True
        Me.ColSendLine.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSendLine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSendLine.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColSendLine.Caption = "แจ้งเตือน Telegram"
        Me.ColSendLine.ColumnEdit = Me.rptLineNoti
        Me.ColSendLine.MaxWidth = 65
        Me.ColSendLine.MinWidth = 65
        Me.ColSendLine.Name = "ColSendLine"
        Me.ColSendLine.Width = 55
        '
        'rptLineNoti
        '
        Me.rptLineNoti.AutoHeight = False
        Me.rptLineNoti.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.logo_telegram, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptLineNoti.Name = "rptLineNoti"
        Me.rptLineNoti.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColAddPic
        '
        Me.ColAddPic.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColAddPic.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAddPic.AppearanceCell.Options.UseBackColor = True
        Me.ColAddPic.AppearanceCell.Options.UseFont = True
        Me.ColAddPic.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAddPic.AppearanceHeader.Options.UseFont = True
        Me.ColAddPic.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAddPic.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAddPic.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAddPic.Caption = "แนบรูป"
        Me.ColAddPic.ColumnEdit = Me.rptAddPic
        Me.ColAddPic.MaxWidth = 35
        Me.ColAddPic.MinWidth = 35
        Me.ColAddPic.Name = "ColAddPic"
        Me.ColAddPic.Width = 35
        '
        'rptAddPic
        '
        Me.rptAddPic.AutoHeight = False
        Me.rptAddPic.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptAddPic.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.rptAddPic.Name = "rptAddPic"
        Me.rptAddPic.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDoc
        '
        Me.ColDoc.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDoc.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDoc.AppearanceCell.Options.UseBackColor = True
        Me.ColDoc.AppearanceCell.Options.UseFont = True
        Me.ColDoc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDoc.AppearanceHeader.Options.UseFont = True
        Me.ColDoc.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDoc.Caption = "เอกสาร"
        Me.ColDoc.ColumnEdit = Me.rptDoc
        Me.ColDoc.MaxWidth = 50
        Me.ColDoc.MinWidth = 50
        Me.ColDoc.Name = "ColDoc"
        Me.ColDoc.Visible = True
        Me.ColDoc.VisibleIndex = 3
        Me.ColDoc.Width = 50
        '
        'rptDoc
        '
        Me.rptDoc.AutoHeight = False
        Me.rptDoc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.icon_billingsss_png_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.rptDoc.Name = "rptDoc"
        Me.rptDoc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColPsCancel1
        '
        Me.ColPsCancel1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPsCancel1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsCancel1.AppearanceCell.Options.UseBackColor = True
        Me.ColPsCancel1.AppearanceCell.Options.UseFont = True
        Me.ColPsCancel1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsCancel1.AppearanceHeader.Options.UseFont = True
        Me.ColPsCancel1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsCancel1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsCancel1.Caption = "PsCancel"
        Me.ColPsCancel1.FieldName = "PsCancel"
        Me.ColPsCancel1.Name = "ColPsCancel1"
        '
        'ColCancelNote
        '
        Me.ColCancelNote.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColCancelNote.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCancelNote.AppearanceCell.Options.UseBackColor = True
        Me.ColCancelNote.AppearanceCell.Options.UseFont = True
        Me.ColCancelNote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCancelNote.AppearanceHeader.Options.UseFont = True
        Me.ColCancelNote.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCancelNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCancelNote.Caption = "CancelNote"
        Me.ColCancelNote.FieldName = "CancelNote"
        Me.ColCancelNote.Name = "ColCancelNote"
        '
        'ColidSale1
        '
        Me.ColidSale1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColidSale1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSale1.AppearanceCell.Options.UseBackColor = True
        Me.ColidSale1.AppearanceCell.Options.UseFont = True
        Me.ColidSale1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSale1.AppearanceHeader.Options.UseFont = True
        Me.ColidSale1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidSale1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidSale1.Caption = "idSale"
        Me.ColidSale1.FieldName = "idSale"
        Me.ColidSale1.Name = "ColidSale1"
        '
        'ColChk1
        '
        Me.ColChk1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColChk1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColChk1.AppearanceCell.Options.UseBackColor = True
        Me.ColChk1.AppearanceCell.Options.UseFont = True
        Me.ColChk1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColChk1.AppearanceHeader.Options.UseFont = True
        Me.ColChk1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColChk1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColChk1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColChk1.Caption = "ตรวจสอบหลายรายการ"
        Me.ColChk1.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.ColChk1.FieldName = "ChkKey"
        Me.ColChk1.MaxWidth = 75
        Me.ColChk1.MinWidth = 75
        Me.ColChk1.Name = "ColChk1"
        Me.ColChk1.Visible = True
        Me.ColChk1.VisibleIndex = 4
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'ColAct
        '
        Me.ColAct.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColAct.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAct.AppearanceCell.Options.UseBackColor = True
        Me.ColAct.AppearanceCell.Options.UseFont = True
        Me.ColAct.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAct.AppearanceHeader.Options.UseFont = True
        Me.ColAct.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAct.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAct.Caption = "รับทราบ"
        Me.ColAct.ColumnEdit = Me.RepositoryItemButtonEdit3
        Me.ColAct.MaxWidth = 45
        Me.ColAct.MinWidth = 45
        Me.ColAct.Name = "ColAct"
        Me.ColAct.Visible = True
        Me.ColAct.VisibleIndex = 5
        Me.ColAct.Width = 45
        '
        'RepositoryItemButtonEdit3
        '
        Me.RepositoryItemButtonEdit3.AutoHeight = False
        Me.RepositoryItemButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.check_icon555, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEdit3.Name = "RepositoryItemButtonEdit3"
        Me.RepositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColCheck1
        '
        Me.ColCheck1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColCheck1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCheck1.AppearanceCell.Options.UseBackColor = True
        Me.ColCheck1.AppearanceCell.Options.UseFont = True
        Me.ColCheck1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCheck1.AppearanceHeader.Options.UseFont = True
        Me.ColCheck1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCheck1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCheck1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColCheck1.Caption = "ตรวจสอบ"
        Me.ColCheck1.ColumnEdit = Me.RepositoryItemButtonEdit4
        Me.ColCheck1.MaxWidth = 55
        Me.ColCheck1.MinWidth = 55
        Me.ColCheck1.Name = "ColCheck1"
        Me.ColCheck1.Visible = True
        Me.ColCheck1.VisibleIndex = 6
        Me.ColCheck1.Width = 55
        '
        'RepositoryItemButtonEdit4
        '
        Me.RepositoryItemButtonEdit4.AutoHeight = False
        Me.RepositoryItemButtonEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.clear_tick_icon, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject7, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEdit4.Name = "RepositoryItemButtonEdit4"
        Me.RepositoryItemButtonEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColApprove1
        '
        Me.ColApprove1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColApprove1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColApprove1.AppearanceCell.Options.UseBackColor = True
        Me.ColApprove1.AppearanceCell.Options.UseFont = True
        Me.ColApprove1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColApprove1.AppearanceHeader.Options.UseFont = True
        Me.ColApprove1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColApprove1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColApprove1.Caption = "อนุมัติ"
        Me.ColApprove1.ColumnEdit = Me.RepositoryItemButtonEdit5
        Me.ColApprove1.MaxWidth = 45
        Me.ColApprove1.MinWidth = 45
        Me.ColApprove1.Name = "ColApprove1"
        Me.ColApprove1.Visible = True
        Me.ColApprove1.VisibleIndex = 7
        Me.ColApprove1.Width = 45
        '
        'RepositoryItemButtonEdit5
        '
        Me.RepositoryItemButtonEdit5.AutoHeight = False
        Me.RepositoryItemButtonEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.check_iconGreen, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject8, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEdit5.Name = "RepositoryItemButtonEdit5"
        Me.RepositoryItemButtonEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColCancelApv
        '
        Me.ColCancelApv.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColCancelApv.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCancelApv.AppearanceCell.Options.UseBackColor = True
        Me.ColCancelApv.AppearanceCell.Options.UseFont = True
        Me.ColCancelApv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCancelApv.AppearanceHeader.Options.UseFont = True
        Me.ColCancelApv.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCancelApv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCancelApv.Caption = "ยกเลิก"
        Me.ColCancelApv.ColumnEdit = Me.RepositoryItemButtonEdit7
        Me.ColCancelApv.MaxWidth = 45
        Me.ColCancelApv.MinWidth = 45
        Me.ColCancelApv.Name = "ColCancelApv"
        Me.ColCancelApv.Visible = True
        Me.ColCancelApv.VisibleIndex = 8
        Me.ColCancelApv.Width = 45
        '
        'RepositoryItemButtonEdit7
        '
        Me.RepositoryItemButtonEdit7.AutoHeight = False
        Me.RepositoryItemButtonEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.DocCancel18, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEdit7.Name = "RepositoryItemButtonEdit7"
        Me.RepositoryItemButtonEdit7.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColCancel
        '
        Me.ColCancel.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColCancel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCancel.AppearanceCell.Options.UseBackColor = True
        Me.ColCancel.AppearanceCell.Options.UseFont = True
        Me.ColCancel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCancel.AppearanceHeader.Options.UseFont = True
        Me.ColCancel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCancel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCancel.Caption = "ยกเลิก"
        Me.ColCancel.ColumnEdit = Me.rptCancel
        Me.ColCancel.MaxWidth = 45
        Me.ColCancel.MinWidth = 45
        Me.ColCancel.Name = "ColCancel"
        Me.ColCancel.Visible = True
        Me.ColCancel.VisibleIndex = 2
        Me.ColCancel.Width = 45
        '
        'rptCancel
        '
        Me.rptCancel.AutoHeight = False
        Me.rptCancel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.cross_circle_frame, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject10, "", Nothing, Nothing, True)})
        Me.rptCancel.Name = "rptCancel"
        Me.rptCancel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colCompCode
        '
        Me.colCompCode.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colCompCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCompCode.AppearanceCell.Options.UseBackColor = True
        Me.colCompCode.AppearanceCell.Options.UseFont = True
        Me.colCompCode.AppearanceCell.Options.UseTextOptions = True
        Me.colCompCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colCompCode.AppearanceHeader.Options.UseFont = True
        Me.colCompCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompCode.Caption = "บริษัท"
        Me.colCompCode.FieldName = "CompCode"
        Me.colCompCode.MaxWidth = 45
        Me.colCompCode.MinWidth = 45
        Me.colCompCode.Name = "colCompCode"
        Me.colCompCode.OptionsColumn.AllowEdit = False
        Me.colCompCode.OptionsColumn.ReadOnly = True
        Me.colCompCode.Visible = True
        Me.colCompCode.VisibleIndex = 9
        Me.colCompCode.Width = 45
        '
        'ColDocRef1
        '
        Me.ColDocRef1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDocRef1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef1.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef1.AppearanceCell.Options.UseFont = True
        Me.ColDocRef1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef1.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef1.Caption = "เลขที่อ้างอิง"
        Me.ColDocRef1.FieldName = "DocRef"
        Me.ColDocRef1.Name = "ColDocRef1"
        Me.ColDocRef1.OptionsColumn.AllowEdit = False
        Me.ColDocRef1.OptionsColumn.ReadOnly = True
        Me.ColDocRef1.Visible = True
        Me.ColDocRef1.VisibleIndex = 10
        Me.ColDocRef1.Width = 118
        '
        'ColDateSale1
        '
        Me.ColDateSale1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDateSale1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateSale1.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale1.AppearanceCell.Options.UseFont = True
        Me.ColDateSale1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateSale1.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale1.Caption = "วันที่ขาย"
        Me.ColDateSale1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateSale1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateSale1.FieldName = "DateSale"
        Me.ColDateSale1.Name = "ColDateSale1"
        Me.ColDateSale1.OptionsColumn.AllowEdit = False
        Me.ColDateSale1.OptionsColumn.ReadOnly = True
        Me.ColDateSale1.Visible = True
        Me.ColDateSale1.VisibleIndex = 11
        Me.ColDateSale1.Width = 80
        '
        'ColDatePay1
        '
        Me.ColDatePay1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDatePay1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDatePay1.AppearanceCell.Options.UseBackColor = True
        Me.ColDatePay1.AppearanceCell.Options.UseFont = True
        Me.ColDatePay1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDatePay1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDatePay1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDatePay1.AppearanceHeader.Options.UseFont = True
        Me.ColDatePay1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDatePay1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDatePay1.Caption = "วันที่จ่ายเงิน"
        Me.ColDatePay1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDatePay1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDatePay1.FieldName = "DatePay"
        Me.ColDatePay1.Name = "ColDatePay1"
        Me.ColDatePay1.OptionsColumn.AllowEdit = False
        Me.ColDatePay1.OptionsColumn.ReadOnly = True
        Me.ColDatePay1.Visible = True
        Me.ColDatePay1.VisibleIndex = 12
        Me.ColDatePay1.Width = 80
        '
        'ColCusName1
        '
        Me.ColCusName1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColCusName1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCusName1.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName1.AppearanceCell.Options.UseFont = True
        Me.ColCusName1.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCusName1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColCusName1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCusName1.AppearanceHeader.Options.UseFont = True
        Me.ColCusName1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCusName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusName1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColCusName1.Caption = "ชื่อลูกค้า"
        Me.ColCusName1.ColumnEdit = Me.rptCusName
        Me.ColCusName1.FieldName = "CusName"
        Me.ColCusName1.Name = "ColCusName1"
        Me.ColCusName1.OptionsColumn.AllowEdit = False
        Me.ColCusName1.OptionsColumn.ReadOnly = True
        Me.ColCusName1.Visible = True
        Me.ColCusName1.VisibleIndex = 13
        Me.ColCusName1.Width = 228
        '
        'rptCusName
        '
        Me.rptCusName.Name = "rptCusName"
        '
        'ColAp1
        '
        Me.ColAp1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColAp1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAp1.AppearanceCell.Options.UseBackColor = True
        Me.ColAp1.AppearanceCell.Options.UseFont = True
        Me.ColAp1.AppearanceCell.Options.UseTextOptions = True
        Me.ColAp1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAp1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAp1.AppearanceHeader.Options.UseFont = True
        Me.ColAp1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAp1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAp1.Caption = "อำเภอ"
        Me.ColAp1.FieldName = "ApName"
        Me.ColAp1.Name = "ColAp1"
        Me.ColAp1.OptionsColumn.AllowEdit = False
        Me.ColAp1.OptionsColumn.ReadOnly = True
        Me.ColAp1.Visible = True
        Me.ColAp1.VisibleIndex = 14
        Me.ColAp1.Width = 80
        '
        'ColPv1
        '
        Me.ColPv1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPv1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPv1.AppearanceCell.Options.UseBackColor = True
        Me.ColPv1.AppearanceCell.Options.UseFont = True
        Me.ColPv1.AppearanceCell.Options.UseTextOptions = True
        Me.ColPv1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPv1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPv1.AppearanceHeader.Options.UseFont = True
        Me.ColPv1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPv1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPv1.Caption = "จังหวัด"
        Me.ColPv1.FieldName = "PvName"
        Me.ColPv1.Name = "ColPv1"
        Me.ColPv1.OptionsColumn.AllowEdit = False
        Me.ColPv1.OptionsColumn.ReadOnly = True
        Me.ColPv1.Visible = True
        Me.ColPv1.VisibleIndex = 15
        Me.ColPv1.Width = 80
        '
        'ColidCancel1
        '
        Me.ColidCancel1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColidCancel1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidCancel1.AppearanceCell.Options.UseBackColor = True
        Me.ColidCancel1.AppearanceCell.Options.UseFont = True
        Me.ColidCancel1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidCancel1.AppearanceHeader.Options.UseFont = True
        Me.ColidCancel1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidCancel1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidCancel1.Caption = "idCancel"
        Me.ColidCancel1.FieldName = "idPsCancel"
        Me.ColidCancel1.Name = "ColidCancel1"
        '
        'ColTotal
        '
        Me.ColTotal.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColTotal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotal.AppearanceCell.Options.UseBackColor = True
        Me.ColTotal.AppearanceCell.Options.UseFont = True
        Me.ColTotal.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotal.AppearanceHeader.Options.UseFont = True
        Me.ColTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotal.Caption = "รวมราคา"
        Me.ColTotal.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotal.FieldName = "Total"
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.OptionsColumn.AllowEdit = False
        Me.ColTotal.OptionsColumn.ReadOnly = True
        Me.ColTotal.Width = 90
        '
        'ColDisCntAmt1
        '
        Me.ColDisCntAmt1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDisCntAmt1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDisCntAmt1.AppearanceCell.Options.UseBackColor = True
        Me.ColDisCntAmt1.AppearanceCell.Options.UseFont = True
        Me.ColDisCntAmt1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDisCntAmt1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDisCntAmt1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDisCntAmt1.AppearanceHeader.Options.UseFont = True
        Me.ColDisCntAmt1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDisCntAmt1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDisCntAmt1.Caption = "ส่วนลดจำนวน"
        Me.ColDisCntAmt1.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColDisCntAmt1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDisCntAmt1.FieldName = "DiscountAmout"
        Me.ColDisCntAmt1.Name = "ColDisCntAmt1"
        Me.ColDisCntAmt1.OptionsColumn.AllowEdit = False
        Me.ColDisCntAmt1.OptionsColumn.ReadOnly = True
        Me.ColDisCntAmt1.Width = 93
        '
        'ColDisPer1
        '
        Me.ColDisPer1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDisPer1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDisPer1.AppearanceCell.Options.UseBackColor = True
        Me.ColDisPer1.AppearanceCell.Options.UseFont = True
        Me.ColDisPer1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDisPer1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDisPer1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDisPer1.AppearanceHeader.Options.UseFont = True
        Me.ColDisPer1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDisPer1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDisPer1.Caption = "ส่วนลด %"
        Me.ColDisPer1.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColDisPer1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDisPer1.FieldName = "DiscountPerc"
        Me.ColDisPer1.Name = "ColDisPer1"
        Me.ColDisPer1.OptionsColumn.AllowEdit = False
        Me.ColDisPer1.OptionsColumn.ReadOnly = True
        Me.ColDisPer1.Width = 69
        '
        'ColTotalNet1
        '
        Me.ColTotalNet1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColTotalNet1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotalNet1.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalNet1.AppearanceCell.Options.UseFont = True
        Me.ColTotalNet1.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalNet1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalNet1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotalNet1.AppearanceHeader.Options.UseFont = True
        Me.ColTotalNet1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalNet1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalNet1.Caption = "รวมสุทธิ"
        Me.ColTotalNet1.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColTotalNet1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalNet1.FieldName = "TotalNet"
        Me.ColTotalNet1.Name = "ColTotalNet1"
        Me.ColTotalNet1.OptionsColumn.AllowEdit = False
        Me.ColTotalNet1.OptionsColumn.ReadOnly = True
        Me.ColTotalNet1.Visible = True
        Me.ColTotalNet1.VisibleIndex = 16
        Me.ColTotalNet1.Width = 90
        '
        'ColPsSale
        '
        Me.ColPsSale.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPsSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsSale.AppearanceCell.Options.UseBackColor = True
        Me.ColPsSale.AppearanceCell.Options.UseFont = True
        Me.ColPsSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsSale.AppearanceHeader.Options.UseFont = True
        Me.ColPsSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsSale.Caption = "เจ้าหน้าที่ขาย"
        Me.ColPsSale.FieldName = "PsSale"
        Me.ColPsSale.Name = "ColPsSale"
        Me.ColPsSale.OptionsColumn.AllowEdit = False
        Me.ColPsSale.OptionsColumn.ReadOnly = True
        Me.ColPsSale.Visible = True
        Me.ColPsSale.VisibleIndex = 17
        Me.ColPsSale.Width = 90
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.Caption = "เลขที่รายการ"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 18
        Me.ColDocCode.Width = 84
        '
        'ColDocRefAcc1
        '
        Me.ColDocRefAcc1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDocRefAcc1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRefAcc1.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRefAcc1.AppearanceCell.Options.UseFont = True
        Me.ColDocRefAcc1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRefAcc1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRefAcc1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRefAcc1.AppearanceHeader.Options.UseFont = True
        Me.ColDocRefAcc1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRefAcc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRefAcc1.Caption = "เลขที่ทางบัญชี"
        Me.ColDocRefAcc1.FieldName = "DocRefAcc"
        Me.ColDocRefAcc1.Name = "ColDocRefAcc1"
        Me.ColDocRefAcc1.OptionsColumn.AllowEdit = False
        Me.ColDocRefAcc1.OptionsColumn.ReadOnly = True
        Me.ColDocRefAcc1.Visible = True
        Me.ColDocRefAcc1.VisibleIndex = 19
        Me.ColDocRefAcc1.Width = 97
        '
        'ColPsTs1
        '
        Me.ColPsTs1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPsTs1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsTs1.AppearanceCell.Options.UseBackColor = True
        Me.ColPsTs1.AppearanceCell.Options.UseFont = True
        Me.ColPsTs1.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsTs1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsTs1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsTs1.AppearanceHeader.Options.UseFont = True
        Me.ColPsTs1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsTs1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsTs1.Caption = "ผู้ทำรายการ"
        Me.ColPsTs1.FieldName = "PsTs"
        Me.ColPsTs1.Name = "ColPsTs1"
        Me.ColPsTs1.OptionsColumn.AllowEdit = False
        Me.ColPsTs1.OptionsColumn.ReadOnly = True
        Me.ColPsTs1.Visible = True
        Me.ColPsTs1.VisibleIndex = 20
        '
        'ColDateTs1
        '
        Me.ColDateTs1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDateTs1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateTs1.AppearanceCell.Options.UseBackColor = True
        Me.ColDateTs1.AppearanceCell.Options.UseFont = True
        Me.ColDateTs1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateTs1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateTs1.AppearanceHeader.Options.UseFont = True
        Me.ColDateTs1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateTs1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs1.Caption = "วันที่ทำรายการ"
        Me.ColDateTs1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateTs1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateTs1.FieldName = "DateTs"
        Me.ColDateTs1.Name = "ColDateTs1"
        Me.ColDateTs1.OptionsColumn.AllowEdit = False
        Me.ColDateTs1.OptionsColumn.ReadOnly = True
        Me.ColDateTs1.Visible = True
        Me.ColDateTs1.VisibleIndex = 21
        Me.ColDateTs1.Width = 94
        '
        'ColTimeTs1
        '
        Me.ColTimeTs1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColTimeTs1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTimeTs1.AppearanceCell.Options.UseBackColor = True
        Me.ColTimeTs1.AppearanceCell.Options.UseFont = True
        Me.ColTimeTs1.AppearanceCell.Options.UseTextOptions = True
        Me.ColTimeTs1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTimeTs1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTimeTs1.AppearanceHeader.Options.UseFont = True
        Me.ColTimeTs1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTimeTs1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTimeTs1.Caption = "เวลา"
        Me.ColTimeTs1.FieldName = "TimeTs"
        Me.ColTimeTs1.Name = "ColTimeTs1"
        Me.ColTimeTs1.OptionsColumn.AllowEdit = False
        Me.ColTimeTs1.OptionsColumn.ReadOnly = True
        Me.ColTimeTs1.Visible = True
        Me.ColTimeTs1.VisibleIndex = 22
        Me.ColTimeTs1.Width = 51
        '
        'ColPsAccept1
        '
        Me.ColPsAccept1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPsAccept1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsAccept1.AppearanceCell.Options.UseBackColor = True
        Me.ColPsAccept1.AppearanceCell.Options.UseFont = True
        Me.ColPsAccept1.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsAccept1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsAccept1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsAccept1.AppearanceHeader.Options.UseFont = True
        Me.ColPsAccept1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsAccept1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsAccept1.Caption = "ผู้รับทราบ"
        Me.ColPsAccept1.FieldName = "PsAccept"
        Me.ColPsAccept1.Name = "ColPsAccept1"
        Me.ColPsAccept1.OptionsColumn.AllowEdit = False
        Me.ColPsAccept1.OptionsColumn.ReadOnly = True
        Me.ColPsAccept1.Visible = True
        Me.ColPsAccept1.VisibleIndex = 24
        Me.ColPsAccept1.Width = 69
        '
        'ColDateAccept1
        '
        Me.ColDateAccept1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDateAccept1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateAccept1.AppearanceCell.Options.UseBackColor = True
        Me.ColDateAccept1.AppearanceCell.Options.UseFont = True
        Me.ColDateAccept1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateAccept1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateAccept1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateAccept1.AppearanceHeader.Options.UseFont = True
        Me.ColDateAccept1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateAccept1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateAccept1.Caption = "วันที่รับทราบ"
        Me.ColDateAccept1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateAccept1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateAccept1.FieldName = "DateAccept"
        Me.ColDateAccept1.Name = "ColDateAccept1"
        Me.ColDateAccept1.OptionsColumn.AllowEdit = False
        Me.ColDateAccept1.OptionsColumn.ReadOnly = True
        Me.ColDateAccept1.Visible = True
        Me.ColDateAccept1.VisibleIndex = 25
        Me.ColDateAccept1.Width = 80
        '
        'ColPsCheck1
        '
        Me.ColPsCheck1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPsCheck1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsCheck1.AppearanceCell.Options.UseBackColor = True
        Me.ColPsCheck1.AppearanceCell.Options.UseFont = True
        Me.ColPsCheck1.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsCheck1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsCheck1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsCheck1.AppearanceHeader.Options.UseFont = True
        Me.ColPsCheck1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsCheck1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsCheck1.Caption = "ผู้ตรวจสอบ"
        Me.ColPsCheck1.FieldName = "PsCheck"
        Me.ColPsCheck1.Name = "ColPsCheck1"
        Me.ColPsCheck1.OptionsColumn.AllowEdit = False
        Me.ColPsCheck1.OptionsColumn.ReadOnly = True
        Me.ColPsCheck1.Visible = True
        Me.ColPsCheck1.VisibleIndex = 26
        '
        'ColDateCheck1
        '
        Me.ColDateCheck1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDateCheck1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateCheck1.AppearanceCell.Options.UseBackColor = True
        Me.ColDateCheck1.AppearanceCell.Options.UseFont = True
        Me.ColDateCheck1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateCheck1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateCheck1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateCheck1.AppearanceHeader.Options.UseFont = True
        Me.ColDateCheck1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateCheck1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateCheck1.Caption = "วันที่ตรวจสอบ"
        Me.ColDateCheck1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateCheck1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateCheck1.FieldName = "DateChcek"
        Me.ColDateCheck1.Name = "ColDateCheck1"
        Me.ColDateCheck1.OptionsColumn.AllowEdit = False
        Me.ColDateCheck1.OptionsColumn.ReadOnly = True
        Me.ColDateCheck1.Visible = True
        Me.ColDateCheck1.VisibleIndex = 27
        Me.ColDateCheck1.Width = 91
        '
        'ColPsApp
        '
        Me.ColPsApp.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPsApp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsApp.AppearanceCell.Options.UseBackColor = True
        Me.ColPsApp.AppearanceCell.Options.UseFont = True
        Me.ColPsApp.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsApp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsApp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsApp.AppearanceHeader.Options.UseFont = True
        Me.ColPsApp.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsApp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsApp.Caption = "ผู้อนุมัติ1"
        Me.ColPsApp.FieldName = "PsApp"
        Me.ColPsApp.Name = "ColPsApp"
        Me.ColPsApp.OptionsColumn.AllowEdit = False
        Me.ColPsApp.OptionsColumn.ReadOnly = True
        Me.ColPsApp.Visible = True
        Me.ColPsApp.VisibleIndex = 28
        '
        'ColDateApp1
        '
        Me.ColDateApp1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDateApp1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateApp1.AppearanceCell.Options.UseBackColor = True
        Me.ColDateApp1.AppearanceCell.Options.UseFont = True
        Me.ColDateApp1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateApp1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateApp1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateApp1.AppearanceHeader.Options.UseFont = True
        Me.ColDateApp1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateApp1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateApp1.Caption = "วันที่อนุมัติ1"
        Me.ColDateApp1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateApp1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateApp1.FieldName = "DateApp"
        Me.ColDateApp1.Name = "ColDateApp1"
        Me.ColDateApp1.OptionsColumn.AllowEdit = False
        Me.ColDateApp1.OptionsColumn.ReadOnly = True
        Me.ColDateApp1.Visible = True
        Me.ColDateApp1.VisibleIndex = 29
        '
        'ColPsApp2
        '
        Me.ColPsApp2.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPsApp2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsApp2.AppearanceCell.Options.UseBackColor = True
        Me.ColPsApp2.AppearanceCell.Options.UseFont = True
        Me.ColPsApp2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsApp2.AppearanceHeader.Options.UseFont = True
        Me.ColPsApp2.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsApp2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsApp2.Caption = "ผู้อนุมัติ2"
        Me.ColPsApp2.FieldName = "PsApp2"
        Me.ColPsApp2.Name = "ColPsApp2"
        Me.ColPsApp2.OptionsColumn.AllowEdit = False
        Me.ColPsApp2.OptionsColumn.ReadOnly = True
        Me.ColPsApp2.Visible = True
        Me.ColPsApp2.VisibleIndex = 30
        '
        'colDateApp2
        '
        Me.colDateApp2.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colDateApp2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDateApp2.AppearanceCell.Options.UseBackColor = True
        Me.colDateApp2.AppearanceCell.Options.UseFont = True
        Me.colDateApp2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colDateApp2.AppearanceHeader.Options.UseFont = True
        Me.colDateApp2.AppearanceHeader.Options.UseTextOptions = True
        Me.colDateApp2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDateApp2.Caption = "วันที่อนุมัติ2"
        Me.colDateApp2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colDateApp2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDateApp2.FieldName = "DateApp2"
        Me.colDateApp2.Name = "colDateApp2"
        Me.colDateApp2.OptionsColumn.AllowEdit = False
        Me.colDateApp2.OptionsColumn.ReadOnly = True
        Me.colDateApp2.Visible = True
        Me.colDateApp2.VisibleIndex = 31
        '
        'ColNote1
        '
        Me.ColNote1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColNote1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNote1.AppearanceCell.Options.UseBackColor = True
        Me.ColNote1.AppearanceCell.Options.UseFont = True
        Me.ColNote1.AppearanceCell.Options.UseTextOptions = True
        Me.ColNote1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColNote1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNote1.AppearanceHeader.Options.UseFont = True
        Me.ColNote1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNote1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNote1.Caption = "หมายเหตุ"
        Me.ColNote1.FieldName = "Note"
        Me.ColNote1.Name = "ColNote1"
        Me.ColNote1.OptionsColumn.AllowEdit = False
        Me.ColNote1.OptionsColumn.ReadOnly = True
        Me.ColNote1.Visible = True
        Me.ColNote1.VisibleIndex = 32
        Me.ColNote1.Width = 174
        '
        'ColstBillOrder1
        '
        Me.ColstBillOrder1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColstBillOrder1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColstBillOrder1.AppearanceCell.Options.UseBackColor = True
        Me.ColstBillOrder1.AppearanceCell.Options.UseFont = True
        Me.ColstBillOrder1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColstBillOrder1.AppearanceHeader.Options.UseFont = True
        Me.ColstBillOrder1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColstBillOrder1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColstBillOrder1.Caption = "stBillOrder"
        Me.ColstBillOrder1.FieldName = "stBillOrder"
        Me.ColstBillOrder1.Name = "ColstBillOrder1"
        '
        'ColstBillType1
        '
        Me.ColstBillType1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColstBillType1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColstBillType1.AppearanceCell.Options.UseBackColor = True
        Me.ColstBillType1.AppearanceCell.Options.UseFont = True
        Me.ColstBillType1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColstBillType1.AppearanceHeader.Options.UseFont = True
        Me.ColstBillType1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColstBillType1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColstBillType1.Caption = "stBillType"
        Me.ColstBillType1.FieldName = "stBillType"
        Me.ColstBillType1.Name = "ColstBillType1"
        '
        'ColidCus
        '
        Me.ColidCus.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColidCus.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidCus.AppearanceCell.Options.UseBackColor = True
        Me.ColidCus.AppearanceCell.Options.UseFont = True
        Me.ColidCus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidCus.AppearanceHeader.Options.UseFont = True
        Me.ColidCus.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidCus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidCus.Caption = "idCus"
        Me.ColidCus.FieldName = "idCus"
        Me.ColidCus.Name = "ColidCus"
        '
        'colidComp
        '
        Me.colidComp.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colidComp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidComp.AppearanceCell.Options.UseBackColor = True
        Me.colidComp.AppearanceCell.Options.UseFont = True
        Me.colidComp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidComp.AppearanceHeader.Options.UseFont = True
        Me.colidComp.AppearanceHeader.Options.UseTextOptions = True
        Me.colidComp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colidComp.Caption = "idComp"
        Me.colidComp.FieldName = "idComp"
        Me.colidComp.Name = "colidComp"
        '
        'colidTs
        '
        Me.colidTs.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colidTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidTs.AppearanceCell.Options.UseBackColor = True
        Me.colidTs.AppearanceCell.Options.UseFont = True
        Me.colidTs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidTs.AppearanceHeader.Options.UseFont = True
        Me.colidTs.AppearanceHeader.Options.UseTextOptions = True
        Me.colidTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colidTs.Caption = "idTS"
        Me.colidTs.FieldName = "idTS"
        Me.colidTs.Name = "colidTs"
        '
        'colidPsSale
        '
        Me.colidPsSale.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colidPsSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidPsSale.AppearanceCell.Options.UseBackColor = True
        Me.colidPsSale.AppearanceCell.Options.UseFont = True
        Me.colidPsSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidPsSale.AppearanceHeader.Options.UseFont = True
        Me.colidPsSale.AppearanceHeader.Options.UseTextOptions = True
        Me.colidPsSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colidPsSale.Caption = "idPsSale"
        Me.colidPsSale.FieldName = "idPsSale"
        Me.colidPsSale.Name = "colidPsSale"
        '
        'colidSend
        '
        Me.colidSend.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colidSend.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidSend.AppearanceCell.Options.UseBackColor = True
        Me.colidSend.AppearanceCell.Options.UseFont = True
        Me.colidSend.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidSend.AppearanceHeader.Options.UseFont = True
        Me.colidSend.AppearanceHeader.Options.UseTextOptions = True
        Me.colidSend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colidSend.Caption = "idSend"
        Me.colidSend.FieldName = "idSend"
        Me.colidSend.Name = "colidSend"
        '
        'ColCompName
        '
        Me.ColCompName.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColCompName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCompName.AppearanceCell.Options.UseBackColor = True
        Me.ColCompName.AppearanceCell.Options.UseFont = True
        Me.ColCompName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCompName.AppearanceHeader.Options.UseFont = True
        Me.ColCompName.Caption = "ชื่อบริษัท(เต็ม)"
        Me.ColCompName.FieldName = "CompanyName"
        Me.ColCompName.Name = "ColCompName"
        '
        'colidSlAVxST
        '
        Me.colidSlAVxST.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colidSlAVxST.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidSlAVxST.AppearanceCell.Options.UseBackColor = True
        Me.colidSlAVxST.AppearanceCell.Options.UseFont = True
        Me.colidSlAVxST.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidSlAVxST.AppearanceHeader.Options.UseFont = True
        Me.colidSlAVxST.Caption = "idSlAVxST"
        Me.colidSlAVxST.FieldName = "idSlAVxST"
        Me.colidSlAVxST.Name = "colidSlAVxST"
        '
        'colSaleCode
        '
        Me.colSaleCode.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colSaleCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colSaleCode.AppearanceCell.Options.UseBackColor = True
        Me.colSaleCode.AppearanceCell.Options.UseFont = True
        Me.colSaleCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colSaleCode.AppearanceHeader.Options.UseFont = True
        Me.colSaleCode.Caption = "รหัสเอกสาร"
        Me.colSaleCode.FieldName = "SaleCode"
        Me.colSaleCode.Name = "colSaleCode"
        '
        'ColidPartner
        '
        Me.ColidPartner.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColidPartner.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidPartner.AppearanceCell.Options.UseBackColor = True
        Me.ColidPartner.AppearanceCell.Options.UseFont = True
        Me.ColidPartner.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidPartner.AppearanceHeader.Options.UseFont = True
        Me.ColidPartner.Caption = "idPartner"
        Me.ColidPartner.FieldName = "idPartner"
        Me.ColidPartner.Name = "ColidPartner"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(769, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 636
        Me.Label6.Text = "รายการขายจากรายการสั่งซื้อ"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(742, 159)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(26, 21)
        Me.Panel4.TabIndex = 632
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cbSlAVxST)
        Me.GroupBox4.Controls.Add(Me.ChkCancel)
        Me.GroupBox4.Controls.Add(Me.txtPsSale)
        Me.GroupBox4.Controls.Add(Me.txtCusName)
        Me.GroupBox4.Controls.Add(Me.chkComp)
        Me.GroupBox4.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox4.Controls.Add(Me.ChkCus)
        Me.GroupBox4.Controls.Add(Me.ChkPsSale)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(727, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(317, 144)
        Me.GroupBox4.TabIndex = 607
        Me.GroupBox4.TabStop = False
        '
        'cbSlAVxST
        '
        Me.cbSlAVxST.AutoSize = True
        Me.cbSlAVxST.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbSlAVxST.Location = New System.Drawing.Point(13, 121)
        Me.cbSlAVxST.Name = "cbSlAVxST"
        Me.cbSlAVxST.Size = New System.Drawing.Size(213, 18)
        Me.cbSlAVxST.TabIndex = 968
        Me.cbSlAVxST.Text = "แสดงเฉพาะรายการขายระหว่าง AV-ST"
        Me.cbSlAVxST.UseVisualStyleBackColor = True
        '
        'ChkCancel
        '
        Me.ChkCancel.AutoSize = True
        Me.ChkCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkCancel.Location = New System.Drawing.Point(13, 97)
        Me.ChkCancel.Name = "ChkCancel"
        Me.ChkCancel.Size = New System.Drawing.Size(143, 18)
        Me.ChkCancel.TabIndex = 612
        Me.ChkCancel.Text = "ไม่แสดงรายการที่ยกเลิก"
        Me.ChkCancel.UseVisualStyleBackColor = True
        '
        'txtPsSale
        '
        Me.txtPsSale.Enabled = False
        Me.txtPsSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPsSale.Location = New System.Drawing.Point(107, 72)
        Me.txtPsSale.Name = "txtPsSale"
        Me.txtPsSale.Size = New System.Drawing.Size(196, 22)
        Me.txtPsSale.TabIndex = 967
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(107, 44)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(196, 22)
        Me.txtCusName.TabIndex = 966
        '
        'chkComp
        '
        Me.chkComp.AutoSize = True
        Me.chkComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkComp.Location = New System.Drawing.Point(13, 20)
        Me.chkComp.Name = "chkComp"
        Me.chkComp.Size = New System.Drawing.Size(57, 18)
        Me.chkComp.TabIndex = 965
        Me.chkComp.Text = "บริษัท"
        Me.chkComp.UseVisualStyleBackColor = True
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Enabled = False
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(107, 18)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(196, 22)
        Me.cmbGroupComp.TabIndex = 964
        '
        'ChkCus
        '
        Me.ChkCus.AutoSize = True
        Me.ChkCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkCus.Location = New System.Drawing.Point(13, 46)
        Me.ChkCus.Name = "ChkCus"
        Me.ChkCus.Size = New System.Drawing.Size(53, 18)
        Me.ChkCus.TabIndex = 412
        Me.ChkCus.Text = "ลูกค้า"
        Me.ChkCus.UseVisualStyleBackColor = True
        '
        'ChkPsSale
        '
        Me.ChkPsSale.AutoSize = True
        Me.ChkPsSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkPsSale.Location = New System.Drawing.Point(13, 71)
        Me.ChkPsSale.Name = "ChkPsSale"
        Me.ChkPsSale.Size = New System.Drawing.Size(93, 18)
        Me.ChkPsSale.TabIndex = 608
        Me.ChkPsSale.Text = "เจ้าหน้าที่ขาย"
        Me.ChkPsSale.UseVisualStyleBackColor = True
        '
        'ChkDoc
        '
        Me.ChkDoc.AutoSize = True
        Me.ChkDoc.Location = New System.Drawing.Point(19, 72)
        Me.ChkDoc.Name = "ChkDoc"
        Me.ChkDoc.Size = New System.Drawing.Size(82, 18)
        Me.ChkDoc.TabIndex = 618
        Me.ChkDoc.Text = "รหัสเอกสาร"
        Me.ChkDoc.UseVisualStyleBackColor = True
        '
        'CCbEditDoc
        '
        Me.CCbEditDoc.Enabled = False
        Me.CCbEditDoc.Location = New System.Drawing.Point(107, 72)
        Me.CCbEditDoc.Name = "CCbEditDoc"
        Me.CCbEditDoc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCbEditDoc.Properties.Appearance.Options.UseFont = True
        Me.CCbEditDoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CCbEditDoc.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.CCbEditDoc.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.CCbEditDoc.Size = New System.Drawing.Size(168, 20)
        Me.CCbEditDoc.TabIndex = 601
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cbDraft)
        Me.GroupBox3.Controls.Add(Me.cmbTsp)
        Me.GroupBox3.Controls.Add(Me.ChkDocCode)
        Me.GroupBox3.Controls.Add(Me.ChkTsp)
        Me.GroupBox3.Controls.Add(Me.ChkStOrd)
        Me.GroupBox3.Controls.Add(Me.txtDocRef)
        Me.GroupBox3.Controls.Add(Me.ChkDocRef)
        Me.GroupBox3.Controls.Add(Me.txtDocCode)
        Me.GroupBox3.Controls.Add(Me.CCbEditDoc)
        Me.GroupBox3.Controls.Add(Me.ChkDoc)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(428, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(293, 184)
        Me.GroupBox3.TabIndex = 602
        Me.GroupBox3.TabStop = False
        '
        'cbDraft
        '
        Me.cbDraft.AutoSize = True
        Me.cbDraft.Location = New System.Drawing.Point(19, 145)
        Me.cbDraft.Name = "cbDraft"
        Me.cbDraft.Size = New System.Drawing.Size(163, 18)
        Me.cbDraft.TabIndex = 619
        Me.cbDraft.Text = "แสดงเฉพาะแบบร่าง (Draft)"
        Me.cbDraft.UseVisualStyleBackColor = True
        '
        'cmbTsp
        '
        Me.cmbTsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTsp.Enabled = False
        Me.cmbTsp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTsp.FormattingEnabled = True
        Me.cmbTsp.Location = New System.Drawing.Point(107, 96)
        Me.cmbTsp.Name = "cmbTsp"
        Me.cmbTsp.Size = New System.Drawing.Size(168, 22)
        Me.cmbTsp.TabIndex = 615
        '
        'ChkDocCode
        '
        Me.ChkDocCode.AutoSize = True
        Me.ChkDocCode.Location = New System.Drawing.Point(19, 20)
        Me.ChkDocCode.Name = "ChkDocCode"
        Me.ChkDocCode.Size = New System.Drawing.Size(89, 18)
        Me.ChkDocCode.TabIndex = 610
        Me.ChkDocCode.Text = "เลขที่รายการ"
        Me.ChkDocCode.UseVisualStyleBackColor = True
        '
        'ChkTsp
        '
        Me.ChkTsp.AutoSize = True
        Me.ChkTsp.Location = New System.Drawing.Point(19, 98)
        Me.ChkTsp.Name = "ChkTsp"
        Me.ChkTsp.Size = New System.Drawing.Size(71, 18)
        Me.ChkTsp.TabIndex = 613
        Me.ChkTsp.Text = "การขนส่ง"
        Me.ChkTsp.UseVisualStyleBackColor = True
        '
        'ChkStOrd
        '
        Me.ChkStOrd.AutoSize = True
        Me.ChkStOrd.Location = New System.Drawing.Point(19, 121)
        Me.ChkStOrd.Name = "ChkStOrd"
        Me.ChkStOrd.Size = New System.Drawing.Size(222, 18)
        Me.ChkStOrd.TabIndex = 611
        Me.ChkStOrd.Text = "แสดงเฉพาะรายการขายจากรายการสั่งซื้อ"
        Me.ChkStOrd.UseVisualStyleBackColor = True
        '
        'txtDocRef
        '
        Me.txtDocRef.Enabled = False
        Me.txtDocRef.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocRef.Location = New System.Drawing.Point(107, 44)
        Me.txtDocRef.Name = "txtDocRef"
        Me.txtDocRef.Size = New System.Drawing.Size(168, 22)
        Me.txtDocRef.TabIndex = 617
        '
        'ChkDocRef
        '
        Me.ChkDocRef.AutoSize = True
        Me.ChkDocRef.Location = New System.Drawing.Point(19, 46)
        Me.ChkDocRef.Name = "ChkDocRef"
        Me.ChkDocRef.Size = New System.Drawing.Size(85, 18)
        Me.ChkDocRef.TabIndex = 616
        Me.ChkDocRef.Text = "เลขที่อ้างอิง"
        Me.ChkDocRef.UseVisualStyleBackColor = True
        '
        'txtDocCode
        '
        Me.txtDocCode.Enabled = False
        Me.txtDocCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocCode.Location = New System.Drawing.Point(107, 18)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Size = New System.Drawing.Size(168, 22)
        Me.txtDocCode.TabIndex = 611
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpMonthNow)
        Me.GroupBox2.Controls.Add(Me.dtpMonthE)
        Me.GroupBox2.Controls.Add(Me.dtpMonthS)
        Me.GroupBox2.Controls.Add(Me.rdbBack7)
        Me.GroupBox2.Controls.Add(Me.rdbMonthNow)
        Me.GroupBox2.Controls.Add(Me.dtpSaleE)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpYear)
        Me.GroupBox2.Controls.Add(Me.rdbYear)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdbMonth)
        Me.GroupBox2.Controls.Add(Me.rdbDate)
        Me.GroupBox2.Controls.Add(Me.dtpSaleS)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 139)
        Me.GroupBox2.TabIndex = 606
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ช่วงวันที่"
        '
        'dtpMonthNow
        '
        Me.dtpMonthNow.Checked = False
        Me.dtpMonthNow.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthNow.Enabled = False
        Me.dtpMonthNow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthNow.Location = New System.Drawing.Point(82, 77)
        Me.dtpMonthNow.Name = "dtpMonthNow"
        Me.dtpMonthNow.Size = New System.Drawing.Size(147, 22)
        Me.dtpMonthNow.TabIndex = 650
        '
        'dtpMonthE
        '
        Me.dtpMonthE.Checked = False
        Me.dtpMonthE.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthE.Enabled = False
        Me.dtpMonthE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthE.Location = New System.Drawing.Point(260, 49)
        Me.dtpMonthE.Name = "dtpMonthE"
        Me.dtpMonthE.Size = New System.Drawing.Size(144, 22)
        Me.dtpMonthE.TabIndex = 649
        '
        'dtpMonthS
        '
        Me.dtpMonthS.Checked = False
        Me.dtpMonthS.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthS.Enabled = False
        Me.dtpMonthS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthS.Location = New System.Drawing.Point(82, 48)
        Me.dtpMonthS.Name = "dtpMonthS"
        Me.dtpMonthS.Size = New System.Drawing.Size(147, 22)
        Me.dtpMonthS.TabIndex = 648
        '
        'rdbBack7
        '
        Me.rdbBack7.AutoSize = True
        Me.rdbBack7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbBack7.Location = New System.Drawing.Point(12, 107)
        Me.rdbBack7.Name = "rdbBack7"
        Me.rdbBack7.Size = New System.Drawing.Size(95, 18)
        Me.rdbBack7.TabIndex = 630
        Me.rdbBack7.Text = "ย้อนหลัง 7 วัน"
        Me.rdbBack7.UseVisualStyleBackColor = True
        '
        'rdbMonthNow
        '
        Me.rdbMonthNow.AutoSize = True
        Me.rdbMonthNow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonthNow.Location = New System.Drawing.Point(12, 80)
        Me.rdbMonthNow.Name = "rdbMonthNow"
        Me.rdbMonthNow.Size = New System.Drawing.Size(50, 18)
        Me.rdbMonthNow.TabIndex = 628
        Me.rdbMonthNow.Text = "เดือน"
        Me.rdbMonthNow.UseVisualStyleBackColor = True
        '
        'dtpSaleE
        '
        Me.dtpSaleE.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleE.Location = New System.Drawing.Point(260, 20)
        Me.dtpSaleE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleE.Name = "dtpSaleE"
        Me.dtpSaleE.Size = New System.Drawing.Size(144, 22)
        Me.dtpSaleE.TabIndex = 607
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 14)
        Me.Label1.TabIndex = 624
        Me.Label1.Text = "ถึง"
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(169, 104)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(65, 22)
        Me.dtpYear.TabIndex = 621
        Me.dtpYear.Value = New Date(2015, 1, 19, 15, 28, 51, 0)
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbYear.Location = New System.Drawing.Point(131, 107)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(33, 18)
        Me.rdbYear.TabIndex = 606
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(235, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 14)
        Me.Label4.TabIndex = 605
        Me.Label4.Text = "ถึง"
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonth.Location = New System.Drawing.Point(12, 52)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(70, 18)
        Me.rdbMonth.TabIndex = 604
        Me.rdbMonth.Text = "ช่วงเดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDate.Location = New System.Drawing.Point(12, 25)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(47, 18)
        Me.rdbDate.TabIndex = 603
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "วันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpSaleS
        '
        Me.dtpSaleS.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleS.Location = New System.Drawing.Point(82, 20)
        Me.dtpSaleS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleS.Name = "dtpSaleS"
        Me.dtpSaleS.Size = New System.Drawing.Size(147, 22)
        Me.dtpSaleS.TabIndex = 601
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbDateTs)
        Me.GroupBox1.Controls.Add(Me.rdbDateSale)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 43)
        Me.GroupBox1.TabIndex = 600
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทข้อมูลวันที่"
        '
        'rdbDateTs
        '
        Me.rdbDateTs.AutoSize = True
        Me.rdbDateTs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDateTs.Location = New System.Drawing.Point(168, 18)
        Me.rdbDateTs.Name = "rdbDateTs"
        Me.rdbDateTs.Size = New System.Drawing.Size(98, 18)
        Me.rdbDateTs.TabIndex = 601
        Me.rdbDateTs.Text = "วันที่ทำรายการ"
        Me.rdbDateTs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbDateTs.UseVisualStyleBackColor = True
        '
        'rdbDateSale
        '
        Me.rdbDateSale.AutoSize = True
        Me.rdbDateSale.Checked = True
        Me.rdbDateSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDateSale.Location = New System.Drawing.Point(54, 19)
        Me.rdbDateSale.Name = "rdbDateSale"
        Me.rdbDateSale.Size = New System.Drawing.Size(67, 18)
        Me.rdbDateSale.TabIndex = 600
        Me.rdbDateSale.TabStop = True
        Me.rdbDateSale.Text = "วันที่ขาย"
        Me.rdbDateSale.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtCountDt)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.txtCount)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(464, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(720, 35)
        Me.Panel3.TabIndex = 600
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(185, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 602
        Me.Label8.Text = "รายการ"
        '
        'txtCountDt
        '
        Me.txtCountDt.BackColor = System.Drawing.Color.Black
        Me.txtCountDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCountDt.ForeColor = System.Drawing.Color.Lime
        Me.txtCountDt.Location = New System.Drawing.Point(99, 6)
        Me.txtCountDt.Name = "txtCountDt"
        Me.txtCountDt.ReadOnly = True
        Me.txtCountDt.Size = New System.Drawing.Size(86, 24)
        Me.txtCountDt.TabIndex = 601
        Me.txtCountDt.Text = "0"
        Me.txtCountDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 600
        Me.Label9.Text = "รายการสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(415, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 599
        Me.Label3.Text = "รายการ"
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(558, 6)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(159, 24)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(321, 6)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(88, 24)
        Me.txtCount.TabIndex = 598
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(468, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "| รวมเป็นเงิน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(239, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 597
        Me.Label5.Text = "| จำนวนบิล"
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewImageColumn1.HeaderText = "เอกสาร"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 40
        '
        'DataGridViewImageColumn3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewImageColumn3.HeaderText = "ยกเลิกรายการ"
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.Visible = False
        Me.DataGridViewImageColumn3.Width = 50
        '
        'DataGridViewImageColumn2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewImageColumn2.HeaderText = "แก้ไข"
        Me.DataGridViewImageColumn2.Image = Global.SAM.My.Resources.Resources.Computer_Edit
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.Width = 70
        '
        'DataGridViewImageColumn4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewImageColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewImageColumn4.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn4.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.ReadOnly = True
        Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn4.Visible = False
        Me.DataGridViewImageColumn4.Width = 50
        '
        'DataGridViewImageColumn5
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewImageColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewImageColumn5.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn5.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.ReadOnly = True
        Me.DataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn5.Visible = False
        Me.DataGridViewImageColumn5.Width = 50
        '
        'DataGridViewImageColumn6
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewImageColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewImageColumn6.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn6.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        Me.DataGridViewImageColumn6.ReadOnly = True
        Me.DataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn6.Visible = False
        Me.DataGridViewImageColumn6.Width = 50
        '
        'DataGridViewImageColumn7
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewImageColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewImageColumn7.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn7.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.DataGridViewImageColumn7.Name = "DataGridViewImageColumn7"
        Me.DataGridViewImageColumn7.ReadOnly = True
        Me.DataGridViewImageColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn7.Visible = False
        Me.DataGridViewImageColumn7.Width = 50
        '
        'DataGridViewImageColumn8
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewImageColumn8.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewImageColumn8.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn8.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.DataGridViewImageColumn8.Name = "DataGridViewImageColumn8"
        Me.DataGridViewImageColumn8.ReadOnly = True
        Me.DataGridViewImageColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn8.Visible = False
        Me.DataGridViewImageColumn8.Width = 50
        '
        'RepositoryItemButtonEdit8
        '
        Me.RepositoryItemButtonEdit8.AutoHeight = False
        Me.RepositoryItemButtonEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit8.Name = "RepositoryItemButtonEdit8"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.Panel4)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 201)
        Me.PanelControl1.TabIndex = 722
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(739, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(338, 13)
        Me.Label7.TabIndex = 637
        Me.Label7.Text = "*** รายการไม่มีสี หมายถึง รายการขายจากการคีย์หน้าทำรายการขายสินค้า"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.pnPrint)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 35)
        Me.Panel1.TabIndex = 723
        '
        'pnPrint
        '
        Me.pnPrint.Controls.Add(Me.btnPrintMulti)
        Me.pnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnPrint.Location = New System.Drawing.Point(407, 0)
        Me.pnPrint.Name = "pnPrint"
        Me.pnPrint.Size = New System.Drawing.Size(170, 35)
        Me.pnPrint.TabIndex = 634
        Me.pnPrint.Visible = False
        '
        'btnPrintMulti
        '
        Me.btnPrintMulti.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintMulti.Appearance.Options.UseFont = True
        Me.btnPrintMulti.Image = CType(resources.GetObject("btnPrintMulti.Image"), System.Drawing.Image)
        Me.btnPrintMulti.Location = New System.Drawing.Point(4, 3)
        Me.btnPrintMulti.Name = "btnPrintMulti"
        Me.btnPrintMulti.Size = New System.Drawing.Size(161, 30)
        Me.btnPrintMulti.TabIndex = 632
        Me.btnPrintMulti.Text = "พิมพ์เอกสารการขาย"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnNew)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(253, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(154, 35)
        Me.Panel6.TabIndex = 633
        Me.Panel6.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(1, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(152, 30)
        Me.btnNew.TabIndex = 631
        Me.btnNew.Text = "ทำรายการขายสินค้า"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnApprove)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(99, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(154, 35)
        Me.Panel5.TabIndex = 632
        Me.Panel5.Visible = False
        '
        'btnApprove
        '
        Me.btnApprove.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Appearance.Options.UseFont = True
        Me.btnApprove.Image = CType(resources.GetObject("btnApprove.Image"), System.Drawing.Image)
        Me.btnApprove.Location = New System.Drawing.Point(1, 3)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(152, 30)
        Me.btnApprove.TabIndex = 631
        Me.btnApprove.Text = "อนุมัติรายการที่เลือก"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(99, 35)
        Me.Panel2.TabIndex = 588
        '
        'btnSFindAll
        '
        Me.btnSFindAll.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSFindAll.Appearance.Options.UseFont = True
        Me.btnSFindAll.Image = CType(resources.GetObject("btnSFindAll.Image"), System.Drawing.Image)
        Me.btnSFindAll.Location = New System.Drawing.Point(1, 3)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(97, 30)
        Me.btnSFindAll.TabIndex = 0
        Me.btnSFindAll.Text = "Refresh"
        '
        'frmSlSaleData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1184, 587)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlSaleData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลการขาย"
        CType(Me.GVSaleDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptInvName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptWH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptChkPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptAddTransport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptLineNoti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptAddPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCusName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.CCbEditDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.RepositoryItemButtonEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnPrint.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents ChkCus As System.Windows.Forms.CheckBox
    Friend WithEvents dtpSaleS As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn5 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn6 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn7 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents rdbMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDate As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDateSale As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDateTs As System.Windows.Forms.RadioButton
    Friend WithEvents rdbYear As System.Windows.Forms.RadioButton
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpSaleE As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkPsSale As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewImageColumn8 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMonthNow As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBack7 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpMonthE As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMonthS As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkDocCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtDocCode As System.Windows.Forms.TextBox
    Friend WithEvents ChkTsp As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTsp As System.Windows.Forms.ComboBox
    Friend WithEvents ChkStOrd As System.Windows.Forms.CheckBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtDocRef As System.Windows.Forms.TextBox
    Friend WithEvents ChkDocRef As System.Windows.Forms.CheckBox
    Friend WithEvents dtpMonthNow As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkCancel As System.Windows.Forms.CheckBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSaleDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVSaleMt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsCancel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCancelNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSale1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColChk1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEdit1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCheck1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColApprove1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatePay1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAp1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPv1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidCancel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDisCntAmt1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDisPer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRefAcc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsTs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateTs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTimeTs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsAccept1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateAccept1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsCheck1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateCheck1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsApp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateApp1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColstBillOrder1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColstBillType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPdCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColExp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCancelApv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptDoc As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemButtonEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptCancel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents CCbEditDoc As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ChkDoc As System.Windows.Forms.CheckBox
    Friend WithEvents ColidCus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDiscountBath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colidTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidPsSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidWh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkComp As System.Windows.Forms.CheckBox
    Friend WithEvents colidSend As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents txtPsSale As System.Windows.Forms.TextBox
    Friend WithEvents ColSendLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptLineNoti As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColCompName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCountDt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbSlAVxST As System.Windows.Forms.CheckBox
    Friend WithEvents colidSlAVxST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddTransport As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptAddTransport As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColPsApp2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateApp2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaleCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidPartner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintMul As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptChkPrint As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colDocCode_PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAddPic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptAddPic As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColWareHouseName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSFindAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintMulti As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColStatusDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbDraft As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ColOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPONo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptInvName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rptWH As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rptCusName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents pnPrint As Panel
    Friend WithEvents ColNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
