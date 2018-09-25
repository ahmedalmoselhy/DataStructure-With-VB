Module Module1

    Sub Main()
        Dim num1, num2 As String
        Dim re1, img1, re2, img2 As Integer

        num1 = InputBox("Enter The First Number As Shown 'Real + jImaginary'")

        GetReAndImg(num1, re1, img1)

        num2 = InputBox("Enter The Second Number As Shown 'Real + jImaginary'")

        GetReAndImg(num2, re2, img2)

        'now define the desired operation using inputbox

        Dim oper As Char

        oper = InputBox("Enter The operation you want to perform '+' '-' '*' '/'")

        'define the result
        Dim result As String

        If oper = "+" Then
            result = add(re1, re2, img1, img2)
        ElseIf oper = "-" Then
            result = subt(re1, re2, img1, img2)
        ElseIf oper = "*" Then
            result = multi(re1, re2, img1, img2)
        ElseIf oper = "/" Then
            result = devide(re1, re2, img1, img2)
        End If


        MsgBox("The Result = " & result)

    End Sub

    Function GetReAndImg(ByVal num, ByRef real, ByRef imagin)
        'used to get the real and imaginary values for each number entered!
        If num.Contains("+") Then
            real = Val(num.Split("+j")(0))
            imagin = Val(num.Split("+j")(1))
        Else
            real = Val(num.Split("-j")(0))
            imagin = Val(num.Split("-j")(1) * -1)
        End If



    End Function

    Function add(ByVal real1, ByVal real2, ByVal imagin1, ByVal imagin2)
        Dim sum As String
        Dim reTotal = real1 + real2
        Dim imgTotal = imagin1 + imagin2

        If imgTotal < 1 Then
            sum = reTotal.ToString + "-j" + (imgTotal * -1).ToString
        Else
            sum = reTotal.ToString + "+j" + imgTotal.ToString
        End If

        Return sum
    End Function

    Function subt(ByVal real1, ByVal real2, ByVal imagin1, ByVal imagin2)
        Dim res As String
        Dim reSubt = real1 - real2
        Dim imgSubt = imagin1 - imagin2

        If imgSubt < 1 Then
            res = reSubt.ToString + "-j" + (imgSubt * -1).ToString
        Else
            res = reSubt.ToString + "+j" + imgSubt.ToString
        End If

        Return res
    End Function

    Function multi(ByVal real1, ByVal real2, ByVal imagin1, ByVal imagin2)
        Dim mul As String


        Return mul
    End Function

    Function devide(ByVal real1, ByVal real2, ByVal imagin1, ByVal imagin2)
        Dim dev As String


        Return dev
    End Function
End Module
