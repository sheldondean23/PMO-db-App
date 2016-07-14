Imports System.Data.SqlClient

Public Class dbConnection
    Private connection As SqlConnection

    Sub New()
        'Sets Connection String
        connection = New SqlConnection("Data Source=HOSDBSRV2.usadir.usa.usouthal.edu;Initial Catalog=HSISProjects;Persist Security Info=True;User ID=HSISPMO;Password=PMOoffice!")
        'connection = New SqlConnection("Data Source=TSH6\SQLEXPRESS;Initial Catalog=HSISProjectsTest;Integrated Security=True")
    End Sub

    Function newQuery(ByVal SQLCommand As String, ByVal tableName As String) As DataTable
        Dim dtResults As new DataTable
        If tableName = "" Then
            tableName = "Custom"
        End If
        connection.Open()
        'Checks for unwanted SQL keywords
        SQLCommand = SQLCommand.ToLower 
        If SQLCommand.Contains("delete") Or SQLCommand.Contains(" update ") Or SQLCommand.Contains("insert") Or SQLCommand.Contains("into") Or SQLCommand.Contains("alter") Or SQLCommand.Contains("drop") Or SQLCommand.Contains("truncate") Or SQLCommand.Contains("create") or SQLCommand.Contains("replace") then
            MsgBox("Invalid SQL commands used!")
            Return dtResults
        End If
        'Sets query
        Dim query As New SqlDataAdapter(SQLCommand, connection)
        Dim dsResutls As New DataSet("Results")
        'Fills a Dataset
        Try
            query.FillSchema(dsResutls, SchemaType.Source, tableName)
            query.Fill(dsResutls, tableName)
        Catch ex As SqlException
            connection.Close()
            MsgBox(ex.Message)
        End Try

        connection.Close()
        'Fills Datatable (for Data grid view)
        dtResults = dsResutls.Tables(tableName)
        Return dtResults
    End Function
    
    Function anyQuery(ByVal SQLCommand As String, ByVal tableName As String) As DataTable
        Dim dtResults As new DataTable
        If tableName = "" Then
            tableName = "Custom"
        End If
        connection.Open()
        'Sets query
        Dim query As New SqlDataAdapter(SQLCommand, connection)
        Dim dsResutls As New DataSet("Results")
        'Fills a Dataset
        Try
            query.FillSchema(dsResutls, SchemaType.Source, tableName)
            query.Fill(dsResutls, tableName)
        Catch ex As SqlException
            connection.Close()
            MsgBox(ex.Message)
        End Try

        connection.Close()
        'Fills Datatable (for Data grid view)
        dtResults = dsResutls.Tables(tableName)
        Return dtResults
    End Function

    'Sub Add(ByVal statement As String)
    '    Using comm As New SqlCommand()
    '        With comm
    '            .Connection = connection
    '            .CommandType = CommandType.Text
    '            .CommandText = statement
    '        End With
    '        Try
    '            connection.Open()
    '            comm.ExecuteNonQuery()
    '        Catch ex As SqlException

    '            connection.Close()
    '            MessageBox.Show(ex.Message)
    '        End Try

    '        connection.Close()
    '    End Using
    'End Sub
End Class
