Module Update
    Private facilities() As String
    Private categories() As String
    Private projectSize As String
    Private projectStatus As String
    Private hsisPrimaryLead As String
    Private hsisSecondaryLead As String
    Private projectPriority As String
    Private projectRequestType As String
    Private projectName As String
    Private resources() As String
    Private departmentOFRequest As String
    Private projectSubmitter As String
    Private comments As String
    Private futureState As String
    Private statusUpdates As String
    Private requestorName As String
    Private requestorEmail As String
    Private requestorPhoneNum As String
    Private FOPALnum As String 
    Private laborHr As Nullable(Of Double)
    Private ranking As Nullable(Of Integer)
    Private desiredBudget As Nullable(Of Integer)
    Private actualBudget As Nullable(Of Integer)
    Private statusUpdateDate As Date
    Private scheduledStartDate As Nullable(Of Date)
    Private scheduledEndDate As Nullable(Of Date)
    Private actualStartDate As Nullable(Of Date)
    Private actualEndDate As Nullable(Of Date)
    Private requestedDate As Nullable(Of Date)
    Private contactedDate As Nullable(Of Date)
    Private archiveDate As Nullable(Of Date)
    'Private db As New HSISProjectsTestEntities
    Private db As New HSISProjectsEntities
    'Private updates As New HSISProjectsTestDataSetTableAdapters.QueriesTableAdapter
    Private updates As New HSISProjectsDataSetTableAdapters.QueriesTableAdapter

    Public Sub UpdateProject(ByVal s_facilities() As String, ByVal s_categories() As String, ByVal s_projectSize As String, ByVal s_projectStatus As String, ByVal s_hsisPrimaryLead As String, ByVal s_hsisSecondaryLead As String, ByVal s_projectPriority As String,
            ByVal s_projectRequestType As String, ByVal s_projectName As String, ByVal s_projectResouces() As String, ByVal s_departmentOFRequest As String, ByVal s_projectSubmitter As String, ByVal s_comments As String,
            ByVal s_futureState As String, ByVal s_statusUpdates As String, ByVal s_requestorName As String, ByVal s_requestorEmail As String, ByVal s_laborHr As String, ByVal s_ranking As String,ByVal s_FOPALnum  As String, ByVal s_desiredBudget As String,
            ByVal s_requestorPhoneNum As String, ByVal s_actualBudget As String, ByVal s_scheduledStartDate As String, ByVal s_scheduledEndDate As String, ByVal s_actualStartDate As String, ByVal s_ActualEndDate As String,
            ByVal s_requestedDate As String, ByVal s_contactedDate As String, ByVal s_archiveDate As String, ByVal s_statusUpdateDate As String)

        facilities = s_facilities
        categories = s_categories
        projectSize = s_projectSize
        projectStatus = s_projectStatus
        hsisPrimaryLead = s_hsisPrimaryLead
        hsisSecondaryLead = s_hsisSecondaryLead
        projectPriority = s_projectPriority
        projectRequestType = s_projectRequestType
        projectName = s_projectName
        resources = s_projectResouces
        departmentOFRequest = s_departmentOFRequest
        projectSubmitter = s_projectSubmitter
        comments = s_comments
        futureState = s_futureState
        statusUpdates = s_statusUpdates
        requestorName = s_requestorName
        requestorEmail = s_requestorEmail
        statusUpdateDate = s_statusUpdateDate
        FOPALnum = s_FOPALnum 
        laborHr = CheckForNull(s_laborHr, GetType(Double))
        ranking = CheckForNull(s_ranking, GetType(Integer))
        requestorPhoneNum = s_requestorPhoneNum
        desiredBudget = CheckForNull(s_desiredBudget, GetType(Integer))
        actualBudget = CheckForNull(s_actualBudget, GetType(Integer))
        scheduledStartDate = CheckForNull(s_scheduledStartDate, GetType(Date))
        scheduledEndDate = CheckForNull(s_scheduledEndDate, GetType(Date))
        actualStartDate = CheckForNull(s_actualStartDate, GetType(Date))
        actualEndDate = CheckForNull(s_ActualEndDate, GetType(Date))
        requestedDate = CheckForNull(s_requestedDate, GetType(Date))
        contactedDate = CheckForNull(s_contactedDate, GetType(Date))
        archiveDate = CheckForNull(s_archiveDate, GetType(Date))

        ProjectUpdate()

    End Sub
'Updates database
    Private Sub ProjectUpdate()
        Dim sizeID, astatusID, pLeadID, requestID, apriorityID, requesterID, projectID, sLeadID As Nullable(Of Integer)

        If projectSize = String.Empty Then
            sizeID = Nothing
        Else
            sizeID = (From id In db.tblProjectSizes
                      Where id.ProjectSizeName = projectSize
                      Select id.ProjectSizeID).Single
        End If

        If projectStatus = String.Empty Then
            astatusID = Nothing
        Else
            astatusID = (From id In db.tblProjectStatus
                         Where id.StatusName = projectStatus
                         Select id.StatusID).Single
        End If

        If projectPriority = String.Empty Then
            apriorityID = Nothing
        Else
            apriorityID = (From id In db.tblProjectPriorities
                           Where id.PriorityName = projectPriority
                           Select id.PriorityID).Single
        End If

        If projectRequestType = String.Empty Then
            requestID = Nothing
        Else
            requestID = (From id In db.tblProjectRequestTypes
                         Where id.ProjectRequestTypeName = projectRequestType
                         Select id.ProjectRequestTypeID).Single
        End If

        If hsisPrimaryLead = String.Empty Then
            pLeadID = Nothing
        Else
            pLeadID = (From id In db.tblHSISPrimaryLeads
                       Where id.PrimaryLeadName = hsisPrimaryLead
                       Select id.PrimaryLeadID).Single
        End If

        If hsisSecondaryLead = String.Empty Then
            sLeadID = Nothing
        Else
            sLeadID = (From id In db.tblHSISSecondaryLeads
                       Where id.SecondaryLeadName = hsisSecondaryLead
                       Select id.SecondaryLeadID).Single
        End If

        requesterID = frmUpdate.beforeContent.RequesterID
        projectID = frmUpdate.beforeContent.ProjectID
        updateCategories(categories, projectID)
        updateFacilities(facilities, projectID)
        updateResources(resources, projectID)
        updates.sp_Requester_Update(requestorName, requestorEmail, requestorPhoneNum, requesterID)
        updates.sp_Project_Update(projectName, pLeadID, sLeadID, requestID, sizeID, requesterID, apriorityID, astatusID, departmentOFRequest, laborHr, ranking, projectSubmitter,FOPALnum, projectID)
        updates.sp_Budget_Update(projectID, desiredBudget, actualBudget)
        updates.sp_Dates_Update(projectID, scheduledStartDate, scheduledEndDate, actualStartDate, actualEndDate, requestedDate, contactedDate, archiveDate)
        updates.sp_Purpose_Update(projectID, comments, futureState)
        If Not statusUpdates = String.Empty Then
            updates.sp_StatusUpdate_Insert(projectID, statusUpdates, statusUpdateDate)
        End If
        For Each num In frmUpdate.rows
            updates.sp_StatusUpdate_Update(frmUpdate.dgvAllUpdates.Rows(num).Cells(0).Value,frmUpdate.dgvAllUpdates.Rows(num).Cells(1).Value,frmUpdate.dgvAllUpdates.Rows(num).Cells(2).Value )
        Next

    End Sub

    Private Sub updateFacilities(ByVal selected() As String, ByVal pID As Integer)
        Dim oldFacilities = From facility In db.tblFacilities
                            Join progectFacility In db.tblProjectFacilities On facility.FacitityID Equals progectFacility.FacilityID
                            Join project In db.tblProjectInformations On progectFacility.ProjectID Equals project.ProjectID
                            Where project.ProjectName = frmUpdate.beforeContent.ProjectName
                            Select facility.FacitityName

        Dim removed = (oldFacilities.Except(selected)).ToList
        Dim added = (selected.Except(oldFacilities)).ToList

        For Each item In added
            Dim facilitiesID = (From id In db.tblFacilities
                                Where id.FacitityName = item
                                Select id.FacitityID).Single

            updates.sp_Project_Facility_Update(pID, facilitiesID)
        Next
        For Each item In removed
            Dim facilitiesID = (From id In db.tblFacilities
                                Where id.FacitityName = item
                                Select id.FacitityID).Single
            updates.sp_Project_Facility_Remove(pID, facilitiesID)
        Next
    End Sub

    Private Sub updateCategories(ByVal selected() As String, ByVal pID As Integer)
        Dim oldCatefories = (From category In db.tblCategories
                             Join systemCategory In db.tblProjectCategories On category.CategoryID Equals systemCategory.CategoryID
                             Join project In db.tblProjectInformations On systemCategory.ProjectID Equals project.ProjectID
                             Where project.ProjectName = frmUpdate.beforeContent.ProjectName
                             Select category.CategoryName).ToList

        Dim removed = (oldCatefories.Except(selected)).ToList
        Dim added = (selected.Except(oldCatefories)).ToList

        For Each item In added
            Dim categoriesID = (From id In db.tblCategories
                                Where id.CategoryName = item
                                Select id.CategoryID).Single

            updates.sp_Project_Category_Update(pID, categoriesID)
        Next
        For Each item In removed
            Dim categoriesID = (From id In db.tblCategories
                                Where id.CategoryName = item
                                Select id.CategoryID).Single
            updates.sp_Project_Category_Remove(pID, categoriesID)
        Next
    End Sub
    
    Private Sub updateResources(ByVal selected() As String, ByVal pID As Integer)
        Dim oldResouces = (From r In db.tblResources 
                             Join bridge In db.tblProjectResources On r.ResourceID Equals bridge.ResourceID
                             Join project In db.tblProjectInformations On bridge.ProjectID Equals project.ProjectID
                             Where project.ProjectName = frmUpdate.beforeContent.ProjectName
                             Select r.ResourceName).ToList

        Dim removed = (oldResouces.Except(selected)).ToList
        Dim added = (selected.Except(oldResouces)).ToList

        For Each item In added
            Dim resourcesID = (From id In db.tblResources
                                Where id.ResourceName = item
                                Select id.ResourceID).Single

            updates.sp_Project_Resource_Update(pID, resourcesID)
        Next
        For Each item In removed
            Dim resourcesID = (From id In db.tblResources 
                                Where id.ResourceName = item
                                Select id.ResourceID).Single
            updates.sp_Project_Resource_Remove(pID, resourcesID)
        Next
    End Sub

End Module
