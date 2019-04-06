Imports System.Data.SqlClient

Public Class InterfazPersonal
    Dim EstadoModificado As Boolean
    ' Cierra el formulario hijo y cambia el titulo del formulario padre 
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        ' InterfazPrincipal.PbxLogo.Visible = True
        ' InterfazPrincipal.LblTitulo.Text = "COEXMAR-FINCA"
        Close()
    End Sub
    ' oculta muestra la tabla con los datos
    Private Sub ChkVer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.CheckState = CheckState.Checked Then
            LsvPersonal.Visible = True
            PbxLogo.Visible = False
            MostrarPersonal()
        Else
            PbxLogo.Visible = True
            LsvPersonal.Visible = False
        End If
    End Sub
    ' Se cargan las instrucciones que se ejecutaran al iniciar el formulario
    Private Sub InterfazProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoModificado = False
        PbxLogo.Visible = True
        LsvPersonal.Visible = False
    End Sub
    ' Almacena datos en la tabla Alimento

    Private Sub LlenarCargo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using Cmd As New SqlCommand
            Cn.Open()
            Try
                With Cmd
                    .CommandText = "Sp_MostrarCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim Da As New SqlDataAdapter(Cmd)

                Dim Ds As New DataSet
                Da.Fill(Ds, "Cargo")
                CboCargo.DataSource = Ds.Tables(0)
                CboCargo.DisplayMember = Ds.Tables(0).Columns("Cargo").ToString
                CboCargo.ValueMember = Ds.Tables(0).Columns("IdCargo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LlenarSexo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using Cmd As New SqlCommand
            Cn.Open()
            Try
                With Cmd
                    .CommandText = "Sp_Mostrarsexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim Da As New SqlDataAdapter(Cmd)

                Dim Ds As New DataSet
                Da.Fill(Ds, "Sexo")
                CboSexo.DataSource = Ds.Tables(0)
                CboSexo.DisplayMember = Ds.Tables(0).Columns("Sexo").ToString
                CboSexo.ValueMember = Ds.Tables(0).Columns("IdSexo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarPersonal()

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarPersonal"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NumIdentidad", SqlDbType.VarChar, 15).Value = TxtIdentidad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar personal" + ex.Message, "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub GuardarPersonal()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarPersonal"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre del genero musical

                    .Parameters.Add("@NumIdentidad", SqlDbType.VarChar, 15).Value = TxtIdentidad.Text
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = TxtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 30).Value = TxtApellidos.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = TxtTelefono.Text
                    .Parameters.Add("@Email", SqlDbType.NVarChar, 25).Value = TxtEmail.Text
                    .Parameters.Add("@IdCargo", SqlDbType.Int).Value = CInt(CboCargo.SelectedValue)
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar personal", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub
    ' 
    Private Sub ActualizarPersonal()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarPersonal"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre del genero musical

                    .Parameters.Add("@NumIdentidad", SqlDbType.VarChar, 15).Value = TxtIdentidad.Text
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = TxtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 30).Value = TxtApellidos.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = TxtTelefono.Text
                    .Parameters.Add("@Email", SqlDbType.NVarChar, 25).Value = TxtEmail.Text
                    .Parameters.Add("@IdCargo", SqlDbType.Int).Value = CInt(CboCargo.SelectedValue)
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar personal", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub

    ' bloquea los botones,excepto BtnGuardar. ejecuta el Sub procedimiento NuevoAlimento(), habilita el TxtAlimento y lo enfoca 
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LlenarCargo()
        LlenarSexo()
        HabilitarBotones(False, True, False, True)
        TxtIdentidad.Focus()

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

        If TxtIdentidad.Text = Nothing Then
            EpMensaje.SetError(TxtIdentidad, "Tiene que ingresar el Proveedor")
            TxtIdentidad.Focus()
            TxtIdentidad.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtIdentidad, "")

        End If
        Return Estado
    End Function

    Private Function ValidarTextBoxModificar()
        Dim Estado As Boolean

        If TxtNombre.Text = Nothing And TxtIdentidad.Text = Nothing Then
            EpMensaje.SetError(TxtIdentidad, "Tiene que ingresar numero identidad")
            EpMensaje.SetError(TxtNombre, "Tiene que ingresar Proveedor")
            TxtIdentidad.Focus()
            TxtIdentidad.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtIdentidad.Text = Nothing Then
            EpMensaje.SetError(TxtIdentidad, "Tiene que ingresar el Codigo Proveedor")
            TxtIdentidad.Focus()
            TxtIdentidad.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtNombre.Text = Nothing Then
            EpMensaje.SetError(TxtNombre, "Tiene que ingresar el Proveedor")
            TxtNombre.Focus()
            TxtNombre.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtNombre, "")
            EpMensaje.SetError(TxtIdentidad, "")

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
                GuardarPersonal()
                HabilitarBotones(True, False, False, False)
                MostrarPersonal()
                EstadoModificado = False
            End If
        Else
            If ValidarTextBox() = True Then
                HabilitarBotones(True, False, True, False)
                GuardarPersonal()
                MostrarPersonal()
                Limpiar()
            End If
        End If

    End Sub
    ' Pasa todos los datos de la Tabla Alimento a la LsvAlimento
    Private Sub MostrarPersonal()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using Cmd As New SqlCommand
            Cn.Open()
            Try
                With Cmd
                    .CommandText = "Sp_MostrarPersonal"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim VerCiudad As SqlDataReader
                VerCiudad = Cmd.ExecuteReader()

                LsvPersonal.Items.Clear()
                While VerCiudad.Read = True
                    With LsvPersonal.Items.Add(VerCiudad("NumIdentidad").ToString)
                        .SubItems.Add(VerCiudad("Nombre").ToString)
                        .SubItems.Add(VerCiudad("Apellidos").ToString)
                        .SubItems.Add(VerCiudad("Telefono").ToString)
                        .SubItems.Add(VerCiudad("Email").ToString)
                        .SubItems.Add(VerCiudad("Cargo").ToString)
                        .SubItems.Add(VerCiudad("Sexo").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error en mostrar." + ex.Message, "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub
    ' Pone en blanco los TextBox
    Private Sub Limpiar()
        TxtIdentidad.Text = Nothing
        TxtNombre.Text = Nothing
        TxtApellidos.Text = Nothing
        TxtTelefono.Text = Nothing
        TxtEmail.Text = Nothing
        CboCargo.Text = "Seleccione--"
        CboSexo.Text = "Seleccione--"
    End Sub

    ' resetea el Error Provider (EpMensaje)
    ' y coloca su color de fondo Habitual (Blanco)
    'Private Sub TxtNombreProveedor_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreProveedor.TextChanged
    '    If TxtNombreProveedor.Text <> Nothing Then
    '        EpMensaje.SetError(TxtNombreProveedor, "")
    '        TxtNombreProveedor.BackColor = Color.White
    '    End If
    'End Sub

    'Private Sub TTxtCodigoProveedo_TextChanged(sender As Object, e As EventArgs) Handles TxtIdProveedor.TextChanged
    '    If TxtIdProveedor.Text <> Nothing Then
    '        EpMensaje.SetError(TxtIdProveedor, "")
    '        TxtIdProveedor.BackColor = Color.White
    '    End If
    'End Sub
    ' obtiene el correlativo de la Tabla Alimento que sera mostrado en TxtIdAlimento
    'Private Sub InvestigarCorrelaticoProveedor()
    '    If Cn.State = ConnectionState.Open Then
    '        Cn.Close()
    '    End If

    '    Try
    '        Dim ListarCiudad As New SqlCommand("Sp_InvestigarCorrelativoProveedor", Cn)
    '        ListarCiudad.CommandType = CommandType.StoredProcedure
    '        Dim ListarCiudadR As SqlDataReader
    '        Cn.Open()
    '        ListarCiudadR = ListarCiudad.ExecuteReader()

    '        If ListarCiudadR.Read = True Then
    '            If ListarCiudadR("IdProveedor") = 1 Then
    '                TxtIdProveedor.Text = 1
    '            Else
    '                TxtIdProveedor.Text = ListarCiudadR("IdProveedor").ToString
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("Error en investigar", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        Cn.Close()
    '    End Try

    'End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()


    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        ActualizarPersonal()
            Limpiar()
            HabilitarBotones(True, False, False, False)
        MostrarPersonal()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarPersonal()
        MostrarPersonal()
        HabilitarBotones(True, False, False, False)
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtIdentidad.Text = LsvPersonal.FocusedItem.SubItems(0).Text
        TxtNombre.Text = LsvPersonal.FocusedItem.SubItems(1).Text
        TxtApellidos.Text = LsvPersonal.FocusedItem.SubItems(2).Text
        TxtTelefono.Text = LsvPersonal.FocusedItem.SubItems(3).Text
        TxtEmail.Text = LsvPersonal.FocusedItem.SubItems(4).Text
        CboCargo.Text = LsvPersonal.FocusedItem.SubItems(5).Text
        CboSexo.Text = LsvPersonal.FocusedItem.SubItems(5).Text
        LlenarCargo()
        LlenarSexo()
        HabilitarBotones(False, False, True, True)
    End Sub
End Class