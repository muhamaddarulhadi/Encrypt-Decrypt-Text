Public Class frmMain

    Function EncryptDecrypt(ByVal text1 As String, ByVal key As String, ByVal isEncrypt As Boolean) As String
        Dim char1 As String
        Dim char2 As String
        Dim cKey As Byte
        Dim strLength As Integer
        Dim Result As String = ""
        Dim A As Integer = -1
        If text1 <> "" And IsNumeric(key) Then
            strLength = text1.Length
            For B As Integer = 0 To strLength - 1
                char1 = text1.Substring(B, 1)
                If A < key.Length - 1 Then
                    A = A + 1
                Else
                    A = 0
                End If
                cKey = Val(key.Substring(A, 1))
                If isEncrypt Then
                    char2 = Chr(Asc(char1) + cKey)
                Else
                    char2 = Chr(Asc(char1) - cKey)
                End If
                Result &= char2
            Next
        Else
            MsgBox("You must enter the SHIFT KEY first!")

        End If

        Return Result

    End Function


    Private Sub btCrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCrypt.Click
        txtResult.Text = EncryptDecrypt(txtText.Text, txtKey.Text, True)

    End Sub

    Private Sub btDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDecrypt.Click
        txtResult.Text = EncryptDecrypt(txtText.Text, txtKey.Text, False)
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ToolTip1 As New ToolTip()
        ToolTip1.ShowAlways = True
        ToolTip1.SetToolTip(txtKey, "You can enter the number that you want to put as a shift number")

        Dim ToolTip2 As New ToolTip()
        ToolTip2.ShowAlways = True
        ToolTip2.SetToolTip(txtText, "You can enter the text by typing or copying")

        Dim ToolTip3 As New ToolTip()
        ToolTip3.ShowAlways = True
        ToolTip3.SetToolTip(txtResult, "Show the result for encrypt and decrypt")

        Dim ToolTip4 As New ToolTip()
        ToolTip4.ShowAlways = True
        ToolTip4.SetToolTip(Label5, "You can clear all the data insert")

        Dim ToolTip5 As New ToolTip()
        ToolTip5.ShowAlways = True
        ToolTip5.SetToolTip(Label4, "You can go see the name creator of this program")

        Dim ToolTip6 As New ToolTip()
        ToolTip6.ShowAlways = True
        ToolTip6.SetToolTip(Label6, "You can close all the open window")

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        txtResult.Clear()
        txtKey.Clear()
        txtText.Clear()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form2.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Form1.Close()
        Form2.Close()
        Close()
    End Sub

End Class
