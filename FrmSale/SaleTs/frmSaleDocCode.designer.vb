<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleDocCode
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
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaleDocCode))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GCNote = New DevExpress.XtraGrid.GridControl()
        Me.GVNote = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNoteHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptMemEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.rptSel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GCNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptMemEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(88, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "คำอธิบายรหัสเอกสาร"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Label1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(344, 39)
        Me.PanelControl3.TabIndex = 730
        '
        'GCNote
        '
        Me.GCNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GCNote.Location = New System.Drawing.Point(0, 39)
        Me.GCNote.MainView = Me.GVNote
        Me.GCNote.Name = "GCNote"
        Me.GCNote.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSel, Me.rptDel, Me.rptMemEdit})
        Me.GCNote.Size = New System.Drawing.Size(344, 323)
        Me.GCNote.TabIndex = 731
        Me.GCNote.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVNote})
        '
        'GVNote
        '
        Me.GVNote.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightCyan
        Me.GVNote.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVNote.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightCyan
        Me.GVNote.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVNote.ColumnPanelRowHeight = 35
        Me.GVNote.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColNoteHide, Me.colNote})
        Me.GVNote.GridControl = Me.GCNote
        Me.GVNote.IndicatorWidth = 35
        Me.GVNote.Name = "GVNote"
        Me.GVNote.OptionsMenu.EnableColumnMenu = False
        Me.GVNote.OptionsView.RowAutoHeight = True
        Me.GVNote.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVNote.OptionsView.ShowGroupPanel = False
        Me.GVNote.OptionsView.ShowIndicator = False
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 40
        Me.ColNum.MinWidth = 40
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.AllowFocus = False
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 40
        '
        'ColNoteHide
        '
        Me.ColNoteHide.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNoteHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNoteHide.AppearanceCell.Options.UseBackColor = True
        Me.ColNoteHide.AppearanceCell.Options.UseFont = True
        Me.ColNoteHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNoteHide.AppearanceHeader.Options.UseFont = True
        Me.ColNoteHide.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNoteHide.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNoteHide.Caption = "รหัสอินวอยส์"
        Me.ColNoteHide.FieldName = "SaleCode"
        Me.ColNoteHide.MinWidth = 85
        Me.ColNoteHide.Name = "ColNoteHide"
        Me.ColNoteHide.OptionsColumn.AllowFocus = False
        Me.ColNoteHide.Visible = True
        Me.ColNoteHide.VisibleIndex = 1
        Me.ColNoteHide.Width = 85
        '
        'colNote
        '
        Me.colNote.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colNote.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colNote.AppearanceCell.Options.UseBackColor = True
        Me.colNote.AppearanceCell.Options.UseFont = True
        Me.colNote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colNote.AppearanceHeader.Options.UseFont = True
        Me.colNote.AppearanceHeader.Options.UseTextOptions = True
        Me.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNote.Caption = "คำอธิบาย"
        Me.colNote.ColumnEdit = Me.rptMemEdit
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.OptionsColumn.AllowEdit = False
        Me.colNote.OptionsColumn.AllowFocus = False
        Me.colNote.Visible = True
        Me.colNote.VisibleIndex = 2
        Me.colNote.Width = 1523
        '
        'rptMemEdit
        '
        Me.rptMemEdit.Appearance.Options.UseTextOptions = True
        Me.rptMemEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptMemEdit.Name = "rptMemEdit"
        '
        'rptSel
        '
        Me.rptSel.AutoHeight = False
        Me.rptSel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptSel.Name = "rptSel"
        Me.rptSel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.cross_circle_frame, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frmSaleDocCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(344, 362)
        Me.Controls.Add(Me.GCNote)
        Me.Controls.Add(Me.PanelControl3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaleDocCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รหัสเอกสาร"
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.GCNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptMemEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCNote As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVNote As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNoteHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptMemEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
