﻿Imports MySql.Data.MySqlClient
Public Class AgregarResidente
    Dim adCon
    Dim cmCon As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Modelo
        Try
            adCon = New MySqlConnection(m.conexion)
            adCon.open()
            Dim sentencia As String = "call sp_ResidenteAgregar(?pNoControl,?pNombre,?pCarrera,?pDomicilio,?pEmail,?pCiudad,?pTelefono,?pSeguridadSocial,?pNoSeguridad,1)"
            cmCon = New MySqlCommand
            cmCon.Connection = adCon
            cmCon.CommandType = CommandType.Text
            cmCon.Parameters.Clear()
            cmCon.Parameters.AddWithValue("?pNoControl", txtNoControl.Text)
            cmCon.Parameters.AddWithValue("?pNombre", txtNombre.Text)
            cmCon.Parameters.AddWithValue("?pCarrera", txtCarrera.Text)
            cmCon.Parameters.AddWithValue("?pDomicilio", txtDomicilio.Text)
            cmCon.Parameters.AddWithValue("?pEmail", txtEmail.Text)
            cmCon.Parameters.AddWithValue("?pCiudad", txtCiudad.Text)
            cmCon.Parameters.AddWithValue("?pTelefono", txtTelefono.Text)
            cmCon.Parameters.AddWithValue("?pSeguridadSocial", txtxSeguridadSocial.Text)
            cmCon.Parameters.AddWithValue("?pNoSeguridad", txtNoSeguridad.Text)
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
    Private Sub AgregarEmpresa_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgregarResidente_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class