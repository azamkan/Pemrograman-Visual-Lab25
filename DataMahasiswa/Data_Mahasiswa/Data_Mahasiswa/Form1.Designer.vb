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
        RBLaki = New RadioButton()
        RBPR = New RadioButton()
        GBJK = New GroupBox()
        CBbelajar = New CheckBox()
        CBmaingame = New CheckBox()
        CBjalan = New CheckBox()
        CBmancing = New CheckBox()
        CBbuku = New CheckBox()
        CBcoding = New CheckBox()
        GBHobi = New GroupBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        PictureBox1 = New PictureBox()
        btn_gambar = New Button()
        btn_simpan = New Button()
        GBJK.SuspendLayout()
        GBHobi.SuspendLayout()
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
        ' RBLaki
        ' 
        RBLaki.AutoSize = True
        RBLaki.Location = New Point(25, 38)
        RBLaki.Name = "RBLaki"
        RBLaki.Size = New Size(96, 24)
        RBLaki.TabIndex = 3
        RBLaki.TabStop = True
        RBLaki.Text = "Laki - Laki"
        RBLaki.UseVisualStyleBackColor = True
        ' 
        ' RBPR
        ' 
        RBPR.AutoSize = True
        RBPR.Location = New Point(230, 38)
        RBPR.Name = "RBPR"
        RBPR.Size = New Size(104, 24)
        RBPR.TabIndex = 4
        RBPR.TabStop = True
        RBPR.Text = "Perempuan"
        RBPR.UseVisualStyleBackColor = True
        ' 
        ' GBJK
        ' 
        GBJK.Controls.Add(RBLaki)
        GBJK.Controls.Add(RBPR)
        GBJK.Location = New Point(258, 169)
        GBJK.Name = "GBJK"
        GBJK.Size = New Size(492, 86)
        GBJK.TabIndex = 5
        GBJK.TabStop = False
        GBJK.Text = "Jenis Kelamin"
        ' 
        ' CBbelajar
        ' 
        CBbelajar.AutoSize = True
        CBbelajar.Location = New Point(25, 40)
        CBbelajar.Name = "CBbelajar"
        CBbelajar.Size = New Size(77, 24)
        CBbelajar.TabIndex = 6
        CBbelajar.Text = "Belajar"
        CBbelajar.UseVisualStyleBackColor = True
        ' 
        ' CBmaingame
        ' 
        CBmaingame.AutoSize = True
        CBmaingame.Location = New Point(25, 80)
        CBmaingame.Name = "CBmaingame"
        CBmaingame.Size = New Size(107, 24)
        CBmaingame.TabIndex = 7
        CBmaingame.Text = "Main Game"
        CBmaingame.UseVisualStyleBackColor = True
        ' 
        ' CBjalan
        ' 
        CBjalan.AutoSize = True
        CBjalan.Location = New Point(181, 40)
        CBjalan.Name = "CBjalan"
        CBjalan.Size = New Size(111, 24)
        CBjalan.TabIndex = 8
        CBjalan.Text = "Jalan - Jalan"
        CBjalan.UseVisualStyleBackColor = True
        ' 
        ' CBmancing
        ' 
        CBmancing.AutoSize = True
        CBmancing.Location = New Point(181, 80)
        CBmancing.Name = "CBmancing"
        CBmancing.Size = New Size(88, 24)
        CBmancing.TabIndex = 9
        CBmancing.Text = "Mancing"
        CBmancing.UseVisualStyleBackColor = True
        ' 
        ' CBbuku
        ' 
        CBbuku.AutoSize = True
        CBbuku.Location = New Point(342, 40)
        CBbuku.Name = "CBbuku"
        CBbuku.Size = New Size(99, 24)
        CBbuku.TabIndex = 10
        CBbuku.Text = "Baca Buku"
        CBbuku.UseVisualStyleBackColor = True
        ' 
        ' CBcoding
        ' 
        CBcoding.AutoSize = True
        CBcoding.Location = New Point(342, 80)
        CBcoding.Name = "CBcoding"
        CBcoding.Size = New Size(79, 24)
        CBcoding.TabIndex = 11
        CBcoding.Text = "Coding"
        CBcoding.UseVisualStyleBackColor = True
        ' 
        ' GBHobi
        ' 
        GBHobi.Controls.Add(CBbelajar)
        GBHobi.Controls.Add(CBcoding)
        GBHobi.Controls.Add(CBmaingame)
        GBHobi.Controls.Add(CBbuku)
        GBHobi.Controls.Add(CBjalan)
        GBHobi.Controls.Add(CBmancing)
        GBHobi.Location = New Point(258, 283)
        GBHobi.Name = "GBHobi"
        GBHobi.Size = New Size(492, 125)
        GBHobi.TabIndex = 12
        GBHobi.TabStop = False
        GBHobi.Text = "Hobi"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(381, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(369, 27)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(381, 82)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(369, 27)
        TextBox2.TabIndex = 14
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(381, 124)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(369, 27)
        DateTimePicker1.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(25, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 248)
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
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(GBHobi)
        Controls.Add(GBJK)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GBJK.ResumeLayout(False)
        GBJK.PerformLayout()
        GBHobi.ResumeLayout(False)
        GBHobi.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RBLaki As RadioButton
    Friend WithEvents RBPR As RadioButton
    Friend WithEvents GBJK As GroupBox
    Friend WithEvents CBbelajar As CheckBox
    Friend WithEvents CBmaingame As CheckBox
    Friend WithEvents CBjalan As CheckBox
    Friend WithEvents CBmancing As CheckBox
    Friend WithEvents CBbuku As CheckBox
    Friend WithEvents CBcoding As CheckBox
    Friend WithEvents GBHobi As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_gambar As Button
    Friend WithEvents btn_simpan As Button

End Class
