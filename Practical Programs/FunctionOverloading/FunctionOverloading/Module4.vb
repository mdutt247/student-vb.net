'Write a program showing multiple inheritance. Take a class Clerk that inherits from a class and an interface (Person & Employee).
'Write your implementation. Show method overriding.

Interface Employee
    Function show() As Integer

    Structure test
        Dim a As Integer
    End Structure

End Interface

Class Person

    Dim name As String
    Dim age As Integer
    Dim sal As Decimal

    Overridable Function disp() As Integer
        Console.WriteLine("I am Class Person - Func Disp")
        Return 0
    End Function
End Class

Class Clerk
    Inherits Person
    Implements Employee

    Public Function show() As Integer Implements Employee.show
        Console.WriteLine("I am Class Clerk - Implemented Func Show from Implemented Interface Employee")
        Return 0
    End Function

    Public Overrides Function disp() As Integer
        Console.WriteLine("I am Class Clerk - Overrided Func Disp from Inherited Class Person ")
        Return 0
    End Function
End Class

Module Module4
    Sub Main()

        Dim A As New Person
        Dim B As New Clerk

        A.disp()

        B.show()
        B.disp()

        Console.ReadKey()

    End Sub
End Module