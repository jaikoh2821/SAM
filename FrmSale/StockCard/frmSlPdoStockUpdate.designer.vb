<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlPdoStockUpdate
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.lotNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._operator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbOperator = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnote = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPsAction = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_addPdo = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txtPsCommand = New System.Windows.Forms.TextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_PsAction = New System.Windows.Forms.Button()
        Me.btn_Pscommand = New System.Windows.Forms.Button()
        Me.btn_note = New System.Windows.Forms.Button()
        Me.btn_operetor = New System.Windows.Forms.Button()
        Me.gc = New DevExpress.XtraGrid.GridControl()
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.change = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.note = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvdel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.cbOperator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lotNum
        '
        Me.lotNum.Caption = "เลขที่ Lot"
        Me.lotNum.FieldName = "lotName"
        Me.lotNum.Name = "lotNum"
        Me.lotNum.OptionsColumn.AllowEdit = False
        Me.lotNum.OptionsColumn.FixedWidth = True
        Me.lotNum.Visible = True
        Me.lotNum.VisibleIndex = 0
        Me.lotNum.Width = 77
        '
        '_operator
        '
        Me._operator.AppearanceCell.Options.HighPriority = True
        Me._operator.AppearanceCell.Options.UseTextOptions = True
        Me._operator.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me._operator.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me._operator.AppearanceHeader.Options.UseBackColor = True
        Me._operator.Caption = "ตัวดำเนินการ"
        Me._operator.ColumnEdit = Me.cbOperator
        Me._operator.FieldName = "operator"
        Me._operator.Name = "_operator"
        Me._operator.OptionsColumn.FixedWidth = True
        Me._operator.Visible = True
        Me._operator.VisibleIndex = 3
        Me._operator.Width = 71
        '
        'cbOperator
        '
        Me.cbOperator.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOperator.Items.AddRange(New Object() {"+", "-", "="})
        Me.cbOperator.Name = "cbOperator"
        Me.cbOperator.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(538, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 685
        Me.Label2.Text = "*หมายเหตุ"
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(600, 12)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(221, 70)
        Me.txtnote.TabIndex = 678
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 684
        Me.Label1.Text = "ชื่อพนักงานปฏิบัติงาน"
        '
        'txtPsAction
        '
        Me.txtPsAction.Enabled = False
        Me.txtPsAction.Location = New System.Drawing.Point(306, 56)
        Me.txtPsAction.Name = "txtPsAction"
        Me.txtPsAction.Size = New System.Drawing.Size(176, 20)
        Me.txtPsAction.TabIndex = 683
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 682
        Me.Label6.Text = "ชื่อพนักงานออกคำสั่ง"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_addPdo)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1059, 40)
        Me.Panel1.TabIndex = 680
        '
        'btn_addPdo
        '
        Me.btn_addPdo.BackColor = System.Drawing.Color.DimGray
        Me.btn_addPdo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addPdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_addPdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_addPdo.ForeColor = System.Drawing.Color.White
        Me.btn_addPdo.Image = Global.SAM.My.Resources.Resources.adddoc
        Me.btn_addPdo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addPdo.Location = New System.Drawing.Point(126, 0)
        Me.btn_addPdo.Name = "btn_addPdo"
        Me.btn_addPdo.Size = New System.Drawing.Size(126, 38)
        Me.btn_addPdo.TabIndex = 2
        Me.btn_addPdo.Tag = ""
        Me.btn_addPdo.Text = "       เพิ่มรายการ"
        Me.btn_addPdo.UseVisualStyleBackColor = False
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
        Me.btn_save.Size = New System.Drawing.Size(126, 38)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Tag = ""
        Me.btn_save.Text = "    บันทึกข้อมูล"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txtPsCommand
        '
        Me.txtPsCommand.Enabled = False
        Me.txtPsCommand.Location = New System.Drawing.Point(306, 18)
        Me.txtPsCommand.Name = "txtPsCommand"
        Me.txtPsCommand.Size = New System.Drawing.Size(176, 20)
        Me.txtPsCommand.TabIndex = 681
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewImageColumn1.HeaderText = "ประวัติบันทึก"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 50
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "ลบ"
        Me.DataGridViewImageColumn2.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 30
        '
        'btn_PsAction
        '
        Me.btn_PsAction.AutoSize = True
        Me.btn_PsAction.BackColor = System.Drawing.Color.DimGray
        Me.btn_PsAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_PsAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_PsAction.ForeColor = System.Drawing.Color.White
        Me.btn_PsAction.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_PsAction.Location = New System.Drawing.Point(488, 48)
        Me.btn_PsAction.Name = "btn_PsAction"
        Me.btn_PsAction.Size = New System.Drawing.Size(30, 30)
        Me.btn_PsAction.TabIndex = 677
        Me.btn_PsAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_PsAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_PsAction.UseVisualStyleBackColor = False
        '
        'btn_Pscommand
        '
        Me.btn_Pscommand.AutoSize = True
        Me.btn_Pscommand.BackColor = System.Drawing.Color.DimGray
        Me.btn_Pscommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Pscommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Pscommand.ForeColor = System.Drawing.Color.White
        Me.btn_Pscommand.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_Pscommand.Location = New System.Drawing.Point(488, 12)
        Me.btn_Pscommand.Name = "btn_Pscommand"
        Me.btn_Pscommand.Size = New System.Drawing.Size(30, 30)
        Me.btn_Pscommand.TabIndex = 676
        Me.btn_Pscommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Pscommand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Pscommand.UseVisualStyleBackColor = False
        '
        'btn_note
        '
        Me.btn_note.AutoSize = True
        Me.btn_note.BackColor = System.Drawing.Color.DimGray
        Me.btn_note.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_note.ForeColor = System.Drawing.Color.White
        Me.btn_note.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_note.Location = New System.Drawing.Point(848, 56)
        Me.btn_note.Name = "btn_note"
        Me.btn_note.Size = New System.Drawing.Size(160, 38)
        Me.btn_note.TabIndex = 687
        Me.btn_note.Text = "ระบุหมายเหตุทั้งหมด"
        Me.btn_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_note.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_note.UseVisualStyleBackColor = False
        '
        'btn_operetor
        '
        Me.btn_operetor.AutoSize = True
        Me.btn_operetor.BackColor = System.Drawing.Color.DimGray
        Me.btn_operetor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_operetor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_operetor.ForeColor = System.Drawing.Color.White
        Me.btn_operetor.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_operetor.Location = New System.Drawing.Point(848, 12)
        Me.btn_operetor.Name = "btn_operetor"
        Me.btn_operetor.Size = New System.Drawing.Size(199, 38)
        Me.btn_operetor.TabIndex = 686
        Me.btn_operetor.Text = "เปลี่ยนตัวดำเนินการทั้งหมด"
        Me.btn_operetor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_operetor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_operetor.UseVisualStyleBackColor = False
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gc.Location = New System.Drawing.Point(0, 144)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbOperator, Me.btnDel})
        Me.gc.Size = New System.Drawing.Size(1059, 369)
        Me.gc.TabIndex = 688
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv.Appearance.Row.Options.UseTextOptions = True
        Me.gv.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.lotNum, Me.GridColumn2, Me.GridColumn3, Me._operator, Me.change, Me.GridColumn6, Me.GridColumn7, Me.note, Me.gvdel, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14})
        Me.gv.CustomizationFormBounds = New System.Drawing.Rectangle(2472, 436, 216, 183)
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.lotNum
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition2.Column = Me.lotNum
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[amountN] < 0   Or [operator] ==  ''   Or [note] == ''"
        Me.gv.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridColumn2.AppearanceCell.Options.HighPriority = True
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.Caption = "ชื่อสินค้า"
        Me.GridColumn2.FieldName = "name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 197
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.Caption = "จำานวนคงเหลือ"
        Me.GridColumn3.DisplayFormat.FormatString = "#,##0.##"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "amount"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 83
        '
        'change
        '
        Me.change.AppearanceCell.Options.UseTextOptions = True
        Me.change.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.change.Caption = "จำนวนที่เปลี่ยนแปลง"
        Me.change.DisplayFormat.FormatString = "#,##0.##"
        Me.change.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.change.FieldName = "change"
        Me.change.Name = "change"
        Me.change.OptionsColumn.FixedWidth = True
        Me.change.Visible = True
        Me.change.VisibleIndex = 4
        Me.change.Width = 110
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn6.Caption = "ยอดคงเหลือใหม่"
        Me.GridColumn6.DisplayFormat.FormatString = "#,##0.##"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "amountN"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 91
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.Caption = "หน่วย"
        Me.GridColumn7.FieldName = "unit"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.FixedWidth = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 51
        '
        'note
        '
        Me.note.Caption = "*หมายเหตุ"
        Me.note.FieldName = "note"
        Me.note.Name = "note"
        Me.note.Visible = True
        Me.note.VisibleIndex = 7
        Me.note.Width = 126
        '
        'gvdel
        '
        Me.gvdel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gvdel.AppearanceCell.Options.HighPriority = True
        Me.gvdel.AppearanceCell.Options.UseBackColor = True
        Me.gvdel.Caption = "ลบ"
        Me.gvdel.ColumnEdit = Me.btnDel
        Me.gvdel.Name = "gvdel"
        Me.gvdel.OptionsColumn.FixedWidth = True
        Me.gvdel.Visible = True
        Me.gvdel.VisibleIndex = 8
        Me.gvdel.Width = 44
        '
        'btnDel
        '
        Me.btnDel.AutoHeight = False
        Me.btnDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.cross_circle_frame, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btnDel.Name = "btnDel"
        Me.btnDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "idPdLot"
        Me.GridColumn10.FieldName = "idPdOLot"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "BarCode"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Code"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "OP"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "แปลงหหน่วย"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'frmSlPdoStockUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1059, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gc)
        Me.Controls.Add(Me.btn_note)
        Me.Controls.Add(Me.btn_operetor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.btn_PsAction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPsAction)
        Me.Controls.Add(Me.btn_Pscommand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPsCommand)
        Me.Name = "frmSlPdoStockUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เมนูการปรับจำนวนสินค้าอื่น ๆ"
        CType(Me.cbOperator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnote As System.Windows.Forms.TextBox
    Friend WithEvents btn_PsAction As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPsAction As System.Windows.Forms.TextBox
    Friend WithEvents btn_Pscommand As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPsCommand As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btn_note As System.Windows.Forms.Button
    Friend WithEvents btn_operetor As System.Windows.Forms.Button
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lotNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _operator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents change As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents note As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvdel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbOperator As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_addPdo As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
End Class
