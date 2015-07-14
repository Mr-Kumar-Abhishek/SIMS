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
        GroupBox1.Hide()
        Me.Height = 380
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

    Private Sub reloadpay()
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
        'this will calculate the total fees deposited
        cm = New OleDbCommand("select amount from stpay where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        Dim deposit As Integer
        While (dr.Read)
            deposit = deposit + CInt(dr.GetValue(0))
        End While
        dep.Text = deposit
        Dim totamt As Integer
        totamt = CInt(tfees.Text)
        Dim remin As Integer
        remin = totamt - deposit
        amtrmn.Text = remin
        cm = New OleDbCommand("select cashmemo from stpay where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            cmn.Text = dr.GetValue(0)
        End While
        cn.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Payment_Details_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        clearing()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Height = 570
        GroupBox1.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("insert into stpay values('" + stcode.Text + "', '" + paydate.Text + "', '" + cashmemo.Text + "', '" + amount.Text + "')", cn)
        Try
            cm.ExecuteNonQuery()
        Catch ex As Exception
            c.errboxy()
        End Try
        reloadpay()
        cn.Close()

    End Sub

    Private Sub stcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles stcode.TextChanged
        reloadpay()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class