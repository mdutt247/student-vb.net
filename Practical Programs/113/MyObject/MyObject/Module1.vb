Module Module1
    Public Class Amount
        Private TotalAmount As Double = 12000, Deductions As Double = 2000, BalanceAmount As Double
        Public Sub Balance()

            BalanceAmount = TotalAmount - Deductions
            Console.WriteLine("Your Current Amount is Rs: " & BalanceAmount)

        End Sub
        Public Sub Debit()
            Dim DebitAmount As Integer = 0
            Console.Write("Enter Amount:")
            DebitAmount = Integer.Parse(Console.ReadLine())
            BalanceAmount = BalanceAmount - DebitAmount
            Console.WriteLine("Your Balance Amount is Rs.:" & BalanceAmount)
        End Sub
        Public Sub Credit()
            Dim CreditAmount As Integer = 0
            Console.Write("Enter Amount:")
            CreditAmount = Integer.Parse(Console.ReadLine())
            BalanceAmount = BalanceAmount + CreditAmount
            Console.WriteLine("Your Balance Amount is Rs.:" & BalanceAmount)
        End Sub
        Public Sub GetData()
            Dim Data As Char
            Console.WriteLine("---------------------------------")
            Console.Write("Press (d) for Debit and (c) for Credit:")
            Data = Char.Parse(Console.ReadLine())
            If Data = "d" Then
                Debit()
            End If
            If Data = "c" Then
                Credit()
            End If
        End Sub
    End Class
    Sub Main()
        Dim Amt As Amount = New Amount()
        Amt.Balance()
        Amt.GetData()
        Console.Write(Constants.vbLf & "Press ENTER to Quit..")
        Console.ReadLine()
    End Sub

End Module

