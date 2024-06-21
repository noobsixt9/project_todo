'libraries needed to create sql connection
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient

Public Class login_form
    Private Sub login_form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Set focus to the txtuname text field when the form is shown
        txtuname.Focus()
    End Sub

    Public Shared LoggedInUser As String
    Private Function getHash(theInput As String) As String
        Using hasher As MD5 = MD5.Create()

            Dim dbytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))


            Dim sBuilder As New StringBuilder()

            For Each t As Byte In dbytes
                sBuilder.Append(t.ToString("X2"))
            Next
            Return sBuilder.ToString()
        End Using
    End Function

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Application.Exit()

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox.CheckedChanged
        If chkbox.Checked = True Then
            txtpwd.UseSystemPasswordChar = False
        Else
            txtpwd.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub loginbtn_Click_1(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim connectionString As String = "Server=172.17.0.1,1433;Database=project_todo;User Id=sa;Password=rajan@224;"
        Dim connection As New SqlConnection(connectionString)
        Dim tasksForm As New tasks_form()
        Try
            connection.Open()

            If txtuname.Text = Nothing Or txtpwd.Text = Nothing Then
                MessageBox.Show("Input fields should not be empty.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Dim sql As String
                Dim command As SqlCommand
                sql = "select count(*) from userinfo where username = @username and passwdhash = @password"
                command = New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@username", txtuname.Text)
                command.Parameters.AddWithValue("@password", getHash(txtpwd.Text))

                Dim check As Integer = Convert.ToInt32(command.ExecuteScalar())

                If check = 1 Then

                    LoggedInUser = txtuname.Text
                    txtuname.Text = ""
                    txtpwd.Text = ""
                    dashboard_form.Show()
                    tasks_form.LoadTasksFromDatabase(LoggedInUser)
                    tasks_form.Show()
                    tasks_form.TopLevel = False
                    dashboard_form.Panel2.Controls.Add(tasks_form)
                    tasks_form.Dock = DockStyle.Fill
                    Me.Hide()


                    '  MessageBox.Show("Login sucessful", "Information Message", MessageBoxButtons.OK)
                Else
                    txtuname.Text = ""
                    txtpwd.Text = ""
                    MessageBox.Show("Username/ Password Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        register_form.Show()
        Me.Hide()
    End Sub
End Class
