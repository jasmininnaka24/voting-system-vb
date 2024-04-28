Public Class frmCandidateID

    Dim flag As Integer

    Private Sub frmCandidateID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLock()
        lvwCol()
        lvw()
    End Sub

    Sub lvwCol()
        Me.lvwCandidateID.Columns.Clear()
        With Me.lvwCandidateID.Columns
            .Add("Candidate ID", 100)
            .Add("Candidate Name", 295)
            .Add("Vote Count", 195)
        End With
    End Sub

    Sub lvw()
        Me.lvwCandidateID.Items.Clear()
        connect()
        rs.Open("tblVote", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwCandidateID
                .Items.Add(rs.Fields("cands_id").Value)
                .Items(i).SubItems.Add(rs("candidateName").Value)
                .Items(i).SubItems.Add(rs("vote_count").Value)
            End With
            i += 1
            rs.MoveNext()

        Loop
        rs.Close()
        con.Close()
    End Sub

    Sub txtLock()
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False

        Me.txtCandidateID.Enabled = False
        Me.txtCandidateName.Enabled = False
        Me.voteCount.Enabled = False
    End Sub

    Sub txtUnlock()
        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnDelete.Enabled = False

        Me.txtCandidateID.Enabled = True
        Me.txtCandidateName.Enabled = True
        Me.voteCount.Enabled = True
    End Sub

    Sub txtClear()
        Me.txtCandidateID.Text = ""
        Me.txtCandidateName.Text = ""
        Me.voteCount.Text = ""

        txtLock()

    End Sub

    Private Sub txtCandidateID_TextChanged(sender As Object, e As EventArgs) Handles txtCandidateID.TextChanged
        connect()
        rs.Open("select * from tblVote where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtCandidateName.Text = rs("candidateName").Value
            Me.voteCount.Text = rs("vote_count").Value
        End If
        rs.Close()
        con.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        flag = 1
        txtUnlock()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) 
        flag = 2
        txtUnlock()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        connect()
        If flag = 1 Then
            rs.Open("select * from tblVote where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 0 Then
                rs.AddNew()
                rs("cands_id").Value = Me.txtCandidateID.Text
                rs("candidateName").Value = Me.txtCandidateName.Text
                rs("vote_count").Value = Me.voteCount.Text
                MessageBox.Show("Record is successfully saved!")
                rs.Update()
            Else
                MessageBox.Show("Record is already existing!")
            End If
            rs.Close()
        ElseIf flag = 2 Then
            rs.Open("select * from tblVote where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Update()
                rs("cands_id").Value = Me.txtCandidateID.Text
                rs("candidateName").Value = Me.txtCandidateName.Text
                rs("vote_count").Value = Me.voteCount.Text
                MessageBox.Show("Record is successfully edited!")
                rs.Update()
            End If
            rs.Close()
        End If
        con.Close()
        lvw()
        txtLock()
        txtClear()
    End Sub

    Private Sub lvwCandidateID_Click(sender As Object, e As EventArgs) Handles lvwCandidateID.Click
        With Me.lvwCandidateID
            Me.txtCandidateID.Text = .Items(.SelectedIndices(0)).Text
            Me.txtCandidateName.Text = .Items(.SelectedIndices(0)).SubItems(1).Text
            Me.voteCount.Text = .Items(.SelectedIndices(0)).SubItems(2).Text
        End With
        txtLock()
        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim delFile As String
        delFile = (MessageBox.Show("Are you sure??", "Deleting a record", MessageBoxButtons.YesNo))
        If delFile = vbYes Then
            connect()
            rs.Open("select * from tblVote where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
                MessageBox.Show("Record is successfully deleted!")
            End If
            rs.Close()
            'mayor
            rs.Open("select * from tblCastVoteMayor where mayorName = '" & Me.txtCandidateName.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'vice mayor
            rs.Open("select * from tblCastVoteVMayor where vmayorName = '" & Me.txtCandidateName.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'senator
            rs.Open("select * from tblCastVoteSenator where senatorName = '" & Me.txtCandidateName.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'councilor 1
            rs.Open("select * from tblCastVoteCouncilor1 where councilor1Name = '" & Me.txtCandidateName.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'councilor2
            rs.Open("select * from tblCastVoteCouncilor2 where councilor2Name = '" & Me.txtCandidateName.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            con.Close()
            lvw()
            txtLock()
            txtClear()

        End If
    End Sub
End Class