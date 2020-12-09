Module Module1

    Sub Main()
        Dim c As Customer = New Customer()
        c.name = "Yash"
        c.custId = 1001

        Dim e As Employee = New Employee()
        e.name = "Dutt"
        e.salary = 100001

        Dim p1 As Programmer = New Programmer()
        p1.name = "md"
        p1.salary = 123456
        p1.project = "CMS"

        Dim p2 As Programmer = New Programmer()
        p2.name = "mdutt"
        p2.salary = 444565
        p2.project = "HMS"

        Dim m As Manager = New Manager()
        m.name = "maddy"
        m.salary = 44455566
        m.programmers = {p1, p2}
    End Sub

End Module

Class Person
    Public name As String
    Public address As String
    Public phone As String
End Class

Class Customer
    Inherits Person

    Public custId As Integer
End Class

Class Employee
    Inherits Person

    Public salary As Integer
End Class

Class Programmer
    Inherits Employee

    Public project As String
End Class

Class Manager
    Inherits Employee

    Public programmers() As Programmer
End Class