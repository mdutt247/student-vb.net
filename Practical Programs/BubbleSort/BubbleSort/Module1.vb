Module Module1

    Sub Main()

        Dim arr() As Integer = {30, 12, 32, 34, 45, 90}
        Dim n As Integer = arr.Length

        Dim i, j As Integer

        For i = 0 To n Step 1

            For j = n - 1 To i + 1 Step -1

                If (arr(j) < arr(j - 1)) Then

                    Dim temp As Integer = arr(j)

                    arr(j) = arr(j - 1)

                    arr(j - 1) = temp

                End If

            Next

        Next


        Dim k As Integer

        For k = 0 To arr.Length - 1

            Console.WriteLine(arr(k))

        Next

        Console.ReadKey()
    End Sub

End Module
