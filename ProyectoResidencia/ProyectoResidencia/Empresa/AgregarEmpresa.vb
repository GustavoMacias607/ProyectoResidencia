Imports MySql.Data.MySqlClient
Public Class AgregarEmpresa
    Dim adCon
    Dim cmCon As MySqlCommand
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_EmpresaAgregar(?pRFC,?pNombre,?pSector,?pDomicilio,?pColonia,?pCiudad,?pMision,?pCP,?pFax,?pTelefono,?pTitular,?pPuesto,?pFirma,1)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()

            cmCon.Parameters.AddWithValue("?pRFC", txtRFC.Text)
            cmCon.Parameters.AddWithValue("?pNombre", txtNombre.Text)
            cmCon.Parameters.AddWithValue("?pSector", txtSector.Text)
            cmCon.Parameters.AddWithValue("?pDomicilio", txtDomicilio.Text)
            cmCon.Parameters.AddWithValue("?pColonia", txtColonia.Text)
            cmCon.Parameters.AddWithValue("?pCiudad", txtCiudad.Text)
            cmCon.Parameters.AddWithValue("?pMision", txtMision.Text)
            cmCon.Parameters.AddWithValue("?pCP", txtCP.Text)
            cmCon.Parameters.AddWithValue("?pFax", txtFax.Text)
            cmCon.Parameters.AddWithValue("?pTelefono", txtTelefono.Text)
            cmCon.Parameters.AddWithValue("?pTitular", txtTitular.Text)
            cmCon.Parameters.AddWithValue("?pPuesto", txtPuesto.Text)
            cmCon.Parameters.AddWithValue("?pFirma", cbFirma.Checked)
            cmCon.CommandText = sentencia
            cmCon.ExecuteNonQuery()
            MsgBox("Datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.close()

        End Try
    End Sub

    Private Sub AgregarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class