Public Class Form1

    Public Property valorPantalla2 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pantalla2 As New Form2




        Form1.ActiveForm.Hide()

        pantalla2.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Property valorPantalla3 As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pantalla3 As New Form3




        Form1.ActiveForm.Hide()

        pantalla3.Show()
    End Sub

    Public Property valorPantalla4 As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pantalla4 As New Form4




        Form1.ActiveForm.Hide()

        pantalla4.Show()
    End Sub
End Class
