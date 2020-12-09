Imports System.Data.SqlClient
Imports System.Data


Public Class Form1

    Dim conn As New SqlConnection("Data Source=(localdb)\Projects;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")
    Dim daStudent As New SqlDataAdapter("Select * from mdTable", conn)
    Dim dsStudent As New DataSet()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdBldr As New SqlCommandBuilder(daStudent)
        daStudent.Fill(dsStudent, "mdTable")
        dgStudent.DataSource = dsStudent
        dgStudent.DataMember = "mdTable"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        daStudent.Update(dsStudent, "mdTable")
    End Sub
End Class
