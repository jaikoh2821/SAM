<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlReturnSaleList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlReturnSaleList))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocRef = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GvShowData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPartnerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColdtType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCData = New DevExpress.XtraGrid.GridControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDocRef)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "เลขที่บิลขาย"
        '
        'txtDocRef
        '
        Me.txtDocRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDocRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDocRef.Enabled = False
        Me.txtDocRef.Location = New System.Drawing.Point(364, 19)
        Me.txtDocRef.Name = "txtDocRef"
        Me.txtDocRef.Size = New System.Drawing.Size(161, 20)
        Me.txtDocRef.TabIndex = 5
        '
        'btn_add
        '
        Me.btn_add.AutoSize = True
        Me.btn_add.BackColor = System.Drawing.Color.DimGray
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(0, 0)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(96, 38)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = " เลือก"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'GvShowData
        '
        Me.GvShowData.ColumnPanelRowHeight = 45
        Me.GvShowData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSaleDt, Me.ColidLot, Me.ColidSale, Me.ColCheck, Me.ColPartnerName, Me.ColLotNo, Me.ColDocCode, Me.ColDateSale, Me.ColProductName, Me.ColAmtSale, Me.ColUnit, Me.ColdtType})
        Me.GvShowData.GridControl = Me.GCData
        Me.GvShowData.Name = "GvShowData"
        Me.GvShowData.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GvShowData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvShowData.OptionsView.ShowGroupPanel = False
        Me.GvShowData.OptionsView.ShowIndicator = False
        Me.GvShowData.RowHeight = 25
        '
        'ColidSaleDt
        '
        Me.ColidSaleDt.Caption = "idSaleDt"
        Me.ColidSaleDt.FieldName = "idSaleDt"
        Me.ColidSaleDt.Name = "ColidSaleDt"
        '
        'ColidLot
        '
        Me.ColidLot.Caption = "ColidLot"
        Me.ColidLot.FieldName = "idLot"
        Me.ColidLot.Name = "ColidLot"
        '
        'ColidSale
        '
        Me.ColidSale.Caption = "idSale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        '
        'ColCheck
        '
        Me.ColCheck.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColCheck.AppearanceHeader.Options.UseFont = True
        Me.ColCheck.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCheck.Caption = "เลือก"
        Me.ColCheck.FieldName = "ChkKey"
        Me.ColCheck.Name = "ColCheck"
        Me.ColCheck.Visible = True
        Me.ColCheck.VisibleIndex = 0
        Me.ColCheck.Width = 42
        '
        'ColPartnerName
        '
        Me.ColPartnerName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPartnerName.Caption = "ชื่อลูกค้า"
        Me.ColPartnerName.FieldName = "PartnerName"
        Me.ColPartnerName.Name = "ColPartnerName"
        '
        'ColLotNo
        '
        Me.ColLotNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColLotNo.AppearanceCell.Options.UseBackColor = True
        Me.ColLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColLotNo.AppearanceHeader.Options.UseFont = True
        Me.ColLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.Caption = "Lot No."
        Me.ColLotNo.FieldName = "LotNo"
        Me.ColLotNo.Name = "ColLotNo"
        Me.ColLotNo.OptionsColumn.AllowEdit = False
        Me.ColLotNo.OptionsColumn.ReadOnly = True
        Me.ColLotNo.OptionsColumn.TabStop = False
        Me.ColLotNo.Visible = True
        Me.ColLotNo.VisibleIndex = 2
        Me.ColLotNo.Width = 100
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocCode.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.Caption = "เลขที่บิล"
        Me.ColDocCode.FieldName = "DocRef"
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.OptionsColumn.TabStop = False
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 1
        Me.ColDocCode.Width = 100
        '
        'ColDateSale
        '
        Me.ColDateSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSale.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColDateSale.AppearanceHeader.Options.UseBackColor = True
        Me.ColDateSale.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.Caption = "วันที่ขาย"
        Me.ColDateSale.FieldName = "DateSale"
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.OptionsColumn.AllowEdit = False
        Me.ColDateSale.OptionsColumn.ReadOnly = True
        Me.ColDateSale.Width = 102
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "ชื่อสินค้า"
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.OptionsColumn.TabStop = False
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 3
        Me.ColProductName.Width = 497
        '
        'ColAmtSale
        '
        Me.ColAmtSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColAmtSale.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtSale.AppearanceHeader.Options.UseFont = True
        Me.ColAmtSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtSale.Caption = "จน. สินค้าที่คืนได้"
        Me.ColAmtSale.DisplayFormat.FormatString = "#,##0.####"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtSale.FieldName = "BalanceRT"
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.OptionsColumn.AllowEdit = False
        Me.ColAmtSale.OptionsColumn.ReadOnly = True
        Me.ColAmtSale.OptionsColumn.TabStop = False
        Me.ColAmtSale.Visible = True
        Me.ColAmtSale.VisibleIndex = 4
        Me.ColAmtSale.Width = 125
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
        Me.ColUnit.FieldName = "UnitName"
        Me.ColUnit.Name = "ColUnit"
        Me.ColUnit.OptionsColumn.AllowEdit = False
        Me.ColUnit.OptionsColumn.ReadOnly = True
        Me.ColUnit.OptionsColumn.TabStop = False
        Me.ColUnit.Visible = True
        Me.ColUnit.VisibleIndex = 5
        Me.ColUnit.Width = 118
        '
        'ColdtType
        '
        Me.ColdtType.Caption = "dtType"
        Me.ColdtType.FieldName = "dtType"
        Me.ColdtType.Name = "ColdtType"
        '
        'GCData
        '
        Me.GCData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCData.Location = New System.Drawing.Point(0, 103)
        Me.GCData.MainView = Me.GvShowData
        Me.GCData.Name = "GCData"
        Me.GCData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1})
        Me.GCData.Size = New System.Drawing.Size(916, 409)
        Me.GCData.TabIndex = 2
        Me.GCData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvShowData})
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btn_add)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 65)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(916, 38)
        Me.PanelControl1.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.GroupBox1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(916, 65)
        Me.PanelControl2.TabIndex = 0
        '
        'frmSlReturnSaleList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(916, 512)
        Me.Controls.Add(Me.GCData)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlReturnSaleList"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกรายการคืนสินค้า"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDocRef As System.Windows.Forms.TextBox
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GvShowData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCData As DevExpress.XtraGrid.GridControl
    Friend WithEvents ColCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColdtType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ColPartnerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
