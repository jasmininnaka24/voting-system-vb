﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVMayorCandidate
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lvwVMayor = New System.Windows.Forms.ListView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboVMayorName = New System.Windows.Forms.ComboBox()
        Me.txtCandidateID = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Candidate ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(786, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 460)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(65, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 48)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(65, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(153, 48)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(65, 169)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(153, 48)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(65, 97)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(153, 48)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(65, 30)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(153, 48)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lvwVMayor
        '
        Me.lvwVMayor.FullRowSelect = True
        Me.lvwVMayor.GridLines = True
        Me.lvwVMayor.Location = New System.Drawing.Point(49, 190)
        Me.lvwVMayor.Name = "lvwVMayor"
        Me.lvwVMayor.Size = New System.Drawing.Size(714, 301)
        Me.lvwVMayor.TabIndex = 52
        Me.lvwVMayor.UseCompatibleStateImageBehavior = False
        Me.lvwVMayor.View = System.Windows.Forms.View.Details
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(293, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 25)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Vice Mayor Name"
        '
        'cboVMayorName
        '
        Me.cboVMayorName.FormattingEnabled = True
        Me.cboVMayorName.Location = New System.Drawing.Point(293, 128)
        Me.cboVMayorName.Name = "cboVMayorName"
        Me.cboVMayorName.Size = New System.Drawing.Size(470, 33)
        Me.cboVMayorName.TabIndex = 55
        '
        'txtCandidateID
        '
        Me.txtCandidateID.Location = New System.Drawing.Point(49, 130)
        Me.txtCandidateID.Name = "txtCandidateID"
        Me.txtCandidateID.Size = New System.Drawing.Size(194, 31)
        Me.txtCandidateID.TabIndex = 58
        '
        'frmVMayorCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 571)
        Me.Controls.Add(Me.txtCandidateID)
        Me.Controls.Add(Me.cboVMayorName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lvwVMayor)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmVMayorCandidate"
        Me.Text = "Vice Mayor Candidate"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lvwVMayor As ListView
    Friend WithEvents Label8 As Label
    Friend WithEvents cboVMayorName As ComboBox
    Friend WithEvents txtCandidateID As TextBox
End Class
