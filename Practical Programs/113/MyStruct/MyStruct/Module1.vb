Module Module1

    Public Structure X
        Public x As Integer
        Public y As Integer
        Public z As Integer
    End Structure

    Sub Main()
        Dim x As X
        x.x = 1
        x.y = 2
        x.z = 3
        Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x.x, x.y, x.z)
        Dim x1 As X = New X()
        Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x1.x, x1.y, x1.z)
        Console.Write(Constants.vbLf & "Press Enter to quit...")
        Console.ReadLine()
    End Sub

End Module

