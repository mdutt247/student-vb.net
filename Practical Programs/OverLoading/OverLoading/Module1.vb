Module Module1

    Public Class demo
        Public Sub area(ByVal r As Decimal)
            'Circle
            Dim cir As Decimal
            cir = 3.14 * r * r
            Console.WriteLine("Area of Circle:" & cir & vbLf)
        End Sub

        Public Sub area(ByVal b As Decimal, ByVal h As Decimal)
            'Triangle
            Dim tri As Decimal
            tri = 0.5 * b * h
            Console.WriteLine("Area of Triangle:" & tri)
        End Sub


    End Class


    Sub Main()

        Dim Obj As New demo

        Dim a, b, c As Decimal

        Console.WriteLine("Enter radius of Circle:")
        a = Console.ReadLine()

        Console.WriteLine("Enter base of Triangle:")
        b = Console.ReadLine()

        Console.WriteLine("Enter height of Triangle:")
        c = Console.ReadLine()

        Obj.area(a)
        Obj.area(b, c)

        Console.ReadKey()
    End Sub


End Module
