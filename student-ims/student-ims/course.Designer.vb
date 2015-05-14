<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class course
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crc = New System.Windows.Forms.TextBox()
        Me.crn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.NumericUpDown()
        Me.dur = New System.Windows.Forms.NumericUpDown()
        Me.save = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cancel)
        Me.GroupBox1.Controls.Add(Me.save)
        Me.GroupBox1.Controls.Add(Me.dur)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.tf)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.crn)
        Me.GroupBox1.Controls.Add(Me.crc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 361)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Course"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Name"
        '
        'crc
        '
        Me.crc.Location = New System.Drawing.Point(42, 92)
        Me.crc.Name = "crc"
        Me.crc.Size = New System.Drawing.Size(100, 28)
        Me.crc.TabIndex = 2
        '
        'crn
        '
        Me.crn.Location = New System.Drawing.Point(229, 92)
        Me.crn.Name = "crn"
        Me.crn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.crn.Size = New System.Drawing.Size(213, 28)
        Me.crn.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Fees"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "No. of Modules"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(337, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Duration  (Weeks)"
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(42, 164)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 28)
        Me.tf.TabIndex = 7
        '
        'nom
        '
        Me.nom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(184, 164)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(120, 22)
        Me.nom.TabIndex = 8
        '
        'dur
        '
        Me.dur.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dur.Location = New System.Drawing.Point(341, 164)
        Me.dur.Name = "dur"
        Me.dur.Size = New System.Drawing.Size(120, 22)
        Me.dur.TabIndex = 9
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.Location = New System.Drawing.Point(122, 258)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(90, 38)
        Me.save.TabIndex = 10
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(249, 258)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(94, 38)
        Me.cancel.TabIndex = 12
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(566, 423)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "course"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "course"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents crn As System.Windows.Forms.TextBox
    Friend WithEvents crc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents dur As System.Windows.Forms.NumericUpDown
    Friend WithEvents nom As System.Windows.Forms.NumericUpDown
    Friend WithEvents tf As System.Windows.Forms.TextBox
End Class
