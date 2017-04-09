Imports DEPP
Public Class frmMain
    Dim PR As frmProgressRate
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PR = New frmProgressRate
    End Sub

    Private Sub ViewMove(sender As Object, e As EventArgs) Handles RibbonButtonViewMove.Click
        RibbonButtonViewMove.Checked = Not RibbonButtonViewMove.Checked
        If RibbonButtonViewMove.Checked = True Then
            RibbonButtonZoomIn.Checked = False
            If Not (ActiveMdiChild Is Nothing) Then
                CType(ActiveMdiChild, frmView).ViewMove()
            End If
        Else
            If Not (ActiveMdiChild Is Nothing) Then
                CType(ActiveMdiChild, frmView).LeaveViewMove()
            End If
        End If
    End Sub
    Private Sub SwitchingWindow(sender As Object, e As EventArgs) Handles RibbonButtonSwitchingWindow.DropDownShowing
        Dim RB As RibbonButton

        RibbonButtonSwitchingWindow.DropDownItems.Clear()
        For Each W As frmView In MdiChildren
            RB = New RibbonButton(W.Text)
            RB.Tag = W
            If W Is ActiveMdiChild Then
                RB.Checked = True
            Else
                RB.Checked = False
            End If
            AddHandler RB.Click, AddressOf frmViewTopLevel
            RibbonButtonSwitchingWindow.DropDownItems.Add(RB)
        Next W
    End Sub

    Private Sub frmViewTopLevel(sender As Object, e As EventArgs)
        Dim RB As RibbonButton
        Dim V As frmView

        For Each W As frmView In MdiChildren
            W.WindowState = FormWindowState.Minimized
        Next W
        RB = CType(sender, RibbonButton)
        V = CType(RB.Tag, frmView)
        V.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ZoomIn(sender As Object, e As EventArgs) Handles RibbonButtonZoomIn.Click
        RibbonButtonViewMove.Checked = False
        If Not (ActiveMdiChild Is Nothing) Then
            RibbonButtonZoomIn.Checked = True
            CType(ActiveMdiChild, frmView).ZoomIn()
        End If
    End Sub

    Private Sub OnZoomInComplete(sender As Object, e As EventArgs)
        RibbonButtonZoomIn.Checked = False
    End Sub

    Private Sub OnViewMoveComplete(sender As Object, e As EventArgs)
        RibbonButtonViewMove.Checked = False
    End Sub

    Private Sub ViewAll(sender As Object, e As EventArgs) Handles RibbonButtonVeiwAll.Click
        RibbonButtonZoomIn.Checked = False
        RibbonButtonViewMove.Checked = False
        If Not (ActiveMdiChild Is Nothing) Then
            CType(ActiveMdiChild, frmView).VeiwAll()
        End If
    End Sub
    Private Sub OnProgressRate(sender As Object, e As DataFile.ProgressRateEventArgs)
        PR.ProgressBar.Value = e.ProgressRate * 100.0
        Application.DoEvents()
    End Sub

    Private Sub OpenDataFile(sender As Object, e As EventArgs) Handles RibbonButtonOpenDataFile.Click
        Dim DF As DataFile
        Dim V As frmView

        OpenFileDialog.Filter = "DEPP 記錄檔|*.*"
        OpenFileDialog.RestoreDirectory = True

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            DF = New DataFile
            PR.ProgressBar.Value = 0
            PR.Show(Me)
            AddHandler DF.ProgressRateEvent, AddressOf OnProgressRate

            If DF.Open(OpenFileDialog.FileName) = False Then
                MsgBox("檔案格式錯誤", MsgBoxStyle.OkOnly, "警告")
            Else
                V = New frmView
                V.DF = DF
                V.Width = Me.ClientRectangle.Width - 4
                V.Height = Me.ClientRectangle.Height - Ribbon.Height - 4
                V.Text = DF.Date + "    [ " + OpenFileDialog.FileName + " ]"
                V.MdiParent = Me
                AddHandler V.ZoomInCompleteEvent, AddressOf OnZoomInComplete
                AddHandler V.ViewMoveCompleteEvent, AddressOf OnViewMoveComplete
                V.WindowState = FormWindowState.Maximized
                V.Show()
            End If
            PR.Hide()
        End If
    End Sub
End Class
