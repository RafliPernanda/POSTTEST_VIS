<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpTambah = New System.Windows.Forms.TabPage()
        Me.lblTitleTambah = New System.Windows.Forms.Label()
        Me.lblNamaBaru = New System.Windows.Forms.Label()
        Me.txtNamaBaru = New System.Windows.Forms.TextBox()
        Me.lblMerkBaru = New System.Windows.Forms.Label()
        Me.txtMerkBaru = New System.Windows.Forms.TextBox()
        Me.lblHargaBaru = New System.Windows.Forms.Label()
        Me.numHargaBaru = New System.Windows.Forms.NumericUpDown()
        Me.lblStokBaru = New System.Windows.Forms.Label()
        Me.numStokBaru = New System.Windows.Forms.NumericUpDown()
        Me.lblNotesBaru = New System.Windows.Forms.Label()
        Me.txtNotesBaru = New System.Windows.Forms.TextBox()
        Me.pbGambarBaru = New System.Windows.Forms.PictureBox()
        Me.btnPilihGambar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.tpDaftar = New System.Windows.Forms.TabPage()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvParfum = New System.Windows.Forms.DataGridView()
        Me.gbEdit = New System.Windows.Forms.GroupBox()
        Me.lblIdEdit = New System.Windows.Forms.Label()
        Me.txtIdEdit = New System.Windows.Forms.TextBox()
        Me.lblNamaEdit = New System.Windows.Forms.Label()
        Me.txtNamaEdit = New System.Windows.Forms.TextBox()
        Me.lblMerkEdit = New System.Windows.Forms.Label()
        Me.txtMerkEdit = New System.Windows.Forms.TextBox()
        Me.lblHargaEdit = New System.Windows.Forms.Label()
        Me.numHargaEdit = New System.Windows.Forms.NumericUpDown()
        Me.lblStokEdit = New System.Windows.Forms.Label()
        Me.numStokEdit = New System.Windows.Forms.NumericUpDown()
        Me.lblNotesEdit = New System.Windows.Forms.Label()
        Me.txtNotesEdit = New System.Windows.Forms.TextBox()
        Me.pbGambarEdit = New System.Windows.Forms.PictureBox()
        Me.btnPilihGambarEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpTambah.SuspendLayout()
        CType(Me.numHargaBaru, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStokBaru, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGambarBaru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDaftar.SuspendLayout()
        CType(Me.dgvParfum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEdit.SuspendLayout()
        CType(Me.numHargaEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStokEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGambarEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpTambah)
        Me.TabControl1.Controls.Add(Me.tpDaftar)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 772)
        Me.TabControl1.TabIndex = 1
        '
        'tpTambah
        '
        Me.tpTambah.Controls.Add(Me.lblTitleTambah)
        Me.tpTambah.Controls.Add(Me.lblNamaBaru)
        Me.tpTambah.Controls.Add(Me.txtNamaBaru)
        Me.tpTambah.Controls.Add(Me.lblMerkBaru)
        Me.tpTambah.Controls.Add(Me.txtMerkBaru)
        Me.tpTambah.Controls.Add(Me.lblHargaBaru)
        Me.tpTambah.Controls.Add(Me.numHargaBaru)
        Me.tpTambah.Controls.Add(Me.lblStokBaru)
        Me.tpTambah.Controls.Add(Me.numStokBaru)
        Me.tpTambah.Controls.Add(Me.lblNotesBaru)
        Me.tpTambah.Controls.Add(Me.txtNotesBaru)
        Me.tpTambah.Controls.Add(Me.pbGambarBaru)
        Me.tpTambah.Controls.Add(Me.btnPilihGambar)
        Me.tpTambah.Controls.Add(Me.btnSimpan)
        Me.tpTambah.Location = New System.Drawing.Point(4, 29)
        Me.tpTambah.Name = "tpTambah"
        Me.tpTambah.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTambah.Size = New System.Drawing.Size(792, 739)
        Me.tpTambah.TabIndex = 0
        Me.tpTambah.Text = "Tambah Parfum Baru"
        Me.tpTambah.UseVisualStyleBackColor = True
        '
        'lblTitleTambah
        '
        Me.lblTitleTambah.AutoSize = True
        Me.lblTitleTambah.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTambah.Location = New System.Drawing.Point(20, 20)
        Me.lblTitleTambah.Name = "lblTitleTambah"
        Me.lblTitleTambah.Size = New System.Drawing.Size(264, 37)
        Me.lblTitleTambah.TabIndex = 0
        Me.lblTitleTambah.Text = "Input Data Parfum"
        '
        'lblNamaBaru
        '
        Me.lblNamaBaru.AutoSize = True
        Me.lblNamaBaru.Location = New System.Drawing.Point(20, 80)
        Me.lblNamaBaru.Name = "lblNamaBaru"
        Me.lblNamaBaru.Size = New System.Drawing.Size(99, 20)
        Me.lblNamaBaru.TabIndex = 1
        Me.lblNamaBaru.Text = "Nama Parfum"
        '
        'txtNamaBaru
        '
        Me.txtNamaBaru.Location = New System.Drawing.Point(130, 77)
        Me.txtNamaBaru.Name = "txtNamaBaru"
        Me.txtNamaBaru.Size = New System.Drawing.Size(250, 27)
        Me.txtNamaBaru.TabIndex = 2
        '
        'lblMerkBaru
        '
        Me.lblMerkBaru.AutoSize = True
        Me.lblMerkBaru.Location = New System.Drawing.Point(20, 120)
        Me.lblMerkBaru.Name = "lblMerkBaru"
        Me.lblMerkBaru.Size = New System.Drawing.Size(42, 20)
        Me.lblMerkBaru.TabIndex = 3
        Me.lblMerkBaru.Text = "Merk"
        '
        'txtMerkBaru
        '
        Me.txtMerkBaru.Location = New System.Drawing.Point(130, 117)
        Me.txtMerkBaru.Name = "txtMerkBaru"
        Me.txtMerkBaru.Size = New System.Drawing.Size(250, 27)
        Me.txtMerkBaru.TabIndex = 4
        '
        'lblHargaBaru
        '
        Me.lblHargaBaru.AutoSize = True
        Me.lblHargaBaru.Location = New System.Drawing.Point(20, 160)
        Me.lblHargaBaru.Name = "lblHargaBaru"
        Me.lblHargaBaru.Size = New System.Drawing.Size(50, 20)
        Me.lblHargaBaru.TabIndex = 5
        Me.lblHargaBaru.Text = "Harga"
        '
        'numHargaBaru
        '
        Me.numHargaBaru.Location = New System.Drawing.Point(130, 158)
        Me.numHargaBaru.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.numHargaBaru.Name = "numHargaBaru"
        Me.numHargaBaru.Size = New System.Drawing.Size(150, 27)
        Me.numHargaBaru.TabIndex = 6
        '
        'lblStokBaru
        '
        Me.lblStokBaru.AutoSize = True
        Me.lblStokBaru.Location = New System.Drawing.Point(20, 200)
        Me.lblStokBaru.Name = "lblStokBaru"
        Me.lblStokBaru.Size = New System.Drawing.Size(38, 20)
        Me.lblStokBaru.TabIndex = 7
        Me.lblStokBaru.Text = "Stok"
        '
        'numStokBaru
        '
        Me.numStokBaru.Location = New System.Drawing.Point(130, 198)
        Me.numStokBaru.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numStokBaru.Name = "numStokBaru"
        Me.numStokBaru.Size = New System.Drawing.Size(100, 27)
        Me.numStokBaru.TabIndex = 8
        '
        'lblNotesBaru
        '
        Me.lblNotesBaru.AutoSize = True
        Me.lblNotesBaru.Location = New System.Drawing.Point(20, 240)
        Me.lblNotesBaru.Name = "lblNotesBaru"
        Me.lblNotesBaru.Size = New System.Drawing.Size(48, 20)
        Me.lblNotesBaru.TabIndex = 9
        Me.lblNotesBaru.Text = "Notes"
        '
        'txtNotesBaru
        '
        Me.txtNotesBaru.Location = New System.Drawing.Point(130, 237)
        Me.txtNotesBaru.Multiline = True
        Me.txtNotesBaru.Name = "txtNotesBaru"
        Me.txtNotesBaru.Size = New System.Drawing.Size(250, 100)
        Me.txtNotesBaru.TabIndex = 10
        '
        'pbGambarBaru
        '
        Me.pbGambarBaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbGambarBaru.Location = New System.Drawing.Point(420, 77)
        Me.pbGambarBaru.Name = "pbGambarBaru"
        Me.pbGambarBaru.Size = New System.Drawing.Size(250, 250)
        Me.pbGambarBaru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGambarBaru.TabIndex = 11
        Me.pbGambarBaru.TabStop = False
        '
        'btnPilihGambar
        '
        Me.btnPilihGambar.Location = New System.Drawing.Point(420, 337)
        Me.btnPilihGambar.Name = "btnPilihGambar"
        Me.btnPilihGambar.Size = New System.Drawing.Size(120, 35)
        Me.btnPilihGambar.TabIndex = 12
        Me.btnPilihGambar.Text = "Pilih Gambar"
        Me.btnPilihGambar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(130, 360)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(120, 40)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan Data"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'tpDaftar
        '
        Me.tpDaftar.Controls.Add(Me.lblSearch)
        Me.tpDaftar.Controls.Add(Me.txtSearch)
        Me.tpDaftar.Controls.Add(Me.dgvParfum)
        Me.tpDaftar.Controls.Add(Me.gbEdit)
        Me.tpDaftar.Location = New System.Drawing.Point(4, 29)
        Me.tpDaftar.Name = "tpDaftar"
        Me.tpDaftar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDaftar.Size = New System.Drawing.Size(792, 739)
        Me.tpDaftar.TabIndex = 1
        Me.tpDaftar.Text = "Daftar & Kelola Parfum"
        Me.tpDaftar.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(20, 20)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(71, 20)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Cari Data"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(100, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 27)
        Me.txtSearch.TabIndex = 1
        '
        'dgvParfum
        '
        Me.dgvParfum.AllowUserToAddRows = False
        Me.dgvParfum.AllowUserToDeleteRows = False
        Me.dgvParfum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvParfum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParfum.Location = New System.Drawing.Point(20, 60)
        Me.dgvParfum.Name = "dgvParfum"
        Me.dgvParfum.ReadOnly = True
        Me.dgvParfum.RowHeadersWidth = 51
        Me.dgvParfum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParfum.Size = New System.Drawing.Size(750, 250)
        Me.dgvParfum.TabIndex = 2
        '
        'gbEdit
        '
        Me.gbEdit.Controls.Add(Me.lblIdEdit)
        Me.gbEdit.Controls.Add(Me.txtIdEdit)
        Me.gbEdit.Controls.Add(Me.lblNamaEdit)
        Me.gbEdit.Controls.Add(Me.txtNamaEdit)
        Me.gbEdit.Controls.Add(Me.lblMerkEdit)
        Me.gbEdit.Controls.Add(Me.txtMerkEdit)
        Me.gbEdit.Controls.Add(Me.lblHargaEdit)
        Me.gbEdit.Controls.Add(Me.numHargaEdit)
        Me.gbEdit.Controls.Add(Me.lblStokEdit)
        Me.gbEdit.Controls.Add(Me.numStokEdit)
        Me.gbEdit.Controls.Add(Me.lblNotesEdit)
        Me.gbEdit.Controls.Add(Me.txtNotesEdit)
        Me.gbEdit.Controls.Add(Me.pbGambarEdit)
        Me.gbEdit.Controls.Add(Me.btnPilihGambarEdit)
        Me.gbEdit.Controls.Add(Me.btnUpdate)
        Me.gbEdit.Controls.Add(Me.btnDelete)
        Me.gbEdit.Location = New System.Drawing.Point(20, 320)
        Me.gbEdit.Name = "gbEdit"
        Me.gbEdit.Size = New System.Drawing.Size(750, 400)
        Me.gbEdit.TabIndex = 3
        Me.gbEdit.TabStop = False
        Me.gbEdit.Text = "Edit / Hapus Data"
        '
        'lblIdEdit
        '
        Me.lblIdEdit.AutoSize = True
        Me.lblIdEdit.Location = New System.Drawing.Point(20, 40)
        Me.lblIdEdit.Name = "lblIdEdit"
        Me.lblIdEdit.Size = New System.Drawing.Size(74, 20)
        Me.lblIdEdit.TabIndex = 0
        Me.lblIdEdit.Text = "ID Parfum"
        '
        'txtIdEdit
        '
        Me.txtIdEdit.Location = New System.Drawing.Point(130, 37)
        Me.txtIdEdit.Name = "txtIdEdit"
        Me.txtIdEdit.ReadOnly = True
        Me.txtIdEdit.Size = New System.Drawing.Size(100, 27)
        Me.txtIdEdit.TabIndex = 1
        '
        'lblNamaEdit
        '
        Me.lblNamaEdit.AutoSize = True
        Me.lblNamaEdit.Location = New System.Drawing.Point(20, 80)
        Me.lblNamaEdit.Name = "lblNamaEdit"
        Me.lblNamaEdit.Size = New System.Drawing.Size(99, 20)
        Me.lblNamaEdit.TabIndex = 2
        Me.lblNamaEdit.Text = "Nama Parfum"
        '
        'txtNamaEdit
        '
        Me.txtNamaEdit.Location = New System.Drawing.Point(130, 77)
        Me.txtNamaEdit.Name = "txtNamaEdit"
        Me.txtNamaEdit.Size = New System.Drawing.Size(250, 27)
        Me.txtNamaEdit.TabIndex = 3
        '
        'lblMerkEdit
        '
        Me.lblMerkEdit.AutoSize = True
        Me.lblMerkEdit.Location = New System.Drawing.Point(20, 120)
        Me.lblMerkEdit.Name = "lblMerkEdit"
        Me.lblMerkEdit.Size = New System.Drawing.Size(42, 20)
        Me.lblMerkEdit.TabIndex = 4
        Me.lblMerkEdit.Text = "Merk"
        '
        'txtMerkEdit
        '
        Me.txtMerkEdit.Location = New System.Drawing.Point(130, 117)
        Me.txtMerkEdit.Name = "txtMerkEdit"
        Me.txtMerkEdit.Size = New System.Drawing.Size(250, 27)
        Me.txtMerkEdit.TabIndex = 5
        '
        'lblHargaEdit
        '
        Me.lblHargaEdit.AutoSize = True
        Me.lblHargaEdit.Location = New System.Drawing.Point(20, 160)
        Me.lblHargaEdit.Name = "lblHargaEdit"
        Me.lblHargaEdit.Size = New System.Drawing.Size(50, 20)
        Me.lblHargaEdit.TabIndex = 6
        Me.lblHargaEdit.Text = "Harga"
        '
        'numHargaEdit
        '
        Me.numHargaEdit.Location = New System.Drawing.Point(130, 158)
        Me.numHargaEdit.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.numHargaEdit.Name = "numHargaEdit"
        Me.numHargaEdit.Size = New System.Drawing.Size(150, 27)
        Me.numHargaEdit.TabIndex = 7
        '
        'lblStokEdit
        '
        Me.lblStokEdit.AutoSize = True
        Me.lblStokEdit.Location = New System.Drawing.Point(20, 200)
        Me.lblStokEdit.Name = "lblStokEdit"
        Me.lblStokEdit.Size = New System.Drawing.Size(38, 20)
        Me.lblStokEdit.TabIndex = 8
        Me.lblStokEdit.Text = "Stok"
        '
        'numStokEdit
        '
        Me.numStokEdit.Location = New System.Drawing.Point(130, 198)
        Me.numStokEdit.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numStokEdit.Name = "numStokEdit"
        Me.numStokEdit.Size = New System.Drawing.Size(100, 27)
        Me.numStokEdit.TabIndex = 9
        '
        'lblNotesEdit
        '
        Me.lblNotesEdit.AutoSize = True
        Me.lblNotesEdit.Location = New System.Drawing.Point(20, 240)
        Me.lblNotesEdit.Name = "lblNotesEdit"
        Me.lblNotesEdit.Size = New System.Drawing.Size(48, 20)
        Me.lblNotesEdit.TabIndex = 10
        Me.lblNotesEdit.Text = "Notes"
        '
        'txtNotesEdit
        '
        Me.txtNotesEdit.Location = New System.Drawing.Point(130, 237)
        Me.txtNotesEdit.Multiline = True
        Me.txtNotesEdit.Name = "txtNotesEdit"
        Me.txtNotesEdit.Size = New System.Drawing.Size(250, 100)
        Me.txtNotesEdit.TabIndex = 11
        '
        'pbGambarEdit
        '
        Me.pbGambarEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbGambarEdit.Location = New System.Drawing.Point(420, 37)
        Me.pbGambarEdit.Name = "pbGambarEdit"
        Me.pbGambarEdit.Size = New System.Drawing.Size(200, 200)
        Me.pbGambarEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGambarEdit.TabIndex = 12
        Me.pbGambarEdit.TabStop = False
        '
        'btnPilihGambarEdit
        '
        Me.btnPilihGambarEdit.Location = New System.Drawing.Point(420, 250)
        Me.btnPilihGambarEdit.Name = "btnPilihGambarEdit"
        Me.btnPilihGambarEdit.Size = New System.Drawing.Size(120, 35)
        Me.btnPilihGambarEdit.TabIndex = 15
        Me.btnPilihGambarEdit.Text = "Ubah Gambar"
        Me.btnPilihGambarEdit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(640, 250)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 40)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(640, 300)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 40)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 800)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Manajemen Toko Parfum"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpTambah.ResumeLayout(False)
        Me.tpTambah.PerformLayout()
        CType(Me.numHargaBaru, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStokBaru, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGambarBaru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDaftar.ResumeLayout(False)
        Me.tpDaftar.PerformLayout()
        CType(Me.dgvParfum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEdit.ResumeLayout(False)
        Me.gbEdit.PerformLayout()
        CType(Me.numHargaEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStokEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGambarEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpTambah As System.Windows.Forms.TabPage
    Friend WithEvents lblTitleTambah As System.Windows.Forms.Label
    Friend WithEvents lblNamaBaru As System.Windows.Forms.Label
    Friend WithEvents txtNamaBaru As System.Windows.Forms.TextBox
    Friend WithEvents lblMerkBaru As System.Windows.Forms.Label
    Friend WithEvents txtMerkBaru As System.Windows.Forms.TextBox
    Friend WithEvents lblHargaBaru As System.Windows.Forms.Label
    Friend WithEvents numHargaBaru As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStokBaru As System.Windows.Forms.Label
    Friend WithEvents numStokBaru As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNotesBaru As System.Windows.Forms.Label
    Friend WithEvents txtNotesBaru As System.Windows.Forms.TextBox
    Friend WithEvents pbGambarBaru As System.Windows.Forms.PictureBox
    Friend WithEvents btnPilihGambar As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents tpDaftar As System.Windows.Forms.TabPage
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvParfum As System.Windows.Forms.DataGridView
    Friend WithEvents gbEdit As System.Windows.Forms.GroupBox
    Friend WithEvents lblIdEdit As System.Windows.Forms.Label
    Friend WithEvents txtIdEdit As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaEdit As System.Windows.Forms.Label
    Friend WithEvents txtNamaEdit As System.Windows.Forms.TextBox
    Friend WithEvents lblMerkEdit As System.Windows.Forms.Label
    Friend WithEvents txtMerkEdit As System.Windows.Forms.TextBox
    Friend WithEvents lblHargaEdit As System.Windows.Forms.Label
    Friend WithEvents numHargaEdit As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStokEdit As System.Windows.Forms.Label
    Friend WithEvents numStokEdit As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNotesEdit As System.Windows.Forms.Label
    Friend WithEvents txtNotesEdit As System.Windows.Forms.TextBox
    Friend WithEvents pbGambarEdit As System.Windows.Forms.PictureBox
    Friend WithEvents btnPilihGambarEdit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class