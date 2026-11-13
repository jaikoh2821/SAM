<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdPkUnitCalculate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPdPkUnitCalculate))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblUnit = New System.Windows.Forms.Label
        Me.rdbUp = New System.Windows.Forms.RadioButton
        Me.rdbDown = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblPdPkName = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblUnitDown = New System.Windows.Forms.Label
        Me.lblUnitUp = New System.Windows.Forms.Label
        Me.lblAmtDown = New System.Windows.Forms.Label
        Me.lblAmtUp = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblPerbox = New System.Windows.Forms.Label
        Me.lblUnitPerbox = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblWeightBox = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "น้ำหนัก :"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(147, 37)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 1
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(253, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "กิโลกรัม"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAmount.ForeColor = System.Drawing.Color.Red
        Me.txtAmount.Location = New System.Drawing.Point(147, 71)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "จำนวนสินคัา :"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(253, 72)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(45, 15)
        Me.lblUnit.TabIndex = 5
        Me.lblUnit.Text = "Label4"
        '
        'rdbUp
        '
        Me.rdbUp.AutoSize = True
        Me.rdbUp.Checked = True
        Me.rdbUp.Location = New System.Drawing.Point(147, 141)
        Me.rdbUp.Name = "rdbUp"
        Me.rdbUp.Size = New System.Drawing.Size(74, 17)
        Me.rdbUp.TabIndex = 6
        Me.rdbUp.TabStop = True
        Me.rdbUp.Text = "ปัดเศษขึ้น"
        Me.rdbUp.UseVisualStyleBackColor = True
        Me.rdbUp.Visible = False
        '
        'rdbDown
        '
        Me.rdbDown.AutoSize = True
        Me.rdbDown.Location = New System.Drawing.Point(147, 164)
        Me.rdbDown.Name = "rdbDown"
        Me.rdbDown.Size = New System.Drawing.Size(71, 17)
        Me.rdbDown.TabIndex = 7
        Me.rdbDown.TabStop = True
        Me.rdbDown.Text = "ปัดเศษลง"
        Me.rdbDown.UseVisualStyleBackColor = True
        Me.rdbDown.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ชื่อสินค้า :"
        '
        'lblPdPkName
        '
        Me.lblPdPkName.AutoSize = True
        Me.lblPdPkName.ForeColor = System.Drawing.Color.Crimson
        Me.lblPdPkName.Location = New System.Drawing.Point(76, 28)
        Me.lblPdPkName.Name = "lblPdPkName"
        Me.lblPdPkName.Size = New System.Drawing.Size(39, 13)
        Me.lblPdPkName.TabIndex = 9
        Me.lblPdPkName.Text = "Label6"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblUnitDown)
        Me.GroupBox1.Controls.Add(Me.lblUnitUp)
        Me.GroupBox1.Controls.Add(Me.lblAmtDown)
        Me.GroupBox1.Controls.Add(Me.lblAmtUp)
        Me.GroupBox1.Controls.Add(Me.rdbUp)
        Me.GroupBox1.Controls.Add(Me.rdbDown)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblUnit)
        Me.GroupBox1.Controls.Add(Me.txtWeight)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 217)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(253, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 425
        Me.Label7.Text = "กล่อง"
        '
        'txtBox
        '
        Me.txtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBox.ForeColor = System.Drawing.Color.Red
        Me.txtBox.Location = New System.Drawing.Point(147, 97)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.ReadOnly = True
        Me.txtBox.Size = New System.Drawing.Size(100, 20)
        Me.txtBox.TabIndex = 424
        Me.txtBox.Text = "0"
        Me.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 423
        Me.Label6.Text = "จำนวนกล่อง :"
        '
        'lblUnitDown
        '
        Me.lblUnitDown.AutoSize = True
        Me.lblUnitDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUnitDown.Location = New System.Drawing.Point(240, 166)
        Me.lblUnitDown.Name = "lblUnitDown"
        Me.lblUnitDown.Size = New System.Drawing.Size(45, 15)
        Me.lblUnitDown.TabIndex = 14
        Me.lblUnitDown.Text = "Label8"
        Me.lblUnitDown.Visible = False
        '
        'lblUnitUp
        '
        Me.lblUnitUp.AutoSize = True
        Me.lblUnitUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUnitUp.Location = New System.Drawing.Point(240, 143)
        Me.lblUnitUp.Name = "lblUnitUp"
        Me.lblUnitUp.Size = New System.Drawing.Size(45, 15)
        Me.lblUnitUp.TabIndex = 13
        Me.lblUnitUp.Text = "Label7"
        Me.lblUnitUp.Visible = False
        '
        'lblAmtDown
        '
        Me.lblAmtDown.AutoSize = True
        Me.lblAmtDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAmtDown.Location = New System.Drawing.Point(220, 166)
        Me.lblAmtDown.Name = "lblAmtDown"
        Me.lblAmtDown.Size = New System.Drawing.Size(14, 15)
        Me.lblAmtDown.TabIndex = 12
        Me.lblAmtDown.Text = "0"
        Me.lblAmtDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAmtDown.Visible = False
        '
        'lblAmtUp
        '
        Me.lblAmtUp.AutoSize = True
        Me.lblAmtUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAmtUp.Location = New System.Drawing.Point(220, 141)
        Me.lblAmtUp.Name = "lblAmtUp"
        Me.lblAmtUp.Size = New System.Drawing.Size(14, 15)
        Me.lblAmtUp.TabIndex = 11
        Me.lblAmtUp.Text = "0"
        Me.lblAmtUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAmtUp.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 37)
        Me.Panel2.TabIndex = 420
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(4, -1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 37)
        Me.btnSave.TabIndex = 424
        Me.btnSave.Tag = "Save"
        Me.btnSave.Text = "       ตกลง"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "จำนวน/กล่อง :"
        '
        'lblPerbox
        '
        Me.lblPerbox.AutoSize = True
        Me.lblPerbox.ForeColor = System.Drawing.Color.Crimson
        Me.lblPerbox.Location = New System.Drawing.Point(97, 55)
        Me.lblPerbox.Name = "lblPerbox"
        Me.lblPerbox.Size = New System.Drawing.Size(39, 13)
        Me.lblPerbox.TabIndex = 421
        Me.lblPerbox.Text = "Label6"
        Me.lblPerbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnitPerbox
        '
        Me.lblUnitPerbox.AutoSize = True
        Me.lblUnitPerbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUnitPerbox.Location = New System.Drawing.Point(142, 53)
        Me.lblUnitPerbox.Name = "lblUnitPerbox"
        Me.lblUnitPerbox.Size = New System.Drawing.Size(68, 15)
        Me.lblUnitPerbox.TabIndex = 422
        Me.lblUnitPerbox.Text = "lblUnitPerb"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(220, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 423
        Me.Label8.Text = "น้ำหนัก/กล่อง :"
        '
        'lblWeightBox
        '
        Me.lblWeightBox.AutoSize = True
        Me.lblWeightBox.ForeColor = System.Drawing.Color.Crimson
        Me.lblWeightBox.Location = New System.Drawing.Point(306, 55)
        Me.lblWeightBox.Name = "lblWeightBox"
        Me.lblWeightBox.Size = New System.Drawing.Size(39, 13)
        Me.lblWeightBox.TabIndex = 424
        Me.lblWeightBox.Text = "Label6"
        Me.lblWeightBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(340, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 425
        Me.Label10.Text = "กิโลกรัม"
        '
        'frmPdPkUnitCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblWeightBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblUnitPerbox)
        Me.Controls.Add(Me.lblPerbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPdPkName)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.Name = "frmPdPkUnitCalculate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "คำนวณจำนวนสินค้าจากหน่วยกิโลกรัม"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents rdbUp As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDown As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPdPkName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUnitDown As System.Windows.Forms.Label
    Friend WithEvents lblUnitUp As System.Windows.Forms.Label
    Friend WithEvents lblAmtDown As System.Windows.Forms.Label
    Friend WithEvents lblAmtUp As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPerbox As System.Windows.Forms.Label
    Friend WithEvents lblUnitPerbox As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblWeightBox As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
