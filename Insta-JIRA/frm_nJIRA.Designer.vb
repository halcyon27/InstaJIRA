<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nJIRA
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
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.gbx_nClient = New System.Windows.Forms.GroupBox()
        Me.gbx_nCustomer = New System.Windows.Forms.GroupBox()
        Me.btn_zpAcc = New System.Windows.Forms.Button()
        Me.btn_zpAdk = New System.Windows.Forms.Button()
        Me.btn_zpAdrClint = New System.Windows.Forms.Button()
        Me.btn_zpGnl = New System.Windows.Forms.Button()
        Me.btn_Nlps = New System.Windows.Forms.Button()
        Me.btn_zpNlu = New System.Windows.Forms.Button()
        Me.btn_zpUdss = New System.Windows.Forms.Button()
        Me.gbx_nServer = New System.Windows.Forms.GroupBox()
        Me.btn_evermore = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_nClient.SuspendLayout()
        Me.gbx_nServer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'gbx_nClient
        '
        Me.gbx_nClient.Controls.Add(Me.btn_evermore)
        Me.gbx_nClient.Location = New System.Drawing.Point(218, 12)
        Me.gbx_nClient.Name = "gbx_nClient"
        Me.gbx_nClient.Size = New System.Drawing.Size(100, 215)
        Me.gbx_nClient.TabIndex = 1
        Me.gbx_nClient.TabStop = False
        Me.gbx_nClient.Text = "Client"
        '
        'gbx_nCustomer
        '
        Me.gbx_nCustomer.Location = New System.Drawing.Point(324, 12)
        Me.gbx_nCustomer.Name = "gbx_nCustomer"
        Me.gbx_nCustomer.Size = New System.Drawing.Size(100, 215)
        Me.gbx_nCustomer.TabIndex = 1
        Me.gbx_nCustomer.TabStop = False
        Me.gbx_nCustomer.Text = "Customer"
        '
        'btn_zpAcc
        '
        Me.btn_zpAcc.Location = New System.Drawing.Point(6, 19)
        Me.btn_zpAcc.Name = "btn_zpAcc"
        Me.btn_zpAcc.Size = New System.Drawing.Size(90, 26)
        Me.btn_zpAcc.TabIndex = 0
        Me.btn_zpAcc.Text = "ZPACC"
        Me.btn_zpAcc.UseVisualStyleBackColor = True
        '
        'btn_zpAdk
        '
        Me.btn_zpAdk.Location = New System.Drawing.Point(102, 19)
        Me.btn_zpAdk.Name = "btn_zpAdk"
        Me.btn_zpAdk.Size = New System.Drawing.Size(90, 26)
        Me.btn_zpAdk.TabIndex = 1
        Me.btn_zpAdk.Text = "ZPADK"
        Me.btn_zpAdk.UseVisualStyleBackColor = True
        '
        'btn_zpAdrClint
        '
        Me.btn_zpAdrClint.Location = New System.Drawing.Point(6, 51)
        Me.btn_zpAdrClint.Name = "btn_zpAdrClint"
        Me.btn_zpAdrClint.Size = New System.Drawing.Size(90, 26)
        Me.btn_zpAdrClint.TabIndex = 2
        Me.btn_zpAdrClint.Text = "ZPADRCLINT"
        Me.btn_zpAdrClint.UseVisualStyleBackColor = True
        '
        'btn_zpGnl
        '
        Me.btn_zpGnl.Location = New System.Drawing.Point(102, 51)
        Me.btn_zpGnl.Name = "btn_zpGnl"
        Me.btn_zpGnl.Size = New System.Drawing.Size(90, 26)
        Me.btn_zpGnl.TabIndex = 3
        Me.btn_zpGnl.Text = "ZPGNL"
        Me.btn_zpGnl.UseVisualStyleBackColor = True
        '
        'btn_Nlps
        '
        Me.btn_Nlps.Location = New System.Drawing.Point(6, 83)
        Me.btn_Nlps.Name = "btn_Nlps"
        Me.btn_Nlps.Size = New System.Drawing.Size(90, 26)
        Me.btn_Nlps.TabIndex = 4
        Me.btn_Nlps.Text = "ZPNLPS"
        Me.btn_Nlps.UseVisualStyleBackColor = True
        '
        'btn_zpNlu
        '
        Me.btn_zpNlu.Location = New System.Drawing.Point(102, 83)
        Me.btn_zpNlu.Name = "btn_zpNlu"
        Me.btn_zpNlu.Size = New System.Drawing.Size(90, 26)
        Me.btn_zpNlu.TabIndex = 5
        Me.btn_zpNlu.Text = "ZPNLU"
        Me.btn_zpNlu.UseVisualStyleBackColor = True
        '
        'btn_zpUdss
        '
        Me.btn_zpUdss.Location = New System.Drawing.Point(6, 115)
        Me.btn_zpUdss.Name = "btn_zpUdss"
        Me.btn_zpUdss.Size = New System.Drawing.Size(90, 26)
        Me.btn_zpUdss.TabIndex = 6
        Me.btn_zpUdss.Text = "ZPUDSS"
        Me.btn_zpUdss.UseVisualStyleBackColor = True
        '
        'gbx_nServer
        '
        Me.gbx_nServer.Controls.Add(Me.btn_zpUdss)
        Me.gbx_nServer.Controls.Add(Me.btn_zpNlu)
        Me.gbx_nServer.Controls.Add(Me.btn_Nlps)
        Me.gbx_nServer.Controls.Add(Me.btn_zpGnl)
        Me.gbx_nServer.Controls.Add(Me.btn_zpAdrClint)
        Me.gbx_nServer.Controls.Add(Me.btn_zpAdk)
        Me.gbx_nServer.Controls.Add(Me.btn_zpAcc)
        Me.gbx_nServer.Location = New System.Drawing.Point(12, 12)
        Me.gbx_nServer.Name = "gbx_nServer"
        Me.gbx_nServer.Size = New System.Drawing.Size(200, 215)
        Me.gbx_nServer.TabIndex = 0
        Me.gbx_nServer.TabStop = False
        Me.gbx_nServer.Text = "Server"
        '
        'btn_evermore
        '
        Me.btn_evermore.Location = New System.Drawing.Point(6, 19)
        Me.btn_evermore.Name = "btn_evermore"
        Me.btn_evermore.Size = New System.Drawing.Size(90, 26)
        Me.btn_evermore.TabIndex = 6
        Me.btn_evermore.Text = "Evermore"
        Me.btn_evermore.UseVisualStyleBackColor = True
        '
        'frm_nJIRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 237)
        Me.Controls.Add(Me.gbx_nCustomer)
        Me.Controls.Add(Me.gbx_nClient)
        Me.Controls.Add(Me.gbx_nServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_nJIRA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "JIRA Projects - Nuance"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_nClient.ResumeLayout(False)
        Me.gbx_nServer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents gbx_nCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_nClient As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_nServer As System.Windows.Forms.GroupBox
    Friend WithEvents btn_zpUdss As System.Windows.Forms.Button
    Friend WithEvents btn_zpNlu As System.Windows.Forms.Button
    Friend WithEvents btn_Nlps As System.Windows.Forms.Button
    Friend WithEvents btn_zpGnl As System.Windows.Forms.Button
    Friend WithEvents btn_zpAdrClint As System.Windows.Forms.Button
    Friend WithEvents btn_zpAdk As System.Windows.Forms.Button
    Friend WithEvents btn_zpAcc As System.Windows.Forms.Button
    Friend WithEvents btn_evermore As System.Windows.Forms.Button
End Class
