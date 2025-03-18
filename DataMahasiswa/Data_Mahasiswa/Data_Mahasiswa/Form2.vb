Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_nama.Text = Nama
        lb_nim.Text = NIM
        lb_tglahir.Text = Tg_lahir
        lb_jk.Text = JK
        lb_hobi.Text = Hobi
        PictureBox1.Image = Image.FromFile(Foto)
    End Sub
End Class