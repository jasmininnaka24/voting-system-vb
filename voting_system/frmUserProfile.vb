Public Class frmUserProfile
    Dim flag As Integer
    Private Sub frmUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        connect()
        If flag = 1 Then
            rs.Open("select * from tblVoterProfile where voter_id = '" & Me.txtVoterID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Update()
                rs("voter_id").Value = Me.txtVoterID.Text
                rs("voterName").Value = Me.txtVoterName.Text
                rs("voterSection").Value = Me.txtVoterSection.Text
                rs("voterYear").Value = Me.txtVoterYear.Text
                MessageBox.Show("Record is successfully edited!")
                rs.Update()
            End If
            rs.Close()
        Else
            rs.Open("select * from tblVoterProfile where voter_id = '" & Me.txtVoterID.Text & "'", con, 3, 3)
            If rs.RecordCount = 0 Then
                rs.AddNew()
                rs("voter_id").Value = Me.txtVoterID.Text
                rs("voterName").Value = Me.txtVoterName.Text
                rs("voterSection").Value = Me.txtVoterSection.Text
                rs("voterYear").Value = Me.txtVoterYear.Text
                MessageBox.Show("Record is successfully saved!")
                rs.Update()
            Else
                MessageBox.Show("Record is already existing!")
            End If
            rs.Close()
        End If
        con.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        flag = 1
    End Sub
End Class