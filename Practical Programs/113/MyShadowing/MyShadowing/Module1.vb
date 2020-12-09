Module Module1
    Public Class MyFirstClass
        Public Sub Show()
            Console.WriteLine("This is my First Class")
        End Sub
    End Class
    Public Class MySecondClass
        Inherits MyFirstClass
        Private Shadows Sub Show()
            Console.WriteLine("This is my Second Class")
        End Sub
    End Class
    Public Class MyThirdClass
        Inherits MySecondClass
        Public Shadows Sub Show()
            Console.WriteLine("This is my Third Class")
        End Sub
    End Class

    Sub Main()
        Dim First As New MyFirstClass
        Dim Second As New MySecondClass
        Dim Third As New MyThirdClass
        ' The following statement displays "This is my First Class".
        First.Show()
        ' The following statement displays "This is my First Class".
        Second.Show()
        ' The following statement displays "This is my Third Class".
        Third.Show()
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

