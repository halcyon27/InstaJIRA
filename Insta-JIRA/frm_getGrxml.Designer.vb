<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_getGrxml
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
        Me.gbx_datacenter = New System.Windows.Forms.GroupBox()
        Me.rad_cvt2 = New System.Windows.Forms.RadioButton()
        Me.rad_montreal = New System.Windows.Forms.RadioButton()
        Me.rad_markley = New System.Windows.Forms.RadioButton()
        Me.gbx_instructions = New System.Windows.Forms.GroupBox()
        Me.lbl_advise = New System.Windows.Forms.Label()
        Me.lbl_instructions = New System.Windows.Forms.Label()
        Me.gbx_values = New System.Windows.Forms.GroupBox()
        Me.tbx_nmaid = New System.Windows.Forms.TextBox()
        Me.tbx_speakerId = New System.Windows.Forms.TextBox()
        Me.tbx_langId = New System.Windows.Forms.TextBox()
        Me.lbl_Nmadi = New System.Windows.Forms.Label()
        Me.lbl_speakerId = New System.Windows.Forms.Label()
        Me.lbl_langId = New System.Windows.Forms.Label()
        Me.btn_jira = New System.Windows.Forms.Button()
        Me.btn_grxml = New System.Windows.Forms.Button()
        Me.gbx_datacenter.SuspendLayout()
        Me.gbx_instructions.SuspendLayout()
        Me.gbx_values.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_datacenter
        '
        Me.gbx_datacenter.Controls.Add(Me.rad_cvt2)
        Me.gbx_datacenter.Controls.Add(Me.rad_montreal)
        Me.gbx_datacenter.Controls.Add(Me.rad_markley)
        Me.gbx_datacenter.Location = New System.Drawing.Point(0, 0)
        Me.gbx_datacenter.Name = "gbx_datacenter"
        Me.gbx_datacenter.Size = New System.Drawing.Size(322, 52)
        Me.gbx_datacenter.TabIndex = 0
        Me.gbx_datacenter.TabStop = False
        Me.gbx_datacenter.Text = "Datacenter"
        '
        'rad_cvt2
        '
        Me.rad_cvt2.AutoSize = True
        Me.rad_cvt2.Location = New System.Drawing.Point(204, 24)
        Me.rad_cvt2.Name = "rad_cvt2"
        Me.rad_cvt2.Size = New System.Drawing.Size(52, 17)
        Me.rad_cvt2.TabIndex = 2
        Me.rad_cvt2.TabStop = True
        Me.rad_cvt2.Text = "CVT2"
        Me.rad_cvt2.UseVisualStyleBackColor = True
        '
        'rad_montreal
        '
        Me.rad_montreal.AutoSize = True
        Me.rad_montreal.Location = New System.Drawing.Point(108, 24)
        Me.rad_montreal.Name = "rad_montreal"
        Me.rad_montreal.Size = New System.Drawing.Size(66, 17)
        Me.rad_montreal.TabIndex = 1
        Me.rad_montreal.TabStop = True
        Me.rad_montreal.Text = "Montreal"
        Me.rad_montreal.UseVisualStyleBackColor = True
        '
        'rad_markley
        '
        Me.rad_markley.AutoSize = True
        Me.rad_markley.Location = New System.Drawing.Point(12, 24)
        Me.rad_markley.Name = "rad_markley"
        Me.rad_markley.Size = New System.Drawing.Size(62, 17)
        Me.rad_markley.TabIndex = 0
        Me.rad_markley.TabStop = True
        Me.rad_markley.Text = "Markley"
        Me.rad_markley.UseVisualStyleBackColor = True
        '
        'gbx_instructions
        '
        Me.gbx_instructions.Controls.Add(Me.lbl_advise)
        Me.gbx_instructions.Controls.Add(Me.lbl_instructions)
        Me.gbx_instructions.Location = New System.Drawing.Point(12, 58)
        Me.gbx_instructions.Name = "gbx_instructions"
        Me.gbx_instructions.Size = New System.Drawing.Size(310, 80)
        Me.gbx_instructions.TabIndex = 0
        Me.gbx_instructions.TabStop = False
        Me.gbx_instructions.Text = "Instructions"
        '
        'lbl_advise
        '
        Me.lbl_advise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_advise.ForeColor = System.Drawing.Color.Red
        Me.lbl_advise.Location = New System.Drawing.Point(3, 54)
        Me.lbl_advise.Name = "lbl_advise"
        Me.lbl_advise.Size = New System.Drawing.Size(301, 23)
        Me.lbl_advise.TabIndex = 1
        Me.lbl_advise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_instructions
        '
        Me.lbl_instructions.Location = New System.Drawing.Point(3, 16)
        Me.lbl_instructions.Name = "lbl_instructions"
        Me.lbl_instructions.Size = New System.Drawing.Size(301, 38)
        Me.lbl_instructions.TabIndex = 0
        '
        'gbx_values
        '
        Me.gbx_values.Controls.Add(Me.tbx_nmaid)
        Me.gbx_values.Controls.Add(Me.tbx_speakerId)
        Me.gbx_values.Controls.Add(Me.tbx_langId)
        Me.gbx_values.Controls.Add(Me.lbl_Nmadi)
        Me.gbx_values.Controls.Add(Me.lbl_speakerId)
        Me.gbx_values.Controls.Add(Me.lbl_langId)
        Me.gbx_values.Location = New System.Drawing.Point(12, 144)
        Me.gbx_values.Name = "gbx_values"
        Me.gbx_values.Size = New System.Drawing.Size(319, 101)
        Me.gbx_values.TabIndex = 0
        Me.gbx_values.TabStop = False
        Me.gbx_values.Text = "Values"
        '
        'tbx_nmaid
        '
        Me.tbx_nmaid.Location = New System.Drawing.Point(84, 71)
        Me.tbx_nmaid.Name = "tbx_nmaid"
        Me.tbx_nmaid.Size = New System.Drawing.Size(229, 20)
        Me.tbx_nmaid.TabIndex = 5
        '
        'tbx_speakerId
        '
        Me.tbx_speakerId.Location = New System.Drawing.Point(84, 45)
        Me.tbx_speakerId.Name = "tbx_speakerId"
        Me.tbx_speakerId.Size = New System.Drawing.Size(229, 20)
        Me.tbx_speakerId.TabIndex = 4
        '
        'tbx_langId
        '
        Me.tbx_langId.Location = New System.Drawing.Point(84, 19)
        Me.tbx_langId.Name = "tbx_langId"
        Me.tbx_langId.Size = New System.Drawing.Size(229, 20)
        Me.tbx_langId.TabIndex = 3
        '
        'lbl_Nmadi
        '
        Me.lbl_Nmadi.AutoSize = True
        Me.lbl_Nmadi.Location = New System.Drawing.Point(9, 74)
        Me.lbl_Nmadi.Name = "lbl_Nmadi"
        Me.lbl_Nmadi.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Nmadi.TabIndex = 2
        Me.lbl_Nmadi.Text = "Nmaid"
        '
        'lbl_speakerId
        '
        Me.lbl_speakerId.AutoSize = True
        Me.lbl_speakerId.Location = New System.Drawing.Point(9, 48)
        Me.lbl_speakerId.Name = "lbl_speakerId"
        Me.lbl_speakerId.Size = New System.Drawing.Size(61, 13)
        Me.lbl_speakerId.TabIndex = 1
        Me.lbl_speakerId.Text = "Speaker ID"
        '
        'lbl_langId
        '
        Me.lbl_langId.AutoSize = True
        Me.lbl_langId.Location = New System.Drawing.Point(9, 22)
        Me.lbl_langId.Name = "lbl_langId"
        Me.lbl_langId.Size = New System.Drawing.Size(69, 13)
        Me.lbl_langId.TabIndex = 0
        Me.lbl_langId.Text = "Language ID"
        '
        'btn_jira
        '
        Me.btn_jira.Location = New System.Drawing.Point(222, 251)
        Me.btn_jira.Name = "btn_jira"
        Me.btn_jira.Size = New System.Drawing.Size(100, 23)
        Me.btn_jira.TabIndex = 0
        Me.btn_jira.Text = "Open JIRA"
        Me.btn_jira.UseVisualStyleBackColor = True
        '
        'btn_grxml
        '
        Me.btn_grxml.Location = New System.Drawing.Point(116, 251)
        Me.btn_grxml.Name = "btn_grxml"
        Me.btn_grxml.Size = New System.Drawing.Size(100, 23)
        Me.btn_grxml.TabIndex = 1
        Me.btn_grxml.Tag = ""
        Me.btn_grxml.Text = "Get grxml"
        Me.btn_grxml.UseVisualStyleBackColor = True
        '
        'frm_getGrxml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 286)
        Me.Controls.Add(Me.gbx_instructions)
        Me.Controls.Add(Me.btn_jira)
        Me.Controls.Add(Me.btn_grxml)
        Me.Controls.Add(Me.gbx_values)
        Me.Controls.Add(Me.gbx_datacenter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_getGrxml"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GRXML Getter"
        Me.gbx_datacenter.ResumeLayout(False)
        Me.gbx_datacenter.PerformLayout()
        Me.gbx_instructions.ResumeLayout(False)
        Me.gbx_values.ResumeLayout(False)
        Me.gbx_values.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_datacenter As System.Windows.Forms.GroupBox
    Friend WithEvents rad_cvt2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad_montreal As System.Windows.Forms.RadioButton
    Friend WithEvents rad_markley As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_instructions As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_values As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_nmaid As System.Windows.Forms.TextBox
    Friend WithEvents tbx_speakerId As System.Windows.Forms.TextBox
    Friend WithEvents tbx_langId As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Nmadi As System.Windows.Forms.Label
    Friend WithEvents lbl_speakerId As System.Windows.Forms.Label
    Friend WithEvents lbl_langId As System.Windows.Forms.Label
    Friend WithEvents btn_jira As System.Windows.Forms.Button
    Friend WithEvents btn_grxml As System.Windows.Forms.Button
    Friend WithEvents lbl_advise As System.Windows.Forms.Label
    Friend WithEvents lbl_instructions As System.Windows.Forms.Label
End Class
