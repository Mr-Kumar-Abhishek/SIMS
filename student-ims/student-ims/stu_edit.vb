Imports System.Data.OleDb

Public Class stu_edit
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
    Private Sub concheck()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stcode.SelectedIndexChanged
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        concheck()
        cm = New OleDbCommand("update student set sname = '" + stname.Text + "', gender = '" + gender.Text + "', telephone = '" + tele.Text + "', address = '" + add.Text + "', DOB = '" + dob.Text + "', qualification = '" + qual.Text + "', coursecode = '" + crc.Text + "', Startdate = '" + stdate.Text + "', Enddate = '" + endate.Text + "', coursefees = '" + crf.Text + "' where user = '" + stcode.Text + "'", cn)
        Try
            cm.ExecuteNonQuery()
            MsgBox("Student data has been updated.")
        Catch ex As Exception
            c.errboxy()
        End Try
        'addition statement
        For Each itemchecked In modbox.CheckedItems
            cm = New OleDbCommand("select moduleid from stmod where user = '" + stcode.Text + "' and moduleid = '" + itemchecked + "'", cn)
            'Try
            dr = cm.ExecuteReader
            If (dr.HasRows) Then
                dr.Close()
                'intended to left blank
            Else
                dr.Close()
                cm = New OleDbCommand("insert into stmod values('" + itemchecked + "', '" + stcode.Text + "', 0)", cn)
                'Try
                cm.ExecuteNonQuery()
                'Catch ex As Exception
                'c.errboxy()
                'End Try
            End If
            'Catch ex As Exception
            'c.errboxy()
            'End Try
        Next
        For i As Integer = 0 To modbox.Items.Count - 1
            modbox.SelectedIndex = i
            If modbox.GetItemCheckState(i) = False Then

                cm = New OleDbCommand("select * from stmod where moduleid = '" + modbox.SelectedItem + "' and user = '" + stcode.Text + "'", cn)
                'Try
                dr = cm.ExecuteReader
                If dr.HasRows Then
                    dr.Close()
                    cm = New OleDbCommand("delete from stmod where moduleid = '" + modbox.SelectedItem + "' and user = '" + stcode.Text + "'", cn)
                    'Try
                    cm.ExecuteNonQuery()
                    ' Catch ex As Exception
                    'c.errboxy()
                    'End Try
                End If
                'Catch ex As Exception
                'c.errboxy()
                'End Try
            End If
        Next
    End Sub

    Private Sub deletion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletion.Click
        concheck()
        cm = New OleDbCommand("delete from student where user = '" + stcode.Text + "'", cn)
        Try
            cm.ExecuteNonQuery()
        Catch ex As Exception
            c.errboxy()
        End Try
        cn.Close()
        clearing()
        repopulate()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub

    Private Sub dob_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dob.Click
        MonthCalendar1.Show()
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        dob.Text = MonthCalendar1.SelectionStart.Date
    End Sub

    Private Sub MonthCalendar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthCalendar1.MouseLeave
        MonthCalendar1.Hide()
    End Sub

    Private Sub stdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles stdate.Click
        MonthCalendar2.Show()
    End Sub

    Private Sub MonthCalendar2_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        stdate.Text = MonthCalendar2.SelectionStart.Date
    End Sub


    Private Sub MonthCalendar2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthCalendar2.MouseLeave
        MonthCalendar2.Hide()
    End Sub

    Private Sub endate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles endate.Click
        MonthCalendar3.Show()
    End Sub


    Private Sub MonthCalendar3_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar3.DateChanged
        endate.Text = MonthCalendar3.SelectionStart.Date
    End Sub

    Private Sub MonthCalendar3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthCalendar3.MouseLeave
        MonthCalendar3.Hide()
    End Sub
End Class