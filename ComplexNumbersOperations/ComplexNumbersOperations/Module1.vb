Module Module1

    Sub Main()
        Dim num1, num2 As String
        'Dim re1, img1, re2, img2 As Integer
        Dim compObj As New complexNumbers


        num1 = InputBox("Enter The First Number As Shown 'Real + jImaginary'")



        num2 = InputBox("Enter The Second Number As Shown 'Real + jImaginary'")


        'now define the desired operation using inputbox

        Dim oper As Char
operTag:
        Console.WriteLine("Enter The operation you want to perform '+' '-' '*' '/'")

        oper = Console.ReadLine()

        'define the result
        Dim result As String

        If oper = "+" Then
            result = compObj.add(num1, num2)
        ElseIf oper = "-" Then
            result = compObj.subt(num1, num2)
        ElseIf oper = "*" Then
            result = compObj.multi(num1, num2)
        ElseIf oper = "/" Then
            result = compObj.devide(num1, num2)
        End If

        Console.WriteLine("The Result = " & result)
        Console.WriteLine("-------------------")

        GoTo operTag


    End Sub
    Class complexNumbers

        Function GetReAndImg(ByVal num, ByRef real, ByRef imagin)
            'used to get the real and imaginary values for each number entered!

            If num.Contains("+j") Then
                real = Val(num.Split("j")(0))
                imagin = Val(num.Split("j")(1))
            Else
                real = Val(num.Split("j")(0))
                imagin = Val(num.Split("j")(1)) * -1
            End If



        End Function

        Function add(ByVal number1, ByVal number2)
            Dim sum As String
            Dim real1, real2, imagin1, imagin2 As Integer
            GetReAndImg(number1, real1, imagin1)
            GetReAndImg(number2, real2, imagin2)
            Dim reTotal = real1 + real2
            Dim imgTotal = imagin1 + imagin2

            If imgTotal < 0 Then
                sum = reTotal.ToString + "-j" + (imgTotal * -1).ToString + ""
            Else
                sum = reTotal.ToString + "+j" + imgTotal.ToString + ""
            End If

            Return sum
        End Function

        Function subt(ByVal number1, ByVal number2)
            Dim res As String
            Dim real1, real2, imagin1, imagin2 As Integer
            GetReAndImg(number1, real1, imagin1)
            GetReAndImg(number2, real2, imagin2)
            Dim reSubt = real1 - real2
            Dim imgSubt = imagin1 - imagin2

            If imgSubt < 0 Then
                res = reSubt.ToString + "-j" + (imgSubt * -1).ToString
            Else
                res = reSubt.ToString + "+j" + imgSubt.ToString
            End If

            Return res
        End Function

        Function multi(ByVal number1, ByVal number2)
            Dim mul As String
            Dim reMulti As Integer
            Dim imgMulti As Integer
            Dim real1, real2, imagin1, imagin2 As Integer
            GetReAndImg(number1, real1, imagin1)
            GetReAndImg(number2, real2, imagin2)

            reMulti = (real1 * real2) + (-1 * (imagin1 * imagin2))
            imgMulti = (real1 * imagin2) + (real2 * imagin1)

            If imgMulti < 0 Then
                mul = reMulti.ToString + "-j" + (imgMulti * -1).ToString
            Else
                mul = reMulti.ToString + "+j" + imgMulti.ToString
            End If

            Return mul
        End Function

        Function devide(ByVal number1, ByVal number2)
            Dim dev As String
            Dim Base As Single
            Dim real1, real2, imagin1, imagin2 As Integer
            GetReAndImg(number1, real1, imagin1)
            GetReAndImg(number2, real2, imagin2)
            Dim remulti, imgmulti As Double

            Base = real2 ^ 2 + imagin2 ^ 2

            remulti = real1 * real2 + imagin1 * imagin2

            imgmulti = imagin1 * real2 - (imagin2 * real1)

            remulti = remulti / Base
            imgmulti = imgmulti / Base


            If imgmulti < 0 Then
                dev = remulti.ToString + "-j" + (imgmulti * -1).ToString
            Else
                dev = remulti.ToString + "+j" + imgmulti.ToString
            End If


            Return dev
        End Function

    End Class
End Module


