'Add reference to assembly named MyAssembly and import it
Imports MyAssembly

Module Module1

    Sub Main()
        Dim x As New MathClass()

        x.publicVar = 1

        Console.WriteLine(x.myAdd(2, 3))

        Console.WriteLine(x.mySub(55, 3))

        Console.WriteLine(x.myDiv(8, 3))

        Console.WriteLine(x.myMul(2, 3))

        Console.ReadKey()
    End Sub

End Module
