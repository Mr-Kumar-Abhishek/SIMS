﻿Imports System.Data.OleDb

Public Class course_edit
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim c As New conn
    Dim cnt As Integer

    Private Sub clearing()
        crc.Text = ""
        crn.Text = ""
        tf.Text = ""
        dur.Value = 0
        'nom.Value = 0
    End Sub

    Private Sub repopulate()
        crc.Items.Clear()
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
    Private Sub course_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon()
        repopulate()
    End Sub

    Private Sub crc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles crc.TextChanged
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        cm = New OleDbCommand("select coursename, totalfees, duration from course where coursecode = '" + crc.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            crn.Text = dr.GetValue(0)
            tf.Text = dr.GetValue(1)
            dur.Value = dr.GetValue(2)
        End While
        cn.Close()
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Hide()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        cm = New OleDbCommand("update course set coursename = '" + crn.Text + "', totalfees = '" + tf.Text + "', duration = '" + dur.Value.ToString() + "' where coursecode = '" + crc.Text + "'", cn)
        cm.ExecuteNonQuery()
        cn.Close()
        MsgBox("Course details updated")
        clearing()
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim deleted As String = crc.Text
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        cm = New OleDbCommand("delete from course where coursecode = '" + crc.Text + "'", cn)
        cm.ExecuteNonQuery()
        cn.Close()
        clearing()
        repopulate()
        MsgBox("The course " + deleted + " has been deleted.")
    End Sub
End Class