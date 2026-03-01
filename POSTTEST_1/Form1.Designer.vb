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
        btnTambah = New Button()
        btnReset = New Button()
        lblIps = New Label()
        lblIpk = New Label()
        txtIps = New TextBox()
        lblPredikat = New Label()
        lblHeader = New Label()
        labelIPK = New Label()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(424, 217)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(535, 217)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 1
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblIps
        ' 
        lblIps.AutoSize = True
        lblIps.Location = New Point(97, 170)
        lblIps.Name = "lblIps"
        lblIps.Size = New Size(247, 25)
        lblIps.TabIndex = 2
        lblIps.Text = "Indeks Prestasi Semester (IPS)"
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Location = New Point(97, 281)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(249, 25)
        lblIpk.TabIndex = 3
        lblIpk.Text = "Indeks Prestasi Kumulatif (IPK)"
        ' 
        ' txtIps
        ' 
        txtIps.Location = New Point(424, 170)
        txtIps.Name = "txtIps"
        txtIps.Size = New Size(205, 31)
        txtIps.TabIndex = 4
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(419, 340)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(19, 25)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = "-"
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.Location = New Point(97, 29)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(611, 38)
        lblHeader.TabIndex = 7
        lblHeader.Text = "SISTEM AKADEMIK MUGIWARA UNIVERSITY"
        ' 
        ' labelIPK
        ' 
        labelIPK.AutoSize = True
        labelIPK.Location = New Point(419, 289)
        labelIPK.Name = "labelIPK"
        labelIPK.Size = New Size(22, 25)
        labelIPK.TabIndex = 8
        labelIPK.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(labelIPK)
        Controls.Add(lblHeader)
        Controls.Add(lblPredikat)
        Controls.Add(txtIps)
        Controls.Add(lblIpk)
        Controls.Add(lblIps)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Name = "Form1"
        Text = "Sistem Akademik Mugiwara University"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblIps As Label
    Friend WithEvents lblIpk As Label
    Friend WithEvents txtIps As TextBox
    Friend WithEvents lblPredikat As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents labelIPK As Label

End Class
