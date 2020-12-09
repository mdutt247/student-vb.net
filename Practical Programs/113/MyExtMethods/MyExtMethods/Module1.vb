Imports System.Runtime.CompilerServices
Module MyExtension
    <Extension()> Public Sub Display(ByVal MyString As String)
        Console.WriteLine(MyString)
    End Sub
End Module
