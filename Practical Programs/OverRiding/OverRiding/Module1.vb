Module Module1

    Public Class A

        Public Overridable Sub show()
            Console.WriteLine("I am from Class A")
        End Sub

    End Class

    Public Class B
        Inherits A

        Public Overrides Sub show()
            'MyBase.show()
            Console.WriteLine("I am from Class B")
        End Sub
    End Class

    Sub Main()

        Dim obA As New A
        Dim obB As New B

        obA.show()
        obB.show()

        Console.ReadKey()
    End Sub

End Module
