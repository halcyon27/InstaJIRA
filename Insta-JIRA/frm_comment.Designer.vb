<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_comment
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
        Me.tbx_comment = New System.Windows.Forms.TextBox()
        Me.btn_commentClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbx_comment
        '
        Me.tbx_comment.Location = New System.Drawing.Point(12, 12)
        Me.tbx_comment.Multiline = True
        Me.tbx_comment.Name = "tbx_comment"
        Me.tbx_comment.Size = New System.Drawing.Size(496, 114)
        Me.tbx_comment.TabIndex = 0
        '
        'btn_commentClose
        '
        Me.btn_commentClose.Location = New System.Drawing.Point(433, 132)
        Me.btn_commentClose.Name = "btn_commentClose"
        Me.btn_commentClose.Size = New System.Drawing.Size(75, 23)
        Me.btn_commentClose.TabIndex = 1
        Me.btn_commentClose.Text = "Close"
        Me.btn_commentClose.UseVisualStyleBackColor = True
        '
        'frm_comment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 164)
        Me.Controls.Add(Me.btn_commentClose)
        Me.Controls.Add(Me.tbx_comment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_comment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbx_comment As System.Windows.Forms.TextBox
    Friend WithEvents btn_commentClose As System.Windows.Forms.Button
End Class
