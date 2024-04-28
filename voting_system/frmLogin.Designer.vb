<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtvoterID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVoterPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbSignUp = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSignUp.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.btnSignIn)
        Me.TabPage1.Controls.Add(Me.btnClose)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtVoterPassword)
        Me.TabPage1.Controls.Add(Me.txtvoterID)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 58)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(720, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SIGN IN"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtvoterID
        '
        Me.txtvoterID.Location = New System.Drawing.Point(326, 104)
        Me.txtvoterID.Name = "txtvoterID"
        Me.txtvoterID.Size = New System.Drawing.Size(281, 31)
        Me.txtvoterID.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 25)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "ID"
        '
        'txtVoterPassword
        '
        Me.txtVoterPassword.Location = New System.Drawing.Point(326, 192)
        Me.txtVoterPassword.Name = "txtVoterPassword"
        Me.txtVoterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVoterPassword.Size = New System.Drawing.Size(281, 31)
        Me.txtVoterPassword.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Password"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(345, 248)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 34)
        Me.btnClose.TabIndex = 73
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSignIn.Location = New System.Drawing.Point(479, 248)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(112, 34)
        Me.btnSignIn.TabIndex = 74
        Me.btnSignIn.Text = "Log-in"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(102, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'tbSignUp
        '
        Me.tbSignUp.Controls.Add(Me.TabPage1)
        Me.tbSignUp.Location = New System.Drawing.Point(1, -1)
        Me.tbSignUp.Name = "tbSignUp"
        Me.tbSignUp.Padding = New System.Drawing.Point(30, 15)
        Me.tbSignUp.SelectedIndex = 0
        Me.tbSignUp.Size = New System.Drawing.Size(728, 440)
        Me.tbSignUp.TabIndex = 0
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 440)
        Me.Controls.Add(Me.tbSignUp)
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSignUp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVoterPassword As TextBox
    Friend WithEvents txtvoterID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbSignUp As TabControl
End Class
