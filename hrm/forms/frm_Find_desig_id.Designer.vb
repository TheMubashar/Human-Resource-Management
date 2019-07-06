<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Find_desig_id
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
        Me.dtgv_Desig = New System.Windows.Forms.DataGridView()
        CType(Me.dtgv_Desig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgv_Desig
        '
        Me.dtgv_Desig.AllowUserToAddRows = False
        Me.dtgv_Desig.AllowUserToDeleteRows = False
        Me.dtgv_Desig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgv_Desig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_Desig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgv_Desig.Location = New System.Drawing.Point(0, 0)
        Me.dtgv_Desig.MultiSelect = False
        Me.dtgv_Desig.Name = "dtgv_Desig"
        Me.dtgv_Desig.ReadOnly = True
        Me.dtgv_Desig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgv_Desig.Size = New System.Drawing.Size(472, 396)
        Me.dtgv_Desig.TabIndex = 28
        '
        'frm_Find_desig_id
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 396)
        Me.Controls.Add(Me.dtgv_Desig)
        Me.Name = "frm_Find_desig_id"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Find_desig_id"
        CType(Me.dtgv_Desig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgv_Desig As System.Windows.Forms.DataGridView
End Class
