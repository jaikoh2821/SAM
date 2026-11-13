<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlSaleSummaryLine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlSaleSummaryLine))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnShow = New System.Windows.Forms.Button
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.dtpYear = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmbplant = New System.Windows.Forms.ComboBox
        Me.ChkPd = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbPdPk = New System.Windows.Forms.ComboBox
        Me.cmbPdT = New System.Windows.Forms.ComboBox
        Me.ChkPdPk = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.ColSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colidP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColSumThisY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnShowS = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdbPdnameO = New System.Windows.Forms.RadioButton
        Me.rdbTotalNet = New System.Windows.Forms.RadioButton
        Me.dtpThisYearS = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdbPlant = New System.Windows.Forms.RadioButton
        Me.rdbPdPk = New System.Windows.Forms.RadioButton
        Me.rdbPdT = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 562)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Lavender
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 536)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "สรุปยอดขายแต่ละเดือนตามพืช / สินค้า / สินค้าแบบ Package"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnShow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 38)
        Me.Panel1.TabIndex = 665
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.DimGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(115, 36)
        Me.btnShow.TabIndex = 580
        Me.btnShow.Tag = ""
        Me.btnShow.Text = "       แสดงข้อมูล"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea1.AxisX.Interval = 1
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Interval = 1
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MajorGrid.IntervalOffset = 0
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX.MajorTickMark.Enabled = False
        ChartArea1.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1
        ChartArea1.AxisX.Title = "เดือน"
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY.Title = "ยอดขาบ (บาท)"
        ChartArea1.BackColor = System.Drawing.Color.Black
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.BorderWidth = 2
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.Title = "ยอดขายของปี"
        Legend1.TitleAlignment = System.Drawing.StringAlignment.Far
        Legend1.TitleBackColor = System.Drawing.Color.Transparent
        Legend1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 107)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.LabelFormat = "C"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(970, 426)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        Me.Chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        Title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Title1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "รายงานเปรียบเทียบยอดขาย"
        Title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart1.Titles.Add(Title1)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lavender
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dtpYear)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(970, 66)
        Me.Panel3.TabIndex = 664
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(91, 20)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(75, 24)
        Me.dtpYear.TabIndex = 646
        Me.dtpYear.Value = New Date(2015, 1, 30, 13, 51, 28, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmbplant)
        Me.GroupBox1.Controls.Add(Me.ChkPd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbPdPk)
        Me.GroupBox1.Controls.Add(Me.cmbPdT)
        Me.GroupBox1.Controls.Add(Me.ChkPdPk)
        Me.GroupBox1.Location = New System.Drawing.Point(184, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 54)
        Me.GroupBox1.TabIndex = 643
        Me.GroupBox1.TabStop = False
        '
        'Cmbplant
        '
        Me.Cmbplant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbplant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbplant.FormattingEnabled = True
        Me.Cmbplant.Location = New System.Drawing.Point(58, -2)
        Me.Cmbplant.Name = "Cmbplant"
        Me.Cmbplant.Size = New System.Drawing.Size(113, 21)
        Me.Cmbplant.TabIndex = 648
        '
        'ChkPd
        '
        Me.ChkPd.AutoSize = True
        Me.ChkPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkPd.ForeColor = System.Drawing.Color.Black
        Me.ChkPd.Location = New System.Drawing.Point(27, 27)
        Me.ChkPd.Name = "ChkPd"
        Me.ChkPd.Size = New System.Drawing.Size(52, 17)
        Me.ChkPd.TabIndex = 647
        Me.ChkPd.Text = "สินค้า"
        Me.ChkPd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 646
        Me.Label2.Text = "เลือกพืช"
        '
        'cmbPdPk
        '
        Me.cmbPdPk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPdPk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPdPk.Enabled = False
        Me.cmbPdPk.FormattingEnabled = True
        Me.cmbPdPk.Location = New System.Drawing.Point(464, 25)
        Me.cmbPdPk.Name = "cmbPdPk"
        Me.cmbPdPk.Size = New System.Drawing.Size(291, 21)
        Me.cmbPdPk.TabIndex = 632
        '
        'cmbPdT
        '
        Me.cmbPdT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPdT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPdT.Enabled = False
        Me.cmbPdT.FormattingEnabled = True
        Me.cmbPdT.Location = New System.Drawing.Point(83, 25)
        Me.cmbPdT.Name = "cmbPdT"
        Me.cmbPdT.Size = New System.Drawing.Size(247, 21)
        Me.cmbPdT.TabIndex = 644
        '
        'ChkPdPk
        '
        Me.ChkPdPk.AutoSize = True
        Me.ChkPdPk.Enabled = False
        Me.ChkPdPk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkPdPk.ForeColor = System.Drawing.Color.Black
        Me.ChkPdPk.Location = New System.Drawing.Point(338, 29)
        Me.ChkPdPk.Name = "ChkPdPk"
        Me.ChkPdPk.Size = New System.Drawing.Size(120, 17)
        Me.ChkPdPk.TabIndex = 628
        Me.ChkPdPk.Text = "สินค้าแบบ Package"
        Me.ChkPdPk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 645
        Me.Label1.Text = "ประจำปี"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(976, 536)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "สรุปยอดขายแต่ละพืช / สินค้า / สินค้าแบบ Package"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColSelect, Me.colidP, Me.colPName, Me.ColSumThisY})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.Location = New System.Drawing.Point(0, 0)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(298, 426)
        Me.dgvData.TabIndex = 670
        '
        'ColSelect
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = False
        Me.ColSelect.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColSelect.FalseValue = "0"
        Me.ColSelect.HeaderText = "เลือก"
        Me.ColSelect.IndeterminateValue = "0"
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColSelect.TrueValue = "1"
        Me.ColSelect.Width = 35
        '
        'colidP
        '
        Me.colidP.DataPropertyName = "idP"
        Me.colidP.HeaderText = "idP"
        Me.colidP.Name = "colidP"
        Me.colidP.Visible = False
        '
        'colPName
        '
        Me.colPName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPName.DataPropertyName = "PName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPName.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPName.HeaderText = "ชื่อสินค้า/ Package"
        Me.colPName.Name = "colPName"
        Me.colPName.ReadOnly = True
        Me.colPName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColSumThisY
        '
        Me.ColSumThisY.DataPropertyName = "SumThisY"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ColSumThisY.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColSumThisY.HeaderText = "ยอดขาย"
        Me.ColSumThisY.Name = "ColSumThisY"
        Me.ColSumThisY.ReadOnly = True
        Me.ColSumThisY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColSumThisY.Width = 85
        '
        'Chart2
        '
        ChartArea2.AxisX.Interval = 1
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Interval = 1
        ChartArea2.AxisX.MajorGrid.IntervalOffset = 0
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX.MajorTickMark.Enabled = False
        ChartArea2.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1
        ChartArea2.AxisX.Title = "เดือน"
        ChartArea2.AxisY.IsLabelAutoFit = False
        ChartArea2.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.ScrollBar.Size = 12
        ChartArea2.AxisY.Title = "ยอดขาบ (บาท)"
        ChartArea2.BackColor = System.Drawing.Color.Black
        ChartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.BorderWidth = 2
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Legend2.Title = "สินค้า"
        Legend2.TitleBackColor = System.Drawing.Color.Transparent
        Legend2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(0, 0)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Size = New System.Drawing.Size(672, 426)
        Me.Chart2.TabIndex = 669
        Me.Chart2.Text = "Chart2"
        Me.Chart2.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        Title2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Title2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "กราฟเปรียบเทียบยอดขายจำแนกตาม"
        Title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart2.Titles.Add(Title2)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnShowS)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 38)
        Me.Panel2.TabIndex = 667
        '
        'btnShowS
        '
        Me.btnShowS.BackColor = System.Drawing.Color.DimGray
        Me.btnShowS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowS.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShowS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShowS.ForeColor = System.Drawing.Color.White
        Me.btnShowS.Image = CType(resources.GetObject("btnShowS.Image"), System.Drawing.Image)
        Me.btnShowS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowS.Location = New System.Drawing.Point(0, 0)
        Me.btnShowS.Name = "btnShowS"
        Me.btnShowS.Size = New System.Drawing.Size(115, 36)
        Me.btnShowS.TabIndex = 580
        Me.btnShowS.Tag = ""
        Me.btnShowS.Text = "       แสดงข้อมูล"
        Me.btnShowS.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Lavender
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Controls.Add(Me.dtpThisYearS)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(970, 66)
        Me.Panel4.TabIndex = 666
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbPdnameO)
        Me.GroupBox3.Controls.Add(Me.rdbTotalNet)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(585, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 54)
        Me.GroupBox3.TabIndex = 647
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ระบุการจัดเรียงข้อมูล"
        '
        'rdbPdnameO
        '
        Me.rdbPdnameO.AutoSize = True
        Me.rdbPdnameO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPdnameO.Location = New System.Drawing.Point(134, 23)
        Me.rdbPdnameO.Name = "rdbPdnameO"
        Me.rdbPdnameO.Size = New System.Drawing.Size(83, 17)
        Me.rdbPdnameO.TabIndex = 1
        Me.rdbPdnameO.Text = "ตามชื่อสินค้า"
        Me.rdbPdnameO.UseVisualStyleBackColor = True
        '
        'rdbTotalNet
        '
        Me.rdbTotalNet.AutoSize = True
        Me.rdbTotalNet.Checked = True
        Me.rdbTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbTotalNet.Location = New System.Drawing.Point(30, 23)
        Me.rdbTotalNet.Name = "rdbTotalNet"
        Me.rdbTotalNet.Size = New System.Drawing.Size(82, 17)
        Me.rdbTotalNet.TabIndex = 0
        Me.rdbTotalNet.TabStop = True
        Me.rdbTotalNet.Text = "ตามยอดขาย"
        Me.rdbTotalNet.UseVisualStyleBackColor = True
        '
        'dtpThisYearS
        '
        Me.dtpThisYearS.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpThisYearS.CausesValidation = False
        Me.dtpThisYearS.CustomFormat = "yyyy"
        Me.dtpThisYearS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpThisYearS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThisYearS.Location = New System.Drawing.Point(99, 21)
        Me.dtpThisYearS.Name = "dtpThisYearS"
        Me.dtpThisYearS.ShowUpDown = True
        Me.dtpThisYearS.Size = New System.Drawing.Size(75, 24)
        Me.dtpThisYearS.TabIndex = 646
        Me.dtpThisYearS.Value = New Date(2015, 2, 12, 0, 0, 0, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbPlant)
        Me.GroupBox2.Controls.Add(Me.rdbPdPk)
        Me.GroupBox2.Controls.Add(Me.rdbPdT)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(202, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 54)
        Me.GroupBox2.TabIndex = 643
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ระบุข้อมูลที่ใช้เปรียบเทียบ"
        '
        'rdbPlant
        '
        Me.rdbPlant.AutoSize = True
        Me.rdbPlant.Checked = True
        Me.rdbPlant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPlant.Location = New System.Drawing.Point(40, 25)
        Me.rdbPlant.Name = "rdbPlant"
        Me.rdbPlant.Size = New System.Drawing.Size(40, 17)
        Me.rdbPlant.TabIndex = 2
        Me.rdbPlant.TabStop = True
        Me.rdbPlant.Text = "พืช"
        Me.rdbPlant.UseVisualStyleBackColor = True
        '
        'rdbPdPk
        '
        Me.rdbPdPk.AutoSize = True
        Me.rdbPdPk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPdPk.Location = New System.Drawing.Point(230, 25)
        Me.rdbPdPk.Name = "rdbPdPk"
        Me.rdbPdPk.Size = New System.Drawing.Size(119, 17)
        Me.rdbPdPk.TabIndex = 1
        Me.rdbPdPk.Text = "สินค้าแบบ Package"
        Me.rdbPdPk.UseVisualStyleBackColor = True
        '
        'rdbPdT
        '
        Me.rdbPdT.AutoSize = True
        Me.rdbPdT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPdT.Location = New System.Drawing.Point(133, 25)
        Me.rdbPdT.Name = "rdbPdT"
        Me.rdbPdT.Size = New System.Drawing.Size(51, 17)
        Me.rdbPdT.TabIndex = 0
        Me.rdbPdT.Text = "สินค้า"
        Me.rdbPdT.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 645
        Me.Label4.Text = "ประจำปี"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvData)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(3, 107)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(298, 426)
        Me.Panel5.TabIndex = 671
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Chart2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(301, 107)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(672, 426)
        Me.Panel6.TabIndex = 672
        '
        'frmSlSaleSummaryLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmSlSaleSummaryLine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สรุปเปรียบเทียบยอดขายแบบกราฟเส้น"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPdPk As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPdT As System.Windows.Forms.ComboBox
    Friend WithEvents ChkPdPk As System.Windows.Forms.CheckBox
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnShowS As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dtpThisYearS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbPdPk As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPdT As System.Windows.Forms.RadioButton
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbPdnameO As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTotalNet As System.Windows.Forms.RadioButton
    Friend WithEvents ChkPd As System.Windows.Forms.CheckBox
    Friend WithEvents Cmbplant As System.Windows.Forms.ComboBox
    Friend WithEvents rdbPlant As System.Windows.Forms.RadioButton
    Friend WithEvents ColSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colidP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSumThisY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
