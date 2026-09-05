Public Class Mainfrm
    Public Shared CurrentTime As DateTime = TimeOfDay.ToLongTimeString
    Public Shared SleepingTime As DateTime
    Public Shared finalcancel As Integer = False
    Public Shared shutdownchk As Integer = False

    Private Sub Startbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Startbut.Click
        On Error Resume Next
        ShutdownTimetxt.Text = CurrentTime.AddMinutes(Val(SleepTimecombo.Text)).ToLongTimeString

        'alert button text to change commands

        If Startbut.Text = "Start Timer" Then
            If CurrentTime >= Convert.ToDateTime(ShutdownTimetxt.Text).ToLongTimeString Then
                MsgBox("Your sleep timer is dated to the past. Update to a time in the future.", MsgBoxStyle.Critical, "WAIT!")
                Exit Sub
            End If
            Startbut.Text = "Stop Timer"
            Do Until TimeOfDay.Ticks = 0 And Startbut.Text <> "Start Timer"

                Application.DoEvents()
                CurrTimetxt.Text = TimeOfDay.ToLongTimeString
                CurrentTime = TimeOfDay.ToLongTimeString
                If CurrentTime = Convert.ToDateTime(ShutdownTimetxt.Text).ToLongTimeString Then

                    Shutdownfrm.Cancelbutcancel = False
                    Shutdownfrm.ShowDialog()
                    Shutdownfrm.TopMost = True
                    Exit Do
                End If

            Loop
        ElseIf Startbut.Text = "Stop Timer" Then
        Startbut.Text = "Start Timer"
        End If



    End Sub

    Private Sub Mainfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim TimeArr = New Integer() {15, 30, 60, 75, 90}
        Dim c As Integer

        Do Until c = TimeArr.Count - 1
            SleepTimecombo.Items.Add(TimeArr(c))
            c = c + 1
        Loop
        SleepTimecombo.Text = SleepTimecombo.Items(0)


        Me.Show()
        SleepTimecombo.Focus()
        Do Until TimeOfDay.Ticks = 0 Or shutdownchk = True
            Application.DoEvents()
            CurrTimetxt.Text = TimeOfDay.ToLongTimeString
            CurrentTime = TimeOfDay.ToLongTimeString
        Loop

    End Sub

    Private Sub Exitbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exitbut.Click
        On Error Resume Next
        shutdownchk = True

        Shutdownfrm.Cancelbutcancel = True
        finalcancel = True
        Application.Exit()
    End Sub

    Private Sub SleepTimecombo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SleepTimecombo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SleepTimecombo_SelectedIndexChanged(SleepTimecombo, New EventArgs)
            Startbut_Click(Startbut, New EventArgs)
        End If
    End Sub

    Private Sub SleepTimecombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SleepTimecombo.SelectedIndexChanged
        ShutdownTimetxt.Text = CurrentTime.AddMinutes(Val(SleepTimecombo.Text)).ToLongTimeString
    End Sub

    Private Sub Startbut_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Startbut.TextChanged
        ' If Startbut.Text = "Start Timer" Then
        '    finalcancel = True
        'End If

    End Sub
End Class
