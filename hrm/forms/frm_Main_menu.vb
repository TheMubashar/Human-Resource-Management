Public Class frm_Main_menu
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles bnt_log_out.Click
        Me.Hide()
        frm_Login.Show()
    End Sub
    Private Sub DepartmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentsToolStripMenuItem.Click
        frm_Department.Show()
        Me.Hide()
    End Sub
    Private Sub EmployeeProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeProfileToolStripMenuItem.Click
        frm_Profile.Show()
        Me.Hide()
    End Sub
    Private Sub ManualAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualAttendanceToolStripMenuItem.Click
        frm_Attendance.Show()
        Me.Hide()
    End Sub
    Private Sub DesignationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesignationToolStripMenuItem.Click
        frm_Designation.Show()
        Me.Hide()
    End Sub
    Private Sub EmployeeSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeSalaryToolStripMenuItem.Click
        frm_Genrate_Salary.Show()
    End Sub
    Private Sub DesignationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DesignationToolStripMenuItem1.Click
        designation_Report.Show()
    End Sub
    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        department_Report.Show()
    End Sub
    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click
        attendance_Report.Show()
    End Sub
    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        salary_Report.Show()
    End Sub
    Private Sub MarkAbsentRestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAbsentRestToolStripMenuItem.Click
        frm_Mark_absent_rest.Show()
    End Sub
    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        emp_Profile_Report.Show()
    End Sub
End Class