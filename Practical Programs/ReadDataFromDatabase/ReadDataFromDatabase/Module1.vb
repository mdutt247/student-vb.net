Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Sub Main()
        Dim conString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\BasicDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        Dim con As SqlConnection = New SqlConnection(conString)
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                Console.WriteLine("Connection opend......")
            End If
            Dim qry As String = "Select * from tblStudent"
            Dim cmd As New SqlCommand(qry, con)
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Console.WriteLine("Name" & vbTab & "Phone" & vbCrLf & "======================")
            While rdr.Read()
                Console.WriteLine(rdr("stuName").ToString & vbTab & rdr("stuPhone").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            If con.State = ConnectionState.Closed Then
                Console.WriteLine("Connection closed......")
            End If
        End Try
        Console.ReadKey()
    End Sub
End Module
