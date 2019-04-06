Imports System.Data.SqlClient
Public Class InterfazProveedor
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
            LsvProveedor.Visible = True
            PbxLogo.Visible = False
            MostrarProveedor()
        Else
            PbxLogo.Visible = True
            LsvProveedor.Visible = False
        End If
    End Sub
    ' Se cargan las instrucciones que se ejecutaran al iniciar el formulario
    Private Sub InterfazProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoModificado = False
        TxtIdProveedor.ReadOnly = True
        PbxLogo.Visible = True
        LsvProveedor.Visible = False
    End Sub
    ' Almacena datos en la tabla Alimento

    Private Sub LlenarProducto()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using Cmd As New SqlCommand
            Cn.Open()
            Try
                With Cmd
                    .CommandText = "Sp_MostrarProductos"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim Da As New SqlDataAdapter(Cmd)

                Dim Ds As New DataSet
                Da.Fill(Ds, "Producto")
                CboProducto.DataSource = Ds.Tables(0)
                CboProducto.DisplayMember = Ds.Tables(0).Columns("Producto").ToString
                CboProducto.ValueMember = Ds.Tables(0).Columns("IdProducto").ToString

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarProveedor()

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarProveedores"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre del genero musical
                    Dim Id As Integer
                    Id = CInt(LsvProveedor.FocusedItem.SubItems(0).Text)

                    .Parameters.Add("@IdProveedor", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar proveedor", "CientificaMisic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub

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

                    ' Enviar el parámetro del nombre del genero musical

                    .Parameters.Add("@NombreProveedor", SqlDbType.NVarChar, 40).Value = TxtNombreProveedor.Text
                    .Parameters.Add("@IdProducto", SqlDbType.Int).Value = CInt(CboProducto.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar proveedor", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub
    ' 
    Private Sub ActualizarProveedor()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarProveedores"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre del genero musical

                    .Parameters.Add("@NombreProveedor", SqlDbType.NVarChar, 40).Value = TxtNombreProveedor.Text
                    .Parameters.Add("@IdProveedor", SqlDbType.Int).Value = CInt(TxtIdProveedor.Text)
                    .Parameters.Add("@IdProducto", SqlDbType.Int).Value = CInt(CboProducto.SelectedValue)

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el nombre del proveedor" + ex.Message, "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub

    ' bloquea los botones,excepto BtnGuardar. ejecuta el Sub procedimiento NuevoAlimento(), habilita el TxtAlimento y lo enfoca 
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LlenarProducto()
        InvestigarCorrelaticoProveedor()
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

        If TxtNombreProveedor.Text = Nothing And TxtIdProveedor.Text = Nothing Then
            EpMensaje.SetError(TxtIdProveedor, "Tiene que ingresar Codigo Proveedor")
            EpMensaje.SetError(TxtNombreProveedor, "Tiene que ingresar Proveedor")
            TxtIdProveedor.Focus()
            TxtIdProveedor.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtIdProveedor.Text = Nothing Then
            EpMensaje.SetError(TxtIdProveedor, "Tiene que ingresar el Codigo Proveedor")
            TxtIdProveedor.Focus()
            TxtIdProveedor.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtNombreProveedor.Text = Nothing Then
            EpMensaje.SetError(TxtNombreProveedor, "Tiene que ingresar el Proveedor")
            TxtNombreProveedor.Focus()
            TxtNombreProveedor.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtNombreProveedor, "")
            EpMensaje.SetError(TxtIdProveedor, "")

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
                GuardarProveedor()
                HabilitarBotones(True, False, False, False)
                MostrarProveedor()
                EstadoModificado = False
            End If
        Else
            If ValidarTextBox() = True Then
                HabilitarBotones(True, False, True, False)
                TxtNombreProveedor.ReadOnly = True
                GuardarProveedor()
                MostrarProveedor()
                Limpiar()
            End If
        End If

    End Sub
    ' Pasa todos los datos de la Tabla Alimento a la LsvAlimento
    Private Sub MostrarProveedor()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using Cmd As New SqlCommand
            Cn.Open()
            Try
                With Cmd
                    .CommandText = "Sp_MostrarProveedores"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim VerCiudad As SqlDataReader
                VerCiudad = Cmd.ExecuteReader()

                LsvProveedor.Items.Clear()
                While VerCiudad.Read = True
                    With LsvProveedor.Items.Add(VerCiudad("IdProveedor").ToString)
                        .SubItems.Add(VerCiudad("NombreProveedor").ToString)
                        .SubItems.Add(VerCiudad("Producto").ToString)
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
        TxtIdProveedor.Text = Nothing
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

    Private Sub TTxtCodigoProveedo_TextChanged(sender As Object, e As EventArgs) Handles TxtIdProveedor.TextChanged
        If TxtIdProveedor.Text <> Nothing Then
            EpMensaje.SetError(TxtIdProveedor, "")
            TxtIdProveedor.BackColor = Color.White
        End If
    End Sub
    ' obtiene el correlativo de la Tabla Alimento que sera mostrado en TxtIdAlimento
    Private Sub InvestigarCorrelaticoProveedor()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListarCiudad As New SqlCommand("Sp_InvestigarCorrelativoProveedor", Cn)
            ListarCiudad.CommandType = CommandType.StoredProcedure
            Dim ListarCiudadR As SqlDataReader
            Cn.Open()
            ListarCiudadR = ListarCiudad.ExecuteReader()

            If ListarCiudadR.Read = True Then
                If ListarCiudadR("IdProveedor") = 1 Then
                    TxtIdProveedor.Text = 1
                Else
                    TxtIdProveedor.Text = ListarCiudadR("IdProveedor").ToString
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en investigar", "Coexmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        HabilitarBotones(True, False, True, False)
        TxtNombreProveedor.ReadOnly = True
        TxtIdProveedor.ReadOnly = True
        TxtIdProveedor.BackColor = Color.WhiteSmoke
        TxtNombreProveedor.BackColor = Color.WhiteSmoke

        TxtNombreProveedor.Text = ""
        TxtIdProveedor.Text = ""


    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            ActualizarProveedor()
            Limpiar()
            HabilitarBotones(True, False, False, False)
            MostrarProveedor()

        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtIdProveedor.Text = LsvProveedor.FocusedItem.SubItems(0).Text
        TxtNombreProveedor.Text = LsvProveedor.FocusedItem.SubItems(1).Text
        CboProducto.Text = LsvProveedor.FocusedItem.SubItems(2).Text
        TxtNombreProveedor.Enabled = True

        LlenarProducto()
        HabilitarBotones(False, False, True, True)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarProveedor()
        MostrarProveedor()
        HabilitarBotones(True, False, False, False)
    End Sub
End Class