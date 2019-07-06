<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Attendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Attendance))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bnt_back = New System.Windows.Forms.Button()
        Me.pb_Employee_image = New System.Windows.Forms.PictureBox()
        Me.pb_Status = New System.Windows.Forms.PictureBox()
        Me.txt_Time = New System.Windows.Forms.TextBox()
        Me.txt_Emp_id = New System.Windows.Forms.TextBox()
        Me.txt_Emp_dept = New System.Windows.Forms.TextBox()
        Me.txt_Emp_designation = New System.Windows.Forms.TextBox()
        Me.txt_Emp_name = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txt_Emp_code = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_Message = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Employee_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(31, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(211, 92)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'bnt_back
        '
        Me.bnt_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_back.Location = New System.Drawing.Point(1298, -1)
        Me.bnt_back.Name = "bnt_back"
        Me.bnt_back.Size = New System.Drawing.Size(75, 30)
        Me.bnt_back.TabIndex = 1
        Me.bnt_back.Text = "Back"
        Me.bnt_back.UseVisualStyleBackColor = True
        '
        'pb_Employee_image
        '
        Me.pb_Employee_image.BackColor = System.Drawing.SystemColors.Control
        Me.pb_Employee_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_Employee_image.Location = New System.Drawing.Point(851, 171)
        Me.pb_Employee_image.Name = "pb_Employee_image"
        Me.pb_Employee_image.Size = New System.Drawing.Size(265, 283)
        Me.pb_Employee_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Employee_image.TabIndex = 108
        Me.pb_Employee_image.TabStop = False
        '
        'pb_Status
        '
        Me.pb_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_Status.Location = New System.Drawing.Point(261, 138)
        Me.pb_Status.Name = "pb_Status"
        Me.pb_Status.Size = New System.Drawing.Size(584, 347)
        Me.pb_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Status.TabIndex = 120
        Me.pb_Status.TabStop = False
        '
        'txt_Time
        '
        Me.txt_Time.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Time.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Time.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Time.ForeColor = System.Drawing.Color.Red
        Me.txt_Time.Location = New System.Drawing.Point(849, 140)
        Me.txt_Time.Name = "txt_Time"
        Me.txt_Time.ReadOnly = True
        Me.txt_Time.Size = New System.Drawing.Size(267, 25)
        Me.txt_Time.TabIndex = 114
        Me.txt_Time.TabStop = False
        Me.txt_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Emp_id
        '
        Me.txt_Emp_id.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Emp_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Emp_id.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Emp_id.Location = New System.Drawing.Point(261, 491)
        Me.txt_Emp_id.Name = "txt_Emp_id"
        Me.txt_Emp_id.ReadOnly = True
        Me.txt_Emp_id.Size = New System.Drawing.Size(261, 32)
        Me.txt_Emp_id.TabIndex = 119
        Me.txt_Emp_id.TabStop = False
        Me.txt_Emp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Emp_dept
        '
        Me.txt_Emp_dept.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Emp_dept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Emp_dept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Emp_dept.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Emp_dept.Location = New System.Drawing.Point(261, 552)
        Me.txt_Emp_dept.Name = "txt_Emp_dept"
        Me.txt_Emp_dept.ReadOnly = True
        Me.txt_Emp_dept.Size = New System.Drawing.Size(545, 32)
        Me.txt_Emp_dept.TabIndex = 115
        Me.txt_Emp_dept.TabStop = False
        '
        'txt_Emp_designation
        '
        Me.txt_Emp_designation.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Emp_designation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Emp_designation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Emp_designation.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Emp_designation.Location = New System.Drawing.Point(261, 586)
        Me.txt_Emp_designation.Name = "txt_Emp_designation"
        Me.txt_Emp_designation.ReadOnly = True
        Me.txt_Emp_designation.Size = New System.Drawing.Size(545, 32)
        Me.txt_Emp_designation.TabIndex = 116
        Me.txt_Emp_designation.TabStop = False
        '
        'txt_Emp_name
        '
        Me.txt_Emp_name.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Emp_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Emp_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Emp_name.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Emp_name.Location = New System.Drawing.Point(261, 519)
        Me.txt_Emp_name.Name = "txt_Emp_name"
        Me.txt_Emp_name.ReadOnly = True
        Me.txt_Emp_name.Size = New System.Drawing.Size(582, 32)
        Me.txt_Emp_name.TabIndex = 117
        Me.txt_Emp_name.TabStop = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(248, 102)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(263, 33)
        Me.label3.TabIndex = 113
        Me.label3.Text = "Employee Attendance"
        '
        'txt_Emp_code
        '
        Me.txt_Emp_code.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Emp_code.Location = New System.Drawing.Point(990, 459)
        Me.txt_Emp_code.MaxLength = 5
        Me.txt_Emp_code.Name = "txt_Emp_code"
        Me.txt_Emp_code.Size = New System.Drawing.Size(102, 26)
        Me.txt_Emp_code.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(849, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 373)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee"
        '
        'lbl_Message
        '
        Me.lbl_Message.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Message.AutoSize = True
        Me.lbl_Message.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Message.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Message.ForeColor = System.Drawing.Color.White
        Me.lbl_Message.Location = New System.Drawing.Point(231, 583)
        Me.lbl_Message.Name = "lbl_Message"
        Me.lbl_Message.Size = New System.Drawing.Size(0, 31)
        Me.lbl_Message.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Code :"
        '
        'frm_Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 643)
        Me.Controls.Add(Me.pb_Employee_image)
        Me.Controls.Add(Me.pb_Status)
        Me.Controls.Add(Me.txt_Time)
        Me.Controls.Add(Me.txt_Emp_id)
        Me.Controls.Add(Me.lbl_Message)
        Me.Controls.Add(Me.txt_Emp_dept)
        Me.Controls.Add(Me.txt_Emp_designation)
        Me.Controls.Add(Me.txt_Emp_name)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txt_Emp_code)
        Me.Controls.Add(Me.bnt_back)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Attendance"
        Me.Text = "frm_Attendance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Employee_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents bnt_back As System.Windows.Forms.Button
    Private WithEvents pb_Employee_image As System.Windows.Forms.PictureBox
    Private WithEvents pb_Status As System.Windows.Forms.PictureBox
    Private WithEvents txt_Time As System.Windows.Forms.TextBox
    Private WithEvents txt_Emp_id As System.Windows.Forms.TextBox
    Private WithEvents txt_Emp_dept As System.Windows.Forms.TextBox
    Private WithEvents txt_Emp_designation As System.Windows.Forms.TextBox
    Private WithEvents txt_Emp_name As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txt_Emp_code As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lbl_Message As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
