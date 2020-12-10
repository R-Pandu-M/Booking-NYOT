Public Class Form1

    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        If karyawan.Text = "Karyawan" And password.Text = "loginform" Then
            Form2.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbutton.Click
        Me.Dispose()
    End Sub
End Class
