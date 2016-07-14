Public Class frmAdd
    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen 
        UnBold()
        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.AutoScroll= True 

        chkRequestedDate.Checked = True
        dtpRequestedDate.Value = Date.Now
        dtpScheduledStartDate.Visible = False
        dtpScheduledStartDate.Value = Date.Now
        dtpScheduledEndDate.Visible = False
        dtpScheduledEndDate.Value = Date.Now
        dtpActualStartDate.Visible = False
        dtpActualStartDate.Value = Date.Now
        dtpActualEndDate.Visible = False
        dtpActualEndDate.Value = Date.Now
        dtpContactedDate.Visible = False
        dtpContactedDate.Value = Date.Now
        dtpArchiveDate.Visible = False
        dtpArchiveDate.Value = Date.Now
        
        lblCharCountStatusUpdates.ForeColor = Color.Green
        lblCharCountStatusUpdates.Text = "500"

        cmbPrimaryLead.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSecondaryLead.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProjectPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProjectRequestType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProjectSize.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProjectStatus.DropDownStyle = ComboBoxStyle.DropDownList

        'Dim db As New HSISProjectsTestEntities
        Dim db As New HSISProjectsEntities

        Dim rows = From ResourceNames In db.tblResources 
                   Order by ResourceNames.ResourceName 
                   Select ResourceNames.ResourceName

        For Each row In rows
            clstResources.Items.Add(row)
        Next

        rows = From facililtiesNames In db.tblFacilities
                   Order by facililtiesNames.FacitityName
                   Select facililtiesNames.FacitityName

        For Each row In rows
            clstFacilityID.Items.Add(row)
        Next

        rows = From categoyNames In db.tblCategories
               Order by categoyNames.CategoryName 
               Select categoyNames.CategoryName

        For Each row In rows
            clstCategoryID.Items.Add(row)
        Next

        rows = From sizeNames In db.tblProjectSizes
               Order by sizeNames.ProjectSizeName  
               Select sizeNames.ProjectSizeName

        For Each row In rows
            cmbProjectSize.Items.Add(row)
        Next

        rows = From statusNames In db.tblProjectStatus
               Order by statusNames.StatusName 
               Select statusNames.StatusName

        For Each row In rows
            cmbProjectStatus.Items.Add(row)
        Next

        rows = From primaryLeadsNames In db.tblHSISPrimaryLeads
               Order by primaryLeadsNames.PrimaryLeadName 
               Select primaryLeadsNames.PrimaryLeadName

        For Each row In rows
            cmbPrimaryLead.Items.Add(row)
        Next

        rows = From secondaryLeadsNames In db.tblHSISSecondaryLeads
               Order by secondaryLeadsNames.SecondaryLeadName 
               Select secondaryLeadsNames.SecondaryLeadName

        For Each row In rows
            cmbSecondaryLead.Items.Add(row)
        Next

        rows = From requesttypeNames In db.tblProjectRequestTypes
               Order by requesttypeNames.ProjectRequestTypeName 
               Select requesttypeNames.ProjectRequestTypeName

        For Each row In rows
            cmbProjectRequestType.Items.Add(row)
        Next

        rows = From priorityNames In db.tblProjectPriorities
               Order by priorityNames.PriorityName 
               Select priorityNames.PriorityName

        For Each row In rows
            cmbProjectPriority.Items.Add(row)
        Next
    End Sub

    Private Sub chkScheduledStartDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkScheduledStartDate.CheckedChanged
        If chkScheduledStartDate.Checked = True Then
            dtpScheduledStartDate.Visible = True
        Else
            dtpScheduledStartDate.Visible = False
        End If
    End Sub

    Private Sub chkScheduledEndDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkScheduledEndDate.CheckedChanged
        If chkScheduledEndDate.Checked = True Then
            dtpScheduledEndDate.Visible = True
        Else
            dtpScheduledEndDate.Visible = False
        End If
    End Sub

    Private Sub chkActualStartDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkActualStartDate.CheckedChanged
        If chkActualStartDate.Checked = True Then
            dtpActualStartDate.Visible = True
        Else
            dtpActualStartDate.Visible = False
        End If
    End Sub

    Private Sub chkActualEndDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkActualEndDate.CheckedChanged
        If chkActualEndDate.Checked = True Then
            dtpActualEndDate.Visible = True
        Else
            dtpActualEndDate.Visible = False
        End If
    End Sub

    Private Sub chkRequestedDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkRequestedDate.CheckedChanged
        If chkRequestedDate.Checked = True Then
            dtpRequestedDate.Visible = True
        Else
            dtpRequestedDate.Visible = False
        End If
    End Sub

    Private Sub chkContactedDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkContactedDate.CheckedChanged
        If chkContactedDate.Checked = True Then
            dtpContactedDate.Visible = True
        Else
            dtpContactedDate.Visible = False
        End If
    End Sub

    Private Sub chkArchiveDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkArchiveDate.CheckedChanged
        If chkArchiveDate.Checked = True Then
            dtpArchiveDate.Visible = True
        Else
            dtpArchiveDate.Visible = False
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim ScheduledStartDate As String = dtpScheduledStartDate.Value
        Dim ScheduledEndDate As String = dtpScheduledEndDate.Value
        Dim ActualStartDate As String = dtpActualStartDate.Value
        Dim ActualEndDate As String = dtpActualEndDate.Value
        Dim ContactedDate As String = dtpContactedDate.Value
        Dim ArchiveDate As String = dtpArchiveDate.Value
        Dim LaborHours As String = mtxtLaborHours.Text
        Dim desiredBudget As String = mtxtDesiredBudget.Text
        Dim actualBudget As String = mtxtActualBudget.Text

        If IsNothing(clstCategoryID.CheckedItems) Then
            MsgBox("You must select a Categoty!")
            Return
        ElseIf IsNothing(clstFacilityID.CheckedItems) Then
            MsgBox("You must select a Facility!")
            Return
        ElseIf cmbProjectStatus.SelectedIndex = -1 Then
            MsgBox("You must select a Project Status!")
            Return
        ElseIf cmbPrimaryLead.SelectedIndex = -1 Then
            MsgBox("You must select a Primary Lead!")
            Return
        ElseIf cmbProjectRequestType.SelectedIndex = -1 Then
            MsgBox("You must select a Request Type!")
            Return
        ElseIf txtProjectName.Text = String.Empty Then
            MsgBox("You must enter a Project Name!")
            Return
        ElseIf txtDepartmentRequest.Text = String.Empty Then
            MsgBox("You must enter a Department of Request!")
            Return
        ElseIf mtxtProjectRanking.Text = String.Empty Then
            MsgBox("You must enter a Project Ranking!")
            Return
        ElseIf txtProjectSubmitter.Text = String.Empty Then
            MsgBox("You must enter a Project Submitter!")
            Return
        ElseIf rtxtCurrentState.Text = String.Empty Then
            MsgBox("You must enter Project Comments!")
            Return
        ElseIf rtxtProjectPurposeFutureState.Text = String.Empty Then
            MsgBox("You must enter Project Future State!")
            Return
        ElseIf txtRequestorName.Text = String.Empty Then
            MsgBox("You must enter the Project Requester's Name!")
            Return
        ElseIf txtprojectRequestorEmail.Text = String.Empty Then
            MsgBox("You must enter the Project Requester's Email address!")
            Return
        ElseIf mtxtProjectRequestorPhone.Text = String.Empty Then
            MsgBox("You must enter the Project Requester's Phone Number!")
            Return
        ElseIf chkRequestedDate.Checked = False Then
            MsgBox("You must enter select a Request Date!")
            Return
        End If

        If chkScheduledStartDate.Checked = False Then
            ScheduledStartDate = String.Empty
        End If
        If chkScheduledEndDate.Checked = False Then
            ScheduledEndDate = String.Empty
        End If
        If chkActualStartDate.Checked = False Then
            ActualStartDate = String.Empty
        End If
        If chkActualEndDate.Checked = False Then
            ActualEndDate = String.Empty
        End If
        If chkContactedDate.Checked = False Then
            ContactedDate = String.Empty
        End If
        If chkArchiveDate.Checked = False Then
            ArchiveDate = String.Empty
        End If
        If mtxtLaborHours.Text = "     ." Then
            LaborHours = String.Empty
        End If
        If desiredBudget = "$" Then
            desiredBudget = String.Empty
        Else
            desiredBudget = desiredBudget.Substring(desiredBudget.IndexOf("$") + 1, desiredBudget.Count - 1)
        End If
        If actualBudget = "$" Then
            actualBudget = String.Empty
        Else
            actualBudget = actualBudget.Substring(actualBudget.IndexOf("$") + 1, actualBudget.Count - 1)
        End If

        Dim facilities(clstFacilityID.CheckedItems.Count - 1), categories(clstCategoryID.CheckedItems.Count - 1), resources(clstResources.CheckedItems.Count - 1) As String
        clstFacilityID.CheckedItems.CopyTo(facilities, 0)
        clstCategoryID.CheckedItems.CopyTo(categories, 0)
        clstResources.CheckedItems.CopyTo(resources, 0)
        Try
            AddProject(facilities, categories, cmbProjectSize.SelectedItem, cmbProjectStatus.SelectedItem, cmbPrimaryLead.SelectedItem, cmbSecondaryLead.SelectedItem, cmbProjectPriority.SelectedItem, cmbProjectRequestType.SelectedItem,
                                      txtProjectName.Text, resources, txtDepartmentRequest.Text, txtProjectSubmitter.Text, rtxtCurrentState.Text, rtxtProjectPurposeFutureState.Text, rtxtStatusUpdate.Text,
                                      txtRequestorName.Text, txtprojectRequestorEmail.Text, LaborHours, mtxtProjectRanking.Text, desiredBudget, mtxtProjectRequestorPhone.Text, actualBudget,txtFOPALnum.Text,
                                      dtpStatusUpdate.Text, ScheduledStartDate, ScheduledEndDate, ActualStartDate, ActualEndDate, dtpRequestedDate.Text, ContactedDate, ArchiveDate)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        MsgBox("Project Added!")
        Close()
    End Sub

    Public Sub UnBold()
        clstFacilityID.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        clstCategoryID.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        cmbProjectSize.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        cmbProjectStatus.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        cmbPrimaryLead.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        cmbProjectPriority.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        cmbProjectRequestType.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        cmbSecondaryLead.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        txtProjectName.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        clstResources.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        txtDepartmentRequest.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        txtProjectSubmitter.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        txtFOPALnum.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        rtxtCurrentState.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        rtxtProjectPurposeFutureState.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        rtxtStatusUpdate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        txtRequestorName.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        txtprojectRequestorEmail.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        mtxtLaborHours.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        mtxtProjectRanking.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        mtxtDesiredBudget.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        mtxtProjectRequestorPhone.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        mtxtActualBudget.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        dtpScheduledStartDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        dtpScheduledEndDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        dtpActualStartDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        dtpActualEndDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        dtpRequestedDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        dtpContactedDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        dtpActualEndDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        dtpArchiveDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        dtpStatusUpdate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)

        lblFacility.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblCategory.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblProjectSize.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblProjectStatus.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblPrimaryLead.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblSecondaryLead.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblProjectPriority.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblProjectRequestType.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblProjectName.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblResources.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblDepartmentRequest.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblSubmitter.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblCurrentState.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblFutureState.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblProjectRequestorName.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblProjectRequestorEmail.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblLaborHours.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblRankingScore.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblDesiredBudget.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblProjectRequestorPhone.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblActualBudget.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblScheduledStartDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblScheduledEndDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblActualStartDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblActualEndDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblRequestedDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblContactedDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblActualEndDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblArchiveDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblCharCountStatusUpdates.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblCharCountComments.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblCharCountFutureState.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblUpdateDate.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
        lblFOPALnum.Font = New Font(clstFacilityID.Font, FontStyle.Regular)
    End Sub

    Private Sub frmAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmPick.Show()
    End Sub

    Private Sub rtxtStatusUpdate_TextChanged(sender As Object, e As EventArgs) Handles rtxtStatusUpdate.TextChanged
        lblCharCountStatusUpdates.Text = 500 - rtxtStatusUpdate.Text.Count

        If lblCharCountStatusUpdates.Text < 0 Then
            lblCharCountStatusUpdates.ForeColor = Color.Red 
        Else
            lblCharCountStatusUpdates.ForeColor = Color.Green  
        End If
    End Sub
    
    Private Sub rtxtProjectPurposeComments_TextChanged(sender As Object, e As EventArgs) Handles rtxtCurrentState.TextChanged
        'Subtracts the current character count from 500
        lblCharCountComments.Text = 500 - rtxtCurrentState.Text.Count

        If lblCharCountComments.Text < 0 Then
            lblCharCountComments.ForeColor = Color.Red 
        Else
            lblCharCountComments.ForeColor = Color.Green
        End If
    End Sub

    Private Sub rtxtProjectPurposeFutureState_TextChanged(sender As Object, e As EventArgs) Handles rtxtProjectPurposeFutureState.TextChanged
        'Subtracts the current character count from 500
        lblCharCountFutureState.Text = 500 - rtxtProjectPurposeFutureState.Text.Count

        If lblCharCountFutureState.Text < 0 Then
            lblCharCountFutureState.ForeColor = Color.Red 
        Else
            lblCharCountFutureState.ForeColor = Color.Green
        End If
    End Sub    
End Class