<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaleSHSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSaleSHSelect))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptSel = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSelAll = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSFindAll = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbSeason = New System.Windows.Forms.ComboBox()
        Me.cbSeason = New System.Windows.Forms.CheckBox()
        Me.cbDateSale = New System.Windows.Forms.CheckBox()
        Me.txtZoneName = New System.Windows.Forms.TextBox()
        Me.dtpSaleS = New System.Windows.Forms.DateTimePicker()
        Me.cbZone = New System.Windows.Forms.CheckBox()
        Me.GCSaleSH = New DevExpress.XtraGrid.GridControl()
        Me.GVSaleSH = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalNet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColZoneName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSeasonCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSeasonPd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidPartner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVSaleDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSaleMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDiscountBath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColExp = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GCSaleSH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleSH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptSel
        '
        Me.rptSel.AutoHeight = False
        Me.rptSel.Name = "rptSel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.cbSelAll)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 31)
        Me.Panel1.TabIndex = 726
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCount)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(390, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(153, 31)
        Me.Panel8.TabIndex = 975
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(43, 4)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(60, 23)
        Me.txtCount.TabIndex = 610
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(104, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "รายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(2, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 14)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "จำนวน"
        '
        'cbSelAll
        '
        Me.cbSelAll.AutoSize = True
        Me.cbSelAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbSelAll.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbSelAll.Location = New System.Drawing.Point(192, 7)
        Me.cbSelAll.Name = "cbSelAll"
        Me.cbSelAll.Size = New System.Drawing.Size(135, 18)
        Me.cbSelAll.TabIndex = 974
        Me.cbSelAll.Text = "เลือกรายการทั้งหมด"
        Me.cbSelAll.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(189, 31)
        Me.Panel2.TabIndex = 588
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(3, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(99, 27)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        '
        'btnSFindAll
        '
        Me.btnSFindAll.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSFindAll.Appearance.Options.UseFont = True
        Me.btnSFindAll.Image = CType(resources.GetObject("btnSFindAll.Image"), System.Drawing.Image)
        Me.btnSFindAll.Location = New System.Drawing.Point(105, 2)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(81, 27)
        Me.btnSFindAll.TabIndex = 0
        Me.btnSFindAll.Text = "เลือก"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(543, 83)
        Me.PanelControl1.TabIndex = 727
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmbSeason)
        Me.GroupBox4.Controls.Add(Me.cbSeason)
        Me.GroupBox4.Controls.Add(Me.cbDateSale)
        Me.GroupBox4.Controls.Add(Me.txtZoneName)
        Me.GroupBox4.Controls.Add(Me.dtpSaleS)
        Me.GroupBox4.Controls.Add(Me.cbZone)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(528, 74)
        Me.GroupBox4.TabIndex = 609
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ค้นหาข้อมูล"
        '
        'cmbSeason
        '
        Me.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeason.Enabled = False
        Me.cmbSeason.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.Location = New System.Drawing.Point(111, 46)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(147, 22)
        Me.cmbSeason.TabIndex = 973
        '
        'cbSeason
        '
        Me.cbSeason.AutoSize = True
        Me.cbSeason.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbSeason.Location = New System.Drawing.Point(28, 48)
        Me.cbSeason.Name = "cbSeason"
        Me.cbSeason.Size = New System.Drawing.Size(61, 18)
        Me.cbSeason.TabIndex = 972
        Me.cbSeason.Text = "ฤดูผลิต"
        Me.cbSeason.UseVisualStyleBackColor = True
        '
        'cbDateSale
        '
        Me.cbDateSale.AutoSize = True
        Me.cbDateSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbDateSale.Location = New System.Drawing.Point(28, 22)
        Me.cbDateSale.Name = "cbDateSale"
        Me.cbDateSale.Size = New System.Drawing.Size(83, 18)
        Me.cbDateSale.TabIndex = 971
        Me.cbDateSale.Text = "วันที่แจ้งหนี้"
        Me.cbDateSale.UseVisualStyleBackColor = True
        '
        'txtZoneName
        '
        Me.txtZoneName.Enabled = False
        Me.txtZoneName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtZoneName.Location = New System.Drawing.Point(352, 20)
        Me.txtZoneName.Name = "txtZoneName"
        Me.txtZoneName.Size = New System.Drawing.Size(144, 22)
        Me.txtZoneName.TabIndex = 966
        '
        'dtpSaleS
        '
        Me.dtpSaleS.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleS.Enabled = False
        Me.dtpSaleS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleS.Location = New System.Drawing.Point(111, 20)
        Me.dtpSaleS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleS.Name = "dtpSaleS"
        Me.dtpSaleS.Size = New System.Drawing.Size(147, 22)
        Me.dtpSaleS.TabIndex = 968
        '
        'cbZone
        '
        Me.cbZone.AutoSize = True
        Me.cbZone.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbZone.Location = New System.Drawing.Point(279, 22)
        Me.cbZone.Name = "cbZone"
        Me.cbZone.Size = New System.Drawing.Size(65, 18)
        Me.cbZone.TabIndex = 965
        Me.cbZone.Text = "เขตผลิต"
        Me.cbZone.UseVisualStyleBackColor = True
        '
        'GCSaleSH
        '
        Me.GCSaleSH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSaleSH.Location = New System.Drawing.Point(0, 114)
        Me.GCSaleSH.MainView = Me.GVSaleSH
        Me.GCSaleSH.Name = "GCSaleSH"
        Me.GCSaleSH.Size = New System.Drawing.Size(543, 442)
        Me.GCSaleSH.TabIndex = 728
        Me.GCSaleSH.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSaleSH, Me.GVSaleDt})
        '
        'GVSaleSH
        '
        Me.GVSaleSH.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.Empty.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSaleSH.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSaleSH.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleSH.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVSaleSH.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVSaleSH.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSaleSH.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSaleSH.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSaleSH.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVSaleSH.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleSH.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleSH.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSaleSH.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSaleSH.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSaleSH.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSaleSH.Appearance.Preview.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.Preview.Options.UseFont = True
        Me.GVSaleSH.Appearance.Preview.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.Row.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.Row.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSaleSH.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSaleSH.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleSH.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSaleSH.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSaleSH.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSaleSH.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSaleSH.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSaleSH.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSaleSH.ColumnPanelRowHeight = 35
        Me.GVSaleSH.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSale, Me.ColSel, Me.ColDocRef, Me.ColDateSale, Me.ColCusName, Me.ColTotalNet, Me.ColZoneName, Me.ColSeasonCode, Me.ColidSeasonPd, Me.ColidPartner})
        Me.GVSaleSH.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule1.Name = "stWaitCut"
        FormatConditionRuleExpression1.Expression = "[stWaitCut] = 'Draft'"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GVSaleSH.FormatRules.Add(GridFormatRule1)
        Me.GVSaleSH.GridControl = Me.GCSaleSH
        Me.GVSaleSH.GroupCount = 1
        Me.GVSaleSH.Name = "GVSaleSH"
        Me.GVSaleSH.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleSH.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleSH.OptionsView.RowAutoHeight = True
        Me.GVSaleSH.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSaleSH.OptionsView.ShowGroupPanel = False
        Me.GVSaleSH.OptionsView.ShowIndicator = False
        Me.GVSaleSH.RowHeight = 25
        Me.GVSaleSH.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColZoneName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColidSale
        '
        Me.ColidSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSale.AppearanceCell.Options.UseFont = True
        Me.ColidSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSale.AppearanceHeader.Options.UseFont = True
        Me.ColidSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidSale.Caption = "idSale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        '
        'ColSel
        '
        Me.ColSel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColSel.AppearanceCell.Options.UseBackColor = True
        Me.ColSel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColSel.AppearanceHeader.Options.UseFont = True
        Me.ColSel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSel.Caption = "เลือก"
        Me.ColSel.ColumnEdit = Me.rptSel
        Me.ColSel.FieldName = "Chk"
        Me.ColSel.MaxWidth = 40
        Me.ColSel.MinWidth = 40
        Me.ColSel.Name = "ColSel"
        Me.ColSel.Visible = True
        Me.ColSel.VisibleIndex = 0
        Me.ColSel.Width = 61
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocRef.Caption = "เลขที่ใบแจ้งหนี้"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 1
        Me.ColDocRef.Width = 330
        '
        'ColDateSale
        '
        Me.ColDateSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateSale.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale.AppearanceCell.Options.UseFont = True
        Me.ColDateSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateSale.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.Caption = "วันที่แจ้งหนี้"
        Me.ColDateSale.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateSale.FieldName = "DateSaleD"
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.OptionsColumn.AllowEdit = False
        Me.ColDateSale.OptionsColumn.ReadOnly = True
        Me.ColDateSale.Visible = True
        Me.ColDateSale.VisibleIndex = 2
        Me.ColDateSale.Width = 267
        '
        'ColCusName
        '
        Me.ColCusName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColCusName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCusName.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName.AppearanceCell.Options.UseFont = True
        Me.ColCusName.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCusName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCusName.AppearanceHeader.Options.UseFont = True
        Me.ColCusName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCusName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusName.Caption = "รายละเอียด"
        Me.ColCusName.CustomizationCaption = " "
        Me.ColCusName.FieldName = "PartnerNameBill"
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.OptionsColumn.AllowEdit = False
        Me.ColCusName.OptionsColumn.ReadOnly = True
        Me.ColCusName.Visible = True
        Me.ColCusName.VisibleIndex = 3
        Me.ColCusName.Width = 576
        '
        'ColTotalNet
        '
        Me.ColTotalNet.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTotalNet.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotalNet.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalNet.AppearanceCell.Options.UseFont = True
        Me.ColTotalNet.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalNet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotalNet.AppearanceHeader.Options.UseFont = True
        Me.ColTotalNet.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalNet.Caption = "จำนวนเงิน"
        Me.ColTotalNet.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColTotalNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalNet.FieldName = "TotalNet"
        Me.ColTotalNet.Name = "ColTotalNet"
        Me.ColTotalNet.OptionsColumn.AllowEdit = False
        Me.ColTotalNet.OptionsColumn.ReadOnly = True
        Me.ColTotalNet.Visible = True
        Me.ColTotalNet.VisibleIndex = 4
        Me.ColTotalNet.Width = 400
        '
        'ColZoneName
        '
        Me.ColZoneName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColZoneName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColZoneName.AppearanceCell.Options.UseBackColor = True
        Me.ColZoneName.AppearanceCell.Options.UseFont = True
        Me.ColZoneName.AppearanceCell.Options.UseTextOptions = True
        Me.ColZoneName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColZoneName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColZoneName.AppearanceHeader.Options.UseFont = True
        Me.ColZoneName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColZoneName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColZoneName.Caption = "เขตผลิต"
        Me.ColZoneName.FieldName = "ZoneName"
        Me.ColZoneName.Name = "ColZoneName"
        Me.ColZoneName.OptionsColumn.AllowEdit = False
        Me.ColZoneName.OptionsColumn.ReadOnly = True
        Me.ColZoneName.Visible = True
        Me.ColZoneName.VisibleIndex = 5
        '
        'ColSeasonCode
        '
        Me.ColSeasonCode.Caption = "ฤดูผลิต"
        Me.ColSeasonCode.FieldName = "SeasonCode"
        Me.ColSeasonCode.Name = "ColSeasonCode"
        '
        'ColidSeasonPd
        '
        Me.ColidSeasonPd.Caption = "idSeasonPd"
        Me.ColidSeasonPd.FieldName = "idSeasonPd"
        Me.ColidSeasonPd.Name = "ColidSeasonPd"
        '
        'ColidPartner
        '
        Me.ColidPartner.Caption = "idPartner"
        Me.ColidPartner.FieldName = "idPartner"
        Me.ColidPartner.Name = "ColidPartner"
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
        Me.GVSaleDt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
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
        Me.GVSaleDt.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVSaleDt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
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
        Me.GVSaleDt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
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
        Me.GVSaleDt.ColumnPanelRowHeight = 25
        Me.GVSaleDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSaleMt, Me.ColProductName, Me.ColAmount, Me.ColUnit, Me.ColDiscount, Me.ColDiscountBath, Me.ColPrice, Me.ColExp})
        Me.GVSaleDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSaleDt.GridControl = Me.GCSaleSH
        Me.GVSaleDt.Name = "GVSaleDt"
        Me.GVSaleDt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleDt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleDt.OptionsView.ShowGroupPanel = False
        Me.GVSaleDt.OptionsView.ShowIndicator = False
        Me.GVSaleDt.PaintStyleName = "MixedXP"
        Me.GVSaleDt.RowHeight = 25
        '
        'ColidSaleMt
        '
        Me.ColidSaleMt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSaleMt.AppearanceCell.Options.UseFont = True
        Me.ColidSaleMt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSaleMt.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleMt.Caption = "idSaleDt"
        Me.ColidSaleMt.FieldName = "idSale"
        Me.ColidSaleMt.Name = "ColidSaleMt"
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการ"
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 0
        Me.ColProductName.Width = 544
        '
        'ColAmount
        '
        Me.ColAmount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColAmount.VisibleIndex = 1
        Me.ColAmount.Width = 106
        '
        'ColUnit
        '
        Me.ColUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColUnit.VisibleIndex = 2
        Me.ColUnit.Width = 106
        '
        'ColDiscount
        '
        Me.ColDiscount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColDiscount.VisibleIndex = 3
        Me.ColDiscount.Width = 131
        '
        'ColDiscountBath
        '
        Me.ColDiscountBath.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColDiscountBath.VisibleIndex = 4
        Me.ColDiscountBath.Width = 124
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColPrice.VisibleIndex = 5
        Me.ColPrice.Width = 95
        '
        'ColExp
        '
        Me.ColExp.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColExp.VisibleIndex = 6
        Me.ColExp.Width = 127
        '
        'FrmSaleSHSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(543, 556)
        Me.Controls.Add(Me.GCSaleSH)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSaleSHSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกใบแจ้งหนี้สินค้าโสหุ้ย"
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GCSaleSH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleSH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSFindAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtZoneName As TextBox
    Friend WithEvents dtpSaleS As DateTimePicker
    Friend WithEvents GCSaleSH As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSaleSH As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVSaleDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSaleMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDiscountBath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColExp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptSel As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColZoneName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbDateSale As CheckBox
    Friend WithEvents cbZone As CheckBox
    Friend WithEvents cbSeason As CheckBox
    Friend WithEvents cmbSeason As ComboBox
    Friend WithEvents ColSeasonCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSeasonPd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbSelAll As CheckBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ColidPartner As DevExpress.XtraGrid.Columns.GridColumn
End Class
