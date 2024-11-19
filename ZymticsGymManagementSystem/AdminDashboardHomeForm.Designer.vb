<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboardHomeForm
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
        AdminHomePanel = New Panel()
        AdminSidebarPanel = New Panel()
        AdminPicPanel = New Panel()
        MemberPanel = New Panel()
        InstructorPanel = New Panel()
        EventPanel = New Panel()
        AdminTitleLabel = New Label()
        AdminNameLabel = New Label()
        HomeBtn = New Button()
        TimeinoutBtn = New Button()
        PaymentBtn = New Button()
        ExerciseBtn = New Button()
        EventBtn = New Button()
        RegisterBtn = New Button()
        Button7 = New Button()
        TitlePanel = New Panel()
        MemberLabel = New Label()
        InstructorLabel = New Label()
        EventLabel = New Label()
        MemberCurrentLabel = New Label()
        MemberActiveLabel = New Label()
        InstructorActiveLabel = New Label()
        InstructorCurrentLabel = New Label()
        EventUpcomingLabel = New Label()
        EventCurrentLabel = New Label()
        MemberCurrentTextbox = New TextBox()
        MemberActiveTextbox = New TextBox()
        InstructorCurrentTextbox = New TextBox()
        InstructorActiveTextbox = New TextBox()
        AdminBG.SuspendLayout()
        AdminHomePanel.SuspendLayout()
        AdminSidebarPanel.SuspendLayout()
        MemberPanel.SuspendLayout()
        InstructorPanel.SuspendLayout()
        EventPanel.SuspendLayout()
        TitlePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' AdminBG
        ' 
        AdminBG.BackgroundImage = My.Resources.Resources.admin
        AdminBG.BackgroundImageLayout = ImageLayout.Stretch
        AdminBG.Controls.Add(TitlePanel)
        AdminBG.Controls.Add(AdminHomePanel)
        AdminBG.Location = New Point(0, 1)
        AdminBG.Name = "AdminBG"
        AdminBG.Size = New Size(1314, 643)
        AdminBG.TabIndex = 0
        ' 
        ' AdminHomePanel
        ' 
        AdminHomePanel.BackColor = Color.Coral
        AdminHomePanel.Controls.Add(EventPanel)
        AdminHomePanel.Controls.Add(InstructorPanel)
        AdminHomePanel.Controls.Add(MemberPanel)
        AdminHomePanel.Controls.Add(AdminSidebarPanel)
        AdminHomePanel.Location = New Point(46, 33)
        AdminHomePanel.Name = "AdminHomePanel"
        AdminHomePanel.Size = New Size(1183, 574)
        AdminHomePanel.TabIndex = 1
        ' 
        ' AdminSidebarPanel
        ' 
        AdminSidebarPanel.BackColor = Color.LemonChiffon
        AdminSidebarPanel.Controls.Add(Button7)
        AdminSidebarPanel.Controls.Add(RegisterBtn)
        AdminSidebarPanel.Controls.Add(EventBtn)
        AdminSidebarPanel.Controls.Add(ExerciseBtn)
        AdminSidebarPanel.Controls.Add(PaymentBtn)
        AdminSidebarPanel.Controls.Add(TimeinoutBtn)
        AdminSidebarPanel.Controls.Add(HomeBtn)
        AdminSidebarPanel.Controls.Add(AdminNameLabel)
        AdminSidebarPanel.Controls.Add(AdminPicPanel)
        AdminSidebarPanel.Location = New Point(0, 0)
        AdminSidebarPanel.Name = "AdminSidebarPanel"
        AdminSidebarPanel.Size = New Size(248, 574)
        AdminSidebarPanel.TabIndex = 2
        ' 
        ' AdminPicPanel
        ' 
        AdminPicPanel.Location = New Point(80, 30)
        AdminPicPanel.Name = "AdminPicPanel"
        AdminPicPanel.Size = New Size(80, 73)
        AdminPicPanel.TabIndex = 3
        ' 
        ' MemberPanel
        ' 
        MemberPanel.BackColor = Color.Khaki
        MemberPanel.Controls.Add(MemberActiveTextbox)
        MemberPanel.Controls.Add(MemberCurrentTextbox)
        MemberPanel.Controls.Add(MemberActiveLabel)
        MemberPanel.Controls.Add(MemberCurrentLabel)
        MemberPanel.Controls.Add(MemberLabel)
        MemberPanel.Location = New Point(248, 130)
        MemberPanel.Name = "MemberPanel"
        MemberPanel.Size = New Size(315, 444)
        MemberPanel.TabIndex = 4
        ' 
        ' InstructorPanel
        ' 
        InstructorPanel.BackColor = Color.Gold
        InstructorPanel.Controls.Add(InstructorActiveTextbox)
        InstructorPanel.Controls.Add(InstructorCurrentTextbox)
        InstructorPanel.Controls.Add(InstructorActiveLabel)
        InstructorPanel.Controls.Add(InstructorCurrentLabel)
        InstructorPanel.Controls.Add(InstructorLabel)
        InstructorPanel.Location = New Point(560, 130)
        InstructorPanel.Name = "InstructorPanel"
        InstructorPanel.Size = New Size(309, 444)
        InstructorPanel.TabIndex = 5
        ' 
        ' EventPanel
        ' 
        EventPanel.BackColor = Color.Goldenrod
        EventPanel.Controls.Add(EventUpcomingLabel)
        EventPanel.Controls.Add(EventCurrentLabel)
        EventPanel.Controls.Add(EventLabel)
        EventPanel.Location = New Point(866, 130)
        EventPanel.Name = "EventPanel"
        EventPanel.Size = New Size(316, 444)
        EventPanel.TabIndex = 5
        ' 
        ' AdminTitleLabel
        ' 
        AdminTitleLabel.AutoSize = True
        AdminTitleLabel.Location = New Point(404, 54)
        AdminTitleLabel.Name = "AdminTitleLabel"
        AdminTitleLabel.RightToLeft = RightToLeft.No
        AdminTitleLabel.Size = New Size(103, 15)
        AdminTitleLabel.TabIndex = 6
        AdminTitleLabel.Text = "Admin Dashboard"
        ' 
        ' AdminNameLabel
        ' 
        AdminNameLabel.AutoSize = True
        AdminNameLabel.Location = New Point(66, 106)
        AdminNameLabel.Name = "AdminNameLabel"
        AdminNameLabel.RightToLeft = RightToLeft.No
        AdminNameLabel.Size = New Size(113, 15)
        AdminNameLabel.TabIndex = 7
        AdminNameLabel.Text = "Firstname Lastname"
        ' 
        ' HomeBtn
        ' 
        HomeBtn.Location = New Point(83, 193)
        HomeBtn.Name = "HomeBtn"
        HomeBtn.Size = New Size(75, 23)
        HomeBtn.TabIndex = 7
        HomeBtn.Text = "Home"
        HomeBtn.UseVisualStyleBackColor = True
        ' 
        ' TimeinoutBtn
        ' 
        TimeinoutBtn.Location = New Point(85, 232)
        TimeinoutBtn.Name = "TimeinoutBtn"
        TimeinoutBtn.Size = New Size(75, 23)
        TimeinoutBtn.TabIndex = 8
        TimeinoutBtn.Text = "Timein/out"
        TimeinoutBtn.UseVisualStyleBackColor = True
        ' 
        ' PaymentBtn
        ' 
        PaymentBtn.Location = New Point(83, 270)
        PaymentBtn.Name = "PaymentBtn"
        PaymentBtn.Size = New Size(75, 23)
        PaymentBtn.TabIndex = 9
        PaymentBtn.Text = "Payment"
        PaymentBtn.UseVisualStyleBackColor = True
        ' 
        ' ExerciseBtn
        ' 
        ExerciseBtn.Location = New Point(83, 309)
        ExerciseBtn.Name = "ExerciseBtn"
        ExerciseBtn.Size = New Size(75, 23)
        ExerciseBtn.TabIndex = 10
        ExerciseBtn.Text = "Exercises"
        ExerciseBtn.UseVisualStyleBackColor = True
        ' 
        ' EventBtn
        ' 
        EventBtn.Location = New Point(83, 349)
        EventBtn.Name = "EventBtn"
        EventBtn.Size = New Size(75, 23)
        EventBtn.TabIndex = 11
        EventBtn.Text = "Events"
        EventBtn.UseVisualStyleBackColor = True
        ' 
        ' RegisterBtn
        ' 
        RegisterBtn.Location = New Point(83, 392)
        RegisterBtn.Name = "RegisterBtn"
        RegisterBtn.Size = New Size(75, 23)
        RegisterBtn.TabIndex = 12
        RegisterBtn.Text = "Register"
        RegisterBtn.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(83, 514)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 23)
        Button7.TabIndex = 13
        Button7.Text = "Logout"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' TitlePanel
        ' 
        TitlePanel.BackColor = Color.Coral
        TitlePanel.Controls.Add(AdminTitleLabel)
        TitlePanel.Location = New Point(294, 33)
        TitlePanel.Name = "TitlePanel"
        TitlePanel.Size = New Size(935, 134)
        TitlePanel.TabIndex = 7
        ' 
        ' MemberLabel
        ' 
        MemberLabel.AutoSize = True
        MemberLabel.Location = New Point(125, 49)
        MemberLabel.Name = "MemberLabel"
        MemberLabel.Size = New Size(52, 15)
        MemberLabel.TabIndex = 0
        MemberLabel.Text = "Member"
        ' 
        ' InstructorLabel
        ' 
        InstructorLabel.AutoSize = True
        InstructorLabel.Location = New Point(115, 49)
        InstructorLabel.Name = "InstructorLabel"
        InstructorLabel.Size = New Size(58, 15)
        InstructorLabel.TabIndex = 1
        InstructorLabel.Text = "Instructor"
        ' 
        ' EventLabel
        ' 
        EventLabel.AutoSize = True
        EventLabel.Location = New Point(140, 49)
        EventLabel.Name = "EventLabel"
        EventLabel.Size = New Size(41, 15)
        EventLabel.TabIndex = 2
        EventLabel.Text = "Events"
        ' 
        ' MemberCurrentLabel
        ' 
        MemberCurrentLabel.AutoSize = True
        MemberCurrentLabel.Location = New Point(125, 140)
        MemberCurrentLabel.Name = "MemberCurrentLabel"
        MemberCurrentLabel.Size = New Size(47, 15)
        MemberCurrentLabel.TabIndex = 1
        MemberCurrentLabel.Text = "Current"
        ' 
        ' MemberActiveLabel
        ' 
        MemberActiveLabel.AutoSize = True
        MemberActiveLabel.Location = New Point(125, 223)
        MemberActiveLabel.Name = "MemberActiveLabel"
        MemberActiveLabel.Size = New Size(40, 15)
        MemberActiveLabel.TabIndex = 2
        MemberActiveLabel.Text = "Active"
        ' 
        ' InstructorActiveLabel
        ' 
        InstructorActiveLabel.AutoSize = True
        InstructorActiveLabel.Location = New Point(115, 219)
        InstructorActiveLabel.Name = "InstructorActiveLabel"
        InstructorActiveLabel.Size = New Size(40, 15)
        InstructorActiveLabel.TabIndex = 4
        InstructorActiveLabel.Text = "Active"
        ' 
        ' InstructorCurrentLabel
        ' 
        InstructorCurrentLabel.AutoSize = True
        InstructorCurrentLabel.Location = New Point(115, 136)
        InstructorCurrentLabel.Name = "InstructorCurrentLabel"
        InstructorCurrentLabel.Size = New Size(47, 15)
        InstructorCurrentLabel.TabIndex = 3
        InstructorCurrentLabel.Text = "Current"
        ' 
        ' EventUpcomingLabel
        ' 
        EventUpcomingLabel.AutoSize = True
        EventUpcomingLabel.Location = New Point(140, 227)
        EventUpcomingLabel.Name = "EventUpcomingLabel"
        EventUpcomingLabel.Size = New Size(63, 15)
        EventUpcomingLabel.TabIndex = 6
        EventUpcomingLabel.Text = "Upcoming"
        ' 
        ' EventCurrentLabel
        ' 
        EventCurrentLabel.AutoSize = True
        EventCurrentLabel.Location = New Point(140, 144)
        EventCurrentLabel.Name = "EventCurrentLabel"
        EventCurrentLabel.Size = New Size(47, 15)
        EventCurrentLabel.TabIndex = 5
        EventCurrentLabel.Text = "Current"
        ' 
        ' MemberCurrentTextbox
        ' 
        MemberCurrentTextbox.Location = New Point(99, 158)
        MemberCurrentTextbox.Name = "MemberCurrentTextbox"
        MemberCurrentTextbox.Size = New Size(100, 23)
        MemberCurrentTextbox.TabIndex = 3
        ' 
        ' MemberActiveTextbox
        ' 
        MemberActiveTextbox.Location = New Point(99, 241)
        MemberActiveTextbox.Name = "MemberActiveTextbox"
        MemberActiveTextbox.Size = New Size(100, 23)
        MemberActiveTextbox.TabIndex = 4
        ' 
        ' InstructorCurrentTextbox
        ' 
        InstructorCurrentTextbox.Location = New Point(92, 154)
        InstructorCurrentTextbox.Name = "InstructorCurrentTextbox"
        InstructorCurrentTextbox.Size = New Size(100, 23)
        InstructorCurrentTextbox.TabIndex = 5
        ' 
        ' InstructorActiveTextbox
        ' 
        InstructorActiveTextbox.Location = New Point(92, 237)
        InstructorActiveTextbox.Name = "InstructorActiveTextbox"
        InstructorActiveTextbox.Size = New Size(100, 23)
        InstructorActiveTextbox.TabIndex = 6
        ' 
        ' AdminDashboardHomeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1317, 641)
        Controls.Add(AdminBG)
        Name = "AdminDashboardHomeForm"
        Text = "AdminDashboardHomeForm"
        AdminBG.ResumeLayout(False)
        AdminHomePanel.ResumeLayout(False)
        AdminSidebarPanel.ResumeLayout(False)
        AdminSidebarPanel.PerformLayout()
        MemberPanel.ResumeLayout(False)
        MemberPanel.PerformLayout()
        InstructorPanel.ResumeLayout(False)
        InstructorPanel.PerformLayout()
        EventPanel.ResumeLayout(False)
        EventPanel.PerformLayout()
        TitlePanel.ResumeLayout(False)
        TitlePanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AdminBG As Panel
    Friend WithEvents AdminHomePanel As Panel
    Friend WithEvents AdminSidebarPanel As Panel
    Friend WithEvents AdminPicPanel As Panel
    Friend WithEvents AdminTitleLabel As Label
    Friend WithEvents EventPanel As Panel
    Friend WithEvents InstructorPanel As Panel
    Friend WithEvents MemberPanel As Panel
    Friend WithEvents AdminNameLabel As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents EventBtn As Button
    Friend WithEvents ExerciseBtn As Button
    Friend WithEvents PaymentBtn As Button
    Friend WithEvents TimeinoutBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents EventLabel As Label
    Friend WithEvents InstructorActiveLabel As Label
    Friend WithEvents InstructorCurrentLabel As Label
    Friend WithEvents InstructorLabel As Label
    Friend WithEvents MemberActiveLabel As Label
    Friend WithEvents MemberCurrentLabel As Label
    Friend WithEvents MemberLabel As Label
    Friend WithEvents EventUpcomingLabel As Label
    Friend WithEvents EventCurrentLabel As Label
    Friend WithEvents InstructorActiveTextbox As TextBox
    Friend WithEvents InstructorCurrentTextbox As TextBox
    Friend WithEvents MemberActiveTextbox As TextBox
    Friend WithEvents MemberCurrentTextbox As TextBox
End Class
