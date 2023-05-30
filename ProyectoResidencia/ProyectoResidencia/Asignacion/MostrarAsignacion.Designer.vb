<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostrarAsignacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MostrarAsignacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombreAsig = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdAsignacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCodigoSolicitud = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtOficio = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtRevision = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdAsesorInterno = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TablaMostrar = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.TablaMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(369, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(645, 96)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MOSTRAR ASIGNACION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1238, 722)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 50)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Regresar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtNombreAsig)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtIdAsignacion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtEstatus)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtCodigoSolicitud)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.txtDepartamento)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.txtLugar)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.txtOficio)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.txtRevision)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtAsunto)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtIdAsesorInterno)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TablaMostrar)
        Me.Panel1.Location = New System.Drawing.Point(47, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1353, 555)
        Me.Panel1.TabIndex = 4
        '
        'txtNombreAsig
        '
        Me.txtNombreAsig.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreAsig.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreAsig.Enabled = False
        Me.txtNombreAsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombreAsig.Location = New System.Drawing.Point(833, 248)
        Me.txtNombreAsig.Name = "txtNombreAsig"
        Me.txtNombreAsig.Size = New System.Drawing.Size(351, 27)
        Me.txtNombreAsig.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(720, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 29)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Id Asignacion:"
        '
        'txtIdAsignacion
        '
        Me.txtIdAsignacion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtIdAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdAsignacion.Enabled = False
        Me.txtIdAsignacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtIdAsignacion.Location = New System.Drawing.Point(889, 103)
        Me.txtIdAsignacion.Name = "txtIdAsignacion"
        Me.txtIdAsignacion.Size = New System.Drawing.Size(91, 27)
        Me.txtIdAsignacion.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(889, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 29)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "______"
        '
        'txtEstatus
        '
        Me.txtEstatus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEstatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstatus.Enabled = False
        Me.txtEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEstatus.Location = New System.Drawing.Point(1105, 457)
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.Size = New System.Drawing.Size(143, 27)
        Me.txtEstatus.TabIndex = 156
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(1105, 462)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 29)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "__________"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label34.Location = New System.Drawing.Point(1003, 455)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(97, 29)
        Me.Label34.TabIndex = 155
        Me.Label34.Text = "Estatus:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(80, 508)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 29)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "Codigo Solicitud:"
        '
        'txtCodigoSolicitud
        '
        Me.txtCodigoSolicitud.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtCodigoSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoSolicitud.Enabled = False
        Me.txtCodigoSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCodigoSolicitud.Location = New System.Drawing.Point(283, 508)
        Me.txtCodigoSolicitud.Name = "txtCodigoSolicitud"
        Me.txtCodigoSolicitud.Size = New System.Drawing.Size(273, 27)
        Me.txtCodigoSolicitud.TabIndex = 152
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(283, 513)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(273, 29)
        Me.Label12.TabIndex = 153
        Me.Label12.Text = "____________________"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label27.Location = New System.Drawing.Point(720, 376)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(171, 29)
        Me.Label27.TabIndex = 151
        Me.Label27.Text = "Departamento:"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDepartamento.Enabled = False
        Me.txtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDepartamento.Location = New System.Drawing.Point(900, 376)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(351, 27)
        Me.txtDepartamento.TabIndex = 149
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label28.Location = New System.Drawing.Point(900, 381)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(351, 29)
        Me.Label28.TabIndex = 150
        Me.Label28.Text = "__________________________"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label29.Location = New System.Drawing.Point(720, 310)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 29)
        Me.Label29.TabIndex = 148
        Me.Label29.Text = "Lugar:"
        '
        'txtLugar
        '
        Me.txtLugar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtLugar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLugar.Enabled = False
        Me.txtLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLugar.Location = New System.Drawing.Point(806, 312)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(351, 27)
        Me.txtLugar.TabIndex = 146
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label30.Location = New System.Drawing.Point(806, 317)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(351, 29)
        Me.Label30.TabIndex = 147
        Me.Label30.Text = "__________________________"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label23.Location = New System.Drawing.Point(720, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 29)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "No. Oficio:"
        '
        'txtOficio
        '
        Me.txtOficio.BackColor = System.Drawing.Color.White
        Me.txtOficio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOficio.Location = New System.Drawing.Point(852, 30)
        Me.txtOficio.Name = "txtOficio"
        Me.txtOficio.Size = New System.Drawing.Size(351, 34)
        Me.txtOficio.TabIndex = 143
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label24.Location = New System.Drawing.Point(833, 251)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(351, 29)
        Me.Label24.TabIndex = 144
        Me.Label24.Text = "__________________________"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label25.Location = New System.Drawing.Point(720, 450)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 29)
        Me.Label25.TabIndex = 142
        Me.Label25.Text = "Revision:"
        '
        'txtRevision
        '
        Me.txtRevision.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtRevision.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRevision.Enabled = False
        Me.txtRevision.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRevision.Location = New System.Drawing.Point(845, 450)
        Me.txtRevision.Name = "txtRevision"
        Me.txtRevision.Size = New System.Drawing.Size(104, 27)
        Me.txtRevision.TabIndex = 140
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label26.Location = New System.Drawing.Point(845, 455)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 29)
        Me.Label26.TabIndex = 141
        Me.Label26.Text = "_______"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(720, 179)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 29)
        Me.Label16.TabIndex = 139
        Me.Label16.Text = "Asunto:"
        '
        'txtAsunto
        '
        Me.txtAsunto.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAsunto.Enabled = False
        Me.txtAsunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAsunto.Location = New System.Drawing.Point(827, 179)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(351, 27)
        Me.txtAsunto.TabIndex = 137
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label22.Location = New System.Drawing.Point(827, 184)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(351, 29)
        Me.Label22.TabIndex = 138
        Me.Label22.Text = "__________________________"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(720, 248)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 29)
        Me.Label20.TabIndex = 135
        Me.Label20.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(77, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 29)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Id Asesor Interno:"
        '
        'txtIdAsesorInterno
        '
        Me.txtIdAsesorInterno.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtIdAsesorInterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdAsesorInterno.Enabled = False
        Me.txtIdAsesorInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtIdAsesorInterno.Location = New System.Drawing.Point(280, 442)
        Me.txtIdAsesorInterno.Name = "txtIdAsesorInterno"
        Me.txtIdAsesorInterno.Size = New System.Drawing.Size(143, 27)
        Me.txtIdAsesorInterno.TabIndex = 121
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(280, 447)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 29)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "__________"
        '
        'TablaMostrar
        '
        Me.TablaMostrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablaMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TablaMostrar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaMostrar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TablaMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaMostrar.DefaultCellStyle = DataGridViewCellStyle2
        Me.TablaMostrar.Location = New System.Drawing.Point(77, 43)
        Me.TablaMostrar.MaximumSize = New System.Drawing.Size(600, 369)
        Me.TablaMostrar.MinimumSize = New System.Drawing.Size(600, 369)
        Me.TablaMostrar.MultiSelect = False
        Me.TablaMostrar.Name = "TablaMostrar"
        Me.TablaMostrar.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaMostrar.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TablaMostrar.RowHeadersWidth = 51
        Me.TablaMostrar.RowTemplate.Height = 29
        Me.TablaMostrar.Size = New System.Drawing.Size(600, 369)
        Me.TablaMostrar.TabIndex = 0
        '
        'MostrarAsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMargin = New System.Drawing.Size(1000, 0)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1430, 773)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MostrarAsignacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TablaMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TablaMostrar As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents txtNombreAsig As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdAsesorInterno As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtOficio As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtRevision As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCodigoSolicitud As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdAsignacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEstatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label34 As Label
End Class
