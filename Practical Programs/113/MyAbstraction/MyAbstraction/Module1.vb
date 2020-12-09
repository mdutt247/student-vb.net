Module Module1
    Public MustInherit Class Shape
        Public Number As Double = 15
        Public MustOverride Function Area() As Double
    End Class
    Public Class Circle
        Inherits Shape
        Public Overrides Function Area() As Double
            Console.Write("The Area of Circle is:")
            Console.WriteLine(3.14 * Number * Number)
        End Function
    End Class
    Public Class Square
        Inherits Shape
        Public Overrides Function Area() As Double
            Console.Write("The Area of Square is:")
            Console.WriteLine(Number * Number)
        End Function
    End Class
    Sub Main()
        Dim Shape1, Shape2 As Shape
        Shape1 = New Circle
        Shape2 = New Square
        Shape1.Area()
        Shape2.Area()
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

