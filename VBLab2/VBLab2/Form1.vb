'VBLab2
'By: Donark Patel
'CSC208-58
'Date: Submitted: 01/31/2018
'Explanation: Visual Basic User Interface Controls About Me
Public Class Form1


    Private Sub btnSeePicture_Click(sender As Object, e As EventArgs) Handles btnSeePicture.Click
        picMyPicture.Visible = True
    End Sub

    Private Sub btnFlag_Click(sender As Object, e As EventArgs) Handles btnFlag.Click
        picFlag.Visible = True
    End Sub

    Private Sub btnHobby_Click(sender As Object, e As EventArgs) Handles btnHobby.Click
        picHobby.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStingName_Click(sender As Object, e As EventArgs) Handles btnStingName.Click
        lblStingOut.Text = txtFirstName.Text & " " & txtLastName.Text

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblStingOut.Text = String.Empty
        txtFirstName.Clear()
        txtLastName.Clear()
        picMyPicture.Visible = False
        picHobby.Visible = False
        picFlag.Visible = False

    End Sub
End Class
