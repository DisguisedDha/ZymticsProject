Public Class LoadingScreenForm
    Private WithEvents Timer As New Timer() ' Timer to control the delay before transitioning to the main form

    Private Sub LoadingScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maximize the form on load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None ' Optionally, hide the form border for a full-screen loading screen

        ' Set initial size and position of the label
        LoadingScreenResizeControl()

    End Sub

    ' Resize and reposition the label when the form is resized
    Private Sub LoadingScreenForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Call the method to resize and reposition Label1
        LoadingScreenResizeControl()
    End Sub

    ' Method to resize and reposition Label1 to the center of the form
    Private Sub LoadingScreenResizeControl()
        ' Ensure the background panel resizes to fill the entire form
        LoadingScreenBG.Width = Me.ClientSize.Width
        LoadingScreenBG.Height = Me.ClientSize.Height

        ' Ensure the label resizes based on the form size
        LoadingScreenLabel.Width = Me.ClientSize.Width * 0.6 ' Set width to 60% of form width
        LoadingScreenLabel.Height = Me.ClientSize.Height * 0.1 ' Set height to 10% of form height

        ' Center the label horizontally and vertically
        LoadingScreenLabel.Left = (Me.ClientSize.Width - LoadingScreenLabel.Width) / 2 ' Center horizontally
        LoadingScreenLabel.Top = (Me.ClientSize.Height - LoadingScreenLabel.Height) / 4 ' Center vertically

        ' Optionally adjust the font size based on the form size
        Dim fontSize1 As Single = Me.ClientSize.Width / 20 ' Font size proportional to form width
        LoadingScreenLabel.Font = New Font("Segoe UI", fontSize1, FontStyle.Bold)

        LoadingScreenBtn.Width = Me.ClientSize.Width * 0.2 ' Set width to 60% of form width
        LoadingScreenBtn.Height = Me.ClientSize.Height * 0.15 ' Set height to 10% of form height

        ' Center the label horizontally and vertically
        LoadingScreenBtn.Left = (Me.ClientSize.Width - LoadingScreenBtn.Width) / 2 ' Center horizontally
        LoadingScreenBtn.Top = (Me.ClientSize.Height - LoadingScreenBtn.Height) / 1.5 ' Center vertically

        ' Optionally adjust the font size based on the form size
        Dim fontSize2 As Single = Me.ClientSize.Width / 30 ' Font size proportional to form width
        LoadingScreenBtn.Font = New Font("Segoe UI", fontSize2, FontStyle.Bold)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoadingScreenBtn.Click
        ' Hide the current loading form
        Me.Hide()

        ' Open the main application form (MainMenuForm)
        Dim mainForm As New MainMenuForm() ' Create instance of MainMenuForm
        mainForm.Show() ' Show the main form
    End Sub

End Class
