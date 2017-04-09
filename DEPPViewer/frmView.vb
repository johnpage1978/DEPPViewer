Imports DEPP
Imports DEPP.Controls
Public Class frmView
    Private Const DGV_Index As Integer = 0
    Private Const DGV_Color As Integer = 1
    Private Const DGV_Station As Integer = 2
    Private Const DGV_Address As Integer = 3
    Private Const DGV_KKS As Integer = 4
    Private Const DGV_Description As Integer = 5
    Private Const DGV_Value As Integer = 6
    Public DF As DataFile
    Private S As frmSignals
    Private IsHideSingal As Boolean
    Private OldSplitterDistance As Integer
    Public MaxPercent As Double
    Public MinPercent As Double
    Private PenMenu As ToolStripMenuItem
    Private PenWidth(4) As ToolStripMenuItem
    Private PenWidthStation As String
    Private PenWidthAddr As String

    Private ColorTable As New List(Of Color) From
        {
        Color.Black, Color.FromArgb(128, 64, 0), Color.Red,
        Color.FromArgb(255, 128, 0), Color.FromArgb(128, 128, 0), Color.Green,
        Color.Blue, Color.Purple, Color.FromArgb(255, 128, 255)
        }
    Public Event ZoomInCompleteEvent(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ViewMoveCompleteEvent(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub frmView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        IsHideSingal = False
        S = New frmSignals
        S.DF = DF
        DataGridView.RowsDefaultCellStyle.Font = New Font("Courier New", 12)
        DataGridView.Columns(DGV_Index).Visible = False
        DataGridView.Columns(DGV_Station).Visible = False
        DataGridView.Columns(DGV_Address).Visible = False
        Waveforms.TimeLine = DF.Time
        ContextMenuStripPenWidth.Items.Clear()
        PenMenu = New ToolStripMenuItem("信號寬度")
        PenMenu.Enabled = False
        ContextMenuStripPenWidth.Items.Add(PenMenu)
        For i = 0 To 4
            PenWidth(i) = New ToolStripMenuItem((i + 1).ToString())
            If i = 0 Then
                PenWidth(i).Checked = True
            Else
                PenWidth(i).Checked = False
            End If
            AddHandler PenWidth(i).Click, AddressOf PenWidth_Click
            ContextMenuStripPenWidth.Items.Add(PenWidth(i))
        Next i
    End Sub

    Public Sub PenWidth_Click(ByVal sender As Object, ByVal e As EventArgs)
        Waveforms.SetSignalWidth(PenWidthStation, PenWidthAddr, CType(sender, ToolStripMenuItem).Text)
        CType(sender, ToolStripMenuItem).Checked = True
    End Sub

    Private Sub DGV_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView.CellPainting
        Dim R As Integer
        Dim C As Integer
        Dim Cell As Rectangle
        Dim g As Graphics

        R = e.RowIndex
        C = e.ColumnIndex
        Cell = e.CellBounds
        g = e.Graphics
        If R > -1 And C = DGV_Color Then
            e.PaintBackground(e.CellBounds, True)
            g.FillRectangle(New SolidBrush(e.CellStyle.ForeColor), Cell.X + 3, Cell.Y + 3, Cell.Width - 7, Cell.Height - 7)
            e.Handled = True
        End If
    End Sub
    Private Sub ButtonSelectSingals_Click(sender As Object, e As EventArgs) Handles ButtonSelectSingals.Click
        Dim DGVR As DataGridViewRowCollection
        Dim i As Integer
        Dim j As Integer
        Dim R As Integer

        If S.ShowDialog = DialogResult.OK Then
            DGVR = DataGridView.Rows
            DGVR.Clear()
            Waveforms.SignalList.Clear()
            MaxPercent = Double.MinValue
            MinPercent = Double.MaxValue
            For i = 0 To S.DisplayList.Count - 1
                R = DGVR.Add(New Object() {S.DisplayList(i), Nothing, DF.Singal(S.DisplayList(i)).Station, DF.Singal(S.DisplayList(i)).Address, DF.Singal(S.DisplayList(i)).KKS, DF.Singal(S.DisplayList(i)).Description, Nothing})
                CType(DGVR(R).Cells(DGV_Color), DataGridViewTextBoxCell).Style.ForeColor = ColorTable(R Mod ColorTable.Count)
                Waveforms.SignalList.Add(New SignalInformation(S.DisplayList(i), DF.Singal(S.DisplayList(i)).Station, DF.Singal(S.DisplayList(i)).Address, ColorTable(R Mod ColorTable.Count), DF.Singal(S.DisplayList(i)).RecordData))
                For j = 0 To DF.Singal(S.DisplayList(i)).RecordData.Count - 1
                    If DF.Singal(S.DisplayList(i)).RecordData(j) > MaxPercent Then
                        MaxPercent = DF.Singal(S.DisplayList(i)).RecordData(j) + 10
                    End If
                    If DF.Singal(S.DisplayList(i)).RecordData(j) < MinPercent Then
                        MinPercent = DF.Singal(S.DisplayList(i)).RecordData(j) - 10
                    End If
                Next j
            Next i
            If S.DisplayList.Count > 0 And MaxPercent > MinPercent Then
                Waveforms.MaxPercent = MaxPercent
                Waveforms.MinPercent = MinPercent
                Waveforms.MaxLimitPercent = MaxPercent
                Waveforms.MinLimitPercent = MinPercent
                Waveforms.Invalidate()
            End If
        End If
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        Dim R As Integer
        Dim C As Integer

        R = e.RowIndex
        C = e.ColumnIndex
        If R <> -1 Then
            Select Case C
                Case DGV_Color
                    If ColorDialog.ShowDialog = DialogResult.OK Then
                        CType(DataGridView.Rows(R).Cells(C), DataGridViewTextBoxCell).Style.ForeColor = ColorDialog.Color
                        Waveforms.SetSignalColor(CType(DataGridView.Rows(R).Cells(DGV_Station), DataGridViewTextBoxCell).Value, CType(DataGridView.Rows(R).Cells(DGV_Address), DataGridViewTextBoxCell).Value, ColorDialog.Color)
                    End If
                Case Else
            End Select
        End If
    End Sub
    Private Sub SplitContainer_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer.SplitterMoved
        Waveforms.Size = SplitContainer.Panel1.ClientSize
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        If IsHideSingal = False Then
            OldSplitterDistance = SplitContainer.SplitterDistance
            SplitContainer.SplitterDistance = SplitContainer.Size.Width - ButtonHide.Width + 20
            ButtonHide.Text = "<"
            IsHideSingal = True
        Else
            SplitContainer.SplitterDistance = OldSplitterDistance
            ButtonHide.Text = ">"
            IsHideSingal = False
        End If
    End Sub

    Public Sub ZoomIn()
        Waveforms.OperatorMode = Waveforms.OperatorType.ZooIn
    End Sub

    Public Sub VeiwAll()
        Waveforms.ViewAll(MaxPercent, MinPercent)
    End Sub

    Private Sub ShowValue(sender As Object, e As DataEventArgs) Handles Waveforms.DataEvent
        Dim i As Integer
        Dim j As Integer
        Dim v As Double
        Dim High As Double
        Dim Low As Double
        Dim Unit As String

        For i = 0 To e.DataList.Count - 1
            For j = 0 To DataGridView.Rows.Count - 1
                If CType(DataGridView.Rows(j).Cells(DGV_Station), DataGridViewTextBoxCell).Value = e.DataList(i).Station And CType(DataGridView.Rows(j).Cells(DGV_Address), DataGridViewTextBoxCell).Value = e.DataList(i).Addr Then
                    If ToolStripMenuItemPercent.Checked = True Then
                        '百分比
                        CType(DataGridView.Rows(j).Cells(DGV_Value), DataGridViewTextBoxCell).Value = e.DataList(i).Data
                    Else
                        '數值
                        If Double.IsNaN(e.DataList(i).Data) = True Then
                            '非數值
                            CType(DataGridView.Rows(j).Cells(DGV_Value), DataGridViewTextBoxCell).Value = e.DataList(i).Data
                        Else
                            High = DF.Singal(e.DataList(i).Index).HundredPercent
                            Low = DF.Singal(e.DataList(i).Index).ZeroPercent
                            Unit = DF.Singal(e.DataList(i).Index).Unit
                            Select Case Unit
                                Case "On Grid", "1:Lead", "1:Active", "bin", "OPEN", "1:ON", "Closed", "1:BLOCK", "Selected", "Start", "1:Closed"
                                    CType(DataGridView.Rows(j).Cells(DGV_Value), DataGridViewTextBoxCell).Value = e.DataList(i).Data
                                Case Else
                                    v = (High - Low) * (e.DataList(i).Data / 100.0) + Low
                                    CType(DataGridView.Rows(j).Cells(DGV_Value), DataGridViewTextBoxCell).Value = v.ToString("#0.##") + " " + Unit
                            End Select
                        End If
                    End If
                    Exit For
                End If
            Next j
        Next i
    End Sub

    Private Sub OnZoomInComplete(sender As Object, e As EventArgs) Handles Waveforms.ZoomInCompleteEvent
        RaiseEvent ZoomInCompleteEvent(sender, e)
    End Sub

    'Private Sub OnViewMoveComplete(sender As Object, e As EventArgs) Handles Waveforms.ViewMoveCompleteEvent
    '    RaiseEvent ViewMoveCompleteEvent(sender, e)
    'End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Dim i As Integer
        Dim keyPressed As Keys = CType(msg.WParam.ToInt32(), Keys)

        Select Case keyPressed
            Case Keys.Escape
                Waveforms.CursorEsc()
                '清除數值
                For i = 0 To DataGridView.Rows.Count - 1
                    CType(DataGridView.Rows(i).Cells(DGV_Value), DataGridViewTextBoxCell).Value = ""
                Next i
                Return True
            Case Keys.Left
                Waveforms.CursorLeft()
                Return True
            Case Keys.Right
                Waveforms.CursorRight()
                Return True
            Case Else
                Return MyBase.ProcessCmdKey(msg, keyData)
        End Select
    End Function

    Private Sub DataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView.MouseDown
        Dim hit As DataGridView.HitTestInfo
        Dim i As Integer
        Dim Width As Integer

        Select Case e.Button
            Case MouseButtons.Right
                hit = DataGridView.HitTest(e.X, e.Y)
                If hit.Type = DataGridViewHitTestType.Cell Then
                    If hit.ColumnIndex = DGV_Value Then
                        ContextMenuStripShowValue.Show(DataGridView, New Point(e.X, e.Y))
                    ElseIf DGV_KKS Or DGV_Description Then
                        PenMenu.Text = CType(DataGridView.Rows(hit.RowIndex).Cells(DGV_Description), DataGridViewTextBoxCell).Value
                        '取得信號寬度
                        PenWidthStation = CType(DataGridView.Rows(hit.RowIndex).Cells(DGV_Station), DataGridViewTextBoxCell).Value
                        PenWidthAddr = CType(DataGridView.Rows(hit.RowIndex).Cells(DGV_Address), DataGridViewTextBoxCell).Value
                        Width = Waveforms.GetSignalWidth(PenWidthStation, PenWidthAddr)
                        For i = 0 To 4
                            PenWidth(i).Checked = False
                        Next i
                        PenWidth(Width - 1).Checked = True
                        ContextMenuStripPenWidth.Show(DataGridView, New Point(e.X, e.Y))
                    End If
                End If
        End Select
    End Sub

    Private Sub ToolStripMenuItemValue_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemValue.Click
        ToolStripMenuItemPercent.Checked = False
        ToolStripMenuItemValue.Checked = True
        DataGridView.Columns(DGV_Value).HeaderText = "數    值"
        DataGridView.Columns(DGV_Value).SortMode = DataGridViewColumnSortMode.NotSortable
        Waveforms.CursorRefrashValue()
    End Sub

    Private Sub ToolStripMenuItemPercent_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemPercent.Click
        ToolStripMenuItemValue.Checked = False
        ToolStripMenuItemPercent.Checked = True
        DataGridView.Columns(DGV_Value).HeaderText = "百 分 比"
        DataGridView.Columns(DGV_Value).SortMode = DataGridViewColumnSortMode.Automatic
        Waveforms.CursorRefrashValue()
    End Sub

    Public Sub ViewMove()
        Waveforms.OperatorMode = Waveforms.OperatorType.ViewMove
    End Sub
    Public Sub LeaveViewMove()
        Waveforms.LeaveViewMove()
    End Sub

End Class