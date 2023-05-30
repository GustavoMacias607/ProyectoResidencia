Imports MySql.Data.MySqlClient

Public Class AgregarAsignacion
    Dim adCon As MySqlConnection
    Dim sentencia As String
    Dim da As MySqlDataAdapter
    Dim ds
    Dim cmCon As MySqlCommand
    Private Sub mostrarRegistros()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            sentencia = "call sp_MostrarAsigCampos()"

            adCon.Open()
            da = New MySqlDataAdapter(sentencia, adCon)
            ds = New DataSet
            da.Fill(ds, "Entidades")
            TablaMostrar.DataSource = ds.Tables("Entidades").DefaultView.ToTable(False, "codigoS", "proyecto", "empresa", "alumno", "NombreAsesor")
            If TablaMostrar.Columns.Contains("codigoS") Then
                TablaMostrar.Columns("codigoS").Visible = False

            End If
            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            TablaMostrar.Columns("proyecto").HeaderText = "Proyecto"
            TablaMostrar.Columns("empresa").HeaderText = "Empresa"
            TablaMostrar.Columns("alumno").HeaderText = "Alumno"
            TablaMostrar.Columns("NombreAsesor").HeaderText = "Asesor Externo"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub
    Private Sub mostrarRegistrosAsesor()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            sentencia = "call sp_AsesorIntMostrar()"

            adCon.Open()
            da = New MySqlDataAdapter(sentencia, adCon)
            ds = New DataSet
            da.Fill(ds, "Entidades")
            TablaAsesorInter.DataSource = ds.Tables("Entidades").DefaultView.ToTable(False, "CodigoAsesor", "NombreAsesor")
            If TablaAsesorInter.Columns.Contains("CodigoAsesor") Then
                TablaAsesorInter.Columns("CodigoAsesor").Visible = False

            End If
            ' Establecer el modo de ajuste automático de las columnas en Fill
            For Each column As DataGridViewColumn In TablaAsesorInter.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            TablaAsesorInter.Columns("NombreAsesor").HeaderText = "Asesor Interno"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub AgregarAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarRegistros()
        mostrarRegistrosAsesor()
    End Sub

    Private Sub TablaMostrar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellClick
        If e.RowIndex >= 0 Then
            Dim codigo As String = TablaMostrar.Rows(e.RowIndex).Cells("codigoS").Value.ToString()
            Dim m As New Modelo
            Try
                adCon = New MySqlConnection(m.conexion)

                adCon.Open()

                Dim queryString As String = "call sp_BuscarAsigCampos(?codigo)"
                Dim command As New MySqlCommand(queryString, adCon)
                command.Parameters.AddWithValue("?codigo", codigo)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                For Each row As DataRow In table.Rows
                    txtNoControl.Text = row(0).ToString()
                    dtFechaSoli.Text = row(1).ToString()
                    txtIdProyecto.Text = row(2).ToString()
                    txtProyecto.Text = row(3).ToString()
                    txtEmpresa.Text = row(4).ToString()
                    txtNoControl.Text = row(5).ToString()
                    txtAlumno.Text = row(6).ToString()
                    txtAsesorExterno.Text = row(7).ToString()
                    txtCodigoSolicitud.Text = row(0).ToString()
                Next


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                adCon.Close()
            End Try
        End If
    End Sub

    Private Sub TablaAsesorInter_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaAsesorInter.CellClick
        If e.RowIndex >= 0 Then
            Dim codigo As String = TablaAsesorInter.Rows(e.RowIndex).Cells("CodigoAsesor").Value.ToString()
            Dim m As New Modelo
            Try
                adCon = New MySqlConnection(m.conexion)

                adCon.Open()

                Dim queryString As String = "call sp_AsesorIntBuscarId(?codigo)"
                Dim command As New MySqlCommand(queryString, adCon)
                command.Parameters.AddWithValue("?codigo", codigo)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                For Each row As DataRow In table.Rows
                    txtIdAsesorInterno.Text = row(0).ToString()
                    txtAsesorInterno.Text = row(1).ToString()

                Next


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                adCon.Close()
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.Open()
            Dim sentencia As String = "call sp_AsignacionAgregar(?pNombre,?pRevision,?pDepartamento,?pNoOficio,?pAsunto,?pLugar,?pCodigoS,?pCodigoInterno,1)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()

            cmCon.Parameters.AddWithValue("?pNombre", txtNombreAsig.Text)
            cmCon.Parameters.AddWithValue("?pRevision", txtRevision.Text)
            cmCon.Parameters.AddWithValue("?pDepartamento", txtDepartamento.Text)
            cmCon.Parameters.AddWithValue("?pNoOficio", txtOficio.Text)
            cmCon.Parameters.AddWithValue("?pAsunto", txtAsunto.Text)
            cmCon.Parameters.AddWithValue("?pLugar", txtLugar.Text)
            cmCon.Parameters.AddWithValue("?pCodigoS", txtCodigoSolicitud.Text)
            cmCon.Parameters.AddWithValue("?pCodigoInterno", txtIdAsesorInterno.Text)
            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
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
End Class