Module Module1

    Sub Main()

        Dim num As Integer
        Dim str As String
        Dim len As Integer
        Dim sum As Integer = 0
        Dim temp As Integer
        Dim rm As Integer

        Console.Write("Enter the number: ")
        num = Console.ReadLine()

        str = num.ToString
        len = str.Length

        temp = num
      
        While temp <> 0
            rm = temp Mod 10
            sum = sum + rm
            temp = temp / 10
        End While

        Console.WriteLine("Sum of Digits is: " & sum)
        Console.ReadKey()
    End Sub

End Module
