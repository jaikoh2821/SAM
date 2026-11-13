<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlReturnSelectLot
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
        Me.GCData = New DevExpress.XtraGrid.GridControl()
        Me.GvShowData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColLotno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPdPkName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateGen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPricePerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColdtTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColdtType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidPdPk = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCData
        '
        Me.GCData.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GCData.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCData.Location = New System.Drawing.Point(0, 0)
        Me.GCData.MainView = Me.GvShowData
        Me.GCData.Name = "GCData"
        Me.GCData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GCData.Size = New System.Drawing.Size(784, 512)
        Me.GCData.TabIndex = 606
        Me.GCData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvShowData})
        '
        'GvShowData
        '
        Me.GvShowData.ColumnPanelRowHeight = 40
        Me.GvShowData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidLot, Me.ColSelect, Me.ColLotno, Me.ColPdPkName, Me.ColDateGen, Me.ColPricePerUnit, Me.ColUnit, Me.ColdtTypeName, Me.ColdtType, Me.ColidUnit, Me.ColidPdPk})
        Me.GvShowData.GridControl = Me.GCData
        Me.GvShowData.GroupCount = 1
        Me.GvShowData.Name = "GvShowData"
        Me.GvShowData.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GvShowData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GvShowData.OptionsView.ShowGroupPanel = False
        Me.GvShowData.OptionsView.ShowIndicator = False
        Me.GvShowData.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColdtTypeName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColidLot
        '
        Me.ColidLot.Caption = "ColidLot"
        Me.ColidLot.FieldName = "idPdPkLot"
        Me.ColidLot.Name = "ColidLot"
        '
        'ColSelect
        '
        Me.ColSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColSelect.AppearanceHeader.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.ColSelect.MaxWidth = 30
        Me.ColSelect.MinWidth = 30
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Visible = True
        Me.ColSelect.VisibleIndex = 0
        Me.ColSelect.Width = 51
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.FindItemInGrid, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColLotno
        '
        Me.ColLotno.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColLotno.AppearanceCell.Options.UseBackColor = True
        Me.ColLotno.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColLotno.AppearanceHeader.Options.UseFont = True
        Me.ColLotno.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotno.Caption = "Lot No."
        Me.ColLotno.FieldName = "Lotnum"
        Me.ColLotno.Name = "ColLotno"
        Me.ColLotno.Visible = True
        Me.ColLotno.VisibleIndex = 1
        Me.ColLotno.Width = 102
        '
        'ColPdPkName
        '
        Me.ColPdPkName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColPdPkName.AppearanceCell.Options.UseBackColor = True
        Me.ColPdPkName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPdPkName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPdPkName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPdPkName.AppearanceHeader.Options.UseFont = True
        Me.ColPdPkName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPdPkName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdPkName.Caption = "รายการสินค้า"
        Me.ColPdPkName.FieldName = "PdPkName"
        Me.ColPdPkName.Name = "ColPdPkName"
        Me.ColPdPkName.OptionsColumn.AllowEdit = False
        Me.ColPdPkName.OptionsColumn.ReadOnly = True
        Me.ColPdPkName.Visible = True
        Me.ColPdPkName.VisibleIndex = 2
        Me.ColPdPkName.Width = 345
        '
        'ColDateGen
        '
        Me.ColDateGen.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateGen.AppearanceCell.Options.UseBackColor = True
        Me.ColDateGen.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateGen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateGen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateGen.AppearanceHeader.Options.UseFont = True
        Me.ColDateGen.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateGen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateGen.Caption = "วันที่ผลิต"
        Me.ColDateGen.FieldName = "DateGen"
        Me.ColDateGen.Name = "ColDateGen"
        Me.ColDateGen.OptionsColumn.AllowEdit = False
        Me.ColDateGen.OptionsColumn.ReadOnly = True
        Me.ColDateGen.Visible = True
        Me.ColDateGen.VisibleIndex = 3
        Me.ColDateGen.Width = 68
        '
        'ColPricePerUnit
        '
        Me.ColPricePerUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPricePerUnit.AppearanceCell.Options.UseBackColor = True
        Me.ColPricePerUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColPricePerUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPricePerUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColPricePerUnit.AppearanceHeader.Options.UseFont = True
        Me.ColPricePerUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPricePerUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPricePerUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPricePerUnit.Caption = "ราคาต่อหน่วย"
        Me.ColPricePerUnit.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPricePerUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPricePerUnit.FieldName = "CostPerPiece"
        Me.ColPricePerUnit.Name = "ColPricePerUnit"
        Me.ColPricePerUnit.OptionsColumn.AllowEdit = False
        Me.ColPricePerUnit.OptionsColumn.ReadOnly = True
        Me.ColPricePerUnit.Visible = True
        Me.ColPricePerUnit.VisibleIndex = 4
        Me.ColPricePerUnit.Width = 61
        '
        'ColUnit
        '
        Me.ColUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnit.AppearanceCell.Options.UseBackColor = True
        Me.ColUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnit.AppearanceHeader.Options.UseFont = True
        Me.ColUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.Caption = "หน่วย"
        Me.ColUnit.FieldName = "PkUnitName"
        Me.ColUnit.Name = "ColUnit"
        Me.ColUnit.OptionsColumn.AllowEdit = False
        Me.ColUnit.OptionsColumn.ReadOnly = True
        Me.ColUnit.Width = 71
        '
        'ColdtTypeName
        '
        Me.ColdtTypeName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColdtTypeName.AppearanceCell.Options.UseBackColor = True
        Me.ColdtTypeName.AppearanceCell.Options.UseTextOptions = True
        Me.ColdtTypeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColdtTypeName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColdtTypeName.AppearanceHeader.Options.UseFont = True
        Me.ColdtTypeName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColdtTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColdtTypeName.Caption = "ประเภทสินค้า"
        Me.ColdtTypeName.FieldName = "dtTypeName"
        Me.ColdtTypeName.Name = "ColdtTypeName"
        Me.ColdtTypeName.OptionsColumn.AllowEdit = False
        Me.ColdtTypeName.OptionsColumn.ReadOnly = True
        Me.ColdtTypeName.Visible = True
        Me.ColdtTypeName.VisibleIndex = 4
        Me.ColdtTypeName.Width = 63
        '
        'ColdtType
        '
        Me.ColdtType.Caption = "dtType"
        Me.ColdtType.FieldName = "dtType"
        Me.ColdtType.Name = "ColdtType"
        '
        'ColidUnit
        '
        Me.ColidUnit.Caption = "idPkunit "
        Me.ColidUnit.FieldName = "idPkUnit"
        Me.ColidUnit.Name = "ColidUnit"
        '
        'ColidPdPk
        '
        Me.ColidPdPk.Caption = "idPdPk"
        Me.ColidPdPk.FieldName = "idPdPk"
        Me.ColidPdPk.Name = "ColidPdPk"
        '
        'frmSlReturnSelectLot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(784, 512)
        Me.Controls.Add(Me.GCData)
        Me.Name = "frmSlReturnSelectLot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูล Lot No."
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GCData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvShowData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColLotno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPdPkName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateGen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPricePerUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColdtTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColdtType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidPdPk As DevExpress.XtraGrid.Columns.GridColumn
End Class
