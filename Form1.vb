Public Class Form1
    Dim bitis As Boolean = False
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(44)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Dim para As Single
        para = CSng(TextBox1.Text)
        MsgBox(para.ToString("N4") + " // Sonuna , koyup 4 tane sıfır ekledi")
        MsgBox(para.ToString("c3") + " // Sonuna , koyup 3 sıfır ekledi ve kullanılan para birimini yazdı")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Width = 150
        PictureBox1.Height = 150
        PictureBox1.Image = Image.FromFile("D:\Leon\IMG_2838.JPG")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBox2.Width = 150
        PictureBox2.Height = 150
        PictureBox2.Image = Image.FromFile("D:\Leon\IMG_2838.JPG")
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.ValidatingType = GetType(System.DateTime)
        MaskedTextBox2.Mask = "(000) 000 00 00"
        MaskedTextBox2.ValidatingType = GetType(System.Single)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        'Dim cizgirengi As Pen
        'Dim x1, y1, x2, y2 As Integer
        'x1 = CInt(TextBox3.Text)
        'y1 = CInt(TextBox4.Text)
        'x2 = CInt(TextBox5.Text)
        'y2 = CInt(TextBox6.Text)
        'cizgirengi = Pens.Black
        'PictureBox1.CreateGraphics.DrawLine(cizgirengi, x1, y1, x2, y2)

        Dim x11, y11, a, b As Integer
        x11 = e.X
        y11 = e.Y
        a = x11 Mod 10
        b = y11 Mod 10
        Label1.Text = x11
        Label2.Text = y11
        Label3.Text = a
        Label4.Text = b
        If a < 5 Then
            x11 = x11 - a
        Else
            x11 = x11 + a
        End If
        If b < 5 Then
            y11 = y11 - b
        Else
            y11 = y11 + b
        End If
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        Dim x, y As Integer
        Dim cizgirengi As Pen
        cizgirengi = Pens.Black
        x = e.X
        y = e.X
        PictureBox2.CreateGraphics.DrawLine(cizgirengi, x, y, x + 1, y + 1)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        bitis = True
    End Sub
End Class
