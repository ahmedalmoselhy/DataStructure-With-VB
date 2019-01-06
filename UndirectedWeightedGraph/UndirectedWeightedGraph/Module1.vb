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

        Public Sub addVertex(ByVal label As String)
            vertices(numVerts) = New MyVertex(label)
            numVerts += 1
        End Sub

        Public Sub addEgde(ByVal start As Integer, ByVal eend As Integer, ByVal weight As Integer)
            adjMatrix(start, eend) = weight
            adjMatrix(eend, start) = weight
        End Sub

        Public Sub showVertex(ByVal v As Integer)
            Console.Write(vertices(v).label)
        End Sub

        ' Describe the Graph:
        ' The function that return with the graph as string in suitable format
        Public Function getDescription() As String
            Dim str As String = "Vertices:" + vbCrLf
            ' Write all IDs of all vertices each in a separate line
            For i = 0 To numVerts - 1
                str &= vertices(i).label + vbCrLf
            Next
            str &= vbCrLf & "Edges:" & vbCrLf

            ' Write the description of each edge as a connection between two vertices each displayed as a vertex ID
            For i = 0 To numVerts - 1
                For j = 0 To i
                    If adjMatrix(i, j) > 0 Then
                        str &= vertices(i).label & " <- " & adjMatrix(i, j) & " -> " & vertices(j).label & vbCrLf
                    End If
                Next
            Next
            Return str
        End Function
    End Class
    Sub Main()
        Dim aGraph As New MyGraph()

        aGraph.addVertex("A")
        aGraph.addVertex("B")
        aGraph.addVertex("C")
        aGraph.addVertex("D")
        aGraph.addVertex("E")
        aGraph.addVertex("F")
        aGraph.addVertex("G")
        aGraph.addVertex("H")

        aGraph.addEgde(0, 1, 5)
        aGraph.addEgde(0, 5, 5)
        aGraph.addEgde(1, 2, 5)
        aGraph.addEgde(1, 3, 4)
        aGraph.addEgde(1, 4, 4)
        aGraph.addEgde(2, 4, 3)
        aGraph.addEgde(2, 7, 4)
        aGraph.addEgde(3, 4, 4)
        aGraph.addEgde(3, 5, 4)
        aGraph.addEgde(3, 6, 4)
        aGraph.addEgde(4, 6, 5)
        aGraph.addEgde(4, 7, 5)
        aGraph.addEgde(5, 6, 5)
        aGraph.addEgde(6, 7, 5)

        Console.WriteLine(aGraph.getDescription())
        Console.Read()

    End Sub

End Module
