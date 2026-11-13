<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkTargetYear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkTargetYear))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btn_YM = New System.Windows.Forms.Button
        Me.txt_Y = New System.Windows.Forms.TextBox
        Me.DGV_YM = New System.Windows.Forms.DataGridView
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colYM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coledit = New System.Windows.Forms.DataGridViewImageColumn
        Me.colMouth = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTarget = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_TargetY = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_addYM = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_save = New System.Windows.Forms.Button
        Me.txt_TotalNetY = New System.Windows.Forms.TextBox
        Me.lb_Y = New System.Windows.Forms.Label
        Me.txt_PerY = New System.Windows.Forms.TextBox
        Me.lb_PerY = New System.Windows.Forms.Label
        CType(Me.DGV_YM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_YM
        '
        Me.btn_YM.BackColor = System.Drawing.Color.DimGray
        Me.btn_YM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_YM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_YM.ForeColor = System.Drawing.Color.White
        Me.btn_YM.Image = CType(resources.GetObject("btn_YM.Image"), System.Drawing.Image)
        Me.btn_YM.Location = New System.Drawing.Point(116, 11)
        Me.btn_YM.Name = "btn_YM"
        Me.btn_YM.Size = New System.Drawing.Size(28, 25)
        Me.btn_YM.TabIndex = 645
        Me.btn_YM.Tag = "Add"
        Me.btn_YM.UseVisualStyleBackColor = False
        '
        'txt_Y
        '
        Me.txt_Y.Enabled = False
        Me.txt_Y.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Y.Location = New System.Drawing.Point(52, 12)
        Me.txt_Y.Name = "txt_Y"
        Me.txt_Y.ReadOnly = True
        Me.txt_Y.Size = New System.Drawing.Size(58, 24)
        Me.txt_Y.TabIndex = 646
        '
        'DGV_YM
        '
        Me.DGV_YM.AllowUserToAddRows = False
        Me.DGV_YM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_YM.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_YM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DGV_YM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_YM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colYM, Me.coledit, Me.colMouth, Me.colTarget})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_YM.DefaultCellStyle = DataGridViewCellStyle15
        Me.DGV_YM.Location = New System.Drawing.Point(0, 133)
        Me.DGV_YM.Name = "DGV_YM"
        Me.DGV_YM.RowHeadersVisible = False
        Me.DGV_YM.Size = New System.Drawing.Size(403, 316)
        Me.DGV_YM.TabIndex = 647
        '
        'colautonum
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Gainsboro
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle12
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Width = 50
        '
        'colYM
        '
        Me.colYM.DataPropertyName = "YM"
        Me.colYM.HeaderText = "YM"
        Me.colYM.Name = "colYM"
        Me.colYM.ReadOnly = True
        Me.colYM.Visible = False
        '
        'coledit
        '
        Me.coledit.HeaderText = "แก้ไข"
        Me.coledit.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.coledit.Name = "coledit"
        Me.coledit.ReadOnly = True
        Me.coledit.Width = 50
        '
        'colMouth
        '
        Me.colMouth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMouth.DataPropertyName = "Mouth"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Gainsboro
        Me.colMouth.DefaultCellStyle = DataGridViewCellStyle13
        Me.colMouth.HeaderText = "เดือน"
        Me.colMouth.Name = "colMouth"
        Me.colMouth.ReadOnly = True
        '
        'colTarget
        '
        Me.colTarget.DataPropertyName = "Target"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.colTarget.DefaultCellStyle = DataGridViewCellStyle14
        Me.colTarget.HeaderText = "เป้ายอดขาย"
        Me.colTarget.Name = "colTarget"
        Me.colTarget.ReadOnly = True
        Me.colTarget.Width = 120
        '
        'txt_TargetY
        '
        Me.txt_TargetY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_TargetY.Location = New System.Drawing.Point(262, 13)
        Me.txt_TargetY.Name = "txt_TargetY"
        Me.txt_TargetY.Size = New System.Drawing.Size(120, 24)
        Me.txt_TargetY.TabIndex = 649
        Me.txt_TargetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 650
        Me.Label2.Text = "เป้ายอดขายรวม"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 18)
        Me.Label1.TabIndex = 651
        Me.Label1.Text = "ปี"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.btn_addYM)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(403, 24)
        Me.Panel2.TabIndex = 652
        '
        'btn_addYM
        '
        Me.btn_addYM.Enabled = False
        Me.btn_addYM.Location = New System.Drawing.Point(301, 0)
        Me.btn_addYM.Name = "btn_addYM"
        Me.btn_addYM.Size = New System.Drawing.Size(99, 23)
        Me.btn_addYM.TabIndex = 1
        Me.btn_addYM.Text = "เพิ่มเป้ายอดขาย"
        Me.btn_addYM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(128, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เป้ายอดขายแต่ละเดือน"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Location = New System.Drawing.Point(0, 442)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 40)
        Me.Panel1.TabIndex = 653
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.Location = New System.Drawing.Point(2, 1)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(107, 38)
        Me.btn_save.TabIndex = 414
        Me.btn_save.Tag = ""
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txt_TotalNetY
        '
        Me.txt_TotalNetY.BackColor = System.Drawing.Color.Black
        Me.txt_TotalNetY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TotalNetY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_TotalNetY.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_TotalNetY.Location = New System.Drawing.Point(262, 43)
        Me.txt_TotalNetY.Name = "txt_TotalNetY"
        Me.txt_TotalNetY.Size = New System.Drawing.Size(120, 24)
        Me.txt_TotalNetY.TabIndex = 655
        Me.txt_TotalNetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_Y
        '
        Me.lb_Y.AutoSize = True
        Me.lb_Y.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_Y.ForeColor = System.Drawing.Color.Black
        Me.lb_Y.Location = New System.Drawing.Point(68, 45)
        Me.lb_Y.Name = "lb_Y"
        Me.lb_Y.Size = New System.Drawing.Size(98, 18)
        Me.lb_Y.TabIndex = 654
        Me.lb_Y.Text = "ยอดขายปีก่อน"
        '
        'txt_PerY
        '
        Me.txt_PerY.BackColor = System.Drawing.Color.Black
        Me.txt_PerY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PerY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_PerY.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_PerY.Location = New System.Drawing.Point(312, 73)
        Me.txt_PerY.Name = "txt_PerY"
        Me.txt_PerY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_PerY.Size = New System.Drawing.Size(70, 24)
        Me.txt_PerY.TabIndex = 657
        Me.txt_PerY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_PerY
        '
        Me.lb_PerY.AutoSize = True
        Me.lb_PerY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_PerY.ForeColor = System.Drawing.Color.Black
        Me.lb_PerY.Location = New System.Drawing.Point(68, 75)
        Me.lb_PerY.Name = "lb_PerY"
        Me.lb_PerY.Size = New System.Drawing.Size(205, 18)
        Me.lb_PerY.TabIndex = 656
        Me.lb_PerY.Text = "เปอร์เซ็นส่วนต่างยอดขายปีก่อน"
        '
        'frmMkTargetYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(403, 482)
        Me.Controls.Add(Me.txt_PerY)
        Me.Controls.Add(Me.lb_PerY)
        Me.Controls.Add(Me.txt_TotalNetY)
        Me.Controls.Add(Me.lb_Y)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_TargetY)
        Me.Controls.Add(Me.DGV_YM)
        Me.Controls.Add(Me.txt_Y)
        Me.Controls.Add(Me.btn_YM)
        Me.Name = "frmMkTargetYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กำหนดเป้าประจำปี"
        CType(Me.DGV_YM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_YM As System.Windows.Forms.Button
    Friend WithEvents txt_Y As System.Windows.Forms.TextBox
    Friend WithEvents DGV_YM As System.Windows.Forms.DataGridView
    Friend WithEvents txt_TargetY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_TotalNetY As System.Windows.Forms.TextBox
    Friend WithEvents lb_Y As System.Windows.Forms.Label
    Friend WithEvents txt_PerY As System.Windows.Forms.TextBox
    Friend WithEvents lb_PerY As System.Windows.Forms.Label
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colYM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coledit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colMouth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTarget As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_addYM As System.Windows.Forms.Button
End Class
