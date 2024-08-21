Imports System.Security.Cryptography.Xml

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Numero.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t1, t2, Result As Integer
        Dim op As String
        t1 = CInt(txt1.Text)
        t2 = CInt(txt2.Text)
        op = c1.Text
        If op = "+" Then
            Result = t1 + t2
        End If
        If op = "-" Then
            Result = t1 - t2
        End If
        If op = "*" Then
            Result = t1 * t2
        End If

        If op = "/" Then
            Result = t1 / t2
        End If
        MsgBox("El resultado es: " & Result)
    End Sub

    Private Sub c1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class
