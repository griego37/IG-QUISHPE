﻿Imports System.IO
Public Class Form2
    Dim IMAGEN As String
    Dim con As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And IMAGEN <> "" Then

            Dim escribir As New StreamWriter("C:\Users\israe\Desktop\Diccionario.txt", True)
            escribir.WriteLine("PALABRA:" & vbTab & vbTab & vbTab & TextBox1.Text)
            escribir.Close()
            Dim esc As New StreamWriter("C:\Users\israe\Desktop\Significado.txt", True)

            esc.WriteLine("SIGNIFICADO: " & vbTab & vbTab & TextBox2.Text)

            esc.Close()
            Dim ima As New StreamWriter("C:\Users\israe\Desktop\Imagen.txt", True)

            ima.WriteLine(IMAGEN)

            ima.Close()
            Dim tod As New StreamWriter("C:\Users\israe\Desktop\Total.txt", True)

            tod.WriteLine(con & "+" & TextBox1.Text & "+" & TextBox2.Text & "+" & IMAGEN)

            tod.Close()

            Button3.Enabled = True
            TextBox1.Text = ""
            TextBox2.Text = ""
            con = con + 1
        Else
            MsgBox("Error")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form1.ActiveForm.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\israe\Desktop"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            IMAGEN = OpenFileDialog1.FileName
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub
    Public Property valor As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pantalla1 As New Form1
        pantalla1.valorPantalla2 = "HOLA PANTALLA 1"
        Form2.ActiveForm.Hide()

        pantalla1.Show()
    End Sub
End Class