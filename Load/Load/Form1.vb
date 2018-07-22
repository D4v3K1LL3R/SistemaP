Public Class Form1
    Dim contador As Byte = 4

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Opacity -= 0.07
            If Me.Opacity = 0.0 Then
                Me.Hide()
                'Login.show()
                Timer1.Enabled = False
            End If
        Else
            ProgressBar1.Value += 4
            If ProgressBar1.Value = contador Then
                Label1.Text = "INICIANDO..."
            Else
                If ProgressBar1.Value = contador + 16 Then
                    Label1.Text = "INICIANDO.."
                    contador += 20
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
    End Sub
End Class
