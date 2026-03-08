Module Module1

    Public daftarBuku(1, 100) As String
    Public jumlahBuku As Integer = 0
    Sub TambahDataBuku(ByVal judul As String, ByVal genre As String)

        daftarBuku(0, jumlahBuku) = judul.Trim()
        daftarBuku(1, jumlahBuku) = genre.Trim()
        jumlahBuku += 1
    End Sub

    Function CariIndexBuku(ByVal judulTarget As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(0, i).Trim().ToLower() = judulTarget.Trim().ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module