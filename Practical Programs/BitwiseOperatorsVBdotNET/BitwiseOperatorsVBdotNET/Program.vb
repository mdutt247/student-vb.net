Imports System.Text

Module Program

    Sub Main()

        Console.Write("Call proper procedure/function here to see the output")

        Console.ReadKey()
    End Sub
    ''' <summary>
    ''' Calculates a Or b
    ''' </summary>
    ''' <param name="a">The first byte</param>
    ''' <param name="b">The second byte</param>
    ''' <returns>a Or b</returns>
    Private Function InclusiveORoperator(a As Byte, b As Byte) As Byte
        Return a Or b
    End Function

    ''' <summary>
    ''' Calculates a And b
    ''' </summary>
    ''' <param name="a">The first byte</param>
    ''' <param name="b">The second byte</param>
    ''' <returns>a And b</returns>
    Private Function ANDoperator(a As Byte, b As Byte) As Byte
        Return a And b
    End Function

    ''' <summary>
    ''' Calculates a Xor b
    ''' </summary>
    ''' <param name="a">The first byte</param>
    ''' <param name="b">The second byte</param>
    ''' <returns>a Xor b</returns>
    Private Function XORoperator(a As Byte, b As Byte) As Byte
        Return a Xor b
    End Function

    ''' <summary>
    ''' Calculates Not a, calculates the inverse of a
    ''' </summary>
    ''' <param name="a">The byte</param>
    ''' <returns>Not a, the inverse of a</returns>
    Private Function NOToperator(a As Byte) As Byte
        Return Not a
    End Function

    ''' <summary>
    ''' Calculates a &lt;&lt; b
    ''' </summary>
    ''' <param name="a">The first byte</param>
    ''' <param name="b">The second byte</param>
    ''' <returns>a &lt;&lt; b</returns>
    Private Function LeftShift(a As Byte, b As Byte) As Byte
        Return CByte(a << b)
    End Function

    ''' <summary>
    ''' Calculates a &gt;&gt; b
    ''' </summary>
    ''' <param name="a">The first byte</param>
    ''' <param name="b">The second byte</param>
    ''' <returns>a &gt;&gt;</returns>
    Private Function RightShift(a As Byte, b As Byte) As Byte
        Return a >> b
    End Function

    ''' <summary>
    ''' Calculates a circularleftshift n, which is equal to (a &lt;&lt; n Or a &gt;&gt; (8 - n)) where a and n are two bytes
    ''' </summary>
    ''' <param name="a">The first byte</param>
    ''' <param name="n">The second byte</param>
    ''' <returns>a circularleftshift n</returns>
    Private Function CircularLeftShift(a As Byte, n As Byte) As Byte
        Return a << n Or a >> (8 - n)
    End Function

    ''' <summary>
    ''' Calculates a circularrightshift n, which is equal to (a &gt;&gt; n Or a &lt;&lt; (8 - n)) where a and n are two bytes
    ''' </summary>
    ''' <param name="a">The first byte</param>
    ''' <param name="n">The second byte</param>
    ''' <returns>a circularrightshift n</returns>
    Private Function CircularRightShift(a As Byte, n As Byte) As Byte
        Return a >> n Or a << (8 - n)
    End Function

    ''' <summary>
    ''' Encrypts a string using XOR encryption with a string as key.
    ''' </summary>
    ''' <param name="str">The string to encrypt.</param>
    ''' <param name="k">The key</param>
    ''' <returns>The encrypted string</returns>
    Private Function XORencryptionWithStringAsKey(str As String, k As String) As String
        Dim sb As New System.Text.StringBuilder()
        For i As Integer = 0 To str.Length - 1
            sb.Append(ChrW(AscW(str(i)) Xor AscW(k(i Mod k.Length))))
        Next
        Return sb.ToString()
    End Function

    ''' <summary>
    ''' Encrypts a string using XOR encryption with a char as key.
    ''' </summary>
    ''' <param name="str">The string to encrypt.</param>
    ''' <param name="k">The key</param>
    ''' <returns>The encrypted string</returns>
    Private Function XORencryptionWithCharAsKey(str As String, k As Char) As String
        Dim sb As New StringBuilder()
        For Each c As Char In str
            sb.Append(ChrW(AscW(c) Xor AscW(k)))
        Next
        Return sb.ToString()
    End Function

    ''' <summary>
    ''' Swaps two integers using the XOR swap algorithm.
    ''' </summary>
    ''' <param name="a">The first integer</param>
    ''' <param name="b">The second integer</param>
    Private Sub XORswap(ByRef a As Integer, ByRef b As Integer)
        a = a Xor b
        b = a Xor b
        a = a Xor b
    End Sub

    ''' <summary>
    ''' Calculates pow(2, p)
    ''' </summary>
    ''' <param name="p">The exponent</param>
    ''' <returns>1 &lt;&lt;, which is equal to pow(2,p)</returns>
    Private Function PowersOfTwoUsingLeftShift(p As Integer) As Integer
        Return 1 << p
    End Function

    ''' <summary>
    ''' Calculates x / pow(2,n)
    ''' </summary>
    ''' <param name="x">The integer to divide with pow(2,n)</param>
    ''' <param name="n">The exponent</param>
    ''' <returns>x &gt;&gt; n, which is equal to x / pow(2,n)</returns>
    Private Function DivideByPowersOfTwoUsingRightShift(x As Integer, n As Integer) As Integer
        Return x >> n
    End Function

    <Flags> _
    Public Enum Priority
        None = 0
        VeryLow = 1
        Low = 2
        Medium = 4
        High = 8
        VeryHigh = 16
    End Enum

    Public Enum PriorityWithoutFlagsAttr
        None = 0
        VeryLow = 1
        Low = 2
        Medium = 4
        High = 8
        VeryHigh = 16
    End Enum

    ''' <summary>
    ''' An example with FlagsAttribute
    ''' </summary>
    Private Sub FlagsAttributeExample()
        Dim p As Priority = Priority.Medium Or Priority.High
        Console.WriteLine(p.ToString()) ' output: Medium, High
        Dim p2 As PriorityWithoutFlagsAttr = PriorityWithoutFlagsAttr.Medium Or PriorityWithoutFlagsAttr.High
        Console.WriteLine(p2.ToString()) ' output: 12
    End Sub

    'https://www.codeproject.com/Articles/544990/Understand-how-bitwise-operators-work-Csharp-and-V
End Module