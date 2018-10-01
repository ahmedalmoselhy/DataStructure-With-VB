Module Module1

    Sub Main()
        Dim m As Integer = InputBox("Enter M")
        Dim n As Integer = InputBox("Enter N")
        Dim v As Integer = InputBox("Enter V")

        Dim A(m, n) As Integer
        Dim B(n, v) As Integer
        Dim C(m, v) As Integer



        Dim resObj As New multi

        For i = 0 To m - 1
            For j = 0 To n - 1
                A(i, j) = resObj.input(i, j)
                'Console.WriteLine(A(i, j))
            Next
        Next

        For i = 0 To n - 1
            For j = 0 To v - 1
                B(i, j) = resObj.input(i, j)
                'Console.WriteLine(B(i, j))
            Next
        Next


        For i = 0 To m - 1
            For j = 0 To n - 1
                For k = 0 To v - 1
                    C(i, k) += resObj.multiply(A(i, j), B(j, k))
                Next
            Next
        Next

        For i = 0 To m - 1
            For k = 0 To v - 1
                resObj.output(C(i, k))
            Next
        Next

        'resObj.output(C(i, k))

        Console.ReadLine()

    End Sub


    'this class to multiply
    Class multi
        Inherits InputOutput

        Function multiply(ByVal a As Integer, ByVal b As Integer)
            Dim m As Integer = a * b
            Return m
        End Function

    End Class


    'the input and output
    Class InputOutput

        Function input(ByVal x As Integer, ByVal y As Integer)
            Dim element As Integer = InputBox("Enter Element No [" & x + 1 & ", " & y + 1 & "]")
            Return element
        End Function
        Sub output(ByVal element As Integer)
            Console.WriteLine(element)
        End Sub

    End Class


End Module
