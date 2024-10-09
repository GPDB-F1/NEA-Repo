<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.LabelSignIn = New System.Windows.Forms.Label()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.txtPasswordSignIn = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.txtUsernameSignIn = New System.Windows.Forms.TextBox()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LabelFirstname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(1276, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(155, 77)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back to Start Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'LabelSignIn
        '
        Me.LabelSignIn.AutoSize = True
        Me.LabelSignIn.BackColor = System.Drawing.Color.White
        Me.LabelSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSignIn.ForeColor = System.Drawing.Color.Black
        Me.LabelSignIn.Location = New System.Drawing.Point(556, 32)
        Me.LabelSignIn.Name = "LabelSignIn"
        Me.LabelSignIn.Size = New System.Drawing.Size(284, 91)
        Me.LabelSignIn.TabIndex = 4
        Me.LabelSignIn.Text = "Sign In"
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.Red
        Me.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.Black
        Me.btnSignIn.Location = New System.Drawing.Point(598, 562)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(233, 91)
        Me.btnSignIn.TabIndex = 42
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'txtPasswordSignIn
        '
        Me.txtPasswordSignIn.BackColor = System.Drawing.Color.Red
        Me.txtPasswordSignIn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordSignIn.ForeColor = System.Drawing.Color.White
        Me.txtPasswordSignIn.Location = New System.Drawing.Point(845, 320)
        Me.txtPasswordSignIn.Name = "txtPasswordSignIn"
        Me.txtPasswordSignIn.Size = New System.Drawing.Size(277, 34)
        Me.txtPasswordSignIn.TabIndex = 41
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.White
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.Black
        Me.LblPassword.Location = New System.Drawing.Point(838, 278)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(171, 38)
        Me.LblPassword.TabIndex = 40
        Me.LblPassword.Text = "Password:"
        '
        'txtUsernameSignIn
        '
        Me.txtUsernameSignIn.BackColor = System.Drawing.Color.Red
        Me.txtUsernameSignIn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsernameSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameSignIn.ForeColor = System.Drawing.Color.White
        Me.txtUsernameSignIn.Location = New System.Drawing.Point(302, 320)
        Me.txtUsernameSignIn.Name = "txtUsernameSignIn"
        Me.txtUsernameSignIn.Size = New System.Drawing.Size(277, 34)
        Me.txtUsernameSignIn.TabIndex = 34
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.BackColor = System.Drawing.Color.White
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.Black
        Me.LblUsername.Location = New System.Drawing.Point(295, 278)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(177, 38)
        Me.LblUsername.TabIndex = 33
        Me.LblUsername.Text = "Username:"
        '
        'LabelFirstname
        '
        Me.LabelFirstname.AutoSize = True
        Me.LabelFirstname.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstname.ForeColor = System.Drawing.Color.White
        Me.LabelFirstname.Location = New System.Drawing.Point(297, 317)
        Me.LabelFirstname.Name = "LabelFirstname"
        Me.LabelFirstname.Size = New System.Drawing.Size(0, 29)
        Me.LabelFirstname.TabIndex = 31
        Me.LabelFirstname.Tag = "Firstnam"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1443, 710)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.txtPasswordSignIn)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.txtUsernameSignIn)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LabelFirstname)
        Me.Controls.Add(Me.LabelSignIn)
        Me.Controls.Add(Me.btnBack)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Sign In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents LabelSignIn As Label
    Friend WithEvents btnSignIn As Button
    Friend WithEvents txtPasswordSignIn As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents txtUsernameSignIn As TextBox
    Friend WithEvents LblUsername As Label
    Friend WithEvents LabelFirstname As Label
End Class
