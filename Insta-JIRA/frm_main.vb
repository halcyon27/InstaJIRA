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
    Dim saveTabText0, saveTabText1, saveTabText2 As String

    Private Sub btn_nJira_Click(sender As System.Object, e As System.EventArgs) Handles btn_nJira.Click

        frm_nJIRA.ShowDialog()

    End Sub

    Private Sub btn_vJira_Click(sender As System.Object, e As System.EventArgs) Handles btn_vJira.Click

        frm_vJIRA.ShowDialog()

    End Sub

    Private Sub frm_main_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'SAVE SETTINGS
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
            .saveTabText0 = Me.TabPage0.Text
            'TAB TWO
            .saveProject1 = Me.cbx_project1.Text
            .saveLanguage1 = Me.cbx_language1.Text
            .saveTestSource1 = Me.tbx_testSource1.Text
            .saveBuildPath1 = Me.tbx_buildPath1.Text
            .saveBuildVersion1 = Me.tbx_buildVersion1.Text
            .saveServerEnv1 = Me.cbx_serverEnv1.Text
            '.saveHost1 = Me.tbx_host1.Text
            .saveSoftware1 = Me.tbx_software1.Text
            .saveDatapack1 = Me.tbx_datapack1.Text
            .saveDiNumber1 = Me.cbx_diNumber1.Text
            '.saveDeviceInfo1 = Me.tbx_deviceInfo1.Text
            .saveTabText1 = Me.TabPage1.Text
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
            .saveTabText2 = Me.TabPage2.Text
        End With

    End Sub

    Private Sub frm_Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'populate device list from xml
        Dim xml_deviceList As XDocument = XDocument.Load(xmlFilePath & "inventoryList.xml")
        Me.cbx_diNumber0.DataSource = (From element In xml_deviceList.Descendants("diNumber") Select element.Value).ToList()
        Me.cbx_diNumber1.DataSource = (From element In xml_deviceList.Descendants("diNumber") Select element.Value).ToList()
        Me.cbx_diNumber2.DataSource = (From element In xml_deviceList.Descendants("diNumber") Select element.Value).ToList()

        'RESTORED SAVED SETTINGS
        'TAB ONE
        With My.Settings
            Me.cbx_project0.Text = .saveProject0
            Me.cbx_language0.Text = .saveLanguage0
            Me.tbx_testSource0.Text = .saveTestSource0
            Me.tbx_buildPath0.Text = .saveBuildPath0
            Me.tbx_buildVersion0.Text = .saveBuildVersion0
            Me.cbx_serverEnv0.Text = .saveServerEnv0
            'Me.tbx_host0.Text = .saveHost0
            'Me.tbx_software0.Text = .saveSoftware0
            Me.tbx_datapack0.Text = .saveDatapack0
            Me.cbx_diNumber0.Text = .saveDiNumber0
            'Me.tbx_deviceInfo0.Text = .saveDeviceInfo0
            If .saveTabText0 = "" Then
                .saveTabText0 = "Test Environment 1"
                Me.TabPage0.Text = .saveTabText0
            Else
                Me.TabPage0.Text = .saveTabText0
            End If

            'TAB TWO
            Me.cbx_project1.Text = .saveProject1
            Me.cbx_language1.Text = .saveLanguage1
            Me.tbx_testSource1.Text = .saveTestSource1
            Me.tbx_buildPath1.Text = .saveBuildPath1
            Me.tbx_buildVersion1.Text = .saveBuildVersion1
            Me.cbx_serverEnv1.Text = .saveServerEnv1
            'Me.tbx_host1.Text = .saveHost1
            'Me.tbx_software1.Text = .saveSoftware1
            Me.tbx_datapack1.Text = .saveDatapack1
            Me.cbx_diNumber1.Text = .saveDiNumber1
            'Me.tbx_deviceInfo1.Text = .saveDeviceInfo1
            If .saveTabText1 = "" Then
                .saveTabText1 = "Test Environment 2"
                Me.TabPage1.Text = .saveTabText1
            Else
                Me.TabPage1.Text = .saveTabText1
            End If

            'TAB THREE
            Me.cbx_project2.Text = .saveProject2
            Me.cbx_language2.Text = .saveLanguage2
            Me.tbx_testSource2.Text = .saveTestSource2
            Me.tbx_buildPath2.Text = .saveBuildPath2
            Me.tbx_buildVersion2.Text = .saveBuildVersion2
            Me.cbx_serverEnv2.Text = .saveServerEnv2
            'Me.tbx_host2.Text = .saveHost2
            'Me.tbx_software2.Text = .saveSoftware2
            Me.tbx_datapack2.Text = .saveDatapack2
            Me.cbx_diNumber2.Text = .saveDiNumber2
            'Me.tbx_deviceInfo2.Text = .saveDeviceInfo2
            If .saveTabText2 = "" Then
                .saveTabText2 = "Test Environment 3"
                Me.TabPage2.Text = .saveTabText2
            Else
                Me.TabPage2.Text = .saveTabText2
            End If
        End With


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
            .Add("zh-CT")
            .Add("zh-HK")
            .Add("zh-TW")
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
            .Add("Tproject")
            .Add("Midas")
            .Add("Q2")
            .Add("Tizen")
            .Add("LGEVM G2")
            .Add("LGEVM B2")
        End With

        With Me.cbx_serverEnv0.Items
            .Add("MTLDEV02")
            .Add("MTLDEV03")
            .Add("MTLDEV04")
            .Add("MTLDEV05")
            .Add("CVT2")
            .Add("CVT3")
            .Add("PROD")
            .Add("QADMZ")
            .Add("QATEST3")
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
            .Add("zh-CT")
            .Add("zh-HK")
            .Add("zh-TW")
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
            .Add("Tproject")
            .Add("Midas")
            .Add("Q2")
            .Add("Tizen")
            .Add("LGEVM G2")
            .Add("LGEVM B2")
        End With

        With Me.cbx_serverEnv1.Items
            .Add("MTLDEV02")
            .Add("MTLDEV03")
            .Add("MTLDEV04")
            .Add("MTLDEV05")
            .Add("CVT2")
            .Add("CVT3")
            .Add("PROD")
            .Add("QADMZ")
            .Add("QATEST3")
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
            .Add("zh-CT")
            .Add("zh-HK")
            .Add("zh-TW")
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
            .Add("Tproject")
            .Add("Midas")
            .Add("Q2")
            .Add("Tizen")
            .Add("LGEVM G2")
            .Add("LGEVM B2")
        End With

        With Me.cbx_serverEnv2.Items
            .Add("MTLDEV02")
            .Add("MTLDEV03")
            .Add("MTLDEV04")
            .Add("MTLDEV05")
            .Add("CVT2")
            .Add("CVT3")
            .Add("PROD")
            .Add("QADMZ")
            .Add("QATEST3")
            .Add("QATEST")
            .Add("SS DEMO")
            .Add("SS TEST")
            .Add("VLINGO DEMO")
        End With

        'populate device combobox on frm_main from xml
        Call getDeviceInfo()

        'refresh server software and device info
        Me.btn_update.PerformClick()

    End Sub

    Private Sub btn_comment_Click(sender As System.Object, e As System.EventArgs) Handles btn_comment.Click

        Call comment()

    End Sub

    Private Sub btn_clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear.Click

        Call clearActiveTab()

    End Sub

    Private Sub btn_refresh_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click

        Call setGetSoftwareByServerEnv()
        Call getDeviceInfo()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click

        'jira device inv
        Process.Start("http://jira.vlingo.com/browse/DI#selectedTab=com.atlassian.jira.plugin.system.project%3Aissues-panel")

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click

        'grammar request form
        Process.Start("\\cma-filesrv01.nuance.com\project_management\Language Testing Team\VBA Productivity Tools\Grammar File Request Form.xlsm")

    End Sub


    Private Sub InstaJIRAWikiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InstaJIRAWikiToolStripMenuItem.Click

        'JIRA tool Wiki link
        Process.Start("http://wiki.vlingo.com/display/QA/Insta-Jira+Tool")

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click

        'ncs config viewer
        Process.Start("http://10.32.4.83/ncs-configuration-viewer.html")

    End Sub

    Private Sub RevisionHistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RevisionHistoryToolStripMenuItem.Click

        Process.Start(Application.StartupPath & "\revisionHistory.txt")

    End Sub

    Private Sub btn_deviceList_Click(sender As System.Object, e As System.EventArgs) Handles btn_deviceList.Click

        frm_deviceList.Show()

    End Sub

    Private Sub cbx_diNumber0_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbx_diNumber0.SelectedIndexChanged

        Call getDeviceInfo()

    End Sub

    Private Sub cbx_diNumber1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbx_diNumber1.SelectedIndexChanged

        Call getDeviceInfo()

    End Sub

    Private Sub cbx_diNumber2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbx_diNumber2.SelectedIndexChanged

        Call getDeviceInfo()

    End Sub

    Private Sub ReportABugToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportABugToolStripMenuItem.Click

        'report bug with Insta JIRA
        Process.Start("http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=12110&issuetype=1&components=14643&summary=[InstaJIRA v." _
                      & Application.ProductVersion & "]+enter%20summary&description=describe+the+error%0Dpaste+the+error+text+or+attach+a+screenshot+if+necessary%0D%0Dassign+to+aden+williamson")

    End Sub

    Private Sub DatapackMappingTableToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DatapackMappingTableToolStripMenuItem.Click

        Process.Start("http://wiki.vlingo.com/display/QA/Datapack+Mapping+Table")

    End Sub

    Private Sub ServerEnvForQAToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ServerEnvForQAToolStripMenuItem.Click

        Process.Start("http://wiki.vlingo.com/display/PM/Server+Environments+for+QA+Language+Testers")

    End Sub

    Private Sub SharePointDeviceListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SharePointDeviceListToolStripMenuItem.Click

        Process.Start("http://inside.nuance.com/mobility/QACollab/Shared%20Documents/Client%20QA%20-%20Common%20Resources/Testing%20Resources/Device%20Inventory%20List/")

    End Sub

    Private Sub Tab1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Tab1ToolStripMenuItem.Click

        Me.TabPage0.Text = InputBox("Enter new title for tab 1", , "Test Environment 1")
        If Me.TabPage0.Text = "" Then Me.TabPage0.Text = "Test Environment 1"

    End Sub

    Private Sub Tab2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Tab2ToolStripMenuItem.Click

        Me.TabPage1.Text = InputBox("Enter new title for tab 2", , "Test Environment 2")
        If Me.TabPage1.Text = "" Then Me.TabPage1.Text = "Test Environment 2"

    End Sub

    Private Sub Tab3ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Tab3ToolStripMenuItem.Click

        Me.TabPage2.Text = InputBox("Enter new title for tab 3", , "Test Environment 3")
        If Me.TabPage2.Text = "" Then Me.TabPage2.Text = "Test Environment 3"

    End Sub

    Private Sub lbl_host0_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_host0.MouseDoubleClick

        With Me.tbx_host0
            If .Enabled = False Then
                .Enabled = True
            Else
                .Enabled = False
            End If
        End With

    End Sub

    Private Sub lbl_Host1_Click(sender As System.Object, e As System.EventArgs) Handles lbl_Host1.Click

        With Me.tbx_host1
            If .Enabled = False Then
                .Enabled = True
            Else
                .Enabled = False
            End If
        End With

    End Sub

    Private Sub lbl_host2_Click(sender As System.Object, e As System.EventArgs) Handles lbl_host2.Click

        With Me.tbx_host2
            If .Enabled = False Then
                .Enabled = True
            Else
                .Enabled = False
            End If
        End With

    End Sub

    Private Sub lbl_deviceInfo0_Click(sender As System.Object, e As System.EventArgs) Handles lbl_deviceInfo0.Click

        With Me.tbx_deviceInfo0
            If .Enabled = False Then
                .Enabled = True
            Else
                .Enabled = False
            End If
        End With

    End Sub

    Private Sub lbl_deviceInfo1_Click(sender As System.Object, e As System.EventArgs) Handles lbl_deviceInfo1.Click

        With Me.tbx_deviceInfo1
            If .Enabled = False Then
                .Enabled = True
            Else
                .Enabled = False
            End If
        End With

    End Sub

    Private Sub lbl_deviceInfo2_Click(sender As System.Object, e As System.EventArgs) Handles lbl_deviceInfo2.Click

        With Me.tbx_deviceInfo2
            If .Enabled = False Then
                .Enabled = True
            Else
                .Enabled = False
            End If
        End With

    End Sub
End Class
