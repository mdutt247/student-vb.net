
'Abstract class inheriting non-abstract class

Module Module4
    'Non-abstract class
    Public Class STUDENT
        Protected rollno As Integer
        Protected name As String
        Protected fee As Integer
        Sub New()
            rollno = 1
            name = "rishabh"
            fee = 100000
        End Sub
        Sub Display()
            Console.WriteLine("Roll No.:" & rollno & " Name:" & name)
        End Sub
    End Class

    'Abstract class
    MustInherit Class college
        Inherits STUDENT
        MustOverride Sub Showfees()
    End Class

    Class ibsar
        Inherits college

        Public Overrides Sub Showfees()
            Console.WriteLine("Fee: " & fee)
        End Sub
    End Class

    Sub Main()
        Dim i As ibsar = New ibsar()
        i.Showfees()
        i.Display()
        Console.ReadKey()
    End Sub
End Module
