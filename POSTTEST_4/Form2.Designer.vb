<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pbFotoKartu = New PictureBox()
        lblNamaKartu = New Label()
        lblIDKartu = New Label()
        lblDivisiKartu = New Label()
        lblKontakKartu = New Label()
        lblAktivitasKartu = New Label()
        lblAlamatKartu = New Label()
        PictureBox1 = New PictureBox()
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoKartu
        ' 
        pbFotoKartu.Location = New Point(12, 84)
        pbFotoKartu.Name = "pbFotoKartu"
        pbFotoKartu.Size = New Size(180, 200)
        pbFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoKartu.TabIndex = 0
        pbFotoKartu.TabStop = False
        ' 
        ' lblNamaKartu
        ' 
        lblNamaKartu.AutoSize = True
        lblNamaKartu.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaKartu.Location = New Point(209, 84)
        lblNamaKartu.Name = "lblNamaKartu"
        lblNamaKartu.Size = New Size(80, 28)
        lblNamaKartu.TabIndex = 1
        lblNamaKartu.Text = "Label1"
        ' 
        ' lblIDKartu
        ' 
        lblIDKartu.AutoSize = True
        lblIDKartu.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIDKartu.Location = New Point(209, 124)
        lblIDKartu.Name = "lblIDKartu"
        lblIDKartu.Size = New Size(80, 28)
        lblIDKartu.TabIndex = 2
        lblIDKartu.Text = "Label1"
        ' 
        ' lblDivisiKartu
        ' 
        lblDivisiKartu.AutoSize = True
        lblDivisiKartu.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDivisiKartu.Location = New Point(209, 165)
        lblDivisiKartu.Name = "lblDivisiKartu"
        lblDivisiKartu.Size = New Size(80, 28)
        lblDivisiKartu.TabIndex = 3
        lblDivisiKartu.Text = "Label1"
        ' 
        ' lblKontakKartu
        ' 
        lblKontakKartu.AutoSize = True
        lblKontakKartu.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKontakKartu.Location = New Point(209, 206)
        lblKontakKartu.Name = "lblKontakKartu"
        lblKontakKartu.Size = New Size(80, 28)
        lblKontakKartu.TabIndex = 4
        lblKontakKartu.Text = "Label1"
        ' 
        ' lblAktivitasKartu
        ' 
        lblAktivitasKartu.AutoSize = True
        lblAktivitasKartu.BackColor = Color.LightSkyBlue
        lblAktivitasKartu.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAktivitasKartu.Location = New Point(12, 300)
        lblAktivitasKartu.MaximumSize = New Size(550, 0)
        lblAktivitasKartu.Name = "lblAktivitasKartu"
        lblAktivitasKartu.Size = New Size(80, 28)
        lblAktivitasKartu.TabIndex = 5
        lblAktivitasKartu.Text = "Label1"
        ' 
        ' lblAlamatKartu
        ' 
        lblAlamatKartu.AutoSize = True
        lblAlamatKartu.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamatKartu.Location = New Point(12, 377)
        lblAlamatKartu.MaximumSize = New Size(550, 0)
        lblAlamatKartu.Name = "lblAlamatKartu"
        lblAlamatKartu.Size = New Size(80, 28)
        lblAlamatKartu.TabIndex = 6
        lblAlamatKartu.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources._31eb2347_0b65_4792_9d92_8fe1bcb278cb
        PictureBox1.Location = New Point(146, -11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(324, 92)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        BackgroundImage = My.Resources.Resources.download__6_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(614, 469)
        Controls.Add(PictureBox1)
        Controls.Add(lblAlamatKartu)
        Controls.Add(lblAktivitasKartu)
        Controls.Add(lblKontakKartu)
        Controls.Add(lblDivisiKartu)
        Controls.Add(lblIDKartu)
        Controls.Add(lblNamaKartu)
        Controls.Add(pbFotoKartu)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pixel Community"
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoKartu As PictureBox
    Friend WithEvents lblNamaKartu As Label
    Friend WithEvents lblIDKartu As Label
    Friend WithEvents lblDivisiKartu As Label
    Friend WithEvents lblKontakKartu As Label
    Friend WithEvents lblAktivitasKartu As Label
    Friend WithEvents lblAlamatKartu As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
