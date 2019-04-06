Imports System.Data.SqlClient


Public Class FrmAlimento
    Dim EstadoModificado As Boolean
    ' Cierra el formulario hijo y cambia el titulo del formulario padre 
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        ' InterfazPrincipal.PbxLogo.Visible = True
        ' InterfazPrincipal.LblTitulo.Text = "COEXMAR-FINCA"
        Close()
    End Sub
    ' Se cargan las instrucciones que se ejecutaran al iniciar el formulario
    Private Sub InterfazAlimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoModificado = False
        TxtAlimento.ReadOnly = True
        TxtIdAlimento.ReadOnly = True
        PbxLogo.Visible = True
        LsvAlimentos.Visible = False
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
                    .CommandText = "Sp_InsertarAlimento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Alimento", SqlDbType.NVarChar, 30).Value = TxtAlimento.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al insertar el alimento", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    .CommandText = "Sp_ModificarAlimento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    .Parameters.Add("@IdAlimento", SqlDbType.Int).Value = CInt(TxtIdAlimento.Text)
                    .Parameters.Add("@Alimento", SqlDbType.NVarChar, 30).Value = TxtAlimento.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro modificado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al modificar el alimento", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
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

        If TxtAlimento.Text = Nothing Then
            EpMensaje.SetError(TxtAlimento, "Tiene que ingresar el alimento")
            TxtAlimento.Focus()
            TxtAlimento.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtAlimento, "")

        End If
        Return Estado
    End Function

    Private Function ValidarTextBoxModificar()
        Dim Estado As Boolean

        If TxtAlimento.Text = Nothing And TxtIdAlimento.Text = Nothing Then
            EpMensaje.SetError(TxtIdAlimento, "Tiene que ingresar Codigo Alimento")
            EpMensaje.SetError(TxtAlimento, "Tiene que ingresar Alimento")
            TxtIdAlimento.Focus()
            TxtIdAlimento.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtIdAlimento.Text = Nothing Then
            EpMensaje.SetError(TxtIdAlimento, "Tiene que ingresar el Codigo Alimento")
            TxtIdAlimento.Focus()
            TxtIdAlimento.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtAlimento.Text = Nothing Then
            EpMensaje.SetError(TxtAlimento, "Tiene que ingresar el alimento")
            TxtAlimento.Focus()
            TxtAlimento.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtAlimento, "")
            EpMensaje.SetError(TxtIdAlimento, "")

        End If
        Return Estado
    End Function
    ' Pone en blanco los TextBox
    Private Sub Limpiar()
        TxtIdAlimento.Text = Nothing
        TxtAlimento.Text = Nothing
    End Sub

    ' resetea el Error Provider (EpMensaje)
    ' y coloca su color de fondo Habitual (Blanco)
    Private Sub TxtAlimento_TextChanged(sender As Object, e As EventArgs) Handles TxtAlimento.TextChanged

    End Sub

    Private Sub TxtIdAlimento_TextChanged(sender As Object, e As EventArgs) Handles TxtIdAlimento.TextChanged
        If TxtIdAlimento.Text <> Nothing Then
            EpMensaje.SetError(TxtIdAlimento, "")
            TxtIdAlimento.BackColor = Color.White
        End If
    End Sub
    ' obtiene el correlativo de la Tabla Alimento que sera mostrado en TxtIdAlimento
    Private Sub NuevoAlimento()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListaAlimento As New SqlCommand("Sp_InvestigarCorrelativo", Cn)
            ListaAlimento.CommandType = CommandType.StoredProcedure
            ListaAlimento.Parameters.Add("@NombreTabla", SqlDbType.NVarChar, 30).Value = "Alimento"
            Dim ListarAlimentoR As SqlDataReader
            Cn.Open()
            ListarAlimentoR = ListaAlimento.ExecuteReader()

            If ListarAlimentoR.Read = True Then
                If ListarAlimentoR("IdTabla") Is "" Then
                    TxtIdAlimento.Text = 1
                Else
                    TxtIdAlimento.Text = ListarAlimentoR("IdTabla").ToString + 1
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
        TxtAlimento.ReadOnly = True
        TxtIdAlimento.ReadOnly = True
        TxtIdAlimento.BackColor = Color.WhiteSmoke
        TxtAlimento.BackColor = Color.WhiteSmoke

        TxtAlimento.Text = ""
        TxtIdAlimento.Text = ""


    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBoxModificar() = True Then
            HabilitarBotones(True, False, True, False)
            TxtAlimento.ReadOnly = True
            TxtIdAlimento.ReadOnly = True
            ModificarAlimento()
            MostrarTodo()
            Limpiar()
        End If

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        HabilitarBotones(False, False, True, True)
        TxtAlimento.ReadOnly = False
        TxtIdAlimento.Text = LsvAlimentos.FocusedItem.SubItems(0).Text
        TxtAlimento.Text = LsvAlimentos.FocusedItem.SubItems(1).Text
    End Sub

    Private Sub EliminarAlimentos()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarAlimentos"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    Dim Id As Integer
                    Id = CInt(LsvAlimentos.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdAlimento", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el alimento", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarAlimentos()
        MostrarTodo()
        HabilitarBotones(True, True, True, True)
    End Sub
End Class


