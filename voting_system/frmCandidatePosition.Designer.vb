<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCandidatePosition
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MAYORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VICEMAYORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SENATORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COUNCILORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MAYORToolStripMenuItem, Me.VICEMAYORToolStripMenuItem, Me.SENATORToolStripMenuItem, Me.COUNCILORToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1075, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MAYORToolStripMenuItem
        '
        Me.MAYORToolStripMenuItem.Name = "MAYORToolStripMenuItem"
        Me.MAYORToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.MAYORToolStripMenuItem.Text = "MAYOR"
        '
        'VICEMAYORToolStripMenuItem
        '
        Me.VICEMAYORToolStripMenuItem.Name = "VICEMAYORToolStripMenuItem"
        Me.VICEMAYORToolStripMenuItem.Size = New System.Drawing.Size(130, 29)
        Me.VICEMAYORToolStripMenuItem.Text = "VICE MAYOR"
        '
        'SENATORToolStripMenuItem
        '
        Me.SENATORToolStripMenuItem.Name = "SENATORToolStripMenuItem"
        Me.SENATORToolStripMenuItem.Size = New System.Drawing.Size(104, 29)
        Me.SENATORToolStripMenuItem.Text = "SENATOR"
        '
        'COUNCILORToolStripMenuItem
        '
        Me.COUNCILORToolStripMenuItem.Name = "COUNCILORToolStripMenuItem"
        Me.COUNCILORToolStripMenuItem.Size = New System.Drawing.Size(126, 29)
        Me.COUNCILORToolStripMenuItem.Text = "COUNCILOR"
        '
        'frmCandidatePosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 546)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCandidatePosition"
        Me.Text = "Candidate Position"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MAYORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VICEMAYORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SENATORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COUNCILORToolStripMenuItem As ToolStripMenuItem
End Class
