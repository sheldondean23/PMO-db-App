Public Class frmGroupByPopup
    Private Sub GroupByPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen 
        Dim list(frmSelect.columNames.Count) As String

        'Fills the combobox with data from the checked list box
        For i As Integer = 0 To frmSelect.columNames.Count - 1
            If Not frmSelect.columNames(i).IndexOf("(") = -1 Then
                list(i) = Query.RemoveAgg(,, frmSelect.columNames(i))
            Else
                list(i) = frmSelect.columNames(i)
            End If
        Next

        cmbGroupByOptions.DataSource = list
        cmbGroupByOptions.SelectedIndex = -1

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        'Checks to see if a selection was made
        If cmbGroupByOptions.SelectedIndex = -1 Then
            MsgBox("You must select a category to group by!")
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub GroupByPopup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If cmbGroupByOptions.SelectedIndex = -1 Then
            MsgBox("To add query you must select how to group when every column is not set with and aggregate function.")
        End If
    End Sub
End Class