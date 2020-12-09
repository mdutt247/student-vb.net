Module ProcedureScope
    Sub Main()
        Dim intValue As Integer = 1                         'Procedure level variable

        If intValue = 1 Then
            Dim strText As String = "No worries. strText has block scope"
            Console.WriteLine(strText)
        End If

        Console.WriteLine("intvalue has procedure scope: " & intValue)

        Console.ReadKey()
    End Sub
End Module
