Module Module1

    Sub Main()

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        a = 10
        b = 0

        Try
            c = a \ b
            ' Console.WriteLine(a / b)
        Catch ex As DivideByZeroException
            Console.WriteLine("DBZException " & ex.Message)
        Catch ex As ArithmeticException
            Console.WriteLine("AEx " & ex.Message)
        Catch ex As Exception
            Console.WriteLine("Ex " & ex.Message)

        End Try

        Console.ReadKey()
    End Sub

End Module
