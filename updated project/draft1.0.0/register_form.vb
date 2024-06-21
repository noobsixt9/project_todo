Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class register_form
    Private Sub register_form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Set focus to the txtuname text field when the form is shown
        txtfname.Focus()
    End Sub
    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Application.Exit()
    End Sub

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

    Private Function checkpass(ByVal password As String) As Boolean
        Dim hasLower As Boolean = False
        Dim hasUpper As Boolean = False
        Dim hasdigit As Boolean = False
        Dim hasSymbol As Boolean = False
        Dim haslength As Boolean = False

        For Each c As Char In password
            If Char.IsLower(c) Then
                hasLower = True
            ElseIf Char.IsUpper(c) Then
                hasUpper = True
            ElseIf Char.IsDigit(c) Then
                hasdigit = True
            ElseIf Char.IsSymbol(c) Or Char.IsPunctuation(c) Then
                hasSymbol = True
            End If
        Next
        If password.Length >= 8 Then
            haslength = True
        End If

        Dim ispasswordvalid As Boolean = hasLower AndAlso hasUpper AndAlso hasdigit AndAlso hasSymbol AndAlso haslength

        Return ispasswordvalid
    End Function

    Private Sub chkbox_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox.CheckedChanged
        If chkbox.Checked = True Then
            txtpasswd.UseSystemPasswordChar = False
        Else
            txtpasswd.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        login_form.Show()
        Me.Hide()
    End Sub

    Private Sub registerbtn_Click_1(sender As Object, e As EventArgs) Handles registerbtn.Click
        Dim connectionString As String = "Server=172.17.0.1,1433;Database=project_todo;User Id=sa;Password=rajan@224;"
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()

            If txtemail.Text = Nothing Or txtfname.Text = Nothing Or txtlname.Text = Nothing Or txtpasswd.Text = Nothing Or txtuname.Text = Nothing Then
                MessageBox.Show("Input fields should not be empty.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim sql As String
                Dim unamequery As String
                Dim emailquery As String

                sql = "insert into userinfo(fname, lname, username, passwdhash, email) values(@fname, @lname, @username, @passwdhash, @email)"
                unamequery = "select count(*) from userinfo where username = @unamecheck"
                emailquery = "select count(*) from userinfo where email = @emailcheck"

                Dim command As New SqlCommand
                Dim cmduname As New SqlCommand
                Dim cmdemail As New SqlCommand
                'email validation
                Dim emailvalid As Boolean = txtemail.Text.Contains("@") AndAlso txtemail.Text.Contains(".")

                cmdemail = New SqlCommand(emailquery, connection)
                cmduname = New SqlCommand(unamequery, connection)
                cmduname.Parameters.AddWithValue("@unamecheck", txtuname.Text)
                cmdemail.Parameters.AddWithValue("@emailcheck", txtemail.Text)

                command = New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@fname", txtfname.Text)
                command.Parameters.AddWithValue("@lname", txtlname.Text)
                command.Parameters.AddWithValue("@username", txtuname.Text)
                command.Parameters.AddWithValue("@passwdhash", getHash(txtpasswd.Text))
                command.Parameters.AddWithValue("@email", txtemail.Text)



                Dim checkuname As Integer = Convert.ToInt32(cmduname.ExecuteScalar())
                Dim checkemail As Integer = Convert.ToInt32(cmdemail.ExecuteScalar())

                If checkuname >= 1 Then
                    txtuname.Text = ""
                    MessageBox.Show("User already exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf checkemail >= 1 Then
                    txtemail.Text = ""
                    MessageBox.Show("User already exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf Not emailvalid Then
                    txtemail.Text = ""
                    MessageBox.Show("Email not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf Not checkpass(txtpasswd.Text) Then
                    MessageBox.Show("Password must be atleast 8 character" & vbCrLf &
                                    "Password must have atleast one Capital letter" & vbCrLf &
                                    "Password must have atleast one digit" & vbCrLf &
                                    "Password must have atlease one symbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


                Else
                    Dim rowsaffected As Integer = command.ExecuteNonQuery()
                    If rowsaffected > 0 Then
                        MessageBox.Show("User register successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtemail.Text = ""
                        txtfname.Text = ""
                        txtlname.Text = ""
                        txtpasswd.Text = ""
                        txtuname.Text = ""
                        login_form.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("User registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If



            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub
End Class