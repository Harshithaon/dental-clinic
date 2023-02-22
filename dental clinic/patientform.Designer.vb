<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patientform
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 39)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PATIENT"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.dental_clinic.My.Resources.Resources.images__5_
        Me.PictureBox2.Location = New System.Drawing.Point(613, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(45, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(36, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Phone "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 160)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(119, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(147, 81)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(144, 99)
        Me.TextBox3.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(188, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(363, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "DOB"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(332, 81)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(353, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Gender"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHER"})
        Me.ComboBox1.Location = New System.Drawing.Point(332, 159)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(106, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(479, 80)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(133, 100)
        Me.TextBox4.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(511, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Allergies"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(237, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 33)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(61, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 33)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(413, 206)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 33)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(39, 286)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DeepSkyBlue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Size = New System.Drawing.Size(558, 150)
        Me.DataGridView1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Location = New System.Drawing.Point(270, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Patients list"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 443)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(659, 18)
        Me.Panel2.TabIndex = 46
        '
        'patientform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "patientform"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
End Class
