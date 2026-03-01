Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not IsNumeric(txtIps.Text) Then
            MessageBox.Show("Masukkan angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim ipInput As Double = CDbl(txtIps.Text)

        If ipInput < 0 Or ipInput > 4.0 Then
            MessageBox.Show("IP Semester tidak boleh kurang dari 0 atau lebih dari 4.00!", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtIps.Clear()
            Return
        End If

        totalIP += ipInput
        jumlahSemester += 1

        Dim ipk As Double = totalIP / jumlahSemester
        labelIPK.Text = ipk.ToString("F2")

        If ipk >= 2.0 And ipk <= 2.75 Then
            lblPredikat.Text = "Cukup"
            lblPredikat.ForeColor = Color.Orange
            labelIPK.ForeColor = Color.Orange
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            lblPredikat.Text = "Memuaskan"
            lblPredikat.ForeColor = Color.Green
            labelIPK.ForeColor = Color.Green
        ElseIf ipk >= 3.01 And ipk <= 4.0 Then
            lblPredikat.Text = "Sangat Memuaskan"
            lblPredikat.ForeColor = Color.Blue
            labelIPK.ForeColor = Color.Blue
        Else
            lblPredikat.Text = "Tidak Memuaskan"
            lblPredikat.ForeColor = Color.Red
            labelIPK.ForeColor = Color.Red
        End If

        txtIps.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIps.Clear()
        labelIPK.Text = "0.00"
        lblPredikat.Text = "-"
        lblPredikat.ForeColor = Color.Black
        labelIPK.ForeColor = Color.Black
    End Sub
End Class
