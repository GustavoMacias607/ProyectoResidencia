<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarAsesorExterno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarAsesorExterno))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscarExt = New System.Windows.Forms.Button()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtCodigoExt = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cbEstatus = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnBuscarEmp = New System.Windows.Forms.Button()
        Me.txtCiudadEm = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtTelefonoEm = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtNombreEm = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(385, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(697, 96)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MODIFICAR ASESOR EXTERNO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(936, 748)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 60)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1132, 748)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 60)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Regresar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(173, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 29)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(173, 242)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 29)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Puesto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(298, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(455, 29)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "__________________________________"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombre.Location = New System.Drawing.Point(298, 149)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(443, 27)
        Me.txtNombre.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(275, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(273, 29)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "____________________"
        '
        'txtPuesto
        '
        Me.txtPuesto.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPuesto.Location = New System.Drawing.Point(275, 242)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(273, 27)
        Me.txtPuesto.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnBuscarExt)
        Me.Panel1.Controls.Add(Me.Label55)
        Me.Panel1.Controls.Add(Me.txtCodigoExt)
        Me.Panel1.Controls.Add(Me.Label56)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.cbEstatus)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtPuesto)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(102, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 558)
        Me.Panel1.TabIndex = 4
        '
        'btnBuscarExt
        '
        Me.btnBuscarExt.BackgroundImage = CType(resources.GetObject("btnBuscarExt.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarExt.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBuscarExt.FlatAppearance.BorderSize = 0
        Me.btnBuscarExt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBuscarExt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscarExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarExt.Location = New System.Drawing.Point(484, 19)
        Me.btnBuscarExt.Name = "btnBuscarExt"
        Me.btnBuscarExt.Size = New System.Drawing.Size(48, 48)
        Me.btnBuscarExt.TabIndex = 76
        Me.btnBuscarExt.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label55.Location = New System.Drawing.Point(173, 62)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(98, 29)
        Me.Label55.TabIndex = 73
        Me.Label55.Text = "Codigo:"
        '
        'txtCodigoExt
        '
        Me.txtCodigoExt.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtCodigoExt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCodigoExt.Location = New System.Drawing.Point(288, 60)
        Me.txtCodigoExt.Name = "txtCodigoExt"
        Me.txtCodigoExt.Size = New System.Drawing.Size(206, 27)
        Me.txtCodigoExt.TabIndex = 74
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label56.Location = New System.Drawing.Point(288, 65)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(208, 29)
        Me.Label56.TabIndex = 75
        Me.Label56.Text = "_______________"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label34.Location = New System.Drawing.Point(665, 247)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(97, 29)
        Me.Label34.TabIndex = 72
        Me.Label34.Text = "Estatus:"
        '
        'cbEstatus
        '
        Me.cbEstatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbEstatus.FormattingEnabled = True
        Me.cbEstatus.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cbEstatus.Location = New System.Drawing.Point(768, 244)
        Me.cbEstatus.Name = "cbEstatus"
        Me.cbEstatus.Size = New System.Drawing.Size(202, 36)
        Me.cbEstatus.TabIndex = 71
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(1094, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 92)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "Examinar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btnBuscarEmp)
        Me.Panel4.Controls.Add(Me.txtCiudadEm)
        Me.Panel4.Controls.Add(Me.Label47)
        Me.Panel4.Controls.Add(Me.txtTelefonoEm)
        Me.Panel4.Controls.Add(Me.Label48)
        Me.Panel4.Controls.Add(Me.Label49)
        Me.Panel4.Controls.Add(Me.Label50)
        Me.Panel4.Controls.Add(Me.txtNombreEm)
        Me.Panel4.Controls.Add(Me.Label35)
        Me.Panel4.Controls.Add(Me.Label43)
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Controls.Add(Me.txtRFC)
        Me.Panel4.Controls.Add(Me.Label46)
        Me.Panel4.Location = New System.Drawing.Point(68, 417)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1102, 235)
        Me.Panel4.TabIndex = 62
        '
        'btnBuscarEmp
        '
        Me.btnBuscarEmp.BackgroundImage = CType(resources.GetObject("btnBuscarEmp.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarEmp.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBuscarEmp.FlatAppearance.BorderSize = 0
        Me.btnBuscarEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBuscarEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarEmp.Location = New System.Drawing.Point(345, 20)
        Me.btnBuscarEmp.Name = "btnBuscarEmp"
        Me.btnBuscarEmp.Size = New System.Drawing.Size(48, 48)
        Me.btnBuscarEmp.TabIndex = 48
        Me.btnBuscarEmp.UseVisualStyleBackColor = True
        '
        'txtCiudadEm
        '
        Me.txtCiudadEm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCiudadEm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCiudadEm.Enabled = False
        Me.txtCiudadEm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCiudadEm.Location = New System.Drawing.Point(212, 147)
        Me.txtCiudadEm.Name = "txtCiudadEm"
        Me.txtCiudadEm.Size = New System.Drawing.Size(338, 27)
        Me.txtCiudadEm.TabIndex = 36
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label47.Location = New System.Drawing.Point(212, 152)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(351, 29)
        Me.Label47.TabIndex = 41
        Me.Label47.Text = "__________________________"
        '
        'txtTelefonoEm
        '
        Me.txtTelefonoEm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTelefonoEm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefonoEm.Enabled = False
        Me.txtTelefonoEm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTelefonoEm.Location = New System.Drawing.Point(757, 147)
        Me.txtTelefonoEm.Name = "txtTelefonoEm"
        Me.txtTelefonoEm.Size = New System.Drawing.Size(247, 27)
        Me.txtTelefonoEm.TabIndex = 38
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label48.Location = New System.Drawing.Point(757, 152)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(247, 29)
        Me.Label48.TabIndex = 40
        Me.Label48.Text = "__________________"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label49.Location = New System.Drawing.Point(635, 152)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(116, 29)
        Me.Label49.TabIndex = 39
        Me.Label49.Text = "Telefono:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label50.Location = New System.Drawing.Point(100, 147)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(96, 29)
        Me.Label50.TabIndex = 37
        Me.Label50.Text = "Ciudad:"
        '
        'txtNombreEm
        '
        Me.txtNombreEm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNombreEm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreEm.Enabled = False
        Me.txtNombreEm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombreEm.Location = New System.Drawing.Point(512, 66)
        Me.txtNombreEm.Name = "txtNombreEm"
        Me.txtNombreEm.Size = New System.Drawing.Size(440, 27)
        Me.txtNombreEm.TabIndex = 26
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label35.Location = New System.Drawing.Point(512, 71)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(455, 29)
        Me.Label35.TabIndex = 31
        Me.Label35.Text = "__________________________________"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label43.Location = New System.Drawing.Point(399, 66)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(107, 29)
        Me.Label43.TabIndex = 29
        Me.Label43.Text = "Nombre:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label44.Location = New System.Drawing.Point(96, 66)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(68, 29)
        Me.Label44.TabIndex = 24
        Me.Label44.Text = "RFC:"
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRFC.Location = New System.Drawing.Point(170, 66)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(195, 27)
        Me.txtRFC.TabIndex = 25
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label46.Location = New System.Drawing.Point(170, 71)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(208, 29)
        Me.Label46.TabIndex = 28
        Me.Label46.Text = "_______________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(531, 335)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(195, 51)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Empresa"
        '
        'ModificarAsesorExterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMargin = New System.Drawing.Size(1000, 0)
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1448, 820)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificarAsesorExterno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnBuscarEmp As Button
    Friend WithEvents txtCiudadEm As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtTelefonoEm As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents txtNombreEm As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents cbEstatus As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents btnBuscarExt As Button
    Friend WithEvents Label55 As Label
    Friend WithEvents txtCodigoExt As TextBox
    Friend WithEvents Label56 As Label
End Class
