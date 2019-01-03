Module Module1

    Sub Main()
        Dim theArray As New CArray(9)
        Dim index As Integer
        For index = 0 To 49
            theArray.insert(Int(100 * Rnd()) + 1)
        Next
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

    End Class
End Module
