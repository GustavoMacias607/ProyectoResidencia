Imports MySql.Data.MySqlClient

Public Class MostrarAsignacion
    Dim adCon As MySqlConnection
    Dim sentencia As String
    Dim da As MySqlDataAdapter
    Dim ds
    Dim cmCon As MySqlCommand


    Private Sub mostrarRegistros()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            sentencia = "call sp_AsignacionMostrar()"

            adCon.Open()
            da = New MySqlDataAdapter(sentencia, adCon)
            ds = New DataSet
            da.Fill(ds, "Entidades")
            TablaMostrar.DataSource = ds.Tables("Entidades").DefaultView.ToTable(False, "idAsignacion", "nombre", "noOficio")

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            TablaMostrar.Columns("idAsignacion").HeaderText = "Id Asignacion"
            TablaMostrar.Columns("nombre").HeaderText = "Nombre"
            TablaMostrar.Columns("noOficio").HeaderText = "No. Oficio"

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
            Dim Nombre As String = txtOficio.Text.Trim()
            Dim queryString As String = "call sp_AsignacionBuscarNoOficio(?Nombre)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?Nombre", Nombre)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Ocultar columnas innecesarias
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                If column.Name <> "idAsignacion" AndAlso column.Name <> "nombre" AndAlso column.Name <> "noOficio" AndAlso column.Name <> "telefono" Then
                    column.Visible = False
                End If
            Next

            TablaMostrar.DataSource = table

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            TablaMostrar.Columns("idAsignacion").HeaderText = "Id Asignacion"
            TablaMostrar.Columns("nombre").HeaderText = "Nombre"
            TablaMostrar.Columns("noOficio").HeaderText = "No. Oficio"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtOficio_TextChanged(sender As Object, e As EventArgs) Handles txtOficio.TextChanged

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub txtOficio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOficio.KeyPress
        buscarByNombre()
    End Sub

    Private Sub txtOficio_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOficio.KeyUp
        buscarByNombre()
    End Sub

    Private Sub MostrarAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarRegistros()
    End Sub

    Private Sub TablaMostrar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellClick
        If e.RowIndex >= 0 Then
            Dim buscar As String = TablaMostrar.Rows(e.RowIndex).Cells("idAsignacion").Value.ToString()
            Dim m As New Modelo
            Try
                adCon = New MySqlConnection(m.conexion)

                adCon.Open()

                Dim queryString As String = "call sp_AsignacionBuscarId(?buscar)"
                Dim command As New MySqlCommand(queryString, adCon)
                command.Parameters.AddWithValue("?buscar", buscar)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                For Each row As DataRow In table.Rows
                    txtIdAsignacion.Text = row(0).ToString()
                    txtNombreAsig.Text = row(1).ToString()
                    txtAsunto.Text = row(5).ToString()
                    txtOficio.Text = row(4).ToString()
                    txtLugar.Text = row(6).ToString()
                    txtDepartamento.Text = row(3).ToString()
                    txtRevision.Text = row(2).ToString()
                    txtIdAsesorInterno.Text = row(9).ToString()
                    txtCodigoSolicitud.Text = row(7).ToString()
                    txtEstatus.Text = Est(row(8).ToString())

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class