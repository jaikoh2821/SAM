<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlCusMapAll
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.cbCusName = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbCusName2 = New System.Windows.Forms.CheckBox()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.colselect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colPersonName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumCus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colidPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 49)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1170, 534)
        Me.WebBrowser1.TabIndex = 0
        '
        'cbCusName
        '
        Me.cbCusName.AutoSize = True
        Me.cbCusName.Location = New System.Drawing.Point(471, 13)
        Me.cbCusName.Name = "cbCusName"
        Me.cbCusName.Size = New System.Drawing.Size(98, 17)
        Me.cbCusName.TabIndex = 1
        Me.cbCusName.Text = "แสดงชื่อทั้งหมด"
        Me.cbCusName.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1184, 612)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1176, 586)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "แสดงลูกค้าทั้งหมด"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbCusName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1170, 46)
        Me.Panel1.TabIndex = 406
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.dgvData)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1176, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แสดงตามเจ้าหน้าที่ที่ดูแล"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.WebBrowser2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(362, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(811, 580)
        Me.Panel2.TabIndex = 407
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lavender
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cbCusName2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(809, 0)
        Me.Panel3.TabIndex = 407
        '
        'cbCusName2
        '
        Me.cbCusName2.AutoSize = True
        Me.cbCusName2.Enabled = False
        Me.cbCusName2.Location = New System.Drawing.Point(367, 13)
        Me.cbCusName2.Name = "cbCusName2"
        Me.cbCusName2.Size = New System.Drawing.Size(98, 17)
        Me.cbCusName2.TabIndex = 1
        Me.cbCusName2.Text = "แสดงชื่อทั้งหมด"
        Me.cbCusName2.UseVisualStyleBackColor = True
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WebBrowser2.Location = New System.Drawing.Point(0, -106)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(809, 684)
        Me.WebBrowser2.TabIndex = 2
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colselect, Me.colPersonName, Me.colNumCus, Me.colidPer})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvData.Location = New System.Drawing.Point(3, 3)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(359, 580)
        Me.dgvData.TabIndex = 412
        '
        'colselect
        '
        Me.colselect.FalseValue = "False"
        Me.colselect.HeaderText = "เลือก"
        Me.colselect.Name = "colselect"
        Me.colselect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colselect.TrueValue = "True"
        Me.colselect.Width = 35
        '
        'colPersonName
        '
        Me.colPersonName.DataPropertyName = "PsName"
        Me.colPersonName.HeaderText = "ชื่อเจ้าหน้าที่"
        Me.colPersonName.Name = "colPersonName"
        Me.colPersonName.Width = 200
        '
        'colNumCus
        '
        Me.colNumCus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNumCus.DataPropertyName = "numCus"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNumCus.DefaultCellStyle = DataGridViewCellStyle2
        Me.colNumCus.HeaderText = "จำนวนลูกค้าที่ดูแล"
        Me.colNumCus.Name = "colNumCus"
        '
        'colidPer
        '
        Me.colidPer.DataPropertyName = "idPs"
        Me.colidPer.HeaderText = "idPer"
        Me.colidPer.Name = "colidPer"
        Me.colidPer.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(471, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "แสดงชื่อทั้งหมด"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmSlCusMapAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1184, 612)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmSlCusMapAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แผนที่ตำแหน่งของลูกค้าทั้งหมด"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents cbCusName As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbCusName2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents colselect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colPersonName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidPer As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
