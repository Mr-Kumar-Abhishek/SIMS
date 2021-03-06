﻿Imports System.Data.OleDb

Public Class Stu_view
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub clearing()
        stcode.Items.Clear()
        stname.Text = ""
        gender.Text = ""
        qual.Text = ""
        add.Text = ""
        dob.Text = ""
        tele.Text = ""
        crc.Text = ""
        stdate.Text = ""
        endate.Text = ""
        crcd.Text = ""
        crf.Text = ""
    End Sub

    Private Sub concheck()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
    End Sub

    Private Sub repopulate()
        concheck()
        cm = New OleDbCommand("select user from student", cn)
        Try
            dr = cm.ExecuteReader
            While (dr.Read)
                stcode.Items.Add(dr.GetValue(0))
            End While
        Catch ex As Exception
            c.errboxy()
        End Try
        cn.Close()
    End Sub


    Private Sub stcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stcode.SelectedIndexChanged
        modbox.Items.Clear()
        concheck()
        cm = New OleDbCommand("select sname, gender, telephone ,address , DOB, coursecode, qualification, Startdate, Enddate, coursefees from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            stname.Text = dr.GetValue(0)
            gender.Text = dr.GetValue(1)
            tele.Text = dr.GetValue(2)
            add.Text = dr.GetValue(3)
            dob.Text = dr.GetValue(4)
            crc.Text = dr.GetValue(5)
            crcd.Text = dr.GetValue(5)
            qual.Text = dr.GetValue(6)
            stdate.Text = dr.GetValue(7)
            endate.Text = dr.GetValue(8)
            crf.Text = dr.GetValue(9)

        End While
        cm = New OleDbCommand("select moduleid from modulo where coursecode = '" + crc.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            modbox.Items.Add(dr.GetValue(0))
        End While
        cm = New OleDbCommand("select moduleid from stmod where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            Try
                Dim modtaken As String = dr.GetValue(0)
                For i As Integer = 0 To modbox.Items.Count - 1
                    modbox.SelectedIndex = i
                    If modbox.SelectedItem = dr.GetValue(0) Then
                        modbox.SetItemChecked(i, True)
                    End If
                Next
            Catch ex As Exception
                MsgBox("This student is not selected in any modules", MsgBoxStyle.Exclamation, "Important")
            End Try

        End While
        cn.Close()
    End Sub

    Private Sub stu_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon()
        clearing()
        repopulate()
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class