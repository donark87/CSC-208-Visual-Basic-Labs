<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblGo = New System.Windows.Forms.Label()
        Me.LblSlowDown = New System.Windows.Forms.Label()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.BtnSlowDown = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(294, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ready, Set Go!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(572, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Donark Patel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VBLab1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSC208-58"
        '
        'LblGo
        '
        Me.LblGo.AutoSize = True
        Me.LblGo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblGo.Location = New System.Drawing.Point(12, 52)
        Me.LblGo.Name = "LblGo"
        Me.LblGo.Size = New System.Drawing.Size(225, 13)
        Me.LblGo.TabIndex = 2
        Me.LblGo.Text = "What does the color green mean on the road?"
        '
        'LblSlowDown
        '
        Me.LblSlowDown.AutoSize = True
        Me.LblSlowDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblSlowDown.Location = New System.Drawing.Point(243, 52)
        Me.LblSlowDown.Name = "LblSlowDown"
        Me.LblSlowDown.Size = New System.Drawing.Size(227, 13)
        Me.LblSlowDown.TabIndex = 3
        Me.LblSlowDown.Text = "What does the color yellow mean on the road?"
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.ForeColor = System.Drawing.Color.Red
        Me.lblStop.Location = New System.Drawing.Point(476, 52)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(213, 13)
        Me.lblStop.TabIndex = 4
        Me.lblStop.Text = "What does the color red mean on the road?"
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(71, 94)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(75, 23)
        Me.BtnGo.TabIndex = 5
        Me.BtnGo.Text = "Go!"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'BtnSlowDown
        '
        Me.BtnSlowDown.Location = New System.Drawing.Point(307, 94)
        Me.BtnSlowDown.Name = "BtnSlowDown"
        Me.BtnSlowDown.Size = New System.Drawing.Size(75, 23)
        Me.BtnSlowDown.TabIndex = 6
        Me.BtnSlowDown.Text = "Slow Down!"
        Me.BtnSlowDown.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(533, 94)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(75, 23)
        Me.BtnStop.TabIndex = 7
        Me.BtnStop.Text = "Stop!"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 457)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnSlowDown)
        Me.Controls.Add(Me.BtnGo)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.LblSlowDown)
        Me.Controls.Add(Me.LblGo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblGo As Label
    Friend WithEvents LblSlowDown As Label
    Friend WithEvents lblStop As Label
    Friend WithEvents BtnGo As Button
    Friend WithEvents BtnSlowDown As Button
    Friend WithEvents BtnStop As Button
End Class
