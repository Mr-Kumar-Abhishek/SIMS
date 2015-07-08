Imports System.Data.OleDb

Public Class Add_mod
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
    Private Sub Add_mod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon()
        clearing()
        repopulate()
    End Sub


    Private Sub crc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles crc.TextChanged
        AvailMod.Items.Clear()
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        cm = New OleDbCommand("select moduleid from modulo where coursecode = '" + crc.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            AvailMod.Items.Add(dr.GetValue(0))
        End While
        cn.Close()
    End Sub

    Private Sub clearing()
        modid.Text = ""
        moddesc.Text = ""
        modname.Text = ""
    End Sub
    Private Sub clrmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrmod.Click
        clearing()
    End Sub

    Private Sub Addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addbtn.Click
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        cm = New OleDbCommand("insert into modulo values('" & modid.Text & "', '" & crc.Text & "', '" & modname.Text & "', '" & moddesc.Text & "')", cn)
        cm.ExecuteNonQuery()
        MsgBox("Module: " & modid.Text & " has been added in course " & crc.Text & "")

    End Sub
End Class