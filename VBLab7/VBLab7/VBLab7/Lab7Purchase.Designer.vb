<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab7Purchase
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPurcaseAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtPurcaseName = New System.Windows.Forms.TextBox()
        Me.txtPurcaseCurrentBalance = New System.Windows.Forms.TextBox()
        Me.txtPurcaseTransactionAmount = New System.Windows.Forms.TextBox()
        Me.txtPurcaseNewBalance = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuPurchaseFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPurchaseFormClearCurrentTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPurchaseFormDecreaseCardValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPurchaseFormIncreaseCardValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPurchaseFormBalanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPurchaseFormGoToBalanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPurchaseFormExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Purchase Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gift Card "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Paisono's Pizzeria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Current Balance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Before Transaction:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Customer Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gift Card Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Transaction Amount:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 30)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "New Balance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "After Transaction:"
        '
        'txtPurcaseAccountNumber
        '
        Me.txtPurcaseAccountNumber.Location = New System.Drawing.Point(236, 146)
        Me.txtPurcaseAccountNumber.Name = "txtPurcaseAccountNumber"
        Me.txtPurcaseAccountNumber.ReadOnly = True
        Me.txtPurcaseAccountNumber.Size = New System.Drawing.Size(190, 20)
        Me.txtPurcaseAccountNumber.TabIndex = 11
        '
        'txtPurcaseName
        '
        Me.txtPurcaseName.Location = New System.Drawing.Point(236, 193)
        Me.txtPurcaseName.Name = "txtPurcaseName"
        Me.txtPurcaseName.ReadOnly = True
        Me.txtPurcaseName.Size = New System.Drawing.Size(190, 20)
        Me.txtPurcaseName.TabIndex = 12
        '
        'txtPurcaseCurrentBalance
        '
        Me.txtPurcaseCurrentBalance.Location = New System.Drawing.Point(236, 240)
        Me.txtPurcaseCurrentBalance.Name = "txtPurcaseCurrentBalance"
        Me.txtPurcaseCurrentBalance.ReadOnly = True
        Me.txtPurcaseCurrentBalance.Size = New System.Drawing.Size(104, 20)
        Me.txtPurcaseCurrentBalance.TabIndex = 13
        Me.txtPurcaseCurrentBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPurcaseTransactionAmount
        '
        Me.txtPurcaseTransactionAmount.Location = New System.Drawing.Point(236, 302)
        Me.txtPurcaseTransactionAmount.Name = "txtPurcaseTransactionAmount"
        Me.txtPurcaseTransactionAmount.Size = New System.Drawing.Size(104, 20)
        Me.txtPurcaseTransactionAmount.TabIndex = 14
        Me.txtPurcaseTransactionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPurcaseNewBalance
        '
        Me.txtPurcaseNewBalance.Location = New System.Drawing.Point(236, 349)
        Me.txtPurcaseNewBalance.Name = "txtPurcaseNewBalance"
        Me.txtPurcaseNewBalance.ReadOnly = True
        Me.txtPurcaseNewBalance.Size = New System.Drawing.Size(104, 20)
        Me.txtPurcaseNewBalance.TabIndex = 15
        Me.txtPurcaseNewBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPurchaseFormToolStripMenuItem, Me.mnuPurchaseFormBalanceFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(528, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuPurchaseFormToolStripMenuItem
        '
        Me.mnuPurchaseFormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPurchaseFormClearCurrentTransactionToolStripMenuItem, Me.ToolStripSeparator1, Me.mnuPurchaseFormDecreaseCardValueToolStripMenuItem, Me.mnuPurchaseFormIncreaseCardValueToolStripMenuItem})
        Me.mnuPurchaseFormToolStripMenuItem.Name = "mnuPurchaseFormToolStripMenuItem"
        Me.mnuPurchaseFormToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.mnuPurchaseFormToolStripMenuItem.Text = "&Purchase Form"
        '
        'mnuPurchaseFormClearCurrentTransactionToolStripMenuItem
        '
        Me.mnuPurchaseFormClearCurrentTransactionToolStripMenuItem.Name = "mnuPurchaseFormClearCurrentTransactionToolStripMenuItem"
        Me.mnuPurchaseFormClearCurrentTransactionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuPurchaseFormClearCurrentTransactionToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.mnuPurchaseFormClearCurrentTransactionToolStripMenuItem.Text = "&Clear Current Transaction"
        '
        'mnuPurchaseFormDecreaseCardValueToolStripMenuItem
        '
        Me.mnuPurchaseFormDecreaseCardValueToolStripMenuItem.Name = "mnuPurchaseFormDecreaseCardValueToolStripMenuItem"
        Me.mnuPurchaseFormDecreaseCardValueToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuPurchaseFormDecreaseCardValueToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.mnuPurchaseFormDecreaseCardValueToolStripMenuItem.Text = "&Decrease Card Value"
        '
        'mnuPurchaseFormIncreaseCardValueToolStripMenuItem
        '
        Me.mnuPurchaseFormIncreaseCardValueToolStripMenuItem.Name = "mnuPurchaseFormIncreaseCardValueToolStripMenuItem"
        Me.mnuPurchaseFormIncreaseCardValueToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuPurchaseFormIncreaseCardValueToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.mnuPurchaseFormIncreaseCardValueToolStripMenuItem.Text = "&Increase Card Value"
        '
        'mnuPurchaseFormBalanceFormToolStripMenuItem
        '
        Me.mnuPurchaseFormBalanceFormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPurchaseFormGoToBalanceFormToolStripMenuItem, Me.mnuPurchaseFormExitToolStripMenuItem})
        Me.mnuPurchaseFormBalanceFormToolStripMenuItem.Name = "mnuPurchaseFormBalanceFormToolStripMenuItem"
        Me.mnuPurchaseFormBalanceFormToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.mnuPurchaseFormBalanceFormToolStripMenuItem.Text = "&Balance Form"
        '
        'mnuPurchaseFormGoToBalanceFormToolStripMenuItem
        '
        Me.mnuPurchaseFormGoToBalanceFormToolStripMenuItem.Name = "mnuPurchaseFormGoToBalanceFormToolStripMenuItem"
        Me.mnuPurchaseFormGoToBalanceFormToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.mnuPurchaseFormGoToBalanceFormToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.mnuPurchaseFormGoToBalanceFormToolStripMenuItem.Text = "&Go to Balance Form"
        '
        'mnuPurchaseFormExitToolStripMenuItem
        '
        Me.mnuPurchaseFormExitToolStripMenuItem.Name = "mnuPurchaseFormExitToolStripMenuItem"
        Me.mnuPurchaseFormExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuPurchaseFormExitToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.mnuPurchaseFormExitToolStripMenuItem.Text = "&Exit"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(442, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 41)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Donark Patel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSC-208-58" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VB Lab 7"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(243, 6)
        '
        'Lab7Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 406)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPurcaseNewBalance)
        Me.Controls.Add(Me.txtPurcaseTransactionAmount)
        Me.Controls.Add(Me.txtPurcaseCurrentBalance)
        Me.Controls.Add(Me.txtPurcaseName)
        Me.Controls.Add(Me.txtPurcaseAccountNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Lab7Purchase"
        Me.Text = "Lab7Purchase"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPurcaseAccountNumber As TextBox
    Friend WithEvents txtPurcaseName As TextBox
    Friend WithEvents txtPurcaseCurrentBalance As TextBox
    Friend WithEvents txtPurcaseTransactionAmount As TextBox
    Friend WithEvents txtPurcaseNewBalance As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuPurchaseFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPurchaseFormClearCurrentTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPurchaseFormDecreaseCardValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPurchaseFormIncreaseCardValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPurchaseFormBalanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPurchaseFormGoToBalanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPurchaseFormExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
