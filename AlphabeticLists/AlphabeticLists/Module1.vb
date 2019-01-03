Module Module1

    Sub Main()
        ' the number of names in the list
        Dim n As Integer
        ' a temp to be used during sort
        Dim temp As String
        Dim index As Integer
        ' getting the number of names
        n = InputBox("Enter the number of names : ")
        ' a string vector to hold the list of names
        Dim a(n) As String
        ' entering the list of names
        For i = 0 To n - 1
            a(i) = InputBox("Enter the name no. " & i + 1)
        Next
        ' sorting the list in alphabetical order
        For j = 0 To n - 1
            temp = a(j)
            index = j
            For i = j To n - 1
                If a(i) < temp Then
                    temp = a(i)
                    index = i
                End If
            Next
            a(index) = a(j)
            a(j) = temp
        Next
        ' an arraylist(x) to store all groups
        Dim x As New ArrayList
        ' add an element to the arraylist(x) --> Group1
        x.Add(New ArrayList)
        ' add the first item in the list (a) to Group1
        x(0).Add(a(0))
        ' move through the list starting with the second element
        For i = 1 To n - 1
            ' if the first char of the current name is the same as that of the previous no need for a new arraylist
            If Not a(i).Chars(0) = a(i - 1).Chars(0) Then
                ' the first char of the current name is not the same as that of the previous
                x.Add(New ArrayList)
            End If
            x(x.Count - 1).Add(a(i))
        Next
        ' print each group in a separate line
        For i = 0 To x.Count - 1
            Console.Write(x(i)(0).ToString().Chars(0) & " : ")
            For j = 0 To x(i).Count - 1
                Console.Write(x(i)(j) & " ")
            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub
End Module
