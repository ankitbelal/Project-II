Public Class forget_password

    Private Sub forget_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changepasswordpanel.Hide()
    End Sub

    Private Sub verifyotpbtn_Click(sender As Object, e As EventArgs) Handles verifyotpbtn.Click
        changepasswordpanel.Show()

    End Sub

    Private Sub backtologinbtn_Click(sender As Object, e As EventArgs) Handles backtologinbtn.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub cancelpasschangebtn_Click(sender As Object, e As EventArgs) Handles cancelpasschangebtn.Click
        forgetpassmainpanel.Show()
        changepasswordpanel.Hide()
    End Sub

    Private Sub emailbox_Enter(sender As Object, e As EventArgs) Handles emailbox.Enter
        If emailbox.Text = "Email_Address" Then
            emailbox.ForeColor = Color.Black
            emailbox.Text = ""
        End If
    End Sub

    Private Sub emailbox_Leave(sender As Object, e As EventArgs) Handles emailbox.Leave
        If emailbox.Text = "" Then
            emailbox.ForeColor = Color.DarkGray
            emailbox.Text = "Email_Address"
        End If
    End Sub
End Class