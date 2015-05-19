Imports System.Data.OleDb
Public Class modulo
    Dim pages As Integer = 0
    Dim cn As OleDbConnection
    Dim c As New conn
    Dim cm As OleDbCommand

    Private Sub clearing()
        modid.Text = ""
        modname.Text = ""
        moddesc.Text = ""
    End Sub
    Private Sub modulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        crc.Text = course.crc.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nxtbtn.Click
        pages = pages + 1
        If pages = course.nom.Value Then
            nxtbtn.Text = "submit"
            clearing()
        ElseIf pages > course.nom.Value Then
            MsgBox("Got all " & pages & " inputs")
            Me.Close()
        Else
            cn = c.getcon()
            cm = New OleDbCommand("insert into modulo values ('" + modid.Text + "', '" + crc.Text + "', '" + modname.Text + "', '" + moddesc.Text + "')", cn)
            cm.ExecuteNonQuery()
            clearing()
        End If
    End Sub
End Class