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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        lblJudul = New Label()
        pbLogo = New PictureBox()
        lblJudull = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label1 = New Label()
        cbRole = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        lblGender = New Label()
        DateTimePicker1 = New DateTimePicker()
        lblTgl = New Label()
        txtID = New TextBox()
        lblId = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        lblAlamat = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        mtbTelepon = New MaskedTextBox()
        lblNoTelp = New Label()
        TabPage3 = New TabPage()
        btnSimpan = New Button()
        gbAktivitas = New GroupBox()
        cbRacing = New CheckBox()
        cbFishing = New CheckBox()
        cbNether = New CheckBox()
        cbFarming = New CheckBox()
        cbPVP = New CheckBox()
        cbTrading = New CheckBox()
        cbBuilding = New CheckBox()
        cbMining = New CheckBox()
        GroupBox1 = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbFoto = New PictureBox()
        ofdFoto = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbAktivitas.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(860, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(110, 29)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(109, 29)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(128, 29)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(106, 29)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(74, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("News706 BT", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.FromArgb(CByte(20), CByte(201), CByte(24))
        lblJudul.Location = New Point(72, 58)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(140, 27)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Community"
        ' 
        ' pbLogo
        ' 
        pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), Image)
        pbLogo.Location = New Point(0, 30)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(65, 52)
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pbLogo.TabIndex = 2
        pbLogo.TabStop = False
        ' 
        ' lblJudull
        ' 
        lblJudull.AutoSize = True
        lblJudull.Font = New Font("News706 BT", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblJudull.ForeColor = Color.Black
        lblJudull.Location = New Point(72, 30)
        lblJudull.Name = "lblJudull"
        lblJudull.Size = New Size(142, 27)
        lblJudull.TabIndex = 3
        lblJudull.Text = "Pixel World"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(13, 88)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(834, 383)
        TabControl1.TabIndex = 4
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(cbRole)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(lblGender)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(lblTgl)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(lblId)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(lblNama)
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(826, 347)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(20), CByte(201), CByte(24))
        Label1.Location = New Point(24, 218)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 23)
        Label1.TabIndex = 10
        Label1.Text = "Role"
        ' 
        ' cbRole
        ' 
        cbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"Builder", "Trader", "Fisher", "Nether", "Miner", "Content Creator"})
        cbRole.Location = New Point(189, 210)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(202, 31)
        cbRole.TabIndex = 9
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(334, 160)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(130, 27)
        rbPerempuan.TabIndex = 8
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(189, 160)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(130, 27)
        rbLaki.TabIndex = 7
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.ForeColor = Color.FromArgb(CByte(20), CByte(201), CByte(24))
        lblGender.Location = New Point(24, 164)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(153, 23)
        lblGender.TabIndex = 6
        lblGender.Text = "Jenis Kelamin"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(189, 114)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(275, 31)
        DateTimePicker1.TabIndex = 5
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.ForeColor = Color.FromArgb(CByte(20), CByte(201), CByte(24))
        lblTgl.Location = New Point(24, 122)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(109, 23)
        lblTgl.TabIndex = 4
        lblTgl.Text = "Tgl Lahir"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(189, 71)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID Anggota"
        txtID.Size = New Size(244, 31)
        txtID.TabIndex = 3
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.ForeColor = Color.FromArgb(CByte(20), CByte(201), CByte(24))
        lblId.Location = New Point(24, 79)
        lblId.Name = "lblId"
        lblId.Size = New Size(120, 23)
        lblId.TabIndex = 2
        lblId.Text = "ID Anggota"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(189, 32)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(244, 31)
        txtNama.TabIndex = 1
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.ForeColor = Color.FromArgb(CByte(20), CByte(201), CByte(24))
        lblNama.Location = New Point(24, 35)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(54, 23)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(lblAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(lblEmail)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Controls.Add(lblNoTelp)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(826, 345)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(183, 159)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Jalan...."
        txtAlamat.Size = New Size(378, 163)
        txtAlamat.TabIndex = 5
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(36, 159)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(76, 23)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(183, 102)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "contoh@gmail.com"
        txtEmail.Size = New Size(183, 31)
        txtEmail.TabIndex = 3
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(36, 105)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(65, 23)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(183, 44)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(183, 31)
        mtbTelepon.TabIndex = 1
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Location = New Point(36, 52)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(87, 23)
        lblNoTelp.TabIndex = 0
        lblNoTelp.Text = "No Telp"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(gbAktivitas)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbFoto)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(826, 345)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(20), CByte(201), CByte(24))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(535, 236)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(268, 29)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan dan Cetak Kartu"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' gbAktivitas
        ' 
        gbAktivitas.Controls.Add(cbRacing)
        gbAktivitas.Controls.Add(cbFishing)
        gbAktivitas.Controls.Add(cbNether)
        gbAktivitas.Controls.Add(cbFarming)
        gbAktivitas.Controls.Add(cbPVP)
        gbAktivitas.Controls.Add(cbTrading)
        gbAktivitas.Controls.Add(cbBuilding)
        gbAktivitas.Controls.Add(cbMining)
        gbAktivitas.Location = New Point(227, 93)
        gbAktivitas.Name = "gbAktivitas"
        gbAktivitas.Size = New Size(576, 125)
        gbAktivitas.TabIndex = 3
        gbAktivitas.TabStop = False
        gbAktivitas.Text = "Aktivitas Favorit"
        ' 
        ' cbRacing
        ' 
        cbRacing.AutoSize = True
        cbRacing.Location = New Point(380, 65)
        cbRacing.Name = "cbRacing"
        cbRacing.Size = New Size(120, 27)
        cbRacing.TabIndex = 7
        cbRacing.Text = "Jet Race"
        cbRacing.UseVisualStyleBackColor = True
        ' 
        ' cbFishing
        ' 
        cbFishing.AutoSize = True
        cbFishing.Location = New Point(380, 32)
        cbFishing.Name = "cbFishing"
        cbFishing.Size = New Size(109, 27)
        cbFishing.TabIndex = 6
        cbFishing.Text = "Fishing"
        cbFishing.UseVisualStyleBackColor = True
        ' 
        ' cbNether
        ' 
        cbNether.AutoSize = True
        cbNether.Location = New Point(265, 65)
        cbNether.Name = "cbNether"
        cbNether.Size = New Size(98, 27)
        cbNether.TabIndex = 5
        cbNether.Text = "Nether"
        cbNether.UseVisualStyleBackColor = True
        ' 
        ' cbFarming
        ' 
        cbFarming.AutoSize = True
        cbFarming.Location = New Point(265, 32)
        cbFarming.Name = "cbFarming"
        cbFarming.Size = New Size(109, 27)
        cbFarming.TabIndex = 4
        cbFarming.Text = "Farming"
        cbFarming.UseVisualStyleBackColor = True
        ' 
        ' cbPVP
        ' 
        cbPVP.AutoSize = True
        cbPVP.Location = New Point(141, 65)
        cbPVP.Name = "cbPVP"
        cbPVP.Size = New Size(65, 27)
        cbPVP.TabIndex = 3
        cbPVP.Text = "PVP"
        cbPVP.UseVisualStyleBackColor = True
        ' 
        ' cbTrading
        ' 
        cbTrading.AutoSize = True
        cbTrading.Location = New Point(141, 32)
        cbTrading.Name = "cbTrading"
        cbTrading.Size = New Size(109, 27)
        cbTrading.TabIndex = 2
        cbTrading.Text = "Trading"
        cbTrading.UseVisualStyleBackColor = True
        ' 
        ' cbBuilding
        ' 
        cbBuilding.AutoSize = True
        cbBuilding.Location = New Point(15, 65)
        cbBuilding.Name = "cbBuilding"
        cbBuilding.Size = New Size(120, 27)
        cbBuilding.TabIndex = 1
        cbBuilding.Text = "Building"
        cbBuilding.UseVisualStyleBackColor = True
        ' 
        ' cbMining
        ' 
        cbMining.AutoSize = True
        cbMining.Location = New Point(15, 32)
        cbMining.Name = "cbMining"
        cbMining.Size = New Size(98, 27)
        cbMining.TabIndex = 0
        cbMining.Text = "Mining"
        cbMining.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbAdmin)
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbKetua)
        GroupBox1.Location = New Point(227, 18)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(313, 69)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pilihan Peran"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(224, 30)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(86, 27)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(110, 30)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(108, 27)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(18, 30)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(86, 27)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(CByte(20), CByte(201), CByte(24))
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(55, 236)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(138, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Cari Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' pbFoto
        ' 
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(13, 18)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(180, 200)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' ofdFoto
        ' 
        ofdFoto.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(860, 509)
        Controls.Add(TabControl1)
        Controls.Add(lblJudull)
        Controls.Add(pbLogo)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip1)
        Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(20), CByte(201), CByte(24))
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pixel World Community Card Maker"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbAktivitas.ResumeLayout(False)
        gbAktivitas.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblJudul As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblJudull As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblTgl As Label
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents lblGender As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents gbAktivitas As GroupBox
    Friend WithEvents cbFarming As CheckBox
    Friend WithEvents cbPVP As CheckBox
    Friend WithEvents cbTrading As CheckBox
    Friend WithEvents cbBuilding As CheckBox
    Friend WithEvents cbMining As CheckBox
    Friend WithEvents cbRacing As CheckBox
    Friend WithEvents cbFishing As CheckBox
    Friend WithEvents cbNether As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
