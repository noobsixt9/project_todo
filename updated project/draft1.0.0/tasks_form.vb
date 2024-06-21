Imports System.Data.SqlClient


Public Class tasks_form

    Dim connectionString As String = "Server=172.17.0.1,1433;Database=project_todo;User Id=sa;Password=rajan@224;"
    Dim connection As New SqlConnection(connectionString)
    Public Shared taskid As Integer


    Public Sub LoadTasksFromDatabase(username As String)


        Try
            connection.Open()
            Dim sql As String = "select duedate, title from todolist where userid = (select userid from userinfo where username = @username)"

            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@username", username)

            Dim reader As SqlDataReader = command.ExecuteReader
            Guna2DataGridView1.Rows.Clear()
            While reader.Read = True
                Guna2DataGridView1.Rows.Add(reader.Item("duedate").ToString, reader.Item("title").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("An error occurred:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close() ' Close the connection when done
        End Try
    End Sub
    'Public Function getinfo(taskid As Integer)

    '    Dim sql As String = "select taskid from "
    'End Function
    Public Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick


        Try
            If e.RowIndex >= 0 AndAlso e.RowIndex <= Guna2DataGridView1.Rows.Count - 1 Then
                dashboard_form.IsNewTask = False
                connection.Open()
                Dim txttitle As String
                Dim txtdescp As String
                Dim txtdate As DateTime
                Dim title As String = Guna2DataGridView1.Rows(e.RowIndex).Cells("Column2").Value.ToString()
                Dim sql = "select id from todolist where title = @title and userid = (select userid from userinfo where username = @username)
 "
                Dim command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@username", login_form.LoggedInUser)
                command.Parameters.AddWithValue("@title", title)
                Dim id As Integer = Convert.ToInt32(command.ExecuteScalar()) 'id retreived 
                taskid = id



                Dim sql1 As String = "select duedate, title,description from todolist where id = @id and userid = (select userid from userinfo where username = @username)"
                Dim cmd As New SqlCommand(sql1, connection)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@username", login_form.LoggedInUser)

                Dim reader As SqlDataReader

                reader = cmd.ExecuteReader() ' information retrieving from database
                If reader.Read() Then
                    txttitle = reader("title").ToString()
                    txtdescp = reader("description").ToString()
                    txtdate = Convert.ToDateTime(reader("duedate"))
                End If
                'MessageBox.Show($"Title: {title} {vbCrLf} DueDate: {txtdate} {vbCrLf} Description: {txtdescp}", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' MessageBox.Show($"Title: {title} {vbCrLf} ID: {id}", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()

                dashboard_form.showaddtaskform()
                add_task.txttitle.Text = txttitle
                add_task.textdescp.Text = txtdescp
                add_task.duedate.Value = txtdate
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Application.Exit()
    End Sub
End Class
