<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorLoginForm
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
        InstructorPanel = New Panel()
        EnterBtn = New Button()
        PassTextBox = New TextBox()
        UserTextBox = New TextBox()
        PassLabel = New Label()
        UserLabel = New Label()
        InstructorLoginTitle = New Label()
        BackBtn = New Button()
        InstructorBG = New Panel()
        InstructorPanel.SuspendLayout()
        InstructorBG.SuspendLayout()
        SuspendLayout()
        ' 
        ' InstructorPanel
        ' 
        InstructorPanel.BackColor = Color.DarkGray
        InstructorPanel.Controls.Add(BackBtn)
        InstructorPanel.Controls.Add(EnterBtn)
        InstructorPanel.Controls.Add(PassTextBox)
        InstructorPanel.Controls.Add(UserTextBox)
        InstructorPanel.Controls.Add(PassLabel)
        InstructorPanel.Controls.Add(UserLabel)
        InstructorPanel.Controls.Add(InstructorLoginTitle)
        InstructorPanel.Location = New Point(487, 94)
        InstructorPanel.Name = "InstructorPanel"
        InstructorPanel.Size = New Size(458, 506)
        InstructorPanel.TabIndex = 2
        ' 
        ' EnterBtn
        ' 
        EnterBtn.Location = New Point(187, 379)
        EnterBtn.Name = "EnterBtn"
        EnterBtn.Size = New Size(75, 23)
        EnterBtn.TabIndex = 6
        EnterBtn.Text = "Enter"
        EnterBtn.UseVisualStyleBackColor = True
        ' 
        ' PassTextBox
        ' 
        PassTextBox.Location = New Point(90, 292)
        PassTextBox.Name = "PassTextBox"
        PassTextBox.Size = New Size(261, 23)
        PassTextBox.TabIndex = 4
        ' 
        ' UserTextBox
        ' 
        UserTextBox.Location = New Point(90, 189)
        UserTextBox.Name = "UserTextBox"
        UserTextBox.Size = New Size(261, 23)
        UserTextBox.TabIndex = 3
        ' 
        ' PassLabel
        ' 
        PassLabel.AutoSize = True
        PassLabel.Location = New Point(195, 274)
        PassLabel.Name = "PassLabel"
        PassLabel.Size = New Size(57, 15)
        PassLabel.TabIndex = 2
        PassLabel.Text = "Password"
        ' 
        ' UserLabel
        ' 
        UserLabel.AutoSize = True
        UserLabel.Location = New Point(192, 171)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New Size(60, 15)
        UserLabel.TabIndex = 1
        UserLabel.Text = "Username"
        ' 
        ' InstructorLoginTitle
        ' 
        InstructorLoginTitle.AutoSize = True
        InstructorLoginTitle.Location = New Point(176, 68)
        InstructorLoginTitle.Name = "InstructorLoginTitle"
        InstructorLoginTitle.Size = New Size(91, 15)
        InstructorLoginTitle.TabIndex = 0
        InstructorLoginTitle.Text = "Instructor Login"
        ' 
        ' BackBtn
        ' 
        BackBtn.Location = New Point(131, 427)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(179, 23)
        BackBtn.TabIndex = 7
        BackBtn.Text = "Back to Main Menu"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' InstructorBG
        ' 
        InstructorBG.BackgroundImage = My.Resources.Resources.admin
        InstructorBG.BackgroundImageLayout = ImageLayout.Stretch
        InstructorBG.Controls.Add(InstructorPanel)
        InstructorBG.Location = New Point(1, 1)
        InstructorBG.Name = "InstructorBG"
        InstructorBG.Size = New Size(1323, 658)
        InstructorBG.TabIndex = 4
        ' 
        ' InstructorLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1326, 682)
        Controls.Add(InstructorBG)
        Name = "InstructorLoginForm"
        Text = "InstructorLoginForm"
        InstructorPanel.ResumeLayout(False)
        InstructorPanel.PerformLayout()
        InstructorBG.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents InstructorPanel As Panel
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents PassLabel As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents InstructorLoginTitle As Label
    Friend WithEvents EnterBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents InstructorBG As Panel
End Class
