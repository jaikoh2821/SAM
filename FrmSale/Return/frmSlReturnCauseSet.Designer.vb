<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlReturnCauseSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlReturnCauseSet))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.dgvReturn = New System.Windows.Forms.DataGridView()
        Me.ColNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColidRtCause = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColReturnCause = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dgvReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(82, 34)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'dgvReturn
        '
        Me.dgvReturn.AllowUserToDeleteRows = False
        Me.dgvReturn.AllowUserToResizeColumns = False
        Me.dgvReturn.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNum, Me.ColidRtCause, Me.ColReturnCause, Me.ColDel})
        Me.dgvReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReturn.Location = New System.Drawing.Point(0, 34)
        Me.dgvReturn.Name = "dgvReturn"
        Me.dgvReturn.RowHeadersVisible = False
        Me.dgvReturn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvReturn.Size = New System.Drawing.Size(364, 428)
        Me.dgvReturn.TabIndex = 7
        '
        'ColNum
        '
        Me.ColNum.DataPropertyName = "Num"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColNum.HeaderText = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.ReadOnly = True
        Me.ColNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNum.Width = 50
        '
        'ColidRtCause
        '
        Me.ColidRtCause.DataPropertyName = "idRtCause"
        Me.ColidRtCause.HeaderText = "ididRtCause"
        Me.ColidRtCause.Name = "ColidRtCause"
        Me.ColidRtCause.Visible = False
        '
        'ColReturnCause
        '
        Me.ColReturnCause.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColReturnCause.DataPropertyName = "ReturnCause"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ColReturnCause.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColReturnCause.HeaderText = "สาเหตุการคืนสินค้า"
        Me.ColReturnCause.Name = "ColReturnCause"
        Me.ColReturnCause.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColDel
        '
        Me.ColDel.HeaderText = "ลบ"
        Me.ColDel.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.ColDel.Name = "ColDel"
        Me.ColDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColDel.Width = 40
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(364, 34)
        Me.PanelControl3.TabIndex = 729
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(364, 34)
        Me.Panel3.TabIndex = 601
        '
        'frmSlReturnCauseSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(364, 462)
        Me.Controls.Add(Me.dgvReturn)
        Me.Controls.Add(Me.PanelControl3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSlReturnCauseSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่ม/แก้ไขสาเหตุการรับคืน"
        CType(Me.dgvReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents dgvReturn As System.Windows.Forms.DataGridView
    Friend WithEvents ColNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidRtCause As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColReturnCause As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
