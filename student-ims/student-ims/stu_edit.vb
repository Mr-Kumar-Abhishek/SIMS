Imports System.Data.OleDb

Public Class stu_edit
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub concheck()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stcode.SelectedIndexChanged
        modbox.Items.Clear()
        concheck()
        cm = New OleDbCommand("select sname from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            stname.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select gender from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            gender.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select telephone from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            tele.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select address from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            add.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select DOB from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            dob.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select coursecode from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            crc.Text = dr.GetValue(0)
            crcd.Text = crc.Text
        End While
        cm = New OleDbCommand("select qualification from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            qual.Text =  dr.GetValue(0)
        End While
        cm = New OleDbCommand("select Startdate from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            stdate.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select Enddate from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            endate.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select coursefees from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            crf.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select moduleid from modulo where coursecode = '" + crc.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            modbox.Items.Add(dr.GetValue(0))
        End While
        cm = New OleDbCommand("select moduleid from stmod where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            Dim modtaken As String = dr.GetValue(0)
            For i As Integer = 0 To modbox.Items.Count - 1
                modbox.SelectedIndex = i
                If modbox.SelectedItem = dr.GetValue(0) Then
                    modbox.SetItemChecked(i, True)
                End If
            Next
        End While
    End Sub

    Private Sub stu_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon()
        concheck()
        cm = New OleDbCommand("select user from student", cn)
        Try
            dr = cm.ExecuteReader
            While (dr.Read)
                stcode.Items.Add(dr.GetValue(0))
            End While
        Catch ex As Exception
        
            MsgBox("Error occured when connecting with the database", MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        concheck()
        cm = New OleDbCommand("update student set sname = '" + stname.Text + "', gender = '" + gender.Text + "', telephone = '" + tele.Text + "', address = '" + add.Text + "', DOB = '" + dob.Text + "', qualification = '" + qual.Text + "', coursecode = '" + crc.Text + "', Startdate = '" + stdate.Text + "', Enddate = '" + endate.Text + "', coursefees = '" + crf.Text + "' where user = '" + stcode.Text + "'", cn)
        Try
            cm.ExecuteNonQuery()
            MsgBox("Student data has been updated.")
        Catch ex As Exception
            MsgBox("Error occured when connecting with the database ", MsgBoxStyle.Critical)
        End Try

    End Sub
End Class