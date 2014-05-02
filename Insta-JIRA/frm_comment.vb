Public Class frm_comment

    Private Sub tbx_comment_Enter(sender As Object, e As System.EventArgs) Handles tbx_comment.Enter

        Me.tbx_comment.SelectAll()

    End Sub

    Private Sub btn_commentClose_Click(sender As System.Object, e As System.EventArgs) Handles btn_commentClose.Click

        Me.tbx_comment.Text = ""
        Me.Close()

    End Sub

End Class