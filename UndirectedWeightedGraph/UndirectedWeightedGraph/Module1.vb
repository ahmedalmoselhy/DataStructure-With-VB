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

        End Sub
    End Class
    Sub Main()

    End Sub

End Module
