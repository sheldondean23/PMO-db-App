﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class HSISProjectsEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=HSISProjectsEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property tblCategories() As DbSet(Of tblCategory)
    Public Overridable Property tblFacilities() As DbSet(Of tblFacility)
    Public Overridable Property tblHSISPrimaryLeads() As DbSet(Of tblHSISPrimaryLead)
    Public Overridable Property tblHSISSecondaryLeads() As DbSet(Of tblHSISSecondaryLead)
    Public Overridable Property tblProjectBudgets() As DbSet(Of tblProjectBudget)
    Public Overridable Property tblProjectCategories() As DbSet(Of tblProjectCategory)
    Public Overridable Property tblProjectDates() As DbSet(Of tblProjectDate)
    Public Overridable Property tblProjectFacilities() As DbSet(Of tblProjectFacility)
    Public Overridable Property tblProjectInformations() As DbSet(Of tblProjectInformation)
    Public Overridable Property tblProjectPriorities() As DbSet(Of tblProjectPriority)
    Public Overridable Property tblProjectPurposes() As DbSet(Of tblProjectPurpose)
    Public Overridable Property tblProjectRequesters() As DbSet(Of tblProjectRequester)
    Public Overridable Property tblProjectRequestTypes() As DbSet(Of tblProjectRequestType)
    Public Overridable Property tblProjectResources() As DbSet(Of tblProjectResource)
    Public Overridable Property tblProjectSizes() As DbSet(Of tblProjectSize)
    Public Overridable Property tblProjectStatus() As DbSet(Of tblProjectStatu)
    Public Overridable Property tblProjectStatusUpdates() As DbSet(Of tblProjectStatusUpdate)
    Public Overridable Property tblResources() As DbSet(Of tblResource)

    Public Overridable Function sp_Budget_Insert(projectID As Nullable(Of Integer), desiredBudget As Nullable(Of Integer), actualBudget As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim desiredBudgetParameter As ObjectParameter = If(desiredBudget.HasValue, New ObjectParameter("DesiredBudget", desiredBudget), New ObjectParameter("DesiredBudget", GetType(Integer)))

        Dim actualBudgetParameter As ObjectParameter = If(actualBudget.HasValue, New ObjectParameter("ActualBudget", actualBudget), New ObjectParameter("ActualBudget", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Budget_Insert", projectIDParameter, desiredBudgetParameter, actualBudgetParameter)
    End Function

    Public Overridable Function sp_Budget_Update(projectID As Nullable(Of Integer), desiredBudget As Nullable(Of Integer), actualBudget As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim desiredBudgetParameter As ObjectParameter = If(desiredBudget.HasValue, New ObjectParameter("DesiredBudget", desiredBudget), New ObjectParameter("DesiredBudget", GetType(Integer)))

        Dim actualBudgetParameter As ObjectParameter = If(actualBudget.HasValue, New ObjectParameter("ActualBudget", actualBudget), New ObjectParameter("ActualBudget", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Budget_Update", projectIDParameter, desiredBudgetParameter, actualBudgetParameter)
    End Function

    Public Overridable Function sp_Dates_Insert(projectID As Nullable(Of Integer), schedualedStartDate As Nullable(Of Date), schedualedEndDate As Nullable(Of Date), actualStartDate As Nullable(Of Date), actualEndDate As Nullable(Of Date), requestedDate As Nullable(Of Date), contactedDate As Nullable(Of Date), archiveDate As Nullable(Of Date)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim schedualedStartDateParameter As ObjectParameter = If(schedualedStartDate.HasValue, New ObjectParameter("SchedualedStartDate", schedualedStartDate), New ObjectParameter("SchedualedStartDate", GetType(Date)))

        Dim schedualedEndDateParameter As ObjectParameter = If(schedualedEndDate.HasValue, New ObjectParameter("SchedualedEndDate", schedualedEndDate), New ObjectParameter("SchedualedEndDate", GetType(Date)))

        Dim actualStartDateParameter As ObjectParameter = If(actualStartDate.HasValue, New ObjectParameter("ActualStartDate", actualStartDate), New ObjectParameter("ActualStartDate", GetType(Date)))

        Dim actualEndDateParameter As ObjectParameter = If(actualEndDate.HasValue, New ObjectParameter("ActualEndDate", actualEndDate), New ObjectParameter("ActualEndDate", GetType(Date)))

        Dim requestedDateParameter As ObjectParameter = If(requestedDate.HasValue, New ObjectParameter("RequestedDate", requestedDate), New ObjectParameter("RequestedDate", GetType(Date)))

        Dim contactedDateParameter As ObjectParameter = If(contactedDate.HasValue, New ObjectParameter("ContactedDate", contactedDate), New ObjectParameter("ContactedDate", GetType(Date)))

        Dim archiveDateParameter As ObjectParameter = If(archiveDate.HasValue, New ObjectParameter("ArchiveDate", archiveDate), New ObjectParameter("ArchiveDate", GetType(Date)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Dates_Insert", projectIDParameter, schedualedStartDateParameter, schedualedEndDateParameter, actualStartDateParameter, actualEndDateParameter, requestedDateParameter, contactedDateParameter, archiveDateParameter)
    End Function

    Public Overridable Function sp_Dates_Update(projectID As Nullable(Of Integer), scheduledStartDate As Nullable(Of Date), scheduledEndDate As Nullable(Of Date), actualStartDate As Nullable(Of Date), actualEndDate As Nullable(Of Date), requestedDate As Nullable(Of Date), contactedDate As Nullable(Of Date), archiveDate As Nullable(Of Date)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim scheduledStartDateParameter As ObjectParameter = If(scheduledStartDate.HasValue, New ObjectParameter("ScheduledStartDate", scheduledStartDate), New ObjectParameter("ScheduledStartDate", GetType(Date)))

        Dim scheduledEndDateParameter As ObjectParameter = If(scheduledEndDate.HasValue, New ObjectParameter("ScheduledEndDate", scheduledEndDate), New ObjectParameter("ScheduledEndDate", GetType(Date)))

        Dim actualStartDateParameter As ObjectParameter = If(actualStartDate.HasValue, New ObjectParameter("ActualStartDate", actualStartDate), New ObjectParameter("ActualStartDate", GetType(Date)))

        Dim actualEndDateParameter As ObjectParameter = If(actualEndDate.HasValue, New ObjectParameter("ActualEndDate", actualEndDate), New ObjectParameter("ActualEndDate", GetType(Date)))

        Dim requestedDateParameter As ObjectParameter = If(requestedDate.HasValue, New ObjectParameter("RequestedDate", requestedDate), New ObjectParameter("RequestedDate", GetType(Date)))

        Dim contactedDateParameter As ObjectParameter = If(contactedDate.HasValue, New ObjectParameter("ContactedDate", contactedDate), New ObjectParameter("ContactedDate", GetType(Date)))

        Dim archiveDateParameter As ObjectParameter = If(archiveDate.HasValue, New ObjectParameter("ArchiveDate", archiveDate), New ObjectParameter("ArchiveDate", GetType(Date)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Dates_Update", projectIDParameter, scheduledStartDateParameter, scheduledEndDateParameter, actualStartDateParameter, actualEndDateParameter, requestedDateParameter, contactedDateParameter, archiveDateParameter)
    End Function

    Public Overridable Function sp_Project_Category_Insert(projectID As Nullable(Of Integer), categoryID As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim categoryIDParameter As ObjectParameter = If(categoryID.HasValue, New ObjectParameter("CategoryID", categoryID), New ObjectParameter("CategoryID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Category_Insert", projectIDParameter, categoryIDParameter)
    End Function

    Public Overridable Function sp_Project_Category_Remove(projectID As Nullable(Of Integer), categoryID As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim categoryIDParameter As ObjectParameter = If(categoryID.HasValue, New ObjectParameter("CategoryID", categoryID), New ObjectParameter("CategoryID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Category_Remove", projectIDParameter, categoryIDParameter)
    End Function

    Public Overridable Function sp_Project_Category_Update(projectID As Nullable(Of Integer), categoryID As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim categoryIDParameter As ObjectParameter = If(categoryID.HasValue, New ObjectParameter("CategoryID", categoryID), New ObjectParameter("CategoryID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Category_Update", projectIDParameter, categoryIDParameter)
    End Function

    Public Overridable Function sp_Project_Delete(projectName As String) As Integer
        Dim projectNameParameter As ObjectParameter = If(projectName IsNot Nothing, New ObjectParameter("ProjectName", projectName), New ObjectParameter("ProjectName", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Delete", projectNameParameter)
    End Function

    Public Overridable Function sp_Project_Facility_Insert(projectID As Nullable(Of Integer), facilityID As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim facilityIDParameter As ObjectParameter = If(facilityID.HasValue, New ObjectParameter("FacilityID", facilityID), New ObjectParameter("FacilityID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Facility_Insert", projectIDParameter, facilityIDParameter)
    End Function

    Public Overridable Function sp_Project_Facility_Remove(projectID As Nullable(Of Integer), facilityID As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim facilityIDParameter As ObjectParameter = If(facilityID.HasValue, New ObjectParameter("FacilityID", facilityID), New ObjectParameter("FacilityID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Facility_Remove", projectIDParameter, facilityIDParameter)
    End Function

    Public Overridable Function sp_Project_Facility_Update(projectID As Nullable(Of Integer), facilityID As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim facilityIDParameter As ObjectParameter = If(facilityID.HasValue, New ObjectParameter("FacilityID", facilityID), New ObjectParameter("FacilityID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Facility_Update", projectIDParameter, facilityIDParameter)
    End Function

    Public Overridable Function sp_Project_Insert(name As String, primaryLeadID As Nullable(Of Integer), secondaryLeadID As Nullable(Of Integer), typeID As Nullable(Of Integer), sizeID As Nullable(Of Integer), requesterID As Nullable(Of Integer), priorityID As Nullable(Of Integer), statusID As Nullable(Of Integer), departmentOfRequest As String, laborHours As Nullable(Of Double), rankingScore As Nullable(Of Integer), submitter As String, fOPALnumber As String, projectID As ObjectParameter) As Integer
        Dim nameParameter As ObjectParameter = If(name IsNot Nothing, New ObjectParameter("Name", name), New ObjectParameter("Name", GetType(String)))

        Dim primaryLeadIDParameter As ObjectParameter = If(primaryLeadID.HasValue, New ObjectParameter("PrimaryLeadID", primaryLeadID), New ObjectParameter("PrimaryLeadID", GetType(Integer)))

        Dim secondaryLeadIDParameter As ObjectParameter = If(secondaryLeadID.HasValue, New ObjectParameter("SecondaryLeadID", secondaryLeadID), New ObjectParameter("SecondaryLeadID", GetType(Integer)))

        Dim typeIDParameter As ObjectParameter = If(typeID.HasValue, New ObjectParameter("TypeID", typeID), New ObjectParameter("TypeID", GetType(Integer)))

        Dim sizeIDParameter As ObjectParameter = If(sizeID.HasValue, New ObjectParameter("SizeID", sizeID), New ObjectParameter("SizeID", GetType(Integer)))

        Dim requesterIDParameter As ObjectParameter = If(requesterID.HasValue, New ObjectParameter("RequesterID", requesterID), New ObjectParameter("RequesterID", GetType(Integer)))

        Dim priorityIDParameter As ObjectParameter = If(priorityID.HasValue, New ObjectParameter("PriorityID", priorityID), New ObjectParameter("PriorityID", GetType(Integer)))

        Dim statusIDParameter As ObjectParameter = If(statusID.HasValue, New ObjectParameter("StatusID", statusID), New ObjectParameter("StatusID", GetType(Integer)))

        Dim departmentOfRequestParameter As ObjectParameter = If(departmentOfRequest IsNot Nothing, New ObjectParameter("DepartmentOfRequest", departmentOfRequest), New ObjectParameter("DepartmentOfRequest", GetType(String)))

        Dim laborHoursParameter As ObjectParameter = If(laborHours.HasValue, New ObjectParameter("LaborHours", laborHours), New ObjectParameter("LaborHours", GetType(Double)))

        Dim rankingScoreParameter As ObjectParameter = If(rankingScore.HasValue, New ObjectParameter("RankingScore", rankingScore), New ObjectParameter("RankingScore", GetType(Integer)))

        Dim submitterParameter As ObjectParameter = If(submitter IsNot Nothing, New ObjectParameter("Submitter", submitter), New ObjectParameter("Submitter", GetType(String)))

        Dim fOPALnumberParameter As ObjectParameter = If(fOPALnumber IsNot Nothing, New ObjectParameter("FOPALnumber", fOPALnumber), New ObjectParameter("FOPALnumber", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Insert", nameParameter, primaryLeadIDParameter, secondaryLeadIDParameter, typeIDParameter, sizeIDParameter, requesterIDParameter, priorityIDParameter, statusIDParameter, departmentOfRequestParameter, laborHoursParameter, rankingScoreParameter, submitterParameter, fOPALnumberParameter, projectID)
    End Function

    Public Overridable Function sp_Project_Resource_Insert(projectID As Nullable(Of Integer), resourceID As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim resourceIDParameter As ObjectParameter = If(resourceID.HasValue, New ObjectParameter("ResourceID", resourceID), New ObjectParameter("ResourceID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Resource_Insert", projectIDParameter, resourceIDParameter)
    End Function

    Public Overridable Function sp_Project_Resource_Remove(projectID As Nullable(Of Integer), resourceID As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim resourceIDParameter As ObjectParameter = If(resourceID.HasValue, New ObjectParameter("ResourceID", resourceID), New ObjectParameter("ResourceID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Resource_Remove", projectIDParameter, resourceIDParameter)
    End Function

    Public Overridable Function sp_Project_Resource_Update(projectID As Nullable(Of Integer), resourceID As Nullable(Of Integer)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim resourceIDParameter As ObjectParameter = If(resourceID.HasValue, New ObjectParameter("ResourceID", resourceID), New ObjectParameter("ResourceID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Resource_Update", projectIDParameter, resourceIDParameter)
    End Function

    Public Overridable Function sp_Project_Update(name As String, primaryLeadID As Nullable(Of Integer), secondaryLeadID As Nullable(Of Integer), typeID As Nullable(Of Integer), sizeID As Nullable(Of Integer), requesterID As Nullable(Of Integer), priorityID As Nullable(Of Integer), statusID As Nullable(Of Integer), departmentOfRequest As String, laborHours As Nullable(Of Double), rankingScore As Nullable(Of Integer), submitter As String, fOPALnumber As String, projectID As Nullable(Of Integer)) As Integer
        Dim nameParameter As ObjectParameter = If(name IsNot Nothing, New ObjectParameter("Name", name), New ObjectParameter("Name", GetType(String)))

        Dim primaryLeadIDParameter As ObjectParameter = If(primaryLeadID.HasValue, New ObjectParameter("PrimaryLeadID", primaryLeadID), New ObjectParameter("PrimaryLeadID", GetType(Integer)))

        Dim secondaryLeadIDParameter As ObjectParameter = If(secondaryLeadID.HasValue, New ObjectParameter("SecondaryLeadID", secondaryLeadID), New ObjectParameter("SecondaryLeadID", GetType(Integer)))

        Dim typeIDParameter As ObjectParameter = If(typeID.HasValue, New ObjectParameter("TypeID", typeID), New ObjectParameter("TypeID", GetType(Integer)))

        Dim sizeIDParameter As ObjectParameter = If(sizeID.HasValue, New ObjectParameter("SizeID", sizeID), New ObjectParameter("SizeID", GetType(Integer)))

        Dim requesterIDParameter As ObjectParameter = If(requesterID.HasValue, New ObjectParameter("RequesterID", requesterID), New ObjectParameter("RequesterID", GetType(Integer)))

        Dim priorityIDParameter As ObjectParameter = If(priorityID.HasValue, New ObjectParameter("PriorityID", priorityID), New ObjectParameter("PriorityID", GetType(Integer)))

        Dim statusIDParameter As ObjectParameter = If(statusID.HasValue, New ObjectParameter("StatusID", statusID), New ObjectParameter("StatusID", GetType(Integer)))

        Dim departmentOfRequestParameter As ObjectParameter = If(departmentOfRequest IsNot Nothing, New ObjectParameter("DepartmentOfRequest", departmentOfRequest), New ObjectParameter("DepartmentOfRequest", GetType(String)))

        Dim laborHoursParameter As ObjectParameter = If(laborHours.HasValue, New ObjectParameter("LaborHours", laborHours), New ObjectParameter("LaborHours", GetType(Double)))

        Dim rankingScoreParameter As ObjectParameter = If(rankingScore.HasValue, New ObjectParameter("RankingScore", rankingScore), New ObjectParameter("RankingScore", GetType(Integer)))

        Dim submitterParameter As ObjectParameter = If(submitter IsNot Nothing, New ObjectParameter("Submitter", submitter), New ObjectParameter("Submitter", GetType(String)))

        Dim fOPALnumberParameter As ObjectParameter = If(fOPALnumber IsNot Nothing, New ObjectParameter("FOPALnumber", fOPALnumber), New ObjectParameter("FOPALnumber", GetType(String)))

        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Project_Update", nameParameter, primaryLeadIDParameter, secondaryLeadIDParameter, typeIDParameter, sizeIDParameter, requesterIDParameter, priorityIDParameter, statusIDParameter, departmentOfRequestParameter, laborHoursParameter, rankingScoreParameter, submitterParameter, fOPALnumberParameter, projectIDParameter)
    End Function

    Public Overridable Function sp_Prupose_Insert(projectID As Nullable(Of Integer), comments As String, futureState As String) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim commentsParameter As ObjectParameter = If(comments IsNot Nothing, New ObjectParameter("Comments", comments), New ObjectParameter("Comments", GetType(String)))

        Dim futureStateParameter As ObjectParameter = If(futureState IsNot Nothing, New ObjectParameter("FutureState", futureState), New ObjectParameter("FutureState", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Prupose_Insert", projectIDParameter, commentsParameter, futureStateParameter)
    End Function

    Public Overridable Function sp_Purpose_Update(projectID As Nullable(Of Integer), comments As String, futureState As String) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim commentsParameter As ObjectParameter = If(comments IsNot Nothing, New ObjectParameter("Comments", comments), New ObjectParameter("Comments", GetType(String)))

        Dim futureStateParameter As ObjectParameter = If(futureState IsNot Nothing, New ObjectParameter("FutureState", futureState), New ObjectParameter("FutureState", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Purpose_Update", projectIDParameter, commentsParameter, futureStateParameter)
    End Function

    Public Overridable Function sp_Requester_Insert(name As String, email As String, phone As String, requestID As ObjectParameter) As Integer
        Dim nameParameter As ObjectParameter = If(name IsNot Nothing, New ObjectParameter("Name", name), New ObjectParameter("Name", GetType(String)))

        Dim emailParameter As ObjectParameter = If(email IsNot Nothing, New ObjectParameter("Email", email), New ObjectParameter("Email", GetType(String)))

        Dim phoneParameter As ObjectParameter = If(phone IsNot Nothing, New ObjectParameter("Phone", phone), New ObjectParameter("Phone", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Requester_Insert", nameParameter, emailParameter, phoneParameter, requestID)
    End Function

    Public Overridable Function sp_Requester_Update(name As String, email As String, phone As String, requestID As ObjectParameter) As Integer
        Dim nameParameter As ObjectParameter = If(name IsNot Nothing, New ObjectParameter("Name", name), New ObjectParameter("Name", GetType(String)))

        Dim emailParameter As ObjectParameter = If(email IsNot Nothing, New ObjectParameter("Email", email), New ObjectParameter("Email", GetType(String)))

        Dim phoneParameter As ObjectParameter = If(phone IsNot Nothing, New ObjectParameter("Phone", phone), New ObjectParameter("Phone", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_Requester_Update", nameParameter, emailParameter, phoneParameter, requestID)
    End Function

    Public Overridable Function sp_StatusUpdate_Insert(projectID As Nullable(Of Integer), projectStatusUpdate As String, projectStatusUpdateDate As Nullable(Of Date)) As Integer
        Dim projectIDParameter As ObjectParameter = If(projectID.HasValue, New ObjectParameter("ProjectID", projectID), New ObjectParameter("ProjectID", GetType(Integer)))

        Dim projectStatusUpdateParameter As ObjectParameter = If(projectStatusUpdate IsNot Nothing, New ObjectParameter("ProjectStatusUpdate", projectStatusUpdate), New ObjectParameter("ProjectStatusUpdate", GetType(String)))

        Dim projectStatusUpdateDateParameter As ObjectParameter = If(projectStatusUpdateDate.HasValue, New ObjectParameter("ProjectStatusUpdateDate", projectStatusUpdateDate), New ObjectParameter("ProjectStatusUpdateDate", GetType(Date)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_StatusUpdate_Insert", projectIDParameter, projectStatusUpdateParameter, projectStatusUpdateDateParameter)
    End Function

    Public Overridable Function sp_table_names() As ObjectResult(Of String)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of String)("sp_table_names")
    End Function

    Public Overridable Function sp_table_row_names(tableName As String) As ObjectResult(Of String)
        Dim tableNameParameter As ObjectParameter = If(tableName IsNot Nothing, New ObjectParameter("TableName", tableName), New ObjectParameter("TableName", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of String)("sp_table_row_names", tableNameParameter)
    End Function

End Class