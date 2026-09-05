Public Class Shutdownfrm
    Public Shared Cancelbutcancel As Integer = False
    Private Sub Cancelbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelbut.Click
        Cancelbutcancel = True
        Shell("shutdown -a")
        Me.Close()
        Mainfrm.Show()
        Mainfrm.Startbut.Text = "Start Timer"

    End Sub

    Private Sub Shutdownfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        System.Diagnostics.Process.Start("shutdown", " -f -s -t 99")

        Secondslbl.Text = "99"
        Me.Show()

        Dim tmptime As Long = Environment.TickCount
        Dim tmpnum As Long = tmptime + 99000

        Do Until tmptime = tmpnum
            Application.DoEvents()
            Secondslbl.Text = Math.Round(((tmpnum - tmptime) / 1000))
            tmptime = Environment.TickCount
            If Cancelbutcancel = True Then
                Call Cancelbut_Click(Cancelbut, New EventArgs)
                Me.Close()
                Exit Sub
            End If
            If Mainfrm.finalcancel = True Then
                Cancelbutcancel = False
            End If
        Loop

    End Sub
End Class