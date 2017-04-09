Imports DEPP
Imports System.IO

Public Class frmSignals
    Private Const DGV_Index As Integer = 0
    Private Const DGV_Checked As Integer = 1
    Private Const DGV_Station As Integer = 2
    Private Const DGV_Address As Integer = 3
    Private Const DGV_KKS As Integer = 4
    Private Const DGV_Description As Integer = 5
    Public DF As DataFile
    Private CB As CheckBox
    Public DisplayList As New List(Of Integer)()

    Private Sub frmSignals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rows As DataGridViewRowCollection
        Dim i As Integer
        Dim rect As Rectangle

        DataGridView.RowsDefaultCellStyle.Font = New Font("Courier New", 12)
        DataGridView.Columns(DGV_Index).Visible = False
        DataGridView.Columns(DGV_Station).Visible = False
        '新增全選 CheckBox
        CB = New CheckBox
        CB.Text = ""
        CB.Checked = False
        rect = DataGridView.GetCellDisplayRectangle(1, -1, True)
        CB.Location = New Point((DataGridView.Columns(DGV_Checked).Width - 15) / 2.0 + 1.5, (DataGridView.ColumnHeadersHeight - 14) / 2.0 + 1.5)
        CB.Size = New Size(15, 14)
        AddHandler CB.CheckedChanged, AddressOf CB_CheckedChanged
        DataGridView.Controls.Clear()
        DataGridView.Controls.Add(CB)
        '初始化選單
        If DataGridView.Rows.Count = 0 Then
            rows = DataGridView.Rows
            For i = 0 To DF.Singal.Count - 1
                rows.Add(New Object() {
                         i,
                         False,
                         DF.Singal(i).Station,
                         DF.Singal(i).Address,
                         DF.Singal(i).KKS,
                         DF.Singal(i).Description})
            Next i
        End If
    End Sub

    Private Sub CB_CheckedChanged(sender As Object, e As EventArgs)
        Dim i As Integer

        For i = 0 To DataGridView.Rows.Count - 1
            DataGridView.Rows(i).Cells(DGV_Checked).Value = CType(sender, CheckBox).Checked
        Next i
        DataGridView.EndEdit()
    End Sub

    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click
        Dim i As Integer

        DisplayList.Clear()
        For i = 0 To DataGridView.RowCount - 1
            If DataGridView.Rows(i).Cells(DGV_Checked).Value = True Then
                DisplayList.Add(DataGridView.Rows(i).Cells(DGV_Index).Value)
            End If
        Next i
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub ButtonSaveList_Click(sender As Object, e As EventArgs) Handles ButtonSaveList.Click
        Dim file As StreamWriter
        Dim i As Integer

        SaveFileDialog.Filter = "信號清單 (*.SL)|*.SL"
        SaveFileDialog.RestoreDirectory = True

        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            file = New StreamWriter(SaveFileDialog.FileName)
            file.WriteLine("Signals List")
            For i = 0 To DataGridView.RowCount - 1
                If DataGridView.Rows(i).Cells(DGV_Checked).Value = True Then
                    file.WriteLine(DataGridView.Rows(i).Cells(DGV_Address).Value)
                    file.WriteLine(DataGridView.Rows(i).Cells(DGV_KKS).Value)
                    file.WriteLine(DataGridView.Rows(i).Cells(DGV_Description).Value)
                End If
            Next i
            file.Close()
        End If
    End Sub

    Private Sub ButtonLoadList_Click(sender As Object, e As EventArgs) Handles ButtonLoadList.Click
        Dim file As StreamReader
        Dim i As Integer
        Dim Sign As String
        Dim Addr As String
        Dim KKS As String
        Dim Description As String

        OpenFileDialog.Filter = "信號清單 (*.SL)|*.SL"
        OpenFileDialog.RestoreDirectory = True

        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            file = New StreamReader(OpenFileDialog.FileName)
            Sign = file.ReadLine()
            If Sign = "Signals List" Then
                Do While file.Peek() >= 0
                    Addr = file.ReadLine()
                    KKS = file.ReadLine()
                    Description = file.ReadLine()
                    For i = 0 To DataGridView.RowCount - 1
                        If DataGridView.Rows(i).Cells(DGV_Address).Value = Addr Then
                            DataGridView.Rows(i).Cells(DGV_Checked).Value = True
                            Exit For
                        End If
                    Next i
                Loop
            Else
                MsgBox("檔案格式錯誤", MsgBoxStyle.OkOnly, "警告")
            End If
            file.Close()
        End If
    End Sub
End Class