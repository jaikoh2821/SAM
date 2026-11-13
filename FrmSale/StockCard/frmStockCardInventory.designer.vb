<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockCardInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockCardInventory))
        Me.rpsLinkList = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GBlength = New System.Windows.Forms.GroupBox()
        Me.rb1y = New System.Windows.Forms.RadioButton()
        Me.rb3m = New System.Windows.Forms.RadioButton()
        Me.rb6m = New System.Windows.Forms.RadioButton()
        Me.Rdb_inv = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.cmbWh = New System.Windows.Forms.ComboBox()
        Me.btnInv = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbllotmain = New System.Windows.Forms.Label()
        Me.CheckWh = New System.Windows.Forms.CheckBox()
        Me.lblInvname = New System.Windows.Forms.Label()
        Me.btnLotmain = New System.Windows.Forms.Button()
        Me.Rdb_lotmain = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelLot = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.Label()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridMain = New DevExpress.XtraGrid.GridControl()
        Me.Data_mt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Col_DateTs = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.col_LotNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.col_idLot = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.col_SumText = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.col_WhNamw = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMoney = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.col_QtyIn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.col_QtyOut = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.col_QtyBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.col_UnitName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Col_idPsTs = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Col_PsName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Col_RefTable = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GvProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GvCus = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_unit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.rpsLinkList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBlength.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_mt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpsLinkList
        '
        Me.rpsLinkList.AutoHeight = False
        Me.rpsLinkList.Name = "rpsLinkList"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1184, 101)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GBlength)
        Me.GroupBox1.Controls.Add(Me.Rdb_inv)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox1.Controls.Add(Me.cmbWh)
        Me.GroupBox1.Controls.Add(Me.btnInv)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbllotmain)
        Me.GroupBox1.Controls.Add(Me.CheckWh)
        Me.GroupBox1.Controls.Add(Me.lblInvname)
        Me.GroupBox1.Controls.Add(Me.btnLotmain)
        Me.GroupBox1.Controls.Add(Me.Rdb_lotmain)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1165, 86)
        Me.GroupBox1.TabIndex = 778
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "การเเสดงข้อมูล"
        '
        'GBlength
        '
        Me.GBlength.Controls.Add(Me.rb1y)
        Me.GBlength.Controls.Add(Me.rb3m)
        Me.GBlength.Controls.Add(Me.rb6m)
        Me.GBlength.Location = New System.Drawing.Point(825, 46)
        Me.GBlength.Name = "GBlength"
        Me.GBlength.Size = New System.Drawing.Size(339, 33)
        Me.GBlength.TabIndex = 784
        Me.GBlength.TabStop = False
        Me.GBlength.Visible = False
        '
        'rb1y
        '
        Me.rb1y.AutoSize = True
        Me.rb1y.Location = New System.Drawing.Point(247, 10)
        Me.rb1y.Name = "rb1y"
        Me.rb1y.Size = New System.Drawing.Size(83, 17)
        Me.rb1y.TabIndex = 780
        Me.rb1y.Text = "ย้อนหลัง 1 ปี"
        Me.rb1y.UseVisualStyleBackColor = True
        '
        'rb3m
        '
        Me.rb3m.AutoSize = True
        Me.rb3m.Checked = True
        Me.rb3m.Location = New System.Drawing.Point(13, 10)
        Me.rb3m.Name = "rb3m"
        Me.rb3m.Size = New System.Drawing.Size(102, 17)
        Me.rb3m.TabIndex = 782
        Me.rb3m.TabStop = True
        Me.rb3m.Text = "ย้อนหลัง 3 เดือน"
        Me.rb3m.UseVisualStyleBackColor = True
        '
        'rb6m
        '
        Me.rb6m.AutoSize = True
        Me.rb6m.Location = New System.Drawing.Point(129, 10)
        Me.rb6m.Name = "rb6m"
        Me.rb6m.Size = New System.Drawing.Size(102, 17)
        Me.rb6m.TabIndex = 781
        Me.rb6m.Text = "ย้อนหลัง 6 เดือน"
        Me.rb6m.UseVisualStyleBackColor = True
        '
        'Rdb_inv
        '
        Me.Rdb_inv.AutoSize = True
        Me.Rdb_inv.Location = New System.Drawing.Point(731, 23)
        Me.Rdb_inv.Name = "Rdb_inv"
        Me.Rdb_inv.Size = New System.Drawing.Size(64, 17)
        Me.Rdb_inv.TabIndex = 0
        Me.Rdb_inv.Text = "ชื่อสินค้า"
        Me.Rdb_inv.UseVisualStyleBackColor = True
        Me.Rdb_inv.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(730, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 783
        Me.Label2.Text = "ข้อมูลย้อนหลัง :"
        Me.Label2.Visible = False
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(87, 21)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(197, 21)
        Me.cmbGroupComp.TabIndex = 775
        '
        'cmbWh
        '
        Me.cmbWh.Enabled = False
        Me.cmbWh.FormattingEnabled = True
        Me.cmbWh.Location = New System.Drawing.Point(511, 53)
        Me.cmbWh.Name = "cmbWh"
        Me.cmbWh.Size = New System.Drawing.Size(118, 21)
        Me.cmbWh.TabIndex = 678
        '
        'btnInv
        '
        Me.btnInv.BackColor = System.Drawing.Color.DimGray
        Me.btnInv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInv.Enabled = False
        Me.btnInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnInv.ForeColor = System.Drawing.Color.White
        Me.btnInv.Image = CType(resources.GetObject("btnInv.Image"), System.Drawing.Image)
        Me.btnInv.Location = New System.Drawing.Point(1121, 19)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(28, 25)
        Me.btnInv.TabIndex = 672
        Me.btnInv.Tag = "Add"
        Me.btnInv.UseVisualStyleBackColor = False
        Me.btnInv.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 776
        Me.Label1.Text = "ข้อมูลบริษัท :"
        '
        'lbllotmain
        '
        Me.lbllotmain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbllotmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbllotmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbllotmain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbllotmain.Location = New System.Drawing.Point(441, 22)
        Me.lbllotmain.Name = "lbllotmain"
        Me.lbllotmain.Size = New System.Drawing.Size(188, 21)
        Me.lbllotmain.TabIndex = 673
        Me.lbllotmain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckWh
        '
        Me.CheckWh.AutoSize = True
        Me.CheckWh.Enabled = False
        Me.CheckWh.Location = New System.Drawing.Point(441, 55)
        Me.CheckWh.Name = "CheckWh"
        Me.CheckWh.Size = New System.Drawing.Size(68, 17)
        Me.CheckWh.TabIndex = 777
        Me.CheckWh.Text = "เลือกคลัง"
        Me.CheckWh.UseVisualStyleBackColor = True
        '
        'lblInvname
        '
        Me.lblInvname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInvname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblInvname.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInvname.Location = New System.Drawing.Point(799, 20)
        Me.lblInvname.Name = "lblInvname"
        Me.lblInvname.Size = New System.Drawing.Size(316, 22)
        Me.lblInvname.TabIndex = 673
        Me.lblInvname.Visible = False
        '
        'btnLotmain
        '
        Me.btnLotmain.BackColor = System.Drawing.Color.DimGray
        Me.btnLotmain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLotmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLotmain.ForeColor = System.Drawing.Color.White
        Me.btnLotmain.Image = CType(resources.GetObject("btnLotmain.Image"), System.Drawing.Image)
        Me.btnLotmain.Location = New System.Drawing.Point(632, 20)
        Me.btnLotmain.Name = "btnLotmain"
        Me.btnLotmain.Size = New System.Drawing.Size(28, 25)
        Me.btnLotmain.TabIndex = 672
        Me.btnLotmain.Tag = "Add"
        Me.btnLotmain.UseVisualStyleBackColor = False
        '
        'Rdb_lotmain
        '
        Me.Rdb_lotmain.AutoSize = True
        Me.Rdb_lotmain.Checked = True
        Me.Rdb_lotmain.Location = New System.Drawing.Point(345, 23)
        Me.Rdb_lotmain.Name = "Rdb_lotmain"
        Me.Rdb_lotmain.Size = New System.Drawing.Size(90, 17)
        Me.Rdb_lotmain.TabIndex = 1
        Me.Rdb_lotmain.TabStop = True
        Me.Rdb_lotmain.Text = "LOT - Lot No."
        Me.Rdb_lotmain.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel5.Controls.Add(Me.LabelLot)
        Me.Panel5.Controls.Add(Me.TextName)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 101)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1184, 55)
        Me.Panel5.TabIndex = 675
        '
        'LabelLot
        '
        Me.LabelLot.AutoSize = True
        Me.LabelLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelLot.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelLot.Location = New System.Drawing.Point(106, 28)
        Me.LabelLot.Name = "LabelLot"
        Me.LabelLot.Size = New System.Drawing.Size(66, 17)
        Me.LabelLot.TabIndex = 671
        Me.LabelLot.Text = "Lot No :"
        '
        'TextName
        '
        Me.TextName.AutoSize = True
        Me.TextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextName.Location = New System.Drawing.Point(9, 7)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(164, 17)
        Me.TextName.TabIndex = 670
        Me.TextName.Text = "รายการความเคลื่อนไหว :"
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "gridBand2"
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = -1
        Me.gridBand2.Width = 859
        '
        'GridMain
        '
        Me.GridMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMain.Location = New System.Drawing.Point(0, 156)
        Me.GridMain.MainView = Me.Data_mt
        Me.GridMain.Name = "GridMain"
        Me.GridMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.GridMain.Size = New System.Drawing.Size(1184, 395)
        Me.GridMain.TabIndex = 677
        Me.GridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Data_mt, Me.GvProduct, Me.GvCus})
        '
        'Data_mt
        '
        Me.Data_mt.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Data_mt.Appearance.EvenRow.Options.UseFont = True
        Me.Data_mt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Data_mt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Data_mt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Data_mt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Data_mt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Data_mt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.Data_mt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Data_mt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Data_mt.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Data_mt.Appearance.HeaderPanel.Options.UseFont = True
        Me.Data_mt.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.Data_mt.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Data_mt.Appearance.Row.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Data_mt.Appearance.Row.Options.UseBackColor = True
        Me.Data_mt.Appearance.Row.Options.UseFont = True
        Me.Data_mt.Appearance.SelectedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Data_mt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Data_mt.Appearance.TopNewRow.Options.UseTextOptions = True
        Me.Data_mt.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Data_mt.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Data_mt.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand3, Me.GridBand4, Me.colMoney, Me.gridBand1})
        Me.Data_mt.ColumnPanelRowHeight = 35
        Me.Data_mt.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.Col_DateTs, Me.col_LotNo, Me.col_idLot, Me.col_WhNamw, Me.col_SumText, Me.col_QtyIn, Me.col_QtyOut, Me.col_QtyBalance, Me.col_UnitName, Me.Col_PsName, Me.Col_idPsTs, Me.Col_RefTable})
        Me.Data_mt.CustomizationFormBounds = New System.Drawing.Rectangle(0, 110, 222, 324)
        Me.Data_mt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.Data_mt.GridControl = Me.GridMain
        Me.Data_mt.IndicatorWidth = 50
        Me.Data_mt.Name = "Data_mt"
        Me.Data_mt.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
        Me.Data_mt.OptionsView.ShowFooter = True
        Me.Data_mt.OptionsView.ShowGroupPanel = False
        '
        'gridBand3
        '
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.Visible = False
        Me.gridBand3.VisibleIndex = -1
        Me.gridBand3.Width = 407
        '
        'GridBand4
        '
        Me.GridBand4.Columns.Add(Me.Col_DateTs)
        Me.GridBand4.Columns.Add(Me.col_LotNo)
        Me.GridBand4.Columns.Add(Me.col_idLot)
        Me.GridBand4.Columns.Add(Me.col_SumText)
        Me.GridBand4.Columns.Add(Me.col_WhNamw)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.VisibleIndex = 0
        Me.GridBand4.Width = 657
        '
        'Col_DateTs
        '
        Me.Col_DateTs.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Col_DateTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Col_DateTs.AppearanceCell.Options.UseBackColor = True
        Me.Col_DateTs.AppearanceCell.Options.UseFont = True
        Me.Col_DateTs.AppearanceCell.Options.UseTextOptions = True
        Me.Col_DateTs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_DateTs.Caption = "วันที่"
        Me.Col_DateTs.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.Col_DateTs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Col_DateTs.FieldName = "DateTs"
        Me.Col_DateTs.MinWidth = 130
        Me.Col_DateTs.Name = "Col_DateTs"
        Me.Col_DateTs.OptionsColumn.AllowEdit = False
        Me.Col_DateTs.OptionsColumn.ReadOnly = True
        Me.Col_DateTs.Visible = True
        Me.Col_DateTs.Width = 130
        '
        'col_LotNo
        '
        Me.col_LotNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_LotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.col_LotNo.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.col_LotNo.AppearanceCell.Options.UseBackColor = True
        Me.col_LotNo.AppearanceCell.Options.UseFont = True
        Me.col_LotNo.AppearanceCell.Options.UseForeColor = True
        Me.col_LotNo.AppearanceCell.Options.UseTextOptions = True
        Me.col_LotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_LotNo.Caption = "LotNo"
        Me.col_LotNo.FieldName = "LotNo"
        Me.col_LotNo.MinWidth = 100
        Me.col_LotNo.Name = "col_LotNo"
        Me.col_LotNo.OptionsColumn.AllowEdit = False
        Me.col_LotNo.OptionsColumn.ReadOnly = True
        Me.col_LotNo.Width = 108
        '
        'col_idLot
        '
        Me.col_idLot.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_idLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.col_idLot.AppearanceCell.Options.UseBackColor = True
        Me.col_idLot.AppearanceCell.Options.UseFont = True
        Me.col_idLot.AppearanceCell.Options.UseTextOptions = True
        Me.col_idLot.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_idLot.Caption = "IdLot"
        Me.col_idLot.FieldName = "idLot"
        Me.col_idLot.Name = "col_idLot"
        Me.col_idLot.OptionsColumn.AllowEdit = False
        Me.col_idLot.OptionsColumn.ReadOnly = True
        Me.col_idLot.Width = 64
        '
        'col_SumText
        '
        Me.col_SumText.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_SumText.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.col_SumText.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.col_SumText.AppearanceCell.Options.UseBackColor = True
        Me.col_SumText.AppearanceCell.Options.UseFont = True
        Me.col_SumText.AppearanceCell.Options.UseForeColor = True
        Me.col_SumText.Caption = "รายละเอียด"
        Me.col_SumText.FieldName = "SumText"
        Me.col_SumText.MinWidth = 400
        Me.col_SumText.Name = "col_SumText"
        Me.col_SumText.OptionsColumn.AllowEdit = False
        Me.col_SumText.OptionsColumn.ReadOnly = True
        Me.col_SumText.Visible = True
        Me.col_SumText.Width = 407
        '
        'col_WhNamw
        '
        Me.col_WhNamw.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_WhNamw.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.col_WhNamw.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.col_WhNamw.AppearanceCell.Options.UseBackColor = True
        Me.col_WhNamw.AppearanceCell.Options.UseFont = True
        Me.col_WhNamw.AppearanceCell.Options.UseForeColor = True
        Me.col_WhNamw.AppearanceCell.Options.UseTextOptions = True
        Me.col_WhNamw.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_WhNamw.Caption = "คลัง"
        Me.col_WhNamw.FieldName = "WareHouseName"
        Me.col_WhNamw.MinWidth = 120
        Me.col_WhNamw.Name = "col_WhNamw"
        Me.col_WhNamw.OptionsColumn.AllowEdit = False
        Me.col_WhNamw.OptionsColumn.ReadOnly = True
        Me.col_WhNamw.Visible = True
        Me.col_WhNamw.Width = 120
        '
        'colMoney
        '
        Me.colMoney.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colMoney.AppearanceHeader.Options.UseFont = True
        Me.colMoney.AppearanceHeader.Options.UseTextOptions = True
        Me.colMoney.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMoney.Caption = "จำนวน"
        Me.colMoney.Columns.Add(Me.col_QtyIn)
        Me.colMoney.Columns.Add(Me.col_QtyOut)
        Me.colMoney.Columns.Add(Me.col_QtyBalance)
        Me.colMoney.Columns.Add(Me.col_UnitName)
        Me.colMoney.Columns.Add(Me.Col_idPsTs)
        Me.colMoney.Name = "colMoney"
        Me.colMoney.VisibleIndex = 1
        Me.colMoney.Width = 356
        '
        'col_QtyIn
        '
        Me.col_QtyIn.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_QtyIn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.col_QtyIn.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.col_QtyIn.AppearanceCell.Options.UseBackColor = True
        Me.col_QtyIn.AppearanceCell.Options.UseFont = True
        Me.col_QtyIn.AppearanceCell.Options.UseForeColor = True
        Me.col_QtyIn.AppearanceCell.Options.UseTextOptions = True
        Me.col_QtyIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_QtyIn.Caption = "เข้า"
        Me.col_QtyIn.DisplayFormat.FormatString = "#,##0.00##"
        Me.col_QtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_QtyIn.FieldName = "QtyIn"
        Me.col_QtyIn.MinWidth = 90
        Me.col_QtyIn.Name = "col_QtyIn"
        Me.col_QtyIn.OptionsColumn.AllowEdit = False
        Me.col_QtyIn.OptionsColumn.ReadOnly = True
        Me.col_QtyIn.Visible = True
        Me.col_QtyIn.Width = 99
        '
        'col_QtyOut
        '
        Me.col_QtyOut.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_QtyOut.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.col_QtyOut.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.col_QtyOut.AppearanceCell.Options.UseBackColor = True
        Me.col_QtyOut.AppearanceCell.Options.UseFont = True
        Me.col_QtyOut.AppearanceCell.Options.UseForeColor = True
        Me.col_QtyOut.AppearanceCell.Options.UseTextOptions = True
        Me.col_QtyOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_QtyOut.Caption = "ออก"
        Me.col_QtyOut.DisplayFormat.FormatString = "#,##0.00##"
        Me.col_QtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_QtyOut.FieldName = "QtyOut"
        Me.col_QtyOut.MinWidth = 90
        Me.col_QtyOut.Name = "col_QtyOut"
        Me.col_QtyOut.OptionsColumn.AllowEdit = False
        Me.col_QtyOut.OptionsColumn.ReadOnly = True
        Me.col_QtyOut.Visible = True
        Me.col_QtyOut.Width = 97
        '
        'col_QtyBalance
        '
        Me.col_QtyBalance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.col_QtyBalance.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.col_QtyBalance.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.col_QtyBalance.AppearanceCell.Options.UseBackColor = True
        Me.col_QtyBalance.AppearanceCell.Options.UseFont = True
        Me.col_QtyBalance.AppearanceCell.Options.UseForeColor = True
        Me.col_QtyBalance.AppearanceCell.Options.UseTextOptions = True
        Me.col_QtyBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_QtyBalance.Caption = "คงเหลือ"
        Me.col_QtyBalance.DisplayFormat.FormatString = "#,##0.00##"
        Me.col_QtyBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_QtyBalance.FieldName = "QtyBalance"
        Me.col_QtyBalance.MinWidth = 90
        Me.col_QtyBalance.Name = "col_QtyBalance"
        Me.col_QtyBalance.OptionsColumn.AllowEdit = False
        Me.col_QtyBalance.Visible = True
        Me.col_QtyBalance.Width = 90
        '
        'col_UnitName
        '
        Me.col_UnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_UnitName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.col_UnitName.AppearanceCell.Options.UseBackColor = True
        Me.col_UnitName.AppearanceCell.Options.UseFont = True
        Me.col_UnitName.AppearanceCell.Options.UseTextOptions = True
        Me.col_UnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_UnitName.Caption = "หน่วย"
        Me.col_UnitName.FieldName = "UnitName"
        Me.col_UnitName.MinWidth = 70
        Me.col_UnitName.Name = "col_UnitName"
        Me.col_UnitName.OptionsColumn.AllowEdit = False
        Me.col_UnitName.OptionsColumn.ReadOnly = True
        Me.col_UnitName.Visible = True
        Me.col_UnitName.Width = 70
        '
        'Col_idPsTs
        '
        Me.Col_idPsTs.Caption = "idPsTs"
        Me.Col_idPsTs.FieldName = "idPsTs"
        Me.Col_idPsTs.Name = "Col_idPsTs"
        '
        'gridBand1
        '
        Me.gridBand1.Columns.Add(Me.Col_PsName)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.VisibleIndex = 2
        Me.gridBand1.Width = 102
        '
        'Col_PsName
        '
        Me.Col_PsName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Col_PsName.AppearanceCell.Options.UseBackColor = True
        Me.Col_PsName.Caption = "ผู้ทำรายการ"
        Me.Col_PsName.FieldName = "PsName"
        Me.Col_PsName.MinWidth = 100
        Me.Col_PsName.Name = "Col_PsName"
        Me.Col_PsName.Visible = True
        Me.Col_PsName.Width = 102
        '
        'Col_RefTable
        '
        Me.Col_RefTable.Caption = "RefTable"
        Me.Col_RefTable.FieldName = "RefTable"
        Me.Col_RefTable.Name = "Col_RefTable"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
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
        Me.GvProduct.GridControl = Me.GridMain
        Me.GvProduct.Name = "GvProduct"
        Me.GvProduct.OptionsView.ColumnAutoWidth = False
        Me.GvProduct.OptionsView.ShowGroupPanel = False
        Me.GvProduct.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GvProduct.OptionsView.ShowIndicator = False
        '
        'GvCus
        '
        Me.GvCus.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GvCus.Appearance.EvenRow.Options.UseFont = True
        Me.GvCus.Appearance.FocusedCell.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvCus.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GvCus.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvCus.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvCus.Appearance.FocusedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvCus.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvCus.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvCus.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvCus.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GvCus.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvCus.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GvCus.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GvCus.Appearance.Row.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvCus.Appearance.Row.Options.UseBackColor = True
        Me.GvCus.Appearance.Row.Options.UseFont = True
        Me.GvCus.Appearance.SelectedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GvCus.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvCus.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GvCus.GridControl = Me.GridMain
        Me.GvCus.Name = "GvCus"
        Me.GvCus.OptionsView.ColumnAutoWidth = False
        Me.GvCus.OptionsView.ShowGroupPanel = False
        Me.GvCus.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GvCus.OptionsView.ShowIndicator = False
        '
        'Col_unit
        '
        Me.Col_unit.Caption = "หน่วย"
        Me.Col_unit.FieldName = "UnitName"
        Me.Col_unit.Name = "Col_unit"
        Me.Col_unit.Visible = True
        '
        'frmStockCardInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GridMain)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockCardInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการความเคลื่อนไหวสต็อกวัสดุ/สินค้า"
        CType(Me.rpsLinkList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBlength.ResumeLayout(False)
        Me.GBlength.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_mt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblInvname As System.Windows.Forms.Label
    Friend WithEvents btnInv As System.Windows.Forms.Button
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents rpsLinkList As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents Rdb_lotmain As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_inv As System.Windows.Forms.RadioButton
    Friend WithEvents lbllotmain As System.Windows.Forms.Label
    Friend WithEvents btnLotmain As System.Windows.Forms.Button
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents Data_mt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents col_LotNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_WhNamw As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_SumText As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents col_QtyIn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_QtyOut As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents col_QtyBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GvProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GvCus As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_UnitName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Col_unit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Col_DateTs As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckWh As System.Windows.Forms.CheckBox
    Friend WithEvents cmbWh As System.Windows.Forms.ComboBox
    Friend WithEvents col_idLot As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TextName As System.Windows.Forms.Label
    Friend WithEvents rb1y As System.Windows.Forms.RadioButton
    Friend WithEvents rb3m As System.Windows.Forms.RadioButton
    Friend WithEvents rb6m As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GBlength As System.Windows.Forms.GroupBox
    Friend WithEvents Col_RefTable As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LabelLot As System.Windows.Forms.Label
    Friend WithEvents Col_PsName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Col_idPsTs As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colMoney As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
