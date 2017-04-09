<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmView
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmView))
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.Waveforms = New DEPP.Controls.Waveforms()
        Me.ButtonHide = New System.Windows.Forms.Button()
        Me.ButtonSelectSingals = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnStation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripShowValue = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemPercent = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripPenWidth = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripShowValue.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.Waveforms)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.ButtonHide)
        Me.SplitContainer.Panel2.Controls.Add(Me.ButtonSelectSingals)
        Me.SplitContainer.Panel2.Controls.Add(Me.DataGridView)
        Me.SplitContainer.Size = New System.Drawing.Size(1244, 470)
        Me.SplitContainer.SplitterDistance = 507
        Me.SplitContainer.SplitterWidth = 6
        Me.SplitContainer.TabIndex = 4
        '
        'Waveforms
        '
        Me.Waveforms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Waveforms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Waveforms.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Waveforms.Location = New System.Drawing.Point(0, 0)
        Me.Waveforms.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Waveforms.MaxPercent = 100.0R
        Me.Waveforms.MinPercent = -100.0R
        Me.Waveforms.Name = "Waveforms"
        Me.Waveforms.Size = New System.Drawing.Size(507, 470)
        Me.Waveforms.TabIndex = 1
        '
        'ButtonHide
        '
        Me.ButtonHide.Location = New System.Drawing.Point(0, 215)
        Me.ButtonHide.Name = "ButtonHide"
        Me.ButtonHide.Size = New System.Drawing.Size(24, 62)
        Me.ButtonHide.TabIndex = 5
        Me.ButtonHide.Text = ">"
        Me.ButtonHide.UseVisualStyleBackColor = True
        '
        'ButtonSelectSingals
        '
        Me.ButtonSelectSingals.Location = New System.Drawing.Point(586, 424)
        Me.ButtonSelectSingals.Name = "ButtonSelectSingals"
        Me.ButtonSelectSingals.Size = New System.Drawing.Size(88, 34)
        Me.ButtonSelectSingals.TabIndex = 5
        Me.ButtonSelectSingals.Text = "訊號選擇"
        Me.ButtonSelectSingals.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnIndex, Me.ColumnColor, Me.ColumnStation, Me.ColumnAddress, Me.ColumnKKS, Me.ColumnDescription, Me.ColumnValue})
        Me.DataGridView.Location = New System.Drawing.Point(25, 12)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(694, 385)
        Me.DataGridView.TabIndex = 4
        '
        'ColumnIndex
        '
        Me.ColumnIndex.DividerWidth = 1
        Me.ColumnIndex.HeaderText = "索引"
        Me.ColumnIndex.Name = "ColumnIndex"
        Me.ColumnIndex.ReadOnly = True
        Me.ColumnIndex.Width = 80
        '
        'ColumnColor
        '
        Me.ColumnColor.DividerWidth = 1
        Me.ColumnColor.HeaderText = ""
        Me.ColumnColor.Name = "ColumnColor"
        Me.ColumnColor.ReadOnly = True
        Me.ColumnColor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnColor.Width = 24
        '
        'ColumnStation
        '
        Me.ColumnStation.DividerWidth = 1
        Me.ColumnStation.HeaderText = "站"
        Me.ColumnStation.Name = "ColumnStation"
        Me.ColumnStation.ReadOnly = True
        Me.ColumnStation.Width = 87
        '
        'ColumnAddress
        '
        Me.ColumnAddress.DividerWidth = 1
        Me.ColumnAddress.HeaderText = "位  置"
        Me.ColumnAddress.Name = "ColumnAddress"
        Me.ColumnAddress.ReadOnly = True
        Me.ColumnAddress.Width = 87
        '
        'ColumnKKS
        '
        Me.ColumnKKS.DividerWidth = 1
        Me.ColumnKKS.HeaderText = "K    K    S"
        Me.ColumnKKS.Name = "ColumnKKS"
        Me.ColumnKKS.ReadOnly = True
        Me.ColumnKKS.Width = 216
        '
        'ColumnDescription
        '
        Me.ColumnDescription.DividerWidth = 1
        Me.ColumnDescription.HeaderText = "說        明"
        Me.ColumnDescription.Name = "ColumnDescription"
        Me.ColumnDescription.ReadOnly = True
        Me.ColumnDescription.Width = 288
        '
        'ColumnValue
        '
        Me.ColumnValue.DividerWidth = 1
        Me.ColumnValue.HeaderText = "數    值"
        Me.ColumnValue.Name = "ColumnValue"
        Me.ColumnValue.ReadOnly = True
        Me.ColumnValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnValue.Width = 145
        '
        'ContextMenuStripShowValue
        '
        Me.ContextMenuStripShowValue.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ContextMenuStripShowValue.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemPercent, Me.ToolStripMenuItemValue})
        Me.ContextMenuStripShowValue.Name = "ContextMenuStrip"
        Me.ContextMenuStripShowValue.Size = New System.Drawing.Size(127, 52)
        '
        'ToolStripMenuItemPercent
        '
        Me.ToolStripMenuItemPercent.Name = "ToolStripMenuItemPercent"
        Me.ToolStripMenuItemPercent.Size = New System.Drawing.Size(126, 24)
        Me.ToolStripMenuItemPercent.Text = "百分比"
        '
        'ToolStripMenuItemValue
        '
        Me.ToolStripMenuItemValue.Checked = True
        Me.ToolStripMenuItemValue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItemValue.Name = "ToolStripMenuItemValue"
        Me.ToolStripMenuItemValue.Size = New System.Drawing.Size(126, 24)
        Me.ToolStripMenuItemValue.Text = "數值"
        '
        'ContextMenuStripPenWidth
        '
        Me.ContextMenuStripPenWidth.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ContextMenuStripPenWidth.Name = "ContextMenuStripPenWidth"
        Me.ContextMenuStripPenWidth.Size = New System.Drawing.Size(61, 4)
        '
        'frmView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1244, 470)
        Me.Controls.Add(Me.SplitContainer)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmView"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripShowValue.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents ButtonSelectSingals As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ButtonHide As Button
    Friend WithEvents Waveforms As DEPP.Controls.Waveforms
    Friend WithEvents ContextMenuStripShowValue As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemPercent As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemValue As ToolStripMenuItem
    Friend WithEvents ContextMenuStripPenWidth As ContextMenuStrip
    Friend WithEvents ColumnIndex As DataGridViewTextBoxColumn
    Friend WithEvents ColumnColor As DataGridViewTextBoxColumn
    Friend WithEvents ColumnStation As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAddress As DataGridViewTextBoxColumn
    Friend WithEvents ColumnKKS As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescription As DataGridViewTextBoxColumn
    Friend WithEvents ColumnValue As DataGridViewTextBoxColumn
End Class
