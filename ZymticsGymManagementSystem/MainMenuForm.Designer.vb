<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
        MainMenuLabel = New Label()
        MainMenuPanel = New Panel()
        ExitBtn = New Button()
        InstructorLoginBtn = New Button()
        MemberLoginBtn = New Button()
        AdminLoginBtn = New Button()
        MainMenuBG = New Panel()
        MainMenuPanel.SuspendLayout()
        MainMenuBG.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainMenuLabel
        ' 
        MainMenuLabel.AutoSize = True
        MainMenuLabel.Location = New Point(194, 53)
        MainMenuLabel.Name = "MainMenuLabel"
        MainMenuLabel.Size = New Size(68, 15)
        MainMenuLabel.TabIndex = 0
        MainMenuLabel.Text = "Main Menu"
        ' 
        ' MainMenuPanel
        ' 
        MainMenuPanel.BackColor = Color.DarkGray
        MainMenuPanel.Controls.Add(ExitBtn)
        MainMenuPanel.Controls.Add(MainMenuLabel)
        MainMenuPanel.Controls.Add(AdminLoginBtn)
        MainMenuPanel.Controls.Add(InstructorLoginBtn)
        MainMenuPanel.Controls.Add(MemberLoginBtn)
        MainMenuPanel.Location = New Point(420, 103)
        MainMenuPanel.Name = "MainMenuPanel"
        MainMenuPanel.Size = New Size(481, 465)
        MainMenuPanel.TabIndex = 1
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Location = New Point(158, 335)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(150, 37)
        ExitBtn.TabIndex = 4
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' InstructorLoginBtn
        ' 
        InstructorLoginBtn.Location = New Point(158, 251)
        InstructorLoginBtn.Name = "InstructorLoginBtn"
        InstructorLoginBtn.Size = New Size(150, 37)
        InstructorLoginBtn.TabIndex = 3
        InstructorLoginBtn.Text = "Login as Instructor"
        InstructorLoginBtn.UseVisualStyleBackColor = True
        ' 
        ' MemberLoginBtn
        ' 
        MemberLoginBtn.Location = New Point(158, 179)
        MemberLoginBtn.Name = "MemberLoginBtn"
        MemberLoginBtn.Size = New Size(150, 37)
        MemberLoginBtn.TabIndex = 2
        MemberLoginBtn.Text = "Login as Member"
        MemberLoginBtn.UseVisualStyleBackColor = True
        ' 
        ' AdminLoginBtn
        ' 
        AdminLoginBtn.Location = New Point(158, 106)
        AdminLoginBtn.Name = "AdminLoginBtn"
        AdminLoginBtn.Size = New Size(150, 37)
        AdminLoginBtn.TabIndex = 1
        AdminLoginBtn.Text = "Login as Admin"
        AdminLoginBtn.UseVisualStyleBackColor = True
        ' 
        ' MainMenuBG
        ' 
        MainMenuBG.BackgroundImage = My.Resources.Resources.admin
        MainMenuBG.BackgroundImageLayout = ImageLayout.Stretch
        MainMenuBG.Controls.Add(MainMenuPanel)
        MainMenuBG.Location = New Point(-2, -21)
        MainMenuBG.Name = "MainMenuBG"
        MainMenuBG.Size = New Size(1323, 647)
        MainMenuBG.TabIndex = 3
        ' 
        ' MainMenuForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1319, 626)
        Controls.Add(MainMenuBG)
        Name = "MainMenuForm"
        Text = "MainMenuForm"
        MainMenuPanel.ResumeLayout(False)
        MainMenuPanel.PerformLayout()
        MainMenuBG.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainMenuLabel As Label
    Friend WithEvents MainMenuPanel As Panel
    Friend WithEvents InstructorLoginBtn As Button
    Friend WithEvents MemberLoginBtn As Button
    Friend WithEvents AdminLoginBtn As Button
    Friend WithEvents MainMenuBG As Panel
    Friend WithEvents ExitBtn As Button
End Class
