Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("You must enter the correct username and password!")

        Else

            If TextBox1.Text = "Hadi" And TextBox2.Text = "hadi" Then
                frmMain.Show()

            Else
                MsgBox("The username or password is wrong")

            End If

        End If

    End Sub
End Class