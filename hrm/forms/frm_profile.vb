Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class frm_profile
    Private emp_Code As String = String.Empty
    Dim emp_Image_path As String = String.Empty
    Private is_Query_mode As Boolean = False
    Private Sub bnt_back_Click(sender As Object, e As EventArgs) Handles bnt_back.Click
        frm_Main_menu.Show()
        Me.Close()
    End Sub
    Private Sub bnt_new_Click(sender As Object, e As EventArgs) Handles bnt_new.Click
        groupbox_employee_profile.Enabled = True
        groupbox_picture_box.Enabled = True
        tab_other_info.Enabled = True
        txt_Emp_code.ReadOnly = True
        txt_Emp_code.BackColor = Color.Silver
        get_New_emp_code()
        bnt_clear.Enabled = True
        bnt_save.Enabled = True
        bnt_new.Enabled = False
        bnt_query.Enabled = False
        txt_first_name.Focus()
        txt_first_name.Enabled = True
        txt_last_name.Enabled = True
        combobox_gender.Enabled = True
        txt_CNIC_no.Enabled = True
        datetimepicker_CNIC_expiry.Enabled = True
        txt_family_no.Enabled = True
        txt_city.Enabled = True
        combobox_marital.Enabled = True
        datetimepicker_DOB.Enabled = True
        txt_mobile_no.Enabled = True
        combobox_rest_day.Enabled = True
        datetimepicker_hire_date.Enabled = True
        txt_postal_address.Enabled = True
        txt_permanent_address.Enabled = True
        txt_dept_code.Enabled = True
        txt_dept.Enabled = True
        txt_desig_code.Enabled = True
        txt_desig.Enabled = True
        checkbox_eobi.Enabled = True
        txt_eobi_no.Enabled = True
        checkbox_social_security.Enabled = True
        txt_social_security.Enabled = True
        txt_salary.Enabled = True
        checkbox_bank_account.Enabled = True
        txt_bank_account.Enabled = True
        txt_qualification.Enabled = True
        checkbox_email.Enabled = True
        txt_email.Enabled = True
        combobox_blood_group.Enabled = True
        combobox_emp_status.Enabled = True
        datetimepicker_quit_date.Enabled = True
        combobox_emp_type.Enabled = True
        txt_religion.Enabled = True
        txt_phone_no_ice.Enabled = True
        groupbox_picture_box.Enabled = True
    End Sub

    Private Sub bnt_clear_Click(sender As Object, e As EventArgs) Handles bnt_clear.Click
        txt_first_name.Text = String.Empty
        txt_CNIC_no.Text = String.Empty
        txt_city.Text = String.Empty
        txt_mobile_no.Text = String.Empty
        txt_last_name.Text = String.Empty
        datetimepicker_DOB.Text = String.Empty
        datetimepicker_CNIC_expiry.Text = String.Empty
        datetimepicker_hire_date.Text = String.Empty
        combobox_rest_day.Text = String.Empty
        combobox_emp_status.Text = String.Empty
        combobox_marital.Text = String.Empty
        combobox_gender.Text = String.Empty
        txt_family_no.Text = String.Empty
        txt_postal_address.Text = String.Empty
        txt_permanent_address.Text = String.Empty
        txt_dept_code.Text = String.Empty
        txt_dept.Text = String.Empty
        txt_desig_code.Text = String.Empty
        txt_desig.Text = String.Empty
        txt_Emp_code.Text = String.Empty
        txt_social_security.Text = String.Empty
        txt_salary.Text = String.Empty
        txt_bank_account.Text = String.Empty
        txt_eobi_no.Text = String.Empty
        txt_email.Text = String.Empty
        txt_religion.Text = String.Empty
        combobox_blood_group.Text = String.Empty
        combobox_emp_status.Text = String.Empty
        combobox_emp_type.Text = String.Empty
        txt_qualification.Text = String.Empty
        datetimepicker_quit_date.Text = String.Empty
        txt_phone_no_ice.Text = String.Empty
        checkbox_eobi.Checked = False
        checkbox_social_security.Checked = False
        checkbox_email.Checked = False
        emp_Image_path = String.Empty
        txt_Emp_code.ReadOnly = True
        txt_Emp_code.BackColor = Color.Silver
        txt_Emp_code.TabStop = False
        pb_Emp_image.Image = Nothing
        groupbox_employee_profile.Enabled = False
        groupbox_picture_box.Enabled = False
        tab_other_info.Enabled = False
        bnt_find.Visible = False
        is_Query_mode = False
        bnt_clear.Enabled = False
        bnt_save.Enabled = False
        bnt_new.Enabled = True
        bnt_query.Enabled = True
        bnt_new.Focus()
    End Sub

    Private Sub get_New_emp_code()
        Dim connection_String As String = String.Empty
        connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
        Using conn As New SqlConnection(connection_String)
            Dim comd As SqlCommand = New SqlCommand("get_Emp_code", conn)
            comd.CommandType = CommandType.StoredProcedure
            conn.Open()
            emp_Code = comd.ExecuteScalar()
            If (emp_Code.Length > 0) Then
                txt_Emp_code.Text = emp_Code
            End If
        End Using
    End Sub

    Private Sub bnt_save_Click(sender As Object, e As EventArgs) Handles bnt_save.Click
        If (is_Query_mode = False) Then
            Dim connection_String As String = String.Empty
            connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
            Using conn As New SqlConnection(connection_String)
                Dim comd As SqlCommand = New SqlCommand("insert_New_emp_data", conn)
                comd.CommandType = CommandType.StoredProcedure
                comd.Parameters.Add("@emp_Code", SqlDbType.VarChar, 5).Value = txt_Emp_code.Text
                comd.Parameters.Add("@emp_First_name", SqlDbType.VarChar, 30).Value = txt_first_name.Text
                comd.Parameters.Add("@emp_last_name", SqlDbType.VarChar, 30).Value = txt_last_name.Text
                comd.Parameters.Add("@Gender", SqlDbType.VarChar, 5).Value = combobox_gender.Text
                comd.Parameters.Add("@DOB", SqlDbType.VarChar, 8).Value = datetimepicker_DOB.Text
                comd.Parameters.Add("@Blood_group", SqlDbType.VarChar, 3).Value = combobox_blood_group.Text
                comd.Parameters.Add("@Eobi", SqlDbType.Bit).Value = checkbox_eobi.Checked
                If checkbox_eobi.Checked = True Then
                    comd.Parameters.Add("@Eobi_number", SqlDbType.VarChar, 15).Value = txt_eobi_no.Text
                Else
                    comd.Parameters.Add("@Eobi_number", SqlDbType.VarChar, 15).Value = ""
                End If
                comd.Parameters.Add("@Social_security", SqlDbType.Bit).Value = checkbox_social_security.Checked
                If checkbox_social_security.Checked = True Then
                    comd.Parameters.Add("@Social_security_number", SqlDbType.VarChar, 30).Value = txt_social_security.Text
                Else
                    comd.Parameters.Add("@Social_security_number", SqlDbType.VarChar, 30).Value = ""
                End If
                comd.Parameters.Add("@Mobile_number", SqlDbType.VarChar, 15).Value = txt_mobile_no.Text
                comd.Parameters.Add("@Family_no", SqlDbType.VarChar, 15).Value = txt_family_no.Text
                comd.Parameters.Add("@Email", SqlDbType.Bit).Value = checkbox_email.Checked
                If checkbox_email.Checked = True Then
                    comd.Parameters.Add("@Email_id", SqlDbType.VarChar, 40).Value = txt_email.Text
                Else
                    comd.Parameters.Add("@Email_id", SqlDbType.VarChar, 40).Value = ""
                End If
                comd.Parameters.Add("@CNIC", SqlDbType.VarChar, 20).Value = txt_CNIC_no.Text
                comd.Parameters.Add("@CNIC_Expiry", SqlDbType.Date).Value = datetimepicker_CNIC_expiry.Text
                comd.Parameters.Add("@Postal_address", SqlDbType.VarChar, 300).Value = txt_postal_address.Text
                comd.Parameters.Add("@Permanent_address", SqlDbType.VarChar, 300).Value = txt_permanent_address.Text
                comd.Parameters.Add("@City", SqlDbType.VarChar, 80).Value = txt_city.Text
                comd.Parameters.Add("@Marital", SqlDbType.VarChar, 10).Value = combobox_marital.Text
                comd.Parameters.Add("@Hire_date", SqlDbType.Date).Value = datetimepicker_hire_date.Text
                comd.Parameters.Add("@Rest_day", SqlDbType.VarChar, 50).Value = combobox_rest_day.Text
                comd.Parameters.Add("@Dept_code", SqlDbType.VarChar, 2).Value = txt_dept_code.Text
                comd.Parameters.Add("@Desig_code", SqlDbType.VarChar, 2).Value = txt_desig_code.Text
                comd.Parameters.Add("@Emp_type", SqlDbType.VarChar, 50).Value = combobox_emp_type.Text
                comd.Parameters.Add("@emp_Status", SqlDbType.VarChar, 15).Value = combobox_emp_status.Text
                If combobox_emp_status.Text = "ENROLL" Then
                    comd.Parameters.Add("@Quit_date", SqlDbType.VarChar, 30).Value = ""
                Else
                    comd.Parameters.Add("@Quit_date", SqlDbType.VarChar, 30).Value = datetimepicker_quit_date.Text
                End If
                comd.Parameters.Add("@Salary", SqlDbType.VarChar, 50).Value = txt_salary.Text
                comd.Parameters.Add("@bank_Account", SqlDbType.Bit).Value = checkbox_bank_account.Checked
                If checkbox_bank_account.Checked = True Then
                    comd.Parameters.Add("@Bank_account_no", SqlDbType.VarChar, 50).Value = txt_bank_account.Text
                Else
                    comd.Parameters.Add("@Bank_account_no", SqlDbType.VarChar, 30).Value = ""
                End If
                comd.Parameters.Add("@Religion", SqlDbType.VarChar, 30).Value = txt_religion.Text
                comd.Parameters.Add("@Qualification", SqlDbType.VarChar, 100).Value = txt_qualification.Text
                comd.Parameters.Add("@Phone_number_ICE", SqlDbType.VarChar, 30).Value = txt_phone_no_ice.Text
                conn.Open()
                comd.ExecuteNonQuery()
                Dim strPath As String = Directory.GetCurrentDirectory
                File.Copy(emp_Image_path, strPath & "\images\" & emp_Code & ".jpg")
                MsgBox("Record Saved!")
            End Using
        Else
            Dim connection_String As String = String.Empty
            connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
            Using conn As New SqlConnection(connection_String)
                Dim comd As SqlCommand = New SqlCommand("update_Emp_data", conn)
                comd.CommandType = CommandType.StoredProcedure
                comd.Parameters.Add("@emp_Code", SqlDbType.VarChar, 5).Value = txt_Emp_code.Text
                comd.Parameters.Add("@emp_First_name", SqlDbType.VarChar, 30).Value = txt_first_name.Text
                comd.Parameters.Add("@emp_last_name", SqlDbType.VarChar, 30).Value = txt_last_name.Text
                comd.Parameters.Add("@Gender", SqlDbType.VarChar, 5).Value = combobox_gender.Text
                comd.Parameters.Add("@DOB", SqlDbType.VarChar, 8).Value = datetimepicker_DOB.Text
                comd.Parameters.Add("@Blood_group", SqlDbType.VarChar, 3).Value = combobox_blood_group.Text
                comd.Parameters.Add("@Eobi", SqlDbType.Bit).Value = checkbox_eobi.Checked
                If checkbox_eobi.Checked = True Then
                    comd.Parameters.Add("@Eobi_number", SqlDbType.VarChar, 15).Value = txt_eobi_no.Text
                Else
                    comd.Parameters.Add("@Eobi_number", SqlDbType.VarChar, 15).Value = ""
                End If
                comd.Parameters.Add("@Social_security", SqlDbType.Bit).Value = checkbox_social_security.Checked
                If checkbox_social_security.Checked = True Then
                    comd.Parameters.Add("@Social_security_number", SqlDbType.VarChar, 30).Value = txt_social_security.Text
                Else
                    comd.Parameters.Add("@Social_security_number", SqlDbType.VarChar, 30).Value = ""
                End If
                comd.Parameters.Add("@Mobile_number", SqlDbType.VarChar, 15).Value = txt_mobile_no.Text
                comd.Parameters.Add("@Family_no", SqlDbType.VarChar, 15).Value = txt_family_no.Text
                comd.Parameters.Add("@Email", SqlDbType.Bit).Value = checkbox_email.Checked
                If checkbox_email.Checked = True Then
                    comd.Parameters.Add("@Email_id", SqlDbType.VarChar, 40).Value = txt_email.Text
                Else
                    comd.Parameters.Add("@Email_id", SqlDbType.VarChar, 40).Value = ""
                End If
                comd.Parameters.Add("@CNIC", SqlDbType.VarChar, 20).Value = txt_CNIC_no.Text
                comd.Parameters.Add("@CNIC_Expiry", SqlDbType.Date).Value = datetimepicker_CNIC_expiry.Text
                comd.Parameters.Add("@Postal_address", SqlDbType.VarChar, 300).Value = txt_postal_address.Text
                comd.Parameters.Add("@Permanent_address", SqlDbType.VarChar, 300).Value = txt_permanent_address.Text
                comd.Parameters.Add("@City", SqlDbType.VarChar, 80).Value = txt_city.Text
                comd.Parameters.Add("@Marital", SqlDbType.VarChar, 10).Value = combobox_marital.Text
                comd.Parameters.Add("@Hire_date", SqlDbType.Date).Value = datetimepicker_hire_date.Text
                comd.Parameters.Add("@Rest_day", SqlDbType.VarChar, 50).Value = combobox_rest_day.Text
                comd.Parameters.Add("@Dept_code", SqlDbType.VarChar, 2).Value = txt_dept_code.Text
                comd.Parameters.Add("@Desig_code", SqlDbType.VarChar, 2).Value = txt_desig_code.Text
                comd.Parameters.Add("@Emp_type", SqlDbType.VarChar, 50).Value = combobox_emp_type.Text
                comd.Parameters.Add("@emp_Status", SqlDbType.VarChar, 15).Value = combobox_emp_status.Text
                If combobox_emp_status.Text = "ENROLL" Then
                    comd.Parameters.Add("@Quit_date", SqlDbType.VarChar, 30).Value = ""
                Else
                    comd.Parameters.Add("@Quit_date", SqlDbType.VarChar, 30).Value = datetimepicker_quit_date.Text
                End If
                comd.Parameters.Add("@Salary", SqlDbType.VarChar, 50).Value = txt_salary.Text
                comd.Parameters.Add("@bank_Account", SqlDbType.Bit).Value = checkbox_bank_account.Checked
                If checkbox_bank_account.Checked = True Then
                    comd.Parameters.Add("@Bank_account_no", SqlDbType.VarChar, 50).Value = txt_bank_account.Text
                Else
                    comd.Parameters.Add("@Bank_account_no", SqlDbType.VarChar, 30).Value = ""
                End If
                comd.Parameters.Add("@Religion", SqlDbType.VarChar, 30).Value = txt_religion.Text
                comd.Parameters.Add("@Qualification", SqlDbType.VarChar, 100).Value = txt_qualification.Text
                comd.Parameters.Add("@Phone_number_ICE", SqlDbType.VarChar, 30).Value = txt_phone_no_ice.Text
                conn.Open()
                comd.ExecuteNonQuery()
                MsgBox("Record Updated!")
            End Using
        End If
        txt_first_name.Text = String.Empty
        txt_CNIC_no.Text = String.Empty
        txt_city.Text = String.Empty
        txt_mobile_no.Text = String.Empty
        txt_last_name.Text = String.Empty
        datetimepicker_DOB.Text = String.Empty
        datetimepicker_CNIC_expiry.Text = String.Empty
        datetimepicker_hire_date.Text = String.Empty
        combobox_rest_day.Text = String.Empty
        combobox_emp_status.Text = String.Empty
        combobox_marital.Text = String.Empty
        combobox_gender.Text = String.Empty
        txt_family_no.Text = String.Empty
        txt_postal_address.Text = String.Empty
        txt_permanent_address.Text = String.Empty
        txt_dept_code.Text = String.Empty
        txt_dept.Text = String.Empty
        txt_desig_code.Text = String.Empty
        txt_desig.Text = String.Empty
        txt_Emp_code.Text = String.Empty
        txt_social_security.Text = String.Empty
        txt_salary.Text = String.Empty
        txt_bank_account.Text = String.Empty
        txt_eobi_no.Text = String.Empty
        txt_email.Text = String.Empty
        txt_religion.Text = String.Empty
        combobox_blood_group.Text = String.Empty
        txt_qualification.Text = String.Empty
        datetimepicker_quit_date.Text = String.Empty
        txt_phone_no_ice.Text = String.Empty
        combobox_emp_type.Text = String.Empty
        checkbox_social_security.Checked = False
        checkbox_eobi.Checked = False
        checkbox_email.Checked = False
        txt_Emp_code.ReadOnly = False
        txt_Emp_code.BackColor = Color.White
        txt_Emp_code.TabStop = True
        groupbox_employee_profile.Enabled = False
        groupbox_picture_box.Enabled = False

        tab_other_info.Enabled = False
        is_Query_mode = False
        pb_Emp_image.Image = Nothing
        bnt_clear.Enabled = False
        bnt_save.Enabled = False
        bnt_new.Enabled = True
        bnt_query.Enabled = True
        bnt_find.Visible = False
    End Sub
    Private Sub llbl_Select_image_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_Select_image.LinkClicked

        Dim opend As New OpenFileDialog
        opend.Filter = "ImageFiles|*.jpg;*.jpeg;*.bmp;*.png"
        If (opend.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            emp_Image_path = opend.FileName
            pb_Emp_image.ImageLocation = opend.FileName
        End If
    End Sub
    Private Sub txt_dept_code_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_dept_code.MouseDoubleClick
        If is_Query_mode = False Then
            frm_Find_Dept_ID.ShowDialog()
            txt_dept_code.Text = frm_Find_Dept_ID.get_Dept_id
            txt_dept.Text = frm_Find_Dept_ID.get_Dept_desc
        End If
    End Sub
    Private Sub txt_desig_code_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_desig_code.MouseDoubleClick
        If is_Query_mode = False Then
            frm_Find_desig_id.ShowDialog()
            txt_desig_code.Text = frm_Find_desig_id.get_desig_id
            txt_desig.Text = frm_Find_desig_id.get_Desig_desc
        End If
    End Sub
    Private Sub txt_dept_code_Enter(sender As Object, e As EventArgs) Handles txt_dept_code.Enter
        If is_Query_mode = False Then
            If (txt_dept_code.Text.Length < 1) Then
                frm_Find_Dept_ID.ShowDialog()
                txt_dept_code.Text = frm_Find_Dept_ID.get_Dept_id
                txt_dept.Text = frm_Find_Dept_ID.get_Dept_desc
            End If
        End If
    End Sub
    Private Sub txt_desig_code_Enter(sender As Object, e As EventArgs) Handles txt_desig_code.Enter
        If is_Query_mode = False Then
            If (txt_desig_code.Text.Length < 1) Then
                frm_Find_desig_id.ShowDialog()
                txt_desig_code.Text = frm_Find_desig_id.get_desig_id
                txt_desig.Text = frm_Find_desig_id.get_Desig_desc
            End If
        End If
    End Sub
    Private Sub checkbox_social_security_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_social_security.CheckedChanged, checkbox_bank_account.CheckedChanged
        If checkbox_social_security.Checked = True Then
            txt_social_security.Enabled = True
            txt_social_security.BackColor = Color.White
        Else
            txt_social_security.Enabled = False
            txt_social_security.BackColor = Color.Silver
            txt_social_security.Text = String.Empty
        End If
    End Sub
    Private Sub checkbox_eobi_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_eobi.CheckedChanged
        If checkbox_eobi.Checked = True Then
            txt_eobi_no.Enabled = True
            txt_eobi_no.BackColor = Color.White
        Else
            txt_eobi_no.Enabled = False
            txt_eobi_no.BackColor = Color.Silver
            txt_eobi_no.Text = String.Empty
        End If
    End Sub
    Private Sub checkbox_bank_account_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_bank_account.CheckedChanged
        If checkbox_bank_account.Checked = True Then
            txt_bank_account.Enabled = True
            txt_bank_account.BackColor = Color.White
        Else
            txt_bank_account.Enabled = False
            txt_bank_account.BackColor = Color.Silver
            txt_bank_account.Text = String.Empty
        End If
    End Sub
    Private Sub combobox_emp_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_emp_status.SelectedIndexChanged
        If combobox_emp_status.Text = "ENROLL" Then
            datetimepicker_quit_date.Enabled = False
        Else
            datetimepicker_quit_date.Enabled = True
        End If
    End Sub
    Private Sub checkbox_email_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_email.CheckedChanged
        If checkbox_email.Checked = True Then
            txt_email.Enabled = True
            txt_email.BackColor = Color.White
        Else
            txt_email.Enabled = False
            txt_email.BackColor = Color.Silver
            txt_email.Text = String.Empty
        End If
    End Sub
    Private Sub bnt_query_Click(sender As Object, e As EventArgs) Handles bnt_query.Click
        groupbox_employee_profile.Enabled = True
        groupbox_picture_box.Enabled = True
        tab_other_info.Enabled = True
        bnt_find.Visible = True
        txt_Emp_code.ReadOnly = False
        txt_Emp_code.BackColor = Color.White
        txt_Emp_code.TabStop = True
        is_Query_mode = True
        bnt_clear.Enabled = True
        bnt_save.Enabled = True
        bnt_new.Enabled = False
        bnt_query.Enabled = False
        txt_Emp_code.Focus()
    End Sub
    Dim dt_Employee As New DataTable
    Private Sub btn_Find_Click(sender As Object, e As EventArgs) Handles bnt_find.Click
        If txt_Emp_code.Text.Length > 0 Then
            dt_Employee.Rows.Clear()
            Dim connection_String As String = String.Empty
            connection_String = ConfigurationManager.ConnectionStrings("connect_db").ConnectionString
            Using conn As New SqlConnection(connection_String)
                Dim comd As SqlCommand = New SqlCommand("find_employee", conn)
                comd.Parameters.Add("@emp_Code", SqlDbType.VarChar, 5).Value = txt_Emp_code.Text
                comd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(comd)
                da.Fill(dt_Employee)
                If (dt_Employee.Rows.Count > 0) Then
                    txt_first_name.Text = dt_Employee.Rows(0)("emp_first_Name").ToString()
                    txt_last_name.Text = dt_Employee.Rows(0)("emp_last_Name").ToString()
                    combobox_gender.Text = dt_Employee.Rows(0)("Gender").ToString()
                    txt_CNIC_no.Text = dt_Employee.Rows(0)("CNIC").ToString()
                    datetimepicker_CNIC_expiry.Text = dt_Employee.Rows(0)("CNIC_Expiry").ToString()
                    txt_family_no.Text = dt_Employee.Rows(0)("Family_no").ToString()
                    txt_city.Text = dt_Employee.Rows(0)("City").ToString()
                    combobox_marital.Text = dt_Employee.Rows(0)("Marital").ToString()
                    datetimepicker_DOB.Text = dt_Employee.Rows(0)("DOB").ToString()
                    txt_mobile_no.Text = dt_Employee.Rows(0)("Mobile_number").ToString()
                    combobox_rest_day.Text = dt_Employee.Rows(0)("Rest_day").ToString()
                    datetimepicker_hire_date.Text = dt_Employee.Rows(0)("Hire_date").ToString()
                    txt_postal_address.Text = dt_Employee.Rows(0)("Postal_address").ToString()
                    txt_permanent_address.Text = dt_Employee.Rows(0)("Permanent_address").ToString()
                    txt_dept_code.Text = dt_Employee.Rows(0)("Dept_code").ToString()
                    txt_dept.Text = dt_Employee.Rows(0)("Dept_description").ToString()
                    txt_desig_code.Text = dt_Employee.Rows(0)("Desig_code").ToString()
                    txt_desig.Text = dt_Employee.Rows(0)("Desig_description").ToString()
                    txt_eobi_no.Text = dt_Employee.Rows(0)("Eobi_number").ToString()
                    If txt_eobi_no.Text.Length > 0 Then
                        checkbox_eobi.Checked = True
                    Else
                        checkbox_eobi.Checked = False
                    End If
                    txt_social_security.Text = dt_Employee.Rows(0)("Social_security_number").ToString()
                    If txt_social_security.Text.Length > 0 Then
                        checkbox_social_security.Checked = True
                    Else
                        checkbox_social_security.Checked = False
                    End If
                    txt_salary.Text = dt_Employee.Rows(0)("Salary").ToString()
                    txt_bank_account.Text = dt_Employee.Rows(0)("Bank_account_no").ToString()
                    If txt_bank_account.Text.Length > 0 Then
                        checkbox_bank_account.Checked = True
                    Else
                        checkbox_bank_account.Checked = False
                    End If
                    txt_qualification.Text = dt_Employee.Rows(0)("Qualification").ToString()
                    txt_email.Text = dt_Employee.Rows(0)("Email_id").ToString()
                    If txt_email.Text.Length > 0 Then
                        checkbox_email.Checked = True
                    Else
                        checkbox_email.Checked = False
                    End If
                    combobox_blood_group.Text = dt_Employee.Rows(0)("Blood_group").ToString()
                    combobox_emp_status.Text = dt_Employee.Rows(0)("emp_Status").ToString()
                    datetimepicker_quit_date.Text = dt_Employee.Rows(0)("Quit_date").ToString()
                    combobox_emp_type.Text = dt_Employee.Rows(0)("Emp_type").ToString()
                    txt_religion.Text = dt_Employee.Rows(0)("Religion").ToString()
                    txt_phone_no_ice.Text = dt_Employee.Rows(0)("Phone_number_ICE").ToString()
                    Dim file_Exsist As Boolean
                    file_Exsist = File.Exists(".\Images\" + txt_Emp_code.Text + ".jpg")
                    If (file_Exsist) Then
                        Dim bmp As New Bitmap(".\Images\" + txt_Emp_code.Text + ".jpg")
                        pb_Emp_image.Image = bmp
                    Else
                        Dim bmp As New Bitmap(".\Images\default.jpg")
                        pb_Emp_image.Image = bmp
                    End If
                Else
                    MsgBox("No Data Found")
                    txt_Emp_code.Text = String.Empty
                    txt_Emp_code.Focus()
                End If
            End Using
        Else
            MsgBox("Employee Code Required!")
        End If
    End Sub

    Private Sub txt_first_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_first_name.KeyPress
        If IsNumeric(e.KeyChar) Then
            MsgBox("INVALID INPUT")
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txt_last_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_last_name.KeyPress
        If IsNumeric(e.KeyChar) Then
            MsgBox("INVALID INPUT")
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txt_religion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_religion.KeyPress
        If IsNumeric(e.KeyChar) Then
            MsgBox("INVALID INPUT")
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txt_family_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_family_no.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("INVALID INPUT")
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txt_CNIC_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CNIC_no.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("INVALID INPUT")
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txt_mobile_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mobile_no.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("INVALID INPUT")
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txt_Emp_code_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_Emp_code.KeyPress
        If is_Query_mode = True Then
            If Not IsNumeric(e.KeyChar) Then
                MsgBox("INVALID INPUT")
                e.KeyChar = Nothing
            End If
        End If
    End Sub
    Private Sub txt_phone_no_ice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone_no_ice.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("INVALID INPUT")
            e.KeyChar = Nothing
        End If
    End Sub
    Private Sub txt_eobi_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_eobi_no.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("INVALID INPUT")
            e.KeyChar = Nothing
        End If
    End Sub
    Private Sub txt_social_security_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_social_security.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("INVALID INPUT")
            e.KeyChar = Nothing
        End If
    End Sub
End Class