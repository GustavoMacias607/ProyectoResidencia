Imports MySql.Data.MySqlClient
Public Class MostrarEmpresa
    Dim adCon As MySqlConnection
    Dim sentencia As String
    Dim da As MySqlDataAdapter
    Dim ds
    Dim cmCon As MySqlCommand

    Private Sub mostrarRegistros()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            sentencia = "call sp_EmpresaMostrar()"

            adCon.Open()
            da = New MySqlDataAdapter(sentencia, adCon)
            ds = New DataSet
            da.Fill(ds, "Entidades")
            TablaMostrar.DataSource = ds.Tables("Entidades").DefaultView.ToTable(False, "rFC", "nombre", "ciudad", "telefono")

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
            TablaMostrar.Columns("rFC").HeaderText = "RFC"
            TablaMostrar.Columns("nombre").HeaderText = "Nombre"
            TablaMostrar.Columns("ciudad").HeaderText = "Ciudad"
            TablaMostrar.Columns("telefono").HeaderText = "Telefono"


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub



    Private Sub buscarByNombre()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()
            Dim Nombre As String = txtNombre.Text.Trim()
            Dim queryString As String = "call sp_EmpresaBuscarNombre(?Nombre)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?Nombre", Nombre)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            ' Ocultar columnas innecesarias
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                If column.Name <> "rFC" AndAlso column.Name <> "nombre" AndAlso column.Name <> "ciudad" AndAlso column.Name <> "telefono" Then
                    column.Visible = False
                End If
            Next

            TablaMostrar.DataSource = table

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            TablaMostrar.Columns("rFC").HeaderText = "RFC"
            TablaMostrar.Columns("nombre").HeaderText = "Nombre"
            TablaMostrar.Columns("ciudad").HeaderText = "Ciudad"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub MostrarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarRegistros()
    End Sub

    Private Sub txtRFC_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TablaMostrar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellContentClick

    End Sub

    Private Sub TablaMostrar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellClick

        If e.RowIndex >= 0 Then
            Dim buscar As String = TablaMostrar.Rows(e.RowIndex).Cells("rFC").Value.ToString()
            Dim m As New Modelo
            Try
                adCon = New MySqlConnection(m.conexion)

                adCon.Open()

                Dim queryString As String = "call sp_EmpresaBuscarId(?buscar)"
                Dim command As New MySqlCommand(queryString, adCon)
                command.Parameters.AddWithValue("?buscar", buscar)
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
                    txtFirma.Text = row(12).ToString()
                    cbEstatus.SelectedItem = Est(row(13).ToString())

                Next


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                adCon.Close()
            End Try
        End If

    End Sub
    Public Function Est(ByVal valor As Integer) As String
        If valor.Equals(1) Then
            Return "Activo"
        Else
            Return "Inactivo"
        End If
    End Function
    Private Sub txtNombre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyUp
        buscarByNombre()
    End Sub
End Class