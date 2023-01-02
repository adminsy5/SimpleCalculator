Public Class Form1
    Dim sign As String
    Dim value1, value2 As Double
    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        ans.Text = ans.Text & 0
    End Sub

    Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
        ans.Text = ans.Text & 1
    End Sub

    Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click
        ans.Text = ans.Text & 2
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        ans.Text = ans.Text & 3
    End Sub

    Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click
        ans.Text = ans.Text & 4
    End Sub

    Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click
        ans.Text = ans.Text & 5
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        ans.Text = ans.Text & 6
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click
        ans.Text = ans.Text & 7
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        ans.Text = ans.Text & 8
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
        ans.Text = ans.Text & 9
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        value1 = ans.Text
        ans.Clear()
        ans.Focus()
        sign = "+"
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        value1 = ans.Text
        ans.Clear()
        ans.Focus()
        sign = "-"
    End Sub

    Private Sub multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click
        value1 = ans.Text
        ans.Clear()
        ans.Focus()
        sign = "x"
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        value1 = ans.Text
        ans.Clear()
        ans.Focus()
        sign = "/"
    End Sub

    Private Sub reminder_Click(sender As Object, e As EventArgs) Handles reminder.Click
        value1 = ans.Text
        ans.Clear()
        ans.Focus()
        sign = "%"
    End Sub

    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click
        value2 = ans.Text
        If sign = "+" Then
            ans.Text = value1 + value2
        ElseIf sign = "-" Then
            ans.Text = value1 - value2
        ElseIf sign = "x" Then
            ans.Text = value1 * value2
        ElseIf sign = "/" Then
            ans.Text = value1 / value2
        ElseIf sign = "%" Then
            ans.Text = value1 Mod value2
        End If

    End Sub

    Private Sub point_Click(sender As Object, e As EventArgs) Handles point.Click
        ans.Text = ans.Text & "."
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If ans.Text.Length > 0 Then
            ans.Text = ans.Text.Remove(ans.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        ans.Clear()
        ans.Focus()
    End Sub
End Class
