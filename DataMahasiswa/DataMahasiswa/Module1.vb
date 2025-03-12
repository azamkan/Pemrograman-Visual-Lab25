Module Module1
    Public NamaMahasiswa() As String
    Public NimMahasiswa() As String
    Public TglahirMahasiswa() As String
    Public JKMahasiswa() As String
    Public JumlahMahasiswa As Integer = 0

    Public Sub TambahMahasiswa(ByVal Nama As String, ByVal Nim As String, ByVal TgLahir As String, ByVal JK As String)
        ReDim Preserve NimMahasiswa(JumlahMahasiswa)
        ReDim Preserve NamaMahasiswa(JumlahMahasiswa)
        ReDim Preserve TglahirMahasiswa(JumlahMahasiswa)
        ReDim Preserve JKMahasiswa(JumlahMahasiswa)

        NimMahasiswa(JumlahMahasiswa) = Nim
        NamaMahasiswa(JumlahMahasiswa) = Nama
        TglahirMahasiswa(JumlahMahasiswa) = TgLahir
        JKMahasiswa(JumlahMahasiswa) = JK
        JumlahMahasiswa += 1
    End Sub

End Module
