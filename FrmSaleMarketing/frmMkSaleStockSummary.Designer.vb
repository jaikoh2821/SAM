<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkSaleStockSummary
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSchPd = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LB2 = New System.Windows.Forms.Label
        Me.LB1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.dgvData3 = New System.Windows.Forms.DataGridView
        Me.dgvData2 = New System.Windows.Forms.DataGridView
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.CHK1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.idPlantType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlantTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Num1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Flag1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Date3 = New System.Windows.Forms.DateTimePicker
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.CHK2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.idPdT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdTradeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Flag2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHK3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.idPdPk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdPkName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Flag3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSchPd)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 40)
        Me.Panel1.TabIndex = 620
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
        Me.Panel2.Controls.Add(Me.LB2)
        Me.Panel2.Controls.Add(Me.LB1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Date3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1084, 131)
        Me.Panel2.TabIndex = 621
        '
        'LB2
        '
        Me.LB2.AutoSize = True
        Me.LB2.Location = New System.Drawing.Point(3, 99)
        Me.LB2.Name = "LB2"
        Me.LB2.Size = New System.Drawing.Size(95, 13)
        Me.LB2.TabIndex = 705
        Me.LB2.Text = "ยอดขายรวม 0 บาท"
        '
        'LB1
        '
        Me.LB1.AutoSize = True
        Me.LB1.Location = New System.Drawing.Point(3, 75)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(131, 13)
        Me.LB1.TabIndex = 704
        Me.LB1.Text = "ยอดรวมน้ำหนัก 0 กิโลกรัม"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvData3)
        Me.Panel3.Controls.Add(Me.dgvData2)
        Me.Panel3.Controls.Add(Me.dgvData)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(194, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(890, 131)
        Me.Panel3.TabIndex = 703
        '
        'dgvData3
        '
        Me.dgvData3.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK3, Me.idPdPk, Me.PdPkName, Me.DataGridViewTextBoxColumn6, Me.Flag3})
        Me.dgvData3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData3.Location = New System.Drawing.Point(546, 0)
        Me.dgvData3.Name = "dgvData3"
        Me.dgvData3.RowHeadersVisible = False
        Me.dgvData3.Size = New System.Drawing.Size(344, 131)
        Me.dgvData3.TabIndex = 704
        '
        'dgvData2
        '
        Me.dgvData2.AllowUserToAddRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK2, Me.idPdT, Me.PdTradeName, Me.DataGridViewTextBoxColumn3, Me.Flag2})
        Me.dgvData2.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvData2.Location = New System.Drawing.Point(265, 0)
        Me.dgvData2.Name = "dgvData2"
        Me.dgvData2.RowHeadersVisible = False
        Me.dgvData2.Size = New System.Drawing.Size(281, 131)
        Me.dgvData2.TabIndex = 703
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK1, Me.idPlantType, Me.PlantTypeName, Me.Num1, Me.Flag1})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvData.Location = New System.Drawing.Point(0, 0)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(265, 131)
        Me.dgvData.TabIndex = 702
        '
        'CHK1
        '
        Me.CHK1.FalseValue = "0"
        Me.CHK1.HeaderText = "เลือก"
        Me.CHK1.Name = "CHK1"
        Me.CHK1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK1.TrueValue = "1"
        Me.CHK1.Width = 35
        '
        'idPlantType
        '
        Me.idPlantType.DataPropertyName = "idPlantType"
        Me.idPlantType.HeaderText = "idPlantType"
        Me.idPlantType.Name = "idPlantType"
        Me.idPlantType.Visible = False
        '
        'PlantTypeName
        '
        Me.PlantTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PlantTypeName.DataPropertyName = "PlantTypeName"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.PlantTypeName.DefaultCellStyle = DataGridViewCellStyle8
        Me.PlantTypeName.HeaderText = "ประเภทพืช"
        Me.PlantTypeName.Name = "PlantTypeName"
        Me.PlantTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Num1
        '
        Me.Num1.DataPropertyName = "Num"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Format = "N3"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Num1.DefaultCellStyle = DataGridViewCellStyle9
        Me.Num1.HeaderText = "จำนวน"
        Me.Num1.Name = "Num1"
        Me.Num1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Num1.Width = 70
        '
        'Flag1
        '
        Me.Flag1.DataPropertyName = "Flag"
        Me.Flag1.HeaderText = "Flag1"
        Me.Flag1.Name = "Flag1"
        Me.Flag1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 702
        Me.Label3.Text = "ระบุปี"
        '
        'Date3
        '
        Me.Date3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date3.Location = New System.Drawing.Point(26, 29)
        Me.Date3.Name = "Date3"
        Me.Date3.ShowUpDown = True
        Me.Date3.Size = New System.Drawing.Size(146, 26)
        Me.Date3.TabIndex = 697
        Me.Date3.Value = New Date(2013, 9, 4, 0, 0, 0, 0)
        '
        'Chart1
        '
        ChartArea1.AxisX.Interval = 1
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.Title = "เดือน"
        ChartArea1.AxisY.Title = "จำนวน (กก.)"
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 171)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series4"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(1084, 441)
        Me.Chart1.TabIndex = 622
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "แผนภูมิเปรียบเทียบระหว่างจำนวนยอดขายและสต๊อกคงเหลือ"
        Title1.Text = "แผนภูมิเปรียบเทียบระหว่างจำนวนยอดขายและสต๊อกคงเหลือ (กก.)"
        Me.Chart1.Titles.Add(Title1)
        '
        'CHK2
        '
        Me.CHK2.FalseValue = "0"
        Me.CHK2.HeaderText = "เลือก"
        Me.CHK2.Name = "CHK2"
        Me.CHK2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK2.TrueValue = "1"
        Me.CHK2.Width = 35
        '
        'idPdT
        '
        Me.idPdT.DataPropertyName = "idPdT"
        Me.idPdT.HeaderText = "idSale"
        Me.idPdT.Name = "idPdT"
        Me.idPdT.Visible = False
        '
        'PdTradeName
        '
        Me.PdTradeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PdTradeName.DataPropertyName = "PdTradeName"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.NullValue = Nothing
        Me.PdTradeName.DefaultCellStyle = DataGridViewCellStyle5
        Me.PdTradeName.HeaderText = "ชื่อสินค้า"
        Me.PdTradeName.Name = "PdTradeName"
        Me.PdTradeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Num"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Format = "N3"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.HeaderText = "จำนวน"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'Flag2
        '
        Me.Flag2.DataPropertyName = "Flag"
        Me.Flag2.HeaderText = "Flag2"
        Me.Flag2.Name = "Flag2"
        Me.Flag2.Visible = False
        '
        'CHK3
        '
        Me.CHK3.FalseValue = "0"
        Me.CHK3.HeaderText = "เลือก"
        Me.CHK3.Name = "CHK3"
        Me.CHK3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK3.TrueValue = "1"
        Me.CHK3.Width = 35
        '
        'idPdPk
        '
        Me.idPdPk.DataPropertyName = "idPdPk"
        Me.idPdPk.HeaderText = "idSale"
        Me.idPdPk.Name = "idPdPk"
        Me.idPdPk.Visible = False
        '
        'PdPkName
        '
        Me.PdPkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PdPkName.DataPropertyName = "PdPkName"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PdPkName.DefaultCellStyle = DataGridViewCellStyle2
        Me.PdPkName.HeaderText = "สินค้าสำเร็จรูป"
        Me.PdPkName.Name = "PdPkName"
        Me.PdPkName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Num"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "จำนวน"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'Flag3
        '
        Me.Flag3.DataPropertyName = "Flag"
        Me.Flag3.HeaderText = "Flag3"
        Me.Flag3.Name = "Flag3"
        Me.Flag3.Visible = False
        '
        'frmMkSaleStockSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1084, 612)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmMkSaleStockSummary"
        Me.Text = "สรุปยอดขายเทียบสต็อกคงเหลือ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSchPd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Date3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents dgvData3 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvData2 As System.Windows.Forms.DataGridView
    Friend WithEvents LB1 As System.Windows.Forms.Label
    Friend WithEvents LB2 As System.Windows.Forms.Label
    Friend WithEvents CHK1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents idPlantType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlantTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Flag1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHK2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents idPdT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdTradeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Flag2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHK3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents idPdPk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdPkName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Flag3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
