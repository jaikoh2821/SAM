<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkGiftCauseData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkGiftCauseData))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSave = New System.Windows.Forms.Button
        Me.dgv_GiftCus = New System.Windows.Forms.DataGridView
        Me.ColidGC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCase = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Colnote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDel = New System.Windows.Forms.DataGridViewImageColumn
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_GiftCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 40)
        Me.Panel2.TabIndex = 543
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(3, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 39)
        Me.btnSave.TabIndex = 95
        Me.btnSave.Tag = "Save"
        Me.btnSave.Text = "       บันทึก"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dgv_GiftCus
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_GiftCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_GiftCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_GiftCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColidGC, Me.ColCase, Me.Colnote, Me.colDel})
        Me.dgv_GiftCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_GiftCus.Location = New System.Drawing.Point(0, 0)
        Me.dgv_GiftCus.Name = "dgv_GiftCus"
        Me.dgv_GiftCus.Size = New System.Drawing.Size(634, 422)
        Me.dgv_GiftCus.TabIndex = 542
        '
        'ColidGC
        '
        Me.ColidGC.DataPropertyName = "idGC"
        Me.ColidGC.HeaderText = "idGC"
        Me.ColidGC.Name = "ColidGC"
        Me.ColidGC.Visible = False
        '
        'ColCase
        '
        Me.ColCase.DataPropertyName = "Cause"
        Me.ColCase.HeaderText = "วัตถุประสงค์การแจกสิ่งของ"
        Me.ColCase.Name = "ColCase"
        Me.ColCase.Width = 280
        '
        'Colnote
        '
        Me.Colnote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Colnote.DataPropertyName = "Note"
        Me.Colnote.HeaderText = "หมายเหตุ"
        Me.Colnote.Name = "Colnote"
        '
        'colDel
        '
        Me.colDel.HeaderText = ""
        Me.colDel.Name = "colDel"
        Me.colDel.Width = 40
        '
        'frmMkGiftCauseData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(634, 462)
        Me.Controls.Add(Me.dgv_GiftCus)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmMkGiftCauseData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "วัตถุประสงค์การแจกสิ่งของ"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_GiftCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgv_GiftCus As System.Windows.Forms.DataGridView
    Friend WithEvents ColidGC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colnote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDel As System.Windows.Forms.DataGridViewImageColumn
End Class
