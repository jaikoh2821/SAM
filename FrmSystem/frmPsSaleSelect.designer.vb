<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPsSaleSelect
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPsSaleSelect))
        Me.rdbSaleTC = New System.Windows.Forms.RadioButton()
        Me.rdbSaleBill = New System.Windows.Forms.RadioButton()
        Me.rdbSaleAll = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPsCus = New System.Windows.Forms.Label()
        Me.rdbSaleQuit = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GCSale = New DevExpress.XtraGrid.GridControl()
        Me.GVSale = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColidPsSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GvProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbSaleTC
        '
        Me.rdbSaleTC.AutoSize = True
        Me.rdbSaleTC.Checked = True
        Me.rdbSaleTC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSaleTC.Location = New System.Drawing.Point(18, 17)
        Me.rdbSaleTC.Name = "rdbSaleTC"
        Me.rdbSaleTC.Size = New System.Drawing.Size(173, 17)
        Me.rdbSaleTC.TabIndex = 0
        Me.rdbSaleTC.TabStop = True
        Me.rdbSaleTC.Text = "พนักงานขายที่ดูแลเขตของลูกค้า"
        Me.rdbSaleTC.UseVisualStyleBackColor = True
        '
        'rdbSaleBill
        '
        Me.rdbSaleBill.AutoSize = True
        Me.rdbSaleBill.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSaleBill.Location = New System.Drawing.Point(18, 40)
        Me.rdbSaleBill.Name = "rdbSaleBill"
        Me.rdbSaleBill.Size = New System.Drawing.Size(164, 17)
        Me.rdbSaleBill.TabIndex = 2
        Me.rdbSaleBill.Text = "พนักงานขายที่ลูกค้าเคยเปิดบิล"
        Me.rdbSaleBill.UseVisualStyleBackColor = True
        '
        'rdbSaleAll
        '
        Me.rdbSaleAll.AutoSize = True
        Me.rdbSaleAll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSaleAll.Location = New System.Drawing.Point(239, 17)
        Me.rdbSaleAll.Name = "rdbSaleAll"
        Me.rdbSaleAll.Size = New System.Drawing.Size(115, 17)
        Me.rdbSaleAll.TabIndex = 1
        Me.rdbSaleAll.Text = "พนักงานขายทั้งหมด"
        Me.rdbSaleAll.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 604
        Me.Label6.Text = "ชื่อลูกค้า :"
        '
        'lblPsCus
        '
        Me.lblPsCus.BackColor = System.Drawing.Color.Transparent
        Me.lblPsCus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPsCus.ForeColor = System.Drawing.Color.Black
        Me.lblPsCus.Location = New System.Drawing.Point(73, 7)
        Me.lblPsCus.Name = "lblPsCus"
        Me.lblPsCus.Size = New System.Drawing.Size(409, 20)
        Me.lblPsCus.TabIndex = 605
        Me.lblPsCus.Text = "-"
        Me.lblPsCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdbSaleQuit
        '
        Me.rdbSaleQuit.AutoSize = True
        Me.rdbSaleQuit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSaleQuit.Location = New System.Drawing.Point(239, 40)
        Me.rdbSaleQuit.Name = "rdbSaleQuit"
        Me.rdbSaleQuit.Size = New System.Drawing.Size(141, 17)
        Me.rdbSaleQuit.TabIndex = 3
        Me.rdbSaleQuit.Text = "พนักงานขายที่ลาออกแล้ว"
        Me.rdbSaleQuit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbSaleBill)
        Me.GroupBox1.Controls.Add(Me.rdbSaleQuit)
        Me.GroupBox1.Controls.Add(Me.rdbSaleTC)
        Me.GroupBox1.Controls.Add(Me.rdbSaleAll)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 69)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GCSale
        '
        Me.GCSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSale.Location = New System.Drawing.Point(0, 121)
        Me.GCSale.MainView = Me.GVSale
        Me.GCSale.Name = "GCSale"
        Me.GCSale.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsSelect})
        Me.GCSale.Size = New System.Drawing.Size(494, 421)
        Me.GCSale.TabIndex = 1
        Me.GCSale.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSale, Me.GvProduct})
        '
        'GVSale
        '
        Me.GVSale.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GVSale.Appearance.EvenRow.Options.UseFont = True
        Me.GVSale.Appearance.FocusedCell.BackColor = System.Drawing.Color.Wheat
        Me.GVSale.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVSale.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSale.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSale.Appearance.FocusedRow.BackColor = System.Drawing.Color.Wheat
        Me.GVSale.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVSale.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSale.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSale.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVSale.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVSale.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVSale.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVSale.Appearance.Row.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GVSale.Appearance.Row.Options.UseBackColor = True
        Me.GVSale.Appearance.Row.Options.UseFont = True
        Me.GVSale.Appearance.SelectedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GVSale.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSale.ColumnPanelRowHeight = 30
        Me.GVSale.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.ColidPsSale, Me.ColPsName})
        Me.GVSale.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSale.GridControl = Me.GCSale
        Me.GVSale.GroupFormat = "[#image]{1} {2}"
        Me.GVSale.Name = "GVSale"
        Me.GVSale.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSale.OptionsView.ShowGroupPanel = False
        Me.GVSale.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVSale.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.GridColumn1.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn1.Caption = "เลือก"
        Me.GridColumn1.ColumnEdit = Me.rpsSelect
        Me.GridColumn1.FieldName = "ChkKey"
        Me.GridColumn1.MaxWidth = 40
        Me.GridColumn1.MinWidth = 40
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 40
        '
        'rpsSelect
        '
        Me.rpsSelect.AutoHeight = False
        Me.rpsSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rpsSelect.Name = "rpsSelect"
        Me.rpsSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColidPsSale
        '
        Me.ColidPsSale.Caption = "idPsSale"
        Me.ColidPsSale.FieldName = "idPsSale"
        Me.ColidPsSale.Name = "ColidPsSale"
        '
        'ColPsName
        '
        Me.ColPsName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColPsName.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColPsName.AppearanceCell.Options.UseBackColor = True
        Me.ColPsName.AppearanceCell.Options.UseForeColor = True
        Me.ColPsName.Caption = "ชื่อพนักงานขาย"
        Me.ColPsName.FieldName = "PsName"
        Me.ColPsName.Name = "ColPsName"
        Me.ColPsName.OptionsColumn.AllowEdit = False
        Me.ColPsName.OptionsColumn.ReadOnly = True
        Me.ColPsName.Visible = True
        Me.ColPsName.VisibleIndex = 1
        Me.ColPsName.Width = 564
        '
        'GvProduct
        '
        Me.GvProduct.Appearance.FocusedCell.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvProduct.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GvProduct.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvProduct.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvProduct.Appearance.FocusedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvProduct.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvProduct.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvProduct.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvProduct.Appearance.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvProduct.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GvProduct.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvProduct.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvProduct.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GvProduct.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GvProduct.DetailHeight = 600
        Me.GvProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GvProduct.GridControl = Me.GCSale
        Me.GvProduct.Name = "GvProduct"
        Me.GvProduct.OptionsView.ColumnAutoWidth = False
        Me.GvProduct.OptionsView.ShowGroupPanel = False
        Me.GvProduct.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GvProduct.OptionsView.ShowIndicator = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.lblPsCus)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 86)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(494, 35)
        Me.PanelControl2.TabIndex = 721
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(494, 86)
        Me.PanelControl1.TabIndex = 0
        '
        'frmPsSaleSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(494, 542)
        Me.Controls.Add(Me.GCSale)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPsSaleSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลเจ้าหน้าที่ขาย"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdbSaleTC As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSaleBill As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSaleAll As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPsCus As System.Windows.Forms.Label
    Friend WithEvents rdbSaleQuit As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GCSale As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSale As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColidPsSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GvProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
