Imports System.Data.OleDb
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.Diagnostics
Imports PdfSharp.Drawing.Layout

Public Class Certificate_Form
    Dim c As New conn
    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub Certificate_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub stcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stcode.SelectedIndexChanged
        modbox.Items.Clear()
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
        While (dr.Read)
            crc.Text = dr.GetValue(0)
        End While
        cm = New OleDbCommand("select moduleid from stmod where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            modbox.Items.Add(dr.GetValue(0))
        End While
        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pdf As PdfDocument = New PdfDocument
        Dim pdfPage As PdfPage = pdf.AddPage
        Dim graph As XGraphics = XGraphics.FromPdfPage(pdfPage)
        Dim myfont As XFont = New XFont("Verdana", 15, XFontStyle.Bold)  '//you can set any font size, and style
        Dim stitle As String
        stitle = "Certificate of " & stname.Text
        pdf.Info.Title = stitle
        Dim textline As String
        textline = "NAME: " & stname.Text
        graph.DrawString(textline, myfont, XBrushes.Black, New XRect(50, 245, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft)       '//width from left 50 pixels, height from top 245 pixels
        textline = "Roll No." & stcode.Text
        graph.DrawString(textline, myfont, XBrushes.Black, New XRect(50, 350, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft)       '//width from left 50 pixels, height from top 245 pixels
        'graph.DrawString("sname :", myfont, XBrushes.Black, New XRect(120, 245, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft)       '//width from left 120 pixels, height from top 245 pixels
        Dim path As String
        path = Application.StartupPath & "/name.pdf"
        pdf.Save(path)
        Process.Start(path)
    End Sub
End Class