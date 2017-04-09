<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignals
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignals))
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnStation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSaveList = New System.Windows.Forms.Button()
        Me.ButtonLoadList = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnIndex, Me.ColumnSelect, Me.ColumnStation, Me.ColumnAddress, Me.ColumnKKS, Me.ColumnDescription})
        Me.DataGridView.Location = New System.Drawing.Point(18, 16)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(638, 338)
        Me.DataGridView.TabIndex = 0
        '
        'ColumnIndex
        '
        Me.ColumnIndex.DividerWidth = 1
        Me.ColumnIndex.HeaderText = "索引"
        Me.ColumnIndex.Name = "ColumnIndex"
        Me.ColumnIndex.Width = 80
        '
        'ColumnSelect
        '
        Me.ColumnSelect.DividerWidth = 1
        Me.ColumnSelect.HeaderText = ""
        Me.ColumnSelect.Name = "ColumnSelect"
        Me.ColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColumnSelect.Width = 26
        '
        'ColumnStation
        '
        Me.ColumnStation.DividerWidth = 1
        Me.ColumnStation.HeaderText = "站"
        Me.ColumnStation.Name = "ColumnStation"
        Me.ColumnStation.Width = 87
        '
        'ColumnAddress
        '
        Me.ColumnAddress.DividerWidth = 1
        Me.ColumnAddress.HeaderText = "位置"
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
        'ButtonConfirm
        '
        Me.ButtonConfirm.Location = New System.Drawing.Point(541, 365)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(99, 31)
        Me.ButtonConfirm.TabIndex = 1
        Me.ButtonConfirm.Text = "確認"
        Me.ButtonConfirm.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(373, 365)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(99, 31)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonSaveList
        '
        Me.ButtonSaveList.Location = New System.Drawing.Point(37, 365)
        Me.ButtonSaveList.Name = "ButtonSaveList"
        Me.ButtonSaveList.Size = New System.Drawing.Size(99, 31)
        Me.ButtonSaveList.TabIndex = 3
        Me.ButtonSaveList.Text = "儲存"
        Me.ButtonSaveList.UseVisualStyleBackColor = True
        '
        'ButtonLoadList
        '
        Me.ButtonLoadList.Location = New System.Drawing.Point(205, 365)
        Me.ButtonLoadList.Name = "ButtonLoadList"
        Me.ButtonLoadList.Size = New System.Drawing.Size(99, 31)
        Me.ButtonLoadList.TabIndex = 4
        Me.ButtonLoadList.Text = "載入"
        Me.ButtonLoadList.UseVisualStyleBackColor = True
        '
        'frmSignals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 405)
        Me.Controls.Add(Me.ButtonLoadList)
        Me.Controls.Add(Me.ButtonSaveList)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.DataGridView)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ButtonConfirm As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonSaveList As Button
    Friend WithEvents ButtonLoadList As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents ColumnIndex As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSelect As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnStation As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAddress As DataGridViewTextBoxColumn
    Friend WithEvents ColumnKKS As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescription As DataGridViewTextBoxColumn
End Class
