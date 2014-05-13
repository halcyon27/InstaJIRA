<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_deviceList
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
        Me.ds_deviceList = New System.Data.DataSet()
        Me.grid_deviceList = New System.Windows.Forms.DataGridView()
        CType(Me.ds_deviceList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_deviceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ds_deviceList
        '
        Me.ds_deviceList.DataSetName = "ds_deviceList"
        '
        'grid_deviceList
        '
        Me.grid_deviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_deviceList.Location = New System.Drawing.Point(12, 12)
        Me.grid_deviceList.Name = "grid_deviceList"
        Me.grid_deviceList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_deviceList.Size = New System.Drawing.Size(562, 351)
        Me.grid_deviceList.TabIndex = 0
        '
        'frm_deviceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 375)
        Me.Controls.Add(Me.grid_deviceList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_deviceList"
        Me.Text = "Device List"
        CType(Me.ds_deviceList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_deviceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ds_deviceList As System.Data.DataSet
    Friend WithEvents grid_deviceList As System.Windows.Forms.DataGridView
End Class
