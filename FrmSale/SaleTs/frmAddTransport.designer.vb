<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTransport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddTransport))
        Me.lblTspComp = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cmbTypePayTrp = New System.Windows.Forms.ComboBox()
        Me.CmbTs = New System.Windows.Forms.ComboBox()
        Me.lblTS = New System.Windows.Forms.Label()
        Me.btnTspComp = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTspComp
        '
        Me.lblTspComp.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTspComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTspComp.Location = New System.Drawing.Point(117, 43)
        Me.lblTspComp.Name = "lblTspComp"
        Me.lblTspComp.Size = New System.Drawing.Size(165, 42)
        Me.lblTspComp.TabIndex = 640
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label56.Location = New System.Drawing.Point(51, 45)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(65, 14)
        Me.Label56.TabIndex = 639
        Me.Label56.Text = "บริษัทขนส่ง"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label54.Location = New System.Drawing.Point(15, 93)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(102, 14)
        Me.Label54.TabIndex = 638
        Me.Label54.Text = "การจ่ายเงินค่าขนส่ง"
        '
        'cmbTypePayTrp
        '
        Me.cmbTypePayTrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypePayTrp.FormattingEnabled = True
        Me.cmbTypePayTrp.Location = New System.Drawing.Point(117, 90)
        Me.cmbTypePayTrp.Name = "cmbTypePayTrp"
        Me.cmbTypePayTrp.Size = New System.Drawing.Size(165, 21)
        Me.cmbTypePayTrp.TabIndex = 2
        '
        'CmbTs
        '
        Me.CmbTs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmbTs.FormattingEnabled = True
        Me.CmbTs.Location = New System.Drawing.Point(117, 16)
        Me.CmbTs.Name = "CmbTs"
        Me.CmbTs.Size = New System.Drawing.Size(165, 21)
        Me.CmbTs.TabIndex = 0
        '
        'lblTS
        '
        Me.lblTS.AutoSize = True
        Me.lblTS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTS.Location = New System.Drawing.Point(41, 19)
        Me.lblTS.Name = "lblTS"
        Me.lblTS.Size = New System.Drawing.Size(72, 14)
        Me.lblTS.TabIndex = 637
        Me.lblTS.Text = "ประเภทขนส่ง"
        '
        'btnTspComp
        '
        Me.btnTspComp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTspComp.Image = Global.SAM.My.Resources.Resources.search_png_16x16
        Me.btnTspComp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnTspComp.Location = New System.Drawing.Point(284, 43)
        Me.btnTspComp.Name = "btnTspComp"
        Me.btnTspComp.Size = New System.Drawing.Size(25, 22)
        Me.btnTspComp.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(117, 118)
        Me.txtPrice.MaxLength = 9
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(129, 20)
        Me.txtPrice.TabIndex = 642
        Me.txtPrice.Text = "0"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 643
        Me.Label1.Text = "จำนวนเงิน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(252, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 644
        Me.Label2.Text = "บาท"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 152)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(321, 35)
        Me.PanelControl2.TabIndex = 645
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSave.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 29)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "บันทึก"
        '
        'frmAddTransport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(321, 187)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnTspComp)
        Me.Controls.Add(Me.lblTspComp)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.cmbTypePayTrp)
        Me.Controls.Add(Me.CmbTs)
        Me.Controls.Add(Me.lblTS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddTransport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่ม/แก้ไขรายละเอียดค่าขนส่ง"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTspComp As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents cmbTypePayTrp As System.Windows.Forms.ComboBox
    Friend WithEvents CmbTs As System.Windows.Forms.ComboBox
    Friend WithEvents lblTS As System.Windows.Forms.Label
    Friend WithEvents btnTspComp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class
