<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Find_Dept_ID
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
        Me.dtgv_dept = New System.Windows.Forms.DataGridView()
        CType(Me.dtgv_dept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgv_dept
        '
        Me.dtgv_dept.AllowUserToAddRows = False
        Me.dtgv_dept.AllowUserToDeleteRows = False
        Me.dtgv_dept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgv_dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_dept.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgv_dept.Location = New System.Drawing.Point(0, 0)
        Me.dtgv_dept.MultiSelect = False
        Me.dtgv_dept.Name = "dtgv_dept"
        Me.dtgv_dept.ReadOnly = True
        Me.dtgv_dept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgv_dept.Size = New System.Drawing.Size(472, 396)
        Me.dtgv_dept.TabIndex = 19
        '
        'frm_Find_Dept_ID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 396)
        Me.Controls.Add(Me.dtgv_dept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Find_Dept_ID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Find_Dept_ID"
        CType(Me.dtgv_dept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgv_dept As System.Windows.Forms.DataGridView
End Class
