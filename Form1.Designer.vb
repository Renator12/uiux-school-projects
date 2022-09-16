<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NEXTBUTTON = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OffButton = New System.Windows.Forms.Button()
        Me.WindowName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'NEXTBUTTON
        '
        Me.NEXTBUTTON.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.NEXTBUTTON.Location = New System.Drawing.Point(355, 190)
        Me.NEXTBUTTON.Name = "NEXTBUTTON"
        Me.NEXTBUTTON.Size = New System.Drawing.Size(113, 47)
        Me.NEXTBUTTON.TabIndex = 0
        Me.NEXTBUTTON.Text = "NEXT WINDOW"
        Me.NEXTBUTTON.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENTER NAME OF NEXT WINDOW"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OffButton
        '
        Me.OffButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OffButton.Location = New System.Drawing.Point(355, 260)
        Me.OffButton.Name = "OffButton"
        Me.OffButton.Size = New System.Drawing.Size(113, 54)
        Me.OffButton.TabIndex = 2
        Me.OffButton.Text = "Off"
        Me.OffButton.UseVisualStyleBackColor = False
        '
        'WindowName
        '
        Me.WindowName.Location = New System.Drawing.Point(355, 164)
        Me.WindowName.Name = "WindowName"
        Me.WindowName.Size = New System.Drawing.Size(113, 20)
        Me.WindowName.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 514)
        Me.Controls.Add(Me.WindowName)
        Me.Controls.Add(Me.OffButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NEXTBUTTON)
        Me.Name = "Form1"
        Me.Text = "RANIT'S LAB1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NEXTBUTTON As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OffButton As Button
    Friend WithEvents WindowName As TextBox
End Class
