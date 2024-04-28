Public Class Form1
    Private Sub CandidatesIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CandidatesIDToolStripMenuItem.Click
        Dim candidateID As New frmCandidateID
        candidateID.ShowDialog()
    End Sub

    Private Sub CandidatesPositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CandidatesPositionToolStripMenuItem.Click
        Dim candidatePosition As New frmCandidatePosition
        candidatePosition.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CandidatesPartylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CandidatesPartylistToolStripMenuItem.Click
        Dim candidatePartylist As New frmCandidatePartylist
        candidatePartylist.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mayor
        colMayor()
        showDashMayor()
        'vice mayor
        colVMayor()
        showDashVMayor()
        'senator
        colSenator()
        showDashSenator()
        'councilor1
        colCouncilor1()
        showDashCouncilor1()
        'councilor2
        colCouncilor2()
        showDashCouncilor2()
    End Sub

    'mayor
    Sub colMayor()
        Me.lvwUserDashMayor.Columns.Clear()
        With Me.lvwUserDashMayor.Columns
            .Add("Position", 100)
            .Add("Candidate Name", 173)
            .Add("Partylist Name", 150)
            .Add("Number of Votes", 50)
        End With
    End Sub

    Sub showDashMayor()
        Me.lvwUserDashMayor.Items.Clear()
        connect()
        rs.Open("select * from tblCastVoteMayor ", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwUserDashMayor
                .Items.Add(rs.Fields("position").Value)
                .Items(i).SubItems.Add(rs("mayorName").Value)
                .Items(i).SubItems.Add(rs("partylistName").Value)
                .Items(i).SubItems.Add(rs("vote_count").Value)
            End With
            i += 1
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub

    'vice mayor
    Sub colVMayor()
        Me.lvwUserDashVMayor.Columns.Clear()
        With Me.lvwUserDashVMayor.Columns
            .Add("Position", 100)
            .Add("Candidate Name", 173)
            .Add("Partylist Name", 150)
            .Add("Number of Votes", 50)
        End With
    End Sub

    Sub showDashVMayor()
        Me.lvwUserDashVMayor.Items.Clear()
        connect()
        rs.Open("select * from tblCastVoteVMayor ", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwUserDashVMayor
                .Items.Add(rs.Fields("position").Value)
                .Items(i).SubItems.Add(rs("vmayorName").Value)
                .Items(i).SubItems.Add(rs("partylistName").Value)
                .Items(i).SubItems.Add(rs("vote_count").Value)
            End With
            i += 1
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub


    'senator
    Sub colSenator()
        Me.lvwUserDashSenator.Columns.Clear()
        With Me.lvwUserDashSenator.Columns
            .Add("Position", 100)
            .Add("Candidate Name", 173)
            .Add("Partylist Name", 150)
            .Add("Number of Votes", 50)
        End With
    End Sub

    Sub showDashSenator()
        Me.lvwUserDashSenator.Items.Clear()
        connect()
        rs.Open("select * from tblCastVoteSenator ", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwUserDashSenator
                .Items.Add(rs.Fields("position").Value)
                .Items(i).SubItems.Add(rs("senatorName").Value)
                .Items(i).SubItems.Add(rs("partylistName").Value)
                .Items(i).SubItems.Add(rs("vote_count").Value)
            End With
            i += 1
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub

    'councilor1
    Sub colCouncilor1()
        Me.lvwUserDashCouncilor1.Columns.Clear()
        With Me.lvwUserDashCouncilor1.Columns
            .Add("Position", 100)
            .Add("Candidate Name", 173)
            .Add("Partylist Name", 150)
            .Add("Number of Votes", 50)
        End With
    End Sub

    Sub showDashCouncilor1()
        Me.lvwUserDashCouncilor1.Items.Clear()
        connect()
        rs.Open("select * from tblCastVoteCouncilor1 ", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwUserDashCouncilor1
                .Items.Add(rs.Fields("position").Value)
                .Items(i).SubItems.Add(rs("councilor1Name").Value)
                .Items(i).SubItems.Add(rs("partylistName").Value)
                .Items(i).SubItems.Add(rs("vote_count").Value)
            End With
            i += 1
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub

    'councilor2
    Sub colCouncilor2()
        Me.lvwUserDashCouncilor2.Columns.Clear()
        With Me.lvwUserDashCouncilor2.Columns
            .Add("Position", 100)
            .Add("Candidate Name", 173)
            .Add("Partylist Name", 150)
            .Add("Number of Votes", 50)
        End With
    End Sub

    Sub showDashCouncilor2()
        Me.lvwUserDashCouncilor2.Items.Clear()
        connect()
        rs.Open("select * from tblCastVoteCouncilor2 ", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwUserDashCouncilor2
                .Items.Add(rs.Fields("position").Value)
                .Items(i).SubItems.Add(rs("councilor2Name").Value)
                .Items(i).SubItems.Add(rs("partylistName").Value)
                .Items(i).SubItems.Add(rs("vote_count").Value)
            End With
            i += 1
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        'mayor
        colMayor()
        showDashMayor()
        'vice mayor
        colVMayor()
        showDashVMayor()
        'senator
        colSenator()
        showDashSenator()
        'councilor1
        colCouncilor1()
        showDashCouncilor1()
        'councilor2
        colCouncilor2()
        showDashCouncilor2()
    End Sub
End Class
