Imports MySqlConnector

Module DataModule
    ' Tampil Data & Search
    Public Function GetAllParfum(Optional keyword As String = "") As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM parfum"
            If keyword <> "" Then
                query &= " WHERE nama_parfum LIKE @key OR merk LIKE @key"
            End If

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    If keyword <> "" Then da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil data: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Simpan 
    Public Function SimpanParfum(nama As String, merk As String, harga As Decimal, stok As Integer, notes As String, gambar As String) As Boolean
        Try
            Dim query As String = "INSERT INTO parfum (nama_parfum, merk, harga, stok, notes, gambar_path) " &
                                 "VALUES (@nama, @merk, @harga, @stok, @notes, @gambar)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@merk", merk)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@notes", notes)
                    cmd.Parameters.AddWithValue("@gambar", gambar)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    ' Update
    Public Function UbahParfum(id As Integer, nama As String, merk As String, harga As Decimal, stok As Integer, notes As String, gambar As String) As Boolean
        Try
            Dim query As String = "UPDATE parfum SET nama_parfum=@nama, merk=@merk, harga=@harga, " &
                                 "stok=@stok, notes=@notes, gambar_path=@gambar WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@merk", merk)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@notes", notes)
                    cmd.Parameters.AddWithValue("@gambar", gambar)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message)
            Return False
        End Try
    End Function

    ' Hapus
    Public Function HapusParfum(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM parfum WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function
End Module