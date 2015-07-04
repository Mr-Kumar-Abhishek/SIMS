<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modulo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.modid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.modname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.moddesc = New System.Windows.Forms.TextBox()
        Me.nxtbtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'modid
        '
        Me.modid.Location = New System.Drawing.Point(379, 58)
        Me.modid.Name = "modid"
        Me.modid.Size = New System.Drawing.Size(176, 20)
        Me.modid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "module ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Course ID"
        '
        'crc
        '
        Me.crc.Enabled = False
        Me.crc.Location = New System.Drawing.Point(125, 62)
        Me.crc.Name = "crc"
        Me.crc.Size = New System.Drawing.Size(100, 20)
        Me.crc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Module Name"
        '
        'modname
        '
        Me.modname.Location = New System.Drawing.Point(125, 143)
        Me.modname.Name = "modname"
        Me.modname.Size = New System.Drawing.Size(100, 20)
        Me.modname.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "module" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "description"
        '
        'moddesc
        '
        Me.moddesc.Location = New System.Drawing.Point(379, 146)
        Me.moddesc.Multiline = True
        Me.moddesc.Name = "moddesc"
        Me.moddesc.Size = New System.Drawing.Size(176, 60)
        Me.moddesc.TabIndex = 7
        '
        'nxtbtn
        '
        Me.nxtbtn.Location = New System.Drawing.Point(344, 340)
        Me.nxtbtn.Name = "nxtbtn"
        Me.nxtbtn.Size = New System.Drawing.Size(113, 21)
        Me.nxtbtn.TabIndex = 8
        Me.nxtbtn.Text = "next >>"
        Me.nxtbtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(479, 340)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 21)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'modulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 373)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.nxtbtn)
        Me.Controls.Add(Me.moddesc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.modname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.crc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.modid)
        Me.Name = "modulo"
        Me.Text = "modulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents modid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents crc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents modname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents moddesc As System.Windows.Forms.TextBox
    Friend WithEvents nxtbtn As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
