Public Class frmOutPut
    Private Sub frmOutPut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOutPut.BackgroundColor = Color.White
        Dim resuls As dbConnection = New dbConnection()
        Try
        dgvOutPut.DataSource = resuls.newQuery(frmSelect.querys(frmSelect.lstQuery.SelectedIndex).FullQuery, frmSelect.querys(frmSelect.lstQuery.SelectedIndex).tableName)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvOutPut.AutoResizeColumns()
        dgvOutPut.ClientSize = New Size(dgvOutPut.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 45, 1400)
        Me.MaximumSize = New Size (1700,1400)
        Me.Width = dgvOutPut.Width + 40
         Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.AutoScroll= True 
        Me.CenterToScreen 
    End Sub
End Class
