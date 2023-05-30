Imports MySql.Data.MySqlClient
Public Class ModificarSolicitud
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
                txtTelefonoResi.Text = row(7).ToString()


            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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
                txtOpcion.Text = row(3).ToString()
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

    Private Sub btnBuscarExt_Click(sender As Object, e As EventArgs) Handles btnBuscarExt.Click
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

    Private Sub btnBuscarDic_Click(sender As Object, e As EventArgs) Handles btnBuscarDic.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()
            Dim CodigoDic As String = txtCodigoDic.Text.Trim()
            Dim queryString As String = "call sp_DictamenBuscarId(?CodigoDic)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?CodigoDic", CodigoDic)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            For Each row As DataRow In table.Rows
                txtCodigoDic.Text = row(0).ToString()
                txtNombreDic.Text = row(1).ToString()

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            Dim fecha As DateTime = DTFechaSoli.Value
            Dim fec As String = fecha.ToString("yyyy-MM-dd")

            adCon.open()
            Dim sentencia As String = "call sp_SolicitudModificar(?pCodigoSoli,?pNombreSoli,?pFechaSoli,?pRevisionSoli,?pCodigoPro
            ,?pRFC,?pNoControl,?pCodigoExt,?pNoResidentesSoli,?pLugarSoli,?pCodigoDic,?pDirigidoSoli,?pObservaciones,?pServicio,?pCreditos
            ,?pRecibo,?pKardex,?pEvaResidencia,?pEvaSeguimiento,?pConstanciaResi,?pEstatus)"

            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pCodigoSoli", txtCodigoSoli.Text)
            cmCon.Parameters.AddWithValue("?pNombreSoli", txtNombreSoli.Text)
            cmCon.Parameters.AddWithValue("?pFechaSoli", fec)
            cmCon.Parameters.AddWithValue("?pRevisionSoli", txtRevisionSoli.Text)
            cmCon.Parameters.AddWithValue("?pCodigoPro", txtCodigoPro.Text)
            cmCon.Parameters.AddWithValue("?pRFC", txtRFC.Text)

            cmCon.Parameters.AddWithValue("?pNoControl", txtNoControl.Text)
            cmCon.Parameters.AddWithValue("?pCodigoExt", txtCodigoExt.Text)
            cmCon.Parameters.AddWithValue("?pNoResidentesSoli", txtNoResidentesSoli.Text)
            cmCon.Parameters.AddWithValue("?pLugarSoli", txtLugarSoli.Text)
            cmCon.Parameters.AddWithValue("?pCodigoDic", txtCodigoDic.Text)
            cmCon.Parameters.AddWithValue("?pDirigidoSoli", txtDirigidoSoli.Text)
            cmCon.Parameters.AddWithValue("?pObservaciones", txtObservaciones.Text)
            cmCon.Parameters.AddWithValue("?pServicio", comvi(cbServicio.SelectedItem))
            cmCon.Parameters.AddWithValue("?pCreditos", comvi(cbCreditos.SelectedItem))
            cmCon.Parameters.AddWithValue("?pRecibo", comvi(cbRecibo.SelectedItem))
            cmCon.Parameters.AddWithValue("?pKardex", comvi(cbKardex.SelectedItem))
            cmCon.Parameters.AddWithValue("?pEvaResidencia", comvi(cbEvaResidencia.SelectedItem))
            cmCon.Parameters.AddWithValue("?pEvaSeguimiento", comvi(cbEvaSeguimiento.SelectedItem))
            cmCon.Parameters.AddWithValue("?pConstanciaResi", comvi(cbConstancia.SelectedItem))
            cmCon.Parameters.AddWithValue("?pEstatus", comvEst(cbEstatus.SelectedItem))

            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.close()

        End Try
    End Sub
    Public Function comvi(ByVal texto As String) As Integer
        If texto.Equals("Entregado") Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Public Function comvEst(ByVal texto As String) As Integer


        If texto.Equals("Aceptado") Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class