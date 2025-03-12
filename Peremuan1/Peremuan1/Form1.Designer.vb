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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtboxPanjang = New TextBox()
        txtboxLebar = New TextBox()
        btnHitung = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(313, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 20)
        Label1.TabIndex = 0
        Label1.Text = "kalkulator persegi panjang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 1
        Label2.Text = "panjang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 2
        Label3.Text = "lebar"
        ' 
        ' txtboxPanjang
        ' 
        txtboxPanjang.Location = New Point(54, 115)
        txtboxPanjang.Name = "txtboxPanjang"
        txtboxPanjang.Size = New Size(313, 27)
        txtboxPanjang.TabIndex = 3
        ' 
        ' txtboxLebar
        ' 
        txtboxLebar.Location = New Point(61, 209)
        txtboxLebar.Name = "txtboxLebar"
        txtboxLebar.Size = New Size(306, 27)
        txtboxLebar.TabIndex = 4
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(108, 307)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(94, 29)
        btnHitung.TabIndex = 5
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnHitung)
        Controls.Add(txtboxLebar)
        Controls.Add(txtboxPanjang)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxPanjang As TextBox
    Friend WithEvents txtboxLebar As TextBox
    Friend WithEvents btnHitung As Button

End Class
