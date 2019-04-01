<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazProveedor
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PIzquierdo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigoProveedor = New System.Windows.Forms.TextBox()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkVer = New System.Windows.Forms.CheckBox()
        Me.LsvProveedor = New System.Windows.Forms.ListView()
        Me.ChCodigoProveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreProveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.ChCodigoProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.PIzquierdo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtCodigoProducto)
        Me.GroupBox1.Controls.Add(Me.PIzquierdo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCodigoProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProveedor)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(800, 215)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'PIzquierdo
        '
        Me.PIzquierdo.BackColor = System.Drawing.Color.Navy
        Me.PIzquierdo.Controls.Add(Me.BtnCancelar)
        Me.PIzquierdo.Controls.Add(Me.BtnModificar)
        Me.PIzquierdo.Controls.Add(Me.BtnNuevo)
        Me.PIzquierdo.Controls.Add(Me.BtnGuardar)
        Me.PIzquierdo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PIzquierdo.Location = New System.Drawing.Point(0, 167)
        Me.PIzquierdo.Name = "PIzquierdo"
        Me.PIzquierdo.Size = New System.Drawing.Size(800, 48)
        Me.PIzquierdo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo Proveedor:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre Proveedor:"
        '
        'TxtCodigoProveedor
        '
        Me.TxtCodigoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCodigoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigoProveedor.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoProveedor.Location = New System.Drawing.Point(215, 30)
        Me.TxtCodigoProveedor.Name = "TxtCodigoProveedor"
        Me.TxtCodigoProveedor.ReadOnly = True
        Me.TxtCodigoProveedor.Size = New System.Drawing.Size(109, 29)
        Me.TxtCodigoProveedor.TabIndex = 3
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNombreProveedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreProveedor.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(215, 65)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(252, 29)
        Me.TxtNombreProveedor.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.ChkVer)
        Me.Panel3.Controls.Add(Me.PbxLogo)
        Me.Panel3.Controls.Add(Me.LsvProveedor)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 215)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 334)
        Me.Panel3.TabIndex = 11
        '
        'ChkVer
        '
        Me.ChkVer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChkVer.AutoSize = True
        Me.ChkVer.Location = New System.Drawing.Point(689, 7)
        Me.ChkVer.Name = "ChkVer"
        Me.ChkVer.Size = New System.Drawing.Size(73, 17)
        Me.ChkVer.TabIndex = 3
        Me.ChkVer.Text = "Ver Datos"
        Me.ChkVer.UseVisualStyleBackColor = True
        '
        'LsvProveedor
        '
        Me.LsvProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LsvProveedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigoProveedor, Me.ChNombreProveedor, Me.ChCodigoProducto})
        Me.LsvProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvProveedor.GridLines = True
        Me.LsvProveedor.Location = New System.Drawing.Point(177, -3)
        Me.LsvProveedor.Name = "LsvProveedor"
        Me.LsvProveedor.Size = New System.Drawing.Size(506, 334)
        Me.LsvProveedor.TabIndex = 0
        Me.LsvProveedor.UseCompatibleStateImageBehavior = False
        Me.LsvProveedor.View = System.Windows.Forms.View.Details
        '
        'ChCodigoProveedor
        '
        Me.ChCodigoProveedor.Text = "Codigo Proveedor"
        Me.ChCodigoProveedor.Width = 150
        '
        'ChNombreProveedor
        '
        Me.ChNombreProveedor.Text = "Nombre Proveedor"
        Me.ChNombreProveedor.Width = 200
        '
        'PbxLogo
        '
        Me.PbxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbxLogo.BackgroundImage = Global.Coexmar.My.Resources.Resources.CoexmarLogoMod
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.Location = New System.Drawing.Point(177, 57)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(506, 229)
        Me.PbxLogo.TabIndex = 2
        Me.PbxLogo.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Coexmar.My.Resources.Resources.IconCancelar2
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(605, 0)
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
        Me.BtnModificar.Location = New System.Drawing.Point(428, 0)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(106, 0)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(261, 0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(114, 48)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(486, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Codigo Producto:"
        '
        'TxtCodigoProducto
        '
        Me.TxtCodigoProducto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigoProducto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoProducto.Location = New System.Drawing.Point(665, 65)
        Me.TxtCodigoProducto.Name = "TxtCodigoProducto"
        Me.TxtCodigoProducto.ReadOnly = True
        Me.TxtCodigoProducto.Size = New System.Drawing.Size(109, 29)
        Me.TxtCodigoProducto.TabIndex = 8
        '
        'ChCodigoProducto
        '
        Me.ChCodigoProducto.Text = "Codigo Producto"
        Me.ChCodigoProducto.Width = 150
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 299)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 35)
        Me.Panel1.TabIndex = 10
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
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'InterfazProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 549)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "InterfazProveedor"
        Me.Text = "InterfazProveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PIzquierdo.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PIzquierdo As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCodigoProveedor As TextBox
    Friend WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChkVer As CheckBox
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents LsvProveedor As ListView
    Friend WithEvents ChCodigoProveedor As ColumnHeader
    Friend WithEvents ChNombreProveedor As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodigoProducto As TextBox
    Friend WithEvents ChCodigoProducto As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents EpMensaje As ErrorProvider
End Class
