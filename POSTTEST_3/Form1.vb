Public Class Form1


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HanyaAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtNoTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If openFile.ShowDialog() = DialogResult.OK Then
            picProfile.Image = Image.FromFile(openFile.FileName)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim listHobby As New List(Of String)
        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                listHobby.Add(DirectCast(ctrl, CheckBox).Text)
            End If
        Next
        Dim hobbyResult As String = String.Join(", ", listHobby)

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoTelp.Text = "" Or txtAlamat.Text = "" Or
           picProfile.Image Is Nothing Or (Not rbLaki.Checked And Not rbPerempuan.Checked) Or
           hobbyResult = "" Then

            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim f2 As New Form2()

        f2.lblNamaHasil.Text = txtNama.Text
        f2.lblUmurHasil.Text = txtUmur.Text & " Tahun"
        f2.lblTglHasil.Text = dtpTanggal.Value.ToString("dd/MM/yyyy")
        f2.lblNoTelpHasil.Text = txtNoTelp.Text
        f2.lblAlamatHasil.Text = txtAlamat.Text
        f2.lblGenderHasil.Text = If(rbLaki.Checked, "Laki - Laki", "Perempuan")
        f2.lblHobiHasil.Text = hobbyResult
        f2.picHasil.Image = picProfile.Image

        f2.Show()
    End Sub

End Class