Public Class frmSenatorCandidate
    Dim flag As Integer
    Private Sub frmSenatorCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        rs.Open("tblVote", con, 3, 3)
        Do Until rs.EOF()
            Me.cboSenatorName.Items.Add(rs("candidateName").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        txtLock()
        lvwCol()
        lvw()
    End Sub

    Sub lvwCol()
        Me.lvwSenator.Columns.Clear()
        With Me.lvwSenator.Columns
            .Add("Candidate ID", 100)
            .Add("Senator Candidates", 295)
        End With
    End Sub

    Sub lvw()
        Me.lvwSenator.Items.Clear()
        connect()
        rs.Open("tblSenator", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwSenator
                .Items.Add(rs.Fields("cands_id").Value)
                .Items(i).SubItems.Add(rs("senator").Value)
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

        Me.cboSenatorName.Enabled = False
        Me.txtCandidateID.Enabled = False
    End Sub

    Sub txtUnlock()
        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnDelete.Enabled = False

        Me.txtCandidateID.Enabled = False
        Me.cboSenatorName.Enabled = True
    End Sub

    Sub txtClear()
        Me.cboSenatorName.Text = ""
        Me.txtCandidateID.Text = ""

        txtLock()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) 
        flag = 2
        txtUnlock()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        flag = 1
        txtUnlock()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        connect()
        If flag = 1 Then
            rs.Open("select * from tblSenator where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 0 Then
                rs.AddNew()
                rs("cands_id").Value = Me.txtCandidateID.Text
                rs("senator").Value = Me.cboSenatorName.Text
                MessageBox.Show("Record is successfully saved!")
                rs.Update()
            Else
                MessageBox.Show("Record is already existing!")
            End If
            rs.Close()
        ElseIf flag = 2 Then
            rs.Open("select * from tblSenator where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Update()
                rs("cands_id").Value = Me.txtCandidateID.Text
                rs("senator").Value = Me.cboSenatorName.Text
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

    Private Sub lvwSenator_Click(sender As Object, e As EventArgs) Handles lvwSenator.Click
        With Me.lvwSenator
            Me.txtCandidateID.Text = .Items(.SelectedIndices(0)).Text
            Me.cboSenatorName.Text = .Items(.SelectedIndices(0)).SubItems(1).Text
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
            rs.Open("select * from tblSenator where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'mayor 
            rs.Open("select * from tblCastVoteMayor", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'vice mayor 
            rs.Open("select * from tblCastVoteVMayor", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'senator 
            rs.Open("select * from tblCastVoteSenator", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'councilor 
            rs.Open("select * from tblCastVoteCouncilor1", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'councilor2
            rs.Open("select * from tblCastVoteCouncilor2", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            MessageBox.Show("Record is successfully deleted!")
            con.Close()
            lvw()
            txtLock()
            txtClear()

        End If
    End Sub

    Private Sub cboSenatorName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSenatorName.SelectedIndexChanged
        connect()
        rs.Open("select * from tblVote where candidateName = '" & Me.cboSenatorName.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtCandidateID.Text = rs("cands_id").Value
        End If
        rs.Close()
        con.Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class