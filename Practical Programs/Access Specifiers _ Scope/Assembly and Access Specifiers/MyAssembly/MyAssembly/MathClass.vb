'Choose application type as class library
Public Class MathClass
    Public publicVar As Int16
    Private privateVar As Int16
    Protected protectedVar As Int16
    Friend friendVar As Int16
    Protected Friend protectedFriendVar As Int16

    Public Function myAdd(ByVal a As Int16, ByVal b As Int16) As Int16
        Return a + b
    End Function

    Public Function myDiv(ByVal a As Int16, ByVal b As Int16) As Int16
        Return a \ b
    End Function

    Public Function myMul(ByVal a As Int16, ByVal b As Int16) As Int16
        Return a * b
    End Function

    Public Function mySub(ByVal a As Int16, ByVal b As Int16) As Int16
        Return a - b
    End Function
End Class