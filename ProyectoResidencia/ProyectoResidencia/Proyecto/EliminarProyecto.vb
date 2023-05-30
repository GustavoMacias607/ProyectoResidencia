Imports MySql.Data.MySqlClient
Public Class EliminarProyecto
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.Open()
            Dim CodigoPro As String = txtCodigoPro.Text.Trim()
            Dim queryString As String = "call sp_ProyectoBuscarId(?CodigoPro)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?CodigoPro", CodigoPro)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            For Each row As DataRow In table.Rows
                txtCodigoPro.Text = row(0).ToString()
                txtNombrePro.Text = row(1).ToString()
                txtPeriodo.Text = row(2).ToString()
                cbOpcion.SelectedItem = row(3).ToString()

                cbEstatus.SelectedItem = Est(row(4).ToString())



            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub
    Public Function Est(ByVal valor As Integer) As String
        If valor.Equals(1) Then
            Return "Activo"
        Else
            Return "Inactivo"
        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_ProyectoDelete(?pCodigoPro)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pCodigoPro", txtCodigoPro.Text)
            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class