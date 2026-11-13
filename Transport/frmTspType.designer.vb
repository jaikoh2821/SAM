<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTspType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTspType))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvData1 = New System.Windows.Forms.DataGridView()
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TspTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.idTspType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(82, 39)
        Me.btn_save.TabIndex = 415
        Me.btn_save.Tag = ""
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 382)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(589, 39)
        Me.Panel3.TabIndex = 619
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.Frozen = True
        Me.DataGridViewImageColumn1.HeaderText = "ลบ"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.Width = 35
        '
        'dgvData1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.ColCode, Me.TspTypeName, Me.Note, Me.del, Me.idTspType, Me.sort})
        Me.dgvData1.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvData1.Location = New System.Drawing.Point(0, 0)
        Me.dgvData1.Name = "dgvData1"
        Me.dgvData1.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvData1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvData1.Size = New System.Drawing.Size(589, 379)
        Me.dgvData1.TabIndex = 620
        '
        'colautonum
        '
        Me.colautonum.DataPropertyName = "colautonum"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colautonum.Width = 45
        '
        'ColCode
        '
        Me.ColCode.DataPropertyName = "TspCode"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColCode.HeaderText = "รหัสขนส่ง"
        Me.ColCode.Name = "ColCode"
        Me.ColCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TspTypeName
        '
        Me.TspTypeName.DataPropertyName = "TspTypeName"
        Me.TspTypeName.HeaderText = "ประเภทการขนส่ง"
        Me.TspTypeName.Name = "TspTypeName"
        Me.TspTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TspTypeName.Width = 220
        '
        'Note
        '
        Me.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Note.DataPropertyName = "Note"
        Me.Note.HeaderText = "หมายเหตุ"
        Me.Note.Name = "Note"
        Me.Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'del
        '
        Me.del.HeaderText = "ลบ"
        Me.del.Image = CType(resources.GetObject("del.Image"), System.Drawing.Image)
        Me.del.Name = "del"
        Me.del.Width = 35
        '
        'idTspType
        '
        Me.idTspType.DataPropertyName = "idTspType"
        Me.idTspType.HeaderText = "idTspType"
        Me.idTspType.Name = "idTspType"
        Me.idTspType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.idTspType.Visible = False
        '
        'sort
        '
        Me.sort.DataPropertyName = "sort"
        Me.sort.HeaderText = "sort"
        Me.sort.Name = "sort"
        Me.sort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sort.Visible = False
        '
        'frmTspType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 421)
        Me.Controls.Add(Me.dgvData1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frmTspType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ประเภทการขนส่ง"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgvData1 As System.Windows.Forms.DataGridView
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TspTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents del As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents idTspType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sort As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
