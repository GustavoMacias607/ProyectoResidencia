Imports MySql.Data.MySqlClient
Public Class EliminarEmpresa
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub EliminarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_EmpresaDelete(?pRFC)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pRFC", txtRFC.Text)
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()
            Dim RFC As String = txtRFC.Text.Trim()
            Dim queryString As String = "call sp_EmpresaBuscarId(?rFC)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?rFC", RFC)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            For Each row As DataRow In table.Rows
                txtRFC.Text = row(0).ToString()
                txtNombre.Text = row(1).ToString()
                txtSector.Text = row(2).ToString()
                txtDomicilio.Text = row(3).ToString()
                txtColonia.Text = row(4).ToString()
                txtCiudad.Text = row(5).ToString()
                txtMision.Text = row(6).ToString()
                txtCP.Text = row(7).ToString()
                txtFax.Text = row(8).ToString()
                txtTelefono.Text = row(9).ToString()
                txtTitular.Text = row(10).ToString()
                txtPuesto.Text = row(11).ToString()
                cbFirma.Checked = row(12).ToString()
                cbEstatus.Checked = row(13).ToString()

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub
End Class