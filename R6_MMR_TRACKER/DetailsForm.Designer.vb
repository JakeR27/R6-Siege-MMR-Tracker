<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailsForm
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
        Me.detailsBox = New System.Windows.Forms.TextBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'detailsBox
        '
        Me.detailsBox.Location = New System.Drawing.Point(12, 12)
        Me.detailsBox.Multiline = True
        Me.detailsBox.Name = "detailsBox"
        Me.detailsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.detailsBox.Size = New System.Drawing.Size(960, 437)
        Me.detailsBox.TabIndex = 0
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(12, 456)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(960, 38)
        Me.backButton.TabIndex = 1
        Me.backButton.Text = "BACK"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'DetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(984, 506)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.detailsBox)
        Me.Name = "DetailsForm"
        Me.Text = "DetailsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents detailsBox As TextBox
    Friend WithEvents backButton As Button
End Class
