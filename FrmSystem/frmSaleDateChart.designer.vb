<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleDateChart
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaleDateChart))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.CachedcrpMkGiftGreetingCard1 = New SAM.CachedcrpMkGiftGreetingCard()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.LightYellow
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.PointDepth = 50
        ChartArea1.Area3DStyle.PointGapDepth = 70
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelAutoFitStyle = CType((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45 Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
        ChartArea1.AxisX.LabelStyle.Angle = 45
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.MajorGrid.Interval = 0.0R
        ChartArea1.AxisX.Title = "วันที่ขาย"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        ChartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisY.LabelStyle.Format = "#,##0"
        ChartArea1.AxisY.Title = "ยอดขาย"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        ChartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.CursorY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.CursorY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Enabled = False
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "PointWidth=0.5"
        Series1.IsValueShownAsLabel = True
        Series1.LabelFormat = "#,##0"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.SmartLabelStyle.Enabled = False
        Series1.XValueMember = "vDayDate"
        Series1.YValueMembers = "TotalNet"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1184, 551)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
        Title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Title1.Font = New System.Drawing.Font("Angsana New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.DodgerBlue
        Title1.Name = "Title1"
        Title1.Text = "กราฟสรุปยอดขายประจำวัน"
        Title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow
        Me.Chart1.Titles.Add(Title1)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightYellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(89, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Last Update :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightYellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(35, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Refresh"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Global.SAM.My.Resources.Resources.refresh_button_icon_56615_png_24x24
        Me.btnRefresh.Location = New System.Drawing.Point(6, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(28, 28)
        Me.btnRefresh.TabIndex = 597
        Me.btnRefresh.Tag = "Add"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.LightYellow
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.Location = New System.Drawing.Point(7, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 13)
        Me.Label23.TabIndex = 782
        Me.Label23.Text = "ข้อมูลบริษัท :"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(86, 31)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(194, 23)
        Me.cmbGroupComp.TabIndex = 783
        '
        'frmSaleDateChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.cmbGroupComp)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSaleDateChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "กราฟสรุปยอดขายรายวัน"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents CachedcrpMkGiftGreetingCard1 As SAM.CachedcrpMkGiftGreetingCard
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
End Class
