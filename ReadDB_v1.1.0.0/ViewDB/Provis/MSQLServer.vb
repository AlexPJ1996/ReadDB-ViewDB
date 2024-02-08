Imports System.Data.SqlClient
Module MSQLServer
    Private ReadOnly SQLSCon As New SqlConnection(Inicio.TxBCStri.Text)

    Sub SQLSTest()
        Try
            SQLSCon.Open()
            Inicio.EsCon = True
            SQLSCon.Close()
        Catch ex As Exception
            Inicio.EsCon = False
            MessageBox.Show(ex.Message)
            Application.Restart()
        End Try
    End Sub

    Sub SQLSCons(ByVal Tabla As DataGridView, ByVal SQL As String)
        Try
            Dim DA As New SqlDataAdapter(SQL, SQLSCon)
            Dim DT As New DataTable
            DA.Fill(DT)
            Tabla.DataSource = DT
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function SQLSRell(ByVal SQL As String)
        Dim DT As New DataTable
        Try
            Dim DA As New SqlDataAdapter(SQL, SQLSCon)
            DA.Fill(DT)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DT
    End Function

    Sub SQLSOper(ByVal Tabla As DataGridView, ByVal SQL As String)
        SQLSCon.Open()
        Try
            Dim CMD As New SqlCommand(SQL, SQLSCon)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        SQLSCon.Close()
    End Sub
End Module