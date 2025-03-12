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
        TextBoxNama = New TextBox()
        TextBoxNIM = New TextBox()
        DateTimePickerTgLahir = New DateTimePicker()
        GroupBox1 = New GroupBox()
        RadioButtonPR = New RadioButton()
        RadioButtonLK = New RadioButton()
        btnSimpan = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ButtonTampil = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(194, 55)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(250, 27)
        TextBoxNama.TabIndex = 0
        ' 
        ' TextBoxNIM
        ' 
        TextBoxNIM.Location = New Point(194, 109)
        TextBoxNIM.Name = "TextBoxNIM"
        TextBoxNIM.Size = New Size(250, 27)
        TextBoxNIM.TabIndex = 1
        ' 
        ' DateTimePickerTgLahir
        ' 
        DateTimePickerTgLahir.Location = New Point(194, 305)
        DateTimePickerTgLahir.Name = "DateTimePickerTgLahir"
        DateTimePickerTgLahir.Size = New Size(250, 27)
        DateTimePickerTgLahir.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButtonPR)
        GroupBox1.Controls.Add(RadioButtonLK)
        GroupBox1.Location = New Point(194, 166)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 125)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pilihan"
        ' 
        ' RadioButtonPR
        ' 
        RadioButtonPR.AutoSize = True
        RadioButtonPR.Location = New Point(23, 81)
        RadioButtonPR.Name = "RadioButtonPR"
        RadioButtonPR.Size = New Size(104, 24)
        RadioButtonPR.TabIndex = 1
        RadioButtonPR.TabStop = True
        RadioButtonPR.Text = "Perempuan"
        RadioButtonPR.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonLK
        ' 
        RadioButtonLK.AutoSize = True
        RadioButtonLK.Location = New Point(27, 32)
        RadioButtonLK.Name = "RadioButtonLK"
        RadioButtonLK.Size = New Size(96, 24)
        RadioButtonLK.TabIndex = 0
        RadioButtonLK.TabStop = True
        RadioButtonLK.Text = "Laki - Laki"
        RadioButtonLK.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(61, 378)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 5
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 20)
        Label2.TabIndex = 6
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 310)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 7
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(61, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 8
        Label4.Text = "Jenis Kelamin"
        ' 
        ' ButtonTampil
        ' 
        ButtonTampil.Location = New Point(661, 378)
        ButtonTampil.Name = "ButtonTampil"
        ButtonTampil.Size = New Size(94, 29)
        ButtonTampil.TabIndex = 9
        ButtonTampil.Text = "Tampilkan"
        ButtonTampil.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonTampil)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSimpan)
        Controls.Add(GroupBox1)
        Controls.Add(DateTimePickerTgLahir)
        Controls.Add(TextBoxNIM)
        Controls.Add(TextBoxNama)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxNIM As TextBox
    Friend WithEvents DateTimePickerTgLahir As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonPR As RadioButton
    Friend WithEvents RadioButtonLK As RadioButton
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonTampil As Button

End Class
