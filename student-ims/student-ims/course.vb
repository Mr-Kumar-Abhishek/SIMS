﻿Imports System.Data.OleDb

Public Class course
    Dim cn As OleDbConnection
    Dim cm, cm1 As OleDbCommand
    Dim dr, dr1 As OleDbDataReader
    Dim c As New conn
    Dim cnt As Integer

    Private Sub clearing()
        crc.Text = ""
        crn.Text = ""
        tf.Text = ""
        dur.Value = 0
        'nom.Value = 0
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
        cm = New OleDbCommand("insert into course values('" + crc.Text + "', " & tf.Text & ", '" + crn.Text + "', '" + dur.Value.ToString() + "')", cn)
        cm.ExecuteNonQuery()
        MsgBox("New course " & crc.Text & " has been added.")
        clearing()
        'clearing the module wizard functionality to expedite the release
        'If Not cn.State = ConnectionState.Open Then
        'cn = c.getcon()
        'End If
        'cm1 = New OleDbCommand("select count(moduleid) from modulo where coursecode= '" + crc.Text + "'", cn)
        'dr1 = cm1.ExecuteReader
        'While dr1.Read
        'cnt = CInt(dr1.GetValue(0))
        'End While
        'cnt = nom.Value - cnt
        'If cnt <> 0 Then
        'modulo.Show()
        'End If
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

    Private Sub course_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class