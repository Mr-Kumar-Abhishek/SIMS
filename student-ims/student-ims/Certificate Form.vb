﻿Imports System.Data.OleDb

Public Class Certificate_Form
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub Certificate_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("select user from student", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            stcode.Items.Add(dr.GetValue(0))
        End While
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub stcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stcode.SelectedIndexChanged
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("select sname from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            stname.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select coursecode from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            crc.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select moduleid from stmod where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            modbox.Items.Add(dr.GetValue(0))
        End While
        cn.Close()
    End Sub
End Class