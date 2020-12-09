Module Module1
    Public Class Rectangle
        Implements IDisposable
        Private length, width As Integer
        Public Sub New(ByVal x As Integer, ByVal y As Integer)
            length = x
            width = y
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            Console.WriteLine("Finalizing rectangle...")
        End Sub
        Public Sub Area()
            Console.WriteLine("Area of the rectangle: {0}", length * width)
        End Sub
    End Class

    Sub Main()
        Dim rect As Rectangle = New Rectangle(10, 20)
        rect.Area()
        rect.Dispose()
        Console.ReadLine()
    End Sub

End Module

