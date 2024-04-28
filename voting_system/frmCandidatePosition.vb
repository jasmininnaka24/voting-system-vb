Public Class frmCandidatePosition
    Private Sub MAYORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAYORToolStripMenuItem.Click
        Dim mayorCandidate As New frmMayorCandidate
        mayorCandidate.ShowDialog()
    End Sub

    Private Sub VICEMAYORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VICEMAYORToolStripMenuItem.Click
        Dim vmayorCandidate As New frmVMayorCandidate
        vmayorCandidate.ShowDialog()
    End Sub

    Private Sub SENATORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SENATORToolStripMenuItem.Click
        Dim senatorCandidate As New frmSenatorCandidate
        senatorCandidate.ShowDialog()
    End Sub

    Private Sub COUNCILORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COUNCILORToolStripMenuItem.Click
        Dim councilorCandidate As New frmCouncilorCandidate
        councilorCandidate.ShowDialog()
    End Sub

    Private Sub frmCandidatePosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class