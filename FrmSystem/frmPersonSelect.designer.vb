<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonSelect))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.lblField = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GC_Person = New DevExpress.XtraGrid.GridControl()
        Me.gv_Person = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSelectx1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptChkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColidPs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsCodex = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsNamex = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCompName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GvProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GC_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptChkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 36)
        Me.Panel1.TabIndex = 414
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(134, 34)
        Me.btn_save.TabIndex = 393
        Me.btn_save.Tag = "Add"
        Me.btn_save.Text = "   เลือกทั้งหมด"
        Me.btn_save.UseVisualStyleBackColor = False
        Me.btn_save.Visible = False
        '
        'txtCondition
        '
        Me.txtCondition.BackColor = System.Drawing.Color.White
        Me.txtCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCondition.Location = New System.Drawing.Point(306, 14)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(162, 22)
        Me.txtCondition.TabIndex = 405
        Me.txtCondition.Tag = "  "
        '
        'lblField
        '
        Me.lblField.AutoSize = True
        Me.lblField.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblField.Location = New System.Drawing.Point(229, 17)
        Me.lblField.Name = "lblField"
        Me.lblField.Size = New System.Drawing.Size(74, 16)
        Me.lblField.TabIndex = 404
        Me.lblField.Tag = "  "
        Me.lblField.Text = "ค้นหาพนักงาน"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtCondition)
        Me.Panel2.Controls.Add(Me.lblField)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 51)
        Me.Panel2.TabIndex = 415
        '
        'GC_Person
        '
        Me.GC_Person.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Person.Location = New System.Drawing.Point(0, 87)
        Me.GC_Person.MainView = Me.gv_Person
        Me.GC_Person.Name = "GC_Person"
        Me.GC_Person.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsSelect, Me.rptChkEdit})
        Me.GC_Person.Size = New System.Drawing.Size(784, 454)
        Me.GC_Person.TabIndex = 677
        Me.GC_Person.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Person, Me.GvProduct})
        '
        'gv_Person
        '
        Me.gv_Person.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.gv_Person.Appearance.EvenRow.Options.UseFont = True
        Me.gv_Person.Appearance.FocusedCell.BackColor = System.Drawing.Color.CornflowerBlue
        Me.gv_Person.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.gv_Person.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv_Person.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv_Person.Appearance.FocusedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.gv_Person.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gv_Person.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv_Person.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv_Person.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gv_Person.Appearance.HeaderPanel.Options.UseFont = True
        Me.gv_Person.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gv_Person.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv_Person.Appearance.Row.BackColor = System.Drawing.Color.CornflowerBlue
        Me.gv_Person.Appearance.Row.Options.UseBackColor = True
        Me.gv_Person.Appearance.Row.Options.UseFont = True
        Me.gv_Person.Appearance.SelectedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.gv_Person.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv_Person.ColumnPanelRowHeight = 30
        Me.gv_Person.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSelectx1, Me.ColSelect, Me.ColidPs, Me.ColPsCodex, Me.ColPsNamex, Me.ColPosition, Me.ColCompName})
        Me.gv_Person.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_Person.GridControl = Me.GC_Person
        Me.gv_Person.GroupFormat = "[#image]{1} {2}"
        Me.gv_Person.Name = "gv_Person"
        Me.gv_Person.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gv_Person.OptionsView.ShowGroupPanel = False
        Me.gv_Person.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Person.OptionsView.ShowIndicator = False
        '
        'ColSelectx1
        '
        Me.ColSelectx1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.ColSelectx1.AppearanceCell.Options.UseBackColor = True
        Me.ColSelectx1.Caption = "เลือก"
        Me.ColSelectx1.ColumnEdit = Me.rpsSelect
        Me.ColSelectx1.MaxWidth = 40
        Me.ColSelectx1.MinWidth = 40
        Me.ColSelectx1.Name = "ColSelectx1"
        Me.ColSelectx1.Visible = True
        Me.ColSelectx1.VisibleIndex = 1
        Me.ColSelectx1.Width = 40
        '
        'rpsSelect
        '
        Me.rpsSelect.AutoHeight = False
        Me.rpsSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rpsSelect.Name = "rpsSelect"
        Me.rpsSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColSelect
        '
        Me.ColSelect.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.ColSelect.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColSelect.AppearanceCell.Options.UseBackColor = True
        Me.ColSelect.AppearanceCell.Options.UseForeColor = True
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.rptChkEdit
        Me.ColSelect.FieldName = "ChkKey"
        Me.ColSelect.MaxWidth = 40
        Me.ColSelect.MinWidth = 40
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Visible = True
        Me.ColSelect.VisibleIndex = 0
        Me.ColSelect.Width = 40
        '
        'rptChkEdit
        '
        Me.rptChkEdit.AutoHeight = False
        Me.rptChkEdit.Name = "rptChkEdit"
        '
        'ColidPs
        '
        Me.ColidPs.Caption = "idPs"
        Me.ColidPs.FieldName = "idPs"
        Me.ColidPs.Name = "ColidPs"
        '
        'ColPsCodex
        '
        Me.ColPsCodex.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsCodex.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColPsCodex.AppearanceCell.Options.UseBackColor = True
        Me.ColPsCodex.AppearanceCell.Options.UseForeColor = True
        Me.ColPsCodex.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsCodex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsCodex.Caption = "รหัสพนักงาน"
        Me.ColPsCodex.FieldName = "PsCode"
        Me.ColPsCodex.MaxWidth = 80
        Me.ColPsCodex.MinWidth = 80
        Me.ColPsCodex.Name = "ColPsCodex"
        Me.ColPsCodex.OptionsColumn.AllowEdit = False
        Me.ColPsCodex.OptionsColumn.ReadOnly = True
        Me.ColPsCodex.OptionsColumn.TabStop = False
        Me.ColPsCodex.Visible = True
        Me.ColPsCodex.VisibleIndex = 2
        Me.ColPsCodex.Width = 80
        '
        'ColPsNamex
        '
        Me.ColPsNamex.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColPsNamex.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColPsNamex.AppearanceCell.Options.UseBackColor = True
        Me.ColPsNamex.AppearanceCell.Options.UseForeColor = True
        Me.ColPsNamex.Caption = "ชื่อ - นามสกุล"
        Me.ColPsNamex.FieldName = "PsName"
        Me.ColPsNamex.Name = "ColPsNamex"
        Me.ColPsNamex.OptionsColumn.AllowEdit = False
        Me.ColPsNamex.OptionsColumn.ReadOnly = True
        Me.ColPsNamex.OptionsColumn.TabStop = False
        Me.ColPsNamex.Visible = True
        Me.ColPsNamex.VisibleIndex = 3
        Me.ColPsNamex.Width = 490
        '
        'ColPosition
        '
        Me.ColPosition.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPosition.AppearanceCell.Options.UseBackColor = True
        Me.ColPosition.Caption = "ตำแหน่ง"
        Me.ColPosition.FieldName = "PositionName"
        Me.ColPosition.MinWidth = 180
        Me.ColPosition.Name = "ColPosition"
        Me.ColPosition.OptionsColumn.AllowEdit = False
        Me.ColPosition.OptionsColumn.ReadOnly = True
        Me.ColPosition.OptionsColumn.TabStop = False
        Me.ColPosition.Visible = True
        Me.ColPosition.VisibleIndex = 4
        Me.ColPosition.Width = 180
        '
        'ColCompName
        '
        Me.ColCompName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCompName.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColCompName.AppearanceCell.Options.UseBackColor = True
        Me.ColCompName.AppearanceCell.Options.UseForeColor = True
        Me.ColCompName.AppearanceCell.Options.UseTextOptions = True
        Me.ColCompName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCompName.Caption = "สังกัดบริษัท"
        Me.ColCompName.FieldName = "CompName"
        Me.ColCompName.MinWidth = 200
        Me.ColCompName.Name = "ColCompName"
        Me.ColCompName.OptionsColumn.AllowEdit = False
        Me.ColCompName.OptionsColumn.ReadOnly = True
        Me.ColCompName.OptionsColumn.TabStop = False
        Me.ColCompName.Visible = True
        Me.ColCompName.VisibleIndex = 5
        Me.ColCompName.Width = 200
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
        Me.GvProduct.GridControl = Me.GC_Person
        Me.GvProduct.Name = "GvProduct"
        Me.GvProduct.OptionsView.ColumnAutoWidth = False
        Me.GvProduct.OptionsView.ShowGroupPanel = False
        Me.GvProduct.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GvProduct.OptionsView.ShowIndicator = False
        '
        'frmPersonSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(784, 541)
        Me.Controls.Add(Me.GC_Person)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersonSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาพนักงานจาก HR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GC_Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptChkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCondition As System.Windows.Forms.TextBox
    Friend WithEvents lblField As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GC_Person As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Person As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSelectx1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptChkEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColidPs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsCodex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsNamex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GvProduct As DevExpress.XtraGrid.Views.Grid.GridView
End Class
