Public Class Stu_view


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

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modbox.SelectedIndexChanged

    End Sub

    Private Sub Stu_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class