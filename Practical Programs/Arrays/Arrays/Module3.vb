Module Module3

    Sub Main()

        Dim a(3) As Integer

        Console.WriteLine("Length: " & a.Length) '4
        Console.WriteLine("Get Length: " & a.GetLength(0)) '4

        Console.WriteLine("UBound: " & UBound(a, 1)) '3
        Console.WriteLine("LBound: " & LBound(a, 1)) '0

        Console.WriteLine("Get Upper Bound: " & a.GetUpperBound(0)) '3
        Console.WriteLine("Get Lower Bound: " & a.GetLowerBound(0)) '0

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Dim b(3, 2) As Integer

        Console.WriteLine("Length: " & b.Length) '4

        Console.WriteLine("Get Length(0): " & b.GetLength(0)) '4
        Console.WriteLine("Get Length(1): " & b.GetLength(1)) '4

        Console.WriteLine("UBound(1): " & UBound(b, 1)) '3
        Console.WriteLine("LBound(1): " & LBound(b, 1)) '0

        Console.WriteLine("UBound(2): " & UBound(b, 2)) '3
        Console.WriteLine("LBound(2): " & LBound(b, 2)) '0

        Console.WriteLine("Get Upper Bound(0): " & b.GetUpperBound(0)) '3
        Console.WriteLine("Get Lower Bound(0): " & b.GetLowerBound(0)) '0

        Console.WriteLine("Get Upper Bound(1): " & b.GetUpperBound(1)) '3
        Console.WriteLine("Get Lower Bound(1): " & b.GetLowerBound(1)) '0

        Console.ReadKey()
    End Sub




End Module
