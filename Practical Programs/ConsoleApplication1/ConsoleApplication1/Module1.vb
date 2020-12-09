Module Module1

    Sub Main()
        Dim a As Double = 6.4
        Dim b As Integer = 6
        Dim c As Integer = 10
        'Dim avg As Double = (a + b + c) / 3 '7.5
        'Dim avg As Integer = (a + b + c) / 3 '8
        Console.WriteLine(CInt(a))
        Dim avg As Integer = CInt((CInt(a) + b + c) / 3)
        MsgBox(avg)
    End Sub

End Module
