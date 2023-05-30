Imports MySql.Data.MySqlClient
Public Class MostrarDictamen
    Dim adCon As MySqlConnection
    Dim sentencia As String
    Dim da As MySqlDataAdapter
    Dim ds
    Dim cmCon As MySqlCommand


    Private Sub mostrarRegistros()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            sentencia = "call sp_DictamenMostrar()"

            adCon.Open()
            da = New MySqlDataAdapter(sentencia, adCon)
            ds = New DataSet
            da.Fill(ds, "Entidades")
            TablaMostrar.DataSource = ds.Tables("Entidades").DefaultView.ToTable(False, "codigoDic", "nombre", "fecha")

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            TablaMostrar.Columns("codigoDic").HeaderText = "Codigo"
            TablaMostrar.Columns("nombre").HeaderText = "Nombre"
            TablaMostrar.Columns("fecha").HeaderText = "Fecha"

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
            Dim queryString As String = "call sp_DictamenBuscarNombre(?Nombre)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?Nombre", Nombre)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Ocultar columnas innecesarias
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                If column.Name <> "codigoDic" AndAlso column.Name <> "nombre" AndAlso column.Name <> "fecha" Then
                    column.Visible = False
                End If
            Next

            TablaMostrar.DataSource = table

            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
            TablaMostrar.Columns("codigoDic").HeaderText = "Codigo"
            TablaMostrar.Columns("nombre").HeaderText = "Nombre"
            TablaMostrar.Columns("fecha").HeaderText = "Fecha"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try

    End Sub

    Public Function Est(ByVal valor As Integer) As String
        If valor.Equals(1) Then
            Return "Activo"
        Else
            Return "Inactivo"
        End If
    End Function

    Private Sub TablaMostrar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellClick
        If e.RowIndex >= 0 Then
            Dim codigo As String = TablaMostrar.Rows(e.RowIndex).Cells("codigoDic").Value.ToString()
            Dim m As New Modelo
            Try
                adCon = New MySqlConnection(m.conexion)

                adCon.Open()

                Dim queryString As String = "call sp_DictamenBuscarId(?codigo)"
                Dim command As New MySqlCommand(queryString, adCon)
                command.Parameters.AddWithValue("?codigo", codigo)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                For Each row As DataRow In table.Rows
                    txtCodigo.Text = row(0).ToString()
                    txtNombre.Text = row(1).ToString()
                    txtRevision.Text = row(2).ToString()
                    dtFecha.Text = row(3).ToString()
                    txtFirPropone.Text = row(4).ToString()
                    txtFirValida.Text = row(5).ToString()
                    txtFirVo.Text = row(6).ToString()
                    txtFirmaRecibe.Text = row(7).ToString()
                    txtEstatus.Text = Est(row(8).ToString())


                Next


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                adCon.Close()
            End Try
        End If
    End Sub

    Private Sub MostrarDictamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarRegistros()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        buscarByNombre()
    End Sub

    Private Sub txtNombre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyUp
        buscarByNombre()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class