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
        picHasil = New PictureBox()
        lblNamaHasil = New Label()
        lblUmurHasil = New Label()
        lblTglHasil = New Label()
        lblNoTelpHasil = New Label()
        lblAlamatHasil = New Label()
        lblGenderHasil = New Label()
        lblHobiHasil = New Label()
        CType(picHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picHasil
        ' 
        picHasil.BorderStyle = BorderStyle.FixedSingle
        picHasil.Location = New Point(25, 76)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(225, 303)
        picHasil.SizeMode = PictureBoxSizeMode.StretchImage
        picHasil.TabIndex = 16
        picHasil.TabStop = False
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.AutoSize = True
        lblNamaHasil.Location = New Point(389, 148)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(31, 25)
        lblNamaHasil.TabIndex = 17
        lblNamaHasil.Text = "lbl"
        ' 
        ' lblUmurHasil
        ' 
        lblUmurHasil.AutoSize = True
        lblUmurHasil.Location = New Point(389, 182)
        lblUmurHasil.Name = "lblUmurHasil"
        lblUmurHasil.Size = New Size(113, 25)
        lblUmurHasil.TabIndex = 18
        lblUmurHasil.Text = "lblUmurHasil"
        ' 
        ' lblTglHasil
        ' 
        lblTglHasil.AutoSize = True
        lblTglHasil.Location = New Point(389, 218)
        lblTglHasil.Name = "lblTglHasil"
        lblTglHasil.Size = New Size(63, 25)
        lblTglHasil.TabIndex = 19
        lblTglHasil.Text = "Label2"
        ' 
        ' lblNoTelpHasil
        ' 
        lblNoTelpHasil.AutoSize = True
        lblNoTelpHasil.Location = New Point(389, 254)
        lblNoTelpHasil.Name = "lblNoTelpHasil"
        lblNoTelpHasil.Size = New Size(63, 25)
        lblNoTelpHasil.TabIndex = 20
        lblNoTelpHasil.Text = "Label2"
        ' 
        ' lblAlamatHasil
        ' 
        lblAlamatHasil.AutoSize = True
        lblAlamatHasil.Location = New Point(389, 285)
        lblAlamatHasil.Name = "lblAlamatHasil"
        lblAlamatHasil.Size = New Size(63, 25)
        lblAlamatHasil.TabIndex = 21
        lblAlamatHasil.Text = "Label3"
        ' 
        ' lblGenderHasil
        ' 
        lblGenderHasil.AutoSize = True
        lblGenderHasil.Location = New Point(389, 318)
        lblGenderHasil.Name = "lblGenderHasil"
        lblGenderHasil.Size = New Size(63, 25)
        lblGenderHasil.TabIndex = 22
        lblGenderHasil.Text = "Label4"
        ' 
        ' lblHobiHasil
        ' 
        lblHobiHasil.AutoSize = True
        lblHobiHasil.Location = New Point(389, 350)
        lblHobiHasil.Name = "lblHobiHasil"
        lblHobiHasil.Size = New Size(63, 25)
        lblHobiHasil.TabIndex = 23
        lblHobiHasil.Text = "Label5"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Desain_tanpa_judul__1_
        ClientSize = New Size(732, 453)
        Controls.Add(lblHobiHasil)
        Controls.Add(lblGenderHasil)
        Controls.Add(lblAlamatHasil)
        Controls.Add(lblNoTelpHasil)
        Controls.Add(lblTglHasil)
        Controls.Add(lblUmurHasil)
        Controls.Add(lblNamaHasil)
        Controls.Add(picHasil)
        Name = "Form2"
        Text = "ITZY Identification Card"
        CType(picHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picHasil As PictureBox
    Public WithEvents lblNamaHasil As Label
    Public WithEvents lblUmurHasil As Label
    Public WithEvents lblTglHasil As Label
    Public WithEvents lblNoTelpHasil As Label
    Public WithEvents lblAlamatHasil As Label
    Public WithEvents lblGenderHasil As Label
    Public WithEvents lblHobiHasil As Label
    Friend WithEvents lblHobi As Label
End Class
