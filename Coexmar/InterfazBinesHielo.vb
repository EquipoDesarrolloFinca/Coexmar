Imports System.Data.SqlClient

Public Class InterfazBinesHielo
    Dim EstadoModificado As Boolean
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        ' InterfazPrincipal.PbxLogo.Visible = True
        ' InterfazPrincipal.LblTitulo.Text = "COEXMAR-FINCA"
        Close()
    End Sub

    Private Sub ChkVer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.CheckState = CheckState.Checked Then
            LsvBinesHielo.Visible = True
            PbxLogo.Visible = False
            MostrarTodo()
        Else
            PbxLogo.Visible = True
            LsvBinesHielo.Visible = False
        End If
    End Sub

    Private Sub InterfazBinesHielo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoModificado = False
        TxtIdConductor.ReadOnly = True
        TxtIdBin.ReadOnly = True
        TxtPlaca.ReadOnly = True
        TxtCantidad.ReadOnly = True
        TxtProveedor.ReadOnly = True
        TxtUsuario.ReadOnly = True
        PbxLogo.Visible = True
        LsvBinesHielo.Visible = False
    End Sub
    ' Almacena datos en la tabla Alimento
    Private Sub GuardarBinHielo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarBinesHielo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = DtpFecha.Text
                    .Parameters.Add("@NumIdentidadConductor", SqlDbType.VarChar, 15).Value = TxtIdConductor.Text
                    .Parameters.Add("@NumPlaca", SqlDbType.Char, 8).Value = TxtPlaca.Text
                    .Parameters.Add("@Cantidad", SqlDbType.Int, 4).Value = TxtCantidad.Text
                    .Parameters.Add("@HoraLlegada", SqlDbType.Time).Value = DtpHora.Text
                    .Parameters.Add("@IdProveedor", SqlDbType.Int, 4).Value = TxtProveedor.Text
                    .Parameters.Add("@Idusiario", SqlDbType.Int, 4).Value = TxtUsuario.Text

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al insertar Bin", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
    ' 
    Private Sub ModificarBinHielo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ModificarBinesHielo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = DtpFecha.Text
                    .Parameters.Add("@NumIdentidadConductor", SqlDbType.VarChar, 15).Value = TxtIdConductor.Text
                    .Parameters.Add("@NumPlaca", SqlDbType.Char, 8).Value = TxtPlaca.Text
                    .Parameters.Add("@Cantidad", SqlDbType.Int, 4).Value = TxtCantidad.Text
                    .Parameters.Add("@HoraLlegada", SqlDbType.Time).Value = DtpHora.Text
                    .Parameters.Add("@IdProveedor", SqlDbType.Int, 4).Value = TxtProveedor.Text
                    .Parameters.Add("@Idusiario", SqlDbType.Int, 4).Value = TxtUsuario.Text

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro modificado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al modificar Bin", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        NuevoBinHielo()
        TxtIdConductor.ReadOnly = False
        TxtIdBin.ReadOnly = False
        TxtPlaca.ReadOnly = False
        TxtCantidad.ReadOnly = False
        TxtProveedor.ReadOnly = False
        TxtUsuario.ReadOnly = False
        HabilitarBotones(False, True, False, True)
        TxtIdConductor.Focus()

    End Sub

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnModificar.Enabled = Modificar
        BtnGuardar.Enabled = Guardar
        BtnCancelar.Enabled = Cancelar
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtIdConductor.Text = Nothing And TxtPlaca.Text = Nothing And TxtCantidad.Text = Nothing And TxtProveedor.Text = Nothing And TxtUsuario.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar los datos")
            TxtIdConductor.Focus()
            TxtIdConductor.BackColor = Color.LightBlue
            TxtPlaca.BackColor = Color.LightBlue
            TxtCantidad.BackColor = Color.LightBlue
            TxtProveedor.BackColor = Color.LightBlue
            TxtUsuario.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtPlaca.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar el número de placa")
            TxtPlaca.Focus()
            TxtPlaca.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtCantidad.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar la cantidad")
            TxtCantidad.Focus()
            TxtCantidad.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtProveedor.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar el el proveedor")
            TxtProveedor.Focus()
            TxtProveedor.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtUsuario.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar el código del usuario")
            TxtUsuario.Focus()
            TxtUsuario.BackColor = Color.LightBlue

            Estado = False

        Else
            Estado = True
            EpMensaje.SetError(TxtIdConductor, "")
            EpMensaje.SetError(TxtPlaca, "")
            EpMensaje.SetError(TxtCantidad, "")
            EpMensaje.SetError(TxtProveedor, "")
            EpMensaje.SetError(TxtUsuario, "")

        End If

        Return Estado

    End Function

    Private Function ValidarTextBoxModificar()
        Dim Estado As Boolean

        If TxtIdConductor.Text = Nothing And TxtPlaca.Text = Nothing And TxtCantidad.Text = Nothing And TxtProveedor.Text = Nothing And TxtUsuario.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar los datos")
            TxtIdConductor.Focus()
            TxtIdConductor.BackColor = Color.LightBlue
            TxtPlaca.BackColor = Color.LightBlue
            TxtCantidad.BackColor = Color.LightBlue
            TxtProveedor.BackColor = Color.LightBlue
            TxtUsuario.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtPlaca.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar el número de placa")
            TxtPlaca.Focus()
            TxtPlaca.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtCantidad.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar la cantidad")
            TxtCantidad.Focus()
            TxtCantidad.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtProveedor.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar el el proveedor")
            TxtProveedor.Focus()
            TxtProveedor.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtUsuario.Text = Nothing Then
            EpMensaje.SetError(TxtIdConductor, "Tiene que ingresar el código del usuario")
            TxtUsuario.Focus()
            TxtUsuario.BackColor = Color.LightBlue

            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtIdConductor, "")
            EpMensaje.SetError(TxtIdBin, "")
            EpMensaje.SetError(TxtPlaca, "")
            EpMensaje.SetError(TxtCantidad, "")
            EpMensaje.SetError(TxtProveedor, "")
            EpMensaje.SetError(TxtUsuario, "")

        End If
        Return Estado
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If EstadoModificado = True Then
            If ValidarTextBoxModificar() = True Then
                HabilitarBotones(True, False, True, False)
                TxtIdBin.ReadOnly = True
                TxtIdConductor.ReadOnly = True
                TxtPlaca.ReadOnly = True
                TxtCantidad.ReadOnly = True
                TxtProveedor.ReadOnly = True
                TxtUsuario.ReadOnly = True
                ModificarBinHielo()
                MostrarTodo()
                Limpiar()

                EstadoModificado = False

            End If
        Else
            If ValidarTextBox() = True Then
                HabilitarBotones(True, False, True, False)
                TxtIdConductor.ReadOnly = True
                TxtPlaca.ReadOnly = True
                TxtCantidad.ReadOnly = True
                TxtProveedor.ReadOnly = True
                TxtUsuario.ReadOnly = True

                GuardarBinHielo()
                MostrarTodo()
                Limpiar()
            End If
        End If

    End Sub

    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarBinesHielo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerBinesHielo As SqlDataReader
                VerBinesHielo = CMd.ExecuteReader

                LsvBinesHielo.Items.Clear()
                While VerBinesHielo.Read = True
                    With LsvBinesHielo.Items.Add(VerBinesHielo("IdBinesHielo").ToString)
                        .SubItems.Add(VerBinesHielo("Fecha").ToString)
                        .SubItems.Add(VerBinesHielo("NumIdentidadConductor").ToString)
                        .SubItems.Add(VerBinesHielo("NumPlaca").ToString)
                        .SubItems.Add(VerBinesHielo("Cantidad").ToString)
                        .SubItems.Add(VerBinesHielo("HoraLlegada").ToString)
                        .SubItems.Add(VerBinesHielo("IdProveedor").ToString)
                        .SubItems.Add(VerBinesHielo("IdUsuario").ToString)
                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al insertar Bin" + ex.ToString, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub Limpiar()
        TxtIdBin.Text = Nothing
        TxtIdConductor.Text = Nothing
        TxtPlaca.Text = Nothing
        TxtCantidad.Text = Nothing
        TxtProveedor.Text = Nothing
        TxtUsuario.Text = Nothing
        DtpFecha.Text = Nothing
        DtpHora.Text = Nothing

    End Sub

    Private Sub TxtIdConductor_TextChanged(sender As Object, e As EventArgs) Handles TxtIdConductor.TextChanged
        If TxtIdConductor.Text <> Nothing Then
            EpMensaje.SetError(TxtIdConductor, "")
            TxtIdConductor.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtIdBin_TextChanged(sender As Object, e As EventArgs) Handles TxtIdBin.TextChanged
        If TxtIdBin.Text <> Nothing Then
            EpMensaje.SetError(TxtIdBin, "")
            TxtIdBin.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtPlaca_TextChanged(sender As Object, e As EventArgs) Handles TxtPlaca.TextChanged
        If TxtPlaca.Text <> Nothing Then
            EpMensaje.SetError(TxtPlaca, "")
            TxtPlaca.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        If TxtCantidad.Text <> Nothing Then
            EpMensaje.SetError(TxtCantidad, "")
            TxtCantidad.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtProveedor_TextChanged(sender As Object, e As EventArgs) Handles TxtProveedor.TextChanged
        If TxtProveedor.Text <> Nothing Then
            EpMensaje.SetError(TxtProveedor, "")
            TxtProveedor.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged
        If TxtUsuario.Text <> Nothing Then
            EpMensaje.SetError(TxtUsuario, "")
            TxtUsuario.BackColor = Color.White
        End If
    End Sub

    Private Sub NuevoBinHielo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListaBinHielo As New SqlCommand("Sp_InvestigarCorrelativo", Cn)
            ListaBinHielo.CommandType = CommandType.StoredProcedure
            ListaBinHielo.Parameters.Add("@NombreTabla", SqlDbType.NVarChar, 30).Value = "BinesHielo"
            Dim ListarBinesHieloR As SqlDataReader
            Cn.Open()
            ListarBinesHieloR = ListaBinHielo.ExecuteReader()

            If ListarBinesHieloR.Read = True Then
                If ListarBinesHieloR("IdBinesHielo") Is "" Then
                    TxtIdBin.Text = 1
                Else
                    TxtIdBin.Text = ListarBinesHieloR("IdBinesHielo").ToString + 1
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
        TxtIdConductor.ReadOnly = True
        TxtIdBin.ReadOnly = True
        TxtPlaca.ReadOnly = True
        TxtCantidad.ReadOnly = True
        TxtProveedor.ReadOnly = True
        TxtUsuario.ReadOnly = True

        TxtIdBin.BackColor = Color.WhiteSmoke
        TxtIdConductor.BackColor = Color.WhiteSmoke
        TxtPlaca.BackColor = Color.WhiteSmoke
        TxtCantidad.BackColor = Color.WhiteSmoke
        TxtProveedor.BackColor = Color.WhiteSmoke
        TxtUsuario.BackColor = Color.WhiteSmoke

        TxtIdConductor.Text = ""
        TxtIdBin.Text = ""
        TxtPlaca.Text = ""
        TxtCantidad.Text = ""
        TxtProveedor.Text = ""
        TxtUsuario.Text = ""

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        EstadoModificado = True
        HabilitarBotones(False, True, False, True)
        TxtIdConductor.ReadOnly = False
        TxtIdBin.ReadOnly = False
        TxtPlaca.ReadOnly = False
        TxtCantidad.ReadOnly = False
        TxtProveedor.ReadOnly = False
        TxtUsuario.ReadOnly = False

        TxtIdBin.Focus()
        LsvBinesHielo.Visible = True
        PbxLogo.Visible = False
        ChkVer.Checked = True
    End Sub


End Class