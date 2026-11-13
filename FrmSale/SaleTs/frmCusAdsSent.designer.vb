<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusAdsSent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusAdsSent))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPsRec = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CntNoAddr = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CntNoAddrS = New System.Windows.Forms.Label()
        Me.ChkCusNoAddrS = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkCusNoAddr = New System.Windows.Forms.CheckBox()
        Me.txtAddressS = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.ChkAddr = New System.Windows.Forms.CheckBox()
        Me.ChkAddrS = New System.Windows.Forms.CheckBox()
        Me.ChkCus = New System.Windows.Forms.CheckBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GCAdrSent = New DevExpress.XtraGrid.GridControl()
        Me.GVAdrSent = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidCusRefAddr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColEditCus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColCusName_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsRecName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAdrS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsUpDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColstActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTspName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTspPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnFindAll = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddNew = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GCAdrSent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVAdrSent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(355, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 603
        Me.Label4.Text = "ค้นหาชื่อผู้รับ"
        '
        'txtPsRec
        '
        Me.txtPsRec.Location = New System.Drawing.Point(455, 8)
        Me.txtPsRec.Name = "txtPsRec"
        Me.txtPsRec.Size = New System.Drawing.Size(176, 21)
        Me.txtPsRec.TabIndex = 602
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtCount)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(735, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(299, 35)
        Me.Panel3.TabIndex = 601
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(235, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 599
        Me.Label1.Text = "รายการ"
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(133, 6)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(98, 26)
        Me.txtCount.TabIndex = 598
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(7, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 16)
        Me.Label5.TabIndex = 597
        Me.Label5.Text = "จำนวนที่อยู่ทั้งหมด"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.CntNoAddr)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CntNoAddrS)
        Me.Panel1.Controls.Add(Me.ChkCusNoAddrS)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ChkCusNoAddr)
        Me.Panel1.Controls.Add(Me.txtAddressS)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtCusName)
        Me.Panel1.Controls.Add(Me.ChkAddr)
        Me.Panel1.Controls.Add(Me.ChkAddrS)
        Me.Panel1.Controls.Add(Me.ChkCus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 90)
        Me.Panel1.TabIndex = 413
        '
        'CntNoAddr
        '
        Me.CntNoAddr.AutoSize = True
        Me.CntNoAddr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CntNoAddr.ForeColor = System.Drawing.Color.Red
        Me.CntNoAddr.Location = New System.Drawing.Point(815, 61)
        Me.CntNoAddr.Name = "CntNoAddr"
        Me.CntNoAddr.Size = New System.Drawing.Size(42, 14)
        Me.CntNoAddr.TabIndex = 607
        Me.CntNoAddr.Text = "Label1"
        Me.CntNoAddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CntNoAddr.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(875, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 14)
        Me.Label3.TabIndex = 606
        Me.Label3.Text = "คน"
        Me.Label3.Visible = False
        '
        'CntNoAddrS
        '
        Me.CntNoAddrS.AutoSize = True
        Me.CntNoAddrS.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CntNoAddrS.ForeColor = System.Drawing.Color.Red
        Me.CntNoAddrS.Location = New System.Drawing.Point(836, 41)
        Me.CntNoAddrS.Name = "CntNoAddrS"
        Me.CntNoAddrS.Size = New System.Drawing.Size(42, 14)
        Me.CntNoAddrS.TabIndex = 605
        Me.CntNoAddrS.Text = "Label4"
        Me.CntNoAddrS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CntNoAddrS.Visible = False
        '
        'ChkCusNoAddrS
        '
        Me.ChkCusNoAddrS.AutoSize = True
        Me.ChkCusNoAddrS.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ChkCusNoAddrS.Location = New System.Drawing.Point(667, 41)
        Me.ChkCusNoAddrS.Name = "ChkCusNoAddrS"
        Me.ChkCusNoAddrS.Size = New System.Drawing.Size(173, 18)
        Me.ChkCusNoAddrS.TabIndex = 604
        Me.ChkCusNoAddrS.Text = "ลูกค้าที่ไม่ได้กำหนดที่อยู่จัดส่ง"
        Me.ChkCusNoAddrS.UseVisualStyleBackColor = True
        Me.ChkCusNoAddrS.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(854, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 14)
        Me.Label2.TabIndex = 603
        Me.Label2.Text = "คน"
        Me.Label2.Visible = False
        '
        'ChkCusNoAddr
        '
        Me.ChkCusNoAddr.AutoSize = True
        Me.ChkCusNoAddr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ChkCusNoAddr.Location = New System.Drawing.Point(667, 59)
        Me.ChkCusNoAddr.Name = "ChkCusNoAddr"
        Me.ChkCusNoAddr.Size = New System.Drawing.Size(146, 18)
        Me.ChkCusNoAddr.TabIndex = 601
        Me.ChkCusNoAddr.Text = "ลูกค้าที่ไม่ได้กำหนดที่อยู่"
        Me.ChkCusNoAddr.UseVisualStyleBackColor = True
        Me.ChkCusNoAddr.Visible = False
        '
        'txtAddressS
        '
        Me.txtAddressS.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtAddressS.Location = New System.Drawing.Point(356, 50)
        Me.txtAddressS.Name = "txtAddressS"
        Me.txtAddressS.Size = New System.Drawing.Size(232, 22)
        Me.txtAddressS.TabIndex = 600
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(648, 3)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(233, 22)
        Me.txtAddress.TabIndex = 599
        Me.txtAddress.Visible = False
        '
        'txtCusName
        '
        Me.txtCusName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(356, 24)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(232, 22)
        Me.txtCusName.TabIndex = 598
        '
        'ChkAddr
        '
        Me.ChkAddr.AutoSize = True
        Me.ChkAddr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ChkAddr.Location = New System.Drawing.Point(598, 4)
        Me.ChkAddr.Name = "ChkAddr"
        Me.ChkAddr.Size = New System.Drawing.Size(49, 18)
        Me.ChkAddr.TabIndex = 597
        Me.ChkAddr.Text = "ที่อยู่"
        Me.ChkAddr.UseVisualStyleBackColor = True
        Me.ChkAddr.Visible = False
        '
        'ChkAddrS
        '
        Me.ChkAddrS.AutoSize = True
        Me.ChkAddrS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkAddrS.Location = New System.Drawing.Point(283, 52)
        Me.ChkAddrS.Name = "ChkAddrS"
        Me.ChkAddrS.Size = New System.Drawing.Size(76, 18)
        Me.ChkAddrS.TabIndex = 412
        Me.ChkAddrS.Text = "ที่อยู่จัดส่ง"
        Me.ChkAddrS.UseVisualStyleBackColor = True
        '
        'ChkCus
        '
        Me.ChkCus.AutoSize = True
        Me.ChkCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkCus.Location = New System.Drawing.Point(283, 26)
        Me.ChkCus.Name = "ChkCus"
        Me.ChkCus.Size = New System.Drawing.Size(68, 18)
        Me.ChkCus.TabIndex = 411
        Me.ChkCus.Text = "ชื่อลูกค้า"
        Me.ChkCus.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "เพิ่มข้อมูล"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 50
        '
        'GCAdrSent
        '
        Me.GCAdrSent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCAdrSent.Location = New System.Drawing.Point(0, 125)
        Me.GCAdrSent.MainView = Me.GVAdrSent
        Me.GCAdrSent.Name = "GCAdrSent"
        Me.GCAdrSent.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit2, Me.RepositoryItemCheckEdit1})
        Me.GCAdrSent.Size = New System.Drawing.Size(1034, 437)
        Me.GCAdrSent.TabIndex = 721
        Me.GCAdrSent.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVAdrSent})
        '
        'GVAdrSent
        '
        Me.GVAdrSent.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightBlue
        Me.GVAdrSent.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVAdrSent.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightBlue
        Me.GVAdrSent.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVAdrSent.Appearance.FooterPanel.ForeColor = System.Drawing.Color.MediumBlue
        Me.GVAdrSent.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVAdrSent.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVAdrSent.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVAdrSent.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVAdrSent.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVAdrSent.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightBlue
        Me.GVAdrSent.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVAdrSent.ColumnPanelRowHeight = 40
        Me.GVAdrSent.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColidCusRefAddr, Me.ColSelect, Me.ColEditCus, Me.ColCusName_, Me.ColPsRecName, Me.ColTel, Me.ColAdrS, Me.ColPsUpDate, Me.ColDateUpdate, Me.ColstActive, Me.ColTspName, Me.ColTspPay, Me.ColSupName})
        Me.GVAdrSent.GridControl = Me.GCAdrSent
        Me.GVAdrSent.GroupCount = 1
        Me.GVAdrSent.GroupFormat = "[#image] ลูกค้า : {1}{2}"
        Me.GVAdrSent.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "AddressS", Nothing, "  (จำนวน {0:N0} ที่อยู่จัดส่งของ)")})
        Me.GVAdrSent.Name = "GVAdrSent"
        Me.GVAdrSent.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVAdrSent.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVAdrSent.OptionsView.ShowFooter = True
        Me.GVAdrSent.OptionsView.ShowGroupPanel = False
        Me.GVAdrSent.OptionsView.ShowIndicator = False
        Me.GVAdrSent.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColCusName_, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.FixedWidth = True
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Width = 44
        '
        'ColidCusRefAddr
        '
        Me.ColidCusRefAddr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidCusRefAddr.AppearanceCell.Options.UseFont = True
        Me.ColidCusRefAddr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidCusRefAddr.AppearanceHeader.Options.UseFont = True
        Me.ColidCusRefAddr.Caption = "idCusRefAddr"
        Me.ColidCusRefAddr.FieldName = "idCusRefAddr"
        Me.ColidCusRefAddr.Name = "ColidCusRefAddr"
        '
        'ColSelect
        '
        Me.ColSelect.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColSelect.AppearanceCell.Options.UseFont = True
        Me.ColSelect.AppearanceCell.Options.UseTextOptions = True
        Me.ColSelect.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColSelect.AppearanceHeader.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.ColSelect.MaxWidth = 50
        Me.ColSelect.MinWidth = 50
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Visible = True
        Me.ColSelect.VisibleIndex = 0
        Me.ColSelect.Width = 71
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'ColEditCus
        '
        Me.ColEditCus.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColEditCus.AppearanceCell.Options.UseFont = True
        Me.ColEditCus.AppearanceCell.Options.UseTextOptions = True
        Me.ColEditCus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEditCus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColEditCus.AppearanceHeader.Options.UseFont = True
        Me.ColEditCus.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEditCus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEditCus.Caption = "แก้ไข"
        Me.ColEditCus.ColumnEdit = Me.RepositoryItemButtonEdit2
        Me.ColEditCus.MaxWidth = 50
        Me.ColEditCus.MinWidth = 50
        Me.ColEditCus.Name = "ColEditCus"
        Me.ColEditCus.Width = 50
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.Computer_Edit, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        Me.RepositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColCusName_
        '
        Me.ColCusName_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCusName_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCusName_.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName_.AppearanceCell.Options.UseFont = True
        Me.ColCusName_.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusName_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCusName_.AppearanceHeader.Options.UseFont = True
        Me.ColCusName_.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCusName_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusName_.Caption = "ชื่อลูกค้า"
        Me.ColCusName_.FieldName = "CusName_"
        Me.ColCusName_.MinWidth = 70
        Me.ColCusName_.Name = "ColCusName_"
        Me.ColCusName_.OptionsColumn.AllowEdit = False
        Me.ColCusName_.OptionsColumn.ReadOnly = True
        Me.ColCusName_.Visible = True
        Me.ColCusName_.VisibleIndex = 1
        '
        'ColPsRecName
        '
        Me.ColPsRecName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsRecName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsRecName.AppearanceCell.Options.UseBackColor = True
        Me.ColPsRecName.AppearanceCell.Options.UseFont = True
        Me.ColPsRecName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsRecName.AppearanceHeader.Options.UseFont = True
        Me.ColPsRecName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsRecName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsRecName.Caption = "ชื่อผู้รับ"
        Me.ColPsRecName.FieldName = "PsRecName"
        Me.ColPsRecName.MinWidth = 180
        Me.ColPsRecName.Name = "ColPsRecName"
        Me.ColPsRecName.OptionsColumn.AllowEdit = False
        Me.ColPsRecName.OptionsColumn.ReadOnly = True
        Me.ColPsRecName.Visible = True
        Me.ColPsRecName.VisibleIndex = 1
        Me.ColPsRecName.Width = 298
        '
        'ColTel
        '
        Me.ColTel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTel.AppearanceCell.Options.UseBackColor = True
        Me.ColTel.AppearanceCell.Options.UseFont = True
        Me.ColTel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTel.AppearanceHeader.Options.UseFont = True
        Me.ColTel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTel.Caption = "เบอร์ติดต่อ"
        Me.ColTel.FieldName = "Tel"
        Me.ColTel.MaxWidth = 200
        Me.ColTel.MinWidth = 100
        Me.ColTel.Name = "ColTel"
        Me.ColTel.Width = 100
        '
        'ColAdrS
        '
        Me.ColAdrS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAdrS.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAdrS.AppearanceCell.Options.UseBackColor = True
        Me.ColAdrS.AppearanceCell.Options.UseFont = True
        Me.ColAdrS.AppearanceCell.Options.UseTextOptions = True
        Me.ColAdrS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColAdrS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAdrS.AppearanceHeader.Options.UseFont = True
        Me.ColAdrS.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAdrS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAdrS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAdrS.Caption = "ที่อยู่จัดส่งของ"
        Me.ColAdrS.FieldName = "AddressS"
        Me.ColAdrS.Name = "ColAdrS"
        Me.ColAdrS.OptionsColumn.AllowEdit = False
        Me.ColAdrS.OptionsColumn.ReadOnly = True
        Me.ColAdrS.Visible = True
        Me.ColAdrS.VisibleIndex = 2
        Me.ColAdrS.Width = 630
        '
        'ColPsUpDate
        '
        Me.ColPsUpDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColPsUpDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsUpDate.AppearanceCell.Options.UseBackColor = True
        Me.ColPsUpDate.AppearanceCell.Options.UseFont = True
        Me.ColPsUpDate.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsUpDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsUpDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsUpDate.AppearanceHeader.Options.UseFont = True
        Me.ColPsUpDate.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsUpDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsUpDate.Caption = "ผู้อัพเดตล่าสุด"
        Me.ColPsUpDate.FieldName = "PsUpdate"
        Me.ColPsUpDate.MaxWidth = 120
        Me.ColPsUpDate.MinWidth = 100
        Me.ColPsUpDate.Name = "ColPsUpDate"
        Me.ColPsUpDate.OptionsColumn.AllowEdit = False
        Me.ColPsUpDate.OptionsColumn.ReadOnly = True
        Me.ColPsUpDate.Width = 100
        '
        'ColDateUpdate
        '
        Me.ColDateUpdate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateUpdate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateUpdate.AppearanceCell.Options.UseBackColor = True
        Me.ColDateUpdate.AppearanceCell.Options.UseFont = True
        Me.ColDateUpdate.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateUpdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateUpdate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateUpdate.AppearanceHeader.Options.UseFont = True
        Me.ColDateUpdate.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateUpdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateUpdate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateUpdate.Caption = "วันที่อัพเดตล่าสุด"
        Me.ColDateUpdate.FieldName = "DateUpdate"
        Me.ColDateUpdate.MaxWidth = 80
        Me.ColDateUpdate.MinWidth = 80
        Me.ColDateUpdate.Name = "ColDateUpdate"
        Me.ColDateUpdate.OptionsColumn.AllowEdit = False
        Me.ColDateUpdate.OptionsColumn.ReadOnly = True
        Me.ColDateUpdate.Width = 80
        '
        'ColstActive
        '
        Me.ColstActive.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColstActive.AppearanceCell.Options.UseFont = True
        Me.ColstActive.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColstActive.AppearanceHeader.Options.UseFont = True
        Me.ColstActive.Caption = "stActive"
        Me.ColstActive.FieldName = "stActive"
        Me.ColstActive.Name = "ColstActive"
        '
        'ColTspName
        '
        Me.ColTspName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTspName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTspName.AppearanceCell.Options.UseBackColor = True
        Me.ColTspName.AppearanceCell.Options.UseFont = True
        Me.ColTspName.AppearanceCell.Options.UseTextOptions = True
        Me.ColTspName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTspName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTspName.AppearanceHeader.Options.UseFont = True
        Me.ColTspName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTspName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTspName.Caption = "ประเภทขนส่ง"
        Me.ColTspName.FieldName = "TspName"
        Me.ColTspName.MinWidth = 100
        Me.ColTspName.Name = "ColTspName"
        Me.ColTspName.OptionsColumn.AllowEdit = False
        Me.ColTspName.OptionsColumn.ReadOnly = True
        Me.ColTspName.Visible = True
        Me.ColTspName.VisibleIndex = 3
        Me.ColTspName.Width = 156
        '
        'ColTspPay
        '
        Me.ColTspPay.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTspPay.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTspPay.AppearanceCell.Options.UseBackColor = True
        Me.ColTspPay.AppearanceCell.Options.UseFont = True
        Me.ColTspPay.AppearanceCell.Options.UseTextOptions = True
        Me.ColTspPay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTspPay.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTspPay.AppearanceHeader.Options.UseFont = True
        Me.ColTspPay.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTspPay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTspPay.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColTspPay.Caption = "การจ่ายเงินค่าขนส่ง"
        Me.ColTspPay.FieldName = "PayTspName"
        Me.ColTspPay.MaxWidth = 120
        Me.ColTspPay.MinWidth = 120
        Me.ColTspPay.Name = "ColTspPay"
        Me.ColTspPay.OptionsColumn.AllowEdit = False
        Me.ColTspPay.OptionsColumn.ReadOnly = True
        Me.ColTspPay.Visible = True
        Me.ColTspPay.VisibleIndex = 4
        Me.ColTspPay.Width = 120
        '
        'ColSupName
        '
        Me.ColSupName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColSupName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColSupName.AppearanceCell.Options.UseBackColor = True
        Me.ColSupName.AppearanceCell.Options.UseFont = True
        Me.ColSupName.AppearanceCell.Options.UseTextOptions = True
        Me.ColSupName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColSupName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColSupName.AppearanceHeader.Options.UseFont = True
        Me.ColSupName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSupName.Caption = "บริษัทขนส่ง"
        Me.ColSupName.FieldName = "SupName"
        Me.ColSupName.MinWidth = 180
        Me.ColSupName.Name = "ColSupName"
        Me.ColSupName.OptionsColumn.AllowEdit = False
        Me.ColSupName.OptionsColumn.ReadOnly = True
        Me.ColSupName.Visible = True
        Me.ColSupName.VisibleIndex = 5
        Me.ColSupName.Width = 383
        '
        'btnFindAll
        '
        Me.btnFindAll.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindAll.Appearance.Options.UseFont = True
        Me.btnFindAll.Image = CType(resources.GetObject("btnFindAll.Image"), System.Drawing.Image)
        Me.btnFindAll.Location = New System.Drawing.Point(3, 3)
        Me.btnFindAll.Name = "btnFindAll"
        Me.btnFindAll.Size = New System.Drawing.Size(110, 30)
        Me.btnFindAll.TabIndex = 671
        Me.btnFindAll.Text = "แสดงข้อมูล"
        '
        'btnAddNew
        '
        Me.btnAddNew.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Appearance.Options.UseFont = True
        Me.btnAddNew.Image = CType(resources.GetObject("btnAddNew.Image"), System.Drawing.Image)
        Me.btnAddNew.Location = New System.Drawing.Point(3, 3)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(118, 30)
        Me.btnAddNew.TabIndex = 672
        Me.btnAddNew.Text = "เพิ่มที่อยู่จัดส่ง"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel4)
        Me.PanelControl3.Controls.Add(Me.Panel2)
        Me.PanelControl3.Controls.Add(Me.Label4)
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Controls.Add(Me.txtPsRec)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 90)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1034, 35)
        Me.PanelControl3.TabIndex = 722
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnAddNew)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(116, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(125, 35)
        Me.Panel4.TabIndex = 674
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(116, 35)
        Me.Panel2.TabIndex = 673
        '
        'frmCusAdsSent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1034, 562)
        Me.Controls.Add(Me.GCAdrSent)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCusAdsSent"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ที่อยู่จัดส่งของ"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GCAdrSent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVAdrSent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ChkAddr As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAddrS As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCus As System.Windows.Forms.CheckBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressS As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkCusNoAddrS As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChkCusNoAddr As System.Windows.Forms.CheckBox
    Friend WithEvents CntNoAddrS As System.Windows.Forms.Label
    Friend WithEvents CntNoAddr As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GCAdrSent As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVAdrSent As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEditCus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColCusName_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAdrS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsUpDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidCusRefAddr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColPsRecName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColstActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTspName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTspPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPsRec As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFindAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
End Class
