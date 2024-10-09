<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.txtSessionsData = New System.Windows.Forms.TextBox()
        Me.LblSessions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack1
        '
        Me.btnBack1.BackColor = System.Drawing.Color.Red
        Me.btnBack1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBack1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack1.ForeColor = System.Drawing.Color.Black
        Me.btnBack1.Location = New System.Drawing.Point(1276, 12)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(155, 77)
        Me.btnBack1.TabIndex = 5
        Me.btnBack1.Text = "Back to Main Menu"
        Me.btnBack1.UseVisualStyleBackColor = False
        '
        'txtSessionsData
        '
        Me.txtSessionsData.Location = New System.Drawing.Point(12, 95)
        Me.txtSessionsData.Multiline = True
        Me.txtSessionsData.Name = "txtSessionsData"
        Me.txtSessionsData.ReadOnly = True
        Me.txtSessionsData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSessionsData.Size = New System.Drawing.Size(1419, 603)
        Me.txtSessionsData.TabIndex = 6
        '
        'LblSessions
        '
        Me.LblSessions.AutoSize = True
        Me.LblSessions.BackColor = System.Drawing.Color.Transparent
        Me.LblSessions.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSessions.ForeColor = System.Drawing.Color.Black
        Me.LblSessions.Location = New System.Drawing.Point(561, 9)
        Me.LblSessions.Name = "LblSessions"
        Me.LblSessions.Size = New System.Drawing.Size(273, 69)
        Me.LblSessions.TabIndex = 17
        Me.LblSessions.Text = "Sessions"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 710)
        Me.Controls.Add(Me.LblSessions)
        Me.Controls.Add(Me.txtSessionsData)
        Me.Controls.Add(Me.btnBack1)
        Me.MaximizeBox = False
        Me.Name = "Form6"
        Me.Text = "Sessions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack1 As Button
    Friend WithEvents txtSessionsData As TextBox
    Friend WithEvents LblSessions As Label
End Class
