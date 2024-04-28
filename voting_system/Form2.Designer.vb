<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvwUserDashMayor = New System.Windows.Forms.ListView()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.lvwUserDashVMayor = New System.Windows.Forms.ListView()
        Me.lvwUserDashCouncilor1 = New System.Windows.Forms.ListView()
        Me.lvwUserDashSenator = New System.Windows.Forms.ListView()
        Me.lvwUserDashCouncilor2 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.VoteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1520, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'VoteToolStripMenuItem
        '
        Me.VoteToolStripMenuItem.Name = "VoteToolStripMenuItem"
        Me.VoteToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.VoteToolStripMenuItem.Text = "Cast Vote"
        '
        'lvwUserDashMayor
        '
        Me.lvwUserDashMayor.FullRowSelect = True
        Me.lvwUserDashMayor.GridLines = True
        Me.lvwUserDashMayor.Location = New System.Drawing.Point(79, 231)
        Me.lvwUserDashMayor.Name = "lvwUserDashMayor"
        Me.lvwUserDashMayor.Size = New System.Drawing.Size(680, 187)
        Me.lvwUserDashMayor.TabIndex = 1
        Me.lvwUserDashMayor.UseCompatibleStateImageBehavior = False
        Me.lvwUserDashMayor.View = System.Windows.Forms.View.Details
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnReload.Location = New System.Drawing.Point(1316, 951)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(146, 52)
        Me.btnReload.TabIndex = 2
        Me.btnReload.Text = "RELOAD"
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'lvwUserDashVMayor
        '
        Me.lvwUserDashVMayor.FullRowSelect = True
        Me.lvwUserDashVMayor.GridLines = True
        Me.lvwUserDashVMayor.Location = New System.Drawing.Point(782, 231)
        Me.lvwUserDashVMayor.Name = "lvwUserDashVMayor"
        Me.lvwUserDashVMayor.Size = New System.Drawing.Size(680, 187)
        Me.lvwUserDashVMayor.TabIndex = 5
        Me.lvwUserDashVMayor.UseCompatibleStateImageBehavior = False
        Me.lvwUserDashVMayor.View = System.Windows.Forms.View.Details
        '
        'lvwUserDashCouncilor1
        '
        Me.lvwUserDashCouncilor1.FullRowSelect = True
        Me.lvwUserDashCouncilor1.GridLines = True
        Me.lvwUserDashCouncilor1.Location = New System.Drawing.Point(782, 491)
        Me.lvwUserDashCouncilor1.Name = "lvwUserDashCouncilor1"
        Me.lvwUserDashCouncilor1.Size = New System.Drawing.Size(680, 187)
        Me.lvwUserDashCouncilor1.TabIndex = 9
        Me.lvwUserDashCouncilor1.UseCompatibleStateImageBehavior = False
        Me.lvwUserDashCouncilor1.View = System.Windows.Forms.View.Details
        '
        'lvwUserDashSenator
        '
        Me.lvwUserDashSenator.FullRowSelect = True
        Me.lvwUserDashSenator.GridLines = True
        Me.lvwUserDashSenator.Location = New System.Drawing.Point(79, 491)
        Me.lvwUserDashSenator.Name = "lvwUserDashSenator"
        Me.lvwUserDashSenator.Size = New System.Drawing.Size(680, 187)
        Me.lvwUserDashSenator.TabIndex = 7
        Me.lvwUserDashSenator.UseCompatibleStateImageBehavior = False
        Me.lvwUserDashSenator.View = System.Windows.Forms.View.Details
        '
        'lvwUserDashCouncilor2
        '
        Me.lvwUserDashCouncilor2.FullRowSelect = True
        Me.lvwUserDashCouncilor2.GridLines = True
        Me.lvwUserDashCouncilor2.Location = New System.Drawing.Point(427, 765)
        Me.lvwUserDashCouncilor2.Name = "lvwUserDashCouncilor2"
        Me.lvwUserDashCouncilor2.Size = New System.Drawing.Size(680, 187)
        Me.lvwUserDashCouncilor2.TabIndex = 11
        Me.lvwUserDashCouncilor2.UseCompatibleStateImageBehavior = False
        Me.lvwUserDashCouncilor2.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(673, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 44)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "DASHBOARD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(684, 725)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 24)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "COUNCILOR 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(1051, 454)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 24)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "COUNCILOR 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(326, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 24)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "SENATOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(1051, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "VICE MAYOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(340, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "MAYOR"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1520, 1050)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwUserDashCouncilor2)
        Me.Controls.Add(Me.lvwUserDashCouncilor1)
        Me.Controls.Add(Me.lvwUserDashSenator)
        Me.Controls.Add(Me.lvwUserDashVMayor)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.lvwUserDashMayor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "User Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lvwUserDashMayor As ListView
    Friend WithEvents btnReload As Button
    Friend WithEvents lvwUserDashVMayor As ListView
    Friend WithEvents lvwUserDashCouncilor1 As ListView
    Friend WithEvents lvwUserDashSenator As ListView
    Friend WithEvents lvwUserDashCouncilor2 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
