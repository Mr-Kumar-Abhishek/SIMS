﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Certificate_Form
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
        Me.stname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.marks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.modbox = New System.Windows.Forms.ListBox()
        Me.stcode = New System.Windows.Forms.ComboBox()
        Me.crc = New System.Windows.Forms.TextBox()
        Me.grade = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'stname
        '
        Me.stname.Enabled = False
        Me.stname.Location = New System.Drawing.Point(397, 32)
        Me.stname.Name = "stname"
        Me.stname.Size = New System.Drawing.Size(226, 20)
        Me.stname.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Course Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Student Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Student Code :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(272, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Module Taken :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Grade :"
        '
        'marks
        '
        Me.marks.Enabled = False
        Me.marks.Location = New System.Drawing.Point(145, 179)
        Me.marks.Name = "marks"
        Me.marks.Size = New System.Drawing.Size(100, 20)
        Me.marks.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Total Marks :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(91, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 39)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Issue Certificate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(357, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 39)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'modbox
        '
        Me.modbox.Enabled = False
        Me.modbox.FormattingEnabled = True
        Me.modbox.Location = New System.Drawing.Point(397, 110)
        Me.modbox.Name = "modbox"
        Me.modbox.Size = New System.Drawing.Size(226, 43)
        Me.modbox.TabIndex = 20
        '
        'stcode
        '
        Me.stcode.FormattingEnabled = True
        Me.stcode.Location = New System.Drawing.Point(145, 31)
        Me.stcode.Name = "stcode"
        Me.stcode.Size = New System.Drawing.Size(100, 21)
        Me.stcode.TabIndex = 21
        '
        'crc
        '
        Me.crc.Enabled = False
        Me.crc.Location = New System.Drawing.Point(145, 109)
        Me.crc.Name = "crc"
        Me.crc.Size = New System.Drawing.Size(100, 20)
        Me.crc.TabIndex = 22
        '
        'grade
        '
        Me.grade.FormattingEnabled = True
        Me.grade.Items.AddRange(New Object() {"fair", "good", "very good", "excellent"})
        Me.grade.Location = New System.Drawing.Point(397, 179)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(121, 21)
        Me.grade.TabIndex = 23
        '
        'Certificate_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 337)
        Me.Controls.Add(Me.grade)
        Me.Controls.Add(Me.crc)
        Me.Controls.Add(Me.stcode)
        Me.Controls.Add(Me.modbox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.marks)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.stname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Certificate_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Certificate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents marks As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents modbox As System.Windows.Forms.ListBox
    Friend WithEvents stcode As System.Windows.Forms.ComboBox
    Friend WithEvents crc As System.Windows.Forms.TextBox
    Friend WithEvents grade As System.Windows.Forms.ComboBox
End Class
