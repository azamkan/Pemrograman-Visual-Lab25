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
        lb_nama = New Label()
        lb_nim = New Label()
        lb_tglahir = New Label()
        lb_jk = New Label()
        lb_hobi = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lb_nama
        ' 
        lb_nama.AutoSize = True
        lb_nama.Location = New Point(412, 46)
        lb_nama.Name = "lb_nama"
        lb_nama.Size = New Size(49, 20)
        lb_nama.TabIndex = 0
        lb_nama.Text = "Nama"
        ' 
        ' lb_nim
        ' 
        lb_nim.AutoSize = True
        lb_nim.Location = New Point(412, 107)
        lb_nim.Name = "lb_nim"
        lb_nim.Size = New Size(37, 20)
        lb_nim.TabIndex = 1
        lb_nim.Text = "NIM"
        ' 
        ' lb_tglahir
        ' 
        lb_tglahir.AutoSize = True
        lb_tglahir.Location = New Point(412, 168)
        lb_tglahir.Name = "lb_tglahir"
        lb_tglahir.Size = New Size(97, 20)
        lb_tglahir.TabIndex = 2
        lb_tglahir.Text = "Tanggal Lahir"
        ' 
        ' lb_jk
        ' 
        lb_jk.AutoSize = True
        lb_jk.Location = New Point(412, 229)
        lb_jk.Name = "lb_jk"
        lb_jk.Size = New Size(98, 20)
        lb_jk.TabIndex = 3
        lb_jk.Text = "Jenis Kelamin"
        ' 
        ' lb_hobi
        ' 
        lb_hobi.AutoSize = True
        lb_hobi.Location = New Point(412, 290)
        lb_hobi.Name = "lb_hobi"
        lb_hobi.Size = New Size(42, 20)
        lb_hobi.TabIndex = 4
        lb_hobi.Text = "Hobi"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(25, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 276)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(291, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 6
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(291, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 20)
        Label2.TabIndex = 7
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(291, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 8
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(291, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 9
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(291, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 10
        Label5.Text = "Hobi"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(lb_hobi)
        Controls.Add(lb_jk)
        Controls.Add(lb_tglahir)
        Controls.Add(lb_nim)
        Controls.Add(lb_nama)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lb_nama As Label
    Friend WithEvents lb_nim As Label
    Friend WithEvents lb_tglahir As Label
    Friend WithEvents lb_jk As Label
    Friend WithEvents lb_hobi As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
