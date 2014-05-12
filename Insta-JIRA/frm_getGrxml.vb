Public Class frm_getGrxml

    Private Sub btn_grxml_Click(sender As System.Object, e As System.EventArgs) Handles btn_grxml.Click

        Me.Hide()
        Call getGrxml()

    End Sub

    Private Sub btn_jira_Click(sender As System.Object, e As System.EventArgs) Handles btn_jira.Click

        Me.Hide()
        Call MRECCMA()

    End Sub

    Private Sub frm_getGrxml_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call setActiveTab()

        With Me
            If language = "en-US" Then tbx_langId.Text = "eng-USA"
            If language = "fr-FR" Then tbx_langId.Text = "fra-FRA"
            If language = "it-IT" Then tbx_langId.Text = "ita-ITA"
            If language = "de-DE" Then tbx_langId.Text = "deu-DEU"
            If language = "es-ES" Then tbx_langId.Text = "spa-ESP"
            If language = "v-es-LA" Then tbx_langId.Text = "spa-XLA"
            If language = "pt-BR" Then tbx_langId.Text = "por-BRA"
            If language = "en-GB" Then tbx_langId.Text = "eng-GBR"
            If language = "zh-CN" Then tbx_langId.Text = "cmn-CHN"
            If language = "ja-JP" Then tbx_langId.Text = "jpn-JPN"
            If language = "ko-KR" Then tbx_langId.Text = "kor-KOR"
            If language = "ru-RU" Then tbx_langId.Text = "rus-RUS"
        End With

    End Sub

    Private Sub rad_Markley_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rad_markley.CheckedChanged

        With Me
            .lbl_advise.Text = "Must connect to Vlingo VPN"
            .lbl_instructions.Text = "Speaker ID = 'Speaker ID' from asr/sr Raw Log" _
                                        & vbCrLf & "NMAID = 'NMAID' from asr/sr Raw Log"

            .btn_jira.Enabled = True
            .btn_grxml.Enabled = True
        End With

    End Sub

    Private Sub rad_montreal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rad_montreal.CheckedChanged

        With Me
            .lbl_advise.Text = ""
            .lbl_instructions.Text = "Speaker ID = 'uid' from CONNECTION INFO" _
                                        & vbCrLf & "NMAID = 'nmaid' from CONNECTION INFO"

            .btn_jira.Enabled = True
            .btn_grxml.Enabled = True
        End With

    End Sub

    Private Sub rad_cvt2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rad_cvt2.CheckedChanged

        With Me
            .lbl_advise.Text = "No access to CVT2; use Grammar request form"
            .lbl_instructions.Text = "Speaker ID = 'Speaker ID' from asr/sr Raw Log" _
                                        & vbCrLf & "NMAID = 'NMAID' from asr/sr Raw Log"

            .btn_jira.Enabled = True
            .btn_grxml.Enabled = False
        End With

    End Sub
End Class