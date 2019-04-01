Imports System.Data.SqlClient

Public Class InterfazSector
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
            LsvSector.Visible = True
            PbxLogo.Visible = False
            MostrarTodo()
        Else
            PbxLogo.Visible = True
            LsvSector.Visible = False
        End If
    End Sub
    ' Se cargan las instrucciones que se ejecutaran al iniciar el formulario
    Private Sub InterfazAlimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoModificado = False
        TxtSector.ReadOnly = True
        TxtSector.ReadOnly = True
        PbxLogo.Visible = True
        LsvSector.Visible = False
    End Sub
    ' Almacena datos en la tabla Alimento
    Private Sub GuardarAlimento()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarSector"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NombreSector", SqlDbType.NVarChar, 30).Value = TxtSector.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al insertar el Sector", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
    ' 
    Private Sub ModificarAlimento()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ModificarSector"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    .Parameters.Add("@IdSector", SqlDbType.NVarChar, 30).Value = TxtIdSector.Text
                    .Parameters.Add("@NombreSector", SqlDbType.NVarChar, 30).Value = TxtSector.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro modificado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al modificar el Sector", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    ' bloquea los botones,excepto BtnGuardar. ejecuta el Sub procedimiento NuevoAlimento(), habilita el TxtAlimento y lo enfoca 
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        NuevoSector()
        TxtSector.ReadOnly = False
        HabilitarBotones(False, True, False, True)
        TxtSector.Focus()

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

        If TxtSector.Text = Nothing Then
            EpMensaje.SetError(TxtSector, "Tiene que ingresar el Sector")
            TxtSector.Focus()
            TxtSector.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtSector, "")

        End If
        Return Estado
    End Function

    Private Function ValidarTextBoxModificar()
        Dim Estado As Boolean

        If TxtSector.Text = Nothing And TxtIdSector.Text = Nothing Then
            EpMensaje.SetError(TxtIdSector, "Tiene que ingresar Codigo Sector")
            EpMensaje.SetError(TxtSector, "Tiene que ingresar Sector")
            TxtIdSector.Focus()
            TxtIdSector.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtIdSector.Text = Nothing Then
            EpMensaje.SetError(TxtIdSector, "Tiene que ingresar el Codigo Sector")
            TxtIdSector.Focus()
            TxtIdSector.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtSector.Text = Nothing Then
            EpMensaje.SetError(TxtSector, "Tiene que ingresar el Sector")
            TxtSector.Focus()
            TxtSector.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtSector, "")
            EpMensaje.SetError(TxtIdSector, "")

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
                TxtSector.ReadOnly = True
                TxtIdSector.ReadOnly = True
                ModificarAlimento()
                MostrarTodo()
                Limpiar()
                EstadoModificado = False
            End If
        Else
            If ValidarTextBox() = True Then
                HabilitarBotones(True, False, True, False)
                TxtSector.ReadOnly = True
                GuardarAlimento()
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
                    .CommandText = "Sp_MostrarSector"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerSector As SqlDataReader
                VerSector = CMd.ExecuteReader

                LsvSector.Items.Clear()
                While VerSector.Read = True
                    With LsvSector.Items.Add(VerSector("IdSector").ToString)
                        .SubItems.Add(VerSector("NombreSector").ToString)
                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al insertar Sector", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub
    ' Pone en blanco los TextBox
    Private Sub Limpiar()
        TxtIdSector.Text = Nothing
        TxtSector.Text = Nothing
    End Sub

    ' resetea el Error Provider (EpMensaje)
    ' y coloca su color de fondo Habitual (Blanco)
    Private Sub TxtAlimento_TextChanged(sender As Object, e As EventArgs) Handles TxtSector.TextChanged
        If TxtSector.Text <> Nothing Then
            EpMensaje.SetError(TxtSector, "")
            TxtSector.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtIdSector_TextChanged(sender As Object, e As EventArgs) Handles TxtIdSector.TextChanged
        If TxtIdSector.Text <> Nothing Then
            EpMensaje.SetError(TxtIdSector, "")
            TxtIdSector.BackColor = Color.White
        End If
    End Sub
    ' obtiene el correlativo de la Tabla Alimento que sera mostrado en TxtIdAlimento
    Private Sub NuevoSector()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListaSector As New SqlCommand("Sp_InvestigarCorrelativo", Cn)
            ListaSector.CommandType = CommandType.StoredProcedure
            ListaSector.Parameters.Add("@NombreTabla", SqlDbType.NVarChar, 30).Value = "Sector"
            Dim ListarSectorR As SqlDataReader
            Cn.Open()
            ListarSectorR = ListaSector.ExecuteReader()

            If ListarSectorR.Read = True Then
                If ListarSectorR("IdSector") Is "" Then
                    TxtIdSector.Text = 1
                Else
                    TxtIdSector.Text = ListarSectorR("IdSector").ToString + 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos" + ex.Message, "CientificaMusic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        HabilitarBotones(True, False, True, False)
        TxtSector.ReadOnly = True
        TxtIdSector.ReadOnly = True
        TxtIdSector.BackColor = Color.WhiteSmoke
        TxtSector.BackColor = Color.WhiteSmoke

        TxtSector.Text = ""
        TxtIdSector.Text = ""


    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        EstadoModificado = True
        HabilitarBotones(False, True, False, True)
        TxtSector.ReadOnly = False
        TxtIdSector.ReadOnly = False
        TxtIdSector.Focus()
        LsvSector.Visible = True
        PbxLogo.Visible = False
        ChkVer.Checked = True
    End Sub


End Class