<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Ribbon = New System.Windows.Forms.Ribbon()
        Me.RibbonTabCommonlyUsed = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonOpenDataFile = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanelView = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonZoomIn = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonVeiwAll = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonViewMove = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanelWindows = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonSwitchingWindow = New System.Windows.Forms.RibbonButton()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Ribbon
        '
        Me.Ribbon.CaptionBarVisible = False
        Me.Ribbon.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Ribbon.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon.Margin = New System.Windows.Forms.Padding(4)
        Me.Ribbon.Minimized = False
        Me.Ribbon.Name = "Ribbon"
        '
        '
        '
        Me.Ribbon.OrbDropDown.BorderRoundness = 8
        Me.Ribbon.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon.OrbDropDown.Name = ""
        Me.Ribbon.OrbDropDown.Size = New System.Drawing.Size(527, 447)
        Me.Ribbon.OrbDropDown.TabIndex = 0
        Me.Ribbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010
        Me.Ribbon.OrbText = ""
        Me.Ribbon.OrbVisible = False
        Me.Ribbon.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon.Size = New System.Drawing.Size(1264, 168)
        Me.Ribbon.TabIndex = 1
        Me.Ribbon.Tabs.Add(Me.RibbonTabCommonlyUsed)
        Me.Ribbon.TabsMargin = New System.Windows.Forms.Padding(6, 2, 20, 0)
        Me.Ribbon.TabSpacing = 3
        '
        'RibbonTabCommonlyUsed
        '
        Me.RibbonTabCommonlyUsed.Name = "RibbonTabCommonlyUsed"
        Me.RibbonTabCommonlyUsed.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTabCommonlyUsed.Panels.Add(Me.RibbonPanelView)
        Me.RibbonTabCommonlyUsed.Panels.Add(Me.RibbonPanelWindows)
        Me.RibbonTabCommonlyUsed.Text = "常用"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.RibbonButtonOpenDataFile)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Text = "檔案"
        '
        'RibbonButtonOpenDataFile
        '
        Me.RibbonButtonOpenDataFile.Image = CType(resources.GetObject("RibbonButtonOpenDataFile.Image"), System.Drawing.Image)
        Me.RibbonButtonOpenDataFile.LargeImage = CType(resources.GetObject("RibbonButtonOpenDataFile.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonOpenDataFile.Name = "RibbonButtonOpenDataFile"
        Me.RibbonButtonOpenDataFile.SmallImage = CType(resources.GetObject("RibbonButtonOpenDataFile.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonOpenDataFile.Text = "開啟舊檔"
        Me.RibbonButtonOpenDataFile.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'RibbonPanelView
        '
        Me.RibbonPanelView.Items.Add(Me.RibbonButtonZoomIn)
        Me.RibbonPanelView.Items.Add(Me.RibbonButtonVeiwAll)
        Me.RibbonPanelView.Items.Add(Me.RibbonButtonViewMove)
        Me.RibbonPanelView.Name = "RibbonPanelView"
        Me.RibbonPanelView.Text = "檢視"
        '
        'RibbonButtonZoomIn
        '
        Me.RibbonButtonZoomIn.Image = CType(resources.GetObject("RibbonButtonZoomIn.Image"), System.Drawing.Image)
        Me.RibbonButtonZoomIn.LargeImage = CType(resources.GetObject("RibbonButtonZoomIn.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonZoomIn.Name = "RibbonButtonZoomIn"
        Me.RibbonButtonZoomIn.SmallImage = CType(resources.GetObject("RibbonButtonZoomIn.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonZoomIn.Text = "局部放大"
        Me.RibbonButtonZoomIn.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'RibbonButtonVeiwAll
        '
        Me.RibbonButtonVeiwAll.Image = CType(resources.GetObject("RibbonButtonVeiwAll.Image"), System.Drawing.Image)
        Me.RibbonButtonVeiwAll.LargeImage = CType(resources.GetObject("RibbonButtonVeiwAll.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonVeiwAll.Name = "RibbonButtonVeiwAll"
        Me.RibbonButtonVeiwAll.SmallImage = CType(resources.GetObject("RibbonButtonVeiwAll.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonVeiwAll.Text = "全部"
        '
        'RibbonButtonViewMove
        '
        Me.RibbonButtonViewMove.Image = CType(resources.GetObject("RibbonButtonViewMove.Image"), System.Drawing.Image)
        Me.RibbonButtonViewMove.LargeImage = CType(resources.GetObject("RibbonButtonViewMove.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonViewMove.Name = "RibbonButtonViewMove"
        Me.RibbonButtonViewMove.SmallImage = CType(resources.GetObject("RibbonButtonViewMove.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonViewMove.Text = "平移"
        '
        'RibbonPanelWindows
        '
        Me.RibbonPanelWindows.Items.Add(Me.RibbonButtonSwitchingWindow)
        Me.RibbonPanelWindows.Name = "RibbonPanelWindows"
        Me.RibbonPanelWindows.Text = "視窗"
        '
        'RibbonButtonSwitchingWindow
        '
        Me.RibbonButtonSwitchingWindow.Image = CType(resources.GetObject("RibbonButtonSwitchingWindow.Image"), System.Drawing.Image)
        Me.RibbonButtonSwitchingWindow.LargeImage = CType(resources.GetObject("RibbonButtonSwitchingWindow.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonSwitchingWindow.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.RibbonButtonSwitchingWindow.Name = "RibbonButtonSwitchingWindow"
        Me.RibbonButtonSwitchingWindow.SmallImage = CType(resources.GetObject("RibbonButtonSwitchingWindow.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonSwitchingWindow.Style = System.Windows.Forms.RibbonButtonStyle.DropDown
        Me.RibbonButtonSwitchingWindow.Text = "切換視窗"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.RestoreDirectory = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Ribbon)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEPP Viewer Ver 1.16.10.15 通霄電廠 陳建璋"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ribbon As Ribbon
    Friend WithEvents RibbonTabCommonlyUsed As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonButtonOpenDataFile As RibbonButton
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents RibbonPanelView As RibbonPanel
    Friend WithEvents RibbonButtonZoomIn As RibbonButton
    Friend WithEvents RibbonButtonVeiwAll As RibbonButton
    Friend WithEvents RibbonButtonViewMove As RibbonButton
    Friend WithEvents RibbonPanelWindows As RibbonPanel
    Friend WithEvents RibbonButtonSwitchingWindow As RibbonButton
End Class
