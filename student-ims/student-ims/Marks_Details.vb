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
        dr.Close()
        cm = New OleDbCommand("select moduleid,marks from marks where user = '" + stcode.Text + "'", cn)
        Dim da As New OleDbDataAdapter(cm)
        ' Dim list As New DataTable
        Dim ds As DataSet
        ds = New DataSet
        da.Fill(ds, "marks")

        Me.DataGridView1.DataSource = ds.Tables("marks")
        'DataGridView1.DataSource = list
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

    Private Sub editing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editing.Click
        If (DataGridView1.SelectedRows.Count >= 0) Then
            TextBox1.Text = DataGridView1.SelectedRows(0).Cells(1).Value
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
 
    End Sub
End Class