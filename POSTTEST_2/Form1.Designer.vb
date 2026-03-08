<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gbTambah = New GroupBox()
        txtGenre = New TextBox()
        Label2 = New Label()
        btnTambah = New Button()
        txtJudulTambah = New TextBox()
        Label1 = New Label()
        gbHapus = New GroupBox()
        txtJudulHapus = New TextBox()
        btnHapus = New Button()
        Label3 = New Label()
        dgvBuku = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        gbTambah.SuspendLayout()
        gbHapus.SuspendLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbTambah
        ' 
        gbTambah.Controls.Add(txtGenre)
        gbTambah.Controls.Add(Label2)
        gbTambah.Controls.Add(btnTambah)
        gbTambah.Controls.Add(txtJudulTambah)
        gbTambah.Controls.Add(Label1)
        gbTambah.ForeColor = Color.Green
        gbTambah.Location = New Point(57, 70)
        gbTambah.Name = "gbTambah"
        gbTambah.Size = New Size(304, 191)
        gbTambah.TabIndex = 0
        gbTambah.TabStop = False
        gbTambah.Text = "Tambah Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(132, 95)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(147, 31)
        txtGenre.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 3
        Label2.Text = "Genre"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Green
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(179, 135)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(100, 41)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Location = New Point(132, 41)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(147, 31)
        txtJudulTambah.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 2
        Label1.Text = "Judul Buku"
        ' 
        ' gbHapus
        ' 
        gbHapus.BackColor = SystemColors.Control
        gbHapus.Controls.Add(txtJudulHapus)
        gbHapus.Controls.Add(btnHapus)
        gbHapus.Controls.Add(Label3)
        gbHapus.ForeColor = Color.Red
        gbHapus.Location = New Point(484, 70)
        gbHapus.Name = "gbHapus"
        gbHapus.Size = New Size(306, 191)
        gbHapus.TabIndex = 1
        gbHapus.TabStop = False
        gbHapus.Text = "Hapus Buku"
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(139, 38)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(147, 31)
        txtJudulHapus.TabIndex = 4
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(188, 137)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(98, 36)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 4
        Label3.Text = "Judul Buku"
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvBuku.Location = New Point(57, 336)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.Size = New Size(304, 228)
        dgvBuku.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul Buku"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Genre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(963, 570)
        Controls.Add(dgvBuku)
        Controls.Add(gbHapus)
        Controls.Add(gbTambah)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pengelolaan Daftar Buku"
        gbTambah.ResumeLayout(False)
        gbTambah.PerformLayout()
        gbHapus.ResumeLayout(False)
        gbHapus.PerformLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbTambah As GroupBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbHapus As GroupBox
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
