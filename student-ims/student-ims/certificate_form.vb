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

        cm = New OleDbCommand("select sname,coursecode from student where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            stname.Text = dr.GetValue(0)
            crc.Text = dr.GetValue(1)
        End While
        cm = New OleDbCommand("select moduleid from stmod where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            modbox.Items.Add(dr.GetValue(0))
        End While
        Dim tot_marks As Integer = 0
        cm = New OleDbCommand("select marks from stmod where user = '" + stcode.Text + "'", cn)
        dr = cm.ExecuteReader
        While (dr.Read)
            tot_marks = dr.GetValue(0) + tot_marks
        End While
        marks.Text = tot_marks
        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pdf As PdfDocument = New PdfDocument
        Dim pdfPage As PdfPage = pdf.AddPage
        Dim graph As XGraphics = XGraphics.FromPdfPage(pdfPage)
        Dim myfont As XFont = New XFont("Verdana", 13, XFontStyle.Bold)  '//you can set any font size, and style
        Dim imagepath As String = Application.StartupPath & "/logo.jpg"
        Dim image As XImage = XImage.FromFile(imagepath)
        Dim stitle As String
        stitle = "Certificate of " & stname.Text
        pdf.Info.Title = stitle
        graph.DrawImage(image, 250, 50, 100, 50)
        Dim textline As String
        textline = "This to certify that Mr./Ms./Mrs. " & stname.Text

        'textline = "NAME: " & stname.Text
        graph.DrawString(textline, myfont, XBrushes.Black, New XRect(30, 145, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft)       '//width from left 50 pixels, height from top 245 pixels
        textline = "has successfully completed the course on " & crc.Text & " "
        graph.DrawString(textline, myfont, XBrushes.Black, New XRect(30, 160, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft)
        textline = stname.Text & " in " & grade.Text & " grade."
        graph.DrawString(textline, myfont, XBrushes.Black, New XRect(30, 175, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft)
        textline = "NB: Fair >= 50; Good >= 60; Very Good >= 70; Excellent >= 80;"
        myfont = New XFont("Verdana", 10, XFontStyle.Bold)
        graph.DrawString(textline, myfont, XBrushes.Black, New XRect(30, 200, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft)
        'textline = "Roll No." & stcode.Text
        'graph.DrawString(textline, myfont, XBrushes.Black, New XRect(50, 350, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft)       '//width from left 50 pixels, height from top 245 pixels
        'graph.DrawString("sname :", myfont, XBrushes.Black, New XRect(120, 245, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft)       '//width from left 120 pixels, height from top 245 pixels
        Dim path As String
        path = Application.StartupPath & "/name.pdf"
        pdf.Save(path)
        Process.Start(path)
    End Sub
End Class