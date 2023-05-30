Imports MySql.Data.MySqlClient
Public Class AgregarSolicitud
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo


        Try

            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            'convierte la fecha a año-mes-dia
            Dim fecha As DateTime = DTFechaSoli.Value
            Dim fec As String = fecha.ToString("yyyy-MM-dd")

            Dim inser As String = "?pCodigo"
            Dim sentencia2 As String = "call sp_ProyectoAgregar(?pNombreP,?pPeriodo, ?pOpcion,1)"
            Dim cnConProyecto As New MySqlCommand(sentencia2, adCon)

            cnConProyecto.Parameters.AddWithValue("?pNombreP", txtNombrePro.Text)
            cnConProyecto.Parameters.AddWithValue("?pPeriodo", txtPeriodo.Text)
            cnConProyecto.Parameters.AddWithValue("?pOpcion", cbOpcion.SelectedItem)
            cnConProyecto.Parameters.AddWithValue("?pCodigo", inser)

            cnConProyecto.ExecuteNonQuery()

            Dim getLast As String = "Select LAST_INSERT_ID()"
            Dim cmGetLast As New MySqlCommand(getLast, adCon)
            inser = CInt(cmGetLast.ExecuteScalar())


            Dim sentencia As String = "call sp_SolicitudAgregar(?pCodigoSoli,?pNombreSoli,?pFechaSoli,?pRevisionSoli,?pCodigoPro
            ,?pRFC,?pNoControl,?pCodigoExt,?pNoResidentesSoli,?pLugarSoli,0,?pDirigidoSoli,?pObservasiones,?pServicio,?pCreditos
            ,?pRecibo,?pKardex,?pEvaResidencia,?pEvaSeguimiento,?pConstanciaResi,1)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pCodigoSoli", txtCodigoSoli.Text)
            cmCon.Parameters.AddWithValue("?pNombreSoli", txtNombreSoli.Text)
            cmCon.Parameters.AddWithValue("?pFechaSoli", fec)
            cmCon.Parameters.AddWithValue("?pRevisionSoli", txtRevisionSoli.Text)
            cmCon.Parameters.AddWithValue("?pCodigoPro", inser)
            cmCon.Parameters.AddWithValue("?pRFC", txtRFC.Text)
            cmCon.Parameters.AddWithValue("?pObservasiones", "ninguna")
            cmCon.Parameters.AddWithValue("?pNoControl", txtNoControl.Text)
            cmCon.Parameters.AddWithValue("?pCodigoExt", txtCodigoExt.Text)
            cmCon.Parameters.AddWithValue("?pNoResidentesSoli", txtNoResidentesSoli.Text)
            cmCon.Parameters.AddWithValue("?pLugarSoli", txtLugarSoli.Text)

            cmCon.Parameters.AddWithValue("?pDirigidoSoli", txtDirigidoSoli.Text)
            cmCon.Parameters.AddWithValue("?pServicio", comv(cbServicio.SelectedItem))
            cmCon.Parameters.AddWithValue("?pCreditos", comv(cbCreditos.SelectedItem))
            cmCon.Parameters.AddWithValue("?pRecibo", comv(cbRecibo.SelectedItem))
            cmCon.Parameters.AddWithValue("?pKardex", comv(cbKardex.SelectedItem))
            cmCon.Parameters.AddWithValue("?pEvaResidencia", comv(cbEvaResidencia.SelectedItem))
            cmCon.Parameters.AddWithValue("?pEvaSeguimiento", comv(cbEvaSeguimiento.SelectedItem))
            cmCon.Parameters.AddWithValue("?pConstanciaResi", comv(cbConstancia.SelectedItem))

            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()



            MsgBox("Datos guardados")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.close()
        End Try
    End Sub

    Public Function comv(ByVal texto As String) As Integer
        If texto.Equals("Entregado") Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscarExt.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()
            Dim CodigoExt As String = txtCodigoExt.Text.Trim()
            Dim queryString As String = "call sp_AsesorExtBuscarId(?CodigoExt)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?CodigoExt", CodigoExt)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            For Each row As DataRow In table.Rows
                txtCodigoExt.Text = row(0).ToString()
                txtNombreExt.Text = row(1).ToString()

                txtPuesto.Text = row(2).ToString()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub btnBuscarResi_Click(sender As Object, e As EventArgs) Handles btnBuscarResi.Click
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
                txtNombreResi.Text = row(1).ToString()
                txtCarrera.Text = row(2).ToString()
                txtTelefonoResi.Text = row(6).ToString()


            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub btnBuscarEmp_Click(sender As Object, e As EventArgs) Handles btnBuscarEmp.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()
            Dim RFC As String = txtRFC.Text.Trim()
            Dim queryString As String = "call sp_EmpresaBuscarId(?RFC)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?RFC", RFC)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            For Each row As DataRow In table.Rows
                txtRFC.Text = row(0).ToString()
                txtNombreEm.Text = row(1).ToString()
                txtCiudadEm.Text = row(5).ToString()
                txtTelefonoEm.Text = row(9).ToString()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class