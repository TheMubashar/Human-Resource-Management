Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization

Public Class frm_Genrate_Salary

    Private Sub btn_Generate_salary_Click(sender As Object, e As EventArgs) Handles btn_Generate_salary.Click
        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)
            Dim comd As SqlCommand = New SqlCommand("insert_Salary_tenure", conn)
            comd.CommandType = CommandType.StoredProcedure
            comd.Parameters.Add("@from_Date", SqlDbType.Date).Value = DateTime.ParseExact(fromDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture)
            comd.Parameters.Add("@to_Date", SqlDbType.Date).Value = DateTime.ParseExact(toDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture)

            Dim tenure_ID As New SqlParameter()
            tenure_ID.ParameterName = "@tenure_ID"
            tenure_ID.SqlDbType = SqlDbType.Decimal
            tenure_ID.Size = 5
            tenure_ID.Direction = System.Data.ParameterDirection.Output
            comd.Parameters.Add(tenure_ID)

            Dim o_Msg As New SqlParameter()
            o_Msg.ParameterName = "@o_Msg"
            o_Msg.SqlDbType = SqlDbType.VarChar
            o_Msg.Size = 30
            o_Msg.Direction = System.Data.ParameterDirection.Output
            comd.Parameters.Add(o_Msg)

            conn.Open()
            comd.ExecuteNonQuery()
            If o_Msg.Value.ToString() = "SUCCESS" Then
                Dim gen_Salary_comd As SqlCommand = New SqlCommand("gen_Salary", conn)
                gen_Salary_comd.CommandType = CommandType.StoredProcedure
                gen_Salary_comd.Parameters.Add("@tenure_Id", SqlDbType.Decimal, 5).Value = Decimal.Parse(tenure_ID.Value.ToString())


                Dim rowsEffected As Integer = gen_Salary_comd.ExecuteNonQuery()
                If rowsEffected > 0 Then
                    MsgBox("Salary Generated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
                End If

            Else
                MsgBox("Salary Already Generated, Select Different Dates to Generate Salary", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Caution")

            End If
        End Using
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class