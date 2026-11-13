<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkPromotionPremium
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvPremium = New System.Windows.Forms.DataGridView
        Me.colSelect = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ColidInv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColInvName = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvPremium, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPremium
        '
        Me.dgvPremium.AllowUserToAddRows = False
        Me.dgvPremium.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPremium.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPremium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPremium.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.ColidInv, Me.ColInvName})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPremium.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPremium.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPremium.EnableHeadersVisualStyles = False
        Me.dgvPremium.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPremium.Location = New System.Drawing.Point(0, 0)
        Me.dgvPremium.Name = "dgvPremium"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPremium.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPremium.RowHeadersVisible = False
        Me.dgvPremium.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPremium.Size = New System.Drawing.Size(384, 392)
        Me.dgvPremium.TabIndex = 602
        '
        'colSelect
        '
        Me.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        Me.colSelect.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSelect.HeaderText = "เลือก"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.Width = 41
        '
        'ColidInv
        '
        Me.ColidInv.DataPropertyName = "idInv"
        Me.ColidInv.HeaderText = "idInv"
        Me.ColidInv.Name = "ColidInv"
        Me.ColidInv.Visible = False
        '
        'ColInvName
        '
        Me.ColInvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColInvName.DataPropertyName = "InvName_"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColInvName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColInvName.HeaderText = "สิ่งของ"
        Me.ColInvName.Name = "ColInvName"
        '
        'frmMkPromotionPremium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(384, 392)
        Me.Controls.Add(Me.dgvPremium)
        Me.MaximizeBox = False
        Me.Name = "frmMkPromotionPremium"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกของแถมสำหรับโปรโมชั่น"
        CType(Me.dgvPremium, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPremium As System.Windows.Forms.DataGridView
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColidInv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColInvName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
