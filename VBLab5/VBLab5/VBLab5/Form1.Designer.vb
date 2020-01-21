<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btnWinner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstPlayer1 = New System.Windows.Forms.ListBox()
        Me.lstPlayer2 = New System.Windows.Forms.ListBox()
        Me.btnClearPlayer1 = New System.Windows.Forms.Button()
        Me.btnClearPlayer2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblplayerOneTotal = New System.Windows.Forms.Label()
        Me.lblplayerTwoTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblplayerOnePerfect = New System.Windows.Forms.Label()
        Me.lblplayerTwoPerfect = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPlayerOne = New System.Windows.Forms.TextBox()
        Me.txtPlayerTwo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblWinningPlayerName = New System.Windows.Forms.Label()
        Me.btnPlayerOne = New System.Windows.Forms.Button()
        Me.btnPlayerTwo = New System.Windows.Forms.Button()
        Me.btnWhoIsTheWinner = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Bowling Score Card"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(24, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player # 1 - Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(422, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Player # 1 - Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Scoring Tabulation:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(422, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Scoring Tabulation:"
        '
        'lstPlayer1
        '
        Me.lstPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPlayer1.FormattingEnabled = True
        Me.lstPlayer1.ItemHeight = 18
        Me.lstPlayer1.Items.AddRange(New Object() {"  Frame           Frame         Total", "  Number        Score          Score ", "----------------------------------------------------"})
        Me.lstPlayer1.Location = New System.Drawing.Point(13, 116)
        Me.lstPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.lstPlayer1.Name = "lstPlayer1"
        Me.lstPlayer1.Size = New System.Drawing.Size(240, 274)
        Me.lstPlayer1.TabIndex = 21
        '
        'lstPlayer2
        '
        Me.lstPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPlayer2.FormattingEnabled = True
        Me.lstPlayer2.ItemHeight = 18
        Me.lstPlayer2.Items.AddRange(New Object() {"  Frame           Frame         Total", "  Number        Score          Score ", "----------------------------------------------------"})
        Me.lstPlayer2.Location = New System.Drawing.Point(411, 116)
        Me.lstPlayer2.Margin = New System.Windows.Forms.Padding(2)
        Me.lstPlayer2.Name = "lstPlayer2"
        Me.lstPlayer2.Size = New System.Drawing.Size(240, 274)
        Me.lstPlayer2.TabIndex = 22
        '
        'btnClearPlayer1
        '
        Me.btnClearPlayer1.Location = New System.Drawing.Point(9, 418)
        Me.btnClearPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearPlayer1.Name = "btnClearPlayer1"
        Me.btnClearPlayer1.Size = New System.Drawing.Size(55, 49)
        Me.btnClearPlayer1.TabIndex = 7
        Me.btnClearPlayer1.Text = "Clear"
        Me.btnClearPlayer1.UseVisualStyleBackColor = True
        '
        'btnClearPlayer2
        '
        Me.btnClearPlayer2.Location = New System.Drawing.Point(605, 418)
        Me.btnClearPlayer2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearPlayer2.Name = "btnClearPlayer2"
        Me.btnClearPlayer2.Size = New System.Drawing.Size(55, 49)
        Me.btnClearPlayer2.TabIndex = 8
        Me.btnClearPlayer2.Text = "Clear"
        Me.btnClearPlayer2.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(496, 515)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 429)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 30)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Player # 1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Final Total:"
        '
        'lblplayerOneTotal
        '
        Me.lblplayerOneTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblplayerOneTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplayerOneTotal.Location = New System.Drawing.Point(139, 430)
        Me.lblplayerOneTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblplayerOneTotal.Name = "lblplayerOneTotal"
        Me.lblplayerOneTotal.Size = New System.Drawing.Size(57, 28)
        Me.lblplayerOneTotal.TabIndex = 12
        Me.lblplayerOneTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblplayerTwoTotal
        '
        Me.lblplayerTwoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblplayerTwoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplayerTwoTotal.Location = New System.Drawing.Point(470, 430)
        Me.lblplayerTwoTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblplayerTwoTotal.Name = "lblplayerTwoTotal"
        Me.lblplayerTwoTotal.Size = New System.Drawing.Size(57, 28)
        Me.lblplayerTwoTotal.TabIndex = 13
        Me.lblplayerTwoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(531, 419)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 48)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Player # 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Final Total:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblplayerOnePerfect
        '
        Me.lblplayerOnePerfect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblplayerOnePerfect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplayerOnePerfect.Location = New System.Drawing.Point(43, 479)
        Me.lblplayerOnePerfect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblplayerOnePerfect.Name = "lblplayerOnePerfect"
        Me.lblplayerOnePerfect.Size = New System.Drawing.Size(175, 28)
        Me.lblplayerOnePerfect.TabIndex = 17
        Me.lblplayerOnePerfect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblplayerTwoPerfect
        '
        Me.lblplayerTwoPerfect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblplayerTwoPerfect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplayerTwoPerfect.Location = New System.Drawing.Point(432, 479)
        Me.lblplayerTwoPerfect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblplayerTwoPerfect.Name = "lblplayerTwoPerfect"
        Me.lblplayerTwoPerfect.Size = New System.Drawing.Size(175, 28)
        Me.lblplayerTwoPerfect.TabIndex = 18
        Me.lblplayerTwoPerfect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(617, 506)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 58)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Donark Patel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSC-205-58" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VB Lab 5"
        '
        'txtPlayerOne
        '
        Me.txtPlayerOne.Location = New System.Drawing.Point(127, 54)
        Me.txtPlayerOne.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlayerOne.Name = "txtPlayerOne"
        Me.txtPlayerOne.Size = New System.Drawing.Size(103, 20)
        Me.txtPlayerOne.TabIndex = 1
        '
        'txtPlayerTwo
        '
        Me.txtPlayerTwo.Location = New System.Drawing.Point(525, 56)
        Me.txtPlayerTwo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlayerTwo.Name = "txtPlayerTwo"
        Me.txtPlayerTwo.Size = New System.Drawing.Size(103, 20)
        Me.txtPlayerTwo.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBLab5.My.Resources.Resources.Bowling
        Me.PictureBox1.Location = New System.Drawing.Point(276, 88)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(256, 169)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(151, 167)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "     The Winning Player's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Name is:"
        '
        'lblWinningPlayerName
        '
        Me.lblWinningPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWinningPlayerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblWinningPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinningPlayerName.Location = New System.Drawing.Point(276, 232)
        Me.lblWinningPlayerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWinningPlayerName.Name = "lblWinningPlayerName"
        Me.lblWinningPlayerName.Size = New System.Drawing.Size(105, 82)
        Me.lblWinningPlayerName.TabIndex = 24
        Me.lblWinningPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayerOne
        '
        Me.btnPlayerOne.Location = New System.Drawing.Point(201, 415)
        Me.btnPlayerOne.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlayerOne.Name = "btnPlayerOne"
        Me.btnPlayerOne.Size = New System.Drawing.Size(63, 60)
        Me.btnPlayerOne.TabIndex = 2
        Me.btnPlayerOne.Text = "Process " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Player # 1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.btnPlayerOne, "Click to enter the score for player 1")
        Me.btnPlayerOne.UseVisualStyleBackColor = True
        '
        'btnPlayerTwo
        '
        Me.btnPlayerTwo.Location = New System.Drawing.Point(403, 415)
        Me.btnPlayerTwo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlayerTwo.Name = "btnPlayerTwo"
        Me.btnPlayerTwo.Size = New System.Drawing.Size(63, 60)
        Me.btnPlayerTwo.TabIndex = 4
        Me.btnPlayerTwo.Text = "Process " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Player # 2 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.btnPlayerTwo, "Click to enter the score for player 2")
        Me.btnPlayerTwo.UseVisualStyleBackColor = True
        '
        'btnWhoIsTheWinner
        '
        Me.btnWhoIsTheWinner.Location = New System.Drawing.Point(276, 341)
        Me.btnWhoIsTheWinner.Name = "btnWhoIsTheWinner"
        Me.btnWhoIsTheWinner.Size = New System.Drawing.Size(94, 49)
        Me.btnWhoIsTheWinner.TabIndex = 6
        Me.btnWhoIsTheWinner.Text = "So Who Is The Winner ?"
        Me.ToolTip1.SetToolTip(Me.btnWhoIsTheWinner, "Click to see who is the winner?")
        Me.btnWhoIsTheWinner.UseVisualStyleBackColor = True
        '
        'btnWinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 589)
        Me.Controls.Add(Me.btnWhoIsTheWinner)
        Me.Controls.Add(Me.btnPlayerTwo)
        Me.Controls.Add(Me.btnPlayerOne)
        Me.Controls.Add(Me.lblWinningPlayerName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPlayerTwo)
        Me.Controls.Add(Me.txtPlayerOne)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblplayerTwoPerfect)
        Me.Controls.Add(Me.lblplayerOnePerfect)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblplayerTwoTotal)
        Me.Controls.Add(Me.lblplayerOneTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearPlayer2)
        Me.Controls.Add(Me.btnClearPlayer1)
        Me.Controls.Add(Me.lstPlayer2)
        Me.Controls.Add(Me.lstPlayer1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "btnWinner"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstPlayer1 As ListBox
    Friend WithEvents lstPlayer2 As ListBox
    Friend WithEvents btnClearPlayer1 As Button
    Friend WithEvents btnClearPlayer2 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblplayerOneTotal As Label
    Friend WithEvents lblplayerTwoTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblplayerOnePerfect As Label
    Friend WithEvents lblplayerTwoPerfect As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPlayerOne As TextBox
    Friend WithEvents txtPlayerTwo As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblWinningPlayerName As Label
    Friend WithEvents btnPlayerOne As Button
    Friend WithEvents btnPlayerTwo As Button
    Friend WithEvents btnWhoIsTheWinner As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
