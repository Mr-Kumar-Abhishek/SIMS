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
        Me.AvailMod = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.crc = New System.Windows.Forms.ComboBox()
        Me.moddesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.modname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.modid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.clrmod = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AvailMod
        '
        Me.AvailMod.FormattingEnabled = True
        Me.AvailMod.ItemHeight = 20
        Me.AvailMod.Location = New System.Drawing.Point(170, 130)
        Me.AvailMod.Name = "AvailMod"
        Me.AvailMod.Size = New System.Drawing.Size(192, 144)
        Me.AvailMod.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(681, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 34)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Addbtn
        '
        Me.Addbtn.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbtn.Location = New System.Drawing.Point(128, 257)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(113, 30)
        Me.Addbtn.TabIndex = 27
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'crc
        '
        Me.crc.FormattingEnabled = True
        Me.crc.Location = New System.Drawing.Point(170, 49)
        Me.crc.Name = "crc"
        Me.crc.Size = New System.Drawing.Size(192, 28)
        Me.crc.TabIndex = 26
        '
        'moddesc
        '
        Me.moddesc.Location = New System.Drawing.Point(158, 171)
        Me.moddesc.Multiline = True
        Me.moddesc.Name = "moddesc"
        Me.moddesc.Size = New System.Drawing.Size(231, 60)
        Me.moddesc.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 40)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "module" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "description"
        '
        'modname
        '
        Me.modname.Location = New System.Drawing.Point(158, 106)
        Me.modname.Name = "modname"
        Me.modname.Size = New System.Drawing.Size(231, 28)
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
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "module ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Module Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Course ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Available Modues"
        '
        'modid
        '
        Me.modid.Location = New System.Drawing.Point(158, 32)
        Me.modid.Name = "modid"
        Me.modid.Size = New System.Drawing.Size(231, 28)
        Me.modid.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.crc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.AvailMod)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 304)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Course"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.clrmod)
        Me.GroupBox2.Controls.Add(Me.modid)
        Me.GroupBox2.Controls.Add(Me.Addbtn)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.modname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.moddesc)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(421, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(407, 304)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Modules"
        '
        'clrmod
        '
        Me.clrmod.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clrmod.Location = New System.Drawing.Point(260, 257)
        Me.clrmod.Name = "clrmod"
        Me.clrmod.Size = New System.Drawing.Size(113, 30)
        Me.clrmod.TabIndex = 34
        Me.clrmod.Text = "clear"
        Me.clrmod.UseVisualStyleBackColor = True
        '
        'Add_mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(844, 368)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Add_mod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Modules"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AvailMod As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Addbtn As System.Windows.Forms.Button
    Friend WithEvents crc As System.Windows.Forms.ComboBox
    Friend WithEvents moddesc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents modname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents modid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents clrmod As System.Windows.Forms.Button
End Class
