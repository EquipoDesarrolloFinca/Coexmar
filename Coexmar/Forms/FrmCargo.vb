Imports System.Data.SqlClient
Public Class FrmCargo
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
            LsvCargo.Visible = True
            PbxLogo.Visible = False
            MostrarTodo()
        Else
            PbxLogo.Visible = True
            LsvCargo.Visible = False
        End If
    End Sub
    ' Se cargan las instrucciones que se ejecutaran al iniciar el formulario
    Private Sub InterfazAlimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoModificado = False
        TxtCargo.ReadOnly = True
        TxtCargo.ReadOnly = True
        PbxLogo.Visible = True
        LsvCargo.Visible = False
    End Sub
    ' Almacena datos en la tabla Alimento
    Private Sub GuardarCargo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Cargo", SqlDbType.NVarChar, 30).Value = TxtCargo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al insertar el Cargo", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
    ' 
    Private Sub ModificarCargo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ModificarCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    .Parameters.Add("@IdCargo", SqlDbType.NVarChar, 30).Value = TxtIdCargo.Text
                    .Parameters.Add("@Cargo", SqlDbType.NVarChar, 30).Value = TxtCargo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro modificado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al modificar el Cargo", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    ' bloquea los botones,excepto BtnGuardar. ejecuta el Sub procedimiento NuevoAlimento(), habilita el TxtAlimento y lo enfoca 
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        NuevoCargo()
        TxtCargo.ReadOnly = False
        HabilitarBotones(False, True, False, True)
        TxtCargo.Focus()

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

        If TxtCargo.Text = Nothing Then
            EpMensaje.SetError(TxtCargo, "Tiene que ingresar el Cargo")
            TxtCargo.Focus()
            TxtCargo.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtCargo, "")

        End If
        Return Estado
    End Function

    Private Function ValidarTextBoxModificar()
        Dim Estado As Boolean

        If TxtCargo.Text = Nothing And TxtIdCargo.Text = Nothing Then
            EpMensaje.SetError(TxtIdCargo, "Tiene que ingresar Codigo Cargo")
            EpMensaje.SetError(TxtCargo, "Tiene que ingresar Cargo")
            TxtIdCargo.Focus()
            TxtIdCargo.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtIdCargo.Text = Nothing Then
            EpMensaje.SetError(TxtIdCargo, "Tiene que ingresar el Codigo Cargo")
            TxtIdCargo.Focus()
            TxtIdCargo.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtCargo.Text = Nothing Then
            EpMensaje.SetError(TxtCargo, "Tiene que ingresar el Cargo")
            TxtCargo.Focus()
            TxtCargo.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtCargo, "")
            EpMensaje.SetError(TxtIdCargo, "")

        End If
        Return Estado
    End Function
    ' habilita el BtnNuevo y el BtnModificar
    ' inserta en la tabla Alimento,gracias al Sub procedimiento GuardarAlimento()
    ' Muestra los datos de la tabla en LsvAlimento gracias al Sub Procedimiento MostrarTodo()
    ' Limpia Los TextBox gracias al Sub Procedimiento Limpiar()
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, True, False)
            TxtCargo.ReadOnly = True
            GuardarCargo()
            MostrarTodo()
            Limpiar()
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
                    .CommandText = "Sp_MostrarCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerSector As SqlDataReader
                VerSector = CMd.ExecuteReader

                LsvCargo.Items.Clear()
                While VerSector.Read = True
                    With LsvCargo.Items.Add(VerSector("IdCargo").ToString)
                        .SubItems.Add(VerSector("Cargo").ToString)
                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al Mostrar Cargo", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub
    ' Pone en blanco los TextBox
    Private Sub Limpiar()
        TxtIdCargo.Text = Nothing
        TxtCargo.Text = Nothing
    End Sub

    ' resetea el Error Provider (EpMensaje)
    ' y coloca su color de fondo Habitual (Blanco)
    Private Sub TxtCargo_TextChanged(sender As Object, e As EventArgs) Handles TxtCargo.TextChanged
        If TxtCargo.Text <> Nothing Then
            EpMensaje.SetError(TxtCargo, "")
            TxtCargo.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtIdSector_TextChanged(sender As Object, e As EventArgs) Handles TxtIdCargo.TextChanged
        If TxtIdCargo.Text <> Nothing Then
            EpMensaje.SetError(TxtIdCargo, "")
            TxtIdCargo.BackColor = Color.White
        End If
    End Sub
    ' obtiene el correlativo de la Tabla Alimento que sera mostrado en TxtIdAlimento
    Private Sub NuevoCargo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListaCargo As New SqlCommand("Sp_InvestigarCorrelativo", Cn)
            ListaCargo.CommandType = CommandType.StoredProcedure
            ListaCargo.Parameters.Add("@NombreTabla", SqlDbType.NVarChar, 30).Value = "Cargo"
            Dim ListarCargoR As SqlDataReader
            Cn.Open()
            ListarCargoR = ListaCargo.ExecuteReader()

            If ListarCargoR.Read = True Then
                If ListarCargoR("IdTabla") Is "" Then
                    TxtIdCargo.Text = 1
                Else
                    TxtIdCargo.Text = ListarCargoR("IdTabla").ToString + 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos" + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        HabilitarBotones(True, False, True, False)
        TxtCargo.ReadOnly = True
        TxtIdCargo.ReadOnly = True
        TxtIdCargo.BackColor = Color.WhiteSmoke
        TxtCargo.BackColor = Color.WhiteSmoke

        TxtCargo.Text = ""
        TxtIdCargo.Text = ""


    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBoxModificar() = True Then
            HabilitarBotones(True, False, True, False)
            TxtCargo.ReadOnly = True
            TxtIdCargo.ReadOnly = False
            ModificarCargo()
            MostrarTodo()
            Limpiar()

        End If
    End Sub



    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        HabilitarBotones(False, False, True, True)
        TxtCargo.ReadOnly = False
        TxtIdCargo.Text = LsvCargo.FocusedItem.SubItems(0).Text
        TxtCargo.Text = LsvCargo.FocusedItem.SubItems(1).Text
    End Sub

    Private Sub EliminarCargo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    Dim Id As Integer
                    Id = CInt(LsvCargo.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdCargo", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el Cargo", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarCargo()
        MostrarTodo()
        HabilitarBotones(True, True, True, True)
    End Sub

End Class