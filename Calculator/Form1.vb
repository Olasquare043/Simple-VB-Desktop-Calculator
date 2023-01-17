Public Class Form1
    Public num1 = 0
    Public num2 = 0
    Public answer = 0
    Public SelectedOperatorID As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLb.Text = Format(Now, "Long Time")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLb.Text = Format(Now, "Long Time")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClickToDisplay(Button1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClickToDisplay(Button2)

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClickToDisplay(Button3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClickToDisplay(Button4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClickToDisplay(Button5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ClickToDisplay(Button6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ClickToDisplay(Button7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ClickToDisplay(Button8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ClickToDisplay(Button9)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ClickToDisplay(Button10)
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If CheckBox1.Checked = True Then
            If Display2Txt.Text <> "0" Then
                num1 = Val(Display2Txt.Text)
                Dim count = CountDecimal(Display2Txt.Text, ".")
                If count < 1 Then
                    Display2Txt.Text += Button12.Text
                End If
            Else
                Display2Txt.Text = "0."
            End If
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        Dim s As String = Display2Txt.Text
        If Display2Txt.Text.Length > 1 Then
            Display2Txt.Text = s.Substring(0, s.Length - 1)
        Else
            Display2Txt.Text = 0
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Display2Txt.Text = "0"
        Display2Txt.Text = "0"
        num1 = 0
        num2 = 0
        answer = 0
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Display1Txt.Text = 0
        Display2Txt.Text = 0
    End Sub
    '*******************************Operator buttons************************
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        OperatorSelected(Button14, 1)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        OperatorSelected(Button19, 2)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        OperatorSelected(Button11, 3)
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        OperatorSelected(Button13, 4)
    End Sub
    '+++++++++++++++++++++++++++++++++++End of Operators buttons+++++++++++++++++++++++++++++++++++++
    '+++++++++++++++++++++++++++++++++++Fuctions and Methods+++++++++++++++++++++++++++++++++++++
    Public Function CountDecimal(text As String, decim As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In text
            If c = decim Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
    Public Sub ClickToDisplay(ByRef Keypress As Button)
        If CheckBox1.Checked = True Then
            If Display2Txt.Text <> "0" Then
                Display2Txt.Text += Keypress.Text
            Else
                Display2Txt.Text = Keypress.Text
            End If
        End If
    End Sub
    Public Sub OperatorSelected(ByRef SelectOperator As Button, operatorID As Integer)
        If CheckBox1.Checked = True Then
            If Display2Txt.Text <> "0" Then
                If SelectedOperatorID = 0 Then
                    num1 = Val(Display2Txt.Text)
                    Display2Txt.Text += " " + SelectOperator.Text + " "
                    SelectedOperatorID = operatorID
                    Display1Txt.Text = Display2Txt.Text
                    Display2Txt.Text = "0"
                End If
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If SelectedOperatorID <> 0 And Display2Txt.Text <> 0 Then
            num2 = Val(Display2Txt.Text)
            '=======division operation=============
            If SelectedOperatorID = 1 Then
                If num2 <> 0 Then
                    Display1Txt.Text += Display2Txt.Text
                    answer = num1 / num2
                    Display2Txt.Text = answer

                Else
                    Display2Txt.Text = "Error! division by zero"
                End If
            End If
            '=======multiplication operation=============
            If SelectedOperatorID = 2 Then
                Display1Txt.Text += Display2Txt.Text
                answer = num1 * num2
                Display2Txt.Text = answer
            End If
            '=======subtraction operation=============
            If SelectedOperatorID = 3 Then
                Display1Txt.Text += Display2Txt.Text
                answer = num1 - num2
                Display2Txt.Text = answer
            End If
            '=======Addition operation=============
            If SelectedOperatorID = 4 Then
                Display1Txt.Text += Display2Txt.Text
                answer = num1 + num2
                Display2Txt.Text = answer
            End If
            SelectedOperatorID = 0
        End If
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        Form2.Show()
    End Sub
End Class
