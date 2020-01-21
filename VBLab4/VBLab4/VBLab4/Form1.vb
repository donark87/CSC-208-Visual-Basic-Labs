'Donark Patel 
'CSC=208-58
'LAB 4
'The Ice Place POS program.
Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const dblRegularCone As Double = 1.25D
        Const dblWaffleCone As Double = 1.5
        Const dblSingleScoops As Double = 1.5
        Const dblDoubleScoops As Double = 1.75
        Const dblTripleScoops As Double = 2
        Const dblSprinkles As Double = 0.75
        Const dblChocolateChips As Double = 0.85
        Const dblHardShell As Double = 0.95

        Const dblRegularMilk As Double = 1.35
        Const dblLowFatMilk As Double = 1.45
        Const dblSmallMilkShake As Double = 1.5
        Const dblMediumMilkShake As Double = 2.5
        Const dblLargeMilkShake As Double = 3.5

        Const dblSmallIceCreamSoda As Double = 1.75
        Const dblMediumIceCreamSoda As Double = 2.75
        Const dblLargeIceCreamSoda As Double = 3.75
        Const dblExLargeIceCreamSoda As Double = 4.75
        Const dblWhippedCream As Double = 1
        Const dblCarmelSauce As Double = 1.25

        Const dblNoneDiscount As Double = 0
        Const dblStudentDiscount As Double = 0.1
        Const dblSeniorDiscount As Double = 0.05

        Const dblSalesTax As Double = 0.07 '7% sales tax 

        Dim intIceCreamConeQuantity As Integer
        Dim dblIceCreamConeSubtotal As Double

        Dim intMilkShakeQuantity As Integer
        Dim dblMilkShakeSubtotal As Double

        Dim intIceCreamSodaQuantity As Integer
        Dim dblIceCreamSodaSubtotal As Double

        Dim dblSubtotal As Double
        Dim dblDiscountAmount As Double
        Dim dblSubtotalAfterDiscount As Double
        Dim dblSalesTaxAmount As Double
        Dim dblFinalTotalDue As Double

        Try
            If txtIceCreamCone.Text Is String.Empty Then
                intIceCreamConeQuantity = 0
            Else intIceCreamConeQuantity = CInt(txtIceCreamCone.Text)
            End If



            If txtMilkShake.Text Is String.Empty Then
                intMilkShakeQuantity = 0
            Else intMilkShakeQuantity = CInt(txtMilkShake.Text)
            End If


            If txtIceCreamSoda.Text Is String.Empty Then
                intIceCreamSodaQuantity = 0
            Else intIceCreamSodaQuantity = CInt(txtIceCreamSoda.Text)
            End If

        Catch
            MessageBox.Show("Error : Be sure to enter nonzero and numeric vales in Quantity", "Error - Catch")
            Return
        End Try


        If intIceCreamConeQuantity < 0 Then
            MessageBox.Show("Error : Be sure to enter nonzero and numeric vales in Quantity", "Error - IC < 0")
            intIceCreamConeQuantity = 0
            Return
        End If

        If intMilkShakeQuantity < 0 Then
            MessageBox.Show("Error : Be sure to enter nonzero and numeric vales in Quantity", "Error - MS < 0")
            intMilkShakeQuantity = 0
            Return
        End If

        If intIceCreamSodaQuantity < 0 Then
            MessageBox.Show("Error : Be sure to enter nonzero and numeric vales in Quantity", "Error - ICS < 0")
            intIceCreamSodaQuantity = 0
            Return
        End If

        If rdbRegularCone.Checked = False And rdbWaffleCone.Checked = False And intIceCreamConeQuantity <> 0 Then
            MessageBox.Show("Error : Please, select a type of Cone", "Error - Type of Cone")
            Return
        ElseIf rdbSingleScoops.Checked = False And rdbDoubleScoops.Checked = False And rdbTripleScoops.Checked = False And intIceCreamConeQuantity <> 0 Then
            MessageBox.Show("Error : Please, select number of Scoops you want", "Error - Number of Scoops")
            Return
        ElseIf rdbRegularMilk.Checked = False And rdbLowFatMilk.Checked = False And intMilkShakeQuantity <> 0 Then
            MessageBox.Show("Error : Please, select a type of Milk", "Error - Type of Milk")
            Return
        ElseIf rdbSmallMilkShake.Checked = False And rdbMediumMilkShake.Checked = False And rdbLargeMilkShake.Checked = False And intMilkShakeQuantity <> 0 Then
            MessageBox.Show("Error : Please, select the size of Milk Shake", "Error - Size of Milk Shake")
            Return
        ElseIf rdbSmallIceCreamSoda.Checked = False And rdbMediumIceCreamSoda.Checked = False And rdbLargeIceCreamSoda.Checked = False And rdbExLargeIceCreamSoda.Checked = False And intIceCreamSodaQuantity <> 0 Then
            MessageBox.Show("Error : Please, select the size of Ice Cream Soda", "Error - Size of Ice Cream Soda")
            Return
        End If

        If rdbRegularCone.Checked = True Then
            dblIceCreamConeSubtotal = intIceCreamConeQuantity * dblRegularCone
        ElseIf rdbWaffleCone.Checked = True Then
            dblIceCreamConeSubtotal = intIceCreamConeQuantity * dblWaffleCone
        End If

        If rdbSingleScoops.Checked = True Then
            dblIceCreamConeSubtotal += intIceCreamConeQuantity * dblSingleScoops
        ElseIf rdbDoubleScoops.Checked = True Then
            dblIceCreamConeSubtotal += intIceCreamConeQuantity * dblDoubleScoops
        ElseIf rdbTripleScoops.Checked = True Then
            dblIceCreamConeSubtotal += intIceCreamConeQuantity * dblTripleScoops
        End If

        If chkSprinkles.Checked = True Then
            dblIceCreamConeSubtotal += intIceCreamConeQuantity * dblSprinkles
        End If
        If chkChocolateChips.Checked = True Then
            dblIceCreamConeSubtotal += intIceCreamConeQuantity * dblChocolateChips
        End If
        If chkHardShell.Checked = True Then
            dblIceCreamConeSubtotal += intIceCreamConeQuantity * dblHardShell
        End If

        lblIceCreamCone.Text = FormatCurrency(dblIceCreamConeSubtotal)


        If rdbRegularMilk.Checked = True Then
            dblMilkShakeSubtotal = intMilkShakeQuantity * dblRegularMilk
        ElseIf rdbLowFatMilk.Checked = True Then
            dblMilkShakeSubtotal = intMilkShakeQuantity * dblLowFatMilk
        End If
        If rdbSmallMilkShake.Checked = True Then
            dblMilkShakeSubtotal += intMilkShakeQuantity * dblSmallMilkShake
        ElseIf rdbMediumMilkShake.Checked = True Then
            dblMilkShakeSubtotal += intMilkShakeQuantity * dblMediumMilkShake
        ElseIf rdbLargeMilkShake.Checked = True Then
            dblMilkShakeSubtotal += intMilkShakeQuantity * dblLargeMilkShake
        End If


        lblMilkShake.Text = FormatCurrency(dblMilkShakeSubtotal)


        If rdbSmallIceCreamSoda.Checked Then
            dblIceCreamSodaSubtotal = intIceCreamSodaQuantity * dblSmallIceCreamSoda
        ElseIf rdbMediumIceCreamSoda.Checked Then
            dblIceCreamSodaSubtotal = intIceCreamSodaQuantity * dblMediumIceCreamSoda
        ElseIf rdbLargeIceCreamSoda.Checked Then
            dblIceCreamSodaSubtotal = intIceCreamSodaQuantity * dblLargeIceCreamSoda
        ElseIf rdbExLargeIceCreamSoda.Checked Then
            dblIceCreamSodaSubtotal = intIceCreamSodaQuantity * dblExLargeIceCreamSoda
        End If

        If chkWhippedCream.Checked Then
            dblIceCreamSodaSubtotal += intIceCreamSodaQuantity * dblWhippedCream
        End If
        If chkCarmelSauce.Checked Then
            dblIceCreamSodaSubtotal += intIceCreamSodaQuantity * dblCarmelSauce
        End If

        lblIceCreamSoda.Text = FormatCurrency(dblIceCreamSodaSubtotal)

        dblSubtotal = dblIceCreamConeSubtotal + dblMilkShakeSubtotal + dblIceCreamSodaSubtotal
        lblSubtotal.Text = FormatCurrency(dblSubtotal)

        If rdbNoneDiscount.Checked = False And rdbStudentDiscount.Checked = False And rdbSeniorDiscount.Checked = False And dblSubtotal > 0 Then
            MessageBox.Show("Error : Please, select a type Discount", "Error - Type of Discount")
        End If

        If rdbNoneDiscount.Checked Then
            dblDiscountAmount = dblNoneDiscount
        ElseIf rdbStudentDiscount.Checked Then
            dblDiscountAmount = dblSubtotal * dblStudentDiscount
        ElseIf rdbSeniorDiscount.Checked Then
            dblDiscountAmount = dblSubtotal * dblSeniorDiscount
        End If
        lblDiscountAmount.Text = FormatCurrency(dblDiscountAmount)


        dblSubtotalAfterDiscount = dblSubtotal - dblDiscountAmount
        lblSubtotalAfterDiscount.Text = FormatCurrency(dblSubtotalAfterDiscount)

        dblSalesTaxAmount = dblSubtotalAfterDiscount * dblSalesTax
        lblSalesTaxAmount.Text = FormatCurrency(dblSalesTaxAmount)

        dblFinalTotalDue = dblSubtotalAfterDiscount + dblSalesTaxAmount
        lblFinalTotalDue.Text = FormatCurrency(dblFinalTotalDue)


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIceCreamCone.Clear()
        txtIceCreamSoda.Clear()
        txtMilkShake.Clear()

        lblDiscountAmount.Text = String.Empty
        lblFinalTotalDue.Text = String.Empty
        lblIceCreamCone.Text = String.Empty
        lblSalesTaxAmount.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblFinalTotalDue.Text = String.Empty
        lblIceCreamSoda.Text = String.Empty
        lblMilkShake.Text = String.Empty
        lblSubtotalAfterDiscount.Text = String.Empty

        rdbRegularCone.Checked = False
        rdbWaffleCone.Checked = False

        rdbSingleScoops.Checked = False
        rdbDoubleScoops.Checked = False
        rdbTripleScoops.Checked = False

        chkSprinkles.Checked = False
        chkChocolateChips.Checked = False
        chkHardShell.Checked = False

        rdbRegularMilk.Checked = False
        rdbLowFatMilk.Checked = False

        rdbSmallMilkShake.Checked = False
        rdbMediumMilkShake.Checked = False
        rdbLargeMilkShake.Checked = False


        rdbSmallIceCreamSoda.Checked = False
        rdbMediumIceCreamSoda.Checked = False
        rdbLargeIceCreamSoda.Checked = False
        rdbExLargeIceCreamSoda.Checked = False

        chkWhippedCream.Checked = False
        chkCarmelSauce.Checked = False

        rdbNoneDiscount.Checked = False
        rdbStudentDiscount.Checked = False
        rdbSeniorDiscount.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateTime.Text = Now.ToString("D") & " " & Now.ToString("T")
    End Sub
End Class
