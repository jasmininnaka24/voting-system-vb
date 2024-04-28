<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCandidatePartylist
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
        Me.txtPartylistID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvwPartylistGrp = New System.Windows.Forms.ListView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPartylistName = New System.Windows.Forms.TextBox()
        Me.cboMayorPos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCouncilorPos2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSenatorPos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCouncilorPos1 = New System.Windows.Forms.ComboBox()
        Me.cboVMayorPos = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPartylistID
        '
        Me.txtPartylistID.Location = New System.Drawing.Point(157, 62)
        Me.txtPartylistID.Name = "txtPartylistID"
        Me.txtPartylistID.Size = New System.Drawing.Size(226, 31)
        Me.txtPartylistID.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Partylist ID"
        '
        'lvwPartylistGrp
        '
        Me.lvwPartylistGrp.FullRowSelect = True
        Me.lvwPartylistGrp.GridLines = True
        Me.lvwPartylistGrp.Location = New System.Drawing.Point(47, 280)
        Me.lvwPartylistGrp.Name = "lvwPartylistGrp"
        Me.lvwPartylistGrp.Size = New System.Drawing.Size(714, 301)
        Me.lvwPartylistGrp.TabIndex = 61
        Me.lvwPartylistGrp.UseCompatibleStateImageBehavior = False
        Me.lvwPartylistGrp.View = System.Windows.Forms.View.Details
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 25)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Partylist Name"
        '
        'txtPartylistName
        '
        Me.txtPartylistName.Location = New System.Drawing.Point(55, 141)
        Me.txtPartylistName.Name = "txtPartylistName"
        Me.txtPartylistName.Size = New System.Drawing.Size(328, 31)
        Me.txtPartylistName.TabIndex = 65
        '
        'cboMayorPos
        '
        Me.cboMayorPos.FormattingEnabled = True
        Me.cboMayorPos.Location = New System.Drawing.Point(526, 54)
        Me.cboMayorPos.Name = "cboMayorPos"
        Me.cboMayorPos.Size = New System.Drawing.Size(235, 33)
        Me.cboMayorPos.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(457, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Mayor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Vice Mayor"
        '
        'cboCouncilorPos2
        '
        Me.cboCouncilorPos2.FormattingEnabled = True
        Me.cboCouncilorPos2.Location = New System.Drawing.Point(526, 218)
        Me.cboCouncilorPos2.Name = "cboCouncilorPos2"
        Me.cboCouncilorPos2.Size = New System.Drawing.Size(235, 33)
        Me.cboCouncilorPos2.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Senator"
        '
        'cboSenatorPos
        '
        Me.cboSenatorPos.FormattingEnabled = True
        Me.cboSenatorPos.Location = New System.Drawing.Point(134, 197)
        Me.cboSenatorPos.Name = "cboSenatorPos"
        Me.cboSenatorPos.Size = New System.Drawing.Size(249, 33)
        Me.cboSenatorPos.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(425, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Councilors"
        '
        'cboCouncilorPos1
        '
        Me.cboCouncilorPos1.FormattingEnabled = True
        Me.cboCouncilorPos1.Location = New System.Drawing.Point(526, 161)
        Me.cboCouncilorPos1.Name = "cboCouncilorPos1"
        Me.cboCouncilorPos1.Size = New System.Drawing.Size(235, 33)
        Me.cboCouncilorPos1.TabIndex = 72
        '
        'cboVMayorPos
        '
        Me.cboVMayorPos.FormattingEnabled = True
        Me.cboVMayorPos.Location = New System.Drawing.Point(526, 101)
        Me.cboVMayorPos.Name = "cboVMayorPos"
        Me.cboVMayorPos.Size = New System.Drawing.Size(235, 33)
        Me.cboVMayorPos.TabIndex = 74
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(65, 39)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(153, 48)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(65, 106)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(153, 48)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(65, 173)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(153, 48)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(65, 240)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(153, 48)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(65, 448)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 48)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(785, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 536)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        '
        'frmCandidatePartylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 617)
        Me.Controls.Add(Me.cboVMayorPos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCouncilorPos1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboSenatorPos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboCouncilorPos2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboMayorPos)
        Me.Controls.Add(Me.txtPartylistName)
        Me.Controls.Add(Me.txtPartylistID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lvwPartylistGrp)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmCandidatePartylist"
        Me.Text = "Candidate Partylist"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPartylistID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lvwPartylistGrp As ListView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPartylistName As TextBox
    Friend WithEvents cboMayorPos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCouncilorPos2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSenatorPos As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboCouncilorPos1 As ComboBox
    Friend WithEvents cboVMayorPos As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
