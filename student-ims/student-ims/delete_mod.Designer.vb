<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class delete_mod
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
        Me.deletion = New System.Windows.Forms.Button()
        Me.crc = New System.Windows.Forms.ComboBox()
        Me.moddesc = New System.Windows.Forms.TextBox()
        Me.modname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AvailMod
        '
        Me.AvailMod.FormattingEnabled = True
        Me.AvailMod.Location = New System.Drawing.Point(450, 67)
        Me.AvailMod.Name = "AvailMod"
        Me.AvailMod.Size = New System.Drawing.Size(231, 56)
        Me.AvailMod.TabIndex = 35
        '
        'deletion
        '
        Me.deletion.Location = New System.Drawing.Point(314, 252)
        Me.deletion.Name = "deletion"
        Me.deletion.Size = New System.Drawing.Size(113, 21)
        Me.deletion.TabIndex = 34
        Me.deletion.Text = "delete"
        Me.deletion.UseVisualStyleBackColor = True
        '
        'crc
        '
        Me.crc.FormattingEnabled = True
        Me.crc.Location = New System.Drawing.Point(125, 67)
        Me.crc.Name = "crc"
        Me.crc.Size = New System.Drawing.Size(192, 21)
        Me.crc.TabIndex = 33
        '
        'moddesc
        '
        Me.moddesc.Location = New System.Drawing.Point(450, 148)
        Me.moddesc.Multiline = True
        Me.moddesc.Name = "moddesc"
        Me.moddesc.Size = New System.Drawing.Size(231, 60)
        Me.moddesc.TabIndex = 32
        '
        'modname
        '
        Me.modname.Location = New System.Drawing.Point(125, 145)
        Me.modname.Name = "modname"
        Me.modname.Size = New System.Drawing.Size(192, 20)
        Me.modname.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Module Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Course ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 26)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "module" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "module ID"
        '
        'delete_mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 334)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AvailMod)
        Me.Controls.Add(Me.deletion)
        Me.Controls.Add(Me.crc)
        Me.Controls.Add(Me.moddesc)
        Me.Controls.Add(Me.modname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "delete_mod"
        Me.Text = "Delete Modules"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AvailMod As System.Windows.Forms.ListBox
    Friend WithEvents deletion As System.Windows.Forms.Button
    Friend WithEvents crc As System.Windows.Forms.ComboBox
    Friend WithEvents moddesc As System.Windows.Forms.TextBox
    Friend WithEvents modname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
