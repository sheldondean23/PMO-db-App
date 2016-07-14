Public Class frmPick
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmSelect.Show()
        Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAdd.Show()
        Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        frmSelectForUpdate.Show()
        Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        MsgBox("WARNIG!!! Recovering a deleted project will prove to be hard!")
        frmDelete.Show()
        Hide()
    End Sub

    Private Sub frmPick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.AutoScroll= True 
        Me.CenterToScreen
    End Sub
End Class