<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPsZoneSummary
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSchPd = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Date2 = New System.Windows.Forms.DateTimePicker
        Me.Date3 = New System.Windows.Forms.DateTimePicker
        Me.RB2 = New System.Windows.Forms.RadioButton
        Me.Date1 = New System.Windows.Forms.DateTimePicker
        Me.RB1 = New System.Windows.Forms.RadioButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.LB_11 = New System.Windows.Forms.Label
        Me.LB11 = New System.Windows.Forms.Label
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.LB8 = New System.Windows.Forms.Label
        Me.LB_8 = New System.Windows.Forms.Label
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.LB_4 = New System.Windows.Forms.Label
        Me.LB4 = New System.Windows.Forms.Label
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.LB2 = New System.Windows.Forms.Label
        Me.LB_2 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.LB1 = New System.Windows.Forms.Label
        Me.LB_1 = New System.Windows.Forms.Label
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.LB10 = New System.Windows.Forms.Label
        Me.LB_10 = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.LB9 = New System.Windows.Forms.Label
        Me.LB_9 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.LB7 = New System.Windows.Forms.Label
        Me.LB_7 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.LB6 = New System.Windows.Forms.Label
        Me.LB_6 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LB5 = New System.Windows.Forms.Label
        Me.LB_5 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.LB_3 = New System.Windows.Forms.Label
        Me.LB3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.RadioButton9 = New System.Windows.Forms.RadioButton
        Me.RadioButton10 = New System.Windows.Forms.RadioButton
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.Panel26 = New System.Windows.Forms.Panel
        Me.Panel27 = New System.Windows.Forms.Panel
        Me.Panel28 = New System.Windows.Forms.Panel
        Me.Panel29 = New System.Windows.Forms.Panel
        Me.Panel30 = New System.Windows.Forms.Panel
        Me.lbtotal = New System.Windows.Forms.Label
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.AxisX.Interval = 1
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.TruncatedLabels = True
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.Title = "เขตการขายตามภูมิภาค"
        ChartArea1.AxisY.LabelStyle.Format = "N0"
        ChartArea1.AxisY.Title = "ยอดขาย (บาท)"
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(459, 472)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "แผนภูมิเปรียบเทียบยอดขายของเขตการขายตามภูมิภาค"
        Me.Chart1.Titles.Add(Title1)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbtotal)
        Me.Panel1.Controls.Add(Me.btnSchPd)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 40)
        Me.Panel1.TabIndex = 618
        '
        'btnSchPd
        '
        Me.btnSchPd.BackColor = System.Drawing.Color.DimGray
        Me.btnSchPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchPd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSchPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSchPd.ForeColor = System.Drawing.Color.White
        Me.btnSchPd.Image = Global.SAM.My.Resources.Resources.Find
        Me.btnSchPd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchPd.Location = New System.Drawing.Point(0, 0)
        Me.btnSchPd.Name = "btnSchPd"
        Me.btnSchPd.Size = New System.Drawing.Size(115, 38)
        Me.btnSchPd.TabIndex = 581
        Me.btnSchPd.Tag = ""
        Me.btnSchPd.Text = "       แสดงข้อมูล"
        Me.btnSchPd.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DimGray
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(3, -1)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 36)
        Me.btnSearch.TabIndex = 392
        Me.btnSearch.Tag = "Add"
        Me.btnSearch.Text = "        แสดงข้อมูล"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Date2)
        Me.Panel2.Controls.Add(Me.Date3)
        Me.Panel2.Controls.Add(Me.RB2)
        Me.Panel2.Controls.Add(Me.Date1)
        Me.Panel2.Controls.Add(Me.RB1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1044, 100)
        Me.Panel2.TabIndex = 619
        '
        'Date2
        '
        Me.Date2.Enabled = False
        Me.Date2.Location = New System.Drawing.Point(547, 27)
        Me.Date2.Name = "Date2"
        Me.Date2.ShowUpDown = True
        Me.Date2.Size = New System.Drawing.Size(146, 20)
        Me.Date2.TabIndex = 698
        Me.Date2.Value = New Date(2013, 9, 4, 0, 0, 0, 0)
        '
        'Date3
        '
        Me.Date3.Enabled = False
        Me.Date3.Location = New System.Drawing.Point(353, 49)
        Me.Date3.Name = "Date3"
        Me.Date3.ShowUpDown = True
        Me.Date3.Size = New System.Drawing.Size(146, 20)
        Me.Date3.TabIndex = 697
        Me.Date3.Value = New Date(2013, 9, 4, 0, 0, 0, 0)
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Checked = True
        Me.RB2.Location = New System.Drawing.Point(257, 51)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(56, 17)
        Me.RB2.TabIndex = 696
        Me.RB2.TabStop = True
        Me.RB2.Text = "เลือกปี"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'Date1
        '
        Me.Date1.Enabled = False
        Me.Date1.Location = New System.Drawing.Point(353, 26)
        Me.Date1.Name = "Date1"
        Me.Date1.ShowUpDown = True
        Me.Date1.Size = New System.Drawing.Size(146, 20)
        Me.Date1.TabIndex = 695
        Me.Date1.Value = New Date(2013, 9, 4, 0, 0, 0, 0)
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Location = New System.Drawing.Point(257, 28)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(75, 17)
        Me.RB1.TabIndex = 694
        Me.RB1.Text = "เลือกเดือน"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1044, 472)
        Me.Panel3.TabIndex = 620
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Chart1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(585, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(459, 472)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.Panel30)
        Me.Panel5.Controls.Add(Me.RadioButton10)
        Me.Panel5.Controls.Add(Me.Panel29)
        Me.Panel5.Controls.Add(Me.RadioButton2)
        Me.Panel5.Controls.Add(Me.Panel13)
        Me.Panel5.Controls.Add(Me.Panel28)
        Me.Panel5.Controls.Add(Me.RadioButton8)
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Controls.Add(Me.Panel27)
        Me.Panel5.Controls.Add(Me.Panel15)
        Me.Panel5.Controls.Add(Me.Panel26)
        Me.Panel5.Controls.Add(Me.Panel25)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel24)
        Me.Panel5.Controls.Add(Me.Panel23)
        Me.Panel5.Controls.Add(Me.RadioButton6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel22)
        Me.Panel5.Controls.Add(Me.Panel14)
        Me.Panel5.Controls.Add(Me.Panel21)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.RadioButton4)
        Me.Panel5.Controls.Add(Me.Panel20)
        Me.Panel5.Controls.Add(Me.Panel19)
        Me.Panel5.Controls.Add(Me.RadioButton3)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Panel18)
        Me.Panel5.Controls.Add(Me.RadioButton9)
        Me.Panel5.Controls.Add(Me.RadioButton7)
        Me.Panel5.Controls.Add(Me.RadioButton5)
        Me.Panel5.Controls.Add(Me.RadioButton1)
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel17)
        Me.Panel5.Controls.Add(Me.Panel16)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(585, 472)
        Me.Panel5.TabIndex = 3
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.DimGray
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.LB_11)
        Me.Panel16.Controls.Add(Me.LB11)
        Me.Panel16.Location = New System.Drawing.Point(376, 409)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(195, 44)
        Me.Panel16.TabIndex = 23
        '
        'LB_11
        '
        Me.LB_11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LB_11.AutoSize = True
        Me.LB_11.BackColor = System.Drawing.Color.DimGray
        Me.LB_11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_11.ForeColor = System.Drawing.Color.Lime
        Me.LB_11.Location = New System.Drawing.Point(8, 3)
        Me.LB_11.Name = "LB_11"
        Me.LB_11.Size = New System.Drawing.Size(90, 15)
        Me.LB_11.TabIndex = 12
        Me.LB_11.Text = "ลูกค้าต่างประเทศ "
        '
        'LB11
        '
        Me.LB11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LB11.AutoSize = True
        Me.LB11.BackColor = System.Drawing.Color.DimGray
        Me.LB11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB11.ForeColor = System.Drawing.Color.Lime
        Me.LB11.Location = New System.Drawing.Point(5, 23)
        Me.LB11.Name = "LB11"
        Me.LB11.Size = New System.Drawing.Size(134, 16)
        Me.LB11.TabIndex = 11
        Me.LB11.Text = "ยอดขาย 200000000 บาท"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.DimGray
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.LB8)
        Me.Panel15.Controls.Add(Me.LB_8)
        Me.Panel15.Location = New System.Drawing.Point(6, 270)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(161, 44)
        Me.Panel15.TabIndex = 22
        '
        'LB8
        '
        Me.LB8.AutoSize = True
        Me.LB8.BackColor = System.Drawing.Color.DimGray
        Me.LB8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB8.ForeColor = System.Drawing.Color.Lime
        Me.LB8.Location = New System.Drawing.Point(1, 20)
        Me.LB8.Name = "LB8"
        Me.LB8.Size = New System.Drawing.Size(134, 16)
        Me.LB8.TabIndex = 11
        Me.LB8.Text = "ยอดขาย 200000000 บาท"
        '
        'LB_8
        '
        Me.LB_8.AutoSize = True
        Me.LB_8.BackColor = System.Drawing.Color.DimGray
        Me.LB_8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_8.ForeColor = System.Drawing.Color.Lime
        Me.LB_8.Location = New System.Drawing.Point(3, 0)
        Me.LB_8.Name = "LB_8"
        Me.LB_8.Size = New System.Drawing.Size(75, 15)
        Me.LB_8.TabIndex = 12
        Me.LB_8.Text = "ภาคใต้ตอนบน"
        Me.LB_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.DimGray
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.LB_4)
        Me.Panel14.Controls.Add(Me.LB4)
        Me.Panel14.Location = New System.Drawing.Point(412, 161)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(159, 44)
        Me.Panel14.TabIndex = 21
        '
        'LB_4
        '
        Me.LB_4.AutoSize = True
        Me.LB_4.BackColor = System.Drawing.Color.DimGray
        Me.LB_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_4.ForeColor = System.Drawing.Color.Lime
        Me.LB_4.Location = New System.Drawing.Point(9, 0)
        Me.LB_4.Name = "LB_4"
        Me.LB_4.Size = New System.Drawing.Size(49, 15)
        Me.LB_4.TabIndex = 12
        Me.LB_4.Text = "ภาคกลาง"
        Me.LB_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB4
        '
        Me.LB4.AutoSize = True
        Me.LB4.BackColor = System.Drawing.Color.DimGray
        Me.LB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB4.ForeColor = System.Drawing.Color.Lime
        Me.LB4.Location = New System.Drawing.Point(1, 20)
        Me.LB4.Name = "LB4"
        Me.LB4.Size = New System.Drawing.Size(134, 16)
        Me.LB4.TabIndex = 11
        Me.LB4.Text = "ยอดขาย 200000000 บาท"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.DimGray
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.LB2)
        Me.Panel13.Controls.Add(Me.LB_2)
        Me.Panel13.Location = New System.Drawing.Point(12, 106)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(161, 44)
        Me.Panel13.TabIndex = 20
        '
        'LB2
        '
        Me.LB2.AutoSize = True
        Me.LB2.BackColor = System.Drawing.Color.DimGray
        Me.LB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB2.ForeColor = System.Drawing.Color.Lime
        Me.LB2.Location = New System.Drawing.Point(1, 20)
        Me.LB2.Name = "LB2"
        Me.LB2.Size = New System.Drawing.Size(134, 16)
        Me.LB2.TabIndex = 11
        Me.LB2.Text = "ยอดขาย 200000000 บาท"
        '
        'LB_2
        '
        Me.LB_2.AutoSize = True
        Me.LB_2.BackColor = System.Drawing.Color.DimGray
        Me.LB_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_2.ForeColor = System.Drawing.Color.Lime
        Me.LB_2.Location = New System.Drawing.Point(5, 2)
        Me.LB_2.Name = "LB_2"
        Me.LB_2.Size = New System.Drawing.Size(89, 15)
        Me.LB_2.TabIndex = 12
        Me.LB_2.Text = "ภาคเหนือตอนล่าง"
        Me.LB_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.DimGray
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.LB1)
        Me.Panel12.Controls.Add(Me.LB_1)
        Me.Panel12.Location = New System.Drawing.Point(17, 16)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(156, 44)
        Me.Panel12.TabIndex = 19
        '
        'LB1
        '
        Me.LB1.AutoSize = True
        Me.LB1.BackColor = System.Drawing.Color.DimGray
        Me.LB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB1.ForeColor = System.Drawing.Color.Lime
        Me.LB1.Location = New System.Drawing.Point(1, 20)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(134, 16)
        Me.LB1.TabIndex = 11
        Me.LB1.Text = "ยอดขาย 200000000 บาท"
        '
        'LB_1
        '
        Me.LB_1.AutoSize = True
        Me.LB_1.BackColor = System.Drawing.Color.DimGray
        Me.LB_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_1.ForeColor = System.Drawing.Color.Lime
        Me.LB_1.Location = New System.Drawing.Point(5, 2)
        Me.LB_1.Name = "LB_1"
        Me.LB_1.Size = New System.Drawing.Size(88, 15)
        Me.LB_1.TabIndex = 12
        Me.LB_1.Text = "ภาคเหนือตอนบน"
        Me.LB_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.DimGray
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.LB10)
        Me.Panel11.Controls.Add(Me.LB_10)
        Me.Panel11.Location = New System.Drawing.Point(12, 194)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(161, 44)
        Me.Panel11.TabIndex = 18
        '
        'LB10
        '
        Me.LB10.AutoSize = True
        Me.LB10.BackColor = System.Drawing.Color.DimGray
        Me.LB10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB10.ForeColor = System.Drawing.Color.Lime
        Me.LB10.Location = New System.Drawing.Point(1, 20)
        Me.LB10.Name = "LB10"
        Me.LB10.Size = New System.Drawing.Size(134, 16)
        Me.LB10.TabIndex = 11
        Me.LB10.Text = "ยอดขาย 200000000 บาท"
        '
        'LB_10
        '
        Me.LB_10.AutoSize = True
        Me.LB_10.BackColor = System.Drawing.Color.DimGray
        Me.LB_10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_10.ForeColor = System.Drawing.Color.Lime
        Me.LB_10.Location = New System.Drawing.Point(3, 0)
        Me.LB_10.Name = "LB_10"
        Me.LB_10.Size = New System.Drawing.Size(66, 15)
        Me.LB_10.TabIndex = 12
        Me.LB_10.Text = "ภาคตะวันตก"
        Me.LB_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DimGray
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.LB9)
        Me.Panel10.Controls.Add(Me.LB_9)
        Me.Panel10.Location = New System.Drawing.Point(12, 416)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(161, 44)
        Me.Panel10.TabIndex = 17
        '
        'LB9
        '
        Me.LB9.AutoSize = True
        Me.LB9.BackColor = System.Drawing.Color.DimGray
        Me.LB9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB9.ForeColor = System.Drawing.Color.Lime
        Me.LB9.Location = New System.Drawing.Point(1, 20)
        Me.LB9.Name = "LB9"
        Me.LB9.Size = New System.Drawing.Size(134, 16)
        Me.LB9.TabIndex = 11
        Me.LB9.Text = "ยอดขาย 200000000 บาท"
        '
        'LB_9
        '
        Me.LB_9.AutoSize = True
        Me.LB_9.BackColor = System.Drawing.Color.DimGray
        Me.LB_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_9.ForeColor = System.Drawing.Color.Lime
        Me.LB_9.Location = New System.Drawing.Point(5, 2)
        Me.LB_9.Name = "LB_9"
        Me.LB_9.Size = New System.Drawing.Size(76, 15)
        Me.LB_9.TabIndex = 12
        Me.LB_9.Text = "ภาคใต้ตอนล่าง"
        Me.LB_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DimGray
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.LB7)
        Me.Panel8.Controls.Add(Me.LB_7)
        Me.Panel8.Location = New System.Drawing.Point(368, 108)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(210, 44)
        Me.Panel8.TabIndex = 16
        '
        'LB7
        '
        Me.LB7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LB7.AutoSize = True
        Me.LB7.BackColor = System.Drawing.Color.DimGray
        Me.LB7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB7.ForeColor = System.Drawing.Color.Lime
        Me.LB7.Location = New System.Drawing.Point(21, 18)
        Me.LB7.Name = "LB7"
        Me.LB7.Size = New System.Drawing.Size(134, 16)
        Me.LB7.TabIndex = 11
        Me.LB7.Text = "ยอดขาย 200000000 บาท"
        '
        'LB_7
        '
        Me.LB_7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LB_7.AutoSize = True
        Me.LB_7.BackColor = System.Drawing.Color.DimGray
        Me.LB_7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_7.ForeColor = System.Drawing.Color.Lime
        Me.LB_7.Location = New System.Drawing.Point(3, 0)
        Me.LB_7.Name = "LB_7"
        Me.LB_7.Size = New System.Drawing.Size(159, 15)
        Me.LB_7.TabIndex = 12
        Me.LB_7.Text = "ภาคตะวันออกเฉียงเหนือตอนล่าง"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DimGray
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.LB6)
        Me.Panel9.Controls.Add(Me.LB_6)
        Me.Panel9.Location = New System.Drawing.Point(300, 16)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(216, 44)
        Me.Panel9.TabIndex = 15
        '
        'LB6
        '
        Me.LB6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LB6.AutoSize = True
        Me.LB6.BackColor = System.Drawing.Color.DimGray
        Me.LB6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB6.ForeColor = System.Drawing.Color.Lime
        Me.LB6.Location = New System.Drawing.Point(38, 20)
        Me.LB6.Name = "LB6"
        Me.LB6.Size = New System.Drawing.Size(134, 16)
        Me.LB6.TabIndex = 11
        Me.LB6.Text = "ยอดขาย 200000000 บาท"
        '
        'LB_6
        '
        Me.LB_6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LB_6.AutoSize = True
        Me.LB_6.BackColor = System.Drawing.Color.DimGray
        Me.LB_6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_6.ForeColor = System.Drawing.Color.Lime
        Me.LB_6.Location = New System.Drawing.Point(6, 2)
        Me.LB_6.Name = "LB_6"
        Me.LB_6.Size = New System.Drawing.Size(158, 15)
        Me.LB_6.TabIndex = 12
        Me.LB_6.Text = "ภาคตะวันออกเฉียงเหนือตอนบน"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DimGray
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.LB5)
        Me.Panel7.Controls.Add(Me.LB_5)
        Me.Panel7.Location = New System.Drawing.Point(357, 221)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(171, 44)
        Me.Panel7.TabIndex = 13
        '
        'LB5
        '
        Me.LB5.AutoSize = True
        Me.LB5.BackColor = System.Drawing.Color.DimGray
        Me.LB5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB5.ForeColor = System.Drawing.Color.Lime
        Me.LB5.Location = New System.Drawing.Point(1, 20)
        Me.LB5.Name = "LB5"
        Me.LB5.Size = New System.Drawing.Size(134, 16)
        Me.LB5.TabIndex = 11
        Me.LB5.Text = "ยอดขาย 200000000 บาท"
        '
        'LB_5
        '
        Me.LB_5.AutoSize = True
        Me.LB_5.BackColor = System.Drawing.Color.DimGray
        Me.LB_5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_5.ForeColor = System.Drawing.Color.Lime
        Me.LB_5.Location = New System.Drawing.Point(8, 0)
        Me.LB_5.Name = "LB_5"
        Me.LB_5.Size = New System.Drawing.Size(71, 15)
        Me.LB_5.TabIndex = 12
        Me.LB_5.Text = "ภาคตะวันออก"
        Me.LB_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.LB_3)
        Me.Panel6.Controls.Add(Me.LB3)
        Me.Panel6.Location = New System.Drawing.Point(304, 326)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(195, 44)
        Me.Panel6.TabIndex = 12
        '
        'LB_3
        '
        Me.LB_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LB_3.AutoSize = True
        Me.LB_3.BackColor = System.Drawing.Color.DimGray
        Me.LB_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_3.ForeColor = System.Drawing.Color.Lime
        Me.LB_3.Location = New System.Drawing.Point(14, 3)
        Me.LB_3.Name = "LB_3"
        Me.LB_3.Size = New System.Drawing.Size(113, 15)
        Me.LB_3.TabIndex = 12
        Me.LB_3.Text = "กรุงเทพฯและปริมณฑล"
        '
        'LB3
        '
        Me.LB3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LB3.AutoSize = True
        Me.LB3.BackColor = System.Drawing.Color.DimGray
        Me.LB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB3.ForeColor = System.Drawing.Color.Lime
        Me.LB3.Location = New System.Drawing.Point(13, 22)
        Me.LB3.Name = "LB3"
        Me.LB3.Size = New System.Drawing.Size(134, 16)
        Me.LB3.TabIndex = 11
        Me.LB3.Text = "ยอดขาย 200000000 บาท"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SAM.My.Resources.Resources.mapsale
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(118, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 464)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(513, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 699
        Me.Label1.Text = "ถึง"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Black
        Me.Panel17.Location = New System.Drawing.Point(101, 42)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(97, 3)
        Me.Panel17.TabIndex = 700
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoCheck = False
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.LightGreen
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(194, 37)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 701
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoCheck = False
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(204, 116)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 702
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoCheck = False
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.SandyBrown
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(308, 98)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton3.TabIndex = 702
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoCheck = False
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Violet
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(322, 159)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton4.TabIndex = 703
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoCheck = False
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.BackColor = System.Drawing.Color.Yellow
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(227, 202)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton5.TabIndex = 704
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoCheck = False
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.BackColor = System.Drawing.Color.LightGreen
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Location = New System.Drawing.Point(266, 225)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton6.TabIndex = 705
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoCheck = False
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.BackColor = System.Drawing.Color.Pink
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Location = New System.Drawing.Point(224, 173)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton7.TabIndex = 706
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.UseVisualStyleBackColor = False
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoCheck = False
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.BackColor = System.Drawing.Color.Red
        Me.RadioButton8.Checked = True
        Me.RadioButton8.Location = New System.Drawing.Point(194, 208)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton8.TabIndex = 707
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.UseVisualStyleBackColor = False
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoCheck = False
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.BackColor = System.Drawing.Color.Pink
        Me.RadioButton9.Checked = True
        Me.RadioButton9.Location = New System.Drawing.Point(170, 333)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton9.TabIndex = 708
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.UseVisualStyleBackColor = False
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoCheck = False
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.BackColor = System.Drawing.Color.Yellow
        Me.RadioButton10.Checked = True
        Me.RadioButton10.Location = New System.Drawing.Point(204, 398)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton10.TabIndex = 709
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.UseVisualStyleBackColor = False
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Black
        Me.Panel18.Location = New System.Drawing.Point(312, 44)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(3, 61)
        Me.Panel18.TabIndex = 701
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.Black
        Me.Panel19.Location = New System.Drawing.Point(328, 127)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(51, 3)
        Me.Panel19.TabIndex = 702
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Black
        Me.Panel20.Location = New System.Drawing.Point(327, 127)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(3, 40)
        Me.Panel20.TabIndex = 710
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.Black
        Me.Panel21.Location = New System.Drawing.Point(237, 178)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(180, 3)
        Me.Panel21.TabIndex = 711
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.Black
        Me.Panel22.Location = New System.Drawing.Point(272, 230)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(180, 3)
        Me.Panel22.TabIndex = 712
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.Black
        Me.Panel23.Location = New System.Drawing.Point(232, 215)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(3, 139)
        Me.Panel23.TabIndex = 713
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.Black
        Me.Panel24.Location = New System.Drawing.Point(234, 351)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(180, 3)
        Me.Panel24.TabIndex = 712
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.Black
        Me.Panel25.Location = New System.Drawing.Point(175, 294)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(3, 40)
        Me.Panel25.TabIndex = 711
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.Black
        Me.Panel26.Location = New System.Drawing.Point(127, 293)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(51, 3)
        Me.Panel26.TabIndex = 703
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.Black
        Me.Panel27.Location = New System.Drawing.Point(22, 214)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(180, 3)
        Me.Panel27.TabIndex = 713
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.Black
        Me.Panel28.Location = New System.Drawing.Point(29, 121)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(180, 3)
        Me.Panel28.TabIndex = 714
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.Black
        Me.Panel29.Location = New System.Drawing.Point(209, 402)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(3, 40)
        Me.Panel29.TabIndex = 711
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.Black
        Me.Panel30.Location = New System.Drawing.Point(160, 439)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(51, 3)
        Me.Panel30.TabIndex = 703
        '
        'lbtotal
        '
        Me.lbtotal.AutoSize = True
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbtotal.ForeColor = System.Drawing.Color.White
        Me.lbtotal.Location = New System.Drawing.Point(775, 9)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbtotal.Size = New System.Drawing.Size(96, 18)
        Me.lbtotal.TabIndex = 453
        Me.lbtotal.Text = "ยอดรวมทั้งหมด"
        '
        'frmPsZoneSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1044, 612)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmPsZoneSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สรุปยอดขายตามเขตการขาย"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSchPd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents Date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LB3 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LB_3 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LB_5 As System.Windows.Forms.Label
    Friend WithEvents LB5 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents LB_6 As System.Windows.Forms.Label
    Friend WithEvents LB6 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents LB7 As System.Windows.Forms.Label
    Friend WithEvents LB_7 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents LB1 As System.Windows.Forms.Label
    Friend WithEvents LB_1 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents LB10 As System.Windows.Forms.Label
    Friend WithEvents LB_10 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents LB9 As System.Windows.Forms.Label
    Friend WithEvents LB_9 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents LB8 As System.Windows.Forms.Label
    Friend WithEvents LB_8 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents LB4 As System.Windows.Forms.Label
    Friend WithEvents LB_4 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents LB2 As System.Windows.Forms.Label
    Friend WithEvents LB_2 As System.Windows.Forms.Label
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents LB_11 As System.Windows.Forms.Label
    Friend WithEvents LB11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Panel30 As System.Windows.Forms.Panel
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents lbtotal As System.Windows.Forms.Label
End Class
