Module Module1

    Class Car
        Public Overridable Sub Wheel()
            Console.WriteLine("Wheels of a Car")
        End Sub

        Public Overridable Sub Brake()
            Console.WriteLine("Brakes of a Car")
        End Sub
    End Class

    Class Bike
        Inherits Car

        Public NotOverridable Overrides Sub Wheel()
            Console.WriteLine("Wheels of a Bike")
        End Sub

        Public Overrides Sub Brake()
            Console.WriteLine("Brakes of a Bike")
        End Sub
    End Class

    NotInheritable Class Scooter
        Inherits Bike

        Public Overrides Sub Brake()
            Console.WriteLine("Brakes of a Scooter")
        End Sub
    End Class
    Sub main()
        Dim c = New Car
        Dim b = New Bike
        Dim s = New Scooter
        Console.WriteLine("(Car Class)")
        c.Wheel()
        c.Brake()
        Console.WriteLine(Constants.vbLf & "(Bike Class)")
        b.Wheel()
        b.Brake()
        Console.WriteLine(Constants.vbLf & "(Scooter Class)")
        s.Brake()
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

