Imports System.Data.SqlClient
Imports System.Configuration

Public Class frm_Find_desig_id

    Private Sub frm_Find_desig_id_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data()
    End Sub
    Private Sub load_Data()

        Dim connection_String As String = String.Empty
        Dim dt As New DataTable
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)

            Dim comd As SqlCommand = New SqlCommand("select_Designation_data", conn)
            comd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(comd)
            da.Fill(dt)
            dtgv_Desig.DataSource = dt
            dtgv_Desig.Columns("desig_short_description").Visible = False


        End Using
    End Sub
    Private Sub dtgv_Desig_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_Desig.CellContentDoubleClick
        desig_Id = dtgv_Desig.Rows(e.RowIndex).Cells("Desig_Id").Value.ToString()
        desig_Desc = dtgv_Desig.Rows(e.RowIndex).Cells("Desig_description").Value.ToString()
        desig_short_desc = dtgv_Desig.Rows(e.RowIndex).Cells("Desig_short_description").Value.ToString()
        Me.Close()
    End Sub

    Private desig_Id, desig_Desc, desig_short_desc As String

    Public ReadOnly Property get_Desig_short_desc() As String
        Get
            Return desig_short_desc
        End Get

    End Property

    Public ReadOnly Property get_desig_id() As String
        Get
            Return desig_Id
        End Get

    End Property

    Public ReadOnly Property get_Desig_desc() As String
        Get
            Return desig_Desc
        End Get

    End Property
End Class