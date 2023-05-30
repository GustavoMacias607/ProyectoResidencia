

Public Class MenuPrincipal

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidenSubmenu()
    End Sub

    Private Sub hidenSubmenu()
        PanelResidenteSubMenu.Visible = False
        PanelAsignacionSubMenu.Visible = False
        PanelCalificacionesSubMenu.Visible = False
        PanelProyectoSubMenu.Visible = False
        PanelSolicitudSubMenu.Visible = False
        PanelAsesorExtSubMenu.Visible = False
        PanelAsesorIntSubMenu.Visible = False
        PanelDictamenSubMenu.Visible = False
        PanelEmpresaSubMenu.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidenSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnSolicitud_Click(sender As Object, e As EventArgs) Handles btnSolicitud.Click
        showSubmenu(PanelSolicitudSubMenu)
    End Sub

    Private Sub btnAsignacion_Click(sender As Object, e As EventArgs) Handles btnAsignacion.Click
        showSubmenu(PanelAsignacionSubMenu)
    End Sub

    Private Sub btnResidente_Click(sender As Object, e As EventArgs) Handles btnResidente.Click
        showSubmenu(PanelResidenteSubMenu)
    End Sub

    Private Sub btnCalificaciones_Click(sender As Object, e As EventArgs) Handles btnCalificaciones.Click
        showSubmenu(PanelCalificacionesSubMenu)
    End Sub

    Private Sub btnProyecto_Click(sender As Object, e As EventArgs) Handles btnProyecto.Click
        showSubmenu(PanelProyectoSubMenu)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openChildForm(New AgregarSolicitud())


        hidenSubmenu()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        openChildForm(New MostrarSolicitud())
        hidenSubmenu()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        openChildForm(New EliminarSolicitud())
        hidenSubmenu()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        openChildForm(New ModificarSolicitud())
        hidenSubmenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        openChildForm(New AgregarAsignacion())
        hidenSubmenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        openChildForm(New MostrarAsignacion())
        hidenSubmenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        hidenSubmenu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hidenSubmenu()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        openChildForm(New AgregarResidente())
        hidenSubmenu()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        openChildForm(New MostrarResidente())
        hidenSubmenu()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        openChildForm(New EliminarResidente())
        hidenSubmenu()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        openChildForm(New ModificarResidentes())
        hidenSubmenu()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        hidenSubmenu()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        hidenSubmenu()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        hidenSubmenu()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        hidenSubmenu()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        hidenSubmenu()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        openChildForm(New MostrarProyecto())
        hidenSubmenu()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        openChildForm(New EliminarProyecto())
        hidenSubmenu()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        openChildForm(New ModificarProyecto())
        hidenSubmenu()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelHijos.Controls.Add(childForm)
        PanelHijos.Tag = childForm
        childForm.BringToFront()

        childForm.Show()
    End Sub

    Private Sub btnDictamen_Click(sender As Object, e As EventArgs) Handles btnDictamen.Click
        showSubmenu(PanelDictamenSubMenu)
    End Sub

    Private Sub btnAsesorInt_Click(sender As Object, e As EventArgs) Handles btnAsesorInt.Click
        showSubmenu(PanelAsesorIntSubMenu)
    End Sub

    Private Sub btnAsesorExt_Click(sender As Object, e As EventArgs) Handles btnAsesorExt.Click
        showSubmenu(PanelAsesorExtSubMenu)
    End Sub

    Private Sub btnEmpresa_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
        showSubmenu(PanelEmpresaSubMenu)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        openChildForm(New AgregarEmpresa())


        hidenSubmenu()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        openChildForm(New MostrarEmpresa())
        hidenSubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        openChildForm(New EliminarEmpresa())
        hidenSubmenu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New ModificarEmpresa())
        hidenSubmenu()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        openChildForm(New AgregarDictamen())
        hidenSubmenu()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        openChildForm(New MostrarDictamen())
        hidenSubmenu()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        hidenSubmenu()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        hidenSubmenu()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        openChildForm(New AgregarAsesorInterno())
        hidenSubmenu()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        openChildForm(New MostrarAsesorInterno())
        hidenSubmenu()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        openChildForm(New EliminarAsesorInterno())
        hidenSubmenu()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        openChildForm(New ModificarAsesorInterno())
        hidenSubmenu()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        openChildForm(New AgregarAsesorExterno())
        hidenSubmenu()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        openChildForm(New MostrarAsesorExterno())
        hidenSubmenu()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        openChildForm(New EliminarAsesorExterno())
        hidenSubmenu()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        openChildForm(New ModificarAsesorExterno())
        hidenSubmenu()
    End Sub

    Private Sub PanelDictamenSubMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelDictamenSubMenu.Paint

    End Sub

    Private Sub PanelHijos_Paint(sender As Object, e As PaintEventArgs) Handles PanelHijos.Paint

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class
