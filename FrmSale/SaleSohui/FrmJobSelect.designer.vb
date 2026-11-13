<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJobSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJobSelect))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression3 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSeed = New System.Windows.Forms.TextBox()
        Me.chkSeed = New System.Windows.Forms.CheckBox()
        Me.txtFarmerName = New System.Windows.Forms.TextBox()
        Me.chkFarmerName = New System.Windows.Forms.CheckBox()
        Me.txtJobNo = New System.Windows.Forms.TextBox()
        Me.chkJobNo = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtStrainCode = New System.Windows.Forms.TextBox()
        Me.ChkStrainCode = New System.Windows.Forms.CheckBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GCJob = New DevExpress.XtraGrid.GridControl()
        Me.GVJob = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColJobNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColStrainCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSeed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPartnerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColZone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecSeedsKg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCancelNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoteCancelProduce = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUserCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstWeightUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptMultiSel = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colidPartner = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.GCJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptMultiSel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(742, 96)
        Me.PanelControl1.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtSeed)
        Me.GroupBox3.Controls.Add(Me.chkSeed)
        Me.GroupBox3.Controls.Add(Me.txtFarmerName)
        Me.GroupBox3.Controls.Add(Me.chkFarmerName)
        Me.GroupBox3.Controls.Add(Me.txtJobNo)
        Me.GroupBox3.Controls.Add(Me.chkJobNo)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.txtStrainCode)
        Me.GroupBox3.Controls.Add(Me.ChkStrainCode)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(736, 90)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'txtSeed
        '
        Me.txtSeed.Enabled = False
        Me.txtSeed.Location = New System.Drawing.Point(83, 64)
        Me.txtSeed.Name = "txtSeed"
        Me.txtSeed.Size = New System.Drawing.Size(149, 20)
        Me.txtSeed.TabIndex = 987
        '
        'chkSeed
        '
        Me.chkSeed.AutoSize = True
        Me.chkSeed.Location = New System.Drawing.Point(14, 66)
        Me.chkSeed.Name = "chkSeed"
        Me.chkSeed.Size = New System.Drawing.Size(41, 17)
        Me.chkSeed.TabIndex = 986
        Me.chkSeed.Text = "พืช"
        Me.chkSeed.UseVisualStyleBackColor = True
        '
        'txtFarmerName
        '
        Me.txtFarmerName.Enabled = False
        Me.txtFarmerName.Location = New System.Drawing.Point(353, 11)
        Me.txtFarmerName.Name = "txtFarmerName"
        Me.txtFarmerName.Size = New System.Drawing.Size(149, 20)
        Me.txtFarmerName.TabIndex = 985
        '
        'chkFarmerName
        '
        Me.chkFarmerName.AutoSize = True
        Me.chkFarmerName.Location = New System.Drawing.Point(262, 12)
        Me.chkFarmerName.Name = "chkFarmerName"
        Me.chkFarmerName.Size = New System.Drawing.Size(85, 17)
        Me.chkFarmerName.TabIndex = 984
        Me.chkFarmerName.Text = "ชื่อเกษตรกร"
        Me.chkFarmerName.UseVisualStyleBackColor = True
        '
        'txtJobNo
        '
        Me.txtJobNo.Enabled = False
        Me.txtJobNo.Location = New System.Drawing.Point(83, 11)
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.Size = New System.Drawing.Size(149, 20)
        Me.txtJobNo.TabIndex = 983
        '
        'chkJobNo
        '
        Me.chkJobNo.AutoSize = True
        Me.chkJobNo.Location = New System.Drawing.Point(14, 12)
        Me.chkJobNo.Name = "chkJobNo"
        Me.chkJobNo.Size = New System.Drawing.Size(63, 17)
        Me.chkJobNo.TabIndex = 982
        Me.chkJobNo.Text = "Job No."
        Me.chkJobNo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(652, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 981
        Me.Label3.Text = "ปิด Job"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lime
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(625, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(24, 18)
        Me.Panel2.TabIndex = 980
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(652, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 979
        Me.Label2.Text = "การผลิตล้มเหลว"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(625, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 18)
        Me.Panel1.TabIndex = 978
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(652, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 977
        Me.Label6.Text = "ยกเลิกรายการ"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Salmon
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(625, 11)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(24, 18)
        Me.Panel4.TabIndex = 976
        '
        'txtStrainCode
        '
        Me.txtStrainCode.Enabled = False
        Me.txtStrainCode.Location = New System.Drawing.Point(83, 38)
        Me.txtStrainCode.Name = "txtStrainCode"
        Me.txtStrainCode.Size = New System.Drawing.Size(149, 20)
        Me.txtStrainCode.TabIndex = 975
        '
        'ChkStrainCode
        '
        Me.ChkStrainCode.AutoSize = True
        Me.ChkStrainCode.Location = New System.Drawing.Point(14, 39)
        Me.ChkStrainCode.Name = "ChkStrainCode"
        Me.ChkStrainCode.Size = New System.Drawing.Size(65, 17)
        Me.ChkStrainCode.TabIndex = 974
        Me.ChkStrainCode.Text = "รหัสผลิต"
        Me.ChkStrainCode.UseVisualStyleBackColor = True
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btnSelect)
        Me.PanelControl3.Controls.Add(Me.Panel8)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 96)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(742, 33)
        Me.PanelControl3.TabIndex = 8
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.DimGray
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Location = New System.Drawing.Point(0, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 33)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Tag = "Add"
        Me.btnSelect.Text = "Refresh"
        Me.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCount)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(586, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(156, 33)
        Me.Panel8.TabIndex = 612
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "รายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-1, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "จำนวน"
        '
        'GCJob
        '
        Me.GCJob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCJob.Location = New System.Drawing.Point(0, 129)
        Me.GCJob.MainView = Me.GVJob
        Me.GCJob.Name = "GCJob"
        Me.GCJob.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSelect, Me.rptMultiSel})
        Me.GCJob.Size = New System.Drawing.Size(742, 513)
        Me.GCJob.TabIndex = 9
        Me.GCJob.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVJob})
        '
        'GVJob
        '
        Me.GVJob.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVJob.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVJob.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVJob.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVJob.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVJob.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVJob.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVJob.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVJob.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVJob.Appearance.Empty.Options.UseBackColor = True
        Me.GVJob.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVJob.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVJob.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVJob.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVJob.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVJob.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVJob.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVJob.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVJob.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVJob.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVJob.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVJob.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVJob.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVJob.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVJob.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVJob.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVJob.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVJob.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVJob.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVJob.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVJob.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVJob.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVJob.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVJob.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVJob.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVJob.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVJob.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVJob.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVJob.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVJob.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVJob.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVJob.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVJob.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVJob.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVJob.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVJob.Appearance.GroupRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GVJob.Appearance.GroupRow.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.GVJob.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GVJob.Appearance.GroupRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVJob.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVJob.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVJob.Appearance.GroupRow.Options.UseFont = True
        Me.GVJob.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVJob.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVJob.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVJob.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVJob.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVJob.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVJob.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVJob.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVJob.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVJob.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVJob.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVJob.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVJob.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVJob.Appearance.OddRow.Options.UseBackColor = True
        Me.GVJob.Appearance.OddRow.Options.UseForeColor = True
        Me.GVJob.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVJob.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVJob.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVJob.Appearance.Preview.Options.UseBackColor = True
        Me.GVJob.Appearance.Preview.Options.UseFont = True
        Me.GVJob.Appearance.Preview.Options.UseForeColor = True
        Me.GVJob.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVJob.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVJob.Appearance.Row.Options.UseBackColor = True
        Me.GVJob.Appearance.Row.Options.UseForeColor = True
        Me.GVJob.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVJob.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVJob.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVJob.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVJob.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVJob.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVJob.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVJob.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVJob.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVJob.Appearance.VertLine.Options.UseBackColor = True
        Me.GVJob.ColumnPanelRowHeight = 35
        Me.GVJob.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSelect, Me.ColJobNo, Me.ColStrainCode, Me.ColSeed, Me.ColPartnerName, Me.ColZone, Me.colRecSeedsKg, Me.ColPs, Me.colCancelNote, Me.colNoteCancelProduce, Me.colidUserCancel, Me.colstCancel, Me.colPsCancel, Me.colstWeightUpdate, Me.colidJob, Me.colidPartner})
        Me.GVJob.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Name = "FMstCancel"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Salmon
        FormatConditionRuleExpression1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Strikeout)
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Appearance.Options.UseFont = True
        FormatConditionRuleExpression1.Expression = "[stCancel] = 1"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Name = "FMpdCancel"
        FormatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.Yellow
        FormatConditionRuleExpression2.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression2.Expression = "Not IsNullOrEmpty([NoteCancelProduce])"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Name = "FMCloseJob"
        FormatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.Lime
        FormatConditionRuleExpression3.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression3.Expression = "[stWeightUpdate] = 1"
        GridFormatRule3.Rule = FormatConditionRuleExpression3
        Me.GVJob.FormatRules.Add(GridFormatRule1)
        Me.GVJob.FormatRules.Add(GridFormatRule2)
        Me.GVJob.FormatRules.Add(GridFormatRule3)
        Me.GVJob.GridControl = Me.GCJob
        Me.GVJob.GroupFormat = " [#image]{1} {2}"
        Me.GVJob.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", Nothing, "(คงเหลือ {0:#,##0.####})")})
        Me.GVJob.Name = "GVJob"
        Me.GVJob.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVJob.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVJob.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVJob.OptionsView.EnableAppearanceEvenRow = True
        Me.GVJob.OptionsView.EnableAppearanceOddRow = True
        Me.GVJob.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVJob.OptionsView.ShowGroupPanel = False
        Me.GVJob.OptionsView.ShowIndicator = False
        Me.GVJob.PaintStyleName = "MixedXP"
        Me.GVJob.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'ColSelect
        '
        Me.ColSelect.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColSelect.AppearanceHeader.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.rptSelect
        Me.ColSelect.MaxWidth = 45
        Me.ColSelect.MinWidth = 45
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Visible = True
        Me.ColSelect.VisibleIndex = 0
        Me.ColSelect.Width = 45
        '
        'rptSelect
        '
        Me.rptSelect.AutoHeight = False
        Me.rptSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptSelect.Name = "rptSelect"
        Me.rptSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColJobNo
        '
        Me.ColJobNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColJobNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColJobNo.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColJobNo.AppearanceHeader.Options.UseFont = True
        Me.ColJobNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColJobNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColJobNo.Caption = "Job No."
        Me.ColJobNo.FieldName = "JobNo"
        Me.ColJobNo.Name = "ColJobNo"
        Me.ColJobNo.OptionsColumn.AllowEdit = False
        Me.ColJobNo.OptionsColumn.ReadOnly = True
        Me.ColJobNo.Visible = True
        Me.ColJobNo.VisibleIndex = 1
        Me.ColJobNo.Width = 151
        '
        'ColStrainCode
        '
        Me.ColStrainCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColStrainCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColStrainCode.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColStrainCode.AppearanceHeader.Options.UseFont = True
        Me.ColStrainCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColStrainCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColStrainCode.Caption = "รหัสผลิต"
        Me.ColStrainCode.FieldName = "StrainCode"
        Me.ColStrainCode.Name = "ColStrainCode"
        Me.ColStrainCode.OptionsColumn.AllowEdit = False
        Me.ColStrainCode.OptionsColumn.ReadOnly = True
        Me.ColStrainCode.Visible = True
        Me.ColStrainCode.VisibleIndex = 2
        Me.ColStrainCode.Width = 144
        '
        'ColSeed
        '
        Me.ColSeed.AppearanceCell.Options.UseTextOptions = True
        Me.ColSeed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSeed.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColSeed.AppearanceHeader.Options.UseFont = True
        Me.ColSeed.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSeed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSeed.Caption = "พืช"
        Me.ColSeed.FieldName = "SeedTypeName"
        Me.ColSeed.Name = "ColSeed"
        Me.ColSeed.OptionsColumn.AllowEdit = False
        Me.ColSeed.OptionsColumn.ReadOnly = True
        Me.ColSeed.Visible = True
        Me.ColSeed.VisibleIndex = 3
        Me.ColSeed.Width = 165
        '
        'ColPartnerName
        '
        Me.ColPartnerName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColPartnerName.AppearanceHeader.Options.UseFont = True
        Me.ColPartnerName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPartnerName.Caption = "ชื่อเกษตรกร"
        Me.ColPartnerName.FieldName = "PartnerName"
        Me.ColPartnerName.Name = "ColPartnerName"
        Me.ColPartnerName.OptionsColumn.AllowEdit = False
        Me.ColPartnerName.OptionsColumn.ReadOnly = True
        Me.ColPartnerName.Visible = True
        Me.ColPartnerName.VisibleIndex = 4
        Me.ColPartnerName.Width = 283
        '
        'ColZone
        '
        Me.ColZone.AppearanceCell.Options.UseTextOptions = True
        Me.ColZone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColZone.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColZone.AppearanceHeader.Options.UseFont = True
        Me.ColZone.AppearanceHeader.Options.UseTextOptions = True
        Me.ColZone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColZone.Caption = "พื่นที่"
        Me.ColZone.FieldName = "ZoneName"
        Me.ColZone.Name = "ColZone"
        Me.ColZone.OptionsColumn.AllowEdit = False
        Me.ColZone.OptionsColumn.ReadOnly = True
        Me.ColZone.Visible = True
        Me.ColZone.VisibleIndex = 5
        Me.ColZone.Width = 178
        '
        'colRecSeedsKg
        '
        Me.colRecSeedsKg.AppearanceCell.Options.UseTextOptions = True
        Me.colRecSeedsKg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRecSeedsKg.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRecSeedsKg.AppearanceHeader.Options.UseFont = True
        Me.colRecSeedsKg.AppearanceHeader.Options.UseTextOptions = True
        Me.colRecSeedsKg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRecSeedsKg.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRecSeedsKg.Caption = "น้ำหนักรับเข้า"
        Me.colRecSeedsKg.FieldName = "RecSeedsKg"
        Me.colRecSeedsKg.Name = "colRecSeedsKg"
        Me.colRecSeedsKg.Visible = True
        Me.colRecSeedsKg.VisibleIndex = 6
        Me.colRecSeedsKg.Width = 142
        '
        'ColPs
        '
        Me.ColPs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColPs.AppearanceHeader.Options.UseFont = True
        Me.ColPs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPs.Caption = "เจ้าหน้าที่ส่งเสริม"
        Me.ColPs.FieldName = "PsMete"
        Me.ColPs.Name = "ColPs"
        Me.ColPs.OptionsColumn.AllowEdit = False
        Me.ColPs.OptionsColumn.ReadOnly = True
        Me.ColPs.Visible = True
        Me.ColPs.VisibleIndex = 7
        Me.ColPs.Width = 220
        '
        'colCancelNote
        '
        Me.colCancelNote.Caption = "CancelNote"
        Me.colCancelNote.FieldName = "Note ยกเลิกรายการ"
        Me.colCancelNote.Name = "colCancelNote"
        '
        'colNoteCancelProduce
        '
        Me.colNoteCancelProduce.Caption = "Note ยกเลิกการผลิต"
        Me.colNoteCancelProduce.FieldName = "NoteCancelProduce"
        Me.colNoteCancelProduce.Name = "colNoteCancelProduce"
        '
        'colidUserCancel
        '
        Me.colidUserCancel.Caption = "idUserCancel"
        Me.colidUserCancel.FieldName = "idUserCancel"
        Me.colidUserCancel.Name = "colidUserCancel"
        '
        'colstCancel
        '
        Me.colstCancel.Caption = "stCancel"
        Me.colstCancel.FieldName = "stCancel"
        Me.colstCancel.Name = "colstCancel"
        '
        'colPsCancel
        '
        Me.colPsCancel.Caption = "PsCancel"
        Me.colPsCancel.FieldName = "PsCancel"
        Me.colPsCancel.Name = "colPsCancel"
        '
        'colstWeightUpdate
        '
        Me.colstWeightUpdate.Caption = "stWeightUpdate"
        Me.colstWeightUpdate.FieldName = "stWeightUpdate"
        Me.colstWeightUpdate.Name = "colstWeightUpdate"
        '
        'colidJob
        '
        Me.colidJob.Caption = "idJob"
        Me.colidJob.FieldName = "idJob"
        Me.colidJob.Name = "colidJob"
        '
        'rptMultiSel
        '
        Me.rptMultiSel.AutoHeight = False
        Me.rptMultiSel.Name = "rptMultiSel"
        '
        'colidPartner
        '
        Me.colidPartner.Caption = "idPartner"
        Me.colidPartner.FieldName = "idPartner"
        Me.colidPartner.Name = "colidPartner"
        '
        'FrmJobSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 642)
        Me.Controls.Add(Me.GCJob)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmJobSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือก Job"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.GCJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptMultiSel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GCJob As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVJob As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColJobNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColStrainCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSeed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPartnerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColZone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptMultiSel As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtStrainCode As System.Windows.Forms.TextBox
    Friend WithEvents ChkStrainCode As System.Windows.Forms.CheckBox
    Friend WithEvents colCancelNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoteCancelProduce As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidUserCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtJobNo As System.Windows.Forms.TextBox
    Friend WithEvents chkJobNo As System.Windows.Forms.CheckBox
    Friend WithEvents txtFarmerName As System.Windows.Forms.TextBox
    Friend WithEvents chkFarmerName As System.Windows.Forms.CheckBox
    Friend WithEvents txtSeed As System.Windows.Forms.TextBox
    Friend WithEvents chkSeed As System.Windows.Forms.CheckBox
    Friend WithEvents colRecSeedsKg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstWeightUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidPartner As DevExpress.XtraGrid.Columns.GridColumn
End Class
