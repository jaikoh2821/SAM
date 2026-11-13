<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlPdoAddStockTempAddData
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInvName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDocNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.DateDoc1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UnitPkLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtLotNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPdName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Pscommand = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "วันที่ผลิต"
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(218, 131)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(142, 20)
        Me.DTP1.TabIndex = 81
        Me.DTP1.Value = New Date(2017, 8, 28, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(118, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 20)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "คลังเก็บสินค้า"
        '
        'txtInvName
        '
        Me.txtInvName.Location = New System.Drawing.Point(218, 224)
        Me.txtInvName.Name = "txtInvName"
        Me.txtInvName.Size = New System.Drawing.Size(142, 20)
        Me.txtInvName.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(121, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "เลขที่เอกสาร"
        '
        'txtDocNum
        '
        Me.txtDocNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDocNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDocNum.Location = New System.Drawing.Point(218, 79)
        Me.txtDocNum.Name = "txtDocNum"
        Me.txtDocNum.Size = New System.Drawing.Size(142, 20)
        Me.txtDocNum.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(141, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "หมายเหตุ"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(218, 189)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(142, 20)
        Me.txtNote.TabIndex = 69
        '
        'DateDoc1
        '
        Me.DateDoc1.Location = New System.Drawing.Point(218, 53)
        Me.DateDoc1.Name = "DateDoc1"
        Me.DateDoc1.Size = New System.Drawing.Size(142, 20)
        Me.DateDoc1.TabIndex = 60
        Me.DateDoc1.Value = New Date(2016, 7, 4, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "วันที่เอกสาร"
        '
        'UnitPkLabel
        '
        Me.UnitPkLabel.AutoSize = True
        Me.UnitPkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UnitPkLabel.Location = New System.Drawing.Point(318, 160)
        Me.UnitPkLabel.Name = "UnitPkLabel"
        Me.UnitPkLabel.Size = New System.Drawing.Size(42, 20)
        Me.UnitPkLabel.TabIndex = 73
        Me.UnitPkLabel.Text = "หน่วย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "จำนวนรับเข้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "เลขที่Lot"
        '
        'txtAmount
        '
        Me.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAmount.Enabled = False
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(218, 157)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(93, 26)
        Me.txtAmount.TabIndex = 64
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLotNum
        '
        Me.txtLotNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLotNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLotNum.Enabled = False
        Me.txtLotNum.Location = New System.Drawing.Point(218, 105)
        Me.txtLotNum.Name = "txtLotNum"
        Me.txtLotNum.Size = New System.Drawing.Size(142, 20)
        Me.txtLotNum.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "ชื่อสินค้า"
        '
        'txtPdName
        '
        Me.txtPdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPdName.Enabled = False
        Me.txtPdName.Location = New System.Drawing.Point(91, 18)
        Me.txtPdName.Name = "txtPdName"
        Me.txtPdName.Size = New System.Drawing.Size(269, 20)
        Me.txtPdName.TabIndex = 61
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 261)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 32)
        Me.Panel1.TabIndex = 65
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(106, 30)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Tag = ""
        Me.btn_save.Text = "    ตกลง"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SAM.My.Resources.Resources.Find16
        Me.Button1.Location = New System.Drawing.Point(366, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 26)
        Me.Button1.TabIndex = 78
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_Pscommand
        '
        Me.btn_Pscommand.AutoSize = True
        Me.btn_Pscommand.BackColor = System.Drawing.Color.DimGray
        Me.btn_Pscommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Pscommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Pscommand.ForeColor = System.Drawing.Color.White
        Me.btn_Pscommand.Image = Global.SAM.My.Resources.Resources.Find16
        Me.btn_Pscommand.Location = New System.Drawing.Point(366, 14)
        Me.btn_Pscommand.Name = "btn_Pscommand"
        Me.btn_Pscommand.Size = New System.Drawing.Size(30, 27)
        Me.btn_Pscommand.TabIndex = 70
        Me.btn_Pscommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Pscommand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Pscommand.UseVisualStyleBackColor = False
        '
        'frmSlPdoAddStockTempAddData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(447, 293)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtInvName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDocNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.DateDoc1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UnitPkLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtLotNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Pscommand)
        Me.Controls.Add(Me.txtPdName)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSlPdoAddStockTempAddData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtInvName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDocNum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents DateDoc1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UnitPkLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtLotNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Pscommand As System.Windows.Forms.Button
    Friend WithEvents txtPdName As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
End Class
