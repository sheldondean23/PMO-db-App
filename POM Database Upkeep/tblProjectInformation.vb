'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblProjectInformation
    Public Property ProjectID As Integer
    Public Property ProjectName As String
    Public Property HSISPrimaryLeadID As Nullable(Of Integer)
    Public Property HSISSecondaryLeadID As Nullable(Of Integer)
    Public Property ProjectRequestTypeID As Integer
    Public Property ProjectSizeID As Nullable(Of Integer)
    Public Property ProjectRequesterID As Integer
    Public Property ProjectPriorityID As Nullable(Of Integer)
    Public Property ProjectStatusID As Nullable(Of Integer)
    Public Property DepartmentOfRequest As String
    Public Property ProjectLaborHours As Nullable(Of Double)
    Public Property ProjectRankingScore As Nullable(Of Integer)
    Public Property ProjectSubmitter As String
    Public Property ProjectFOPALnumber As String

    Public Overridable Property tblHSISPrimaryLead As tblHSISPrimaryLead
    Public Overridable Property tblHSISSecondaryLead As tblHSISSecondaryLead
    Public Overridable Property tblProjectBudgets As ICollection(Of tblProjectBudget) = New HashSet(Of tblProjectBudget)
    Public Overridable Property tblProjectCategories As ICollection(Of tblProjectCategory) = New HashSet(Of tblProjectCategory)
    Public Overridable Property tblProjectDates As ICollection(Of tblProjectDate) = New HashSet(Of tblProjectDate)
    Public Overridable Property tblProjectFacilities As ICollection(Of tblProjectFacility) = New HashSet(Of tblProjectFacility)
    Public Overridable Property tblProjectRequestType As tblProjectRequestType
    Public Overridable Property tblProjectSize As tblProjectSize
    Public Overridable Property tblProjectRequester As tblProjectRequester
    Public Overridable Property tblProjectPriority As tblProjectPriority
    Public Overridable Property tblProjectStatu As tblProjectStatu
    Public Overridable Property tblProjectResources As ICollection(Of tblProjectResource) = New HashSet(Of tblProjectResource)
    Public Overridable Property tblProjectPurposes As ICollection(Of tblProjectPurpose) = New HashSet(Of tblProjectPurpose)
    Public Overridable Property tblProjectStatusUpdates As ICollection(Of tblProjectStatusUpdate) = New HashSet(Of tblProjectStatusUpdate)

End Class
