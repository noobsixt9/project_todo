<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard_form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.extbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.logoutbtn)
        Me.Panel1.Controls.Add(Me.addbtn)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 377)
        Me.Panel1.TabIndex = 0
        '
        'logoutbtn
        '
        Me.logoutbtn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.logoutbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.logoutbtn.FlatAppearance.BorderSize = 0
        Me.logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.logoutbtn.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.logoutbtn.Image = CType(resources.GetObject("logoutbtn.Image"), System.Drawing.Image)
        Me.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutbtn.Location = New System.Drawing.Point(0, 347)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(146, 30)
        Me.logoutbtn.TabIndex = 2
        Me.logoutbtn.Text = "   LOGOUT"
        Me.logoutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logoutbtn.UseVisualStyleBackColor = False
        '
        'addbtn
        '
        Me.addbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addbtn.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.White
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addbtn.Location = New System.Drawing.Point(0, 85)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(146, 40)
        Me.addbtn.TabIndex = 1
        Me.addbtn.Text = "  ADD"
        Me.addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(146, 85)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(45, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "to do in one place"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "All of your things "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TODO APP"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.extbtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(146, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(499, 377)
        Me.Panel2.TabIndex = 1
        '
        'extbtn
        '
        Me.extbtn.BackColor = System.Drawing.Color.White
        Me.extbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.extbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.extbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.extbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.extbtn.Location = New System.Drawing.Point(459, 1)
        Me.extbtn.Name = "extbtn"
        Me.extbtn.Size = New System.Drawing.Size(40, 24)
        Me.extbtn.TabIndex = 0
        Me.extbtn.Text = "X"
        Me.extbtn.UseVisualStyleBackColor = False
        '
        'dashboard_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 377)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboard_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard_form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents addbtn As Button
    Friend WithEvents extbtn As Button
    Friend WithEvents logoutbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
