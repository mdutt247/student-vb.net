Class Base
    Public Overridable Function Disp() As Integer
        Console.WriteLine("This is Base Class")
        Return 0
    End Function
End Class

Class Derived
    Inherits Base
    Public Overrides Function Disp() As Integer
        Console.WriteLine("This is Derived Class")
        Return 0
    End Function
End Class

Module Module3
    Sub Main()
        Dim b As New Base
        Dim d As New Derived

        b.Disp()
        d.Disp()

        Console.ReadKey()
    End Sub
End Module

