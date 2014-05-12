Module mod_getGrxml

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
