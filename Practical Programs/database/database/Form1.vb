Imports System.Data.OleDb
'Imports System.Console


Public Class Form1
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim icount As Integer
    Dim str As String
    Public head As New System.Data.DataTable
    Public No As Integer = 0
    Public headadaptor As New OleDbDataAdapter
    Public headcommand As New OleDbCommandBuilder

    Sub showRecords()
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.accdb;Persist Security Info=False;")
        cn.Open()
        cmd = New OleDbCommand("select * from student", cn)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox1.Text = dr(0)
            TextBox2.Text = dr(1)
            TextBox3.Text = dr(2)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Sub initial()
        headadaptor = New OleDbDataAdapter("select * from student", cn)
        headcommand = New OleDbCommandBuilder(headadaptor)
        headadaptor.Fill(head)
        display()
    End Sub

    Sub display()
        If (No <= head.Rows.Count - 1) Then
            TextBox1.Text = head.Rows(No)("ID").ToString
            TextBox2.Text = head.Rows(No)("Name1").ToString
            TextBox3.Text = head.Rows(No)("Phone").ToString
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.accdb;Persist Security Info=False;")
        cn.Open()
        str = "insert into student values(" & CInt(TextBox1.Text) & ",'" & TextBox2.Text & "','" & _TextBox3.Text & "')"
        cmd = New OleDbCommand(str, cn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Inserted!...")
        cn.Close()
        initial()
        showRecords()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.accdb;Persist Security Info=False;")
        cn.Open()
        str = "update student set name1='" & TextBox2.Text & "',phone='" & TextBox3.Text & "'  where ID = " & TextBox1.Text
        cmd = New OleDbCommand(str, cn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Updated!...")
        initial()
        showRecords()
        cn.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.accdb;Persist Security Info=False;")
        cn.Open()
        initial()
        str = "delete from student where id=" & TextBox1.Text
        cmd = New OleDbCommand(str, cn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Deleted!...")
        head = New DataTable
        headadaptor.Fill(head)
        No = No - 1
        showRecords()
        initial()
        cn.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        No = 0
        display()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Database application"
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.accdb;Persist Security Info=False;")
        cn.Open()
        initial()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If (No = head.Rows.Count - 1) Then
            MsgBox("this is last")
        Else
            No = No + 1
            display()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        No = head.Rows.Count - 1
        display()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If (No = 0) Then
            MsgBox("this is first")
        Else
            No = No - 1
            display()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
