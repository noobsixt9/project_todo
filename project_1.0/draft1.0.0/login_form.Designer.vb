<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.chkbox = New System.Windows.Forms.CheckBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.Label()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.appname = New System.Windows.Forms.Label()
        Me.uname = New System.Windows.Forms.Label()
        Me.welcome = New System.Windows.Forms.Label()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 377)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(57, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "to do in one place"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TODO APP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "All of your things "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.loginbtn)
        Me.Panel2.Controls.Add(Me.chkbox)
        Me.Panel2.Controls.Add(Me.txtpwd)
        Me.Panel2.Controls.Add(Me.pwd)
        Me.Panel2.Controls.Add(Me.txtuname)
        Me.Panel2.Controls.Add(Me.appname)
        Me.Panel2.Controls.Add(Me.uname)
        Me.Panel2.Controls.Add(Me.welcome)
        Me.Panel2.Controls.Add(Me.exitbtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(186, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(460, 377)
        Me.Panel2.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(96, 314)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(209, 16)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "First time login? Create a new account"
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.Navy
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(175, 249)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(161, 37)
        Me.loginbtn.TabIndex = 10
        Me.loginbtn.Text = "LOGIN"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'chkbox
        '
        Me.chkbox.AutoSize = True
        Me.chkbox.Location = New System.Drawing.Point(175, 208)
        Me.chkbox.Name = "chkbox"
        Me.chkbox.Size = New System.Drawing.Size(102, 17)
        Me.chkbox.TabIndex = 9
        Me.chkbox.Text = "Show Password"
        Me.chkbox.UseVisualStyleBackColor = True
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(175, 177)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(159, 20)
        Me.txtpwd.TabIndex = 6
        Me.txtpwd.UseSystemPasswordChar = True
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pwd.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd.Location = New System.Drawing.Point(96, 177)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(60, 18)
        Me.pwd.TabIndex = 5
        Me.pwd.Text = "Password"
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(173, 142)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(159, 20)
        Me.txtuname.TabIndex = 4
        '
        'appname
        '
        Me.appname.AutoSize = True
        Me.appname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.appname.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appname.Location = New System.Drawing.Point(145, 30)
        Me.appname.Name = "appname"
        Me.appname.Size = New System.Drawing.Size(128, 30)
        Me.appname.TabIndex = 3
        Me.appname.Text = "TODO APP"
        '
        'uname
        '
        Me.uname.AutoSize = True
        Me.uname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.uname.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname.ForeColor = System.Drawing.SystemColors.ControlText
        Me.uname.Location = New System.Drawing.Point(96, 143)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(63, 18)
        Me.uname.TabIndex = 2
        Me.uname.Text = "Username"
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.Location = New System.Drawing.Point(129, 84)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(152, 22)
        Me.welcome.TabIndex = 1
        Me.welcome.Text = "WELCOME BACK"
        '
        'exitbtn
        '
        Me.exitbtn.BackColor = System.Drawing.Color.Transparent
        Me.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.exitbtn.FlatAppearance.BorderSize = 0
        Me.exitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.Location = New System.Drawing.Point(420, 1)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(40, 24)
        Me.exitbtn.TabIndex = 0
        Me.exitbtn.Text = "x"
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 377)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents exitbtn As Button
    Friend WithEvents txtpwd As TextBox
    Friend WithEvents pwd As Label
    Friend WithEvents txtuname As TextBox
    Friend WithEvents appname As Label
    Friend WithEvents uname As Label
    Friend WithEvents welcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents loginbtn As Button
    Friend WithEvents chkbox As CheckBox
End Class
