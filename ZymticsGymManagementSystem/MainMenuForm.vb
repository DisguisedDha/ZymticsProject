Public Class MainMenuForm
    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maximize the form on load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None ' Optionally, hide the form border for a full-screen menu

        ' Call the resize control method to adjust all controls on form load
        MainMenuResizeControl()
    End Sub

    Private Sub MainMenuForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Call the method to resize and reposition controls when form is resized
        MainMenuResizeControl()
    End Sub

    Private Sub MainMenuResizeControl()
        ' Ensure the background panel resizes to fill the entire form
        MainMenuBG.Width = Me.ClientSize.Width
        MainMenuBG.Height = Me.ClientSize.Height

        ' Resize the MainMenuPanel to 50% of the form width and 90% of the form height, centered in the middle
        MainMenuPanel.Width = Me.ClientSize.Width * 0.5 ' Set width to 50% of form width
        MainMenuPanel.Height = Me.ClientSize.Height * 0.9 ' Set height to 90% of form height
        MainMenuPanel.Left = (Me.ClientSize.Width - MainMenuPanel.Width) / 2 ' Center horizontally
        MainMenuPanel.Top = (Me.ClientSize.Height - MainMenuPanel.Height) / 2 ' Center vertically

        ' Ensure the title label is positioned relative to MainMenuPanel and resized based on panel size
        MainMenuLabel.Width = MainMenuPanel.Width * 0.8 ' Set width to 80% of panel width
        MainMenuLabel.Height = MainMenuPanel.Height * 0.1 ' Set height to 10% of panel height
        MainMenuLabel.Left = (MainMenuPanel.Width - MainMenuLabel.Width) / 2 ' Center horizontally within the panel
        MainMenuLabel.Top = MainMenuPanel.Top + 20 ' Position label slightly below the top of the panel

        ' Adjust the font size of the label based on the panel width
        Dim fontSize1 As Single = MainMenuPanel.Width / 15 ' Font size proportional to panel width
        MainMenuLabel.Font = New Font("Segoe UI", fontSize1, FontStyle.Bold)

        ' Define button size percentage and space within the panel
        Dim btnWidth As Integer = MainMenuPanel.Width * 0.5 ' Set button width to 30% of panel width
        Dim btnHeight As Integer = MainMenuPanel.Height * 0.12 ' Set button height to 12% of panel height
        Dim btnVerticalSpacing As Integer = MainMenuPanel.Height * 0.05 ' Set vertical space between buttons

        ' Position buttons with consistent width, height, and vertical alignment within the panel

        ' Admin Login Button
        AdminLoginBtn.Width = btnWidth
        AdminLoginBtn.Height = btnHeight
        AdminLoginBtn.Left = (MainMenuPanel.Width - AdminLoginBtn.Width) / 2 ' Center horizontally within the panel
        AdminLoginBtn.Top = MainMenuLabel.Bottom + btnVerticalSpacing ' Position below the title label
        AdminLoginBtn.Font = New Font("Segoe UI", 16, FontStyle.Bold)

        ' Member Login Button
        MemberLoginBtn.Width = btnWidth
        MemberLoginBtn.Height = btnHeight
        MemberLoginBtn.Left = (MainMenuPanel.Width - MemberLoginBtn.Width) / 2 ' Center horizontally within the panel
        MemberLoginBtn.Top = AdminLoginBtn.Bottom + btnVerticalSpacing ' Position below Admin Login button
        MemberLoginBtn.Font = New Font("Segoe UI", 16, FontStyle.Bold)

        ' Instructor Login Button
        InstructorLoginBtn.Width = btnWidth
        InstructorLoginBtn.Height = btnHeight
        InstructorLoginBtn.Left = (MainMenuPanel.Width - InstructorLoginBtn.Width) / 2 ' Center horizontally within the panel
        InstructorLoginBtn.Top = MemberLoginBtn.Bottom + btnVerticalSpacing ' Position below Member Login button
        InstructorLoginBtn.Font = New Font("Segoe UI", 16, FontStyle.Bold)

        ' Exit Button
        ExitBtn.Width = btnWidth
        ExitBtn.Height = btnHeight
        ExitBtn.Left = (MainMenuPanel.Width - ExitBtn.Width) / 2 ' Center horizontally within the panel
        ExitBtn.Top = InstructorLoginBtn.Bottom + btnVerticalSpacing ' Position below Instructor Login button
        ExitBtn.Font = New Font("Segoe UI", 16, FontStyle.Bold)
    End Sub

    ' Event handler for Admin Login button
    Private Sub AdminLoginBtn_Click(sender As Object, e As EventArgs) Handles AdminLoginBtn.Click
        ' Open AdminLoginForm when Admin Login button is clicked
        Dim adminLoginForm As New AdminLoginForm()
        adminLoginForm.Show()
        Me.Hide() ' Optionally, hide the current form (MainMenuForm) if you want to navigate away
    End Sub

    ' Event handler for Member Login button
    Private Sub MemberLoginBtn_Click(sender As Object, e As EventArgs) Handles MemberLoginBtn.Click
        ' Open MemberLoginForm when Member Login button is clicked
        Dim memberLoginForm As New MemberLoginForm()
        memberLoginForm.Show()
        Me.Hide() ' Optionally, hide the current form (MainMenuForm) if you want to navigate away
    End Sub

    ' Event handler for Instructor Login button
    Private Sub InstructorLoginBtn_Click(sender As Object, e As EventArgs) Handles InstructorLoginBtn.Click
        ' Open InstructorLoginForm when Instructor Login button is clicked
        Dim instructorLoginForm As New InstructorLoginForm()
        instructorLoginForm.Show()
        Me.Hide() ' Optionally, hide the current form (MainMenuForm) if you want to navigate away
    End Sub

    ' Event handler for Exit button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        ' Close the application when the Exit button is clicked
        Application.Exit() ' This will terminate the program
    End Sub
End Class
