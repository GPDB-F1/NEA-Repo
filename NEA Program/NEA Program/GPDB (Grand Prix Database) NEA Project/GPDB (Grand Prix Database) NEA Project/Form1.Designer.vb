<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.LabelGPDB = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.Red
        Me.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSignIn.Location = New System.Drawing.Point(261, 427)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(322, 109)
        Me.btnSignIn.TabIndex = 1
        Me.btnSignIn.Text = "Sign in"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.Red
        Me.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAccount.Location = New System.Drawing.Point(831, 427)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(331, 109)
        Me.btnAccount.TabIndex = 2
        Me.btnAccount.Text = "Create account"
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'LabelGPDB
        '
        Me.LabelGPDB.AutoSize = True
        Me.LabelGPDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGPDB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelGPDB.Location = New System.Drawing.Point(340, 51)
        Me.LabelGPDB.Name = "LabelGPDB"
        Me.LabelGPDB.Size = New System.Drawing.Size(779, 91)
        Me.LabelGPDB.TabIndex = 3
        Me.LabelGPDB.Text = "Grand Prix Database"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1443, 710)
        Me.Controls.Add(Me.LabelGPDB)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.btnSignIn)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Start Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents LabelGPDB As Label
End Class
