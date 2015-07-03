Imports System.Data.OleDb
Public Class modulo
    Dim pages As Integer = 0
    Dim cn As OleDbConnection
    Dim c As New conn
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim moduleid(course.nom.Value) As String
    Dim coursecode(course.nom.Value) As String
    Dim modulename(course.nom.Value) As String
    Dim moduledesc(course.nom.Value) As String

    Private Sub clearing()
        modid.Text = ""
        modname.Text = ""
        moddesc.Text = ""
    End Sub
    Private Sub modulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        crc.Text = course.crc.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nxtbtn.Click
        pages = pages + 1
        MsgBox(pages)
        If pages = course.nom.Value - 1 Then
            nxtbtn.Text = "submit"
            clearing()
        ElseIf pages > course.nom.Value - 1 Then
            cn = c.getcon()
            For i As Integer = 0 To course.nom.Value Step 1
                cm = New OleDbCommand("insert into modulo values ('" + moduleid(i) + "', '" + coursecode(i) + "', '" + modulename(i) + "', '" + moduledesc(i) + "')", cn)
                cm.ExecuteNonQuery()
            Next

            'cm = New OleDbCommand("insert into modulo values ('" + modid.Text + "', '" + crc.Text + "', '" + modname.Text + "', '" + moddesc.Text + "')", cn)
            'cm.ExecuteNonQuery()
            cn.Close()
            MsgBox("Got all " & pages & " inputs")
            Me.Close()
        Else
                'cn = c.getcon()
                'cm = New OleDbCommand("insert into modulo values ('" + modid.Text + "', '" + crc.Text + "', '" + modname.Text + "', '" + moddesc.Text + "')", cn)
                'cm.ExecuteNonQuery()
            'cn.Close()
                moduleid(pages - 1) = modid.Text
                coursecode(pages - 1) = crc.Text
                modulename(pages - 1) = modname.Text
                moduledesc(pages - 1) = moddesc.Text


                clearing()
        End If
    End Sub

    Private Sub modid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modid.TextChanged
        cn = c.getcon()
        cm = New OleDbCommand("select * from modulo where moduleid = '" + modid.Text + "'", cn)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            MsgBox("sorry the module code already exits")
        End If
    End Sub
End Class