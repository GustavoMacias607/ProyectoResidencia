Imports MySql.Data.MySqlClient




Public Class MostrarResidente

    Dim adCon
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub MostrarResidente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()

        Catch dx As Exception

        Finally
            adCon.close()

        End Try
    End Sub
End Class