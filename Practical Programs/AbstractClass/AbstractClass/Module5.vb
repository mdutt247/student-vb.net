
'Abstract class implimenting interface

Module Module5
    'interface
    Public Interface mymath
        Sub Add(ByVal a As Integer, ByVal b As Integer)
        Sub Subtract(ByVal a As Integer, ByVal b As Integer)
    End Interface

    'abstract class which implements an interface
    MustInherit Class mClass
        Implements mymath
        MustOverride Sub Divide(ByVal a As Integer, ByVal b As Integer) 'abstract method

        Public Sub Add(ByVal a As Integer, ByVal b As Integer) Implements mymath.Add 'implimenting method of interface
            Console.WriteLine("Sum: " & a + b)
        End Sub

        Public Sub Subtract(ByVal a As Integer, ByVal b As Integer) Implements mymath.Subtract 'implimenting method of interface
            Console.WriteLine("Subtract: " & a - b)
        End Sub
    End Class

    Class useClass
        Inherits mClass
        Public Overrides Sub Divide(ByVal a As Integer, ByVal b As Integer) 'implimenting method of abstract class
            Console.WriteLine("Division: " & a / b)
        End Sub
    End Class
    Sub Main()
        Dim a As useClass = New useClass()
        a.Subtract(20, 5)
        a.Add(20, 8)
        a.Divide(62, 8)

        Console.ReadKey()
    End Sub
End Module
