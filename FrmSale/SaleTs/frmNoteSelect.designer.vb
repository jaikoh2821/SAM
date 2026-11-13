<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoteSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNoteSelect))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.pnSave = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNoteHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnSave.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnSave
        '
        Me.pnSave.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnSave.Controls.Add(Me.btnSave)
        Me.pnSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnSave.Location = New System.Drawing.Point(0, 472)
        Me.pnSave.Name = "pnSave"
        Me.pnSave.Size = New System.Drawing.Size(664, 31)
        Me.pnSave.TabIndex = 666
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 31)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Tag = "Save"
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 39)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSel, Me.rptDel})
        Me.GridControl1.Size = New System.Drawing.Size(664, 433)
        Me.GridControl1.TabIndex = 667
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightCyan
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightCyan
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.ColumnPanelRowHeight = 35
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSel, Me.colNum, Me.colidNote, Me.colNote, Me.ColNoteHide, Me.colDel})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colSel
        '
        Me.colSel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSel.AppearanceHeader.Options.UseFont = True
        Me.colSel.AppearanceHeader.Options.UseTextOptions = True
        Me.colSel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSel.Caption = "เลือก"
        Me.colSel.ColumnEdit = Me.rptSel
        Me.colSel.MaxWidth = 40
        Me.colSel.MinWidth = 40
        Me.colSel.Name = "colSel"
        Me.colSel.Width = 40
        '
        'rptSel
        '
        Me.rptSel.AutoHeight = False
        Me.rptSel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptSel.Name = "rptSel"
        Me.rptSel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colNum
        '
        Me.colNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNum.AppearanceHeader.Options.UseFont = True
        Me.colNum.AppearanceHeader.Options.UseTextOptions = True
        Me.colNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNum.Caption = "ลำดับ"
        Me.colNum.MaxWidth = 40
        Me.colNum.MinWidth = 40
        Me.colNum.Name = "colNum"
        Me.colNum.OptionsColumn.AllowEdit = False
        Me.colNum.OptionsColumn.ReadOnly = True
        Me.colNum.Width = 40
        '
        'colidNote
        '
        Me.colidNote.Caption = "idNote"
        Me.colidNote.FieldName = "idNote"
        Me.colidNote.Name = "colidNote"
        '
        'colNote
        '
        Me.colNote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNote.AppearanceHeader.Options.UseFont = True
        Me.colNote.AppearanceHeader.Options.UseTextOptions = True
        Me.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNote.Caption = "คำอธิบายรายการ"
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.OptionsColumn.AllowEdit = False
        Me.colNote.OptionsColumn.ReadOnly = True
        Me.colNote.Visible = True
        Me.colNote.VisibleIndex = 0
        Me.colNote.Width = 322
        '
        'ColNoteHide
        '
        Me.ColNoteHide.Caption = "ซ่อนคำอธิบายรายการ"
        Me.ColNoteHide.FieldName = "NoteHide"
        Me.ColNoteHide.Name = "ColNoteHide"
        '
        'colDel
        '
        Me.colDel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDel.AppearanceHeader.Options.UseFont = True
        Me.colDel.AppearanceHeader.Options.UseTextOptions = True
        Me.colDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDel.Caption = "ลบ"
        Me.colDel.ColumnEdit = Me.rptDel
        Me.colDel.MaxWidth = 30
        Me.colDel.MinWidth = 30
        Me.colDel.Name = "colDel"
        Me.colDel.Visible = True
        Me.colDel.VisibleIndex = 1
        Me.colDel.Width = 30
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.cross_circle_frame, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.cmbGroupComp)
        Me.PanelControl3.Controls.Add(Me.Label3)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(664, 39)
        Me.PanelControl3.TabIndex = 729
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(247, 10)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(211, 21)
        Me.cmbGroupComp.TabIndex = 765
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 766
        Me.Label3.Text = "บริษัท :"
        '
        'frmNoteSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(664, 503)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.pnSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNoteSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSelNote"
        Me.pnSave.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnSave As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents colidNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNoteHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
