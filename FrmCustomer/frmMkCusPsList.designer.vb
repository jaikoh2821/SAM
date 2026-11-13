<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkCusPsList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtnamecus = New System.Windows.Forms.Label()
        Me.txtaddcus = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPersonName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnamecus
        '
        Me.txtnamecus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnamecus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtnamecus.Location = New System.Drawing.Point(87, 11)
        Me.txtnamecus.Name = "txtnamecus"
        Me.txtnamecus.Size = New System.Drawing.Size(309, 23)
        Me.txtnamecus.TabIndex = 420
        Me.txtnamecus.Text = "ชื่อ"
        '
        'txtaddcus
        '
        Me.txtaddcus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddcus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtaddcus.Location = New System.Drawing.Point(87, 40)
        Me.txtaddcus.Name = "txtaddcus"
        Me.txtaddcus.Size = New System.Drawing.Size(309, 51)
        Me.txtaddcus.TabIndex = 419
        Me.txtaddcus.Text = "ที่อยู่"
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
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colPersonName})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvData.Location = New System.Drawing.Point(0, 107)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(492, 355)
        Me.dgvData.TabIndex = 416
        '
        'colautonum
        '
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.Width = 35
        '
        'colPersonName
        '
        Me.colPersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPersonName.DataPropertyName = "PsName"
        Me.colPersonName.HeaderText = "ชื่อเจ้าหน้าที่"
        Me.colPersonName.Name = "colPersonName"
        Me.colPersonName.ReadOnly = True
        '
        'frmMkCusPsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(492, 462)
        Me.Controls.Add(Me.txtnamecus)
        Me.Controls.Add(Me.txtaddcus)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "frmMkCusPsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลพนักงานขายที่ดูแลลูกค้า"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtnamecus As System.Windows.Forms.Label
    Friend WithEvents txtaddcus As System.Windows.Forms.Label
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPersonName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
