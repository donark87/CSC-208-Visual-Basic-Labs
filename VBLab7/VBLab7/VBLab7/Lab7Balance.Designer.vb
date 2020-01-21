<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lab7Balance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBalanceForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBalanceFromClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBalanceFromPurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBalanceFromGoToPurchaseForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paisono's Pizzeria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gift Card "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Balance Form"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gift Card Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Customer Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Current Balance:"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(255, 173)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(190, 20)
        Me.txtAccountNumber.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(255, 220)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(190, 20)
        Me.txtName.TabIndex = 7
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(255, 268)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(190, 20)
        Me.txtBalance.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBalanceForm, Me.mnuBalanceFromPurchase})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(525, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBalanceForm
        '
        Me.mnuBalanceForm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBalanceFromClear, Me.ExitToolStripMenuItem})
        Me.mnuBalanceForm.Name = "mnuBalanceForm"
        Me.mnuBalanceForm.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuBalanceForm.Size = New System.Drawing.Size(91, 20)
        Me.mnuBalanceForm.Text = "&Balance Form"
        '
        'mnuBalanceFromClear
        '
        Me.mnuBalanceFromClear.Name = "mnuBalanceFromClear"
        Me.mnuBalanceFromClear.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuBalanceFromClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuBalanceFromClear.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit "
        '
        'mnuBalanceFromPurchase
        '
        Me.mnuBalanceFromPurchase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBalanceFromGoToPurchaseForm})
        Me.mnuBalanceFromPurchase.Name = "mnuBalanceFromPurchase"
        Me.mnuBalanceFromPurchase.Size = New System.Drawing.Size(98, 20)
        Me.mnuBalanceFromPurchase.Text = "&Purchase Form"
        '
        'mnuBalanceFromGoToPurchaseForm
        '
        Me.mnuBalanceFromGoToPurchaseForm.Name = "mnuBalanceFromGoToPurchaseForm"
        Me.mnuBalanceFromGoToPurchaseForm.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.mnuBalanceFromGoToPurchaseForm.Size = New System.Drawing.Size(225, 22)
        Me.mnuBalanceFromGoToPurchaseForm.Text = "&Go To Purchase Form"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(450, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 41)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Donark Patel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSC-208-58" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VB Lab 7"
        '
        'Lab7Balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 354)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Lab7Balance"
        Me.Text = "Balance Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBalanceForm As ToolStripMenuItem
    Friend WithEvents mnuBalanceFromClear As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuBalanceFromPurchase As ToolStripMenuItem
    Friend WithEvents mnuBalanceFromGoToPurchaseForm As ToolStripMenuItem
    Friend WithEvents Label7 As Label
End Class
