<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainfrm
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
        Me.Startbut = New System.Windows.Forms.Button
        Me.CurrTimetxt = New System.Windows.Forms.TextBox
        Me.ShutdownTimetxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SleepTimecombo = New System.Windows.Forms.ComboBox
        Me.Exitbut = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Startbut
        '
        Me.Startbut.Location = New System.Drawing.Point(36, 108)
        Me.Startbut.Name = "Startbut"
        Me.Startbut.Size = New System.Drawing.Size(75, 23)
        Me.Startbut.TabIndex = 0
        Me.Startbut.Text = "Start Timer"
        Me.Startbut.UseVisualStyleBackColor = True
        '
        'CurrTimetxt
        '
        Me.CurrTimetxt.Location = New System.Drawing.Point(106, 12)
        Me.CurrTimetxt.Name = "CurrTimetxt"
        Me.CurrTimetxt.ReadOnly = True
        Me.CurrTimetxt.Size = New System.Drawing.Size(121, 20)
        Me.CurrTimetxt.TabIndex = 1
        '
        'ShutdownTimetxt
        '
        Me.ShutdownTimetxt.Location = New System.Drawing.Point(106, 66)
        Me.ShutdownTimetxt.Name = "ShutdownTimetxt"
        Me.ShutdownTimetxt.Size = New System.Drawing.Size(121, 20)
        Me.ShutdownTimetxt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Current Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Shutdown Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SleepTimer"
        '
        'SleepTimecombo
        '
        Me.SleepTimecombo.FormattingEnabled = True
        Me.SleepTimecombo.Location = New System.Drawing.Point(106, 36)
        Me.SleepTimecombo.Name = "SleepTimecombo"
        Me.SleepTimecombo.Size = New System.Drawing.Size(121, 21)
        Me.SleepTimecombo.TabIndex = 0
        '
        'Exitbut
        '
        Me.Exitbut.Location = New System.Drawing.Point(152, 108)
        Me.Exitbut.Name = "Exitbut"
        Me.Exitbut.Size = New System.Drawing.Size(75, 23)
        Me.Exitbut.TabIndex = 8
        Me.Exitbut.Text = "Exit"
        Me.Exitbut.UseVisualStyleBackColor = True
        '
        'Mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 146)
        Me.Controls.Add(Me.Exitbut)
        Me.Controls.Add(Me.SleepTimecombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShutdownTimetxt)
        Me.Controls.Add(Me.CurrTimetxt)
        Me.Controls.Add(Me.Startbut)
        Me.KeyPreview = True
        Me.Name = "Mainfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Sleep Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Startbut As System.Windows.Forms.Button
    Friend WithEvents CurrTimetxt As System.Windows.Forms.TextBox
    Friend WithEvents ShutdownTimetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SleepTimecombo As System.Windows.Forms.ComboBox
    Friend WithEvents Exitbut As System.Windows.Forms.Button

End Class
