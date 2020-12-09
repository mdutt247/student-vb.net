Module Module1
    Public Class Person
        Private fAge As Integer

        Public Sub New()
            fAge = 21
        End Sub
        Public Overridable Sub setAge(ByVal age As Integer)
            fAge = age
        End Sub
        Public Overridable Function getAge() As Integer
            Return fAge
        End Function
    End Class

    Public Class AdultPerson
        Inherits Person
        Public Sub New()
        End Sub
        Public Overrides Sub setAge(ByVal age As Integer)
            If age > 21 Then
                MyBase.setAge(age)
            End If
        End Sub
    End Class
    Sub Main()
        Dim p As Person = New Person()
        p.setAge(18)
        Dim ap As AdultPerson = New AdultPerson()
        ap.setAge(18)
        Console.WriteLine("Person Age: {0}", p.getAge())
        Console.WriteLine("AdultPerson Age: {0}", ap.getAge())
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub

End Module

