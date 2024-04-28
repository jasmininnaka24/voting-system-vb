<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCastVote
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMayor = New System.Windows.Forms.ComboBox()
        Me.cboVMayor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSenator = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCouncilor1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCouncilor2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.txtMayor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVMayor = New System.Windows.Forms.TextBox()
        Me.txtSenator = New System.Windows.Forms.TextBox()
        Me.txtCouncilor1 = New System.Windows.Forms.TextBox()
        Me.txtCouncilor2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mayor"
        '
        'cboMayor
        '
        Me.cboMayor.FormattingEnabled = True
        Me.cboMayor.Location = New System.Drawing.Point(51, 134)
        Me.cboMayor.Name = "cboMayor"
        Me.cboMayor.Size = New System.Drawing.Size(211, 33)
        Me.cboMayor.TabIndex = 1
        '
        'cboVMayor
        '
        Me.cboVMayor.FormattingEnabled = True
        Me.cboVMayor.Location = New System.Drawing.Point(51, 241)
        Me.cboVMayor.Name = "cboVMayor"
        Me.cboVMayor.Size = New System.Drawing.Size(218, 33)
        Me.cboVMayor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vice Mayor"
        '
        'cboSenator
        '
        Me.cboSenator.FormattingEnabled = True
        Me.cboSenator.Location = New System.Drawing.Point(51, 340)
        Me.cboSenator.Name = "cboSenator"
        Me.cboSenator.Size = New System.Drawing.Size(218, 33)
        Me.cboSenator.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Senator"
        '
        'cboCouncilor1
        '
        Me.cboCouncilor1.FormattingEnabled = True
        Me.cboCouncilor1.Location = New System.Drawing.Point(51, 446)
        Me.cboCouncilor1.Name = "cboCouncilor1"
        Me.cboCouncilor1.Size = New System.Drawing.Size(211, 33)
        Me.cboCouncilor1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 409)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Councilors"
        '
        'cboCouncilor2
        '
        Me.cboCouncilor2.FormattingEnabled = True
        Me.cboCouncilor2.Location = New System.Drawing.Point(51, 508)
        Me.cboCouncilor2.Name = "cboCouncilor2"
        Me.cboCouncilor2.Size = New System.Drawing.Size(211, 33)
        Me.cboCouncilor2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CAST VOTE"
        '
        'btnVote
        '
        Me.btnVote.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVote.Location = New System.Drawing.Point(214, 595)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(147, 63)
        Me.btnVote.TabIndex = 10
        Me.btnVote.Text = "VOTE"
        Me.btnVote.UseVisualStyleBackColor = False
        '
        'txtMayor
        '
        Me.txtMayor.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtMayor.Location = New System.Drawing.Point(313, 134)
        Me.txtMayor.Name = "txtMayor"
        Me.txtMayor.ReadOnly = True
        Me.txtMayor.Size = New System.Drawing.Size(211, 31)
        Me.txtMayor.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Partylist Name"
        '
        'txtVMayor
        '
        Me.txtVMayor.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtVMayor.Location = New System.Drawing.Point(313, 241)
        Me.txtVMayor.Name = "txtVMayor"
        Me.txtVMayor.ReadOnly = True
        Me.txtVMayor.Size = New System.Drawing.Size(211, 31)
        Me.txtVMayor.TabIndex = 13
        '
        'txtSenator
        '
        Me.txtSenator.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtSenator.Location = New System.Drawing.Point(313, 342)
        Me.txtSenator.Name = "txtSenator"
        Me.txtSenator.ReadOnly = True
        Me.txtSenator.Size = New System.Drawing.Size(211, 31)
        Me.txtSenator.TabIndex = 14
        '
        'txtCouncilor1
        '
        Me.txtCouncilor1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCouncilor1.Location = New System.Drawing.Point(313, 448)
        Me.txtCouncilor1.Name = "txtCouncilor1"
        Me.txtCouncilor1.ReadOnly = True
        Me.txtCouncilor1.Size = New System.Drawing.Size(211, 31)
        Me.txtCouncilor1.TabIndex = 15
        '
        'txtCouncilor2
        '
        Me.txtCouncilor2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCouncilor2.Location = New System.Drawing.Point(313, 510)
        Me.txtCouncilor2.Name = "txtCouncilor2"
        Me.txtCouncilor2.ReadOnly = True
        Me.txtCouncilor2.Size = New System.Drawing.Size(211, 31)
        Me.txtCouncilor2.TabIndex = 16
        '
        'frmCastVote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 742)
        Me.Controls.Add(Me.txtCouncilor2)
        Me.Controls.Add(Me.txtCouncilor1)
        Me.Controls.Add(Me.txtSenator)
        Me.Controls.Add(Me.txtVMayor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMayor)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCouncilor2)
        Me.Controls.Add(Me.cboCouncilor1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboSenator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboVMayor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboMayor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCastVote"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboMayor As ComboBox
    Friend WithEvents cboVMayor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSenator As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCouncilor1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCouncilor2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVote As Button
    Friend WithEvents txtMayor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVMayor As TextBox
    Friend WithEvents txtSenator As TextBox
    Friend WithEvents txtCouncilor1 As TextBox
    Friend WithEvents txtCouncilor2 As TextBox
End Class
