Public Class Form1
    Public second As Integer
    Public minute As Integer
    Public hour As Integer
    Dim exeComand As Boolean
    Dim command As String

    Public Sub pass()
        hour = HourTextBox.Text
        minute = minuteTextBox.Text
        second = SecondTextBox.Text
        Timer.Start()
    End Sub

    Public Sub passDate()
        TimerDate.Start()
        TextTimer.Text = command & " programado: " & DateTimePicker1.Value
    End Sub

    Public Sub startCommand()
        If command = "Apagado" Then
            Shell("shutdown -s - t 1 -f")
        ElseIf command = "Reinicio" Then
            Shell("shutdown -r .t 1 -f")
        ElseIf command = "Hibernación" Then
            Shell("shutdown -h -f")
        ElseIf command = "Suspendido" Then
            Shell("rundll32.exe powrprof.dll, SetSuspendState 0, 1, 0")
        End If
        Me.Close()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        TextTimer.Text = command & " programado: " & Format(hour, "##00") & ":" & Format(minute, "##00") & ":" & Format(second, "##00")
        second -= 1
        If second = -1 Then
            If minute <> 0 Then
                second = 59
                minute -= 1
            End If
        End If
        If hour <> 0 And minute = 0 Then
            hour -= 1
            minute = 59
            second = 59
        End If

        If exeComand Then
            startCommand()
        End If
        If hour = 0 And minute = 0 And second = 0 Then
            exeComand = True
        End If
        If second < 0 Then
            second = 0
        End If
    End Sub

    Private Sub countDownMode_CheckedChanged(sender As Object, e As EventArgs) Handles countDownMode.CheckedChanged
        If countDownMode.Checked Then
            DateTimePicker1.Visible = False
            HourTextBox.Visible = True
            minuteTextBox.Visible = True
            SecondTextBox.Visible = True
            H.Visible = True
            M.Visible = True
            S.Visible = True
        End If
    End Sub

    Private Sub hourMode_CheckedChanged(sender As Object, e As EventArgs) Handles hourMode.CheckedChanged
        If hourMode.Checked Then
            DateTimePicker1.Visible = True
            HourTextBox.Visible = False
            minuteTextBox.Visible = False
            SecondTextBox.Visible = False
            H.Visible = False
            M.Visible = False
            S.Visible = False
            DateTimePicker1.Value = Now()
        End If
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        command = "Reinicio"
        If countDownMode.Checked Then
            pass()
        Else
            passDate()
        End If
    End Sub

    Private Sub Hibernate_Click(sender As Object, e As EventArgs) Handles Hibernate.Click
        command = "Hibernación"
        If countDownMode.Checked Then
            pass()
        Else
            passDate()
        End If
    End Sub

    Private Sub Sleep_Click(sender As Object, e As EventArgs) Handles Sleep.Click
        command = "Suspendido"
        If countDownMode.Checked Then
            pass()
        Else
            passDate()
        End If
    End Sub

    Private Sub Shutdown_Click(sender As Object, e As EventArgs) Handles Shutdown.Click
        command = "Apagado"
        If countDownMode.Checked Then
            pass()
        Else
            passDate()
        End If
    End Sub

    Private Sub TimerDate_Tick(sender As Object, e As EventArgs) Handles TimerDate.Tick
        If DateTime.Compare(Now(), DateTimePicker1.Value) >= 0 Then
            startCommand()
        End If
    End Sub

    Private Sub eatect_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles eatect.LinkClicked
        System.Diagnostics.Process.Start("https://www.eatect.com")
    End Sub
End Class
