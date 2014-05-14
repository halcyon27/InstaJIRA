Module mod_controls

    Function getActiveTabIndex()

        'checks which tabpage is selected and returns as base 0 index
        Dim currentTabIndex As Int32 = frm_main.TabControl1.SelectedIndex
        Return currentTabIndex

        'Dim currentTabName As String = frm_Main.TabControl1.SelectedTab.Name
        'Dim tabsCount As Int32 = frm_Main.TabControl1.TabPages.Count

    End Function

    Function getAutomationTestType()

        'Dim rButton As RadioButton = frm_main.gbx_automation.Controls.OfType(Of RadioButton)().Where(Function(r) r.Checked = True).FirstOrDefault()
        'Dim automationTestType As String = rButton.Text

        'If automationTestType = "Manual" Then
        '    automationTestType = ""
        'Else : automationTestType = "[" & automationTestType & "]"
        'End If
        Dim automationTestType As String = ""
        With frm_main
            If .rad_mtc.Checked = True Then
                automationTestType = .rad_mtc.Text
                Return "[" & automationTestType & "]"
            ElseIf.rad_vlt.Checked = True Then
                    automationTestType = .rad_vlt.Text
                Return "[" & automationTestType & "-R]"
            ElseIf .rad_oneshot.Checked = True Then
                automationTestType = .rad_oneshot.Text
                Return "[" & automationTestType & "]"
            Else
                Return ""
            End If
        End With

    End Function

    Public Sub comment()

        Call setActiveTab()

        commentFormat = ""

        'build comment
        If language <> "" Then
            commentFormat = "lang: " & language & vbCrLf
        End If
        If diNumber <> "" Then
            commentFormat = commentFormat & "device: " & diNumber & " ( " & deviceInfo & " )" & vbCrLf
        End If
        If buildVersion <> "" Then
            commentFormat = commentFormat & "build version: " & buildVersion & vbCrLf
        End If
        If buildPath <> "" Then
            commentFormat = commentFormat & "build path: " & buildPath & vbCrLf
        End If
        If serverEnv <> "" Then
            commentFormat = commentFormat & "server: " & serverEnv
        End If
        If software = "" Then
            commentFormat = commentFormat
        End If
        If software <> "" And serverEnv = "" Then
            commentFormat = commentFormat & "server: ( " & software & " )" & vbCrLf
        End If
        If software <> "" And serverEnv <> "" Then
            commentFormat = commentFormat & " ( " & software & " ) "
        End If
        If datapack <> "" Then
            commentFormat = commentFormat & vbCrLf & "datapack: " & datapack
        End If

        If commentFormat = "()" Then commentFormat = ""

        commentFormat = "{noformat}" & vbCrLf & commentFormat & vbCrLf & "{noformat}"
        frm_comment.tbx_comment.Text = commentFormat

        frm_comment.ShowDialog()

    End Sub

    Public Sub clearActiveTab()

        Dim response As MsgBoxResult
        response = MsgBox("This will clear all entries in Server Environment " & getActiveTabIndex() + 1 _
                                              & vbCrLf & "Proceed?", MsgBoxStyle.YesNo, "Confirm")
        If response = 6 Then
            If getActiveTabIndex() = 0 Then
                With frm_main
                    .cbx_project0.Text = ""
                    .cbx_language0.Text = ""
                    .tbx_testSource0.Text = ""
                    .tbx_buildPath0.Text = ""
                    .tbx_buildVersion0.Text = ""
                    .cbx_serverEnv0.Text = ""
                    .tbx_host0.Text = ""
                    .tbx_software0.Text = ""
                    .tbx_datapack0.Text = ""
                    .cbx_diNumber0.Text = ""
                    .tbx_deviceInfo0.Text = ""
                End With

            End If

            If getActiveTabIndex() = 1 Then
                With frm_main
                    .cbx_project1.Text = ""
                    .cbx_language1.Text = ""
                    .tbx_testSource1.Text = ""
                    .tbx_buildPath1.Text = ""
                    .tbx_buildVersion1.Text = ""
                    .cbx_serverEnv1.Text = ""
                    .tbx_host1.Text = ""
                    .tbx_software1.Text = ""
                    .tbx_datapack1.Text = ""
                    .cbx_diNumber1.Text = ""
                    .tbx_deviceInfo1.Text = ""
                End With
            End If

            If getActiveTabIndex() = 2 Then
                With frm_main
                    .cbx_project2.Text = ""
                    .cbx_language2.Text = ""
                    .tbx_testSource2.Text = ""
                    .tbx_buildPath2.Text = ""
                    .tbx_buildVersion2.Text = ""
                    .cbx_serverEnv2.Text = ""
                    .tbx_host2.Text = ""
                    .tbx_software2.Text = ""
                    .tbx_datapack2.Text = ""
                    .cbx_diNumber2.Text = ""
                    .tbx_deviceInfo2.Text = ""
                End With
            End If
        Else : Exit Sub
        End If

    End Sub

    Public Sub getGrxml()

        Dim speakerId As String
        Dim nmaid As String
        Dim ecUrl As String
        Dim grxmlLangId As String

        On Error GoTo ErrHandler

        ''check that all values are filled
        If frm_getGrxml.tbx_langId.Text = "" Or frm_getGrxml.tbx_nmaid.Text = "" Or frm_getGrxml.tbx_speakerId.Text = "" Then GoTo ErrNoValue

        ''check that viable datacenter is selected
        If frm_getGrxml.rad_markley.Checked = False And frm_getGrxml.rad_montreal.Checked = False Then GoTo ErrNoValue

        ''set variables based on text entered in frmGetGRXML
        grxmlLangId = frm_getGrxml.tbx_langId.Text
        speakerId = frm_getGrxml.tbx_speakerId.Text
        nmaid = frm_getGrxml.tbx_nmaid.Text

        ''create string for Montreal
        If frm_getGrxml.rad_montreal.Checked = True Then
            If grxmlLangId = "spa=XLA" Then langID = "spa-ESP"
            url = "http://mt-bldmz02-15.nuance.com:8420/epWeb/nfileserver/method-decide/" & speakerId & "/0/" & nmaid & "_grammar_" & langID & ".zip?userid=" & speakerId & ""
        End If

        ''create string for Markley
        If frm_getGrxml.rad_markley.Checked = True Then
            url = "http://prod2124.vlingo.com:8420/epWeb/nfileserver/method-decide/" & speakerId & "/0/" & nmaid & "_grammar_" & langID & ".zip?userid=" & speakerId & ""
        End If

        Exit Sub

ErrNoValue:
        MsgBox("All values required")
        frm_getGrxml.ShowDialog()
        Exit Sub

ErrHandler:
        MsgBox("Failed to get grammar file. Submit requet via Grammar request form")
        Exit Sub

    End Sub

End Module
