Imports MySql.Data.MySqlClient
Public Class ModificarAsesorInterno
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()
            Dim Codigo As String = txtCodigo.Text.Trim()
            Dim queryString As String = "call sp_AsesorIntBuscarId(?Codigo)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?Codigo", Codigo)
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
    End Sub
    Public Function Est(ByVal valor As Integer) As String
        If valor.Equals(1) Then
            Return "Activo"
        Else
            Return "Inactivo"
        End If
    End Function
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_AsesorIntModificar(?pId,?pNombre,?pPuesto,?pEstatus)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()

            cmCon.Parameters.AddWithValue("?pId", txtCodigo.Text)
            cmCon.Parameters.AddWithValue("?pNombre", txtNombre.Text)
            cmCon.Parameters.AddWithValue("?pPuesto", txtPuesto.Text)
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
    Public Function comvEst(ByVal texto As String) As Integer


        If texto.Equals("Activo") Then
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