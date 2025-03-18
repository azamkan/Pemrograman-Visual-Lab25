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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        rb_laki = New RadioButton()
        rb_pr = New RadioButton()
        gb_jk = New GroupBox()
        cb_belajar = New CheckBox()
        cb_maingame = New CheckBox()
        cb_jalan = New CheckBox()
        cb_mancing = New CheckBox()
        cb_buku = New CheckBox()
        cb_coding = New CheckBox()
        gb_hobi = New GroupBox()
        tb_nama = New TextBox()
        tb_nim = New TextBox()
        dtp_lahir = New DateTimePicker()
        PictureBox1 = New PictureBox()
        btn_gambar = New Button()
        btn_simpan = New Button()
        gb_jk.SuspendLayout()
        gb_hobi.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(258, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(258, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 20)
        Label2.TabIndex = 1
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(258, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 2
        Label3.Text = "Tanggal Lahir"
        ' 
        ' rb_laki
        ' 
        rb_laki.AutoSize = True
        rb_laki.Location = New Point(25, 38)
        rb_laki.Name = "rb_laki"
        rb_laki.Size = New Size(96, 24)
        rb_laki.TabIndex = 3
        rb_laki.TabStop = True
        rb_laki.Text = "Laki - Laki"
        rb_laki.UseVisualStyleBackColor = True
        ' 
        ' rb_pr
        ' 
        rb_pr.AutoSize = True
        rb_pr.Location = New Point(230, 38)
        rb_pr.Name = "rb_pr"
        rb_pr.Size = New Size(104, 24)
        rb_pr.TabIndex = 4
        rb_pr.TabStop = True
        rb_pr.Text = "Perempuan"
        rb_pr.UseVisualStyleBackColor = True
        ' 
        ' gb_jk
        ' 
        gb_jk.Controls.Add(rb_laki)
        gb_jk.Controls.Add(rb_pr)
        gb_jk.Location = New Point(258, 169)
        gb_jk.Name = "gb_jk"
        gb_jk.Size = New Size(492, 86)
        gb_jk.TabIndex = 5
        gb_jk.TabStop = False
        gb_jk.Text = "Jenis Kelamin"
        ' 
        ' cb_belajar
        ' 
        cb_belajar.AutoSize = True
        cb_belajar.Location = New Point(25, 40)
        cb_belajar.Name = "cb_belajar"
        cb_belajar.Size = New Size(77, 24)
        cb_belajar.TabIndex = 6
        cb_belajar.Text = "Belajar"
        cb_belajar.UseVisualStyleBackColor = True
        ' 
        ' cb_maingame
        ' 
        cb_maingame.AutoSize = True
        cb_maingame.Location = New Point(25, 80)
        cb_maingame.Name = "cb_maingame"
        cb_maingame.Size = New Size(107, 24)
        cb_maingame.TabIndex = 7
        cb_maingame.Text = "Main Game"
        cb_maingame.UseVisualStyleBackColor = True
        ' 
        ' cb_jalan
        ' 
        cb_jalan.AutoSize = True
        cb_jalan.Location = New Point(181, 40)
        cb_jalan.Name = "cb_jalan"
        cb_jalan.Size = New Size(111, 24)
        cb_jalan.TabIndex = 8
        cb_jalan.Text = "Jalan - Jalan"
        cb_jalan.UseVisualStyleBackColor = True
        ' 
        ' cb_mancing
        ' 
        cb_mancing.AutoSize = True
        cb_mancing.Location = New Point(181, 80)
        cb_mancing.Name = "cb_mancing"
        cb_mancing.Size = New Size(88, 24)
        cb_mancing.TabIndex = 9
        cb_mancing.Text = "Mancing"
        cb_mancing.UseVisualStyleBackColor = True
        ' 
        ' cb_buku
        ' 
        cb_buku.AutoSize = True
        cb_buku.Location = New Point(342, 40)
        cb_buku.Name = "cb_buku"
        cb_buku.Size = New Size(99, 24)
        cb_buku.TabIndex = 10
        cb_buku.Text = "Baca Buku"
        cb_buku.UseVisualStyleBackColor = True
        ' 
        ' cb_coding
        ' 
        cb_coding.AutoSize = True
        cb_coding.Location = New Point(342, 80)
        cb_coding.Name = "cb_coding"
        cb_coding.Size = New Size(79, 24)
        cb_coding.TabIndex = 11
        cb_coding.Text = "Coding"
        cb_coding.UseVisualStyleBackColor = True
        ' 
        ' gb_hobi
        ' 
        gb_hobi.Controls.Add(cb_belajar)
        gb_hobi.Controls.Add(cb_coding)
        gb_hobi.Controls.Add(cb_maingame)
        gb_hobi.Controls.Add(cb_buku)
        gb_hobi.Controls.Add(cb_jalan)
        gb_hobi.Controls.Add(cb_mancing)
        gb_hobi.Location = New Point(258, 283)
        gb_hobi.Name = "gb_hobi"
        gb_hobi.Size = New Size(492, 125)
        gb_hobi.TabIndex = 12
        gb_hobi.TabStop = False
        gb_hobi.Text = "Hobi"
        ' 
        ' tb_nama
        ' 
        tb_nama.Location = New Point(381, 40)
        tb_nama.Name = "tb_nama"
        tb_nama.Size = New Size(369, 27)
        tb_nama.TabIndex = 13
        ' 
        ' tb_nim
        ' 
        tb_nim.Location = New Point(381, 82)
        tb_nim.Name = "tb_nim"
        tb_nim.Size = New Size(369, 27)
        tb_nim.TabIndex = 14
        ' 
        ' dtp_lahir
        ' 
        dtp_lahir.Location = New Point(381, 124)
        dtp_lahir.Name = "dtp_lahir"
        dtp_lahir.Size = New Size(369, 27)
        dtp_lahir.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(25, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 248)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' btn_gambar
        ' 
        btn_gambar.Location = New Point(75, 318)
        btn_gambar.Name = "btn_gambar"
        btn_gambar.Size = New Size(116, 29)
        btn_gambar.TabIndex = 17
        btn_gambar.Text = "Pilih Gambar"
        btn_gambar.UseVisualStyleBackColor = True
        ' 
        ' btn_simpan
        ' 
        btn_simpan.Location = New Point(75, 366)
        btn_simpan.Name = "btn_simpan"
        btn_simpan.Size = New Size(116, 29)
        btn_simpan.TabIndex = 18
        btn_simpan.Text = "Simpan"
        btn_simpan.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_simpan)
        Controls.Add(btn_gambar)
        Controls.Add(PictureBox1)
        Controls.Add(dtp_lahir)
        Controls.Add(tb_nim)
        Controls.Add(tb_nama)
        Controls.Add(gb_hobi)
        Controls.Add(gb_jk)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        gb_jk.ResumeLayout(False)
        gb_jk.PerformLayout()
        gb_hobi.ResumeLayout(False)
        gb_hobi.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rb_laki As RadioButton
    Friend WithEvents rb_pr As RadioButton
    Friend WithEvents gb_jk As GroupBox
    Friend WithEvents cb_belajar As CheckBox
    Friend WithEvents cb_maingame As CheckBox
    Friend WithEvents cb_jalan As CheckBox
    Friend WithEvents cb_mancing As CheckBox
    Friend WithEvents cb_buku As CheckBox
    Friend WithEvents cb_coding As CheckBox
    Friend WithEvents gb_hobi As GroupBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents tb_nim As TextBox
    Friend WithEvents dtp_lahir As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_gambar As Button
    Friend WithEvents btn_simpan As Button

End Class
