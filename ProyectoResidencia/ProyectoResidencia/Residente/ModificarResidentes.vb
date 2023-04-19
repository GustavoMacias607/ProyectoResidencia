Imports MySql.Data.MySqlClient
Public Class ModificarResidentes
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub ModificarResidentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbEstatus.CheckedChanged

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_ResidenteModificar(?pNoControl,?pNombre,?pCarrera,?pDomicilio,?pEmail,?pCiudad,?pTelefono,?pSeguridadSocial,?pNoSeguridad,?pEstatus)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pNoControl", txtNoControl.Text)
            cmCon.Parameters.AddWithValue("?pNombre", txtNombre.Text)
            cmCon.Parameters.AddWithValue("?pCarrera", txtCarrera.Text)
            cmCon.Parameters.AddWithValue("?pDomicilio", txtDomicilio.Text)
            cmCon.Parameters.AddWithValue("?pEmail", txtEmail.Text)
            cmCon.Parameters.AddWithValue("?pCiudad", txtCiudad.Text)
            cmCon.Parameters.AddWithValue("?pTelefono", txtTelefono.Text)
            cmCon.Parameters.AddWithValue("?pSeguridadSocial", txtxSeguridadSocial.Text)
            cmCon.Parameters.AddWithValue("?pNoSeguridad", txtNoSeguridad.Text)
            cmCon.Parameters.AddWithValue("?pEstatus", cbEstatus.Checked)
            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.close()

        End Try
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
                txtDomicilio.Text = row(3).ToString()
                txtEmail.Text = row(4).ToString()
                txtCiudad.Text = row(5).ToString()
                txtTelefono.Text = row(6).ToString()
                txtxSeguridadSocial.Text = row(7).ToString()
                txtNoSeguridad.Text = row(8).ToString()
                cbEstatus.Checked = row(9).ToString()

            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub
End Class