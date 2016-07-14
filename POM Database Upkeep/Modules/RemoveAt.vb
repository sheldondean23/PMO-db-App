'RemoveAt method for arrays
Module ArrayRemoveAt
    'Code used from: Alex Essilfie & ToolmakerSteve Via StackOverFlow
    'Call method As follows: array.RemoveAt(someInt)
    <System.Runtime.CompilerServices.Extension()>
    Public Sub qRemoveAt(Of T)(ByRef arr As T(), ByVal indexToRemove As Integer)
        If indexToRemove = -1 Then
            MsgBox("A selection must be made!")
            Return
        End If
        Dim uBounds = arr.GetUpperBound(0)
        Dim lBounds = arr.GetLowerBound(0)
        Dim arrLen = uBounds - lBounds

        If indexToRemove < lBounds OrElse indexToRemove > uBounds Then
            Throw New ArgumentOutOfRangeException(
        String.Format("Index must be from {0} to {1}.", lBounds, uBounds))

        Else
            ' Move elements after "index" down 1 position.
            Array.Copy(arr, indexToRemove + 1, arr, indexToRemove, UBound(arr) - indexToRemove)
            ' Shorten by 1 element.
            ReDim Preserve arr(UBound(arr) - 1)

            ''Also try
            'arr = arr.Where(Function(item, index) index <> indexToRemove).ToArray 'Ivan Ferrer Villa via StackOverFlow
        End If
    End Sub
End Module

