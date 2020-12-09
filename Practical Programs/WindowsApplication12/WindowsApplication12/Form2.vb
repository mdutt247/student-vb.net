Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader

Public Class Form2
    'Dim conStr As String = "Data Source=(localdb)\Projects;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"


    Dim conStr As String = "Data Source=(localdb)\Projects;Initial Catalog=testDB;Integrated Security=True"
    Dim con As New SqlConnection(conStr)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dsTab As New DataSet()
        Dim daTab As New SqlDataAdapter("Select * from mdTable", con)
        daTab.Fill(dsTab, "mdTable")
        DataGridView1.DataSource = dsTab
        DataGridView1.DataMember = "mdTable"
        daTab.Update(dsTab, "mdTable")
    End Sub
End Class