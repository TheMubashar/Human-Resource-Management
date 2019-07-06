<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mark_absent_rest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Mark_absent_rest))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_Mark_absent_rest = New System.Windows.Forms.Button()
        Me.forDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Close = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(27, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(212, 86)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'btn_Mark_absent_rest
        '
        Me.btn_Mark_absent_rest.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Mark_absent_rest.Location = New System.Drawing.Point(156, 162)
        Me.btn_Mark_absent_rest.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Mark_absent_rest.Name = "btn_Mark_absent_rest"
        Me.btn_Mark_absent_rest.Size = New System.Drawing.Size(209, 37)
        Me.btn_Mark_absent_rest.TabIndex = 17
        Me.btn_Mark_absent_rest.Text = "Mark Absent Rest"
        Me.btn_Mark_absent_rest.UseVisualStyleBackColor = True
        '
        'forDate
        '
        Me.forDate.CustomFormat = "dd-MM-yyyy"
        Me.forDate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.forDate.Location = New System.Drawing.Point(220, 124)
        Me.forDate.Margin = New System.Windows.Forms.Padding(5)
        Me.forDate.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.forDate.Name = "forDate"
        Me.forDate.Size = New System.Drawing.Size(164, 29)
        Me.forDate.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "For Date:"
        '
        'btn_Close
        '
        Me.btn_Close.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.Location = New System.Drawing.Point(438, 14)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(93, 37)
        Me.btn_Close.TabIndex = 18
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'frm_Mark_absent_rest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 261)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_Mark_absent_rest)
        Me.Controls.Add(Me.forDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Mark_absent_rest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Mark_absent_rest"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Mark_absent_rest As System.Windows.Forms.Button
    Friend WithEvents forDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As System.Windows.Forms.Button
End Class
