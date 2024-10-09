<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.txtDriverData = New System.Windows.Forms.TextBox()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.LblDrivers = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDriverData
        '
        Me.txtDriverData.Location = New System.Drawing.Point(12, 95)
        Me.txtDriverData.Multiline = True
        Me.txtDriverData.Name = "txtDriverData"
        Me.txtDriverData.ReadOnly = True
        Me.txtDriverData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDriverData.Size = New System.Drawing.Size(1419, 603)
        Me.txtDriverData.TabIndex = 0
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
        Me.btnBack1.TabIndex = 4
        Me.btnBack1.Text = "Back to Main Menu"
        Me.btnBack1.UseVisualStyleBackColor = False
        '
        'LblDrivers
        '
        Me.LblDrivers.AutoSize = True
        Me.LblDrivers.BackColor = System.Drawing.Color.Transparent
        Me.LblDrivers.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDrivers.ForeColor = System.Drawing.Color.Black
        Me.LblDrivers.Location = New System.Drawing.Point(587, 9)
        Me.LblDrivers.Name = "LblDrivers"
        Me.LblDrivers.Size = New System.Drawing.Size(220, 69)
        Me.LblDrivers.TabIndex = 16
        Me.LblDrivers.Text = "Drivers"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 710)
        Me.Controls.Add(Me.LblDrivers)
        Me.Controls.Add(Me.btnBack1)
        Me.Controls.Add(Me.txtDriverData)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.Text = "Drivers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDriverData As TextBox
    Friend WithEvents btnBack1 As Button
    Friend WithEvents LblDrivers As Label
End Class
