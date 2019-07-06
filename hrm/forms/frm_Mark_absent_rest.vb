Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization

Public Class frm_Mark_absent_rest

    Private Sub btn_Mark_absent_rest_Click(sender As Object, e As EventArgs) Handles btn_Mark_absent_rest.Click
        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)
            Dim comd As SqlCommand = New SqlCommand("mark_Absent_rest", conn)
            comd.CommandType = CommandType.StoredProcedure
            comd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.ParseExact(forDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture)

            conn.Open()
            comd.ExecuteNonQuery()

            Dim rowsEffected As Integer = comd.ExecuteNonQuery()
            If Math.Abs(rowsEffected) > 0 Then
                MsgBox("Absent / Rest Marked!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
            End If


        End Using
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class