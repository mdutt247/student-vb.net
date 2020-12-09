Module Module1
    Sub Main()
        Dim Name As String
        Dim Marks As Integer
        Console.Write("Enter Your Name:")
        Name = Console.ReadLine()
        Console.WriteLine("Select the Range of Marks:")
        Console.WriteLine("1.   0-20")
        Console.WriteLine("2.   21-40")
        Console.WriteLine("3.   41-60")
        Console.WriteLine("4.   61-80")
        Console.WriteLine("5.   80-100")
        Console.Write("Enter Your Choice (1,2,3,4,5):")
        Marks = Integer.Parse(Console.ReadLine())
        Select Case Marks
            Case 1
                Console.Write(Name & " your marks are very Low." & Constants.vbLf)
            Case 2
                Console.Write(Name & " your marks are Low. " & Constants.vbLf)
            Case 3
                Console.Write(Name & " your marks are Average." & Constants.vbLf)
            Case 4
                Console.Write(Name & " your marks are Good." & Constants.vbLf)
            Case 5
                Console.Write(Name & " your marks are very Good." & Constants.vbLf)
            Case Else
        End Select
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

