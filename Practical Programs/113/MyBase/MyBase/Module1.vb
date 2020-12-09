Module Module1
    Public Class MyBaseClass
        Public Overridable Sub Shape()
            Console.WriteLine("I am a Circle")
        End Sub
    End Class
    Class MyDerivedClass
        Inherits MyBaseClass
        Public Overrides Sub Shape()
            Console.WriteLine("I am a Square")
        End Sub
        Public Sub MyBaseClassMethod()
            MyBase.Shape()
        End Sub
    End Class
    Sub Main()
        Dim DerivedClass As New MyDerivedClass
        DerivedClass.Shape()
        DerivedClass.MyBaseClassMethod()
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

