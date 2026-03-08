Public Class Form1
    Sub RefreshDGV(ByRef dgv As DataGridView)
        dgv.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgv.Rows.Add(daftarBuku(0, i), daftarBuku(1, i))
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudulTambah.Text <> "" And txtGenre.Text <> "" Then
            TambahDataBuku(txtJudulTambah.Text, txtGenre.Text)

            RefreshDGV(dgvBuku)

            txtJudulTambah.Clear()
            txtGenre.Clear()
        Else
            MsgBox("Isi Judul dan Genre terlebih dahulu!")
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulYangDicari As String = txtJudulHapus.Text

        Dim index As Integer = CariIndexBuku(judulYangDicari)

        If index <> -1 Then
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(0, i) = daftarBuku(0, i + 1)
                daftarBuku(1, i) = daftarBuku(1, i + 1)
            Next

            jumlahBuku -= 1

            daftarBuku(0, jumlahBuku) = Nothing
            daftarBuku(1, jumlahBuku) = Nothing

            RefreshDGV(dgvBuku)

            txtJudulHapus.Clear()
            MessageBox.Show("Buku '" & judulYangDicari & "' berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Maaf, buku dengan judul '" & judulYangDicari & "' tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class