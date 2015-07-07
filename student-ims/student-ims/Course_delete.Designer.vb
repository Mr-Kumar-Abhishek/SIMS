<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course_delete
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
        Me.crc = New System.Windows.Forms.ComboBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.dur = New System.Windows.Forms.NumericUpDown()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.crn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.crc)
        Me.GroupBox1.Controls.Add(Me.delete)
        Me.GroupBox1.Controls.Add(Me.dur)
        Me.GroupBox1.Controls.Add(Me.tf)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.crn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 307)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Course"
        '
        'crc
        '
        Me.crc.FormattingEnabled = True
        Me.crc.Location = New System.Drawing.Point(59, 87)
        Me.crc.Name = "crc"
        Me.crc.Size = New System.Drawing.Size(161, 28)
        Me.crc.TabIndex = 13
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(170, 240)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(156, 38)
        Me.delete.TabIndex = 12
        Me.delete.Text = "Delete This !"
        Me.delete.UseVisualStyleBackColor = True
        '
        'dur
        '
        Me.dur.Enabled = False
        Me.dur.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dur.Location = New System.Drawing.Point(249, 165)
        Me.dur.Name = "dur"
        Me.dur.Size = New System.Drawing.Size(213, 22)
        Me.dur.TabIndex = 9
        '
        'tf
        '
        Me.tf.Enabled = False
        Me.tf.Location = New System.Drawing.Point(62, 159)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 28)
        Me.tf.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Duration  (Weeks)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Fees"
        '
        'crn
        '
        Me.crn.Enabled = False
        Me.crn.Location = New System.Drawing.Point(249, 87)
        Me.crn.Name = "crn"
        Me.crn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.crn.Size = New System.Drawing.Size(213, 28)
        Me.crn.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Code"
        '
        'Course_delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(524, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Course_delete"
        Me.Text = "Course_delete"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents crc As System.Windows.Forms.ComboBox
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents dur As System.Windows.Forms.NumericUpDown
    Friend WithEvents tf As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents crn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
