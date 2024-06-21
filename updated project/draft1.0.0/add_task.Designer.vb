<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_task
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_task))
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txttitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textdescp = New System.Windows.Forms.RichTextBox()
        Me.canbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dltbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.savebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.duedate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(181, 2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(136, 26)
        Me.Guna2HtmlLabel1.TabIndex = 12
        Me.Guna2HtmlLabel1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<strong>ADD NEW TASK</strong>"
        '
        'txttitle
        '
        Me.txttitle.BackColor = System.Drawing.Color.White
        Me.txttitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttitle.DefaultText = ""
        Me.txttitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttitle.ForeColor = System.Drawing.Color.Black
        Me.txttitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttitle.Location = New System.Drawing.Point(2, 34)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttitle.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txttitle.PlaceholderText = "TITLE"
        Me.txttitle.SelectedText = ""
        Me.txttitle.Size = New System.Drawing.Size(494, 30)
        Me.txttitle.TabIndex = 13
        '
        'textdescp
        '
        Me.textdescp.Location = New System.Drawing.Point(2, 70)
        Me.textdescp.Name = "textdescp"
        Me.textdescp.Size = New System.Drawing.Size(494, 230)
        Me.textdescp.TabIndex = 19
        Me.textdescp.Text = ""
        '
        'canbtn
        '
        Me.canbtn.AutoRoundedCorners = True
        Me.canbtn.BorderRadius = 16
        Me.canbtn.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.canbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.canbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.canbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.canbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.canbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.canbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.canbtn.ForeColor = System.Drawing.Color.White
        Me.canbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.canbtn.Location = New System.Drawing.Point(124, 317)
        Me.canbtn.Name = "canbtn"
        Me.canbtn.Size = New System.Drawing.Size(52, 35)
        Me.canbtn.TabIndex = 23
        Me.canbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dltbtn
        '
        Me.dltbtn.AutoRoundedCorners = True
        Me.dltbtn.BorderRadius = 16
        Me.dltbtn.CustomImages.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.dltbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dltbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.dltbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.dltbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dltbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dltbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dltbtn.ForeColor = System.Drawing.Color.White
        Me.dltbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.dltbtn.Location = New System.Drawing.Point(66, 317)
        Me.dltbtn.Name = "dltbtn"
        Me.dltbtn.Size = New System.Drawing.Size(52, 35)
        Me.dltbtn.TabIndex = 22
        Me.dltbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'savebtn
        '
        Me.savebtn.AutoRoundedCorners = True
        Me.savebtn.BorderRadius = 16
        Me.savebtn.CustomImages.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.savebtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.savebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.savebtn.ForeColor = System.Drawing.Color.White
        Me.savebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.savebtn.Location = New System.Drawing.Point(8, 317)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(52, 35)
        Me.savebtn.TabIndex = 21
        Me.savebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'duedate
        '
        Me.duedate.AutoRoundedCorners = True
        Me.duedate.BorderRadius = 17
        Me.duedate.Checked = True
        Me.duedate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.duedate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.duedate.Location = New System.Drawing.Point(182, 317)
        Me.duedate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.duedate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.duedate.Name = "duedate"
        Me.duedate.Size = New System.Drawing.Size(200, 36)
        Me.duedate.TabIndex = 24
        Me.duedate.Value = New Date(2024, 6, 8, 8, 4, 0, 380)
        '
        'add_task
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(499, 377)
        Me.Controls.Add(Me.duedate)
        Me.Controls.Add(Me.canbtn)
        Me.Controls.Add(Me.dltbtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.textdescp)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_task"
        Me.Text = "add_task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txttitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textdescp As RichTextBox
    Friend WithEvents canbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dltbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents savebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents duedate As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
