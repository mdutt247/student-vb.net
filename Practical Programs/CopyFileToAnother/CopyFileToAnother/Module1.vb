Imports System.IO

Module Module1

    Sub Main()

        'Dim s(1000) As String
        'Dim i As Integer = 0

        'Dim fsr As New FileStream("Test.txt", FileMode.OpenOrCreate, FileAccess.Read)

        'Using reader As New StreamReader(fsr)
        '    While reader.Peek <> -1
        '        s(i) = reader.ReadLine
        '        i = i + 1
        '    End While
        'End Using

      
        'i = 0

        'Dim fsw As New FileStream("NewTest.txt", FileMode.Create, FileAccess.Write)

        'Using writer As New StreamWriter(fsw)
        '    'While i < s.Length
        '    '    writer.WriteLine(s(i))
        '    '    i = i + 1
        '    'End While
        'End Using

        Dim fsr As New FileStream("Shilpa.txt", FileMode.OpenOrCreate, FileAccess.Read)
        Dim fsw As New FileStream("Venkzzzzz.txt", FileMode.OpenOrCreate, FileAccess.Write)

        Using reader As New StreamReader(fsr)
            Using writer As New StreamWriter(fsw)
                While reader.Peek <> -1
                    writer.WriteLine(reader.ReadLine)
                End While
            End Using
        End Using




        Console.WriteLine("File created successfully")
        Console.ReadKey()

    End Sub

End Module
