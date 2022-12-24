Imports System.Data.OracleClient
Module konektor
    Public connect As New OracleConnection
    Public adapter As New OracleDataAdapter
    Public dataset As New DataSet
    Public cmd As New OracleCommand
    Public dr As OracleDataReader

    Sub koneksi()
        connect.Close()
        connect = New OracleConnection("Data Source=XE;Persist Security Info=True;User ID=Pelangi;Unicode=True;password=123;")
        connect.Open()
    End Sub
End Module
