Module Module2
    Sub cont()
        Dim sumNum, sumBigNum As Integer
        Dim i As Byte
        For i = 1 To 6
            sumNum += i
            If i < 4 Then
                Continue For
            End If
            sumBigNum += i
        Next
        Console.WriteLine(sumNum & "  " & sumBigNum)
        Console.ReadKey()
    End Sub


End Module
