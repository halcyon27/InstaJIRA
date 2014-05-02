Public Class frm_nJIRA

    Private Sub btn_zpAcc_Click(sender As System.Object, e As System.EventArgs) Handles btn_zpAcc.Click

        Me.Close()
        Call ZPACC()

    End Sub

    Private Sub btn_zpAdk_Click(sender As System.Object, e As System.EventArgs) Handles btn_zpAdk.Click

        Me.Close()
        Call ZPADK()

    End Sub

    Private Sub btn_zpAdrClint_Click(sender As System.Object, e As System.EventArgs) Handles btn_zpAdrClint.Click

        Me.Close()
        Call ZPADRCLINT()

    End Sub

    Private Sub btn_zpGnl_Click(sender As System.Object, e As System.EventArgs) Handles btn_zpGnl.Click

        Me.Close()
        Call ZPGNL()

    End Sub

    Private Sub btn_Nlps_Click(sender As System.Object, e As System.EventArgs) Handles btn_Nlps.Click

        Me.Close()
        Call ZPNLPS()

    End Sub

    Private Sub btn_zpNlu_Click(sender As System.Object, e As System.EventArgs) Handles btn_zpNlu.Click

        Me.Close()
        Call ZPNLU()

    End Sub

    Private Sub btn_zpUdss_Click(sender As System.Object, e As System.EventArgs) Handles btn_zpUdss.Click

        Me.Close()
        Call ZPUDSS()

    End Sub
End Class