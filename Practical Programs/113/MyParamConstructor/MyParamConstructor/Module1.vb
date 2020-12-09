Module Module1
    Public Class MySampleClass

        Public Sub New() 'Constructor without Parameter

        End Sub
        Public Sub New(ByVal Name As String) 'Constructor with One Parameter
            Console.WriteLine("Name is:" & Name)
            Console.WriteLine("--------------")
        End Sub
        Public Sub New(ByVal Name As String, ByVal Age As Integer) 'Constructor with two Parameters()
            Console.WriteLine("Name is:" & Name)
            Console.WriteLine("Age is:" & Age)
        End Sub
    End Class
    Sub Main()
        Dim Obj1 As MySampleClass = New MySampleClass() 'No Parameter
        Dim Obj2 As MySampleClass = New MySampleClass("Martin") ' One Parameter
        Dim Obj3 As MySampleClass = New MySampleClass("Martin", 26) 'Two Parameters
        Console.Write(Constants.vbLf & "Press ENTER to Quit..")
        Console.ReadLine()
    End Sub

End Module

