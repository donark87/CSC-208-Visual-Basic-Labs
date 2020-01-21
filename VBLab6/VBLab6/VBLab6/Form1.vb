'Donark Patel
'CSC-208-01
'Date: 3/6/2018
'This application will calculate total tution and fess of mutipal students. 
Public Class Form1
    Function FullTimeOrPartTime(ByVal intCreditHours As Integer) As String
        Dim strTime As String
        If intCreditHours >= 0 And intCreditHours < 12 Then
            strTime = "Part"
            intPartTime = 1 + intPartTime
            intStudent = 1 + intStudent
        ElseIf intCreditHours >= 12 Then
            strTime = "Full"
            intFullTime = 1 + intFullTime
            intStudent = 1 + intStudent
        End If
        Return strTime
    End Function
    Function GradOrUnderGrad(ByVal chrUnderOrGrad As Char) As String
        Dim strGradlevel As String
        If chrUnderOrGrad = "u" Or chrUnderOrGrad = "U" Then
            strGradlevel = "Und"
            intUndergard = 1 + intUndergard
        ElseIf chrUnderOrGrad = "g" Or chrUnderOrGrad = "G" Then
            strGradlevel = "Grad"
            intGrad = 1 + intGrad
        End If
        Return strGradlevel
    End Function
    Function TotalTuitionFeesUnd(ByVal intTUITIONUNDERGRAD As Integer, intCreditHours As Integer) As Integer
        TotalTuitionFeesUnd = intTUITIONUNDERGRAD * intCreditHours
        Return TotalTuitionFeesUnd
    End Function
    Function TotalGeneralFeesUnd(ByVal intGENERALUNDERGRAD As Integer, intCreditHours As Integer) As Integer
        TotalGeneralFeesUnd = intGENERALUNDERGRAD * intCreditHours
        Return TotalGeneralFeesUnd
    End Function


    Function TotalTuitionFeesGrad(ByVal intTUITIONGRAD As Integer, intCreditHours As Integer) As Integer
        TotalTuitionFeesGrad = intTUITIONGRAD * intCreditHours
        Return TotalTuitionFeesGrad
    End Function
    Function TotalGeneralFeesGrad(ByVal intGENERALGRAD As Integer, intCreditHours As Integer) As Integer
        TotalGeneralFeesGrad = intGENERALGRAD * intCreditHours
        Return TotalGeneralFeesGrad
    End Function





    Function TotalTuition(ByVal intTotalTuition As Integer, intTotalTuitionFees As Integer) As Integer
        TotalTuition = intTotalTuition + intTotalTuitionFees
        Return TotalTuition
    End Function
    Function TotalGeneral(ByVal intTotalGeneral As Integer, intTotalGeneralFees As Integer) As Integer
        TotalGeneral = intTotalGeneral + intTotalGeneralFees
        Return TotalGeneral
    End Function

    Function TotalTechFeesPart(ByVal intTECHPART As Integer, intCreditHours As Integer) As Integer
        TotalTechFeesPart = intTECHPART * intCreditHours
        Return TotalTechFeesPart
    End Function
    Function TotalTechFeesFull(ByVal intTECHFULL As Integer, intCreditHours As Integer) As Integer
        TotalTechFeesFull = intTECHFULL * intCreditHours
        Return TotalTechFeesFull
    End Function
    Function TotalTech(ByVal intTotalTech As Integer, intTotalTechFees As Integer) As Integer
        TotalTech = intTotalTech + intTotalTechFees
        Return TotalTech
    End Function
    Function TotalFees(ByVal intTotalGeneralFees As Integer, intTotalTechFees As Integer) As Integer
        TotalFees = intTotalGeneralFees + intTotalTechFees
        Return TotalFees
    End Function
    Function TotalFeesCombined(ByVal intTotalFeesCombined As Integer, intTotalFees As Integer) As Integer
        TotalFeesCombined = intTotalFeesCombined + intTotalFees
        Return TotalFeesCombined
    End Function
    Function TotalTuitionAndFees(ByVal intTotalTuitionFees As Integer, intTotalFees As Integer) As Integer
        TotalTuitionAndFees = intTotalTuitionFees + intTotalFees
        Return TotalTuitionAndFees
    End Function
    Function TotalTuitionAndFeesCombined(ByVal intTotalTuitionAndFeesCombined As Integer, intTotalTuitionAndFees As Integer) As Integer
        TotalTuitionAndFeesCombined = intTotalTuitionAndFeesCombined + intTotalTuitionAndFees
        Return TotalTuitionAndFeesCombined
    End Function
    Dim intPartTime As Integer
    Dim intFullTime As Integer
    Dim intUndergard As Integer
    Dim intGrad As Integer
    Dim intStudent As Integer
    Dim intTotalTuition As Integer
    Dim intTotalGeneral As Integer
    Dim intTotalTech As Integer
    Dim intTotalFeesCombined As Integer
    Dim intTotalTuitionAndFeesCombined As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOutput.Items.Add("Student Name" & vbTab & vbTab & "Credit" & vbTab & "Under" & vbTab & "Part or" & vbTab & "Tuition"  & vbTab & "General" & vbTab & "Tech" & vbTab & "Total" & vbTab & "Tuition")
        lstOutput.Items.Add("Name" & vbTab & vbTab & vbTab & "Hours" & vbTab & "Or Grad" & vbTab & "Full" & vbTab & "Cost" & vbTab & "Fee" & vbTab & "Fee" & vbTab & "Fees" & vbTab & "& Fees")
        lstOutput.Items.Add("______________________________________________________________________________________________________________________________")
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim strStudentName As String
        Dim intCreditHours As Integer
        Dim StrCreditHours As String
        Dim chrUnderOrGrad As Char
        Dim strTime As String
        Dim strGradlevel As String

        Dim intTotalTuitionFees As Integer
        Const intTUITIONUNDERGRAD As Integer = 100
        Const intTUITIONGRAD As Integer = 200

        Dim intTotalGeneralFees As Integer
        Const intGENERALUNDERGRAD As Integer = 10
        Const intGENERALGRAD As Integer = 20

        Dim intTotalTechFees As Integer
        Const intTECHPART As Integer = 5
        Const intTECHFULL As Integer = 15

        Dim intTotalFees As Integer
        Dim intTotalTuitionAndFees As Integer


        strStudentName = InputBox("What is the name of the student?")
        If strStudentName = String.Empty Then
            MessageBox.Show("Error: Please, enter student's name. You did not enter the name of the student")
            Return
        End If

        Try
            StrCreditHours = InputBox("How many credit hours " & strStudentName & " taken this semester?",)
            intCreditHours = CInt(StrCreditHours)

            If intCreditHours <= 0 Then
                MessageBox.Show("Error: Enter Non-zero numeric number. " & "You have entered: " & StrCreditHours, "< 0")
                Return
            End If
        Catch
            MessageBox.Show("Error: Enter Non-zero numeric number. " & "You have entered: " & StrCreditHours, "Catch")
            Return
        End Try

        Try
            chrUnderOrGrad = CChar(InputBox("Is the Student Graduate or Undergraduate? Enter 'U' for UnderGraduate, 'G' for Graduate"))
            If chrUnderOrGrad <> "u" And chrUnderOrGrad <> "U" And chrUnderOrGrad <> "g" And chrUnderOrGrad <> "G" Then
                MessageBox.Show("Error: Please, enter valid character for Undergraduate or Graduate student. " & "You have entered " & chrUnderOrGrad & " Instead of U or G")
                Return
            End If

        Catch
            MessageBox.Show("Error: Please, enter valid character for Undergraduate or Graduate student. " & "You have entered " & chrUnderOrGrad & " Instead of U or G", "Catch")
            Return
        End Try



        Do Until intCreditHours = 0 Or strStudentName = "Endit" Or chrUnderOrGrad = "A"

            strTime = FullTimeOrPartTime(intCreditHours)
            strGradlevel = GradOrUnderGrad(chrUnderOrGrad)


            If strGradlevel = "Und" Then
                intTotalTuitionFees = TotalTuitionFeesUnd(intTUITIONUNDERGRAD, intCreditHours)


                intTotalGeneralFees = TotalGeneralFeesUnd(intGENERALUNDERGRAD, intCreditHours)

                intTotalTuition = TotalTuition(intTotalTuition, intTotalTuitionFees)

                intTotalGeneral = TotalGeneral(intTotalGeneral, intTotalGeneralFees)

            ElseIf strGradlevel = "Grad" Then
                intTotalTuitionFees = TotalTuitionFeesGrad(intTUITIONGRAD, intCreditHours)

                intTotalGeneralFees = TotalGeneralFeesGrad(intGENERALGRAD, intCreditHours)

                intTotalTuition = TotalTuition(intTotalTuition, intTotalTuitionFees)

                intTotalGeneral = TotalGeneral(intTotalGeneral, intTotalGeneralFees)

            End If

            If strTime = "Part" Then
                intTotalTechFees = TotalTechFeesPart(intTECHPART, intCreditHours)

                intTotalTech = TotalTech(intTotalTech, intTotalTechFees)

            ElseIf strTime = "Full" Then
                intTotalTechFees = TotalTechFeesFull(intTECHFULL, intCreditHours)

                intTotalTech = TotalTech(intTotalTech, intTotalTechFees)

            End If
            intTotalFees = TotalFees(intTotalGeneralFees, intTotalTechFees)
            intTotalFeesCombined = TotalFeesCombined(intTotalFeesCombined, intTotalFees)
            intTotalTuitionAndFees = TotalTuitionAndFees(intTotalTuitionFees, intTotalFees)
            intTotalTuitionAndFeesCombined = TotalTuitionAndFeesCombined(intTotalTuitionAndFeesCombined, intTotalTuitionAndFees)




            lstOutput.Items.Add(strStudentName & vbTab & vbTab & intCreditHours & vbTab & strGradlevel & vbTab & strTime &
                                vbTab & FormatCurrency(intTotalTuitionFees) & vbTab & FormatCurrency(intTotalGeneralFees) & vbTab & FormatCurrency(intTotalTechFees) & vbTab &
                                  FormatCurrency(intTotalFees) & vbTab & FormatCurrency(intTotalTuitionAndFees))


            strStudentName = InputBox("What is the name of the student? Or Type Endit to cancel the loop")
            If strStudentName = "Endit" Then
                Exit Do
            End If
            If strStudentName = String.Empty Then
                MessageBox.Show("Error: Please, enter student's name. You did not enter the name of the student")
                Return
            End If

            Try
                intCreditHours = CInt(InputBox("How many credit hours " & strStudentName & " taken this semester? or Enter 0 to cancel the loop",))
                If intCreditHours < 0 Then
                    MessageBox.Show("Error: Enter Non-zero numeric number. " & "You have entered: " & intCreditHours, "< 0")
                ElseIf intCreditHours = 0 Then
                    Exit Do
                    Return
                End If
            Catch
                MessageBox.Show("Error: Enter Non-zero numeric number. " & "You have entered: " & intCreditHours, "Catch")
                Return
            End Try

            Try
                chrUnderOrGrad = CChar(InputBox("Is the Student Graduate or Undergraduate? Enter 'U' for UnderGraduate, 'G' for Graduate"))

                If chrUnderOrGrad <> "u" And chrUnderOrGrad <> "U" And chrUnderOrGrad <> "g" And chrUnderOrGrad <> "G" Then
                    MessageBox.Show("Error: Please, enter valid character for Undergraduate or Graduate student. " & "You have entered " & chrUnderOrGrad & " Instead of U or G")
                    Return
                End If

            Catch
                MessageBox.Show("Error: Please, enter valid character for Undergraduate or Graduate student. " & "You have entered " & chrUnderOrGrad & " Instead of U or G")
                Return
            End Try
        Loop
        lstOutput.Items.Add("")
        lstOutput.Items.Add("Total number of part time students:         " & intPartTime)

        lstOutput.Items.Add("Total number of full time students:          " & intFullTime)

        lstOutput.Items.Add("Total number of underguate students:    " & intUndergard)

        lstOutput.Items.Add("Total number of graduate students:        " & intGrad)

        lstOutput.Items.Add("Total numbers of students:                     " & intStudent)
        lstOutput.Items.Add("Total tuition costs: " & vbTab & vbTab & vbTab & vbTab & vbTab & FormatCurrency(intTotalTuition))
        lstOutput.Items.Add("Total general fees: " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & FormatCurrency(intTotalGeneral))
        lstOutput.Items.Add("Total technology fees: " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & FormatCurrency(intTotalTech))
        lstOutput.Items.Add("Total fees combined costs: " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & FormatCurrency(intTotalFeesCombined))
        lstOutput.Items.Add("Total of tuition and fees combined costs: " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & FormatCurrency(intTotalTuitionAndFeesCombined))

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
