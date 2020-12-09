
'Abstract class with partial implimentation

Module Module3
    'abstract class
    Public MustInherit Class One

        Public MustOverride Sub Add(ByVal a As Integer, ByVal b As Integer) 'abstract method
        Public MustOverride Sub Subtract(ByVal a As Integer, ByVal b As Integer) 'abstract method

    End Class

    'partial abstract class
    Public MustInherit Class Two
        Inherits One
        Public Overrides Sub Add(ByVal a As Integer, ByVal b As Integer) 'implimenting abstract method
            Console.WriteLine("Sum: " & a + b)
        End Sub
    End Class

    Public Class Three
        Inherits Two
        Public Overrides Sub Subtract(ByVal a As Integer, ByVal b As Integer) 'implimenting abstract method
            Console.WriteLine("Difference: " & a - b)
        End Sub
    End Class
    Sub Main()
        Dim a As Three = New Three
        a.Add(10, 20)
        a.Subtract(20, 10)

        Console.ReadKey()
    End Sub
End Module
