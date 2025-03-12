Public Class Form2
    Public Sub TampilkanListView()
        ListView1.Items.Clear()

        For i As Integer = 0 To JumlahMahasiswa - 1
            Dim item As New ListViewItem(NamaMahasiswa(i))
            item.SubItems.Add(NimMahasiswa(i))
            item.SubItems.Add(TglahirMahasiswa(i))
            item.SubItems.Add(JKMahasiswa(i))

            ListView1.Items.Add(item)
        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("Nama", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("NIM", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Tanggal Lahir", 190, HorizontalAlignment.Left)
        ListView1.Columns.Add("Jenis Kelamin", 120, HorizontalAlignment.Left)

        TampilkanListView()
    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Me.Close()
    End Sub
End Class