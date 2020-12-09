
Public Class Student

    Public Function disp() As Integer
        Console.WriteLine("This is Function 1")
        Return disp
    End Function

    Public Function disp(ByVal i As String) As Integer
        Console.WriteLine("This is Function 2")
        Dim s As String
        s = i
        Console.WriteLine(s)
        Return disp
    End Function

    Public Function disp(ByVal i As Integer, ByVal j As Double) As Integer
        Console.WriteLine("This is Function 3")
        Dim a As Integer
        Dim b As Double
        a = i
        b = j
        Console.WriteLine(a)
        Console.WriteLine(b)
        Return disp
    End Function


    'Public Sub show()
    '    Console.WriteLine("This is a Sub")
    'End Sub

End Class

Module Module1
    Sub Main()
        Dim S As New Student
        S.disp()
        S.disp("Hello World")
        S.disp(10, 20D)
        'S.show()
        Console.ReadKey()
    End Sub
End Module




