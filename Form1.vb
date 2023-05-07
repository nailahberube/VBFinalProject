Public Class frmLavishNails
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'These occur when the user clicks the calucate button 
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDsicount As Decimal = 5D
        Dim decRewardPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strRewardPoints As String = ""
        Dim intRewardPoints As Integer
        Dim decTip = 15D

        'Is entry numeric? Yes, we'll convert value
        If IsNumeric(txtRewardPoints.Text) Then
            intRewardPoints = Convert.ToInt32(txtRewardPoints.Text)
            strRewardPoints = " after discount of " & intRewardPoints.ToString() & " reward points."

            'What the user checked and how much it costs 
            If radManicure.Checked Then
                decCost = 10D
                strOrder = "Maicure"
            ElseIf radPedicure.Checked Then
                decCost = 10D
                strOrder = "Pedicure"
            ElseIf radManiAndPedi.Checked Then
                decCost = 25D
                strOrder = "Manicure and Pedicure"
            ElseIf radManiAndDesign.Checked Then
                decCost = 20D
                strOrder = "Manicure and Design"
            ElseIf radPediAndDesign.Checked Then
                decCost = 20D
                strOrder = "Pedicure and Design"
            ElseIf radManiPediAndDesign.Checked Then
                decCost = 38D
                strOrder = "Manicure, Pedicure, and Design"
            End If
            'Algorithm to calculate our discount 
            intRewardPoints = Convert.ToInt32(intRewardPoints / 10)
            MsgBox(intRewardPoints)

            decRewardPoints = (intRewardPoints * cdecDsicount) / 100
            MsgBox(decRewardPoints)

            If decRewardPoints > 1 Then
                decRewardPoints = 1
            End If

            MsgBox(decRewardPoints)
            'Final discount is the cost times the discount amount plus tip 
            decFinal = decCost * (1 - decRewardPoints) + decTip
            MsgBox(decFinal)
            'Label output
            lblTotal.Text = "Your final " & strOrder & " services costs " & decFinal.ToString("C") & strPay & strRewardPoints

            'Error handler telling the user to input valid number 
        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            ' Returns to original state 
            Me.btnClear.PerformClick()


        End If

    End Sub

    Private Sub frmLavishNails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Calls our button clear 
        Me.btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears out the text box, the label and sets the radio button to orginal 
        txtRewardPoints.Text = ""
        txtRewardPoints.Focus()
        lblTotal.Text = ""
        radManicure.Checked = True
        radPedicure.Checked = False
        radManiAndPedi.Checked = False
        radManiAndDesign.Checked = False
        radPediAndDesign.Checked = False
        radManiPediAndDesign.Checked = False
        lblTotalPoints.Visible = True
        btnAddPoints.Enabled = True

    End Sub

    Private Sub btnAddPoints_Click(sender As Object, e As EventArgs) Handles btnAddPoints.Click
        'Declare and initialize varibles,these will be displayed in the input box
        Dim strRewardPoints As String
        Dim decRewardPoints As Decimal
        Dim decTotalPoints As Decimal
        Dim decAddedTotalPoints As Decimal = 0D
        Dim strInputMessage As String = "Enter the number of points per visit # "
        Dim stringInputHeading As String = "Total Points "
        Dim strNormalMessage As String = "Enter your points "
        Dim strNonNumericError As String = "Error - Enter a number "
        Dim strNegativeError As String = "Error - Enter a positve number "

        'Initialize loop variables

        'This is a place holder 
        Dim strCancelClicked As String = ""
        'This will tell the program how many times to loop
        Dim intMaxNumberOfEnteries As Integer = 5
        'This is our counter, what we use to increment every time we go through the loop 
        Dim intNumberOfEnteries As Integer = 1

        'Capture first value 
        strRewardPoints = InputBox(strInputMessage & intNumberOfEnteries, stringInputHeading, " ")

        'Loop until 5 reward point values are input or cancel 
        Do Until intNumberOfEnteries > intMaxNumberOfEnteries Or strRewardPoints = strCancelClicked
            'Is entry numeric? Yes, we'll convert it into a value 
            If IsNumeric(strRewardPoints) Then
                decRewardPoints = Convert.ToDecimal(strRewardPoints)

                'Check is value is positive, is the value greater than 0?
                If decRewardPoints > 0 Then
                    'Adding our entered points into total points 
                    decAddedTotalPoints += decRewardPoints
                    'Increments and prevents it from creating an infinite loop 
                    intNumberOfEnteries += 1
                    'Resetting the value in our input box 
                    strInputMessage = strNormalMessage
                Else
                    'Error handle that'll check if the user entered a negative value 
                    strInputMessage = strNegativeError
                End If

            Else
                ' Error handle that will check if the user entered a non numeric value 
                strInputMessage = strNonNumericError
            End If
            'Check if 5 values have been entered and captured next value 
            If intNumberOfEnteries <= intMaxNumberOfEnteries Then
                'Capture another total points value 
                strRewardPoints = InputBox(strInputMessage & intNumberOfEnteries, stringInputHeading, "")
            End If

        Loop

        'Add Total Reward Points  
        If intNumberOfEnteries > 1 Then
            'Makes the label visable 
            lblTotalPoints.Visible = True

            'Calculate Total Points 
            'This will loop 6 times so we had to minus 1 to ensure we get 5 
            decTotalPoints = decAddedTotalPoints + (intNumberOfEnteries - 6)
            'Display total cost
            ' decTotalPoints will convert into a string 
            lblTotalPoints.Text = "You have " & decTotalPoints.ToString("F1") & " total points."

        End If
        'They can only click button once 
        btnAddPoints.Enabled = False
    End Sub

End Class
