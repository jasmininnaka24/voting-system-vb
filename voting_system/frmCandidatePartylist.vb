Public Class frmCandidatePartylist

    Dim flag As Integer
    Private Sub frmCandidatePartylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drpMenu()
        txtLock()
        lvwCol()
        lvw()
    End Sub

    Sub drpMenu()
        'mayor
        connect()
        rs.Open("tblMayor", con, 3, 3)
        Do Until rs.EOF()
            Me.cboMayorPos.Items.Add(rs("mayor").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        'vice mayor
        connect()
        rs.Open("tblVMayor", con, 3, 3)
        Do Until rs.EOF()
            Me.cboVMayorPos.Items.Add(rs("vmayor").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        'senator
        connect()
        rs.Open("tblSenator", con, 3, 3)
        Do Until rs.EOF()
            Me.cboSenatorPos.Items.Add(rs("senator").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        'councilors
        connect()
        rs.Open("tblCouncilor", con, 3, 3)
        Do Until rs.EOF()
            Me.cboCouncilorPos1.Items.Add(rs("councilor").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        connect()
        rs.Open("tblCouncilor", con, 3, 3)
        Do Until rs.EOF()
            Me.cboCouncilorPos2.Items.Add(rs("councilor").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub

    Sub lvwCol()
        Me.lvwPartylistGrp.Columns.Clear()
        With Me.lvwPartylistGrp.Columns
            .Add("Partylist ID", 100)
            .Add("Partylist Name", 150)
            .Add("Mayor Candidates", 150)
            .Add("Vice Mayor Candidates", 150)
            .Add("Senator Candidates", 150)
            .Add("Councilor Candidates", 150)
            .Add("Councilor Candidates", 150)
        End With
    End Sub

    Sub lvw()
        Me.lvwPartylistGrp.Items.Clear()
        connect()
        rs.Open("tblPartylistGrp", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF()
            With Me.lvwPartylistGrp
                .Items.Add(rs.Fields("partylist_id").Value)
                .Items(i).SubItems.Add(rs("partylistName").Value)
                .Items(i).SubItems.Add(rs("mayor").Value)
                .Items(i).SubItems.Add(rs("vmayor").Value)
                .Items(i).SubItems.Add(rs("senator").Value)
                .Items(i).SubItems.Add(rs("councilor1").Value)
                .Items(i).SubItems.Add(rs("councilor2").Value)
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

        Me.txtPartylistID.Enabled = False
        Me.txtPartylistName.Enabled = False
        Me.cboMayorPos.Enabled = False
        Me.cboVMayorPos.Enabled = False
        Me.cboSenatorPos.Enabled = False
        Me.cboCouncilorPos1.Enabled = False
        Me.cboCouncilorPos2.Enabled = False
    End Sub

    Sub txtUnlock()
        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnDelete.Enabled = False

        Me.txtPartylistID.Enabled = True
        Me.txtPartylistName.Enabled = True
        Me.cboMayorPos.Enabled = True
        Me.cboVMayorPos.Enabled = True
        Me.cboSenatorPos.Enabled = True
        Me.cboCouncilorPos1.Enabled = True
        Me.cboCouncilorPos2.Enabled = True
    End Sub

    Sub txtClear()
        Me.txtPartylistID.Text = ""
        Me.txtPartylistName.Text = ""
        Me.cboMayorPos.Text = ""
        Me.cboVMayorPos.Text = ""
        Me.cboSenatorPos.Text = ""
        Me.cboCouncilorPos1.Text = ""
        Me.cboCouncilorPos2.Text = ""

        txtLock()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        flag = 2
        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnDelete.Enabled = False

        Me.txtPartylistID.Enabled = True
        Me.txtPartylistName.Enabled = True
        Me.cboMayorPos.Enabled = False
        Me.cboVMayorPos.Enabled = False
        Me.cboSenatorPos.Enabled = False
        Me.cboCouncilorPos1.Enabled = False
        Me.cboCouncilorPos2.Enabled = False
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
            rs.Open("select * from tblPartylistGrp where partylist_id = '" & Me.txtPartylistID.Text & "'", con, 3, 3)
            If rs.RecordCount = 0 Then
                rs.AddNew()
                rs("partylist_id").Value = Me.txtPartylistID.Text
                rs("partylistName").Value = Me.txtPartylistName.Text
                rs("mayor").Value = Me.cboMayorPos.Text
                rs("vmayor").Value = Me.cboVMayorPos.Text
                rs("senator").Value = Me.cboSenatorPos.Text
                rs("councilor1").Value = Me.cboCouncilorPos1.Text
                rs("councilor2").Value = Me.cboCouncilorPos2.Text
                MessageBox.Show("Record is successfully saved!")
                rs.Update()
            Else
                MessageBox.Show("Record is already existing!")
            End If
            rs.Close()
        ElseIf flag = 2 Then
            rs.Open("select * from tblPartylistGrp where partylist_id = '" & Me.txtPartylistID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Update()
                rs("partylist_id").Value = Me.txtPartylistID.Text
                rs("partylistName").Value = Me.txtPartylistName.Text
                rs("mayor").Value = Me.cboMayorPos.Text
                rs("vmayor").Value = Me.cboVMayorPos.Text
                rs("senator").Value = Me.cboSenatorPos.Text
                rs("councilor1").Value = Me.cboCouncilorPos1.Text
                rs("councilor2").Value = Me.cboCouncilorPos2.Text
                MessageBox.Show("Record is successfully edited!")
                rs.Update()
            End If
            rs.Close()
        End If
        'mayor
        rs.Open("select * from tblCastVoteMayor where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("mayorName").Value = Me.cboMayorPos.Text
            rs("position").Value = "MAYOR"
            rs("partylistName").Value = Me.txtPartylistName.Text
            rs("vote_count").Value = 0
            rs.Update()

        End If
        rs.Close()
        'vice mayor
        rs.Open("select * from tblCastVoteVMayor where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("vmayorName").Value = Me.cboVMayorPos.Text
            rs("position").Value = "VICE MAYOR"
            rs("partylistName").Value = Me.txtPartylistName.Text
            rs("vote_count").Value = 0
            rs.Update()
        End If
        rs.Close()
        'senator
        rs.Open("select * from tblCastVoteSenator where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("senatorName").Value = Me.cboSenatorPos.Text
            rs("position").Value = "SENATOR"
            rs("partylistName").Value = Me.txtPartylistName.Text
            rs("vote_count").Value = 0
            rs.Update()
        End If
        rs.Close()
        'councilor 1
        rs.Open("select * from tblCastVoteCouncilor1 where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("councilor1Name").Value = Me.cboCouncilorPos1.Text
            rs("position").Value = "COUNCILOR"
            rs("partylistName").Value = Me.txtPartylistName.Text
            rs("vote_count").Value = 0
            rs.Update()
        End If
        rs.Close()
        'councilor 2
        rs.Open("select * from tblCastVoteCouncilor2 where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("councilor2Name").Value = Me.cboCouncilorPos2.Text
            rs("position").Value = "COUNCILOR"
            rs("partylistName").Value = Me.txtPartylistName.Text
            rs("vote_count").Value = 0
            rs.Update()
        End If
        rs.Close()
        con.Close()
        lvw()
        txtLock()
        txtClear()
    End Sub

    Private Sub lvwVMayor_Click(sender As Object, e As EventArgs) Handles lvwPartylistGrp.Click
        With Me.lvwPartylistGrp
            Me.txtPartylistID.Text = .Items(.SelectedIndices(0)).Text
            Me.txtPartylistName.Text = .Items(.SelectedIndices(0)).SubItems(1).Text
            Me.cboMayorPos.Text = .Items(.SelectedIndices(0)).SubItems(2).Text
            Me.cboVMayorPos.Text = .Items(.SelectedIndices(0)).SubItems(3).Text
            Me.cboSenatorPos.Text = .Items(.SelectedIndices(0)).SubItems(4).Text
            Me.cboCouncilorPos1.Text = .Items(.SelectedIndices(0)).SubItems(5).Text
            Me.cboCouncilorPos2.Text = .Items(.SelectedIndices(0)).SubItems(6).Text
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
            rs.Open("select * from tblPartylistGrp where partylist_id = '" & Me.txtPartylistID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'mayor
            rs.Open("select * from tblCastVoteMayor where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'vice mayor
            rs.Open("select * from tblCastVoteVMayor where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'senator
            rs.Open("select * from tblCastVoteSenator where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'councilor 1
            rs.Open("select * from tblCastVoteCouncilor1 where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Delete()
            End If
            rs.Close()
            'councilor2
            rs.Open("select * from tblCastVoteCouncilor2 where partylistName = '" & Me.txtPartylistName.Text & "'", con, 3, 3)
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

    Private Sub txtPartylistID_TextChanged(sender As Object, e As EventArgs) Handles txtPartylistID.TextChanged
        connect()
        rs.Open("select * from tblPartylistGrp where partylist_id = '" & Me.txtPartylistID.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtPartylistName.Text = rs("partylistName").Value
            Me.cboMayorPos.Text = rs("mayor").Value
            Me.cboVMayorPos.Text = rs("vmayor").Value
            Me.cboSenatorPos.Text = rs("senator").Value
            Me.cboCouncilorPos1.Text = rs("councilor1").Value
            Me.cboCouncilorPos2.Text = rs("councilor2").Value
        End If
        rs.Close()
        con.Close()
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class