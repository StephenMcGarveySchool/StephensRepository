Public Class Form1

    Dim y As Integer = 241
    Dim g As Integer = -5
    Dim frogleft As Boolean = False



    Private Sub picFrog_Click(sender As Object, e As EventArgs) Handles picFrog.Click





        tmrArc.Enabled = True
        tmrAnimate.Enabled = True

        My.Computer.Audio.Play(My.Resources.ribbit, AudioPlayMode.Background)

        lblRibbit.Visible = True
        tmrRibbet.Enabled = True







    End Sub

    Private Sub tmrRibbet_Tick(sender As Object, e As EventArgs) Handles tmrRibbet.Tick



        'hide the label after 1.5 seconds (1500 milliseconds...timer interval)
        lblRibbit.Visible = False
        'turn timer off because it’s job is done






    End Sub
    Private Sub tmrArc_Tick(sender As Object, e As EventArgs) Handles tmrArc.Tick


        picFrog.Left = picFrog.Left + 10
        g = g + 1
        y = y + g

        picFrog.Top = y
        If y = 241 Then
            g = -5
            tmrArc.Enabled = False
        End If



    End Sub

    Private Sub tmrAnimate_Tick(sender As Object, e As EventArgs) Handles tmrAnimate.Tick
        Static count As Integer = 0

        lblRibbit.Left = picFrog.Left + 50
        lblRibbit.Top = picFrog.Top - 40

        picFrog.Image = ilsFrog.Images(count)
        count = count + 1

        If count = 17 Then
            count = 0
            tmrAnimate.Enabled = False
            tmrRibbet.Enabled = False
        End If



    End Sub
End Class
