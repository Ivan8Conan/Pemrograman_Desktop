Public Class Form1
    Private valHolder1 As Double
    Private valHolder2 As Double
    Private tmpValue As Double
    Private hasDecimal As Boolean
    Private inputStatus As Boolean = True
    Private clearText As Boolean
    Private calcFunc As String
    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd1.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd1.Text
        Else
            txtInput.Text = Cmd1.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd2.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd2.Text
        Else
            txtInput.Text = Cmd2.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd3.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd3.Text
        Else
            txtInput.Text = Cmd3.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd4.Click
        If inputStatus = False Then
            txtInput.Text += Cmd4.Text
        Else
            txtInput.Text = Cmd4.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd5.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd5.Text
        Else
            txtInput.Text = Cmd5.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd6.Click
        If inputStatus = False Then
            txtInput.Text += Cmd6.Text
        Else
            txtInput.Text = Cmd6.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd7.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd7.Text
        Else
            txtInput.Text = Cmd7.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd8.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd8.Text
        Else
            txtInput.Text = Cmd8.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd9.Click
        If inputStatus = False Then
            txtInput.Text &= Cmd9.Text
        Else
            txtInput.Text = Cmd9.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd0.Click
        If inputStatus = False Then
            If txtInput.Text.Length >= 1 Then
                txtInput.Text &= Cmd0.Text
            End If
        End If
    End Sub
End Class
