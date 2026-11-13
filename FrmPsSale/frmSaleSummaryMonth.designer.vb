<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleSummaryMonth
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaleSummaryMonth))
        Me.GVPdT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCPlant = New DevExpress.XtraGrid.GridControl()
        Me.GVPlant = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkPdT = New System.Windows.Forms.RadioButton()
        Me.cbFindPlantName = New System.Windows.Forms.RadioButton()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.txtPdTName = New System.Windows.Forms.TextBox()
        Me.txtPlantName = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdbKg = New System.Windows.Forms.RadioButton()
        Me.rdbUnitSale = New System.Windows.Forms.RadioButton()
        Me.rdbSale = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbPsSale = New System.Windows.Forms.CheckBox()
        Me.cbCus = New System.Windows.Forms.CheckBox()
        Me.cmbPsSale = New System.Windows.Forms.ComboBox()
        Me.lblCus = New System.Windows.Forms.Label()
        Me.btnCus = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckedComboBoxType = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.CheckMatP = New System.Windows.Forms.CheckBox()
        Me.CheckGenP = New System.Windows.Forms.CheckBox()
        Me.rdbGenPN = New System.Windows.Forms.RadioButton()
        Me.rdbGenPA = New System.Windows.Forms.RadioButton()
        Me.rdbGenPC = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbThai = New System.Windows.Forms.RadioButton()
        Me.rdbExp = New System.Windows.Forms.RadioButton()
        Me.rdbAllSale = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpMe = New System.Windows.Forms.DateTimePicker()
        Me.dtpMs = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.GVPdT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPlant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPlant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CheckedComboBoxType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVPdT
        '
        Me.GVPdT.Appearance.EvenRow.Options.UseTextOptions = True
        Me.GVPdT.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVPdT.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVPdT.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVPdT.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVPdT.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVPdT.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVPdT.ColumnPanelRowHeight = 45
        Me.GVPdT.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVPdT.GridControl = Me.GCPlant
        Me.GVPdT.Name = "GVPdT"
        Me.GVPdT.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVPdT.OptionsView.ShowGroupPanel = False
        Me.GVPdT.OptionsView.ShowIndicator = False
        '
        'GCPlant
        '
        Me.GCPlant.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVPdT
        GridLevelNode1.RelationName = "Level1"
        Me.GCPlant.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCPlant.Location = New System.Drawing.Point(0, 206)
        Me.GCPlant.MainView = Me.GVPlant
        Me.GCPlant.Name = "GCPlant"
        Me.GCPlant.Size = New System.Drawing.Size(1184, 345)
        Me.GCPlant.TabIndex = 463
        Me.GCPlant.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPlant, Me.GVPdT})
        '
        'GVPlant
        '
        Me.GVPlant.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GVPlant.Appearance.EvenRow.Options.UseFont = True
        Me.GVPlant.Appearance.EvenRow.Options.UseTextOptions = True
        Me.GVPlant.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVPlant.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVPlant.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVPlant.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVPlant.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVPlant.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVPlant.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVPlant.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVPlant.Appearance.Row.Options.UseFont = True
        Me.GVPlant.Appearance.SelectedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GVPlant.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVPlant.ColumnPanelRowHeight = 45
        Me.GVPlant.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVPlant.GridControl = Me.GCPlant
        Me.GVPlant.Name = "GVPlant"
        Me.GVPlant.OptionsMenu.EnableFooterMenu = False
        Me.GVPlant.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVPlant.OptionsView.ShowGroupPanel = False
        Me.GVPlant.OptionsView.ShowIndicator = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.chkPdT)
        Me.PanelControl1.Controls.Add(Me.cbFindPlantName)
        Me.PanelControl1.Controls.Add(Me.cmbGroupComp)
        Me.PanelControl1.Controls.Add(Me.txtPdTName)
        Me.PanelControl1.Controls.Add(Me.txtPlantName)
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Controls.Add(Me.GroupBox5)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 171)
        Me.PanelControl1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(682, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 775
        Me.Label2.Text = "ข้อมูลบริษัท"
        '
        'chkPdT
        '
        Me.chkPdT.AutoSize = True
        Me.chkPdT.BackColor = System.Drawing.Color.Transparent
        Me.chkPdT.Location = New System.Drawing.Point(666, 143)
        Me.chkPdT.Name = "chkPdT"
        Me.chkPdT.Size = New System.Drawing.Size(112, 17)
        Me.chkPdT.TabIndex = 774
        Me.chkPdT.Text = "ค้นหาชื่อทางการค้า"
        Me.chkPdT.UseVisualStyleBackColor = False
        '
        'cbFindPlantName
        '
        Me.cbFindPlantName.AutoSize = True
        Me.cbFindPlantName.BackColor = System.Drawing.Color.Transparent
        Me.cbFindPlantName.Location = New System.Drawing.Point(666, 115)
        Me.cbFindPlantName.Name = "cbFindPlantName"
        Me.cbFindPlantName.Size = New System.Drawing.Size(79, 17)
        Me.cbFindPlantName.TabIndex = 773
        Me.cbFindPlantName.Text = "ค้นหาชื่อพืช"
        Me.cbFindPlantName.UseVisualStyleBackColor = False
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(785, 85)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(209, 21)
        Me.cmbGroupComp.TabIndex = 771
        '
        'txtPdTName
        '
        Me.txtPdTName.Enabled = False
        Me.txtPdTName.Location = New System.Drawing.Point(785, 141)
        Me.txtPdTName.Name = "txtPdTName"
        Me.txtPdTName.Size = New System.Drawing.Size(209, 21)
        Me.txtPdTName.TabIndex = 684
        '
        'txtPlantName
        '
        Me.txtPlantName.BackColor = System.Drawing.SystemColors.Window
        Me.txtPlantName.Enabled = False
        Me.txtPlantName.Location = New System.Drawing.Point(785, 114)
        Me.txtPlantName.Name = "txtPlantName"
        Me.txtPlantName.Size = New System.Drawing.Size(209, 21)
        Me.txtPlantName.TabIndex = 682
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.rdbKg)
        Me.GroupBox4.Controls.Add(Me.rdbUnitSale)
        Me.GroupBox4.Controls.Add(Me.rdbSale)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 81)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(231, 79)
        Me.GroupBox4.TabIndex = 681
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "หน่วยแสดงข้อมูล"
        '
        'rdbKg
        '
        Me.rdbKg.AutoSize = True
        Me.rdbKg.Location = New System.Drawing.Point(93, 22)
        Me.rdbKg.Name = "rdbKg"
        Me.rdbKg.Size = New System.Drawing.Size(95, 17)
        Me.rdbKg.TabIndex = 676
        Me.rdbKg.Text = "จำนวนขาย (kg)"
        Me.rdbKg.UseVisualStyleBackColor = True
        '
        'rdbUnitSale
        '
        Me.rdbUnitSale.AutoSize = True
        Me.rdbUnitSale.Location = New System.Drawing.Point(93, 52)
        Me.rdbUnitSale.Name = "rdbUnitSale"
        Me.rdbUnitSale.Size = New System.Drawing.Size(127, 17)
        Me.rdbUnitSale.TabIndex = 677
        Me.rdbUnitSale.Text = "จำนวนขาย (หน่วยขาย)"
        Me.rdbUnitSale.UseVisualStyleBackColor = True
        '
        'rdbSale
        '
        Me.rdbSale.AutoSize = True
        Me.rdbSale.Checked = True
        Me.rdbSale.Location = New System.Drawing.Point(13, 22)
        Me.rdbSale.Name = "rdbSale"
        Me.rdbSale.Size = New System.Drawing.Size(63, 17)
        Me.rdbSale.TabIndex = 675
        Me.rdbSale.TabStop = True
        Me.rdbSale.Text = "ยอดขาย"
        Me.rdbSale.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.cbPsSale)
        Me.GroupBox5.Controls.Add(Me.cbCus)
        Me.GroupBox5.Controls.Add(Me.cmbPsSale)
        Me.GroupBox5.Controls.Add(Me.lblCus)
        Me.GroupBox5.Controls.Add(Me.btnCus)
        Me.GroupBox5.Location = New System.Drawing.Point(242, 82)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(394, 79)
        Me.GroupBox5.TabIndex = 680
        Me.GroupBox5.TabStop = False
        '
        'cbPsSale
        '
        Me.cbPsSale.AutoSize = True
        Me.cbPsSale.Checked = True
        Me.cbPsSale.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPsSale.Location = New System.Drawing.Point(15, 20)
        Me.cbPsSale.Name = "cbPsSale"
        Me.cbPsSale.Size = New System.Drawing.Size(86, 17)
        Me.cbPsSale.TabIndex = 670
        Me.cbPsSale.Text = "เจ้าหน้าที่ขาย"
        Me.cbPsSale.UseVisualStyleBackColor = True
        '
        'cbCus
        '
        Me.cbCus.AutoSize = True
        Me.cbCus.Location = New System.Drawing.Point(15, 53)
        Me.cbCus.Name = "cbCus"
        Me.cbCus.Size = New System.Drawing.Size(52, 17)
        Me.cbCus.TabIndex = 672
        Me.cbCus.Text = "ลูกค้า"
        Me.cbCus.UseVisualStyleBackColor = True
        '
        'cmbPsSale
        '
        Me.cmbPsSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPsSale.FormattingEnabled = True
        Me.cmbPsSale.Location = New System.Drawing.Point(107, 18)
        Me.cmbPsSale.Name = "cmbPsSale"
        Me.cmbPsSale.Size = New System.Drawing.Size(247, 21)
        Me.cmbPsSale.TabIndex = 669
        '
        'lblCus
        '
        Me.lblCus.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCus.Location = New System.Drawing.Point(107, 50)
        Me.lblCus.Name = "lblCus"
        Me.lblCus.Size = New System.Drawing.Size(247, 20)
        Me.lblCus.TabIndex = 668
        Me.lblCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCus
        '
        Me.btnCus.BackColor = System.Drawing.Color.DimGray
        Me.btnCus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCus.Enabled = False
        Me.btnCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCus.ForeColor = System.Drawing.Color.White
        Me.btnCus.Image = CType(resources.GetObject("btnCus.Image"), System.Drawing.Image)
        Me.btnCus.Location = New System.Drawing.Point(355, 47)
        Me.btnCus.Name = "btnCus"
        Me.btnCus.Size = New System.Drawing.Size(28, 25)
        Me.btnCus.TabIndex = 667
        Me.btnCus.Tag = "Add"
        Me.btnCus.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CheckedComboBoxType)
        Me.GroupBox2.Controls.Add(Me.CheckMatP)
        Me.GroupBox2.Controls.Add(Me.CheckGenP)
        Me.GroupBox2.Controls.Add(Me.rdbGenPN)
        Me.GroupBox2.Controls.Add(Me.rdbGenPA)
        Me.GroupBox2.Controls.Add(Me.rdbGenPC)
        Me.GroupBox2.Location = New System.Drawing.Point(439, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 74)
        Me.GroupBox2.TabIndex = 678
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ประเภทสินค้า"
        '
        'CheckedComboBoxType
        '
        Me.CheckedComboBoxType.Enabled = False
        Me.CheckedComboBoxType.Location = New System.Drawing.Point(483, 20)
        Me.CheckedComboBoxType.Name = "CheckedComboBoxType"
        Me.CheckedComboBoxType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CheckedComboBoxType.Properties.PopupFormSize = New System.Drawing.Size(70, 110)
        Me.CheckedComboBoxType.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize
        Me.CheckedComboBoxType.Size = New System.Drawing.Size(135, 20)
        Me.CheckedComboBoxType.TabIndex = 18
        '
        'CheckMatP
        '
        Me.CheckMatP.AutoSize = True
        Me.CheckMatP.Checked = True
        Me.CheckMatP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckMatP.Location = New System.Drawing.Point(28, 46)
        Me.CheckMatP.Name = "CheckMatP"
        Me.CheckMatP.Size = New System.Drawing.Size(129, 17)
        Me.CheckMatP.TabIndex = 17
        Me.CheckMatP.Text = "สินค้าเมล็ดพันธุ์วัตถุดิบ"
        Me.CheckMatP.UseVisualStyleBackColor = True
        '
        'CheckGenP
        '
        Me.CheckGenP.AutoSize = True
        Me.CheckGenP.Checked = True
        Me.CheckGenP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckGenP.Location = New System.Drawing.Point(28, 22)
        Me.CheckGenP.Name = "CheckGenP"
        Me.CheckGenP.Size = New System.Drawing.Size(136, 17)
        Me.CheckGenP.TabIndex = 16
        Me.CheckGenP.Text = "สินค้าเมล็ดพันธุ์สำเร็จรูป"
        Me.CheckGenP.UseVisualStyleBackColor = True
        '
        'rdbGenPN
        '
        Me.rdbGenPN.AutoSize = True
        Me.rdbGenPN.Location = New System.Drawing.Point(296, 22)
        Me.rdbGenPN.Name = "rdbGenPN"
        Me.rdbGenPN.Size = New System.Drawing.Size(77, 17)
        Me.rdbGenPN.TabIndex = 15
        Me.rdbGenPN.Text = "สินค้าทั่วไป"
        Me.rdbGenPN.UseVisualStyleBackColor = True
        '
        'rdbGenPA
        '
        Me.rdbGenPA.AutoSize = True
        Me.rdbGenPA.Checked = True
        Me.rdbGenPA.Location = New System.Drawing.Point(191, 22)
        Me.rdbGenPA.Name = "rdbGenPA"
        Me.rdbGenPA.Size = New System.Drawing.Size(85, 17)
        Me.rdbGenPA.TabIndex = 14
        Me.rdbGenPA.TabStop = True
        Me.rdbGenPA.Text = "สินค้าทั้งหมด"
        Me.rdbGenPA.UseVisualStyleBackColor = True
        '
        'rdbGenPC
        '
        Me.rdbGenPC.AutoSize = True
        Me.rdbGenPC.Location = New System.Drawing.Point(395, 23)
        Me.rdbGenPC.Name = "rdbGenPC"
        Me.rdbGenPC.Size = New System.Drawing.Size(85, 17)
        Me.rdbGenPC.TabIndex = 13
        Me.rdbGenPC.Text = "สินค้าผักซอง"
        Me.rdbGenPC.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbThai)
        Me.GroupBox1.Controls.Add(Me.rdbExp)
        Me.GroupBox1.Controls.Add(Me.rdbAllSale)
        Me.GroupBox1.Location = New System.Drawing.Point(243, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 74)
        Me.GroupBox1.TabIndex = 678
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "การแสดงยอดขาย"
        '
        'rdbThai
        '
        Me.rdbThai.AutoSize = True
        Me.rdbThai.Location = New System.Drawing.Point(83, 22)
        Me.rdbThai.Name = "rdbThai"
        Me.rdbThai.Size = New System.Drawing.Size(101, 17)
        Me.rdbThai.TabIndex = 676
        Me.rdbThai.Text = "เฉพาะในประเทศ"
        Me.rdbThai.UseVisualStyleBackColor = True
        '
        'rdbExp
        '
        Me.rdbExp.AutoSize = True
        Me.rdbExp.Location = New System.Drawing.Point(83, 45)
        Me.rdbExp.Name = "rdbExp"
        Me.rdbExp.Size = New System.Drawing.Size(106, 17)
        Me.rdbExp.TabIndex = 677
        Me.rdbExp.Text = "เฉพาะต่างประเทศ"
        Me.rdbExp.UseVisualStyleBackColor = True
        '
        'rdbAllSale
        '
        Me.rdbAllSale.AutoSize = True
        Me.rdbAllSale.Checked = True
        Me.rdbAllSale.Location = New System.Drawing.Point(13, 22)
        Me.rdbAllSale.Name = "rdbAllSale"
        Me.rdbAllSale.Size = New System.Drawing.Size(59, 17)
        Me.rdbAllSale.TabIndex = 675
        Me.rdbAllSale.TabStop = True
        Me.rdbAllSale.Text = "ทั้งหมด"
        Me.rdbAllSale.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.dtpMe)
        Me.GroupBox3.Controls.Add(Me.dtpMs)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 74)
        Me.GroupBox3.TabIndex = 674
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ช่วงเดือน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 678
        Me.Label3.Text = "เดือน"
        '
        'dtpMe
        '
        Me.dtpMe.Checked = False
        Me.dtpMe.CustomFormat = "MMMM /yyyy"
        Me.dtpMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMe.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMe.Location = New System.Drawing.Point(69, 45)
        Me.dtpMe.Name = "dtpMe"
        Me.dtpMe.Size = New System.Drawing.Size(134, 20)
        Me.dtpMe.TabIndex = 677
        '
        'dtpMs
        '
        Me.dtpMs.Checked = False
        Me.dtpMs.CustomFormat = "MMMM /yyyy"
        Me.dtpMs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMs.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMs.Location = New System.Drawing.Point(69, 19)
        Me.dtpMs.Name = "dtpMs"
        Me.dtpMs.Size = New System.Drawing.Size(134, 20)
        Me.dtpMs.TabIndex = 676
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 427
        Me.Label1.Text = "ถึง"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnSearch)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 171)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1184, 35)
        Me.PanelControl2.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DimGray
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(0, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(115, 35)
        Me.btnSearch.TabIndex = 670
        Me.btnSearch.Tag = ""
        Me.btnSearch.Text = "       แสดงข้อมูล"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmSaleSummaryMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCPlant)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSaleSummaryMonth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ยอดขาย และจำนวนขายสินค้าเมล็ดพันธุ์"
        CType(Me.GVPdT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPlant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPlant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CheckedComboBoxType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCPlant As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpMs As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMe As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbThai As System.Windows.Forms.RadioButton
    Friend WithEvents rdbExp As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAllSale As System.Windows.Forms.RadioButton
    Friend WithEvents CheckedComboBoxType As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents CheckMatP As System.Windows.Forms.CheckBox
    Friend WithEvents CheckGenP As System.Windows.Forms.CheckBox
    Friend WithEvents rdbGenPN As System.Windows.Forms.RadioButton
    Friend WithEvents rdbGenPA As System.Windows.Forms.RadioButton
    Friend WithEvents rdbGenPC As System.Windows.Forms.RadioButton
    Friend WithEvents cbCus As System.Windows.Forms.CheckBox
    Friend WithEvents cbPsSale As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPsSale As System.Windows.Forms.ComboBox
    Friend WithEvents lblCus As System.Windows.Forms.Label
    Friend WithEvents btnCus As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbKg As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUnitSale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSale As System.Windows.Forms.RadioButton
    Friend WithEvents txtPlantName As System.Windows.Forms.TextBox
    Friend WithEvents GVPdT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtPdTName As System.Windows.Forms.TextBox
    Friend WithEvents GVPlant As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents chkPdT As System.Windows.Forms.RadioButton
    Friend WithEvents cbFindPlantName As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
