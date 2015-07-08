<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_mod
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
        Me.AvailMod = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.crc = New System.Windows.Forms.ComboBox()
        Me.moddesc = New System.Windows.Forms.TextBox()
        Me.modname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AvailMod
        '
        Me.AvailMod.FormattingEnabled = True
        Me.AvailMod.Location = New System.Drawing.Point(458, 76)
        Me.AvailMod.Name = "AvailMod"
        Me.AvailMod.Size = New System.Drawing.Size(222, 56)
        Me.AvailMod.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(322, 261)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 21)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "okay"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'crc
        '
        Me.crc.FormattingEnabled = True
        Me.crc.Location = New System.Drawing.Point(133, 76)
        Me.crc.Name = "crc"
        Me.crc.Size = New System.Drawing.Size(192, 21)
        Me.crc.TabIndex = 25
        '
        'moddesc
        '
        Me.moddesc.Location = New System.Drawing.Point(458, 157)
        Me.moddesc.Multiline = True
        Me.moddesc.Name = "moddesc"
        Me.moddesc.Size = New System.Drawing.Size(231, 60)
        Me.moddesc.TabIndex = 24
        '
        'modname
        '
        Me.modname.Location = New System.Drawing.Point(133, 154)
        Me.modname.Name = "modname"
        Me.modname.Size = New System.Drawing.Size(192, 20)
        Me.modname.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Module Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Course ID"
        '
        'view_mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 322)
        Me.Controls.Add(Me.AvailMod)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.crc)
        Me.Controls.Add(Me.moddesc)
        Me.Controls.Add(Me.modname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "view_mod"
        Me.Text = "view modules"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AvailMod As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents crc As System.Windows.Forms.ComboBox
    Friend WithEvents moddesc As System.Windows.Forms.TextBox
    Friend WithEvents modname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
