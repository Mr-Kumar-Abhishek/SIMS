Imports System.Data.OleDb
Public Class conn
    Dim cn As OleDbConnection
    Public Function getcon()
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SIMS1.accdb")
        cn.Open()
        Return cn
    End Function
End Class
