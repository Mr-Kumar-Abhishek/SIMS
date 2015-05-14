Imports System.Data.OleDb

Public Class course
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim c As New conn

    Private Sub course_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clearing()
        crc.Text = ""
        crn.Text = ""
        tf.Text = ""
        dur.Value = 0
        nom.Value = 0
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        cm = New OleDbCommand("select * from course where coursecode = '" + crc.Text + "'", cn)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            MsgBox("Sorry the course code already exists")
        End If
        cm = New OleDbCommand("insert into course values('" + crc.Text + "','" + crn.Text + "', '" + tf.Text + "', '" + nom.Text + "', '" + dur.Text + "')", cn)
        If cm.ExecuteNonQuery() Then
            clearing()
        End If
        cn.Close()
    End Sub

    Private Sub crc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crc.TextChanged
        cn = c.getcon()
        cm = New OleDbCommand("select * from course where coursecode = '" + crc.Text + "'", cn)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            MsgBox("Sorry the course code already exists")
        End If
        cn.Close()
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        cour()
    End Sub
End Class