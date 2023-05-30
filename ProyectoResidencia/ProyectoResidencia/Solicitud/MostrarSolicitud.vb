Imports MySql.Data.MySqlClient
Public Class MostrarSolicitud
    Dim adCon As MySqlConnection
    Dim sentencia As String
    Dim da As MySqlDataAdapter
    Dim ds
    Dim cmCon As MySqlCommand

    Private Sub buscarByNombre()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()

            If (txtCodigoSoli.Text).Equals("") Then

                adCon = New MySqlConnection(m.conexion)
                sentencia = "call sp_SolicitudMostrar()"

                adCon.Open()
                da = New MySqlDataAdapter(sentencia, adCon)
                ds = New DataSet
                da.Fill(ds, "Entidades")
                TablaMostrar.DataSource = ds.Tables("Entidades").DefaultView.ToTable(False, "codigoS", "nombre", "fecha")

                ' Establecer el modo de ajuste automático de las columnas en Fill
                For Each column As DataGridViewColumn In TablaMostrar.Columns
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                Next

                TablaMostrar.Columns("codigoS").HeaderText = "Codigo"
                TablaMostrar.Columns("nombre").HeaderText = "Nombre"
                TablaMostrar.Columns("fecha").HeaderText = "Fecha"



            Else
                Dim Codigo As String = txtCodigoSoli.Text.Trim()
                Dim queryString As String = "call sp_SolicitudBuscarId(?Codigo)"
                Dim command As New MySqlCommand(queryString, adCon)
                command.Parameters.AddWithValue("?Codigo", Codigo)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Ocultar columnas innecesarias
                For Each column As DataGridViewColumn In TablaMostrar.Columns
                    If column.Name <> "codigoS" AndAlso column.Name <> "nombre" AndAlso column.Name <> "fecha" Then
                        column.Visible = False
                    End If
                Next

                TablaMostrar.DataSource = table

                ' Establecer el modo de ajuste automático de las columnas en Fill
                For Each column As DataGridViewColumn In TablaMostrar.Columns
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                Next

                TablaMostrar.Columns("codigoS").HeaderText = "Codigo"
                TablaMostrar.Columns("nombre").HeaderText = "Nombre"
                TablaMostrar.Columns("fecha").HeaderText = "Fecha"
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub
    Private Sub ConsultarSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscarByNombre()
        buscarByNombre()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtCodigoSoli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoSoli.KeyPress
        buscarByNombre()
        buscarByNombre()
    End Sub

    Private Sub txtCodigoSoli_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCodigoSoli.KeyUp
        buscarByNombre()
        buscarByNombre()
    End Sub

    Private Sub TablaMostrar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellClick
        If e.RowIndex >= 0 Then
            Dim buscar As String = TablaMostrar.Rows(e.RowIndex).Cells("codigoS").Value.ToString()
            Dim m As New Modelo
            Try
                adCon = New MySqlConnection(m.conexion)

                adCon.Open()

                Dim queryString As String = "call sp_SolicitudBuscarId(?buscar)"
                Dim command As New MySqlCommand(queryString, adCon)
                command.Parameters.AddWithValue("?buscar", buscar)
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
        End If

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class