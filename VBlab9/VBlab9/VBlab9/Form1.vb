'Donark Patel 
'CSC-208-58
'Date- 4/14/2018
'Lab - 9
'This application create a report of customer's bill. 

Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Public Class Form1
    Private DataTextFieldParase As TextFieldParser
    Dim decBillAmountTotal As Decimal = 0
    Dim decDicountTotal As Decimal = 0
    Dim decLateFeesTotal As Decimal = 0
    Dim decNewBillAmountTotal As Decimal = 0

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Dim intCustomerId As Integer
        Dim strFirstName As String
        Dim chrMiddlename As Char
        Dim strLastName As String
        Dim bytCustomerStatus As Byte
        Dim dblBillAmount As Double

        Try


            If txtCustomerID.Text Is String.Empty Then
                MessageBox.Show("Error: Missing Customer ID, Please,enter Customer ID")
                Return
            Else
                intCustomerId = CInt(txtCustomerID.Text)
                If intCustomerId <= 999 Or intCustomerId >= 10000 Then
                    MessageBox.Show("Error: Invalid Customer ID, Pleae, enter 4 digit customer ID. You have entered: " & intCustomerId, "Invalid Customer ID")
                    txtCustomerID.Focus()
                    txtCustomerID.Clear()
                    Return
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Invalid Customer ID,  Pleae, enter 4 digit customer ID. You have entered: " & txtCustomerID.Text)
            Return
        End Try
        'Validating First Name Textbox
        If txtFirstName Is String.Empty Then
            MessageBox.Show("Error:Missing customer first name. Please, enter customer first name", "Error: Missing name")
            Return
        ElseIf IsNumeric(txtFirstName.Text) Then
            MessageBox.Show("Error: Customer first name is numaric. Please, enter correct first name. You have entered: " & txtFirstName.Text)
            txtFirstName.Focus()
            txtFirstName.Clear()
            Return
        ElseIf txtFirstName.Text.Trim = "" Then
            MessageBox.Show("Error: Missing customer first name. Please, enter customer first name", "Error: Customer Name-Space")
            txtFirstName.Focus()
            txtFirstName.Clear()
            Return
        Else
            strFirstName = CStr(txtFirstName.Text)
        End If

        'Validating Middle initial Textbox
        If txtMiddleName Is String.Empty Then
            MessageBox.Show("Error: Missing customer middle initial. Please, enter customer middle initial", "Error: Missing middle initial")
            Return
        ElseIf IsNumeric(txtMiddleName.Text) Then
            MessageBox.Show("Error: Customer middle initial is numaric. Please, enter correct middles initial. You have entered: " & txtMiddleName.Text)
            txtMiddleName.Focus()
            txtMiddleName.Clear()
            Return
        ElseIf txtMiddleName.Text.Trim = "" Then
            MessageBox.Show("Error: Missing customer middle initial. Please, enter customer middle initial", "Error: Customer middle initial-Space")
            txtMiddleName.Focus()
            txtMiddleName.Clear()
            Return
        Else
            chrMiddlename = CChar(txtMiddleName.Text)
        End If

        'Validating Last Name Textbox
        If txtLastName Is String.Empty Then
            MessageBox.Show("Error: Missing customer last name. Please, enter customer last name", "Error: Missing Last name")
            Return
        ElseIf IsNumeric(txtLastName.Text) Then
            MessageBox.Show("Error: Customer lastname is numaric. Please, enter correct first name. You have entered: " & txtLastName.Text)
            txtLastName.Focus()
            txtLastName.Clear()
            Return
        ElseIf txtLastName.Text.Trim = "" Then
            MessageBox.Show("Error: Missing customer last name. Please, enter customer last name", "Error: Customer last Name-Space")
            txtLastName.Focus()
            txtLastName.Clear()
            Return
        Else
            strLastName = CStr(txtLastName.Text)
        End If
        'Validating Customer Status text box 
        If txtCustomerStatus Is String.Empty Then
            MessageBox.Show("Error: Missing customer status. Please, enter customer status number", "Missing: Customer Status Number")
            Return
        ElseIf txtCustomerStatus.Text.Trim = "" Then
            MessageBox.Show("Error: Missing customer status. Please, enter customer status number", "Missing: Customer Status Number-Space")
            txtCustomerStatus.Focus()
            txtCustomerStatus.Clear()
            Return
        End If
        Try
            bytCustomerStatus = CByte(txtCustomerStatus.Text)
        Catch ex As Exception
            MessageBox.Show("Error: Invalid entry for Customer Status. You have entered: " & txtCustomerStatus.Text, "Error: Customer_status-Catch")
            txtCustomerStatus.Focus()
            txtCustomerStatus.Clear()
            Return
        End Try
        If bytCustomerStatus < 0 Or bytCustomerStatus >= 3 Then
            MessageBox.Show("Error: Invalid entry for Customer Status. Please, enter number between  0 to 2. You have entered: " & bytCustomerStatus, "Error:Invalid Entry-CustomerStatus")
            txtCustomerStatus.Focus()
            txtCustomerStatus.Clear()
            Return
        End If
        'Validating Bill Amount text box. 
        If txtBillAmount Is String.Empty Then
            MessageBox.Show("Error: Missing bill amount. please, enter bill amount", "Error: Missing bill amount")
            txtBillAmount.Focus()
            Return
        ElseIf txtBillAmount.Text.Trim = "" Then
            MessageBox.Show("Error: Missing bill amount. please, enter bill amount", "Error: Missing bill amount-Space")
            txtBillAmount.Focus()
            txtBillAmount.Clear()
            Return
        End If
        Try
            dblBillAmount = CDbl(txtBillAmount.Text)
            If dblBillAmount <= 0 Then
                MessageBox.Show("Error: Invalid billing amount, Please, enter non-zero positve number. You have entered: " & dblBillAmount, "Error: Invalid billing amount")
                txtBillAmount.Focus()
                txtBillAmount.Clear()
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Invalid billing amount, Please, enter non-zero positve number. You have entered: " & txtBillAmount.Text, "Error: Invalid billing amount")
            txtBillAmount.Focus()
            txtBillAmount.Clear()
            Return
        End Try
        'Input data to a file. 
        Dim FileString As String = "customer.txt"
        Dim RecordString As String = intCustomerId & "," & strFirstName & "," & chrMiddlename & "," &
            strLastName & "," & bytCustomerStatus & "," & dblBillAmount & vbCrLf
        My.Computer.FileSystem.WriteAllText(FileString, RecordString, True)

        'Clearing all text box and focus back to customer ID 
        txtCustomerID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtCustomerStatus.Clear()
        txtBillAmount.Clear()
        txtCustomerID.Focus()



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing all text box
        txtCustomerID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtCustomerStatus.Clear()
        txtBillAmount.Clear()

    End Sub

    Private Sub btnDisplayRecord_Click(sender As Object, e As EventArgs) Handles btnDisplayRecord.Click
        Dim DataTextFieldParase As TextFieldParser
        Dim FileString As String = "customer.txt"
        Dim FileStringArray() As String
        Dim FileStringReport As String = "DiscountReport.txt"
        Dim intCustomerId As Integer
        Dim strFirstName As String
        Dim chrMiddlename As Char
        Dim strLastName As String
        Dim bytCustomerStatus As Byte
        Dim dblBillAmount As Double
        Dim RecordString As String
        Dim decDiscountPer As Decimal
        Dim decDiscountAmount As Decimal
        Dim decLateFees As Decimal
        Dim decNewBillAmount As Decimal
        'Array
        Dim dblBillStatusArray(,) = {{0, 0.1, 00.00},
                                   {1, 0.05, 10.0},
                                   {2, 00.00, 20.0}}
        'Printinh heading to output file.
        RecordString = "                                            CUSTOMER DISCOUNT REPORT AS OF: " & Now.ToString("D") & vbCrLf &
                       "                                                    Created by: Donark Patel                                                                     " & vbCrLf &
                       "_________________________________________________________________________________________________________________________________________________" & vbCrLf &
                       "Customer        First        Middle     Last        Customer        Bill Amount       Discount        Discount        Late Pay         New Bill  " & vbCrLf &
                       "ID              Name         Initial    Name         Status        From In File      % Eligible        Amount           Fee             Amount   " & vbCrLf
        My.Computer.FileSystem.WriteAllText(FileStringReport, RecordString, True)
        'Reading and Parsing the input data
        Try

            DataTextFieldParase = New TextFieldParser(FileString)
            DataTextFieldParase.TextFieldType = FieldType.Delimited
            DataTextFieldParase.SetDelimiters(",")

        Catch ex As Exception
            MessageBox.Show("Unable to read the file: " & FileString, "File Error")
        End Try
        'Loop to read all the input data.
        If Not DataTextFieldParase.EndOfData Then
            Do
                FileStringArray = DataTextFieldParase.ReadFields()

                'Assaning the data to a varibale for FileStringArray
                intCustomerId = CInt(FileStringArray(0))
                strFirstName = CStr(FileStringArray(1))
                chrMiddlename = CChar(FileStringArray(2))
                strLastName = CStr(FileStringArray(3))
                bytCustomerStatus = CByte(FileStringArray(4))
                dblBillAmount = CDbl(FileStringArray(5))

                'Calculating all the filds 
                decBillAmountTotal += dblBillAmount
                decDiscountPer = FindDiscountPer(dblBillStatusArray, bytCustomerStatus)
                decDiscountAmount = (dblBillAmount * decDiscountPer)
                decDicountTotal += decDiscountAmount
                decLateFees = FindLateFees(dblBillStatusArray, bytCustomerStatus, decDiscountPer)
                decLateFeesTotal += decLateFees
                decNewBillAmount = (dblBillAmount - decDiscountAmount) + decLateFees
                decNewBillAmountTotal += decNewBillAmount

                'Output the data to a file. 
                RecordString = intCustomerId & vbTab & vbTab & strFirstName & vbTab & vbTab & chrMiddlename & vbTab & strLastName & vbTab & vbTab & bytCustomerStatus & vbTab & vbTab & FormatNumber(dblBillAmount, 2) & vbTab & vbTab & FormatNumber(decDiscountPer, 2) & vbTab & vbTab & FormatNumber(decDiscountAmount, 2) & vbTab & vbTab & FormatNumber(decLateFees, 2) & vbTab & vbTab & FormatNumber(decNewBillAmount, 2) & vbCrLf
                My.Computer.FileSystem.WriteAllText(FileStringReport, RecordString, True)
            Loop Until DataTextFieldParase.EndOfData

            RecordString = "_________________________________________________________________________________________________________________________________________________" & vbCrLf &
                                 "TOTAL:  " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & FormatNumber(decBillAmountTotal, 2) & vbTab & vbTab & vbTab & FormatNumber(decDicountTotal, 2) & vbTab & vbTab & FormatNumber(decLateFeesTotal, 2) & vbTab & vbTab & FormatNumber(decNewBillAmountTotal, 2) & vbCrLf &
                                 "_________________________________________________________________________________________________________________________________________________" & vbCrLf

            My.Computer.FileSystem.WriteAllText(FileStringReport, RecordString, True)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Function to find Discount Percentage from  a Array
    Function FindDiscountPer(ByVal dblBillStatusArray(,) As Double, ByVal bytCustomerStatus As Byte) As Double
        Dim i As Integer
        Dim decDiscountPer As Decimal
        For i = 0 To dblBillStatusArray.GetUpperBound(0)

            If dblBillStatusArray(i, 0) = bytCustomerStatus Then
                decDiscountPer = dblBillStatusArray(i, 1)
            End If
        Next
        Return decDiscountPer
    End Function
    'Function to find a late fees amount from a array
    Function FindLateFees(ByVal dblBillStatusArray(,) As Double, ByVal bytCustomerStatus As Byte, decDiscountPer As Decimal) As Double
        Dim i As Integer
        Dim decLateFees As Decimal
        For i = 0 To dblBillStatusArray.GetUpperBound(0)

            If dblBillStatusArray(i, 0) = bytCustomerStatus Then
                decLateFees = dblBillStatusArray(i, 2)
            End If
        Next
        Return decLateFees
    End Function

    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click
        pddPrintDualog.ShowDialog()
        pdPrint.Print()

    End Sub

    Public strReportFile As String = "DiscountReport.txt"

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        Dim inputFile As StreamReader
        Dim intX As Integer = 5
        Dim intY As Integer = 5

        Try
            inputFile = File.OpenText("DiscountReport.txt")
            Do While Not inputFile.EndOfStream
                e.Graphics.DrawString(inputFile.ReadLine(), New Font("Consolas", 11, FontStyle.Regular), Brushes.Black, intX, intY)
                intY += 12
            Loop
            inputFile.Close()
        Catch ex As Exception
            MessageBox.Show("Error: Cannot find the file.")
        End Try


    End Sub
End Class
