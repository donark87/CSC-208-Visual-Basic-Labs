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
        Me.lstOriginal = New System.Windows.Forms.ListBox()
        Me.lstOriginalAsecending = New System.Windows.Forms.ListBox()
        Me.lstLessEqual30 = New System.Windows.Forms.ListBox()
        Me.lstGreaterEqual20Desc = New System.Windows.Forms.ListBox()
        Me.lstBetween40to70 = New System.Windows.Forms.ListBox()
        Me.btnOrignalAscending = New System.Windows.Forms.Button()
        Me.btnOriginal = New System.Windows.Forms.Button()
        Me.btnLessEqual30 = New System.Windows.Forms.Button()
        Me.btnGreaterEqual20Desc = New System.Windows.Forms.Button()
        Me.btnBetween40to70 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstOriginal
        '
        Me.lstOriginal.FormattingEnabled = True
        Me.lstOriginal.ItemHeight = 20
        Me.lstOriginal.Location = New System.Drawing.Point(36, 113)
        Me.lstOriginal.Name = "lstOriginal"
        Me.lstOriginal.Size = New System.Drawing.Size(114, 324)
        Me.lstOriginal.TabIndex = 0
        '
        'lstOriginalAsecending
        '
        Me.lstOriginalAsecending.FormattingEnabled = True
        Me.lstOriginalAsecending.ItemHeight = 20
        Me.lstOriginalAsecending.Location = New System.Drawing.Point(187, 113)
        Me.lstOriginalAsecending.Name = "lstOriginalAsecending"
        Me.lstOriginalAsecending.Size = New System.Drawing.Size(120, 324)
        Me.lstOriginalAsecending.TabIndex = 1
        '
        'lstLessEqual30
        '
        Me.lstLessEqual30.FormattingEnabled = True
        Me.lstLessEqual30.ItemHeight = 20
        Me.lstLessEqual30.Location = New System.Drawing.Point(344, 113)
        Me.lstLessEqual30.Name = "lstLessEqual30"
        Me.lstLessEqual30.Size = New System.Drawing.Size(120, 324)
        Me.lstLessEqual30.TabIndex = 2
        '
        'lstGreaterEqual20Desc
        '
        Me.lstGreaterEqual20Desc.FormattingEnabled = True
        Me.lstGreaterEqual20Desc.ItemHeight = 20
        Me.lstGreaterEqual20Desc.Location = New System.Drawing.Point(501, 113)
        Me.lstGreaterEqual20Desc.Name = "lstGreaterEqual20Desc"
        Me.lstGreaterEqual20Desc.Size = New System.Drawing.Size(120, 324)
        Me.lstGreaterEqual20Desc.TabIndex = 3
        '
        'lstBetween40to70
        '
        Me.lstBetween40to70.FormattingEnabled = True
        Me.lstBetween40to70.ItemHeight = 20
        Me.lstBetween40to70.Location = New System.Drawing.Point(658, 113)
        Me.lstBetween40to70.Name = "lstBetween40to70"
        Me.lstBetween40to70.Size = New System.Drawing.Size(120, 324)
        Me.lstBetween40to70.TabIndex = 4
        '
        'btnOrignalAscending
        '
        Me.btnOrignalAscending.Location = New System.Drawing.Point(187, 456)
        Me.btnOrignalAscending.Name = "btnOrignalAscending"
        Me.btnOrignalAscending.Size = New System.Drawing.Size(120, 131)
        Me.btnOrignalAscending.TabIndex = 5
        Me.btnOrignalAscending.Text = "List of all parts " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in ascending order"
        Me.btnOrignalAscending.UseVisualStyleBackColor = True
        '
        'btnOriginal
        '
        Me.btnOriginal.Location = New System.Drawing.Point(30, 456)
        Me.btnOriginal.Name = "btnOriginal"
        Me.btnOriginal.Size = New System.Drawing.Size(120, 131)
        Me.btnOriginal.TabIndex = 6
        Me.btnOriginal.Text = "List of all parts"
        Me.btnOriginal.UseVisualStyleBackColor = True
        '
        'btnLessEqual30
        '
        Me.btnLessEqual30.Location = New System.Drawing.Point(344, 456)
        Me.btnLessEqual30.Name = "btnLessEqual30"
        Me.btnLessEqual30.Size = New System.Drawing.Size(120, 131)
        Me.btnLessEqual30.TabIndex = 7
        Me.btnLessEqual30.Text = "List of all parts " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">=" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "30"
        Me.btnLessEqual30.UseVisualStyleBackColor = True
        '
        'btnGreaterEqual20Desc
        '
        Me.btnGreaterEqual20Desc.Location = New System.Drawing.Point(501, 456)
        Me.btnGreaterEqual20Desc.Name = "btnGreaterEqual20Desc"
        Me.btnGreaterEqual20Desc.Size = New System.Drawing.Size(120, 131)
        Me.btnGreaterEqual20Desc.TabIndex = 8
        Me.btnGreaterEqual20Desc.Text = "List of all parts " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">= 20 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in ascending order"
        Me.btnGreaterEqual20Desc.UseVisualStyleBackColor = True
        '
        'btnBetween40to70
        '
        Me.btnBetween40to70.Location = New System.Drawing.Point(658, 456)
        Me.btnBetween40to70.Name = "btnBetween40to70"
        Me.btnBetween40to70.Size = New System.Drawing.Size(120, 131)
        Me.btnBetween40to70.TabIndex = 9
        Me.btnBetween40to70.Text = "List of all parts " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "between the values " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "40 to 70"
        Me.btnBetween40to70.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "List of all parts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 60)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "List of all parts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  in ascending " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 40)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "List of all parts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    >= 30"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 80)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "List of all parts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    >= 20 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in decending" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    order"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(654, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 60)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "  List of all parts " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "between the values " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     40 to 70"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(30, 604)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 51)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(187, 604)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 51)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(673, 598)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 60)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Donark Patel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSC 208-58" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VBLab 11" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 667)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBetween40to70)
        Me.Controls.Add(Me.btnGreaterEqual20Desc)
        Me.Controls.Add(Me.btnLessEqual30)
        Me.Controls.Add(Me.btnOriginal)
        Me.Controls.Add(Me.btnOrignalAscending)
        Me.Controls.Add(Me.lstBetween40to70)
        Me.Controls.Add(Me.lstGreaterEqual20Desc)
        Me.Controls.Add(Me.lstLessEqual30)
        Me.Controls.Add(Me.lstOriginalAsecending)
        Me.Controls.Add(Me.lstOriginal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOriginal As ListBox
    Friend WithEvents lstOriginalAsecending As ListBox
    Friend WithEvents lstLessEqual30 As ListBox
    Friend WithEvents lstGreaterEqual20Desc As ListBox
    Friend WithEvents lstBetween40to70 As ListBox
    Friend WithEvents btnOrignalAscending As Button
    Friend WithEvents btnOriginal As Button
    Friend WithEvents btnLessEqual30 As Button
    Friend WithEvents btnGreaterEqual20Desc As Button
    Friend WithEvents btnBetween40to70 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label6 As Label
End Class
