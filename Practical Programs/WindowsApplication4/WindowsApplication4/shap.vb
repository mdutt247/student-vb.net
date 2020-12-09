
Public Class Shape1

    Public Overridable Function Area() As Int16
        Return 0
    End Function
End Class

Public Class Circle1
    Inherits Shape1
    Public Shadows Function Area(ByVal r As Double) As Double
        Return MyBase.Area()
    End Function
    'Public Function Area(ByVal r As Decimal) As Int16
    '    'MyBase.Area()
    '    Return 0
    'End Function
End Class

Public Class Rectangle1
    Inherits Shape1
End Class

Public Class Triangle1
    Inherits Shape1
End Class
