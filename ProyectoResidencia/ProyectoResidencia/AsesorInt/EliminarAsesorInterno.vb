Imports MySql.Data.MySqlClient
Public Class EliminarAsesorInterno
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub EliminarAsesorInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Dim sentencia As String = "call sp_AsesorIntDelete(?pid)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pid", txtCodigo.Text)
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

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
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
End Class