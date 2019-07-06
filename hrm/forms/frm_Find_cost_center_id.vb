Imports System.Data.SqlClient
Imports System.Configuration

Public Class frm_Find_cost_center_id

    Private Sub frm_Find_cost_center_id_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data()
    End Sub


    Private Sub load_Data()
        Dim dt As New DataTable
        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)

            Dim comd As SqlCommand = New SqlCommand("select_cost_centre_data", conn)
            comd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(comd)
            da.Fill(dt)
            dtgv_cost_center.DataSource = dt
            dtgv_cost_center.Columns("dept_Id").Visible = False

        End Using
    End Sub


    Private Sub dtgv_cost_center_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_cost_center.CellContentDoubleClick
        cost_center_id = dtgv_cost_center.Rows(e.RowIndex).Cells("cost_center_id").Value.ToString()
        cost_center_desc = dtgv_cost_center.Rows(e.RowIndex).Cells("cost_center_description").Value.ToString()
        Me.Close()
    End Sub

    Private cost_center_id, cost_center_desc As String

    Public ReadOnly Property get_cost_center_id() As String
        Get
            Return cost_center_id
        End Get

    End Property

    Public ReadOnly Property get_cost_center_desc() As String
        Get
            Return cost_center_desc
        End Get

    End Property

End Class