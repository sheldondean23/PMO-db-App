Public Class frmSelectForUpdate
    Private Sub frmSelectForUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen 
        'Dim db As New HSISProjectsTestEntities
        Dim db As New HSISProjectsEntities
        Dim projects = From projectsList In db.tblProjectInformations
                       Join status In db.tblProjectStatus On projectsList.ProjectStatusID Equals status.StatusID 
                       Where not (status.StatusName = "Archived")
                       Order by projectsList.ProjectName
                       Select projectsList.ProjectName
        cmbProjects.DropDownStyle = ComboBoxStyle.DropDownList
        For Each project In projects
            cmbProjects.Items.Add(project)
        Next
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cmbProjects.SelectedIndex = -1 Then
            Return
        Else
            frmUpdate.Close()
            frmUpdate.Show()
        End If

    End Sub

    Private Sub frmSelectForUpdate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmPick.Show()
    End Sub
End Class