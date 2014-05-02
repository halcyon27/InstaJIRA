Public Class frm_vJIRA

    Private Sub frm_vJIRA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_asrSciTagging_Click(sender As System.Object, e As System.EventArgs) Handles btn_asrSciTagging.Click

        Me.Close()
        Call ASRSCI()

    End Sub

    Private Sub btn_asrSciTxtNrm_Click(sender As System.Object, e As System.EventArgs) Handles btn_asrSciTxtNrm.Click

        Me.Close()
        Call TXTNRM()

    End Sub

    Private Sub btn_mreccma_Click(sender As System.Object, e As System.EventArgs) Handles btn_mreccma.Click

        Me.Close()
        Call MRECCMA()

    End Sub

    Private Sub btn_vvscfg_Click(sender As System.Object, e As System.EventArgs) Handles btn_vvscfg.Click

        Me.Close()
        Call VVSCFG()

    End Sub

    Private Sub btn_blackdog_Click(sender As System.Object, e As System.EventArgs) Handles btn_blackdog.Click

        Me.Close()
        Call BLKDG()

    End Sub

    Private Sub btn_lgeVm_Click(sender As System.Object, e As System.EventArgs) Handles btn_lgeVm.Click

        Me.Close()
        Call LGEVM()

    End Sub

    Private Sub btn_lgeVb_Click(sender As System.Object, e As System.EventArgs) Handles btn_lgeVb.Click

        Me.Close()
        Call LGEVB()

    End Sub

    Private Sub btn_nac_Click(sender As System.Object, e As System.EventArgs) Handles btn_nac.Click

        Me.Close()
        Call NAC()

    End Sub

    Private Sub btn_samc_Click(sender As System.Object, e As System.EventArgs) Handles btn_samc.Click

        Me.Close()
        Call SAMC()

    End Sub

    Private Sub btn_saq_Click(sender As System.Object, e As System.EventArgs) Handles btn_saq.Click

        Me.Close()
        Call SAQ()

    End Sub

    Private Sub btn_stz_Click(sender As System.Object, e As System.EventArgs) Handles btn_stz.Click

        Me.Close()
        Call STZ()

    End Sub

    Private Sub btn_saqe_Click(sender As System.Object, e As System.EventArgs) Handles btn_saqe.Click

        Me.Close()
        Call SAQE()

    End Sub

    Private Sub btn_sda_Click(sender As System.Object, e As System.EventArgs) Handles btn_sda.Click

        Me.Close()
        Call SDA()

    End Sub

    Private Sub btn_stze_Click(sender As System.Object, e As System.EventArgs) Handles btn_stze.Click

        Me.Close()
        Call STZE()

    End Sub
End Class