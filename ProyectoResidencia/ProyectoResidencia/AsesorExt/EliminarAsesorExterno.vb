Imports MySql.Data.MySqlClient
Public Class EliminarAsesorExterno
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub btnBuscarExt_Click(sender As Object, e As EventArgs) Handles btnBuscarExt.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()
            Dim Externo As String = txtCodigoExt.Text.Trim()
            Dim queryString As String = "call sp_AsesorExtBuscarId(?Externo)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?Externo", Externo)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            For Each row As DataRow In table.Rows

                txtNombre.Text = row(1).ToString()
                txtPuesto.Text = row(2).ToString()
                cbEstatus.SelectedItem = Est(row(3).ToString())
                txtRFC.Text = row(4).ToString()
                txtNombreEm.Text = row(5).ToString()
                txtCiudadEm.Text = row(9).ToString()
                txtTelefonoEm.Text = row(13).ToString()

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_AsesorExtDelete(?pCodigo)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()

            cmCon.Parameters.AddWithValue("?pCodigo", txtCodigoExt.Text)



            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class