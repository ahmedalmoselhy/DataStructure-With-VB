Module Module1

    Sub Main()
        Dim theArray As New CArray(9)
        Dim index As Integer
        For index = 0 To 49
            theArray.insert(Int(100 * Rnd()) + 1)
        Next
        theArray.BubbleSort()
        Console.WriteLine(theArray.binarySearch(40))
        Console.Read()
    End Sub
    Class CArray
        Private arr() As Integer
        Private numElements As Integer

        Public Sub New(ByVal number As Integer)
            ReDim arr(number)
            numElements = 0
        End Sub

        Public Sub insert(ByVal item As Integer)
            ' Increasing the size of the array
            If numElements > arr.GetUpperBound(0) Then
                ReDim Preserve arr(numElements * 1.25)
            End If
            arr(numElements) = item
            numElements += 1
        End Sub

        Public Sub showArray()
            Dim index As Integer
            For index = 0 To numElements - 1
                Console.Write(arr(index) & " ")
            Next
            Console.WriteLine()
        End Sub

        Public Sub BubbleSort()
            Dim outer, inner, temp As Integer

            For outer = numElements - 1 To 1 Step -1
                For inner = 0 To outer - 1
                    If arr(inner) > arr(inner + 1) Then
                        temp = arr(inner)
                        arr(inner) = arr(inner + 1)
                        arr(inner + 1) = temp
                    End If
                Next
                Me.showArray()
            Next
        End Sub

        Public Sub selectioSort()
            Dim outer, inner, temp, min As Integer
            For outer = 0 To numElements - 2
                min = outer
                For inner = outer + 1 To numElements - 1
                    If arr(inner) < arr(min) Then
                        min = inner
                    End If
                Next
                temp = arr(outer)
                arr(outer) = arr(min)
                arr(min) = temp
                Me.showArray()
            Next
        End Sub

        Public Function binarySearch(ByVal value As Integer)
            Dim upperBound, lowerBound, mid As Integer
            ' set the bounds of the array
            upperBound = arr.GetUpperBound(0)
            lowerBound = 0
            Do While (lowerBound <= upperBound)
                mid = (lowerBound + upperBound) / 2
                If arr(mid) = value Then
                    Return mid
                ElseIf value < arr(mid) Then
                    upperBound = mid - 1
                Else
                    lowerBound = mid + 1
                End If
            Loop
            Return -1
        End Function
    End Class
End Module
