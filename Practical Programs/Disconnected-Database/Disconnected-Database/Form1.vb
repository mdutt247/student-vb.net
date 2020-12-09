Imports System.Data.SqlClient
Imports System.Data

Public Class Form1

    Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Google Drive\IBSAR BCA 2012-2015\Semester - 5\Subjects\Visual Basic .NET (VB.Net)\Practical Programs\Disconnected-Database\Disconnected-Database\testDB.mdf;Integrated Security=True")
    Dim daStudent As New SqlDataAdapter("Select * from StudentTable", conn)
    Dim dsStudent As New DataSet()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdBldr As New SqlCommandBuilder(daStudent)
        daStudent.Fill(dsStudent, "StudentTable")
        dgStudent.DataSource = dsStudent
        dgStudent.DataMember = "StudentTable"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        daStudent.Update(dsStudent, "StudentTable")
    End Sub
End Class
