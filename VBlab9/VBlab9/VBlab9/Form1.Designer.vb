<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtBillAmount = New System.Windows.Forms.TextBox()
        Me.txtCustomerStatus = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.btnDisplayRecord = New System.Windows.Forms.Button()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.pddPrintDualog = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBillAmount
        '
        Me.txtBillAmount.Location = New System.Drawing.Point(183, 218)
        Me.txtBillAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.Size = New System.Drawing.Size(112, 20)
        Me.txtBillAmount.TabIndex = 6
        '
        'txtCustomerStatus
        '
        Me.txtCustomerStatus.Location = New System.Drawing.Point(183, 187)
        Me.txtCustomerStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomerStatus.MaxLength = 1
        Me.txtCustomerStatus.Name = "txtCustomerStatus"
        Me.txtCustomerStatus.Size = New System.Drawing.Size(112, 20)
        Me.txtCustomerStatus.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(183, 155)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.MaxLength = 10
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(112, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(183, 123)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMiddleName.MaxLength = 1
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(112, 20)
        Me.txtMiddleName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(183, 91)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.MaxLength = 10
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(112, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(97, 218)
        Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(82, 13)
        Me.label6.TabIndex = 22
        Me.label6.Text = "Bill amount due "
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(92, 187)
        Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(85, 13)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Customer status "
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(110, 123)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(70, 13)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Middle name "
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(123, 155)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Last name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(123, 91)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 13)
        Me.label2.TabIndex = 18
        Me.label2.Text = "First name"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(74, 59)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(103, 13)
        Me.label1.TabIndex = 17
        Me.label1.Text = "Customer ID number"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(183, 57)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomerID.MaxLength = 4
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(112, 20)
        Me.txtCustomerID.TabIndex = 1
        '
        'btnDisplayRecord
        '
        Me.btnDisplayRecord.Location = New System.Drawing.Point(307, 175)
        Me.btnDisplayRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplayRecord.Name = "btnDisplayRecord"
        Me.btnDisplayRecord.Size = New System.Drawing.Size(111, 60)
        Me.btnDisplayRecord.TabIndex = 8
        Me.btnDisplayRecord.Text = "Display Customer Record"
        Me.btnDisplayRecord.UseVisualStyleBackColor = True
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Location = New System.Drawing.Point(307, 75)
        Me.btnAddRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(111, 60)
        Me.btnAddRecord.TabIndex = 7
        Me.btnAddRecord.Text = "Add Customer Record "
        Me.btnAddRecord.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(179, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 22)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Customer Discount"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(434, 76)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 60)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(434, 175)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 60)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(452, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 39)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Donark Patel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSC 208-58" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VB Lab 9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pdPrint
        '
        Me.pdPrint.DocumentName = "DiscountReport.txt"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(582, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFilePrint})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.Size = New System.Drawing.Size(99, 22)
        Me.mnuFilePrint.Text = "Print"
        '
        'pddPrintDualog
        '
        Me.pddPrintDualog.Document = Me.pdPrint
        Me.pddPrintDualog.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 335)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBillAmount)
        Me.Controls.Add(Me.txtCustomerStatus)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.btnDisplayRecord)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Customer Discount"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtBillAmount As TextBox
    Private WithEvents txtCustomerStatus As TextBox
    Private WithEvents txtLastName As TextBox
    Private WithEvents txtMiddleName As TextBox
    Private WithEvents txtFirstName As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtCustomerID As TextBox
    Private WithEvents btnDisplayRecord As Button
    Private WithEvents btnAddRecord As Button
    Private WithEvents Label7 As Label
    Private WithEvents btnClear As Button
    Private WithEvents btnExit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents pdPrint As Printing.PrintDocument
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFilePrint As ToolStripMenuItem
    Friend WithEvents pddPrintDualog As PrintDialog
End Class
