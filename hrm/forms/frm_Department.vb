Imports System.Data.SqlClient
Imports System.Configuration

Public Class frm_Department
    Private is_Query_mode As Boolean = False
    Private dept_Id As String = String.Empty
    Private dt_Dept As New ds_HRM.dt_DepartmentDataTable
    Private Sub bnt_new_Click(sender As Object, e As EventArgs) Handles bnt_new.Click
        txt_dept_id.Text = String.Empty
        txt_dept_name.Text = String.Empty
        get_New_deptt_code()
        bnt_save.Enabled = True
        txt_dept_name.Focus()

    End Sub

    Private Sub get_New_deptt_code()

        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)
            Dim comd As SqlCommand = New SqlCommand("get_deptt_code", conn)
            comd.CommandType = CommandType.StoredProcedure
            conn.Open()
            dept_Id = comd.ExecuteScalar()
            If (dept_Id.Length > 0) Then
                txt_dept_id.Text = dept_Id
            End If
        End Using

    End Sub

    Private Sub frm_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgv_dept.DataSource = dt_Dept
        load_Data()

    End Sub

    Private Sub bnt_save_Click(sender As Object, e As EventArgs) Handles bnt_save.Click
        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        If (is_Query_mode = False) Then

            Using conn As New SqlConnection(connection_String)
                Dim comd As SqlCommand = New SqlCommand("insert_New_dept_data", conn)
                comd.CommandType = CommandType.StoredProcedure
                comd.Parameters.Add("@dept_Id", SqlDbType.VarChar, 2).Value = txt_dept_id.Text
                comd.Parameters.Add("@dept_description", SqlDbType.VarChar, 50).Value = txt_dept_name.Text
                conn.Open()
                comd.ExecuteNonQuery()
                load_Data()
                MsgBox("Record Saved")
                txt_dept_id.Text = String.Empty
                txt_dept_name.Text = String.Empty
                bnt_save.Enabled = False
            End Using
        Else
            Using conn As New SqlConnection(connection_String)
                Dim comd As SqlCommand = New SqlCommand("update_Department", conn)
                comd.CommandType = CommandType.StoredProcedure
                comd.Parameters.Add("@dept_Id", SqlDbType.VarChar, 2).Value = txt_dept_id.Text
                comd.Parameters.Add("@dept_description", SqlDbType.VarChar, 50).Value = txt_dept_name.Text
                conn.Open()
                comd.ExecuteNonQuery()
                load_Data()
                txt_dept_id.Text = String.Empty
                txt_dept_name.Text = String.Empty
                bnt_save.Enabled = False
            End Using
        End If
    End Sub

    Private Sub load_Data()

        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)
            dt_Dept.Rows.Clear()
            Dim comd As SqlCommand = New SqlCommand("select_Department_data", conn)
            comd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(comd)
            da.Fill(dt_Dept)

        End Using
    End Sub

    Private Sub dtgv_dept_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_dept.CellDoubleClick

        txt_dept_id.Text = dtgv_dept.Rows(e.RowIndex).Cells("dept_id").Value.ToString
        txt_dept_name.Text = dtgv_dept.Rows(e.RowIndex).Cells("dept_description").Value.ToString
        is_Query_mode = True
        bnt_save.Enabled = True
        txt_dept_name.Focus()

    End Sub

    Private Sub bnt_clear_Click(sender As Object, e As EventArgs) Handles bnt_clear.Click

        is_Query_mode = False
        bnt_save.Enabled = False
        txt_dept_id.Text = String.Empty
        txt_dept_name.Text = String.Empty

    End Sub
    Private Sub bnt_back_Click(sender As Object, e As EventArgs) Handles bnt_back.Click
        frm_Main_menu.Show()
        Me.Close()

    End Sub
End Class