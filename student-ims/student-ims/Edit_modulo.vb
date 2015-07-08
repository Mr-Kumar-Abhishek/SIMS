Imports System.Data.OleDb

Public Class Edit_modulo
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim c As New conn
    Dim cnt As Integer


    Private Sub repopulate()
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        cm = New OleDbCommand("select coursecode from course", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            crc.Items.Add(dr.GetValue(0))
        End While
        cn.Close()
    End Sub

    Private Sub Edit_modulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon()
        repopulate()
    End Sub
End Class