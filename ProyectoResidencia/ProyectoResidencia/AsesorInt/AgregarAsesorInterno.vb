Imports MySql.Data.MySqlClient
Public Class AgregarAsesorInterno
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_AsesorIntAgregar(?pNombre,?pPuesto,1)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()


            cmCon.Parameters.AddWithValue("?pNombre", txtNombre.Text)
            cmCon.Parameters.AddWithValue("?pPuesto", txtPuesto.Text)

            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.close()

        End Try
    End Sub

    Private Sub AgregarAsesorInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class