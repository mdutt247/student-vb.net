Module Module1

    Sub Main()

        'module2.FirstName = "madhav"
        'module2.LastName = "dutt"
        'Console.WriteLine(module2.FullName)

        Dim x As New Employee("Madhav", 456, 30000D)
        x.DisplayStats()
        x.GiveBonus(10000D)
        x.DisplayStats()

        Dim y As New Employee()
        y.DisplayStats()
        y.SetName("sadhav")
        y.SetId(415)
        y.SetCurPay(50000D)

        Console.WriteLine("id is " & y.GetId())
        y.DisplayStats()

        Console.ReadKey()
    End Sub

End Module
Module module2
    Private m_sFirstName As String
    Private m_sLastName As String
    Public Property FirstName() As String
        Get
            FirstName = m_sFirstName
        End Get
        Set(ByVal Value As String)
            m_sFirstName = Value
        End Set
    End Property
    Public Property LastName() As String
        Get
            LastName = m_sLastName
        End Get
        Set(ByVal Value As String)
            m_sLastName = Value
        End Set
    End Property
    ReadOnly Property FullName() As String
        Get
            FullName = m_sLastName & ", " & m_sFirstName
        End Get
    End Property
End Module