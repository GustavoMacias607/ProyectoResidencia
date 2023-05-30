Imports MySql.Data.MySqlClient
Public Class AgregarDictamen
    Dim adCon As MySqlConnection
    Dim adCon2 As MySqlConnection
    Dim sentencia As String
    Dim da As MySqlDataAdapter
    Dim ds
    Dim cmCon As MySqlCommand
    Dim cmCon2 As MySqlCommand
    Dim dictamenCell As DataGridViewComboBoxCell
    Private e As Object

    Private Sub mostrarRegistros()
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            sentencia = "call sp_MostrarSoliDic()"

            adCon.Open()
            da = New MySqlDataAdapter(sentencia, adCon)
            ds = New DataSet
            da.Fill(ds, "Entidades")
            TablaMostrar.DataSource = ds.Tables("Entidades")

            ' Agregar una columna de ComboBox para "dictamen"
            Dim dictamenColumn As New DataGridViewComboBoxColumn()
            dictamenColumn.Name = "dictamen"
            dictamenColumn.HeaderText = "Dictamen"
            dictamenColumn.Items.AddRange("Aceptado", "Rechazado")
            TablaMostrar.Columns.Add(dictamenColumn)

            TablaMostrar.DataSource = ds.Tables("Entidades").DefaultView.ToTable(False, "codigoS", "codigoP", "proyecto", "empresa", "alumno", "observaciones", "estatus")


            ' Ocultar la columna "estatus" si existe
            If TablaMostrar.Columns.Contains("estatus") Then
                TablaMostrar.Columns("estatus").Visible = False

            End If
            ' Ajustar el modo de ajuste automático de las columnas en Fill
            TablaMostrar.Columns("codigoS").Visible = False
            For Each column As DataGridViewColumn In TablaMostrar.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
            TablaMostrar.Columns("codigoP").HeaderText = "Codigo Proyecto"
            TablaMostrar.Columns("proyecto").HeaderText = "Proyecto"
            TablaMostrar.Columns("empresa").HeaderText = "Empresa"
            TablaMostrar.Columns("alumno").HeaderText = "Alumno"
            TablaMostrar.Columns("dictamen").HeaderText = "Dictamen"
            TablaMostrar.Columns("observaciones").HeaderText = "Observaciones"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub AgregarDictamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarRegistros()




    End Sub



    Private Sub TablaMostrar_SelectionChanged(sender As Object, e As EventArgs) Handles TablaMostrar.SelectionChanged

    End Sub

    Private Sub TablaMostrar_MouseLeave(sender As Object, e As EventArgs) Handles TablaMostrar.MouseLeave

    End Sub

    Private Sub cambio()


    End Sub

    Private Sub TablaMostrar_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMostrar.CellValueChanged
        Dim m As New Modelo
        adCon = New MySqlConnection(m.conexion)
        adCon.Open()
        adCon2 = New MySqlConnection(m.conexion)
        adCon2.Open()
        Try

            If e.RowIndex >= 0 Then
                Dim buscar As String = TablaMostrar.Rows(e.RowIndex).Cells("codigoS").Value.ToString()
                Try
                    Dim dictamen As String = TablaMostrar.Rows(e.RowIndex).Cells("dictamen").Value.ToString()
                    dic(buscar, dictamen)

                Catch ex As Exception
                End Try
                Dim observaciones As String = TablaMostrar.Rows(e.RowIndex).Cells("observaciones").Value.ToString()
                obse(buscar, observaciones)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
            adCon2.Close()
        End Try
    End Sub
    Private Sub obse(buscar As String, observaciones As String)
        Try


            txtObservaciones.Text = observaciones
            Dim sentencia As String = "call sp_ModificaObser(?pCodigo,?pObservaciones)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pCodigo", buscar)
            cmCon.Parameters.AddWithValue("?pObservaciones", observaciones)
            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Se modifico")
            LimpiarTabla()
            mostrarRegistros()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dic(buscar As String, dictamen As String)
        Try


            cbEstatus.SelectedItem = dictamen
            Dim sentencia As String = "call sp_ModificaEstatus(?pCodigo,?pEstatus)"
            cmCon2 = New MySqlCommand
            cmCon2.Connection = adCon2
            cmCon2.CommandType = CommandType.Text

            cmCon2.Parameters.Clear()
            cmCon2.Parameters.AddWithValue("?pCodigo", buscar)
            cmCon2.Parameters.AddWithValue("?pEstatus", comvEst(dictamen))

            cmCon2.CommandText = sentencia

            cmCon2.ExecuteNonQuery()
            MsgBox("Se modifico dictamen")
            LimpiarTabla()
            mostrarRegistros()
        Catch ex As Exception

        End Try
    End Sub
    Public Function comvEst(ByVal texto As String) As Integer


        If texto.Equals("Aceptado") Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Sub LimpiarTabla()
        ' Limpia el contenido y las columnas del DataGridView
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
            ds.Tables(0).Clear()
        End If

        TablaMostrar.Columns.Clear()
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
                    txtidProyecto.Text = row(16).ToString()
                    txtProyecto.Text = row(17).ToString()

                    txtObservaciones.Text = row(7).ToString()
                    cbEstatus.SelectedItem = Est(row(15).ToString())

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
            Return "Aceptado"
        Else
            Return "Rechazado"
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.Open()
            'convierte la fecha a año-mes-dia
            Dim fecha As DateTime = dtFecha.Value
            Dim fec As String = fecha.ToString("yyyy-MM-dd")
            Dim sentencia As String = "call sp_DictamenAgregar(?pCodigo,?pNombre,?pRevision,?pFecha,?pPro,?pVa,?pVo,?pRe,1)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pCodigo", txtCodigo.Text)
            cmCon.Parameters.AddWithValue("?pNombre", txtNombre.Text)
            cmCon.Parameters.AddWithValue("?pRevision", txtRevision.Text)
            cmCon.Parameters.AddWithValue("?pFecha", fec)
            cmCon.Parameters.AddWithValue("?pPro", txtFirPropone.Text)
            cmCon.Parameters.AddWithValue("?pVa", txtFirValida.Text)
            cmCon.Parameters.AddWithValue("?pVo", txtFirVo.Text)
            cmCon.Parameters.AddWithValue("?pRe", txtFirmaRecibe.Text)
            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()

            Dim sentencia2 As String = "call ModificarDicEnSoli(?pCodigoD)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pCodigoD", txtCodigo.Text)

            cmCon.CommandText = sentencia2
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
            mostrarRegistros()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()

        End Try
    End Sub

    Private Sub dtFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtFecha.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub txtPuesto_TextChanged(sender As Object, e As EventArgs) Handles txtPuesto.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class