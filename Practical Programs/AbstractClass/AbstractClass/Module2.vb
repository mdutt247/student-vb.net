
'Abstract class with abstract and non-abstract method

Module Module2
    'abstract class
    Public MustInherit Class shape
        Public Sub Area(ByRef length As Integer, ByVal breadth As Integer) 'non abstract method
            Console.WriteLine("Area: " & 1 / 2 * length * breadth)
        End Sub
        Public MustOverride Sub Add(ByVal a As Integer, ByVal b As Integer) 'abstract method

    End Class
    Class Triangle
        Inherits shape
        Public Overrides Sub Add(ByVal a As Integer, ByVal b As Integer)
            Console.WriteLine("Sum: " & a + b)
        End Sub
    End Class
    Sub Main()
        Dim obj As New Triangle
        obj.Area(10, 8)
        obj.Add(88, 4)
        Console.Read()
    End Sub



End Module
