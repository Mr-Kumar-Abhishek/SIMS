Imports System.Data.OleDb
Public Class Marks_Details
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim list As DataTable
    Dim da As OleDbDataAdapter


    Private Sub concheck()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
    End Sub
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
        cn.Close()
    End Sub

    Private Sub refreshgrid()
        concheck()
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
        dr.Close()
        cm = New OleDbCommand("select moduleid,marks from stmod where user = '" + stcode.Text + "'", cn)
        Dim da As New OleDbDataAdapter(cm)
        ' Dim list As New DataTable
        Dim ds As DataSet
        ds = New DataSet
        da.Fill(ds, "stmod")
        Me.DataGridView1.DataSource = ds.Tables("stmod")
        'DataGridView1.DataSource = list
        cn.Close()
    End Sub

    Private Sub stcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stcode.SelectedIndexChanged
        refreshgrid()
    End Sub

    Private Sub stcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles stcode.TextChanged
        concheck()
        cm = New OleDbCommand("select sname from student where user='" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        stname.Text = ""
        While (dr.Read)
            stname.Text = dr.GetValue(0)
        End While
        cn.Close()
    End Sub

    Private Sub editing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editing.Click
        If (DataGridView1.SelectedRows.Count >= 0) Then
            Try
                marks.Text = DataGridView1.SelectedRows(0).Cells(1).Value
                TextBox2.Text = DataGridView1.SelectedRows(0).Cells(0).Value
            Catch ex As Exception
                MsgBox("select cell properly.", MsgBoxStyle.Exclamation, "Info")
            End Try

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        concheck()
        cm = New OleDbCommand("update stmod set marks = '" + marks.Text + "' where user = '" + stcode.Text + "'", cn)
        Try
            cm.ExecuteNonQuery()
        Catch ex As Exception
            c.errboxy()
        End Try
        cn.Close()
        refreshgrid()
    End Sub
End Class