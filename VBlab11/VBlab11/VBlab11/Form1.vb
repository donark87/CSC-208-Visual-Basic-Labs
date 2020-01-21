'Donark Patel
'CSC 208 - 58
'VBLab 11
'Date -4 / 25 / 2018
'This application search and list the array item using linq
Public Class Form1
    Dim part() As Integer = {83, 24, 42, 7, 27, 18, 77, 39, 5, 68, 86, 56, 3, 14, 52}
    Private Sub btnOriginal_Click(sender As Object, e As EventArgs) Handles btnOriginal.Click
        lstOriginal.Items.Clear()

        Dim quaryResults = From item In part
                           Select item
        For Each intNum As Integer In quaryResults
            lstOriginal.Items.Add(intNum)
        Next
    End Sub

    Private Sub btnOrignalAscending_Click(sender As Object, e As EventArgs) Handles btnOrignalAscending.Click
        lstOriginalAsecending.Items.Clear()

        Dim quaryResults = From item In part
                           Select item
                           Order By item
        For Each intNum As Integer In quaryResults
            lstOriginalAsecending.Items.Add(intNum)
        Next
    End Sub

    Private Sub btnLessEqual30_Click(sender As Object, e As EventArgs) Handles btnLessEqual30.Click
        lstLessEqual30.Items.Clear()

        Dim quaryResults = From item In part
                           Where item <= 30
                           Select item

        For Each intNum As Integer In quaryResults
            lstLessEqual30.Items.Add(intNum)
        Next
    End Sub

    Private Sub btnGreaterEqual20Desc_Click(sender As Object, e As EventArgs) Handles btnGreaterEqual20Desc.Click
        lstGreaterEqual20Desc.Items.Clear()

        Dim quaryResults = From item In part
                           Where item >= 20
                           Select item
                           Order By item Descending

        For Each intNum As Integer In quaryResults
            lstGreaterEqual20Desc.Items.Add(intNum)
        Next
    End Sub

    Private Sub btnBetween40to70_Click(sender As Object, e As EventArgs) Handles btnBetween40to70.Click
        lstBetween40to70.Items.Clear()

        Dim quaryResults = From item In part
                           Where item >= 40 And item <= 70
                           Select item

        For Each intNum As Integer In quaryResults
            lstBetween40to70.Items.Add(intNum)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstBetween40to70.Items.Clear()
        lstGreaterEqual20Desc.Items.Clear()
        lstLessEqual30.Items.Clear()
        lstOriginal.Items.Clear()
        lstOriginalAsecending.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
