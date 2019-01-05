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
    Sub Main()
        Dim stack As New myStack()
        Dim input As String = InputBox("Enter a sentence to reverse")
        ' push each character in the sentence into the stack
        For i = 0 To input.Length - 1
            stack.push(input.Chars(i))
        Next

        Dim numElements As Integer = stack.count()
        Dim reverse As String = ""
        ' pop reversed sentence characters from the stack
        For i = 0 To numElements - 1
            reverse &= stack.pop()
        Next

        Console.WriteLine("The Reversed Sentence is : ")
        Console.WriteLine(reverse)
        stack.clear()

        ' check if the input word is palindrome
        Dim word As String = InputBox("Enter a word :")
        Dim x As Integer
        Dim isPalindrome As Boolean = True
        For x = 0 To word.Length - 1
            stack.push(word.Chars(x))
        Next

        ' pop the characters from the stack and compare it with the word
        For x = 0 To (word.Length - 1) / 2
            If stack.pop <> word.Chars(x) Then
                isPalindrome = False
                Exit For
            End If
        Next

        If isPalindrome Then
            Console.WriteLine("The Word " & word & " is palindrome")
        Else
            Console.WriteLine("The Word " & word & " is not palindrome")
        End If

        stack.clear()
        ' check if a mathemtaical sentence is correct using stack
        Dim sentence As String = InputBox("Enter the mathematical sentence:")
        For i = 0 To sentence.Length - 1
            Dim ch As Char = sentence.Chars(i)

            Select Case ch
                Case "{", "[", "("
                    stack.push(ch)
                Case "}", "]", ")"
                    If stack.isEmpty() Then
                        GoTo wrong
                    Else
                        Dim chx As Char = stack.pop()
                        If (ch = "}" And chx <> "{") Or (ch = ")" And chx <> "(") Or (ch = "]" And chx <> "[") Then
                            GoTo wrong
                        End If
                    End If
            End Select
        Next

        If stack.isEmpty() Then
            Console.WriteLine("Sentence is correct")
        Else
wrong:
            Console.WriteLine("Sentence is wrong")
        End If
        Console.Read()
    End Sub

End Module
