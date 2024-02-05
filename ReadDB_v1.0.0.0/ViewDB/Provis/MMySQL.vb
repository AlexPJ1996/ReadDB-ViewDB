Imports MySqlConnector
Module MMySQL
    Private MSQLCon As New MySqlConnection(Inicio.TxBCStri.Text)

    Sub MSQLTest()
        Try
            MSQLCon.Open()
            Inicio.EsCon = True
            MSQLCon.Close()
        Catch ex As Exception
            Inicio.EsCon = False
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MSQLCons(ByVal Tabla As DataGridView, ByVal SQL As String)
        Try
            Dim DA As New MySqlDataAdapter(SQL, MSQLCon)
            Dim DT As New DataTable
            DA.Fill(DT)
            Tabla.DataSource = DT
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function MSQLRell(ByVal SQL As String)
        Dim DT As New DataTable
        Try
            Dim DA As New MySqlDataAdapter(SQL, MSQLCon)
            DA.Fill(DT)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DT
    End Function

    Sub MSQLOper(ByVal Tabla As DataGridView, ByVal SQL As String)
        MSQLCon.Open()
        Try
            Dim CMD As New MySqlCommand(SQL, MSQLCon)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MSQLCon.Close()
    End Sub
End Module