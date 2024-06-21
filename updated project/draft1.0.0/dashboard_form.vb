Public Class dashboard_form
    Public Shared IsNewTask As Boolean
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles extbtn.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Dim logout As DialogResult
        logout = MessageBox.Show("Are you sure you want to log out ?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If logout = DialogResult.OK Then
            'if there is any key name "add_task in panel2 then it removes it when it logsout"
            If Panel2.Controls.ContainsKey("add_task") Then
                Panel2.Controls("add_task").Dispose()
                Panel2.Controls.RemoveByKey("add_tak")
            End If
            login_form.Show()
            Me.Hide()


        End If


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        IsNewTask = True
        'it removes the toplevel controls from the "add_task form" then add it to the panel2 in dashboard_form
        add_task.TopLevel = False
        Panel2.Controls.Add(add_task)
        add_task.Dock = DockStyle.Fill
        add_task.Show()

        tasks_form.LoadTasksFromDatabase(login_form.LoggedInUser)

        tasks_form.TopLevel = False
        Panel2.Controls.Add(tasks_form)
        tasks_form.Dock = DockStyle.Fill
        tasks_form.Show()



    End Sub
    Public Function showaddtaskform()
        add_task.TopLevel = False
        Panel2.Controls.Add(add_task)
        add_task.Dock = DockStyle.Fill
        add_task.Show()
    End Function


    Public Function showtasks()
        tasks_form.TopLevel = False
        Panel2.Controls.Add(tasks_form)
        tasks_form.Dock = DockStyle.Fill
        tasks_form.Show()
    End Function


End Class