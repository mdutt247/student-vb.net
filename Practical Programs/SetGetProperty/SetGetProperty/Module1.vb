Module Module1

    Class GetSet

        Dim SN As String
        Dim SR As Integer

        Public Property StdRoll() As Integer

            Get
                Return SR
            End Get

            Set(ByVal roll As Integer)
                SR = roll
            End Set

        End Property

        Public Property StdName() As String

            Get
                Return SN
            End Get

            Set(ByVal name As String)
                SN = name
            End Set

        End Property

    End Class


    Sub Main()
        Dim s As New GetSet
        s.StdName = "Venk"
        s.StdRoll = 7

        Console.WriteLine(s.StdName)
        Console.WriteLine(s.StdRoll)

        Console.ReadKey()
    End Sub

End Module
