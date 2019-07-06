<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Designation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Designation))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnt_clear = New System.Windows.Forms.Button()
        Me.bnt_save = New System.Windows.Forms.Button()
        Me.bnt_new = New System.Windows.Forms.Button()
        Me.txt_desig_name = New System.Windows.Forms.TextBox()
        Me.txt_desig_id = New System.Windows.Forms.TextBox()
        Me.bnt_back = New System.Windows.Forms.Button()
        Me.txt_desig_short_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dtgv_Desig = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgv_Desig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Designation Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Designation ID :"
        '
        'bnt_clear
        '
        Me.bnt_clear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_clear.Location = New System.Drawing.Point(456, 476)
        Me.bnt_clear.Name = "bnt_clear"
        Me.bnt_clear.Size = New System.Drawing.Size(96, 38)
        Me.bnt_clear.TabIndex = 4
        Me.bnt_clear.Text = "Clear"
        Me.bnt_clear.UseVisualStyleBackColor = True
        '
        'bnt_save
        '
        Me.bnt_save.Enabled = False
        Me.bnt_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_save.Location = New System.Drawing.Point(354, 476)
        Me.bnt_save.Name = "bnt_save"
        Me.bnt_save.Size = New System.Drawing.Size(96, 38)
        Me.bnt_save.TabIndex = 3
        Me.bnt_save.Text = "Save"
        Me.bnt_save.UseVisualStyleBackColor = True
        '
        'bnt_new
        '
        Me.bnt_new.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_new.Location = New System.Drawing.Point(251, 476)
        Me.bnt_new.Name = "bnt_new"
        Me.bnt_new.Size = New System.Drawing.Size(96, 38)
        Me.bnt_new.TabIndex = 0
        Me.bnt_new.Text = "New"
        Me.bnt_new.UseVisualStyleBackColor = True
        '
        'txt_desig_name
        '
        Me.txt_desig_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_desig_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desig_name.Location = New System.Drawing.Point(248, 370)
        Me.txt_desig_name.Name = "txt_desig_name"
        Me.txt_desig_name.Size = New System.Drawing.Size(190, 26)
        Me.txt_desig_name.TabIndex = 1
        '
        'txt_desig_id
        '
        Me.txt_desig_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_desig_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desig_id.Location = New System.Drawing.Point(248, 328)
        Me.txt_desig_id.MaxLength = 2
        Me.txt_desig_id.Name = "txt_desig_id"
        Me.txt_desig_id.ReadOnly = True
        Me.txt_desig_id.Size = New System.Drawing.Size(190, 26)
        Me.txt_desig_id.TabIndex = 1
        '
        'bnt_back
        '
        Me.bnt_back.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnt_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_back.Location = New System.Drawing.Point(1296, -1)
        Me.bnt_back.Name = "bnt_back"
        Me.bnt_back.Size = New System.Drawing.Size(75, 30)
        Me.bnt_back.TabIndex = 6
        Me.bnt_back.Text = "Back"
        Me.bnt_back.UseVisualStyleBackColor = True
        '
        'txt_desig_short_name
        '
        Me.txt_desig_short_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_desig_short_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desig_short_name.Location = New System.Drawing.Point(248, 412)
        Me.txt_desig_short_name.Name = "txt_desig_short_name"
        Me.txt_desig_short_name.Size = New System.Drawing.Size(190, 26)
        Me.txt_desig_short_name.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Designation Short Description :"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(93, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(211, 92)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'dtgv_Desig
        '
        Me.dtgv_Desig.AllowUserToAddRows = False
        Me.dtgv_Desig.AllowUserToDeleteRows = False
        Me.dtgv_Desig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgv_Desig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_Desig.Location = New System.Drawing.Point(759, 34)
        Me.dtgv_Desig.MultiSelect = False
        Me.dtgv_Desig.Name = "dtgv_Desig"
        Me.dtgv_Desig.ReadOnly = True
        Me.dtgv_Desig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgv_Desig.Size = New System.Drawing.Size(496, 702)
        Me.dtgv_Desig.TabIndex = 5
        '
        'frm_Designation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 769)
        Me.Controls.Add(Me.dtgv_Desig)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnt_clear)
        Me.Controls.Add(Me.bnt_save)
        Me.Controls.Add(Me.bnt_new)
        Me.Controls.Add(Me.txt_desig_name)
        Me.Controls.Add(Me.txt_desig_short_name)
        Me.Controls.Add(Me.txt_desig_id)
        Me.Controls.Add(Me.bnt_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Designation"
        Me.Text = "frm_Designation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgv_Desig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bnt_clear As System.Windows.Forms.Button
    Friend WithEvents bnt_save As System.Windows.Forms.Button
    Friend WithEvents bnt_new As System.Windows.Forms.Button
    Friend WithEvents txt_desig_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_desig_id As System.Windows.Forms.TextBox
    Friend WithEvents bnt_back As System.Windows.Forms.Button
    Friend WithEvents txt_desig_short_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dtgv_Desig As System.Windows.Forms.DataGridView
End Class
