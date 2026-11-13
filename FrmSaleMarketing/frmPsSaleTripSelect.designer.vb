<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPsSaleTripSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPsSaleTripSelect))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btShow = New System.Windows.Forms.Button
        Me.dgvPsSaleTrip = New System.Windows.Forms.DataGridView
        Me.lbPsSaleSelect = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpPsSaleTrip = New System.Windows.Forms.DateTimePicker
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn
        Me.DateTripS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTripE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStTrip = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idTrip = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idProvince = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idAp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idSup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stTrip = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPsSaleTrip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เจ้าหน้าที่ขาย : "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btShow)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 37)
        Me.Panel2.TabIndex = 425
        '
        'btShow
        '
        Me.btShow.BackColor = System.Drawing.Color.DimGray
        Me.btShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btShow.ForeColor = System.Drawing.Color.White
        Me.btShow.Image = CType(resources.GetObject("btShow.Image"), System.Drawing.Image)
        Me.btShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btShow.Location = New System.Drawing.Point(0, 0)
        Me.btShow.Name = "btShow"
        Me.btShow.Size = New System.Drawing.Size(115, 35)
        Me.btShow.TabIndex = 397
        Me.btShow.Tag = ""
        Me.btShow.Text = "       แสดงข้อมูล"
        Me.btShow.UseVisualStyleBackColor = False
        '
        'dgvPsSaleTrip
        '
        Me.dgvPsSaleTrip.AllowUserToAddRows = False
        Me.dgvPsSaleTrip.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPsSaleTrip.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPsSaleTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPsSaleTrip.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEdit, Me.DateTripS, Me.DateTripE, Me.colStTrip, Me.colSup, Me.colPv, Me.colAp, Me.colNote, Me.idTrip, Me.idProvince, Me.idAp, Me.idSup, Me.stTrip})
        Me.dgvPsSaleTrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvPsSaleTrip.Location = New System.Drawing.Point(0, 127)
        Me.dgvPsSaleTrip.Name = "dgvPsSaleTrip"
        Me.dgvPsSaleTrip.ReadOnly = True
        Me.dgvPsSaleTrip.RowHeadersVisible = False
        Me.dgvPsSaleTrip.Size = New System.Drawing.Size(792, 269)
        Me.dgvPsSaleTrip.TabIndex = 424
        '
        'lbPsSaleSelect
        '
        Me.lbPsSaleSelect.BackColor = System.Drawing.Color.Gainsboro
        Me.lbPsSaleSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPsSaleSelect.Location = New System.Drawing.Point(137, 10)
        Me.lbPsSaleSelect.Name = "lbPsSaleSelect"
        Me.lbPsSaleSelect.Size = New System.Drawing.Size(203, 20)
        Me.lbPsSaleSelect.TabIndex = 518
        Me.lbPsSaleSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 519
        Me.Label2.Text = "ระบุเดือน และ ปี : "
        '
        'dtpPsSaleTrip
        '
        Me.dtpPsSaleTrip.CustomFormat = "MMMM/yyyy"
        Me.dtpPsSaleTrip.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPsSaleTrip.Location = New System.Drawing.Point(137, 47)
        Me.dtpPsSaleTrip.MinimumSize = New System.Drawing.Size(4, 30)
        Me.dtpPsSaleTrip.Name = "dtpPsSaleTrip"
        Me.dtpPsSaleTrip.ShowUpDown = True
        Me.dtpPsSaleTrip.Size = New System.Drawing.Size(200, 30)
        Me.dtpPsSaleTrip.TabIndex = 520
        Me.dtpPsSaleTrip.Value = New Date(2013, 10, 31, 16, 15, 38, 0)
        '
        'colEdit
        '
        Me.colEdit.HeaderText = "เลือก"
        Me.colEdit.Image = Global.SAM.My.Resources.Resources.CancelCheck
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Width = 50
        '
        'DateTripS
        '
        Me.DateTripS.DataPropertyName = "DateTripS"
        Me.DateTripS.HeaderText = "วันที่เริ่ม"
        Me.DateTripS.Name = "DateTripS"
        Me.DateTripS.ReadOnly = True
        Me.DateTripS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DateTripS.Width = 80
        '
        'DateTripE
        '
        Me.DateTripE.DataPropertyName = "DateTripE"
        Me.DateTripE.HeaderText = "วันที่สิ้นสุด"
        Me.DateTripE.Name = "DateTripE"
        Me.DateTripE.ReadOnly = True
        Me.DateTripE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DateTripE.Width = 80
        '
        'colStTrip
        '
        Me.colStTrip.DataPropertyName = "colStTrip"
        Me.colStTrip.HeaderText = "ประเภทการเบิกค่าใช้จ่าย"
        Me.colStTrip.Name = "colStTrip"
        Me.colStTrip.ReadOnly = True
        Me.colStTrip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colStTrip.Width = 130
        '
        'colSup
        '
        Me.colSup.DataPropertyName = "colSup"
        Me.colSup.HeaderText = "ที่พักหรือร้านอาหาร"
        Me.colSup.Name = "colSup"
        Me.colSup.ReadOnly = True
        Me.colSup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colSup.Width = 130
        '
        'colPv
        '
        Me.colPv.DataPropertyName = "PvName"
        Me.colPv.HeaderText = "จังหวัด"
        Me.colPv.Name = "colPv"
        Me.colPv.ReadOnly = True
        Me.colPv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colAp
        '
        Me.colAp.DataPropertyName = "ApName"
        Me.colAp.HeaderText = "อำเภอ"
        Me.colAp.Name = "colAp"
        Me.colAp.ReadOnly = True
        Me.colAp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colNote
        '
        Me.colNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNote.DataPropertyName = "Note"
        Me.colNote.HeaderText = "หมายเหตุ"
        Me.colNote.Name = "colNote"
        Me.colNote.ReadOnly = True
        Me.colNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'idTrip
        '
        Me.idTrip.DataPropertyName = "idTrip"
        Me.idTrip.HeaderText = "idTrip"
        Me.idTrip.Name = "idTrip"
        Me.idTrip.ReadOnly = True
        Me.idTrip.Visible = False
        '
        'idProvince
        '
        Me.idProvince.DataPropertyName = "idProvince"
        Me.idProvince.HeaderText = "idProvince"
        Me.idProvince.Name = "idProvince"
        Me.idProvince.ReadOnly = True
        Me.idProvince.Visible = False
        '
        'idAp
        '
        Me.idAp.DataPropertyName = "idAp"
        Me.idAp.HeaderText = "idAp"
        Me.idAp.Name = "idAp"
        Me.idAp.ReadOnly = True
        Me.idAp.Visible = False
        '
        'idSup
        '
        Me.idSup.DataPropertyName = "idSup"
        Me.idSup.HeaderText = "idSup"
        Me.idSup.Name = "idSup"
        Me.idSup.ReadOnly = True
        Me.idSup.Visible = False
        '
        'stTrip
        '
        Me.stTrip.DataPropertyName = "stTrip"
        Me.stTrip.HeaderText = "stTrip"
        Me.stTrip.Name = "stTrip"
        Me.stTrip.ReadOnly = True
        Me.stTrip.Visible = False
        '
        'frmPsSaleTripSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(792, 396)
        Me.Controls.Add(Me.dtpPsSaleTrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbPsSaleSelect)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvPsSaleTrip)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPsSaleTripSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trip เจ้าหน้าที่ขาย"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvPsSaleTrip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btShow As System.Windows.Forms.Button
    Friend WithEvents dgvPsSaleTrip As System.Windows.Forms.DataGridView
    Friend WithEvents lbPsSaleSelect As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpPsSaleTrip As System.Windows.Forms.DateTimePicker
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DateTripS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTripE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStTrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idTrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProvince As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idAp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idSup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stTrip As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
