Imports System.Runtime.InteopServises
Public Class Form1
    Dim A As String
    Dim B As String
    Dim op = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        TextBox1.Text = A + "" + op + "" + B

    End Sub
    Private Sub TextBox1_TextChanged(sendder As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"
        End If
        TextBox1.Text = A + "" + op + "" + B
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        TextBox1.Text = A + "" + op + "" + B
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        TextBox1.Text = A + "" + op + "" + B
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        TextBox1.Text = A + "" + op + "" + B
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
        TextBox1.Text = A + "" + op + "" + B
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        TextBox1.Text = A + "" + op + "" + B
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        TextBox1.Text = A + "" + op + "" + B
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        TextBox1.Text = A + "" + op + "" + B
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        TextBox1.Text = A + "" + op + "" + B
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Not A + "" Then
            op = "+"
        End If
        TextBox1.Text = A + op + B

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Not A + "" Then
            op = "-"
        End If
        TextBox1.Text = A + op + B
    End Sub



    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Not A + "" Then
            op = "*"
        End If
        TextBox1.Text = A + op + B
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Not A + "" Then
            op = "/"
        End If
        TextBox1.Text = A + op + B
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = ""
        A = ""
        B = ""
        op = ""

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim test = True
        Dim reset As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)

            If op = "+" Then
                reset = va + vb
            ElseIf op = "-" Then
                reset = va - vb
            ElseIf op = "*" Then
                reset = va * vb
            ElseIf op = "/" And Not op = "" Then
                reset = va / vb
            Else
                MessageBox.Show("A et B doivent etre des entiers")
                test = False

            End If
            If test Then
                TextBox1.Text = TextBox1.Text + "=" + reset.ToString
            End If

        End If
    End Sub


End Class
