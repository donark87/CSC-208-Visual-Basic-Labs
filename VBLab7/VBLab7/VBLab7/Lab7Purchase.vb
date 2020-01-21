'Donark Patel 
'CSC-208-58
'Lab - 7 
'Date - 4/1/2018
'This Program creat new Gift card balance. Also add and suptract balance.
'Purchase Form
Public Class Lab7Purchase


    Private Sub mnuPurchaseFormDecreaseCardValueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPurchaseFormDecreaseCardValueToolStripMenuItem.Click
        Dim intAccountNumber As Integer
        Dim strName As String
        Dim dblBalance As Double
        Dim dblTransactionAmount As Double
        Dim dblNewBalance As Double

        intAccountNumber = txtPurcaseAccountNumber.Text
        strName = txtPurcaseName.Text
        dblBalance = CDbl(txtPurcaseCurrentBalance.Text)

        Try

            If txtPurcaseTransactionAmount.Text = String.Empty Then
                MessageBox.Show("Error: Missing transaction amount. You must enter the amount that you want to subtract from the gift card", "Error: Transaction Ammount")
                txtPurcaseTransactionAmount.Focus()
                txtPurcaseTransactionAmount.Clear()
                Return
            End If
            dblTransactionAmount = CDbl(txtPurcaseTransactionAmount.Text)
            dblNewBalance = dblBalance - dblTransactionAmount
            If dblNewBalance < 10 Then
                MessageBox.Show("Error: : Gift card balance restriction. Gift card balance cannot be lower then $10.00 or balance cannot be higer then $2000.00, ", "Error: Balance Restriction ")
                txtPurcaseTransactionAmount.Focus()
                txtPurcaseTransactionAmount.Clear()
                Return
            End If
            txtPurcaseNewBalance.Text = FormatCurrency(dblNewBalance)

        Catch ex As Exception
            MessageBox.Show("Error: Transaction amount need to be non-zero numaric number.", "Error: Catch")
        End Try
    End Sub

    Private Sub mnuPurchaseFormIncreaseCardValueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPurchaseFormIncreaseCardValueToolStripMenuItem.Click
        Dim intAccountNumber As Integer
        Dim strName As String
        Dim dblBalance As Double
        Dim dblTransactionAmount As Double
        Dim dblNewBalance As Double

        intAccountNumber = txtPurcaseAccountNumber.Text
        strName = txtPurcaseName.Text
        dblBalance = CDbl(txtPurcaseCurrentBalance.Text)

        Try

            If txtPurcaseTransactionAmount.Text = String.Empty Then
                MessageBox.Show("Error: Missing transaction amount. You must enter the amount that you want to add to the gift card", "Error: Transaction Ammount")
                txtPurcaseTransactionAmount.Focus()
                txtPurcaseTransactionAmount.Clear()
                Return
            End If
            dblTransactionAmount = CDbl(txtPurcaseTransactionAmount.Text)
            dblNewBalance = dblBalance + dblTransactionAmount
            If dblNewBalance > 2000 Then
                MessageBox.Show("Error: : Gift card balance restriction. Gift card balance can not be lower then $10.00 or balance can not be higer then $2000.00. ", "Error: Balance Restriction ")
                txtPurcaseTransactionAmount.Focus()
                txtPurcaseTransactionAmount.Clear()
                Return
            End If

            txtPurcaseNewBalance.Text = FormatCurrency(dblNewBalance)

        Catch ex As Exception
            MessageBox.Show("Error: Transaction amount need to be non-zero numaric number.", "Error: Catch")
        End Try
    End Sub

    Private Sub mnuPurchaseFormExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPurchaseFormExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mnuPurchaseFormClearCurrentTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPurchaseFormClearCurrentTransactionToolStripMenuItem.Click
        txtPurcaseCurrentBalance.Text = FormatCurrency(txtPurcaseNewBalance.Text)
        txtPurcaseTransactionAmount.Clear()
        txtPurcaseNewBalance.Clear()
    End Sub

    Private Sub mnuPurchaseFormGoToBalanceFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPurchaseFormGoToBalanceFormToolStripMenuItem.Click
        'Loading Balance from
        Dim frmLab7Balance As New Lab7Balance

        Me.Close()
        frmLab7Balance.txtBalance.Text = FormatCurrency(txtPurcaseCurrentBalance.Text)


    End Sub

    Private Sub Lab7Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class