<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkTarget
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Target = New System.Windows.Forms.TextBox
        Me.DGV_MK = New System.Windows.Forms.DataGridView
        Me.coldel = New System.Windows.Forms.DataGridViewImageColumn
        Me.colPdTName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidPdT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPayY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPayM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTarget = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTargetKg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_del = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_addPdT = New System.Windows.Forms.Button
        Me.lb_Y = New System.Windows.Forms.Label
        Me.lb_M = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.lb_PerY = New System.Windows.Forms.Label
        Me.lb_PerM = New System.Windows.Forms.Label
        Me.txt_TotalNetY = New System.Windows.Forms.TextBox
        Me.txt_TotalNetM = New System.Windows.Forms.TextBox
        Me.txt_PerY = New System.Windows.Forms.TextBox
        Me.txt_PerM = New System.Windows.Forms.TextBox
        Me.cbMouth = New System.Windows.Forms.ComboBox
        CType(Me.DGV_MK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "เดือน/ปี"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 637
        Me.Label2.Text = "เป้ายอดขายรวม"
        '
        'txt_Target
        '
        Me.txt_Target.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Target.Location = New System.Drawing.Point(116, 93)
        Me.txt_Target.Name = "txt_Target"
        Me.txt_Target.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Target.Size = New System.Drawing.Size(136, 24)
        Me.txt_Target.TabIndex = 638
        Me.txt_Target.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DGV_MK
        '
        Me.DGV_MK.AllowUserToAddRows = False
        Me.DGV_MK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_MK.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_MK.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_MK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_MK.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldel, Me.colPdTName, Me.colidPdT, Me.colPayY, Me.colPayM, Me.colTarget, Me.colTargetKg})
        Me.DGV_MK.Location = New System.Drawing.Point(1, 167)
        Me.DGV_MK.Name = "DGV_MK"
        Me.DGV_MK.RowHeadersVisible = False
        Me.DGV_MK.Size = New System.Drawing.Size(689, 359)
        Me.DGV_MK.TabIndex = 639
        '
        'coldel
        '
        Me.coldel.HeaderText = "ลบ"
        Me.coldel.Image = Global.SAM.My.Resources.Resources.ImgNotprocess
        Me.coldel.Name = "coldel"
        Me.coldel.Width = 60
        '
        'colPdTName
        '
        Me.colPdTName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPdTName.DataPropertyName = "PdTradeName"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.colPdTName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPdTName.HeaderText = "สินค้า"
        Me.colPdTName.Name = "colPdTName"
        Me.colPdTName.ReadOnly = True
        '
        'colidPdT
        '
        Me.colidPdT.DataPropertyName = "idPdT"
        Me.colidPdT.HeaderText = "idPdT"
        Me.colidPdT.Name = "colidPdT"
        Me.colidPdT.ReadOnly = True
        Me.colidPdT.Visible = False
        '
        'colPayY
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colPayY.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPayY.HeaderText = "ยอดขายเดือนนี้ปีที่แล้ว"
        Me.colPayY.Name = "colPayY"
        Me.colPayY.ReadOnly = True
        Me.colPayY.Width = 120
        '
        'colPayM
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colPayM.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPayM.HeaderText = "ยอดขายเดือนที่แล้ว"
        Me.colPayM.Name = "colPayM"
        Me.colPayM.ReadOnly = True
        Me.colPayM.Width = 120
        '
        'colTarget
        '
        Me.colTarget.DataPropertyName = "Target"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.colTarget.DefaultCellStyle = DataGridViewCellStyle5
        Me.colTarget.HeaderText = "เป้ายอดขาย"
        Me.colTarget.Name = "colTarget"
        Me.colTarget.Width = 120
        '
        'colTargetKg
        '
        Me.colTargetKg.DataPropertyName = "TargetKg"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.colTargetKg.DefaultCellStyle = DataGridViewCellStyle6
        Me.colTargetKg.HeaderText = "เป้ายอดขาย(นน.)"
        Me.colTargetKg.Name = "colTargetKg"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.btn_del)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Location = New System.Drawing.Point(1, 526)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 40)
        Me.Panel1.TabIndex = 637
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.DimGray
        Me.btn_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_del.ForeColor = System.Drawing.Color.White
        Me.btn_del.Image = Global.SAM.My.Resources.Resources.ImgNotprocess
        Me.btn_del.Location = New System.Drawing.Point(115, 1)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(67, 38)
        Me.btn_del.TabIndex = 415
        Me.btn_del.Tag = ""
        Me.btn_del.Text = "ลบ"
        Me.btn_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_del.UseVisualStyleBackColor = False
        Me.btn_del.Visible = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
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
        'btn_addPdT
        '
        Me.btn_addPdT.Location = New System.Drawing.Point(600, 0)
        Me.btn_addPdT.Name = "btn_addPdT"
        Me.btn_addPdT.Size = New System.Drawing.Size(75, 23)
        Me.btn_addPdT.TabIndex = 640
        Me.btn_addPdT.Text = "เลือกสินค้า"
        Me.btn_addPdT.UseVisualStyleBackColor = True
        '
        'lb_Y
        '
        Me.lb_Y.AutoSize = True
        Me.lb_Y.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_Y.ForeColor = System.Drawing.Color.Black
        Me.lb_Y.Location = New System.Drawing.Point(295, 9)
        Me.lb_Y.Name = "lb_Y"
        Me.lb_Y.Size = New System.Drawing.Size(98, 18)
        Me.lb_Y.TabIndex = 646
        Me.lb_Y.Text = "ยอดขายปีก่อน"
        '
        'lb_M
        '
        Me.lb_M.AutoSize = True
        Me.lb_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_M.ForeColor = System.Drawing.Color.Black
        Me.lb_M.Location = New System.Drawing.Point(295, 41)
        Me.lb_M.Name = "lb_M"
        Me.lb_M.Size = New System.Drawing.Size(121, 18)
        Me.lb_M.TabIndex = 647
        Me.lb_M.Text = "ยอดขายเดือนก่อน"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btn_addPdT)
        Me.Panel2.Location = New System.Drawing.Point(0, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 24)
        Me.Panel2.TabIndex = 648
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(268, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เป้ายอดขายเฉพาะสินค้า"
        '
        'lb_PerY
        '
        Me.lb_PerY.AutoSize = True
        Me.lb_PerY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_PerY.ForeColor = System.Drawing.Color.Black
        Me.lb_PerY.Location = New System.Drawing.Point(295, 79)
        Me.lb_PerY.Name = "lb_PerY"
        Me.lb_PerY.Size = New System.Drawing.Size(205, 18)
        Me.lb_PerY.TabIndex = 646
        Me.lb_PerY.Text = "เปอร์เซ็นส่วนต่างยอดขายปีก่อน"
        '
        'lb_PerM
        '
        Me.lb_PerM.AutoSize = True
        Me.lb_PerM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_PerM.ForeColor = System.Drawing.Color.Black
        Me.lb_PerM.Location = New System.Drawing.Point(295, 110)
        Me.lb_PerM.Name = "lb_PerM"
        Me.lb_PerM.Size = New System.Drawing.Size(228, 18)
        Me.lb_PerM.TabIndex = 647
        Me.lb_PerM.Text = "เปอร์เซ็นส่วนต่างยอดขายเดือนก่อน"
        '
        'txt_TotalNetY
        '
        Me.txt_TotalNetY.BackColor = System.Drawing.Color.Black
        Me.txt_TotalNetY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TotalNetY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_TotalNetY.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_TotalNetY.Location = New System.Drawing.Point(552, 7)
        Me.txt_TotalNetY.Name = "txt_TotalNetY"
        Me.txt_TotalNetY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TotalNetY.Size = New System.Drawing.Size(120, 24)
        Me.txt_TotalNetY.TabIndex = 649
        '
        'txt_TotalNetM
        '
        Me.txt_TotalNetM.BackColor = System.Drawing.Color.Black
        Me.txt_TotalNetM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TotalNetM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_TotalNetM.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_TotalNetM.Location = New System.Drawing.Point(552, 39)
        Me.txt_TotalNetM.Name = "txt_TotalNetM"
        Me.txt_TotalNetM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TotalNetM.Size = New System.Drawing.Size(120, 24)
        Me.txt_TotalNetM.TabIndex = 650
        '
        'txt_PerY
        '
        Me.txt_PerY.BackColor = System.Drawing.Color.Black
        Me.txt_PerY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PerY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_PerY.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_PerY.Location = New System.Drawing.Point(602, 77)
        Me.txt_PerY.Name = "txt_PerY"
        Me.txt_PerY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_PerY.Size = New System.Drawing.Size(70, 24)
        Me.txt_PerY.TabIndex = 650
        '
        'txt_PerM
        '
        Me.txt_PerM.BackColor = System.Drawing.Color.Black
        Me.txt_PerM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PerM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_PerM.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_PerM.Location = New System.Drawing.Point(602, 108)
        Me.txt_PerM.Name = "txt_PerM"
        Me.txt_PerM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_PerM.Size = New System.Drawing.Size(70, 24)
        Me.txt_PerM.TabIndex = 650
        '
        'cbMouth
        '
        Me.cbMouth.FormattingEnabled = True
        Me.cbMouth.Location = New System.Drawing.Point(116, 25)
        Me.cbMouth.Name = "cbMouth"
        Me.cbMouth.Size = New System.Drawing.Size(121, 21)
        Me.cbMouth.TabIndex = 651
        '
        'frmMkTarget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(689, 567)
        Me.Controls.Add(Me.cbMouth)
        Me.Controls.Add(Me.txt_PerM)
        Me.Controls.Add(Me.txt_PerY)
        Me.Controls.Add(Me.txt_TotalNetM)
        Me.Controls.Add(Me.txt_TotalNetY)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lb_PerM)
        Me.Controls.Add(Me.lb_M)
        Me.Controls.Add(Me.lb_PerY)
        Me.Controls.Add(Me.lb_Y)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV_MK)
        Me.Controls.Add(Me.txt_Target)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMkTarget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กำหนดเป้ายอดขาย"
        CType(Me.DGV_MK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Target As System.Windows.Forms.TextBox
    Friend WithEvents DGV_MK As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_addPdT As System.Windows.Forms.Button
    Friend WithEvents lb_Y As System.Windows.Forms.Label
    Friend WithEvents lb_M As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_PerY As System.Windows.Forms.Label
    Friend WithEvents lb_PerM As System.Windows.Forms.Label
    Friend WithEvents txt_TotalNetY As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalNetM As System.Windows.Forms.TextBox
    Friend WithEvents txt_PerY As System.Windows.Forms.TextBox
    Friend WithEvents txt_PerM As System.Windows.Forms.TextBox
    Friend WithEvents cbMouth As System.Windows.Forms.ComboBox
    Friend WithEvents coldel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPdTName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidPdT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTarget As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTargetKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_del As System.Windows.Forms.Button
End Class
