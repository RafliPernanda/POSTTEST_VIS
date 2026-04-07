Public Class Form1
    Dim isKartuSiap As Boolean = False

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Inputan tidak boleh kosong (Nama hanya boleh berisi huruf!)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("ID Anggota hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ofdFoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If ofdFoto.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(ofdFoto.FileName)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or txtID.Text = "" Or mtbTelepon.Text = "" Or cbRole.SelectedIndex = -1 Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim peranTerpilih As String = ""
        If rbKetua.Checked Then
            peranTerpilih = "Ketua"
        ElseIf rbAdmin.Checked Then
            peranTerpilih = "Admin"
        ElseIf rbAnggota.Checked Then
            peranTerpilih = "Anggota"
        Else
            MessageBox.Show("Inputan tidak boleh kosong (Pilih salah satu Peran!)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hobiList As New List(Of String)
        For Each cb As CheckBox In gbAktivitas.Controls.OfType(Of CheckBox)()
            If cb.Checked Then hobiList.Add(cb.Text)
        Next

        If hobiList.Count = 0 Then
            MessageBox.Show("Inputan tidak boleh kosong (Pilih minimal 1 aktivitas!)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek Foto
        If pbFoto.Image Is Nothing Then
            MessageBox.Show("Silakan upload foto profil terlebih dahulu!", "Peringatan")
            Exit Sub
        End If

        Dim konfirmasi = MessageBox.Show("Apakah Anda ingin mencetak kartu sekarang?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Dim kartu As New Form2()
            kartu.lblNamaKartu.Text = txtNama.Text
            kartu.lblIDKartu.Text = "ID: " & txtID.Text
            kartu.lblDivisiKartu.Text = "Role: " & cbRole.SelectedItem.ToString() & " | " & peranTerpilih
            kartu.lblKontakKartu.Text = mtbTelepon.Text & " | " & txtEmail.Text
            kartu.lblAlamatKartu.Text = "Alamat: " & txtAlamat.Text
            kartu.pbFotoKartu.Image = pbFoto.Image
            kartu.lblAktivitasKartu.Text = "Aktivitas: " & String.Join(", ", hobiList)

            kartu.Show()
            isKartuSiap = True
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        Dim sfd = SaveFileDialog1
        sfd.Filter = "Text Files (*.txt)|*.txt"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New System.IO.StreamWriter(sfd.FileName)
                    writer.WriteLine(txtNama.Text)
                    writer.WriteLine(txtID.Text)
                    writer.WriteLine(mtbTelepon.Text)
                    writer.WriteLine(txtEmail.Text)
                    writer.WriteLine(txtAlamat.Text)
                End Using
                MessageBox.Show("Data berhasil disimpan ke file!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal simpan: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Text Files (*.txt)|*.txt"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim lines() As String = System.IO.File.ReadAllLines(ofd.FileName)
                If lines.Length >= 5 Then
                    txtNama.Text = lines(0)
                    txtID.Text = lines(1)
                    mtbTelepon.Text = lines(2)
                    txtEmail.Text = lines(3)
                    txtAlamat.Text = lines(4)
                    MessageBox.Show("Data berhasil dimuat!", "Sukses")
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal membaca file!")
            End Try
        End If
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If isKartuSiap = False Then
            MessageBox.Show("Belum ada data kartu yang dicetak. Silakan isi data dan klik 'Simpan & Cetak' terlebih dahulu!", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TabControl1.SelectedTab = TabPage1
        Else
            Dim kartu As New Form2()

            Dim peranTerpilih As String = If(rbKetua.Checked, "Ketua", If(rbAdmin.Checked, "Admin", "Anggota"))

            kartu.lblNamaKartu.Text = txtNama.Text
            kartu.lblIDKartu.Text = "ID: " & txtID.Text
            kartu.lblDivisiKartu.Text = "Role: " & cbRole.SelectedItem.ToString() & " | " & peranTerpilih
            kartu.lblKontakKartu.Text = mtbTelepon.Text & " | " & txtEmail.Text
            kartu.lblAlamatKartu.Text = "Alamat: " & txtAlamat.Text
            kartu.pbFotoKartu.Image = pbFoto.Image

            Dim hobiList As New List(Of String)
            For Each cb As CheckBox In gbAktivitas.Controls.OfType(Of CheckBox)()
                If cb.Checked Then hobiList.Add(cb.Text)
            Next
            kartu.lblAktivitasKartu.Text = "Aktivitas: " & String.Join(", ", hobiList)

            kartu.Show()
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim tanya = MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub
End Class