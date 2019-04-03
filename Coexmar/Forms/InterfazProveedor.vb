Imports System.Data.SqlClient
Public Class InterfazProveedor
    Dim EstadoModificado As Boolean
    ' Cierra el formulario hijo y cambia el titulo del formulario padre 
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        ' InterfazPrincipal.PbxLogo.Visible = True
        ' InterfazPrincipal.LblTitulo.Text = "COEXMAR-FINCA"
        Close()
    End Sub
    ' oculta muestra la tabla con los datos
    Private Sub ChkVer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.CheckState = CheckState.Checked Then
            LsvProveedor.Visible = True
            PbxLogo.Visible = False
            MostrarTodo()
        Else
            PbxLogo.Visible = True
            LsvProveedor.Visible = False
        End If
    End Sub
    ' Se cargan las instrucciones que se ejecutaran al iniciar el formulario
    Private Sub InterfazProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoModificado = False
        TxtNombreProveedor.ReadOnly = True
        TxtCodigoProveedor.ReadOnly = True
        PbxLogo.Visible = True
        LsvProveedor.Visible = False
    End Sub
    ' Almacena datos en la tabla Alimento
    Private Sub GuardarProveedor()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NombreProveedor", SqlDbType.NVarChar, 40).Value = TxtNombreProveedor.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al insertar el Proveedor", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
    ' 
    Private Sub ModificarProveedor()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ModificarProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    .Parameters.Add("@IdProveedor", SqlDbType.NVarChar, 30).Value = TxtCodigoProveedor.Text
                    .Parameters.Add("@NombreProveedor", SqlDbType.NVarChar, 30).Value = TxtNombreProveedor.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro modificado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al modificar el Proveedor", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    ' bloquea los botones,excepto BtnGuardar. ejecuta el Sub procedimiento NuevoAlimento(), habilita el TxtAlimento y lo enfoca 
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        NuevoProveedor()
        TxtNombreProveedor.ReadOnly = False
        HabilitarBotones(False, True, False, True)
        TxtNombreProveedor.Focus()

    End Sub
    ' controla el estado de los botones (Habilitado o Inabilitado)
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnModificar.Enabled = Modificar
        BtnGuardar.Enabled = Guardar
        BtnCancelar.Enabled = Cancelar
    End Sub
    ' Verifica que el TextBox no este` vacio
    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtNombreProveedor.Text = Nothing Then
            EpMensaje.SetError(TxtNombreProveedor, "Tiene que ingresar el Proveedor")
            TxtNombreProveedor.Focus()
            TxtNombreProveedor.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtNombreProveedor, "")

        End If
        Return Estado
    End Function

    Private Function ValidarTextBoxModificar()
        Dim Estado As Boolean

        If TxtNombreProveedor.Text = Nothing And TxtCodigoProveedor.Text = Nothing Then
            EpMensaje.SetError(TxtCodigoProveedor, "Tiene que ingresar Codigo Proveedor")
            EpMensaje.SetError(TxtNombreProveedor, "Tiene que ingresar Proveedor")
            TxtCodigoProveedor.Focus()
            TxtCodigoProveedor.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtCodigoProveedor.Text = Nothing Then
            EpMensaje.SetError(TxtCodigoProveedor, "Tiene que ingresar el Codigo Proveedor")
            TxtCodigoProveedor.Focus()
            TxtCodigoProveedor.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtNombreProveedor.Text = Nothing Then
            EpMensaje.SetError(TxtNombreProveedor, "Tiene que ingresar el Proveedor")
            TxtNombreProveedor.Focus()
            TxtNombreProveedor.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtNombreProveedor, "")
            EpMensaje.SetError(TxtCodigoProveedor, "")

        End If
        Return Estado
    End Function
    ' habilita el BtnNuevo y el BtnModificar
    ' inserta en la tabla Alimento,gracias al Sub procedimiento GuardarAlimento()
    ' Muestra los datos de la tabla en LsvAlimento gracias al Sub Procedimiento MostrarTodo()
    ' Limpia Los TextBox gracias al Sub Procedimiento Limpiar()
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If EstadoModificado = True Then
            If ValidarTextBoxModificar() = True Then
                HabilitarBotones(True, False, True, False)
                TxtNombreProveedor.ReadOnly = True
                TxtCodigoProveedor.ReadOnly = True
                ModificarProveedor()
                MostrarTodo()
                Limpiar()
                EstadoModificado = False
            End If
        Else
            If ValidarTextBox() = True Then
                HabilitarBotones(True, False, True, False)
                TxtNombreProveedor.ReadOnly = True
                GuardarProveedor()
                MostrarTodo()
                Limpiar()
            End If
        End If

    End Sub
    ' Pasa todos los datos de la Tabla Alimento a la LsvAlimento
    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarProveedores"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerProveedor As SqlDataReader
                VerProveedor = CMd.ExecuteReader

                LsvProveedor.Items.Clear()
                While VerProveedor.Read = True
                    With LsvProveedor.Items.Add(VerProveedor("Codigo Proveedor").ToString)
                        .SubItems.Add(VerProveedor("Nombre Proveedor").ToString)
                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al insertar Proveedor", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub
    ' Pone en blanco los TextBox
    Private Sub Limpiar()
        TxtCodigoProveedor.Text = Nothing
        TxtNombreProveedor.Text = Nothing
    End Sub

    ' resetea el Error Provider (EpMensaje)
    ' y coloca su color de fondo Habitual (Blanco)
    Private Sub TxtNombreProveedor_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreProveedor.TextChanged
        If TxtNombreProveedor.Text <> Nothing Then
            EpMensaje.SetError(TxtNombreProveedor, "")
            TxtNombreProveedor.BackColor = Color.White
        End If
    End Sub

    Private Sub TTxtCodigoProveedo_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoProveedor.TextChanged
        If TxtCodigoProveedor.Text <> Nothing Then
            EpMensaje.SetError(TxtCodigoProveedor, "")
            TxtCodigoProveedor.BackColor = Color.White
        End If
    End Sub
    ' obtiene el correlativo de la Tabla Alimento que sera mostrado en TxtIdAlimento
    Private Sub NuevoProveedor()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListaProveedor As New SqlCommand("Sp_InvestigarCorrelativoProveedor", Cn)
            ListaProveedor.CommandType = CommandType.StoredProcedure
            ListaProveedor.Parameters.Add("@Proveedor", SqlDbType.NVarChar, 30).Value = "Alimento"
            Dim ListarProveedorR As SqlDataReader
            Cn.Open()
            ListarProveedorR = ListaProveedor.ExecuteReader()

            If ListarProveedorR.Read = True Then
                If ListarProveedorR("Codigo Proveedor") Is "" Then
                    TxtCodigoProveedor.Text = 1
                Else
                    TxtCodigoProveedor.Text = ListarProveedorR("Codigo Proveedor").ToString + 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos" + ex.Message, "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        HabilitarBotones(True, False, True, False)
        TxtNombreProveedor.ReadOnly = True
        TxtCodigoProveedor.ReadOnly = True
        TxtCodigoProveedor.BackColor = Color.WhiteSmoke
        TxtNombreProveedor.BackColor = Color.WhiteSmoke

        TxtNombreProveedor.Text = ""
        TxtCodigoProveedor.Text = ""


    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        EstadoModificado = True
        HabilitarBotones(False, True, False, True)
        TxtNombreProveedor.ReadOnly = False
        TxtCodigoProveedor.ReadOnly = False
        TxtCodigoProveedor.Focus()
        LsvProveedor.Visible = True
        PbxLogo.Visible = False
        ChkVer.Checked = True
    End Sub

End Class