Class ProjectFullView
    'Private db As HSISProjectsTestEntities = New HSISProjectsTestEntities
    Private db As HSISProjectsEntities = New HSISProjectsEntities

    Public Sub FillFromDB(ByRef clstFacilityID As CheckedListBox, ByRef clstCategoryID As CheckedListBox, ByRef cmbProjectSize As Object, ByRef cmbProjectStatus As Object, ByRef cmbSecondaryLead As Object,
                          ByRef cmbPrimaryLead As Object, ByRef cmbProjectPriority As Object, ByRef cmbProjectRequestType As Object, ByRef txtProjectName As String, ByRef clstResources As CheckedListBox,
                          ByRef txtDepartmentRequest As String, ByRef txtProjectSubmitter As String, ByRef rtxtProjectPurposeComments As String, ByRef rtxtProjectPurposeFutureState As String,
                          ByRef rtxtStatusUpdate As String, ByRef txtRequestorName As String, ByRef txtprojectRequestorEmail As String, ByRef mtxtLaborHours As String, ByRef mtxtProjectRanking As String, ByRef txtFOPALnum As String,
                          ByRef mtxtDesiredBudget As String, ByRef mtxtProjectRequestorPhone As String, ByRef mtxtActualBudget As String, ByRef dtpScheduledStartDate As Date, ByRef dtpScheduledEndDate As Date,
                          ByRef dtpActualStartDate As Date, ByRef dtpActualEndDate As Date, ByRef dtpRequestedDate As Date, ByRef dtpContactedDate As Date, ByRef dtpArchiveDate As Date, ByVal theProjectName As String)
'Queries database for all fields of a project by name
        Dim project As Object = (From aproject In db.tblProjectInformations
                                 Where aproject.ProjectName = theProjectName
                                 Group Join r In db.tblProjectRequesters On r.ProjectRequesterID Equals aproject.ProjectRequesterID Into rp = Group From requester In rp.DefaultIfEmpty
                                 Group Join p In db.tblProjectPurposes On p.ProjectID Equals aproject.ProjectID Into purp = Group From purpose In purp.DefaultIfEmpty
                                 Group Join b In db.tblProjectBudgets On b.ProjectID Equals aproject.ProjectID Into bud = Group From budget In bud.DefaultIfEmpty
                                 Group Join d In db.tblProjectDates On d.ProjectID Equals aproject.ProjectID Into adate = Group From dates In adate.DefaultIfEmpty
                                 Group Join rt In db.tblProjectRequestTypes On rt.ProjectRequestTypeID Equals aproject.ProjectRequestTypeID Into re = Group From request In re.DefaultIfEmpty
                                 Group Join pr In db.tblHSISPrimaryLeads On pr.PrimaryLeadID Equals aproject.HSISPrimaryLeadID Into prime = Group From primary In prime.DefaultIfEmpty
                                 Group Join sec In db.tblHSISSecondaryLeads On sec.SecondaryLeadID Equals aproject.HSISSecondaryLeadID Into second = Group From secondary In second.DefaultIfEmpty
                                 Group Join s In db.tblProjectSizes On s.ProjectSizeID Equals aproject.ProjectSizeID Into sizes = Group From Size In sizes.DefaultIfEmpty
                                 Group Join pri In db.tblProjectPriorities On pri.PriorityID Equals aproject.ProjectPriorityID Into priorities = Group From proporty In priorities.DefaultIfEmpty
                                 Group Join stat In db.tblProjectStatus On stat.StatusID Equals aproject.ProjectStatusID Into statuses = Group From status In statuses.DefaultIfEmpty
                                 Select requester.ProjectRequesterEmail, requester.ProjectRequesterName, requester.ProjectRequesterPhone, aproject.ProjectName, aproject.DepartmentOfRequest, aproject.ProjectSubmitter, aproject.ProjectFOPALnumber,
        aproject.ProjectRankingScore, aproject.ProjectLaborHours, purpose.Comments, purpose.FutureState, budget.ProjectActualBudget, budget.ProjectDesiredBudget, request.ProjectRequestTypeName, primary.PrimaryLeadName, secondary.SecondaryLeadName,
        Size.ProjectSizeName, proporty.PriorityName, status.StatusName, dates.ActualEndDate, dates.ActualStartDate, dates.ArchiveDate, dates.ContactedDate, dates.ScheduledEndDate, dates.ScheduledStartDate, dates.RequestedDate).ToList
'Using by reference updates the form fields with data from database
        txtprojectRequestorEmail = project(0).ProjectRequesterEmail.Trim()
        txtRequestorName = project(0).ProjectRequesterName.Trim()
        mtxtProjectRequestorPhone = project(0).ProjectRequesterPhone.Trim()
        txtProjectName = project(0).ProjectName.Trim()
        txtDepartmentRequest = project(0).DepartmentOfRequest.Trim()
        txtProjectSubmitter = project(0).ProjectSubmitter.Trim()
        mtxtProjectRanking = project(0).ProjectRankingScore
        rtxtProjectPurposeComments = Trim(project(0).Comments)
        rtxtProjectPurposeFutureState = Trim(project(0).FutureState)
        mtxtActualBudget = project(0).ProjectActualBudget
        mtxtDesiredBudget = project(0).ProjectDesiredBudget
        txtFOPALnum = Trim(project(0).ProjectFOPALnumber)
        mtxtLaborHours = project(0).ProjectLaborHours
        cmbProjectRequestType = project(0).ProjectRequestTypeName
        cmbPrimaryLead = project(0).PrimaryLeadName
        cmbSecondaryLead = project(0).SecondaryLeadName
        cmbProjectSize = project(0).ProjectSizeName
        cmbProjectPriority = project(0).PriorityName
        cmbProjectStatus = project(0).StatusName
        dtpActualEndDate = minDate(project(0).ActualEndDate)
        dtpActualStartDate = minDate(project(0).ActualStartDate)
        dtpArchiveDate = minDate(project(0).ArchiveDate)
        dtpContactedDate = minDate(project(0).ContactedDate)
        dtpScheduledEndDate = minDate(project(0).ScheduledEndDate)
        dtpScheduledStartDate = minDate(project(0).ScheduledStartDate)
        dtpRequestedDate = minDate(project(0).RequestedDate)
        clstCategoryID = getCat(clstCategoryID, theProjectName)
        clstFacilityID = getFacility(clstFacilityID, theProjectName)
        clstResources = getResources(clstResources, theProjectName)
    End Sub
'If date field in database is null, replaces it with current date
    Private Function minDate(ByVal aDate As Date) As Date
        If aDate = Nothing Then
            Return frmUpdate.now
        Else
            Return aDate
        End If
    End Function
'Finds all categories for a project based on a project name
    Private Function getCat(ByVal cat As CheckedListBox, ByVal name As String) As ListBox
        Dim selectedCats = From cats In db.tblCategories
                           Join bridge In db.tblProjectCategories On bridge.CategoryID Equals cats.CategoryID
                           Join project In db.tblProjectInformations On project.ProjectID Equals bridge.ProjectID
                           Where project.ProjectName = name
                           Select cats.CategoryName

        For Each category In selectedCats
            cat.SetItemChecked(cat.FindString(category), True)
        Next

        Return cat
    End Function
'Finds all facilities for a project based on a project name
    Private Function getFacility(ByVal facility As CheckedListBox, ByVal name As String) As ListBox
        Dim selected = From qfacility In db.tblFacilities
                       Join bridge In db.tblProjectFacilities On bridge.FacilityID Equals qfacility.FacitityID
                       Join project In db.tblProjectInformations On project.ProjectID Equals bridge.ProjectID
                       Where project.ProjectName = name
                       Select qfacility.FacitityName

        For Each facil In selected
            facility.SetItemChecked(facility.FindString(facil), True)
        Next

        Return facility
    End Function
    'Finds all Resources for a project based on a project name
    Private Function getResources(ByVal resource As CheckedListBox, ByVal name As String) As ListBox
        Dim selected = From r In db.tblResources 
                       Join bridge In db.tblProjectResources On bridge.ResourceID Equals r.ResourceID 
                       Join project In db.tblProjectInformations On project.ProjectID Equals bridge.ProjectID
                       Where project.ProjectName = name
                       Select r.ResourceName 

        For Each source In selected
            resource.SetItemChecked(resource.FindString(source), True)
        Next

        Return resource
    End Function
End Class
