Imports System.Data.OleDb

Public Class Addmission_Form
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Dim p As String
    Private Sub TextBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dob.Click
        MonthCalendar1.Show()
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
        'below codes are for if check of previous records ----
        'cm = New OleDbCommand("select user from stmod where user = '" + stdcode.Text + "'", cn)
        'cm = New OleDbCommand("select user from stmod where user = '" + stdcode.Text + "' and moduleid = '" + modbox.SelectedItems.IndexOf(i) + "')", cn)
        'skipping to insertion and hoping for the best

        'itemnum = modbox.SelectedItems.Count
        ' p = CDbl(stdcode.Text)
        'If Double.TryParse(stdcode.Text, p) Then
        ''For index As Integer = 1 To itemnum
        'cm = New OleDbCommand("insert into stmod values('" + stdcode.Text + "', '" + modbox.SelectedItems.IndexOf(index) + "')", cn)
        'cm.ExecuteNonQuery()
        'Next
        'Else
        'MsgBox("Something is empty")
        'End If


        'For Each item As Integer In modbox.SelectedIndices
        'cm = New OleDbCommand("select user from stmod where user = '" + CDbl(stdcode.Text) + "' and moduleid = '" + modbox.SelectedItems.IndexOf(item) + "')", cn)
        'dr = cm.ExecuteReader
        'If dr.HasRows Then
        'MsgBox("sorry the value already exits")
        'Else
        'MsgBox("values doesn't exist")
        'End If
        'Next
        'cm = New OleDbCommand("insert into student values('" + stdcode.Text + "', '" + stdname.Text + "', '" + gender.SelectedItem + "', '" + tele.Text + "', '" + add.Text + "', '" + dob.Text + "', '" + qual.Text + "', '" + crc.Text + "', '" + stdate.Text + "', '" + endate.Text + "', 'comming soon')", cn)
        'cm.ExecuteNonQuery()
        'cm = New OleDbCommand("insert into stmod values('some id', '" + stdcode.Text + "')", cn)
        'MsgBox("hopefully data is inserted")
        ' If modbox.Items.Count > 0 Then

        'For Me.i = 0 To i < modbox.Items.Count Step 1
        ' if modbox.Items[i].Selected then
        ' p = modbox.Items[i].Text
        'End If
        ' p = modbox.SelectedItems.indexof[i]



        ' Next

        ' End If



        cn.Close()

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
        modbox.SelectionMode = SelectionMode.MultiSimple
        ListBox1.Items.Clear()
        cn = c.getcon()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("select coursename from course", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            course.Items.Add(dr.GetValue(0))
        End While
        cn.Close()
    End Sub

    Private Sub course_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles course.SelectedIndexChanged
        modbox.Items.Clear()
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cm = New OleDbCommand("select coursecode from course where coursename = '" + course.SelectedItem + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            crc.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select moduleid from modulo where coursecode = '" + crc.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            modbox.Items.Add(dr.GetValue(0))
            modbox.SelectionMode = SelectionMode.One

        End While
        cn.Close()
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

   
    Private Sub modbox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modbox.SelectedIndexChanged
        ListBox1.Items.Add(modbox.SelectedItem)
    End Sub

End Class