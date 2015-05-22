<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addmission_Form
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar3 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.cancel = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.modbox = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.endate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.stdate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.crf = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.crc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.tele = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.TextBox()
        Me.dob = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.stdname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stdcode = New System.Windows.Forms.TextBox()
        Me.qual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.course = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(522, 224)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 12
        Me.MonthCalendar1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MonthCalendar3)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar2)
        Me.GroupBox1.Controls.Add(Me.cancel)
        Me.GroupBox1.Controls.Add(Me.ok)
        Me.GroupBox1.Controls.Add(Me.modbox)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.endate)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.stdate)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.crf)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.crc)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 410)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 320)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Course Details"
        Me.GroupBox1.Visible = False
        '
        'MonthCalendar3
        '
        Me.MonthCalendar3.Location = New System.Drawing.Point(407, 145)
        Me.MonthCalendar3.Name = "MonthCalendar3"
        Me.MonthCalendar3.TabIndex = 13
        Me.MonthCalendar3.Visible = False
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(183, 13)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 12
        Me.MonthCalendar2.Visible = False
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(341, 177)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 11
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(192, 177)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 10
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'modbox
        '
        Me.modbox.FormattingEnabled = True
        Me.modbox.ItemHeight = 20
        Me.modbox.Location = New System.Drawing.Point(573, 76)
        Me.modbox.Name = "modbox"
        Me.modbox.Size = New System.Drawing.Size(120, 124)
        Me.modbox.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(569, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 20)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Module Details"
        '
        'endate
        '
        Me.endate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endate.Location = New System.Drawing.Point(422, 125)
        Me.endate.Name = "endate"
        Me.endate.Size = New System.Drawing.Size(100, 20)
        Me.endate.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(308, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Ending Date :"
        '
        'stdate
        '
        Me.stdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdate.Location = New System.Drawing.Point(137, 125)
        Me.stdate.Name = "stdate"
        Me.stdate.Size = New System.Drawing.Size(100, 20)
        Me.stdate.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Starting Date :"
        '
        'crf
        '
        Me.crf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crf.Location = New System.Drawing.Point(422, 58)
        Me.crf.Name = "crf"
        Me.crf.Size = New System.Drawing.Size(100, 20)
        Me.crf.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(308, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Course Fees :"
        '
        'crc
        '
        Me.crc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crc.Location = New System.Drawing.Point(137, 58)
        Me.crc.Name = "crc"
        Me.crc.Size = New System.Drawing.Size(109, 20)
        Me.crc.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Course Code :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender :"
        '
        'gender
        '
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"male", "female"})
        Me.gender.Location = New System.Drawing.Point(155, 70)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(136, 21)
        Me.gender.TabIndex = 9
        '
        'tele
        '
        Me.tele.Location = New System.Drawing.Point(527, 71)
        Me.tele.Name = "tele"
        Me.tele.Size = New System.Drawing.Size(187, 20)
        Me.tele.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(414, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date of Birth :"
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(155, 118)
        Me.add.Multiline = True
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(136, 57)
        Me.add.TabIndex = 5
        '
        'dob
        '
        Me.dob.Location = New System.Drawing.Point(527, 118)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(136, 20)
        Me.dob.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(414, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Course :"
        '
        'stdname
        '
        Me.stdname.Location = New System.Drawing.Point(527, 12)
        Me.stdname.Name = "stdname"
        Me.stdname.Size = New System.Drawing.Size(205, 20)
        Me.stdname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(414, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Qualification :"
        '
        'stdcode
        '
        Me.stdcode.Location = New System.Drawing.Point(155, 21)
        Me.stdcode.Name = "stdcode"
        Me.stdcode.Size = New System.Drawing.Size(136, 20)
        Me.stdcode.TabIndex = 1
        '
        'qual
        '
        Me.qual.Location = New System.Drawing.Point(155, 217)
        Me.qual.Name = "qual"
        Me.qual.Size = New System.Drawing.Size(136, 20)
        Me.qual.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Code :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(309, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 33)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Course Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(414, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telephone :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.course)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.qual)
        Me.Panel1.Controls.Add(Me.stdcode)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.stdname)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dob)
        Me.Panel1.Controls.Add(Me.add)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tele)
        Me.Panel1.Controls.Add(Me.gender)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(16, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 381)
        Me.Panel1.TabIndex = 18
        '
        'course
        '
        Me.course.FormattingEnabled = True
        Me.course.Location = New System.Drawing.Point(527, 198)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(205, 21)
        Me.course.TabIndex = 18
        '
        'Addmission_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 742)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Addmission_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addmission_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gender As System.Windows.Forms.ComboBox
    Friend WithEvents tele As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents add As System.Windows.Forms.TextBox
    Friend WithEvents dob As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents stdname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents stdcode As System.Windows.Forms.TextBox
    Friend WithEvents qual As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents endate As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents stdate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents crf As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents crc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar3 As System.Windows.Forms.MonthCalendar
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents modbox As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents course As System.Windows.Forms.ComboBox
End Class
