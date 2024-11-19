<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLoginForm
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
        AdminBG = New Panel()
        AdminPanel = New Panel()
        BackBtn = New Button()
        EnterBtn = New Button()
        PassTextBox = New TextBox()
        UserTextBox = New TextBox()
        PassLabel = New Label()
        UserLabel = New Label()
        AdminLoginTitle = New Label()
        AdminBG.SuspendLayout()
        AdminPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' AdminBG
        ' 
        AdminBG.BackgroundImage = My.Resources.Resources.admin
        AdminBG.BackgroundImageLayout = ImageLayout.Stretch
        AdminBG.Controls.Add(AdminPanel)
        AdminBG.Location = New Point(-5, 0)
        AdminBG.Name = "AdminBG"
        AdminBG.Size = New Size(1323, 658)
        AdminBG.TabIndex = 6
        ' 
        ' AdminPanel
        ' 
        AdminPanel.BackColor = Color.DarkGray
        AdminPanel.Controls.Add(BackBtn)
        AdminPanel.Controls.Add(EnterBtn)
        AdminPanel.Controls.Add(PassTextBox)
        AdminPanel.Controls.Add(UserTextBox)
        AdminPanel.Controls.Add(PassLabel)
        AdminPanel.Controls.Add(UserLabel)
        AdminPanel.Controls.Add(AdminLoginTitle)
        AdminPanel.Location = New Point(487, 94)
        AdminPanel.Name = "AdminPanel"
        AdminPanel.Size = New Size(458, 506)
        AdminPanel.TabIndex = 2
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
        ' AdminLoginTitle
        ' 
        AdminLoginTitle.AutoSize = True
        AdminLoginTitle.Location = New Point(177, 66)
        AdminLoginTitle.Name = "AdminLoginTitle"
        AdminLoginTitle.Size = New Size(76, 15)
        AdminLoginTitle.TabIndex = 0
        AdminLoginTitle.Text = "Admin Login"
        ' 
        ' AdminLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 668)
        Controls.Add(AdminBG)
        Name = "AdminLoginForm"
        Text = "AdminLoginForm"
        AdminBG.ResumeLayout(False)
        AdminPanel.ResumeLayout(False)
        AdminPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents AdminBG As Panel
    Friend WithEvents AdminPanel As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents EnterBtn As Button
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents PassLabel As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents AdminLoginTitle As Label
End Class
