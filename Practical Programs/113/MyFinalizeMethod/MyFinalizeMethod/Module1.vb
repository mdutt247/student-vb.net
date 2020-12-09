Module Module1
    Public Class Hello
        Private MyName As String
        Public Sub New(ByVal Name As String)
            MyName = Name
            Console.WriteLine("Hello {0} !", Name)

        End Sub

        Protected Overrides Sub Finalize()
            Console.WriteLine("GoodBye {0} !", MyName)
            Console.ReadLine()
        End Sub

    End Class
    Sub Main()
        Dim Obj As New Hello("Sumit Saxena")

    End Sub

End Module

