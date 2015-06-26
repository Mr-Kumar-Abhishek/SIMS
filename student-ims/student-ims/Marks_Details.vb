Imports System.Data.OleDb
Public Class Marks_Details
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim list As DataTable
    Dim da As OleDbDataAdapter

    Private Sub Marks_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("select user from student'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            stcode.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
        Dim da As New OleDbDataAdapter(cm)
        Dim list As New DataTable
        da.Fill(list)
        DataGridView1.DataSource = list
        cn.Close()
    End Sub


    Private Sub stcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stcode.SelectedIndexChanged
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("select sname from student where user='" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        stname.Text = ""
        While (dr.Read)
            stname.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select coursecode from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        crc.Text = ""
        While (dr.Read)
            crc.Text = dr.GetValue(0)
        End While
        cn.Close()
    End Sub

    Private Sub stcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles stcode.TextChanged
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("select sname from student where user='" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        stname.Text = ""
        While (dr.Read)
            stname.Text = dr.GetValue(0)
        End While
        cn.Close()
    End Sub
End Class