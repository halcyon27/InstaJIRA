Module Module1

    Public Sub Evermore()

        Call setActiveTab()
        Call descriptions()
        Call nLanguages()
        Call nPlatforms()

        ''block user from non-compatible project
        If Not project = "Evermore" Then GoTo ErrHandler1

        ''blocks user from creating bugs for non-compatible servers
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        ''build url
        ''old vlingo url: url = "http://jira.vlingo.com/secure/CreateIssueDetails!init.jspa?pid=12010"
        url = "https://mobility-jira.nuance.com/secure/CreateIssueDetails!init.jspa?pid=13800" _
        & "&issuetype=1" _
        & "&priority=4" _
        & "&customfield_10001=10000" _
        & "&customfield_10502=" & platform & "" _
        & "&customfield_10002=" & langID & "" _
        & "&customfield_11801=" & version & "" _
        & "&resolution=12" _
        & nServer _
        & "%0D%0DNLPS%0D{code}{code}"

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

    Public Sub ZPACC()

        Call setActiveTab()
        Call descriptions()
        Call nLanguages()
        Call nPlatforms()

        ''block user from creating bugs for non-compatible project
        If project = "Bproject" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "CC" Then GoTo ErrHandler1
        If project = "Hproject" Then GoTo ErrHandler1
        If project Like "Jproject*" Then GoTo ErrHandler1
        If project = "Kproject" Then GoTo ErrHandler1
        If project = "Midas" Then GoTo ErrHandler1
        If project = "Q2" Then GoTo ErrHandler1
        If project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        If project = "Blackdog" Then version = "R2"
        If project = "Evermore" Then version = "R2"
        If project = "LGEVM" Then version = "R1"
        If project = "LGEVM B2" Then version = "R2"
        If project = "DMA" Then version = ""

        ''build url
        url = "https://mobility-jira.nuance.com/secure/CreateIssueDetails!init.jspa?pid=10921" _
        & "&issuetype=1" _
        & "&priority=4" _
        & "&customfield_10001=10000" _
        & "&customfield_10502=" & platform & "" _
        & "&customfield_10002=" & langID & "" _
        & "&customfield_11801=" & version & "" _
        & nServer _
        & "%0D%0DVARIANTS%0D||Utt||Result||%0D|++++|+++++++|%0D"

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

    Public Sub ZPADK()

        Call setActiveTab()
        Call descriptions()
        Call nLanguages()
        Call nPlatforms()

        ''block user from creating bugs for non-compatible project
        If project = "Bproject" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "CC" Then GoTo ErrHandler1
        If project = "Hproject" Then GoTo ErrHandler1
        If project Like "Jproject*" Then GoTo ErrHandler1
        If project = "Kproject" Then GoTo ErrHandler1
        If project = "Midas" Then GoTo ErrHandler1
        If project = "Q2" Then GoTo ErrHandler1
        If project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        If project = "Blackdog" Then version = "R2"
        If project = "Evermore" Then version = "R2"
        If project = "LGEVM" Then version = "R1"
        If project = "LGEVM B2" Then version = "R2"
        If project = "DMA" Then version = ""

        ''build url
        url = "https://mobility-jira.nuance.com/secure/CreateIssueDetails!init.jspa?pid=10123" _
        & "&issuetype=1" _
        & "&priority=4" _
        & "&customfield_10001=10000" _
        & "&customfield_10502=" & platform & "" _
        & "&customfield_10002=" & langID & "" _
        & "&customfield_11801=" & version & "" _
        & nServer

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

    Public Sub ZPADRCLINT()

        Call setActiveTab()
        Call descriptions()
        Call nLanguages()
        Call nPlatforms()

        ''block user from creating bugs for non-compatible project
        If project = "Bproject" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "CC" Then GoTo ErrHandler1
        If project = "Hproject" Then GoTo ErrHandler1
        If project Like "Jproject*" Then GoTo ErrHandler1
        If project = "Kproject" Then GoTo ErrHandler1
        If project = "Midas" Then GoTo ErrHandler1
        If project = "Q2" Then GoTo ErrHandler1
        If project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        If project = "Blackdog" Then version = "R2"
        If project = "Evermore" Then version = "R2"
        If project = "LGEVM" Then version = "R1"
        If project = "LGEVM B2" Then version = "R2"
        If project = "DMA" Then version = ""

        ''build url
        url = "https://mobility-jira.nuance.com/secure/CreateIssueDetails!init.jspa?pid=10202" _
        & "&issuetype=1" _
        & "&priority=4" _
        & "&customfield_10001=10000" _
        & "&customfield_10502=" & platform & "" _
        & "&customfield_10002=" & langID & "" _
        & "&customfield_11801=" & version & "" _
        & nServer

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

    Public Sub ZPGNL()

        Call setActiveTab()
        Call descriptions()
        Call nLanguages()
        Call nPlatforms()

        ''block user from creating bugs for non-compatible project
        If project = "Bproject" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "CC" Then GoTo ErrHandler1
        If project = "Hproject" Then GoTo ErrHandler1
        If project Like "Jproject*" Then GoTo ErrHandler1
        If project = "Kproject" Then GoTo ErrHandler1
        If project = "Midas" Then GoTo ErrHandler1
        If project = "Q2" Then GoTo ErrHandler1
        If project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        If project = "Blackdog" Then version = "R2"
        If project = "Evermore" Then version = "R2"
        If project = "LGEVM" Then version = "R1"
        If project = "LGEVM B2" Then version = "R2"
        If project = "DMA" Then version = ""

        ''build url
        url = "https://mobility-jira.nuance.com/secure/CreateIssueDetails!init.jspa?pid=10125" _
        & "&issuetype=1" _
        & "&priority=4" _
        & "&customfield_10001=10000" _
        & "&customfield_10502=" & platform & "" _
        & "&customfield_10002=" & langID & "" _
        & "&customfield_11801=" & version & "" _
        & nServer _
        & "%0D%0DNLPS%0D{code}{code}"

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

    Public Sub ZPNLPS()

        Call setActiveTab()
        Call descriptions()
        Call nLanguages()
        Call nPlatforms()

        ''block user from creating bugs for non-compatible project
        If project = "Bproject" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "CC" Then GoTo ErrHandler1
        If project = "Hproject" Then GoTo ErrHandler1
        If project Like "Jproject*" Then GoTo ErrHandler1
        If project = "Kproject" Then GoTo ErrHandler1
        If project = "Midas" Then GoTo ErrHandler1
        If project = "Q2" Then GoTo ErrHandler1
        If project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        If project = "Blackdog" Then version = "R2"
        If project = "Evermore" Then version = "R2"
        If project = "LGEVM" Then version = "R1"
        If project = "LGEVM B2" Then version = "R2"
        If project = "DMA" Then version = ""

        ''build url
        url = "https://mobility-jira.nuance.com/secure/CreateIssueDetails!init.jspa?=10126" _
        & "&issuetype=1" _
        & "&priority=4" _
        & "&customfield_10001=10000" _
        & "&customfield_10502=" & platform & "" _
        & "&customfield_10002=" & langID & "" _
        & "&customfield_11801=" & version & "" _
        & nServer _
        & "%0D%0DNLPS%0D{code}{code}"

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

    Public Sub ZPNLU()

        Dim url As Object

        Call setActiveTab()
        Call descriptions()
        Call nLanguages()
        Call nPlatforms()

        ''block user from creating bugs for non-compatible project
        If project = "Bproject" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "CC" Then GoTo ErrHandler1
        If project = "Hproject" Then GoTo ErrHandler1
        If project Like "Jproject*" Then GoTo ErrHandler1
        If project = "Kproject" Then GoTo ErrHandler1
        If project = "Midas" Then GoTo ErrHandler1
        If project = "Q2" Then GoTo ErrHandler1
        If project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        If project = "Blackdog" Then version = "R2"
        If project = "Evermore" Then version = "R2"
        If project = "LGEVM" Then version = "R1"
        If project = "LGEVM B2" Then version = "R2"
        If project = "DMA" Then version = ""

        ''build url
        url = "https://mobility-jira.nuance.com/secure/CreateIssueDetails!init.jspa?pid=10127" _
        & "&issuetype=1" _
        & "&priority=4" _
        & "&customfield_10001=10000" _
        & "&customfield_10502=" & platform & "" _
        & "&customfield_10002=" & langID & "" _
        & "&customfield_11801=" & version & "" _
        & nServer _
        & "%0D%0DVARIANTS%0D||Utt||Result||%0D|++++|+++++++|"

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

    Public Sub ZPUDSS()

        Call setActiveTab()
        Call descriptions()
        Call nLanguages()
        Call nPlatforms()

        ''block user from creating bugs for non-compatible project
        If project = "Bproject" Then GoTo ErrHandler1
        If project = "CEC" Then GoTo ErrHandler1
        If project = "CC" Then GoTo ErrHandler1
        If project = "Hproject" Then GoTo ErrHandler1
        If project Like "Jproject*" Then GoTo ErrHandler1
        If project = "Kproject" Then GoTo ErrHandler1
        If project = "Midas" Then GoTo ErrHandler1
        If project = "Q2" Then GoTo ErrHandler1
        If project = "Tizen" Then GoTo ErrHandler1

        ''block user from creating bugs for non-compatible server
        If serverEnv Like "MTL*" Or serverEnv Like "CVT*" Then
            GoTo continueSub
        Else
            GoTo ErrHandler2
        End If

continueSub:

        If project = "Blackdog" Then version = "R2"
        If project = "Evermore" Then version = "R2"
        If project = "LGEVM" Then version = "R1"
        If project = "LGEVM B2" Then version = "R2"
        If project = "DMA" Then version = ""

        ''build url
        url = "https://mobility-jira.nuance.com/secure/CreateIssueDetails!init.jspa?pid=10300" _
        & "&issuetype=1" _
        & "&priority=4" _
        & "&customfield_10001=10000" _
        & "&customfield_10502=" & platform & "" _
        & "&customfield_10002=" & langID & "" _
        & "&customfield_11801=" & version & "" _
        & nServer _
        & "%0D%0DNLPS%0D{code}{code}"

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
