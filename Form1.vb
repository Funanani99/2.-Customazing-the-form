Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My first App in 2023"
        Me.BackColor = Color.Blue
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Size = New Size(800, 800)
        Me.Opacity = 0.85 ' make it a bit transparent
        Me.CenterToParent() ' centers the execution box

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnFunananiRaphulu.Click
        MsgBox("This is Funanani Phulu-Ntsu",, "Hi")
    End Sub
End Class
