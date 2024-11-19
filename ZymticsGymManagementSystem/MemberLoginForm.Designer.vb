<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberLoginForm
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
        MemberBG = New Panel()
        MemberPanel = New Panel()
        BackBtn = New Button()
        EnterBtn = New Button()
        PassTextBox = New TextBox()
        UserTextBox = New TextBox()
        PassLabel = New Label()
        UserLabel = New Label()
        MemberLoginTitle = New Label()
        MemberBG.SuspendLayout()
        MemberPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MemberBG
        ' 
        MemberBG.BackgroundImage = My.Resources.Resources.admin
        MemberBG.BackgroundImageLayout = ImageLayout.Stretch
        MemberBG.Controls.Add(MemberPanel)
        MemberBG.Location = New Point(1, 0)
        MemberBG.Name = "MemberBG"
        MemberBG.Size = New Size(1323, 658)
        MemberBG.TabIndex = 5
        ' 
        ' MemberPanel
        ' 
        MemberPanel.BackColor = Color.DarkGray
        MemberPanel.Controls.Add(BackBtn)
        MemberPanel.Controls.Add(EnterBtn)
        MemberPanel.Controls.Add(PassTextBox)
        MemberPanel.Controls.Add(UserTextBox)
        MemberPanel.Controls.Add(PassLabel)
        MemberPanel.Controls.Add(UserLabel)
        MemberPanel.Controls.Add(MemberLoginTitle)
        MemberPanel.Location = New Point(487, 94)
        MemberPanel.Name = "MemberPanel"
        MemberPanel.Size = New Size(458, 506)
        MemberPanel.TabIndex = 2
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
        ' MemberLoginTitle
        ' 
        MemberLoginTitle.AutoSize = True
        MemberLoginTitle.Location = New Point(177, 66)
        MemberLoginTitle.Name = "MemberLoginTitle"
        MemberLoginTitle.Size = New Size(85, 15)
        MemberLoginTitle.TabIndex = 0
        MemberLoginTitle.Text = "Member Login"
        ' 
        ' MemberLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1323, 683)
        Controls.Add(MemberBG)
        Name = "MemberLoginForm"
        Text = "MemberLoginForm"
        MemberBG.ResumeLayout(False)
        MemberPanel.ResumeLayout(False)
        MemberPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MemberBG As Panel
    Friend WithEvents MemberPanel As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents EnterBtn As Button
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents PassLabel As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents MemberLoginTitle As Label
End Class
