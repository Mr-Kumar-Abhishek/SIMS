Imports System.Data.OleDb

Public Class Addmission_Form
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim chk As String
    Private Sub TextBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dob.Click
        MonthCalendar1.Show()
    End Sub
    Private Sub cleaning()
        stdcode.clear()
        stdname.clear()
        gender.Text = ""
        tele.clear()
        add.clear()
        dob.clear()
        qual.clear()
        coursedp.Text = ""
        crn.clear()
        crf.clear()
        stdate.clear()
        endate.clear()
        modbox.Items.Clear()
    End Sub

    Private Sub TextBox10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles stdate.Click
        MonthCalendar2.Show()
    End Sub

    Private Sub TextBox11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles endate.Click
        MonthCalendar3.Show()
    End Sub
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        dob.Text = MonthCalendar1.SelectionStart.Date
    End Sub

    Private Sub MonthCalendar2_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        stdate.Text = MonthCalendar2.SelectionStart.Date
    End Sub

    Private Sub MonthCalendar3_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar3.DateChanged
        endate.Text = MonthCalendar3.SelectionStart.Date
    End Sub

    Private Sub MonthCalendar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthCalendar1.MouseLeave
        MonthCalendar1.Hide()
    End Sub

    Private Sub MonthCalendar2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthCalendar2.MouseLeave
        MonthCalendar2.Hide()
    End Sub

    Private Sub MonthCalendar3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthCalendar3.MouseLeave
        MonthCalendar3.Hide()
    End Sub

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("insert into student values('" + stdcode.Text + "', '" + stdname.Text + "', '" + gender.Text + "', '" + tele.Text + "', '" + add.Text + "', '" + dob.Text + "' , '" + qual.Text + "', '" + crn.Text + "', '" + stdate.Text + "', '" + endate.Text + "', 'comming soon', '" + crf.Text + "')", cn)
        cm.ExecuteNonQuery()
        Dim itemchecked As Object
        For Each itemchecked In modbox.CheckedItems
            cm = New OleDbCommand("insert into stmod values('" + itemchecked.ToString + "', '" + stdcode.Text + "')", cn)
            cm.ExecuteNonQuery()
        Next
        cn.Close()
        MsgBox("Data has been added succesfully")
        cleaning()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Show()
        Me.Width = 785
        Me.Height = 750
    End Sub

    Private Sub Addmission_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = Panel1.Width
        Me.Height = Panel1.Height
        Me.BackColor = Color.Beige
        GroupBox1.Hide()
        cn = c.getcon()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("select coursecode from course", cn)
        Try
            dr = cm.ExecuteReader
            While (dr.Read)
                coursedp.Items.Add(dr.GetValue(0))
            End While
        Catch ex As Exception
            c.errboxy()
        End Try
        cn.Close()
    End Sub

    Private Sub course_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coursedp.SelectedIndexChanged
        modbox.Items.Clear()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("select coursename,totalfees from course where coursecode = '" + coursedp.SelectedItem + "'", cn)
        Try
            dr = cm.ExecuteReader
            While (dr.Read)
                crn.Text = dr.GetValue(0)
                crf.Text = dr.GetValue(1)
            End While
        Catch ex As Exception
            c.errboxy()
        End Try
        
        cm = New OleDbCommand("select moduleid from modulo where coursecode = '" + coursedp.SelectedItem + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            modbox.Items.Add(dr.GetValue(0))
        End While
        cn.Close()
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class