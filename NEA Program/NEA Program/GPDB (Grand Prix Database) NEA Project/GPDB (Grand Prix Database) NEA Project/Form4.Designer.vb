<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.LabelCrAcc = New System.Windows.Forms.Label()
        Me.btnTeams = New System.Windows.Forms.Button()
        Me.btnDrivers = New System.Windows.Forms.Button()
        Me.btnMeetings = New System.Windows.Forms.Button()
        Me.btnSessions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelCrAcc
        '
        Me.LabelCrAcc.AutoSize = True
        Me.LabelCrAcc.BackColor = System.Drawing.Color.White
        Me.LabelCrAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCrAcc.ForeColor = System.Drawing.Color.Black
        Me.LabelCrAcc.Location = New System.Drawing.Point(498, 28)
        Me.LabelCrAcc.Name = "LabelCrAcc"
        Me.LabelCrAcc.Size = New System.Drawing.Size(431, 91)
        Me.LabelCrAcc.TabIndex = 6
        Me.LabelCrAcc.Text = "Main Menu"
        '
        'btnTeams
        '
        Me.btnTeams.BackColor = System.Drawing.Color.Red
        Me.btnTeams.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnTeams.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeams.ForeColor = System.Drawing.Color.Black
        Me.btnTeams.Location = New System.Drawing.Point(63, 299)
        Me.btnTeams.Name = "btnTeams"
        Me.btnTeams.Size = New System.Drawing.Size(233, 190)
        Me.btnTeams.TabIndex = 43
        Me.btnTeams.Text = "Teams"
        Me.btnTeams.UseVisualStyleBackColor = False
        '
        'btnDrivers
        '
        Me.btnDrivers.BackColor = System.Drawing.Color.Red
        Me.btnDrivers.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDrivers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrivers.ForeColor = System.Drawing.Color.Black
        Me.btnDrivers.Location = New System.Drawing.Point(412, 299)
        Me.btnDrivers.Name = "btnDrivers"
        Me.btnDrivers.Size = New System.Drawing.Size(233, 190)
        Me.btnDrivers.TabIndex = 44
        Me.btnDrivers.Text = "Drivers"
        Me.btnDrivers.UseVisualStyleBackColor = False
        '
        'btnMeetings
        '
        Me.btnMeetings.BackColor = System.Drawing.Color.Red
        Me.btnMeetings.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnMeetings.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeetings.ForeColor = System.Drawing.Color.Black
        Me.btnMeetings.Location = New System.Drawing.Point(767, 299)
        Me.btnMeetings.Name = "btnMeetings"
        Me.btnMeetings.Size = New System.Drawing.Size(233, 190)
        Me.btnMeetings.TabIndex = 45
        Me.btnMeetings.Text = "Meetings"
        Me.btnMeetings.UseVisualStyleBackColor = False
        '
        'btnSessions
        '
        Me.btnSessions.BackColor = System.Drawing.Color.Red
        Me.btnSessions.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSessions.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSessions.ForeColor = System.Drawing.Color.Black
        Me.btnSessions.Location = New System.Drawing.Point(1138, 299)
        Me.btnSessions.Name = "btnSessions"
        Me.btnSessions.Size = New System.Drawing.Size(233, 190)
        Me.btnSessions.TabIndex = 46
        Me.btnSessions.Text = "Sessions"
        Me.btnSessions.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1443, 710)
        Me.Controls.Add(Me.btnSessions)
        Me.Controls.Add(Me.btnMeetings)
        Me.Controls.Add(Me.btnDrivers)
        Me.Controls.Add(Me.btnTeams)
        Me.Controls.Add(Me.LabelCrAcc)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCrAcc As Label
    Friend WithEvents btnTeams As Button
    Friend WithEvents btnDrivers As Button
    Friend WithEvents btnMeetings As Button
    Friend WithEvents btnSessions As Button
End Class
