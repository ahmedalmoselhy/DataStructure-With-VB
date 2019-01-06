Module Module1
    Class MyVertex
        Public wasVisited As Boolean
        Public label As String
        Public Sub New(ByVal label As String)
            Me.label = label
            wasVisited = False
        End Sub
    End Class
    Class MyGraph
        Private Const NUM_VERTICES As Integer = 20
        Private vertices() As MyVertex
        Private adjMatrix(,) As Integer
        Private numVerts As Integer

        Public Sub New()
            ReDim vertices(NUM_VERTICES - 1)
            ReDim adjMatrix(NUM_VERTICES - 1, NUM_VERTICES - 1)
            numVerts = 0

            Dim j, k As Integer

            For j = 0 To adjMatrix.GetUpperBound(0)
                For k = 0 To adjMatrix.GetUpperBound(1)
                    If j = k Then
                        adjMatrix(j, k) = 0
                    Else
                        adjMatrix(j, k) = -1
                    End If
                Next
            Next
        End Sub

    End Class
    Sub Main()

    End Sub

End Module
