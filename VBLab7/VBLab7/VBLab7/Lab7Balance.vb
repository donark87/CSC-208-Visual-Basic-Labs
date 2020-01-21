'Donark Patel 
'CSC-208-58
'Lab - 7 
'Date - 4/1/2018
'This Program creat new Gift card balance. Also add and suptract balance. 
'Balance Form
Public Class Lab7Balance
    Private Sub mnuBalanceFromGoToPurchaseForm_Click(sender As Object, e As EventArgs) Handles mnuBalanceFromGoToPurchaseForm.Click
        Dim intAccountNumber As Integer
        Dim strName As String
        Dim dblBalance As Double

        Try
            'Validating Gift Card Number textbox input
            If txtAccountNumber.Text = String.Empty Then
                MessageBox.Show("Error: Missing gift card number. You must enter 4 digit gift card number", "Error: Account Number")
                txtAccountNumber.Focus()
                txtAccountNumber.Clear()
                Return
            Else
                intAccountNumber = CInt(txtAccountNumber.Text)
                If intAccountNumber <= 999 Or intAccountNumber >= 10000 Then
                    MessageBox.Show("Error: Gift card account number need to be a positive 4 digit number " & "You have entered: " & intAccountNumber, "Error: Account Number")
                    txtAccountNumber.Focus()
                    txtAccountNumber.Clear()
                    Return
                End If
            End If

            'Validating Customer Name textbox input
            If txtName.Text = String.Empty Then
                MessageBox.Show("Error: Missing customer Name. You must enter customer name", "Error: Customer Name")
                txtName.Focus()
                txtName.Clear()
                Return
            ElseIf IsNumeric(txtName.Text) Then
                MessageBox.Show("Error: Customer name is numaric. Customer name can not be numeric " & "You have entered: " & txtName.Text, "Error: Customer Name")
                txtName.Focus()
                txtName.Clear()
                Return
            ElseIf txtName.Text.Trim = "" Then
                MessageBox.Show("Error: Missing customer Name. You must enter customer name", "Error: Customer Name-Space")
                Return
            Else
                strName = CStr(txtName.Text)
            End If
            'Validating Balance textbox input
            If txtBalance.Text = String.Empty Then
                MessageBox.Show("Error: Missing start up gift card amount. You must enter amount of money you want to load in to this Gift Card", "Error: Balance")
                txtBalance.Focus()
                txtBalance.Clear()
                Return
            Else
                dblBalance = CDbl(txtBalance.Text)
                If dblBalance < 10 Or dblBalance > 2000 Then
                    MessageBox.Show("Error: Gift card balance restriction. Gift card balance can not be lower then $10.00 or Balance can not be higer then $2000.00, " & "You have entered: " & FormatCurrency(dblBalance), "Error: Balance")
                    txtBalance.Focus()
                    txtBalance.Clear()
                    Return
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Please validate the data you have entered. Gift card account number need to be a positive 4 digit number. Customer name field can not be emty or numaric. You must enter startup amount of the gift card", "Error: Catch")
            Return
        End Try



        'Loading Purchase from
        Dim frmLab7Purchase As New Lab7Purchase

        'Inserting Data from Balance from to Purchase from
        frmLab7Purchase.txtPurcaseAccountNumber.Text = intAccountNumber
        frmLab7Purchase.txtPurcaseName.Text = strName
        frmLab7Purchase.txtPurcaseCurrentBalance.Text = FormatCurrency(dblBalance)

        frmLab7Purchase.ShowDialog()

        txtBalance.Text = FormatCurrency(frmLab7Purchase.txtPurcaseCurrentBalance.Text)




    End Sub

    Private Sub mnuBalanceFromClear_Click(sender As Object, e As EventArgs) Handles mnuBalanceFromClear.Click
        txtAccountNumber.Clear()
        txtBalance.Clear()
        txtName.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
