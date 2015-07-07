Imports System.Data.OleDb

Public Class Add_mod
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim c As New conn
    Dim cnt As Integer
    Private Sub Add_mod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon()
        cm = New OleDbCommand("select coursecode from course", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            crc.Items.Add(dr.GetValue(0))
        End While
        cn.Close()
    End Sub

    Private Sub moddesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moddesc.TextChanged

    End Sub

    Private Sub modname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modname.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub nxtbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nxtbtn.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crc.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class