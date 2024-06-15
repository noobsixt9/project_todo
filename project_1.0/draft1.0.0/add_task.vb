Imports System.Data
Imports System.Data.SqlClient
Public Class add_task
    Dim connectionString As String = "Server=172.17.0.1,1433;Database=project_todo;User Id=sa;Password=rajan@224;"
    Dim connection As New SqlConnection(connectionString)
    Public shared usrid As Integer

    Private Sub addtaskfocus(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Set focus to the txtuname text field when the form is shown
        txttitle.Focus()
    End Sub

    Public Sub savebtn_Click_1(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim connectionString As String = "Server=172.17.0.1,1433;Database=project_todo;User Id=sa;Password=rajan@224;"
        Dim connection As New SqlConnection(connectionString)

        Try
            connection.Open()

            If txttitle.Text = Nothing Or textdescp.Text = Nothing Then
                MessageBox.Show("Title & Description fields should not be empty.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim sqluser As String = "select userid from userinfo where username = @username"
                Dim cmd As New SqlCommand(sqluser, connection)
                cmd.Parameters.AddWithValue("@username", login_form.LoggedInUser)
                'Dim loggeruser As String =
                Dim userid As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                usrid = userid
                'MessageBox.Show(userid, "logged in userid", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Dim sql As String = "insert into todolist(userid, title, [description], duedate) values (@userid, @title, @description, @duedate)"
                Dim command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@userid", userid)
                command.Parameters.AddWithValue("@title", txttitle.Text)
                command.Parameters.AddWithValue("@description", textdescp.Text)
                command.Parameters.AddWithValue("@duedate", duedate.Value.Date)
                Dim rowsaffected As Integer = Convert.ToInt32(command.ExecuteNonQuery())

                If rowsaffected > 0 Then
                    MessageBox.Show("Task added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txttitle.Text = ""
                    textdescp.Text = ""
                    Me.Hide()
                    dashboard_form.showtasks()
                    tasks_form.LoadTasksFromDatabase(login_form.LoggedInUser)
                Else
                    MessageBox.Show("Task failed to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End If


        Catch ex As Exception
            MessageBox.Show("An error occurred:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()

        End Try
    End Sub

    Private Sub canbtn_Click(sender As Object, e As EventArgs) Handles canbtn.Click
        txttitle.Text = ""
        textdescp.Text = ""
        dashboard_form.Show()
        Me.Hide()
        dashboard_form.showtasks()
    End Sub



    Private Sub txttitle_TextChanged(sender As Object, e As EventArgs) Handles txttitle.TextChanged
        txttitle.Focus()
    End Sub

    Private Sub dltbtn_Click(sender As Object, e As EventArgs) Handles dltbtn.Click
        Try
            connection.Open()
            Dim sql As String = "delete from todolist where id = @id and userid = (select userid from userinfo where username = @username)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@id", tasks_form.taskid)
            command.Parameters.AddWithValue("@username", login_form.LoggedInUser)


            'MessageBox.Show($"task id : {id} userid: {login_form.LoggedInUser}", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim check As Integer = command.ExecuteNonQuery()

            If check = 1 Then
                MessageBox.Show("Task deleted sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                dashboard_form.showtasks()
                tasks_form.LoadTasksFromDatabase(login_form.LoggedInUser)
                txttitle.Text = ""
                textdescp.Text = ""
            Else
                MessageBox.Show("Task deleted unsucessful, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            connection.Close()
        End Try
    End Sub

End Class