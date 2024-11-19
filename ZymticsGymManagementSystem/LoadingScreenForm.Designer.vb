<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadingScreenForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LoadingScreenLabel = New Label()
        LoadingScreenBtn = New Button()
        LoadingScreenBG = New Panel()
        LoadingScreenBG.SuspendLayout()
        SuspendLayout()
        ' 
        ' LoadingScreenLabel
        ' 
        LoadingScreenLabel.AutoSize = True
        LoadingScreenLabel.BackColor = Color.LightGray
        LoadingScreenLabel.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoadingScreenLabel.ForeColor = Color.Black
        LoadingScreenLabel.Location = New Point(557, 148)
        LoadingScreenLabel.Name = "LoadingScreenLabel"
        LoadingScreenLabel.Size = New Size(269, 86)
        LoadingScreenLabel.TabIndex = 0
        LoadingScreenLabel.Text = "Zymtics" & vbCrLf
        LoadingScreenLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoadingScreenBtn
        ' 
        LoadingScreenBtn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoadingScreenBtn.Location = New Point(605, 411)
        LoadingScreenBtn.Name = "LoadingScreenBtn"
        LoadingScreenBtn.Size = New Size(161, 105)
        LoadingScreenBtn.TabIndex = 1
        LoadingScreenBtn.Text = "Start"
        LoadingScreenBtn.UseVisualStyleBackColor = True
        ' 
        ' LoadingScreenBG
        ' 
        LoadingScreenBG.BackgroundImage = My.Resources.Resources.admin
        LoadingScreenBG.BackgroundImageLayout = ImageLayout.Stretch
        LoadingScreenBG.Controls.Add(LoadingScreenLabel)
        LoadingScreenBG.Controls.Add(LoadingScreenBtn)
        LoadingScreenBG.Location = New Point(0, 1)
        LoadingScreenBG.Name = "LoadingScreenBG"
        LoadingScreenBG.Size = New Size(1323, 668)
        LoadingScreenBG.TabIndex = 2
        ' 
        ' LoadingScreenForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1321, 681)
        Controls.Add(LoadingScreenBG)
        Name = "LoadingScreenForm"
        Text = "Initializing Screen"
        LoadingScreenBG.ResumeLayout(False)
        LoadingScreenBG.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadingScreenLabel As Label
    Friend WithEvents LoadingScreenBtn As Button
    Friend WithEvents LoadingScreenBG As Panel

End Class
