Imports MySql.Data.MySqlClient
Public Class MostrarAsesorInterno
    Dim adCon As MySqlConnection
    Dim sentencia As String
    Dim da As MySqlDataAdapter
    Dim ds
    Dim cmCon As MySqlCommand
    Private Sub mostrarRegistros()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            sentencia = "call sp_AsesorIntMostrar()"

            adCon.Open()
            da = New MySqlDataAdapter(sentencia, adCon)
            ds = New DataSet
            da.Fill(ds, "Entidades")
            TablaMostrar.DataSource = ds.Tables("Entidades").DefaultView.ToTable(False, "CodigoAsesor", "NombreAsesor", "PuestoAsesor")

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next



            TablaMostrar.DataSource = ds.Tables("entidades")
            TablaMostrar.Columns("CodigoAsesor").HeaderText = "Codigo"
            TablaMostrar.Columns("NombreAsesor").HeaderText = "Nombre"
            TablaMostrar.Columns("puestoAsesor").HeaderText = "Puesto"
            TablaMostrar.Columns("estatus").Visible = False

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
            Dim queryString As String = "call sp_AsesorIntBuscarNombre(?Nombre)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?Nombre", Nombre)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Ocultar columnas innecesarias
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                If column.Name <> "CodigoAsesor" AndAlso column.Name <> "NombreAsesor" AndAlso column.Name <> "PuestoAsesor" Then
                    column.Visible = False
                End If
            Next

            TablaMostrar.DataSource = table

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            TablaMostrar.Columns("CodigoAsesor").HeaderText = "Codigo"
            TablaMostrar.Columns("NombreAsesor").HeaderText = "Nombre"
            TablaMostrar.Columns("puestoAsesor").HeaderText = "Puesto"


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        buscarByNombre()
    End Sub

    Private Sub MostrarAsesorInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarRegistros()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub TablaMostrar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellContentClick

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub TablaMostrar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellClick

        If e.RowIndex >= 0 Then
            Dim buscar As String = TablaMostrar.Rows(e.RowIndex).Cells("CodigoAsesor").Value.ToString()
            Dim m As New Modelo
            Try
                adCon = New MySqlConnection(m.conexion)

                adCon.Open()

                Dim queryString As String = "call sp_AsesorIntBuscarId(?buscar)"
                Dim command As New MySqlCommand(queryString, adCon)
                command.Parameters.AddWithValue("?buscar", buscar)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                For Each row As DataRow In table.Rows
                    txtCodigo.Text = row(0).ToString()
                    txtNombre.Text = row(1).ToString()

                    txtPuesto.Text = row(2).ToString()
                    cbEstatus.SelectedItem = Est(row(3).ToString())

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