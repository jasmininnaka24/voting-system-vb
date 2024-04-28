Public Class frmMayorCandidate
    Dim flag As Integer

    Private Sub frmMayorCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()
        rs.Open("tblVote", con, 3, 3)
        Do Until rs.EOF()
            Me.cboMayorName.Items.Add(rs("candidateName").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        txtLock()
        lvwCol()
        lvw()
    End Sub

    Sub lvwCol()
        Me.lvwMayor.Columns.Clear()
        With Me.lvwMayor.Columns
            .Add("Candidate ID", 100)
            .Add("Mayor Candidates", 295)
        End With
    End Sub

    Sub lvw()
        Me.lvwMayor.Items.Clear()
        connect()
        rs.Open("tblMayor", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwMayor
                .Items.Add(rs.Fields("cands_id").Value)
                .Items(i).SubItems.Add(rs("mayor").Value)
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

        Me.cboMayorName.Enabled = False
        Me.txtCandidateID.Enabled = False
    End Sub

    Sub txtUnlock()
        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnDelete.Enabled = False

        Me.txtCandidateID.Enabled = False
        Me.cboMayorName.Enabled = True
    End Sub

    Sub txtClear()
        Me.cboMayorName.Text = ""
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
            rs.Open("select * from tblMayor where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 0 Then
                rs.AddNew()
                rs("cands_id").Value = Me.txtCandidateID.Text
                rs("mayor").Value = Me.cboMayorName.Text
                MessageBox.Show("Record is successfully saved!")
                rs.Update()
            Else
                MessageBox.Show("Record is already existing!")
            End If
            rs.Close()
        ElseIf flag = 2 Then
            rs.Open("select * from tblMayor where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Update()
                rs("cands_id").Value = Me.txtCandidateID.Text
                rs("mayor").Value = Me.cboMayorName.Text
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

    Private Sub lvwMayor_Click(sender As Object, e As EventArgs) Handles lvwMayor.Click
        With Me.lvwMayor
            Me.txtCandidateID.Text = .Items(.SelectedIndices(0)).Text
            Me.cboMayorName.Text = .Items(.SelectedIndices(0)).SubItems(1).Text
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
            rs.Open("select * from tblMayor where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
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

    Private Sub cboMayorName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMayorName.SelectedIndexChanged
        connect()
        rs.Open("select * from tblVote where candidateName = '" & Me.cboMayorName.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtCandidateID.Text = rs("cands_id").Value
        End If
        rs.Close()
        con.Close()
    End Sub
End Class