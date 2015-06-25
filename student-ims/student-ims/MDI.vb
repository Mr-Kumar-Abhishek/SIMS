Public Class MDI
    Dim acclvl As Integer
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LoginCheck()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        course.Show()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Addmission_Form.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        stu_edit.Show()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem1.Click
        Stu_view.Show()
    End Sub

    Private Sub EditToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem2.Click
        Edit_modulo.Show()
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsToolStripMenuItem.Click
        Payment_Details.Show()
    End Sub

    Private Sub MarksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksToolStripMenuItem1.Click
        Marks_Details.Show()
    End Sub

    Private Sub CertificatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificatesToolStripMenuItem.Click
        Certificate_Form.Show()
    End Sub
End Class