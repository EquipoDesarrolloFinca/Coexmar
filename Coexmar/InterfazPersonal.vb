Imports System.Data.SqlClient

Public Class InterfazPersonal
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
            LsvPersonal.Visible = True
            PbxLogo.Visible = False
            MostrarTodo()
        Else
            PbxLogo.Visible = True
            LsvPersonal.Visible = False
        End If
    End Sub
    ' Se cargan las instrucciones que se ejecutaran al iniciar el formulario
    Private Sub InterfazProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoModificado = False
        TxtNombre.ReadOnly = True
        TxtNumIdentidad.ReadOnly = True
        PbxLogo.Visible = True
        LsvPersonal.Visible = False
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

                    .Parameters.Add("@NombreProveedor", SqlDbType.NVarChar, 40).Value = TxtNombre.Text
                    .Parameters.Add("@NombreProveedor", SqlDbType.NVarChar, 40).Value = TxtNombre.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al insertar el Proveedor", "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
End Class