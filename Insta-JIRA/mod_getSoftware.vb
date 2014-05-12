Module mod_getSoftware

    Public Sub setGetSoftwareByServerEnv()
        Call setActiveTab()

        If serverEnv Like "MTL*" Then Call nGetSoftware()
        If serverEnv Like "CVT*" Then Call nGetSoftware()

        If serverEnv = "PROD" Then Call vlGetSoftware()
        If serverEnv = "VLINGO DEMO" Then Call vlGetSoftware()
        If serverEnv = "SS TEST" Then Call vlGetSoftware()
        If serverEnv = "SS DEMO" Then Call vlGetSoftware()
        If serverEnv = "QATEST" Then Call vlGetSoftware()
        If serverEnv = "QATEST3" Then Call vlGetSoftware()
        If serverEnv = "QADMZ" Then Call vlGetSoftware()


    End Sub

    Public Sub nGetSoftware()

        MessageBox.Show("Cannot parse software for " & serverEnv & ". Check Manually")

    End Sub

    Public Sub vlGetSoftware()
        Call setActiveTab()
        Call vlSetHostUrl()

        On Error GoTo NoData

        If serverEnv = "PROD" Then GoTo NoSupport
        If serverEnv = "VLINGO DEMO" Then GoTo NoSupport
        If serverEnv = "SS TEST" Then GoTo NoSupport
        If serverEnv = "SS DEMO" Then GoTo NoSupport

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(hostUrl)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim htmlSource As String = sr.ReadToEnd()

        Dim software As String
        Dim startLoc As Integer

        software = ""
        startLoc = InStr(htmlSource, "software")
        If startLoc > 0 Then
            software = Mid(htmlSource, startLoc + 9, Len(htmlSource))
            software = Mid(software, 1, InStr(software, Chr(60)) - 1)
        End If

        If software = "" Then GoTo NoData

        With frm_main
            If getActiveTabIndex() = 0 Then
                .tbx_software0.Text = software
                .tbx_host0.Text = hostUrl
            End If
            If getActiveTabIndex() = 1 Then
                .tbx_software1.Text = software
                .tbx_host1.Text = hostUrl
            End If
            If getActiveTabIndex() = 2 Then
                .tbx_software2.Text = software
                .tbx_host2.Text = hostUrl
            End If
        End With

        Exit Sub

NoData:

        MsgBox("Error calling server status page. Check manually.")
        Exit Sub

NoSupport:

        MsgBox("Cannot parse software data from " & serverEnv & ". Check manually.")
        Exit Sub

    End Sub
    'urls on this page should match with those found at http://wiki.vlingo.com/display/PM/Server+Environments+for+QA+Language+Testers
    Public Sub vlHostUrls()

        'QATEST 1 (J/H/B)
        qatest_1_enus = "http://app05-test.qa.vlingo.com:8080/asr/status"
        qatest_1_frfr = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_1_itit = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_1_dede = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_1_eses = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_1_vesla = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_1_ptbr = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_1_engb = "http://app12-test.qa.vlingo.com:8080/asr/status"
        qatest_1_zhcn = "http://app12-test.qa.vlingo.com:8080/asr/status"
        qatest_1_jajp = "http://app12-test.qa.vlingo.com:8080/asr/status"
        qatest_1_kokr = "http://app12-test.qa.vlingo.com:8080/asr/status"
        qatest_1_ruru = "http://app10-test.qa.vlingo.com:8080/asr/status"

        'QATEST 2 (K/CC)
        qatest_2_enus = "http://app05-test.qa.vlingo.com:8080/asr/status"
        qatest_2_frfr = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_2_itit = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_2_dede = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_2_eses = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_2_vesla = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_2_ptbr = "http://app10-test.qa.vlingo.com:8080/asr/status"
        qatest_2_engb = "http://app12-test.qa.vlingo.com:8080/asr/status"
        qatest_2_zhcn = "http://app12-test.qa.vlingo.com:8080/asr/status"
        qatest_2_jajp = "http://app12-test.qa.vlingo.com:8080/asr/status"
        qatest_2_kokr = "http://app12-test.qa.vlingo.com:8080/asr/status"
        qatest_2_ruru = "http://app10-test.qa.vlingo.com:8080/asr/status"

        'QADMZ 1 (J/H/B)
        qadmz_1_enus = "http://qadmz92.dmz.vlingo.com:8080/asr/status"
        qadmz_1_frfr = "http://qadmz93.dmz.vlingo.com:8080/asr/status"
        qadmz_1_itit = "http://qadmz93.dmz.vlingo.com:8080/asr/status"
        qadmz_1_dede = "http://qadmz93.dmz.vlingo.com:8080/asr/status"
        qadmz_1_eses = "http://qadmz93.dmz.vlingo.com:8080/asr/status"
        qadmz_1_vesla = "http://qadmz93.dmz.vlingo.com:8080/asr/status"
        qadmz_1_ptbr = "http://qadmz93.dmz.vlingo.com:8080/asr/status"
        qadmz_1_engb = "http://qadmz95.dmz.vlingo.com:8080/asr/status"
        qadmz_1_zhcn = "http://qadmz95.dmz.vlingo.com:8080/asr/status"
        qadmz_1_jajp = "http://qadmz95.dmz.vlingo.com:8080/asr/status"
        qadmz_1_kokr = "http://qadmz95.dmz.vlingo.com:8080/asr/status"
        qadmz_1_ruru = "http://qadmz93.dmz.vlingo.com:8080/asr/status"

        'QADMZ 2 (K/CC)
        qadmz_2_enus = "http://qadmz96.dmz.vlingo.com:8080/asr/status"
        qadmz_2_frfr = "http://qadmz97.dmz.vlingo.com:8080/asr/status"
        qadmz_2_itit = "http://qadmz97.dmz.vlingo.com:8080/asr/status"
        qadmz_2_dede = "http://qadmz97.dmz.vlingo.com:8080/asr/status"
        qadmz_2_eses = "http://qadmz97.dmz.vlingo.com:8080/asr/status"
        qadmz_2_vesla = "http://qadmz97.dmz.vlingo.com:8080/asr/status"
        qadmz_2_ptbr = "http://qadmz97.dmz.vlingo.com:8080/asr/status"
        qadmz_2_engb = "http://qadmz98.dmz.vlingo.com:8080/asr/status"
        qadmz_2_zhcn = "http://qadmz98.dmz.vlingo.com:8080/asr/status"
        qadmz_2_jajp = "http://qadmz98.dmz.vlingo.com:8080/asr/status"
        qadmz_2_kokr = "http://qadmz98.dmz.vlingo.com:8080/asr/status"
        qadmz_2_ruru = "http://qadmz97.dmz.vlingo.com:8080/asr/status"

    End Sub

    Public Sub vlSetHostUrl()

        Call setActiveTab()
        Call vlHostUrls()

        hostUrl = ""

        If project = "Kproject" Then GoTo configTwo
        If project = "CC" Then GoTo configTwo

configOne:

        If language = "en-US" And serverEnv = "QATEST" Then hostUrl = qatest_1_enus
        If language = "fr-FR" And serverEnv = "QATEST" Then hostUrl = qatest_1_frfr
        If language = "it-IT" And serverEnv = "QATEST" Then hostUrl = qatest_1_itit
        If language = "de-DE" And serverEnv = "QATEST" Then hostUrl = qatest_1_dede
        If language = "es-ES" And serverEnv = "QATEST" Then hostUrl = qatest_1_eses
        If language = "v-es-LA" And serverEnv = "QATEST" Then hostUrl = qatest_1_vesla
        If language = "pt-BR" And serverEnv = "QATEST" Then hostUrl = qatest_1_ptbr
        If language = "en-GB" And serverEnv = "QATEST" Then hostUrl = qatest_1_engb
        If language = "zh-CN" And serverEnv = "QATEST" Then hostUrl = qatest_1_zhcn
        If language = "ja-JP" And serverEnv = "QATEST" Then hostUrl = qatest_1_jajp
        If language = "ko-KR" And serverEnv = "QATEST" Then hostUrl = qatest_1_kokr
        If language = "ru-RU" And serverEnv = "QATEST" Then hostUrl = qatest_1_ruru

        If language = "en-US" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_enus
        If language = "fr-FR" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_frfr
        If language = "it-IT" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_itit
        If language = "de-DE" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_dede
        If language = "es-ES" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_eses
        If language = "v-es-LA" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_vesla
        If language = "pt-BR" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_ptbr
        If language = "en-GB" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_engb
        If language = "zh-CN" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_zhcn
        If language = "ja-JP" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_jajp
        If language = "ko-KR" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_kokr
        If language = "ru-RU" And serverEnv = "QADMZ" Then hostUrl = qadmz_1_ruru

        If language = "en-US" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_enus
        If language = "fr-FR" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_frfr
        If language = "it-IT" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_itit
        If language = "de-DE" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_dede
        If language = "es-ES" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_eses
        If language = "v-es-LA" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_vesla
        If language = "pt-BR" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_ptbr
        If language = "en-GB" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_engb
        If language = "zh-CN" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_zhcn
        If language = "ja-JP" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_jajp
        If language = "ko-KR" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_kokr
        If language = "ru-RU" And serverEnv = "QATEST3" Then hostUrl = qadmz_1_ruru

        Exit Sub

configTwo:

        If language = "en-US" And serverEnv = "QATEST" Then hostUrl = qatest_2_enus
        If language = "fr-FR" And serverEnv = "QATEST" Then hostUrl = qatest_2_frfr
        If language = "it-IT" And serverEnv = "QATEST" Then hostUrl = qatest_2_itit
        If language = "de-DE" And serverEnv = "QATEST" Then hostUrl = qatest_2_dede
        If language = "es-ES" And serverEnv = "QATEST" Then hostUrl = qatest_2_eses
        If language = "v-es-LA" And serverEnv = "QATEST" Then hostUrl = qatest_2_vesla
        If language = "pt-BR" And serverEnv = "QATEST" Then hostUrl = qatest_2_ptbr
        If language = "en-GB" And serverEnv = "QATEST" Then hostUrl = qatest_2_engb
        If language = "zh-CN" And serverEnv = "QATEST" Then hostUrl = qatest_2_zhcn
        If language = "ja-JP" And serverEnv = "QATEST" Then hostUrl = qatest_2_jajp
        If language = "ko-KR" And serverEnv = "QATEST" Then hostUrl = qatest_2_kokr
        If language = "ru-RU" And serverEnv = "QATEST" Then hostUrl = qatest_2_ruru

        If language = "en-US" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_enus
        If language = "fr-FR" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_frfr
        If language = "it-IT" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_itit
        If language = "de-DE" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_dede
        If language = "es-ES" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_eses
        If language = "v-es-LA" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_vesla
        If language = "pt-BR" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_ptbr
        If language = "en-GB" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_engb
        If language = "zh-CN" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_zhcn
        If language = "ja-JP" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_jajp
        If language = "ko-KR" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_kokr
        If language = "ru-RU" And serverEnv = "QADMZ" Then hostUrl = qadmz_2_ruru

        If language = "en-US" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_enus
        If language = "fr-FR" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_frfr
        If language = "it-IT" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_itit
        If language = "de-DE" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_dede
        If language = "es-ES" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_eses
        If language = "v-es-LA" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_vesla
        If language = "pt-BR" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_ptbr
        If language = "en-GB" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_engb
        If language = "zh-CN" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_zhcn
        If language = "ja-JP" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_jajp
        If language = "ko-KR" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_kokr
        If language = "ru-RU" And serverEnv = "QATEST3" Then hostUrl = qadmz_2_ruru

    End Sub

    Public Sub nHostUrls()

    End Sub

End Module
