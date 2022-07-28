Module Module1
    Public con As New ADODB.Connection
    Public rec As New ADODB.Recordset

    Public Sub buka()
        con.Open("DSN=dataobat")
    End Sub

    Public Sub tutup()
        con.Close()
    End Sub
End Module
