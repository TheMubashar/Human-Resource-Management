<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Department
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Department))
        Me.dtgv_dept = New System.Windows.Forms.DataGridView()
        Me.bnt_back = New System.Windows.Forms.Button()
        Me.bnt_save = New System.Windows.Forms.Button()
        Me.bnt_new = New System.Windows.Forms.Button()
        Me.bnt_clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_dept_name = New System.Windows.Forms.TextBox()
        Me.txt_dept_id = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dtgv_dept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgv_dept
        '
        Me.dtgv_dept.AllowUserToAddRows = False
        Me.dtgv_dept.AllowUserToDeleteRows = False
        Me.dtgv_dept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgv_dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_dept.Location = New System.Drawing.Point(749, 40)
        Me.dtgv_dept.Margin = New System.Windows.Forms.Padding(2)
        Me.dtgv_dept.MultiSelect = False
        Me.dtgv_dept.Name = "dtgv_dept"
        Me.dtgv_dept.ReadOnly = True
        Me.dtgv_dept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgv_dept.Size = New System.Drawing.Size(508, 698)
        Me.dtgv_dept.TabIndex = 4
        '
        'bnt_back
        '
        Me.bnt_back.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnt_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_back.Location = New System.Drawing.Point(1285, -1)
        Me.bnt_back.Margin = New System.Windows.Forms.Padding(2)
        Me.bnt_back.Name = "bnt_back"
        Me.bnt_back.Size = New System.Drawing.Size(75, 30)
        Me.bnt_back.TabIndex = 5
        Me.bnt_back.Text = "Back"
        Me.bnt_back.UseVisualStyleBackColor = True
        '
        'bnt_save
        '
        Me.bnt_save.Enabled = False
        Me.bnt_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_save.Location = New System.Drawing.Point(289, 424)
        Me.bnt_save.Margin = New System.Windows.Forms.Padding(2)
        Me.bnt_save.Name = "bnt_save"
        Me.bnt_save.Size = New System.Drawing.Size(86, 39)
        Me.bnt_save.TabIndex = 2
        Me.bnt_save.Text = "Save"
        Me.bnt_save.UseVisualStyleBackColor = True
        '
        'bnt_new
        '
        Me.bnt_new.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_new.Location = New System.Drawing.Point(167, 424)
        Me.bnt_new.Margin = New System.Windows.Forms.Padding(2)
        Me.bnt_new.Name = "bnt_new"
        Me.bnt_new.Size = New System.Drawing.Size(93, 39)
        Me.bnt_new.TabIndex = 0
        Me.bnt_new.Text = "New"
        Me.bnt_new.UseVisualStyleBackColor = True
        '
        'bnt_clear
        '
        Me.bnt_clear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_clear.Location = New System.Drawing.Point(401, 424)
        Me.bnt_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.bnt_clear.Name = "bnt_clear"
        Me.bnt_clear.Size = New System.Drawing.Size(96, 38)
        Me.bnt_clear.TabIndex = 3
        Me.bnt_clear.Text = "Clear"
        Me.bnt_clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 298)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Department ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 339)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Department Name :"
        '
        'txt_dept_name
        '
        Me.txt_dept_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_dept_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dept_name.Location = New System.Drawing.Point(290, 337)
        Me.txt_dept_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_dept_name.Name = "txt_dept_name"
        Me.txt_dept_name.Size = New System.Drawing.Size(207, 26)
        Me.txt_dept_name.TabIndex = 1
        '
        'txt_dept_id
        '
        Me.txt_dept_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_dept_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dept_id.Location = New System.Drawing.Point(290, 296)
        Me.txt_dept_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_dept_id.MaxLength = 2
        Me.txt_dept_id.Name = "txt_dept_id"
        Me.txt_dept_id.ReadOnly = True
        Me.txt_dept_id.Size = New System.Drawing.Size(207, 26)
        Me.txt_dept_id.TabIndex = 34
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(77, 99)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(211, 92)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'frm_Department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 741)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txt_dept_id)
        Me.Controls.Add(Me.txt_dept_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnt_clear)
        Me.Controls.Add(Me.bnt_new)
        Me.Controls.Add(Me.bnt_save)
        Me.Controls.Add(Me.bnt_back)
        Me.Controls.Add(Me.dtgv_dept)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Department"
        Me.Text = "frm_Department"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgv_dept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgv_dept As System.Windows.Forms.DataGridView
    Friend WithEvents bnt_back As System.Windows.Forms.Button
    Friend WithEvents bnt_save As System.Windows.Forms.Button
    Friend WithEvents bnt_new As System.Windows.Forms.Button
    Friend WithEvents bnt_clear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_dept_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_dept_id As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
