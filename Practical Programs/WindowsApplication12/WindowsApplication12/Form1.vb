Imports System.Data
Imports System.Data.SqlClient

'Imports System.Data.SqlClient.SqlDataReader


Public Class Form1

    Dim con As New SqlConnection("Data Source=(localdb)\Projects;Initial Catalog=Test1;Integrated Security=True")

    Dim rdr As SqlDataReader


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmd2 As New SqlCommand("Select * from Timepass", con)
        rdr = cmd2.ExecuteReader()
        While (rdr.Read())
            ListBox2.Items.Add(rdr(0) & "  " & rdr(1) & "  " & rdr(2) & "  " & rdr(3))
            ListBox3.Items.Add(rdr(0))
        End While

        rdr.Close()
        con.Close()

      

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.TextLength = 0 And TextBox2.TextLength = 0 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Fill the Criteria")
            MsgBox("Harami kuch toh likh!!!")

        ElseIf TextBox2.Text = "" Then

            ListBox1.Items.Clear()

            con.Open()

            Dim cmd As New SqlCommand("Select * from Timepass where Name='" + TextBox1.Text + "'", con)

            rdr = cmd.ExecuteReader()

            While (rdr.Read())
                ListBox1.Items.Add(rdr(0) & "  " & rdr(1) & "  " & rdr(2) & "  " & rdr(3))
            End While

            rdr.Close()

            con.Close()

        ElseIf TextBox1.Text = "" Then

            ListBox1.Items.Clear()

            con.Open()

            Dim cmd As New SqlCommand("Select * from Timepass where Address='" + TextBox2.Text + "'", con)

            rdr = cmd.ExecuteReader()

            While (rdr.Read())
                ListBox1.Items.Add(rdr(0) & "  " & rdr(1) & "  " & rdr(2) & "  " & rdr(3))
            End While

            rdr.Close()

            con.Close()

        ElseIf TextBox1.TextLength >= 1 And TextBox2.TextLength >= 1 Then

            ListBox1.Items.Clear()

            con.Open()

            Dim cmd As New SqlCommand("Select * from Timepass where Name='" + TextBox1.Text + "' AND Address='" + TextBox2.Text + "'", con)

            rdr = cmd.ExecuteReader()

            While (rdr.Read())
                ListBox1.Items.Add(rdr(0) & "  " & rdr(1) & "  " & rdr(2) & "  " & rdr(3))
            End While

            rdr.Close()

            con.Close()


        End If









    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer = 0

        For Each i As String In ListBox3.Items

            If TextBox3.Text = i Then
                a = 1
            End If

        Next

        If a = 0 Then
            con.Open()
            Dim cmd As New SqlCommand("insert into Timepass (Id,Name,Mobile,Address) values (" + TextBox3.Text + ",'" + TextBox4.Text + "'," + TextBox5.Text + ",'" + TextBox6.Text + "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Inserted")
            con.Close()

            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()

        Else
            MsgBox("ID Exists")
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
        End If



    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

      
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub

    Private Sub ViewDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDataToolStripMenuItem.Click
        GroupBox1.Visible = True
        'GroupBox2.Visible = False

    End Sub

    Private Sub ManipulateDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManipulateDataToolStripMenuItem.Click

    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        Dim listlength As Integer = ListBox3.Items.Count
        TextBox3.Text = (listlength + 1).ToString()

        GroupBox2.Visible = True

        Button2.Visible = True
        Button3.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        GroupBox2.Visible = True

        Button2.Visible = False
        Button3.Visible = True
        Button4.Visible = False
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        TextBox3.Text = ""
        GroupBox2.Visible = True

        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = True

        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
       
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""


        con.Open()
        Dim cmd As New SqlCommand("Select * from Timepass where Id='" & TextBox3.Text & "'", con)

        rdr = cmd.ExecuteReader()
        While (rdr.Read)
            TextBox4.Text = rdr(1)
            TextBox5.Text = rdr(2)
            TextBox6.Text = rdr(3)
        End While

        rdr.Close()

        con.Close()
    End Sub
End Class
