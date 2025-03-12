Public Class Form1
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim jk, nama, Tglahir, nim As String

        If RadioButtonLK.Checked Then
            jk = "Laki - Laki"
        ElseIf RadioButtonPR.Checked Then
            jk = "Perempuan"
        End If

        nama = TextBoxNama.Text
        Tglahir = DateTimePickerTgLahir.Text
        nim = TextBoxNIM.Text

        Module1.TambahMahasiswa(nama, nim, Tglahir, jk)
    End Sub

    Private Sub ButtonTampil_Click(sender As Object, e As EventArgs) Handles ButtonTampil.Click
        Form2.Show()
    End Sub
End Class
