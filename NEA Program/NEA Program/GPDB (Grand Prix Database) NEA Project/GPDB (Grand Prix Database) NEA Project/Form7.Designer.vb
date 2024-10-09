<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.LblMeetings = New System.Windows.Forms.Label()
        Me.txtMeetingsData = New System.Windows.Forms.TextBox()
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
        Me.btnBack1.TabIndex = 6
        Me.btnBack1.Text = "Back to Main Menu"
        Me.btnBack1.UseVisualStyleBackColor = False
        '
        'LblMeetings
        '
        Me.LblMeetings.AutoSize = True
        Me.LblMeetings.BackColor = System.Drawing.Color.Transparent
        Me.LblMeetings.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMeetings.ForeColor = System.Drawing.Color.Black
        Me.LblMeetings.Location = New System.Drawing.Point(563, 9)
        Me.LblMeetings.Name = "LblMeetings"
        Me.LblMeetings.Size = New System.Drawing.Size(273, 69)
        Me.LblMeetings.TabIndex = 18
        Me.LblMeetings.Text = "Meetings"
        '
        'txtMeetingsData
        '
        Me.txtMeetingsData.Location = New System.Drawing.Point(12, 95)
        Me.txtMeetingsData.Multiline = True
        Me.txtMeetingsData.Name = "txtMeetingsData"
        Me.txtMeetingsData.ReadOnly = True
        Me.txtMeetingsData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMeetingsData.Size = New System.Drawing.Size(1419, 603)
        Me.txtMeetingsData.TabIndex = 19
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 710)
        Me.Controls.Add(Me.txtMeetingsData)
        Me.Controls.Add(Me.LblMeetings)
        Me.Controls.Add(Me.btnBack1)
        Me.MaximizeBox = False
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack1 As Button
    Friend WithEvents LblMeetings As Label
    Friend WithEvents txtMeetingsData As TextBox
End Class
