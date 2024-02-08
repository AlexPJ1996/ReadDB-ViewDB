Imports Microsoft.Office.Interop.Excel
Imports System.IO

Module MExportE

    Sub Export(ByVal DGV As DataGridView)
        Dim ExcelApp As New Application With {.Visible = True}
        Dim WorkBook As Workbook = ExcelApp.Workbooks.Add()
        Dim WorkSheet As Worksheet = CType(WorkBook.Sheets(1), Worksheet)
        Dim ColumnCount As Integer = DGV.Columns.Count
        For i As Integer = 0 To ColumnCount - 1
            WorkSheet.Cells(1, i + 1) = DGV.Columns(i).HeaderText
        Next
        Dim RowCount As Integer = DGV.Rows.Count
        For i As Integer = 0 To RowCount - 1
            For j As Integer = 0 To ColumnCount - 1
                WorkSheet.Cells(i + 2, j + 1) = DGV.Rows(i).Cells(j).Value
            Next
        Next
        Dim TempFile As String = Path.GetTempFileName() & ".xls"
        WorkBook.SaveAs(TempFile)
        Process.Start(TempFile)
    End Sub
End Module