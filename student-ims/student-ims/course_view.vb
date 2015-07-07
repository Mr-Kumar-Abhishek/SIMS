Imports System.Data.OleDb

Public Class course_view
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim c As New conn
    Dim cnt As Integer

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Hide()
    End Sub

    Private Sub crc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles crc.TextChanged

    End Sub

    Private Sub course_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = c.getcon()
    End Sub
End Class