
'Abstract class with non-abstract method

Module Module1
    'abstract class
    Public MustInherit Class shape
        Public Sub Area(ByRef length As Integer, ByVal breadth As Integer) 'non abstract method
            Console.WriteLine("Area: " & 1 / 2 * length * breadth)
        End Sub
    End Class
    Class Triangle
        Inherits shape

    End Class
    Sub Main()
        Dim obj As New Triangle
        obj.Area(10, 8)
        Console.ReadKey()
    End Sub

End Module
