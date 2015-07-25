Public Class splash

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightPink
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MDI.Show()
        Me.Hide()
        Timer1.Stop()
    End Sub
End Class
