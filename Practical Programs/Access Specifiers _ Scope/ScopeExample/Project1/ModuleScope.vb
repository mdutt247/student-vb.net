Module ModuleScope
    Dim strMod As String = "Hurray"                                             'Module level variable
    Sub Main()
        Dim intValue As Integer = 1                                             'Procedure level variable

        If intValue = 1 Then
            Dim strText As String = "No worries. strText has block scope"       'Block level variable
            Console.WriteLine(strText)
            Console.WriteLine("We can access strMod from any where within module: " & strMod)
        End If

        Console.WriteLine("intvalue has procedure scope: " & intValue)
        Console.WriteLine("We can access strMod from any where within module: " & strMod)

        AnotherSub()

        Console.ReadKey()
    End Sub

    Sub AnotherSub()
        Console.WriteLine("Call to AnotherSub()")
        Console.WriteLine("We can access strMod from any where within module: " & strMod)
    End Sub
End Module
