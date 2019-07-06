Imports System.Data.SqlClient
Imports System.Configuration
Public Class frm_Designation

    Private Sub bnt_back_Click(sender As Object, e As EventArgs) Handles bnt_back.Click
        frm_Main_menu.Show()
        Me.Close()
    End Sub
    Private dt_Desig As New ds_HRM.dt_DesignationDataTable
    Private desig_id As String = String.Empty
    Private is_Query_mode As Boolean = False

    Private Sub frm_Designation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgv_Desig.DataSource = dt_Desig
        load_Data()

       End Sub

    Private Sub bnt_save_Click(sender As Object, e As EventArgs) Handles bnt_save.Click

        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        If (is_Query_mode = False) Then

            Using conn As New SqlConnection(connection_String)
                Dim comd As SqlCommand = New SqlCommand("insert_designations", conn)
                comd.CommandType = CommandType.StoredProcedure
                comd.Parameters.Add("@desig_id", SqlDbType.VarChar, 3).Value = txt_desig_id.Text
                comd.Parameters.Add("@Desig_description", SqlDbType.VarChar, 30).Value = txt_desig_name.Text
                comd.Parameters.Add("@Desig_short_description", SqlDbType.VarChar, 10).Value = txt_desig_short_name.Text
                conn.Open()
                comd.ExecuteNonQuery()
                load_Data()
                MsgBox("Record Saved")
                txt_desig_id.Text = String.Empty
                txt_desig_name.Text = String.Empty
                txt_desig_short_name.Text = String.Empty
                bnt_save.Enabled = False
            End Using
        Else
            Using conn As New SqlConnection(connection_String)
                Dim comd As SqlCommand = New SqlCommand("update_Designations", conn)
                comd.CommandType = CommandType.StoredProcedure
                comd.Parameters.Add("@desig_id", SqlDbType.VarChar, 3).Value = txt_desig_id.Text
                comd.Parameters.Add("@Desig_description", SqlDbType.VarChar, 30).Value = txt_desig_name.Text
                comd.Parameters.Add("@Desig_short_description", SqlDbType.VarChar, 10).Value = txt_desig_short_name.Text
                conn.Open()
                comd.ExecuteNonQuery()
                load_Data()
                txt_desig_id.Text = String.Empty
                txt_desig_name.Text = String.Empty
                txt_desig_short_name.Text = String.Empty
                bnt_save.Enabled = False
            End Using
        End If
    End Sub
    Private Sub load_Data()

        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)
            dt_Desig.Rows.Clear()
            Dim comd As SqlCommand = New SqlCommand("select_Designation_data", conn)
            comd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(comd)
            da.Fill(dt_Desig)

        End Using
    End Sub

    Private Sub dtgv_Desig_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_Desig.CellContentDoubleClick

        txt_desig_id.Text = dtgv_Desig.Rows(e.RowIndex).Cells("desig_id").Value.ToString
        txt_desig_name.Text = dtgv_Desig.Rows(e.RowIndex).Cells("desig_description").Value.ToString
        txt_desig_short_name.Text = dtgv_Desig.Rows(e.RowIndex).Cells("desig_short_description").Value.ToString
        is_Query_mode = True
        bnt_save.Enabled = True
        txt_desig_name.Focus()

    End Sub

    Private Sub bnt_clear_Click(sender As Object, e As EventArgs) Handles bnt_clear.Click

        is_Query_mode = False
        bnt_save.Enabled = False
        txt_desig_id.Text = String.Empty
        txt_desig_name.Text = String.Empty
        txt_desig_short_name.Text = String.Empty

    End Sub

    Private Sub bnt_new_Click(sender As Object, e As EventArgs) Handles bnt_new.Click
        txt_desig_id.Text = String.Empty
        txt_desig_name.Text = String.Empty
        txt_desig_short_name.Text = String.Empty
        get_New_desig_code()
        bnt_save.Enabled = True
        txt_desig_name.Focus()

    End Sub


    Private Sub get_New_desig_code()
        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)
            Dim comd As SqlCommand = New SqlCommand("get_desig_code", conn)
            comd.CommandType = CommandType.StoredProcedure
            conn.Open()
            desig_id = comd.ExecuteScalar()
            If (desig_id.Length > 0) Then
                txt_desig_id.Text = desig_id
            End If
        End Using
    End Sub
End Class
