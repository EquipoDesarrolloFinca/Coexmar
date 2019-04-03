Public Class FrmCamion
    Private Sub LsvAlimentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvCamion.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

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
End Class