Public Class Employee
    Private empName As String
    Private empID As Integer
    Private curPay As Double

    Public Sub New()

    End Sub

    Public Sub New(ByVal name As String, ByVal id As Integer, ByVal pay As Double)
        empName = name
        empID = id
        curPay = pay
    End Sub

    Public Sub GiveBonus(ByVal amount As Double)
        curPay += amount
    End Sub

    Public Function GetCurPay() As Double
        Return curPay
    End Function

    Public Sub SetCurPay(ByVal pay As Decimal)
        curPay = pay
    End Sub

    Public Function GetName() As String
        Return empName
    End Function

    Public Sub SetName(ByVal name As String)
        empName = name
    End Sub

    Public Function GetId() As Integer
        Return empID
    End Function

    Public Sub SetID(ByVal id As Integer)
        empID = id
    End Sub

    Public Sub DisplayStats()
        Console.WriteLine("Name:{0}", empName)
        Console.WriteLine("ID:{0}", empID)
        Console.WriteLine("Pay:{0}", curPay)

    End Sub

End Class

Module Module3

    Sub Main()

        Dim x As New Employee("Madhav", 456, 30000D)
        x.DisplayStats()
        x.GiveBonus()
        x.DisplayStats()
        x.SetName()
    End Sub

End Module

