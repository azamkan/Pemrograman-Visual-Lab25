Imports System.IO

Public Class Form1
    Private Function CekData() As Boolean
        If Not ValidasiTextBox(tb_nama, "Nama Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(tb_nim, "NIM Tidak Boleh Kosong") Then Return False

        Dim CheckBox_Hobi() As CheckBox = {
            cb_belajar, cb_buku, cb_coding, cb_jalan, cb_maingame, cb_mancing
        }
        If Not ValidasiCheckBox(CheckBox_Hobi, "Pilih Minimal 1 Hobi") Then Return False

        Dim RadioButton_jk() As RadioButton = {
            rb_laki, rb_pr
        }
        If Not ValidasiRadioButton(RadioButton_jk, "Pilih Jenis Kelamin Anda") Then Return False

        Return True
    End Function

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If CekData() Then
            Nama = tb_nama.Text
            NIM = tb_nim.Text
            JK = gb_jk.Text

            Dim CheckBox_Hobi() As CheckBox = {
                cb_belajar, cb_buku, cb_coding, cb_jalan, cb_maingame, cb_mancing
            }
            Dim Hobi_Selected As String = GetSelectedCheckBox(CheckBox_Hobi)
            Hobi = Hobi_Selected

            Dim RadioButton_jk() As RadioButton = {
                rb_laki, rb_pr
            }
            Dim jk_Selected As String = GetSelectedRadioButton(RadioButton_jk)
            JK = jk_Selected

            Form2.Show()
        End If
    End Sub

    Private Sub tb_nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_nama.KeyPress
        AllowOnlyLetters(sender, e)
    End Sub

    Private Sub tb_nim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_nim.KeyPress
        AllowOnlyNumbers(sender, e)
    End Sub

    Private Sub btn_gambar_Click(sender As Object, e As EventArgs) Handles btn_gambar.Click
        If ValidasiTextBox(tb_nama, "Nama Tidak Boleh Kosong") Then
            Nama = tb_nama.Text
            Dim openFileDialog As New OpenFileDialog()

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = Nama & Path.GetExtension(openFileDialog.FileName)

                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                Dim destinationPath As String = Path.Combine(folderPath, fileName)

                File.Copy(openFileDialog.FileName, destinationPath, True)
                Foto = destinationPath

                PictureBox1.Image = Image.FromFile(destinationPath)

                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class
