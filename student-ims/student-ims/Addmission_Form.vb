Imports System.Data.OleDb

Public Class Addmission_Form
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Private Sub TextBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Click
        MonthCalendar1.Show()
    End Sub

    Private Sub TextBox10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.Click
        MonthCalendar2.Show()
    End Sub

    Private Sub TextBox11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.Click
        MonthCalendar3.Show()
    End Sub
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBox5.Text = MonthCalendar1.SelectionStart.Date
    End Sub

    Private Sub MonthCalendar2_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        TextBox10.Text = MonthCalendar2.SelectionStart.Date
    End Sub

    Private Sub MonthCalendar3_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar3.DateChanged
        TextBox11.Text = MonthCalendar3.SelectionStart.Date
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Width = 785
        Me.Height = 650
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Show()
        Me.Width = 785
        Me.Height = 650
    End Sub

    Private Sub Addmission_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = Panel1.Width
        Me.Height = Panel1.Height
        Me.BackColor = Color.Beige
        GroupBox1.Hide()
        If Not cn.State = ConnectionState.Open Then
            cn = c.getcon()
        End If
        'cm = New OleDbCommand("select coursename from course", cn)
        da = New OleDbDataAdapter("select coursename from course", cn)
        da.Fill(ds, "course")

    End Sub


End Class