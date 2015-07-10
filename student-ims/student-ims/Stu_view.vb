Imports System.Data.OleDb

Public Class Stu_view
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

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modbox.SelectedIndexChanged

    End Sub

    Private Sub Stu_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon
        cn.Close()
    End Sub
End Class