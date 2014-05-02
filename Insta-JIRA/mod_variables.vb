Module mod_variables

    Public Sub setTestEnv()

        'set variables based on selected tabpage
        If frm_main.TabControl1.SelectedIndex = 0 Then Call testEnv1()
        If frm_main.TabControl1.SelectedIndex = 1 Then Call testEnv2()
        If frm_main.TabControl1.SelectedIndex = 2 Then Call testEnv3()

    End Sub

    Public Sub testEnv1()

        project = frm_main.cbx_project0.Text
        automationTest = getAutomationTestType()
        language = frm_main.cbx_language0.Text
        testSource = frm_main.tbx_testSource0.Text
        buildPath = frm_main.tbx_buildPath0.Text
        buildVersion = frm_main.tbx_buildVersion0.Text
        serverEnv = frm_main.cbx_serverEnv0.Text
        software = frm_main.tbx_software0.Text
        datapack = frm_main.tbx_datapack0.Text
        diNumber = frm_main.cbx_diNumber0.Text
        deviceInfo = frm_main.tbx_deviceInfo0.Text

    End Sub

    Public Sub testEnv2()

        project = frm_main.cbx_project1.Text
        automationTest = getAutomationTestType()
        language = frm_main.cbx_language1.Text
        testSource = frm_main.tbx_testSource1.Text
        buildPath = frm_main.tbx_buildPath1.Text
        buildVersion = frm_main.tbx_buildVersion1.Text
        serverEnv = frm_main.cbx_serverEnv1.Text
        software = frm_main.tbx_software1.Text
        datapack = frm_main.tbx_datapack1.Text
        diNumber = frm_main.cbx_diNumber1.Text
        deviceInfo = frm_main.tbx_deviceInfo1.Text

    End Sub

    Public Sub testEnv3()

        project = frm_main.cbx_project2.Text
        automationTest = getAutomationTestType()
        language = frm_main.cbx_language2.Text
        testSource = frm_main.tbx_testSource2.Text
        buildPath = frm_main.tbx_buildPath2.Text
        buildVersion = frm_main.tbx_buildVersion2.Text
        serverEnv = frm_main.cbx_serverEnv2.Text
        software = frm_main.tbx_software2.Text
        datapack = frm_main.tbx_datapack2.Text
        diNumber = frm_main.cbx_diNumber2.Text
        deviceInfo = frm_main.tbx_deviceInfo2.Text

    End Sub

    Public Sub vlLanguages_1()

        Call setTestEnv()

        If language = "" Then langID = "10586"
        If language = "en-US" Then langID = "10570"
        If language = "fr-FR" Then langID = "10580"
        If language = "it-IT" Then langID = "10582"
        If language = "de-DE" Then langID = "10577"
        If language = "es-ES" Then langID = "10578"
        If language = "v-es-LA" Then langID = "10623"
        If language = "pt-BR" Then langID = "10598"
        If language = "en-GB" Then langID = "10571"
        If language = "zh-CN" Then langID = "10583"
        If language = "ja-JP" Then langID = "10585"
        If language = "ko-KR" Then langID = "10595"
        If language = "ru-RU" Then langID = "10596"


    End Sub

    Public Sub nLanguages()
        Call setTestEnv()

        ''match the language chosen to code for language used by Jira
        If language = "" Then langID = "10015"
        If language = "en-US" Then langID = "10005"
        If language = "fr-FR" Then langID = "10007"
        If language = "it-IT" Then langID = "10008"
        If language = "de-DE" Then langID = "10009"
        If language = "es-ES" Then langID = "10010"
        If language = "v-es-LA" Then langID = "10014"
        If language = "es-US" Then langID = "10062"
        If language = "pt-BR" Then langID = "10018"
        If language = "en-GB" Then langID = "10006"
        If language = "zh-CN" Then langID = "10044"
        If language = "ja-JP" Then langID = "10039"
        If language = "ko-KR" Then langID = "10040"
        If language = "ru-RU" Then langID = "10052"

        ''change language choice to xxx-XXX format for Burlington teams
        If langID = "10015" Then langCode = "N/A"
        If langID = "10005" Then langCode = "eng-USA"
        If langID = "10007" Then langCode = "fra-FRA"
        If langID = "10008" Then langCode = "ita-ITA"
        If langID = "10009" Then langCode = "deu-DEU"
        If langID = "10010" Then langCode = "spa-ESP"
        If langID = "10014" Then langCode = "spa-XLA"
        If langID = "10062" Then langCode = "spa-USA"
        If langID = "10018" Then langCode = "por-BRA"
        If langID = "10006" Then langCode = "eng-GBR"
        If langID = "10044" Then langCode = "cmn-CHN"
        If langID = "10039" Then langCode = "jpn-JPN"
        If langID = "10040" Then langCode = "kor-KOR"
        If langID = "10052" Then langCode = "rus-RUS"

    End Sub

    Public Sub vlLanguages_2()

    End Sub

    Public Sub nPlatforms()

        Call setTestEnv()

        'Match the platform chosen to code for platform used by Jira
        If project Like "LGEVM*" Then platform = "82249"
        If project = "Blackdog" Then platform = "43090"
        If project = "DMA" Then platform = "43091"
        If project = "Evermore" Then platform = "43090"

    End Sub

    Public Sub vlPlatforms_1()

        Call setTestEnv()

        If project = "" Then platform = "10560" 'All
        If project = "Blackdog" Then platform = "10951" 'Samsung Android GS4
        If project = "Bproject" Then platform = "10951" 'Samsung Android GS4
        If project = "CEC" Then platform = "10594" 'Other
        If project = "CC" Then platform = "11850" 'Samsung Android GS5
        If project = "DMA" Then platform = "10594" 'Other
        If project = "Evermore" Then platform = "10594" 'Other
        If project = "Hproject" Then platform = "11650" 'Samsung Note III
        If project = "Jproject-NCS" Then platform = "10951" 'Samsung Android GS4
        If project = "Jproject" Then platform = "10951" 'Samsung Android GS4
        If project = "Kproject" Then platform = "11850" 'Samsung Android GS5
        If project = "Q2/Midas" Then platform = "10850" 'Samsung Note II
        If project = "Tizen" Then platform = "11950" 'Tizen
        If project Like "LGEVM*" Then platform = "10594" 'Other


    End Sub

    Public Sub vlPlatforms_2()

        Call setTestEnv()

        If project = "" Then platform = "-1" 'None
        If project = "Blackdog" Then platform = "10952" 'Samsung Android GS4
        If project = "Bproject" Then platform = "10952" 'Samsung Android GS4
        If project = "CEC" Then platform = "-1" 'None
        If project = "CC" Then platform = "11851" 'Samsung Android GS5
        If project = "DMA" Then platform = "-1" 'None
        If project = "Evermore" Then platform = "-1" 'None
        If project = "Hproject" Then platform = "11450" 'Samsung Note III
        If project = "Jproject-NCS" Then platform = "10952" 'Samsung Android GS4
        If project = "Jproject" Then platform = "10952" 'Samsung Android GS4
        If project = "Kproject" Then platform = "11851" 'Samsung Android GS5
        If project = "Q2/Midas" Then platform = "10852" 'Samsung Note II
        If project = "Tizen" Then platform = "11750" 'Tizen
        If project Like "LGEVM*" Then platform = "-1" 'Note


    End Sub

    Public Sub serverEnv_nlps()
        ''used for blkdg, Evermore, lgevm

        Call setTestEnv()

        ''connect choice of language and project to applicable server environment
        If language = "en-US" Then nServerEnv = "mtl-pe59-vm3.nuance.com"
        If language = "fr-FR" Then nServerEnv = "mtl-pe57-vm2.nuance.com"
        If language = "it-IT" Then nServerEnv = "mt-bldmz02-09-vm3.nuance.com"
        If language = "de-DE" Then nServerEnv = "mtl-pe60-vm1.nuance.com"
        If language = "es-ES" Then nServerEnv = "mt-bldmz02-09-vm2.nuance.com"
        If language = "v-es-LA" Then nServerEnv = "mt-bldmz02-09-vm2.nuance.com"
        If language = "es-US" Then nServerEnv = "mt-bldmz02-09-vm2.nuance.com"
        If language = "pt-BR" Then nServerEnv = "mtl-pe54-vm3.nuance.com"
        If language = "ru-RU" Then nServerEnv = "mtl-pe60-vm3.nuance.com"
        If language = "en-GB" Then nServerEnv = "mt-bldmz02-10-vm2.nuance.com"
        If language = "ja-JP" Then nServerEnv = "mtl-pe53-vm2.nuance.com"
        If language = "zh-CN" Then nServerEnv = "mtl-pe57-vm5.nuance.com"

        If language = "ko-KR" And project = "Evermore" Then
            nServerEnv = "mtl-pe57-vm2.nuance.com"
        Else
            nServerEnv = "mtl-pe59-vm2.nuance.com"
        End If

    End Sub


    Public Sub serverEnv_ss()

        Call setTestEnv()

        ''Match project and server to SAQE options (id="customfield_11182")
        If serverEnv = "" Then serverEnv = "11558" '<option value="11558">Unknown (Production)</option>
        If serverEnv Like "QADMZ*" Then sServerEnv = "11564" '<option value="11564">samsungdmzasr.vlingo.com (DMZ)</option>
        If serverEnv = "SS TEST" Then sServerEnv = "11563" '<option value="11563">samsungtest.vlingo.com (Samsung Test)</option>
        If serverEnv = "SS DEMO" Then sServerEnv = "11565" '<option value="11565">samsungdemo.vlingo.com (Demo)</option>
        If serverEnv = "PROD" And project = "" Then sServerEnv = "11566" '<option value="11566">Unknown</option>
        If serverEnv = "PROD" And project = "Tizen" Then sServerEnv = "11558" '<option value="11558">Unknown (Production)</option>
        If serverEnv = "PROD" And project = "Hproject" Then sServerEnv = "11559" '<option value="11559">samsungbuiasr.vlingo.com (Prod for H/B)</option>
        If serverEnv = "PROD" And project = "Bproject" Then sServerEnv = "11559" '<option value="11559">samsungbuiasr.vlingo.com (Prod for H/B)</option>
        If serverEnv = "PROD" And project = "Jproject" Then sServerEnv = "11560" '<option value="11560">samsungjuiasr.vlingo.com (Prod for J)</option>
        If serverEnv = "PROD" And project = "MRA1" Then sServerEnv = "11560" '<option value="11560">samsungjuiasr.vlingo.com (Prod for J)</option>
        If serverEnv = "PROD" And project = "MRA2" Then sServerEnv = "11560" '<option value="11560">samsungjuiasr.vlingo.com (Prod for J)</option>
        If serverEnv = "PROD" And project = "Q2/Midas" Then sServerEnv = "11561" '<option value="11561">samsungq2asr.vlingo.com (Prod for Note 2)</option>

        If serverEnv = "PROD" And project = "Kproject" Then
            sServerEnv = "11566"                                                 '<option value="11566">Unknown</option>
            MsgBox(project & " is not yet in production; reverting to 'Unknown'." _
            & vbCrLf & "Please verify server before opening the JIRA.")
        End If

        If serverEnv = "PROD" And project = "CC" Then                            '<option value="11566">Unknown</option>
            sServerEnv = "11566"
            MsgBox(project & " is not yet in production; reverting to 'Unknown'." _
            & vbCrLf & "Please verify server before opening the JIRA.")
        End If

        If serverEnv = "VLINGO DEMO" Then
            sServerEnv = "11566"                                                 '<option value="11566">Unknown</option>
            MsgBox(serverEnv & " is not a valid choice for SAQE; reverting to 'Unknown'." _
            & vbCrLf & "Please verify server before opening the JIRA.")
        End If

        If serverEnv = "QATEST" Then
            sServerEnv = "11566"                                                 '<option value="11566">Unknown</option>
            MsgBox(serverEnv & " is not a valid choice for SAQE; reverting to 'Unknown'." _
            & vbCrLf & "Please verify server before opening the JIRA.")
        End If


    End Sub

End Module
