Imports System.Data.SqlClient
Imports System.Configuration

Public Class frm_Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bnt_sign_in.Click
        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)
            Dim comd As SqlCommand = New SqlCommand("output_the_parameter", conn)
            comd.CommandType = CommandType.StoredProcedure
            comd.Parameters.Add("@user_name", SqlDbType.VarChar, 20).Value = txt_username.Text
            comd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = txt_password.Text
            conn.Open()
            Dim parameter As SqlParameter = New SqlParameter()
            parameter.ParameterName = "@user_type"
            parameter.Size = 15
            parameter.Direction = ParameterDirection.Output
            comd.Parameters.Add(parameter)
            comd.ExecuteNonQuery()
            If (comd.Parameters("@user_type").Value.ToString().Length > 0) Then
                txt_password.Text = String.Empty
                txt_password.Focus()
                frm_Main_menu.Show()
                Me.Hide()
            Else
                MsgBox("Login Failed Try Again", MsgBoxStyle.Exclamation, "Login Error")
                txt_password.Text = String.Empty
                txt_password.Focus()
            End If
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bnt_exit.Click
        Application.Exit()
    End Sub
End Class
