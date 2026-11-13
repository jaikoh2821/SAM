<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlTransportData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvData1 = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txt_Search = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RdTspName = New System.Windows.Forms.RadioButton
        Me.RdTspShort = New System.Windows.Forms.RadioButton
        Me.Rdimportance = New System.Windows.Forms.RadioButton
        Me.ComboTspType = New System.Windows.Forms.ComboBox
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.CbShowTsp = New System.Windows.Forms.CheckBox
        Me.idTsp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.editTranSport = New System.Windows.Forms.DataGridViewImageColumn
        Me.importance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TspShort = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TspName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TspTel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TspArea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TspAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TspTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TspNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.is_null = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Short_null = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idTspType = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData1
        '
        Me.dgvData1.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTsp, Me.colautonum, Me.editTranSport, Me.importance, Me.TspShort, Me.TspName, Me.TspTel, Me.TspArea, Me.TspAddress, Me.TspTypeName, Me.TspNote, Me.is_null, Me.Short_null, Me.idTspType})
        Me.dgvData1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvData1.Location = New System.Drawing.Point(0, 138)
        Me.dgvData1.Name = "dgvData1"
        Me.dgvData1.RowHeadersVisible = False
        Me.dgvData1.Size = New System.Drawing.Size(1074, 353)
        Me.dgvData1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1074, 44)
        Me.Panel2.TabIndex = 541
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(839, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 546
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DimGray
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(0, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(102, 39)
        Me.btnAdd.TabIndex = 95
        Me.btnAdd.Tag = "Save"
        Me.btnAdd.Text = "       เพิ่มข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txt_Search
        '
        Me.txt_Search.Location = New System.Drawing.Point(360, 39)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(313, 20)
        Me.txt_Search.TabIndex = 542
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 18)
        Me.Label1.TabIndex = 543
        Me.Label1.Text = "ค้นหา ชื่อการขนส่ง , ชื่อย่อการขนส่ง หรือ ที่อยู่"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdTspName)
        Me.GroupBox1.Controls.Add(Me.RdTspShort)
        Me.GroupBox1.Controls.Add(Me.Rdimportance)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(695, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 77)
        Me.GroupBox1.TabIndex = 544
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกรูปแบบการเรียงข้อมูล"
        '
        'RdTspName
        '
        Me.RdTspName.AutoSize = True
        Me.RdTspName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RdTspName.Location = New System.Drawing.Point(164, 23)
        Me.RdTspName.Name = "RdTspName"
        Me.RdTspName.Size = New System.Drawing.Size(123, 20)
        Me.RdTspName.TabIndex = 2
        Me.RdTspName.Text = "เรียงตามชื่อการขนส่ง"
        Me.RdTspName.UseVisualStyleBackColor = True
        '
        'RdTspShort
        '
        Me.RdTspShort.AutoSize = True
        Me.RdTspShort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RdTspShort.Location = New System.Drawing.Point(15, 48)
        Me.RdTspShort.Name = "RdTspShort"
        Me.RdTspShort.Size = New System.Drawing.Size(135, 20)
        Me.RdTspShort.TabIndex = 1
        Me.RdTspShort.Text = "เรียงตามชื่อย่อการขนส่ง"
        Me.RdTspShort.UseVisualStyleBackColor = True
        '
        'Rdimportance
        '
        Me.Rdimportance.AutoSize = True
        Me.Rdimportance.Checked = True
        Me.Rdimportance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rdimportance.Location = New System.Drawing.Point(15, 23)
        Me.Rdimportance.Name = "Rdimportance"
        Me.Rdimportance.Size = New System.Drawing.Size(135, 20)
        Me.Rdimportance.TabIndex = 0
        Me.Rdimportance.TabStop = True
        Me.Rdimportance.Text = "เรียงตามลำดับการขนส่ง"
        Me.Rdimportance.UseVisualStyleBackColor = True
        '
        'ComboTspType
        '
        Me.ComboTspType.Enabled = False
        Me.ComboTspType.FormattingEnabled = True
        Me.ComboTspType.Location = New System.Drawing.Point(463, 65)
        Me.ComboTspType.Name = "ComboTspType"
        Me.ComboTspType.Size = New System.Drawing.Size(210, 21)
        Me.ComboTspType.TabIndex = 3
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 85.47009!
        Me.DataGridViewImageColumn1.HeaderText = "แก้ไข"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 40
        '
        'CbShowTsp
        '
        Me.CbShowTsp.AutoSize = True
        Me.CbShowTsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CbShowTsp.Location = New System.Drawing.Point(339, 66)
        Me.CbShowTsp.Name = "CbShowTsp"
        Me.CbShowTsp.Size = New System.Drawing.Size(118, 20)
        Me.CbShowTsp.TabIndex = 546
        Me.CbShowTsp.Text = "เลือกแสดงการขนส่ง"
        Me.CbShowTsp.UseVisualStyleBackColor = True
        '
        'idTsp
        '
        Me.idTsp.DataPropertyName = "idTsp"
        Me.idTsp.HeaderText = "idTs"
        Me.idTsp.Name = "idTsp"
        Me.idTsp.Visible = False
        '
        'colautonum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Width = 47
        '
        'editTranSport
        '
        Me.editTranSport.FillWeight = 85.47009!
        Me.editTranSport.HeaderText = "แก้ไข"
        Me.editTranSport.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.editTranSport.Name = "editTranSport"
        Me.editTranSport.Width = 40
        '
        'importance
        '
        Me.importance.DataPropertyName = "importance"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.importance.DefaultCellStyle = DataGridViewCellStyle3
        Me.importance.HeaderText = "ลำดับการขนส่ง"
        Me.importance.Name = "importance"
        Me.importance.ReadOnly = True
        Me.importance.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.importance.Width = 85
        '
        'TspShort
        '
        Me.TspShort.DataPropertyName = "TspShort"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TspShort.DefaultCellStyle = DataGridViewCellStyle4
        Me.TspShort.HeaderText = "ชื่อย่อการขนส่ง"
        Me.TspShort.Name = "TspShort"
        Me.TspShort.ReadOnly = True
        Me.TspShort.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TspShort.Width = 85
        '
        'TspName
        '
        Me.TspName.DataPropertyName = "TspName"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TspName.DefaultCellStyle = DataGridViewCellStyle5
        Me.TspName.FillWeight = 226.8608!
        Me.TspName.HeaderText = "ชื่อการขนส่ง"
        Me.TspName.Name = "TspName"
        Me.TspName.ReadOnly = True
        Me.TspName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TspName.Width = 150
        '
        'TspTel
        '
        Me.TspTel.DataPropertyName = "TspTel"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TspTel.DefaultCellStyle = DataGridViewCellStyle6
        Me.TspTel.HeaderText = "เบอร์โทรศัพท์"
        Me.TspTel.Name = "TspTel"
        Me.TspTel.ReadOnly = True
        Me.TspTel.Width = 150
        '
        'TspArea
        '
        Me.TspArea.DataPropertyName = "TspArea"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TspArea.DefaultCellStyle = DataGridViewCellStyle7
        Me.TspArea.HeaderText = "พื้นที่ให้บริการ"
        Me.TspArea.Name = "TspArea"
        Me.TspArea.ReadOnly = True
        Me.TspArea.Width = 140
        '
        'TspAddress
        '
        Me.TspAddress.DataPropertyName = "TspAddress"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TspAddress.DefaultCellStyle = DataGridViewCellStyle8
        Me.TspAddress.HeaderText = "ที่อยู่"
        Me.TspAddress.Name = "TspAddress"
        Me.TspAddress.ReadOnly = True
        Me.TspAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TspAddress.Width = 150
        '
        'TspTypeName
        '
        Me.TspTypeName.DataPropertyName = "TspTypeName"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TspTypeName.DefaultCellStyle = DataGridViewCellStyle9
        Me.TspTypeName.HeaderText = "รูปแบบการขนส่ง"
        Me.TspTypeName.Name = "TspTypeName"
        Me.TspTypeName.ReadOnly = True
        '
        'TspNote
        '
        Me.TspNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TspNote.DataPropertyName = "TspNote"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TspNote.DefaultCellStyle = DataGridViewCellStyle10
        Me.TspNote.FillWeight = 69.54247!
        Me.TspNote.HeaderText = "หมายเหตุ"
        Me.TspNote.Name = "TspNote"
        Me.TspNote.ReadOnly = True
        '
        'is_null
        '
        Me.is_null.DataPropertyName = "is_null"
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        Me.is_null.DefaultCellStyle = DataGridViewCellStyle11
        Me.is_null.HeaderText = "is_null"
        Me.is_null.Name = "is_null"
        Me.is_null.Visible = False
        '
        'Short_null
        '
        Me.Short_null.DataPropertyName = "Short_null"
        Me.Short_null.HeaderText = "Short_null"
        Me.Short_null.Name = "Short_null"
        Me.Short_null.ReadOnly = True
        Me.Short_null.Visible = False
        '
        'idTspType
        '
        Me.idTspType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.idTspType.DataPropertyName = "idTspType"
        Me.idTspType.HeaderText = "idTspType"
        Me.idTspType.Name = "idTspType"
        Me.idTspType.Visible = False
        '
        'frmSlTransportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1074, 491)
        Me.Controls.Add(Me.CbShowTsp)
        Me.Controls.Add(Me.ComboTspType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvData1)
        Me.MaximizeBox = False
        Me.Name = "frmSlTransportData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลการขนส่ง"
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvData1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdTspName As System.Windows.Forms.RadioButton
    Friend WithEvents RdTspShort As System.Windows.Forms.RadioButton
    Friend WithEvents Rdimportance As System.Windows.Forms.RadioButton
    Friend WithEvents ComboTspType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbShowTsp As System.Windows.Forms.CheckBox
    Friend WithEvents idTsp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents editTranSport As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents importance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TspShort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TspName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TspTel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TspArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TspAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TspTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TspNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents is_null As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Short_null As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idTspType As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
