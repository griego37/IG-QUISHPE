﻿Imports System.IO
Public Class Form4
    Dim imagen As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
        ListView1.Columns.Add("ID", 20)
        ListView1.Columns.Add("Palabra", 100)
        ListView1.Columns.Add("Significado", 50)
        ListView1.Columns.Add("Path Image", 20)
        Dim Total As New StreamReader("C:\Users\israe\Desktop\Total.txt")
        Dim palabras() As String
        While Total.Peek <> -1
            palabras = Total.ReadLine().ToString.Split("+")
            Dim item As ListViewItem
            item = New ListViewItem(palabras)
            ListView1.Items.Add(item)

        End While

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        imagen = ListView1.SelectedItems.ToString


        Dim v2 As New Form2
        'MsgBox(ListBox2.SelectedIndex)


        'v3.PictureBox1.Image = Image.FromFile(ListView1.SelectedIndexCollection)
        'v3.P.Text = ListView1.Items(ListView1.SelectedIndices)
        'v3.S.Text = ListBox3.Items(ListBox2.SelectedIndex)
        Form4.ActiveForm.Hide()
        v2.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        imagen = ListView1.SelectedIndices.ToString
        MsgBox(imagen)

    End Sub
    Public Property valor As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pantalla1 As New Form1
        pantalla1.valorPantalla2 = "HOLA PANTALLA 1"
        Form2.ActiveForm.Hide()

        pantalla1.Show()
    End Sub


End Class