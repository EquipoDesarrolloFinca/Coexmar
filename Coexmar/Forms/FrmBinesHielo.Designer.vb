<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBinesHielo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChIdBinesHielo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.LsvBinesHielo = New System.Windows.Forms.ListView()
        Me.ChFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNumIdentidadConductor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNumPlaca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChHoraLlegada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdProveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TcDatos = New System.Windows.Forms.TabControl()
        Me.TpDatos = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboPlacaCamion = New System.Windows.Forms.ComboBox()
        Me.CboUsuario = New System.Windows.Forms.ComboBox()
        Me.CboProveedor = New System.Windows.Forms.ComboBox()
        Me.CboIdentidadConductor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpHora = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
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
        Me.TxtIdBin = New System.Windows.Forms.TextBox()
        Me.TpRegistros = New System.Windows.Forms.TabPage()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsOpciones.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TcDatos.SuspendLayout()
        Me.TpDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TpRegistros.SuspendLayout()
        Me.SuspendLayout()
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'ChIdBinesHielo
        '
        Me.ChIdBinesHielo.Text = "Código Bin"
        Me.ChIdBinesHielo.Width = 80
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
        'LsvBinesHielo
        '
        Me.LsvBinesHielo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdBinesHielo, Me.ChFecha, Me.ChNumIdentidadConductor, Me.ChNumPlaca, Me.ChCantidad, Me.ChHoraLlegada, Me.ChIdProveedor, Me.ChIdUsuario})
        Me.LsvBinesHielo.ContextMenuStrip = Me.CmsOpciones
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
        'ChFecha
        '
        Me.ChFecha.Text = "Fecha"
        Me.ChFecha.Width = 123
        '
        'ChNumIdentidadConductor
        '
        Me.ChNumIdentidadConductor.Text = "Identidad Conductor"
        Me.ChNumIdentidadConductor.Width = 200
        '
        'ChNumPlaca
        '
        Me.ChNumPlaca.Text = "Placa del Camión"
        Me.ChNumPlaca.Width = 122
        '
        'ChCantidad
        '
        Me.ChCantidad.Text = "Cantidad"
        Me.ChCantidad.Width = 95
        '
        'ChHoraLlegada
        '
        Me.ChHoraLlegada.Text = "Hora de Llegada"
        Me.ChHoraLlegada.Width = 117
        '
        'ChIdProveedor
        '
        Me.ChIdProveedor.Text = "Proveedor"
        Me.ChIdProveedor.Width = 124
        '
        'ChIdUsuario
        '
        Me.ChIdUsuario.Text = "Usuario"
        Me.ChIdUsuario.Width = 120
        '
        'CmsOpciones
        '
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Controls.Add(Me.TcDatos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1044, 545)
        Me.Panel3.TabIndex = 13
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
        Me.TcDatos.TabIndex = 9
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
        Me.GroupBox2.Controls.Add(Me.CboPlacaCamion)
        Me.GroupBox2.Controls.Add(Me.CboUsuario)
        Me.GroupBox2.Controls.Add(Me.CboProveedor)
        Me.GroupBox2.Controls.Add(Me.CboIdentidadConductor)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.DtpHora)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.DtpFecha)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.TxtIdBin)
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
        'CboPlacaCamion
        '
        Me.CboPlacaCamion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CboPlacaCamion.FormattingEnabled = True
        Me.CboPlacaCamion.Location = New System.Drawing.Point(319, 192)
        Me.CboPlacaCamion.Name = "CboPlacaCamion"
        Me.CboPlacaCamion.Size = New System.Drawing.Size(197, 30)
        Me.CboPlacaCamion.TabIndex = 23
        '
        'CboUsuario
        '
        Me.CboUsuario.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CboUsuario.FormattingEnabled = True
        Me.CboUsuario.Location = New System.Drawing.Point(722, 187)
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.Size = New System.Drawing.Size(197, 30)
        Me.CboUsuario.TabIndex = 22
        '
        'CboProveedor
        '
        Me.CboProveedor.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CboProveedor.FormattingEnabled = True
        Me.CboProveedor.Location = New System.Drawing.Point(722, 130)
        Me.CboProveedor.Name = "CboProveedor"
        Me.CboProveedor.Size = New System.Drawing.Size(197, 30)
        Me.CboProveedor.TabIndex = 21
        '
        'CboIdentidadConductor
        '
        Me.CboIdentidadConductor.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CboIdentidadConductor.FormattingEnabled = True
        Me.CboIdentidadConductor.Location = New System.Drawing.Point(319, 130)
        Me.CboIdentidadConductor.Name = "CboIdentidadConductor"
        Me.CboIdentidadConductor.Size = New System.Drawing.Size(197, 30)
        Me.CboIdentidadConductor.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(542, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Usuario:"
        '
        'DtpHora
        '
        Me.DtpHora.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DtpHora.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHora.Location = New System.Drawing.Point(722, 74)
        Me.DtpHora.Name = "DtpHora"
        Me.DtpHora.Size = New System.Drawing.Size(197, 29)
        Me.DtpHora.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(542, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 22)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Hora de Llegada:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(542, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 24)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Cantidad:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(542, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 22)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Proveedor :"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(722, 18)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.ReadOnly = True
        Me.TxtCantidad.Size = New System.Drawing.Size(197, 29)
        Me.TxtCantidad.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(103, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 22)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Placa del Camión :"
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
        Me.Label14.Location = New System.Drawing.Point(103, 79)
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
        Me.Label15.Location = New System.Drawing.Point(103, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(174, 24)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Código Bin Hielo:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(103, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(212, 22)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Identidad Conductor :"
        '
        'TxtIdBin
        '
        Me.TxtIdBin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtIdBin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdBin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdBin.Location = New System.Drawing.Point(319, 25)
        Me.TxtIdBin.Name = "TxtIdBin"
        Me.TxtIdBin.ReadOnly = True
        Me.TxtIdBin.Size = New System.Drawing.Size(197, 29)
        Me.TxtIdBin.TabIndex = 3
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
        'FrmBinesHielo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 545)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBinesHielo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsOpciones.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TcDatos.ResumeLayout(False)
        Me.TpDatos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TpRegistros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents LsvBinesHielo As ListView
    Friend WithEvents ChIdBinesHielo As ColumnHeader
    Friend WithEvents ChFecha As ColumnHeader
    Friend WithEvents ChNumIdentidadConductor As ColumnHeader
    Friend WithEvents ChNumPlaca As ColumnHeader
    Friend WithEvents ChCantidad As ColumnHeader
    Friend WithEvents ChHoraLlegada As ColumnHeader
    Friend WithEvents ChIdProveedor As ColumnHeader
    Friend WithEvents ChIdUsuario As ColumnHeader
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TcDatos As TabControl
    Friend WithEvents TpDatos As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CboPlacaCamion As ComboBox
    Friend WithEvents CboUsuario As ComboBox
    Friend WithEvents CboProveedor As ComboBox
    Friend WithEvents CboIdentidadConductor As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DtpHora As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCantidad As TextBox
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
    Friend WithEvents TxtIdBin As TextBox
    Friend WithEvents TpRegistros As TabPage
End Class
