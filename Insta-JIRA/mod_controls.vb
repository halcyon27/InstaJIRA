Module mod_controls

    Function getActiveTabIndex()

        'checks which tabpage is selected and returns as base 0 index
        Dim currentTabIndex As Int32 = frm_main.TabControl1.SelectedIndex
        Return currentTabIndex

        'Dim currentTabName As String = frm_Main.TabControl1.SelectedTab.Name
        'Dim tabsCount As Int32 = frm_Main.TabControl1.TabPages.Count

    End Function

    Function getAutomationTestType()

        Dim rButton As RadioButton = frm_main.gbx_automation.Controls.OfType(Of RadioButton)().Where(Function(r) r.Checked = True).FirstOrDefault()
        Dim automationTestType As String = rButton.Text

        If automationTestType = "Manual" Then
            automationTestType = ""
        Else : automationTestType = "[" & automationTestType & "]"
        End If

        Return automationTestType

    End Function

    Public Sub comment()

        Call setActiveTab()

        commentFormat = ""

        'build comment
        If language <> "" Then
            commentFormat = "lang: " & language & vbCrLf
        End If
        If diNumber <> "" Then
            commentFormat = commentFormat & "device: " & diNumber & " ( model=" & deviceModel & " | series=" & deviceSeries & " | os=" & deviceOS & " )" & vbCrLf
        End If
        If diNumber = "" And deviceModel <> "" Then
            commentFormat = commentFormat & "device: ( model=" & deviceModel & " | series=" & deviceSeries & " | os=" & deviceOS & " )" & vbCrLf
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
            commentFormat = commentFormat & " ( " & software & " )" & vbCrLf
        End If
        If datapack <> "" Then
            commentFormat = commentFormat & "datapack: " & datapack
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

End Module
