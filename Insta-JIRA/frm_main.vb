Public Class frm_main

    'DECLARE VARIABLES FOR SAVE SETTINGS
    Dim saveProject0, saveProject1, saveProject2 As String
    Dim saveLanguage0, saveLanguage1, saveLanguage2 As String
    Dim saveTestSource0, saveTestSource1, saveTestSource2 As String
    Dim saveBuildPath0, saveBuildPath1, saveBuildPath2 As String
    Dim saveBuildVersion0, saveBuildVersion1, saveBuildVersion2 As String
    Dim saveServerEnv0, saveServerEnv1, saveServerEnv2 As String
    'Dim saveHost0, saveHost1, saveHost2 As String
    Dim saveSoftware0, saveSoftware1, saveSoftware2 As String
    Dim saveDatapack0, saveDatapack1, saveDatapack2 As String
    Dim saveDiNumber0, saveDiNumber1, saveDiNumber2 As String
    Dim saveDeviceInfo0, saveDeviceInfo1, saveDeviceInfo2 As String

    Private Sub btn_nJira_Click(sender As System.Object, e As System.EventArgs) Handles btn_nJira.Click

        frm_nJIRA.ShowDialog()

    End Sub

    Private Sub btn_vJira_Click(sender As System.Object, e As System.EventArgs) Handles btn_vJira.Click

        frm_vJIRA.ShowDialog()

    End Sub
    'SAVE SETTINGS
    Private Sub frm_main_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        With My.Settings
            'TAB ONE
            .saveProject0 = Me.cbx_project0.Text
            .saveLanguage0 = Me.cbx_language0.Text
            .saveTestSource0 = Me.tbx_testSource0.Text
            .saveBuildPath0 = Me.tbx_buildPath0.Text
            .saveBuildVersion0 = Me.tbx_buildVersion0.Text
            .saveServerEnv0 = Me.cbx_serverEnv0.Text
            '.saveHost0 = Me.tbx_host0.Text
            .saveSoftware0 = Me.tbx_software0.Text
            .saveDatapack0 = Me.tbx_datapack0.Text
            .saveDiNumber0 = Me.cbx_diNumber0.Text
            '.saveDeviceInfo0 = Me.tbx_deviceInfo0.Text
            'TAB TWO
            .saveProject1 = Me.cbx_project1.Text
            .saveProject0 = Me.cbx_language1.Text
            .saveTestSource1 = Me.tbx_testSource1.Text
            .saveBuildPath1 = Me.tbx_buildPath1.Text
            .saveBuildVersion1 = Me.tbx_buildVersion1.Text
            .saveServerEnv1 = Me.cbx_serverEnv1.Text
            '.saveHost1 = Me.tbx_host1.Text
            .saveSoftware1 = Me.tbx_software1.Text
            .saveDatapack1 = Me.tbx_datapack1.Text
            .saveDiNumber1 = Me.cbx_diNumber1.Text
            '.saveDeviceInfo1 = Me.tbx_deviceInfo1.Text
            'TAB THREE
            .saveProject2 = Me.cbx_project2.Text
            .saveLanguage2 = Me.cbx_language2.Text
            .saveTestSource2 = Me.tbx_testSource2.Text
            .saveBuildPath2 = Me.tbx_buildPath2.Text
            .saveBuildVersion2 = Me.tbx_buildVersion2.Text
            .saveServerEnv2 = Me.cbx_serverEnv2.Text
            '.saveHost2 = Me.tbx_host2.Text
            .saveSoftware2 = Me.tbx_software2.Text
            .saveDatapack2 = Me.tbx_datapack2.Text
            .saveDiNumber2 = Me.cbx_diNumber2.Text
            '.saveDeviceInfo2 = Me.tbx_deviceInfo2.Text
        End With

    End Sub

    Private Sub frm_Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'RESTORED SAVED SETTINGS
        'TAB ONE
        Me.cbx_project0.Text = My.Settings.saveProject0
        Me.cbx_language0.Text = My.Settings.saveLanguage0
        Me.tbx_testSource0.Text = My.Settings.saveTestSource0
        Me.tbx_buildPath0.Text = My.Settings.saveBuildPath0
        Me.tbx_buildVersion0.Text = My.Settings.saveBuildVersion0
        Me.cbx_serverEnv0.Text = My.Settings.saveServerEnv0
        'Me.tbx_host0.Text = My.Settings.saveHost0
        Me.tbx_software0.Text = My.Settings.saveSoftware0
        Me.tbx_datapack0.Text = My.Settings.saveDatapack0
        Me.cbx_diNumber0.Text = My.Settings.saveDiNumber0
        'Me.tbx_deviceInfo0.Text = My.Settings.saveDeviceInfo0
        'TAB TWO
        Me.cbx_project1.Text = My.Settings.saveProject1
        Me.cbx_language1.Text = My.Settings.saveProject0
        Me.tbx_testSource1.Text = My.Settings.saveTestSource1
        Me.tbx_buildPath1.Text = My.Settings.saveBuildPath1
        Me.tbx_buildVersion1.Text = My.Settings.saveBuildVersion1
        Me.cbx_serverEnv1.Text = My.Settings.saveServerEnv1
        'Me.tbx_host1.Text = My.Settings.saveHost1
        Me.tbx_software1.Text = My.Settings.saveSoftware1
        Me.tbx_datapack1.Text = My.Settings.saveDatapack1
        Me.cbx_diNumber1.Text = My.Settings.saveDiNumber1
        'Me.tbx_deviceInfo1.Text = My.Settings.saveDeviceInfo1
        'TAB THREE
        Me.cbx_project2.Text = My.Settings.saveProject2
        Me.cbx_language2.Text = My.Settings.saveLanguage2
        Me.tbx_testSource2.Text = My.Settings.saveTestSource2
        Me.tbx_buildPath2.Text = My.Settings.saveBuildPath2
        Me.tbx_buildVersion2.Text = My.Settings.saveBuildVersion2
        Me.cbx_serverEnv2.Text = My.Settings.saveServerEnv2
        'Me.tbx_host2.Text = My.Settings.saveHost2
        Me.tbx_software2.Text = My.Settings.saveSoftware2
        Me.tbx_datapack2.Text = My.Settings.saveDatapack2
        Me.cbx_diNumber2.Text = My.Settings.saveDiNumber2
        'Me.tbx_deviceInfo2.Text = My.Settings.saveDeviceInfo2

        'select "Manual" radio button
        Me.rad_manual.Checked = True

        'populate comboboxes on frm_main--future work link to data source
        With Me.cbx_language0.Items
            .Add("en-US")
            .Add("fr-FR")
            .Add("it-IT")
            .Add("de-DE")
            .Add("es-ES")
            .Add("v-es-LA")
            .Add("es-US")
            .Add("pt-BR")
            .Add("en-GB")
            .Add("zh-CN")
            .Add("ja-JP")
            .Add("ko-KR")
            .Add("ru-RU")
        End With

        With Me.cbx_project0.Items
            .Add("Blackdog")
            .Add("Bproject")
            .Add("CEC")
            .Add("CC")
            .Add("DMA")
            .Add("Evermore")
            .Add("Hproject")
            .Add("Jproject-NCS")
            .Add("Jproject")
            .Add("Kproject")
            .Add("Midas")
            .Add("QA")
            .Add("Tizen")
            .Add("LGEVM G2")
            .Add("LGEVM B2")
        End With

        With Me.cbx_serverEnv0.Items
            .Add("MTLDEV02")
            .Add("MTLDEV03")
            .Add("MTLDEV04")
            .Add("CVT2")
            .Add("CVT2")
            .Add("PROD")
            .Add("QADMZ")
            .Add("QATEST3 (DMZ)")
            .Add("QATEST")
            .Add("QATEST")
            .Add("SS DEMO")
            .Add("SS TEST")
            .Add("VLINGO DEMO")
        End With

        'populate comboboxes on frm_main--future work link to data source
        With Me.cbx_language1.Items
            .Add("en-US")
            .Add("fr-FR")
            .Add("it-IT")
            .Add("de-DE")
            .Add("es-ES")
            .Add("v-es-LA")
            .Add("es-US")
            .Add("pt-BR")
            .Add("en-GB")
            .Add("zh-CN")
            .Add("ja-JP")
            .Add("ko-KR")
            .Add("ru-RU")
        End With

        With Me.cbx_project1.Items
            .Add("Blackdog")
            .Add("Bproject")
            .Add("CEC")
            .Add("CC")
            .Add("DMA")
            .Add("Evermore")
            .Add("Hproject")
            .Add("Jproject-NCS")
            .Add("Jproject")
            .Add("Kproject")
            .Add("Midas")
            .Add("QA")
            .Add("Tizen")
            .Add("LGEVM G2")
            .Add("LGEVM B2")
        End With

        With Me.cbx_serverEnv1.Items
            .Add("MTLDEV02")
            .Add("MTLDEV03")
            .Add("MTLDEV04")
            .Add("CVT2")
            .Add("CVT2")
            .Add("PROD")
            .Add("QADMZ")
            .Add("QATEST3 (DMZ)")
            .Add("QATEST")
            .Add("QATEST")
            .Add("SS DEMO")
            .Add("SS TEST")
            .Add("VLINGO DEMO")
        End With

        'populate comboboxes on frm_main--future work link to data source
        With Me.cbx_language2.Items
            .Add("en-US")
            .Add("fr-FR")
            .Add("it-IT")
            .Add("de-DE")
            .Add("es-ES")
            .Add("v-es-LA")
            .Add("es-US")
            .Add("pt-BR")
            .Add("en-GB")
            .Add("zh-CN")
            .Add("ja-JP")
            .Add("ko-KR")
            .Add("ru-RU")
        End With

        With Me.cbx_project2.Items
            .Add("Blackdog")
            .Add("Bproject")
            .Add("CEC")
            .Add("CC")
            .Add("DMA")
            .Add("Evermore")
            .Add("Hproject")
            .Add("Jproject-NCS")
            .Add("Jproject")
            .Add("Kproject")
            .Add("Midas")
            .Add("QA")
            .Add("Tizen")
            .Add("LGEVM G2")
            .Add("LGEVM B2")
        End With

        With Me.cbx_serverEnv2.Items
            .Add("MTLDEV02")
            .Add("MTLDEV03")
            .Add("MTLDEV04")
            .Add("CVT2")
            .Add("CVT2")
            .Add("PROD")
            .Add("QADMZ")
            .Add("QATEST3 (DMZ)")
            .Add("QATEST")
            .Add("QATEST")
            .Add("SS DEMO")
            .Add("SS TEST")
            .Add("VLINGO DEMO")
        End With

    End Sub

    Private Sub btn_comment_Click(sender As System.Object, e As System.EventArgs) Handles btn_comment.Click

        Call comment()

    End Sub

    Private Sub btn_clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear.Click

        Call clearSelectedTab()

    End Sub

End Class
