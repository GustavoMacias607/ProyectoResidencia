Imports MySql.Data.MySqlClient
Public Class MostrarResidente

    Dim adCon As MySqlConnection
    Dim sentencia As String
    Dim da As MySqlDataAdapter
    Dim ds
    Dim cmCon As MySqlCommand

    Private Sub MostrarResidente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarRegistros()
    End Sub

    Private Sub mostrarRegistros()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            sentencia = "call sp_ResidenteMostrar()"

            adCon.Open()
            da = New MySqlDataAdapter(sentencia, adCon)
            ds = New DataSet
            da.Fill(ds, "Entidades")
            TablaMostrar.DataSource = ds.Tables("Entidades").DefaultView.ToTable(False, "noControl", "nombre", "carrera", "telefono")

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            TablaMostrar.Columns("noControl").HeaderText = "No Control"
            TablaMostrar.Columns("nombre").HeaderText = "Nombre"
            TablaMostrar.Columns("carrera").HeaderText = "Carrera"
            TablaMostrar.Columns("telefono").HeaderText = "Telefono"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub


    Private Sub buscarByNombre()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.Open()
            Dim Nombre As String = txtNombre.Text.Trim()
            Dim queryString As String = "call sp_ResidenteBuscarNombre(?Nombre)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?Nombre", Nombre)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Ocultar columnas innecesarias
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                If column.Name <> "noControl" AndAlso column.Name <> "nombre" AndAlso column.Name <> "carrera" AndAlso column.Name <> "telefono" Then
                    column.Visible = False
                End If
            Next

            TablaMostrar.DataSource = table

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
            TablaMostrar.Columns("noControl").HeaderText = "No Control"
            TablaMostrar.Columns("nombre").HeaderText = "Nombre"
            TablaMostrar.Columns("carrera").HeaderText = "Carrera"
            TablaMostrar.Columns("telefono").HeaderText = "Telefono"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try

    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        buscarByNombre()
    End Sub
    Public Function Est(ByVal valor As Integer) As String
        If valor.Equals(1) Then
            Return "Activo"
        Else
            Return "Inactivo"
        End If
    End Function
    Private Sub clic(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellClick
        If e.RowIndex >= 0 Then
            Dim noControl As String = TablaMostrar.Rows(e.RowIndex).Cells("noControl").Value.ToString()
            Dim m As New Modelo
            Try
                adCon = New MySqlConnection(m.conexion)

                adCon.Open()

                Dim queryString As String = "call sp_ResidenteBuscarId(?noControl)"
                Dim command As New MySqlCommand(queryString, adCon)
                command.Parameters.AddWithValue("?noControl", noControl)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                For Each row As DataRow In table.Rows
                    txtNoControl.Text = row(0).ToString()
                    '' txtNombre.Text = row(1).ToString()
                    txtCarrera.Text = row(2).ToString()
                    txtSexo.Text = row(3).ToString()
                    txtDomicilio.Text = row(4).ToString()
                    txtEmail.Text = row(5).ToString()
                    txtCiudad.Text = row(6).ToString()
                    txtTelefono.Text = row(7).ToString()
                    txtxSeguridadSocial.Text = row(8).ToString()
                    txtNoSeguridad.Text = row(9).ToString()
                    txtEstatus.Text = Est(row(10).ToString())

                Next


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                adCon.Close()
            End Try
        End If
    End Sub

    Private Sub txtNombre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyUp
        buscarByNombre()
    End Sub
End Class