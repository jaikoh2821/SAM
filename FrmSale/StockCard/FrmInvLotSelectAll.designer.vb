<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvLotSelectAll
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInvLotSelectAll))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cpLotNo = New System.Windows.Forms.CheckBox()
        Me.cbPdName = New System.Windows.Forms.CheckBox()
        Me.cbType = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbWhFrom = New System.Windows.Forms.ComboBox()
        Me.CBLot = New System.Windows.Forms.CheckBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtLotNum = New System.Windows.Forms.TextBox()
        Me.txtPdName = New System.Windows.Forms.TextBox()
        Me.ChkPd = New System.Windows.Forms.CheckBox()
        Me.ChkType = New System.Windows.Forms.CheckBox()
        Me.CHKWh = New System.Windows.Forms.CheckBox()
        Me.CHKLotNum = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btnSchPd = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Select_check = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CheckPd = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Select_Button = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonPd = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Col_idLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_idRefLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_idInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_InvGroupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_idInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_InvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_idUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_UnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_idwh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_WareHouseName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonPd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 88)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cpLotNo)
        Me.GroupBox3.Controls.Add(Me.cbPdName)
        Me.GroupBox3.Controls.Add(Me.cbType)
        Me.GroupBox3.Location = New System.Drawing.Point(785, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 80)
        Me.GroupBox3.TabIndex = 640
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "จัดกลุ่มตาม"
        '
        'cpLotNo
        '
        Me.cpLotNo.AutoSize = True
        Me.cpLotNo.Location = New System.Drawing.Point(21, 48)
        Me.cpLotNo.Name = "cpLotNo"
        Me.cpLotNo.Size = New System.Drawing.Size(61, 17)
        Me.cpLotNo.TabIndex = 633
        Me.cpLotNo.Text = "Lot No."
        Me.cpLotNo.UseVisualStyleBackColor = True
        '
        'cbPdName
        '
        Me.cbPdName.AutoSize = True
        Me.cbPdName.Checked = True
        Me.cbPdName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPdName.Location = New System.Drawing.Point(90, 18)
        Me.cbPdName.Name = "cbPdName"
        Me.cbPdName.Size = New System.Drawing.Size(95, 17)
        Me.cbPdName.TabIndex = 608
        Me.cbPdName.Text = "ชื่อวัสดุ / สินค้า"
        Me.cbPdName.UseVisualStyleBackColor = True
        '
        'cbType
        '
        Me.cbType.AutoSize = True
        Me.cbType.Location = New System.Drawing.Point(21, 20)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(63, 17)
        Me.cbType.TabIndex = 632
        Me.cbType.Text = "ประเภท"
        Me.cbType.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbWhFrom)
        Me.GroupBox1.Controls.Add(Me.CBLot)
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.txtLotNum)
        Me.GroupBox1.Controls.Add(Me.txtPdName)
        Me.GroupBox1.Controls.Add(Me.ChkPd)
        Me.GroupBox1.Controls.Add(Me.ChkType)
        Me.GroupBox1.Controls.Add(Me.CHKWh)
        Me.GroupBox1.Controls.Add(Me.CHKLotNum)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 80)
        Me.GroupBox1.TabIndex = 607
        Me.GroupBox1.TabStop = False
        '
        'cmbWhFrom
        '
        Me.cmbWhFrom.Enabled = False
        Me.cmbWhFrom.FormattingEnabled = True
        Me.cmbWhFrom.Location = New System.Drawing.Point(414, 46)
        Me.cmbWhFrom.Name = "cmbWhFrom"
        Me.cmbWhFrom.Size = New System.Drawing.Size(157, 21)
        Me.cmbWhFrom.TabIndex = 777
        '
        'CBLot
        '
        Me.CBLot.AutoSize = True
        Me.CBLot.Location = New System.Drawing.Point(594, 20)
        Me.CBLot.Name = "CBLot"
        Me.CBLot.Size = New System.Drawing.Size(172, 17)
        Me.CBLot.TabIndex = 614
        Me.CBLot.Text = "ค้นหา Lot วัสดุ/สินค้าที่หมดแล้ว"
        Me.CBLot.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.Enabled = False
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(118, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(217, 21)
        Me.cmbType.TabIndex = 2
        '
        'txtLotNum
        '
        Me.txtLotNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLotNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLotNum.Location = New System.Drawing.Point(414, 17)
        Me.txtLotNum.Name = "txtLotNum"
        Me.txtLotNum.Size = New System.Drawing.Size(157, 20)
        Me.txtLotNum.TabIndex = 605
        '
        'txtPdName
        '
        Me.txtPdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPdName.Enabled = False
        Me.txtPdName.Location = New System.Drawing.Point(117, 50)
        Me.txtPdName.Name = "txtPdName"
        Me.txtPdName.Size = New System.Drawing.Size(218, 20)
        Me.txtPdName.TabIndex = 1
        '
        'ChkPd
        '
        Me.ChkPd.AutoSize = True
        Me.ChkPd.Location = New System.Drawing.Point(19, 51)
        Me.ChkPd.Name = "ChkPd"
        Me.ChkPd.Size = New System.Drawing.Size(95, 17)
        Me.ChkPd.TabIndex = 603
        Me.ChkPd.Text = "ชื่อวัสดุ / สินค้า"
        Me.ChkPd.UseVisualStyleBackColor = True
        '
        'ChkType
        '
        Me.ChkType.AutoSize = True
        Me.ChkType.Location = New System.Drawing.Point(20, 18)
        Me.ChkType.Name = "ChkType"
        Me.ChkType.Size = New System.Drawing.Size(63, 17)
        Me.ChkType.TabIndex = 604
        Me.ChkType.Text = "ประเภท"
        Me.ChkType.UseVisualStyleBackColor = True
        '
        'CHKWh
        '
        Me.CHKWh.AutoSize = True
        Me.CHKWh.Location = New System.Drawing.Point(350, 48)
        Me.CHKWh.Name = "CHKWh"
        Me.CHKWh.Size = New System.Drawing.Size(44, 17)
        Me.CHKWh.TabIndex = 606
        Me.CHKWh.Text = "คลัง"
        Me.CHKWh.UseVisualStyleBackColor = True
        '
        'CHKLotNum
        '
        Me.CHKLotNum.AutoSize = True
        Me.CHKLotNum.Checked = True
        Me.CHKLotNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKLotNum.Location = New System.Drawing.Point(349, 19)
        Me.CHKLotNum.Name = "CHKLotNum"
        Me.CHKLotNum.Size = New System.Drawing.Size(61, 17)
        Me.CHKLotNum.TabIndex = 606
        Me.CHKLotNum.Text = "Lot No."
        Me.CHKLotNum.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btnSchPd)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 34)
        Me.Panel1.TabIndex = 2
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.ImportDoc
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(115, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_save.Size = New System.Drawing.Size(106, 32)
        Me.btn_save.TabIndex = 611
        Me.btn_save.Tag = ""
        Me.btn_save.Text = "  เลือก"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btnSchPd
        '
        Me.btnSchPd.BackColor = System.Drawing.Color.DimGray
        Me.btnSchPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchPd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSchPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSchPd.ForeColor = System.Drawing.Color.White
        Me.btnSchPd.Image = Global.SAM.My.Resources.Resources.refresh_24x24
        Me.btnSchPd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchPd.Location = New System.Drawing.Point(0, 0)
        Me.btnSchPd.Name = "btnSchPd"
        Me.btnSchPd.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnSchPd.Size = New System.Drawing.Size(115, 32)
        Me.btnSchPd.TabIndex = 613
        Me.btnSchPd.Tag = ""
        Me.btnSchPd.Text = "     Refresh"
        Me.btnSchPd.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.txtCount)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(720, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(262, 32)
        Me.Panel8.TabIndex = 612
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(201, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "รายการ"
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(101, 5)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(98, 24)
        Me.txtCount.TabIndex = 595
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "จำนวนรายการ"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 122)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CheckPd, Me.ButtonPd})
        Me.GridControl1.Size = New System.Drawing.Size(984, 429)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkGray
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Select_check, Me.Select_Button, Me.Col_idLot, Me.Col_idRefLot, Me.Col_LotNo, Me.Col_idInvGroup, Me.Col_InvGroupName, Me.Col_idInvMain, Me.Col_InvName, Me.Col_Amount, Me.Col_idUnit, Me.Col_UnitName, Me.Col_idwh, Me.Col_WareHouseName})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Select_check
        '
        Me.Select_check.AppearanceCell.Options.UseTextOptions = True
        Me.Select_check.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Select_check.AppearanceHeader.Options.UseTextOptions = True
        Me.Select_check.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Select_check.Caption = "เลือก"
        Me.Select_check.ColumnEdit = Me.CheckPd
        Me.Select_check.FieldName = "CheckPd"
        Me.Select_check.MaxWidth = 40
        Me.Select_check.MinWidth = 30
        Me.Select_check.Name = "Select_check"
        Me.Select_check.Visible = True
        Me.Select_check.VisibleIndex = 0
        Me.Select_check.Width = 39
        '
        'CheckPd
        '
        Me.CheckPd.AutoHeight = False
        Me.CheckPd.Name = "CheckPd"
        '
        'Select_Button
        '
        Me.Select_Button.AppearanceHeader.Options.UseTextOptions = True
        Me.Select_Button.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Select_Button.Caption = "เลือก"
        Me.Select_Button.ColumnEdit = Me.ButtonPd
        Me.Select_Button.MaxWidth = 50
        Me.Select_Button.MinWidth = 50
        Me.Select_Button.Name = "Select_Button"
        Me.Select_Button.Width = 50
        '
        'ButtonPd
        '
        Me.ButtonPd.AutoHeight = False
        Me.ButtonPd.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.ButtonPd.Name = "ButtonPd"
        Me.ButtonPd.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Col_idLot
        '
        Me.Col_idLot.FieldName = "idLotMain"
        Me.Col_idLot.Name = "Col_idLot"
        '
        'Col_idRefLot
        '
        Me.Col_idRefLot.FieldName = "idRefLot"
        Me.Col_idRefLot.Name = "Col_idRefLot"
        '
        'Col_LotNo
        '
        Me.Col_LotNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Col_LotNo.AppearanceCell.Options.UseBackColor = True
        Me.Col_LotNo.AppearanceCell.Options.UseTextOptions = True
        Me.Col_LotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_LotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_LotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_LotNo.Caption = "Lot No."
        Me.Col_LotNo.FieldName = "LotNo"
        Me.Col_LotNo.MaxWidth = 120
        Me.Col_LotNo.Name = "Col_LotNo"
        Me.Col_LotNo.OptionsColumn.AllowEdit = False
        Me.Col_LotNo.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[True]
        Me.Col_LotNo.OptionsColumn.ReadOnly = True
        Me.Col_LotNo.Visible = True
        Me.Col_LotNo.VisibleIndex = 1
        Me.Col_LotNo.Width = 120
        '
        'Col_idInvGroup
        '
        Me.Col_idInvGroup.FieldName = "idInvGroup"
        Me.Col_idInvGroup.Name = "Col_idInvGroup"
        '
        'Col_InvGroupName
        '
        Me.Col_InvGroupName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Col_InvGroupName.AppearanceCell.Options.UseBackColor = True
        Me.Col_InvGroupName.AppearanceCell.Options.UseTextOptions = True
        Me.Col_InvGroupName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_InvGroupName.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_InvGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_InvGroupName.Caption = "ประเภท"
        Me.Col_InvGroupName.FieldName = "InvGroupName"
        Me.Col_InvGroupName.MaxWidth = 170
        Me.Col_InvGroupName.MinWidth = 150
        Me.Col_InvGroupName.Name = "Col_InvGroupName"
        Me.Col_InvGroupName.OptionsColumn.AllowEdit = False
        Me.Col_InvGroupName.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[True]
        Me.Col_InvGroupName.OptionsColumn.ReadOnly = True
        Me.Col_InvGroupName.Visible = True
        Me.Col_InvGroupName.VisibleIndex = 6
        Me.Col_InvGroupName.Width = 170
        '
        'Col_idInvMain
        '
        Me.Col_idInvMain.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_idInvMain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_idInvMain.FieldName = "idInvMain"
        Me.Col_idInvMain.Name = "Col_idInvMain"
        Me.Col_idInvMain.Width = 109
        '
        'Col_InvName
        '
        Me.Col_InvName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Col_InvName.AppearanceCell.Options.UseBackColor = True
        Me.Col_InvName.AppearanceCell.Options.UseTextOptions = True
        Me.Col_InvName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.Col_InvName.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_InvName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_InvName.Caption = "ชื่อ"
        Me.Col_InvName.FieldName = "InvName"
        Me.Col_InvName.Name = "Col_InvName"
        Me.Col_InvName.OptionsColumn.AllowEdit = False
        Me.Col_InvName.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[True]
        Me.Col_InvName.OptionsColumn.ReadOnly = True
        Me.Col_InvName.Visible = True
        Me.Col_InvName.VisibleIndex = 2
        Me.Col_InvName.Width = 440
        '
        'Col_Amount
        '
        Me.Col_Amount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Col_Amount.AppearanceCell.Options.UseBackColor = True
        Me.Col_Amount.AppearanceCell.Options.UseTextOptions = True
        Me.Col_Amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Col_Amount.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Amount.Caption = "คงเหลือ"
        Me.Col_Amount.DisplayFormat.FormatString = "#,##0.00##"
        Me.Col_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.Col_Amount.FieldName = "Amount"
        Me.Col_Amount.MaxWidth = 120
        Me.Col_Amount.Name = "Col_Amount"
        Me.Col_Amount.OptionsColumn.AllowEdit = False
        Me.Col_Amount.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[True]
        Me.Col_Amount.OptionsColumn.ReadOnly = True
        Me.Col_Amount.Visible = True
        Me.Col_Amount.VisibleIndex = 3
        Me.Col_Amount.Width = 120
        '
        'Col_idUnit
        '
        Me.Col_idUnit.FieldName = "idUnit"
        Me.Col_idUnit.Name = "Col_idUnit"
        '
        'Col_UnitName
        '
        Me.Col_UnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Col_UnitName.AppearanceCell.Options.UseBackColor = True
        Me.Col_UnitName.AppearanceCell.Options.UseTextOptions = True
        Me.Col_UnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_UnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_UnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_UnitName.Caption = "หน่วย"
        Me.Col_UnitName.FieldName = "UnitName"
        Me.Col_UnitName.MaxWidth = 100
        Me.Col_UnitName.MinWidth = 50
        Me.Col_UnitName.Name = "Col_UnitName"
        Me.Col_UnitName.OptionsColumn.AllowEdit = False
        Me.Col_UnitName.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[True]
        Me.Col_UnitName.OptionsColumn.ReadOnly = True
        Me.Col_UnitName.Visible = True
        Me.Col_UnitName.VisibleIndex = 4
        Me.Col_UnitName.Width = 100
        '
        'Col_idwh
        '
        Me.Col_idwh.FieldName = "idwh"
        Me.Col_idwh.Name = "Col_idwh"
        '
        'Col_WareHouseName
        '
        Me.Col_WareHouseName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Col_WareHouseName.AppearanceCell.Options.UseBackColor = True
        Me.Col_WareHouseName.AppearanceCell.Options.UseTextOptions = True
        Me.Col_WareHouseName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_WareHouseName.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_WareHouseName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_WareHouseName.Caption = "คลัง"
        Me.Col_WareHouseName.FieldName = "WareHouseName"
        Me.Col_WareHouseName.MaxWidth = 120
        Me.Col_WareHouseName.MinWidth = 100
        Me.Col_WareHouseName.Name = "Col_WareHouseName"
        Me.Col_WareHouseName.OptionsColumn.AllowEdit = False
        Me.Col_WareHouseName.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[True]
        Me.Col_WareHouseName.Visible = True
        Me.Col_WareHouseName.VisibleIndex = 5
        Me.Col_WareHouseName.Width = 120
        '
        'FrmInvLotSelectAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 551)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInvLotSelectAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการสต็อกวัสดุ และสินค้า"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonPd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtLotNum As System.Windows.Forms.TextBox
    Friend WithEvents ChkType As System.Windows.Forms.CheckBox
    Friend WithEvents CHKLotNum As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPd As System.Windows.Forms.CheckBox
    Friend WithEvents txtPdName As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btnSchPd As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Col_idInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Select_check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckPd As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Select_Button As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonPd As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Col_LotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_idwh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_InvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_InvGroupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_UnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_idUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPdName As System.Windows.Forms.CheckBox
    Friend WithEvents cbType As System.Windows.Forms.CheckBox
    Friend WithEvents cpLotNo As System.Windows.Forms.CheckBox
    Friend WithEvents Col_idLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_idRefLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_idInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_WareHouseName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CBLot As System.Windows.Forms.CheckBox
    Friend WithEvents CHKWh As System.Windows.Forms.CheckBox
    Friend WithEvents cmbWhFrom As System.Windows.Forms.ComboBox
End Class
