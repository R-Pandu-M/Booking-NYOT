Public Class form_pembayaran

    Private Sub form_pembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub konfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles konfirm.Click
        If tunai.Checked = True Then
            ListView2.Items.Add("Tunai")
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(TextBox1.Text)
        ElseIf non_tunai.Checked = True Then
            ListView2.Items.Add("Tunai")
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(TextBox1.Text)
        End If
    End Sub

    
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
