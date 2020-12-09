Public Class Employee
    ' Field data.
    Private empName As String
    Private empID As Integer
    Private currPay As Double
    ' Constructors
    Public Sub New()

    End Sub
    Public Sub New(ByVal name As String, ByVal id As Integer, ByVal pay As Double)
        empName = name
        empID = id
        currPay = pay
    End Sub
    ' Members
    Public Sub GiveBonus(ByVal amount As Double)
        currPay += amount
    End Sub
    Public Function GetCurPay() As Decimal
        Return currPay
    End Function
    Public Sub SetCurPay(ByVal pay As Decimal)
        currPay = pay
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
    Public Sub SetId(ByVal id As Integer)
        empID = id
    End Sub
    Public Sub DisplayStats()
        Console.WriteLine("Name: {0}", empName)
        Console.WriteLine("ID: {0}", empID)
        Console.WriteLine("Pay: {0}", currPay)
    End Sub
End Class
