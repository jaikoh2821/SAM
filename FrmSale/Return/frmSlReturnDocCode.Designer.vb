<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlReturnDocCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlReturnDocCode))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvReturnCode = New System.Windows.Forms.DataGridView()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.ColidRTDocCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColReturnCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDel = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgvReturnCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvReturnCode
        '
        Me.dgvReturnCode.AllowUserToDeleteRows = False
        Me.dgvReturnCode.AllowUserToResizeColumns = False
        Me.dgvReturnCode.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturnCode.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReturnCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnCode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColidRTDocCode, Me.ColReturnCode, Me.ColNote, Me.ColDel})
        Me.dgvReturnCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReturnCode.Location = New System.Drawing.Point(0, 34)
        Me.dgvReturnCode.Name = "dgvReturnCode"
        Me.dgvReturnCode.RowHeadersVisible = False
        Me.dgvReturnCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvReturnCode.Size = New System.Drawing.Size(344, 427)
        Me.dgvReturnCode.TabIndex = 1
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(88, 34)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btn_save)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(344, 34)
        Me.PanelControl3.TabIndex = 729
        '
        'ColidRTDocCode
        '
        Me.ColidRTDocCode.DataPropertyName = "idRTDocCode"
        Me.ColidRTDocCode.HeaderText = "idRTDocCode"
        Me.ColidRTDocCode.Name = "ColidRTDocCode"
        Me.ColidRTDocCode.Visible = False
        '
        'ColReturnCode
        '
        Me.ColReturnCode.DataPropertyName = "ReturnCode"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColReturnCode.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColReturnCode.HeaderText = "รหัสเอกสาร"
        Me.ColReturnCode.Name = "ColReturnCode"
        Me.ColReturnCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColReturnCode.Width = 120
        '
        'ColNote
        '
        Me.ColNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColNote.DataPropertyName = "Note"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ColNote.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColNote.HeaderText = "คำอธิบาย"
        Me.ColNote.Name = "ColNote"
        Me.ColNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColDel
        '
        Me.ColDel.HeaderText = "ลบ"
        Me.ColDel.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.ColDel.Name = "ColDel"
        Me.ColDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColDel.Visible = False
        Me.ColDel.Width = 40
        '
        'frmSlReturnDocCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(344, 461)
        Me.Controls.Add(Me.dgvReturnCode)
        Me.Controls.Add(Me.PanelControl3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSlReturnDocCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่ม/แก้ไข รหัสเอกสารการคืนสินค้า"
        CType(Me.dgvReturnCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvReturnCode As System.Windows.Forms.DataGridView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents ColidRTDocCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColReturnCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
End Class
