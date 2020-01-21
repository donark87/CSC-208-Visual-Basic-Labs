'Donark Patel 
'Vb Lab 5 
'CSC-208-58
'Date - 2/28/2018
'This application calculated the bowling score between two players. And also determined the winner between two player.  
Public Class btnWinner
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPlayerOne_Click(sender As Object, e As EventArgs) Handles btnPlayerOne.Click
        Dim strPlayerName As String
        Dim intCount As Integer = 1
        Const intNumFrame As Integer = 10
        Dim strInput As String
        Dim intFrameScore As Integer
        Dim intTotalScore As Integer
        Dim intPlayerOneScore As Integer


        If txtPlayerOne.Text = String.Empty Then
            MessageBox.Show("Error: You must enter the name of player 1", "Error - Player Name")
            txtPlayerOne.Focus()
        Else
            strPlayerName = CStr(txtPlayerOne.Text)

            Do While intCount <= intNumFrame
                strInput = InputBox("Enter the score of " & strPlayerName & " " & "Frame " & intCount, "Score entry")

                If Integer.TryParse(strInput, intFrameScore) Then
                    If intFrameScore >= 0 And intFrameScore <= 30 Then
                        intTotalScore += intFrameScore

                        lstPlayer1.Items.Add(intCount & "                    " & intFrameScore & "                    " & intTotalScore)

                        intCount += 1
                    Else
                        MessageBox.Show("Invalid score entered. Score must be within the range of 0 trough 30. You entered: " & strInput, "Error - Invlid score entry")
                    End If
                Else
                    MessageBox.Show("Invalid score entered. Score must be numaric and within the range of 0 trough 30. You entered: " & strInput, "Error - Invlid score entry")
                End If
            Loop
        End If

        lblplayerOneTotal.Text = intTotalScore
        intPlayerOneScore = intTotalScore

        If intTotalScore = 300 Then
            lblplayerOnePerfect.Text = ("Perfect Score!")
        End If



    End Sub

    Private Sub lstPlayer1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPlayer1.SelectedIndexChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPlayerTwo_Click(sender As Object, e As EventArgs) Handles btnPlayerTwo.Click
        Dim strPlayerName As String
        Dim intCount As Integer = 1
        Const intNumFrame As Integer = 10
        Dim strInput As String
        Dim intFrameScore As Integer
        Dim intTotalScore As Integer
        Dim intPlayerTwoScore As Integer

        If txtPlayerTwo.Text = String.Empty Then
            MessageBox.Show("Error: You must enter the name of player 2", "Error - Player Name")
            txtPlayerTwo.Focus()
        Else
            strPlayerName = CStr(txtPlayerTwo.Text)

            Do While intCount <= intNumFrame
                strInput = InputBox("Enter the score of " & strPlayerName & " " & "Frame " & intCount, "Score entry")

                If Integer.TryParse(strInput, intFrameScore) Then
                    If intFrameScore >= 0 And intFrameScore <= 30 Then
                        intTotalScore += intFrameScore

                        lstPlayer2.Items.Add(intCount & "                    " & intFrameScore & "                    " & intTotalScore)

                        intCount += 1
                    Else
                        MessageBox.Show("Invalid score entered. Score must be within the range of 0 trough 30. You entered: " & strInput, "Error - Invlid score entry")
                    End If
                Else
                    MessageBox.Show("Invalid score entered. Score must be numaric and within the range of 0 trough 30. You entered: " & strInput, "Error - Invlid score entry")
                End If
            Loop
        End If

        lblplayerTwoTotal.Text = intTotalScore
        intPlayerTwoScore = intTotalScore

        If intTotalScore = 300 Then
            lblplayerTwoPerfect.Text = ("Perfect Score!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWhoIsTheWinner.Click
        Dim intPlayerOneScore As Integer
        Dim intPlayerTwoScore As Integer
        Dim strPlayerOneName As String
        Dim strPlayerTwoName As String

        intPlayerTwoScore = CInt(lblplayerTwoTotal.Text)
        intPlayerOneScore = CInt(lblplayerOneTotal.Text)
        strPlayerOneName = CStr(txtPlayerOne.Text)
        strPlayerTwoName = CStr(txtPlayerTwo.Text)



        If intPlayerOneScore = intPlayerTwoScore Then
            lblWinningPlayerName.Text = "Tie"
        ElseIf intPlayerOneScore > intPlayerTwoScore Then
            lblWinningPlayerName.Text = "Player 1: " & strPlayerOneName
        ElseIf intPlayerOneScore < intPlayerTwoScore Then
            lblWinningPlayerName.Text = "Player 2: " & strPlayerTwoName
        End If
    End Sub

    Private Sub btnClearPlayer1_Click(sender As Object, e As EventArgs) Handles btnClearPlayer1.Click
        lstPlayer1.Items.Clear()
        txtPlayerOne.Text = String.Empty
        lblplayerOnePerfect.Text = String.Empty
        lblplayerOneTotal.Text = String.Empty
        If lblWinningPlayerName.Text IsNot String.Empty Then
            lblWinningPlayerName.Text = String.Empty
        End If


    End Sub

    Private Sub btnClearPlayer2_Click(sender As Object, e As EventArgs) Handles btnClearPlayer2.Click
        lstPlayer2.Items.Clear()
        txtPlayerTwo.Text = String.Empty
        lblplayerTwoPerfect.Text = String.Empty
        lblplayerTwoTotal.Text = String.Empty
        If lblWinningPlayerName.Text IsNot String.Empty Then
            lblWinningPlayerName.Text = String.Empty
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

End Class
