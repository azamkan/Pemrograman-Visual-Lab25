Module DataModule
    Public Nama, NIM, JK, Hobi, Foto As String
    Public Tg_lahir As Date

    ' Simpan Nilai dari RadioButton
    Public Function GetSelectedRadioButton(ByVal grupRadio() As RadioButton) As String
        For Each rbtn As RadioButton In grupRadio
            If rbtn.Checked Then Return rbtn.Text
        Next
        Return ""
    End Function

    ' Simpan Nilai dari CheckBox
    Public Function GetSelectedCheckBox(ByVal grupCheck() As CheckBox) As String
        Dim selectedItems As New List(Of String)

        For Each cb As CheckBox In grupCheck
            If cb.Checked Then
                selectedItems.Add(cb.Text)
            End If
        Next

        Return String.Join(", ", selectedItems)
    End Function
End Module
