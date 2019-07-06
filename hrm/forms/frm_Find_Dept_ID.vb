Imports System.Data.SqlClient
Imports System.Configuration

Public Class frm_Find_Dept_ID

    Private Sub frm_Find_Dept_ID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data()
    End Sub

    Private Sub load_Data()

        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Dim dt As New DataTable
        Using conn As New SqlConnection(connection_String)

            Dim comd As SqlCommand = New SqlCommand("select_Department_data", conn)
            comd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(comd)
            da.Fill(dt)
            dtgv_dept.DataSource = dt
        End Using
    End Sub

    Private Sub dtgv_dept_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_dept.CellContentDoubleClick
        dept_Id = dtgv_dept.Rows(e.RowIndex).Cells("Dept_Id").Value.ToString()
        dept_Desc = dtgv_dept.Rows(e.RowIndex).Cells("Dept_description").Value.ToString()
        Me.Close()
    End Sub
    Private dept_Id, dept_Desc As String
    
    Public ReadOnly Property get_Dept_id() As String
        Get
            Return dept_Id
        End Get

    End Property

    Public ReadOnly Property get_Dept_desc() As String
        Get
            Return dept_Desc
        End Get

    End Property

End Class