Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rutaArchivo As String = "D:\texto.txt"
        Try
            If My.Computer.FileSystem.FileExists(rutaArchivo) Then
                Dim contenido As String = My.Computer.FileSystem.ReadAllText(rutaArchivo)
                TextBox1.Text = contenido
                Label1.Text = "Archivo"

            Else

                Label1.Text = "El archivo no fue encontrado"

            End If
        Catch ex As Exception
            Label1.Text = "Error al cargar el archivo " & ex.Message

        End Try
    End Sub
End Class