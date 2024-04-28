Public Class frmCastVote

    Dim flag As Integer

    Private Sub frmCastVote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropMenu()
    End Sub

    Sub dropMenu()
        'mayor
        connect()
        rs.Open("tblPartylistGrp", con, 3, 3)
        Do Until rs.EOF()
            Me.cboMayor.Items.Add(rs("mayor").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        'vice mayor
        connect()
        rs.Open("tblPartylistGrp", con, 3, 3)
        Do Until rs.EOF()
            Me.cboVMayor.Items.Add(rs("vmayor").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        'senator
        connect()
        rs.Open("tblPartylistGrp", con, 3, 3)
        Do Until rs.EOF()
            Me.cboSenator.Items.Add(rs("senator").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        'councilors
        connect()
        rs.Open("tblPartylistGrp", con, 3, 3)
        Do Until rs.EOF()
            Me.cboCouncilor1.Items.Add(rs("councilor1").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        connect()
        rs.Open("tblPartylistGrp", con, 3, 3)
        Do Until rs.EOF()
            Me.cboCouncilor2.Items.Add(rs("councilor2").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub

    Private Sub cboMayor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMayor.SelectedIndexChanged
        connect()
        rs.Open("select * from tblPartylistGrp where mayor = '" & Me.cboMayor.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtMayor.Text = rs("partylistName").Value
        End If
        rs.Close()
        con.Close()
    End Sub

    Private Sub cboVMayor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVMayor.SelectedIndexChanged
        connect()
        rs.Open("select * from tblPartylistGrp where vmayor = '" & Me.cboVMayor.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtVMayor.Text = rs("partylistName").Value
        End If
        rs.Close()
        con.Close()
    End Sub

    Private Sub cboSenator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSenator.SelectedIndexChanged
        connect()
        rs.Open("select * from tblPartylistGrp where senator = '" & Me.cboSenator.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtSenator.Text = rs("partylistName").Value
        End If
        rs.Close()
        con.Close()
    End Sub

    Private Sub cboCouncilor1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCouncilor1.SelectedIndexChanged
        connect()
        rs.Open("select * from tblPartylistGrp where councilor1 = '" & Me.cboCouncilor1.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtCouncilor1.Text = rs("partylistName").Value
        End If
        rs.Close()
        con.Close()
    End Sub

    Private Sub cboCouncilor2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCouncilor2.SelectedIndexChanged
        connect()
        rs.Open("select * from tblPartylistGrp where councilor2 = '" & Me.cboCouncilor2.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Me.txtCouncilor2.Text = rs("partylistName").Value
        End If
        rs.Close()
        con.Close()
    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        connect()
        'mayor

        rs.Open("select * from tblCastVoteMayor where mayorName = '" & Me.cboMayor.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("mayorName").Value = Me.cboMayor.Text
            rs("position").Value = "MAYOR"
            rs("partylistName").Value = Me.txtMayor.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        ElseIf rs.RecordCount > 0 Then
            rs.Update()
            rs("mayorName").Value = Me.cboMayor.Text
            rs("position").Value = "MAYOR"
            rs("partylistName").Value = Me.txtMayor.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        End If

        rs.Close()

        'vice mayor
        rs.Open("select * from tblCastVoteVMayor where vmayorName = '" & Me.cboVMayor.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("vmayorName").Value = Me.cboVMayor.Text
            rs("position").Value = "VICE MAYOR"
            rs("partylistName").Value = Me.txtVMayor.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        ElseIf rs.RecordCount > 0 Then
            rs.Update()
            rs("vmayorName").Value = Me.cboVMayor.Text
            rs("position").Value = "VICE MAYOR"
            rs("partylistName").Value = Me.txtVMayor.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        End If
        rs.Close()

        'senator
        rs.Open("select * from tblCastVoteSenator where senatorName = '" & Me.cboSenator.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("senatorName").Value = Me.cboSenator.Text
            rs("position").Value = "SENATOR"
            rs("partylistName").Value = Me.txtSenator.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        ElseIf rs.RecordCount > 0 Then
            rs.Update()
            rs("senatorName").Value = Me.cboSenator.Text
            rs("position").Value = "SENATOR"
            rs("partylistName").Value = Me.txtSenator.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        End If
        rs.Close()

        'councilor 1
        rs.Open("select * from tblCastVoteCouncilor1 where councilor1Name = '" & Me.cboCouncilor1.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("councilor1Name").Value = Me.cboCouncilor1.Text
            rs("position").Value = "COUNCILOR"
            rs("partylistName").Value = Me.txtCouncilor1.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        ElseIf rs.RecordCount > 0 Then
            rs.Update()
            rs("councilor1Name").Value = Me.cboCouncilor1.Text
            rs("position").Value = "COUNCILOR"
            rs("partylistName").Value = Me.txtCouncilor1.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        End If
        rs.Close()

        'councilor 2
        rs.Open("select * from tblCastVoteCouncilor2 where councilor2Name = '" & Me.cboCouncilor2.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs("councilor2Name").Value = Me.cboCouncilor2.Text
            rs("position").Value = "COUNCILOR"
            rs("partylistName").Value = Me.txtCouncilor2.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        ElseIf rs.RecordCount > 0 Then
            rs.Update()
            rs("councilor2Name").Value = Me.cboCouncilor2.Text
            rs("position").Value = "COUNCILOR"
            rs("partylistName").Value = Me.txtCouncilor2.Text
            rs("vote_count").Value = rs("vote_count").Value + 1
            rs.Update()
        End If
        rs.Close()
        con.Close()
        MessageBox.Show("Record is successfully saved!")
        txtClear()
        lock()
        Me.btnVote.Enabled = False

    End Sub

    Sub txtClear()
        Me.cboMayor.Text = ""
        Me.cboVMayor.Text = ""
        Me.cboSenator.Text = ""
        Me.cboCouncilor1.Text = ""
        Me.cboCouncilor2.Text = ""

        Me.txtMayor.Text = ""
        Me.txtVMayor.Text = ""
        Me.txtSenator.Text = ""
        Me.txtCouncilor1.Text = ""
        Me.txtCouncilor2.Text = ""
    End Sub

    Sub lock()
        Me.cboMayor.Enabled = False
        Me.cboVMayor.Enabled = False
        Me.cboSenator.Enabled = False
        Me.cboCouncilor1.Enabled = False
        Me.cboCouncilor2.Enabled = False

        Me.txtMayor.Enabled = False
        Me.txtVMayor.Enabled = False
        Me.txtSenator.Enabled = False
        Me.txtCouncilor1.Enabled = False
        Me.txtCouncilor2.Enabled = False
    End Sub
End Class