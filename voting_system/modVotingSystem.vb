Module modVotingSystem
    Public con As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Public Sub connect()
        Dim path As String
        path = Application.StartupPath & ("\dbVotingSystem.mdb")
        con.Open("provider = microsoft.jet.oledb.4.0; data source = " & path)
    End Sub
End Module
