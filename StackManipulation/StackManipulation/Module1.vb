Module Module1
    Class myStack
        Private ToS As Integer
        Private list As New ArrayList()
        ' constructor to set ToS to -1
        Public Sub New()
            ToS = -1
        End Sub

        ' a function to return the number of elements in the stack
        Function count() As Integer
            Return list.Count
        End Function

        ' a method to insert new items in the stack
        Public Sub push(ByVal value As Object)
            list.Add(value)
            ToS += 1
        End Sub

        ' a function to remove the top of stack and return with it
        Public Function pop()
            If isEmpty() Then
                Return -1
            End If
            Dim obj As Object = list.Item(ToS)
            list.RemoveAt(ToS)
            ToS -= 1
            Return obj
        End Function

        ' a method to clear the stack
        Public Sub clear()
            list.Clear()
            ToS = -1
        End Sub

        ' a function to return the TOS without removing it
        Public Function peek()
            Return list.Item(ToS)
        End Function

        Public Function isEmpty()
            If ToS = -1 Then
                Return True
            End If
            Return False
        End Function
    End Class

    Public Function inputItems(ByVal no As Integer)
        Dim stk As New myStack()
        Dim element As Integer
        For i = 0 To no - 1
            element = InputBox("Enter element " & i + 1 & " to be pushed:")
            stk.push(element)
        Next
        Return stk
    End Function

    Public Sub printItems(ByVal stk As myStack)
        Dim i As Integer = 0
        While Not stk.isEmpty()
            Console.WriteLine("Top of Stack No." & (i + 1) & " = " & stk.pop())
            i += 1
        End While
    End Sub

    Public Function reverse(ByVal stk As myStack)
        Dim stk1 As New myStack()
        For i = 0 To stk.count - 1
            stk1.push(stk.pop())
        Next
        Return stk1
    End Function

    Public Function getLargest(ByVal stk As myStack)
        Dim element, max As Integer
        max = stk.pop()
        While Not stk.isEmpty()
            element = stk.pop()
            If element > max Then max = element
        End While
        Return max
    End Function
    Sub Main()

    End Sub

End Module
