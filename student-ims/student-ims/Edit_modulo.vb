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

    Private Sub AvailMod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailMod.SelectedIndexChanged
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        cm = New OleDbCommand("select module_name from modulo where moduleid = '" & AvailMod.Text & "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            modname.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select module_desc from modulo where moduleid = '" & AvailMod.Text & "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            moddesc.Text = dr.GetValue(0)
        End While
        cn.Close()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        cm = New OleDbCommand("update modulo set module_name = '" + modname.Text + "', module_desc = '" + moddesc.Text + "' where moduleid = '" + AvailMod.SelectedItem + "'", cn)
        cm.ExecuteNonQuery()
        MsgBox("Module: " + AvailMod.SelectedItem + " was updated.")
        cn.Close()
    End Sub
End Class


