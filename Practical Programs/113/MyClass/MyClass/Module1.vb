Module Module1
   Public Class Animal
        Sub Live()
            Breathing()
        End Sub
        Sub Live2()
            MyClass.Breathing()
        End Sub
        Overridable Sub Breathing()
            Console.WriteLine("Breathing by Animal")
        End Sub
    End Class

    Public Class Fish
        Inherits Animal
        Overrides Sub Breathing()
            Console.WriteLine("Bubbling by Fish")
        End Sub
    End Class

    Sub Main()
        Dim Jaw As New Fish
        Jaw.Live()
        Jaw.Live2()
        Console.WriteLine(Constants.vbLf & "Press ENTER to quit.....")
        Console.ReadLine()
    End Sub

End Module
