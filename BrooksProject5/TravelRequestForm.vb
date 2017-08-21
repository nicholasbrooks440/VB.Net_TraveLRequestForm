Public Class TravelRequestForm
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        'Clear
        firstNameTextBox.Clear()
        lastNameTextBox.Clear()
        purposeTextBox.Clear()
        startDateTextBox.Clear()
        endDateTextBox.Clear()
        requestedAmountTextBox.Clear()
        exceptionLabel.Text = ""

        'Verify exit
        If MessageBox.Show("Do you want to close this form?", "Close Form?", MessageBoxButtons.YesNo) =
            DialogResult.Yes Then
            'exit app
            Me.Close()
        Else
            'return back to app
            Return
        End If
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        ' exception label
        exceptionLabel.Text = "Validating data ..."

        Try

            'First Name Check''''''''''''''''''''''''''''

            If (String.IsNullOrEmpty(firstNameTextBox.Text)) Then
                Throw New InputBlankException(firstNameTextBox.Name.ToString + " Cannot be blank")
            End If
            'Last Name Check''''''''''''''''''''''''''''

            If (String.IsNullOrEmpty(lastNameTextBox.Text)) Then
                Throw New InputBlankException(lastNameTextBox.Name.ToString + " Cannot be blank")
            End If
            'Purpose Check''''''''''''''''''''''''''''''''

            If (String.IsNullOrEmpty(purposeTextBox.Text)) Then
                Throw New InputBlankException(purposeTextBox.Name.ToString + " Cannot be blank")
            End If
            'Start Date Check''''''''''''''''''''''''''

            'check for null
            If (String.IsNullOrEmpty(startDateTextBox.Text)) Then
                Throw New InputBlankException(startDateTextBox.Name.ToString + " Cannot be blank")
            End If

            'Try parse
            Dim sDate As Date
            If ((Date.TryParse(startDateTextBox.Text, sDate)) = False) Then
                Throw New FormatException(startDateTextBox.Name.ToString + " has invalid date format")
            End If
            sDate = startDateTextBox.Text
            'Check date
            If sDate < DateTime.Today Then
                'throw custom exception
                Throw New StartsInPastException
            End If

            'End Date Check''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'check for null
            If (String.IsNullOrEmpty(endDateTextBox.Text)) Then
                Throw New InputBlankException(endDateTextBox.Name.ToString + " Cannot be blank")
            End If

            'Try parse
            Dim eDate As Date
            If ((Date.TryParse(endDateTextBox.Text, eDate)) = False) Then
                Throw New FormatException(endDateTextBox.Name.ToString + " has invalid date format")
            End If

            eDate = endDateTextBox.Text
            'Check date
            If eDate < sDate Then
                'throw custom exception
                Throw New EndsBeforeStartException
            End If

            'Requested Amount Check''''''''''''''''''''''''''
            'check for null
            If (String.IsNullOrEmpty(requestedAmountTextBox.Text)) Then
                Throw New InputBlankException(requestedAmountTextBox.Name.ToString + " Cannot be blank")
            End If

            'Try parse
            Dim amt As Double
            If ((Double.TryParse(requestedAmountTextBox.Text, amt)) = False) Then
                Throw New FormatException(requestedAmountTextBox.Name.ToString + " has invalid format")
            End If
            'Check for positive
            If amt <= 0 Then
                'throw custom exception
                Throw New NonPositiveAmountException
            End If

            'Update label
            exceptionLabel.Text = "All Data Is valid"

            'End of Try Block

        Catch ex As InputBlankException
            exceptionLabel.Text = ex.Message

        Catch ex As StartsInPastException
            exceptionLabel.Text = ex.Message

        Catch ex As EndsBeforeStartException
            exceptionLabel.Text = ex.Message

        Catch ex As NonPositiveAmountException
            exceptionLabel.Text = ex.Message

        Catch ex As FormatException
            exceptionLabel.Text = ex.Message

        End Try

    End Sub
End Class

'Custom Exceptions
Public Class StartsInPastException
    Inherits Exception

    'Default constructor
    Public Sub New()
        MyBase.New("Start Date cannot be in the past")
    End Sub

    'Constructor for customizing error message
    Public Sub New(messageValue As String)
        MyBase.New(messageValue)
    End Sub

    'Constructor for customizing the exception's error
    'message and specifying the InnerException Object
    Public Sub New(messageValue As String, inner As Exception)
        MyBase.New(messageValue, inner)
    End Sub

End Class

Public Class InputBlankException
    Inherits Exception

    'Default constructor
    Public Sub New()
        MyBase.New("Input cannot be blank")
    End Sub

    'Constructor for customizing error message
    Public Sub New(messageValue As String)
        MyBase.New(messageValue)
    End Sub

    'Constructor for customizing the exception's error
    'message and specifying the InnerException Object
    Public Sub New(messageValue As String, inner As Exception)
        MyBase.New(messageValue, inner)
    End Sub

End Class

Public Class EndsBeforeStartException
    Inherits Exception

    'Default constructor
    Public Sub New()
        MyBase.New("End date cannot be before start date")
    End Sub

    'Constructor for customizing error message
    Public Sub New(messageValue As String)
        MyBase.New(messageValue)
    End Sub

    'Constructor for customizing the exception's error
    'message and specifying the InnerException Object
    Public Sub New(messageValue As String, inner As Exception)
        MyBase.New(messageValue, inner)
    End Sub

End Class

Public Class NonPositiveAmountException
    Inherits Exception

    'Default constructor
    Public Sub New()
        MyBase.New("Number must be positive")
    End Sub

    'Constructor for customizing error message
    Public Sub New(messageValue As String)
        MyBase.New(messageValue)
    End Sub

    'Constructor for customizing the exception's error
    'message and specifying the InnerException Object
    Public Sub New(messageValue As String, inner As Exception)
        MyBase.New(messageValue, inner)
    End Sub

End Class
