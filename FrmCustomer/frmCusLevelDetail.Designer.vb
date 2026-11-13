<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusLevelDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusLevelDetail))
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtpr = New System.Windows.Forms.TextBox
        Me.txtpb = New System.Windows.Forms.TextBox
        Me.txtnote = New System.Windows.Forms.TextBox
        Me.txtpw = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCreditTotal = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(200, 33)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(254, 20)
        Me.txtname.TabIndex = 0
        '
        'txtpr
        '
        Me.txtpr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpr.Location = New System.Drawing.Point(200, 63)
        Me.txtpr.Name = "txtpr"
        Me.txtpr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpr.Size = New System.Drawing.Size(72, 20)
        Me.txtpr.TabIndex = 1
        '
        'txtpb
        '
        Me.txtpb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpb.Location = New System.Drawing.Point(200, 95)
        Me.txtpb.Name = "txtpb"
        Me.txtpb.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpb.Size = New System.Drawing.Size(72, 20)
        Me.txtpb.TabIndex = 2
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(200, 194)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(254, 97)
        Me.txtnote.TabIndex = 3
        '
        'txtpw
        '
        Me.txtpw.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpw.Location = New System.Drawing.Point(200, 128)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpw.Size = New System.Drawing.Size(72, 20)
        Me.txtpw.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ราคาปลีกถูกลง (%)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ชื่อระดับ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ราคาหน้าบิลถูกลง (%)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ราคาส่งถูกลง (%)"
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(8, -1)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 40)
        Me.btn_save.TabIndex = 418
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.AutoSize = True
        Me.btn_delete.BackColor = System.Drawing.Color.DimGray
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Image = Global.SAM.My.Resources.Resources.Del28
        Me.btn_delete.Location = New System.Drawing.Point(103, -1)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(96, 40)
        Me.btn_delete.TabIndex = 610
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 611
        Me.Label5.Text = "คำอธิบายระดับ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(110, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 17)
        Me.Label7.TabIndex = 613
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(71, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 17)
        Me.Label8.TabIndex = 614
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 616
        Me.Label9.Text = "กำหนดวงเงินเครดิต"
        '
        'txtCreditTotal
        '
        Me.txtCreditTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCreditTotal.Location = New System.Drawing.Point(200, 160)
        Me.txtCreditTotal.Name = "txtCreditTotal"
        Me.txtCreditTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCreditTotal.Size = New System.Drawing.Size(72, 20)
        Me.txtCreditTotal.TabIndex = 615
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 317)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(481, 40)
        Me.Panel2.TabIndex = 617
        '
        'frmCusLevelDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(481, 357)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCreditTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.txtpb)
        Me.Controls.Add(Me.txtpr)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmCusLevelDetail"
        Me.Text = "ข้อมูลระดับลูกค้า"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpr As System.Windows.Forms.TextBox
    Friend WithEvents txtpb As System.Windows.Forms.TextBox
    Friend WithEvents txtnote As System.Windows.Forms.TextBox
    Friend WithEvents txtpw As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCreditTotal As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
