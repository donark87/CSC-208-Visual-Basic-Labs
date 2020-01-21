'Donark Patel 
'CSC-208-58
'VB Lab 8
'Date: 4/4/2018
'This application determine the discounted price of an item.
Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the application
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all fields 
        txtItem.Text = String.Empty
        txtQuantity.Text = String.Empty
        lblDiscountedPrice.Text = String.Empty
        lblPrice.Text = String.Empty
        lblSavingAmount.Text = String.Empty
        lblTotal.Text = String.Empty
        lblDiscountCategory.Text = String.Empty
        lblDiscountPercentage.Text = String.Empty


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intIntemNumber As Integer
        Dim intQuantity As Integer
        Dim decPrice As Decimal
        Dim intCategory As Integer
        Dim decDiscountPer As Integer
        Dim decDiscountedPrice As Decimal
        Dim decTotal As Decimal
        Dim decSaving As Decimal

        'Array
        Dim decListPriceArray(,) = {{1987, 0.55},
                               {3243, 25.0},
                               {3454, 429.0},
                               {4324, 32.0},
                               {4423, 750.0},
                               {5423, 75.0},
                               {6534, 2.25},
                               {7364, 125.0},
                               {7453, 37.5},
                               {8745, 1.25}}
        Dim intCategoryCategory(,) = {{1987, 3},
                                       {3243, 1},
                                       {3454, 2},
                                       {4324, 1},
                                       {4423, 2},
                                       {5423, 2},
                                       {6534, 3},
                                       {7364, 4},
                                       {7453, 1},
                                       {8745, 3}}
        Dim decDiscountPercent(,) = {{1, 10},
                                      {2, 7},
                                      {3, 5}}
        'Validating the input data
        Try
            If txtItem.Text = String.Empty Then
                txtItem.Focus()
                MessageBox.Show("Error: Item number is missing. Please enter the Item number", "Input Data Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

                Return
            Else
                intIntemNumber = CInt(txtItem.Text)
                decPrice = FindPrice(decListPriceArray, intIntemNumber)
                If decPrice = 0 Then
                    txtItem.Focus()
                    MessageBox.Show("Error: Invalid Item number. Please, enter valid item number. You have entered: " & intIntemNumber, "Input Data Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                    Return
                End If
            End If
        Catch
            txtItem.Focus()
            MessageBox.Show("Error: Invalid item number. Please enter a 4 digit item number. You have entered: " & txtItem.Text, "Input Data Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
            Return
        End Try


        Try
            If txtQuantity.Text = String.Empty Then
                txtQuantity.Focus()
                MessageBox.Show("Error: Quantity number is missing. Please enter the quantity number", "Input Data Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                Return
            Else
                intQuantity = CInt(txtQuantity.Text)
                If intQuantity <= 0 Then
                    txtQuantity.Focus()
                    MessageBox.Show("Error: Invalid number for a quantity. Please enter non-zera number. You have entered: " & intQuantity, "Input Data Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                    Return
                End If
            End If
        Catch
            txtQuantity.Focus()
            MessageBox.Show("Error: Invalid number for quantity. Please enter non-zero number. You have entered: " & txtQuantity.Text, "Input Data Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
            Return
        End Try


        lblPrice.Text = FormatCurrency(decPrice)

        intCategory = FindDiscountCategory(intCategoryCategory, intIntemNumber)
        lblDiscountCategory.Text = intCategory



        decDiscountPer = FindDiscountPercentage(decDiscountPercent, intCategory)
        If decDiscountPer = 0 Then
            MessageBox.Show("This product does not receive discount. ", "Non-discounted product", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Return
        Else
            lblDiscountPercentage.Text = FormatPercent(decDiscountPer / 100)
        End If

        decDiscountedPrice = decPrice - (decPrice * (decDiscountPer / 100))
        lblDiscountedPrice.Text = FormatCurrency(decDiscountedPrice, 4)

        decTotal = decDiscountedPrice * intQuantity
        lblTotal.Text = FormatCurrency(decTotal)


        decSaving = (decPrice * intQuantity) - (decDiscountedPrice * intQuantity)
        lblSavingAmount.Text = FormatCurrency(decSaving)
    End Sub


    'Function to find the price
    Function FindPrice(ByVal decListPriceArray(,) As Double, ByVal intIntemNumber As Integer) As Decimal
        Dim i As Integer
        Dim decPrice As Decimal

        For i = 0 To decListPriceArray.GetUpperBound(0)

            If decListPriceArray(i, 0) = intIntemNumber Then
                decPrice = decListPriceArray(i, 1)
            End If

        Next

        Return decPrice

    End Function
    'Function to find the category
    Function FindDiscountCategory(ByVal intCategoryCategory(,) As Integer, ByVal intIntemNumber As Integer) As Decimal
        Dim i As Integer
        Dim intCategory As Integer

        For i = 0 To intCategoryCategory.GetUpperBound(0)

            If intCategoryCategory(i, 0) = intIntemNumber Then
                intCategory = intCategoryCategory(i, 1)
            End If

        Next

        Return intCategory
    End Function
    'Function to find discount percentage. 
    Function FindDiscountPercentage(ByVal decDiscountPercent(,) As Integer, ByVal intCategory As Integer) As Decimal
        Dim i As Integer
        Dim decDiscountPer As Decimal

        For i = 0 To decDiscountPercent.GetUpperBound(0)

            If decDiscountPercent(i, 0) = intCategory Then
                decDiscountPer = decDiscountPercent(i, 1)
            End If

        Next

        Return decDiscountPer
    End Function
End Class
