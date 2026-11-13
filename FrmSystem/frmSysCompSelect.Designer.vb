<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysCompSelect
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysCompSelect))
        Me.Img = New System.Windows.Forms.ImageList(Me.components)
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Img
        '
        Me.Img.ImageStream = CType(resources.GetObject("Img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Img.TransparentColor = System.Drawing.Color.Transparent
        Me.Img.Images.SetKeyName(0, "0business-home5.png")
        Me.Img.Images.SetKeyName(1, "Company_2.png")
        Me.Img.Images.SetKeyName(2, "building.png")
        Me.Img.Images.SetKeyName(3, "office_building.png")
        Me.Img.Images.SetKeyName(4, "company.png")
        Me.Img.Images.SetKeyName(5, "Factory.jpg")
        '
        'TreeList1
        '
        Me.TreeList1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.TreeList1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.TreeList1.Appearance.Empty.Options.UseBackColor = True
        Me.TreeList1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeList1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TreeList1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.EvenRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.TreeList1.Appearance.EvenRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.FocusedCell.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TreeList1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeList1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.TreeList1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TreeList1.Appearance.FocusedCell.Options.UseFont = True
        Me.TreeList1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.TreeList1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TreeList1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TreeList1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.TreeList1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TreeList1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TreeList1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.TreeList1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.TreeList1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.TreeList1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TreeList1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TreeList1.Appearance.GroupButton.Options.UseBackColor = True
        Me.TreeList1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.TreeList1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.TreeList1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.TreeList1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.TreeList1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.TreeList1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.TreeList1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TreeList1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TreeList1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TreeList1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.TreeList1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.TreeList1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.TreeList1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.TreeList1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.TreeList1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TreeList1.Appearance.HorzLine.Options.UseBackColor = True
        Me.TreeList1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TreeList1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TreeList1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.OddRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.OddRow.Options.UseBorderColor = True
        Me.TreeList1.Appearance.OddRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TreeList1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.TreeList1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.TreeList1.Appearance.Preview.Options.UseBackColor = True
        Me.TreeList1.Appearance.Preview.Options.UseFont = True
        Me.TreeList1.Appearance.Preview.Options.UseForeColor = True
        Me.TreeList1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TreeList1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.Row.Options.UseBackColor = True
        Me.TreeList1.Appearance.Row.Options.UseForeColor = True
        Me.TreeList1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TreeList1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.TreeList1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.TreeList1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.TreeList1.Appearance.TreeLine.Options.UseBackColor = True
        Me.TreeList1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TreeList1.Appearance.VertLine.Options.UseBackColor = True
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1})
        Me.TreeList1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsBehavior.PopulateServiceColumns = True
        Me.TreeList1.OptionsView.AllowHtmlDrawHeaders = True
        Me.TreeList1.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeList1.OptionsView.EnableAppearanceOddRow = True
        Me.TreeList1.OptionsView.ShowColumns = False
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor
        Me.TreeList1.Size = New System.Drawing.Size(384, 581)
        Me.TreeList1.StateImageList = Me.Img
        Me.TreeList1.TabIndex = 2
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.MinWidth = 52
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        Me.TreeListColumn1.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.TreeListColumn1.Visible = True
        Me.TreeListColumn1.VisibleIndex = 0
        Me.TreeListColumn1.Width = 93
        '
        'frmSysCompSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(384, 581)
        Me.Controls.Add(Me.TreeList1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSysCompSelect"
        Me.Opacity = 0.6R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกบริษัท"
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Img As System.Windows.Forms.ImageList
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
