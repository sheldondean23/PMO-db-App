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

Partial Public Class tblProjectRequestType
    Public Property ProjectRequestTypeID As Integer
    Public Property ProjectRequestTypeName As String

    Public Overridable Property tblProjectInformations As ICollection(Of tblProjectInformation) = New HashSet(Of tblProjectInformation)

End Class