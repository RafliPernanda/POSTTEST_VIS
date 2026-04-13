Public Class Form1
    Dim imgPathBaru As String = ""
    Dim imgPathEdit As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        KosongkanInput()
    End Sub

    Sub TampilData(Optional key As String = "")
        dgvParfum.DataSource = GetAllParfum(key)
    End Sub

    Sub KosongkanInput()
        txtNamaBaru.Clear()
        txtMerkBaru.Clear()
        numHargaBaru.Value = 0
        numStokBaru.Value = 0
        txtNotesBaru.Clear()
        If pbGambarBaru.Image IsNot Nothing Then pbGambarBaru.Image.Dispose()
        pbGambarBaru.Image = Nothing
        imgPathBaru = ""

        txtIdEdit.Clear()
        txtNamaEdit.Clear()
        txtMerkEdit.Clear()
        numHargaEdit.Value = 0
        numStokEdit.Value = 0
        txtNotesEdit.Clear()
        If pbGambarEdit.Image IsNot Nothing Then pbGambarEdit.Image.Dispose()
        pbGambarEdit.Image = Nothing
        imgPathEdit = ""
    End Sub


    Private Sub btnPilihGambar_Click(sender As Object, e As EventArgs) Handles btnPilihGambar.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                imgPathBaru = ofd.FileName
                If pbGambarBaru.Image IsNot Nothing Then pbGambarBaru.Image.Dispose()
                pbGambarBaru.Image = Image.FromFile(imgPathBaru)
            End If
        End Using
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaBaru.Text.Trim() = "" OrElse txtMerkBaru.Text.Trim() = "" OrElse txtNotesBaru.Text.Trim() = "" Then
            MessageBox.Show("Pastikan Nama, Merk, dan Notes bahan parfum sudah terisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If numHargaBaru.Value <= 0 Then
            MessageBox.Show("Harga parfum harus lebih dari 0!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If numStokBaru.Value <= 0 Then
            MessageBox.Show("Stok awal parfum tidak boleh 0 saat baru ditambahkan!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(imgPathBaru) OrElse Not IO.File.Exists(imgPathBaru) Then
            MessageBox.Show("Silakan pilih gambar parfum terlebih dahulu sebelum menyimpan data!", "Validasi Gambar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanParfum(txtNamaBaru.Text.Trim(), txtMerkBaru.Text.Trim(), numHargaBaru.Value, numStokBaru.Value, txtNotesBaru.Text.Trim(), imgPathBaru) Then
            MessageBox.Show("Parfum Berhasil Ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanInput()
            TabControl1.SelectedTab = tpDaftar
        End If
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        TampilData(txtSearch.Text)
    End Sub

    Private Sub dgvParfum_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParfum.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvParfum.Rows(e.RowIndex)
            txtIdEdit.Text = row.Cells("id").Value.ToString()
            txtNamaEdit.Text = row.Cells("nama_parfum").Value.ToString()
            txtMerkEdit.Text = row.Cells("merk").Value.ToString()
            numHargaEdit.Value = Convert.ToDecimal(row.Cells("harga").Value)
            numStokEdit.Value = Convert.ToInt32(row.Cells("stok").Value)
            txtNotesEdit.Text = row.Cells("notes").Value.ToString()

            Dim path As String = row.Cells("gambar_path").Value.ToString()
            If IO.File.Exists(path) Then
                If pbGambarEdit.Image IsNot Nothing Then pbGambarEdit.Image.Dispose()
                pbGambarEdit.Image = Image.FromFile(path)
                imgPathEdit = path
            Else
                If pbGambarEdit.Image IsNot Nothing Then pbGambarEdit.Image.Dispose()
                pbGambarEdit.Image = Nothing
                imgPathEdit = ""
            End If
        End If
    End Sub

    Private Sub btnPilihGambarEdit_Click(sender As Object, e As EventArgs) Handles btnPilihGambarEdit.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                imgPathEdit = ofd.FileName
                If pbGambarEdit.Image IsNot Nothing Then pbGambarEdit.Image.Dispose()
                pbGambarEdit.Image = Image.FromFile(imgPathEdit)
            End If
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtIdEdit.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang ingin diubah dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtNamaEdit.Text.Trim() = "" OrElse txtMerkEdit.Text.Trim() = "" OrElse txtNotesEdit.Text.Trim() = "" Then
            MessageBox.Show("Pastikan Nama, Merk, dan Notes bahan parfum tidak kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If numHargaEdit.Value <= 0 Then
            MessageBox.Show("Harga parfum harus lebih dari 0!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If UbahParfum(Convert.ToInt32(txtIdEdit.Text), txtNamaEdit.Text.Trim(), txtMerkEdit.Text.Trim(), numHargaEdit.Value, Convert.ToInt32(numStokEdit.Value), txtNotesEdit.Text.Trim(), imgPathEdit) Then
            MessageBox.Show("Data Berhasil Diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtIdEdit.Text.Trim() = "" Then Return

        If MessageBox.Show("Apakah Anda yakin ingin menghapus parfum ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If HapusParfum(Convert.ToInt32(txtIdEdit.Text)) Then
                MessageBox.Show("Data Berhasil Dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanInput()
            End If
        End If
    End Sub


    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        KosongkanInput()
        TampilData()
        TabControl1.SelectedTab = tpTambah
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class