Module BlockScope
    Sub Main()
        Dim intValue As Integer = 1

        If intValue = 1 Then
            Dim strText As String = "No worries. strText has block scope"       'Block level variable
            Console.WriteLine(strText)
        End If
        'Console.WriteLine(strText)          'Will not work as the scope of variable strText is limited to its block

        Console.ReadKey()
    End Sub
End Module
