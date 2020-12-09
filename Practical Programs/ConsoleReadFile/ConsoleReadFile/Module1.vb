Imports System.IO

Module Module1

    Sub Main()

        Dim fs As New FileStream("Test.txt", FileMode.OpenOrCreate, FileAccess.Read)

        Using reader As New StreamReader(fs)
            While reader.Peek <> -1
                Console.WriteLine(reader.ReadLine)
            End While
        End Using

        Console.ReadKey()

    End Sub

End Module
