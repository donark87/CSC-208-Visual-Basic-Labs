'By: Donark Patel
'VBLab1 - Visual Basic introduction
'CSC208-58
'Date: Submited: 01/29/2018
'Explanation: This program will introduce simple Visual Basic controls and events
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        lblStop.Text = "Time To STOP!"
    End Sub

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        LblGo.Text = "Time To GO!"
    End Sub

    Private Sub BtnSlowDown_Click(sender As Object, e As EventArgs) Handles BtnSlowDown.Click
        LblSlowDown.Text = "Time to SLOW DOWN!"
    End Sub
End Class
