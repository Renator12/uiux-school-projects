<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtherForm
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
        Me.name1 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'name1
        '
        Me.name1.AutoSize = True
        Me.name1.Location = New System.Drawing.Point(346, 155)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(60, 13)
        Me.name1.TabIndex = 0
        Me.name1.Text = "My name is"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(369, 207)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(10, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "."
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Ravie", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(329, 238)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(109, 52)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close Windows"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'OtherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.name1)
        Me.name = "OtherForm"
        Me.Text = "OtherForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents name1 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents CloseButton As Button
End Class
