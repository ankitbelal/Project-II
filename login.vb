Public Class login
    'while the login panel loads
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        defaultpasspanel.Hide()




    End Sub

    'is for the login button function
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If usernamebox.Text = "username" And passwordbox.Text = "password" Then
            defaultpasspanel.Show()
        End If
    End Sub

    'for designing the username textbox behave like real
    Private Sub usernamebox_Enter(sender As Object, e As EventArgs) Handles usernamebox.Enter
        If usernamebox.Text = "username" Then
            usernamebox.ForeColor = Color.Black
            usernamebox.Text = ""
        End If

    End Sub

    Private Sub usernamebox_Leave(sender As Object, e As EventArgs) Handles usernamebox.Leave
        If usernamebox.Text = "" Then
            usernamebox.ForeColor = Color.DarkGray
            usernamebox.Text = "username"
        End If

    End Sub

    'to design the password textbox behave like real
    Private Sub passwordbox_Leave(sender As Object, e As EventArgs) Handles passwordbox.Leave
        If passwordbox.Text = "" Then
            passwordbox.ForeColor = Color.DarkGray
            passwordbox.Text = "password"
            passwordbox.PasswordChar = ""
        End If
    End Sub

    Private Sub passwordbox_Enter(sender As Object, e As EventArgs) Handles passwordbox.Enter
        If passwordbox.Text = "password" Then
            passwordbox.ForeColor = Color.Black
            passwordbox.Text = ""
            passwordbox.PasswordChar = "*"

        End If
    End Sub

    'for hiding and showing password with eye icon

    Private Sub showpassbtn_Click(sender As Object, e As EventArgs) Handles showpassbtn.Click

        passwordbox.PasswordChar = ""
        showpassbtn.Hide()
        hidepassbtn.Show()

    End Sub
    Private Sub hidepassbtn_Click(sender As Object, e As EventArgs) Handles hidepassbtn.Click
        passwordbox.PasswordChar = "*"
        hidepassbtn.Hide()
        showpassbtn.Show()
    End Sub

    'when the username box load 
    Private Sub usernamebox_Load(sender As Object, e As EventArgs) Handles usernamebox.Load
        usernamebox.ForeColor = Color.DarkGray
        usernamebox.Text = "username"
    End Sub

    'when the password box load
    Private Sub passwordbox_Load(sender As Object, e As EventArgs) Handles passwordbox.Load
        passwordbox.ForeColor = Color.DarkGray
        passwordbox.Text = "password"
    End Sub



    'for the pannel of default password change

    'make the username box in default password change panel behave like real
    Private Sub changeusernamebox_Leave(sender As Object, e As EventArgs) Handles changeusernamebox.Leave
        If changeusernamebox.Text = "" Then
            changeusernamebox.ForeColor = Color.DarkGray
            changeusernamebox.Text = "New_username"

        End If

    End Sub

    Private Sub changeusernamebox_Enter(sender As Object, e As EventArgs) Handles changeusernamebox.Enter
        If changeusernamebox.Text = "New_username" Then
            changeusernamebox.ForeColor = Color.Black
            changeusernamebox.Text = ""
        End If
    End Sub

    'what to show when usernamebox load
    Private Sub changeusernamebox_Load(sender As Object, e As EventArgs) Handles changeusernamebox.Load
        changeusernamebox.ForeColor = Color.DarkGray
        changeusernamebox.Text = "New_username"
    End Sub


    'for what to show when password box loads
    Private Sub changepasswordbox_Load(sender As Object, e As EventArgs) Handles changepasswordbox.Load
        changepasswordbox.ForeColor = Color.DarkGray
        changepasswordbox.Text = "New_password"

    End Sub

    'makes password box behave like real
    Private Sub changepasswordbox_Enter(sender As Object, e As EventArgs) Handles changepasswordbox.Enter
        If changepasswordbox.Text = "New_password" Then
            changepasswordbox.ForeColor = Color.Black
            changepasswordbox.Text=""
        End If
    End Sub

    Private Sub changepasswordbox_Leave(sender As Object, e As EventArgs) Handles changepasswordbox.Leave
        If changepasswordbox.Text = "" Then
            changepasswordbox.ForeColor = Color.DarkGray
            changepasswordbox.Text = "New_password"
        End If
    End Sub


    'same for repeat password box
    Private Sub changepassbox2_Load(sender As Object, e As EventArgs) Handles changepassbox2.Load
        changepassbox2.ForeColor = Color.DarkGray
        changepassbox2.Text = "Repeat_password"

    End Sub

    Private Sub changepasswordbox2_Enter(sender As Object, e As EventArgs) Handles changepassbox2.Enter
        If changepasswordbox.Text = "Repeat_password" Then

            changepassbox2.Text = ""
            changepassbox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub changepasswordbox2_Leave(sender As Object, e As EventArgs) Handles changepassbox2.Leave
        If changepassbox2.Text = "" Then
            changepassbox2.ForeColor = Color.DarkGray
            changepassbox2.Text = "Repeat_password"
        End If
    End Sub

    'to make the text in password box autohide
    Private Sub changepassbox2_GotFocus(sender As Object, e As EventArgs) Handles changepassbox2.GotFocus
        changepassbox2.ForeColor = Color.Black
        changepassbox2.Text = ""
    End Sub


End Class

