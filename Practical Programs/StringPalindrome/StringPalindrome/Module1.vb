Module Module1

    Sub Main()

        Dim str As String
        Dim len As Integer
        Dim rev(100) As String
        Dim revstr As String = ""

        Console.WriteLine("Enter a String:  ")

        str = Console.ReadLine()
        len = str.Length


        For i As Integer = len To 1 Step -1
            rev(len - i) = str(i - 1)
        Next

        For i As Integer = 0 To len - 1
            revstr = revstr + rev(i)
        Next

        Console.WriteLine()

        If str = revstr Then
            Console.WriteLine("It is a Palindrome")
        Else
            Console.WriteLine("It is Not a Palindrome")
        End If


        Console.ReadKey()

    End Sub

End Module
