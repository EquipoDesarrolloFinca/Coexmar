Public Class FrmConductor
    Private Sub ChkVer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.CheckState = CheckState.Checked Then
            LsvConductor.Visible = True
            PbxLogo.Visible = False
            'MostrarTodo()'
        Else
            PbxLogo.Visible = True
            LsvConductor.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class