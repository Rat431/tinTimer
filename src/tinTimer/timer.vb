'   Copyright(c) 2023 Rat431 (https://github.com/Rat431).
'   This software Is under the MIT license, For more informations check the LICENSE file.

Public Class timerForm
    'global vars
    Dim Counter As DateTime = New DateTime()
    Const Digit As String = "00 : 00.00"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'check timer state
        If Not Timer1.Enabled Then
            Timer1.Start()
            Button1.Text = "Pause"
        Else
            Timer1.Stop()
            Button1.Text = "Resume"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'increment the elapsed time by 10 ms
        Counter = Counter.AddMilliseconds(Timer1.Interval)
        Label1.Text = Counter.ToString("mm : ss\.ff")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'timer arrest and reset
        Timer1.Stop()
        Counter = New DateTime()

        Label1.Text = Digit
        Button1.Text = "Start"
    End Sub
End Class
