Imports System.Data.OleDb

Public Class login
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn = c.getcon()

        cm = New OleDbCommand("select user,pass from login where user='" + unamebox.Text + "' and pass='" + passbox.Text + "'", cn)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            While (dr.Read)
                Form1.Show()
                Me.Hide()
            End While
        Else
            MsgBox("please check your username or password", vbOK, "error")
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        unamebox.Select()
    End Sub
End Class