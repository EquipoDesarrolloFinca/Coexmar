Imports System.Data.SqlClient

Public Class FrmIngresoCombustible
    Private Sub FrmIngresoCombustible_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarTodo()

        TxtCodigoIngresoCombustible.ReadOnly = True
        DtpFecha.Text = ""
        DtpHoraEntrada.Text = ""
        CboNombreConductor.Text = ""
        CboNumeroPlaca.Text = ""
        CboTipoCombustible.Text = ""
        TxtTotalGalCombustible.ReadOnly = True
        DtpHoraSalida.Text = ""

        PbxLogo.Visible = True

    End Sub


    Private Sub LLenarCboNombreConductor()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarNombreConductor"
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

End Class