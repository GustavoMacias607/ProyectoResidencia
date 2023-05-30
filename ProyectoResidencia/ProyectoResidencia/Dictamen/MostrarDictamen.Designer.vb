<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostrarDictamen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MostrarDictamen))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFirValida = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtFirPropone = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtFirVo = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtFirmaRecibe = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRevision = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(440, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(645, 96)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MOSTRAR DICTAMEN"
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
        Me.Panel1.Controls.Add(Me.txtEstatus)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtFirValida)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtFirPropone)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.txtFirVo)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.txtFirmaRecibe)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtRevision)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dtFecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtPuesto)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TablaMostrar)
        Me.Panel1.Location = New System.Drawing.Point(47, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1353, 555)
        Me.Panel1.TabIndex = 4
        '
        'txtEstatus
        '
        Me.txtEstatus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEstatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstatus.Enabled = False
        Me.txtEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEstatus.Location = New System.Drawing.Point(1197, 311)
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.Size = New System.Drawing.Size(143, 27)
        Me.txtEstatus.TabIndex = 158
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(1197, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 29)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "__________"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label34.Location = New System.Drawing.Point(1095, 309)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(97, 29)
        Me.Label34.TabIndex = 157
        Me.Label34.Text = "Estatus:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCodigo.Location = New System.Drawing.Point(971, 162)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(278, 27)
        Me.txtCodigo.TabIndex = 154
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(971, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(286, 29)
        Me.Label11.TabIndex = 156
        Me.Label11.Text = "_____________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(867, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 29)
        Me.Label13.TabIndex = 155
        Me.Label13.Text = "Codigo:"
        '
        'txtFirValida
        '
        Me.txtFirValida.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFirValida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirValida.Enabled = False
        Me.txtFirValida.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFirValida.Location = New System.Drawing.Point(856, 507)
        Me.txtFirValida.Name = "txtFirValida"
        Me.txtFirValida.Size = New System.Drawing.Size(376, 27)
        Me.txtFirValida.TabIndex = 144
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(856, 512)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(377, 29)
        Me.Label19.TabIndex = 146
        Me.Label19.Text = "____________________________"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(700, 507)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(154, 29)
        Me.Label20.TabIndex = 145
        Me.Label20.Text = "Firma Valida:"
        '
        'txtFirPropone
        '
        Me.txtFirPropone.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFirPropone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirPropone.Enabled = False
        Me.txtFirPropone.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFirPropone.Location = New System.Drawing.Point(225, 509)
        Me.txtFirPropone.Name = "txtFirPropone"
        Me.txtFirPropone.Size = New System.Drawing.Size(376, 27)
        Me.txtFirPropone.TabIndex = 141
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label21.Location = New System.Drawing.Point(225, 514)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(377, 29)
        Me.Label21.TabIndex = 143
        Me.Label21.Text = "____________________________"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label22.Location = New System.Drawing.Point(34, 507)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(180, 29)
        Me.Label22.TabIndex = 142
        Me.Label22.Text = "Firma Propone:"
        '
        'txtFirVo
        '
        Me.txtFirVo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFirVo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirVo.Enabled = False
        Me.txtFirVo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFirVo.Location = New System.Drawing.Point(864, 421)
        Me.txtFirVo.Name = "txtFirVo"
        Me.txtFirVo.Size = New System.Drawing.Size(376, 27)
        Me.txtFirVo.TabIndex = 138
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label23.Location = New System.Drawing.Point(864, 426)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(377, 29)
        Me.Label23.TabIndex = 140
        Me.Label23.Text = "____________________________"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label24.Location = New System.Drawing.Point(700, 421)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(158, 29)
        Me.Label24.TabIndex = 139
        Me.Label24.Text = "Firma Vo. Bo:"
        '
        'txtFirmaRecibe
        '
        Me.txtFirmaRecibe.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFirmaRecibe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirmaRecibe.Enabled = False
        Me.txtFirmaRecibe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFirmaRecibe.Location = New System.Drawing.Point(204, 421)
        Me.txtFirmaRecibe.Name = "txtFirmaRecibe"
        Me.txtFirmaRecibe.Size = New System.Drawing.Size(376, 27)
        Me.txtFirmaRecibe.TabIndex = 135
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(204, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(377, 29)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "____________________________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(34, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 29)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "Firma Recibe:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombre.Location = New System.Drawing.Point(987, 87)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(339, 34)
        Me.txtNombre.TabIndex = 112
        '
        'txtRevision
        '
        Me.txtRevision.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtRevision.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRevision.Enabled = False
        Me.txtRevision.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRevision.Location = New System.Drawing.Point(998, 309)
        Me.txtRevision.Name = "txtRevision"
        Me.txtRevision.Size = New System.Drawing.Size(91, 27)
        Me.txtRevision.TabIndex = 111
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(998, 314)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 29)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "______"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(867, 309)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 29)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Revision:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(867, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 29)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "Nombre:"
        '
        'dtFecha
        '
        Me.dtFecha.CalendarFont = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtFecha.Enabled = False
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(967, 238)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(222, 27)
        Me.dtFecha.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(867, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 29)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Fecha:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(632, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 29)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "Periodo:"
        '
        'txtPuesto
        '
        Me.txtPuesto.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPuesto.Enabled = False
        Me.txtPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPuesto.Location = New System.Drawing.Point(753, 11)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(130, 27)
        Me.txtPuesto.TabIndex = 97
        Me.txtPuesto.Text = "Abril - Junio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(753, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 29)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "_________"
        '
        'TablaMostrar
        '
        Me.TablaMostrar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaMostrar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.TablaMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaMostrar.DefaultCellStyle = DataGridViewCellStyle5
        Me.TablaMostrar.Location = New System.Drawing.Point(34, 72)
        Me.TablaMostrar.MaximumSize = New System.Drawing.Size(800, 300)
        Me.TablaMostrar.MinimumSize = New System.Drawing.Size(800, 300)
        Me.TablaMostrar.MultiSelect = False
        Me.TablaMostrar.Name = "TablaMostrar"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaMostrar.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.TablaMostrar.RowHeadersWidth = 51
        Me.TablaMostrar.RowTemplate.Height = 29
        Me.TablaMostrar.Size = New System.Drawing.Size(800, 300)
        Me.TablaMostrar.TabIndex = 0
        '
        'MostrarDictamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMargin = New System.Drawing.Size(1000, 0)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1430, 773)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MostrarDictamen"
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
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirValida As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtFirPropone As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtFirVo As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtFirmaRecibe As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtRevision As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEstatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label34 As Label
End Class
