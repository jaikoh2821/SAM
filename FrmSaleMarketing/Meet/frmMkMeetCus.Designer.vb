<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkMeetCus
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkMeetCus))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvData1 = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_save = New System.Windows.Forms.Button
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.change = New System.Windows.Forms.DataGridViewImageColumn
        Me.MeetName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MeetNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.del = New System.Windows.Forms.DataGridViewImageColumn
        Me.idMeet = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData1
        '
        Me.dgvData1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.change, Me.MeetName, Me.MeetNote, Me.del, Me.idMeet})
        Me.dgvData1.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvData1.Location = New System.Drawing.Point(0, 0)
        Me.dgvData1.Name = "dgvData1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvData1.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvData1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvData1.Size = New System.Drawing.Size(637, 377)
        Me.dgvData1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 379)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(637, 39)
        Me.Panel3.TabIndex = 621
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.Frozen = True
        Me.DataGridViewImageColumn1.HeaderText = "เลือก"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Visible = False
        Me.DataGridViewImageColumn1.Width = 35
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.Frozen = True
        Me.DataGridViewImageColumn2.HeaderText = "ลบ"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.Width = 35
        '
        'colautonum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colautonum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colautonum.Width = 45
        '
        'change
        '
        Me.change.HeaderText = "เลือก"
        Me.change.Image = CType(resources.GetObject("change.Image"), System.Drawing.Image)
        Me.change.Name = "change"
        Me.change.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.change.Visible = False
        Me.change.Width = 35
        '
        'MeetName
        '
        Me.MeetName.DataPropertyName = "MeetName"
        DataGridViewCellStyle3.Format = "000"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.MeetName.DefaultCellStyle = DataGridViewCellStyle3
        Me.MeetName.HeaderText = "หัวข้อการเข้าพบคู่ค้า"
        Me.MeetName.Name = "MeetName"
        Me.MeetName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MeetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MeetName.Width = 220
        '
        'MeetNote
        '
        Me.MeetNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MeetNote.DataPropertyName = "MeetNote"
        Me.MeetNote.HeaderText = "หมายเหตุ"
        Me.MeetNote.Name = "MeetNote"
        Me.MeetNote.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MeetNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'del
        '
        Me.del.HeaderText = "ลบ"
        Me.del.Image = CType(resources.GetObject("del.Image"), System.Drawing.Image)
        Me.del.Name = "del"
        Me.del.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.del.Width = 35
        '
        'idMeet
        '
        Me.idMeet.DataPropertyName = "idMeet"
        Me.idMeet.HeaderText = "idMeet"
        Me.idMeet.Name = "idMeet"
        Me.idMeet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.idMeet.Visible = False
        '
        'frmMkMeetCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(637, 418)
        Me.Controls.Add(Me.dgvData1)
        Me.Controls.Add(Me.Panel3)
        Me.MaximizeBox = False
        Me.Name = "frmMkMeetCus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลหัวข้อการเข้าพบคู่ค้า"
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvData1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents change As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MeetName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeetNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents del As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents idMeet As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
