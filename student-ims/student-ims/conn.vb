Imports System.Data.OleDb
Public Class conn
    Dim cn As OleDbConnection
    Public Function getcon()
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\projects\paru smita\student-ims\student-ims\SIMS1.accdb")
        cn.Open()
        Return cn
    End Function
End Class
