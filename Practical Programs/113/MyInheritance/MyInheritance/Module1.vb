Module Module1
    Public Class BaseClass
        Public DataMember As Integer
        Public Sub BaseClassMethod()
            Console.WriteLine("I am a Base Class Method()")
        End Sub
    End Class
    Public Class DerivedClass
        Inherits BaseClass
        Public Sub DerivedClassMethod()
            Console.WriteLine("I am a Derived Class Method()")
        End Sub
    End Class
    Sub Main()
        ' Create a Base Class Object
        Console.WriteLine("I am accessing Base Class Object:")
        Dim bc As BaseClass = New BaseClass()
        bc.DataMember = 1
        bc.BaseClassMethod()
        ' Create a Derived Class Object
        Console.WriteLine("")
        Console.WriteLine("I am accessing Derived Class Object:")
        Dim dc As DerivedClass = New DerivedClass()
        dc.DataMember = 2
        dc.BaseClassMethod()
        dc.DerivedClassMethod()
        Console.Write(Constants.vbLf & "Press ENTER to quit..")
        Console.ReadLine()
    End Sub

End Module

