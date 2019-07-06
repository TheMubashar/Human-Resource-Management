Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_Attendance

    Private Sub bnt_back_Click(sender As Object, e As EventArgs) Handles bnt_back.Click
        frm_Main_menu.Show()
        Me.Close()
    End Sub

    Private Sub txt_Emp_code_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Emp_code.KeyUp


        If e.KeyCode = Keys.Enter Then
            Mark_Attendance(txt_Emp_code.Text)
            txt_Emp_code.Text = String.Empty
        End If

    End Sub

    Private Sub Mark_Attendance(e_code As String)

        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)
            Dim comd As SqlCommand = New SqlCommand("emp_InOut", conn)
            comd.CommandType = CommandType.StoredProcedure
            comd.Parameters.Add("@emp_Code", SqlDbType.VarChar, 5).Value = txt_Emp_code.Text


            Dim emp_Name As New SqlParameter()
            emp_Name.ParameterName = "@emp_Name"
            emp_Name.SqlDbType = SqlDbType.VarChar
            emp_Name.Size = 30
            emp_Name.Direction = System.Data.ParameterDirection.Output
            comd.Parameters.Add(emp_Name)


            Dim emp_Last_name As New SqlParameter()
            emp_Last_name.ParameterName = "@emp_Last_name"
            emp_Last_name.SqlDbType = SqlDbType.VarChar
            emp_Last_name.Size = 30
            emp_Last_name.Direction = System.Data.ParameterDirection.Output
            comd.Parameters.Add(emp_Last_name)


            Dim emp_Designation As New SqlParameter()
            emp_Designation.ParameterName = "@emp_Designation"
            emp_Designation.SqlDbType = SqlDbType.VarChar
            emp_Designation.Size = 30
            emp_Designation.Direction = System.Data.ParameterDirection.Output
            comd.Parameters.Add(emp_Designation)


            Dim emp_Department As New SqlParameter()
            emp_Department.ParameterName = "@emp_Department"
            emp_Department.SqlDbType = SqlDbType.VarChar
            emp_Department.Size = 50
            emp_Department.Direction = System.Data.ParameterDirection.Output
            comd.Parameters.Add(emp_Department)


            Dim emp_InOut_status As New SqlParameter()
            emp_InOut_status.ParameterName = "@emp_InOut_status"
            emp_InOut_status.SqlDbType = SqlDbType.VarChar
            emp_InOut_status.Size = 1
            emp_InOut_status.Direction = System.Data.ParameterDirection.Output
            comd.Parameters.Add(emp_InOut_status)


            Dim emp_Att_time As New SqlParameter()
            emp_Att_time.ParameterName = "@emp_Att_time"
            emp_Att_time.SqlDbType = SqlDbType.DateTime

            emp_Att_time.Direction = System.Data.ParameterDirection.Output
            comd.Parameters.Add(emp_Att_time)


            Dim O_msg As New SqlParameter()
            O_msg.ParameterName = "@msg"
            O_msg.SqlDbType = SqlDbType.VarChar
            O_msg.Size = 25
            O_msg.Direction = System.Data.ParameterDirection.Output
            comd.Parameters.Add(O_msg)

            conn.Open()
            comd.ExecuteNonQuery()



            Dim r As String = O_msg.Value.ToString()


            If r = "Success" Then

                If (emp_InOut_status.Value.ToString = "1") Then

                    Dim file_Exsist As Boolean
                    file_Exsist = File.Exists(".\Images\" + txt_Emp_code.Text + ".jpg")
                    If (file_Exsist) Then

                        Dim bmp As New Bitmap(".\Images\" + txt_Emp_code.Text + ".jpg")
                        pb_Employee_image.Image = bmp
                    Else
                        Dim bmp As New Bitmap(".\Images\default.jpg")
                        pb_Employee_image.Image = bmp
                    End If
                    txt_Emp_name.Text = emp_Name.Value.ToString() + "-" + emp_Last_name.Value.ToString()
                    txt_Emp_dept.Text = emp_Department.Value.ToString()
                    txt_Emp_designation.Text = emp_Designation.Value.ToString()
                    Dim datee As String = DateTime.Now.ToString("dd-MM-yyyy")
                    txt_Time.Text = datee + " " + DateTime.Now.ToLongTimeString()
                    Dim status_Image As New Bitmap(".\Images\in.jpg")
                    pb_Status.Image = status_Image
                    lbl_Message.BackColor = Color.Green
                    lbl_Message.Text = "Welcome"
                    txt_Time.ForeColor = Color.Green

                ElseIf (emp_InOut_status.Value.ToString = "2") Then

                   Dim file_Exsist As Boolean
                    file_Exsist = File.Exists(".\Images\" + txt_Emp_code.Text + ".jpg")
                    If (file_Exsist) Then

                        Dim bmp As New Bitmap(".\Images\" + txt_Emp_code.Text + ".jpg")
                        pb_Employee_image.Image = bmp
                    Else
                        Dim bmp As New Bitmap(".\Images\default.jpg")
                        pb_Employee_image.Image = bmp
                    End If
                    txt_Emp_name.Text = emp_Name.Value.ToString() + "-" + emp_Last_name.Value.ToString()
                    txt_Emp_dept.Text = emp_Department.Value.ToString()
                    txt_Emp_designation.Text = emp_Designation.Value.ToString()
                    Dim datee As String = DateTime.Now.ToString("dd-MM-yyyy")
                    txt_Time.Text = datee + " " + DateTime.Now.ToLongTimeString()
                    Dim status_Image As New Bitmap(".\Images\out.jpg")
                    pb_Status.Image = status_Image
                    lbl_Message.BackColor = Color.Red
                    lbl_Message.Text = "Good Bye"
                    txt_Time.ForeColor = Color.Red
                End If
            Else

                clear_Objects()
                lbl_Message.BackColor = Color.Red
                Dim msg As String = r.ToString()
                If (msg.Contains("Employee Code NOT FOUND")) Then

                    lbl_Message.Text = r.ToString() + " (" + e_code + ")"

                Else
                    lbl_Message.Text = r.ToString()
                End If
            End If
        End Using


    End Sub

    Private Sub clear_Objects()

        txt_Emp_code.Text = String.Empty
        txt_Emp_id.Text = String.Empty
        txt_Emp_name.Text = String.Empty
        txt_Emp_dept.Text = String.Empty
        txt_Emp_designation.Text = String.Empty
        pb_Employee_image.Image = Nothing
        txt_Time.Text = String.Empty
        pb_Status.Image = Nothing

    End Sub

    Private Sub txt_Emp_code_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Emp_code.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
End Class