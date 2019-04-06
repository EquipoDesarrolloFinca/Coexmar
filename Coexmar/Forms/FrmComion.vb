Public Class FrmComion
    Private Sub ChkVer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.CheckState = CheckState.Checked Then
            LsvCamion.Visible = True
            PbxLogo.Visible = False
            'MostrarTodo()'
        Else
            PbxLogo.Visible = True
            LsvCamion.Visible = False
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        'NuevoAlimento()'
        TxtContratista.ReadOnly = False
        HabilitarBotones(False, True, False, True)
        TxtContratista.Focus()
    End Sub
    ' controla el estado de los botones (Habilitado o Inabilitado)
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnModificar.Enabled = Modificar
        BtnGuardar.Enabled = Guardar
        BtnCancelar.Enabled = Cancelar
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        HabilitarBotones(True, False, True, False)
        TxtContratista.ReadOnly = True
        ' GuardarAlimento()
        ' MostrarTodo()'
        'Limpiar()'

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        HabilitarBotones(True, False, True, False)
        TxtContratista.ReadOnly = True
        TxtNumPlaca.ReadOnly = True
        TxtNumPlaca.BackColor = Color.WhiteSmoke
        'ModificarAlimento()'
        ' MostrarTodo()'
        'Limpiar()'

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        HabilitarBotones(True, False, True, False)
        TxtContratista.ReadOnly = True
        TxtNumPlaca.ReadOnly = True
        TxtContratista.BackColor = Color.WhiteSmoke
        TxtContratista.BackColor = Color.WhiteSmoke

        TxtContratista.Text = ""
        TxtNumPlaca.Text = ""
    End Sub
End Class