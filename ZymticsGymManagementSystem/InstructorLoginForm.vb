Public Class InstructorLoginForm
    Private Sub InstructorLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maximize the form on load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None ' Optionally, hide the form border for full-screen login

        ' Call the resize control method to adjust all controls on form load
        InstructorLoginResizeControl()
    End Sub

    Private Sub InstructorLoginForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Call the method to resize and reposition controls when form is resized
        InstructorLoginResizeControl()
    End Sub

    Private Sub InstructorLoginResizeControl()
        ' Ensure the background panel resizes to fill the entire form
        InstructorBG.Width = Me.ClientSize.Width
        InstructorBG.Height = Me.ClientSize.Height

        ' Resize the InstructorPanel to be a smaller portion of the form, centered horizontally but close to the top
        InstructorPanel.Width = Me.ClientSize.Width * 0.6 ' Set width to 60% of form width
        InstructorPanel.Height = Me.ClientSize.Height * 0.6 ' Set height to 60% of form height
        InstructorPanel.Left = (Me.ClientSize.Width - InstructorPanel.Width) / 2 ' Center horizontally
        InstructorPanel.Top = (Me.ClientSize.Height - InstructorPanel.Height) / 3 ' Align it to the top of the form

        ' Set the label and text box dimensions, making them consistent with the panel width
        Dim controlWidth As Integer = InstructorPanel.Width * 0.8 ' 80% of the panel width
        Dim controlHeight As Integer = 40 ' Fixed height for textboxes and labels

        ' Resize the InstructorLoginTitle
        InstructorLoginTitle.Width = controlWidth
        InstructorLoginTitle.Height = 50 ' Fixed height for the title label
        InstructorLoginTitle.Left = (InstructorPanel.Width - InstructorLoginTitle.Width) / 2 ' Center horizontally
        InstructorLoginTitle.Top = InstructorPanel.Top + 10 ' Position title near the top of the panel
        InstructorLoginTitle.Font = New Font("Segoe UI", 24, FontStyle.Bold) ' Font style and size

        ' Resize and position the UserLabel
        UserLabel.Width = controlWidth
        UserLabel.Height = controlHeight
        UserLabel.Left = (InstructorPanel.Width - UserLabel.Width) / 2 ' Center horizontally
        UserLabel.Top = InstructorLoginTitle.Bottom + 10 ' Position below the title label

        UserLabel.Font = New Font("Segoe UI", 14, FontStyle.Bold) ' Set font style and size

        ' Resize and position the UserTextBox
        UserTextBox.Width = controlWidth
        UserTextBox.Height = controlHeight
        UserTextBox.Left = (InstructorPanel.Width - UserTextBox.Width) / 2 ' Center horizontally
        UserTextBox.Top = UserLabel.Bottom + 10 ' Position below the UserLabel with some spacing
        UserTextBox.Font = New Font("Segoe UI", 14) ' Set font style and size for the textbox

        ' Resize and position the PassLabel
        PassLabel.Width = controlWidth
        PassLabel.Height = controlHeight
        PassLabel.Left = (InstructorPanel.Width - PassLabel.Width) / 2 ' Center horizontally
        PassLabel.Top = UserTextBox.Bottom + 10 ' Position below the UserTextBox with some spacing
        PassLabel.Font = New Font("Segoe UI", 14, FontStyle.Bold) ' Set font style and size

        ' Resize and position the PassTextBox
        PassTextBox.Width = controlWidth
        PassTextBox.Height = controlHeight
        PassTextBox.Left = (InstructorPanel.Width - PassTextBox.Width) / 2 ' Center horizontally
        PassTextBox.Top = PassLabel.Bottom + 10 ' Position below the PassLabel with some spacing
        PassTextBox.Font = New Font("Segoe UI", 14) ' Set font style and size for the textbox
        PassTextBox.PasswordChar = "*" ' Mask the password input

        ' Resize and position the EnterBtn
        EnterBtn.Width = InstructorPanel.Width * 0.3 ' Set width to 60% of the panel width
        EnterBtn.Height = 50 ' Set a fixed height for the button
        EnterBtn.Left = (InstructorPanel.Width - EnterBtn.Width) / 2 ' Center horizontally in the panel
        EnterBtn.Top = PassTextBox.Bottom + 20 ' Position below the PassTextBox with some spacing
        EnterBtn.Font = New Font("Segoe UI", 16, FontStyle.Bold) ' Set font style and size for the button

        ' Resize and position the BackBtn
        BackBtn.Width = InstructorPanel.Width * 0.3 ' Set width to 60% of the panel width
        BackBtn.Height = 50 ' Set a fixed height for the button
        BackBtn.Left = (InstructorPanel.Width - BackBtn.Width) / 2 ' Center horizontally in the panel
        BackBtn.Top = EnterBtn.Bottom + 20 ' Position below the EnterBtn with some spacing

        BackBtn.Font = New Font("Segoe UI", 16, FontStyle.Bold) ' Set font style and size for the button

        ' Calculate the total height of all controls, including vertical spacing
        Dim totalHeight As Integer = InstructorLoginTitle.Height + UserLabel.Height + UserTextBox.Height + PassLabel.Height + PassTextBox.Height + EnterBtn.Height + BackBtn.Height + 180 ' Additional space for margins and gaps

        ' If the total height exceeds the InstructorPanel height, scale down the controls
        If totalHeight > InstructorPanel.Height Then
            ' Scale down the height of each control proportionally
            Dim scaleFactor As Double = InstructorPanel.Height / totalHeight

            ' Scale each control's height and adjust the positioning
            UserLabel.Height *= scaleFactor
            UserTextBox.Height *= scaleFactor
            PassLabel.Height *= scaleFactor
            PassTextBox.Height *= scaleFactor
            EnterBtn.Height *= scaleFactor
            BackBtn.Height *= scaleFactor

            ' Reposition controls based on the new scaled heights
            InstructorLoginTitle.Top = InstructorPanel.Top + 20
            UserLabel.Top = InstructorLoginTitle.Bottom + 10
            UserTextBox.Top = UserLabel.Bottom + 10
            PassLabel.Top = UserTextBox.Bottom + 10
            PassTextBox.Top = PassLabel.Bottom + 10
            EnterBtn.Top = PassTextBox.Bottom + 20
            BackBtn.Top = EnterBtn.Bottom + 20
        Else
            ' If the total height is less than or equal to the InstructorPanel height, position the controls at the top
            InstructorLoginTitle.Top = InstructorPanel.Top + 20
            UserLabel.Top = InstructorLoginTitle.Bottom + 10
            UserTextBox.Top = UserLabel.Bottom + 10
            PassLabel.Top = UserTextBox.Bottom + 10
            PassTextBox.Top = PassLabel.Bottom + 10
            EnterBtn.Top = PassTextBox.Bottom + 20
            BackBtn.Top = EnterBtn.Bottom + 20
        End If
    End Sub

    ' Event handler for EnterBtn (login)
    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles EnterBtn.Click
        ' Perform login logic (check username and password) here
        If UserTextBox.Text = "admin" And PassTextBox.Text = "password" Then
            MessageBox.Show("Login successful") ' Placeholder message
            ' Optionally, open a new form (e.g., InstructorDashboardForm) after login
            ' Dim instructorDashboard As New InstructorDashboardForm()
            ' instructorDashboard.Show()
            ' Me.Hide() ' Optionally, hide the current form after login
        Else
            MessageBox.Show("Invalid credentials") ' Error message if login fails
        End If
    End Sub

    ' Event handler for BackBtn (go back to MainMenuForm)
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ' Close the current form and go back to the MainMenuForm
        Dim mainMenuForm As New MainMenuForm()
        mainMenuForm.Show()
        Me.Hide() ' Hide the current form (InstructorLoginForm)
    End Sub
End Class
