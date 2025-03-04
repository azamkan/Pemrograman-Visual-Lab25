Public Class Form1

    ' Variabel
    Public varPublic As String = "variabel Public dari Form1"
    Private varDimForm1 As String = "variabel class Form1"

    Private Sub btnVariabel_Click(sender As Object, e As EventArgs) Handles btnVariabel.Click
        Dim lokalVar As Integer = 5 ' Variabel lokal
        MessageBox.Show("Public : " & varPublic & vbCrLf &
                "Lokal : " & lokalVar & vbCrLf &
                "Class : " & varDimForm1)
    End Sub

    Private Sub btnVariabel1_Click(sender As Object, e As EventArgs) Handles btnVariabel1.Click
        'lokalVar akan error karena berbeda prosedur, fungsi, modul
        'MessageBox.Show("Public : " & varPublic & ", Lokal : " & lokalVar & ", Class : " & varDimForm1)
        MessageBox.Show(String.Join(vbCrLf, "Public : " & varPublic, "Class : " & varDimForm1))
    End Sub

    'Tipe data dan Operator
    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles btnOperator.Click
        Dim a As Integer = 17
        Dim b As Integer = 2

        Dim hasilPenjumlahan As Integer = a + b
        Dim hasilPembagian As Double = a / b
        Dim hasilPengurangan As Integer = a - b
        Dim hasilPerkalian As Integer = a * b
        Dim hasilMod As Integer = a Mod b
        Dim hasilPangkat As Double = a ^ b

        MessageBox.Show(String.Join(vbCrLf,
                        a & " + " & b & " = " & hasilPenjumlahan,
                        a & " / " & b & " = " & hasilPembagian,
                        a & " - " & b & " = " & hasilPengurangan,
                        a & " * " & b & " = " & hasilPerkalian,
                        a & " Mod " & b & " = " & hasilMod,
                        a & " ^ " & b & " = " & hasilPangkat))
    End Sub

    Private Sub btnOperator1_Click(sender As Object, e As EventArgs) Handles btnOperator1.Click
        Dim x As Boolean = True
        Dim y As Boolean = False

        Dim hasilAnd As Boolean = x And y   ' False (karena salah satu False)
        Dim hasilOr As Boolean = x Or y     ' True (karena salah satu True)
        Dim hasilNotX As Boolean = Not x    ' False (karena Not membalik nilai)
        Dim hasilXor As Boolean = x Xor y   ' True (karena salah satu True, tapi tidak keduanya)

        MessageBox.Show(String.Join(vbCrLf,
                        x & " And " & y & " = " & hasilAnd,
                        x & " Or " & y & " = " & hasilOr,
                        "Not " & x & " = " & hasilNotX,
                        x & " Xor " & y & " = " & hasilXor))
    End Sub

    Private Sub btnOperator2_Click(sender As Object, e As EventArgs) Handles btnOperator2.Click
        Dim a As Integer = 10
        Dim b As Integer = 5

        Dim hasilSama As Boolean = (a = b)    ' False
        Dim hasilTidakSama As Boolean = (a <> b)  ' True
        Dim hasilLebihBesar As Boolean = (a > b)  ' True
        Dim hasilLebihKecil As Boolean = (a < b)  ' False
        Dim hasilLebihBesarSama As Boolean = (a >= b) ' True
        Dim hasilLebihKecilSama As Boolean = (a <= b) ' False

        MessageBox.Show(String.Join(vbCrLf,
                        a & " = " & b & " : " & hasilSama,
                        a & " <> " & b & " : " & hasilTidakSama,
                        a & " > " & b & " : " & hasilLebihBesar,
                        a & " < " & b & " : " & hasilLebihKecil,
                        a & " >= " & b & " : " & hasilLebihBesarSama,
                        a & " <= " & b & " : " & hasilLebihKecilSama))
    End Sub

    ' Percabangan IF
    Private Sub btnIF_Click(sender As Object, e As EventArgs) Handles btnIF.Click
        Dim x As Integer = 11
        If x > 10 Then
            MessageBox.Show(x & " lebih besar dari 10")
        End If
    End Sub

    Private d As Integer = 11
    Private Sub btnIF1_Click(sender As Object, e As EventArgs) Handles btnIF1.Click
        If d > 10 Then
            MessageBox.Show(d & " lebih besar dari 10")
            d = d + 1
        End If
    End Sub

    Private Sub btnIF2_Click(sender As Object, e As EventArgs) Handles btnIF2.Click
        Dim x As Integer = 11
        Dim y As Integer = 18
        If x > 10 And y < 20 Then
            MessageBox.Show("Kondisi terpenuhi")
        End If
    End Sub

    Private Sub btnIF3_Click(sender As Object, e As EventArgs) Handles btnIF3.Click
        Dim x As Integer = 11
        If x > 10 Then
            MessageBox.Show("x lebih besar dari 10")
        ElseIf x = 10 Then
            MessageBox.Show("x sama dengan 10")
        Else
            MessageBox.Show("x kurang dari 10")
        End If
    End Sub

    'Percabangan SELECT CASE
    Private Sub btnCase_Click(sender As Object, e As EventArgs) Handles btnCase.Click
        Dim nilai As Integer = 85
        Select Case nilai
            Case 90 To 100
                MessageBox.Show("Grade A")
            Case 80 To 89
                MessageBox.Show("Grade B")
            Case 70 To 79
                MessageBox.Show("Grade C")
            Case Else
                MessageBox.Show("Grade D")
        End Select
    End Sub

    ' Perulangan
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        For i As Integer = 1 To 5
            MessageBox.Show("Iterasi ke-" & i)
        Next
    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        Dim i As Integer = 6
        Do
            MessageBox.Show("Iterasi ke-" & i)
            i = i + 1
        Loop While i <= 5
    End Sub

    Private Sub btnDoLoop1_Click(sender As Object, e As EventArgs) Handles btnDoLoop1.Click
        Dim i As Integer = 4
        Do While i <= 5
            MessageBox.Show("Iterasi ke-" & i)
            i = i + 1
        Loop
    End Sub

    Private Sub btnDoLoop2_Click(sender As Object, e As EventArgs) Handles btnDoLoop2.Click
        Dim i As Integer = 1
        Do Until i > 5
            MessageBox.Show("Iterasi ke-" & i)
            i = i + 1
        Loop
    End Sub
End Class
