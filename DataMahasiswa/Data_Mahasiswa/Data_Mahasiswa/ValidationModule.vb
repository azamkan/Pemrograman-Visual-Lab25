Module ValidationModule

    ' Fungsi untuk validasi input hanya angka
    Public Sub AllowOnlyNumbers(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim keyascii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0 ' Izinkan input
        Else
            e.Handled = True
        End If
    End Sub

    ' Fungsi untuk validasi input hanya huruf
    Public Sub AllowOnlyLetters(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim keyascii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[a-zA-Z]" _
            OrElse keyascii = Keys.Back _
            OrElse keyascii = Keys.Space _
            OrElse keyascii = Keys.Return _
            OrElse keyascii = Keys.Delete) Then

            keyascii = 0
        Else
            e.Handled = True
        End If
    End Sub

    ' Fungsi untuk Validasi TextBox
    Public Function ValidasiTextBox(ByVal txt As TextBox, ByVal pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            MsgBox(pesan, MsgBoxStyle.Exclamation, "Peringatan")
            txt.Focus()
            Return False
        End If
        Return True
    End Function

    ' Fungsi untuk Validasi CheckBox
    Public Function ValidasiCheckBox(ByVal grupCheckBox() As CheckBox, ByVal pesan As String) As Boolean
        For Each cb As CheckBox In grupCheckBox
            If cb.Checked Then Return True
        Next
        MsgBox(pesan, MsgBoxStyle.Exclamation, "Peringatan")
        Return False
    End Function

    ' Fungsi untuk Validasi RadioButton
    Public Function ValidasiRadioButton(ByVal grupRadio() As RadioButton, ByVal pesan As String) As Boolean
        For Each rbtn As RadioButton In grupRadio
            If rbtn.Checked Then Return True
        Next
        MsgBox(pesan, MsgBoxStyle.Exclamation, "Peringatan")
        Return False
    End Function

End Module
