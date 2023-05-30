Imports MySql.Data.MySqlClient
Public Class EliminarSolicitud
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.Open()
            Dim CodigoSoli As String = txtCodigoSoli.Text.Trim()
            Dim queryString As String = "call sp_SolicitudBuscarId(?CodigoSoli)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?CodigoSoli", CodigoSoli)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            For Each row As DataRow In table.Rows
                txtCodigoSoli.Text = row(0).ToString()
                txtNombreSoli.Text = row(1).ToString()
                DTFechaSoli.Value = row(2).ToString()
                txtRevisionSoli.Text = row(3).ToString()
                txtCodigoPro.Text = row(16).ToString()
                txtRFC.Text = row(21).ToString()
                '
                txtNoControl.Text = row(35).ToString()
                txtCodigoExt.Text = row(46).ToString()
                txtNoResidentesSoli.Text = row(4).ToString()
                txtLugarSoli.Text = row(5).ToString()
                txtCodigoDic.Text = row(50).ToString()
                txtDirigidoSoli.Text = row(6).ToString()
                txtObservaciones.Text = row(7).ToString()
                cbServicio.SelectedItem = comv(row(8).ToString())
                cbCreditos.SelectedItem = comv(row(9).ToString())
                cbRecibo.SelectedItem = comv(row(10).ToString())
                cbKardex.SelectedItem = comv(row(11).ToString())
                cbEvaResidencia.SelectedItem = comv(row(12).ToString())
                cbEvaSeguimiento.SelectedItem = comv(row(13).ToString())
                cbConstancia.SelectedItem = comv(row(14).ToString())
                cbEstatus.SelectedItem = Est(row(15).ToString())

                txtNombreResi.Text = row(36).ToString()
                txtCarrera.Text = row(37).ToString()
                txtTelefonoResi.Text = row(42).ToString()
                txtNombrePro.Text = row(17).ToString()
                txtPeriodo.Text = row(18).ToString()
                txtOpcion.Text = row(19).ToString()

                txtNombreEm.Text = row(22).ToString()
                txtCiudadEm.Text = row(26).ToString()
                txtTelefonoEm.Text = row(30).ToString()
                txtNombreExt.Text = row(47).ToString()
                txtPuesto.Text = row(48).ToString()
                txtNombreDic.Text = row(51).ToString()


            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub

    Public Function comv(ByVal valor As Integer) As String
        If valor.Equals(1) Then
            Return "Entregado"
        Else
            Return "No Entregado"
        End If
    End Function
    Public Function Est(ByVal valor As Integer) As String
        If valor.Equals(1) Then
            Return "Aceptado"
        Else
            Return "Rechazado"
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_SolicitudDelete(?pCodigoSoli)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pCodigoSoli", txtCodigoSoli.Text)
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