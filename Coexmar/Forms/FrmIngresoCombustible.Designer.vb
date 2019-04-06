<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngresoCombustible
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.TcDatos = New System.Windows.Forms.TabControl()
        Me.TpDatos = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboNombreConductor = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.TpRegistros = New System.Windows.Forms.TabPage()
        Me.LsvBinesHielo = New System.Windows.Forms.ListView()
        Me.ChIdIngresoCombustible = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChHoraEntrada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreConductor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNumeroPlaca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoCombustible = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTotalGalCombustible = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChHoraSalida = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.CboTipoCombustible = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.TxtCodigoIngresoCombustible = New System.Windows.Forms.TextBox()
        Me.TxtTotalGalCombustible = New System.Windows.Forms.TextBox()
        Me.CboNumeroPlaca = New System.Windows.Forms.ComboBox()
        Me.TcDatos.SuspendLayout()
        Me.TpDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpRegistros.SuspendLayout()
        Me.SuspendLayout()
        '
        'TcDatos
        '
        Me.TcDatos.Controls.Add(Me.TpDatos)
        Me.TcDatos.Controls.Add(Me.TpRegistros)
        Me.TcDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TcDatos.Location = New System.Drawing.Point(0, 0)
        Me.TcDatos.Name = "TcDatos"
        Me.TcDatos.SelectedIndex = 0
        Me.TcDatos.Size = New System.Drawing.Size(1044, 545)
        Me.TcDatos.TabIndex = 11
        '
        'TpDatos
        '
        Me.TpDatos.Controls.Add(Me.Panel1)
        Me.TpDatos.Controls.Add(Me.GroupBox2)
        Me.TpDatos.Controls.Add(Me.PbxLogo)
        Me.TpDatos.Location = New System.Drawing.Point(4, 25)
        Me.TpDatos.Name = "TpDatos"
        Me.TpDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.TpDatos.Size = New System.Drawing.Size(1036, 516)
        Me.TpDatos.TabIndex = 0
        Me.TpDatos.Text = "Datos"
        Me.TpDatos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 478)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 35)
        Me.Panel1.TabIndex = 24
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackgroundImage = Global.Coexmar.My.Resources.Resources.IconCerrar
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Location = New System.Drawing.Point(3, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboNumeroPlaca)
        Me.GroupBox2.Controls.Add(Me.TxtTotalGalCombustible)
        Me.GroupBox2.Controls.Add(Me.TxtCodigoIngresoCombustible)
        Me.GroupBox2.Controls.Add(Me.DtpHoraSalida)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CboTipoCombustible)
        Me.GroupBox2.Controls.Add(Me.DtpHoraEntrada)
        Me.GroupBox2.Controls.Add(Me.CboNombreConductor)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.DtpFecha)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(1030, 288)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'CboNombreConductor
        '
        Me.CboNombreConductor.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CboNombreConductor.FormattingEnabled = True
        Me.CboNombreConductor.Location = New System.Drawing.Point(319, 192)
        Me.CboNombreConductor.Name = "CboNombreConductor"
        Me.CboNombreConductor.Size = New System.Drawing.Size(197, 30)
        Me.CboNombreConductor.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(542, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 22)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Tipo Combustible:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(542, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 24)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Número de Placa:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(542, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(231, 22)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Total Gal. Combustible :"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(21, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(199, 22)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Nombre Conductor :"
        '
        'DtpFecha
        '
        Me.DtpFecha.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DtpFecha.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(319, 74)
        Me.DtpFecha.MaxDate = New Date(2019, 4, 5, 0, 0, 0, 0)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(197, 29)
        Me.DtpFecha.TabIndex = 9
        Me.DtpFecha.Value = New Date(2019, 4, 5, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(21, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 22)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Fecha:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.BtnModificar)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Controls.Add(Me.BtnGuardar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 240)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1030, 48)
        Me.Panel2.TabIndex = 7
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Coexmar.My.Resources.Resources.IconCancelar2
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(720, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(123, 48)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnModificar.BackColor = System.Drawing.Color.White
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.Coexmar.My.Resources.Resources.IconModificar
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(543, 0)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(123, 48)
        Me.BtnModificar.TabIndex = 10
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnNuevo.BackColor = System.Drawing.Color.White
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.Coexmar.My.Resources.Resources.IconNuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(221, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(103, 48)
        Me.BtnNuevo.TabIndex = 8
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnGuardar.BackColor = System.Drawing.Color.White
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.Coexmar.My.Resources.Resources.IconGuardar__2_
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(376, 0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(114, 48)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(21, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(281, 24)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Código Ingreso Combustible:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(21, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 22)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Hora Entrada:"
        '
        'PbxLogo
        '
        Me.PbxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbxLogo.BackgroundImage = Global.Coexmar.My.Resources.Resources.CoexmarLogoMod
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.Location = New System.Drawing.Point(421, 294)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(277, 198)
        Me.PbxLogo.TabIndex = 2
        Me.PbxLogo.TabStop = False
        '
        'TpRegistros
        '
        Me.TpRegistros.Controls.Add(Me.LsvBinesHielo)
        Me.TpRegistros.Location = New System.Drawing.Point(4, 25)
        Me.TpRegistros.Name = "TpRegistros"
        Me.TpRegistros.Padding = New System.Windows.Forms.Padding(3)
        Me.TpRegistros.Size = New System.Drawing.Size(1036, 516)
        Me.TpRegistros.TabIndex = 1
        Me.TpRegistros.Text = "Registros"
        Me.TpRegistros.UseVisualStyleBackColor = True
        '
        'LsvBinesHielo
        '
        Me.LsvBinesHielo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdIngresoCombustible, Me.ChFecha, Me.ChHoraEntrada, Me.ChNombreConductor, Me.ChNumeroPlaca, Me.ChTipoCombustible, Me.ChTotalGalCombustible, Me.ChHoraSalida})
        Me.LsvBinesHielo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsvBinesHielo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvBinesHielo.FullRowSelect = True
        Me.LsvBinesHielo.GridLines = True
        Me.LsvBinesHielo.Location = New System.Drawing.Point(3, 3)
        Me.LsvBinesHielo.Name = "LsvBinesHielo"
        Me.LsvBinesHielo.Size = New System.Drawing.Size(1030, 510)
        Me.LsvBinesHielo.TabIndex = 0
        Me.LsvBinesHielo.UseCompatibleStateImageBehavior = False
        Me.LsvBinesHielo.View = System.Windows.Forms.View.Details
        '
        'ChIdIngresoCombustible
        '
        Me.ChIdIngresoCombustible.Text = "Código Ingreso Combustible"
        Me.ChIdIngresoCombustible.Width = 120
        '
        'ChFecha
        '
        Me.ChFecha.Text = "Fecha"
        Me.ChFecha.Width = 90
        '
        'ChHoraEntrada
        '
        Me.ChHoraEntrada.Text = "Hora Entrada"
        Me.ChHoraEntrada.Width = 120
        '
        'ChNombreConductor
        '
        Me.ChNombreConductor.Text = "Nombre Conductor"
        Me.ChNombreConductor.Width = 180
        '
        'ChNumeroPlaca
        '
        Me.ChNumeroPlaca.Text = "Número Placa"
        Me.ChNumeroPlaca.Width = 120
        '
        'ChTipoCombustible
        '
        Me.ChTipoCombustible.Text = "Tipo Combustible"
        Me.ChTipoCombustible.Width = 120
        '
        'ChTotalGalCombustible
        '
        Me.ChTotalGalCombustible.Text = "Total Gal. Combustible"
        Me.ChTotalGalCombustible.Width = 150
        '
        'ChHoraSalida
        '
        Me.ChHoraSalida.Text = "HoraSalida"
        Me.ChHoraSalida.Width = 120
        '
        'DtpHoraEntrada
        '
        Me.DtpHoraEntrada.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DtpHoraEntrada.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHoraEntrada.Location = New System.Drawing.Point(319, 133)
        Me.DtpHoraEntrada.Name = "DtpHoraEntrada"
        Me.DtpHoraEntrada.Size = New System.Drawing.Size(197, 29)
        Me.DtpHoraEntrada.TabIndex = 24
        '
        'CboTipoCombustible
        '
        Me.CboTipoCombustible.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CboTipoCombustible.FormattingEnabled = True
        Me.CboTipoCombustible.Location = New System.Drawing.Point(779, 76)
        Me.CboTipoCombustible.Name = "CboTipoCombustible"
        Me.CboTipoCombustible.Size = New System.Drawing.Size(197, 30)
        Me.CboTipoCombustible.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(542, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Hora Salida:"
        '
        'DtpHoraSalida
        '
        Me.DtpHoraSalida.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DtpHoraSalida.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHoraSalida.Location = New System.Drawing.Point(779, 193)
        Me.DtpHoraSalida.Name = "DtpHoraSalida"
        Me.DtpHoraSalida.Size = New System.Drawing.Size(197, 29)
        Me.DtpHoraSalida.TabIndex = 28
        '
        'TxtCodigoIngresoCombustible
        '
        Me.TxtCodigoIngresoCombustible.Location = New System.Drawing.Point(319, 20)
        Me.TxtCodigoIngresoCombustible.Multiline = True
        Me.TxtCodigoIngresoCombustible.Name = "TxtCodigoIngresoCombustible"
        Me.TxtCodigoIngresoCombustible.Size = New System.Drawing.Size(197, 30)
        Me.TxtCodigoIngresoCombustible.TabIndex = 29
        '
        'TxtTotalGalCombustible
        '
        Me.TxtTotalGalCombustible.Location = New System.Drawing.Point(779, 132)
        Me.TxtTotalGalCombustible.Multiline = True
        Me.TxtTotalGalCombustible.Name = "TxtTotalGalCombustible"
        Me.TxtTotalGalCombustible.Size = New System.Drawing.Size(197, 30)
        Me.TxtTotalGalCombustible.TabIndex = 31
        '
        'CboNumeroPlaca
        '
        Me.CboNumeroPlaca.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CboNumeroPlaca.FormattingEnabled = True
        Me.CboNumeroPlaca.Location = New System.Drawing.Point(779, 24)
        Me.CboNumeroPlaca.Name = "CboNumeroPlaca"
        Me.CboNumeroPlaca.Size = New System.Drawing.Size(197, 30)
        Me.CboNumeroPlaca.TabIndex = 32
        '
        'FrmIngresoCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 545)
        Me.Controls.Add(Me.TcDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmIngresoCombustible"
        Me.Text = "FrmIngresoCombustible"
        Me.TcDatos.ResumeLayout(False)
        Me.TpDatos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpRegistros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TcDatos As TabControl
    Friend WithEvents TpDatos As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CboNombreConductor As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents TpRegistros As TabPage
    Friend WithEvents LsvBinesHielo As ListView
    Friend WithEvents ChIdIngresoCombustible As ColumnHeader
    Friend WithEvents ChFecha As ColumnHeader
    Friend WithEvents ChHoraEntrada As ColumnHeader
    Friend WithEvents ChNombreConductor As ColumnHeader
    Friend WithEvents ChNumeroPlaca As ColumnHeader
    Friend WithEvents ChTipoCombustible As ColumnHeader
    Friend WithEvents ChTotalGalCombustible As ColumnHeader
    Friend WithEvents ChHoraSalida As ColumnHeader
    Friend WithEvents TxtTotalGalCombustible As TextBox
    Friend WithEvents TxtCodigoIngresoCombustible As TextBox
    Friend WithEvents DtpHoraSalida As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents CboTipoCombustible As ComboBox
    Friend WithEvents DtpHoraEntrada As DateTimePicker
    Friend WithEvents CboNumeroPlaca As ComboBox
End Class
