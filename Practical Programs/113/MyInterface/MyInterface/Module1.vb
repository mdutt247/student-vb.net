Module Module1
    Public Interface Car
        Sub Stearing()
        Sub Wheel()
    End Interface
    Public Interface Bike
        Sub Handle()
        Sub Brake()
    End Interface
    Public Class Program
        Implements Car, Bike
        Public Sub Stearing() Implements Car.Stearing
            Console.WriteLine("Stearing of a Car")
        End Sub
        Public Sub Wheel() Implements Car.Wheel
            Console.WriteLine("Four Wheels of a Car")
        End Sub
        Public Sub Handle() Implements Bike.Handle
            Console.WriteLine("Handle of a Bike")
        End Sub
        Public Sub Brake() Implements Bike.Brake
            Console.WriteLine("Brakes of a Bike")
        End Sub
    End Class
    Sub Main()
        Dim app As Program = New Program()
        Console.WriteLine("Implementing the Car Interface")
        app.Stearing()
        app.Wheel()
        Console.WriteLine(Constants.vbLf & "Implementing the Bike Interface")
        app.Handle()
        app.Brake()
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

