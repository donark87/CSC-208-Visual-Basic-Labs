'Donark Patel
'CSC-208-58
'Date: 2/7/2018
'Mcc's FastFood Chcekout Form 
Public Class Form1
    Dim intCountDifferetItem As Integer = 0
    Dim intAccQuantity As Integer
    Dim dblAccSubtotal As Double
    Dim dblAccSalesTax As Double
    Dim dblFinalTotal As Double

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim intQuantity As Integer
        Dim dblItemPrice As Double
        Dim dblSubtotal As Double
        Dim dblSalesTax As Double = 0.07D
        Dim dblCalculatedSalesTax As Double
        Dim dblItemTotal As Double

        Try
            intQuantity = CInt(txtQuantity.Text)
            dblItemPrice = CDbl(txtItemPrice.Text)
            dblSubtotal = intQuantity * dblItemPrice
            dblCalculatedSalesTax = dblSalesTax * dblSubtotal
            dblItemTotal = dblSubtotal + dblCalculatedSalesTax

            lblItemSubtotal.Text = FormatCurrency(dblSubtotal)
            lblSalesTax.Text = FormatCurrency(dblCalculatedSalesTax)
            lblItemTotal.Text = FormatCurrency(dblItemTotal)

            intCountDifferetItem += 1
            lblCounDifferentItem.Text = intCountDifferetItem

            intAccQuantity += intQuantity
            lblAccQuantity.Text = intAccQuantity

            dblAccSubtotal += dblSubtotal
            lblAccSubtotal.Text = FormatCurrency(dblAccSubtotal)

            dblAccSalesTax += dblCalculatedSalesTax
            lblAccSalesTax.Text = FormatCurrency(dblAccSalesTax)

            dblFinalTotal += dblItemTotal
            lblFinalTotal.Text = FormatCurrency(dblFinalTotal)

        Catch
            MessageBox.Show("Error : Be sure to enter nonzero and numeric vales in Quantity & Item Price", "Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItemPrice.Clear()
        txtName.Clear()
        txtQuantity.Clear()
        lblItemSubtotal.Text = String.Empty
        lblSalesTax.Text = String.Empty
        lblItemTotal.Text = String.Empty

    End Sub


End Class
