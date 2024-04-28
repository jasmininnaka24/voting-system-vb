Public Class frmLogin
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        'connect()
        'rs.Open("select * from tblVoterSignIn_Up where voter_id = '" & Me.txtvoterID.Text & "' and password = '" & Me.txtVoterPassword.Text & "'", con, 3, 3)
        'If rs.RecordCount = 1 Then
        'Dim showUserMain As New Form2
        'showUserMain.ShowDialog()
        'End If
        'rs.Close()

        'con.Close()

        'temporary lang muna dito
        If Me.txtvoterID.Text = "2020" And Me.txtVoterPassword.Text = "adminpass" Then
            Dim showMain = New Form1
            showMain.ShowDialog()
        ElseIf Me.txtvoterID.Text = "2022" And Me.txtVoterPassword.Text = "voterpass" Then
            Dim showMain = New Form2
            showMain.ShowDialog()
        Else
            MessageBox.Show("Invalid Username or Password", "INVALID")
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class