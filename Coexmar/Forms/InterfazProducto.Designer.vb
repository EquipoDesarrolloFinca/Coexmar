<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazProducto
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.PIzquierdo = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkVer = New System.Windows.Forms.CheckBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.LsvProducto = New System.Windows.Forms.ListView()
        Me.ChIdProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.PIzquierdo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtIdProducto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtProducto)
        Me.GroupBox1.Controls.Add(Me.PIzquierdo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(889, 215)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtIdProducto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdProducto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdProducto.Location = New System.Drawing.Point(394, 27)
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.Size = New System.Drawing.Size(252, 29)
        Me.TxtIdProducto.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(155, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código de Producto"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(155, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Producto:"
        '
        'TxtProducto
        '
        Me.TxtProducto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtProducto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProducto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProducto.Location = New System.Drawing.Point(394, 69)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(252, 29)
        Me.TxtProducto.TabIndex = 5
        '
        'PIzquierdo
        '
        Me.PIzquierdo.BackColor = System.Drawing.Color.Navy
        Me.PIzquierdo.Controls.Add(Me.BtnCancelar)
        Me.PIzquierdo.Controls.Add(Me.BtnModificar)
        Me.PIzquierdo.Controls.Add(Me.BtnNuevo)
        Me.PIzquierdo.Controls.Add(Me.BtnGuardar)
        Me.PIzquierdo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PIzquierdo.Location = New System.Drawing.Point(0, 162)
        Me.PIzquierdo.Name = "PIzquierdo"
        Me.PIzquierdo.Size = New System.Drawing.Size(889, 53)
        Me.PIzquierdo.TabIndex = 7
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Coexmar.My.Resources.Resources.IconCancelar2
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(648, 0)
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
        Me.BtnModificar.Location = New System.Drawing.Point(472, 0)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(150, 0)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(305, 0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(114, 48)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 511)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 35)
        Me.Panel1.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Coexmar.My.Resources.Resources.IconCerrar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ChkVer)
        Me.Panel3.Controls.Add(Me.PbxLogo)
        Me.Panel3.Controls.Add(Me.LsvProducto)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 215)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(889, 296)
        Me.Panel3.TabIndex = 19
        '
        'ChkVer
        '
        Me.ChkVer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChkVer.AutoSize = True
        Me.ChkVer.Location = New System.Drawing.Point(690, 13)
        Me.ChkVer.Name = "ChkVer"
        Me.ChkVer.Size = New System.Drawing.Size(73, 17)
        Me.ChkVer.TabIndex = 3
        Me.ChkVer.Text = "Ver Datos"
        Me.ChkVer.UseVisualStyleBackColor = True
        '
        'PbxLogo
        '
        Me.PbxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbxLogo.BackgroundImage = Global.Coexmar.My.Resources.Resources.CoexmarLogoMod
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.Location = New System.Drawing.Point(298, 57)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(358, 229)
        Me.PbxLogo.TabIndex = 2
        Me.PbxLogo.TabStop = False
        '
        'LsvProducto
        '
        Me.LsvProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LsvProducto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdProducto, Me.ChProducto})
        Me.LsvProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvProducto.FullRowSelect = True
        Me.LsvProducto.GridLines = True
        Me.LsvProducto.Location = New System.Drawing.Point(315, 0)
        Me.LsvProducto.Name = "LsvProducto"
        Me.LsvProducto.Size = New System.Drawing.Size(325, 296)
        Me.LsvProducto.TabIndex = 0
        Me.LsvProducto.UseCompatibleStateImageBehavior = False
        Me.LsvProducto.View = System.Windows.Forms.View.Details
        '
        'ChIdProducto
        '
        Me.ChIdProducto.Text = "Código de Producto"
        Me.ChIdProducto.Width = 120
        '
        'ChProducto
        '
        Me.ChProducto.Text = "Producto"
        Me.ChProducto.Width = 200
        '
        'InterfazProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 546)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "InterfazProducto"
        Me.Text = "Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PIzquierdo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents PIzquierdo As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChkVer As CheckBox
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents LsvProducto As ListView
    Friend WithEvents ChIdProducto As ColumnHeader
    Friend WithEvents ChProducto As ColumnHeader
End Class
