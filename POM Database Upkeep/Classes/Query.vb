Public Class Query
    Public columnNames() As String
    Public tableName As String
    Private whereClause As String
    Private groupBy As String = Nothing
    Public FullQuery As String

    'Default Constructor
    Sub New()
        ReDim columnNames(0)
        tableName = ""
    End Sub

    'Overrided Constructor
    Sub New(ByVal l_tableName As String, ByVal l_columnNames() As String, Optional ByVal where As String = Nothing)
        columnNames = l_columnNames
        tableName = l_tableName
        If Not where = Nothing Then
            whereClause = " where " + where
        Else
            whereClause = where
        End If
        ReDim Preserve columnNames(columnNames.Count - 1)
    End Sub

    'Prints array to string separated by ", "
    Function ColumnsToString() As String
        If columnNames.Count = 0 Then
            Return "*"
        Else
            For i As Integer = 0 To columnNames.Count - 1
                If Not columnNames(i).IndexOf("(") = -1 Then
                    columnNames(i) += " as '" + RemoveAgg(,, columnNames(i)) + "'"
                Else
                    columnNames(i) = columnNames(i)
                End If
            Next
            Return String.Join(", ", columnNames)
        End If

    End Function

    'Concatinats pices of the select statement together
    Function SelectStatment() As String
        Dim numOfAggFunctions As Integer

        For i As Integer = 0 To columnNames.Count - 1
            If Not columnNames(i).IndexOf("(") = -1 Then
                numOfAggFunctions += 1
            End If
        Next

        If numOfAggFunctions < columnNames.Count And Not numOfAggFunctions = 0 Then

            frmGroupByPopup.ShowDialog()
            If frmGroupByPopup.cmbGroupByOptions.SelectedIndex = -1 Then
                Return Nothing
            Else
                groupBy = " group by " + frmGroupByPopup.cmbGroupByOptions.SelectedItem
            End If

        End If

        FullQuery = "Select " + ColumnsToString() + " From " + tableName + whereClause + groupBy
        Return FullQuery
    End Function

    'Only Send ONE optional parameter
    Shared Function RemoveAgg(Optional ByVal CheckedListBox As CheckedListBox = Nothing, Optional ByVal ComboBox As ComboBox = Nothing, Optional ByVal aString As String = "") As String
        Dim aggFunctionSelect As String

        If Not IsNothing(CheckedListBox) Then
            aggFunctionSelect = CheckedListBox.SelectedItem.ToString
            Return aggFunctionSelect.Substring(aggFunctionSelect.IndexOf("(") + 1, aggFunctionSelect.Count - 2 - aggFunctionSelect.IndexOf("("))
        ElseIf Not IsNothing(ComboBox) Then
            aggFunctionSelect = ComboBox.SelectedItem.ToString
            Return aggFunctionSelect.Substring(aggFunctionSelect.IndexOf("(") + 1, aggFunctionSelect.Count - 2 - aggFunctionSelect.IndexOf("("))
        ElseIf Not aString = "" Then
            aggFunctionSelect = aString
            Return aggFunctionSelect.Substring(aggFunctionSelect.IndexOf("(") + 1, aggFunctionSelect.Count - 2 - aggFunctionSelect.IndexOf("("))
        End If
        Return MsgBox("The RemoveAgg function must recive one optional parameter. Please contact proggramer.")
    End Function
End Class
