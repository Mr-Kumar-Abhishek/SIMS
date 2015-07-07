<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_mod
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.nxtbtn = New System.Windows.Forms.Button()
        Me.crc = New System.Windows.Forms.ComboBox()
        Me.moddesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.modname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(151, 113)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(192, 121)
        Me.ListBox1.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(407, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 21)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'nxtbtn
        '
        Me.nxtbtn.Location = New System.Drawing.Point(261, 260)
        Me.nxtbtn.Name = "nxtbtn"
        Me.nxtbtn.Size = New System.Drawing.Size(113, 21)
        Me.nxtbtn.TabIndex = 27
        Me.nxtbtn.Text = "save"
        Me.nxtbtn.UseVisualStyleBackColor = True
        '
        'crc
        '
        Me.crc.FormattingEnabled = True
        Me.crc.Location = New System.Drawing.Point(151, 35)
        Me.crc.Name = "crc"
        Me.crc.Size = New System.Drawing.Size(192, 21)
        Me.crc.TabIndex = 26
        '
        'moddesc
        '
        Me.moddesc.Location = New System.Drawing.Point(469, 174)
        Me.moddesc.Multiline = True
        Me.moddesc.Name = "moddesc"
        Me.moddesc.Size = New System.Drawing.Size(231, 60)
        Me.moddesc.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 26)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "module" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "description"
        '
        'modname
        '
        Me.modname.Location = New System.Drawing.Point(469, 109)
        Me.modname.Name = "modname"
        Me.modname.Size = New System.Drawing.Size(231, 20)
        Me.modname.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-57, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Course ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "module ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Module Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Course ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Available Modues"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(469, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 20)
        Me.TextBox1.TabIndex = 33
        '
        'Add_mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 308)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.nxtbtn)
        Me.Controls.Add(Me.crc)
        Me.Controls.Add(Me.moddesc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.modname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_mod"
        Me.Text = "Add Modules"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents nxtbtn As System.Windows.Forms.Button
    Friend WithEvents crc As System.Windows.Forms.ComboBox
    Friend WithEvents moddesc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents modname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
