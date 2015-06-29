Imports System.Data.OleDb
Public Class Payment_Details
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Private Sub clearing()
        crc.Text = ""
        stname.Text = ""
        stcode.Text = ""
        tfees.Text = ""
        cmn.Text = ""
        dep.Text = ""
        dop.Text = ""
        amtrmn.Text = ""
    End Sub
    Private Sub Payment_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Beige
        clearing()
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
        crc.Text = ""
        While (dr.Read)
            crc.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select totalfees from course where coursecode = '" + crc.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            tfees.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select amount from stpay where user =  '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            dep.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select paydate from stpay where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            dop.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select coursefees from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            tfees.Text = dr.GetValue(0)
        End While
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Payment_Details_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        clearing()
    End Sub
End Class