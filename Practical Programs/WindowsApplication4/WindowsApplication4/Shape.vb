Public Class Shape
    Dim input1 As Double
    Dim input2 As Double


    Public Overridable Function Area() As Double
        Return 1
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        If ListBox1.SelectedItem = "Circle" Then
            input1 = CDbl(InputBox("Enter radius:", "Area of Circle"))
            TextBox1.Text = Circle.Area(input1).ToString
        ElseIf ListBox1.SelectedItem = "Rectangle" Then
            input1 = CDbl(InputBox("Enter Length:", "Area of Rectangle"))
            input2 = CDbl(InputBox("Enter Breadth:", "Area of Rectangle"))
            TextBox1.Text = Rectangle.Area(input1, input2).ToString

        ElseIf ListBox1.SelectedItem = "Triangle" Then
            input1 = CDbl(InputBox("Enter Base:", "Area of Triangle"))
            input2 = CDbl(InputBox("Enter Height:", "Area of Triangle"))
            TextBox1.Text = Triangle.Area(input1, input2).ToString

        End If

    End Sub
End Class

Public Class Circle
    Inherits Shape
    Public Shadows Function Area(ByVal r As Double) As Double
        Return 3.14 * r * r
    End Function
End Class

Public Class Rectangle
    Inherits Shape
    Public Shadows Function Area(ByVal l As Double, ByVal b As Double) As Double
        Return l * b
    End Function
End Class

Public Class Triangle
    Inherits Shape
    Public Shadows Function Area(ByVal b As Double, ByVal h As Double) As Double
        Return 0.5 * b * h
    End Function
End Class
