Imports MySql.Data.MySqlClient
Public Class EliminarResidente
    Dim adCon
    Dim cmCon As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_ResidenteDelete(?pNoControl)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pNoControl", txtNoControl.Text)
            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.close()

        End Try
    End Sub

    Private Sub EliminarResidente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()
            Dim noControl As String = txtNoControl.Text.Trim()
            Dim queryString As String = "call sp_ResidenteBuscarId(?noControl)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?noControl", noControl)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            For Each row As DataRow In table.Rows
                txtNoControl.Text = row(0).ToString()
                txtNombre.Text = row(1).ToString()
                txtCarrera.Text = row(2).ToString()
                cbSexo.Text = row(3).ToString()
                txtDomicilio.Text = row(4).ToString()
                txtEmail.Text = row(5).ToString()
                txtCiudad.Text = row(6).ToString()
                txtTelefono.Text = row(7).ToString()
                txtxSeguridadSocial.Text = row(8).ToString()
                txtNoSeguridad.Text = row(9).ToString()
                cbEstatus.SelectedItem = Est(row(10).ToString())

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

End Class