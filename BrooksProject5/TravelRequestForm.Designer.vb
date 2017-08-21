<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TravelRequestForm
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
        Me.exceptionLabel = New System.Windows.Forms.Label()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.purposeTextBox = New System.Windows.Forms.TextBox()
        Me.startDateTextBox = New System.Windows.Forms.TextBox()
        Me.endDateTextBox = New System.Windows.Forms.TextBox()
        Me.requestedAmountTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.requestedAmtLabel = New System.Windows.Forms.Label()
        Me.endDateLabel = New System.Windows.Forms.Label()
        Me.startDateLabel = New System.Windows.Forms.Label()
        Me.purposeLabel = New System.Windows.Forms.Label()
        Me.lNameLabel = New System.Windows.Forms.Label()
        Me.fNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exceptionLabel
        '
        Me.exceptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.exceptionLabel.Location = New System.Drawing.Point(15, 192)
        Me.exceptionLabel.Name = "exceptionLabel"
        Me.exceptionLabel.Size = New System.Drawing.Size(401, 99)
        Me.exceptionLabel.TabIndex = 30
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(341, 147)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 29
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(260, 147)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 28
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'purposeTextBox
        '
        Me.purposeTextBox.Location = New System.Drawing.Point(94, 60)
        Me.purposeTextBox.Name = "purposeTextBox"
        Me.purposeTextBox.Size = New System.Drawing.Size(322, 20)
        Me.purposeTextBox.TabIndex = 20
        '
        'startDateTextBox
        '
        Me.startDateTextBox.Location = New System.Drawing.Point(94, 99)
        Me.startDateTextBox.Name = "startDateTextBox"
        Me.startDateTextBox.Size = New System.Drawing.Size(121, 20)
        Me.startDateTextBox.TabIndex = 22
        '
        'endDateTextBox
        '
        Me.endDateTextBox.Location = New System.Drawing.Point(303, 99)
        Me.endDateTextBox.Name = "endDateTextBox"
        Me.endDateTextBox.Size = New System.Drawing.Size(113, 20)
        Me.endDateTextBox.TabIndex = 24
        '
        'requestedAmountTextBox
        '
        Me.requestedAmountTextBox.Location = New System.Drawing.Point(143, 150)
        Me.requestedAmountTextBox.Name = "requestedAmountTextBox"
        Me.requestedAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.requestedAmountTextBox.TabIndex = 26
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(303, 19)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(113, 20)
        Me.lastNameTextBox.TabIndex = 18
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(94, 19)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.firstNameTextBox.TabIndex = 16
        '
        'requestedAmtLabel
        '
        Me.requestedAmtLabel.AutoSize = True
        Me.requestedAmtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestedAmtLabel.Location = New System.Drawing.Point(11, 150)
        Me.requestedAmtLabel.Name = "requestedAmtLabel"
        Me.requestedAmtLabel.Size = New System.Drawing.Size(126, 16)
        Me.requestedAmtLabel.TabIndex = 27
        Me.requestedAmtLabel.Text = "Requested Amount:"
        '
        'endDateLabel
        '
        Me.endDateLabel.AutoSize = True
        Me.endDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDateLabel.Location = New System.Drawing.Point(221, 99)
        Me.endDateLabel.Name = "endDateLabel"
        Me.endDateLabel.Size = New System.Drawing.Size(67, 16)
        Me.endDateLabel.TabIndex = 25
        Me.endDateLabel.Text = "End Date:"
        '
        'startDateLabel
        '
        Me.startDateLabel.AutoSize = True
        Me.startDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDateLabel.Location = New System.Drawing.Point(12, 99)
        Me.startDateLabel.Name = "startDateLabel"
        Me.startDateLabel.Size = New System.Drawing.Size(70, 16)
        Me.startDateLabel.TabIndex = 23
        Me.startDateLabel.Text = "Start Date:"
        '
        'purposeLabel
        '
        Me.purposeLabel.AutoSize = True
        Me.purposeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purposeLabel.Location = New System.Drawing.Point(12, 60)
        Me.purposeLabel.Name = "purposeLabel"
        Me.purposeLabel.Size = New System.Drawing.Size(59, 16)
        Me.purposeLabel.TabIndex = 21
        Me.purposeLabel.Text = "Purpose"
        '
        'lNameLabel
        '
        Me.lNameLabel.AutoSize = True
        Me.lNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNameLabel.Location = New System.Drawing.Point(221, 20)
        Me.lNameLabel.Name = "lNameLabel"
        Me.lNameLabel.Size = New System.Drawing.Size(76, 16)
        Me.lNameLabel.TabIndex = 19
        Me.lNameLabel.Text = "Last Name:"
        '
        'fNameLabel
        '
        Me.fNameLabel.AutoSize = True
        Me.fNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fNameLabel.Location = New System.Drawing.Point(12, 20)
        Me.fNameLabel.Name = "fNameLabel"
        Me.fNameLabel.Size = New System.Drawing.Size(76, 16)
        Me.fNameLabel.TabIndex = 17
        Me.fNameLabel.Text = "First Name:"
        '
        'TravelRequestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 311)
        Me.Controls.Add(Me.exceptionLabel)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.purposeTextBox)
        Me.Controls.Add(Me.startDateTextBox)
        Me.Controls.Add(Me.endDateTextBox)
        Me.Controls.Add(Me.requestedAmountTextBox)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.requestedAmtLabel)
        Me.Controls.Add(Me.endDateLabel)
        Me.Controls.Add(Me.startDateLabel)
        Me.Controls.Add(Me.purposeLabel)
        Me.Controls.Add(Me.lNameLabel)
        Me.Controls.Add(Me.fNameLabel)
        Me.Name = "TravelRequestForm"
        Me.Text = "Brooks Travel Request"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exceptionLabel As Label
    Friend WithEvents cancelButton As Button
    Friend WithEvents submitButton As Button
    Friend WithEvents purposeTextBox As TextBox
    Friend WithEvents startDateTextBox As TextBox
    Friend WithEvents endDateTextBox As TextBox
    Friend WithEvents requestedAmountTextBox As TextBox
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents requestedAmtLabel As Label
    Friend WithEvents endDateLabel As Label
    Friend WithEvents startDateLabel As Label
    Friend WithEvents purposeLabel As Label
    Friend WithEvents lNameLabel As Label
    Friend WithEvents fNameLabel As Label
End Class
