Module Module1
    Public Class A

    End Class
    Public Class B

    End Class
    Public Class C

    End Class

    Sub Main()
        Dim a = New A
        Dim b = New A
        a = b
        Dim c = New C
        If a Is b Then
            Console.WriteLine("a and b are same")
        End If
        If b IsNot c Then
            Console.WriteLine("b and c are not same")
        End If
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub

End Module

