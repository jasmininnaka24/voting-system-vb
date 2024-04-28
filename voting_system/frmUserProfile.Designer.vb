<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserProfile
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
        Me.txtVoterID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVoterName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVoterSection = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVoterYear = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Profile"
        '
        'txtVoterID
        '
        Me.txtVoterID.Location = New System.Drawing.Point(58, 107)
        Me.txtVoterID.Name = "txtVoterID"
        Me.txtVoterID.Size = New System.Drawing.Size(150, 31)
        Me.txtVoterID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'txtVoterName
        '
        Me.txtVoterName.Location = New System.Drawing.Point(249, 107)
        Me.txtVoterName.Name = "txtVoterName"
        Me.txtVoterName.Size = New System.Drawing.Size(342, 31)
        Me.txtVoterName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(393, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Section"
        '
        'txtVoterSection
        '
        Me.txtVoterSection.Location = New System.Drawing.Point(249, 189)
        Me.txtVoterSection.Name = "txtVoterSection"
        Me.txtVoterSection.Size = New System.Drawing.Size(342, 31)
        Me.txtVoterSection.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Year"
        '
        'txtVoterYear
        '
        Me.txtVoterYear.Location = New System.Drawing.Point(58, 189)
        Me.txtVoterYear.Name = "txtVoterYear"
        Me.txtVoterYear.Size = New System.Drawing.Size(150, 31)
        Me.txtVoterYear.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Location = New System.Drawing.Point(150, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 34)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnEdit.Location = New System.Drawing.Point(371, 319)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(112, 34)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'frmUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 432)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVoterSection)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVoterYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVoterName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVoterID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUserProfile"
        Me.Text = "frmUserProfile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtVoterID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVoterName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVoterSection As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVoterYear As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
End Class
