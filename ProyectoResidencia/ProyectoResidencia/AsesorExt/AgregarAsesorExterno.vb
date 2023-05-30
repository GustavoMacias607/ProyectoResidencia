Imports MySql.Data.MySqlClient
Public Class AgregarAsesorExterno
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_AsesorExtAgregar(?pNombre,?pPuesto,?pRFC,1)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()

            cmCon.Parameters.AddWithValue("?pNombre", txtNombre.Text)
            cmCon.Parameters.AddWithValue("?pPuesto", txtPuesto.Text)
            cmCon.Parameters.AddWithValue("?pRFC", txtRFC.Text)
            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.close()

        End Try
    End Sub

    Private Sub btnBuscarEmp_Click(sender As Object, e As EventArgs) Handles btnBuscarEmp.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)

            adCon.Open()
            Dim RFC As String = txtRFC.Text.Trim()
            Dim queryString As String = "call sp_EmpresaBuscarId(?RFC)"
            Dim command As New MySqlCommand(queryString, adCon)
            command.Parameters.AddWithValue("?RFC", RFC)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            For Each row As DataRow In table.Rows
                txtRFC.Text = row(0).ToString()
                txtNombreEm.Text = row(1).ToString()
                txtCiudadEm.Text = row(5).ToString()
                txtTelefonoEm.Text = row(9).ToString()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub AgregarAsesorExterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class