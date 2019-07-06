<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main_menu))
        Me.bnt_log_out = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CodingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TranscationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAbsentRestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeSalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnt_log_out
        '
        Me.bnt_log_out.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnt_log_out.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_log_out.Location = New System.Drawing.Point(648, -4)
        Me.bnt_log_out.Name = "bnt_log_out"
        Me.bnt_log_out.Size = New System.Drawing.Size(75, 30)
        Me.bnt_log_out.TabIndex = 7
        Me.bnt_log_out.Text = "Log Out"
        Me.bnt_log_out.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodingToolStripMenuItem, Me.TranscationToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CodingToolStripMenuItem
        '
        Me.CodingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentsToolStripMenuItem, Me.DesignationToolStripMenuItem})
        Me.CodingToolStripMenuItem.Name = "CodingToolStripMenuItem"
        Me.CodingToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.CodingToolStripMenuItem.Text = "Coding"
        '
        'DepartmentsToolStripMenuItem
        '
        Me.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        Me.DepartmentsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DepartmentsToolStripMenuItem.Text = "Departments"
        '
        'DesignationToolStripMenuItem
        '
        Me.DesignationToolStripMenuItem.Name = "DesignationToolStripMenuItem"
        Me.DesignationToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DesignationToolStripMenuItem.Text = "Designation"
        '
        'TranscationToolStripMenuItem
        '
        Me.TranscationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeProfileToolStripMenuItem, Me.ManualAttendanceToolStripMenuItem, Me.MarkAbsentRestToolStripMenuItem, Me.EmployeeSalaryToolStripMenuItem})
        Me.TranscationToolStripMenuItem.Name = "TranscationToolStripMenuItem"
        Me.TranscationToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TranscationToolStripMenuItem.Text = "Transaction"
        '
        'EmployeeProfileToolStripMenuItem
        '
        Me.EmployeeProfileToolStripMenuItem.Name = "EmployeeProfileToolStripMenuItem"
        Me.EmployeeProfileToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EmployeeProfileToolStripMenuItem.Text = "Employee Profile"
        '
        'ManualAttendanceToolStripMenuItem
        '
        Me.ManualAttendanceToolStripMenuItem.Name = "ManualAttendanceToolStripMenuItem"
        Me.ManualAttendanceToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ManualAttendanceToolStripMenuItem.Text = "Attendance"
        '
        'MarkAbsentRestToolStripMenuItem
        '
        Me.MarkAbsentRestToolStripMenuItem.Name = "MarkAbsentRestToolStripMenuItem"
        Me.MarkAbsentRestToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.MarkAbsentRestToolStripMenuItem.Text = "Mark Absent/Rest"
        '
        'EmployeeSalaryToolStripMenuItem
        '
        Me.EmployeeSalaryToolStripMenuItem.Name = "EmployeeSalaryToolStripMenuItem"
        Me.EmployeeSalaryToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EmployeeSalaryToolStripMenuItem.Text = "Employee Salary"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.DesignationToolStripMenuItem1, Me.DepartmentToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.SalaryToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'DesignationToolStripMenuItem1
        '
        Me.DesignationToolStripMenuItem1.Name = "DesignationToolStripMenuItem1"
        Me.DesignationToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.DesignationToolStripMenuItem1.Text = "Designation"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'SalaryToolStripMenuItem
        '
        Me.SalaryToolStripMenuItem.Name = "SalaryToolStripMenuItem"
        Me.SalaryToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SalaryToolStripMenuItem.Text = "Salary"
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(214, 27)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(293, 89)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 110
        Me.pictureBox1.TabStop = False
        '
        'frm_Main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(721, 441)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.bnt_log_out)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_Main_menu"
        Me.Text = "frm_Main_menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnt_log_out As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CodingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TranscationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeSalaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DesignationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkAbsentRestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
