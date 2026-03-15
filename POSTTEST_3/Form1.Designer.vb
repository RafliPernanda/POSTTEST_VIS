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
        picProfile = New PictureBox()
        btnBrowse = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblNoTelp = New Label()
        lblAlamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelp = New TextBox()
        txtAlamat = New TextBox()
        lblTglLahir = New Label()
        dtpTanggal = New DateTimePicker()
        btnCetak = New Button()
        gbGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobby = New GroupBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        gbGender.SuspendLayout()
        gbHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfile
        ' 
        picProfile.BorderStyle = BorderStyle.FixedSingle
        picProfile.Location = New Point(12, 56)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(225, 303)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(142, 365)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 27)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Location = New Point(242, 56)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(53, 23)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Location = New Point(242, 101)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(53, 23)
        lblUmur.TabIndex = 3
        lblUmur.Text = "Umur"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.BackColor = Color.Transparent
        lblNoTelp.Location = New Point(242, 184)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(76, 23)
        lblNoTelp.TabIndex = 4
        lblNoTelp.Text = "No. Telp"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Location = New Point(242, 226)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(65, 23)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(382, 56)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(324, 28)
        txtNama.TabIndex = 6
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(382, 101)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(74, 28)
        txtUmur.TabIndex = 7
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(382, 184)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(324, 28)
        txtNoTelp.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(382, 226)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(324, 29)
        txtAlamat.TabIndex = 9
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.BackColor = Color.Transparent
        lblTglLahir.Location = New Point(242, 144)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(114, 23)
        lblTglLahir.TabIndex = 10
        lblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(382, 144)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(324, 28)
        dtpTanggal.TabIndex = 11
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.RoyalBlue
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(242, 456)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(464, 27)
        btnCetak.TabIndex = 12
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' gbGender
        ' 
        gbGender.Controls.Add(rbPerempuan)
        gbGender.Controls.Add(rbLaki)
        gbGender.Location = New Point(242, 292)
        gbGender.Name = "gbGender"
        gbGender.Size = New Size(186, 99)
        gbGender.TabIndex = 13
        gbGender.TabStop = False
        gbGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(6, 60)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(120, 27)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(6, 28)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(112, 27)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(CheckBox10)
        gbHobby.Controls.Add(CheckBox9)
        gbHobby.Controls.Add(CheckBox8)
        gbHobby.Controls.Add(CheckBox7)
        gbHobby.Controls.Add(CheckBox6)
        gbHobby.Controls.Add(CheckBox5)
        gbHobby.Controls.Add(CheckBox4)
        gbHobby.Controls.Add(CheckBox3)
        gbHobby.Controls.Add(CheckBox2)
        gbHobby.Controls.Add(CheckBox1)
        gbHobby.Location = New Point(434, 292)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(272, 159)
        gbHobby.TabIndex = 14
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(131, 118)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(107, 27)
        CheckBox10.TabIndex = 9
        CheckBox10.Text = "Menyanyi"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(131, 97)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(86, 27)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "Menari"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(131, 73)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(91, 27)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Melukis"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(131, 49)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(105, 27)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Fotografi"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(131, 28)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(102, 27)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Olahraga"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(10, 118)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(104, 27)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Traveling"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(10, 97)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(106, 27)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Membaca"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(10, 73)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(97, 27)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Mancing"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(10, 49)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(87, 27)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Coding"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(10, 25)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(91, 27)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Gaming"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(832, 509)
        Controls.Add(gbHobby)
        Controls.Add(gbGender)
        Controls.Add(btnCetak)
        Controls.Add(dtpTanggal)
        Controls.Add(lblTglLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblAlamat)
        Controls.Add(lblNoTelp)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(btnBrowse)
        Controls.Add(picProfile)
        Font = New Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ITZY Identification Card Maker"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        gbGender.ResumeLayout(False)
        gbGender.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents btnCetak As Button
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox

End Class
