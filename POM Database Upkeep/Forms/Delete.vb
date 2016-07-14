Public Class frmDelete
    Dim resuls As dbConnection = New dbConnection()
    Private Sub frmDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDelete.MaximumSize = New Size(1700, 1400)
        dgvDelete.BackgroundColor = Color.White
        dgvDelete.AutoResizeColumns()
        dgvDelete.DataSource = resuls.newQuery("SELECT tblProjectInformation.ProjectName,tblProjectRequester.ProjectRequesterEmail,tblProjectRequester.ProjectRequesterName,tblProjectRequester.ProjectRequesterPhone,tblProjectInformation.DepartmentOfRequest,tblProjectInformation.ProjectSubmitter,
		tblProjectInformation.ProjectRankingScore,tblProjectInformation.ProjectLaborHours,tblProjectPurpose.Comments,tblProjectPurpose.FutureState,tblProjectBudget.ProjectActualBudget,tblProjectBudget.ProjectDesiredBudget,
		tblProjectRequestType.ProjectRequestTypeName,tblHSISPrimaryLead.PrimaryLeadName,tblHSISSecondaryLead.SecondaryLeadName,tblProjectSize.ProjectSizeName,tblProjectPriority.PriorityName,tblProjectStatus.StatusName,tblProjectDates.ActualEndDate,tblProjectDates.ActualStartDate,
		tblProjectDates.ArchiveDate,tblProjectDates.ContactedDate,tblProjectDates.ScheduledEndDate,tblProjectDates.ScheduledStartDate,tblProjectDates.RequestedDate 
FROM tblProjectInformation
LEFT JOIN tblProjectRequester ON tblProjectRequester.ProjectRequesterID = tblProjectInformation.ProjectRequesterID 
LEFT JOIN tblProjectPurpose ON tblProjectPurpose.ProjectID = tblProjectInformation.ProjectID 
LEFT JOIN tblProjectBudget ON tblProjectBudget.ProjectID = tblProjectInformation.ProjectID 
LEFT JOIN tblProjectDates ON tblProjectDates.ProjectID = tblProjectInformation.ProjectID 
LEFT JOIN tblProjectRequestType ON tblProjectRequestType.ProjectRequestTypeID = tblProjectInformation.ProjectRequestTypeID 
LEFT JOIN tblHSISPrimaryLead ON tblHSISPrimaryLead.PrimaryLeadID = tblProjectInformation.HSISPrimaryLeadID  
LEFT JOIN tblHSISSecondaryLead ON tblHSISSecondaryLead.SecondaryLeadID = tblProjectInformation.HSISSecondaryLeadID 
LEFT JOIN tblProjectSize ON tblProjectSize.ProjectSizeID = tblProjectInformation.ProjectSizeID 
LEFT JOIN tblProjectPriority ON tblProjectPriority.PriorityID = tblProjectInformation.ProjectPriorityID 
LEFT JOIN tblProjectStatus ON tblProjectStatus.StatusID = tblProjectInformation.ProjectStatusID", "ProjectInformation")
        dgvDelete.ClientSize = New Size(dgvDelete.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 43, 500)
        Me.Width = dgvDelete.Width + 50
        Me.CenterToScreen 
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case MessageBox.Show("Are you sure that you want to delete this?", "Warning", MessageBoxButtons.YesNo)
            Case DialogResult.Yes
                If dgvDelete.SelectedRows.Count = 0 Then
                    MsgBox("No row selected!")
                    Return
                Else
                    'Dim delete As New HSISProjectsDataSetTableAdapters.QueriesTableAdapter
                    Dim delete As New HSISProjectsDataSetTableAdapters.QueriesTableAdapter

                    Try
                        delete.sp_Project_Delete(dgvDelete.SelectedRows(0).Cells(0).Value.ToString)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    dgvDelete.AutoResizeColumns()
                    dgvDelete.DataSource = resuls.newQuery("SELECT tblProjectInformation.ProjectName,tblProjectRequester.ProjectRequesterEmail,tblProjectRequester.ProjectRequesterName,tblProjectRequester.ProjectRequesterPhone,tblProjectInformation.DepartmentOfRequest,tblProjectInformation.ProjectSubmitter,
		tblProjectInformation.ProjectRankingScore,tblProjectInformation.ProjectLaborHours,tblProjectPurpose.Comments,tblProjectPurpose.FutureState,tblProjectBudget.ProjectActualBudget,tblProjectBudget.ProjectDesiredBudget,
		tblProjectRequestType.ProjectRequestTypeName,tblHSISPrimaryLead.PrimaryLeadName,tblHSISSecondaryLead.SecondaryLeadName,tblProjectSize.ProjectSizeName,tblProjectPriority.PriorityName,tblProjectStatus.StatusName,tblProjectDates.ActualEndDate,tblProjectDates.ActualStartDate,
		tblProjectDates.ArchiveDate,tblProjectDates.ContactedDate,tblProjectDates.ScheduledEndDate,tblProjectDates.ScheduledStartDate,tblProjectDates.RequestedDate 
FROM tblProjectInformation
LEFT JOIN tblProjectRequester ON tblProjectRequester.ProjectRequesterID = tblProjectInformation.ProjectRequesterID 
LEFT JOIN tblProjectPurpose ON tblProjectPurpose.ProjectID = tblProjectInformation.ProjectID 
LEFT JOIN tblProjectBudget ON tblProjectBudget.ProjectID = tblProjectInformation.ProjectID 
LEFT JOIN tblProjectDates ON tblProjectDates.ProjectID = tblProjectInformation.ProjectID 
LEFT JOIN tblProjectRequestType ON tblProjectRequestType.ProjectRequestTypeID = tblProjectInformation.ProjectRequestTypeID 
LEFT JOIN tblHSISPrimaryLead ON tblHSISPrimaryLead.PrimaryLeadID = tblProjectInformation.HSISPrimaryLeadID  
LEFT JOIN tblHSISSecondaryLead ON tblHSISSecondaryLead.SecondaryLeadID = tblProjectInformation.HSISSecondaryLeadID 
LEFT JOIN tblProjectSize ON tblProjectSize.ProjectSizeID = tblProjectInformation.ProjectSizeID 
LEFT JOIN tblProjectPriority ON tblProjectPriority.PriorityID = tblProjectInformation.ProjectPriorityID 
LEFT JOIN tblProjectStatus ON tblProjectStatus.StatusID = tblProjectInformation.ProjectStatusID", "ProjectInformation")
                End If
            Case DialogResult.No
                Return
        End Select
    End Sub

    Private Sub frmDelete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmPick.Show()
    End Sub
End Class