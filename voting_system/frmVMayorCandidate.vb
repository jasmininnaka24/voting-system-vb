Public Class frmVMayorCandidate
    Dim flag As Integer
    Private Sub frmVMayorCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()
        rs.Open("tblVote", con, 3, 3)
        Do Until rs.EOF()
            Me.cboVMayorName.Items.Add(rs("candidateName").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        txtLock()
        lvwCol()
        lvw()
    End Sub

    Sub lvwCol()
        Me.lvwVMayor.Columns.Clear()
        With Me.lvwVMayor.Columns
            .Add("Candidate ID", 100)
            .Add("Vice Mayor Candidates", 295)
        End With
    End Sub

    Sub lvw()
        Me.lvwVMayor.Items.Clear()
        connect()
        rs.Open("tblVMayor", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwVMayor
                .Items.Add(rs.Fields("cands_id").Value)
                .Items(i).SubItems.Add(rs("vmayor").Value)
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
        Me.cboVMayorName.Enabled = False
    End Sub

    Sub txtUnlock()
        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnDelete.Enabled = False

        Me.txtCandidateID.Enabled = False
        Me.cboVMayorName.Enabled = True
    End Sub

    Sub txtClear()
        Me.txtCandidateID.Text = ""
        Me.cboVMayorName.Text = ""

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
            rs.Open("select * from tblVMayor where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 0 Then
                rs.AddNew()
                rs("cands_id").Value = Me.txtCandidateID.Text
                rs("vmayor").Value = Me.cboVMayorName.Text
                MessageBox.Show("Record is successfully saved!")
                rs.Update()
            Else
                MessageBox.Show("Record is already existing!")
            End If
            rs.Close()
        ElseIf flag = 2 Then
            rs.Open("select * from tblVMayor where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Update()
                rs("cands_id").Value = Me.txtCandidateID.Text
                rs("vmayor").Value = Me.cboVMayorName.Text
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

    Private Sub lvwVMayor_Click(sender As Object, e As EventArgs) Handles lvwVMayor.Click
        With Me.lvwVMayor
            Me.txtCandidateID.Text = .Items(.SelectedIndices(0)).Text
            Me.cboVMayorName.Text = .Items(.SelectedIndices(0)).SubItems(1).Text
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
            rs.Open("select * from tblVMayor where cands_id = '" & Me.txtCandidateID.Text & "'", con, 3, 3)
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

    Private Sub cboVMayorName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVMayorName.SelectedIndexChanged
        connect()
        rs.Open("select * from tblVote where candidateName = '" & Me.cboVMayorName.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtCandidateID.Text = rs("cands_id").Value
        End If
        rs.Close()
        con.Close()
    End Sub


End Class