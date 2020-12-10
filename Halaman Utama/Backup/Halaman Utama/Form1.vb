Public Class Form1
    Private Sub ComboTanggal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTanggal.SelectedIndexChanged

        If ComboTanggal.Text = "1 Februari 2021" Then
            LvTiket.Text = "1 Februari 2021"
        ElseIf ComboTanggal.Text = "2 Februari 2021" Then
            LvTiket.Text = "2 Februari 2021"
        ElseIf ComboTanggal.Text = "3 Februari 2021" Then
            LvTiket.Text = "3 Februari 2021"
        Else
            LvTiket.Text = "4 Februari 2021"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True Then
            MessageBox.Show("Theater 1, Movie 1 : 11.00-13.30")
        ElseIf RadioButton2.Checked = True Then
            MessageBox.Show("Theater 1, Movie 2 : 13.45-16.15")
        ElseIf RadioButton3.Checked = True Then
            MessageBox.Show("Theater 2, Movie 1 : 12.00-13.45")
        ElseIf RadioButton4.Checked = True Then
            MessageBox.Show("Theater 2, Movie 2 : 18.00-19.45")
        ElseIf RadioButton6.Checked = True Then
            MessageBox.Show("Theater 2, Movie 1 : 10.00-12.45")
        Else
            MessageBox.Show("Theater 2, Movie 2 : 18.00-19.45")
        End If

        LvTiket.Items.Add(ComboTanggal.Text)
        If RadioButton1.Checked = True Then
            LvTiket.Items.Add(LvTiket.Items.Count - 1).SubItems(RadioButton1.Text)
        ElseIf RadioButton2.Checked = True Then
            LvTiket.Items.Add(LvTiket.Items.Count - 1).SubItems(RadioButton2.Text)
        ElseIf RadioButton3.Checked = True Then
            LvTiket.Items.Add(LvTiket.Items.Count - 1).SubItems(RadioButton3.Text)
        ElseIf RadioButton4.Checked = True Then
            LvTiket.Items.Add(LvTiket.Items.Count - 1).SubItems(RadioButton4.Text)
        ElseIf RadioButton6.Checked = True Then
            LvTiket.Items.Add(LvTiket.Items.Count - 1).SubItems(RadioButton5.Text)
        Else
            LvTiket.Items.Add(LvTiket.Items.Count - 1).SubItems(RadioButton6.Text)
        End If
        LvTiket.Items(LvTiket.Items.Count - 1).SubItems(TextBox1.Text)
    End Sub
End Class
