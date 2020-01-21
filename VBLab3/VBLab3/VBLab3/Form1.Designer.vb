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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblItemSubtotal = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblItemTotal = New System.Windows.Forms.Label()
        Me.lblAccSubtotal = New System.Windows.Forms.Label()
        Me.lblAccQuantity = New System.Windows.Forms.Label()
        Me.lblCounDifferentItem = New System.Windows.Forms.Label()
        Me.lblAccSalesTax = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MCC's Fast Food Checkout Form "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Individual Item Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Item Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Item Subtotal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Item Sales Tax:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 393)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Item Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(470, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 26)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Final Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ammount Due:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(470, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 26)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Accumulated " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sales Tax:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(470, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 26)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Accumulaated " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Subtotal:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(470, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 26)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Accumulated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quantity:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(470, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 26)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Count of Different" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item Purchased:"
        '
        'lblItemSubtotal
        '
        Me.lblItemSubtotal.AutoSize = True
        Me.lblItemSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemSubtotal.Location = New System.Drawing.Point(168, 279)
        Me.lblItemSubtotal.Name = "lblItemSubtotal"
        Me.lblItemSubtotal.Size = New System.Drawing.Size(2, 15)
        Me.lblItemSubtotal.TabIndex = 14
        Me.lblItemSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalesTax.Location = New System.Drawing.Point(168, 337)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSalesTax.Size = New System.Drawing.Size(2, 15)
        Me.lblSalesTax.TabIndex = 15
        Me.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemTotal
        '
        Me.lblItemTotal.AutoSize = True
        Me.lblItemTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemTotal.Location = New System.Drawing.Point(168, 393)
        Me.lblItemTotal.Name = "lblItemTotal"
        Me.lblItemTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblItemTotal.Size = New System.Drawing.Size(2, 15)
        Me.lblItemTotal.TabIndex = 16
        Me.lblItemTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAccSubtotal
        '
        Me.lblAccSubtotal.AutoSize = True
        Me.lblAccSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccSubtotal.Location = New System.Drawing.Point(653, 249)
        Me.lblAccSubtotal.Name = "lblAccSubtotal"
        Me.lblAccSubtotal.Size = New System.Drawing.Size(2, 15)
        Me.lblAccSubtotal.TabIndex = 19
        Me.lblAccSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAccQuantity
        '
        Me.lblAccQuantity.AutoSize = True
        Me.lblAccQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccQuantity.Location = New System.Drawing.Point(653, 181)
        Me.lblAccQuantity.Name = "lblAccQuantity"
        Me.lblAccQuantity.Size = New System.Drawing.Size(2, 15)
        Me.lblAccQuantity.TabIndex = 18
        Me.lblAccQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCounDifferentItem
        '
        Me.lblCounDifferentItem.AutoSize = True
        Me.lblCounDifferentItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCounDifferentItem.Location = New System.Drawing.Point(653, 126)
        Me.lblCounDifferentItem.Name = "lblCounDifferentItem"
        Me.lblCounDifferentItem.Size = New System.Drawing.Size(2, 15)
        Me.lblCounDifferentItem.TabIndex = 17
        Me.lblCounDifferentItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAccSalesTax
        '
        Me.lblAccSalesTax.AutoSize = True
        Me.lblAccSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccSalesTax.Location = New System.Drawing.Point(653, 317)
        Me.lblAccSalesTax.Name = "lblAccSalesTax"
        Me.lblAccSalesTax.Size = New System.Drawing.Size(2, 15)
        Me.lblAccSalesTax.TabIndex = 20
        Me.lblAccSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinalTotal.Location = New System.Drawing.Point(653, 385)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(2, 15)
        Me.lblFinalTotal.TabIndex = 21
        Me.lblFinalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(149, 115)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(124, 20)
        Me.txtName.TabIndex = 22
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(149, 171)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(124, 20)
        Me.txtQuantity.TabIndex = 23
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Location = New System.Drawing.Point(149, 227)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(124, 20)
        Me.txtItemPrice.TabIndex = 24
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(32, 431)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(107, 70)
        Me.btnCalculateTotal.TabIndex = 25
        Me.btnCalculateTotal.Text = "Calcuate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Totals"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(239, 431)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 70)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item "
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(453, 431)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 70)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Exit " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Form"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(666, 448)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 39)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Donark Patel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VBLab3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSC208-58"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(602, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Cumulative Totals"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 525)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblAccSalesTax)
        Me.Controls.Add(Me.lblAccSubtotal)
        Me.Controls.Add(Me.lblAccQuantity)
        Me.Controls.Add(Me.lblCounDifferentItem)
        Me.Controls.Add(Me.lblItemTotal)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblItemSubtotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblItemSubtotal As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblItemTotal As Label
    Friend WithEvents lblAccSubtotal As Label
    Friend WithEvents lblAccQuantity As Label
    Friend WithEvents lblCounDifferentItem As Label
    Friend WithEvents lblAccSalesTax As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents btnCalculateTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
End Class
