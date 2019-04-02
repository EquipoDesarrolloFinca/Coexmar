<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazSector
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdSector = New System.Windows.Forms.TextBox()
        Me.TxtSector = New System.Windows.Forms.TextBox()
        Me.PIzquierdo = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkVer = New System.Windows.Forms.CheckBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.LsvSector = New System.Windows.Forms.ListView()
        Me.ChIdSector = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSector = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.PIzquierdo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtIdSector)
        Me.GroupBox1.Controls.Add(Me.TxtSector)
        Me.GroupBox1.Controls.Add(Me.PIzquierdo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(1370, 265)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(382, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo Sector:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(480, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sector:"
        '
        'TxtIdSector
        '
        Me.TxtIdSector.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtIdSector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdSector.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdSector.Location = New System.Drawing.Point(618, 38)
        Me.TxtIdSector.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdSector.Name = "TxtIdSector"
        Me.TxtIdSector.ReadOnly = True
        Me.TxtIdSector.Size = New System.Drawing.Size(145, 35)
        Me.TxtIdSector.TabIndex = 3
        '
        'TxtSector
        '
        Me.TxtSector.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSector.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtSector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSector.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSector.Location = New System.Drawing.Point(618, 85)
        Me.TxtSector.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSector.Name = "TxtSector"
        Me.TxtSector.Size = New System.Drawing.Size(335, 35)
        Me.TxtSector.TabIndex = 5
        '
        'PIzquierdo
        '
        Me.PIzquierdo.BackColor = System.Drawing.Color.Navy
        Me.PIzquierdo.Controls.Add(Me.BtnCancelar)
        Me.PIzquierdo.Controls.Add(Me.BtnModificar)
        Me.PIzquierdo.Controls.Add(Me.BtnNuevo)
        Me.PIzquierdo.Controls.Add(Me.BtnGuardar)
        Me.PIzquierdo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PIzquierdo.Location = New System.Drawing.Point(0, 206)
        Me.PIzquierdo.Margin = New System.Windows.Forms.Padding(4)
        Me.PIzquierdo.Name = "PIzquierdo"
        Me.PIzquierdo.Size = New System.Drawing.Size(1370, 59)
        Me.PIzquierdo.TabIndex = 7
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Coexmar.My.Resources.Resources.IconCancelar2
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(958, 0)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(164, 59)
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
        Me.BtnModificar.Location = New System.Drawing.Point(722, 0)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(164, 59)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(293, 0)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(137, 59)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(500, 0)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(152, 59)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 581)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 43)
        Me.Panel1.TabIndex = 10
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackgroundImage = Global.Coexmar.My.Resources.Resources.IconCerrar
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Location = New System.Drawing.Point(4, 0)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(47, 43)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ChkVer)
        Me.Panel3.Controls.Add(Me.PbxLogo)
        Me.Panel3.Controls.Add(Me.LsvSector)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 265)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 316)
        Me.Panel3.TabIndex = 11
        '
        'ChkVer
        '
        Me.ChkVer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChkVer.AutoSize = True
        Me.ChkVer.Location = New System.Drawing.Point(1013, 16)
        Me.ChkVer.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkVer.Name = "ChkVer"
        Me.ChkVer.Size = New System.Drawing.Size(93, 21)
        Me.ChkVer.TabIndex = 3
        Me.ChkVer.Text = "Ver Datos"
        Me.ChkVer.UseVisualStyleBackColor = True
        '
        'PbxLogo
        '
        Me.PbxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbxLogo.BackgroundImage = Global.Coexmar.My.Resources.Resources.CoexmarLogoMod
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.Location = New System.Drawing.Point(506, 57)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(477, 282)
        Me.PbxLogo.TabIndex = 2
        Me.PbxLogo.TabStop = False
        '
        'LsvSector
        '
        Me.LsvSector.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LsvSector.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdSector, Me.ChSector})
        Me.LsvSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvSector.GridLines = True
        Me.LsvSector.Location = New System.Drawing.Point(584, 1)
        Me.LsvSector.Margin = New System.Windows.Forms.Padding(4)
        Me.LsvSector.Name = "LsvSector"
        Me.LsvSector.Size = New System.Drawing.Size(328, 315)
        Me.LsvSector.TabIndex = 0
        Me.LsvSector.UseCompatibleStateImageBehavior = False
        Me.LsvSector.View = System.Windows.Forms.View.Details
        '
        'ChIdSector
        '
        Me.ChIdSector.Text = "Còdigo Sector"
        Me.ChIdSector.Width = 120
        '
        'ChSector
        '
        Me.ChSector.Text = "Sector"
        Me.ChSector.Width = 200
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'InterfazSector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 624)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InterfazSector"
        Me.Text = "InterfazSector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PIzquierdo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdSector As TextBox
    Friend WithEvents TxtSector As TextBox
    Friend WithEvents PIzquierdo As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChkVer As CheckBox
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents LsvSector As ListView
    Friend WithEvents ChIdSector As ColumnHeader
    Friend WithEvents ChSector As ColumnHeader
    Friend WithEvents EpMensaje As ErrorProvider
End Class
