Public Class Inicio
    Public SQL As String
    Public EsCon As Boolean

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormProp()
        EsCon = False
    End Sub

    Sub FormProp()
        'Form
        Text = My.Application.Info.Title
        BackColor = Color.SteelBlue
        'Controles
        DGVDatos.RowsDefaultCellStyle.BackColor = Color.LightSeaGreen
        DGVDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        'Enabled = False
        ButLoadT.Enabled = False
        ButCleaT.Enabled = False
        CBxTabla.Enabled = False
        ButLData.Enabled = False
        ButCData.Enabled = False
    End Sub

    Private Sub ButConnO_Click(sender As Object, e As EventArgs) Handles ButConnO.Click
        If Trim(CBxProvi.Text) = String.Empty Then
            MessageBox.Show("Seleccione un proveedor de datos")
            CBxProvi.Focus()
        ElseIf Trim(TxBCStri.Text) = String.Empty Then
            MessageBox.Show("Escriba el ConecctionString/Cadena de conexión para la base de datos")
            TxBCStri.Focus()
        Else
            Select Case CBxProvi.Text
                Case "SQL Server"
                    Try
                        SQLSTest()
                    Catch ex As Exception
                        EsCon = False
                        MessageBox.Show(ex.Message)
                        Application.Restart()
                    End Try

                Case "MySQL"
                    Try
                        MSQLTest()
                    Catch ex As Exception
                        EsCon = False
                        MessageBox.Show(ex.Message)
                        Application.Restart()
                    End Try

                Case "SQLite"
                    Try
                        SQLiTest()
                    Catch ex As Exception
                        EsCon = False
                        MessageBox.Show(ex.Message)
                        Application.Restart()
                    End Try

            End Select

            If EsCon = True Then
                CBxProvi.Enabled = False
                TxBCStri.Enabled = False
                ButConnO.Enabled = False

                ButLoadT.Enabled = True
                ButCleaT.Enabled = True
                CBxTabla.Enabled = True
                ButLData.Enabled = True
                ButCData.Enabled = True
            End If
        End If
    End Sub

    Private Sub ButConnC_Click(sender As Object, e As EventArgs) Handles ButConnC.Click
        If EsCon = True Then
            ButLoadT.Enabled = False
            ButCleaT.Enabled = False
            CBxTabla.Enabled = False
            ButLData.Enabled = False
            ButCData.Enabled = False
            ButCleaT_Click(sender, e)

            CBxProvi.ResetText()
            TxBCStri.Clear()
            EsCon = False
            CBxProvi.Enabled = True
            TxBCStri.Enabled = True
            ButConnO.Enabled = True
            CBxProvi.Focus()
        Else
            MessageBox.Show("No hay una conexión establecida", "Error")
        End If
    End Sub

    Private Sub ButLoadT_Click(sender As Object, e As EventArgs) Handles ButLoadT.Click
        ButCleaT_Click(sender, e)
        Select Case CBxProvi.Text
            Case "SQL Server"
                RellSQLS()

            Case "MySQL"
                RellMSQL()

            Case "SQLite"
                RellSQLi()

        End Select
    End Sub

    Sub RellSQLS()
        SQL = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"
        Try
            Dim DT As New DataTable
            DT = SQLSRell(SQL)
            CBxTabla.DataSource = DT
            CBxTabla.DisplayMember = "TABLE_NAME"
            CBxTabla.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub RellMSQL()
        SQL = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"
        Try
            Dim DT As New DataTable
            DT = MSQLRell(SQL)
            CBxTabla.DataSource = DT
            CBxTabla.DisplayMember = "TABLE_NAME"
            CBxTabla.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub RellSQLi()
        SQL = "SELECT name FROM sqlite_master WHERE type = 'table'"
        Try
            Dim DT As New DataTable
            DT = SQLiRell(SQL)
            CBxTabla.DataSource = DT
            CBxTabla.DisplayMember = "name"
            CBxTabla.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButCleaT_Click(sender As Object, e As EventArgs) Handles ButCleaT.Click
        Try
            CBxTabla.DataSource = Nothing
            CBxTabla.Items.Clear()
            CBxTabla.ResetText()
            ButCData_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButLData_Click(sender As Object, e As EventArgs) Handles ButLData.Click
        If Trim(CBxTabla.Text) <> String.Empty Then
            SQL = "SELECT * FROM " & CBxTabla.Text
            Select Case CBxProvi.Text
                Case "SQL Server"
                    SQLSCons(DGVDatos, SQL)

                Case "MySQL"
                    MSQLCons(DGVDatos, SQL)

                Case "SQLite"
                    SQLiCons(DGVDatos, SQL)

            End Select
        End If
    End Sub

    Private Sub ButCData_Click(sender As Object, e As EventArgs) Handles ButCData.Click
        DGVDatos.Columns.Clear()
    End Sub
End Class