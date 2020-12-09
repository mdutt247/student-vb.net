Module Module1
    Public Class Shape
        Public Sub Area(ByVal Side As Integer)
            Dim SquareArea As Integer = Side * Side
            Console.WriteLine("The Area of Square is: " & SquareArea)
        End Sub

        Public Sub Area(ByVal Length As Integer, ByVal Bredth As Integer)
            Dim RectangleArea As Integer = Length * Bredth
            Console.WriteLine("The Area of Rectangle is: " & RectangleArea)

        End Sub
        Public Sub Area(ByVal Radius As Double)
            Dim CircleArea As Double = 3.14 * Radius * Radius
            Console.WriteLine("The Area of Circle is: " & CircleArea)
        End Sub
        Public Function Area(ByVal Base As Double, ByVal Height As Double) As Double
            Dim TriangleArea As Double = (Base * Height) / 2
            Console.WriteLine("The Area of Triangle is: " & TriangleArea)
            Return TriangleArea
        End Function
    End Class
    Sub Main()
        Dim shape As Shape = New Shape()
        shape.Area(15)
        shape.Area(10, 20)
        shape.Area(10.5)
        shape.Area(15.5, 20.4)
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub

End Module

