Public Module Insert
    Private facilities() As String
    Private categories() As String
    Private projectSize As String
    Private projectStatus As String
    Private hsisPrimaryLead As String
    Private hsisSecondaryLead As String
    Private projectPriority As String
    Private projectRequestType As String
    Private projectName As String
    Private resouces() As String
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

    Public Sub AddProject(ByVal s_facilities() As String, ByVal s_categories() As String, ByVal s_projectSize As String, ByVal s_projectStatus As String, ByVal s_hsisPrimaryLead As String, ByVal s_hsisSecondaryLead As String, ByVal s_projectPriority As String,
            ByVal s_projectRequestType As String, ByVal s_projectName As String, ByVal s_projectResouces() As String, ByVal s_departmentOFRequest As String, ByVal s_projectSubmitter As String, ByVal s_comments As String,
            ByVal s_futureState As String, ByVal s_statusUpdates As String, ByVal s_requestorName As String, ByVal s_requestorEmail As String, ByVal s_laborHr As String, ByVal s_ranking As String, ByVal s_desiredBudget As String,
            ByVal s_requestorPhoneNum As String, ByVal s_actualBudget As String,ByVal s_FOPALnum As String, ByVal s_statusUpdateDate As String, ByVal s_scheduledStartDate As String, ByVal s_scheduledEndDate As String, ByVal s_actualStartDate As String, ByVal s_ActualEndDate As String,
            ByVal s_requestedDate As String, ByVal s_contactedDate As String, ByVal s_archiveDate As String)

        facilities = s_facilities
        categories = s_categories
        projectSize = s_projectSize
        projectStatus = s_projectStatus
        hsisPrimaryLead = s_hsisPrimaryLead
        hsisSecondaryLead = s_hsisSecondaryLead
        projectPriority = s_projectPriority
        projectRequestType = s_projectRequestType
        projectName = s_projectName
        resouces = s_projectResouces
        departmentOFRequest = s_departmentOFRequest
        projectSubmitter = s_projectSubmitter
        comments = s_comments
        futureState = s_futureState
        statusUpdates = s_statusUpdates
        requestorName = s_requestorName
        requestorEmail = s_requestorEmail
        FOPALnum = s_FOPALnum
        laborHr = CheckForNull(s_laborHr, GetType(Double))
        ranking = CheckForNull(s_ranking, GetType(Integer))
        requestorPhoneNum = s_requestorPhoneNum
        desiredBudget = CheckForNull(s_desiredBudget, GetType(Integer))
        actualBudget = CheckForNull(s_actualBudget, GetType(Integer))
        statusUpdateDate = s_statusUpdateDate
        scheduledStartDate = CheckForNull(s_scheduledStartDate, GetType(Date))
        scheduledEndDate = CheckForNull(s_scheduledEndDate, GetType(Date))
        actualStartDate = CheckForNull(s_actualStartDate, GetType(Date))
        actualEndDate = CheckForNull(s_ActualEndDate, GetType(Date))
        requestedDate = CheckForNull(s_requestedDate, GetType(Date))
        contactedDate = CheckForNull(s_contactedDate, GetType(Date))
        archiveDate = CheckForNull(s_archiveDate, GetType(Date))

        AddProject()

    End Sub
'Inserts project
    Private Sub AddProject()
        Dim sizeID, astatusID, pLeadID, requestID, apriorityID, requesterID, projectID, sLeadID As Nullable(Of Integer)
        Dim catIDs(), facilIDs(), resouseIDs() As Integer
        Dim add As New HSISProjectsDataSetTableAdapters.QueriesTableAdapter

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

        catIDs = CategoryIDs(categories)
        facilIDs = FacilityIDs(facilities)
        resouseIDs = ResourceIDS(resouces)

        add.sp_Requester_Update(requestorName, requestorEmail, requestorPhoneNum, requesterID)
        add.sp_Project_Insert(projectName, pLeadID, sLeadID, requestID, sizeID, requesterID, apriorityID, astatusID, departmentOFRequest, laborHr, ranking, projectSubmitter,FOPALnum, projectID)
        add.sp_Budget_Insert(projectID, desiredBudget, actualBudget)
        add.sp_Dates_Insert(projectID, scheduledStartDate, scheduledEndDate, actualStartDate, actualEndDate, requestedDate, contactedDate, archiveDate)
        add.sp_Prupose_Insert(projectID, comments, futureState)
        If Not statusUpdates = String.Empty Then
            add.sp_StatusUpdate_Insert(projectID, statusUpdates, statusUpdateDate)
        End If
        For Each id In catIDs
            add.sp_Project_Category_Insert(projectID, id)
        Next
        For Each id In facilIDs
            add.sp_Project_Facility_Insert(projectID, id)
        Next
        For Each id In resouseIDs
            add.sp_Project_Resource_Insert(projectID, id)
        Next

    End Sub

    Private Function FacilityIDs(ByVal selected() As String) As Integer()
        Dim IDs(selected.Count - 1) As Integer
        Dim count As Integer = 0
        For Each item In selected
            IDs(count) = (From facililtieID In db.tblFacilities
                          Where facililtieID.FacitityName = item
                          Select facililtieID.FacitityID).Single
            count += 1
        Next
        Return IDs
    End Function

    Private Function CategoryIDs(ByVal selected() As String) As Integer()
        Dim IDs(selected.Count - 1) As Integer
        Dim count As Integer = 0
        For Each item In selected
            IDs(count) = (From categoryID In db.tblCategories
                          Where categoryID.CategoryName = item
                          Select categoryID.CategoryID).Single
            count += 1
        Next
        Return IDs
    End Function
    
    Private Function ResourceIDs(ByVal selected() As String) As Integer()
        Dim IDs(selected.Count - 1) As Integer
        Dim count As Integer = 0
        For Each item In selected
            IDs(count) = (From resouceID In db.tblResources
                          Where resouceID.ResourceName = item
                          Select resouceID.ResourceID).Single
            count += 1
        Next
        Return IDs
    End Function

    Public Function CheckForNull(ByVal input As Object, ByVal dataType As Type) As Object
        If input.Equals(DBNull.Value) Then
            Return Nothing
        ElseIf Not input.GetType = GetType(String) Then
            Return Nothing
        ElseIf input = String.Empty Then
            Return Nothing
        Else
            Return Convert.ChangeType(input, dataType)
        End If

    End Function


End Module
