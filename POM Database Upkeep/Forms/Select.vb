Public Class frmSelect
    Public querys() As Query
    Public columNames() As String
    Private fruitContextMenuStrip As ContextMenuStrip

    Private Sub frmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen 
        'Clears list box
        lstQuery.Items.Clear()
        'Adds values to Table Combo box
        Dim tableNames As New HSISProjectsDataSetTableAdapters.sp_table_namesTableAdapter
        Dim tables As DataTable
        tables = tableNames.GetData

        For i As Integer = 0 To tables.Rows.Count - 2
            cmbTable.Items.Add(tables.Rows.Item(i).ItemArray(0).ToString)
        Next
        'turns on horzontal scroll bar
        lstQuery.HorizontalScrollbar = True
    End Sub

    Private Sub cmbTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTable.SelectedIndexChanged
        'Adds values to Column Combo box
        Dim tableRowNames As New HSISProjectsDataSetTableAdapters.sp_table_row_namesTableAdapter
        Dim rows As DataTable
        rows = tableRowNames.GetData(cmbTable.SelectedItem)

        clstColumn.Items.Clear()

        'Add items to checked list box
        For i As Integer = 0 To rows.Rows.Count - 1
            clstColumn.Items.Add(rows.Rows.Item(i).ItemArray(0).ToString)
        Next
        'turns on horzontal scroll bar
        clstColumn.HorizontalScrollbar = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim quertNum As Integer = lstQuery.Items.Count
        'Checks to see if both combo boxes are selected
        If IsNothing(clstColumn.CheckedItems) Or cmbTable.SelectedIndex = -1 Then
            MsgBox("You must select a table and column!")
            Return
        End If

        'Formats and adds data into the Query class
        ReDim columNames(clstColumn.CheckedItems.Count - 1)
        clstColumn.CheckedItems.CopyTo(columNames, 0)
        ReDim Preserve querys(quertNum)
        'Checks to see if "where" textbox is filled and creates query appropriatly
        If Not (txtWhere.Text = Nothing Or txtWhere.Text = "") Then
            querys(quertNum) = New Query(cmbTable.SelectedItem, columNames, txtWhere.Text)
        Else
            querys(quertNum) = New Query(cmbTable.SelectedItem, columNames)
        End If

        'Checks to see that duplicate data is not put in the list box
        If Not lstQuery.Items.Count = 0 Then
            For i As Integer = 0 To quertNum - 1
                If (querys(quertNum).SelectStatment) = lstQuery.Items(i) Then
                    querys.qRemoveAt(quertNum)
                    MsgBox("You can not select the same table and column twice!")
                    Return
                End If
            Next
        End If

        'Adds data to listbox
        Try
            lstQuery.Items.Add(querys(quertNum).SelectStatment)
        Catch ex As Exception
            querys.qRemoveAt(quertNum)
            Return
        End Try

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If lstQuery.SelectedIndex = -1 Then
            MsgBox("You must select a query!")
        Else
            'Displays Output form
            frmOutPut.Close()
            frmOutPut.Show()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Removes Selected index from arry
        querys.qRemoveAt(lstQuery.SelectedIndex)
        'Removes Selected index from listbox
        Try
            lstQuery.Items.RemoveAt(lstQuery.SelectedIndex)
        Catch ex As ArgumentOutOfRangeException
            Return
        End Try

    End Sub

    Private Sub clstColumn_MouseUp(sender As Object, e As MouseEventArgs) Handles clstColumn.MouseUp
        'Determines if the click event was from a right click
        If e.Button = MouseButtons.Right Then
            'Finds the index of the item that the mouse clicked
            Dim index As Integer = clstColumn.IndexFromPoint(New Point(e.X, e.Y))
            If index >= 0 Then
                clstColumn.SelectedItem = clstColumn.Items(index)
            End If
        End If
    End Sub

    Private Sub AverageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AverageToolStripMenuItem.Click
        clstColumn.Items(clstColumn.SelectedIndex) = "AVG(" & clstColumn.SelectedItem & ")"
    End Sub

    Private Sub CountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountToolStripMenuItem.Click
        clstColumn.Items(clstColumn.SelectedIndex) = "COUNT(" & clstColumn.SelectedItem & ")"
    End Sub

    Private Sub MaxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaxToolStripMenuItem.Click
        clstColumn.Items(clstColumn.SelectedIndex) = "MAX(" & clstColumn.SelectedItem & ")"
    End Sub

    Private Sub MinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem.Click
        clstColumn.Items(clstColumn.SelectedIndex) = "MIN(" & clstColumn.SelectedItem & ")"
    End Sub

    Private Sub SumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumToolStripMenuItem.Click
        clstColumn.Items(clstColumn.SelectedIndex) = "SUM(" & clstColumn.SelectedItem & ")"
    End Sub
    Private Sub DistinctToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistinctToolStripMenuItem.Click
        clstColumn.Items(clstColumn.SelectedIndex) = "Distinct " & clstColumn.SelectedItem
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Checks to see if an Aggregate Function is present
        If Not clstColumn.SelectedItem.ToString.IndexOf("(") = -1 Or Not clstColumn.SelectedItem.ToString.IndexOf("Distinct") = -1 Then
            clstColumn.Items(clstColumn.SelectedIndex) = Query.RemoveAgg(clstColumn,,)
        Else
            MsgBox("There is no Aggregate Function selected for this column!")
            Return
        End If
    End Sub

    Private Sub frmSelect_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmPick.Show()
        frmGroupByPopup.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCustomQuery.Click
       Dim queryNum As Integer = lstQuery.Items.Count  
        ReDim Preserve querys(queryNum)
        querys(queryNum) = New Query
        querys(queryNum).FullQuery = rtxtCustom.Text
        'Adds data to listbox
        Try
            lstQuery.Items.Add(querys(queryNum).FullQuery)
        Catch ex As Exception
            querys.qRemoveAt(queryNum)
            Return
        End Try

    End Sub
End Class