Module mod_vJira

    'module for all vlingo system JIRAs:
    'ASRSCI    'BLKDG    'CEC    'LGEVM    'LGEVB    'MREC    'NAC    
    'SAMC    'SAQ    'SAQE    'SDA    'STZ    'STZE    'TXTNRM    'VVSCFG

    Public Sub ASRSCI()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_1()

        ''block user from non-compatible project
        If project = "Blackdog" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "DMA" Then GoTo ErrHandler1
        If project = "Evermore" Then GoTo ErrHandler1
        If project Like "LGEVM*" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10082" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420" _
        & "&components=11191" _
        & "&customfield_10251=" & platform & "" _
        & "&customfield_10250=" & langID & "" _
        & "&description=" & vlServer

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub BLKDG()

        Call setActiveTab()
        Call descriptions()

        ''block user from non-compatible project
        If Not project = "Blackdog" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible servers
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10512" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420&" _
        & "&description=" & vlClient

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub CEC()

        Call setActiveTab()
        Call descriptions()

        ''block user from non-compatible project
        If Not project = "CEC" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''build URL
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=11310" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420" _
        & "&customfield_10251=" & platform _
        & "&customfield_10250=" & langID _
        & "&description=" & vlServer

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub LGEVM()

        Call setActiveTab()
        Call descriptions()

        ''block user from non-compatible project
        If Not project Like "LGEVM*" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible servers
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=11510" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420&" _
        & "&description=" & vlClient

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub LGEVB()

        Call setActiveTab()
        Call descriptions()

        ''block user from non-compatible project
        If Not project Like "LGEV*" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible servers
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=12211" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420&" _
        & "&description=" & vlClient

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub MRECCMA()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()

        On Error GoTo ErrHandler3

        If frm_getGrxml.rad_markley.Checked = True Then datacenter = "Markley"
        If frm_getGrxml.rad_montreal.Checked = True Then datacenter = "Montreal"
        If frm_getGrxml.rad_cvt2.Checked = True Then datacenter = "CVT2"

        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo MRECMTL

MRECCMA:

        'set nonlatin dynamic URL with extra lines for romanization
        nonLatin = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10611&issuetype=1&priority=3&components=11940&customfield_10250=" & langID & "&summary=" & _
        "[" & project & "][" & language & "]+summary&customfield_10220=10420" & _
        "&description=Utt+timestamp:+%0D" & _
        "Datacenter:+" & datacenter & "%0DDatapack:+" & datapack & "%0D" & Chr(34) & "SessionId" & Chr(34) & ":+%0D" & Chr(34) & _
        "Speaker+ID" & Chr(34) & ":+" & frm_getGrxml.tbx_speakerId.Text & _
        "%0D" & Chr(34) & "NMAID" & Chr(34) & ":+" & frm_getGrxml.tbx_nmaid.Text & "%0D" & Chr(34) & "FieldID" & Chr(34) & ":+%0D" & _
        "----%0D" & _
        "Unformatted+utt+[" & language & "]:%0D" & _
        "Unformatted+utt+[en-US]:%0D" & _
        "\\%0D" & _
        "||+++++++++++++++++||[" & language & "]||[romanized]||[en-US]||%0D" & _
        "||+Expected+display|++++++++|++++++++++++|++++++++|%0D" & _
        "||+Actual+display++|++++++++|++++++++++++|++++++++|%0D" & _
        "||+RawHyp++++++++++|++++++++|++++++++++++|++++++++|%0D" & _
        "||+String+to+tag+++|++++++++|++++++++++++|++++++++|%0D" & _
        "%0D" & _
        "Note:+"

        ''set latinurl
        latin = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10611&issuetype=1&priority=3&components=11940&customfield_10250=" & langID & "&summary=" & _
        "[" & project & "][" & language & "]+summary&customfield_10220=10420" & _
        "&description=Utt+timestamp:+%0D" & _
        "Datacenter:+" & datacenter & "%0DDatapack:+" & datapack & "%0D" & Chr(34) & "SessionId" & Chr(34) & ":+%0D" & Chr(34) & _
        "Speaker+ID" & Chr(34) & ":+" & frm_getGrxml.tbx_speakerId.Text & _
        "%0D" & Chr(34) & "NMAID" & Chr(34) & ":+" & frm_getGrxml.tbx_nmaid.Text & "%0D" & Chr(34) & "FieldID" & Chr(34) & ":+%0D" & _
        "----%0D" & _
        "Unformatted+utt+[" & language & "]:%0D" & _
        "Unformatted+utt+[en-US]:%0D" & _
        "\\%0D" & _
        "||++++++++++++++++||[" & language & "]||[en-US]||%0D" & _
        "||+Expected+display|++++++++|++++++++|%0D" & _
        "||+Actual+display++|++++++++|++++++++|%0D" & _
        "||+RawHyp++++++++++|++++++++|++++++++|%0D" & _
        "||+String+to+tag+++|++++++++|++++++++|%0D" & _
        "%0D" & _
        "Note:+"

        GoTo continueSub

MRECMTL:

        ''set nonlatin url with extra lines for romanization
        nonLatin = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10611&issuetype=1&priority=3&components=11940&customfield_10250=" & langID & "&summary=" & _
        "[" & project & "][" & language & "]+summary&customfield_10220=10420" & _
        "&description=Utt+timestamp:+%0D" & _
        "Datacenter:+" & datacenter & "%0DDatapack:+" & datapack & "%0D" & Chr(34) & "SessionId" & Chr(34) & ":+%0D" & Chr(34) & _
        "Speaker+ID" & Chr(34) & ":+" & frm_getGrxml.tbx_speakerId.Text & _
        "%0D" & Chr(34) & "NMAID" & Chr(34) & ":+" & frm_getGrxml.tbx_nmaid.Text & "%0D" & Chr(34) & "FieldID" & Chr(34) & ":+%0D" & _
        "----%0D" & _
        "Unformatted+utt+[" & language & "]:%0D" & _
        "Unformatted+utt+[en-US]:%0D" & _
        "\\%0D" & _
        "||+++++++++++++++++||[" & language & "]||[romanized]||[en-US]||%0D" & _
        "||+Expected+display|++++++++|++++++++++++|++++++++|%0D" & _
        "||+Actual+display++|++++++++|++++++++++++|++++++++|%0D" & _
        "%0DASR%0D{noformat}{noformat}%0D" & _
        "%0DNote:+"

        ''set latin url
        latin = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10611&issuetype=1&priority=3&components=11940&customfield_10250=" & langID & "&summary=" & _
        "[" & project & "][" & language & "]+summary&customfield_10220=10420" & _
        "&description=Utt+timestamp:+%0D" & _
        "Datacenter:+" & datacenter & "%0DDatapack:+" & datapack & "%0D" & Chr(34) & "SessionId" & Chr(34) & ":+%0D" & Chr(34) & _
        "Speaker+ID" & Chr(34) & ":+" & frm_getGrxml.tbx_speakerId.Text & _
        "%0D" & Chr(34) & "NMAID" & Chr(34) & ":+" & frm_getGrxml.tbx_nmaid.Text & "%0D" & Chr(34) & "FieldID" & Chr(34) & ":+%0D" & _
        "----%0D" & _
        "Unformatted+utt+[" & language & "]:%0D" & _
        "Unformatted+utt+[en-US]:%0D" & _
        "\\%0D" & _
        "||++++++++++++++++||[" & language & "]||[en-US]||%0D" & _
        "||+Expected+display|++++++++|++++++++|%0D" & _
        "||+Actual+display++|++++++++|++++++++|%0D" & _
        "%0DASR%0D{noformat}{noformat}%0D" & _
        "%0DNote:+"

continueSub:

        ''choose latin or nonlatin format based on language choice
        If language = "ko-KR" Then url = nonLatin
        If language = "ja-JP" Then url = nonLatin
        If language = "zh-CN" Then url = nonLatin
        If language = "ru-RU" Then url = nonLatin
        If language = "fr-FR" Then url = latin
        If language = "it-IT" Then url = latin
        If language = "de-DE" Then url = latin
        If language = "es-ES" Then url = latin
        If language = "v-es-LA" Then url = latin
        If language = "en-GB" Then url = latin
        If language = "en-US" Then url = latin
        If language = "pt-BR" Then url = latin

        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub NAC()

        Call setActiveTab()
        Call descriptions()

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=11210" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420&" _
        & "&description=" & vlClient

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub SAMC()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_2()

        ''block user from non-compatible project
        If Not project = "CC" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=11810" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420" _
        & "&customfield_10480=" & platform & "" _
        & "&customfield_10250=" & langID & "" _
        & "&description=" & vlClient

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub SAQ()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_2()

        ''block user from non-compatible project
        If project = "Blackdog" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "DMA" Then GoTo ErrHandler1
        If project = "Evermore" Then GoTo ErrHandler1
        If project Like "LGEVM*" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10303" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420" _
        & "&customfield_10480=" & platform & "" _
        & "&customfield_10250=" & langID & "" _
        & "&description=" & vlServer

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub SAQE()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_2()
        Call serverEnv_ss()

        'block user from non-compatible project
        If project = "Blackdog" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "DMA" Then GoTo ErrHandler1
        If project = "Evermore" Then GoTo ErrHandler1
        If project Like "LGEVM*" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''Build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10314" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&customfield_11184=11573" _
        & "&customfield_11180=11555" _
        & "&customfield_10250=" & langID & "" _
        & "&customfield_10480=" & platform _
        & "&customfield_10145=" & diNumber & " ( model=" & deviceModel & " Series=" & deviceSeries & " OS=" & deviceOS & " )" _
        & "&customfield_11181=" & buildVersion _
        & "&customfield_11182=" & sServerEnv _
        & "&customfield_10220=10420" _
        & "&description=" _
        & vlExternal

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub SDA()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_2()
        Call serverEnv_ss()

        ''block user from creating bugs for non-compatible project
        If Not project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=11710" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&customfield_11184=11573" _
        & "&customfield_11180=11555" _
        & "&customfield_10250=" & langID & "" _
        & "&customfield_10480=" & platform _
        & "&customfield_10145=" & diNumber & " ( model=" & deviceModel & " Series=" & deviceSeries & " OS=" & deviceOS & " )" _
        & "&customfield_11181=" & buildVersion _
        & "&customfield_11182=" & sServerEnv _
        & "&customfield_10220=10420" _
        & "&description=" _
        & vlExternal

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub STZ()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_2()
        Call serverEnv_ss()

        ''block user from creating bugs for non-compatible project
        If Not project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10511" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&customfield_11184=11573" _
        & "&customfield_11180=11555" _
        & "&customfield_10250=" & langID & "" _
        & "&customfield_10480=" & platform _
        & "&customfield_10145=" & diNumber & " ( model=" & deviceModel & " Series=" & deviceSeries & " OS=" & deviceOS & " )" _
        & "&customfield_11181=" & buildVersion _
        & "&customfield_11182=" & sServerEnv _
        & "&customfield_10220=10420" _
        & "&description=" _
        & vlExternal

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub STZE()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_2()
        Call serverEnv_ss()

        ''block user from creating bugs for non-compatible project
        If Not project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10710" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&customfield_11184=11573" _
        & "&customfield_11180=11555" _
        & "&customfield_10250=" & langID & "" _
        & "&customfield_10480=" & platform _
        & "&customfield_10145=" & diNumber & " ( model=" & deviceModel & " Series=" & deviceSeries & " OS=" & deviceOS & " )" _
        & "&customfield_11181=" & buildVersion _
        & "&customfield_11182=" & sServerEnv _
        & "&customfield_10220=10420" _
        & "&description=" _
        & vlExternal

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub TXTNRM()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_1()

        ''block user from non-compatible project
        If project = "Blackdog" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "DMA" Then GoTo ErrHandler1
        If project = "Evermore" Then GoTo ErrHandler1
        If project Like "LGEVM*" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        'Build dynamic URL
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10082" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420" _
        & "&components=11199" _
        & "&customfield_10251=" & platform & "" _
        & "&customfield_10250=" & langID & "" _
        & "&description=" _
        & "TEST+ENVIRONMENT" _
        & "%0Ddevice:+" & diNumber & " (model=" & deviceModel & " Series=" & deviceSeries & " OS=" & deviceOS & ")" _
        & "%0Dbuild+version:+" & buildVersion _
        & "%0Dbuild+path:+" & buildPath _
        & "%0Dserver:+" & serverEnv & " (" & software & ")" & additionalInfo _
        & "%0D%0DPRECONDITIONS" _
        & "%0DDatapack:+" _
        & "%0D" & Chr(34) & "FieldID" & Chr(34) & ":+" _
        & "%0D----" _
        & "%0D%0D||unformatted+utt+[" & language & "]||unformatted+utt+[en-US]||String+to+tag||displayed||" _
        & "%0D|+|+|+|+|" _
        & "%0D%0DNotes:+" _
        & "%0D%0DTest+source:+"

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub VVSDM()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_1()

        ''block user from non-compatible project
        If project = "Blackdog" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "DMA" Then GoTo ErrHandler1
        If project = "Evermore" Then GoTo ErrHandler1
        If project Like "LGEVM*" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10267" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420" _
        & "&components=11440" _
        & "&customfield_10251=" & platform & "" _
        & "&customfield_10250=" & langID & "" _
        & "&description=" & vlServer

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub

    Public Sub VVSCFG()

        Call setActiveTab()
        Call descriptions()
        Call vlLanguages_1()
        Call vlPlatforms_1()

        ''block user from non-compatible project
        If project = "Blackdog" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "DMA" Then GoTo ErrHandler1
        If project = "Evermore" Then GoTo ErrHandler1
        If project Like "LGEVM*" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then GoTo ErrHandler2

        ''build url
        url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=10300" _
        & "&issuetype=1" _
        & "&summary=[" & project & "]" & automationTest & "[" & language & "]+summary" _
        & "&priority=3" _
        & "&customfield_10220=10420" _
        & "&components=11375" _
        & "&customfield_10251=" & platform & "" _
        & "&customfield_10250=" & langID & "" _
        & "&description=" & vlServer

        On Error GoTo ErrHandler3
        Process.Start(url)

        Exit Sub

ErrHandler1:
        MsgBox("Jira type not compatible with project selected.")
        Exit Sub
ErrHandler2:
        MsgBox("Project not compatible with server selected.")
        Exit Sub
ErrHandler3:
        MsgBox("There was an issue opening the Jira URL.")
        Exit Sub

    End Sub


End Module
