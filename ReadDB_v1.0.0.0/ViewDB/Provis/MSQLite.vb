Imports System.Data.SQLite
Module MSQLite
    Private SQLiCon As New SQLiteConnection(Inicio.TxBCStri.Text)

    Sub SQLiTest()
        Try
            SQLiCon.Open()
            Inicio.EsCon = True
            SQLiCon.Close()
        Catch ex As Exception
            Inicio.EsCon = False
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub SQLiCons(ByVal Tabla As DataGridView, ByVal SQL As String)
        Try
            Dim DA As New SQLiteDataAdapter(SQL, SQLiCon)
            Dim DT As New DataTable
            DA.Fill(DT)
            Tabla.DataSource = DT
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function SQLiRell(ByVal SQL As String)
        Dim DT As New DataTable
        Try
            Dim DA As New SQLiteDataAdapter(SQL, SQLiCon)
            DA.Fill(DT)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DT
    End Function

    Sub SQLiOper(ByVal Tabla As DataGridView, ByVal SQL As String)
        SQLiCon.Open()
        Try
            Dim CMD As New SQLiteCommand(SQL, SQLiCon)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        SQLiCon.Close()
    End Sub
End Module