Imports System.Data.SqlClient

Public Class FrmBinesHielo





    Private Sub InterfazBinesHielo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
        DtpFecha.Text = ""
        DtpHora.Text = ""
        TxtIdBin.ReadOnly = True
        CboIdentidadConductor.Text = ""
        TxtCantidad.ReadOnly = True
        CboProveedor.Text = ""
        CboUsuario.Text = ""
        CboPlacaCamion.Text = ""

        PbxLogo.Visible = True

    End Sub

    Private Sub LLenarCboIdentidadConductor()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarIdentidadConductor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "Conductor")
                CboIdentidadConductor.DataSource = Ds.Tables(0)
                CboIdentidadConductor.DisplayMember = Ds.Tables(0).Columns("NumIdentidadConductor").ToString
                CboIdentidadConductor.ValueMember = Ds.Tables(0).Columns("NumIdentidadConductor").ToString
            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CoexMarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LLenarCboProveedor()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "Proveedor")
                CboProveedor.DataSource = Ds.Tables(0)
                CboProveedor.DisplayMember = Ds.Tables(0).Columns("NombreProveedor").ToString
                CboProveedor.ValueMember = Ds.Tables(0).Columns("IdProveedor").ToString
            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LLenarCboPlacaCamion()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarPlaca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "Camion")
                CboPlacaCamion.DataSource = Ds.Tables(0)
                CboPlacaCamion.DisplayMember = Ds.Tables(0).Columns("NumPlaca").ToString
                CboPlacaCamion.ValueMember = Ds.Tables(0).Columns("NumPlaca").ToString
            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LLenarCboUsuario()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarUsuarioCbo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "Usuario")
                CboUsuario.DataSource = Ds.Tables(0)
                CboUsuario.DisplayMember = Ds.Tables(0).Columns("NombreUsuario").ToString
                CboUsuario.ValueMember = Ds.Tables(0).Columns("IdUsuario").ToString
            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
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
                    .Parameters.Add("@NumIdentidadConductor", SqlDbType.VarChar, 15).Value = CboIdentidadConductor.SelectedValue
                    .Parameters.Add("@NumPlaca", SqlDbType.Char, 8).Value = CboPlacaCamion.SelectedValue
                    .Parameters.Add("@Cantidad", SqlDbType.Int).Value = CInt(TxtCantidad.Text)
                    .Parameters.Add("@HoraLlegada", SqlDbType.Time).Value = DtpHora.Text
                    .Parameters.Add("@IdProveedor", SqlDbType.Int).Value = CInt(CboProveedor.SelectedValue)
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboUsuario.SelectedValue)

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al insertar Bin" + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    .Parameters.Add("@IdBinesHielo", SqlDbType.Int).Value = CInt(TxtIdBin.Text)
                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = DtpFecha.Text
                    .Parameters.Add("@NumIdentidadConductor", SqlDbType.VarChar, 15).Value = CboIdentidadConductor.SelectedValue
                    .Parameters.Add("@NumPlaca", SqlDbType.Char, 8).Value = CboPlacaCamion.SelectedValue
                    .Parameters.Add("@Cantidad", SqlDbType.Int, 4).Value = CInt(TxtCantidad.Text)
                    .Parameters.Add("@HoraLlegada", SqlDbType.Time).Value = DtpHora.Text
                    .Parameters.Add("@IdProveedor", SqlDbType.Int, 4).Value = CInt(CboProveedor.SelectedValue)
                    .Parameters.Add("@Idusuario", SqlDbType.Int, 4).Value = CInt(CboUsuario.SelectedValue)

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro modificado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al modificar Bin" + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub



    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnModificar.Enabled = Modificar
        BtnGuardar.Enabled = Guardar
        BtnCancelar.Enabled = Cancelar
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If CboPlacaCamion.Text = Nothing And TxtCantidad.Text = Nothing And CboProveedor.Text = Nothing And CboUsuario.Text = Nothing Then
            EpMensaje.SetError(TxtCantidad, "Tiene que ingresar los datos")
            TxtCantidad.Focus()

            CboPlacaCamion.BackColor = Color.LightBlue
            TxtCantidad.BackColor = Color.LightBlue
            CboProveedor.BackColor = Color.LightBlue
            CboUsuario.BackColor = Color.LightBlue

            Estado = False

        ElseIf CboPlacaCamion.Text = Nothing Then
            EpMensaje.SetError(CboPlacaCamion, "Tiene que seleccionar el número de placa")
            CboPlacaCamion.Focus()
            CboPlacaCamion.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtCantidad.Text = Nothing Then
            EpMensaje.SetError(TxtCantidad, "Tiene que ingresar la cantidad")
            TxtCantidad.Focus()
            TxtCantidad.BackColor = Color.LightBlue

            Estado = False

        ElseIf CboProveedor.Text = Nothing Then
            EpMensaje.SetError(CboProveedor, "Tiene que seleccionar el proveedor")
            CboProveedor.Focus()
            CboProveedor.BackColor = Color.LightBlue

            Estado = False

        ElseIf CboUsuario.Text = Nothing Then
            EpMensaje.SetError(CboUsuario, "Tiene que seleccionar el nombre del usuario")
            CboUsuario.Focus()
            CboUsuario.BackColor = Color.LightBlue

            Estado = False

        Else
            Estado = True

            EpMensaje.SetError(CboPlacaCamion, "")
            EpMensaje.SetError(TxtCantidad, "")
            EpMensaje.SetError(CboProveedor, "")
            EpMensaje.SetError(CboUsuario, "")

        End If

        Return Estado

    End Function

    Private Function ValidarTextBoxModificar()
        Dim Estado As Boolean

        If CboPlacaCamion.Text = Nothing And TxtCantidad.Text = Nothing And CboProveedor.Text = Nothing And CboUsuario.Text = Nothing And CboIdentidadConductor.Text = Nothing Then
            EpMensaje.SetError(TxtCantidad, "Tiene que ingresar los datos")
            TxtCantidad.Focus()

            CboPlacaCamion.BackColor = Color.LightBlue
            TxtCantidad.BackColor = Color.LightBlue
            CboProveedor.BackColor = Color.LightBlue
            CboUsuario.BackColor = Color.LightBlue

            Estado = False


        ElseIf CboPlacaCamion.Text = Nothing Then
            EpMensaje.SetError(CboPlacaCamion, "Tiene que seleccionar el número de placa")
            CboPlacaCamion.Focus()
            CboPlacaCamion.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtCantidad.Text = Nothing Then
            EpMensaje.SetError(TxtCantidad, "Tiene que ingresar la cantidad")
            TxtCantidad.Focus()
            TxtCantidad.BackColor = Color.LightBlue

            Estado = False
        ElseIf CboIdentidadConductor.Text = Nothing Then
            EpMensaje.SetError(CboIdentidadConductor, "Tiene que seleccionar la identidad del conductor")
            CboIdentidadConductor.Focus()
            CboIdentidadConductor.BackColor = Color.LightBlue

            Estado = False
        ElseIf CboProveedor.Text = Nothing Then
            EpMensaje.SetError(CboProveedor, "Tiene que seleccionar el proveedor")
            CboProveedor.Focus()
            CboProveedor.BackColor = Color.LightBlue

            Estado = False

        ElseIf CboUsuario.Text = Nothing Then
            EpMensaje.SetError(CboUsuario, "Tiene que seleccionar el nombre del usuario")
            CboUsuario.Focus()
            CboUsuario.BackColor = Color.LightBlue

            Estado = False

        Else
            Estado = True

            EpMensaje.SetError(CboPlacaCamion, "")
            EpMensaje.SetError(TxtCantidad, "")
            EpMensaje.SetError(CboProveedor, "")
            EpMensaje.SetError(CboUsuario, "")
            EpMensaje.SetError(CboIdentidadConductor, "")
        End If

        Return Estado

    End Function


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
                        .SubItems.Add(VerBinesHielo("NombreConductor").ToString)
                        .SubItems.Add(VerBinesHielo("NumPlaca").ToString)
                        .SubItems.Add(VerBinesHielo("Cantidad").ToString)
                        .SubItems.Add(VerBinesHielo("HoraLlegada").ToString)
                        .SubItems.Add(VerBinesHielo("NombreProveedor").ToString)
                        .SubItems.Add(VerBinesHielo("NombreUsuario").ToString)
                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al Mostrar Bin" + ex.ToString, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub Limpiar()
        TxtIdBin.Text = Nothing

        CboUsuario.Text = ""
        TxtCantidad.Text = Nothing
        CboProveedor.Text = ""
        CboUsuario.Text = ""
        DtpFecha.Text = Nothing
        DtpHora.Text = Nothing

    End Sub



    Private Sub TxtIdBin_TextChanged(sender As Object, e As EventArgs)
        If TxtIdBin.Text <> Nothing Then
            EpMensaje.SetError(TxtIdBin, "")
            TxtIdBin.BackColor = Color.White
        End If
    End Sub


    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs)
        If TxtCantidad.Text <> Nothing Then
            EpMensaje.SetError(TxtCantidad, "")
            TxtCantidad.BackColor = Color.White
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
                If ListarBinesHieloR("IdTabla") Is "" Then
                    TxtIdBin.Text = 1
                Else
                    TxtIdBin.Text = ListarBinesHieloR("IdTabla").ToString + 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos" + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub


    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        HabilitarBotones(False, False, True, True)
        TxtIdBin.ReadOnly = True
        LLenarCboIdentidadConductor()
        LLenarCboPlacaCamion()
        LLenarCboProveedor()
        LLenarCboUsuario()

        CboPlacaCamion.Text = ""
        CboProveedor.Text = ""
        CboUsuario.Text = ""
        TxtIdBin.Text = LsvBinesHielo.FocusedItem.SubItems(0).Text
        DtpFecha.MaxDate = LsvBinesHielo.FocusedItem.SubItems(1).Text
        CboIdentidadConductor.Text = LsvBinesHielo.FocusedItem.SubItems(2).Text
        CboPlacaCamion.Text = LsvBinesHielo.FocusedItem.SubItems(3).Text
        TxtCantidad.Text = LsvBinesHielo.FocusedItem.SubItems(4).Text
        DtpHora.Text = LsvBinesHielo.FocusedItem.SubItems(5).Text
        CboProveedor.Text = LsvBinesHielo.FocusedItem.SubItems(6).Text
        CboUsuario.Text = LsvBinesHielo.FocusedItem.SubItems(7).Text
        Dim tp As TabPage = TcDatos.TabPages(0)

        TcDatos.SelectedTab = tp
    End Sub

    Private Sub EliminarBinesHielo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarBinesHielo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    Dim Id As Integer
                    Id = CInt(LsvBinesHielo.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdBinesHielo", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el Registro", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarBinesHielo()
        MostrarTodo()
        HabilitarBotones(True, True, True, True)
    End Sub



    Private Sub CboIdentidadConductor_SelectedIndexChanged(sender As Object, e As EventArgs)
        If CboPlacaCamion.Text <> Nothing Then
            EpMensaje.SetError(CboPlacaCamion, "")
            CboPlacaCamion.BackColor = Color.White
        End If
    End Sub

    Private Sub CboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs)
        If CboProveedor.Text <> Nothing Then
            EpMensaje.SetError(CboProveedor, "")
            CboProveedor.BackColor = Color.White
        End If
    End Sub

    Private Sub CboPlacaCamion_SelectedIndexChanged(sender As Object, e As EventArgs)
        If CboUsuario.Text <> Nothing Then
            EpMensaje.SetError(CboUsuario, "")
            CboUsuario.BackColor = Color.White
        End If
    End Sub

    Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs)
        ' InterfazPrincipal.PbxLogo.Visible = True
        ' InterfazPrincipal.LblTitulo.Text = "COEXMAR-FINCA"
        Close()
    End Sub

    Private Sub BtnNuevo_Click_1(sender As Object, e As EventArgs)
        HabilitarBotones(False, True, False, True)
        TxtIdBin.ReadOnly = False
        TxtCantidad.ReadOnly = False
        TxtCantidad.Focus()
        NuevoBinHielo()
        LLenarCboIdentidadConductor()
        LLenarCboProveedor()
        LLenarCboUsuario()
        LLenarCboPlacaCamion()
    End Sub

    Private Sub BtnGuardar_Click_1(sender As Object, e As EventArgs)

        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, True, False)

            CboPlacaCamion.Text = ""
            TxtCantidad.ReadOnly = True
            CboProveedor.Text = ""
            CboUsuario.Text = ""

            GuardarBinHielo()
            MostrarTodo()
            Limpiar()
        End If
    End Sub

    Private Sub BtnModificar_Click_1(sender As Object, e As EventArgs)
        If ValidarTextBoxModificar() = True Then
            HabilitarBotones(True, False, True, False)
            TxtIdBin.ReadOnly = True
            CboIdentidadConductor.Text = ""
            CboPlacaCamion.Text = ""
            TxtCantidad.ReadOnly = True
            CboProveedor.Text = ""
            CboUsuario.Text = ""
            ModificarBinHielo()
            MostrarTodo()
            Limpiar()
        End If

    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs)
        HabilitarBotones(True, False, True, False)

        TxtIdBin.ReadOnly = True
        TxtIdBin.Text = ""
        CboPlacaCamion.Text = ""
        TxtCantidad.ReadOnly = True
        TxtCantidad.Text = ""
        DtpFecha.Text = ""
        DtpHora.Text = ""
        CboProveedor.Text = ""
        CboUsuario.Text = ""
        CboIdentidadConductor.Text = ""

        TxtIdBin.BackColor = Color.WhiteSmoke

        CboPlacaCamion.BackColor = Color.WhiteSmoke
        TxtCantidad.BackColor = Color.WhiteSmoke
        CboProveedor.BackColor = Color.WhiteSmoke
        CboUsuario.BackColor = Color.WhiteSmoke
        CboIdentidadConductor.BackColor = Color.WhiteSmoke
    End Sub
End Class